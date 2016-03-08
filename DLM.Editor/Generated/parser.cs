using System;
using System.Collections.Generic;
using DLM.Editor.Nodes;
using SablePP.Tools.Nodes;

namespace DLM.Editor.Parsing
{
    public class Parser : SablePP.Tools.Parsing.Parser<PRoot>
    {
        #region Token Index
        
        protected override int getTokenIndex(Token token)
        {
            return getIndex((dynamic)token);
        }
        
        private int getIndex(Token node)
        {
            return -1;
        }
        
        private int getIndex(TInclude node)
        {
            return 0;
        }
        private int getIndex(TFile node)
        {
            return 1;
        }
        private int getIndex(TBool node)
        {
            return 2;
        }
        private int getIndex(TNumber node)
        {
            return 3;
        }
        private int getIndex(TPrincipall node)
        {
            return 4;
        }
        private int getIndex(TTypedef node)
        {
            return 5;
        }
        private int getIndex(TStruct node)
        {
            return 6;
        }
        private int getIndex(TWhile node)
        {
            return 7;
        }
        private int getIndex(TIf node)
        {
            return 8;
        }
        private int getIndex(TElse node)
        {
            return 9;
        }
        private int getIndex(TReturn node)
        {
            return 10;
        }
        private int getIndex(TIdentifier node)
        {
            return 11;
        }
        private int getIndex(TActsFor node)
        {
            return 12;
        }
        private int getIndex(TDeclassifyStart node)
        {
            return 13;
        }
        private int getIndex(TDeclassifyEnd node)
        {
            return 14;
        }
        private int getIndex(TRArrow node)
        {
            return 15;
        }
        private int getIndex(TLArrow node)
        {
            return 16;
        }
        private int getIndex(TCompare node)
        {
            return 17;
        }
        private int getIndex(TAssign node)
        {
            return 18;
        }
        private int getIndex(TUnderscore node)
        {
            return 19;
        }
        private int getIndex(THat node)
        {
            return 20;
        }
        private int getIndex(TPlus node)
        {
            return 21;
        }
        private int getIndex(TMinus node)
        {
            return 22;
        }
        private int getIndex(TAsterisk node)
        {
            return 23;
        }
        private int getIndex(TSlash node)
        {
            return 24;
        }
        private int getIndex(TPercent node)
        {
            return 25;
        }
        private int getIndex(TBang node)
        {
            return 26;
        }
        private int getIndex(TAnd node)
        {
            return 27;
        }
        private int getIndex(TOr node)
        {
            return 28;
        }
        private int getIndex(TPeriod node)
        {
            return 29;
        }
        private int getIndex(TComma node)
        {
            return 30;
        }
        private int getIndex(TColon node)
        {
            return 31;
        }
        private int getIndex(TSemicolon node)
        {
            return 32;
        }
        private int getIndex(TLabelStart node)
        {
            return 33;
        }
        private int getIndex(TLabelEnd node)
        {
            return 34;
        }
        private int getIndex(TLPar node)
        {
            return 35;
        }
        private int getIndex(TRPar node)
        {
            return 36;
        }
        private int getIndex(TLSqu node)
        {
            return 37;
        }
        private int getIndex(TRSqu node)
        {
            return 38;
        }
        private int getIndex(TLCur node)
        {
            return 39;
        }
        private int getIndex(TRCur node)
        {
            return 40;
        }
        private int getIndex(TJoin node)
        {
            return 41;
        }
        
        private int getIndex(EOF node)
        {
            return 42;
        }
        
        #endregion
        
