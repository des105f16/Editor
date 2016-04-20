using System.Collections.Generic;
using DLM.Compiler.Nodes;
using SablePP.Tools;
using SablePP.Tools.Nodes;
using SablePP.Tools.Error;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using System.IO;
using FastColoredTextBoxNS;
using DLM.Inference;
using System.Drawing;
using System;

namespace DLM.Compiler
{
    public partial class CompilerExecuter
    {
        private InferenceResult<NodeConstraint> result;
        public InferenceResult<NodeConstraint> Result => result;

        public override void Validate(Start<PRoot> root, CompilationOptions compilationOptions)
        {
            compilationOptions.Highlight(new TypeHighlighter(this));

            Validator v = new Validator(root, compilationOptions);

            result = null;

            v.CompileWithGCC(compilationOptions.Input);
            if (v.Errors)
                return;

            v.ExtractPrincipals();
            if (v.Errors)
                return;

            v.ExtractLabels();
            if (v.Errors)
                return;

            var vars = v.InferLabels();
            if (!vars.Succes)
            {
                var fail = vars.ResolveSteps.Last();
                compilationOptions.ErrorManager.Register(fail.Constraint.MarkedOrigin ?? fail.Constraint.Origin, "Failed to validate labels, see details.");
            }

            result = vars;
        }

        private class Validator
        {
            private ValidationData data;

            private readonly Start<PRoot> root;
            private readonly CompilationOptions compilationOptions;
            private ErrorManager errorManager => compilationOptions.ErrorManager;

            private Dictionary<string, Principal> principals;

            public Validator(Start<PRoot> root, CompilationOptions compilationOptions)
            {
                this.data = new ValidationData();

                this.root = root;
                this.compilationOptions = compilationOptions;

                this.principals = new Dictionary<string, Principal>();
            }

            public bool Errors => compilationOptions.ErrorManager.Errors.Count > 0;

            public void CompileWithGCC(string source)
            {
                var file = Path.GetTempFileName();
                File.WriteAllText(file, CGenerator.GenerateC(root, source));

                ProcessStartInfo psi = new ProcessStartInfo(@"C:\MinGW\bin\gcc.exe", "-std=c99 -pedantic-errors -x c \"" + file + "\"")
                {
                    CreateNoWindow = true,
                    RedirectStandardError = true,
                    UseShellExecute = false
                };

                psi.CreateNoWindow = true;

                string[] lines;

                using (var p = Process.Start(psi))
                {
                    p.WaitForExit();
                    lines = p.StandardError.ReadToEnd().Split('\r', '\n');
                }

                foreach (var l in lines)
                {
                    var m = Regex.Match(l, @"\:(?<line>[0-9]+)\:(?<pos>[0-9]+)\:(?<message>[^\n\r]+)");
                    if (m.Success)
                    {
                        int line = int.Parse(m.Groups["line"].Value);
                        int pos = int.Parse(m.Groups["pos"].Value);
                        string message = m.Groups["message"].Value.Trim();

                        ErrorType type = ErrorType.Error;

                        var typeStr = Regex.Match(message, "(?<type>error): (?<message>[^\n\r]+)");
                        if (typeStr.Success)
                        {
                            type = ErrorType.Error;
                            message = typeStr.Groups["message"].Value.Trim();
                        }

                        CompilerError e = new CompilerError(ErrorType.Error, new Position(line, pos), new Position(line, pos), "GCC; " + message);
                        errorManager.Register(e);
                    }
                }
            }

            public void ExtractPrincipals()
            {
                PrincipalExtractor pe = new PrincipalExtractor(errorManager);
                pe.Visit(root);

                principals = pe.Principals;
            }

            public void ExtractLabels()
            {
                LabelDecorator le = new LabelDecorator(errorManager, principals);
                le.Visit(root);
            }

            public InferenceResult<NodeConstraint> InferLabels()
            {
                ConstraintExtractor le = new ConstraintExtractor(errorManager);
                le.Visit(root);
                return Inference.ConstraintResolver<NodeConstraint>.Resolve((o, l, r) => new NodeConstraint(l, r, o.MarkedOrigin, o.Origin, o.OriginType), le.Constraints);
            }
        }

        private static Brush fromRgb(int rgb)
        {
            var r = (rgb >> 16) & 255;
            var g = (rgb >> 8) & 255;
            var b = (rgb >> 0) & 255;

            return new SolidBrush(Color.FromArgb(r, g, b));
        }

        private class TypeHighlighter : IHighlighter
        {
            private static Style typestyle;
            private static Style principalstyle;
            private static Style varpolicystyle;

            public TypeHighlighter(CompilerExecuter executor)
            {
                typestyle = executor.style2;
                principalstyle = executor.style3;
                varpolicystyle = new TextStyle(executor.style3.ForeBrush, executor.style3.BackgroundBrush, FontStyle.Bold | FontStyle.Underline);
            }

            public Style GetStyle(Token token)
            {
                if (!(token is TIdentifier))
                    return null;

                var par = token.GetParent().GetType().Name;

                if (token.GetParent() is PType || token.GetParent() is PStruct)
                    return typestyle;
                else if (token.GetParent() is PPrincipal)
                    return principalstyle;
                else if (token.GetParent() is AVariablePolicy)
                    return varpolicystyle;
                else
                    return null;
            }
        }
    }
}
