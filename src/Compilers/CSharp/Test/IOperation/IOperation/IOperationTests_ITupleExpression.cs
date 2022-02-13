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
        [Fact, WorkItem(10856, "https://github.com/dotnet/roslyn/issues/10856")]
        public void TupleExpression_NoConversions()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22070,501,1488);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,704,880);

string 
source = @"
using System;

class C
{
    static void Main()
    {
        (int, int) t = /*<bind>*/(1, 2)/*</bind>*/;
        Console.WriteLine(t);
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,894,1278);

string 
expectedOperationTree = @"
ITupleOperation (OperationKind.Tuple, Type: (System.Int32, System.Int32)) (Syntax: '(1, 2)')
  NaturalType: (System.Int32, System.Int32)
  Elements(2):
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,1292,1345);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,1361,1477);

f_22070_1361_1476(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22070,501,1488);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22070,501,1488);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22070,501,1488);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(10856, "https://github.com/dotnet/roslyn/issues/10856")]
        public void TupleExpression_NoConversions_ParentVariableDeclaration()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22070,1500,3200);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,1729,1905);

string 
source = @"
using System;

class C
{
    static void Main()
    {
        /*<bind>*/(int, int) t = (1, 2);/*</bind>*/
        Console.WriteLine(t);
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,1919,2980);

string 
expectedOperationTree = @"
IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null) (Syntax: '(int, int) t = (1, 2);')
  IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: '(int, int) t = (1, 2)')
    Declarators:
        IVariableDeclaratorOperation (Symbol: (System.Int32, System.Int32) t) (OperationKind.VariableDeclarator, Type: null) (Syntax: 't = (1, 2)')
          Initializer: 
            IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= (1, 2)')
              ITupleOperation (OperationKind.Tuple, Type: (System.Int32, System.Int32)) (Syntax: '(1, 2)')
                NaturalType: (System.Int32, System.Int32)
                Elements(2):
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
    Initializer: 
      null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,2994,3047);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,3063,3189);

f_22070_3063_3188(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22070,1500,3200);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22070,1500,3200);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22070,1500,3200);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(10856, "https://github.com/dotnet/roslyn/issues/10856")]
        public void TupleExpression_ImplicitConversions()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22070,3212,4847);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,3421,3599);

string 
source = @"
using System;

class C
{
    static void Main()
    {
        (uint, uint) t = /*<bind>*/(1, 2)/*</bind>*/;
        Console.WriteLine(t);
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,3613,4637);

string 
expectedOperationTree = @"
ITupleOperation (OperationKind.Tuple, Type: (System.UInt32, System.UInt32)) (Syntax: '(1, 2)')
  NaturalType: (System.Int32, System.Int32)
  Elements(2):
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.UInt32, Constant: 1, IsImplicit) (Syntax: '1')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.UInt32, Constant: 2, IsImplicit) (Syntax: '2')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,4651,4704);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,4720,4836);

f_22070_4720_4835(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22070,3212,4847);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22070,3212,4847);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22070,3212,4847);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(10856, "https://github.com/dotnet/roslyn/issues/10856")]
        public void TupleExpression_ImplicitConversions_ParentVariableDeclaration()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22070,4859,7297);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,5094,5272);

string 
source = @"
using System;

class C
{
    static void Main()
    {
        /*<bind>*/(uint, uint) t = (1, 2);/*</bind>*/
        Console.WriteLine(t);
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,5286,7077);

string 
expectedOperationTree = @"
IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null) (Syntax: '(uint, uint) t = (1, 2);')
  IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: '(uint, uint) t = (1, 2)')
    Declarators:
        IVariableDeclaratorOperation (Symbol: (System.UInt32, System.UInt32) t) (OperationKind.VariableDeclarator, Type: null) (Syntax: 't = (1, 2)')
          Initializer: 
            IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= (1, 2)')
              ITupleOperation (OperationKind.Tuple, Type: (System.UInt32, System.UInt32)) (Syntax: '(1, 2)')
                NaturalType: (System.Int32, System.Int32)
                Elements(2):
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.UInt32, Constant: 1, IsImplicit) (Syntax: '1')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                      Operand: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.UInt32, Constant: 2, IsImplicit) (Syntax: '2')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                      Operand: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
    Initializer: 
      null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,7091,7144);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,7160,7286);

f_22070_7160_7285(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22070,4859,7297);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22070,4859,7297);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22070,4859,7297);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(10856, "https://github.com/dotnet/roslyn/issues/10856")]
        public void TupleExpression_ImplicitConversionsWithTypedExpression_01()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22070,7309,8990);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,7540,7758);

string 
source = @"
using System;

class C
{
    static void Main()
    {
        int a = 1;
        int b = 2;
        (long, long) t = /*<bind>*/(a, b)/*</bind>*/;
        Console.WriteLine(t);
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,7772,8780);

string 
expectedOperationTree = @"
ITupleOperation (OperationKind.Tuple, Type: (System.Int64 a, System.Int64 b)) (Syntax: '(a, b)')
  NaturalType: (System.Int32 a, System.Int32 b)
  Elements(2):
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int64, IsImplicit) (Syntax: 'a')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          ILocalReferenceOperation: a (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'a')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int64, IsImplicit) (Syntax: 'b')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          ILocalReferenceOperation: b (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'b')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,8794,8847);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,8863,8979);

f_22070_8863_8978(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22070,7309,8990);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22070,7309,8990);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22070,7309,8990);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(10856, "https://github.com/dotnet/roslyn/issues/10856")]
        public void TupleExpression_ImplicitConversionsWithTypedExpression_02()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22070,9002,11161);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,9233,9451);

string 
source = @"
using System;

class C
{
    static void Main()
    {
        int a = 1;
        int b = 2;
        (long, long) t /*<bind>*/= (a, b)/*</bind>*/;
        Console.WriteLine(t);
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,9465,10949);

string 
expectedOperationTree = @"
IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= (a, b)')
  IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: (System.Int64, System.Int64), IsImplicit) (Syntax: '(a, b)')
    Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
    Operand: 
      ITupleOperation (OperationKind.Tuple, Type: (System.Int64 a, System.Int64 b)) (Syntax: '(a, b)')
        NaturalType: (System.Int32 a, System.Int32 b)
        Elements(2):
            IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int64, IsImplicit) (Syntax: 'a')
              Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
              Operand: 
                ILocalReferenceOperation: a (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'a')
            IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int64, IsImplicit) (Syntax: 'b')
              Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
              Operand: 
                ILocalReferenceOperation: b (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'b')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,10963,11016);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,11032,11150);

f_22070_11032_11149(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22070,9002,11161);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22070,9002,11161);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22070,9002,11161);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(10856, "https://github.com/dotnet/roslyn/issues/10856")]
        public void TupleExpression_ImplicitConversionsWithTypedExpression_03()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22070,11173,12982);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,11404,11626);

string 
source = @"
using System;

class C
{
    static void Main()
    {
        int a = 1;
        int b = 2;
        (long a, long b) t /*<bind>*/= (a, b)/*</bind>*/;
        Console.WriteLine(t);
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,11640,12770);

string 
expectedOperationTree = @"
IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= (a, b)')
  ITupleOperation (OperationKind.Tuple, Type: (System.Int64 a, System.Int64 b)) (Syntax: '(a, b)')
    NaturalType: (System.Int32 a, System.Int32 b)
    Elements(2):
        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int64, IsImplicit) (Syntax: 'a')
          Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
          Operand: 
            ILocalReferenceOperation: a (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'a')
        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int64, IsImplicit) (Syntax: 'b')
          Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
          Operand: 
            ILocalReferenceOperation: b (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'b')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,12784,12837);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,12853,12971);

f_22070_12853_12970(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22070,11173,12982);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22070,11173,12982);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22070,11173,12982);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(10856, "https://github.com/dotnet/roslyn/issues/10856")]
        public void TupleExpression_ImplicitConversionsWithTypedExpression_WithParentDeclaration()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22070,12994,15859);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,13244,13462);

string 
source = @"
using System;

class C
{
    static void Main()
    {
        int a = 1;
        int b = 2;
        /*<bind>*/(long, long) t = (a, b);/*</bind>*/
        Console.WriteLine(t);
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,13476,15639);

string 
expectedOperationTree = @"
IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null) (Syntax: '(long, long) t = (a, b);')
  IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: '(long, long) t = (a, b)')
    Declarators:
        IVariableDeclaratorOperation (Symbol: (System.Int64, System.Int64) t) (OperationKind.VariableDeclarator, Type: null) (Syntax: 't = (a, b)')
          Initializer: 
            IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= (a, b)')
              IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: (System.Int64, System.Int64), IsImplicit) (Syntax: '(a, b)')
                Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                Operand: 
                  ITupleOperation (OperationKind.Tuple, Type: (System.Int64 a, System.Int64 b)) (Syntax: '(a, b)')
                    NaturalType: (System.Int32 a, System.Int32 b)
                    Elements(2):
                        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int64, IsImplicit) (Syntax: 'a')
                          Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                          Operand: 
                            ILocalReferenceOperation: a (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'a')
                        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int64, IsImplicit) (Syntax: 'b')
                          Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                          Operand: 
                            ILocalReferenceOperation: b (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'b')
    Initializer: 
      null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,15653,15706);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,15722,15848);

f_22070_15722_15847(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22070,12994,15859);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22070,12994,15859);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22070,12994,15859);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(10856, "https://github.com/dotnet/roslyn/issues/10856")]
        public void TupleExpression_ImplicitConversionFromNull()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22070,15871,17500);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,16087,16270);

