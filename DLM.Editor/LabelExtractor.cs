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

        protected override void HandleAFunctionDeclarationStatement(AFunctionDeclarationStatement node)
        {
            namedLabels.OpenScope();

            foreach (var par in node.Parameters)
            {
                Visit(par.Type);

                if (par.Type.DeclaredLabel == null)
                    par.Type.DeclaredLabel = new ConstantLabel(par.Identifier.Text);

                namedLabels.Add(par.Identifier.Text, par.Type.DeclaredLabel);
            }

            Visit(node.Type);
            if (node.Type.DeclaredLabel == null)
                node.Type.DeclaredLabel = Label.LowerBound;

            if (errorManager.Errors.Count > 0)
            {
                namedLabels.CloseScope();
                return;
            }

            Visit(node.Statements);

            namedLabels.CloseScope();
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
            var ownerName = (node.Owner as APrincipal).Identifier.Text;
            Principal owner;

            if (!principals.TryGetValue(ownerName, out owner))
                errorManager.Register(node.Owner, $"Use of undeclared principal {ownerName}.");

            List<Principal> readers = new List<Principal>();
            foreach (var reader in node.Readers)
            {
                string name = (reader as APrincipal).Identifier.Text;
                Principal r;

                if (!principals.TryGetValue(name, out r))
                    errorManager.Register(node.Owner, $"Use of undeclared principal {name}.");
                else
                    readers.Add(r);
            }

            if (owner != null)
                Output[node] = new PolicyLabel(new Policy(owner, readers));
        }
    }
}
