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
[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void AnonymousObjectCreation_NoControlFlow_01()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22005,471,4977);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22005,645,805);

string 
source = @"
using System;

class C
{
    void M(object p, int i, int j)
    /*<bind>*/{
        p = new { a = i, b = j };
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22005,819,4785);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [1] [2]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (4)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'p')
              Value: 
                IParameterReferenceOperation: p (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'p')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i')
              Value: 
                IParameterReferenceOperation: i (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i')

            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'j')
              Value: 
                IParameterReferenceOperation: j (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'j')

            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'p = new { a ... i, b = j };')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Object) (Syntax: 'p = new { a = i, b = j }')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'p')
                  Right: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsImplicit) (Syntax: 'new { a = i, b = j }')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                        (ImplicitReference)
                      Operand: 
                        IAnonymousObjectCreationOperation (OperationKind.AnonymousObjectCreation, Type: <anonymous type: System.Int32 a, System.Int32 b>) (Syntax: 'new { a = i, b = j }')
                          Initializers(2):
                              ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'a = i')
                                Left: 
                                  IPropertyReferenceOperation: System.Int32 <anonymous type: System.Int32 a, System.Int32 b>.a { get; } (OperationKind.PropertyReference, Type: System.Int32) (Syntax: 'a')
                                    Instance Receiver: 
                                      IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: <anonymous type: System.Int32 a, System.Int32 b>, IsImplicit) (Syntax: 'new { a = i, b = j }')
                                Right: 
                                  IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'i')
                              ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'b = j')
                                Left: 
                                  IPropertyReferenceOperation: System.Int32 <anonymous type: System.Int32 a, System.Int32 b>.b { get; } (OperationKind.PropertyReference, Type: System.Int32) (Syntax: 'b')
                                    Instance Receiver: 
                                      IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: <anonymous type: System.Int32 a, System.Int32 b>, IsImplicit) (Syntax: 'new { a = i, b = j }')
                                Right: 
                                  IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'j')

        Next (Regular) Block[B2]
            Leaving: {R1}
}

Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22005,4799,4852);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22005,4868,4966);

f_22005_4868_4965(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22005,471,4977);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22005,471,4977);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22005,471,4977);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void AnonymousObjectCreation_NoControlFlow_02()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22005,4989,9989);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22005,5232,5447);

string 
source = @"
using System;

class B
{
    public int j = 0;
}

class C
{
    private B b = new B();
    void M(object p, int i)
    /*<bind>*/{
        p = new { i, b.j };
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22005,5461,9797);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [1] [2]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (4)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'p')
              Value: 
                IParameterReferenceOperation: p (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'p')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i')
              Value: 
                IParameterReferenceOperation: i (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i')

            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'b.j')
              Value: 
                IFieldReferenceOperation: System.Int32 B.j (OperationKind.FieldReference, Type: System.Int32) (Syntax: 'b.j')
                  Instance Receiver: 
                    IFieldReferenceOperation: B C.b (OperationKind.FieldReference, Type: B) (Syntax: 'b')
                      Instance Receiver: 
                        IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C, IsImplicit) (Syntax: 'b')

            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'p = new { i, b.j };')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Object) (Syntax: 'p = new { i, b.j }')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'p')
                  Right: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsImplicit) (Syntax: 'new { i, b.j }')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                        (ImplicitReference)
                      Operand: 
                        IAnonymousObjectCreationOperation (OperationKind.AnonymousObjectCreation, Type: <anonymous type: System.Int32 i, System.Int32 j>) (Syntax: 'new { i, b.j }')
                          Initializers(2):
                              ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: 'i')
                                Left: 
                                  IPropertyReferenceOperation: System.Int32 <anonymous type: System.Int32 i, System.Int32 j>.i { get; } (OperationKind.PropertyReference, Type: System.Int32, IsImplicit) (Syntax: 'i')
                                    Instance Receiver: 
                                      IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: <anonymous type: System.Int32 i, System.Int32 j>, IsImplicit) (Syntax: 'new { i, b.j }')
                                Right: 
                                  IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'i')
                              ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: 'b.j')
                                Left: 
                                  IPropertyReferenceOperation: System.Int32 <anonymous type: System.Int32 i, System.Int32 j>.j { get; } (OperationKind.PropertyReference, Type: System.Int32, IsImplicit) (Syntax: 'b.j')
                                    Instance Receiver: 
                                      IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: <anonymous type: System.Int32 i, System.Int32 j>, IsImplicit) (Syntax: 'new { i, b.j }')
                                Right: 
                                  IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'b.j')

        Next (Regular) Block[B2]
            Leaving: {R1}
}

Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22005,9811,9864);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22005,9880,9978);

f_22005_9880_9977(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22005,4989,9989);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22005,4989,9989);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22005,4989,9989);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void AnonymousObjectCreation_NoControlFlow_03()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22005,10001,14589);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22005,10267,10423);

string 
source = @"
using System;

class C
{
    void M(object p, int a, int i)
    /*<bind>*/{
        p = new { a, b = i };
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22005,10437,14397);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [1] [2]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (4)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'p')
              Value: 
                IParameterReferenceOperation: p (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'p')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
              Value: 
                IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'a')

            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i')
              Value: 
                IParameterReferenceOperation: i (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i')

            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'p = new { a, b = i };')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Object) (Syntax: 'p = new { a, b = i }')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'p')
                  Right: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsImplicit) (Syntax: 'new { a, b = i }')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                        (ImplicitReference)
                      Operand: 
                        IAnonymousObjectCreationOperation (OperationKind.AnonymousObjectCreation, Type: <anonymous type: System.Int32 a, System.Int32 b>) (Syntax: 'new { a, b = i }')
                          Initializers(2):
                              ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: 'a')
                                Left: 
                                  IPropertyReferenceOperation: System.Int32 <anonymous type: System.Int32 a, System.Int32 b>.a { get; } (OperationKind.PropertyReference, Type: System.Int32, IsImplicit) (Syntax: 'a')
                                    Instance Receiver: 
                                      IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: <anonymous type: System.Int32 a, System.Int32 b>, IsImplicit) (Syntax: 'new { a, b = i }')
                                Right: 
                                  IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'a')
                              ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'b = i')
                                Left: 
                                  IPropertyReferenceOperation: System.Int32 <anonymous type: System.Int32 a, System.Int32 b>.b { get; } (OperationKind.PropertyReference, Type: System.Int32) (Syntax: 'b')
                                    Instance Receiver: 
                                      IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: <anonymous type: System.Int32 a, System.Int32 b>, IsImplicit) (Syntax: 'new { a, b = i }')
                                Right: 
                                  IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'i')

        Next (Regular) Block[B2]
            Leaving: {R1}
}

Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22005,14411,14464);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22005,14480,14578);

f_22005_14480_14577(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22005,10001,14589);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22005,10001,14589);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22005,10001,14589);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void AnonymousObjectCreation_NoControlFlow_04()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22005,14601,34828);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22005,14834,15128);

string 
source = @"
using System;
using System.Collections.Generic;
using System.Linq;