string 
source = @"
using System;

class C
{
    static void Main()
    {
        (uint, string) t = /*<bind>*/(1, null)/*</bind>*/;
        Console.WriteLine(t);
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,16284,17290);

string 
expectedOperationTree = @"
ITupleOperation (OperationKind.Tuple, Type: (System.UInt32, System.String)) (Syntax: '(1, null)')
  NaturalType: null
  Elements(2):
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.UInt32, Constant: 1, IsImplicit) (Syntax: '1')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.String, Constant: null, IsImplicit) (Syntax: 'null')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,17304,17357);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,17373,17489);

f_22070_17373_17488(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22070,15871,17500);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22070,15871,17500);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22070,15871,17500);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(10856, "https://github.com/dotnet/roslyn/issues/10856")]
        public void TupleExpression_ImplicitConversionFromNull_ParentVariableDeclaration()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22070,17512,19957);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,17754,17937);

string 
source = @"
using System;

class C
{
    static void Main()
    {
        /*<bind>*/(uint, string) t = (1, null);/*</bind>*/
        Console.WriteLine(t);
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,17951,19737);

string 
expectedOperationTree = @"
IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null) (Syntax: '(uint, stri ...  (1, null);')
  IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: '(uint, stri ... = (1, null)')
    Declarators:
        IVariableDeclaratorOperation (Symbol: (System.UInt32, System.String) t) (OperationKind.VariableDeclarator, Type: null) (Syntax: 't = (1, null)')
          Initializer: 
            IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= (1, null)')
              ITupleOperation (OperationKind.Tuple, Type: (System.UInt32, System.String)) (Syntax: '(1, null)')
                NaturalType: null
                Elements(2):
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.UInt32, Constant: 1, IsImplicit) (Syntax: '1')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                      Operand: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.String, Constant: null, IsImplicit) (Syntax: 'null')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                      Operand: 
                        ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')
    Initializer: 
      null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,19751,19804);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,19820,19946);

f_22070_19820_19945(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22070,17512,19957);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22070,17512,19957);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22070,17512,19957);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(10856, "https://github.com/dotnet/roslyn/issues/10856")]
        public void TupleExpression_NamedElements()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22070,19969,20969);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,20172,20347);

string 
source = @"
using System;

class C
{
    static void Main()
    {
        var t = /*<bind>*/(A: 1, B: 2)/*</bind>*/;
        Console.WriteLine(t);
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,20361,20759);

string 
expectedOperationTree = @"
ITupleOperation (OperationKind.Tuple, Type: (System.Int32 A, System.Int32 B)) (Syntax: '(A: 1, B: 2)')
  NaturalType: (System.Int32 A, System.Int32 B)
  Elements(2):
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,20773,20826);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,20842,20958);

f_22070_20842_20957(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22070,19969,20969);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22070,19969,20969);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22070,19969,20969);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(10856, "https://github.com/dotnet/roslyn/issues/10856")]
        public void TupleExpression_NamedElements_ParentVariableDeclaration()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22070,20981,22708);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,21210,21385);

string 
source = @"
using System;

class C
{
    static void Main()
    {
        /*<bind>*/var t = (A: 1, B: 2);/*</bind>*/
        Console.WriteLine(t);
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,21399,22488);

string 
expectedOperationTree = @"
IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null) (Syntax: 'var t = (A: 1, B: 2);')
  IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'var t = (A: 1, B: 2)')
    Declarators:
        IVariableDeclaratorOperation (Symbol: (System.Int32 A, System.Int32 B) t) (OperationKind.VariableDeclarator, Type: null) (Syntax: 't = (A: 1, B: 2)')
          Initializer: 
            IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= (A: 1, B: 2)')
              ITupleOperation (OperationKind.Tuple, Type: (System.Int32 A, System.Int32 B)) (Syntax: '(A: 1, B: 2)')
                NaturalType: (System.Int32 A, System.Int32 B)
                Elements(2):
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
    Initializer: 
      null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,22502,22555);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,22571,22697);

f_22070_22571_22696(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22070,20981,22708);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22070,20981,22708);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22070,20981,22708);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(10856, "https://github.com/dotnet/roslyn/issues/10856")]
        public void TupleExpression_NamedElementsInTupleType()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22070,22720,23722);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,22934,23114);

string 
source = @"
using System;

class C
{
    static void Main()
    {
        (int A, int B) t = /*<bind>*/(1, 2)/*</bind>*/;
        Console.WriteLine(t);
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,23128,23512);

string 
expectedOperationTree = @"
ITupleOperation (OperationKind.Tuple, Type: (System.Int32, System.Int32)) (Syntax: '(1, 2)')
  NaturalType: (System.Int32, System.Int32)
  Elements(2):
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,23526,23579);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,23595,23711);

f_22070_23595_23710(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22070,22720,23722);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22070,22720,23722);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22070,22720,23722);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(10856, "https://github.com/dotnet/roslyn/issues/10856")]
        public void TupleExpression_NamedElementsInTupleType_ParentVariableDeclaration()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22070,23734,25833);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,23974,24154);

string 
source = @"
using System;

class C
{
    static void Main()
    {
        /*<bind>*/(int A, int B) t = (1, 2);/*</bind>*/
        Console.WriteLine(t);
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,24168,25613);

string 
expectedOperationTree = @"
IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null) (Syntax: '(int A, int ... t = (1, 2);')
  IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: '(int A, int ...  t = (1, 2)')
    Declarators:
        IVariableDeclaratorOperation (Symbol: (System.Int32 A, System.Int32 B) t) (OperationKind.VariableDeclarator, Type: null) (Syntax: 't = (1, 2)')
          Initializer: 
            IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= (1, 2)')
              IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: (System.Int32 A, System.Int32 B), IsImplicit) (Syntax: '(1, 2)')
                Conversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                Operand: 
                  ITupleOperation (OperationKind.Tuple, Type: (System.Int32, System.Int32)) (Syntax: '(1, 2)')
                    NaturalType: (System.Int32, System.Int32)
                    Elements(2):
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
    Initializer: 
      null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,25627,25680);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,25696,25822);

f_22070_25696_25821(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22070,23734,25833);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22070,23734,25833);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22070,23734,25833);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(10856, "https://github.com/dotnet/roslyn/issues/10856")]
        public void TupleExpression_NamedElementsAndImplicitConversions()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22070,25845,28266);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,26070,26260);

string 
source = @"
using System;

class C
{
    static void Main()
    {
        (short, string) t = /*<bind>*/(A: 1, B: null)/*</bind>*/;
        Console.WriteLine(t);
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,26274,27288);

string 
expectedOperationTree = @"
ITupleOperation (OperationKind.Tuple, Type: (System.Int16 A, System.String B)) (Syntax: '(A: 1, B: null)')
  NaturalType: null
  Elements(2):
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int16, Constant: 1, IsImplicit) (Syntax: '1')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.String, Constant: null, IsImplicit) (Syntax: 'null')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,27302,28123);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22070_27614_27730(f_22070_27614_27710(f_22070_27614_27672(ErrorCode.WRN_TupleLiteralNameMismatch, "A: 1"), "A", "(short, string)"), 8, 40),
f_22070_27988_28107(f_22070_27988_28087(f_22070_27988_28049(ErrorCode.WRN_TupleLiteralNameMismatch, "B: null"), "B", "(short, string)"), 8, 46)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,28139,28255);

f_22070_28139_28254(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22070,25845,28266);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22070,25845,28266);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22070,25845,28266);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(10856, "https://github.com/dotnet/roslyn/issues/10856")]
        public void TupleExpression_NamedElementsAndImplicitConversions_ParentVariableDeclaration()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22070,28278,31926);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,28529,28719);

string 
source = @"
using System;

class C
{
    static void Main()
    {
        /*<bind>*/(short, string) t = (A: 1, B: null);/*</bind>*/
        Console.WriteLine(t);
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,28733,30938);

string 
expectedOperationTree = @"
IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null) (Syntax: '(short, str ... , B: null);')
  IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: '(short, str ... 1, B: null)')
    Declarators:
        IVariableDeclaratorOperation (Symbol: (System.Int16, System.String) t) (OperationKind.VariableDeclarator, Type: null) (Syntax: 't = (A: 1, B: null)')
          Initializer: 
            IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= (A: 1, B: null)')
              IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: (System.Int16, System.String), IsImplicit) (Syntax: '(A: 1, B: null)')
                Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                Operand: 
                  ITupleOperation (OperationKind.Tuple, Type: (System.Int16 A, System.String B)) (Syntax: '(A: 1, B: null)')
                    NaturalType: null
                    Elements(2):
                        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int16, Constant: 1, IsImplicit) (Syntax: '1')
                          Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                          Operand: 
                            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
                        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.String, Constant: null, IsImplicit) (Syntax: 'null')
                          Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                          Operand: 
                            ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')
    Initializer: 
      null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,30952,31773);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22070_31264_31380(f_22070_31264_31360(f_22070_31264_31322(ErrorCode.WRN_TupleLiteralNameMismatch, "A: 1"), "A", "(short, string)"), 8, 40),
f_22070_31638_31757(f_22070_31638_31737(f_22070_31638_31699(ErrorCode.WRN_TupleLiteralNameMismatch, "B: null"), "B", "(short, string)"), 8, 46)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,31789,31915);

