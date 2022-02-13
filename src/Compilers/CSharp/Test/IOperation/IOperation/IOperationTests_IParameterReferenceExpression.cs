// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp.Test.Utilities;
using Microsoft.CodeAnalysis.Test.Utilities;
using Roslyn.Test.Utilities;
using Xunit;

namespace Microsoft.CodeAnalysis.CSharp.UnitTests
{
public partial class IOperationTests : SemanticModelTestBase
{
[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(8884, "https://github.com/dotnet/roslyn/issues/8884")]
        public void ParameterReference_TupleExpression()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22057,554,2098);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,760,903);

string 
source = @"
class Class1
{
    public void M(int x, int y)
    {
        var tuple = /*<bind>*/(x, x + y)/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,917,1592);

string 
expectedOperationTree = @"
ITupleOperation (OperationKind.Tuple, Type: (System.Int32 x, System.Int32)) (Syntax: '(x, x + y)')
  NaturalType: (System.Int32 x, System.Int32)
  Elements(2):
      IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'x')
      IBinaryOperation (BinaryOperatorKind.Add) (OperationKind.Binary, Type: System.Int32) (Syntax: 'x + y')
        Left: 
          IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'x')
        Right: 
          IParameterReferenceOperation: y (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'y')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,1606,1955);

var 
expectedDiagnostics = new[] {
f_22057_1842_1939(f_22057_1842_1919(f_22057_1842_1896(ErrorCode.WRN_UnreferencedVarAssg, "tuple"), "tuple"), 6, 13)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,1971,2087);

f_22057_1971_2086(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22057,554,2098);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22057,554,2098);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22057,554,2098);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(8884, "https://github.com/dotnet/roslyn/issues/8884")]
        public void ParameterReference_TupleDeconstruction()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22057,2110,3829);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,2320,2712);

string 
source = @"
class Point
{
    public int X { get; }
    public int Y { get; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public void Deconstruct(out int x, out int y)
    {
        x = X;
        y = Y;
    }
}

class Class1
{
    public void M(Point point)
    {
        /*<bind>*/var (x, y) = point/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,2726,3614);

string 
expectedOperationTree = @"
IDeconstructionAssignmentOperation (OperationKind.DeconstructionAssignment, Type: (System.Int32 x, System.Int32 y)) (Syntax: 'var (x, y) = point')
  Left: 
    IDeclarationExpressionOperation (OperationKind.DeclarationExpression, Type: (System.Int32 x, System.Int32 y)) (Syntax: 'var (x, y)')
      ITupleOperation (OperationKind.Tuple, Type: (System.Int32 x, System.Int32 y)) (Syntax: '(x, y)')
        NaturalType: (System.Int32 x, System.Int32 y)
        Elements(2):
            ILocalReferenceOperation: x (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'x')
            ILocalReferenceOperation: y (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'y')
  Right: 
    IParameterReferenceOperation: point (OperationKind.ParameterReference, Type: Point) (Syntax: 'point')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,3628,3681);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,3697,3818);

f_22057_3697_3817(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22057,2110,3829);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22057,2110,3829);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22057,2110,3829);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(8884, "https://github.com/dotnet/roslyn/issues/8884")]
        public void ParameterReference_AnonymousObjectCreation()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22057,3841,6467);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,4055,4230);

string 
source = @"
class Class1
{
    public void M(int x, string y)
    {
        var v = /*<bind>*/new { Amount = x, Message = ""Hello"" + y }/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,4244,6239);

string 
expectedOperationTree = @"
IAnonymousObjectCreationOperation (OperationKind.AnonymousObjectCreation, Type: <anonymous type: System.Int32 Amount, System.String Message>) (Syntax: 'new { Amoun ... ello"" + y }')
  Initializers(2):
      ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'Amount = x')
        Left: 
          IPropertyReferenceOperation: System.Int32 <anonymous type: System.Int32 Amount, System.String Message>.Amount { get; } (OperationKind.PropertyReference, Type: System.Int32) (Syntax: 'Amount')
            Instance Receiver: 
              IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: <anonymous type: System.Int32 Amount, System.String Message>, IsImplicit) (Syntax: 'new { Amoun ... ello"" + y }')
        Right: 
          IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'x')
      ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.String) (Syntax: 'Message = ""Hello"" + y')
        Left: 
          IPropertyReferenceOperation: System.String <anonymous type: System.Int32 Amount, System.String Message>.Message { get; } (OperationKind.PropertyReference, Type: System.String) (Syntax: 'Message')
            Instance Receiver: 
              IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: <anonymous type: System.Int32 Amount, System.String Message>, IsImplicit) (Syntax: 'new { Amoun ... ello"" + y }')
        Right: 
          IBinaryOperation (BinaryOperatorKind.Add) (OperationKind.Binary, Type: System.String) (Syntax: '""Hello"" + y')
            Left: 
              ILiteralOperation (OperationKind.Literal, Type: System.String, Constant: ""Hello"") (Syntax: '""Hello""')
            Right: 
              IParameterReferenceOperation: y (OperationKind.ParameterReference, Type: System.String) (Syntax: 'y')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,6253,6306);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,6322,6456);

f_22057_6322_6455(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22057,3841,6467);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22057,3841,6467);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22057,3841,6467);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(8884, "https://github.com/dotnet/roslyn/issues/8884")]
        public void ParameterReference_QueryExpression()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22057,6479,10364);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,6685,7053);

