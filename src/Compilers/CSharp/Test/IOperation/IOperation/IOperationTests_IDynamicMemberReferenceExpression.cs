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
        public void IDynamicMemberReferenceExpression_SimplePropertyAccess()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22028,471,1420);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22028,633,859);

string 
source = @"
using System;

namespace ConsoleApp1
{
    class C1
    {
        static void M1()
        {
            dynamic d = null;
            int i = /*<bind>*/d.Prop1/*</bind>*/;
        }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22028,873,1203);

string 
expectedOperationTree = @"
IDynamicMemberReferenceOperation (Member Name: ""Prop1"", Containing Type: null) (OperationKind.DynamicMemberReference, Type: dynamic) (Syntax: 'd.Prop1')
  Type Arguments(0)
  Instance Receiver: 
    ILocalReferenceOperation: d (OperationKind.LocalReference, Type: dynamic) (Syntax: 'd')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22028,1217,1270);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22028,1286,1409);

f_22028_1286_1408(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22028,471,1420);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22028,471,1420);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22028,471,1420);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IDynamicMemberReferenceExpression_InvalidPropertyAccess()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22028,1432,2608);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22028,1595,1816);

string 
source = @"
using System;

namespace ConsoleApp1
{
    class C1
    {
        static void M1()
        {
            dynamic d = null;
            int i = /*<bind>*/d./*</bind>*/;
        }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22028,1830,2172);

string 
expectedOperationTree = @"
IDynamicMemberReferenceOperation (Member Name: """", Containing Type: null) (OperationKind.DynamicMemberReference, Type: dynamic, IsInvalid) (Syntax: 'd./*</bind>*/')
  Type Arguments(0)
  Instance Receiver: 
    ILocalReferenceOperation: d (OperationKind.LocalReference, Type: dynamic) (Syntax: 'd')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22028,2186,2458);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22028_2372_2442(f_22028_2372_2421(ErrorCode.ERR_IdentifierExpected, ";"), 11, 44)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22028,2474,2597);

f_22028_2474_2596(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22028,1432,2608);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22028,1432,2608);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22028,1432,2608);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IDynamicMemberReferenceExpression_SimpleMethodCall()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22028,2620,3760);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22028,2778,3001);

string 
source = @"
using System;

namespace ConsoleApp1
{
    class C1
    {
        static void M1()
        {
            dynamic d = null;
            /*<bind>*/d.GetValue()/*</bind>*/;
        }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22028,3015,3545);

string 
expectedOperationTree = @"
IDynamicInvocationOperation (OperationKind.DynamicInvocation, Type: dynamic) (Syntax: 'd.GetValue()')
  Expression: 
    IDynamicMemberReferenceOperation (Member Name: ""GetValue"", Containing Type: null) (OperationKind.DynamicMemberReference, Type: dynamic) (Syntax: 'd.GetValue')
      Type Arguments(0)
      Instance Receiver: 
        ILocalReferenceOperation: d (OperationKind.LocalReference, Type: dynamic) (Syntax: 'd')
  Arguments(0)
  ArgumentNames(0)
  ArgumentRefKinds(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22028,3559,3612);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22028,3628,3749);

f_22028_3628_3748(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22028,2620,3760);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22028,2620,3760);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22028,2620,3760);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IDynamicMemberReferenceExpression_InvalidMethodCall_MissingName()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22028,3772,5110);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22028,3943,4141);

string 
source = @"
namespace ConsoleApp1
{
    class C1
    {
        static void M1()
        {
            dynamic d = null;
            /*<bind>*/d.()/*</bind>*/;
        }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22028,4155,4683);

string 
expectedOperationTree = @"
IDynamicInvocationOperation (OperationKind.DynamicInvocation, Type: dynamic, IsInvalid) (Syntax: 'd.()')
  Expression: 
    IDynamicMemberReferenceOperation (Member Name: """", Containing Type: null) (OperationKind.DynamicMemberReference, Type: dynamic, IsInvalid) (Syntax: 'd.')
      Type Arguments(0)
      Instance Receiver: 
        ILocalReferenceOperation: d (OperationKind.LocalReference, Type: dynamic) (Syntax: 'd')
  Arguments(0)
  ArgumentNames(0)
  ArgumentRefKinds(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22028,4697,4962);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22028_4877_4946(f_22028_4877_4926(ErrorCode.ERR_IdentifierExpected, "("), 9, 25)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22028,4978,5099);

f_22028_4978_5098(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22028,3772,5110);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22028,3772,5110);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22028,3772,5110);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IDynamicMemberReferenceExpression_InvalidMethodCall_MissingCloseParen()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22028,5122,6494);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22028,5299,5504);

