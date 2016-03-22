using System;
using System.Collections.Generic;
using SablePP.Tools.Nodes;
using DLM.Editor.Analysis;

namespace DLM.Editor.Nodes
{
    public partial class TInclude : Token<TInclude>
    {
        public TInclude()
            : base(@"#include")
        {
        }
        public TInclude(int line, int pos)
            : base(@"#include", line, pos)
        {
        }
        public TInclude(string text)
            : base(text)
        {
        }
        public TInclude(string text, int line, int pos)
            : base(text, line, pos)
        {
        }
        
        public override TInclude Clone()
        {
            return new TInclude(Text, Line, Position);
        }
    }
    public partial class TFile : Token<TFile>
    {
        public TFile(string text)
            : base(text)
        {
        }
        public TFile(string text, int line, int pos)
            : base(text, line, pos)
        {
        }
        
        public override TFile Clone()
        {
            return new TFile(Text, Line, Position);
        }
    }
    public partial class TBool : Token<TBool>
    {
        public TBool(string text)
            : base(text)
        {
        }
        public TBool(string text, int line, int pos)
            : base(text, line, pos)
        {
        }
        
        public override TBool Clone()
        {
            return new TBool(Text, Line, Position);
        }
    }
    public partial class TNumber : Token<TNumber>
    {
        public TNumber(string text)
            : base(text)
        {
        }
        public TNumber(string text, int line, int pos)
            : base(text, line, pos)
        {
        }
        
        public override TNumber Clone()
        {
            return new TNumber(Text, Line, Position);
        }
    }
    public partial class TPrincipall : Token<TPrincipall>
    {
        public TPrincipall()
            : base(@"principal")
        {
        }
        public TPrincipall(int line, int pos)
            : base(@"principal", line, pos)
        {
        }
        public TPrincipall(string text)
            : base(text)
        {
        }
        public TPrincipall(string text, int line, int pos)
            : base(text, line, pos)
        {
        }
        
        public override TPrincipall Clone()
        {
            return new TPrincipall(Text, Line, Position);
        }
    }
    public partial class TTypedef : Token<TTypedef>
    {
        public TTypedef()
            : base(@"typedef")
        {
        }
        public TTypedef(int line, int pos)
            : base(@"typedef", line, pos)
        {
        }
        public TTypedef(string text)
            : base(text)
        {
        }
        public TTypedef(string text, int line, int pos)
            : base(text, line, pos)
        {
        }
        
        public override TTypedef Clone()
        {
            return new TTypedef(Text, Line, Position);
        }
    }
    public partial class TStruct : Token<TStruct>
    {
        public TStruct()
            : base(@"struct")
        {
        }
        public TStruct(int line, int pos)
            : base(@"struct", line, pos)
        {
        }
        public TStruct(string text)
            : base(text)
        {
        }
        public TStruct(string text, int line, int pos)
            : base(text, line, pos)
        {
        }
        
        public override TStruct Clone()
        {
            return new TStruct(Text, Line, Position);
        }
    }
    public partial class TWhile : Token<TWhile>
    {
        public TWhile()
            : base(@"while")
        {
        }
        public TWhile(int line, int pos)
            : base(@"while", line, pos)
        {
        }
        public TWhile(string text)
            : base(text)
        {
        }
        public TWhile(string text, int line, int pos)
            : base(text, line, pos)
        {
        }
        
        public override TWhile Clone()
        {
            return new TWhile(Text, Line, Position);
        }
    }
    public partial class TIf : Token<TIf>
    {
        public TIf()
            : base(@"if")
        {
        }
        public TIf(int line, int pos)
            : base(@"if", line, pos)
        {
        }
        public TIf(string text)
            : base(text)
        {
        }
        public TIf(string text, int line, int pos)
            : base(text, line, pos)
        {
        }
        
        public override TIf Clone()
        {
            return new TIf(Text, Line, Position);
        }
    }
    public partial class TElse : Token<TElse>
    {
        public TElse()
            : base(@"else")
        {
        }
        public TElse(int line, int pos)
            : base(@"else", line, pos)
        {
        }
        public TElse(string text)
            : base(text)
        {
        }
        public TElse(string text, int line, int pos)
            : base(text, line, pos)
        {
        }
        