f_22070_31789_31914(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22070,28278,31926);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22070,28278,31926);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22070,28278,31926);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(10856, "https://github.com/dotnet/roslyn/issues/10856")]
        public void TupleExpression_UserDefinedConversionsForArguments()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22070,31938,34781);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,32162,32723);

string 
source = @"
using System;

class C
{
    private readonly int _x;
    public C(int x)
    {
        _x = x;
    }

    public static implicit operator C(int value)
    {
        return new C(value);
    }

    public static implicit operator short(C c)
    {
        return (short)c._x;
    }

    public static implicit operator string(C c)
    {
        return c._x.ToString();
    }

    public void M(C c1)
    {
        (short, string) t = /*<bind>*/(new C(0), c1)/*</bind>*/;
        Console.WriteLine(t);
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,32737,34571);

string 
expectedOperationTree = @"
ITupleOperation (OperationKind.Tuple, Type: (System.Int16, System.String c1)) (Syntax: '(new C(0), c1)')
  NaturalType: (C, C c1)
  Elements(2):
      IConversionOperation (TryCast: False, Unchecked) (OperatorMethod: System.Int16 C.op_Implicit(C c)) (OperationKind.Conversion, Type: System.Int16, IsImplicit) (Syntax: 'new C(0)')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: True) (MethodSymbol: System.Int16 C.op_Implicit(C c))
        Operand: 
          IObjectCreationOperation (Constructor: C..ctor(System.Int32 x)) (OperationKind.ObjectCreation, Type: C) (Syntax: 'new C(0)')
            Arguments(1):
                IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: x) (OperationKind.Argument, Type: null) (Syntax: '0')
                  ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
                  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            Initializer: 
              null
      IConversionOperation (TryCast: False, Unchecked) (OperatorMethod: System.String C.op_Implicit(C c)) (OperationKind.Conversion, Type: System.String, IsImplicit) (Syntax: 'c1')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: True) (MethodSymbol: System.String C.op_Implicit(C c))
        Operand: 
          IParameterReferenceOperation: c1 (OperationKind.ParameterReference, Type: C) (Syntax: 'c1')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,34585,34638);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,34654,34770);

f_22070_34654_34769(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22070,31938,34781);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22070,31938,34781);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22070,31938,34781);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(10856, "https://github.com/dotnet/roslyn/issues/10856")]
        public void TupleExpression_UserDefinedConversionsForArguments_ParentVariableDeclaration()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22070,34793,38986);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,35043,35604);

string 
source = @"
using System;

class C
{
    private readonly int _x;
    public C(int x)
    {
        _x = x;
    }

    public static implicit operator C(int value)
    {
        return new C(value);
    }

    public static implicit operator short(C c)
    {
        return (short)c._x;
    }

    public static implicit operator string(C c)
    {
        return c._x.ToString();
    }

    public void M(C c1)
    {
        /*<bind>*/(short, string) t = (new C(0), c1);/*</bind>*/
        Console.WriteLine(t);
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,35618,38766);

string 
expectedOperationTree = @"
IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null) (Syntax: '(short, str ...  C(0), c1);')
  IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: '(short, str ... w C(0), c1)')
    Declarators:
        IVariableDeclaratorOperation (Symbol: (System.Int16, System.String) t) (OperationKind.VariableDeclarator, Type: null) (Syntax: 't = (new C(0), c1)')
          Initializer: 
            IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= (new C(0), c1)')
              IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: (System.Int16, System.String), IsImplicit) (Syntax: '(new C(0), c1)')
                Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                Operand: 
                  ITupleOperation (OperationKind.Tuple, Type: (System.Int16, System.String c1)) (Syntax: '(new C(0), c1)')
                    NaturalType: (C, C c1)
                    Elements(2):
                        IConversionOperation (TryCast: False, Unchecked) (OperatorMethod: System.Int16 C.op_Implicit(C c)) (OperationKind.Conversion, Type: System.Int16, IsImplicit) (Syntax: 'new C(0)')
                          Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: True) (MethodSymbol: System.Int16 C.op_Implicit(C c))
                          Operand: 
                            IObjectCreationOperation (Constructor: C..ctor(System.Int32 x)) (OperationKind.ObjectCreation, Type: C) (Syntax: 'new C(0)')
                              Arguments(1):
                                  IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: x) (OperationKind.Argument, Type: null) (Syntax: '0')
                                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
                                    InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                    OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                              Initializer: 
                                null
                        IConversionOperation (TryCast: False, Unchecked) (OperatorMethod: System.String C.op_Implicit(C c)) (OperationKind.Conversion, Type: System.String, IsImplicit) (Syntax: 'c1')
                          Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: True) (MethodSymbol: System.String C.op_Implicit(C c))
                          Operand: 
                            IParameterReferenceOperation: c1 (OperationKind.ParameterReference, Type: C) (Syntax: 'c1')
    Initializer: 
      null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,38780,38833);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,38849,38975);

f_22070_38849_38974(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22070,34793,38986);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22070,34793,38986);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22070,34793,38986);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(10856, "https://github.com/dotnet/roslyn/issues/10856")]
        public void TupleExpression_UserDefinedConversionFromTupleExpression()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22070,38998,40611);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,39228,39701);

string 
source = @"
using System;

class C
{
    private readonly int _x;
    public C(int x)
    {
        _x = x;
    }

    public static implicit operator C((int, string) x)
    {
        return new C(x.Item1);
    }

    public static implicit operator (int, string) (C c)
    {
        return (c._x, c._x.ToString());
    }

    public void M(C c1)
    {
        C t = /*<bind>*/(0, null)/*</bind>*/;
        Console.WriteLine(t);
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,39715,40401);

string 
expectedOperationTree = @"
ITupleOperation (OperationKind.Tuple, Type: (System.Int32, System.String)) (Syntax: '(0, null)')
  NaturalType: null
  Elements(2):
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.String, Constant: null, IsImplicit) (Syntax: 'null')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,40415,40468);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,40484,40600);

f_22070_40484_40599(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22070,38998,40611);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22070,38998,40611);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22070,38998,40611);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(10856, "https://github.com/dotnet/roslyn/issues/10856")]
        public void TupleExpression_UserDefinedConversionFromTupleExpression_ParentVariableDeclaration()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22070,40623,43422);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,40879,41352);

string 
source = @"
using System;

class C
{
    private readonly int _x;
    public C(int x)
    {
        _x = x;
    }

    public static implicit operator C((int, string) x)
    {
        return new C(x.Item1);
    }

    public static implicit operator (int, string) (C c)
    {
        return (c._x, c._x.ToString());
    }

    public void M(C c1)
    {
        /*<bind>*/C t = (0, null);/*</bind>*/
        Console.WriteLine(t);
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,41366,43202);

string 
expectedOperationTree = @"
IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null) (Syntax: 'C t = (0, null);')
  IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'C t = (0, null)')
    Declarators:
        IVariableDeclaratorOperation (Symbol: C t) (OperationKind.VariableDeclarator, Type: null) (Syntax: 't = (0, null)')
          Initializer: 
            IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= (0, null)')
              IConversionOperation (TryCast: False, Unchecked) (OperatorMethod: C C.op_Implicit((System.Int32, System.String) x)) (OperationKind.Conversion, Type: C, IsImplicit) (Syntax: '(0, null)')
                Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: True) (MethodSymbol: C C.op_Implicit((System.Int32, System.String) x))
                Operand: 
                  ITupleOperation (OperationKind.Tuple, Type: (System.Int32, System.String)) (Syntax: '(0, null)')
                    NaturalType: null
                    Elements(2):
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
                        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.String, Constant: null, IsImplicit) (Syntax: 'null')
                          Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                          Operand: 
                            ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')
    Initializer: 
      null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,43216,43269);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,43285,43411);

f_22070_43285_43410(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22070,40623,43422);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22070,40623,43422);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22070,40623,43422);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(10856, "https://github.com/dotnet/roslyn/issues/10856")]
        public void TupleExpression_UserDefinedConversionToTupleType()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22070,43434,44487);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,43656,44134);

string 
source = @"
using System;

class C
{
    private readonly int _x;
    public C(int x)
    {
        _x = x;
    }

    public static implicit operator C((int, string) x)
    {
        return new C(x.Item1);
    }

    public static implicit operator (int, string) (C c)
    {
        return (c._x, c._x.ToString());
    }

    public void M(C c1)
    {
        (int, string) t = /*<bind>*/c1/*</bind>*/;
        Console.WriteLine(t);
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,44148,44278);

string 
expectedOperationTree = @"
IParameterReferenceOperation: c1 (OperationKind.ParameterReference, Type: C) (Syntax: 'c1')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,44292,44345);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,44361,44476);

f_22070_44361_44475(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22070,43434,44487);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22070,43434,44487);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22070,43434,44487);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(10856, "https://github.com/dotnet/roslyn/issues/10856")]
        public void TupleExpression_UserDefinedConversionToTupleType_ParentVariableDeclaration()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22070,44499,46658);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,44747,45225);

string 
source = @"
using System;

class C
{
    private readonly int _x;
    public C(int x)
    {
        _x = x;
    }

    public static implicit operator C((int, string) x)
    {
        return new C(x.Item1);
    }

    public static implicit operator (int, string) (C c)
    {
        return (c._x, c._x.ToString());
    }

