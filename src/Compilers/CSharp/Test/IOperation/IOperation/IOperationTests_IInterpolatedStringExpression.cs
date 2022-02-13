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
        [Fact, WorkItem(18300, "https://github.com/dotnet/roslyn/issues/18300")]
        public void InterpolatedStringExpression_Empty()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22041,501,1273);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22041,709,867);

string 
source = @"
using System;

internal class Class
{
    public void M()
    {
        Console.WriteLine(/*<bind>*/$""""/*</bind>*/);
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22041,881,1050);

string 
expectedOperationTree = @"
IInterpolatedStringOperation (OperationKind.InterpolatedString, Type: System.String, Constant: """") (Syntax: '$""""')
  Parts(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22041,1064,1117);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22041,1133,1262);

f_22041_1133_1261(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22041,501,1273);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22041,501,1273);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22041,501,1273);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(18300, "https://github.com/dotnet/roslyn/issues/18300")]
        public void InterpolatedStringExpression_OnlyTextPart()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22041,1285,2384);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22041,1500,1672);

string 
source = @"
using System;

internal class Class
{
    public void M()
    {
        Console.WriteLine(/*<bind>*/$""Only text part""/*</bind>*/);
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22041,1686,2161);

string 
expectedOperationTree = @"
IInterpolatedStringOperation (OperationKind.InterpolatedString, Type: System.String, Constant: ""Only text part"") (Syntax: '$""Only text part""')
  Parts(1):
      IInterpolatedStringTextOperation (OperationKind.InterpolatedStringText, Type: null) (Syntax: 'Only text part')
        Text: 
          ILiteralOperation (OperationKind.Literal, Type: System.String, Constant: ""Only text part"", IsImplicit) (Syntax: 'Only text part')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22041,2175,2228);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22041,2244,2373);

f_22041_2244_2372(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22041,1285,2384);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22041,1285,2384);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22041,1285,2384);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(18300, "https://github.com/dotnet/roslyn/issues/18300")]
        public void InterpolatedStringExpression_OnlyInterpolationPart()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22041,2396,3463);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22041,2620,2781);

string 
source = @"
using System;

internal class Class
{
    public void M()
    {
        Console.WriteLine(/*<bind>*/$""{1}""/*</bind>*/);
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22041,2795,3240);

string 
expectedOperationTree = @"
IInterpolatedStringOperation (OperationKind.InterpolatedString, Type: System.String) (Syntax: '$""{1}""')
  Parts(1):
      IInterpolationOperation (OperationKind.Interpolation, Type: null) (Syntax: '{1}')
        Expression: 
          ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
        Alignment: 
          null
        FormatString: 
          null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22041,3254,3307);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22041,3323,3452);

f_22041_3323_3451(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22041,2396,3463);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22041,2396,3463);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22041,2396,3463);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(18300, "https://github.com/dotnet/roslyn/issues/18300")]
        public void InterpolatedStringExpression_EmptyInterpolationPart()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22041,3475,4803);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22041,3700,3860);

string 
source = @"
using System;

internal class Class
{
    public void M()
    {
        Console.WriteLine(/*<bind>*/$""{}""/*</bind>*/);
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22041,3874,4353);

string 
expectedOperationTree = @"
IInterpolatedStringOperation (OperationKind.InterpolatedString, Type: System.String, IsInvalid) (Syntax: '$""{}""')
  Parts(1):
      IInterpolationOperation (OperationKind.Interpolation, Type: null, IsInvalid) (Syntax: '{}')
        Expression: 
          IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid) (Syntax: '')
            Children(0)
        Alignment: 
          null
        FormatString: 
          null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22041,4367,4647);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22041_4563_4631(f_22041_4563_4611(ErrorCode.ERR_ExpressionExpected, ""), 8, 40)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22041,4663,4792);

f_22041_4663_4791(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22041,3475,4803);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22041,3475,4803);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22041,3475,4803);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(18300, "https://github.com/dotnet/roslyn/issues/18300")]
        public void InterpolatedStringExpression_TextAndInterpolationParts()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22041,4815,6769);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22041,5043,5233);

string 
source = @"
using System;

internal class Class
{
    public void M(int x)
    {
        Console.WriteLine(/*<bind>*/$""String {x} and constant {1}""/*</bind>*/);
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22041,5247,6546);

string 
expectedOperationTree = @"
IInterpolatedStringOperation (OperationKind.InterpolatedString, Type: System.String) (Syntax: '$""String {x ... nstant {1}""')
  Parts(4):
      IInterpolatedStringTextOperation (OperationKind.InterpolatedStringText, Type: null) (Syntax: 'String ')
        Text: 
          ILiteralOperation (OperationKind.Literal, Type: System.String, Constant: ""String "", IsImplicit) (Syntax: 'String ')
      IInterpolationOperation (OperationKind.Interpolation, Type: null) (Syntax: '{x}')
        Expression: 
          IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'x')
        Alignment: 
          null
        FormatString: 
          null
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
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22041,6560,6613);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22041,6629,6758);

f_22041_6629_6757(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22041,4815,6769);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22041,4815,6769);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22041,4815,6769);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(18300, "https://github.com/dotnet/roslyn/issues/18300")]
        public void InterpolatedStringExpression_FormatAndAlignment()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22041,6781,9937);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22041,7002,7265);

string 
source = @"
using System;

internal class Class
{
    private string x = string.Empty;
    private int y = 0;

    public void M()
    {
        Console.WriteLine(/*<bind>*/$""String {x,20} and {y:D3} and constant {1}""/*</bind>*/);
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22041,7279,9714);

string 
expectedOperationTree = @"
IInterpolatedStringOperation (OperationKind.InterpolatedString, Type: System.String) (Syntax: '$""String {x ... nstant {1}""')
  Parts(6):
      IInterpolatedStringTextOperation (OperationKind.InterpolatedStringText, Type: null) (Syntax: 'String ')
        Text: 
          ILiteralOperation (OperationKind.Literal, Type: System.String, Constant: ""String "", IsImplicit) (Syntax: 'String ')
      IInterpolationOperation (OperationKind.Interpolation, Type: null) (Syntax: '{x,20}')
        Expression: 
          IFieldReferenceOperation: System.String Class.x (OperationKind.FieldReference, Type: System.String) (Syntax: 'x')
            Instance Receiver: 
              IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: Class, IsImplicit) (Syntax: 'x')
        Alignment: 
          ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 20) (Syntax: '20')
        FormatString: 
          null
      IInterpolatedStringTextOperation (OperationKind.InterpolatedStringText, Type: null) (Syntax: ' and ')
        Text: 
          ILiteralOperation (OperationKind.Literal, Type: System.String, Constant: "" and "", IsImplicit) (Syntax: ' and ')
      IInterpolationOperation (OperationKind.Interpolation, Type: null) (Syntax: '{y:D3}')
        Expression: 
          IFieldReferenceOperation: System.Int32 Class.y (OperationKind.FieldReference, Type: System.Int32) (Syntax: 'y')
            Instance Receiver: 
              IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: Class, IsImplicit) (Syntax: 'y')
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
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22041,9728,9781);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22041,9797,9926);

f_22041_9797_9925(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22041,6781,9937);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22041,6781,9937);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22041,6781,9937);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(18300, "https://github.com/dotnet/roslyn/issues/18300")]
        public void InterpolatedStringExpression_InterpolationAndFormatAndAlignment()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22041,9949,11872);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22041,10186,10429);

string 
source = @"
using System;

internal class Class
{
    private string x = string.Empty;
    private const int y = 0;

    public void M()
    {
        Console.WriteLine(/*<bind>*/$""String {x,y:D3}""/*</bind>*/);
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22041,10443,11649);

string 
expectedOperationTree = @"
IInterpolatedStringOperation (OperationKind.InterpolatedString, Type: System.String) (Syntax: '$""String {x,y:D3}""')
  Parts(2):
      IInterpolatedStringTextOperation (OperationKind.InterpolatedStringText, Type: null) (Syntax: 'String ')
        Text: 
          ILiteralOperation (OperationKind.Literal, Type: System.String, Constant: ""String "", IsImplicit) (Syntax: 'String ')
      IInterpolationOperation (OperationKind.Interpolation, Type: null) (Syntax: '{x,y:D3}')
        Expression: 
          IFieldReferenceOperation: System.String Class.x (OperationKind.FieldReference, Type: System.String) (Syntax: 'x')
            Instance Receiver: 
              IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: Class, IsImplicit) (Syntax: 'x')
        Alignment: 
          IFieldReferenceOperation: System.Int32 Class.y (Static) (OperationKind.FieldReference, Type: System.Int32, Constant: 0) (Syntax: 'y')
            Instance Receiver: 
              null
        FormatString: 
          ILiteralOperation (OperationKind.Literal, Type: System.String, Constant: ""D3"") (Syntax: ':D3')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22041,11663,11716);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22041,11732,11861);

f_22041_11732_11860(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22041,9949,11872);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22041,9949,11872);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22041,9949,11872);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(18300, "https://github.com/dotnet/roslyn/issues/18300")]
        public void InterpolatedStringExpression_InvocationInInterpolation()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22041,11884,15315);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22041,12112,12412);

string 
source = @"
using System;

internal class Class
{
    public void M()
    {
        string x = string.Empty;
        int y = 0;
        Console.WriteLine(/*<bind>*/$""String {x} and {M2(y)} and constant {1}""/*</bind>*/);
    }

    private string M2(int z) => z.ToString();
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22041,12426,15092);

string 
expectedOperationTree = @"
IInterpolatedStringOperation (OperationKind.InterpolatedString, Type: System.String) (Syntax: '$""String {x ... nstant {1}""')
  Parts(6):
      IInterpolatedStringTextOperation (OperationKind.InterpolatedStringText, Type: null) (Syntax: 'String ')
        Text: 
          ILiteralOperation (OperationKind.Literal, Type: System.String, Constant: ""String "", IsImplicit) (Syntax: 'String ')
      IInterpolationOperation (OperationKind.Interpolation, Type: null) (Syntax: '{x}')
        Expression: 
          ILocalReferenceOperation: x (OperationKind.LocalReference, Type: System.String) (Syntax: 'x')
        Alignment: 
          null
        FormatString: 
          null
      IInterpolatedStringTextOperation (OperationKind.InterpolatedStringText, Type: null) (Syntax: ' and ')
        Text: 
          ILiteralOperation (OperationKind.Literal, Type: System.String, Constant: "" and "", IsImplicit) (Syntax: ' and ')
      IInterpolationOperation (OperationKind.Interpolation, Type: null) (Syntax: '{M2(y)}')
        Expression: 
          IInvocationOperation ( System.String Class.M2(System.Int32 z)) (OperationKind.Invocation, Type: System.String) (Syntax: 'M2(y)')
            Instance Receiver: 
              IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: Class, IsImplicit) (Syntax: 'M2')
            Arguments(1):
                IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: z) (OperationKind.Argument, Type: null) (Syntax: 'y')
                  ILocalReferenceOperation: y (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'y')
                  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Alignment: 
          null
        FormatString: 
          null
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
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22041,15106,15159);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22041,15175,15304);

f_22041_15175_15303(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22041,11884,15315);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22041,11884,15315);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22041,11884,15315);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(18300, "https://github.com/dotnet/roslyn/issues/18300")]
        public void InterpolatedStringExpression_NestedInterpolation()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22041,15327,18107);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22041,15549,15833);

string 
source = @"
using System;

internal class Class
{
    public void M()
    {
        string x = string.Empty;
        int y = 0;
        Console.WriteLine(/*<bind>*/$""String {M2($""{y}"")}""/*</bind>*/);
    }

    private int M2(string z) => Int32.Parse(z);
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22041,15847,17884);

string 
expectedOperationTree = @"
IInterpolatedStringOperation (OperationKind.InterpolatedString, Type: System.String) (Syntax: '$""String {M2($""{y}"")}""')
  Parts(2):
      IInterpolatedStringTextOperation (OperationKind.InterpolatedStringText, Type: null) (Syntax: 'String ')
        Text: 
          ILiteralOperation (OperationKind.Literal, Type: System.String, Constant: ""String "", IsImplicit) (Syntax: 'String ')
      IInterpolationOperation (OperationKind.Interpolation, Type: null) (Syntax: '{M2($""{y}"")}')
        Expression: 
          IInvocationOperation ( System.Int32 Class.M2(System.String z)) (OperationKind.Invocation, Type: System.Int32) (Syntax: 'M2($""{y}"")')
            Instance Receiver: 
              IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: Class, IsImplicit) (Syntax: 'M2')
            Arguments(1):
                IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: z) (OperationKind.Argument, Type: null) (Syntax: '$""{y}""')
                  IInterpolatedStringOperation (OperationKind.InterpolatedString, Type: System.String) (Syntax: '$""{y}""')
                    Parts(1):
                        IInterpolationOperation (OperationKind.Interpolation, Type: null) (Syntax: '{y}')
                          Expression: 
                            ILocalReferenceOperation: y (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'y')
                          Alignment: 
                            null
                          FormatString: 
                            null
                  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Alignment: 
          null
        FormatString: 
          null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22041,17898,17951);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22041,17967,18096);

f_22041_17967_18095(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22041,15327,18107);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22041,15327,18107);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22041,15327,18107);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(18300, "https://github.com/dotnet/roslyn/issues/18300")]
        public void InterpolatedStringExpression_InvalidExpressionInInterpolation()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22041,18119,20867);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22041,18354,18549);

string 
source = @"
using System;

internal class Class
{
    public void M(int x)
    {
        Console.WriteLine(/*<bind>*/$""String {x1} and constant {Class}""/*</bind>*/);
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22041,18563,20026);

string 
expectedOperationTree = @"
IInterpolatedStringOperation (OperationKind.InterpolatedString, Type: System.String, IsInvalid) (Syntax: '$""String {x ... nt {Class}""')
  Parts(4):
      IInterpolatedStringTextOperation (OperationKind.InterpolatedStringText, Type: null) (Syntax: 'String ')
        Text: 
          ILiteralOperation (OperationKind.Literal, Type: System.String, Constant: ""String "", IsImplicit) (Syntax: 'String ')
      IInterpolationOperation (OperationKind.Interpolation, Type: null, IsInvalid) (Syntax: '{x1}')
        Expression: 
          IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid) (Syntax: 'x1')
            Children(0)
        Alignment: 
          null
        FormatString: 
          null
      IInterpolatedStringTextOperation (OperationKind.InterpolatedStringText, Type: null) (Syntax: ' and constant ')
        Text: 
          ILiteralOperation (OperationKind.Literal, Type: System.String, Constant: "" and constant "", IsImplicit) (Syntax: ' and constant ')
      IInterpolationOperation (OperationKind.Interpolation, Type: null, IsInvalid) (Syntax: '{Class}')
        Expression: 
          IInvalidOperation (OperationKind.Invalid, Type: Class, IsInvalid, IsImplicit) (Syntax: 'Class')
            Children(1):
                IOperation:  (OperationKind.None, Type: null, IsInvalid) (Syntax: 'Class')
        Alignment: 
          null
        FormatString: 
          null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22041,20040,20711);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22041_20298_20386(f_22041_20298_20366(f_22041_20298_20346(ErrorCode.ERR_NameNotInContext, "x1"), "x1"), 8, 47),
f_22041_20597_20695(f_22041_20597_20675(f_22041_20597_20644(ErrorCode.ERR_BadSKunknown, "Class"), "Class", "type"), 8, 65)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22041,20727,20856);

f_22041_20727_20855(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22041,18119,20867);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22041,18119,20867);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22041,18119,20867);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void InterpolatedStringExpression_Empty_Flow()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22041,20879,22246);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22041,21052,21203);

string 
source = @"
using System;

internal class Class
{
    public void M(string p)
    /*<bind>*/{
        p = $"""";
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22041,21217,22054);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (1)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'p = $"""";')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.String) (Syntax: 'p = $""""')
              Left: 
                IParameterReferenceOperation: p (OperationKind.ParameterReference, Type: System.String) (Syntax: 'p')
              Right: 
                IInterpolatedStringOperation (OperationKind.InterpolatedString, Type: System.String, Constant: """") (Syntax: '$""""')
                  Parts(0)

    Next (Regular) Block[B2]
Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22041,22068,22121);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22041,22137,22235);

