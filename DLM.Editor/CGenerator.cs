using System;
using System.Linq;
using SablePP.Tools.Nodes;
using DLM.Editor.Nodes;
using System.Collections.Generic;

namespace DLM.Editor
{
    public class CGenerator : Analysis.DepthFirstAdapter
    {
        private readonly SearchableString text;

        private CGenerator(string source)
        {
            this.text = new SearchableString(source, "\r\n");
        }

        public static string GenerateC(Node node, string source)
        {
            CGenerator gen = new CGenerator(source);

            gen.Visit((dynamic)node);

            return gen.text.ToString();
        }
    }
}
