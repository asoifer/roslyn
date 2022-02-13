// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp.Test.Utilities;
using Microsoft.CodeAnalysis.Operations;
using Microsoft.CodeAnalysis.Test.Utilities;
using Roslyn.Test.Utilities;
using Xunit;

namespace Microsoft.CodeAnalysis.CSharp.UnitTests
{
public partial class IOperationTests_Patterns : SemanticModelTestBase
{
[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Patterns)]
        [Fact, WorkItem(19927, "https://github.com/dotnet/roslyn/issues/19927")]
        public void TestIsPatternExpression_VarPatternDeclaration()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22043,625,1727);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,870,1040);

string 
source = @"
using System;
class X
{
    void M()
    {
        int? x = 12;
        if (/*<bind>*/x is var y/*</bind>*/) Console.WriteLine(y);
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,1054,1513);

string 
expectedOperationTree = @"
IIsPatternOperation (OperationKind.IsPattern, Type: System.Boolean) (Syntax: 'x is var y')
  Value: 
    ILocalReferenceOperation: x (OperationKind.LocalReference, Type: System.Int32?) (Syntax: 'x')
  Pattern: 
    IDeclarationPatternOperation (OperationKind.DeclarationPattern, Type: null) (Syntax: 'var y') (InputType: System.Int32?, NarrowedType: System.Int32?, DeclaredSymbol: System.Int32? y, MatchesNull: True)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,1527,1580);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,1596,1716);

f_22043_1596_1715(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22043,625,1727);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22043,625,1727);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22043,625,1727);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Patterns)]
        [Fact, WorkItem(19927, "https://github.com/dotnet/roslyn/issues/19927")]
        public void TestIsPatternExpression_PrimitiveTypePatternDeclaration()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22043,1739,2850);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,1994,2164);

string 
source = @"
using System;
class X
{
    void M()
    {
        int? x = 12;
        if (/*<bind>*/x is int y/*</bind>*/) Console.WriteLine(y);
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,2178,2636);

string 
expectedOperationTree = @"
IIsPatternOperation (OperationKind.IsPattern, Type: System.Boolean) (Syntax: 'x is int y')
  Value: 
    ILocalReferenceOperation: x (OperationKind.LocalReference, Type: System.Int32?) (Syntax: 'x')
  Pattern: 
    IDeclarationPatternOperation (OperationKind.DeclarationPattern, Type: null) (Syntax: 'int y') (InputType: System.Int32?, NarrowedType: System.Int32, DeclaredSymbol: System.Int32 y, MatchesNull: False)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,2650,2703);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,2719,2839);

f_22043_2719_2838(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22043,1739,2850);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22043,1739,2850);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22043,1739,2850);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Patterns)]
        [Fact, WorkItem(19927, "https://github.com/dotnet/roslyn/issues/19927")]
        public void TestIsPatternExpression_ReferenceTypePatternDeclaration()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22043,2862,3910);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,3117,3266);

string 
source = @"
using System;
class X
{
    void M(X x)
    {
        if (/*<bind>*/x is X y/*</bind>*/) Console.WriteLine(y);
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,3280,3696);

string 
expectedOperationTree = @"
IIsPatternOperation (OperationKind.IsPattern, Type: System.Boolean) (Syntax: 'x is X y')
  Value: 
    IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: X) (Syntax: 'x')
  Pattern: 
    IDeclarationPatternOperation (OperationKind.DeclarationPattern, Type: null) (Syntax: 'X y') (InputType: X, NarrowedType: X, DeclaredSymbol: X y, MatchesNull: False)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,3710,3763);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,3779,3899);

f_22043_3779_3898(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22043,2862,3910);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22043,2862,3910);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22043,2862,3910);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Patterns)]
        [Fact, WorkItem(19927, "https://github.com/dotnet/roslyn/issues/19927")]
        public void TestIsPatternExpression_TypeParameterTypePatternDeclaration()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22043,3922,4992);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,4181,4348);

string 
source = @"
using System;
class X
{
    void M<T>(T x) where T: class
    {
        if (/*<bind>*/x is T y/*</bind>*/) Console.WriteLine(y);
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,4362,4778);

string 
expectedOperationTree = @"
IIsPatternOperation (OperationKind.IsPattern, Type: System.Boolean) (Syntax: 'x is T y')
  Value: 
    IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: T) (Syntax: 'x')
  Pattern: 
    IDeclarationPatternOperation (OperationKind.DeclarationPattern, Type: null) (Syntax: 'T y') (InputType: T, NarrowedType: T, DeclaredSymbol: T y, MatchesNull: False)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,4792,4845);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,4861,4981);

f_22043_4861_4980(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22043,3922,4992);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22043,3922,4992);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22043,3922,4992);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Patterns)]
        [Fact, WorkItem(19927, "https://github.com/dotnet/roslyn/issues/19927")]
        public void TestIsPatternExpression_DynamicTypePatternDeclaration()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22043,5004,6388);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,5257,5412);

string 
source = @"
using System;
class X
{
    void M(X x)
    {
        if (/*<bind>*/x is dynamic y/*</bind>*/) Console.WriteLine(y);
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,5426,5888);

string 
expectedOperationTree = @"
IIsPatternOperation (OperationKind.IsPattern, Type: System.Boolean, IsInvalid) (Syntax: 'x is dynamic y')
  Value: 
    IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: X) (Syntax: 'x')
  Pattern: 
    IDeclarationPatternOperation (OperationKind.DeclarationPattern, Type: null, IsInvalid) (Syntax: 'dynamic y') (InputType: X, NarrowedType: dynamic, DeclaredSymbol: dynamic y, MatchesNull: False)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,5902,6241);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22043_6150_6225(f_22043_6150_6205(ErrorCode.ERR_PatternDynamicType, "dynamic"), 7, 28)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,6257,6377);

f_22043_6257_6376(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22043,5004,6388);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22043,5004,6388);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22043,5004,6388);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Patterns)]
        [Fact, WorkItem(19927, "https://github.com/dotnet/roslyn/issues/19927")]
        public void TestIsPatternExpression_ConstantPattern()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22043,6400,7551);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,6639,6814);

string 
source = @"
using System;
class X
{
    void M()
    {
        int? x = 12, y = 12;
        if (/*<bind>*/x is 12/*</bind>*/) Console.WriteLine(y);
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,6828,7337);

string 
expectedOperationTree = @"
IIsPatternOperation (OperationKind.IsPattern, Type: System.Boolean) (Syntax: 'x is 12')
  Value: 
    ILocalReferenceOperation: x (OperationKind.LocalReference, Type: System.Int32?) (Syntax: 'x')
  Pattern: 
    IConstantPatternOperation (OperationKind.ConstantPattern, Type: null) (Syntax: '12') (InputType: System.Int32?, NarrowedType: System.Int32)
      Value: 
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 12) (Syntax: '12')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,7351,7404);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,7420,7540);

f_22043_7420_7539(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22043,6400,7551);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22043,6400,7551);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22043,6400,7551);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Patterns)]
        [Fact, WorkItem(19927, "https://github.com/dotnet/roslyn/issues/19927")]
        public void TestIsPatternExpression_ConstantPatternWithConversion()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22043,7563,9072);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,7816,7998);

string 
source = @"
using System;
class X
{
    void M()
    {
        int? x = 12, y = 12;
        if (/*<bind>*/x is (int)12.0/*</bind>*/) Console.WriteLine(y);
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,8012,8858);

string 
expectedOperationTree = @"
IIsPatternOperation (OperationKind.IsPattern, Type: System.Boolean) (Syntax: 'x is (int)12.0')
  Value: 
    ILocalReferenceOperation: x (OperationKind.LocalReference, Type: System.Int32?) (Syntax: 'x')
  Pattern: 
    IConstantPatternOperation (OperationKind.ConstantPattern, Type: null) (Syntax: '(int)12.0') (InputType: System.Int32?, NarrowedType: System.Int32)
      Value: 
        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32, Constant: 12) (Syntax: '(int)12.0')
          Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
          Operand: 
            ILiteralOperation (OperationKind.Literal, Type: System.Double, Constant: 12) (Syntax: '12.0')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,8872,8925);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,8941,9061);

f_22043_8941_9060(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22043,7563,9072);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22043,7563,9072);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22043,7563,9072);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Patterns)]
        [Fact, WorkItem(19927, "https://github.com/dotnet/roslyn/issues/19927")]
        public void TestIsPatternExpression_ConstantPatternWithNoImplicitConversion()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22043,9084,11000);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,9347,9524);

string 
source = @"
using System;
class X
{
    void M()
    {
        int? x = 12, y = 12;
        if (/*<bind>*/x is 12.0/*</bind>*/) Console.WriteLine(y);
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,9538,10425);

string 
expectedOperationTree = @"
IIsPatternOperation (OperationKind.IsPattern, Type: System.Boolean, IsInvalid) (Syntax: 'x is 12.0')
  Value: 
    ILocalReferenceOperation: x (OperationKind.LocalReference, Type: System.Int32?) (Syntax: 'x')
  Pattern: 
    IConstantPatternOperation (OperationKind.ConstantPattern, Type: null, IsInvalid) (Syntax: '12.0') (InputType: System.Int32?, NarrowedType: System.Int32)
      Value: 
        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32, Constant: 12, IsInvalid, IsImplicit) (Syntax: '12.0')
          Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
          Operand: 
            ILiteralOperation (OperationKind.Literal, Type: System.Double, Constant: 12, IsInvalid) (Syntax: '12.0')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,10439,10853);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22043_10733_10837(f_22043_10733_10817(f_22043_10733_10785(ErrorCode.ERR_NoImplicitConvCast, "12.0"), "double", "int?"), 8, 28)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,10869,10989);

f_22043_10869_10988(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22043,9084,11000);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22043,9084,11000);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22043,9084,11000);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Patterns)]
        [Fact, WorkItem(19927, "https://github.com/dotnet/roslyn/issues/19927")]
        public void TestIsPatternExpression_ConstantPatternWithNoValidImplicitOrExplicitConversion()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22043,11012,12869);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,11290,11466);

string 
source = @"
using System;
class X
{
    void M()
    {
        int x = 12, y = 12;
        if (/*<bind>*/x is null/*</bind>*/) Console.WriteLine(y);
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,11480,12346);

string 
expectedOperationTree = @"
IIsPatternOperation (OperationKind.IsPattern, Type: System.Boolean, IsInvalid) (Syntax: 'x is null')
  Value: 
    ILocalReferenceOperation: x (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'x')
  Pattern: 
    IConstantPatternOperation (OperationKind.ConstantPattern, Type: null, IsInvalid) (Syntax: 'null') (InputType: System.Int32, NarrowedType: System.Int32)
      Value: 
        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'null')
          Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
          Operand: 
            ILiteralOperation (OperationKind.Literal, Type: null, Constant: null, IsInvalid) (Syntax: 'null')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,12360,12722);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22043_12616_12706(f_22043_12616_12686(f_22043_12616_12665(ErrorCode.ERR_ValueCantBeNull, "null"), "int"), 8, 28)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,12738,12858);

