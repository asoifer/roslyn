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
[CompilerTrait(CompilerFeature.IOperation), WorkItem(21769, "https://github.com/dotnet/roslyn/issues/21769")]
        [Fact]
        public void IPropertyReferenceExpression_PropertyReferenceInDerivedTypeUsesDerivedTypeAsInstanceType()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22061,554,1809);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22061,816,1023);

string 
source = @"
class C
{
    void M1()
    {
        C2 c2 = new C2() { /*<bind>*/P1 = 1/*</bind>*/ };
    }
}

class C1
{
    public virtual int P1 { get; set; }
}

class C2 : C1
{
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22061,1037,1594);

string 
expectedOperationTree = @"
ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'P1 = 1')
  Left: 
    IPropertyReferenceOperation: System.Int32 C1.P1 { get; set; } (OperationKind.PropertyReference, Type: System.Int32) (Syntax: 'P1')
      Instance Receiver: 
        IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: C2, IsImplicit) (Syntax: 'P1')
  Right: 
    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22061,1608,1661);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22061,1677,1798);

f_22061_1677_1797(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22061,554,1809);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22061,554,1809);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22061,554,1809);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IPropertyReference_StaticPropertyWithInstanceReceiver()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22061,1821,3008);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22061,1982,2160);

string 
source = @"
class C
{
    static int I { get; }

    public static void M()
    {
        var c = new C();
        var i1 = /*<bind>*/c.I/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22061,2174,2478);

string 
expectedOperationTree = @"
IPropertyReferenceOperation: System.Int32 C.I { get; } (Static) (OperationKind.PropertyReference, Type: System.Int32, IsInvalid) (Syntax: 'c.I')
  Instance Receiver: 
    ILocalReferenceOperation: c (OperationKind.LocalReference, Type: C, IsInvalid) (Syntax: 'c')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22061,2492,2858);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22061_2752_2842(f_22061_2752_2822(f_22061_2752_2801(ErrorCode.ERR_ObjectProhibited, "c.I"), "C.I"), 9, 28)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22061,2874,2997);

f_22061_2874_2996(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22061,1821,3008);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22061,1821,3008);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22061,1821,3008);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IPropertyReference_StaticPropertyAccessOnClass()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22061,3020,3762);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22061,3174,3326);

string 
source = @"
class C
{
    static int I { get; }

    public static void M()
    {
        var i1 = /*<bind>*/C.I/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22061,3340,3545);

string 
expectedOperationTree = @"
IPropertyReferenceOperation: System.Int32 C.I { get; } (Static) (OperationKind.PropertyReference, Type: System.Int32) (Syntax: 'C.I')
  Instance Receiver: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22061,3559,3612);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22061,3628,3751);

f_22061_3628_3750(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22061,3020,3762);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22061,3020,3762);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22061,3020,3762);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IPropertyReference_InstancePropertyAccessOnClass()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22061,3774,4812);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22061,3930,4075);

string 
source = @"
class C
{
    int I { get; }

    public static void M()
    {
        var i1 = /*<bind>*/C.I/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22061,4089,4296);

string 
expectedOperationTree = @"
IPropertyReferenceOperation: System.Int32 C.I { get; } (OperationKind.PropertyReference, Type: System.Int32, IsInvalid) (Syntax: 'C.I')
  Instance Receiver: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22061,4310,4662);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22061_4558_4646(f_22061_4558_4626(f_22061_4558_4605(ErrorCode.ERR_ObjectRequired, "C.I"), "C.I"), 8, 28)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22061,4678,4801);

f_22061_4678_4800(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22061,3774,4812);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22061,3774,4812);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22061,3774,4812);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IPropertyReference_StaticPropertyWithInstanceReceiver_Indexer()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22061,4824,6957);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22061,4993,5233);

string 
source = @"
using System.Collections.Generic;

class C
{
    static List<int> list = new List<int>();