string 
source = @"
namespace ConsoleApp1
{
    class C1
    {
        static void M1()
        {
            dynamic d = null;
            /*<bind>*/d.GetValue(/*</bind>*/;
        }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22028,5518,6069);

string 
expectedOperationTree = @"
IDynamicInvocationOperation (OperationKind.DynamicInvocation, Type: dynamic, IsInvalid) (Syntax: 'd.GetValue(/*</bind>*/')
  Expression: 
    IDynamicMemberReferenceOperation (Member Name: ""GetValue"", Containing Type: null) (OperationKind.DynamicMemberReference, Type: dynamic) (Syntax: 'd.GetValue')
      Type Arguments(0)
      Instance Receiver: 
        ILocalReferenceOperation: d (OperationKind.LocalReference, Type: dynamic) (Syntax: 'd')
  Arguments(0)
  ArgumentNames(0)
  ArgumentRefKinds(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22028,6083,6346);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22028_6261_6330(f_22028_6261_6310(ErrorCode.ERR_CloseParenExpected, ";"), 9, 45)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22028,6362,6483);

f_22028_6362_6482(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22028,5122,6494);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22028,5122,6494);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22028,5122,6494);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IDynamicMemberReference_GenericMethodCall_SingleGeneric()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22028,6506,7680);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22028,6669,6880);

string 
source = @"
namespace ConsoleApp1
{
    class C1
    {
        static void M1()
        {
            dynamic d = null;
            /*<bind>*/d.GetValue<int>()/*</bind>*/;
        }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22028,6894,7465);

string 
expectedOperationTree = @"
IDynamicInvocationOperation (OperationKind.DynamicInvocation, Type: dynamic) (Syntax: 'd.GetValue<int>()')
  Expression: 
    IDynamicMemberReferenceOperation (Member Name: ""GetValue"", Containing Type: null) (OperationKind.DynamicMemberReference, Type: dynamic) (Syntax: 'd.GetValue<int>')
      Type Arguments(1):
        Symbol: System.Int32
      Instance Receiver: 
        ILocalReferenceOperation: d (OperationKind.LocalReference, Type: dynamic) (Syntax: 'd')
  Arguments(0)
  ArgumentNames(0)
  ArgumentRefKinds(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22028,7479,7532);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22028,7548,7669);

f_22028_7548_7668(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22028,6506,7680);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22028,6506,7680);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22028,6506,7680);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IDynamicMemberReference_GenericMethodCall_MultipleGeneric()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22028,7692,8912);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22028,7857,8072);

string 
source = @"
namespace ConsoleApp1
{
    class C1
    {
        static void M1()
        {
            dynamic d = null;
            /*<bind>*/d.GetValue<int, C1>()/*</bind>*/;
        }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22028,8086,8697);

string 
expectedOperationTree = @"
IDynamicInvocationOperation (OperationKind.DynamicInvocation, Type: dynamic) (Syntax: 'd.GetValue<int, C1>()')
  Expression: 
    IDynamicMemberReferenceOperation (Member Name: ""GetValue"", Containing Type: null) (OperationKind.DynamicMemberReference, Type: dynamic) (Syntax: 'd.GetValue<int, C1>')
      Type Arguments(2):
        Symbol: System.Int32
        Symbol: ConsoleApp1.C1
      Instance Receiver: 
        ILocalReferenceOperation: d (OperationKind.LocalReference, Type: dynamic) (Syntax: 'd')
  Arguments(0)
  ArgumentNames(0)
  ArgumentRefKinds(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22028,8711,8764);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22028,8780,8901);

f_22028_8780_8900(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22028,7692,8912);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22028,7692,8912);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22028,7692,8912);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IDynamicMemberReferenceExpression_GenericPropertyAccess()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22028,8924,10585);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22028,9087,9300);