        public Parser(SablePP.Tools.Lexing.ILexer lexer)
            : base(lexer, actionTable, gotoTable, errorMessages, errors)
        {
        }
        protected override void reduce(int index)
        {
            switch (index)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                case 11:
                case 12:
                case 13:
                case 14:
                case 15:
                    {
                        List<PStatement> pstatementlist = isOn(8, index - 0) ? Pop<List<PStatement>>() : new List<PStatement>();
                        List<PStruct> pstructlist = isOn(4, index - 0) ? Pop<List<PStruct>>() : new List<PStruct>();
                        List<PPrincipalDeclaration> pprincipaldeclarationlist = isOn(2, index - 0) ? Pop<List<PPrincipalDeclaration>>() : new List<PPrincipalDeclaration>();
                        List<PInclude> pincludelist = isOn(1, index - 0) ? Pop<List<PInclude>>() : new List<PInclude>();
                        List<PInclude> pincludelist2 = new List<PInclude>();
                        pincludelist2.AddRange(pincludelist);
                        List<PPrincipalDeclaration> pprincipaldeclarationlist2 = new List<PPrincipalDeclaration>();
                        pprincipaldeclarationlist2.AddRange(pprincipaldeclarationlist);
                        List<PStruct> pstructlist2 = new List<PStruct>();
                        pstructlist2.AddRange(pstructlist);
                        List<PStatement> pstatementlist2 = new List<PStatement>();
                        pstatementlist2.AddRange(pstatementlist);
                        ARoot aroot = new ARoot(
                            pincludelist2,
                            pprincipaldeclarationlist2,
                            pstructlist2,
                            pstatementlist2
                        );
                        Push(0, aroot);
                    }
                    break;
                case 16:
                    {
                        TFile tfile = Pop<TFile>();
                        TInclude tinclude = Pop<TInclude>();
                        AInclude ainclude = new AInclude(
                            tfile
                        );
                        Push(1, ainclude);
                    }
                    break;
                case 17:
                    {
                        TSemicolon tsemicolon = Pop<TSemicolon>();
                        TIdentifier tidentifier = Pop<TIdentifier>();
                        TPrincipall tprincipall = Pop<TPrincipall>();
                        APrincipalDeclaration aprincipaldeclaration = new APrincipalDeclaration(
                            tidentifier
                        );
                        Push(2, aprincipaldeclaration);
                    }
                    break;
                case 18:
                case 19:
                    {
                        TSemicolon tsemicolon = Pop<TSemicolon>();
                        TIdentifier tidentifier = Pop<TIdentifier>();
                        TRCur trcur = Pop<TRCur>();
                        List<PField> pfieldlist = isOn(1, index - 18) ? Pop<List<PField>>() : new List<PField>();
                        TLCur tlcur = Pop<TLCur>();
                        TIdentifier tidentifier2 = Pop<TIdentifier>();
                        TStruct tstruct = Pop<TStruct>();
                        TTypedef ttypedef = Pop<TTypedef>();
                        List<PField> pfieldlist2 = new List<PField>();
                        pfieldlist2.AddRange(pfieldlist);
                        AStruct astruct = new AStruct(
                            tidentifier2,
                            pfieldlist2,
                            tidentifier
                        );
                        Push(3, astruct);
                    }
                    break;
                case 20:
                    {
                        TSemicolon tsemicolon = Pop<TSemicolon>();
                        TIdentifier tidentifier = Pop<TIdentifier>();
                        PType ptype = Pop<PType>();
                        AField afield = new AField(
                            ptype,
                            tidentifier
                        );
                        Push(4, afield);
                    }
                    break;
                case 21:
                    {
                        TSemicolon tsemicolon = Pop<TSemicolon>();
                        TRSqu trsqu = Pop<TRSqu>();
                        TNumber tnumber = Pop<TNumber>();
                        TLSqu tlsqu = Pop<TLSqu>();
                        TIdentifier tidentifier = Pop<TIdentifier>();
                        PType ptype = Pop<PType>();
                        AArrayField aarrayfield = new AArrayField(
                            ptype,
                            tidentifier,
                            tnumber
                        );
                        Push(4, aarrayfield);
                    }
                    break;
                case 22:
                    {
                        TSemicolon tsemicolon = Pop<TSemicolon>();
                        TIdentifier tidentifier = Pop<TIdentifier>();
                        PType ptype = Pop<PType>();
                        ADeclarationStatement adeclarationstatement = new ADeclarationStatement(
                            ptype,
                            tidentifier,
                            null
                        );
                        Push(5, adeclarationstatement);
                    }
                    break;
                case 23:
                    {
                        TSemicolon tsemicolon = Pop<TSemicolon>();
                        PExpression pexpression = Pop<PExpression>();
                        TAssign tassign = Pop<TAssign>();
                        TIdentifier tidentifier = Pop<TIdentifier>();
                        PType ptype = Pop<PType>();
                        ADeclarationStatement adeclarationstatement = new ADeclarationStatement(
                            ptype,
                            tidentifier,
                            pexpression
                        );
                        Push(5, adeclarationstatement);
                    }
                    break;
                case 24:
                    {
                        TRSqu trsqu = Pop<TRSqu>();
                        TNumber tnumber = Pop<TNumber>();
                        TLSqu tlsqu = Pop<TLSqu>();
                        TIdentifier tidentifier = Pop<TIdentifier>();
                        PType ptype = Pop<PType>();
                        AArrayDeclarationStatement aarraydeclarationstatement = new AArrayDeclarationStatement(
                            ptype,
                            tidentifier,
                            tnumber
                        );
                        Push(5, aarraydeclarationstatement);
                    }
                    break;
                case 25:
                case 26:
                    {
                        TRCur trcur = Pop<TRCur>();
                        List<PStatement> pstatementlist = isOn(1, index - 25) ? Pop<List<PStatement>>() : new List<PStatement>();
                        TLCur tlcur = Pop<TLCur>();
                        TRPar trpar = Pop<TRPar>();
                        List<PFunctionParameter> pfunctionparameterlist = Pop<List<PFunctionParameter>>();
                        TLPar tlpar = Pop<TLPar>();
                        TIdentifier tidentifier = Pop<TIdentifier>();
                        PType ptype = Pop<PType>();
                        List<PFunctionParameter> pfunctionparameterlist2 = new List<PFunctionParameter>();
                        pfunctionparameterlist2.AddRange(pfunctionparameterlist);
                        List<PStatement> pstatementlist2 = new List<PStatement>();
                        pstatementlist2.AddRange(pstatementlist);
                        AFunctionDeclarationStatement afunctiondeclarationstatement = new AFunctionDeclarationStatement(
                            ptype,
                            tidentifier,
                            pfunctionparameterlist2,
                            pstatementlist2
                        );
                        Push(5, afunctiondeclarationstatement);
                    }
                    break;
                case 27:
                    {
                        TIdentifier tidentifier = Pop<TIdentifier>();
                        PType ptype = Pop<PType>();
                        AFunctionParameter afunctionparameter = new AFunctionParameter(
                            ptype,
                            tidentifier
                        );
                        List<PFunctionParameter> pfunctionparameterlist = new List<PFunctionParameter>();
                        pfunctionparameterlist.Add(afunctionparameter);
                        Push(6, pfunctionparameterlist);
                    }
                    break;
                case 28:
                    {
                        List<PFunctionParameter> pfunctionparameterlist = Pop<List<PFunctionParameter>>();
                        TComma tcomma = Pop<TComma>();
                        TIdentifier tidentifier = Pop<TIdentifier>();
                        PType ptype = Pop<PType>();
                        AFunctionParameter afunctionparameter = new AFunctionParameter(
                            ptype,
                            tidentifier
                        );
                        List<PFunctionParameter> pfunctionparameterlist2 = new List<PFunctionParameter>();
                        pfunctionparameterlist2.Add(afunctionparameter);
                        pfunctionparameterlist2.AddRange(pfunctionparameterlist);
                        Push(6, pfunctionparameterlist2);
                    }
                    break;
                case 29:
                    {
                        List<PStatement> pstatementlist = Pop<List<PStatement>>();
                        TRPar trpar = Pop<TRPar>();
                        PExpression pexpression = Pop<PExpression>();
                        TLPar tlpar = Pop<TLPar>();
                        TIf tif = Pop<TIf>();
                        List<PStatement> pstatementlist2 = new List<PStatement>();
                        pstatementlist2.AddRange(pstatementlist);
                        AIfStatement aifstatement = new AIfStatement(
                            pexpression,
                            pstatementlist2
                        );
                        Push(7, aifstatement);
                    }
                    break;
                case 30:
                    {
                        List<PStatement> pstatementlist = Pop<List<PStatement>>();
                        TElse telse = Pop<TElse>();
                        List<PStatement> pstatementlist2 = Pop<List<PStatement>>();
                        TRPar trpar = Pop<TRPar>();
                        PExpression pexpression = Pop<PExpression>();
                        TLPar tlpar = Pop<TLPar>();
                        TIf tif = Pop<TIf>();
                        List<PStatement> pstatementlist3 = new List<PStatement>();
                        pstatementlist3.AddRange(pstatementlist2);
                        List<PStatement> pstatementlist4 = new List<PStatement>();
                        pstatementlist4.AddRange(pstatementlist);
                        AIfElseStatement aifelsestatement = new AIfElseStatement(
                            pexpression,
                            pstatementlist3,
                            pstatementlist4
                        );
                        Push(7, aifelsestatement);
                    }
                    break;
                case 31:
                    {
                        List<PStatement> pstatementlist = Pop<List<PStatement>>();
                        TRPar trpar = Pop<TRPar>();
                        PExpression pexpression = Pop<PExpression>();
                        TLPar tlpar = Pop<TLPar>();
                        TWhile twhile = Pop<TWhile>();
                        List<PStatement> pstatementlist2 = new List<PStatement>();
                        pstatementlist2.AddRange(pstatementlist);
                        AWhileStatement awhilestatement = new AWhileStatement(
                            pexpression,
                            pstatementlist2
                        );
                        Push(7, awhilestatement);
                    }
                    break;
                case 32:
                    {
                        PStatement pstatement = Pop<PStatement>();
                        Push(7, pstatement);
                    }
                    break;
                case 33:
                    {
                        List<PStatement> pstatementlist = Pop<List<PStatement>>();
                        TElse telse = Pop<TElse>();
                        List<PStatement> pstatementlist2 = Pop<List<PStatement>>();
                        TRPar trpar = Pop<TRPar>();
                        PExpression pexpression = Pop<PExpression>();
                        TLPar tlpar = Pop<TLPar>();
                        TIf tif = Pop<TIf>();
                        List<PStatement> pstatementlist3 = new List<PStatement>();
                        pstatementlist3.AddRange(pstatementlist2);
                        List<PStatement> pstatementlist4 = new List<PStatement>();
                        pstatementlist4.AddRange(pstatementlist);
                        AIfElseStatement aifelsestatement = new AIfElseStatement(
                            pexpression,
                            pstatementlist3,
                            pstatementlist4
                        );
                        Push(8, aifelsestatement);
                    }
                    break;
                case 34:
                    {
                        List<PStatement> pstatementlist = Pop<List<PStatement>>();
                        TRPar trpar = Pop<TRPar>();
                        PExpression pexpression = Pop<PExpression>();
                        TLPar tlpar = Pop<TLPar>();
                        TWhile twhile = Pop<TWhile>();
                        List<PStatement> pstatementlist2 = new List<PStatement>();
                        pstatementlist2.AddRange(pstatementlist);
                        AWhileStatement awhilestatement = new AWhileStatement(
                            pexpression,
                            pstatementlist2
                        );
                        Push(8, awhilestatement);
                    }
                    break;
                case 35:
                    {
                        PStatement pstatement = Pop<PStatement>();
                        Push(8, pstatement);
                    }
                    break;
                case 36:
                    {
                        TSemicolon tsemicolon = Pop<TSemicolon>();
                        TIdentifier tidentifier = Pop<TIdentifier>();
                        PType ptype = Pop<PType>();
                        ADeclarationStatement adeclarationstatement = new ADeclarationStatement(
                            ptype,
                            tidentifier,
                            null
                        );
                        Push(9, adeclarationstatement);
                    }
                    break;
                case 37:
                    {
                        TSemicolon tsemicolon = Pop<TSemicolon>();
                        PExpression pexpression = Pop<PExpression>();
                        TAssign tassign = Pop<TAssign>();
                        TIdentifier tidentifier = Pop<TIdentifier>();
                        PType ptype = Pop<PType>();
                        ADeclarationStatement adeclarationstatement = new ADeclarationStatement(
                            ptype,
                            tidentifier,
                            pexpression
                        );
                        Push(9, adeclarationstatement);
                    }
                    break;
                case 38:
                    {
                        TRSqu trsqu = Pop<TRSqu>();
                        TNumber tnumber = Pop<TNumber>();
                        TLSqu tlsqu = Pop<TLSqu>();
                        TIdentifier tidentifier = Pop<TIdentifier>();
                        PType ptype = Pop<PType>();
                        AArrayDeclarationStatement aarraydeclarationstatement = new AArrayDeclarationStatement(
                            ptype,
                            tidentifier,
                            tnumber
                        );
                        Push(9, aarraydeclarationstatement);
                    }
                    break;
                case 39:
                    {
                        TSemicolon tsemicolon = Pop<TSemicolon>();
                        PExpression pexpression = Pop<PExpression>();
                        TAssign tassign = Pop<TAssign>();
                        TIdentifier tidentifier = Pop<TIdentifier>();
                        AAssignmentStatement aassignmentstatement = new AAssignmentStatement(
                            tidentifier,
                            pexpression
                        );
                        Push(9, aassignmentstatement);
                    }
                    break;
                case 40:
                case 41:
                    {
                        TSemicolon tsemicolon = Pop<TSemicolon>();
                        PExpression pexpression = isOn(1, index - 40) ? Pop<PExpression>() : null;
                        TReturn treturn = Pop<TReturn>();
                        AReturnStatement areturnstatement = new AReturnStatement(
                            pexpression
                        );
                        Push(9, areturnstatement);
                    }
                    break;
                case 42:
                case 43:
                    {
                        TRCur trcur = Pop<TRCur>();
                        List<PStatement> pstatementlist = isOn(1, index - 42) ? Pop<List<PStatement>>() : new List<PStatement>();
                        TLCur tlcur = Pop<TLCur>();
                        PPrincipal pprincipal = Pop<PPrincipal>();
                        TActsFor tactsfor = Pop<TActsFor>();
                        TIdentifier tidentifier = Pop<TIdentifier>();
                        List<PStatement> pstatementlist2 = new List<PStatement>();
                        pstatementlist2.AddRange(pstatementlist);
                        AActsForStatement aactsforstatement = new AActsForStatement(
                            tidentifier,
                            pprincipal,
                            pstatementlist2
                        );
                        Push(9, aactsforstatement);
                    }
                    break;
                case 44:
                case 45:
                    {
                        PLabel plabel = isOn(1, index - 44) ? Pop<PLabel>() : null;
                        TIdentifier tidentifier = Pop<TIdentifier>();
                        AType atype = new AType(
                            tidentifier,
                            plabel
                        );
                        Push(10, atype);
                    }
                    break;
                case 46:
                    {
                        TAsterisk tasterisk = Pop<TAsterisk>();
                        PType ptype = Pop<PType>();
                        APointerType apointertype = new APointerType(
                            ptype,
                            tasterisk
                        );
                        Push(10, apointertype);
                    }
                    break;
                case 47:
                    {
                        PStatement pstatement = Pop<PStatement>();
                        List<PStatement> pstatementlist = new List<PStatement>();
                        pstatementlist.Add(pstatement);
                        Push(11, pstatementlist);
                    }
                    break;
                case 48:
                case 49:
                    {
                        TRCur trcur = Pop<TRCur>();
                        List<PStatement> pstatementlist = isOn(1, index - 48) ? Pop<List<PStatement>>() : new List<PStatement>();
                        TLCur tlcur = Pop<TLCur>();
                        List<PStatement> pstatementlist2 = new List<PStatement>();
                        pstatementlist2.AddRange(pstatementlist);
                        Push(11, pstatementlist2);
                    }
                    break;
                case 50:
                    {
                        PStatement pstatement = Pop<PStatement>();
                        List<PStatement> pstatementlist = new List<PStatement>();
                        pstatementlist.Add(pstatement);
                        Push(12, pstatementlist);
                    }
                    break;
                case 51:
                case 52:
                    {
                        TRCur trcur = Pop<TRCur>();
                        List<PStatement> pstatementlist = isOn(1, index - 51) ? Pop<List<PStatement>>() : new List<PStatement>();
                        TLCur tlcur = Pop<TLCur>();
                        List<PStatement> pstatementlist2 = new List<PStatement>();
                        pstatementlist2.AddRange(pstatementlist);
                        Push(12, pstatementlist2);
                    }
                    break;
                case 53:
                    {
                        TLabelEnd tlabelend = Pop<TLabelEnd>();
                        List<PPolicy> ppolicylist = Pop<List<PPolicy>>();
                        TLabelStart tlabelstart = Pop<TLabelStart>();
                        List<PPolicy> ppolicylist2 = new List<PPolicy>();
                        ppolicylist2.AddRange(ppolicylist);
                        ALabel alabel = new ALabel(
                            ppolicylist2
                        );
                        Push(13, alabel);
                    }
                    break;
                case 54:
                    {
                        TIdentifier tidentifier = Pop<TIdentifier>();
                        AVariablePolicy avariablepolicy = new AVariablePolicy(
                            tidentifier
                        );
                        Push(14, avariablepolicy);
                    }
                    break;
                case 55:
                    {
                        List<PPrincipal> pprincipallist = Pop<List<PPrincipal>>();
                        TRArrow trarrow = Pop<TRArrow>();
                        PPrincipal pprincipal = Pop<PPrincipal>();
                        List<PPrincipal> pprincipallist2 = new List<PPrincipal>();
                        pprincipallist2.AddRange(pprincipallist);
                        APrincipalPolicy aprincipalpolicy = new APrincipalPolicy(
                            pprincipal,
                            pprincipallist2
                        );
                        Push(14, aprincipalpolicy);
                    }
                    break;
                case 56:
                    {
                        TRArrow trarrow = Pop<TRArrow>();
                        PPrincipal pprincipal = Pop<PPrincipal>();
                        List<PPrincipal> pprincipallist = new List<PPrincipal>();
                        APrincipalPolicy aprincipalpolicy = new APrincipalPolicy(
                            pprincipal,
                            pprincipallist
                        );
                        Push(14, aprincipalpolicy);
                    }
                    break;
                case 57:
                    {
                        TUnderscore tunderscore = Pop<TUnderscore>();
                        ALowerPolicy alowerpolicy = new ALowerPolicy(
                            tunderscore
                        );
                        Push(14, alowerpolicy);
                    }
                    break;
                case 58:
                    {
                        THat that = Pop<THat>();
                        AUpperPolicy aupperpolicy = new AUpperPolicy(
                            that
                        );
                        Push(14, aupperpolicy);
                    }
                    break;
                case 59:
                    {
                        PPolicy ppolicy = Pop<PPolicy>();
                        List<PPolicy> ppolicylist = new List<PPolicy>();
                        ppolicylist.Add(ppolicy);
                        Push(15, ppolicylist);
                    }
                    break;
                case 60:
                    {
                        List<PPolicy> ppolicylist = Pop<List<PPolicy>>();
                        TSemicolon tsemicolon = Pop<TSemicolon>();
                        PPolicy ppolicy = Pop<PPolicy>();
                        List<PPolicy> ppolicylist2 = new List<PPolicy>();
                        ppolicylist2.Add(ppolicy);
                        ppolicylist2.AddRange(ppolicylist);
                        Push(15, ppolicylist2);
                    }
                    break;
                case 61:
                    {
                        List<PPolicy> ppolicylist = Pop<List<PPolicy>>();
                        TJoin tjoin = Pop<TJoin>();
                        PPolicy ppolicy = Pop<PPolicy>();
                        List<PPolicy> ppolicylist2 = new List<PPolicy>();
                        ppolicylist2.Add(ppolicy);
                        ppolicylist2.AddRange(ppolicylist);
                        Push(15, ppolicylist2);
                    }
                    break;
                case 62:
                    {
                        TIdentifier tidentifier = Pop<TIdentifier>();
                        APrincipal aprincipal = new APrincipal(
                            tidentifier
                        );
                        Push(16, aprincipal);
                    }
                    break;
                case 63:
                    {
                        PPrincipal pprincipal = Pop<PPrincipal>();
                        List<PPrincipal> pprincipallist = new List<PPrincipal>();
                        pprincipallist.Add(pprincipal);
                        Push(17, pprincipallist);
                    }
                    break;
                case 64:
                    {
                        List<PPrincipal> pprincipallist = Pop<List<PPrincipal>>();
                        TComma tcomma = Pop<TComma>();
                        PPrincipal pprincipal = Pop<PPrincipal>();
                        List<PPrincipal> pprincipallist2 = new List<PPrincipal>();
                        pprincipallist2.Add(pprincipal);
                        pprincipallist2.AddRange(pprincipallist);
                        Push(17, pprincipallist2);
                    }
                    break;
                case 65:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        Push(18, pexpression);
                    }
                    break;
                case 66:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TAnd tand = Pop<TAnd>();
                        PExpression pexpression2 = Pop<PExpression>();
                        AAndExpression aandexpression = new AAndExpression(
                            pexpression2,
                            pexpression
                        );
                        Push(19, aandexpression);
                    }
                    break;
                case 67:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TOr tor = Pop<TOr>();
                        PExpression pexpression2 = Pop<PExpression>();
                        AOrExpression aorexpression = new AOrExpression(
                            pexpression2,
                            pexpression
                        );
                        Push(19, aorexpression);
                    }
                    break;
                case 68:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        Push(19, pexpression);
                    }
                    break;
                case 69:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TCompare tcompare = Pop<TCompare>();
                        PExpression pexpression2 = Pop<PExpression>();
                        AComparisonExpression acomparisonexpression = new AComparisonExpression(
                            pexpression2,
                            tcompare,
                            pexpression
                        );
                        Push(20, acomparisonexpression);
                    }
                    break;
                case 70:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TBang tbang = Pop<TBang>();
                        ANotExpression anotexpression = new ANotExpression(
                            pexpression
                        );
                        Push(20, anotexpression);
                    }
                    break;
                case 71:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        Push(20, pexpression);
                    }
                    break;
                case 72:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TPlus tplus = Pop<TPlus>();
                        PExpression pexpression2 = Pop<PExpression>();
                        APlusExpression aplusexpression = new APlusExpression(
                            pexpression2,
                            pexpression
                        );
                        Push(21, aplusexpression);
                    }
                    break;
                case 73:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TMinus tminus = Pop<TMinus>();
                        PExpression pexpression2 = Pop<PExpression>();
                        AMinusExpression aminusexpression = new AMinusExpression(
                            pexpression2,
                            pexpression
                        );
                        Push(21, aminusexpression);
                    }
                    break;
                case 74:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TMinus tminus = Pop<TMinus>();
                        ANegateExpression anegateexpression = new ANegateExpression(
                            pexpression
                        );
                        Push(21, anegateexpression);
                    }
                    break;
                case 75:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        Push(21, pexpression);
                    }
                    break;
                case 76:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TAsterisk tasterisk = Pop<TAsterisk>();
                        PExpression pexpression2 = Pop<PExpression>();
                        AMultiplyExpression amultiplyexpression = new AMultiplyExpression(
                            pexpression2,
                            pexpression
                        );
                        Push(22, amultiplyexpression);
                    }
                    break;
                case 77:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TSlash tslash = Pop<TSlash>();
                        PExpression pexpression2 = Pop<PExpression>();
                        ADivideExpression adivideexpression = new ADivideExpression(
                            pexpression2,
                            pexpression
                        );
                        Push(22, adivideexpression);
                    }
                    break;
                case 78:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TPercent tpercent = Pop<TPercent>();
                        PExpression pexpression2 = Pop<PExpression>();
                        AModuloExpression amoduloexpression = new AModuloExpression(
                            pexpression2,
                            pexpression
                        );
                        Push(22, amoduloexpression);
                    }
                    break;
                case 79:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        Push(22, pexpression);
                    }
                    break;
                case 80:
                    {
                        TIdentifier tidentifier = Pop<TIdentifier>();
                        TPeriod tperiod = Pop<TPeriod>();
                        PExpression pexpression = Pop<PExpression>();
                        AElement aelement = new AElement(
                            tidentifier
                        );
                        AElementExpression aelementexpression = new AElementExpression(
                            pexpression,
                            aelement
                        );
                        Push(23, aelementexpression);
                    }
                    break;
                case 81:
                    {
                        TIdentifier tidentifier = Pop<TIdentifier>();
                        TRArrow trarrow = Pop<TRArrow>();
                        PExpression pexpression = Pop<PExpression>();
                        APointerElement apointerelement = new APointerElement(
                            tidentifier
                        );
                        AElementExpression aelementexpression = new AElementExpression(
                            pexpression,
                            apointerelement
                        );
                        Push(23, aelementexpression);
                    }
                    break;
                case 82:
                    {
                        TRSqu trsqu = Pop<TRSqu>();
                        PExpression pexpression = Pop<PExpression>();
                        TLSqu tlsqu = Pop<TLSqu>();
                        PExpression pexpression2 = Pop<PExpression>();
                        AIndexExpression aindexexpression = new AIndexExpression(
                            pexpression2,
                            pexpression
                        );
                        Push(23, aindexexpression);
                    }
                    break;
                case 83:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        Push(23, pexpression);
                    }
                    break;
                case 84:
                    {
                        TRPar trpar = Pop<TRPar>();
                        PExpression pexpression = Pop<PExpression>();
                        TLPar tlpar = Pop<TLPar>();
                        AParenthesisExpression aparenthesisexpression = new AParenthesisExpression(
                            pexpression
                        );
                        Push(24, aparenthesisexpression);
                    }
                    break;
                case 85:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        Push(24, pexpression);
                    }
                    break;
                case 86:
                    {
                        TNumber tnumber = Pop<TNumber>();
                        ANumberExpression anumberexpression = new ANumberExpression(
                            tnumber
                        );
                        Push(24, anumberexpression);
                    }
                    break;
                case 87:
                    {
                        TBool tbool = Pop<TBool>();
                        ABooleanExpression abooleanexpression = new ABooleanExpression(
                            tbool
                        );
                        Push(24, abooleanexpression);
                    }
                    break;
                case 88:
                    {
                        TIdentifier tidentifier = Pop<TIdentifier>();
                        AIdentifierExpression aidentifierexpression = new AIdentifierExpression(
                            tidentifier
                        );
                        Push(24, aidentifierexpression);
                    }
                    break;
                case 89:
                    {
                        TDeclassifyEnd tdeclassifyend = Pop<TDeclassifyEnd>();
                        TIdentifier tidentifier = Pop<TIdentifier>();
                        TDeclassifyStart tdeclassifystart = Pop<TDeclassifyStart>();
                        ADeclassifyExpression adeclassifyexpression = new ADeclassifyExpression(
                            tidentifier,
                            null
                        );
                        Push(24, adeclassifyexpression);
                    }
                    break;
                case 90:
                    {
                        TDeclassifyEnd tdeclassifyend = Pop<TDeclassifyEnd>();
                        PLabel plabel = Pop<PLabel>();
                        TComma tcomma = Pop<TComma>();
                        TIdentifier tidentifier = Pop<TIdentifier>();
                        TDeclassifyStart tdeclassifystart = Pop<TDeclassifyStart>();
                        ADeclassifyExpression adeclassifyexpression = new ADeclassifyExpression(
                            tidentifier,
                            plabel
                        );
                        Push(24, adeclassifyexpression);
                    }
                    break;
                case 91:
                case 92:
                    {
                        TRPar trpar = Pop<TRPar>();
                        List<PExpression> pexpressionlist = isOn(1, index - 91) ? Pop<List<PExpression>>() : new List<PExpression>();
                        TLPar tlpar = Pop<TLPar>();
                        TIdentifier tidentifier = Pop<TIdentifier>();
                        List<PExpression> pexpressionlist2 = new List<PExpression>();
                        pexpressionlist2.AddRange(pexpressionlist);
                        AFunctionCallExpression afunctioncallexpression = new AFunctionCallExpression(
                            tidentifier,
                            pexpressionlist2
                        );
                        Push(25, afunctioncallexpression);
                    }
                    break;
                case 93:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        List<PExpression> pexpressionlist = new List<PExpression>();
                        pexpressionlist.Add(pexpression);
                        Push(26, pexpressionlist);
                    }
                    break;
                case 94:
                    {
                        List<PExpression> pexpressionlist = Pop<List<PExpression>>();
                        TComma tcomma = Pop<TComma>();
                        PExpression pexpression = Pop<PExpression>();
                        List<PExpression> pexpressionlist2 = new List<PExpression>();
                        pexpressionlist2.Add(pexpression);
                        pexpressionlist2.AddRange(pexpressionlist);
                        Push(26, pexpressionlist2);
                    }
                    break;
                case 95:
                    Push(27, new List<PInclude>() { Pop<PInclude>() });
                    break;
                case 96:
                    {
                        PInclude item = Pop<PInclude>();
                        List<PInclude> list = Pop<List<PInclude>>();
                        list.Add(item);
                        Push(27, list);
                    }
                    break;
                case 97:
                    Push(28, new List<PPrincipalDeclaration>() { Pop<PPrincipalDeclaration>() });
                    break;
                case 98:
                    {
                        PPrincipalDeclaration item = Pop<PPrincipalDeclaration>();
                        List<PPrincipalDeclaration> list = Pop<List<PPrincipalDeclaration>>();
                        list.Add(item);
                        Push(28, list);
                    }
                    break;
                case 99:
                    Push(29, new List<PStruct>() { Pop<PStruct>() });
                    break;
                case 100:
                    {
                        PStruct item = Pop<PStruct>();
                        List<PStruct> list = Pop<List<PStruct>>();
                        list.Add(item);
                        Push(29, list);
                    }
                    break;
                case 101:
                    Push(30, new List<PStatement>() { Pop<PStatement>() });
                    break;
                case 102:
                    {
                        PStatement item = Pop<PStatement>();
                        List<PStatement> list = Pop<List<PStatement>>();
                        list.Add(item);
                        Push(30, list);
                    }
                    break;
                case 103:
                    Push(31, new List<PField>() { Pop<PField>() });
                    break;
                case 104:
                    {
                        PField item = Pop<PField>();
                        List<PField> list = Pop<List<PField>>();
                        list.Add(item);
                        Push(31, list);
                    }
                    break;
                case 105:
                    Push(32, new List<PStatement>() { Pop<PStatement>() });
                    break;
                case 106:
                    {
                        PStatement item = Pop<PStatement>();
                        List<PStatement> list = Pop<List<PStatement>>();
                        list.Add(item);
                        Push(32, list);
                    }
                    break;
            }
        }
        
        #region actionTable
        private static int[][][] actionTable = {
            new int[][] {
                new int[] {-1, 1, 0},
                new int[] {0, 0, 1},
                new int[] {4, 0, 2},
                new int[] {5, 0, 3},
                new int[] {11, 0, 4},
            },
            new int[][] {
                new int[] {-1, 3, 1},
                new int[] {1, 0, 15},
            },
            new int[][] {
                new int[] {-1, 3, 2},
                new int[] {11, 0, 16},
            },
            new int[][] {
                new int[] {-1, 3, 3},
                new int[] {6, 0, 17},
            },
            new int[][] {
                new int[] {-1, 1, 44},
                new int[] {33, 0, 18},
            },
            new int[][] {
                new int[] {-1, 3, 5},
                new int[] {42, 2, -1},
            },
            new int[][] {
                new int[] {-1, 1, 95},
            },
            new int[][] {
                new int[] {-1, 1, 97},
            },
            new int[][] {
                new int[] {-1, 1, 99},
            },
            new int[][] {
                new int[] {-1, 1, 101},
            },
            new int[][] {
                new int[] {-1, 3, 10},
                new int[] {11, 0, 20},
                new int[] {23, 0, 21},
            },
            new int[][] {
                new int[] {-1, 1, 1},
                new int[] {0, 0, 1},
                new int[] {4, 0, 2},
                new int[] {5, 0, 3},
                new int[] {11, 0, 4},
            },
            new int[][] {
                new int[] {-1, 1, 2},
                new int[] {4, 0, 2},
                new int[] {5, 0, 3},
                new int[] {11, 0, 4},
            },
            new int[][] {
                new int[] {-1, 1, 4},
                new int[] {5, 0, 3},
                new int[] {11, 0, 4},
            },
            new int[][] {
                new int[] {-1, 1, 8},
                new int[] {11, 0, 4},
            },
            new int[][] {
                new int[] {-1, 1, 16},
            },
            new int[][] {
                new int[] {-1, 3, 16},
                new int[] {32, 0, 32},
            },
            new int[][] {
                new int[] {-1, 3, 17},
                new int[] {11, 0, 33},
            },
            new int[][] {
                new int[] {-1, 3, 18},
                new int[] {11, 0, 34},
                new int[] {19, 0, 35},
                new int[] {20, 0, 36},
            },
            new int[][] {
                new int[] {-1, 1, 45},
            },
            new int[][] {
                new int[] {-1, 3, 20},
                new int[] {18, 0, 40},
                new int[] {32, 0, 41},
                new int[] {35, 0, 42},
                new int[] {37, 0, 43},
            },
            new int[][] {
                new int[] {-1, 1, 46},
            },
            new int[][] {
                new int[] {-1, 1, 96},
            },
            new int[][] {
                new int[] {-1, 1, 3},
                new int[] {4, 0, 2},
                new int[] {5, 0, 3},
                new int[] {11, 0, 4},
            },
            new int[][] {
                new int[] {-1, 1, 5},
                new int[] {5, 0, 3},
                new int[] {11, 0, 4},
            },
            new int[][] {
                new int[] {-1, 1, 9},
                new int[] {11, 0, 4},
            },
            new int[][] {
                new int[] {-1, 1, 98},
            },
            new int[][] {
                new int[] {-1, 1, 6},
                new int[] {5, 0, 3},
                new int[] {11, 0, 4},
            },
            new int[][] {
                new int[] {-1, 1, 10},
                new int[] {11, 0, 4},
            },
            new int[][] {
                new int[] {-1, 1, 100},
            },
            new int[][] {
                new int[] {-1, 1, 12},
                new int[] {11, 0, 4},
            },
            new int[][] {
                new int[] {-1, 1, 102},
            },
            new int[][] {
                new int[] {-1, 1, 17},
            },
            new int[][] {
                new int[] {-1, 3, 33},
                new int[] {39, 0, 48},
            },
            new int[][] {
                new int[] {-1, 1, 54},
                new int[] {15, 1, 62},
            },
            new int[][] {
                new int[] {-1, 1, 57},
            },
            new int[][] {
                new int[] {-1, 1, 58},
            },
            new int[][] {
                new int[] {-1, 1, 59},
                new int[] {32, 0, 49},
                new int[] {41, 0, 50},
            },
            new int[][] {
                new int[] {-1, 3, 38},
                new int[] {34, 0, 51},
            },
            new int[][] {
                new int[] {-1, 3, 39},
                new int[] {15, 0, 52},
            },
            new int[][] {
                new int[] {-1, 3, 40},
                new int[] {2, 0, 53},
                new int[] {3, 0, 54},
                new int[] {11, 0, 55},
                new int[] {13, 0, 56},
                new int[] {22, 0, 57},
                new int[] {26, 0, 58},
                new int[] {35, 0, 59},
            },
            new int[][] {
                new int[] {-1, 1, 22},
            },
            new int[][] {
                new int[] {-1, 3, 42},
                new int[] {11, 0, 4},
            },
            new int[][] {
                new int[] {-1, 3, 43},
                new int[] {3, 0, 70},
            },
            new int[][] {
                new int[] {-1, 1, 7},
                new int[] {5, 0, 3},
                new int[] {11, 0, 4},
            },
            new int[][] {
                new int[] {-1, 1, 11},
                new int[] {11, 0, 4},
            },
            new int[][] {
                new int[] {-1, 1, 13},
                new int[] {11, 0, 4},
            },
            new int[][] {
                new int[] {-1, 1, 14},
                new int[] {11, 0, 4},
            },
            new int[][] {
                new int[] {-1, 3, 48},
                new int[] {11, 0, 4},
                new int[] {40, 0, 72},
            },
            new int[][] {
                new int[] {-1, 3, 49},
                new int[] {11, 0, 34},
                new int[] {19, 0, 35},
                new int[] {20, 0, 36},
            },
            new int[][] {
                new int[] {-1, 3, 50},
                new int[] {11, 0, 34},
                new int[] {19, 0, 35},
                new int[] {20, 0, 36},
            },
            new int[][] {
                new int[] {-1, 1, 53},
            },
            new int[][] {
                new int[] {-1, 1, 56},
                new int[] {11, 0, 78},
            },
            new int[][] {
                new int[] {-1, 1, 87},
            },
            new int[][] {
                new int[] {-1, 1, 86},
            },
            new int[][] {
                new int[] {-1, 1, 88},
                new int[] {35, 0, 81},
            },
            new int[][] {
                new int[] {-1, 3, 56},
                new int[] {11, 0, 82},
            },
            new int[][] {
                new int[] {-1, 3, 57},
                new int[] {2, 0, 53},
                new int[] {3, 0, 54},
                new int[] {11, 0, 55},
                new int[] {13, 0, 56},
                new int[] {35, 0, 59},
            },
            new int[][] {
                new int[] {-1, 3, 58},
                new int[] {2, 0, 53},
                new int[] {3, 0, 54},
                new int[] {11, 0, 55},
                new int[] {13, 0, 56},
                new int[] {22, 0, 57},
                new int[] {35, 0, 59},
            },
            new int[][] {
                new int[] {-1, 3, 59},
                new int[] {2, 0, 53},
                new int[] {3, 0, 54},
                new int[] {11, 0, 55},
                new int[] {13, 0, 56},
                new int[] {22, 0, 57},
                new int[] {26, 0, 58},
                new int[] {35, 0, 59},
            },
            new int[][] {
                new int[] {-1, 3, 60},
                new int[] {32, 0, 86},
            },
            new int[][] {
                new int[] {-1, 1, 65},
            },
            new int[][] {
                new int[] {-1, 1, 68},
                new int[] {27, 0, 87},
                new int[] {28, 0, 88},
            },
            new int[][] {
                new int[] {-1, 1, 71},
                new int[] {17, 0, 89},
            },
            new int[][] {
                new int[] {-1, 1, 75},
                new int[] {21, 0, 90},
                new int[] {22, 0, 91},
            },
            new int[][] {
                new int[] {-1, 1, 79},
                new int[] {15, 0, 92},
                new int[] {23, 0, 93},
                new int[] {24, 0, 94},
                new int[] {25, 0, 95},
                new int[] {29, 0, 96},
                new int[] {37, 0, 97},
            },
            new int[][] {
                new int[] {-1, 1, 83},
            },
            new int[][] {
                new int[] {-1, 1, 85},
            },
            new int[][] {
                new int[] {-1, 3, 68},
                new int[] {36, 0, 98},
            },
            new int[][] {
                new int[] {-1, 3, 69},
                new int[] {11, 0, 99},
                new int[] {23, 0, 21},
            },
            new int[][] {
                new int[] {-1, 3, 70},
                new int[] {38, 0, 100},
            },
            new int[][] {
                new int[] {-1, 1, 15},
                new int[] {11, 0, 4},
            },
            new int[][] {
                new int[] {-1, 3, 72},
                new int[] {11, 0, 101},
            },
            new int[][] {
                new int[] {-1, 1, 103},
            },
            new int[][] {
                new int[] {-1, 3, 74},
                new int[] {11, 0, 102},
                new int[] {23, 0, 21},
            },
            new int[][] {
                new int[] {-1, 3, 75},
                new int[] {11, 0, 4},
                new int[] {40, 0, 103},
            },
            new int[][] {
                new int[] {-1, 1, 60},
            },
            new int[][] {
                new int[] {-1, 1, 61},
            },
            new int[][] {
                new int[] {-1, 1, 62},
            },
            new int[][] {
                new int[] {-1, 1, 63},
                new int[] {30, 0, 105},
            },
            new int[][] {
                new int[] {-1, 1, 55},
            },
            new int[][] {
                new int[] {-1, 3, 81},
                new int[] {2, 0, 53},
                new int[] {3, 0, 54},
                new int[] {11, 0, 55},
                new int[] {13, 0, 56},
                new int[] {22, 0, 57},
                new int[] {26, 0, 58},
                new int[] {35, 0, 59},
                new int[] {36, 0, 106},
            },
            new int[][] {
                new int[] {-1, 3, 82},
                new int[] {14, 0, 109},
                new int[] {30, 0, 110},
            },
            new int[][] {
                new int[] {-1, 1, 74},
            },
            new int[][] {
                new int[] {-1, 1, 70},
            },
            new int[][] {
                new int[] {-1, 3, 85},
                new int[] {36, 0, 111},
            },
            new int[][] {
                new int[] {-1, 1, 23},
            },
            new int[][] {
                new int[] {-1, 3, 87},
                new int[] {2, 0, 53},
                new int[] {3, 0, 54},
                new int[] {11, 0, 55},
                new int[] {13, 0, 56},
                new int[] {22, 0, 57},
                new int[] {26, 0, 58},
                new int[] {35, 0, 59},
            },
            new int[][] {
                new int[] {-1, 3, 88},
                new int[] {2, 0, 53},
                new int[] {3, 0, 54},
                new int[] {11, 0, 55},
                new int[] {13, 0, 56},
                new int[] {22, 0, 57},
                new int[] {26, 0, 58},
                new int[] {35, 0, 59},
            },
            new int[][] {
                new int[] {-1, 3, 89},
                new int[] {2, 0, 53},
                new int[] {3, 0, 54},
                new int[] {11, 0, 55},
                new int[] {13, 0, 56},
                new int[] {22, 0, 57},
                new int[] {26, 0, 58},
                new int[] {35, 0, 59},
            },
            new int[][] {
                new int[] {-1, 3, 90},
                new int[] {2, 0, 53},
                new int[] {3, 0, 54},
                new int[] {11, 0, 55},
                new int[] {13, 0, 56},
                new int[] {22, 0, 57},
                new int[] {35, 0, 59},
            },
            new int[][] {
                new int[] {-1, 3, 91},
                new int[] {2, 0, 53},
                new int[] {3, 0, 54},
                new int[] {11, 0, 55},
                new int[] {13, 0, 56},
                new int[] {22, 0, 57},
                new int[] {35, 0, 59},
            },
            new int[][] {
                new int[] {-1, 3, 92},
                new int[] {11, 0, 117},
            },
            new int[][] {
                new int[] {-1, 3, 93},
                new int[] {2, 0, 53},
                new int[] {3, 0, 54},
                new int[] {11, 0, 55},
                new int[] {13, 0, 56},
                new int[] {35, 0, 59},
            },
            new int[][] {
                new int[] {-1, 3, 94},
                new int[] {2, 0, 53},
                new int[] {3, 0, 54},
                new int[] {11, 0, 55},
                new int[] {13, 0, 56},
                new int[] {35, 0, 59},
            },
            new int[][] {
                new int[] {-1, 3, 95},
                new int[] {2, 0, 53},
                new int[] {3, 0, 54},
                new int[] {11, 0, 55},
                new int[] {13, 0, 56},
                new int[] {35, 0, 59},
            },
            new int[][] {
                new int[] {-1, 3, 96},
                new int[] {11, 0, 121},
            },
            new int[][] {
                new int[] {-1, 3, 97},
                new int[] {2, 0, 53},
                new int[] {3, 0, 54},
                new int[] {11, 0, 55},
                new int[] {13, 0, 56},
                new int[] {22, 0, 57},
                new int[] {26, 0, 58},
                new int[] {35, 0, 59},
            },
            new int[][] {
                new int[] {-1, 3, 98},
                new int[] {39, 0, 123},
            },
            new int[][] {
                new int[] {-1, 1, 27},
                new int[] {30, 0, 124},
            },
            new int[][] {
                new int[] {-1, 1, 24},
            },
            new int[][] {
                new int[] {-1, 3, 101},
                new int[] {32, 0, 125},
            },
            new int[][] {
                new int[] {-1, 3, 102},
                new int[] {32, 0, 126},
                new int[] {37, 0, 127},
            },
            new int[][] {
                new int[] {-1, 3, 103},
                new int[] {11, 0, 128},
            },
            new int[][] {
                new int[] {-1, 1, 104},
            },
            new int[][] {
                new int[] {-1, 3, 105},
                new int[] {11, 0, 78},
            },
            new int[][] {
                new int[] {-1, 1, 91},
            },
            new int[][] {
                new int[] {-1, 1, 93},
                new int[] {30, 0, 130},
            },
            new int[][] {
                new int[] {-1, 3, 108},
                new int[] {36, 0, 131},
            },
            new int[][] {
                new int[] {-1, 1, 89},
            },
            new int[][] {
                new int[] {-1, 3, 110},
                new int[] {33, 0, 18},
            },
            new int[][] {
                new int[] {-1, 1, 84},
            },
            new int[][] {
                new int[] {-1, 1, 66},
            },
            new int[][] {
                new int[] {-1, 1, 67},
            },
            new int[][] {
                new int[] {-1, 1, 69},
            },
            new int[][] {
                new int[] {-1, 1, 72},
            },
            new int[][] {
                new int[] {-1, 1, 73},
            },
            new int[][] {
                new int[] {-1, 1, 81},
            },
            new int[][] {
                new int[] {-1, 1, 76},
            },
            new int[][] {
                new int[] {-1, 1, 77},
            },
            new int[][] {
                new int[] {-1, 1, 78},
            },
            new int[][] {
                new int[] {-1, 1, 80},
            },
            new int[][] {
                new int[] {-1, 3, 122},
                new int[] {38, 0, 133},
            },
            new int[][] {
                new int[] {-1, 3, 123},
                new int[] {7, 0, 134},
                new int[] {8, 0, 135},
                new int[] {10, 0, 136},
                new int[] {11, 0, 137},
                new int[] {40, 0, 138},
            },
            new int[][] {
                new int[] {-1, 3, 124},
                new int[] {11, 0, 4},
            },
            new int[][] {
                new int[] {-1, 1, 18},
            },
            new int[][] {
                new int[] {-1, 1, 20},
            },
            new int[][] {
                new int[] {-1, 3, 127},
                new int[] {3, 0, 144},
            },
            new int[][] {
                new int[] {-1, 3, 128},
                new int[] {32, 0, 145},
            },
            new int[][] {
                new int[] {-1, 1, 64},
            },
            new int[][] {
                new int[] {-1, 3, 130},
                new int[] {2, 0, 53},
                new int[] {3, 0, 54},
                new int[] {11, 0, 55},
                new int[] {13, 0, 56},
                new int[] {22, 0, 57},
                new int[] {26, 0, 58},
                new int[] {35, 0, 59},
            },
            new int[][] {
                new int[] {-1, 1, 92},
            },
            new int[][] {
                new int[] {-1, 3, 132},
                new int[] {14, 0, 147},
            },
            new int[][] {
                new int[] {-1, 1, 82},
            },
            new int[][] {
                new int[] {-1, 3, 134},
                new int[] {35, 0, 148},
            },
            new int[][] {
                new int[] {-1, 3, 135},
                new int[] {35, 0, 149},
            },
            new int[][] {
                new int[] {-1, 3, 136},
                new int[] {2, 0, 53},
                new int[] {3, 0, 54},
                new int[] {11, 0, 55},
                new int[] {13, 0, 56},
                new int[] {22, 0, 57},
                new int[] {26, 0, 58},
                new int[] {32, 0, 150},
                new int[] {35, 0, 59},
            },
            new int[][] {
                new int[] {-1, 1, 44},
                new int[] {12, 0, 152},
                new int[] {18, 0, 153},
                new int[] {33, 0, 18},
            },
            new int[][] {
                new int[] {-1, 1, 25},
            },
            new int[][] {
                new int[] {-1, 1, 105},
            },
            new int[][] {
                new int[] {-1, 1, 32},
            },
            new int[][] {
                new int[] {-1, 3, 141},
                new int[] {11, 0, 154},
                new int[] {23, 0, 21},
            },
            new int[][] {
                new int[] {-1, 3, 142},
                new int[] {7, 0, 134},
                new int[] {8, 0, 135},
                new int[] {10, 0, 136},
                new int[] {11, 0, 137},
                new int[] {40, 0, 155},
            },
            new int[][] {
                new int[] {-1, 1, 28},
            },
            new int[][] {
                new int[] {-1, 3, 144},
                new int[] {38, 0, 157},
            },
            new int[][] {
                new int[] {-1, 1, 19},
            },
            new int[][] {
                new int[] {-1, 1, 94},
            },
            new int[][] {
                new int[] {-1, 1, 90},
            },
            new int[][] {
                new int[] {-1, 3, 148},
                new int[] {2, 0, 53},
                new int[] {3, 0, 54},
                new int[] {11, 0, 55},
                new int[] {13, 0, 56},
                new int[] {22, 0, 57},
                new int[] {26, 0, 58},
                new int[] {35, 0, 59},
            },
            new int[][] {
                new int[] {-1, 3, 149},
                new int[] {2, 0, 53},
                new int[] {3, 0, 54},
                new int[] {11, 0, 55},
                new int[] {13, 0, 56},
                new int[] {22, 0, 57},
                new int[] {26, 0, 58},
                new int[] {35, 0, 59},
            },
            new int[][] {
                new int[] {-1, 1, 40},
            },
            new int[][] {
                new int[] {-1, 3, 151},
                new int[] {32, 0, 160},
            },
            new int[][] {
                new int[] {-1, 3, 152},
                new int[] {11, 0, 78},
            },
            new int[][] {
                new int[] {-1, 3, 153},
                new int[] {2, 0, 53},
                new int[] {3, 0, 54},
                new int[] {11, 0, 55},
                new int[] {13, 0, 56},
                new int[] {22, 0, 57},
                new int[] {26, 0, 58},
                new int[] {35, 0, 59},
            },
            new int[][] {
                new int[] {-1, 3, 154},
                new int[] {18, 0, 163},
                new int[] {32, 0, 164},
                new int[] {37, 0, 165},
            },
            new int[][] {
                new int[] {-1, 1, 26},
            },
            new int[][] {
                new int[] {-1, 1, 106},
            },
            new int[][] {
                new int[] {-1, 3, 157},
                new int[] {32, 0, 166},
            },
            new int[][] {
                new int[] {-1, 3, 158},
                new int[] {36, 0, 167},
            },
            new int[][] {
                new int[] {-1, 3, 159},
                new int[] {36, 0, 168},
            },
            new int[][] {
                new int[] {-1, 1, 41},
            },
            new int[][] {
                new int[] {-1, 3, 161},
                new int[] {39, 0, 169},
            },
            new int[][] {
                new int[] {-1, 3, 162},
                new int[] {32, 0, 170},
            },
            new int[][] {
                new int[] {-1, 3, 163},
                new int[] {2, 0, 53},
                new int[] {3, 0, 54},
                new int[] {11, 0, 55},
                new int[] {13, 0, 56},
                new int[] {22, 0, 57},
                new int[] {26, 0, 58},
                new int[] {35, 0, 59},
            },
            new int[][] {
                new int[] {-1, 1, 36},
            },
            new int[][] {
                new int[] {-1, 3, 165},
                new int[] {3, 0, 172},
            },
            new int[][] {
                new int[] {-1, 1, 21},
            },
            new int[][] {
                new int[] {-1, 3, 167},
                new int[] {7, 0, 134},
                new int[] {8, 0, 135},
                new int[] {10, 0, 136},
                new int[] {11, 0, 137},
                new int[] {39, 0, 173},
            },
            new int[][] {
                new int[] {-1, 3, 168},
                new int[] {7, 0, 176},
                new int[] {8, 0, 177},
                new int[] {10, 0, 136},
                new int[] {11, 0, 137},
                new int[] {39, 0, 178},
            },
            new int[][] {
                new int[] {-1, 3, 169},
                new int[] {7, 0, 134},
                new int[] {8, 0, 135},
                new int[] {10, 0, 136},
                new int[] {11, 0, 137},
                new int[] {40, 0, 183},
            },
            new int[][] {
                new int[] {-1, 1, 39},
            },
            new int[][] {
                new int[] {-1, 3, 171},
                new int[] {32, 0, 185},
            },
            new int[][] {
                new int[] {-1, 3, 172},
                new int[] {38, 0, 186},
            },
            new int[][] {
                new int[] {-1, 3, 173},
                new int[] {7, 0, 134},
                new int[] {8, 0, 135},
                new int[] {10, 0, 136},
                new int[] {11, 0, 137},
                new int[] {40, 0, 187},
            },
            new int[][] {
                new int[] {-1, 1, 47},
            },
            new int[][] {
                new int[] {-1, 1, 31},
            },
            new int[][] {
                new int[] {-1, 3, 176},
                new int[] {35, 0, 189},
            },
            new int[][] {
                new int[] {-1, 3, 177},
                new int[] {35, 0, 190},
            },
            new int[][] {
                new int[] {-1, 3, 178},
                new int[] {7, 0, 134},
                new int[] {8, 0, 135},
                new int[] {10, 0, 136},
                new int[] {11, 0, 137},
                new int[] {40, 0, 191},
            },
            new int[][] {
                new int[] {-1, 1, 50},
            },
            new int[][] {
                new int[] {-1, 1, 32},
                new int[] {9, 1, 35},
            },
            new int[][] {
                new int[] {-1, 1, 29},
            },
            new int[][] {
                new int[] {-1, 3, 182},
                new int[] {9, 0, 193},
            },
            new int[][] {
                new int[] {-1, 1, 42},
            },
            new int[][] {
                new int[] {-1, 3, 184},
                new int[] {7, 0, 134},
                new int[] {8, 0, 135},
                new int[] {10, 0, 136},
                new int[] {11, 0, 137},
                new int[] {40, 0, 194},
            },
            new int[][] {
                new int[] {-1, 1, 37},
            },
            new int[][] {
                new int[] {-1, 1, 38},
            },
            new int[][] {
                new int[] {-1, 1, 48},
            },
            new int[][] {
                new int[] {-1, 3, 188},
                new int[] {7, 0, 134},
                new int[] {8, 0, 135},
                new int[] {10, 0, 136},
                new int[] {11, 0, 137},
                new int[] {40, 0, 195},
            },
            new int[][] {
                new int[] {-1, 3, 189},
                new int[] {2, 0, 53},
                new int[] {3, 0, 54},
                new int[] {11, 0, 55},
                new int[] {13, 0, 56},
                new int[] {22, 0, 57},
                new int[] {26, 0, 58},
                new int[] {35, 0, 59},
            },
            new int[][] {
                new int[] {-1, 3, 190},
                new int[] {2, 0, 53},
                new int[] {3, 0, 54},
                new int[] {11, 0, 55},
                new int[] {13, 0, 56},
                new int[] {22, 0, 57},
                new int[] {26, 0, 58},
                new int[] {35, 0, 59},
            },
            new int[][] {
                new int[] {-1, 1, 48},
                new int[] {9, 1, 51},
            },
            new int[][] {
                new int[] {-1, 3, 192},
                new int[] {7, 0, 134},
                new int[] {8, 0, 135},
                new int[] {10, 0, 136},
                new int[] {11, 0, 137},
                new int[] {40, 0, 198},
            },
            new int[][] {
                new int[] {-1, 3, 193},
                new int[] {7, 0, 199},
                new int[] {8, 0, 200},
                new int[] {10, 0, 136},
                new int[] {11, 0, 137},
                new int[] {39, 0, 201},
            },
            new int[][] {
                new int[] {-1, 1, 43},
            },
            new int[][] {
                new int[] {-1, 1, 49},
            },
            new int[][] {
                new int[] {-1, 3, 196},
                new int[] {36, 0, 204},
            },
            new int[][] {
                new int[] {-1, 3, 197},
                new int[] {36, 0, 205},
            },
            new int[][] {
                new int[] {-1, 1, 49},
                new int[] {9, 1, 52},
            },
            new int[][] {
                new int[] {-1, 3, 199},
                new int[] {35, 0, 206},
            },
            new int[][] {
                new int[] {-1, 3, 200},
                new int[] {35, 0, 207},
            },
            new int[][] {
                new int[] {-1, 3, 201},
                new int[] {7, 0, 134},
                new int[] {8, 0, 135},
                new int[] {10, 0, 136},
                new int[] {11, 0, 137},
                new int[] {40, 0, 208},
            },
            new int[][] {
                new int[] {-1, 1, 35},
            },
            new int[][] {
                new int[] {-1, 1, 30},
            },
            new int[][] {
                new int[] {-1, 3, 204},
                new int[] {7, 0, 176},
                new int[] {8, 0, 177},
                new int[] {10, 0, 136},
                new int[] {11, 0, 137},
                new int[] {39, 0, 178},
            },
            new int[][] {
                new int[] {-1, 3, 205},
                new int[] {7, 0, 176},
                new int[] {8, 0, 177},
                new int[] {10, 0, 136},
                new int[] {11, 0, 137},
                new int[] {39, 0, 178},
            },
            new int[][] {
                new int[] {-1, 3, 206},
                new int[] {2, 0, 53},
                new int[] {3, 0, 54},
                new int[] {11, 0, 55},
                new int[] {13, 0, 56},
                new int[] {22, 0, 57},
                new int[] {26, 0, 58},
                new int[] {35, 0, 59},
            },
            new int[][] {
                new int[] {-1, 3, 207},
                new int[] {2, 0, 53},
                new int[] {3, 0, 54},
                new int[] {11, 0, 55},
                new int[] {13, 0, 56},
                new int[] {22, 0, 57},
                new int[] {26, 0, 58},
                new int[] {35, 0, 59},
            },
            new int[][] {
                new int[] {-1, 1, 51},
            },
            new int[][] {
                new int[] {-1, 3, 209},
                new int[] {7, 0, 134},
                new int[] {8, 0, 135},
                new int[] {10, 0, 136},
                new int[] {11, 0, 137},
                new int[] {40, 0, 214},
            },
            new int[][] {
                new int[] {-1, 1, 34},
            },
            new int[][] {
                new int[] {-1, 3, 211},
                new int[] {9, 0, 215},
            },
            new int[][] {
                new int[] {-1, 3, 212},
                new int[] {36, 0, 216},
            },
            new int[][] {
                new int[] {-1, 3, 213},
                new int[] {36, 0, 217},
            },
            new int[][] {
                new int[] {-1, 1, 52},
            },
            new int[][] {
                new int[] {-1, 3, 215},
                new int[] {7, 0, 199},
                new int[] {8, 0, 200},
                new int[] {10, 0, 136},
                new int[] {11, 0, 137},
                new int[] {39, 0, 201},
            },
            new int[][] {
                new int[] {-1, 3, 216},
                new int[] {7, 0, 199},
                new int[] {8, 0, 200},
                new int[] {10, 0, 136},
                new int[] {11, 0, 137},
                new int[] {39, 0, 201},
            },
            new int[][] {
                new int[] {-1, 3, 217},
                new int[] {7, 0, 199},
                new int[] {8, 0, 200},
                new int[] {10, 0, 136},
                new int[] {11, 0, 137},
                new int[] {39, 0, 201},
            },
            new int[][] {
                new int[] {-1, 1, 30},
                new int[] {9, 1, 33},
            },
            new int[][] {
                new int[] {-1, 3, 219},
                new int[] {9, 0, 220},
            },
            new int[][] {
                new int[] {-1, 3, 220},
                new int[] {7, 0, 199},
                new int[] {8, 0, 200},
                new int[] {10, 0, 136},
                new int[] {11, 0, 137},
                new int[] {39, 0, 201},
            },
            new int[][] {
                new int[] {-1, 1, 33},
            },
        };
        #endregion
        #region gotoTable
        private static int[][][] gotoTable = {
            new int[][] {
                new int[] {-1, 5},
            },
            new int[][] {
                new int[] {-1, 6},
                new int[] {11, 22},
            },
            new int[][] {
                new int[] {-1, 7},
                new int[] {12, 26},
                new int[] {23, 26},
            },
            new int[][] {
                new int[] {-1, 8},
                new int[] {13, 29},
                new int[] {24, 29},
                new int[] {27, 29},
                new int[] {44, 29},
            },
            new int[][] {
                new int[] {-1, 73},
                new int[] {75, 104},
            },
            new int[][] {
                new int[] {-1, 9},
                new int[] {14, 31},
                new int[] {25, 31},
                new int[] {28, 31},
                new int[] {30, 31},
                new int[] {45, 31},
                new int[] {46, 31},
                new int[] {47, 31},
                new int[] {71, 31},
            },
            new int[][] {
                new int[] {-1, 68},
                new int[] {124, 143},
            },
            new int[][] {
                new int[] {-1, 139},
                new int[] {142, 156},
                new int[] {167, 174},
                new int[] {168, 174},
                new int[] {184, 156},
                new int[] {188, 156},
                new int[] {192, 156},
                new int[] {204, 174},
                new int[] {205, 174},
                new int[] {209, 156},
            },
            new int[][] {
                new int[] {-1, 179},
            },
            new int[][] {
                new int[] {-1, 140},
                new int[] {168, 180},
                new int[] {193, 202},
                new int[] {204, 180},
                new int[] {205, 180},
                new int[] {215, 202},
                new int[] {216, 202},
                new int[] {217, 202},
                new int[] {220, 202},
            },
            new int[][] {
                new int[] {-1, 141},
                new int[] {0, 10},
                new int[] {11, 10},
                new int[] {12, 10},
                new int[] {13, 10},
                new int[] {14, 10},
                new int[] {23, 10},
                new int[] {24, 10},
                new int[] {25, 10},
                new int[] {27, 10},
                new int[] {28, 10},
                new int[] {30, 10},
                new int[] {42, 69},
                new int[] {44, 10},
                new int[] {45, 10},
                new int[] {46, 10},
                new int[] {47, 10},
                new int[] {48, 74},
                new int[] {71, 10},
                new int[] {75, 74},
                new int[] {124, 69},
            },
            new int[][] {
                new int[] {-1, 175},
                new int[] {168, 181},
                new int[] {205, 181},
            },
            new int[][] {
                new int[] {-1, 210},
                new int[] {168, 182},
                new int[] {193, 203},
                new int[] {205, 211},
                new int[] {215, 218},
                new int[] {217, 219},
                new int[] {220, 221},
            },
            new int[][] {
                new int[] {-1, 19},
                new int[] {110, 132},
            },
            new int[][] {
                new int[] {-1, 37},
            },
            new int[][] {
                new int[] {-1, 38},
                new int[] {49, 76},
                new int[] {50, 77},
            },
            new int[][] {
                new int[] {-1, 39},
                new int[] {52, 79},
                new int[] {105, 79},
                new int[] {152, 161},
            },
            new int[][] {
                new int[] {-1, 80},
                new int[] {105, 129},
            },
            new int[][] {
                new int[] {-1, 107},
                new int[] {40, 60},
                new int[] {59, 85},
                new int[] {97, 122},
                new int[] {136, 151},
                new int[] {148, 158},
                new int[] {149, 159},
                new int[] {153, 162},
                new int[] {163, 171},
                new int[] {189, 196},
                new int[] {190, 197},
                new int[] {206, 212},
                new int[] {207, 213},
            },
            new int[][] {
                new int[] {-1, 61},
                new int[] {87, 112},
                new int[] {88, 113},
            },
            new int[][] {
                new int[] {-1, 62},
                new int[] {89, 114},
            },
            new int[][] {
                new int[] {-1, 63},
                new int[] {58, 84},
                new int[] {90, 115},
                new int[] {91, 116},
            },
            new int[][] {
                new int[] {-1, 64},
                new int[] {57, 83},
                new int[] {93, 118},
                new int[] {94, 119},
                new int[] {95, 120},
            },
            new int[][] {
                new int[] {-1, 65},
            },
            new int[][] {
                new int[] {-1, 66},
            },
            new int[][] {
                new int[] {-1, 67},
            },
            new int[][] {
                new int[] {-1, 108},
                new int[] {130, 146},
            },
            new int[][] {
                new int[] {-1, 11},
            },
            new int[][] {
                new int[] {-1, 12},
                new int[] {11, 23},
            },
            new int[][] {
                new int[] {-1, 13},
                new int[] {11, 24},
                new int[] {12, 27},
                new int[] {23, 44},
            },
            new int[][] {
                new int[] {-1, 14},
                new int[] {11, 25},
                new int[] {12, 28},
                new int[] {13, 30},
                new int[] {23, 45},
                new int[] {24, 46},
                new int[] {27, 47},
                new int[] {44, 71},
            },
            new int[][] {
                new int[] {-1, 75},
            },
            new int[][] {
                new int[] {-1, 142},
                new int[] {169, 184},
                new int[] {173, 188},
                new int[] {178, 192},
                new int[] {201, 209},
            },
        };
        #endregion
        #region errorMessages
        private static string[] errorMessages = {
            "Expecting: '#include', 'principal', 'typedef', TIdentifier or end of file",
            "Expecting: TFile",
            "Expecting: TIdentifier",
            "Expecting: 'struct'",
            "Expecting: TIdentifier, '*' or '{{'",
            "Expecting: end of file",
            "Expecting: 'principal', 'typedef', TIdentifier or end of file",
            "Expecting: 'typedef', TIdentifier or end of file",
            "Expecting: TIdentifier or end of file",
            "Expecting: TIdentifier or '*'",
            "Expecting: ';'",
            "Expecting: TIdentifier, '_' or '^'",
            "Expecting: '=', ';', '(' or '['",
            "Expecting: '{'",
            "Expecting: '->', ';', '}}' or '⊔'",
            "Expecting: ';', '}}' or '⊔'",
            "Expecting: '}}'",
            "Expecting: '->'",
            "Expecting: TBool, TNumber, TIdentifier, '<|', '-', '!' or '('",
            "Expecting: TNumber",
            "Expecting: TIdentifier or '}'",
            "Expecting: TIdentifier, '|>' or '*'",
            "Expecting: TIdentifier, ';', '}}' or '⊔'",
            "Expecting: '->', TCompare, '+', '-', '*', '/', '%', '&&', '||', '.', ',', ';', ')', '[' or ']'",
            "Expecting: '->', TCompare, '+', '-', '*', '/', '%', '&&', '||', '.', ',', ';', '(', ')', '[' or ']'",
            "Expecting: TBool, TNumber, TIdentifier, '<|' or '('",
            "Expecting: TBool, TNumber, TIdentifier, '<|', '-' or '('",
            "Expecting: ',', ';', ')' or ']'",
            "Expecting: '&&', '||', ',', ';', ')' or ']'",
            "Expecting: TCompare, '&&', '||', ',', ';', ')' or ']'",
            "Expecting: TCompare, '+', '-', '&&', '||', ',', ';', ')' or ']'",
            "Expecting: ')'",
            "Expecting: ']'",
            "Expecting: ',', ';', '}}', '{' or '⊔'",
            "Expecting: ',', ';', '}}' or '⊔'",
            "Expecting: TBool, TNumber, TIdentifier, '<|', '-', '!', '(' or ')'",
            "Expecting: '|>' or ','",
            "Expecting: ',' or ')'",
            "Expecting: ';' or '['",
            "Expecting: '{{'",
            "Expecting: 'while', 'if', 'return', TIdentifier or '}'",
            "Expecting: '|>'",
            "Expecting: '('",
            "Expecting: TBool, TNumber, TIdentifier, '<|', '-', '!', ';' or '('",
            "Expecting: TIdentifier, TActsFor, '=', '*' or '{{'",
            "Expecting: 'while', 'if', 'else', 'return', TIdentifier or '}'",
            "Expecting: '=', ';' or '['",
            "Expecting: 'while', 'if', 'return', TIdentifier or '{'",
            "Expecting: 'else'",
        };
        #endregion
        #region errors
        private static int[] errors = {
            0, 1, 2, 3, 4, 5, 0, 6, 7, 8, 9, 0, 6, 7, 8, 0,
            10, 2, 11, 9, 12, 9, 0, 6, 7, 8, 6, 7, 8, 7, 8, 8,
            6, 13, 14, 15, 15, 15, 16, 17, 18, 8, 2, 19, 7, 8, 8, 8,
            20, 11, 11, 21, 22, 23, 23, 24, 2, 25, 26, 18, 10, 27, 28, 29,
            30, 23, 23, 23, 31, 9, 32, 8, 2, 20, 9, 20, 16, 16, 33, 34,
            15, 35, 36, 29, 28, 31, 8, 18, 18, 18, 26, 26, 2, 25, 25, 25,
            2, 18, 13, 37, 8, 10, 38, 2, 20, 2, 23, 37, 31, 23, 39, 23,
            27, 27, 28, 29, 29, 23, 30, 30, 30, 23, 32, 40, 2, 7, 20, 19,
            10, 15, 18, 23, 41, 23, 42, 42, 43, 44, 8, 40, 40, 9, 40, 31,
            32, 7, 31, 23, 18, 18, 45, 10, 2, 18, 46, 8, 40, 10, 31, 31,
            45, 13, 10, 18, 45, 19, 20, 47, 47, 40, 45, 10, 32, 40, 40, 40,
            42, 42, 40, 45, 45, 40, 48, 45, 40, 45, 45, 40, 40, 18, 18, 45,
            40, 47, 45, 40, 31, 31, 45, 42, 42, 40, 45, 40, 47, 47, 18, 18,
            45, 40, 45, 48, 31, 31, 45, 47, 47, 47, 45, 48, 47, 45,
        };
        #endregion
    }
}