    public static void M()
    {
        var c = new C();
        var i1 = /*<bind>*/c.list[1]/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22061,5247,6410);

string 
expectedOperationTree = @"
IPropertyReferenceOperation: System.Int32 System.Collections.Generic.List<System.Int32>.this[System.Int32 index] { get; set; } (OperationKind.PropertyReference, Type: System.Int32, IsInvalid) (Syntax: 'c.list[1]')
  Instance Receiver: 
    IFieldReferenceOperation: System.Collections.Generic.List<System.Int32> C.list (Static) (OperationKind.FieldReference, Type: System.Collections.Generic.List<System.Int32>, IsInvalid) (Syntax: 'c.list')
      Instance Receiver: 
        ILocalReferenceOperation: c (OperationKind.LocalReference, Type: C, IsInvalid) (Syntax: 'c')
  Arguments(1):
      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: index) (OperationKind.Argument, Type: null) (Syntax: '1')
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22061,6424,6806);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22061_6693_6790(f_22061_6693_6769(f_22061_6693_6745(ErrorCode.ERR_ObjectProhibited, "c.list"), "C.list"), 11, 28)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22061,6822,6946);

f_22061_6822_6945(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22061,4824,6957);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22061,4824,6957);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22061,4824,6957);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IPropertyReference_StaticPropertyAccessOnClass_IndexerOnProperty()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22061,6969,8640);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22061,7141,7355);

string 
source = @"
using System.Collections.Generic;

class C
{
    static List<int> list = new List<int>();

    public static void M()
    {
        var i1 = /*<bind>*/C.list[1]/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22061,7369,8422);

string 
expectedOperationTree = @"
IPropertyReferenceOperation: System.Int32 System.Collections.Generic.List<System.Int32>.this[System.Int32 index] { get; set; } (OperationKind.PropertyReference, Type: System.Int32) (Syntax: 'C.list[1]')
  Instance Receiver: 
    IFieldReferenceOperation: System.Collections.Generic.List<System.Int32> C.list (Static) (OperationKind.FieldReference, Type: System.Collections.Generic.List<System.Int32>) (Syntax: 'C.list')
      Instance Receiver: 
        null
  Arguments(1):
      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: index) (OperationKind.Argument, Type: null) (Syntax: '1')
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22061,8436,8489);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22061,8505,8629);

f_22061_8505_8628(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22061,6969,8640);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22061,6969,8640);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22061,6969,8640);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IPropertyReference_InstancePropertyAccessOnClass_IndexerOnProperty()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22061,8652,10646);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22061,8826,9033);

string 
source = @"
using System.Collections.Generic;

class C
{
    List<int> list = new List<int>();

    public static void M()
    {
        var i1 = /*<bind>*/C.list[1]/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22061,9047,10113);

string 
expectedOperationTree = @"
IPropertyReferenceOperation: System.Int32 System.Collections.Generic.List<System.Int32>.this[System.Int32 index] { get; set; } (OperationKind.PropertyReference, Type: System.Int32, IsInvalid) (Syntax: 'C.list[1]')
  Instance Receiver: 
    IFieldReferenceOperation: System.Collections.Generic.List<System.Int32> C.list (OperationKind.FieldReference, Type: System.Collections.Generic.List<System.Int32>, IsInvalid) (Syntax: 'C.list')
      Instance Receiver: 
        null
  Arguments(1):
      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: index) (OperationKind.Argument, Type: null) (Syntax: '1')
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22061,10127,10495);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22061_10384_10479(f_22061_10384_10458(f_22061_10384_10434(ErrorCode.ERR_ObjectRequired, "C.list"), "C.list"), 10, 28)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22061,10511,10635);

f_22061_10511_10634(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22061,8652,10646);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22061,8652,10646);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22061,8652,10646);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IPropertyReference_InstancePropertyAccessOnClass_IndexerAccessOnType()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22061,10658,12488);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22061,10834,11039);

string 
source = @"
class C
{
    public C this[int i]
    {
        get => null;
        set { }
    }