class C
{
    void M(object p, List<int> a, List<string> b)
    /*<bind>*/{
        p = from x in a
            from y in b
            where x == 0
            select 0;
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22005,15144,34636);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (1)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'p = from x  ... select 0;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Object) (Syntax: 'p = from x  ... select 0')
              Left: 
                IParameterReferenceOperation: p (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'p')
              Right: 
                IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsImplicit) (Syntax: 'from x in a ... select 0')
                  Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                    (ImplicitReference)
                  Operand: 
                    ITranslatedQueryOperation (OperationKind.TranslatedQuery, Type: System.Collections.Generic.IEnumerable<System.Int32>) (Syntax: 'from x in a ... select 0')
                      Expression: 
                        IInvocationOperation (System.Collections.Generic.IEnumerable<System.Int32> System.Linq.Enumerable.Select<<anonymous type: System.Int32 x, System.String y>, System.Int32>(this System.Collections.Generic.IEnumerable<<anonymous type: System.Int32 x, System.String y>> source, System.Func<<anonymous type: System.Int32 x, System.String y>, System.Int32> selector)) (OperationKind.Invocation, Type: System.Collections.Generic.IEnumerable<System.Int32>, IsImplicit) (Syntax: 'select 0')
                          Instance Receiver: 
                            null
                          Arguments(2):
                              IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: source) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'where x == 0')
                                IInvocationOperation (System.Collections.Generic.IEnumerable<<anonymous type: System.Int32 x, System.String y>> System.Linq.Enumerable.Where<<anonymous type: System.Int32 x, System.String y>>(this System.Collections.Generic.IEnumerable<<anonymous type: System.Int32 x, System.String y>> source, System.Func<<anonymous type: System.Int32 x, System.String y>, System.Boolean> predicate)) (OperationKind.Invocation, Type: System.Collections.Generic.IEnumerable<<anonymous type: System.Int32 x, System.String y>>, IsImplicit) (Syntax: 'where x == 0')
                                  Instance Receiver: 
                                    null
                                  Arguments(2):
                                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: source) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'from y in b')
                                        IInvocationOperation (System.Collections.Generic.IEnumerable<<anonymous type: System.Int32 x, System.String y>> System.Linq.Enumerable.SelectMany<System.Int32, System.String, <anonymous type: System.Int32 x, System.String y>>(this System.Collections.Generic.IEnumerable<System.Int32> source, System.Func<System.Int32, System.Collections.Generic.IEnumerable<System.String>> collectionSelector, System.Func<System.Int32, System.String, <anonymous type: System.Int32 x, System.String y>> resultSelector)) (OperationKind.Invocation, Type: System.Collections.Generic.IEnumerable<<anonymous type: System.Int32 x, System.String y>>, IsImplicit) (Syntax: 'from y in b')
                                          Instance Receiver: 
                                            null
                                          Arguments(3):
                                              IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: source) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'from x in a')
                                                IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Collections.Generic.IEnumerable<System.Int32>, IsImplicit) (Syntax: 'from x in a')
                                                  Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                                                    (ImplicitReference)
                                                  Operand: 
                                                    IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Collections.Generic.List<System.Int32>) (Syntax: 'a')
                                                InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                                OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                              IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: collectionSelector) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'b')
                                                IDelegateCreationOperation (OperationKind.DelegateCreation, Type: System.Func<System.Int32, System.Collections.Generic.IEnumerable<System.String>>, IsImplicit) (Syntax: 'b')
                                                  Target: 
                                                    IFlowAnonymousFunctionOperation (Symbol: lambda expression) (OperationKind.FlowAnonymousFunction, Type: null, IsImplicit) (Syntax: 'b')
                                                    {
                                                        Block[B0#A0] - Entry
                                                            Statements (0)
                                                            Next (Regular) Block[B1#A0]
                                                        Block[B1#A0] - Block
                                                            Predecessors: [B0#A0]
                                                            Statements (0)
                                                            Next (Return) Block[B2#A0]
                                                                IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Collections.Generic.IEnumerable<System.String>, IsImplicit) (Syntax: 'b')
                                                                  Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                                                                    (ImplicitReference)
                                                                  Operand: 
                                                                    IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Collections.Generic.List<System.String>) (Syntax: 'b')
                                                        Block[B2#A0] - Exit
                                                            Predecessors: [B1#A0]
                                                            Statements (0)
                                                    }
                                                InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                                OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                              IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: resultSelector) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'from y in b')
                                                IDelegateCreationOperation (OperationKind.DelegateCreation, Type: System.Func<System.Int32, System.String, <anonymous type: System.Int32 x, System.String y>>, IsImplicit) (Syntax: 'from y in b')
                                                  Target: 
                                                    IFlowAnonymousFunctionOperation (Symbol: lambda expression) (OperationKind.FlowAnonymousFunction, Type: null, IsImplicit) (Syntax: 'from y in b')
                                                    {
                                                        Block[B0#A1] - Entry
                                                            Statements (0)
                                                            Next (Regular) Block[B1#A1]
                                                                Entering: {R1#A1}

                                                        .locals {R1#A1}
                                                        {
                                                            CaptureIds: [0] [1]
                                                            Block[B1#A1] - Block
                                                                Predecessors: [B0#A1]
                                                                Statements (2)
                                                                    IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'from y in b')
                                                                      Value: 
                                                                        IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32, IsImplicit) (Syntax: 'from y in b')

                                                                    IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'from y in b')
                                                                      Value: 
                                                                        IParameterReferenceOperation: y (OperationKind.ParameterReference, Type: System.String, IsImplicit) (Syntax: 'from y in b')

                                                                Next (Return) Block[B2#A1]
                                                                    IAnonymousObjectCreationOperation (OperationKind.AnonymousObjectCreation, Type: <anonymous type: System.Int32 x, System.String y>, IsImplicit) (Syntax: 'from y in b')
                                                                      Initializers(2):
                                                                          ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: 'from y in b ... select 0')
                                                                            Left: 
                                                                              IPropertyReferenceOperation: System.Int32 <anonymous type: System.Int32 x, System.String y>.x { get; } (OperationKind.PropertyReference, Type: System.Int32, IsImplicit) (Syntax: 'from y in b')
                                                                                Instance Receiver: 
                                                                                  IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: <anonymous type: System.Int32 x, System.String y>, IsImplicit) (Syntax: 'from y in b')
                                                                            Right: 
                                                                              IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'from y in b')
                                                                          ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.String, IsImplicit) (Syntax: 'from y in b ... select 0')
                                                                            Left: 
                                                                              IPropertyReferenceOperation: System.String <anonymous type: System.Int32 x, System.String y>.y { get; } (OperationKind.PropertyReference, Type: System.String, IsImplicit) (Syntax: 'from y in b')
                                                                                Instance Receiver: 
                                                                                  IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: <anonymous type: System.Int32 x, System.String y>, IsImplicit) (Syntax: 'from y in b')
                                                                            Right: 
                                                                              IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.String, IsImplicit) (Syntax: 'from y in b')
                                                                    Leaving: {R1#A1}
                                                        }

                                                        Block[B2#A1] - Exit
                                                            Predecessors: [B1#A1]
                                                            Statements (0)
                                                    }
                                                InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                                OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: predicate) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'x == 0')
                                        IDelegateCreationOperation (OperationKind.DelegateCreation, Type: System.Func<<anonymous type: System.Int32 x, System.String y>, System.Boolean>, IsImplicit) (Syntax: 'x == 0')
                                          Target: 
                                            IFlowAnonymousFunctionOperation (Symbol: lambda expression) (OperationKind.FlowAnonymousFunction, Type: null, IsImplicit) (Syntax: 'x == 0')
                                            {
                                                Block[B0#A2] - Entry
                                                    Statements (0)
                                                    Next (Regular) Block[B1#A2]
                                                Block[B1#A2] - Block
                                                    Predecessors: [B0#A2]
                                                    Statements (0)
                                                    Next (Return) Block[B2#A2]
                                                        IBinaryOperation (BinaryOperatorKind.Equals) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'x == 0')
                                                          Left: 
                                                            IPropertyReferenceOperation: System.Int32 <anonymous type: System.Int32 x, System.String y>.x { get; } (OperationKind.PropertyReference, Type: System.Int32) (Syntax: 'x')
                                                              Instance Receiver: 
                                                                IParameterReferenceOperation: <>h__TransparentIdentifier0 (OperationKind.ParameterReference, Type: <anonymous type: System.Int32 x, System.String y>, IsImplicit) (Syntax: 'x')
                                                          Right: 
                                                            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
                                                Block[B2#A2] - Exit
                                                    Predecessors: [B1#A2]
                                                    Statements (0)
                                            }
                                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                              IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: selector) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: '0')
                                IDelegateCreationOperation (OperationKind.DelegateCreation, Type: System.Func<<anonymous type: System.Int32 x, System.String y>, System.Int32>, IsImplicit) (Syntax: '0')
                                  Target: 
                                    IFlowAnonymousFunctionOperation (Symbol: lambda expression) (OperationKind.FlowAnonymousFunction, Type: null, IsImplicit) (Syntax: '0')
                                    {
                                        Block[B0#A3] - Entry
                                            Statements (0)
                                            Next (Regular) Block[B1#A3]
                                        Block[B1#A3] - Block
                                            Predecessors: [B0#A3]
                                            Statements (0)
                                            Next (Return) Block[B2#A3]
                                                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
                                        Block[B2#A3] - Exit
                                            Predecessors: [B1#A3]
                                            Statements (0)
                                    }
                                InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

    Next (Regular) Block[B2]
Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22005,34650,34703);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22005,34719,34817);

f_22005_34719_34816(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22005,14601,34828);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22005,14601,34828);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22005,14601,34828);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void AnonymousObjectCreation_NoControlFlow_05()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22005,34840,51994);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22005,35102,35378);

string 
source = @"
using System;
using System.Collections.Generic;
using System.Linq;

class C
{
    void M(object p, List<int> a)
    /*<bind>*/{
        p = from x in a
            let y = x
            where x == 0
            select 0;
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22005,35392,51802);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (1)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'p = from x  ... select 0;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Object) (Syntax: 'p = from x  ... select 0')
              Left: 
                IParameterReferenceOperation: p (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'p')
              Right: 
                IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsImplicit) (Syntax: 'from x in a ... select 0')
                  Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                    (ImplicitReference)
                  Operand: 
                    ITranslatedQueryOperation (OperationKind.TranslatedQuery, Type: System.Collections.Generic.IEnumerable<System.Int32>) (Syntax: 'from x in a ... select 0')
                      Expression: 
                        IInvocationOperation (System.Collections.Generic.IEnumerable<System.Int32> System.Linq.Enumerable.Select<<anonymous type: System.Int32 x, System.Int32 y>, System.Int32>(this System.Collections.Generic.IEnumerable<<anonymous type: System.Int32 x, System.Int32 y>> source, System.Func<<anonymous type: System.Int32 x, System.Int32 y>, System.Int32> selector)) (OperationKind.Invocation, Type: System.Collections.Generic.IEnumerable<System.Int32>, IsImplicit) (Syntax: 'select 0')
                          Instance Receiver: 
                            null
                          Arguments(2):
                              IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: source) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'where x == 0')
                                IInvocationOperation (System.Collections.Generic.IEnumerable<<anonymous type: System.Int32 x, System.Int32 y>> System.Linq.Enumerable.Where<<anonymous type: System.Int32 x, System.Int32 y>>(this System.Collections.Generic.IEnumerable<<anonymous type: System.Int32 x, System.Int32 y>> source, System.Func<<anonymous type: System.Int32 x, System.Int32 y>, System.Boolean> predicate)) (OperationKind.Invocation, Type: System.Collections.Generic.IEnumerable<<anonymous type: System.Int32 x, System.Int32 y>>, IsImplicit) (Syntax: 'where x == 0')
                                  Instance Receiver: 
                                    null
                                  Arguments(2):
                                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: source) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'let y = x')
                                        IInvocationOperation (System.Collections.Generic.IEnumerable<<anonymous type: System.Int32 x, System.Int32 y>> System.Linq.Enumerable.Select<System.Int32, <anonymous type: System.Int32 x, System.Int32 y>>(this System.Collections.Generic.IEnumerable<System.Int32> source, System.Func<System.Int32, <anonymous type: System.Int32 x, System.Int32 y>> selector)) (OperationKind.Invocation, Type: System.Collections.Generic.IEnumerable<<anonymous type: System.Int32 x, System.Int32 y>>, IsImplicit) (Syntax: 'let y = x')
                                          Instance Receiver: 
                                            null
                                          Arguments(2):
                                              IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: source) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'from x in a')
                                                IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Collections.Generic.IEnumerable<System.Int32>, IsImplicit) (Syntax: 'from x in a')
                                                  Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                                                    (ImplicitReference)
                                                  Operand: 
                                                    IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Collections.Generic.List<System.Int32>) (Syntax: 'a')
                                                InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                                OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                              IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: selector) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'x')
                                                IDelegateCreationOperation (OperationKind.DelegateCreation, Type: System.Func<System.Int32, <anonymous type: System.Int32 x, System.Int32 y>>, IsImplicit) (Syntax: 'x')
                                                  Target: 
                                                    IFlowAnonymousFunctionOperation (Symbol: lambda expression) (OperationKind.FlowAnonymousFunction, Type: null, IsImplicit) (Syntax: 'x')
                                                    {
                                                        Block[B0#A0] - Entry
                                                            Statements (0)
                                                            Next (Regular) Block[B1#A0]
                                                                Entering: {R1#A0}

                                                        .locals {R1#A0}
                                                        {
                                                            CaptureIds: [0] [1]
                                                            Block[B1#A0] - Block
                                                                Predecessors: [B0#A0]
                                                                Statements (2)
                                                                    IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'let y = x')
                                                                      Value: 
                                                                        IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32, IsImplicit) (Syntax: 'let y = x')

                                                                    IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'x')
                                                                      Value: 
                                                                        IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'x')

                                                                Next (Return) Block[B2#A0]
                                                                    IAnonymousObjectCreationOperation (OperationKind.AnonymousObjectCreation, Type: <anonymous type: System.Int32 x, System.Int32 y>, IsImplicit) (Syntax: 'let y = x')
                                                                      Initializers(2):
                                                                          ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: 'let y = x ... select 0')
                                                                            Left: 
                                                                              IPropertyReferenceOperation: System.Int32 <anonymous type: System.Int32 x, System.Int32 y>.x { get; } (OperationKind.PropertyReference, Type: System.Int32, IsImplicit) (Syntax: 'let y = x')
                                                                                Instance Receiver: 
                                                                                  IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: <anonymous type: System.Int32 x, System.Int32 y>, IsImplicit) (Syntax: 'let y = x')
                                                                            Right: 
                                                                              IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'let y = x')
                                                                          ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: 'let y = x')
                                                                            Left: 
                                                                              IPropertyReferenceOperation: System.Int32 <anonymous type: System.Int32 x, System.Int32 y>.y { get; } (OperationKind.PropertyReference, Type: System.Int32, IsImplicit) (Syntax: 'x')
                                                                                Instance Receiver: 
                                                                                  IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: <anonymous type: System.Int32 x, System.Int32 y>, IsImplicit) (Syntax: 'let y = x')
                                                                            Right: 
                                                                              IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'x')
                                                                    Leaving: {R1#A0}
                                                        }

                                                        Block[B2#A0] - Exit
                                                            Predecessors: [B1#A0]
                                                            Statements (0)
                                                    }
                                                InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                                OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: predicate) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'x == 0')
                                        IDelegateCreationOperation (OperationKind.DelegateCreation, Type: System.Func<<anonymous type: System.Int32 x, System.Int32 y>, System.Boolean>, IsImplicit) (Syntax: 'x == 0')
                                          Target: 
                                            IFlowAnonymousFunctionOperation (Symbol: lambda expression) (OperationKind.FlowAnonymousFunction, Type: null, IsImplicit) (Syntax: 'x == 0')
                                            {
                                                Block[B0#A1] - Entry
                                                    Statements (0)
                                                    Next (Regular) Block[B1#A1]
                                                Block[B1#A1] - Block
                                                    Predecessors: [B0#A1]
                                                    Statements (0)
                                                    Next (Return) Block[B2#A1]
                                                        IBinaryOperation (BinaryOperatorKind.Equals) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'x == 0')
                                                          Left: 
                                                            IPropertyReferenceOperation: System.Int32 <anonymous type: System.Int32 x, System.Int32 y>.x { get; } (OperationKind.PropertyReference, Type: System.Int32) (Syntax: 'x')
                                                              Instance Receiver: 
                                                                IParameterReferenceOperation: <>h__TransparentIdentifier0 (OperationKind.ParameterReference, Type: <anonymous type: System.Int32 x, System.Int32 y>, IsImplicit) (Syntax: 'x')
                                                          Right: 
                                                            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
                                                Block[B2#A1] - Exit
                                                    Predecessors: [B1#A1]
                                                    Statements (0)
                                            }
                                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                              IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: selector) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: '0')
                                IDelegateCreationOperation (OperationKind.DelegateCreation, Type: System.Func<<anonymous type: System.Int32 x, System.Int32 y>, System.Int32>, IsImplicit) (Syntax: '0')
                                  Target: 
                                    IFlowAnonymousFunctionOperation (Symbol: lambda expression) (OperationKind.FlowAnonymousFunction, Type: null, IsImplicit) (Syntax: '0')
                                    {
                                        Block[B0#A2] - Entry
                                            Statements (0)
                                            Next (Regular) Block[B1#A2]
                                        Block[B1#A2] - Block
                                            Predecessors: [B0#A2]
                                            Statements (0)
                                            Next (Return) Block[B2#A2]
                                                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
                                        Block[B2#A2] - Exit
                                            Predecessors: [B1#A2]
                                            Statements (0)
                                    }
                                InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

    Next (Regular) Block[B2]
Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22005,51816,51869);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22005,51885,51983);

f_22005_51885_51982(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22005,34840,51994);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22005,34840,51994);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22005,34840,51994);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void AnonymousObjectCreation_NoControlFlow_06()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22005,52006,59163);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22005,52268,52508);

string 
source = @"
using System;

class C
{
    public int a = 1;
    public object b;
    void M(object p, int i1, int i2, int i3)
    /*<bind>*/{
        p = new C() { a = i1, b = new { a = i2, b = i3 }};
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22005,52522,58971);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'p')
              Value: 
                IParameterReferenceOperation: p (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'p')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new C() { a ... , b = i3 }}')
              Value: 
                IObjectCreationOperation (Constructor: C..ctor()) (OperationKind.ObjectCreation, Type: C) (Syntax: 'new C() { a ... , b = i3 }}')
                  Arguments(0)
                  Initializer: 
                    null

            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'a = i1')
              Left: 
                IFieldReferenceOperation: System.Int32 C.a (OperationKind.FieldReference, Type: System.Int32) (Syntax: 'a')
                  Instance Receiver: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'new C() { a ... , b = i3 }}')
              Right: 
                IParameterReferenceOperation: i1 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i1')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [2] [3]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (3)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i2')
                  Value: 
                    IParameterReferenceOperation: i2 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i2')

                IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i3')
                  Value: 
                    IParameterReferenceOperation: i3 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i3')

                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Object) (Syntax: 'b = new { a ... 2, b = i3 }')
                  Left: 
                    IFieldReferenceOperation: System.Object C.b (OperationKind.FieldReference, Type: System.Object) (Syntax: 'b')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'new C() { a ... , b = i3 }}')
                  Right: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsImplicit) (Syntax: 'new { a = i2, b = i3 }')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                        (ImplicitReference)
                      Operand: 
                        IAnonymousObjectCreationOperation (OperationKind.AnonymousObjectCreation, Type: <anonymous type: System.Int32 a, System.Int32 b>) (Syntax: 'new { a = i2, b = i3 }')
                          Initializers(2):
                              ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'a = i2')
                                Left: 
                                  IPropertyReferenceOperation: System.Int32 <anonymous type: System.Int32 a, System.Int32 b>.a { get; } (OperationKind.PropertyReference, Type: System.Int32) (Syntax: 'a')
                                    Instance Receiver: 
                                      IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: <anonymous type: System.Int32 a, System.Int32 b>, IsImplicit) (Syntax: 'new { a = i2, b = i3 }')
                                Right: 
                                  IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'i2')
                              ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'b = i3')
                                Left: 
                                  IPropertyReferenceOperation: System.Int32 <anonymous type: System.Int32 a, System.Int32 b>.b { get; } (OperationKind.PropertyReference, Type: System.Int32) (Syntax: 'b')
                                    Instance Receiver: 
                                      IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: <anonymous type: System.Int32 a, System.Int32 b>, IsImplicit) (Syntax: 'new { a = i2, b = i3 }')
                                Right: 
                                  IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'i3')

            Next (Regular) Block[B3]
                Leaving: {R2}
    }

    Block[B3] - Block
        Predecessors: [B2]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'p = new C() ...  b = i3 }};')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Object) (Syntax: 'p = new C() ... , b = i3 }}')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'p')
                  Right: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsImplicit) (Syntax: 'new C() { a ... , b = i3 }}')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                        (ImplicitReference)
                      Operand: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'new C() { a ... , b = i3 }}')

        Next (Regular) Block[B4]
            Leaving: {R1}
}