f_22041_22137_22234(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22041,20879,22246);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22041,20879,22246);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22041,20879,22246);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void InterpolatedStringExpression_OnlyTextPart_Flow()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22041,22258,24028);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22041,22438,22603);

string 
source = @"
using System;

internal class Class
{
    public void M(string p)
    /*<bind>*/{
        p = $""Only text part"";
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22041,22617,23836);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (1)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'p = $""Only text part"";')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.String) (Syntax: 'p = $""Only text part""')
              Left: 
                IParameterReferenceOperation: p (OperationKind.ParameterReference, Type: System.String) (Syntax: 'p')
              Right: 
                IInterpolatedStringOperation (OperationKind.InterpolatedString, Type: System.String, Constant: ""Only text part"") (Syntax: '$""Only text part""')
                  Parts(1):
                      IInterpolatedStringTextOperation (OperationKind.InterpolatedStringText, Type: null) (Syntax: 'Only text part')
                        Text: 
                          ILiteralOperation (OperationKind.Literal, Type: System.String, Constant: ""Only text part"", IsImplicit) (Syntax: 'Only text part')

    Next (Regular) Block[B2]
Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22041,23850,23903);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22041,23919,24017);

f_22041_23919_24016(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22041,22258,24028);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22041,22258,24028);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22041,22258,24028);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void InterpolatedStringExpression_OnlyInterpolationPart_Flow()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22041,24040,27367);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22041,24229,24421);