    public static void M()
    {
        var c1 = /*<bind>*/C[1]/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22061,11053,11996);

string 
expectedOperationTree = @"
IPropertyReferenceOperation: C C.this[System.Int32 i] { get; set; } (OperationKind.PropertyReference, Type: C, IsInvalid) (Syntax: 'C[1]')
  Instance Receiver: 
    IInvalidOperation (OperationKind.Invalid, Type: C, IsInvalid, IsImplicit) (Syntax: 'C')
      Children(1):
          IOperation:  (OperationKind.None, Type: null, IsInvalid) (Syntax: 'C')
  Arguments(1):
      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: '1')
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22061,12010,12337);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22061_12230_12321(f_22061_12230_12300(f_22061_12230_12273(ErrorCode.ERR_BadSKunknown, "C"), "C", "type"), 12, 28)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22061,12353,12477);

f_22061_12353_12476(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22061,10658,12488);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22061,10658,12488);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22061,10658,12488);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IPropertyReference_InstancePropertyAccessOnClass_StaticIndexerAccessOnType()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22061,12500,14582);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22061,12682,12894);

string 
source = @"
class C
{
    public static C this[int i]
    {
        get => null;
        set { }
    }

    public static void M()
    {
        var c1 = /*<bind>*/C[1]/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22061,12908,13851);

string 
expectedOperationTree = @"
IPropertyReferenceOperation: C C.this[System.Int32 i] { get; set; } (OperationKind.PropertyReference, Type: C, IsInvalid) (Syntax: 'C[1]')
  Instance Receiver: 
    IInvalidOperation (OperationKind.Invalid, Type: C, IsInvalid, IsImplicit) (Syntax: 'C')
      Children(1):
          IOperation:  (OperationKind.None, Type: null, IsInvalid) (Syntax: 'C')
  Arguments(1):
      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: '1')
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22061,13865,14431);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22061_14067_14158(f_22061_14067_14138(f_22061_14067_14114(ErrorCode.ERR_BadMemberFlag, "this"), "static"), 4, 21),
f_22061_14324_14415(f_22061_14324_14394(f_22061_14324_14367(ErrorCode.ERR_BadSKunknown, "C"), "C", "type"), 12, 28)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22061,14447,14571);

f_22061_14447_14570(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22061,12500,14582);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22061,12500,14582);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22061,12500,14582);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IPropertyReference_StaticPropertyInObjectInitializer_NoInstance()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22061,14594,15700);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22061,14765,14936);

string 
source = @"
class C
{
    static int I1 { get; set; }
    public static void Main()
    {
        var c = new C { /*<bind>*/I1/*</bind>*/ = 1 };
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22061,14950,15171);

string 
expectedOperationTree = @"
IPropertyReferenceOperation: System.Int32 C.I1 { get; set; } (Static) (OperationKind.PropertyReference, Type: System.Int32, IsInvalid) (Syntax: 'I1')
  Instance Receiver: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22061,15185,15558);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22061_15437_15542(f_22061_15437_15522(f_22061_15437_15500(ErrorCode.ERR_StaticMemberInObjectInitializer, "I1"), "C.I1"), 7, 35)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22061,15574,15689);

f_22061_15574_15688(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22061,14594,15700);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22061,14594,15700);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22061,14594,15700);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void PropertyReference_NoControlFlow()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22061,15712,20191);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22061,16031,16293);

string 
source = @"
class C
{
    public int P1 { get; set; }
    public static int P2 { get; set; }
    public int this[int i] => 0;