Block[B4] - Exit
    Predecessors: [B3]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22005,58985,59038);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22005,59054,59152);

f_22005_59054_59151(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22005,52006,59163);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22005,52006,59163);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22005,52006,59163);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void AnonymousObjectCreation_NoControlFlow_07()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22005,59175,66904);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22005,59447,59638);

string 
source = @"
using System;

class C
{
    void M(object p, int i1, int i2, int i3)
    /*<bind>*/{
        p = new { a = i1, b = new { a = i2, b = i3 }};
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22005,59652,66712);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [1] [4]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (2)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'p')
              Value: 
                IParameterReferenceOperation: p (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'p')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i1')
              Value: 
                IParameterReferenceOperation: i1 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i1')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [2] [3]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (3)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i2')
                  Value: 
                    IParameterReferenceOperation: i2 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i2')

                IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i3')
                  Value: 
                    IParameterReferenceOperation: i3 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i3')

                IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new { a = i2, b = i3 }')
                  Value: 
                    IAnonymousObjectCreationOperation (OperationKind.AnonymousObjectCreation, Type: <anonymous type: System.Int32 a, System.Int32 b>) (Syntax: 'new { a = i2, b = i3 }')
                      Initializers(2):
                          ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'a = i2')
                            Left: 
                              IPropertyReferenceOperation: System.Int32 <anonymous type: System.Int32 a, System.Int32 b>.a { get; } (OperationKind.PropertyReference, Type: System.Int32) (Syntax: 'a')
                                Instance Receiver: 
                                  IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: <anonymous type: System.Int32 a, System.Int32 b>, IsImplicit) (Syntax: 'new { a = i2, b = i3 }')
                            Right: 
                              IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'i2')
                          ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'b = i3')
                            Left: 
                              IPropertyReferenceOperation: System.Int32 <anonymous type: System.Int32 a, System.Int32 b>.b { get; } (OperationKind.PropertyReference, Type: System.Int32) (Syntax: 'b')
                                Instance Receiver: 
                                  IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: <anonymous type: System.Int32 a, System.Int32 b>, IsImplicit) (Syntax: 'new { a = i2, b = i3 }')
                            Right: 
                              IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'i3')

            Next (Regular) Block[B3]
                Leaving: {R2}
    }

    Block[B3] - Block
        Predecessors: [B2]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'p = new { a ...  b = i3 }};')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Object) (Syntax: 'p = new { a ... , b = i3 }}')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'p')
                  Right: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsImplicit) (Syntax: 'new { a = i ... , b = i3 }}')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                        (ImplicitReference)
                      Operand: 
                        IAnonymousObjectCreationOperation (OperationKind.AnonymousObjectCreation, Type: <anonymous type: System.Int32 a, <anonymous type: System.Int32 a, System.Int32 b> b>) (Syntax: 'new { a = i ... , b = i3 }}')
                          Initializers(2):
                              ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'a = i1')
                                Left: 
                                  IPropertyReferenceOperation: System.Int32 <anonymous type: System.Int32 a, <anonymous type: System.Int32 a, System.Int32 b> b>.a { get; } (OperationKind.PropertyReference, Type: System.Int32) (Syntax: 'a')
                                    Instance Receiver: 
                                      IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: <anonymous type: System.Int32 a, <anonymous type: System.Int32 a, System.Int32 b> b>, IsImplicit) (Syntax: 'new { a = i ... , b = i3 }}')
                                Right: 
                                  IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'i1')
                              ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: <anonymous type: System.Int32 a, System.Int32 b>) (Syntax: 'b = new { a ... 2, b = i3 }')
                                Left: 
                                  IPropertyReferenceOperation: <anonymous type: System.Int32 a, System.Int32 b> <anonymous type: System.Int32 a, <anonymous type: System.Int32 a, System.Int32 b> b>.b { get; } (OperationKind.PropertyReference, Type: <anonymous type: System.Int32 a, System.Int32 b>) (Syntax: 'b')
                                    Instance Receiver: 
                                      IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: <anonymous type: System.Int32 a, <anonymous type: System.Int32 a, System.Int32 b> b>, IsImplicit) (Syntax: 'new { a = i ... , b = i3 }}')
                                Right: 
                                  IFlowCaptureReferenceOperation: 4 (OperationKind.FlowCaptureReference, Type: <anonymous type: System.Int32 a, System.Int32 b>, IsImplicit) (Syntax: 'new { a = i2, b = i3 }')

        Next (Regular) Block[B4]
            Leaving: {R1}
}

