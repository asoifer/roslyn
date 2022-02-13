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
        public void IEventReference_AddEvent_StaticEventAccessOnClass()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22032,471,1564);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22032,628,863);

string 
source = @"
using System;
using System.Collections.Generic;

class C
{
    static event EventHandler Event;

    public static void M()
    {
        /*<bind>*/C.Event/*</bind>*/ += (sender, args) => { };
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22032,877,1095);

string 
expectedOperationTree = @"
IEventReferenceOperation: event System.EventHandler C.Event (Static) (OperationKind.EventReference, Type: System.EventHandler) (Syntax: 'C.Event')
  Instance Receiver: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22032,1109,1414);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22032_1301_1398(f_22032_1301_1378(f_22032_1301_1353(ErrorCode.WRN_UnreferencedEvent, "Event"), "C.Event"), 7, 31)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22032,1430,1553);

f_22032_1430_1552(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22032,471,1564);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22032,471,1564);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22032,471,1564);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IEventReference_AddEvent_InstanceEventAccessOnClass()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22032,1576,2974);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22032,1735,1963);

string 
source = @"
using System;
using System.Collections.Generic;

class C
{
    event EventHandler Event;

    public static void M()
    {
        /*<bind>*/C.Event/*</bind>*/ += (sender, args) => { };
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22032,1977,2197);

string 
expectedOperationTree = @"
IEventReferenceOperation: event System.EventHandler C.Event (OperationKind.EventReference, Type: System.EventHandler, IsInvalid) (Syntax: 'C.Event')
  Instance Receiver: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22032,2211,2824);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22032_2483_2580(f_22032_2483_2559(f_22032_2483_2534(ErrorCode.ERR_ObjectRequired, "C.Event"), "C.Event"), 11, 19),
f_22032_2711_2808(f_22032_2711_2788(f_22032_2711_2763(ErrorCode.WRN_UnreferencedEvent, "Event"), "C.Event"), 7, 24)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22032,2840,2963);

f_22032_2840_2962(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22032,1576,2974);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22032,1576,2974);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22032,1576,2974);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IEventReference_AddEvent_StaticEventWithInstanceReceiver()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22032,2986,4540);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22032,3150,3411);

string 
source = @"
using System;
using System.Collections.Generic;

class C
{
    static event EventHandler Event;

    public static void M()
    {
        var c = new C();
        /*<bind>*/c.Event/*</bind>*/ += (sender, args) => { };
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22032,3425,3742);

string 
expectedOperationTree = @"
IEventReferenceOperation: event System.EventHandler C.Event (Static) (OperationKind.EventReference, Type: System.EventHandler, IsInvalid) (Syntax: 'c.Event')
  Instance Receiver: 
    ILocalReferenceOperation: c (OperationKind.LocalReference, Type: C, IsInvalid) (Syntax: 'c')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22032,3756,4390);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22032_4040_4139(f_22032_4040_4118(f_22032_4040_4093(ErrorCode.ERR_ObjectProhibited, "c.Event"), "C.Event"), 12, 19),
f_22032_4277_4374(f_22032_4277_4354(f_22032_4277_4329(ErrorCode.WRN_UnreferencedEvent, "Event"), "C.Event"), 7, 31)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22032,4406,4529);

f_22032_4406_4528(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22032,2986,4540);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22032,2986,4540);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22032,2986,4540);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IEventReference_AccessEvent_StaticEventAccessOnClass()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22032,4552,5348);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22032,4712,4899);

string 
source = @"
using System;

class C
{
    static event EventHandler Event;

    public static void M()
    {
        /*<bind>*/C.Event/*</bind>*/(null, null);
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22032,4913,5131);

string 
expectedOperationTree = @"
IEventReferenceOperation: event System.EventHandler C.Event (Static) (OperationKind.EventReference, Type: System.EventHandler) (Syntax: 'C.Event')
  Instance Receiver: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22032,5145,5198);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22032,5214,5337);

f_22032_5214_5336(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22032,4552,5348);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22032,4552,5348);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22032,4552,5348);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IEventReference_AccessEvent_InstanceEventAccessOnClass()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22032,5360,6472);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22032,5522,5702);

string 
source = @"
using System;

class C
{
    event EventHandler Event;

    public static void M()
    {
        /*<bind>*/C.Event/*</bind>*/(null, null);
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22032,5716,5936);

string 
expectedOperationTree = @"
IEventReferenceOperation: event System.EventHandler C.Event (OperationKind.EventReference, Type: System.EventHandler, IsInvalid) (Syntax: 'C.Event')
  Instance Receiver: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22032,5950,6322);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22032_6209_6306(f_22032_6209_6285(f_22032_6209_6260(ErrorCode.ERR_ObjectRequired, "C.Event"), "C.Event"), 10, 19)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22032,6338,6461);