f_22043_12738_12857(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22043,11012,12869);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22043,11012,12869);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22043,11012,12869);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Patterns)]
        [Fact, WorkItem(19927, "https://github.com/dotnet/roslyn/issues/19927")]
        public void TestIsPatternExpression_UndefinedTypeInPatternDeclaration()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22043,12881,14449);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,13138,13318);

string 
source = @"
using System;
class X
{
    void M()
    {
        int? x = 12;
        if (/*<bind>*/x is UndefinedType y/*</bind>*/) Console.WriteLine(y);
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,13332,13834);

string 
expectedOperationTree = @"
IIsPatternOperation (OperationKind.IsPattern, Type: System.Boolean, IsInvalid) (Syntax: 'x is UndefinedType y')
  Value: 
    ILocalReferenceOperation: x (OperationKind.LocalReference, Type: System.Int32?) (Syntax: 'x')
  Pattern: 
    IDeclarationPatternOperation (OperationKind.DeclarationPattern, Type: null, IsInvalid) (Syntax: 'UndefinedType y') (InputType: System.Int32?, NarrowedType: UndefinedType, DeclaredSymbol: UndefinedType y, MatchesNull: False)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,13848,14302);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22043_14170_14286(f_22043_14170_14266(f_22043_14170_14235(ErrorCode.ERR_SingleTypeNameNotFound, "UndefinedType"), "UndefinedType"), 8, 28)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,14318,14438);

f_22043_14318_14437(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22043,12881,14449);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22043,12881,14449);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22043,12881,14449);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Patterns)]
        [Fact, WorkItem(19927, "https://github.com/dotnet/roslyn/issues/19927")]
        public void TestIsPatternExpression_InvalidConstantPatternDeclaration()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22043,14461,15916);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,14718,14892);

string 
source = @"
using System;
class X
{
    void M()
    {
        int? x = 12, y = 12;
        if (/*<bind>*/x is y/*</bind>*/) Console.WriteLine(y);
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,14906,15462);

string 
expectedOperationTree = @"
IIsPatternOperation (OperationKind.IsPattern, Type: System.Boolean, IsInvalid) (Syntax: 'x is y')
  Value: 
    ILocalReferenceOperation: x (OperationKind.LocalReference, Type: System.Int32?) (Syntax: 'x')
  Pattern: 
    IConstantPatternOperation (OperationKind.ConstantPattern, Type: null, IsInvalid, IsImplicit) (Syntax: 'y') (InputType: System.Int32?, NarrowedType: System.Int32?)
      Value: 
        ILocalReferenceOperation: y (OperationKind.LocalReference, Type: System.Int32?, IsInvalid) (Syntax: 'y')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,15476,15772);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22043_15689_15756(f_22043_15689_15736(ErrorCode.ERR_ConstantExpected, "y"), 8, 28)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,15788,15905);

f_22043_15788_15904(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22043,14461,15916);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22043,14461,15916);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22043,14461,15916);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Patterns)]
        [Fact, WorkItem(19927, "https://github.com/dotnet/roslyn/issues/19927")]
        public void TestIsPatternExpression_InvalidTypeInPatternDeclaration()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22043,15928,17349);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,16183,16351);

string 
source = @"
using System;
class X
{
    void M()
    {
        int? x = 12;
        if (/*<bind>*/x is X y/*</bind>*/) Console.WriteLine(y);
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,16365,16819);

string 
expectedOperationTree = @"
IIsPatternOperation (OperationKind.IsPattern, Type: System.Boolean, IsInvalid) (Syntax: 'x is X y')
  Value: 
    ILocalReferenceOperation: x (OperationKind.LocalReference, Type: System.Int32?) (Syntax: 'x')
  Pattern: 
    IDeclarationPatternOperation (OperationKind.DeclarationPattern, Type: null, IsInvalid) (Syntax: 'X y') (InputType: System.Int32?, NarrowedType: X, DeclaredSymbol: X y, MatchesNull: False)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,16833,17202);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22043_17092_17186(f_22043_17092_17166(f_22043_17092_17139(ErrorCode.ERR_PatternWrongType, "X"), "int?", "X"), 8, 28)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,17218,17338);

f_22043_17218_17337(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22043,15928,17349);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22043,15928,17349);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22043,15928,17349);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Patterns)]
        [Fact, WorkItem(19927, "https://github.com/dotnet/roslyn/issues/19927")]
        public void TestIsPatternExpression_DuplicateLocalInPatternDeclaration()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22043,17361,18812);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,17619,17797);

string 
source = @"
using System;
class X
{
    void M()
    {
        int? x = 12, y = 12;
        if (/*<bind>*/x is int y/*</bind>*/) Console.WriteLine(y);
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,17811,18291);

string 
expectedOperationTree = @"
IIsPatternOperation (OperationKind.IsPattern, Type: System.Boolean, IsInvalid) (Syntax: 'x is int y')
  Value: 
    ILocalReferenceOperation: x (OperationKind.LocalReference, Type: System.Int32?) (Syntax: 'x')
  Pattern: 
    IDeclarationPatternOperation (OperationKind.DeclarationPattern, Type: null, IsInvalid) (Syntax: 'int y') (InputType: System.Int32?, NarrowedType: System.Int32, DeclaredSymbol: System.Int32 y, MatchesNull: False)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,18305,18665);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22043_18565_18649(f_22043_18565_18629(f_22043_18565_18610(ErrorCode.ERR_LocalDuplicate, "y"), "y"), 8, 32)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,18681,18801);

f_22043_18681_18800(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22043,17361,18812);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22043,17361,18812);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22043,17361,18812);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Patterns)]
        [Fact, WorkItem(19927, "https://github.com/dotnet/roslyn/issues/19927")]
        public void TestIsPatternExpression_InvalidMultipleLocalsInPatternDeclaration()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22043,18824,21594);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,19089,19272);

string 
source = @"
using System;
class X
{
    void M()
    {
        int? x = 12, y = 12;
        if (/*<bind>*/x is int y2/*</bind>*/, y3) Console.WriteLine(y);
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,19286,19747);

string 
expectedOperationTree = @"
IIsPatternOperation (OperationKind.IsPattern, Type: System.Boolean) (Syntax: 'x is int y2')
  Value: 
    ILocalReferenceOperation: x (OperationKind.LocalReference, Type: System.Int32?) (Syntax: 'x')
  Pattern: 
    IDeclarationPatternOperation (OperationKind.DeclarationPattern, Type: null) (Syntax: 'int y2') (InputType: System.Int32?, NarrowedType: System.Int32, DeclaredSymbol: System.Int32 y2, MatchesNull: False)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,19761,21447);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22043_19965_20034(f_22043_19965_20014(ErrorCode.ERR_CloseParenExpected, ","), 8, 45),
f_22043_20201_20286(f_22043_20201_20266(f_22043_20201_20247(ErrorCode.ERR_InvalidExprTerm, ","), ","), 8, 45),
f_22043_20436_20504(f_22043_20436_20484(ErrorCode.ERR_SemicolonExpected, ","), 8, 45),
f_22043_20654_20719(f_22043_20654_20699(ErrorCode.ERR_RbraceExpected, ","), 8, 45),
f_22043_20869_20937(f_22043_20869_20917(ErrorCode.ERR_SemicolonExpected, ")"), 8, 49),
f_22043_21087_21152(f_22043_21087_21132(ErrorCode.ERR_RbraceExpected, ")"), 8, 49),
f_22043_21343_21431(f_22043_21343_21411(f_22043_21343_21391(ErrorCode.ERR_NameNotInContext, "y3"), "y3"), 8, 47)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,21463,21583);

f_22043_21463_21582(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22043,18824,21594);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22043,18824,21594);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22043,18824,21594);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Patterns)]
        [Fact, WorkItem(19927, "https://github.com/dotnet/roslyn/issues/19927")]
        public void TestIsPatternExpression_InvalidConstDeclarationInPatternDeclaration()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22043,21606,24841);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,21873,22048);

string 
source = @"
using System;
class X
{
    void M()
    {
        int x = 12;
        if (/*<bind>*/x is /*</bind>*/const int y) Console.WriteLine(y);
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,22062,22342);

string 
expectedOperationTree = @"
    IIsTypeOperation (OperationKind.IsType, Type: System.Boolean, IsInvalid) (Syntax: 'x is /*</bind>*/')
      Operand: 
        ILocalReferenceOperation: x (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'x')
      IsType: ?
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,22356,24697);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22043_22615_22708(f_22043_22615_22688(f_22043_22615_22665(ErrorCode.ERR_InvalidExprTerm, "const"), "const"), 8, 39),
f_22043_22892_22965(f_22043_22892_22945(ErrorCode.ERR_CloseParenExpected, "const"), 8, 39),
f_22043_23184_23253(f_22043_23184_23233(ErrorCode.ERR_ConstValueRequired, "y"), 8, 49),
f_22043_23437_23505(f_22043_23437_23485(ErrorCode.ERR_SemicolonExpected, ")"), 8, 50),
f_22043_23689_23754(f_22043_23689_23734(ErrorCode.ERR_RbraceExpected, ")"), 8, 50),
f_22043_23991_24067(f_22043_23991_24047(ErrorCode.ERR_BadEmbeddedStmt, "const int y"), 8, 39),
f_22043_24291_24377(f_22043_24291_24357(f_22043_24291_24338(ErrorCode.ERR_NameNotInContext, "y"), "y"), 8, 70),
f_22043_24596_24681(f_22043_24596_24661(f_22043_24596_24642(ErrorCode.WRN_UnreferencedVar, "y"), "y"), 8, 49)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,24713,24830);

f_22043_24713_24829(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22043,21606,24841);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22043,21606,24841);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22043,21606,24841);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Patterns)]
        [Fact, WorkItem(19927, "https://github.com/dotnet/roslyn/issues/19927")]
        public void TestIsPatternExpression_InvalidInDefaultParameterInitializer()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22043,24853,26420);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,25113,25253);

string 
source = @"
using System;
class X
{
    void M(string x = /*<bind>*/string.Empty is string y/*</bind>*/)
    {    
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,25267,25870);

string 
expectedOperationTree = @"
IIsPatternOperation (OperationKind.IsPattern, Type: System.Boolean, IsInvalid) (Syntax: 'string.Empty is string y')
  Value: 
    IFieldReferenceOperation: System.String System.String.Empty (Static) (OperationKind.FieldReference, Type: System.String, IsInvalid) (Syntax: 'string.Empty')
      Instance Receiver: 
        null
  Pattern: 
    IDeclarationPatternOperation (OperationKind.DeclarationPattern, Type: null, IsInvalid) (Syntax: 'string y') (InputType: System.String, NarrowedType: System.String, DeclaredSymbol: System.String y, MatchesNull: False)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,25884,26273);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22043_26138_26257(f_22043_26138_26237(f_22043_26138_26218(ErrorCode.ERR_DefaultValueMustBeConstant, "string.Empty is string y"), "x"), 5, 33)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,26289,26409);