string 
source = @"
using System.Linq;
using System.Collections.Generic;

struct Customer
{
    public string Name { get; set; }
    public string Address { get; set; }
}

class Class1
{
    public void M(List<Customer> customers)
    {
        var result = /*<bind>*/from cust in customers
                     select cust.Name/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,7067,10154);

string 
expectedOperationTree = @"
ITranslatedQueryOperation (OperationKind.TranslatedQuery, Type: System.Collections.Generic.IEnumerable<System.String>) (Syntax: 'from cust i ... t cust.Name')
  Expression: 
    IInvocationOperation (System.Collections.Generic.IEnumerable<System.String> System.Linq.Enumerable.Select<Customer, System.String>(this System.Collections.Generic.IEnumerable<Customer> source, System.Func<Customer, System.String> selector)) (OperationKind.Invocation, Type: System.Collections.Generic.IEnumerable<System.String>, IsImplicit) (Syntax: 'select cust.Name')
      Instance Receiver: 
        null
      Arguments(2):
          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: source) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'from cust in customers')
            IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Collections.Generic.IEnumerable<Customer>, IsImplicit) (Syntax: 'from cust in customers')
              Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
              Operand: 
                IParameterReferenceOperation: customers (OperationKind.ParameterReference, Type: System.Collections.Generic.List<Customer>) (Syntax: 'customers')
            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: selector) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'cust.Name')
            IDelegateCreationOperation (OperationKind.DelegateCreation, Type: System.Func<Customer, System.String>, IsImplicit) (Syntax: 'cust.Name')
              Target: 
                IAnonymousFunctionOperation (Symbol: lambda expression) (OperationKind.AnonymousFunction, Type: null, IsImplicit) (Syntax: 'cust.Name')
                  IBlockOperation (1 statements) (OperationKind.Block, Type: null, IsImplicit) (Syntax: 'cust.Name')
                    IReturnOperation (OperationKind.Return, Type: null, IsImplicit) (Syntax: 'cust.Name')
                      ReturnedValue: 
                        IPropertyReferenceOperation: System.String Customer.Name { get; set; } (OperationKind.PropertyReference, Type: System.String) (Syntax: 'cust.Name')
                          Instance Receiver: 
                            IParameterReferenceOperation: cust (OperationKind.ParameterReference, Type: Customer) (Syntax: 'cust')
            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,10168,10221);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,10237,10353);

f_22057_10237_10352(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22057,6479,10364);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22057,6479,10364);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22057,6479,10364);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(8884, "https://github.com/dotnet/roslyn/issues/8884")]
        public void ParameterReference_ObjectAndCollectionInitializer()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22057,10376,20428);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,10597,11004);

string 
source = @"
using System.Collections.Generic;

internal class Class
{
    public int X { get; set; }
    public List<int> Y { get; set; }
    public Dictionary<int, int> Z { get; set; }
    public Class C { get; set; }

    public void M(int x, int y, int z)
    {
        var c = /*<bind>*/new Class() { X = x, Y = { x, y, 3 }, Z = { { x, y } }, C = { X = z } }/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,11018,20209);

string 
expectedOperationTree = @"
IObjectCreationOperation (Constructor: Class..ctor()) (OperationKind.ObjectCreation, Type: Class) (Syntax: 'new Class() ... { X = z } }')
  Arguments(0)
  Initializer: 
    IObjectOrCollectionInitializerOperation (OperationKind.ObjectOrCollectionInitializer, Type: Class) (Syntax: '{ X = x, Y  ... { X = z } }')
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
                            IParameterReferenceOperation: y (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'y')
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
                            IParameterReferenceOperation: y (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'y')
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
          IMemberInitializerOperation (OperationKind.MemberInitializer, Type: Class) (Syntax: 'C = { X = z }')
            InitializedMember: 
              IPropertyReferenceOperation: Class Class.C { get; set; } (OperationKind.PropertyReference, Type: Class) (Syntax: 'C')
                Instance Receiver: 
                  IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: Class, IsImplicit) (Syntax: 'C')
            Initializer: 
              IObjectOrCollectionInitializerOperation (OperationKind.ObjectOrCollectionInitializer, Type: Class) (Syntax: '{ X = z }')
                Initializers(1):
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'X = z')
                      Left: 
                        IPropertyReferenceOperation: System.Int32 Class.X { get; set; } (OperationKind.PropertyReference, Type: System.Int32) (Syntax: 'X')
                          Instance Receiver: 
                            IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: Class, IsImplicit) (Syntax: 'X')
                      Right: 
                        IParameterReferenceOperation: z (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'z')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,20223,20276);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,20292,20417);

f_22057_20292_20416(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22057,10376,20428);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22057,10376,20428);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22057,10376,20428);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(8884, "https://github.com/dotnet/roslyn/issues/8884")]
        public void ParameterReference_DelegateCreationExpressionWithLambdaArgument()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22057,20440,22127);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,20675,20927);

string 
source = @"
using System;

