using System.Collections.Generic;
using System.Linq;
using SablePP.Tools.Analysis;
using SablePP.Tools.Nodes;
using DLM.Editor.Nodes;

namespace DLM.Editor.Analysis
{
    #region Analysis adapters
    
    public partial class AnalysisAdapter : AnalysisAdapter<object>
    {
    }
    public partial class AnalysisAdapter<Value> : Adapter<Value, PExpression>
    {
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
        private void dispatch(AFunctionCallExpression node)
        {
            HandleAFunctionCallExpression(node);
        }
        protected virtual void HandleAFunctionCallExpression(AFunctionCallExpression node)
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
        private void dispatch(AParenthesisExpression node)
        {
            HandleAParenthesisExpression(node);
        }
        protected virtual void HandleAParenthesisExpression(AParenthesisExpression node)
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
        public void Visit(TActfor node)
        {
            HandleTActfor(node);
        }
        protected virtual void HandleTActfor(TActfor node)
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
        public void Visit(TLabelStart node)
        {
            HandleTLabelStart(node);
        }
        protected virtual void HandleTLabelStart(TLabelStart node)
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
        
        protected override void HandleStart(Start<PExpression> node)
        {
            Visit(node.Root);
            Visit(node.EOF);
        }
        
        protected override void HandleAAndExpression(AAndExpression node)
        {
            Visit(node.Left);
            Visit(node.Right);
        }
        protected override void HandleAOrExpression(AOrExpression node)
        {
            Visit(node.Left);
            Visit(node.Right);
        }
        protected override void HandleANotExpression(ANotExpression node)
        {
            Visit(node.Left);
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
            Visit(node.Index);
        }
        protected override void HandleAPlusExpression(APlusExpression node)
        {
            Visit(node.Left);
            Visit(node.Right);
        }
        protected override void HandleAMinusExpression(AMinusExpression node)
        {
            Visit(node.Left);
            Visit(node.Right);
        }
        protected override void HandleAMultiplyExpression(AMultiplyExpression node)
        {
            Visit(node.Left);
            Visit(node.Right);
        }
        protected override void HandleADivideExpression(ADivideExpression node)
        {
            Visit(node.Left);
            Visit(node.Right);
        }
        protected override void HandleAModuloExpression(AModuloExpression node)
        {
            Visit(node.Left);
            Visit(node.Right);
        }
        protected override void HandleAFunctionCallExpression(AFunctionCallExpression node)
        {
            Visit(node.Function);
            Visit(node.Arguments);
        }
        protected override void HandleANegateExpression(ANegateExpression node)
        {
            Visit(node.Right);
        }
        protected override void HandleAParenthesisExpression(AParenthesisExpression node)
        {
            Visit(node.Expression);
        }
        protected override void HandleAIdentifierExpression(AIdentifierExpression node)
        {
            Visit(node.Identifier);
        }
        protected override void HandleANumberExpression(ANumberExpression node)
        {
            Visit(node.Number);
        }
        protected override void HandleABooleanExpression(ABooleanExpression node)
        {
            Visit(node.Bool);
        }
        protected override void HandleAElement(AElement node)
        {
            Visit(node.Identifier);
        }
        protected override void HandleAPointerElement(APointerElement node)
        {
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
        
        protected override void HandleStart(Start<PExpression> node)
        {
            Visit(node.EOF);
            Visit(node.Root);
        }
        
        protected override void HandleAAndExpression(AAndExpression node)
        {
            Visit(node.Right);
            Visit(node.Left);
        }
        protected override void HandleAOrExpression(AOrExpression node)
        {
            Visit(node.Right);
            Visit(node.Left);
        }
        protected override void HandleANotExpression(ANotExpression node)
        {
            Visit(node.Left);
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
            Visit(node.Index);
            Visit(node.Expression);
        }
        protected override void HandleAPlusExpression(APlusExpression node)
        {
            Visit(node.Right);
            Visit(node.Left);
        }
        protected override void HandleAMinusExpression(AMinusExpression node)
        {
            Visit(node.Right);
            Visit(node.Left);
        }
        protected override void HandleAMultiplyExpression(AMultiplyExpression node)
        {
            Visit(node.Right);
            Visit(node.Left);
        }
        protected override void HandleADivideExpression(ADivideExpression node)
        {
            Visit(node.Right);
            Visit(node.Left);
        }
        protected override void HandleAModuloExpression(AModuloExpression node)
        {
            Visit(node.Right);
            Visit(node.Left);
        }
        protected override void HandleAFunctionCallExpression(AFunctionCallExpression node)
        {
            Visit(node.Arguments);
            Visit(node.Function);
        }
        protected override void HandleANegateExpression(ANegateExpression node)
        {
            Visit(node.Right);
        }
        protected override void HandleAParenthesisExpression(AParenthesisExpression node)
        {
            Visit(node.Expression);
        }
        protected override void HandleAIdentifierExpression(AIdentifierExpression node)
        {
            Visit(node.Identifier);
        }
        protected override void HandleANumberExpression(ANumberExpression node)
        {
            Visit(node.Number);
        }
        protected override void HandleABooleanExpression(ABooleanExpression node)
        {
            Visit(node.Bool);
        }
        protected override void HandleAElement(AElement node)
        {
            Visit(node.Identifier);
        }
        protected override void HandleAPointerElement(APointerElement node)
        {
            Visit(node.Identifier);
        }
    }
    