f_22032_6338_6460(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22032,5360,6472);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22032,5360,6472);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22032,5360,6472);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IEventReference_AccessEvent_StaticEventWithInstanceReceiver()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22032,6484,7745);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22032,6651,6864);

string 
source = @"
using System;

class C
{
    static event EventHandler Event;

    public static void M()
    {
        var c = new C();
        /*<bind>*/c.Event/*</bind>*/(null, null);
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22032,6878,7195);

string 
expectedOperationTree = @"
IEventReferenceOperation: event System.EventHandler C.Event (Static) (OperationKind.EventReference, Type: System.EventHandler, IsInvalid) (Syntax: 'c.Event')
  Instance Receiver: 
    ILocalReferenceOperation: c (OperationKind.LocalReference, Type: C, IsInvalid) (Syntax: 'c')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22032,7209,7595);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22032_7480_7579(f_22032_7480_7558(f_22032_7480_7533(ErrorCode.ERR_ObjectProhibited, "c.Event"), "C.Event"), 11, 19)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22032,7611,7734);

f_22032_7611_7733(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22032,6484,7745);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22032,6484,7745);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22032,6484,7745);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void EventReference_NoControlFlow()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22032,7757,11172);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22032,8004,8431);

string 
source = @"
using System;

class C
{
#pragma warning disable CS0067 // The event is never used
    public event EventHandler Event1;
    public static event EventHandler Event2;

    public void M(C c, EventHandler handler1, EventHandler handler2, EventHandler handler3)
    /*<bind>*/
    {
        handler1 = this.Event1;
        c.Event1 = handler2;
        handler3 = C.Event2;
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22032,8445,10980);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (3)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'handler1 = this.Event1;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.EventHandler) (Syntax: 'handler1 = this.Event1')
              Left: 
                IParameterReferenceOperation: handler1 (OperationKind.ParameterReference, Type: System.EventHandler) (Syntax: 'handler1')
              Right: 
                IEventReferenceOperation: event System.EventHandler C.Event1 (OperationKind.EventReference, Type: System.EventHandler) (Syntax: 'this.Event1')
                  Instance Receiver: 
                    IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C) (Syntax: 'this')

        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'c.Event1 = handler2;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.EventHandler) (Syntax: 'c.Event1 = handler2')
              Left: 
                IEventReferenceOperation: event System.EventHandler C.Event1 (OperationKind.EventReference, Type: System.EventHandler) (Syntax: 'c.Event1')
                  Instance Receiver: 
                    IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: C) (Syntax: 'c')
              Right: 
                IParameterReferenceOperation: handler2 (OperationKind.ParameterReference, Type: System.EventHandler) (Syntax: 'handler2')

        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'handler3 = C.Event2;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.EventHandler) (Syntax: 'handler3 = C.Event2')
              Left: 
                IParameterReferenceOperation: handler3 (OperationKind.ParameterReference, Type: System.EventHandler) (Syntax: 'handler3')
              Right: 
                IEventReferenceOperation: event System.EventHandler C.Event2 (Static) (OperationKind.EventReference, Type: System.EventHandler) (Syntax: 'C.Event2')
                  Instance Receiver: 
                    null

    Next (Regular) Block[B2]
Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22032,10994,11047);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22032,11063,11161);

f_22032_11063_11160(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22032,7757,11172);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22032,7757,11172);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22032,7757,11172);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void EventReference_ControlFlowInReceiver()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22032,11184,15046);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22032,11354,11641);

string 
source = @"
using System;

class C
{
#pragma warning disable CS0067 // The event is never used
    private event EventHandler Event1;

    public void M(C c1, C c2, EventHandler handler)
    /*<bind>*/
    {
        handler = (c1 ?? c2).Event1;
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22032,11655,14854);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [2]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'handler')
              Value: 
                IParameterReferenceOperation: handler (OperationKind.ParameterReference, Type: System.EventHandler) (Syntax: 'handler')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c1')
                  Value: 
                    IParameterReferenceOperation: c1 (OperationKind.ParameterReference, Type: C) (Syntax: 'c1')

            Jump if True (Regular) to Block[B4]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'c1')
                  Operand: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'c1')
                Leaving: {R2}

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c1')
                  Value: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'c1')

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B4] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c2')
              Value: 
                IParameterReferenceOperation: c2 (OperationKind.ParameterReference, Type: C) (Syntax: 'c2')

        Next (Regular) Block[B5]
    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'handler = ( ... c2).Event1;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.EventHandler) (Syntax: 'handler = ( ...  c2).Event1')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.EventHandler, IsImplicit) (Syntax: 'handler')
                  Right: 
                    IEventReferenceOperation: event System.EventHandler C.Event1 (OperationKind.EventReference, Type: System.EventHandler) (Syntax: '(c1 ?? c2).Event1')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'c1 ?? c2')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22032,14868,14921);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22032,14937,15035);