class Class
{
    // Used parameter methods
    public void UsedParameterMethod1(Action a)
    {
        Action a2 = /*<bind>*/new Action(() =>
        {
            a();
        })/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,20941,21908);

string 
expectedOperationTree = @"
IDelegateCreationOperation (OperationKind.DelegateCreation, Type: System.Action) (Syntax: 'new Action( ... })')
  Target: 
    IAnonymousFunctionOperation (Symbol: lambda expression) (OperationKind.AnonymousFunction, Type: null) (Syntax: '() => ... }')
      IBlockOperation (2 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'a();')
          Expression: 
            IInvocationOperation (virtual void System.Action.Invoke()) (OperationKind.Invocation, Type: System.Void) (Syntax: 'a()')
              Instance Receiver: 
                IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Action) (Syntax: 'a')
              Arguments(0)
        IReturnOperation (OperationKind.Return, Type: null, IsImplicit) (Syntax: '{ ... }')
          ReturnedValue: 
            null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,21922,21975);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,21991,22116);

f_22057_21991_22115(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22057,20440,22127);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22057,20440,22127);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22057,20440,22127);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(8884, "https://github.com/dotnet/roslyn/issues/8884")]
        public void ParameterReference_DelegateCreationExpressionWithMethodArgument()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22057,22139,23379);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,22374,22650);

string 
source = @"
using System;

class Class
{
    public delegate void Delegate(int x, int y);

    public void Method(Delegate d)
    {
        var a = /*<bind>*/new Delegate(Method2)/*</bind>*/;
    }

    public void Method2(int x, int y)
    {
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,22664,23160);

string 
expectedOperationTree = @"
IDelegateCreationOperation (OperationKind.DelegateCreation, Type: Class.Delegate) (Syntax: 'new Delegate(Method2)')
  Target: 
    IMethodReferenceOperation: void Class.Method2(System.Int32 x, System.Int32 y) (OperationKind.MethodReference, Type: null) (Syntax: 'Method2')
      Instance Receiver: 
        IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: Class, IsImplicit) (Syntax: 'Method2')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,23174,23227);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,23243,23368);

f_22057_23243_23367(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22057,22139,23379);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22057,22139,23379);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22057,22139,23379);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(8884, "https://github.com/dotnet/roslyn/issues/8884")]
        public void ParameterReference_DelegateCreationExpressionWithInvalidArgument()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22057,23391,24575);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,23627,23837);

string 
source = @"
using System;

class Class
{
    public delegate void Delegate(int x, int y);

    public void Method(int x)
    {
        var a = /*<bind>*/new Delegate(x)/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,23851,24127);

string 
expectedOperationTree = @"
IInvalidOperation (OperationKind.Invalid, Type: Class.Delegate, IsInvalid) (Syntax: 'new Delegate(x)')
  Children(1):
      IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32, IsInvalid) (Syntax: 'x')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,24141,24423);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22057_24337_24407(f_22057_24337_24386(ErrorCode.ERR_MethodNameExpected, "x"), 10, 40)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,24439,24564);

f_22057_24439_24563(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22057,23391,24575);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22057,23391,24575);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22057,23391,24575);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(8884, "https://github.com/dotnet/roslyn/issues/8884")]
        public void ParameterReference_DynamicCollectionInitializer()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22057,24587,27048);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,24806,25050);

string 
source = @"
using System.Collections.Generic;

internal class Class
{
    public dynamic X { get; set; }

    public void M(int x, int y)
    {
        var c = new Class() /*<bind>*/{ X = { { x, y } } }/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,25064,26832);

string 
expectedOperationTree = @"
IObjectOrCollectionInitializerOperation (OperationKind.ObjectOrCollectionInitializer, Type: Class) (Syntax: '{ X = { { x, y } } }')
  Initializers(1):
      IMemberInitializerOperation (OperationKind.MemberInitializer, Type: dynamic) (Syntax: 'X = { { x, y } }')
        InitializedMember: 
          IPropertyReferenceOperation: dynamic Class.X { get; set; } (OperationKind.PropertyReference, Type: dynamic) (Syntax: 'X')
            Instance Receiver: 
              IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: Class, IsImplicit) (Syntax: 'X')
        Initializer: 
          IObjectOrCollectionInitializerOperation (OperationKind.ObjectOrCollectionInitializer, Type: dynamic) (Syntax: '{ { x, y } }')
            Initializers(1):
                IDynamicInvocationOperation (OperationKind.DynamicInvocation, Type: System.Void) (Syntax: '{ x, y }')
                  Expression: 
                    IDynamicMemberReferenceOperation (Member Name: ""Add"", Containing Type: null) (OperationKind.DynamicMemberReference, Type: null, IsImplicit) (Syntax: 'X')
                      Type Arguments(0)
                      Instance Receiver: 
                        IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: dynamic, IsImplicit) (Syntax: 'X')
                  Arguments(2):
                      IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'x')
                      IParameterReferenceOperation: y (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'y')
                  ArgumentNames(0)
                  ArgumentRefKinds(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,26846,26899);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,26915,27037);

f_22057_26915_27036(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22057,24587,27048);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22057,24587,27048);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22057,24587,27048);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(8884, "https://github.com/dotnet/roslyn/issues/8884")]
        public void ParameterReference_NameOfExpression()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22057,27060,27870);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,27267,27399);

string 
source = @"
class Class1
{
    public string M(int x)
    {
        return /*<bind>*/nameof(x)/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,27413,27655);

string 
expectedOperationTree = @"
INameOfOperation (OperationKind.NameOf, Type: System.String, Constant: ""x"") (Syntax: 'nameof(x)')
  IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'x')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,27669,27722);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,27738,27859);