    public void M(C c1)
    {
        /*<bind>*/(int, string) t = c1;/*</bind>*/
        Console.WriteLine(t);
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,45239,46438);

string 
expectedOperationTree = @"
IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null) (Syntax: '(int, string) t = c1;')
  IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: '(int, string) t = c1')
    Declarators:
        IVariableDeclaratorOperation (Symbol: (System.Int32, System.String) t) (OperationKind.VariableDeclarator, Type: null) (Syntax: 't = c1')
          Initializer: 
            IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= c1')
              IConversionOperation (TryCast: False, Unchecked) (OperatorMethod: (System.Int32, System.String) C.op_Implicit(C c)) (OperationKind.Conversion, Type: (System.Int32, System.String), IsImplicit) (Syntax: 'c1')
                Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: True) (MethodSymbol: (System.Int32, System.String) C.op_Implicit(C c))
                Operand: 
                  IParameterReferenceOperation: c1 (OperationKind.ParameterReference, Type: C) (Syntax: 'c1')
    Initializer: 
      null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,46452,46505);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,46521,46647);

f_22070_46521_46646(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22070,44499,46658);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22070,44499,46658);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22070,44499,46658);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(10856, "https://github.com/dotnet/roslyn/issues/10856")]
        public void TupleExpression_InvalidConversion()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22070,46670,50207);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,46877,47436);

string 
source = @"
using System;

class C
{
    private readonly int _x;
    public C(int x)
    {
        _x = x;
    }

    public static implicit operator C(int value)
    {
        return new C(value);
    }

    public static implicit operator int(C c)
    {
        return (short)c._x;
    }

    public static implicit operator string(C c)
    {
        return c._x.ToString();
    }

    public void M(C c1)
    {
        (short, string) t = /*<bind>*/(new C(0), c1)/*</bind>*/;
        Console.WriteLine(t);
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,47450,49701);

string 
expectedOperationTree = @"
ITupleOperation (OperationKind.Tuple, Type: (System.Int16, System.String c1), IsInvalid) (Syntax: '(new C(0), c1)')
  NaturalType: (C, C c1)
  Elements(2):
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int16, IsInvalid, IsImplicit) (Syntax: 'new C(0)')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          IConversionOperation (TryCast: False, Unchecked) (OperatorMethod: System.Int32 C.op_Implicit(C c)) (OperationKind.Conversion, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'new C(0)')
            Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: True) (MethodSymbol: System.Int32 C.op_Implicit(C c))
            Operand: 
              IObjectCreationOperation (Constructor: C..ctor(System.Int32 x)) (OperationKind.ObjectCreation, Type: C, IsInvalid) (Syntax: 'new C(0)')
                Arguments(1):
                    IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: x) (OperationKind.Argument, Type: null, IsInvalid) (Syntax: '0')
                      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0, IsInvalid) (Syntax: '0')
                      InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                      OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                Initializer: 
                  null
      IConversionOperation (TryCast: False, Unchecked) (OperatorMethod: System.String C.op_Implicit(C c)) (OperationKind.Conversion, Type: System.String, IsImplicit) (Syntax: 'c1')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: True) (MethodSymbol: System.String C.op_Implicit(C c))
        Operand: 
          IParameterReferenceOperation: c1 (OperationKind.ParameterReference, Type: C) (Syntax: 'c1')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,49715,50064);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22070_49947_50048(f_22070_49947_50027(f_22070_49947_49999(ErrorCode.ERR_NoImplicitConv, "new C(0)"), "C", "short"), 29, 40)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,50080,50196);

f_22070_50080_50195(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22070,46670,50207);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22070,46670,50207);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22070,46670,50207);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(10856, "https://github.com/dotnet/roslyn/issues/10856")]
        public void TupleExpression_InvalidConversion_ParentVariableDeclaration()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22070,50219,55215);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,50452,51011);

string 
source = @"
using System;

class C
{
    private readonly int _x;
    public C(int x)
    {
        _x = x;
    }

    public static implicit operator C(int value)
    {
        return new C(value);
    }

    public static implicit operator int(C c)
    {
        return (short)c._x;
    }

    public static implicit operator string(C c)
    {
        return c._x.ToString();
    }

    public void M(C c1)
    {
        /*<bind>*/(short, string) t = (new C(0), c1);/*</bind>*/
        Console.WriteLine(t);
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,51025,54699);

string 
expectedOperationTree = @"
IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsInvalid) (Syntax: '(short, str ...  C(0), c1);')
  IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null, IsInvalid) (Syntax: '(short, str ... w C(0), c1)')
    Declarators:
        IVariableDeclaratorOperation (Symbol: (System.Int16, System.String) t) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 't = (new C(0), c1)')
          Initializer: 
            IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '= (new C(0), c1)')
              IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: (System.Int16, System.String), IsInvalid, IsImplicit) (Syntax: '(new C(0), c1)')
                Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                Operand: 
                  ITupleOperation (OperationKind.Tuple, Type: (System.Int16, System.String c1), IsInvalid) (Syntax: '(new C(0), c1)')
                    NaturalType: (C, C c1)
                    Elements(2):
                        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int16, IsInvalid, IsImplicit) (Syntax: 'new C(0)')
                          Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                          Operand: 
                            IConversionOperation (TryCast: False, Unchecked) (OperatorMethod: System.Int32 C.op_Implicit(C c)) (OperationKind.Conversion, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'new C(0)')
                              Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: True) (MethodSymbol: System.Int32 C.op_Implicit(C c))
                              Operand: 
                                IObjectCreationOperation (Constructor: C..ctor(System.Int32 x)) (OperationKind.ObjectCreation, Type: C, IsInvalid) (Syntax: 'new C(0)')
                                  Arguments(1):
                                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: x) (OperationKind.Argument, Type: null, IsInvalid) (Syntax: '0')
                                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0, IsInvalid) (Syntax: '0')
                                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                  Initializer: 
                                    null
                        IConversionOperation (TryCast: False, Unchecked) (OperatorMethod: System.String C.op_Implicit(C c)) (OperationKind.Conversion, Type: System.String, IsImplicit) (Syntax: 'c1')
                          Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: True) (MethodSymbol: System.String C.op_Implicit(C c))
                          Operand: 
                            IParameterReferenceOperation: c1 (OperationKind.ParameterReference, Type: C) (Syntax: 'c1')
    Initializer: 
      null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,54713,55062);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22070_54945_55046(f_22070_54945_55025(f_22070_54945_54997(ErrorCode.ERR_NoImplicitConv, "new C(0)"), "C", "short"), 29, 40)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,55078,55204);

f_22070_55078_55203(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22070,50219,55215);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22070,50219,55215);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22070,50219,55215);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(10856, "https://github.com/dotnet/roslyn/issues/10856")]
        public void TupleExpression_Deconstruction()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22070,55227,58152);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,55431,55822);

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
    public void M()
    {
        /*<bind>*/var (x, y) = new Point(0, 1)/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,55836,57937);

string 
expectedOperationTree = @"
IDeconstructionAssignmentOperation (OperationKind.DeconstructionAssignment, Type: (System.Int32 x, System.Int32 y)) (Syntax: 'var (x, y)  ... Point(0, 1)')
  Left: 
    IDeclarationExpressionOperation (OperationKind.DeclarationExpression, Type: (System.Int32 x, System.Int32 y)) (Syntax: 'var (x, y)')
      ITupleOperation (OperationKind.Tuple, Type: (System.Int32 x, System.Int32 y)) (Syntax: '(x, y)')
        NaturalType: (System.Int32 x, System.Int32 y)
        Elements(2):
            ILocalReferenceOperation: x (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'x')
            ILocalReferenceOperation: y (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'y')
  Right: 
    IObjectCreationOperation (Constructor: Point..ctor(System.Int32 x, System.Int32 y)) (OperationKind.ObjectCreation, Type: Point) (Syntax: 'new Point(0, 1)')
      Arguments(2):
          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: x) (OperationKind.Argument, Type: null) (Syntax: '0')
            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: y) (OperationKind.Argument, Type: null) (Syntax: '1')
            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      Initializer: 
        null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,57951,58004);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,58020,58141);

f_22070_58020_58140(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22070,55227,58152);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22070,55227,58152);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22070,55227,58152);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(10856, "https://github.com/dotnet/roslyn/issues/10856")]
        public void TupleExpression_Deconstruction_ForEach()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22070,58164,62338);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,58376,58816);

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

    public void Deconstruct(out uint x, out uint y)
    {
        x = 0;
        y = 0;
    }
}

class Class1
{
    public void M()
    {
        /*<bind>*/foreach (var (x, y) in new Point[]{ new Point(0, 1) })
        {
        }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,58830,62119);

string 
expectedOperationTree = @"
IForEachLoopOperation (LoopKind.ForEach, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'foreach (va ... }')
  Locals: Local_1: System.UInt32 x
    Local_2: System.UInt32 y
  LoopControlVariable: 
    IDeclarationExpressionOperation (OperationKind.DeclarationExpression, Type: (System.UInt32 x, System.UInt32 y)) (Syntax: 'var (x, y)')
      ITupleOperation (OperationKind.Tuple, Type: (System.UInt32 x, System.UInt32 y)) (Syntax: '(x, y)')
        NaturalType: (System.UInt32 x, System.UInt32 y)
        Elements(2):
            ILocalReferenceOperation: x (IsDeclaration: True) (OperationKind.LocalReference, Type: System.UInt32) (Syntax: 'x')
            ILocalReferenceOperation: y (IsDeclaration: True) (OperationKind.LocalReference, Type: System.UInt32) (Syntax: 'y')
  Collection: 
    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Collections.IEnumerable, IsImplicit) (Syntax: 'new Point[] ... int(0, 1) }')
      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
      Operand: 
        IArrayCreationOperation (OperationKind.ArrayCreation, Type: Point[]) (Syntax: 'new Point[] ... int(0, 1) }')
          Dimension Sizes(1):
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1, IsImplicit) (Syntax: 'new Point[] ... int(0, 1) }')
          Initializer: 
            IArrayInitializerOperation (1 elements) (OperationKind.ArrayInitializer, Type: null) (Syntax: '{ new Point(0, 1) }')
              Element Values(1):
                  IObjectCreationOperation (Constructor: Point..ctor(System.Int32 x, System.Int32 y)) (OperationKind.ObjectCreation, Type: Point) (Syntax: 'new Point(0, 1)')
                    Arguments(2):
                        IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: x) (OperationKind.Argument, Type: null) (Syntax: '0')
                          ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
                          InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                          OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: y) (OperationKind.Argument, Type: null) (Syntax: '1')
                          ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
                          InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                          OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    Initializer: 
                      null
  Body: 
    IBlockOperation (0 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
  NextVariables(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,62133,62186);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,62202,62327);

