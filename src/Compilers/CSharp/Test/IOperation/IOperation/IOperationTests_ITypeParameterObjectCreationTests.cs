// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Test.Utilities;
using Xunit;

namespace Microsoft.CodeAnalysis.CSharp.UnitTests
{
public partial class IOperationTests : SemanticModelTestBase
{
[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void TypeParameterObjectCreation_Simple()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22072,471,1159);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22072,613,750);

string 
source = @"
class C1
{
    void M<T>(T t1) where T : C1, new()
    {
        t1 = /*<bind>*/new T()/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22072,764,817);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22072,833,1009);

string 
expectedOperationTree = @"
ITypeParameterObjectCreationOperation (OperationKind.TypeParameterObjectCreation, Type: T) (Syntax: 'new T()')
  Initializer: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22072,1023,1148);

f_22072_1023_1147(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22072,471,1159);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22072,471,1159);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22072,471,1159);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void TypeParameterObjectCreation_WithObjectInitializer()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22072,1171,2640);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22072,1328,1500);

string 
source = @"
class C1
{
    void M<T>(T t1) where T : C1, new()
    {
        t1 = /*<bind>*/new T() { I = 1 }/*</bind>*/;
    }
    int I { get; set; }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22072,1514,1567);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22072,1583,2490);

string 
expectedOperationTree = @"
ITypeParameterObjectCreationOperation (OperationKind.TypeParameterObjectCreation, Type: T) (Syntax: 'new T() { I = 1 }')
  Initializer: 
    IObjectOrCollectionInitializerOperation (OperationKind.ObjectOrCollectionInitializer, Type: T) (Syntax: '{ I = 1 }')
      Initializers(1):
          ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'I = 1')
            Left: 
              IPropertyReferenceOperation: System.Int32 C1.I { get; set; } (OperationKind.PropertyReference, Type: System.Int32) (Syntax: 'I')
                Instance Receiver: 
                  IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: T, IsImplicit) (Syntax: 'I')
            Right: 
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22072,2504,2629);

f_22072_2504_2628(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22072,1171,2640);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22072,1171,2640);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22072,1171,2640);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void TypeParameterObjectCreation_WithCollectionInitializer()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22072,2652,4507);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22072,2813,3036);

string 
source = @"
using System.Collections.Generic;

class C1
{
    void M<T>(T t1) where T : C1, IEnumerable<int>, new()
    {
        t1 = /*<bind>*/new T() { 1 }/*</bind>*/;
    }
    void Add(int i) { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22072,3050,3103);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22072,3119,4357);

string 
expectedOperationTree = @"
ITypeParameterObjectCreationOperation (OperationKind.TypeParameterObjectCreation, Type: T) (Syntax: 'new T() { 1 }')
  Initializer: 
    IObjectOrCollectionInitializerOperation (OperationKind.ObjectOrCollectionInitializer, Type: T) (Syntax: '{ 1 }')
      Initializers(1):
          IInvocationOperation ( void C1.Add(System.Int32 i)) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: '1')
            Instance Receiver: 
              IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: T, IsImplicit) (Syntax: 'T')
            Arguments(1):
                IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: '1')
                  ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
                  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22072,4371,4496);

f_22072_4371_4495(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22072,2652,4507);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22072,2652,4507);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22072,2652,4507);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void TypeParameterObjectCreation_NoNewConstraint()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22072,4519,8406);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22072,4670,4932);

string 
source = @"
using System.Collections;
using System.Collections.Generic;

class C1
{
    void M<T>(T t1, bool b) where T : C1, IEnumerable<int>
    {
        t1 = /*<bind>*/new T() { 1, b ? 2 : 3 }/*</bind>*/;
    }
    void Add(int i) { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22072,4946,5343);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22072_5224_5327(f_22072_5224_5307(f_22072_5224_5288(ErrorCode.ERR_NoNewTyvar, "new T() { 1, b ? 2 : 3 }"), "T"), 9, 24)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22072,5455,8256);

