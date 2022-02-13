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
        public void DynamicInvocation_DynamicArgument()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22027,501,1648);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22027,642,803);

string 
source = @"
class C
{
    void M(C c, dynamic d)
    {
        /*<bind>*/c.M2(d)/*</bind>*/;
    }

    public void M2(int i)
    {
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22027,817,1433);

string 
expectedOperationTree = @"
IDynamicInvocationOperation (OperationKind.DynamicInvocation, Type: dynamic) (Syntax: 'c.M2(d)')
  Expression: 
    IDynamicMemberReferenceOperation (Member Name: ""M2"", Containing Type: null) (OperationKind.DynamicMemberReference, Type: null) (Syntax: 'c.M2')
      Type Arguments(0)
      Instance Receiver: 
        IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: C) (Syntax: 'c')
  Arguments(1):
      IParameterReferenceOperation: d (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'd')
  ArgumentNames(0)
  ArgumentRefKinds(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22027,1447,1500);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22027,1516,1637);

f_22027_1516_1636(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22027,501,1648);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22027,501,1648);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22027,501,1648);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void DynamicInvocation_MultipleApplicableSymbols()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22027,1660,2869);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22027,1811,2024);

string 
source = @"
class C
{
    void M(C c, dynamic d)
    {
        var x = /*<bind>*/c.M2(d)/*</bind>*/;
    }

    public void M2(int i)
    {
    }

    public void M2(long i)
    {
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22027,2038,2654);

string 
expectedOperationTree = @"
IDynamicInvocationOperation (OperationKind.DynamicInvocation, Type: dynamic) (Syntax: 'c.M2(d)')
  Expression: 
    IDynamicMemberReferenceOperation (Member Name: ""M2"", Containing Type: null) (OperationKind.DynamicMemberReference, Type: null) (Syntax: 'c.M2')
      Type Arguments(0)
      Instance Receiver: 
        IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: C) (Syntax: 'c')
  Arguments(1):
      IParameterReferenceOperation: d (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'd')
  ArgumentNames(0)
  ArgumentRefKinds(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22027,2668,2721);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22027,2737,2858);

f_22027_2737_2857(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22027,1660,2869);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22027,1660,2869);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22027,1660,2869);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void DynamicInvocation_MultipleArgumentsAndApplicableSymbols()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22027,2881,4253);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22027,3044,3303);

string 
source = @"
class C
{
    void M(C c, dynamic d)
    {
        char ch = 'c';
        var x = /*<bind>*/c.M2(d, ch)/*</bind>*/;
    }

    public void M2(int i, char ch)
    {
    }

    public void M2(long i, char ch)
    {
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22027,3317,4038);

string 
expectedOperationTree = @"
IDynamicInvocationOperation (OperationKind.DynamicInvocation, Type: dynamic) (Syntax: 'c.M2(d, ch)')
  Expression: 
    IDynamicMemberReferenceOperation (Member Name: ""M2"", Containing Type: null) (OperationKind.DynamicMemberReference, Type: null) (Syntax: 'c.M2')
      Type Arguments(0)
      Instance Receiver: 
        IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: C) (Syntax: 'c')
  Arguments(2):
      IParameterReferenceOperation: d (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'd')
      ILocalReferenceOperation: ch (OperationKind.LocalReference, Type: System.Char) (Syntax: 'ch')
  ArgumentNames(0)
  ArgumentRefKinds(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22027,4052,4105);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22027,4121,4242);

f_22027_4121_4241(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22027,2881,4253);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22027,2881,4253);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22027,2881,4253);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void DynamicInvocation_ArgumentNames()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22027,4265,5638);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22027,4404,4656);

string 
source = @"
class C
{
    void M(C c, dynamic d, dynamic e)
    {
        var x = /*<bind>*/c.M2(i: d, ch: e)/*</bind>*/;
    }

    public void M2(int i, char ch)
    {
    }