    #endregion
    
    #region Return analysis adapters
    
    public partial class ReturnAnalysisAdapter<Result> : ReturnAdapter<Result, PExpression>
    {
        public Result Visit(AAndExpression node)
        {
            return HandleAAndExpression(node);
        }
        public virtual Result HandleAAndExpression(AAndExpression node)
        {
            return HandleDefault(node);
        }
        public Result Visit(AOrExpression node)
        {
            return HandleAOrExpression(node);
        }
        public virtual Result HandleAOrExpression(AOrExpression node)
        {
            return HandleDefault(node);
        }
        public Result Visit(ANotExpression node)
        {
            return HandleANotExpression(node);
        }
        public virtual Result HandleANotExpression(ANotExpression node)
        {
            return HandleDefault(node);
        }
        public Result Visit(AComparisonExpression node)
        {
            return HandleAComparisonExpression(node);
        }
        public virtual Result HandleAComparisonExpression(AComparisonExpression node)
        {
            return HandleDefault(node);
        }
        public Result Visit(AElementExpression node)
        {
            return HandleAElementExpression(node);
        }
        public virtual Result HandleAElementExpression(AElementExpression node)
        {
            return HandleDefault(node);
        }
        public Result Visit(AIndexExpression node)
        {
            return HandleAIndexExpression(node);
        }
        public virtual Result HandleAIndexExpression(AIndexExpression node)
        {
            return HandleDefault(node);
        }
        public Result Visit(APlusExpression node)
        {
            return HandleAPlusExpression(node);
        }
        public virtual Result HandleAPlusExpression(APlusExpression node)
        {
            return HandleDefault(node);
        }
        public Result Visit(AMinusExpression node)
        {
            return HandleAMinusExpression(node);
        }
        public virtual Result HandleAMinusExpression(AMinusExpression node)
        {
            return HandleDefault(node);
        }
        public Result Visit(AMultiplyExpression node)
        {
            return HandleAMultiplyExpression(node);
        }
        public virtual Result HandleAMultiplyExpression(AMultiplyExpression node)
        {
            return HandleDefault(node);
        }
        public Result Visit(ADivideExpression node)
        {
            return HandleADivideExpression(node);
        }
        public virtual Result HandleADivideExpression(ADivideExpression node)
        {
            return HandleDefault(node);
        }
        public Result Visit(AModuloExpression node)
        {
            return HandleAModuloExpression(node);
        }
        public virtual Result HandleAModuloExpression(AModuloExpression node)
        {
            return HandleDefault(node);
        }
        public Result Visit(AFunctionCallExpression node)
        {
            return HandleAFunctionCallExpression(node);
        }
        public virtual Result HandleAFunctionCallExpression(AFunctionCallExpression node)
        {
            return HandleDefault(node);
        }
        public Result Visit(ANegateExpression node)
        {
            return HandleANegateExpression(node);
        }
        public virtual Result HandleANegateExpression(ANegateExpression node)
        {
            return HandleDefault(node);
        }
        public Result Visit(AParenthesisExpression node)
        {
            return HandleAParenthesisExpression(node);
        }
        public virtual Result HandleAParenthesisExpression(AParenthesisExpression node)
        {
            return HandleDefault(node);
        }
        public Result Visit(AIdentifierExpression node)
        {
            return HandleAIdentifierExpression(node);
        }
        public virtual Result HandleAIdentifierExpression(AIdentifierExpression node)
        {
            return HandleDefault(node);
        }
        public Result Visit(ANumberExpression node)
        {
            return HandleANumberExpression(node);
        }
        public virtual Result HandleANumberExpression(ANumberExpression node)
        {
            return HandleDefault(node);
        }
        public Result Visit(ABooleanExpression node)
        {
            return HandleABooleanExpression(node);
        }
        public virtual Result HandleABooleanExpression(ABooleanExpression node)
        {
            return HandleDefault(node);
        }
        public Result Visit(AElement node)
        {
            return HandleAElement(node);
        }
        public virtual Result HandleAElement(AElement node)
        {
            return HandleDefault(node);
        }
        public Result Visit(APointerElement node)
        {
            return HandleAPointerElement(node);
        }
        public virtual Result HandleAPointerElement(APointerElement node)
        {
            return HandleDefault(node);
        }
        public Result Visit(TBool node)
        {
            return HandleTBool(node);
        }
        public virtual Result HandleTBool(TBool node)
        {
            return HandleDefault(node);
        }
        public Result Visit(TNumber node)
        {
            return HandleTNumber(node);
        }
        public virtual Result HandleTNumber(TNumber node)
        {
            return HandleDefault(node);
        }
        public Result Visit(TWhile node)
        {
            return HandleTWhile(node);
        }
        public virtual Result HandleTWhile(TWhile node)
        {
            return HandleDefault(node);
        }
        public Result Visit(TIf node)
        {
            return HandleTIf(node);
        }
        public virtual Result HandleTIf(TIf node)
        {
            return HandleDefault(node);
        }
        public Result Visit(TElse node)
        {
            return HandleTElse(node);
        }
        public virtual Result HandleTElse(TElse node)
        {
            return HandleDefault(node);
        }
        public Result Visit(TReturn node)
        {
            return HandleTReturn(node);
        }
        public virtual Result HandleTReturn(TReturn node)
        {
            return HandleDefault(node);
        }
        public Result Visit(TActfor node)
        {
            return HandleTActfor(node);
        }
        public virtual Result HandleTActfor(TActfor node)
        {
            return HandleDefault(node);
        }
        public Result Visit(TIdentifier node)
        {
            return HandleTIdentifier(node);
        }
        public virtual Result HandleTIdentifier(TIdentifier node)
        {
            return HandleDefault(node);
        }
        public Result Visit(TRArrow node)
        {
            return HandleTRArrow(node);
        }
        public virtual Result HandleTRArrow(TRArrow node)
        {
            return HandleDefault(node);
        }
        public Result Visit(TLArrow node)
        {
            return HandleTLArrow(node);
        }
        public virtual Result HandleTLArrow(TLArrow node)
        {
            return HandleDefault(node);
        }
        public Result Visit(TCompare node)
        {
            return HandleTCompare(node);
        }
        public virtual Result HandleTCompare(TCompare node)
        {
            return HandleDefault(node);
        }
        public Result Visit(TPlus node)
        {
            return HandleTPlus(node);
        }
        public virtual Result HandleTPlus(TPlus node)
        {
            return HandleDefault(node);
        }
        public Result Visit(TMinus node)
        {
            return HandleTMinus(node);
        }
        public virtual Result HandleTMinus(TMinus node)
        {
            return HandleDefault(node);
        }
        public Result Visit(TAsterisk node)
        {
            return HandleTAsterisk(node);
        }
        public virtual Result HandleTAsterisk(TAsterisk node)
        {
            return HandleDefault(node);
        }
        public Result Visit(TSlash node)
        {
            return HandleTSlash(node);
        }
        public virtual Result HandleTSlash(TSlash node)
        {
            return HandleDefault(node);
        }
        public Result Visit(TPercent node)
        {
            return HandleTPercent(node);
        }
        public virtual Result HandleTPercent(TPercent node)
        {
            return HandleDefault(node);
        }
        public Result Visit(TBang node)
        {
            return HandleTBang(node);
        }
        public virtual Result HandleTBang(TBang node)
        {
            return HandleDefault(node);
        }
        public Result Visit(TAnd node)
        {
            return HandleTAnd(node);
        }
        public virtual Result HandleTAnd(TAnd node)
        {
            return HandleDefault(node);
        }
        public Result Visit(TOr node)
        {
            return HandleTOr(node);
        }
        public virtual Result HandleTOr(TOr node)
        {
            return HandleDefault(node);
        }
        public Result Visit(TPeriod node)
        {
            return HandleTPeriod(node);
        }
        public virtual Result HandleTPeriod(TPeriod node)
        {
            return HandleDefault(node);
        }
        public Result Visit(TComma node)
        {
            return HandleTComma(node);
        }
        public virtual Result HandleTComma(TComma node)
        {
            return HandleDefault(node);
        }
        public Result Visit(TLabelStart node)
        {
            return HandleTLabelStart(node);
        }
        public virtual Result HandleTLabelStart(TLabelStart node)
        {
            return HandleDefault(node);
        }
        public Result Visit(TLabelEnd node)
        {
            return HandleTLabelEnd(node);
        }
        public virtual Result HandleTLabelEnd(TLabelEnd node)
        {
            return HandleDefault(node);
        }
        public Result Visit(TLPar node)
        {
            return HandleTLPar(node);
        }
        public virtual Result HandleTLPar(TLPar node)
        {
            return HandleDefault(node);
        }
        public Result Visit(TRPar node)
        {
            return HandleTRPar(node);
        }
        public virtual Result HandleTRPar(TRPar node)
        {
            return HandleDefault(node);
        }
        public Result Visit(TLSqu node)
        {
            return HandleTLSqu(node);
        }
        public virtual Result HandleTLSqu(TLSqu node)
        {
            return HandleDefault(node);
        }
        public Result Visit(TRSqu node)
        {
            return HandleTRSqu(node);
        }
        public virtual Result HandleTRSqu(TRSqu node)
        {
            return HandleDefault(node);
        }
        public Result Visit(TComment node)
        {
            return HandleTComment(node);
        }
        public virtual Result HandleTComment(TComment node)
        {
            return HandleDefault(node);
        }
        public Result Visit(TWhitespace node)
        {
            return HandleTWhitespace(node);
        }
        public virtual Result HandleTWhitespace(TWhitespace node)
        {
            return HandleDefault(node);
        }
    }
    public partial class ReturnAnalysisAdapter<T1, Result> : ReturnAdapter<T1, Result, PExpression>
    {
        public Result Visit(AAndExpression node, T1 arg1)
        {
            return HandleAAndExpression(node, arg1);
        }
        public virtual Result HandleAAndExpression(AAndExpression node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(AOrExpression node, T1 arg1)
        {
            return HandleAOrExpression(node, arg1);
        }
        public virtual Result HandleAOrExpression(AOrExpression node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(ANotExpression node, T1 arg1)
        {
            return HandleANotExpression(node, arg1);
        }
        public virtual Result HandleANotExpression(ANotExpression node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(AComparisonExpression node, T1 arg1)
        {
            return HandleAComparisonExpression(node, arg1);
        }
        public virtual Result HandleAComparisonExpression(AComparisonExpression node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(AElementExpression node, T1 arg1)
        {
            return HandleAElementExpression(node, arg1);
        }
        public virtual Result HandleAElementExpression(AElementExpression node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(AIndexExpression node, T1 arg1)
        {
            return HandleAIndexExpression(node, arg1);
        }
        public virtual Result HandleAIndexExpression(AIndexExpression node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(APlusExpression node, T1 arg1)
        {
            return HandleAPlusExpression(node, arg1);
        }
        public virtual Result HandleAPlusExpression(APlusExpression node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(AMinusExpression node, T1 arg1)
        {
            return HandleAMinusExpression(node, arg1);
        }
        public virtual Result HandleAMinusExpression(AMinusExpression node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(AMultiplyExpression node, T1 arg1)
        {
            return HandleAMultiplyExpression(node, arg1);
        }
        public virtual Result HandleAMultiplyExpression(AMultiplyExpression node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(ADivideExpression node, T1 arg1)
        {
            return HandleADivideExpression(node, arg1);
        }
        public virtual Result HandleADivideExpression(ADivideExpression node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(AModuloExpression node, T1 arg1)
        {
            return HandleAModuloExpression(node, arg1);
        }
        public virtual Result HandleAModuloExpression(AModuloExpression node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(AFunctionCallExpression node, T1 arg1)
        {
            return HandleAFunctionCallExpression(node, arg1);
        }
        public virtual Result HandleAFunctionCallExpression(AFunctionCallExpression node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(ANegateExpression node, T1 arg1)
        {
            return HandleANegateExpression(node, arg1);
        }
        public virtual Result HandleANegateExpression(ANegateExpression node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(AParenthesisExpression node, T1 arg1)
        {
            return HandleAParenthesisExpression(node, arg1);
        }
        public virtual Result HandleAParenthesisExpression(AParenthesisExpression node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(AIdentifierExpression node, T1 arg1)
        {
            return HandleAIdentifierExpression(node, arg1);
        }
        public virtual Result HandleAIdentifierExpression(AIdentifierExpression node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(ANumberExpression node, T1 arg1)
        {
            return HandleANumberExpression(node, arg1);
        }
        public virtual Result HandleANumberExpression(ANumberExpression node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(ABooleanExpression node, T1 arg1)
        {
            return HandleABooleanExpression(node, arg1);
        }
        public virtual Result HandleABooleanExpression(ABooleanExpression node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(AElement node, T1 arg1)
        {
            return HandleAElement(node, arg1);
        }
        public virtual Result HandleAElement(AElement node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(APointerElement node, T1 arg1)
        {
            return HandleAPointerElement(node, arg1);
        }
        public virtual Result HandleAPointerElement(APointerElement node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(TBool node, T1 arg1)
        {
            return HandleTBool(node, arg1);
        }
        public virtual Result HandleTBool(TBool node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(TNumber node, T1 arg1)
        {
            return HandleTNumber(node, arg1);
        }
        public virtual Result HandleTNumber(TNumber node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(TWhile node, T1 arg1)
        {
            return HandleTWhile(node, arg1);
        }
        public virtual Result HandleTWhile(TWhile node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(TIf node, T1 arg1)
        {
            return HandleTIf(node, arg1);
        }
        public virtual Result HandleTIf(TIf node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(TElse node, T1 arg1)
        {
            return HandleTElse(node, arg1);
        }
        public virtual Result HandleTElse(TElse node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(TReturn node, T1 arg1)
        {
            return HandleTReturn(node, arg1);
        }
        public virtual Result HandleTReturn(TReturn node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(TActfor node, T1 arg1)
        {
            return HandleTActfor(node, arg1);
        }
        public virtual Result HandleTActfor(TActfor node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(TIdentifier node, T1 arg1)
        {
            return HandleTIdentifier(node, arg1);
        }
        public virtual Result HandleTIdentifier(TIdentifier node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(TRArrow node, T1 arg1)
        {
            return HandleTRArrow(node, arg1);
        }
        public virtual Result HandleTRArrow(TRArrow node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(TLArrow node, T1 arg1)
        {
            return HandleTLArrow(node, arg1);
        }
        public virtual Result HandleTLArrow(TLArrow node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(TCompare node, T1 arg1)
        {
            return HandleTCompare(node, arg1);
        }
        public virtual Result HandleTCompare(TCompare node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(TPlus node, T1 arg1)
        {
            return HandleTPlus(node, arg1);
        }
        public virtual Result HandleTPlus(TPlus node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(TMinus node, T1 arg1)
        {
            return HandleTMinus(node, arg1);
        }
        public virtual Result HandleTMinus(TMinus node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(TAsterisk node, T1 arg1)
        {
            return HandleTAsterisk(node, arg1);
        }
        public virtual Result HandleTAsterisk(TAsterisk node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(TSlash node, T1 arg1)
        {
            return HandleTSlash(node, arg1);
        }
        public virtual Result HandleTSlash(TSlash node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(TPercent node, T1 arg1)
        {
            return HandleTPercent(node, arg1);
        }
        public virtual Result HandleTPercent(TPercent node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(TBang node, T1 arg1)
        {
            return HandleTBang(node, arg1);
        }
        public virtual Result HandleTBang(TBang node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(TAnd node, T1 arg1)
        {
            return HandleTAnd(node, arg1);
        }
        public virtual Result HandleTAnd(TAnd node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(TOr node, T1 arg1)
        {
            return HandleTOr(node, arg1);
        }
        public virtual Result HandleTOr(TOr node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(TPeriod node, T1 arg1)
        {
            return HandleTPeriod(node, arg1);
        }
        public virtual Result HandleTPeriod(TPeriod node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(TComma node, T1 arg1)
        {
            return HandleTComma(node, arg1);
        }
        public virtual Result HandleTComma(TComma node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(TLabelStart node, T1 arg1)
        {
            return HandleTLabelStart(node, arg1);
        }
        public virtual Result HandleTLabelStart(TLabelStart node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(TLabelEnd node, T1 arg1)
        {
            return HandleTLabelEnd(node, arg1);
        }
        public virtual Result HandleTLabelEnd(TLabelEnd node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(TLPar node, T1 arg1)
        {
            return HandleTLPar(node, arg1);
        }
        public virtual Result HandleTLPar(TLPar node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(TRPar node, T1 arg1)
        {
            return HandleTRPar(node, arg1);
        }
        public virtual Result HandleTRPar(TRPar node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(TLSqu node, T1 arg1)
        {
            return HandleTLSqu(node, arg1);
        }
        public virtual Result HandleTLSqu(TLSqu node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(TRSqu node, T1 arg1)
        {
            return HandleTRSqu(node, arg1);
        }
        public virtual Result HandleTRSqu(TRSqu node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(TComment node, T1 arg1)
        {
            return HandleTComment(node, arg1);
        }
        public virtual Result HandleTComment(TComment node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
        public Result Visit(TWhitespace node, T1 arg1)
        {
            return HandleTWhitespace(node, arg1);
        }
        public virtual Result HandleTWhitespace(TWhitespace node, T1 arg1)
        {
            return HandleDefault(node, arg1);
        }
    }
    public partial class ReturnAnalysisAdapter<T1, T2, Result> : ReturnAdapter<T1, T2, Result, PExpression>
    {
        public Result Visit(AAndExpression node, T1 arg1, T2 arg2)
        {
            return HandleAAndExpression(node, arg1, arg2);
        }
        public virtual Result HandleAAndExpression(AAndExpression node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(AOrExpression node, T1 arg1, T2 arg2)
        {
            return HandleAOrExpression(node, arg1, arg2);
        }
        public virtual Result HandleAOrExpression(AOrExpression node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(ANotExpression node, T1 arg1, T2 arg2)
        {
            return HandleANotExpression(node, arg1, arg2);
        }
        public virtual Result HandleANotExpression(ANotExpression node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(AComparisonExpression node, T1 arg1, T2 arg2)
        {
            return HandleAComparisonExpression(node, arg1, arg2);
        }
        public virtual Result HandleAComparisonExpression(AComparisonExpression node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(AElementExpression node, T1 arg1, T2 arg2)
        {
            return HandleAElementExpression(node, arg1, arg2);
        }
        public virtual Result HandleAElementExpression(AElementExpression node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(AIndexExpression node, T1 arg1, T2 arg2)
        {
            return HandleAIndexExpression(node, arg1, arg2);
        }
        public virtual Result HandleAIndexExpression(AIndexExpression node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(APlusExpression node, T1 arg1, T2 arg2)
        {
            return HandleAPlusExpression(node, arg1, arg2);
        }
        public virtual Result HandleAPlusExpression(APlusExpression node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(AMinusExpression node, T1 arg1, T2 arg2)
        {
            return HandleAMinusExpression(node, arg1, arg2);
        }
        public virtual Result HandleAMinusExpression(AMinusExpression node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(AMultiplyExpression node, T1 arg1, T2 arg2)
        {
            return HandleAMultiplyExpression(node, arg1, arg2);
        }
        public virtual Result HandleAMultiplyExpression(AMultiplyExpression node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(ADivideExpression node, T1 arg1, T2 arg2)
        {
            return HandleADivideExpression(node, arg1, arg2);
        }
        public virtual Result HandleADivideExpression(ADivideExpression node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(AModuloExpression node, T1 arg1, T2 arg2)
        {
            return HandleAModuloExpression(node, arg1, arg2);
        }
        public virtual Result HandleAModuloExpression(AModuloExpression node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(AFunctionCallExpression node, T1 arg1, T2 arg2)
        {
            return HandleAFunctionCallExpression(node, arg1, arg2);
        }
        public virtual Result HandleAFunctionCallExpression(AFunctionCallExpression node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(ANegateExpression node, T1 arg1, T2 arg2)
        {
            return HandleANegateExpression(node, arg1, arg2);
        }
        public virtual Result HandleANegateExpression(ANegateExpression node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(AParenthesisExpression node, T1 arg1, T2 arg2)
        {
            return HandleAParenthesisExpression(node, arg1, arg2);
        }
        public virtual Result HandleAParenthesisExpression(AParenthesisExpression node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(AIdentifierExpression node, T1 arg1, T2 arg2)
        {
            return HandleAIdentifierExpression(node, arg1, arg2);
        }
        public virtual Result HandleAIdentifierExpression(AIdentifierExpression node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(ANumberExpression node, T1 arg1, T2 arg2)
        {
            return HandleANumberExpression(node, arg1, arg2);
        }
        public virtual Result HandleANumberExpression(ANumberExpression node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(ABooleanExpression node, T1 arg1, T2 arg2)
        {
            return HandleABooleanExpression(node, arg1, arg2);
        }
        public virtual Result HandleABooleanExpression(ABooleanExpression node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(AElement node, T1 arg1, T2 arg2)
        {
            return HandleAElement(node, arg1, arg2);
        }
        public virtual Result HandleAElement(AElement node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(APointerElement node, T1 arg1, T2 arg2)
        {
            return HandleAPointerElement(node, arg1, arg2);
        }
        public virtual Result HandleAPointerElement(APointerElement node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(TBool node, T1 arg1, T2 arg2)
        {
            return HandleTBool(node, arg1, arg2);
        }
        public virtual Result HandleTBool(TBool node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(TNumber node, T1 arg1, T2 arg2)
        {
            return HandleTNumber(node, arg1, arg2);
        }
        public virtual Result HandleTNumber(TNumber node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(TWhile node, T1 arg1, T2 arg2)
        {
            return HandleTWhile(node, arg1, arg2);
        }
        public virtual Result HandleTWhile(TWhile node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(TIf node, T1 arg1, T2 arg2)
        {
            return HandleTIf(node, arg1, arg2);
        }
        public virtual Result HandleTIf(TIf node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(TElse node, T1 arg1, T2 arg2)
        {
            return HandleTElse(node, arg1, arg2);
        }
        public virtual Result HandleTElse(TElse node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(TReturn node, T1 arg1, T2 arg2)
        {
            return HandleTReturn(node, arg1, arg2);
        }
        public virtual Result HandleTReturn(TReturn node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(TActfor node, T1 arg1, T2 arg2)
        {
            return HandleTActfor(node, arg1, arg2);
        }
        public virtual Result HandleTActfor(TActfor node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(TIdentifier node, T1 arg1, T2 arg2)
        {
            return HandleTIdentifier(node, arg1, arg2);
        }
        public virtual Result HandleTIdentifier(TIdentifier node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(TRArrow node, T1 arg1, T2 arg2)
        {
            return HandleTRArrow(node, arg1, arg2);
        }
        public virtual Result HandleTRArrow(TRArrow node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(TLArrow node, T1 arg1, T2 arg2)
        {
            return HandleTLArrow(node, arg1, arg2);
        }
        public virtual Result HandleTLArrow(TLArrow node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(TCompare node, T1 arg1, T2 arg2)
        {
            return HandleTCompare(node, arg1, arg2);
        }
        public virtual Result HandleTCompare(TCompare node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(TPlus node, T1 arg1, T2 arg2)
        {
            return HandleTPlus(node, arg1, arg2);
        }
        public virtual Result HandleTPlus(TPlus node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(TMinus node, T1 arg1, T2 arg2)
        {
            return HandleTMinus(node, arg1, arg2);
        }
        public virtual Result HandleTMinus(TMinus node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(TAsterisk node, T1 arg1, T2 arg2)
        {
            return HandleTAsterisk(node, arg1, arg2);
        }
        public virtual Result HandleTAsterisk(TAsterisk node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(TSlash node, T1 arg1, T2 arg2)
        {
            return HandleTSlash(node, arg1, arg2);
        }
        public virtual Result HandleTSlash(TSlash node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(TPercent node, T1 arg1, T2 arg2)
        {
            return HandleTPercent(node, arg1, arg2);
        }
        public virtual Result HandleTPercent(TPercent node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(TBang node, T1 arg1, T2 arg2)
        {
            return HandleTBang(node, arg1, arg2);
        }
        public virtual Result HandleTBang(TBang node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(TAnd node, T1 arg1, T2 arg2)
        {
            return HandleTAnd(node, arg1, arg2);
        }
        public virtual Result HandleTAnd(TAnd node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(TOr node, T1 arg1, T2 arg2)
        {
            return HandleTOr(node, arg1, arg2);
        }
        public virtual Result HandleTOr(TOr node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(TPeriod node, T1 arg1, T2 arg2)
        {
            return HandleTPeriod(node, arg1, arg2);
        }
        public virtual Result HandleTPeriod(TPeriod node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(TComma node, T1 arg1, T2 arg2)
        {
            return HandleTComma(node, arg1, arg2);
        }
        public virtual Result HandleTComma(TComma node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(TLabelStart node, T1 arg1, T2 arg2)
        {
            return HandleTLabelStart(node, arg1, arg2);
        }
        public virtual Result HandleTLabelStart(TLabelStart node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(TLabelEnd node, T1 arg1, T2 arg2)
        {
            return HandleTLabelEnd(node, arg1, arg2);
        }
        public virtual Result HandleTLabelEnd(TLabelEnd node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(TLPar node, T1 arg1, T2 arg2)
        {
            return HandleTLPar(node, arg1, arg2);
        }
        public virtual Result HandleTLPar(TLPar node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(TRPar node, T1 arg1, T2 arg2)
        {
            return HandleTRPar(node, arg1, arg2);
        }
        public virtual Result HandleTRPar(TRPar node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(TLSqu node, T1 arg1, T2 arg2)
        {
            return HandleTLSqu(node, arg1, arg2);
        }
        public virtual Result HandleTLSqu(TLSqu node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(TRSqu node, T1 arg1, T2 arg2)
        {
            return HandleTRSqu(node, arg1, arg2);
        }
        public virtual Result HandleTRSqu(TRSqu node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(TComment node, T1 arg1, T2 arg2)
        {
            return HandleTComment(node, arg1, arg2);
        }
        public virtual Result HandleTComment(TComment node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
        public Result Visit(TWhitespace node, T1 arg1, T2 arg2)
        {
            return HandleTWhitespace(node, arg1, arg2);
        }
        public virtual Result HandleTWhitespace(TWhitespace node, T1 arg1, T2 arg2)
        {
            return HandleDefault(node, arg1, arg2);
        }
    }
    public partial class ReturnAnalysisAdapter<T1, T2, T3, Result> : ReturnAdapter<T1, T2, T3, Result, PExpression>
    {
        public Result Visit(AAndExpression node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleAAndExpression(node, arg1, arg2, arg3);
        }
        public virtual Result HandleAAndExpression(AAndExpression node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(AOrExpression node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleAOrExpression(node, arg1, arg2, arg3);
        }
        public virtual Result HandleAOrExpression(AOrExpression node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(ANotExpression node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleANotExpression(node, arg1, arg2, arg3);
        }
        public virtual Result HandleANotExpression(ANotExpression node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(AComparisonExpression node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleAComparisonExpression(node, arg1, arg2, arg3);
        }
        public virtual Result HandleAComparisonExpression(AComparisonExpression node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(AElementExpression node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleAElementExpression(node, arg1, arg2, arg3);
        }
        public virtual Result HandleAElementExpression(AElementExpression node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(AIndexExpression node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleAIndexExpression(node, arg1, arg2, arg3);
        }
        public virtual Result HandleAIndexExpression(AIndexExpression node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(APlusExpression node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleAPlusExpression(node, arg1, arg2, arg3);
        }
        public virtual Result HandleAPlusExpression(APlusExpression node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(AMinusExpression node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleAMinusExpression(node, arg1, arg2, arg3);
        }
        public virtual Result HandleAMinusExpression(AMinusExpression node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(AMultiplyExpression node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleAMultiplyExpression(node, arg1, arg2, arg3);
        }
        public virtual Result HandleAMultiplyExpression(AMultiplyExpression node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(ADivideExpression node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleADivideExpression(node, arg1, arg2, arg3);
        }
        public virtual Result HandleADivideExpression(ADivideExpression node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(AModuloExpression node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleAModuloExpression(node, arg1, arg2, arg3);
        }
        public virtual Result HandleAModuloExpression(AModuloExpression node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(AFunctionCallExpression node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleAFunctionCallExpression(node, arg1, arg2, arg3);
        }
        public virtual Result HandleAFunctionCallExpression(AFunctionCallExpression node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(ANegateExpression node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleANegateExpression(node, arg1, arg2, arg3);
        }
        public virtual Result HandleANegateExpression(ANegateExpression node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(AParenthesisExpression node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleAParenthesisExpression(node, arg1, arg2, arg3);
        }
        public virtual Result HandleAParenthesisExpression(AParenthesisExpression node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(AIdentifierExpression node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleAIdentifierExpression(node, arg1, arg2, arg3);
        }
        public virtual Result HandleAIdentifierExpression(AIdentifierExpression node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(ANumberExpression node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleANumberExpression(node, arg1, arg2, arg3);
        }
        public virtual Result HandleANumberExpression(ANumberExpression node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(ABooleanExpression node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleABooleanExpression(node, arg1, arg2, arg3);
        }
        public virtual Result HandleABooleanExpression(ABooleanExpression node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(AElement node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleAElement(node, arg1, arg2, arg3);
        }
        public virtual Result HandleAElement(AElement node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(APointerElement node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleAPointerElement(node, arg1, arg2, arg3);
        }
        public virtual Result HandleAPointerElement(APointerElement node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(TBool node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleTBool(node, arg1, arg2, arg3);
        }
        public virtual Result HandleTBool(TBool node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(TNumber node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleTNumber(node, arg1, arg2, arg3);
        }
        public virtual Result HandleTNumber(TNumber node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(TWhile node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleTWhile(node, arg1, arg2, arg3);
        }
        public virtual Result HandleTWhile(TWhile node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(TIf node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleTIf(node, arg1, arg2, arg3);
        }
        public virtual Result HandleTIf(TIf node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(TElse node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleTElse(node, arg1, arg2, arg3);
        }
        public virtual Result HandleTElse(TElse node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(TReturn node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleTReturn(node, arg1, arg2, arg3);
        }
        public virtual Result HandleTReturn(TReturn node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(TActfor node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleTActfor(node, arg1, arg2, arg3);
        }
        public virtual Result HandleTActfor(TActfor node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(TIdentifier node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleTIdentifier(node, arg1, arg2, arg3);
        }
        public virtual Result HandleTIdentifier(TIdentifier node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(TRArrow node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleTRArrow(node, arg1, arg2, arg3);
        }
        public virtual Result HandleTRArrow(TRArrow node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(TLArrow node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleTLArrow(node, arg1, arg2, arg3);
        }
        public virtual Result HandleTLArrow(TLArrow node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(TCompare node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleTCompare(node, arg1, arg2, arg3);
        }
        public virtual Result HandleTCompare(TCompare node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(TPlus node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleTPlus(node, arg1, arg2, arg3);
        }
        public virtual Result HandleTPlus(TPlus node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(TMinus node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleTMinus(node, arg1, arg2, arg3);
        }
        public virtual Result HandleTMinus(TMinus node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(TAsterisk node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleTAsterisk(node, arg1, arg2, arg3);
        }
        public virtual Result HandleTAsterisk(TAsterisk node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(TSlash node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleTSlash(node, arg1, arg2, arg3);
        }
        public virtual Result HandleTSlash(TSlash node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(TPercent node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleTPercent(node, arg1, arg2, arg3);
        }
        public virtual Result HandleTPercent(TPercent node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(TBang node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleTBang(node, arg1, arg2, arg3);
        }
        public virtual Result HandleTBang(TBang node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(TAnd node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleTAnd(node, arg1, arg2, arg3);
        }
        public virtual Result HandleTAnd(TAnd node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(TOr node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleTOr(node, arg1, arg2, arg3);
        }
        public virtual Result HandleTOr(TOr node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(TPeriod node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleTPeriod(node, arg1, arg2, arg3);
        }
        public virtual Result HandleTPeriod(TPeriod node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(TComma node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleTComma(node, arg1, arg2, arg3);
        }
        public virtual Result HandleTComma(TComma node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(TLabelStart node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleTLabelStart(node, arg1, arg2, arg3);
        }
        public virtual Result HandleTLabelStart(TLabelStart node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(TLabelEnd node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleTLabelEnd(node, arg1, arg2, arg3);
        }
        public virtual Result HandleTLabelEnd(TLabelEnd node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(TLPar node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleTLPar(node, arg1, arg2, arg3);
        }
        public virtual Result HandleTLPar(TLPar node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(TRPar node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleTRPar(node, arg1, arg2, arg3);
        }
        public virtual Result HandleTRPar(TRPar node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(TLSqu node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleTLSqu(node, arg1, arg2, arg3);
        }
        public virtual Result HandleTLSqu(TLSqu node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(TRSqu node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleTRSqu(node, arg1, arg2, arg3);
        }
        public virtual Result HandleTRSqu(TRSqu node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(TComment node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleTComment(node, arg1, arg2, arg3);
        }
        public virtual Result HandleTComment(TComment node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
        public Result Visit(TWhitespace node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleTWhitespace(node, arg1, arg2, arg3);
        }
        public virtual Result HandleTWhitespace(TWhitespace node, T1 arg1, T2 arg2, T3 arg3)
        {
            return HandleDefault(node, arg1, arg2, arg3);
        }
    }
    
    #endregion
}