string 
source = @"
using System;

internal class Class
{
    public void M(bool a, string b, string c, string p)
    /*<bind>*/{
        p = $""{(a ? b : c)}"";
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22041,24435,27175);

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
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'p')
              Value: 
                IParameterReferenceOperation: p (OperationKind.ParameterReference, Type: System.String) (Syntax: 'p')

        Jump if False (Regular) to Block[B3]
            IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'a')

        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'b')
              Value: 
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.String) (Syntax: 'b')

        Next (Regular) Block[B4]
    Block[B3] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c')
              Value: 
                IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: System.String) (Syntax: 'c')

        Next (Regular) Block[B4]
    Block[B4] - Block
        Predecessors: [B2] [B3]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'p = $""{(a ? b : c)}"";')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.String) (Syntax: 'p = $""{(a ? b : c)}""')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.String, IsImplicit) (Syntax: 'p')
                  Right: 
                    IInterpolatedStringOperation (OperationKind.InterpolatedString, Type: System.String) (Syntax: '$""{(a ? b : c)}""')
                      Parts(1):
                          IInterpolationOperation (OperationKind.Interpolation, Type: null) (Syntax: '{(a ? b : c)}')
                            Expression: 
                              IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.String, IsImplicit) (Syntax: 'a ? b : c')
                            Alignment: 
                              null
                            FormatString: 
                              null

        Next (Regular) Block[B5]
            Leaving: {R1}
}