f_22043_26289_26408(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22043,24853,26420);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22043,24853,26420);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22043,24853,26420);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Patterns)]
        [Fact, WorkItem(19927, "https://github.com/dotnet/roslyn/issues/19927")]
        public void TestIsPatternExpression_InvalidInFieldInitializer()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22043,26432,27587);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,26681,26835);

string 
source = @"
class C
{
    private readonly static object o = 1;
    private readonly bool b = /*<bind>*/o is int x/*</bind>*/ && x >= 5;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,26849,27373);

string 
expectedOperationTree = @"
IIsPatternOperation (OperationKind.IsPattern, Type: System.Boolean) (Syntax: 'o is int x')
  Value: 
    IFieldReferenceOperation: System.Object C.o (Static) (OperationKind.FieldReference, Type: System.Object) (Syntax: 'o')
      Instance Receiver: 
        null
  Pattern: 
    IDeclarationPatternOperation (OperationKind.DeclarationPattern, Type: null) (Syntax: 'int x') (InputType: System.Object, NarrowedType: System.Int32, DeclaredSymbol: System.Int32 x, MatchesNull: False)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,27387,27440);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,27456,27576);

f_22043_27456_27575(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22043,26432,27587);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22043,26432,27587);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22043,26432,27587);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Patterns)]
        [Fact, WorkItem(19927, "https://github.com/dotnet/roslyn/issues/19927")]
        public void TestIsPatternExpression_InvalidInConstructorInitializer()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22043,27599,28722);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,27854,28028);

string 
source = @"
class C
{
    public C(object o): 
        this (/*<bind>*/o is int x/*</bind>*/ && x >= 5)
    {
    }

    public C (bool b)
    {
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,28042,28508);

string 
expectedOperationTree = @"
IIsPatternOperation (OperationKind.IsPattern, Type: System.Boolean) (Syntax: 'o is int x')
  Value: 
    IParameterReferenceOperation: o (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'o')
  Pattern: 
    IDeclarationPatternOperation (OperationKind.DeclarationPattern, Type: null) (Syntax: 'int x') (InputType: System.Object, NarrowedType: System.Int32, DeclaredSymbol: System.Int32 x, MatchesNull: False)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,28522,28575);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,28591,28711);

f_22043_28591_28710(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22043,27599,28722);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22043,27599,28722);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22043,27599,28722);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Patterns)]
        [Fact, WorkItem(19927, "https://github.com/dotnet/roslyn/issues/19927")]
        public void TestIsPatternExpression_InvalidInAttributeArgument()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22043,28734,30651);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,28984,29174);

string 
source = @"
class A: System.Attribute
{
    public A (bool i)
    {
    }
}

[A(/*<bind>*/o is int x/*</bind>*/ && x >= 5)]
class C
{
    private const object o = 1;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,29188,29758);

string 
expectedOperationTree = @"
IIsPatternOperation (OperationKind.IsPattern, Type: System.Boolean, IsInvalid) (Syntax: 'o is int x')
  Value: 
    IFieldReferenceOperation: System.Object C.o (Static) (OperationKind.FieldReference, Type: System.Object, Constant: 1, IsInvalid) (Syntax: 'o')
      Instance Receiver: 
        null
  Pattern: 
    IDeclarationPatternOperation (OperationKind.DeclarationPattern, Type: null, IsInvalid) (Syntax: 'int x') (InputType: System.Object, NarrowedType: System.Int32, DeclaredSymbol: System.Int32 x, MatchesNull: False)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,29772,30504);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22043_30039_30142(f_22043_30039_30121(f_22043_30039_30090(ErrorCode.ERR_NotNullConstRefField, "1"), "C.o", "object"), 12, 30),
f_22043_30387_30488(f_22043_30387_30468(ErrorCode.ERR_BadAttributeArgument, "o is int x/*</bind>*/ && x >= 5"), 9, 14)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,30520,30640);

f_22043_30520_30639(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22043,28734,30651);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22043,28734,30651);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22043,28734,30651);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow, CompilerFeature.Patterns)]
        [Fact]
        public void IsPattern_NoControlFlow_01()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22043,30663,33642);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,30849,31014);

string 
source = @"
class C
{
    void M(int? x, bool b, int x2, bool b2)
    /*<bind>*/{
        b = x is var y;
        b2 = x2 is 1;
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,31028,33448);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}
.locals {R1}
{
    Locals: [System.Int32? y]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (2)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'b = x is var y;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'b = x is var y')
                  Left: 
                    IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')
                  Right: 
                    IIsPatternOperation (OperationKind.IsPattern, Type: System.Boolean) (Syntax: 'x is var y')
                      Value: 
                        IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'x')
                      Pattern: 
                        IDeclarationPatternOperation (OperationKind.DeclarationPattern, Type: null) (Syntax: 'var y') (InputType: System.Int32?, NarrowedType: System.Int32?, DeclaredSymbol: System.Int32? y, MatchesNull: True)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'b2 = x2 is 1;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'b2 = x2 is 1')
                  Left: 
                    IParameterReferenceOperation: b2 (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b2')
                  Right: 
                    IIsPatternOperation (OperationKind.IsPattern, Type: System.Boolean) (Syntax: 'x2 is 1')
                      Value: 
                        IParameterReferenceOperation: x2 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'x2')
                      Pattern: 
                        IConstantPatternOperation (OperationKind.ConstantPattern, Type: null) (Syntax: '1') (InputType: System.Int32, NarrowedType: System.Int32)
                          Value: 
                            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
        Next (Regular) Block[B2]
            Leaving: {R1}
}
Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,33464,33517);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,33533,33631);

f_22043_33533_33630(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22043,30663,33642);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22043,30663,33642);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22043,30663,33642);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow, CompilerFeature.Patterns)]
        [Fact]
        public void IsPattern_NoControlFlow_02()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22043,33654,40053);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,33840,33996);

string 
source = @"
class C
{
    void M((int X, int Y)? x, bool b)
    /*<bind>*/{
        b = x is (1, _) { Item1: var z } p;
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,34012,34056);

var 
compilation = f_22043_34030_34055(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,34070,34102);

f_22043_34070_34101(            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,34118,36768);

string 
expectedOperationTree = @"
IBlockOperation (1 statements, 2 locals) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
  Locals: Local_1: (System.Int32 X, System.Int32 Y) p
    Local_2: System.Int32 z
  IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'b = x is (1 ...  var z } p;')
    Expression: 
      ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'b = x is (1 ... : var z } p')
        Left: 
          IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')
        Right: 
          IIsPatternOperation (OperationKind.IsPattern, Type: System.Boolean) (Syntax: 'x is (1, _) ... : var z } p')
            Value: 
              IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: (System.Int32 X, System.Int32 Y)?) (Syntax: 'x')
            Pattern: 
              IRecursivePatternOperation (OperationKind.RecursivePattern, Type: null) (Syntax: '(1, _) { It ... : var z } p') (InputType: (System.Int32 X, System.Int32 Y)?, NarrowedType: (System.Int32 X, System.Int32 Y), DeclaredSymbol: (System.Int32 X, System.Int32 Y) p, MatchedType: (System.Int32 X, System.Int32 Y), DeconstructSymbol: null)
                DeconstructionSubpatterns (2):
                    IConstantPatternOperation (OperationKind.ConstantPattern, Type: null) (Syntax: '1') (InputType: System.Int32, NarrowedType: System.Int32)
                      Value: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
                    IDiscardPatternOperation (OperationKind.DiscardPattern, Type: null) (Syntax: '_') (InputType: System.Int32, NarrowedType: System.Int32)
                PropertySubpatterns (1):
                    IPropertySubpatternOperation (OperationKind.PropertySubpattern, Type: null) (Syntax: 'Item1: var z')
                      Member: 
                        IFieldReferenceOperation: System.Int32 (System.Int32 X, System.Int32 Y).Item1 (OperationKind.FieldReference, Type: System.Int32) (Syntax: 'Item1')
                          Instance Receiver: 
                            IInstanceReferenceOperation (ReferenceKind: PatternInput) (OperationKind.InstanceReference, Type: (System.Int32 X, System.Int32 Y), IsImplicit) (Syntax: 'Item1')
                      Pattern: 
                        IDeclarationPatternOperation (OperationKind.DeclarationPattern, Type: null) (Syntax: 'var z') (InputType: System.Int32, NarrowedType: System.Int32, DeclaredSymbol: System.Int32 z, MatchesNull: True)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,36784,36860);

f_22043_36784_36859(compilation, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,36876,39958);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}
.locals {R1}
{
    Locals: [(System.Int32 X, System.Int32 Y) p] [System.Int32 z]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'b = x is (1 ...  var z } p;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'b = x is (1 ... : var z } p')
                  Left: 
                    IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')
                  Right: 
                    IIsPatternOperation (OperationKind.IsPattern, Type: System.Boolean) (Syntax: 'x is (1, _) ... : var z } p')
                      Value: 
                        IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: (System.Int32 X, System.Int32 Y)?) (Syntax: 'x')
                      Pattern: 
                        IRecursivePatternOperation (OperationKind.RecursivePattern, Type: null) (Syntax: '(1, _) { It ... : var z } p') (InputType: (System.Int32 X, System.Int32 Y)?, NarrowedType: (System.Int32 X, System.Int32 Y), DeclaredSymbol: (System.Int32 X, System.Int32 Y) p, MatchedType: (System.Int32 X, System.Int32 Y), DeconstructSymbol: null)
                          DeconstructionSubpatterns (2):
                              IConstantPatternOperation (OperationKind.ConstantPattern, Type: null) (Syntax: '1') (InputType: System.Int32, NarrowedType: System.Int32)
                                Value: 
                                  ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
                              IDiscardPatternOperation (OperationKind.DiscardPattern, Type: null) (Syntax: '_') (InputType: System.Int32, NarrowedType: System.Int32)
                          PropertySubpatterns (1):
                              IPropertySubpatternOperation (OperationKind.PropertySubpattern, Type: null) (Syntax: 'Item1: var z')
                                Member: 
                                  IFieldReferenceOperation: System.Int32 (System.Int32 X, System.Int32 Y).Item1 (OperationKind.FieldReference, Type: System.Int32) (Syntax: 'Item1')
                                    Instance Receiver: 
                                      IInstanceReferenceOperation (ReferenceKind: PatternInput) (OperationKind.InstanceReference, Type: (System.Int32 X, System.Int32 Y), IsImplicit) (Syntax: 'Item1')
                                Pattern: 
                                  IDeclarationPatternOperation (OperationKind.DeclarationPattern, Type: null) (Syntax: 'var z') (InputType: System.Int32, NarrowedType: System.Int32, DeclaredSymbol: System.Int32 z, MatchesNull: True)
        Next (Regular) Block[B2]
            Leaving: {R1}
}
Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,39974,40042);