f_22057_27738_27858(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22057,27060,27870);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22057,27060,27870);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22057,27060,27870);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(8884, "https://github.com/dotnet/roslyn/issues/8884")]
        public void ParameterReference_PointerIndirectionExpression()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22057,27882,28919);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,28101,28231);

string 
source = @"
class Class1
{
    public unsafe int M(int *x)
    {
        return /*<bind>*/*x/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,28245,28469);

string 
expectedOperationTree = @"
IOperation:  (OperationKind.None, Type: null) (Syntax: '*x')
  Children(1):
      IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32*) (Syntax: 'x')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,28483,28770);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22057_28690_28754(f_22057_28690_28734(ErrorCode.ERR_IllegalUnsafe, "M"), 4, 23)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,28786,28908);

f_22057_28786_28907(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22057,27882,28919);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22057,27882,28919);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22057,27882,28919);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(8884, "https://github.com/dotnet/roslyn/issues/8884")]
        public void ParameterReference_FixedLocalInitializer()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22057,28931,30357);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,29143,29379);

string 
source = @"
using System.Collections.Generic;

internal class Class
{
    public unsafe void M(int[] array)
    {
        fixed (int* /*<bind>*/p = array/*</bind>*/)
        {
            *p = 1;
        }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,29393,29904);

string 
expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: System.Int32* p) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'p = array')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= array')
      IOperation:  (OperationKind.None, Type: null, IsImplicit) (Syntax: 'array')
        Children(1):
            IParameterReferenceOperation: array (OperationKind.ParameterReference, Type: System.Int32[]) (Syntax: 'array')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,29918,30211);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22057_30131_30195(f_22057_30131_30175(ErrorCode.ERR_IllegalUnsafe, "M"), 6, 24)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,30227,30346);

f_22057_30227_30345(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22057,28931,30357);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22057,28931,30357);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22057,28931,30357);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(8884, "https://github.com/dotnet/roslyn/issues/8884")]
        public void ParameterReference_RefTypeOperator()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22057,30369,31201);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,30575,30733);

string 
source = @"
class Class1
{
    public System.Type M(System.TypedReference x)
    {
        return /*<bind>*/__reftype(x)/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,30747,30989);

string 
expectedOperationTree = @"
IOperation:  (OperationKind.None, Type: null) (Syntax: '__reftype(x)')
  Children(1):
      IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.TypedReference) (Syntax: 'x')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,31003,31056);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,31072,31190);

f_22057_31072_31189(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22057,30369,31201);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22057,30369,31201);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22057,30369,31201);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(8884, "https://github.com/dotnet/roslyn/issues/8884")]
        public void ParameterReference_MakeRefOperator()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22057,31213,32019);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,31419,31561);

string 
source = @"
class Class1
{
    public void M(System.Type x)
    {
        var y = /*<bind>*/__makeref(x)/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,31575,31807);

string 
expectedOperationTree = @"
IOperation:  (OperationKind.None, Type: null) (Syntax: '__makeref(x)')
  Children(1):
      IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Type) (Syntax: 'x')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,31821,31874);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,31890,32008);

f_22057_31890_32007(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22057,31213,32019);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22057,31213,32019);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22057,31213,32019);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(8884, "https://github.com/dotnet/roslyn/issues/8884")]
        public void ParameterReference_RefValueOperator()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22057,32031,32871);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,32238,32396);

string 
source = @"
class Class1
{
    public void M(System.TypedReference x)
    {
        var y = /*<bind>*/__refvalue(x, int)/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,32410,32658);

string 
expectedOperationTree = @"
IOperation:  (OperationKind.None, Type: null) (Syntax: '__refvalue(x, int)')
  Children(1):
      IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.TypedReference) (Syntax: 'x')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,32672,32725);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,32741,32860);

f_22057_32741_32859(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22057,32031,32871);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22057,32031,32871);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22057,32031,32871);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(8884, "https://github.com/dotnet/roslyn/issues/8884")]
        public void ParameterReference_DynamicIndexerAccess()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22057,32883,34160);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,33094,33231);

string 
source = @"
class Class1
{
    public void M(dynamic d, int x)
    {
        var /*<bind>*/y = d[x]/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,33245,33947);

string 
expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: dynamic y) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'y = d[x]')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= d[x]')
      IDynamicIndexerAccessOperation (OperationKind.DynamicIndexerAccess, Type: dynamic) (Syntax: 'd[x]')
        Expression: 
          IParameterReferenceOperation: d (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'd')
        Arguments(1):
            IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'x')
        ArgumentNames(0)
        ArgumentRefKinds(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,33961,34014);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,34030,34149);

f_22057_34030_34148(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22057,32883,34160);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22057,32883,34160);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22057,32883,34160);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(8884, "https://github.com/dotnet/roslyn/issues/8884")]
        public void ParameterReference_DynamicMemberAccess()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22057,34172,35377);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,34382,34521);