    public void M2(long i, char ch)
    {
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22027,4670,5423);

string 
expectedOperationTree = @"
IDynamicInvocationOperation (OperationKind.DynamicInvocation, Type: dynamic) (Syntax: 'c.M2(i: d, ch: e)')
  Expression: 
    IDynamicMemberReferenceOperation (Member Name: ""M2"", Containing Type: null) (OperationKind.DynamicMemberReference, Type: null) (Syntax: 'c.M2')
      Type Arguments(0)
      Instance Receiver: 
        IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: C) (Syntax: 'c')
  Arguments(2):
      IParameterReferenceOperation: d (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'd')
      IParameterReferenceOperation: e (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'e')
  ArgumentNames(2):
    ""i""
    ""ch""
  ArgumentRefKinds(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22027,5437,5490);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22027,5506,5627);

f_22027_5506_5626(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22027,4265,5638);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22027,4265,5638);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22027,4265,5638);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void DynamicInvocation_ArgumentRefKinds()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22027,5650,7140);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22027,5792,6043);

string 
source = @"
class C
{
    void M(C c, object d, dynamic e)
    {
        int k;
        var x = /*<bind>*/c.M2(ref d, out k, e)/*</bind>*/;
    }

    public void M2(ref object i, out int j, char c)
    {
        j = 0;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22027,6057,6925);

string 
expectedOperationTree = @"
IDynamicInvocationOperation (OperationKind.DynamicInvocation, Type: dynamic) (Syntax: 'c.M2(ref d, out k, e)')
  Expression: 
    IDynamicMemberReferenceOperation (Member Name: ""M2"", Containing Type: null) (OperationKind.DynamicMemberReference, Type: null) (Syntax: 'c.M2')
      Type Arguments(0)
      Instance Receiver: 
        IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: C) (Syntax: 'c')
  Arguments(3):
      IParameterReferenceOperation: d (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'd')
      ILocalReferenceOperation: k (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'k')
      IParameterReferenceOperation: e (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'e')
  ArgumentNames(0)
  ArgumentRefKinds(3):
    Ref
    Out
    None
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22027,6939,6992);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22027,7008,7129);

f_22027_7008_7128(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22027,5650,7140);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22027,5650,7140);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22027,5650,7140);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void DynamicInvocation_DelegateInvocation()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22027,7152,8613);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22027,7296,7461);

string 
source = @"
using System;

class C
{
    public Action<object> F;
    void M(dynamic i)
    {
        var x = /*<bind>*/F(i)/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22027,7475,8104);

string 
expectedOperationTree = @"
IDynamicInvocationOperation (OperationKind.DynamicInvocation, Type: dynamic) (Syntax: 'F(i)')
  Expression: 
    IFieldReferenceOperation: System.Action<System.Object> C.F (OperationKind.FieldReference, Type: System.Action<System.Object>) (Syntax: 'F')
      Instance Receiver: 
        IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C, IsImplicit) (Syntax: 'F')
  Arguments(1):
      IParameterReferenceOperation: i (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'i')
  ArgumentNames(0)
  ArgumentRefKinds(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22027,8118,8465);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22027_8346_8449(f_22027_8346_8429(f_22027_8346_8400(ErrorCode.WRN_UnassignedInternalField, "F"), "C.F", "null"), 6, 27)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22027,8481,8602);

f_22027_8481_8601(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22027,7152,8613);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22027,7152,8613);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22027,7152,8613);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void DynamicInvocation_WithDynamicReceiver()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22027,8625,9541);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22027,8770,8895);

string 
source = @"
class C
{
    void M(dynamic d, int i)
    {
        var x = /*<bind>*/d(i)/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22027,8909,9326);

string 
expectedOperationTree = @"
IDynamicInvocationOperation (OperationKind.DynamicInvocation, Type: dynamic) (Syntax: 'd(i)')
  Expression: 
    IParameterReferenceOperation: d (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'd')
  Arguments(1):
      IParameterReferenceOperation: i (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i')
  ArgumentNames(0)
  ArgumentRefKinds(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22027,9340,9393);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22027,9409,9530);

f_22027_9409_9529(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22027,8625,9541);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22027,8625,9541);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22027,8625,9541);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void DynamicInvocation_WithDynamicMemberReceiver()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22027,9553,10691);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22027,9704,9832);

