using System.Collections.Generic;
using System.Linq;
using SablePP.Tools.Analysis;
using SablePP.Tools.Nodes;
using DLM.Compiler.Nodes;

namespace DLM.Compiler.Analysis
{
    #region Analysis adapters
    
    public partial class AnalysisAdapter : AnalysisAdapter<object>
    {
    }
    public partial class AnalysisAdapter<Value> : Adapter<Value, PRoot>
    {
        public void Visit(PRoot node)
        {
            HandlePRoot(node);
        }
        protected virtual void HandlePRoot(PRoot node)
        {
            dispatch((dynamic)node);
        }
        private void dispatch(ARoot node)
        {
            HandleARoot(node);
        }
        protected virtual void HandleARoot(ARoot node)
        {
            HandleDefault(node);
        }
        
        public void Visit(PPreProcessor node)
        {
            HandlePPreProcessor(node);
        }
        protected virtual void HandlePPreProcessor(PPreProcessor node)
        {
            dispatch((dynamic)node);
        }
        private void dispatch(APreProcessor node)
        {
            HandleAPreProcessor(node);
        }
        protected virtual void HandleAPreProcessor(APreProcessor node)
        {
            HandleDefault(node);
        }
        
        public void Visit(PPrincipalDeclaration node)
        {
            HandlePPrincipalDeclaration(node);
        }
        protected virtual void HandlePPrincipalDeclaration(PPrincipalDeclaration node)
        {
            dispatch((dynamic)node);
        }
        private void dispatch(APrincipalDeclaration node)
        {
            HandleAPrincipalDeclaration(node);
        }
        protected virtual void HandleAPrincipalDeclaration(APrincipalDeclaration node)
        {
            HandleDefault(node);
        }
        
        public void Visit(PPrincipalHierarchyDeclaration node)
        {
            HandlePPrincipalHierarchyDeclaration(node);
        }
        protected virtual void HandlePPrincipalHierarchyDeclaration(PPrincipalHierarchyDeclaration node)
        {
            dispatch((dynamic)node);
        }
        private void dispatch(APrincipalHierarchyDeclaration node)
        {
            HandleAPrincipalHierarchyDeclaration(node);
        }
        protected virtual void HandleAPrincipalHierarchyDeclaration(APrincipalHierarchyDeclaration node)
        {
            HandleDefault(node);
        }
        
        public void Visit(PStruct node)
        {
            HandlePStruct(node);
        }
        protected virtual void HandlePStruct(PStruct node)
        {
            dispatch((dynamic)node);
        }
        private void dispatch(AStruct node)
        {
            HandleAStruct(node);
        }
        protected virtual void HandleAStruct(AStruct node)
        {
            HandleDefault(node);
        }
        
        public void Visit(PField node)
        {
            HandlePField(node);
        }
        protected virtual void HandlePField(PField node)
        {
            dispatch((dynamic)node);
        }
        private void dispatch(AField node)
        {
            HandleAField(node);
        }
        protected virtual void HandleAField(AField node)
        {
            HandleDefault(node);
        }
        private void dispatch(AArrayField node)
        {
            HandleAArrayField(node);
        }
        protected virtual void HandleAArrayField(AArrayField node)
        {
            HandleDefault(node);
        }
        
        public void Visit(PStatement node)
        {
            HandlePStatement(node);
        }
        protected virtual void HandlePStatement(PStatement node)
        {
            dispatch((dynamic)node);
        }
        private void dispatch(ADeclarationStatement node)
        {
            HandleADeclarationStatement(node);
        }
        protected virtual void HandleADeclarationStatement(ADeclarationStatement node)
        {
            HandleDefault(node);
        }
        private void dispatch(AArrayDeclarationStatement node)
        {
            HandleAArrayDeclarationStatement(node);
        }
        protected virtual void HandleAArrayDeclarationStatement(AArrayDeclarationStatement node)
        {
            HandleDefault(node);
        }
        private void dispatch(AAssignmentStatement node)
        {
            HandleAAssignmentStatement(node);
        }
        protected virtual void HandleAAssignmentStatement(AAssignmentStatement node)
        {
            HandleDefault(node);
        }
        private void dispatch(AIfActsForStatement node)
        {
            HandleAIfActsForStatement(node);
        }
        protected virtual void HandleAIfActsForStatement(AIfActsForStatement node)
        {
            HandleDefault(node);
        }
        private void dispatch(AIfActsForElseStatement node)
        {
            HandleAIfActsForElseStatement(node);
        }
        protected virtual void HandleAIfActsForElseStatement(AIfActsForElseStatement node)
        {
            HandleDefault(node);
        }
        private void dispatch(AIfStatement node)
        {
            HandleAIfStatement(node);
        }
        protected virtual void HandleAIfStatement(AIfStatement node)
        {
            HandleDefault(node);
        }
        private void dispatch(AIfElseStatement node)
        {
            HandleAIfElseStatement(node);
        }
        protected virtual void HandleAIfElseStatement(AIfElseStatement node)
        {
            HandleDefault(node);
        }
        private void dispatch(AWhileStatement node)
        {
            HandleAWhileStatement(node);
        }
        protected virtual void HandleAWhileStatement(AWhileStatement node)
        {
            HandleDefault(node);
        }
        private void dispatch(AFunctionDeclarationStatement node)
        {
            HandleAFunctionDeclarationStatement(node);
        }
        protected virtual void HandleAFunctionDeclarationStatement(AFunctionDeclarationStatement node)
        {
            HandleDefault(node);
        }
        private void dispatch(AExpressionStatement node)
        {
            HandleAExpressionStatement(node);
        }
        protected virtual void HandleAExpressionStatement(AExpressionStatement node)
        {
            HandleDefault(node);
        }
        private void dispatch(AReturnStatement node)
        {
            HandleAReturnStatement(node);
        }
        protected virtual void HandleAReturnStatement(AReturnStatement node)
        {
            HandleDefault(node);
        }
        
        public void Visit(PFunctionParameter node)
        {
            HandlePFunctionParameter(node);
        }
        protected virtual void HandlePFunctionParameter(PFunctionParameter node)
        {
            dispatch((dynamic)node);
        }
        private void dispatch(AFunctionParameter node)
        {
            HandleAFunctionParameter(node);
        }
        protected virtual void HandleAFunctionParameter(AFunctionParameter node)
        {
            HandleDefault(node);
        }
        
        public void Visit(PType node)
        {
            HandlePType(node);
        }
        protected virtual void HandlePType(PType node)
        {
            dispatch((dynamic)node);
        }
        private void dispatch(AType node)
        {
            HandleAType(node);
        }
        protected virtual void HandleAType(AType node)
        {
            HandleDefault(node);
        }
        private void dispatch(APointerType node)
        {
            HandleAPointerType(node);
        }
        protected virtual void HandleAPointerType(APointerType node)
        {
            HandleDefault(node);
        }
        
        public void Visit(PClaimant node)
        {
            HandlePClaimant(node);
        }
        protected virtual void HandlePClaimant(PClaimant node)
        {
            dispatch((dynamic)node);
        }
        private void dispatch(AThisClaimant node)
        {
            HandleAThisClaimant(node);
        }
        protected virtual void HandleAThisClaimant(AThisClaimant node)
        {
            HandleDefault(node);
        }
        private void dispatch(ACallerClaimant node)
        {
            HandleACallerClaimant(node);
        }
        protected virtual void HandleACallerClaimant(ACallerClaimant node)
        {
            HandleDefault(node);
        }
        
        public void Visit(PLabel node)
        {
            HandlePLabel(node);
        }
        protected virtual void HandlePLabel(PLabel node)
        {
            dispatch((dynamic)node);
        }
        private void dispatch(ALabel node)
        {
            HandleALabel(node);
        }
        protected virtual void HandleALabel(ALabel node)
        {
            HandleDefault(node);
        }
        
        public void Visit(PTimePolicy node)
        {
            HandlePTimePolicy(node);
        }
        protected virtual void HandlePTimePolicy(PTimePolicy node)
        {
            dispatch((dynamic)node);
        }
        private void dispatch(ATimePolicy node)
        {
            HandleATimePolicy(node);
        }
        protected virtual void HandleATimePolicy(ATimePolicy node)
        {
            HandleDefault(node);
        }
        
        public void Visit(PTimingPeriod node)
        {
            HandlePTimingPeriod(node);
        }
        protected virtual void HandlePTimingPeriod(PTimingPeriod node)
        {
            dispatch((dynamic)node);
        }
        private void dispatch(ATimingPeriod node)
        {
            HandleATimingPeriod(node);
        }
        protected virtual void HandleATimingPeriod(ATimingPeriod node)
        {
            HandleDefault(node);
        }
        
        public void Visit(PTimingInterval node)
        {
            HandlePTimingInterval(node);
        }
        protected virtual void HandlePTimingInterval(PTimingInterval node)
        {
            dispatch((dynamic)node);
        }
        private void dispatch(ATimingInterval node)
        {
            HandleATimingInterval(node);
        }
        protected virtual void HandleATimingInterval(ATimingInterval node)
        {
            HandleDefault(node);
        }
        
        public void Visit(PPolicy node)
        {
            HandlePPolicy(node);
        }
        protected virtual void HandlePPolicy(PPolicy node)
        {
            dispatch((dynamic)node);
        }
        private void dispatch(AVariablePolicy node)
        {
            HandleAVariablePolicy(node);
        }
        protected virtual void HandleAVariablePolicy(AVariablePolicy node)
        {
            HandleDefault(node);
        }
        private void dispatch(APrincipalPolicy node)
        {
            HandleAPrincipalPolicy(node);
        }
        protected virtual void HandleAPrincipalPolicy(APrincipalPolicy node)
        {
            HandleDefault(node);
        }
        private void dispatch(ALowerPolicy node)
        {
            HandleALowerPolicy(node);
        }
        protected virtual void HandleALowerPolicy(ALowerPolicy node)
        {
            HandleDefault(node);
        }
        private void dispatch(AUpperPolicy node)
        {
            HandleAUpperPolicy(node);
        }
        protected virtual void HandleAUpperPolicy(AUpperPolicy node)
        {
            HandleDefault(node);
        }
        
        public void Visit(PPrincipal node)
        {
            HandlePPrincipal(node);
        }
        protected virtual void HandlePPrincipal(PPrincipal node)
        {
            dispatch((dynamic)node);
        }
        private void dispatch(APrincipal node)
        {
            HandleAPrincipal(node);
        }
        protected virtual void HandleAPrincipal(APrincipal node)
        {
            HandleDefault(node);
        }
        
        public void Visit(PExpression node)
        {
            HandlePExpression(node);
        }
        protected virtual void HandlePExpression(PExpression node)
        {
            dispatch((dynamic)node);
        }
        private void dispatch(AAndExpression node)
        {
            HandleAAndExpression(node);
        }
        protected virtual void HandleAAndExpression(AAndExpression node)
        {
            HandleDefault(node);
        }
        private void dispatch(AOrExpression node)
        {
            HandleAOrExpression(node);
        }
        protected virtual void HandleAOrExpression(AOrExpression node)
        {
            HandleDefault(node);
        }
        private void dispatch(ANotExpression node)
        {
            HandleANotExpression(node);
        }
        protected virtual void HandleANotExpression(ANotExpression node)
        {
            HandleDefault(node);
        }
        private void dispatch(AComparisonExpression node)
        {
            HandleAComparisonExpression(node);
        }
        protected virtual void HandleAComparisonExpression(AComparisonExpression node)
        {
            HandleDefault(node);
        }
        private void dispatch(AElementExpression node)
        {
            HandleAElementExpression(node);
        }
        protected virtual void HandleAElementExpression(AElementExpression node)
        {
            HandleDefault(node);
        }
        private void dispatch(AIndexExpression node)
        {
            HandleAIndexExpression(node);
        }
        protected virtual void HandleAIndexExpression(AIndexExpression node)
        {
            HandleDefault(node);
        }
        private void dispatch(APlusExpression node)
        {
            HandleAPlusExpression(node);
        }
        protected virtual void HandleAPlusExpression(APlusExpression node)
        {
            HandleDefault(node);
        }
        private void dispatch(AMinusExpression node)
        {
            HandleAMinusExpression(node);
        }
        protected virtual void HandleAMinusExpression(AMinusExpression node)
        {
            HandleDefault(node);
        }
        private void dispatch(AMultiplyExpression node)
        {
            HandleAMultiplyExpression(node);
        }
        protected virtual void HandleAMultiplyExpression(AMultiplyExpression node)
        {
            HandleDefault(node);
        }
        private void dispatch(ADivideExpression node)
        {
            HandleADivideExpression(node);
        }
        protected virtual void HandleADivideExpression(ADivideExpression node)
        {
            HandleDefault(node);
        }
        private void dispatch(AModuloExpression node)
        {
            HandleAModuloExpression(node);
        }
        protected virtual void HandleAModuloExpression(AModuloExpression node)
        {
            HandleDefault(node);
        }
        private void dispatch(ANegateExpression node)
        {
            HandleANegateExpression(node);
        }
        protected virtual void HandleANegateExpression(ANegateExpression node)
        {
            HandleDefault(node);
        }
        private void dispatch(AFunctionCallExpression node)
        {
            HandleAFunctionCallExpression(node);
        }
        protected virtual void HandleAFunctionCallExpression(AFunctionCallExpression node)
        {
            HandleDefault(node);
        }
        private void dispatch(ATernaryExpression node)
        {
            HandleATernaryExpression(node);
        }
        protected virtual void HandleATernaryExpression(ATernaryExpression node)
        {
            HandleDefault(node);
        }
        private void dispatch(AParenthesisExpression node)
        {
            HandleAParenthesisExpression(node);
        }
        protected virtual void HandleAParenthesisExpression(AParenthesisExpression node)
        {
            HandleDefault(node);
        }
        private void dispatch(ADeclassifyExpression node)
        {
            HandleADeclassifyExpression(node);
        }
        protected virtual void HandleADeclassifyExpression(ADeclassifyExpression node)
        {
            HandleDefault(node);
        }
        private void dispatch(ADereferenceExpression node)
        {
            HandleADereferenceExpression(node);
        }
        protected virtual void HandleADereferenceExpression(ADereferenceExpression node)
        {
            HandleDefault(node);
        }
        private void dispatch(AAddressExpression node)
        {
            HandleAAddressExpression(node);
        }
        protected virtual void HandleAAddressExpression(AAddressExpression node)
        {
            HandleDefault(node);
        }
        private void dispatch(AIdentifierExpression node)
        {
            HandleAIdentifierExpression(node);
        }
        protected virtual void HandleAIdentifierExpression(AIdentifierExpression node)
        {
            HandleDefault(node);
        }
        private void dispatch(ATimeCheckExpression node)
        {
            HandleATimeCheckExpression(node);
        }
        protected virtual void HandleATimeCheckExpression(ATimeCheckExpression node)
        {
            HandleDefault(node);
        }
        private void dispatch(ANumberExpression node)
        {
            HandleANumberExpression(node);
        }
        protected virtual void HandleANumberExpression(ANumberExpression node)
        {
            HandleDefault(node);
        }
        private void dispatch(ABooleanExpression node)
        {
            HandleABooleanExpression(node);
        }
        protected virtual void HandleABooleanExpression(ABooleanExpression node)
        {
            HandleDefault(node);
        }
        private void dispatch(ANullExpression node)
        {
            HandleANullExpression(node);
        }
        protected virtual void HandleANullExpression(ANullExpression node)
        {
            HandleDefault(node);
        }
        private void dispatch(ACharExpression node)
        {
            HandleACharExpression(node);
        }
        protected virtual void HandleACharExpression(ACharExpression node)
        {
            HandleDefault(node);
        }
        private void dispatch(AStringExpression node)
        {
            HandleAStringExpression(node);
        }
        protected virtual void HandleAStringExpression(AStringExpression node)
        {
            HandleDefault(node);
        }
        
        public void Visit(PElement node)
        {
            HandlePElement(node);
        }
        protected virtual void HandlePElement(PElement node)
        {
            dispatch((dynamic)node);
        }
        private void dispatch(AElement node)
        {
            HandleAElement(node);
        }
        protected virtual void HandleAElement(AElement node)
        {
            HandleDefault(node);
        }
        private void dispatch(APointerElement node)
        {
            HandleAPointerElement(node);
        }
        protected virtual void HandleAPointerElement(APointerElement node)
        {
            HandleDefault(node);
        }
        
