// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp.Test.Utilities;
using Microsoft.CodeAnalysis.Test.Utilities;
using Roslyn.Test.Utilities;
using Xunit;

namespace Microsoft.CodeAnalysis.CSharp.UnitTests
{
public partial class IOperationTests : SemanticModelTestBase
{
private static readonly CSharpParseOptions ImplicitObjectCreationOptions ;

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ImplicitObjectCreationWithArguments()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,682,12725);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,825,1075);

string 
source = @"
class C
{
    public C(byte i, long j)
    {
    }
    void M()
    /*<bind>*/{
        C x1 = new(3, 4);
        C x2 = new(j: 3, i: 4);
        C x3 = new(3, j: 4);
        C x4 = new(i: 3, 4);
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,1089,1142);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,1158,12549);

string 
expectedOperationTree = @"
IBlockOperation (4 statements, 4 locals) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
  Locals: Local_1: C x1
    Local_2: C x2
    Local_3: C x3
    Local_4: C x4
  IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null) (Syntax: 'C x1 = new(3, 4);')
    IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'C x1 = new(3, 4)')
      Declarators:
          IVariableDeclaratorOperation (Symbol: C x1) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'x1 = new(3, 4)')
            Initializer: 
              IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= new(3, 4)')
                IObjectCreationOperation (Constructor: C..ctor(System.Byte i, System.Int64 j)) (OperationKind.ObjectCreation, Type: C) (Syntax: 'new(3, 4)')
                  Arguments(2):
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: '3')
                        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Byte, Constant: 3, IsImplicit) (Syntax: '3')
                          Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                          Operand: 
                            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: j) (OperationKind.Argument, Type: null) (Syntax: '4')
                        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int64, Constant: 4, IsImplicit) (Syntax: '4')
                          Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                          Operand: 
                            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 4) (Syntax: '4')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  Initializer: 
                    null
      Initializer: 
        null
  IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null) (Syntax: 'C x2 = new(j: 3, i: 4);')
    IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'C x2 = new(j: 3, i: 4)')
      Declarators:
          IVariableDeclaratorOperation (Symbol: C x2) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'x2 = new(j: 3, i: 4)')
            Initializer: 
              IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= new(j: 3, i: 4)')
                IObjectCreationOperation (Constructor: C..ctor(System.Byte i, System.Int64 j)) (OperationKind.ObjectCreation, Type: C) (Syntax: 'new(j: 3, i: 4)')
                  Arguments(2):
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: j) (OperationKind.Argument, Type: null) (Syntax: 'j: 3')
                        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int64, Constant: 3, IsImplicit) (Syntax: '3')
                          Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                          Operand: 
                            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: 'i: 4')
                        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Byte, Constant: 4, IsImplicit) (Syntax: '4')
                          Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                          Operand: 
                            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 4) (Syntax: '4')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  Initializer: 
                    null
      Initializer: 
        null
  IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null) (Syntax: 'C x3 = new(3, j: 4);')
    IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'C x3 = new(3, j: 4)')
      Declarators:
          IVariableDeclaratorOperation (Symbol: C x3) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'x3 = new(3, j: 4)')
            Initializer: 
              IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= new(3, j: 4)')
                IObjectCreationOperation (Constructor: C..ctor(System.Byte i, System.Int64 j)) (OperationKind.ObjectCreation, Type: C) (Syntax: 'new(3, j: 4)')
                  Arguments(2):
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: '3')
                        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Byte, Constant: 3, IsImplicit) (Syntax: '3')
                          Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                          Operand: 
                            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: j) (OperationKind.Argument, Type: null) (Syntax: 'j: 4')
                        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int64, Constant: 4, IsImplicit) (Syntax: '4')
                          Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                          Operand: 
                            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 4) (Syntax: '4')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  Initializer: 
                    null
      Initializer: 
        null
  IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null) (Syntax: 'C x4 = new(i: 3, 4);')
    IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'C x4 = new(i: 3, 4)')
      Declarators:
          IVariableDeclaratorOperation (Symbol: C x4) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'x4 = new(i: 3, 4)')
            Initializer: 
              IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= new(i: 3, 4)')
                IObjectCreationOperation (Constructor: C..ctor(System.Byte i, System.Int64 j)) (OperationKind.ObjectCreation, Type: C) (Syntax: 'new(i: 3, 4)')
                  Arguments(2):
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: 'i: 3')
                        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Byte, Constant: 3, IsImplicit) (Syntax: '3')
                          Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                          Operand: 
                            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: j) (OperationKind.Argument, Type: null) (Syntax: '4')
                        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int64, Constant: 4, IsImplicit) (Syntax: '4')
                          Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                          Operand: 
                            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 4) (Syntax: '4')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  Initializer: 
                    null
      Initializer: 
        null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,12563,12714);

f_22056_12563_12713(source, expectedOperationTree, expectedDiagnostics, parseOptions: ImplicitObjectCreationOptions);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,682,12725);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,682,12725);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,682,12725);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ImplicitObjectCreationWithMemberInitializers()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,12737,41836);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,12889,13450);

var 
comp = f_22056_12900_13449(@"
struct B
{
    public bool Field;
}
class F
{
    public int Field;
    public string Property1 { set; get; }
    public B Property2 { set; get; }
}
class C
{
    public void M1()
    /*<bind>*/{
        F x1 = new();
        F x2 = new() { Field = 2 };
        F x3 = new() { Property1 = """" };
        F x4 = new() { Property1 = """", Field = 2 };
        F x5 = new() { Property2 = new B { Field = true } };
        F e1 = new() { Property2 = 1 };
        F e2 = new() { """" };
    }/*</bind>*/
}
")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,13464,26997);

string 
expectedOperationTree = @"
IBlockOperation (7 statements, 7 locals) (OperationKind.Block, Type: null, IsInvalid) (Syntax: '{ ... }')
  Locals: Local_1: F x1
    Local_2: F x2
    Local_3: F x3
    Local_4: F x4
    Local_5: F x5
    Local_6: F e1
    Local_7: F e2
  IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null) (Syntax: 'F x1 = new();')
    IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'F x1 = new()')
      Declarators:
          IVariableDeclaratorOperation (Symbol: F x1) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'x1 = new()')
            Initializer: 
              IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= new()')
                IObjectCreationOperation (Constructor: F..ctor()) (OperationKind.ObjectCreation, Type: F) (Syntax: 'new()')
                  Arguments(0)
                  Initializer: 
                    null
      Initializer: 
        null
  IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null) (Syntax: 'F x2 = new( ... ield = 2 };')
    IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'F x2 = new( ... Field = 2 }')
      Declarators:
          IVariableDeclaratorOperation (Symbol: F x2) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'x2 = new() { Field = 2 }')
            Initializer: 
              IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= new() { Field = 2 }')
                IObjectCreationOperation (Constructor: F..ctor()) (OperationKind.ObjectCreation, Type: F) (Syntax: 'new() { Field = 2 }')
                  Arguments(0)
                  Initializer: 
                    IObjectOrCollectionInitializerOperation (OperationKind.ObjectOrCollectionInitializer, Type: F) (Syntax: '{ Field = 2 }')
                      Initializers(1):
                          ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'Field = 2')
                            Left: 
                              IFieldReferenceOperation: System.Int32 F.Field (OperationKind.FieldReference, Type: System.Int32) (Syntax: 'Field')
                                Instance Receiver: 
                                  IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: F, IsImplicit) (Syntax: 'Field')
                            Right: 
                              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
      Initializer: 
        null
  IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null) (Syntax: 'F x3 = new( ... ty1 = """" };')
    IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'F x3 = new( ... rty1 = """" }')
      Declarators:
          IVariableDeclaratorOperation (Symbol: F x3) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'x3 = new()  ... rty1 = """" }')
            Initializer: 
              IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= new() { P ... rty1 = """" }')
                IObjectCreationOperation (Constructor: F..ctor()) (OperationKind.ObjectCreation, Type: F) (Syntax: 'new() { Property1 = """" }')
                  Arguments(0)
                  Initializer: 
                    IObjectOrCollectionInitializerOperation (OperationKind.ObjectOrCollectionInitializer, Type: F) (Syntax: '{ Property1 = """" }')
                      Initializers(1):
                          ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.String) (Syntax: 'Property1 = """"')
                            Left: 
                              IPropertyReferenceOperation: System.String F.Property1 { get; set; } (OperationKind.PropertyReference, Type: System.String) (Syntax: 'Property1')
                                Instance Receiver: 
                                  IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: F, IsImplicit) (Syntax: 'Property1')
                            Right: 
                              ILiteralOperation (OperationKind.Literal, Type: System.String, Constant: """") (Syntax: '""""')
      Initializer: 
        null
  IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null) (Syntax: 'F x4 = new( ... ield = 2 };')
    IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'F x4 = new( ... Field = 2 }')
      Declarators:
          IVariableDeclaratorOperation (Symbol: F x4) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'x4 = new()  ... Field = 2 }')
            Initializer: 
              IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= new() { P ... Field = 2 }')
                IObjectCreationOperation (Constructor: F..ctor()) (OperationKind.ObjectCreation, Type: F) (Syntax: 'new() { Pro ... Field = 2 }')
                  Arguments(0)
                  Initializer: 
                    IObjectOrCollectionInitializerOperation (OperationKind.ObjectOrCollectionInitializer, Type: F) (Syntax: '{ Property1 ... Field = 2 }')
                      Initializers(2):
                          ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.String) (Syntax: 'Property1 = """"')
                            Left: 
                              IPropertyReferenceOperation: System.String F.Property1 { get; set; } (OperationKind.PropertyReference, Type: System.String) (Syntax: 'Property1')
                                Instance Receiver: 
                                  IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: F, IsImplicit) (Syntax: 'Property1')
                            Right: 
                              ILiteralOperation (OperationKind.Literal, Type: System.String, Constant: """") (Syntax: '""""')
                          ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'Field = 2')
                            Left: 
                              IFieldReferenceOperation: System.Int32 F.Field (OperationKind.FieldReference, Type: System.Int32) (Syntax: 'Field')
                                Instance Receiver: 
                                  IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: F, IsImplicit) (Syntax: 'Field')
                            Right: 
                              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
      Initializer: 
        null
  IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null) (Syntax: 'F x5 = new( ... = true } };')
    IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'F x5 = new( ...  = true } }')
      Declarators:
          IVariableDeclaratorOperation (Symbol: F x5) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'x5 = new()  ...  = true } }')
            Initializer: 
              IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= new() { P ...  = true } }')
                IObjectCreationOperation (Constructor: F..ctor()) (OperationKind.ObjectCreation, Type: F) (Syntax: 'new() { Pro ...  = true } }')
                  Arguments(0)
                  Initializer: 
                    IObjectOrCollectionInitializerOperation (OperationKind.ObjectOrCollectionInitializer, Type: F) (Syntax: '{ Property2 ...  = true } }')
                      Initializers(1):
                          ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: B) (Syntax: 'Property2 = ... ld = true }')
                            Left: 
                              IPropertyReferenceOperation: B F.Property2 { get; set; } (OperationKind.PropertyReference, Type: B) (Syntax: 'Property2')
                                Instance Receiver: 
                                  IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: F, IsImplicit) (Syntax: 'Property2')
                            Right: 
                              IObjectCreationOperation (Constructor: B..ctor()) (OperationKind.ObjectCreation, Type: B) (Syntax: 'new B { Field = true }')
                                Arguments(0)
                                Initializer: 
                                  IObjectOrCollectionInitializerOperation (OperationKind.ObjectOrCollectionInitializer, Type: B) (Syntax: '{ Field = true }')
                                    Initializers(1):
                                        ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'Field = true')
                                          Left: 
                                            IFieldReferenceOperation: System.Boolean B.Field (OperationKind.FieldReference, Type: System.Boolean) (Syntax: 'Field')
                                              Instance Receiver: 
                                                IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: B, IsImplicit) (Syntax: 'Field')
                                          Right: 
                                            ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')
      Initializer: 
        null
  IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsInvalid) (Syntax: 'F e1 = new( ... rty2 = 1 };')
    IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null, IsInvalid) (Syntax: 'F e1 = new( ... erty2 = 1 }')
      Declarators:
          IVariableDeclaratorOperation (Symbol: F e1) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'e1 = new()  ... erty2 = 1 }')
            Initializer: 
              IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '= new() { P ... erty2 = 1 }')
                IObjectCreationOperation (Constructor: F..ctor()) (OperationKind.ObjectCreation, Type: F, IsInvalid) (Syntax: 'new() { Property2 = 1 }')
                  Arguments(0)
                  Initializer: 
                    IObjectOrCollectionInitializerOperation (OperationKind.ObjectOrCollectionInitializer, Type: F, IsInvalid) (Syntax: '{ Property2 = 1 }')
                      Initializers(1):
                          ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: B, IsInvalid) (Syntax: 'Property2 = 1')
                            Left: 
                              IPropertyReferenceOperation: B F.Property2 { get; set; } (OperationKind.PropertyReference, Type: B) (Syntax: 'Property2')
                                Instance Receiver: 
                                  IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: F, IsImplicit) (Syntax: 'Property2')
                            Right: 
                              IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: B, IsInvalid, IsImplicit) (Syntax: '1')
                                Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                Operand: 
                                  ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1, IsInvalid) (Syntax: '1')
      Initializer: 
        null
  IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsInvalid) (Syntax: 'F e2 = new() { """" };')
    IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null, IsInvalid) (Syntax: 'F e2 = new() { """" }')
      Declarators:
          IVariableDeclaratorOperation (Symbol: F e2) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'e2 = new() { """" }')
            Initializer: 
              IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '= new() { """" }')
                IObjectCreationOperation (Constructor: F..ctor()) (OperationKind.ObjectCreation, Type: F, IsInvalid) (Syntax: 'new() { """" }')
                  Arguments(0)
                  Initializer: 
                    IObjectOrCollectionInitializerOperation (OperationKind.ObjectOrCollectionInitializer, Type: F, IsInvalid) (Syntax: '{ """" }')
                      Initializers(1):
                          IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid, IsImplicit) (Syntax: '""""')
                            Children(1):
                                ILiteralOperation (OperationKind.Literal, Type: System.String, Constant: """", IsInvalid) (Syntax: '""""')
      Initializer: 
        null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,27011,27696);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22056_27238_27330(f_22056_27238_27309(f_22056_27238_27283(ErrorCode.ERR_NoImplicitConv, "1"), "int", "B"), 21, 36),
f_22056_27568_27680(f_22056_27568_27659(f_22056_27568_27640(ErrorCode.ERR_CollectionInitRequiresIEnumerable, @"{ """" }"), "F"), 22, 22)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,27712,27816);

f_22056_27712_27815(comp, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,27830,41825);

f_22056_27830_41824(comp, @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}
.locals {R1}
{
    Locals: [F x1] [F x2] [F x3] [F x4] [F x5] [F e1] [F e2]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: F, IsImplicit) (Syntax: 'x1 = new()')
              Left: 
                ILocalReferenceOperation: x1 (IsDeclaration: True) (OperationKind.LocalReference, Type: F, IsImplicit) (Syntax: 'x1 = new()')
              Right: 
                IObjectCreationOperation (Constructor: F..ctor()) (OperationKind.ObjectCreation, Type: F) (Syntax: 'new()')
                  Arguments(0)
                  Initializer: 
                    null
        Next (Regular) Block[B2]
            Entering: {R2}
    .locals {R2}
    {
        CaptureIds: [0]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (3)
                IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new() { Field = 2 }')
                  Value: 
                    IObjectCreationOperation (Constructor: F..ctor()) (OperationKind.ObjectCreation, Type: F) (Syntax: 'new() { Field = 2 }')
                      Arguments(0)
                      Initializer: 
                        null
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'Field = 2')
                  Left: 
                    IFieldReferenceOperation: System.Int32 F.Field (OperationKind.FieldReference, Type: System.Int32) (Syntax: 'Field')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: F, IsImplicit) (Syntax: 'new() { Field = 2 }')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: F, IsImplicit) (Syntax: 'x2 = new() { Field = 2 }')
                  Left: 
                    ILocalReferenceOperation: x2 (IsDeclaration: True) (OperationKind.LocalReference, Type: F, IsImplicit) (Syntax: 'x2 = new() { Field = 2 }')
                  Right: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: F, IsImplicit) (Syntax: 'new() { Field = 2 }')
            Next (Regular) Block[B3]
                Leaving: {R2}
                Entering: {R3}
    }
    .locals {R3}
    {
        CaptureIds: [1]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (3)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new() { Property1 = """" }')
                  Value: 
                    IObjectCreationOperation (Constructor: F..ctor()) (OperationKind.ObjectCreation, Type: F) (Syntax: 'new() { Property1 = """" }')
                      Arguments(0)
                      Initializer: 
                        null
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.String) (Syntax: 'Property1 = """"')
                  Left: 
                    IPropertyReferenceOperation: System.String F.Property1 { get; set; } (OperationKind.PropertyReference, Type: System.String) (Syntax: 'Property1')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: F, IsImplicit) (Syntax: 'new() { Property1 = """" }')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.String, Constant: """") (Syntax: '""""')
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: F, IsImplicit) (Syntax: 'x3 = new()  ... rty1 = """" }')
                  Left: 
                    ILocalReferenceOperation: x3 (IsDeclaration: True) (OperationKind.LocalReference, Type: F, IsImplicit) (Syntax: 'x3 = new()  ... rty1 = """" }')
                  Right: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: F, IsImplicit) (Syntax: 'new() { Property1 = """" }')
            Next (Regular) Block[B4]
                Leaving: {R3}
                Entering: {R4}
    }
    .locals {R4}
    {
        CaptureIds: [2]
        Block[B4] - Block
            Predecessors: [B3]
            Statements (4)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new() { Pro ... Field = 2 }')
                  Value: 
                    IObjectCreationOperation (Constructor: F..ctor()) (OperationKind.ObjectCreation, Type: F) (Syntax: 'new() { Pro ... Field = 2 }')
                      Arguments(0)
                      Initializer: 
                        null
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.String) (Syntax: 'Property1 = """"')
                  Left: 
                    IPropertyReferenceOperation: System.String F.Property1 { get; set; } (OperationKind.PropertyReference, Type: System.String) (Syntax: 'Property1')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: F, IsImplicit) (Syntax: 'new() { Pro ... Field = 2 }')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.String, Constant: """") (Syntax: '""""')
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'Field = 2')
                  Left: 
                    IFieldReferenceOperation: System.Int32 F.Field (OperationKind.FieldReference, Type: System.Int32) (Syntax: 'Field')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: F, IsImplicit) (Syntax: 'new() { Pro ... Field = 2 }')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: F, IsImplicit) (Syntax: 'x4 = new()  ... Field = 2 }')
                  Left: 
                    ILocalReferenceOperation: x4 (IsDeclaration: True) (OperationKind.LocalReference, Type: F, IsImplicit) (Syntax: 'x4 = new()  ... Field = 2 }')
                  Right: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: F, IsImplicit) (Syntax: 'new() { Pro ... Field = 2 }')
            Next (Regular) Block[B5]
                Leaving: {R4}
                Entering: {R5}
    }
    .locals {R5}
    {
        CaptureIds: [3]
        Block[B5] - Block
            Predecessors: [B4]
            Statements (1)
                IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new() { Pro ...  = true } }')
                  Value: 
                    IObjectCreationOperation (Constructor: F..ctor()) (OperationKind.ObjectCreation, Type: F) (Syntax: 'new() { Pro ...  = true } }')
                      Arguments(0)
                      Initializer: 
                        null
            Next (Regular) Block[B6]
                Entering: {R6}
        .locals {R6}
        {
            CaptureIds: [4]
            Block[B6] - Block
                Predecessors: [B5]
                Statements (3)
                    IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new B { Field = true }')
                      Value: 
                        IObjectCreationOperation (Constructor: B..ctor()) (OperationKind.ObjectCreation, Type: B) (Syntax: 'new B { Field = true }')
                          Arguments(0)
                          Initializer: 
                            null
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'Field = true')
                      Left: 
                        IFieldReferenceOperation: System.Boolean B.Field (OperationKind.FieldReference, Type: System.Boolean) (Syntax: 'Field')
                          Instance Receiver: 
                            IFlowCaptureReferenceOperation: 4 (OperationKind.FlowCaptureReference, Type: B, IsImplicit) (Syntax: 'new B { Field = true }')
                      Right: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: B) (Syntax: 'Property2 = ... ld = true }')
                      Left: 
                        IPropertyReferenceOperation: B F.Property2 { get; set; } (OperationKind.PropertyReference, Type: B) (Syntax: 'Property2')
                          Instance Receiver: 
                            IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: F, IsImplicit) (Syntax: 'new() { Pro ...  = true } }')
                      Right: 
                        IFlowCaptureReferenceOperation: 4 (OperationKind.FlowCaptureReference, Type: B, IsImplicit) (Syntax: 'new B { Field = true }')
                Next (Regular) Block[B7]
                    Leaving: {R6}
        }
        Block[B7] - Block
            Predecessors: [B6]
            Statements (1)
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: F, IsImplicit) (Syntax: 'x5 = new()  ...  = true } }')
                  Left: 
                    ILocalReferenceOperation: x5 (IsDeclaration: True) (OperationKind.LocalReference, Type: F, IsImplicit) (Syntax: 'x5 = new()  ...  = true } }')
                  Right: 
                    IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: F, IsImplicit) (Syntax: 'new() { Pro ...  = true } }')
            Next (Regular) Block[B8]
                Leaving: {R5}
                Entering: {R7}
    }
    .locals {R7}
    {
        CaptureIds: [5]
        Block[B8] - Block
            Predecessors: [B7]
            Statements (3)
                IFlowCaptureOperation: 5 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'new() { Property2 = 1 }')
                  Value: 
                    IObjectCreationOperation (Constructor: F..ctor()) (OperationKind.ObjectCreation, Type: F, IsInvalid) (Syntax: 'new() { Property2 = 1 }')
                      Arguments(0)
                      Initializer: 
                        null
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: B, IsInvalid) (Syntax: 'Property2 = 1')
                  Left: 
                    IPropertyReferenceOperation: B F.Property2 { get; set; } (OperationKind.PropertyReference, Type: B) (Syntax: 'Property2')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 5 (OperationKind.FlowCaptureReference, Type: F, IsInvalid, IsImplicit) (Syntax: 'new() { Property2 = 1 }')
                  Right: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: B, IsInvalid, IsImplicit) (Syntax: '1')
                      Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (NoConversion)
                      Operand: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1, IsInvalid) (Syntax: '1')
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: F, IsInvalid, IsImplicit) (Syntax: 'e1 = new()  ... erty2 = 1 }')
                  Left: 
                    ILocalReferenceOperation: e1 (IsDeclaration: True) (OperationKind.LocalReference, Type: F, IsInvalid, IsImplicit) (Syntax: 'e1 = new()  ... erty2 = 1 }')
                  Right: 
                    IFlowCaptureReferenceOperation: 5 (OperationKind.FlowCaptureReference, Type: F, IsInvalid, IsImplicit) (Syntax: 'new() { Property2 = 1 }')
            Next (Regular) Block[B9]
                Leaving: {R7}
                Entering: {R8}
    }
    .locals {R8}
    {
        CaptureIds: [6]
        Block[B9] - Block
            Predecessors: [B8]
            Statements (3)
                IFlowCaptureOperation: 6 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'new() { """" }')
                  Value: 
                    IObjectCreationOperation (Constructor: F..ctor()) (OperationKind.ObjectCreation, Type: F, IsInvalid) (Syntax: 'new() { """" }')
                      Arguments(0)
                      Initializer: 
                        null
                IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid, IsImplicit) (Syntax: '""""')
                  Children(1):
                      ILiteralOperation (OperationKind.Literal, Type: System.String, Constant: """", IsInvalid) (Syntax: '""""')
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: F, IsInvalid, IsImplicit) (Syntax: 'e2 = new() { """" }')
                  Left: 
                    ILocalReferenceOperation: e2 (IsDeclaration: True) (OperationKind.LocalReference, Type: F, IsInvalid, IsImplicit) (Syntax: 'e2 = new() { """" }')
                  Right: 
                    IFlowCaptureReferenceOperation: 6 (OperationKind.FlowCaptureReference, Type: F, IsInvalid, IsImplicit) (Syntax: 'new() { """" }')
            Next (Regular) Block[B10]
                Leaving: {R8} {R1}
    }
}
Block[B10] - Exit
    Predecessors: [B9]
    Statements (0)
");
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,12737,41836);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,12737,41836);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,12737,41836);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ImplicitObjectCreationWithCollectionInitializer()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,41848,46695);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,42003,42237);

string 
source = @"
using System.Collections.Generic;
class C
{
    private readonly int field;
    public void M1(int x)
    {
        int y = 0;
        List<int> x1 = /*<bind>*/new() { x, y, field }/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,42251,46097);

string 
expectedOperationTree = @"
IObjectCreationOperation (Constructor: System.Collections.Generic.List<System.Int32>..ctor()) (OperationKind.ObjectCreation, Type: System.Collections.Generic.List<System.Int32>) (Syntax: 'new() { x, y, field }')
  Arguments(0)
  Initializer: 
    IObjectOrCollectionInitializerOperation (OperationKind.ObjectOrCollectionInitializer, Type: System.Collections.Generic.List<System.Int32>) (Syntax: '{ x, y, field }')
      Initializers(3):
          IInvocationOperation ( void System.Collections.Generic.List<System.Int32>.Add(System.Int32 item)) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'x')
            Instance Receiver: 
              IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: System.Collections.Generic.List<System.Int32>, IsImplicit) (Syntax: 'new() { x, y, field }')
            Arguments(1):
                IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: item) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'x')
                  IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'x')
                  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
          IInvocationOperation ( void System.Collections.Generic.List<System.Int32>.Add(System.Int32 item)) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'y')
            Instance Receiver: 
              IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: System.Collections.Generic.List<System.Int32>, IsImplicit) (Syntax: 'new() { x, y, field }')
            Arguments(1):
                IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: item) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'y')
                  ILocalReferenceOperation: y (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'y')
                  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
          IInvocationOperation ( void System.Collections.Generic.List<System.Int32>.Add(System.Int32 item)) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'field')
            Instance Receiver: 
              IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: System.Collections.Generic.List<System.Int32>, IsImplicit) (Syntax: 'new() { x, y, field }')
            Arguments(1):
                IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: item) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'field')
                  IFieldReferenceOperation: System.Int32 C.field (OperationKind.FieldReference, Type: System.Int32) (Syntax: 'field')
                    Instance Receiver: 
                      IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C, IsImplicit) (Syntax: 'field')
                  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,46111,46490);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22056_46366_46474(f_22056_46366_46454(f_22056_46366_46424(ErrorCode.WRN_UnassignedInternalField, "field"), "C.field", "0"), 5, 26)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,46506,46684);

f_22056_46506_46683(source, expectedOperationTree, expectedDiagnostics, parseOptions: ImplicitObjectCreationOptions);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,41848,46695);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,41848,46695);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,41848,46695);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ImplicitObjectCreationWithNestedCollectionInitializer()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,46707,63792);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,46868,47210);

var 
comp = f_22056_46879_47209(@"
using System.Collections.Generic;
using System.Linq;
class C
{
    private readonly int field = 0;
    public void M1(int x)
    {
        int y = 0;
        List<List<int>> x1 = /*<bind>*/new() {
            new[] { x, y }.ToList(),
            new() { field }
        }/*</bind>*/;
    }
}
")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,47224,54075);

string 
expectedOperationTree = @"
IObjectCreationOperation (Constructor: System.Collections.Generic.List<System.Collections.Generic.List<System.Int32>>..ctor()) (OperationKind.ObjectCreation, Type: System.Collections.Generic.List<System.Collections.Generic.List<System.Int32>>) (Syntax: 'new() { ... }')
  Arguments(0)
  Initializer: 
    IObjectOrCollectionInitializerOperation (OperationKind.ObjectOrCollectionInitializer, Type: System.Collections.Generic.List<System.Collections.Generic.List<System.Int32>>) (Syntax: '{ ... }')
      Initializers(2):
          IInvocationOperation ( void System.Collections.Generic.List<System.Collections.Generic.List<System.Int32>>.Add(System.Collections.Generic.List<System.Int32> item)) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'new[] { x, y }.ToList()')
            Instance Receiver: 
              IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: System.Collections.Generic.List<System.Collections.Generic.List<System.Int32>>, IsImplicit) (Syntax: 'new() { ... }')
            Arguments(1):
                IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: item) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'new[] { x, y }.ToList()')
                  IInvocationOperation (System.Collections.Generic.List<System.Int32> System.Linq.Enumerable.ToList<System.Int32>(this System.Collections.Generic.IEnumerable<System.Int32> source)) (OperationKind.Invocation, Type: System.Collections.Generic.List<System.Int32>) (Syntax: 'new[] { x, y }.ToList()')
                    Instance Receiver: 
                      null
                    Arguments(1):
                        IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: source) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'new[] { x, y }')
                          IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Collections.Generic.IEnumerable<System.Int32>, IsImplicit) (Syntax: 'new[] { x, y }')
                            Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                            Operand: 
                              IArrayCreationOperation (OperationKind.ArrayCreation, Type: System.Int32[]) (Syntax: 'new[] { x, y }')
                                Dimension Sizes(1):
                                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2, IsImplicit) (Syntax: 'new[] { x, y }')
                                Initializer: 
                                  IArrayInitializerOperation (2 elements) (OperationKind.ArrayInitializer, Type: null) (Syntax: '{ x, y }')
                                    Element Values(2):
                                        IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'x')
                                        ILocalReferenceOperation: y (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'y')
                          InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                          OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
          IInvocationOperation ( void System.Collections.Generic.List<System.Collections.Generic.List<System.Int32>>.Add(System.Collections.Generic.List<System.Int32> item)) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'new() { field }')
            Instance Receiver: 
              IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: System.Collections.Generic.List<System.Collections.Generic.List<System.Int32>>, IsImplicit) (Syntax: 'new() { ... }')
            Arguments(1):
                IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: item) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'new() { field }')
                  IObjectCreationOperation (Constructor: System.Collections.Generic.List<System.Int32>..ctor()) (OperationKind.ObjectCreation, Type: System.Collections.Generic.List<System.Int32>) (Syntax: 'new() { field }')
                    Arguments(0)
                    Initializer: 
                      IObjectOrCollectionInitializerOperation (OperationKind.ObjectOrCollectionInitializer, Type: System.Collections.Generic.List<System.Int32>) (Syntax: '{ field }')
                        Initializers(1):
                            IInvocationOperation ( void System.Collections.Generic.List<System.Int32>.Add(System.Int32 item)) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'field')
                              Instance Receiver: 
                                IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: System.Collections.Generic.List<System.Int32>, IsImplicit) (Syntax: 'new() { field }')
                              Arguments(1):
                                  IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: item) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'field')
                                    IFieldReferenceOperation: System.Int32 C.field (OperationKind.FieldReference, Type: System.Int32) (Syntax: 'field')
                                      Instance Receiver: 
                                        IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C, IsImplicit) (Syntax: 'field')
                                    InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                    OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,54089,54142);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,54158,54289);

f_22056_54158_54288(comp, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,54305,54405);

var 
m1 = f_22056_54314_54404(f_22056_54314_54395(f_22056_54314_54361(f_22056_54314_54343(f_22056_54314_54330(comp)[0]))))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,54419,63781);

f_22056_54419_63780(comp, m1, @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [System.Int32 y] [System.Collections.Generic.List<System.Collections.Generic.List<System.Int32>> x1]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: 'y = 0')
              Left: 
                ILocalReferenceOperation: y (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsImplicit) (Syntax: 'y = 0')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [0]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (2)
                IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new() { ... }')
                  Value: 
                    IObjectCreationOperation (Constructor: System.Collections.Generic.List<System.Collections.Generic.List<System.Int32>>..ctor()) (OperationKind.ObjectCreation, Type: System.Collections.Generic.List<System.Collections.Generic.List<System.Int32>>) (Syntax: 'new() { ... }')
                      Arguments(0)
                      Initializer: 
                        null

                IInvocationOperation ( void System.Collections.Generic.List<System.Collections.Generic.List<System.Int32>>.Add(System.Collections.Generic.List<System.Int32> item)) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'new[] { x, y }.ToList()')
                  Instance Receiver: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Collections.Generic.List<System.Collections.Generic.List<System.Int32>>, IsImplicit) (Syntax: 'new() { ... }')
                  Arguments(1):
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: item) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'new[] { x, y }.ToList()')
                        IInvocationOperation (System.Collections.Generic.List<System.Int32> System.Linq.Enumerable.ToList<System.Int32>(this System.Collections.Generic.IEnumerable<System.Int32> source)) (OperationKind.Invocation, Type: System.Collections.Generic.List<System.Int32>) (Syntax: 'new[] { x, y }.ToList()')
                          Instance Receiver: 
                            null
                          Arguments(1):
                              IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: source) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'new[] { x, y }')
                                IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Collections.Generic.IEnumerable<System.Int32>, IsImplicit) (Syntax: 'new[] { x, y }')
                                  Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                                    (ImplicitReference)
                                  Operand: 
                                    IArrayCreationOperation (OperationKind.ArrayCreation, Type: System.Int32[]) (Syntax: 'new[] { x, y }')
                                      Dimension Sizes(1):
                                          ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2, IsImplicit) (Syntax: 'new[] { x, y }')
                                      Initializer: 
                                        IArrayInitializerOperation (2 elements) (OperationKind.ArrayInitializer, Type: null) (Syntax: '{ x, y }')
                                          Element Values(2):
                                              IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'x')
                                              ILocalReferenceOperation: y (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'y')
                                InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

            Next (Regular) Block[B3]
                Entering: {R3}

        .locals {R3}
        {
            CaptureIds: [1]
            Block[B3] - Block
                Predecessors: [B2]
                Statements (3)
                    IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new() { field }')
                      Value: 
                        IObjectCreationOperation (Constructor: System.Collections.Generic.List<System.Int32>..ctor()) (OperationKind.ObjectCreation, Type: System.Collections.Generic.List<System.Int32>) (Syntax: 'new() { field }')
                          Arguments(0)
                          Initializer: 
                            null

                    IInvocationOperation ( void System.Collections.Generic.List<System.Int32>.Add(System.Int32 item)) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'field')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Collections.Generic.List<System.Int32>, IsImplicit) (Syntax: 'new() { field }')
                      Arguments(1):
                          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: item) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'field')
                            IFieldReferenceOperation: System.Int32 C.field (OperationKind.FieldReference, Type: System.Int32) (Syntax: 'field')
                              Instance Receiver: 
                                IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C, IsImplicit) (Syntax: 'field')
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

                    IInvocationOperation ( void System.Collections.Generic.List<System.Collections.Generic.List<System.Int32>>.Add(System.Collections.Generic.List<System.Int32> item)) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'new() { field }')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Collections.Generic.List<System.Collections.Generic.List<System.Int32>>, IsImplicit) (Syntax: 'new() { ... }')
                      Arguments(1):
                          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: item) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'new() { field }')
                            IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Collections.Generic.List<System.Int32>, IsImplicit) (Syntax: 'new() { field }')
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

                Next (Regular) Block[B4]
                    Leaving: {R3}
        }

        Block[B4] - Block
            Predecessors: [B3]
            Statements (1)
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Collections.Generic.List<System.Collections.Generic.List<System.Int32>>, IsImplicit) (Syntax: 'x1 = /*<bin ... }')
                  Left: 
                    ILocalReferenceOperation: x1 (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Collections.Generic.List<System.Collections.Generic.List<System.Int32>>, IsImplicit) (Syntax: 'x1 = /*<bin ... }')
                  Right: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Collections.Generic.List<System.Collections.Generic.List<System.Int32>>, IsImplicit) (Syntax: 'new() { ... }')

            Next (Regular) Block[B5]
                Leaving: {R2} {R1}
    }
}

Block[B5] - Exit
    Predecessors: [B4]
    Statements (0)
");
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,46707,63792);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,46707,63792);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,46707,63792);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ImplicitObjectCreationWithMemberAndCollectionInitializers()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,63804,74155);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,63969,64476);

string 
source = @"
using System.Collections.Generic;
internal class Class
{
    public int X { get; set; }
    public List<int> Y { get; set; }
    public Dictionary<int, int> Z { get; set; }
    public Class C { get; set; }
    private readonly int field = 0;
    public void M(int x)
    {
        int y = 0;
        Class c = /*<bind>*/new() {
            X = x,
            Y = { x, y, 3 },
            Z = { { x, y } },
            C = { X = field }
        }/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,64490,73883);

string 
expectedOperationTree = @"
IObjectCreationOperation (Constructor: Class..ctor()) (OperationKind.ObjectCreation, Type: Class) (Syntax: 'new() { ... }')
  Arguments(0)
  Initializer: 
    IObjectOrCollectionInitializerOperation (OperationKind.ObjectOrCollectionInitializer, Type: Class) (Syntax: '{ ... }')
      Initializers(4):
          ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'X = x')
            Left: 
              IPropertyReferenceOperation: System.Int32 Class.X { get; set; } (OperationKind.PropertyReference, Type: System.Int32) (Syntax: 'X')
                Instance Receiver: 
                  IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: Class, IsImplicit) (Syntax: 'X')
            Right: 
              IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'x')
          IMemberInitializerOperation (OperationKind.MemberInitializer, Type: System.Collections.Generic.List<System.Int32>) (Syntax: 'Y = { x, y, 3 }')
            InitializedMember: 
              IPropertyReferenceOperation: System.Collections.Generic.List<System.Int32> Class.Y { get; set; } (OperationKind.PropertyReference, Type: System.Collections.Generic.List<System.Int32>) (Syntax: 'Y')
                Instance Receiver: 
                  IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: Class, IsImplicit) (Syntax: 'Y')
            Initializer: 
              IObjectOrCollectionInitializerOperation (OperationKind.ObjectOrCollectionInitializer, Type: System.Collections.Generic.List<System.Int32>) (Syntax: '{ x, y, 3 }')
                Initializers(3):
                    IInvocationOperation ( void System.Collections.Generic.List<System.Int32>.Add(System.Int32 item)) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'x')
                      Instance Receiver: 
                        IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: System.Collections.Generic.List<System.Int32>, IsImplicit) (Syntax: 'Y')
                      Arguments(1):
                          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: item) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'x')
                            IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'x')
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    IInvocationOperation ( void System.Collections.Generic.List<System.Int32>.Add(System.Int32 item)) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'y')
                      Instance Receiver: 
                        IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: System.Collections.Generic.List<System.Int32>, IsImplicit) (Syntax: 'Y')
                      Arguments(1):
                          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: item) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'y')
                            ILocalReferenceOperation: y (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'y')
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    IInvocationOperation ( void System.Collections.Generic.List<System.Int32>.Add(System.Int32 item)) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: '3')
                      Instance Receiver: 
                        IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: System.Collections.Generic.List<System.Int32>, IsImplicit) (Syntax: 'Y')
                      Arguments(1):
                          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: item) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: '3')
                            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
          IMemberInitializerOperation (OperationKind.MemberInitializer, Type: System.Collections.Generic.Dictionary<System.Int32, System.Int32>) (Syntax: 'Z = { { x, y } }')
            InitializedMember: 
              IPropertyReferenceOperation: System.Collections.Generic.Dictionary<System.Int32, System.Int32> Class.Z { get; set; } (OperationKind.PropertyReference, Type: System.Collections.Generic.Dictionary<System.Int32, System.Int32>) (Syntax: 'Z')
                Instance Receiver: 
                  IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: Class, IsImplicit) (Syntax: 'Z')
            Initializer: 
              IObjectOrCollectionInitializerOperation (OperationKind.ObjectOrCollectionInitializer, Type: System.Collections.Generic.Dictionary<System.Int32, System.Int32>) (Syntax: '{ { x, y } }')
                Initializers(1):
                    IInvocationOperation ( void System.Collections.Generic.Dictionary<System.Int32, System.Int32>.Add(System.Int32 key, System.Int32 value)) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: '{ x, y }')
                      Instance Receiver: 
                        IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: System.Collections.Generic.Dictionary<System.Int32, System.Int32>, IsImplicit) (Syntax: 'Z')
                      Arguments(2):
                          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: key) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'x')
                            IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'x')
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: value) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'y')
                            ILocalReferenceOperation: y (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'y')
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
          IMemberInitializerOperation (OperationKind.MemberInitializer, Type: Class) (Syntax: 'C = { X = field }')
            InitializedMember: 
              IPropertyReferenceOperation: Class Class.C { get; set; } (OperationKind.PropertyReference, Type: Class) (Syntax: 'C')
                Instance Receiver: 
                  IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: Class, IsImplicit) (Syntax: 'C')
            Initializer: 
              IObjectOrCollectionInitializerOperation (OperationKind.ObjectOrCollectionInitializer, Type: Class) (Syntax: '{ X = field }')
                Initializers(1):
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'X = field')
                      Left: 
                        IPropertyReferenceOperation: System.Int32 Class.X { get; set; } (OperationKind.PropertyReference, Type: System.Int32) (Syntax: 'X')
                          Instance Receiver: 
                            IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: Class, IsImplicit) (Syntax: 'X')
                      Right: 
                        IFieldReferenceOperation: System.Int32 Class.field (OperationKind.FieldReference, Type: System.Int32) (Syntax: 'field')
                          Instance Receiver: 
                            IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: Class, IsImplicit) (Syntax: 'field')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,73897,73950);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,73966,74144);

f_22056_73966_74143(source, expectedOperationTree, expectedDiagnostics, parseOptions: ImplicitObjectCreationOptions);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,63804,74155);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,63804,74155);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,63804,74155);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ImplicitObjectCreationWithArrayInitializer()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,74167,82140);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,74317,74492);

var 
comp = f_22056_74328_74491(@"
class C
{
    int[] a;
    static void Main()
    {
        C a = /*<bind>*/new() { a = { [0] = 1, [1] = 2 } }/*</bind>*/;
    }
}
")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,74506,77175);

string 
expectedOperationTree = @"
IObjectCreationOperation (Constructor: C..ctor()) (OperationKind.ObjectCreation, Type: C) (Syntax: 'new() { a = ... [1] = 2 } }')
  Arguments(0)
  Initializer: 
    IObjectOrCollectionInitializerOperation (OperationKind.ObjectOrCollectionInitializer, Type: C) (Syntax: '{ a = { [0] ... [1] = 2 } }')
      Initializers(1):
          IMemberInitializerOperation (OperationKind.MemberInitializer, Type: System.Int32[]) (Syntax: 'a = { [0] = 1, [1] = 2 }')
            InitializedMember: 
              IFieldReferenceOperation: System.Int32[] C.a (OperationKind.FieldReference, Type: System.Int32[]) (Syntax: 'a')
                Instance Receiver: 
                  IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: C, IsImplicit) (Syntax: 'a')
            Initializer: 
              IObjectOrCollectionInitializerOperation (OperationKind.ObjectOrCollectionInitializer, Type: System.Int32[]) (Syntax: '{ [0] = 1, [1] = 2 }')
                Initializers(2):
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: '[0] = 1')
                      Left: 
                        IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: System.Int32) (Syntax: '[0]')
                          Array reference: 
                            IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: System.Int32[], IsImplicit) (Syntax: 'a')
                          Indices(1):
                              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
                      Right: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: '[1] = 2')
                      Left: 
                        IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: System.Int32) (Syntax: '[1]')
                          Array reference: 
                            IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: System.Int32[], IsImplicit) (Syntax: 'a')
                          Indices(1):
                              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
                      Right: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,77189,77509);

var 
expectedDiagnostics = new DiagnosticDescription[]
            {
f_22056_77400_77493(f_22056_77400_77473(f_22056_77400_77452(ErrorCode.WRN_UnreferencedFieldAssg, "a"), "C.a"), 4, 11)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,77525,77656);

f_22056_77525_77655(comp, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,77672,77774);

var 
main = f_22056_77683_77773(f_22056_77683_77764(f_22056_77683_77730(f_22056_77683_77712(f_22056_77683_77699(comp)[0]))))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,77790,82129);

f_22056_77790_82128(comp, main, @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [C a]
    CaptureIds: [0]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new() { a = ... [1] = 2 } }')
              Value: 
                IObjectCreationOperation (Constructor: C..ctor()) (OperationKind.ObjectCreation, Type: C) (Syntax: 'new() { a = ... [1] = 2 } }')
                  Arguments(0)
                  Initializer: 
                    null

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (2)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '0')
                  Value: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')

                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: '[0] = 1')
                  Left: 
                    IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: System.Int32) (Syntax: '[0]')
                      Array reference: 
                        IFieldReferenceOperation: System.Int32[] C.a (OperationKind.FieldReference, Type: System.Int32[]) (Syntax: 'a')
                          Instance Receiver: 
                            IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'new() { a = ... [1] = 2 } }')
                      Indices(1):
                          IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32, Constant: 0, IsImplicit) (Syntax: '0')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

            Next (Regular) Block[B3]
                Leaving: {R2}
                Entering: {R3}
    }
    .locals {R3}
    {
        CaptureIds: [2]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (2)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '1')
                  Value: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: '[1] = 2')
                  Left: 
                    IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: System.Int32) (Syntax: '[1]')
                      Array reference: 
                        IFieldReferenceOperation: System.Int32[] C.a (OperationKind.FieldReference, Type: System.Int32[]) (Syntax: 'a')
                          Instance Receiver: 
                            IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'new() { a = ... [1] = 2 } }')
                      Indices(1):
                          IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, Constant: 1, IsImplicit) (Syntax: '1')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')

            Next (Regular) Block[B4]
                Leaving: {R3}
    }

    Block[B4] - Block
        Predecessors: [B3]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: C, IsImplicit) (Syntax: 'a = /*<bind ... [1] = 2 } }')
              Left: 
                ILocalReferenceOperation: a (IsDeclaration: True) (OperationKind.LocalReference, Type: C, IsImplicit) (Syntax: 'a = /*<bind ... [1] = 2 } }')
              Right: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'new() { a = ... [1] = 2 } }')

        Next (Regular) Block[B5]
            Leaving: {R1}
}

Block[B5] - Exit
    Predecessors: [B4]
    Statements (0)
");
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,74167,82140);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,74167,82140);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,74167,82140);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ImplicitObjectCreationWithInvalidInitializer()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,82152,84191);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,82304,82443);

string 
source = @"
class C
{
    public void M1()
    {
        C x1 = /*<bind>*/new() { MissingMember = 1 }/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,82457,83584);

string 
expectedOperationTree = @"
IObjectCreationOperation (Constructor: C..ctor()) (OperationKind.ObjectCreation, Type: C, IsInvalid) (Syntax: 'new() { Mis ... ember = 1 }')
  Arguments(0)
  Initializer: 
    IObjectOrCollectionInitializerOperation (OperationKind.ObjectOrCollectionInitializer, Type: C, IsInvalid) (Syntax: '{ MissingMember = 1 }')
      Initializers(1):
          ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: ?, IsInvalid) (Syntax: 'MissingMember = 1')
            Left: 
              IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid, IsImplicit) (Syntax: 'MissingMember')
                Children(1):
                    IOperation:  (OperationKind.None, Type: null, IsInvalid) (Syntax: 'MissingMember')
                      Children(1):
                          IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: C, IsInvalid, IsImplicit) (Syntax: 'new() { Mis ... ember = 1 }')
            Right: 
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,83598,83986);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22056_83859_83970(f_22056_83859_83950(f_22056_83859_83914(ErrorCode.ERR_NoSuchMember, "MissingMember"), "C", "MissingMember"), 6, 34)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,84002,84180);

f_22056_84002_84179(source, expectedOperationTree, expectedDiagnostics, parseOptions: ImplicitObjectCreationOptions);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,82152,84191);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,82152,84191);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,82152,84191);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ImplicitObjectCreationWithInvalidMemberInitializer()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,84203,87103);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,84361,84506);

string 
source = @"
class C
{
    public void M1()
    {
        C x1 = /*<bind>*/new(){ MissingField = { x = 1 } }/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,84520,86493);

string 
expectedOperationTree = @"
IObjectCreationOperation (Constructor: C..ctor()) (OperationKind.ObjectCreation, Type: C, IsInvalid) (Syntax: 'new(){ Miss ... { x = 1 } }')
  Arguments(0)
  Initializer: 
    IObjectOrCollectionInitializerOperation (OperationKind.ObjectOrCollectionInitializer, Type: C, IsInvalid) (Syntax: '{ MissingFi ... { x = 1 } }')
      Initializers(1):
          IMemberInitializerOperation (OperationKind.MemberInitializer, Type: ?, IsInvalid) (Syntax: 'MissingField = { x = 1 }')
            InitializedMember: 
              IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid, IsImplicit) (Syntax: 'MissingField')
                Children(1):
                    IOperation:  (OperationKind.None, Type: null, IsInvalid) (Syntax: 'MissingField')
                      Children(1):
                          IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: C, IsInvalid, IsImplicit) (Syntax: 'new(){ Miss ... { x = 1 } }')
            Initializer: 
              IObjectOrCollectionInitializerOperation (OperationKind.ObjectOrCollectionInitializer, Type: ?) (Syntax: '{ x = 1 }')
                Initializers(1):
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: ?) (Syntax: 'x = 1')
                      Left: 
                        IInvalidOperation (OperationKind.Invalid, Type: ?, IsImplicit) (Syntax: 'x')
                          Children(1):
                              IOperation:  (OperationKind.None, Type: null) (Syntax: 'x')
                                Children(1):
                                    IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: ?, IsInvalid, IsImplicit) (Syntax: 'MissingField')
                      Right: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,86507,86898);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22056_86773_86882(f_22056_86773_86862(f_22056_86773_86827(ErrorCode.ERR_NoSuchMember, "MissingField"), "C", "MissingField"), 6, 33)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,86914,87092);

f_22056_86914_87091(source, expectedOperationTree, expectedDiagnostics, parseOptions: ImplicitObjectCreationOptions);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,84203,87103);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,84203,87103);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,84203,87103);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ImplicitObjectCreationWithInvalidCollectionInitializer()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,87115,95292);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,87277,87482);

var 
comp = f_22056_87288_87481(@"
using System.Collections.Generic;
class C
{
    public void M1()
    {
        C x1 = /*<bind>*/new(){ MissingField = new List<int>() { 1 }}/*</bind>*/;
    }
}
")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,87496,90172);

string 
expectedOperationTree = @"
IObjectCreationOperation (Constructor: C..ctor()) (OperationKind.ObjectCreation, Type: C, IsInvalid) (Syntax: 'new(){ Miss ... t>() { 1 }}')
  Arguments(0)
  Initializer: 
    IObjectOrCollectionInitializerOperation (OperationKind.ObjectOrCollectionInitializer, Type: C, IsInvalid) (Syntax: '{ MissingFi ... t>() { 1 }}')
      Initializers(1):
          ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: ?, IsInvalid) (Syntax: 'MissingFiel ... nt>() { 1 }')
            Left: 
              IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid, IsImplicit) (Syntax: 'MissingField')
                Children(1):
                    IOperation:  (OperationKind.None, Type: null, IsInvalid) (Syntax: 'MissingField')
                      Children(1):
                          IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: C, IsInvalid, IsImplicit) (Syntax: 'new(){ Miss ... t>() { 1 }}')
            Right: 
              IObjectCreationOperation (Constructor: System.Collections.Generic.List<System.Int32>..ctor()) (OperationKind.ObjectCreation, Type: System.Collections.Generic.List<System.Int32>) (Syntax: 'new List<int>() { 1 }')
                Arguments(0)
                Initializer: 
                  IObjectOrCollectionInitializerOperation (OperationKind.ObjectOrCollectionInitializer, Type: System.Collections.Generic.List<System.Int32>) (Syntax: '{ 1 }')
                    Initializers(1):
                        IInvocationOperation ( void System.Collections.Generic.List<System.Int32>.Add(System.Int32 item)) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: '1')
                          Instance Receiver: 
                            IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: System.Collections.Generic.List<System.Int32>, IsImplicit) (Syntax: 'List<int>')
                          Arguments(1):
                              IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: item) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: '1')
                                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
                                InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,90186,90588);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22056_90463_90572(f_22056_90463_90552(f_22056_90463_90517(ErrorCode.ERR_NoSuchMember, "MissingField"), "C", "MissingField"), 7, 33)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,90604,90735);

f_22056_90604_90734(comp, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,90751,90851);

var 
m1 = f_22056_90760_90850(f_22056_90760_90841(f_22056_90760_90807(f_22056_90760_90789(f_22056_90760_90776(comp)[0]))))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,90867,95281);

f_22056_90867_95280(comp, m1, @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [C x1]
    CaptureIds: [0]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'new(){ Miss ... t>() { 1 }}')
              Value: 
                IObjectCreationOperation (Constructor: C..ctor()) (OperationKind.ObjectCreation, Type: C, IsInvalid) (Syntax: 'new(){ Miss ... t>() { 1 }}')
                  Arguments(0)
                  Initializer: 
                    null

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1] [2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (4)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'MissingField')
                  Value: 
                    IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid, IsImplicit) (Syntax: 'MissingField')
                      Children(1):
                          IOperation:  (OperationKind.None, Type: null, IsInvalid) (Syntax: 'MissingField')
                            Children(1):
                                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C, IsInvalid, IsImplicit) (Syntax: 'new(){ Miss ... t>() { 1 }}')

                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new List<int>() { 1 }')
                  Value: 
                    IObjectCreationOperation (Constructor: System.Collections.Generic.List<System.Int32>..ctor()) (OperationKind.ObjectCreation, Type: System.Collections.Generic.List<System.Int32>) (Syntax: 'new List<int>() { 1 }')
                      Arguments(0)
                      Initializer: 
                        null

                IInvocationOperation ( void System.Collections.Generic.List<System.Int32>.Add(System.Int32 item)) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: '1')
                  Instance Receiver: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Collections.Generic.List<System.Int32>, IsImplicit) (Syntax: 'new List<int>() { 1 }')
                  Arguments(1):
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: item) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: '1')
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: ?, IsInvalid) (Syntax: 'MissingFiel ... nt>() { 1 }')
                  Left: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: ?, IsInvalid, IsImplicit) (Syntax: 'MissingField')
                  Right: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Collections.Generic.List<System.Int32>, IsImplicit) (Syntax: 'new List<int>() { 1 }')

            Next (Regular) Block[B3]
                Leaving: {R2}
    }

    Block[B3] - Block
        Predecessors: [B2]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: C, IsInvalid, IsImplicit) (Syntax: 'x1 = /*<bin ... t>() { 1 }}')
              Left: 
                ILocalReferenceOperation: x1 (IsDeclaration: True) (OperationKind.LocalReference, Type: C, IsInvalid, IsImplicit) (Syntax: 'x1 = /*<bin ... t>() { 1 }}')
              Right: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C, IsInvalid, IsImplicit) (Syntax: 'new(){ Miss ... t>() { 1 }}')

        Next (Regular) Block[B4]
            Leaving: {R1}
}

Block[B4] - Exit
    Predecessors: [B3]
    Statements (0)
");
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,87115,95292);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,87115,95292);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,87115,95292);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(1198816, "https://devdiv.visualstudio.com/DevDiv/_workitems/edit/1198816/")]
        public void ImplicitObjectCreationUnconverted_ArrayIndex()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,95304,96333);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,95542,95618);

var 
comp = f_22056_95553_95617("_ = new int[/*<bind>*/new(bad)/*</bind>*/];")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,95634,95973);

var 
expectedDiagnostics = new DiagnosticDescription[] { 
f_22056_95867_95957(f_22056_95867_95937(f_22056_95867_95916(ErrorCode.ERR_NameNotInContext, "bad"), "bad"), 1, 27)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,95989,96322);

f_22056_95989_96321(comp, @"
IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid) (Syntax: 'new(bad)')
  Children(1):
      IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid) (Syntax: 'bad')
        Children(0)
            ", expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,95304,96333);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,95304,96333);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,95304,96333);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(1198816, "https://devdiv.visualstudio.com/DevDiv/_workitems/edit/1198816/")]
        public void ImplicitObjectCreationUnconverted_IfCondition()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,96345,97406);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,96584,96698);

var 
comp = f_22056_96595_96697(@"
if (/*<bind>*/new(bad)/*</bind>*/) {}
", options: TestOptions.UnsafeReleaseExe)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,96714,97046);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22056_96940_97030(f_22056_96940_97010(f_22056_96940_96989(ErrorCode.ERR_NameNotInContext, "bad"), "bad"), 2, 19)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,97062,97395);

f_22056_97062_97394(comp, @"
IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid) (Syntax: 'new(bad)')
  Children(1):
      IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid) (Syntax: 'bad')
        Children(0)
            ", expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,96345,97406);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,96345,97406);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,96345,97406);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(1198816, "https://devdiv.visualstudio.com/DevDiv/_workitems/edit/1198816/")]
        public void ImplicitObjectCreationUnconverted_ConditionalOperator()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,97418,98592);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,97665,97806);

var 
source =
@"class Program
{
    static void Main()
    {
        _ = /*<bind>*/new(bad)/*</bind>*/ ? null : new object();
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,97820,97857);

var 
comp = f_22056_97831_97856(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,97873,98232);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22056_98126_98216(f_22056_98126_98196(f_22056_98126_98175(ErrorCode.ERR_NameNotInContext, "bad"), "bad"), 5, 27)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,98248,98581);

f_22056_98248_98580(comp, @"
IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid) (Syntax: 'new(bad)')
  Children(1):
      IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid) (Syntax: 'bad')
        Children(0)
            ", expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,97418,98592);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,97418,98592);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,97418,98592);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(1198816, "https://devdiv.visualstudio.com/DevDiv/_workitems/edit/1198816/")]
        public void ImplicitObjectCreationUnconverted_ConditionalOperator_Nested1()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,98604,99802);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,98859,99008);

var 
source =
@"class Program
{
    static void Main()
    {
        _ = (/*<bind>*/new(bad)/*</bind>*/, null) ? null : new object();
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,99022,99059);

var 
comp = f_22056_99033_99058(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,99075,99442);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22056_99336_99426(f_22056_99336_99406(f_22056_99336_99385(ErrorCode.ERR_NameNotInContext, "bad"), "bad"), 5, 28)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,99458,99791);

f_22056_99458_99790(comp, @"
IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid) (Syntax: 'new(bad)')
  Children(1):
      IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid) (Syntax: 'bad')
        Children(0)
            ", expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,98604,99802);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,98604,99802);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,98604,99802);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(1198816, "https://devdiv.visualstudio.com/DevDiv/_workitems/edit/1198816/")]
        public void ImplicitObjectCreationUnconverted_ConditionalOperator_Nested2()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,99814,101059);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,100069,100244);

var 
source =
@"class Program
{
    static void Main(int i)
    {
        _ = i switch { 1 => /*<bind>*/new(bad)/*</bind>*/, _ => null } ? null : new object();
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,100258,100295);

var 
comp = f_22056_100269_100294(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,100311,100699);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22056_100593_100683(f_22056_100593_100663(f_22056_100593_100642(ErrorCode.ERR_NameNotInContext, "bad"), "bad"), 5, 43)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,100715,101048);

f_22056_100715_101047(comp, @"
IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid) (Syntax: 'new(bad)')
  Children(1):
      IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid) (Syntax: 'bad')
        Children(0)
            ", expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,99814,101059);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,99814,101059);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,99814,101059);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ImplicitObjectCreationWithDynamicMemberInitializer_01()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,101071,112426);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,101232,101700);

var 
comp = f_22056_101243_101699(@"
#pragma warning disable 0169
class A
{
    dynamic this[int x, int y]
    {
        get
        {
            return new A();
        }
    }
    dynamic this[string x, string y]
    {
        get
        {
            throw null;
        }
    }
    int X, Y, Z;
    static void Main()
    {
        dynamic x = 1;
        A _ = new() {/*<bind>*/[y: x, x: x] = { X = 1, Y = 1, Z = 1 }/*</bind>*/ };
    }
}
")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,101714,104580);

string 
expectedOperationTree = @"
IMemberInitializerOperation (OperationKind.MemberInitializer, Type: dynamic) (Syntax: '[y: x, x: x ...  1, Z = 1 }')
  InitializedMember: 
    IDynamicIndexerAccessOperation (OperationKind.DynamicIndexerAccess, Type: dynamic) (Syntax: '[y: x, x: x]')
      Expression: 
        IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: A, IsImplicit) (Syntax: '[y: x, x: x]')
      Arguments(2):
          ILocalReferenceOperation: x (OperationKind.LocalReference, Type: dynamic) (Syntax: 'x')
          ILocalReferenceOperation: x (OperationKind.LocalReference, Type: dynamic) (Syntax: 'x')
      ArgumentNames(2):
        ""y""
        ""x""
      ArgumentRefKinds(0)
  Initializer: 
    IObjectOrCollectionInitializerOperation (OperationKind.ObjectOrCollectionInitializer, Type: dynamic) (Syntax: '{ X = 1, Y = 1, Z = 1 }')
      Initializers(3):
          ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: dynamic) (Syntax: 'X = 1')
            Left: 
              IDynamicMemberReferenceOperation (Member Name: ""X"", Containing Type: dynamic) (OperationKind.DynamicMemberReference, Type: dynamic) (Syntax: 'X')
                Type Arguments(0)
                Instance Receiver: 
                  IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: dynamic, IsImplicit) (Syntax: 'X')
            Right: 
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
          ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: dynamic) (Syntax: 'Y = 1')
            Left: 
              IDynamicMemberReferenceOperation (Member Name: ""Y"", Containing Type: dynamic) (OperationKind.DynamicMemberReference, Type: dynamic) (Syntax: 'Y')
                Type Arguments(0)
                Instance Receiver: 
                  IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: dynamic, IsImplicit) (Syntax: 'Y')
            Right: 
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
          ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: dynamic) (Syntax: 'Z = 1')
            Left: 
              IDynamicMemberReferenceOperation (Member Name: ""Z"", Containing Type: dynamic) (OperationKind.DynamicMemberReference, Type: dynamic) (Syntax: 'Z')
                Type Arguments(0)
                Instance Receiver: 
                  IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: dynamic, IsImplicit) (Syntax: 'Z')
            Right: 
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,104594,104647);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,104663,104782);

f_22056_104663_104781(comp, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,104798,104900);

var 
main = f_22056_104809_104899(f_22056_104809_104890(f_22056_104809_104856(f_22056_104809_104838(f_22056_104809_104825(comp)[0]))))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,104914,112415);

f_22056_104914_112414(comp, main, @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [dynamic x] [A _]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: dynamic, IsImplicit) (Syntax: 'x = 1')
              Left: 
                ILocalReferenceOperation: x (IsDeclaration: True) (OperationKind.LocalReference, Type: dynamic, IsImplicit) (Syntax: 'x = 1')
              Right: 
                IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: dynamic, IsImplicit) (Syntax: '1')
                  Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    (Boxing)
                  Operand: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [0]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new() {/*<b ... </bind>*/ }')
                  Value: 
                    IObjectCreationOperation (Constructor: A..ctor()) (OperationKind.ObjectCreation, Type: A) (Syntax: 'new() {/*<b ... </bind>*/ }')
                      Arguments(0)
                      Initializer: 
                        null

            Next (Regular) Block[B3]
                Entering: {R3}

        .locals {R3}
        {
            CaptureIds: [1] [2]
            Block[B3] - Block
                Predecessors: [B2]
                Statements (5)
                    IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'x')
                      Value: 
                        ILocalReferenceOperation: x (OperationKind.LocalReference, Type: dynamic) (Syntax: 'x')

                    IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'x')
                      Value: 
                        ILocalReferenceOperation: x (OperationKind.LocalReference, Type: dynamic) (Syntax: 'x')

                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: dynamic) (Syntax: 'X = 1')
                      Left: 
                        IDynamicMemberReferenceOperation (Member Name: ""X"", Containing Type: dynamic) (OperationKind.DynamicMemberReference, Type: dynamic) (Syntax: 'X')
                          Type Arguments(0)
                          Instance Receiver: 
                            IDynamicIndexerAccessOperation (OperationKind.DynamicIndexerAccess, Type: dynamic) (Syntax: '[y: x, x: x]')
                              Expression: 
                                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: A, IsImplicit) (Syntax: 'new() {/*<b ... </bind>*/ }')
                              Arguments(2):
                                  IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'x')
                                  IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'x')
                              ArgumentNames(2):
                                ""y""
                                ""x""
                              ArgumentRefKinds(0)
                      Right: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: dynamic) (Syntax: 'Y = 1')
                      Left: 
                        IDynamicMemberReferenceOperation (Member Name: ""Y"", Containing Type: dynamic) (OperationKind.DynamicMemberReference, Type: dynamic) (Syntax: 'Y')
                          Type Arguments(0)
                          Instance Receiver: 
                            IDynamicIndexerAccessOperation (OperationKind.DynamicIndexerAccess, Type: dynamic) (Syntax: '[y: x, x: x]')
                              Expression: 
                                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: A, IsImplicit) (Syntax: 'new() {/*<b ... </bind>*/ }')
                              Arguments(2):
                                  IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'x')
                                  IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'x')
                              ArgumentNames(2):
                                ""y""
                                ""x""
                              ArgumentRefKinds(0)
                      Right: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: dynamic) (Syntax: 'Z = 1')
                      Left: 
                        IDynamicMemberReferenceOperation (Member Name: ""Z"", Containing Type: dynamic) (OperationKind.DynamicMemberReference, Type: dynamic) (Syntax: 'Z')
                          Type Arguments(0)
                          Instance Receiver: 
                            IDynamicIndexerAccessOperation (OperationKind.DynamicIndexerAccess, Type: dynamic) (Syntax: '[y: x, x: x]')
                              Expression: 
                                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: A, IsImplicit) (Syntax: 'new() {/*<b ... </bind>*/ }')
                              Arguments(2):
                                  IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'x')
                                  IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'x')
                              ArgumentNames(2):
                                ""y""
                                ""x""
                              ArgumentRefKinds(0)
                      Right: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

                Next (Regular) Block[B4]
                    Leaving: {R3}
        }

        Block[B4] - Block
            Predecessors: [B3]
            Statements (1)
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: A, IsImplicit) (Syntax: '_ = new() { ... </bind>*/ }')
                  Left: 
                    ILocalReferenceOperation: _ (IsDeclaration: True) (OperationKind.LocalReference, Type: A, IsImplicit) (Syntax: '_ = new() { ... </bind>*/ }')
                  Right: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: A, IsImplicit) (Syntax: 'new() {/*<b ... </bind>*/ }')

            Next (Regular) Block[B5]
                Leaving: {R2} {R1}
    }
}

Block[B5] - Exit
    Predecessors: [B4]
    Statements (0)
            ");
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,101071,112426);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,101071,112426);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,101071,112426);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ImplicitObjectCreationWithDynamicMemberInitializer_02()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,112438,114223);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,112599,113033);

string 
source = @"
#pragma warning disable 0169
class A
{
    dynamic this[int x, int y]
    {
        get
        {
            return new A();
        }
    }
    dynamic this[string x, string y]
    {
        get
        {
            throw null;
        }
    }
    int X, Y, Z;
    static void Main()
    {
        dynamic x = 1;
        A _ = new() {/*<bind>*/[y: x, x: x] = { }/*</bind>*/ };
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,113047,113963);

string 
expectedOperationTree = @"
IMemberInitializerOperation (OperationKind.MemberInitializer, Type: dynamic) (Syntax: '[y: x, x: x] = { }')
  InitializedMember: 
    IDynamicIndexerAccessOperation (OperationKind.DynamicIndexerAccess, Type: dynamic) (Syntax: '[y: x, x: x]')
      Expression: 
        IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: A, IsImplicit) (Syntax: '[y: x, x: x]')
      Arguments(2):
          ILocalReferenceOperation: x (OperationKind.LocalReference, Type: dynamic) (Syntax: 'x')
          ILocalReferenceOperation: x (OperationKind.LocalReference, Type: dynamic) (Syntax: 'x')
      ArgumentNames(2):
        ""y""
        ""x""
      ArgumentRefKinds(0)
  Initializer: 
    IObjectOrCollectionInitializerOperation (OperationKind.ObjectOrCollectionInitializer, Type: dynamic) (Syntax: '{ }')
      Initializers(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,113977,114030);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,114046,114212);

f_22056_114046_114211(source, expectedOperationTree, expectedDiagnostics, parseOptions: ImplicitObjectCreationOptions);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,112438,114223);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,112438,114223);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,112438,114223);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ImplicitObjectCreationWithDynamicMemberInitializer_03()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,114235,115676);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,114396,114830);

string 
source = @"
#pragma warning disable 0169
class A
{
    dynamic this[int x, int y]
    {
        get
        {
            return new A();
        }
    }
    dynamic this[string x, string y]
    {
        get
        {
            throw null;
        }
    }
    int X, Y, Z;
    static void Main()
    {
        dynamic x = 1;
        A _ = new() {/*<bind>*/[y: x, x: x]/*</bind>*/ = { } };
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,114844,115426);

string 
expectedOperationTree = @"
IDynamicIndexerAccessOperation (OperationKind.DynamicIndexerAccess, Type: dynamic) (Syntax: '[y: x, x: x]')
  Expression: 
    IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: A, IsImplicit) (Syntax: '[y: x, x: x]')
  Arguments(2):
      ILocalReferenceOperation: x (OperationKind.LocalReference, Type: dynamic) (Syntax: 'x')
      ILocalReferenceOperation: x (OperationKind.LocalReference, Type: dynamic) (Syntax: 'x')
  ArgumentNames(2):
    ""y""
    ""x""
  ArgumentRefKinds(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,115440,115493);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,115509,115665);

f_22056_115509_115664(source, expectedOperationTree, expectedDiagnostics, parseOptions: ImplicitObjectCreationOptions);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,114235,115676);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,114235,115676);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,114235,115676);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ImplicitObjectCreationDynamicCollectionInitializer()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,115688,117604);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,115846,116224);

string 
source = @"
using System.Collections;
using System.Collections.Generic;
class C1 : IEnumerable<int>
{
    public static void M(C1 c, dynamic d1)
    {
        c = /*<bind>*/new() { d1 }/*</bind>*/;
    }
    public IEnumerator<int> GetEnumerator() => throw null;
    IEnumerator IEnumerable.GetEnumerator() => throw null;
    public void Add(int c2) { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,116238,116291);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,116307,117401);

string 
expectedOperationTree = @"
IObjectCreationOperation (Constructor: C1..ctor()) (OperationKind.ObjectCreation, Type: C1) (Syntax: 'new() { d1 }')
  Arguments(0)
  Initializer: 
    IObjectOrCollectionInitializerOperation (OperationKind.ObjectOrCollectionInitializer, Type: C1) (Syntax: '{ d1 }')
      Initializers(1):
          IDynamicInvocationOperation (OperationKind.DynamicInvocation, Type: dynamic, IsImplicit) (Syntax: 'd1')
            Expression: 
              IDynamicMemberReferenceOperation (Member Name: ""Add"", Containing Type: null) (OperationKind.DynamicMemberReference, Type: null, IsImplicit) (Syntax: 'new() { d1 }')
                Type Arguments(0)
                Instance Receiver: 
                  IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: C1, IsImplicit) (Syntax: 'new() { d1 }')
            Arguments(1):
                IParameterReferenceOperation: d1 (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'd1')
            ArgumentNames(0)
            ArgumentRefKinds(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,117415,117593);

f_22056_117415_117592(source, expectedOperationTree, expectedDiagnostics, parseOptions: ImplicitObjectCreationOptions);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,115688,117604);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,115688,117604);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,115688,117604);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ImplicitObjectCreationCollectionInitializerWithRefAddMethod()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,117616,120768);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,117783,118269);

string 
source = @"
using System;
using System.Collections;
using System.Collections.Generic;
class C : IEnumerable<int>
{
    public static void M()
    {
        C c = new() /*<bind>*/{ 1, 2, 3 }/*</bind>*/;
    }
    public IEnumerator<int> GetEnumerator()
    {
        throw new NotImplementedException();
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
    }
    public void Add(ref int i)
    {
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,118283,119191);

string 
expectedOperationTree = @"
IObjectOrCollectionInitializerOperation (OperationKind.ObjectOrCollectionInitializer, Type: C, IsInvalid) (Syntax: '{ 1, 2, 3 }')
  Initializers(3):
      IInvalidOperation (OperationKind.Invalid, Type: System.Void, IsInvalid, IsImplicit) (Syntax: '1')
        Children(1):
            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1, IsInvalid) (Syntax: '1')
      IInvalidOperation (OperationKind.Invalid, Type: System.Void, IsInvalid, IsImplicit) (Syntax: '2')
        Children(1):
            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2, IsInvalid) (Syntax: '2')
      IInvalidOperation (OperationKind.Invalid, Type: System.Void, IsInvalid, IsImplicit) (Syntax: '3')
        Children(1):
            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3, IsInvalid) (Syntax: '3')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,119205,120574);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22056_119578_119692(f_22056_119578_119672(f_22056_119578_119640(ErrorCode.ERR_InitializerAddHasParamModifiers, "1"), "C.Add(ref int)"), 9, 33),
f_22056_120011_120125(f_22056_120011_120105(f_22056_120011_120073(ErrorCode.ERR_InitializerAddHasParamModifiers, "2"), "C.Add(ref int)"), 9, 36),
f_22056_120444_120558(f_22056_120444_120538(f_22056_120444_120506(ErrorCode.ERR_InitializerAddHasParamModifiers, "3"), "C.Add(ref int)"), 9, 39)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,120590,120757);

f_22056_120590_120756(source, expectedOperationTree, expectedDiagnostics, parseOptions: ImplicitObjectCreationOptions);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,117616,120768);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,117616,120768);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,117616,120768);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ImplicitObjectCreationCollectionInitializerWithDefaultParameterAddMethod()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,120780,126531);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,120960,121459);

string 
source = @"
using System;
using System.Collections;
using System.Collections.Generic;
class C : IEnumerable<int>
{
    public static void M()
    {
        C c = new() /*<bind>*/{ 1, 2, 3 }/*</bind>*/;
    }
    public IEnumerator<int> GetEnumerator()
    {
        throw new NotImplementedException();
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
    }
    public void Add(int i, object o = null)
    {
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,121473,126270);

string 
expectedOperationTree = @"
IObjectOrCollectionInitializerOperation (OperationKind.ObjectOrCollectionInitializer, Type: C) (Syntax: '{ 1, 2, 3 }')
  Initializers(3):
      IInvocationOperation ( void C.Add(System.Int32 i, [System.Object o = null])) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: '1')
        Instance Receiver: 
          IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: C, IsImplicit) (Syntax: 'new() /*<bi ... { 1, 2, 3 }')
        Arguments(2):
            IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: '1')
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
              InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
              OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            IArgumentOperation (ArgumentKind.DefaultValue, Matching Parameter: o) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: '1')
              IDefaultValueOperation (OperationKind.DefaultValue, Type: System.Object, Constant: null, IsImplicit) (Syntax: '1')
              InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
              OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      IInvocationOperation ( void C.Add(System.Int32 i, [System.Object o = null])) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: '2')
        Instance Receiver: 
          IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: C, IsImplicit) (Syntax: 'new() /*<bi ... { 1, 2, 3 }')
        Arguments(2):
            IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: '2')
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
              InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
              OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            IArgumentOperation (ArgumentKind.DefaultValue, Matching Parameter: o) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: '2')
              IDefaultValueOperation (OperationKind.DefaultValue, Type: System.Object, Constant: null, IsImplicit) (Syntax: '2')
              InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
              OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      IInvocationOperation ( void C.Add(System.Int32 i, [System.Object o = null])) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: '3')
        Instance Receiver: 
          IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: C, IsImplicit) (Syntax: 'new() /*<bi ... { 1, 2, 3 }')
        Arguments(2):
            IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: '3')
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')
              InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
              OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            IArgumentOperation (ArgumentKind.DefaultValue, Matching Parameter: o) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: '3')
              IDefaultValueOperation (OperationKind.DefaultValue, Type: System.Object, Constant: null, IsImplicit) (Syntax: '3')
              InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
              OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,126284,126337);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,126353,126520);

f_22056_126353_126519(source, expectedOperationTree, expectedDiagnostics, parseOptions: ImplicitObjectCreationOptions);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,120780,126531);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,120780,126531);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,120780,126531);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ImplicitObjectCreationCollectionInitializerWithParamsAddMethod()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,126543,131908);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,126713,127193);

string 
source = @"
using System.Collections;
using System.Collections.Generic;
class C : IEnumerable<int>
{
    void M(C c)
    {
        c = new() /*<bind>*/{ 1, 2, 3 }/*</bind>*/;
    }
    public void Add(params int[] ints)
    {
    }
    public IEnumerator<int> GetEnumerator()
    {
        throw new System.NotImplementedException();
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new System.NotImplementedException();
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,127207,127260);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,127276,131716);

string 
expectedOperationTree = @"
IObjectOrCollectionInitializerOperation (OperationKind.ObjectOrCollectionInitializer, Type: C) (Syntax: '{ 1, 2, 3 }')
  Initializers(3):
      IInvocationOperation ( void C.Add(params System.Int32[] ints)) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: '1')
        Instance Receiver: 
          IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: C, IsImplicit) (Syntax: 'new() /*<bi ... { 1, 2, 3 }')
        Arguments(1):
            IArgumentOperation (ArgumentKind.ParamArray, Matching Parameter: ints) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: '1')
              IArrayCreationOperation (OperationKind.ArrayCreation, Type: System.Int32[], IsImplicit) (Syntax: '1')
                Dimension Sizes(1):
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1, IsImplicit) (Syntax: '1')
                Initializer: 
                  IArrayInitializerOperation (1 elements) (OperationKind.ArrayInitializer, Type: null, IsImplicit) (Syntax: '1')
                    Element Values(1):
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
              InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
              OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      IInvocationOperation ( void C.Add(params System.Int32[] ints)) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: '2')
        Instance Receiver: 
          IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: C, IsImplicit) (Syntax: 'new() /*<bi ... { 1, 2, 3 }')
        Arguments(1):
            IArgumentOperation (ArgumentKind.ParamArray, Matching Parameter: ints) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: '2')
              IArrayCreationOperation (OperationKind.ArrayCreation, Type: System.Int32[], IsImplicit) (Syntax: '2')
                Dimension Sizes(1):
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1, IsImplicit) (Syntax: '2')
                Initializer: 
                  IArrayInitializerOperation (1 elements) (OperationKind.ArrayInitializer, Type: null, IsImplicit) (Syntax: '2')
                    Element Values(1):
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
              InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
              OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      IInvocationOperation ( void C.Add(params System.Int32[] ints)) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: '3')
        Instance Receiver: 
          IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: C, IsImplicit) (Syntax: 'new() /*<bi ... { 1, 2, 3 }')
        Arguments(1):
            IArgumentOperation (ArgumentKind.ParamArray, Matching Parameter: ints) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: '3')
              IArrayCreationOperation (OperationKind.ArrayCreation, Type: System.Int32[], IsImplicit) (Syntax: '3')
                Dimension Sizes(1):
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1, IsImplicit) (Syntax: '3')
                Initializer: 
                  IArrayInitializerOperation (1 elements) (OperationKind.ArrayInitializer, Type: null, IsImplicit) (Syntax: '3')
                    Element Values(1):
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')
              InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
              OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,131730,131897);

f_22056_131730_131896(source, expectedOperationTree, expectedDiagnostics, parseOptions: ImplicitObjectCreationOptions);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,126543,131908);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,126543,131908);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,126543,131908);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ImplicitObjectCreationCollectionInitializerExtensionAddMethod()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,131920,137393);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,132089,132606);

string 
source = @"
using System.Collections;
using System.Collections.Generic;
class C : IEnumerable<int>
{
    void M(C c)
    {
        c = new() /*<bind>*/{ 1, 2, 3 }/*</bind>*/;
    }
    public IEnumerator<int> GetEnumerator()
    {
        throw new System.NotImplementedException();
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new System.NotImplementedException();
    }
}
static class CExtensions
{
    public static void Add(this C c, int i)
    {
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,132620,132673);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,132689,137201);

string 
expectedOperationTree = @"
IObjectOrCollectionInitializerOperation (OperationKind.ObjectOrCollectionInitializer, Type: C) (Syntax: '{ 1, 2, 3 }')
  Initializers(3):
      IInvocationOperation (void CExtensions.Add(this C c, System.Int32 i)) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: '1')
        Instance Receiver: 
          null
        Arguments(2):
            IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: c) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'new() /*<bi ... { 1, 2, 3 }')
              IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: C, IsImplicit) (Syntax: 'new() /*<bi ... { 1, 2, 3 }')
              InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
              OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: '1')
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
              InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
              OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      IInvocationOperation (void CExtensions.Add(this C c, System.Int32 i)) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: '2')
        Instance Receiver: 
          null
        Arguments(2):
            IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: c) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'new() /*<bi ... { 1, 2, 3 }')
              IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: C, IsImplicit) (Syntax: 'new() /*<bi ... { 1, 2, 3 }')
              InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
              OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: '2')
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
              InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
              OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      IInvocationOperation (void CExtensions.Add(this C c, System.Int32 i)) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: '3')
        Instance Receiver: 
          null
        Arguments(2):
            IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: c) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'new() /*<bi ... { 1, 2, 3 }')
              IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: C, IsImplicit) (Syntax: 'new() /*<bi ... { 1, 2, 3 }')
              InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
              OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: '3')
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')
              InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
              OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,137215,137382);

f_22056_137215_137381(source, expectedOperationTree, expectedDiagnostics, parseOptions: ImplicitObjectCreationOptions);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,131920,137393);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,131920,137393);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,131920,137393);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ImplicitObjectCreationCollectionInitializerStaticAddMethod()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,137405,140496);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,137571,138060);

string 
source = @"
using System;
using System.Collections;
using System.Collections.Generic;
class C : IEnumerable<int>
{
    public static void M()
    {
        C c = new() /*<bind>*/{ 1, 2, 3 }/*</bind>*/;
    }
    public IEnumerator<int> GetEnumerator()
    {
        throw new NotImplementedException();
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
    }
    public static void Add(int i)
    {
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,138074,139380);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22056_138430_138540(f_22056_138430_138520(f_22056_138430_138492(ErrorCode.ERR_InitializerAddHasWrongSignature, "1"), "C.Add(int)"), 9, 33),
f_22056_138842_138952(f_22056_138842_138932(f_22056_138842_138904(ErrorCode.ERR_InitializerAddHasWrongSignature, "2"), "C.Add(int)"), 9, 36),
f_22056_139254_139364(f_22056_139254_139344(f_22056_139254_139316(ErrorCode.ERR_InitializerAddHasWrongSignature, "3"), "C.Add(int)"), 9, 39)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,139396,140304);

string 
expectedOperationTree = @"
IObjectOrCollectionInitializerOperation (OperationKind.ObjectOrCollectionInitializer, Type: C, IsInvalid) (Syntax: '{ 1, 2, 3 }')
  Initializers(3):
      IInvalidOperation (OperationKind.Invalid, Type: System.Void, IsInvalid, IsImplicit) (Syntax: '1')
        Children(1):
            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1, IsInvalid) (Syntax: '1')
      IInvalidOperation (OperationKind.Invalid, Type: System.Void, IsInvalid, IsImplicit) (Syntax: '2')
        Children(1):
            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2, IsInvalid) (Syntax: '2')
      IInvalidOperation (OperationKind.Invalid, Type: System.Void, IsInvalid, IsImplicit) (Syntax: '3')
        Children(1):
            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3, IsInvalid) (Syntax: '3')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,140318,140485);

f_22056_140318_140484(source, expectedOperationTree, expectedDiagnostics, parseOptions: ImplicitObjectCreationOptions);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,137405,140496);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,137405,140496);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,137405,140496);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ImplicitObjectCreationCollectionInitializerAddMethodOnInterface()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,140508,144394);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,140679,141116);

string 
source = @"
using System.Collections.Generic;
using System.Runtime.InteropServices;
[ComImport()]
[CoClass(typeof(CoClassImplementation))]
[Guid(""f9c2d51d-4f44-45f0-9eda-c9d599b58257"")]
public interface IInterface : IEnumerable<int>
{
    void Add(int i);
}
public class CoClassImplementation
{
}
class C
{
    void M()
    {
        IInterface iinterface = new() /*<bind>*/{ 1, 2, 3 }/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,141130,141183);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,141199,144211);

string 
expectedOperationTree = @"
IObjectOrCollectionInitializerOperation (OperationKind.ObjectOrCollectionInitializer, Type: IInterface) (Syntax: '{ 1, 2, 3 }')
  Initializers(3):
      IInvocationOperation (virtual void IInterface.Add(System.Int32 i)) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: '1')
        Instance Receiver: 
          IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: IInterface, IsImplicit) (Syntax: 'new() /*<bi ... { 1, 2, 3 }')
        Arguments(1):
            IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: '1')
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
              InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
              OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      IInvocationOperation (virtual void IInterface.Add(System.Int32 i)) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: '2')
        Instance Receiver: 
          IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: IInterface, IsImplicit) (Syntax: 'new() /*<bi ... { 1, 2, 3 }')
        Arguments(1):
            IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: '2')
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
              InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
              OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      IInvocationOperation (virtual void IInterface.Add(System.Int32 i)) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: '3')
        Instance Receiver: 
          IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: IInterface, IsImplicit) (Syntax: 'new() /*<bi ... { 1, 2, 3 }')
        Arguments(1):
            IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: '3')
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')
              InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
              OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,144225,144383);

f_22056_144225_144382(source, expectedOperationTree, expectedDiagnostics, parseOptions: TestOptions.Regular9);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,140508,144394);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,140508,144394);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,140508,144394);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ImplicitObjectCreationNestedObjectInitializerNoSet()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,144406,150976);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,144564,144796);

var 
comp = f_22056_144575_144795(@"
class C1
{
    void M(C1 c1)
    {
        c1 = new() /*<bind>*/{ [1] = { A = 1 } }/*</bind>*/;
    }
    C2 this[int i] { get => null; }
}
class C2
{
    public int A { get; set; }
}
")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,144810,144863);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,144879,146927);

string 
expectedOperationTree = @"
IObjectOrCollectionInitializerOperation (OperationKind.ObjectOrCollectionInitializer, Type: C1) (Syntax: '{ [1] = { A = 1 } }')
  Initializers(1):
      IMemberInitializerOperation (OperationKind.MemberInitializer, Type: C2) (Syntax: '[1] = { A = 1 }')
        InitializedMember: 
          IPropertyReferenceOperation: C2 C1.this[System.Int32 i] { get; } (OperationKind.PropertyReference, Type: C2) (Syntax: '[1]')
            Instance Receiver: 
              IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: C1, IsImplicit) (Syntax: '[1]')
            Arguments(1):
                IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: '1')
                  ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
                  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Initializer: 
          IObjectOrCollectionInitializerOperation (OperationKind.ObjectOrCollectionInitializer, Type: C2) (Syntax: '{ A = 1 }')
            Initializers(1):
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'A = 1')
                  Left: 
                    IPropertyReferenceOperation: System.Int32 C2.A { get; set; } (OperationKind.PropertyReference, Type: System.Int32) (Syntax: 'A')
                      Instance Receiver: 
                        IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: C2, IsImplicit) (Syntax: 'A')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,146941,147061);

f_22056_146941_147060(comp, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,147077,147176);

var 
m = f_22056_147085_147175(f_22056_147085_147166(f_22056_147085_147132(f_22056_147085_147114(f_22056_147085_147101(comp)[0]))))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,147192,150965);

f_22056_147192_150964(comp, m, @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [1]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (2)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c1')
              Value: 
                IParameterReferenceOperation: c1 (OperationKind.ParameterReference, Type: C1) (Syntax: 'c1')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new() /*<bi ... { A = 1 } }')
              Value: 
                IObjectCreationOperation (Constructor: C1..ctor()) (OperationKind.ObjectCreation, Type: C1) (Syntax: 'new() /*<bi ... { A = 1 } }')
                  Arguments(0)
                  Initializer: 
                    null

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (2)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '1')
                  Value: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'A = 1')
                  Left: 
                    IPropertyReferenceOperation: System.Int32 C2.A { get; set; } (OperationKind.PropertyReference, Type: System.Int32) (Syntax: 'A')
                      Instance Receiver: 
                        IPropertyReferenceOperation: C2 C1.this[System.Int32 i] { get; } (OperationKind.PropertyReference, Type: C2) (Syntax: '[1]')
                          Instance Receiver: 
                            IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new() /*<bi ... { A = 1 } }')
                          Arguments(1):
                              IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: '1')
                                IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, Constant: 1, IsImplicit) (Syntax: '1')
                                InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

            Next (Regular) Block[B3]
                Leaving: {R2}
    }

    Block[B3] - Block
        Predecessors: [B2]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'c1 = new()  ... *</bind>*/;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: C1) (Syntax: 'c1 = new()  ... { A = 1 } }')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'c1')
                  Right: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new() /*<bi ... { A = 1 } }')

        Next (Regular) Block[B4]
            Leaving: {R1}
}

Block[B4] - Exit
    Predecessors: [B3]
    Statements (0)
");
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,144406,150976);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,144406,150976);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,144406,150976);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ImplicitObjectCreationNestedCollectionInitializerNoSet()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,150988,158489);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,151150,151643);

var 
comp = f_22056_151161_151642(@"
using System.Collections;
using System.Collections.Generic;
class C1
{
    void M(C1 c1)
    {
        c1 = new() /*<bind>*/{ [1] = { 1 } }/*</bind>*/;
    }
    C2 this[int i] { get => null; }
}
class C2 : IEnumerable<int>
{
    public IEnumerator<int> GetEnumerator() => throw new System.NotImplementedException();
    IEnumerator IEnumerable.GetEnumerator() => throw new System.NotImplementedException();
    public void Add(int i) { }
}
")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,151657,151710);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,151726,154109);

string 
expectedOperationTree = @"
IObjectOrCollectionInitializerOperation (OperationKind.ObjectOrCollectionInitializer, Type: C1) (Syntax: '{ [1] = { 1 } }')
  Initializers(1):
      IMemberInitializerOperation (OperationKind.MemberInitializer, Type: C2) (Syntax: '[1] = { 1 }')
        InitializedMember: 
          IPropertyReferenceOperation: C2 C1.this[System.Int32 i] { get; } (OperationKind.PropertyReference, Type: C2) (Syntax: '[1]')
            Instance Receiver: 
              IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: C1, IsImplicit) (Syntax: '[1]')
            Arguments(1):
                IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: '1')
                  ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
                  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Initializer: 
          IObjectOrCollectionInitializerOperation (OperationKind.ObjectOrCollectionInitializer, Type: C2) (Syntax: '{ 1 }')
            Initializers(1):
                IInvocationOperation ( void C2.Add(System.Int32 i)) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: '1')
                  Instance Receiver: 
                    IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: C2, IsImplicit) (Syntax: '[1]')
                  Arguments(1):
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: '1')
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,154123,154243);

f_22056_154123_154242(comp, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,154259,154392);

var 
m = f_22056_154267_154391(f_22056_154267_154348(f_22056_154267_154314(f_22056_154267_154296(f_22056_154267_154283(comp)[0]))), m => m.Identifier.ValueText == "M")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,154406,158478);

f_22056_154406_158477(comp, m, @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}
.locals {R1}
{
    CaptureIds: [0] [1]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (2)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c1')
              Value: 
                IParameterReferenceOperation: c1 (OperationKind.ParameterReference, Type: C1) (Syntax: 'c1')
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new() /*<bi ... ] = { 1 } }')
              Value: 
                IObjectCreationOperation (Constructor: C1..ctor()) (OperationKind.ObjectCreation, Type: C1) (Syntax: 'new() /*<bi ... ] = { 1 } }')
                  Arguments(0)
                  Initializer: 
                    null
        Next (Regular) Block[B2]
            Entering: {R2}
    .locals {R2}
    {
        CaptureIds: [2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (2)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '1')
                  Value: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
                IInvocationOperation ( void C2.Add(System.Int32 i)) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: '1')
                  Instance Receiver: 
                    IPropertyReferenceOperation: C2 C1.this[System.Int32 i] { get; } (OperationKind.PropertyReference, Type: C2) (Syntax: '[1]')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new() /*<bi ... ] = { 1 } }')
                      Arguments(1):
                          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: '1')
                            IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, Constant: 1, IsImplicit) (Syntax: '1')
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  Arguments(1):
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: '1')
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            Next (Regular) Block[B3]
                Leaving: {R2}
    }
    Block[B3] - Block
        Predecessors: [B2]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'c1 = new()  ... *</bind>*/;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: C1) (Syntax: 'c1 = new()  ... ] = { 1 } }')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'c1')
                  Right: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new() /*<bi ... ] = { 1 } }')
        Next (Regular) Block[B4]
            Leaving: {R1}
}
Block[B4] - Exit
    Predecessors: [B3]
    Statements (0)
");
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,150988,158489);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,150988,158489);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,150988,158489);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17588, "https://github.com/dotnet/roslyn/issues/17588")]
        public void ObjectCreationWithMemberInitializers()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,158501,173677);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,158711,159292);

string 
source = @"
struct B
{
    public bool Field;
}

class F
{
    public int Field;
    public string Property1 { set; get; }
    public B Property2 { set; get; }
}

class C
{
    public void M1()
    /*<bind>*/{
        var x1 = new F();
        var x2 = new F() { Field = 2 };
        var x3 = new F() { Property1 = """" };
        var x4 = new F() { Property1 = """", Field = 2 };
        var x5 = new F() { Property2 = new B { Field = true } };

        var e1 = new F() { Property2 = 1 };
        var e2 = new F() { """" };
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,159306,172881);

string 
expectedOperationTree = @"
IBlockOperation (7 statements, 7 locals) (OperationKind.Block, Type: null, IsInvalid) (Syntax: '{ ... }')
  Locals: Local_1: F x1
    Local_2: F x2
    Local_3: F x3
    Local_4: F x4
    Local_5: F x5
    Local_6: F e1
    Local_7: F e2
  IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null) (Syntax: 'var x1 = new F();')
    IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'var x1 = new F()')
      Declarators:
          IVariableDeclaratorOperation (Symbol: F x1) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'x1 = new F()')
            Initializer: 
              IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= new F()')
                IObjectCreationOperation (Constructor: F..ctor()) (OperationKind.ObjectCreation, Type: F) (Syntax: 'new F()')
                  Arguments(0)
                  Initializer: 
                    null
      Initializer: 
        null
  IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null) (Syntax: 'var x2 = ne ... ield = 2 };')
    IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'var x2 = ne ... Field = 2 }')
      Declarators:
          IVariableDeclaratorOperation (Symbol: F x2) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'x2 = new F( ... Field = 2 }')
            Initializer: 
              IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= new F() { Field = 2 }')
                IObjectCreationOperation (Constructor: F..ctor()) (OperationKind.ObjectCreation, Type: F) (Syntax: 'new F() { Field = 2 }')
                  Arguments(0)
                  Initializer: 
                    IObjectOrCollectionInitializerOperation (OperationKind.ObjectOrCollectionInitializer, Type: F) (Syntax: '{ Field = 2 }')
                      Initializers(1):
                          ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'Field = 2')
                            Left: 
                              IFieldReferenceOperation: System.Int32 F.Field (OperationKind.FieldReference, Type: System.Int32) (Syntax: 'Field')
                                Instance Receiver: 
                                  IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: F, IsImplicit) (Syntax: 'Field')
                            Right: 
                              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
      Initializer: 
        null
  IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null) (Syntax: 'var x3 = ne ... ty1 = """" };')
    IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'var x3 = ne ... rty1 = """" }')
      Declarators:
          IVariableDeclaratorOperation (Symbol: F x3) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'x3 = new F( ... rty1 = """" }')
            Initializer: 
              IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= new F() { ... rty1 = """" }')
                IObjectCreationOperation (Constructor: F..ctor()) (OperationKind.ObjectCreation, Type: F) (Syntax: 'new F() { P ... rty1 = """" }')
                  Arguments(0)
                  Initializer: 
                    IObjectOrCollectionInitializerOperation (OperationKind.ObjectOrCollectionInitializer, Type: F) (Syntax: '{ Property1 = """" }')
                      Initializers(1):
                          ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.String) (Syntax: 'Property1 = """"')
                            Left: 
                              IPropertyReferenceOperation: System.String F.Property1 { get; set; } (OperationKind.PropertyReference, Type: System.String) (Syntax: 'Property1')
                                Instance Receiver: 
                                  IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: F, IsImplicit) (Syntax: 'Property1')
                            Right: 
                              ILiteralOperation (OperationKind.Literal, Type: System.String, Constant: """") (Syntax: '""""')
      Initializer: 
        null
  IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null) (Syntax: 'var x4 = ne ... ield = 2 };')
    IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'var x4 = ne ... Field = 2 }')
      Declarators:
          IVariableDeclaratorOperation (Symbol: F x4) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'x4 = new F( ... Field = 2 }')
            Initializer: 
              IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= new F() { ... Field = 2 }')
                IObjectCreationOperation (Constructor: F..ctor()) (OperationKind.ObjectCreation, Type: F) (Syntax: 'new F() { P ... Field = 2 }')
                  Arguments(0)
                  Initializer: 
                    IObjectOrCollectionInitializerOperation (OperationKind.ObjectOrCollectionInitializer, Type: F) (Syntax: '{ Property1 ... Field = 2 }')
                      Initializers(2):
                          ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.String) (Syntax: 'Property1 = """"')
                            Left: 
                              IPropertyReferenceOperation: System.String F.Property1 { get; set; } (OperationKind.PropertyReference, Type: System.String) (Syntax: 'Property1')
                                Instance Receiver: 
                                  IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: F, IsImplicit) (Syntax: 'Property1')
                            Right: 
                              ILiteralOperation (OperationKind.Literal, Type: System.String, Constant: """") (Syntax: '""""')
                          ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'Field = 2')
                            Left: 
                              IFieldReferenceOperation: System.Int32 F.Field (OperationKind.FieldReference, Type: System.Int32) (Syntax: 'Field')
                                Instance Receiver: 
                                  IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: F, IsImplicit) (Syntax: 'Field')
                            Right: 
                              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
      Initializer: 
        null
  IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null) (Syntax: 'var x5 = ne ... = true } };')
    IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'var x5 = ne ...  = true } }')
      Declarators:
          IVariableDeclaratorOperation (Symbol: F x5) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'x5 = new F( ...  = true } }')
            Initializer: 
              IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= new F() { ...  = true } }')
                IObjectCreationOperation (Constructor: F..ctor()) (OperationKind.ObjectCreation, Type: F) (Syntax: 'new F() { P ...  = true } }')
                  Arguments(0)
                  Initializer: 
                    IObjectOrCollectionInitializerOperation (OperationKind.ObjectOrCollectionInitializer, Type: F) (Syntax: '{ Property2 ...  = true } }')
                      Initializers(1):
                          ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: B) (Syntax: 'Property2 = ... ld = true }')
                            Left: 
                              IPropertyReferenceOperation: B F.Property2 { get; set; } (OperationKind.PropertyReference, Type: B) (Syntax: 'Property2')
                                Instance Receiver: 
                                  IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: F, IsImplicit) (Syntax: 'Property2')
                            Right: 
                              IObjectCreationOperation (Constructor: B..ctor()) (OperationKind.ObjectCreation, Type: B) (Syntax: 'new B { Field = true }')
                                Arguments(0)
                                Initializer: 
                                  IObjectOrCollectionInitializerOperation (OperationKind.ObjectOrCollectionInitializer, Type: B) (Syntax: '{ Field = true }')
                                    Initializers(1):
                                        ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'Field = true')
                                          Left: 
                                            IFieldReferenceOperation: System.Boolean B.Field (OperationKind.FieldReference, Type: System.Boolean) (Syntax: 'Field')
                                              Instance Receiver: 
                                                IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: B, IsImplicit) (Syntax: 'Field')
                                          Right: 
                                            ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')
      Initializer: 
        null
  IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsInvalid) (Syntax: 'var e1 = ne ... rty2 = 1 };')
    IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null, IsInvalid) (Syntax: 'var e1 = ne ... erty2 = 1 }')
      Declarators:
          IVariableDeclaratorOperation (Symbol: F e1) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'e1 = new F( ... erty2 = 1 }')
            Initializer: 
              IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '= new F() { ... erty2 = 1 }')
                IObjectCreationOperation (Constructor: F..ctor()) (OperationKind.ObjectCreation, Type: F, IsInvalid) (Syntax: 'new F() { P ... erty2 = 1 }')
                  Arguments(0)
                  Initializer: 
                    IObjectOrCollectionInitializerOperation (OperationKind.ObjectOrCollectionInitializer, Type: F, IsInvalid) (Syntax: '{ Property2 = 1 }')
                      Initializers(1):
                          ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: B, IsInvalid) (Syntax: 'Property2 = 1')
                            Left: 
                              IPropertyReferenceOperation: B F.Property2 { get; set; } (OperationKind.PropertyReference, Type: B) (Syntax: 'Property2')
                                Instance Receiver: 
                                  IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: F, IsImplicit) (Syntax: 'Property2')
                            Right: 
                              IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: B, IsInvalid, IsImplicit) (Syntax: '1')
                                Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                Operand: 
                                  ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1, IsInvalid) (Syntax: '1')
      Initializer: 
        null
  IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsInvalid) (Syntax: 'var e2 = new F() { """" };')
    IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null, IsInvalid) (Syntax: 'var e2 = new F() { """" }')
      Declarators:
          IVariableDeclaratorOperation (Symbol: F e2) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'e2 = new F() { """" }')
            Initializer: 
              IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '= new F() { """" }')
                IObjectCreationOperation (Constructor: F..ctor()) (OperationKind.ObjectCreation, Type: F, IsInvalid) (Syntax: 'new F() { """" }')
                  Arguments(0)
                  Initializer: 
                    IObjectOrCollectionInitializerOperation (OperationKind.ObjectOrCollectionInitializer, Type: F, IsInvalid) (Syntax: '{ """" }')
                      Initializers(1):
                          IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid, IsImplicit) (Syntax: '""""')
                            Children(1):
                                ILiteralOperation (OperationKind.Literal, Type: System.String, Constant: """", IsInvalid) (Syntax: '""""')
      Initializer: 
        null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,172895,173544);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22056_173104_173196(f_22056_173104_173175(f_22056_173104_173149(ErrorCode.ERR_NoImplicitConv, "1"), "int", "B"), 24, 40),
f_22056_173416_173528(f_22056_173416_173507(f_22056_173416_173488(ErrorCode.ERR_CollectionInitRequiresIEnumerable, @"{ """" }"), "F"), 25, 26)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,173560,173666);

f_22056_173560_173665(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,158501,173677);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,158501,173677);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,158501,173677);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17588, "https://github.com/dotnet/roslyn/issues/17588")]
        public void ObjectCreationWithCollectionInitializer()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,173689,178492);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,173902,174140);

string 
source = @"
using System.Collections.Generic;

class C
{
    private readonly int field;
    public void M1(int x)
    {
        int y = 0;
        var x1 = /*<bind>*/new List<int> { x, y, field }/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,174154,177970);

string 
expectedOperationTree = @"
IObjectCreationOperation (Constructor: System.Collections.Generic.List<System.Int32>..ctor()) (OperationKind.ObjectCreation, Type: System.Collections.Generic.List<System.Int32>) (Syntax: 'new List<in ...  y, field }')
  Arguments(0)
  Initializer: 
    IObjectOrCollectionInitializerOperation (OperationKind.ObjectOrCollectionInitializer, Type: System.Collections.Generic.List<System.Int32>) (Syntax: '{ x, y, field }')
      Initializers(3):
          IInvocationOperation ( void System.Collections.Generic.List<System.Int32>.Add(System.Int32 item)) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'x')
            Instance Receiver: 
              IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: System.Collections.Generic.List<System.Int32>, IsImplicit) (Syntax: 'List<int>')
            Arguments(1):
                IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: item) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'x')
                  IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'x')
                  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
          IInvocationOperation ( void System.Collections.Generic.List<System.Int32>.Add(System.Int32 item)) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'y')
            Instance Receiver: 
              IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: System.Collections.Generic.List<System.Int32>, IsImplicit) (Syntax: 'List<int>')
            Arguments(1):
                IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: item) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'y')
                  ILocalReferenceOperation: y (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'y')
                  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
          IInvocationOperation ( void System.Collections.Generic.List<System.Int32>.Add(System.Int32 item)) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'field')
            Instance Receiver: 
              IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: System.Collections.Generic.List<System.Int32>, IsImplicit) (Syntax: 'List<int>')
            Arguments(1):
                IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: item) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'field')
                  IFieldReferenceOperation: System.Int32 C.field (OperationKind.FieldReference, Type: System.Int32) (Syntax: 'field')
                    Instance Receiver: 
                      IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C, IsImplicit) (Syntax: 'field')
                  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,177984,178340);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22056_178216_178324(f_22056_178216_178304(f_22056_178216_178274(ErrorCode.WRN_UnassignedInternalField, "field"), "C.field", "0"), 6, 26)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,178356,178481);

f_22056_178356_178480(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,173689,178492);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,173689,178492);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,173689,178492);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17588, "https://github.com/dotnet/roslyn/issues/17588")]
        public void ObjectCreationWithNestedCollectionInitializer()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,178504,186173);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,178723,179063);

string 
source = @"
using System.Collections.Generic;
using System.Linq;

class C
{
    private readonly int field = 0;
    public void M1(int x)
    {
        int y = 0;
        var x1 = /*<bind>*/new List<List<int>> {
            new[] { x, y }.ToList(),
            new List<int> { field }
        }/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,179077,185954);

string 
expectedOperationTree = @"
IObjectCreationOperation (Constructor: System.Collections.Generic.List<System.Collections.Generic.List<System.Int32>>..ctor()) (OperationKind.ObjectCreation, Type: System.Collections.Generic.List<System.Collections.Generic.List<System.Int32>>) (Syntax: 'new List<Li ... }')
  Arguments(0)
  Initializer: 
    IObjectOrCollectionInitializerOperation (OperationKind.ObjectOrCollectionInitializer, Type: System.Collections.Generic.List<System.Collections.Generic.List<System.Int32>>) (Syntax: '{ ... }')
      Initializers(2):
          IInvocationOperation ( void System.Collections.Generic.List<System.Collections.Generic.List<System.Int32>>.Add(System.Collections.Generic.List<System.Int32> item)) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'new[] { x, y }.ToList()')
            Instance Receiver: 
              IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: System.Collections.Generic.List<System.Collections.Generic.List<System.Int32>>, IsImplicit) (Syntax: 'List<List<int>>')
            Arguments(1):
                IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: item) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'new[] { x, y }.ToList()')
                  IInvocationOperation (System.Collections.Generic.List<System.Int32> System.Linq.Enumerable.ToList<System.Int32>(this System.Collections.Generic.IEnumerable<System.Int32> source)) (OperationKind.Invocation, Type: System.Collections.Generic.List<System.Int32>) (Syntax: 'new[] { x, y }.ToList()')
                    Instance Receiver: 
                      null
                    Arguments(1):
                        IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: source) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'new[] { x, y }')
                          IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Collections.Generic.IEnumerable<System.Int32>, IsImplicit) (Syntax: 'new[] { x, y }')
                            Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                            Operand: 
                              IArrayCreationOperation (OperationKind.ArrayCreation, Type: System.Int32[]) (Syntax: 'new[] { x, y }')
                                Dimension Sizes(1):
                                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2, IsImplicit) (Syntax: 'new[] { x, y }')
                                Initializer: 
                                  IArrayInitializerOperation (2 elements) (OperationKind.ArrayInitializer, Type: null) (Syntax: '{ x, y }')
                                    Element Values(2):
                                        IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'x')
                                        ILocalReferenceOperation: y (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'y')
                          InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                          OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
          IInvocationOperation ( void System.Collections.Generic.List<System.Collections.Generic.List<System.Int32>>.Add(System.Collections.Generic.List<System.Int32> item)) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'new List<int> { field }')
            Instance Receiver: 
              IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: System.Collections.Generic.List<System.Collections.Generic.List<System.Int32>>, IsImplicit) (Syntax: 'List<List<int>>')
            Arguments(1):
                IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: item) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'new List<int> { field }')
                  IObjectCreationOperation (Constructor: System.Collections.Generic.List<System.Int32>..ctor()) (OperationKind.ObjectCreation, Type: System.Collections.Generic.List<System.Int32>) (Syntax: 'new List<int> { field }')
                    Arguments(0)
                    Initializer: 
                      IObjectOrCollectionInitializerOperation (OperationKind.ObjectOrCollectionInitializer, Type: System.Collections.Generic.List<System.Int32>) (Syntax: '{ field }')
                        Initializers(1):
                            IInvocationOperation ( void System.Collections.Generic.List<System.Int32>.Add(System.Int32 item)) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'field')
                              Instance Receiver: 
                                IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: System.Collections.Generic.List<System.Int32>, IsImplicit) (Syntax: 'List<int>')
                              Arguments(1):
                                  IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: item) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'field')
                                    IFieldReferenceOperation: System.Int32 C.field (OperationKind.FieldReference, Type: System.Int32) (Syntax: 'field')
                                      Instance Receiver: 
                                        IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C, IsImplicit) (Syntax: 'field')
                                    InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                    OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,185968,186021);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,186037,186162);

f_22056_186037_186161(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,178504,186173);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,178504,186173);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,178504,186173);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17588, "https://github.com/dotnet/roslyn/issues/17588")]
        public void ObjectCreationWithMemberAndCollectionInitializers()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,186185,196555);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,186408,186925);

string 
source = @"
using System.Collections.Generic;

internal class Class
{
    public int X { get; set; }
    public List<int> Y { get; set; }
    public Dictionary<int, int> Z { get; set; }
    public Class C { get; set; }

    private readonly int field = 0;

    public void M(int x)
    {
        int y = 0;
        var c = /*<bind>*/new Class() {
            X = x,
            Y = { x, y, 3 },
            Z = { { x, y } },
            C = { X = field }
        }/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,186939,196336);

string 
expectedOperationTree = @"
IObjectCreationOperation (Constructor: Class..ctor()) (OperationKind.ObjectCreation, Type: Class) (Syntax: 'new Class() ... }')
  Arguments(0)
  Initializer: 
    IObjectOrCollectionInitializerOperation (OperationKind.ObjectOrCollectionInitializer, Type: Class) (Syntax: '{ ... }')
      Initializers(4):
          ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'X = x')
            Left: 
              IPropertyReferenceOperation: System.Int32 Class.X { get; set; } (OperationKind.PropertyReference, Type: System.Int32) (Syntax: 'X')
                Instance Receiver: 
                  IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: Class, IsImplicit) (Syntax: 'X')
            Right: 
              IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'x')
          IMemberInitializerOperation (OperationKind.MemberInitializer, Type: System.Collections.Generic.List<System.Int32>) (Syntax: 'Y = { x, y, 3 }')
            InitializedMember: 
              IPropertyReferenceOperation: System.Collections.Generic.List<System.Int32> Class.Y { get; set; } (OperationKind.PropertyReference, Type: System.Collections.Generic.List<System.Int32>) (Syntax: 'Y')
                Instance Receiver: 
                  IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: Class, IsImplicit) (Syntax: 'Y')
            Initializer: 
              IObjectOrCollectionInitializerOperation (OperationKind.ObjectOrCollectionInitializer, Type: System.Collections.Generic.List<System.Int32>) (Syntax: '{ x, y, 3 }')
                Initializers(3):
                    IInvocationOperation ( void System.Collections.Generic.List<System.Int32>.Add(System.Int32 item)) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'x')
                      Instance Receiver: 
                        IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: System.Collections.Generic.List<System.Int32>, IsImplicit) (Syntax: 'Y')
                      Arguments(1):
                          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: item) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'x')
                            IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'x')
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    IInvocationOperation ( void System.Collections.Generic.List<System.Int32>.Add(System.Int32 item)) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'y')
                      Instance Receiver: 
                        IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: System.Collections.Generic.List<System.Int32>, IsImplicit) (Syntax: 'Y')
                      Arguments(1):
                          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: item) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'y')
                            ILocalReferenceOperation: y (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'y')
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    IInvocationOperation ( void System.Collections.Generic.List<System.Int32>.Add(System.Int32 item)) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: '3')
                      Instance Receiver: 
                        IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: System.Collections.Generic.List<System.Int32>, IsImplicit) (Syntax: 'Y')
                      Arguments(1):
                          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: item) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: '3')
                            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
          IMemberInitializerOperation (OperationKind.MemberInitializer, Type: System.Collections.Generic.Dictionary<System.Int32, System.Int32>) (Syntax: 'Z = { { x, y } }')
            InitializedMember: 
              IPropertyReferenceOperation: System.Collections.Generic.Dictionary<System.Int32, System.Int32> Class.Z { get; set; } (OperationKind.PropertyReference, Type: System.Collections.Generic.Dictionary<System.Int32, System.Int32>) (Syntax: 'Z')
                Instance Receiver: 
                  IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: Class, IsImplicit) (Syntax: 'Z')
            Initializer: 
              IObjectOrCollectionInitializerOperation (OperationKind.ObjectOrCollectionInitializer, Type: System.Collections.Generic.Dictionary<System.Int32, System.Int32>) (Syntax: '{ { x, y } }')
                Initializers(1):
                    IInvocationOperation ( void System.Collections.Generic.Dictionary<System.Int32, System.Int32>.Add(System.Int32 key, System.Int32 value)) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: '{ x, y }')
                      Instance Receiver: 
                        IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: System.Collections.Generic.Dictionary<System.Int32, System.Int32>, IsImplicit) (Syntax: 'Z')
                      Arguments(2):
                          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: key) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'x')
                            IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'x')
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: value) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'y')
                            ILocalReferenceOperation: y (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'y')
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
          IMemberInitializerOperation (OperationKind.MemberInitializer, Type: Class) (Syntax: 'C = { X = field }')
            InitializedMember: 
              IPropertyReferenceOperation: Class Class.C { get; set; } (OperationKind.PropertyReference, Type: Class) (Syntax: 'C')
                Instance Receiver: 
                  IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: Class, IsImplicit) (Syntax: 'C')
            Initializer: 
              IObjectOrCollectionInitializerOperation (OperationKind.ObjectOrCollectionInitializer, Type: Class) (Syntax: '{ X = field }')
                Initializers(1):
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'X = field')
                      Left: 
                        IPropertyReferenceOperation: System.Int32 Class.X { get; set; } (OperationKind.PropertyReference, Type: System.Int32) (Syntax: 'X')
                          Instance Receiver: 
                            IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: Class, IsImplicit) (Syntax: 'X')
                      Right: 
                        IFieldReferenceOperation: System.Int32 Class.field (OperationKind.FieldReference, Type: System.Int32) (Syntax: 'field')
                          Instance Receiver: 
                            IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: Class, IsImplicit) (Syntax: 'field')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,196350,196403);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,196419,196544);

f_22056_196419_196543(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,186185,196555);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,186185,196555);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,186185,196555);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17588, "https://github.com/dotnet/roslyn/issues/17588")]
        public void ObjectCreationWithArrayInitializer()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,196567,200109);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,196775,196940);

string 
source = @"
class C
{
    int[] a;

    static void Main()
    {
        var a = /*<bind>*/new C { a = { [0] = 1, [1] = 2 } }/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,196954,199623);

string 
expectedOperationTree = @"
IObjectCreationOperation (Constructor: C..ctor()) (OperationKind.ObjectCreation, Type: C) (Syntax: 'new C { a = ... [1] = 2 } }')
  Arguments(0)
  Initializer: 
    IObjectOrCollectionInitializerOperation (OperationKind.ObjectOrCollectionInitializer, Type: C) (Syntax: '{ a = { [0] ... [1] = 2 } }')
      Initializers(1):
          IMemberInitializerOperation (OperationKind.MemberInitializer, Type: System.Int32[]) (Syntax: 'a = { [0] = 1, [1] = 2 }')
            InitializedMember: 
              IFieldReferenceOperation: System.Int32[] C.a (OperationKind.FieldReference, Type: System.Int32[]) (Syntax: 'a')
                Instance Receiver: 
                  IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: C, IsImplicit) (Syntax: 'a')
            Initializer: 
              IObjectOrCollectionInitializerOperation (OperationKind.ObjectOrCollectionInitializer, Type: System.Int32[]) (Syntax: '{ [0] = 1, [1] = 2 }')
                Initializers(2):
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: '[0] = 1')
                      Left: 
                        IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: System.Int32) (Syntax: '[0]')
                          Array reference: 
                            IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: System.Int32[], IsImplicit) (Syntax: 'a')
                          Indices(1):
                              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
                      Right: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: '[1] = 2')
                      Left: 
                        IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: System.Int32) (Syntax: '[1]')
                          Array reference: 
                            IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: System.Int32[], IsImplicit) (Syntax: 'a')
                          Indices(1):
                              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
                      Right: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,199637,199957);

var 
expectedDiagnostics = new DiagnosticDescription[]
            {
f_22056_199848_199941(f_22056_199848_199921(f_22056_199848_199900(ErrorCode.WRN_UnreferencedFieldAssg, "a"), "C.a"), 4, 11)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,199973,200098);

f_22056_199973_200097(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,196567,200109);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,196567,200109);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,196567,200109);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(22967, "https://github.com/dotnet/roslyn/issues/22967")]
        public void ObjectCreationWithInvalidInitializer()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,200121,202136);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,200331,200474);

string 
source = @"
class C
{
    public void M1()
    {
        var x1 = /*<bind>*/new C() { MissingMember = 1 }/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,200488,201578);

string 
expectedOperationTree = @"
IObjectCreationOperation (Constructor: C..ctor()) (OperationKind.ObjectCreation, Type: C, IsInvalid) (Syntax: 'new C() { M ... ember = 1 }')
  Arguments(0)
  Initializer: 
    IObjectOrCollectionInitializerOperation (OperationKind.ObjectOrCollectionInitializer, Type: C, IsInvalid) (Syntax: '{ MissingMember = 1 }')
      Initializers(1):
          ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: ?, IsInvalid) (Syntax: 'MissingMember = 1')
            Left: 
              IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid, IsImplicit) (Syntax: 'MissingMember')
                Children(1):
                    IOperation:  (OperationKind.None, Type: null, IsInvalid) (Syntax: 'MissingMember')
                      Children(1):
                          IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: C, IsImplicit) (Syntax: 'C')
            Right: 
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,201592,201984);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22056_201857_201968(f_22056_201857_201948(f_22056_201857_201912(ErrorCode.ERR_NoSuchMember, "MissingMember"), "C", "MissingMember"), 6, 38)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,202000,202125);

f_22056_202000_202124(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,200121,202136);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,200121,202136);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,200121,202136);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(22967, "https://github.com/dotnet/roslyn/issues/22967")]
        public void ObjectCreationWithInvalidMemberInitializer()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,202148,205024);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,202364,202513);

string 
source = @"
class C
{
    public void M1()
    {
        var x1 = /*<bind>*/new C(){ MissingField = { x = 1 } }/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,202527,204463);

string 
expectedOperationTree = @"
IObjectCreationOperation (Constructor: C..ctor()) (OperationKind.ObjectCreation, Type: C, IsInvalid) (Syntax: 'new C(){ Mi ... { x = 1 } }')
  Arguments(0)
  Initializer: 
    IObjectOrCollectionInitializerOperation (OperationKind.ObjectOrCollectionInitializer, Type: C, IsInvalid) (Syntax: '{ MissingFi ... { x = 1 } }')
      Initializers(1):
          IMemberInitializerOperation (OperationKind.MemberInitializer, Type: ?, IsInvalid) (Syntax: 'MissingField = { x = 1 }')
            InitializedMember: 
              IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid, IsImplicit) (Syntax: 'MissingField')
                Children(1):
                    IOperation:  (OperationKind.None, Type: null, IsInvalid) (Syntax: 'MissingField')
                      Children(1):
                          IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: C, IsImplicit) (Syntax: 'C')
            Initializer: 
              IObjectOrCollectionInitializerOperation (OperationKind.ObjectOrCollectionInitializer, Type: ?) (Syntax: '{ x = 1 }')
                Initializers(1):
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: ?) (Syntax: 'x = 1')
                      Left: 
                        IInvalidOperation (OperationKind.Invalid, Type: ?, IsImplicit) (Syntax: 'x')
                          Children(1):
                              IOperation:  (OperationKind.None, Type: null) (Syntax: 'x')
                                Children(1):
                                    IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: ?, IsInvalid, IsImplicit) (Syntax: 'MissingField')
                      Right: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,204477,204872);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22056_204747_204856(f_22056_204747_204836(f_22056_204747_204801(ErrorCode.ERR_NoSuchMember, "MissingField"), "C", "MissingField"), 6, 37)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,204888,205013);

f_22056_204888_205012(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,202148,205024);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,202148,205024);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,202148,205024);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(22967, "https://github.com/dotnet/roslyn/issues/22967")]
        public void ObjectCreationWithInvalidCollectionInitializer()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,205036,208678);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,205256,205453);

string 
source = @"
using System.Collections.Generic;

class C
{
    public void M1()
    {
        var x1 = /*<bind>*/new C(){ MissingField = new List<int>() { 1 }}/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,205467,208106);

string 
expectedOperationTree = @"
IObjectCreationOperation (Constructor: C..ctor()) (OperationKind.ObjectCreation, Type: C, IsInvalid) (Syntax: 'new C(){ Mi ... t>() { 1 }}')
  Arguments(0)
  Initializer: 
    IObjectOrCollectionInitializerOperation (OperationKind.ObjectOrCollectionInitializer, Type: C, IsInvalid) (Syntax: '{ MissingFi ... t>() { 1 }}')
      Initializers(1):
          ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: ?, IsInvalid) (Syntax: 'MissingFiel ... nt>() { 1 }')
            Left: 
              IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid, IsImplicit) (Syntax: 'MissingField')
                Children(1):
                    IOperation:  (OperationKind.None, Type: null, IsInvalid) (Syntax: 'MissingField')
                      Children(1):
                          IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: C, IsImplicit) (Syntax: 'C')
            Right: 
              IObjectCreationOperation (Constructor: System.Collections.Generic.List<System.Int32>..ctor()) (OperationKind.ObjectCreation, Type: System.Collections.Generic.List<System.Int32>) (Syntax: 'new List<int>() { 1 }')
                Arguments(0)
                Initializer: 
                  IObjectOrCollectionInitializerOperation (OperationKind.ObjectOrCollectionInitializer, Type: System.Collections.Generic.List<System.Int32>) (Syntax: '{ 1 }')
                    Initializers(1):
                        IInvocationOperation ( void System.Collections.Generic.List<System.Int32>.Add(System.Int32 item)) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: '1')
                          Instance Receiver: 
                            IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: System.Collections.Generic.List<System.Int32>, IsImplicit) (Syntax: 'List<int>')
                          Arguments(1):
                              IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: item) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: '1')
                                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
                                InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,208120,208526);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22056_208401_208510(f_22056_208401_208490(f_22056_208401_208455(ErrorCode.ERR_NoSuchMember, "MissingField"), "C", "MissingField"), 8, 37)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,208542,208667);

f_22056_208542_208666(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,205036,208678);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,205036,208678);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,205036,208678);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        [WorkItem(23154, "https://github.com/dotnet/roslyn/issues/23154")]
        public void ObjectCreationWithDynamicMemberInitializer_01()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,208690,212468);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,208919,209373);

string 
source = @"
#pragma warning disable 0169
class A
{
    dynamic this[int x, int y]
    {
        get
        {
            return new A();
        }
    }

    dynamic this[string x, string y]
    {
        get
        {
            throw null;
        }
    }

    int X, Y, Z;

    static void Main()
    {
        dynamic x = 1;
        new A {/*<bind>*/[y: x, x: x] = { X = 1, Y = 1, Z = 1 }/*</bind>*/ };
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,209387,212253);

string 
expectedOperationTree = @"
IMemberInitializerOperation (OperationKind.MemberInitializer, Type: dynamic) (Syntax: '[y: x, x: x ...  1, Z = 1 }')
  InitializedMember: 
    IDynamicIndexerAccessOperation (OperationKind.DynamicIndexerAccess, Type: dynamic) (Syntax: '[y: x, x: x]')
      Expression: 
        IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: A, IsImplicit) (Syntax: '[y: x, x: x]')
      Arguments(2):
          ILocalReferenceOperation: x (OperationKind.LocalReference, Type: dynamic) (Syntax: 'x')
          ILocalReferenceOperation: x (OperationKind.LocalReference, Type: dynamic) (Syntax: 'x')
      ArgumentNames(2):
        ""y""
        ""x""
      ArgumentRefKinds(0)
  Initializer: 
    IObjectOrCollectionInitializerOperation (OperationKind.ObjectOrCollectionInitializer, Type: dynamic) (Syntax: '{ X = 1, Y = 1, Z = 1 }')
      Initializers(3):
          ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: dynamic) (Syntax: 'X = 1')
            Left: 
              IDynamicMemberReferenceOperation (Member Name: ""X"", Containing Type: dynamic) (OperationKind.DynamicMemberReference, Type: dynamic) (Syntax: 'X')
                Type Arguments(0)
                Instance Receiver: 
                  IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: dynamic, IsImplicit) (Syntax: 'X')
            Right: 
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
          ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: dynamic) (Syntax: 'Y = 1')
            Left: 
              IDynamicMemberReferenceOperation (Member Name: ""Y"", Containing Type: dynamic) (OperationKind.DynamicMemberReference, Type: dynamic) (Syntax: 'Y')
                Type Arguments(0)
                Instance Receiver: 
                  IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: dynamic, IsImplicit) (Syntax: 'Y')
            Right: 
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
          ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: dynamic) (Syntax: 'Z = 1')
            Left: 
              IDynamicMemberReferenceOperation (Member Name: ""Z"", Containing Type: dynamic) (OperationKind.DynamicMemberReference, Type: dynamic) (Syntax: 'Z')
                Type Arguments(0)
                Instance Receiver: 
                  IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: dynamic, IsImplicit) (Syntax: 'Z')
            Right: 
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,212267,212320);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,212336,212457);

f_22056_212336_212456(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,208690,212468);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,208690,212468);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,208690,212468);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        [WorkItem(23154, "https://github.com/dotnet/roslyn/issues/23154")]
        public void ObjectCreationWithDynamicMemberInitializer_02()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,212480,214288);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,212709,213143);

string 
source = @"
#pragma warning disable 0169
class A
{
    dynamic this[int x, int y]
    {
        get
        {
            return new A();
        }
    }

    dynamic this[string x, string y]
    {
        get
        {
            throw null;
        }
    }

    int X, Y, Z;

    static void Main()
    {
        dynamic x = 1;
        new A {/*<bind>*/[y: x, x: x] = { }/*</bind>*/ };
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,213157,214073);

string 
expectedOperationTree = @"
IMemberInitializerOperation (OperationKind.MemberInitializer, Type: dynamic) (Syntax: '[y: x, x: x] = { }')
  InitializedMember: 
    IDynamicIndexerAccessOperation (OperationKind.DynamicIndexerAccess, Type: dynamic) (Syntax: '[y: x, x: x]')
      Expression: 
        IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: A, IsImplicit) (Syntax: '[y: x, x: x]')
      Arguments(2):
          ILocalReferenceOperation: x (OperationKind.LocalReference, Type: dynamic) (Syntax: 'x')
          ILocalReferenceOperation: x (OperationKind.LocalReference, Type: dynamic) (Syntax: 'x')
      ArgumentNames(2):
        ""y""
        ""x""
      ArgumentRefKinds(0)
  Initializer: 
    IObjectOrCollectionInitializerOperation (OperationKind.ObjectOrCollectionInitializer, Type: dynamic) (Syntax: '{ }')
      Initializers(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,214087,214140);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,214156,214277);

f_22056_214156_214276(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,212480,214288);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,212480,214288);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,212480,214288);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        [WorkItem(23154, "https://github.com/dotnet/roslyn/issues/23154")]
        public void ObjectCreationWithDynamicMemberInitializer_03()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,214300,215764);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,214529,214963);

string 
source = @"
#pragma warning disable 0169
class A
{
    dynamic this[int x, int y]
    {
        get
        {
            return new A();
        }
    }

    dynamic this[string x, string y]
    {
        get
        {
            throw null;
        }
    }

    int X, Y, Z;

    static void Main()
    {
        dynamic x = 1;
        new A {/*<bind>*/[y: x, x: x]/*</bind>*/ = { } };
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,214977,215559);

string 
expectedOperationTree = @"
IDynamicIndexerAccessOperation (OperationKind.DynamicIndexerAccess, Type: dynamic) (Syntax: '[y: x, x: x]')
  Expression: 
    IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: A, IsImplicit) (Syntax: '[y: x, x: x]')
  Arguments(2):
      ILocalReferenceOperation: x (OperationKind.LocalReference, Type: dynamic) (Syntax: 'x')
      ILocalReferenceOperation: x (OperationKind.LocalReference, Type: dynamic) (Syntax: 'x')
  ArgumentNames(2):
    ""y""
    ""x""
  ArgumentRefKinds(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,215573,215626);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,215642,215753);

f_22056_215642_215752(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,214300,215764);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,214300,215764);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,214300,215764);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ObjectCreationDynamicCollectionInitializer()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,215776,217615);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,215926,216307);

string 
source = @"
using System.Collections;
using System.Collections.Generic;

class C1 : IEnumerable<int>
{
    public static void M(C1 c, dynamic d1)
    {
        c = /*<bind>*/new C1 { d1 }/*</bind>*/;
    }
    public IEnumerator<int> GetEnumerator() => throw null;
    IEnumerator IEnumerable.GetEnumerator() => throw null;
    public void Add(int c2) { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,216321,216374);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,216390,217465);

string 
expectedOperationTree = @"
IObjectCreationOperation (Constructor: C1..ctor()) (OperationKind.ObjectCreation, Type: C1) (Syntax: 'new C1 { d1 }')
  Arguments(0)
  Initializer: 
    IObjectOrCollectionInitializerOperation (OperationKind.ObjectOrCollectionInitializer, Type: C1) (Syntax: '{ d1 }')
      Initializers(1):
          IDynamicInvocationOperation (OperationKind.DynamicInvocation, Type: dynamic, IsImplicit) (Syntax: 'd1')
            Expression: 
              IDynamicMemberReferenceOperation (Member Name: ""Add"", Containing Type: null) (OperationKind.DynamicMemberReference, Type: null, IsImplicit) (Syntax: 'C1')
                Type Arguments(0)
                Instance Receiver: 
                  IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: C1, IsImplicit) (Syntax: 'C1')
            Arguments(1):
                IParameterReferenceOperation: d1 (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'd1')
            ArgumentNames(0)
            ArgumentRefKinds(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,217479,217604);

f_22056_217479_217603(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,215776,217615);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,215776,217615);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,215776,217615);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ObjectCreationCollectionInitializerWithRefAddMethod()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,217627,220682);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,217786,218282);

string 
source = @"
using System;
using System.Collections;
using System.Collections.Generic;

class C : IEnumerable<int>
{
    public static void M()
    {
        var c = new C /*<bind>*/{ 1, 2, 3 }/*</bind>*/;
    }

    public IEnumerator<int> GetEnumerator()
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
    }

    public void Add(ref int i)
    {
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,218296,219204);

string 
expectedOperationTree = @"
IObjectOrCollectionInitializerOperation (OperationKind.ObjectOrCollectionInitializer, Type: C, IsInvalid) (Syntax: '{ 1, 2, 3 }')
  Initializers(3):
      IInvalidOperation (OperationKind.Invalid, Type: System.Void, IsInvalid, IsImplicit) (Syntax: '1')
        Children(1):
            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1, IsInvalid) (Syntax: '1')
      IInvalidOperation (OperationKind.Invalid, Type: System.Void, IsInvalid, IsImplicit) (Syntax: '2')
        Children(1):
            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2, IsInvalid) (Syntax: '2')
      IInvalidOperation (OperationKind.Invalid, Type: System.Void, IsInvalid, IsImplicit) (Syntax: '3')
        Children(1):
            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3, IsInvalid) (Syntax: '3')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,219218,220533);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22056_219572_219687(f_22056_219572_219666(f_22056_219572_219634(ErrorCode.ERR_InitializerAddHasParamModifiers, "1"), "C.Add(ref int)"), 10, 35),
f_22056_219987_220102(f_22056_219987_220081(f_22056_219987_220049(ErrorCode.ERR_InitializerAddHasParamModifiers, "2"), "C.Add(ref int)"), 10, 38),
f_22056_220402_220517(f_22056_220402_220496(f_22056_220402_220464(ErrorCode.ERR_InitializerAddHasParamModifiers, "3"), "C.Add(ref int)"), 10, 41)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,220549,220671);

f_22056_220549_220670(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,217627,220682);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,217627,220682);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,217627,220682);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ObjectCreationCollectionInitializerWithDefaultParameterAddMethod()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,220694,226324);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,220866,221375);

string 
source = @"
using System;
using System.Collections;
using System.Collections.Generic;

class C : IEnumerable<int>
{
    public static void M()
    {
        var c = new C /*<bind>*/{ 1, 2, 3 }/*</bind>*/;
    }

    public IEnumerator<int> GetEnumerator()
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
    }

    public void Add(int i, object o = null)
    {
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,221389,226108);

string 
expectedOperationTree = @"
IObjectOrCollectionInitializerOperation (OperationKind.ObjectOrCollectionInitializer, Type: C) (Syntax: '{ 1, 2, 3 }')
  Initializers(3):
      IInvocationOperation ( void C.Add(System.Int32 i, [System.Object o = null])) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: '1')
        Instance Receiver: 
          IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: C, IsImplicit) (Syntax: 'C')
        Arguments(2):
            IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: '1')
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
              InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
              OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            IArgumentOperation (ArgumentKind.DefaultValue, Matching Parameter: o) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: '1')
              IDefaultValueOperation (OperationKind.DefaultValue, Type: System.Object, Constant: null, IsImplicit) (Syntax: '1')
              InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
              OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      IInvocationOperation ( void C.Add(System.Int32 i, [System.Object o = null])) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: '2')
        Instance Receiver: 
          IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: C, IsImplicit) (Syntax: 'C')
        Arguments(2):
            IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: '2')
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
              InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
              OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            IArgumentOperation (ArgumentKind.DefaultValue, Matching Parameter: o) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: '2')
              IDefaultValueOperation (OperationKind.DefaultValue, Type: System.Object, Constant: null, IsImplicit) (Syntax: '2')
              InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
              OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      IInvocationOperation ( void C.Add(System.Int32 i, [System.Object o = null])) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: '3')
        Instance Receiver: 
          IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: C, IsImplicit) (Syntax: 'C')
        Arguments(2):
            IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: '3')
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')
              InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
              OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            IArgumentOperation (ArgumentKind.DefaultValue, Matching Parameter: o) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: '3')
              IDefaultValueOperation (OperationKind.DefaultValue, Type: System.Object, Constant: null, IsImplicit) (Syntax: '3')
              InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
              OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,226122,226175);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,226191,226313);

f_22056_226191_226312(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,220694,226324);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,220694,226324);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,220694,226324);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ObjectCreationCollectionInitializerWithParamsAddMethod()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,226336,231580);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,226498,226988);

string 
source = @"
using System.Collections;
using System.Collections.Generic;

class C : IEnumerable<int>
{
    void M(C c)
    {
        c = new C() /*<bind>*/{ 1, 2, 3 }/*</bind>*/;
    }

    public void Add(params int[] ints)
    {
    }

    public IEnumerator<int> GetEnumerator()
    {
        throw new System.NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new System.NotImplementedException();
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,227002,227055);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,227071,231433);

string 
expectedOperationTree = @"
IObjectOrCollectionInitializerOperation (OperationKind.ObjectOrCollectionInitializer, Type: C) (Syntax: '{ 1, 2, 3 }')
  Initializers(3):
      IInvocationOperation ( void C.Add(params System.Int32[] ints)) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: '1')
        Instance Receiver: 
          IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: C, IsImplicit) (Syntax: 'C')
        Arguments(1):
            IArgumentOperation (ArgumentKind.ParamArray, Matching Parameter: ints) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: '1')
              IArrayCreationOperation (OperationKind.ArrayCreation, Type: System.Int32[], IsImplicit) (Syntax: '1')
                Dimension Sizes(1):
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1, IsImplicit) (Syntax: '1')
                Initializer: 
                  IArrayInitializerOperation (1 elements) (OperationKind.ArrayInitializer, Type: null, IsImplicit) (Syntax: '1')
                    Element Values(1):
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
              InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
              OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      IInvocationOperation ( void C.Add(params System.Int32[] ints)) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: '2')
        Instance Receiver: 
          IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: C, IsImplicit) (Syntax: 'C')
        Arguments(1):
            IArgumentOperation (ArgumentKind.ParamArray, Matching Parameter: ints) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: '2')
              IArrayCreationOperation (OperationKind.ArrayCreation, Type: System.Int32[], IsImplicit) (Syntax: '2')
                Dimension Sizes(1):
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1, IsImplicit) (Syntax: '2')
                Initializer: 
                  IArrayInitializerOperation (1 elements) (OperationKind.ArrayInitializer, Type: null, IsImplicit) (Syntax: '2')
                    Element Values(1):
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
              InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
              OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      IInvocationOperation ( void C.Add(params System.Int32[] ints)) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: '3')
        Instance Receiver: 
          IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: C, IsImplicit) (Syntax: 'C')
        Arguments(1):
            IArgumentOperation (ArgumentKind.ParamArray, Matching Parameter: ints) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: '3')
              IArrayCreationOperation (OperationKind.ArrayCreation, Type: System.Int32[], IsImplicit) (Syntax: '3')
                Dimension Sizes(1):
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1, IsImplicit) (Syntax: '3')
                Initializer: 
                  IArrayInitializerOperation (1 elements) (OperationKind.ArrayInitializer, Type: null, IsImplicit) (Syntax: '3')
                    Element Values(1):
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')
              InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
              OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,231447,231569);

f_22056_231447_231568(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,226336,231580);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,226336,231580);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,226336,231580);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ObjectCreationCollectionInitializerExtensionAddMethod()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,231592,236864);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,231753,232278);

string 
source = @"
using System.Collections;
using System.Collections.Generic;

class C : IEnumerable<int>
{
    void M(C c)
    {
        c = new C() /*<bind>*/{ 1, 2, 3 }/*</bind>*/;
    }
    public IEnumerator<int> GetEnumerator()
    {
        throw new System.NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new System.NotImplementedException();
    }
}

static class CExtensions
{
    public static void Add(this C c, int i)
    {
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,232292,232345);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,232361,236717);

string 
expectedOperationTree = @"
IObjectOrCollectionInitializerOperation (OperationKind.ObjectOrCollectionInitializer, Type: C) (Syntax: '{ 1, 2, 3 }')
  Initializers(3):
      IInvocationOperation (void CExtensions.Add(this C c, System.Int32 i)) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: '1')
        Instance Receiver: 
          null
        Arguments(2):
            IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: c) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'C')
              IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: C, IsImplicit) (Syntax: 'C')
              InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
              OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: '1')
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
              InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
              OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      IInvocationOperation (void CExtensions.Add(this C c, System.Int32 i)) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: '2')
        Instance Receiver: 
          null
        Arguments(2):
            IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: c) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'C')
              IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: C, IsImplicit) (Syntax: 'C')
              InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
              OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: '2')
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
              InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
              OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      IInvocationOperation (void CExtensions.Add(this C c, System.Int32 i)) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: '3')
        Instance Receiver: 
          null
        Arguments(2):
            IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: c) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'C')
              IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: C, IsImplicit) (Syntax: 'C')
              InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
              OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: '3')
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')
              InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
              OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,236731,236853);

f_22056_236731_236852(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,231592,236864);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,231592,236864);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,231592,236864);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ObjectCreationCollectionInitializerStaticAddMethod()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,236876,239870);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,237034,237533);

string 
source = @"
using System;
using System.Collections;
using System.Collections.Generic;

class C : IEnumerable<int>
{
    public static void M()
    {
        var c = new C /*<bind>*/{ 1, 2, 3 }/*</bind>*/;
    }

    public IEnumerator<int> GetEnumerator()
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
    }

    public static void Add(int i)
    {
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,237547,238799);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22056_237884_237995(f_22056_237884_237974(f_22056_237884_237946(ErrorCode.ERR_InitializerAddHasWrongSignature, "1"), "C.Add(int)"), 10, 35),
f_22056_238278_238389(f_22056_238278_238368(f_22056_238278_238340(ErrorCode.ERR_InitializerAddHasWrongSignature, "2"), "C.Add(int)"), 10, 38),
f_22056_238672_238783(f_22056_238672_238762(f_22056_238672_238734(ErrorCode.ERR_InitializerAddHasWrongSignature, "3"), "C.Add(int)"), 10, 41)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,238815,239723);

string 
expectedOperationTree = @"
IObjectOrCollectionInitializerOperation (OperationKind.ObjectOrCollectionInitializer, Type: C, IsInvalid) (Syntax: '{ 1, 2, 3 }')
  Initializers(3):
      IInvalidOperation (OperationKind.Invalid, Type: System.Void, IsInvalid, IsImplicit) (Syntax: '1')
        Children(1):
            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1, IsInvalid) (Syntax: '1')
      IInvalidOperation (OperationKind.Invalid, Type: System.Void, IsInvalid, IsImplicit) (Syntax: '2')
        Children(1):
            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2, IsInvalid) (Syntax: '2')
      IInvalidOperation (OperationKind.Invalid, Type: System.Void, IsInvalid, IsImplicit) (Syntax: '3')
        Children(1):
            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3, IsInvalid) (Syntax: '3')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,239737,239859);

f_22056_239737_239858(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,236876,239870);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,236876,239870);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,236876,239870);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ObjectCreationCollectionInitializerAddMethodOnInterface()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,239882,243683);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,240045,240492);

string 
source = @"
using System.Collections.Generic;
using System.Runtime.InteropServices;

[ComImport()]
[CoClass(typeof(CoClassImplementation))]
[Guid(""f9c2d51d-4f44-45f0-9eda-c9d599b58257"")]
public interface IInterface : IEnumerable<int>
{
    void Add(int i);
}

public class CoClassImplementation
{
}

class C
{
    void M()
    {
        var iinterface = new IInterface() /*<bind>*/{ 1, 2, 3 }/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,240506,240559);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,240575,243536);

string 
expectedOperationTree = @"
IObjectOrCollectionInitializerOperation (OperationKind.ObjectOrCollectionInitializer, Type: IInterface) (Syntax: '{ 1, 2, 3 }')
  Initializers(3):
      IInvocationOperation (virtual void IInterface.Add(System.Int32 i)) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: '1')
        Instance Receiver: 
          IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: IInterface, IsImplicit) (Syntax: 'IInterface')
        Arguments(1):
            IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: '1')
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
              InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
              OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      IInvocationOperation (virtual void IInterface.Add(System.Int32 i)) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: '2')
        Instance Receiver: 
          IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: IInterface, IsImplicit) (Syntax: 'IInterface')
        Arguments(1):
            IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: '2')
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
              InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
              OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      IInvocationOperation (virtual void IInterface.Add(System.Int32 i)) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: '3')
        Instance Receiver: 
          IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: IInterface, IsImplicit) (Syntax: 'IInterface')
        Arguments(1):
            IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: '3')
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')
              InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
              OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,243550,243672);

f_22056_243550_243671(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,239882,243683);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,239882,243683);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,239882,243683);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ObjectCreationCollectionInitializerBoxingConversion()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,243695,248296);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,243854,244150);

string 
source = @"
using System.Collections;
struct S : IEnumerable
{
    IEnumerator IEnumerable.GetEnumerator() => null;
}
static class Program
{
    static void Add(this object x, int y) { }
    static void Main()
    {
        _ = /*<bind>*/new S() { 1, 2 }/*</bind>*/;
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,244164,244217);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,244231,248146);

string 
expectedOperationTree = @"
IObjectCreationOperation (Constructor: S..ctor()) (OperationKind.ObjectCreation, Type: S) (Syntax: 'new S() { 1, 2 }')
  Arguments(0)
  Initializer: 
    IObjectOrCollectionInitializerOperation (OperationKind.ObjectOrCollectionInitializer, Type: S) (Syntax: '{ 1, 2 }')
      Initializers(2):
          IInvocationOperation (void Program.Add(this System.Object x, System.Int32 y)) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: '1')
            Instance Receiver: 
              null
            Arguments(2):
                IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: x) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'S')
                  IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsImplicit) (Syntax: 'S')
                    Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    Operand: 
                      IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: S, IsImplicit) (Syntax: 'S')
                  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: y) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: '1')
                  ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
                  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
          IInvocationOperation (void Program.Add(this System.Object x, System.Int32 y)) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: '2')
            Instance Receiver: 
              null
            Arguments(2):
                IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: x) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'S')
                  IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsImplicit) (Syntax: 'S')
                    Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    Operand: 
                      IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: S, IsImplicit) (Syntax: 'S')
                  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: y) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: '2')
                  ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
                  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,248160,248285);

f_22056_248160_248284(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,243695,248296);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,243695,248296);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,243695,248296);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ObjectCreationNestedObjectInitializerNoSet()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,248308,250957);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,248458,248679);

string 
source = @"
class C1
{
    void M(C1 c1)
    {
        c1 = new C1() /*<bind>*/{ [1] = { A = 1 } }/*</bind>*/;
    }
    C2 this[int i] { get => null; }
}
class C2
{
    public int A { get; set; }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,248693,248746);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,248762,250810);

string 
expectedOperationTree = @"
IObjectOrCollectionInitializerOperation (OperationKind.ObjectOrCollectionInitializer, Type: C1) (Syntax: '{ [1] = { A = 1 } }')
  Initializers(1):
      IMemberInitializerOperation (OperationKind.MemberInitializer, Type: C2) (Syntax: '[1] = { A = 1 }')
        InitializedMember: 
          IPropertyReferenceOperation: C2 C1.this[System.Int32 i] { get; } (OperationKind.PropertyReference, Type: C2) (Syntax: '[1]')
            Instance Receiver: 
              IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: C1, IsImplicit) (Syntax: '[1]')
            Arguments(1):
                IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: '1')
                  ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
                  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Initializer: 
          IObjectOrCollectionInitializerOperation (OperationKind.ObjectOrCollectionInitializer, Type: C2) (Syntax: '{ A = 1 }')
            Initializers(1):
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'A = 1')
                  Left: 
                    IPropertyReferenceOperation: System.Int32 C2.A { get; set; } (OperationKind.PropertyReference, Type: System.Int32) (Syntax: 'A')
                      Instance Receiver: 
                        IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: C2, IsImplicit) (Syntax: 'A')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,250824,250946);

f_22056_250824_250945(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,248308,250957);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,248308,250957);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,248308,250957);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ObjectCreationNestedCollectionInitializerNoSet()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,250969,254220);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,251123,251607);

string 
source = @"
using System.Collections;
using System.Collections.Generic;

class C1
{
    void M(C1 c1)
    {
        c1 = new C1() /*<bind>*/{ [1] = { 1 } }/*</bind>*/;
    }
    C2 this[int i] { get => null; }
}
class C2 : IEnumerable<int>
{
    public IEnumerator<int> GetEnumerator() => throw new System.NotImplementedException();
    IEnumerator IEnumerable.GetEnumerator() => throw new System.NotImplementedException();
    public void Add(int i) { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,251621,251674);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,251690,254073);

string 
expectedOperationTree = @"
IObjectOrCollectionInitializerOperation (OperationKind.ObjectOrCollectionInitializer, Type: C1) (Syntax: '{ [1] = { 1 } }')
  Initializers(1):
      IMemberInitializerOperation (OperationKind.MemberInitializer, Type: C2) (Syntax: '[1] = { 1 }')
        InitializedMember: 
          IPropertyReferenceOperation: C2 C1.this[System.Int32 i] { get; } (OperationKind.PropertyReference, Type: C2) (Syntax: '[1]')
            Instance Receiver: 
              IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: C1, IsImplicit) (Syntax: '[1]')
            Arguments(1):
                IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: '1')
                  ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
                  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Initializer: 
          IObjectOrCollectionInitializerOperation (OperationKind.ObjectOrCollectionInitializer, Type: C2) (Syntax: '{ 1 }')
            Initializers(1):
                IInvocationOperation ( void C2.Add(System.Int32 i)) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: '1')
                  Instance Receiver: 
                    IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: C2, IsImplicit) (Syntax: '[1]')
                  Arguments(1):
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: '1')
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,254087,254209);

f_22056_254087_254208(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,250969,254220);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,250969,254220);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,250969,254220);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ObjectCreationFlow_01()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,254232,259204);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,254387,254594);

string 
source = @"
public class MyClass
{
    public MyClass(int i1, int i2, int i3) { }
    static void M(bool b)
    /*<bind>*/{
        var c = new MyClass(1, 2, b ? 3 : 4);
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,254608,254661);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,254677,259081);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [MyClass c]
    CaptureIds: [0] [1] [2]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (2)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '1')
              Value: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '2')
              Value: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')

        Jump if False (Regular) to Block[B3]
            IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '3')
              Value: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')

        Next (Regular) Block[B4]
    Block[B3] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '4')
              Value: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 4) (Syntax: '4')

        Next (Regular) Block[B4]
    Block[B4] - Block
        Predecessors: [B2] [B3]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: MyClass, IsImplicit) (Syntax: 'c = new MyC ...  b ? 3 : 4)')
              Left: 
                ILocalReferenceOperation: c (IsDeclaration: True) (OperationKind.LocalReference, Type: MyClass, IsImplicit) (Syntax: 'c = new MyC ...  b ? 3 : 4)')
              Right: 
                IObjectCreationOperation (Constructor: MyClass..ctor(System.Int32 i1, System.Int32 i2, System.Int32 i3)) (OperationKind.ObjectCreation, Type: MyClass) (Syntax: 'new MyClass ...  b ? 3 : 4)')
                  Arguments(3):
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i1) (OperationKind.Argument, Type: null) (Syntax: '1')
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, Constant: 1, IsImplicit) (Syntax: '1')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i2) (OperationKind.Argument, Type: null) (Syntax: '2')
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32, Constant: 2, IsImplicit) (Syntax: '2')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i3) (OperationKind.Argument, Type: null) (Syntax: 'b ? 3 : 4')
                        IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'b ? 3 : 4')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  Initializer: 
                    null

        Next (Regular) Block[B5]
            Leaving: {R1}
}

Block[B5] - Exit
    Predecessors: [B4]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,259095,259193);

f_22056_259095_259192(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,254232,259204);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,254232,259204);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,254232,259204);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ObjectCreationFlow_02()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,259216,264212);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,259371,259590);

string 
source = @"
public class MyClass
{
    public MyClass(int i1, int i2, int i3) { }
    static void M(bool b)
    /*<bind>*/{
        var c = new MyClass(i1: 1, i2: 2, i3: b ? 3 : 4);
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,259604,259657);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,259673,264089);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [MyClass c]
    CaptureIds: [0] [1] [2]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (2)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '1')
              Value: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '2')
              Value: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')

        Jump if False (Regular) to Block[B3]
            IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '3')
              Value: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')

        Next (Regular) Block[B4]
    Block[B3] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '4')
              Value: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 4) (Syntax: '4')

        Next (Regular) Block[B4]
    Block[B4] - Block
        Predecessors: [B2] [B3]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: MyClass, IsImplicit) (Syntax: 'c = new MyC ...  b ? 3 : 4)')
              Left: 
                ILocalReferenceOperation: c (IsDeclaration: True) (OperationKind.LocalReference, Type: MyClass, IsImplicit) (Syntax: 'c = new MyC ...  b ? 3 : 4)')
              Right: 
                IObjectCreationOperation (Constructor: MyClass..ctor(System.Int32 i1, System.Int32 i2, System.Int32 i3)) (OperationKind.ObjectCreation, Type: MyClass) (Syntax: 'new MyClass ...  b ? 3 : 4)')
                  Arguments(3):
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i1) (OperationKind.Argument, Type: null) (Syntax: 'i1: 1')
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, Constant: 1, IsImplicit) (Syntax: '1')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i2) (OperationKind.Argument, Type: null) (Syntax: 'i2: 2')
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32, Constant: 2, IsImplicit) (Syntax: '2')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i3) (OperationKind.Argument, Type: null) (Syntax: 'i3: b ? 3 : 4')
                        IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'b ? 3 : 4')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  Initializer: 
                    null

        Next (Regular) Block[B5]
            Leaving: {R1}
}

Block[B5] - Exit
    Predecessors: [B4]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,264103,264201);

f_22056_264103_264200(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,259216,264212);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,259216,264212);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,259216,264212);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ObjectCreationFlow_03()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,264224,269220);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,264379,264598);

string 
source = @"
public class MyClass
{
    public MyClass(int i1, int i2, int i3) { }
    static void M(bool b)
    /*<bind>*/{
        var c = new MyClass(i3: 3, i2: 2, i1: b ? 1 : 4);
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,264612,264665);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,264681,269097);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [MyClass c]
    CaptureIds: [0] [1] [2]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (2)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '3')
              Value: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '2')
              Value: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')

        Jump if False (Regular) to Block[B3]
            IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '1')
              Value: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

        Next (Regular) Block[B4]
    Block[B3] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '4')
              Value: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 4) (Syntax: '4')

        Next (Regular) Block[B4]
    Block[B4] - Block
        Predecessors: [B2] [B3]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: MyClass, IsImplicit) (Syntax: 'c = new MyC ...  b ? 1 : 4)')
              Left: 
                ILocalReferenceOperation: c (IsDeclaration: True) (OperationKind.LocalReference, Type: MyClass, IsImplicit) (Syntax: 'c = new MyC ...  b ? 1 : 4)')
              Right: 
                IObjectCreationOperation (Constructor: MyClass..ctor(System.Int32 i1, System.Int32 i2, System.Int32 i3)) (OperationKind.ObjectCreation, Type: MyClass) (Syntax: 'new MyClass ...  b ? 1 : 4)')
                  Arguments(3):
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i3) (OperationKind.Argument, Type: null) (Syntax: 'i3: 3')
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, Constant: 3, IsImplicit) (Syntax: '3')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i2) (OperationKind.Argument, Type: null) (Syntax: 'i2: 2')
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32, Constant: 2, IsImplicit) (Syntax: '2')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i1) (OperationKind.Argument, Type: null) (Syntax: 'i1: b ? 1 : 4')
                        IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'b ? 1 : 4')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  Initializer: 
                    null

        Next (Regular) Block[B5]
            Leaving: {R1}
}

Block[B5] - Exit
    Predecessors: [B4]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,269111,269209);

f_22056_269111_269208(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,264224,269220);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,264224,269220);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,264224,269220);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ObjectCreationFlow_04()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,269232,274027);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,269387,269603);

string 
source = @"
public class MyClass
{
    public MyClass(int i1, int i2, int i3 = 0) { }
    static void M(bool b)
    /*<bind>*/{
        var c = new MyClass(i1: 1, i2: b ? 2 : 3);
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,269617,269670);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,269686,273904);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [MyClass c]
    CaptureIds: [0] [1]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '1')
              Value: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

        Jump if False (Regular) to Block[B3]
            IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '2')
              Value: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')

        Next (Regular) Block[B4]
    Block[B3] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '3')
              Value: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')

        Next (Regular) Block[B4]
    Block[B4] - Block
        Predecessors: [B2] [B3]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: MyClass, IsImplicit) (Syntax: 'c = new MyC ...  b ? 2 : 3)')
              Left: 
                ILocalReferenceOperation: c (IsDeclaration: True) (OperationKind.LocalReference, Type: MyClass, IsImplicit) (Syntax: 'c = new MyC ...  b ? 2 : 3)')
              Right: 
                IObjectCreationOperation (Constructor: MyClass..ctor(System.Int32 i1, System.Int32 i2, [System.Int32 i3 = 0])) (OperationKind.ObjectCreation, Type: MyClass) (Syntax: 'new MyClass ...  b ? 2 : 3)')
                  Arguments(3):
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i1) (OperationKind.Argument, Type: null) (Syntax: 'i1: 1')
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, Constant: 1, IsImplicit) (Syntax: '1')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i2) (OperationKind.Argument, Type: null) (Syntax: 'i2: b ? 2 : 3')
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'b ? 2 : 3')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                      IArgumentOperation (ArgumentKind.DefaultValue, Matching Parameter: i3) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'new MyClass ...  b ? 2 : 3)')
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0, IsImplicit) (Syntax: 'new MyClass ...  b ? 2 : 3)')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  Initializer: 
                    null

        Next (Regular) Block[B5]
            Leaving: {R1}
}

Block[B5] - Exit
    Predecessors: [B4]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,273918,274016);

f_22056_273918_274015(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,269232,274027);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,269232,274027);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,269232,274027);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ObjectCreationFlow_05()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,274039,276468);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,274194,274403);

string 
source = @"
public class MyClass
{
    public int A { get; set; }
    static void M()
    /*<bind>*/{
        var a = new MyClass
        {
            A = 1
        };
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,274417,274470);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,274486,276345);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [MyClass a]
    CaptureIds: [0]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (3)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new MyClass ... }')
              Value: 
                IObjectCreationOperation (Constructor: MyClass..ctor()) (OperationKind.ObjectCreation, Type: MyClass) (Syntax: 'new MyClass ... }')
                  Arguments(0)
                  Initializer: 
                    null

            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'A = 1')
              Left: 
                IPropertyReferenceOperation: System.Int32 MyClass.A { get; set; } (OperationKind.PropertyReference, Type: System.Int32) (Syntax: 'A')
                  Instance Receiver: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: MyClass, IsImplicit) (Syntax: 'new MyClass ... }')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: MyClass, IsImplicit) (Syntax: 'a = new MyC ... }')
              Left: 
                ILocalReferenceOperation: a (IsDeclaration: True) (OperationKind.LocalReference, Type: MyClass, IsImplicit) (Syntax: 'a = new MyC ... }')
              Right: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: MyClass, IsImplicit) (Syntax: 'new MyClass ... }')

        Next (Regular) Block[B2]
            Leaving: {R1}
}

Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,276359,276457);

f_22056_276359_276456(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,274039,276468);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,274039,276468);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,274039,276468);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ObjectCreationFlow_06()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,276480,281050);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,276635,276910);

string 
source = @"
public class MyClass
{
    public int A { get; set; }
    public int B { get; set; }
    static void M(bool b)
    /*<bind>*/{
        var a = new MyClass
        {
            A = 1,
            B = b ? 2 : 3
        };
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,276924,276977);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,276993,280927);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [MyClass a]
    CaptureIds: [0]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (2)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new MyClass ... }')
              Value: 
                IObjectCreationOperation (Constructor: MyClass..ctor()) (OperationKind.ObjectCreation, Type: MyClass) (Syntax: 'new MyClass ... }')
                  Arguments(0)
                  Initializer: 
                    null

            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'A = 1')
              Left: 
                IPropertyReferenceOperation: System.Int32 MyClass.A { get; set; } (OperationKind.PropertyReference, Type: System.Int32) (Syntax: 'A')
                  Instance Receiver: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: MyClass, IsImplicit) (Syntax: 'new MyClass ... }')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (0)
            Jump if False (Regular) to Block[B4]
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '2')
                  Value: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')

            Next (Regular) Block[B5]
        Block[B4] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '3')
                  Value: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')

            Next (Regular) Block[B5]
        Block[B5] - Block
            Predecessors: [B3] [B4]
            Statements (1)
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'B = b ? 2 : 3')
                  Left: 
                    IPropertyReferenceOperation: System.Int32 MyClass.B { get; set; } (OperationKind.PropertyReference, Type: System.Int32) (Syntax: 'B')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: MyClass, IsImplicit) (Syntax: 'new MyClass ... }')
                  Right: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'b ? 2 : 3')

            Next (Regular) Block[B6]
                Leaving: {R2}
    }

    Block[B6] - Block
        Predecessors: [B5]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: MyClass, IsImplicit) (Syntax: 'a = new MyC ... }')
              Left: 
                ILocalReferenceOperation: a (IsDeclaration: True) (OperationKind.LocalReference, Type: MyClass, IsImplicit) (Syntax: 'a = new MyC ... }')
              Right: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: MyClass, IsImplicit) (Syntax: 'new MyClass ... }')

        Next (Regular) Block[B7]
            Leaving: {R1}
}

Block[B7] - Exit
    Predecessors: [B6]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,280941,281039);

f_22056_280941_281038(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,276480,281050);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,276480,281050);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,276480,281050);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ObjectCreationFlow_07()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,281062,285598);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,281217,281438);

string 
source = @"
public class MyClass
{
    public object A { get; set; }
    static void M(bool b)
    /*<bind>*/{
        var a = new MyClass
        {
            A = 1
        }?.A;
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,281452,281505);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,281521,285475);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2}

.locals {R1}
{
    Locals: [System.Object a]
    CaptureIds: [1]
    .locals {R2}
    {
        CaptureIds: [0]
        Block[B1] - Block
            Predecessors: [B0]
            Statements (2)
                IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new MyClass ... }')
                  Value: 
                    IObjectCreationOperation (Constructor: MyClass..ctor()) (OperationKind.ObjectCreation, Type: MyClass) (Syntax: 'new MyClass ... }')
                      Arguments(0)
                      Initializer: 
                        null

                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Object) (Syntax: 'A = 1')
                  Left: 
                    IPropertyReferenceOperation: System.Object MyClass.A { get; set; } (OperationKind.PropertyReference, Type: System.Object) (Syntax: 'A')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: MyClass, IsImplicit) (Syntax: 'new MyClass ... }')
                  Right: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsImplicit) (Syntax: '1')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (Boxing)
                      Operand: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

            Jump if True (Regular) to Block[B3]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'new MyClass ... }')
                  Operand: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: MyClass, IsImplicit) (Syntax: 'new MyClass ... }')
                Leaving: {R2}

            Next (Regular) Block[B2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '.A')
                  Value: 
                    IPropertyReferenceOperation: System.Object MyClass.A { get; set; } (OperationKind.PropertyReference, Type: System.Object) (Syntax: '.A')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: MyClass, IsImplicit) (Syntax: 'new MyClass ... }')

            Next (Regular) Block[B4]
                Leaving: {R2}
    }

    Block[B3] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new MyClass ... }')
              Value: 
                IDefaultValueOperation (OperationKind.DefaultValue, Type: System.Object, Constant: null, IsImplicit) (Syntax: 'new MyClass ... }')

        Next (Regular) Block[B4]
    Block[B4] - Block
        Predecessors: [B2] [B3]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Object, IsImplicit) (Syntax: 'a = new MyC ... }?.A')
              Left: 
                ILocalReferenceOperation: a (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Object, IsImplicit) (Syntax: 'a = new MyC ... }?.A')
              Right: 
                IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'new MyClass ... }?.A')

        Next (Regular) Block[B5]
            Leaving: {R1}
}

Block[B5] - Exit
    Predecessors: [B4]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,285489,285587);

f_22056_285489_285586(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,281062,285598);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,281062,285598);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,281062,285598);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ObjectCreationFlow_08()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,285610,293884);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,285765,286098);

string 
source = @"
public class MyClass
{
    public MyClass(int a, int b) { }
    public object A { get; set; }
    public object B { get; set; }
    static void M(bool b)
    /*<bind>*/{
        var a = new MyClass(1, b ? 2 : 3)
        {
            A = 1,
            B = b ? 2 : 3
        };
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,286112,286165);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,286181,293761);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2}

.locals {R1}
{
    Locals: [MyClass a]
    CaptureIds: [2]
    .locals {R2}
    {
        CaptureIds: [0] [1]
        Block[B1] - Block
            Predecessors: [B0]
            Statements (1)
                IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '1')
                  Value: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

            Jump if False (Regular) to Block[B3]
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

            Next (Regular) Block[B2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '2')
                  Value: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')

            Next (Regular) Block[B4]
        Block[B3] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '3')
                  Value: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')

            Next (Regular) Block[B4]
        Block[B4] - Block
            Predecessors: [B2] [B3]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new MyClass ... }')
                  Value: 
                    IObjectCreationOperation (Constructor: MyClass..ctor(System.Int32 a, System.Int32 b)) (OperationKind.ObjectCreation, Type: MyClass) (Syntax: 'new MyClass ... }')
                      Arguments(2):
                          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: a) (OperationKind.Argument, Type: null) (Syntax: '1')
                            IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, Constant: 1, IsImplicit) (Syntax: '1')
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: b) (OperationKind.Argument, Type: null) (Syntax: 'b ? 2 : 3')
                            IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'b ? 2 : 3')
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                      Initializer: 
                        null

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B5] - Block
        Predecessors: [B4]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Object) (Syntax: 'A = 1')
              Left: 
                IPropertyReferenceOperation: System.Object MyClass.A { get; set; } (OperationKind.PropertyReference, Type: System.Object) (Syntax: 'A')
                  Instance Receiver: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: MyClass, IsImplicit) (Syntax: 'new MyClass ... }')
              Right: 
                IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsImplicit) (Syntax: '1')
                  Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    (Boxing)
                  Operand: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

        Next (Regular) Block[B6]
            Entering: {R3}

    .locals {R3}
    {
        CaptureIds: [3]
        Block[B6] - Block
            Predecessors: [B5]
            Statements (0)
            Jump if False (Regular) to Block[B8]
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

            Next (Regular) Block[B7]
        Block[B7] - Block
            Predecessors: [B6]
            Statements (1)
                IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '2')
                  Value: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')

            Next (Regular) Block[B9]
        Block[B8] - Block
            Predecessors: [B6]
            Statements (1)
                IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '3')
                  Value: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')

            Next (Regular) Block[B9]
        Block[B9] - Block
            Predecessors: [B7] [B8]
            Statements (1)
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Object) (Syntax: 'B = b ? 2 : 3')
                  Left: 
                    IPropertyReferenceOperation: System.Object MyClass.B { get; set; } (OperationKind.PropertyReference, Type: System.Object) (Syntax: 'B')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: MyClass, IsImplicit) (Syntax: 'new MyClass ... }')
                  Right: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsImplicit) (Syntax: 'b ? 2 : 3')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (Boxing)
                      Operand: 
                        IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'b ? 2 : 3')

            Next (Regular) Block[B10]
                Leaving: {R3}
    }

    Block[B10] - Block
        Predecessors: [B9]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: MyClass, IsImplicit) (Syntax: 'a = new MyC ... }')
              Left: 
                ILocalReferenceOperation: a (IsDeclaration: True) (OperationKind.LocalReference, Type: MyClass, IsImplicit) (Syntax: 'a = new MyC ... }')
              Right: 
                IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: MyClass, IsImplicit) (Syntax: 'new MyClass ... }')

        Next (Regular) Block[B11]
            Leaving: {R1}
}

Block[B11] - Exit
    Predecessors: [B10]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,293775,293873);

f_22056_293775_293872(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,285610,293884);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,285610,293884);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,285610,293884);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ObjectCreationFlow_09()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,293896,297885);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,294051,294455);

string 
source = @"
class C1
{
    public C2 C2 { get; set; } = new C2();

    public void M()
    /*<bind>*/{
        var x = new C1 { C2 = { C31 = { P1 = 1, P2 = 2 } } };
    }/*</bind>*/
}

class C2
{
    public C2()
    {
    }

    public C3 C31 { get; set; }
    public C3 C32 { get; set; }
}

class C3
{
    public int P1 { get; set; }
    public int P2 { get; set; }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,294469,294522);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,294538,297762);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [C1 x]
    CaptureIds: [0]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (4)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new C1 { C2 ... 2 = 2 } } }')
              Value: 
                IObjectCreationOperation (Constructor: C1..ctor()) (OperationKind.ObjectCreation, Type: C1) (Syntax: 'new C1 { C2 ... 2 = 2 } } }')
                  Arguments(0)
                  Initializer: 
                    null

            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'P1 = 1')
              Left: 
                IPropertyReferenceOperation: System.Int32 C3.P1 { get; set; } (OperationKind.PropertyReference, Type: System.Int32) (Syntax: 'P1')
                  Instance Receiver: 
                    IPropertyReferenceOperation: C3 C2.C31 { get; set; } (OperationKind.PropertyReference, Type: C3) (Syntax: 'C31')
                      Instance Receiver: 
                        IPropertyReferenceOperation: C2 C1.C2 { get; set; } (OperationKind.PropertyReference, Type: C2) (Syntax: 'C2')
                          Instance Receiver: 
                            IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { C2 ... 2 = 2 } } }')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'P2 = 2')
              Left: 
                IPropertyReferenceOperation: System.Int32 C3.P2 { get; set; } (OperationKind.PropertyReference, Type: System.Int32) (Syntax: 'P2')
                  Instance Receiver: 
                    IPropertyReferenceOperation: C3 C2.C31 { get; set; } (OperationKind.PropertyReference, Type: C3) (Syntax: 'C31')
                      Instance Receiver: 
                        IPropertyReferenceOperation: C2 C1.C2 { get; set; } (OperationKind.PropertyReference, Type: C2) (Syntax: 'C2')
                          Instance Receiver: 
                            IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { C2 ... 2 = 2 } } }')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')

            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: C1, IsImplicit) (Syntax: 'x = new C1  ... 2 = 2 } } }')
              Left: 
                ILocalReferenceOperation: x (IsDeclaration: True) (OperationKind.LocalReference, Type: C1, IsImplicit) (Syntax: 'x = new C1  ... 2 = 2 } } }')
              Right: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { C2 ... 2 = 2 } } }')

        Next (Regular) Block[B2]
            Leaving: {R1}
}

Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,297776,297874);

f_22056_297776_297873(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,293896,297885);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,293896,297885);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,293896,297885);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ObjectCreationFlow_10()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,297897,305619);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,298052,298496);

string 
source = @"
class C1
{
    public C2 C2 { get; set; } = new C2();

    public void M(bool b)
    /*<bind>*/{
        var x = new C1 { C2 = { C31 = { P1 = 1, P2 = 2 }, C32 = { P1 = 3, P2 = b ? 4 : 5 } } };
    }/*</bind>*/
}

class C2
{
    public C2()
    {
    }

    public C3 C31 { get; set; }
    public C3 C32 { get; set; }
}

class C3
{
    public int P1 { get; set; }
    public int P2 { get; set; }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,298510,298563);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,298579,305496);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [C1 x]
    CaptureIds: [0]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (4)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new C1 { C2 ... 4 : 5 } } }')
              Value: 
                IObjectCreationOperation (Constructor: C1..ctor()) (OperationKind.ObjectCreation, Type: C1) (Syntax: 'new C1 { C2 ... 4 : 5 } } }')
                  Arguments(0)
                  Initializer: 
                    null

            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'P1 = 1')
              Left: 
                IPropertyReferenceOperation: System.Int32 C3.P1 { get; set; } (OperationKind.PropertyReference, Type: System.Int32) (Syntax: 'P1')
                  Instance Receiver: 
                    IPropertyReferenceOperation: C3 C2.C31 { get; set; } (OperationKind.PropertyReference, Type: C3) (Syntax: 'C31')
                      Instance Receiver: 
                        IPropertyReferenceOperation: C2 C1.C2 { get; set; } (OperationKind.PropertyReference, Type: C2) (Syntax: 'C2')
                          Instance Receiver: 
                            IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { C2 ... 4 : 5 } } }')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'P2 = 2')
              Left: 
                IPropertyReferenceOperation: System.Int32 C3.P2 { get; set; } (OperationKind.PropertyReference, Type: System.Int32) (Syntax: 'P2')
                  Instance Receiver: 
                    IPropertyReferenceOperation: C3 C2.C31 { get; set; } (OperationKind.PropertyReference, Type: C3) (Syntax: 'C31')
                      Instance Receiver: 
                        IPropertyReferenceOperation: C2 C1.C2 { get; set; } (OperationKind.PropertyReference, Type: C2) (Syntax: 'C2')
                          Instance Receiver: 
                            IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { C2 ... 4 : 5 } } }')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')

            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'P1 = 3')
              Left: 
                IPropertyReferenceOperation: System.Int32 C3.P1 { get; set; } (OperationKind.PropertyReference, Type: System.Int32) (Syntax: 'P1')
                  Instance Receiver: 
                    IPropertyReferenceOperation: C3 C2.C32 { get; set; } (OperationKind.PropertyReference, Type: C3) (Syntax: 'C32')
                      Instance Receiver: 
                        IPropertyReferenceOperation: C2 C1.C2 { get; set; } (OperationKind.PropertyReference, Type: C2) (Syntax: 'C2')
                          Instance Receiver: 
                            IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { C2 ... 4 : 5 } } }')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1] [2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'C32')
                  Value: 
                    IPropertyReferenceOperation: C3 C2.C32 { get; set; } (OperationKind.PropertyReference, Type: C3) (Syntax: 'C32')
                      Instance Receiver: 
                        IPropertyReferenceOperation: C2 C1.C2 { get; set; } (OperationKind.PropertyReference, Type: C2) (Syntax: 'C2')
                          Instance Receiver: 
                            IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { C2 ... 4 : 5 } } }')

            Jump if False (Regular) to Block[B4]
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '4')
                  Value: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 4) (Syntax: '4')

            Next (Regular) Block[B5]
        Block[B4] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '5')
                  Value: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 5) (Syntax: '5')

            Next (Regular) Block[B5]
        Block[B5] - Block
            Predecessors: [B3] [B4]
            Statements (1)
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'P2 = b ? 4 : 5')
                  Left: 
                    IPropertyReferenceOperation: System.Int32 C3.P2 { get; set; } (OperationKind.PropertyReference, Type: System.Int32) (Syntax: 'P2')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C3, IsImplicit) (Syntax: 'C32')
                  Right: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'b ? 4 : 5')

            Next (Regular) Block[B6]
                Leaving: {R2}
    }

    Block[B6] - Block
        Predecessors: [B5]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: C1, IsImplicit) (Syntax: 'x = new C1  ... 4 : 5 } } }')
              Left: 
                ILocalReferenceOperation: x (IsDeclaration: True) (OperationKind.LocalReference, Type: C1, IsImplicit) (Syntax: 'x = new C1  ... 4 : 5 } } }')
              Right: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { C2 ... 4 : 5 } } }')

        Next (Regular) Block[B7]
            Leaving: {R1}
}

Block[B7] - Exit
    Predecessors: [B6]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,305510,305608);

f_22056_305510_305607(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,297897,305619);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,297897,305619);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,297897,305619);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ObjectCreationFlow_11()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,305631,313353);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,305786,306230);

string 
source = @"
class C1
{
    public C2 C2 { get; set; } = new C2();

    public void M(bool b)
    /*<bind>*/{
        var x = new C1 { C2 = { C31 = { P1 = b ? 1 : 5, P2 = 2 }, C32 = { P1 = 3, P2 = 4 } } };
    }/*</bind>*/
}

class C2
{
    public C2()
    {
    }

    public C3 C31 { get; set; }
    public C3 C32 { get; set; }
}

class C3
{
    public int P1 { get; set; }
    public int P2 { get; set; }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,306244,306297);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,306313,313230);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [C1 x]
    CaptureIds: [0]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new C1 { C2 ... 2 = 4 } } }')
              Value: 
                IObjectCreationOperation (Constructor: C1..ctor()) (OperationKind.ObjectCreation, Type: C1) (Syntax: 'new C1 { C2 ... 2 = 4 } } }')
                  Arguments(0)
                  Initializer: 
                    null

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1] [2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'C31')
                  Value: 
                    IPropertyReferenceOperation: C3 C2.C31 { get; set; } (OperationKind.PropertyReference, Type: C3) (Syntax: 'C31')
                      Instance Receiver: 
                        IPropertyReferenceOperation: C2 C1.C2 { get; set; } (OperationKind.PropertyReference, Type: C2) (Syntax: 'C2')
                          Instance Receiver: 
                            IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { C2 ... 2 = 4 } } }')

            Jump if False (Regular) to Block[B4]
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '1')
                  Value: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

            Next (Regular) Block[B5]
        Block[B4] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '5')
                  Value: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 5) (Syntax: '5')

            Next (Regular) Block[B5]
        Block[B5] - Block
            Predecessors: [B3] [B4]
            Statements (1)
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'P1 = b ? 1 : 5')
                  Left: 
                    IPropertyReferenceOperation: System.Int32 C3.P1 { get; set; } (OperationKind.PropertyReference, Type: System.Int32) (Syntax: 'P1')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C3, IsImplicit) (Syntax: 'C31')
                  Right: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'b ? 1 : 5')

            Next (Regular) Block[B6]
                Leaving: {R2}
    }

    Block[B6] - Block
        Predecessors: [B5]
        Statements (4)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'P2 = 2')
              Left: 
                IPropertyReferenceOperation: System.Int32 C3.P2 { get; set; } (OperationKind.PropertyReference, Type: System.Int32) (Syntax: 'P2')
                  Instance Receiver: 
                    IPropertyReferenceOperation: C3 C2.C31 { get; set; } (OperationKind.PropertyReference, Type: C3) (Syntax: 'C31')
                      Instance Receiver: 
                        IPropertyReferenceOperation: C2 C1.C2 { get; set; } (OperationKind.PropertyReference, Type: C2) (Syntax: 'C2')
                          Instance Receiver: 
                            IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { C2 ... 2 = 4 } } }')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')

            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'P1 = 3')
              Left: 
                IPropertyReferenceOperation: System.Int32 C3.P1 { get; set; } (OperationKind.PropertyReference, Type: System.Int32) (Syntax: 'P1')
                  Instance Receiver: 
                    IPropertyReferenceOperation: C3 C2.C32 { get; set; } (OperationKind.PropertyReference, Type: C3) (Syntax: 'C32')
                      Instance Receiver: 
                        IPropertyReferenceOperation: C2 C1.C2 { get; set; } (OperationKind.PropertyReference, Type: C2) (Syntax: 'C2')
                          Instance Receiver: 
                            IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { C2 ... 2 = 4 } } }')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')

            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'P2 = 4')
              Left: 
                IPropertyReferenceOperation: System.Int32 C3.P2 { get; set; } (OperationKind.PropertyReference, Type: System.Int32) (Syntax: 'P2')
                  Instance Receiver: 
                    IPropertyReferenceOperation: C3 C2.C32 { get; set; } (OperationKind.PropertyReference, Type: C3) (Syntax: 'C32')
                      Instance Receiver: 
                        IPropertyReferenceOperation: C2 C1.C2 { get; set; } (OperationKind.PropertyReference, Type: C2) (Syntax: 'C2')
                          Instance Receiver: 
                            IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { C2 ... 2 = 4 } } }')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 4) (Syntax: '4')

            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: C1, IsImplicit) (Syntax: 'x = new C1  ... 2 = 4 } } }')
              Left: 
                ILocalReferenceOperation: x (IsDeclaration: True) (OperationKind.LocalReference, Type: C1, IsImplicit) (Syntax: 'x = new C1  ... 2 = 4 } } }')
              Right: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { C2 ... 2 = 4 } } }')

        Next (Regular) Block[B7]
            Leaving: {R1}
}

Block[B7] - Exit
    Predecessors: [B6]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,313244,313342);

f_22056_313244_313341(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,305631,313353);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,305631,313353);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,305631,313353);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ObjectCreationFlow_12()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,313365,329762);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,313520,313990);

string 
source = @"
class C1
{
    public C2 C2 { get; set; } = new C2();

    public void M(bool b)
    /*<bind>*/{
        var x = new C1 { C2 = { C31 = { P1 = 1, P2 = 2 }, C32 = b ? ({ P1 = 3, P2 = 4 }) : ({ P1 = 3, P2 = 4 })
    }/*</bind>*/ };
    }
}

class C2
{
    public C2()
    {
    }

    public C3 C31 { get; set; }
    public C3 C32 { get; set; }
}

class C3
{
    public int P1 { get; set; }
    public int P2 { get; set; }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,314004,320335);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22056_314265_314350(f_22056_314265_314330(f_22056_314265_314311(ErrorCode.ERR_InvalidExprTerm, "{"), "{"), 8, 70),
f_22056_314540_314609(f_22056_314540_314589(ErrorCode.ERR_CloseParenExpected, "{"), 8, 70),
f_22056_314815_314901(f_22056_314815_314881(f_22056_314815_314857(ErrorCode.ERR_SyntaxError, "{"), ":", "{"), 8, 70),
f_22056_315108_315193(f_22056_315108_315173(f_22056_315108_315154(ErrorCode.ERR_InvalidExprTerm, "{"), "{"), 8, 70),
f_22056_315399_315485(f_22056_315399_315465(f_22056_315399_315441(ErrorCode.ERR_SyntaxError, "{"), ",", "{"), 8, 70),
f_22056_315675_315740(f_22056_315675_315720(ErrorCode.ERR_RbraceExpected, ")"), 8, 88),
f_22056_315930_315995(f_22056_315930_315975(ErrorCode.ERR_RbraceExpected, ")"), 8, 88),
f_22056_316185_316253(f_22056_316185_316233(ErrorCode.ERR_SemicolonExpected, ")"), 8, 88),
f_22056_316443_316508(f_22056_316443_316488(ErrorCode.ERR_RbraceExpected, ")"), 8, 88),
f_22056_316715_316800(f_22056_316715_316780(f_22056_316715_316761(ErrorCode.ERR_InvalidExprTerm, "{"), "{"), 8, 93),
f_22056_316990_317059(f_22056_316990_317039(ErrorCode.ERR_CloseParenExpected, "{"), 8, 93),
f_22056_317249_317317(f_22056_317249_317297(ErrorCode.ERR_SemicolonExpected, "{"), 8, 93),
f_22056_317507_317576(f_22056_317507_317555(ErrorCode.ERR_SemicolonExpected, ","), 8, 101),
f_22056_317766_317832(f_22056_317766_317811(ErrorCode.ERR_RbraceExpected, ","), 8, 101),
f_22056_318022_318091(f_22056_318022_318070(ErrorCode.ERR_SemicolonExpected, "}"), 8, 110),
f_22056_318281_318347(f_22056_318281_318326(ErrorCode.ERR_RbraceExpected, ")"), 8, 111),
f_22056_318474_318536(f_22056_318474_318516(ErrorCode.ERR_EOFExpected, "}"), 10, 5),
f_22056_318659_318721(f_22056_318659_318701(ErrorCode.ERR_EOFExpected, "}"), 11, 1),
f_22056_318952_319040(f_22056_318952_319020(f_22056_318952_319000(ErrorCode.ERR_NameNotInContext, "P1"), "P1"), 8, 72),
f_22056_319271_319359(f_22056_319271_319339(f_22056_319271_319319(ErrorCode.ERR_NameNotInContext, "P2"), "P2"), 8, 80),
f_22056_319576_319680(f_22056_319576_319660(ErrorCode.ERR_InvalidInitializerElementInitializer, "{ P1 = 3, P2 = 4 }"), 8, 70),
f_22056_319911_319999(f_22056_319911_319979(f_22056_319911_319959(ErrorCode.ERR_NameNotInContext, "P1"), "P1"), 8, 95),
f_22056_320230_320319(f_22056_320230_320298(f_22056_320230_320278(ErrorCode.ERR_NameNotInContext, "P2"), "P2"), 8, 103)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,320351,329639);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2}

.locals {R1}
{
    Locals: [C1 x]
    .locals {R2}
    {
        CaptureIds: [0]
        Block[B1] - Block
            Predecessors: [B0]
            Statements (3)
                IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'new C1 { C2 ... 3, P2 = 4 }')
                  Value: 
                    IObjectCreationOperation (Constructor: C1..ctor()) (OperationKind.ObjectCreation, Type: C1, IsInvalid) (Syntax: 'new C1 { C2 ... 3, P2 = 4 }')
                      Arguments(0)
                      Initializer: 
                        null

                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'P1 = 1')
                  Left: 
                    IPropertyReferenceOperation: System.Int32 C3.P1 { get; set; } (OperationKind.PropertyReference, Type: System.Int32) (Syntax: 'P1')
                      Instance Receiver: 
                        IPropertyReferenceOperation: C3 C2.C31 { get; set; } (OperationKind.PropertyReference, Type: C3) (Syntax: 'C31')
                          Instance Receiver: 
                            IPropertyReferenceOperation: C2 C1.C2 { get; set; } (OperationKind.PropertyReference, Type: C2) (Syntax: 'C2')
                              Instance Receiver: 
                                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C1, IsInvalid, IsImplicit) (Syntax: 'new C1 { C2 ... 3, P2 = 4 }')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'P2 = 2')
                  Left: 
                    IPropertyReferenceOperation: System.Int32 C3.P2 { get; set; } (OperationKind.PropertyReference, Type: System.Int32) (Syntax: 'P2')
                      Instance Receiver: 
                        IPropertyReferenceOperation: C3 C2.C31 { get; set; } (OperationKind.PropertyReference, Type: C3) (Syntax: 'C31')
                          Instance Receiver: 
                            IPropertyReferenceOperation: C2 C1.C2 { get; set; } (OperationKind.PropertyReference, Type: C2) (Syntax: 'C2')
                              Instance Receiver: 
                                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C1, IsInvalid, IsImplicit) (Syntax: 'new C1 { C2 ... 3, P2 = 4 }')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')

            Next (Regular) Block[B2]
                Entering: {R3}

        .locals {R3}
        {
            CaptureIds: [1] [2]
            Block[B2] - Block
                Predecessors: [B1]
                Statements (1)
                    IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'C2')
                      Value: 
                        IPropertyReferenceOperation: C2 C1.C2 { get; set; } (OperationKind.PropertyReference, Type: C2) (Syntax: 'C2')
                          Instance Receiver: 
                            IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C1, IsInvalid, IsImplicit) (Syntax: 'new C1 { C2 ... 3, P2 = 4 }')

                Jump if False (Regular) to Block[B4]
                    IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

                Next (Regular) Block[B3]
            Block[B3] - Block
                Predecessors: [B2]
                Statements (1)
                    IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: '')
                      Value: 
                        IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid) (Syntax: '')
                          Children(0)

                Next (Regular) Block[B5]
            Block[B4] - Block
                Predecessors: [B2]
                Statements (1)
                    IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: '')
                      Value: 
                        IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid) (Syntax: '')
                          Children(0)

                Next (Regular) Block[B5]
            Block[B5] - Block
                Predecessors: [B3] [B4]
                Statements (1)
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: C3, IsInvalid) (Syntax: 'C32 = b ? (')
                      Left: 
                        IPropertyReferenceOperation: C3 C2.C32 { get; set; } (OperationKind.PropertyReference, Type: C3) (Syntax: 'C32')
                          Instance Receiver: 
                            IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C2, IsImplicit) (Syntax: 'C2')
                      Right: 
                        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: C3, IsInvalid, IsImplicit) (Syntax: 'b ? (')
                          Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            (NoConversion)
                          Operand: 
                            IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: ?, IsInvalid, IsImplicit) (Syntax: 'b ? (')

                Next (Regular) Block[B6]
                    Leaving: {R3}
        }

        Block[B6] - Block
            Predecessors: [B5]
            Statements (2)
                IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid) (Syntax: '{ P1 = 3, P2 = 4 }')
                  Children(2):
                      ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: ?, IsInvalid) (Syntax: 'P1 = 3')
                        Left: 
                          IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid) (Syntax: 'P1')
                            Children(0)
                        Right: 
                          ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3, IsInvalid) (Syntax: '3')
                      ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: ?, IsInvalid) (Syntax: 'P2 = 4')
                        Left: 
                          IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid) (Syntax: 'P2')
                            Children(0)
                        Right: 
                          ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 4, IsInvalid) (Syntax: '4')

                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: C1, IsInvalid, IsImplicit) (Syntax: 'x = new C1  ... 3, P2 = 4 }')
                  Left: 
                    ILocalReferenceOperation: x (IsDeclaration: True) (OperationKind.LocalReference, Type: C1, IsInvalid, IsImplicit) (Syntax: 'x = new C1  ... 3, P2 = 4 }')
                  Right: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C1, IsInvalid, IsImplicit) (Syntax: 'new C1 { C2 ... 3, P2 = 4 }')

            Next (Regular) Block[B7]
                Leaving: {R2}
    }

    Block[B7] - Block
        Predecessors: [B6]
        Statements (3)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: '(')
              Expression: 
                IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid) (Syntax: '')
                  Children(0)

            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: 'P1 = 3')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: ?, IsInvalid) (Syntax: 'P1 = 3')
                  Left: 
                    IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid) (Syntax: 'P1')
                      Children(0)
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3, IsInvalid) (Syntax: '3')

            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: 'P2 = 4 ')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: ?, IsInvalid) (Syntax: 'P2 = 4')
                  Left: 
                    IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid) (Syntax: 'P2')
                      Children(0)
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 4) (Syntax: '4')

        Next (Regular) Block[B8]
            Leaving: {R1}
}

Block[B8] - Exit
    Predecessors: [B7]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,329653,329751);

f_22056_329653_329750(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,313365,329762);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,313365,329762);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,313365,329762);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ObjectCreationFlow_13()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,329774,342396);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,329929,330389);

string 
source = @"
class C1
{
    public C2 C2 { get; set; } = new C2();


    public void M(bool b)
    /*<bind>*/{
        var x = new C1 { C2 = { C31 = { [1] = 2, [3] = 4 }, C32 = { [5] = 6, [7] = 8 } } };
    }/*</bind>*/
}

class C2
{
    public C2()
    {
    }

    public C3 C31 { get; set; }
    public C3 C32 { get; set; }
}

class C3
{
    public object this[int i]
    {
        get => null;
        set { }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,330403,330456);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,330472,342273);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [C1 x]
    CaptureIds: [0]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new C1 { C2 ... ] = 8 } } }')
              Value: 
                IObjectCreationOperation (Constructor: C1..ctor()) (OperationKind.ObjectCreation, Type: C1) (Syntax: 'new C1 { C2 ... ] = 8 } } }')
                  Arguments(0)
                  Initializer: 
                    null

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (2)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '1')
                  Value: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Object) (Syntax: '[1] = 2')
                  Left: 
                    IPropertyReferenceOperation: System.Object C3.this[System.Int32 i] { get; set; } (OperationKind.PropertyReference, Type: System.Object) (Syntax: '[1]')
                      Instance Receiver: 
                        IPropertyReferenceOperation: C3 C2.C31 { get; set; } (OperationKind.PropertyReference, Type: C3) (Syntax: 'C31')
                          Instance Receiver: 
                            IPropertyReferenceOperation: C2 C1.C2 { get; set; } (OperationKind.PropertyReference, Type: C2) (Syntax: 'C2')
                              Instance Receiver: 
                                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { C2 ... ] = 8 } } }')
                      Arguments(1):
                          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: '1')
                            IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32, Constant: 1, IsImplicit) (Syntax: '1')
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  Right: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsImplicit) (Syntax: '2')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (Boxing)
                      Operand: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')

            Next (Regular) Block[B3]
                Leaving: {R2}
                Entering: {R3}
    }
    .locals {R3}
    {
        CaptureIds: [2]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (2)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '3')
                  Value: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')

                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Object) (Syntax: '[3] = 4')
                  Left: 
                    IPropertyReferenceOperation: System.Object C3.this[System.Int32 i] { get; set; } (OperationKind.PropertyReference, Type: System.Object) (Syntax: '[3]')
                      Instance Receiver: 
                        IPropertyReferenceOperation: C3 C2.C31 { get; set; } (OperationKind.PropertyReference, Type: C3) (Syntax: 'C31')
                          Instance Receiver: 
                            IPropertyReferenceOperation: C2 C1.C2 { get; set; } (OperationKind.PropertyReference, Type: C2) (Syntax: 'C2')
                              Instance Receiver: 
                                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { C2 ... ] = 8 } } }')
                      Arguments(1):
                          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: '3')
                            IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, Constant: 3, IsImplicit) (Syntax: '3')
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  Right: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsImplicit) (Syntax: '4')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (Boxing)
                      Operand: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 4) (Syntax: '4')

            Next (Regular) Block[B4]
                Leaving: {R3}
                Entering: {R4}
    }
    .locals {R4}
    {
        CaptureIds: [3]
        Block[B4] - Block
            Predecessors: [B3]
            Statements (2)
                IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '5')
                  Value: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 5) (Syntax: '5')

                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Object) (Syntax: '[5] = 6')
                  Left: 
                    IPropertyReferenceOperation: System.Object C3.this[System.Int32 i] { get; set; } (OperationKind.PropertyReference, Type: System.Object) (Syntax: '[5]')
                      Instance Receiver: 
                        IPropertyReferenceOperation: C3 C2.C32 { get; set; } (OperationKind.PropertyReference, Type: C3) (Syntax: 'C32')
                          Instance Receiver: 
                            IPropertyReferenceOperation: C2 C1.C2 { get; set; } (OperationKind.PropertyReference, Type: C2) (Syntax: 'C2')
                              Instance Receiver: 
                                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { C2 ... ] = 8 } } }')
                      Arguments(1):
                          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: '5')
                            IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Int32, Constant: 5, IsImplicit) (Syntax: '5')
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  Right: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsImplicit) (Syntax: '6')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (Boxing)
                      Operand: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 6) (Syntax: '6')

            Next (Regular) Block[B5]
                Leaving: {R4}
                Entering: {R5}
    }
    .locals {R5}
    {
        CaptureIds: [4]
        Block[B5] - Block
            Predecessors: [B4]
            Statements (2)
                IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '7')
                  Value: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 7) (Syntax: '7')

                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Object) (Syntax: '[7] = 8')
                  Left: 
                    IPropertyReferenceOperation: System.Object C3.this[System.Int32 i] { get; set; } (OperationKind.PropertyReference, Type: System.Object) (Syntax: '[7]')
                      Instance Receiver: 
                        IPropertyReferenceOperation: C3 C2.C32 { get; set; } (OperationKind.PropertyReference, Type: C3) (Syntax: 'C32')
                          Instance Receiver: 
                            IPropertyReferenceOperation: C2 C1.C2 { get; set; } (OperationKind.PropertyReference, Type: C2) (Syntax: 'C2')
                              Instance Receiver: 
                                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { C2 ... ] = 8 } } }')
                      Arguments(1):
                          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: '7')
                            IFlowCaptureReferenceOperation: 4 (OperationKind.FlowCaptureReference, Type: System.Int32, Constant: 7, IsImplicit) (Syntax: '7')
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  Right: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsImplicit) (Syntax: '8')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (Boxing)
                      Operand: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 8) (Syntax: '8')

            Next (Regular) Block[B6]
                Leaving: {R5}
    }

    Block[B6] - Block
        Predecessors: [B5]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: C1, IsImplicit) (Syntax: 'x = new C1  ... ] = 8 } } }')
              Left: 
                ILocalReferenceOperation: x (IsDeclaration: True) (OperationKind.LocalReference, Type: C1, IsImplicit) (Syntax: 'x = new C1  ... ] = 8 } } }')
              Right: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { C2 ... ] = 8 } } }')

        Next (Regular) Block[B7]
            Leaving: {R1}
}

Block[B7] - Exit
    Predecessors: [B6]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,342287,342385);

f_22056_342287_342384(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,329774,342396);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,329774,342396);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,329774,342396);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ObjectCreationFlow_14()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,342408,355858);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,342563,343031);

string 
source = @"
class C1
{
    public C2 C2 { get; set; } = new C2();


    public void M(bool b)
    /*<bind>*/{
        var x = new C1 { C2 = { C31 = { [1] = 2, [3] = 4 }, C32 = { [5] = 6, [b ? 7 : 8] = 9 } } };
    }/*</bind>*/
}

class C2
{
    public C2()
    {
    }

    public C3 C31 { get; set; }
    public C3 C32 { get; set; }
}

class C3
{
    public object this[int i]
    {
        get => null;
        set { }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,343045,343098);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,343114,355735);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [C1 x]
    CaptureIds: [0]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new C1 { C2 ... ] = 9 } } }')
              Value: 
                IObjectCreationOperation (Constructor: C1..ctor()) (OperationKind.ObjectCreation, Type: C1) (Syntax: 'new C1 { C2 ... ] = 9 } } }')
                  Arguments(0)
                  Initializer: 
                    null

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (2)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '1')
                  Value: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Object) (Syntax: '[1] = 2')
                  Left: 
                    IPropertyReferenceOperation: System.Object C3.this[System.Int32 i] { get; set; } (OperationKind.PropertyReference, Type: System.Object) (Syntax: '[1]')
                      Instance Receiver: 
                        IPropertyReferenceOperation: C3 C2.C31 { get; set; } (OperationKind.PropertyReference, Type: C3) (Syntax: 'C31')
                          Instance Receiver: 
                            IPropertyReferenceOperation: C2 C1.C2 { get; set; } (OperationKind.PropertyReference, Type: C2) (Syntax: 'C2')
                              Instance Receiver: 
                                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { C2 ... ] = 9 } } }')
                      Arguments(1):
                          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: '1')
                            IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32, Constant: 1, IsImplicit) (Syntax: '1')
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  Right: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsImplicit) (Syntax: '2')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (Boxing)
                      Operand: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')

            Next (Regular) Block[B3]
                Leaving: {R2}
                Entering: {R3}
    }
    .locals {R3}
    {
        CaptureIds: [2]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (2)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '3')
                  Value: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')

                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Object) (Syntax: '[3] = 4')
                  Left: 
                    IPropertyReferenceOperation: System.Object C3.this[System.Int32 i] { get; set; } (OperationKind.PropertyReference, Type: System.Object) (Syntax: '[3]')
                      Instance Receiver: 
                        IPropertyReferenceOperation: C3 C2.C31 { get; set; } (OperationKind.PropertyReference, Type: C3) (Syntax: 'C31')
                          Instance Receiver: 
                            IPropertyReferenceOperation: C2 C1.C2 { get; set; } (OperationKind.PropertyReference, Type: C2) (Syntax: 'C2')
                              Instance Receiver: 
                                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { C2 ... ] = 9 } } }')
                      Arguments(1):
                          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: '3')
                            IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, Constant: 3, IsImplicit) (Syntax: '3')
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  Right: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsImplicit) (Syntax: '4')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (Boxing)
                      Operand: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 4) (Syntax: '4')

            Next (Regular) Block[B4]
                Leaving: {R3}
                Entering: {R4}
    }
    .locals {R4}
    {
        CaptureIds: [3]
        Block[B4] - Block
            Predecessors: [B3]
            Statements (2)
                IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '5')
                  Value: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 5) (Syntax: '5')

                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Object) (Syntax: '[5] = 6')
                  Left: 
                    IPropertyReferenceOperation: System.Object C3.this[System.Int32 i] { get; set; } (OperationKind.PropertyReference, Type: System.Object) (Syntax: '[5]')
                      Instance Receiver: 
                        IPropertyReferenceOperation: C3 C2.C32 { get; set; } (OperationKind.PropertyReference, Type: C3) (Syntax: 'C32')
                          Instance Receiver: 
                            IPropertyReferenceOperation: C2 C1.C2 { get; set; } (OperationKind.PropertyReference, Type: C2) (Syntax: 'C2')
                              Instance Receiver: 
                                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { C2 ... ] = 9 } } }')
                      Arguments(1):
                          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: '5')
                            IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Int32, Constant: 5, IsImplicit) (Syntax: '5')
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  Right: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsImplicit) (Syntax: '6')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (Boxing)
                      Operand: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 6) (Syntax: '6')

            Next (Regular) Block[B5]
                Leaving: {R4}
                Entering: {R5}
    }
    .locals {R5}
    {
        CaptureIds: [4]
        Block[B5] - Block
            Predecessors: [B4]
            Statements (0)
            Jump if False (Regular) to Block[B7]
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

            Next (Regular) Block[B6]
        Block[B6] - Block
            Predecessors: [B5]
            Statements (1)
                IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '7')
                  Value: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 7) (Syntax: '7')

            Next (Regular) Block[B8]
        Block[B7] - Block
            Predecessors: [B5]
            Statements (1)
                IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '8')
                  Value: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 8) (Syntax: '8')

            Next (Regular) Block[B8]
        Block[B8] - Block
            Predecessors: [B6] [B7]
            Statements (1)
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Object) (Syntax: '[b ? 7 : 8] = 9')
                  Left: 
                    IPropertyReferenceOperation: System.Object C3.this[System.Int32 i] { get; set; } (OperationKind.PropertyReference, Type: System.Object) (Syntax: '[b ? 7 : 8]')
                      Instance Receiver: 
                        IPropertyReferenceOperation: C3 C2.C32 { get; set; } (OperationKind.PropertyReference, Type: C3) (Syntax: 'C32')
                          Instance Receiver: 
                            IPropertyReferenceOperation: C2 C1.C2 { get; set; } (OperationKind.PropertyReference, Type: C2) (Syntax: 'C2')
                              Instance Receiver: 
                                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { C2 ... ] = 9 } } }')
                      Arguments(1):
                          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: 'b ? 7 : 8')
                            IFlowCaptureReferenceOperation: 4 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'b ? 7 : 8')
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  Right: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsImplicit) (Syntax: '9')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (Boxing)
                      Operand: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 9) (Syntax: '9')

            Next (Regular) Block[B9]
                Leaving: {R5}
    }

    Block[B9] - Block
        Predecessors: [B8]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: C1, IsImplicit) (Syntax: 'x = new C1  ... ] = 9 } } }')
              Left: 
                ILocalReferenceOperation: x (IsDeclaration: True) (OperationKind.LocalReference, Type: C1, IsImplicit) (Syntax: 'x = new C1  ... ] = 9 } } }')
              Right: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { C2 ... ] = 9 } } }')

        Next (Regular) Block[B10]
            Leaving: {R1}
}

Block[B10] - Exit
    Predecessors: [B9]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,355749,355847);

f_22056_355749_355846(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,342408,355858);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,342408,355858);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,342408,355858);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ObjectCreationFlow_15()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,355870,369861);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,356025,356493);

string 
source = @"
class C1
{
    public C2 C2 { get; set; } = new C2();


    public void M(bool b)
    /*<bind>*/{
        var x = new C1 { C2 = { C31 = { [1] = 2, [3] = 4 }, C32 = { [5] = 6, [7] = b ? 8 : 9 } } };
    }/*</bind>*/
}

class C2
{
    public C2()
    {
    }

    public C3 C31 { get; set; }
    public C3 C32 { get; set; }
}

class C3
{
    public object this[int i]
    {
        get => null;
        set { }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,356507,356560);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,356576,369738);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [C1 x]
    CaptureIds: [0]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new C1 { C2 ... 8 : 9 } } }')
              Value: 
                IObjectCreationOperation (Constructor: C1..ctor()) (OperationKind.ObjectCreation, Type: C1) (Syntax: 'new C1 { C2 ... 8 : 9 } } }')
                  Arguments(0)
                  Initializer: 
                    null

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (2)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '1')
                  Value: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Object) (Syntax: '[1] = 2')
                  Left: 
                    IPropertyReferenceOperation: System.Object C3.this[System.Int32 i] { get; set; } (OperationKind.PropertyReference, Type: System.Object) (Syntax: '[1]')
                      Instance Receiver: 
                        IPropertyReferenceOperation: C3 C2.C31 { get; set; } (OperationKind.PropertyReference, Type: C3) (Syntax: 'C31')
                          Instance Receiver: 
                            IPropertyReferenceOperation: C2 C1.C2 { get; set; } (OperationKind.PropertyReference, Type: C2) (Syntax: 'C2')
                              Instance Receiver: 
                                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { C2 ... 8 : 9 } } }')
                      Arguments(1):
                          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: '1')
                            IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32, Constant: 1, IsImplicit) (Syntax: '1')
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  Right: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsImplicit) (Syntax: '2')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (Boxing)
                      Operand: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')

            Next (Regular) Block[B3]
                Leaving: {R2}
                Entering: {R3}
    }
    .locals {R3}
    {
        CaptureIds: [2]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (2)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '3')
                  Value: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')

                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Object) (Syntax: '[3] = 4')
                  Left: 
                    IPropertyReferenceOperation: System.Object C3.this[System.Int32 i] { get; set; } (OperationKind.PropertyReference, Type: System.Object) (Syntax: '[3]')
                      Instance Receiver: 
                        IPropertyReferenceOperation: C3 C2.C31 { get; set; } (OperationKind.PropertyReference, Type: C3) (Syntax: 'C31')
                          Instance Receiver: 
                            IPropertyReferenceOperation: C2 C1.C2 { get; set; } (OperationKind.PropertyReference, Type: C2) (Syntax: 'C2')
                              Instance Receiver: 
                                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { C2 ... 8 : 9 } } }')
                      Arguments(1):
                          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: '3')
                            IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, Constant: 3, IsImplicit) (Syntax: '3')
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  Right: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsImplicit) (Syntax: '4')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (Boxing)
                      Operand: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 4) (Syntax: '4')

            Next (Regular) Block[B4]
                Leaving: {R3}
                Entering: {R4}
    }
    .locals {R4}
    {
        CaptureIds: [3]
        Block[B4] - Block
            Predecessors: [B3]
            Statements (2)
                IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '5')
                  Value: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 5) (Syntax: '5')

                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Object) (Syntax: '[5] = 6')
                  Left: 
                    IPropertyReferenceOperation: System.Object C3.this[System.Int32 i] { get; set; } (OperationKind.PropertyReference, Type: System.Object) (Syntax: '[5]')
                      Instance Receiver: 
                        IPropertyReferenceOperation: C3 C2.C32 { get; set; } (OperationKind.PropertyReference, Type: C3) (Syntax: 'C32')
                          Instance Receiver: 
                            IPropertyReferenceOperation: C2 C1.C2 { get; set; } (OperationKind.PropertyReference, Type: C2) (Syntax: 'C2')
                              Instance Receiver: 
                                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { C2 ... 8 : 9 } } }')
                      Arguments(1):
                          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: '5')
                            IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Int32, Constant: 5, IsImplicit) (Syntax: '5')
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  Right: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsImplicit) (Syntax: '6')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (Boxing)
                      Operand: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 6) (Syntax: '6')

            Next (Regular) Block[B5]
                Leaving: {R4}
                Entering: {R5}
    }
    .locals {R5}
    {
        CaptureIds: [4] [5] [6]
        Block[B5] - Block
            Predecessors: [B4]
            Statements (2)
                IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '7')
                  Value: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 7) (Syntax: '7')

                IFlowCaptureOperation: 5 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'C32')
                  Value: 
                    IPropertyReferenceOperation: C3 C2.C32 { get; set; } (OperationKind.PropertyReference, Type: C3) (Syntax: 'C32')
                      Instance Receiver: 
                        IPropertyReferenceOperation: C2 C1.C2 { get; set; } (OperationKind.PropertyReference, Type: C2) (Syntax: 'C2')
                          Instance Receiver: 
                            IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { C2 ... 8 : 9 } } }')

            Jump if False (Regular) to Block[B7]
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

            Next (Regular) Block[B6]
        Block[B6] - Block
            Predecessors: [B5]
            Statements (1)
                IFlowCaptureOperation: 6 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '8')
                  Value: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 8) (Syntax: '8')

            Next (Regular) Block[B8]
        Block[B7] - Block
            Predecessors: [B5]
            Statements (1)
                IFlowCaptureOperation: 6 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '9')
                  Value: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 9) (Syntax: '9')

            Next (Regular) Block[B8]
        Block[B8] - Block
            Predecessors: [B6] [B7]
            Statements (1)
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Object) (Syntax: '[7] = b ? 8 : 9')
                  Left: 
                    IPropertyReferenceOperation: System.Object C3.this[System.Int32 i] { get; set; } (OperationKind.PropertyReference, Type: System.Object) (Syntax: '[7]')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 5 (OperationKind.FlowCaptureReference, Type: C3, IsImplicit) (Syntax: 'C32')
                      Arguments(1):
                          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: '7')
                            IFlowCaptureReferenceOperation: 4 (OperationKind.FlowCaptureReference, Type: System.Int32, Constant: 7, IsImplicit) (Syntax: '7')
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  Right: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsImplicit) (Syntax: 'b ? 8 : 9')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (Boxing)
                      Operand: 
                        IFlowCaptureReferenceOperation: 6 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'b ? 8 : 9')

            Next (Regular) Block[B9]
                Leaving: {R5}
    }

    Block[B9] - Block
        Predecessors: [B8]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: C1, IsImplicit) (Syntax: 'x = new C1  ... 8 : 9 } } }')
              Left: 
                ILocalReferenceOperation: x (IsDeclaration: True) (OperationKind.LocalReference, Type: C1, IsImplicit) (Syntax: 'x = new C1  ... 8 : 9 } } }')
              Right: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { C2 ... 8 : 9 } } }')

        Next (Regular) Block[B10]
            Leaving: {R1}
}

Block[B10] - Exit
    Predecessors: [B9]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,369752,369850);

f_22056_369752_369849(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,355870,369861);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,355870,369861);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,355870,369861);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ObjectCreationFlow_16()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,369873,388730);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,370028,370535);

string 
source = @"
class C1
{
    public C2 C2 { get; set; } = new C2();


    public void M(bool b)
    /*<bind>*/{
        var x = new C1 { C2 = { [""C3""] = b ? new C3 { [1] = 2, [3] = 4 } : new C3 { [5] = 6, [7] = b ? 8 : 9 } } };
    }/*</bind>*/
}

class C2
{
    public C2()
    {
    }

    public object this[string i]
    {
        get => null;
        set { }
    }
}

class C3
{
    public object this[int i]
    {
        get => null;
        set { }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,370549,370602);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,370618,388607);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [C1 x]
    CaptureIds: [0]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new C1 { C2 ... 8 : 9 } } }')
              Value: 
                IObjectCreationOperation (Constructor: C1..ctor()) (OperationKind.ObjectCreation, Type: C1) (Syntax: 'new C1 { C2 ... 8 : 9 } } }')
                  Arguments(0)
                  Initializer: 
                    null

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1] [2] [3]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (2)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '""C3""')
                  Value: 
                    ILiteralOperation (OperationKind.Literal, Type: System.String, Constant: ""C3"") (Syntax: '""C3""')

                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'C2')
                  Value: 
                    IPropertyReferenceOperation: C2 C1.C2 { get; set; } (OperationKind.PropertyReference, Type: C2) (Syntax: 'C2')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { C2 ... 8 : 9 } } }')

            Jump if False (Regular) to Block[B7]
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')
                Entering: {R6}

            Next (Regular) Block[B3]
                Entering: {R3}

        .locals {R3}
        {
            CaptureIds: [4]
            Block[B3] - Block
                Predecessors: [B2]
                Statements (1)
                    IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new C3 { [1 ... , [3] = 4 }')
                      Value: 
                        IObjectCreationOperation (Constructor: C3..ctor()) (OperationKind.ObjectCreation, Type: C3) (Syntax: 'new C3 { [1 ... , [3] = 4 }')
                          Arguments(0)
                          Initializer: 
                            null

                Next (Regular) Block[B4]
                    Entering: {R4}

            .locals {R4}
            {
                CaptureIds: [5]
                Block[B4] - Block
                    Predecessors: [B3]
                    Statements (2)
                        IFlowCaptureOperation: 5 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '1')
                          Value: 
                            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

                        ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Object) (Syntax: '[1] = 2')
                          Left: 
                            IPropertyReferenceOperation: System.Object C3.this[System.Int32 i] { get; set; } (OperationKind.PropertyReference, Type: System.Object) (Syntax: '[1]')
                              Instance Receiver: 
                                IFlowCaptureReferenceOperation: 4 (OperationKind.FlowCaptureReference, Type: C3, IsImplicit) (Syntax: 'new C3 { [1 ... , [3] = 4 }')
                              Arguments(1):
                                  IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: '1')
                                    IFlowCaptureReferenceOperation: 5 (OperationKind.FlowCaptureReference, Type: System.Int32, Constant: 1, IsImplicit) (Syntax: '1')
                                    InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                    OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                          Right: 
                            IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsImplicit) (Syntax: '2')
                              Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                (Boxing)
                              Operand: 
                                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')

                    Next (Regular) Block[B5]
                        Leaving: {R4}
                        Entering: {R5}
            }
            .locals {R5}
            {
                CaptureIds: [6]
                Block[B5] - Block
                    Predecessors: [B4]
                    Statements (2)
                        IFlowCaptureOperation: 6 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '3')
                          Value: 
                            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')

                        ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Object) (Syntax: '[3] = 4')
                          Left: 
                            IPropertyReferenceOperation: System.Object C3.this[System.Int32 i] { get; set; } (OperationKind.PropertyReference, Type: System.Object) (Syntax: '[3]')
                              Instance Receiver: 
                                IFlowCaptureReferenceOperation: 4 (OperationKind.FlowCaptureReference, Type: C3, IsImplicit) (Syntax: 'new C3 { [1 ... , [3] = 4 }')
                              Arguments(1):
                                  IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: '3')
                                    IFlowCaptureReferenceOperation: 6 (OperationKind.FlowCaptureReference, Type: System.Int32, Constant: 3, IsImplicit) (Syntax: '3')
                                    InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                    OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                          Right: 
                            IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsImplicit) (Syntax: '4')
                              Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                (Boxing)
                              Operand: 
                                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 4) (Syntax: '4')

                    Next (Regular) Block[B6]
                        Leaving: {R5}
            }

            Block[B6] - Block
                Predecessors: [B5]
                Statements (1)
                    IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new C3 { [1 ... , [3] = 4 }')
                      Value: 
                        IFlowCaptureReferenceOperation: 4 (OperationKind.FlowCaptureReference, Type: C3, IsImplicit) (Syntax: 'new C3 { [1 ... , [3] = 4 }')

                Next (Regular) Block[B14]
                    Leaving: {R3}
        }
        .locals {R6}
        {
            CaptureIds: [7]
            Block[B7] - Block
                Predecessors: [B2]
                Statements (1)
                    IFlowCaptureOperation: 7 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new C3 { [5 ... b ? 8 : 9 }')
                      Value: 
                        IObjectCreationOperation (Constructor: C3..ctor()) (OperationKind.ObjectCreation, Type: C3) (Syntax: 'new C3 { [5 ... b ? 8 : 9 }')
                          Arguments(0)
                          Initializer: 
                            null

                Next (Regular) Block[B8]
                    Entering: {R7}

            .locals {R7}
            {
                CaptureIds: [8]
                Block[B8] - Block
                    Predecessors: [B7]
                    Statements (2)
                        IFlowCaptureOperation: 8 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '5')
                          Value: 
                            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 5) (Syntax: '5')

                        ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Object) (Syntax: '[5] = 6')
                          Left: 
                            IPropertyReferenceOperation: System.Object C3.this[System.Int32 i] { get; set; } (OperationKind.PropertyReference, Type: System.Object) (Syntax: '[5]')
                              Instance Receiver: 
                                IFlowCaptureReferenceOperation: 7 (OperationKind.FlowCaptureReference, Type: C3, IsImplicit) (Syntax: 'new C3 { [5 ... b ? 8 : 9 }')
                              Arguments(1):
                                  IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: '5')
                                    IFlowCaptureReferenceOperation: 8 (OperationKind.FlowCaptureReference, Type: System.Int32, Constant: 5, IsImplicit) (Syntax: '5')
                                    InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                    OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                          Right: 
                            IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsImplicit) (Syntax: '6')
                              Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                (Boxing)
                              Operand: 
                                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 6) (Syntax: '6')

                    Next (Regular) Block[B9]
                        Leaving: {R7}
                        Entering: {R8}
            }
            .locals {R8}
            {
                CaptureIds: [9] [10]
                Block[B9] - Block
                    Predecessors: [B8]
                    Statements (1)
                        IFlowCaptureOperation: 9 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '7')
                          Value: 
                            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 7) (Syntax: '7')

                    Jump if False (Regular) to Block[B11]
                        IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

                    Next (Regular) Block[B10]
                Block[B10] - Block
                    Predecessors: [B9]
                    Statements (1)
                        IFlowCaptureOperation: 10 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '8')
                          Value: 
                            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 8) (Syntax: '8')

                    Next (Regular) Block[B12]
                Block[B11] - Block
                    Predecessors: [B9]
                    Statements (1)
                        IFlowCaptureOperation: 10 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '9')
                          Value: 
                            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 9) (Syntax: '9')

                    Next (Regular) Block[B12]
                Block[B12] - Block
                    Predecessors: [B10] [B11]
                    Statements (1)
                        ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Object) (Syntax: '[7] = b ? 8 : 9')
                          Left: 
                            IPropertyReferenceOperation: System.Object C3.this[System.Int32 i] { get; set; } (OperationKind.PropertyReference, Type: System.Object) (Syntax: '[7]')
                              Instance Receiver: 
                                IFlowCaptureReferenceOperation: 7 (OperationKind.FlowCaptureReference, Type: C3, IsImplicit) (Syntax: 'new C3 { [5 ... b ? 8 : 9 }')
                              Arguments(1):
                                  IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: '7')
                                    IFlowCaptureReferenceOperation: 9 (OperationKind.FlowCaptureReference, Type: System.Int32, Constant: 7, IsImplicit) (Syntax: '7')
                                    InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                    OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                          Right: 
                            IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsImplicit) (Syntax: 'b ? 8 : 9')
                              Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                (Boxing)
                              Operand: 
                                IFlowCaptureReferenceOperation: 10 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'b ? 8 : 9')

                    Next (Regular) Block[B13]
                        Leaving: {R8}
            }

            Block[B13] - Block
                Predecessors: [B12]
                Statements (1)
                    IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new C3 { [5 ... b ? 8 : 9 }')
                      Value: 
                        IFlowCaptureReferenceOperation: 7 (OperationKind.FlowCaptureReference, Type: C3, IsImplicit) (Syntax: 'new C3 { [5 ... b ? 8 : 9 }')

                Next (Regular) Block[B14]
                    Leaving: {R6}
        }

        Block[B14] - Block
            Predecessors: [B6] [B13]
            Statements (1)
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Object) (Syntax: '[""C3""] = b  ... b ? 8 : 9 }')
                  Left: 
                    IPropertyReferenceOperation: System.Object C2.this[System.String i] { get; set; } (OperationKind.PropertyReference, Type: System.Object) (Syntax: '[""C3""]')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: C2, IsImplicit) (Syntax: 'C2')
                      Arguments(1):
                          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: '""C3""')
                            IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.String, Constant: ""C3"", IsImplicit) (Syntax: '""C3""')
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  Right: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsImplicit) (Syntax: 'b ? new C3  ... b ? 8 : 9 }')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                        (ImplicitReference)
                      Operand: 
                        IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: C3, IsImplicit) (Syntax: 'b ? new C3  ... b ? 8 : 9 }')

            Next (Regular) Block[B15]
                Leaving: {R2}
    }

    Block[B15] - Block
        Predecessors: [B14]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: C1, IsImplicit) (Syntax: 'x = new C1  ... 8 : 9 } } }')
              Left: 
                ILocalReferenceOperation: x (IsDeclaration: True) (OperationKind.LocalReference, Type: C1, IsImplicit) (Syntax: 'x = new C1  ... 8 : 9 } } }')
              Right: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { C2 ... 8 : 9 } } }')

        Next (Regular) Block[B16]
            Leaving: {R1}
}

Block[B16] - Exit
    Predecessors: [B15]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,388621,388719);

f_22056_388621_388718(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,369873,388730);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,369873,388730);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,369873,388730);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ObjectCreationFlow_17()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,388742,396405);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,388897,389363);

string 
source = @"
class C1
{
    public C2 C2 { get; set; }

    public void M(bool b)
    /*<bind>*/{
        var x = new C1 { C2 = { C31 = { [GetInt(1)] = b ? new C1() : null } } };
    }/*</bind>*/

    int GetInt(int x) => x;
}

class C2
{
    public C2()
    {
    }

    public C3 C31 { get; set; }
    public C3 C32 { get; set; }
}

class C3
{
    public object this[int i]
    {
        get => null;
        set { }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,389377,389430);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,389446,396282);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [C1 x]
    CaptureIds: [0]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new C1 { C2 ...  null } } }')
              Value: 
                IObjectCreationOperation (Constructor: C1..ctor()) (OperationKind.ObjectCreation, Type: C1) (Syntax: 'new C1 { C2 ...  null } } }')
                  Arguments(0)
                  Initializer: 
                    null

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1] [2] [3]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (2)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'GetInt(1)')
                  Value: 
                    IInvocationOperation ( System.Int32 C1.GetInt(System.Int32 x)) (OperationKind.Invocation, Type: System.Int32) (Syntax: 'GetInt(1)')
                      Instance Receiver: 
                        IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C1, IsImplicit) (Syntax: 'GetInt')
                      Arguments(1):
                          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: x) (OperationKind.Argument, Type: null) (Syntax: '1')
                            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'C31')
                  Value: 
                    IPropertyReferenceOperation: C3 C2.C31 { get; set; } (OperationKind.PropertyReference, Type: C3) (Syntax: 'C31')
                      Instance Receiver: 
                        IPropertyReferenceOperation: C2 C1.C2 { get; set; } (OperationKind.PropertyReference, Type: C2) (Syntax: 'C2')
                          Instance Receiver: 
                            IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { C2 ...  null } } }')

            Jump if False (Regular) to Block[B4]
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new C1()')
                  Value: 
                    IObjectCreationOperation (Constructor: C1..ctor()) (OperationKind.ObjectCreation, Type: C1) (Syntax: 'new C1()')
                      Arguments(0)
                      Initializer: 
                        null

            Next (Regular) Block[B5]
        Block[B4] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'null')
                  Value: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: C1, Constant: null, IsImplicit) (Syntax: 'null')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                        (ImplicitReference)
                      Operand: 
                        ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')

            Next (Regular) Block[B5]
        Block[B5] - Block
            Predecessors: [B3] [B4]
            Statements (1)
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Object) (Syntax: '[GetInt(1)] ... C1() : null')
                  Left: 
                    IPropertyReferenceOperation: System.Object C3.this[System.Int32 i] { get; set; } (OperationKind.PropertyReference, Type: System.Object) (Syntax: '[GetInt(1)]')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: C3, IsImplicit) (Syntax: 'C31')
                      Arguments(1):
                          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: 'GetInt(1)')
                            IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'GetInt(1)')
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  Right: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsImplicit) (Syntax: 'b ? new C1() : null')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                        (ImplicitReference)
                      Operand: 
                        IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'b ? new C1() : null')

            Next (Regular) Block[B6]
                Leaving: {R2}
    }

    Block[B6] - Block
        Predecessors: [B5]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: C1, IsImplicit) (Syntax: 'x = new C1  ...  null } } }')
              Left: 
                ILocalReferenceOperation: x (IsDeclaration: True) (OperationKind.LocalReference, Type: C1, IsImplicit) (Syntax: 'x = new C1  ...  null } } }')
              Right: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { C2 ...  null } } }')

        Next (Regular) Block[B7]
            Leaving: {R1}
}

Block[B7] - Exit
    Predecessors: [B6]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,396296,396394);

f_22056_396296_396393(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,388742,396405);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,388742,396405);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,388742,396405);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ObjectCreationFlow_18()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,396417,402353);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,396572,396813);

string 
source = @"
class C1
{
    public void M(bool b)
    /*<bind>*/{
        var x = new C1 { [1, b ? 2 : 3] = null };
    }/*</bind>*/

    private C1 this[int i, int j]
    {
        get => null;
        set { }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,396827,396880);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,396896,402230);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [C1 x]
    CaptureIds: [0]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new C1 { [1 ... 3] = null }')
              Value: 
                IObjectCreationOperation (Constructor: C1..ctor()) (OperationKind.ObjectCreation, Type: C1) (Syntax: 'new C1 { [1 ... 3] = null }')
                  Arguments(0)
                  Initializer: 
                    null

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1] [2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '1')
                  Value: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

            Jump if False (Regular) to Block[B4]
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '2')
                  Value: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')

            Next (Regular) Block[B5]
        Block[B4] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '3')
                  Value: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')

            Next (Regular) Block[B5]
        Block[B5] - Block
            Predecessors: [B3] [B4]
            Statements (1)
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: C1) (Syntax: '[1, b ? 2 : 3] = null')
                  Left: 
                    IPropertyReferenceOperation: C1 C1.this[System.Int32 i, System.Int32 j] { get; set; } (OperationKind.PropertyReference, Type: C1) (Syntax: '[1, b ? 2 : 3]')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { [1 ... 3] = null }')
                      Arguments(2):
                          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: '1')
                            IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32, Constant: 1, IsImplicit) (Syntax: '1')
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: j) (OperationKind.Argument, Type: null) (Syntax: 'b ? 2 : 3')
                            IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'b ? 2 : 3')
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  Right: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: C1, Constant: null, IsImplicit) (Syntax: 'null')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                        (ImplicitReference)
                      Operand: 
                        ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')

            Next (Regular) Block[B6]
                Leaving: {R2}
    }

    Block[B6] - Block
        Predecessors: [B5]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: C1, IsImplicit) (Syntax: 'x = new C1  ... 3] = null }')
              Left: 
                ILocalReferenceOperation: x (IsDeclaration: True) (OperationKind.LocalReference, Type: C1, IsImplicit) (Syntax: 'x = new C1  ... 3] = null }')
              Right: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { [1 ... 3] = null }')

        Next (Regular) Block[B7]
            Leaving: {R1}
}

Block[B7] - Exit
    Predecessors: [B6]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,402244,402342);

f_22056_402244_402341(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,396417,402353);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,396417,402353);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,396417,402353);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ObjectCreationFlow_19()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,402365,411780);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,402520,402999);

string 
source = @"
class C1
{
    public C2 C2 { get; set; }

    public void M(bool b, int? i)
    /*<bind>*/{
        var x = new C1 { C2 = { C31 = { [i ?? GetInt(1)] = b ? new C1() : null } } };
    }/*</bind>*/

    int GetInt(int x) => x;
}

class C2
{
    public C2()
    {
    }

    public C3 C31 { get; set; }
    public C3 C32 { get; set; }
}

class C3
{
    public object this[int i]
    {
        get => null;
        set { }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,403013,403066);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,403082,411657);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [C1 x]
    CaptureIds: [0]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new C1 { C2 ...  null } } }')
              Value: 
                IObjectCreationOperation (Constructor: C1..ctor()) (OperationKind.ObjectCreation, Type: C1) (Syntax: 'new C1 { C2 ...  null } } }')
                  Arguments(0)
                  Initializer: 
                    null

        Next (Regular) Block[B2]
            Entering: {R2} {R3}

    .locals {R2}
    {
        CaptureIds: [2] [3] [4]
        .locals {R3}
        {
            CaptureIds: [1]
            Block[B2] - Block
                Predecessors: [B1]
                Statements (1)
                    IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i')
                      Value: 
                        IParameterReferenceOperation: i (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'i')

                Jump if True (Regular) to Block[B4]
                    IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'i')
                      Operand: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'i')
                    Leaving: {R3}

                Next (Regular) Block[B3]
            Block[B3] - Block
                Predecessors: [B2]
                Statements (1)
                    IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i')
                      Value: 
                        IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsImplicit) (Syntax: 'i')
                          Instance Receiver: 
                            IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'i')
                          Arguments(0)

                Next (Regular) Block[B5]
                    Leaving: {R3}
        }

        Block[B4] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'GetInt(1)')
                  Value: 
                    IInvocationOperation ( System.Int32 C1.GetInt(System.Int32 x)) (OperationKind.Invocation, Type: System.Int32) (Syntax: 'GetInt(1)')
                      Instance Receiver: 
                        IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C1, IsImplicit) (Syntax: 'GetInt')
                      Arguments(1):
                          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: x) (OperationKind.Argument, Type: null) (Syntax: '1')
                            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

            Next (Regular) Block[B5]
        Block[B5] - Block
            Predecessors: [B3] [B4]
            Statements (1)
                IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'C31')
                  Value: 
                    IPropertyReferenceOperation: C3 C2.C31 { get; set; } (OperationKind.PropertyReference, Type: C3) (Syntax: 'C31')
                      Instance Receiver: 
                        IPropertyReferenceOperation: C2 C1.C2 { get; set; } (OperationKind.PropertyReference, Type: C2) (Syntax: 'C2')
                          Instance Receiver: 
                            IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { C2 ...  null } } }')

            Jump if False (Regular) to Block[B7]
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

            Next (Regular) Block[B6]
        Block[B6] - Block
            Predecessors: [B5]
            Statements (1)
                IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new C1()')
                  Value: 
                    IObjectCreationOperation (Constructor: C1..ctor()) (OperationKind.ObjectCreation, Type: C1) (Syntax: 'new C1()')
                      Arguments(0)
                      Initializer: 
                        null

            Next (Regular) Block[B8]
        Block[B7] - Block
            Predecessors: [B5]
            Statements (1)
                IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'null')
                  Value: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: C1, Constant: null, IsImplicit) (Syntax: 'null')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                        (ImplicitReference)
                      Operand: 
                        ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')

            Next (Regular) Block[B8]
        Block[B8] - Block
            Predecessors: [B6] [B7]
            Statements (1)
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Object) (Syntax: '[i ?? GetIn ... C1() : null')
                  Left: 
                    IPropertyReferenceOperation: System.Object C3.this[System.Int32 i] { get; set; } (OperationKind.PropertyReference, Type: System.Object) (Syntax: '[i ?? GetInt(1)]')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: C3, IsImplicit) (Syntax: 'C31')
                      Arguments(1):
                          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: 'i ?? GetInt(1)')
                            IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'i ?? GetInt(1)')
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  Right: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsImplicit) (Syntax: 'b ? new C1() : null')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                        (ImplicitReference)
                      Operand: 
                        IFlowCaptureReferenceOperation: 4 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'b ? new C1() : null')

            Next (Regular) Block[B9]
                Leaving: {R2}
    }

    Block[B9] - Block
        Predecessors: [B8]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: C1, IsImplicit) (Syntax: 'x = new C1  ...  null } } }')
              Left: 
                ILocalReferenceOperation: x (IsDeclaration: True) (OperationKind.LocalReference, Type: C1, IsImplicit) (Syntax: 'x = new C1  ...  null } } }')
              Right: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { C2 ...  null } } }')

        Next (Regular) Block[B10]
            Leaving: {R1}
}

Block[B10] - Exit
    Predecessors: [B9]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,411671,411769);

f_22056_411671_411768(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,402365,411780);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,402365,411780);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,402365,411780);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ObjectCreationFlow_20()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,411792,417815);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,411947,412137);

string 
source = @"
class C1
{
    public void M(bool b)
    /*<bind>*/{
        var x = new C1 { O[b ? 1 : 2] = null };
    }/*</bind>*/

    public object[] O { get; set; }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,412151,412841);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22056_412441_412567(f_22056_412441_412547(f_22056_412441_412527(ErrorCode.ERR_CollectionInitRequiresIEnumerable, "{ O[b ? 1 : 2] = null }"), "C1"), 6, 24),
f_22056_412720_412825(f_22056_412720_412805(ErrorCode.ERR_InvalidInitializerElementInitializer, "O[b ? 1 : 2] = null"), 6, 26)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,412857,417692);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [C1 x]
    CaptureIds: [0]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'new C1 { O[ ... 2] = null }')
              Value: 
                IObjectCreationOperation (Constructor: C1..ctor()) (OperationKind.ObjectCreation, Type: C1, IsInvalid) (Syntax: 'new C1 { O[ ... 2] = null }')
                  Arguments(0)
                  Initializer: 
                    null

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1] [2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'O')
                  Value: 
                    IPropertyReferenceOperation: System.Object[] C1.O { get; set; } (OperationKind.PropertyReference, Type: System.Object[], IsInvalid) (Syntax: 'O')
                      Instance Receiver: 
                        IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C1, IsInvalid, IsImplicit) (Syntax: 'O')

            Jump if False (Regular) to Block[B4]
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean, IsInvalid) (Syntax: 'b')

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: '1')
                  Value: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1, IsInvalid) (Syntax: '1')

            Next (Regular) Block[B5]
        Block[B4] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: '2')
                  Value: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2, IsInvalid) (Syntax: '2')

            Next (Regular) Block[B5]
        Block[B5] - Block
            Predecessors: [B3] [B4]
            Statements (1)
                IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid, IsImplicit) (Syntax: 'O[b ? 1 : 2] = null')
                  Children(1):
                      ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Object, IsInvalid) (Syntax: 'O[b ? 1 : 2] = null')
                        Left: 
                          IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: System.Object, IsInvalid) (Syntax: 'O[b ? 1 : 2]')
                            Array reference: 
                              IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Object[], IsInvalid, IsImplicit) (Syntax: 'O')
                            Indices(1):
                                IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'b ? 1 : 2')
                        Right: 
                          IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, Constant: null, IsInvalid, IsImplicit) (Syntax: 'null')
                            Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                              (ImplicitReference)
                            Operand: 
                              ILiteralOperation (OperationKind.Literal, Type: null, Constant: null, IsInvalid) (Syntax: 'null')

            Next (Regular) Block[B6]
                Leaving: {R2}
    }

    Block[B6] - Block
        Predecessors: [B5]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: C1, IsInvalid, IsImplicit) (Syntax: 'x = new C1  ... 2] = null }')
              Left: 
                ILocalReferenceOperation: x (IsDeclaration: True) (OperationKind.LocalReference, Type: C1, IsInvalid, IsImplicit) (Syntax: 'x = new C1  ... 2] = null }')
              Right: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C1, IsInvalid, IsImplicit) (Syntax: 'new C1 { O[ ... 2] = null }')

        Next (Regular) Block[B7]
            Leaving: {R1}
}

Block[B7] - Exit
    Predecessors: [B6]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,417706,417804);

f_22056_417706_417803(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,411792,417815);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,411792,417815);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,411792,417815);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ObjectCreationFlow_21()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,417827,420223);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,417982,418178);

string 
source = @"
public class MyClass
{
    public int A;
    static void M()
    /*<bind>*/{
        var a = new MyClass
        {
            A = 1
        };
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,418192,418245);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,418261,420100);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [MyClass a]
    CaptureIds: [0]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (3)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new MyClass ... }')
              Value: 
                IObjectCreationOperation (Constructor: MyClass..ctor()) (OperationKind.ObjectCreation, Type: MyClass) (Syntax: 'new MyClass ... }')
                  Arguments(0)
                  Initializer: 
                    null

            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'A = 1')
              Left: 
                IFieldReferenceOperation: System.Int32 MyClass.A (OperationKind.FieldReference, Type: System.Int32) (Syntax: 'A')
                  Instance Receiver: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: MyClass, IsImplicit) (Syntax: 'new MyClass ... }')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: MyClass, IsImplicit) (Syntax: 'a = new MyC ... }')
              Left: 
                ILocalReferenceOperation: a (IsDeclaration: True) (OperationKind.LocalReference, Type: MyClass, IsImplicit) (Syntax: 'a = new MyC ... }')
              Right: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: MyClass, IsImplicit) (Syntax: 'new MyClass ... }')

        Next (Regular) Block[B2]
            Leaving: {R1}
}

Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,420114,420212);

f_22056_420114_420211(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,417827,420223);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,417827,420223);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,417827,420223);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ObjectCreationFlow_22()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,420233,424737);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,420388,420637);

string 
source = @"
public class MyClass
{
    public int A;
    public int B;
    static void M(bool b)
    /*<bind>*/{
        var a = new MyClass
        {
            A = 1,
            B = b ? 2 : 3
        };
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,420651,420704);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,420720,424614);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [MyClass a]
    CaptureIds: [0]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (2)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new MyClass ... }')
              Value: 
                IObjectCreationOperation (Constructor: MyClass..ctor()) (OperationKind.ObjectCreation, Type: MyClass) (Syntax: 'new MyClass ... }')
                  Arguments(0)
                  Initializer: 
                    null

            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'A = 1')
              Left: 
                IFieldReferenceOperation: System.Int32 MyClass.A (OperationKind.FieldReference, Type: System.Int32) (Syntax: 'A')
                  Instance Receiver: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: MyClass, IsImplicit) (Syntax: 'new MyClass ... }')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (0)
            Jump if False (Regular) to Block[B4]
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '2')
                  Value: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')

            Next (Regular) Block[B5]
        Block[B4] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '3')
                  Value: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')

            Next (Regular) Block[B5]
        Block[B5] - Block
            Predecessors: [B3] [B4]
            Statements (1)
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'B = b ? 2 : 3')
                  Left: 
                    IFieldReferenceOperation: System.Int32 MyClass.B (OperationKind.FieldReference, Type: System.Int32) (Syntax: 'B')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: MyClass, IsImplicit) (Syntax: 'new MyClass ... }')
                  Right: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'b ? 2 : 3')

            Next (Regular) Block[B6]
                Leaving: {R2}
    }

    Block[B6] - Block
        Predecessors: [B5]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: MyClass, IsImplicit) (Syntax: 'a = new MyC ... }')
              Left: 
                ILocalReferenceOperation: a (IsDeclaration: True) (OperationKind.LocalReference, Type: MyClass, IsImplicit) (Syntax: 'a = new MyC ... }')
              Right: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: MyClass, IsImplicit) (Syntax: 'new MyClass ... }')

        Next (Regular) Block[B7]
            Leaving: {R1}
}

Block[B7] - Exit
    Predecessors: [B6]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,424628,424726);

f_22056_424628_424725(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,420233,424737);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,420233,424737);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,420233,424737);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ObjectCreationFlow_23()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,424749,429232);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,424904,425112);

string 
source = @"
public class MyClass
{
    public object A;
    static void M(bool b)
    /*<bind>*/{
        var a = new MyClass
        {
            A = 1
        }?.A;
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,425126,425179);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,425195,429109);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2}

.locals {R1}
{
    Locals: [System.Object a]
    CaptureIds: [1]
    .locals {R2}
    {
        CaptureIds: [0]
        Block[B1] - Block
            Predecessors: [B0]
            Statements (2)
                IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new MyClass ... }')
                  Value: 
                    IObjectCreationOperation (Constructor: MyClass..ctor()) (OperationKind.ObjectCreation, Type: MyClass) (Syntax: 'new MyClass ... }')
                      Arguments(0)
                      Initializer: 
                        null

                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Object) (Syntax: 'A = 1')
                  Left: 
                    IFieldReferenceOperation: System.Object MyClass.A (OperationKind.FieldReference, Type: System.Object) (Syntax: 'A')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: MyClass, IsImplicit) (Syntax: 'new MyClass ... }')
                  Right: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsImplicit) (Syntax: '1')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (Boxing)
                      Operand: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

            Jump if True (Regular) to Block[B3]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'new MyClass ... }')
                  Operand: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: MyClass, IsImplicit) (Syntax: 'new MyClass ... }')
                Leaving: {R2}

            Next (Regular) Block[B2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '.A')
                  Value: 
                    IFieldReferenceOperation: System.Object MyClass.A (OperationKind.FieldReference, Type: System.Object) (Syntax: '.A')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: MyClass, IsImplicit) (Syntax: 'new MyClass ... }')

            Next (Regular) Block[B4]
                Leaving: {R2}
    }

    Block[B3] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new MyClass ... }')
              Value: 
                IDefaultValueOperation (OperationKind.DefaultValue, Type: System.Object, Constant: null, IsImplicit) (Syntax: 'new MyClass ... }')

        Next (Regular) Block[B4]
    Block[B4] - Block
        Predecessors: [B2] [B3]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Object, IsImplicit) (Syntax: 'a = new MyC ... }?.A')
              Left: 
                ILocalReferenceOperation: a (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Object, IsImplicit) (Syntax: 'a = new MyC ... }?.A')
              Right: 
                IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'new MyClass ... }?.A')

        Next (Regular) Block[B5]
            Leaving: {R1}
}

Block[B5] - Exit
    Predecessors: [B4]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,429123,429221);

f_22056_429123_429220(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,424749,429232);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,424749,429232);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,424749,429232);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ObjectCreationFlow_24()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,429244,433329);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,429399,429726);

string 
source = @"
class C1
{
    public C2 C2;

    public void M()
    /*<bind>*/{
        var x = new C1 { C2 = { C31 = { P1 = 1, P2 = 2 } } };
    }/*</bind>*/
}

class C2
{
    public C2()
    {
    }

    public C3 C31;
    public C3 C32;
}

class C3
{
    public int P1;
    public int P2;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,429740,430086);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22056_429961_430070(f_22056_429961_430049(f_22056_429961_430017(ErrorCode.WRN_UnassignedInternalField, "C32"), "C2.C32", "null"), 19, 15)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,430102,433206);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [C1 x]
    CaptureIds: [0]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (4)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new C1 { C2 ... 2 = 2 } } }')
              Value: 
                IObjectCreationOperation (Constructor: C1..ctor()) (OperationKind.ObjectCreation, Type: C1) (Syntax: 'new C1 { C2 ... 2 = 2 } } }')
                  Arguments(0)
                  Initializer: 
                    null

            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'P1 = 1')
              Left: 
                IFieldReferenceOperation: System.Int32 C3.P1 (OperationKind.FieldReference, Type: System.Int32) (Syntax: 'P1')
                  Instance Receiver: 
                    IFieldReferenceOperation: C3 C2.C31 (OperationKind.FieldReference, Type: C3) (Syntax: 'C31')
                      Instance Receiver: 
                        IFieldReferenceOperation: C2 C1.C2 (OperationKind.FieldReference, Type: C2) (Syntax: 'C2')
                          Instance Receiver: 
                            IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { C2 ... 2 = 2 } } }')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'P2 = 2')
              Left: 
                IFieldReferenceOperation: System.Int32 C3.P2 (OperationKind.FieldReference, Type: System.Int32) (Syntax: 'P2')
                  Instance Receiver: 
                    IFieldReferenceOperation: C3 C2.C31 (OperationKind.FieldReference, Type: C3) (Syntax: 'C31')
                      Instance Receiver: 
                        IFieldReferenceOperation: C2 C1.C2 (OperationKind.FieldReference, Type: C2) (Syntax: 'C2')
                          Instance Receiver: 
                            IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { C2 ... 2 = 2 } } }')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')

            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: C1, IsImplicit) (Syntax: 'x = new C1  ... 2 = 2 } } }')
              Left: 
                ILocalReferenceOperation: x (IsDeclaration: True) (OperationKind.LocalReference, Type: C1, IsImplicit) (Syntax: 'x = new C1  ... 2 = 2 } } }')
              Right: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { C2 ... 2 = 2 } } }')

        Next (Regular) Block[B2]
            Leaving: {R1}
}

Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,433220,433318);

f_22056_433220_433317(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,429244,433329);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,429244,433329);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,429244,433329);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ControlFlow_25()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,433341,440739);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,433489,433856);

string 
source = @"
class C1
{
    public C2 C2;

    public void M(bool b)
    /*<bind>*/{
        var x = new C1 { C2 = { C31 = { P1 = 1, P2 = 2 }, C32 = { P1 = 3, P2 = b ? 4 : 5 } } };
    }/*</bind>*/
}

class C2
{
    public C2()
    {
    }

    public C3 C31;
    public C3 C32;
}

class C3
{
    public int P1;
    public int P2;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,433870,433923);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,433939,440616);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [C1 x]
    CaptureIds: [0]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (4)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new C1 { C2 ... 4 : 5 } } }')
              Value: 
                IObjectCreationOperation (Constructor: C1..ctor()) (OperationKind.ObjectCreation, Type: C1) (Syntax: 'new C1 { C2 ... 4 : 5 } } }')
                  Arguments(0)
                  Initializer: 
                    null

            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'P1 = 1')
              Left: 
                IFieldReferenceOperation: System.Int32 C3.P1 (OperationKind.FieldReference, Type: System.Int32) (Syntax: 'P1')
                  Instance Receiver: 
                    IFieldReferenceOperation: C3 C2.C31 (OperationKind.FieldReference, Type: C3) (Syntax: 'C31')
                      Instance Receiver: 
                        IFieldReferenceOperation: C2 C1.C2 (OperationKind.FieldReference, Type: C2) (Syntax: 'C2')
                          Instance Receiver: 
                            IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { C2 ... 4 : 5 } } }')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'P2 = 2')
              Left: 
                IFieldReferenceOperation: System.Int32 C3.P2 (OperationKind.FieldReference, Type: System.Int32) (Syntax: 'P2')
                  Instance Receiver: 
                    IFieldReferenceOperation: C3 C2.C31 (OperationKind.FieldReference, Type: C3) (Syntax: 'C31')
                      Instance Receiver: 
                        IFieldReferenceOperation: C2 C1.C2 (OperationKind.FieldReference, Type: C2) (Syntax: 'C2')
                          Instance Receiver: 
                            IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { C2 ... 4 : 5 } } }')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')

            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'P1 = 3')
              Left: 
                IFieldReferenceOperation: System.Int32 C3.P1 (OperationKind.FieldReference, Type: System.Int32) (Syntax: 'P1')
                  Instance Receiver: 
                    IFieldReferenceOperation: C3 C2.C32 (OperationKind.FieldReference, Type: C3) (Syntax: 'C32')
                      Instance Receiver: 
                        IFieldReferenceOperation: C2 C1.C2 (OperationKind.FieldReference, Type: C2) (Syntax: 'C2')
                          Instance Receiver: 
                            IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { C2 ... 4 : 5 } } }')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1] [2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'C32')
                  Value: 
                    IFieldReferenceOperation: C3 C2.C32 (OperationKind.FieldReference, Type: C3) (Syntax: 'C32')
                      Instance Receiver: 
                        IFieldReferenceOperation: C2 C1.C2 (OperationKind.FieldReference, Type: C2) (Syntax: 'C2')
                          Instance Receiver: 
                            IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { C2 ... 4 : 5 } } }')

            Jump if False (Regular) to Block[B4]
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '4')
                  Value: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 4) (Syntax: '4')

            Next (Regular) Block[B5]
        Block[B4] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '5')
                  Value: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 5) (Syntax: '5')

            Next (Regular) Block[B5]
        Block[B5] - Block
            Predecessors: [B3] [B4]
            Statements (1)
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'P2 = b ? 4 : 5')
                  Left: 
                    IFieldReferenceOperation: System.Int32 C3.P2 (OperationKind.FieldReference, Type: System.Int32) (Syntax: 'P2')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C3, IsImplicit) (Syntax: 'C32')
                  Right: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'b ? 4 : 5')

            Next (Regular) Block[B6]
                Leaving: {R2}
    }

    Block[B6] - Block
        Predecessors: [B5]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: C1, IsImplicit) (Syntax: 'x = new C1  ... 4 : 5 } } }')
              Left: 
                ILocalReferenceOperation: x (IsDeclaration: True) (OperationKind.LocalReference, Type: C1, IsImplicit) (Syntax: 'x = new C1  ... 4 : 5 } } }')
              Right: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { C2 ... 4 : 5 } } }')

        Next (Regular) Block[B7]
            Leaving: {R1}
}

Block[B7] - Exit
    Predecessors: [B6]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,440630,440728);

f_22056_440630_440727(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,433341,440739);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,433341,440739);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,433341,440739);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ObjectCreationFlow_26()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,440751,448156);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,440906,441273);

string 
source = @"
class C1
{
    public C2 C2;

    public void M(bool b)
    /*<bind>*/{
        var x = new C1 { C2 = { C31 = { P1 = b ? 1 : 5, P2 = 2 }, C32 = { P1 = 3, P2 = 4 } } };
    }/*</bind>*/
}

class C2
{
    public C2()
    {
    }

    public C3 C31;
    public C3 C32;
}

class C3
{
    public int P1;
    public int P2;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,441287,441340);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,441356,448033);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [C1 x]
    CaptureIds: [0]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new C1 { C2 ... 2 = 4 } } }')
              Value: 
                IObjectCreationOperation (Constructor: C1..ctor()) (OperationKind.ObjectCreation, Type: C1) (Syntax: 'new C1 { C2 ... 2 = 4 } } }')
                  Arguments(0)
                  Initializer: 
                    null

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1] [2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'C31')
                  Value: 
                    IFieldReferenceOperation: C3 C2.C31 (OperationKind.FieldReference, Type: C3) (Syntax: 'C31')
                      Instance Receiver: 
                        IFieldReferenceOperation: C2 C1.C2 (OperationKind.FieldReference, Type: C2) (Syntax: 'C2')
                          Instance Receiver: 
                            IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { C2 ... 2 = 4 } } }')

            Jump if False (Regular) to Block[B4]
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '1')
                  Value: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

            Next (Regular) Block[B5]
        Block[B4] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '5')
                  Value: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 5) (Syntax: '5')

            Next (Regular) Block[B5]
        Block[B5] - Block
            Predecessors: [B3] [B4]
            Statements (1)
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'P1 = b ? 1 : 5')
                  Left: 
                    IFieldReferenceOperation: System.Int32 C3.P1 (OperationKind.FieldReference, Type: System.Int32) (Syntax: 'P1')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C3, IsImplicit) (Syntax: 'C31')
                  Right: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'b ? 1 : 5')

            Next (Regular) Block[B6]
                Leaving: {R2}
    }

    Block[B6] - Block
        Predecessors: [B5]
        Statements (4)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'P2 = 2')
              Left: 
                IFieldReferenceOperation: System.Int32 C3.P2 (OperationKind.FieldReference, Type: System.Int32) (Syntax: 'P2')
                  Instance Receiver: 
                    IFieldReferenceOperation: C3 C2.C31 (OperationKind.FieldReference, Type: C3) (Syntax: 'C31')
                      Instance Receiver: 
                        IFieldReferenceOperation: C2 C1.C2 (OperationKind.FieldReference, Type: C2) (Syntax: 'C2')
                          Instance Receiver: 
                            IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { C2 ... 2 = 4 } } }')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')

            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'P1 = 3')
              Left: 
                IFieldReferenceOperation: System.Int32 C3.P1 (OperationKind.FieldReference, Type: System.Int32) (Syntax: 'P1')
                  Instance Receiver: 
                    IFieldReferenceOperation: C3 C2.C32 (OperationKind.FieldReference, Type: C3) (Syntax: 'C32')
                      Instance Receiver: 
                        IFieldReferenceOperation: C2 C1.C2 (OperationKind.FieldReference, Type: C2) (Syntax: 'C2')
                          Instance Receiver: 
                            IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { C2 ... 2 = 4 } } }')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')

            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'P2 = 4')
              Left: 
                IFieldReferenceOperation: System.Int32 C3.P2 (OperationKind.FieldReference, Type: System.Int32) (Syntax: 'P2')
                  Instance Receiver: 
                    IFieldReferenceOperation: C3 C2.C32 (OperationKind.FieldReference, Type: C3) (Syntax: 'C32')
                      Instance Receiver: 
                        IFieldReferenceOperation: C2 C1.C2 (OperationKind.FieldReference, Type: C2) (Syntax: 'C2')
                          Instance Receiver: 
                            IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { C2 ... 2 = 4 } } }')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 4) (Syntax: '4')

            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: C1, IsImplicit) (Syntax: 'x = new C1  ... 2 = 4 } } }')
              Left: 
                ILocalReferenceOperation: x (IsDeclaration: True) (OperationKind.LocalReference, Type: C1, IsImplicit) (Syntax: 'x = new C1  ... 2 = 4 } } }')
              Right: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { C2 ... 2 = 4 } } }')

        Next (Regular) Block[B7]
            Leaving: {R1}
}

Block[B7] - Exit
    Predecessors: [B6]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,448047,448145);

f_22056_448047_448144(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,440751,448156);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,440751,448156);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,440751,448156);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ObjectCreationFlow_27()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,448168,460579);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,448323,448732);

string 
source = @"
class C1
{
    public C2 C2;


    public void M(bool b)
    /*<bind>*/{
        var x = new C1 { C2 = { C31 = { [1] = 2, [3] = 4 }, C32 = { [5] = 6, [7] = 8 } } };
    }/*</bind>*/
}

class C2
{
    public C2()
    {
    }

    public C3 C31;
    public C3 C32;
}

class C3
{
    public object this[int i]
    {
        get => null;
        set { }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,448746,448799);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,448815,460456);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [C1 x]
    CaptureIds: [0]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new C1 { C2 ... ] = 8 } } }')
              Value: 
                IObjectCreationOperation (Constructor: C1..ctor()) (OperationKind.ObjectCreation, Type: C1) (Syntax: 'new C1 { C2 ... ] = 8 } } }')
                  Arguments(0)
                  Initializer: 
                    null

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (2)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '1')
                  Value: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Object) (Syntax: '[1] = 2')
                  Left: 
                    IPropertyReferenceOperation: System.Object C3.this[System.Int32 i] { get; set; } (OperationKind.PropertyReference, Type: System.Object) (Syntax: '[1]')
                      Instance Receiver: 
                        IFieldReferenceOperation: C3 C2.C31 (OperationKind.FieldReference, Type: C3) (Syntax: 'C31')
                          Instance Receiver: 
                            IFieldReferenceOperation: C2 C1.C2 (OperationKind.FieldReference, Type: C2) (Syntax: 'C2')
                              Instance Receiver: 
                                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { C2 ... ] = 8 } } }')
                      Arguments(1):
                          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: '1')
                            IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32, Constant: 1, IsImplicit) (Syntax: '1')
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  Right: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsImplicit) (Syntax: '2')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (Boxing)
                      Operand: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')

            Next (Regular) Block[B3]
                Leaving: {R2}
                Entering: {R3}
    }
    .locals {R3}
    {
        CaptureIds: [2]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (2)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '3')
                  Value: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')

                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Object) (Syntax: '[3] = 4')
                  Left: 
                    IPropertyReferenceOperation: System.Object C3.this[System.Int32 i] { get; set; } (OperationKind.PropertyReference, Type: System.Object) (Syntax: '[3]')
                      Instance Receiver: 
                        IFieldReferenceOperation: C3 C2.C31 (OperationKind.FieldReference, Type: C3) (Syntax: 'C31')
                          Instance Receiver: 
                            IFieldReferenceOperation: C2 C1.C2 (OperationKind.FieldReference, Type: C2) (Syntax: 'C2')
                              Instance Receiver: 
                                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { C2 ... ] = 8 } } }')
                      Arguments(1):
                          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: '3')
                            IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, Constant: 3, IsImplicit) (Syntax: '3')
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  Right: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsImplicit) (Syntax: '4')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (Boxing)
                      Operand: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 4) (Syntax: '4')

            Next (Regular) Block[B4]
                Leaving: {R3}
                Entering: {R4}
    }
    .locals {R4}
    {
        CaptureIds: [3]
        Block[B4] - Block
            Predecessors: [B3]
            Statements (2)
                IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '5')
                  Value: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 5) (Syntax: '5')

                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Object) (Syntax: '[5] = 6')
                  Left: 
                    IPropertyReferenceOperation: System.Object C3.this[System.Int32 i] { get; set; } (OperationKind.PropertyReference, Type: System.Object) (Syntax: '[5]')
                      Instance Receiver: 
                        IFieldReferenceOperation: C3 C2.C32 (OperationKind.FieldReference, Type: C3) (Syntax: 'C32')
                          Instance Receiver: 
                            IFieldReferenceOperation: C2 C1.C2 (OperationKind.FieldReference, Type: C2) (Syntax: 'C2')
                              Instance Receiver: 
                                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { C2 ... ] = 8 } } }')
                      Arguments(1):
                          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: '5')
                            IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Int32, Constant: 5, IsImplicit) (Syntax: '5')
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  Right: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsImplicit) (Syntax: '6')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (Boxing)
                      Operand: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 6) (Syntax: '6')

            Next (Regular) Block[B5]
                Leaving: {R4}
                Entering: {R5}
    }
    .locals {R5}
    {
        CaptureIds: [4]
        Block[B5] - Block
            Predecessors: [B4]
            Statements (2)
                IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '7')
                  Value: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 7) (Syntax: '7')

                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Object) (Syntax: '[7] = 8')
                  Left: 
                    IPropertyReferenceOperation: System.Object C3.this[System.Int32 i] { get; set; } (OperationKind.PropertyReference, Type: System.Object) (Syntax: '[7]')
                      Instance Receiver: 
                        IFieldReferenceOperation: C3 C2.C32 (OperationKind.FieldReference, Type: C3) (Syntax: 'C32')
                          Instance Receiver: 
                            IFieldReferenceOperation: C2 C1.C2 (OperationKind.FieldReference, Type: C2) (Syntax: 'C2')
                              Instance Receiver: 
                                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { C2 ... ] = 8 } } }')
                      Arguments(1):
                          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: '7')
                            IFlowCaptureReferenceOperation: 4 (OperationKind.FlowCaptureReference, Type: System.Int32, Constant: 7, IsImplicit) (Syntax: '7')
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  Right: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsImplicit) (Syntax: '8')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (Boxing)
                      Operand: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 8) (Syntax: '8')

            Next (Regular) Block[B6]
                Leaving: {R5}
    }

    Block[B6] - Block
        Predecessors: [B5]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: C1, IsImplicit) (Syntax: 'x = new C1  ... ] = 8 } } }')
              Left: 
                ILocalReferenceOperation: x (IsDeclaration: True) (OperationKind.LocalReference, Type: C1, IsImplicit) (Syntax: 'x = new C1  ... ] = 8 } } }')
              Right: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { C2 ... ] = 8 } } }')

        Next (Regular) Block[B7]
            Leaving: {R1}
}

Block[B7] - Exit
    Predecessors: [B6]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,460470,460568);

f_22056_460470_460567(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,448168,460579);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,448168,460579);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,448168,460579);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ObjectCreationFlow_28()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,460591,473830);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,460746,461163);

string 
source = @"
class C1
{
    public C2 C2;


    public void M(bool b)
    /*<bind>*/{
        var x = new C1 { C2 = { C31 = { [1] = 2, [3] = 4 }, C32 = { [5] = 6, [b ? 7 : 8] = 9 } } };
    }/*</bind>*/
}

class C2
{
    public C2()
    {
    }

    public C3 C31;
    public C3 C32;
}

class C3
{
    public object this[int i]
    {
        get => null;
        set { }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,461177,461230);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,461246,473707);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [C1 x]
    CaptureIds: [0]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new C1 { C2 ... ] = 9 } } }')
              Value: 
                IObjectCreationOperation (Constructor: C1..ctor()) (OperationKind.ObjectCreation, Type: C1) (Syntax: 'new C1 { C2 ... ] = 9 } } }')
                  Arguments(0)
                  Initializer: 
                    null

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (2)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '1')
                  Value: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Object) (Syntax: '[1] = 2')
                  Left: 
                    IPropertyReferenceOperation: System.Object C3.this[System.Int32 i] { get; set; } (OperationKind.PropertyReference, Type: System.Object) (Syntax: '[1]')
                      Instance Receiver: 
                        IFieldReferenceOperation: C3 C2.C31 (OperationKind.FieldReference, Type: C3) (Syntax: 'C31')
                          Instance Receiver: 
                            IFieldReferenceOperation: C2 C1.C2 (OperationKind.FieldReference, Type: C2) (Syntax: 'C2')
                              Instance Receiver: 
                                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { C2 ... ] = 9 } } }')
                      Arguments(1):
                          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: '1')
                            IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32, Constant: 1, IsImplicit) (Syntax: '1')
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  Right: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsImplicit) (Syntax: '2')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (Boxing)
                      Operand: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')

            Next (Regular) Block[B3]
                Leaving: {R2}
                Entering: {R3}
    }
    .locals {R3}
    {
        CaptureIds: [2]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (2)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '3')
                  Value: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')

                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Object) (Syntax: '[3] = 4')
                  Left: 
                    IPropertyReferenceOperation: System.Object C3.this[System.Int32 i] { get; set; } (OperationKind.PropertyReference, Type: System.Object) (Syntax: '[3]')
                      Instance Receiver: 
                        IFieldReferenceOperation: C3 C2.C31 (OperationKind.FieldReference, Type: C3) (Syntax: 'C31')
                          Instance Receiver: 
                            IFieldReferenceOperation: C2 C1.C2 (OperationKind.FieldReference, Type: C2) (Syntax: 'C2')
                              Instance Receiver: 
                                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { C2 ... ] = 9 } } }')
                      Arguments(1):
                          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: '3')
                            IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, Constant: 3, IsImplicit) (Syntax: '3')
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  Right: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsImplicit) (Syntax: '4')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (Boxing)
                      Operand: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 4) (Syntax: '4')

            Next (Regular) Block[B4]
                Leaving: {R3}
                Entering: {R4}
    }
    .locals {R4}
    {
        CaptureIds: [3]
        Block[B4] - Block
            Predecessors: [B3]
            Statements (2)
                IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '5')
                  Value: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 5) (Syntax: '5')

                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Object) (Syntax: '[5] = 6')
                  Left: 
                    IPropertyReferenceOperation: System.Object C3.this[System.Int32 i] { get; set; } (OperationKind.PropertyReference, Type: System.Object) (Syntax: '[5]')
                      Instance Receiver: 
                        IFieldReferenceOperation: C3 C2.C32 (OperationKind.FieldReference, Type: C3) (Syntax: 'C32')
                          Instance Receiver: 
                            IFieldReferenceOperation: C2 C1.C2 (OperationKind.FieldReference, Type: C2) (Syntax: 'C2')
                              Instance Receiver: 
                                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { C2 ... ] = 9 } } }')
                      Arguments(1):
                          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: '5')
                            IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Int32, Constant: 5, IsImplicit) (Syntax: '5')
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  Right: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsImplicit) (Syntax: '6')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (Boxing)
                      Operand: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 6) (Syntax: '6')

            Next (Regular) Block[B5]
                Leaving: {R4}
                Entering: {R5}
    }
    .locals {R5}
    {
        CaptureIds: [4]
        Block[B5] - Block
            Predecessors: [B4]
            Statements (0)
            Jump if False (Regular) to Block[B7]
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

            Next (Regular) Block[B6]
        Block[B6] - Block
            Predecessors: [B5]
            Statements (1)
                IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '7')
                  Value: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 7) (Syntax: '7')

            Next (Regular) Block[B8]
        Block[B7] - Block
            Predecessors: [B5]
            Statements (1)
                IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '8')
                  Value: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 8) (Syntax: '8')

            Next (Regular) Block[B8]
        Block[B8] - Block
            Predecessors: [B6] [B7]
            Statements (1)
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Object) (Syntax: '[b ? 7 : 8] = 9')
                  Left: 
                    IPropertyReferenceOperation: System.Object C3.this[System.Int32 i] { get; set; } (OperationKind.PropertyReference, Type: System.Object) (Syntax: '[b ? 7 : 8]')
                      Instance Receiver: 
                        IFieldReferenceOperation: C3 C2.C32 (OperationKind.FieldReference, Type: C3) (Syntax: 'C32')
                          Instance Receiver: 
                            IFieldReferenceOperation: C2 C1.C2 (OperationKind.FieldReference, Type: C2) (Syntax: 'C2')
                              Instance Receiver: 
                                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { C2 ... ] = 9 } } }')
                      Arguments(1):
                          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: 'b ? 7 : 8')
                            IFlowCaptureReferenceOperation: 4 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'b ? 7 : 8')
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  Right: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsImplicit) (Syntax: '9')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (Boxing)
                      Operand: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 9) (Syntax: '9')

            Next (Regular) Block[B9]
                Leaving: {R5}
    }

    Block[B9] - Block
        Predecessors: [B8]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: C1, IsImplicit) (Syntax: 'x = new C1  ... ] = 9 } } }')
              Left: 
                ILocalReferenceOperation: x (IsDeclaration: True) (OperationKind.LocalReference, Type: C1, IsImplicit) (Syntax: 'x = new C1  ... ] = 9 } } }')
              Right: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { C2 ... ] = 9 } } }')

        Next (Regular) Block[B10]
            Leaving: {R1}
}

Block[B10] - Exit
    Predecessors: [B9]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,473721,473819);

f_22056_473721_473818(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,460591,473830);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,460591,473830);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,460591,473830);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ObjectCreationFlow_29()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,473842,492621);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,473997,474446);

string 
source = @"
class C1
{
    public C2 C2;


    public void M(bool b)
    /*<bind>*/{
        var x = new C1 { C2 = { [""C3""] = b ? new C3 { [1] = 2, [3] = 4 } : new C3 { [5] = 6, [7] = b ? 8 : 9 } } };
    }/*</bind>*/
}

class C2
{
    public object this[string i]
    {
        get => null;
        set { }
    }
}

class C3
{
    public object this[int i]
    {
        get => null;
        set { }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,474460,474513);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,474529,492498);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [C1 x]
    CaptureIds: [0]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new C1 { C2 ... 8 : 9 } } }')
              Value: 
                IObjectCreationOperation (Constructor: C1..ctor()) (OperationKind.ObjectCreation, Type: C1) (Syntax: 'new C1 { C2 ... 8 : 9 } } }')
                  Arguments(0)
                  Initializer: 
                    null

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1] [2] [3]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (2)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '""C3""')
                  Value: 
                    ILiteralOperation (OperationKind.Literal, Type: System.String, Constant: ""C3"") (Syntax: '""C3""')

                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'C2')
                  Value: 
                    IFieldReferenceOperation: C2 C1.C2 (OperationKind.FieldReference, Type: C2) (Syntax: 'C2')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { C2 ... 8 : 9 } } }')

            Jump if False (Regular) to Block[B7]
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')
                Entering: {R6}

            Next (Regular) Block[B3]
                Entering: {R3}

        .locals {R3}
        {
            CaptureIds: [4]
            Block[B3] - Block
                Predecessors: [B2]
                Statements (1)
                    IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new C3 { [1 ... , [3] = 4 }')
                      Value: 
                        IObjectCreationOperation (Constructor: C3..ctor()) (OperationKind.ObjectCreation, Type: C3) (Syntax: 'new C3 { [1 ... , [3] = 4 }')
                          Arguments(0)
                          Initializer: 
                            null

                Next (Regular) Block[B4]
                    Entering: {R4}

            .locals {R4}
            {
                CaptureIds: [5]
                Block[B4] - Block
                    Predecessors: [B3]
                    Statements (2)
                        IFlowCaptureOperation: 5 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '1')
                          Value: 
                            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

                        ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Object) (Syntax: '[1] = 2')
                          Left: 
                            IPropertyReferenceOperation: System.Object C3.this[System.Int32 i] { get; set; } (OperationKind.PropertyReference, Type: System.Object) (Syntax: '[1]')
                              Instance Receiver: 
                                IFlowCaptureReferenceOperation: 4 (OperationKind.FlowCaptureReference, Type: C3, IsImplicit) (Syntax: 'new C3 { [1 ... , [3] = 4 }')
                              Arguments(1):
                                  IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: '1')
                                    IFlowCaptureReferenceOperation: 5 (OperationKind.FlowCaptureReference, Type: System.Int32, Constant: 1, IsImplicit) (Syntax: '1')
                                    InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                    OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                          Right: 
                            IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsImplicit) (Syntax: '2')
                              Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                (Boxing)
                              Operand: 
                                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')

                    Next (Regular) Block[B5]
                        Leaving: {R4}
                        Entering: {R5}
            }
            .locals {R5}
            {
                CaptureIds: [6]
                Block[B5] - Block
                    Predecessors: [B4]
                    Statements (2)
                        IFlowCaptureOperation: 6 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '3')
                          Value: 
                            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')

                        ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Object) (Syntax: '[3] = 4')
                          Left: 
                            IPropertyReferenceOperation: System.Object C3.this[System.Int32 i] { get; set; } (OperationKind.PropertyReference, Type: System.Object) (Syntax: '[3]')
                              Instance Receiver: 
                                IFlowCaptureReferenceOperation: 4 (OperationKind.FlowCaptureReference, Type: C3, IsImplicit) (Syntax: 'new C3 { [1 ... , [3] = 4 }')
                              Arguments(1):
                                  IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: '3')
                                    IFlowCaptureReferenceOperation: 6 (OperationKind.FlowCaptureReference, Type: System.Int32, Constant: 3, IsImplicit) (Syntax: '3')
                                    InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                    OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                          Right: 
                            IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsImplicit) (Syntax: '4')
                              Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                (Boxing)
                              Operand: 
                                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 4) (Syntax: '4')

                    Next (Regular) Block[B6]
                        Leaving: {R5}
            }

            Block[B6] - Block
                Predecessors: [B5]
                Statements (1)
                    IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new C3 { [1 ... , [3] = 4 }')
                      Value: 
                        IFlowCaptureReferenceOperation: 4 (OperationKind.FlowCaptureReference, Type: C3, IsImplicit) (Syntax: 'new C3 { [1 ... , [3] = 4 }')

                Next (Regular) Block[B14]
                    Leaving: {R3}
        }
        .locals {R6}
        {
            CaptureIds: [7]
            Block[B7] - Block
                Predecessors: [B2]
                Statements (1)
                    IFlowCaptureOperation: 7 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new C3 { [5 ... b ? 8 : 9 }')
                      Value: 
                        IObjectCreationOperation (Constructor: C3..ctor()) (OperationKind.ObjectCreation, Type: C3) (Syntax: 'new C3 { [5 ... b ? 8 : 9 }')
                          Arguments(0)
                          Initializer: 
                            null

                Next (Regular) Block[B8]
                    Entering: {R7}

            .locals {R7}
            {
                CaptureIds: [8]
                Block[B8] - Block
                    Predecessors: [B7]
                    Statements (2)
                        IFlowCaptureOperation: 8 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '5')
                          Value: 
                            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 5) (Syntax: '5')

                        ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Object) (Syntax: '[5] = 6')
                          Left: 
                            IPropertyReferenceOperation: System.Object C3.this[System.Int32 i] { get; set; } (OperationKind.PropertyReference, Type: System.Object) (Syntax: '[5]')
                              Instance Receiver: 
                                IFlowCaptureReferenceOperation: 7 (OperationKind.FlowCaptureReference, Type: C3, IsImplicit) (Syntax: 'new C3 { [5 ... b ? 8 : 9 }')
                              Arguments(1):
                                  IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: '5')
                                    IFlowCaptureReferenceOperation: 8 (OperationKind.FlowCaptureReference, Type: System.Int32, Constant: 5, IsImplicit) (Syntax: '5')
                                    InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                    OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                          Right: 
                            IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsImplicit) (Syntax: '6')
                              Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                (Boxing)
                              Operand: 
                                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 6) (Syntax: '6')

                    Next (Regular) Block[B9]
                        Leaving: {R7}
                        Entering: {R8}
            }
            .locals {R8}
            {
                CaptureIds: [9] [10]
                Block[B9] - Block
                    Predecessors: [B8]
                    Statements (1)
                        IFlowCaptureOperation: 9 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '7')
                          Value: 
                            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 7) (Syntax: '7')

                    Jump if False (Regular) to Block[B11]
                        IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

                    Next (Regular) Block[B10]
                Block[B10] - Block
                    Predecessors: [B9]
                    Statements (1)
                        IFlowCaptureOperation: 10 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '8')
                          Value: 
                            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 8) (Syntax: '8')

                    Next (Regular) Block[B12]
                Block[B11] - Block
                    Predecessors: [B9]
                    Statements (1)
                        IFlowCaptureOperation: 10 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '9')
                          Value: 
                            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 9) (Syntax: '9')

                    Next (Regular) Block[B12]
                Block[B12] - Block
                    Predecessors: [B10] [B11]
                    Statements (1)
                        ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Object) (Syntax: '[7] = b ? 8 : 9')
                          Left: 
                            IPropertyReferenceOperation: System.Object C3.this[System.Int32 i] { get; set; } (OperationKind.PropertyReference, Type: System.Object) (Syntax: '[7]')
                              Instance Receiver: 
                                IFlowCaptureReferenceOperation: 7 (OperationKind.FlowCaptureReference, Type: C3, IsImplicit) (Syntax: 'new C3 { [5 ... b ? 8 : 9 }')
                              Arguments(1):
                                  IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: '7')
                                    IFlowCaptureReferenceOperation: 9 (OperationKind.FlowCaptureReference, Type: System.Int32, Constant: 7, IsImplicit) (Syntax: '7')
                                    InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                    OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                          Right: 
                            IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsImplicit) (Syntax: 'b ? 8 : 9')
                              Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                (Boxing)
                              Operand: 
                                IFlowCaptureReferenceOperation: 10 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'b ? 8 : 9')

                    Next (Regular) Block[B13]
                        Leaving: {R8}
            }

            Block[B13] - Block
                Predecessors: [B12]
                Statements (1)
                    IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new C3 { [5 ... b ? 8 : 9 }')
                      Value: 
                        IFlowCaptureReferenceOperation: 7 (OperationKind.FlowCaptureReference, Type: C3, IsImplicit) (Syntax: 'new C3 { [5 ... b ? 8 : 9 }')

                Next (Regular) Block[B14]
                    Leaving: {R6}
        }

        Block[B14] - Block
            Predecessors: [B6] [B13]
            Statements (1)
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Object) (Syntax: '[""C3""] = b  ... b ? 8 : 9 }')
                  Left: 
                    IPropertyReferenceOperation: System.Object C2.this[System.String i] { get; set; } (OperationKind.PropertyReference, Type: System.Object) (Syntax: '[""C3""]')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: C2, IsImplicit) (Syntax: 'C2')
                      Arguments(1):
                          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: '""C3""')
                            IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.String, Constant: ""C3"", IsImplicit) (Syntax: '""C3""')
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  Right: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsImplicit) (Syntax: 'b ? new C3  ... b ? 8 : 9 }')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                        (ImplicitReference)
                      Operand: 
                        IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: C3, IsImplicit) (Syntax: 'b ? new C3  ... b ? 8 : 9 }')

            Next (Regular) Block[B15]
                Leaving: {R2}
    }

    Block[B15] - Block
        Predecessors: [B14]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: C1, IsImplicit) (Syntax: 'x = new C1  ... 8 : 9 } } }')
              Left: 
                ILocalReferenceOperation: x (IsDeclaration: True) (OperationKind.LocalReference, Type: C1, IsImplicit) (Syntax: 'x = new C1  ... 8 : 9 } } }')
              Right: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { C2 ... 8 : 9 } } }')

        Next (Regular) Block[B16]
            Leaving: {R1}
}

Block[B16] - Exit
    Predecessors: [B15]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,492512,492610);

f_22056_492512_492609(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,473842,492621);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,473842,492621);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,473842,492621);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ObjectCreationFlow_30()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,492633,502262);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,492788,493228);

string 
source = @"
class C1
{
    public C2 C2;

    public void M(bool b, int? i)
    /*<bind>*/{
        var x = new C1 { C2 = { C31 = { [i ?? GetInt(1)] = b ? new C1() : null } } };
    }/*</bind>*/

    int GetInt(int x) => x;
}

class C2
{
    public C2()
    {
    }

    public C3 C31;
    public C3 C32;
}

class C3
{
    public object this[int i]
    {
        get => null;
        set { }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,493242,493588);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22056_493463_493572(f_22056_493463_493551(f_22056_493463_493519(ErrorCode.WRN_UnassignedInternalField, "C32"), "C2.C32", "null"), 21, 15)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,493604,502139);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [C1 x]
    CaptureIds: [0]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new C1 { C2 ...  null } } }')
              Value: 
                IObjectCreationOperation (Constructor: C1..ctor()) (OperationKind.ObjectCreation, Type: C1) (Syntax: 'new C1 { C2 ...  null } } }')
                  Arguments(0)
                  Initializer: 
                    null

        Next (Regular) Block[B2]
            Entering: {R2} {R3}

    .locals {R2}
    {
        CaptureIds: [2] [3] [4]
        .locals {R3}
        {
            CaptureIds: [1]
            Block[B2] - Block
                Predecessors: [B1]
                Statements (1)
                    IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i')
                      Value: 
                        IParameterReferenceOperation: i (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'i')

                Jump if True (Regular) to Block[B4]
                    IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'i')
                      Operand: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'i')
                    Leaving: {R3}

                Next (Regular) Block[B3]
            Block[B3] - Block
                Predecessors: [B2]
                Statements (1)
                    IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i')
                      Value: 
                        IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsImplicit) (Syntax: 'i')
                          Instance Receiver: 
                            IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'i')
                          Arguments(0)

                Next (Regular) Block[B5]
                    Leaving: {R3}
        }

        Block[B4] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'GetInt(1)')
                  Value: 
                    IInvocationOperation ( System.Int32 C1.GetInt(System.Int32 x)) (OperationKind.Invocation, Type: System.Int32) (Syntax: 'GetInt(1)')
                      Instance Receiver: 
                        IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C1, IsImplicit) (Syntax: 'GetInt')
                      Arguments(1):
                          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: x) (OperationKind.Argument, Type: null) (Syntax: '1')
                            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

            Next (Regular) Block[B5]
        Block[B5] - Block
            Predecessors: [B3] [B4]
            Statements (1)
                IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'C31')
                  Value: 
                    IFieldReferenceOperation: C3 C2.C31 (OperationKind.FieldReference, Type: C3) (Syntax: 'C31')
                      Instance Receiver: 
                        IFieldReferenceOperation: C2 C1.C2 (OperationKind.FieldReference, Type: C2) (Syntax: 'C2')
                          Instance Receiver: 
                            IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { C2 ...  null } } }')

            Jump if False (Regular) to Block[B7]
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

            Next (Regular) Block[B6]
        Block[B6] - Block
            Predecessors: [B5]
            Statements (1)
                IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new C1()')
                  Value: 
                    IObjectCreationOperation (Constructor: C1..ctor()) (OperationKind.ObjectCreation, Type: C1) (Syntax: 'new C1()')
                      Arguments(0)
                      Initializer: 
                        null

            Next (Regular) Block[B8]
        Block[B7] - Block
            Predecessors: [B5]
            Statements (1)
                IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'null')
                  Value: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: C1, Constant: null, IsImplicit) (Syntax: 'null')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                        (ImplicitReference)
                      Operand: 
                        ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')

            Next (Regular) Block[B8]
        Block[B8] - Block
            Predecessors: [B6] [B7]
            Statements (1)
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Object) (Syntax: '[i ?? GetIn ... C1() : null')
                  Left: 
                    IPropertyReferenceOperation: System.Object C3.this[System.Int32 i] { get; set; } (OperationKind.PropertyReference, Type: System.Object) (Syntax: '[i ?? GetInt(1)]')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: C3, IsImplicit) (Syntax: 'C31')
                      Arguments(1):
                          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: 'i ?? GetInt(1)')
                            IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'i ?? GetInt(1)')
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  Right: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsImplicit) (Syntax: 'b ? new C1() : null')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                        (ImplicitReference)
                      Operand: 
                        IFlowCaptureReferenceOperation: 4 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'b ? new C1() : null')

            Next (Regular) Block[B9]
                Leaving: {R2}
    }

    Block[B9] - Block
        Predecessors: [B8]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: C1, IsImplicit) (Syntax: 'x = new C1  ...  null } } }')
              Left: 
                ILocalReferenceOperation: x (IsDeclaration: True) (OperationKind.LocalReference, Type: C1, IsImplicit) (Syntax: 'x = new C1  ...  null } } }')
              Right: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { C2 ...  null } } }')

        Next (Regular) Block[B10]
            Leaving: {R1}
}

Block[B10] - Exit
    Predecessors: [B9]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,502153,502251);

f_22056_502153_502250(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,492633,502262);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,492633,502262);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,492633,502262);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ObjectCreationFlow_31()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,502274,505403);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,502429,502630);

string 
source = @"
using System;

class C1
{
    public event EventHandler<object> ev;

    public void M(bool b)
    /*<bind>*/{
        var x = new C1 { ev = null };
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,502644,502947);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22056_502839_502931(f_22056_502839_502911(f_22056_502839_502888(ErrorCode.WRN_UnreferencedEvent, "ev"), "C1.ev"), 6, 39)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,502963,505280);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [C1 x]
    CaptureIds: [0]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (3)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new C1 { ev = null }')
              Value: 
                IObjectCreationOperation (Constructor: C1..ctor()) (OperationKind.ObjectCreation, Type: C1) (Syntax: 'new C1 { ev = null }')
                  Arguments(0)
                  Initializer: 
                    null

            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.EventHandler<System.Object>) (Syntax: 'ev = null')
              Left: 
                IEventReferenceOperation: event System.EventHandler<System.Object> C1.ev (OperationKind.EventReference, Type: System.EventHandler<System.Object>) (Syntax: 'ev')
                  Instance Receiver: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { ev = null }')
              Right: 
                IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.EventHandler<System.Object>, Constant: null, IsImplicit) (Syntax: 'null')
                  Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                    (ImplicitReference)
                  Operand: 
                    ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')

            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: C1, IsImplicit) (Syntax: 'x = new C1 { ev = null }')
              Left: 
                ILocalReferenceOperation: x (IsDeclaration: True) (OperationKind.LocalReference, Type: C1, IsImplicit) (Syntax: 'x = new C1 { ev = null }')
              Right: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { ev = null }')

        Next (Regular) Block[B2]
            Leaving: {R1}
}

Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,505294,505392);

f_22056_505294_505391(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,502274,505403);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,502274,505403);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,502274,505403);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ObjectCreationFlow_32()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,505415,510617);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,505570,505811);

string 
source = @"
using System;

class C1
{
    public event EventHandler<object> ev;

    public void M(bool b, object o)
    /*<bind>*/{
        var x = new C1 { ev = b ? (EventHandler<object>)o : null };
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,505825,506128);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22056_506020_506112(f_22056_506020_506092(f_22056_506020_506069(ErrorCode.WRN_UnreferencedEvent, "ev"), "C1.ev"), 6, 39)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,506144,510494);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [C1 x]
    CaptureIds: [0]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new C1 { ev ... )o : null }')
              Value: 
                IObjectCreationOperation (Constructor: C1..ctor()) (OperationKind.ObjectCreation, Type: C1) (Syntax: 'new C1 { ev ... )o : null }')
                  Arguments(0)
                  Initializer: 
                    null

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (0)
            Jump if False (Regular) to Block[B4]
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '(EventHandler<object>)o')
                  Value: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.EventHandler<System.Object>) (Syntax: '(EventHandler<object>)o')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                        (ExplicitReference)
                      Operand: 
                        IParameterReferenceOperation: o (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'o')

            Next (Regular) Block[B5]
        Block[B4] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'null')
                  Value: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.EventHandler<System.Object>, Constant: null, IsImplicit) (Syntax: 'null')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                        (ImplicitReference)
                      Operand: 
                        ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')

            Next (Regular) Block[B5]
        Block[B5] - Block
            Predecessors: [B3] [B4]
            Statements (1)
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.EventHandler<System.Object>) (Syntax: 'ev = b ? (E ... t>)o : null')
                  Left: 
                    IEventReferenceOperation: event System.EventHandler<System.Object> C1.ev (OperationKind.EventReference, Type: System.EventHandler<System.Object>) (Syntax: 'ev')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { ev ... )o : null }')
                  Right: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.EventHandler<System.Object>, IsImplicit) (Syntax: 'b ? (EventH ... t>)o : null')

            Next (Regular) Block[B6]
                Leaving: {R2}
    }

    Block[B6] - Block
        Predecessors: [B5]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: C1, IsImplicit) (Syntax: 'x = new C1  ... )o : null }')
              Left: 
                ILocalReferenceOperation: x (IsDeclaration: True) (OperationKind.LocalReference, Type: C1, IsImplicit) (Syntax: 'x = new C1  ... )o : null }')
              Right: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { ev ... )o : null }')

        Next (Regular) Block[B7]
            Leaving: {R1}
}

Block[B7] - Exit
    Predecessors: [B6]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,510508,510606);

f_22056_510508_510605(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,505415,510617);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,505415,510617);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,505415,510617);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ObjectCreationFlow_33()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,510629,516781);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,510784,511084);

string 
source = @"
using System;

class C1
{
    public C2 C2 { get; set; }

    public void M(bool b, object o)
    /*<bind>*/{
        var x = new C1 { C2 = { ev = b ? (EventHandler<object>)o : null } };
    }/*</bind>*/
}

class C2
{
    public event EventHandler<object> ev;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,511098,511754);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22056_511409_511504(f_22056_511409_511483(f_22056_511409_511454(ErrorCode.ERR_BadEventUsage, "ev"), "C2.ev", "C2"), 10, 33),
f_22056_511645_511738(f_22056_511645_511717(f_22056_511645_511694(ErrorCode.WRN_UnreferencedEvent, "ev"), "C2.ev"), 16, 39)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,511770,516658);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [C1 x]
    CaptureIds: [0]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'new C1 { C2 ...  : null } }')
              Value: 
                IObjectCreationOperation (Constructor: C1..ctor()) (OperationKind.ObjectCreation, Type: C1, IsInvalid) (Syntax: 'new C1 { C2 ...  : null } }')
                  Arguments(0)
                  Initializer: 
                    null

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1] [2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'C2')
                  Value: 
                    IPropertyReferenceOperation: C2 C1.C2 { get; set; } (OperationKind.PropertyReference, Type: C2) (Syntax: 'C2')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C1, IsInvalid, IsImplicit) (Syntax: 'new C1 { C2 ...  : null } }')

            Jump if False (Regular) to Block[B4]
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '(EventHandler<object>)o')
                  Value: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.EventHandler<System.Object>) (Syntax: '(EventHandler<object>)o')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                        (ExplicitReference)
                      Operand: 
                        IParameterReferenceOperation: o (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'o')

            Next (Regular) Block[B5]
        Block[B4] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'null')
                  Value: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.EventHandler<System.Object>, Constant: null, IsImplicit) (Syntax: 'null')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                        (ImplicitReference)
                      Operand: 
                        ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')

            Next (Regular) Block[B5]
        Block[B5] - Block
            Predecessors: [B3] [B4]
            Statements (1)
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.EventHandler<System.Object>, IsInvalid) (Syntax: 'ev = b ? (E ... t>)o : null')
                  Left: 
                    IEventReferenceOperation: event System.EventHandler<System.Object> C2.ev (OperationKind.EventReference, Type: System.EventHandler<System.Object>, IsInvalid) (Syntax: 'ev')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C2, IsImplicit) (Syntax: 'C2')
                  Right: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.EventHandler<System.Object>, IsImplicit) (Syntax: 'b ? (EventH ... t>)o : null')

            Next (Regular) Block[B6]
                Leaving: {R2}
    }

    Block[B6] - Block
        Predecessors: [B5]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: C1, IsInvalid, IsImplicit) (Syntax: 'x = new C1  ...  : null } }')
              Left: 
                ILocalReferenceOperation: x (IsDeclaration: True) (OperationKind.LocalReference, Type: C1, IsInvalid, IsImplicit) (Syntax: 'x = new C1  ...  : null } }')
              Right: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C1, IsInvalid, IsImplicit) (Syntax: 'new C1 { C2 ...  : null } }')

        Next (Regular) Block[B7]
            Leaving: {R1}
}

Block[B7] - Exit
    Predecessors: [B6]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,516672,516770);

f_22056_516672_516769(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,510629,516781);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,510629,516781);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,510629,516781);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ObjectCreationFlow_34()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,516793,523636);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,516948,517207);

string 
source = @"
using System;

class C1
{
    public object P1 { get; set; }
    public object P2 { get; set; }

    public void M(bool b, object o)
    /*<bind>*/{
        var x = new C1 { P1 = null, (P1 ?? P2) = null };
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,517221,517834);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22056_517475_517552(f_22056_517475_517531(ErrorCode.ERR_AssgLvalueExpected, "P1 ?? P2"), 11, 38),
f_22056_517714_517818(f_22056_517714_517797(ErrorCode.ERR_InvalidInitializerElementInitializer, "(P1 ?? P2) = null"), 11, 37)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,517850,523513);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [C1 x]
    CaptureIds: [0]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (2)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'new C1 { P1 ... 2) = null }')
              Value: 
                IObjectCreationOperation (Constructor: C1..ctor()) (OperationKind.ObjectCreation, Type: C1, IsInvalid) (Syntax: 'new C1 { P1 ... 2) = null }')
                  Arguments(0)
                  Initializer: 
                    null

            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Object) (Syntax: 'P1 = null')
              Left: 
                IPropertyReferenceOperation: System.Object C1.P1 { get; set; } (OperationKind.PropertyReference, Type: System.Object) (Syntax: 'P1')
                  Instance Receiver: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C1, IsInvalid, IsImplicit) (Syntax: 'new C1 { P1 ... 2) = null }')
              Right: 
                IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, Constant: null, IsImplicit) (Syntax: 'null')
                  Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                    (ImplicitReference)
                  Operand: 
                    ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')

        Next (Regular) Block[B2]
            Entering: {R2} {R3}

    .locals {R2}
    {
        CaptureIds: [2]
        .locals {R3}
        {
            CaptureIds: [1]
            Block[B2] - Block
                Predecessors: [B1]
                Statements (1)
                    IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'P1')
                      Value: 
                        IPropertyReferenceOperation: System.Object C1.P1 { get; set; } (OperationKind.PropertyReference, Type: System.Object, IsInvalid) (Syntax: 'P1')
                          Instance Receiver: 
                            IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C1, IsInvalid, IsImplicit) (Syntax: 'P1')

                Jump if True (Regular) to Block[B4]
                    IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsInvalid, IsImplicit) (Syntax: 'P1')
                      Operand: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Object, IsInvalid, IsImplicit) (Syntax: 'P1')
                    Leaving: {R3}

                Next (Regular) Block[B3]
            Block[B3] - Block
                Predecessors: [B2]
                Statements (1)
                    IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'P1')
                      Value: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Object, IsInvalid, IsImplicit) (Syntax: 'P1')

                Next (Regular) Block[B5]
                    Leaving: {R3}
        }

        Block[B4] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'P2')
                  Value: 
                    IPropertyReferenceOperation: System.Object C1.P2 { get; set; } (OperationKind.PropertyReference, Type: System.Object, IsInvalid) (Syntax: 'P2')
                      Instance Receiver: 
                        IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C1, IsInvalid, IsImplicit) (Syntax: 'P2')

            Next (Regular) Block[B5]
        Block[B5] - Block
            Predecessors: [B3] [B4]
            Statements (1)
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Object, IsInvalid) (Syntax: '(P1 ?? P2) = null')
                  Left: 
                    IInvalidOperation (OperationKind.Invalid, Type: System.Object, IsInvalid, IsImplicit) (Syntax: 'P1 ?? P2')
                      Children(1):
                          IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Object, IsInvalid, IsImplicit) (Syntax: 'P1 ?? P2')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: null, Constant: null, IsInvalid) (Syntax: 'null')

            Next (Regular) Block[B6]
                Leaving: {R2}
    }

    Block[B6] - Block
        Predecessors: [B5]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: C1, IsInvalid, IsImplicit) (Syntax: 'x = new C1  ... 2) = null }')
              Left: 
                ILocalReferenceOperation: x (IsDeclaration: True) (OperationKind.LocalReference, Type: C1, IsInvalid, IsImplicit) (Syntax: 'x = new C1  ... 2) = null }')
              Right: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C1, IsInvalid, IsImplicit) (Syntax: 'new C1 { P1 ... 2) = null }')

        Next (Regular) Block[B7]
            Leaving: {R1}
}

Block[B7] - Exit
    Predecessors: [B6]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,523527,523625);

f_22056_523527_523624(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,516793,523636);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,516793,523636);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,516793,523636);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ObjectCreationFlow_35()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,523648,530733);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,523803,524049);

string 
source = @"
using System;

class C1
{
    public object P1 { get; set; }
    public object P2;

    public void M(bool b, object o)
    /*<bind>*/{
        var x = new C1 { P1 = null, (P1 ?? P2) = null };
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,524063,524951);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22056_524317_524394(f_22056_524317_524373(ErrorCode.ERR_AssgLvalueExpected, "P1 ?? P2"), 11, 38),
f_22056_524556_524660(f_22056_524556_524639(ErrorCode.ERR_InvalidInitializerElementInitializer, "(P1 ?? P2) = null"), 11, 37),
f_22056_524829_524935(f_22056_524829_524915(f_22056_524829_524884(ErrorCode.WRN_UnassignedInternalField, "P2"), "C1.P2", "null"), 7, 19)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,524967,530610);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [C1 x]
    CaptureIds: [0]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (2)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'new C1 { P1 ... 2) = null }')
              Value: 
                IObjectCreationOperation (Constructor: C1..ctor()) (OperationKind.ObjectCreation, Type: C1, IsInvalid) (Syntax: 'new C1 { P1 ... 2) = null }')
                  Arguments(0)
                  Initializer: 
                    null

            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Object) (Syntax: 'P1 = null')
              Left: 
                IPropertyReferenceOperation: System.Object C1.P1 { get; set; } (OperationKind.PropertyReference, Type: System.Object) (Syntax: 'P1')
                  Instance Receiver: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C1, IsInvalid, IsImplicit) (Syntax: 'new C1 { P1 ... 2) = null }')
              Right: 
                IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, Constant: null, IsImplicit) (Syntax: 'null')
                  Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                    (ImplicitReference)
                  Operand: 
                    ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')

        Next (Regular) Block[B2]
            Entering: {R2} {R3}

    .locals {R2}
    {
        CaptureIds: [2]
        .locals {R3}
        {
            CaptureIds: [1]
            Block[B2] - Block
                Predecessors: [B1]
                Statements (1)
                    IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'P1')
                      Value: 
                        IPropertyReferenceOperation: System.Object C1.P1 { get; set; } (OperationKind.PropertyReference, Type: System.Object, IsInvalid) (Syntax: 'P1')
                          Instance Receiver: 
                            IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C1, IsInvalid, IsImplicit) (Syntax: 'P1')

                Jump if True (Regular) to Block[B4]
                    IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsInvalid, IsImplicit) (Syntax: 'P1')
                      Operand: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Object, IsInvalid, IsImplicit) (Syntax: 'P1')
                    Leaving: {R3}

                Next (Regular) Block[B3]
            Block[B3] - Block
                Predecessors: [B2]
                Statements (1)
                    IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'P1')
                      Value: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Object, IsInvalid, IsImplicit) (Syntax: 'P1')

                Next (Regular) Block[B5]
                    Leaving: {R3}
        }

        Block[B4] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'P2')
                  Value: 
                    IFieldReferenceOperation: System.Object C1.P2 (OperationKind.FieldReference, Type: System.Object, IsInvalid) (Syntax: 'P2')
                      Instance Receiver: 
                        IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C1, IsInvalid, IsImplicit) (Syntax: 'P2')

            Next (Regular) Block[B5]
        Block[B5] - Block
            Predecessors: [B3] [B4]
            Statements (1)
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Object, IsInvalid) (Syntax: '(P1 ?? P2) = null')
                  Left: 
                    IInvalidOperation (OperationKind.Invalid, Type: System.Object, IsInvalid, IsImplicit) (Syntax: 'P1 ?? P2')
                      Children(1):
                          IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Object, IsInvalid, IsImplicit) (Syntax: 'P1 ?? P2')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: null, Constant: null, IsInvalid) (Syntax: 'null')

            Next (Regular) Block[B6]
                Leaving: {R2}
    }

    Block[B6] - Block
        Predecessors: [B5]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: C1, IsInvalid, IsImplicit) (Syntax: 'x = new C1  ... 2) = null }')
              Left: 
                ILocalReferenceOperation: x (IsDeclaration: True) (OperationKind.LocalReference, Type: C1, IsInvalid, IsImplicit) (Syntax: 'x = new C1  ... 2) = null }')
              Right: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C1, IsInvalid, IsImplicit) (Syntax: 'new C1 { P1 ... 2) = null }')

        Next (Regular) Block[B7]
            Leaving: {R1}
}

Block[B7] - Exit
    Predecessors: [B6]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,530624,530722);

f_22056_530624_530721(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,523648,530733);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,523648,530733);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,523648,530733);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ObjectCreationFlow_36()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,530745,537287);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,530900,531346);

string 
source = @"
using System;

internal class Class
{
    public void M(bool a, string b, object o)
    /*<bind>*/{
        Class c = new Class { [GetInt()] = { C = { I1 = 1, I2 = 2 } } };
    }/*</bind>*/

    public C2 this[int i]
    {
        get => null;
        set { }
    }

    int GetInt() => 1;
}

class C2
{
    public C2 C { get; set; }
    public int I1 { get; set; }
    public int I2 { get; set; }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,531360,531413);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,531429,537164);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [Class c]
    CaptureIds: [0]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new Class { ... 2 = 2 } } }')
              Value: 
                IObjectCreationOperation (Constructor: Class..ctor()) (OperationKind.ObjectCreation, Type: Class) (Syntax: 'new Class { ... 2 = 2 } } }')
                  Arguments(0)
                  Initializer: 
                    null

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (3)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'GetInt()')
                  Value: 
                    IInvocationOperation ( System.Int32 Class.GetInt()) (OperationKind.Invocation, Type: System.Int32) (Syntax: 'GetInt()')
                      Instance Receiver: 
                        IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: Class, IsImplicit) (Syntax: 'GetInt')
                      Arguments(0)

                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'I1 = 1')
                  Left: 
                    IPropertyReferenceOperation: System.Int32 C2.I1 { get; set; } (OperationKind.PropertyReference, Type: System.Int32) (Syntax: 'I1')
                      Instance Receiver: 
                        IPropertyReferenceOperation: C2 C2.C { get; set; } (OperationKind.PropertyReference, Type: C2) (Syntax: 'C')
                          Instance Receiver: 
                            IPropertyReferenceOperation: C2 Class.this[System.Int32 i] { get; set; } (OperationKind.PropertyReference, Type: C2) (Syntax: '[GetInt()]')
                              Instance Receiver: 
                                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: Class, IsImplicit) (Syntax: 'new Class { ... 2 = 2 } } }')
                              Arguments(1):
                                  IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: 'GetInt()')
                                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'GetInt()')
                                    InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                    OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'I2 = 2')
                  Left: 
                    IPropertyReferenceOperation: System.Int32 C2.I2 { get; set; } (OperationKind.PropertyReference, Type: System.Int32) (Syntax: 'I2')
                      Instance Receiver: 
                        IPropertyReferenceOperation: C2 C2.C { get; set; } (OperationKind.PropertyReference, Type: C2) (Syntax: 'C')
                          Instance Receiver: 
                            IPropertyReferenceOperation: C2 Class.this[System.Int32 i] { get; set; } (OperationKind.PropertyReference, Type: C2) (Syntax: '[GetInt()]')
                              Instance Receiver: 
                                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: Class, IsImplicit) (Syntax: 'new Class { ... 2 = 2 } } }')
                              Arguments(1):
                                  IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: 'GetInt()')
                                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'GetInt()')
                                    InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                    OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')

            Next (Regular) Block[B3]
                Leaving: {R2}
    }

    Block[B3] - Block
        Predecessors: [B2]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: Class, IsImplicit) (Syntax: 'c = new Cla ... 2 = 2 } } }')
              Left: 
                ILocalReferenceOperation: c (IsDeclaration: True) (OperationKind.LocalReference, Type: Class, IsImplicit) (Syntax: 'c = new Cla ... 2 = 2 } } }')
              Right: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: Class, IsImplicit) (Syntax: 'new Class { ... 2 = 2 } } }')

        Next (Regular) Block[B4]
            Leaving: {R1}
}

Block[B4] - Exit
    Predecessors: [B3]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,537178,537276);

f_22056_537178_537275(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,530745,537287);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,530745,537287);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,530745,537287);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ObjectCreationFlow_37()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,537299,543502);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,537454,537776);

string 
source = @"
using System;

internal class Class
{
    public void M(bool a, string b, object o)
    /*<bind>*/{
        Class c = new Class { (C21 ?? C22).I1 = 1 };
    }/*</bind>*/

    public C2 C21 { get; set; }
    public C2 C22 { get; set; }
}

class C2
{
    public int I1 { get; set; }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,537790,538496);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22056_538088_538217(f_22056_538088_538197(f_22056_538088_538174(ErrorCode.ERR_CollectionInitRequiresIEnumerable, "{ (C21 ?? C22).I1 = 1 }"), "Class"), 8, 29),
f_22056_538375_538480(f_22056_538375_538460(ErrorCode.ERR_InvalidInitializerElementInitializer, "(C21 ?? C22).I1 = 1"), 8, 31)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,538512,543379);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [Class c]
    CaptureIds: [0]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'new Class { ... 2).I1 = 1 }')
              Value: 
                IObjectCreationOperation (Constructor: Class..ctor()) (OperationKind.ObjectCreation, Type: Class, IsInvalid) (Syntax: 'new Class { ... 2).I1 = 1 }')
                  Arguments(0)
                  Initializer: 
                    null

        Next (Regular) Block[B2]
            Entering: {R2} {R3}

    .locals {R2}
    {
        CaptureIds: [2]
        .locals {R3}
        {
            CaptureIds: [1]
            Block[B2] - Block
                Predecessors: [B1]
                Statements (1)
                    IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'C21')
                      Value: 
                        IPropertyReferenceOperation: C2 Class.C21 { get; set; } (OperationKind.PropertyReference, Type: C2, IsInvalid) (Syntax: 'C21')
                          Instance Receiver: 
                            IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: Class, IsInvalid, IsImplicit) (Syntax: 'C21')

                Jump if True (Regular) to Block[B4]
                    IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsInvalid, IsImplicit) (Syntax: 'C21')
                      Operand: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C2, IsInvalid, IsImplicit) (Syntax: 'C21')
                    Leaving: {R3}

                Next (Regular) Block[B3]
            Block[B3] - Block
                Predecessors: [B2]
                Statements (1)
                    IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'C21')
                      Value: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C2, IsInvalid, IsImplicit) (Syntax: 'C21')

                Next (Regular) Block[B5]
                    Leaving: {R3}
        }

        Block[B4] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'C22')
                  Value: 
                    IPropertyReferenceOperation: C2 Class.C22 { get; set; } (OperationKind.PropertyReference, Type: C2, IsInvalid) (Syntax: 'C22')
                      Instance Receiver: 
                        IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: Class, IsInvalid, IsImplicit) (Syntax: 'C22')

            Next (Regular) Block[B5]
        Block[B5] - Block
            Predecessors: [B3] [B4]
            Statements (1)
                IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid, IsImplicit) (Syntax: '(C21 ?? C22).I1 = 1')
                  Children(1):
                      ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsInvalid) (Syntax: '(C21 ?? C22).I1 = 1')
                        Left: 
                          IPropertyReferenceOperation: System.Int32 C2.I1 { get; set; } (OperationKind.PropertyReference, Type: System.Int32, IsInvalid) (Syntax: '(C21 ?? C22).I1')
                            Instance Receiver: 
                              IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: C2, IsInvalid, IsImplicit) (Syntax: 'C21 ?? C22')
                        Right: 
                          ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1, IsInvalid) (Syntax: '1')

            Next (Regular) Block[B6]
                Leaving: {R2}
    }

    Block[B6] - Block
        Predecessors: [B5]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: Class, IsInvalid, IsImplicit) (Syntax: 'c = new Cla ... 2).I1 = 1 }')
              Left: 
                ILocalReferenceOperation: c (IsDeclaration: True) (OperationKind.LocalReference, Type: Class, IsInvalid, IsImplicit) (Syntax: 'c = new Cla ... 2).I1 = 1 }')
              Right: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: Class, IsInvalid, IsImplicit) (Syntax: 'new Class { ... 2).I1 = 1 }')

        Next (Regular) Block[B7]
            Leaving: {R1}
}

Block[B7] - Exit
    Predecessors: [B6]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,543393,543491);

f_22056_543393_543490(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,537299,543502);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,537299,543502);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,537299,543502);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ObjectCreationFlow_38()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,543514,551850);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,543669,544121);

string 
source = @"
using System;

internal class Class
{
    public void M(bool a, string b, object o)
    /*<bind>*/{
        Class c = new Class { [GetInt() ?? 3] = { C = { I1 = 1, I2 = 2 } } };
    }/*</bind>*/

    public C2 this[int i]
    {
        get => null;
        set { }
    }

    int? GetInt() => 1;
}

class C2
{
    public C2 C { get; set; }
    public int I1 { get; set; }
    public int I2 { get; set; }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,544135,544188);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,544204,551727);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [Class c]
    CaptureIds: [0]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new Class { ... 2 = 2 } } }')
              Value: 
                IObjectCreationOperation (Constructor: Class..ctor()) (OperationKind.ObjectCreation, Type: Class) (Syntax: 'new Class { ... 2 = 2 } } }')
                  Arguments(0)
                  Initializer: 
                    null

        Next (Regular) Block[B2]
            Entering: {R2} {R3}

    .locals {R2}
    {
        CaptureIds: [2]
        .locals {R3}
        {
            CaptureIds: [1]
            Block[B2] - Block
                Predecessors: [B1]
                Statements (1)
                    IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'GetInt()')
                      Value: 
                        IInvocationOperation ( System.Int32? Class.GetInt()) (OperationKind.Invocation, Type: System.Int32?) (Syntax: 'GetInt()')
                          Instance Receiver: 
                            IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: Class, IsImplicit) (Syntax: 'GetInt')
                          Arguments(0)

                Jump if True (Regular) to Block[B4]
                    IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'GetInt()')
                      Operand: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'GetInt()')
                    Leaving: {R3}

                Next (Regular) Block[B3]
            Block[B3] - Block
                Predecessors: [B2]
                Statements (1)
                    IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'GetInt()')
                      Value: 
                        IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsImplicit) (Syntax: 'GetInt()')
                          Instance Receiver: 
                            IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'GetInt()')
                          Arguments(0)

                Next (Regular) Block[B5]
                    Leaving: {R3}
        }

        Block[B4] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '3')
                  Value: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')

            Next (Regular) Block[B5]
        Block[B5] - Block
            Predecessors: [B3] [B4]
            Statements (2)
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'I1 = 1')
                  Left: 
                    IPropertyReferenceOperation: System.Int32 C2.I1 { get; set; } (OperationKind.PropertyReference, Type: System.Int32) (Syntax: 'I1')
                      Instance Receiver: 
                        IPropertyReferenceOperation: C2 C2.C { get; set; } (OperationKind.PropertyReference, Type: C2) (Syntax: 'C')
                          Instance Receiver: 
                            IPropertyReferenceOperation: C2 Class.this[System.Int32 i] { get; set; } (OperationKind.PropertyReference, Type: C2) (Syntax: '[GetInt() ?? 3]')
                              Instance Receiver: 
                                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: Class, IsImplicit) (Syntax: 'new Class { ... 2 = 2 } } }')
                              Arguments(1):
                                  IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: 'GetInt() ?? 3')
                                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'GetInt() ?? 3')
                                    InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                    OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'I2 = 2')
                  Left: 
                    IPropertyReferenceOperation: System.Int32 C2.I2 { get; set; } (OperationKind.PropertyReference, Type: System.Int32) (Syntax: 'I2')
                      Instance Receiver: 
                        IPropertyReferenceOperation: C2 C2.C { get; set; } (OperationKind.PropertyReference, Type: C2) (Syntax: 'C')
                          Instance Receiver: 
                            IPropertyReferenceOperation: C2 Class.this[System.Int32 i] { get; set; } (OperationKind.PropertyReference, Type: C2) (Syntax: '[GetInt() ?? 3]')
                              Instance Receiver: 
                                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: Class, IsImplicit) (Syntax: 'new Class { ... 2 = 2 } } }')
                              Arguments(1):
                                  IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: 'GetInt() ?? 3')
                                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'GetInt() ?? 3')
                                    InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                    OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')

            Next (Regular) Block[B6]
                Leaving: {R2}
    }

    Block[B6] - Block
        Predecessors: [B5]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: Class, IsImplicit) (Syntax: 'c = new Cla ... 2 = 2 } } }')
              Left: 
                ILocalReferenceOperation: c (IsDeclaration: True) (OperationKind.LocalReference, Type: Class, IsImplicit) (Syntax: 'c = new Cla ... 2 = 2 } } }')
              Right: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: Class, IsImplicit) (Syntax: 'new Class { ... 2 = 2 } } }')

        Next (Regular) Block[B7]
            Leaving: {R1}
}

Block[B7] - Exit
    Predecessors: [B6]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,551741,551839);

f_22056_551741_551838(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,543514,551850);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,543514,551850);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,543514,551850);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ObjectCreationFlow_39()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,551862,556052);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,552017,552188);

string 
source = @"
internal class Class
{
    public void M(bool b)
    /*<bind>*/{
        Class c = new Class { C21 = { I1 = 1, I2 = 2 } };
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,552202,552540);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22056_552429_552524(f_22056_552429_552504(f_22056_552429_552474(ErrorCode.ERR_NoSuchMember, "C21"), "Class", "C21"), 6, 31)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,552556,555929);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [Class c]
    CaptureIds: [0]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (4)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'new Class { ...  I2 = 2 } }')
              Value: 
                IObjectCreationOperation (Constructor: Class..ctor()) (OperationKind.ObjectCreation, Type: Class, IsInvalid) (Syntax: 'new Class { ...  I2 = 2 } }')
                  Arguments(0)
                  Initializer: 
                    null

            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: ?) (Syntax: 'I1 = 1')
              Left: 
                IInvalidOperation (OperationKind.Invalid, Type: ?, IsImplicit) (Syntax: 'I1')
                  Children(1):
                      IOperation:  (OperationKind.None, Type: null) (Syntax: 'I1')
                        Children(1):
                            IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid, IsImplicit) (Syntax: 'C21')
                              Children(1):
                                  IOperation:  (OperationKind.None, Type: null, IsInvalid) (Syntax: 'C21')
                                    Children(1):
                                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: Class, IsInvalid, IsImplicit) (Syntax: 'new Class { ...  I2 = 2 } }')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: ?) (Syntax: 'I2 = 2')
              Left: 
                IInvalidOperation (OperationKind.Invalid, Type: ?, IsImplicit) (Syntax: 'I2')
                  Children(1):
                      IOperation:  (OperationKind.None, Type: null) (Syntax: 'I2')
                        Children(1):
                            IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid, IsImplicit) (Syntax: 'C21')
                              Children(1):
                                  IOperation:  (OperationKind.None, Type: null, IsInvalid) (Syntax: 'C21')
                                    Children(1):
                                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: Class, IsInvalid, IsImplicit) (Syntax: 'new Class { ...  I2 = 2 } }')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')

            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: Class, IsInvalid, IsImplicit) (Syntax: 'c = new Cla ...  I2 = 2 } }')
              Left: 
                ILocalReferenceOperation: c (IsDeclaration: True) (OperationKind.LocalReference, Type: Class, IsInvalid, IsImplicit) (Syntax: 'c = new Cla ...  I2 = 2 } }')
              Right: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: Class, IsInvalid, IsImplicit) (Syntax: 'new Class { ...  I2 = 2 } }')

        Next (Regular) Block[B2]
            Leaving: {R1}
}

Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,555943,556041);

f_22056_555943_556040(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,551862,556052);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,551862,556052);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,551862,556052);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ObjectCreationFlow_40()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,556064,560908);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,556219,556423);

string 
source = @"
internal class Class
{
    public void M(bool b)
    /*<bind>*/{
        Class c = new Class { [GetInt()] = { I1 = 1, I2 = 2 } };
    }/*</bind>*/

    int GetInt() => 1;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,556437,556796);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22056_556686_556780(f_22056_556686_556760(f_22056_556686_556737(ErrorCode.ERR_BadIndexLHS, "[GetInt()]"), "Class"), 6, 31)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,556812,560785);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [Class c]
    CaptureIds: [0]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (4)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'new Class { ...  I2 = 2 } }')
              Value: 
                IObjectCreationOperation (Constructor: Class..ctor()) (OperationKind.ObjectCreation, Type: Class, IsInvalid) (Syntax: 'new Class { ...  I2 = 2 } }')
                  Arguments(0)
                  Initializer: 
                    null

            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: ?) (Syntax: 'I1 = 1')
              Left: 
                IInvalidOperation (OperationKind.Invalid, Type: ?, IsImplicit) (Syntax: 'I1')
                  Children(1):
                      IOperation:  (OperationKind.None, Type: null) (Syntax: 'I1')
                        Children(1):
                            IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid) (Syntax: '[GetInt()]')
                              Children(2):
                                  IInvocationOperation ( System.Int32 Class.GetInt()) (OperationKind.Invocation, Type: System.Int32, IsInvalid) (Syntax: 'GetInt()')
                                    Instance Receiver: 
                                      IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: Class, IsInvalid, IsImplicit) (Syntax: 'GetInt')
                                    Arguments(0)
                                  IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: Class, IsInvalid, IsImplicit) (Syntax: 'new Class { ...  I2 = 2 } }')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: ?) (Syntax: 'I2 = 2')
              Left: 
                IInvalidOperation (OperationKind.Invalid, Type: ?, IsImplicit) (Syntax: 'I2')
                  Children(1):
                      IOperation:  (OperationKind.None, Type: null) (Syntax: 'I2')
                        Children(1):
                            IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid) (Syntax: '[GetInt()]')
                              Children(2):
                                  IInvocationOperation ( System.Int32 Class.GetInt()) (OperationKind.Invocation, Type: System.Int32, IsInvalid) (Syntax: 'GetInt()')
                                    Instance Receiver: 
                                      IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: Class, IsInvalid, IsImplicit) (Syntax: 'GetInt')
                                    Arguments(0)
                                  IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: Class, IsInvalid, IsImplicit) (Syntax: 'new Class { ...  I2 = 2 } }')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')

            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: Class, IsInvalid, IsImplicit) (Syntax: 'c = new Cla ...  I2 = 2 } }')
              Left: 
                ILocalReferenceOperation: c (IsDeclaration: True) (OperationKind.LocalReference, Type: Class, IsInvalid, IsImplicit) (Syntax: 'c = new Cla ...  I2 = 2 } }')
              Right: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: Class, IsInvalid, IsImplicit) (Syntax: 'new Class { ...  I2 = 2 } }')

        Next (Regular) Block[B2]
            Leaving: {R1}
}

Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,560799,560897);

f_22056_560799_560896(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,556064,560908);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,556064,560908);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,556064,560908);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ObjectCreationFlow_41()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,560920,568055);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,561075,561285);

string 
source = @"
internal class Class
{
    public void M(bool b)
    /*<bind>*/{
        Class c = new Class { [GetInt() ?? 1] = { I1 = 2, I2 = 3 } };
    }/*</bind>*/

    int? GetInt() => 1;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,561299,561668);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22056_561553_561652(f_22056_561553_561632(f_22056_561553_561609(ErrorCode.ERR_BadIndexLHS, "[GetInt() ?? 1]"), "Class"), 6, 31)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,561684,567932);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [Class c]
    CaptureIds: [0]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'new Class { ...  I2 = 3 } }')
              Value: 
                IObjectCreationOperation (Constructor: Class..ctor()) (OperationKind.ObjectCreation, Type: Class, IsInvalid) (Syntax: 'new Class { ...  I2 = 3 } }')
                  Arguments(0)
                  Initializer: 
                    null

        Next (Regular) Block[B2]
            Entering: {R2} {R3}

    .locals {R2}
    {
        CaptureIds: [2]
        .locals {R3}
        {
            CaptureIds: [1]
            Block[B2] - Block
                Predecessors: [B1]
                Statements (1)
                    IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'GetInt()')
                      Value: 
                        IInvocationOperation ( System.Int32? Class.GetInt()) (OperationKind.Invocation, Type: System.Int32?, IsInvalid) (Syntax: 'GetInt()')
                          Instance Receiver: 
                            IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: Class, IsInvalid, IsImplicit) (Syntax: 'GetInt')
                          Arguments(0)

                Jump if True (Regular) to Block[B4]
                    IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsInvalid, IsImplicit) (Syntax: 'GetInt()')
                      Operand: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsInvalid, IsImplicit) (Syntax: 'GetInt()')
                    Leaving: {R3}

                Next (Regular) Block[B3]
            Block[B3] - Block
                Predecessors: [B2]
                Statements (1)
                    IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'GetInt()')
                      Value: 
                        IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'GetInt()')
                          Instance Receiver: 
                            IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsInvalid, IsImplicit) (Syntax: 'GetInt()')
                          Arguments(0)

                Next (Regular) Block[B5]
                    Leaving: {R3}
        }

        Block[B4] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: '1')
                  Value: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1, IsInvalid) (Syntax: '1')

            Next (Regular) Block[B5]
        Block[B5] - Block
            Predecessors: [B3] [B4]
            Statements (2)
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: ?) (Syntax: 'I1 = 2')
                  Left: 
                    IInvalidOperation (OperationKind.Invalid, Type: ?, IsImplicit) (Syntax: 'I1')
                      Children(1):
                          IOperation:  (OperationKind.None, Type: null) (Syntax: 'I1')
                            Children(1):
                                IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid) (Syntax: '[GetInt() ?? 1]')
                                  Children(2):
                                      IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'GetInt() ?? 1')
                                      IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: Class, IsInvalid, IsImplicit) (Syntax: 'new Class { ...  I2 = 3 } }')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')

                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: ?) (Syntax: 'I2 = 3')
                  Left: 
                    IInvalidOperation (OperationKind.Invalid, Type: ?, IsImplicit) (Syntax: 'I2')
                      Children(1):
                          IOperation:  (OperationKind.None, Type: null) (Syntax: 'I2')
                            Children(1):
                                IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid) (Syntax: '[GetInt() ?? 1]')
                                  Children(2):
                                      IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'GetInt() ?? 1')
                                      IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: Class, IsInvalid, IsImplicit) (Syntax: 'new Class { ...  I2 = 3 } }')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')

            Next (Regular) Block[B6]
                Leaving: {R2}
    }

    Block[B6] - Block
        Predecessors: [B5]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: Class, IsInvalid, IsImplicit) (Syntax: 'c = new Cla ...  I2 = 3 } }')
              Left: 
                ILocalReferenceOperation: c (IsDeclaration: True) (OperationKind.LocalReference, Type: Class, IsInvalid, IsImplicit) (Syntax: 'c = new Cla ...  I2 = 3 } }')
              Right: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: Class, IsInvalid, IsImplicit) (Syntax: 'new Class { ...  I2 = 3 } }')

        Next (Regular) Block[B7]
            Leaving: {R1}
}

Block[B7] - Exit
    Predecessors: [B6]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,567946,568044);

f_22056_567946_568043(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,560920,568055);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,560920,568055);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,560920,568055);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ObjectCreationFlow_42()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,568067,573412);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,568222,568599);

string 
source = @"
using System;

internal class Class
{
    public void M(bool a, string b, object o)
    /*<bind>*/{
        Class c = new Class { C2s = { [GetInt()] = { I1 = 1, I2 = 2 } } };
    }/*</bind>*/

    public C2[] C2s { get; set; }
    public int GetInt() => 0;
}

class C2
{
    public int I1 { get; set; }
    public int I2 { get; set; }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,568613,568666);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,568682,573289);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [Class c]
    CaptureIds: [0]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new Class { ... 2 = 2 } } }')
              Value: 
                IObjectCreationOperation (Constructor: Class..ctor()) (OperationKind.ObjectCreation, Type: Class) (Syntax: 'new Class { ... 2 = 2 } } }')
                  Arguments(0)
                  Initializer: 
                    null

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (3)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'GetInt()')
                  Value: 
                    IInvocationOperation ( System.Int32 Class.GetInt()) (OperationKind.Invocation, Type: System.Int32) (Syntax: 'GetInt()')
                      Instance Receiver: 
                        IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: Class, IsImplicit) (Syntax: 'GetInt')
                      Arguments(0)

                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'I1 = 1')
                  Left: 
                    IPropertyReferenceOperation: System.Int32 C2.I1 { get; set; } (OperationKind.PropertyReference, Type: System.Int32) (Syntax: 'I1')
                      Instance Receiver: 
                        IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: C2) (Syntax: '[GetInt()]')
                          Array reference: 
                            IPropertyReferenceOperation: C2[] Class.C2s { get; set; } (OperationKind.PropertyReference, Type: C2[]) (Syntax: 'C2s')
                              Instance Receiver: 
                                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: Class, IsImplicit) (Syntax: 'new Class { ... 2 = 2 } } }')
                          Indices(1):
                              IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'GetInt()')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'I2 = 2')
                  Left: 
                    IPropertyReferenceOperation: System.Int32 C2.I2 { get; set; } (OperationKind.PropertyReference, Type: System.Int32) (Syntax: 'I2')
                      Instance Receiver: 
                        IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: C2) (Syntax: '[GetInt()]')
                          Array reference: 
                            IPropertyReferenceOperation: C2[] Class.C2s { get; set; } (OperationKind.PropertyReference, Type: C2[]) (Syntax: 'C2s')
                              Instance Receiver: 
                                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: Class, IsImplicit) (Syntax: 'new Class { ... 2 = 2 } } }')
                          Indices(1):
                              IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'GetInt()')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')

            Next (Regular) Block[B3]
                Leaving: {R2}
    }

    Block[B3] - Block
        Predecessors: [B2]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: Class, IsImplicit) (Syntax: 'c = new Cla ... 2 = 2 } } }')
              Left: 
                ILocalReferenceOperation: c (IsDeclaration: True) (OperationKind.LocalReference, Type: Class, IsImplicit) (Syntax: 'c = new Cla ... 2 = 2 } } }')
              Right: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: Class, IsImplicit) (Syntax: 'new Class { ... 2 = 2 } } }')

        Next (Regular) Block[B4]
            Leaving: {R1}
}

Block[B4] - Exit
    Predecessors: [B3]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,573303,573401);

f_22056_573303_573400(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,568067,573412);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,568067,573412);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,568067,573412);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ObjectCreationFlow_43()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,573424,580553);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,573579,573962);

string 
source = @"
using System;

internal class Class
{
    public void M(bool a, string b, object o)
    /*<bind>*/{
        Class c = new Class { C2s = { [GetInt() ?? 0] = { I1 = 1, I2 = 2 } } };
    }/*</bind>*/

    public C2[] C2s { get; set; }
    public int? GetInt() => 0;
}

class C2
{
    public int I1 { get; set; }
    public int I2 { get; set; }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,573976,574029);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,574045,580430);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [Class c]
    CaptureIds: [0]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new Class { ... 2 = 2 } } }')
              Value: 
                IObjectCreationOperation (Constructor: Class..ctor()) (OperationKind.ObjectCreation, Type: Class) (Syntax: 'new Class { ... 2 = 2 } } }')
                  Arguments(0)
                  Initializer: 
                    null

        Next (Regular) Block[B2]
            Entering: {R2} {R3}

    .locals {R2}
    {
        CaptureIds: [2]
        .locals {R3}
        {
            CaptureIds: [1]
            Block[B2] - Block
                Predecessors: [B1]
                Statements (1)
                    IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'GetInt()')
                      Value: 
                        IInvocationOperation ( System.Int32? Class.GetInt()) (OperationKind.Invocation, Type: System.Int32?) (Syntax: 'GetInt()')
                          Instance Receiver: 
                            IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: Class, IsImplicit) (Syntax: 'GetInt')
                          Arguments(0)

                Jump if True (Regular) to Block[B4]
                    IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'GetInt()')
                      Operand: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'GetInt()')
                    Leaving: {R3}

                Next (Regular) Block[B3]
            Block[B3] - Block
                Predecessors: [B2]
                Statements (1)
                    IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'GetInt()')
                      Value: 
                        IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsImplicit) (Syntax: 'GetInt()')
                          Instance Receiver: 
                            IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'GetInt()')
                          Arguments(0)

                Next (Regular) Block[B5]
                    Leaving: {R3}
        }

        Block[B4] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '0')
                  Value: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')

            Next (Regular) Block[B5]
        Block[B5] - Block
            Predecessors: [B3] [B4]
            Statements (2)
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'I1 = 1')
                  Left: 
                    IPropertyReferenceOperation: System.Int32 C2.I1 { get; set; } (OperationKind.PropertyReference, Type: System.Int32) (Syntax: 'I1')
                      Instance Receiver: 
                        IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: C2) (Syntax: '[GetInt() ?? 0]')
                          Array reference: 
                            IPropertyReferenceOperation: C2[] Class.C2s { get; set; } (OperationKind.PropertyReference, Type: C2[]) (Syntax: 'C2s')
                              Instance Receiver: 
                                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: Class, IsImplicit) (Syntax: 'new Class { ... 2 = 2 } } }')
                          Indices(1):
                              IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'GetInt() ?? 0')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'I2 = 2')
                  Left: 
                    IPropertyReferenceOperation: System.Int32 C2.I2 { get; set; } (OperationKind.PropertyReference, Type: System.Int32) (Syntax: 'I2')
                      Instance Receiver: 
                        IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: C2) (Syntax: '[GetInt() ?? 0]')
                          Array reference: 
                            IPropertyReferenceOperation: C2[] Class.C2s { get; set; } (OperationKind.PropertyReference, Type: C2[]) (Syntax: 'C2s')
                              Instance Receiver: 
                                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: Class, IsImplicit) (Syntax: 'new Class { ... 2 = 2 } } }')
                          Indices(1):
                              IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'GetInt() ?? 0')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')

            Next (Regular) Block[B6]
                Leaving: {R2}
    }

    Block[B6] - Block
        Predecessors: [B5]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: Class, IsImplicit) (Syntax: 'c = new Cla ... 2 = 2 } } }')
              Left: 
                ILocalReferenceOperation: c (IsDeclaration: True) (OperationKind.LocalReference, Type: Class, IsImplicit) (Syntax: 'c = new Cla ... 2 = 2 } } }')
              Right: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: Class, IsImplicit) (Syntax: 'new Class { ... 2 = 2 } } }')

        Next (Regular) Block[B7]
            Leaving: {R1}
}

Block[B7] - Exit
    Predecessors: [B6]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,580444,580542);

f_22056_580444_580541(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,573424,580553);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,573424,580553);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,573424,580553);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ObjectCreationFlow_44()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,580565,589127);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,580720,581087);

string 
source = @"
using System;

internal class Class
{
    public void M(bool b)
    /*<bind>*/{
        Class c = new Class { C2s = { [0] = { I1 = b ? 1 : 2, I2 = b ? 3 : 4 } } };
    }/*</bind>*/

    public C2[] C2s { get; set; }
    public int? GetInt() => 0;
}

class C2
{
    public int I1 { get; set; }
    public int I2 { get; set; }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,581101,581154);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,581170,589004);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [Class c]
    CaptureIds: [0]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new Class { ... 3 : 4 } } }')
              Value: 
                IObjectCreationOperation (Constructor: Class..ctor()) (OperationKind.ObjectCreation, Type: Class) (Syntax: 'new Class { ... 3 : 4 } } }')
                  Arguments(0)
                  Initializer: 
                    null

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '0')
                  Value: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')

            Next (Regular) Block[B3]
                Entering: {R3}

        .locals {R3}
        {
            CaptureIds: [2] [3]
            Block[B3] - Block
                Predecessors: [B2]
                Statements (1)
                    IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '[0]')
                      Value: 
                        IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: C2) (Syntax: '[0]')
                          Array reference: 
                            IPropertyReferenceOperation: C2[] Class.C2s { get; set; } (OperationKind.PropertyReference, Type: C2[]) (Syntax: 'C2s')
                              Instance Receiver: 
                                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: Class, IsImplicit) (Syntax: 'new Class { ... 3 : 4 } } }')
                          Indices(1):
                              IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32, Constant: 0, IsImplicit) (Syntax: '0')

                Jump if False (Regular) to Block[B5]
                    IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

                Next (Regular) Block[B4]
            Block[B4] - Block
                Predecessors: [B3]
                Statements (1)
                    IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '1')
                      Value: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

                Next (Regular) Block[B6]
            Block[B5] - Block
                Predecessors: [B3]
                Statements (1)
                    IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '2')
                      Value: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')

                Next (Regular) Block[B6]
            Block[B6] - Block
                Predecessors: [B4] [B5]
                Statements (1)
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'I1 = b ? 1 : 2')
                      Left: 
                        IPropertyReferenceOperation: System.Int32 C2.I1 { get; set; } (OperationKind.PropertyReference, Type: System.Int32) (Syntax: 'I1')
                          Instance Receiver: 
                            IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: C2, IsImplicit) (Syntax: '[0]')
                      Right: 
                        IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'b ? 1 : 2')

                Next (Regular) Block[B7]
                    Leaving: {R3}
                    Entering: {R4}
        }
        .locals {R4}
        {
            CaptureIds: [4] [5]
            Block[B7] - Block
                Predecessors: [B6]
                Statements (1)
                    IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '[0]')
                      Value: 
                        IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: C2) (Syntax: '[0]')
                          Array reference: 
                            IPropertyReferenceOperation: C2[] Class.C2s { get; set; } (OperationKind.PropertyReference, Type: C2[]) (Syntax: 'C2s')
                              Instance Receiver: 
                                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: Class, IsImplicit) (Syntax: 'new Class { ... 3 : 4 } } }')
                          Indices(1):
                              IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32, Constant: 0, IsImplicit) (Syntax: '0')

                Jump if False (Regular) to Block[B9]
                    IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

                Next (Regular) Block[B8]
            Block[B8] - Block
                Predecessors: [B7]
                Statements (1)
                    IFlowCaptureOperation: 5 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '3')
                      Value: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')

                Next (Regular) Block[B10]
            Block[B9] - Block
                Predecessors: [B7]
                Statements (1)
                    IFlowCaptureOperation: 5 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '4')
                      Value: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 4) (Syntax: '4')

                Next (Regular) Block[B10]
            Block[B10] - Block
                Predecessors: [B8] [B9]
                Statements (1)
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'I2 = b ? 3 : 4')
                      Left: 
                        IPropertyReferenceOperation: System.Int32 C2.I2 { get; set; } (OperationKind.PropertyReference, Type: System.Int32) (Syntax: 'I2')
                          Instance Receiver: 
                            IFlowCaptureReferenceOperation: 4 (OperationKind.FlowCaptureReference, Type: C2, IsImplicit) (Syntax: '[0]')
                      Right: 
                        IFlowCaptureReferenceOperation: 5 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'b ? 3 : 4')

                Next (Regular) Block[B11]
                    Leaving: {R4} {R2}
        }
    }

    Block[B11] - Block
        Predecessors: [B10]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: Class, IsImplicit) (Syntax: 'c = new Cla ... 3 : 4 } } }')
              Left: 
                ILocalReferenceOperation: c (IsDeclaration: True) (OperationKind.LocalReference, Type: Class, IsImplicit) (Syntax: 'c = new Cla ... 3 : 4 } } }')
              Right: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: Class, IsImplicit) (Syntax: 'new Class { ... 3 : 4 } } }')

        Next (Regular) Block[B12]
            Leaving: {R1}
}

Block[B12] - Exit
    Predecessors: [B11]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,589018,589116);

f_22056_589018_589115(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,580565,589127);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,580565,589127);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,580565,589127);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ObjectCreationFlow_45()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,589139,594411);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,589294,589638);

string 
source = @"
using System;

internal class Class
{
    public void M(bool b)
    /*<bind>*/{
        Class c = new Class { C2s = { [GetInt()] = { I1 = 1, I2 = 2 } } };
    }/*</bind>*/

    public C2[] C2s;
    public int GetInt() => 0;
}

class C2
{
    public int I1 { get; set; }
    public int I2 { get; set; }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,589652,589705);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,589721,594288);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [Class c]
    CaptureIds: [0]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new Class { ... 2 = 2 } } }')
              Value: 
                IObjectCreationOperation (Constructor: Class..ctor()) (OperationKind.ObjectCreation, Type: Class) (Syntax: 'new Class { ... 2 = 2 } } }')
                  Arguments(0)
                  Initializer: 
                    null

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (3)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'GetInt()')
                  Value: 
                    IInvocationOperation ( System.Int32 Class.GetInt()) (OperationKind.Invocation, Type: System.Int32) (Syntax: 'GetInt()')
                      Instance Receiver: 
                        IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: Class, IsImplicit) (Syntax: 'GetInt')
                      Arguments(0)

                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'I1 = 1')
                  Left: 
                    IPropertyReferenceOperation: System.Int32 C2.I1 { get; set; } (OperationKind.PropertyReference, Type: System.Int32) (Syntax: 'I1')
                      Instance Receiver: 
                        IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: C2) (Syntax: '[GetInt()]')
                          Array reference: 
                            IFieldReferenceOperation: C2[] Class.C2s (OperationKind.FieldReference, Type: C2[]) (Syntax: 'C2s')
                              Instance Receiver: 
                                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: Class, IsImplicit) (Syntax: 'new Class { ... 2 = 2 } } }')
                          Indices(1):
                              IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'GetInt()')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'I2 = 2')
                  Left: 
                    IPropertyReferenceOperation: System.Int32 C2.I2 { get; set; } (OperationKind.PropertyReference, Type: System.Int32) (Syntax: 'I2')
                      Instance Receiver: 
                        IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: C2) (Syntax: '[GetInt()]')
                          Array reference: 
                            IFieldReferenceOperation: C2[] Class.C2s (OperationKind.FieldReference, Type: C2[]) (Syntax: 'C2s')
                              Instance Receiver: 
                                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: Class, IsImplicit) (Syntax: 'new Class { ... 2 = 2 } } }')
                          Indices(1):
                              IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'GetInt()')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')

            Next (Regular) Block[B3]
                Leaving: {R2}
    }

    Block[B3] - Block
        Predecessors: [B2]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: Class, IsImplicit) (Syntax: 'c = new Cla ... 2 = 2 } } }')
              Left: 
                ILocalReferenceOperation: c (IsDeclaration: True) (OperationKind.LocalReference, Type: Class, IsImplicit) (Syntax: 'c = new Cla ... 2 = 2 } } }')
              Right: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: Class, IsImplicit) (Syntax: 'new Class { ... 2 = 2 } } }')

        Next (Regular) Block[B4]
            Leaving: {R1}
}

Block[B4] - Exit
    Predecessors: [B3]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,594302,594400);

f_22056_594302_594399(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,589139,594411);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,589139,594411);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,589139,594411);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ObjectCreationFlow_46()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,594423,601479);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,594578,594928);

string 
source = @"
using System;

internal class Class
{
    public void M(bool b)
    /*<bind>*/{
        Class c = new Class { C2s = { [GetInt() ?? 0] = { I1 = 1, I2 = 2 } } };
    }/*</bind>*/

    public C2[] C2s;
    public int? GetInt() => 0;
}

class C2
{
    public int I1 { get; set; }
    public int I2 { get; set; }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,594942,594995);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,595011,601356);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [Class c]
    CaptureIds: [0]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new Class { ... 2 = 2 } } }')
              Value: 
                IObjectCreationOperation (Constructor: Class..ctor()) (OperationKind.ObjectCreation, Type: Class) (Syntax: 'new Class { ... 2 = 2 } } }')
                  Arguments(0)
                  Initializer: 
                    null

        Next (Regular) Block[B2]
            Entering: {R2} {R3}

    .locals {R2}
    {
        CaptureIds: [2]
        .locals {R3}
        {
            CaptureIds: [1]
            Block[B2] - Block
                Predecessors: [B1]
                Statements (1)
                    IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'GetInt()')
                      Value: 
                        IInvocationOperation ( System.Int32? Class.GetInt()) (OperationKind.Invocation, Type: System.Int32?) (Syntax: 'GetInt()')
                          Instance Receiver: 
                            IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: Class, IsImplicit) (Syntax: 'GetInt')
                          Arguments(0)

                Jump if True (Regular) to Block[B4]
                    IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'GetInt()')
                      Operand: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'GetInt()')
                    Leaving: {R3}

                Next (Regular) Block[B3]
            Block[B3] - Block
                Predecessors: [B2]
                Statements (1)
                    IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'GetInt()')
                      Value: 
                        IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsImplicit) (Syntax: 'GetInt()')
                          Instance Receiver: 
                            IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'GetInt()')
                          Arguments(0)

                Next (Regular) Block[B5]
                    Leaving: {R3}
        }

        Block[B4] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '0')
                  Value: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')

            Next (Regular) Block[B5]
        Block[B5] - Block
            Predecessors: [B3] [B4]
            Statements (2)
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'I1 = 1')
                  Left: 
                    IPropertyReferenceOperation: System.Int32 C2.I1 { get; set; } (OperationKind.PropertyReference, Type: System.Int32) (Syntax: 'I1')
                      Instance Receiver: 
                        IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: C2) (Syntax: '[GetInt() ?? 0]')
                          Array reference: 
                            IFieldReferenceOperation: C2[] Class.C2s (OperationKind.FieldReference, Type: C2[]) (Syntax: 'C2s')
                              Instance Receiver: 
                                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: Class, IsImplicit) (Syntax: 'new Class { ... 2 = 2 } } }')
                          Indices(1):
                              IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'GetInt() ?? 0')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'I2 = 2')
                  Left: 
                    IPropertyReferenceOperation: System.Int32 C2.I2 { get; set; } (OperationKind.PropertyReference, Type: System.Int32) (Syntax: 'I2')
                      Instance Receiver: 
                        IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: C2) (Syntax: '[GetInt() ?? 0]')
                          Array reference: 
                            IFieldReferenceOperation: C2[] Class.C2s (OperationKind.FieldReference, Type: C2[]) (Syntax: 'C2s')
                              Instance Receiver: 
                                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: Class, IsImplicit) (Syntax: 'new Class { ... 2 = 2 } } }')
                          Indices(1):
                              IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'GetInt() ?? 0')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')

            Next (Regular) Block[B6]
                Leaving: {R2}
    }

    Block[B6] - Block
        Predecessors: [B5]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: Class, IsImplicit) (Syntax: 'c = new Cla ... 2 = 2 } } }')
              Left: 
                ILocalReferenceOperation: c (IsDeclaration: True) (OperationKind.LocalReference, Type: Class, IsImplicit) (Syntax: 'c = new Cla ... 2 = 2 } } }')
              Right: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: Class, IsImplicit) (Syntax: 'new Class { ... 2 = 2 } } }')

        Next (Regular) Block[B7]
            Leaving: {R1}
}

Block[B7] - Exit
    Predecessors: [B6]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,601370,601468);

f_22056_601370_601467(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,594423,601479);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,594423,601479);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,594423,601479);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ObjectCreationFlow_47()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,601491,610436);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,601646,601976);

string 
source = @"
using System;

internal class Class
{
    public void M(bool b)
    /*<bind>*/{
        Class c = new Class { C2s = { [GetInt() ?? 0] = { I1 = { [1] = 2, [3] = 4 } } } };
    }/*</bind>*/

    public C2[] C2s;
    public int? GetInt() => 0;
}

class C2
{
    public int[] I1 { get; set; }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,601990,602043);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,602059,610313);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [Class c]
    CaptureIds: [0]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new Class { ... = 4 } } } }')
              Value: 
                IObjectCreationOperation (Constructor: Class..ctor()) (OperationKind.ObjectCreation, Type: Class) (Syntax: 'new Class { ... = 4 } } } }')
                  Arguments(0)
                  Initializer: 
                    null

        Next (Regular) Block[B2]
            Entering: {R2} {R3}

    .locals {R2}
    {
        CaptureIds: [2]
        .locals {R3}
        {
            CaptureIds: [1]
            Block[B2] - Block
                Predecessors: [B1]
                Statements (1)
                    IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'GetInt()')
                      Value: 
                        IInvocationOperation ( System.Int32? Class.GetInt()) (OperationKind.Invocation, Type: System.Int32?) (Syntax: 'GetInt()')
                          Instance Receiver: 
                            IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: Class, IsImplicit) (Syntax: 'GetInt')
                          Arguments(0)

                Jump if True (Regular) to Block[B4]
                    IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'GetInt()')
                      Operand: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'GetInt()')
                    Leaving: {R3}

                Next (Regular) Block[B3]
            Block[B3] - Block
                Predecessors: [B2]
                Statements (1)
                    IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'GetInt()')
                      Value: 
                        IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsImplicit) (Syntax: 'GetInt()')
                          Instance Receiver: 
                            IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'GetInt()')
                          Arguments(0)

                Next (Regular) Block[B5]
                    Leaving: {R3}
                    Entering: {R4}
        }

        Block[B4] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '0')
                  Value: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')

            Next (Regular) Block[B5]
                Entering: {R4}

        .locals {R4}
        {
            CaptureIds: [3]
            Block[B5] - Block
                Predecessors: [B3] [B4]
                Statements (2)
                    IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '1')
                      Value: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: '[1] = 2')
                      Left: 
                        IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: System.Int32) (Syntax: '[1]')
                          Array reference: 
                            IPropertyReferenceOperation: System.Int32[] C2.I1 { get; set; } (OperationKind.PropertyReference, Type: System.Int32[]) (Syntax: 'I1')
                              Instance Receiver: 
                                IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: C2) (Syntax: '[GetInt() ?? 0]')
                                  Array reference: 
                                    IFieldReferenceOperation: C2[] Class.C2s (OperationKind.FieldReference, Type: C2[]) (Syntax: 'C2s')
                                      Instance Receiver: 
                                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: Class, IsImplicit) (Syntax: 'new Class { ... = 4 } } } }')
                                  Indices(1):
                                      IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'GetInt() ?? 0')
                          Indices(1):
                              IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Int32, Constant: 1, IsImplicit) (Syntax: '1')
                      Right: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')

                Next (Regular) Block[B6]
                    Leaving: {R4}
                    Entering: {R5}
        }
        .locals {R5}
        {
            CaptureIds: [4]
            Block[B6] - Block
                Predecessors: [B5]
                Statements (2)
                    IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '3')
                      Value: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')

                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: '[3] = 4')
                      Left: 
                        IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: System.Int32) (Syntax: '[3]')
                          Array reference: 
                            IPropertyReferenceOperation: System.Int32[] C2.I1 { get; set; } (OperationKind.PropertyReference, Type: System.Int32[]) (Syntax: 'I1')
                              Instance Receiver: 
                                IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: C2) (Syntax: '[GetInt() ?? 0]')
                                  Array reference: 
                                    IFieldReferenceOperation: C2[] Class.C2s (OperationKind.FieldReference, Type: C2[]) (Syntax: 'C2s')
                                      Instance Receiver: 
                                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: Class, IsImplicit) (Syntax: 'new Class { ... = 4 } } } }')
                                  Indices(1):
                                      IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'GetInt() ?? 0')
                          Indices(1):
                              IFlowCaptureReferenceOperation: 4 (OperationKind.FlowCaptureReference, Type: System.Int32, Constant: 3, IsImplicit) (Syntax: '3')
                      Right: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 4) (Syntax: '4')

                Next (Regular) Block[B7]
                    Leaving: {R5} {R2}
        }
    }

    Block[B7] - Block
        Predecessors: [B6]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: Class, IsImplicit) (Syntax: 'c = new Cla ... = 4 } } } }')
              Left: 
                ILocalReferenceOperation: c (IsDeclaration: True) (OperationKind.LocalReference, Type: Class, IsImplicit) (Syntax: 'c = new Cla ... = 4 } } } }')
              Right: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: Class, IsImplicit) (Syntax: 'new Class { ... = 4 } } } }')

        Next (Regular) Block[B8]
            Leaving: {R1}
}

Block[B8] - Exit
    Predecessors: [B7]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,610327,610425);

f_22056_610327_610424(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,601491,610436);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,601491,610436);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,601491,610436);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ObjectCreationFlow_48()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,610448,620514);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,610603,610941);

string 
source = @"
using System;

internal class Class
{
    public void M(bool b)
    /*<bind>*/{
        Class c = new Class { C2s = { [0] = { I1 = { [GetInt() ?? 1] = 2, [b ? 3 : 4] = 5 } } } };
    }/*</bind>*/

    public C2[] C2s;
    public int? GetInt() => 0;
}

class C2
{
    public int[] I1 { get; set; }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,610955,611008);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,611024,620391);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [Class c]
    CaptureIds: [0]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new Class { ... = 5 } } } }')
              Value: 
                IObjectCreationOperation (Constructor: Class..ctor()) (OperationKind.ObjectCreation, Type: Class) (Syntax: 'new Class { ... = 5 } } } }')
                  Arguments(0)
                  Initializer: 
                    null

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '0')
                  Value: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')

            Next (Regular) Block[B3]
                Entering: {R3} {R4}

        .locals {R3}
        {
            CaptureIds: [3]
            .locals {R4}
            {
                CaptureIds: [2]
                Block[B3] - Block
                    Predecessors: [B2]
                    Statements (1)
                        IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'GetInt()')
                          Value: 
                            IInvocationOperation ( System.Int32? Class.GetInt()) (OperationKind.Invocation, Type: System.Int32?) (Syntax: 'GetInt()')
                              Instance Receiver: 
                                IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: Class, IsImplicit) (Syntax: 'GetInt')
                              Arguments(0)

                    Jump if True (Regular) to Block[B5]
                        IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'GetInt()')
                          Operand: 
                            IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'GetInt()')
                        Leaving: {R4}

                    Next (Regular) Block[B4]
                Block[B4] - Block
                    Predecessors: [B3]
                    Statements (1)
                        IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'GetInt()')
                          Value: 
                            IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsImplicit) (Syntax: 'GetInt()')
                              Instance Receiver: 
                                IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'GetInt()')
                              Arguments(0)

                    Next (Regular) Block[B6]
                        Leaving: {R4}
            }

            Block[B5] - Block
                Predecessors: [B3]
                Statements (1)
                    IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '1')
                      Value: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

                Next (Regular) Block[B6]
            Block[B6] - Block
                Predecessors: [B4] [B5]
                Statements (1)
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: '[GetInt() ?? 1] = 2')
                      Left: 
                        IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: System.Int32) (Syntax: '[GetInt() ?? 1]')
                          Array reference: 
                            IPropertyReferenceOperation: System.Int32[] C2.I1 { get; set; } (OperationKind.PropertyReference, Type: System.Int32[]) (Syntax: 'I1')
                              Instance Receiver: 
                                IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: C2) (Syntax: '[0]')
                                  Array reference: 
                                    IFieldReferenceOperation: C2[] Class.C2s (OperationKind.FieldReference, Type: C2[]) (Syntax: 'C2s')
                                      Instance Receiver: 
                                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: Class, IsImplicit) (Syntax: 'new Class { ... = 5 } } } }')
                                  Indices(1):
                                      IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32, Constant: 0, IsImplicit) (Syntax: '0')
                          Indices(1):
                              IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'GetInt() ?? 1')
                      Right: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')

                Next (Regular) Block[B7]
                    Leaving: {R3}
                    Entering: {R5}
        }
        .locals {R5}
        {
            CaptureIds: [4]
            Block[B7] - Block
                Predecessors: [B6]
                Statements (0)
                Jump if False (Regular) to Block[B9]
                    IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

                Next (Regular) Block[B8]
            Block[B8] - Block
                Predecessors: [B7]
                Statements (1)
                    IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '3')
                      Value: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')

                Next (Regular) Block[B10]
            Block[B9] - Block
                Predecessors: [B7]
                Statements (1)
                    IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '4')
                      Value: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 4) (Syntax: '4')

                Next (Regular) Block[B10]
            Block[B10] - Block
                Predecessors: [B8] [B9]
                Statements (1)
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: '[b ? 3 : 4] = 5')
                      Left: 
                        IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: System.Int32) (Syntax: '[b ? 3 : 4]')
                          Array reference: 
                            IPropertyReferenceOperation: System.Int32[] C2.I1 { get; set; } (OperationKind.PropertyReference, Type: System.Int32[]) (Syntax: 'I1')
                              Instance Receiver: 
                                IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: C2) (Syntax: '[0]')
                                  Array reference: 
                                    IFieldReferenceOperation: C2[] Class.C2s (OperationKind.FieldReference, Type: C2[]) (Syntax: 'C2s')
                                      Instance Receiver: 
                                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: Class, IsImplicit) (Syntax: 'new Class { ... = 5 } } } }')
                                  Indices(1):
                                      IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32, Constant: 0, IsImplicit) (Syntax: '0')
                          Indices(1):
                              IFlowCaptureReferenceOperation: 4 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'b ? 3 : 4')
                      Right: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 5) (Syntax: '5')

                Next (Regular) Block[B11]
                    Leaving: {R5} {R2}
        }
    }

    Block[B11] - Block
        Predecessors: [B10]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: Class, IsImplicit) (Syntax: 'c = new Cla ... = 5 } } } }')
              Left: 
                ILocalReferenceOperation: c (IsDeclaration: True) (OperationKind.LocalReference, Type: Class, IsImplicit) (Syntax: 'c = new Cla ... = 5 } } } }')
              Right: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: Class, IsImplicit) (Syntax: 'new Class { ... = 5 } } } }')

        Next (Regular) Block[B12]
            Leaving: {R1}
}

Block[B12] - Exit
    Predecessors: [B11]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,620405,620503);

f_22056_620405_620502(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,610448,620514);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,610448,620514);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,610448,620514);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ObjectCreationFlow_49()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,620526,625103);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,620681,620901);

string 
source = @"
internal class Class
{
    public void M(Class c, int i, bool b)
    /*<bind>*/{
        c = new Class { P1 = { [(i = 3), i] = 3 } };
    }/*</bind>*/

    public int[,] P1 { get; set; }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,620915,620968);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,620984,624980);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [1]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (2)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c')
              Value: 
                IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: Class) (Syntax: 'c')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new Class { ...  i] = 3 } }')
              Value: 
                IObjectCreationOperation (Constructor: Class..ctor()) (OperationKind.ObjectCreation, Type: Class) (Syntax: 'new Class { ...  i] = 3 } }')
                  Arguments(0)
                  Initializer: 
                    null

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [2] [3]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (3)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i = 3')
                  Value: 
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'i = 3')
                      Left: 
                        IParameterReferenceOperation: i (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i')
                      Right: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')

                IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i')
                  Value: 
                    IParameterReferenceOperation: i (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i')

                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: '[(i = 3), i] = 3')
                  Left: 
                    IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: System.Int32) (Syntax: '[(i = 3), i]')
                      Array reference: 
                        IPropertyReferenceOperation: System.Int32[,] Class.P1 { get; set; } (OperationKind.PropertyReference, Type: System.Int32[,]) (Syntax: 'P1')
                          Instance Receiver: 
                            IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: Class, IsImplicit) (Syntax: 'new Class { ...  i] = 3 } }')
                      Indices(2):
                          IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'i = 3')
                          IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'i')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')

            Next (Regular) Block[B3]
                Leaving: {R2}
    }

    Block[B3] - Block
        Predecessors: [B2]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'c = new Cla ... i] = 3 } };')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: Class) (Syntax: 'c = new Cla ...  i] = 3 } }')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: Class, IsImplicit) (Syntax: 'c')
                  Right: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: Class, IsImplicit) (Syntax: 'new Class { ...  i] = 3 } }')

        Next (Regular) Block[B4]
            Leaving: {R1}
}

Block[B4] - Exit
    Predecessors: [B3]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,624994,625092);

f_22056_624994_625091(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,620526,625103);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,620526,625103);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,620526,625103);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ObjectCreationFlow_50()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,625115,630187);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,625270,625492);

string 
source = @"
internal class Class
{
    public void M(Class c, int i, bool b)
    /*<bind>*/{
        c = new Class { P1 = { [b ? 1 : 2, i] = 3 } };
    }/*</bind>*/

    public int[,] P1 { get; set; }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,625506,625559);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,625575,630064);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [1]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (2)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c')
              Value: 
                IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: Class) (Syntax: 'c')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new Class { ...  i] = 3 } }')
              Value: 
                IObjectCreationOperation (Constructor: Class..ctor()) (OperationKind.ObjectCreation, Type: Class) (Syntax: 'new Class { ...  i] = 3 } }')
                  Arguments(0)
                  Initializer: 
                    null

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [2] [3]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (0)
            Jump if False (Regular) to Block[B4]
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '1')
                  Value: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

            Next (Regular) Block[B5]
        Block[B4] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '2')
                  Value: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')

            Next (Regular) Block[B5]
        Block[B5] - Block
            Predecessors: [B3] [B4]
            Statements (2)
                IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i')
                  Value: 
                    IParameterReferenceOperation: i (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i')

                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: '[b ? 1 : 2, i] = 3')
                  Left: 
                    IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: System.Int32) (Syntax: '[b ? 1 : 2, i]')
                      Array reference: 
                        IPropertyReferenceOperation: System.Int32[,] Class.P1 { get; set; } (OperationKind.PropertyReference, Type: System.Int32[,]) (Syntax: 'P1')
                          Instance Receiver: 
                            IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: Class, IsImplicit) (Syntax: 'new Class { ...  i] = 3 } }')
                      Indices(2):
                          IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'b ? 1 : 2')
                          IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'i')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')

            Next (Regular) Block[B6]
                Leaving: {R2}
    }

    Block[B6] - Block
        Predecessors: [B5]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'c = new Cla ... i] = 3 } };')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: Class) (Syntax: 'c = new Cla ...  i] = 3 } }')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: Class, IsImplicit) (Syntax: 'c')
                  Right: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: Class, IsImplicit) (Syntax: 'new Class { ...  i] = 3 } }')

        Next (Regular) Block[B7]
            Leaving: {R1}
}

Block[B7] - Exit
    Predecessors: [B6]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,630078,630176);

f_22056_630078_630175(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,625115,630187);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,625115,630187);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,625115,630187);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ObjectCreationFlow_51()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,630199,635271);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,630354,630576);

string 
source = @"
internal class Class
{
    public void M(Class c, int i, bool b)
    /*<bind>*/{
        c = new Class { P1 = { [i, b ? 1 : 2] = 3 } };
    }/*</bind>*/

    public int[,] P1 { get; set; }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,630590,630643);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,630659,635148);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [1]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (2)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c')
              Value: 
                IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: Class) (Syntax: 'c')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new Class { ...  2] = 3 } }')
              Value: 
                IObjectCreationOperation (Constructor: Class..ctor()) (OperationKind.ObjectCreation, Type: Class) (Syntax: 'new Class { ...  2] = 3 } }')
                  Arguments(0)
                  Initializer: 
                    null

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [2] [3]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i')
                  Value: 
                    IParameterReferenceOperation: i (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i')

            Jump if False (Regular) to Block[B4]
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '1')
                  Value: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

            Next (Regular) Block[B5]
        Block[B4] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '2')
                  Value: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')

            Next (Regular) Block[B5]
        Block[B5] - Block
            Predecessors: [B3] [B4]
            Statements (1)
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: '[i, b ? 1 : 2] = 3')
                  Left: 
                    IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: System.Int32) (Syntax: '[i, b ? 1 : 2]')
                      Array reference: 
                        IPropertyReferenceOperation: System.Int32[,] Class.P1 { get; set; } (OperationKind.PropertyReference, Type: System.Int32[,]) (Syntax: 'P1')
                          Instance Receiver: 
                            IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: Class, IsImplicit) (Syntax: 'new Class { ...  2] = 3 } }')
                      Indices(2):
                          IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'i')
                          IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'b ? 1 : 2')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')

            Next (Regular) Block[B6]
                Leaving: {R2}
    }

    Block[B6] - Block
        Predecessors: [B5]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'c = new Cla ... 2] = 3 } };')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: Class) (Syntax: 'c = new Cla ...  2] = 3 } }')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: Class, IsImplicit) (Syntax: 'c')
                  Right: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: Class, IsImplicit) (Syntax: 'new Class { ...  2] = 3 } }')

        Next (Regular) Block[B7]
            Leaving: {R1}
}

Block[B7] - Exit
    Predecessors: [B6]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,635162,635260);

f_22056_635162_635259(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,630199,635271);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,630199,635271);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,630199,635271);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ObjectCreationFlow_52()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,635283,639449);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,635438,635648);

string 
source = @"
internal class Class
{
    public void M(Class c, int i, bool b)
    /*<bind>*/{
        c = new Class { P1 = { [] = 3 } };
    }/*</bind>*/

    public int[,] P1 { get; set; }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,635662,635935);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22056_635855_635919(f_22056_635855_635899(ErrorCode.ERR_ValueExpected, "]"), 6, 33)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,635951,639326);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [1]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (2)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c')
              Value: 
                IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: Class) (Syntax: 'c')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'new Class { ...  [] = 3 } }')
              Value: 
                IObjectCreationOperation (Constructor: Class..ctor()) (OperationKind.ObjectCreation, Type: Class, IsInvalid) (Syntax: 'new Class { ...  [] = 3 } }')
                  Arguments(0)
                  Initializer: 
                    null

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (2)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: '')
                  Value: 
                    IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid) (Syntax: '')
                      Children(0)

                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsInvalid) (Syntax: '[] = 3')
                  Left: 
                    IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: System.Int32, IsInvalid) (Syntax: '[]')
                      Array reference: 
                        IPropertyReferenceOperation: System.Int32[,] Class.P1 { get; set; } (OperationKind.PropertyReference, Type: System.Int32[,]) (Syntax: 'P1')
                          Instance Receiver: 
                            IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: Class, IsInvalid, IsImplicit) (Syntax: 'new Class { ...  [] = 3 } }')
                      Indices(1):
                          IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: null, IsInvalid, IsImplicit) (Syntax: '')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')

            Next (Regular) Block[B3]
                Leaving: {R2}
    }

    Block[B3] - Block
        Predecessors: [B2]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: 'c = new Cla ... [] = 3 } };')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: Class, IsInvalid) (Syntax: 'c = new Cla ...  [] = 3 } }')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: Class, IsImplicit) (Syntax: 'c')
                  Right: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: Class, IsInvalid, IsImplicit) (Syntax: 'new Class { ...  [] = 3 } }')

        Next (Regular) Block[B4]
            Leaving: {R1}
}

Block[B4] - Exit
    Predecessors: [B3]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,639340,639438);

f_22056_639340_639437(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,635283,639449);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,635283,639449);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,635283,639449);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ObjectCreationFlow_53()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,639461,644582);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,639616,639987);

string 
source = @"
using System.Collections;
using System.Collections.Generic;

class C : IEnumerable<int>
{
    /*<bind>*/public static void M(C c)
    {
        c = new C { 1, 2, 3 };
    }/*</bind>*/

    public IEnumerator<int> GetEnumerator() => throw null;
    IEnumerator IEnumerable.GetEnumerator() => throw null;
    public void Add(int i) {}
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,640001,640054);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,640070,644447);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [1]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (6)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c')
              Value: 
                IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: C) (Syntax: 'c')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new C { 1, 2, 3 }')
              Value: 
                IObjectCreationOperation (Constructor: C..ctor()) (OperationKind.ObjectCreation, Type: C) (Syntax: 'new C { 1, 2, 3 }')
                  Arguments(0)
                  Initializer: 
                    null

            IInvocationOperation ( void C.Add(System.Int32 i)) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: '1')
              Instance Receiver: 
                IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'new C { 1, 2, 3 }')
              Arguments(1):
                  IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: '1')
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
                    InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

            IInvocationOperation ( void C.Add(System.Int32 i)) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: '2')
              Instance Receiver: 
                IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'new C { 1, 2, 3 }')
              Arguments(1):
                  IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: '2')
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
                    InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

            IInvocationOperation ( void C.Add(System.Int32 i)) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: '3')
              Instance Receiver: 
                IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'new C { 1, 2, 3 }')
              Arguments(1):
                  IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: '3')
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')
                    InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'c = new C { 1, 2, 3 };')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: C) (Syntax: 'c = new C { 1, 2, 3 }')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'c')
                  Right: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'new C { 1, 2, 3 }')

        Next (Regular) Block[B2]
            Leaving: {R1}
}

Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,644461,644571);

f_22056_644461_644570(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,639461,644582);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,639461,644582);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,639461,644582);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ObjectCreationFlow_54()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,644594,656526);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,644749,645265);

string 
source = @"
using System.Collections;
using System.Collections.Generic;

class C1
{
    /*<bind>*/public static void M(C1 c)
    {
        c = new C1 { [GetInt(0)] = { GetInt(1), GetInt(2), GetInt(3) } };
    }/*</bind>*/

    C2 this[int i] { get => null; set { } }
    static int GetInt(int i) => i;
}

class C2 : IEnumerable<int>
{
    public IEnumerator<int> GetEnumerator() => throw null;
    IEnumerator IEnumerable.GetEnumerator() => throw null;
    public void Add(int i) { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,645279,645332);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,645348,656391);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [1]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (2)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c')
              Value: 
                IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: C1) (Syntax: 'c')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new C1 { [G ... tInt(3) } }')
              Value: 
                IObjectCreationOperation (Constructor: C1..ctor()) (OperationKind.ObjectCreation, Type: C1) (Syntax: 'new C1 { [G ... tInt(3) } }')
                  Arguments(0)
                  Initializer: 
                    null

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (4)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'GetInt(0)')
                  Value: 
                    IInvocationOperation (System.Int32 C1.GetInt(System.Int32 i)) (OperationKind.Invocation, Type: System.Int32) (Syntax: 'GetInt(0)')
                      Instance Receiver: 
                        null
                      Arguments(1):
                          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: '0')
                            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

                IInvocationOperation ( void C2.Add(System.Int32 i)) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'GetInt(1)')
                  Instance Receiver: 
                    IPropertyReferenceOperation: C2 C1.this[System.Int32 i] { get; set; } (OperationKind.PropertyReference, Type: C2) (Syntax: '[GetInt(0)]')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { [G ... tInt(3) } }')
                      Arguments(1):
                          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: 'GetInt(0)')
                            IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'GetInt(0)')
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  Arguments(1):
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'GetInt(1)')
                        IInvocationOperation (System.Int32 C1.GetInt(System.Int32 i)) (OperationKind.Invocation, Type: System.Int32) (Syntax: 'GetInt(1)')
                          Instance Receiver: 
                            null
                          Arguments(1):
                              IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: '1')
                                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
                                InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

                IInvocationOperation ( void C2.Add(System.Int32 i)) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'GetInt(2)')
                  Instance Receiver: 
                    IPropertyReferenceOperation: C2 C1.this[System.Int32 i] { get; set; } (OperationKind.PropertyReference, Type: C2) (Syntax: '[GetInt(0)]')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { [G ... tInt(3) } }')
                      Arguments(1):
                          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: 'GetInt(0)')
                            IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'GetInt(0)')
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  Arguments(1):
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'GetInt(2)')
                        IInvocationOperation (System.Int32 C1.GetInt(System.Int32 i)) (OperationKind.Invocation, Type: System.Int32) (Syntax: 'GetInt(2)')
                          Instance Receiver: 
                            null
                          Arguments(1):
                              IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: '2')
                                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
                                InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

                IInvocationOperation ( void C2.Add(System.Int32 i)) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'GetInt(3)')
                  Instance Receiver: 
                    IPropertyReferenceOperation: C2 C1.this[System.Int32 i] { get; set; } (OperationKind.PropertyReference, Type: C2) (Syntax: '[GetInt(0)]')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { [G ... tInt(3) } }')
                      Arguments(1):
                          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: 'GetInt(0)')
                            IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'GetInt(0)')
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  Arguments(1):
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'GetInt(3)')
                        IInvocationOperation (System.Int32 C1.GetInt(System.Int32 i)) (OperationKind.Invocation, Type: System.Int32) (Syntax: 'GetInt(3)')
                          Instance Receiver: 
                            null
                          Arguments(1):
                              IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: '3')
                                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')
                                InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

            Next (Regular) Block[B3]
                Leaving: {R2}
    }

    Block[B3] - Block
        Predecessors: [B2]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'c = new C1  ... Int(3) } };')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: C1) (Syntax: 'c = new C1  ... tInt(3) } }')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'c')
                  Right: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { [G ... tInt(3) } }')

        Next (Regular) Block[B4]
            Leaving: {R1}
}

Block[B4] - Exit
    Predecessors: [B3]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,656405,656515);

f_22056_656405_656514(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,644594,656526);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,644594,656526);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,644594,656526);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ObjectCreationFlow_55()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,656538,670542);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,656693,657229);

string 
source = @"
using System.Collections;
using System.Collections.Generic;

class C1
{
    /*<bind>*/public static void M(C1 c, int? i1, int? i2, int? i3)
    {
        c = new C1 { [GetInt(i1 ?? 0)] = { GetInt(i2 ?? 1), 2 } };
    }/*</bind>*/

    C2 this[int i] { get => null; set { } }
    static int GetInt(int i) => i;
}

class C2 : IEnumerable<int>
{
    public IEnumerator<int> GetEnumerator() => throw null;
    IEnumerator IEnumerable.GetEnumerator() => throw null;
    public void Add(int i) { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,657243,657296);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,657312,670407);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [1]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (2)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c')
              Value: 
                IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: C1) (Syntax: 'c')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new C1 { [G ... ? 1), 2 } }')
              Value: 
                IObjectCreationOperation (Constructor: C1..ctor()) (OperationKind.ObjectCreation, Type: C1) (Syntax: 'new C1 { [G ... ? 1), 2 } }')
                  Arguments(0)
                  Initializer: 
                    null

        Next (Regular) Block[B2]
            Entering: {R2} {R3} {R4}

    .locals {R2}
    {
        CaptureIds: [4]
        .locals {R3}
        {
            CaptureIds: [3]
            .locals {R4}
            {
                CaptureIds: [2]
                Block[B2] - Block
                    Predecessors: [B1]
                    Statements (1)
                        IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i1')
                          Value: 
                            IParameterReferenceOperation: i1 (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'i1')

                    Jump if True (Regular) to Block[B4]
                        IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'i1')
                          Operand: 
                            IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'i1')
                        Leaving: {R4}

                    Next (Regular) Block[B3]
                Block[B3] - Block
                    Predecessors: [B2]
                    Statements (1)
                        IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i1')
                          Value: 
                            IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsImplicit) (Syntax: 'i1')
                              Instance Receiver: 
                                IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'i1')
                              Arguments(0)

                    Next (Regular) Block[B5]
                        Leaving: {R4}
            }

            Block[B4] - Block
                Predecessors: [B2]
                Statements (1)
                    IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '0')
                      Value: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')

                Next (Regular) Block[B5]
            Block[B5] - Block
                Predecessors: [B3] [B4]
                Statements (1)
                    IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'GetInt(i1 ?? 0)')
                      Value: 
                        IInvocationOperation (System.Int32 C1.GetInt(System.Int32 i)) (OperationKind.Invocation, Type: System.Int32) (Syntax: 'GetInt(i1 ?? 0)')
                          Instance Receiver: 
                            null
                          Arguments(1):
                              IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: 'i1 ?? 0')
                                IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'i1 ?? 0')
                                InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

                Next (Regular) Block[B6]
                    Leaving: {R3}
                    Entering: {R5}
        }
        .locals {R5}
        {
            CaptureIds: [5] [7]
            Block[B6] - Block
                Predecessors: [B5]
                Statements (1)
                    IFlowCaptureOperation: 5 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '[GetInt(i1 ?? 0)]')
                      Value: 
                        IPropertyReferenceOperation: C2 C1.this[System.Int32 i] { get; set; } (OperationKind.PropertyReference, Type: C2) (Syntax: '[GetInt(i1 ?? 0)]')
                          Instance Receiver: 
                            IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { [G ... ? 1), 2 } }')
                          Arguments(1):
                              IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: 'GetInt(i1 ?? 0)')
                                IFlowCaptureReferenceOperation: 4 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'GetInt(i1 ?? 0)')
                                InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

                Next (Regular) Block[B7]
                    Entering: {R6}

            .locals {R6}
            {
                CaptureIds: [6]
                Block[B7] - Block
                    Predecessors: [B6]
                    Statements (1)
                        IFlowCaptureOperation: 6 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i2')
                          Value: 
                            IParameterReferenceOperation: i2 (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'i2')

                    Jump if True (Regular) to Block[B9]
                        IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'i2')
                          Operand: 
                            IFlowCaptureReferenceOperation: 6 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'i2')
                        Leaving: {R6}

                    Next (Regular) Block[B8]
                Block[B8] - Block
                    Predecessors: [B7]
                    Statements (1)
                        IFlowCaptureOperation: 7 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i2')
                          Value: 
                            IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsImplicit) (Syntax: 'i2')
                              Instance Receiver: 
                                IFlowCaptureReferenceOperation: 6 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'i2')
                              Arguments(0)

                    Next (Regular) Block[B10]
                        Leaving: {R6}
            }

            Block[B9] - Block
                Predecessors: [B7]
                Statements (1)
                    IFlowCaptureOperation: 7 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '1')
                      Value: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

                Next (Regular) Block[B10]
            Block[B10] - Block
                Predecessors: [B8] [B9]
                Statements (1)
                    IInvocationOperation ( void C2.Add(System.Int32 i)) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'GetInt(i2 ?? 1)')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 5 (OperationKind.FlowCaptureReference, Type: C2, IsImplicit) (Syntax: '[GetInt(i1 ?? 0)]')
                      Arguments(1):
                          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'GetInt(i2 ?? 1)')
                            IInvocationOperation (System.Int32 C1.GetInt(System.Int32 i)) (OperationKind.Invocation, Type: System.Int32) (Syntax: 'GetInt(i2 ?? 1)')
                              Instance Receiver: 
                                null
                              Arguments(1):
                                  IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: 'i2 ?? 1')
                                    IFlowCaptureReferenceOperation: 7 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'i2 ?? 1')
                                    InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                    OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

                Next (Regular) Block[B11]
                    Leaving: {R5}
        }

        Block[B11] - Block
            Predecessors: [B10]
            Statements (1)
                IInvocationOperation ( void C2.Add(System.Int32 i)) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: '2')
                  Instance Receiver: 
                    IPropertyReferenceOperation: C2 C1.this[System.Int32 i] { get; set; } (OperationKind.PropertyReference, Type: C2) (Syntax: '[GetInt(i1 ?? 0)]')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { [G ... ? 1), 2 } }')
                      Arguments(1):
                          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: 'GetInt(i1 ?? 0)')
                            IFlowCaptureReferenceOperation: 4 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'GetInt(i1 ?? 0)')
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  Arguments(1):
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: '2')
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

            Next (Regular) Block[B12]
                Leaving: {R2}
    }

    Block[B12] - Block
        Predecessors: [B11]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'c = new C1  ...  1), 2 } };')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: C1) (Syntax: 'c = new C1  ... ? 1), 2 } }')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'c')
                  Right: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { [G ... ? 1), 2 } }')

        Next (Regular) Block[B13]
            Leaving: {R1}
}

Block[B13] - Exit
    Predecessors: [B12]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,670421,670531);

f_22056_670421_670530(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,656538,670542);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,656538,670542);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,656538,670542);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ObjectCreationFlow_56()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,670554,688922);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,670709,671368);

string 
source = @"
using System.Collections;
using System.Collections.Generic;

class C1
{
    /*<bind>*/public static void M(C1 c, int? i1, int? i2, int? i3)
    {
        c = new C1 { [i1 ?? 0] = { GetInt(i2 ?? 1), { 3, GetInt(i3 ?? 4) } } };
    }/*</bind>*/
    C2 this[int i] { get => null; set { } }
    static int GetInt(int i) => i;
}

class C2 : IEnumerable<int>
{
    public IEnumerator<int> GetEnumerator() => throw null;
    IEnumerator IEnumerable.GetEnumerator() => throw null;
}

static class C2Extensions
{
    public static void Add(this C2 c2, int i) { }
    public static void Add(this C2 c2, int i, int j) { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,671382,671435);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,671451,688787);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [1]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (2)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c')
              Value: 
                IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: C1) (Syntax: 'c')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new C1 { [i ... ?? 4) } } }')
              Value: 
                IObjectCreationOperation (Constructor: C1..ctor()) (OperationKind.ObjectCreation, Type: C1) (Syntax: 'new C1 { [i ... ?? 4) } } }')
                  Arguments(0)
                  Initializer: 
                    null

        Next (Regular) Block[B2]
            Entering: {R2} {R3}

    .locals {R2}
    {
        CaptureIds: [3]
        .locals {R3}
        {
            CaptureIds: [2]
            Block[B2] - Block
                Predecessors: [B1]
                Statements (1)
                    IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i1')
                      Value: 
                        IParameterReferenceOperation: i1 (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'i1')

                Jump if True (Regular) to Block[B4]
                    IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'i1')
                      Operand: 
                        IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'i1')
                    Leaving: {R3}

                Next (Regular) Block[B3]
            Block[B3] - Block
                Predecessors: [B2]
                Statements (1)
                    IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i1')
                      Value: 
                        IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsImplicit) (Syntax: 'i1')
                          Instance Receiver: 
                            IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'i1')
                          Arguments(0)

                Next (Regular) Block[B5]
                    Leaving: {R3}
                    Entering: {R4}
        }

        Block[B4] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '0')
                  Value: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')

            Next (Regular) Block[B5]
                Entering: {R4}

        .locals {R4}
        {
            CaptureIds: [4] [6]
            Block[B5] - Block
                Predecessors: [B3] [B4]
                Statements (1)
                    IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '[i1 ?? 0]')
                      Value: 
                        IPropertyReferenceOperation: C2 C1.this[System.Int32 i] { get; set; } (OperationKind.PropertyReference, Type: C2) (Syntax: '[i1 ?? 0]')
                          Instance Receiver: 
                            IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { [i ... ?? 4) } } }')
                          Arguments(1):
                              IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: 'i1 ?? 0')
                                IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'i1 ?? 0')
                                InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

                Next (Regular) Block[B6]
                    Entering: {R5}

            .locals {R5}
            {
                CaptureIds: [5]
                Block[B6] - Block
                    Predecessors: [B5]
                    Statements (1)
                        IFlowCaptureOperation: 5 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i2')
                          Value: 
                            IParameterReferenceOperation: i2 (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'i2')

                    Jump if True (Regular) to Block[B8]
                        IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'i2')
                          Operand: 
                            IFlowCaptureReferenceOperation: 5 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'i2')
                        Leaving: {R5}

                    Next (Regular) Block[B7]
                Block[B7] - Block
                    Predecessors: [B6]
                    Statements (1)
                        IFlowCaptureOperation: 6 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i2')
                          Value: 
                            IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsImplicit) (Syntax: 'i2')
                              Instance Receiver: 
                                IFlowCaptureReferenceOperation: 5 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'i2')
                              Arguments(0)

                    Next (Regular) Block[B9]
                        Leaving: {R5}
            }

            Block[B8] - Block
                Predecessors: [B6]
                Statements (1)
                    IFlowCaptureOperation: 6 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '1')
                      Value: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

                Next (Regular) Block[B9]
            Block[B9] - Block
                Predecessors: [B7] [B8]
                Statements (1)
                    IInvocationOperation (void C2Extensions.Add(this C2 c2, System.Int32 i)) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'GetInt(i2 ?? 1)')
                      Instance Receiver: 
                        null
                      Arguments(2):
                          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: c2) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: '[i1 ?? 0]')
                            IFlowCaptureReferenceOperation: 4 (OperationKind.FlowCaptureReference, Type: C2, IsImplicit) (Syntax: '[i1 ?? 0]')
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'GetInt(i2 ?? 1)')
                            IInvocationOperation (System.Int32 C1.GetInt(System.Int32 i)) (OperationKind.Invocation, Type: System.Int32) (Syntax: 'GetInt(i2 ?? 1)')
                              Instance Receiver: 
                                null
                              Arguments(1):
                                  IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: 'i2 ?? 1')
                                    IFlowCaptureReferenceOperation: 6 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'i2 ?? 1')
                                    InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                    OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

                Next (Regular) Block[B10]
                    Leaving: {R4}
                    Entering: {R6}
        }
        .locals {R6}
        {
            CaptureIds: [7] [8] [10]
            Block[B10] - Block
                Predecessors: [B9]
                Statements (2)
                    IFlowCaptureOperation: 7 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '[i1 ?? 0]')
                      Value: 
                        IPropertyReferenceOperation: C2 C1.this[System.Int32 i] { get; set; } (OperationKind.PropertyReference, Type: C2) (Syntax: '[i1 ?? 0]')
                          Instance Receiver: 
                            IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { [i ... ?? 4) } } }')
                          Arguments(1):
                              IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: 'i1 ?? 0')
                                IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'i1 ?? 0')
                                InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

                    IFlowCaptureOperation: 8 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '3')
                      Value: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')

                Next (Regular) Block[B11]
                    Entering: {R7}

            .locals {R7}
            {
                CaptureIds: [9]
                Block[B11] - Block
                    Predecessors: [B10]
                    Statements (1)
                        IFlowCaptureOperation: 9 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i3')
                          Value: 
                            IParameterReferenceOperation: i3 (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'i3')

                    Jump if True (Regular) to Block[B13]
                        IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'i3')
                          Operand: 
                            IFlowCaptureReferenceOperation: 9 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'i3')
                        Leaving: {R7}

                    Next (Regular) Block[B12]
                Block[B12] - Block
                    Predecessors: [B11]
                    Statements (1)
                        IFlowCaptureOperation: 10 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i3')
                          Value: 
                            IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsImplicit) (Syntax: 'i3')
                              Instance Receiver: 
                                IFlowCaptureReferenceOperation: 9 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'i3')
                              Arguments(0)

                    Next (Regular) Block[B14]
                        Leaving: {R7}
            }

            Block[B13] - Block
                Predecessors: [B11]
                Statements (1)
                    IFlowCaptureOperation: 10 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '4')
                      Value: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 4) (Syntax: '4')

                Next (Regular) Block[B14]
            Block[B14] - Block
                Predecessors: [B12] [B13]
                Statements (1)
                    IInvocationOperation (void C2Extensions.Add(this C2 c2, System.Int32 i, System.Int32 j)) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: '{ 3, GetInt(i3 ?? 4) }')
                      Instance Receiver: 
                        null
                      Arguments(3):
                          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: c2) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: '[i1 ?? 0]')
                            IFlowCaptureReferenceOperation: 7 (OperationKind.FlowCaptureReference, Type: C2, IsImplicit) (Syntax: '[i1 ?? 0]')
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: '3')
                            IFlowCaptureReferenceOperation: 8 (OperationKind.FlowCaptureReference, Type: System.Int32, Constant: 3, IsImplicit) (Syntax: '3')
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: j) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'GetInt(i3 ?? 4)')
                            IInvocationOperation (System.Int32 C1.GetInt(System.Int32 i)) (OperationKind.Invocation, Type: System.Int32) (Syntax: 'GetInt(i3 ?? 4)')
                              Instance Receiver: 
                                null
                              Arguments(1):
                                  IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: 'i3 ?? 4')
                                    IFlowCaptureReferenceOperation: 10 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'i3 ?? 4')
                                    InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                    OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

                Next (Regular) Block[B15]
                    Leaving: {R6} {R2}
        }
    }

    Block[B15] - Block
        Predecessors: [B14]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'c = new C1  ... ? 4) } } };')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: C1) (Syntax: 'c = new C1  ... ?? 4) } } }')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'c')
                  Right: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { [i ... ?? 4) } } }')

        Next (Regular) Block[B16]
            Leaving: {R1}
}

Block[B16] - Exit
    Predecessors: [B15]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,688801,688911);

f_22056_688801_688910(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,670554,688922);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,670554,688922);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,670554,688922);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ObjectCreationFlow_57()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,688934,706762);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,689089,689648);

string 
source = @"
using System.Collections;
using System.Collections.Generic;

class C1
{
    /*<bind>*/public static void M(C1 c, int? i1, int? i2, int? i3)
    {
        c = new C1 { [i1 ?? 0] = { GetInt(i2 ?? 1), { 3, GetInt(i3 ?? 4) } } };
    }/*</bind>*/
    C2 this[int i] { get => null; set { } }
    static int GetInt(int i) => i;
}

class C2 : IEnumerable<int>
{
    public IEnumerator<int> GetEnumerator() => throw null;
    IEnumerator IEnumerable.GetEnumerator() => throw null;
    public void Add(int i, int j = -1) { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,689662,689715);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,689731,706627);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [1]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (2)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c')
              Value: 
                IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: C1) (Syntax: 'c')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new C1 { [i ... ?? 4) } } }')
              Value: 
                IObjectCreationOperation (Constructor: C1..ctor()) (OperationKind.ObjectCreation, Type: C1) (Syntax: 'new C1 { [i ... ?? 4) } } }')
                  Arguments(0)
                  Initializer: 
                    null

        Next (Regular) Block[B2]
            Entering: {R2} {R3}

    .locals {R2}
    {
        CaptureIds: [3]
        .locals {R3}
        {
            CaptureIds: [2]
            Block[B2] - Block
                Predecessors: [B1]
                Statements (1)
                    IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i1')
                      Value: 
                        IParameterReferenceOperation: i1 (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'i1')

                Jump if True (Regular) to Block[B4]
                    IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'i1')
                      Operand: 
                        IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'i1')
                    Leaving: {R3}

                Next (Regular) Block[B3]
            Block[B3] - Block
                Predecessors: [B2]
                Statements (1)
                    IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i1')
                      Value: 
                        IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsImplicit) (Syntax: 'i1')
                          Instance Receiver: 
                            IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'i1')
                          Arguments(0)

                Next (Regular) Block[B5]
                    Leaving: {R3}
                    Entering: {R4}
        }

        Block[B4] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '0')
                  Value: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')

            Next (Regular) Block[B5]
                Entering: {R4}

        .locals {R4}
        {
            CaptureIds: [4] [6]
            Block[B5] - Block
                Predecessors: [B3] [B4]
                Statements (1)
                    IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '[i1 ?? 0]')
                      Value: 
                        IPropertyReferenceOperation: C2 C1.this[System.Int32 i] { get; set; } (OperationKind.PropertyReference, Type: C2) (Syntax: '[i1 ?? 0]')
                          Instance Receiver: 
                            IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { [i ... ?? 4) } } }')
                          Arguments(1):
                              IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: 'i1 ?? 0')
                                IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'i1 ?? 0')
                                InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

                Next (Regular) Block[B6]
                    Entering: {R5}

            .locals {R5}
            {
                CaptureIds: [5]
                Block[B6] - Block
                    Predecessors: [B5]
                    Statements (1)
                        IFlowCaptureOperation: 5 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i2')
                          Value: 
                            IParameterReferenceOperation: i2 (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'i2')

                    Jump if True (Regular) to Block[B8]
                        IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'i2')
                          Operand: 
                            IFlowCaptureReferenceOperation: 5 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'i2')
                        Leaving: {R5}

                    Next (Regular) Block[B7]
                Block[B7] - Block
                    Predecessors: [B6]
                    Statements (1)
                        IFlowCaptureOperation: 6 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i2')
                          Value: 
                            IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsImplicit) (Syntax: 'i2')
                              Instance Receiver: 
                                IFlowCaptureReferenceOperation: 5 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'i2')
                              Arguments(0)

                    Next (Regular) Block[B9]
                        Leaving: {R5}
            }

            Block[B8] - Block
                Predecessors: [B6]
                Statements (1)
                    IFlowCaptureOperation: 6 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '1')
                      Value: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

                Next (Regular) Block[B9]
            Block[B9] - Block
                Predecessors: [B7] [B8]
                Statements (1)
                    IInvocationOperation ( void C2.Add(System.Int32 i, [System.Int32 j = -1])) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'GetInt(i2 ?? 1)')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 4 (OperationKind.FlowCaptureReference, Type: C2, IsImplicit) (Syntax: '[i1 ?? 0]')
                      Arguments(2):
                          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'GetInt(i2 ?? 1)')
                            IInvocationOperation (System.Int32 C1.GetInt(System.Int32 i)) (OperationKind.Invocation, Type: System.Int32) (Syntax: 'GetInt(i2 ?? 1)')
                              Instance Receiver: 
                                null
                              Arguments(1):
                                  IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: 'i2 ?? 1')
                                    IFlowCaptureReferenceOperation: 6 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'i2 ?? 1')
                                    InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                    OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                          IArgumentOperation (ArgumentKind.DefaultValue, Matching Parameter: j) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'GetInt(i2 ?? 1)')
                            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: -1, IsImplicit) (Syntax: 'GetInt(i2 ?? 1)')
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

                Next (Regular) Block[B10]
                    Leaving: {R4}
                    Entering: {R6}
        }
        .locals {R6}
        {
            CaptureIds: [7] [8] [10]
            Block[B10] - Block
                Predecessors: [B9]
                Statements (2)
                    IFlowCaptureOperation: 7 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '[i1 ?? 0]')
                      Value: 
                        IPropertyReferenceOperation: C2 C1.this[System.Int32 i] { get; set; } (OperationKind.PropertyReference, Type: C2) (Syntax: '[i1 ?? 0]')
                          Instance Receiver: 
                            IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { [i ... ?? 4) } } }')
                          Arguments(1):
                              IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: 'i1 ?? 0')
                                IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'i1 ?? 0')
                                InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

                    IFlowCaptureOperation: 8 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '3')
                      Value: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')

                Next (Regular) Block[B11]
                    Entering: {R7}

            .locals {R7}
            {
                CaptureIds: [9]
                Block[B11] - Block
                    Predecessors: [B10]
                    Statements (1)
                        IFlowCaptureOperation: 9 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i3')
                          Value: 
                            IParameterReferenceOperation: i3 (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'i3')

                    Jump if True (Regular) to Block[B13]
                        IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'i3')
                          Operand: 
                            IFlowCaptureReferenceOperation: 9 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'i3')
                        Leaving: {R7}

                    Next (Regular) Block[B12]
                Block[B12] - Block
                    Predecessors: [B11]
                    Statements (1)
                        IFlowCaptureOperation: 10 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i3')
                          Value: 
                            IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsImplicit) (Syntax: 'i3')
                              Instance Receiver: 
                                IFlowCaptureReferenceOperation: 9 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'i3')
                              Arguments(0)

                    Next (Regular) Block[B14]
                        Leaving: {R7}
            }

            Block[B13] - Block
                Predecessors: [B11]
                Statements (1)
                    IFlowCaptureOperation: 10 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '4')
                      Value: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 4) (Syntax: '4')

                Next (Regular) Block[B14]
            Block[B14] - Block
                Predecessors: [B12] [B13]
                Statements (1)
                    IInvocationOperation ( void C2.Add(System.Int32 i, [System.Int32 j = -1])) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: '{ 3, GetInt(i3 ?? 4) }')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 7 (OperationKind.FlowCaptureReference, Type: C2, IsImplicit) (Syntax: '[i1 ?? 0]')
                      Arguments(2):
                          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: '3')
                            IFlowCaptureReferenceOperation: 8 (OperationKind.FlowCaptureReference, Type: System.Int32, Constant: 3, IsImplicit) (Syntax: '3')
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: j) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'GetInt(i3 ?? 4)')
                            IInvocationOperation (System.Int32 C1.GetInt(System.Int32 i)) (OperationKind.Invocation, Type: System.Int32) (Syntax: 'GetInt(i3 ?? 4)')
                              Instance Receiver: 
                                null
                              Arguments(1):
                                  IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: 'i3 ?? 4')
                                    IFlowCaptureReferenceOperation: 10 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'i3 ?? 4')
                                    InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                    OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

                Next (Regular) Block[B15]
                    Leaving: {R6} {R2}
        }
    }

    Block[B15] - Block
        Predecessors: [B14]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'c = new C1  ... ? 4) } } };')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: C1) (Syntax: 'c = new C1  ... ?? 4) } } }')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'c')
                  Right: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { [i ... ?? 4) } } }')

        Next (Regular) Block[B16]
            Leaving: {R1}
}

Block[B16] - Exit
    Predecessors: [B15]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,706641,706751);

f_22056_706641_706750(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,688934,706762);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,688934,706762);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,688934,706762);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ObjectCreationFlow_58()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,706774,725499);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,706929,707487);

string 
source = @"
using System.Collections;
using System.Collections.Generic;

class C1
{
    /*<bind>*/public static void M(C1 c, int? i1, int? i2, int? i3)
    {
        c = new C1 { [i1 ?? 0] = { GetInt(i2 ?? 1), { 3, GetInt(i3 ?? 4) } } };
    }/*</bind>*/
    C2 this[int i] { get => null; set { } }
    static int GetInt(int i) => i;
}

class C2 : IEnumerable<int>
{
    public IEnumerator<int> GetEnumerator() => throw null;
    IEnumerator IEnumerable.GetEnumerator() => throw null;
    public void Add(params int[] @is) { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,707501,707554);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,707570,725364);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [1]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (2)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c')
              Value: 
                IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: C1) (Syntax: 'c')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new C1 { [i ... ?? 4) } } }')
              Value: 
                IObjectCreationOperation (Constructor: C1..ctor()) (OperationKind.ObjectCreation, Type: C1) (Syntax: 'new C1 { [i ... ?? 4) } } }')
                  Arguments(0)
                  Initializer: 
                    null

        Next (Regular) Block[B2]
            Entering: {R2} {R3}

    .locals {R2}
    {
        CaptureIds: [3]
        .locals {R3}
        {
            CaptureIds: [2]
            Block[B2] - Block
                Predecessors: [B1]
                Statements (1)
                    IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i1')
                      Value: 
                        IParameterReferenceOperation: i1 (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'i1')

                Jump if True (Regular) to Block[B4]
                    IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'i1')
                      Operand: 
                        IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'i1')
                    Leaving: {R3}

                Next (Regular) Block[B3]
            Block[B3] - Block
                Predecessors: [B2]
                Statements (1)
                    IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i1')
                      Value: 
                        IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsImplicit) (Syntax: 'i1')
                          Instance Receiver: 
                            IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'i1')
                          Arguments(0)

                Next (Regular) Block[B5]
                    Leaving: {R3}
                    Entering: {R4}
        }

        Block[B4] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '0')
                  Value: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')

            Next (Regular) Block[B5]
                Entering: {R4}

        .locals {R4}
        {
            CaptureIds: [4] [5] [7]
            Block[B5] - Block
                Predecessors: [B3] [B4]
                Statements (2)
                    IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '[i1 ?? 0]')
                      Value: 
                        IPropertyReferenceOperation: C2 C1.this[System.Int32 i] { get; set; } (OperationKind.PropertyReference, Type: C2) (Syntax: '[i1 ?? 0]')
                          Instance Receiver: 
                            IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { [i ... ?? 4) } } }')
                          Arguments(1):
                              IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: 'i1 ?? 0')
                                IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'i1 ?? 0')
                                InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

                    IFlowCaptureOperation: 5 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'GetInt(i2 ?? 1)')
                      Value: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1, IsImplicit) (Syntax: 'GetInt(i2 ?? 1)')

                Next (Regular) Block[B6]
                    Entering: {R5}

            .locals {R5}
            {
                CaptureIds: [6]
                Block[B6] - Block
                    Predecessors: [B5]
                    Statements (1)
                        IFlowCaptureOperation: 6 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i2')
                          Value: 
                            IParameterReferenceOperation: i2 (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'i2')

                    Jump if True (Regular) to Block[B8]
                        IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'i2')
                          Operand: 
                            IFlowCaptureReferenceOperation: 6 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'i2')
                        Leaving: {R5}

                    Next (Regular) Block[B7]
                Block[B7] - Block
                    Predecessors: [B6]
                    Statements (1)
                        IFlowCaptureOperation: 7 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i2')
                          Value: 
                            IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsImplicit) (Syntax: 'i2')
                              Instance Receiver: 
                                IFlowCaptureReferenceOperation: 6 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'i2')
                              Arguments(0)

                    Next (Regular) Block[B9]
                        Leaving: {R5}
            }

            Block[B8] - Block
                Predecessors: [B6]
                Statements (1)
                    IFlowCaptureOperation: 7 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '1')
                      Value: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

                Next (Regular) Block[B9]
            Block[B9] - Block
                Predecessors: [B7] [B8]
                Statements (1)
                    IInvocationOperation ( void C2.Add(params System.Int32[] @is)) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'GetInt(i2 ?? 1)')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 4 (OperationKind.FlowCaptureReference, Type: C2, IsImplicit) (Syntax: '[i1 ?? 0]')
                      Arguments(1):
                          IArgumentOperation (ArgumentKind.ParamArray, Matching Parameter: is) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'GetInt(i2 ?? 1)')
                            IArrayCreationOperation (OperationKind.ArrayCreation, Type: System.Int32[], IsImplicit) (Syntax: 'GetInt(i2 ?? 1)')
                              Dimension Sizes(1):
                                  IFlowCaptureReferenceOperation: 5 (OperationKind.FlowCaptureReference, Type: System.Int32, Constant: 1, IsImplicit) (Syntax: 'GetInt(i2 ?? 1)')
                              Initializer: 
                                IArrayInitializerOperation (1 elements) (OperationKind.ArrayInitializer, Type: null, IsImplicit) (Syntax: 'GetInt(i2 ?? 1)')
                                  Element Values(1):
                                      IInvocationOperation (System.Int32 C1.GetInt(System.Int32 i)) (OperationKind.Invocation, Type: System.Int32) (Syntax: 'GetInt(i2 ?? 1)')
                                        Instance Receiver: 
                                          null
                                        Arguments(1):
                                            IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: 'i2 ?? 1')
                                              IFlowCaptureReferenceOperation: 7 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'i2 ?? 1')
                                              InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                              OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

                Next (Regular) Block[B10]
                    Leaving: {R4}
                    Entering: {R6}
        }
        .locals {R6}
        {
            CaptureIds: [8] [9] [10] [12]
            Block[B10] - Block
                Predecessors: [B9]
                Statements (3)
                    IFlowCaptureOperation: 8 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '[i1 ?? 0]')
                      Value: 
                        IPropertyReferenceOperation: C2 C1.this[System.Int32 i] { get; set; } (OperationKind.PropertyReference, Type: C2) (Syntax: '[i1 ?? 0]')
                          Instance Receiver: 
                            IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { [i ... ?? 4) } } }')
                          Arguments(1):
                              IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: 'i1 ?? 0')
                                IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'i1 ?? 0')
                                InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

                    IFlowCaptureOperation: 9 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '{ 3, GetInt(i3 ?? 4) }')
                      Value: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2, IsImplicit) (Syntax: '{ 3, GetInt(i3 ?? 4) }')

                    IFlowCaptureOperation: 10 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '3')
                      Value: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')

                Next (Regular) Block[B11]
                    Entering: {R7}

            .locals {R7}
            {
                CaptureIds: [11]
                Block[B11] - Block
                    Predecessors: [B10]
                    Statements (1)
                        IFlowCaptureOperation: 11 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i3')
                          Value: 
                            IParameterReferenceOperation: i3 (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'i3')

                    Jump if True (Regular) to Block[B13]
                        IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'i3')
                          Operand: 
                            IFlowCaptureReferenceOperation: 11 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'i3')
                        Leaving: {R7}

                    Next (Regular) Block[B12]
                Block[B12] - Block
                    Predecessors: [B11]
                    Statements (1)
                        IFlowCaptureOperation: 12 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i3')
                          Value: 
                            IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsImplicit) (Syntax: 'i3')
                              Instance Receiver: 
                                IFlowCaptureReferenceOperation: 11 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'i3')
                              Arguments(0)

                    Next (Regular) Block[B14]
                        Leaving: {R7}
            }

            Block[B13] - Block
                Predecessors: [B11]
                Statements (1)
                    IFlowCaptureOperation: 12 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '4')
                      Value: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 4) (Syntax: '4')

                Next (Regular) Block[B14]
            Block[B14] - Block
                Predecessors: [B12] [B13]
                Statements (1)
                    IInvocationOperation ( void C2.Add(params System.Int32[] @is)) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: '{ 3, GetInt(i3 ?? 4) }')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 8 (OperationKind.FlowCaptureReference, Type: C2, IsImplicit) (Syntax: '[i1 ?? 0]')
                      Arguments(1):
                          IArgumentOperation (ArgumentKind.ParamArray, Matching Parameter: is) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: '{ 3, GetInt(i3 ?? 4) }')
                            IArrayCreationOperation (OperationKind.ArrayCreation, Type: System.Int32[], IsImplicit) (Syntax: '{ 3, GetInt(i3 ?? 4) }')
                              Dimension Sizes(1):
                                  IFlowCaptureReferenceOperation: 9 (OperationKind.FlowCaptureReference, Type: System.Int32, Constant: 2, IsImplicit) (Syntax: '{ 3, GetInt(i3 ?? 4) }')
                              Initializer: 
                                IArrayInitializerOperation (2 elements) (OperationKind.ArrayInitializer, Type: null, IsImplicit) (Syntax: '{ 3, GetInt(i3 ?? 4) }')
                                  Element Values(2):
                                      IFlowCaptureReferenceOperation: 10 (OperationKind.FlowCaptureReference, Type: System.Int32, Constant: 3, IsImplicit) (Syntax: '3')
                                      IInvocationOperation (System.Int32 C1.GetInt(System.Int32 i)) (OperationKind.Invocation, Type: System.Int32) (Syntax: 'GetInt(i3 ?? 4)')
                                        Instance Receiver: 
                                          null
                                        Arguments(1):
                                            IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: 'i3 ?? 4')
                                              IFlowCaptureReferenceOperation: 12 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'i3 ?? 4')
                                              InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                              OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

                Next (Regular) Block[B15]
                    Leaving: {R6} {R2}
        }
    }

    Block[B15] - Block
        Predecessors: [B14]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'c = new C1  ... ? 4) } } };')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: C1) (Syntax: 'c = new C1  ... ?? 4) } } }')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'c')
                  Right: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { [i ... ?? 4) } } }')

        Next (Regular) Block[B16]
            Leaving: {R1}
}

Block[B16] - Exit
    Predecessors: [B15]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,725378,725488);

f_22056_725378_725487(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,706774,725499);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,706774,725499);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,706774,725499);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ObjectCreationFlow_59()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,725511,740764);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,725666,726285);

string 
source = @"
using System.Collections;
using System.Collections.Generic;

class C1 : IEnumerable<C2>
{
    /*<bind>*/public static void M(C1 c, int? i1, int? i2)
    {
        c = new C1 { new C2() { i1 ?? 1, 2 }, new C2() { 3, i2 ?? 4 } };
    }/*</bind>*/
    public IEnumerator<C2> GetEnumerator() => throw null;
    IEnumerator IEnumerable.GetEnumerator() => throw null;
    public void Add(C2 c2) { }
}

class C2 : IEnumerable<int>
{
    public IEnumerator<int> GetEnumerator() => throw null;
    IEnumerator IEnumerable.GetEnumerator() => throw null;
    public void Add(int i) { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,726299,726352);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,726368,740629);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [1]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (2)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c')
              Value: 
                IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: C1) (Syntax: 'c')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new C1 { ne ... i2 ?? 4 } }')
              Value: 
                IObjectCreationOperation (Constructor: C1..ctor()) (OperationKind.ObjectCreation, Type: C1) (Syntax: 'new C1 { ne ... i2 ?? 4 } }')
                  Arguments(0)
                  Initializer: 
                    null

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new C2() { i1 ?? 1, 2 }')
                  Value: 
                    IObjectCreationOperation (Constructor: C2..ctor()) (OperationKind.ObjectCreation, Type: C2) (Syntax: 'new C2() { i1 ?? 1, 2 }')
                      Arguments(0)
                      Initializer: 
                        null

            Next (Regular) Block[B3]
                Entering: {R3} {R4}

        .locals {R3}
        {
            CaptureIds: [4]
            .locals {R4}
            {
                CaptureIds: [3]
                Block[B3] - Block
                    Predecessors: [B2]
                    Statements (1)
                        IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i1')
                          Value: 
                            IParameterReferenceOperation: i1 (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'i1')

                    Jump if True (Regular) to Block[B5]
                        IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'i1')
                          Operand: 
                            IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'i1')
                        Leaving: {R4}

                    Next (Regular) Block[B4]
                Block[B4] - Block
                    Predecessors: [B3]
                    Statements (1)
                        IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i1')
                          Value: 
                            IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsImplicit) (Syntax: 'i1')
                              Instance Receiver: 
                                IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'i1')
                              Arguments(0)

                    Next (Regular) Block[B6]
                        Leaving: {R4}
            }

            Block[B5] - Block
                Predecessors: [B3]
                Statements (1)
                    IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '1')
                      Value: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

                Next (Regular) Block[B6]
            Block[B6] - Block
                Predecessors: [B4] [B5]
                Statements (1)
                    IInvocationOperation ( void C2.Add(System.Int32 i)) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'i1 ?? 1')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: C2, IsImplicit) (Syntax: 'new C2() { i1 ?? 1, 2 }')
                      Arguments(1):
                          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'i1 ?? 1')
                            IFlowCaptureReferenceOperation: 4 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'i1 ?? 1')
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

                Next (Regular) Block[B7]
                    Leaving: {R3}
        }

        Block[B7] - Block
            Predecessors: [B6]
            Statements (2)
                IInvocationOperation ( void C2.Add(System.Int32 i)) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: '2')
                  Instance Receiver: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: C2, IsImplicit) (Syntax: 'new C2() { i1 ?? 1, 2 }')
                  Arguments(1):
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: '2')
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

                IInvocationOperation ( void C1.Add(C2 c2)) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'new C2() { i1 ?? 1, 2 }')
                  Instance Receiver: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { ne ... i2 ?? 4 } }')
                  Arguments(1):
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: c2) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'new C2() { i1 ?? 1, 2 }')
                        IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: C2, IsImplicit) (Syntax: 'new C2() { i1 ?? 1, 2 }')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

            Next (Regular) Block[B8]
                Leaving: {R2}
                Entering: {R5}
    }
    .locals {R5}
    {
        CaptureIds: [5]
        Block[B8] - Block
            Predecessors: [B7]
            Statements (2)
                IFlowCaptureOperation: 5 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new C2() { 3, i2 ?? 4 }')
                  Value: 
                    IObjectCreationOperation (Constructor: C2..ctor()) (OperationKind.ObjectCreation, Type: C2) (Syntax: 'new C2() { 3, i2 ?? 4 }')
                      Arguments(0)
                      Initializer: 
                        null

                IInvocationOperation ( void C2.Add(System.Int32 i)) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: '3')
                  Instance Receiver: 
                    IFlowCaptureReferenceOperation: 5 (OperationKind.FlowCaptureReference, Type: C2, IsImplicit) (Syntax: 'new C2() { 3, i2 ?? 4 }')
                  Arguments(1):
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: '3')
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

            Next (Regular) Block[B9]
                Entering: {R6} {R7}

        .locals {R6}
        {
            CaptureIds: [7]
            .locals {R7}
            {
                CaptureIds: [6]
                Block[B9] - Block
                    Predecessors: [B8]
                    Statements (1)
                        IFlowCaptureOperation: 6 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i2')
                          Value: 
                            IParameterReferenceOperation: i2 (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'i2')

                    Jump if True (Regular) to Block[B11]
                        IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'i2')
                          Operand: 
                            IFlowCaptureReferenceOperation: 6 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'i2')
                        Leaving: {R7}

                    Next (Regular) Block[B10]
                Block[B10] - Block
                    Predecessors: [B9]
                    Statements (1)
                        IFlowCaptureOperation: 7 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i2')
                          Value: 
                            IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsImplicit) (Syntax: 'i2')
                              Instance Receiver: 
                                IFlowCaptureReferenceOperation: 6 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'i2')
                              Arguments(0)

                    Next (Regular) Block[B12]
                        Leaving: {R7}
            }

            Block[B11] - Block
                Predecessors: [B9]
                Statements (1)
                    IFlowCaptureOperation: 7 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '4')
                      Value: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 4) (Syntax: '4')

                Next (Regular) Block[B12]
            Block[B12] - Block
                Predecessors: [B10] [B11]
                Statements (1)
                    IInvocationOperation ( void C2.Add(System.Int32 i)) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'i2 ?? 4')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 5 (OperationKind.FlowCaptureReference, Type: C2, IsImplicit) (Syntax: 'new C2() { 3, i2 ?? 4 }')
                      Arguments(1):
                          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'i2 ?? 4')
                            IFlowCaptureReferenceOperation: 7 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'i2 ?? 4')
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

                Next (Regular) Block[B13]
                    Leaving: {R6}
        }

        Block[B13] - Block
            Predecessors: [B12]
            Statements (1)
                IInvocationOperation ( void C1.Add(C2 c2)) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'new C2() { 3, i2 ?? 4 }')
                  Instance Receiver: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { ne ... i2 ?? 4 } }')
                  Arguments(1):
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: c2) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'new C2() { 3, i2 ?? 4 }')
                        IFlowCaptureReferenceOperation: 5 (OperationKind.FlowCaptureReference, Type: C2, IsImplicit) (Syntax: 'new C2() { 3, i2 ?? 4 }')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

            Next (Regular) Block[B14]
                Leaving: {R5}
    }

    Block[B14] - Block
        Predecessors: [B13]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'c = new C1  ... 2 ?? 4 } };')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: C1) (Syntax: 'c = new C1  ... i2 ?? 4 } }')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'c')
                  Right: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { ne ... i2 ?? 4 } }')

        Next (Regular) Block[B15]
            Leaving: {R1}
}

Block[B15] - Exit
    Predecessors: [B14]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,740643,740753);

f_22056_740643_740752(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,725511,740764);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,725511,740764);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,725511,740764);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ObjectCreationFlow_60()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,740776,744641);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,740931,741328);

string 
source = @"
using System.Collections;
using System.Collections.Generic;

class C1 : IEnumerable<int>
{
    /*<bind>*/public static void M(C1 c, dynamic d1, dynamic d2)
    {
        c = new C1 { d1, d2 };
    }/*</bind>*/
    public IEnumerator<int> GetEnumerator() => throw null;
    IEnumerator IEnumerable.GetEnumerator() => throw null;
    public void Add(int c2) { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,741342,741395);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,741411,744506);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [1]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (5)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c')
              Value: 
                IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: C1) (Syntax: 'c')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new C1 { d1, d2 }')
              Value: 
                IObjectCreationOperation (Constructor: C1..ctor()) (OperationKind.ObjectCreation, Type: C1) (Syntax: 'new C1 { d1, d2 }')
                  Arguments(0)
                  Initializer: 
                    null

            IDynamicInvocationOperation (OperationKind.DynamicInvocation, Type: dynamic, IsImplicit) (Syntax: 'd1')
              Expression: 
                IDynamicMemberReferenceOperation (Member Name: ""Add"", Containing Type: null) (OperationKind.DynamicMemberReference, Type: null, IsImplicit) (Syntax: 'C1')
                  Type Arguments(0)
                  Instance Receiver: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { d1, d2 }')
              Arguments(1):
                  IParameterReferenceOperation: d1 (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'd1')
              ArgumentNames(0)
              ArgumentRefKinds(0)

            IDynamicInvocationOperation (OperationKind.DynamicInvocation, Type: dynamic, IsImplicit) (Syntax: 'd2')
              Expression: 
                IDynamicMemberReferenceOperation (Member Name: ""Add"", Containing Type: null) (OperationKind.DynamicMemberReference, Type: null, IsImplicit) (Syntax: 'C1')
                  Type Arguments(0)
                  Instance Receiver: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { d1, d2 }')
              Arguments(1):
                  IParameterReferenceOperation: d2 (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'd2')
              ArgumentNames(0)
              ArgumentRefKinds(0)

            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'c = new C1 { d1, d2 };')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: C1) (Syntax: 'c = new C1 { d1, d2 }')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'c')
                  Right: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { d1, d2 }')

        Next (Regular) Block[B2]
            Leaving: {R1}
}

Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,744520,744630);

f_22056_744520_744629(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,740776,744641);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,740776,744641);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,740776,744641);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ObjectCreationFlow_61()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,744653,750101);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,744808,745234);

string 
source = @"
using System.Collections;
using System.Collections.Generic;

class C1 : IEnumerable<int>
{
    /*<bind>*/public static void M(C1 c, bool b, dynamic d1, dynamic d2, dynamic d3)
    {
        c = new C1 { d1, b ? d2 : d3 };
    }/*</bind>*/
    public IEnumerator<int> GetEnumerator() => throw null;
    IEnumerator IEnumerable.GetEnumerator() => throw null;
    public void Add(int c2) { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,745248,745301);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,745317,749966);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [1]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (3)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c')
              Value: 
                IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: C1) (Syntax: 'c')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new C1 { d1 ... ? d2 : d3 }')
              Value: 
                IObjectCreationOperation (Constructor: C1..ctor()) (OperationKind.ObjectCreation, Type: C1) (Syntax: 'new C1 { d1 ... ? d2 : d3 }')
                  Arguments(0)
                  Initializer: 
                    null

            IDynamicInvocationOperation (OperationKind.DynamicInvocation, Type: dynamic, IsImplicit) (Syntax: 'd1')
              Expression: 
                IDynamicMemberReferenceOperation (Member Name: ""Add"", Containing Type: null) (OperationKind.DynamicMemberReference, Type: null, IsImplicit) (Syntax: 'C1')
                  Type Arguments(0)
                  Instance Receiver: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { d1 ... ? d2 : d3 }')
              Arguments(1):
                  IParameterReferenceOperation: d1 (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'd1')
              ArgumentNames(0)
              ArgumentRefKinds(0)

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (0)
            Jump if False (Regular) to Block[B4]
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'd2')
                  Value: 
                    IParameterReferenceOperation: d2 (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'd2')

            Next (Regular) Block[B5]
        Block[B4] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'd3')
                  Value: 
                    IParameterReferenceOperation: d3 (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'd3')

            Next (Regular) Block[B5]
        Block[B5] - Block
            Predecessors: [B3] [B4]
            Statements (1)
                IDynamicInvocationOperation (OperationKind.DynamicInvocation, Type: dynamic, IsImplicit) (Syntax: 'b ? d2 : d3')
                  Expression: 
                    IDynamicMemberReferenceOperation (Member Name: ""Add"", Containing Type: null) (OperationKind.DynamicMemberReference, Type: null, IsImplicit) (Syntax: 'C1')
                      Type Arguments(0)
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { d1 ... ? d2 : d3 }')
                  Arguments(1):
                      IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'b ? d2 : d3')
                  ArgumentNames(0)
                  ArgumentRefKinds(0)

            Next (Regular) Block[B6]
                Leaving: {R2}
    }

    Block[B6] - Block
        Predecessors: [B5]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'c = new C1  ...  d2 : d3 };')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: C1) (Syntax: 'c = new C1  ... ? d2 : d3 }')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'c')
                  Right: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { d1 ... ? d2 : d3 }')

        Next (Regular) Block[B7]
            Leaving: {R1}
}

Block[B7] - Exit
    Predecessors: [B6]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,749980,750090);

f_22056_749980_750089(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,744653,750101);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,744653,750101);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,744653,750101);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ObjectCreationFlow_62()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,750113,759307);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,750268,750808);

string 
source = @"
using System.Collections;
using System.Collections.Generic;

class C1
{
    /*<bind>*/public static void M(C1 c, bool b, dynamic d1, dynamic d2, dynamic d3)
    {
        c = new C1 { [GetInt(0)] = { d1, b ? d2 : d3 } };
    }/*</bind>*/
    static int GetInt(int i) => i;
    public C2 this[int i] { get => null; }
}
class C2 : IEnumerable<int>
{
    public IEnumerator<int> GetEnumerator() => throw null;
    IEnumerator IEnumerable.GetEnumerator() => throw null;
    public void Add(int c2) { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,750822,750875);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,750891,759136);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [1]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (2)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c')
              Value: 
                IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: C1) (Syntax: 'c')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new C1 { [G ... d2 : d3 } }')
              Value: 
                IObjectCreationOperation (Constructor: C1..ctor()) (OperationKind.ObjectCreation, Type: C1) (Syntax: 'new C1 { [G ... d2 : d3 } }')
                  Arguments(0)
                  Initializer: 
                    null

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (2)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'GetInt(0)')
                  Value: 
                    IInvocationOperation (System.Int32 C1.GetInt(System.Int32 i)) (OperationKind.Invocation, Type: System.Int32) (Syntax: 'GetInt(0)')
                      Instance Receiver: 
                        null
                      Arguments(1):
                          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: '0')
                            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

                IDynamicInvocationOperation (OperationKind.DynamicInvocation, Type: dynamic, IsImplicit) (Syntax: 'd1')
                  Expression: 
                    IDynamicMemberReferenceOperation (Member Name: ""Add"", Containing Type: null) (OperationKind.DynamicMemberReference, Type: null, IsImplicit) (Syntax: '[GetInt(0)]')
                      Type Arguments(0)
                      Instance Receiver: 
                        IPropertyReferenceOperation: C2 C1.this[System.Int32 i] { get; } (OperationKind.PropertyReference, Type: C2) (Syntax: '[GetInt(0)]')
                          Instance Receiver: 
                            IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { [G ... d2 : d3 } }')
                          Arguments(1):
                              IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: 'GetInt(0)')
                                IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'GetInt(0)')
                                InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  Arguments(1):
                      IParameterReferenceOperation: d1 (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'd1')
                  ArgumentNames(0)
                  ArgumentRefKinds(0)

            Next (Regular) Block[B3]
                Entering: {R3}

        .locals {R3}
        {
            CaptureIds: [3] [4]
            Block[B3] - Block
                Predecessors: [B2]
                Statements (1)
                    IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '[GetInt(0)]')
                      Value: 
                        IPropertyReferenceOperation: C2 C1.this[System.Int32 i] { get; } (OperationKind.PropertyReference, Type: C2) (Syntax: '[GetInt(0)]')
                          Instance Receiver: 
                            IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { [G ... d2 : d3 } }')
                          Arguments(1):
                              IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: 'GetInt(0)')
                                IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'GetInt(0)')
                                InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

                Jump if False (Regular) to Block[B5]
                    IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

                Next (Regular) Block[B4]
            Block[B4] - Block
                Predecessors: [B3]
                Statements (1)
                    IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'd2')
                      Value: 
                        IParameterReferenceOperation: d2 (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'd2')

                Next (Regular) Block[B6]
            Block[B5] - Block
                Predecessors: [B3]
                Statements (1)
                    IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'd3')
                      Value: 
                        IParameterReferenceOperation: d3 (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'd3')

                Next (Regular) Block[B6]
            Block[B6] - Block
                Predecessors: [B4] [B5]
                Statements (1)
                    IDynamicInvocationOperation (OperationKind.DynamicInvocation, Type: dynamic, IsImplicit) (Syntax: 'b ? d2 : d3')
                      Expression: 
                        IDynamicMemberReferenceOperation (Member Name: ""Add"", Containing Type: null) (OperationKind.DynamicMemberReference, Type: null, IsImplicit) (Syntax: '[GetInt(0)]')
                          Type Arguments(0)
                          Instance Receiver: 
                            IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: C2, IsImplicit) (Syntax: '[GetInt(0)]')
                      Arguments(1):
                          IFlowCaptureReferenceOperation: 4 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'b ? d2 : d3')
                      ArgumentNames(0)
                      ArgumentRefKinds(0)

                Next (Regular) Block[B7]
                    Leaving: {R3} {R2}
        }
    }

    Block[B7] - Block
        Predecessors: [B6]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'c = new C1  ... 2 : d3 } };')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: C1) (Syntax: 'c = new C1  ... d2 : d3 } }')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'c')
                  Right: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { [G ... d2 : d3 } }')

        Next (Regular) Block[B8]
            Leaving: {R1}
}

Block[B8] - Exit
    Predecessors: [B7]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,759150,759296);

f_22056_759150_759295(source, expectedFlowGraph, expectedDiagnostics, useLatestFrameworkReferences: true);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,750113,759307);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,750113,759307);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,750113,759307);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ObjectCreationFlow_63()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,759319,769713);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,759474,760036);

string 
source = @"
using System.Collections;
using System.Collections.Generic;

class C1
{
    /*<bind>*/public static void M(C1 c, bool b, dynamic d1, dynamic d2, dynamic d3)
    {
        c = new C1 { [GetInt(0)] = { { 1, 2 }, { d1, b ? d2 : d3 } } };
    }/*</bind>*/
    static int GetInt(int i) => i;
    public C2 this[int i] { get => null; }
}
class C2 : IEnumerable<int>
{
    public IEnumerator<int> GetEnumerator() => throw null;
    IEnumerator IEnumerable.GetEnumerator() => throw null;
    public void Add(int c1, int c2) { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,760050,760103);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,760119,769542);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [1]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (2)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c')
              Value: 
                IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: C1) (Syntax: 'c')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new C1 { [G ...  : d3 } } }')
              Value: 
                IObjectCreationOperation (Constructor: C1..ctor()) (OperationKind.ObjectCreation, Type: C1) (Syntax: 'new C1 { [G ...  : d3 } } }')
                  Arguments(0)
                  Initializer: 
                    null

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (2)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'GetInt(0)')
                  Value: 
                    IInvocationOperation (System.Int32 C1.GetInt(System.Int32 i)) (OperationKind.Invocation, Type: System.Int32) (Syntax: 'GetInt(0)')
                      Instance Receiver: 
                        null
                      Arguments(1):
                          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: '0')
                            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

                IInvocationOperation ( void C2.Add(System.Int32 c1, System.Int32 c2)) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: '{ 1, 2 }')
                  Instance Receiver: 
                    IPropertyReferenceOperation: C2 C1.this[System.Int32 i] { get; } (OperationKind.PropertyReference, Type: C2) (Syntax: '[GetInt(0)]')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { [G ...  : d3 } } }')
                      Arguments(1):
                          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: 'GetInt(0)')
                            IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'GetInt(0)')
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  Arguments(2):
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: c1) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: '1')
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: c2) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: '2')
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

            Next (Regular) Block[B3]
                Entering: {R3}

        .locals {R3}
        {
            CaptureIds: [3] [4] [5]
            Block[B3] - Block
                Predecessors: [B2]
                Statements (2)
                    IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '[GetInt(0)]')
                      Value: 
                        IPropertyReferenceOperation: C2 C1.this[System.Int32 i] { get; } (OperationKind.PropertyReference, Type: C2) (Syntax: '[GetInt(0)]')
                          Instance Receiver: 
                            IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { [G ...  : d3 } } }')
                          Arguments(1):
                              IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: 'GetInt(0)')
                                IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'GetInt(0)')
                                InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

                    IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'd1')
                      Value: 
                        IParameterReferenceOperation: d1 (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'd1')

                Jump if False (Regular) to Block[B5]
                    IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

                Next (Regular) Block[B4]
            Block[B4] - Block
                Predecessors: [B3]
                Statements (1)
                    IFlowCaptureOperation: 5 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'd2')
                      Value: 
                        IParameterReferenceOperation: d2 (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'd2')

                Next (Regular) Block[B6]
            Block[B5] - Block
                Predecessors: [B3]
                Statements (1)
                    IFlowCaptureOperation: 5 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'd3')
                      Value: 
                        IParameterReferenceOperation: d3 (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'd3')

                Next (Regular) Block[B6]
            Block[B6] - Block
                Predecessors: [B4] [B5]
                Statements (1)
                    IDynamicInvocationOperation (OperationKind.DynamicInvocation, Type: dynamic) (Syntax: '{ d1, b ? d2 : d3 }')
                      Expression: 
                        IDynamicMemberReferenceOperation (Member Name: ""Add"", Containing Type: null) (OperationKind.DynamicMemberReference, Type: null, IsImplicit) (Syntax: '[GetInt(0)]')
                          Type Arguments(0)
                          Instance Receiver: 
                            IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: C2, IsImplicit) (Syntax: '[GetInt(0)]')
                      Arguments(2):
                          IFlowCaptureReferenceOperation: 4 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'd1')
                          IFlowCaptureReferenceOperation: 5 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'b ? d2 : d3')
                      ArgumentNames(0)
                      ArgumentRefKinds(0)

                Next (Regular) Block[B7]
                    Leaving: {R3} {R2}
        }
    }

    Block[B7] - Block
        Predecessors: [B6]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'c = new C1  ... : d3 } } };')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: C1) (Syntax: 'c = new C1  ...  : d3 } } }')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'c')
                  Right: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1 { [G ...  : d3 } } }')

        Next (Regular) Block[B8]
            Leaving: {R1}
}

Block[B8] - Exit
    Predecessors: [B7]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,769556,769702);

f_22056_769556_769701(source, expectedFlowGraph, expectedDiagnostics, useLatestFrameworkReferences: true);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,759319,769713);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,759319,769713);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,759319,769713);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ObjectCreationFlow_64()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,769725,773292);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,769880,770276);

string 
source = @"
using System.Collections;
using System.Collections.Generic;

class C1 : IEnumerable<int>
{
    C1(int x){}

    /*<bind>*/public static void M(C1 c, int i1)
    {
        c = new C1 { i1 };
    }/*</bind>*/
    public IEnumerator<int> GetEnumerator() => throw null;
    IEnumerator IEnumerable.GetEnumerator() => throw null;
    public void Add(int c2) { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,770290,770660);

var 
expectedDiagnostics = new[] {
f_22056_770535_770644(f_22056_770535_770623(f_22056_770535_770590(ErrorCode.ERR_NoCorrespondingArgument, "C1"), "x", "C1.C1(int)"), 11, 17)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,770676,773157);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [1]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (4)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c')
              Value: 
                IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: C1) (Syntax: 'c')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'new C1 { i1 }')
              Value: 
                IInvalidOperation (OperationKind.Invalid, Type: C1, IsInvalid) (Syntax: 'new C1 { i1 }')
                  Children(0)

            IInvocationOperation ( void C1.Add(System.Int32 c2)) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'i1')
              Instance Receiver: 
                IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C1, IsInvalid, IsImplicit) (Syntax: 'new C1 { i1 }')
              Arguments(1):
                  IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: c2) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'i1')
                    IParameterReferenceOperation: i1 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i1')
                    InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: 'c = new C1 { i1 };')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: C1, IsInvalid) (Syntax: 'c = new C1 { i1 }')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'c')
                  Right: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C1, IsInvalid, IsImplicit) (Syntax: 'new C1 { i1 }')

        Next (Regular) Block[B2]
            Leaving: {R1}
}

Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,773171,773281);

f_22056_773171_773280(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,769725,773292);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,769725,773292);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,769725,773292);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ObjectCreationFlow_65()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,773304,776483);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,773459,773701);

string 
source = @"
using System.Collections;
using System.Collections.Generic;

class C1
{
    /*<bind>*/public static void M(C1 c, int i1, int i2)
    {
        c = new C1(i1) { F = i2 };
    }/*</bind>*/

    public int F;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,773715,774037);

var 
expectedDiagnostics = new[] {
f_22056_773929_774021(f_22056_773929_774001(f_22056_773929_773976(ErrorCode.ERR_BadCtorArgCount, "C1"), "C1", "1"), 9, 17)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,774053,776348);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [1]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (4)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c')
              Value: 
                IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: C1) (Syntax: 'c')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'new C1(i1) { F = i2 }')
              Value: 
                IInvalidOperation (OperationKind.Invalid, Type: C1, IsInvalid) (Syntax: 'new C1(i1) { F = i2 }')
                  Children(1):
                      IParameterReferenceOperation: i1 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i1')

            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'F = i2')
              Left: 
                IFieldReferenceOperation: System.Int32 C1.F (OperationKind.FieldReference, Type: System.Int32) (Syntax: 'F')
                  Instance Receiver: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C1, IsInvalid, IsImplicit) (Syntax: 'new C1(i1) { F = i2 }')
              Right: 
                IParameterReferenceOperation: i2 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i2')

            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: 'c = new C1( ... { F = i2 };')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: C1, IsInvalid) (Syntax: 'c = new C1( ...  { F = i2 }')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'c')
                  Right: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C1, IsInvalid, IsImplicit) (Syntax: 'new C1(i1) { F = i2 }')

        Next (Regular) Block[B2]
            Leaving: {R1}
}

Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,776362,776472);

f_22056_776362_776471(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,773304,776483);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,773304,776483);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,773304,776483);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ObjectCreationFlow_66()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,776495,782370);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,776650,776916);

string 
source = @"
using System.Collections;
using System.Collections.Generic;

class C1
{
    /*<bind>*/public static void M(C1 c, int i1, int i2, C1 c1, C1 c2)
    {
        c = new C1(i1, c1 ?? c2) { F = i2 };
    }/*</bind>*/

    public int F;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,776930,777262);

var 
expectedDiagnostics = new[] {
f_22056_777154_777246(f_22056_777154_777226(f_22056_777154_777201(ErrorCode.ERR_BadCtorArgCount, "C1"), "C1", "2"), 9, 17)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,777278,782235);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [4]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c')
              Value: 
                IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: C1) (Syntax: 'c')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1] [3]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i1')
                  Value: 
                    IParameterReferenceOperation: i1 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i1')

            Next (Regular) Block[B3]
                Entering: {R3}

        .locals {R3}
        {
            CaptureIds: [2]
            Block[B3] - Block
                Predecessors: [B2]
                Statements (1)
                    IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c1')
                      Value: 
                        IParameterReferenceOperation: c1 (OperationKind.ParameterReference, Type: C1) (Syntax: 'c1')

                Jump if True (Regular) to Block[B5]
                    IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'c1')
                      Operand: 
                        IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'c1')
                    Leaving: {R3}

                Next (Regular) Block[B4]
            Block[B4] - Block
                Predecessors: [B3]
                Statements (1)
                    IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c1')
                      Value: 
                        IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'c1')

                Next (Regular) Block[B6]
                    Leaving: {R3}
        }

        Block[B5] - Block
            Predecessors: [B3]
            Statements (1)
                IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c2')
                  Value: 
                    IParameterReferenceOperation: c2 (OperationKind.ParameterReference, Type: C1) (Syntax: 'c2')

            Next (Regular) Block[B6]
        Block[B6] - Block
            Predecessors: [B4] [B5]
            Statements (1)
                IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'new C1(i1,  ...  { F = i2 }')
                  Value: 
                    IInvalidOperation (OperationKind.Invalid, Type: C1, IsInvalid) (Syntax: 'new C1(i1,  ...  { F = i2 }')
                      Children(2):
                          IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'i1')
                          IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'c1 ?? c2')

            Next (Regular) Block[B7]
                Leaving: {R2}
    }

    Block[B7] - Block
        Predecessors: [B6]
        Statements (2)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'F = i2')
              Left: 
                IFieldReferenceOperation: System.Int32 C1.F (OperationKind.FieldReference, Type: System.Int32) (Syntax: 'F')
                  Instance Receiver: 
                    IFlowCaptureReferenceOperation: 4 (OperationKind.FlowCaptureReference, Type: C1, IsInvalid, IsImplicit) (Syntax: 'new C1(i1,  ...  { F = i2 }')
              Right: 
                IParameterReferenceOperation: i2 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i2')

            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: 'c = new C1( ... { F = i2 };')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: C1, IsInvalid) (Syntax: 'c = new C1( ...  { F = i2 }')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'c')
                  Right: 
                    IFlowCaptureReferenceOperation: 4 (OperationKind.FlowCaptureReference, Type: C1, IsInvalid, IsImplicit) (Syntax: 'new C1(i1,  ...  { F = i2 }')

        Next (Regular) Block[B8]
            Leaving: {R1}
}

Block[B8] - Exit
    Predecessors: [B7]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,782249,782359);

f_22056_782249_782358(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,776495,782370);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,776495,782370);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,776495,782370);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ObjectCreationFlow_67()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,782382,787659);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,782537,782790);

string 
source = @"
using System.Collections;
using System.Collections.Generic;

class C1
{
    /*<bind>*/public static void M(C1 c, int i1, C1 c1, C1 c2)
    {
        c = new C1(i1) { F = c1 ?? c2 };
    }/*</bind>*/

    public C1 F;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,782804,783132);

var 
expectedDiagnostics = new[] {
f_22056_783024_783116(f_22056_783024_783096(f_22056_783024_783071(ErrorCode.ERR_BadCtorArgCount, "C1"), "C1", "1"), 9, 17)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,783148,787524);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [1]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (2)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c')
              Value: 
                IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: C1) (Syntax: 'c')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'new C1(i1)  ...  c1 ?? c2 }')
              Value: 
                IInvalidOperation (OperationKind.Invalid, Type: C1, IsInvalid) (Syntax: 'new C1(i1)  ...  c1 ?? c2 }')
                  Children(1):
                      IParameterReferenceOperation: i1 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i1')

        Next (Regular) Block[B2]
            Entering: {R2} {R3}

    .locals {R2}
    {
        CaptureIds: [3]
        .locals {R3}
        {
            CaptureIds: [2]
            Block[B2] - Block
                Predecessors: [B1]
                Statements (1)
                    IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c1')
                      Value: 
                        IParameterReferenceOperation: c1 (OperationKind.ParameterReference, Type: C1) (Syntax: 'c1')

                Jump if True (Regular) to Block[B4]
                    IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'c1')
                      Operand: 
                        IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'c1')
                    Leaving: {R3}

                Next (Regular) Block[B3]
            Block[B3] - Block
                Predecessors: [B2]
                Statements (1)
                    IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c1')
                      Value: 
                        IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'c1')

                Next (Regular) Block[B5]
                    Leaving: {R3}
        }

        Block[B4] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c2')
                  Value: 
                    IParameterReferenceOperation: c2 (OperationKind.ParameterReference, Type: C1) (Syntax: 'c2')

            Next (Regular) Block[B5]
        Block[B5] - Block
            Predecessors: [B3] [B4]
            Statements (1)
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: C1) (Syntax: 'F = c1 ?? c2')
                  Left: 
                    IFieldReferenceOperation: C1 C1.F (OperationKind.FieldReference, Type: C1) (Syntax: 'F')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C1, IsInvalid, IsImplicit) (Syntax: 'new C1(i1)  ...  c1 ?? c2 }')
                  Right: 
                    IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'c1 ?? c2')

            Next (Regular) Block[B6]
                Leaving: {R2}
    }

    Block[B6] - Block
        Predecessors: [B5]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: 'c = new C1( ... c1 ?? c2 };')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: C1, IsInvalid) (Syntax: 'c = new C1( ...  c1 ?? c2 }')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'c')
                  Right: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C1, IsInvalid, IsImplicit) (Syntax: 'new C1(i1)  ...  c1 ?? c2 }')

        Next (Regular) Block[B7]
            Leaving: {R1}
}

Block[B7] - Exit
    Predecessors: [B6]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,787538,787648);

f_22056_787538_787647(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,782382,787659);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,782382,787659);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,782382,787659);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ObjectCreationFlow_68()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,787671,791482);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,787826,788037);

string 
source = @"
public class MemberInitializerTest
{
    public int x, y;
    /*<bind>*/public static void Main()
    {
        var i = new MemberInitializerTest { x = 0, y++ };
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,788051,788728);

var 
expectedDiagnostics = new[] {
f_22056_788333_788439(f_22056_788333_788419(f_22056_788333_788378(ErrorCode.ERR_ObjectRequired, "y"), "MemberInitializerTest.y"), 7, 52),
f_22056_788623_788712(f_22056_788623_788692(ErrorCode.ERR_InvalidInitializerElementInitializer, "y++"), 7, 52)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,788744,791347);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [MemberInitializerTest i]
    CaptureIds: [0]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (4)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'new MemberI ...  = 0, y++ }')
              Value: 
                IObjectCreationOperation (Constructor: MemberInitializerTest..ctor()) (OperationKind.ObjectCreation, Type: MemberInitializerTest, IsInvalid) (Syntax: 'new MemberI ...  = 0, y++ }')
                  Arguments(0)
                  Initializer: 
                    null

            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'x = 0')
              Left: 
                IFieldReferenceOperation: System.Int32 MemberInitializerTest.x (OperationKind.FieldReference, Type: System.Int32) (Syntax: 'x')
                  Instance Receiver: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: MemberInitializerTest, IsInvalid, IsImplicit) (Syntax: 'new MemberI ...  = 0, y++ }')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')

            IIncrementOrDecrementOperation (Postfix) (OperationKind.Increment, Type: ?, IsInvalid) (Syntax: 'y++')
              Target: 
                IFieldReferenceOperation: System.Int32 MemberInitializerTest.y (OperationKind.FieldReference, Type: System.Int32, IsInvalid) (Syntax: 'y')
                  Instance Receiver: 
                    IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: MemberInitializerTest, IsInvalid, IsImplicit) (Syntax: 'y')

            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: MemberInitializerTest, IsInvalid, IsImplicit) (Syntax: 'i = new Mem ...  = 0, y++ }')
              Left: 
                ILocalReferenceOperation: i (IsDeclaration: True) (OperationKind.LocalReference, Type: MemberInitializerTest, IsInvalid, IsImplicit) (Syntax: 'i = new Mem ...  = 0, y++ }')
              Right: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: MemberInitializerTest, IsInvalid, IsImplicit) (Syntax: 'new MemberI ...  = 0, y++ }')

        Next (Regular) Block[B2]
            Leaving: {R1}
}

Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,791361,791471);

f_22056_791361_791470(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,787671,791482);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,787671,791482);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,787671,791482);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ObjectCreationFlow_69()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,791494,798510);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,791649,791982);

string 
source = @"
#pragma warning disable 0169
class A
{
    A this[int x, int y]
    {
        get
        {
            return new A();
        }
    }

    int X, Y, Z;

    /*<bind>*/static void Main(A a, dynamic x, dynamic y)
    {
        a = new A {[x, y] = { X = 1, Y = 2, Z = 3 } };
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,791996,792049);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,792065,798375);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [1]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (2)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
              Value: 
                IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: A) (Syntax: 'a')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new A {[x,  ... , Z = 3 } }')
              Value: 
                IObjectCreationOperation (Constructor: A..ctor()) (OperationKind.ObjectCreation, Type: A) (Syntax: 'new A {[x,  ... , Z = 3 } }')
                  Arguments(0)
                  Initializer: 
                    null

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [2] [3]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (5)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'x')
                  Value: 
                    IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'x')

                IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'y')
                  Value: 
                    IParameterReferenceOperation: y (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'y')

                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: dynamic) (Syntax: 'X = 1')
                  Left: 
                    IDynamicMemberReferenceOperation (Member Name: ""X"", Containing Type: dynamic) (OperationKind.DynamicMemberReference, Type: dynamic) (Syntax: 'X')
                      Type Arguments(0)
                      Instance Receiver: 
                        IDynamicIndexerAccessOperation (OperationKind.DynamicIndexerAccess, Type: dynamic) (Syntax: '[x, y]')
                          Expression: 
                            IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: A, IsImplicit) (Syntax: 'new A {[x,  ... , Z = 3 } }')
                          Arguments(2):
                              IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'x')
                              IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'y')
                          ArgumentNames(0)
                          ArgumentRefKinds(0)
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: dynamic) (Syntax: 'Y = 2')
                  Left: 
                    IDynamicMemberReferenceOperation (Member Name: ""Y"", Containing Type: dynamic) (OperationKind.DynamicMemberReference, Type: dynamic) (Syntax: 'Y')
                      Type Arguments(0)
                      Instance Receiver: 
                        IDynamicIndexerAccessOperation (OperationKind.DynamicIndexerAccess, Type: dynamic) (Syntax: '[x, y]')
                          Expression: 
                            IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: A, IsImplicit) (Syntax: 'new A {[x,  ... , Z = 3 } }')
                          Arguments(2):
                              IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'x')
                              IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'y')
                          ArgumentNames(0)
                          ArgumentRefKinds(0)
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')

                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: dynamic) (Syntax: 'Z = 3')
                  Left: 
                    IDynamicMemberReferenceOperation (Member Name: ""Z"", Containing Type: dynamic) (OperationKind.DynamicMemberReference, Type: dynamic) (Syntax: 'Z')
                      Type Arguments(0)
                      Instance Receiver: 
                        IDynamicIndexerAccessOperation (OperationKind.DynamicIndexerAccess, Type: dynamic) (Syntax: '[x, y]')
                          Expression: 
                            IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: A, IsImplicit) (Syntax: 'new A {[x,  ... , Z = 3 } }')
                          Arguments(2):
                              IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'x')
                              IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'y')
                          ArgumentNames(0)
                          ArgumentRefKinds(0)
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')

            Next (Regular) Block[B3]
                Leaving: {R2}
    }

    Block[B3] - Block
        Predecessors: [B2]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'a = new A { ...  Z = 3 } };')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: A) (Syntax: 'a = new A { ... , Z = 3 } }')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: A, IsImplicit) (Syntax: 'a')
                  Right: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: A, IsImplicit) (Syntax: 'new A {[x,  ... , Z = 3 } }')

        Next (Regular) Block[B4]
            Leaving: {R1}
}

Block[B4] - Exit
    Predecessors: [B3]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,798389,798499);

f_22056_798389_798498(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,791494,798510);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,791494,798510);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,791494,798510);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ObjectCreationFlow_70()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,798522,804166);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,798677,798898);

string 
source = @"
#pragma warning disable 0169
class A
{
    dynamic D { get; set; }

    /*<bind>*/static void Main(A a, bool b)
    {
        a = new A { D = { X = 1, Y = b ? 2 : 3 } };
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,798912,798965);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,798981,804031);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [1]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (3)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
              Value: 
                IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: A) (Syntax: 'a')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new A { D = ... ? 2 : 3 } }')
              Value: 
                IObjectCreationOperation (Constructor: A..ctor()) (OperationKind.ObjectCreation, Type: A) (Syntax: 'new A { D = ... ? 2 : 3 } }')
                  Arguments(0)
                  Initializer: 
                    null

            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: dynamic) (Syntax: 'X = 1')
              Left: 
                IDynamicMemberReferenceOperation (Member Name: ""X"", Containing Type: dynamic) (OperationKind.DynamicMemberReference, Type: dynamic) (Syntax: 'X')
                  Type Arguments(0)
                  Instance Receiver: 
                    IPropertyReferenceOperation: dynamic A.D { get; set; } (OperationKind.PropertyReference, Type: dynamic) (Syntax: 'D')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: A, IsImplicit) (Syntax: 'new A { D = ... ? 2 : 3 } }')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [2] [3]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'D')
                  Value: 
                    IPropertyReferenceOperation: dynamic A.D { get; set; } (OperationKind.PropertyReference, Type: dynamic) (Syntax: 'D')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: A, IsImplicit) (Syntax: 'new A { D = ... ? 2 : 3 } }')

            Jump if False (Regular) to Block[B4]
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '2')
                  Value: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')

            Next (Regular) Block[B5]
        Block[B4] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '3')
                  Value: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')

            Next (Regular) Block[B5]
        Block[B5] - Block
            Predecessors: [B3] [B4]
            Statements (1)
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: dynamic) (Syntax: 'Y = b ? 2 : 3')
                  Left: 
                    IDynamicMemberReferenceOperation (Member Name: ""Y"", Containing Type: dynamic) (OperationKind.DynamicMemberReference, Type: dynamic) (Syntax: 'Y')
                      Type Arguments(0)
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'D')
                  Right: 
                    IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'b ? 2 : 3')

            Next (Regular) Block[B6]
                Leaving: {R2}
    }

    Block[B6] - Block
        Predecessors: [B5]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'a = new A { ...  2 : 3 } };')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: A) (Syntax: 'a = new A { ... ? 2 : 3 } }')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: A, IsImplicit) (Syntax: 'a')
                  Right: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: A, IsImplicit) (Syntax: 'new A { D = ... ? 2 : 3 } }')

        Next (Regular) Block[B7]
            Leaving: {R1}
}

Block[B7] - Exit
    Predecessors: [B6]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,804045,804155);

f_22056_804045_804154(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,798522,804166);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,798522,804166);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,798522,804166);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ObjectCreationFlow_71()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,804178,808022);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,804333,804767);

string 
source = @"
#pragma warning disable 0169
class A
{
    dynamic this[int x, int y]
    {
        get
        {
            return new A();
        }
    }

    dynamic this[string x, string y]
    {
        get
        {
            throw null;
        }
    }

    int X, Y, Z;

    /*<bind>*/static void Main()
    {
        dynamic x = 1;
        new A {[y: x, x: x] = { } };
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,804781,804834);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,804850,807887);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [dynamic x]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: dynamic, IsImplicit) (Syntax: 'x = 1')
              Left: 
                ILocalReferenceOperation: x (IsDeclaration: True) (OperationKind.LocalReference, Type: dynamic, IsImplicit) (Syntax: 'x = 1')
              Right: 
                IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: dynamic, IsImplicit) (Syntax: '1')
                  Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    (Boxing)
                  Operand: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [0]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new A {[y:  ...  x] = { } }')
                  Value: 
                    IObjectCreationOperation (Constructor: A..ctor()) (OperationKind.ObjectCreation, Type: A) (Syntax: 'new A {[y:  ...  x] = { } }')
                      Arguments(0)
                      Initializer: 
                        null

            Next (Regular) Block[B3]
                Entering: {R3}

        .locals {R3}
        {
            CaptureIds: [1] [2]
            Block[B3] - Block
                Predecessors: [B2]
                Statements (2)
                    IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'x')
                      Value: 
                        ILocalReferenceOperation: x (OperationKind.LocalReference, Type: dynamic) (Syntax: 'x')

                    IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'x')
                      Value: 
                        ILocalReferenceOperation: x (OperationKind.LocalReference, Type: dynamic) (Syntax: 'x')

                Next (Regular) Block[B4]
                    Leaving: {R3}
        }

        Block[B4] - Block
            Predecessors: [B3]
            Statements (1)
                IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'new A {[y:  ... x] = { } };')
                  Expression: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: A, IsImplicit) (Syntax: 'new A {[y:  ...  x] = { } }')

            Next (Regular) Block[B5]
                Leaving: {R2} {R1}
    }
}

Block[B5] - Exit
    Predecessors: [B4]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,807901,808011);

f_22056_807901_808010(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,804178,808022);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,804178,808022);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,804178,808022);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ObjectCreationFlow_72()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,808034,813009);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,808189,808399);

string 
source = @"
public class MyClass
{
    public MyClass(int i1, int i2, int i3) { }
    static void M(bool b)
    /*<bind>*/{
        var c = new MyClass(1, 2, b ? 3 : 4) {};
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,808413,808466);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,808482,812886);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [MyClass c]
    CaptureIds: [0] [1] [2]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (2)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '1')
              Value: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '2')
              Value: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')

        Jump if False (Regular) to Block[B3]
            IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '3')
              Value: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')

        Next (Regular) Block[B4]
    Block[B3] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '4')
              Value: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 4) (Syntax: '4')

        Next (Regular) Block[B4]
    Block[B4] - Block
        Predecessors: [B2] [B3]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: MyClass, IsImplicit) (Syntax: 'c = new MyC ... ? 3 : 4) {}')
              Left: 
                ILocalReferenceOperation: c (IsDeclaration: True) (OperationKind.LocalReference, Type: MyClass, IsImplicit) (Syntax: 'c = new MyC ... ? 3 : 4) {}')
              Right: 
                IObjectCreationOperation (Constructor: MyClass..ctor(System.Int32 i1, System.Int32 i2, System.Int32 i3)) (OperationKind.ObjectCreation, Type: MyClass) (Syntax: 'new MyClass ... ? 3 : 4) {}')
                  Arguments(3):
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i1) (OperationKind.Argument, Type: null) (Syntax: '1')
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, Constant: 1, IsImplicit) (Syntax: '1')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i2) (OperationKind.Argument, Type: null) (Syntax: '2')
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32, Constant: 2, IsImplicit) (Syntax: '2')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i3) (OperationKind.Argument, Type: null) (Syntax: 'b ? 3 : 4')
                        IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'b ? 3 : 4')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  Initializer: 
                    null

        Next (Regular) Block[B5]
            Leaving: {R1}
}

Block[B5] - Exit
    Predecessors: [B4]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,812900,812998);

f_22056_812900_812997(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,808034,813009);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,808034,813009);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,808034,813009);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ObjectCreationFlow_73()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,813021,815865);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,813176,813334);

string 
source = @"
class C
{
    static int i1;
    public static void Main()
    /*<bind>*/{
        var c = new C { i1 = 1 };
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,813348,813960);

var 
expectedDiagnostics = new[] {
f_22056_813578_813683(f_22056_813578_813663(f_22056_813578_813641(ErrorCode.ERR_StaticMemberInObjectInitializer, "i1"), "C.i1"), 7, 25),
f_22056_813849_813944(f_22056_813849_813924(f_22056_813849_813902(ErrorCode.WRN_UnreferencedFieldAssg, "i1"), "C.i1"), 4, 16)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,813976,815742);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [C c]
    CaptureIds: [0]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (3)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'new C { i1 = 1 }')
              Value: 
                IObjectCreationOperation (Constructor: C..ctor()) (OperationKind.ObjectCreation, Type: C, IsInvalid) (Syntax: 'new C { i1 = 1 }')
                  Arguments(0)
                  Initializer: 
                    null

            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsInvalid) (Syntax: 'i1 = 1')
              Left: 
                IFieldReferenceOperation: System.Int32 C.i1 (Static) (OperationKind.FieldReference, Type: System.Int32, IsInvalid) (Syntax: 'i1')
                  Instance Receiver: 
                    null
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: C, IsInvalid, IsImplicit) (Syntax: 'c = new C { i1 = 1 }')
              Left: 
                ILocalReferenceOperation: c (IsDeclaration: True) (OperationKind.LocalReference, Type: C, IsInvalid, IsImplicit) (Syntax: 'c = new C { i1 = 1 }')
              Right: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C, IsInvalid, IsImplicit) (Syntax: 'new C { i1 = 1 }')

        Next (Regular) Block[B2]
            Leaving: {R1}
}

Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,815756,815854);

f_22056_815756_815853(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,813021,815865);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,813021,815865);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,813021,815865);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ObjectCreationFlow_74()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,815877,824881);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,816032,816277);

string 
source = @"
struct S1
{
    public int x;
}

struct S
{
    public S1 x;
 
    static void M(bool result)
    /*<bind>*/{
        result = new S { x = new S1{x=0} }.x.Equals(new S { x = new S1{x=1} });
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,816291,816344);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,816360,824758);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [3] [4]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'result')
              Value: 
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'result')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new S { x = ... w S1{x=0} }')
                  Value: 
                    IObjectCreationOperation (Constructor: S..ctor()) (OperationKind.ObjectCreation, Type: S) (Syntax: 'new S { x = ... w S1{x=0} }')
                      Arguments(0)
                      Initializer: 
                        null

            Next (Regular) Block[B3]
                Entering: {R3}

        .locals {R3}
        {
            CaptureIds: [2]
            Block[B3] - Block
                Predecessors: [B2]
                Statements (3)
                    IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new S1{x=0}')
                      Value: 
                        IObjectCreationOperation (Constructor: S1..ctor()) (OperationKind.ObjectCreation, Type: S1) (Syntax: 'new S1{x=0}')
                          Arguments(0)
                          Initializer: 
                            null

                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'x=0')
                      Left: 
                        IFieldReferenceOperation: System.Int32 S1.x (OperationKind.FieldReference, Type: System.Int32) (Syntax: 'x')
                          Instance Receiver: 
                            IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: S1, IsImplicit) (Syntax: 'new S1{x=0}')
                      Right: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')

                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: S1) (Syntax: 'x = new S1{x=0}')
                      Left: 
                        IFieldReferenceOperation: S1 S.x (OperationKind.FieldReference, Type: S1) (Syntax: 'x')
                          Instance Receiver: 
                            IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: S, IsImplicit) (Syntax: 'new S { x = ... w S1{x=0} }')
                      Right: 
                        IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: S1, IsImplicit) (Syntax: 'new S1{x=0}')

                Next (Regular) Block[B4]
                    Leaving: {R3}
        }

        Block[B4] - Block
            Predecessors: [B3]
            Statements (1)
                IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new S { x = ... S1{x=0} }.x')
                  Value: 
                    IFieldReferenceOperation: S1 S.x (OperationKind.FieldReference, Type: S1) (Syntax: 'new S { x = ... S1{x=0} }.x')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: S, IsImplicit) (Syntax: 'new S { x = ... w S1{x=0} }')

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B5] - Block
        Predecessors: [B4]
        Statements (1)
            IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new S { x = ... w S1{x=1} }')
              Value: 
                IObjectCreationOperation (Constructor: S..ctor()) (OperationKind.ObjectCreation, Type: S) (Syntax: 'new S { x = ... w S1{x=1} }')
                  Arguments(0)
                  Initializer: 
                    null

        Next (Regular) Block[B6]
            Entering: {R4}

    .locals {R4}
    {
        CaptureIds: [5]
        Block[B6] - Block
            Predecessors: [B5]
            Statements (3)
                IFlowCaptureOperation: 5 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new S1{x=1}')
                  Value: 
                    IObjectCreationOperation (Constructor: S1..ctor()) (OperationKind.ObjectCreation, Type: S1) (Syntax: 'new S1{x=1}')
                      Arguments(0)
                      Initializer: 
                        null

                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'x=1')
                  Left: 
                    IFieldReferenceOperation: System.Int32 S1.x (OperationKind.FieldReference, Type: System.Int32) (Syntax: 'x')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 5 (OperationKind.FlowCaptureReference, Type: S1, IsImplicit) (Syntax: 'new S1{x=1}')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: S1) (Syntax: 'x = new S1{x=1}')
                  Left: 
                    IFieldReferenceOperation: S1 S.x (OperationKind.FieldReference, Type: S1) (Syntax: 'x')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 4 (OperationKind.FlowCaptureReference, Type: S, IsImplicit) (Syntax: 'new S { x = ... w S1{x=1} }')
                  Right: 
                    IFlowCaptureReferenceOperation: 5 (OperationKind.FlowCaptureReference, Type: S1, IsImplicit) (Syntax: 'new S1{x=1}')

            Next (Regular) Block[B7]
                Leaving: {R4}
    }

    Block[B7] - Block
        Predecessors: [B6]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = ne ... S1{x=1} });')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'result = ne ...  S1{x=1} })')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Boolean, IsImplicit) (Syntax: 'result')
                  Right: 
                    IInvocationOperation (virtual System.Boolean System.ValueType.Equals(System.Object obj)) (OperationKind.Invocation, Type: System.Boolean) (Syntax: 'new S { x = ...  S1{x=1} })')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: S1, IsImplicit) (Syntax: 'new S { x = ... S1{x=0} }.x')
                      Arguments(1):
                          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: obj) (OperationKind.Argument, Type: null) (Syntax: 'new S { x = ... w S1{x=1} }')
                            IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsImplicit) (Syntax: 'new S { x = ... w S1{x=1} }')
                              Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                (Boxing)
                              Operand: 
                                IFlowCaptureReferenceOperation: 4 (OperationKind.FlowCaptureReference, Type: S, IsImplicit) (Syntax: 'new S { x = ... w S1{x=1} }')
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

        Next (Regular) Block[B8]
            Leaving: {R1}
}

Block[B8] - Exit
    Predecessors: [B7]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,824772,824870);

f_22056_824772_824869(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,815877,824881);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,815877,824881);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,815877,824881);
}
		}

[Fact]
        public void ObjectCreationExpression_NoNewConstraint()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,824893,829115);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,824988,825127);

var 
source = @"
class C
{
    static void F2<T2>()
    /*<bind>*/{
        object x2;
        x2 = new T2 { };
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,825141,825178);

var 
comp = f_22056_825152_825177(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,825194,825550);

var 
diagnostics = new DiagnosticDescription[] {
f_22056_825444_825534(f_22056_825444_825514(f_22056_825444_825494(ErrorCode.ERR_NoNewTyvar, "new T2 { }"), "T2"), 7, 14)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,825566,827279);

var 
expectedOperationTree = @"
IBlockOperation (2 statements, 1 locals) (OperationKind.Block, Type: null, IsInvalid) (Syntax: '{ ... }')
  Locals: Local_1: System.Object x2
  IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null) (Syntax: 'object x2;')
    IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'object x2')
      Declarators:
          IVariableDeclaratorOperation (Symbol: System.Object x2) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'x2')
            Initializer: 
              null
      Initializer: 
        null
  IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: 'x2 = new T2 { };')
    Expression: 
      ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Object, IsInvalid) (Syntax: 'x2 = new T2 { }')
        Left: 
          ILocalReferenceOperation: x2 (OperationKind.LocalReference, Type: System.Object) (Syntax: 'x2')
        Right: 
          IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsInvalid, IsImplicit) (Syntax: 'new T2 { }')
            Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            Operand: 
              IInvalidOperation (OperationKind.Invalid, Type: T2, IsInvalid) (Syntax: 'new T2 { }')
                Children(1):
                    IObjectOrCollectionInitializerOperation (OperationKind.ObjectOrCollectionInitializer, Type: T2, IsInvalid) (Syntax: '{ }')
                      Initializers(0)"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,827295,827391);

f_22056_827295_827390(comp, expectedOperationTree, diagnostics);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,827407,829104);

f_22056_827407_829103(comp, @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [System.Object x2]
    CaptureIds: [0]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (2)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'x2')
              Value: 
                ILocalReferenceOperation: x2 (OperationKind.LocalReference, Type: System.Object) (Syntax: 'x2')

            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: 'x2 = new T2 { };')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Object, IsInvalid) (Syntax: 'x2 = new T2 { }')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'x2')
                  Right: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsInvalid, IsImplicit) (Syntax: 'new T2 { }')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (Boxing)
                      Operand: 
                        IInvalidOperation (OperationKind.Invalid, Type: T2, IsInvalid) (Syntax: 'new T2 { }')
                          Children(0)

        Next (Regular) Block[B2]
            Leaving: {R1}
}

Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)");
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,824893,829115);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,824893,829115);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,824893,829115);
}
		}

[Fact]
        public void ObjectCreationFlow_ParenthesizedReferenceOffConstructedObject()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22056,829127,833564);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,829243,829479);

var 
source =
@"
class A
{
    internal object F1;
}
class B
{
    internal A G;
}
class Program
{
    static void F(A a)
    /*<bind>*/{
        a = (new B() { G = new A() { F1 = new object() } }).G;
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,829495,829532);

var 
comp = f_22056_829506_829531(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056,829546,833553);

f_22056_829546_833552(comp, @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [1]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (2)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
              Value: 
                IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: A) (Syntax: 'a')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new B() { G ... bject() } }')
              Value: 
                IObjectCreationOperation (Constructor: B..ctor()) (OperationKind.ObjectCreation, Type: B) (Syntax: 'new B() { G ... bject() } }')
                  Arguments(0)
                  Initializer: 
                    null

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (3)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new A() { F ...  object() }')
                  Value: 
                    IObjectCreationOperation (Constructor: A..ctor()) (OperationKind.ObjectCreation, Type: A) (Syntax: 'new A() { F ...  object() }')
                      Arguments(0)
                      Initializer: 
                        null

                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Object) (Syntax: 'F1 = new object()')
                  Left: 
                    IFieldReferenceOperation: System.Object A.F1 (OperationKind.FieldReference, Type: System.Object) (Syntax: 'F1')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: A, IsImplicit) (Syntax: 'new A() { F ...  object() }')
                  Right: 
                    IObjectCreationOperation (Constructor: System.Object..ctor()) (OperationKind.ObjectCreation, Type: System.Object) (Syntax: 'new object()')
                      Arguments(0)
                      Initializer: 
                        null

                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: A) (Syntax: 'G = new A() ...  object() }')
                  Left: 
                    IFieldReferenceOperation: A B.G (OperationKind.FieldReference, Type: A) (Syntax: 'G')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: B, IsImplicit) (Syntax: 'new B() { G ... bject() } }')
                  Right: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: A, IsImplicit) (Syntax: 'new A() { F ...  object() }')

            Next (Regular) Block[B3]
                Leaving: {R2}
    }

    Block[B3] - Block
        Predecessors: [B2]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'a = (new B( ... t() } }).G;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: A) (Syntax: 'a = (new B( ... ct() } }).G')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: A, IsImplicit) (Syntax: 'a')
                  Right: 
                    IFieldReferenceOperation: A B.G (OperationKind.FieldReference, Type: A) (Syntax: '(new B() {  ... ct() } }).G')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: B, IsImplicit) (Syntax: 'new B() { G ... bject() } }')

        Next (Regular) Block[B4]
            Leaving: {R1}
}

Block[B4] - Exit
    Predecessors: [B3]
    Statements (0)");
DynAbs.Tracing.TraceSender.TraceExitMethod(22056,829127,833564);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22056,829127,833564);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22056,829127,833564);
}
		}

int
f_22056_12563_12713(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
parseOptions)
{
VerifyOperationTreeAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedOperationTree, expectedDiagnostics, parseOptions:parseOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 12563, 12713);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22056_12900_13449(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 12900, 13449);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_27238_27283(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 27238, 27283);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_27238_27309(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 27238, 27309);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_27238_27330(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 27238, 27330);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_27568_27640(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 27568, 27640);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_27568_27659(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 27568, 27659);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_27568_27680(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 27568, 27680);
return return_v;
}


int
f_22056_27712_27815(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<BlockSyntax>( compilation, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 27712, 27815);
return 0;
}


int
f_22056_27830_41824(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 27830, 41824);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_46366_46424(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 46366, 46424);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_46366_46454(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 46366, 46454);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_46366_46474(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 46366, 46474);
return return_v;
}


int
f_22056_46506_46683(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
parseOptions)
{
VerifyOperationTreeAndDiagnosticsForTest<ImplicitObjectCreationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics, parseOptions:parseOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 46506, 46683);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22056_46879_47209(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 46879, 47209);
return return_v;
}


int
f_22056_54158_54288(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ImplicitObjectCreationExpressionSyntax>( compilation, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 54158, 54288);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxTree>
f_22056_54314_54330(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param)
{
var return_v = this_param.SyntaxTrees;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22056, 54314, 54330);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxNode
f_22056_54314_54343(Microsoft.CodeAnalysis.SyntaxTree
this_param)
{
var return_v = this_param.GetRoot();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 54314, 54343);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
f_22056_54314_54361(Microsoft.CodeAnalysis.SyntaxNode
this_param)
{
var return_v = this_param.DescendantNodes();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 54314, 54361);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax>
f_22056_54314_54395(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
source)
{
var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 54314, 54395);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
f_22056_54314_54404(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax>
source)
{
var return_v = source.Single<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 54314, 54404);
return return_v;
}


int
f_22056_54419_63780(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
syntaxNode,string
expectedFlowGraph)
{
VerifyFlowGraph( compilation, (Microsoft.CodeAnalysis.SyntaxNode)syntaxNode, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 54419, 63780);
return 0;
}


int
f_22056_73966_74143(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
parseOptions)
{
VerifyOperationTreeAndDiagnosticsForTest<ImplicitObjectCreationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics, parseOptions:parseOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 73966, 74143);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22056_74328_74491(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 74328, 74491);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_77400_77452(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 77400, 77452);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_77400_77473(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 77400, 77473);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_77400_77493(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 77400, 77493);
return return_v;
}


int
f_22056_77525_77655(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ImplicitObjectCreationExpressionSyntax>( compilation, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 77525, 77655);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxTree>
f_22056_77683_77699(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param)
{
var return_v = this_param.SyntaxTrees;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22056, 77683, 77699);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxNode
f_22056_77683_77712(Microsoft.CodeAnalysis.SyntaxTree
this_param)
{
var return_v = this_param.GetRoot();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 77683, 77712);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
f_22056_77683_77730(Microsoft.CodeAnalysis.SyntaxNode
this_param)
{
var return_v = this_param.DescendantNodes();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 77683, 77730);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax>
f_22056_77683_77764(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
source)
{
var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 77683, 77764);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
f_22056_77683_77773(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax>
source)
{
var return_v = source.Single<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 77683, 77773);
return return_v;
}


int
f_22056_77790_82128(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
syntaxNode,string
expectedFlowGraph)
{
VerifyFlowGraph( compilation, (Microsoft.CodeAnalysis.SyntaxNode)syntaxNode, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 77790, 82128);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_83859_83914(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 83859, 83914);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_83859_83950(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 83859, 83950);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_83859_83970(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 83859, 83970);
return return_v;
}


int
f_22056_84002_84179(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
parseOptions)
{
VerifyOperationTreeAndDiagnosticsForTest<ImplicitObjectCreationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics, parseOptions:parseOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 84002, 84179);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_86773_86827(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 86773, 86827);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_86773_86862(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 86773, 86862);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_86773_86882(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 86773, 86882);
return return_v;
}


int
f_22056_86914_87091(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
parseOptions)
{
VerifyOperationTreeAndDiagnosticsForTest<ImplicitObjectCreationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics, parseOptions:parseOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 86914, 87091);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22056_87288_87481(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 87288, 87481);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_90463_90517(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 90463, 90517);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_90463_90552(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 90463, 90552);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_90463_90572(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 90463, 90572);
return return_v;
}


int
f_22056_90604_90734(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ImplicitObjectCreationExpressionSyntax>( compilation, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 90604, 90734);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxTree>
f_22056_90760_90776(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param)
{
var return_v = this_param.SyntaxTrees;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22056, 90760, 90776);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxNode
f_22056_90760_90789(Microsoft.CodeAnalysis.SyntaxTree
this_param)
{
var return_v = this_param.GetRoot();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 90760, 90789);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
f_22056_90760_90807(Microsoft.CodeAnalysis.SyntaxNode
this_param)
{
var return_v = this_param.DescendantNodes();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 90760, 90807);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax>
f_22056_90760_90841(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
source)
{
var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 90760, 90841);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
f_22056_90760_90850(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax>
source)
{
var return_v = source.Single<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 90760, 90850);
return return_v;
}


int
f_22056_90867_95280(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
syntaxNode,string
expectedFlowGraph)
{
VerifyFlowGraph( compilation, (Microsoft.CodeAnalysis.SyntaxNode)syntaxNode, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 90867, 95280);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22056_95553_95617(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 95553, 95617);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_95867_95916(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 95867, 95916);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_95867_95937(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 95867, 95937);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_95867_95957(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 95867, 95957);
return return_v;
}


int
f_22056_95989_96321(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ImplicitObjectCreationExpressionSyntax>( compilation, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 95989, 96321);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22056_96595_96697(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 96595, 96697);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_96940_96989(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 96940, 96989);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_96940_97010(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 96940, 97010);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_96940_97030(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 96940, 97030);
return return_v;
}


int
f_22056_97062_97394(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ImplicitObjectCreationExpressionSyntax>( compilation, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 97062, 97394);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22056_97831_97856(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 97831, 97856);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_98126_98175(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 98126, 98175);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_98126_98196(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 98126, 98196);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_98126_98216(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 98126, 98216);
return return_v;
}


int
f_22056_98248_98580(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ImplicitObjectCreationExpressionSyntax>( compilation, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 98248, 98580);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22056_99033_99058(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 99033, 99058);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_99336_99385(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 99336, 99385);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_99336_99406(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 99336, 99406);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_99336_99426(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 99336, 99426);
return return_v;
}


int
f_22056_99458_99790(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ImplicitObjectCreationExpressionSyntax>( compilation, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 99458, 99790);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22056_100269_100294(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 100269, 100294);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_100593_100642(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 100593, 100642);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_100593_100663(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 100593, 100663);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_100593_100683(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 100593, 100683);
return return_v;
}


int
f_22056_100715_101047(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ImplicitObjectCreationExpressionSyntax>( compilation, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 100715, 101047);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22056_101243_101699(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 101243, 101699);
return return_v;
}


int
f_22056_104663_104781(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<AssignmentExpressionSyntax>( compilation, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 104663, 104781);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxTree>
f_22056_104809_104825(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param)
{
var return_v = this_param.SyntaxTrees;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22056, 104809, 104825);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxNode
f_22056_104809_104838(Microsoft.CodeAnalysis.SyntaxTree
this_param)
{
var return_v = this_param.GetRoot();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 104809, 104838);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
f_22056_104809_104856(Microsoft.CodeAnalysis.SyntaxNode
this_param)
{
var return_v = this_param.DescendantNodes();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 104809, 104856);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax>
f_22056_104809_104890(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
source)
{
var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 104809, 104890);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
f_22056_104809_104899(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax>
source)
{
var return_v = source.Single<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 104809, 104899);
return return_v;
}


int
f_22056_104914_112414(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
syntaxNode,string
expectedFlowGraph)
{
VerifyFlowGraph( compilation, (Microsoft.CodeAnalysis.SyntaxNode)syntaxNode, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 104914, 112414);
return 0;
}


int
f_22056_114046_114211(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
parseOptions)
{
VerifyOperationTreeAndDiagnosticsForTest<AssignmentExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics, parseOptions:parseOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 114046, 114211);
return 0;
}


int
f_22056_115509_115664(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
parseOptions)
{
VerifyOperationTreeAndDiagnosticsForTest<ExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics, parseOptions:parseOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 115509, 115664);
return 0;
}


int
f_22056_117415_117592(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
parseOptions)
{
VerifyOperationTreeAndDiagnosticsForTest<ImplicitObjectCreationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics, parseOptions:parseOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 117415, 117592);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_119578_119640(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 119578, 119640);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_119578_119672(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 119578, 119672);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_119578_119692(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 119578, 119692);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_120011_120073(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 120011, 120073);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_120011_120105(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 120011, 120105);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_120011_120125(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 120011, 120125);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_120444_120506(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 120444, 120506);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_120444_120538(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 120444, 120538);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_120444_120558(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 120444, 120558);
return return_v;
}


int
f_22056_120590_120756(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
parseOptions)
{
VerifyOperationTreeAndDiagnosticsForTest<InitializerExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics, parseOptions:parseOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 120590, 120756);
return 0;
}


int
f_22056_126353_126519(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
parseOptions)
{
VerifyOperationTreeAndDiagnosticsForTest<InitializerExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics, parseOptions:parseOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 126353, 126519);
return 0;
}


int
f_22056_131730_131896(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
parseOptions)
{
VerifyOperationTreeAndDiagnosticsForTest<InitializerExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics, parseOptions:parseOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 131730, 131896);
return 0;
}


int
f_22056_137215_137381(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
parseOptions)
{
VerifyOperationTreeAndDiagnosticsForTest<InitializerExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics, parseOptions:parseOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 137215, 137381);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_138430_138492(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 138430, 138492);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_138430_138520(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 138430, 138520);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_138430_138540(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 138430, 138540);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_138842_138904(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 138842, 138904);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_138842_138932(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 138842, 138932);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_138842_138952(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 138842, 138952);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_139254_139316(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 139254, 139316);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_139254_139344(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 139254, 139344);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_139254_139364(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 139254, 139364);
return return_v;
}


int
f_22056_140318_140484(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
parseOptions)
{
VerifyOperationTreeAndDiagnosticsForTest<InitializerExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics, parseOptions:parseOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 140318, 140484);
return 0;
}


int
f_22056_144225_144382(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
parseOptions)
{
VerifyOperationTreeAndDiagnosticsForTest<InitializerExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics, parseOptions:parseOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 144225, 144382);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22056_144575_144795(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 144575, 144795);
return return_v;
}


int
f_22056_146941_147060(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InitializerExpressionSyntax>( compilation, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 146941, 147060);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxTree>
f_22056_147085_147101(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param)
{
var return_v = this_param.SyntaxTrees;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22056, 147085, 147101);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxNode
f_22056_147085_147114(Microsoft.CodeAnalysis.SyntaxTree
this_param)
{
var return_v = this_param.GetRoot();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 147085, 147114);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
f_22056_147085_147132(Microsoft.CodeAnalysis.SyntaxNode
this_param)
{
var return_v = this_param.DescendantNodes();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 147085, 147132);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax>
f_22056_147085_147166(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
source)
{
var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 147085, 147166);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
f_22056_147085_147175(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax>
source)
{
var return_v = source.Single<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 147085, 147175);
return return_v;
}


int
f_22056_147192_150964(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
syntaxNode,string
expectedFlowGraph)
{
VerifyFlowGraph( compilation, (Microsoft.CodeAnalysis.SyntaxNode)syntaxNode, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 147192, 150964);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22056_151161_151642(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 151161, 151642);
return return_v;
}


int
f_22056_154123_154242(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InitializerExpressionSyntax>( compilation, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 154123, 154242);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxTree>
f_22056_154267_154283(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param)
{
var return_v = this_param.SyntaxTrees;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22056, 154267, 154283);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxNode
f_22056_154267_154296(Microsoft.CodeAnalysis.SyntaxTree
this_param)
{
var return_v = this_param.GetRoot();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 154267, 154296);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
f_22056_154267_154314(Microsoft.CodeAnalysis.SyntaxNode
this_param)
{
var return_v = this_param.DescendantNodes();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 154267, 154314);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax>
f_22056_154267_154348(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
source)
{
var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 154267, 154348);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
f_22056_154267_154391(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax>
source,System.Func<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax, bool>
predicate)
{
var return_v = source.Single<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax>( predicate);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 154267, 154391);
return return_v;
}


int
f_22056_154406_158477(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
syntaxNode,string
expectedFlowGraph)
{
VerifyFlowGraph( compilation, (Microsoft.CodeAnalysis.SyntaxNode)syntaxNode, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 154406, 158477);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_173104_173149(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 173104, 173149);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_173104_173175(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 173104, 173175);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_173104_173196(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 173104, 173196);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_173416_173488(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 173416, 173488);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_173416_173507(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 173416, 173507);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_173416_173528(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 173416, 173528);
return return_v;
}


int
f_22056_173560_173665(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 173560, 173665);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_178216_178274(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 178216, 178274);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_178216_178304(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 178216, 178304);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_178216_178324(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 178216, 178324);
return return_v;
}


int
f_22056_178356_178480(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ObjectCreationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 178356, 178480);
return 0;
}


int
f_22056_186037_186161(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ObjectCreationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 186037, 186161);
return 0;
}


int
f_22056_196419_196543(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ObjectCreationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 196419, 196543);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_199848_199900(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 199848, 199900);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_199848_199921(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 199848, 199921);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_199848_199941(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 199848, 199941);
return return_v;
}


int
f_22056_199973_200097(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ObjectCreationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 199973, 200097);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_201857_201912(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 201857, 201912);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_201857_201948(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 201857, 201948);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_201857_201968(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 201857, 201968);
return return_v;
}


int
f_22056_202000_202124(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ObjectCreationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 202000, 202124);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_204747_204801(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 204747, 204801);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_204747_204836(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 204747, 204836);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_204747_204856(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 204747, 204856);
return return_v;
}


int
f_22056_204888_205012(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ObjectCreationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 204888, 205012);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_208401_208455(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 208401, 208455);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_208401_208490(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 208401, 208490);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_208401_208510(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 208401, 208510);
return return_v;
}


int
f_22056_208542_208666(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ObjectCreationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 208542, 208666);
return 0;
}


int
f_22056_212336_212456(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<AssignmentExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 212336, 212456);
return 0;
}


int
f_22056_214156_214276(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<AssignmentExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 214156, 214276);
return 0;
}


int
f_22056_215642_215752(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 215642, 215752);
return 0;
}


int
f_22056_217479_217603(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ObjectCreationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 217479, 217603);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_219572_219634(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 219572, 219634);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_219572_219666(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 219572, 219666);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_219572_219687(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 219572, 219687);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_219987_220049(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 219987, 220049);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_219987_220081(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 219987, 220081);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_219987_220102(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 219987, 220102);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_220402_220464(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 220402, 220464);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_220402_220496(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 220402, 220496);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_220402_220517(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 220402, 220517);
return return_v;
}


int
f_22056_220549_220670(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InitializerExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 220549, 220670);
return 0;
}


int
f_22056_226191_226312(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InitializerExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 226191, 226312);
return 0;
}


int
f_22056_231447_231568(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InitializerExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 231447, 231568);
return 0;
}


int
f_22056_236731_236852(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InitializerExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 236731, 236852);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_237884_237946(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 237884, 237946);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_237884_237974(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 237884, 237974);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_237884_237995(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 237884, 237995);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_238278_238340(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 238278, 238340);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_238278_238368(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 238278, 238368);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_238278_238389(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 238278, 238389);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_238672_238734(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 238672, 238734);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_238672_238762(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 238672, 238762);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_238672_238783(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 238672, 238783);
return return_v;
}


int
f_22056_239737_239858(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InitializerExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 239737, 239858);
return 0;
}


int
f_22056_243550_243671(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InitializerExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 243550, 243671);
return 0;
}


int
f_22056_248160_248284(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ObjectCreationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 248160, 248284);
return 0;
}


int
f_22056_250824_250945(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InitializerExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 250824, 250945);
return 0;
}


int
f_22056_254087_254208(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InitializerExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 254087, 254208);
return 0;
}


int
f_22056_259095_259192(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 259095, 259192);
return 0;
}


int
f_22056_264103_264200(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 264103, 264200);
return 0;
}


int
f_22056_269111_269208(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 269111, 269208);
return 0;
}


int
f_22056_273918_274015(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 273918, 274015);
return 0;
}


int
f_22056_276359_276456(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 276359, 276456);
return 0;
}


int
f_22056_280941_281038(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 280941, 281038);
return 0;
}


int
f_22056_285489_285586(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 285489, 285586);
return 0;
}


int
f_22056_293775_293872(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 293775, 293872);
return 0;
}


int
f_22056_297776_297873(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 297776, 297873);
return 0;
}


int
f_22056_305510_305607(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 305510, 305607);
return 0;
}


int
f_22056_313244_313341(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 313244, 313341);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_314265_314311(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 314265, 314311);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_314265_314330(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 314265, 314330);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_314265_314350(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 314265, 314350);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_314540_314589(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 314540, 314589);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_314540_314609(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 314540, 314609);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_314815_314857(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 314815, 314857);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_314815_314881(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 314815, 314881);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_314815_314901(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 314815, 314901);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_315108_315154(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 315108, 315154);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_315108_315173(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 315108, 315173);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_315108_315193(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 315108, 315193);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_315399_315441(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 315399, 315441);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_315399_315465(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 315399, 315465);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_315399_315485(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 315399, 315485);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_315675_315720(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 315675, 315720);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_315675_315740(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 315675, 315740);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_315930_315975(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 315930, 315975);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_315930_315995(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 315930, 315995);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_316185_316233(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 316185, 316233);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_316185_316253(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 316185, 316253);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_316443_316488(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 316443, 316488);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_316443_316508(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 316443, 316508);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_316715_316761(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 316715, 316761);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_316715_316780(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 316715, 316780);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_316715_316800(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 316715, 316800);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_316990_317039(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 316990, 317039);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_316990_317059(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 316990, 317059);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_317249_317297(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 317249, 317297);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_317249_317317(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 317249, 317317);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_317507_317555(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 317507, 317555);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_317507_317576(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 317507, 317576);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_317766_317811(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 317766, 317811);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_317766_317832(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 317766, 317832);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_318022_318070(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 318022, 318070);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_318022_318091(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 318022, 318091);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_318281_318326(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 318281, 318326);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_318281_318347(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 318281, 318347);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_318474_318516(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 318474, 318516);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_318474_318536(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 318474, 318536);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_318659_318701(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 318659, 318701);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_318659_318721(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 318659, 318721);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_318952_319000(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 318952, 319000);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_318952_319020(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 318952, 319020);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_318952_319040(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 318952, 319040);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_319271_319319(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 319271, 319319);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_319271_319339(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 319271, 319339);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_319271_319359(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 319271, 319359);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_319576_319660(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 319576, 319660);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_319576_319680(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 319576, 319680);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_319911_319959(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 319911, 319959);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_319911_319979(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 319911, 319979);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_319911_319999(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 319911, 319999);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_320230_320278(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 320230, 320278);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_320230_320298(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 320230, 320298);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_320230_320319(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 320230, 320319);
return return_v;
}


int
f_22056_329653_329750(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 329653, 329750);
return 0;
}


int
f_22056_342287_342384(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 342287, 342384);
return 0;
}


int
f_22056_355749_355846(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 355749, 355846);
return 0;
}


int
f_22056_369752_369849(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 369752, 369849);
return 0;
}


int
f_22056_388621_388718(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 388621, 388718);
return 0;
}


int
f_22056_396296_396393(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 396296, 396393);
return 0;
}


int
f_22056_402244_402341(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 402244, 402341);
return 0;
}


int
f_22056_411671_411768(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 411671, 411768);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_412441_412527(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 412441, 412527);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_412441_412547(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 412441, 412547);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_412441_412567(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 412441, 412567);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_412720_412805(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 412720, 412805);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_412720_412825(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 412720, 412825);
return return_v;
}


int
f_22056_417706_417803(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 417706, 417803);
return 0;
}


int
f_22056_420114_420211(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 420114, 420211);
return 0;
}


int
f_22056_424628_424725(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 424628, 424725);
return 0;
}


int
f_22056_429123_429220(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 429123, 429220);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_429961_430017(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 429961, 430017);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_429961_430049(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 429961, 430049);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_429961_430070(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 429961, 430070);
return return_v;
}


int
f_22056_433220_433317(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 433220, 433317);
return 0;
}


int
f_22056_440630_440727(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 440630, 440727);
return 0;
}


int
f_22056_448047_448144(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 448047, 448144);
return 0;
}


int
f_22056_460470_460567(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 460470, 460567);
return 0;
}


int
f_22056_473721_473818(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 473721, 473818);
return 0;
}


int
f_22056_492512_492609(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 492512, 492609);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_493463_493519(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 493463, 493519);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_493463_493551(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 493463, 493551);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_493463_493572(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 493463, 493572);
return return_v;
}


int
f_22056_502153_502250(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 502153, 502250);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_502839_502888(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 502839, 502888);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_502839_502911(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 502839, 502911);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_502839_502931(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 502839, 502931);
return return_v;
}


int
f_22056_505294_505391(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 505294, 505391);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_506020_506069(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 506020, 506069);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_506020_506092(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 506020, 506092);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_506020_506112(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 506020, 506112);
return return_v;
}


int
f_22056_510508_510605(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 510508, 510605);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_511409_511454(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 511409, 511454);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_511409_511483(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 511409, 511483);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_511409_511504(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 511409, 511504);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_511645_511694(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 511645, 511694);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_511645_511717(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 511645, 511717);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_511645_511738(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 511645, 511738);
return return_v;
}


int
f_22056_516672_516769(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 516672, 516769);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_517475_517531(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 517475, 517531);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_517475_517552(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 517475, 517552);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_517714_517797(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 517714, 517797);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_517714_517818(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 517714, 517818);
return return_v;
}


int
f_22056_523527_523624(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 523527, 523624);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_524317_524373(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 524317, 524373);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_524317_524394(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 524317, 524394);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_524556_524639(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 524556, 524639);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_524556_524660(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 524556, 524660);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_524829_524884(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 524829, 524884);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_524829_524915(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 524829, 524915);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_524829_524935(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 524829, 524935);
return return_v;
}


int
f_22056_530624_530721(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 530624, 530721);
return 0;
}


int
f_22056_537178_537275(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 537178, 537275);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_538088_538174(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 538088, 538174);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_538088_538197(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 538088, 538197);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_538088_538217(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 538088, 538217);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_538375_538460(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 538375, 538460);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_538375_538480(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 538375, 538480);
return return_v;
}


int
f_22056_543393_543490(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 543393, 543490);
return 0;
}


int
f_22056_551741_551838(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 551741, 551838);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_552429_552474(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 552429, 552474);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_552429_552504(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 552429, 552504);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_552429_552524(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 552429, 552524);
return return_v;
}


int
f_22056_555943_556040(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 555943, 556040);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_556686_556737(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 556686, 556737);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_556686_556760(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 556686, 556760);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_556686_556780(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 556686, 556780);
return return_v;
}


int
f_22056_560799_560896(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 560799, 560896);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_561553_561609(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 561553, 561609);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_561553_561632(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 561553, 561632);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_561553_561652(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 561553, 561652);
return return_v;
}


int
f_22056_567946_568043(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 567946, 568043);
return 0;
}


int
f_22056_573303_573400(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 573303, 573400);
return 0;
}


int
f_22056_580444_580541(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 580444, 580541);
return 0;
}


int
f_22056_589018_589115(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 589018, 589115);
return 0;
}


int
f_22056_594302_594399(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 594302, 594399);
return 0;
}


int
f_22056_601370_601467(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 601370, 601467);
return 0;
}


int
f_22056_610327_610424(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 610327, 610424);
return 0;
}


int
f_22056_620405_620502(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 620405, 620502);
return 0;
}


int
f_22056_624994_625091(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 624994, 625091);
return 0;
}


int
f_22056_630078_630175(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 630078, 630175);
return 0;
}


int
f_22056_635162_635259(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 635162, 635259);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_635855_635899(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 635855, 635899);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_635855_635919(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 635855, 635919);
return return_v;
}


int
f_22056_639340_639437(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 639340, 639437);
return 0;
}


int
f_22056_644461_644570(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<MethodDeclarationSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 644461, 644570);
return 0;
}


int
f_22056_656405_656514(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<MethodDeclarationSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 656405, 656514);
return 0;
}


int
f_22056_670421_670530(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<MethodDeclarationSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 670421, 670530);
return 0;
}


int
f_22056_688801_688910(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<MethodDeclarationSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 688801, 688910);
return 0;
}


int
f_22056_706641_706750(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<MethodDeclarationSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 706641, 706750);
return 0;
}


int
f_22056_725378_725487(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<MethodDeclarationSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 725378, 725487);
return 0;
}


int
f_22056_740643_740752(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<MethodDeclarationSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 740643, 740752);
return 0;
}


int
f_22056_744520_744629(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<MethodDeclarationSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 744520, 744629);
return 0;
}


int
f_22056_749980_750089(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<MethodDeclarationSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 749980, 750089);
return 0;
}


int
f_22056_759150_759295(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics,bool
useLatestFrameworkReferences)
{
VerifyFlowGraphAndDiagnosticsForTest<MethodDeclarationSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics, useLatestFrameworkReferences:useLatestFrameworkReferences);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 759150, 759295);
return 0;
}


int
f_22056_769556_769701(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics,bool
useLatestFrameworkReferences)
{
VerifyFlowGraphAndDiagnosticsForTest<MethodDeclarationSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics, useLatestFrameworkReferences:useLatestFrameworkReferences);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 769556, 769701);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_770535_770590(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 770535, 770590);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_770535_770623(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 770535, 770623);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_770535_770644(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 770535, 770644);
return return_v;
}


int
f_22056_773171_773280(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<MethodDeclarationSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 773171, 773280);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_773929_773976(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 773929, 773976);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_773929_774001(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 773929, 774001);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_773929_774021(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 773929, 774021);
return return_v;
}


int
f_22056_776362_776471(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<MethodDeclarationSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 776362, 776471);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_777154_777201(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 777154, 777201);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_777154_777226(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 777154, 777226);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_777154_777246(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 777154, 777246);
return return_v;
}


int
f_22056_782249_782358(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<MethodDeclarationSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 782249, 782358);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_783024_783071(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 783024, 783071);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_783024_783096(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 783024, 783096);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_783024_783116(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 783024, 783116);
return return_v;
}


int
f_22056_787538_787647(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<MethodDeclarationSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 787538, 787647);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_788333_788378(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 788333, 788378);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_788333_788419(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 788333, 788419);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_788333_788439(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 788333, 788439);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_788623_788692(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 788623, 788692);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_788623_788712(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 788623, 788712);
return return_v;
}


int
f_22056_791361_791470(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<MethodDeclarationSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 791361, 791470);
return 0;
}


int
f_22056_798389_798498(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<MethodDeclarationSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 798389, 798498);
return 0;
}


int
f_22056_804045_804154(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<MethodDeclarationSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 804045, 804154);
return 0;
}


int
f_22056_807901_808010(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<MethodDeclarationSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 807901, 808010);
return 0;
}


int
f_22056_812900_812997(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 812900, 812997);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_813578_813641(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 813578, 813641);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_813578_813663(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 813578, 813663);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_813578_813683(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 813578, 813683);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_813849_813902(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 813849, 813902);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_813849_813924(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 813849, 813924);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_813849_813944(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 813849, 813944);
return return_v;
}


int
f_22056_815756_815853(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 815756, 815853);
return 0;
}


int
f_22056_824772_824869(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 824772, 824869);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22056_825152_825177(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 825152, 825177);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_825444_825494(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 825444, 825494);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_825444_825514(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 825444, 825514);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22056_825444_825534(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 825444, 825534);
return return_v;
}


int
f_22056_827295_827390(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<BlockSyntax>( compilation, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 827295, 827390);
return 0;
}


int
f_22056_827407_829103(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 827407, 829103);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22056_829506_829531(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 829506, 829531);
return return_v;
}


int
f_22056_829546_833552(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22056, 829546, 833552);
return 0;
}

}
}
