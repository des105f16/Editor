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
            if (token is TComment)
                return style1;
            if (token is TIf || token is TElse || token is TWhile || token is TReturn || token is TTypedef || token is TStruct)
                return style2;
            if (token is TLabelStart || token is TLabelEnd || token is TActsFor || token is TDeclassifyStart || token is TDeclassifyEnd || token is TRArrow || token is TJoin || token is TPrincipall || token is TThis || token is TCaller)
                return style3;
            return null;
        }
        private TextStyle style1 = new TextStyle(new SolidBrush(Color.FromArgb(51, 153, 51)), null, FontStyle.Italic);
        private TextStyle style2 = new TextStyle(new SolidBrush(Color.FromArgb(0, 0, 204)), null, FontStyle.Bold);
        private TextStyle style3 = new TextStyle(new SolidBrush(Color.FromArgb(141, 25, 170)), new SolidBrush(Color.FromArgb(230, 231, 250)), FontStyle.Bold);
    }
}
