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

namespace DLM.Editor
{
    public partial class CompilerExecuter
    {
        public override void Validate(Start<PRoot> root, CompilationOptions compilationOptions)
        {
            compilationOptions.Highlight(new TypeHighlighter());

            Validator v = new Validator(root, compilationOptions);

            v.CompileWithGCC();
            if (v.Errors)
                return;

            v.ExtractLabels();
            if (v.Errors)
                return;

            v.InferLabels();
            if (v.Errors)
                return;
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

            public void ExtractLabels()
            {
                LabelExtractor le = new LabelExtractor(errorManager);
                le.Visit(root);
            }
            public void InferLabels()
            {
                LabelInferer le = new LabelInferer(errorManager);
                le.Visit(root);
            }
        }

        private class TypeHighlighter : IHighlighter
        {
            private Style style = new TextStyle(System.Drawing.Brushes.Blue, null, System.Drawing.FontStyle.Bold);

            public Style GetStyle(Token token)
            {
                if (!(token is TIdentifier))
                    return null;

                var par = token.GetParent().GetType().Name;

                if (token.GetParent() is PType || token.GetParent() is PStruct)
                    return style;
                else
                    return null;
            }
        }
    }
}