Block[B5] - Exit
    Predecessors: [B4]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22041,27189,27242);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22041,27258,27356);

f_22041_27258_27355(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22041,24040,27367);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22041,24040,27367);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22041,24040,27367);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void InterpolatedStringExpression_MultipleInterpolationParts_Flow()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22041,27379,31184);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22041,27573,27780);

string 
source = @"
using System;

internal class Class
{
    public void M(bool a, string b, string c, string c2, string p)
    /*<bind>*/{
        p = $""{(a ? b : c)}{c2}"";
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22041,27794,30992);

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
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'p')
              Value: 
                IParameterReferenceOperation: p (OperationKind.ParameterReference, Type: System.String) (Syntax: 'p')

        Jump if False (Regular) to Block[B3]
            IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'a')

        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'b')
              Value: 
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.String) (Syntax: 'b')

        Next (Regular) Block[B4]
    Block[B3] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c')
              Value: 
                IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: System.String) (Syntax: 'c')

        Next (Regular) Block[B4]
    Block[B4] - Block
        Predecessors: [B2] [B3]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'p = $""{(a ? ... : c)}{c2}"";')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.String) (Syntax: 'p = $""{(a ? b : c)}{c2}""')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.String, IsImplicit) (Syntax: 'p')
                  Right: 
                    IInterpolatedStringOperation (OperationKind.InterpolatedString, Type: System.String) (Syntax: '$""{(a ? b : c)}{c2}""')
                      Parts(2):
                          IInterpolationOperation (OperationKind.Interpolation, Type: null) (Syntax: '{(a ? b : c)}')
                            Expression: 
                              IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.String, IsImplicit) (Syntax: 'a ? b : c')
                            Alignment: 
                              null
                            FormatString: 
                              null
                          IInterpolationOperation (OperationKind.Interpolation, Type: null) (Syntax: '{c2}')
                            Expression: 
                              IParameterReferenceOperation: c2 (OperationKind.ParameterReference, Type: System.String) (Syntax: 'c2')
                            Alignment: 
                              null
                            FormatString: 
                              null

        Next (Regular) Block[B5]
            Leaving: {R1}
}