        public override TElse Clone()
        {
            return new TElse(Text, Line, Position);
        }
    }
    public partial class TReturn : Token<TReturn>
    {
        public TReturn()
            : base(@"return")
        {
        }
        public TReturn(int line, int pos)
            : base(@"return", line, pos)
        {
        }
        public TReturn(string text)
            : base(text)
        {
        }
        public TReturn(string text, int line, int pos)
            : base(text, line, pos)
        {
        }
        
        public override TReturn Clone()
        {
            return new TReturn(Text, Line, Position);
        }
    }
    public partial class TThis : Token<TThis>
    {
        public TThis()
            : base(@"this")
        {
        }
        public TThis(int line, int pos)
            : base(@"this", line, pos)
        {
        }
        public TThis(string text)
            : base(text)
        {
        }
        public TThis(string text, int line, int pos)
            : base(text, line, pos)
        {
        }
        
        public override TThis Clone()
        {
            return new TThis(Text, Line, Position);
        }
    }
    public partial class TCaller : Token<TCaller>
    {
        public TCaller()
            : base(@"caller")
        {
        }
        public TCaller(int line, int pos)
            : base(@"caller", line, pos)
        {
        }
        public TCaller(string text)
            : base(text)
        {
        }
        public TCaller(string text, int line, int pos)
            : base(text, line, pos)
        {
        }
        
        public override TCaller Clone()
        {
            return new TCaller(Text, Line, Position);
        }
    }
    public partial class TIdentifier : Token<TIdentifier>
    {
        public TIdentifier(string text)
            : base(text)
        {
        }
        public TIdentifier(string text, int line, int pos)
            : base(text, line, pos)
        {
        }
        
        public override TIdentifier Clone()
        {
            return new TIdentifier(Text, Line, Position);
        }
    }
    public partial class TActsFor : Token<TActsFor>
    {
        public TActsFor()
            : base(@"-->")
        {
        }
        public TActsFor(int line, int pos)
            : base(@"-->", line, pos)
        {
        }
        public TActsFor(string text)
            : base(text)
        {
        }
        public TActsFor(string text, int line, int pos)
            : base(text, line, pos)
        {
        }
        
        public override TActsFor Clone()
        {
            return new TActsFor(Text, Line, Position);
        }
    }
    public partial class TIfActsFor : Token<TIfActsFor>
    {
        public TIfActsFor(string text)
            : base(text)
        {
        }
        public TIfActsFor(string text, int line, int pos)
            : base(text, line, pos)
        {
        }
        
        public override TIfActsFor Clone()
        {
            return new TIfActsFor(Text, Line, Position);
        }
    }
    public partial class TDeclassifyStart : Token<TDeclassifyStart>
    {
        public TDeclassifyStart()
            : base(@"<|")
        {
        }
        public TDeclassifyStart(int line, int pos)
            : base(@"<|", line, pos)
        {
        }
        public TDeclassifyStart(string text)
            : base(text)
        {
        }
        public TDeclassifyStart(string text, int line, int pos)
            : base(text, line, pos)
        {
        }
        
        public override TDeclassifyStart Clone()
        {
            return new TDeclassifyStart(Text, Line, Position);
        }
    }
    public partial class TDeclassifyEnd : Token<TDeclassifyEnd>
    {
        public TDeclassifyEnd()
            : base(@"|>")
        {
        }
        public TDeclassifyEnd(int line, int pos)
            : base(@"|>", line, pos)
        {
        }
        public TDeclassifyEnd(string text)
            : base(text)
        {
        }
        public TDeclassifyEnd(string text, int line, int pos)
            : base(text, line, pos)
        {
        }
        
        public override TDeclassifyEnd Clone()
        {
            return new TDeclassifyEnd(Text, Line, Position);
        }
    }
    public partial class TRArrow : Token<TRArrow>
    {
        public TRArrow()
            : base(@"->")
        {
        }
        public TRArrow(int line, int pos)
            : base(@"->", line, pos)
        {
        }
        public TRArrow(string text)
            : base(text)
        {
        }
        public TRArrow(string text, int line, int pos)
            : base(text, line, pos)
        {
        }
        
