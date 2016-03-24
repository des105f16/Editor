using System;
using System.Collections.Generic;
using SablePP.Tools.Nodes;
using DLM.Compiler.Analysis;

namespace DLM.Compiler.Nodes
{
    public abstract partial class PRoot : Production<PRoot>
    {
        private NodeList<PInclude> _includes_;
        private NodeList<PPrincipalDeclaration> _principaldeclarations_;
        private NodeList<PPrincipalHierarchyStatement> _principalhierarchystatements_;
        private NodeList<PStruct> _structs_;
        private NodeList<PStatement> _statements_;
        
        public PRoot(IEnumerable<PInclude> _includes_, IEnumerable<PPrincipalDeclaration> _principaldeclarations_, IEnumerable<PPrincipalHierarchyStatement> _principalhierarchystatements_, IEnumerable<PStruct> _structs_, IEnumerable<PStatement> _statements_)
        {
            this._includes_ = new NodeList<PInclude>(this, _includes_, true);
            this._principaldeclarations_ = new NodeList<PPrincipalDeclaration>(this, _principaldeclarations_, true);
            this._principalhierarchystatements_ = new NodeList<PPrincipalHierarchyStatement>(this, _principalhierarchystatements_, true);
            this._structs_ = new NodeList<PStruct>(this, _structs_, true);
            this._statements_ = new NodeList<PStatement>(this, _statements_, true);
        }
        