f_22070_62202_62326(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22070,58164,62338);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22070,58164,62338);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22070,58164,62338);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(10856, "https://github.com/dotnet/roslyn/issues/10856")]
        public void TupleExpression_DeconstructionWithConversion()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22070,62350,65413);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,62568,62967);

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

    public void Deconstruct(out uint x, out uint y)
    {
        x = 0;
        y = 0;
    }
}

class Class1
{
    public void M()
    {
        /*<bind>*/(uint x, uint y) = new Point(0, 1)/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,62981,65198);

string 
expectedOperationTree = @"
IDeconstructionAssignmentOperation (OperationKind.DeconstructionAssignment, Type: (System.UInt32 x, System.UInt32 y)) (Syntax: '(uint x, ui ... Point(0, 1)')
  Left: 
    ITupleOperation (OperationKind.Tuple, Type: (System.UInt32 x, System.UInt32 y)) (Syntax: '(uint x, uint y)')
      NaturalType: (System.UInt32 x, System.UInt32 y)
      Elements(2):
          IDeclarationExpressionOperation (OperationKind.DeclarationExpression, Type: System.UInt32) (Syntax: 'uint x')
            ILocalReferenceOperation: x (IsDeclaration: True) (OperationKind.LocalReference, Type: System.UInt32) (Syntax: 'x')
          IDeclarationExpressionOperation (OperationKind.DeclarationExpression, Type: System.UInt32) (Syntax: 'uint y')
            ILocalReferenceOperation: y (IsDeclaration: True) (OperationKind.LocalReference, Type: System.UInt32) (Syntax: 'y')
  Right: 
    IObjectCreationOperation (Constructor: Point..ctor(System.Int32 x, System.Int32 y)) (OperationKind.ObjectCreation, Type: Point) (Syntax: 'new Point(0, 1)')
      Arguments(2):
          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: x) (OperationKind.Argument, Type: null) (Syntax: '0')
            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: y) (OperationKind.Argument, Type: null) (Syntax: '1')
            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      Initializer: 
        null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,65212,65265);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,65281,65402);

f_22070_65281_65401(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22070,62350,65413);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22070,62350,65413);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22070,62350,65413);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ExplicitConversionOfANestedTuple_01()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22070,65425,69329);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,65568,65772);

string 
source = @"
using System;

class C
{
    static void Main()
    {
        var t = /*<bind>*/((int, (long c, int d)))(1, (a: 2, b: 3))/*</bind>*/;
        Console.WriteLine(t);
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,65786,68295);

string 
expectedOperationTree = @"
IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: (System.Int32, (System.Int64 c, System.Int32 d))) (Syntax: '((int, (lon ... : 2, b: 3))')
  Conversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
  Operand: 
    ITupleOperation (OperationKind.Tuple, Type: (System.Int32, (System.Int64 c, System.Int32 d))) (Syntax: '(1, (a: 2, b: 3))')
      NaturalType: (System.Int32, (System.Int32 a, System.Int32 b))
      Elements(2):
          IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32, Constant: 1, IsImplicit) (Syntax: '1')
            Conversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            Operand: 
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
          IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: (System.Int64 c, System.Int32 d), IsImplicit) (Syntax: '(a: 2, b: 3)')
            Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            Operand: 
              ITupleOperation (OperationKind.Tuple, Type: (System.Int64 a, System.Int32 b)) (Syntax: '(a: 2, b: 3)')
                NaturalType: (System.Int32 a, System.Int32 b)
                Elements(2):
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int64, Constant: 2, IsImplicit) (Syntax: '2')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                      Operand: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32, Constant: 3, IsImplicit) (Syntax: '3')
                      Conversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                      Operand: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,68309,69187);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22070_68651_68767(f_22070_68651_68747(f_22070_68651_68709(ErrorCode.WRN_TupleLiteralNameMismatch, "a: 2"), "a", "(long c, int d)"), 8, 56),
f_22070_69055_69171(f_22070_69055_69151(f_22070_69055_69113(ErrorCode.WRN_TupleLiteralNameMismatch, "b: 3"), "b", "(long c, int d)"), 8, 62)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,69203,69318);

f_22070_69203_69317(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22070,65425,69329);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22070,65425,69329);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22070,65425,69329);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void TupleFlow_01()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22070,69341,72602);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,69487,69619);

string 
source = @"
class C
{
    void M(bool b)
    /*<bind>*/{
        (int, int) t = (1, b ? 2 : 3);
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,69633,69955);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22070_69850_69939(f_22070_69850_69919(f_22070_69850_69900(ErrorCode.WRN_UnreferencedVarAssg, "t"), "t"), 6, 20)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,69971,72479);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [(System.Int32, System.Int32) t]
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
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: (System.Int32, System.Int32), IsImplicit) (Syntax: 't = (1, b ? 2 : 3)')
              Left: 
                ILocalReferenceOperation: t (IsDeclaration: True) (OperationKind.LocalReference, Type: (System.Int32, System.Int32), IsImplicit) (Syntax: 't = (1, b ? 2 : 3)')
              Right: 
                ITupleOperation (OperationKind.Tuple, Type: (System.Int32, System.Int32)) (Syntax: '(1, b ? 2 : 3)')
                  NaturalType: (System.Int32, System.Int32)
                  Elements(2):
                      IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, Constant: 1, IsImplicit) (Syntax: '1')
                      IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'b ? 2 : 3')

        Next (Regular) Block[B5]
            Leaving: {R1}
}

Block[B5] - Exit
    Predecessors: [B4]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,72493,72591);

f_22070_72493_72590(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22070,69341,72602);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22070,69341,72602);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22070,69341,72602);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void TupleFlow_02()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22070,72614,76599);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,72760,72890);

string 
source = @"
class C
{
    void M(bool b)
    /*<bind>*/{
        var t = (1, (2, b ? 2 : 3));
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,72904,73224);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22070_73119_73208(f_22070_73119_73188(f_22070_73119_73169(ErrorCode.WRN_UnreferencedVarAssg, "t"), "t"), 6, 13)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,73240,76476);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [(System.Int32, (System.Int32, System.Int32)) t]
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
            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '2')
              Value: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')

        Next (Regular) Block[B4]
    Block[B3] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '3')
              Value: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')

        Next (Regular) Block[B4]
    Block[B4] - Block
        Predecessors: [B2] [B3]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: (System.Int32, (System.Int32, System.Int32)), IsImplicit) (Syntax: 't = (1, (2, b ? 2 : 3))')
              Left: 
                ILocalReferenceOperation: t (IsDeclaration: True) (OperationKind.LocalReference, Type: (System.Int32, (System.Int32, System.Int32)), IsImplicit) (Syntax: 't = (1, (2, b ? 2 : 3))')
              Right: 
                ITupleOperation (OperationKind.Tuple, Type: (System.Int32, (System.Int32, System.Int32))) (Syntax: '(1, (2, b ? 2 : 3))')
                  NaturalType: (System.Int32, (System.Int32, System.Int32))
                  Elements(2):
                      IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, Constant: 1, IsImplicit) (Syntax: '1')
                      ITupleOperation (OperationKind.Tuple, Type: (System.Int32, System.Int32)) (Syntax: '(2, b ? 2 : 3)')
                        NaturalType: (System.Int32, System.Int32)
                        Elements(2):
                            IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32, Constant: 2, IsImplicit) (Syntax: '2')
                            IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'b ? 2 : 3')

        Next (Regular) Block[B5]
            Leaving: {R1}
}

Block[B5] - Exit
    Predecessors: [B4]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,76490,76588);

f_22070_76490_76587(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22070,72614,76599);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22070,72614,76599);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22070,72614,76599);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void TupleFlow_03()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22070,76611,80545);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,76757,76913);

string 
source = @"
class C
{
    void M(bool b)
    /*<bind>*/{
        M2((1, b ? 1 : 2));
    }/*</bind>*/

