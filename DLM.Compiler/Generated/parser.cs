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
        
        private int getIndex(TDirective node)
        {
            return 0;
        }
        private int getIndex(TTime node)
        {
            return 1;
        }
        private int getIndex(TIntervalUnit node)
        {
            return 2;
        }
        private int getIndex(TBool node)
        {
            return 3;
        }
        private int getIndex(TNumber node)
        {
            return 4;
        }
        private int getIndex(TPrincipall node)
        {
            return 5;
        }
        private int getIndex(TTypedef node)
        {
            return 6;
        }
        private int getIndex(TStruct node)
        {
            return 7;
        }
        private int getIndex(TWhile node)
        {
            return 8;
        }
        private int getIndex(TIf node)
        {
            return 9;
        }
        private int getIndex(TElse node)
        {
            return 10;
        }
        private int getIndex(TReturn node)
        {
            return 11;
        }
        private int getIndex(TThis node)
        {
            return 12;
        }
        private int getIndex(TCaller node)
        {
            return 13;
        }
        private int getIndex(TNull node)
        {
            return 14;
        }
        private int getIndex(TChar node)
        {
            return 15;
        }
        private int getIndex(TCharErr node)
        {
            return 16;
        }
        private int getIndex(TString node)
        {
            return 17;
        }
        private int getIndex(TStringErr node)
        {
            return 18;
        }
        private int getIndex(TIdentifier node)
        {
            return 19;
        }
        private int getIndex(TActsFor node)
        {
            return 20;
        }
        private int getIndex(TIfActsFor node)
        {
            return 21;
        }
        private int getIndex(TDeclassifyStart node)
        {
            return 22;
        }
        private int getIndex(TDeclassifyEnd node)
        {
            return 23;
        }
        private int getIndex(TFuncAuthStart node)
        {
            return 24;
        }
        private int getIndex(TFuncAuthEnd node)
        {
            return 25;
        }
        private int getIndex(TRArrow node)
        {
            return 26;
        }
        private int getIndex(TLArrow node)
        {
            return 27;
        }
        private int getIndex(TCompare node)
        {
            return 28;
        }
        private int getIndex(TAssign node)
        {
            return 29;
        }
        private int getIndex(TUnderscore node)
        {
            return 30;
        }
        private int getIndex(THat node)
        {
            return 31;
        }
        private int getIndex(TPlus node)
        {
            return 32;
        }
        private int getIndex(TMinus node)
        {
            return 33;
        }
        private int getIndex(TAsterisk node)
        {
            return 34;
        }
        private int getIndex(TSlash node)
        {
            return 35;
        }
        private int getIndex(TPercent node)
        {
            return 36;
        }
        private int getIndex(TBang node)
        {
            return 37;
        }
        private int getIndex(TAnd node)
        {
            return 38;
        }
        private int getIndex(TOr node)
        {
            return 39;
        }
        private int getIndex(TPeriod node)
        {
            return 40;
        }
        private int getIndex(TComma node)
        {
            return 41;
        }
        private int getIndex(TColon node)
        {
            return 42;
        }
        private int getIndex(TSemicolon node)
        {
            return 43;
        }
        private int getIndex(TLabelStart node)
        {
            return 44;
        }
        private int getIndex(TTimeStart node)
        {
            return 45;
        }
        private int getIndex(TLabelEnd node)
        {
            return 46;
        }
        private int getIndex(TTimeCall node)
        {
            return 47;
        }
        private int getIndex(TTimeCheck node)
        {
            return 48;
        }
        private int getIndex(TLPar node)
        {
            return 49;
        }
        private int getIndex(TRPar node)
        {
            return 50;
        }
        private int getIndex(TLSqu node)
        {
            return 51;
        }
        private int getIndex(TRSqu node)
        {
            return 52;
        }
        private int getIndex(TLCur node)
        {
            return 53;
        }
        private int getIndex(TRCur node)
        {
            return 54;
        }
        private int getIndex(TJoin node)
        {
            return 55;
        }
        
        private int getIndex(EOF node)
        {
            return 56;
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
                        List<PPreProcessor> ppreprocessorlist = isOn(1, index - 0) ? Pop<List<PPreProcessor>>() : new List<PPreProcessor>();
                        List<PPreProcessor> ppreprocessorlist2 = new List<PPreProcessor>();
                        ppreprocessorlist2.AddRange(ppreprocessorlist);
                        List<PPrincipalDeclaration> pprincipaldeclarationlist2 = new List<PPrincipalDeclaration>();
                        pprincipaldeclarationlist2.AddRange(pprincipaldeclarationlist);
                        List<PPrincipalHierarchyDeclaration> pprincipalhierarchydeclarationlist2 = new List<PPrincipalHierarchyDeclaration>();
                        pprincipalhierarchydeclarationlist2.AddRange(pprincipalhierarchydeclarationlist);
                        List<PStruct> pstructlist2 = new List<PStruct>();
                        pstructlist2.AddRange(pstructlist);
                        List<PStatement> pstatementlist2 = new List<PStatement>();
                        pstatementlist2.AddRange(pstatementlist);
                        ARoot aroot = new ARoot(
                            ppreprocessorlist2,
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
                        TDirective tdirective = Pop<TDirective>();
                        APreProcessor apreprocessor = new APreProcessor(
                            tdirective
                        );
                        Push(1, apreprocessor);
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
                case 46:
                case 47:
                case 48:
                case 49:
                    {
                        TRCur trcur = Pop<TRCur>();
                        List<PStatement> pstatementlist = isOn(4, index - 42) ? Pop<List<PStatement>>() : new List<PStatement>();
                        TLCur tlcur = Pop<TLCur>();
                        TRPar trpar = Pop<TRPar>();
                        List<PFunctionParameter> pfunctionparameterlist = isOn(2, index - 42) ? Pop<List<PFunctionParameter>>() : new List<PFunctionParameter>();
                        TLPar tlpar = Pop<TLPar>();
                        TIdentifier tidentifier = Pop<TIdentifier>();
                        PType ptype = Pop<PType>();
                        List<PPrincipal> pprincipallist = isOn(1, index - 42) ? Pop<List<PPrincipal>>() : new List<PPrincipal>();
                        List<PPrincipal> pprincipallist2 = new List<PPrincipal>();
                        pprincipallist2.AddRange(pprincipallist);
                        List<PFunctionParameter> pfunctionparameterlist2 = new List<PFunctionParameter>();
                        pfunctionparameterlist2.AddRange(pfunctionparameterlist);
                        List<PStatement> pstatementlist2 = new List<PStatement>();
                        pstatementlist2.AddRange(pstatementlist);
                        AFunctionDeclarationStatement afunctiondeclarationstatement = new AFunctionDeclarationStatement(
                            pprincipallist2,
                            ptype,
                            tidentifier,
                            pfunctionparameterlist2,
                            pstatementlist2
                        );
                        Push(6, afunctiondeclarationstatement);
                    }
                    break;
                case 50:
                    {
                        TLArrow tlarrow = Pop<TLArrow>();
                        List<PPrincipal> pprincipallist = Pop<List<PPrincipal>>();
                        List<PPrincipal> pprincipallist2 = new List<PPrincipal>();
                        pprincipallist2.AddRange(pprincipallist);
                        Push(7, pprincipallist2);
                    }
                    break;
                case 51:
                    {
                        TIdentifier tidentifier = Pop<TIdentifier>();
                        PType ptype = Pop<PType>();
                        AFunctionParameter afunctionparameter = new AFunctionParameter(
                            ptype,
                            tidentifier
                        );
                        List<PFunctionParameter> pfunctionparameterlist = new List<PFunctionParameter>();
                        pfunctionparameterlist.Add(afunctionparameter);
                        Push(8, pfunctionparameterlist);
                    }
                    break;
                case 52:
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
                        Push(8, pfunctionparameterlist2);
                    }
                    break;
                case 53:
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
                        Push(9, aifstatement);
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
                        Push(9, aifactsforstatement);
                    }
                    break;
                case 57:
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
                case 58:
                    {
                        PStatement pstatement = Pop<PStatement>();
                        Push(9, pstatement);
                    }
                    break;
                case 59:
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
                        Push(10, aifelsestatement);
                    }
                    break;
                case 60:
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
                        Push(10, awhilestatement);
                    }
                    break;
                case 61:
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
                        Push(10, aifactsforelsestatement);
                    }
                    break;
                case 62:
                    {
                        PStatement pstatement = Pop<PStatement>();
                        Push(10, pstatement);
                    }
                    break;
                case 63:
                    {
                        TSemicolon tsemicolon = Pop<TSemicolon>();
                        TIdentifier tidentifier = Pop<TIdentifier>();
                        PType ptype = Pop<PType>();
                        ADeclarationStatement adeclarationstatement = new ADeclarationStatement(
                            ptype,
                            tidentifier,
                            null
                        );
                        Push(11, adeclarationstatement);
                    }
                    break;
                case 64:
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
                        Push(11, adeclarationstatement);
                    }
                    break;
                case 65:
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
                        Push(11, aarraydeclarationstatement);
                    }
                    break;
                case 66:
                    {
                        TSemicolon tsemicolon = Pop<TSemicolon>();
                        PExpression pexpression = Pop<PExpression>();
                        TAssign tassign = Pop<TAssign>();
                        TIdentifier tidentifier = Pop<TIdentifier>();
                        AAssignmentStatement aassignmentstatement = new AAssignmentStatement(
                            tidentifier,
                            pexpression
                        );
                        Push(11, aassignmentstatement);
                    }
                    break;
                case 67:
                case 68:
                    {
                        TSemicolon tsemicolon = Pop<TSemicolon>();
                        PExpression pexpression = isOn(1, index - 67) ? Pop<PExpression>() : null;
                        TReturn treturn = Pop<TReturn>();
                        AReturnStatement areturnstatement = new AReturnStatement(
                            treturn,
                            pexpression
                        );
                        Push(11, areturnstatement);
                    }
                    break;
                case 69:
                    {
                        PStatement pstatement = Pop<PStatement>();
                        Push(11, pstatement);
                    }
                    break;
                case 70:
                case 71:
                    {
                        PLabel plabel = isOn(1, index - 70) ? Pop<PLabel>() : null;
                        TIdentifier tidentifier = Pop<TIdentifier>();
                        AType atype = new AType(
                            tidentifier,
                            plabel
                        );
                        Push(12, atype);
                    }
                    break;
                case 72:
                    {
                        TAsterisk tasterisk = Pop<TAsterisk>();
                        PType ptype = Pop<PType>();
                        APointerType apointertype = new APointerType(
                            ptype,
                            tasterisk
                        );
                        Push(12, apointertype);
                    }
                    break;
                case 73:
                    {
                        PStatement pstatement = Pop<PStatement>();
                        List<PStatement> pstatementlist = new List<PStatement>();
                        pstatementlist.Add(pstatement);
                        Push(13, pstatementlist);
                    }
                    break;
                case 74:
                case 75:
                    {
                        TRCur trcur = Pop<TRCur>();
                        List<PStatement> pstatementlist = isOn(1, index - 74) ? Pop<List<PStatement>>() : new List<PStatement>();
                        TLCur tlcur = Pop<TLCur>();
                        List<PStatement> pstatementlist2 = new List<PStatement>();
                        pstatementlist2.AddRange(pstatementlist);
                        Push(13, pstatementlist2);
                    }
                    break;
                case 76:
                    {
                        PStatement pstatement = Pop<PStatement>();
                        List<PStatement> pstatementlist = new List<PStatement>();
                        pstatementlist.Add(pstatement);
                        Push(14, pstatementlist);
                    }
                    break;
                case 77:
                case 78:
                    {
                        TRCur trcur = Pop<TRCur>();
                        List<PStatement> pstatementlist = isOn(1, index - 77) ? Pop<List<PStatement>>() : new List<PStatement>();
                        TLCur tlcur = Pop<TLCur>();
                        List<PStatement> pstatementlist2 = new List<PStatement>();
                        pstatementlist2.AddRange(pstatementlist);
                        Push(14, pstatementlist2);
                    }
                    break;
                case 79:
                    {
                        TThis tthis = Pop<TThis>();
                        AThisClaimant athisclaimant = new AThisClaimant(
                            tthis
                        );
                        Push(15, athisclaimant);
                    }
                    break;
                case 80:
                    {
                        TCaller tcaller = Pop<TCaller>();
                        ACallerClaimant acallerclaimant = new ACallerClaimant(
                            tcaller
                        );
                        Push(15, acallerclaimant);
                    }
                    break;
                case 81:
                    {
                        TLabelEnd tlabelend = Pop<TLabelEnd>();
                        List<PPolicy> ppolicylist = Pop<List<PPolicy>>();
                        TLabelStart tlabelstart = Pop<TLabelStart>();
                        List<PPolicy> ppolicylist2 = new List<PPolicy>();
                        ppolicylist2.AddRange(ppolicylist);
                        ALabel alabel = new ALabel(
                            ppolicylist2
                        );
                        Push(16, alabel);
                    }
                    break;
                case 82:
                    {
                        PTimingPeriod ptimingperiod = Pop<PTimingPeriod>();
                        List<PTimingInterval> ptimingintervallist = new List<PTimingInterval>();
                        ATimePolicy atimepolicy = new ATimePolicy(
                            ptimingperiod,
                            ptimingintervallist,
                            null
                        );
                        Push(17, atimepolicy);
                    }
                    break;
                case 83:
                    {
                        TNumber tnumber = Pop<TNumber>();
                        TAsterisk tasterisk = Pop<TAsterisk>();
                        PTimingPeriod ptimingperiod = Pop<PTimingPeriod>();
                        List<PTimingInterval> ptimingintervallist = new List<PTimingInterval>();
                        ATimePolicy atimepolicy = new ATimePolicy(
                            ptimingperiod,
                            ptimingintervallist,
                            tnumber
                        );
                        Push(17, atimepolicy);
                    }
                    break;
                case 84:
                    {
                        List<PTimingInterval> ptimingintervallist = Pop<List<PTimingInterval>>();
                        ATimePolicy atimepolicy = new ATimePolicy(
                            null,
                            ptimingintervallist,
                            null
                        );
                        Push(17, atimepolicy);
                    }
                    break;
                case 85:
                    {
                        TNumber tnumber = Pop<TNumber>();
                        TAsterisk tasterisk = Pop<TAsterisk>();
                        List<PTimingInterval> ptimingintervallist = Pop<List<PTimingInterval>>();
                        ATimePolicy atimepolicy = new ATimePolicy(
                            null,
                            ptimingintervallist,
                            tnumber
                        );
                        Push(17, atimepolicy);
                    }
                    break;
                case 86:
                    {
                        List<PTimingInterval> ptimingintervallist = Pop<List<PTimingInterval>>();
                        PTimingPeriod ptimingperiod = Pop<PTimingPeriod>();
                        ATimePolicy atimepolicy = new ATimePolicy(
                            ptimingperiod,
                            ptimingintervallist,
                            null
                        );
                        Push(17, atimepolicy);
                    }
                    break;
                case 87:
                    {
                        TNumber tnumber = Pop<TNumber>();
                        TAsterisk tasterisk = Pop<TAsterisk>();
                        List<PTimingInterval> ptimingintervallist = Pop<List<PTimingInterval>>();
                        PTimingPeriod ptimingperiod = Pop<PTimingPeriod>();
                        ATimePolicy atimepolicy = new ATimePolicy(
                            ptimingperiod,
                            ptimingintervallist,
                            tnumber
                        );
                        Push(17, atimepolicy);
                    }
                    break;
                case 88:
                    {
                        TTime ttime = Pop<TTime>();
                        TMinus tminus = Pop<TMinus>();
                        TTime ttime2 = Pop<TTime>();
                        ATimingPeriod atimingperiod = new ATimingPeriod(
                            ttime2,
                            ttime
                        );
                        Push(18, atimingperiod);
                    }
                    break;
                case 89:
                    {
                        TIntervalUnit tintervalunit = Pop<TIntervalUnit>();
                        TNumber tnumber = Pop<TNumber>();
                        ATimingInterval atiminginterval = new ATimingInterval(
                            tnumber,
                            tintervalunit
                        );
                        Push(19, atiminginterval);
                    }
                    break;
                case 90:
                    {
                        TIdentifier tidentifier = Pop<TIdentifier>();
                        AVariablePolicy avariablepolicy = new AVariablePolicy(
                            tidentifier
                        );
                        Push(20, avariablepolicy);
                    }
                    break;
                case 91:
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
                        Push(20, aprincipalpolicy);
                    }
                    break;
                case 92:
                    {
                        TRArrow trarrow = Pop<TRArrow>();
                        PPrincipal pprincipal = Pop<PPrincipal>();
                        List<PPrincipal> pprincipallist = new List<PPrincipal>();
                        APrincipalPolicy aprincipalpolicy = new APrincipalPolicy(
                            pprincipal,
                            pprincipallist
                        );
                        Push(20, aprincipalpolicy);
                    }
                    break;
                case 93:
                    {
                        TUnderscore tunderscore = Pop<TUnderscore>();
                        ALowerPolicy alowerpolicy = new ALowerPolicy(
                            tunderscore
                        );
                        Push(20, alowerpolicy);
                    }
                    break;
                case 94:
                    {
                        THat that = Pop<THat>();
                        AUpperPolicy aupperpolicy = new AUpperPolicy(
                            that
                        );
                        Push(20, aupperpolicy);
                    }
                    break;
                case 95:
                    {
                        PPolicy ppolicy = Pop<PPolicy>();
                        List<PPolicy> ppolicylist = new List<PPolicy>();
                        ppolicylist.Add(ppolicy);
                        Push(21, ppolicylist);
                    }
                    break;
                case 96:
                    {
                        List<PPolicy> ppolicylist = Pop<List<PPolicy>>();
                        TSemicolon tsemicolon = Pop<TSemicolon>();
                        PPolicy ppolicy = Pop<PPolicy>();
                        List<PPolicy> ppolicylist2 = new List<PPolicy>();
                        ppolicylist2.Add(ppolicy);
                        ppolicylist2.AddRange(ppolicylist);
                        Push(21, ppolicylist2);
                    }
                    break;
                case 97:
                    {
                        List<PPolicy> ppolicylist = Pop<List<PPolicy>>();
                        TJoin tjoin = Pop<TJoin>();
                        PPolicy ppolicy = Pop<PPolicy>();
                        List<PPolicy> ppolicylist2 = new List<PPolicy>();
                        ppolicylist2.Add(ppolicy);
                        ppolicylist2.AddRange(ppolicylist);
                        Push(21, ppolicylist2);
                    }
                    break;
                case 98:
                    {
                        TIdentifier tidentifier = Pop<TIdentifier>();
                        APrincipal aprincipal = new APrincipal(
                            tidentifier,
                            null
                        );
                        Push(22, aprincipal);
                    }
                    break;
                case 99:
                    {
                        PTimePolicy ptimepolicy = Pop<PTimePolicy>();
                        TTimeStart ttimestart = Pop<TTimeStart>();
                        TIdentifier tidentifier = Pop<TIdentifier>();
                        APrincipal aprincipal = new APrincipal(
                            tidentifier,
                            ptimepolicy
                        );
                        Push(22, aprincipal);
                    }
                    break;
                case 100:
                    {
                        PPrincipal pprincipal = Pop<PPrincipal>();
                        List<PPrincipal> pprincipallist = new List<PPrincipal>();
                        pprincipallist.Add(pprincipal);
                        Push(23, pprincipallist);
                    }
                    break;
                case 101:
                    {
                        List<PPrincipal> pprincipallist = Pop<List<PPrincipal>>();
                        TComma tcomma = Pop<TComma>();
                        PPrincipal pprincipal = Pop<PPrincipal>();
                        List<PPrincipal> pprincipallist2 = new List<PPrincipal>();
                        pprincipallist2.Add(pprincipal);
                        pprincipallist2.AddRange(pprincipallist);
                        Push(23, pprincipallist2);
                    }
                    break;
                case 102:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        Push(24, pexpression);
                    }
                    break;
                case 103:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TAnd tand = Pop<TAnd>();
                        PExpression pexpression2 = Pop<PExpression>();
                        AAndExpression aandexpression = new AAndExpression(
                            pexpression2,
                            pexpression
                        );
                        Push(25, aandexpression);
                    }
                    break;
                case 104:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TOr tor = Pop<TOr>();
                        PExpression pexpression2 = Pop<PExpression>();
                        AOrExpression aorexpression = new AOrExpression(
                            pexpression2,
                            pexpression
                        );
                        Push(25, aorexpression);
                    }
                    break;
                case 105:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        Push(25, pexpression);
                    }
                    break;
                case 106:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TCompare tcompare = Pop<TCompare>();
                        PExpression pexpression2 = Pop<PExpression>();
                        AComparisonExpression acomparisonexpression = new AComparisonExpression(
                            pexpression2,
                            tcompare,
                            pexpression
                        );
                        Push(26, acomparisonexpression);
                    }
                    break;
                case 107:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TBang tbang = Pop<TBang>();
                        ANotExpression anotexpression = new ANotExpression(
                            pexpression
                        );
                        Push(26, anotexpression);
                    }
                    break;
                case 108:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        Push(26, pexpression);
                    }
                    break;
                case 109:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TPlus tplus = Pop<TPlus>();
                        PExpression pexpression2 = Pop<PExpression>();
                        APlusExpression aplusexpression = new APlusExpression(
                            pexpression2,
                            pexpression
                        );
                        Push(27, aplusexpression);
                    }
                    break;
                case 110:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TMinus tminus = Pop<TMinus>();
                        PExpression pexpression2 = Pop<PExpression>();
                        AMinusExpression aminusexpression = new AMinusExpression(
                            pexpression2,
                            pexpression
                        );
                        Push(27, aminusexpression);
                    }
                    break;
                case 111:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TMinus tminus = Pop<TMinus>();
                        ANegateExpression anegateexpression = new ANegateExpression(
                            pexpression
                        );
                        Push(27, anegateexpression);
                    }
                    break;
                case 112:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        Push(27, pexpression);
                    }
                    break;
                case 113:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TAsterisk tasterisk = Pop<TAsterisk>();
                        PExpression pexpression2 = Pop<PExpression>();
                        AMultiplyExpression amultiplyexpression = new AMultiplyExpression(
                            pexpression2,
                            pexpression
                        );
                        Push(28, amultiplyexpression);
                    }
                    break;
                case 114:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TSlash tslash = Pop<TSlash>();
                        PExpression pexpression2 = Pop<PExpression>();
                        ADivideExpression adivideexpression = new ADivideExpression(
                            pexpression2,
                            pexpression
                        );
                        Push(28, adivideexpression);
                    }
                    break;
                case 115:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TPercent tpercent = Pop<TPercent>();
                        PExpression pexpression2 = Pop<PExpression>();
                        AModuloExpression amoduloexpression = new AModuloExpression(
                            pexpression2,
                            pexpression
                        );
                        Push(28, amoduloexpression);
                    }
                    break;
                case 116:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        Push(28, pexpression);
                    }
                    break;
                case 117:
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
                        Push(29, aelementexpression);
                    }
                    break;
                case 118:
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
                        Push(29, aelementexpression);
                    }
                    break;
                case 119:
                    {
                        TRSqu trsqu = Pop<TRSqu>();
                        PExpression pexpression = Pop<PExpression>();
                        TLSqu tlsqu = Pop<TLSqu>();
                        PExpression pexpression2 = Pop<PExpression>();
                        AIndexExpression aindexexpression = new AIndexExpression(
                            pexpression2,
                            pexpression
                        );
                        Push(29, aindexexpression);
                    }
                    break;
                case 120:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        Push(29, pexpression);
                    }
                    break;
                case 121:
                    {
                        TRPar trpar = Pop<TRPar>();
                        PExpression pexpression = Pop<PExpression>();
                        TLPar tlpar = Pop<TLPar>();
                        AParenthesisExpression aparenthesisexpression = new AParenthesisExpression(
                            pexpression
                        );
                        Push(30, aparenthesisexpression);
                    }
                    break;
                case 122:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        Push(30, pexpression);
                    }
                    break;
                case 123:
                    {
                        TNumber tnumber = Pop<TNumber>();
                        ANumberExpression anumberexpression = new ANumberExpression(
                            tnumber
                        );
                        Push(30, anumberexpression);
                    }
                    break;
                case 124:
                    {
                        TBool tbool = Pop<TBool>();
                        ABooleanExpression abooleanexpression = new ABooleanExpression(
                            tbool
                        );
                        Push(30, abooleanexpression);
                    }
                    break;
                case 125:
                    {
                        TNull tnull = Pop<TNull>();
                        ANullExpression anullexpression = new ANullExpression(
                            tnull
                        );
                        Push(30, anullexpression);
                    }
                    break;
                case 126:
                    {
                        TChar tchar = Pop<TChar>();
                        ACharExpression acharexpression = new ACharExpression(
                            tchar
                        );
                        Push(30, acharexpression);
                    }
                    break;
                case 127:
                    {
                        TString tstring = Pop<TString>();
                        AStringExpression astringexpression = new AStringExpression(
                            tstring
                        );
                        Push(30, astringexpression);
                    }
                    break;
                case 128:
                    {
                        TIdentifier tidentifier = Pop<TIdentifier>();
                        AIdentifierExpression aidentifierexpression = new AIdentifierExpression(
                            tidentifier
                        );
                        Push(30, aidentifierexpression);
                    }
                    break;
                case 129:
                    {
                        TIdentifier tidentifier = Pop<TIdentifier>();
                        TTimeCheck ttimecheck = Pop<TTimeCheck>();
                        ATimeCheckExpression atimecheckexpression = new ATimeCheckExpression(
                            ttimecheck,
                            tidentifier
                        );
                        Push(30, atimecheckexpression);
                    }
                    break;
                case 130:
                    {
                        TDeclassifyEnd tdeclassifyend = Pop<TDeclassifyEnd>();
                        PExpression pexpression = Pop<PExpression>();
                        TDeclassifyStart tdeclassifystart = Pop<TDeclassifyStart>();
                        ADeclassifyExpression adeclassifyexpression = new ADeclassifyExpression(
                            pexpression,
                            null
                        );
                        Push(30, adeclassifyexpression);
                    }
                    break;
                case 131:
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
                        Push(30, adeclassifyexpression);
                    }
                    break;
                case 132:
                    {
                        TSemicolon tsemicolon = Pop<TSemicolon>();
                        PExpression pexpression = Pop<PExpression>();
                        AExpressionStatement aexpressionstatement = new AExpressionStatement(
                            pexpression
                        );
                        Push(31, aexpressionstatement);
                    }
                    break;
                case 133:
                case 134:
                case 135:
                case 136:
                case 137:
                case 138:
                case 139:
                case 140:
                    {
                        TRPar trpar = Pop<TRPar>();
                        List<PExpression> pexpressionlist = isOn(4, index - 133) ? Pop<List<PExpression>>() : new List<PExpression>();
                        TLPar tlpar = Pop<TLPar>();
                        List<PPrincipal> pprincipallist = isOn(2, index - 133) ? Pop<List<PPrincipal>>() : new List<PPrincipal>();
                        TIdentifier tidentifier = Pop<TIdentifier>();
                        TTimeCall ttimecall = isOn(1, index - 133) ? Pop<TTimeCall>() : null;
                        List<PPrincipal> pprincipallist2 = new List<PPrincipal>();
                        pprincipallist2.AddRange(pprincipallist);
                        List<PExpression> pexpressionlist2 = new List<PExpression>();
                        pexpressionlist2.AddRange(pexpressionlist);
                        AFunctionCallExpression afunctioncallexpression = new AFunctionCallExpression(
                            ttimecall,
                            tidentifier,
                            pprincipallist2,
                            pexpressionlist2
                        );
                        Push(32, afunctioncallexpression);
                    }
                    break;
                case 141:
                    {
                        TFuncAuthEnd tfuncauthend = Pop<TFuncAuthEnd>();
                        List<PPrincipal> pprincipallist = Pop<List<PPrincipal>>();
                        TFuncAuthStart tfuncauthstart = Pop<TFuncAuthStart>();
                        List<PPrincipal> pprincipallist2 = new List<PPrincipal>();
                        pprincipallist2.AddRange(pprincipallist);
                        Push(33, pprincipallist2);
                    }
                    break;
                case 142:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        List<PExpression> pexpressionlist = new List<PExpression>();
                        pexpressionlist.Add(pexpression);
                        Push(34, pexpressionlist);
                    }
                    break;
                case 143:
                    {
                        List<PExpression> pexpressionlist = Pop<List<PExpression>>();
                        TComma tcomma = Pop<TComma>();
                        PExpression pexpression = Pop<PExpression>();
                        List<PExpression> pexpressionlist2 = new List<PExpression>();
                        pexpressionlist2.Add(pexpression);
                        pexpressionlist2.AddRange(pexpressionlist);
                        Push(34, pexpressionlist2);
                    }
                    break;
                case 144:
                    Push(35, new List<PPreProcessor>() { Pop<PPreProcessor>() });
                    break;
                case 145:
                    {
                        PPreProcessor item = Pop<PPreProcessor>();
                        List<PPreProcessor> list = Pop<List<PPreProcessor>>();
                        list.Add(item);
                        Push(35, list);
                    }
                    break;
                case 146:
                    Push(36, new List<PPrincipalDeclaration>() { Pop<PPrincipalDeclaration>() });
                    break;
                case 147:
                    {
                        PPrincipalDeclaration item = Pop<PPrincipalDeclaration>();
                        List<PPrincipalDeclaration> list = Pop<List<PPrincipalDeclaration>>();
                        list.Add(item);
                        Push(36, list);
                    }
                    break;
                case 148:
                    Push(37, new List<PPrincipalHierarchyDeclaration>() { Pop<PPrincipalHierarchyDeclaration>() });
                    break;
                case 149:
                    {
                        PPrincipalHierarchyDeclaration item = Pop<PPrincipalHierarchyDeclaration>();
                        List<PPrincipalHierarchyDeclaration> list = Pop<List<PPrincipalHierarchyDeclaration>>();
                        list.Add(item);
                        Push(37, list);
                    }
                    break;
                case 150:
                    Push(38, new List<PStruct>() { Pop<PStruct>() });
                    break;
                case 151:
                    {
                        PStruct item = Pop<PStruct>();
                        List<PStruct> list = Pop<List<PStruct>>();
                        list.Add(item);
                        Push(38, list);
                    }
                    break;
                case 152:
                    Push(39, new List<PStatement>() { Pop<PStatement>() });
                    break;
                case 153:
                    {
                        PStatement item = Pop<PStatement>();
                        List<PStatement> list = Pop<List<PStatement>>();
                        list.Add(item);
                        Push(39, list);
                    }
                    break;
                case 154:
                    Push(40, new List<PField>() { Pop<PField>() });
                    break;
                case 155:
                    {
                        PField item = Pop<PField>();
                        List<PField> list = Pop<List<PField>>();
                        list.Add(item);
                        Push(40, list);
                    }
                    break;
                case 156:
                    Push(41, new List<PStatement>() { Pop<PStatement>() });
                    break;
                case 157:
                    {
                        PStatement item = Pop<PStatement>();
                        List<PStatement> list = Pop<List<PStatement>>();
                        list.Add(item);
                        Push(41, list);
                    }
                    break;
                case 158:
                    Push(42, new List<PTimingInterval>() { Pop<PTimingInterval>() });
                    break;
                case 159:
                    {
                        PTimingInterval item = Pop<PTimingInterval>();
                        List<PTimingInterval> list = Pop<List<PTimingInterval>>();
                        list.Add(item);
                        Push(42, list);
                    }
                    break;
            }
        }
        
        #region actionTable
        private static int[][][] actionTable = {
            new int[][] {
                new int[] {-1, 1, 0},
                new int[] {0, 0, 1},
                new int[] {5, 0, 2},
                new int[] {6, 0, 3},
                new int[] {19, 0, 4},
            },
            new int[][] {
                new int[] {-1, 1, 32},
            },
            new int[][] {
                new int[] {-1, 3, 2},
                new int[] {19, 0, 20},
            },
            new int[][] {
                new int[] {-1, 3, 3},
                new int[] {7, 0, 23},
            },
            new int[][] {
                new int[] {-1, 1, 98},
                new int[] {19, 1, 70},
                new int[] {34, 1, 70},
                new int[] {44, 0, 24},
                new int[] {45, 0, 25},
            },
            new int[][] {
                new int[] {-1, 3, 5},
                new int[] {56, 2, -1},
            },
            new int[][] {
                new int[] {-1, 1, 144},
            },
            new int[][] {
                new int[] {-1, 1, 146},
            },
            new int[][] {
                new int[] {-1, 1, 148},
            },
            new int[][] {
                new int[] {-1, 1, 150},
            },
            new int[][] {
                new int[] {-1, 1, 152},
            },
            new int[][] {
                new int[] {-1, 3, 11},
                new int[] {19, 0, 27},
            },
            new int[][] {
                new int[] {-1, 3, 12},
                new int[] {19, 0, 29},
                new int[] {34, 0, 30},
            },
            new int[][] {
                new int[] {-1, 1, 100},
                new int[] {20, 0, 31},
                new int[] {41, 0, 32},
            },
            new int[][] {
                new int[] {-1, 3, 14},
                new int[] {27, 0, 33},
            },
            new int[][] {
                new int[] {-1, 1, 1},
                new int[] {0, 0, 1},
                new int[] {5, 0, 2},
                new int[] {6, 0, 3},
                new int[] {19, 0, 4},
            },
            new int[][] {
                new int[] {-1, 1, 2},
                new int[] {5, 0, 2},
                new int[] {6, 0, 3},
                new int[] {19, 0, 4},
            },
            new int[][] {
                new int[] {-1, 1, 4},
                new int[] {6, 0, 3},
                new int[] {19, 0, 4},
            },
            new int[][] {
                new int[] {-1, 1, 8},
                new int[] {6, 0, 3},
                new int[] {19, 0, 4},
            },
            new int[][] {
                new int[] {-1, 1, 16},
                new int[] {19, 0, 4},
            },
            new int[][] {
                new int[] {-1, 1, 98},
                new int[] {45, 0, 25},
            },
            new int[][] {
                new int[] {-1, 1, 100},
                new int[] {41, 0, 32},
            },
            new int[][] {
                new int[] {-1, 3, 22},
                new int[] {43, 0, 49},
            },
            new int[][] {
                new int[] {-1, 3, 23},
                new int[] {19, 0, 50},
            },
            new int[][] {
                new int[] {-1, 3, 24},
                new int[] {19, 0, 51},
                new int[] {30, 0, 52},
                new int[] {31, 0, 53},
            },
            new int[][] {
                new int[] {-1, 3, 25},
                new int[] {1, 0, 57},
                new int[] {4, 0, 58},
            },
            new int[][] {
                new int[] {-1, 1, 71},
            },
            new int[][] {
                new int[] {-1, 1, 70},
                new int[] {44, 0, 24},
            },
            new int[][] {
                new int[] {-1, 3, 28},
                new int[] {19, 0, 63},
                new int[] {34, 0, 30},
            },
            new int[][] {
                new int[] {-1, 3, 29},
                new int[] {29, 0, 64},
                new int[] {43, 0, 65},
                new int[] {49, 0, 66},
                new int[] {51, 0, 67},
            },
            new int[][] {
                new int[] {-1, 1, 72},
            },
            new int[][] {
                new int[] {-1, 3, 31},
                new int[] {19, 0, 20},
            },
            new int[][] {
                new int[] {-1, 3, 32},
                new int[] {19, 0, 20},
            },
            new int[][] {
                new int[] {-1, 1, 50},
            },
            new int[][] {
                new int[] {-1, 1, 145},
            },
            new int[][] {
                new int[] {-1, 1, 3},
                new int[] {5, 0, 2},
                new int[] {6, 0, 3},
                new int[] {19, 0, 4},
            },
            new int[][] {
                new int[] {-1, 1, 5},
                new int[] {6, 0, 3},
                new int[] {19, 0, 4},
            },
            new int[][] {
                new int[] {-1, 1, 9},
                new int[] {6, 0, 3},
                new int[] {19, 0, 4},
            },
            new int[][] {
                new int[] {-1, 1, 17},
                new int[] {19, 0, 4},
            },
            new int[][] {
                new int[] {-1, 1, 147},
            },
            new int[][] {
                new int[] {-1, 1, 6},
                new int[] {6, 0, 3},
                new int[] {19, 0, 4},
            },
            new int[][] {
                new int[] {-1, 1, 10},
                new int[] {6, 0, 3},
                new int[] {19, 0, 4},
            },
            new int[][] {
                new int[] {-1, 1, 18},
                new int[] {19, 0, 4},
            },
            new int[][] {
                new int[] {-1, 1, 149},
            },
            new int[][] {
                new int[] {-1, 1, 12},
                new int[] {6, 0, 3},
                new int[] {19, 0, 4},
            },
            new int[][] {
                new int[] {-1, 1, 20},
                new int[] {19, 0, 4},
            },
            new int[][] {
                new int[] {-1, 1, 151},
            },
            new int[][] {
                new int[] {-1, 1, 24},
                new int[] {19, 0, 4},
            },
            new int[][] {
                new int[] {-1, 1, 153},
            },
            new int[][] {
                new int[] {-1, 1, 33},
            },
            new int[][] {
                new int[] {-1, 3, 50},
                new int[] {53, 0, 80},
            },
            new int[][] {
                new int[] {-1, 1, 90},
                new int[] {26, 1, 98},
                new int[] {45, 0, 25},
            },
            new int[][] {
                new int[] {-1, 1, 93},
            },
            new int[][] {
                new int[] {-1, 1, 94},
            },
            new int[][] {
                new int[] {-1, 1, 95},
                new int[] {43, 0, 81},
                new int[] {55, 0, 82},
            },
            new int[][] {
                new int[] {-1, 3, 55},
                new int[] {46, 0, 83},
            },
            new int[][] {
                new int[] {-1, 3, 56},
                new int[] {26, 0, 84},
            },
            new int[][] {
                new int[] {-1, 3, 57},
                new int[] {33, 0, 85},
            },
            new int[][] {
                new int[] {-1, 3, 58},
                new int[] {2, 0, 86},
            },
            new int[][] {
                new int[] {-1, 1, 99},
            },
            new int[][] {
                new int[] {-1, 1, 82},
                new int[] {4, 0, 58},
                new int[] {34, 0, 87},
            },
            new int[][] {
                new int[] {-1, 1, 158},
            },
            new int[][] {
                new int[] {-1, 1, 84},
                new int[] {4, 0, 58},
                new int[] {34, 0, 89},
            },
            new int[][] {
                new int[] {-1, 3, 63},
                new int[] {49, 0, 91},
            },
            new int[][] {
                new int[] {-1, 3, 64},
                new int[] {3, 0, 92},
                new int[] {4, 0, 93},
                new int[] {14, 0, 94},
                new int[] {15, 0, 95},
                new int[] {17, 0, 96},
                new int[] {19, 0, 97},
                new int[] {22, 0, 98},
                new int[] {33, 0, 99},
                new int[] {37, 0, 100},
                new int[] {47, 0, 101},
                new int[] {48, 0, 102},
                new int[] {49, 0, 103},
            },
            new int[][] {
                new int[] {-1, 1, 39},
            },
            new int[][] {
                new int[] {-1, 3, 66},
                new int[] {19, 0, 27},
                new int[] {50, 0, 112},
            },
            new int[][] {
                new int[] {-1, 3, 67},
                new int[] {4, 0, 115},
            },
            new int[][] {
                new int[] {-1, 3, 68},
                new int[] {43, 0, 116},
            },
            new int[][] {
                new int[] {-1, 1, 101},
            },
            new int[][] {
                new int[] {-1, 1, 7},
                new int[] {6, 0, 3},
                new int[] {19, 0, 4},
            },
            new int[][] {
                new int[] {-1, 1, 11},
                new int[] {6, 0, 3},
                new int[] {19, 0, 4},
            },
            new int[][] {
                new int[] {-1, 1, 19},
                new int[] {19, 0, 4},
            },
            new int[][] {
                new int[] {-1, 1, 13},
                new int[] {6, 0, 3},
                new int[] {19, 0, 4},
            },
            new int[][] {
                new int[] {-1, 1, 21},
                new int[] {19, 0, 4},
            },
            new int[][] {
                new int[] {-1, 1, 25},
                new int[] {19, 0, 4},
            },
            new int[][] {
                new int[] {-1, 1, 14},
                new int[] {6, 0, 3},
                new int[] {19, 0, 4},
            },
            new int[][] {
                new int[] {-1, 1, 22},
                new int[] {19, 0, 4},
            },
            new int[][] {
                new int[] {-1, 1, 26},
                new int[] {19, 0, 4},
            },
            new int[][] {
                new int[] {-1, 1, 28},
                new int[] {19, 0, 4},
            },
            new int[][] {
                new int[] {-1, 3, 80},
                new int[] {19, 0, 27},
                new int[] {54, 0, 122},
            },
            new int[][] {
                new int[] {-1, 3, 81},
                new int[] {19, 0, 51},
                new int[] {30, 0, 52},
                new int[] {31, 0, 53},
            },
            new int[][] {
                new int[] {-1, 3, 82},
                new int[] {19, 0, 51},
                new int[] {30, 0, 52},
                new int[] {31, 0, 53},
            },
            new int[][] {
                new int[] {-1, 1, 81},
            },
            new int[][] {
                new int[] {-1, 1, 92},
                new int[] {19, 0, 20},
            },
            new int[][] {
                new int[] {-1, 3, 85},
                new int[] {1, 0, 129},
            },
            new int[][] {
                new int[] {-1, 1, 89},
            },
            new int[][] {
                new int[] {-1, 3, 87},
                new int[] {4, 0, 130},
            },
            new int[][] {
                new int[] {-1, 1, 86},
                new int[] {4, 0, 58},
                new int[] {34, 0, 131},
            },
            new int[][] {
                new int[] {-1, 3, 89},
                new int[] {4, 0, 132},
            },
            new int[][] {
                new int[] {-1, 1, 159},
            },
            new int[][] {
                new int[] {-1, 3, 91},
                new int[] {19, 0, 27},
                new int[] {50, 0, 133},
            },
            new int[][] {
                new int[] {-1, 1, 124},
            },
            new int[][] {
                new int[] {-1, 1, 123},
            },
            new int[][] {
                new int[] {-1, 1, 125},
            },
            new int[][] {
                new int[] {-1, 1, 126},
            },
            new int[][] {
                new int[] {-1, 1, 127},
            },
            new int[][] {
                new int[] {-1, 1, 128},
                new int[] {24, 0, 135},
                new int[] {49, 0, 136},
            },
            new int[][] {
                new int[] {-1, 3, 98},
                new int[] {3, 0, 92},
                new int[] {4, 0, 93},
                new int[] {14, 0, 94},
                new int[] {15, 0, 95},
                new int[] {17, 0, 96},
                new int[] {19, 0, 97},
                new int[] {22, 0, 98},
                new int[] {33, 0, 99},
                new int[] {37, 0, 100},
                new int[] {47, 0, 101},
                new int[] {48, 0, 102},
                new int[] {49, 0, 103},
            },
            new int[][] {
                new int[] {-1, 3, 99},
                new int[] {3, 0, 92},
                new int[] {4, 0, 93},
                new int[] {14, 0, 94},
                new int[] {15, 0, 95},
                new int[] {17, 0, 96},
                new int[] {19, 0, 97},
                new int[] {22, 0, 98},
                new int[] {47, 0, 101},
                new int[] {48, 0, 102},
                new int[] {49, 0, 103},
            },
            new int[][] {
                new int[] {-1, 3, 100},
                new int[] {3, 0, 92},
                new int[] {4, 0, 93},
                new int[] {14, 0, 94},
                new int[] {15, 0, 95},
                new int[] {17, 0, 96},
                new int[] {19, 0, 97},
                new int[] {22, 0, 98},
                new int[] {33, 0, 99},
                new int[] {47, 0, 101},
                new int[] {48, 0, 102},
                new int[] {49, 0, 103},
            },
            new int[][] {
                new int[] {-1, 3, 101},
                new int[] {19, 0, 141},
            },
            new int[][] {
                new int[] {-1, 3, 102},
                new int[] {19, 0, 142},
            },
            new int[][] {
                new int[] {-1, 3, 103},
                new int[] {3, 0, 92},
                new int[] {4, 0, 93},
                new int[] {14, 0, 94},
                new int[] {15, 0, 95},
                new int[] {17, 0, 96},
                new int[] {19, 0, 97},
                new int[] {22, 0, 98},
                new int[] {33, 0, 99},
                new int[] {37, 0, 100},
                new int[] {47, 0, 101},
                new int[] {48, 0, 102},
                new int[] {49, 0, 103},
            },
            new int[][] {
                new int[] {-1, 3, 104},
                new int[] {43, 0, 144},
            },
            new int[][] {
                new int[] {-1, 1, 102},
            },
            new int[][] {
                new int[] {-1, 1, 105},
                new int[] {38, 0, 145},
                new int[] {39, 0, 146},
            },
            new int[][] {
                new int[] {-1, 1, 108},
                new int[] {28, 0, 147},
            },
            new int[][] {
                new int[] {-1, 1, 112},
                new int[] {32, 0, 148},
                new int[] {33, 0, 149},
            },
            new int[][] {
                new int[] {-1, 1, 116},
                new int[] {26, 0, 150},
                new int[] {34, 0, 151},
                new int[] {35, 0, 152},
                new int[] {36, 0, 153},
                new int[] {40, 0, 154},
                new int[] {51, 0, 155},
            },
            new int[][] {
                new int[] {-1, 1, 120},
            },
            new int[][] {
                new int[] {-1, 1, 122},
            },
            new int[][] {
                new int[] {-1, 3, 112},
                new int[] {53, 0, 156},
            },
            new int[][] {
                new int[] {-1, 3, 113},
                new int[] {50, 0, 157},
            },
            new int[][] {
                new int[] {-1, 3, 114},
                new int[] {19, 0, 158},
                new int[] {34, 0, 30},
            },
            new int[][] {
                new int[] {-1, 3, 115},
                new int[] {52, 0, 159},
            },
            new int[][] {
                new int[] {-1, 1, 34},
            },
            new int[][] {
                new int[] {-1, 1, 15},
                new int[] {6, 0, 3},
                new int[] {19, 0, 4},
            },
            new int[][] {
                new int[] {-1, 1, 23},
                new int[] {19, 0, 4},
            },
            new int[][] {
                new int[] {-1, 1, 27},
                new int[] {19, 0, 4},
            },
            new int[][] {
                new int[] {-1, 1, 29},
                new int[] {19, 0, 4},
            },
            new int[][] {
                new int[] {-1, 1, 30},
                new int[] {19, 0, 4},
            },
            new int[][] {
                new int[] {-1, 3, 122},
                new int[] {19, 0, 161},
            },
            new int[][] {
                new int[] {-1, 1, 154},
            },
            new int[][] {
                new int[] {-1, 3, 124},
                new int[] {19, 0, 162},
                new int[] {34, 0, 30},
            },
            new int[][] {
                new int[] {-1, 3, 125},
                new int[] {19, 0, 27},
                new int[] {54, 0, 163},
            },
            new int[][] {
                new int[] {-1, 1, 96},
            },
            new int[][] {
                new int[] {-1, 1, 97},
            },
            new int[][] {
                new int[] {-1, 1, 91},
            },
            new int[][] {
                new int[] {-1, 1, 88},
            },
            new int[][] {
                new int[] {-1, 1, 83},
            },
            new int[][] {
                new int[] {-1, 3, 131},
                new int[] {4, 0, 165},
            },
            new int[][] {
                new int[] {-1, 1, 85},
            },
            new int[][] {
                new int[] {-1, 3, 133},
                new int[] {53, 0, 166},
            },
            new int[][] {
                new int[] {-1, 3, 134},
                new int[] {50, 0, 167},
            },
            new int[][] {
                new int[] {-1, 3, 135},
                new int[] {19, 0, 20},
            },
            new int[][] {
                new int[] {-1, 3, 136},
                new int[] {3, 0, 92},
                new int[] {4, 0, 93},
                new int[] {14, 0, 94},
                new int[] {15, 0, 95},
                new int[] {17, 0, 96},
                new int[] {19, 0, 97},
                new int[] {22, 0, 98},
                new int[] {33, 0, 99},
                new int[] {37, 0, 100},
                new int[] {47, 0, 101},
                new int[] {48, 0, 102},
                new int[] {49, 0, 103},
                new int[] {50, 0, 169},
            },
            new int[][] {
                new int[] {-1, 3, 137},
                new int[] {49, 0, 172},
            },
            new int[][] {
                new int[] {-1, 3, 138},
                new int[] {23, 0, 173},
                new int[] {41, 0, 174},
            },
            new int[][] {
                new int[] {-1, 1, 111},
            },
            new int[][] {
                new int[] {-1, 1, 107},
            },
            new int[][] {
                new int[] {-1, 3, 141},
                new int[] {24, 0, 135},
                new int[] {49, 0, 175},
            },
            new int[][] {
                new int[] {-1, 1, 129},
            },
            new int[][] {
                new int[] {-1, 3, 143},
                new int[] {50, 0, 177},
            },
            new int[][] {
                new int[] {-1, 1, 40},
            },
            new int[][] {
                new int[] {-1, 3, 145},
                new int[] {3, 0, 92},
                new int[] {4, 0, 93},
                new int[] {14, 0, 94},
                new int[] {15, 0, 95},
                new int[] {17, 0, 96},
                new int[] {19, 0, 97},
                new int[] {22, 0, 98},
                new int[] {33, 0, 99},
                new int[] {37, 0, 100},
                new int[] {47, 0, 101},
                new int[] {48, 0, 102},
                new int[] {49, 0, 103},
            },
            new int[][] {
                new int[] {-1, 3, 146},
                new int[] {3, 0, 92},
                new int[] {4, 0, 93},
                new int[] {14, 0, 94},
                new int[] {15, 0, 95},
                new int[] {17, 0, 96},
                new int[] {19, 0, 97},
                new int[] {22, 0, 98},
                new int[] {33, 0, 99},
                new int[] {37, 0, 100},
                new int[] {47, 0, 101},
                new int[] {48, 0, 102},
                new int[] {49, 0, 103},
            },
            new int[][] {
                new int[] {-1, 3, 147},
                new int[] {3, 0, 92},
                new int[] {4, 0, 93},
                new int[] {14, 0, 94},
                new int[] {15, 0, 95},
                new int[] {17, 0, 96},
                new int[] {19, 0, 97},
                new int[] {22, 0, 98},
                new int[] {33, 0, 99},
                new int[] {37, 0, 100},
                new int[] {47, 0, 101},
                new int[] {48, 0, 102},
                new int[] {49, 0, 103},
            },
            new int[][] {
                new int[] {-1, 3, 148},
                new int[] {3, 0, 92},
                new int[] {4, 0, 93},
                new int[] {14, 0, 94},
                new int[] {15, 0, 95},
                new int[] {17, 0, 96},
                new int[] {19, 0, 97},
                new int[] {22, 0, 98},
                new int[] {33, 0, 99},
                new int[] {47, 0, 101},
                new int[] {48, 0, 102},
                new int[] {49, 0, 103},
            },
            new int[][] {
                new int[] {-1, 3, 149},
                new int[] {3, 0, 92},
                new int[] {4, 0, 93},
                new int[] {14, 0, 94},
                new int[] {15, 0, 95},
                new int[] {17, 0, 96},
                new int[] {19, 0, 97},
                new int[] {22, 0, 98},
                new int[] {33, 0, 99},
                new int[] {47, 0, 101},
                new int[] {48, 0, 102},
                new int[] {49, 0, 103},
            },
            new int[][] {
                new int[] {-1, 3, 150},
                new int[] {19, 0, 183},
            },
            new int[][] {
                new int[] {-1, 3, 151},
                new int[] {3, 0, 92},
                new int[] {4, 0, 93},
                new int[] {14, 0, 94},
                new int[] {15, 0, 95},
                new int[] {17, 0, 96},
                new int[] {19, 0, 97},
                new int[] {22, 0, 98},
                new int[] {47, 0, 101},
                new int[] {48, 0, 102},
                new int[] {49, 0, 103},
            },
            new int[][] {
                new int[] {-1, 3, 152},
                new int[] {3, 0, 92},
                new int[] {4, 0, 93},
                new int[] {14, 0, 94},
                new int[] {15, 0, 95},
                new int[] {17, 0, 96},
                new int[] {19, 0, 97},
                new int[] {22, 0, 98},
                new int[] {47, 0, 101},
                new int[] {48, 0, 102},
                new int[] {49, 0, 103},
            },
            new int[][] {
                new int[] {-1, 3, 153},
                new int[] {3, 0, 92},
                new int[] {4, 0, 93},
                new int[] {14, 0, 94},
                new int[] {15, 0, 95},
                new int[] {17, 0, 96},
                new int[] {19, 0, 97},
                new int[] {22, 0, 98},
                new int[] {47, 0, 101},
                new int[] {48, 0, 102},
                new int[] {49, 0, 103},
            },
            new int[][] {
                new int[] {-1, 3, 154},
                new int[] {19, 0, 187},
            },
            new int[][] {
                new int[] {-1, 3, 155},
                new int[] {3, 0, 92},
                new int[] {4, 0, 93},
                new int[] {14, 0, 94},
                new int[] {15, 0, 95},
                new int[] {17, 0, 96},
                new int[] {19, 0, 97},
                new int[] {22, 0, 98},
                new int[] {33, 0, 99},
                new int[] {37, 0, 100},
                new int[] {47, 0, 101},
                new int[] {48, 0, 102},
                new int[] {49, 0, 103},
            },
            new int[][] {
                new int[] {-1, 3, 156},
                new int[] {8, 0, 189},
                new int[] {9, 0, 190},
                new int[] {11, 0, 191},
                new int[] {12, 0, 192},
                new int[] {13, 0, 193},
                new int[] {19, 0, 194},
                new int[] {47, 0, 101},
                new int[] {54, 0, 195},
            },
            new int[][] {
                new int[] {-1, 3, 157},
                new int[] {53, 0, 203},
            },
            new int[][] {
                new int[] {-1, 1, 51},
                new int[] {41, 0, 204},
            },
            new int[][] {
                new int[] {-1, 3, 159},
                new int[] {43, 0, 205},
            },
            new int[][] {
                new int[] {-1, 1, 31},
                new int[] {19, 0, 4},
            },
            new int[][] {
                new int[] {-1, 3, 161},
                new int[] {43, 0, 206},
            },
            new int[][] {
                new int[] {-1, 3, 162},
                new int[] {43, 0, 207},
                new int[] {51, 0, 208},
            },
            new int[][] {
                new int[] {-1, 3, 163},
                new int[] {19, 0, 209},
            },
            new int[][] {
                new int[] {-1, 1, 155},
            },
            new int[][] {
                new int[] {-1, 1, 87},
            },
            new int[][] {
                new int[] {-1, 3, 166},
                new int[] {8, 0, 189},
                new int[] {9, 0, 190},
                new int[] {11, 0, 191},
                new int[] {12, 0, 192},
                new int[] {13, 0, 193},
                new int[] {19, 0, 194},
                new int[] {47, 0, 101},
                new int[] {54, 0, 210},
            },
            new int[][] {
                new int[] {-1, 3, 167},
                new int[] {53, 0, 212},
            },
            new int[][] {
                new int[] {-1, 3, 168},
                new int[] {25, 0, 213},
            },
            new int[][] {
                new int[] {-1, 1, 133},
            },
            new int[][] {
                new int[] {-1, 1, 142},
                new int[] {41, 0, 214},
            },
            new int[][] {
                new int[] {-1, 3, 171},
                new int[] {50, 0, 215},
            },
            new int[][] {
                new int[] {-1, 3, 172},
                new int[] {3, 0, 92},
                new int[] {4, 0, 93},
                new int[] {14, 0, 94},
                new int[] {15, 0, 95},
                new int[] {17, 0, 96},
                new int[] {19, 0, 97},
                new int[] {22, 0, 98},
                new int[] {33, 0, 99},
                new int[] {37, 0, 100},
                new int[] {47, 0, 101},
                new int[] {48, 0, 102},
                new int[] {49, 0, 103},
                new int[] {50, 0, 216},
            },
            new int[][] {
                new int[] {-1, 1, 130},
            },
            new int[][] {
                new int[] {-1, 3, 174},
                new int[] {44, 0, 24},
            },
            new int[][] {
                new int[] {-1, 3, 175},
                new int[] {3, 0, 92},
                new int[] {4, 0, 93},
                new int[] {14, 0, 94},
                new int[] {15, 0, 95},
                new int[] {17, 0, 96},
                new int[] {19, 0, 97},
                new int[] {22, 0, 98},
                new int[] {33, 0, 99},
                new int[] {37, 0, 100},
                new int[] {47, 0, 101},
                new int[] {48, 0, 102},
                new int[] {49, 0, 103},
                new int[] {50, 0, 219},
            },
            new int[][] {
                new int[] {-1, 3, 176},
                new int[] {49, 0, 221},
            },
            new int[][] {
                new int[] {-1, 1, 121},
            },
            new int[][] {
                new int[] {-1, 1, 103},
            },
            new int[][] {
                new int[] {-1, 1, 104},
            },
            new int[][] {
                new int[] {-1, 1, 106},
            },
            new int[][] {
                new int[] {-1, 1, 109},
            },
            new int[][] {
                new int[] {-1, 1, 110},
            },
            new int[][] {
                new int[] {-1, 1, 118},
            },
            new int[][] {
                new int[] {-1, 1, 113},
            },
            new int[][] {
                new int[] {-1, 1, 114},
            },
            new int[][] {
                new int[] {-1, 1, 115},
            },
            new int[][] {
                new int[] {-1, 1, 117},
            },
            new int[][] {
                new int[] {-1, 3, 188},
                new int[] {52, 0, 222},
            },
            new int[][] {
                new int[] {-1, 3, 189},
                new int[] {49, 0, 223},
            },
            new int[][] {
                new int[] {-1, 3, 190},
                new int[] {49, 0, 224},
            },
            new int[][] {
                new int[] {-1, 3, 191},
                new int[] {3, 0, 92},
                new int[] {4, 0, 93},
                new int[] {14, 0, 94},
                new int[] {15, 0, 95},
                new int[] {17, 0, 96},
                new int[] {19, 0, 97},
                new int[] {22, 0, 98},
                new int[] {33, 0, 99},
                new int[] {37, 0, 100},
                new int[] {43, 0, 225},
                new int[] {47, 0, 101},
                new int[] {48, 0, 102},
                new int[] {49, 0, 103},
            },
            new int[][] {
                new int[] {-1, 1, 79},
            },
            new int[][] {
                new int[] {-1, 1, 80},
            },
            new int[][] {
                new int[] {-1, 1, 70},
                new int[] {24, 0, 135},
                new int[] {29, 0, 227},
                new int[] {44, 0, 24},
                new int[] {49, 0, 136},
            },
            new int[][] {
                new int[] {-1, 1, 42},
            },
            new int[][] {
                new int[] {-1, 1, 156},
            },
            new int[][] {
                new int[] {-1, 1, 58},
            },
            new int[][] {
                new int[] {-1, 3, 198},
                new int[] {19, 0, 228},
                new int[] {34, 0, 30},
            },
            new int[][] {
                new int[] {-1, 3, 199},
                new int[] {21, 0, 229},
            },
            new int[][] {
                new int[] {-1, 1, 69},
            },
            new int[][] {
                new int[] {-1, 3, 201},
                new int[] {43, 0, 230},
            },
            new int[][] {
                new int[] {-1, 3, 202},
                new int[] {8, 0, 189},
                new int[] {9, 0, 190},
                new int[] {11, 0, 191},
                new int[] {12, 0, 192},
                new int[] {13, 0, 193},
                new int[] {19, 0, 194},
                new int[] {47, 0, 101},
                new int[] {54, 0, 231},
            },
            new int[][] {
                new int[] {-1, 3, 203},
                new int[] {8, 0, 189},
                new int[] {9, 0, 190},
                new int[] {11, 0, 191},
                new int[] {12, 0, 192},
                new int[] {13, 0, 193},
                new int[] {19, 0, 194},
                new int[] {47, 0, 101},
                new int[] {54, 0, 233},
            },
            new int[][] {
                new int[] {-1, 3, 204},
                new int[] {19, 0, 27},
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
                new int[] {-1, 3, 208},
                new int[] {4, 0, 236},
            },
            new int[][] {
                new int[] {-1, 3, 209},
                new int[] {43, 0, 237},
            },
            new int[][] {
                new int[] {-1, 1, 43},
            },
            new int[][] {
                new int[] {-1, 3, 211},
                new int[] {8, 0, 189},
                new int[] {9, 0, 190},
                new int[] {11, 0, 191},
                new int[] {12, 0, 192},
                new int[] {13, 0, 193},
                new int[] {19, 0, 194},
                new int[] {47, 0, 101},
                new int[] {54, 0, 238},
            },
            new int[][] {
                new int[] {-1, 3, 212},
                new int[] {8, 0, 189},
                new int[] {9, 0, 190},
                new int[] {11, 0, 191},
                new int[] {12, 0, 192},
                new int[] {13, 0, 193},
                new int[] {19, 0, 194},
                new int[] {47, 0, 101},
                new int[] {54, 0, 239},
            },
            new int[][] {
                new int[] {-1, 1, 141},
            },
            new int[][] {
                new int[] {-1, 3, 214},
                new int[] {3, 0, 92},
                new int[] {4, 0, 93},
                new int[] {14, 0, 94},
                new int[] {15, 0, 95},
                new int[] {17, 0, 96},
                new int[] {19, 0, 97},
                new int[] {22, 0, 98},
                new int[] {33, 0, 99},
                new int[] {37, 0, 100},
                new int[] {47, 0, 101},
                new int[] {48, 0, 102},
                new int[] {49, 0, 103},
            },
            new int[][] {
                new int[] {-1, 1, 137},
            },
            new int[][] {
                new int[] {-1, 1, 135},
            },
            new int[][] {
                new int[] {-1, 3, 217},
                new int[] {50, 0, 242},
            },
            new int[][] {
                new int[] {-1, 3, 218},
                new int[] {23, 0, 243},
            },
            new int[][] {
                new int[] {-1, 1, 134},
            },
            new int[][] {
                new int[] {-1, 3, 220},
                new int[] {50, 0, 244},
            },
            new int[][] {
                new int[] {-1, 3, 221},
                new int[] {3, 0, 92},
                new int[] {4, 0, 93},
                new int[] {14, 0, 94},
                new int[] {15, 0, 95},
                new int[] {17, 0, 96},
                new int[] {19, 0, 97},
                new int[] {22, 0, 98},
                new int[] {33, 0, 99},
                new int[] {37, 0, 100},
                new int[] {47, 0, 101},
                new int[] {48, 0, 102},
                new int[] {49, 0, 103},
                new int[] {50, 0, 245},
            },
            new int[][] {
                new int[] {-1, 1, 119},
            },
            new int[][] {
                new int[] {-1, 3, 223},
                new int[] {3, 0, 92},
                new int[] {4, 0, 93},
                new int[] {14, 0, 94},
                new int[] {15, 0, 95},
                new int[] {17, 0, 96},
                new int[] {19, 0, 97},
                new int[] {22, 0, 98},
                new int[] {33, 0, 99},
                new int[] {37, 0, 100},
                new int[] {47, 0, 101},
                new int[] {48, 0, 102},
                new int[] {49, 0, 103},
            },
            new int[][] {
                new int[] {-1, 3, 224},
                new int[] {3, 0, 92},
                new int[] {4, 0, 93},
                new int[] {14, 0, 94},
                new int[] {15, 0, 95},
                new int[] {17, 0, 96},
                new int[] {19, 0, 97},
                new int[] {22, 0, 98},
                new int[] {33, 0, 99},
                new int[] {37, 0, 100},
                new int[] {47, 0, 101},
                new int[] {48, 0, 102},
                new int[] {49, 0, 103},
            },
            new int[][] {
                new int[] {-1, 1, 67},
            },
            new int[][] {
                new int[] {-1, 3, 226},
                new int[] {43, 0, 249},
            },
            new int[][] {
                new int[] {-1, 3, 227},
                new int[] {3, 0, 92},
                new int[] {4, 0, 93},
                new int[] {14, 0, 94},
                new int[] {15, 0, 95},
                new int[] {17, 0, 96},
                new int[] {19, 0, 97},
                new int[] {22, 0, 98},
                new int[] {33, 0, 99},
                new int[] {37, 0, 100},
                new int[] {47, 0, 101},
                new int[] {48, 0, 102},
                new int[] {49, 0, 103},
            },
            new int[][] {
                new int[] {-1, 3, 228},
                new int[] {29, 0, 251},
                new int[] {43, 0, 252},
                new int[] {51, 0, 253},
            },
            new int[][] {
                new int[] {-1, 3, 229},
                new int[] {19, 0, 20},
            },
            new int[][] {
                new int[] {-1, 1, 132},
            },
            new int[][] {
                new int[] {-1, 1, 46},
            },
            new int[][] {
                new int[] {-1, 1, 157},
            },
            new int[][] {
                new int[] {-1, 1, 44},
            },
            new int[][] {
                new int[] {-1, 3, 234},
                new int[] {8, 0, 189},
                new int[] {9, 0, 190},
                new int[] {11, 0, 191},
                new int[] {12, 0, 192},
                new int[] {13, 0, 193},
                new int[] {19, 0, 194},
                new int[] {47, 0, 101},
                new int[] {54, 0, 255},
            },
            new int[][] {
                new int[] {-1, 1, 52},
            },
            new int[][] {
                new int[] {-1, 3, 236},
                new int[] {52, 0, 256},
            },
            new int[][] {
                new int[] {-1, 1, 36},
            },
            new int[][] {
                new int[] {-1, 1, 47},
            },
            new int[][] {
                new int[] {-1, 1, 45},
            },
            new int[][] {
                new int[] {-1, 3, 240},
                new int[] {8, 0, 189},
                new int[] {9, 0, 190},
                new int[] {11, 0, 191},
                new int[] {12, 0, 192},
                new int[] {13, 0, 193},
                new int[] {19, 0, 194},
                new int[] {47, 0, 101},
                new int[] {54, 0, 257},
            },
            new int[][] {
                new int[] {-1, 1, 143},
            },
            new int[][] {
                new int[] {-1, 1, 139},
            },
            new int[][] {
                new int[] {-1, 1, 131},
            },
            new int[][] {
                new int[] {-1, 1, 138},
            },
            new int[][] {
                new int[] {-1, 1, 136},
            },
            new int[][] {
                new int[] {-1, 3, 246},
                new int[] {50, 0, 258},
            },
            new int[][] {
                new int[] {-1, 3, 247},
                new int[] {50, 0, 259},
            },
            new int[][] {
                new int[] {-1, 3, 248},
                new int[] {50, 0, 260},
            },
            new int[][] {
                new int[] {-1, 1, 68},
            },
            new int[][] {
                new int[] {-1, 3, 250},
                new int[] {43, 0, 261},
            },
            new int[][] {
                new int[] {-1, 3, 251},
                new int[] {3, 0, 92},
                new int[] {4, 0, 93},
                new int[] {14, 0, 94},
                new int[] {15, 0, 95},
                new int[] {17, 0, 96},
                new int[] {19, 0, 97},
                new int[] {22, 0, 98},
                new int[] {33, 0, 99},
                new int[] {37, 0, 100},
                new int[] {47, 0, 101},
                new int[] {48, 0, 102},
                new int[] {49, 0, 103},
            },
            new int[][] {
                new int[] {-1, 1, 63},
            },
            new int[][] {
                new int[] {-1, 3, 253},
                new int[] {4, 0, 263},
            },
            new int[][] {
                new int[] {-1, 3, 254},
                new int[] {8, 0, 264},
                new int[] {9, 0, 265},
                new int[] {11, 0, 191},
                new int[] {12, 0, 192},
                new int[] {13, 0, 193},
                new int[] {19, 0, 194},
                new int[] {47, 0, 101},
                new int[] {53, 0, 266},
            },
            new int[][] {
                new int[] {-1, 1, 48},
            },
            new int[][] {
                new int[] {-1, 3, 256},
                new int[] {43, 0, 273},
            },
            new int[][] {
                new int[] {-1, 1, 49},
            },
            new int[][] {
                new int[] {-1, 1, 140},
            },
            new int[][] {
                new int[] {-1, 3, 259},
                new int[] {8, 0, 189},
                new int[] {9, 0, 190},
                new int[] {11, 0, 191},
                new int[] {12, 0, 192},
                new int[] {13, 0, 193},
                new int[] {19, 0, 194},
                new int[] {47, 0, 101},
                new int[] {53, 0, 274},
            },
            new int[][] {
                new int[] {-1, 3, 260},
                new int[] {8, 0, 264},
                new int[] {9, 0, 265},
                new int[] {11, 0, 191},
                new int[] {12, 0, 192},
                new int[] {13, 0, 193},
                new int[] {19, 0, 194},
                new int[] {47, 0, 101},
                new int[] {53, 0, 266},
            },
            new int[][] {
                new int[] {-1, 1, 66},
            },
            new int[][] {
                new int[] {-1, 3, 262},
                new int[] {43, 0, 278},
            },
            new int[][] {
                new int[] {-1, 3, 263},
                new int[] {52, 0, 279},
            },
            new int[][] {
                new int[] {-1, 3, 264},
                new int[] {49, 0, 280},
            },
            new int[][] {
                new int[] {-1, 3, 265},
                new int[] {49, 0, 281},
            },
            new int[][] {
                new int[] {-1, 3, 266},
                new int[] {8, 0, 189},
                new int[] {9, 0, 190},
                new int[] {11, 0, 191},
                new int[] {12, 0, 192},
                new int[] {13, 0, 193},
                new int[] {19, 0, 194},
                new int[] {47, 0, 101},
                new int[] {54, 0, 282},
            },
            new int[][] {
                new int[] {-1, 1, 73},
            },
            new int[][] {
                new int[] {-1, 1, 76},
            },
            new int[][] {
                new int[] {-1, 1, 58},
                new int[] {10, 1, 62},
            },
            new int[][] {
                new int[] {-1, 1, 56},
            },
            new int[][] {
                new int[] {-1, 3, 271},
                new int[] {10, 0, 284},
            },
            new int[][] {
                new int[] {-1, 3, 272},
                new int[] {21, 0, 285},
            },
            new int[][] {
                new int[] {-1, 1, 38},
            },
            new int[][] {
                new int[] {-1, 3, 274},
                new int[] {8, 0, 189},
                new int[] {9, 0, 190},
                new int[] {11, 0, 191},
                new int[] {12, 0, 192},
                new int[] {13, 0, 193},
                new int[] {19, 0, 194},
                new int[] {47, 0, 101},
                new int[] {54, 0, 286},
            },
            new int[][] {
                new int[] {-1, 1, 55},
            },
            new int[][] {
                new int[] {-1, 1, 53},
            },
            new int[][] {
                new int[] {-1, 3, 277},
                new int[] {10, 0, 288},
            },
            new int[][] {
                new int[] {-1, 1, 64},
            },
            new int[][] {
                new int[] {-1, 1, 65},
            },
            new int[][] {
                new int[] {-1, 3, 280},
                new int[] {3, 0, 92},
                new int[] {4, 0, 93},
                new int[] {14, 0, 94},
                new int[] {15, 0, 95},
                new int[] {17, 0, 96},
                new int[] {19, 0, 97},
                new int[] {22, 0, 98},
                new int[] {33, 0, 99},
                new int[] {37, 0, 100},
                new int[] {47, 0, 101},
                new int[] {48, 0, 102},
                new int[] {49, 0, 103},
            },
            new int[][] {
                new int[] {-1, 3, 281},
                new int[] {3, 0, 92},
                new int[] {4, 0, 93},
                new int[] {14, 0, 94},
                new int[] {15, 0, 95},
                new int[] {17, 0, 96},
                new int[] {19, 0, 97},
                new int[] {22, 0, 98},
                new int[] {33, 0, 99},
                new int[] {37, 0, 100},
                new int[] {47, 0, 101},
                new int[] {48, 0, 102},
                new int[] {49, 0, 103},
            },
            new int[][] {
                new int[] {-1, 1, 74},
                new int[] {10, 1, 77},
            },
            new int[][] {
                new int[] {-1, 3, 283},
                new int[] {8, 0, 189},
                new int[] {9, 0, 190},
                new int[] {11, 0, 191},
                new int[] {12, 0, 192},
                new int[] {13, 0, 193},
                new int[] {19, 0, 194},
                new int[] {47, 0, 101},
                new int[] {54, 0, 291},
            },
            new int[][] {
                new int[] {-1, 3, 284},
                new int[] {8, 0, 292},
                new int[] {9, 0, 293},
                new int[] {11, 0, 191},
                new int[] {12, 0, 192},
                new int[] {13, 0, 193},
                new int[] {19, 0, 194},
                new int[] {47, 0, 101},
                new int[] {53, 0, 294},
            },
            new int[][] {
                new int[] {-1, 3, 285},
                new int[] {19, 0, 20},
            },
            new int[][] {
                new int[] {-1, 1, 74},
            },
            new int[][] {
                new int[] {-1, 3, 287},
                new int[] {8, 0, 189},
                new int[] {9, 0, 190},
                new int[] {11, 0, 191},
                new int[] {12, 0, 192},
                new int[] {13, 0, 193},
                new int[] {19, 0, 194},
                new int[] {47, 0, 101},
                new int[] {54, 0, 299},
            },
            new int[][] {
                new int[] {-1, 3, 288},
                new int[] {8, 0, 292},
                new int[] {9, 0, 293},
                new int[] {11, 0, 191},
                new int[] {12, 0, 192},
                new int[] {13, 0, 193},
                new int[] {19, 0, 194},
                new int[] {47, 0, 101},
                new int[] {53, 0, 294},
            },
            new int[][] {
                new int[] {-1, 3, 289},
                new int[] {50, 0, 301},
            },
            new int[][] {
                new int[] {-1, 3, 290},
                new int[] {50, 0, 302},
            },
            new int[][] {
                new int[] {-1, 1, 75},
                new int[] {10, 1, 78},
            },
            new int[][] {
                new int[] {-1, 3, 292},
                new int[] {49, 0, 303},
            },
            new int[][] {
                new int[] {-1, 3, 293},
                new int[] {49, 0, 304},
            },
            new int[][] {
                new int[] {-1, 3, 294},
                new int[] {8, 0, 189},
                new int[] {9, 0, 190},
                new int[] {11, 0, 191},
                new int[] {12, 0, 192},
                new int[] {13, 0, 193},
                new int[] {19, 0, 194},
                new int[] {47, 0, 101},
                new int[] {54, 0, 305},
            },
            new int[][] {
                new int[] {-1, 1, 62},
            },
            new int[][] {
                new int[] {-1, 1, 57},
            },
            new int[][] {
                new int[] {-1, 3, 297},
                new int[] {21, 0, 307},
            },
            new int[][] {
                new int[] {-1, 3, 298},
                new int[] {8, 0, 264},
                new int[] {9, 0, 265},
                new int[] {11, 0, 191},
                new int[] {12, 0, 192},
                new int[] {13, 0, 193},
                new int[] {19, 0, 194},
                new int[] {47, 0, 101},
                new int[] {53, 0, 266},
            },
            new int[][] {
                new int[] {-1, 1, 75},
            },
            new int[][] {
                new int[] {-1, 1, 54},
            },
            new int[][] {
                new int[] {-1, 3, 301},
                new int[] {8, 0, 264},
                new int[] {9, 0, 265},
                new int[] {11, 0, 191},
                new int[] {12, 0, 192},
                new int[] {13, 0, 193},
                new int[] {19, 0, 194},
                new int[] {47, 0, 101},
                new int[] {53, 0, 266},
            },
            new int[][] {
                new int[] {-1, 3, 302},
                new int[] {8, 0, 264},
                new int[] {9, 0, 265},
                new int[] {11, 0, 191},
                new int[] {12, 0, 192},
                new int[] {13, 0, 193},
                new int[] {19, 0, 194},
                new int[] {47, 0, 101},
                new int[] {53, 0, 266},
            },
            new int[][] {
                new int[] {-1, 3, 303},
                new int[] {3, 0, 92},
                new int[] {4, 0, 93},
                new int[] {14, 0, 94},
                new int[] {15, 0, 95},
                new int[] {17, 0, 96},
                new int[] {19, 0, 97},
                new int[] {22, 0, 98},
                new int[] {33, 0, 99},
                new int[] {37, 0, 100},
                new int[] {47, 0, 101},
                new int[] {48, 0, 102},
                new int[] {49, 0, 103},
            },
            new int[][] {
                new int[] {-1, 3, 304},
                new int[] {3, 0, 92},
                new int[] {4, 0, 93},
                new int[] {14, 0, 94},
                new int[] {15, 0, 95},
                new int[] {17, 0, 96},
                new int[] {19, 0, 97},
                new int[] {22, 0, 98},
                new int[] {33, 0, 99},
                new int[] {37, 0, 100},
                new int[] {47, 0, 101},
                new int[] {48, 0, 102},
                new int[] {49, 0, 103},
            },
            new int[][] {
                new int[] {-1, 1, 77},
            },
            new int[][] {
                new int[] {-1, 3, 306},
                new int[] {8, 0, 189},
                new int[] {9, 0, 190},
                new int[] {11, 0, 191},
                new int[] {12, 0, 192},
                new int[] {13, 0, 193},
                new int[] {19, 0, 194},
                new int[] {47, 0, 101},
                new int[] {54, 0, 313},
            },
            new int[][] {
                new int[] {-1, 3, 307},
                new int[] {19, 0, 20},
            },
            new int[][] {
                new int[] {-1, 3, 308},
                new int[] {10, 0, 315},
            },
            new int[][] {
                new int[] {-1, 1, 60},
            },
            new int[][] {
                new int[] {-1, 3, 310},
                new int[] {10, 0, 316},
            },
            new int[][] {
                new int[] {-1, 3, 311},
                new int[] {50, 0, 317},
            },
            new int[][] {
                new int[] {-1, 3, 312},
                new int[] {50, 0, 318},
            },
            new int[][] {
                new int[] {-1, 1, 78},
            },
            new int[][] {
                new int[] {-1, 3, 314},
                new int[] {8, 0, 292},
                new int[] {9, 0, 293},
                new int[] {11, 0, 191},
                new int[] {12, 0, 192},
                new int[] {13, 0, 193},
                new int[] {19, 0, 194},
                new int[] {47, 0, 101},
                new int[] {53, 0, 294},
            },
            new int[][] {
                new int[] {-1, 3, 315},
                new int[] {8, 0, 292},
                new int[] {9, 0, 293},
                new int[] {11, 0, 191},
                new int[] {12, 0, 192},
                new int[] {13, 0, 193},
                new int[] {19, 0, 194},
                new int[] {47, 0, 101},
                new int[] {53, 0, 294},
            },
            new int[][] {
                new int[] {-1, 3, 316},
                new int[] {8, 0, 292},
                new int[] {9, 0, 293},
                new int[] {11, 0, 191},
                new int[] {12, 0, 192},
                new int[] {13, 0, 193},
                new int[] {19, 0, 194},
                new int[] {47, 0, 101},
                new int[] {53, 0, 294},
            },
            new int[][] {
                new int[] {-1, 3, 317},
                new int[] {8, 0, 292},
                new int[] {9, 0, 293},
                new int[] {11, 0, 191},
                new int[] {12, 0, 192},
                new int[] {13, 0, 193},
                new int[] {19, 0, 194},
                new int[] {47, 0, 101},
                new int[] {53, 0, 294},
            },
            new int[][] {
                new int[] {-1, 3, 318},
                new int[] {8, 0, 292},
                new int[] {9, 0, 293},
                new int[] {11, 0, 191},
                new int[] {12, 0, 192},
                new int[] {13, 0, 193},
                new int[] {19, 0, 194},
                new int[] {47, 0, 101},
                new int[] {53, 0, 294},
            },
            new int[][] {
                new int[] {-1, 3, 319},
                new int[] {10, 0, 323},
            },
            new int[][] {
                new int[] {-1, 1, 57},
                new int[] {10, 1, 61},
            },
            new int[][] {
                new int[] {-1, 1, 54},
                new int[] {10, 1, 59},
            },
            new int[][] {
                new int[] {-1, 3, 322},
                new int[] {10, 0, 324},
            },
            new int[][] {
                new int[] {-1, 3, 323},
                new int[] {8, 0, 292},
                new int[] {9, 0, 293},
                new int[] {11, 0, 191},
                new int[] {12, 0, 192},
                new int[] {13, 0, 193},
                new int[] {19, 0, 194},
                new int[] {47, 0, 101},
                new int[] {53, 0, 294},
            },
            new int[][] {
                new int[] {-1, 3, 324},
                new int[] {8, 0, 292},
                new int[] {9, 0, 293},
                new int[] {11, 0, 191},
                new int[] {12, 0, 192},
                new int[] {13, 0, 193},
                new int[] {19, 0, 194},
                new int[] {47, 0, 101},
                new int[] {53, 0, 294},
            },
            new int[][] {
                new int[] {-1, 1, 61},
            },
            new int[][] {
                new int[] {-1, 1, 59},
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
                new int[] {15, 34},
            },
            new int[][] {
                new int[] {-1, 7},
                new int[] {16, 39},
                new int[] {35, 39},
            },
            new int[][] {
                new int[] {-1, 8},
                new int[] {17, 43},
                new int[] {36, 43},
                new int[] {40, 43},
                new int[] {70, 43},
            },
            new int[][] {
                new int[] {-1, 9},
                new int[] {18, 46},
                new int[] {37, 46},
                new int[] {41, 46},
                new int[] {44, 46},
                new int[] {71, 46},
                new int[] {73, 46},
                new int[] {76, 46},
                new int[] {117, 46},
            },
            new int[][] {
                new int[] {-1, 123},
                new int[] {125, 164},
            },
            new int[][] {
                new int[] {-1, 10},
                new int[] {19, 48},
                new int[] {38, 48},
                new int[] {42, 48},
                new int[] {45, 48},
                new int[] {47, 48},
                new int[] {72, 48},
                new int[] {74, 48},
                new int[] {75, 48},
                new int[] {77, 48},
                new int[] {78, 48},
                new int[] {79, 48},
                new int[] {118, 48},
                new int[] {119, 48},
                new int[] {120, 48},
                new int[] {121, 48},
                new int[] {160, 48},
            },
            new int[][] {
                new int[] {-1, 11},
            },
            new int[][] {
                new int[] {-1, 113},
                new int[] {91, 134},
                new int[] {204, 235},
            },
            new int[][] {
                new int[] {-1, 196},
                new int[] {202, 232},
                new int[] {211, 232},
                new int[] {234, 232},
                new int[] {240, 232},
                new int[] {254, 267},
                new int[] {259, 267},
                new int[] {260, 267},
                new int[] {283, 232},
                new int[] {287, 232},
                new int[] {298, 267},
                new int[] {301, 267},
                new int[] {302, 267},
                new int[] {306, 232},
            },
            new int[][] {
                new int[] {-1, 268},
            },
            new int[][] {
                new int[] {-1, 197},
                new int[] {254, 269},
                new int[] {260, 269},
                new int[] {284, 295},
                new int[] {288, 295},
                new int[] {298, 269},
                new int[] {301, 269},
                new int[] {302, 269},
                new int[] {314, 295},
                new int[] {315, 295},
                new int[] {316, 295},
                new int[] {317, 295},
                new int[] {318, 295},
                new int[] {323, 295},
                new int[] {324, 295},
            },
            new int[][] {
                new int[] {-1, 12},
                new int[] {11, 28},
                new int[] {66, 114},
                new int[] {80, 124},
                new int[] {91, 114},
                new int[] {125, 124},
                new int[] {156, 198},
                new int[] {166, 198},
                new int[] {202, 198},
                new int[] {203, 198},
                new int[] {204, 114},
                new int[] {211, 198},
                new int[] {212, 198},
                new int[] {234, 198},
                new int[] {240, 198},
                new int[] {254, 198},
                new int[] {259, 198},
                new int[] {260, 198},
                new int[] {266, 198},
                new int[] {274, 198},
                new int[] {283, 198},
                new int[] {284, 198},
                new int[] {287, 198},
                new int[] {288, 198},
                new int[] {294, 198},
                new int[] {298, 198},
                new int[] {301, 198},
                new int[] {302, 198},
                new int[] {306, 198},
                new int[] {314, 198},
                new int[] {315, 198},
                new int[] {316, 198},
                new int[] {317, 198},
                new int[] {318, 198},
                new int[] {323, 198},
                new int[] {324, 198},
            },
            new int[][] {
                new int[] {-1, 270},
                new int[] {259, 275},
                new int[] {260, 276},
                new int[] {301, 275},
                new int[] {302, 276},
            },
            new int[][] {
                new int[] {-1, 309},
                new int[] {254, 271},
                new int[] {260, 277},
                new int[] {284, 296},
                new int[] {288, 300},
                new int[] {298, 308},
                new int[] {302, 310},
                new int[] {314, 319},
                new int[] {315, 320},
                new int[] {316, 321},
                new int[] {318, 322},
                new int[] {323, 325},
                new int[] {324, 326},
            },
            new int[][] {
                new int[] {-1, 199},
                new int[] {254, 272},
                new int[] {260, 272},
                new int[] {284, 297},
                new int[] {288, 297},
                new int[] {298, 272},
                new int[] {301, 272},
                new int[] {302, 272},
                new int[] {314, 297},
                new int[] {315, 297},
                new int[] {316, 297},
                new int[] {317, 297},
                new int[] {318, 297},
                new int[] {323, 297},
                new int[] {324, 297},
            },
            new int[][] {
                new int[] {-1, 26},
                new int[] {174, 218},
            },
            new int[][] {
                new int[] {-1, 59},
            },
            new int[][] {
                new int[] {-1, 60},
            },
            new int[][] {
                new int[] {-1, 61},
                new int[] {62, 90},
                new int[] {88, 90},
            },
            new int[][] {
                new int[] {-1, 54},
            },
            new int[][] {
                new int[] {-1, 55},
                new int[] {81, 126},
                new int[] {82, 127},
            },
            new int[][] {
                new int[] {-1, 21},
                new int[] {0, 13},
                new int[] {15, 13},
                new int[] {16, 13},
                new int[] {17, 13},
                new int[] {24, 56},
                new int[] {35, 13},
                new int[] {36, 13},
                new int[] {40, 13},
                new int[] {70, 13},
                new int[] {81, 56},
                new int[] {82, 56},
            },
            new int[][] {
                new int[] {-1, 14},
                new int[] {2, 22},
                new int[] {31, 68},
                new int[] {32, 69},
                new int[] {84, 128},
                new int[] {135, 168},
                new int[] {229, 254},
                new int[] {285, 298},
                new int[] {307, 314},
            },
            new int[][] {
                new int[] {-1, 170},
                new int[] {64, 104},
                new int[] {98, 138},
                new int[] {103, 143},
                new int[] {155, 188},
                new int[] {191, 226},
                new int[] {223, 247},
                new int[] {224, 248},
                new int[] {227, 250},
                new int[] {251, 262},
                new int[] {280, 289},
                new int[] {281, 290},
                new int[] {303, 311},
                new int[] {304, 312},
            },
            new int[][] {
                new int[] {-1, 105},
                new int[] {145, 178},
                new int[] {146, 179},
            },
            new int[][] {
                new int[] {-1, 106},
                new int[] {147, 180},
            },
            new int[][] {
                new int[] {-1, 107},
                new int[] {100, 140},
                new int[] {148, 181},
                new int[] {149, 182},
            },
            new int[][] {
                new int[] {-1, 108},
                new int[] {99, 139},
                new int[] {151, 184},
                new int[] {152, 185},
                new int[] {153, 186},
            },
            new int[][] {
                new int[] {-1, 109},
            },
            new int[][] {
                new int[] {-1, 110},
            },
            new int[][] {
                new int[] {-1, 200},
            },
            new int[][] {
                new int[] {-1, 201},
                new int[] {64, 111},
                new int[] {98, 111},
                new int[] {99, 111},
                new int[] {100, 111},
                new int[] {103, 111},
                new int[] {136, 111},
                new int[] {145, 111},
                new int[] {146, 111},
                new int[] {147, 111},
                new int[] {148, 111},
                new int[] {149, 111},
                new int[] {151, 111},
                new int[] {152, 111},
                new int[] {153, 111},
                new int[] {155, 111},
                new int[] {172, 111},
                new int[] {175, 111},
                new int[] {191, 111},
                new int[] {214, 111},
                new int[] {221, 111},
                new int[] {223, 111},
                new int[] {224, 111},
                new int[] {227, 111},
                new int[] {251, 111},
                new int[] {280, 111},
                new int[] {281, 111},
                new int[] {303, 111},
                new int[] {304, 111},
            },
            new int[][] {
                new int[] {-1, 137},
                new int[] {141, 176},
            },
            new int[][] {
                new int[] {-1, 171},
                new int[] {172, 217},
                new int[] {175, 220},
                new int[] {214, 241},
                new int[] {221, 246},
            },
            new int[][] {
                new int[] {-1, 15},
            },
            new int[][] {
                new int[] {-1, 16},
                new int[] {15, 35},
            },
            new int[][] {
                new int[] {-1, 17},
                new int[] {15, 36},
                new int[] {16, 40},
                new int[] {35, 70},
            },
            new int[][] {
                new int[] {-1, 18},
                new int[] {15, 37},
                new int[] {16, 41},
                new int[] {17, 44},
                new int[] {35, 71},
                new int[] {36, 73},
                new int[] {40, 76},
                new int[] {70, 117},
            },
            new int[][] {
                new int[] {-1, 19},
                new int[] {15, 38},
                new int[] {16, 42},
                new int[] {17, 45},
                new int[] {18, 47},
                new int[] {35, 72},
                new int[] {36, 74},
                new int[] {37, 75},
                new int[] {40, 77},
                new int[] {41, 78},
                new int[] {44, 79},
                new int[] {70, 118},
                new int[] {71, 119},
                new int[] {73, 120},
                new int[] {76, 121},
                new int[] {117, 160},
            },
            new int[][] {
                new int[] {-1, 125},
            },
            new int[][] {
                new int[] {-1, 202},
                new int[] {166, 211},
                new int[] {203, 234},
                new int[] {212, 240},
                new int[] {266, 283},
                new int[] {274, 287},
                new int[] {294, 306},
            },
            new int[][] {
                new int[] {-1, 62},
                new int[] {60, 88},
            },
        };
        #endregion
        #region errorMessages
        private static string[] errorMessages = {
            "Expecting: TDirective, 'principal', 'typedef', TIdentifier or end of file",
            "Expecting: TIdentifier",
            "Expecting: 'struct'",
            "Expecting: TIdentifier, '-->', '<-', '*', ',', '{{' or '@'",
            "Expecting: end of file",
            "Expecting: 'principal', 'typedef', TIdentifier or end of file",
            "Expecting: 'typedef', TIdentifier or end of file",
            "Expecting: TIdentifier or end of file",
            "Expecting: TIdentifier or '*'",
            "Expecting: '-->', '<-' or ','",
            "Expecting: '<-'",
            "Expecting: 'while', 'if', 'return', 'this', 'caller', TIdentifier, '>>>', '<-', ',', ';', '@', '}}', '@', '{' or '⊔'",
            "Expecting: 'while', 'if', 'return', 'this', 'caller', TIdentifier, '>>>', '<-', ',', ';', '}}', '@', '{' or '⊔'",
            "Expecting: ';'",
            "Expecting: TIdentifier, '_' or '^'",
            "Expecting: TTime or TNumber",
            "Expecting: TIdentifier, '*' or '{{'",
            "Expecting: '=', ';', '(' or '['",
            "Expecting: '{'",
            "Expecting: '->', ';', '@', '}}' or '⊔'",
            "Expecting: ';', '}}' or '⊔'",
            "Expecting: '}}'",
            "Expecting: '->'",
            "Expecting: '-'",
            "Expecting: TIntervalUnit",
            "Expecting: 'while', 'if', 'return', 'this', 'caller', TIdentifier, '-->', '>>>', '->', '<-', ',', ';', '}}', '@', '{' or '⊔'",
            "Expecting: TNumber, 'while', 'if', 'return', 'this', 'caller', TIdentifier, '-->', '>>>', '->', '<-', '*', ',', ';', '}}', '@', '{' or '⊔'",
            "Expecting: '('",
            "Expecting: TBool, TNumber, 'NULL', TChar, TString, TIdentifier, '<|', '-', '!', '@', '@?' or '('",
            "Expecting: TIdentifier or ')'",
            "Expecting: TNumber",
            "Expecting: 'while', 'if', 'return', 'this', 'caller', TIdentifier, '>>>', '<-', ';', '}}', '@', '{' or '⊔'",
            "Expecting: TIdentifier or '}'",
            "Expecting: TIdentifier, '|>' or '*'",
            "Expecting: TIdentifier, ';', '}}' or '⊔'",
            "Expecting: TTime",
            "Expecting: '|>', '->', TCompare, '+', '-', '*', '/', '%', '&&', '||', '.', ',', ';', ')', '[' or ']'",
            "Expecting: '|>', '<<<', '->', TCompare, '+', '-', '*', '/', '%', '&&', '||', '.', ',', ';', '(', ')', '[' or ']'",
            "Expecting: TBool, TNumber, 'NULL', TChar, TString, TIdentifier, '<|', '@', '@?' or '('",
            "Expecting: TBool, TNumber, 'NULL', TChar, TString, TIdentifier, '<|', '-', '@', '@?' or '('",
            "Expecting: '|>', ',', ';', ')' or ']'",
            "Expecting: '|>', '&&', '||', ',', ';', ')' or ']'",
            "Expecting: '|>', TCompare, '&&', '||', ',', ';', ')' or ']'",
            "Expecting: '|>', TCompare, '+', '-', '&&', '||', ',', ';', ')' or ']'",
            "Expecting: ')'",
            "Expecting: ']'",
            "Expecting: TBool, TNumber, 'NULL', TChar, TString, TIdentifier, '<|', '-', '!', '@', '@?', '(' or ')'",
            "Expecting: '|>' or ','",
            "Expecting: '<<<' or '('",
            "Expecting: 'while', 'if', 'return', 'this', 'caller', TIdentifier, '@' or '}'",
            "Expecting: ',' or ')'",
            "Expecting: ';' or '['",
            "Expecting: '>>>'",
            "Expecting: '{{'",
            "Expecting: TBool, TNumber, 'NULL', TChar, TString, TIdentifier, '<|', '-', '!', ';', '@', '@?' or '('",
            "Expecting: TIfActsFor",
            "Expecting: TIdentifier, '<<<', '=', '*', '{{' or '('",
            "Expecting: 'while', 'if', 'else', 'return', 'this', 'caller', TIdentifier, '@' or '}'",
            "Expecting: '|>'",
            "Expecting: '=', ';' or '['",
            "Expecting: 'while', 'if', 'return', 'this', 'caller', TIdentifier, '@' or '{'",
            "Expecting: 'else'",
        };
        #endregion
        #region errors
        private static int[] errors = {
            0, 0, 1, 2, 3, 4, 0, 5, 6, 6, 7, 1, 8, 9, 10, 0,
            5, 6, 6, 7, 11, 12, 13, 1, 14, 15, 8, 16, 8, 17, 8, 1,
            1, 1, 0, 5, 6, 6, 7, 5, 6, 6, 7, 6, 6, 7, 6, 7,
            7, 5, 18, 19, 20, 20, 20, 21, 22, 23, 24, 25, 26, 26, 26, 27,
            28, 7, 29, 30, 13, 31, 6, 6, 7, 6, 7, 7, 6, 7, 7, 7,
            32, 14, 14, 33, 34, 35, 26, 30, 26, 30, 26, 29, 36, 36, 36, 36,
            36, 37, 28, 38, 39, 1, 1, 28, 13, 40, 41, 42, 43, 36, 36, 36,
            18, 44, 8, 45, 6, 6, 7, 7, 7, 7, 1, 32, 8, 32, 21, 21,
            20, 26, 25, 30, 25, 18, 44, 1, 46, 27, 47, 42, 41, 48, 36, 44,
            7, 28, 28, 28, 39, 39, 1, 38, 38, 38, 1, 28, 49, 18, 50, 13,
            7, 13, 51, 1, 32, 25, 49, 18, 52, 36, 50, 44, 46, 36, 53, 46,
            27, 36, 40, 40, 41, 42, 42, 36, 43, 43, 43, 36, 45, 27, 27, 54,
            55, 55, 56, 7, 49, 49, 8, 55, 57, 13, 49, 49, 1, 7, 6, 32,
            30, 13, 7, 49, 49, 27, 28, 36, 36, 44, 58, 36, 44, 46, 36, 28,
            28, 57, 13, 28, 59, 1, 57, 7, 49, 7, 49, 44, 45, 6, 7, 7,
            49, 44, 36, 36, 36, 36, 44, 44, 44, 57, 13, 28, 57, 30, 60, 7,
            13, 7, 36, 60, 60, 57, 13, 45, 27, 27, 49, 49, 57, 57, 49, 61,
            55, 32, 49, 49, 49, 61, 57, 57, 28, 28, 57, 49, 60, 1, 49, 49,
            60, 44, 44, 57, 27, 27, 49, 57, 49, 55, 60, 49, 49, 60, 60, 28,
            28, 57, 49, 1, 61, 57, 61, 44, 44, 57, 60, 60, 60, 60, 60, 61,
            57, 57, 61, 60, 60, 57, 57,
        };
        #endregion
    }
}