string 
source = @"
class Class1
{
    public void M(dynamic x, int y)
    {
        var z = /*<bind>*/x.M(y)/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,34535,35162);

string 
expectedOperationTree = @"
IDynamicInvocationOperation (OperationKind.DynamicInvocation, Type: dynamic) (Syntax: 'x.M(y)')
  Expression: 
    IDynamicMemberReferenceOperation (Member Name: ""M"", Containing Type: null) (OperationKind.DynamicMemberReference, Type: dynamic) (Syntax: 'x.M')
      Type Arguments(0)
      Instance Receiver: 
        IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'x')
  Arguments(1):
      IParameterReferenceOperation: y (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'y')
  ArgumentNames(0)
  ArgumentRefKinds(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,35176,35229);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,35245,35366);

f_22057_35245_35365(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22057,34172,35377);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22057,34172,35377);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22057,34172,35377);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(8884, "https://github.com/dotnet/roslyn/issues/8884")]
        public void ParameterReference_DynamicInvocation()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22057,35389,36380);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,35597,35734);

string 
source = @"
class Class1
{
    public void M(dynamic x, int y)
    {
        var z = /*<bind>*/x(y)/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,35748,36165);

string 
expectedOperationTree = @"
IDynamicInvocationOperation (OperationKind.DynamicInvocation, Type: dynamic) (Syntax: 'x(y)')
  Expression: 
    IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'x')
  Arguments(1):
      IParameterReferenceOperation: y (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'y')
  ArgumentNames(0)
  ArgumentRefKinds(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,36179,36232);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,36248,36369);

f_22057_36248_36368(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22057,35389,36380);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22057,35389,36380);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22057,35389,36380);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(8884, "https://github.com/dotnet/roslyn/issues/8884")]
        public void ParameterReference_DynamicObjectCreation()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22057,36392,37384);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,36604,36815);

string 
source = @"
internal class Class
{
    public Class(Class x) { }
    public Class(string x) { }

    public void M(dynamic x)
    {
        var c = /*<bind>*/new Class(x)/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,36829,37165);

string 
expectedOperationTree = @"
IDynamicObjectCreationOperation (OperationKind.DynamicObjectCreation, Type: Class) (Syntax: 'new Class(x)')
  Arguments(1):
      IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'x')
  ArgumentNames(0)
  ArgumentRefKinds(0)
  Initializer: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,37179,37232);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,37248,37373);

f_22057_37248_37372(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22057,36392,37384);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22057,36392,37384);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22057,36392,37384);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(8884, "https://github.com/dotnet/roslyn/issues/8884")]
        public void ParameterReference_StackAllocArrayCreation()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22057,37396,38520);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,37610,37806);

string 
source = @"
using System.Collections.Generic;

internal class Class
{
    public unsafe void M(int x)
    {
        int* block = /*<bind>*/stackalloc int[x]/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,37820,38058);

string 
expectedOperationTree = @"
IOperation:  (OperationKind.None, Type: null) (Syntax: 'stackalloc int[x]')
  Children(1):
      IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'x')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,38072,38359);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22057_38279_38343(f_22057_38279_38323(ErrorCode.ERR_IllegalUnsafe, "M"), 6, 24)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,38375,38509);

f_22057_38375_38508(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22057,37396,38520);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22057,37396,38520);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22057,37396,38520);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(8884, "https://github.com/dotnet/roslyn/issues/8884")]
        public void ParameterReference_InterpolatedStringExpression()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22057,38532,41236);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,38751,38965);

string 
source = @"
using System;

internal class Class
{
    public void M(string x, int y)
    {
        Console.WriteLine(/*<bind>*/$""String {x,20} and {y:D3} and constant {1}""/*</bind>*/);
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,38979,41013);

string 
expectedOperationTree = @"
IInterpolatedStringOperation (OperationKind.InterpolatedString, Type: System.String) (Syntax: '$""String {x ... nstant {1}""')
  Parts(6):
      IInterpolatedStringTextOperation (OperationKind.InterpolatedStringText, Type: null) (Syntax: 'String ')
        Text: 
          ILiteralOperation (OperationKind.Literal, Type: System.String, Constant: ""String "", IsImplicit) (Syntax: 'String ')
      IInterpolationOperation (OperationKind.Interpolation, Type: null) (Syntax: '{x,20}')
        Expression: 
          IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.String) (Syntax: 'x')
        Alignment: 
          ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 20) (Syntax: '20')
        FormatString: 
          null
      IInterpolatedStringTextOperation (OperationKind.InterpolatedStringText, Type: null) (Syntax: ' and ')
        Text: 
          ILiteralOperation (OperationKind.Literal, Type: System.String, Constant: "" and "", IsImplicit) (Syntax: ' and ')
      IInterpolationOperation (OperationKind.Interpolation, Type: null) (Syntax: '{y:D3}')
        Expression: 
          IParameterReferenceOperation: y (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'y')
        Alignment: 
          null
        FormatString: 
          ILiteralOperation (OperationKind.Literal, Type: System.String, Constant: ""D3"") (Syntax: ':D3')
      IInterpolatedStringTextOperation (OperationKind.InterpolatedStringText, Type: null) (Syntax: ' and constant ')
        Text: 
          ILiteralOperation (OperationKind.Literal, Type: System.String, Constant: "" and constant "", IsImplicit) (Syntax: ' and constant ')
      IInterpolationOperation (OperationKind.Interpolation, Type: null) (Syntax: '{1}')
        Expression: 
          ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
        Alignment: 
          null
        FormatString: 
          null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,41027,41080);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,41096,41225);