    void M2((int, int) arg) { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,76927,76980);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,76996,80422);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'M2')
              Value: 
                IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C, IsImplicit) (Syntax: 'M2')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '1')
              Value: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

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
            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '2')
              Value: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')

        Next (Regular) Block[B4]
    Block[B4] - Block
        Predecessors: [B2] [B3]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'M2((1, b ? 1 : 2));')
              Expression: 
                IInvocationOperation ( void C.M2((System.Int32, System.Int32) arg)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'M2((1, b ? 1 : 2))')
                  Instance Receiver: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'M2')
                  Arguments(1):
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: arg) (OperationKind.Argument, Type: null) (Syntax: '(1, b ? 1 : 2)')
                        ITupleOperation (OperationKind.Tuple, Type: (System.Int32, System.Int32)) (Syntax: '(1, b ? 1 : 2)')
                          NaturalType: (System.Int32, System.Int32)
                          Elements(2):
                              IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32, Constant: 1, IsImplicit) (Syntax: '1')
                              IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'b ? 1 : 2')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

        Next (Regular) Block[B5]
            Leaving: {R1}
}

Block[B5] - Exit
    Predecessors: [B4]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,80436,80534);

f_22070_80436_80533(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22070,76611,80545);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22070,76611,80545);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22070,76611,80545);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void TupleFlow_04()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22070,80557,84640);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,80703,80893);

string 
source = @"
class C
{
    void M(bool b, int i1, int i2, int i3)
    /*<bind>*/{
        (i1, b ? i2 : i3) = (1, 2);
    }/*</bind>*/

    void M2((int, int) arg) { }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,80907,81235);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22070_81140_81219(f_22070_81140_81199(ErrorCode.ERR_AssgLvalueExpected, "b ? i2 : i3"), 6, 14)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,81251,84517);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i1')
              Value: 
                IParameterReferenceOperation: i1 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i1')

        Jump if False (Regular) to Block[B3]
            IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean, IsInvalid) (Syntax: 'b')

        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'i2')
              Value: 
                IParameterReferenceOperation: i2 (OperationKind.ParameterReference, Type: System.Int32, IsInvalid) (Syntax: 'i2')

        Next (Regular) Block[B4]
    Block[B3] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'i3')
              Value: 
                IParameterReferenceOperation: i3 (OperationKind.ParameterReference, Type: System.Int32, IsInvalid) (Syntax: 'i3')

        Next (Regular) Block[B4]
    Block[B4] - Block
        Predecessors: [B2] [B3]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: '(i1, b ? i2 ... ) = (1, 2);')
              Expression: 
                IDeconstructionAssignmentOperation (OperationKind.DeconstructionAssignment, Type: (System.Int32 i1, System.Int32), IsInvalid) (Syntax: '(i1, b ? i2 ... 3) = (1, 2)')
                  Left: 
                    ITupleOperation (OperationKind.Tuple, Type: (System.Int32 i1, System.Int32), IsInvalid) (Syntax: '(i1, b ? i2 : i3)')
                      NaturalType: (System.Int32 i1, System.Int32)
                      Elements(2):
                          IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'i1')
                          IInvalidOperation (OperationKind.Invalid, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'b ? i2 : i3')
                            Children(1):
                                IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'b ? i2 : i3')
                  Right: 
                    ITupleOperation (OperationKind.Tuple, Type: (System.Int32, System.Int32)) (Syntax: '(1, 2)')
                      NaturalType: (System.Int32, System.Int32)
                      Elements(2):
                          ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
                          ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')

        Next (Regular) Block[B5]
            Leaving: {R1}
}

Block[B5] - Exit
    Predecessors: [B4]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,84531,84629);

f_22070_84531_84628(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22070,80557,84640);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22070,80557,84640);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22070,80557,84640);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void TupleFlow_05()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22070,84652,88203);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,84798,84996);

string 
source = @"
class C
{
    void M(bool b, int i1, int i2, int i3)
    /*<bind>*/{
        (i1, b ? ref i2 : ref i3) = (1, 2);
    }/*</bind>*/

    void M2((int, int) arg) { }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,85010,85063);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,85079,88080);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i1')
              Value: 
                IParameterReferenceOperation: i1 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i1')

        Jump if False (Regular) to Block[B3]
            IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i2')
              Value: 
                IParameterReferenceOperation: i2 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i2')

        Next (Regular) Block[B4]
    Block[B3] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i3')
              Value: 
                IParameterReferenceOperation: i3 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i3')

        Next (Regular) Block[B4]
    Block[B4] - Block
        Predecessors: [B2] [B3]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: '(i1, b ? re ... ) = (1, 2);')
              Expression: 
                IDeconstructionAssignmentOperation (OperationKind.DeconstructionAssignment, Type: (System.Int32 i1, System.Int32)) (Syntax: '(i1, b ? re ... 3) = (1, 2)')
                  Left: 
                    ITupleOperation (OperationKind.Tuple, Type: (System.Int32 i1, System.Int32)) (Syntax: '(i1, b ? re ... 2 : ref i3)')
                      NaturalType: (System.Int32 i1, System.Int32)
                      Elements(2):
                          IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'i1')
                          IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'b ? ref i2 : ref i3')
                  Right: 
                    ITupleOperation (OperationKind.Tuple, Type: (System.Int32, System.Int32)) (Syntax: '(1, 2)')
                      NaturalType: (System.Int32, System.Int32)
                      Elements(2):
                          ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
                          ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')

        Next (Regular) Block[B5]
            Leaving: {R1}
}

Block[B5] - Exit
    Predecessors: [B4]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,88094,88192);

f_22070_88094_88191(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22070,84652,88203);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22070,84652,88203);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22070,84652,88203);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void TupleFlow_06()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22070,88215,91196);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,88361,88493);

string 
source = @"
class C
{
    void M(bool b)
    /*<bind>*/{
        (int, int) t = (b ? 2 : 3, 1);
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,88507,88829);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22070_88724_88813(f_22070_88724_88793(f_22070_88724_88774(ErrorCode.WRN_UnreferencedVarAssg, "t"), "t"), 6, 20)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,88845,91073);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [(System.Int32, System.Int32) t]
    CaptureIds: [0]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (0)
        Jump if False (Regular) to Block[B3]
            IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '2')
              Value: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')

        Next (Regular) Block[B4]
    Block[B3] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '3')
              Value: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')

        Next (Regular) Block[B4]
    Block[B4] - Block
        Predecessors: [B2] [B3]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: (System.Int32, System.Int32), IsImplicit) (Syntax: 't = (b ? 2 : 3, 1)')
              Left: 
                ILocalReferenceOperation: t (IsDeclaration: True) (OperationKind.LocalReference, Type: (System.Int32, System.Int32), IsImplicit) (Syntax: 't = (b ? 2 : 3, 1)')
              Right: 
                ITupleOperation (OperationKind.Tuple, Type: (System.Int32, System.Int32)) (Syntax: '(b ? 2 : 3, 1)')
                  NaturalType: (System.Int32, System.Int32)
                  Elements(2):
                      IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'b ? 2 : 3')
                      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

        Next (Regular) Block[B5]
            Leaving: {R1}
}

Block[B5] - Exit
    Predecessors: [B4]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,91087,91185);

f_22070_91087_91184(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22070,88215,91196);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22070,88215,91196);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22070,88215,91196);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void TupleFlow_07()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22070,91208,96317);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,91354,91543);

string 
source = @"
class C
{
    void M(bool b, int i1, int i2, int i3, int i4, int i5, int i6)
    /*<bind>*/{
        (b ? (i1, i2) : (i3, i4)) = (i5, i6);
    }/*</bind>*/
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,91557,91907);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22070_91800_91891(f_22070_91800_91871(ErrorCode.ERR_AssgLvalueExpected, "b ? (i1, i2) : (i3, i4)"), 6, 10)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,91923,96194);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (0)
        Jump if False (Regular) to Block[B3]
            IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean, IsInvalid) (Syntax: 'b')

        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: '(i1, i2)')
              Value: 
                IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: (System.Int32, System.Int32), IsInvalid, IsImplicit) (Syntax: '(i1, i2)')
                  Conversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    (Identity)
                  Operand: 
                    ITupleOperation (OperationKind.Tuple, Type: (System.Int32 i1, System.Int32 i2), IsInvalid) (Syntax: '(i1, i2)')
                      NaturalType: (System.Int32 i1, System.Int32 i2)
                      Elements(2):
                          IParameterReferenceOperation: i1 (OperationKind.ParameterReference, Type: System.Int32, IsInvalid) (Syntax: 'i1')
                          IParameterReferenceOperation: i2 (OperationKind.ParameterReference, Type: System.Int32, IsInvalid) (Syntax: 'i2')

        Next (Regular) Block[B4]
    Block[B3] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: '(i3, i4)')
              Value: 
                IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: (System.Int32, System.Int32), IsInvalid, IsImplicit) (Syntax: '(i3, i4)')
                  Conversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    (Identity)
                  Operand: 
                    ITupleOperation (OperationKind.Tuple, Type: (System.Int32 i3, System.Int32 i4), IsInvalid) (Syntax: '(i3, i4)')
                      NaturalType: (System.Int32 i3, System.Int32 i4)
                      Elements(2):
                          IParameterReferenceOperation: i3 (OperationKind.ParameterReference, Type: System.Int32, IsInvalid) (Syntax: 'i3')
                          IParameterReferenceOperation: i4 (OperationKind.ParameterReference, Type: System.Int32, IsInvalid) (Syntax: 'i4')

        Next (Regular) Block[B4]
    Block[B4] - Block
        Predecessors: [B2] [B3]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: '(b ? (i1, i ... = (i5, i6);')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: (System.Int32, System.Int32), IsInvalid) (Syntax: '(b ? (i1, i ...  = (i5, i6)')
                  Left: 
                    IInvalidOperation (OperationKind.Invalid, Type: (System.Int32, System.Int32), IsInvalid, IsImplicit) (Syntax: 'b ? (i1, i2) : (i3, i4)')
                      Children(1):
                          IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: (System.Int32, System.Int32), IsInvalid, IsImplicit) (Syntax: 'b ? (i1, i2) : (i3, i4)')
                  Right: 
                    ITupleOperation (OperationKind.Tuple, Type: (System.Int32 i5, System.Int32 i6)) (Syntax: '(i5, i6)')
                      NaturalType: (System.Int32 i5, System.Int32 i6)
                      Elements(2):
                          IParameterReferenceOperation: i5 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i5')
                          IParameterReferenceOperation: i6 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i6')

        Next (Regular) Block[B5]
            Leaving: {R1}
}