        public void Visit(TDirective node)
        {
            HandleTDirective(node);
        }
        protected virtual void HandleTDirective(TDirective node)
        {
            HandleDefault(node);
        }
        public void Visit(TTime node)
        {
            HandleTTime(node);
        }
        protected virtual void HandleTTime(TTime node)
        {
            HandleDefault(node);
        }
        public void Visit(TIntervalUnit node)
        {
            HandleTIntervalUnit(node);
        }
        protected virtual void HandleTIntervalUnit(TIntervalUnit node)
        {
            HandleDefault(node);
        }
        public void Visit(TBool node)
        {
            HandleTBool(node);
        }
        protected virtual void HandleTBool(TBool node)
        {
            HandleDefault(node);
        }
        public void Visit(TNumber node)
        {
            HandleTNumber(node);
        }
        protected virtual void HandleTNumber(TNumber node)
        {
            HandleDefault(node);
        }
        public void Visit(TPrincipall node)
        {
            HandleTPrincipall(node);
        }
        protected virtual void HandleTPrincipall(TPrincipall node)
        {
            HandleDefault(node);
        }
        public void Visit(TTypedef node)
        {
            HandleTTypedef(node);
        }
        protected virtual void HandleTTypedef(TTypedef node)
        {
            HandleDefault(node);
        }
        public void Visit(TStruct node)
        {
            HandleTStruct(node);
        }
        protected virtual void HandleTStruct(TStruct node)
        {
            HandleDefault(node);
        }
        public void Visit(TWhile node)
        {
            HandleTWhile(node);
        }
        protected virtual void HandleTWhile(TWhile node)
        {
            HandleDefault(node);
        }
        public void Visit(TIf node)
        {
            HandleTIf(node);
        }
        protected virtual void HandleTIf(TIf node)
        {
            HandleDefault(node);
        }
        public void Visit(TElse node)
        {
            HandleTElse(node);
        }
        protected virtual void HandleTElse(TElse node)
        {
            HandleDefault(node);
        }
        public void Visit(TReturn node)
        {
            HandleTReturn(node);
        }
        protected virtual void HandleTReturn(TReturn node)
        {
            HandleDefault(node);
        }
        public void Visit(TThis node)
        {
            HandleTThis(node);
        }
        protected virtual void HandleTThis(TThis node)
        {
            HandleDefault(node);
        }
        public void Visit(TCaller node)
        {
            HandleTCaller(node);
        }
        protected virtual void HandleTCaller(TCaller node)
        {
            HandleDefault(node);
        }
        public void Visit(TNull node)
        {
            HandleTNull(node);
        }
        protected virtual void HandleTNull(TNull node)
        {
            HandleDefault(node);
        }
        public void Visit(TChar node)
        {
            HandleTChar(node);
        }
        protected virtual void HandleTChar(TChar node)
        {
            HandleDefault(node);
        }
        public void Visit(TCharErr node)
        {
            HandleTCharErr(node);
        }
        protected virtual void HandleTCharErr(TCharErr node)
        {
            HandleDefault(node);
        }
        public void Visit(TString node)
        {
            HandleTString(node);
        }
        protected virtual void HandleTString(TString node)
        {
            HandleDefault(node);
        }
        public void Visit(TStringErr node)
        {
            HandleTStringErr(node);
        }
        protected virtual void HandleTStringErr(TStringErr node)
        {
            HandleDefault(node);
        }
        public void Visit(TIdentifier node)
        {
            HandleTIdentifier(node);
        }
        protected virtual void HandleTIdentifier(TIdentifier node)
        {
            HandleDefault(node);
        }
        public void Visit(TActsFor node)
        {
            HandleTActsFor(node);
        }
        protected virtual void HandleTActsFor(TActsFor node)
        {
            HandleDefault(node);
        }
        public void Visit(TIfActsFor node)
        {
            HandleTIfActsFor(node);
        }
        protected virtual void HandleTIfActsFor(TIfActsFor node)
        {
            HandleDefault(node);
        }
        public void Visit(TDeclassifyStart node)
        {
            HandleTDeclassifyStart(node);
        }
        protected virtual void HandleTDeclassifyStart(TDeclassifyStart node)
        {
            HandleDefault(node);
        }
        public void Visit(TDeclassifyEnd node)
        {
            HandleTDeclassifyEnd(node);
        }
        protected virtual void HandleTDeclassifyEnd(TDeclassifyEnd node)
        {
            HandleDefault(node);
        }
        public void Visit(TFuncAuthStart node)
        {
            HandleTFuncAuthStart(node);
        }
        protected virtual void HandleTFuncAuthStart(TFuncAuthStart node)
        {
            HandleDefault(node);
        }
        public void Visit(TFuncAuthEnd node)
        {
            HandleTFuncAuthEnd(node);
        }
        protected virtual void HandleTFuncAuthEnd(TFuncAuthEnd node)
        {
            HandleDefault(node);
        }
        public void Visit(TRArrow node)
        {
            HandleTRArrow(node);
        }
        protected virtual void HandleTRArrow(TRArrow node)
        {
            HandleDefault(node);
        }
        public void Visit(TLArrow node)
        {
            HandleTLArrow(node);
        }
        protected virtual void HandleTLArrow(TLArrow node)
        {
            HandleDefault(node);
        }
        public void Visit(TCompare node)
        {
            HandleTCompare(node);
        }
        protected virtual void HandleTCompare(TCompare node)
        {
            HandleDefault(node);
        }
        public void Visit(TAssign node)
        {
            HandleTAssign(node);
        }
        protected virtual void HandleTAssign(TAssign node)
        {
            HandleDefault(node);
        }
        public void Visit(TUnderscore node)
        {
            HandleTUnderscore(node);
        }
        protected virtual void HandleTUnderscore(TUnderscore node)
        {
            HandleDefault(node);
        }
        public void Visit(THat node)
        {
            HandleTHat(node);
        }
        protected virtual void HandleTHat(THat node)
        {
            HandleDefault(node);
        }
        public void Visit(TPlus node)
        {
            HandleTPlus(node);
        }
        protected virtual void HandleTPlus(TPlus node)
        {
            HandleDefault(node);
        }
        public void Visit(TMinus node)
        {
            HandleTMinus(node);
        }
        protected virtual void HandleTMinus(TMinus node)
        {
            HandleDefault(node);
        }
        public void Visit(TAsterisk node)
        {
            HandleTAsterisk(node);
        }
        protected virtual void HandleTAsterisk(TAsterisk node)
        {
            HandleDefault(node);
        }
        public void Visit(TSlash node)
        {
            HandleTSlash(node);
        }
        protected virtual void HandleTSlash(TSlash node)
        {
            HandleDefault(node);
        }
        public void Visit(TPercent node)
        {
            HandleTPercent(node);
        }
        protected virtual void HandleTPercent(TPercent node)
        {
            HandleDefault(node);
        }
        public void Visit(TAmpersand node)
        {
            HandleTAmpersand(node);
        }
        protected virtual void HandleTAmpersand(TAmpersand node)
        {
            HandleDefault(node);
        }
        public void Visit(TBang node)
        {
            HandleTBang(node);
        }
        protected virtual void HandleTBang(TBang node)
        {
            HandleDefault(node);
        }
        public void Visit(TAnd node)
        {
            HandleTAnd(node);
        }
        protected virtual void HandleTAnd(TAnd node)
        {
            HandleDefault(node);
        }
        public void Visit(TOr node)
        {
            HandleTOr(node);
        }
        protected virtual void HandleTOr(TOr node)
        {
            HandleDefault(node);
        }
        public void Visit(TQuestion node)
        {
            HandleTQuestion(node);
        }
        protected virtual void HandleTQuestion(TQuestion node)
        {
            HandleDefault(node);
        }
        public void Visit(TPeriod node)
        {
            HandleTPeriod(node);
        }
        protected virtual void HandleTPeriod(TPeriod node)
        {
            HandleDefault(node);
        }
        public void Visit(TComma node)
        {
            HandleTComma(node);
        }
        protected virtual void HandleTComma(TComma node)
        {
            HandleDefault(node);
        }
        public void Visit(TColon node)
        {
            HandleTColon(node);
        }
        protected virtual void HandleTColon(TColon node)
        {
            HandleDefault(node);
        }
        public void Visit(TSemicolon node)
        {
            HandleTSemicolon(node);
        }
        protected virtual void HandleTSemicolon(TSemicolon node)
        {
            HandleDefault(node);
        }
        public void Visit(TLabelStart node)
        {
            HandleTLabelStart(node);
        }
        protected virtual void HandleTLabelStart(TLabelStart node)
        {
            HandleDefault(node);
        }
        public void Visit(TTimeStart node)
        {
            HandleTTimeStart(node);
        }
        protected virtual void HandleTTimeStart(TTimeStart node)
        {
            HandleDefault(node);
        }
        public void Visit(TLabelEnd node)
        {
            HandleTLabelEnd(node);
        }
        protected virtual void HandleTLabelEnd(TLabelEnd node)
        {
            HandleDefault(node);
        }
        public void Visit(TTimeCall node)
        {
            HandleTTimeCall(node);
        }
        protected virtual void HandleTTimeCall(TTimeCall node)
        {
            HandleDefault(node);
        }
        public void Visit(TTimeCheck node)
        {
            HandleTTimeCheck(node);
        }
        protected virtual void HandleTTimeCheck(TTimeCheck node)
        {
            HandleDefault(node);
        }
        public void Visit(TLPar node)
        {
            HandleTLPar(node);
        }
        protected virtual void HandleTLPar(TLPar node)
        {
            HandleDefault(node);
        }
        public void Visit(TRPar node)
        {
            HandleTRPar(node);
        }
        protected virtual void HandleTRPar(TRPar node)
        {
            HandleDefault(node);
        }
        public void Visit(TLSqu node)
        {
            HandleTLSqu(node);
        }
        protected virtual void HandleTLSqu(TLSqu node)
        {
            HandleDefault(node);
        }
        public void Visit(TRSqu node)
        {
            HandleTRSqu(node);
        }
        protected virtual void HandleTRSqu(TRSqu node)
        {
            HandleDefault(node);
        }
        public void Visit(TLCur node)
        {
            HandleTLCur(node);
        }
        protected virtual void HandleTLCur(TLCur node)
        {
            HandleDefault(node);
        }
        public void Visit(TRCur node)
        {
            HandleTRCur(node);
        }
        protected virtual void HandleTRCur(TRCur node)
        {
            HandleDefault(node);
        }
        public void Visit(TJoin node)
        {
            HandleTJoin(node);
        }
        protected virtual void HandleTJoin(TJoin node)
        {
            HandleDefault(node);
        }
        public void Visit(TComment node)
        {
            HandleTComment(node);
        }
        protected virtual void HandleTComment(TComment node)
        {
            HandleDefault(node);
        }
        public void Visit(TWhitespace node)
        {
            HandleTWhitespace(node);
        }
        protected virtual void HandleTWhitespace(TWhitespace node)
        {
            HandleDefault(node);
        }
    }
    
    public partial class DepthFirstAdapter : DepthFirstAdapter<object>
    {
    }
    public partial class DepthFirstAdapter<Value> : AnalysisAdapter<Value>
    {
        public void Visit<Element>(IEnumerable<Element> elements) where Element : Node
        {
            Element[] temp = elements.ToArray();
            for (int i = 0; i < temp.Length; i++)
                Visit((dynamic)temp[i]);
        }
        
        protected override void HandleStart(Start<PRoot> node)
        {
            Visit(node.Root);
            Visit(node.EOF);
        }
        
        protected override void HandleARoot(ARoot node)
        {
            Visit(node.PreProcessors);
            Visit(node.PrincipalDeclarations);
            Visit(node.PrincipalHierarchyDeclarations);
            Visit(node.Structs);
            Visit(node.Statements);
        }
        protected override void HandleAPreProcessor(APreProcessor node)
        {
            Visit(node.Directive);
        }
        protected override void HandleAPrincipalDeclaration(APrincipalDeclaration node)
        {
            Visit(node.Principals);
        }
        protected override void HandleAPrincipalHierarchyDeclaration(APrincipalHierarchyDeclaration node)
        {
            Visit(node.Principal);
            Visit(node.Subordinates);
        }
        protected override void HandleAStruct(AStruct node)
        {
            Visit(node.Identifier);
            Visit(node.Fields);
            Visit(node.Name);
        }
        protected override void HandleAField(AField node)
        {
            Visit(node.Type);
            Visit(node.Identifier);
        }
        protected override void HandleAArrayField(AArrayField node)
        {
            Visit(node.Type);
            Visit(node.Identifier);
            Visit(node.Size);
        }
        protected override void HandleADeclarationStatement(ADeclarationStatement node)
        {
            Visit(node.Type);
            Visit(node.Identifier);
            if (node.HasExpression)
                Visit(node.Expression);
        }
        protected override void HandleAArrayDeclarationStatement(AArrayDeclarationStatement node)
        {
            Visit(node.Type);
            Visit(node.Identifier);
            Visit(node.Size);
        }
        protected override void HandleAAssignmentStatement(AAssignmentStatement node)
        {
            Visit(node.Identifier);
            Visit(node.Expression);
        }
        protected override void HandleAIfActsForStatement(AIfActsForStatement node)
        {
            Visit(node.Claimant);
            Visit(node.Principals);
            Visit(node.Statements);
        }
        protected override void HandleAIfActsForElseStatement(AIfActsForElseStatement node)
        {
            Visit(node.Claimant);
            Visit(node.Principals);
            Visit(node.IfStatements);
            Visit(node.ElseStatements);
        }
        protected override void HandleAIfStatement(AIfStatement node)
        {
            Visit(node.If);
            Visit(node.Expression);
            Visit(node.Statements);
        }
        protected override void HandleAIfElseStatement(AIfElseStatement node)
        {
            Visit(node.If);
            Visit(node.Expression);
            Visit(node.IfStatements);
            Visit(node.ElseStatements);
        }
        protected override void HandleAWhileStatement(AWhileStatement node)
        {
            Visit(node.While);
            Visit(node.Expression);
            Visit(node.Statements);
        }
        protected override void HandleAFunctionDeclarationStatement(AFunctionDeclarationStatement node)
        {
            Visit(node.Readers);
            Visit(node.Type);
            Visit(node.Identifier);
            Visit(node.Parameters);
            Visit(node.Statements);
        }
        protected override void HandleAExpressionStatement(AExpressionStatement node)
        {
            Visit(node.Expression);
        }
        protected override void HandleAReturnStatement(AReturnStatement node)
        {
            Visit(node.Return);
            if (node.HasExpression)
                Visit(node.Expression);
        }
        protected override void HandleAFunctionParameter(AFunctionParameter node)
        {
            Visit(node.Type);
            Visit(node.Identifier);
        }
        protected override void HandleAType(AType node)
        {
            Visit(node.Name);
            if (node.HasLabel)
                Visit(node.Label);
        }
        protected override void HandleAPointerType(APointerType node)
        {
            Visit(node.Type);
            Visit(node.Asterisk);
        }
        protected override void HandleAThisClaimant(AThisClaimant node)
        {
            Visit(node.This);
        }
        protected override void HandleACallerClaimant(ACallerClaimant node)
        {
            Visit(node.Caller);
        }
        protected override void HandleALabel(ALabel node)
        {
            Visit(node.Policys);
            Visit(node.TimePolicies);
        }
        protected override void HandleATimePolicy(ATimePolicy node)
        {
            if (node.HasPrincipal)
                Visit(node.Principal);
            if (node.HasPeriod)
                Visit(node.Period);
            Visit(node.Interval);
            if (node.HasCount)
                Visit(node.Count);
        }
        protected override void HandleATimingPeriod(ATimingPeriod node)
        {
            Visit(node.From);
            Visit(node.To);
        }
        protected override void HandleATimingInterval(ATimingInterval node)
        {
            Visit(node.Number);
            Visit(node.Unit);
        }
        protected override void HandleAVariablePolicy(AVariablePolicy node)
        {
            Visit(node.Identifier);
        }
        protected override void HandleAPrincipalPolicy(APrincipalPolicy node)
        {
            Visit(node.Owner);
            Visit(node.Readers);
        }
        protected override void HandleALowerPolicy(ALowerPolicy node)
        {
            Visit(node.Underscore);
        }
        protected override void HandleAUpperPolicy(AUpperPolicy node)
        {
            Visit(node.Hat);
        }
        protected override void HandleAPrincipal(APrincipal node)
        {
            Visit(node.Identifier);
        }
        protected override void HandleAAndExpression(AAndExpression node)
        {
            Visit(node.Left);
            Visit(node.And);
            Visit(node.Right);
        }
        protected override void HandleAOrExpression(AOrExpression node)
        {
            Visit(node.Left);
            Visit(node.Or);
            Visit(node.Right);
        }
        protected override void HandleANotExpression(ANotExpression node)
        {
            Visit(node.Bang);
            Visit(node.Expression);
        }
        protected override void HandleAComparisonExpression(AComparisonExpression node)
        {
            Visit(node.Left);
            Visit(node.Compare);
            Visit(node.Right);
        }
        protected override void HandleAElementExpression(AElementExpression node)
        {
            Visit(node.Expression);
            Visit(node.Element);
        }
        protected override void HandleAIndexExpression(AIndexExpression node)
        {
            Visit(node.Expression);
            Visit(node.LeftPar);
            Visit(node.Index);
            Visit(node.RightPar);
        }
        protected override void HandleAPlusExpression(APlusExpression node)
        {
            Visit(node.Left);
            Visit(node.Plus);
            Visit(node.Right);
        }
        protected override void HandleAMinusExpression(AMinusExpression node)
        {
            Visit(node.Left);
            Visit(node.Minus);
            Visit(node.Right);
        }
        protected override void HandleAMultiplyExpression(AMultiplyExpression node)
        {
            Visit(node.Left);
            Visit(node.Asterisk);
            Visit(node.Right);
        }
        protected override void HandleADivideExpression(ADivideExpression node)
        {
            Visit(node.Left);
            Visit(node.Slash);
            Visit(node.Right);
        }
        protected override void HandleAModuloExpression(AModuloExpression node)
        {
            Visit(node.Left);
            Visit(node.Percent);
            Visit(node.Right);
        }
        protected override void HandleANegateExpression(ANegateExpression node)
        {
            Visit(node.Minus);
            Visit(node.Expression);
        }
        protected override void HandleAFunctionCallExpression(AFunctionCallExpression node)
        {
            if (node.HasTimeCall)
                Visit(node.TimeCall);
            Visit(node.Function);
            Visit(node.Authorities);
            Visit(node.LeftPar);
            Visit(node.Arguments);
            Visit(node.RightPar);
        }
        protected override void HandleATernaryExpression(ATernaryExpression node)
        {
            Visit(node.Condition);
            Visit(node.Question);
            Visit(node.True);
            Visit(node.Colon);
            Visit(node.False);
        }
        protected override void HandleAParenthesisExpression(AParenthesisExpression node)
        {
            Visit(node.LeftPar);
            Visit(node.Expression);
            Visit(node.RightPar);
        }
        protected override void HandleADeclassifyExpression(ADeclassifyExpression node)
        {
            Visit(node.DeclassifyStart);
            Visit(node.Expression);
            if (node.HasLabel)
                Visit(node.Label);
            Visit(node.DeclassifyEnd);
        }
        protected override void HandleADereferenceExpression(ADereferenceExpression node)
        {
            Visit(node.Asterisk);
            Visit(node.Expression);
        }
        protected override void HandleAAddressExpression(AAddressExpression node)
        {
            Visit(node.Ampersand);
            Visit(node.Expression);
        }
        protected override void HandleAIdentifierExpression(AIdentifierExpression node)
        {
            Visit(node.Identifier);
        }
        protected override void HandleATimeCheckExpression(ATimeCheckExpression node)
        {
            Visit(node.TimeCheck);
            Visit(node.Function);
        }
        protected override void HandleANumberExpression(ANumberExpression node)
        {
            Visit(node.Number);
        }
        protected override void HandleABooleanExpression(ABooleanExpression node)
        {
            Visit(node.Bool);
        }
        protected override void HandleANullExpression(ANullExpression node)
        {
            Visit(node.Null);
        }
        protected override void HandleACharExpression(ACharExpression node)
        {
            Visit(node.Char);
        }
        protected override void HandleAStringExpression(AStringExpression node)
        {
            Visit(node.String);
        }
        protected override void HandleAElement(AElement node)
        {
            Visit(node.Period);
            Visit(node.Identifier);
        }
        protected override void HandleAPointerElement(APointerElement node)
        {
            Visit(node.Arrow);
            Visit(node.Identifier);
        }
    }
    