f_22057_41096_41224(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22057,38532,41236);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22057,38532,41236);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22057,38532,41236);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(8884, "https://github.com/dotnet/roslyn/issues/8884")]
        public void ParameterReference_ThrowExpression()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22057,41248,43298);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,41454,41651);

string 
source = @"
using System;

internal class Class
{
    public void M(string x)
    {
        var y = x ?? /*<bind>*/throw new ArgumentNullException(nameof(x))/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,41665,43088);

string 
expectedOperationTree = @"
IThrowOperation (OperationKind.Throw, Type: null) (Syntax: 'throw new A ... (nameof(x))')
  IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Exception, IsImplicit) (Syntax: 'new Argumen ... (nameof(x))')
    Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
    Operand: 
      IObjectCreationOperation (Constructor: System.ArgumentNullException..ctor(System.String paramName)) (OperationKind.ObjectCreation, Type: System.ArgumentNullException) (Syntax: 'new Argumen ... (nameof(x))')
        Arguments(1):
            IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: paramName) (OperationKind.Argument, Type: null) (Syntax: 'nameof(x)')
              INameOfOperation (OperationKind.NameOf, Type: System.String, Constant: ""x"") (Syntax: 'nameof(x)')
                IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.String) (Syntax: 'x')
              InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
              OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Initializer: 
          null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,43102,43155);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,43171,43287);

f_22057_43171_43286(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22057,41248,43298);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22057,41248,43298);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22057,41248,43298);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(8884, "https://github.com/dotnet/roslyn/issues/8884")]
        public void ParameterReference_PatternSwitchStatement()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22057,43310,45105);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,43523,43740);

string 
source = @"
internal class Class
{
    public void M(int x)
    {
        switch (x)
        {
            /*<bind>*/case var y when (x >= 10):
                break;/*</bind>*/
        }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,43754,44897);

string 
expectedOperationTree = @"
ISwitchCaseOperation (1 case clauses, 1 statements) (OperationKind.SwitchCase, Type: null) (Syntax: 'case var y  ... break;')
  Locals: Local_1: System.Int32 y
    Clauses:
        IPatternCaseClauseOperation (Label Id: 0) (CaseKind.Pattern) (OperationKind.CaseClause, Type: null) (Syntax: 'case var y  ...  (x >= 10):')
          Pattern: 
            IDeclarationPatternOperation (OperationKind.DeclarationPattern, Type: null) (Syntax: 'var y') (InputType: System.Int32, NarrowedType: System.Int32, DeclaredSymbol: System.Int32 y, MatchesNull: True)
          Guard: 
            IBinaryOperation (BinaryOperatorKind.GreaterThanOrEqual) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'x >= 10')
              Left: 
                IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'x')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 10) (Syntax: '10')
    Body:
        IBranchOperation (BranchKind.Break, Label Id: 1) (OperationKind.Branch, Type: null) (Syntax: 'break;')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,44911,44964);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,44980,45094);

f_22057_44980_45093(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22057,43310,45105);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22057,43310,45105);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22057,43310,45105);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(8884, "https://github.com/dotnet/roslyn/issues/8884")]
        public void ParameterReference_DefaultPatternSwitchStatement()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22057,45117,45988);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,45337,45602);

string 
source = @"
internal class Class
{
    public void M(int x)
    {
        switch (x)
        {
            case var y when (x >= 10):
                break;

            /*<bind>*/default:/*</bind>*/
                break;
        }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,45616,45775);

string 
expectedOperationTree = @"
IDefaultCaseClauseOperation (Label Id: 0) (CaseKind.Default) (OperationKind.CaseClause, Type: null) (Syntax: 'default:')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,45789,45842);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,45858,45977);

f_22057_45858_45976(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22057,45117,45988);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22057,45117,45988);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22057,45117,45988);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(8884, "https://github.com/dotnet/roslyn/issues/8884")]
        public void ParameterReference_UserDefinedLogicalConditionalOperator()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22057,46000,47874);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,46228,46676);

string 
source = @"
class A<T>
{
    public static bool operator true(A<T> o) { return true; }
    public static bool operator false(A<T> o) { return false; }
}
class B : A<object>
{
    public static B operator &(B x, B y) { return x; }
}
class C : B
{
    public static C operator |(C x, C y) { return x; }
}
class P
{
    static void M(C x, C y)
    {
        if (/*<bind>*/x && y/*</bind>*/)
        {
        }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,46690,47663);

string 
expectedOperationTree = @"
IBinaryOperation (BinaryOperatorKind.ConditionalAnd) (OperatorMethod: B B.op_BitwiseAnd(B x, B y)) (OperationKind.Binary, Type: B) (Syntax: 'x && y')
  Left: 
    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: B, IsImplicit) (Syntax: 'x')
      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
      Operand: 
        IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: C) (Syntax: 'x')
  Right: 
    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: B, IsImplicit) (Syntax: 'y')
      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
      Operand: 
        IParameterReferenceOperation: y (OperationKind.ParameterReference, Type: C) (Syntax: 'y')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,47677,47730);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,47746,47863);

f_22057_47746_47862(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22057,46000,47874);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22057,46000,47874);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22057,46000,47874);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [WorkItem(8884, "https://github.com/dotnet/roslyn/issues/8884")]
        [ConditionalFact(typeof(DesktopOnly), Reason = ConditionalSkipReason.RestrictedTypesNeedDesktop)]
        public void ParameterReference_NoPiaObjectCreation()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22057,47886,49777);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,48197,48650);