f_22043_39974_40041(compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22043,33654,40053);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22043,33654,40053);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22043,33654,40053);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow, CompilerFeature.Patterns)]
        [Fact]
        public void IsPattern_NoControlFlow_03()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22043,40065,47175);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,40251,40451);

string 
source = @"
class C
{
    void M((int X, (int Y, int Z))? tuple, bool b)
    /*<bind>*/{
        b = tuple is (1, _) { Item1: var x, Item2: { Y: 1, Z: var z } } p;
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,40467,46981);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}
.locals {R1}
{
    Locals: [(System.Int32 X, (System.Int32 Y, System.Int32 Z)) p] [System.Int32 x] [System.Int32 z]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'b = tuple i ... ar z } } p;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'b = tuple i ... var z } } p')
                  Left: 
                    IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')
                  Right: 
                    IIsPatternOperation (OperationKind.IsPattern, Type: System.Boolean) (Syntax: 'tuple is (1 ... var z } } p')
                      Value: 
                        IParameterReferenceOperation: tuple (OperationKind.ParameterReference, Type: (System.Int32 X, (System.Int32 Y, System.Int32 Z))?) (Syntax: 'tuple')
                      Pattern: 
                        IRecursivePatternOperation (OperationKind.RecursivePattern, Type: null) (Syntax: '(1, _) { It ... var z } } p') (InputType: (System.Int32 X, (System.Int32 Y, System.Int32 Z))?, NarrowedType: (System.Int32 X, (System.Int32 Y, System.Int32 Z)), DeclaredSymbol: (System.Int32 X, (System.Int32 Y, System.Int32 Z)) p, MatchedType: (System.Int32 X, (System.Int32 Y, System.Int32 Z)), DeconstructSymbol: null)
                          DeconstructionSubpatterns (2):
                              IConstantPatternOperation (OperationKind.ConstantPattern, Type: null) (Syntax: '1') (InputType: System.Int32, NarrowedType: System.Int32)
                                Value: 
                                  ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
                              IDiscardPatternOperation (OperationKind.DiscardPattern, Type: null) (Syntax: '_') (InputType: (System.Int32 Y, System.Int32 Z), NarrowedType: (System.Int32 Y, System.Int32 Z))
                          PropertySubpatterns (2):
                              IPropertySubpatternOperation (OperationKind.PropertySubpattern, Type: null) (Syntax: 'Item1: var x')
                                Member: 
                                  IFieldReferenceOperation: System.Int32 (System.Int32 X, (System.Int32 Y, System.Int32 Z)).Item1 (OperationKind.FieldReference, Type: System.Int32) (Syntax: 'Item1')
                                    Instance Receiver: 
                                      IInstanceReferenceOperation (ReferenceKind: PatternInput) (OperationKind.InstanceReference, Type: (System.Int32 X, (System.Int32 Y, System.Int32 Z)), IsImplicit) (Syntax: 'Item1')
                                Pattern: 
                                  IDeclarationPatternOperation (OperationKind.DeclarationPattern, Type: null) (Syntax: 'var x') (InputType: System.Int32, NarrowedType: System.Int32, DeclaredSymbol: System.Int32 x, MatchesNull: True)
                              IPropertySubpatternOperation (OperationKind.PropertySubpattern, Type: null) (Syntax: 'Item2: { Y: ...  Z: var z }')
                                Member: 
                                  IFieldReferenceOperation: (System.Int32 Y, System.Int32 Z) (System.Int32 X, (System.Int32 Y, System.Int32 Z)).Item2 (OperationKind.FieldReference, Type: (System.Int32 Y, System.Int32 Z)) (Syntax: 'Item2')
                                    Instance Receiver: 
                                      IInstanceReferenceOperation (ReferenceKind: PatternInput) (OperationKind.InstanceReference, Type: (System.Int32 X, (System.Int32 Y, System.Int32 Z)), IsImplicit) (Syntax: 'Item2')
                                Pattern: 
                                  IRecursivePatternOperation (OperationKind.RecursivePattern, Type: null) (Syntax: '{ Y: 1, Z: var z }') (InputType: (System.Int32 Y, System.Int32 Z), NarrowedType: (System.Int32 Y, System.Int32 Z), DeclaredSymbol: null, MatchedType: (System.Int32 Y, System.Int32 Z), DeconstructSymbol: null)
                                    DeconstructionSubpatterns (0)
                                    PropertySubpatterns (2):
                                        IPropertySubpatternOperation (OperationKind.PropertySubpattern, Type: null) (Syntax: 'Y: 1')
                                          Member: 
                                            IFieldReferenceOperation: System.Int32 (System.Int32 Y, System.Int32 Z).Y (OperationKind.FieldReference, Type: System.Int32) (Syntax: 'Y')
                                              Instance Receiver: 
                                                IInstanceReferenceOperation (ReferenceKind: PatternInput) (OperationKind.InstanceReference, Type: (System.Int32 Y, System.Int32 Z), IsImplicit) (Syntax: 'Y')
                                          Pattern: 
                                            IConstantPatternOperation (OperationKind.ConstantPattern, Type: null) (Syntax: '1') (InputType: System.Int32, NarrowedType: System.Int32)
                                              Value: 
                                                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
                                        IPropertySubpatternOperation (OperationKind.PropertySubpattern, Type: null) (Syntax: 'Z: var z')
                                          Member: 
                                            IFieldReferenceOperation: System.Int32 (System.Int32 Y, System.Int32 Z).Z (OperationKind.FieldReference, Type: System.Int32) (Syntax: 'Z')
                                              Instance Receiver: 
                                                IInstanceReferenceOperation (ReferenceKind: PatternInput) (OperationKind.InstanceReference, Type: (System.Int32 Y, System.Int32 Z), IsImplicit) (Syntax: 'Z')
                                          Pattern: 
                                            IDeclarationPatternOperation (OperationKind.DeclarationPattern, Type: null) (Syntax: 'var z') (InputType: System.Int32, NarrowedType: System.Int32, DeclaredSymbol: System.Int32 z, MatchesNull: True)
        Next (Regular) Block[B2]
            Leaving: {R1}
}
Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,46997,47050);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,47066,47164);

f_22043_47066_47163(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22043,40065,47175);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22043,40065,47175);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22043,40065,47175);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow, CompilerFeature.Patterns)]
        [Fact]
        public void IsPattern_ControlFlowInValue()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22043,47187,51410);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,47375,47518);

string 
source = @"
class C
{
    void M(int? x1, int x2, bool b)
    /*<bind>*/{
        b = (x1 ?? x2) is var y;
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,47532,51218);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [System.Int32 y]
    CaptureIds: [0] [2]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'b')
              Value: 
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

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
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'b = (x1 ?? x2) is var y;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'b = (x1 ?? x2) is var y')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Boolean, IsImplicit) (Syntax: 'b')
                  Right: 
                    IIsPatternOperation (OperationKind.IsPattern, Type: System.Boolean) (Syntax: '(x1 ?? x2) is var y')
                      Value: 
                        IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'x1 ?? x2')
                      Pattern: 
                        IDeclarationPatternOperation (OperationKind.DeclarationPattern, Type: null) (Syntax: 'var y') (InputType: System.Int32, NarrowedType: System.Int32, DeclaredSymbol: System.Int32 y, MatchesNull: True)

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,51232,51285);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,51301,51399);

f_22043_51301_51398(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22043,47187,51410);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22043,47187,51410);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22043,47187,51410);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Patterns)]
        [Fact]
        public void IsPattern_RecursivePattern()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22043,51422,53986);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,51582,51749);

string 
source = @"
class C
{
    void M((int X, int Y) tuple, bool b)
    {
        if (/*<bind>*/tuple is (1, 2) { Item1: int x } y/*</bind>*/) { }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,51763,53772);

string 
expectedOperationTree = @"
IIsPatternOperation (OperationKind.IsPattern, Type: System.Boolean) (Syntax: 'tuple is (1 ... : int x } y')
  Value: 
    IParameterReferenceOperation: tuple (OperationKind.ParameterReference, Type: (System.Int32 X, System.Int32 Y)) (Syntax: 'tuple')
  Pattern: 
    IRecursivePatternOperation (OperationKind.RecursivePattern, Type: null) (Syntax: '(1, 2) { It ... : int x } y') (InputType: (System.Int32 X, System.Int32 Y), NarrowedType: (System.Int32 X, System.Int32 Y), DeclaredSymbol: (System.Int32 X, System.Int32 Y) y, MatchedType: (System.Int32 X, System.Int32 Y), DeconstructSymbol: null)
      DeconstructionSubpatterns (2):
          IConstantPatternOperation (OperationKind.ConstantPattern, Type: null) (Syntax: '1') (InputType: System.Int32, NarrowedType: System.Int32)
            Value: 
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
          IConstantPatternOperation (OperationKind.ConstantPattern, Type: null) (Syntax: '2') (InputType: System.Int32, NarrowedType: System.Int32)
            Value: 
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
      PropertySubpatterns (1):
          IPropertySubpatternOperation (OperationKind.PropertySubpattern, Type: null) (Syntax: 'Item1: int x')
            Member: 
              IFieldReferenceOperation: System.Int32 (System.Int32 X, System.Int32 Y).Item1 (OperationKind.FieldReference, Type: System.Int32) (Syntax: 'Item1')
                Instance Receiver: 
                  IInstanceReferenceOperation (ReferenceKind: PatternInput) (OperationKind.InstanceReference, Type: (System.Int32 X, System.Int32 Y), IsImplicit) (Syntax: 'Item1')
            Pattern: 
              IDeclarationPatternOperation (OperationKind.DeclarationPattern, Type: null) (Syntax: 'int x') (InputType: System.Int32, NarrowedType: System.Int32, DeclaredSymbol: System.Int32 x, MatchesNull: False)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,53786,53839);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,53855,53975);

f_22043_53855_53974(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22043,51422,53986);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22043,51422,53986);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22043,51422,53986);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Patterns)]
        [Fact]
        public void IsPattern_BadRecursivePattern_01()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22043,53998,56681);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,54164,54334);