Block[B4] - Exit
    Predecessors: [B3]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22005,66726,66779);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22005,66795,66893);

f_22005_66795_66892(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22005,59175,66904);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22005,59175,66904);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22005,59175,66904);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void AnonymousObjectCreation_NoControlFlow_08()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22005,66916,68739);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22005,67161,67294);

string 
source = @"
using System;

class C
{
    void M(object p)
    /*<bind>*/{
        p = new { };
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22005,67308,68547);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (1)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'p = new { };')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Object) (Syntax: 'p = new { }')
              Left: 
                IParameterReferenceOperation: p (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'p')
              Right: 
                IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsImplicit) (Syntax: 'new { }')
                  Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                    (ImplicitReference)
                  Operand: 
                    IAnonymousObjectCreationOperation (OperationKind.AnonymousObjectCreation, Type: <empty anonymous type>) (Syntax: 'new { }')
                      Initializers(0)

    Next (Regular) Block[B2]
Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22005,68561,68614);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22005,68630,68728);

f_22005_68630_68727(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22005,66916,68739);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22005,66916,68739);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22005,66916,68739);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void AnonymousObjectCreation_NoControlFlow_Error01()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22005,68751,73748);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22005,69029,69174);

string 
source = @"
using System;

class C
{
    void M(object p, int i)
    /*<bind>*/{
        p = new { i, i };
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22005,69188,73271);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [1] [2]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (4)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'p')
              Value: 
                IParameterReferenceOperation: p (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'p')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i')
              Value: 
                IParameterReferenceOperation: i (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i')

            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'i')
              Value: 
                IParameterReferenceOperation: i (OperationKind.ParameterReference, Type: System.Int32, IsInvalid) (Syntax: 'i')

            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: 'p = new { i, i };')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Object, IsInvalid) (Syntax: 'p = new { i, i }')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'p')
                  Right: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsInvalid, IsImplicit) (Syntax: 'new { i, i }')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                        (ImplicitReference)
                      Operand: 
                        IAnonymousObjectCreationOperation (OperationKind.AnonymousObjectCreation, Type: <anonymous type: System.Int32 i, System.Int32 $1>, IsInvalid) (Syntax: 'new { i, i }')
                          Initializers(2):
                              ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: 'i')
                                Left: 
                                  IPropertyReferenceOperation: System.Int32 <anonymous type: System.Int32 i, System.Int32 $1>.i { get; } (OperationKind.PropertyReference, Type: System.Int32, IsImplicit) (Syntax: 'i')
                                    Instance Receiver: 
                                      IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: <anonymous type: System.Int32 i, System.Int32 $1>, IsInvalid, IsImplicit) (Syntax: 'new { i, i }')
                                Right: 
                                  IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'i')
                              ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'i')
                                Left: 
                                  IPropertyReferenceOperation: System.Int32 <anonymous type: System.Int32 i, System.Int32 $1>.$1 { get; } (OperationKind.PropertyReference, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'i')
                                    Instance Receiver: 
                                      IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: <anonymous type: System.Int32 i, System.Int32 $1>, IsInvalid, IsImplicit) (Syntax: 'new { i, i }')
                                Right: 
                                  IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'i')

        Next (Regular) Block[B2]
            Leaving: {R1}
}

Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22005,73285,73623);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22005_73522_73607(f_22005_73522_73587(ErrorCode.ERR_AnonymousTypeDuplicatePropertyName, "i"), 8, 22)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22005,73639,73737);

