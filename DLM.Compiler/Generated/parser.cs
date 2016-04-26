using System;
using System.Collections.Generic;
using DLM.Compiler.Nodes;
using SablePP.Tools.Nodes;

namespace DLM.Compiler.Parsing
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
        private int getIndex(TTime node)
        {
            return 2;
        }
        private int getIndex(TIntervalUnit node)
        {
            return 3;
        }
        private int getIndex(TBool node)
        {
            return 4;
        }
        private int getIndex(TNumber node)
        {
            return 5;
        }
        private int getIndex(TPrincipall node)
        {
            return 6;
        }
        private int getIndex(TTypedef node)
        {
            return 7;
        }
        private int getIndex(TStruct node)
        {
            return 8;
        }
        private int getIndex(TWhile node)
        {
            return 9;
        }
        private int getIndex(TIf node)
        {
            return 10;
        }
        private int getIndex(TElse node)
        {
            return 11;
        }
        private int getIndex(TReturn node)
        {
            return 12;
        }
        private int getIndex(TThis node)
        {
            return 13;
        }
        private int getIndex(TCaller node)
        {
            return 14;
        }
        private int getIndex(TNull node)
        {
            return 15;
        }
        private int getIndex(TIdentifier node)
        {
            return 16;
        }
        private int getIndex(TActsFor node)
        {
            return 17;
        }
        private int getIndex(TIfActsFor node)
        {
            return 18;
        }
        private int getIndex(TDeclassifyStart node)
        {
            return 19;
        }
        private int getIndex(TDeclassifyEnd node)
        {
            return 20;
        }
        private int getIndex(TFuncAuthStart node)
        {
            return 21;
        }
        private int getIndex(TFuncAuthEnd node)
        {
            return 22;
        }
        private int getIndex(TRArrow node)
        {
            return 23;
        }
        private int getIndex(TLArrow node)
        {
            return 24;
        }
        private int getIndex(TCompare node)
        {
            return 25;
        }
        private int getIndex(TAssign node)
        {
            return 26;
        }
        private int getIndex(TUnderscore node)
        {
            return 27;
        }
        private int getIndex(THat node)
        {
            return 28;
        }
        private int getIndex(TPlus node)
        {
            return 29;
        }
        private int getIndex(TMinus node)
        {
            return 30;
        }
        private int getIndex(TAsterisk node)
        {
            return 31;
        }
        private int getIndex(TSlash node)
        {
            return 32;
        }
        private int getIndex(TPercent node)
        {
            return 33;
        }
        private int getIndex(TBang node)
        {
            return 34;
        }
        private int getIndex(TAnd node)
        {
            return 35;
        }
        private int getIndex(TOr node)
        {
            return 36;
        }
        private int getIndex(TPeriod node)
        {
            return 37;
        }
        private int getIndex(TComma node)
        {
            return 38;
        }
        private int getIndex(TColon node)
        {
            return 39;
        }
        private int getIndex(TSemicolon node)
        {
            return 40;
        }
        private int getIndex(TLabelStart node)
        {
            return 41;
        }
        private int getIndex(TTimeStart node)
        {
            return 42;
        }
        private int getIndex(TLabelEnd node)
        {
            return 43;
        }
        private int getIndex(TLPar node)
        {
            return 44;
        }
        private int getIndex(TRPar node)
        {
            return 45;
        }
        private int getIndex(TLSqu node)
        {
            return 46;
        }
        private int getIndex(TRSqu node)
        {
            return 47;
        }
        private int getIndex(TLCur node)
        {
            return 48;
        }
        private int getIndex(TRCur node)
        {
            return 49;
        }
        private int getIndex(TJoin node)
        {
            return 50;
        }
        
        private int getIndex(EOF node)
        {
            return 51;
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
                case 16:
                case 17:
                case 18:
                case 19:
                case 20:
                case 21:
                case 22:
                case 23:
                case 24:
                case 25:
                case 26:
                case 27:
                case 28:
                case 29:
                case 30:
                case 31:
                    {
                        List<PStatement> pstatementlist = isOn(16, index - 0) ? Pop<List<PStatement>>() : new List<PStatement>();
                        List<PStruct> pstructlist = isOn(8, index - 0) ? Pop<List<PStruct>>() : new List<PStruct>();
                        List<PPrincipalHierarchyDeclaration> pprincipalhierarchydeclarationlist = isOn(4, index - 0) ? Pop<List<PPrincipalHierarchyDeclaration>>() : new List<PPrincipalHierarchyDeclaration>();
                        List<PPrincipalDeclaration> pprincipaldeclarationlist = isOn(2, index - 0) ? Pop<List<PPrincipalDeclaration>>() : new List<PPrincipalDeclaration>();
                        List<PInclude> pincludelist = isOn(1, index - 0) ? Pop<List<PInclude>>() : new List<PInclude>();
                        List<PInclude> pincludelist2 = new List<PInclude>();
                        pincludelist2.AddRange(pincludelist);
                        List<PPrincipalDeclaration> pprincipaldeclarationlist2 = new List<PPrincipalDeclaration>();
                        pprincipaldeclarationlist2.AddRange(pprincipaldeclarationlist);
                        List<PPrincipalHierarchyDeclaration> pprincipalhierarchydeclarationlist2 = new List<PPrincipalHierarchyDeclaration>();
                        pprincipalhierarchydeclarationlist2.AddRange(pprincipalhierarchydeclarationlist);
                        List<PStruct> pstructlist2 = new List<PStruct>();
                        pstructlist2.AddRange(pstructlist);
                        List<PStatement> pstatementlist2 = new List<PStatement>();
                        pstatementlist2.AddRange(pstatementlist);
                        ARoot aroot = new ARoot(
                            pincludelist2,
                            pprincipaldeclarationlist2,
                            pprincipalhierarchydeclarationlist2,
                            pstructlist2,
                            pstatementlist2
                        );
                        Push(0, aroot);
                    }
                    break;
                case 32:
                    {
                        TFile tfile = Pop<TFile>();
                        TInclude tinclude = Pop<TInclude>();
                        AInclude ainclude = new AInclude(
                            tfile
                        );
                        Push(1, ainclude);
                    }
                    break;
                case 33:
                    {
                        TSemicolon tsemicolon = Pop<TSemicolon>();
                        List<PPrincipal> pprincipallist = Pop<List<PPrincipal>>();
                        TPrincipall tprincipall = Pop<TPrincipall>();
                        List<PPrincipal> pprincipallist2 = new List<PPrincipal>();
                        pprincipallist2.AddRange(pprincipallist);
                        APrincipalDeclaration aprincipaldeclaration = new APrincipalDeclaration(
                            pprincipallist2
                        );
                        Push(2, aprincipaldeclaration);
                    }
                    break;
                case 34:
                    {
                        TSemicolon tsemicolon = Pop<TSemicolon>();
                        List<PPrincipal> pprincipallist = Pop<List<PPrincipal>>();
                        TActsFor tactsfor = Pop<TActsFor>();
                        PPrincipal pprincipal = Pop<PPrincipal>();
                        List<PPrincipal> pprincipallist2 = new List<PPrincipal>();
                        pprincipallist2.AddRange(pprincipallist);
                        APrincipalHierarchyDeclaration aprincipalhierarchydeclaration = new APrincipalHierarchyDeclaration(
                            pprincipal,
                            pprincipallist2
                        );
                        Push(3, aprincipalhierarchydeclaration);
                    }
                    break;
                case 35:
                case 36:
                    {
                        TSemicolon tsemicolon = Pop<TSemicolon>();
                        TIdentifier tidentifier = Pop<TIdentifier>();
                        TRCur trcur = Pop<TRCur>();
                        List<PField> pfieldlist = isOn(1, index - 35) ? Pop<List<PField>>() : new List<PField>();
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
                        Push(4, astruct);
                    }
                    break;
                case 37:
                    {
                        TSemicolon tsemicolon = Pop<TSemicolon>();
                        TIdentifier tidentifier = Pop<TIdentifier>();
                        PType ptype = Pop<PType>();
                        AField afield = new AField(
                            ptype,
                            tidentifier
                        );
                        Push(5, afield);
                    }
                    break;
                case 38:
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
                        Push(5, aarrayfield);
                    }
                    break;
                case 39:
                    {
                        TSemicolon tsemicolon = Pop<TSemicolon>();
                        TIdentifier tidentifier = Pop<TIdentifier>();
                        PType ptype = Pop<PType>();
                        ADeclarationStatement adeclarationstatement = new ADeclarationStatement(
                            ptype,
                            tidentifier,
                            null
                        );
                        Push(6, adeclarationstatement);
                    }
                    break;
                case 40:
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
                        Push(6, adeclarationstatement);
                    }
                    break;
                case 41:
                    {
                        TSemicolon tsemicolon = Pop<TSemicolon>();
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
                        Push(6, aarraydeclarationstatement);
                    }
                    break;
                case 42:
                case 43:
                case 44:
                case 45:
                    {
                        TRCur trcur = Pop<TRCur>();
                        List<PStatement> pstatementlist = isOn(2, index - 42) ? Pop<List<PStatement>>() : new List<PStatement>();
                        TLCur tlcur = Pop<TLCur>();
                        TRPar trpar = Pop<TRPar>();
                        List<PFunctionParameter> pfunctionparameterlist = isOn(1, index - 42) ? Pop<List<PFunctionParameter>>() : new List<PFunctionParameter>();
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
                        Push(6, afunctiondeclarationstatement);
                    }
                    break;
                case 46:
                    {
                        TIdentifier tidentifier = Pop<TIdentifier>();
                        PType ptype = Pop<PType>();
                        AFunctionParameter afunctionparameter = new AFunctionParameter(
                            ptype,
                            tidentifier
                        );
                        List<PFunctionParameter> pfunctionparameterlist = new List<PFunctionParameter>();
                        pfunctionparameterlist.Add(afunctionparameter);
                        Push(7, pfunctionparameterlist);
                    }
                    break;
                case 47:
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
                        Push(7, pfunctionparameterlist2);
                    }
                    break;
                case 48:
                    {
                        List<PStatement> pstatementlist = Pop<List<PStatement>>();
                        TRPar trpar = Pop<TRPar>();
                        PExpression pexpression = Pop<PExpression>();
                        TLPar tlpar = Pop<TLPar>();
                        TIf tif = Pop<TIf>();
                        List<PStatement> pstatementlist2 = new List<PStatement>();
                        pstatementlist2.AddRange(pstatementlist);
                        AIfStatement aifstatement = new AIfStatement(
                            tif,
                            pexpression,
                            pstatementlist2
                        );
                        Push(8, aifstatement);
                    }
                    break;
                case 49:
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
                            tif,
                            pexpression,
                            pstatementlist3,
                            pstatementlist4
                        );
                        Push(8, aifelsestatement);
                    }
                    break;
                case 50:
                    {
                        List<PStatement> pstatementlist = Pop<List<PStatement>>();
                        TRPar trpar = Pop<TRPar>();
                        PExpression pexpression = Pop<PExpression>();
                        TLPar tlpar = Pop<TLPar>();
                        TWhile twhile = Pop<TWhile>();
                        List<PStatement> pstatementlist2 = new List<PStatement>();
                        pstatementlist2.AddRange(pstatementlist);
                        AWhileStatement awhilestatement = new AWhileStatement(
                            twhile,
                            pexpression,
                            pstatementlist2
                        );
                        Push(8, awhilestatement);
                    }
                    break;
                case 51:
                    {
                        List<PStatement> pstatementlist = Pop<List<PStatement>>();
                        List<PPrincipal> pprincipallist = Pop<List<PPrincipal>>();
                        TIfActsFor tifactsfor = Pop<TIfActsFor>();
                        PClaimant pclaimant = Pop<PClaimant>();
                        List<PPrincipal> pprincipallist2 = new List<PPrincipal>();
                        pprincipallist2.AddRange(pprincipallist);
                        List<PStatement> pstatementlist2 = new List<PStatement>();
                        pstatementlist2.AddRange(pstatementlist);
                        AIfActsForStatement aifactsforstatement = new AIfActsForStatement(
                            pclaimant,
                            pprincipallist2,
                            pstatementlist2
                        );
                        Push(8, aifactsforstatement);
                    }
                    break;
                case 52:
                    {
                        List<PStatement> pstatementlist = Pop<List<PStatement>>();
                        TElse telse = Pop<TElse>();
                        List<PStatement> pstatementlist2 = Pop<List<PStatement>>();
                        List<PPrincipal> pprincipallist = Pop<List<PPrincipal>>();
                        TIfActsFor tifactsfor = Pop<TIfActsFor>();
                        PClaimant pclaimant = Pop<PClaimant>();
                        List<PPrincipal> pprincipallist2 = new List<PPrincipal>();
                        pprincipallist2.AddRange(pprincipallist);
                        List<PStatement> pstatementlist3 = new List<PStatement>();
                        pstatementlist3.AddRange(pstatementlist2);
                        List<PStatement> pstatementlist4 = new List<PStatement>();
                        pstatementlist4.AddRange(pstatementlist);
                        AIfActsForElseStatement aifactsforelsestatement = new AIfActsForElseStatement(
                            pclaimant,
                            pprincipallist2,
                            pstatementlist3,
                            pstatementlist4
                        );
                        Push(8, aifactsforelsestatement);
                    }
                    break;
                case 53:
                    {
                        PStatement pstatement = Pop<PStatement>();
                        Push(8, pstatement);
                    }
                    break;
                case 54:
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
                            tif,
                            pexpression,
                            pstatementlist3,
                            pstatementlist4
                        );
                        Push(9, aifelsestatement);
                    }
                    break;
                case 55:
                    {
                        List<PStatement> pstatementlist = Pop<List<PStatement>>();
                        TRPar trpar = Pop<TRPar>();
                        PExpression pexpression = Pop<PExpression>();
                        TLPar tlpar = Pop<TLPar>();
                        TWhile twhile = Pop<TWhile>();
                        List<PStatement> pstatementlist2 = new List<PStatement>();
                        pstatementlist2.AddRange(pstatementlist);
                        AWhileStatement awhilestatement = new AWhileStatement(
                            twhile,
                            pexpression,
                            pstatementlist2
                        );
                        Push(9, awhilestatement);
                    }
                    break;
                case 56:
                    {
                        List<PStatement> pstatementlist = Pop<List<PStatement>>();
                        TElse telse = Pop<TElse>();
                        List<PStatement> pstatementlist2 = Pop<List<PStatement>>();
                        List<PPrincipal> pprincipallist = Pop<List<PPrincipal>>();
                        TIfActsFor tifactsfor = Pop<TIfActsFor>();
                        PClaimant pclaimant = Pop<PClaimant>();
                        List<PPrincipal> pprincipallist2 = new List<PPrincipal>();
                        pprincipallist2.AddRange(pprincipallist);
                        List<PStatement> pstatementlist3 = new List<PStatement>();
                        pstatementlist3.AddRange(pstatementlist2);
                        List<PStatement> pstatementlist4 = new List<PStatement>();
                        pstatementlist4.AddRange(pstatementlist);
                        AIfActsForElseStatement aifactsforelsestatement = new AIfActsForElseStatement(
                            pclaimant,
                            pprincipallist2,
                            pstatementlist3,
                            pstatementlist4
                        );
                        Push(9, aifactsforelsestatement);
                    }
                    break;
                case 57:
                    {
                        PStatement pstatement = Pop<PStatement>();
                        Push(9, pstatement);
                    }
                    break;
                case 58:
                    {
                        TSemicolon tsemicolon = Pop<TSemicolon>();
                        TIdentifier tidentifier = Pop<TIdentifier>();
                        PType ptype = Pop<PType>();
                        ADeclarationStatement adeclarationstatement = new ADeclarationStatement(
                            ptype,
                            tidentifier,
                            null
                        );
                        Push(10, adeclarationstatement);
                    }
                    break;
                case 59:
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
                        Push(10, adeclarationstatement);
                    }
                    break;
                case 60:
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
                        Push(10, aarraydeclarationstatement);
                    }
                    break;
                case 61:
                    {
                        TSemicolon tsemicolon = Pop<TSemicolon>();
                        PExpression pexpression = Pop<PExpression>();
                        TAssign tassign = Pop<TAssign>();
                        TIdentifier tidentifier = Pop<TIdentifier>();
                        AAssignmentStatement aassignmentstatement = new AAssignmentStatement(
                            tidentifier,
                            pexpression
                        );
                        Push(10, aassignmentstatement);
                    }
                    break;
                case 62:
                case 63:
                    {
                        TSemicolon tsemicolon = Pop<TSemicolon>();
                        PExpression pexpression = isOn(1, index - 62) ? Pop<PExpression>() : null;
                        TReturn treturn = Pop<TReturn>();
                        AReturnStatement areturnstatement = new AReturnStatement(
                            treturn,
                            pexpression
                        );
                        Push(10, areturnstatement);
                    }
                    break;
                case 64:
                    {
                        PStatement pstatement = Pop<PStatement>();
                        Push(10, pstatement);
                    }
                    break;
                case 65:
                case 66:
                    {
                        PLabel plabel = isOn(1, index - 65) ? Pop<PLabel>() : null;
                        TIdentifier tidentifier = Pop<TIdentifier>();
                        AType atype = new AType(
                            tidentifier,
                            plabel
                        );
                        Push(11, atype);
                    }
                    break;
                case 67:
                    {
                        TAsterisk tasterisk = Pop<TAsterisk>();
                        PType ptype = Pop<PType>();
                        APointerType apointertype = new APointerType(
                            ptype,
                            tasterisk
                        );
                        Push(11, apointertype);
                    }
                    break;
                case 68:
                    {
                        PStatement pstatement = Pop<PStatement>();
                        List<PStatement> pstatementlist = new List<PStatement>();
                        pstatementlist.Add(pstatement);
                        Push(12, pstatementlist);
                    }
                    break;
                case 69:
                case 70:
                    {
                        TRCur trcur = Pop<TRCur>();
                        List<PStatement> pstatementlist = isOn(1, index - 69) ? Pop<List<PStatement>>() : new List<PStatement>();
                        TLCur tlcur = Pop<TLCur>();
                        List<PStatement> pstatementlist2 = new List<PStatement>();
                        pstatementlist2.AddRange(pstatementlist);
                        Push(12, pstatementlist2);
                    }
                    break;
                case 71:
                    {
                        PStatement pstatement = Pop<PStatement>();
                        List<PStatement> pstatementlist = new List<PStatement>();
                        pstatementlist.Add(pstatement);
                        Push(13, pstatementlist);
                    }
                    break;
                case 72:
                case 73:
                    {
                        TRCur trcur = Pop<TRCur>();
                        List<PStatement> pstatementlist = isOn(1, index - 72) ? Pop<List<PStatement>>() : new List<PStatement>();
                        TLCur tlcur = Pop<TLCur>();
                        List<PStatement> pstatementlist2 = new List<PStatement>();
                        pstatementlist2.AddRange(pstatementlist);
                        Push(13, pstatementlist2);
                    }
                    break;
                case 74:
                    {
                        TThis tthis = Pop<TThis>();
                        AThisClaimant athisclaimant = new AThisClaimant(
                            tthis
                        );
                        Push(14, athisclaimant);
                    }
                    break;
                case 75:
                    {
                        TCaller tcaller = Pop<TCaller>();
                        ACallerClaimant acallerclaimant = new ACallerClaimant(
                            tcaller
                        );
                        Push(14, acallerclaimant);
                    }
                    break;
                case 76:
                    {
                        TLabelEnd tlabelend = Pop<TLabelEnd>();
                        List<PPolicy> ppolicylist = Pop<List<PPolicy>>();
                        TLabelStart tlabelstart = Pop<TLabelStart>();
                        List<PPolicy> ppolicylist2 = new List<PPolicy>();
                        ppolicylist2.AddRange(ppolicylist);
                        ALabel alabel = new ALabel(
                            ppolicylist2,
                            null
                        );
                        Push(15, alabel);
                    }
                    break;
                case 77:
                    {
                        TLabelEnd tlabelend = Pop<TLabelEnd>();
                        PTiming ptiming = Pop<PTiming>();
                        TTimeStart ttimestart = Pop<TTimeStart>();
                        List<PPolicy> ppolicylist = Pop<List<PPolicy>>();
                        TLabelStart tlabelstart = Pop<TLabelStart>();
                        List<PPolicy> ppolicylist2 = new List<PPolicy>();
                        ppolicylist2.AddRange(ppolicylist);
                        ALabel alabel = new ALabel(
                            ppolicylist2,
                            ptiming
                        );
                        Push(15, alabel);
                    }
                    break;
                case 78:
                    {
                        PTimingPeriod ptimingperiod = Pop<PTimingPeriod>();
                        List<PTimingInterval> ptimingintervallist = new List<PTimingInterval>();
                        ATiming atiming = new ATiming(
                            ptimingperiod,
                            ptimingintervallist,
                            null
                        );
                        Push(16, atiming);
                    }
                    break;
                case 79:
                    {
                        TNumber tnumber = Pop<TNumber>();
                        TAsterisk tasterisk = Pop<TAsterisk>();
                        PTimingPeriod ptimingperiod = Pop<PTimingPeriod>();
                        List<PTimingInterval> ptimingintervallist = new List<PTimingInterval>();
                        ATiming atiming = new ATiming(
                            ptimingperiod,
                            ptimingintervallist,
                            tnumber
                        );
                        Push(16, atiming);
                    }
                    break;
                case 80:
                    {
                        List<PTimingInterval> ptimingintervallist = Pop<List<PTimingInterval>>();
                        ATiming atiming = new ATiming(
                            null,
                            ptimingintervallist,
                            null
                        );
                        Push(16, atiming);
                    }
                    break;
                case 81:
                    {
                        TNumber tnumber = Pop<TNumber>();
                        TAsterisk tasterisk = Pop<TAsterisk>();
                        List<PTimingInterval> ptimingintervallist = Pop<List<PTimingInterval>>();
                        ATiming atiming = new ATiming(
                            null,
                            ptimingintervallist,
                            tnumber
                        );
                        Push(16, atiming);
                    }
                    break;
                case 82:
                    {
                        List<PTimingInterval> ptimingintervallist = Pop<List<PTimingInterval>>();
                        TComma tcomma = Pop<TComma>();
                        PTimingPeriod ptimingperiod = Pop<PTimingPeriod>();
                        ATiming atiming = new ATiming(
                            ptimingperiod,
                            ptimingintervallist,
                            null
                        );
                        Push(16, atiming);
                    }
                    break;
                case 83:
                    {
                        TNumber tnumber = Pop<TNumber>();
                        TAsterisk tasterisk = Pop<TAsterisk>();
                        List<PTimingInterval> ptimingintervallist = Pop<List<PTimingInterval>>();
                        TComma tcomma = Pop<TComma>();
                        PTimingPeriod ptimingperiod = Pop<PTimingPeriod>();
                        ATiming atiming = new ATiming(
                            ptimingperiod,
                            ptimingintervallist,
                            tnumber
                        );
                        Push(16, atiming);
                    }
                    break;
                case 84:
                    {
                        TTime ttime = Pop<TTime>();
                        TMinus tminus = Pop<TMinus>();
                        TTime ttime2 = Pop<TTime>();
                        ATimingPeriod atimingperiod = new ATimingPeriod(
                            ttime2,
                            ttime
                        );
                        Push(17, atimingperiod);
                    }
                    break;
                case 85:
                    {
                        TIntervalUnit tintervalunit = Pop<TIntervalUnit>();
                        TNumber tnumber = Pop<TNumber>();
                        ATimingInterval atiminginterval = new ATimingInterval(
                            tnumber,
                            tintervalunit
                        );
                        Push(18, atiminginterval);
                    }
                    break;
                case 86:
                    {
                        TIdentifier tidentifier = Pop<TIdentifier>();
                        AVariablePolicy avariablepolicy = new AVariablePolicy(
                            tidentifier
                        );
                        Push(19, avariablepolicy);
                    }
                    break;
                case 87:
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
                        Push(19, aprincipalpolicy);
                    }
                    break;
                case 88:
                    {
                        TRArrow trarrow = Pop<TRArrow>();
                        PPrincipal pprincipal = Pop<PPrincipal>();
                        List<PPrincipal> pprincipallist = new List<PPrincipal>();
                        APrincipalPolicy aprincipalpolicy = new APrincipalPolicy(
                            pprincipal,
                            pprincipallist
                        );
                        Push(19, aprincipalpolicy);
                    }
                    break;
                case 89:
                    {
                        TUnderscore tunderscore = Pop<TUnderscore>();
                        ALowerPolicy alowerpolicy = new ALowerPolicy(
                            tunderscore
                        );
                        Push(19, alowerpolicy);
                    }
                    break;
                case 90:
                    {
                        THat that = Pop<THat>();
                        AUpperPolicy aupperpolicy = new AUpperPolicy(
                            that
                        );
                        Push(19, aupperpolicy);
                    }
                    break;
                case 91:
                    {
                        PPolicy ppolicy = Pop<PPolicy>();
                        List<PPolicy> ppolicylist = new List<PPolicy>();
                        ppolicylist.Add(ppolicy);
                        Push(20, ppolicylist);
                    }
                    break;
                case 92:
                    {
                        List<PPolicy> ppolicylist = Pop<List<PPolicy>>();
                        TSemicolon tsemicolon = Pop<TSemicolon>();
                        PPolicy ppolicy = Pop<PPolicy>();
                        List<PPolicy> ppolicylist2 = new List<PPolicy>();
                        ppolicylist2.Add(ppolicy);
                        ppolicylist2.AddRange(ppolicylist);
                        Push(20, ppolicylist2);
                    }
                    break;
                case 93:
                    {
                        List<PPolicy> ppolicylist = Pop<List<PPolicy>>();
                        TJoin tjoin = Pop<TJoin>();
                        PPolicy ppolicy = Pop<PPolicy>();
                        List<PPolicy> ppolicylist2 = new List<PPolicy>();
                        ppolicylist2.Add(ppolicy);
                        ppolicylist2.AddRange(ppolicylist);
                        Push(20, ppolicylist2);
                    }
                    break;
                case 94:
                    {
                        TIdentifier tidentifier = Pop<TIdentifier>();
                        APrincipal aprincipal = new APrincipal(
                            tidentifier
                        );
                        Push(21, aprincipal);
                    }
                    break;
                case 95:
                    {
                        PPrincipal pprincipal = Pop<PPrincipal>();
                        List<PPrincipal> pprincipallist = new List<PPrincipal>();
                        pprincipallist.Add(pprincipal);
                        Push(22, pprincipallist);
                    }
                    break;
                case 96:
                    {
                        List<PPrincipal> pprincipallist = Pop<List<PPrincipal>>();
                        TComma tcomma = Pop<TComma>();
                        PPrincipal pprincipal = Pop<PPrincipal>();
                        List<PPrincipal> pprincipallist2 = new List<PPrincipal>();
                        pprincipallist2.Add(pprincipal);
                        pprincipallist2.AddRange(pprincipallist);
                        Push(22, pprincipallist2);
                    }
                    break;
                case 97:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        Push(23, pexpression);
                    }
                    break;
                case 98:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TAnd tand = Pop<TAnd>();
                        PExpression pexpression2 = Pop<PExpression>();
                        AAndExpression aandexpression = new AAndExpression(
                            pexpression2,
                            pexpression
                        );
                        Push(24, aandexpression);
                    }
                    break;
                case 99:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TOr tor = Pop<TOr>();
                        PExpression pexpression2 = Pop<PExpression>();
                        AOrExpression aorexpression = new AOrExpression(
                            pexpression2,
                            pexpression
                        );
                        Push(24, aorexpression);
                    }
                    break;
                case 100:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        Push(24, pexpression);
                    }
                    break;
                case 101:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TCompare tcompare = Pop<TCompare>();
                        PExpression pexpression2 = Pop<PExpression>();
                        AComparisonExpression acomparisonexpression = new AComparisonExpression(
                            pexpression2,
                            tcompare,
                            pexpression
                        );
                        Push(25, acomparisonexpression);
                    }
                    break;
                case 102:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TBang tbang = Pop<TBang>();
                        ANotExpression anotexpression = new ANotExpression(
                            pexpression
                        );
                        Push(25, anotexpression);
                    }
                    break;
                case 103:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        Push(25, pexpression);
                    }
                    break;
                case 104:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TPlus tplus = Pop<TPlus>();
                        PExpression pexpression2 = Pop<PExpression>();
                        APlusExpression aplusexpression = new APlusExpression(
                            pexpression2,
                            pexpression
                        );
                        Push(26, aplusexpression);
                    }
                    break;
                case 105:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TMinus tminus = Pop<TMinus>();
                        PExpression pexpression2 = Pop<PExpression>();
                        AMinusExpression aminusexpression = new AMinusExpression(
                            pexpression2,
                            pexpression
                        );
                        Push(26, aminusexpression);
                    }
                    break;
                case 106:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TMinus tminus = Pop<TMinus>();
                        ANegateExpression anegateexpression = new ANegateExpression(
                            pexpression
                        );
                        Push(26, anegateexpression);
                    }
                    break;
                case 107:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        Push(26, pexpression);
                    }
                    break;
                case 108:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TAsterisk tasterisk = Pop<TAsterisk>();
                        PExpression pexpression2 = Pop<PExpression>();
                        AMultiplyExpression amultiplyexpression = new AMultiplyExpression(
                            pexpression2,
                            pexpression
                        );
                        Push(27, amultiplyexpression);
                    }
                    break;
                case 109:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TSlash tslash = Pop<TSlash>();
                        PExpression pexpression2 = Pop<PExpression>();
                        ADivideExpression adivideexpression = new ADivideExpression(
                            pexpression2,
                            pexpression
                        );
                        Push(27, adivideexpression);
                    }
                    break;
                case 110:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TPercent tpercent = Pop<TPercent>();
                        PExpression pexpression2 = Pop<PExpression>();
                        AModuloExpression amoduloexpression = new AModuloExpression(
                            pexpression2,
                            pexpression
                        );
                        Push(27, amoduloexpression);
                    }
                    break;
                case 111:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        Push(27, pexpression);
                    }
                    break;
                case 112:
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
                        Push(28, aelementexpression);
                    }
                    break;
                case 113:
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
                        Push(28, aelementexpression);
                    }
                    break;
                case 114:
                    {
                        TRSqu trsqu = Pop<TRSqu>();
                        PExpression pexpression = Pop<PExpression>();
                        TLSqu tlsqu = Pop<TLSqu>();
                        PExpression pexpression2 = Pop<PExpression>();
                        AIndexExpression aindexexpression = new AIndexExpression(
                            pexpression2,
                            pexpression
                        );
                        Push(28, aindexexpression);
                    }
                    break;
                case 115:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        Push(28, pexpression);
                    }
                    break;
                case 116:
                    {
                        TRPar trpar = Pop<TRPar>();
                        PExpression pexpression = Pop<PExpression>();
                        TLPar tlpar = Pop<TLPar>();
                        AParenthesisExpression aparenthesisexpression = new AParenthesisExpression(
                            pexpression
                        );
                        Push(29, aparenthesisexpression);
                    }
                    break;
                case 117:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        Push(29, pexpression);
                    }
                    break;
                case 118:
                    {
                        TNumber tnumber = Pop<TNumber>();
                        ANumberExpression anumberexpression = new ANumberExpression(
                            tnumber
                        );
                        Push(29, anumberexpression);
                    }
                    break;
                case 119:
                    {
                        TBool tbool = Pop<TBool>();
                        ABooleanExpression abooleanexpression = new ABooleanExpression(
                            tbool
                        );
                        Push(29, abooleanexpression);
                    }
                    break;
                case 120:
                    {
                        TNull tnull = Pop<TNull>();
                        ANullExpression anullexpression = new ANullExpression(
                            tnull
                        );
                        Push(29, anullexpression);
                    }
                    break;
                case 121:
                    {
                        TIdentifier tidentifier = Pop<TIdentifier>();
                        AIdentifierExpression aidentifierexpression = new AIdentifierExpression(
                            tidentifier
                        );
                        Push(29, aidentifierexpression);
                    }
                    break;
                case 122:
                    {
                        TDeclassifyEnd tdeclassifyend = Pop<TDeclassifyEnd>();
                        PExpression pexpression = Pop<PExpression>();
                        TDeclassifyStart tdeclassifystart = Pop<TDeclassifyStart>();
                        ADeclassifyExpression adeclassifyexpression = new ADeclassifyExpression(
                            pexpression,
                            null
                        );
                        Push(29, adeclassifyexpression);
                    }
                    break;
                case 123:
                    {
                        TDeclassifyEnd tdeclassifyend = Pop<TDeclassifyEnd>();
                        PLabel plabel = Pop<PLabel>();
                        TComma tcomma = Pop<TComma>();
                        PExpression pexpression = Pop<PExpression>();
                        TDeclassifyStart tdeclassifystart = Pop<TDeclassifyStart>();
                        ADeclassifyExpression adeclassifyexpression = new ADeclassifyExpression(
                            pexpression,
                            plabel
                        );
                        Push(29, adeclassifyexpression);
                    }
                    break;
                case 124:
                    {
                        TSemicolon tsemicolon = Pop<TSemicolon>();
                        PExpression pexpression = Pop<PExpression>();
                        AExpressionStatement aexpressionstatement = new AExpressionStatement(
                            pexpression
                        );
                        Push(30, aexpressionstatement);
                    }
                    break;
                case 125:
                case 126:
                case 127:
                case 128:
                    {
                        TRPar trpar = Pop<TRPar>();
                        List<PExpression> pexpressionlist = isOn(2, index - 125) ? Pop<List<PExpression>>() : new List<PExpression>();
                        TLPar tlpar = Pop<TLPar>();
                        List<PPrincipal> pprincipallist = isOn(1, index - 125) ? Pop<List<PPrincipal>>() : new List<PPrincipal>();
                        TIdentifier tidentifier = Pop<TIdentifier>();
                        List<PPrincipal> pprincipallist2 = new List<PPrincipal>();
                        pprincipallist2.AddRange(pprincipallist);
                        List<PExpression> pexpressionlist2 = new List<PExpression>();
                        pexpressionlist2.AddRange(pexpressionlist);
                        AFunctionCallExpression afunctioncallexpression = new AFunctionCallExpression(
                            tidentifier,
                            pprincipallist2,
                            pexpressionlist2
                        );
                        Push(31, afunctioncallexpression);
                    }
                    break;
                case 129:
                    {
                        TFuncAuthEnd tfuncauthend = Pop<TFuncAuthEnd>();
                        List<PPrincipal> pprincipallist = Pop<List<PPrincipal>>();
                        TFuncAuthStart tfuncauthstart = Pop<TFuncAuthStart>();
                        List<PPrincipal> pprincipallist2 = new List<PPrincipal>();
                        pprincipallist2.AddRange(pprincipallist);
                        Push(32, pprincipallist2);
                    }
                    break;
                case 130:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        List<PExpression> pexpressionlist = new List<PExpression>();
                        pexpressionlist.Add(pexpression);
                        Push(33, pexpressionlist);
                    }
                    break;
                case 131:
                    {
                        List<PExpression> pexpressionlist = Pop<List<PExpression>>();
                        TComma tcomma = Pop<TComma>();
                        PExpression pexpression = Pop<PExpression>();
                        List<PExpression> pexpressionlist2 = new List<PExpression>();
                        pexpressionlist2.Add(pexpression);
                        pexpressionlist2.AddRange(pexpressionlist);
                        Push(33, pexpressionlist2);
                    }
                    break;
                case 132:
                    Push(34, new List<PInclude>() { Pop<PInclude>() });
                    break;
                case 133:
                    {
                        PInclude item = Pop<PInclude>();
                        List<PInclude> list = Pop<List<PInclude>>();
                        list.Add(item);
                        Push(34, list);
                    }
                    break;
                case 134:
                    Push(35, new List<PPrincipalDeclaration>() { Pop<PPrincipalDeclaration>() });
                    break;
                case 135:
                    {
                        PPrincipalDeclaration item = Pop<PPrincipalDeclaration>();
                        List<PPrincipalDeclaration> list = Pop<List<PPrincipalDeclaration>>();
                        list.Add(item);
                        Push(35, list);
                    }
                    break;
                case 136:
                    Push(36, new List<PPrincipalHierarchyDeclaration>() { Pop<PPrincipalHierarchyDeclaration>() });
                    break;
                case 137:
                    {
                        PPrincipalHierarchyDeclaration item = Pop<PPrincipalHierarchyDeclaration>();
                        List<PPrincipalHierarchyDeclaration> list = Pop<List<PPrincipalHierarchyDeclaration>>();
                        list.Add(item);
                        Push(36, list);
                    }
                    break;
                case 138:
                    Push(37, new List<PStruct>() { Pop<PStruct>() });
                    break;
                case 139:
                    {
                        PStruct item = Pop<PStruct>();
                        List<PStruct> list = Pop<List<PStruct>>();
                        list.Add(item);
                        Push(37, list);
                    }
                    break;
                case 140:
                    Push(38, new List<PStatement>() { Pop<PStatement>() });
                    break;
                case 141:
                    {
                        PStatement item = Pop<PStatement>();
                        List<PStatement> list = Pop<List<PStatement>>();
                        list.Add(item);
                        Push(38, list);
                    }
                    break;
                case 142:
                    Push(39, new List<PField>() { Pop<PField>() });
                    break;
                case 143:
                    {
                        PField item = Pop<PField>();
                        List<PField> list = Pop<List<PField>>();
                        list.Add(item);
                        Push(39, list);
                    }
                    break;
                case 144:
                    Push(40, new List<PStatement>() { Pop<PStatement>() });
                    break;
                case 145:
                    {
                        PStatement item = Pop<PStatement>();
                        List<PStatement> list = Pop<List<PStatement>>();
                        list.Add(item);
                        Push(40, list);
                    }
                    break;
                case 146:
                    Push(41, new List<PTimingInterval>() { Pop<PTimingInterval>() });
                    break;
                case 147:
                    {
                        PTimingInterval item = Pop<PTimingInterval>();
                        List<PTimingInterval> list = Pop<List<PTimingInterval>>();
                        list.Add(item);
                        Push(41, list);
                    }
                    break;
            }
        }
        
        #region actionTable
        private static int[][][] actionTable = {
            new int[][] {
                new int[] {-1, 1, 0},
                new int[] {0, 0, 1},
                new int[] {6, 0, 2},
                new int[] {7, 0, 3},
                new int[] {16, 0, 4},
            },
            new int[][] {
                new int[] {-1, 3, 1},
                new int[] {1, 0, 18},
            },
            new int[][] {
                new int[] {-1, 3, 2},
                new int[] {16, 0, 19},
            },
            new int[][] {
                new int[] {-1, 3, 3},
                new int[] {8, 0, 22},
            },
            new int[][] {
                new int[] {-1, 1, 65},
                new int[] {17, 1, 94},
                new int[] {41, 0, 23},
            },
            new int[][] {
                new int[] {-1, 3, 5},
                new int[] {51, 2, -1},
            },
            new int[][] {
                new int[] {-1, 1, 132},
            },
            new int[][] {
                new int[] {-1, 1, 134},
            },
            new int[][] {
                new int[] {-1, 1, 136},
            },
            new int[][] {
                new int[] {-1, 1, 138},
            },
            new int[][] {
                new int[] {-1, 1, 140},
            },
            new int[][] {
                new int[] {-1, 3, 11},
                new int[] {16, 0, 25},
                new int[] {31, 0, 26},
            },
            new int[][] {
                new int[] {-1, 3, 12},
                new int[] {17, 0, 27},
            },
            new int[][] {
                new int[] {-1, 1, 1},
                new int[] {0, 0, 1},
                new int[] {6, 0, 2},
                new int[] {7, 0, 3},
                new int[] {16, 0, 4},
            },
            new int[][] {
                new int[] {-1, 1, 2},
                new int[] {6, 0, 2},
                new int[] {7, 0, 3},
                new int[] {16, 0, 4},
            },
            new int[][] {
                new int[] {-1, 1, 4},
                new int[] {7, 0, 3},
                new int[] {16, 0, 4},
            },
            new int[][] {
                new int[] {-1, 1, 8},
                new int[] {7, 0, 3},
                new int[] {16, 0, 40},
            },
            new int[][] {
                new int[] {-1, 1, 16},
                new int[] {16, 0, 40},
            },
            new int[][] {
                new int[] {-1, 1, 32},
            },
            new int[][] {
                new int[] {-1, 1, 94},
            },
            new int[][] {
                new int[] {-1, 1, 95},
                new int[] {38, 0, 44},
            },
            new int[][] {
                new int[] {-1, 3, 21},
                new int[] {40, 0, 45},
            },
            new int[][] {
                new int[] {-1, 3, 22},
                new int[] {16, 0, 46},
            },
            new int[][] {
                new int[] {-1, 3, 23},
                new int[] {16, 0, 47},
                new int[] {27, 0, 48},
                new int[] {28, 0, 49},
            },
            new int[][] {
                new int[] {-1, 1, 66},
            },
            new int[][] {
                new int[] {-1, 3, 25},
                new int[] {26, 0, 53},
                new int[] {40, 0, 54},
                new int[] {44, 0, 55},
                new int[] {46, 0, 56},
            },
            new int[][] {
                new int[] {-1, 1, 67},
            },
            new int[][] {
                new int[] {-1, 3, 27},
                new int[] {16, 0, 19},
            },
            new int[][] {
                new int[] {-1, 1, 133},
            },
            new int[][] {
                new int[] {-1, 1, 3},
                new int[] {6, 0, 2},
                new int[] {7, 0, 3},
                new int[] {16, 0, 4},
            },
            new int[][] {
                new int[] {-1, 1, 5},
                new int[] {7, 0, 3},
                new int[] {16, 0, 4},
            },
            new int[][] {
                new int[] {-1, 1, 9},
                new int[] {7, 0, 3},
                new int[] {16, 0, 40},
            },
            new int[][] {
                new int[] {-1, 1, 17},
                new int[] {16, 0, 40},
            },
            new int[][] {
                new int[] {-1, 1, 135},
            },
            new int[][] {
                new int[] {-1, 1, 6},
                new int[] {7, 0, 3},
                new int[] {16, 0, 4},
            },
            new int[][] {
                new int[] {-1, 1, 10},
                new int[] {7, 0, 3},
                new int[] {16, 0, 40},
            },
            new int[][] {
                new int[] {-1, 1, 18},
                new int[] {16, 0, 40},
            },
            new int[][] {
                new int[] {-1, 1, 137},
            },
            new int[][] {
                new int[] {-1, 1, 12},
                new int[] {7, 0, 3},
                new int[] {16, 0, 40},
            },
            new int[][] {
                new int[] {-1, 1, 20},
                new int[] {16, 0, 40},
            },
            new int[][] {
                new int[] {-1, 1, 65},
                new int[] {41, 0, 23},
            },
            new int[][] {
                new int[] {-1, 1, 139},
            },
            new int[][] {
                new int[] {-1, 1, 24},
                new int[] {16, 0, 40},
            },
            new int[][] {
                new int[] {-1, 1, 141},
            },
            new int[][] {
                new int[] {-1, 3, 44},
                new int[] {16, 0, 19},
            },
            new int[][] {
                new int[] {-1, 1, 33},
            },
            new int[][] {
                new int[] {-1, 3, 46},
                new int[] {48, 0, 69},
            },
            new int[][] {
                new int[] {-1, 1, 86},
                new int[] {23, 1, 94},
            },
            new int[][] {
                new int[] {-1, 1, 89},
            },
            new int[][] {
                new int[] {-1, 1, 90},
            },
            new int[][] {
                new int[] {-1, 1, 91},
                new int[] {40, 0, 70},
                new int[] {50, 0, 71},
            },
            new int[][] {
                new int[] {-1, 3, 51},
                new int[] {42, 0, 72},
                new int[] {43, 0, 73},
            },
            new int[][] {
                new int[] {-1, 3, 52},
                new int[] {23, 0, 74},
            },
            new int[][] {
                new int[] {-1, 3, 53},
                new int[] {4, 0, 75},
                new int[] {5, 0, 76},
                new int[] {15, 0, 77},
                new int[] {16, 0, 78},
                new int[] {19, 0, 79},
                new int[] {30, 0, 80},
                new int[] {34, 0, 81},
                new int[] {44, 0, 82},
            },
            new int[][] {
                new int[] {-1, 1, 39},
            },
            new int[][] {
                new int[] {-1, 3, 55},
                new int[] {16, 0, 40},
                new int[] {45, 0, 91},
            },
            new int[][] {
                new int[] {-1, 3, 56},
                new int[] {5, 0, 94},
            },
            new int[][] {
                new int[] {-1, 3, 57},
                new int[] {40, 0, 95},
            },
            new int[][] {
                new int[] {-1, 1, 7},
                new int[] {7, 0, 3},
                new int[] {16, 0, 4},
            },
            new int[][] {
                new int[] {-1, 1, 11},
                new int[] {7, 0, 3},
                new int[] {16, 0, 40},
            },
            new int[][] {
                new int[] {-1, 1, 19},
                new int[] {16, 0, 40},
            },
            new int[][] {
                new int[] {-1, 1, 13},
                new int[] {7, 0, 3},
                new int[] {16, 0, 40},
            },
            new int[][] {
                new int[] {-1, 1, 21},
                new int[] {16, 0, 40},
            },
            new int[][] {
                new int[] {-1, 1, 25},
                new int[] {16, 0, 40},
            },
            new int[][] {
                new int[] {-1, 1, 14},
                new int[] {7, 0, 3},
                new int[] {16, 0, 40},
            },
            new int[][] {
                new int[] {-1, 1, 22},
                new int[] {16, 0, 40},
            },
            new int[][] {
                new int[] {-1, 1, 26},
                new int[] {16, 0, 40},
            },
            new int[][] {
                new int[] {-1, 1, 28},
                new int[] {16, 0, 40},
            },
            new int[][] {
                new int[] {-1, 1, 96},
            },
            new int[][] {
                new int[] {-1, 3, 69},
                new int[] {16, 0, 40},
                new int[] {49, 0, 101},
            },
            new int[][] {
                new int[] {-1, 3, 70},
                new int[] {16, 0, 47},
                new int[] {27, 0, 48},
                new int[] {28, 0, 49},
            },
            new int[][] {
                new int[] {-1, 3, 71},
                new int[] {16, 0, 47},
                new int[] {27, 0, 48},
                new int[] {28, 0, 49},
            },
            new int[][] {
                new int[] {-1, 3, 72},
                new int[] {2, 0, 107},
                new int[] {5, 0, 108},
            },
            new int[][] {
                new int[] {-1, 1, 76},
            },
            new int[][] {
                new int[] {-1, 1, 88},
                new int[] {16, 0, 19},
            },
            new int[][] {
                new int[] {-1, 1, 119},
            },
            new int[][] {
                new int[] {-1, 1, 118},
            },
            new int[][] {
                new int[] {-1, 1, 120},
            },
            new int[][] {
                new int[] {-1, 1, 121},
                new int[] {21, 0, 114},
                new int[] {44, 0, 115},
            },
            new int[][] {
                new int[] {-1, 3, 79},
                new int[] {4, 0, 75},
                new int[] {5, 0, 76},
                new int[] {15, 0, 77},
                new int[] {16, 0, 78},
                new int[] {19, 0, 79},
                new int[] {30, 0, 80},
                new int[] {34, 0, 81},
                new int[] {44, 0, 82},
            },
            new int[][] {
                new int[] {-1, 3, 80},
                new int[] {4, 0, 75},
                new int[] {5, 0, 76},
                new int[] {15, 0, 77},
                new int[] {16, 0, 78},
                new int[] {19, 0, 79},
                new int[] {44, 0, 82},
            },
            new int[][] {
                new int[] {-1, 3, 81},
                new int[] {4, 0, 75},
                new int[] {5, 0, 76},
                new int[] {15, 0, 77},
                new int[] {16, 0, 78},
                new int[] {19, 0, 79},
                new int[] {30, 0, 80},
                new int[] {44, 0, 82},
            },
            new int[][] {
                new int[] {-1, 3, 82},
                new int[] {4, 0, 75},
                new int[] {5, 0, 76},
                new int[] {15, 0, 77},
                new int[] {16, 0, 78},
                new int[] {19, 0, 79},
                new int[] {30, 0, 80},
                new int[] {34, 0, 81},
                new int[] {44, 0, 82},
            },
            new int[][] {
                new int[] {-1, 3, 83},
                new int[] {40, 0, 121},
            },
            new int[][] {
                new int[] {-1, 1, 97},
            },
            new int[][] {
                new int[] {-1, 1, 100},
                new int[] {35, 0, 122},
                new int[] {36, 0, 123},
            },
            new int[][] {
                new int[] {-1, 1, 103},
                new int[] {25, 0, 124},
            },
            new int[][] {
                new int[] {-1, 1, 107},
                new int[] {29, 0, 125},
                new int[] {30, 0, 126},
            },
            new int[][] {
                new int[] {-1, 1, 111},
                new int[] {23, 0, 127},
                new int[] {31, 0, 128},
                new int[] {32, 0, 129},
                new int[] {33, 0, 130},
                new int[] {37, 0, 131},
                new int[] {46, 0, 132},
            },
            new int[][] {
                new int[] {-1, 1, 115},
            },
            new int[][] {
                new int[] {-1, 1, 117},
            },
            new int[][] {
                new int[] {-1, 3, 91},
                new int[] {48, 0, 133},
            },
            new int[][] {
                new int[] {-1, 3, 92},
                new int[] {45, 0, 134},
            },
            new int[][] {
                new int[] {-1, 3, 93},
                new int[] {16, 0, 135},
                new int[] {31, 0, 26},
            },
            new int[][] {
                new int[] {-1, 3, 94},
                new int[] {47, 0, 136},
            },
            new int[][] {
                new int[] {-1, 1, 34},
            },
            new int[][] {
                new int[] {-1, 1, 15},
                new int[] {7, 0, 3},
                new int[] {16, 0, 40},
            },
            new int[][] {
                new int[] {-1, 1, 23},
                new int[] {16, 0, 40},
            },
            new int[][] {
                new int[] {-1, 1, 27},
                new int[] {16, 0, 40},
            },
            new int[][] {
                new int[] {-1, 1, 29},
                new int[] {16, 0, 40},
            },
            new int[][] {
                new int[] {-1, 1, 30},
                new int[] {16, 0, 40},
            },
            new int[][] {
                new int[] {-1, 3, 101},
                new int[] {16, 0, 138},
            },
            new int[][] {
                new int[] {-1, 1, 142},
            },
            new int[][] {
                new int[] {-1, 3, 103},
                new int[] {16, 0, 139},
                new int[] {31, 0, 26},
            },
            new int[][] {
                new int[] {-1, 3, 104},
                new int[] {16, 0, 40},
                new int[] {49, 0, 140},
            },
            new int[][] {
                new int[] {-1, 1, 92},
            },
            new int[][] {
                new int[] {-1, 1, 93},
            },
            new int[][] {
                new int[] {-1, 3, 107},
                new int[] {30, 0, 142},
            },
            new int[][] {
                new int[] {-1, 3, 108},
                new int[] {3, 0, 143},
            },
            new int[][] {
                new int[] {-1, 3, 109},
                new int[] {43, 0, 144},
            },
            new int[][] {
                new int[] {-1, 1, 78},
                new int[] {31, 0, 145},
                new int[] {38, 0, 146},
            },
            new int[][] {
                new int[] {-1, 1, 146},
            },
            new int[][] {
                new int[] {-1, 1, 80},
                new int[] {5, 0, 108},
                new int[] {31, 0, 147},
            },
            new int[][] {
                new int[] {-1, 1, 87},
            },
            new int[][] {
                new int[] {-1, 3, 114},
                new int[] {16, 0, 19},
            },
            new int[][] {
                new int[] {-1, 3, 115},
                new int[] {4, 0, 75},
                new int[] {5, 0, 76},
                new int[] {15, 0, 77},
                new int[] {16, 0, 78},
                new int[] {19, 0, 79},
                new int[] {30, 0, 80},
                new int[] {34, 0, 81},
                new int[] {44, 0, 82},
                new int[] {45, 0, 150},
            },
            new int[][] {
                new int[] {-1, 3, 116},
                new int[] {44, 0, 153},
            },
            new int[][] {
                new int[] {-1, 3, 117},
                new int[] {20, 0, 154},
                new int[] {38, 0, 155},
            },
            new int[][] {
                new int[] {-1, 1, 106},
            },
            new int[][] {
                new int[] {-1, 1, 102},
            },
            new int[][] {
                new int[] {-1, 3, 120},
                new int[] {45, 0, 156},
            },
            new int[][] {
                new int[] {-1, 1, 40},
            },
            new int[][] {
                new int[] {-1, 3, 122},
                new int[] {4, 0, 75},
                new int[] {5, 0, 76},
                new int[] {15, 0, 77},
                new int[] {16, 0, 78},
                new int[] {19, 0, 79},
                new int[] {30, 0, 80},
                new int[] {34, 0, 81},
                new int[] {44, 0, 82},
            },
            new int[][] {
                new int[] {-1, 3, 123},
                new int[] {4, 0, 75},
                new int[] {5, 0, 76},
                new int[] {15, 0, 77},
                new int[] {16, 0, 78},
                new int[] {19, 0, 79},
                new int[] {30, 0, 80},
                new int[] {34, 0, 81},
                new int[] {44, 0, 82},
            },
            new int[][] {
                new int[] {-1, 3, 124},
                new int[] {4, 0, 75},
                new int[] {5, 0, 76},
                new int[] {15, 0, 77},
                new int[] {16, 0, 78},
                new int[] {19, 0, 79},
                new int[] {30, 0, 80},
                new int[] {34, 0, 81},
                new int[] {44, 0, 82},
            },
            new int[][] {
                new int[] {-1, 3, 125},
                new int[] {4, 0, 75},
                new int[] {5, 0, 76},
                new int[] {15, 0, 77},
                new int[] {16, 0, 78},
                new int[] {19, 0, 79},
                new int[] {30, 0, 80},
                new int[] {44, 0, 82},
            },
            new int[][] {
                new int[] {-1, 3, 126},
                new int[] {4, 0, 75},
                new int[] {5, 0, 76},
                new int[] {15, 0, 77},
                new int[] {16, 0, 78},
                new int[] {19, 0, 79},
                new int[] {30, 0, 80},
                new int[] {44, 0, 82},
            },
            new int[][] {
                new int[] {-1, 3, 127},
                new int[] {16, 0, 162},
            },
            new int[][] {
                new int[] {-1, 3, 128},
                new int[] {4, 0, 75},
                new int[] {5, 0, 76},
                new int[] {15, 0, 77},
                new int[] {16, 0, 78},
                new int[] {19, 0, 79},
                new int[] {44, 0, 82},
            },
            new int[][] {
                new int[] {-1, 3, 129},
                new int[] {4, 0, 75},
                new int[] {5, 0, 76},
                new int[] {15, 0, 77},
                new int[] {16, 0, 78},
                new int[] {19, 0, 79},
                new int[] {44, 0, 82},
            },
            new int[][] {
                new int[] {-1, 3, 130},
                new int[] {4, 0, 75},
                new int[] {5, 0, 76},
                new int[] {15, 0, 77},
                new int[] {16, 0, 78},
                new int[] {19, 0, 79},
                new int[] {44, 0, 82},
            },
            new int[][] {
                new int[] {-1, 3, 131},
                new int[] {16, 0, 166},
            },
            new int[][] {
                new int[] {-1, 3, 132},
                new int[] {4, 0, 75},
                new int[] {5, 0, 76},
                new int[] {15, 0, 77},
                new int[] {16, 0, 78},
                new int[] {19, 0, 79},
                new int[] {30, 0, 80},
                new int[] {34, 0, 81},
                new int[] {44, 0, 82},
            },
            new int[][] {
                new int[] {-1, 3, 133},
                new int[] {9, 0, 168},
                new int[] {10, 0, 169},
                new int[] {12, 0, 170},
                new int[] {13, 0, 171},
                new int[] {14, 0, 172},
                new int[] {16, 0, 173},
                new int[] {49, 0, 174},
            },
            new int[][] {
                new int[] {-1, 3, 134},
                new int[] {48, 0, 182},
            },
            new int[][] {
                new int[] {-1, 1, 46},
                new int[] {38, 0, 183},
            },
            new int[][] {
                new int[] {-1, 3, 136},
                new int[] {40, 0, 184},
            },
            new int[][] {
                new int[] {-1, 1, 31},
                new int[] {16, 0, 40},
            },
            new int[][] {
                new int[] {-1, 3, 138},
                new int[] {40, 0, 185},
            },
            new int[][] {
                new int[] {-1, 3, 139},
                new int[] {40, 0, 186},
                new int[] {46, 0, 187},
            },
            new int[][] {
                new int[] {-1, 3, 140},
                new int[] {16, 0, 188},
            },
            new int[][] {
                new int[] {-1, 1, 143},
            },
            new int[][] {
                new int[] {-1, 3, 142},
                new int[] {2, 0, 189},
            },
            new int[][] {
                new int[] {-1, 1, 85},
            },
            new int[][] {
                new int[] {-1, 1, 77},
            },
            new int[][] {
                new int[] {-1, 3, 145},
                new int[] {5, 0, 190},
            },
            new int[][] {
                new int[] {-1, 3, 146},
                new int[] {5, 0, 108},
            },
            new int[][] {
                new int[] {-1, 3, 147},
                new int[] {5, 0, 192},
            },
            new int[][] {
                new int[] {-1, 1, 147},
            },
            new int[][] {
                new int[] {-1, 3, 149},
                new int[] {22, 0, 193},
            },
            new int[][] {
                new int[] {-1, 1, 125},
            },
            new int[][] {
                new int[] {-1, 1, 130},
                new int[] {38, 0, 194},
            },
            new int[][] {
                new int[] {-1, 3, 152},
                new int[] {45, 0, 195},
            },
            new int[][] {
                new int[] {-1, 3, 153},
                new int[] {4, 0, 75},
                new int[] {5, 0, 76},
                new int[] {15, 0, 77},
                new int[] {16, 0, 78},
                new int[] {19, 0, 79},
                new int[] {30, 0, 80},
                new int[] {34, 0, 81},
                new int[] {44, 0, 82},
                new int[] {45, 0, 196},
            },
            new int[][] {
                new int[] {-1, 1, 122},
            },
            new int[][] {
                new int[] {-1, 3, 155},
                new int[] {41, 0, 23},
            },
            new int[][] {
                new int[] {-1, 1, 116},
            },
            new int[][] {
                new int[] {-1, 1, 98},
            },
            new int[][] {
                new int[] {-1, 1, 99},
            },
            new int[][] {
                new int[] {-1, 1, 101},
            },
            new int[][] {
                new int[] {-1, 1, 104},
            },
            new int[][] {
                new int[] {-1, 1, 105},
            },
            new int[][] {
                new int[] {-1, 1, 113},
            },
            new int[][] {
                new int[] {-1, 1, 108},
            },
            new int[][] {
                new int[] {-1, 1, 109},
            },
            new int[][] {
                new int[] {-1, 1, 110},
            },
            new int[][] {
                new int[] {-1, 1, 112},
            },
            new int[][] {
                new int[] {-1, 3, 167},
                new int[] {47, 0, 199},
            },
            new int[][] {
                new int[] {-1, 3, 168},
                new int[] {44, 0, 200},
            },
            new int[][] {
                new int[] {-1, 3, 169},
                new int[] {44, 0, 201},
            },
            new int[][] {
                new int[] {-1, 3, 170},
                new int[] {4, 0, 75},
                new int[] {5, 0, 76},
                new int[] {15, 0, 77},
                new int[] {16, 0, 78},
                new int[] {19, 0, 79},
                new int[] {30, 0, 80},
                new int[] {34, 0, 81},
                new int[] {40, 0, 202},
                new int[] {44, 0, 82},
            },
            new int[][] {
                new int[] {-1, 1, 74},
            },
            new int[][] {
                new int[] {-1, 1, 75},
            },
            new int[][] {
                new int[] {-1, 1, 65},
                new int[] {21, 0, 114},
                new int[] {26, 0, 204},
                new int[] {41, 0, 23},
                new int[] {44, 0, 115},
            },
            new int[][] {
                new int[] {-1, 1, 42},
            },
            new int[][] {
                new int[] {-1, 1, 144},
            },
            new int[][] {
                new int[] {-1, 1, 53},
            },
            new int[][] {
                new int[] {-1, 3, 177},
                new int[] {16, 0, 205},
                new int[] {31, 0, 26},
            },
            new int[][] {
                new int[] {-1, 3, 178},
                new int[] {18, 0, 206},
            },
            new int[][] {
                new int[] {-1, 1, 64},
            },
            new int[][] {
                new int[] {-1, 3, 180},
                new int[] {40, 0, 207},
            },
            new int[][] {
                new int[] {-1, 3, 181},
                new int[] {9, 0, 168},
                new int[] {10, 0, 169},
                new int[] {12, 0, 170},
                new int[] {13, 0, 171},
                new int[] {14, 0, 172},
                new int[] {16, 0, 173},
                new int[] {49, 0, 208},
            },
            new int[][] {
                new int[] {-1, 3, 182},
                new int[] {9, 0, 168},
                new int[] {10, 0, 169},
                new int[] {12, 0, 170},
                new int[] {13, 0, 171},
                new int[] {14, 0, 172},
                new int[] {16, 0, 173},
                new int[] {49, 0, 210},
            },
            new int[][] {
                new int[] {-1, 3, 183},
                new int[] {16, 0, 40},
            },
            new int[][] {
                new int[] {-1, 1, 41},
            },
            new int[][] {
                new int[] {-1, 1, 35},
            },
            new int[][] {
                new int[] {-1, 1, 37},
            },
            new int[][] {
                new int[] {-1, 3, 187},
                new int[] {5, 0, 213},
            },
            new int[][] {
                new int[] {-1, 3, 188},
                new int[] {40, 0, 214},
            },
            new int[][] {
                new int[] {-1, 1, 84},
            },
            new int[][] {
                new int[] {-1, 1, 79},
            },
            new int[][] {
                new int[] {-1, 1, 82},
                new int[] {5, 0, 108},
                new int[] {31, 0, 215},
            },
            new int[][] {
                new int[] {-1, 1, 81},
            },
            new int[][] {
                new int[] {-1, 1, 129},
            },
            new int[][] {
                new int[] {-1, 3, 194},
                new int[] {4, 0, 75},
                new int[] {5, 0, 76},
                new int[] {15, 0, 77},
                new int[] {16, 0, 78},
                new int[] {19, 0, 79},
                new int[] {30, 0, 80},
                new int[] {34, 0, 81},
                new int[] {44, 0, 82},
            },
            new int[][] {
                new int[] {-1, 1, 127},
            },
            new int[][] {
                new int[] {-1, 1, 126},
            },
            new int[][] {
                new int[] {-1, 3, 197},
                new int[] {45, 0, 217},
            },
            new int[][] {
                new int[] {-1, 3, 198},
                new int[] {20, 0, 218},
            },
            new int[][] {
                new int[] {-1, 1, 114},
            },
            new int[][] {
                new int[] {-1, 3, 200},
                new int[] {4, 0, 75},
                new int[] {5, 0, 76},
                new int[] {15, 0, 77},
                new int[] {16, 0, 78},
                new int[] {19, 0, 79},
                new int[] {30, 0, 80},
                new int[] {34, 0, 81},
                new int[] {44, 0, 82},
            },
            new int[][] {
                new int[] {-1, 3, 201},
                new int[] {4, 0, 75},
                new int[] {5, 0, 76},
                new int[] {15, 0, 77},
                new int[] {16, 0, 78},
                new int[] {19, 0, 79},
                new int[] {30, 0, 80},
                new int[] {34, 0, 81},
                new int[] {44, 0, 82},
            },
            new int[][] {
                new int[] {-1, 1, 62},
            },
            new int[][] {
                new int[] {-1, 3, 203},
                new int[] {40, 0, 221},
            },
            new int[][] {
                new int[] {-1, 3, 204},
                new int[] {4, 0, 75},
                new int[] {5, 0, 76},
                new int[] {15, 0, 77},
                new int[] {16, 0, 78},
                new int[] {19, 0, 79},
                new int[] {30, 0, 80},
                new int[] {34, 0, 81},
                new int[] {44, 0, 82},
            },
            new int[][] {
                new int[] {-1, 3, 205},
                new int[] {26, 0, 223},
                new int[] {40, 0, 224},
                new int[] {46, 0, 225},
            },
            new int[][] {
                new int[] {-1, 3, 206},
                new int[] {16, 0, 19},
            },
            new int[][] {
                new int[] {-1, 1, 124},
            },
            new int[][] {
                new int[] {-1, 1, 44},
            },
            new int[][] {
                new int[] {-1, 1, 145},
            },
            new int[][] {
                new int[] {-1, 1, 43},
            },
            new int[][] {
                new int[] {-1, 3, 211},
                new int[] {9, 0, 168},
                new int[] {10, 0, 169},
                new int[] {12, 0, 170},
                new int[] {13, 0, 171},
                new int[] {14, 0, 172},
                new int[] {16, 0, 173},
                new int[] {49, 0, 227},
            },
            new int[][] {
                new int[] {-1, 1, 47},
            },
            new int[][] {
                new int[] {-1, 3, 213},
                new int[] {47, 0, 228},
            },
            new int[][] {
                new int[] {-1, 1, 36},
            },
            new int[][] {
                new int[] {-1, 3, 215},
                new int[] {5, 0, 229},
            },
            new int[][] {
                new int[] {-1, 1, 131},
            },
            new int[][] {
                new int[] {-1, 1, 128},
            },
            new int[][] {
                new int[] {-1, 1, 123},
            },
            new int[][] {
                new int[] {-1, 3, 219},
                new int[] {45, 0, 230},
            },
            new int[][] {
                new int[] {-1, 3, 220},
                new int[] {45, 0, 231},
            },
            new int[][] {
                new int[] {-1, 1, 63},
            },
            new int[][] {
                new int[] {-1, 3, 222},
                new int[] {40, 0, 232},
            },
            new int[][] {
                new int[] {-1, 3, 223},
                new int[] {4, 0, 75},
                new int[] {5, 0, 76},
                new int[] {15, 0, 77},
                new int[] {16, 0, 78},
                new int[] {19, 0, 79},
                new int[] {30, 0, 80},
                new int[] {34, 0, 81},
                new int[] {44, 0, 82},
            },
            new int[][] {
                new int[] {-1, 1, 58},
            },
            new int[][] {
                new int[] {-1, 3, 225},
                new int[] {5, 0, 234},
            },
            new int[][] {
                new int[] {-1, 3, 226},
                new int[] {9, 0, 235},
                new int[] {10, 0, 236},
                new int[] {12, 0, 170},
                new int[] {13, 0, 171},
                new int[] {14, 0, 172},
                new int[] {16, 0, 173},
                new int[] {48, 0, 237},
            },
            new int[][] {
                new int[] {-1, 1, 45},
            },
            new int[][] {
                new int[] {-1, 3, 228},
                new int[] {40, 0, 244},
            },
            new int[][] {
                new int[] {-1, 1, 83},
            },
            new int[][] {
                new int[] {-1, 3, 230},
                new int[] {9, 0, 168},
                new int[] {10, 0, 169},
                new int[] {12, 0, 170},
                new int[] {13, 0, 171},
                new int[] {14, 0, 172},
                new int[] {16, 0, 173},
                new int[] {48, 0, 245},
            },
            new int[][] {
                new int[] {-1, 3, 231},
                new int[] {9, 0, 235},
                new int[] {10, 0, 236},
                new int[] {12, 0, 170},
                new int[] {13, 0, 171},
                new int[] {14, 0, 172},
                new int[] {16, 0, 173},
                new int[] {48, 0, 237},
            },
            new int[][] {
                new int[] {-1, 1, 61},
            },
            new int[][] {
                new int[] {-1, 3, 233},
                new int[] {40, 0, 249},
            },
            new int[][] {
                new int[] {-1, 3, 234},
                new int[] {47, 0, 250},
            },
            new int[][] {
                new int[] {-1, 3, 235},
                new int[] {44, 0, 251},
            },
            new int[][] {
                new int[] {-1, 3, 236},
                new int[] {44, 0, 252},
            },
            new int[][] {
                new int[] {-1, 3, 237},
                new int[] {9, 0, 168},
                new int[] {10, 0, 169},
                new int[] {12, 0, 170},
                new int[] {13, 0, 171},
                new int[] {14, 0, 172},
                new int[] {16, 0, 173},
                new int[] {49, 0, 253},
            },
            new int[][] {
                new int[] {-1, 1, 68},
            },
            new int[][] {
                new int[] {-1, 1, 71},
            },
            new int[][] {
                new int[] {-1, 1, 53},
                new int[] {11, 1, 57},
            },
            new int[][] {
                new int[] {-1, 1, 51},
            },
            new int[][] {
                new int[] {-1, 3, 242},
                new int[] {11, 0, 255},
            },
            new int[][] {
                new int[] {-1, 3, 243},
                new int[] {18, 0, 256},
            },
            new int[][] {
                new int[] {-1, 1, 38},
            },
            new int[][] {
                new int[] {-1, 3, 245},
                new int[] {9, 0, 168},
                new int[] {10, 0, 169},
                new int[] {12, 0, 170},
                new int[] {13, 0, 171},
                new int[] {14, 0, 172},
                new int[] {16, 0, 173},
                new int[] {49, 0, 257},
            },
            new int[][] {
                new int[] {-1, 1, 50},
            },
            new int[][] {
                new int[] {-1, 1, 48},
            },
            new int[][] {
                new int[] {-1, 3, 248},
                new int[] {11, 0, 259},
            },
            new int[][] {
                new int[] {-1, 1, 59},
            },
            new int[][] {
                new int[] {-1, 1, 60},
            },
            new int[][] {
                new int[] {-1, 3, 251},
                new int[] {4, 0, 75},
                new int[] {5, 0, 76},
                new int[] {15, 0, 77},
                new int[] {16, 0, 78},
                new int[] {19, 0, 79},
                new int[] {30, 0, 80},
                new int[] {34, 0, 81},
                new int[] {44, 0, 82},
            },
            new int[][] {
                new int[] {-1, 3, 252},
                new int[] {4, 0, 75},
                new int[] {5, 0, 76},
                new int[] {15, 0, 77},
                new int[] {16, 0, 78},
                new int[] {19, 0, 79},
                new int[] {30, 0, 80},
                new int[] {34, 0, 81},
                new int[] {44, 0, 82},
            },
            new int[][] {
                new int[] {-1, 1, 69},
                new int[] {11, 1, 72},
            },
            new int[][] {
                new int[] {-1, 3, 254},
                new int[] {9, 0, 168},
                new int[] {10, 0, 169},
                new int[] {12, 0, 170},
                new int[] {13, 0, 171},
                new int[] {14, 0, 172},
                new int[] {16, 0, 173},
                new int[] {49, 0, 262},
            },
            new int[][] {
                new int[] {-1, 3, 255},
                new int[] {9, 0, 263},
                new int[] {10, 0, 264},
                new int[] {12, 0, 170},
                new int[] {13, 0, 171},
                new int[] {14, 0, 172},
                new int[] {16, 0, 173},
                new int[] {48, 0, 265},
            },
            new int[][] {
                new int[] {-1, 3, 256},
                new int[] {16, 0, 19},
            },
            new int[][] {
                new int[] {-1, 1, 69},
            },
            new int[][] {
                new int[] {-1, 3, 258},
                new int[] {9, 0, 168},
                new int[] {10, 0, 169},
                new int[] {12, 0, 170},
                new int[] {13, 0, 171},
                new int[] {14, 0, 172},
                new int[] {16, 0, 173},
                new int[] {49, 0, 270},
            },
            new int[][] {
                new int[] {-1, 3, 259},
                new int[] {9, 0, 263},
                new int[] {10, 0, 264},
                new int[] {12, 0, 170},
                new int[] {13, 0, 171},
                new int[] {14, 0, 172},
                new int[] {16, 0, 173},
                new int[] {48, 0, 265},
            },
            new int[][] {
                new int[] {-1, 3, 260},
                new int[] {45, 0, 272},
            },
            new int[][] {
                new int[] {-1, 3, 261},
                new int[] {45, 0, 273},
            },
            new int[][] {
                new int[] {-1, 1, 70},
                new int[] {11, 1, 73},
            },
            new int[][] {
                new int[] {-1, 3, 263},
                new int[] {44, 0, 274},
            },
            new int[][] {
                new int[] {-1, 3, 264},
                new int[] {44, 0, 275},
            },
            new int[][] {
                new int[] {-1, 3, 265},
                new int[] {9, 0, 168},
                new int[] {10, 0, 169},
                new int[] {12, 0, 170},
                new int[] {13, 0, 171},
                new int[] {14, 0, 172},
                new int[] {16, 0, 173},
                new int[] {49, 0, 276},
            },
            new int[][] {
                new int[] {-1, 1, 57},
            },
            new int[][] {
                new int[] {-1, 1, 52},
            },
            new int[][] {
                new int[] {-1, 3, 268},
                new int[] {18, 0, 278},
            },
            new int[][] {
                new int[] {-1, 3, 269},
                new int[] {9, 0, 235},
                new int[] {10, 0, 236},
                new int[] {12, 0, 170},
                new int[] {13, 0, 171},
                new int[] {14, 0, 172},
                new int[] {16, 0, 173},
                new int[] {48, 0, 237},
            },
            new int[][] {
                new int[] {-1, 1, 70},
            },
            new int[][] {
                new int[] {-1, 1, 49},
            },
            new int[][] {
                new int[] {-1, 3, 272},
                new int[] {9, 0, 235},
                new int[] {10, 0, 236},
                new int[] {12, 0, 170},
                new int[] {13, 0, 171},
                new int[] {14, 0, 172},
                new int[] {16, 0, 173},
                new int[] {48, 0, 237},
            },
            new int[][] {
                new int[] {-1, 3, 273},
                new int[] {9, 0, 235},
                new int[] {10, 0, 236},
                new int[] {12, 0, 170},
                new int[] {13, 0, 171},
                new int[] {14, 0, 172},
                new int[] {16, 0, 173},
                new int[] {48, 0, 237},
            },
            new int[][] {
                new int[] {-1, 3, 274},
                new int[] {4, 0, 75},
                new int[] {5, 0, 76},
                new int[] {15, 0, 77},
                new int[] {16, 0, 78},
                new int[] {19, 0, 79},
                new int[] {30, 0, 80},
                new int[] {34, 0, 81},
                new int[] {44, 0, 82},
            },
            new int[][] {
                new int[] {-1, 3, 275},
                new int[] {4, 0, 75},
                new int[] {5, 0, 76},
                new int[] {15, 0, 77},
                new int[] {16, 0, 78},
                new int[] {19, 0, 79},
                new int[] {30, 0, 80},
                new int[] {34, 0, 81},
                new int[] {44, 0, 82},
            },
            new int[][] {
                new int[] {-1, 1, 72},
            },
            new int[][] {
                new int[] {-1, 3, 277},
                new int[] {9, 0, 168},
                new int[] {10, 0, 169},
                new int[] {12, 0, 170},
                new int[] {13, 0, 171},
                new int[] {14, 0, 172},
                new int[] {16, 0, 173},
                new int[] {49, 0, 284},
            },
            new int[][] {
                new int[] {-1, 3, 278},
                new int[] {16, 0, 19},
            },
            new int[][] {
                new int[] {-1, 3, 279},
                new int[] {11, 0, 286},
            },
            new int[][] {
                new int[] {-1, 1, 55},
            },
            new int[][] {
                new int[] {-1, 3, 281},
                new int[] {11, 0, 287},
            },
            new int[][] {
                new int[] {-1, 3, 282},
                new int[] {45, 0, 288},
            },
            new int[][] {
                new int[] {-1, 3, 283},
                new int[] {45, 0, 289},
            },
            new int[][] {
                new int[] {-1, 1, 73},
            },
            new int[][] {
                new int[] {-1, 3, 285},
                new int[] {9, 0, 263},
                new int[] {10, 0, 264},
                new int[] {12, 0, 170},
                new int[] {13, 0, 171},
                new int[] {14, 0, 172},
                new int[] {16, 0, 173},
                new int[] {48, 0, 265},
            },
            new int[][] {
                new int[] {-1, 3, 286},
                new int[] {9, 0, 263},
                new int[] {10, 0, 264},
                new int[] {12, 0, 170},
                new int[] {13, 0, 171},
                new int[] {14, 0, 172},
                new int[] {16, 0, 173},
                new int[] {48, 0, 265},
            },
            new int[][] {
                new int[] {-1, 3, 287},
                new int[] {9, 0, 263},
                new int[] {10, 0, 264},
                new int[] {12, 0, 170},
                new int[] {13, 0, 171},
                new int[] {14, 0, 172},
                new int[] {16, 0, 173},
                new int[] {48, 0, 265},
            },
            new int[][] {
                new int[] {-1, 3, 288},
                new int[] {9, 0, 263},
                new int[] {10, 0, 264},
                new int[] {12, 0, 170},
                new int[] {13, 0, 171},
                new int[] {14, 0, 172},
                new int[] {16, 0, 173},
                new int[] {48, 0, 265},
            },
            new int[][] {
                new int[] {-1, 3, 289},
                new int[] {9, 0, 263},
                new int[] {10, 0, 264},
                new int[] {12, 0, 170},
                new int[] {13, 0, 171},
                new int[] {14, 0, 172},
                new int[] {16, 0, 173},
                new int[] {48, 0, 265},
            },
            new int[][] {
                new int[] {-1, 3, 290},
                new int[] {11, 0, 294},
            },
            new int[][] {
                new int[] {-1, 1, 52},
                new int[] {11, 1, 56},
            },
            new int[][] {
                new int[] {-1, 1, 49},
                new int[] {11, 1, 54},
            },
            new int[][] {
                new int[] {-1, 3, 293},
                new int[] {11, 0, 295},
            },
            new int[][] {
                new int[] {-1, 3, 294},
                new int[] {9, 0, 263},
                new int[] {10, 0, 264},
                new int[] {12, 0, 170},
                new int[] {13, 0, 171},
                new int[] {14, 0, 172},
                new int[] {16, 0, 173},
                new int[] {48, 0, 265},
            },
            new int[][] {
                new int[] {-1, 3, 295},
                new int[] {9, 0, 263},
                new int[] {10, 0, 264},
                new int[] {12, 0, 170},
                new int[] {13, 0, 171},
                new int[] {14, 0, 172},
                new int[] {16, 0, 173},
                new int[] {48, 0, 265},
            },
            new int[][] {
                new int[] {-1, 1, 56},
            },
            new int[][] {
                new int[] {-1, 1, 54},
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
                new int[] {13, 28},
            },
            new int[][] {
                new int[] {-1, 7},
                new int[] {14, 33},
                new int[] {29, 33},
            },
            new int[][] {
                new int[] {-1, 8},
                new int[] {15, 37},
                new int[] {30, 37},
                new int[] {34, 37},
                new int[] {58, 37},
            },
            new int[][] {
                new int[] {-1, 9},
                new int[] {16, 41},
                new int[] {31, 41},
                new int[] {35, 41},
                new int[] {38, 41},
                new int[] {59, 41},
                new int[] {61, 41},
                new int[] {64, 41},
                new int[] {96, 41},
            },
            new int[][] {
                new int[] {-1, 102},
                new int[] {104, 141},
            },
            new int[][] {
                new int[] {-1, 10},
                new int[] {17, 43},
                new int[] {32, 43},
                new int[] {36, 43},
                new int[] {39, 43},
                new int[] {42, 43},
                new int[] {60, 43},
                new int[] {62, 43},
                new int[] {63, 43},
                new int[] {65, 43},
                new int[] {66, 43},
                new int[] {67, 43},
                new int[] {97, 43},
                new int[] {98, 43},
                new int[] {99, 43},
                new int[] {100, 43},
                new int[] {137, 43},
            },
            new int[][] {
                new int[] {-1, 92},
                new int[] {183, 212},
            },
            new int[][] {
                new int[] {-1, 238},
                new int[] {133, 175},
                new int[] {181, 209},
                new int[] {182, 175},
                new int[] {211, 209},
                new int[] {237, 175},
                new int[] {245, 175},
                new int[] {254, 209},
                new int[] {258, 209},
                new int[] {265, 175},
                new int[] {277, 209},
            },
            new int[][] {
                new int[] {-1, 239},
            },
            new int[][] {
                new int[] {-1, 176},
                new int[] {226, 240},
                new int[] {231, 240},
                new int[] {255, 266},
                new int[] {259, 266},
                new int[] {269, 240},
                new int[] {272, 240},
                new int[] {273, 240},
                new int[] {285, 266},
                new int[] {286, 266},
                new int[] {287, 266},
                new int[] {288, 266},
                new int[] {289, 266},
                new int[] {294, 266},
                new int[] {295, 266},
            },
            new int[][] {
                new int[] {-1, 11},
                new int[] {55, 93},
                new int[] {69, 103},
                new int[] {104, 103},
                new int[] {133, 177},
                new int[] {181, 177},
                new int[] {182, 177},
                new int[] {183, 93},
                new int[] {211, 177},
                new int[] {226, 177},
                new int[] {230, 177},
                new int[] {231, 177},
                new int[] {237, 177},
                new int[] {245, 177},
                new int[] {254, 177},
                new int[] {255, 177},
                new int[] {258, 177},
                new int[] {259, 177},
                new int[] {265, 177},
                new int[] {269, 177},
                new int[] {272, 177},
                new int[] {273, 177},
                new int[] {277, 177},
                new int[] {285, 177},
                new int[] {286, 177},
                new int[] {287, 177},
                new int[] {288, 177},
                new int[] {289, 177},
                new int[] {294, 177},
                new int[] {295, 177},
            },
            new int[][] {
                new int[] {-1, 241},
                new int[] {230, 246},
                new int[] {231, 247},
                new int[] {272, 246},
                new int[] {273, 247},
            },
            new int[][] {
                new int[] {-1, 280},
                new int[] {226, 242},
                new int[] {231, 248},
                new int[] {255, 267},
                new int[] {259, 271},
                new int[] {269, 279},
                new int[] {273, 281},
                new int[] {285, 290},
                new int[] {286, 291},
                new int[] {287, 292},
                new int[] {289, 293},
                new int[] {294, 296},
                new int[] {295, 297},
            },
            new int[][] {
                new int[] {-1, 178},
                new int[] {226, 243},
                new int[] {231, 243},
                new int[] {255, 268},
                new int[] {259, 268},
                new int[] {269, 243},
                new int[] {272, 243},
                new int[] {273, 243},
                new int[] {285, 268},
                new int[] {286, 268},
                new int[] {287, 268},
                new int[] {288, 268},
                new int[] {289, 268},
                new int[] {294, 268},
                new int[] {295, 268},
            },
            new int[][] {
                new int[] {-1, 24},
                new int[] {155, 198},
            },
            new int[][] {
                new int[] {-1, 109},
            },
            new int[][] {
                new int[] {-1, 110},
            },
            new int[][] {
                new int[] {-1, 111},
                new int[] {112, 148},
                new int[] {191, 148},
            },
            new int[][] {
                new int[] {-1, 50},
            },
            new int[][] {
                new int[] {-1, 51},
                new int[] {70, 105},
                new int[] {71, 106},
            },
            new int[][] {
                new int[] {-1, 12},
                new int[] {2, 20},
                new int[] {23, 52},
                new int[] {27, 20},
                new int[] {44, 20},
                new int[] {70, 52},
                new int[] {71, 52},
                new int[] {74, 20},
                new int[] {114, 20},
                new int[] {206, 20},
                new int[] {256, 20},
                new int[] {278, 20},
            },
            new int[][] {
                new int[] {-1, 21},
                new int[] {27, 57},
                new int[] {44, 68},
                new int[] {74, 113},
                new int[] {114, 149},
                new int[] {206, 226},
                new int[] {256, 269},
                new int[] {278, 285},
            },
            new int[][] {
                new int[] {-1, 151},
                new int[] {53, 83},
                new int[] {79, 117},
                new int[] {82, 120},
                new int[] {132, 167},
                new int[] {170, 203},
                new int[] {200, 219},
                new int[] {201, 220},
                new int[] {204, 222},
                new int[] {223, 233},
                new int[] {251, 260},
                new int[] {252, 261},
                new int[] {274, 282},
                new int[] {275, 283},
            },
            new int[][] {
                new int[] {-1, 84},
                new int[] {122, 157},
                new int[] {123, 158},
            },
            new int[][] {
                new int[] {-1, 85},
                new int[] {124, 159},
            },
            new int[][] {
                new int[] {-1, 86},
                new int[] {81, 119},
                new int[] {125, 160},
                new int[] {126, 161},
            },
            new int[][] {
                new int[] {-1, 87},
                new int[] {80, 118},
                new int[] {128, 163},
                new int[] {129, 164},
                new int[] {130, 165},
            },
            new int[][] {
                new int[] {-1, 88},
            },
            new int[][] {
                new int[] {-1, 89},
            },
            new int[][] {
                new int[] {-1, 179},
            },
            new int[][] {
                new int[] {-1, 90},
                new int[] {133, 180},
                new int[] {181, 180},
                new int[] {182, 180},
                new int[] {211, 180},
                new int[] {226, 180},
                new int[] {230, 180},
                new int[] {231, 180},
                new int[] {237, 180},
                new int[] {245, 180},
                new int[] {254, 180},
                new int[] {255, 180},
                new int[] {258, 180},
                new int[] {259, 180},
                new int[] {265, 180},
                new int[] {269, 180},
                new int[] {272, 180},
                new int[] {273, 180},
                new int[] {277, 180},
                new int[] {285, 180},
                new int[] {286, 180},
                new int[] {287, 180},
                new int[] {288, 180},
                new int[] {289, 180},
                new int[] {294, 180},
                new int[] {295, 180},
            },
            new int[][] {
                new int[] {-1, 116},
            },
            new int[][] {
                new int[] {-1, 152},
                new int[] {153, 197},
                new int[] {194, 216},
            },
            new int[][] {
                new int[] {-1, 13},
            },
            new int[][] {
                new int[] {-1, 14},
                new int[] {13, 29},
            },
            new int[][] {
                new int[] {-1, 15},
                new int[] {13, 30},
                new int[] {14, 34},
                new int[] {29, 58},
            },
            new int[][] {
                new int[] {-1, 16},
                new int[] {13, 31},
                new int[] {14, 35},
                new int[] {15, 38},
                new int[] {29, 59},
                new int[] {30, 61},
                new int[] {34, 64},
                new int[] {58, 96},
            },
            new int[][] {
                new int[] {-1, 17},
                new int[] {13, 32},
                new int[] {14, 36},
                new int[] {15, 39},
                new int[] {16, 42},
                new int[] {29, 60},
                new int[] {30, 62},
                new int[] {31, 63},
                new int[] {34, 65},
                new int[] {35, 66},
                new int[] {38, 67},
                new int[] {58, 97},
                new int[] {59, 98},
                new int[] {61, 99},
                new int[] {64, 100},
                new int[] {96, 137},
            },
            new int[][] {
                new int[] {-1, 104},
            },
            new int[][] {
                new int[] {-1, 181},
                new int[] {182, 211},
                new int[] {237, 254},
                new int[] {245, 258},
                new int[] {265, 277},
            },
            new int[][] {
                new int[] {-1, 112},
                new int[] {146, 191},
            },
        };
        #endregion
        #region errorMessages
        private static string[] errorMessages = {
            "Expecting: '#include', 'principal', 'typedef', TIdentifier or end of file",
            "Expecting: TFile",
            "Expecting: TIdentifier",
            "Expecting: 'struct'",
            "Expecting: TIdentifier, '-->', '*' or '{{'",
            "Expecting: end of file",
            "Expecting: 'principal', 'typedef', TIdentifier or end of file",
            "Expecting: 'typedef', TIdentifier or end of file",
            "Expecting: TIdentifier or end of file",
            "Expecting: TIdentifier or '*'",
            "Expecting: '-->'",
            "Expecting: 'while', 'if', 'return', 'this', 'caller', TIdentifier, '>>>', ',', ';', '@', '}}', '{' or '⊔'",
            "Expecting: ';'",
            "Expecting: TIdentifier, '_' or '^'",
            "Expecting: '=', ';', '(' or '['",
            "Expecting: TIdentifier, '*' or '{{'",
            "Expecting: '{'",
            "Expecting: '->', ';', '@', '}}' or '⊔'",
            "Expecting: ';', '@', '}}' or '⊔'",
            "Expecting: '@' or '}}'",
            "Expecting: '->'",
            "Expecting: TBool, TNumber, 'NULL', TIdentifier, '<|', '-', '!' or '('",
            "Expecting: TIdentifier or ')'",
            "Expecting: TNumber",
            "Expecting: 'while', 'if', 'return', 'this', 'caller', TIdentifier, '>>>', ';', '@', '}}', '{' or '⊔'",
            "Expecting: TIdentifier or '}'",
            "Expecting: TTime or TNumber",
            "Expecting: TIdentifier, '|>' or '*'",
            "Expecting: TIdentifier, ';', '@', '}}' or '⊔'",
            "Expecting: '|>', '->', TCompare, '+', '-', '*', '/', '%', '&&', '||', '.', ',', ';', ')', '[' or ']'",
            "Expecting: '|>', '<<<', '->', TCompare, '+', '-', '*', '/', '%', '&&', '||', '.', ',', ';', '(', ')', '[' or ']'",
            "Expecting: TBool, TNumber, 'NULL', TIdentifier, '<|' or '('",
            "Expecting: TBool, TNumber, 'NULL', TIdentifier, '<|', '-' or '('",
            "Expecting: '|>', ',', ';', ')' or ']'",
            "Expecting: '|>', '&&', '||', ',', ';', ')' or ']'",
            "Expecting: '|>', TCompare, '&&', '||', ',', ';', ')' or ']'",
            "Expecting: '|>', TCompare, '+', '-', '&&', '||', ',', ';', ')' or ']'",
            "Expecting: ')'",
            "Expecting: ']'",
            "Expecting: '-'",
            "Expecting: TIntervalUnit",
            "Expecting: '}}'",
            "Expecting: '*', ',' or '}}'",
            "Expecting: TNumber, '*' or '}}'",
            "Expecting: TBool, TNumber, 'NULL', TIdentifier, '<|', '-', '!', '(' or ')'",
            "Expecting: '('",
            "Expecting: '|>' or ','",
            "Expecting: 'while', 'if', 'return', 'this', 'caller', TIdentifier or '}'",
            "Expecting: ',' or ')'",
            "Expecting: ';' or '['",
            "Expecting: TTime",
            "Expecting: '>>>'",
            "Expecting: '{{'",
            "Expecting: TBool, TNumber, 'NULL', TIdentifier, '<|', '-', '!', ';' or '('",
            "Expecting: TIfActsFor",
            "Expecting: TIdentifier, '<<<', '=', '*', '{{' or '('",
            "Expecting: 'while', 'if', 'else', 'return', 'this', 'caller', TIdentifier or '}'",
            "Expecting: '|>'",
            "Expecting: '=', ';' or '['",
            "Expecting: 'while', 'if', 'return', 'this', 'caller', TIdentifier or '{'",
            "Expecting: 'else'",
        };
        #endregion
        #region errors
        private static int[] errors = {
            0, 1, 2, 3, 4, 5, 0, 6, 7, 7, 8, 9, 10, 0, 6, 7,
            7, 8, 0, 11, 11, 12, 2, 13, 9, 14, 9, 2, 0, 6, 7, 7,
            8, 6, 7, 7, 8, 7, 7, 8, 15, 7, 8, 8, 2, 6, 16, 17,
            18, 18, 18, 19, 20, 21, 8, 22, 23, 12, 7, 7, 8, 7, 8, 8,
            7, 8, 8, 8, 24, 25, 13, 13, 26, 27, 28, 29, 29, 29, 30, 21,
            31, 32, 21, 12, 33, 34, 35, 36, 29, 29, 29, 16, 37, 9, 38, 7,
            7, 8, 8, 8, 8, 2, 25, 9, 25, 19, 19, 39, 40, 41, 42, 43,
            43, 18, 2, 44, 45, 46, 35, 34, 37, 8, 21, 21, 21, 32, 32, 2,
            31, 31, 31, 2, 21, 47, 16, 48, 12, 8, 12, 49, 2, 25, 50, 43,
            27, 23, 23, 23, 43, 51, 29, 48, 37, 44, 29, 52, 29, 33, 33, 34,
            35, 35, 29, 36, 36, 36, 29, 38, 45, 45, 53, 54, 54, 55, 8, 47,
            47, 9, 54, 56, 12, 47, 47, 2, 8, 7, 25, 23, 12, 42, 41, 43,
            41, 45, 21, 29, 29, 37, 57, 29, 21, 21, 56, 12, 21, 58, 2, 56,
            8, 47, 8, 47, 37, 38, 7, 23, 37, 29, 29, 37, 37, 56, 12, 21,
            56, 23, 59, 8, 12, 41, 59, 59, 56, 12, 38, 45, 45, 47, 47, 56,
            56, 47, 60, 54, 25, 47, 47, 47, 60, 56, 56, 21, 21, 56, 47, 59,
            2, 47, 47, 59, 37, 37, 56, 45, 45, 47, 56, 47, 54, 59, 47, 47,
            59, 59, 21, 21, 56, 47, 2, 60, 56, 60, 37, 37, 56, 59, 59, 59,
            59, 59, 60, 56, 56, 60, 59, 59, 56, 56,
        };
        #endregion
    }
}