string 
source = @"
class C
{
    void M((int X, int Y) tuple, bool b)
    {
        if (/*<bind>*/tuple is (1, 2) { NotFound: int x } y/*</bind>*/) { }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,54348,56132);

string 
expectedOperationTree = @"
IIsPatternOperation (OperationKind.IsPattern, Type: System.Boolean, IsInvalid) (Syntax: 'tuple is (1 ... : int x } y')
  Value: 
    IParameterReferenceOperation: tuple (OperationKind.ParameterReference, Type: (System.Int32 X, System.Int32 Y)) (Syntax: 'tuple')
  Pattern: 
    IRecursivePatternOperation (OperationKind.RecursivePattern, Type: null, IsInvalid) (Syntax: '(1, 2) { No ... : int x } y') (InputType: (System.Int32 X, System.Int32 Y), NarrowedType: (System.Int32 X, System.Int32 Y), DeclaredSymbol: (System.Int32 X, System.Int32 Y) y, MatchedType: (System.Int32 X, System.Int32 Y), DeconstructSymbol: null)
      DeconstructionSubpatterns (2):
          IConstantPatternOperation (OperationKind.ConstantPattern, Type: null) (Syntax: '1') (InputType: System.Int32, NarrowedType: System.Int32)
            Value: 
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
          IConstantPatternOperation (OperationKind.ConstantPattern, Type: null) (Syntax: '2') (InputType: System.Int32, NarrowedType: System.Int32)
            Value: 
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
      PropertySubpatterns (1):
          IPropertySubpatternOperation (OperationKind.PropertySubpattern, Type: null, IsInvalid) (Syntax: 'NotFound: int x')
            Member: 
              IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid) (Syntax: 'NotFound')
                Children(0)
            Pattern: 
              IDeclarationPatternOperation (OperationKind.DeclarationPattern, Type: null) (Syntax: 'int x') (InputType: ?, NarrowedType: System.Int32, DeclaredSymbol: System.Int32 x, MatchesNull: False)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,56146,56534);

var 
expectedDiagnostics = new[] {
f_22043_56404_56518(f_22043_56404_56498(f_22043_56404_56454(ErrorCode.ERR_NoSuchMember, "NotFound"), "(int X, int Y)", "NotFound"), 6, 41)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,56550,56670);

f_22043_56550_56669(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22043,53998,56681);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22043,53998,56681);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22043,53998,56681);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Patterns)]
        [Fact]
        public void IsPattern_BadRecursivePattern_02()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22043,56693,61064);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,56859,57063);

var 
vbSource = @"
Public Class C1
    Public Property Prop(index As Integer) As Integer
        Get
            Return 1
        End Get
        Set
        End Set
    End Property
End Class
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,57079,57138);

var 
vbCompilation = f_22043_57099_57137(this, vbSource)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,57154,57293);

var 
source = @"
class C
{
    void M1(object o, bool b)
    {
        b = /*<bind>*/o is C1 { Prop[1]: var x }/*</bind>*/;
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,57309,57437);

var 
compilation = f_22043_57327_57436(source, new[] { f_22043_57361_57397(vbCompilation)}, parseOptions: TestOptions.Regular8)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,57451,59383);

f_22043_57451_59382(            compilation, f_22043_57717_57840(f_22043_57717_57820(f_22043_57717_57783(ErrorCode.ERR_FeatureNotAvailableInVersion8, "Prop[1]"), "type pattern", "9.0"), 6, 33), f_22043_58090_58198(f_22043_58090_58178(f_22043_58090_58153(ErrorCode.ERR_PropertyPatternNameMissing, "Prop[1]"), "Prop[1]"), 6, 33), f_22043_58455_58553(f_22043_58455_58533(f_22043_58455_58511(ErrorCode.ERR_SingleTypeNameNotFound, "Prop"), "Prop"), 6, 33), f_22043_58795_58870(f_22043_58795_58850(ErrorCode.ERR_ArraySizeInDeclaration, "[1]"), 6, 37), f_22043_59039_59125(f_22043_59039_59105(f_22043_59039_59081(ErrorCode.ERR_SyntaxError, ":"), ",", ":"), 6, 40), f_22043_59294_59381(f_22043_59294_59361(f_22043_59294_59338(ErrorCode.ERR_SyntaxError, "var"), ",", ""), 6, 42));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,59399,60947);

var 
expectedOperationTree = @"
IIsPatternOperation (OperationKind.IsPattern, Type: System.Boolean, IsInvalid) (Syntax: 'o is C1 { P ... 1]: var x }')
  Value: 
    IParameterReferenceOperation: o (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'o')
  Pattern: 
    IRecursivePatternOperation (OperationKind.RecursivePattern, Type: null, IsInvalid) (Syntax: 'C1 { Prop[1]: var x }') (InputType: System.Object, NarrowedType: C1, DeclaredSymbol: null, MatchedType: C1, DeconstructSymbol: null)
      DeconstructionSubpatterns (0)
      PropertySubpatterns (2):
          IPropertySubpatternOperation (OperationKind.PropertySubpattern, Type: null, IsInvalid) (Syntax: 'Prop[1]')
            Member: 
              IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid, IsImplicit) (Syntax: 'Prop[1]')
                Children(0)
            Pattern: 
              ITypePatternOperation (OperationKind.TypePattern, Type: null, IsInvalid) (Syntax: 'Prop[1]') (InputType: ?, NarrowedType: Prop[], MatchedType: Prop[])
          IPropertySubpatternOperation (OperationKind.PropertySubpattern, Type: null, IsInvalid) (Syntax: 'var x')
            Member: 
              IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid, IsImplicit) (Syntax: 'var x')
                Children(0)
            Pattern: 
              IDeclarationPatternOperation (OperationKind.DeclarationPattern, Type: null, IsInvalid) (Syntax: 'var x') (InputType: ?, NarrowedType: ?, DeclaredSymbol: ?? x, MatchesNull: True)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,60963,61053);

f_22043_60963_61052(compilation, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22043,56693,61064);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22043,56693,61064);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22043,56693,61064);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Patterns)]
        [Fact]
        public void IsPattern_BadRecursivePattern_03()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22043,61076,63339);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,61242,61446);

var 
vbSource = @"
Public Class C1
    Public Property Prop(index As Integer) As Integer
        Get
            Return 1
        End Get
        Set
        End Set
    End Property
End Class
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,61462,61521);

var 
vbCompilation = f_22043_61482_61520(this, vbSource)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,61537,61673);

var 
source = @"
class C
{
    void M1(object o, bool b)
    {
        b = /*<bind>*/o is C1 { Prop: var x }/*</bind>*/;
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,61689,61781);

var 
compilation = f_22043_61707_61780(source, new[] { f_22043_61741_61777(vbCompilation)})
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,61795,62153);

f_22043_61795_62152(            compilation, f_22043_62059_62151(f_22043_62059_62131(f_22043_62059_62109(ErrorCode.ERR_PropertyLacksGet, "Prop"), "Prop"), 6, 33));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,62169,63222);

var 
expectedOperationTree = @"
IIsPatternOperation (OperationKind.IsPattern, Type: System.Boolean, IsInvalid) (Syntax: 'o is C1 { Prop: var x }')
  Value: 
    IParameterReferenceOperation: o (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'o')
  Pattern: 
    IRecursivePatternOperation (OperationKind.RecursivePattern, Type: null, IsInvalid) (Syntax: 'C1 { Prop: var x }') (InputType: System.Object, NarrowedType: C1, DeclaredSymbol: null, MatchedType: C1, DeconstructSymbol: null)
      DeconstructionSubpatterns (0)
      PropertySubpatterns (1):
          IPropertySubpatternOperation (OperationKind.PropertySubpattern, Type: null, IsInvalid) (Syntax: 'Prop: var x')
            Member: 
              IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid) (Syntax: 'Prop')
                Children(0)
            Pattern: 
              IDeclarationPatternOperation (OperationKind.DeclarationPattern, Type: null) (Syntax: 'var x') (InputType: ?, NarrowedType: ?, DeclaredSymbol: ?? x, MatchesNull: True)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,63238,63328);

f_22043_63238_63327(compilation, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22043,61076,63339);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22043,61076,63339);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22043,61076,63339);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Patterns)]
        [Fact]
        public void IsPattern_BadRecursivePattern_04()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22043,63351,65538);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,63517,63693);

var 
source = @"
class C
{
    void M1(object o)
    {
        _ = /*<bind>*/o is D { A: var a }/*</bind>*/;
    }
}
class D
{
    public event System.Action A;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,63709,63753);

var 
compilation = f_22043_63727_63752(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,63767,64368);

f_22043_63767_64367(            compilation, f_22043_64024_64110(f_22043_64024_64090(f_22043_64024_64071(ErrorCode.ERR_PropertyLacksGet, "A"), "A"), 6, 32), f_22043_64258_64348(f_22043_64258_64327(f_22043_64258_64306(ErrorCode.WRN_UnreferencedEvent, "A"), "D.A"), 11, 32));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,64384,65421);

var 
expectedOperationTree = @"
IIsPatternOperation (OperationKind.IsPattern, Type: System.Boolean, IsInvalid) (Syntax: 'o is D { A: var a }')
  Value: 
    IParameterReferenceOperation: o (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'o')
  Pattern: 
    IRecursivePatternOperation (OperationKind.RecursivePattern, Type: null, IsInvalid) (Syntax: 'D { A: var a }') (InputType: System.Object, NarrowedType: D, DeclaredSymbol: null, MatchedType: D, DeconstructSymbol: null)
      DeconstructionSubpatterns (0)
      PropertySubpatterns (1):
          IPropertySubpatternOperation (OperationKind.PropertySubpattern, Type: null, IsInvalid) (Syntax: 'A: var a')
            Member: 
              IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid) (Syntax: 'A')
                Children(0)
            Pattern: 
              IDeclarationPatternOperation (OperationKind.DeclarationPattern, Type: null) (Syntax: 'var a') (InputType: ?, NarrowedType: ?, DeclaredSymbol: ?? a, MatchesNull: True)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,65437,65527);

f_22043_65437_65526(compilation, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22043,63351,65538);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22043,63351,65538);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22043,63351,65538);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Patterns)]
        [Fact]
        public void IsPattern_BadRecursivePattern_05()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22043,65550,67489);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,65716,65882);

var 
source = @"
class C
{
    void M1(object o)
    {
        _ = /*<bind>*/o is D { B: var b }/*</bind>*/;
    }
}
class D
{
    public void B() { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,65898,65942);

var 
compilation = f_22043_65916_65941(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,65956,66319);

f_22043_65956_66318(            compilation, f_22043_66213_66299(f_22043_66213_66279(f_22043_66213_66260(ErrorCode.ERR_PropertyLacksGet, "B"), "B"), 6, 32));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,66335,67372);

