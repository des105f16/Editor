#define GRAPH_OFF

using DLM.Inference;
using SablePP.Tools.Editor;
using SablePP.Tools.Generate;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
#if !GRAPH
using System.Windows.Forms;
#endif

namespace DLM.Editor
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
#if GRAPH
            PatchElement graph = new PatchElement();
            PatchElement nodes = new PatchElement();
            PatchElement links = new PatchElement();

            graph.EmitLine("digraph G {");
            graph.IncreaseIndentation();
            graph.InsertElement(nodes);
            graph.InsertElement(links);
            graph.DecreaseIndentation();
            graph.EmitLine("}");

            Principal a = new Principal("a"), b = new Principal("b");
            List<Label> labels = new List<Label>(getLabels(a, b));

            for (int i = 0; i < labels.Count; i++)
                nodes.EmitLine($"l{i} [label=\"{labels[i].ToString().Replace('\u2205', 'Ø')}\"];");

            for (int i = 0; i < labels.Count - 1; i++)
                for (int j = i + 1; j < labels.Count; j++)
                {
                    var v = labels[i] + labels[j];
                    var index = labels.IndexOf(v);

                    if (index >= 0 && index != i && index != j)
                    {
                        links.EmitLine($"l{i}->l{index};");
                        links.EmitLine($"l{j}->l{index};");
                    }

                    v = labels[i] - labels[j];
                    index = labels.IndexOf(v);

                    if (index >= 0 && index != i && index != j)
                    {
                        links.EmitLine($"l{index}->l{i};");
                        links.EmitLine($"l{index}->l{j};");
                    }
                }

            var graph2 =
@"graph G {
    run [label=""Break in and steal""];
    run -- intr;
	intr -- runbl;
	runbl -- run;
	run -- kernel;
	kernel -- zombie;
	kernel -- sleep;
	kernel -- runmem;
	sleep -- q;
	q -- runswap;
	runswap -- new;
	runswap -- runmem;
	new -- runmem;
	sleep -- runmem;
}";
            dot(graph, @"""C:\Users\Mikkel\Downloads\graphviz-2.38\bleh.pdf""");
#else
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Editor());
#endif
        }
#if GRAPH
        static void dot(CodeElement code, string outputPath)
        {
            dot(code.ToString("  "), outputPath);
        }
        static void dot(string graph, string outputPath)
        {
            var filepath = Path.GetTempFileName();
            File.WriteAllText(filepath, graph);

            ProcessStartInfo psi = new ProcessStartInfo(@"C:\Users\Mikkel\Downloads\graphviz-2.38\release\bin\dot.exe")
            {
                Arguments = "-o" + outputPath + " -Tpdf " + filepath
            };

            using (var p = Process.Start(psi))
                p.WaitForExit();
        }

        static IEnumerable<Label> getLabels(Principal a, Principal b)
        {
            var readers = powerSet(new Principal[] { a, b });

            foreach (var rA in readers)
                foreach (var rB in readers)
                    yield return new PolicyLabel(new Policy(a, rA), new Policy(b, rB));
        }

        static T[][] powerSet<T>(T[] seq)
        {
            var powerSet = new T[1 << seq.Length][];
            powerSet[0] = new T[0]; // starting only with empty set
            for (int i = 0; i < seq.Length; i++)
            {
                var cur = seq[i];
                int count = 1 << i; // doubling list each time
                for (int j = 0; j < count; j++)
                {
                    var source = powerSet[j];
                    var destination = powerSet[count + j] = new T[source.Length + 1];
                    for (int q = 0; q < source.Length; q++)
                        destination[q] = source[q];
                    destination[source.Length] = cur;
                }
            }
            return powerSet;
        }
#endif
    }
}