Block[B5] - Exit
    Predecessors: [B4]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22041,31006,31059);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22041,31075,31173);

f_22041_31075_31172(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22041,27379,31184);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22041,27379,31184);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22041,27379,31184);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void InterpolatedStringExpression_TextAndInterpolationParts_Flow()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22041,31196,36757);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22041,31389,31649);

string 
source = @"
using System;

internal class Class
{
    public void M(bool a, string b, string c, bool a2, string b2, string c2, string p)
    /*<bind>*/{
        p = $""String1 {(a ? b : c)} and String2 {(a2 ? b2 : c2)}"";
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22041,31663,36565);

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
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'p')
              Value: 
                IParameterReferenceOperation: p (OperationKind.ParameterReference, Type: System.String) (Syntax: 'p')

        Jump if False (Regular) to Block[B3]
            IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'a')

        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'b')
              Value: 
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.String) (Syntax: 'b')

        Next (Regular) Block[B4]
    Block[B3] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c')
              Value: 
                IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: System.String) (Syntax: 'c')

        Next (Regular) Block[B4]
    Block[B4] - Block
        Predecessors: [B2] [B3]
        Statements (0)
        Jump if False (Regular) to Block[B6]
            IParameterReferenceOperation: a2 (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'a2')

        Next (Regular) Block[B5]
    Block[B5] - Block
        Predecessors: [B4]
        Statements (1)
            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'b2')
              Value: 
                IParameterReferenceOperation: b2 (OperationKind.ParameterReference, Type: System.String) (Syntax: 'b2')

        Next (Regular) Block[B7]
    Block[B6] - Block
        Predecessors: [B4]
        Statements (1)
            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c2')
              Value: 
                IParameterReferenceOperation: c2 (OperationKind.ParameterReference, Type: System.String) (Syntax: 'c2')

        Next (Regular) Block[B7]
    Block[B7] - Block
        Predecessors: [B5] [B6]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'p = $""Strin ... b2 : c2)}"";')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.String) (Syntax: 'p = $""Strin ...  b2 : c2)}""')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.String, IsImplicit) (Syntax: 'p')
                  Right: 
                    IInterpolatedStringOperation (OperationKind.InterpolatedString, Type: System.String) (Syntax: '$""String1 { ...  b2 : c2)}""')
                      Parts(4):
                          IInterpolatedStringTextOperation (OperationKind.InterpolatedStringText, Type: null) (Syntax: 'String1 ')
                            Text: 
                              ILiteralOperation (OperationKind.Literal, Type: System.String, Constant: ""String1 "", IsImplicit) (Syntax: 'String1 ')
                          IInterpolationOperation (OperationKind.Interpolation, Type: null) (Syntax: '{(a ? b : c)}')
                            Expression: 
                              IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.String, IsImplicit) (Syntax: 'a ? b : c')
                            Alignment: 
                              null
                            FormatString: 
                              null
                          IInterpolatedStringTextOperation (OperationKind.InterpolatedStringText, Type: null) (Syntax: ' and String2 ')
                            Text: 
                              ILiteralOperation (OperationKind.Literal, Type: System.String, Constant: "" and String2 "", IsImplicit) (Syntax: ' and String2 ')
                          IInterpolationOperation (OperationKind.Interpolation, Type: null) (Syntax: '{(a2 ? b2 : c2)}')
                            Expression: 
                              IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.String, IsImplicit) (Syntax: 'a2 ? b2 : c2')
                            Alignment: 
                              null
                            FormatString: 
                              null

        Next (Regular) Block[B8]
            Leaving: {R1}
}

Block[B8] - Exit
    Predecessors: [B7]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22041,36579,36632);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22041,36648,36746);

f_22041_36648_36745(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22041,31196,36757);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22041,31196,36757);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22041,31196,36757);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void InterpolatedStringExpression_FormatAndAlignment_Flow()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22041,36769,40302);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22041,36955,37153);

string 
source = @"
using System;

internal class Class
{
    public void M(bool a, string b, string c, string p)
    /*<bind>*/{
        p = $""{(a ? b : c),20:D3}"";
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22041,37167,40110);

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
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'p')
              Value: 
                IParameterReferenceOperation: p (OperationKind.ParameterReference, Type: System.String) (Syntax: 'p')

        Jump if False (Regular) to Block[B3]
            IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'a')

        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'b')
              Value: 
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.String) (Syntax: 'b')

        Next (Regular) Block[B4]
    Block[B3] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c')
              Value: 
                IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: System.String) (Syntax: 'c')

        Next (Regular) Block[B4]
    Block[B4] - Block
        Predecessors: [B2] [B3]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'p = $""{(a ? ... c),20:D3}"";')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.String) (Syntax: 'p = $""{(a ? ...  c),20:D3}""')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.String, IsImplicit) (Syntax: 'p')
                  Right: 
                    IInterpolatedStringOperation (OperationKind.InterpolatedString, Type: System.String) (Syntax: '$""{(a ? b : c),20:D3}""')
                      Parts(1):
                          IInterpolationOperation (OperationKind.Interpolation, Type: null) (Syntax: '{(a ? b : c),20:D3}')
                            Expression: 
                              IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.String, IsImplicit) (Syntax: 'a ? b : c')
                            Alignment: 
                              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 20) (Syntax: '20')
                            FormatString: 
                              ILiteralOperation (OperationKind.Literal, Type: System.String, Constant: ""D3"") (Syntax: ':D3')

        Next (Regular) Block[B5]
            Leaving: {R1}
}