    void M(C c, int i)
    /*<bind>*/{
        P1 = C.P2 + c[i];
        P2 = this.P1 + c.P1;
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22061,16307,19999);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (2)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'P1 = C.P2 + c[i];')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'P1 = C.P2 + c[i]')
              Left: 
                IPropertyReferenceOperation: System.Int32 C.P1 { get; set; } (OperationKind.PropertyReference, Type: System.Int32) (Syntax: 'P1')
                  Instance Receiver: 
                    IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C, IsImplicit) (Syntax: 'P1')
              Right: 
                IBinaryOperation (BinaryOperatorKind.Add) (OperationKind.Binary, Type: System.Int32) (Syntax: 'C.P2 + c[i]')
                  Left: 
                    IPropertyReferenceOperation: System.Int32 C.P2 { get; set; } (Static) (OperationKind.PropertyReference, Type: System.Int32) (Syntax: 'C.P2')
                      Instance Receiver: 
                        null
                  Right: 
                    IPropertyReferenceOperation: System.Int32 C.this[System.Int32 i] { get; } (OperationKind.PropertyReference, Type: System.Int32) (Syntax: 'c[i]')
                      Instance Receiver: 
                        IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: C) (Syntax: 'c')
                      Arguments(1):
                          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: 'i')
                            IParameterReferenceOperation: i (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i')
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'P2 = this.P1 + c.P1;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'P2 = this.P1 + c.P1')
              Left: 
                IPropertyReferenceOperation: System.Int32 C.P2 { get; set; } (Static) (OperationKind.PropertyReference, Type: System.Int32) (Syntax: 'P2')
                  Instance Receiver: 
                    null
              Right: 
                IBinaryOperation (BinaryOperatorKind.Add) (OperationKind.Binary, Type: System.Int32) (Syntax: 'this.P1 + c.P1')
                  Left: 
                    IPropertyReferenceOperation: System.Int32 C.P1 { get; set; } (OperationKind.PropertyReference, Type: System.Int32) (Syntax: 'this.P1')
                      Instance Receiver: 
                        IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C) (Syntax: 'this')
                  Right: 
                    IPropertyReferenceOperation: System.Int32 C.P1 { get; set; } (OperationKind.PropertyReference, Type: System.Int32) (Syntax: 'c.P1')
                      Instance Receiver: 
                        IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: C) (Syntax: 'c')

    Next (Regular) Block[B2]
Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22061,20013,20066);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22061,20082,20180);

f_22061_20082_20179(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22061,15712,20191);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22061,15712,20191);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22061,15712,20191);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void PropertyReference_ControlFlowInReceiver()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22061,20203,24554);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22061,20376,20548);

string 
source = @"
class C
{
    public int this[int i] => 0;
    void M(C c1, C c2, int i, int p)
    /*<bind>*/{
        p = (c1 ?? c2)[i];
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22061,20562,24362);

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
                IParameterReferenceOperation: p (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'p')

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
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'p = (c1 ?? c2)[i];')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'p = (c1 ?? c2)[i]')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'p')
                  Right: 
                    IPropertyReferenceOperation: System.Int32 C.this[System.Int32 i] { get; } (OperationKind.PropertyReference, Type: System.Int32) (Syntax: '(c1 ?? c2)[i]')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'c1 ?? c2')
                      Arguments(1):
                          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: 'i')
                            IParameterReferenceOperation: i (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i')
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22061,24376,24429);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22061,24445,24543);

f_22061_24445_24542(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22061,20203,24554);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22061,20203,24554);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22061,20203,24554);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void PropertyReference_ControlFlowInReceiver_StaticProperty()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22061,24566,27404);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22061,24754,24948);

string 
source = @"
class C
{
    public static int P1 => 0;
    void M(C c1, C c2, int p1, int p2)
    /*<bind>*/{
        p1 = c1.P1;
        p2 = (c1 ?? c2).P1;
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22061,24962,26583);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (2)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: 'p1 = c1.P1;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsInvalid) (Syntax: 'p1 = c1.P1')
              Left: 
                IParameterReferenceOperation: p1 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'p1')
              Right: 
                IPropertyReferenceOperation: System.Int32 C.P1 { get; } (Static) (OperationKind.PropertyReference, Type: System.Int32, IsInvalid) (Syntax: 'c1.P1')
                  Instance Receiver: 
                    null

        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: 'p2 = (c1 ?? c2).P1;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsInvalid) (Syntax: 'p2 = (c1 ?? c2).P1')
              Left: 
                IParameterReferenceOperation: p2 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'p2')
              Right: 
                IPropertyReferenceOperation: System.Int32 C.P1 { get; } (Static) (OperationKind.PropertyReference, Type: System.Int32, IsInvalid) (Syntax: '(c1 ?? c2).P1')
                  Instance Receiver: 
                    null

    Next (Regular) Block[B2]
Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22061,26597,27279);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22061_26856_26949(f_22061_26856_26929(f_22061_26856_26907(ErrorCode.ERR_ObjectProhibited, "c1.P1"), "C.P1"), 7, 14),
f_22061_27162_27263(f_22061_27162_27243(f_22061_27162_27221(ErrorCode.ERR_ObjectProhibited, "(c1 ?? c2).P1"), "C.P1"), 8, 14)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22061,27295,27393);