string 
expectedOperationTree = @"
IInvalidOperation (OperationKind.Invalid, Type: T, IsInvalid) (Syntax: 'new T() { 1, b ? 2 : 3 }')
  Children(1):
      IObjectOrCollectionInitializerOperation (OperationKind.ObjectOrCollectionInitializer, Type: T, IsInvalid) (Syntax: '{ 1, b ? 2 : 3 }')
        Initializers(2):
            IInvocationOperation ( void C1.Add(System.Int32 i)) (OperationKind.Invocation, Type: System.Void, IsInvalid, IsImplicit) (Syntax: '1')
              Instance Receiver: 
                IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: T, IsInvalid, IsImplicit) (Syntax: 'T')
              Arguments(1):
                  IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null, IsInvalid, IsImplicit) (Syntax: '1')
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1, IsInvalid) (Syntax: '1')
                    InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            IInvocationOperation ( void C1.Add(System.Int32 i)) (OperationKind.Invocation, Type: System.Void, IsInvalid, IsImplicit) (Syntax: 'b ? 2 : 3')
              Instance Receiver: 
                IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: T, IsInvalid, IsImplicit) (Syntax: 'T')
              Arguments(1):
                  IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null, IsInvalid, IsImplicit) (Syntax: 'b ? 2 : 3')
                    IConditionalOperation (OperationKind.Conditional, Type: System.Int32, IsInvalid) (Syntax: 'b ? 2 : 3')
                      Condition: 
                        IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean, IsInvalid) (Syntax: 'b')
                      WhenTrue: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2, IsInvalid) (Syntax: '2')
                      WhenFalse: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3, IsInvalid) (Syntax: '3')
                    InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22072,8270,8395);

f_22072_8270_8394(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22072,4519,8406);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22072,4519,8406);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22072,4519,8406);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void TypeParameterObjectCreationFlow_01()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22072,8418,14023);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22072,8586,8855);

string 
source = @"
using System.Collections;
using System.Collections.Generic;

class C1
{
    /*<bind>*/void M<T>(T t1, bool b) where T : C1, IEnumerable<int>, new()
    {
        t1 = new T() { 1, b ? 2 : 3 };
    }/*</bind>*/
    void Add(int i) { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22072,8869,8922);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22072,8938,13888);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 't1')
              Value: 
                IParameterReferenceOperation: t1 (OperationKind.ParameterReference, Type: T) (Syntax: 't1')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new T() { 1, b ? 2 : 3 }')
              Value: 
                ITypeParameterObjectCreationOperation (OperationKind.TypeParameterObjectCreation, Type: T) (Syntax: 'new T() { 1, b ? 2 : 3 }')
                  Initializer: 
                    null

            IInvocationOperation ( void C1.Add(System.Int32 i)) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: '1')
              Instance Receiver: 
                IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: T, IsImplicit) (Syntax: 'new T() { 1, b ? 2 : 3 }')
              Arguments(1):
                  IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: '1')
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
                    InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

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
                IInvocationOperation ( void C1.Add(System.Int32 i)) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'b ? 2 : 3')
                  Instance Receiver: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: T, IsImplicit) (Syntax: 'new T() { 1, b ? 2 : 3 }')
                  Arguments(1):
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'b ? 2 : 3')
                        IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'b ? 2 : 3')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

            Next (Regular) Block[B6]
                Leaving: {R2}
    }

    Block[B6] - Block
        Predecessors: [B5]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 't1 = new T( ...  ? 2 : 3 };')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: T) (Syntax: 't1 = new T( ... b ? 2 : 3 }')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: T, IsImplicit) (Syntax: 't1')
                  Right: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: T, IsImplicit) (Syntax: 'new T() { 1, b ? 2 : 3 }')

        Next (Regular) Block[B7]
            Leaving: {R1}
}

Block[B7] - Exit
    Predecessors: [B6]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22072,13902,14012);

