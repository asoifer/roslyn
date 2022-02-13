// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Test.Utilities;
using Roslyn.Test.Utilities;
using Xunit;

namespace Microsoft.CodeAnalysis.CSharp.UnitTests
{
public partial class IOperationTests : SemanticModelTestBase
{
[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void AddEventHandler()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22031,501,2357);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22031,624,913);

string 
source = @"
using System;

class Test
{
    public event EventHandler MyEvent;   
}

class C
{
    void Handler(object sender, EventArgs e)
    {
    } 

    void M()
    {
        var t = new Test();
        /*<bind>*/t.MyEvent += Handler/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22031,927,1875);

string 
expectedOperationTree = @"
IEventAssignmentOperation (EventAdd) (OperationKind.EventAssignment, Type: System.Void) (Syntax: 't.MyEvent += Handler')
  Event Reference: 
    IEventReferenceOperation: event System.EventHandler Test.MyEvent (OperationKind.EventReference, Type: System.EventHandler) (Syntax: 't.MyEvent')
      Instance Receiver: 
        ILocalReferenceOperation: t (OperationKind.LocalReference, Type: Test) (Syntax: 't')
  Handler: 
    IDelegateCreationOperation (OperationKind.DelegateCreation, Type: System.EventHandler, IsImplicit) (Syntax: 'Handler')
      Target: 
        IMethodReferenceOperation: void C.Handler(System.Object sender, System.EventArgs e) (OperationKind.MethodReference, Type: null) (Syntax: 'Handler')
          Instance Receiver: 
            IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C, IsImplicit) (Syntax: 'Handler')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22031,1889,2209);

var 
expectedDiagnostics = new[] {
f_22031_2089_2193(f_22031_2089_2173(f_22031_2089_2143(ErrorCode.WRN_UnreferencedEvent, "MyEvent"), "Test.MyEvent"), 6, 31)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22031,2225,2346);

f_22031_2225_2345(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22031,501,2357);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22031,501,2357);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22031,501,2357);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void AddEventHandler_JustHandlerReturnsMethodReference()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22031,2369,3657);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22031,2526,2811);

string 
source = @"
using System;

class Test
{
    public event EventHandler MyEvent;
}

class C
{
    void Handler(object sender, EventArgs e)
    {
    }

    void M()
    {
        var t = new Test();
        t.MyEvent += /*<bind>*/Handler/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22031,2825,3182);

string 
expectedOperationTree = @"
IMethodReferenceOperation: void C.Handler(System.Object sender, System.EventArgs e) (OperationKind.MethodReference, Type: null) (Syntax: 'Handler')
  Instance Receiver: 
    IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C, IsImplicit) (Syntax: 'Handler')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22031,3196,3515);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22031_3395_3499(f_22031_3395_3479(f_22031_3395_3449(ErrorCode.WRN_UnreferencedEvent, "MyEvent"), "Test.MyEvent"), 6, 31)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22031,3531,3646);

f_22031_3531_3645(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22031,2369,3657);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22031,2369,3657);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22031,2369,3657);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void RemoveEventHandler()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22031,3669,5394);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22031,3795,4018);

string 
source = @"
using System;

class Test
{
    public event EventHandler MyEvent;   
}

class C
{
    void M()
    {
        var t = new Test();
        /*<bind>*/t.MyEvent -= null/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22031,4032,4912);

string 
expectedOperationTree = @"
IEventAssignmentOperation (EventRemove) (OperationKind.EventAssignment, Type: System.Void) (Syntax: 't.MyEvent -= null')
  Event Reference: 
    IEventReferenceOperation: event System.EventHandler Test.MyEvent (OperationKind.EventReference, Type: System.EventHandler) (Syntax: 't.MyEvent')
      Instance Receiver: 
        ILocalReferenceOperation: t (OperationKind.LocalReference, Type: Test) (Syntax: 't')
  Handler: 
    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.EventHandler, Constant: null, IsImplicit) (Syntax: 'null')
      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
      Operand: 
        ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22031,4926,5246);

var 
expectedDiagnostics = new[] {
f_22031_5126_5230(f_22031_5126_5210(f_22031_5126_5180(ErrorCode.WRN_UnreferencedEvent, "MyEvent"), "Test.MyEvent"), 6, 31)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22031,5262,5383);

f_22031_5262_5382(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22031,3669,5394);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22031,3669,5394);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22031,3669,5394);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void AddEventHandler_StaticEvent()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22031,5406,7198);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22031,5541,5812);

string 
source = @"
using System;

class Test
{
    public static event EventHandler MyEvent;    
}

class C
{
    void Handler(object sender, EventArgs e)
    {
    } 