f_22005_73639_73736(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22005,68751,73748);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22005,68751,73748);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22005,68751,73748);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void AnonymousObjectCreation_NoControlFlow_Error02()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22005,73760,77359);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22005,73994,74131);

string 
source = @"
using System;

class C
{
    void M(object p)
    /*<bind>*/{
        p = new { a = };
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22005,74145,76924);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'p')
              Value: 
                IParameterReferenceOperation: p (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'p')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: '')
              Value: 
                IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid) (Syntax: '')
                  Children(0)

            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: 'p = new { a = };')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Object, IsInvalid) (Syntax: 'p = new { a = }')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'p')
                  Right: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsInvalid, IsImplicit) (Syntax: 'new { a = }')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                        (ImplicitReference)
                      Operand: 
                        IAnonymousObjectCreationOperation (OperationKind.AnonymousObjectCreation, Type: <anonymous type: ? a>, IsInvalid) (Syntax: 'new { a = }')
                          Initializers(1):
                              ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: ?, IsInvalid) (Syntax: 'a = ')
                                Left: 
                                  IPropertyReferenceOperation: ? <anonymous type: ? a>.a { get; } (OperationKind.PropertyReference, Type: ?) (Syntax: 'a')
                                    Instance Receiver: 
                                      IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: <anonymous type: ? a>, IsInvalid, IsImplicit) (Syntax: 'new { a = }')
                                Right: 
                                  IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: null, IsInvalid, IsImplicit) (Syntax: '')

        Next (Regular) Block[B2]
            Leaving: {R1}
}

Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22005,76938,77234);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22005_77133_77218(f_22005_77133_77198(f_22005_77133_77179(ErrorCode.ERR_InvalidExprTerm, "}"), "}"), 8, 23)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22005,77250,77348);

