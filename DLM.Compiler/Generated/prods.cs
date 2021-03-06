using System;
using System.Collections.Generic;
using SablePP.Tools.Nodes;
using DLM.Compiler.Analysis;

namespace DLM.Compiler.Nodes
{
    public abstract partial class PRoot : Production<PRoot>
    {
        private NodeList<PPreProcessor> _preprocessors_;
        private NodeList<PPrincipalDeclaration> _principaldeclarations_;
        private NodeList<PPrincipalHierarchyDeclaration> _principalhierarchydeclarations_;
        private NodeList<PStruct> _structs_;
        private NodeList<PStatement> _statements_;
        
        public PRoot(IEnumerable<PPreProcessor> _preprocessors_, IEnumerable<PPrincipalDeclaration> _principaldeclarations_, IEnumerable<PPrincipalHierarchyDeclaration> _principalhierarchydeclarations_, IEnumerable<PStruct> _structs_, IEnumerable<PStatement> _statements_)
        {
            this._preprocessors_ = new NodeList<PPreProcessor>(this, _preprocessors_, true);
            this._principaldeclarations_ = new NodeList<PPrincipalDeclaration>(this, _principaldeclarations_, true);
            this._principalhierarchydeclarations_ = new NodeList<PPrincipalHierarchyDeclaration>(this, _principalhierarchydeclarations_, true);
            this._structs_ = new NodeList<PStruct>(this, _structs_, true);
            this._statements_ = new NodeList<PStatement>(this, _statements_, true);
        }
        
        public NodeList<PPreProcessor> PreProcessors
        {
            get { return _preprocessors_; }
        }
        public NodeList<PPrincipalDeclaration> PrincipalDeclarations
        {
            get { return _principaldeclarations_; }
        }
        public NodeList<PPrincipalHierarchyDeclaration> PrincipalHierarchyDeclarations
        {
            get { return _principalhierarchydeclarations_; }
        }
        public NodeList<PStruct> Structs
        {
            get { return _structs_; }
        }
        public NodeList<PStatement> Statements
        {
            get { return _statements_; }
        }
        
    }
    public partial class ARoot : PRoot
    {
        public ARoot(IEnumerable<PPreProcessor> _preprocessors_, IEnumerable<PPrincipalDeclaration> _principaldeclarations_, IEnumerable<PPrincipalHierarchyDeclaration> _principalhierarchydeclarations_, IEnumerable<PStruct> _structs_, IEnumerable<PStatement> _statements_)
            : base(_preprocessors_, _principaldeclarations_, _principalhierarchydeclarations_, _structs_, _statements_)
        {
        }
        