    void M()
    {
        /*<bind>*/Test.MyEvent += Handler/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22031,5826,6709);

string 
expectedOperationTree = @"
IEventAssignmentOperation (EventAdd) (OperationKind.EventAssignment, Type: System.Void) (Syntax: 'Test.MyEvent += Handler')
  Event Reference: 
    IEventReferenceOperation: event System.EventHandler Test.MyEvent (Static) (OperationKind.EventReference, Type: System.EventHandler) (Syntax: 'Test.MyEvent')
      Instance Receiver: 
        null
  Handler: 
    IDelegateCreationOperation (OperationKind.DelegateCreation, Type: System.EventHandler, IsImplicit) (Syntax: 'Handler')
      Target: 
        IMethodReferenceOperation: void C.Handler(System.Object sender, System.EventArgs e) (OperationKind.MethodReference, Type: null) (Syntax: 'Handler')
          Instance Receiver: 
            IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C, IsImplicit) (Syntax: 'Handler')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22031,6723,7050);

var 
expectedDiagnostics = new[] {
f_22031_6930_7034(f_22031_6930_7014(f_22031_6930_6984(ErrorCode.WRN_UnreferencedEvent, "MyEvent"), "Test.MyEvent"), 6, 38)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22031,7066,7187);

f_22031_7066_7186(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22031,5406,7198);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22031,5406,7198);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22031,5406,7198);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void RemoveEventHandler_StaticEvent()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22031,7210,9008);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22031,7348,7619);

string 
source = @"
using System;

class Test
{
    public static event EventHandler MyEvent;    
}

class C
{
    void Handler(object sender, EventArgs e)
    {
    } 

    void M()
    {
        /*<bind>*/Test.MyEvent -= Handler/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22031,7633,8519);

string 
expectedOperationTree = @"
IEventAssignmentOperation (EventRemove) (OperationKind.EventAssignment, Type: System.Void) (Syntax: 'Test.MyEvent -= Handler')
  Event Reference: 
    IEventReferenceOperation: event System.EventHandler Test.MyEvent (Static) (OperationKind.EventReference, Type: System.EventHandler) (Syntax: 'Test.MyEvent')
      Instance Receiver: 
        null
  Handler: 
    IDelegateCreationOperation (OperationKind.DelegateCreation, Type: System.EventHandler, IsImplicit) (Syntax: 'Handler')
      Target: 
        IMethodReferenceOperation: void C.Handler(System.Object sender, System.EventArgs e) (OperationKind.MethodReference, Type: null) (Syntax: 'Handler')
          Instance Receiver: 
            IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C, IsImplicit) (Syntax: 'Handler')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22031,8533,8860);

var 
expectedDiagnostics = new[] {
f_22031_8740_8844(f_22031_8740_8824(f_22031_8740_8794(ErrorCode.WRN_UnreferencedEvent, "MyEvent"), "Test.MyEvent"), 6, 38)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22031,8876,8997);

f_22031_8876_8996(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22031,7210,9008);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22031,7210,9008);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22031,7210,9008);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void AddEventHandler_DelegateTypeMismatch()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22031,9020,11199);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22031,9164,9440);

string 
source = @"
using System;

class Test
{
    public event EventHandler MyEvent;    
}

class C
{
    void Handler(object sender)
    {
    } 