    public partial class ReverseDepthFirstAdapter : ReverseDepthFirstAdapter<object>
    {
    }
    public partial class ReverseDepthFirstAdapter<Value> : AnalysisAdapter<Value>
    {
        public void Visit<Element>(IEnumerable<Element> elements) where Element : Node
        {
            Element[] temp = elements.ToArray();
            for (int i = temp.Length - 1; i >= 0; i--)
                Visit((dynamic)temp[i]);
        }
        
        protected override void HandleStart(Start<PRoot> node)
        {
            Visit(node.EOF);
            Visit(node.Root);
        }
        
        protected override void HandleARoot(ARoot node)
        {
            Visit(node.Statements);
            Visit(node.Structs);
            Visit(node.PrincipalHierarchyDeclarations);
            Visit(node.PrincipalDeclarations);
            Visit(node.PreProcessors);
        }
        protected override void HandleAPreProcessor(APreProcessor node)
        {
            Visit(node.Directive);
        }
        protected override void HandleAPrincipalDeclaration(APrincipalDeclaration node)
        {
            Visit(node.Principals);
        }
        protected override void HandleAPrincipalHierarchyDeclaration(APrincipalHierarchyDeclaration node)
        {
            Visit(node.Subordinates);
            Visit(node.Principal);
        }
        protected override void HandleAStruct(AStruct node)
        {
            Visit(node.Name);
            Visit(node.Fields);
            Visit(node.Identifier);
        }
        protected override void HandleAField(AField node)
        {
            Visit(node.Identifier);
            Visit(node.Type);
        }
        protected override void HandleAArrayField(AArrayField node)
        {
            Visit(node.Size);
            Visit(node.Identifier);
            Visit(node.Type);
        }
        protected override void HandleADeclarationStatement(ADeclarationStatement node)
        {
            if (node.HasExpression)
                Visit(node.Expression);
            Visit(node.Identifier);
            Visit(node.Type);
        }
        protected override void HandleAArrayDeclarationStatement(AArrayDeclarationStatement node)
        {
            Visit(node.Size);
            Visit(node.Identifier);
            Visit(node.Type);
        }
        protected override void HandleAAssignmentStatement(AAssignmentStatement node)
        {
            Visit(node.Expression);
            Visit(node.Identifier);
        }
        protected override void HandleAIfActsForStatement(AIfActsForStatement node)
        {
            Visit(node.Statements);
            Visit(node.Principals);
            Visit(node.Claimant);
        }
        protected override void HandleAIfActsForElseStatement(AIfActsForElseStatement node)
        {
            Visit(node.ElseStatements);
            Visit(node.IfStatements);
            Visit(node.Principals);
            Visit(node.Claimant);
        }
        protected override void HandleAIfStatement(AIfStatement node)
        {
            Visit(node.Statements);
            Visit(node.Expression);
            Visit(node.If);
        }
        protected override void HandleAIfElseStatement(AIfElseStatement node)
        {
            Visit(node.ElseStatements);
            Visit(node.IfStatements);
            Visit(node.Expression);
            Visit(node.If);
        }
        protected override void HandleAWhileStatement(AWhileStatement node)
        {
            Visit(node.Statements);
            Visit(node.Expression);
            Visit(node.While);
        }
        protected override void HandleAFunctionDeclarationStatement(AFunctionDeclarationStatement node)
        {
            Visit(node.Statements);
            Visit(node.Parameters);
            Visit(node.Identifier);
            Visit(node.Type);
            Visit(node.Readers);
        }
        protected override void HandleAExpressionStatement(AExpressionStatement node)
        {
            Visit(node.Expression);
        }
        protected override void HandleAReturnStatement(AReturnStatement node)
        {
            if (node.HasExpression)
                Visit(node.Expression);
            Visit(node.Return);
        }
        protected override void HandleAFunctionParameter(AFunctionParameter node)
        {
            Visit(node.Identifier);
            Visit(node.Type);
        }
        protected override void HandleAType(AType node)
        {
            if (node.HasLabel)
                Visit(node.Label);
            Visit(node.Name);
        }
        protected override void HandleAPointerType(APointerType node)
        {
            Visit(node.Asterisk);
            Visit(node.Type);
        }
        protected override void HandleAThisClaimant(AThisClaimant node)
        {
            Visit(node.This);
        }
        protected override void HandleACallerClaimant(ACallerClaimant node)
        {
            Visit(node.Caller);
        }
        protected override void HandleALabel(ALabel node)
        {
            Visit(node.TimePolicies);
            Visit(node.Policys);
        }
        protected override void HandleATimePolicy(ATimePolicy node)
        {
            if (node.HasCount)
                Visit(node.Count);
            Visit(node.Interval);
            if (node.HasPeriod)
                Visit(node.Period);
            if (node.HasPrincipal)
                Visit(node.Principal);
        }
        protected override void HandleATimingPeriod(ATimingPeriod node)
        {
            Visit(node.To);
            Visit(node.From);
        }
        protected override void HandleATimingInterval(ATimingInterval node)
        {
            Visit(node.Unit);
            Visit(node.Number);
        }
        protected override void HandleAVariablePolicy(AVariablePolicy node)
        {
            Visit(node.Identifier);
        }
        protected override void HandleAPrincipalPolicy(APrincipalPolicy node)
        {
            Visit(node.Readers);
            Visit(node.Owner);
        }
        protected override void HandleALowerPolicy(ALowerPolicy node)
        {
            Visit(node.Underscore);
        }
        protected override void HandleAUpperPolicy(AUpperPolicy node)
        {
            Visit(node.Hat);
        }
        protected override void HandleAPrincipal(APrincipal node)
        {
            Visit(node.Identifier);
        }
        protected override void HandleAAndExpression(AAndExpression node)
        {
            Visit(node.Right);
            Visit(node.And);
            Visit(node.Left);
        }
        protected override void HandleAOrExpression(AOrExpression node)
        {
            Visit(node.Right);
            Visit(node.Or);
            Visit(node.Left);
        }
        protected override void HandleANotExpression(ANotExpression node)
        {
            Visit(node.Expression);
            Visit(node.Bang);
        }
        protected override void HandleAComparisonExpression(AComparisonExpression node)
        {
            Visit(node.Right);
            Visit(node.Compare);
            Visit(node.Left);
        }
        protected override void HandleAElementExpression(AElementExpression node)
        {
            Visit(node.Element);
            Visit(node.Expression);
        }
        protected override void HandleAIndexExpression(AIndexExpression node)
        {
            Visit(node.RightPar);
            Visit(node.Index);
            Visit(node.LeftPar);
            Visit(node.Expression);
        }
        protected override void HandleAPlusExpression(APlusExpression node)
        {
            Visit(node.Right);
            Visit(node.Plus);
            Visit(node.Left);
        }
        protected override void HandleAMinusExpression(AMinusExpression node)
        {
            Visit(node.Right);
            Visit(node.Minus);
            Visit(node.Left);
        }
        protected override void HandleAMultiplyExpression(AMultiplyExpression node)
        {
            Visit(node.Right);
            Visit(node.Asterisk);
            Visit(node.Left);
        }
        protected override void HandleADivideExpression(ADivideExpression node)
        {
            Visit(node.Right);
            Visit(node.Slash);
            Visit(node.Left);
        }
        protected override void HandleAModuloExpression(AModuloExpression node)
        {
            Visit(node.Right);
            Visit(node.Percent);
            Visit(node.Left);
        }
        protected override void HandleANegateExpression(ANegateExpression node)
        {
            Visit(node.Expression);
            Visit(node.Minus);
        }
        protected override void HandleAFunctionCallExpression(AFunctionCallExpression node)
        {
            Visit(node.RightPar);
            Visit(node.Arguments);
            Visit(node.LeftPar);
            Visit(node.Authorities);
            Visit(node.Function);
            if (node.HasTimeCall)
                Visit(node.TimeCall);
        }
        protected override void HandleATernaryExpression(ATernaryExpression node)
        {
            Visit(node.False);
            Visit(node.Colon);
            Visit(node.True);
            Visit(node.Question);
            Visit(node.Condition);
        }
        protected override void HandleAParenthesisExpression(AParenthesisExpression node)
        {
            Visit(node.RightPar);
            Visit(node.Expression);
            Visit(node.LeftPar);
        }
        protected override void HandleADeclassifyExpression(ADeclassifyExpression node)
        {
            Visit(node.DeclassifyEnd);
            if (node.HasLabel)
                Visit(node.Label);
            Visit(node.Expression);
            Visit(node.DeclassifyStart);
        }
        protected override void HandleADereferenceExpression(ADereferenceExpression node)
        {
            Visit(node.Expression);
            Visit(node.Asterisk);
        }
        protected override void HandleAAddressExpression(AAddressExpression node)
        {
            Visit(node.Expression);
            Visit(node.Ampersand);
        }
        protected override void HandleAIdentifierExpression(AIdentifierExpression node)
        {
            Visit(node.Identifier);
        }
        protected override void HandleATimeCheckExpression(ATimeCheckExpression node)
        {
            Visit(node.Function);
            Visit(node.TimeCheck);
        }
        protected override void HandleANumberExpression(ANumberExpression node)
        {
            Visit(node.Number);
        }
        protected override void HandleABooleanExpression(ABooleanExpression node)
        {
            Visit(node.Bool);
        }
        protected override void HandleANullExpression(ANullExpression node)
        {
            Visit(node.Null);
        }
        protected override void HandleACharExpression(ACharExpression node)
        {
            Visit(node.Char);
        }
        protected override void HandleAStringExpression(AStringExpression node)
        {
            Visit(node.String);
        }
        protected override void HandleAElement(AElement node)
        {
            Visit(node.Identifier);
            Visit(node.Period);
        }
        protected override void HandleAPointerElement(APointerElement node)
        {
            Visit(node.Identifier);
            Visit(node.Arrow);
        }
    }
    
    #endregion
    
    #region Return analysis adapters
    
    public partial class ReturnAnalysisAdapter<Result> : ReturnAdapter<Result, PRoot>
    {
        public Result Visit(PRoot node)
        {
            return HandlePRoot(node);
        }
        protected virtual Result HandlePRoot(PRoot node)
        {
            return dispatch((dynamic)node);
        }
        private Result dispatch(ARoot node)
        {
            return HandleARoot(node);
        }
        protected virtual Result HandleARoot(ARoot node)
        {
            return HandleDefault(node);
        }
        
        public Result Visit(PPreProcessor node)
        {
            return HandlePPreProcessor(node);
        }
        protected virtual Result HandlePPreProcessor(PPreProcessor node)
        {
            return dispatch((dynamic)node);
        }
        private Result dispatch(APreProcessor node)
        {
            return HandleAPreProcessor(node);
        }
        protected virtual Result HandleAPreProcessor(APreProcessor node)
        {
            return HandleDefault(node);
        }
        
        public Result Visit(PPrincipalDeclaration node)
        {
            return HandlePPrincipalDeclaration(node);
        }
        protected virtual Result HandlePPrincipalDeclaration(PPrincipalDeclaration node)
        {
            return dispatch((dynamic)node);
        }
        private Result dispatch(APrincipalDeclaration node)
        {
            return HandleAPrincipalDeclaration(node);
        }
        protected virtual Result HandleAPrincipalDeclaration(APrincipalDeclaration node)
        {
            return HandleDefault(node);
        }
        
        public Result Visit(PPrincipalHierarchyDeclaration node)
        {
            return HandlePPrincipalHierarchyDeclaration(node);
        }
        protected virtual Result HandlePPrincipalHierarchyDeclaration(PPrincipalHierarchyDeclaration node)
        {
            return dispatch((dynamic)node);
        }
        private Result dispatch(APrincipalHierarchyDeclaration node)
        {
            return HandleAPrincipalHierarchyDeclaration(node);
        }
        protected virtual Result HandleAPrincipalHierarchyDeclaration(APrincipalHierarchyDeclaration node)
        {
            return HandleDefault(node);
        }
        
        public Result Visit(PStruct node)
        {
            return HandlePStruct(node);
        }
        protected virtual Result HandlePStruct(PStruct node)
        {
            return dispatch((dynamic)node);
        }
        private Result dispatch(AStruct node)
        {
            return HandleAStruct(node);
        }
        protected virtual Result HandleAStruct(AStruct node)
        {
            return HandleDefault(node);
        }
        
        public Result Visit(PField node)
        {
            return HandlePField(node);
        }
        protected virtual Result HandlePField(PField node)
        {
            return dispatch((dynamic)node);
        }
        private Result dispatch(AField node)
        {
            return HandleAField(node);
        }
        protected virtual Result HandleAField(AField node)
        {
            return HandleDefault(node);
        }
        private Result dispatch(AArrayField node)
        {
            return HandleAArrayField(node);
        }
        protected virtual Result HandleAArrayField(AArrayField node)
        {
            return HandleDefault(node);
        }
        
        public Result Visit(PStatement node)
        {
            return HandlePStatement(node);
        }
        protected virtual Result HandlePStatement(PStatement node)
        {
            return dispatch((dynamic)node);
        }
        private Result dispatch(ADeclarationStatement node)
        {
            return HandleADeclarationStatement(node);
        }
        protected virtual Result HandleADeclarationStatement(ADeclarationStatement node)
        {
            return HandleDefault(node);
        }
        private Result dispatch(AArrayDeclarationStatement node)
        {
            return HandleAArrayDeclarationStatement(node);
        }
        protected virtual Result HandleAArrayDeclarationStatement(AArrayDeclarationStatement node)
        {
            return HandleDefault(node);
        }
        private Result dispatch(AAssignmentStatement node)
        {
            return HandleAAssignmentStatement(node);
        }
        protected virtual Result HandleAAssignmentStatement(AAssignmentStatement node)
        {
            return HandleDefault(node);
        }
        private Result dispatch(AIfActsForStatement node)
        {
            return HandleAIfActsForStatement(node);
        }
        protected virtual Result HandleAIfActsForStatement(AIfActsForStatement node)
        {
            return HandleDefault(node);
        }
        private Result dispatch(AIfActsForElseStatement node)
        {
            return HandleAIfActsForElseStatement(node);
        }
        protected virtual Result HandleAIfActsForElseStatement(AIfActsForElseStatement node)
        {
            return HandleDefault(node);
        }
        private Result dispatch(AIfStatement node)
        {
            return HandleAIfStatement(node);
        }
        protected virtual Result HandleAIfStatement(AIfStatement node)
        {
            return HandleDefault(node);
        }
        private Result dispatch(AIfElseStatement node)
        {
            return HandleAIfElseStatement(node);
        }
        protected virtual Result HandleAIfElseStatement(AIfElseStatement node)
        {
            return HandleDefault(node);
        }
        private Result dispatch(AWhileStatement node)
        {
            return HandleAWhileStatement(node);
        }
        protected virtual Result HandleAWhileStatement(AWhileStatement node)
        {
            return HandleDefault(node);
        }
        private Result dispatch(AFunctionDeclarationStatement node)
        {
            return HandleAFunctionDeclarationStatement(node);
        }
        protected virtual Result HandleAFunctionDeclarationStatement(AFunctionDeclarationStatement node)
        {
            return HandleDefault(node);
        }
        private Result dispatch(AExpressionStatement node)
        {
            return HandleAExpressionStatement(node);
        }
        protected virtual Result HandleAExpressionStatement(AExpressionStatement node)
        {
            return HandleDefault(node);
        }
        private Result dispatch(AReturnStatement node)
        {
            return HandleAReturnStatement(node);
        }
        protected virtual Result HandleAReturnStatement(AReturnStatement node)
        {
            return HandleDefault(node);
        }
        
        public Result Visit(PFunctionParameter node)
        {
            return HandlePFunctionParameter(node);
        }
        protected virtual Result HandlePFunctionParameter(PFunctionParameter node)
        {
            return dispatch((dynamic)node);
        }
        private Result dispatch(AFunctionParameter node)
        {
            return HandleAFunctionParameter(node);
        }
        protected virtual Result HandleAFunctionParameter(AFunctionParameter node)
        {
            return HandleDefault(node);
        }
        
        public Result Visit(PType node)
        {
            return HandlePType(node);
        }
        protected virtual Result HandlePType(PType node)
        {
            return dispatch((dynamic)node);
        }
        private Result dispatch(AType node)
        {
            return HandleAType(node);
        }
        protected virtual Result HandleAType(AType node)
        {
            return HandleDefault(node);
        }
        private Result dispatch(APointerType node)
        {
            return HandleAPointerType(node);
        }
        protected virtual Result HandleAPointerType(APointerType node)
        {
            return HandleDefault(node);
        }
        
        public Result Visit(PClaimant node)
        {
            return HandlePClaimant(node);
        }
        protected virtual Result HandlePClaimant(PClaimant node)
        {
            return dispatch((dynamic)node);
        }
        private Result dispatch(AThisClaimant node)
        {
            return HandleAThisClaimant(node);
        }
        protected virtual Result HandleAThisClaimant(AThisClaimant node)
        {
            return HandleDefault(node);
        }
        private Result dispatch(ACallerClaimant node)
        {
            return HandleACallerClaimant(node);
        }
        protected virtual Result HandleACallerClaimant(ACallerClaimant node)
        {
            return HandleDefault(node);
        }
        
        public Result Visit(PLabel node)
        {
            return HandlePLabel(node);
        }
        protected virtual Result HandlePLabel(PLabel node)
        {
            return dispatch((dynamic)node);
        }
        private Result dispatch(ALabel node)
        {
            return HandleALabel(node);
        }
        protected virtual Result HandleALabel(ALabel node)
        {
            return HandleDefault(node);
        }
        
        public Result Visit(PTimePolicy node)
        {
            return HandlePTimePolicy(node);
        }
        protected virtual Result HandlePTimePolicy(PTimePolicy node)
        {
            return dispatch((dynamic)node);
        }
        private Result dispatch(ATimePolicy node)
        {
            return HandleATimePolicy(node);
        }
        protected virtual Result HandleATimePolicy(ATimePolicy node)
        {
            return HandleDefault(node);
        }
        
        public Result Visit(PTimingPeriod node)
        {
            return HandlePTimingPeriod(node);
        }
        protected virtual Result HandlePTimingPeriod(PTimingPeriod node)
        {
            return dispatch((dynamic)node);
        }
        private Result dispatch(ATimingPeriod node)
        {
            return HandleATimingPeriod(node);
        }
        protected virtual Result HandleATimingPeriod(ATimingPeriod node)
        {
            return HandleDefault(node);
        }
        