f_22072_13902_14011(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22072,8418,14023);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22072,8418,14023);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22072,8418,14023);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void TypeParameterObjectCreationFlow_02()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22072,14035,18986);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22072,14203,14491);

string 
source = @"
using System.Collections;
using System.Collections.Generic;

class C1
{
    /*<bind>*/void M<T>(T t1, bool b) where T : C1, new()
    {
        t1 = new T() { I1 = 1, I2 = b ? 2 : 3 };
    }/*</bind>*/
    int I1 { get; set; }
    int I2 { get; set; }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22072,14505,14558);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22072,14574,18851);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 't1')
              Value: 
                IParameterReferenceOperation: t1 (OperationKind.ParameterReference, Type: T) (Syntax: 't1')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new T() { I ... b ? 2 : 3 }')
              Value: 
                ITypeParameterObjectCreationOperation (OperationKind.TypeParameterObjectCreation, Type: T) (Syntax: 'new T() { I ... b ? 2 : 3 }')
                  Initializer: 
                    null

            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'I1 = 1')
              Left: 
                IPropertyReferenceOperation: System.Int32 C1.I1 { get; set; } (OperationKind.PropertyReference, Type: System.Int32) (Syntax: 'I1')
                  Instance Receiver: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: T, IsImplicit) (Syntax: 'new T() { I ... b ? 2 : 3 }')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

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
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'I2 = b ? 2 : 3')
                  Left: 
                    IPropertyReferenceOperation: System.Int32 C1.I2 { get; set; } (OperationKind.PropertyReference, Type: System.Int32) (Syntax: 'I2')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: T, IsImplicit) (Syntax: 'new T() { I ... b ? 2 : 3 }')
                  Right: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'b ? 2 : 3')

            Next (Regular) Block[B6]
                Leaving: {R2}
    }

    Block[B6] - Block
        Predecessors: [B5]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 't1 = new T( ...  ? 2 : 3 };')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: T) (Syntax: 't1 = new T( ... b ? 2 : 3 }')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: T, IsImplicit) (Syntax: 't1')
                  Right: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: T, IsImplicit) (Syntax: 'new T() { I ... b ? 2 : 3 }')

        Next (Regular) Block[B7]
            Leaving: {R1}
}

Block[B7] - Exit
    Predecessors: [B6]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22072,18865,18975);

f_22072_18865_18974(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22072,14035,18986);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22072,14035,18986);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22072,14035,18986);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void TypeParameterObjectCreationFlow_03()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22072,18998,23060);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22072,19166,19427);

string 
source = @"
using System.Collections;
using System.Collections.Generic;

class C1
{
    /*<bind>*/void M<T>(T t1, bool b) where T : C1, IEnumerable<int>, new()
    {
        t1 = new T() { 1, 2 };
    }/*</bind>*/
    void Add(int i) { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22072,19441,19494);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22072,19510,22925);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 't1')
              Value: 
                IParameterReferenceOperation: t1 (OperationKind.ParameterReference, Type: T) (Syntax: 't1')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new T() { 1, 2 }')
              Value: 
                ITypeParameterObjectCreationOperation (OperationKind.TypeParameterObjectCreation, Type: T) (Syntax: 'new T() { 1, 2 }')
                  Initializer: 
                    null

            IInvocationOperation ( void C1.Add(System.Int32 i)) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: '1')
              Instance Receiver: 
                IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: T, IsImplicit) (Syntax: 'new T() { 1, 2 }')
              Arguments(1):
                  IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: '1')
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
                    InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

            IInvocationOperation ( void C1.Add(System.Int32 i)) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: '2')
              Instance Receiver: 
                IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: T, IsImplicit) (Syntax: 'new T() { 1, 2 }')
              Arguments(1):
                  IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: '2')
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
                    InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 't1 = new T() { 1, 2 };')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: T) (Syntax: 't1 = new T() { 1, 2 }')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: T, IsImplicit) (Syntax: 't1')
                  Right: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: T, IsImplicit) (Syntax: 'new T() { 1, 2 }')

        Next (Regular) Block[B2]
            Leaving: {R1}
}

Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22072,22939,23049);