        public override TRArrow Clone()
        {
            return new TRArrow(Text, Line, Position);
        }
    }
    public partial class TLArrow : Token<TLArrow>
    {
        public TLArrow()
            : base(@"<-")
        {
        }
        public TLArrow(int line, int pos)
            : base(@"<-", line, pos)
        {
        }
        public TLArrow(string text)
            : base(text)
        {
        }
        public TLArrow(string text, int line, int pos)
            : base(text, line, pos)
        {
        }
        
        public override TLArrow Clone()
        {
            return new TLArrow(Text, Line, Position);
        }
    }
    public partial class TCompare : Token<TCompare>
    {
        public TCompare(string text)
            : base(text)
        {
        }
        public TCompare(string text, int line, int pos)
            : base(text, line, pos)
        {
        }
        
        public override TCompare Clone()
        {
            return new TCompare(Text, Line, Position);
        }
    }
    public partial class TAssign : Token<TAssign>
    {
        public TAssign()
            : base(@"=")
        {
        }
        public TAssign(int line, int pos)
            : base(@"=", line, pos)
        {
        }
        public TAssign(string text)
            : base(text)
        {
        }
        public TAssign(string text, int line, int pos)
            : base(text, line, pos)
        {
        }
        
        public override TAssign Clone()
        {
            return new TAssign(Text, Line, Position);
        }
    }
    public partial class TUnderscore : Token<TUnderscore>
    {
        public TUnderscore()
            : base(@"_")
        {
        }
        public TUnderscore(int line, int pos)
            : base(@"_", line, pos)
        {
        }
        public TUnderscore(string text)
            : base(text)
        {
        }
        public TUnderscore(string text, int line, int pos)
            : base(text, line, pos)
        {
        }
        
        public override TUnderscore Clone()
        {
            return new TUnderscore(Text, Line, Position);
        }
    }
    public partial class THat : Token<THat>
    {
        public THat()
            : base(@"^")
        {
        }
        public THat(int line, int pos)
            : base(@"^", line, pos)
        {
        }
        public THat(string text)
            : base(text)
        {
        }
        public THat(string text, int line, int pos)
            : base(text, line, pos)
        {
        }
        
        public override THat Clone()
        {
            return new THat(Text, Line, Position);
        }
    }
    public partial class TPlus : Token<TPlus>
    {
        public TPlus()
            : base(@"+")
        {
        }
        public TPlus(int line, int pos)
            : base(@"+", line, pos)
        {
        }
        public TPlus(string text)
            : base(text)
        {
        }
        public TPlus(string text, int line, int pos)
            : base(text, line, pos)
        {
        }
        
        public override TPlus Clone()
        {
            return new TPlus(Text, Line, Position);
        }
    }
    public partial class TMinus : Token<TMinus>
    {
        public TMinus()
            : base(@"-")
        {
        }
        public TMinus(int line, int pos)
            : base(@"-", line, pos)
        {
        }
        public TMinus(string text)
            : base(text)
        {
        }
        public TMinus(string text, int line, int pos)
            : base(text, line, pos)
        {
        }
        
        public override TMinus Clone()
        {
            return new TMinus(Text, Line, Position);
        }
    }
    public partial class TAsterisk : Token<TAsterisk>
    {
        public TAsterisk()
            : base(@"*")
        {
        }
        public TAsterisk(int line, int pos)
            : base(@"*", line, pos)
        {
        }
        public TAsterisk(string text)
            : base(text)
        {
        }
        public TAsterisk(string text, int line, int pos)
            : base(text, line, pos)
        {
        }
        
        public override TAsterisk Clone()
        {
            return new TAsterisk(Text, Line, Position);
        }
    }
    public partial class TSlash : Token<TSlash>
    {
        public TSlash()
            : base(@"/")
        {
        }
        public TSlash(int line, int pos)
            : base(@"/", line, pos)
        {
        }
        public TSlash(string text)
            : base(text)
        {
        }
        public TSlash(string text, int line, int pos)
            : base(text, line, pos)
        {
        }
        