var 
expectedOperationTree = @"
IIsPatternOperation (OperationKind.IsPattern, Type: System.Boolean, IsInvalid) (Syntax: 'o is D { B: var b }')
  Value: 
    IParameterReferenceOperation: o (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'o')
  Pattern: 
    IRecursivePatternOperation (OperationKind.RecursivePattern, Type: null, IsInvalid) (Syntax: 'D { B: var b }') (InputType: System.Object, NarrowedType: D, DeclaredSymbol: null, MatchedType: D, DeconstructSymbol: null)
      DeconstructionSubpatterns (0)
      PropertySubpatterns (1):
          IPropertySubpatternOperation (OperationKind.PropertySubpattern, Type: null, IsInvalid) (Syntax: 'B: var b')
            Member: 
              IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid) (Syntax: 'B')
                Children(0)
            Pattern: 
              IDeclarationPatternOperation (OperationKind.DeclarationPattern, Type: null) (Syntax: 'var b') (InputType: ?, NarrowedType: ?, DeclaredSymbol: ?? b, MatchesNull: True)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,67388,67478);

f_22043_67388_67477(compilation, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22043,65550,67489);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22043,65550,67489);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22043,65550,67489);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Patterns)]
        [Fact]
        public void IsPattern_BadRecursivePattern_06()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22043,67501,69737);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,67667,67832);

var 
source = @"
class C
{
    void M1(object o)
    {
        _ = /*<bind>*/o is D { C: var c }/*</bind>*/;
    }
}
class D
{
    public class C { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,67848,67892);

var 
compilation = f_22043_67866_67891(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,67906,68567);

f_22043_67906_68566(            compilation, f_22043_68140_68233(f_22043_68140_68213(f_22043_68140_68187(ErrorCode.ERR_BadTypeReference, "C"), "C", "D.C"), 6, 32), f_22043_68461_68547(f_22043_68461_68527(f_22043_68461_68508(ErrorCode.ERR_PropertyLacksGet, "C"), "C"), 6, 32));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,68583,69620);

var 
expectedOperationTree = @"
IIsPatternOperation (OperationKind.IsPattern, Type: System.Boolean, IsInvalid) (Syntax: 'o is D { C: var c }')
  Value: 
    IParameterReferenceOperation: o (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'o')
  Pattern: 
    IRecursivePatternOperation (OperationKind.RecursivePattern, Type: null, IsInvalid) (Syntax: 'D { C: var c }') (InputType: System.Object, NarrowedType: D, DeclaredSymbol: null, MatchedType: D, DeconstructSymbol: null)
      DeconstructionSubpatterns (0)
      PropertySubpatterns (1):
          IPropertySubpatternOperation (OperationKind.PropertySubpattern, Type: null, IsInvalid) (Syntax: 'C: var c')
            Member: 
              IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid) (Syntax: 'C')
                Children(0)
            Pattern: 
              IDeclarationPatternOperation (OperationKind.DeclarationPattern, Type: null) (Syntax: 'var c') (InputType: ?, NarrowedType: ?, DeclaredSymbol: ?? c, MatchesNull: True)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,69636,69726);

f_22043_69636_69725(compilation, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22043,67501,69737);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22043,67501,69737);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22043,67501,69737);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Patterns)]
        [Fact]
        public void IsPattern_BadRecursivePattern_07()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22043,69749,71791);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,69915,70085);

var 
source = @"
class C
{
    void M1(object o)
    {
        _ = /*<bind>*/o is D { X: var x }/*</bind>*/;
    }
}
class D
{
    public const int X = 3;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,70101,70145);

var 
compilation = f_22043_70119_70144(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,70159,70527);

f_22043_70159_70526(            compilation, f_22043_70419_70507(f_22043_70419_70487(f_22043_70419_70466(ErrorCode.ERR_ObjectProhibited, "X"), "D.X"), 6, 32));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,70543,71674);

var 
expectedOperationTree = @"
IIsPatternOperation (OperationKind.IsPattern, Type: System.Boolean, IsInvalid) (Syntax: 'o is D { X: var x }')
  Value: 
    IParameterReferenceOperation: o (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'o')
  Pattern: 
    IRecursivePatternOperation (OperationKind.RecursivePattern, Type: null, IsInvalid) (Syntax: 'D { X: var x }') (InputType: System.Object, NarrowedType: D, DeclaredSymbol: null, MatchedType: D, DeconstructSymbol: null)
      DeconstructionSubpatterns (0)
      PropertySubpatterns (1):
          IPropertySubpatternOperation (OperationKind.PropertySubpattern, Type: null, IsInvalid) (Syntax: 'X: var x')
            Member: 
              IFieldReferenceOperation: System.Int32 D.X (Static) (OperationKind.FieldReference, Type: System.Int32, Constant: 3, IsInvalid) (Syntax: 'X')
                Instance Receiver: 
                  null
            Pattern: 
              IDeclarationPatternOperation (OperationKind.DeclarationPattern, Type: null) (Syntax: 'var x') (InputType: ?, NarrowedType: ?, DeclaredSymbol: ?? x, MatchesNull: True)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,71690,71780);

f_22043_71690_71779(compilation, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22043,69749,71791);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22043,69749,71791);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22043,69749,71791);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Patterns)]
        [Fact]
        public void IsPattern_BadRecursivePattern_08()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22043,71803,73833);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,71969,72140);

var 
source = @"
class C
{
    void M1(object o)
    {
        _ = /*<bind>*/o is D { X: var x }/*</bind>*/;
    }
}
class D
{
    public static int X = 3;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,72156,72200);

var 
compilation = f_22043_72174_72199(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,72214,72582);

f_22043_72214_72581(            compilation, f_22043_72474_72562(f_22043_72474_72542(f_22043_72474_72521(ErrorCode.ERR_ObjectProhibited, "X"), "D.X"), 6, 32));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,72598,73716);

var 
expectedOperationTree = @"
IIsPatternOperation (OperationKind.IsPattern, Type: System.Boolean, IsInvalid) (Syntax: 'o is D { X: var x }')
  Value: 
    IParameterReferenceOperation: o (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'o')
  Pattern: 
    IRecursivePatternOperation (OperationKind.RecursivePattern, Type: null, IsInvalid) (Syntax: 'D { X: var x }') (InputType: System.Object, NarrowedType: D, DeclaredSymbol: null, MatchedType: D, DeconstructSymbol: null)
      DeconstructionSubpatterns (0)
      PropertySubpatterns (1):
          IPropertySubpatternOperation (OperationKind.PropertySubpattern, Type: null, IsInvalid) (Syntax: 'X: var x')
            Member: 
              IFieldReferenceOperation: System.Int32 D.X (Static) (OperationKind.FieldReference, Type: System.Int32, IsInvalid) (Syntax: 'X')
                Instance Receiver: 
                  null
            Pattern: 
              IDeclarationPatternOperation (OperationKind.DeclarationPattern, Type: null) (Syntax: 'var x') (InputType: ?, NarrowedType: ?, DeclaredSymbol: ?? x, MatchesNull: True)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,73732,73822);

f_22043_73732_73821(compilation, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22043,71803,73833);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22043,71803,73833);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22043,71803,73833);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Patterns)]
        [Fact]
        public void IsPattern_BadRecursivePattern_09()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22043,73845,75891);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,74011,74183);

var 
source = @"
class C
{
    void M1(object o)
    {
        _ = /*<bind>*/o is D { X: var x }/*</bind>*/;
    }
}
class D
{
    public static int X => 3;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,74199,74243);

var 
compilation = f_22043_74217_74242(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,74257,74625);

f_22043_74257_74624(            compilation, f_22043_74517_74605(f_22043_74517_74585(f_22043_74517_74564(ErrorCode.ERR_ObjectProhibited, "X"), "D.X"), 6, 32));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,74641,75774);

var 
expectedOperationTree = @"
IIsPatternOperation (OperationKind.IsPattern, Type: System.Boolean, IsInvalid) (Syntax: 'o is D { X: var x }')
  Value: 
    IParameterReferenceOperation: o (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'o')
  Pattern: 
    IRecursivePatternOperation (OperationKind.RecursivePattern, Type: null, IsInvalid) (Syntax: 'D { X: var x }') (InputType: System.Object, NarrowedType: D, DeclaredSymbol: null, MatchedType: D, DeconstructSymbol: null)
      DeconstructionSubpatterns (0)
      PropertySubpatterns (1):
          IPropertySubpatternOperation (OperationKind.PropertySubpattern, Type: null, IsInvalid) (Syntax: 'X: var x')
            Member: 
              IPropertyReferenceOperation: System.Int32 D.X { get; } (Static) (OperationKind.PropertyReference, Type: System.Int32, IsInvalid) (Syntax: 'X')
                Instance Receiver: 
                  null
            Pattern: 
              IDeclarationPatternOperation (OperationKind.DeclarationPattern, Type: null) (Syntax: 'var x') (InputType: ?, NarrowedType: ?, DeclaredSymbol: ?? x, MatchesNull: True)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,75790,75880);

f_22043_75790_75879(compilation, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22043,73845,75891);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22043,73845,75891);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22043,73845,75891);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow, CompilerFeature.Patterns)]
        [Fact]
        public void IsPattern_ControlFlowInPattern()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22043,75903,79483);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,76093,76233);

string 
source = @"
class C
{
    void M(int? x, bool b)
    /*<bind>*/
    {
        b = x is (true ? 1 : 0);
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,76247,79291);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'b')
              Value: 
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'x')
              Value: 
                IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'x')

        Jump if False (Regular) to Block[B3]
            ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')

        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '1')
              Value: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

        Next (Regular) Block[B4]
    Block[B3] - Block [UnReachable]
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '0')
              Value: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')

        Next (Regular) Block[B4]
    Block[B4] - Block
        Predecessors: [B2] [B3]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'b = x is (true ? 1 : 0);')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'b = x is (true ? 1 : 0)')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Boolean, IsImplicit) (Syntax: 'b')
                  Right: 
                    IIsPatternOperation (OperationKind.IsPattern, Type: System.Boolean) (Syntax: 'x is (true ? 1 : 0)')
                      Value: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'x')
                      Pattern: 
                        IConstantPatternOperation (OperationKind.ConstantPattern, Type: null) (Syntax: '(true ? 1 : 0)') (InputType: System.Int32?, NarrowedType: System.Int32)
                          Value: 
                            IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, Constant: 1, IsImplicit) (Syntax: 'true ? 1 : 0')

        Next (Regular) Block[B5]
            Leaving: {R1}
}

Block[B5] - Exit
    Predecessors: [B4]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,79305,79358);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,79374,79472);

f_22043_79374_79471(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22043,75903,79483);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22043,75903,79483);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22043,75903,79483);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow, CompilerFeature.Patterns)]
        [Fact]
        public void IsPattern_ControlFlowInPattern_02()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22043,79495,84968);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,79688,79853);