f_22005_77250_77347(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22005,73760,77359);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22005,73760,77359);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22005,73760,77359);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void AnonymousObjectCreation_NoControlFlow_Error03()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22005,77371,82385);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22005,77666,77837);

string 
source = @"
using System;

class C
{
    void M(object p, int i)
    /*<bind>*/{
        p = new { M2() = i };
    }/*</bind>*/

    int M2() => 0;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22005,77851,81560);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'p')
              Value: 
                IParameterReferenceOperation: p (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'p')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'M2() = i')
              Value: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsInvalid) (Syntax: 'M2() = i')
                  Left: 
                    IInvalidOperation (OperationKind.Invalid, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'M2()')
                      Children(1):
                          IInvocationOperation ( System.Int32 C.M2()) (OperationKind.Invocation, Type: System.Int32, IsInvalid) (Syntax: 'M2()')
                            Instance Receiver: 
                              IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C, IsInvalid, IsImplicit) (Syntax: 'M2')
                            Arguments(0)
                  Right: 
                    IParameterReferenceOperation: i (OperationKind.ParameterReference, Type: System.Int32, IsInvalid) (Syntax: 'i')

            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: 'p = new { M2() = i };')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Object, IsInvalid) (Syntax: 'p = new { M2() = i }')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'p')
                  Right: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsInvalid, IsImplicit) (Syntax: 'new { M2() = i }')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                        (ImplicitReference)
                      Operand: 
                        IAnonymousObjectCreationOperation (OperationKind.AnonymousObjectCreation, Type: <anonymous type: System.Int32 $0>, IsInvalid) (Syntax: 'new { M2() = i }')
                          Initializers(1):
                              ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'M2() = i')
                                Left: 
                                  IPropertyReferenceOperation: System.Int32 <anonymous type: System.Int32 $0>.$0 { get; } (OperationKind.PropertyReference, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'M2() = i')
                                    Instance Receiver: 
                                      IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: <anonymous type: System.Int32 $0>, IsInvalid, IsImplicit) (Syntax: 'new { M2() = i }')
                                Right: 
                                  IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'M2() = i')

        Next (Regular) Block[B2]
            Leaving: {R1}
}

Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22005,81574,82260);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22005_81884_81978(f_22005_81884_81958(ErrorCode.ERR_InvalidAnonymousTypeMemberDeclarator, "M2() = i"), 8, 19),
f_22005_82172_82244(f_22005_82172_82224(ErrorCode.ERR_AssgLvalueExpected, "M2()"), 8, 19)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22005,82276,82374);

f_22005_82276_82373(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22005,77371,82385);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22005,77371,82385);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22005,77371,82385);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void AnonymousObjectCreation_NoControlFlow_Error04()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22005,82397,87097);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22005,82650,82806);

string 
source = @"
using System;

class C
{
    void M(object p, int i, int j)
    /*<bind>*/{
        p = new { a[i] = j };
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22005,82820,86284);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'p')
              Value: 
                IParameterReferenceOperation: p (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'p')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'a[i] = j')
              Value: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: ?, IsInvalid) (Syntax: 'a[i] = j')
                  Left: 
                    IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid) (Syntax: 'a[i]')
                      Children(2):
                          IParameterReferenceOperation: i (OperationKind.ParameterReference, Type: System.Int32, IsInvalid) (Syntax: 'i')
                          IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid) (Syntax: 'a')
                            Children(0)
                  Right: 
                    IParameterReferenceOperation: j (OperationKind.ParameterReference, Type: System.Int32, IsInvalid) (Syntax: 'j')

            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: 'p = new { a[i] = j };')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Object, IsInvalid) (Syntax: 'p = new { a[i] = j }')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'p')
                  Right: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsInvalid, IsImplicit) (Syntax: 'new { a[i] = j }')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                        (ImplicitReference)
                      Operand: 
                        IAnonymousObjectCreationOperation (OperationKind.AnonymousObjectCreation, Type: <anonymous type: ? $0>, IsInvalid) (Syntax: 'new { a[i] = j }')
                          Initializers(1):
                              ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: ?, IsInvalid, IsImplicit) (Syntax: 'a[i] = j')
                                Left: 
                                  IPropertyReferenceOperation: ? <anonymous type: ? $0>.$0 { get; } (OperationKind.PropertyReference, Type: ?, IsInvalid, IsImplicit) (Syntax: 'a[i] = j')
                                    Instance Receiver: 
                                      IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: <anonymous type: ? $0>, IsInvalid, IsImplicit) (Syntax: 'new { a[i] = j }')
                                Right: 
                                  IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: ?, IsInvalid, IsImplicit) (Syntax: 'a[i] = j')

        Next (Regular) Block[B2]
            Leaving: {R1}
}

Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22005,86298,86972);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22005_86607_86701(f_22005_86607_86681(ErrorCode.ERR_InvalidAnonymousTypeMemberDeclarator, "a[i] = j"), 8, 19),
f_22005_86870_86956(f_22005_86870_86936(f_22005_86870_86917(ErrorCode.ERR_NameNotInContext, "a"), "a"), 8, 19)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22005,86988,87086);