        public override TSlash Clone()
        {
            return new TSlash(Text, Line, Position);
        }
    }
    public partial class TPercent : Token<TPercent>
    {
        public TPercent()
            : base(@"%")
        {
        }
        public TPercent(int line, int pos)
            : base(@"%", line, pos)
        {
        }
        public TPercent(string text)
            : base(text)
        {
        }
        public TPercent(string text, int line, int pos)
            : base(text, line, pos)
        {
        }
        
        public override TPercent Clone()
        {
            return new TPercent(Text, Line, Position);
        }
    }
    public partial class TBang : Token<TBang>
    {
        public TBang()
            : base(@"!")
        {
        }
        public TBang(int line, int pos)
            : base(@"!", line, pos)
        {
        }
        public TBang(string text)
            : base(text)
        {
        }
        public TBang(string text, int line, int pos)
            : base(text, line, pos)
        {
        }
        
        public override TBang Clone()
        {
            return new TBang(Text, Line, Position);
        }
    }
    public partial class TAnd : Token<TAnd>
    {
        public TAnd()
            : base(@"&&")
        {
        }
        public TAnd(int line, int pos)
            : base(@"&&", line, pos)
        {
        }
        public TAnd(string text)
            : base(text)
        {
        }
        public TAnd(string text, int line, int pos)
            : base(text, line, pos)
        {
        }
        
        public override TAnd Clone()
        {
            return new TAnd(Text, Line, Position);
        }
    }
    public partial class TOr : Token<TOr>
    {
        public TOr()
            : base(@"||")
        {
        }
        public TOr(int line, int pos)
            : base(@"||", line, pos)
        {
        }
        public TOr(string text)
            : base(text)
        {
        }
        public TOr(string text, int line, int pos)
            : base(text, line, pos)
        {
        }
        
        public override TOr Clone()
        {
            return new TOr(Text, Line, Position);
        }
    }
    public partial class TPeriod : Token<TPeriod>
    {
        public TPeriod()
            : base(@".")
        {
        }
        public TPeriod(int line, int pos)
            : base(@".", line, pos)
        {
        }
        public TPeriod(string text)
            : base(text)
        {
        }
        public TPeriod(string text, int line, int pos)
            : base(text, line, pos)
        {
        }
        
        public override TPeriod Clone()
        {
            return new TPeriod(Text, Line, Position);
        }
    }
    public partial class TComma : Token<TComma>
    {
        public TComma()
            : base(@",")
        {
        }
        public TComma(int line, int pos)
            : base(@",", line, pos)
        {
        }
        public TComma(string text)
            : base(text)
        {
        }
        public TComma(string text, int line, int pos)
            : base(text, line, pos)
        {
        }
        
        public override TComma Clone()
        {
            return new TComma(Text, Line, Position);
        }
    }
    public partial class TColon : Token<TColon>
    {
        public TColon()
            : base(@":")
        {
        }
        public TColon(int line, int pos)
            : base(@":", line, pos)
        {
        }
        public TColon(string text)
            : base(text)
        {
        }
        public TColon(string text, int line, int pos)
            : base(text, line, pos)
        {
        }
        
        public override TColon Clone()
        {
            return new TColon(Text, Line, Position);
        }
    }
    public partial class TSemicolon : Token<TSemicolon>
    {
        public TSemicolon()
            : base(@";")
        {
        }
        public TSemicolon(int line, int pos)
            : base(@";", line, pos)
        {
        }
        public TSemicolon(string text)
            : base(text)
        {
        }
        public TSemicolon(string text, int line, int pos)
            : base(text, line, pos)
        {
        }
        
        public override TSemicolon Clone()
        {
            return new TSemicolon(Text, Line, Position);
        }
    }
    public partial class TLabelStart : Token<TLabelStart>
    {
        public TLabelStart()
            : base(@"{{")
        {
        }
        public TLabelStart(int line, int pos)
            : base(@"{{", line, pos)
        {
        }
        public TLabelStart(string text)
            : base(text)
        {
        }
        public TLabelStart(string text, int line, int pos)
            : base(text, line, pos)
        {
        }
        
        public override TLabelStart Clone()
        {
            return new TLabelStart(Text, Line, Position);
        }
    }
    public partial class TLabelEnd : Token<TLabelEnd>
    {
        public TLabelEnd()
            : base(@"}}")
        {
        }
        public TLabelEnd(int line, int pos)
            : base(@"}}", line, pos)
        {
        }
        public TLabelEnd(string text)
            : base(text)
        {
        }
        public TLabelEnd(string text, int line, int pos)
            : base(text, line, pos)
        {
        }
        
