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
        private int getIndex(TDeclassifyStart node)
        {
            return 15;
        }
        private int getIndex(TDeclassifyEnd node)
        {
            return 16;
        }
        private int getIndex(TRArrow node)
        {
            return 17;
        }
        private int getIndex(TLArrow node)
        {
            return 18;
        }
        private int getIndex(TCompare node)
        {
            return 19;
        }
        private int getIndex(TAssign node)
        {
            return 20;
        }
        private int getIndex(TUnderscore node)
        {
            return 21;
        }
        private int getIndex(THat node)
        {
            return 22;
        }
        private int getIndex(TPlus node)
        {
            return 23;
        }
        private int getIndex(TMinus node)
        {
            return 24;
        }
        private int getIndex(TAsterisk node)
        {
            return 25;
        }
        private int getIndex(TSlash node)
        {
            return 26;
        }
        private int getIndex(TPercent node)
        {
            return 27;
        }
        private int getIndex(TBang node)
        {
            return 28;
        }
        private int getIndex(TAnd node)
        {
            return 29;
        }
        private int getIndex(TOr node)
        {
            return 30;
        }
        private int getIndex(TPeriod node)
        {
            return 31;
        }
        private int getIndex(TComma node)
        {
            return 32;
        }
        private int getIndex(TColon node)
        {
            return 33;
        }
        private int getIndex(TSemicolon node)
        {
            return 34;
        }
        private int getIndex(TLabelStart node)
        {
            return 35;
        }
        private int getIndex(TLabelEnd node)
        {
            return 36;
        }
        private int getIndex(TLPar node)
        {
            return 37;
        }
        private int getIndex(TRPar node)
        {
            return 38;
        }
        private int getIndex(TLSqu node)
        {
            return 39;
        }
        private int getIndex(TRSqu node)
        {
            return 40;
        }
        private int getIndex(TLCur node)
        {
            return 41;
        }
        private int getIndex(TRCur node)
        {
            return 42;
        }
        private int getIndex(TJoin node)
        {
            return 43;
        }
        
        private int getIndex(EOF node)
        {
            return 44;
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
                        Push(5, aarraydeclarationstatement);
                    }
                    break;
                case 25:
                case 26:
                case 27:
                case 28:
                    {
                        TRCur trcur = Pop<TRCur>();
                        List<PStatement> pstatementlist = isOn(2, index - 25) ? Pop<List<PStatement>>() : new List<PStatement>();
                        TLCur tlcur = Pop<TLCur>();
                        TRPar trpar = Pop<TRPar>();
                        List<PFunctionParameter> pfunctionparameterlist = isOn(1, index - 25) ? Pop<List<PFunctionParameter>>() : new List<PFunctionParameter>();
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
                case 29:
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
                case 30:
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
                case 31:
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
                case 32:
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
                case 33:
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
                case 34:
                    {
                        PStatement pstatement = Pop<PStatement>();
                        Push(7, pstatement);
                    }
                    break;
                case 35:
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
                case 36:
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
                case 37:
                    {
                        PStatement pstatement = Pop<PStatement>();
                        Push(8, pstatement);
                    }
                    break;
                case 38:
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
                case 39:
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
                case 40:
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
                case 41:
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
                case 42:
                case 43:
                    {
                        TSemicolon tsemicolon = Pop<TSemicolon>();
                        PExpression pexpression = isOn(1, index - 42) ? Pop<PExpression>() : null;
                        TReturn treturn = Pop<TReturn>();
                        AReturnStatement areturnstatement = new AReturnStatement(
                            pexpression
                        );
                        Push(9, areturnstatement);
                    }
                    break;
                case 44:
                case 45:
                    {
                        TRCur trcur = Pop<TRCur>();
                        List<PStatement> pstatementlist = isOn(1, index - 44) ? Pop<List<PStatement>>() : new List<PStatement>();
                        TLCur tlcur = Pop<TLCur>();
                        List<PPrincipal> pprincipallist = Pop<List<PPrincipal>>();
                        TActsFor tactsfor = Pop<TActsFor>();
                        PClaimant pclaimant = Pop<PClaimant>();
                        List<PPrincipal> pprincipallist2 = new List<PPrincipal>();
                        pprincipallist2.AddRange(pprincipallist);
                        List<PStatement> pstatementlist2 = new List<PStatement>();
                        pstatementlist2.AddRange(pstatementlist);
                        AActsForStatement aactsforstatement = new AActsForStatement(
                            pclaimant,
                            pprincipallist2,
                            pstatementlist2
                        );
                        Push(9, aactsforstatement);
                    }
                    break;
                case 46:
                case 47:
                    {
                        PLabel plabel = isOn(1, index - 46) ? Pop<PLabel>() : null;
                        TIdentifier tidentifier = Pop<TIdentifier>();
                        AType atype = new AType(
                            tidentifier,
                            plabel
                        );
                        Push(10, atype);
                    }
                    break;
                case 48:
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
                case 49:
                    {
                        PStatement pstatement = Pop<PStatement>();
                        List<PStatement> pstatementlist = new List<PStatement>();
                        pstatementlist.Add(pstatement);
                        Push(11, pstatementlist);
                    }
                    break;
                case 50:
                case 51:
                    {
                        TRCur trcur = Pop<TRCur>();
                        List<PStatement> pstatementlist = isOn(1, index - 50) ? Pop<List<PStatement>>() : new List<PStatement>();
                        TLCur tlcur = Pop<TLCur>();
                        List<PStatement> pstatementlist2 = new List<PStatement>();
                        pstatementlist2.AddRange(pstatementlist);
                        Push(11, pstatementlist2);
                    }
                    break;
                case 52:
                    {
                        PStatement pstatement = Pop<PStatement>();
                        List<PStatement> pstatementlist = new List<PStatement>();
                        pstatementlist.Add(pstatement);
                        Push(12, pstatementlist);
                    }
                    break;
                case 53:
                case 54:
                    {
                        TRCur trcur = Pop<TRCur>();
                        List<PStatement> pstatementlist = isOn(1, index - 53) ? Pop<List<PStatement>>() : new List<PStatement>();
                        TLCur tlcur = Pop<TLCur>();
                        List<PStatement> pstatementlist2 = new List<PStatement>();
                        pstatementlist2.AddRange(pstatementlist);
                        Push(12, pstatementlist2);
                    }
                    break;
                case 55:
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
                case 56:
                    {
                        TIdentifier tidentifier = Pop<TIdentifier>();
                        AVariablePolicy avariablepolicy = new AVariablePolicy(
                            tidentifier
                        );
                        Push(14, avariablepolicy);
                    }
                    break;
                case 57:
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
                case 58:
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
                case 59:
                    {
                        TUnderscore tunderscore = Pop<TUnderscore>();
                        ALowerPolicy alowerpolicy = new ALowerPolicy(
                            tunderscore
                        );
                        Push(14, alowerpolicy);
                    }
                    break;
                case 60:
                    {
                        THat that = Pop<THat>();
                        AUpperPolicy aupperpolicy = new AUpperPolicy(
                            that
                        );
                        Push(14, aupperpolicy);
                    }
                    break;
                case 61:
                    {
                        PPolicy ppolicy = Pop<PPolicy>();
                        List<PPolicy> ppolicylist = new List<PPolicy>();
                        ppolicylist.Add(ppolicy);
                        Push(15, ppolicylist);
                    }
                    break;
                case 62:
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
                case 63:
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
                case 64:
                    {
                        TIdentifier tidentifier = Pop<TIdentifier>();
                        APrincipal aprincipal = new APrincipal(
                            tidentifier
                        );
                        Push(16, aprincipal);
                    }
                    break;
                case 65:
                    {
                        PPrincipal pprincipal = Pop<PPrincipal>();
                        List<PPrincipal> pprincipallist = new List<PPrincipal>();
                        pprincipallist.Add(pprincipal);
                        Push(17, pprincipallist);
                    }
                    break;
                case 66:
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
                case 67:
                    {
                        TThis tthis = Pop<TThis>();
                        AThisClaimant athisclaimant = new AThisClaimant(
                            tthis
                        );
                        Push(18, athisclaimant);
                    }
                    break;
                case 68:
                    {
                        TCaller tcaller = Pop<TCaller>();
                        ACallerClaimant acallerclaimant = new ACallerClaimant(
                            tcaller
                        );
                        Push(18, acallerclaimant);
                    }
                    break;
                case 69:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        Push(19, pexpression);
                    }
                    break;
                case 70:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TAnd tand = Pop<TAnd>();
                        PExpression pexpression2 = Pop<PExpression>();
                        AAndExpression aandexpression = new AAndExpression(
                            pexpression2,
                            pexpression
                        );
                        Push(20, aandexpression);
                    }
                    break;
                case 71:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TOr tor = Pop<TOr>();
                        PExpression pexpression2 = Pop<PExpression>();
                        AOrExpression aorexpression = new AOrExpression(
                            pexpression2,
                            pexpression
                        );
                        Push(20, aorexpression);
                    }
                    break;
                case 72:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        Push(20, pexpression);
                    }
                    break;
                case 73:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TCompare tcompare = Pop<TCompare>();
                        PExpression pexpression2 = Pop<PExpression>();
                        AComparisonExpression acomparisonexpression = new AComparisonExpression(
                            pexpression2,
                            tcompare,
                            pexpression
                        );
                        Push(21, acomparisonexpression);
                    }
                    break;
                case 74:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TBang tbang = Pop<TBang>();
                        ANotExpression anotexpression = new ANotExpression(
                            pexpression
                        );
                        Push(21, anotexpression);
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
                        TPlus tplus = Pop<TPlus>();
                        PExpression pexpression2 = Pop<PExpression>();
                        APlusExpression aplusexpression = new APlusExpression(
                            pexpression2,
                            pexpression
                        );
                        Push(22, aplusexpression);
                    }
                    break;
                case 77:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TMinus tminus = Pop<TMinus>();
                        PExpression pexpression2 = Pop<PExpression>();
                        AMinusExpression aminusexpression = new AMinusExpression(
                            pexpression2,
                            pexpression
                        );
                        Push(22, aminusexpression);
                    }
                    break;
                case 78:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TMinus tminus = Pop<TMinus>();
                        ANegateExpression anegateexpression = new ANegateExpression(
                            pexpression
                        );
                        Push(22, anegateexpression);
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
                        PExpression pexpression = Pop<PExpression>();
                        TAsterisk tasterisk = Pop<TAsterisk>();
                        PExpression pexpression2 = Pop<PExpression>();
                        AMultiplyExpression amultiplyexpression = new AMultiplyExpression(
                            pexpression2,
                            pexpression
                        );
                        Push(23, amultiplyexpression);
                    }
                    break;
                case 81:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TSlash tslash = Pop<TSlash>();
                        PExpression pexpression2 = Pop<PExpression>();
                        ADivideExpression adivideexpression = new ADivideExpression(
                            pexpression2,
                            pexpression
                        );
                        Push(23, adivideexpression);
                    }
                    break;
                case 82:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TPercent tpercent = Pop<TPercent>();
                        PExpression pexpression2 = Pop<PExpression>();
                        AModuloExpression amoduloexpression = new AModuloExpression(
                            pexpression2,
                            pexpression
                        );
                        Push(23, amoduloexpression);
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
                        Push(24, aelementexpression);
                    }
                    break;
                case 85:
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
                        Push(24, aelementexpression);
                    }
                    break;
                case 86:
                    {
                        TRSqu trsqu = Pop<TRSqu>();
                        PExpression pexpression = Pop<PExpression>();
                        TLSqu tlsqu = Pop<TLSqu>();
                        PExpression pexpression2 = Pop<PExpression>();
                        AIndexExpression aindexexpression = new AIndexExpression(
                            pexpression2,
                            pexpression
                        );
                        Push(24, aindexexpression);
                    }
                    break;
                case 87:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        Push(24, pexpression);
                    }
                    break;
                case 88:
                    {
                        TRPar trpar = Pop<TRPar>();
                        PExpression pexpression = Pop<PExpression>();
                        TLPar tlpar = Pop<TLPar>();
                        AParenthesisExpression aparenthesisexpression = new AParenthesisExpression(
                            pexpression
                        );
                        Push(25, aparenthesisexpression);
                    }
                    break;
                case 89:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        Push(25, pexpression);
                    }
                    break;
                case 90:
                    {
                        TNumber tnumber = Pop<TNumber>();
                        ANumberExpression anumberexpression = new ANumberExpression(
                            tnumber
                        );
                        Push(25, anumberexpression);
                    }
                    break;
                case 91:
                    {
                        TBool tbool = Pop<TBool>();
                        ABooleanExpression abooleanexpression = new ABooleanExpression(
                            tbool
                        );
                        Push(25, abooleanexpression);
                    }
                    break;
                case 92:
                    {
                        TIdentifier tidentifier = Pop<TIdentifier>();
                        AIdentifierExpression aidentifierexpression = new AIdentifierExpression(
                            tidentifier
                        );
                        Push(25, aidentifierexpression);
                    }
                    break;
                case 93:
                    {
                        TDeclassifyEnd tdeclassifyend = Pop<TDeclassifyEnd>();
                        TIdentifier tidentifier = Pop<TIdentifier>();
                        TDeclassifyStart tdeclassifystart = Pop<TDeclassifyStart>();
                        ADeclassifyExpression adeclassifyexpression = new ADeclassifyExpression(
                            tidentifier,
                            null
                        );
                        Push(25, adeclassifyexpression);
                    }
                    break;
                case 94:
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
                        Push(25, adeclassifyexpression);
                    }
                    break;
                case 95:
                case 96:
                    {
                        TRPar trpar = Pop<TRPar>();
                        List<PExpression> pexpressionlist = isOn(1, index - 95) ? Pop<List<PExpression>>() : new List<PExpression>();
                        TLPar tlpar = Pop<TLPar>();
                        TIdentifier tidentifier = Pop<TIdentifier>();
                        List<PExpression> pexpressionlist2 = new List<PExpression>();
                        pexpressionlist2.AddRange(pexpressionlist);
                        AFunctionCallExpression afunctioncallexpression = new AFunctionCallExpression(
                            tidentifier,
                            pexpressionlist2
                        );
                        Push(26, afunctioncallexpression);
                    }
                    break;
                case 97:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        List<PExpression> pexpressionlist = new List<PExpression>();
                        pexpressionlist.Add(pexpression);
                        Push(27, pexpressionlist);
                    }
                    break;
                case 98:
                    {
                        List<PExpression> pexpressionlist = Pop<List<PExpression>>();
                        TComma tcomma = Pop<TComma>();
                        PExpression pexpression = Pop<PExpression>();
                        List<PExpression> pexpressionlist2 = new List<PExpression>();
                        pexpressionlist2.Add(pexpression);
                        pexpressionlist2.AddRange(pexpressionlist);
                        Push(27, pexpressionlist2);
                    }
                    break;
                case 99:
                    Push(28, new List<PInclude>() { Pop<PInclude>() });
                    break;
                case 100:
                    {
                        PInclude item = Pop<PInclude>();
                        List<PInclude> list = Pop<List<PInclude>>();
                        list.Add(item);
                        Push(28, list);
                    }
                    break;
                case 101:
                    Push(29, new List<PPrincipalDeclaration>() { Pop<PPrincipalDeclaration>() });
                    break;
                case 102:
                    {
                        PPrincipalDeclaration item = Pop<PPrincipalDeclaration>();
                        List<PPrincipalDeclaration> list = Pop<List<PPrincipalDeclaration>>();
                        list.Add(item);
                        Push(29, list);
                    }
                    break;
                case 103:
                    Push(30, new List<PStruct>() { Pop<PStruct>() });
                    break;
                case 104:
                    {
                        PStruct item = Pop<PStruct>();
                        List<PStruct> list = Pop<List<PStruct>>();
                        list.Add(item);
                        Push(30, list);
                    }
                    break;
                case 105:
                    Push(31, new List<PStatement>() { Pop<PStatement>() });
                    break;
                case 106:
                    {
                        PStatement item = Pop<PStatement>();
                        List<PStatement> list = Pop<List<PStatement>>();
                        list.Add(item);
                        Push(31, list);
                    }
                    break;
                case 107:
                    Push(32, new List<PField>() { Pop<PField>() });
                    break;
                case 108:
                    {
                        PField item = Pop<PField>();
                        List<PField> list = Pop<List<PField>>();
                        list.Add(item);
                        Push(32, list);
                    }
                    break;
                case 109:
                    Push(33, new List<PStatement>() { Pop<PStatement>() });
                    break;
                case 110:
                    {
                        PStatement item = Pop<PStatement>();
                        List<PStatement> list = Pop<List<PStatement>>();
                        list.Add(item);
                        Push(33, list);
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
                new int[] {1, 0, 15},
            },
            new int[][] {
                new int[] {-1, 3, 2},
                new int[] {13, 0, 16},
            },
            new int[][] {
                new int[] {-1, 3, 3},
                new int[] {6, 0, 19},
            },
            new int[][] {
                new int[] {-1, 1, 46},
                new int[] {35, 0, 20},
            },
            new int[][] {
                new int[] {-1, 3, 5},
                new int[] {44, 2, -1},
            },
            new int[][] {
                new int[] {-1, 1, 99},
            },
            new int[][] {
                new int[] {-1, 1, 101},
            },
            new int[][] {
                new int[] {-1, 1, 103},
            },
            new int[][] {
                new int[] {-1, 1, 105},
            },
            new int[][] {
                new int[] {-1, 3, 10},
                new int[] {13, 0, 22},
                new int[] {25, 0, 23},
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
                new int[] {13, 0, 4},
            },
            new int[][] {
                new int[] {-1, 1, 16},
            },
            new int[][] {
                new int[] {-1, 1, 64},
            },
            new int[][] {
                new int[] {-1, 1, 65},
                new int[] {32, 0, 34},
            },
            new int[][] {
                new int[] {-1, 3, 18},
                new int[] {34, 0, 35},
            },
            new int[][] {
                new int[] {-1, 3, 19},
                new int[] {13, 0, 36},
            },
            new int[][] {
                new int[] {-1, 3, 20},
                new int[] {13, 0, 37},
                new int[] {21, 0, 38},
                new int[] {22, 0, 39},
            },
            new int[][] {
                new int[] {-1, 1, 47},
            },
            new int[][] {
                new int[] {-1, 3, 22},
                new int[] {20, 0, 43},
                new int[] {34, 0, 44},
                new int[] {37, 0, 45},
                new int[] {39, 0, 46},
            },
            new int[][] {
                new int[] {-1, 1, 48},
            },
            new int[][] {
                new int[] {-1, 1, 100},
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
                new int[] {13, 0, 4},
            },
            new int[][] {
                new int[] {-1, 1, 102},
            },
            new int[][] {
                new int[] {-1, 1, 6},
                new int[] {5, 0, 3},
                new int[] {13, 0, 4},
            },
            new int[][] {
                new int[] {-1, 1, 10},
                new int[] {13, 0, 4},
            },
            new int[][] {
                new int[] {-1, 1, 104},
            },
            new int[][] {
                new int[] {-1, 1, 12},
                new int[] {13, 0, 4},
            },
            new int[][] {
                new int[] {-1, 1, 106},
            },
            new int[][] {
                new int[] {-1, 3, 34},
                new int[] {13, 0, 16},
            },
            new int[][] {
                new int[] {-1, 1, 17},
            },
            new int[][] {
                new int[] {-1, 3, 36},
                new int[] {41, 0, 52},
            },
            new int[][] {
                new int[] {-1, 1, 56},
                new int[] {17, 1, 64},
            },
            new int[][] {
                new int[] {-1, 1, 59},
            },
            new int[][] {
                new int[] {-1, 1, 60},
            },
            new int[][] {
                new int[] {-1, 1, 61},
                new int[] {34, 0, 53},
                new int[] {43, 0, 54},
            },
            new int[][] {
                new int[] {-1, 3, 41},
                new int[] {36, 0, 55},
            },
            new int[][] {
                new int[] {-1, 3, 42},
                new int[] {17, 0, 56},
            },
            new int[][] {
                new int[] {-1, 3, 43},
                new int[] {2, 0, 57},
                new int[] {3, 0, 58},
                new int[] {13, 0, 59},
                new int[] {15, 0, 60},
                new int[] {24, 0, 61},
                new int[] {28, 0, 62},
                new int[] {37, 0, 63},
            },
            new int[][] {
                new int[] {-1, 1, 22},
            },
            new int[][] {
                new int[] {-1, 3, 45},
                new int[] {13, 0, 4},
                new int[] {38, 0, 72},
            },
            new int[][] {
                new int[] {-1, 3, 46},
                new int[] {3, 0, 75},
            },
            new int[][] {
                new int[] {-1, 1, 7},
                new int[] {5, 0, 3},
                new int[] {13, 0, 4},
            },
            new int[][] {
                new int[] {-1, 1, 11},
                new int[] {13, 0, 4},
            },
            new int[][] {
                new int[] {-1, 1, 13},
                new int[] {13, 0, 4},
            },
            new int[][] {
                new int[] {-1, 1, 14},
                new int[] {13, 0, 4},
            },
            new int[][] {
                new int[] {-1, 1, 66},
            },
            new int[][] {
                new int[] {-1, 3, 52},
                new int[] {13, 0, 4},
                new int[] {42, 0, 77},
            },
            new int[][] {
                new int[] {-1, 3, 53},
                new int[] {13, 0, 37},
                new int[] {21, 0, 38},
                new int[] {22, 0, 39},
            },
            new int[][] {
                new int[] {-1, 3, 54},
                new int[] {13, 0, 37},
                new int[] {21, 0, 38},
                new int[] {22, 0, 39},
            },
            new int[][] {
                new int[] {-1, 1, 55},
            },
            new int[][] {
                new int[] {-1, 1, 58},
                new int[] {13, 0, 16},
            },
            new int[][] {
                new int[] {-1, 1, 91},
            },
            new int[][] {
                new int[] {-1, 1, 90},
            },
            new int[][] {
                new int[] {-1, 1, 92},
                new int[] {37, 0, 84},
            },
            new int[][] {
                new int[] {-1, 3, 60},
                new int[] {13, 0, 85},
            },
            new int[][] {
                new int[] {-1, 3, 61},
                new int[] {2, 0, 57},
                new int[] {3, 0, 58},
                new int[] {13, 0, 59},
                new int[] {15, 0, 60},
                new int[] {37, 0, 63},
            },
            new int[][] {
                new int[] {-1, 3, 62},
                new int[] {2, 0, 57},
                new int[] {3, 0, 58},
                new int[] {13, 0, 59},
                new int[] {15, 0, 60},
                new int[] {24, 0, 61},
                new int[] {37, 0, 63},
            },
            new int[][] {
                new int[] {-1, 3, 63},
                new int[] {2, 0, 57},
                new int[] {3, 0, 58},
                new int[] {13, 0, 59},
                new int[] {15, 0, 60},
                new int[] {24, 0, 61},
                new int[] {28, 0, 62},
                new int[] {37, 0, 63},
            },
            new int[][] {
                new int[] {-1, 3, 64},
                new int[] {34, 0, 89},
            },
            new int[][] {
                new int[] {-1, 1, 69},
            },
            new int[][] {
                new int[] {-1, 1, 72},
                new int[] {29, 0, 90},
                new int[] {30, 0, 91},
            },
            new int[][] {
                new int[] {-1, 1, 75},
                new int[] {19, 0, 92},
            },
            new int[][] {
                new int[] {-1, 1, 79},
                new int[] {23, 0, 93},
                new int[] {24, 0, 94},
            },
            new int[][] {
                new int[] {-1, 1, 83},
                new int[] {17, 0, 95},
                new int[] {25, 0, 96},
                new int[] {26, 0, 97},
                new int[] {27, 0, 98},
                new int[] {31, 0, 99},
                new int[] {39, 0, 100},
            },
            new int[][] {
                new int[] {-1, 1, 87},
            },
            new int[][] {
                new int[] {-1, 1, 89},
            },
            new int[][] {
                new int[] {-1, 3, 72},
                new int[] {41, 0, 101},
            },
            new int[][] {
                new int[] {-1, 3, 73},
                new int[] {38, 0, 102},
            },
            new int[][] {
                new int[] {-1, 3, 74},
                new int[] {13, 0, 103},
                new int[] {25, 0, 23},
            },
            new int[][] {
                new int[] {-1, 3, 75},
                new int[] {40, 0, 104},
            },
            new int[][] {
                new int[] {-1, 1, 15},
                new int[] {13, 0, 4},
            },
            new int[][] {
                new int[] {-1, 3, 77},
                new int[] {13, 0, 105},
            },
            new int[][] {
                new int[] {-1, 1, 107},
            },
            new int[][] {
                new int[] {-1, 3, 79},
                new int[] {13, 0, 106},
                new int[] {25, 0, 23},
            },
            new int[][] {
                new int[] {-1, 3, 80},
                new int[] {13, 0, 4},
                new int[] {42, 0, 107},
            },
            new int[][] {
                new int[] {-1, 1, 62},
            },
            new int[][] {
                new int[] {-1, 1, 63},
            },
            new int[][] {
                new int[] {-1, 1, 57},
            },
            new int[][] {
                new int[] {-1, 3, 84},
                new int[] {2, 0, 57},
                new int[] {3, 0, 58},
                new int[] {13, 0, 59},
                new int[] {15, 0, 60},
                new int[] {24, 0, 61},
                new int[] {28, 0, 62},
                new int[] {37, 0, 63},
                new int[] {38, 0, 109},
            },
            new int[][] {
                new int[] {-1, 3, 85},
                new int[] {16, 0, 112},
                new int[] {32, 0, 113},
            },
            new int[][] {
                new int[] {-1, 1, 78},
            },
            new int[][] {
                new int[] {-1, 1, 74},
            },
            new int[][] {
                new int[] {-1, 3, 88},
                new int[] {38, 0, 114},
            },
            new int[][] {
                new int[] {-1, 1, 23},
            },
            new int[][] {
                new int[] {-1, 3, 90},
                new int[] {2, 0, 57},
                new int[] {3, 0, 58},
                new int[] {13, 0, 59},
                new int[] {15, 0, 60},
                new int[] {24, 0, 61},
                new int[] {28, 0, 62},
                new int[] {37, 0, 63},
            },
            new int[][] {
                new int[] {-1, 3, 91},
                new int[] {2, 0, 57},
                new int[] {3, 0, 58},
                new int[] {13, 0, 59},
                new int[] {15, 0, 60},
                new int[] {24, 0, 61},
                new int[] {28, 0, 62},
                new int[] {37, 0, 63},
            },
            new int[][] {
                new int[] {-1, 3, 92},
                new int[] {2, 0, 57},
                new int[] {3, 0, 58},
                new int[] {13, 0, 59},
                new int[] {15, 0, 60},
                new int[] {24, 0, 61},
                new int[] {28, 0, 62},
                new int[] {37, 0, 63},
            },
            new int[][] {
                new int[] {-1, 3, 93},
                new int[] {2, 0, 57},
                new int[] {3, 0, 58},
                new int[] {13, 0, 59},
                new int[] {15, 0, 60},
                new int[] {24, 0, 61},
                new int[] {37, 0, 63},
            },
            new int[][] {
                new int[] {-1, 3, 94},
                new int[] {2, 0, 57},
                new int[] {3, 0, 58},
                new int[] {13, 0, 59},
                new int[] {15, 0, 60},
                new int[] {24, 0, 61},
                new int[] {37, 0, 63},
            },
            new int[][] {
                new int[] {-1, 3, 95},
                new int[] {13, 0, 120},
            },
            new int[][] {
                new int[] {-1, 3, 96},
                new int[] {2, 0, 57},
                new int[] {3, 0, 58},
                new int[] {13, 0, 59},
                new int[] {15, 0, 60},
                new int[] {37, 0, 63},
            },
            new int[][] {
                new int[] {-1, 3, 97},
                new int[] {2, 0, 57},
                new int[] {3, 0, 58},
                new int[] {13, 0, 59},
                new int[] {15, 0, 60},
                new int[] {37, 0, 63},
            },
            new int[][] {
                new int[] {-1, 3, 98},
                new int[] {2, 0, 57},
                new int[] {3, 0, 58},
                new int[] {13, 0, 59},
                new int[] {15, 0, 60},
                new int[] {37, 0, 63},
            },
            new int[][] {
                new int[] {-1, 3, 99},
                new int[] {13, 0, 124},
            },
            new int[][] {
                new int[] {-1, 3, 100},
                new int[] {2, 0, 57},
                new int[] {3, 0, 58},
                new int[] {13, 0, 59},
                new int[] {15, 0, 60},
                new int[] {24, 0, 61},
                new int[] {28, 0, 62},
                new int[] {37, 0, 63},
            },
            new int[][] {
                new int[] {-1, 3, 101},
                new int[] {7, 0, 126},
                new int[] {8, 0, 127},
                new int[] {10, 0, 128},
                new int[] {11, 0, 129},
                new int[] {12, 0, 130},
                new int[] {13, 0, 131},
                new int[] {42, 0, 132},
            },
            new int[][] {
                new int[] {-1, 3, 102},
                new int[] {41, 0, 138},
            },
            new int[][] {
                new int[] {-1, 1, 29},
                new int[] {32, 0, 139},
            },
            new int[][] {
                new int[] {-1, 3, 104},
                new int[] {34, 0, 140},
            },
            new int[][] {
                new int[] {-1, 3, 105},
                new int[] {34, 0, 141},
            },
            new int[][] {
                new int[] {-1, 3, 106},
                new int[] {34, 0, 142},
                new int[] {39, 0, 143},
            },
            new int[][] {
                new int[] {-1, 3, 107},
                new int[] {13, 0, 144},
            },
            new int[][] {
                new int[] {-1, 1, 108},
            },
            new int[][] {
                new int[] {-1, 1, 95},
            },
            new int[][] {
                new int[] {-1, 1, 97},
                new int[] {32, 0, 145},
            },
            new int[][] {
                new int[] {-1, 3, 111},
                new int[] {38, 0, 146},
            },
            new int[][] {
                new int[] {-1, 1, 93},
            },
            new int[][] {
                new int[] {-1, 3, 113},
                new int[] {35, 0, 20},
            },
            new int[][] {
                new int[] {-1, 1, 88},
            },
            new int[][] {
                new int[] {-1, 1, 70},
            },
            new int[][] {
                new int[] {-1, 1, 71},
            },
            new int[][] {
                new int[] {-1, 1, 73},
            },
            new int[][] {
                new int[] {-1, 1, 76},
            },
            new int[][] {
                new int[] {-1, 1, 77},
            },
            new int[][] {
                new int[] {-1, 1, 85},
            },
            new int[][] {
                new int[] {-1, 1, 80},
            },
            new int[][] {
                new int[] {-1, 1, 81},
            },
            new int[][] {
                new int[] {-1, 1, 82},
            },
            new int[][] {
                new int[] {-1, 1, 84},
            },
            new int[][] {
                new int[] {-1, 3, 125},
                new int[] {40, 0, 148},
            },
            new int[][] {
                new int[] {-1, 3, 126},
                new int[] {37, 0, 149},
            },
            new int[][] {
                new int[] {-1, 3, 127},
                new int[] {37, 0, 150},
            },
            new int[][] {
                new int[] {-1, 3, 128},
                new int[] {2, 0, 57},
                new int[] {3, 0, 58},
                new int[] {13, 0, 59},
                new int[] {15, 0, 60},
                new int[] {24, 0, 61},
                new int[] {28, 0, 62},
                new int[] {34, 0, 151},
                new int[] {37, 0, 63},
            },
            new int[][] {
                new int[] {-1, 1, 67},
            },
            new int[][] {
                new int[] {-1, 1, 68},
            },
            new int[][] {
                new int[] {-1, 1, 46},
                new int[] {20, 0, 153},
                new int[] {35, 0, 20},
            },
            new int[][] {
                new int[] {-1, 1, 25},
            },
            new int[][] {
                new int[] {-1, 1, 109},
            },
            new int[][] {
                new int[] {-1, 1, 34},
            },
            new int[][] {
                new int[] {-1, 3, 135},
                new int[] {13, 0, 154},
                new int[] {25, 0, 23},
            },
            new int[][] {
                new int[] {-1, 3, 136},
                new int[] {14, 0, 155},
            },
            new int[][] {
                new int[] {-1, 3, 137},
                new int[] {7, 0, 126},
                new int[] {8, 0, 127},
                new int[] {10, 0, 128},
                new int[] {11, 0, 129},
                new int[] {12, 0, 130},
                new int[] {13, 0, 131},
                new int[] {42, 0, 156},
            },
            new int[][] {
                new int[] {-1, 3, 138},
                new int[] {7, 0, 126},
                new int[] {8, 0, 127},
                new int[] {10, 0, 128},
                new int[] {11, 0, 129},
                new int[] {12, 0, 130},
                new int[] {13, 0, 131},
                new int[] {42, 0, 158},
            },
            new int[][] {
                new int[] {-1, 3, 139},
                new int[] {13, 0, 4},
            },
            new int[][] {
                new int[] {-1, 1, 24},
            },
            new int[][] {
                new int[] {-1, 1, 18},
            },
            new int[][] {
                new int[] {-1, 1, 20},
            },
            new int[][] {
                new int[] {-1, 3, 143},
                new int[] {3, 0, 161},
            },
            new int[][] {
                new int[] {-1, 3, 144},
                new int[] {34, 0, 162},
            },
            new int[][] {
                new int[] {-1, 3, 145},
                new int[] {2, 0, 57},
                new int[] {3, 0, 58},
                new int[] {13, 0, 59},
                new int[] {15, 0, 60},
                new int[] {24, 0, 61},
                new int[] {28, 0, 62},
                new int[] {37, 0, 63},
            },
            new int[][] {
                new int[] {-1, 1, 96},
            },
            new int[][] {
                new int[] {-1, 3, 147},
                new int[] {16, 0, 164},
            },
            new int[][] {
                new int[] {-1, 1, 86},
            },
            new int[][] {
                new int[] {-1, 3, 149},
                new int[] {2, 0, 57},
                new int[] {3, 0, 58},
                new int[] {13, 0, 59},
                new int[] {15, 0, 60},
                new int[] {24, 0, 61},
                new int[] {28, 0, 62},
                new int[] {37, 0, 63},
            },
            new int[][] {
                new int[] {-1, 3, 150},
                new int[] {2, 0, 57},
                new int[] {3, 0, 58},
                new int[] {13, 0, 59},
                new int[] {15, 0, 60},
                new int[] {24, 0, 61},
                new int[] {28, 0, 62},
                new int[] {37, 0, 63},
            },
            new int[][] {
                new int[] {-1, 1, 42},
            },
            new int[][] {
                new int[] {-1, 3, 152},
                new int[] {34, 0, 167},
            },
            new int[][] {
                new int[] {-1, 3, 153},
                new int[] {2, 0, 57},
                new int[] {3, 0, 58},
                new int[] {13, 0, 59},
                new int[] {15, 0, 60},
                new int[] {24, 0, 61},
                new int[] {28, 0, 62},
                new int[] {37, 0, 63},
            },
            new int[][] {
                new int[] {-1, 3, 154},
                new int[] {20, 0, 169},
                new int[] {34, 0, 170},
                new int[] {39, 0, 171},
            },
            new int[][] {
                new int[] {-1, 3, 155},
                new int[] {13, 0, 16},
            },
            new int[][] {
                new int[] {-1, 1, 27},
            },
            new int[][] {
                new int[] {-1, 1, 110},
            },
            new int[][] {
                new int[] {-1, 1, 26},
            },
            new int[][] {
                new int[] {-1, 3, 159},
                new int[] {7, 0, 126},
                new int[] {8, 0, 127},
                new int[] {10, 0, 128},
                new int[] {11, 0, 129},
                new int[] {12, 0, 130},
                new int[] {13, 0, 131},
                new int[] {42, 0, 173},
            },
            new int[][] {
                new int[] {-1, 1, 30},
            },
            new int[][] {
                new int[] {-1, 3, 161},
                new int[] {40, 0, 174},
            },
            new int[][] {
                new int[] {-1, 1, 19},
            },
            new int[][] {
                new int[] {-1, 1, 98},
            },
            new int[][] {
                new int[] {-1, 1, 94},
            },
            new int[][] {
                new int[] {-1, 3, 165},
                new int[] {38, 0, 175},
            },
            new int[][] {
                new int[] {-1, 3, 166},
                new int[] {38, 0, 176},
            },
            new int[][] {
                new int[] {-1, 1, 43},
            },
            new int[][] {
                new int[] {-1, 3, 168},
                new int[] {34, 0, 177},
            },
            new int[][] {
                new int[] {-1, 3, 169},
                new int[] {2, 0, 57},
                new int[] {3, 0, 58},
                new int[] {13, 0, 59},
                new int[] {15, 0, 60},
                new int[] {24, 0, 61},
                new int[] {28, 0, 62},
                new int[] {37, 0, 63},
            },
            new int[][] {
                new int[] {-1, 1, 38},
            },
            new int[][] {
                new int[] {-1, 3, 171},
                new int[] {3, 0, 179},
            },
            new int[][] {
                new int[] {-1, 3, 172},
                new int[] {41, 0, 180},
            },
            new int[][] {
                new int[] {-1, 1, 28},
            },
            new int[][] {
                new int[] {-1, 3, 174},
                new int[] {34, 0, 181},
            },
            new int[][] {
                new int[] {-1, 3, 175},
                new int[] {7, 0, 126},
                new int[] {8, 0, 127},
                new int[] {10, 0, 128},
                new int[] {11, 0, 129},
                new int[] {12, 0, 130},
                new int[] {13, 0, 131},
                new int[] {41, 0, 182},
            },
            new int[][] {
                new int[] {-1, 3, 176},
                new int[] {7, 0, 185},
                new int[] {8, 0, 186},
                new int[] {10, 0, 128},
                new int[] {11, 0, 129},
                new int[] {12, 0, 130},
                new int[] {13, 0, 131},
                new int[] {41, 0, 187},
            },
            new int[][] {
                new int[] {-1, 1, 41},
            },
            new int[][] {
                new int[] {-1, 3, 178},
                new int[] {34, 0, 192},
            },
            new int[][] {
                new int[] {-1, 3, 179},
                new int[] {40, 0, 193},
            },
            new int[][] {
                new int[] {-1, 3, 180},
                new int[] {7, 0, 126},
                new int[] {8, 0, 127},
                new int[] {10, 0, 128},
                new int[] {11, 0, 129},
                new int[] {12, 0, 130},
                new int[] {13, 0, 131},
                new int[] {42, 0, 194},
            },
            new int[][] {
                new int[] {-1, 1, 21},
            },
            new int[][] {
                new int[] {-1, 3, 182},
                new int[] {7, 0, 126},
                new int[] {8, 0, 127},
                new int[] {10, 0, 128},
                new int[] {11, 0, 129},
                new int[] {12, 0, 130},
                new int[] {13, 0, 131},
                new int[] {42, 0, 196},
            },
            new int[][] {
                new int[] {-1, 1, 49},
            },
            new int[][] {
                new int[] {-1, 1, 33},
            },
            new int[][] {
                new int[] {-1, 3, 185},
                new int[] {37, 0, 198},
            },
            new int[][] {
                new int[] {-1, 3, 186},
                new int[] {37, 0, 199},
            },
            new int[][] {
                new int[] {-1, 3, 187},
                new int[] {7, 0, 126},
                new int[] {8, 0, 127},
                new int[] {10, 0, 128},
                new int[] {11, 0, 129},
                new int[] {12, 0, 130},
                new int[] {13, 0, 131},
                new int[] {42, 0, 200},
            },
            new int[][] {
                new int[] {-1, 1, 52},
            },
            new int[][] {
                new int[] {-1, 1, 34},
                new int[] {9, 1, 37},
            },
            new int[][] {
                new int[] {-1, 1, 31},
            },
            new int[][] {
                new int[] {-1, 3, 191},
                new int[] {9, 0, 202},
            },
            new int[][] {
                new int[] {-1, 1, 39},
            },
            new int[][] {
                new int[] {-1, 1, 40},
            },
            new int[][] {
                new int[] {-1, 1, 44},
            },
            new int[][] {
                new int[] {-1, 3, 195},
                new int[] {7, 0, 126},
                new int[] {8, 0, 127},
                new int[] {10, 0, 128},
                new int[] {11, 0, 129},
                new int[] {12, 0, 130},
                new int[] {13, 0, 131},
                new int[] {42, 0, 203},
            },
            new int[][] {
                new int[] {-1, 1, 50},
            },
            new int[][] {
                new int[] {-1, 3, 197},
                new int[] {7, 0, 126},
                new int[] {8, 0, 127},
                new int[] {10, 0, 128},
                new int[] {11, 0, 129},
                new int[] {12, 0, 130},
                new int[] {13, 0, 131},
                new int[] {42, 0, 204},
            },
            new int[][] {
                new int[] {-1, 3, 198},
                new int[] {2, 0, 57},
                new int[] {3, 0, 58},
                new int[] {13, 0, 59},
                new int[] {15, 0, 60},
                new int[] {24, 0, 61},
                new int[] {28, 0, 62},
                new int[] {37, 0, 63},
            },
            new int[][] {
                new int[] {-1, 3, 199},
                new int[] {2, 0, 57},
                new int[] {3, 0, 58},
                new int[] {13, 0, 59},
                new int[] {15, 0, 60},
                new int[] {24, 0, 61},
                new int[] {28, 0, 62},
                new int[] {37, 0, 63},
            },
            new int[][] {
                new int[] {-1, 1, 50},
                new int[] {9, 1, 53},
            },
            new int[][] {
                new int[] {-1, 3, 201},
                new int[] {7, 0, 126},
                new int[] {8, 0, 127},
                new int[] {10, 0, 128},
                new int[] {11, 0, 129},
                new int[] {12, 0, 130},
                new int[] {13, 0, 131},
                new int[] {42, 0, 207},
            },
            new int[][] {
                new int[] {-1, 3, 202},
                new int[] {7, 0, 208},
                new int[] {8, 0, 209},
                new int[] {10, 0, 128},
                new int[] {11, 0, 129},
                new int[] {12, 0, 130},
                new int[] {13, 0, 131},
                new int[] {41, 0, 210},
            },
            new int[][] {
                new int[] {-1, 1, 45},
            },
            new int[][] {
                new int[] {-1, 1, 51},
            },
            new int[][] {
                new int[] {-1, 3, 205},
                new int[] {38, 0, 213},
            },
            new int[][] {
                new int[] {-1, 3, 206},
                new int[] {38, 0, 214},
            },
            new int[][] {
                new int[] {-1, 1, 51},
                new int[] {9, 1, 54},
            },
            new int[][] {
                new int[] {-1, 3, 208},
                new int[] {37, 0, 215},
            },
            new int[][] {
                new int[] {-1, 3, 209},
                new int[] {37, 0, 216},
            },
            new int[][] {
                new int[] {-1, 3, 210},
                new int[] {7, 0, 126},
                new int[] {8, 0, 127},
                new int[] {10, 0, 128},
                new int[] {11, 0, 129},
                new int[] {12, 0, 130},
                new int[] {13, 0, 131},
                new int[] {42, 0, 217},
            },
            new int[][] {
                new int[] {-1, 1, 37},
            },
            new int[][] {
                new int[] {-1, 1, 32},
            },
            new int[][] {
                new int[] {-1, 3, 213},
                new int[] {7, 0, 185},
                new int[] {8, 0, 186},
                new int[] {10, 0, 128},
                new int[] {11, 0, 129},
                new int[] {12, 0, 130},
                new int[] {13, 0, 131},
                new int[] {41, 0, 187},
            },
            new int[][] {
                new int[] {-1, 3, 214},
                new int[] {7, 0, 185},
                new int[] {8, 0, 186},
                new int[] {10, 0, 128},
                new int[] {11, 0, 129},
                new int[] {12, 0, 130},
                new int[] {13, 0, 131},
                new int[] {41, 0, 187},
            },
            new int[][] {
                new int[] {-1, 3, 215},
                new int[] {2, 0, 57},
                new int[] {3, 0, 58},
                new int[] {13, 0, 59},
                new int[] {15, 0, 60},
                new int[] {24, 0, 61},
                new int[] {28, 0, 62},
                new int[] {37, 0, 63},
            },
            new int[][] {
                new int[] {-1, 3, 216},
                new int[] {2, 0, 57},
                new int[] {3, 0, 58},
                new int[] {13, 0, 59},
                new int[] {15, 0, 60},
                new int[] {24, 0, 61},
                new int[] {28, 0, 62},
                new int[] {37, 0, 63},
            },
            new int[][] {
                new int[] {-1, 1, 53},
            },
            new int[][] {
                new int[] {-1, 3, 218},
                new int[] {7, 0, 126},
                new int[] {8, 0, 127},
                new int[] {10, 0, 128},
                new int[] {11, 0, 129},
                new int[] {12, 0, 130},
                new int[] {13, 0, 131},
                new int[] {42, 0, 223},
            },
            new int[][] {
                new int[] {-1, 1, 36},
            },
            new int[][] {
                new int[] {-1, 3, 220},
                new int[] {9, 0, 224},
            },
            new int[][] {
                new int[] {-1, 3, 221},
                new int[] {38, 0, 225},
            },
            new int[][] {
                new int[] {-1, 3, 222},
                new int[] {38, 0, 226},
            },
            new int[][] {
                new int[] {-1, 1, 54},
            },
            new int[][] {
                new int[] {-1, 3, 224},
                new int[] {7, 0, 208},
                new int[] {8, 0, 209},
                new int[] {10, 0, 128},
                new int[] {11, 0, 129},
                new int[] {12, 0, 130},
                new int[] {13, 0, 131},
                new int[] {41, 0, 210},
            },
            new int[][] {
                new int[] {-1, 3, 225},
                new int[] {7, 0, 208},
                new int[] {8, 0, 209},
                new int[] {10, 0, 128},
                new int[] {11, 0, 129},
                new int[] {12, 0, 130},
                new int[] {13, 0, 131},
                new int[] {41, 0, 210},
            },
            new int[][] {
                new int[] {-1, 3, 226},
                new int[] {7, 0, 208},
                new int[] {8, 0, 209},
                new int[] {10, 0, 128},
                new int[] {11, 0, 129},
                new int[] {12, 0, 130},
                new int[] {13, 0, 131},
                new int[] {41, 0, 210},
            },
            new int[][] {
                new int[] {-1, 1, 32},
                new int[] {9, 1, 35},
            },
            new int[][] {
                new int[] {-1, 3, 228},
                new int[] {9, 0, 229},
            },
            new int[][] {
                new int[] {-1, 3, 229},
                new int[] {7, 0, 208},
                new int[] {8, 0, 209},
                new int[] {10, 0, 128},
                new int[] {11, 0, 129},
                new int[] {12, 0, 130},
                new int[] {13, 0, 131},
                new int[] {41, 0, 210},
            },
            new int[][] {
                new int[] {-1, 1, 35},
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
                new int[] {11, 24},
            },
            new int[][] {
                new int[] {-1, 7},
                new int[] {12, 28},
                new int[] {25, 28},
            },
            new int[][] {
                new int[] {-1, 8},
                new int[] {13, 31},
                new int[] {26, 31},
                new int[] {29, 31},
                new int[] {47, 31},
            },
            new int[][] {
                new int[] {-1, 78},
                new int[] {80, 108},
            },
            new int[][] {
                new int[] {-1, 9},
                new int[] {14, 33},
                new int[] {27, 33},
                new int[] {30, 33},
                new int[] {32, 33},
                new int[] {48, 33},
                new int[] {49, 33},
                new int[] {50, 33},
                new int[] {76, 33},
            },
            new int[][] {
                new int[] {-1, 73},
                new int[] {139, 160},
            },
            new int[][] {
                new int[] {-1, 133},
                new int[] {137, 157},
                new int[] {159, 157},
                new int[] {175, 183},
                new int[] {176, 183},
                new int[] {195, 157},
                new int[] {197, 157},
                new int[] {201, 157},
                new int[] {213, 183},
                new int[] {214, 183},
                new int[] {218, 157},
            },
            new int[][] {
                new int[] {-1, 188},
            },
            new int[][] {
                new int[] {-1, 134},
                new int[] {176, 189},
                new int[] {202, 211},
                new int[] {213, 189},
                new int[] {214, 189},
                new int[] {224, 211},
                new int[] {225, 211},
                new int[] {226, 211},
                new int[] {229, 211},
            },
            new int[][] {
                new int[] {-1, 135},
                new int[] {0, 10},
                new int[] {11, 10},
                new int[] {12, 10},
                new int[] {13, 10},
                new int[] {14, 10},
                new int[] {25, 10},
                new int[] {26, 10},
                new int[] {27, 10},
                new int[] {29, 10},
                new int[] {30, 10},
                new int[] {32, 10},
                new int[] {45, 74},
                new int[] {47, 10},
                new int[] {48, 10},
                new int[] {49, 10},
                new int[] {50, 10},
                new int[] {52, 79},
                new int[] {76, 10},
                new int[] {80, 79},
                new int[] {139, 74},
            },
            new int[][] {
                new int[] {-1, 184},
                new int[] {176, 190},
                new int[] {214, 190},
            },
            new int[][] {
                new int[] {-1, 219},
                new int[] {176, 191},
                new int[] {202, 212},
                new int[] {214, 220},
                new int[] {224, 227},
                new int[] {226, 228},
                new int[] {229, 230},
            },
            new int[][] {
                new int[] {-1, 21},
                new int[] {113, 147},
            },
            new int[][] {
                new int[] {-1, 40},
            },
            new int[][] {
                new int[] {-1, 41},
                new int[] {53, 81},
                new int[] {54, 82},
            },
            new int[][] {
                new int[] {-1, 17},
                new int[] {20, 42},
                new int[] {53, 42},
                new int[] {54, 42},
            },
            new int[][] {
                new int[] {-1, 18},
                new int[] {34, 51},
                new int[] {56, 83},
                new int[] {155, 172},
            },
            new int[][] {
                new int[] {-1, 136},
            },
            new int[][] {
                new int[] {-1, 110},
                new int[] {43, 64},
                new int[] {63, 88},
                new int[] {100, 125},
                new int[] {128, 152},
                new int[] {149, 165},
                new int[] {150, 166},
                new int[] {153, 168},
                new int[] {169, 178},
                new int[] {198, 205},
                new int[] {199, 206},
                new int[] {215, 221},
                new int[] {216, 222},
            },
            new int[][] {
                new int[] {-1, 65},
                new int[] {90, 115},
                new int[] {91, 116},
            },
            new int[][] {
                new int[] {-1, 66},
                new int[] {92, 117},
            },
            new int[][] {
                new int[] {-1, 67},
                new int[] {62, 87},
                new int[] {93, 118},
                new int[] {94, 119},
            },
            new int[][] {
                new int[] {-1, 68},
                new int[] {61, 86},
                new int[] {96, 121},
                new int[] {97, 122},
                new int[] {98, 123},
            },
            new int[][] {
                new int[] {-1, 69},
            },
            new int[][] {
                new int[] {-1, 70},
            },
            new int[][] {
                new int[] {-1, 71},
            },
            new int[][] {
                new int[] {-1, 111},
                new int[] {145, 163},
            },
            new int[][] {
                new int[] {-1, 11},
            },
            new int[][] {
                new int[] {-1, 12},
                new int[] {11, 25},
            },
            new int[][] {
                new int[] {-1, 13},
                new int[] {11, 26},
                new int[] {12, 29},
                new int[] {25, 47},
            },
            new int[][] {
                new int[] {-1, 14},
                new int[] {11, 27},
                new int[] {12, 30},
                new int[] {13, 32},
                new int[] {25, 48},
                new int[] {26, 49},
                new int[] {29, 50},
                new int[] {47, 76},
            },
            new int[][] {
                new int[] {-1, 80},
            },
            new int[][] {
                new int[] {-1, 137},
                new int[] {138, 159},
                new int[] {180, 195},
                new int[] {182, 197},
                new int[] {187, 201},
                new int[] {210, 218},
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
            "Expecting: ',', ';', '}}', '{' or '⊔'",
            "Expecting: ';'",
            "Expecting: TIdentifier, '_' or '^'",
            "Expecting: '=', ';', '(' or '['",
            "Expecting: '{'",
            "Expecting: '->', ';', '}}' or '⊔'",
            "Expecting: ';', '}}' or '⊔'",
            "Expecting: '}}'",
            "Expecting: '->'",
            "Expecting: TBool, TNumber, TIdentifier, '<|', '-', '!' or '('",
            "Expecting: TIdentifier or ')'",
            "Expecting: TNumber",
            "Expecting: ';', '}}', '{' or '⊔'",
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
            "Expecting: TActsFor",
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
            0, 1, 2, 3, 4, 5, 0, 6, 7, 8, 9, 0, 6, 7, 8, 0,
            10, 10, 11, 2, 12, 9, 13, 9, 0, 6, 7, 8, 6, 7, 8, 7,
            8, 8, 2, 6, 14, 15, 16, 16, 16, 17, 18, 19, 8, 20, 21, 7,
            8, 8, 8, 22, 23, 12, 12, 24, 25, 26, 26, 27, 2, 28, 29, 19,
            11, 30, 31, 32, 33, 26, 26, 26, 14, 34, 9, 35, 8, 2, 23, 9,
            23, 17, 17, 16, 36, 37, 32, 31, 34, 8, 19, 19, 19, 29, 29, 2,
            28, 28, 28, 2, 19, 38, 14, 39, 11, 11, 40, 2, 23, 26, 39, 34,
            26, 41, 26, 30, 30, 31, 32, 32, 26, 33, 33, 33, 26, 35, 42, 42,
            43, 44, 44, 45, 8, 38, 38, 9, 44, 38, 38, 2, 8, 7, 23, 21,
            11, 19, 26, 46, 26, 19, 19, 47, 11, 19, 48, 2, 8, 38, 8, 38,
            34, 35, 7, 34, 26, 34, 34, 47, 11, 19, 47, 21, 14, 8, 11, 49,
            49, 47, 11, 35, 38, 23, 38, 38, 38, 42, 42, 38, 47, 47, 38, 50,
            47, 47, 47, 38, 38, 38, 19, 19, 47, 38, 49, 47, 38, 34, 34, 47,
            42, 42, 38, 47, 38, 49, 49, 19, 19, 47, 38, 47, 50, 34, 34, 47,
            49, 49, 49, 47, 50, 49, 47,
        };
        #endregion
    }
}