f_22005_86988_87085(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22005,82397,87097);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22005,82397,87097);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22005,82397,87097);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void AnonymousObjectCreation_ControlFlowInFirstInitializer()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22005,87109,93433);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22005,87296,87473);

string 
source = @"
using System;

class C
{
    void M(object p, int? i1, int i2, int j)
    /*<bind>*/{
        p = new { a = i1 ?? i2, b = j };
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22005,87487,93241);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [2] [3]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'p')
              Value: 
                IParameterReferenceOperation: p (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'p')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i1')
                  Value: 
                    IParameterReferenceOperation: i1 (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'i1')

            Jump if True (Regular) to Block[B4]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'i1')
                  Operand: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'i1')
                Leaving: {R2}

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i1')
                  Value: 
                    IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsImplicit) (Syntax: 'i1')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'i1')
                      Arguments(0)

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B4] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i2')
              Value: 
                IParameterReferenceOperation: i2 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i2')

        Next (Regular) Block[B5]
    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (2)
            IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'j')
              Value: 
                IParameterReferenceOperation: j (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'j')

            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'p = new { a ... 2, b = j };')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Object) (Syntax: 'p = new { a ... i2, b = j }')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'p')
                  Right: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsImplicit) (Syntax: 'new { a = i ... i2, b = j }')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                        (ImplicitReference)
                      Operand: 
                        IAnonymousObjectCreationOperation (OperationKind.AnonymousObjectCreation, Type: <anonymous type: System.Int32 a, System.Int32 b>) (Syntax: 'new { a = i ... i2, b = j }')
                          Initializers(2):
                              ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'a = i1 ?? i2')
                                Left: 
                                  IPropertyReferenceOperation: System.Int32 <anonymous type: System.Int32 a, System.Int32 b>.a { get; } (OperationKind.PropertyReference, Type: System.Int32) (Syntax: 'a')
                                    Instance Receiver: 
                                      IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: <anonymous type: System.Int32 a, System.Int32 b>, IsImplicit) (Syntax: 'new { a = i ... i2, b = j }')
                                Right: 
                                  IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'i1 ?? i2')
                              ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'b = j')
                                Left: 
                                  IPropertyReferenceOperation: System.Int32 <anonymous type: System.Int32 a, System.Int32 b>.b { get; } (OperationKind.PropertyReference, Type: System.Int32) (Syntax: 'b')
                                    Instance Receiver: 
                                      IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: <anonymous type: System.Int32 a, System.Int32 b>, IsImplicit) (Syntax: 'new { a = i ... i2, b = j }')
                                Right: 
                                  IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'j')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22005,93255,93308);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22005,93324,93422);

f_22005_93324_93421(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22005,87109,93433);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22005,87109,93433);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22005,87109,93433);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void AnonymousObjectCreation_ControlFlowInSecondInitializer()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22005,93445,99770);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22005,93633,93810);

string 
source = @"
using System;

class C
{
    void M(object p, int? i1, int i2, int j)
    /*<bind>*/{
        p = new { a = j, b = i1 ?? i2 };
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22005,93824,99578);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [1] [3]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (2)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'p')
              Value: 
                IParameterReferenceOperation: p (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'p')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'j')
              Value: 
                IParameterReferenceOperation: j (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'j')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
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
                Leaving: {R2}

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
                Leaving: {R2}
    }

    Block[B4] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i2')
              Value: 
                IParameterReferenceOperation: i2 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i2')

        Next (Regular) Block[B5]
    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'p = new { a ... i1 ?? i2 };')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Object) (Syntax: 'p = new { a ...  i1 ?? i2 }')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'p')
                  Right: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsImplicit) (Syntax: 'new { a = j ...  i1 ?? i2 }')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                        (ImplicitReference)
                      Operand: 
                        IAnonymousObjectCreationOperation (OperationKind.AnonymousObjectCreation, Type: <anonymous type: System.Int32 a, System.Int32 b>) (Syntax: 'new { a = j ...  i1 ?? i2 }')
                          Initializers(2):
                              ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'a = j')
                                Left: 
                                  IPropertyReferenceOperation: System.Int32 <anonymous type: System.Int32 a, System.Int32 b>.a { get; } (OperationKind.PropertyReference, Type: System.Int32) (Syntax: 'a')
                                    Instance Receiver: 
                                      IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: <anonymous type: System.Int32 a, System.Int32 b>, IsImplicit) (Syntax: 'new { a = j ...  i1 ?? i2 }')
                                Right: 
                                  IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'j')
                              ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'b = i1 ?? i2')
                                Left: 
                                  IPropertyReferenceOperation: System.Int32 <anonymous type: System.Int32 a, System.Int32 b>.b { get; } (OperationKind.PropertyReference, Type: System.Int32) (Syntax: 'b')
                                    Instance Receiver: 
                                      IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: <anonymous type: System.Int32 a, System.Int32 b>, IsImplicit) (Syntax: 'new { a = j ...  i1 ?? i2 }')
                                Right: 
                                  IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'i1 ?? i2')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22005,99592,99645);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22005,99661,99759);

f_22005_99661_99758(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22005,93445,99770);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22005,93445,99770);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22005,93445,99770);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void AnonymousObjectCreation_ControlFlowInMultipleInitializers()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22005,99782,107807);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22005,99973,100167);

string 
source = @"
using System;