        public override TLabelEnd Clone()
        {
            return new TLabelEnd(Text, Line, Position);
        }
    }
    public partial class TLPar : Token<TLPar>
    {
        public TLPar()
            : base(@"(")
        {
        }
        public TLPar(int line, int pos)
            : base(@"(", line, pos)
        {
        }
        public TLPar(string text)
            : base(text)
        {
        }
        public TLPar(string text, int line, int pos)
            : base(text, line, pos)
        {
        }
        
        public override TLPar Clone()
        {
            return new TLPar(Text, Line, Position);
        }
    }
    public partial class TRPar : Token<TRPar>
    {
        public TRPar()
            : base(@")")
        {
        }
        public TRPar(int line, int pos)
            : base(@")", line, pos)
        {
        }
        public TRPar(string text)
            : base(text)
        {
        }
        public TRPar(string text, int line, int pos)
            : base(text, line, pos)
        {
        }
        
        public override TRPar Clone()
        {
            return new TRPar(Text, Line, Position);
        }
    }
    public partial class TLSqu : Token<TLSqu>
    {
        public TLSqu()
            : base(@"[")
        {
        }
        public TLSqu(int line, int pos)
            : base(@"[", line, pos)
        {
        }
        public TLSqu(string text)
            : base(text)
        {
        }
        public TLSqu(string text, int line, int pos)
            : base(text, line, pos)
        {
        }
        
        public override TLSqu Clone()
        {
            return new TLSqu(Text, Line, Position);
        }
    }
    public partial class TRSqu : Token<TRSqu>
    {
        public TRSqu()
            : base(@"]")
        {
        }
        public TRSqu(int line, int pos)
            : base(@"]", line, pos)
        {
        }
        public TRSqu(string text)
            : base(text)
        {
        }
        public TRSqu(string text, int line, int pos)
            : base(text, line, pos)
        {
        }
        
        public override TRSqu Clone()
        {
            return new TRSqu(Text, Line, Position);
        }
    }
    public partial class TLCur : Token<TLCur>
    {
        public TLCur()
            : base(@"{")
        {
        }
        public TLCur(int line, int pos)
            : base(@"{", line, pos)
        {
        }
        public TLCur(string text)
            : base(text)
        {
        }
        public TLCur(string text, int line, int pos)
            : base(text, line, pos)
        {
        }
        
        public override TLCur Clone()
        {
            return new TLCur(Text, Line, Position);
        }
    }
    public partial class TRCur : Token<TRCur>
    {
        public TRCur()
            : base(@"}")
        {
        }
        public TRCur(int line, int pos)
            : base(@"}", line, pos)
        {
        }
        public TRCur(string text)
            : base(text)
        {
        }
        public TRCur(string text, int line, int pos)
            : base(text, line, pos)
        {
        }
        
        public override TRCur Clone()
        {
            return new TRCur(Text, Line, Position);
        }
    }
    public partial class TJoin : Token<TJoin>
    {
        public TJoin()
            : base(@"⊔")
        {
        }
        public TJoin(int line, int pos)
            : base(@"⊔", line, pos)
        {
        }
        public TJoin(string text)
            : base(text)
        {
        }
        public TJoin(string text, int line, int pos)
            : base(text, line, pos)
        {
        }
        
        public override TJoin Clone()
        {
            return new TJoin(Text, Line, Position);
        }
    }
    public partial class TComment : Token<TComment>
    {
        public TComment(string text)
            : base(text)
        {
        }
        public TComment(string text, int line, int pos)
            : base(text, line, pos)
        {
        }
        
        public override TComment Clone()
        {
            return new TComment(Text, Line, Position);
        }
    }
    public partial class TWhitespace : Token<TWhitespace>
    {
        public TWhitespace(string text)
            : base(text)
        {
        }
        public TWhitespace(string text, int line, int pos)
            : base(text, line, pos)
        {
        }
        
        public override TWhitespace Clone()
        {
            return new TWhitespace(Text, Line, Position);
        }
    }
}