    void M()
    {
        var t = new Test();
        /*<bind>*/t.MyEvent += Handler/*<bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22031,9454,10381);

string 
expectedOperationTree = @"
IEventAssignmentOperation (EventAdd) (OperationKind.EventAssignment, Type: System.Void, IsInvalid) (Syntax: 't.MyEvent += Handler')
  Event Reference: 
    IEventReferenceOperation: event System.EventHandler Test.MyEvent (OperationKind.EventReference, Type: System.EventHandler, IsInvalid) (Syntax: 't.MyEvent')
      Instance Receiver: 
        ILocalReferenceOperation: t (OperationKind.LocalReference, Type: Test, IsInvalid) (Syntax: 't')
  Handler: 
    IDelegateCreationOperation (OperationKind.DelegateCreation, Type: System.EventHandler, IsInvalid, IsImplicit) (Syntax: 'Handler')
      Target: 
        IOperation:  (OperationKind.None, Type: null, IsInvalid) (Syntax: 'Handler')
          Children(1):
              IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C, IsInvalid, IsImplicit) (Syntax: 'Handler')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22031,10395,11051);

var 
expectedDiagnostics = new[] {
f_22031_10624_10763(f_22031_10624_10742(f_22031_10624_10694(ErrorCode.ERR_MethDelegateMismatch, "t.MyEvent += Handler"), "Handler", "System.EventHandler"), 18, 19),
f_22031_10931_11035(f_22031_10931_11015(f_22031_10931_10985(ErrorCode.WRN_UnreferencedEvent, "MyEvent"), "Test.MyEvent"), 6, 31)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22031,11067,11188);

f_22031_11067_11187(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22031,9020,11199);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22031,9020,11199);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22031,9020,11199);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void AddEventHandler_AssignToStaticEventOnInstance()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22031,11211,13503);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22031,11364,11660);

string 
source = @"
using System;

class Test
{
    public static event EventHandler MyEvent;    
}

class C
{
    void Handler(object sender, EventArgs e)
    {
    } 

    void M()
    {
        var t = new Test();
        /*<bind>*/t.MyEvent += Handler/*<bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22031,11674,12664);

string 
expectedOperationTree = @"
IEventAssignmentOperation (EventAdd) (OperationKind.EventAssignment, Type: System.Void, IsInvalid) (Syntax: 't.MyEvent += Handler')
  Event Reference: 
    IEventReferenceOperation: event System.EventHandler Test.MyEvent (Static) (OperationKind.EventReference, Type: System.EventHandler, IsInvalid) (Syntax: 't.MyEvent')
      Instance Receiver: 
        ILocalReferenceOperation: t (OperationKind.LocalReference, Type: Test, IsInvalid) (Syntax: 't')
  Handler: 
    IDelegateCreationOperation (OperationKind.DelegateCreation, Type: System.EventHandler, IsImplicit) (Syntax: 'Handler')
      Target: 
        IMethodReferenceOperation: void C.Handler(System.Object sender, System.EventArgs e) (OperationKind.MethodReference, Type: null) (Syntax: 'Handler')
          Instance Receiver: 
            IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C, IsImplicit) (Syntax: 'Handler')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22031,12678,13355);

var 
expectedDiagnostics = new[] {
f_22031_12954_13060(f_22031_12954_13039(f_22031_12954_13009(ErrorCode.ERR_ObjectProhibited, "t.MyEvent"), "Test.MyEvent"), 18, 19),
f_22031_13235_13339(f_22031_13235_13319(f_22031_13235_13289(ErrorCode.WRN_UnreferencedEvent, "MyEvent"), "Test.MyEvent"), 6, 38)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22031,13371,13492);

f_22031_13371_13491(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22031,11211,13503);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22031,11211,13503);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22031,11211,13503);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        [WorkItem(8909, "https://github.com/dotnet/roslyn/issues/8909")]
        public void AddEventHandler_AssignToNonStaticEventOnType()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22031,13515,15738);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22031,13741,14004);

string 
source = @"
using System;

class Test
{
    public event EventHandler MyEvent;    
}

class C
{
    void Handler(object sender, EventArgs e)
    {
    } 

    void M()
    {
        /*<bind>*/Test.MyEvent += Handler/*<bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22031,14018,14914);

string 
expectedOperationTree = @"
IEventAssignmentOperation (EventAdd) (OperationKind.EventAssignment, Type: System.Void, IsInvalid) (Syntax: 'Test.MyEvent += Handler')
  Event Reference: 
    IEventReferenceOperation: event System.EventHandler Test.MyEvent (OperationKind.EventReference, Type: System.EventHandler, IsInvalid) (Syntax: 'Test.MyEvent')
      Instance Receiver: 
        null
  Handler: 
    IDelegateCreationOperation (OperationKind.DelegateCreation, Type: System.EventHandler, IsImplicit) (Syntax: 'Handler')
      Target: 
        IMethodReferenceOperation: void C.Handler(System.Object sender, System.EventArgs e) (OperationKind.MethodReference, Type: null) (Syntax: 'Handler')
          Instance Receiver: 
            IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C, IsImplicit) (Syntax: 'Handler')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22031,14928,15590);

var 
expectedDiagnostics = new[] {
f_22031_15195_15302(f_22031_15195_15281(f_22031_15195_15251(ErrorCode.ERR_ObjectRequired, "Test.MyEvent"), "Test.MyEvent"), 17, 19),
f_22031_15470_15574(f_22031_15470_15554(f_22031_15470_15524(ErrorCode.WRN_UnreferencedEvent, "MyEvent"), "Test.MyEvent"), 6, 31)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22031,15606,15727);

f_22031_15606_15726(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22031,13515,15738);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22031,13515,15738);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22031,13515,15738);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void AddEventHandler_AssignToEventWithoutExplicitReceiver()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22031,15750,17678);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22031,15910,16153);

string 
source = @"
using System;

class Test
{
    public event EventHandler MyEvent;  

    void Handler(object sender, EventArgs e)
    {
    } 

    void M()
    {
        /*<bind>*/MyEvent += Handler/*<bind>*/;
    }  
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22031,16167,17178);