Block[B5] - Exit
    Predecessors: [B4]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22041,40124,40177);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22041,40193,40291);

f_22041_40193_40290(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22041,36769,40302);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22041,36769,40302);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22041,36769,40302);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void InterpolatedStringExpression_FormatAndAlignment_Flow_02()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22041,40314,44867);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22041,40503,40716);

string 
source = @"
using System;

internal class Class
{
    public void M(bool a, string b, string b2, string c, string p)
    /*<bind>*/{
        p = $""{b2,20:D3}{(a ? b : c)}"";
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22041,40730,44675);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [1] [2] [3]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (3)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'p')
              Value: 
                IParameterReferenceOperation: p (OperationKind.ParameterReference, Type: System.String) (Syntax: 'p')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'b2')
              Value: 
                IParameterReferenceOperation: b2 (OperationKind.ParameterReference, Type: System.String) (Syntax: 'b2')

            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '20')
              Value: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 20) (Syntax: '20')

        Jump if False (Regular) to Block[B3]
            IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'a')

        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'b')
              Value: 
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.String) (Syntax: 'b')

        Next (Regular) Block[B4]
    Block[B3] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c')
              Value: 
                IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: System.String) (Syntax: 'c')

        Next (Regular) Block[B4]
    Block[B4] - Block
        Predecessors: [B2] [B3]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'p = $""{b2,2 ... ? b : c)}"";')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.String) (Syntax: 'p = $""{b2,2 ...  ? b : c)}""')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.String, IsImplicit) (Syntax: 'p')
                  Right: 
                    IInterpolatedStringOperation (OperationKind.InterpolatedString, Type: System.String) (Syntax: '$""{b2,20:D3 ...  ? b : c)}""')
                      Parts(2):
                          IInterpolationOperation (OperationKind.Interpolation, Type: null) (Syntax: '{b2,20:D3}')
                            Expression: 
                              IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.String, IsImplicit) (Syntax: 'b2')
                            Alignment: 
                              IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, Constant: 20, IsImplicit) (Syntax: '20')
                            FormatString: 
                              ILiteralOperation (OperationKind.Literal, Type: System.String, Constant: ""D3"") (Syntax: ':D3')
                          IInterpolationOperation (OperationKind.Interpolation, Type: null) (Syntax: '{(a ? b : c)}')
                            Expression: 
                              IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.String, IsImplicit) (Syntax: 'a ? b : c')
                            Alignment: 
                              null
                            FormatString: 
                              null

        Next (Regular) Block[B5]
            Leaving: {R1}
}

Block[B5] - Exit
    Predecessors: [B4]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22041,44689,44742);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22041,44758,44856);

f_22041_44758_44855(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22041,40314,44867);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22041,40314,44867);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22041,40314,44867);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void InterpolatedStringExpression_FormatAndAlignment_Flow_03()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22041,44879,50634);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22041,45068,45302);

string 
source = @"
using System;

internal class Class
{
    public void M(bool a, string b, string b2, string b3, string c, string p)
    /*<bind>*/{
        p = $""{b2,20:D3}{b3,21:D4}{(a ? b : c)}"";
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22041,45316,50442);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [1] [2] [3] [4] [5]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (5)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'p')
              Value: 
                IParameterReferenceOperation: p (OperationKind.ParameterReference, Type: System.String) (Syntax: 'p')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'b2')
              Value: 
                IParameterReferenceOperation: b2 (OperationKind.ParameterReference, Type: System.String) (Syntax: 'b2')

            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '20')
              Value: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 20) (Syntax: '20')

            IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'b3')
              Value: 
                IParameterReferenceOperation: b3 (OperationKind.ParameterReference, Type: System.String) (Syntax: 'b3')

            IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '21')
              Value: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 21) (Syntax: '21')

        Jump if False (Regular) to Block[B3]
            IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'a')

        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 5 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'b')
              Value: 
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.String) (Syntax: 'b')

        Next (Regular) Block[B4]
    Block[B3] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 5 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c')
              Value: 
                IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: System.String) (Syntax: 'c')

        Next (Regular) Block[B4]
    Block[B4] - Block
        Predecessors: [B2] [B3]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'p = $""{b2,2 ... ? b : c)}"";')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.String) (Syntax: 'p = $""{b2,2 ...  ? b : c)}""')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.String, IsImplicit) (Syntax: 'p')
                  Right: 
                    IInterpolatedStringOperation (OperationKind.InterpolatedString, Type: System.String) (Syntax: '$""{b2,20:D3 ...  ? b : c)}""')
                      Parts(3):
                          IInterpolationOperation (OperationKind.Interpolation, Type: null) (Syntax: '{b2,20:D3}')
                            Expression: 
                              IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.String, IsImplicit) (Syntax: 'b2')
                            Alignment: 
                              IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, Constant: 20, IsImplicit) (Syntax: '20')
                            FormatString: 
                              ILiteralOperation (OperationKind.Literal, Type: System.String, Constant: ""D3"") (Syntax: ':D3')
                          IInterpolationOperation (OperationKind.Interpolation, Type: null) (Syntax: '{b3,21:D4}')
                            Expression: 
                              IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.String, IsImplicit) (Syntax: 'b3')
                            Alignment: 
                              IFlowCaptureReferenceOperation: 4 (OperationKind.FlowCaptureReference, Type: System.Int32, Constant: 21, IsImplicit) (Syntax: '21')
                            FormatString: 
                              ILiteralOperation (OperationKind.Literal, Type: System.String, Constant: ""D4"") (Syntax: ':D4')
                          IInterpolationOperation (OperationKind.Interpolation, Type: null) (Syntax: '{(a ? b : c)}')
                            Expression: 
                              IFlowCaptureReferenceOperation: 5 (OperationKind.FlowCaptureReference, Type: System.String, IsImplicit) (Syntax: 'a ? b : c')
                            Alignment: 
                              null
                            FormatString: 
                              null

        Next (Regular) Block[B5]
            Leaving: {R1}
}