f_22061_27295_27392(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22061,24566,27404);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22061,24566,27404);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22061,24566,27404);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void PropertyReference_ControlFlowInFirstArgument()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22061,27416,33005);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22061,27594,27788);

string 
source = @"
class C
{
    public int this[int i1, int i2] => 0;
    void M(C c, int? i1, int i2, int i3, int p)
    /*<bind>*/{
        p = c[i1 ?? i2, i3];
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22061,27802,32813);

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
                IParameterReferenceOperation: p (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'p')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c')
              Value: 
                IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: C) (Syntax: 'c')

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
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'p = c[i1 ?? i2, i3];')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'p = c[i1 ?? i2, i3]')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'p')
                  Right: 
                    IPropertyReferenceOperation: System.Int32 C.this[System.Int32 i1, System.Int32 i2] { get; } (OperationKind.PropertyReference, Type: System.Int32) (Syntax: 'c[i1 ?? i2, i3]')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'c')
                      Arguments(2):
                          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i1) (OperationKind.Argument, Type: null) (Syntax: 'i1 ?? i2')
                            IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'i1 ?? i2')
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i2) (OperationKind.Argument, Type: null) (Syntax: 'i3')
                            IParameterReferenceOperation: i3 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i3')
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22061,32827,32880);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22061,32896,32994);

f_22061_32896_32993(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22061,27416,33005);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22061,27416,33005);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22061,27416,33005);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void PropertyReference_ControlFlowInSecondArgument()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22061,33017,38876);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22061,33196,33390);

string 
source = @"
class C
{
    public int this[int i1, int i2] => 0;
    void M(C c, int? i1, int i2, int i3, int p)
    /*<bind>*/{
        p = c[i3, i1 ?? i2];
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22061,33404,38684);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [1] [2] [4]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (3)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'p')
              Value: 
                IParameterReferenceOperation: p (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'p')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c')
              Value: 
                IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: C) (Syntax: 'c')

            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i3')
              Value: 
                IParameterReferenceOperation: i3 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i3')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [3]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i1')
                  Value: 
                    IParameterReferenceOperation: i1 (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'i1')

            Jump if True (Regular) to Block[B4]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'i1')
                  Operand: 
                    IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'i1')
                Leaving: {R2}

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i1')
                  Value: 
                    IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsImplicit) (Syntax: 'i1')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'i1')
                      Arguments(0)

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B4] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i2')
              Value: 
                IParameterReferenceOperation: i2 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i2')

        Next (Regular) Block[B5]
    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'p = c[i3, i1 ?? i2];')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'p = c[i3, i1 ?? i2]')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'p')
                  Right: 
                    IPropertyReferenceOperation: System.Int32 C.this[System.Int32 i1, System.Int32 i2] { get; } (OperationKind.PropertyReference, Type: System.Int32) (Syntax: 'c[i3, i1 ?? i2]')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'c')
                      Arguments(2):
                          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i1) (OperationKind.Argument, Type: null) (Syntax: 'i3')
                            IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'i3')
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i2) (OperationKind.Argument, Type: null) (Syntax: 'i1 ?? i2')
                            IFlowCaptureReferenceOperation: 4 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'i1 ?? i2')
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22061,38698,38751);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22061,38767,38865);

