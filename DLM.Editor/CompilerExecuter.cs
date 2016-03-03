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

namespace DLM.Editor
{
    public partial class CompilerExecuter
    {
        public override void Validate(Start<PExpression> root, CompilationOptions compilationOptions)
        {
            CompileWithGCC(root, compilationOptions.ErrorManager);
            
            base.Validate(root, compilationOptions);
        }
        
        private static void CompileWithGCC(Node root, ErrorManager errors)
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
                    errors.Register(e);
                }
            }
        }
    }
}