string 
source = @"
namespace ConsoleApp1
{
    class C1
    {
        static void M1()
        {
            dynamic d = null;
            /*<bind>*/d.GetValue<int, C1>/*</bind>*/;
        }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22028,9314,9736);

string 
expectedOperationTree = @"
IDynamicMemberReferenceOperation (Member Name: ""GetValue"", Containing Type: null) (OperationKind.DynamicMemberReference, Type: dynamic, IsInvalid) (Syntax: 'd.GetValue<int, C1>')
  Type Arguments(2):
    Symbol: System.Int32
    Symbol: ConsoleApp1.C1
  Instance Receiver: 
    ILocalReferenceOperation: d (OperationKind.LocalReference, Type: dynamic, IsInvalid) (Syntax: 'd')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22028,9750,10435);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22028_9984_10107(f_22028_9984_10087(f_22028_9984_10049(ErrorCode.ERR_TypeArgsNotAllowed, "GetValue<int, C1>"), "GetValue", "property"), 9, 25),
f_22028_10334_10419(f_22028_10334_10399(ErrorCode.ERR_IllegalStatement, "d.GetValue<int, C1>"), 9, 23)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22028,10451,10574);

f_22028_10451_10573(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22028,8924,10585);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22028,8924,10585);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22028,8924,10585);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IDynamicMemberReferenceExpression_GenericMethodCall_InvalidGenericParam()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22028,10597,12045);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22028,10776,10988);

string 
source = @"
namespace ConsoleApp1
{
    class C1
    {
        static void M1()
        {
            dynamic d = null;
            /*<bind>*/d.GetValue<int,>()/*</bind>*/;
        }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22028,11002,11616);

string 
expectedOperationTree = @"
IDynamicInvocationOperation (OperationKind.DynamicInvocation, Type: dynamic, IsInvalid) (Syntax: 'd.GetValue<int,>()')
  Expression: 
    IDynamicMemberReferenceOperation (Member Name: ""GetValue"", Containing Type: null) (OperationKind.DynamicMemberReference, Type: dynamic, IsInvalid) (Syntax: 'd.GetValue<int,>')
      Type Arguments(2):
        Symbol: System.Int32
        Symbol: ?
      Instance Receiver: 
        ILocalReferenceOperation: d (OperationKind.LocalReference, Type: dynamic) (Syntax: 'd')
  Arguments(0)
  ArgumentNames(0)
  ArgumentRefKinds(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22028,11630,11897);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22028_11818_11881(f_22028_11818_11861(ErrorCode.ERR_TypeExpected, ">"), 9, 38)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22028,11913,12034);

f_22028_11913_12033(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22028,10597,12045);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22028,10597,12045);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22028,10597,12045);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IDynamicMemberReferenceExpression_NestedDynamicPropertyAccess()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22028,12057,13227);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22028,12226,12444);

string 
source = @"
namespace ConsoleApp1
{
    class C1
    {
        static void M1()
        {
            dynamic d = null;
            object o = /*<bind>*/d.Prop1.Prop2/*</bind>*/;
        }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22028,12458,13010);

string 
expectedOperationTree = @"
IDynamicMemberReferenceOperation (Member Name: ""Prop2"", Containing Type: null) (OperationKind.DynamicMemberReference, Type: dynamic) (Syntax: 'd.Prop1.Prop2')
  Type Arguments(0)
  Instance Receiver: 
    IDynamicMemberReferenceOperation (Member Name: ""Prop1"", Containing Type: null) (OperationKind.DynamicMemberReference, Type: dynamic) (Syntax: 'd.Prop1')
      Type Arguments(0)
      Instance Receiver: 
        ILocalReferenceOperation: d (OperationKind.LocalReference, Type: dynamic) (Syntax: 'd')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22028,13024,13077);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22028,13093,13216);

f_22028_13093_13215(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22028,12057,13227);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22028,12057,13227);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22028,12057,13227);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IDynamicMemberReferenceExpression_NestedDynamicMethodAccess()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22028,13239,14862);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22028,13406,13621);

string 
source = @"
namespace ConsoleApp1
{
    class C1
    {
        static void M1()
        {
            dynamic d = null;
            /*<bind>*/d.Method1().Method2()/*</bind>*/;
        }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22028,13635,14647);

string 
expectedOperationTree = @"
IDynamicInvocationOperation (OperationKind.DynamicInvocation, Type: dynamic) (Syntax: 'd.Method1().Method2()')
  Expression: 
    IDynamicMemberReferenceOperation (Member Name: ""Method2"", Containing Type: null) (OperationKind.DynamicMemberReference, Type: dynamic) (Syntax: 'd.Method1().Method2')
      Type Arguments(0)
      Instance Receiver: 
        IDynamicInvocationOperation (OperationKind.DynamicInvocation, Type: dynamic) (Syntax: 'd.Method1()')
          Expression: 
            IDynamicMemberReferenceOperation (Member Name: ""Method1"", Containing Type: null) (OperationKind.DynamicMemberReference, Type: dynamic) (Syntax: 'd.Method1')
              Type Arguments(0)
              Instance Receiver: 
                ILocalReferenceOperation: d (OperationKind.LocalReference, Type: dynamic) (Syntax: 'd')
          Arguments(0)
          ArgumentNames(0)
          ArgumentRefKinds(0)
  Arguments(0)
  ArgumentNames(0)
  ArgumentRefKinds(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22028,14661,14714);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22028,14730,14851);