string 
source = @"
class C
{
    void M(dynamic c, int i)
    {
        var x = /*<bind>*/c.M2(i)/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22027,9846,10476);

string 
expectedOperationTree = @"
IDynamicInvocationOperation (OperationKind.DynamicInvocation, Type: dynamic) (Syntax: 'c.M2(i)')
  Expression: 
    IDynamicMemberReferenceOperation (Member Name: ""M2"", Containing Type: null) (OperationKind.DynamicMemberReference, Type: dynamic) (Syntax: 'c.M2')
      Type Arguments(0)
      Instance Receiver: 
        IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'c')
  Arguments(1):
      IParameterReferenceOperation: i (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i')
  ArgumentNames(0)
  ArgumentRefKinds(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22027,10490,10543);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22027,10559,10680);

f_22027_10559_10679(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22027,9553,10691);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22027,9553,10691);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22027,9553,10691);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void DynamicInvocation_WithDynamicTypedMemberReceiver()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22027,10703,11786);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22027,10859,11005);

string 
source = @"
class C
{
    dynamic M2 = null;
    void M(C c, int i)
    {
        var x = /*<bind>*/c.M2(i)/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22027,11019,11571);

string 
expectedOperationTree = @"
IDynamicInvocationOperation (OperationKind.DynamicInvocation, Type: dynamic) (Syntax: 'c.M2(i)')
  Expression: 
    IFieldReferenceOperation: dynamic C.M2 (OperationKind.FieldReference, Type: dynamic) (Syntax: 'c.M2')
      Instance Receiver: 
        IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: C) (Syntax: 'c')
  Arguments(1):
      IParameterReferenceOperation: i (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i')
  ArgumentNames(0)
  ArgumentRefKinds(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22027,11585,11638);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22027,11654,11775);

f_22027_11654_11774(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22027,10703,11786);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22027,10703,11786);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22027,10703,11786);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void DynamicInvocation_AllFields()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22027,11798,13200);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22027,11933,12199);

string 
source = @"
class C
{
    void M(C c, dynamic d)
    {
        int i = 0;
        var x = /*<bind>*/c.M2(ref i, c: d)/*</bind>*/;
    }

    public void M2(ref int i, char c)
    {
    }

    public void M2(ref int i, long c)
    {
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22027,12213,12985);

string 
expectedOperationTree = @"
IDynamicInvocationOperation (OperationKind.DynamicInvocation, Type: dynamic) (Syntax: 'c.M2(ref i, c: d)')
  Expression: 
    IDynamicMemberReferenceOperation (Member Name: ""M2"", Containing Type: null) (OperationKind.DynamicMemberReference, Type: null) (Syntax: 'c.M2')
      Type Arguments(0)
      Instance Receiver: 
        IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: C) (Syntax: 'c')
  Arguments(2):
      ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
      IParameterReferenceOperation: d (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'd')
  ArgumentNames(2):
    ""null""
    ""c""
  ArgumentRefKinds(2):
    Ref
    None
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22027,12999,13052);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22027,13068,13189);

f_22027_13068_13188(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22027,11798,13200);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22027,11798,13200);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22027,11798,13200);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void DynamicInvocation_ErrorBadDynamicMethodArgLambda()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22027,13212,15242);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22027,13368,13604);

string 
source = @"
using System;

class C
{
    public void M(C c)
    {
        dynamic y = null;
        var x = /*<bind>*/c.M2(delegate { }, y)/*</bind>*/;
    }

    public void M2(Action a, Action y)
    {
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22027,13618,14648);

string 
expectedOperationTree = @"
IDynamicInvocationOperation (OperationKind.DynamicInvocation, Type: dynamic, IsInvalid) (Syntax: 'c.M2(delegate { }, y)')
  Expression: 
    IDynamicMemberReferenceOperation (Member Name: ""M2"", Containing Type: null) (OperationKind.DynamicMemberReference, Type: null) (Syntax: 'c.M2')
      Type Arguments(0)
      Instance Receiver: 
        IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: C) (Syntax: 'c')
  Arguments(2):
      IAnonymousFunctionOperation (Symbol: lambda expression) (OperationKind.AnonymousFunction, Type: null, IsInvalid) (Syntax: 'delegate { }')
        IBlockOperation (1 statements) (OperationKind.Block, Type: null, IsInvalid) (Syntax: '{ }')
          IReturnOperation (OperationKind.Return, Type: null, IsInvalid, IsImplicit) (Syntax: '{ }')
            ReturnedValue: 
              null
      ILocalReferenceOperation: y (OperationKind.LocalReference, Type: dynamic) (Syntax: 'y')
  ArgumentNames(0)
  ArgumentRefKinds(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22027,14662,15094);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22027_14991_15078(f_22027_14991_15058(ErrorCode.ERR_BadDynamicMethodArgLambda, "delegate { }"), 9, 32)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22027,15110,15231);

