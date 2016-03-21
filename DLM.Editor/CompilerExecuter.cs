using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLM.Editor.Nodes;
using SablePP.Tools;
using SablePP.Tools.Nodes;
using SablePP.Tools.Error;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.IO;
using FastColoredTextBoxNS;
using DLM.Inference;
using System.Drawing;

namespace DLM.Editor
{
    public partial class CompilerExecuter
    {
        private InferenceResult result;
        public InferenceResult Result => result;

        public override void Validate(Start<PRoot> root, CompilationOptions compilationOptions)
        {
            compilationOptions.Highlight(new TypeHighlighter());

            Validator v = new Validator(root, compilationOptions);

            v.CompileWithGCC();
            if (v.Errors)
                return;

            v.ExtractPrincipals();
            if (v.Errors)
                return;

            v.ExtractLabels();
            if (v.Errors)
                return;

            v.ExtractElementLabels();
            if (v.Errors)
                return;

            var vars = v.InferLabels();
            if (v.Errors)
                return;

            result = vars;
        }

        private class Validator
        {
            private ValidationData data;

            private readonly Start<PRoot> root;
            private readonly CompilationOptions compilationOptions;
            private ErrorManager errorManager => compilationOptions.ErrorManager;

            public Validator(Start<PRoot> root, CompilationOptions compilationOptions)
            {
                this.data = new ValidationData();

                this.root = root;
                this.compilationOptions = compilationOptions;
            }

            public bool Errors => compilationOptions.ErrorManager.Errors.Count > 0;

            public void CompileWithGCC()
            {
                var file = Path.GetTempFileName();
                File.WriteAllText(file, CGenerator.GenerateC(root));

                ProcessStartInfo psi = new ProcessStartInfo(@"C:\MinGW\bin\gcc.exe", "-x c \"" + file + "\"")
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
                PrincipalExtractor pe = new PrincipalExtractor();
            }

            public void ExtractLabels()
            {
                LabelExtractor le = new LabelExtractor(errorManager);
                le.Visit(root);
            }
            public InferenceResult InferLabels()
            {
                LabelInferer le = new LabelInferer(errorManager);
                le.Visit(root);
                return Inference.ConstraintResolver.Resolve(le.Constraints);
            }

            public void ExtractElementLabels()
            {
                ElementLabelExtractor ele = new ElementLabelExtractor(errorManager);
                ele.Visit(root);
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
            private static Style typestyle = new TextStyle(fromRgb(0x0000cc), null, FontStyle.Bold);
            private static Style principalstyle = new TextStyle(fromRgb(0x8d19aa), null, FontStyle.Bold);
            private static Style varpolicystyle = new TextStyle(fromRgb(0x8d19aa), null, FontStyle.Bold | FontStyle.Underline);

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