f_22028_14730_14850(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22028,13239,14862);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22028,13239,14862);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22028,13239,14862);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IDynamicMemberReferenceExpression_NestedDynamicPropertyAndMethodAccess()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22028,14874,16347);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22028,15052,15293);

string 
source = @"
using System;

namespace ConsoleApp1
{
    class C1
    {
        static void M1()
        {
            dynamic d = null;
            int i = /*<bind>*/d.Method1<int>().Prop2/*</bind>*/;
        }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22028,15307,16130);

string 
expectedOperationTree = @"
IDynamicMemberReferenceOperation (Member Name: ""Prop2"", Containing Type: null) (OperationKind.DynamicMemberReference, Type: dynamic) (Syntax: 'd.Method1<int>().Prop2')
  Type Arguments(0)
  Instance Receiver: 
    IDynamicInvocationOperation (OperationKind.DynamicInvocation, Type: dynamic) (Syntax: 'd.Method1<int>()')
      Expression: 
        IDynamicMemberReferenceOperation (Member Name: ""Method1"", Containing Type: null) (OperationKind.DynamicMemberReference, Type: dynamic) (Syntax: 'd.Method1<int>')
          Type Arguments(1):
            Symbol: System.Int32
          Instance Receiver: 
            ILocalReferenceOperation: d (OperationKind.LocalReference, Type: dynamic) (Syntax: 'd')
      Arguments(0)
      ArgumentNames(0)
      ArgumentRefKinds(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22028,16144,16197);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22028,16213,16336);

f_22028_16213_16335(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22028,14874,16347);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22028,14874,16347);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22028,14874,16347);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void DynamicMemberReference_NoControlFlow()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22028,16359,17976);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22028,16529,16740);

string 
source = @"
using System;

namespace ConsoleApp1
{
    class C1
    {
        static void M1(dynamic d, dynamic p)
        /*<bind>*/{
            p = d.Prop1;
        }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22028,16754,17784);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (1)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'p = d.Prop1;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: dynamic) (Syntax: 'p = d.Prop1')
              Left: 
                IParameterReferenceOperation: p (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'p')
              Right: 
                IDynamicMemberReferenceOperation (Member Name: ""Prop1"", Containing Type: null) (OperationKind.DynamicMemberReference, Type: dynamic) (Syntax: 'd.Prop1')
                  Type Arguments(0)
                  Instance Receiver: 
                    IParameterReferenceOperation: d (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'd')

    Next (Regular) Block[B2]
Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22028,17798,17851);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22028,17867,17965);

f_22028_17867_17964(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22028,16359,17976);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22028,16359,17976);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22028,16359,17976);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void DynamicMemberReference_ControlFlowInReceiver()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22028,17988,21817);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22028,18166,18399);

string 
source = @"
using System;

namespace ConsoleApp1
{
    class C1
    {
        static void M1(dynamic d1, dynamic d2, dynamic p)
        /*<bind>*/{
            p = (d1 ?? d2).Prop1;
        }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22028,18413,21625);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'p')
              Value: 
                IParameterReferenceOperation: p (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'p')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'd1')
                  Value: 
                    IParameterReferenceOperation: d1 (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'd1')

            Jump if True (Regular) to Block[B4]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'd1')
                  Operand: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'd1')
                Leaving: {R2}

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'd1')
                  Value: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'd1')

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B4] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'd2')
              Value: 
                IParameterReferenceOperation: d2 (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'd2')

        Next (Regular) Block[B5]
    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'p = (d1 ?? d2).Prop1;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: dynamic) (Syntax: 'p = (d1 ?? d2).Prop1')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'p')
                  Right: 
                    IDynamicMemberReferenceOperation (Member Name: ""Prop1"", Containing Type: null) (OperationKind.DynamicMemberReference, Type: dynamic) (Syntax: '(d1 ?? d2).Prop1')
                      Type Arguments(0)
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'd1 ?? d2')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22028,21639,21692);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22028,21708,21806);

