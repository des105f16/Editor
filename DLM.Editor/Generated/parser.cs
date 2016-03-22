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
        private int getIndex(TThis node)
        {
            return 11;
        }
        private int getIndex(TCaller node)
        {
            return 12;
        }
        private int getIndex(TIdentifier node)
        {
            return 13;
        }
        private int getIndex(TActsFor node)
        {
            return 14;
        }
        private int getIndex(TIfActsFor node)
        {
            return 15;
        }
        private int getIndex(TDeclassifyStart node)
        {
            return 16;
        }
        private int getIndex(TDeclassifyEnd node)
        {
            return 17;
        }
        private int getIndex(TRArrow node)
        {
            return 18;
        }
        private int getIndex(TLArrow node)
        {
            return 19;
        }
        private int getIndex(TCompare node)
        {
            return 20;
        }
        private int getIndex(TAssign node)
        {
            return 21;
        }
        private int getIndex(TUnderscore node)
        {
            return 22;
        }
        private int getIndex(THat node)
        {
            return 23;
        }
        private int getIndex(TPlus node)
        {
            return 24;
        }
        private int getIndex(TMinus node)
        {
            return 25;
        }
        private int getIndex(TAsterisk node)
        {
            return 26;
        }
        private int getIndex(TSlash node)
        {
            return 27;
        }
        private int getIndex(TPercent node)
        {
            return 28;
        }
        private int getIndex(TBang node)
        {
            return 29;
        }
        private int getIndex(TAnd node)
        {
            return 30;
        }
        private int getIndex(TOr node)
        {
            return 31;
        }
        private int getIndex(TPeriod node)
        {
            return 32;
        }
        private int getIndex(TComma node)
        {
            return 33;
        }
        private int getIndex(TColon node)
        {
            return 34;
        }
        private int getIndex(TSemicolon node)
        {
            return 35;
        }
        private int getIndex(TLabelStart node)
        {
            return 36;
        }
        private int getIndex(TLabelEnd node)
        {
            return 37;
        }
        private int getIndex(TLPar node)
        {
            return 38;
        }
        private int getIndex(TRPar node)
        {
            return 39;
        }
        private int getIndex(TLSqu node)
        {
            return 40;
        }
        private int getIndex(TRSqu node)
        {
            return 41;
        }
        private int getIndex(TLCur node)
        {
            return 42;
        }
        private int getIndex(TRCur node)
        {
            return 43;
        }
        private int getIndex(TJoin node)
        {
            return 44;
        }
        
        private int getIndex(EOF node)
        {
            return 45;
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
                        List<PPrincipalHierarchyStatement> pprincipalhierarchystatementlist = isOn(4, index - 0) ? Pop<List<PPrincipalHierarchyStatement>>() : new List<PPrincipalHierarchyStatement>();
                        List<PPrincipalDeclaration> pprincipaldeclarationlist = isOn(2, index - 0) ? Pop<List<PPrincipalDeclaration>>() : new List<PPrincipalDeclaration>();
                        List<PInclude> pincludelist = isOn(1, index - 0) ? Pop<List<PInclude>>() : new List<PInclude>();
                        List<PInclude> pincludelist2 = new List<PInclude>();
                        pincludelist2.AddRange(pincludelist);
                        List<PPrincipalDeclaration> pprincipaldeclarationlist2 = new List<PPrincipalDeclaration>();
                        pprincipaldeclarationlist2.AddRange(pprincipaldeclarationlist);
                        List<PPrincipalHierarchyStatement> pprincipalhierarchystatementlist2 = new List<PPrincipalHierarchyStatement>();
                        pprincipalhierarchystatementlist2.AddRange(pprincipalhierarchystatementlist);
                        List<PStruct> pstructlist2 = new List<PStruct>();
                        pstructlist2.AddRange(pstructlist);
                        List<PStatement> pstatementlist2 = new List<PStatement>();
                        pstatementlist2.AddRange(pstatementlist);
                        ARoot aroot = new ARoot(
                            pincludelist2,
                            pprincipaldeclarationlist2,
                            pprincipalhierarchystatementlist2,
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
                        APrincipalHierarchyStatement aprincipalhierarchystatement = new APrincipalHierarchyStatement(
                            pprincipal,
                            pprincipallist2
                        );
                        Push(3, aprincipalhierarchystatement);
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
                        PStatement pstatement = Pop<PStatement>();
                        Push(8, pstatement);
                    }
                    break;
                case 53:
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
                        Push(9, aifelsestatement);
                    }
                    break;
                case 54:
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
                        Push(9, awhilestatement);
                    }
                    break;
                case 55:
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
                case 56:
                    {
                        PStatement pstatement = Pop<PStatement>();
                        Push(9, pstatement);
                    }
                    break;
                case 57:
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
                case 58:
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
                case 59:
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
                case 60:
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
                case 61:
                case 62:
                    {
                        TSemicolon tsemicolon = Pop<TSemicolon>();
                        PExpression pexpression = isOn(1, index - 61) ? Pop<PExpression>() : null;
                        TReturn treturn = Pop<TReturn>();
                        AReturnStatement areturnstatement = new AReturnStatement(
                            pexpression
                        );
                        Push(10, areturnstatement);
                    }
                    break;
                case 63:
                case 64:
                    {
                        PLabel plabel = isOn(1, index - 63) ? Pop<PLabel>() : null;
                        TIdentifier tidentifier = Pop<TIdentifier>();
                        AType atype = new AType(
                            tidentifier,
                            plabel
                        );
                        Push(11, atype);
                    }
                    break;
                case 65:
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
                case 66:
                    {
                        PStatement pstatement = Pop<PStatement>();
                        List<PStatement> pstatementlist = new List<PStatement>();
                        pstatementlist.Add(pstatement);
                        Push(12, pstatementlist);
                    }
                    break;
                case 67:
                case 68:
                    {
                        TRCur trcur = Pop<TRCur>();
                        List<PStatement> pstatementlist = isOn(1, index - 67) ? Pop<List<PStatement>>() : new List<PStatement>();
                        TLCur tlcur = Pop<TLCur>();
                        List<PStatement> pstatementlist2 = new List<PStatement>();
                        pstatementlist2.AddRange(pstatementlist);
                        Push(12, pstatementlist2);
                    }
                    break;
                case 69:
                    {
                        PStatement pstatement = Pop<PStatement>();
                        List<PStatement> pstatementlist = new List<PStatement>();
                        pstatementlist.Add(pstatement);
                        Push(13, pstatementlist);
                    }
                    break;
                case 70:
                case 71:
                    {
                        TRCur trcur = Pop<TRCur>();
                        List<PStatement> pstatementlist = isOn(1, index - 70) ? Pop<List<PStatement>>() : new List<PStatement>();
                        TLCur tlcur = Pop<TLCur>();
                        List<PStatement> pstatementlist2 = new List<PStatement>();
                        pstatementlist2.AddRange(pstatementlist);
                        Push(13, pstatementlist2);
                    }
                    break;
                case 72:
                    {
                        TThis tthis = Pop<TThis>();
                        AThisClaimant athisclaimant = new AThisClaimant(
                            tthis
                        );
                        Push(14, athisclaimant);
                    }
                    break;
                case 73:
                    {
                        TCaller tcaller = Pop<TCaller>();
                        ACallerClaimant acallerclaimant = new ACallerClaimant(
                            tcaller
                        );
                        Push(14, acallerclaimant);
                    }
                    break;
                case 74:
                    {
                        TLabelEnd tlabelend = Pop<TLabelEnd>();
                        List<PPolicy> ppolicylist = Pop<List<PPolicy>>();
                        TLabelStart tlabelstart = Pop<TLabelStart>();
                        List<PPolicy> ppolicylist2 = new List<PPolicy>();
                        ppolicylist2.AddRange(ppolicylist);
                        ALabel alabel = new ALabel(
                            ppolicylist2
                        );
                        Push(15, alabel);
                    }
                    break;
                case 75:
                    {
                        TIdentifier tidentifier = Pop<TIdentifier>();
                        AVariablePolicy avariablepolicy = new AVariablePolicy(
                            tidentifier
                        );
                        Push(16, avariablepolicy);
                    }
                    break;
                case 76:
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
                        Push(16, aprincipalpolicy);
                    }
                    break;
                case 77:
                    {
                        TRArrow trarrow = Pop<TRArrow>();
                        PPrincipal pprincipal = Pop<PPrincipal>();
                        List<PPrincipal> pprincipallist = new List<PPrincipal>();
                        APrincipalPolicy aprincipalpolicy = new APrincipalPolicy(
                            pprincipal,
                            pprincipallist
                        );
                        Push(16, aprincipalpolicy);
                    }
                    break;
                case 78:
                    {
                        TUnderscore tunderscore = Pop<TUnderscore>();
                        ALowerPolicy alowerpolicy = new ALowerPolicy(
                            tunderscore
                        );
                        Push(16, alowerpolicy);
                    }
                    break;
                case 79:
                    {
                        THat that = Pop<THat>();
                        AUpperPolicy aupperpolicy = new AUpperPolicy(
                            that
                        );
                        Push(16, aupperpolicy);
                    }
                    break;
                case 80:
                    {
                        PPolicy ppolicy = Pop<PPolicy>();
                        List<PPolicy> ppolicylist = new List<PPolicy>();
                        ppolicylist.Add(ppolicy);
                        Push(17, ppolicylist);
                    }
                    break;
                case 81:
                    {
                        List<PPolicy> ppolicylist = Pop<List<PPolicy>>();
                        TSemicolon tsemicolon = Pop<TSemicolon>();
                        PPolicy ppolicy = Pop<PPolicy>();
                        List<PPolicy> ppolicylist2 = new List<PPolicy>();
                        ppolicylist2.Add(ppolicy);
                        ppolicylist2.AddRange(ppolicylist);
                        Push(17, ppolicylist2);
                    }
                    break;
                case 82:
                    {
                        List<PPolicy> ppolicylist = Pop<List<PPolicy>>();
                        TJoin tjoin = Pop<TJoin>();
                        PPolicy ppolicy = Pop<PPolicy>();
                        List<PPolicy> ppolicylist2 = new List<PPolicy>();
                        ppolicylist2.Add(ppolicy);
                        ppolicylist2.AddRange(ppolicylist);
                        Push(17, ppolicylist2);
                    }
                    break;
                case 83:
                    {
                        TIdentifier tidentifier = Pop<TIdentifier>();
                        APrincipal aprincipal = new APrincipal(
                            tidentifier
                        );
                        Push(18, aprincipal);
                    }
                    break;
                case 84:
                    {
                        PPrincipal pprincipal = Pop<PPrincipal>();
                        List<PPrincipal> pprincipallist = new List<PPrincipal>();
                        pprincipallist.Add(pprincipal);
                        Push(19, pprincipallist);
                    }
                    break;
                case 85:
                    {
                        List<PPrincipal> pprincipallist = Pop<List<PPrincipal>>();
                        TComma tcomma = Pop<TComma>();
                        PPrincipal pprincipal = Pop<PPrincipal>();
                        List<PPrincipal> pprincipallist2 = new List<PPrincipal>();
                        pprincipallist2.Add(pprincipal);
                        pprincipallist2.AddRange(pprincipallist);
                        Push(19, pprincipallist2);
                    }
                    break;
                case 86:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        Push(20, pexpression);
                    }
                    break;
                case 87:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TAnd tand = Pop<TAnd>();
                        PExpression pexpression2 = Pop<PExpression>();
                        AAndExpression aandexpression = new AAndExpression(
                            pexpression2,
                            pexpression
                        );
                        Push(21, aandexpression);
                    }
                    break;
                case 88:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TOr tor = Pop<TOr>();
                        PExpression pexpression2 = Pop<PExpression>();
                        AOrExpression aorexpression = new AOrExpression(
                            pexpression2,
                            pexpression
                        );
                        Push(21, aorexpression);
                    }
                    break;
                case 89:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        Push(21, pexpression);
                    }
                    break;
                case 90:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TCompare tcompare = Pop<TCompare>();
                        PExpression pexpression2 = Pop<PExpression>();
                        AComparisonExpression acomparisonexpression = new AComparisonExpression(
                            pexpression2,
                            tcompare,
                            pexpression
                        );
                        Push(22, acomparisonexpression);
                    }
                    break;
                case 91:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TBang tbang = Pop<TBang>();
                        ANotExpression anotexpression = new ANotExpression(
                            pexpression
                        );
                        Push(22, anotexpression);
                    }
                    break;
                case 92:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        Push(22, pexpression);
                    }
                    break;
                case 93:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TPlus tplus = Pop<TPlus>();
                        PExpression pexpression2 = Pop<PExpression>();
                        APlusExpression aplusexpression = new APlusExpression(
                            pexpression2,
                            pexpression
                        );
                        Push(23, aplusexpression);
                    }
                    break;
                case 94:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TMinus tminus = Pop<TMinus>();
                        PExpression pexpression2 = Pop<PExpression>();
                        AMinusExpression aminusexpression = new AMinusExpression(
                            pexpression2,
                            pexpression
                        );
                        Push(23, aminusexpression);
                    }
                    break;
                case 95:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TMinus tminus = Pop<TMinus>();
                        ANegateExpression anegateexpression = new ANegateExpression(
                            pexpression
                        );
                        Push(23, anegateexpression);
                    }
                    break;
                case 96:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        Push(23, pexpression);
                    }
                    break;
                case 97:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TAsterisk tasterisk = Pop<TAsterisk>();
                        PExpression pexpression2 = Pop<PExpression>();
                        AMultiplyExpression amultiplyexpression = new AMultiplyExpression(
                            pexpression2,
                            pexpression
                        );
                        Push(24, amultiplyexpression);
                    }
                    break;
                case 98:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TSlash tslash = Pop<TSlash>();
                        PExpression pexpression2 = Pop<PExpression>();
                        ADivideExpression adivideexpression = new ADivideExpression(
                            pexpression2,
                            pexpression
                        );
                        Push(24, adivideexpression);
                    }
                    break;
                case 99:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TPercent tpercent = Pop<TPercent>();
                        PExpression pexpression2 = Pop<PExpression>();
                        AModuloExpression amoduloexpression = new AModuloExpression(
                            pexpression2,
                            pexpression
                        );
                        Push(24, amoduloexpression);
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
                        Push(25, aelementexpression);
                    }
                    break;
                case 102:
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
                        Push(25, aelementexpression);
                    }
                    break;
                case 103:
                    {
                        TRSqu trsqu = Pop<TRSqu>();
                        PExpression pexpression = Pop<PExpression>();
                        TLSqu tlsqu = Pop<TLSqu>();
                        PExpression pexpression2 = Pop<PExpression>();
                        AIndexExpression aindexexpression = new AIndexExpression(
                            pexpression2,
                            pexpression
                        );
                        Push(25, aindexexpression);
                    }
                    break;
                case 104:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        Push(25, pexpression);
                    }
                    break;
                case 105:
                    {
                        TRPar trpar = Pop<TRPar>();
                        PExpression pexpression = Pop<PExpression>();
                        TLPar tlpar = Pop<TLPar>();
                        AParenthesisExpression aparenthesisexpression = new AParenthesisExpression(
                            pexpression
                        );
                        Push(26, aparenthesisexpression);
                    }
                    break;
                case 106:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        Push(26, pexpression);
                    }
                    break;
                case 107:
                    {
                        TNumber tnumber = Pop<TNumber>();
                        ANumberExpression anumberexpression = new ANumberExpression(
                            tnumber
                        );
                        Push(26, anumberexpression);
                    }
                    break;
                case 108:
                    {
                        TBool tbool = Pop<TBool>();
                        ABooleanExpression abooleanexpression = new ABooleanExpression(
                            tbool
                        );
                        Push(26, abooleanexpression);
                    }
                    break;
                case 109:
                    {
                        TIdentifier tidentifier = Pop<TIdentifier>();
                        AIdentifierExpression aidentifierexpression = new AIdentifierExpression(
                            tidentifier
                        );
                        Push(26, aidentifierexpression);
                    }
                    break;
                case 110:
                    {
                        TDeclassifyEnd tdeclassifyend = Pop<TDeclassifyEnd>();
                        TIdentifier tidentifier = Pop<TIdentifier>();
                        TDeclassifyStart tdeclassifystart = Pop<TDeclassifyStart>();
                        ADeclassifyExpression adeclassifyexpression = new ADeclassifyExpression(
                            tidentifier,
                            null
                        );
                        Push(26, adeclassifyexpression);
                    }
                    break;
                case 111:
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
                        Push(26, adeclassifyexpression);
                    }
                    break;
                case 112:
                case 113:
                    {
                        TRPar trpar = Pop<TRPar>();
                        List<PExpression> pexpressionlist = isOn(1, index - 112) ? Pop<List<PExpression>>() : new List<PExpression>();
                        TLPar tlpar = Pop<TLPar>();
                        TIdentifier tidentifier = Pop<TIdentifier>();
                        List<PExpression> pexpressionlist2 = new List<PExpression>();
                        pexpressionlist2.AddRange(pexpressionlist);
                        AFunctionCallExpression afunctioncallexpression = new AFunctionCallExpression(
                            tidentifier,
                            pexpressionlist2
                        );
                        Push(27, afunctioncallexpression);
                    }
                    break;
                case 114:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        List<PExpression> pexpressionlist = new List<PExpression>();
                        pexpressionlist.Add(pexpression);
                        Push(28, pexpressionlist);
                    }
                    break;
                case 115:
                    {
                        List<PExpression> pexpressionlist = Pop<List<PExpression>>();
                        TComma tcomma = Pop<TComma>();
                        PExpression pexpression = Pop<PExpression>();
                        List<PExpression> pexpressionlist2 = new List<PExpression>();
                        pexpressionlist2.Add(pexpression);
                        pexpressionlist2.AddRange(pexpressionlist);
                        Push(28, pexpressionlist2);
                    }
                    break;
                case 116:
                    Push(29, new List<PInclude>() { Pop<PInclude>() });
                    break;
                case 117:
                    {
                        PInclude item = Pop<PInclude>();
                        List<PInclude> list = Pop<List<PInclude>>();
                        list.Add(item);
                        Push(29, list);
                    }
                    break;
                case 118:
                    Push(30, new List<PPrincipalDeclaration>() { Pop<PPrincipalDeclaration>() });
                    break;
                case 119:
                    {
                        PPrincipalDeclaration item = Pop<PPrincipalDeclaration>();
                        List<PPrincipalDeclaration> list = Pop<List<PPrincipalDeclaration>>();
                        list.Add(item);
                        Push(30, list);
                    }
                    break;
                case 120:
                    Push(31, new List<PPrincipalHierarchyStatement>() { Pop<PPrincipalHierarchyStatement>() });
                    break;
                case 121:
                    {
                        PPrincipalHierarchyStatement item = Pop<PPrincipalHierarchyStatement>();
                        List<PPrincipalHierarchyStatement> list = Pop<List<PPrincipalHierarchyStatement>>();
                        list.Add(item);
                        Push(31, list);
                    }
                    break;
                case 122:
                    Push(32, new List<PStruct>() { Pop<PStruct>() });
                    break;
                case 123:
                    {
                        PStruct item = Pop<PStruct>();
                        List<PStruct> list = Pop<List<PStruct>>();
                        list.Add(item);
                        Push(32, list);
                    }
                    break;
                case 124:
                    Push(33, new List<PStatement>() { Pop<PStatement>() });
                    break;
                case 125:
                    {
                        PStatement item = Pop<PStatement>();
                        List<PStatement> list = Pop<List<PStatement>>();
                        list.Add(item);
                        Push(33, list);
                    }
                    break;
                case 126:
                    Push(34, new List<PField>() { Pop<PField>() });
                    break;
                case 127:
                    {
                        PField item = Pop<PField>();
                        List<PField> list = Pop<List<PField>>();
                        list.Add(item);
                        Push(34, list);
                    }
                    break;
                case 128:
                    Push(35, new List<PStatement>() { Pop<PStatement>() });
                    break;
                case 129:
                    {
                        PStatement item = Pop<PStatement>();
                        List<PStatement> list = Pop<List<PStatement>>();
                        list.Add(item);
                        Push(35, list);
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
                new int[] {13, 0, 4},
            },
            new int[][] {
                new int[] {-1, 3, 1},
                new int[] {1, 0, 18},
            },
            new int[][] {
                new int[] {-1, 3, 2},
                new int[] {13, 0, 19},
            },
            new int[][] {
                new int[] {-1, 3, 3},
                new int[] {6, 0, 22},
            },
            new int[][] {
                new int[] {-1, 1, 63},
                new int[] {14, 1, 83},
                new int[] {36, 0, 23},
            },
            new int[][] {
                new int[] {-1, 3, 5},
                new int[] {45, 2, -1},
            },
            new int[][] {
                new int[] {-1, 1, 116},
            },
            new int[][] {
                new int[] {-1, 1, 118},
            },
            new int[][] {
                new int[] {-1, 1, 120},
            },
            new int[][] {
                new int[] {-1, 1, 122},
            },
            new int[][] {
                new int[] {-1, 1, 124},
            },
            new int[][] {
                new int[] {-1, 3, 11},
                new int[] {13, 0, 25},
                new int[] {26, 0, 26},
            },
            new int[][] {
                new int[] {-1, 3, 12},
                new int[] {14, 0, 27},
            },
            new int[][] {
                new int[] {-1, 1, 1},
                new int[] {0, 0, 1},
                new int[] {4, 0, 2},
                new int[] {5, 0, 3},
                new int[] {13, 0, 4},
            },
            new int[][] {
                new int[] {-1, 1, 2},
                new int[] {4, 0, 2},
                new int[] {5, 0, 3},
                new int[] {13, 0, 4},
            },
            new int[][] {
                new int[] {-1, 1, 4},
                new int[] {5, 0, 3},
                new int[] {13, 0, 4},
            },
            new int[][] {
                new int[] {-1, 1, 8},
                new int[] {5, 0, 3},
                new int[] {13, 0, 40},
            },
            new int[][] {
                new int[] {-1, 1, 16},
                new int[] {13, 0, 40},
            },
            new int[][] {
                new int[] {-1, 1, 32},
            },
            new int[][] {
                new int[] {-1, 1, 83},
            },
            new int[][] {
                new int[] {-1, 1, 84},
                new int[] {33, 0, 44},
            },
            new int[][] {
                new int[] {-1, 3, 21},
                new int[] {35, 0, 45},
            },
            new int[][] {
                new int[] {-1, 3, 22},
                new int[] {13, 0, 46},
            },
            new int[][] {
                new int[] {-1, 3, 23},
                new int[] {13, 0, 47},
                new int[] {22, 0, 48},
                new int[] {23, 0, 49},
            },
            new int[][] {
                new int[] {-1, 1, 64},
            },
            new int[][] {
                new int[] {-1, 3, 25},
                new int[] {21, 0, 53},
                new int[] {35, 0, 54},
                new int[] {38, 0, 55},
                new int[] {40, 0, 56},
            },
            new int[][] {
                new int[] {-1, 1, 65},
            },
            new int[][] {
                new int[] {-1, 3, 27},
                new int[] {13, 0, 19},
            },
            new int[][] {
                new int[] {-1, 1, 117},
            },
            new int[][] {
                new int[] {-1, 1, 3},
                new int[] {4, 0, 2},
                new int[] {5, 0, 3},
                new int[] {13, 0, 4},
            },
            new int[][] {
                new int[] {-1, 1, 5},
                new int[] {5, 0, 3},
                new int[] {13, 0, 4},
            },
            new int[][] {
                new int[] {-1, 1, 9},
                new int[] {5, 0, 3},
                new int[] {13, 0, 40},
            },
            new int[][] {
                new int[] {-1, 1, 17},
                new int[] {13, 0, 40},
            },
            new int[][] {
                new int[] {-1, 1, 119},
            },
            new int[][] {
                new int[] {-1, 1, 6},
                new int[] {5, 0, 3},
                new int[] {13, 0, 4},
            },
            new int[][] {
                new int[] {-1, 1, 10},
                new int[] {5, 0, 3},
                new int[] {13, 0, 40},
            },
            new int[][] {
                new int[] {-1, 1, 18},
                new int[] {13, 0, 40},
            },
            new int[][] {
                new int[] {-1, 1, 121},
            },
            new int[][] {
                new int[] {-1, 1, 12},
                new int[] {5, 0, 3},
                new int[] {13, 0, 40},
            },
            new int[][] {
                new int[] {-1, 1, 20},
                new int[] {13, 0, 40},
            },
            new int[][] {
                new int[] {-1, 1, 63},
                new int[] {36, 0, 23},
            },
            new int[][] {
                new int[] {-1, 1, 123},
            },
            new int[][] {
                new int[] {-1, 1, 24},
                new int[] {13, 0, 40},
            },
            new int[][] {
                new int[] {-1, 1, 125},
            },
            new int[][] {
                new int[] {-1, 3, 44},
                new int[] {13, 0, 19},
            },
            new int[][] {
                new int[] {-1, 1, 33},
            },
            new int[][] {
                new int[] {-1, 3, 46},
                new int[] {42, 0, 69},
            },
            new int[][] {
                new int[] {-1, 1, 75},
                new int[] {18, 1, 83},
            },
            new int[][] {
                new int[] {-1, 1, 78},
            },
            new int[][] {
                new int[] {-1, 1, 79},
            },
            new int[][] {
                new int[] {-1, 1, 80},
                new int[] {35, 0, 70},
                new int[] {44, 0, 71},
            },
            new int[][] {
                new int[] {-1, 3, 51},
                new int[] {37, 0, 72},
            },
            new int[][] {
                new int[] {-1, 3, 52},
                new int[] {18, 0, 73},
            },
            new int[][] {
                new int[] {-1, 3, 53},
                new int[] {2, 0, 74},
                new int[] {3, 0, 75},
                new int[] {13, 0, 76},
                new int[] {16, 0, 77},
                new int[] {25, 0, 78},
                new int[] {29, 0, 79},
                new int[] {38, 0, 80},
            },
            new int[][] {
                new int[] {-1, 1, 39},
            },
            new int[][] {
                new int[] {-1, 3, 55},
                new int[] {13, 0, 40},
                new int[] {39, 0, 89},
            },
            new int[][] {
                new int[] {-1, 3, 56},
                new int[] {3, 0, 92},
            },
            new int[][] {
                new int[] {-1, 3, 57},
                new int[] {35, 0, 93},
            },
            new int[][] {
                new int[] {-1, 1, 7},
                new int[] {5, 0, 3},
                new int[] {13, 0, 4},
            },
            new int[][] {
                new int[] {-1, 1, 11},
                new int[] {5, 0, 3},
                new int[] {13, 0, 40},
            },
            new int[][] {
                new int[] {-1, 1, 19},
                new int[] {13, 0, 40},
            },
            new int[][] {
                new int[] {-1, 1, 13},
                new int[] {5, 0, 3},
                new int[] {13, 0, 40},
            },
            new int[][] {
                new int[] {-1, 1, 21},
                new int[] {13, 0, 40},
            },
            new int[][] {
                new int[] {-1, 1, 25},
                new int[] {13, 0, 40},
            },
            new int[][] {
                new int[] {-1, 1, 14},
                new int[] {5, 0, 3},
                new int[] {13, 0, 40},
            },
            new int[][] {
                new int[] {-1, 1, 22},
                new int[] {13, 0, 40},
            },
            new int[][] {
                new int[] {-1, 1, 26},
                new int[] {13, 0, 40},
            },
            new int[][] {
                new int[] {-1, 1, 28},
                new int[] {13, 0, 40},
            },
            new int[][] {
                new int[] {-1, 1, 85},
            },
            new int[][] {
                new int[] {-1, 3, 69},
                new int[] {13, 0, 40},
                new int[] {43, 0, 99},
            },
            new int[][] {
                new int[] {-1, 3, 70},
                new int[] {13, 0, 47},
                new int[] {22, 0, 48},
                new int[] {23, 0, 49},
            },
            new int[][] {
                new int[] {-1, 3, 71},
                new int[] {13, 0, 47},
                new int[] {22, 0, 48},
                new int[] {23, 0, 49},
            },
            new int[][] {
                new int[] {-1, 1, 74},
            },
            new int[][] {
                new int[] {-1, 1, 77},
                new int[] {13, 0, 19},
            },
            new int[][] {
                new int[] {-1, 1, 108},
            },
            new int[][] {
                new int[] {-1, 1, 107},
            },
            new int[][] {
                new int[] {-1, 1, 109},
                new int[] {38, 0, 106},
            },
            new int[][] {
                new int[] {-1, 3, 77},
                new int[] {13, 0, 107},
            },
            new int[][] {
                new int[] {-1, 3, 78},
                new int[] {2, 0, 74},
                new int[] {3, 0, 75},
                new int[] {13, 0, 76},
                new int[] {16, 0, 77},
                new int[] {38, 0, 80},
            },
            new int[][] {
                new int[] {-1, 3, 79},
                new int[] {2, 0, 74},
                new int[] {3, 0, 75},
                new int[] {13, 0, 76},
                new int[] {16, 0, 77},
                new int[] {25, 0, 78},
                new int[] {38, 0, 80},
            },
            new int[][] {
                new int[] {-1, 3, 80},
                new int[] {2, 0, 74},
                new int[] {3, 0, 75},
                new int[] {13, 0, 76},
                new int[] {16, 0, 77},
                new int[] {25, 0, 78},
                new int[] {29, 0, 79},
                new int[] {38, 0, 80},
            },
            new int[][] {
                new int[] {-1, 3, 81},
                new int[] {35, 0, 111},
            },
            new int[][] {
                new int[] {-1, 1, 86},
            },
            new int[][] {
                new int[] {-1, 1, 89},
                new int[] {30, 0, 112},
                new int[] {31, 0, 113},
            },
            new int[][] {
                new int[] {-1, 1, 92},
                new int[] {20, 0, 114},
            },
            new int[][] {
                new int[] {-1, 1, 96},
                new int[] {24, 0, 115},
                new int[] {25, 0, 116},
            },
            new int[][] {
                new int[] {-1, 1, 100},
                new int[] {18, 0, 117},
                new int[] {26, 0, 118},
                new int[] {27, 0, 119},
                new int[] {28, 0, 120},
                new int[] {32, 0, 121},
                new int[] {40, 0, 122},
            },
            new int[][] {
                new int[] {-1, 1, 104},
            },
            new int[][] {
                new int[] {-1, 1, 106},
            },
            new int[][] {
                new int[] {-1, 3, 89},
                new int[] {42, 0, 123},
            },
            new int[][] {
                new int[] {-1, 3, 90},
                new int[] {39, 0, 124},
            },
            new int[][] {
                new int[] {-1, 3, 91},
                new int[] {13, 0, 125},
                new int[] {26, 0, 26},
            },
            new int[][] {
                new int[] {-1, 3, 92},
                new int[] {41, 0, 126},
            },
            new int[][] {
                new int[] {-1, 1, 34},
            },
            new int[][] {
                new int[] {-1, 1, 15},
                new int[] {5, 0, 3},
                new int[] {13, 0, 40},
            },
            new int[][] {
                new int[] {-1, 1, 23},
                new int[] {13, 0, 40},
            },
            new int[][] {
                new int[] {-1, 1, 27},
                new int[] {13, 0, 40},
            },
            new int[][] {
                new int[] {-1, 1, 29},
                new int[] {13, 0, 40},
            },
            new int[][] {
                new int[] {-1, 1, 30},
                new int[] {13, 0, 40},
            },
            new int[][] {
                new int[] {-1, 3, 99},
                new int[] {13, 0, 128},
            },
            new int[][] {
                new int[] {-1, 1, 126},
            },
            new int[][] {
                new int[] {-1, 3, 101},
                new int[] {13, 0, 129},
                new int[] {26, 0, 26},
            },
            new int[][] {
                new int[] {-1, 3, 102},
                new int[] {13, 0, 40},
                new int[] {43, 0, 130},
            },
            new int[][] {
                new int[] {-1, 1, 81},
            },
            new int[][] {
                new int[] {-1, 1, 82},
            },
            new int[][] {
                new int[] {-1, 1, 76},
            },
            new int[][] {
                new int[] {-1, 3, 106},
                new int[] {2, 0, 74},
                new int[] {3, 0, 75},
                new int[] {13, 0, 76},
                new int[] {16, 0, 77},
                new int[] {25, 0, 78},
                new int[] {29, 0, 79},
                new int[] {38, 0, 80},
                new int[] {39, 0, 132},
            },
            new int[][] {
                new int[] {-1, 3, 107},
                new int[] {17, 0, 135},
                new int[] {33, 0, 136},
            },
            new int[][] {
                new int[] {-1, 1, 95},
            },
            new int[][] {
                new int[] {-1, 1, 91},
            },
            new int[][] {
                new int[] {-1, 3, 110},
                new int[] {39, 0, 137},
            },
            new int[][] {
                new int[] {-1, 1, 40},
            },
            new int[][] {
                new int[] {-1, 3, 112},
                new int[] {2, 0, 74},
                new int[] {3, 0, 75},
                new int[] {13, 0, 76},
                new int[] {16, 0, 77},
                new int[] {25, 0, 78},
                new int[] {29, 0, 79},
                new int[] {38, 0, 80},
            },
            new int[][] {
                new int[] {-1, 3, 113},
                new int[] {2, 0, 74},
                new int[] {3, 0, 75},
                new int[] {13, 0, 76},
                new int[] {16, 0, 77},
                new int[] {25, 0, 78},
                new int[] {29, 0, 79},
                new int[] {38, 0, 80},
            },
            new int[][] {
                new int[] {-1, 3, 114},
                new int[] {2, 0, 74},
                new int[] {3, 0, 75},
                new int[] {13, 0, 76},
                new int[] {16, 0, 77},
                new int[] {25, 0, 78},
                new int[] {29, 0, 79},
                new int[] {38, 0, 80},
            },
            new int[][] {
                new int[] {-1, 3, 115},
                new int[] {2, 0, 74},
                new int[] {3, 0, 75},
                new int[] {13, 0, 76},
                new int[] {16, 0, 77},
                new int[] {25, 0, 78},
                new int[] {38, 0, 80},
            },
            new int[][] {
                new int[] {-1, 3, 116},
                new int[] {2, 0, 74},
                new int[] {3, 0, 75},
                new int[] {13, 0, 76},
                new int[] {16, 0, 77},
                new int[] {25, 0, 78},
                new int[] {38, 0, 80},
            },
            new int[][] {
                new int[] {-1, 3, 117},
                new int[] {13, 0, 143},
            },
            new int[][] {
                new int[] {-1, 3, 118},
                new int[] {2, 0, 74},
                new int[] {3, 0, 75},
                new int[] {13, 0, 76},
                new int[] {16, 0, 77},
                new int[] {38, 0, 80},
            },
            new int[][] {
                new int[] {-1, 3, 119},
                new int[] {2, 0, 74},
                new int[] {3, 0, 75},
                new int[] {13, 0, 76},
                new int[] {16, 0, 77},
                new int[] {38, 0, 80},
            },
            new int[][] {
                new int[] {-1, 3, 120},
                new int[] {2, 0, 74},
                new int[] {3, 0, 75},
                new int[] {13, 0, 76},
                new int[] {16, 0, 77},
                new int[] {38, 0, 80},
            },
            new int[][] {
                new int[] {-1, 3, 121},
                new int[] {13, 0, 147},
            },
            new int[][] {
                new int[] {-1, 3, 122},
                new int[] {2, 0, 74},
                new int[] {3, 0, 75},
                new int[] {13, 0, 76},
                new int[] {16, 0, 77},
                new int[] {25, 0, 78},
                new int[] {29, 0, 79},
                new int[] {38, 0, 80},
            },
            new int[][] {
                new int[] {-1, 3, 123},
                new int[] {7, 0, 149},
                new int[] {8, 0, 150},
                new int[] {10, 0, 151},
                new int[] {11, 0, 152},
                new int[] {12, 0, 153},
                new int[] {13, 0, 154},
                new int[] {43, 0, 155},
            },
            new int[][] {
                new int[] {-1, 3, 124},
                new int[] {42, 0, 161},
            },
            new int[][] {
                new int[] {-1, 1, 46},
                new int[] {33, 0, 162},
            },
            new int[][] {
                new int[] {-1, 3, 126},
                new int[] {35, 0, 163},
            },
            new int[][] {
                new int[] {-1, 1, 31},
                new int[] {13, 0, 40},
            },
            new int[][] {
                new int[] {-1, 3, 128},
                new int[] {35, 0, 164},
            },
            new int[][] {
                new int[] {-1, 3, 129},
                new int[] {35, 0, 165},
                new int[] {40, 0, 166},
            },
            new int[][] {
                new int[] {-1, 3, 130},
                new int[] {13, 0, 167},
            },
            new int[][] {
                new int[] {-1, 1, 127},
            },
            new int[][] {
                new int[] {-1, 1, 112},
            },
            new int[][] {
                new int[] {-1, 1, 114},
                new int[] {33, 0, 168},
            },
            new int[][] {
                new int[] {-1, 3, 134},
                new int[] {39, 0, 169},
            },
            new int[][] {
                new int[] {-1, 1, 110},
            },
            new int[][] {
                new int[] {-1, 3, 136},
                new int[] {36, 0, 23},
            },
            new int[][] {
                new int[] {-1, 1, 105},
            },
            new int[][] {
                new int[] {-1, 1, 87},
            },
            new int[][] {
                new int[] {-1, 1, 88},
            },
            new int[][] {
                new int[] {-1, 1, 90},
            },
            new int[][] {
                new int[] {-1, 1, 93},
            },
            new int[][] {
                new int[] {-1, 1, 94},
            },
            new int[][] {
                new int[] {-1, 1, 102},
            },
            new int[][] {
                new int[] {-1, 1, 97},
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
                new int[] {-1, 3, 148},
                new int[] {41, 0, 171},
            },
            new int[][] {
                new int[] {-1, 3, 149},
                new int[] {38, 0, 172},
            },
            new int[][] {
                new int[] {-1, 3, 150},
                new int[] {38, 0, 173},
            },
            new int[][] {
                new int[] {-1, 3, 151},
                new int[] {2, 0, 74},
                new int[] {3, 0, 75},
                new int[] {13, 0, 76},
                new int[] {16, 0, 77},
                new int[] {25, 0, 78},
                new int[] {29, 0, 79},
                new int[] {35, 0, 174},
                new int[] {38, 0, 80},
            },
            new int[][] {
                new int[] {-1, 1, 72},
            },
            new int[][] {
                new int[] {-1, 1, 73},
            },
            new int[][] {
                new int[] {-1, 1, 63},
                new int[] {21, 0, 176},
                new int[] {36, 0, 23},
            },
            new int[][] {
                new int[] {-1, 1, 42},
            },
            new int[][] {
                new int[] {-1, 1, 128},
            },
            new int[][] {
                new int[] {-1, 1, 52},
            },
            new int[][] {
                new int[] {-1, 3, 158},
                new int[] {13, 0, 177},
                new int[] {26, 0, 26},
            },
            new int[][] {
                new int[] {-1, 3, 159},
                new int[] {15, 0, 178},
            },
            new int[][] {
                new int[] {-1, 3, 160},
                new int[] {7, 0, 149},
                new int[] {8, 0, 150},
                new int[] {10, 0, 151},
                new int[] {11, 0, 152},
                new int[] {12, 0, 153},
                new int[] {13, 0, 154},
                new int[] {43, 0, 179},
            },
            new int[][] {
                new int[] {-1, 3, 161},
                new int[] {7, 0, 149},
                new int[] {8, 0, 150},
                new int[] {10, 0, 151},
                new int[] {11, 0, 152},
                new int[] {12, 0, 153},
                new int[] {13, 0, 154},
                new int[] {43, 0, 181},
            },
            new int[][] {
                new int[] {-1, 3, 162},
                new int[] {13, 0, 40},
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
                new int[] {-1, 3, 166},
                new int[] {3, 0, 184},
            },
            new int[][] {
                new int[] {-1, 3, 167},
                new int[] {35, 0, 185},
            },
            new int[][] {
                new int[] {-1, 3, 168},
                new int[] {2, 0, 74},
                new int[] {3, 0, 75},
                new int[] {13, 0, 76},
                new int[] {16, 0, 77},
                new int[] {25, 0, 78},
                new int[] {29, 0, 79},
                new int[] {38, 0, 80},
            },
            new int[][] {
                new int[] {-1, 1, 113},
            },
            new int[][] {
                new int[] {-1, 3, 170},
                new int[] {17, 0, 187},
            },
            new int[][] {
                new int[] {-1, 1, 103},
            },
            new int[][] {
                new int[] {-1, 3, 172},
                new int[] {2, 0, 74},
                new int[] {3, 0, 75},
                new int[] {13, 0, 76},
                new int[] {16, 0, 77},
                new int[] {25, 0, 78},
                new int[] {29, 0, 79},
                new int[] {38, 0, 80},
            },
            new int[][] {
                new int[] {-1, 3, 173},
                new int[] {2, 0, 74},
                new int[] {3, 0, 75},
                new int[] {13, 0, 76},
                new int[] {16, 0, 77},
                new int[] {25, 0, 78},
                new int[] {29, 0, 79},
                new int[] {38, 0, 80},
            },
            new int[][] {
                new int[] {-1, 1, 61},
            },
            new int[][] {
                new int[] {-1, 3, 175},
                new int[] {35, 0, 190},
            },
            new int[][] {
                new int[] {-1, 3, 176},
                new int[] {2, 0, 74},
                new int[] {3, 0, 75},
                new int[] {13, 0, 76},
                new int[] {16, 0, 77},
                new int[] {25, 0, 78},
                new int[] {29, 0, 79},
                new int[] {38, 0, 80},
            },
            new int[][] {
                new int[] {-1, 3, 177},
                new int[] {21, 0, 192},
                new int[] {35, 0, 193},
                new int[] {40, 0, 194},
            },
            new int[][] {
                new int[] {-1, 3, 178},
                new int[] {13, 0, 19},
            },
            new int[][] {
                new int[] {-1, 1, 44},
            },
            new int[][] {
                new int[] {-1, 1, 129},
            },
            new int[][] {
                new int[] {-1, 1, 43},
            },
            new int[][] {
                new int[] {-1, 3, 182},
                new int[] {7, 0, 149},
                new int[] {8, 0, 150},
                new int[] {10, 0, 151},
                new int[] {11, 0, 152},
                new int[] {12, 0, 153},
                new int[] {13, 0, 154},
                new int[] {43, 0, 196},
            },
            new int[][] {
                new int[] {-1, 1, 47},
            },
            new int[][] {
                new int[] {-1, 3, 184},
                new int[] {41, 0, 197},
            },
            new int[][] {
                new int[] {-1, 1, 36},
            },
            new int[][] {
                new int[] {-1, 1, 115},
            },
            new int[][] {
                new int[] {-1, 1, 111},
            },
            new int[][] {
                new int[] {-1, 3, 188},
                new int[] {39, 0, 198},
            },
            new int[][] {
                new int[] {-1, 3, 189},
                new int[] {39, 0, 199},
            },
            new int[][] {
                new int[] {-1, 1, 62},
            },
            new int[][] {
                new int[] {-1, 3, 191},
                new int[] {35, 0, 200},
            },
            new int[][] {
                new int[] {-1, 3, 192},
                new int[] {2, 0, 74},
                new int[] {3, 0, 75},
                new int[] {13, 0, 76},
                new int[] {16, 0, 77},
                new int[] {25, 0, 78},
                new int[] {29, 0, 79},
                new int[] {38, 0, 80},
            },
            new int[][] {
                new int[] {-1, 1, 57},
            },
            new int[][] {
                new int[] {-1, 3, 194},
                new int[] {3, 0, 202},
            },
            new int[][] {
                new int[] {-1, 3, 195},
                new int[] {7, 0, 149},
                new int[] {8, 0, 150},
                new int[] {10, 0, 151},
                new int[] {11, 0, 152},
                new int[] {12, 0, 153},
                new int[] {13, 0, 154},
                new int[] {42, 0, 203},
            },
            new int[][] {
                new int[] {-1, 1, 45},
            },
            new int[][] {
                new int[] {-1, 3, 197},
                new int[] {35, 0, 206},
            },
            new int[][] {
                new int[] {-1, 3, 198},
                new int[] {7, 0, 149},
                new int[] {8, 0, 150},
                new int[] {10, 0, 151},
                new int[] {11, 0, 152},
                new int[] {12, 0, 153},
                new int[] {13, 0, 154},
                new int[] {42, 0, 203},
            },
            new int[][] {
                new int[] {-1, 3, 199},
                new int[] {7, 0, 208},
                new int[] {8, 0, 209},
                new int[] {10, 0, 151},
                new int[] {11, 0, 152},
                new int[] {12, 0, 153},
                new int[] {13, 0, 154},
                new int[] {42, 0, 210},
            },
            new int[][] {
                new int[] {-1, 1, 60},
            },
            new int[][] {
                new int[] {-1, 3, 201},
                new int[] {35, 0, 216},
            },
            new int[][] {
                new int[] {-1, 3, 202},
                new int[] {41, 0, 217},
            },
            new int[][] {
                new int[] {-1, 3, 203},
                new int[] {7, 0, 149},
                new int[] {8, 0, 150},
                new int[] {10, 0, 151},
                new int[] {11, 0, 152},
                new int[] {12, 0, 153},
                new int[] {13, 0, 154},
                new int[] {43, 0, 218},
            },
            new int[][] {
                new int[] {-1, 1, 66},
            },
            new int[][] {
                new int[] {-1, 1, 51},
            },
            new int[][] {
                new int[] {-1, 1, 38},
            },
            new int[][] {
                new int[] {-1, 1, 50},
            },
            new int[][] {
                new int[] {-1, 3, 208},
                new int[] {38, 0, 220},
            },
            new int[][] {
                new int[] {-1, 3, 209},
                new int[] {38, 0, 221},
            },
            new int[][] {
                new int[] {-1, 3, 210},
                new int[] {7, 0, 149},
                new int[] {8, 0, 150},
                new int[] {10, 0, 151},
                new int[] {11, 0, 152},
                new int[] {12, 0, 153},
                new int[] {13, 0, 154},
                new int[] {43, 0, 222},
            },
            new int[][] {
                new int[] {-1, 1, 69},
            },
            new int[][] {
                new int[] {-1, 1, 52},
                new int[] {9, 1, 56},
            },
            new int[][] {
                new int[] {-1, 1, 48},
            },
            new int[][] {
                new int[] {-1, 3, 214},
                new int[] {9, 0, 224},
            },
            new int[][] {
                new int[] {-1, 3, 215},
                new int[] {15, 0, 225},
            },
            new int[][] {
                new int[] {-1, 1, 58},
            },
            new int[][] {
                new int[] {-1, 1, 59},
            },
            new int[][] {
                new int[] {-1, 1, 67},
            },
            new int[][] {
                new int[] {-1, 3, 219},
                new int[] {7, 0, 149},
                new int[] {8, 0, 150},
                new int[] {10, 0, 151},
                new int[] {11, 0, 152},
                new int[] {12, 0, 153},
                new int[] {13, 0, 154},
                new int[] {43, 0, 226},
            },
            new int[][] {
                new int[] {-1, 3, 220},
                new int[] {2, 0, 74},
                new int[] {3, 0, 75},
                new int[] {13, 0, 76},
                new int[] {16, 0, 77},
                new int[] {25, 0, 78},
                new int[] {29, 0, 79},
                new int[] {38, 0, 80},
            },
            new int[][] {
                new int[] {-1, 3, 221},
                new int[] {2, 0, 74},
                new int[] {3, 0, 75},
                new int[] {13, 0, 76},
                new int[] {16, 0, 77},
                new int[] {25, 0, 78},
                new int[] {29, 0, 79},
                new int[] {38, 0, 80},
            },
            new int[][] {
                new int[] {-1, 1, 67},
                new int[] {9, 1, 70},
            },
            new int[][] {
                new int[] {-1, 3, 223},
                new int[] {7, 0, 149},
                new int[] {8, 0, 150},
                new int[] {10, 0, 151},
                new int[] {11, 0, 152},
                new int[] {12, 0, 153},
                new int[] {13, 0, 154},
                new int[] {43, 0, 229},
            },
            new int[][] {
                new int[] {-1, 3, 224},
                new int[] {7, 0, 230},
                new int[] {8, 0, 231},
                new int[] {10, 0, 151},
                new int[] {11, 0, 152},
                new int[] {12, 0, 153},
                new int[] {13, 0, 154},
                new int[] {42, 0, 232},
            },
            new int[][] {
                new int[] {-1, 3, 225},
                new int[] {13, 0, 19},
            },
            new int[][] {
                new int[] {-1, 1, 68},
            },
            new int[][] {
                new int[] {-1, 3, 227},
                new int[] {39, 0, 237},
            },
            new int[][] {
                new int[] {-1, 3, 228},
                new int[] {39, 0, 238},
            },
            new int[][] {
                new int[] {-1, 1, 68},
                new int[] {9, 1, 71},
            },
            new int[][] {
                new int[] {-1, 3, 230},
                new int[] {38, 0, 239},
            },
            new int[][] {
                new int[] {-1, 3, 231},
                new int[] {38, 0, 240},
            },
            new int[][] {
                new int[] {-1, 3, 232},
                new int[] {7, 0, 149},
                new int[] {8, 0, 150},
                new int[] {10, 0, 151},
                new int[] {11, 0, 152},
                new int[] {12, 0, 153},
                new int[] {13, 0, 154},
                new int[] {43, 0, 241},
            },
            new int[][] {
                new int[] {-1, 1, 56},
            },
            new int[][] {
                new int[] {-1, 1, 49},
            },
            new int[][] {
                new int[] {-1, 3, 235},
                new int[] {15, 0, 243},
            },
            new int[][] {
                new int[] {-1, 3, 236},
                new int[] {7, 0, 208},
                new int[] {8, 0, 209},
                new int[] {10, 0, 151},
                new int[] {11, 0, 152},
                new int[] {12, 0, 153},
                new int[] {13, 0, 154},
                new int[] {42, 0, 210},
            },
            new int[][] {
                new int[] {-1, 3, 237},
                new int[] {7, 0, 208},
                new int[] {8, 0, 209},
                new int[] {10, 0, 151},
                new int[] {11, 0, 152},
                new int[] {12, 0, 153},
                new int[] {13, 0, 154},
                new int[] {42, 0, 210},
            },
            new int[][] {
                new int[] {-1, 3, 238},
                new int[] {7, 0, 208},
                new int[] {8, 0, 209},
                new int[] {10, 0, 151},
                new int[] {11, 0, 152},
                new int[] {12, 0, 153},
                new int[] {13, 0, 154},
                new int[] {42, 0, 210},
            },
            new int[][] {
                new int[] {-1, 3, 239},
                new int[] {2, 0, 74},
                new int[] {3, 0, 75},
                new int[] {13, 0, 76},
                new int[] {16, 0, 77},
                new int[] {25, 0, 78},
                new int[] {29, 0, 79},
                new int[] {38, 0, 80},
            },
            new int[][] {
                new int[] {-1, 3, 240},
                new int[] {2, 0, 74},
                new int[] {3, 0, 75},
                new int[] {13, 0, 76},
                new int[] {16, 0, 77},
                new int[] {25, 0, 78},
                new int[] {29, 0, 79},
                new int[] {38, 0, 80},
            },
            new int[][] {
                new int[] {-1, 1, 70},
            },
            new int[][] {
                new int[] {-1, 3, 242},
                new int[] {7, 0, 149},
                new int[] {8, 0, 150},
                new int[] {10, 0, 151},
                new int[] {11, 0, 152},
                new int[] {12, 0, 153},
                new int[] {13, 0, 154},
                new int[] {43, 0, 249},
            },
            new int[][] {
                new int[] {-1, 3, 243},
                new int[] {13, 0, 19},
            },
            new int[][] {
                new int[] {-1, 1, 55},
            },
            new int[][] {
                new int[] {-1, 1, 54},
            },
            new int[][] {
                new int[] {-1, 3, 246},
                new int[] {9, 0, 251},
            },
            new int[][] {
                new int[] {-1, 3, 247},
                new int[] {39, 0, 252},
            },
            new int[][] {
                new int[] {-1, 3, 248},
                new int[] {39, 0, 253},
            },
            new int[][] {
                new int[] {-1, 1, 71},
            },
            new int[][] {
                new int[] {-1, 3, 250},
                new int[] {7, 0, 230},
                new int[] {8, 0, 231},
                new int[] {10, 0, 151},
                new int[] {11, 0, 152},
                new int[] {12, 0, 153},
                new int[] {13, 0, 154},
                new int[] {42, 0, 232},
            },
            new int[][] {
                new int[] {-1, 3, 251},
                new int[] {7, 0, 230},
                new int[] {8, 0, 231},
                new int[] {10, 0, 151},
                new int[] {11, 0, 152},
                new int[] {12, 0, 153},
                new int[] {13, 0, 154},
                new int[] {42, 0, 232},
            },
            new int[][] {
                new int[] {-1, 3, 252},
                new int[] {7, 0, 230},
                new int[] {8, 0, 231},
                new int[] {10, 0, 151},
                new int[] {11, 0, 152},
                new int[] {12, 0, 153},
                new int[] {13, 0, 154},
                new int[] {42, 0, 232},
            },
            new int[][] {
                new int[] {-1, 3, 253},
                new int[] {7, 0, 230},
                new int[] {8, 0, 231},
                new int[] {10, 0, 151},
                new int[] {11, 0, 152},
                new int[] {12, 0, 153},
                new int[] {13, 0, 154},
                new int[] {42, 0, 232},
            },
            new int[][] {
                new int[] {-1, 1, 49},
                new int[] {9, 1, 53},
            },
            new int[][] {
                new int[] {-1, 3, 255},
                new int[] {9, 0, 256},
            },
            new int[][] {
                new int[] {-1, 3, 256},
                new int[] {7, 0, 230},
                new int[] {8, 0, 231},
                new int[] {10, 0, 151},
                new int[] {11, 0, 152},
                new int[] {12, 0, 153},
                new int[] {13, 0, 154},
                new int[] {42, 0, 232},
            },
            new int[][] {
                new int[] {-1, 1, 53},
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
                new int[] {94, 41},
            },
            new int[][] {
                new int[] {-1, 100},
                new int[] {102, 131},
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
                new int[] {95, 43},
                new int[] {96, 43},
                new int[] {97, 43},
                new int[] {98, 43},
                new int[] {127, 43},
            },
            new int[][] {
                new int[] {-1, 90},
                new int[] {162, 183},
            },
            new int[][] {
                new int[] {-1, 204},
                new int[] {123, 156},
                new int[] {160, 180},
                new int[] {161, 156},
                new int[] {182, 180},
                new int[] {203, 156},
                new int[] {210, 156},
                new int[] {219, 180},
                new int[] {223, 180},
                new int[] {232, 156},
                new int[] {242, 180},
            },
            new int[][] {
                new int[] {-1, 211},
            },
            new int[][] {
                new int[] {-1, 157},
                new int[] {199, 212},
                new int[] {224, 233},
                new int[] {236, 212},
                new int[] {237, 212},
                new int[] {238, 212},
                new int[] {250, 233},
                new int[] {251, 233},
                new int[] {252, 233},
                new int[] {253, 233},
                new int[] {256, 233},
            },
            new int[][] {
                new int[] {-1, 11},
                new int[] {55, 91},
                new int[] {69, 101},
                new int[] {102, 101},
                new int[] {123, 158},
                new int[] {160, 158},
                new int[] {161, 158},
                new int[] {162, 91},
                new int[] {182, 158},
                new int[] {195, 158},
                new int[] {198, 158},
                new int[] {199, 158},
                new int[] {203, 158},
                new int[] {210, 158},
                new int[] {219, 158},
                new int[] {223, 158},
                new int[] {224, 158},
                new int[] {232, 158},
                new int[] {236, 158},
                new int[] {237, 158},
                new int[] {238, 158},
                new int[] {242, 158},
                new int[] {250, 158},
                new int[] {251, 158},
                new int[] {252, 158},
                new int[] {253, 158},
                new int[] {256, 158},
            },
            new int[][] {
                new int[] {-1, 205},
                new int[] {198, 207},
                new int[] {199, 213},
                new int[] {237, 207},
                new int[] {238, 213},
            },
            new int[][] {
                new int[] {-1, 244},
                new int[] {199, 214},
                new int[] {224, 234},
                new int[] {237, 245},
                new int[] {238, 246},
                new int[] {251, 254},
                new int[] {252, 245},
                new int[] {253, 255},
                new int[] {256, 257},
            },
            new int[][] {
                new int[] {-1, 159},
                new int[] {199, 215},
                new int[] {224, 235},
                new int[] {236, 215},
                new int[] {237, 215},
                new int[] {238, 215},
                new int[] {250, 235},
                new int[] {251, 235},
                new int[] {252, 235},
                new int[] {253, 235},
                new int[] {256, 235},
            },
            new int[][] {
                new int[] {-1, 24},
                new int[] {136, 170},
            },
            new int[][] {
                new int[] {-1, 50},
            },
            new int[][] {
                new int[] {-1, 51},
                new int[] {70, 103},
                new int[] {71, 104},
            },
            new int[][] {
                new int[] {-1, 12},
                new int[] {2, 20},
                new int[] {23, 52},
                new int[] {27, 20},
                new int[] {44, 20},
                new int[] {70, 52},
                new int[] {71, 52},
                new int[] {73, 20},
                new int[] {178, 20},
                new int[] {225, 20},
                new int[] {243, 20},
            },
            new int[][] {
                new int[] {-1, 21},
                new int[] {27, 57},
                new int[] {44, 68},
                new int[] {73, 105},
                new int[] {178, 195},
                new int[] {225, 236},
                new int[] {243, 250},
            },
            new int[][] {
                new int[] {-1, 133},
                new int[] {53, 81},
                new int[] {80, 110},
                new int[] {122, 148},
                new int[] {151, 175},
                new int[] {172, 188},
                new int[] {173, 189},
                new int[] {176, 191},
                new int[] {192, 201},
                new int[] {220, 227},
                new int[] {221, 228},
                new int[] {239, 247},
                new int[] {240, 248},
            },
            new int[][] {
                new int[] {-1, 82},
                new int[] {112, 138},
                new int[] {113, 139},
            },
            new int[][] {
                new int[] {-1, 83},
                new int[] {114, 140},
            },
            new int[][] {
                new int[] {-1, 84},
                new int[] {79, 109},
                new int[] {115, 141},
                new int[] {116, 142},
            },
            new int[][] {
                new int[] {-1, 85},
                new int[] {78, 108},
                new int[] {118, 144},
                new int[] {119, 145},
                new int[] {120, 146},
            },
            new int[][] {
                new int[] {-1, 86},
            },
            new int[][] {
                new int[] {-1, 87},
            },
            new int[][] {
                new int[] {-1, 88},
            },
            new int[][] {
                new int[] {-1, 134},
                new int[] {168, 186},
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
                new int[] {58, 94},
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
                new int[] {58, 95},
                new int[] {59, 96},
                new int[] {61, 97},
                new int[] {64, 98},
                new int[] {94, 127},
            },
            new int[][] {
                new int[] {-1, 102},
            },
            new int[][] {
                new int[] {-1, 160},
                new int[] {161, 182},
                new int[] {203, 219},
                new int[] {210, 223},
                new int[] {232, 242},
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
            "Expecting: 'while', 'if', 'return', 'this', 'caller', TIdentifier, ',', ';', '}}', '{' or '⊔'",
            "Expecting: ';'",
            "Expecting: TIdentifier, '_' or '^'",
            "Expecting: '=', ';', '(' or '['",
            "Expecting: TIdentifier, '*' or '{{'",
            "Expecting: '{'",
            "Expecting: '->', ';', '}}' or '⊔'",
            "Expecting: ';', '}}' or '⊔'",
            "Expecting: '}}'",
            "Expecting: '->'",
            "Expecting: TBool, TNumber, TIdentifier, '<|', '-', '!' or '('",
            "Expecting: TIdentifier or ')'",
            "Expecting: TNumber",
            "Expecting: 'while', 'if', 'return', 'this', 'caller', TIdentifier, ';', '}}', '{' or '⊔'",
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
            "Expecting: TBool, TNumber, TIdentifier, '<|', '-', '!', '(' or ')'",
            "Expecting: '|>' or ','",
            "Expecting: 'while', 'if', 'return', 'this', 'caller', TIdentifier or '}'",
            "Expecting: ',' or ')'",
            "Expecting: ';' or '['",
            "Expecting: '{{'",
            "Expecting: '('",
            "Expecting: TBool, TNumber, TIdentifier, '<|', '-', '!', ';' or '('",
            "Expecting: TIfActsFor",
            "Expecting: TIdentifier, '=', '*' or '{{'",
            "Expecting: '|>'",
            "Expecting: 'while', 'if', 'else', 'return', 'this', 'caller', TIdentifier or '}'",
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
            7, 8, 8, 8, 24, 25, 13, 13, 26, 27, 28, 28, 29, 2, 30, 31,
            21, 12, 32, 33, 34, 35, 28, 28, 28, 16, 36, 9, 37, 7, 7, 8,
            8, 8, 8, 2, 25, 9, 25, 19, 19, 18, 38, 39, 34, 33, 36, 8,
            21, 21, 21, 31, 31, 2, 30, 30, 30, 2, 21, 40, 16, 41, 12, 8,
            12, 42, 2, 25, 28, 41, 36, 28, 43, 28, 32, 32, 33, 34, 34, 28,
            35, 35, 35, 28, 37, 44, 44, 45, 46, 46, 47, 8, 40, 40, 9, 46,
            40, 40, 2, 8, 7, 25, 23, 12, 21, 28, 48, 28, 21, 21, 49, 12,
            21, 50, 2, 8, 40, 8, 40, 36, 37, 7, 36, 28, 36, 36, 49, 12,
            21, 49, 23, 51, 8, 12, 51, 51, 49, 12, 37, 40, 40, 40, 25, 40,
            44, 44, 40, 49, 49, 40, 52, 46, 49, 49, 40, 40, 21, 21, 49, 40,
            51, 2, 40, 36, 36, 49, 44, 44, 40, 49, 40, 46, 51, 51, 51, 21,
            21, 49, 40, 2, 49, 49, 52, 36, 36, 49, 51, 51, 51, 51, 49, 52,
            51, 49,
        };
        #endregion
    }
}