class C
{
    void M(object p, int? i1, int i2, int? j1, int j2)
    /*<bind>*/{
        p = new { a = i1 ?? i2, b = j1 ?? j2 };
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22005,100181,107615);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [2] [4]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'p')
              Value: 
                IParameterReferenceOperation: p (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'p')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i1')
                  Value: 
                    IParameterReferenceOperation: i1 (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'i1')

            Jump if True (Regular) to Block[B4]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'i1')
                  Operand: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'i1')
                Leaving: {R2}

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i1')
                  Value: 
                    IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsImplicit) (Syntax: 'i1')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'i1')
                      Arguments(0)

            Next (Regular) Block[B5]
                Leaving: {R2}
                Entering: {R3}
    }

    Block[B4] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i2')
              Value: 
                IParameterReferenceOperation: i2 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i2')

        Next (Regular) Block[B5]
            Entering: {R3}

    .locals {R3}
    {
        CaptureIds: [3]
        Block[B5] - Block
            Predecessors: [B3] [B4]
            Statements (1)
                IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'j1')
                  Value: 
                    IParameterReferenceOperation: j1 (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'j1')

            Jump if True (Regular) to Block[B7]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'j1')
                  Operand: 
                    IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'j1')
                Leaving: {R3}

            Next (Regular) Block[B6]
        Block[B6] - Block
            Predecessors: [B5]
            Statements (1)
                IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'j1')
                  Value: 
                    IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsImplicit) (Syntax: 'j1')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'j1')
                      Arguments(0)

            Next (Regular) Block[B8]
                Leaving: {R3}
    }

    Block[B7] - Block
        Predecessors: [B5]
        Statements (1)
            IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'j2')
              Value: 
                IParameterReferenceOperation: j2 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'j2')

        Next (Regular) Block[B8]
    Block[B8] - Block
        Predecessors: [B6] [B7]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'p = new { a ... j1 ?? j2 };')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Object) (Syntax: 'p = new { a ...  j1 ?? j2 }')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'p')
                  Right: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsImplicit) (Syntax: 'new { a = i ...  j1 ?? j2 }')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                        (ImplicitReference)
                      Operand: 
                        IAnonymousObjectCreationOperation (OperationKind.AnonymousObjectCreation, Type: <anonymous type: System.Int32 a, System.Int32 b>) (Syntax: 'new { a = i ...  j1 ?? j2 }')
                          Initializers(2):
                              ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'a = i1 ?? i2')
                                Left: 
                                  IPropertyReferenceOperation: System.Int32 <anonymous type: System.Int32 a, System.Int32 b>.a { get; } (OperationKind.PropertyReference, Type: System.Int32) (Syntax: 'a')
                                    Instance Receiver: 
                                      IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: <anonymous type: System.Int32 a, System.Int32 b>, IsImplicit) (Syntax: 'new { a = i ...  j1 ?? j2 }')
                                Right: 
                                  IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'i1 ?? i2')
                              ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'b = j1 ?? j2')
                                Left: 
                                  IPropertyReferenceOperation: System.Int32 <anonymous type: System.Int32 a, System.Int32 b>.b { get; } (OperationKind.PropertyReference, Type: System.Int32) (Syntax: 'b')
                                    Instance Receiver: 
                                      IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: <anonymous type: System.Int32 a, System.Int32 b>, IsImplicit) (Syntax: 'new { a = i ...  j1 ?? j2 }')
                                Right: 
                                  IFlowCaptureReferenceOperation: 4 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'j1 ?? j2')

        Next (Regular) Block[B9]
            Leaving: {R1}
}

Block[B9] - Exit
    Predecessors: [B8]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22005,107629,107682);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22005,107698,107796);

f_22005_107698_107795(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22005,99782,107807);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22005,99782,107807);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22005,99782,107807);
}
		}

[Fact]
        public void AnonymousObjectCreation_NullableEnabled_PropertyMatches()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22005,107819,110817);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22005,107929,108106);

var 
source = @"
#nullable enable
class C
{
    void M(int i1, object o1)
    {
        var obj = /*<bind>*/new { a = i1, o1, b = ""Hello world!"" }/*</bind>*/;
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22005,108122,110628);

var 
expectedOperationTree = @"
IAnonymousObjectCreationOperation (OperationKind.AnonymousObjectCreation, Type: <anonymous type: System.Int32 a, System.Object o1, System.String b>) (Syntax: 'new { a = i ... o world!"" }')
  Initializers(3):
      ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'a = i1')
        Left: 
          IPropertyReferenceOperation: System.Int32 <anonymous type: System.Int32 a, System.Object o1, System.String b>.a { get; } (OperationKind.PropertyReference, Type: System.Int32) (Syntax: 'a')
            Instance Receiver: 
              IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: <anonymous type: System.Int32 a, System.Object o1, System.String b>, IsImplicit) (Syntax: 'new { a = i ... o world!"" }')
        Right: 
          IParameterReferenceOperation: i1 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i1')
      ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Object, IsImplicit) (Syntax: 'o1')
        Left: 
          IPropertyReferenceOperation: System.Object <anonymous type: System.Int32 a, System.Object o1, System.String b>.o1 { get; } (OperationKind.PropertyReference, Type: System.Object, IsImplicit) (Syntax: 'o1')
            Instance Receiver: 
              IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: <anonymous type: System.Int32 a, System.Object o1, System.String b>, IsImplicit) (Syntax: 'new { a = i ... o world!"" }')
        Right: 
          IParameterReferenceOperation: o1 (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'o1')
      ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.String, Constant: ""Hello world!"") (Syntax: 'b = ""Hello world!""')
        Left: 
          IPropertyReferenceOperation: System.String <anonymous type: System.Int32 a, System.Object o1, System.String b>.b { get; } (OperationKind.PropertyReference, Type: System.String) (Syntax: 'b')
            Instance Receiver: 
              IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: <anonymous type: System.Int32 a, System.Object o1, System.String b>, IsImplicit) (Syntax: 'new { a = i ... o world!"" }')
        Right: 
          ILiteralOperation (OperationKind.Literal, Type: System.String, Constant: ""Hello world!"") (Syntax: '""Hello world!""')"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22005,110644,110806);

f_22005_110644_110805(source, expectedOperationTree, expectedDiagnostics: DiagnosticDescription.None);
DynAbs.Tracing.TraceSender.TraceExitMethod(22005,107819,110817);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22005,107819,110817);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22005,107819,110817);
}
		}

int
f_22005_4868_4965(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22005, 4868, 4965);
return 0;
}


int
f_22005_9880_9977(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22005, 9880, 9977);
return 0;
}


int
f_22005_14480_14577(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22005, 14480, 14577);
return 0;
}


int
f_22005_34719_34816(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22005, 34719, 34816);
return 0;
}


int
f_22005_51885_51982(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22005, 51885, 51982);
return 0;
}


int
f_22005_59054_59151(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22005, 59054, 59151);
return 0;
}


int
f_22005_66795_66892(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22005, 66795, 66892);
return 0;
}


int
f_22005_68630_68727(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22005, 68630, 68727);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22005_73522_73587(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22005, 73522, 73587);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22005_73522_73607(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22005, 73522, 73607);
return return_v;
}


int
f_22005_73639_73736(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22005, 73639, 73736);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22005_77133_77179(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22005, 77133, 77179);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22005_77133_77198(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22005, 77133, 77198);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22005_77133_77218(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22005, 77133, 77218);
return return_v;
}


int
f_22005_77250_77347(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22005, 77250, 77347);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22005_81884_81958(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22005, 81884, 81958);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22005_81884_81978(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22005, 81884, 81978);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22005_82172_82224(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22005, 82172, 82224);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22005_82172_82244(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22005, 82172, 82244);
return return_v;
}


int
f_22005_82276_82373(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22005, 82276, 82373);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22005_86607_86681(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22005, 86607, 86681);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22005_86607_86701(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22005, 86607, 86701);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22005_86870_86917(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22005, 86870, 86917);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22005_86870_86936(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22005, 86870, 86936);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22005_86870_86956(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22005, 86870, 86956);
return return_v;
}


int
f_22005_86988_87085(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22005, 86988, 87085);
return 0;
}


int
f_22005_93324_93421(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22005, 93324, 93421);
return 0;
}


int
f_22005_99661_99758(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22005, 99661, 99758);
return 0;
}


int
f_22005_107698_107795(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22005, 107698, 107795);
return 0;
}


int
f_22005_110644_110805(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<AnonymousObjectCreationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics:expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22005, 110644, 110805);
return 0;
}

}
}