f_22061_38767_38864(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22061,33017,38876);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22061,33017,38876);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22061,33017,38876);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void PropertyReference_ControlFlowInReceiverAndArguments()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22061,38888,47883);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22061,39073,39298);

string 
source = @"
class C
{
    public int this[int i1, int i2] => 0;
    void M(C c1, C c2, int? i1, int i2, int? i3, int i4, int p)
    /*<bind>*/{
        p = (c1 ?? c2)[i1 ?? i2, i3 ?? i4];
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22061,39312,47691);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [2] [4] [6]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'p')
              Value: 
                IParameterReferenceOperation: p (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'p')

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
                Entering: {R3}
    }

    Block[B4] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c2')
              Value: 
                IParameterReferenceOperation: c2 (OperationKind.ParameterReference, Type: C) (Syntax: 'c2')

        Next (Regular) Block[B5]
            Entering: {R3}

    .locals {R3}
    {
        CaptureIds: [3]
        Block[B5] - Block
            Predecessors: [B3] [B4]
            Statements (1)
                IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i1')
                  Value: 
                    IParameterReferenceOperation: i1 (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'i1')

            Jump if True (Regular) to Block[B7]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'i1')
                  Operand: 
                    IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'i1')
                Leaving: {R3}

            Next (Regular) Block[B6]
        Block[B6] - Block
            Predecessors: [B5]
            Statements (1)
                IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i1')
                  Value: 
                    IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsImplicit) (Syntax: 'i1')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'i1')
                      Arguments(0)

            Next (Regular) Block[B8]
                Leaving: {R3}
                Entering: {R4}
    }

    Block[B7] - Block
        Predecessors: [B5]
        Statements (1)
            IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i2')
              Value: 
                IParameterReferenceOperation: i2 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i2')

        Next (Regular) Block[B8]
            Entering: {R4}

    .locals {R4}
    {
        CaptureIds: [5]
        Block[B8] - Block
            Predecessors: [B6] [B7]
            Statements (1)
                IFlowCaptureOperation: 5 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i3')
                  Value: 
                    IParameterReferenceOperation: i3 (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'i3')

            Jump if True (Regular) to Block[B10]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'i3')
                  Operand: 
                    IFlowCaptureReferenceOperation: 5 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'i3')
                Leaving: {R4}

            Next (Regular) Block[B9]
        Block[B9] - Block
            Predecessors: [B8]
            Statements (1)
                IFlowCaptureOperation: 6 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i3')
                  Value: 
                    IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsImplicit) (Syntax: 'i3')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 5 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'i3')
                      Arguments(0)

            Next (Regular) Block[B11]
                Leaving: {R4}
    }

    Block[B10] - Block
        Predecessors: [B8]
        Statements (1)
            IFlowCaptureOperation: 6 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i4')
              Value: 
                IParameterReferenceOperation: i4 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i4')

        Next (Regular) Block[B11]
    Block[B11] - Block
        Predecessors: [B9] [B10]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'p = (c1 ??  ...  i3 ?? i4];')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'p = (c1 ??  ... , i3 ?? i4]')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'p')
                  Right: 
                    IPropertyReferenceOperation: System.Int32 C.this[System.Int32 i1, System.Int32 i2] { get; } (OperationKind.PropertyReference, Type: System.Int32) (Syntax: '(c1 ?? c2)[ ... , i3 ?? i4]')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'c1 ?? c2')
                      Arguments(2):
                          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i1) (OperationKind.Argument, Type: null) (Syntax: 'i1 ?? i2')
                            IFlowCaptureReferenceOperation: 4 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'i1 ?? i2')
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i2) (OperationKind.Argument, Type: null) (Syntax: 'i3 ?? i4')
                            IFlowCaptureReferenceOperation: 6 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'i3 ?? i4')
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

        Next (Regular) Block[B12]
            Leaving: {R1}
}

Block[B12] - Exit
    Predecessors: [B11]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22061,47705,47758);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22061,47774,47872);