f_22028_21708_21805(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22028,17988,21817);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22028,17988,21817);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22028,17988,21817);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void DynamicMemberReference_ControlFlowInReceiver_TypeArguments()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22028,21829,26090);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22028,22021,22259);

string 
source = @"
using System;

namespace ConsoleApp1
{
    class C1
    {
        static void M1(dynamic d1, dynamic d2, dynamic p)
        /*<bind>*/{
            p = (d1 ?? d2).Prop1<int>;
        }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22028,22273,25583);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'p')
              Value: 
                IParameterReferenceOperation: p (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'p')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'd1')
                  Value: 
                    IParameterReferenceOperation: d1 (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'd1')

            Jump if True (Regular) to Block[B4]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'd1')
                  Operand: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'd1')
                Leaving: {R2}

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'd1')
                  Value: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'd1')

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B4] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'd2')
              Value: 
                IParameterReferenceOperation: d2 (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'd2')

        Next (Regular) Block[B5]
    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: 'p = (d1 ??  ... Prop1<int>;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: dynamic, IsInvalid) (Syntax: 'p = (d1 ??  ... .Prop1<int>')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'p')
                  Right: 
                    IDynamicMemberReferenceOperation (Member Name: ""Prop1"", Containing Type: null) (OperationKind.DynamicMemberReference, Type: dynamic, IsInvalid) (Syntax: '(d1 ?? d2).Prop1<int>')
                      Type Arguments(1):
                        Symbol: System.Int32
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'd1 ?? d2')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22028,25597,25965);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22028_25835_25949(f_22028_25835_25928(f_22028_25835_25893(ErrorCode.ERR_TypeArgsNotAllowed, "Prop1<int>"), "Prop1", "property"), 10, 28)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22028,25981,26079);

f_22028_25981_26078(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22028,21829,26090);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22028,21829,26090);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22028,21829,26090);
}
		}

int
f_22028_1286_1408(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<MemberAccessExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22028, 1286, 1408);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22028_2372_2421(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22028, 2372, 2421);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22028_2372_2442(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22028, 2372, 2442);
return return_v;
}


int
f_22028_2474_2596(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<MemberAccessExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22028, 2474, 2596);
return 0;
}


int
f_22028_3628_3748(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InvocationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22028, 3628, 3748);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22028_4877_4926(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22028, 4877, 4926);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22028_4877_4946(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22028, 4877, 4946);
return return_v;
}


int
f_22028_4978_5098(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InvocationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22028, 4978, 5098);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22028_6261_6310(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22028, 6261, 6310);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22028_6261_6330(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22028, 6261, 6330);
return return_v;
}


int
f_22028_6362_6482(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InvocationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22028, 6362, 6482);
return 0;
}


int
f_22028_7548_7668(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InvocationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22028, 7548, 7668);
return 0;
}


int
f_22028_8780_8900(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InvocationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22028, 8780, 8900);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22028_9984_10049(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22028, 9984, 10049);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22028_9984_10087(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22028, 9984, 10087);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22028_9984_10107(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22028, 9984, 10107);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22028_10334_10399(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22028, 10334, 10399);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22028_10334_10419(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22028, 10334, 10419);
return return_v;
}


int
f_22028_10451_10573(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<MemberAccessExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22028, 10451, 10573);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22028_11818_11861(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22028, 11818, 11861);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22028_11818_11881(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22028, 11818, 11881);
return return_v;
}


int
f_22028_11913_12033(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InvocationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22028, 11913, 12033);
return 0;
}


int
f_22028_13093_13215(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<MemberAccessExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22028, 13093, 13215);
return 0;
}


int
f_22028_14730_14850(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InvocationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22028, 14730, 14850);
return 0;
}


int
f_22028_16213_16335(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<MemberAccessExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22028, 16213, 16335);
return 0;
}


int
f_22028_17867_17964(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22028, 17867, 17964);
return 0;
}


int
f_22028_21708_21805(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22028, 21708, 21805);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22028_25835_25893(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22028, 25835, 25893);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22028_25835_25928(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22028, 25835, 25928);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22028_25835_25949(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22028, 25835, 25949);
return return_v;
}


int
f_22028_25981_26078(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22028, 25981, 26078);
return 0;
}

}
}