        public override void ReplaceChild(Node oldChild, Node newChild)
        {
            if (oldChild is PPreProcessor && PreProcessors.Contains(oldChild as PPreProcessor))
            {
                if (!(newChild is PPreProcessor) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                
                int index = PreProcessors.IndexOf(oldChild as PPreProcessor);
                if (newChild == null)
                    PreProcessors.RemoveAt(index);
                else
                    PreProcessors[index] = newChild as PPreProcessor;
            }
            else if (oldChild is PPrincipalDeclaration && PrincipalDeclarations.Contains(oldChild as PPrincipalDeclaration))
            {
                if (!(newChild is PPrincipalDeclaration) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                
                int index = PrincipalDeclarations.IndexOf(oldChild as PPrincipalDeclaration);
                if (newChild == null)
                    PrincipalDeclarations.RemoveAt(index);
                else
                    PrincipalDeclarations[index] = newChild as PPrincipalDeclaration;
            }
            else if (oldChild is PPrincipalHierarchyDeclaration && PrincipalHierarchyDeclarations.Contains(oldChild as PPrincipalHierarchyDeclaration))
            {
                if (!(newChild is PPrincipalHierarchyDeclaration) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                
                int index = PrincipalHierarchyDeclarations.IndexOf(oldChild as PPrincipalHierarchyDeclaration);
                if (newChild == null)
                    PrincipalHierarchyDeclarations.RemoveAt(index);
                else
                    PrincipalHierarchyDeclarations[index] = newChild as PPrincipalHierarchyDeclaration;
            }
            else if (oldChild is PStruct && Structs.Contains(oldChild as PStruct))
            {
                if (!(newChild is PStruct) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                
                int index = Structs.IndexOf(oldChild as PStruct);
                if (newChild == null)
                    Structs.RemoveAt(index);
                else
                    Structs[index] = newChild as PStruct;
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
                PPreProcessor[] temp = new PPreProcessor[PreProcessors.Count];
                PreProcessors.CopyTo(temp, 0);
                for (int i = 0; i < temp.Length; i++)
                    yield return temp[i];
            }
            {
                PPrincipalDeclaration[] temp = new PPrincipalDeclaration[PrincipalDeclarations.Count];
                PrincipalDeclarations.CopyTo(temp, 0);
                for (int i = 0; i < temp.Length; i++)
                    yield return temp[i];
            }
            {
                PPrincipalHierarchyDeclaration[] temp = new PPrincipalHierarchyDeclaration[PrincipalHierarchyDeclarations.Count];
                PrincipalHierarchyDeclarations.CopyTo(temp, 0);
                for (int i = 0; i < temp.Length; i++)
                    yield return temp[i];
            }
            {
                PStruct[] temp = new PStruct[Structs.Count];
                Structs.CopyTo(temp, 0);
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
            return new ARoot(PreProcessors.Clone(), PrincipalDeclarations.Clone(), PrincipalHierarchyDeclarations.Clone(), Structs.Clone(), Statements.Clone());
        }
        
        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4}", PreProcessors, PrincipalDeclarations, PrincipalHierarchyDeclarations, Structs, Statements);
        }
    }
    public abstract partial class PPreProcessor : Production<PPreProcessor>
    {
        private TDirective _directive_;
        
        public PPreProcessor(TDirective _directive_)
        {
            this.Directive = _directive_;
        }
        
        public TDirective Directive
        {
            get { return _directive_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Directive in PPreProcessor cannot be null.", "value");
                
                if (_directive_ != null)
                    SetParent(_directive_, null);
                SetParent(value, this);
                
                _directive_ = value;
            }
        }
        
    }
    public partial class APreProcessor : PPreProcessor
    {
        public APreProcessor(TDirective _directive_)
            : base(_directive_)
        {
        }
        
        public override void ReplaceChild(Node oldChild, Node newChild)
        {
            if (Directive == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("Directive in APreProcessor cannot be null.", "newChild");
                if (!(newChild is TDirective) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Directive = newChild as TDirective;
            }
            else throw new ArgumentException("Node to be replaced is not a child in this production.");
        }
        protected override IEnumerable<Node> GetChildren()
        {
            yield return Directive;
        }
        
        public override PPreProcessor Clone()
        {
            return new APreProcessor(Directive.Clone());
        }
        
        public override string ToString()
        {
            return string.Format("{0}", Directive);
        }
    }
    public abstract partial class PPrincipalDeclaration : Production<PPrincipalDeclaration>
    {
        private NodeList<PPrincipal> _principals_;
        
        public PPrincipalDeclaration(IEnumerable<PPrincipal> _principals_)
        {
            this._principals_ = new NodeList<PPrincipal>(this, _principals_, false);
        }
        
        public NodeList<PPrincipal> Principals
        {
            get { return _principals_; }
        }
        
    }
    public partial class APrincipalDeclaration : PPrincipalDeclaration
    {
        public APrincipalDeclaration(IEnumerable<PPrincipal> _principals_)
            : base(_principals_)
        {
        }
        
        public override void ReplaceChild(Node oldChild, Node newChild)
        {
            if (oldChild is PPrincipal && Principals.Contains(oldChild as PPrincipal))
            {
                if (!(newChild is PPrincipal) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                
                int index = Principals.IndexOf(oldChild as PPrincipal);
                if (newChild == null)
                    Principals.RemoveAt(index);
                else
                    Principals[index] = newChild as PPrincipal;
            }
            else throw new ArgumentException("Node to be replaced is not a child in this production.");
        }
        protected override IEnumerable<Node> GetChildren()
        {
            {
                PPrincipal[] temp = new PPrincipal[Principals.Count];
                Principals.CopyTo(temp, 0);
                for (int i = 0; i < temp.Length; i++)
                    yield return temp[i];
            }
        }
        
        public override PPrincipalDeclaration Clone()
        {
            return new APrincipalDeclaration(Principals.Clone());
        }
        
        public override string ToString()
        {
            return string.Format("{0}", Principals);
        }
    }
    public abstract partial class PPrincipalHierarchyDeclaration : Production<PPrincipalHierarchyDeclaration>
    {
        private PPrincipal _principal_;
        private NodeList<PPrincipal> _subordinates_;
        
        public PPrincipalHierarchyDeclaration(PPrincipal _principal_, IEnumerable<PPrincipal> _subordinates_)
        {
            this.Principal = _principal_;
            this._subordinates_ = new NodeList<PPrincipal>(this, _subordinates_, false);
        }
        
        public PPrincipal Principal
        {
            get { return _principal_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Principal in PPrincipalHierarchyDeclaration cannot be null.", "value");
                
                if (_principal_ != null)
                    SetParent(_principal_, null);
                SetParent(value, this);
                
                _principal_ = value;
            }
        }
        public NodeList<PPrincipal> Subordinates
        {
            get { return _subordinates_; }
        }
        
    }
    public partial class APrincipalHierarchyDeclaration : PPrincipalHierarchyDeclaration
    {
        public APrincipalHierarchyDeclaration(PPrincipal _principal_, IEnumerable<PPrincipal> _subordinates_)
            : base(_principal_, _subordinates_)
        {
        }
        
        public override void ReplaceChild(Node oldChild, Node newChild)
        {
            if (Principal == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("Principal in APrincipalHierarchyDeclaration cannot be null.", "newChild");
                if (!(newChild is PPrincipal) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Principal = newChild as PPrincipal;
            }
            else if (oldChild is PPrincipal && Subordinates.Contains(oldChild as PPrincipal))
            {
                if (!(newChild is PPrincipal) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                
                int index = Subordinates.IndexOf(oldChild as PPrincipal);
                if (newChild == null)
                    Subordinates.RemoveAt(index);
                else
                    Subordinates[index] = newChild as PPrincipal;
            }
            else throw new ArgumentException("Node to be replaced is not a child in this production.");
        }
        protected override IEnumerable<Node> GetChildren()
        {
            yield return Principal;
            {
                PPrincipal[] temp = new PPrincipal[Subordinates.Count];
                Subordinates.CopyTo(temp, 0);
                for (int i = 0; i < temp.Length; i++)
                    yield return temp[i];
            }
        }
        
        public override PPrincipalHierarchyDeclaration Clone()
        {
            return new APrincipalHierarchyDeclaration(Principal.Clone(), Subordinates.Clone());
        }
        
        public override string ToString()
        {
            return string.Format("{0} {1}", Principal, Subordinates);
        }
    }
    public abstract partial class PStruct : Production<PStruct>
    {
        private TIdentifier _identifier_;
        private NodeList<PField> _fields_;
        private TIdentifier _name_;
        
        public PStruct(TIdentifier _identifier_, IEnumerable<PField> _fields_, TIdentifier _name_)
        {
            this.Identifier = _identifier_;
            this._fields_ = new NodeList<PField>(this, _fields_, true);
            this.Name = _name_;
        }
        
        public TIdentifier Identifier
        {
            get { return _identifier_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Identifier in PStruct cannot be null.", "value");
                
                if (_identifier_ != null)
                    SetParent(_identifier_, null);
                SetParent(value, this);
                
                _identifier_ = value;
            }
        }
        public NodeList<PField> Fields
        {
            get { return _fields_; }
        }
        public TIdentifier Name
        {
            get { return _name_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Name in PStruct cannot be null.", "value");
                
                if (_name_ != null)
                    SetParent(_name_, null);
                SetParent(value, this);
                
                _name_ = value;
            }
        }
        
    }
    public partial class AStruct : PStruct
    {
        public AStruct(TIdentifier _identifier_, IEnumerable<PField> _fields_, TIdentifier _name_)
            : base(_identifier_, _fields_, _name_)
        {
        }
        
        public override void ReplaceChild(Node oldChild, Node newChild)
        {
            if (Identifier == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("Identifier in AStruct cannot be null.", "newChild");
                if (!(newChild is TIdentifier) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Identifier = newChild as TIdentifier;
            }
            else if (oldChild is PField && Fields.Contains(oldChild as PField))
            {
                if (!(newChild is PField) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                
                int index = Fields.IndexOf(oldChild as PField);
                if (newChild == null)
                    Fields.RemoveAt(index);
                else
                    Fields[index] = newChild as PField;
            }
            else if (Name == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("Name in AStruct cannot be null.", "newChild");
                if (!(newChild is TIdentifier) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Name = newChild as TIdentifier;
            }
            else throw new ArgumentException("Node to be replaced is not a child in this production.");
        }
        protected override IEnumerable<Node> GetChildren()
        {
            yield return Identifier;
            {
                PField[] temp = new PField[Fields.Count];
                Fields.CopyTo(temp, 0);
                for (int i = 0; i < temp.Length; i++)
                    yield return temp[i];
            }
            yield return Name;
        }
        
        public override PStruct Clone()
        {
            return new AStruct(Identifier.Clone(), Fields.Clone(), Name.Clone());
        }
        
        public override string ToString()
        {
            return string.Format("{0} {1} {2}", Identifier, Fields, Name);
        }
    }
    public abstract partial class PField : Production<PField>
    {
        private PType _type_;
        private TIdentifier _identifier_;
        
        public PField(PType _type_, TIdentifier _identifier_)
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
                    throw new ArgumentException("Type in PField cannot be null.", "value");
                
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
                    throw new ArgumentException("Identifier in PField cannot be null.", "value");
                
                if (_identifier_ != null)
                    SetParent(_identifier_, null);
                SetParent(value, this);
                
                _identifier_ = value;
            }
        }
        
    }
    public partial class AField : PField
    {
        public AField(PType _type_, TIdentifier _identifier_)
            : base(_type_, _identifier_)
        {
        }
        
        public override void ReplaceChild(Node oldChild, Node newChild)
        {
            if (Type == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("Type in AField cannot be null.", "newChild");
                if (!(newChild is PType) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Type = newChild as PType;
            }
            else if (Identifier == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("Identifier in AField cannot be null.", "newChild");
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
        
        public override PField Clone()
        {
            return new AField(Type.Clone(), Identifier.Clone());
        }
        
        public override string ToString()
        {
            return string.Format("{0} {1}", Type, Identifier);
        }
    }
    public partial class AArrayField : PField
    {
        private TNumber _size_;
        
        public AArrayField(PType _type_, TIdentifier _identifier_, TNumber _size_)
            : base(_type_, _identifier_)
        {
            this.Size = _size_;
        }
        
        public TNumber Size
        {
            get { return _size_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Size in AArrayField cannot be null.", "value");
                
                if (_size_ != null)
                    SetParent(_size_, null);
                SetParent(value, this);
                
                _size_ = value;
            }
        }
        
        public override void ReplaceChild(Node oldChild, Node newChild)
        {
            if (Type == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("Type in AArrayField cannot be null.", "newChild");
                if (!(newChild is PType) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Type = newChild as PType;
            }
            else if (Identifier == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("Identifier in AArrayField cannot be null.", "newChild");
                if (!(newChild is TIdentifier) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Identifier = newChild as TIdentifier;
            }
            else if (Size == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("Size in AArrayField cannot be null.", "newChild");
                if (!(newChild is TNumber) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Size = newChild as TNumber;
            }
            else throw new ArgumentException("Node to be replaced is not a child in this production.");
        }
        protected override IEnumerable<Node> GetChildren()
        {
            yield return Type;
            yield return Identifier;
            yield return Size;
        }
        
        public override PField Clone()
        {
            return new AArrayField(Type.Clone(), Identifier.Clone(), Size.Clone());
        }
        
        public override string ToString()
        {
            return string.Format("{0} {1} {2}", Type, Identifier, Size);
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
            return new ADeclarationStatement(Type.Clone(), Identifier.Clone(), Expression?.Clone());
        }
        
        public override string ToString()
        {
            return string.Format("{0} {1} {2}", Type, Identifier, Expression);
        }
    }
    public partial class AArrayDeclarationStatement : PStatement
    {
        private PType _type_;
        private TIdentifier _identifier_;
        private TNumber _size_;
        
        public AArrayDeclarationStatement(PType _type_, TIdentifier _identifier_, TNumber _size_)
            : base()
        {
            this.Type = _type_;
            this.Identifier = _identifier_;
            this.Size = _size_;
        }
        
        public PType Type
        {
            get { return _type_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Type in AArrayDeclarationStatement cannot be null.", "value");
                
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
                    throw new ArgumentException("Identifier in AArrayDeclarationStatement cannot be null.", "value");
                
                if (_identifier_ != null)
                    SetParent(_identifier_, null);
                SetParent(value, this);
                
                _identifier_ = value;
            }
        }
        public TNumber Size
        {
            get { return _size_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Size in AArrayDeclarationStatement cannot be null.", "value");
                
                if (_size_ != null)
                    SetParent(_size_, null);
                SetParent(value, this);
                
                _size_ = value;
            }
        }
        
        public override void ReplaceChild(Node oldChild, Node newChild)
        {
            if (Type == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("Type in AArrayDeclarationStatement cannot be null.", "newChild");
                if (!(newChild is PType) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Type = newChild as PType;
            }
            else if (Identifier == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("Identifier in AArrayDeclarationStatement cannot be null.", "newChild");
                if (!(newChild is TIdentifier) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Identifier = newChild as TIdentifier;
            }
            else if (Size == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("Size in AArrayDeclarationStatement cannot be null.", "newChild");
                if (!(newChild is TNumber) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Size = newChild as TNumber;
            }
            else throw new ArgumentException("Node to be replaced is not a child in this production.");
        }
        protected override IEnumerable<Node> GetChildren()
        {
            yield return Type;
            yield return Identifier;
            yield return Size;
        }
        
        public override PStatement Clone()
        {
            return new AArrayDeclarationStatement(Type.Clone(), Identifier.Clone(), Size.Clone());
        }
        
        public override string ToString()
        {
            return string.Format("{0} {1} {2}", Type, Identifier, Size);
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
    public partial class AIfActsForStatement : PStatement
    {
        private PClaimant _claimant_;
        private NodeList<PPrincipal> _principals_;
        private NodeList<PStatement> _statements_;
        
        public AIfActsForStatement(PClaimant _claimant_, IEnumerable<PPrincipal> _principals_, IEnumerable<PStatement> _statements_)
            : base()
        {
            this.Claimant = _claimant_;
            this._principals_ = new NodeList<PPrincipal>(this, _principals_, false);
            this._statements_ = new NodeList<PStatement>(this, _statements_, true);
        }
        
        public PClaimant Claimant
        {
            get { return _claimant_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Claimant in AIfActsForStatement cannot be null.", "value");
                
                if (_claimant_ != null)
                    SetParent(_claimant_, null);
                SetParent(value, this);
                
                _claimant_ = value;
            }
        }
        public NodeList<PPrincipal> Principals
        {
            get { return _principals_; }
        }
        public NodeList<PStatement> Statements
        {
            get { return _statements_; }
        }
        
        public override void ReplaceChild(Node oldChild, Node newChild)
        {
            if (Claimant == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("Claimant in AIfActsForStatement cannot be null.", "newChild");
                if (!(newChild is PClaimant) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Claimant = newChild as PClaimant;
            }
            else if (oldChild is PPrincipal && Principals.Contains(oldChild as PPrincipal))
            {
                if (!(newChild is PPrincipal) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                
                int index = Principals.IndexOf(oldChild as PPrincipal);
                if (newChild == null)
                    Principals.RemoveAt(index);
                else
                    Principals[index] = newChild as PPrincipal;
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
            yield return Claimant;
            {
                PPrincipal[] temp = new PPrincipal[Principals.Count];
                Principals.CopyTo(temp, 0);
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
            return new AIfActsForStatement(Claimant.Clone(), Principals.Clone(), Statements.Clone());
        }
        
        public override string ToString()
        {
            return string.Format("{0} {1} {2}", Claimant, Principals, Statements);
        }
    }
    public partial class AIfActsForElseStatement : PStatement
    {
        private PClaimant _claimant_;
        private NodeList<PPrincipal> _principals_;
        private NodeList<PStatement> _ifstatements_;
        private NodeList<PStatement> _elsestatements_;
        
        public AIfActsForElseStatement(PClaimant _claimant_, IEnumerable<PPrincipal> _principals_, IEnumerable<PStatement> _ifstatements_, IEnumerable<PStatement> _elsestatements_)
            : base()
        {
            this.Claimant = _claimant_;
            this._principals_ = new NodeList<PPrincipal>(this, _principals_, false);
            this._ifstatements_ = new NodeList<PStatement>(this, _ifstatements_, true);
            this._elsestatements_ = new NodeList<PStatement>(this, _elsestatements_, true);
        }
        
        public PClaimant Claimant
        {
            get { return _claimant_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Claimant in AIfActsForElseStatement cannot be null.", "value");
                
                if (_claimant_ != null)
                    SetParent(_claimant_, null);
                SetParent(value, this);
                
                _claimant_ = value;
            }
        }
        public NodeList<PPrincipal> Principals
        {
            get { return _principals_; }
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
            if (Claimant == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("Claimant in AIfActsForElseStatement cannot be null.", "newChild");
                if (!(newChild is PClaimant) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Claimant = newChild as PClaimant;
            }
            else if (oldChild is PPrincipal && Principals.Contains(oldChild as PPrincipal))
            {
                if (!(newChild is PPrincipal) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                
                int index = Principals.IndexOf(oldChild as PPrincipal);
                if (newChild == null)
                    Principals.RemoveAt(index);
                else
                    Principals[index] = newChild as PPrincipal;
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
            yield return Claimant;
            {
                PPrincipal[] temp = new PPrincipal[Principals.Count];
                Principals.CopyTo(temp, 0);
                for (int i = 0; i < temp.Length; i++)
                    yield return temp[i];
            }
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
            return new AIfActsForElseStatement(Claimant.Clone(), Principals.Clone(), IfStatements.Clone(), ElseStatements.Clone());
        }
        
        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3}", Claimant, Principals, IfStatements, ElseStatements);
        }
    }
    public partial class AIfStatement : PStatement
    {
        private TIf _if_;
        private PExpression _expression_;
        private NodeList<PStatement> _statements_;
        
        public AIfStatement(TIf _if_, PExpression _expression_, IEnumerable<PStatement> _statements_)
            : base()
        {
            this.If = _if_;
            this.Expression = _expression_;
            this._statements_ = new NodeList<PStatement>(this, _statements_, true);
        }
        
        public TIf If
        {
            get { return _if_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("If in AIfStatement cannot be null.", "value");
                
                if (_if_ != null)
                    SetParent(_if_, null);
                SetParent(value, this);
                
                _if_ = value;
            }
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
            if (If == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("If in AIfStatement cannot be null.", "newChild");
                if (!(newChild is TIf) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                If = newChild as TIf;
            }
            else if (Expression == oldChild)
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
            yield return If;
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
            return new AIfStatement(If.Clone(), Expression.Clone(), Statements.Clone());
        }
        
        public override string ToString()
        {
            return string.Format("{0} {1} {2}", If, Expression, Statements);
        }
    }
    public partial class AIfElseStatement : PStatement
    {
        private TIf _if_;
        private PExpression _expression_;
        private NodeList<PStatement> _ifstatements_;
        private NodeList<PStatement> _elsestatements_;
        
        public AIfElseStatement(TIf _if_, PExpression _expression_, IEnumerable<PStatement> _ifstatements_, IEnumerable<PStatement> _elsestatements_)
            : base()
        {
            this.If = _if_;
            this.Expression = _expression_;
            this._ifstatements_ = new NodeList<PStatement>(this, _ifstatements_, true);
            this._elsestatements_ = new NodeList<PStatement>(this, _elsestatements_, true);
        }
        
        public TIf If
        {
            get { return _if_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("If in AIfElseStatement cannot be null.", "value");
                
                if (_if_ != null)
                    SetParent(_if_, null);
                SetParent(value, this);
                
                _if_ = value;
            }
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
            if (If == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("If in AIfElseStatement cannot be null.", "newChild");
                if (!(newChild is TIf) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                If = newChild as TIf;
            }
            else if (Expression == oldChild)
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
            yield return If;
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
            return new AIfElseStatement(If.Clone(), Expression.Clone(), IfStatements.Clone(), ElseStatements.Clone());
        }
        
        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3}", If, Expression, IfStatements, ElseStatements);
        }
    }
    public partial class AWhileStatement : PStatement
    {
        private TWhile _while_;
        private PExpression _expression_;
        private NodeList<PStatement> _statements_;
        
        public AWhileStatement(TWhile _while_, PExpression _expression_, IEnumerable<PStatement> _statements_)
            : base()
        {
            this.While = _while_;
            this.Expression = _expression_;
            this._statements_ = new NodeList<PStatement>(this, _statements_, true);
        }
        
        public TWhile While
        {
            get { return _while_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("While in AWhileStatement cannot be null.", "value");
                
                if (_while_ != null)
                    SetParent(_while_, null);
                SetParent(value, this);
                
                _while_ = value;
            }
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
            if (While == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("While in AWhileStatement cannot be null.", "newChild");
                if (!(newChild is TWhile) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                While = newChild as TWhile;
            }
            else if (Expression == oldChild)
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
            yield return While;
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
            return new AWhileStatement(While.Clone(), Expression.Clone(), Statements.Clone());
        }
        
        public override string ToString()
        {
            return string.Format("{0} {1} {2}", While, Expression, Statements);
        }
    }
    public partial class AFunctionDeclarationStatement : PStatement
    {
        private NodeList<PPrincipal> _readers_;
        private PType _type_;
        private TIdentifier _identifier_;
        private NodeList<PFunctionParameter> _parameters_;
        private NodeList<PStatement> _statements_;
        
        public AFunctionDeclarationStatement(IEnumerable<PPrincipal> _readers_, PType _type_, TIdentifier _identifier_, IEnumerable<PFunctionParameter> _parameters_, IEnumerable<PStatement> _statements_)
            : base()
        {
            this._readers_ = new NodeList<PPrincipal>(this, _readers_, true);
            this.Type = _type_;
            this.Identifier = _identifier_;
            this._parameters_ = new NodeList<PFunctionParameter>(this, _parameters_, true);
            this._statements_ = new NodeList<PStatement>(this, _statements_, true);
        }
        
        public NodeList<PPrincipal> Readers
        {
            get { return _readers_; }
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
            if (oldChild is PPrincipal && Readers.Contains(oldChild as PPrincipal))
            {
                if (!(newChild is PPrincipal) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                
                int index = Readers.IndexOf(oldChild as PPrincipal);
                if (newChild == null)
                    Readers.RemoveAt(index);
                else
                    Readers[index] = newChild as PPrincipal;
            }
            else if (Type == oldChild)
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
            {
                PPrincipal[] temp = new PPrincipal[Readers.Count];
                Readers.CopyTo(temp, 0);
                for (int i = 0; i < temp.Length; i++)
                    yield return temp[i];
            }
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
            return new AFunctionDeclarationStatement(Readers.Clone(), Type.Clone(), Identifier.Clone(), Parameters.Clone(), Statements.Clone());
        }
        
        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4}", Readers, Type, Identifier, Parameters, Statements);
        }
    }
    public partial class AExpressionStatement : PStatement
    {
        private PExpression _expression_;
        
        public AExpressionStatement(PExpression _expression_)
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
                    throw new ArgumentException("Expression in AExpressionStatement cannot be null.", "value");
                
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
                    throw new ArgumentException("Expression in AExpressionStatement cannot be null.", "newChild");
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
        
        public override PStatement Clone()
        {
            return new AExpressionStatement(Expression.Clone());
        }
        
        public override string ToString()
        {
            return string.Format("{0}", Expression);
        }
    }
    public partial class AReturnStatement : PStatement
    {
        private TReturn _return_;
        private PExpression _expression_;
        
        public AReturnStatement(TReturn _return_, PExpression _expression_)
            : base()
        {
            this.Return = _return_;
            this.Expression = _expression_;
        }
        
        public TReturn Return
        {
            get { return _return_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Return in AReturnStatement cannot be null.", "value");
                
                if (_return_ != null)
                    SetParent(_return_, null);
                SetParent(value, this);
                
                _return_ = value;
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
            if (Return == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("Return in AReturnStatement cannot be null.", "newChild");
                if (!(newChild is TReturn) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Return = newChild as TReturn;
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
            yield return Return;
            if (HasExpression)
                yield return Expression;
        }
        
        public override PStatement Clone()
        {
            return new AReturnStatement(Return.Clone(), Expression?.Clone());
        }
        
        public override string ToString()
        {
            return string.Format("{0} {1}", Return, Expression);
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
        private PLabel _label_;
        
        public AType(TIdentifier _name_, PLabel _label_)
            : base()
        {
            this.Name = _name_;
            this.Label = _label_;
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
        public PLabel Label
        {
            get { return _label_; }
            set
            {
                if (_label_ != null)
                    SetParent(_label_, null);
                if (value != null)
                    SetParent(value, this);
                
                _label_ = value;
            }
        }
        public bool HasLabel
        {
            get { return _label_ != null; }
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
            else if (Label == oldChild)
            {
                if (!(newChild is PLabel) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Label = newChild as PLabel;
            }
            else throw new ArgumentException("Node to be replaced is not a child in this production.");
        }
        protected override IEnumerable<Node> GetChildren()
        {
            yield return Name;
            if (HasLabel)
                yield return Label;
        }
        
        public override PType Clone()
        {
            return new AType(Name.Clone(), Label?.Clone());
        }
        
        public override string ToString()
        {
            return string.Format("{0} {1}", Name, Label);
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
    public abstract partial class PClaimant : Production<PClaimant>
    {
        public PClaimant()
        {
        }
        
    }
    public partial class AThisClaimant : PClaimant
    {
        private TThis _this_;
        
        public AThisClaimant(TThis _this_)
            : base()
        {
            this.This = _this_;
        }
        
        public TThis This
        {
            get { return _this_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("This in AThisClaimant cannot be null.", "value");
                
                if (_this_ != null)
                    SetParent(_this_, null);
                SetParent(value, this);
                
                _this_ = value;
            }
        }
        
        public override void ReplaceChild(Node oldChild, Node newChild)
        {
            if (This == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("This in AThisClaimant cannot be null.", "newChild");
                if (!(newChild is TThis) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                This = newChild as TThis;
            }
            else throw new ArgumentException("Node to be replaced is not a child in this production.");
        }
        protected override IEnumerable<Node> GetChildren()
        {
            yield return This;
        }
        
        public override PClaimant Clone()
        {
            return new AThisClaimant(This.Clone());
        }
        
        public override string ToString()
        {
            return string.Format("{0}", This);
        }
    }
    public partial class ACallerClaimant : PClaimant
    {
        private TCaller _caller_;
        
        public ACallerClaimant(TCaller _caller_)
            : base()
        {
            this.Caller = _caller_;
        }
        
        public TCaller Caller
        {
            get { return _caller_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Caller in ACallerClaimant cannot be null.", "value");
                
                if (_caller_ != null)
                    SetParent(_caller_, null);
                SetParent(value, this);
                
                _caller_ = value;
            }
        }
        
        public override void ReplaceChild(Node oldChild, Node newChild)
        {
            if (Caller == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("Caller in ACallerClaimant cannot be null.", "newChild");
                if (!(newChild is TCaller) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Caller = newChild as TCaller;
            }
            else throw new ArgumentException("Node to be replaced is not a child in this production.");
        }
        protected override IEnumerable<Node> GetChildren()
        {
            yield return Caller;
        }
        
        public override PClaimant Clone()
        {
            return new ACallerClaimant(Caller.Clone());
        }
        
        public override string ToString()
        {
            return string.Format("{0}", Caller);
        }
    }
    public abstract partial class PLabel : Production<PLabel>
    {
        private NodeList<PPolicy> _policys_;
        private NodeList<PTimePolicy> _timepolicies_;
        
        public PLabel(IEnumerable<PPolicy> _policys_, IEnumerable<PTimePolicy> _timepolicies_)
        {
            this._policys_ = new NodeList<PPolicy>(this, _policys_, false);
            this._timepolicies_ = new NodeList<PTimePolicy>(this, _timepolicies_, true);
        }
        
        public NodeList<PPolicy> Policys
        {
            get { return _policys_; }
        }
        public NodeList<PTimePolicy> TimePolicies
        {
            get { return _timepolicies_; }
        }
        
    }
    public partial class ALabel : PLabel
    {
        public ALabel(IEnumerable<PPolicy> _policys_, IEnumerable<PTimePolicy> _timepolicies_)
            : base(_policys_, _timepolicies_)
        {
        }
        
        public override void ReplaceChild(Node oldChild, Node newChild)
        {
            if (oldChild is PPolicy && Policys.Contains(oldChild as PPolicy))
            {
                if (!(newChild is PPolicy) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                
                int index = Policys.IndexOf(oldChild as PPolicy);
                if (newChild == null)
                    Policys.RemoveAt(index);
                else
                    Policys[index] = newChild as PPolicy;
            }
            else if (oldChild is PTimePolicy && TimePolicies.Contains(oldChild as PTimePolicy))
            {
                if (!(newChild is PTimePolicy) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                
                int index = TimePolicies.IndexOf(oldChild as PTimePolicy);
                if (newChild == null)
                    TimePolicies.RemoveAt(index);
                else
                    TimePolicies[index] = newChild as PTimePolicy;
            }
            else throw new ArgumentException("Node to be replaced is not a child in this production.");
        }
        protected override IEnumerable<Node> GetChildren()
        {
            {
                PPolicy[] temp = new PPolicy[Policys.Count];
                Policys.CopyTo(temp, 0);
                for (int i = 0; i < temp.Length; i++)
                    yield return temp[i];
            }
            {
                PTimePolicy[] temp = new PTimePolicy[TimePolicies.Count];
                TimePolicies.CopyTo(temp, 0);
                for (int i = 0; i < temp.Length; i++)
                    yield return temp[i];
            }
        }
        
        public override PLabel Clone()
        {
            return new ALabel(Policys.Clone(), TimePolicies.Clone());
        }
        
        public override string ToString()
        {
            return string.Format("{0} {1}", Policys, TimePolicies);
        }
    }
    public abstract partial class PTimePolicy : Production<PTimePolicy>
    {
        private PPrincipal _principal_;
        private PTimingPeriod _period_;
        private NodeList<PTimingInterval> _interval_;
        private TNumber _count_;
        
        public PTimePolicy(PPrincipal _principal_, PTimingPeriod _period_, IEnumerable<PTimingInterval> _interval_, TNumber _count_)
        {
            this.Principal = _principal_;
            this.Period = _period_;
            this._interval_ = new NodeList<PTimingInterval>(this, _interval_, true);
            this.Count = _count_;
        }
        
        public PPrincipal Principal
        {
            get { return _principal_; }
            set
            {
                if (_principal_ != null)
                    SetParent(_principal_, null);
                if (value != null)
                    SetParent(value, this);
                
                _principal_ = value;
            }
        }
        public bool HasPrincipal
        {
            get { return _principal_ != null; }
        }
        public PTimingPeriod Period
        {
            get { return _period_; }
            set
            {
                if (_period_ != null)
                    SetParent(_period_, null);
                if (value != null)
                    SetParent(value, this);
                
                _period_ = value;
            }
        }
        public bool HasPeriod
        {
            get { return _period_ != null; }
        }
        public NodeList<PTimingInterval> Interval
        {
            get { return _interval_; }
        }
        public TNumber Count
        {
            get { return _count_; }
            set
            {
                if (_count_ != null)
                    SetParent(_count_, null);
                if (value != null)
                    SetParent(value, this);
                
                _count_ = value;
            }
        }
        public bool HasCount
        {
            get { return _count_ != null; }
        }
        
    }
    public partial class ATimePolicy : PTimePolicy
    {
        public ATimePolicy(PPrincipal _principal_, PTimingPeriod _period_, IEnumerable<PTimingInterval> _interval_, TNumber _count_)
            : base(_principal_, _period_, _interval_, _count_)
        {
        }
        
        public override void ReplaceChild(Node oldChild, Node newChild)
        {
            if (Principal == oldChild)
            {
                if (!(newChild is PPrincipal) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Principal = newChild as PPrincipal;
            }
            else if (Period == oldChild)
            {
                if (!(newChild is PTimingPeriod) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Period = newChild as PTimingPeriod;
            }
            else if (oldChild is PTimingInterval && Interval.Contains(oldChild as PTimingInterval))
            {
                if (!(newChild is PTimingInterval) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                
                int index = Interval.IndexOf(oldChild as PTimingInterval);
                if (newChild == null)
                    Interval.RemoveAt(index);
                else
                    Interval[index] = newChild as PTimingInterval;
            }
            else if (Count == oldChild)
            {
                if (!(newChild is TNumber) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Count = newChild as TNumber;
            }
            else throw new ArgumentException("Node to be replaced is not a child in this production.");
        }
        protected override IEnumerable<Node> GetChildren()
        {
            if (HasPrincipal)
                yield return Principal;
            if (HasPeriod)
                yield return Period;
            {
                PTimingInterval[] temp = new PTimingInterval[Interval.Count];
                Interval.CopyTo(temp, 0);
                for (int i = 0; i < temp.Length; i++)
                    yield return temp[i];
            }
            if (HasCount)
                yield return Count;
        }
        
        public override PTimePolicy Clone()
        {
            return new ATimePolicy(Principal?.Clone(), Period?.Clone(), Interval.Clone(), Count?.Clone());
        }
        
        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3}", Principal, Period, Interval, Count);
        }
    }
    public abstract partial class PTimingPeriod : Production<PTimingPeriod>
    {
        private TTime _from_;
        private TTime _to_;
        
        public PTimingPeriod(TTime _from_, TTime _to_)
        {
            this.From = _from_;
            this.To = _to_;
        }
        
        public TTime From
        {
            get { return _from_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("From in PTimingPeriod cannot be null.", "value");
                
                if (_from_ != null)
                    SetParent(_from_, null);
                SetParent(value, this);
                
                _from_ = value;
            }
        }
        public TTime To
        {
            get { return _to_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("To in PTimingPeriod cannot be null.", "value");
                
                if (_to_ != null)
                    SetParent(_to_, null);
                SetParent(value, this);
                
                _to_ = value;
            }
        }
        
    }
    public partial class ATimingPeriod : PTimingPeriod
    {
        public ATimingPeriod(TTime _from_, TTime _to_)
            : base(_from_, _to_)
        {
        }
        
        public override void ReplaceChild(Node oldChild, Node newChild)
        {
            if (From == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("From in ATimingPeriod cannot be null.", "newChild");
                if (!(newChild is TTime) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                From = newChild as TTime;
            }
            else if (To == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("To in ATimingPeriod cannot be null.", "newChild");
                if (!(newChild is TTime) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                To = newChild as TTime;
            }
            else throw new ArgumentException("Node to be replaced is not a child in this production.");
        }
        protected override IEnumerable<Node> GetChildren()
        {
            yield return From;
            yield return To;
        }
        
        public override PTimingPeriod Clone()
        {
            return new ATimingPeriod(From.Clone(), To.Clone());
        }
        
        public override string ToString()
        {
            return string.Format("{0} {1}", From, To);
        }
    }
    public abstract partial class PTimingInterval : Production<PTimingInterval>
    {
        private TNumber _number_;
        private TIntervalUnit _unit_;
        
        public PTimingInterval(TNumber _number_, TIntervalUnit _unit_)
        {
            this.Number = _number_;
            this.Unit = _unit_;
        }
        
        public TNumber Number
        {
            get { return _number_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Number in PTimingInterval cannot be null.", "value");
                
                if (_number_ != null)
                    SetParent(_number_, null);
                SetParent(value, this);
                
                _number_ = value;
            }
        }
        public TIntervalUnit Unit
        {
            get { return _unit_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Unit in PTimingInterval cannot be null.", "value");
                
                if (_unit_ != null)
                    SetParent(_unit_, null);
                SetParent(value, this);
                
                _unit_ = value;
            }
        }
        
    }
    public partial class ATimingInterval : PTimingInterval
    {
        public ATimingInterval(TNumber _number_, TIntervalUnit _unit_)
            : base(_number_, _unit_)
        {
        }
        
        public override void ReplaceChild(Node oldChild, Node newChild)
        {
            if (Number == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("Number in ATimingInterval cannot be null.", "newChild");
                if (!(newChild is TNumber) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Number = newChild as TNumber;
            }
            else if (Unit == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("Unit in ATimingInterval cannot be null.", "newChild");
                if (!(newChild is TIntervalUnit) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Unit = newChild as TIntervalUnit;
            }
            else throw new ArgumentException("Node to be replaced is not a child in this production.");
        }
        protected override IEnumerable<Node> GetChildren()
        {
            yield return Number;
            yield return Unit;
        }
        
        public override PTimingInterval Clone()
        {
            return new ATimingInterval(Number.Clone(), Unit.Clone());
        }
        
        public override string ToString()
        {
            return string.Format("{0} {1}", Number, Unit);
        }
    }
    public abstract partial class PPolicy : Production<PPolicy>
    {
        public PPolicy()
        {
        }
        
    }
    public partial class AVariablePolicy : PPolicy
    {
        private TIdentifier _identifier_;
        
        public AVariablePolicy(TIdentifier _identifier_)
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
                    throw new ArgumentException("Identifier in AVariablePolicy cannot be null.", "value");
                
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
                    throw new ArgumentException("Identifier in AVariablePolicy cannot be null.", "newChild");
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
        
        public override PPolicy Clone()
        {
            return new AVariablePolicy(Identifier.Clone());
        }
        
        public override string ToString()
        {
            return string.Format("{0}", Identifier);
        }
    }
    public partial class APrincipalPolicy : PPolicy
    {
        private PPrincipal _owner_;
        private NodeList<PPrincipal> _readers_;
        
        public APrincipalPolicy(PPrincipal _owner_, IEnumerable<PPrincipal> _readers_)
            : base()
        {
            this.Owner = _owner_;
            this._readers_ = new NodeList<PPrincipal>(this, _readers_, true);
        }
        
        public PPrincipal Owner
        {
            get { return _owner_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Owner in APrincipalPolicy cannot be null.", "value");
                
                if (_owner_ != null)
                    SetParent(_owner_, null);
                SetParent(value, this);
                
                _owner_ = value;
            }
        }
        public NodeList<PPrincipal> Readers
        {
            get { return _readers_; }
        }
        
        public override void ReplaceChild(Node oldChild, Node newChild)
        {
            if (Owner == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("Owner in APrincipalPolicy cannot be null.", "newChild");
                if (!(newChild is PPrincipal) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Owner = newChild as PPrincipal;
            }
            else if (oldChild is PPrincipal && Readers.Contains(oldChild as PPrincipal))
            {
                if (!(newChild is PPrincipal) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                
                int index = Readers.IndexOf(oldChild as PPrincipal);
                if (newChild == null)
                    Readers.RemoveAt(index);
                else
                    Readers[index] = newChild as PPrincipal;
            }
            else throw new ArgumentException("Node to be replaced is not a child in this production.");
        }
        protected override IEnumerable<Node> GetChildren()
        {
            yield return Owner;
            {
                PPrincipal[] temp = new PPrincipal[Readers.Count];
                Readers.CopyTo(temp, 0);
                for (int i = 0; i < temp.Length; i++)
                    yield return temp[i];
            }
        }
        
        public override PPolicy Clone()
        {
            return new APrincipalPolicy(Owner.Clone(), Readers.Clone());
        }
        
        public override string ToString()
        {
            return string.Format("{0} {1}", Owner, Readers);
        }
    }
    public partial class ALowerPolicy : PPolicy
    {
        private TUnderscore _underscore_;
        
        public ALowerPolicy(TUnderscore _underscore_)
            : base()
        {
            this.Underscore = _underscore_;
        }
        
        public TUnderscore Underscore
        {
            get { return _underscore_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Underscore in ALowerPolicy cannot be null.", "value");
                
                if (_underscore_ != null)
                    SetParent(_underscore_, null);
                SetParent(value, this);
                
                _underscore_ = value;
            }
        }
        
        public override void ReplaceChild(Node oldChild, Node newChild)
        {
            if (Underscore == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("Underscore in ALowerPolicy cannot be null.", "newChild");
                if (!(newChild is TUnderscore) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Underscore = newChild as TUnderscore;
            }
            else throw new ArgumentException("Node to be replaced is not a child in this production.");
        }
        protected override IEnumerable<Node> GetChildren()
        {
            yield return Underscore;
        }
        
        public override PPolicy Clone()
        {
            return new ALowerPolicy(Underscore.Clone());
        }
        
        public override string ToString()
        {
            return string.Format("{0}", Underscore);
        }
    }
    public partial class AUpperPolicy : PPolicy
    {
        private THat _hat_;
        
        public AUpperPolicy(THat _hat_)
            : base()
        {
            this.Hat = _hat_;
        }
        
        public THat Hat
        {
            get { return _hat_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Hat in AUpperPolicy cannot be null.", "value");
                
                if (_hat_ != null)
                    SetParent(_hat_, null);
                SetParent(value, this);
                
                _hat_ = value;
            }
        }
        
        public override void ReplaceChild(Node oldChild, Node newChild)
        {
            if (Hat == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("Hat in AUpperPolicy cannot be null.", "newChild");
                if (!(newChild is THat) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Hat = newChild as THat;
            }
            else throw new ArgumentException("Node to be replaced is not a child in this production.");
        }
        protected override IEnumerable<Node> GetChildren()
        {
            yield return Hat;
        }
        
        public override PPolicy Clone()
        {
            return new AUpperPolicy(Hat.Clone());
        }
        
        public override string ToString()
        {
            return string.Format("{0}", Hat);
        }
    }
    public abstract partial class PPrincipal : Production<PPrincipal>
    {
        private TIdentifier _identifier_;
        
        public PPrincipal(TIdentifier _identifier_)
        {
            this.Identifier = _identifier_;
        }
        
        public TIdentifier Identifier
        {
            get { return _identifier_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Identifier in PPrincipal cannot be null.", "value");
                
                if (_identifier_ != null)
                    SetParent(_identifier_, null);
                SetParent(value, this);
                
                _identifier_ = value;
            }
        }
        
    }
    public partial class APrincipal : PPrincipal
    {
        public APrincipal(TIdentifier _identifier_)
            : base(_identifier_)
        {
        }
        
        public override void ReplaceChild(Node oldChild, Node newChild)
        {
            if (Identifier == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("Identifier in APrincipal cannot be null.", "newChild");
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
        
        public override PPrincipal Clone()
        {
            return new APrincipal(Identifier.Clone());
        }
        
        public override string ToString()
        {
            return string.Format("{0}", Identifier);
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
        private TAnd _and_;
        private PExpression _right_;
        
        public AAndExpression(PExpression _left_, TAnd _and_, PExpression _right_)
            : base()
        {
            this.Left = _left_;
            this.And = _and_;
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
        public TAnd And
        {
            get { return _and_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("And in AAndExpression cannot be null.", "value");
                
                if (_and_ != null)
                    SetParent(_and_, null);
                SetParent(value, this);
                
                _and_ = value;
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
            else if (And == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("And in AAndExpression cannot be null.", "newChild");
                if (!(newChild is TAnd) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                And = newChild as TAnd;
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
            yield return And;
            yield return Right;
        }
        
        public override PExpression Clone()
        {
            return new AAndExpression(Left.Clone(), And.Clone(), Right.Clone());
        }
        
        public override string ToString()
        {
            return string.Format("{0} {1} {2}", Left, And, Right);
        }
    }
    public partial class AOrExpression : PExpression
    {
        private PExpression _left_;
        private TOr _or_;
        private PExpression _right_;
        
        public AOrExpression(PExpression _left_, TOr _or_, PExpression _right_)
            : base()
        {
            this.Left = _left_;
            this.Or = _or_;
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
        public TOr Or
        {
            get { return _or_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Or in AOrExpression cannot be null.", "value");
                
                if (_or_ != null)
                    SetParent(_or_, null);
                SetParent(value, this);
                
                _or_ = value;
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
            else if (Or == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("Or in AOrExpression cannot be null.", "newChild");
                if (!(newChild is TOr) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Or = newChild as TOr;
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
            yield return Or;
            yield return Right;
        }
        
        public override PExpression Clone()
        {
            return new AOrExpression(Left.Clone(), Or.Clone(), Right.Clone());
        }
        
        public override string ToString()
        {
            return string.Format("{0} {1} {2}", Left, Or, Right);
        }
    }
    public partial class ANotExpression : PExpression
    {
        private TBang _bang_;
        private PExpression _expression_;
        
        public ANotExpression(TBang _bang_, PExpression _expression_)
            : base()
        {
            this.Bang = _bang_;
            this.Expression = _expression_;
        }
        
        public TBang Bang
        {
            get { return _bang_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Bang in ANotExpression cannot be null.", "value");
                
                if (_bang_ != null)
                    SetParent(_bang_, null);
                SetParent(value, this);
                
                _bang_ = value;
            }
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
            if (Bang == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("Bang in ANotExpression cannot be null.", "newChild");
                if (!(newChild is TBang) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Bang = newChild as TBang;
            }
            else if (Expression == oldChild)
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
            yield return Bang;
            yield return Expression;
        }
        
        public override PExpression Clone()
        {
            return new ANotExpression(Bang.Clone(), Expression.Clone());
        }
        
        public override string ToString()
        {
            return string.Format("{0} {1}", Bang, Expression);
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
        private TLSqu _leftpar_;
        private PExpression _index_;
        private TRSqu _rightpar_;
        
        public AIndexExpression(PExpression _expression_, TLSqu _leftpar_, PExpression _index_, TRSqu _rightpar_)
            : base()
        {
            this.Expression = _expression_;
            this.LeftPar = _leftpar_;
            this.Index = _index_;
            this.RightPar = _rightpar_;
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
        public TLSqu LeftPar
        {
            get { return _leftpar_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("LeftPar in AIndexExpression cannot be null.", "value");
                
                if (_leftpar_ != null)
                    SetParent(_leftpar_, null);
                SetParent(value, this);
                
                _leftpar_ = value;
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
        public TRSqu RightPar
        {
            get { return _rightpar_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("RightPar in AIndexExpression cannot be null.", "value");
                
                if (_rightpar_ != null)
                    SetParent(_rightpar_, null);
                SetParent(value, this);
                
                _rightpar_ = value;
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
            else if (LeftPar == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("LeftPar in AIndexExpression cannot be null.", "newChild");
                if (!(newChild is TLSqu) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                LeftPar = newChild as TLSqu;
            }
            else if (Index == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("Index in AIndexExpression cannot be null.", "newChild");
                if (!(newChild is PExpression) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Index = newChild as PExpression;
            }
            else if (RightPar == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("RightPar in AIndexExpression cannot be null.", "newChild");
                if (!(newChild is TRSqu) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                RightPar = newChild as TRSqu;
            }
            else throw new ArgumentException("Node to be replaced is not a child in this production.");
        }
        protected override IEnumerable<Node> GetChildren()
        {
            yield return Expression;
            yield return LeftPar;
            yield return Index;
            yield return RightPar;
        }
        
        public override PExpression Clone()
        {
            return new AIndexExpression(Expression.Clone(), LeftPar.Clone(), Index.Clone(), RightPar.Clone());
        }
        
        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3}", Expression, LeftPar, Index, RightPar);
        }
    }
    public partial class APlusExpression : PExpression
    {
        private PExpression _left_;
        private TPlus _plus_;
        private PExpression _right_;
        
        public APlusExpression(PExpression _left_, TPlus _plus_, PExpression _right_)
            : base()
        {
            this.Left = _left_;
            this.Plus = _plus_;
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
        public TPlus Plus
        {
            get { return _plus_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Plus in APlusExpression cannot be null.", "value");
                
                if (_plus_ != null)
                    SetParent(_plus_, null);
                SetParent(value, this);
                
                _plus_ = value;
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
            else if (Plus == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("Plus in APlusExpression cannot be null.", "newChild");
                if (!(newChild is TPlus) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Plus = newChild as TPlus;
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
            yield return Plus;
            yield return Right;
        }
        
        public override PExpression Clone()
        {
            return new APlusExpression(Left.Clone(), Plus.Clone(), Right.Clone());
        }
        
        public override string ToString()
        {
            return string.Format("{0} {1} {2}", Left, Plus, Right);
        }
    }
    public partial class AMinusExpression : PExpression
    {
        private PExpression _left_;
        private TMinus _minus_;
        private PExpression _right_;
        
        public AMinusExpression(PExpression _left_, TMinus _minus_, PExpression _right_)
            : base()
        {
            this.Left = _left_;
            this.Minus = _minus_;
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
        public TMinus Minus
        {
            get { return _minus_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Minus in AMinusExpression cannot be null.", "value");
                
                if (_minus_ != null)
                    SetParent(_minus_, null);
                SetParent(value, this);
                
                _minus_ = value;
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
            else if (Minus == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("Minus in AMinusExpression cannot be null.", "newChild");
                if (!(newChild is TMinus) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Minus = newChild as TMinus;
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
            yield return Minus;
            yield return Right;
        }
        
        public override PExpression Clone()
        {
            return new AMinusExpression(Left.Clone(), Minus.Clone(), Right.Clone());
        }
        
        public override string ToString()
        {
            return string.Format("{0} {1} {2}", Left, Minus, Right);
        }
    }
    public partial class AMultiplyExpression : PExpression
    {
        private PExpression _left_;
        private TAsterisk _asterisk_;
        private PExpression _right_;
        
        public AMultiplyExpression(PExpression _left_, TAsterisk _asterisk_, PExpression _right_)
            : base()
        {
            this.Left = _left_;
            this.Asterisk = _asterisk_;
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
        public TAsterisk Asterisk
        {
            get { return _asterisk_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Asterisk in AMultiplyExpression cannot be null.", "value");
                
                if (_asterisk_ != null)
                    SetParent(_asterisk_, null);
                SetParent(value, this);
                
                _asterisk_ = value;
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
            else if (Asterisk == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("Asterisk in AMultiplyExpression cannot be null.", "newChild");
                if (!(newChild is TAsterisk) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Asterisk = newChild as TAsterisk;
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
            yield return Asterisk;
            yield return Right;
        }
        
        public override PExpression Clone()
        {
            return new AMultiplyExpression(Left.Clone(), Asterisk.Clone(), Right.Clone());
        }
        
        public override string ToString()
        {
            return string.Format("{0} {1} {2}", Left, Asterisk, Right);
        }
    }
    public partial class ADivideExpression : PExpression
    {
        private PExpression _left_;
        private TSlash _slash_;
        private PExpression _right_;
        
        public ADivideExpression(PExpression _left_, TSlash _slash_, PExpression _right_)
            : base()
        {
            this.Left = _left_;
            this.Slash = _slash_;
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
        public TSlash Slash
        {
            get { return _slash_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Slash in ADivideExpression cannot be null.", "value");
                
                if (_slash_ != null)
                    SetParent(_slash_, null);
                SetParent(value, this);
                
                _slash_ = value;
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
            else if (Slash == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("Slash in ADivideExpression cannot be null.", "newChild");
                if (!(newChild is TSlash) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Slash = newChild as TSlash;
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
            yield return Slash;
            yield return Right;
        }
        
        public override PExpression Clone()
        {
            return new ADivideExpression(Left.Clone(), Slash.Clone(), Right.Clone());
        }
        
        public override string ToString()
        {
            return string.Format("{0} {1} {2}", Left, Slash, Right);
        }
    }
    public partial class AModuloExpression : PExpression
    {
        private PExpression _left_;
        private TPercent _percent_;
        private PExpression _right_;
        
        public AModuloExpression(PExpression _left_, TPercent _percent_, PExpression _right_)
            : base()
        {
            this.Left = _left_;
            this.Percent = _percent_;
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
        public TPercent Percent
        {
            get { return _percent_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Percent in AModuloExpression cannot be null.", "value");
                
                if (_percent_ != null)
                    SetParent(_percent_, null);
                SetParent(value, this);
                
                _percent_ = value;
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
            else if (Percent == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("Percent in AModuloExpression cannot be null.", "newChild");
                if (!(newChild is TPercent) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Percent = newChild as TPercent;
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
            yield return Percent;
            yield return Right;
        }
        
        public override PExpression Clone()
        {
            return new AModuloExpression(Left.Clone(), Percent.Clone(), Right.Clone());
        }
        
        public override string ToString()
        {
            return string.Format("{0} {1} {2}", Left, Percent, Right);
        }
    }
    public partial class ANegateExpression : PExpression
    {
        private TMinus _minus_;
        private PExpression _expression_;
        
        public ANegateExpression(TMinus _minus_, PExpression _expression_)
            : base()
        {
            this.Minus = _minus_;
            this.Expression = _expression_;
        }
        
        public TMinus Minus
        {
            get { return _minus_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Minus in ANegateExpression cannot be null.", "value");
                
                if (_minus_ != null)
                    SetParent(_minus_, null);
                SetParent(value, this);
                
                _minus_ = value;
            }
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
            if (Minus == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("Minus in ANegateExpression cannot be null.", "newChild");
                if (!(newChild is TMinus) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Minus = newChild as TMinus;
            }
            else if (Expression == oldChild)
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
            yield return Minus;
            yield return Expression;
        }
        
        public override PExpression Clone()
        {
            return new ANegateExpression(Minus.Clone(), Expression.Clone());
        }
        
        public override string ToString()
        {
            return string.Format("{0} {1}", Minus, Expression);
        }
    }
    public partial class AFunctionCallExpression : PExpression
    {
        private TTimeCall _timecall_;
        private TIdentifier _function_;
        private NodeList<PPrincipal> _authorities_;
        private TLPar _leftpar_;
        private NodeList<PExpression> _arguments_;
        private TRPar _rightpar_;
        
        public AFunctionCallExpression(TTimeCall _timecall_, TIdentifier _function_, IEnumerable<PPrincipal> _authorities_, TLPar _leftpar_, IEnumerable<PExpression> _arguments_, TRPar _rightpar_)
            : base()
        {
            this.TimeCall = _timecall_;
            this.Function = _function_;
            this._authorities_ = new NodeList<PPrincipal>(this, _authorities_, true);
            this.LeftPar = _leftpar_;
            this._arguments_ = new NodeList<PExpression>(this, _arguments_, true);
            this.RightPar = _rightpar_;
        }
        
        public TTimeCall TimeCall
        {
            get { return _timecall_; }
            set
            {
                if (_timecall_ != null)
                    SetParent(_timecall_, null);
                if (value != null)
                    SetParent(value, this);
                
                _timecall_ = value;
            }
        }
        public bool HasTimeCall
        {
            get { return _timecall_ != null; }
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
        public NodeList<PPrincipal> Authorities
        {
            get { return _authorities_; }
        }
        public TLPar LeftPar
        {
            get { return _leftpar_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("LeftPar in AFunctionCallExpression cannot be null.", "value");
                
                if (_leftpar_ != null)
                    SetParent(_leftpar_, null);
                SetParent(value, this);
                
                _leftpar_ = value;
            }
        }
        public NodeList<PExpression> Arguments
        {
            get { return _arguments_; }
        }
        public TRPar RightPar
        {
            get { return _rightpar_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("RightPar in AFunctionCallExpression cannot be null.", "value");
                
                if (_rightpar_ != null)
                    SetParent(_rightpar_, null);
                SetParent(value, this);
                
                _rightpar_ = value;
            }
        }
        
        public override void ReplaceChild(Node oldChild, Node newChild)
        {
            if (TimeCall == oldChild)
            {
                if (!(newChild is TTimeCall) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                TimeCall = newChild as TTimeCall;
            }
            else if (Function == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("Function in AFunctionCallExpression cannot be null.", "newChild");
                if (!(newChild is TIdentifier) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Function = newChild as TIdentifier;
            }
            else if (oldChild is PPrincipal && Authorities.Contains(oldChild as PPrincipal))
            {
                if (!(newChild is PPrincipal) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                
                int index = Authorities.IndexOf(oldChild as PPrincipal);
                if (newChild == null)
                    Authorities.RemoveAt(index);
                else
                    Authorities[index] = newChild as PPrincipal;
            }
            else if (LeftPar == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("LeftPar in AFunctionCallExpression cannot be null.", "newChild");
                if (!(newChild is TLPar) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                LeftPar = newChild as TLPar;
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
            else if (RightPar == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("RightPar in AFunctionCallExpression cannot be null.", "newChild");
                if (!(newChild is TRPar) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                RightPar = newChild as TRPar;
            }
            else throw new ArgumentException("Node to be replaced is not a child in this production.");
        }
        protected override IEnumerable<Node> GetChildren()
        {
            if (HasTimeCall)
                yield return TimeCall;
            yield return Function;
            {
                PPrincipal[] temp = new PPrincipal[Authorities.Count];
                Authorities.CopyTo(temp, 0);
                for (int i = 0; i < temp.Length; i++)
                    yield return temp[i];
            }
            yield return LeftPar;
            {
                PExpression[] temp = new PExpression[Arguments.Count];
                Arguments.CopyTo(temp, 0);
                for (int i = 0; i < temp.Length; i++)
                    yield return temp[i];
            }
            yield return RightPar;
        }
        
        public override PExpression Clone()
        {
            return new AFunctionCallExpression(TimeCall?.Clone(), Function.Clone(), Authorities.Clone(), LeftPar.Clone(), Arguments.Clone(), RightPar.Clone());
        }
        
        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4} {5}", TimeCall, Function, Authorities, LeftPar, Arguments, RightPar);
        }
    }
    public partial class ATernaryExpression : PExpression
    {
        private PExpression _condition_;
        private TQuestion _question_;
        private PExpression _true_;
        private TColon _colon_;
        private PExpression _false_;
        
        public ATernaryExpression(PExpression _condition_, TQuestion _question_, PExpression _true_, TColon _colon_, PExpression _false_)
            : base()
        {
            this.Condition = _condition_;
            this.Question = _question_;
            this.True = _true_;
            this.Colon = _colon_;
            this.False = _false_;
        }
        
        public PExpression Condition
        {
            get { return _condition_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Condition in ATernaryExpression cannot be null.", "value");
                
                if (_condition_ != null)
                    SetParent(_condition_, null);
                SetParent(value, this);
                
                _condition_ = value;
            }
        }
        public TQuestion Question
        {
            get { return _question_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Question in ATernaryExpression cannot be null.", "value");
                
                if (_question_ != null)
                    SetParent(_question_, null);
                SetParent(value, this);
                
                _question_ = value;
            }
        }
        public PExpression True
        {
            get { return _true_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("True in ATernaryExpression cannot be null.", "value");
                
                if (_true_ != null)
                    SetParent(_true_, null);
                SetParent(value, this);
                
                _true_ = value;
            }
        }
        public TColon Colon
        {
            get { return _colon_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Colon in ATernaryExpression cannot be null.", "value");
                
                if (_colon_ != null)
                    SetParent(_colon_, null);
                SetParent(value, this);
                
                _colon_ = value;
            }
        }
        public PExpression False
        {
            get { return _false_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("False in ATernaryExpression cannot be null.", "value");
                
                if (_false_ != null)
                    SetParent(_false_, null);
                SetParent(value, this);
                
                _false_ = value;
            }
        }
        
        public override void ReplaceChild(Node oldChild, Node newChild)
        {
            if (Condition == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("Condition in ATernaryExpression cannot be null.", "newChild");
                if (!(newChild is PExpression) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Condition = newChild as PExpression;
            }
            else if (Question == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("Question in ATernaryExpression cannot be null.", "newChild");
                if (!(newChild is TQuestion) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Question = newChild as TQuestion;
            }
            else if (True == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("True in ATernaryExpression cannot be null.", "newChild");
                if (!(newChild is PExpression) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                True = newChild as PExpression;
            }
            else if (Colon == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("Colon in ATernaryExpression cannot be null.", "newChild");
                if (!(newChild is TColon) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Colon = newChild as TColon;
            }
            else if (False == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("False in ATernaryExpression cannot be null.", "newChild");
                if (!(newChild is PExpression) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                False = newChild as PExpression;
            }
            else throw new ArgumentException("Node to be replaced is not a child in this production.");
        }
        protected override IEnumerable<Node> GetChildren()
        {
            yield return Condition;
            yield return Question;
            yield return True;
            yield return Colon;
            yield return False;
        }
        
        public override PExpression Clone()
        {
            return new ATernaryExpression(Condition.Clone(), Question.Clone(), True.Clone(), Colon.Clone(), False.Clone());
        }
        
        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4}", Condition, Question, True, Colon, False);
        }
    }
    public partial class AParenthesisExpression : PExpression
    {
        private TLPar _leftpar_;
        private PExpression _expression_;
        private TRPar _rightpar_;
        
        public AParenthesisExpression(TLPar _leftpar_, PExpression _expression_, TRPar _rightpar_)
            : base()
        {
            this.LeftPar = _leftpar_;
            this.Expression = _expression_;
            this.RightPar = _rightpar_;
        }
        
        public TLPar LeftPar
        {
            get { return _leftpar_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("LeftPar in AParenthesisExpression cannot be null.", "value");
                
                if (_leftpar_ != null)
                    SetParent(_leftpar_, null);
                SetParent(value, this);
                
                _leftpar_ = value;
            }
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
        public TRPar RightPar
        {
            get { return _rightpar_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("RightPar in AParenthesisExpression cannot be null.", "value");
                
                if (_rightpar_ != null)
                    SetParent(_rightpar_, null);
                SetParent(value, this);
                
                _rightpar_ = value;
            }
        }
        
        public override void ReplaceChild(Node oldChild, Node newChild)
        {
            if (LeftPar == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("LeftPar in AParenthesisExpression cannot be null.", "newChild");
                if (!(newChild is TLPar) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                LeftPar = newChild as TLPar;
            }
            else if (Expression == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("Expression in AParenthesisExpression cannot be null.", "newChild");
                if (!(newChild is PExpression) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Expression = newChild as PExpression;
            }
            else if (RightPar == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("RightPar in AParenthesisExpression cannot be null.", "newChild");
                if (!(newChild is TRPar) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                RightPar = newChild as TRPar;
            }
            else throw new ArgumentException("Node to be replaced is not a child in this production.");
        }
        protected override IEnumerable<Node> GetChildren()
        {
            yield return LeftPar;
            yield return Expression;
            yield return RightPar;
        }
        
        public override PExpression Clone()
        {
            return new AParenthesisExpression(LeftPar.Clone(), Expression.Clone(), RightPar.Clone());
        }
        
        public override string ToString()
        {
            return string.Format("{0} {1} {2}", LeftPar, Expression, RightPar);
        }
    }
    public partial class ADeclassifyExpression : PExpression
    {
        private TDeclassifyStart _declassifystart_;
        private PExpression _expression_;
        private PLabel _label_;
        private TDeclassifyEnd _declassifyend_;
        
        public ADeclassifyExpression(TDeclassifyStart _declassifystart_, PExpression _expression_, PLabel _label_, TDeclassifyEnd _declassifyend_)
            : base()
        {
            this.DeclassifyStart = _declassifystart_;
            this.Expression = _expression_;
            this.Label = _label_;
            this.DeclassifyEnd = _declassifyend_;
        }
        
        public TDeclassifyStart DeclassifyStart
        {
            get { return _declassifystart_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("DeclassifyStart in ADeclassifyExpression cannot be null.", "value");
                
                if (_declassifystart_ != null)
                    SetParent(_declassifystart_, null);
                SetParent(value, this);
                
                _declassifystart_ = value;
            }
        }
        public PExpression Expression
        {
            get { return _expression_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Expression in ADeclassifyExpression cannot be null.", "value");
                
                if (_expression_ != null)
                    SetParent(_expression_, null);
                SetParent(value, this);
                
                _expression_ = value;
            }
        }
        public PLabel Label
        {
            get { return _label_; }
            set
            {
                if (_label_ != null)
                    SetParent(_label_, null);
                if (value != null)
                    SetParent(value, this);
                
                _label_ = value;
            }
        }
        public bool HasLabel
        {
            get { return _label_ != null; }
        }
        public TDeclassifyEnd DeclassifyEnd
        {
            get { return _declassifyend_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("DeclassifyEnd in ADeclassifyExpression cannot be null.", "value");
                
                if (_declassifyend_ != null)
                    SetParent(_declassifyend_, null);
                SetParent(value, this);
                
                _declassifyend_ = value;
            }
        }
        
        public override void ReplaceChild(Node oldChild, Node newChild)
        {
            if (DeclassifyStart == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("DeclassifyStart in ADeclassifyExpression cannot be null.", "newChild");
                if (!(newChild is TDeclassifyStart) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                DeclassifyStart = newChild as TDeclassifyStart;
            }
            else if (Expression == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("Expression in ADeclassifyExpression cannot be null.", "newChild");
                if (!(newChild is PExpression) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Expression = newChild as PExpression;
            }
            else if (Label == oldChild)
            {
                if (!(newChild is PLabel) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Label = newChild as PLabel;
            }
            else if (DeclassifyEnd == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("DeclassifyEnd in ADeclassifyExpression cannot be null.", "newChild");
                if (!(newChild is TDeclassifyEnd) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                DeclassifyEnd = newChild as TDeclassifyEnd;
            }
            else throw new ArgumentException("Node to be replaced is not a child in this production.");
        }
        protected override IEnumerable<Node> GetChildren()
        {
            yield return DeclassifyStart;
            yield return Expression;
            if (HasLabel)
                yield return Label;
            yield return DeclassifyEnd;
        }
        
        public override PExpression Clone()
        {
            return new ADeclassifyExpression(DeclassifyStart.Clone(), Expression.Clone(), Label?.Clone(), DeclassifyEnd.Clone());
        }
        
        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3}", DeclassifyStart, Expression, Label, DeclassifyEnd);
        }
    }
    public partial class ADereferenceExpression : PExpression
    {
        private TAsterisk _asterisk_;
        private PExpression _expression_;
        
        public ADereferenceExpression(TAsterisk _asterisk_, PExpression _expression_)
            : base()
        {
            this.Asterisk = _asterisk_;
            this.Expression = _expression_;
        }
        
        public TAsterisk Asterisk
        {
            get { return _asterisk_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Asterisk in ADereferenceExpression cannot be null.", "value");
                
                if (_asterisk_ != null)
                    SetParent(_asterisk_, null);
                SetParent(value, this);
                
                _asterisk_ = value;
            }
        }
        public PExpression Expression
        {
            get { return _expression_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Expression in ADereferenceExpression cannot be null.", "value");
                
                if (_expression_ != null)
                    SetParent(_expression_, null);
                SetParent(value, this);
                
                _expression_ = value;
            }
        }
        
        public override void ReplaceChild(Node oldChild, Node newChild)
        {
            if (Asterisk == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("Asterisk in ADereferenceExpression cannot be null.", "newChild");
                if (!(newChild is TAsterisk) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Asterisk = newChild as TAsterisk;
            }
            else if (Expression == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("Expression in ADereferenceExpression cannot be null.", "newChild");
                if (!(newChild is PExpression) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Expression = newChild as PExpression;
            }
            else throw new ArgumentException("Node to be replaced is not a child in this production.");
        }
        protected override IEnumerable<Node> GetChildren()
        {
            yield return Asterisk;
            yield return Expression;
        }
        
        public override PExpression Clone()
        {
            return new ADereferenceExpression(Asterisk.Clone(), Expression.Clone());
        }
        
        public override string ToString()
        {
            return string.Format("{0} {1}", Asterisk, Expression);
        }
    }
    public partial class AAddressExpression : PExpression
    {
        private TAmpersand _ampersand_;
        private PExpression _expression_;
        
        public AAddressExpression(TAmpersand _ampersand_, PExpression _expression_)
            : base()
        {
            this.Ampersand = _ampersand_;
            this.Expression = _expression_;
        }
        
        public TAmpersand Ampersand
        {
            get { return _ampersand_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Ampersand in AAddressExpression cannot be null.", "value");
                
                if (_ampersand_ != null)
                    SetParent(_ampersand_, null);
                SetParent(value, this);
                
                _ampersand_ = value;
            }
        }
        public PExpression Expression
        {
            get { return _expression_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Expression in AAddressExpression cannot be null.", "value");
                
                if (_expression_ != null)
                    SetParent(_expression_, null);
                SetParent(value, this);
                
                _expression_ = value;
            }
        }
        
        public override void ReplaceChild(Node oldChild, Node newChild)
        {
            if (Ampersand == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("Ampersand in AAddressExpression cannot be null.", "newChild");
                if (!(newChild is TAmpersand) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Ampersand = newChild as TAmpersand;
            }
            else if (Expression == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("Expression in AAddressExpression cannot be null.", "newChild");
                if (!(newChild is PExpression) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Expression = newChild as PExpression;
            }
            else throw new ArgumentException("Node to be replaced is not a child in this production.");
        }
        protected override IEnumerable<Node> GetChildren()
        {
            yield return Ampersand;
            yield return Expression;
        }
        
        public override PExpression Clone()
        {
            return new AAddressExpression(Ampersand.Clone(), Expression.Clone());
        }
        
        public override string ToString()
        {
            return string.Format("{0} {1}", Ampersand, Expression);
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
    public partial class ATimeCheckExpression : PExpression
    {
        private TTimeCheck _timecheck_;
        private TIdentifier _function_;
        
        public ATimeCheckExpression(TTimeCheck _timecheck_, TIdentifier _function_)
            : base()
        {
            this.TimeCheck = _timecheck_;
            this.Function = _function_;
        }
        
        public TTimeCheck TimeCheck
        {
            get { return _timecheck_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("TimeCheck in ATimeCheckExpression cannot be null.", "value");
                
                if (_timecheck_ != null)
                    SetParent(_timecheck_, null);
                SetParent(value, this);
                
                _timecheck_ = value;
            }
        }
        public TIdentifier Function
        {
            get { return _function_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Function in ATimeCheckExpression cannot be null.", "value");
                
                if (_function_ != null)
                    SetParent(_function_, null);
                SetParent(value, this);
                
                _function_ = value;
            }
        }
        
        public override void ReplaceChild(Node oldChild, Node newChild)
        {
            if (TimeCheck == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("TimeCheck in ATimeCheckExpression cannot be null.", "newChild");
                if (!(newChild is TTimeCheck) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                TimeCheck = newChild as TTimeCheck;
            }
            else if (Function == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("Function in ATimeCheckExpression cannot be null.", "newChild");
                if (!(newChild is TIdentifier) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Function = newChild as TIdentifier;
            }
            else throw new ArgumentException("Node to be replaced is not a child in this production.");
        }
        protected override IEnumerable<Node> GetChildren()
        {
            yield return TimeCheck;
            yield return Function;
        }
        
        public override PExpression Clone()
        {
            return new ATimeCheckExpression(TimeCheck.Clone(), Function.Clone());
        }
        
        public override string ToString()
        {
            return string.Format("{0} {1}", TimeCheck, Function);
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
    public partial class ANullExpression : PExpression
    {
        private TNull _null_;
        
        public ANullExpression(TNull _null_)
            : base()
        {
            this.Null = _null_;
        }
        
        public TNull Null
        {
            get { return _null_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Null in ANullExpression cannot be null.", "value");
                
                if (_null_ != null)
                    SetParent(_null_, null);
                SetParent(value, this);
                
                _null_ = value;
            }
        }
        
        public override void ReplaceChild(Node oldChild, Node newChild)
        {
            if (Null == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("Null in ANullExpression cannot be null.", "newChild");
                if (!(newChild is TNull) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Null = newChild as TNull;
            }
            else throw new ArgumentException("Node to be replaced is not a child in this production.");
        }
        protected override IEnumerable<Node> GetChildren()
        {
            yield return Null;
        }
        
        public override PExpression Clone()
        {
            return new ANullExpression(Null.Clone());
        }
        
        public override string ToString()
        {
            return string.Format("{0}", Null);
        }
    }
    public partial class ACharExpression : PExpression
    {
        private TChar _char_;
        
        public ACharExpression(TChar _char_)
            : base()
        {
            this.Char = _char_;
        }
        
        public TChar Char
        {
            get { return _char_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Char in ACharExpression cannot be null.", "value");
                
                if (_char_ != null)
                    SetParent(_char_, null);
                SetParent(value, this);
                
                _char_ = value;
            }
        }
        
        public override void ReplaceChild(Node oldChild, Node newChild)
        {
            if (Char == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("Char in ACharExpression cannot be null.", "newChild");
                if (!(newChild is TChar) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Char = newChild as TChar;
            }
            else throw new ArgumentException("Node to be replaced is not a child in this production.");
        }
        protected override IEnumerable<Node> GetChildren()
        {
            yield return Char;
        }
        
        public override PExpression Clone()
        {
            return new ACharExpression(Char.Clone());
        }
        
        public override string ToString()
        {
            return string.Format("{0}", Char);
        }
    }
    public partial class AStringExpression : PExpression
    {
        private TString _string_;
        
        public AStringExpression(TString _string_)
            : base()
        {
            this.String = _string_;
        }
        
        public TString String
        {
            get { return _string_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("String in AStringExpression cannot be null.", "value");
                
                if (_string_ != null)
                    SetParent(_string_, null);
                SetParent(value, this);
                
                _string_ = value;
            }
        }
        
        public override void ReplaceChild(Node oldChild, Node newChild)
        {
            if (String == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("String in AStringExpression cannot be null.", "newChild");
                if (!(newChild is TString) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                String = newChild as TString;
            }
            else throw new ArgumentException("Node to be replaced is not a child in this production.");
        }
        protected override IEnumerable<Node> GetChildren()
        {
            yield return String;
        }
        
        public override PExpression Clone()
        {
            return new AStringExpression(String.Clone());
        }
        
        public override string ToString()
        {
            return string.Format("{0}", String);
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
        private TPeriod _period_;
        
        public AElement(TPeriod _period_, TIdentifier _identifier_)
            : base(_identifier_)
        {
            this.Period = _period_;
        }
        
        public TPeriod Period
        {
            get { return _period_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Period in AElement cannot be null.", "value");
                
                if (_period_ != null)
                    SetParent(_period_, null);
                SetParent(value, this);
                
                _period_ = value;
            }
        }
        
        public override void ReplaceChild(Node oldChild, Node newChild)
        {
            if (Period == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("Period in AElement cannot be null.", "newChild");
                if (!(newChild is TPeriod) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Period = newChild as TPeriod;
            }
            else if (Identifier == oldChild)
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
            yield return Period;
            yield return Identifier;
        }
        
        public override PElement Clone()
        {
            return new AElement(Period.Clone(), Identifier.Clone());
        }
        
        public override string ToString()
        {
            return string.Format("{0} {1}", Period, Identifier);
        }
    }
    public partial class APointerElement : PElement
    {
        private TRArrow _arrow_;
        
        public APointerElement(TRArrow _arrow_, TIdentifier _identifier_)
            : base(_identifier_)
        {
            this.Arrow = _arrow_;
        }
        
        public TRArrow Arrow
        {
            get { return _arrow_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Arrow in APointerElement cannot be null.", "value");
                
                if (_arrow_ != null)
                    SetParent(_arrow_, null);
                SetParent(value, this);
                
                _arrow_ = value;
            }
        }
        
        public override void ReplaceChild(Node oldChild, Node newChild)
        {
            if (Arrow == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("Arrow in APointerElement cannot be null.", "newChild");
                if (!(newChild is TRArrow) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Arrow = newChild as TRArrow;
            }
            else if (Identifier == oldChild)
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
            yield return Arrow;
            yield return Identifier;
        }
        
        public override PElement Clone()
        {
            return new APointerElement(Arrow.Clone(), Identifier.Clone());
        }
        
        public override string ToString()
        {
            return string.Format("{0} {1}", Arrow, Identifier);
        }
    }
}
