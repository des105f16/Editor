using System.Drawing;
using System.IO;

using SablePP.Tools.Nodes;

using DLM.Editor.Lexing;
using DLM.Editor.Nodes;
using DLM.Editor.Parsing;

using FastColoredTextBoxNS;

namespace DLM.Editor
{
    public partial class CompilerExecuter : SablePP.Tools.CompilerExecuter<PRoot, Lexer, Parser>
    {
        public override Lexer GetLexer(TextReader reader)
        {
            return new Lexer(reader);
        }
        
        public override Parser GetParser(SablePP.Tools.Lexing.ILexer lexer)
        {
            return new Parser(lexer);
        }
        
        public override Style GetSimpleStyle(Token token)
        {
            if (token is TIdentifier)
                return style1;
            if (token is TComment)
                return style2;
            if (token is TIf || token is TElse || token is TWhile || token is TReturn || token is TActfor)
                return style3;
            if (token is TLabelStart || token is TLabelEnd)
                return style4;
            return null;
        }
        private TextStyle style1 = new TextStyle(new SolidBrush(Color.FromArgb(0, 102, 153)), null, FontStyle.Regular);
        private TextStyle style2 = new TextStyle(new SolidBrush(Color.FromArgb(0, 102, 0)), null, FontStyle.Italic);
        private TextStyle style3 = new TextStyle(new SolidBrush(Color.FromArgb(0, 0, 204)), null, FontStyle.Bold);
        private TextStyle style4 = new TextStyle(new SolidBrush(Color.FromArgb(204, 153, 0)), null, FontStyle.Bold);
    }
}