f_22032_14937_15034(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22032,11184,15046);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22032,11184,15046);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22032,11184,15046);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void EventReference_ControlFlowInReceiver_StaticEvent()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22032,15058,18209);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22032,15240,15590);

string 
source = @"
using System;

class C
{
#pragma warning disable CS0067 // The event is never used
    private static event EventHandler Event1;

    public void M(C c1, C c2, EventHandler handler1, EventHandler handler2)
    /*<bind>*/
    {
        handler1 = c1.Event1;
        handler2 = (c1 ?? c2).Event1;
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22032,15604,17340);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (2)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: 'handler1 = c1.Event1;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.EventHandler, IsInvalid) (Syntax: 'handler1 = c1.Event1')
              Left: 
                IParameterReferenceOperation: handler1 (OperationKind.ParameterReference, Type: System.EventHandler) (Syntax: 'handler1')
              Right: 
                IEventReferenceOperation: event System.EventHandler C.Event1 (Static) (OperationKind.EventReference, Type: System.EventHandler, IsInvalid) (Syntax: 'c1.Event1')
                  Instance Receiver: 
                    null

        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: 'handler2 =  ... c2).Event1;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.EventHandler, IsInvalid) (Syntax: 'handler2 =  ...  c2).Event1')
              Left: 
                IParameterReferenceOperation: handler2 (OperationKind.ParameterReference, Type: System.EventHandler) (Syntax: 'handler2')
              Right: 
                IEventReferenceOperation: event System.EventHandler C.Event1 (Static) (OperationKind.EventReference, Type: System.EventHandler, IsInvalid) (Syntax: '(c1 ?? c2).Event1')
                  Instance Receiver: 
                    null

    Next (Regular) Block[B2]
Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22032,17354,18084);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22032_17628_17730(f_22032_17628_17709(f_22032_17628_17683(ErrorCode.ERR_ObjectProhibited, "c1.Event1"), "C.Event1"), 12, 20),
f_22032_17958_18068(f_22032_17958_18047(f_22032_17958_18021(ErrorCode.ERR_ObjectProhibited, "(c1 ?? c2).Event1"), "C.Event1"), 13, 20)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22032,18100,18198);

f_22032_18100_18197(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22032,15058,18209);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22032,15058,18209);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22032,15058,18209);
}
		}

Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22032_1301_1353(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22032, 1301, 1353);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22032_1301_1378(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22032, 1301, 1378);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22032_1301_1398(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22032, 1301, 1398);
return return_v;
}


int
f_22032_1430_1552(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<MemberAccessExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22032, 1430, 1552);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22032_2483_2534(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22032, 2483, 2534);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22032_2483_2559(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22032, 2483, 2559);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22032_2483_2580(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22032, 2483, 2580);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22032_2711_2763(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22032, 2711, 2763);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22032_2711_2788(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22032, 2711, 2788);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22032_2711_2808(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22032, 2711, 2808);
return return_v;
}


int
f_22032_2840_2962(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<MemberAccessExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22032, 2840, 2962);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22032_4040_4093(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22032, 4040, 4093);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22032_4040_4118(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22032, 4040, 4118);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22032_4040_4139(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22032, 4040, 4139);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22032_4277_4329(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22032, 4277, 4329);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22032_4277_4354(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22032, 4277, 4354);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22032_4277_4374(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22032, 4277, 4374);
return return_v;
}


int
f_22032_4406_4528(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<MemberAccessExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22032, 4406, 4528);
return 0;
}


int
f_22032_5214_5336(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<MemberAccessExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22032, 5214, 5336);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22032_6209_6260(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22032, 6209, 6260);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22032_6209_6285(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22032, 6209, 6285);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22032_6209_6306(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22032, 6209, 6306);
return return_v;
}


int
f_22032_6338_6460(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<MemberAccessExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22032, 6338, 6460);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22032_7480_7533(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22032, 7480, 7533);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22032_7480_7558(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22032, 7480, 7558);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22032_7480_7579(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22032, 7480, 7579);
return return_v;
}


int
f_22032_7611_7733(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<MemberAccessExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22032, 7611, 7733);
return 0;
}


int
f_22032_11063_11160(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22032, 11063, 11160);
return 0;
}


int
f_22032_14937_15034(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22032, 14937, 15034);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22032_17628_17683(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22032, 17628, 17683);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22032_17628_17709(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22032, 17628, 17709);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22032_17628_17730(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22032, 17628, 17730);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22032_17958_18021(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22032, 17958, 18021);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22032_17958_18047(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22032, 17958, 18047);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22032_17958_18068(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22032, 17958, 18068);
return return_v;
}


int
f_22032_18100_18197(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22032, 18100, 18197);
return 0;
}

}
}