Block[B5] - Exit
    Predecessors: [B4]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,96208,96306);

f_22070_96208_96305(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22070,91208,96317);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22070,91208,96317);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22070,91208,96317);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void TupleFlow_08()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22070,96329,102963);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,96475,96630);

string 
source = @"
class C
{
    void M(bool b)
    /*<bind>*/{
        (b ? (var i1, var i2) : (var i3, var i4)) = (1, 2);
    }/*</bind>*/
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,96644,98072);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22070_96871_96960(f_22070_96871_96940(ErrorCode.ERR_DeclarationExpressionNotPermitted, "var i1"), 6, 15),
f_22070_97133_97222(f_22070_97133_97202(ErrorCode.ERR_DeclarationExpressionNotPermitted, "var i2"), 6, 23),
f_22070_97395_97484(f_22070_97395_97464(ErrorCode.ERR_DeclarationExpressionNotPermitted, "var i3"), 6, 34),
f_22070_97657_97746(f_22070_97657_97726(ErrorCode.ERR_DeclarationExpressionNotPermitted, "var i4"), 6, 42),
f_22070_97949_98056(f_22070_97949_98036(ErrorCode.ERR_AssgLvalueExpected, "b ? (var i1, var i2) : (var i3, var i4)"), 6, 10)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,98088,102840);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [var i1] [var i2] [var i3] [var i4]
    CaptureIds: [0]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (0)
        Jump if False (Regular) to Block[B3]
            IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean, IsInvalid) (Syntax: 'b')

        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: '(var i1, var i2)')
              Value: 
                IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: (var, var), IsInvalid, IsImplicit) (Syntax: '(var i1, var i2)')
                  Conversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    (Identity)
                  Operand: 
                    ITupleOperation (OperationKind.Tuple, Type: (var i1, var i2), IsInvalid) (Syntax: '(var i1, var i2)')
                      NaturalType: (var i1, var i2)
                      Elements(2):
                          IDeclarationExpressionOperation (OperationKind.DeclarationExpression, Type: var, IsInvalid) (Syntax: 'var i1')
                            ILocalReferenceOperation: i1 (IsDeclaration: True) (OperationKind.LocalReference, Type: var, IsInvalid) (Syntax: 'i1')
                          IDeclarationExpressionOperation (OperationKind.DeclarationExpression, Type: var, IsInvalid) (Syntax: 'var i2')
                            ILocalReferenceOperation: i2 (IsDeclaration: True) (OperationKind.LocalReference, Type: var, IsInvalid) (Syntax: 'i2')

        Next (Regular) Block[B4]
    Block[B3] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: '(var i3, var i4)')
              Value: 
                IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: (var, var), IsInvalid, IsImplicit) (Syntax: '(var i3, var i4)')
                  Conversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    (Identity)
                  Operand: 
                    ITupleOperation (OperationKind.Tuple, Type: (var i3, var i4), IsInvalid) (Syntax: '(var i3, var i4)')
                      NaturalType: (var i3, var i4)
                      Elements(2):
                          IDeclarationExpressionOperation (OperationKind.DeclarationExpression, Type: var, IsInvalid) (Syntax: 'var i3')
                            ILocalReferenceOperation: i3 (IsDeclaration: True) (OperationKind.LocalReference, Type: var, IsInvalid) (Syntax: 'i3')
                          IDeclarationExpressionOperation (OperationKind.DeclarationExpression, Type: var, IsInvalid) (Syntax: 'var i4')
                            ILocalReferenceOperation: i4 (IsDeclaration: True) (OperationKind.LocalReference, Type: var, IsInvalid) (Syntax: 'i4')

        Next (Regular) Block[B4]
    Block[B4] - Block
        Predecessors: [B2] [B3]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: '(b ? (var i ... ) = (1, 2);')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: (var, var), IsInvalid) (Syntax: '(b ? (var i ... )) = (1, 2)')
                  Left: 
                    IInvalidOperation (OperationKind.Invalid, Type: (var, var), IsInvalid, IsImplicit) (Syntax: 'b ? (var i1 ... i3, var i4)')
                      Children(1):
                          IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: (var, var), IsInvalid, IsImplicit) (Syntax: 'b ? (var i1 ... i3, var i4)')
                  Right: 
                    ITupleOperation (OperationKind.Tuple, Type: (System.Int32, System.Int32)) (Syntax: '(1, 2)')
                      NaturalType: (System.Int32, System.Int32)
                      Elements(2):
                          ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
                          ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')

        Next (Regular) Block[B5]
            Leaving: {R1}
}

Block[B5] - Exit
    Predecessors: [B4]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,102854,102952);

f_22070_102854_102951(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22070,96329,102963);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22070,96329,102963);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22070,96329,102963);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void TupleFlow_09()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22070,102975,105650);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,103168,103342);

string 
source = @"
class C
{
    void M(int i1, int i2, int i3, ((int, int), int) result)
    /*<bind>*/
    {
        result = ((i1, i2), i3);
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,103356,103409);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,103425,105527);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (1)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = ((i1, i2), i3);')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: ((System.Int32, System.Int32), System.Int32)) (Syntax: 'result = ((i1, i2), i3)')
              Left: 
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: ((System.Int32, System.Int32), System.Int32)) (Syntax: 'result')
              Right: 
                IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: ((System.Int32, System.Int32), System.Int32), IsImplicit) (Syntax: '((i1, i2), i3)')
                  Conversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    (Identity)
                  Operand: 
                    ITupleOperation (OperationKind.Tuple, Type: ((System.Int32 i1, System.Int32 i2), System.Int32 i3)) (Syntax: '((i1, i2), i3)')
                      NaturalType: ((System.Int32 i1, System.Int32 i2), System.Int32 i3)
                      Elements(2):
                          ITupleOperation (OperationKind.Tuple, Type: (System.Int32 i1, System.Int32 i2)) (Syntax: '(i1, i2)')
                            NaturalType: (System.Int32 i1, System.Int32 i2)
                            Elements(2):
                                IParameterReferenceOperation: i1 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i1')
                                IParameterReferenceOperation: i2 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i2')
                          IParameterReferenceOperation: i3 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i3')

    Next (Regular) Block[B2]
Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,105541,105639);

f_22070_105541_105638(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22070,102975,105650);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22070,102975,105650);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22070,102975,105650);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void TupleFlow_10()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22070,105662,111444);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,105888,106077);

string 
source = @"
class C
{
    void M(int i1, int i2, int? i3, int i4, ((int, int), int) result)
    /*<bind>*/
    {
        result = ((i1, i2), i3 ?? i4);
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,106091,106144);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,106160,111321);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'result')
              Value: 
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: ((System.Int32, System.Int32), System.Int32)) (Syntax: 'result')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i1')
              Value: 
                IParameterReferenceOperation: i1 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i1')

            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i2')
              Value: 
                IParameterReferenceOperation: i2 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i2')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [3]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i3')
                  Value: 
                    IParameterReferenceOperation: i3 (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'i3')

            Jump if True (Regular) to Block[B4]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'i3')
                  Operand: 
                    IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'i3')
                Leaving: {R2}

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i3')
                  Value: 
                    IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsImplicit) (Syntax: 'i3')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'i3')
                      Arguments(0)

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B4] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i4')
              Value: 
                IParameterReferenceOperation: i4 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i4')

        Next (Regular) Block[B5]
    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = (( ...  i3 ?? i4);')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: ((System.Int32, System.Int32), System.Int32)) (Syntax: 'result = (( ... , i3 ?? i4)')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: ((System.Int32, System.Int32), System.Int32), IsImplicit) (Syntax: 'result')
                  Right: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: ((System.Int32, System.Int32), System.Int32), IsImplicit) (Syntax: '((i1, i2), i3 ?? i4)')
                      Conversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (Identity)
                      Operand: 
                        ITupleOperation (OperationKind.Tuple, Type: ((System.Int32 i1, System.Int32 i2), System.Int32)) (Syntax: '((i1, i2), i3 ?? i4)')
                          NaturalType: ((System.Int32 i1, System.Int32 i2), System.Int32)
                          Elements(2):
                              ITupleOperation (OperationKind.Tuple, Type: (System.Int32 i1, System.Int32 i2)) (Syntax: '(i1, i2)')
                                NaturalType: (System.Int32 i1, System.Int32 i2)
                                Elements(2):
                                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'i1')
                                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'i2')
                              IFlowCaptureReferenceOperation: 4 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'i3 ?? i4')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,111335,111433);

f_22070_111335_111432(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22070,105662,111444);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22070,105662,111444);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22070,105662,111444);
}
		}

[Fact]
        public void UnexpectedTupleExpressionRecovery()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22070,111456,114651);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,111544,111669);