f_22027_15110_15230(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22027,13212,15242);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22027,13212,15242);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22027,13212,15242);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void DynamicInvocation_OverloadResolutionFailure()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22027,15254,16855);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22027,15405,15619);

string 
source = @"
class C
{
    void M(C c, dynamic d)
    {
        var x = /*<bind>*/c.M2(d)/*</bind>*/;
    }

    public void M2()
    {
    }

    public void M2(int i, int j)
    {
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22027,15633,16001);

string 
expectedOperationTree = @"
IInvalidOperation (OperationKind.Invalid, Type: System.Void, IsInvalid) (Syntax: 'c.M2(d)')
  Children(2):
      IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: C, IsInvalid) (Syntax: 'c')
      IParameterReferenceOperation: d (OperationKind.ParameterReference, Type: dynamic, IsInvalid) (Syntax: 'd')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22027,16015,16707);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22027_16283_16395(f_22027_16283_16375(f_22027_16283_16338(ErrorCode.ERR_NoCorrespondingArgument, "M2"), "j", "C.M2(int, int)"), 6, 29),
f_22027_16559_16691(f_22027_16559_16671(f_22027_16559_16649(ErrorCode.ERR_ImplicitlyTypedVariableAssignedBadValue, "x = /*<bind>*/c.M2(d)"), "void"), 6, 13)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22027,16723,16844);

f_22027_16723_16843(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22027,15254,16855);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22027,15254,16855);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22027,15254,16855);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void DynamicInvocation_InConstructorInitializer()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22027,16867,17992);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22027,17017,17236);

string 
source = @"
class B 
{
    protected B(int x) { }
}

class C : B
{
    C(dynamic x) : base((int)/*<bind>*/Goo(x)/*</bind>*/) { }
 
    static object Goo(object x)
    {
        return x;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22027,17250,17777);

string 
expectedOperationTree = @"
IDynamicInvocationOperation (OperationKind.DynamicInvocation, Type: dynamic) (Syntax: 'Goo(x)')
  Expression: 
    IDynamicMemberReferenceOperation (Member Name: ""Goo"", Containing Type: C) (OperationKind.DynamicMemberReference, Type: null) (Syntax: 'Goo')
      Type Arguments(0)
      Instance Receiver: 
        null
  Arguments(1):
      IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'x')
  ArgumentNames(0)
  ArgumentRefKinds(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22027,17791,17844);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22027,17860,17981);

f_22027_17860_17980(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22027,16867,17992);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22027,16867,17992);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22027,16867,17992);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void DynamicInvocation_NoControlFlow()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22027,18004,19626);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22027,18169,18330);

string 
source = @"
class C
{
    void M(C c, dynamic d)
    /*<bind>*/{
        c.M2(d);
    }/*</bind>*/

    public void M2(int i)
    {
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22027,18344,19434);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (1)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'c.M2(d);')
          Expression: 
            IDynamicInvocationOperation (OperationKind.DynamicInvocation, Type: dynamic) (Syntax: 'c.M2(d)')
              Expression: 
                IDynamicMemberReferenceOperation (Member Name: ""M2"", Containing Type: null) (OperationKind.DynamicMemberReference, Type: null) (Syntax: 'c.M2')
                  Type Arguments(0)
                  Instance Receiver: 
                    IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: C) (Syntax: 'c')
              Arguments(1):
                  IParameterReferenceOperation: d (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'd')
              ArgumentNames(0)
              ArgumentRefKinds(0)

    Next (Regular) Block[B2]
Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22027,19448,19501);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22027,19517,19615);

f_22027_19517_19614(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22027,18004,19626);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22027,18004,19626);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22027,18004,19626);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void DynamicInvocation_ControlFlowNullReceiver()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22027,19638,23170);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22027,19928,20119);

string 
source = @"
class C
{
    void M(dynamic d1, dynamic d2)
    /*<bind>*/{
        C.M2<int>(d1 ?? d2);
    }/*</bind>*/