        public Result Visit(PTimingInterval node)
        {
            return HandlePTimingInterval(node);
        }
        protected virtual Result HandlePTimingInterval(PTimingInterval node)
        {
            return dispatch((dynamic)node);
        }
        private Result dispatch(ATimingInterval node)
        {
            return HandleATimingInterval(node);
        }
        protected virtual Result HandleATimingInterval(ATimingInterval node)
        {
            return HandleDefault(node);
        }
        
        public Result Visit(PPolicy node)
        {
            return HandlePPolicy(node);
        }
        protected virtual Result HandlePPolicy(PPolicy node)
        {
            return dispatch((dynamic)node);
        }
        private Result dispatch(AVariablePolicy node)
        {
            return HandleAVariablePolicy(node);
        }
        protected virtual Result HandleAVariablePolicy(AVariablePolicy node)
        {
            return HandleDefault(node);
        }
        private Result dispatch(APrincipalPolicy node)
        {
            return HandleAPrincipalPolicy(node);
        }
        protected virtual Result HandleAPrincipalPolicy(APrincipalPolicy node)
        {
            return HandleDefault(node);
        }
        private Result dispatch(ALowerPolicy node)
        {
            return HandleALowerPolicy(node);
        }
        protected virtual Result HandleALowerPolicy(ALowerPolicy node)
        {
            return HandleDefault(node);
        }
        private Result dispatch(AUpperPolicy node)
        {
            return HandleAUpperPolicy(node);
        }
        protected virtual Result HandleAUpperPolicy(AUpperPolicy node)
        {
            return HandleDefault(node);
        }
        
        public Result Visit(PPrincipal node)
        {
            return HandlePPrincipal(node);
        }
        protected virtual Result HandlePPrincipal(PPrincipal node)
        {
            return dispatch((dynamic)node);
        }
        private Result dispatch(APrincipal node)
        {
            return HandleAPrincipal(node);
        }
        protected virtual Result HandleAPrincipal(APrincipal node)
        {
            return HandleDefault(node);
        }
        
        public Result Visit(PExpression node)
        {
            return HandlePExpression(node);
        }
        protected virtual Result HandlePExpression(PExpression node)
        {
            return dispatch((dynamic)node);
        }
        private Result dispatch(AAndExpression node)
        {
            return HandleAAndExpression(node);
        }
        protected virtual Result HandleAAndExpression(AAndExpression node)
        {
            return HandleDefault(node);
        }
        private Result dispatch(AOrExpression node)
        {
            return HandleAOrExpression(node);
        }
        protected virtual Result HandleAOrExpression(AOrExpression node)
        {
            return HandleDefault(node);
        }
        private Result dispatch(ANotExpression node)
        {
            return HandleANotExpression(node);
        }
        protected virtual Result HandleANotExpression(ANotExpression node)
        {
            return HandleDefault(node);
        }
        private Result dispatch(AComparisonExpression node)
        {
            return HandleAComparisonExpression(node);
        }
        protected virtual Result HandleAComparisonExpression(AComparisonExpression node)
        {
            return HandleDefault(node);
        }
        private Result dispatch(AElementExpression node)
        {
            return HandleAElementExpression(node);
        }
        protected virtual Result HandleAElementExpression(AElementExpression node)
        {
            return HandleDefault(node);
        }
        private Result dispatch(AIndexExpression node)
        {
            return HandleAIndexExpression(node);
        }
        protected virtual Result HandleAIndexExpression(AIndexExpression node)
        {
            return HandleDefault(node);
        }
        private Result dispatch(APlusExpression node)
        {
            return HandleAPlusExpression(node);
        }
        protected virtual Result HandleAPlusExpression(APlusExpression node)
        {
            return HandleDefault(node);
        }
        private Result dispatch(AMinusExpression node)
        {
            return HandleAMinusExpression(node);
        }
        protected virtual Result HandleAMinusExpression(AMinusExpression node)
        {
            return HandleDefault(node);
        }
        private Result dispatch(AMultiplyExpression node)
        {
            return HandleAMultiplyExpression(node);
        }
        protected virtual Result HandleAMultiplyExpression(AMultiplyExpression node)
        {
            return HandleDefault(node);
        }
        private Result dispatch(ADivideExpression node)
        {
            return HandleADivideExpression(node);
        }
        protected virtual Result HandleADivideExpression(ADivideExpression node)
        {
            return HandleDefault(node);
        }
        private Result dispatch(AModuloExpression node)
        {
            return HandleAModuloExpression(node);
        }
        protected virtual Result HandleAModuloExpression(AModuloExpression node)
        {
            return HandleDefault(node);
        }
        private Result dispatch(ANegateExpression node)
        {
            return HandleANegateExpression(node);
        }
        protected virtual Result HandleANegateExpression(ANegateExpression node)
        {
            return HandleDefault(node);
        }
        private Result dispatch(AFunctionCallExpression node)
        {
            return HandleAFunctionCallExpression(node);
        }
        protected virtual Result HandleAFunctionCallExpression(AFunctionCallExpression node)
        {
            return HandleDefault(node);
        }
        private Result dispatch(ATernaryExpression node)
        {
            return HandleATernaryExpression(node);
        }
        protected virtual Result HandleATernaryExpression(ATernaryExpression node)
        {
            return HandleDefault(node);
        }
        private Result dispatch(AParenthesisExpression node)
        {
            return HandleAParenthesisExpression(node);
        }
        protected virtual Result HandleAParenthesisExpression(AParenthesisExpression node)
        {
            return HandleDefault(node);
        }
        private Result dispatch(ADeclassifyExpression node)
        {
            return HandleADeclassifyExpression(node);
        }
        protected virtual Result HandleADeclassifyExpression(ADeclassifyExpression node)
        {
            return HandleDefault(node);
        }
        private Result dispatch(ADereferenceExpression node)
        {
            return HandleADereferenceExpression(node);
        }
        protected virtual Result HandleADereferenceExpression(ADereferenceExpression node)
        {
            return HandleDefault(node);
        }
        private Result dispatch(AAddressExpression node)
        {
            return HandleAAddressExpression(node);
        }
        protected virtual Result HandleAAddressExpression(AAddressExpression node)
        {
            return HandleDefault(node);
        }
        private Result dispatch(AIdentifierExpression node)
        {
            return HandleAIdentifierExpression(node);
        }
        protected virtual Result HandleAIdentifierExpression(AIdentifierExpression node)
        {
            return HandleDefault(node);
        }
        private Result dispatch(ATimeCheckExpression node)
        {
            return HandleATimeCheckExpression(node);
        }
        protected virtual Result HandleATimeCheckExpression(ATimeCheckExpression node)
        {
            return HandleDefault(node);
        }
        private Result dispatch(ANumberExpression node)
        {
            return HandleANumberExpression(node);
        }
        protected virtual Result HandleANumberExpression(ANumberExpression node)
        {
            return HandleDefault(node);
        }
        private Result dispatch(ABooleanExpression node)
        {
            return HandleABooleanExpression(node);
        }
        protected virtual Result HandleABooleanExpression(ABooleanExpression node)
        {
            return HandleDefault(node);
        }
        private Result dispatch(ANullExpression node)
        {
            return HandleANullExpression(node);
        }
        protected virtual Result HandleANullExpression(ANullExpression node)
        {
            return HandleDefault(node);
        }
        private Result dispatch(ACharExpression node)
        {
            return HandleACharExpression(node);
        }
        protected virtual Result HandleACharExpression(ACharExpression node)
        {
            return HandleDefault(node);
        }
        private Result dispatch(AStringExpression node)
        {
            return HandleAStringExpression(node);
        }
        protected virtual Result HandleAStringExpression(AStringExpression node)
        {
            return HandleDefault(node);
        }
        
        public Result Visit(PElement node)
        {
            return HandlePElement(node);
        }
        protected virtual Result HandlePElement(PElement node)
        {
            return dispatch((dynamic)node);
        }
        private Result dispatch(AElement node)
        {
            return HandleAElement(node);
        }
        protected virtual Result HandleAElement(AElement node)
        {
            return HandleDefault(node);
        }
        private Result dispatch(APointerElement node)
        {
            return HandleAPointerElement(node);
        }
        protected virtual Result HandleAPointerElement(APointerElement node)
        {
            return HandleDefault(node);
        }
        