string 
expectedOperationTree = @"
IEventAssignmentOperation (EventAdd) (OperationKind.EventAssignment, Type: System.Void) (Syntax: 'MyEvent += Handler')
  Event Reference: 
    IEventReferenceOperation: event System.EventHandler Test.MyEvent (OperationKind.EventReference, Type: System.EventHandler) (Syntax: 'MyEvent')
      Instance Receiver: 
        IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: Test, IsImplicit) (Syntax: 'MyEvent')
  Handler: 
    IDelegateCreationOperation (OperationKind.DelegateCreation, Type: System.EventHandler, IsImplicit) (Syntax: 'Handler')
      Target: 
        IMethodReferenceOperation: void Test.Handler(System.Object sender, System.EventArgs e) (OperationKind.MethodReference, Type: null) (Syntax: 'Handler')
          Instance Receiver: 
            IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: Test, IsImplicit) (Syntax: 'Handler')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22031,17192,17530);

var 
expectedDiagnostics = new[] {
f_22031_17410_17514(f_22031_17410_17494(f_22031_17410_17464(ErrorCode.WRN_UnreferencedEvent, "MyEvent"), "Test.MyEvent"), 6, 31)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22031,17546,17667);

f_22031_17546_17666(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22031,15750,17678);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22031,15750,17678);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22031,15750,17678);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void EventAssignment_NoControlFlow()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22031,17690,20252);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22031,17853,18161);

string 
source = @"
using System;

class C
{
#pragma warning disable CS0067 // Event is unused.
    public event EventHandler MyEvent;

    void M(C c, EventHandler handler1, EventHandler handler2)
    /*<bind>*/{
        c.MyEvent += handler1;
        MyEvent -= handler2;
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22031,18175,20060);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (2)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'c.MyEvent += handler1;')
          Expression: 
            IEventAssignmentOperation (EventAdd) (OperationKind.EventAssignment, Type: System.Void) (Syntax: 'c.MyEvent += handler1')
              Event Reference: 
                IEventReferenceOperation: event System.EventHandler C.MyEvent (OperationKind.EventReference, Type: System.EventHandler) (Syntax: 'c.MyEvent')
                  Instance Receiver: 
                    IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: C) (Syntax: 'c')
              Handler: 
                IParameterReferenceOperation: handler1 (OperationKind.ParameterReference, Type: System.EventHandler) (Syntax: 'handler1')

        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'MyEvent -= handler2;')
          Expression: 
            IEventAssignmentOperation (EventRemove) (OperationKind.EventAssignment, Type: System.Void) (Syntax: 'MyEvent -= handler2')
              Event Reference: 
                IEventReferenceOperation: event System.EventHandler C.MyEvent (OperationKind.EventReference, Type: System.EventHandler) (Syntax: 'MyEvent')
                  Instance Receiver: 
                    IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C, IsImplicit) (Syntax: 'MyEvent')
              Handler: 
                IParameterReferenceOperation: handler2 (OperationKind.ParameterReference, Type: System.EventHandler) (Syntax: 'handler2')

    Next (Regular) Block[B2]
Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22031,20074,20127);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22031,20143,20241);

f_22031_20143_20240(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22031,17690,20252);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22031,17690,20252);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22031,17690,20252);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void EventAssignment_ControlFlowInEventReference()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22031,20264,23717);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22031,20441,20716);

string 
source = @"
using System;

class C
{
#pragma warning disable CS0067 // Event is unused.
    public event EventHandler MyEvent;

    void M(C c1, C c2, EventHandler handler)
    /*<bind>*/
    {
        (c1 ?? c2).MyEvent += handler;
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22031,20730,23525);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2}