string 
source = @"
class C
{
    void M((int, int) x, bool b)
    /*<bind>*/
    {
        b = x is ((true ? 1 : 2), (false ? 3 : 4));
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,79867,84776);

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
        Statements (2)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'b')
              Value: 
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'x')
              Value: 
                IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: (System.Int32, System.Int32)) (Syntax: 'x')

        Jump if False (Regular) to Block[B3]
            ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')

        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '1')
              Value: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

        Next (Regular) Block[B4]
    Block[B3] - Block [UnReachable]
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '2')
              Value: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')

        Next (Regular) Block[B4]
    Block[B4] - Block
        Predecessors: [B2] [B3]
        Statements (0)
        Jump if False (Regular) to Block[B6]
            ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')

        Next (Regular) Block[B5]
    Block[B5] - Block [UnReachable]
        Predecessors: [B4]
        Statements (1)
            IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '3')
              Value: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')

        Next (Regular) Block[B7]
    Block[B6] - Block
        Predecessors: [B4]
        Statements (1)
            IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '4')
              Value: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 4) (Syntax: '4')

        Next (Regular) Block[B7]
    Block[B7] - Block
        Predecessors: [B5] [B6]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'b = x is (( ...  ? 3 : 4));')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'b = x is (( ... e ? 3 : 4))')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Boolean, IsImplicit) (Syntax: 'b')
                  Right: 
                    IIsPatternOperation (OperationKind.IsPattern, Type: System.Boolean) (Syntax: 'x is ((true ... e ? 3 : 4))')
                      Value: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: (System.Int32, System.Int32), IsImplicit) (Syntax: 'x')
                      Pattern: 
                        IRecursivePatternOperation (OperationKind.RecursivePattern, Type: null) (Syntax: '((true ? 1  ... e ? 3 : 4))') (InputType: (System.Int32, System.Int32), NarrowedType: (System.Int32, System.Int32), DeclaredSymbol: null, MatchedType: (System.Int32, System.Int32), DeconstructSymbol: null)
                          DeconstructionSubpatterns (2):
                              IConstantPatternOperation (OperationKind.ConstantPattern, Type: null) (Syntax: '(true ? 1 : 2)') (InputType: System.Int32, NarrowedType: System.Int32)
                                Value: 
                                  IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, Constant: 1, IsImplicit) (Syntax: 'true ? 1 : 2')
                              IConstantPatternOperation (OperationKind.ConstantPattern, Type: null) (Syntax: '(false ? 3 : 4)') (InputType: System.Int32, NarrowedType: System.Int32)
                                Value: 
                                  IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Int32, Constant: 4, IsImplicit) (Syntax: 'false ? 3 : 4')
                          PropertySubpatterns (0)

        Next (Regular) Block[B8]
            Leaving: {R1}
}

Block[B8] - Exit
    Predecessors: [B7]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,84790,84843);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,84859,84957);

f_22043_84859_84956(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22043,79495,84968);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22043,79495,84968);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22043,79495,84968);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow, CompilerFeature.Patterns)]
        [Fact]
        public void IsPattern_ControlFlowInValueAndPattern()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22043,84980,90348);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,85178,85336);

string 
source = @"
class C
{
    void M(int? x1, int x2, bool b)
    /*<bind>*/
    {
        b = (x1 ?? x2) is (true ? 1 : 0);
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,85350,90156);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'b')
              Value: 
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

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
        Statements (0)
        Jump if False (Regular) to Block[B7]
            ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')

        Next (Regular) Block[B6]
    Block[B6] - Block
        Predecessors: [B5]
        Statements (1)
            IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '1')
              Value: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

        Next (Regular) Block[B8]
    Block[B7] - Block [UnReachable]
        Predecessors: [B5]
        Statements (1)
            IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '0')
              Value: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')

        Next (Regular) Block[B8]
    Block[B8] - Block
        Predecessors: [B6] [B7]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'b = (x1 ??  ... e ? 1 : 0);')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'b = (x1 ??  ... ue ? 1 : 0)')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Boolean, IsImplicit) (Syntax: 'b')
                  Right: 
                    IIsPatternOperation (OperationKind.IsPattern, Type: System.Boolean) (Syntax: '(x1 ?? x2)  ... ue ? 1 : 0)')
                      Value: 
                        IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'x1 ?? x2')
                      Pattern: 
                        IConstantPatternOperation (OperationKind.ConstantPattern, Type: null) (Syntax: '(true ? 1 : 0)') (InputType: System.Int32, NarrowedType: System.Int32)
                          Value: 
                            IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Int32, Constant: 1, IsImplicit) (Syntax: 'true ? 1 : 0')

        Next (Regular) Block[B9]
            Leaving: {R1}
}

Block[B9] - Exit
    Predecessors: [B8]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,90170,90223);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,90239,90337);

f_22043_90239_90336(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22043,84980,90348);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22043,84980,90348);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22043,84980,90348);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void TestIsPatternExpression_PatternCombinatorsAndRelationalPatterns_01()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22043,90360,93350);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,90534,90688);

string 
source = @"
class X
{
    void M(char c)
    {
        _ = /*<bind>*/c is (>= 'A' and <= 'Z') or (>= 'a' and <= 'z')/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,90702,93079);

string 
expectedOperationTree = @"
    IIsPatternOperation (OperationKind.IsPattern, Type: System.Boolean) (Syntax: 'c is (>= 'A ... and <= 'z')')
      Value: 
        IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: System.Char) (Syntax: 'c')
      Pattern: 
        IBinaryPatternOperation (BinaryOperatorKind.Or) (OperationKind.BinaryPattern, Type: null) (Syntax: '(>= 'A' and ... and <= 'z')') (InputType: System.Char, NarrowedType: System.Char)
          LeftPattern: 
            IBinaryPatternOperation (BinaryOperatorKind.And) (OperationKind.BinaryPattern, Type: null) (Syntax: '>= 'A' and <= 'Z'') (InputType: System.Char, NarrowedType: System.Char)
              LeftPattern: 
                IRelationalPatternOperation (BinaryOperatorKind.GreaterThanOrEqual) (OperationKind.RelationalPattern, Type: null) (Syntax: '>= 'A'') (InputType: System.Char, NarrowedType: System.Char)
                  Value: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Char, Constant: A) (Syntax: ''A'')
              RightPattern: 
                IRelationalPatternOperation (BinaryOperatorKind.LessThanOrEqual) (OperationKind.RelationalPattern, Type: null) (Syntax: '<= 'Z'') (InputType: System.Char, NarrowedType: System.Char)
                  Value: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Char, Constant: Z) (Syntax: ''Z'')
          RightPattern: 
            IBinaryPatternOperation (BinaryOperatorKind.And) (OperationKind.BinaryPattern, Type: null) (Syntax: '>= 'a' and <= 'z'') (InputType: System.Char, NarrowedType: System.Char)
              LeftPattern: 
                IRelationalPatternOperation (BinaryOperatorKind.GreaterThanOrEqual) (OperationKind.RelationalPattern, Type: null) (Syntax: '>= 'a'') (InputType: System.Char, NarrowedType: System.Char)
                  Value: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Char, Constant: a) (Syntax: ''a'')
              RightPattern: 
                IRelationalPatternOperation (BinaryOperatorKind.LessThanOrEqual) (OperationKind.RelationalPattern, Type: null) (Syntax: '<= 'z'') (InputType: System.Char, NarrowedType: System.Char)
                  Value: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Char, Constant: z) (Syntax: ''z'')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,93093,93146);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,93162,93339);

f_22043_93162_93338(source, expectedOperationTree, expectedDiagnostics, parseOptions: TestOptions.RegularWithPatternCombinators);
DynAbs.Tracing.TraceSender.TraceExitMethod(22043,90360,93350);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22043,90360,93350);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22043,90360,93350);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void TestIsPatternExpression_TypePatterns_01()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22043,93362,95230);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,93509,93642);

string 
source = @"
class X
{
    void M(object o)
    {
        _ = /*<bind>*/o is int or long or bool/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,93656,94959);

string 
expectedOperationTree = @"
    IIsPatternOperation (OperationKind.IsPattern, Type: System.Boolean) (Syntax: 'o is int or long or bool')
      Value: 
        IParameterReferenceOperation: o (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'o')
      Pattern: 
        IBinaryPatternOperation (BinaryOperatorKind.Or) (OperationKind.BinaryPattern, Type: null) (Syntax: 'int or long or bool') (InputType: System.Object, NarrowedType: System.Object)
          LeftPattern: 
            IBinaryPatternOperation (BinaryOperatorKind.Or) (OperationKind.BinaryPattern, Type: null) (Syntax: 'int or long') (InputType: System.Object, NarrowedType: System.Object)
              LeftPattern: 
                ITypePatternOperation (OperationKind.TypePattern, Type: null) (Syntax: 'int') (InputType: System.Object, NarrowedType: System.Int32, MatchedType: System.Int32)
              RightPattern: 
                ITypePatternOperation (OperationKind.TypePattern, Type: null) (Syntax: 'long') (InputType: System.Object, NarrowedType: System.Int64, MatchedType: System.Int64)
          RightPattern: 
            ITypePatternOperation (OperationKind.TypePattern, Type: null) (Syntax: 'bool') (InputType: System.Object, NarrowedType: System.Boolean, MatchedType: System.Boolean)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,94973,95026);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22043,95042,95219);

f_22043_95042_95218(source, expectedOperationTree, expectedDiagnostics, parseOptions: TestOptions.RegularWithPatternCombinators);
DynAbs.Tracing.TraceSender.TraceExitMethod(22043,93362,95230);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22043,93362,95230);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22043,93362,95230);
}
		}

public IOperationTests_Patterns()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(22043,539,95237);
DynAbs.Tracing.TraceSender.TraceExitConstructor(22043,539,95237);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22043,539,95237);
}


static IOperationTests_Patterns()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(22043,539,95237);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(22043,539,95237);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22043,539,95237);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(22043,539,95237);

int
f_22043_1596_1715(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<IsPatternExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 1596, 1715);
return 0;
}


int
f_22043_2719_2838(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<IsPatternExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 2719, 2838);
return 0;
}


int
f_22043_3779_3898(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<IsPatternExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 3779, 3898);
return 0;
}


int
f_22043_4861_4980(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<IsPatternExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 4861, 4980);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_6150_6205(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 6150, 6205);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_6150_6225(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 6150, 6225);
return return_v;
}


int
f_22043_6257_6376(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<IsPatternExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 6257, 6376);
return 0;
}


int
f_22043_7420_7539(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<IsPatternExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 7420, 7539);
return 0;
}


int
f_22043_8941_9060(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<IsPatternExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 8941, 9060);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_10733_10785(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 10733, 10785);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_10733_10817(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 10733, 10817);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_10733_10837(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 10733, 10837);
return return_v;
}