f_22061_47774_47871(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22061,38888,47883);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22061,38888,47883);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22061,38888,47883);
}
		}

[Fact, WorkItem(45692, "https://github.com/dotnet/roslyn/issues/45692")]
        public void NestedObjectInitializerMissingGet()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22061,47895,50259);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22061,48049,48249);

var 
comp = f_22061_48060_48248(@"
_ = new C { Prop1 = /*<bind>*/new C { [0] = 1 }/*</bind>*/ };

class C
{
    public object Prop1 { get; set; }
    public object this[int i] { set { } }

}
")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22061,48265,50248);

f_22061_48265_50247(comp, @"
IObjectCreationOperation (Constructor: C..ctor()) (OperationKind.ObjectCreation, Type: C) (Syntax: 'new C { [0] = 1 }')
  Arguments(0)
  Initializer: 
    IObjectOrCollectionInitializerOperation (OperationKind.ObjectOrCollectionInitializer, Type: C) (Syntax: '{ [0] = 1 }')
      Initializers(1):
          ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Object) (Syntax: '[0] = 1')
            Left: 
              IPropertyReferenceOperation: System.Object C.this[System.Int32 i] { set; } (OperationKind.PropertyReference, Type: System.Object) (Syntax: '[0]')
                Instance Receiver: 
                  IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: C, IsImplicit) (Syntax: '[0]')
                Arguments(1):
                    IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: '0')
                      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
                      InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                      OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            Right: 
              IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsImplicit) (Syntax: '1')
                Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                Operand: 
                  ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
            ", DiagnosticDescription.None);
DynAbs.Tracing.TraceSender.TraceExitMethod(22061,47895,50259);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22061,47895,50259);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22061,47895,50259);
}
		}

[Fact, WorkItem(45692, "https://github.com/dotnet/roslyn/issues/45692")]
        public void NestedObjectInitializerMissingGet_NestedInitializer()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22061,50271,54133);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22061,50443,50659);

var 
comp = f_22061_50454_50658(@"
_ = new C { Prop1 = /*<bind>*/new C { [0] = new C { Prop1 = 1 } }/*</bind>*/ };

class C
{
    public object Prop1 { get; set; }
    public object this[int i] { set { } }
}
")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22061,50675,54122);

f_22061_50675_54121(comp, @"
IObjectCreationOperation (Constructor: C..ctor()) (OperationKind.ObjectCreation, Type: C) (Syntax: 'new C { [0] ... op1 = 1 } }')
  Arguments(0)
  Initializer: 
    IObjectOrCollectionInitializerOperation (OperationKind.ObjectOrCollectionInitializer, Type: C) (Syntax: '{ [0] = new ... op1 = 1 } }')
      Initializers(1):
          ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Object) (Syntax: '[0] = new C ... Prop1 = 1 }')
            Left: 
              IPropertyReferenceOperation: System.Object C.this[System.Int32 i] { set; } (OperationKind.PropertyReference, Type: System.Object) (Syntax: '[0]')
                Instance Receiver: 
                  IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: C, IsImplicit) (Syntax: '[0]')
                Arguments(1):
                    IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: '0')
                      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
                      InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                      OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            Right: 
              IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsImplicit) (Syntax: 'new C { Prop1 = 1 }')
                Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                Operand: 
                  IObjectCreationOperation (Constructor: C..ctor()) (OperationKind.ObjectCreation, Type: C) (Syntax: 'new C { Prop1 = 1 }')
                    Arguments(0)
                    Initializer: 
                      IObjectOrCollectionInitializerOperation (OperationKind.ObjectOrCollectionInitializer, Type: C) (Syntax: '{ Prop1 = 1 }')
                        Initializers(1):
                            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Object) (Syntax: 'Prop1 = 1')
                              Left: 
                                IPropertyReferenceOperation: System.Object C.Prop1 { get; set; } (OperationKind.PropertyReference, Type: System.Object) (Syntax: 'Prop1')
                                  Instance Receiver: 
                                    IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: C, IsImplicit) (Syntax: 'Prop1')
                              Right: 
                                IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsImplicit) (Syntax: '1')
                                  Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                  Operand: 
                                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
            ", DiagnosticDescription.None);