.locals {R1}
{
    CaptureIds: [1]
    .locals {R2}
    {
        CaptureIds: [0]
        Block[B1] - Block
            Predecessors: [B0]
            Statements (1)
                IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c1')
                  Value: 
                    IParameterReferenceOperation: c1 (OperationKind.ParameterReference, Type: C) (Syntax: 'c1')

            Jump if True (Regular) to Block[B3]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'c1')
                  Operand: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'c1')
                Leaving: {R2}

            Next (Regular) Block[B2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c1')
                  Value: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'c1')

            Next (Regular) Block[B4]
                Leaving: {R2}
    }

    Block[B3] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c2')
              Value: 
                IParameterReferenceOperation: c2 (OperationKind.ParameterReference, Type: C) (Syntax: 'c2')

        Next (Regular) Block[B4]
    Block[B4] - Block
        Predecessors: [B2] [B3]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: '(c1 ?? c2). ... += handler;')
              Expression: 
                IEventAssignmentOperation (EventAdd) (OperationKind.EventAssignment, Type: System.Void) (Syntax: '(c1 ?? c2). ...  += handler')
                  Event Reference: 
                    IEventReferenceOperation: event System.EventHandler C.MyEvent (OperationKind.EventReference, Type: System.EventHandler) (Syntax: '(c1 ?? c2).MyEvent')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'c1 ?? c2')
                  Handler: 
                    IParameterReferenceOperation: handler (OperationKind.ParameterReference, Type: System.EventHandler) (Syntax: 'handler')

        Next (Regular) Block[B5]
            Leaving: {R1}
}

Block[B5] - Exit
    Predecessors: [B4]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22031,23539,23592);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22031,23608,23706);

f_22031_23608_23705(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22031,20264,23717);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22031,20264,23717);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22031,20264,23717);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void EventAssignment_ControlFlowInEventReference_StaticEvent()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22031,23729,25800);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22031,23918,24200);

string 
source = @"
using System;

class C
{
#pragma warning disable CS0067 // Event is unused.
    public static event EventHandler MyEvent;

    void M(C c1, C c2, EventHandler handler)
    /*<bind>*/
    {
        (c1 ?? c2).MyEvent += handler;
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22031,24214,25235);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (1)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: '(c1 ?? c2). ... += handler;')
          Expression: 
            IEventAssignmentOperation (EventAdd) (OperationKind.EventAssignment, Type: System.Void, IsInvalid) (Syntax: '(c1 ?? c2). ...  += handler')
              Event Reference: 
                IEventReferenceOperation: event System.EventHandler C.MyEvent (Static) (OperationKind.EventReference, Type: System.EventHandler, IsInvalid) (Syntax: '(c1 ?? c2).MyEvent')
                  Instance Receiver: 
                    null
              Handler: 
                IParameterReferenceOperation: handler (OperationKind.ParameterReference, Type: System.EventHandler) (Syntax: 'handler')

    Next (Regular) Block[B2]
Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22031,25249,25675);

var 
expectedDiagnostics = new DiagnosticDescription[] {                
f_22031_25548_25659(f_22031_25548_25639(f_22031_25548_25612(ErrorCode.ERR_ObjectProhibited, "(c1 ?? c2).MyEvent"), "C.MyEvent"), 12, 9)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22031,25691,25789);

f_22031_25691_25788(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22031,23729,25800);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22031,23729,25800);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22031,23729,25800);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void EventAssignment_ControlFlowInHandler_InstanceReceiver()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22031,25812,29868);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22031,25999,26288);

string 
source = @"
using System;

class C
{
#pragma warning disable CS0067 // Event is unused.
    public event EventHandler MyEvent;

    void M(EventHandler handler1, EventHandler handler2)
    /*<bind>*/
    {
        MyEvent -= handler1 ?? handler2;
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22031,26302,29676);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'MyEvent')
              Value: 
                IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C, IsImplicit) (Syntax: 'MyEvent')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'handler1')
                  Value: 
                    IParameterReferenceOperation: handler1 (OperationKind.ParameterReference, Type: System.EventHandler) (Syntax: 'handler1')

            Jump if True (Regular) to Block[B4]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'handler1')
                  Operand: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.EventHandler, IsImplicit) (Syntax: 'handler1')
                Leaving: {R2}

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'handler1')
                  Value: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.EventHandler, IsImplicit) (Syntax: 'handler1')

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B4] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'handler2')
              Value: 
                IParameterReferenceOperation: handler2 (OperationKind.ParameterReference, Type: System.EventHandler) (Syntax: 'handler2')

        Next (Regular) Block[B5]
    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'MyEvent -=  ... ? handler2;')
              Expression: 
                IEventAssignmentOperation (EventRemove) (OperationKind.EventAssignment, Type: System.Void) (Syntax: 'MyEvent -=  ... ?? handler2')
                  Event Reference: 
                    IEventReferenceOperation: event System.EventHandler C.MyEvent (OperationKind.EventReference, Type: System.EventHandler) (Syntax: 'MyEvent')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'MyEvent')
                  Handler: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.EventHandler, IsImplicit) (Syntax: 'handler1 ?? handler2')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22031,29690,29743);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22031,29759,29857);

f_22031_29759_29856(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22031,25812,29868);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22031,25812,29868);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22031,25812,29868);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void EventAssignment_ControlFlowInHandler_NullReceiver()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22031,29880,33408);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22031,30063,30359);