    public static void M2<T>(int i)
    {
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22027,20133,22978);

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
                IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'd1')
                  Value: 
                    IParameterReferenceOperation: d1 (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'd1')

            Jump if True (Regular) to Block[B3]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'd1')
                  Operand: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'd1')
                Leaving: {R2}

            Next (Regular) Block[B2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'd1')
                  Value: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'd1')

            Next (Regular) Block[B4]
                Leaving: {R2}
    }

    Block[B3] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'd2')
              Value: 
                IParameterReferenceOperation: d2 (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'd2')

        Next (Regular) Block[B4]
    Block[B4] - Block
        Predecessors: [B2] [B3]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'C.M2<int>(d1 ?? d2);')
              Expression: 
                IDynamicInvocationOperation (OperationKind.DynamicInvocation, Type: dynamic) (Syntax: 'C.M2<int>(d1 ?? d2)')
                  Expression: 
                    IDynamicMemberReferenceOperation (Member Name: ""M2"", Containing Type: C) (OperationKind.DynamicMemberReference, Type: null) (Syntax: 'C.M2<int>')
                      Type Arguments(1):
                        Symbol: System.Int32
                      Instance Receiver: 
                        null
                  Arguments(1):
                      IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'd1 ?? d2')
                  ArgumentNames(0)
                  ArgumentRefKinds(0)

        Next (Regular) Block[B5]
            Leaving: {R1}
}

Block[B5] - Exit
    Predecessors: [B4]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22027,22992,23045);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22027,23061,23159);

f_22027_23061_23158(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22027,19638,23170);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22027,19638,23170);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22027,19638,23170);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void DynamicInvocation_ControlFlowInReceiver()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22027,23182,26598);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22027,23355,23532);

string 
source = @"
class C
{
    void M(C c1, C c2, dynamic d)
    /*<bind>*/{
        (c1 ?? c2).M2(d);
    }/*</bind>*/

    public void M2(int i)
    {
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22027,23546,26406);

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
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: '(c1 ?? c2).M2(d);')
              Expression: 
                IDynamicInvocationOperation (OperationKind.DynamicInvocation, Type: dynamic) (Syntax: '(c1 ?? c2).M2(d)')
                  Expression: 
                    IDynamicMemberReferenceOperation (Member Name: ""M2"", Containing Type: null) (OperationKind.DynamicMemberReference, Type: null) (Syntax: '(c1 ?? c2).M2')
                      Type Arguments(0)
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'c1 ?? c2')
                  Arguments(1):
                      IParameterReferenceOperation: d (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'd')
                  ArgumentNames(0)
                  ArgumentRefKinds(0)

        Next (Regular) Block[B5]
            Leaving: {R1}
}

Block[B5] - Exit
    Predecessors: [B4]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22027,26420,26473);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22027,26489,26587);

f_22027_26489_26586(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22027,23182,26598);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22027,23182,26598);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22027,23182,26598);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void DynamicInvocation_ControlFlowInReceiverEmptyArgList()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22027,26610,29944);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22027,26795,26967);

string 
source = @"
class C
{
    void M(dynamic d1, dynamic d2)
    /*<bind>*/{
        (d1 ?? d2).M2();
    }/*</bind>*/

    public void M2()
    {
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22027,26981,29752);

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
                IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'd1')
                  Value: 
                    IParameterReferenceOperation: d1 (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'd1')

            Jump if True (Regular) to Block[B3]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'd1')
                  Operand: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'd1')
                Leaving: {R2}

            Next (Regular) Block[B2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'd1')
                  Value: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'd1')

            Next (Regular) Block[B4]
                Leaving: {R2}
    }

    Block[B3] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'd2')
              Value: 
                IParameterReferenceOperation: d2 (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'd2')

        Next (Regular) Block[B4]
    Block[B4] - Block
        Predecessors: [B2] [B3]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: '(d1 ?? d2).M2();')
              Expression: 
                IDynamicInvocationOperation (OperationKind.DynamicInvocation, Type: dynamic) (Syntax: '(d1 ?? d2).M2()')
                  Expression: 
                    IDynamicMemberReferenceOperation (Member Name: ""M2"", Containing Type: null) (OperationKind.DynamicMemberReference, Type: dynamic) (Syntax: '(d1 ?? d2).M2')
                      Type Arguments(0)
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'd1 ?? d2')
                  Arguments(0)
                  ArgumentNames(0)
                  ArgumentRefKinds(0)

        Next (Regular) Block[B5]
            Leaving: {R1}
}

