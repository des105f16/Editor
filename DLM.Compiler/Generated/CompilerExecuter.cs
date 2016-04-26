using System.Drawing;
using System.IO;

using SablePP.Tools.Nodes;

using DLM.Compiler.Lexing;
using DLM.Compiler.Nodes;
using DLM.Compiler.Parsing;

using FastColoredTextBoxNS;

namespace DLM.Compiler
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
            if (token is TChar || token is TString || token is TCharErr || token is TStringErr)
                return style2;
            if (token is TIf || token is TElse || token is TWhile || token is TReturn || token is TTypedef || token is TStruct)
                return style3;
            if (token is TLabelStart || token is TLabelEnd || token is TActsFor || token is TIfActsFor || token is TDeclassifyStart || token is TDeclassifyEnd || token is TFuncAuthStart || token is TFuncAuthEnd || token is TRArrow || token is TJoin || token is TPrincipall || token is TThis || token is TCaller || token is TTimeStart || token is TTime || token is TIntervalUnit || token is TUnderscore || token is THat)
                return style4;
            return null;
        }
        private TextStyle style1 = new TextStyle(new SolidBrush(Color.FromArgb(73, 139, 61)), null, FontStyle.Italic);
        private TextStyle style2 = new TextStyle(new SolidBrush(Color.FromArgb(214, 76, 65)), null, FontStyle.Regular);
        private TextStyle style3 = new TextStyle(new SolidBrush(Color.FromArgb(36, 126, 175)), null, FontStyle.Bold);
        private TextStyle style4 = new TextStyle(new SolidBrush(Color.FromArgb(177, 17, 217)), null, FontStyle.Bold);
    }
}