string 
source = @"
using System;

class C
{
#pragma warning disable CS0067 // Event is unused.
    public static event EventHandler MyEvent;

    void M(EventHandler handler1, EventHandler handler2)
    /*<bind>*/
    {
        MyEvent -= handler1 ?? handler2;
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22031,30373,33216);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2}

.locals {R1}
{
    CaptureIds: [1]
    .locals {R2}
    {
        CaptureIds: [0]
        Block[B1] - Block
            Predecessors: [B0]
            Statements (1)
                IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'handler1')
                  Value: 
                    IParameterReferenceOperation: handler1 (OperationKind.ParameterReference, Type: System.EventHandler) (Syntax: 'handler1')

            Jump if True (Regular) to Block[B3]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'handler1')
                  Operand: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.EventHandler, IsImplicit) (Syntax: 'handler1')
                Leaving: {R2}

            Next (Regular) Block[B2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'handler1')
                  Value: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.EventHandler, IsImplicit) (Syntax: 'handler1')

            Next (Regular) Block[B4]
                Leaving: {R2}
    }

    Block[B3] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'handler2')
              Value: 
                IParameterReferenceOperation: handler2 (OperationKind.ParameterReference, Type: System.EventHandler) (Syntax: 'handler2')

        Next (Regular) Block[B4]
    Block[B4] - Block
        Predecessors: [B2] [B3]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'MyEvent -=  ... ? handler2;')
              Expression: 
                IEventAssignmentOperation (EventRemove) (OperationKind.EventAssignment, Type: System.Void) (Syntax: 'MyEvent -=  ... ?? handler2')
                  Event Reference: 
                    IEventReferenceOperation: event System.EventHandler C.MyEvent (Static) (OperationKind.EventReference, Type: System.EventHandler) (Syntax: 'MyEvent')
                      Instance Receiver: 
                        null
                  Handler: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.EventHandler, IsImplicit) (Syntax: 'handler1 ?? handler2')

        Next (Regular) Block[B5]
            Leaving: {R1}
}

Block[B5] - Exit
    Predecessors: [B4]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22031,33230,33283);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22031,33299,33397);

f_22031_33299_33396(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22031,29880,33408);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22031,29880,33408);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22031,29880,33408);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void EventAssignment_ControlFlowInEventReferenceAndHandler()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22031,33420,38696);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22031,33607,33919);

string 
source = @"
using System;

class C
{
#pragma warning disable CS0067 // Event is unused.
    public event EventHandler MyEvent;

    void M(C c1, C c2, EventHandler handler1, EventHandler handler2)
    /*<bind>*/
    {
        (c1 ?? c2).MyEvent += handler1 ?? handler2;
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22031,33933,38504);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2}

.locals {R1}
{
    CaptureIds: [1] [3]
    .locals {R2}
    {
        CaptureIds: [0]
        Block[B1] - Block
            Predecessors: [B0]
            Statements (1)
                IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c1')
                  Value: 
                    IParameterReferenceOperation: c1 (OperationKind.ParameterReference, Type: C) (Syntax: 'c1')

            Jump if True (Regular) to Block[B3]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'c1')
                  Operand: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'c1')
                Leaving: {R2}

            Next (Regular) Block[B2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c1')
                  Value: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'c1')

            Next (Regular) Block[B4]
                Leaving: {R2}
                Entering: {R3}
    }

    Block[B3] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c2')
              Value: 
                IParameterReferenceOperation: c2 (OperationKind.ParameterReference, Type: C) (Syntax: 'c2')

        Next (Regular) Block[B4]
            Entering: {R3}

    .locals {R3}
    {
        CaptureIds: [2]
        Block[B4] - Block
            Predecessors: [B2] [B3]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'handler1')
                  Value: 
                    IParameterReferenceOperation: handler1 (OperationKind.ParameterReference, Type: System.EventHandler) (Syntax: 'handler1')

            Jump if True (Regular) to Block[B6]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'handler1')
                  Operand: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.EventHandler, IsImplicit) (Syntax: 'handler1')
                Leaving: {R3}

            Next (Regular) Block[B5]
        Block[B5] - Block
            Predecessors: [B4]
            Statements (1)
                IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'handler1')
                  Value: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.EventHandler, IsImplicit) (Syntax: 'handler1')

            Next (Regular) Block[B7]
                Leaving: {R3}
    }

    Block[B6] - Block
        Predecessors: [B4]
        Statements (1)
            IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'handler2')
              Value: 
                IParameterReferenceOperation: handler2 (OperationKind.ParameterReference, Type: System.EventHandler) (Syntax: 'handler2')

        Next (Regular) Block[B7]
    Block[B7] - Block
        Predecessors: [B5] [B6]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: '(c1 ?? c2). ... ? handler2;')
              Expression: 
                IEventAssignmentOperation (EventAdd) (OperationKind.EventAssignment, Type: System.Void) (Syntax: '(c1 ?? c2). ... ?? handler2')
                  Event Reference: 
                    IEventReferenceOperation: event System.EventHandler C.MyEvent (OperationKind.EventReference, Type: System.EventHandler) (Syntax: '(c1 ?? c2).MyEvent')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'c1 ?? c2')
                  Handler: 
                    IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.EventHandler, IsImplicit) (Syntax: 'handler1 ?? handler2')

        Next (Regular) Block[B8]
            Leaving: {R1}
}