        public NodeList<PInclude> Includes
        {
            get { return _includes_; }
        }
        public NodeList<PPrincipalDeclaration> PrincipalDeclarations
        {
            get { return _principaldeclarations_; }
        }
        public NodeList<PPrincipalHierarchyStatement> PrincipalHierarchyStatements
        {
            get { return _principalhierarchystatements_; }
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
        public ARoot(IEnumerable<PInclude> _includes_, IEnumerable<PPrincipalDeclaration> _principaldeclarations_, IEnumerable<PPrincipalHierarchyStatement> _principalhierarchystatements_, IEnumerable<PStruct> _structs_, IEnumerable<PStatement> _statements_)
            : base(_includes_, _principaldeclarations_, _principalhierarchystatements_, _structs_, _statements_)
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
            else if (oldChild is PPrincipalHierarchyStatement && PrincipalHierarchyStatements.Contains(oldChild as PPrincipalHierarchyStatement))
            {
                if (!(newChild is PPrincipalHierarchyStatement) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                
                int index = PrincipalHierarchyStatements.IndexOf(oldChild as PPrincipalHierarchyStatement);
                if (newChild == null)
                    PrincipalHierarchyStatements.RemoveAt(index);
                else
                    PrincipalHierarchyStatements[index] = newChild as PPrincipalHierarchyStatement;
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
                PInclude[] temp = new PInclude[Includes.Count];
                Includes.CopyTo(temp, 0);
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
                PPrincipalHierarchyStatement[] temp = new PPrincipalHierarchyStatement[PrincipalHierarchyStatements.Count];
                PrincipalHierarchyStatements.CopyTo(temp, 0);
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
            return new ARoot(Includes.Clone(), PrincipalDeclarations.Clone(), PrincipalHierarchyStatements.Clone(), Structs.Clone(), Statements.Clone());
        }
        
        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4}", Includes, PrincipalDeclarations, PrincipalHierarchyStatements, Structs, Statements);
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
    public abstract partial class PPrincipalHierarchyStatement : Production<PPrincipalHierarchyStatement>
    {
        private PPrincipal _principal_;
        private NodeList<PPrincipal> _subordinates_;
        
        public PPrincipalHierarchyStatement(PPrincipal _principal_, IEnumerable<PPrincipal> _subordinates_)
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
                    throw new ArgumentException("Principal in PPrincipalHierarchyStatement cannot be null.", "value");
                
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
    public partial class APrincipalHierarchyStatement : PPrincipalHierarchyStatement
    {
        public APrincipalHierarchyStatement(PPrincipal _principal_, IEnumerable<PPrincipal> _subordinates_)
            : base(_principal_, _subordinates_)
        {
        }
        
        public override void ReplaceChild(Node oldChild, Node newChild)
        {
            if (Principal == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("Principal in APrincipalHierarchyStatement cannot be null.", "newChild");
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
        
        public override PPrincipalHierarchyStatement Clone()
        {
            return new APrincipalHierarchyStatement(Principal.Clone(), Subordinates.Clone());
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
            return new AIfStatement(Expression.Clone(), Statements.Clone());
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
            return new AIfElseStatement(Expression.Clone(), IfStatements.Clone(), ElseStatements.Clone());
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
            return new AWhileStatement(Expression.Clone(), Statements.Clone());
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
            return new AFunctionDeclarationStatement(Type.Clone(), Identifier.Clone(), Parameters.Clone(), Statements.Clone());
        }
        
        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3}", Type, Identifier, Parameters, Statements);
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
            return new AReturnStatement(Expression?.Clone());
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
        private PTiming _timing_;
        
        public PLabel(IEnumerable<PPolicy> _policys_, PTiming _timing_)
        {
            this._policys_ = new NodeList<PPolicy>(this, _policys_, false);
            this.Timing = _timing_;
        }
        
        public NodeList<PPolicy> Policys
        {
            get { return _policys_; }
        }
        public PTiming Timing
        {
            get { return _timing_; }
            set
            {
                if (_timing_ != null)
                    SetParent(_timing_, null);
                if (value != null)
                    SetParent(value, this);
                
                _timing_ = value;
            }
        }
        public bool HasTiming
        {
            get { return _timing_ != null; }
        }
        
    }
    public partial class ALabel : PLabel
    {
        public ALabel(IEnumerable<PPolicy> _policys_, PTiming _timing_)
            : base(_policys_, _timing_)
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
            else if (Timing == oldChild)
            {
                if (!(newChild is PTiming) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Timing = newChild as PTiming;
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
            if (HasTiming)
                yield return Timing;
        }
        
        public override PLabel Clone()
        {
            return new ALabel(Policys.Clone(), Timing?.Clone());
        }
        
        public override string ToString()
        {
            return string.Format("{0} {1}", Policys, Timing);
        }
    }
    public abstract partial class PTiming : Production<PTiming>
    {
        private PTimingPeriod _period_;
        private NodeList<PTimingInterval> _interval_;
        private TNumber _count_;
        
        public PTiming(PTimingPeriod _period_, IEnumerable<PTimingInterval> _interval_, TNumber _count_)
        {
            this.Period = _period_;
            this._interval_ = new NodeList<PTimingInterval>(this, _interval_, true);
            this.Count = _count_;
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
    public partial class ATiming : PTiming
    {
        public ATiming(PTimingPeriod _period_, IEnumerable<PTimingInterval> _interval_, TNumber _count_)
            : base(_period_, _interval_, _count_)
        {
        }
        
        public override void ReplaceChild(Node oldChild, Node newChild)
        {
            if (Period == oldChild)
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
        
        public override PTiming Clone()
        {
            return new ATiming(Period?.Clone(), Interval.Clone(), Count?.Clone());
        }
        
        public override string ToString()
        {
            return string.Format("{0} {1} {2}", Period, Interval, Count);
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
        private NodeList<PPrincipal> _authorities_;
        private NodeList<PExpression> _arguments_;
        
        public AFunctionCallExpression(TIdentifier _function_, IEnumerable<PPrincipal> _authorities_, IEnumerable<PExpression> _arguments_)
            : base()
        {
            this.Function = _function_;
            this._authorities_ = new NodeList<PPrincipal>(this, _authorities_, true);
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
        public NodeList<PPrincipal> Authorities
        {
            get { return _authorities_; }
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
                PPrincipal[] temp = new PPrincipal[Authorities.Count];
                Authorities.CopyTo(temp, 0);
                for (int i = 0; i < temp.Length; i++)
                    yield return temp[i];
            }
            {
                PExpression[] temp = new PExpression[Arguments.Count];
                Arguments.CopyTo(temp, 0);
                for (int i = 0; i < temp.Length; i++)
                    yield return temp[i];
            }
        }
        
        public override PExpression Clone()
        {
            return new AFunctionCallExpression(Function.Clone(), Authorities.Clone(), Arguments.Clone());
        }
        
        public override string ToString()
        {
            return string.Format("{0} {1} {2}", Function, Authorities, Arguments);
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
    public partial class ADeclassifyExpression : PExpression
    {
        private TIdentifier _identifier_;
        private PLabel _label_;
        
        public ADeclassifyExpression(TIdentifier _identifier_, PLabel _label_)
            : base()
        {
            this.Identifier = _identifier_;
            this.Label = _label_;
        }
        
        public TIdentifier Identifier
        {
            get { return _identifier_; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Identifier in ADeclassifyExpression cannot be null.", "value");
                
                if (_identifier_ != null)
                    SetParent(_identifier_, null);
                SetParent(value, this);
                
                _identifier_ = value;
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
            if (Identifier == oldChild)
            {
                if (newChild == null)
                    throw new ArgumentException("Identifier in ADeclassifyExpression cannot be null.", "newChild");
                if (!(newChild is TIdentifier) && newChild != null)
                    throw new ArgumentException("Child replaced must be of same type as child being replaced with.");
                Identifier = newChild as TIdentifier;
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
            yield return Identifier;
            if (HasLabel)
                yield return Label;
        }
        
        public override PExpression Clone()
        {
            return new ADeclassifyExpression(Identifier.Clone(), Label?.Clone());
        }
        
        public override string ToString()
        {
            return string.Format("{0} {1}", Identifier, Label);
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