DynAbs.Tracing.TraceSender.TraceExitMethod(22061,50271,54133);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22061,50271,54133);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22061,50271,54133);
}
		}

int
f_22061_1677_1797(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<AssignmentExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22061, 1677, 1797);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22061_2752_2801(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22061, 2752, 2801);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22061_2752_2822(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22061, 2752, 2822);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22061_2752_2842(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22061, 2752, 2842);
return return_v;
}


int
f_22061_2874_2996(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<MemberAccessExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22061, 2874, 2996);
return 0;
}


int
f_22061_3628_3750(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<MemberAccessExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22061, 3628, 3750);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22061_4558_4605(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22061, 4558, 4605);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22061_4558_4626(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22061, 4558, 4626);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22061_4558_4646(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22061, 4558, 4646);
return return_v;
}


int
f_22061_4678_4800(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<MemberAccessExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22061, 4678, 4800);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22061_6693_6745(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22061, 6693, 6745);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22061_6693_6769(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22061, 6693, 6769);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22061_6693_6790(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22061, 6693, 6790);
return return_v;
}


int
f_22061_6822_6945(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ElementAccessExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22061, 6822, 6945);
return 0;
}


int
f_22061_8505_8628(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ElementAccessExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22061, 8505, 8628);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22061_10384_10434(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22061, 10384, 10434);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22061_10384_10458(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22061, 10384, 10458);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22061_10384_10479(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22061, 10384, 10479);
return return_v;
}


int
f_22061_10511_10634(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ElementAccessExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22061, 10511, 10634);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22061_12230_12273(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22061, 12230, 12273);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22061_12230_12300(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22061, 12230, 12300);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22061_12230_12321(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22061, 12230, 12321);
return return_v;
}


int
f_22061_12353_12476(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ElementAccessExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22061, 12353, 12476);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22061_14067_14114(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22061, 14067, 14114);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22061_14067_14138(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22061, 14067, 14138);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22061_14067_14158(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22061, 14067, 14158);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22061_14324_14367(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22061, 14324, 14367);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22061_14324_14394(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22061, 14324, 14394);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22061_14324_14415(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22061, 14324, 14415);
return return_v;
}


int
f_22061_14447_14570(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ElementAccessExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22061, 14447, 14570);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22061_15437_15500(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22061, 15437, 15500);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22061_15437_15522(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22061, 15437, 15522);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22061_15437_15542(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22061, 15437, 15542);
return return_v;
}


int
f_22061_15574_15688(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<IdentifierNameSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22061, 15574, 15688);
return 0;
}


int
f_22061_20082_20179(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22061, 20082, 20179);
return 0;
}


int
f_22061_24445_24542(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22061, 24445, 24542);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22061_26856_26907(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22061, 26856, 26907);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22061_26856_26929(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22061, 26856, 26929);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22061_26856_26949(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22061, 26856, 26949);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22061_27162_27221(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22061, 27162, 27221);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22061_27162_27243(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22061, 27162, 27243);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22061_27162_27263(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22061, 27162, 27263);
return return_v;
}


int
f_22061_27295_27392(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22061, 27295, 27392);
return 0;
}


int
f_22061_32896_32993(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22061, 32896, 32993);
return 0;
}


int
f_22061_38767_38864(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22061, 38767, 38864);
return 0;
}


int
f_22061_47774_47871(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22061, 47774, 47871);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22061_48060_48248(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22061, 48060, 48248);
return return_v;
}


int
f_22061_48265_50247(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ObjectCreationExpressionSyntax>( compilation, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22061, 48265, 50247);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22061_50454_50658(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22061, 50454, 50658);
return return_v;
}


int
f_22061_50675_54121(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ObjectCreationExpressionSyntax>( compilation, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22061, 50675, 54121);
return 0;
}

}
}