f_22072_22939_23048(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22072,18998,23060);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22072,18998,23060);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22072,18998,23060);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void TypeParameterObjectCreationFlow_04()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22072,23072,27527);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22072,23240,23494);

string 
source = @"
using System.Collections;
using System.Collections.Generic;

class C1
{
    /*<bind>*/void M<T>(T t1, bool b) where T : C1, IEnumerable<int>
    {
        t1 = new T() { 1, 2 };
    }/*</bind>*/
    void Add(int i) { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22072,23508,23886);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22072_23775_23870(f_22072_23775_23850(f_22072_23775_23831(ErrorCode.ERR_NoNewTyvar, "new T() { 1, 2 }"), "T"), 9, 14)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22072,23902,27392);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 't1')
              Value: 
                IParameterReferenceOperation: t1 (OperationKind.ParameterReference, Type: T) (Syntax: 't1')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'new T() { 1, 2 }')
              Value: 
                IInvalidOperation (OperationKind.Invalid, Type: T, IsInvalid) (Syntax: 'new T() { 1, 2 }')
                  Children(0)

            IInvocationOperation ( void C1.Add(System.Int32 i)) (OperationKind.Invocation, Type: System.Void, IsInvalid, IsImplicit) (Syntax: '1')
              Instance Receiver: 
                IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: T, IsInvalid, IsImplicit) (Syntax: 'new T() { 1, 2 }')
              Arguments(1):
                  IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null, IsInvalid, IsImplicit) (Syntax: '1')
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1, IsInvalid) (Syntax: '1')
                    InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

            IInvocationOperation ( void C1.Add(System.Int32 i)) (OperationKind.Invocation, Type: System.Void, IsInvalid, IsImplicit) (Syntax: '2')
              Instance Receiver: 
                IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: T, IsInvalid, IsImplicit) (Syntax: 'new T() { 1, 2 }')
              Arguments(1):
                  IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null, IsInvalid, IsImplicit) (Syntax: '2')
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2, IsInvalid) (Syntax: '2')
                    InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: 't1 = new T() { 1, 2 };')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: T, IsInvalid) (Syntax: 't1 = new T() { 1, 2 }')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: T, IsImplicit) (Syntax: 't1')
                  Right: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: T, IsInvalid, IsImplicit) (Syntax: 'new T() { 1, 2 }')

        Next (Regular) Block[B2]
            Leaving: {R1}
}

Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22072,27406,27516);

f_22072_27406_27515(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22072,23072,27527);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22072,23072,27527);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22072,23072,27527);
}
		}

int
f_22072_1023_1147(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ObjectCreationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22072, 1023, 1147);
return 0;
}


int
f_22072_2504_2628(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ObjectCreationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22072, 2504, 2628);
return 0;
}


int
f_22072_4371_4495(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ObjectCreationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22072, 4371, 4495);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22072_5224_5288(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22072, 5224, 5288);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22072_5224_5307(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22072, 5224, 5307);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22072_5224_5327(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22072, 5224, 5327);
return return_v;
}


int
f_22072_8270_8394(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ObjectCreationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22072, 8270, 8394);
return 0;
}


int
f_22072_13902_14011(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<MethodDeclarationSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22072, 13902, 14011);
return 0;
}


int
f_22072_18865_18974(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<MethodDeclarationSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22072, 18865, 18974);
return 0;
}


int
f_22072_22939_23048(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<MethodDeclarationSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22072, 22939, 23048);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22072_23775_23831(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22072, 23775, 23831);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22072_23775_23850(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22072, 23775, 23850);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22072_23775_23870(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22072, 23775, 23870);
return return_v;
}


int
f_22072_27406_27515(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<MethodDeclarationSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22072, 27406, 27515);
return 0;
}

}
}
