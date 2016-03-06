﻿using DLM.Editor.Analysis;
using System.Collections.Generic;
using DLM.Editor.Nodes;
using DLM.Inference;
using SablePP.Tools.Error;
using SablePP.Tools;

namespace DLM.Editor
{
    public class LabelExtractor : DepthFirstAdapter
    {
        private ErrorManager errorManager;
        private Dictionary<string, Principal> principals;
        private ScopedDictionary<string, Label> namedLabels;

        public LabelExtractor(ErrorManager errorManager)
        {
            this.errorManager = errorManager;
            this.principals = new Dictionary<string, Principal>();
            this.namedLabels = new ScopedDictionary<string, Label>();
        }

        protected override void HandlePRoot(PRoot node)
        {
            foreach (var p in node.PrincipalDeclarations)
            {
                string name = p.Name.Text;
                if (principals.ContainsKey(name))
                    errorManager.Register(p, $"The principal {name} has already been defined.");
                else
                    principals.Add(name, new Principal(name));
            }

            // Stop validation if there were errors
            if (errorManager.Errors.Count > 0)
                return;

            Visit(node.Structs);
            Visit(node.Statements);

            // Stop validation if there were errors
            if (errorManager.Errors.Count > 0)
                return;
        }

        protected override void HandlePStruct(PStruct node)
        {
            foreach (var field in node.Fields)
            {
                Visit(field.Type);

                if (field.Type.DeclaredLabel == null)
                    field.Type.DeclaredLabel = Label.LowerBound;
            }
        }

        protected override void HandleADeclarationStatement(ADeclarationStatement node)
        {
            Visit(node.Type);

            if (node.Type.DeclaredLabel == null)
                node.Type.DeclaredLabel = new VariableLabel(node.Identifier.Text);

            namedLabels.Add(node.Identifier.Text, node.Type.DeclaredLabel);
        }
        protected override void HandleAArrayDeclarationStatement(AArrayDeclarationStatement node)
        {
            Visit(node.Type);

            if (node.Type.DeclaredLabel == null)
                node.Type.DeclaredLabel = new VariableLabel(node.Identifier.Text);

            namedLabels.Add(node.Identifier.Text, node.Type.DeclaredLabel);
        }

        protected override void HandleAType(AType node)
        {
            if (node.HasLabel)
                Visit(node.Label);

            node.DeclaredLabel = Output[node.Label] as Label;
        }
        protected override void HandleAPointerType(APointerType node)
        {
            Visit(node.Type);

            node.DeclaredLabel = node.Type.DeclaredLabel;
        }

        protected override void HandlePLabel(PLabel node)
        {
            Label lbl = Label.LowerBound;

            foreach (var p in node.Policys)
            {
                Visit(p);
                Label plbl = Output[p] as Label;

                if (plbl != null)
                    lbl += plbl;
            }

            Output[node] = lbl;
        }
        protected override void HandleAVariablePolicy(AVariablePolicy node)
        {
            Label lbl;
            if (!namedLabels.TryGetValue(node.Identifier.Text, out lbl, false))
            {
                errorManager.Register(node, $"Unknown reference \"{node.Identifier.Text}\".");
                Output[node] = null;
            }
            else
                Output[node] = lbl;
        }
        protected override void HandleAPrincipalPolicy(APrincipalPolicy node)
        {
            Label lbl = null;
            if (node.Owner is ALowerPrincipal)
            {
                if (node.Readers.Count != 1 || !(node.Readers[0] is AUpperPrincipal))
                    errorManager.Register(node, "A policy with no owners must specify * for its readers.");
                else
                    lbl = Label.LowerBound;
            }
            else if (node.Owner is AUpperPrincipal)
            {
                if (node.Readers.Count != 1 || !(node.Readers[0] is ALowerPrincipal))
                    errorManager.Register(node, "A policy with all principals as owners must specify _ for its readers.");
                else
                    lbl = Label.UpperBound;
            }
            else
            {
                var ownerName = (node.Owner as APrincipal).Identifier.Text;
                Principal owner;

                if (!principals.TryGetValue(ownerName, out owner))
                    errorManager.Register(node.Owner, $"Use of undeclared principal {ownerName}.");

                List<Principal> readers = new List<Principal>();
                foreach (var reader in node.Readers)
                {
                    if (reader is ALowerPrincipal)
                        continue;
                    else if (reader is AUpperPrincipal)
                        errorManager.Register(reader, "Only a _ owner can specify the * reader-set.");
                    else
                    {
                        string name = (reader as APrincipal).Identifier.Text;
                        Principal r;

                        if (!principals.TryGetValue(name, out r))
                            errorManager.Register(node.Owner, $"Use of undeclared principal {name}.");
                        else
                            readers.Add(r);
                    }
                }

                if (owner != null)
                    lbl = new PolicyLabel(
                        new Policy(owner, readers));
            }

            Output[node] = lbl;
        }
    }
}