Block[B5] - Exit
    Predecessors: [B4]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22027,29766,29819);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22027,29835,29933);

f_22027_29835_29932(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22027,26610,29944);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22027,26610,29944);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22027,26610,29944);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void DynamicInvocation_ControlFlowInFirstArgument()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22027,29956,33990);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22027,30134,30390);

string 
source = @"
class C
{
    void M(char ch, C c, dynamic d1, dynamic d2)
    /*<bind>*/{
        c.M2(d1 ?? d2, ch);
    }/*</bind>*/

    public void M2(int i, char ch)
    {
    }

    public void M2(long i, char ch)
    {
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22027,30404,33798);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c')
              Value: 
                IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: C) (Syntax: 'c')

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
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'c.M2(d1 ?? d2, ch);')
              Expression: 
                IDynamicInvocationOperation (OperationKind.DynamicInvocation, Type: dynamic) (Syntax: 'c.M2(d1 ?? d2, ch)')
                  Expression: 
                    IDynamicMemberReferenceOperation (Member Name: ""M2"", Containing Type: null) (OperationKind.DynamicMemberReference, Type: null) (Syntax: 'c.M2')
                      Type Arguments(0)
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'c')
                  Arguments(2):
                      IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'd1 ?? d2')
                      IParameterReferenceOperation: ch (OperationKind.ParameterReference, Type: System.Char) (Syntax: 'ch')
                  ArgumentNames(0)
                  ArgumentRefKinds(0)

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22027,33812,33865);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22027,33881,33979);

f_22027_33881_33978(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22027,29956,33990);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22027,29956,33990);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22027,29956,33990);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void DynamicInvocation_ControlFlowInSecondArgument()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22027,34002,38585);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22027,34181,34439);

string 
source = @"
class C
{
    void M(C c, dynamic d1, char? ch1, char ch2)
    /*<bind>*/{
        c.M2(d1, ch1 ?? ch2);
    }/*</bind>*/

    public void M2(int i, char ch)
    {
    }

    public void M2(long i, char ch)
    {
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22027,34453,38393);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c')
              Value: 
                IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: C) (Syntax: 'c')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'd1')
              Value: 
                IParameterReferenceOperation: d1 (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'd1')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'ch1')
                  Value: 
                    IParameterReferenceOperation: ch1 (OperationKind.ParameterReference, Type: System.Char?) (Syntax: 'ch1')

            Jump if True (Regular) to Block[B4]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'ch1')
                  Operand: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Char?, IsImplicit) (Syntax: 'ch1')
                Leaving: {R2}

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'ch1')
                  Value: 
                    IInvocationOperation ( System.Char System.Char?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Char, IsImplicit) (Syntax: 'ch1')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Char?, IsImplicit) (Syntax: 'ch1')
                      Arguments(0)

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B4] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'ch2')
              Value: 
                IParameterReferenceOperation: ch2 (OperationKind.ParameterReference, Type: System.Char) (Syntax: 'ch2')

        Next (Regular) Block[B5]
    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'c.M2(d1, ch1 ?? ch2);')
              Expression: 
                IDynamicInvocationOperation (OperationKind.DynamicInvocation, Type: dynamic) (Syntax: 'c.M2(d1, ch1 ?? ch2)')
                  Expression: 
                    IDynamicMemberReferenceOperation (Member Name: ""M2"", Containing Type: null) (OperationKind.DynamicMemberReference, Type: null) (Syntax: 'c.M2')
                      Type Arguments(0)
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'c')
                  Arguments(2):
                      IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'd1')
                      IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Char, IsImplicit) (Syntax: 'ch1 ?? ch2')
                  ArgumentNames(0)
                  ArgumentRefKinds(0)

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22027,38407,38460);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22027,38476,38574);

f_22027_38476_38573(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22027,34002,38585);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22027,34002,38585);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22027,34002,38585);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void DynamicInvocation_ControlFlowInMultipleArguments()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22027,38597,43727);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22027,38779,39071);

string 
source = @"
class C
{
    void M(bool flag, char ch1, char ch2, C c, dynamic d1, dynamic d2)
    /*<bind>*/{
        c.M2(d1 ?? d2, flag ? ch1 : ch2);
    }/*</bind>*/