        public Result Visit(TDirective node)
        {
            return HandleTDirective(node);
        }
        protected virtual Result HandleTDirective(TDirective node)
        {
            return HandleDefault(node);
        }
        public Result Visit(TTime node)
        {
            return HandleTTime(node);
        }
        protected virtual Result HandleTTime(TTime node)
        {
            return HandleDefault(node);
        }
        public Result Visit(TIntervalUnit node)
        {
            return HandleTIntervalUnit(node);
        }
        protected virtual Result HandleTIntervalUnit(TIntervalUnit node)
        {
            return HandleDefault(node);
        }
        public Result Visit(TBool node)
        {
            return HandleTBool(node);
        }
        protected virtual Result HandleTBool(TBool node)
        {
            return HandleDefault(node);
        }
        public Result Visit(TNumber node)
        {
            return HandleTNumber(node);
        }
        protected virtual Result HandleTNumber(TNumber node)
        {
            return HandleDefault(node);
        }
        public Result Visit(TPrincipall node)
        {
            return HandleTPrincipall(node);
        }
        protected virtual Result HandleTPrincipall(TPrincipall node)
        {
            return HandleDefault(node);
        }
        public Result Visit(TTypedef node)
        {
            return HandleTTypedef(node);
        }
        protected virtual Result HandleTTypedef(TTypedef node)
        {
            return HandleDefault(node);
        }
        public Result Visit(TStruct node)
        {
            return HandleTStruct(node);
        }
        protected virtual Result HandleTStruct(TStruct node)
        {
            return HandleDefault(node);
        }
        public Result Visit(TWhile node)
        {
            return HandleTWhile(node);
        }
        protected virtual Result HandleTWhile(TWhile node)
        {
            return HandleDefault(node);
        }
        public Result Visit(TIf node)
        {
            return HandleTIf(node);
        }
        protected virtual Result HandleTIf(TIf node)
        {
            return HandleDefault(node);
        }
        public Result Visit(TElse node)
        {
            return HandleTElse(node);
        }
        protected virtual Result HandleTElse(TElse node)
        {
            return HandleDefault(node);
        }
        public Result Visit(TReturn node)
        {
            return HandleTReturn(node);
        }
        protected virtual Result HandleTReturn(TReturn node)
        {
            return HandleDefault(node);
        }
        public Result Visit(TThis node)
        {
            return HandleTThis(node);
        }
        protected virtual Result HandleTThis(TThis node)
        {
            return HandleDefault(node);
        }
        public Result Visit(TCaller node)
        {
            return HandleTCaller(node);
        }
        protected virtual Result HandleTCaller(TCaller node)
        {
            return HandleDefault(node);
        }
        public Result Visit(TNull node)
        {
            return HandleTNull(node);
        }
        protected virtual Result HandleTNull(TNull node)
        {
            return HandleDefault(node);
        }
        public Result Visit(TChar node)
        {
            return HandleTChar(node);
        }
        protected virtual Result HandleTChar(TChar node)
        {
            return HandleDefault(node);
        }
        public Result Visit(TCharErr node)
        {
            return HandleTCharErr(node);
        }
        protected virtual Result HandleTCharErr(TCharErr node)
        {
            return HandleDefault(node);
        }
        public Result Visit(TString node)
        {
            return HandleTString(node);
        }
        protected virtual Result HandleTString(TString node)
        {
            return HandleDefault(node);
        }
        public Result Visit(TStringErr node)
        {
            return HandleTStringErr(node);
        }
        protected virtual Result HandleTStringErr(TStringErr node)
        {
            return HandleDefault(node);
        }
        public Result Visit(TIdentifier node)
        {
            return HandleTIdentifier(node);
        }
        protected virtual Result HandleTIdentifier(TIdentifier node)
        {
            return HandleDefault(node);
        }
        public Result Visit(TActsFor node)
        {
            return HandleTActsFor(node);
        }
        protected virtual Result HandleTActsFor(TActsFor node)
        {
            return HandleDefault(node);
        }
        public Result Visit(TIfActsFor node)
        {
            return HandleTIfActsFor(node);
        }
        protected virtual Result HandleTIfActsFor(TIfActsFor node)
        {
            return HandleDefault(node);
        }
        public Result Visit(TDeclassifyStart node)
        {
            return HandleTDeclassifyStart(node);
        }
        protected virtual Result HandleTDeclassifyStart(TDeclassifyStart node)
        {
            return HandleDefault(node);
        }
        public Result Visit(TDeclassifyEnd node)
        {
            return HandleTDeclassifyEnd(node);
        }
        protected virtual Result HandleTDeclassifyEnd(TDeclassifyEnd node)
        {
            return HandleDefault(node);
        }
        public Result Visit(TFuncAuthStart node)
        {
            return HandleTFuncAuthStart(node);
        }
        protected virtual Result HandleTFuncAuthStart(TFuncAuthStart node)
        {
            return HandleDefault(node);
        }
        public Result Visit(TFuncAuthEnd node)
        {
            return HandleTFuncAuthEnd(node);
        }
        protected virtual Result HandleTFuncAuthEnd(TFuncAuthEnd node)
        {
            return HandleDefault(node);
        }
        public Result Visit(TRArrow node)
        {
            return HandleTRArrow(node);
        }
        protected virtual Result HandleTRArrow(TRArrow node)
        {
            return HandleDefault(node);
        }
        public Result Visit(TLArrow node)
        {
            return HandleTLArrow(node);
        }
        protected virtual Result HandleTLArrow(TLArrow node)
        {
            return HandleDefault(node);
        }
        public Result Visit(TCompare node)
        {
            return HandleTCompare(node);
        }
        protected virtual Result HandleTCompare(TCompare node)
        {
            return HandleDefault(node);
        }
        public Result Visit(TAssign node)
        {
            return HandleTAssign(node);
        }
        protected virtual Result HandleTAssign(TAssign node)
        {
            return HandleDefault(node);
        }
        public Result Visit(TUnderscore node)
        {
            return HandleTUnderscore(node);
        }
        protected virtual Result HandleTUnderscore(TUnderscore node)
        {
            return HandleDefault(node);
        }
        public Result Visit(THat node)
        {
            return HandleTHat(node);
        }
        protected virtual Result HandleTHat(THat node)
        {
            return HandleDefault(node);
        }
        public Result Visit(TPlus node)
        {
            return HandleTPlus(node);
        }
        protected virtual Result HandleTPlus(TPlus node)
        {
            return HandleDefault(node);
        }
        public Result Visit(TMinus node)
        {
            return HandleTMinus(node);
        }
        protected virtual Result HandleTMinus(TMinus node)
        {
            return HandleDefault(node);
        }
        public Result Visit(TAsterisk node)
        {
            return HandleTAsterisk(node);
        }
        protected virtual Result HandleTAsterisk(TAsterisk node)
        {
            return HandleDefault(node);
        }
        public Result Visit(TSlash node)
        {
            return HandleTSlash(node);
        }
        protected virtual Result HandleTSlash(TSlash node)
        {
            return HandleDefault(node);
        }
        public Result Visit(TPercent node)
        {
            return HandleTPercent(node);
        }
        protected virtual Result HandleTPercent(TPercent node)
        {
            return HandleDefault(node);
        }
        public Result Visit(TAmpersand node)
        {
            return HandleTAmpersand(node);
        }
        protected virtual Result HandleTAmpersand(TAmpersand node)
        {
            return HandleDefault(node);
        }
        public Result Visit(TBang node)
        {
            return HandleTBang(node);
        }
        protected virtual Result HandleTBang(TBang node)
        {
            return HandleDefault(node);
        }
        public Result Visit(TAnd node)
        {
            return HandleTAnd(node);
        }
        protected virtual Result HandleTAnd(TAnd node)
        {
            return HandleDefault(node);
        }
        public Result Visit(TOr node)
        {
            return HandleTOr(node);
        }
        protected virtual Result HandleTOr(TOr node)
        {
            return HandleDefault(node);
        }
        public Result Visit(TQuestion node)
        {
            return HandleTQuestion(node);
        }
        protected virtual Result HandleTQuestion(TQuestion node)
        {
            return HandleDefault(node);
        }
        public Result Visit(TPeriod node)
        {
            return HandleTPeriod(node);
        }
        protected virtual Result HandleTPeriod(TPeriod node)
        {
            return HandleDefault(node);
        }
        public Result Visit(TComma node)
        {
            return HandleTComma(node);
        }
        protected virtual Result HandleTComma(TComma node)
        {
            return HandleDefault(node);
        }
        public Result Visit(TColon node)
        {
            return HandleTColon(node);
        }
        protected virtual Result HandleTColon(TColon node)
        {
            return HandleDefault(node);
        }
        public Result Visit(TSemicolon node)
        {
            return HandleTSemicolon(node);
        }
        protected virtual Result HandleTSemicolon(TSemicolon node)
        {
            return HandleDefault(node);
        }
        public Result Visit(TLabelStart node)
        {
            return HandleTLabelStart(node);
        }
        protected virtual Result HandleTLabelStart(TLabelStart node)
        {
            return HandleDefault(node);
        }
        public Result Visit(TTimeStart node)
        {
            return HandleTTimeStart(node);
        }
        protected virtual Result HandleTTimeStart(TTimeStart node)
        {
            return HandleDefault(node);
        }
        public Result Visit(TLabelEnd node)
        {
            return HandleTLabelEnd(node);
        }
        protected virtual Result HandleTLabelEnd(TLabelEnd node)
        {
            return HandleDefault(node);
        }
        public Result Visit(TTimeCall node)
        {
            return HandleTTimeCall(node);
        }
        protected virtual Result HandleTTimeCall(TTimeCall node)
        {
            return HandleDefault(node);
        }
        public Result Visit(TTimeCheck node)
        {
            return HandleTTimeCheck(node);
        }
        protected virtual Result HandleTTimeCheck(TTimeCheck node)
        {
            return HandleDefault(node);
        }
        public Result Visit(TLPar node)
        {
            return HandleTLPar(node);
        }
        protected virtual Result HandleTLPar(TLPar node)
        {
            return HandleDefault(node);
        }
        public Result Visit(TRPar node)
        {
            return HandleTRPar(node);
        }
        protected virtual Result HandleTRPar(TRPar node)
        {
            return HandleDefault(node);
        }
        public Result Visit(TLSqu node)
        {
            return HandleTLSqu(node);
        }
        protected virtual Result HandleTLSqu(TLSqu node)
        {
            return HandleDefault(node);
        }
        public Result Visit(TRSqu node)
        {
            return HandleTRSqu(node);
        }
        protected virtual Result HandleTRSqu(TRSqu node)
        {
            return HandleDefault(node);
        }
        public Result Visit(TLCur node)
        {
            return HandleTLCur(node);
        }
        protected virtual Result HandleTLCur(TLCur node)
        {
            return HandleDefault(node);
        }
        public Result Visit(TRCur node)
        {
            return HandleTRCur(node);
        }
        protected virtual Result HandleTRCur(TRCur node)
        {
            return HandleDefault(node);
        }
        public Result Visit(TJoin node)
        {
            return HandleTJoin(node);
        }
        protected virtual Result HandleTJoin(TJoin node)
        {
            return HandleDefault(node);
        }
        public Result Visit(TComment node)
        {
            return HandleTComment(node);
        }
        protected virtual Result HandleTComment(TComment node)
        {
            return HandleDefault(node);
        }
        public Result Visit(TWhitespace node)
        {
            return HandleTWhitespace(node);
        }
        protected virtual Result HandleTWhitespace(TWhitespace node)
        {
            return HandleDefault(node);
        }
    }
    public partial class ReturnAnalysisAdapter<T1, Result> : ReturnAdapter<T1, Result, PRoot>
    {
        public Result Visit(PRoot node, T1 arg1)
        {
            return HandlePRoot(node, arg1);
        }
        protected virtual Result HandlePRoot(PRoot node, T1 arg1)
        {
            return dispatch((dynamic)node, arg1);
        }
        private Result dispatch(ARoot node, T1 arg1)
        {
            return HandleARoot(node, arg1);
        }
        protected virtual Result HandleARoot(ARoot node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        
        public Result Visit(PPreProcessor node, T1 arg1)
        {
            return HandlePPreProcessor(node, arg1);
        }
        protected virtual Result HandlePPreProcessor(PPreProcessor node, T1 arg1)
        {
            return dispatch((dynamic)node, arg1);
        }
        private Result dispatch(APreProcessor node, T1 arg1)
        {
            return HandleAPreProcessor(node, arg1);
        }
        protected virtual Result HandleAPreProcessor(APreProcessor node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        
        public Result Visit(PPrincipalDeclaration node, T1 arg1)
        {
            return HandlePPrincipalDeclaration(node, arg1);
        }
        protected virtual Result HandlePPrincipalDeclaration(PPrincipalDeclaration node, T1 arg1)
        {
            return dispatch((dynamic)node, arg1);
        }
        private Result dispatch(APrincipalDeclaration node, T1 arg1)
        {
            return HandleAPrincipalDeclaration(node, arg1);
        }
        protected virtual Result HandleAPrincipalDeclaration(APrincipalDeclaration node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        
        public Result Visit(PPrincipalHierarchyDeclaration node, T1 arg1)
        {
            return HandlePPrincipalHierarchyDeclaration(node, arg1);
        }
        protected virtual Result HandlePPrincipalHierarchyDeclaration(PPrincipalHierarchyDeclaration node, T1 arg1)
        {
            return dispatch((dynamic)node, arg1);
        }
        private Result dispatch(APrincipalHierarchyDeclaration node, T1 arg1)
        {
            return HandleAPrincipalHierarchyDeclaration(node, arg1);
        }
        protected virtual Result HandleAPrincipalHierarchyDeclaration(APrincipalHierarchyDeclaration node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        
        public Result Visit(PStruct node, T1 arg1)
        {
            return HandlePStruct(node, arg1);
        }
        protected virtual Result HandlePStruct(PStruct node, T1 arg1)
        {
            return dispatch((dynamic)node, arg1);
        }
        private Result dispatch(AStruct node, T1 arg1)
        {
            return HandleAStruct(node, arg1);
        }
        protected virtual Result HandleAStruct(AStruct node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        
        public Result Visit(PField node, T1 arg1)
        {
            return HandlePField(node, arg1);
        }
        protected virtual Result HandlePField(PField node, T1 arg1)
        {
            return dispatch((dynamic)node, arg1);
        }
        private Result dispatch(AField node, T1 arg1)
        {
            return HandleAField(node, arg1);
        }
        protected virtual Result HandleAField(AField node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        private Result dispatch(AArrayField node, T1 arg1)
        {
            return HandleAArrayField(node, arg1);
        }
        protected virtual Result HandleAArrayField(AArrayField node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        
        public Result Visit(PStatement node, T1 arg1)
        {
            return HandlePStatement(node, arg1);
        }
        protected virtual Result HandlePStatement(PStatement node, T1 arg1)
        {
            return dispatch((dynamic)node, arg1);
        }
        private Result dispatch(ADeclarationStatement node, T1 arg1)
        {
            return HandleADeclarationStatement(node, arg1);
        }
        protected virtual Result HandleADeclarationStatement(ADeclarationStatement node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        private Result dispatch(AArrayDeclarationStatement node, T1 arg1)
        {
            return HandleAArrayDeclarationStatement(node, arg1);
        }
        protected virtual Result HandleAArrayDeclarationStatement(AArrayDeclarationStatement node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        private Result dispatch(AAssignmentStatement node, T1 arg1)
        {
            return HandleAAssignmentStatement(node, arg1);
        }
        protected virtual Result HandleAAssignmentStatement(AAssignmentStatement node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        private Result dispatch(AIfActsForStatement node, T1 arg1)
        {
            return HandleAIfActsForStatement(node, arg1);
        }
        protected virtual Result HandleAIfActsForStatement(AIfActsForStatement node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        private Result dispatch(AIfActsForElseStatement node, T1 arg1)
        {
            return HandleAIfActsForElseStatement(node, arg1);
        }
        protected virtual Result HandleAIfActsForElseStatement(AIfActsForElseStatement node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        private Result dispatch(AIfStatement node, T1 arg1)
        {
            return HandleAIfStatement(node, arg1);
        }
        protected virtual Result HandleAIfStatement(AIfStatement node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        private Result dispatch(AIfElseStatement node, T1 arg1)
        {
            return HandleAIfElseStatement(node, arg1);
        }
        protected virtual Result HandleAIfElseStatement(AIfElseStatement node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        private Result dispatch(AWhileStatement node, T1 arg1)
        {
            return HandleAWhileStatement(node, arg1);
        }
        protected virtual Result HandleAWhileStatement(AWhileStatement node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        private Result dispatch(AFunctionDeclarationStatement node, T1 arg1)
        {
            return HandleAFunctionDeclarationStatement(node, arg1);
        }
        protected virtual Result HandleAFunctionDeclarationStatement(AFunctionDeclarationStatement node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        private Result dispatch(AExpressionStatement node, T1 arg1)
        {
            return HandleAExpressionStatement(node, arg1);
        }
        protected virtual Result HandleAExpressionStatement(AExpressionStatement node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        private Result dispatch(AReturnStatement node, T1 arg1)
        {
            return HandleAReturnStatement(node, arg1);
        }
        protected virtual Result HandleAReturnStatement(AReturnStatement node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        
        public Result Visit(PFunctionParameter node, T1 arg1)
        {
            return HandlePFunctionParameter(node, arg1);
        }
        protected virtual Result HandlePFunctionParameter(PFunctionParameter node, T1 arg1)
        {
            return dispatch((dynamic)node, arg1);
        }
        private Result dispatch(AFunctionParameter node, T1 arg1)
        {
            return HandleAFunctionParameter(node, arg1);
        }
        protected virtual Result HandleAFunctionParameter(AFunctionParameter node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        
        public Result Visit(PType node, T1 arg1)
        {
            return HandlePType(node, arg1);
        }
        protected virtual Result HandlePType(PType node, T1 arg1)
        {
            return dispatch((dynamic)node, arg1);
        }
        private Result dispatch(AType node, T1 arg1)
        {
            return HandleAType(node, arg1);
        }
        protected virtual Result HandleAType(AType node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        private Result dispatch(APointerType node, T1 arg1)
        {
            return HandleAPointerType(node, arg1);
        }
        protected virtual Result HandleAPointerType(APointerType node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        
        public Result Visit(PClaimant node, T1 arg1)
        {
            return HandlePClaimant(node, arg1);
        }
        protected virtual Result HandlePClaimant(PClaimant node, T1 arg1)
        {
            return dispatch((dynamic)node, arg1);
        }
        private Result dispatch(AThisClaimant node, T1 arg1)
        {
            return HandleAThisClaimant(node, arg1);
        }
        protected virtual Result HandleAThisClaimant(AThisClaimant node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        private Result dispatch(ACallerClaimant node, T1 arg1)
        {
            return HandleACallerClaimant(node, arg1);
        }
        protected virtual Result HandleACallerClaimant(ACallerClaimant node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        
        public Result Visit(PLabel node, T1 arg1)
        {
            return HandlePLabel(node, arg1);
        }
        protected virtual Result HandlePLabel(PLabel node, T1 arg1)
        {
            return dispatch((dynamic)node, arg1);
        }
        private Result dispatch(ALabel node, T1 arg1)
        {
            return HandleALabel(node, arg1);
        }
        protected virtual Result HandleALabel(ALabel node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        
        public Result Visit(PTimePolicy node, T1 arg1)
        {
            return HandlePTimePolicy(node, arg1);
        }
        protected virtual Result HandlePTimePolicy(PTimePolicy node, T1 arg1)
        {
            return dispatch((dynamic)node, arg1);
        }
        private Result dispatch(ATimePolicy node, T1 arg1)
        {
            return HandleATimePolicy(node, arg1);
        }
        protected virtual Result HandleATimePolicy(ATimePolicy node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        
        public Result Visit(PTimingPeriod node, T1 arg1)
        {
            return HandlePTimingPeriod(node, arg1);
        }
        protected virtual Result HandlePTimingPeriod(PTimingPeriod node, T1 arg1)
        {
            return dispatch((dynamic)node, arg1);
        }
        private Result dispatch(ATimingPeriod node, T1 arg1)
        {
            return HandleATimingPeriod(node, arg1);
        }
        protected virtual Result HandleATimingPeriod(ATimingPeriod node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        
        public Result Visit(PTimingInterval node, T1 arg1)
        {
            return HandlePTimingInterval(node, arg1);
        }
        protected virtual Result HandlePTimingInterval(PTimingInterval node, T1 arg1)
        {
            return dispatch((dynamic)node, arg1);
        }
        private Result dispatch(ATimingInterval node, T1 arg1)
        {
            return HandleATimingInterval(node, arg1);
        }
        protected virtual Result HandleATimingInterval(ATimingInterval node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        
        public Result Visit(PPolicy node, T1 arg1)
        {
            return HandlePPolicy(node, arg1);
        }
        protected virtual Result HandlePPolicy(PPolicy node, T1 arg1)
        {
            return dispatch((dynamic)node, arg1);
        }
        private Result dispatch(AVariablePolicy node, T1 arg1)
        {
            return HandleAVariablePolicy(node, arg1);
        }
        protected virtual Result HandleAVariablePolicy(AVariablePolicy node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        private Result dispatch(APrincipalPolicy node, T1 arg1)
        {
            return HandleAPrincipalPolicy(node, arg1);
        }
        protected virtual Result HandleAPrincipalPolicy(APrincipalPolicy node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        private Result dispatch(ALowerPolicy node, T1 arg1)
        {
            return HandleALowerPolicy(node, arg1);
        }
        protected virtual Result HandleALowerPolicy(ALowerPolicy node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        private Result dispatch(AUpperPolicy node, T1 arg1)
        {
            return HandleAUpperPolicy(node, arg1);
        }
        protected virtual Result HandleAUpperPolicy(AUpperPolicy node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        
        public Result Visit(PPrincipal node, T1 arg1)
        {
            return HandlePPrincipal(node, arg1);
        }
        protected virtual Result HandlePPrincipal(PPrincipal node, T1 arg1)
        {
            return dispatch((dynamic)node, arg1);
        }
        private Result dispatch(APrincipal node, T1 arg1)
        {
            return HandleAPrincipal(node, arg1);
        }
        protected virtual Result HandleAPrincipal(APrincipal node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        
        public Result Visit(PExpression node, T1 arg1)
        {
            return HandlePExpression(node, arg1);
        }
        protected virtual Result HandlePExpression(PExpression node, T1 arg1)
        {
            return dispatch((dynamic)node, arg1);
        }
        private Result dispatch(AAndExpression node, T1 arg1)
        {
            return HandleAAndExpression(node, arg1);
        }
        protected virtual Result HandleAAndExpression(AAndExpression node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        private Result dispatch(AOrExpression node, T1 arg1)
        {
            return HandleAOrExpression(node, arg1);
        }
        protected virtual Result HandleAOrExpression(AOrExpression node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        private Result dispatch(ANotExpression node, T1 arg1)
        {
            return HandleANotExpression(node, arg1);
        }
        protected virtual Result HandleANotExpression(ANotExpression node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        private Result dispatch(AComparisonExpression node, T1 arg1)
        {
            return HandleAComparisonExpression(node, arg1);
        }
        protected virtual Result HandleAComparisonExpression(AComparisonExpression node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        private Result dispatch(AElementExpression node, T1 arg1)
        {
            return HandleAElementExpression(node, arg1);
        }
        protected virtual Result HandleAElementExpression(AElementExpression node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        private Result dispatch(AIndexExpression node, T1 arg1)
        {
            return HandleAIndexExpression(node, arg1);
        }
        protected virtual Result HandleAIndexExpression(AIndexExpression node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        private Result dispatch(APlusExpression node, T1 arg1)
        {
            return HandleAPlusExpression(node, arg1);
        }
        protected virtual Result HandleAPlusExpression(APlusExpression node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        private Result dispatch(AMinusExpression node, T1 arg1)
        {
            return HandleAMinusExpression(node, arg1);
        }
        protected virtual Result HandleAMinusExpression(AMinusExpression node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        private Result dispatch(AMultiplyExpression node, T1 arg1)
        {
            return HandleAMultiplyExpression(node, arg1);
        }
        protected virtual Result HandleAMultiplyExpression(AMultiplyExpression node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        private Result dispatch(ADivideExpression node, T1 arg1)
        {
            return HandleADivideExpression(node, arg1);
        }
        protected virtual Result HandleADivideExpression(ADivideExpression node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        private Result dispatch(AModuloExpression node, T1 arg1)
        {
            return HandleAModuloExpression(node, arg1);
        }
        protected virtual Result HandleAModuloExpression(AModuloExpression node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        private Result dispatch(ANegateExpression node, T1 arg1)
        {
            return HandleANegateExpression(node, arg1);
        }
        protected virtual Result HandleANegateExpression(ANegateExpression node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        private Result dispatch(AFunctionCallExpression node, T1 arg1)
        {
            return HandleAFunctionCallExpression(node, arg1);
        }
        protected virtual Result HandleAFunctionCallExpression(AFunctionCallExpression node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        private Result dispatch(ATernaryExpression node, T1 arg1)
        {
            return HandleATernaryExpression(node, arg1);
        }
        protected virtual Result HandleATernaryExpression(ATernaryExpression node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        private Result dispatch(AParenthesisExpression node, T1 arg1)
        {
            return HandleAParenthesisExpression(node, arg1);
        }
        protected virtual Result HandleAParenthesisExpression(AParenthesisExpression node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        private Result dispatch(ADeclassifyExpression node, T1 arg1)
        {
            return HandleADeclassifyExpression(node, arg1);
        }
        protected virtual Result HandleADeclassifyExpression(ADeclassifyExpression node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        private Result dispatch(ADereferenceExpression node, T1 arg1)
        {
            return HandleADereferenceExpression(node, arg1);
        }
        protected virtual Result HandleADereferenceExpression(ADereferenceExpression node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        private Result dispatch(AAddressExpression node, T1 arg1)
        {
            return HandleAAddressExpression(node, arg1);
        }
        protected virtual Result HandleAAddressExpression(AAddressExpression node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        private Result dispatch(AIdentifierExpression node, T1 arg1)
        {
            return HandleAIdentifierExpression(node, arg1);
        }
        protected virtual Result HandleAIdentifierExpression(AIdentifierExpression node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        private Result dispatch(ATimeCheckExpression node, T1 arg1)
        {
            return HandleATimeCheckExpression(node, arg1);
        }
        protected virtual Result HandleATimeCheckExpression(ATimeCheckExpression node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        private Result dispatch(ANumberExpression node, T1 arg1)
        {
            return HandleANumberExpression(node, arg1);
        }
        protected virtual Result HandleANumberExpression(ANumberExpression node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        private Result dispatch(ABooleanExpression node, T1 arg1)
        {
            return HandleABooleanExpression(node, arg1);
        }
        protected virtual Result HandleABooleanExpression(ABooleanExpression node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        private Result dispatch(ANullExpression node, T1 arg1)
        {
            return HandleANullExpression(node, arg1);
        }
        protected virtual Result HandleANullExpression(ANullExpression node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        private Result dispatch(ACharExpression node, T1 arg1)
        {
            return HandleACharExpression(node, arg1);
        }
        protected virtual Result HandleACharExpression(ACharExpression node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        private Result dispatch(AStringExpression node, T1 arg1)
        {
            return HandleAStringExpression(node, arg1);
        }
        protected virtual Result HandleAStringExpression(AStringExpression node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        
        public Result Visit(PElement node, T1 arg1)
        {
            return HandlePElement(node, arg1);
        }
        protected virtual Result HandlePElement(PElement node, T1 arg1)
        {
            return dispatch((dynamic)node, arg1);
        }
        private Result dispatch(AElement node, T1 arg1)
        {
            return HandleAElement(node, arg1);
        }
        protected virtual Result HandleAElement(AElement node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        private Result dispatch(APointerElement node, T1 arg1)
        {
            return HandleAPointerElement(node, arg1);
        }
        protected virtual Result HandleAPointerElement(APointerElement node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        
        public Result Visit(TDirective node, T1 arg1)
        {
            return HandleTDirective(node, arg1);
        }
        protected virtual Result HandleTDirective(TDirective node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(TTime node, T1 arg1)
        {
            return HandleTTime(node, arg1);
        }
        protected virtual Result HandleTTime(TTime node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(TIntervalUnit node, T1 arg1)
        {
            return HandleTIntervalUnit(node, arg1);
        }
        protected virtual Result HandleTIntervalUnit(TIntervalUnit node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(TBool node, T1 arg1)
        {
            return HandleTBool(node, arg1);
        }
        protected virtual Result HandleTBool(TBool node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(TNumber node, T1 arg1)
        {
            return HandleTNumber(node, arg1);
        }
        protected virtual Result HandleTNumber(TNumber node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(TPrincipall node, T1 arg1)
        {
            return HandleTPrincipall(node, arg1);
        }
        protected virtual Result HandleTPrincipall(TPrincipall node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(TTypedef node, T1 arg1)
        {
            return HandleTTypedef(node, arg1);
        }
        protected virtual Result HandleTTypedef(TTypedef node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(TStruct node, T1 arg1)
        {
            return HandleTStruct(node, arg1);
        }
        protected virtual Result HandleTStruct(TStruct node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(TWhile node, T1 arg1)
        {
            return HandleTWhile(node, arg1);
        }
        protected virtual Result HandleTWhile(TWhile node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(TIf node, T1 arg1)
        {
            return HandleTIf(node, arg1);
        }
        protected virtual Result HandleTIf(TIf node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(TElse node, T1 arg1)
        {
            return HandleTElse(node, arg1);
        }
        protected virtual Result HandleTElse(TElse node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(TReturn node, T1 arg1)
        {
            return HandleTReturn(node, arg1);
        }
        protected virtual Result HandleTReturn(TReturn node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(TThis node, T1 arg1)
        {
            return HandleTThis(node, arg1);
        }
        protected virtual Result HandleTThis(TThis node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(TCaller node, T1 arg1)
        {
            return HandleTCaller(node, arg1);
        }
        protected virtual Result HandleTCaller(TCaller node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(TNull node, T1 arg1)
        {
            return HandleTNull(node, arg1);
        }
        protected virtual Result HandleTNull(TNull node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(TChar node, T1 arg1)
        {
            return HandleTChar(node, arg1);
        }
        protected virtual Result HandleTChar(TChar node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(TCharErr node, T1 arg1)
        {
            return HandleTCharErr(node, arg1);
        }
        protected virtual Result HandleTCharErr(TCharErr node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(TString node, T1 arg1)
        {
            return HandleTString(node, arg1);
        }
        protected virtual Result HandleTString(TString node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(TStringErr node, T1 arg1)
        {
            return HandleTStringErr(node, arg1);
        }
        protected virtual Result HandleTStringErr(TStringErr node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(TIdentifier node, T1 arg1)
        {
            return HandleTIdentifier(node, arg1);
        }
        protected virtual Result HandleTIdentifier(TIdentifier node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(TActsFor node, T1 arg1)
        {
            return HandleTActsFor(node, arg1);
        }
        protected virtual Result HandleTActsFor(TActsFor node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(TIfActsFor node, T1 arg1)
        {
            return HandleTIfActsFor(node, arg1);
        }
        protected virtual Result HandleTIfActsFor(TIfActsFor node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(TDeclassifyStart node, T1 arg1)
        {
            return HandleTDeclassifyStart(node, arg1);
        }
        protected virtual Result HandleTDeclassifyStart(TDeclassifyStart node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(TDeclassifyEnd node, T1 arg1)
        {
            return HandleTDeclassifyEnd(node, arg1);
        }
        protected virtual Result HandleTDeclassifyEnd(TDeclassifyEnd node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(TFuncAuthStart node, T1 arg1)
        {
            return HandleTFuncAuthStart(node, arg1);
        }
        protected virtual Result HandleTFuncAuthStart(TFuncAuthStart node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(TFuncAuthEnd node, T1 arg1)
        {
            return HandleTFuncAuthEnd(node, arg1);
        }
        protected virtual Result HandleTFuncAuthEnd(TFuncAuthEnd node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(TRArrow node, T1 arg1)
        {
            return HandleTRArrow(node, arg1);
        }
        protected virtual Result HandleTRArrow(TRArrow node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(TLArrow node, T1 arg1)
        {
            return HandleTLArrow(node, arg1);
        }
        protected virtual Result HandleTLArrow(TLArrow node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(TCompare node, T1 arg1)
        {
            return HandleTCompare(node, arg1);
        }
        protected virtual Result HandleTCompare(TCompare node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(TAssign node, T1 arg1)
        {
            return HandleTAssign(node, arg1);
        }
        protected virtual Result HandleTAssign(TAssign node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(TUnderscore node, T1 arg1)
        {
            return HandleTUnderscore(node, arg1);
        }
        protected virtual Result HandleTUnderscore(TUnderscore node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(THat node, T1 arg1)
        {
            return HandleTHat(node, arg1);
        }
        protected virtual Result HandleTHat(THat node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(TPlus node, T1 arg1)
        {
            return HandleTPlus(node, arg1);
        }
        protected virtual Result HandleTPlus(TPlus node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(TMinus node, T1 arg1)
        {
            return HandleTMinus(node, arg1);
        }
        protected virtual Result HandleTMinus(TMinus node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(TAsterisk node, T1 arg1)
        {
            return HandleTAsterisk(node, arg1);
        }
        protected virtual Result HandleTAsterisk(TAsterisk node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(TSlash node, T1 arg1)
        {
            return HandleTSlash(node, arg1);
        }
        protected virtual Result HandleTSlash(TSlash node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(TPercent node, T1 arg1)
        {
            return HandleTPercent(node, arg1);
        }
        protected virtual Result HandleTPercent(TPercent node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(TAmpersand node, T1 arg1)
        {
            return HandleTAmpersand(node, arg1);
        }
        protected virtual Result HandleTAmpersand(TAmpersand node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(TBang node, T1 arg1)
        {
            return HandleTBang(node, arg1);
        }
        protected virtual Result HandleTBang(TBang node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(TAnd node, T1 arg1)
        {
            return HandleTAnd(node, arg1);
        }
        protected virtual Result HandleTAnd(TAnd node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(TOr node, T1 arg1)
        {
            return HandleTOr(node, arg1);
        }
        protected virtual Result HandleTOr(TOr node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(TQuestion node, T1 arg1)
        {
            return HandleTQuestion(node, arg1);
        }
        protected virtual Result HandleTQuestion(TQuestion node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(TPeriod node, T1 arg1)
        {
            return HandleTPeriod(node, arg1);
        }
        protected virtual Result HandleTPeriod(TPeriod node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(TComma node, T1 arg1)
        {
            return HandleTComma(node, arg1);
        }
        protected virtual Result HandleTComma(TComma node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(TColon node, T1 arg1)
        {
            return HandleTColon(node, arg1);
        }
        protected virtual Result HandleTColon(TColon node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(TSemicolon node, T1 arg1)
        {
            return HandleTSemicolon(node, arg1);
        }
        protected virtual Result HandleTSemicolon(TSemicolon node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(TLabelStart node, T1 arg1)
        {
            return HandleTLabelStart(node, arg1);
        }
        protected virtual Result HandleTLabelStart(TLabelStart node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(TTimeStart node, T1 arg1)
        {
            return HandleTTimeStart(node, arg1);
        }
        protected virtual Result HandleTTimeStart(TTimeStart node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(TLabelEnd node, T1 arg1)
        {
            return HandleTLabelEnd(node, arg1);
        }
        protected virtual Result HandleTLabelEnd(TLabelEnd node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(TTimeCall node, T1 arg1)
        {
            return HandleTTimeCall(node, arg1);
        }
        protected virtual Result HandleTTimeCall(TTimeCall node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(TTimeCheck node, T1 arg1)
        {
            return HandleTTimeCheck(node, arg1);
        }
        protected virtual Result HandleTTimeCheck(TTimeCheck node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(TLPar node, T1 arg1)
        {
            return HandleTLPar(node, arg1);
        }
        protected virtual Result HandleTLPar(TLPar node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(TRPar node, T1 arg1)
        {
            return HandleTRPar(node, arg1);
        }
        protected virtual Result HandleTRPar(TRPar node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(TLSqu node, T1 arg1)
        {
            return HandleTLSqu(node, arg1);
        }
        protected virtual Result HandleTLSqu(TLSqu node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(TRSqu node, T1 arg1)
        {
            return HandleTRSqu(node, arg1);
        }
        protected virtual Result HandleTRSqu(TRSqu node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(TLCur node, T1 arg1)
        {
            return HandleTLCur(node, arg1);
        }
        protected virtual Result HandleTLCur(TLCur node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(TRCur node, T1 arg1)
        {
            return HandleTRCur(node, arg1);
        }
        protected virtual Result HandleTRCur(TRCur node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(TJoin node, T1 arg1)
        {
            return HandleTJoin(node, arg1);
        }
        protected virtual Result HandleTJoin(TJoin node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(TComment node, T1 arg1)
        {
            return HandleTComment(node, arg1);
        }
        protected virtual Result HandleTComment(TComment node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(TWhitespace node, T1 arg1)
        {
            return HandleTWhitespace(node, arg1);
        }
        protected virtual Result HandleTWhitespace(TWhitespace node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
    }
    public partial class ReturnAnalysisAdapter<T1, T2, Result> : ReturnAdapter<T1, T2, Result, PRoot>
    {
        public Result Visit(PRoot node, T1 arg1, T2 arg2)
        {
            return HandlePRoot(node, arg1, arg2);
        }
        protected virtual Result HandlePRoot(PRoot node, T1 arg1, T2 arg2)
        {
            return dispatch((dynamic)node, arg1, arg2);
        }
        private Result dispatch(ARoot node, T1 arg1, T2 arg2)
        {
            return HandleARoot(node, arg1, arg2);
        }
        protected virtual Result HandleARoot(ARoot node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        
        public Result Visit(PPreProcessor node, T1 arg1, T2 arg2)
        {
            return HandlePPreProcessor(node, arg1, arg2);
        }
        protected virtual Result HandlePPreProcessor(PPreProcessor node, T1 arg1, T2 arg2)
        {
            return dispatch((dynamic)node, arg1, arg2);
        }
        private Result dispatch(APreProcessor node, T1 arg1, T2 arg2)
        {
            return HandleAPreProcessor(node, arg1, arg2);
        }
        protected virtual Result HandleAPreProcessor(APreProcessor node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        
        public Result Visit(PPrincipalDeclaration node, T1 arg1, T2 arg2)
        {
            return HandlePPrincipalDeclaration(node, arg1, arg2);
        }
        protected virtual Result HandlePPrincipalDeclaration(PPrincipalDeclaration node, T1 arg1, T2 arg2)
        {
            return dispatch((dynamic)node, arg1, arg2);
        }
        private Result dispatch(APrincipalDeclaration node, T1 arg1, T2 arg2)
        {
            return HandleAPrincipalDeclaration(node, arg1, arg2);
        }
        protected virtual Result HandleAPrincipalDeclaration(APrincipalDeclaration node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        
        public Result Visit(PPrincipalHierarchyDeclaration node, T1 arg1, T2 arg2)
        {
            return HandlePPrincipalHierarchyDeclaration(node, arg1, arg2);
        }
        protected virtual Result HandlePPrincipalHierarchyDeclaration(PPrincipalHierarchyDeclaration node, T1 arg1, T2 arg2)
        {
            return dispatch((dynamic)node, arg1, arg2);
        }
        private Result dispatch(APrincipalHierarchyDeclaration node, T1 arg1, T2 arg2)
        {
            return HandleAPrincipalHierarchyDeclaration(node, arg1, arg2);
        }
        protected virtual Result HandleAPrincipalHierarchyDeclaration(APrincipalHierarchyDeclaration node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        
        public Result Visit(PStruct node, T1 arg1, T2 arg2)
        {
            return HandlePStruct(node, arg1, arg2);
        }
        protected virtual Result HandlePStruct(PStruct node, T1 arg1, T2 arg2)
        {
            return dispatch((dynamic)node, arg1, arg2);
        }
        private Result dispatch(AStruct node, T1 arg1, T2 arg2)
        {
            return HandleAStruct(node, arg1, arg2);
        }
        protected virtual Result HandleAStruct(AStruct node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        
        public Result Visit(PField node, T1 arg1, T2 arg2)
        {
            return HandlePField(node, arg1, arg2);
        }
        protected virtual Result HandlePField(PField node, T1 arg1, T2 arg2)
        {
            return dispatch((dynamic)node, arg1, arg2);
        }
        private Result dispatch(AField node, T1 arg1, T2 arg2)
        {
            return HandleAField(node, arg1, arg2);
        }
        protected virtual Result HandleAField(AField node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        private Result dispatch(AArrayField node, T1 arg1, T2 arg2)
        {
            return HandleAArrayField(node, arg1, arg2);
        }
        protected virtual Result HandleAArrayField(AArrayField node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        
        public Result Visit(PStatement node, T1 arg1, T2 arg2)
        {
            return HandlePStatement(node, arg1, arg2);
        }
        protected virtual Result HandlePStatement(PStatement node, T1 arg1, T2 arg2)
        {
            return dispatch((dynamic)node, arg1, arg2);
        }
        private Result dispatch(ADeclarationStatement node, T1 arg1, T2 arg2)
        {
            return HandleADeclarationStatement(node, arg1, arg2);
        }
        protected virtual Result HandleADeclarationStatement(ADeclarationStatement node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        private Result dispatch(AArrayDeclarationStatement node, T1 arg1, T2 arg2)
        {
            return HandleAArrayDeclarationStatement(node, arg1, arg2);
        }
        protected virtual Result HandleAArrayDeclarationStatement(AArrayDeclarationStatement node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        private Result dispatch(AAssignmentStatement node, T1 arg1, T2 arg2)
        {
            return HandleAAssignmentStatement(node, arg1, arg2);
        }
        protected virtual Result HandleAAssignmentStatement(AAssignmentStatement node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        private Result dispatch(AIfActsForStatement node, T1 arg1, T2 arg2)
        {
            return HandleAIfActsForStatement(node, arg1, arg2);
        }
        protected virtual Result HandleAIfActsForStatement(AIfActsForStatement node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        private Result dispatch(AIfActsForElseStatement node, T1 arg1, T2 arg2)
        {
            return HandleAIfActsForElseStatement(node, arg1, arg2);
        }
        protected virtual Result HandleAIfActsForElseStatement(AIfActsForElseStatement node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        private Result dispatch(AIfStatement node, T1 arg1, T2 arg2)
        {
            return HandleAIfStatement(node, arg1, arg2);
        }
        protected virtual Result HandleAIfStatement(AIfStatement node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        private Result dispatch(AIfElseStatement node, T1 arg1, T2 arg2)
        {
            return HandleAIfElseStatement(node, arg1, arg2);
        }
        protected virtual Result HandleAIfElseStatement(AIfElseStatement node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        private Result dispatch(AWhileStatement node, T1 arg1, T2 arg2)
        {
            return HandleAWhileStatement(node, arg1, arg2);
        }
        protected virtual Result HandleAWhileStatement(AWhileStatement node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        private Result dispatch(AFunctionDeclarationStatement node, T1 arg1, T2 arg2)
        {
            return HandleAFunctionDeclarationStatement(node, arg1, arg2);
        }
        protected virtual Result HandleAFunctionDeclarationStatement(AFunctionDeclarationStatement node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        private Result dispatch(AExpressionStatement node, T1 arg1, T2 arg2)
        {
            return HandleAExpressionStatement(node, arg1, arg2);
        }
        protected virtual Result HandleAExpressionStatement(AExpressionStatement node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        private Result dispatch(AReturnStatement node, T1 arg1, T2 arg2)
        {
            return HandleAReturnStatement(node, arg1, arg2);
        }
        protected virtual Result HandleAReturnStatement(AReturnStatement node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        
        public Result Visit(PFunctionParameter node, T1 arg1, T2 arg2)
        {
            return HandlePFunctionParameter(node, arg1, arg2);
        }
        protected virtual Result HandlePFunctionParameter(PFunctionParameter node, T1 arg1, T2 arg2)
        {
            return dispatch((dynamic)node, arg1, arg2);
        }
        private Result dispatch(AFunctionParameter node, T1 arg1, T2 arg2)
        {
            return HandleAFunctionParameter(node, arg1, arg2);
        }
        protected virtual Result HandleAFunctionParameter(AFunctionParameter node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        
        public Result Visit(PType node, T1 arg1, T2 arg2)
        {
            return HandlePType(node, arg1, arg2);
        }
        protected virtual Result HandlePType(PType node, T1 arg1, T2 arg2)
        {
            return dispatch((dynamic)node, arg1, arg2);
        }
        private Result dispatch(AType node, T1 arg1, T2 arg2)
        {
            return HandleAType(node, arg1, arg2);
        }
        protected virtual Result HandleAType(AType node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        private Result dispatch(APointerType node, T1 arg1, T2 arg2)
        {
            return HandleAPointerType(node, arg1, arg2);
        }
        protected virtual Result HandleAPointerType(APointerType node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        
        public Result Visit(PClaimant node, T1 arg1, T2 arg2)
        {
            return HandlePClaimant(node, arg1, arg2);
        }
        protected virtual Result HandlePClaimant(PClaimant node, T1 arg1, T2 arg2)
        {
            return dispatch((dynamic)node, arg1, arg2);
        }
        private Result dispatch(AThisClaimant node, T1 arg1, T2 arg2)
        {
            return HandleAThisClaimant(node, arg1, arg2);
        }
        protected virtual Result HandleAThisClaimant(AThisClaimant node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        private Result dispatch(ACallerClaimant node, T1 arg1, T2 arg2)
        {
            return HandleACallerClaimant(node, arg1, arg2);
        }
        protected virtual Result HandleACallerClaimant(ACallerClaimant node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        
        public Result Visit(PLabel node, T1 arg1, T2 arg2)
        {
            return HandlePLabel(node, arg1, arg2);
        }
        protected virtual Result HandlePLabel(PLabel node, T1 arg1, T2 arg2)
        {
            return dispatch((dynamic)node, arg1, arg2);
        }
        private Result dispatch(ALabel node, T1 arg1, T2 arg2)
        {
            return HandleALabel(node, arg1, arg2);
        }
        protected virtual Result HandleALabel(ALabel node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        
        public Result Visit(PTimePolicy node, T1 arg1, T2 arg2)
        {
            return HandlePTimePolicy(node, arg1, arg2);
        }
        protected virtual Result HandlePTimePolicy(PTimePolicy node, T1 arg1, T2 arg2)
        {
            return dispatch((dynamic)node, arg1, arg2);
        }
        private Result dispatch(ATimePolicy node, T1 arg1, T2 arg2)
        {
            return HandleATimePolicy(node, arg1, arg2);
        }
        protected virtual Result HandleATimePolicy(ATimePolicy node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        
        public Result Visit(PTimingPeriod node, T1 arg1, T2 arg2)
        {
            return HandlePTimingPeriod(node, arg1, arg2);
        }
        protected virtual Result HandlePTimingPeriod(PTimingPeriod node, T1 arg1, T2 arg2)
        {
            return dispatch((dynamic)node, arg1, arg2);
        }
        private Result dispatch(ATimingPeriod node, T1 arg1, T2 arg2)
        {
            return HandleATimingPeriod(node, arg1, arg2);
        }
        protected virtual Result HandleATimingPeriod(ATimingPeriod node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        
        public Result Visit(PTimingInterval node, T1 arg1, T2 arg2)
        {
            return HandlePTimingInterval(node, arg1, arg2);
        }
        protected virtual Result HandlePTimingInterval(PTimingInterval node, T1 arg1, T2 arg2)
        {
            return dispatch((dynamic)node, arg1, arg2);
        }
        private Result dispatch(ATimingInterval node, T1 arg1, T2 arg2)
        {
            return HandleATimingInterval(node, arg1, arg2);
        }
        protected virtual Result HandleATimingInterval(ATimingInterval node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        
        public Result Visit(PPolicy node, T1 arg1, T2 arg2)
        {
            return HandlePPolicy(node, arg1, arg2);
        }
        protected virtual Result HandlePPolicy(PPolicy node, T1 arg1, T2 arg2)
        {
            return dispatch((dynamic)node, arg1, arg2);
        }
        private Result dispatch(AVariablePolicy node, T1 arg1, T2 arg2)
        {
            return HandleAVariablePolicy(node, arg1, arg2);
        }
        protected virtual Result HandleAVariablePolicy(AVariablePolicy node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        private Result dispatch(APrincipalPolicy node, T1 arg1, T2 arg2)
        {
            return HandleAPrincipalPolicy(node, arg1, arg2);
        }
        protected virtual Result HandleAPrincipalPolicy(APrincipalPolicy node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        private Result dispatch(ALowerPolicy node, T1 arg1, T2 arg2)
        {
            return HandleALowerPolicy(node, arg1, arg2);
        }
        protected virtual Result HandleALowerPolicy(ALowerPolicy node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        private Result dispatch(AUpperPolicy node, T1 arg1, T2 arg2)
        {
            return HandleAUpperPolicy(node, arg1, arg2);
        }
        protected virtual Result HandleAUpperPolicy(AUpperPolicy node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        
        public Result Visit(PPrincipal node, T1 arg1, T2 arg2)
        {
            return HandlePPrincipal(node, arg1, arg2);
        }
        protected virtual Result HandlePPrincipal(PPrincipal node, T1 arg1, T2 arg2)
        {
            return dispatch((dynamic)node, arg1, arg2);
        }
        private Result dispatch(APrincipal node, T1 arg1, T2 arg2)
        {
            return HandleAPrincipal(node, arg1, arg2);
        }
        protected virtual Result HandleAPrincipal(APrincipal node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        
        public Result Visit(PExpression node, T1 arg1, T2 arg2)
        {
            return HandlePExpression(node, arg1, arg2);
        }
        protected virtual Result HandlePExpression(PExpression node, T1 arg1, T2 arg2)
        {
            return dispatch((dynamic)node, arg1, arg2);
        }
        private Result dispatch(AAndExpression node, T1 arg1, T2 arg2)
        {
            return HandleAAndExpression(node, arg1, arg2);
        }
        protected virtual Result HandleAAndExpression(AAndExpression node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        private Result dispatch(AOrExpression node, T1 arg1, T2 arg2)
        {
            return HandleAOrExpression(node, arg1, arg2);
        }
        protected virtual Result HandleAOrExpression(AOrExpression node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        private Result dispatch(ANotExpression node, T1 arg1, T2 arg2)
        {
            return HandleANotExpression(node, arg1, arg2);
        }
        protected virtual Result HandleANotExpression(ANotExpression node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        private Result dispatch(AComparisonExpression node, T1 arg1, T2 arg2)
        {
            return HandleAComparisonExpression(node, arg1, arg2);
        }
        protected virtual Result HandleAComparisonExpression(AComparisonExpression node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        private Result dispatch(AElementExpression node, T1 arg1, T2 arg2)
        {
            return HandleAElementExpression(node, arg1, arg2);
        }
        protected virtual Result HandleAElementExpression(AElementExpression node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        private Result dispatch(AIndexExpression node, T1 arg1, T2 arg2)
        {
            return HandleAIndexExpression(node, arg1, arg2);
        }
        protected virtual Result HandleAIndexExpression(AIndexExpression node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        private Result dispatch(APlusExpression node, T1 arg1, T2 arg2)
        {
            return HandleAPlusExpression(node, arg1, arg2);
        }
        protected virtual Result HandleAPlusExpression(APlusExpression node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        private Result dispatch(AMinusExpression node, T1 arg1, T2 arg2)
        {
            return HandleAMinusExpression(node, arg1, arg2);
        }
        protected virtual Result HandleAMinusExpression(AMinusExpression node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        private Result dispatch(AMultiplyExpression node, T1 arg1, T2 arg2)
        {
            return HandleAMultiplyExpression(node, arg1, arg2);
        }
        protected virtual Result HandleAMultiplyExpression(AMultiplyExpression node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        private Result dispatch(ADivideExpression node, T1 arg1, T2 arg2)
        {
            return HandleADivideExpression(node, arg1, arg2);
        }
        protected virtual Result HandleADivideExpression(ADivideExpression node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        private Result dispatch(AModuloExpression node, T1 arg1, T2 arg2)
        {
            return HandleAModuloExpression(node, arg1, arg2);
        }
        protected virtual Result HandleAModuloExpression(AModuloExpression node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        private Result dispatch(ANegateExpression node, T1 arg1, T2 arg2)
        {
            return HandleANegateExpression(node, arg1, arg2);
        }
        protected virtual Result HandleANegateExpression(ANegateExpression node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        private Result dispatch(AFunctionCallExpression node, T1 arg1, T2 arg2)
        {
            return HandleAFunctionCallExpression(node, arg1, arg2);
        }
        protected virtual Result HandleAFunctionCallExpression(AFunctionCallExpression node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        private Result dispatch(ATernaryExpression node, T1 arg1, T2 arg2)
        {
            return HandleATernaryExpression(node, arg1, arg2);
        }
        protected virtual Result HandleATernaryExpression(ATernaryExpression node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        private Result dispatch(AParenthesisExpression node, T1 arg1, T2 arg2)
        {
            return HandleAParenthesisExpression(node, arg1, arg2);
        }
        protected virtual Result HandleAParenthesisExpression(AParenthesisExpression node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        private Result dispatch(ADeclassifyExpression node, T1 arg1, T2 arg2)
        {
            return HandleADeclassifyExpression(node, arg1, arg2);
        }
        protected virtual Result HandleADeclassifyExpression(ADeclassifyExpression node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        private Result dispatch(ADereferenceExpression node, T1 arg1, T2 arg2)
        {
            return HandleADereferenceExpression(node, arg1, arg2);
        }
        protected virtual Result HandleADereferenceExpression(ADereferenceExpression node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        private Result dispatch(AAddressExpression node, T1 arg1, T2 arg2)
        {
            return HandleAAddressExpression(node, arg1, arg2);
        }
        protected virtual Result HandleAAddressExpression(AAddressExpression node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        private Result dispatch(AIdentifierExpression node, T1 arg1, T2 arg2)
        {
            return HandleAIdentifierExpression(node, arg1, arg2);
        }
        protected virtual Result HandleAIdentifierExpression(AIdentifierExpression node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        private Result dispatch(ATimeCheckExpression node, T1 arg1, T2 arg2)
        {
            return HandleATimeCheckExpression(node, arg1, arg2);
        }
        protected virtual Result HandleATimeCheckExpression(ATimeCheckExpression node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        private Result dispatch(ANumberExpression node, T1 arg1, T2 arg2)
        {
            return HandleANumberExpression(node, arg1, arg2);
        }
        protected virtual Result HandleANumberExpression(ANumberExpression node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        private Result dispatch(ABooleanExpression node, T1 arg1, T2 arg2)
        {
            return HandleABooleanExpression(node, arg1, arg2);
        }
        protected virtual Result HandleABooleanExpression(ABooleanExpression node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        private Result dispatch(ANullExpression node, T1 arg1, T2 arg2)
        {
            return HandleANullExpression(node, arg1, arg2);
        }
        protected virtual Result HandleANullExpression(ANullExpression node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        private Result dispatch(ACharExpression node, T1 arg1, T2 arg2)
        {
            return HandleACharExpression(node, arg1, arg2);
        }
        protected virtual Result HandleACharExpression(ACharExpression node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        private Result dispatch(AStringExpression node, T1 arg1, T2 arg2)
        {
            return HandleAStringExpression(node, arg1, arg2);
        }
        protected virtual Result HandleAStringExpression(AStringExpression node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        
        public Result Visit(PElement node, T1 arg1, T2 arg2)
        {
            return HandlePElement(node, arg1, arg2);
        }
        protected virtual Result HandlePElement(PElement node, T1 arg1, T2 arg2)
        {
            return dispatch((dynamic)node, arg1, arg2);
        }
        private Result dispatch(AElement node, T1 arg1, T2 arg2)
        {
            return HandleAElement(node, arg1, arg2);
        }
        protected virtual Result HandleAElement(AElement node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        private Result dispatch(APointerElement node, T1 arg1, T2 arg2)
        {
            return HandleAPointerElement(node, arg1, arg2);
        }
        protected virtual Result HandleAPointerElement(APointerElement node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        
        public Result Visit(TDirective node, T1 arg1, T2 arg2)
        {
            return HandleTDirective(node, arg1, arg2);
        }
        protected virtual Result HandleTDirective(TDirective node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(TTime node, T1 arg1, T2 arg2)
        {
            return HandleTTime(node, arg1, arg2);
        }
        protected virtual Result HandleTTime(TTime node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(TIntervalUnit node, T1 arg1, T2 arg2)
        {
            return HandleTIntervalUnit(node, arg1, arg2);
        }
        protected virtual Result HandleTIntervalUnit(TIntervalUnit node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(TBool node, T1 arg1, T2 arg2)
        {
            return HandleTBool(node, arg1, arg2);
        }
        protected virtual Result HandleTBool(TBool node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(TNumber node, T1 arg1, T2 arg2)
        {
            return HandleTNumber(node, arg1, arg2);
        }
        protected virtual Result HandleTNumber(TNumber node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(TPrincipall node, T1 arg1, T2 arg2)
        {
            return HandleTPrincipall(node, arg1, arg2);
        }
        protected virtual Result HandleTPrincipall(TPrincipall node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(TTypedef node, T1 arg1, T2 arg2)
        {
            return HandleTTypedef(node, arg1, arg2);
        }
        protected virtual Result HandleTTypedef(TTypedef node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(TStruct node, T1 arg1, T2 arg2)
        {
            return HandleTStruct(node, arg1, arg2);
        }
        protected virtual Result HandleTStruct(TStruct node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(TWhile node, T1 arg1, T2 arg2)
        {
            return HandleTWhile(node, arg1, arg2);
        }
        protected virtual Result HandleTWhile(TWhile node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(TIf node, T1 arg1, T2 arg2)
        {
            return HandleTIf(node, arg1, arg2);
        }
        protected virtual Result HandleTIf(TIf node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(TElse node, T1 arg1, T2 arg2)
        {
            return HandleTElse(node, arg1, arg2);
        }
        protected virtual Result HandleTElse(TElse node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(TReturn node, T1 arg1, T2 arg2)
        {
            return HandleTReturn(node, arg1, arg2);
        }
        protected virtual Result HandleTReturn(TReturn node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(TThis node, T1 arg1, T2 arg2)
        {
            return HandleTThis(node, arg1, arg2);
        }
        protected virtual Result HandleTThis(TThis node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(TCaller node, T1 arg1, T2 arg2)
        {
            return HandleTCaller(node, arg1, arg2);
        }
        protected virtual Result HandleTCaller(TCaller node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(TNull node, T1 arg1, T2 arg2)
        {
            return HandleTNull(node, arg1, arg2);
        }
        protected virtual Result HandleTNull(TNull node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(TChar node, T1 arg1, T2 arg2)
        {
            return HandleTChar(node, arg1, arg2);
        }
        protected virtual Result HandleTChar(TChar node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(TCharErr node, T1 arg1, T2 arg2)
        {
            return HandleTCharErr(node, arg1, arg2);
        }
        protected virtual Result HandleTCharErr(TCharErr node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(TString node, T1 arg1, T2 arg2)
        {
            return HandleTString(node, arg1, arg2);
        }
        protected virtual Result HandleTString(TString node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(TStringErr node, T1 arg1, T2 arg2)
        {
            return HandleTStringErr(node, arg1, arg2);
        }
        protected virtual Result HandleTStringErr(TStringErr node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(TIdentifier node, T1 arg1, T2 arg2)
        {
            return HandleTIdentifier(node, arg1, arg2);
        }
        protected virtual Result HandleTIdentifier(TIdentifier node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(TActsFor node, T1 arg1, T2 arg2)
        {
            return HandleTActsFor(node, arg1, arg2);
        }
        protected virtual Result HandleTActsFor(TActsFor node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(TIfActsFor node, T1 arg1, T2 arg2)
        {
            return HandleTIfActsFor(node, arg1, arg2);
        }
        protected virtual Result HandleTIfActsFor(TIfActsFor node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(TDeclassifyStart node, T1 arg1, T2 arg2)
        {
            return HandleTDeclassifyStart(node, arg1, arg2);
        }
        protected virtual Result HandleTDeclassifyStart(TDeclassifyStart node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(TDeclassifyEnd node, T1 arg1, T2 arg2)
        {
            return HandleTDeclassifyEnd(node, arg1, arg2);
        }
        protected virtual Result HandleTDeclassifyEnd(TDeclassifyEnd node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(TFuncAuthStart node, T1 arg1, T2 arg2)
        {
            return HandleTFuncAuthStart(node, arg1, arg2);
        }
        protected virtual Result HandleTFuncAuthStart(TFuncAuthStart node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(TFuncAuthEnd node, T1 arg1, T2 arg2)
        {
            return HandleTFuncAuthEnd(node, arg1, arg2);
        }
        protected virtual Result HandleTFuncAuthEnd(TFuncAuthEnd node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(TRArrow node, T1 arg1, T2 arg2)
        {
            return HandleTRArrow(node, arg1, arg2);
        }
        protected virtual Result HandleTRArrow(TRArrow node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(TLArrow node, T1 arg1, T2 arg2)
        {
            return HandleTLArrow(node, arg1, arg2);
        }
        protected virtual Result HandleTLArrow(TLArrow node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(TCompare node, T1 arg1, T2 arg2)
        {
            return HandleTCompare(node, arg1, arg2);
        }
        protected virtual Result HandleTCompare(TCompare node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(TAssign node, T1 arg1, T2 arg2)
        {
            return HandleTAssign(node, arg1, arg2);
        }
        protected virtual Result HandleTAssign(TAssign node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(TUnderscore node, T1 arg1, T2 arg2)
        {
            return HandleTUnderscore(node, arg1, arg2);
        }
        protected virtual Result HandleTUnderscore(TUnderscore node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(THat node, T1 arg1, T2 arg2)
        {
            return HandleTHat(node, arg1, arg2);
        }
        protected virtual Result HandleTHat(THat node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(TPlus node, T1 arg1, T2 arg2)
        {
            return HandleTPlus(node, arg1, arg2);
        }
        protected virtual Result HandleTPlus(TPlus node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(TMinus node, T1 arg1, T2 arg2)
        {
            return HandleTMinus(node, arg1, arg2);
        }
        protected virtual Result HandleTMinus(TMinus node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(TAsterisk node, T1 arg1, T2 arg2)
        {
            return HandleTAsterisk(node, arg1, arg2);
        }
        protected virtual Result HandleTAsterisk(TAsterisk node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(TSlash node, T1 arg1, T2 arg2)
        {
            return HandleTSlash(node, arg1, arg2);
        }
        protected virtual Result HandleTSlash(TSlash node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(TPercent node, T1 arg1, T2 arg2)
        {
            return HandleTPercent(node, arg1, arg2);
        }
        protected virtual Result HandleTPercent(TPercent node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(TAmpersand node, T1 arg1, T2 arg2)
        {
            return HandleTAmpersand(node, arg1, arg2);
        }
        protected virtual Result HandleTAmpersand(TAmpersand node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(TBang node, T1 arg1, T2 arg2)
        {
            return HandleTBang(node, arg1, arg2);
        }
        protected virtual Result HandleTBang(TBang node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(TAnd node, T1 arg1, T2 arg2)
        {
            return HandleTAnd(node, arg1, arg2);
        }
        protected virtual Result HandleTAnd(TAnd node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(TOr node, T1 arg1, T2 arg2)
        {
            return HandleTOr(node, arg1, arg2);
        }
        protected virtual Result HandleTOr(TOr node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(TQuestion node, T1 arg1, T2 arg2)
        {
            return HandleTQuestion(node, arg1, arg2);
        }
        protected virtual Result HandleTQuestion(TQuestion node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(TPeriod node, T1 arg1, T2 arg2)
        {
            return HandleTPeriod(node, arg1, arg2);
        }
        protected virtual Result HandleTPeriod(TPeriod node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(TComma node, T1 arg1, T2 arg2)
        {
            return HandleTComma(node, arg1, arg2);
        }
        protected virtual Result HandleTComma(TComma node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(TColon node, T1 arg1, T2 arg2)
        {
            return HandleTColon(node, arg1, arg2);
        }
        protected virtual Result HandleTColon(TColon node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(TSemicolon node, T1 arg1, T2 arg2)
        {
            return HandleTSemicolon(node, arg1, arg2);
        }
        protected virtual Result HandleTSemicolon(TSemicolon node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(TLabelStart node, T1 arg1, T2 arg2)
        {
            return HandleTLabelStart(node, arg1, arg2);
        }
        protected virtual Result HandleTLabelStart(TLabelStart node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(TTimeStart node, T1 arg1, T2 arg2)
        {
            return HandleTTimeStart(node, arg1, arg2);
        }
        protected virtual Result HandleTTimeStart(TTimeStart node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(TLabelEnd node, T1 arg1, T2 arg2)
        {
            return HandleTLabelEnd(node, arg1, arg2);
        }
        protected virtual Result HandleTLabelEnd(TLabelEnd node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(TTimeCall node, T1 arg1, T2 arg2)
        {
            return HandleTTimeCall(node, arg1, arg2);
        }
        protected virtual Result HandleTTimeCall(TTimeCall node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(TTimeCheck node, T1 arg1, T2 arg2)
        {
            return HandleTTimeCheck(node, arg1, arg2);
        }
        protected virtual Result HandleTTimeCheck(TTimeCheck node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(TLPar node, T1 arg1, T2 arg2)
        {
            return HandleTLPar(node, arg1, arg2);
        }
        protected virtual Result HandleTLPar(TLPar node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(TRPar node, T1 arg1, T2 arg2)
        {
            return HandleTRPar(node, arg1, arg2);
        }
        protected virtual Result HandleTRPar(TRPar node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(TLSqu node, T1 arg1, T2 arg2)
        {
            return HandleTLSqu(node, arg1, arg2);
        }
        protected virtual Result HandleTLSqu(TLSqu node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(TRSqu node, T1 arg1, T2 arg2)
        {
            return HandleTRSqu(node, arg1, arg2);
        }
        protected virtual Result HandleTRSqu(TRSqu node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(TLCur node, T1 arg1, T2 arg2)
        {
            return HandleTLCur(node, arg1, arg2);
        }
        protected virtual Result HandleTLCur(TLCur node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(TRCur node, T1 arg1, T2 arg2)
        {
            return HandleTRCur(node, arg1, arg2);
        }
        protected virtual Result HandleTRCur(TRCur node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(TJoin node, T1 arg1, T2 arg2)
        {
            return HandleTJoin(node, arg1, arg2);
        }
        protected virtual Result HandleTJoin(TJoin node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(TComment node, T1 arg1, T2 arg2)
        {
            return HandleTComment(node, arg1, arg2);
        }
        protected virtual Result HandleTComment(TComment node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(TWhitespace node, T1 arg1, T2 arg2)
        {
            return HandleTWhitespace(node, arg1, arg2);
        }
        protected virtual Result HandleTWhitespace(TWhitespace node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
    }
    public partial class ReturnAnalysisAdapter<T1, T2, T3, Result> : ReturnAdapter<T1, T2, T3, Result, PRoot>
    {
        public Result Visit(PRoot node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandlePRoot(node, arg1, arg2, arg3);
        }
        protected virtual Result HandlePRoot(PRoot node, T1 arg1, T2 arg2, T3 arg3)
        {
            return dispatch((dynamic)node, arg1, arg2, arg3);
        }
        private Result dispatch(ARoot node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleARoot(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleARoot(ARoot node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        
        public Result Visit(PPreProcessor node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandlePPreProcessor(node, arg1, arg2, arg3);
        }
        protected virtual Result HandlePPreProcessor(PPreProcessor node, T1 arg1, T2 arg2, T3 arg3)
        {
            return dispatch((dynamic)node, arg1, arg2, arg3);
        }
        private Result dispatch(APreProcessor node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleAPreProcessor(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleAPreProcessor(APreProcessor node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        
        public Result Visit(PPrincipalDeclaration node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandlePPrincipalDeclaration(node, arg1, arg2, arg3);
        }
        protected virtual Result HandlePPrincipalDeclaration(PPrincipalDeclaration node, T1 arg1, T2 arg2, T3 arg3)
        {
            return dispatch((dynamic)node, arg1, arg2, arg3);
        }
        private Result dispatch(APrincipalDeclaration node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleAPrincipalDeclaration(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleAPrincipalDeclaration(APrincipalDeclaration node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        
        public Result Visit(PPrincipalHierarchyDeclaration node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandlePPrincipalHierarchyDeclaration(node, arg1, arg2, arg3);
        }
        protected virtual Result HandlePPrincipalHierarchyDeclaration(PPrincipalHierarchyDeclaration node, T1 arg1, T2 arg2, T3 arg3)
        {
            return dispatch((dynamic)node, arg1, arg2, arg3);
        }
        private Result dispatch(APrincipalHierarchyDeclaration node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleAPrincipalHierarchyDeclaration(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleAPrincipalHierarchyDeclaration(APrincipalHierarchyDeclaration node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        
        public Result Visit(PStruct node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandlePStruct(node, arg1, arg2, arg3);
        }
        protected virtual Result HandlePStruct(PStruct node, T1 arg1, T2 arg2, T3 arg3)
        {
            return dispatch((dynamic)node, arg1, arg2, arg3);
        }
        private Result dispatch(AStruct node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleAStruct(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleAStruct(AStruct node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        
        public Result Visit(PField node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandlePField(node, arg1, arg2, arg3);
        }
        protected virtual Result HandlePField(PField node, T1 arg1, T2 arg2, T3 arg3)
        {
            return dispatch((dynamic)node, arg1, arg2, arg3);
        }
        private Result dispatch(AField node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleAField(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleAField(AField node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        private Result dispatch(AArrayField node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleAArrayField(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleAArrayField(AArrayField node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        
        public Result Visit(PStatement node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandlePStatement(node, arg1, arg2, arg3);
        }
        protected virtual Result HandlePStatement(PStatement node, T1 arg1, T2 arg2, T3 arg3)
        {
            return dispatch((dynamic)node, arg1, arg2, arg3);
        }
        private Result dispatch(ADeclarationStatement node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleADeclarationStatement(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleADeclarationStatement(ADeclarationStatement node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        private Result dispatch(AArrayDeclarationStatement node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleAArrayDeclarationStatement(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleAArrayDeclarationStatement(AArrayDeclarationStatement node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        private Result dispatch(AAssignmentStatement node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleAAssignmentStatement(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleAAssignmentStatement(AAssignmentStatement node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        private Result dispatch(AIfActsForStatement node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleAIfActsForStatement(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleAIfActsForStatement(AIfActsForStatement node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        private Result dispatch(AIfActsForElseStatement node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleAIfActsForElseStatement(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleAIfActsForElseStatement(AIfActsForElseStatement node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        private Result dispatch(AIfStatement node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleAIfStatement(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleAIfStatement(AIfStatement node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        private Result dispatch(AIfElseStatement node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleAIfElseStatement(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleAIfElseStatement(AIfElseStatement node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        private Result dispatch(AWhileStatement node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleAWhileStatement(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleAWhileStatement(AWhileStatement node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        private Result dispatch(AFunctionDeclarationStatement node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleAFunctionDeclarationStatement(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleAFunctionDeclarationStatement(AFunctionDeclarationStatement node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        private Result dispatch(AExpressionStatement node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleAExpressionStatement(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleAExpressionStatement(AExpressionStatement node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        private Result dispatch(AReturnStatement node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleAReturnStatement(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleAReturnStatement(AReturnStatement node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        
        public Result Visit(PFunctionParameter node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandlePFunctionParameter(node, arg1, arg2, arg3);
        }
        protected virtual Result HandlePFunctionParameter(PFunctionParameter node, T1 arg1, T2 arg2, T3 arg3)
        {
            return dispatch((dynamic)node, arg1, arg2, arg3);
        }
        private Result dispatch(AFunctionParameter node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleAFunctionParameter(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleAFunctionParameter(AFunctionParameter node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        
        public Result Visit(PType node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandlePType(node, arg1, arg2, arg3);
        }
        protected virtual Result HandlePType(PType node, T1 arg1, T2 arg2, T3 arg3)
        {
            return dispatch((dynamic)node, arg1, arg2, arg3);
        }
        private Result dispatch(AType node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleAType(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleAType(AType node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        private Result dispatch(APointerType node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleAPointerType(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleAPointerType(APointerType node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        
        public Result Visit(PClaimant node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandlePClaimant(node, arg1, arg2, arg3);
        }
        protected virtual Result HandlePClaimant(PClaimant node, T1 arg1, T2 arg2, T3 arg3)
        {
            return dispatch((dynamic)node, arg1, arg2, arg3);
        }
        private Result dispatch(AThisClaimant node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleAThisClaimant(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleAThisClaimant(AThisClaimant node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        private Result dispatch(ACallerClaimant node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleACallerClaimant(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleACallerClaimant(ACallerClaimant node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        
        public Result Visit(PLabel node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandlePLabel(node, arg1, arg2, arg3);
        }
        protected virtual Result HandlePLabel(PLabel node, T1 arg1, T2 arg2, T3 arg3)
        {
            return dispatch((dynamic)node, arg1, arg2, arg3);
        }
        private Result dispatch(ALabel node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleALabel(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleALabel(ALabel node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        
        public Result Visit(PTimePolicy node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandlePTimePolicy(node, arg1, arg2, arg3);
        }
        protected virtual Result HandlePTimePolicy(PTimePolicy node, T1 arg1, T2 arg2, T3 arg3)
        {
            return dispatch((dynamic)node, arg1, arg2, arg3);
        }
        private Result dispatch(ATimePolicy node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleATimePolicy(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleATimePolicy(ATimePolicy node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        
        public Result Visit(PTimingPeriod node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandlePTimingPeriod(node, arg1, arg2, arg3);
        }
        protected virtual Result HandlePTimingPeriod(PTimingPeriod node, T1 arg1, T2 arg2, T3 arg3)
        {
            return dispatch((dynamic)node, arg1, arg2, arg3);
        }
        private Result dispatch(ATimingPeriod node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleATimingPeriod(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleATimingPeriod(ATimingPeriod node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        
        public Result Visit(PTimingInterval node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandlePTimingInterval(node, arg1, arg2, arg3);
        }
        protected virtual Result HandlePTimingInterval(PTimingInterval node, T1 arg1, T2 arg2, T3 arg3)
        {
            return dispatch((dynamic)node, arg1, arg2, arg3);
        }
        private Result dispatch(ATimingInterval node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleATimingInterval(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleATimingInterval(ATimingInterval node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        
        public Result Visit(PPolicy node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandlePPolicy(node, arg1, arg2, arg3);
        }
        protected virtual Result HandlePPolicy(PPolicy node, T1 arg1, T2 arg2, T3 arg3)
        {
            return dispatch((dynamic)node, arg1, arg2, arg3);
        }
        private Result dispatch(AVariablePolicy node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleAVariablePolicy(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleAVariablePolicy(AVariablePolicy node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        private Result dispatch(APrincipalPolicy node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleAPrincipalPolicy(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleAPrincipalPolicy(APrincipalPolicy node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        private Result dispatch(ALowerPolicy node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleALowerPolicy(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleALowerPolicy(ALowerPolicy node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        private Result dispatch(AUpperPolicy node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleAUpperPolicy(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleAUpperPolicy(AUpperPolicy node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        
        public Result Visit(PPrincipal node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandlePPrincipal(node, arg1, arg2, arg3);
        }
        protected virtual Result HandlePPrincipal(PPrincipal node, T1 arg1, T2 arg2, T3 arg3)
        {
            return dispatch((dynamic)node, arg1, arg2, arg3);
        }
        private Result dispatch(APrincipal node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleAPrincipal(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleAPrincipal(APrincipal node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        
        public Result Visit(PExpression node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandlePExpression(node, arg1, arg2, arg3);
        }
        protected virtual Result HandlePExpression(PExpression node, T1 arg1, T2 arg2, T3 arg3)
        {
            return dispatch((dynamic)node, arg1, arg2, arg3);
        }
        private Result dispatch(AAndExpression node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleAAndExpression(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleAAndExpression(AAndExpression node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        private Result dispatch(AOrExpression node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleAOrExpression(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleAOrExpression(AOrExpression node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        private Result dispatch(ANotExpression node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleANotExpression(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleANotExpression(ANotExpression node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        private Result dispatch(AComparisonExpression node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleAComparisonExpression(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleAComparisonExpression(AComparisonExpression node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        private Result dispatch(AElementExpression node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleAElementExpression(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleAElementExpression(AElementExpression node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        private Result dispatch(AIndexExpression node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleAIndexExpression(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleAIndexExpression(AIndexExpression node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        private Result dispatch(APlusExpression node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleAPlusExpression(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleAPlusExpression(APlusExpression node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        private Result dispatch(AMinusExpression node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleAMinusExpression(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleAMinusExpression(AMinusExpression node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        private Result dispatch(AMultiplyExpression node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleAMultiplyExpression(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleAMultiplyExpression(AMultiplyExpression node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        private Result dispatch(ADivideExpression node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleADivideExpression(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleADivideExpression(ADivideExpression node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        private Result dispatch(AModuloExpression node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleAModuloExpression(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleAModuloExpression(AModuloExpression node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        private Result dispatch(ANegateExpression node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleANegateExpression(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleANegateExpression(ANegateExpression node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        private Result dispatch(AFunctionCallExpression node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleAFunctionCallExpression(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleAFunctionCallExpression(AFunctionCallExpression node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        private Result dispatch(ATernaryExpression node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleATernaryExpression(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleATernaryExpression(ATernaryExpression node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        private Result dispatch(AParenthesisExpression node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleAParenthesisExpression(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleAParenthesisExpression(AParenthesisExpression node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        private Result dispatch(ADeclassifyExpression node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleADeclassifyExpression(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleADeclassifyExpression(ADeclassifyExpression node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        private Result dispatch(ADereferenceExpression node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleADereferenceExpression(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleADereferenceExpression(ADereferenceExpression node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        private Result dispatch(AAddressExpression node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleAAddressExpression(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleAAddressExpression(AAddressExpression node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        private Result dispatch(AIdentifierExpression node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleAIdentifierExpression(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleAIdentifierExpression(AIdentifierExpression node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        private Result dispatch(ATimeCheckExpression node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleATimeCheckExpression(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleATimeCheckExpression(ATimeCheckExpression node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        private Result dispatch(ANumberExpression node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleANumberExpression(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleANumberExpression(ANumberExpression node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        private Result dispatch(ABooleanExpression node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleABooleanExpression(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleABooleanExpression(ABooleanExpression node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        private Result dispatch(ANullExpression node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleANullExpression(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleANullExpression(ANullExpression node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        private Result dispatch(ACharExpression node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleACharExpression(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleACharExpression(ACharExpression node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        private Result dispatch(AStringExpression node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleAStringExpression(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleAStringExpression(AStringExpression node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        
        public Result Visit(PElement node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandlePElement(node, arg1, arg2, arg3);
        }
        protected virtual Result HandlePElement(PElement node, T1 arg1, T2 arg2, T3 arg3)
        {
            return dispatch((dynamic)node, arg1, arg2, arg3);
        }
        private Result dispatch(AElement node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleAElement(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleAElement(AElement node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        private Result dispatch(APointerElement node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleAPointerElement(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleAPointerElement(APointerElement node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        
        public Result Visit(TDirective node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleTDirective(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleTDirective(TDirective node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(TTime node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleTTime(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleTTime(TTime node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(TIntervalUnit node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleTIntervalUnit(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleTIntervalUnit(TIntervalUnit node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(TBool node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleTBool(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleTBool(TBool node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(TNumber node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleTNumber(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleTNumber(TNumber node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(TPrincipall node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleTPrincipall(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleTPrincipall(TPrincipall node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(TTypedef node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleTTypedef(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleTTypedef(TTypedef node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(TStruct node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleTStruct(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleTStruct(TStruct node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(TWhile node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleTWhile(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleTWhile(TWhile node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(TIf node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleTIf(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleTIf(TIf node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(TElse node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleTElse(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleTElse(TElse node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(TReturn node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleTReturn(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleTReturn(TReturn node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(TThis node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleTThis(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleTThis(TThis node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(TCaller node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleTCaller(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleTCaller(TCaller node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(TNull node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleTNull(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleTNull(TNull node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(TChar node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleTChar(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleTChar(TChar node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(TCharErr node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleTCharErr(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleTCharErr(TCharErr node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(TString node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleTString(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleTString(TString node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(TStringErr node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleTStringErr(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleTStringErr(TStringErr node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(TIdentifier node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleTIdentifier(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleTIdentifier(TIdentifier node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(TActsFor node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleTActsFor(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleTActsFor(TActsFor node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(TIfActsFor node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleTIfActsFor(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleTIfActsFor(TIfActsFor node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(TDeclassifyStart node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleTDeclassifyStart(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleTDeclassifyStart(TDeclassifyStart node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(TDeclassifyEnd node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleTDeclassifyEnd(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleTDeclassifyEnd(TDeclassifyEnd node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(TFuncAuthStart node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleTFuncAuthStart(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleTFuncAuthStart(TFuncAuthStart node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(TFuncAuthEnd node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleTFuncAuthEnd(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleTFuncAuthEnd(TFuncAuthEnd node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(TRArrow node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleTRArrow(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleTRArrow(TRArrow node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(TLArrow node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleTLArrow(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleTLArrow(TLArrow node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(TCompare node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleTCompare(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleTCompare(TCompare node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(TAssign node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleTAssign(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleTAssign(TAssign node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(TUnderscore node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleTUnderscore(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleTUnderscore(TUnderscore node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(THat node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleTHat(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleTHat(THat node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(TPlus node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleTPlus(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleTPlus(TPlus node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(TMinus node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleTMinus(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleTMinus(TMinus node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(TAsterisk node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleTAsterisk(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleTAsterisk(TAsterisk node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(TSlash node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleTSlash(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleTSlash(TSlash node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(TPercent node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleTPercent(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleTPercent(TPercent node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(TAmpersand node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleTAmpersand(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleTAmpersand(TAmpersand node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(TBang node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleTBang(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleTBang(TBang node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(TAnd node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleTAnd(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleTAnd(TAnd node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(TOr node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleTOr(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleTOr(TOr node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(TQuestion node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleTQuestion(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleTQuestion(TQuestion node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(TPeriod node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleTPeriod(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleTPeriod(TPeriod node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(TComma node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleTComma(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleTComma(TComma node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(TColon node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleTColon(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleTColon(TColon node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(TSemicolon node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleTSemicolon(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleTSemicolon(TSemicolon node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(TLabelStart node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleTLabelStart(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleTLabelStart(TLabelStart node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(TTimeStart node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleTTimeStart(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleTTimeStart(TTimeStart node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(TLabelEnd node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleTLabelEnd(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleTLabelEnd(TLabelEnd node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(TTimeCall node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleTTimeCall(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleTTimeCall(TTimeCall node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(TTimeCheck node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleTTimeCheck(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleTTimeCheck(TTimeCheck node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(TLPar node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleTLPar(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleTLPar(TLPar node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(TRPar node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleTRPar(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleTRPar(TRPar node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(TLSqu node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleTLSqu(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleTLSqu(TLSqu node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(TRSqu node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleTRSqu(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleTRSqu(TRSqu node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(TLCur node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleTLCur(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleTLCur(TLCur node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(TRCur node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleTRCur(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleTRCur(TRCur node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(TJoin node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleTJoin(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleTJoin(TJoin node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(TComment node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleTComment(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleTComment(TComment node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(TWhitespace node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleTWhitespace(node, arg1, arg2, arg3);
        }
        protected virtual Result HandleTWhitespace(TWhitespace node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
    }
    
    #endregion
}