var 
sources0 = @"
using System;
using System.Runtime.InteropServices;

[assembly: ImportedFromTypeLib(""_.dll"")]
[assembly: Guid(""f9c2d51d-4f44-45f0-9eda-c9d599b58257"")]
[ComImport()]
[Guid(""f9c2d51d-4f44-45f0-9eda-c9d599b58277"")]
[CoClass(typeof(C))]
public interface I
        {
            int P { get; set; }
        }
[Guid(""f9c2d51d-4f44-45f0-9eda-c9d599b58278"")]
public class C
{
    public C(object o)
    {
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,48664,48776);

var 
sources1 = @"
struct S
{
	public I F(object x)
	{
		return /*<bind>*/new I(x)/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,48790,48837);

var 
compilation0 = f_22057_48809_48836(sources0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,48851,48884);

f_22057_48851_48883(            compilation0);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,48900,49093);

var 
compilation1 = f_22057_48919_49092(sources1, references: new[] { f_22057_49007_49018(), f_22057_49020_49029(), f_22057_49031_49089(compilation0, embedInteropTypes: true)})
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,49109,49266);

string 
expectedOperationTree = @"
INoPiaObjectCreationOperation (OperationKind.None, Type: I, IsInvalid) (Syntax: 'new I(x)')
  Initializer: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,49280,49619);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22057_49513_49603(f_22057_49513_49583(f_22057_49513_49559(ErrorCode.ERR_BadCtorArgCount, "I"), "I", "1"), 6, 24)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,49635,49766);

f_22057_49635_49765(compilation1, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22057,47886,49777);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22057,47886,49777);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22057,47886,49777);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(8884, "https://github.com/dotnet/roslyn/issues/8884")]
        public void ParameterReference_ArgListOperator()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22057,49789,50786);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,49995,50211);

string 
source = @"
using System;
class C
{
    static void Method(int x, bool y)
    {
        M(1, /*<bind>*/__arglist(x, y)/*</bind>*/);
    }
    
    static void M(int x, __arglist)
    {
    } 
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,50225,50571);

string 
expectedOperationTree = @"
IOperation:  (OperationKind.None, Type: null) (Syntax: '__arglist(x, y)')
  Children(2):
      IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'x')
      IParameterReferenceOperation: y (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'y')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,50585,50638);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,50654,50775);

f_22057_50654_50774(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22057,49789,50786);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22057,49789,50786);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22057,49789,50786);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(19790, "https://github.com/dotnet/roslyn/issues/19790")]
        public void ParameterReference_IsPatternExpression()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22057,50798,51845);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,51010,51151);

string 
source = @"
class Class1
{
    public void Method1(object x)
    {
        if (/*<bind>*/x is int y/*</bind>*/) { }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,51165,51631);

string 
expectedOperationTree = @"
IIsPatternOperation (OperationKind.IsPattern, Type: System.Boolean) (Syntax: 'x is int y')
  Value: 
    IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'x')
  Pattern: 
    IDeclarationPatternOperation (OperationKind.DeclarationPattern, Type: null) (Syntax: 'int y') (InputType: System.Object, NarrowedType: System.Int32, DeclaredSymbol: System.Int32 y, MatchesNull: False)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,51645,51698);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,51714,51834);

f_22057_51714_51833(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22057,50798,51845);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22057,50798,51845);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22057,50798,51845);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(19902, "https://github.com/dotnet/roslyn/issues/19902")]
        public void ParameterReference_LocalFunctionStatement()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22057,51857,55525);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,52072,52507);

string 
source = @"
using System;
using System.Collections.Generic;

class Class
{
    static IEnumerable<T> MyIterator<T>(IEnumerable<T> source, Func<T, bool> predicate)
    {
        /*<bind>*/IEnumerable<T> Iterator()
        {
            foreach (var element in source)
                if (predicate(element))
                    yield return element;
        }/*</bind>*/

        return Iterator();
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,52521,55308);

string 
expectedOperationTree = @"
ILocalFunctionOperation (Symbol: System.Collections.Generic.IEnumerable<T> Iterator()) (OperationKind.LocalFunction, Type: null) (Syntax: 'IEnumerable ... }')
  IBlockOperation (2 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
    IForEachLoopOperation (LoopKind.ForEach, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'foreach (va ... rn element;')
      Locals: Local_1: T element
      LoopControlVariable: 
        IVariableDeclaratorOperation (Symbol: T element) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'var')
          Initializer: 
            null
      Collection: 
        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Collections.Generic.IEnumerable<T>, IsImplicit) (Syntax: 'source')
          Conversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
          Operand: 
            IParameterReferenceOperation: source (OperationKind.ParameterReference, Type: System.Collections.Generic.IEnumerable<T>) (Syntax: 'source')
      Body: 
        IConditionalOperation (OperationKind.Conditional, Type: null) (Syntax: 'if (predica ... rn element;')
          Condition: 
            IInvocationOperation (virtual System.Boolean System.Func<T, System.Boolean>.Invoke(T arg)) (OperationKind.Invocation, Type: System.Boolean) (Syntax: 'predicate(element)')
              Instance Receiver: 
                IParameterReferenceOperation: predicate (OperationKind.ParameterReference, Type: System.Func<T, System.Boolean>) (Syntax: 'predicate')
              Arguments(1):
                  IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: arg) (OperationKind.Argument, Type: null) (Syntax: 'element')
                    ILocalReferenceOperation: element (OperationKind.LocalReference, Type: T) (Syntax: 'element')
                    InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
          WhenTrue: 
            IReturnOperation (OperationKind.YieldReturn, Type: null) (Syntax: 'yield return element;')
              ReturnedValue: 
                ILocalReferenceOperation: element (OperationKind.LocalReference, Type: T) (Syntax: 'element')
          WhenFalse: 
            null
      NextVariables(0)
    IReturnOperation (OperationKind.YieldBreak, Type: null, IsImplicit) (Syntax: '{ ... }')
      ReturnedValue: 
        null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,55322,55375);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22057,55391,55514);