var 
source = @"
class C
{
    static void Main()
    {
        /*<bind>*/(var ((a,b), c), int d);/*</bind>*/
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,111685,112912);

var 
expectedDiagnostics = new[]
            {
f_22070_111978_112067(f_22070_111978_112047(ErrorCode.ERR_IllegalStatement, "(var ((a,b), c), int d)"), 6, 19),
f_22070_112255_112352(f_22070_112255_112332(ErrorCode.ERR_DeclarationExpressionNotPermitted, "var ((a,b), c)"), 6, 20),
f_22070_112540_112628(f_22070_112540_112608(ErrorCode.ERR_DeclarationExpressionNotPermitted, "int d"), 6, 36),
f_22070_112807_112896(f_22070_112807_112876(f_22070_112807_112857(ErrorCode.ERR_UseDefViolation, "int d"), "d"), 6, 36)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,112928,114513);

var 
expectedTree = @"
IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: '(var ((a,b), c), int d);')
  Expression:
    ITupleOperation (OperationKind.Tuple, Type: (((var a, var b), var c), System.Int32 d), IsInvalid) (Syntax: '(var ((a,b), c), int d)')
      NaturalType: (((var a, var b), var c), System.Int32 d)
      Elements(2):
          IDeclarationExpressionOperation (OperationKind.DeclarationExpression, Type: ((var a, var b), var c), IsInvalid) (Syntax: 'var ((a,b), c)')
            ITupleOperation (OperationKind.Tuple, Type: ((var a, var b), var c), IsInvalid) (Syntax: '((a,b), c)')
              NaturalType: null
              Elements(2):
                  ITupleOperation (OperationKind.Tuple, Type: (var a, var b), IsInvalid) (Syntax: '(a,b)')
                    NaturalType: null
                    Elements(2):
                        ILocalReferenceOperation: a (IsDeclaration: True) (OperationKind.LocalReference, Type: var, IsInvalid) (Syntax: 'a')
                        ILocalReferenceOperation: b (IsDeclaration: True) (OperationKind.LocalReference, Type: var, IsInvalid) (Syntax: 'b')
                  ILocalReferenceOperation: c (IsDeclaration: True) (OperationKind.LocalReference, Type: var, IsInvalid) (Syntax: 'c')
          IDeclarationExpressionOperation (OperationKind.DeclarationExpression, Type: System.Int32, IsInvalid) (Syntax: 'int d')
            ILocalReferenceOperation: d (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsInvalid) (Syntax: 'd')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22070,114529,114640);

f_22070_114529_114639(source, expectedTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22070,111456,114651);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22070,111456,114651);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22070,111456,114651);
}
		}

int
f_22070_1361_1476(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<TupleExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22070, 1361, 1476);
return 0;
}


int
f_22070_3063_3188(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<LocalDeclarationStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22070, 3063, 3188);
return 0;
}


int
f_22070_4720_4835(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<TupleExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22070, 4720, 4835);
return 0;
}


int
f_22070_7160_7285(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<LocalDeclarationStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22070, 7160, 7285);
return 0;
}


int
f_22070_8863_8978(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<TupleExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22070, 8863, 8978);
return 0;
}


int
f_22070_11032_11149(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<EqualsValueClauseSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22070, 11032, 11149);
return 0;
}


int
f_22070_12853_12970(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<EqualsValueClauseSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22070, 12853, 12970);
return 0;
}


int
f_22070_15722_15847(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<LocalDeclarationStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22070, 15722, 15847);
return 0;
}


int
f_22070_17373_17488(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<TupleExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22070, 17373, 17488);
return 0;
}


int
f_22070_19820_19945(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<LocalDeclarationStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22070, 19820, 19945);
return 0;
}


int
f_22070_20842_20957(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<TupleExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22070, 20842, 20957);
return 0;
}


int
f_22070_22571_22696(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<LocalDeclarationStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22070, 22571, 22696);
return 0;
}


int
f_22070_23595_23710(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<TupleExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22070, 23595, 23710);
return 0;
}


int
f_22070_25696_25821(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<LocalDeclarationStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22070, 25696, 25821);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22070_27614_27672(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22070, 27614, 27672);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22070_27614_27710(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22070, 27614, 27710);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22070_27614_27730(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22070, 27614, 27730);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22070_27988_28049(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22070, 27988, 28049);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22070_27988_28087(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22070, 27988, 28087);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22070_27988_28107(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22070, 27988, 28107);
return return_v;
}


int
f_22070_28139_28254(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<TupleExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22070, 28139, 28254);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22070_31264_31322(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22070, 31264, 31322);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22070_31264_31360(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22070, 31264, 31360);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22070_31264_31380(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22070, 31264, 31380);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22070_31638_31699(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22070, 31638, 31699);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22070_31638_31737(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22070, 31638, 31737);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22070_31638_31757(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22070, 31638, 31757);
return return_v;
}


int
f_22070_31789_31914(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<LocalDeclarationStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22070, 31789, 31914);
return 0;
}


int
f_22070_34654_34769(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<TupleExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22070, 34654, 34769);
return 0;
}


int
f_22070_38849_38974(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<LocalDeclarationStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22070, 38849, 38974);
return 0;
}


int
f_22070_40484_40599(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<TupleExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22070, 40484, 40599);
return 0;
}


int
f_22070_43285_43410(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<LocalDeclarationStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22070, 43285, 43410);
return 0;
}


int
f_22070_44361_44475(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<IdentifierNameSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22070, 44361, 44475);
return 0;
}


int
f_22070_46521_46646(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<LocalDeclarationStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22070, 46521, 46646);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22070_49947_49999(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22070, 49947, 49999);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22070_49947_50027(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22070, 49947, 50027);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22070_49947_50048(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22070, 49947, 50048);
return return_v;
}


int
f_22070_50080_50195(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<TupleExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22070, 50080, 50195);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22070_54945_54997(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22070, 54945, 54997);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22070_54945_55025(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22070, 54945, 55025);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22070_54945_55046(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22070, 54945, 55046);
return return_v;
}


int
f_22070_55078_55203(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<LocalDeclarationStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22070, 55078, 55203);
return 0;
}


int
f_22070_58020_58140(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<AssignmentExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22070, 58020, 58140);
return 0;
}


int
f_22070_62202_62326(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ForEachVariableStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22070, 62202, 62326);
return 0;
}


int
f_22070_65281_65401(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<AssignmentExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22070, 65281, 65401);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22070_68651_68709(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22070, 68651, 68709);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22070_68651_68747(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22070, 68651, 68747);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22070_68651_68767(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22070, 68651, 68767);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22070_69055_69113(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22070, 69055, 69113);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22070_69055_69151(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22070, 69055, 69151);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22070_69055_69171(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22070, 69055, 69171);
return return_v;
}


int
f_22070_69203_69317(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<CastExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22070, 69203, 69317);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22070_69850_69900(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22070, 69850, 69900);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22070_69850_69919(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22070, 69850, 69919);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22070_69850_69939(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22070, 69850, 69939);
return return_v;
}


int
f_22070_72493_72590(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22070, 72493, 72590);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22070_73119_73169(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22070, 73119, 73169);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22070_73119_73188(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22070, 73119, 73188);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22070_73119_73208(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22070, 73119, 73208);
return return_v;
}


int
f_22070_76490_76587(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22070, 76490, 76587);
return 0;
}


int
f_22070_80436_80533(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22070, 80436, 80533);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22070_81140_81199(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22070, 81140, 81199);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22070_81140_81219(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22070, 81140, 81219);
return return_v;
}


int
f_22070_84531_84628(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22070, 84531, 84628);
return 0;
}


int
f_22070_88094_88191(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22070, 88094, 88191);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22070_88724_88774(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22070, 88724, 88774);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22070_88724_88793(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22070, 88724, 88793);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22070_88724_88813(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22070, 88724, 88813);
return return_v;
}


int
f_22070_91087_91184(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22070, 91087, 91184);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22070_91800_91871(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22070, 91800, 91871);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22070_91800_91891(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22070, 91800, 91891);
return return_v;
}


int
f_22070_96208_96305(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22070, 96208, 96305);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22070_96871_96940(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22070, 96871, 96940);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22070_96871_96960(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22070, 96871, 96960);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22070_97133_97202(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22070, 97133, 97202);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22070_97133_97222(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22070, 97133, 97222);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22070_97395_97464(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22070, 97395, 97464);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22070_97395_97484(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22070, 97395, 97484);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22070_97657_97726(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22070, 97657, 97726);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22070_97657_97746(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22070, 97657, 97746);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22070_97949_98036(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22070, 97949, 98036);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22070_97949_98056(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22070, 97949, 98056);
return return_v;
}


int
f_22070_102854_102951(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22070, 102854, 102951);
return 0;
}


int
f_22070_105541_105638(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22070, 105541, 105638);
return 0;
}


int
f_22070_111335_111432(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22070, 111335, 111432);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22070_111978_112047(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22070, 111978, 112047);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22070_111978_112067(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22070, 111978, 112067);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22070_112255_112332(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22070, 112255, 112332);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22070_112255_112352(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22070, 112255, 112352);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22070_112540_112608(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22070, 112540, 112608);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22070_112540_112628(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22070, 112540, 112628);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22070_112807_112857(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22070, 112807, 112857);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22070_112807_112876(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22070, 112807, 112876);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22070_112807_112896(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22070, 112807, 112896);
return return_v;
}


int
f_22070_114529_114639(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ExpressionStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22070, 114529, 114639);
return 0;
}

}
}