Block[B5] - Exit
    Predecessors: [B4]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22041,50456,50509);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22041,50525,50623);

f_22041_50525_50622(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22041,44879,50634);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22041,44879,50634);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22041,44879,50634);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void InterpolatedStringExpression_NestedInterpolation_Flow()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22041,50646,55519);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22041,50833,51014);

string 
source = @"
using System;

internal class Class
{
    public void M(string a, int? b, int c)
    /*<bind>*/{
        a = $""{$""{b ?? c}""}"";
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22041,51028,55327);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
              Value: 
                IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.String) (Syntax: 'a')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'b')
                  Value: 
                    IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'b')

            Jump if True (Regular) to Block[B4]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'b')
                  Operand: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'b')
                Leaving: {R2}

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'b')
                  Value: 
                    IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsImplicit) (Syntax: 'b')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'b')
                      Arguments(0)

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B4] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c')
              Value: 
                IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'c')

        Next (Regular) Block[B5]
    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'a = $""{$""{b ?? c}""}"";')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.String) (Syntax: 'a = $""{$""{b ?? c}""}""')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.String, IsImplicit) (Syntax: 'a')
                  Right: 
                    IInterpolatedStringOperation (OperationKind.InterpolatedString, Type: System.String) (Syntax: '$""{$""{b ?? c}""}""')
                      Parts(1):
                          IInterpolationOperation (OperationKind.Interpolation, Type: null) (Syntax: '{$""{b ?? c}""}')
                            Expression: 
                              IInterpolatedStringOperation (OperationKind.InterpolatedString, Type: System.String) (Syntax: '$""{b ?? c}""')
                                Parts(1):
                                    IInterpolationOperation (OperationKind.Interpolation, Type: null) (Syntax: '{b ?? c}')
                                      Expression: 
                                        IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'b ?? c')
                                      Alignment: 
                                        null
                                      FormatString: 
                                        null
                            Alignment: 
                              null
                            FormatString: 
                              null

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22041,55341,55394);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22041,55410,55508);

f_22041_55410_55507(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22041,50646,55519);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22041,50646,55519);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22041,50646,55519);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void InterpolatedStringExpression_ConditionalCodeInAlignment_Flow()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22041,55531,59592);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22041,55725,55923);

string 
source = @"
using System;

internal class Class
{
    public void M(bool a, int b, int c, string d, string p)
    /*<bind>*/{
        p = $""{d,(a ? b : c)}"";
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22041,55937,59157);

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
        Statements (2)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'p')
              Value: 
                IParameterReferenceOperation: p (OperationKind.ParameterReference, Type: System.String) (Syntax: 'p')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'd')
              Value: 
                IParameterReferenceOperation: d (OperationKind.ParameterReference, Type: System.String) (Syntax: 'd')

        Jump if False (Regular) to Block[B3]
            IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Boolean, IsInvalid) (Syntax: 'a')

        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'b')
              Value: 
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Int32, IsInvalid) (Syntax: 'b')

        Next (Regular) Block[B4]
    Block[B3] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'c')
              Value: 
                IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: System.Int32, IsInvalid) (Syntax: 'c')

        Next (Regular) Block[B4]
    Block[B4] - Block
        Predecessors: [B2] [B3]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: 'p = $""{d,(a ? b : c)}"";')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.String, IsInvalid) (Syntax: 'p = $""{d,(a ? b : c)}""')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.String, IsImplicit) (Syntax: 'p')
                  Right: 
                    IInterpolatedStringOperation (OperationKind.InterpolatedString, Type: System.String, IsInvalid) (Syntax: '$""{d,(a ? b : c)}""')
                      Parts(1):
                          IInterpolationOperation (OperationKind.Interpolation, Type: null, IsInvalid) (Syntax: '{d,(a ? b : c)}')
                            Expression: 
                              IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.String, IsImplicit) (Syntax: 'd')
                            Alignment: 
                              IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'a ? b : c')
                            FormatString: 
                              null

        Next (Regular) Block[B5]
            Leaving: {R1}
}

Block[B5] - Exit
    Predecessors: [B4]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22041,59171,59467);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22041_59374_59451(f_22041_59374_59431(ErrorCode.ERR_ConstantExpected, "(a ? b : c)"), 8, 18)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22041,59483,59581);

f_22041_59483_59580(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22041,55531,59592);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22041,55531,59592);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22041,55531,59592);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void InterpolatedStringExpression_ConditionalCodeInAlignment_Flow_02()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22041,59604,64543);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22041,59801,60010);

string 
source = @"
using System;