f_22057_55391_55513(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22057,51857,55525);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22057,51857,55525);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22057,51857,55525);
}
		}

Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22057_1842_1896(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22057, 1842, 1896);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22057_1842_1919(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22057, 1842, 1919);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22057_1842_1939(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22057, 1842, 1939);
return return_v;
}


int
f_22057_1971_2086(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<TupleExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22057, 1971, 2086);
return 0;
}


int
f_22057_3697_3817(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<AssignmentExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22057, 3697, 3817);
return 0;
}


int
f_22057_6322_6455(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<AnonymousObjectCreationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22057, 6322, 6455);
return 0;
}


int
f_22057_10237_10352(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<QueryExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22057, 10237, 10352);
return 0;
}


int
f_22057_20292_20416(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ObjectCreationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22057, 20292, 20416);
return 0;
}


int
f_22057_21991_22115(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ObjectCreationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22057, 21991, 22115);
return 0;
}


int
f_22057_23243_23367(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ObjectCreationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22057, 23243, 23367);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22057_24337_24386(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22057, 24337, 24386);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22057_24337_24407(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22057, 24337, 24407);
return return_v;
}


int
f_22057_24439_24563(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ObjectCreationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22057, 24439, 24563);
return 0;
}


int
f_22057_26915_27036(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InitializerExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22057, 26915, 27036);
return 0;
}


int
f_22057_27738_27858(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InvocationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22057, 27738, 27858);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22057_28690_28734(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22057, 28690, 28734);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22057_28690_28754(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22057, 28690, 28754);
return return_v;
}


int
f_22057_28786_28907(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22057, 28786, 28907);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22057_30131_30175(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22057, 30131, 30175);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22057_30131_30195(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22057, 30131, 30195);
return return_v;
}


int
f_22057_30227_30345(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22057, 30227, 30345);
return 0;
}


int
f_22057_31072_31189(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<RefTypeExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22057, 31072, 31189);
return 0;
}


int
f_22057_31890_32007(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<MakeRefExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22057, 31890, 32007);
return 0;
}


int
f_22057_32741_32859(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<RefValueExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22057, 32741, 32859);
return 0;
}


int
f_22057_34030_34148(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22057, 34030, 34148);
return 0;
}


int
f_22057_35245_35365(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InvocationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22057, 35245, 35365);
return 0;
}


int
f_22057_36248_36368(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InvocationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22057, 36248, 36368);
return 0;
}


int
f_22057_37248_37372(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ObjectCreationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22057, 37248, 37372);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22057_38279_38323(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22057, 38279, 38323);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22057_38279_38343(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22057, 38279, 38343);
return return_v;
}


int
f_22057_38375_38508(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<StackAllocArrayCreationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22057, 38375, 38508);
return 0;
}


int
f_22057_41096_41224(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InterpolatedStringExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22057, 41096, 41224);
return 0;
}


int
f_22057_43171_43286(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ThrowExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22057, 43171, 43286);
return 0;
}


int
f_22057_44980_45093(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<SwitchSectionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22057, 44980, 45093);
return 0;
}


int
f_22057_45858_45976(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<DefaultSwitchLabelSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22057, 45858, 45976);
return 0;
}


int
f_22057_47746_47862(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<BinaryExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22057, 47746, 47862);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22057_48809_48836(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22057, 48809, 48836);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22057_48851_48883(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22057, 48851, 48883);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_22057_49007_49018()
{
var return_v = MscorlibRef;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22057, 49007, 49018);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_22057_49020_49029()
{
var return_v = SystemRef;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22057, 49020, 49029);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_22057_49031_49089(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
comp,bool
embedInteropTypes)
{
var return_v = comp.EmitToImageReference( embedInteropTypes:embedInteropTypes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22057, 49031, 49089);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22057_48919_49092(string
source,Microsoft.CodeAnalysis.MetadataReference[]
references)
{
var return_v = CreateEmptyCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22057, 48919, 49092);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22057_49513_49559(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22057, 49513, 49559);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22057_49513_49583(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22057, 49513, 49583);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22057_49513_49603(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22057, 49513, 49603);
return return_v;
}


int
f_22057_49635_49765(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ObjectCreationExpressionSyntax>( compilation, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22057, 49635, 49765);
return 0;
}


int
f_22057_50654_50774(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InvocationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22057, 50654, 50774);
return 0;
}


int
f_22057_51714_51833(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<IsPatternExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22057, 51714, 51833);
return 0;
}


int
f_22057_55391_55513(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<LocalFunctionStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22057, 55391, 55513);
return 0;
}

}
}