Block[B8] - Exit
    Predecessors: [B7]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22031,38518,38571);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22031,38587,38685);

f_22031_38587_38684(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22031,33420,38696);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22031,33420,38696);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22031,33420,38696);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void EventAssignment_NoControlFlow_NotAStatement()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22031,38708,41306);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22031,38885,39144);

string 
source = @"
using System;

class C
{
#pragma warning disable CS0067 // Event is unused.
    public event EventHandler MyEvent;

    void M(C c, EventHandler handler)
    /*<bind>*/{
        (c.MyEvent += handler) = 0;
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22031,39158,40791);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (1)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: '(c.MyEvent  ... ndler) = 0;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Void, IsInvalid) (Syntax: '(c.MyEvent  ... andler) = 0')
              Left: 
                IInvalidOperation (OperationKind.Invalid, Type: System.Void, IsInvalid, IsImplicit) (Syntax: 'c.MyEvent += handler')
                  Children(1):
                      IEventAssignmentOperation (EventAdd) (OperationKind.EventAssignment, Type: System.Void, IsInvalid) (Syntax: 'c.MyEvent += handler')
                        Event Reference: 
                          IEventReferenceOperation: event System.EventHandler C.MyEvent (OperationKind.EventReference, Type: System.EventHandler, IsInvalid) (Syntax: 'c.MyEvent')
                            Instance Receiver: 
                              IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: C, IsInvalid) (Syntax: 'c')
                        Handler: 
                          IParameterReferenceOperation: handler (OperationKind.ParameterReference, Type: System.EventHandler, IsInvalid) (Syntax: 'handler')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')

    Next (Regular) Block[B2]
Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22031,40805,41181);

var 
expectedDiagnostics = new DiagnosticDescription[] {                
f_22031_41076_41165(f_22031_41076_41144(ErrorCode.ERR_AssgLvalueExpected, "c.MyEvent += handler"), 11, 10)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22031,41197,41295);

f_22031_41197_41294(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22031,38708,41306);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22031,38708,41306);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22031,38708,41306);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void EventAssignment_ControlFlow_NotAStatement()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22031,41318,46420);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22031,41493,41776);

string 
source = @"
using System;

class C
{
#pragma warning disable CS0067 // Event is unused.
    public event EventHandler MyEvent;

    void M(C c, EventHandler handler, int? x1, int x2)
    /*<bind>*/{
        (c.MyEvent += handler) = x1 ?? x2;
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22031,41790,45914);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'c.MyEvent += handler')
              Value: 
                IInvalidOperation (OperationKind.Invalid, Type: System.Void, IsInvalid, IsImplicit) (Syntax: 'c.MyEvent += handler')
                  Children(1):
                      IEventAssignmentOperation (EventAdd) (OperationKind.EventAssignment, Type: System.Void, IsInvalid) (Syntax: 'c.MyEvent += handler')
                        Event Reference: 
                          IEventReferenceOperation: event System.EventHandler C.MyEvent (OperationKind.EventReference, Type: System.EventHandler, IsInvalid) (Syntax: 'c.MyEvent')
                            Instance Receiver: 
                              IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: C, IsInvalid) (Syntax: 'c')
                        Handler: 
                          IParameterReferenceOperation: handler (OperationKind.ParameterReference, Type: System.EventHandler, IsInvalid) (Syntax: 'handler')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'x1')
                  Value: 
                    IParameterReferenceOperation: x1 (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'x1')

            Jump if True (Regular) to Block[B4]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'x1')
                  Operand: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'x1')
                Leaving: {R2}

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'x1')
                  Value: 
                    IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsImplicit) (Syntax: 'x1')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'x1')
                      Arguments(0)

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B4] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'x2')
              Value: 
                IParameterReferenceOperation: x2 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'x2')

        Next (Regular) Block[B5]
    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: '(c.MyEvent  ... = x1 ?? x2;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Void, IsInvalid) (Syntax: '(c.MyEvent  ...  = x1 ?? x2')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Void, IsInvalid, IsImplicit) (Syntax: 'c.MyEvent += handler')
                  Right: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'x1 ?? x2')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22031,45928,46295);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22031_46190_46279(f_22031_46190_46258(ErrorCode.ERR_AssgLvalueExpected, "c.MyEvent += handler"), 11, 10)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22031,46311,46409);