internal class Class
{
    public void M(bool a, string b, string c, string c2, string p)
    /*<bind>*/{
        p = $""{c2,(a ? b : c):D3}"";
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22041,60024,63796);

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
        Statements (2)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'p')
              Value: 
                IParameterReferenceOperation: p (OperationKind.ParameterReference, Type: System.String) (Syntax: 'p')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c2')
              Value: 
                IParameterReferenceOperation: c2 (OperationKind.ParameterReference, Type: System.String) (Syntax: 'c2')

        Jump if False (Regular) to Block[B3]
            IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'a')

        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'b')
              Value: 
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.String, IsInvalid) (Syntax: 'b')

        Next (Regular) Block[B4]
    Block[B3] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'c')
              Value: 
                IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: System.String, IsInvalid) (Syntax: 'c')

        Next (Regular) Block[B4]
    Block[B4] - Block
        Predecessors: [B2] [B3]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: 'p = $""{c2,( ...  : c):D3}"";')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.String, IsInvalid) (Syntax: 'p = $""{c2,( ... b : c):D3}""')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.String, IsImplicit) (Syntax: 'p')
                  Right: 
                    IInterpolatedStringOperation (OperationKind.InterpolatedString, Type: System.String, IsInvalid) (Syntax: '$""{c2,(a ? b : c):D3}""')
                      Parts(1):
                          IInterpolationOperation (OperationKind.Interpolation, Type: null, IsInvalid) (Syntax: '{c2,(a ? b : c):D3}')
                            Expression: 
                              IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.String, IsImplicit) (Syntax: 'c2')
                            Alignment: 
                              IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'a ? b : c')
                                Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                  (NoConversion)
                                Operand: 
                                  IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.String, IsInvalid, IsImplicit) (Syntax: 'a ? b : c')
                            FormatString: 
                              ILiteralOperation (OperationKind.Literal, Type: System.String, Constant: ""D3"") (Syntax: ':D3')

        Next (Regular) Block[B5]
            Leaving: {R1}
}

Block[B5] - Exit
    Predecessors: [B4]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22041,63810,64418);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22041_64037_64133(f_22041_64037_64113(f_22041_64037_64082(ErrorCode.ERR_NoImplicitConv, "b"), "string", "int"), 8, 24),
f_22041_64306_64402(f_22041_64306_64382(f_22041_64306_64351(ErrorCode.ERR_NoImplicitConv, "c"), "string", "int"), 8, 28)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22041,64434,64532);

f_22041_64434_64531(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22041,59604,64543);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22041,59604,64543);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22041,59604,64543);
}
		}

int
f_22041_1133_1261(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InterpolatedStringExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22041, 1133, 1261);
return 0;
}


int
f_22041_2244_2372(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InterpolatedStringExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22041, 2244, 2372);
return 0;
}


int
f_22041_3323_3451(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InterpolatedStringExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22041, 3323, 3451);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22041_4563_4611(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22041, 4563, 4611);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22041_4563_4631(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22041, 4563, 4631);
return return_v;
}


int
f_22041_4663_4791(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InterpolatedStringExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22041, 4663, 4791);
return 0;
}


int
f_22041_6629_6757(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InterpolatedStringExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22041, 6629, 6757);
return 0;
}


int
f_22041_9797_9925(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InterpolatedStringExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22041, 9797, 9925);
return 0;
}


int
f_22041_11732_11860(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InterpolatedStringExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22041, 11732, 11860);
return 0;
}


int
f_22041_15175_15303(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InterpolatedStringExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22041, 15175, 15303);
return 0;
}


int
f_22041_17967_18095(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InterpolatedStringExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22041, 17967, 18095);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22041_20298_20346(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22041, 20298, 20346);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22041_20298_20366(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22041, 20298, 20366);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22041_20298_20386(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22041, 20298, 20386);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22041_20597_20644(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22041, 20597, 20644);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22041_20597_20675(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22041, 20597, 20675);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22041_20597_20695(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22041, 20597, 20695);
return return_v;
}


int
f_22041_20727_20855(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InterpolatedStringExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22041, 20727, 20855);
return 0;
}


int
f_22041_22137_22234(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22041, 22137, 22234);
return 0;
}


int
f_22041_23919_24016(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22041, 23919, 24016);
return 0;
}


int
f_22041_27258_27355(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22041, 27258, 27355);
return 0;
}


int
f_22041_31075_31172(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22041, 31075, 31172);
return 0;
}


int
f_22041_36648_36745(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22041, 36648, 36745);
return 0;
}


int
f_22041_40193_40290(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22041, 40193, 40290);
return 0;
}


int
f_22041_44758_44855(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22041, 44758, 44855);
return 0;
}


int
f_22041_50525_50622(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22041, 50525, 50622);
return 0;
}


int
f_22041_55410_55507(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22041, 55410, 55507);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22041_59374_59431(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22041, 59374, 59431);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22041_59374_59451(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22041, 59374, 59451);
return return_v;
}


int
f_22041_59483_59580(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22041, 59483, 59580);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22041_64037_64082(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22041, 64037, 64082);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22041_64037_64113(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22041, 64037, 64113);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22041_64037_64133(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22041, 64037, 64133);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22041_64306_64351(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22041, 64306, 64351);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22041_64306_64382(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22041, 64306, 64382);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22041_64306_64402(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22041, 64306, 64402);
return return_v;
}


int
f_22041_64434_64531(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22041, 64434, 64531);
return 0;
}

}
}