int
f_22043_10869_10988(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<IsPatternExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 10869, 10988);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_12616_12665(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 12616, 12665);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_12616_12686(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 12616, 12686);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_12616_12706(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 12616, 12706);
return return_v;
}


int
f_22043_12738_12857(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<IsPatternExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 12738, 12857);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_14170_14235(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 14170, 14235);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_14170_14266(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 14170, 14266);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_14170_14286(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 14170, 14286);
return return_v;
}


int
f_22043_14318_14437(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<IsPatternExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 14318, 14437);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_15689_15736(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 15689, 15736);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_15689_15756(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 15689, 15756);
return return_v;
}


int
f_22043_15788_15904(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<BinaryExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 15788, 15904);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_17092_17139(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 17092, 17139);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_17092_17166(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 17092, 17166);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_17092_17186(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 17092, 17186);
return return_v;
}


int
f_22043_17218_17337(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<IsPatternExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 17218, 17337);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_18565_18610(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 18565, 18610);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_18565_18629(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 18565, 18629);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_18565_18649(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 18565, 18649);
return return_v;
}


int
f_22043_18681_18800(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<IsPatternExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 18681, 18800);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_19965_20014(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 19965, 20014);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_19965_20034(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 19965, 20034);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_20201_20247(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 20201, 20247);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_20201_20266(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 20201, 20266);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_20201_20286(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 20201, 20286);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_20436_20484(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 20436, 20484);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_20436_20504(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 20436, 20504);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_20654_20699(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 20654, 20699);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_20654_20719(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 20654, 20719);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_20869_20917(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 20869, 20917);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_20869_20937(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 20869, 20937);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_21087_21132(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 21087, 21132);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_21087_21152(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 21087, 21152);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_21343_21391(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 21343, 21391);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_21343_21411(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 21343, 21411);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_21343_21431(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 21343, 21431);
return return_v;
}


int
f_22043_21463_21582(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<IsPatternExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 21463, 21582);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_22615_22665(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 22615, 22665);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_22615_22688(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 22615, 22688);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_22615_22708(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 22615, 22708);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_22892_22945(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 22892, 22945);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_22892_22965(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 22892, 22965);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_23184_23233(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 23184, 23233);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_23184_23253(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 23184, 23253);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_23437_23485(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 23437, 23485);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_23437_23505(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 23437, 23505);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_23689_23734(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 23689, 23734);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_23689_23754(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 23689, 23754);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_23991_24047(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 23991, 24047);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_23991_24067(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 23991, 24067);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_24291_24338(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 24291, 24338);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_24291_24357(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 24291, 24357);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_24291_24377(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 24291, 24377);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_24596_24642(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 24596, 24642);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_24596_24661(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 24596, 24661);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_24596_24681(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 24596, 24681);
return return_v;
}


int
f_22043_24713_24829(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<BinaryExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 24713, 24829);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_26138_26218(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 26138, 26218);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_26138_26237(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 26138, 26237);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_26138_26257(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 26138, 26257);
return return_v;
}


int
f_22043_26289_26408(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<IsPatternExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 26289, 26408);
return 0;
}


int
f_22043_27456_27575(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<IsPatternExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 27456, 27575);
return 0;
}


int
f_22043_28591_28710(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<IsPatternExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 28591, 28710);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_30039_30090(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 30039, 30090);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_30039_30121(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 30039, 30121);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_30039_30142(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 30039, 30142);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_30387_30468(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 30387, 30468);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_30387_30488(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 30387, 30488);
return return_v;
}


int
f_22043_30520_30639(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<IsPatternExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 30520, 30639);
return 0;
}


int
f_22043_33533_33630(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 33533, 33630);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22043_34030_34055(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 34030, 34055);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22043_34070_34101(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 34070, 34101);
return return_v;
}


Microsoft.CodeAnalysis.IOperation
f_22043_36784_36859(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOperationTree)
{
var return_v = VerifyOperationTreeForTest<BlockSyntax>( compilation, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 36784, 36859);
return return_v;
}


int
f_22043_39974_40041(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 39974, 40041);
return 0;
}


int
f_22043_47066_47163(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 47066, 47163);
return 0;
}


int
f_22043_51301_51398(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 51301, 51398);
return 0;
}


int
f_22043_53855_53974(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<IsPatternExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 53855, 53974);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_56404_56454(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 56404, 56454);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_56404_56498(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 56404, 56498);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_56404_56518(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 56404, 56518);
return return_v;
}


int
f_22043_56550_56669(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<IsPatternExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 56550, 56669);
return 0;
}


Microsoft.CodeAnalysis.VisualBasic.VisualBasicCompilation
f_22043_57099_57137(Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests_Patterns
this_param,string
code)
{
var return_v = this_param.CreateVisualBasicCompilation( code);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 57099, 57137);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_22043_57361_57397(Microsoft.CodeAnalysis.VisualBasic.VisualBasicCompilation
comp)
{
var return_v = comp.EmitToImageReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 57361, 57397);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22043_57327_57436(string
source,Microsoft.CodeAnalysis.MetadataReference[]
references,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
parseOptions)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, parseOptions:parseOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 57327, 57436);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_57717_57783(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 57717, 57783);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_57717_57820(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 57717, 57820);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_57717_57840(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 57717, 57840);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_58090_58153(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 58090, 58153);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_58090_58178(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 58090, 58178);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_58090_58198(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 58090, 58198);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_58455_58511(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 58455, 58511);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_58455_58533(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 58455, 58533);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_58455_58553(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 58455, 58553);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_58795_58850(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 58795, 58850);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_58795_58870(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 58795, 58870);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_59039_59081(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 59039, 59081);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_59039_59105(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 59039, 59105);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_59039_59125(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 59039, 59125);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_59294_59338(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 59294, 59338);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_59294_59361(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 59294, 59361);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_59294_59381(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 59294, 59381);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22043_57451_59382(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 57451, 59382);
return return_v;
}


Microsoft.CodeAnalysis.IOperation
f_22043_60963_61052(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOperationTree)
{
var return_v = VerifyOperationTreeForTest<IsPatternExpressionSyntax>( compilation, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 60963, 61052);
return return_v;
}


Microsoft.CodeAnalysis.VisualBasic.VisualBasicCompilation
f_22043_61482_61520(Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests_Patterns
this_param,string
code)
{
var return_v = this_param.CreateVisualBasicCompilation( code);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 61482, 61520);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_22043_61741_61777(Microsoft.CodeAnalysis.VisualBasic.VisualBasicCompilation
comp)
{
var return_v = comp.EmitToImageReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 61741, 61777);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22043_61707_61780(string
source,Microsoft.CodeAnalysis.MetadataReference[]
references)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 61707, 61780);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_62059_62109(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 62059, 62109);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_62059_62131(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 62059, 62131);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_62059_62151(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 62059, 62151);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22043_61795_62152(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 61795, 62152);
return return_v;
}


Microsoft.CodeAnalysis.IOperation
f_22043_63238_63327(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOperationTree)
{
var return_v = VerifyOperationTreeForTest<IsPatternExpressionSyntax>( compilation, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 63238, 63327);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22043_63727_63752(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 63727, 63752);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_64024_64071(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 64024, 64071);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_64024_64090(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 64024, 64090);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_64024_64110(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 64024, 64110);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_64258_64306(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 64258, 64306);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_64258_64327(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 64258, 64327);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_64258_64348(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 64258, 64348);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22043_63767_64367(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 63767, 64367);
return return_v;
}


Microsoft.CodeAnalysis.IOperation
f_22043_65437_65526(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOperationTree)
{
var return_v = VerifyOperationTreeForTest<IsPatternExpressionSyntax>( compilation, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 65437, 65526);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22043_65916_65941(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 65916, 65941);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_66213_66260(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 66213, 66260);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_66213_66279(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 66213, 66279);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_66213_66299(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 66213, 66299);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22043_65956_66318(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 65956, 66318);
return return_v;
}


Microsoft.CodeAnalysis.IOperation
f_22043_67388_67477(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOperationTree)
{
var return_v = VerifyOperationTreeForTest<IsPatternExpressionSyntax>( compilation, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 67388, 67477);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22043_67866_67891(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 67866, 67891);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_68140_68187(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 68140, 68187);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_68140_68213(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 68140, 68213);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_68140_68233(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 68140, 68233);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_68461_68508(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 68461, 68508);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_68461_68527(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 68461, 68527);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_68461_68547(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 68461, 68547);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22043_67906_68566(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 67906, 68566);
return return_v;
}


Microsoft.CodeAnalysis.IOperation
f_22043_69636_69725(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOperationTree)
{
var return_v = VerifyOperationTreeForTest<IsPatternExpressionSyntax>( compilation, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 69636, 69725);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22043_70119_70144(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 70119, 70144);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_70419_70466(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 70419, 70466);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_70419_70487(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 70419, 70487);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_70419_70507(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 70419, 70507);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22043_70159_70526(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 70159, 70526);
return return_v;
}


Microsoft.CodeAnalysis.IOperation
f_22043_71690_71779(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOperationTree)
{
var return_v = VerifyOperationTreeForTest<IsPatternExpressionSyntax>( compilation, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 71690, 71779);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22043_72174_72199(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 72174, 72199);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_72474_72521(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 72474, 72521);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_72474_72542(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 72474, 72542);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_72474_72562(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 72474, 72562);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22043_72214_72581(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 72214, 72581);
return return_v;
}


Microsoft.CodeAnalysis.IOperation
f_22043_73732_73821(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOperationTree)
{
var return_v = VerifyOperationTreeForTest<IsPatternExpressionSyntax>( compilation, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 73732, 73821);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22043_74217_74242(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 74217, 74242);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_74517_74564(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 74517, 74564);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_74517_74585(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 74517, 74585);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22043_74517_74605(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 74517, 74605);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22043_74257_74624(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 74257, 74624);
return return_v;
}


Microsoft.CodeAnalysis.IOperation
f_22043_75790_75879(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOperationTree)
{
var return_v = VerifyOperationTreeForTest<IsPatternExpressionSyntax>( compilation, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 75790, 75879);
return return_v;
}


int
f_22043_79374_79471(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 79374, 79471);
return 0;
}


int
f_22043_84859_84956(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 84859, 84956);
return 0;
}


int
f_22043_90239_90336(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 90239, 90336);
return 0;
}


int
f_22043_93162_93338(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
parseOptions)
{
VerifyOperationTreeAndDiagnosticsForTest<IsPatternExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics, parseOptions:parseOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 93162, 93338);
return 0;
}


int
f_22043_95042_95218(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
parseOptions)
{
VerifyOperationTreeAndDiagnosticsForTest<IsPatternExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics, parseOptions:parseOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22043, 95042, 95218);
return 0;
}

}
}