    public void M2(int i, char ch)
    {
    }

    public void M2(long i, char ch)
    {
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22027,39085,43535);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c')
              Value: 
                IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: C) (Syntax: 'c')

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
        Statements (0)
        Jump if False (Regular) to Block[B7]
            IParameterReferenceOperation: flag (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'flag')

        Next (Regular) Block[B6]
    Block[B6] - Block
        Predecessors: [B5]
        Statements (1)
            IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'ch1')
              Value: 
                IParameterReferenceOperation: ch1 (OperationKind.ParameterReference, Type: System.Char) (Syntax: 'ch1')

        Next (Regular) Block[B8]
    Block[B7] - Block
        Predecessors: [B5]
        Statements (1)
            IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'ch2')
              Value: 
                IParameterReferenceOperation: ch2 (OperationKind.ParameterReference, Type: System.Char) (Syntax: 'ch2')

        Next (Regular) Block[B8]
    Block[B8] - Block
        Predecessors: [B6] [B7]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'c.M2(d1 ??  ... ch1 : ch2);')
              Expression: 
                IDynamicInvocationOperation (OperationKind.DynamicInvocation, Type: dynamic) (Syntax: 'c.M2(d1 ??  ...  ch1 : ch2)')
                  Expression: 
                    IDynamicMemberReferenceOperation (Member Name: ""M2"", Containing Type: null) (OperationKind.DynamicMemberReference, Type: null) (Syntax: 'c.M2')
                      Type Arguments(0)
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'c')
                  Arguments(2):
                      IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'd1 ?? d2')
                      IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Char, IsImplicit) (Syntax: 'flag ? ch1 : ch2')
                  ArgumentNames(0)
                  ArgumentRefKinds(0)

        Next (Regular) Block[B9]
            Leaving: {R1}
}

Block[B9] - Exit
    Predecessors: [B8]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22027,43549,43602);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22027,43618,43716);

f_22027_43618_43715(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22027,38597,43727);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22027,38597,43727);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22027,38597,43727);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void DynamicInvocation_ControlFlowInReceiverAndArgument()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22027,43739,49658);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22027,44044,44325);

string 
source = @"
class C
{
    void M(C c1, C c2, dynamic d1, dynamic d2, int i)
    /*<bind>*/{
        (c1 ?? c2).M2(ref i, c: d1 ?? d2);
    }/*</bind>*/

    public void M2(ref int i, char c)
    {
    }

    public void M2(ref int i, long c)
    {
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22027,44339,49466);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2}

.locals {R1}
{
    CaptureIds: [1] [2] [4]
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
            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i')
              Value: 
                IParameterReferenceOperation: i (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i')

        Next (Regular) Block[B5]
            Entering: {R3}

    .locals {R3}
    {
        CaptureIds: [3]
        Block[B5] - Block
            Predecessors: [B4]
            Statements (1)
                IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'd1')
                  Value: 
                    IParameterReferenceOperation: d1 (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'd1')

            Jump if True (Regular) to Block[B7]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'd1')
                  Operand: 
                    IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'd1')
                Leaving: {R3}

            Next (Regular) Block[B6]
        Block[B6] - Block
            Predecessors: [B5]
            Statements (1)
                IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'd1')
                  Value: 
                    IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'd1')

            Next (Regular) Block[B8]
                Leaving: {R3}
    }

    Block[B7] - Block
        Predecessors: [B5]
        Statements (1)
            IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'd2')
              Value: 
                IParameterReferenceOperation: d2 (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'd2')

        Next (Regular) Block[B8]
    Block[B8] - Block
        Predecessors: [B6] [B7]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: '(c1 ?? c2). ...  d1 ?? d2);')
              Expression: 
                IDynamicInvocationOperation (OperationKind.DynamicInvocation, Type: dynamic) (Syntax: '(c1 ?? c2). ... : d1 ?? d2)')
                  Expression: 
                    IDynamicMemberReferenceOperation (Member Name: ""M2"", Containing Type: null) (OperationKind.DynamicMemberReference, Type: null) (Syntax: '(c1 ?? c2).M2')
                      Type Arguments(0)
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'c1 ?? c2')
                  Arguments(2):
                      IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'i')
                      IFlowCaptureReferenceOperation: 4 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'd1 ?? d2')
                  ArgumentNames(2):
                    ""null""
                    ""c""
                  ArgumentRefKinds(2):
                    Ref
                    None

        Next (Regular) Block[B9]
            Leaving: {R1}
}

