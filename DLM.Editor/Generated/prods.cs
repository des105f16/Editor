using System;
using System.Collections.Generic;
using SablePP.Tools.Nodes;
using DLM.Editor.Analysis;

namespace DLM.Editor.Nodes
{
    public abstract partial class PRoot : Production<PRoot>
    {
        private NodeList<PInclude> _includes_;
        private NodeList<PStatement> _statements_;
        
        public PRoot(IEnumerable<PInclude> _includes_, IEnumerable<PStatement> _statements_)
        {
            this._includes_ = new NodeList<PInclude>(this, _includes_, true);
            this._statements_ = new NodeList<PStatement>(this, _statements_, true);
        }
        
        public NodeList<PInclude> Includes
        {
            get { return _includes_; }
        }
        public NodeList<PStatement> Statements
        {
            get { return _statements_; }
        }
        
    }
    public partial class ARoot : PRoot
    {
        public ARoot(IEnumerable<PInclude> _includes_, IEnumerable<PStatement> _statements_)
            : base(_includes_, _statements_)
        {
        }
        
        public override void ReplaceChild(Node oldChild, Node newChild)
        {
            if (oldChild is PInclude && Includes.Contains(oldChild as PInclude))
            {
                if (!(newChild is PInclude) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                
                int index = Includes.IndexOf(oldChild as PInclude);
                if (newChild == null)
                    Includes.RemoveAt(index);
                else
                    Includes[index] = newChild as PInclude;
            }
            else if (oldChild is PStatement && Statements.Contains(oldChild as PStatement))
            {
                if (!(newChild is PStatement) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                
                int index = Statements.IndexOf(oldChild as PStatement);
                if (newChild == null)
                    Statements.RemoveAt(index);
                else
                    Statements[index] = newChild as PStatement;
            }
            else throw new ArgumentException("Node to be replaced is not a child in this production.");
        }
        protected override IEnumerable<Node> GetChildren()
        {
            {
                PInclude[] temp = new PInclude[Includes.Count];
                Includes.CopyTo(temp, 0);
                for (int i = 0; i < temp.Length; i++)
                    yield return temp[i];
            }
            {
                PStatement[] temp = new PStatement[Statements.Count];
                Statements.CopyTo(temp, 0);
                for (int i = 0; i < temp.Length; i++)
                    yield return temp[i];
            }
        }
        
        public override PRoot Clone()
        {
            return new ARoot(Includes, Statements);
        }
        
        public override string ToString()
        {
            return string.Format("{0} {1}", Includes, Statements);
        }
    }
    public abstract partial class PInclude : Production<PInclude>
    {
        private TFile _file_;
        
        public PInclude(TFile _file_)
        {
            this.File = _file_;
        }
        
        public TFile File
        {
            get { return _file_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("File in PInclude cannot be null.", "value");
                
                if (_file_ != null)
                    SetParent(_file_, null);
                SetParent(value, this);
                
                _file_ = value;
            }
        }
        
    }
    public partial class AInclude : PInclude
    {
        public AInclude(TFile _file_)
            : base(_file_)
        {
        }
        
        public override void ReplaceChild(Node oldChild, Node newChild)
        {
            if (File == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("File in AInclude cannot be null.", "newChild");
                if (!(newChild is TFile) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                File = newChild as TFile;
            }
            else throw new ArgumentException("Node to be replaced is not a child in this production.");
        }
        protected override IEnumerable<Node> GetChildren()
        {
            yield return File;
        }
        
        public override PInclude Clone()
        {
            return new AInclude(File.Clone());
        }
        
        public override string ToString()
        {
            return string.Format("{0}", File);
        }
    }
    public abstract partial class PStatement : Production<PStatement>
    {
        public PStatement()
        {
        }
        
    }
    public partial class ADeclarationStatement : PStatement
    {
        private PType _type_;
        private TIdentifier _identifier_;
        private PExpression _expression_;
        
        public ADeclarationStatement(PType _type_, TIdentifier _identifier_, PExpression _expression_)
            : base()
        {
            this.Type = _type_;
            this.Identifier = _identifier_;
            this.Expression = _expression_;
        }
        
        public PType Type
        {
            get { return _type_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Type in ADeclarationStatement cannot be null.", "value");
                
                if (_type_ != null)
                    SetParent(_type_, null);
                SetParent(value, this);
                
                _type_ = value;
            }
        }
        public TIdentifier Identifier
        {
            get { return _identifier_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Identifier in ADeclarationStatement cannot be null.", "value");
                
                if (_identifier_ != null)
                    SetParent(_identifier_, null);
                SetParent(value, this);
                
                _identifier_ = value;
            }
        }
        public PExpression Expression
        {
            get { return _expression_; }
            set
            {
                if (_expression_ != null)
                    SetParent(_expression_, null);
                if (value != null)
                    SetParent(value, this);
                
                _expression_ = value;
            }
        }
        public bool HasExpression
        {
            get { return _expression_ != null; }
        }
        
        public override void ReplaceChild(Node oldChild, Node newChild)
        {
            if (Type == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("Type in ADeclarationStatement cannot be null.", "newChild");
                if (!(newChild is PType) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Type = newChild as PType;
            }
            else if (Identifier == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("Identifier in ADeclarationStatement cannot be null.", "newChild");
                if (!(newChild is TIdentifier) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Identifier = newChild as TIdentifier;
            }
            else if (Expression == oldChild)
            {
                if (!(newChild is PExpression) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Expression = newChild as PExpression;
            }
            else throw new ArgumentException("Node to be replaced is not a child in this production.");
        }
        protected override IEnumerable<Node> GetChildren()
        {
            yield return Type;
            yield return Identifier;
            if (HasExpression)
                yield return Expression;
        }
        
        public override PStatement Clone()
        {
            return new ADeclarationStatement(Type.Clone(), Identifier.Clone(), Expression.Clone());
        }
        
        public override string ToString()
        {
            return string.Format("{0} {1} {2}", Type, Identifier, Expression);
        }
    }
    public partial class AAssignmentStatement : PStatement
    {
        private TIdentifier _identifier_;
        private PExpression _expression_;
        
        public AAssignmentStatement(TIdentifier _identifier_, PExpression _expression_)
            : base()
        {
            this.Identifier = _identifier_;
            this.Expression = _expression_;
        }
        
        public TIdentifier Identifier
        {
            get { return _identifier_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Identifier in AAssignmentStatement cannot be null.", "value");
                
                if (_identifier_ != null)
                    SetParent(_identifier_, null);
                SetParent(value, this);
                
                _identifier_ = value;
            }
        }
        public PExpression Expression
        {
            get { return _expression_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Expression in AAssignmentStatement cannot be null.", "value");
                
                if (_expression_ != null)
                    SetParent(_expression_, null);
                SetParent(value, this);
                
                _expression_ = value;
            }
        }
        
        public override void ReplaceChild(Node oldChild, Node newChild)
        {
            if (Identifier == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("Identifier in AAssignmentStatement cannot be null.", "newChild");
                if (!(newChild is TIdentifier) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Identifier = newChild as TIdentifier;
            }
            else if (Expression == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("Expression in AAssignmentStatement cannot be null.", "newChild");
                if (!(newChild is PExpression) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Expression = newChild as PExpression;
            }
            else throw new ArgumentException("Node to be replaced is not a child in this production.");
        }
        protected override IEnumerable<Node> GetChildren()
        {
            yield return Identifier;
            yield return Expression;
        }
        
        public override PStatement Clone()
        {
            return new AAssignmentStatement(Identifier.Clone(), Expression.Clone());
        }
        
        public override string ToString()
        {
            return string.Format("{0} {1}", Identifier, Expression);
        }
    }
    public partial class AIfStatement : PStatement
    {
        private PExpression _expression_;
        private NodeList<PStatement> _statements_;
        
        public AIfStatement(PExpression _expression_, IEnumerable<PStatement> _statements_)
            : base()
        {
            this.Expression = _expression_;
            this._statements_ = new NodeList<PStatement>(this, _statements_, true);
        }
        
        public PExpression Expression
        {
            get { return _expression_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Expression in AIfStatement cannot be null.", "value");
                
                if (_expression_ != null)
                    SetParent(_expression_, null);
                SetParent(value, this);
                
                _expression_ = value;
            }
        }
        public NodeList<PStatement> Statements
        {
            get { return _statements_; }
        }
        
        public override void ReplaceChild(Node oldChild, Node newChild)
        {
            if (Expression == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("Expression in AIfStatement cannot be null.", "newChild");
                if (!(newChild is PExpression) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Expression = newChild as PExpression;
            }
            else if (oldChild is PStatement && Statements.Contains(oldChild as PStatement))
            {
                if (!(newChild is PStatement) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                
                int index = Statements.IndexOf(oldChild as PStatement);
                if (newChild == null)
                    Statements.RemoveAt(index);
                else
                    Statements[index] = newChild as PStatement;
            }
            else throw new ArgumentException("Node to be replaced is not a child in this production.");
        }
        protected override IEnumerable<Node> GetChildren()
        {
            yield return Expression;
            {
                PStatement[] temp = new PStatement[Statements.Count];
                Statements.CopyTo(temp, 0);
                for (int i = 0; i < temp.Length; i++)
                    yield return temp[i];
            }
        }
        
        public override PStatement Clone()
        {
            return new AIfStatement(Expression.Clone(), Statements);
        }
        
        public override string ToString()
        {
            return string.Format("{0} {1}", Expression, Statements);
        }
    }
    public partial class AIfElseStatement : PStatement
    {
        private PExpression _expression_;
        private NodeList<PStatement> _ifstatements_;
        private NodeList<PStatement> _elsestatements_;
        
        public AIfElseStatement(PExpression _expression_, IEnumerable<PStatement> _ifstatements_, IEnumerable<PStatement> _elsestatements_)
            : base()
        {
            this.Expression = _expression_;
            this._ifstatements_ = new NodeList<PStatement>(this, _ifstatements_, true);
            this._elsestatements_ = new NodeList<PStatement>(this, _elsestatements_, true);
        }
        
        public PExpression Expression
        {
            get { return _expression_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Expression in AIfElseStatement cannot be null.", "value");
                
                if (_expression_ != null)
                    SetParent(_expression_, null);
                SetParent(value, this);
                
                _expression_ = value;
            }
        }
        public NodeList<PStatement> IfStatements
        {
            get { return _ifstatements_; }
        }
        public NodeList<PStatement> ElseStatements
        {
            get { return _elsestatements_; }
        }
        
        public override void ReplaceChild(Node oldChild, Node newChild)
        {
            if (Expression == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("Expression in AIfElseStatement cannot be null.", "newChild");
                if (!(newChild is PExpression) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Expression = newChild as PExpression;
            }
            else if (oldChild is PStatement && IfStatements.Contains(oldChild as PStatement))
            {
                if (!(newChild is PStatement) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                
                int index = IfStatements.IndexOf(oldChild as PStatement);
                if (newChild == null)
                    IfStatements.RemoveAt(index);
                else
                    IfStatements[index] = newChild as PStatement;
            }
            else if (oldChild is PStatement && ElseStatements.Contains(oldChild as PStatement))
            {
                if (!(newChild is PStatement) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                
                int index = ElseStatements.IndexOf(oldChild as PStatement);
                if (newChild == null)
                    ElseStatements.RemoveAt(index);
                else
                    ElseStatements[index] = newChild as PStatement;
            }
            else throw new ArgumentException("Node to be replaced is not a child in this production.");
        }
        protected override IEnumerable<Node> GetChildren()
        {
            yield return Expression;
            {
                PStatement[] temp = new PStatement[IfStatements.Count];
                IfStatements.CopyTo(temp, 0);
                for (int i = 0; i < temp.Length; i++)
                    yield return temp[i];
            }
            {
                PStatement[] temp = new PStatement[ElseStatements.Count];
                ElseStatements.CopyTo(temp, 0);
                for (int i = 0; i < temp.Length; i++)
                    yield return temp[i];
            }
        }
        
        public override PStatement Clone()
        {
            return new AIfElseStatement(Expression.Clone(), IfStatements, ElseStatements);
        }
        
        public override string ToString()
        {
            return string.Format("{0} {1} {2}", Expression, IfStatements, ElseStatements);
        }
    }
    public partial class AWhileStatement : PStatement
    {
        private PExpression _expression_;
        private NodeList<PStatement> _statements_;
        
        public AWhileStatement(PExpression _expression_, IEnumerable<PStatement> _statements_)
            : base()
        {
            this.Expression = _expression_;
            this._statements_ = new NodeList<PStatement>(this, _statements_, true);
        }
        
        public PExpression Expression
        {
            get { return _expression_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Expression in AWhileStatement cannot be null.", "value");
                
                if (_expression_ != null)
                    SetParent(_expression_, null);
                SetParent(value, this);
                
                _expression_ = value;
            }
        }
        public NodeList<PStatement> Statements
        {
            get { return _statements_; }
        }
        
        public override void ReplaceChild(Node oldChild, Node newChild)
        {
            if (Expression == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("Expression in AWhileStatement cannot be null.", "newChild");
                if (!(newChild is PExpression) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Expression = newChild as PExpression;
            }
            else if (oldChild is PStatement && Statements.Contains(oldChild as PStatement))
            {
                if (!(newChild is PStatement) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                
                int index = Statements.IndexOf(oldChild as PStatement);
                if (newChild == null)
                    Statements.RemoveAt(index);
                else
                    Statements[index] = newChild as PStatement;
            }
            else throw new ArgumentException("Node to be replaced is not a child in this production.");
        }
        protected override IEnumerable<Node> GetChildren()
        {
            yield return Expression;
            {
                PStatement[] temp = new PStatement[Statements.Count];
                Statements.CopyTo(temp, 0);
                for (int i = 0; i < temp.Length; i++)
                    yield return temp[i];
            }
        }
        
        public override PStatement Clone()
        {
            return new AWhileStatement(Expression.Clone(), Statements);
        }
        
        public override string ToString()
        {
            return string.Format("{0} {1}", Expression, Statements);
        }
    }
    public partial class AFunctionDeclarationStatement : PStatement
    {
        private PType _type_;
        private TIdentifier _identifier_;
        private NodeList<PFunctionParameter> _parameters_;
        private NodeList<PStatement> _statements_;
        
        public AFunctionDeclarationStatement(PType _type_, TIdentifier _identifier_, IEnumerable<PFunctionParameter> _parameters_, IEnumerable<PStatement> _statements_)
            : base()
        {
            this.Type = _type_;
            this.Identifier = _identifier_;
            this._parameters_ = new NodeList<PFunctionParameter>(this, _parameters_, true);
            this._statements_ = new NodeList<PStatement>(this, _statements_, true);
        }
        
        public PType Type
        {
            get { return _type_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Type in AFunctionDeclarationStatement cannot be null.", "value");
                
                if (_type_ != null)
                    SetParent(_type_, null);
                SetParent(value, this);
                
                _type_ = value;
            }
        }
        public TIdentifier Identifier
        {
            get { return _identifier_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Identifier in AFunctionDeclarationStatement cannot be null.", "value");
                
                if (_identifier_ != null)
                    SetParent(_identifier_, null);
                SetParent(value, this);
                
                _identifier_ = value;
            }
        }
        public NodeList<PFunctionParameter> Parameters
        {
            get { return _parameters_; }
        }
        public NodeList<PStatement> Statements
        {
            get { return _statements_; }
        }
        
        public override void ReplaceChild(Node oldChild, Node newChild)
        {
            if (Type == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("Type in AFunctionDeclarationStatement cannot be null.", "newChild");
                if (!(newChild is PType) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Type = newChild as PType;
            }
            else if (Identifier == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("Identifier in AFunctionDeclarationStatement cannot be null.", "newChild");
                if (!(newChild is TIdentifier) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Identifier = newChild as TIdentifier;
            }
            else if (oldChild is PFunctionParameter && Parameters.Contains(oldChild as PFunctionParameter))
            {
                if (!(newChild is PFunctionParameter) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                
                int index = Parameters.IndexOf(oldChild as PFunctionParameter);
                if (newChild == null)
                    Parameters.RemoveAt(index);
                else
                    Parameters[index] = newChild as PFunctionParameter;
            }
            else if (oldChild is PStatement && Statements.Contains(oldChild as PStatement))
            {
                if (!(newChild is PStatement) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                
                int index = Statements.IndexOf(oldChild as PStatement);
                if (newChild == null)
                    Statements.RemoveAt(index);
                else
                    Statements[index] = newChild as PStatement;
            }
            else throw new ArgumentException("Node to be replaced is not a child in this production.");
        }
        protected override IEnumerable<Node> GetChildren()
        {
            yield return Type;
            yield return Identifier;
            {
                PFunctionParameter[] temp = new PFunctionParameter[Parameters.Count];
                Parameters.CopyTo(temp, 0);
                for (int i = 0; i < temp.Length; i++)
                    yield return temp[i];
            }
            {
                PStatement[] temp = new PStatement[Statements.Count];
                Statements.CopyTo(temp, 0);
                for (int i = 0; i < temp.Length; i++)
                    yield return temp[i];
            }
        }
        
        public override PStatement Clone()
        {
            return new AFunctionDeclarationStatement(Type.Clone(), Identifier.Clone(), Parameters, Statements);
        }
        
        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3}", Type, Identifier, Parameters, Statements);
        }
    }
    public partial class AReturnStatement : PStatement
    {
        private PExpression _expression_;
        
        public AReturnStatement(PExpression _expression_)
            : base()
        {
            this.Expression = _expression_;
        }
        
        public PExpression Expression
        {
            get { return _expression_; }
            set
            {
                if (_expression_ != null)
                    SetParent(_expression_, null);
                if (value != null)
                    SetParent(value, this);
                
                _expression_ = value;
            }
        }
        public bool HasExpression
        {
            get { return _expression_ != null; }
        }
        
        public override void ReplaceChild(Node oldChild, Node newChild)
        {
            if (Expression == oldChild)
            {
                if (!(newChild is PExpression) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Expression = newChild as PExpression;
            }
            else throw new ArgumentException("Node to be replaced is not a child in this production.");
        }
        protected override IEnumerable<Node> GetChildren()
        {
            if (HasExpression)
                yield return Expression;
        }
        
        public override PStatement Clone()
        {
            return new AReturnStatement(Expression.Clone());
        }
        
        public override string ToString()
        {
            return string.Format("{0}", Expression);
        }
    }
    public abstract partial class PFunctionParameter : Production<PFunctionParameter>
    {
        private PType _type_;
        private TIdentifier _identifier_;
        
        public PFunctionParameter(PType _type_, TIdentifier _identifier_)
        {
            this.Type = _type_;
            this.Identifier = _identifier_;
        }
        
        public PType Type
        {
            get { return _type_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Type in PFunctionParameter cannot be null.", "value");
                
                if (_type_ != null)
                    SetParent(_type_, null);
                SetParent(value, this);
                
                _type_ = value;
            }
        }
        public TIdentifier Identifier
        {
            get { return _identifier_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Identifier in PFunctionParameter cannot be null.", "value");
                
                if (_identifier_ != null)
                    SetParent(_identifier_, null);
                SetParent(value, this);
                
                _identifier_ = value;
            }
        }
        
    }
    public partial class AFunctionParameter : PFunctionParameter
    {
        public AFunctionParameter(PType _type_, TIdentifier _identifier_)
            : base(_type_, _identifier_)
        {
        }
        
        public override void ReplaceChild(Node oldChild, Node newChild)
        {
            if (Type == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("Type in AFunctionParameter cannot be null.", "newChild");
                if (!(newChild is PType) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Type = newChild as PType;
            }
            else if (Identifier == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("Identifier in AFunctionParameter cannot be null.", "newChild");
                if (!(newChild is TIdentifier) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Identifier = newChild as TIdentifier;
            }
            else throw new ArgumentException("Node to be replaced is not a child in this production.");
        }
        protected override IEnumerable<Node> GetChildren()
        {
            yield return Type;
            yield return Identifier;
        }
        
        public override PFunctionParameter Clone()
        {
            return new AFunctionParameter(Type.Clone(), Identifier.Clone());
        }
        
        public override string ToString()
        {
            return string.Format("{0} {1}", Type, Identifier);
        }
    }
    public abstract partial class PType : Production<PType>
    {
        public PType()
        {
        }
        
    }
    public partial class AType : PType
    {
        private TIdentifier _name_;
        
        public AType(TIdentifier _name_)
            : base()
        {
            this.Name = _name_;
        }
        
        public TIdentifier Name
        {
            get { return _name_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Name in AType cannot be null.", "value");
                
                if (_name_ != null)
                    SetParent(_name_, null);
                SetParent(value, this);
                
                _name_ = value;
            }
        }
        
        public override void ReplaceChild(Node oldChild, Node newChild)
        {
            if (Name == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("Name in AType cannot be null.", "newChild");
                if (!(newChild is TIdentifier) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Name = newChild as TIdentifier;
            }
            else throw new ArgumentException("Node to be replaced is not a child in this production.");
        }
        protected override IEnumerable<Node> GetChildren()
        {
            yield return Name;
        }
        
        public override PType Clone()
        {
            return new AType(Name.Clone());
        }
        
        public override string ToString()
        {
            return string.Format("{0}", Name);
        }
    }
    public partial class APointerType : PType
    {
        private PType _type_;
        private TAsterisk _asterisk_;
        
        public APointerType(PType _type_, TAsterisk _asterisk_)
            : base()
        {
            this.Type = _type_;
            this.Asterisk = _asterisk_;
        }
        
        public PType Type
        {
            get { return _type_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Type in APointerType cannot be null.", "value");
                
                if (_type_ != null)
                    SetParent(_type_, null);
                SetParent(value, this);
                
                _type_ = value;
            }
        }
        public TAsterisk Asterisk
        {
            get { return _asterisk_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Asterisk in APointerType cannot be null.", "value");
                
                if (_asterisk_ != null)
                    SetParent(_asterisk_, null);
                SetParent(value, this);
                
                _asterisk_ = value;
            }
        }
        
        public override void ReplaceChild(Node oldChild, Node newChild)
        {
            if (Type == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("Type in APointerType cannot be null.", "newChild");
                if (!(newChild is PType) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Type = newChild as PType;
            }
            else if (Asterisk == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("Asterisk in APointerType cannot be null.", "newChild");
                if (!(newChild is TAsterisk) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Asterisk = newChild as TAsterisk;
            }
            else throw new ArgumentException("Node to be replaced is not a child in this production.");
        }
        protected override IEnumerable<Node> GetChildren()
        {
            yield return Type;
            yield return Asterisk;
        }
        
        public override PType Clone()
        {
            return new APointerType(Type.Clone(), Asterisk.Clone());
        }
        
        public override string ToString()
        {
            return string.Format("{0} {1}", Type, Asterisk);
        }
    }
    public abstract partial class PExpression : Production<PExpression>
    {
        public PExpression()
        {
        }
        
    }
    public partial class AAndExpression : PExpression
    {
        private PExpression _left_;
        private PExpression _right_;
        
        public AAndExpression(PExpression _left_, PExpression _right_)
            : base()
        {
            this.Left = _left_;
            this.Right = _right_;
        }
        
        public PExpression Left
        {
            get { return _left_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Left in AAndExpression cannot be null.", "value");
                
                if (_left_ != null)
                    SetParent(_left_, null);
                SetParent(value, this);
                
                _left_ = value;
            }
        }
        public PExpression Right
        {
            get { return _right_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Right in AAndExpression cannot be null.", "value");
                
                if (_right_ != null)
                    SetParent(_right_, null);
                SetParent(value, this);
                
                _right_ = value;
            }
        }
        
        public override void ReplaceChild(Node oldChild, Node newChild)
        {
            if (Left == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("Left in AAndExpression cannot be null.", "newChild");
                if (!(newChild is PExpression) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Left = newChild as PExpression;
            }
            else if (Right == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("Right in AAndExpression cannot be null.", "newChild");
                if (!(newChild is PExpression) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Right = newChild as PExpression;
            }
            else throw new ArgumentException("Node to be replaced is not a child in this production.");
        }
        protected override IEnumerable<Node> GetChildren()
        {
            yield return Left;
            yield return Right;
        }
        
        public override PExpression Clone()
        {
            return new AAndExpression(Left.Clone(), Right.Clone());
        }
        
        public override string ToString()
        {
            return string.Format("{0} {1}", Left, Right);
        }
    }
    public partial class AOrExpression : PExpression
    {
        private PExpression _left_;
        private PExpression _right_;
        
        public AOrExpression(PExpression _left_, PExpression _right_)
            : base()
        {
            this.Left = _left_;
            this.Right = _right_;
        }
        
        public PExpression Left
        {
            get { return _left_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Left in AOrExpression cannot be null.", "value");
                
                if (_left_ != null)
                    SetParent(_left_, null);
                SetParent(value, this);
                
                _left_ = value;
            }
        }
        public PExpression Right
        {
            get { return _right_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Right in AOrExpression cannot be null.", "value");
                
                if (_right_ != null)
                    SetParent(_right_, null);
                SetParent(value, this);
                
                _right_ = value;
            }
        }
        
        public override void ReplaceChild(Node oldChild, Node newChild)
        {
            if (Left == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("Left in AOrExpression cannot be null.", "newChild");
                if (!(newChild is PExpression) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Left = newChild as PExpression;
            }
            else if (Right == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("Right in AOrExpression cannot be null.", "newChild");
                if (!(newChild is PExpression) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Right = newChild as PExpression;
            }
            else throw new ArgumentException("Node to be replaced is not a child in this production.");
        }
        protected override IEnumerable<Node> GetChildren()
        {
            yield return Left;
            yield return Right;
        }
        
        public override PExpression Clone()
        {
            return new AOrExpression(Left.Clone(), Right.Clone());
        }
        
        public override string ToString()
        {
            return string.Format("{0} {1}", Left, Right);
        }
    }
    public partial class ANotExpression : PExpression
    {
        private PExpression _expression_;
        
        public ANotExpression(PExpression _expression_)
            : base()
        {
            this.Expression = _expression_;
        }
        
        public PExpression Expression
        {
            get { return _expression_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Expression in ANotExpression cannot be null.", "value");
                
                if (_expression_ != null)
                    SetParent(_expression_, null);
                SetParent(value, this);
                
                _expression_ = value;
            }
        }
        
        public override void ReplaceChild(Node oldChild, Node newChild)
        {
            if (Expression == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("Expression in ANotExpression cannot be null.", "newChild");
                if (!(newChild is PExpression) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Expression = newChild as PExpression;
            }
            else throw new ArgumentException("Node to be replaced is not a child in this production.");
        }
        protected override IEnumerable<Node> GetChildren()
        {
            yield return Expression;
        }
        
        public override PExpression Clone()
        {
            return new ANotExpression(Expression.Clone());
        }
        
        public override string ToString()
        {
            return string.Format("{0}", Expression);
        }
    }
    public partial class AComparisonExpression : PExpression
    {
        private PExpression _left_;
        private TCompare _compare_;
        private PExpression _right_;
        
        public AComparisonExpression(PExpression _left_, TCompare _compare_, PExpression _right_)
            : base()
        {
            this.Left = _left_;
            this.Compare = _compare_;
            this.Right = _right_;
        }
        
        public PExpression Left
        {
            get { return _left_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Left in AComparisonExpression cannot be null.", "value");
                
                if (_left_ != null)
                    SetParent(_left_, null);
                SetParent(value, this);
                
                _left_ = value;
            }
        }
        public TCompare Compare
        {
            get { return _compare_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Compare in AComparisonExpression cannot be null.", "value");
                
                if (_compare_ != null)
                    SetParent(_compare_, null);
                SetParent(value, this);
                
                _compare_ = value;
            }
        }
        public PExpression Right
        {
            get { return _right_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Right in AComparisonExpression cannot be null.", "value");
                
                if (_right_ != null)
                    SetParent(_right_, null);
                SetParent(value, this);
                
                _right_ = value;
            }
        }
        
        public override void ReplaceChild(Node oldChild, Node newChild)
        {
            if (Left == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("Left in AComparisonExpression cannot be null.", "newChild");
                if (!(newChild is PExpression) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Left = newChild as PExpression;
            }
            else if (Compare == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("Compare in AComparisonExpression cannot be null.", "newChild");
                if (!(newChild is TCompare) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Compare = newChild as TCompare;
            }
            else if (Right == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("Right in AComparisonExpression cannot be null.", "newChild");
                if (!(newChild is PExpression) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Right = newChild as PExpression;
            }
            else throw new ArgumentException("Node to be replaced is not a child in this production.");
        }
        protected override IEnumerable<Node> GetChildren()
        {
            yield return Left;
            yield return Compare;
            yield return Right;
        }
        
        public override PExpression Clone()
        {
            return new AComparisonExpression(Left.Clone(), Compare.Clone(), Right.Clone());
        }
        
        public override string ToString()
        {
            return string.Format("{0} {1} {2}", Left, Compare, Right);
        }
    }
    public partial class AElementExpression : PExpression
    {
        private PExpression _expression_;
        private PElement _element_;
        
        public AElementExpression(PExpression _expression_, PElement _element_)
            : base()
        {
            this.Expression = _expression_;
            this.Element = _element_;
        }
        
        public PExpression Expression
        {
            get { return _expression_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Expression in AElementExpression cannot be null.", "value");
                
                if (_expression_ != null)
                    SetParent(_expression_, null);
                SetParent(value, this);
                
                _expression_ = value;
            }
        }
        public PElement Element
        {
            get { return _element_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Element in AElementExpression cannot be null.", "value");
                
                if (_element_ != null)
                    SetParent(_element_, null);
                SetParent(value, this);
                
                _element_ = value;
            }
        }
        
        public override void ReplaceChild(Node oldChild, Node newChild)
        {
            if (Expression == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("Expression in AElementExpression cannot be null.", "newChild");
                if (!(newChild is PExpression) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Expression = newChild as PExpression;
            }
            else if (Element == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("Element in AElementExpression cannot be null.", "newChild");
                if (!(newChild is PElement) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Element = newChild as PElement;
            }
            else throw new ArgumentException("Node to be replaced is not a child in this production.");
        }
        protected override IEnumerable<Node> GetChildren()
        {
            yield return Expression;
            yield return Element;
        }
        
        public override PExpression Clone()
        {
            return new AElementExpression(Expression.Clone(), Element.Clone());
        }
        
        public override string ToString()
        {
            return string.Format("{0} {1}", Expression, Element);
        }
    }
    public partial class AIndexExpression : PExpression
    {
        private PExpression _expression_;
        private PExpression _index_;
        
        public AIndexExpression(PExpression _expression_, PExpression _index_)
            : base()
        {
            this.Expression = _expression_;
            this.Index = _index_;
        }
        
        public PExpression Expression
        {
            get { return _expression_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Expression in AIndexExpression cannot be null.", "value");
                
                if (_expression_ != null)
                    SetParent(_expression_, null);
                SetParent(value, this);
                
                _expression_ = value;
            }
        }
        public PExpression Index
        {
            get { return _index_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Index in AIndexExpression cannot be null.", "value");
                
                if (_index_ != null)
                    SetParent(_index_, null);
                SetParent(value, this);
                
                _index_ = value;
            }
        }
        
        public override void ReplaceChild(Node oldChild, Node newChild)
        {
            if (Expression == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("Expression in AIndexExpression cannot be null.", "newChild");
                if (!(newChild is PExpression) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Expression = newChild as PExpression;
            }
            else if (Index == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("Index in AIndexExpression cannot be null.", "newChild");
                if (!(newChild is PExpression) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Index = newChild as PExpression;
            }
            else throw new ArgumentException("Node to be replaced is not a child in this production.");
        }
        protected override IEnumerable<Node> GetChildren()
        {
            yield return Expression;
            yield return Index;
        }
        
        public override PExpression Clone()
        {
            return new AIndexExpression(Expression.Clone(), Index.Clone());
        }
        
        public override string ToString()
        {
            return string.Format("{0} {1}", Expression, Index);
        }
    }
    public partial class APlusExpression : PExpression
    {
        private PExpression _left_;
        private PExpression _right_;
        
        public APlusExpression(PExpression _left_, PExpression _right_)
            : base()
        {
            this.Left = _left_;
            this.Right = _right_;
        }
        
        public PExpression Left
        {
            get { return _left_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Left in APlusExpression cannot be null.", "value");
                
                if (_left_ != null)
                    SetParent(_left_, null);
                SetParent(value, this);
                
                _left_ = value;
            }
        }
        public PExpression Right
        {
            get { return _right_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Right in APlusExpression cannot be null.", "value");
                
                if (_right_ != null)
                    SetParent(_right_, null);
                SetParent(value, this);
                
                _right_ = value;
            }
        }
        
        public override void ReplaceChild(Node oldChild, Node newChild)
        {
            if (Left == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("Left in APlusExpression cannot be null.", "newChild");
                if (!(newChild is PExpression) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Left = newChild as PExpression;
            }
            else if (Right == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("Right in APlusExpression cannot be null.", "newChild");
                if (!(newChild is PExpression) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Right = newChild as PExpression;
            }
            else throw new ArgumentException("Node to be replaced is not a child in this production.");
        }
        protected override IEnumerable<Node> GetChildren()
        {
            yield return Left;
            yield return Right;
        }
        
        public override PExpression Clone()
        {
            return new APlusExpression(Left.Clone(), Right.Clone());
        }
        
        public override string ToString()
        {
            return string.Format("{0} {1}", Left, Right);
        }
    }
    public partial class AMinusExpression : PExpression
    {
        private PExpression _left_;
        private PExpression _right_;
        
        public AMinusExpression(PExpression _left_, PExpression _right_)
            : base()
        {
            this.Left = _left_;
            this.Right = _right_;
        }
        
        public PExpression Left
        {
            get { return _left_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Left in AMinusExpression cannot be null.", "value");
                
                if (_left_ != null)
                    SetParent(_left_, null);
                SetParent(value, this);
                
                _left_ = value;
            }
        }
        public PExpression Right
        {
            get { return _right_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Right in AMinusExpression cannot be null.", "value");
                
                if (_right_ != null)
                    SetParent(_right_, null);
                SetParent(value, this);
                
                _right_ = value;
            }
        }
        
        public override void ReplaceChild(Node oldChild, Node newChild)
        {
            if (Left == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("Left in AMinusExpression cannot be null.", "newChild");
                if (!(newChild is PExpression) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Left = newChild as PExpression;
            }
            else if (Right == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("Right in AMinusExpression cannot be null.", "newChild");
                if (!(newChild is PExpression) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Right = newChild as PExpression;
            }
            else throw new ArgumentException("Node to be replaced is not a child in this production.");
        }
        protected override IEnumerable<Node> GetChildren()
        {
            yield return Left;
            yield return Right;
        }
        
        public override PExpression Clone()
        {
            return new AMinusExpression(Left.Clone(), Right.Clone());
        }
        
        public override string ToString()
        {
            return string.Format("{0} {1}", Left, Right);
        }
    }
    public partial class AMultiplyExpression : PExpression
    {
        private PExpression _left_;
        private PExpression _right_;
        
        public AMultiplyExpression(PExpression _left_, PExpression _right_)
            : base()
        {
            this.Left = _left_;
            this.Right = _right_;
        }
        
        public PExpression Left
        {
            get { return _left_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Left in AMultiplyExpression cannot be null.", "value");
                
                if (_left_ != null)
                    SetParent(_left_, null);
                SetParent(value, this);
                
                _left_ = value;
            }
        }
        public PExpression Right
        {
            get { return _right_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Right in AMultiplyExpression cannot be null.", "value");
                
                if (_right_ != null)
                    SetParent(_right_, null);
                SetParent(value, this);
                
                _right_ = value;
            }
        }
        
        public override void ReplaceChild(Node oldChild, Node newChild)
        {
            if (Left == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("Left in AMultiplyExpression cannot be null.", "newChild");
                if (!(newChild is PExpression) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Left = newChild as PExpression;
            }
            else if (Right == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("Right in AMultiplyExpression cannot be null.", "newChild");
                if (!(newChild is PExpression) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Right = newChild as PExpression;
            }
            else throw new ArgumentException("Node to be replaced is not a child in this production.");
        }
        protected override IEnumerable<Node> GetChildren()
        {
            yield return Left;
            yield return Right;
        }
        
        public override PExpression Clone()
        {
            return new AMultiplyExpression(Left.Clone(), Right.Clone());
        }
        
        public override string ToString()
        {
            return string.Format("{0} {1}", Left, Right);
        }
    }
    public partial class ADivideExpression : PExpression
    {
        private PExpression _left_;
        private PExpression _right_;
        
        public ADivideExpression(PExpression _left_, PExpression _right_)
            : base()
        {
            this.Left = _left_;
            this.Right = _right_;
        }
        
        public PExpression Left
        {
            get { return _left_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Left in ADivideExpression cannot be null.", "value");
                
                if (_left_ != null)
                    SetParent(_left_, null);
                SetParent(value, this);
                
                _left_ = value;
            }
        }
        public PExpression Right
        {
            get { return _right_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Right in ADivideExpression cannot be null.", "value");
                
                if (_right_ != null)
                    SetParent(_right_, null);
                SetParent(value, this);
                
                _right_ = value;
            }
        }
        
        public override void ReplaceChild(Node oldChild, Node newChild)
        {
            if (Left == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("Left in ADivideExpression cannot be null.", "newChild");
                if (!(newChild is PExpression) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Left = newChild as PExpression;
            }
            else if (Right == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("Right in ADivideExpression cannot be null.", "newChild");
                if (!(newChild is PExpression) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Right = newChild as PExpression;
            }
            else throw new ArgumentException("Node to be replaced is not a child in this production.");
        }
        protected override IEnumerable<Node> GetChildren()
        {
            yield return Left;
            yield return Right;
        }
        
        public override PExpression Clone()
        {
            return new ADivideExpression(Left.Clone(), Right.Clone());
        }
        
        public override string ToString()
        {
            return string.Format("{0} {1}", Left, Right);
        }
    }
    public partial class AModuloExpression : PExpression
    {
        private PExpression _left_;
        private PExpression _right_;
        
        public AModuloExpression(PExpression _left_, PExpression _right_)
            : base()
        {
            this.Left = _left_;
            this.Right = _right_;
        }
        
        public PExpression Left
        {
            get { return _left_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Left in AModuloExpression cannot be null.", "value");
                
                if (_left_ != null)
                    SetParent(_left_, null);
                SetParent(value, this);
                
                _left_ = value;
            }
        }
        public PExpression Right
        {
            get { return _right_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Right in AModuloExpression cannot be null.", "value");
                
                if (_right_ != null)
                    SetParent(_right_, null);
                SetParent(value, this);
                
                _right_ = value;
            }
        }
        
        public override void ReplaceChild(Node oldChild, Node newChild)
        {
            if (Left == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("Left in AModuloExpression cannot be null.", "newChild");
                if (!(newChild is PExpression) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Left = newChild as PExpression;
            }
            else if (Right == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("Right in AModuloExpression cannot be null.", "newChild");
                if (!(newChild is PExpression) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Right = newChild as PExpression;
            }
            else throw new ArgumentException("Node to be replaced is not a child in this production.");
        }
        protected override IEnumerable<Node> GetChildren()
        {
            yield return Left;
            yield return Right;
        }
        
        public override PExpression Clone()
        {
            return new AModuloExpression(Left.Clone(), Right.Clone());
        }
        
        public override string ToString()
        {
            return string.Format("{0} {1}", Left, Right);
        }
    }
    public partial class ANegateExpression : PExpression
    {
        private PExpression _expression_;
        
        public ANegateExpression(PExpression _expression_)
            : base()
        {
            this.Expression = _expression_;
        }
        
        public PExpression Expression
        {
            get { return _expression_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Expression in ANegateExpression cannot be null.", "value");
                
                if (_expression_ != null)
                    SetParent(_expression_, null);
                SetParent(value, this);
                
                _expression_ = value;
            }
        }
        
        public override void ReplaceChild(Node oldChild, Node newChild)
        {
            if (Expression == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("Expression in ANegateExpression cannot be null.", "newChild");
                if (!(newChild is PExpression) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Expression = newChild as PExpression;
            }
            else throw new ArgumentException("Node to be replaced is not a child in this production.");
        }
        protected override IEnumerable<Node> GetChildren()
        {
            yield return Expression;
        }
        
        public override PExpression Clone()
        {
            return new ANegateExpression(Expression.Clone());
        }
        
        public override string ToString()
        {
            return string.Format("{0}", Expression);
        }
    }
    public partial class AFunctionCallExpression : PExpression
    {
        private TIdentifier _function_;
        private NodeList<PExpression> _arguments_;
        
        public AFunctionCallExpression(TIdentifier _function_, IEnumerable<PExpression> _arguments_)
            : base()
        {
            this.Function = _function_;
            this._arguments_ = new NodeList<PExpression>(this, _arguments_, true);
        }
        
        public TIdentifier Function
        {
            get { return _function_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Function in AFunctionCallExpression cannot be null.", "value");
                
                if (_function_ != null)
                    SetParent(_function_, null);
                SetParent(value, this);
                
                _function_ = value;
            }
        }
        public NodeList<PExpression> Arguments
        {
            get { return _arguments_; }
        }
        
        public override void ReplaceChild(Node oldChild, Node newChild)
        {
            if (Function == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("Function in AFunctionCallExpression cannot be null.", "newChild");
                if (!(newChild is TIdentifier) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Function = newChild as TIdentifier;
            }
            else if (oldChild is PExpression && Arguments.Contains(oldChild as PExpression))
            {
                if (!(newChild is PExpression) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                
                int index = Arguments.IndexOf(oldChild as PExpression);
                if (newChild == null)
                    Arguments.RemoveAt(index);
                else
                    Arguments[index] = newChild as PExpression;
            }
            else throw new ArgumentException("Node to be replaced is not a child in this production.");
        }
        protected override IEnumerable<Node> GetChildren()
        {
            yield return Function;
            {
                PExpression[] temp = new PExpression[Arguments.Count];
                Arguments.CopyTo(temp, 0);
                for (int i = 0; i < temp.Length; i++)
                    yield return temp[i];
            }
        }
        
        public override PExpression Clone()
        {
            return new AFunctionCallExpression(Function.Clone(), Arguments);
        }
        
        public override string ToString()
        {
            return string.Format("{0} {1}", Function, Arguments);
        }
    }
    public partial class AParenthesisExpression : PExpression
    {
        private PExpression _expression_;
        
        public AParenthesisExpression(PExpression _expression_)
            : base()
        {
            this.Expression = _expression_;
        }
        
        public PExpression Expression
        {
            get { return _expression_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Expression in AParenthesisExpression cannot be null.", "value");
                
                if (_expression_ != null)
                    SetParent(_expression_, null);
                SetParent(value, this);
                
                _expression_ = value;
            }
        }
        
        public override void ReplaceChild(Node oldChild, Node newChild)
        {
            if (Expression == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("Expression in AParenthesisExpression cannot be null.", "newChild");
                if (!(newChild is PExpression) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Expression = newChild as PExpression;
            }
            else throw new ArgumentException("Node to be replaced is not a child in this production.");
        }
        protected override IEnumerable<Node> GetChildren()
        {
            yield return Expression;
        }
        
        public override PExpression Clone()
        {
            return new AParenthesisExpression(Expression.Clone());
        }
        
        public override string ToString()
        {
            return string.Format("{0}", Expression);
        }
    }
    public partial class AIdentifierExpression : PExpression
    {
        private TIdentifier _identifier_;
        
        public AIdentifierExpression(TIdentifier _identifier_)
            : base()
        {
            this.Identifier = _identifier_;
        }
        
        public TIdentifier Identifier
        {
            get { return _identifier_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Identifier in AIdentifierExpression cannot be null.", "value");
                
                if (_identifier_ != null)
                    SetParent(_identifier_, null);
                SetParent(value, this);
                
                _identifier_ = value;
            }
        }
        
        public override void ReplaceChild(Node oldChild, Node newChild)
        {
            if (Identifier == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("Identifier in AIdentifierExpression cannot be null.", "newChild");
                if (!(newChild is TIdentifier) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Identifier = newChild as TIdentifier;
            }
            else throw new ArgumentException("Node to be replaced is not a child in this production.");
        }
        protected override IEnumerable<Node> GetChildren()
        {
            yield return Identifier;
        }
        
        public override PExpression Clone()
        {
            return new AIdentifierExpression(Identifier.Clone());
        }
        
        public override string ToString()
        {
            return string.Format("{0}", Identifier);
        }
    }
    public partial class ANumberExpression : PExpression
    {
        private TNumber _number_;
        
        public ANumberExpression(TNumber _number_)
            : base()
        {
            this.Number = _number_;
        }
        
        public TNumber Number
        {
            get { return _number_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Number in ANumberExpression cannot be null.", "value");
                
                if (_number_ != null)
                    SetParent(_number_, null);
                SetParent(value, this);
                
                _number_ = value;
            }
        }
        
        public override void ReplaceChild(Node oldChild, Node newChild)
        {
            if (Number == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("Number in ANumberExpression cannot be null.", "newChild");
                if (!(newChild is TNumber) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Number = newChild as TNumber;
            }
            else throw new ArgumentException("Node to be replaced is not a child in this production.");
        }
        protected override IEnumerable<Node> GetChildren()
        {
            yield return Number;
        }
        
        public override PExpression Clone()
        {
            return new ANumberExpression(Number.Clone());
        }
        
        public override string ToString()
        {
            return string.Format("{0}", Number);
        }
    }
    public partial class ABooleanExpression : PExpression
    {
        private TBool _bool_;
        
        public ABooleanExpression(TBool _bool_)
            : base()
        {
            this.Bool = _bool_;
        }
        
        public TBool Bool
        {
            get { return _bool_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Bool in ABooleanExpression cannot be null.", "value");
                
                if (_bool_ != null)
                    SetParent(_bool_, null);
                SetParent(value, this);
                
                _bool_ = value;
            }
        }
        
        public override void ReplaceChild(Node oldChild, Node newChild)
        {
            if (Bool == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("Bool in ABooleanExpression cannot be null.", "newChild");
                if (!(newChild is TBool) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Bool = newChild as TBool;
            }
            else throw new ArgumentException("Node to be replaced is not a child in this production.");
        }
        protected override IEnumerable<Node> GetChildren()
        {
            yield return Bool;
        }
        
        public override PExpression Clone()
        {
            return new ABooleanExpression(Bool.Clone());
        }
        
        public override string ToString()
        {
            return string.Format("{0}", Bool);
        }
    }
    public abstract partial class PElement : Production<PElement>
    {
        private TIdentifier _identifier_;
        
        public PElement(TIdentifier _identifier_)
        {
            this.Identifier = _identifier_;
        }
        
        public TIdentifier Identifier
        {
            get { return _identifier_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Identifier in PElement cannot be null.", "value");
                
                if (_identifier_ != null)
                    SetParent(_identifier_, null);
                SetParent(value, this);
                
                _identifier_ = value;
            }
        }
        
    }
    public partial class AElement : PElement
    {
        public AElement(TIdentifier _identifier_)
            : base(_identifier_)
        {
        }
        
        public override void ReplaceChild(Node oldChild, Node newChild)
        {
            if (Identifier == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("Identifier in AElement cannot be null.", "newChild");
                if (!(newChild is TIdentifier) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Identifier = newChild as TIdentifier;
            }
            else throw new ArgumentException("Node to be replaced is not a child in this production.");
        }
        protected override IEnumerable<Node> GetChildren()
        {
            yield return Identifier;
        }
        
        public override PElement Clone()
        {
            return new AElement(Identifier.Clone());
        }
        
        public override string ToString()
        {
            return string.Format("{0}", Identifier);
        }
    }
    public partial class APointerElement : PElement
    {
        public APointerElement(TIdentifier _identifier_)
            : base(_identifier_)
        {
        }
        
        public override void ReplaceChild(Node oldChild, Node newChild)
        {
            if (Identifier == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("Identifier in APointerElement cannot be null.", "newChild");
                if (!(newChild is TIdentifier) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Identifier = newChild as TIdentifier;
            }
            else throw new ArgumentException("Node to be replaced is not a child in this production.");
        }
        protected override IEnumerable<Node> GetChildren()
        {
            yield return Identifier;
        }
        
        public override PElement Clone()
        {
            return new APointerElement(Identifier.Clone());
        }
        
        public override string ToString()
        {
            return string.Format("{0}", Identifier);
        }
    }
}