f_22031_46311_46408(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22031,41318,46420);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22031,41318,46420);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22031,41318,46420);
}
		}

Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22031_2089_2143(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22031, 2089, 2143);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22031_2089_2173(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22031, 2089, 2173);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22031_2089_2193(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22031, 2089, 2193);
return return_v;
}


int
f_22031_2225_2345(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<AssignmentExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22031, 2225, 2345);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22031_3395_3449(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22031, 3395, 3449);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22031_3395_3479(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22031, 3395, 3479);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22031_3395_3499(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22031, 3395, 3499);
return return_v;
}


int
f_22031_3531_3645(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<IdentifierNameSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22031, 3531, 3645);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22031_5126_5180(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22031, 5126, 5180);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22031_5126_5210(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22031, 5126, 5210);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22031_5126_5230(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22031, 5126, 5230);
return return_v;
}


int
f_22031_5262_5382(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<AssignmentExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22031, 5262, 5382);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22031_6930_6984(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22031, 6930, 6984);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22031_6930_7014(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22031, 6930, 7014);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22031_6930_7034(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22031, 6930, 7034);
return return_v;
}


int
f_22031_7066_7186(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<AssignmentExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22031, 7066, 7186);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22031_8740_8794(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22031, 8740, 8794);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22031_8740_8824(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22031, 8740, 8824);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22031_8740_8844(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22031, 8740, 8844);
return return_v;
}


int
f_22031_8876_8996(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<AssignmentExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22031, 8876, 8996);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22031_10624_10694(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22031, 10624, 10694);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22031_10624_10742(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22031, 10624, 10742);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22031_10624_10763(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22031, 10624, 10763);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22031_10931_10985(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22031, 10931, 10985);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22031_10931_11015(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22031, 10931, 11015);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22031_10931_11035(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22031, 10931, 11035);
return return_v;
}


int
f_22031_11067_11187(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<AssignmentExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22031, 11067, 11187);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22031_12954_13009(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22031, 12954, 13009);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22031_12954_13039(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22031, 12954, 13039);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22031_12954_13060(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22031, 12954, 13060);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22031_13235_13289(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22031, 13235, 13289);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22031_13235_13319(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22031, 13235, 13319);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22031_13235_13339(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22031, 13235, 13339);
return return_v;
}


int
f_22031_13371_13491(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<AssignmentExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22031, 13371, 13491);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22031_15195_15251(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22031, 15195, 15251);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22031_15195_15281(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22031, 15195, 15281);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22031_15195_15302(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22031, 15195, 15302);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22031_15470_15524(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22031, 15470, 15524);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22031_15470_15554(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22031, 15470, 15554);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22031_15470_15574(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22031, 15470, 15574);
return return_v;
}


int
f_22031_15606_15726(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<AssignmentExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22031, 15606, 15726);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22031_17410_17464(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22031, 17410, 17464);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22031_17410_17494(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22031, 17410, 17494);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22031_17410_17514(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22031, 17410, 17514);
return return_v;
}


int
f_22031_17546_17666(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<AssignmentExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22031, 17546, 17666);
return 0;
}


int
f_22031_20143_20240(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22031, 20143, 20240);
return 0;
}


int
f_22031_23608_23705(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22031, 23608, 23705);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22031_25548_25612(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22031, 25548, 25612);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22031_25548_25639(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22031, 25548, 25639);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22031_25548_25659(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22031, 25548, 25659);
return return_v;
}


int
f_22031_25691_25788(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22031, 25691, 25788);
return 0;
}


int
f_22031_29759_29856(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22031, 29759, 29856);
return 0;
}


int
f_22031_33299_33396(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22031, 33299, 33396);
return 0;
}


int
f_22031_38587_38684(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22031, 38587, 38684);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22031_41076_41144(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22031, 41076, 41144);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22031_41076_41165(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22031, 41076, 41165);
return return_v;
}


int
f_22031_41197_41294(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22031, 41197, 41294);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22031_46190_46258(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22031, 46190, 46258);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22031_46190_46279(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22031, 46190, 46279);
return return_v;
}


int
f_22031_46311_46408(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22031, 46311, 46408);
return 0;
}

}
}