Block[B9] - Exit
    Predecessors: [B8]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22027,49480,49533);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22027,49549,49647);

f_22027_49549_49646(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22027,43739,49658);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22027,43739,49658);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22027,43739,49658);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void DynamicInvocation_ControlFlowWithDynamicTypedMemberReceiver()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22027,49670,53681);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22027,49863,50018);

string 
source = @"
class C
{
    dynamic M2 = null;
    void M(C c, int? i1, int i2)
    /*<bind>*/{
        c.M2(i1 ?? i2);
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22027,50032,53489);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c.M2')
              Value: 
                IFieldReferenceOperation: dynamic C.M2 (OperationKind.FieldReference, Type: dynamic) (Syntax: 'c.M2')
                  Instance Receiver: 
                    IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: C) (Syntax: 'c')

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
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'c.M2(i1 ?? i2);')
              Expression: 
                IDynamicInvocationOperation (OperationKind.DynamicInvocation, Type: dynamic) (Syntax: 'c.M2(i1 ?? i2)')
                  Expression: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'c.M2')
                  Arguments(1):
                      IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'i1 ?? i2')
                  ArgumentNames(0)
                  ArgumentRefKinds(0)

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22027,53503,53556);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22027,53572,53670);

f_22027_53572_53669(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22027,49670,53681);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22027,49670,53681);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22027,49670,53681);
}
		}

int
f_22027_1516_1636(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InvocationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22027, 1516, 1636);
return 0;
}


int
f_22027_2737_2857(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InvocationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22027, 2737, 2857);
return 0;
}


int
f_22027_4121_4241(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InvocationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22027, 4121, 4241);
return 0;
}


int
f_22027_5506_5626(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InvocationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22027, 5506, 5626);
return 0;
}


int
f_22027_7008_7128(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InvocationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22027, 7008, 7128);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22027_8346_8400(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22027, 8346, 8400);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22027_8346_8429(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22027, 8346, 8429);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22027_8346_8449(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22027, 8346, 8449);
return return_v;
}


int
f_22027_8481_8601(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InvocationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22027, 8481, 8601);
return 0;
}


int
f_22027_9409_9529(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InvocationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22027, 9409, 9529);
return 0;
}


int
f_22027_10559_10679(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InvocationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22027, 10559, 10679);
return 0;
}


int
f_22027_11654_11774(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InvocationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22027, 11654, 11774);
return 0;
}


int
f_22027_13068_13188(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InvocationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22027, 13068, 13188);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22027_14991_15058(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22027, 14991, 15058);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22027_14991_15078(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22027, 14991, 15078);
return return_v;
}


int
f_22027_15110_15230(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InvocationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22027, 15110, 15230);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22027_16283_16338(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22027, 16283, 16338);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22027_16283_16375(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22027, 16283, 16375);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22027_16283_16395(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22027, 16283, 16395);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22027_16559_16649(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22027, 16559, 16649);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22027_16559_16671(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22027, 16559, 16671);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22027_16559_16691(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22027, 16559, 16691);
return return_v;
}


int
f_22027_16723_16843(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InvocationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22027, 16723, 16843);
return 0;
}


int
f_22027_17860_17980(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InvocationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22027, 17860, 17980);
return 0;
}


int
f_22027_19517_19614(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22027, 19517, 19614);
return 0;
}


int
f_22027_23061_23158(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22027, 23061, 23158);
return 0;
}


int
f_22027_26489_26586(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22027, 26489, 26586);
return 0;
}


int
f_22027_29835_29932(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22027, 29835, 29932);
return 0;
}


int
f_22027_33881_33978(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22027, 33881, 33978);
return 0;
}


int
f_22027_38476_38573(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22027, 38476, 38573);
return 0;
}


int
f_22027_43618_43715(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22027, 43618, 43715);
return 0;
}


int
f_22027_49549_49646(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22027, 49549, 49646);
return 0;
}


int
f_22027_53572_53669(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22027, 53572, 53669);
return 0;
}

}
}
