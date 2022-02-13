// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp.Test.Utilities;
using Microsoft.CodeAnalysis.Test.Utilities;
using Roslyn.Test.Utilities;
using System.Linq;
using Xunit;

namespace Microsoft.CodeAnalysis.CSharp.UnitTests
{
public partial class IOperationTests : SemanticModelTestBase
{
[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17598, "https://github.com/dotnet/roslyn/issues/17598")]
        public void InvalidInvocationExpression_BadReceiver()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22054,574,1839);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,787,950);

string 
source = @"
using System;

class Program
{
    static void Main(string[] args)
    {
        /*<bind>*/Console.WriteLine2()/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,964,1314);

string 
expectedOperationTree = @"
IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid) (Syntax: 'Console.WriteLine2()')
  Children(1):
      IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid) (Syntax: 'Console.WriteLine2')
        Children(1):
            IOperation:  (OperationKind.None, Type: null) (Syntax: 'Console')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,1328,1691);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22054_1557_1675(f_22054_1557_1655(f_22054_1557_1609(ErrorCode.ERR_NoSuchMember, "WriteLine2"), "System.Console", "WriteLine2"), 8, 27)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,1707,1828);

f_22054_1707_1827(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22054,574,1839);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22054,574,1839);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22054,574,1839);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17598, "https://github.com/dotnet/roslyn/issues/17598")]
        public void InvalidInvocationExpression_OverloadResolutionFailureBadArgument()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22054,1851,3162);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,2089,2282);

string 
source = @"
using System;

class Program
{
    static void Main(string[] args)
    {
        /*<bind>*/F(string.Empty)/*</bind>*/;
    }

    void F(int x)
    {
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,2296,2659);

string 
expectedOperationTree = @"
IInvalidOperation (OperationKind.Invalid, Type: System.Void, IsInvalid) (Syntax: 'F(string.Empty)')
  Children(1):
      IFieldReferenceOperation: System.String System.String.Empty (Static) (OperationKind.FieldReference, Type: System.String, IsInvalid) (Syntax: 'string.Empty')
        Instance Receiver: 
          null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,2673,3014);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22054_2890_2998(f_22054_2890_2978(f_22054_2890_2942(ErrorCode.ERR_BadArgType, "string.Empty"), "1", "string", "int"), 8, 21)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,3030,3151);

f_22054_3030_3150(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22054,1851,3162);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22054,1851,3162);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22054,1851,3162);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17598, "https://github.com/dotnet/roslyn/issues/17598")]
        public void InvalidInvocationExpression_OverloadResolutionFailureExtraArgument()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22054,3174,4444);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,3414,3602);

string 
source = @"
using System;

class Program
{
    static void Main(string[] args)
    {
        /*<bind>*/F(string.Empty)/*</bind>*/;
    }

    void F()
    {
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,3616,3968);

string 
expectedOperationTree = @"
IInvalidOperation (OperationKind.Invalid, Type: System.Void, IsInvalid) (Syntax: 'F(string.Empty)')
  Children(1):
      IFieldReferenceOperation: System.String System.String.Empty (Static) (OperationKind.FieldReference, Type: System.String) (Syntax: 'string.Empty')
        Instance Receiver: 
          null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,3982,4296);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22054_4194_4280(f_22054_4194_4260(f_22054_4194_4236(ErrorCode.ERR_BadArgCount, "F"), "F", "1"), 8, 19)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,4312,4433);

f_22054_4312_4432(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22054,3174,4444);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22054,3174,4444);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22054,3174,4444);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17598, "https://github.com/dotnet/roslyn/issues/17598")]
        public void InvalidFieldReferenceExpression()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22054,4456,6127);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,4661,4888);

string 
source = @"
using System;

class Program
{
    static void Main(string[] args)
    {
        var x = new Program();
        var /*<bind>*/y = x.MissingField/*</bind>*/;
    }

    void F()
    {
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,4902,5431);

string 
expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: ? y) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'y = x.MissingField')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '= x.MissingField')
      IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid) (Syntax: 'x.MissingField')
        Children(1):
            ILocalReferenceOperation: x (OperationKind.LocalReference, Type: Program) (Syntax: 'x')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,5445,5981);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22054_5839_5965(f_22054_5839_5945(f_22054_5839_5904(ErrorCode.ERR_NoSuchMemberOrExtension, "MissingField"), "Program", "MissingField"), 9, 29)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,5997,6116);

f_22054_5997_6115(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22054,4456,6127);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22054,4456,6127);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22054,4456,6127);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17598, "https://github.com/dotnet/roslyn/issues/17598")]
        public void InvalidConversionExpression_ImplicitCast()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22054,6139,8676);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,6353,6586);

string 
source = @"
using System;

class Program
{
    int i1;
    static void Main(string[] args)
    {
        var x = new Program();
        /*<bind>*/string y = x.i1;/*</bind>*/
    }

    void F()
    {
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,6600,7909);

string 
expectedOperationTree = @"
IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsInvalid) (Syntax: 'string y = x.i1;')
  IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null, IsInvalid) (Syntax: 'string y = x.i1')
    Declarators:
        IVariableDeclaratorOperation (Symbol: System.String y) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'y = x.i1')
          Initializer: 
            IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '= x.i1')
              IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.String, IsInvalid, IsImplicit) (Syntax: 'x.i1')
                Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                Operand: 
                  IFieldReferenceOperation: System.Int32 Program.i1 (OperationKind.FieldReference, Type: System.Int32, IsInvalid) (Syntax: 'x.i1')
                    Instance Receiver: 
                      ILocalReferenceOperation: x (OperationKind.LocalReference, Type: Program, IsInvalid) (Syntax: 'x')
    Initializer: 
      null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,7923,8523);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22054_8139_8239(f_22054_8139_8218(f_22054_8139_8187(ErrorCode.ERR_NoImplicitConv, "x.i1"), "int", "string"), 10, 30),
f_22054_8400_8507(f_22054_8400_8488(f_22054_8400_8455(ErrorCode.WRN_UnassignedInternalField, "i1"), "Program.i1", "0"), 6, 9)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,8539,8665);

f_22054_8539_8664(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22054,6139,8676);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22054,6139,8676);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22054,6139,8676);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17598, "https://github.com/dotnet/roslyn/issues/17598")]
        public void InvalidConversionExpression_ExplicitCast()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22054,8688,11271);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,8902,9145);

string 
source = @"
using System;

class Program
{
    int i1;
    static void Main(string[] args)
    {
        var x = new Program();
        /*<bind>*/Program y = (Program)x.i1;/*</bind>*/
    }

    void F()
    {
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,9159,10494);

string 
expectedOperationTree = @"
IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsInvalid) (Syntax: 'Program y = ... ogram)x.i1;')
  IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null, IsInvalid) (Syntax: 'Program y = ... rogram)x.i1')
    Declarators:
        IVariableDeclaratorOperation (Symbol: Program y) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'y = (Program)x.i1')
          Initializer: 
            IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '= (Program)x.i1')
              IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: Program, IsInvalid) (Syntax: '(Program)x.i1')
                Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                Operand: 
                  IFieldReferenceOperation: System.Int32 Program.i1 (OperationKind.FieldReference, Type: System.Int32, IsInvalid) (Syntax: 'x.i1')
                    Instance Receiver: 
                      ILocalReferenceOperation: x (OperationKind.LocalReference, Type: Program, IsInvalid) (Syntax: 'x')
    Initializer: 
      null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,10508,11118);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22054_10724_10834(f_22054_10724_10813(f_22054_10724_10781(ErrorCode.ERR_NoExplicitConv, "(Program)x.i1"), "int", "Program"), 10, 31),
f_22054_10995_11102(f_22054_10995_11083(f_22054_10995_11050(ErrorCode.WRN_UnassignedInternalField, "i1"), "Program.i1", "0"), 6, 9)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,11134,11260);

f_22054_11134_11259(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22054,8688,11271);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22054,8688,11271);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22054,8688,11271);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17598, "https://github.com/dotnet/roslyn/issues/17598")]
        public void InvalidUnaryExpression()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22054,11283,12476);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,11479,11702);

string 
source = @"
using System;

class Program
{
    static void Main(string[] args)
    {
        var x = new Program();
        Console.Write(/*<bind>*/++x/*</bind>*/);
    }

    void F()
    {
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,11716,11972);

string 
expectedOperationTree = @"
IIncrementOrDecrementOperation (Prefix) (OperationKind.Increment, Type: ?, IsInvalid) (Syntax: '++x')
  Target: 
    ILocalReferenceOperation: x (OperationKind.LocalReference, Type: Program, IsInvalid) (Syntax: 'x')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,11986,12327);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22054_12217_12311(f_22054_12217_12291(f_22054_12217_12260(ErrorCode.ERR_BadUnaryOp, "++x"), "++", "Program"), 9, 33)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,12343,12465);

f_22054_12343_12464(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22054,11283,12476);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22054,11283,12476);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22054,11283,12476);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17598, "https://github.com/dotnet/roslyn/issues/17598")]
        public void InvalidBinaryExpression()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22054,12488,14282);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,12685,12926);

string 
source = @"
using System;

class Program
{
    static void Main(string[] args)
    {
        var x = new Program();
        Console.Write(/*<bind>*/x + (y * args.Length)/*</bind>*/);
    }

    void F()
    {
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,12940,13783);

string 
expectedOperationTree = @"
IBinaryOperation (BinaryOperatorKind.Add) (OperationKind.Binary, Type: ?, IsInvalid) (Syntax: 'x + (y * args.Length)')
  Left: 
    ILocalReferenceOperation: x (OperationKind.LocalReference, Type: Program) (Syntax: 'x')
  Right: 
    IBinaryOperation (BinaryOperatorKind.Multiply) (OperationKind.Binary, Type: ?, IsInvalid) (Syntax: 'y * args.Length')
      Left: 
        IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid) (Syntax: 'y')
          Children(0)
      Right: 
        IPropertyReferenceOperation: System.Int32 System.Array.Length { get; } (OperationKind.PropertyReference, Type: System.Int32) (Syntax: 'args.Length')
          Instance Receiver: 
            IParameterReferenceOperation: args (OperationKind.ParameterReference, Type: System.String[]) (Syntax: 'args')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,13797,14138);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22054_14036_14122(f_22054_14036_14102(f_22054_14036_14083(ErrorCode.ERR_NameNotInContext, "y"), "y"), 9, 38)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,14154,14271);

f_22054_14154_14270(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22054,12488,14282);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22054,12488,14282);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22054,12488,14282);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17598, "https://github.com/dotnet/roslyn/issues/17598")]
        public void InvalidLambdaBinding_UnboundLambda()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22054,14294,16189);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,14502,14699);

string 
source = @"
using System;

class Program
{
    static void Main(string[] args)
    {
        var /*<bind>*/x = () => F()/*</bind>*/;
    }

    static void F()
    {
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,14713,15643);

string 
expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: var x) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'x = () => F()')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '= () => F()')
      IAnonymousFunctionOperation (Symbol: lambda expression) (OperationKind.AnonymousFunction, Type: null, IsInvalid) (Syntax: '() => F()')
        IBlockOperation (1 statements) (OperationKind.Block, Type: null, IsInvalid, IsImplicit) (Syntax: 'F()')
          IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid, IsImplicit) (Syntax: 'F()')
            Expression: 
              IInvocationOperation (void Program.F()) (OperationKind.Invocation, Type: System.Void, IsInvalid) (Syntax: 'F()')
                Instance Receiver: 
                  null
                Arguments(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,15657,16043);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22054_15890_16027(f_22054_15890_16007(f_22054_15890_15972(ErrorCode.ERR_ImplicitlyTypedVariableAssignedBadValue, "x = () => F()"), "lambda expression"), 8, 23)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,16059,16178);

f_22054_16059_16177(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22054,14294,16189);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22054,14294,16189);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22054,14294,16189);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17598, "https://github.com/dotnet/roslyn/issues/17598")]
        public void InvalidLambdaBinding_LambdaExpression()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22054,16201,17807);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,16412,16609);

string 
source = @"
using System;

class Program
{
    static void Main(string[] args)
    {
        var x = /*<bind>*/() => F()/*</bind>*/;
    }

    static void F()
    {
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,16623,17240);

string 
expectedOperationTree = @"
IAnonymousFunctionOperation (Symbol: lambda expression) (OperationKind.AnonymousFunction, Type: null, IsInvalid) (Syntax: '() => F()')
  IBlockOperation (1 statements) (OperationKind.Block, Type: null, IsInvalid, IsImplicit) (Syntax: 'F()')
    IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid, IsImplicit) (Syntax: 'F()')
      Expression: 
        IInvocationOperation (void Program.F()) (OperationKind.Invocation, Type: System.Void, IsInvalid) (Syntax: 'F()')
          Instance Receiver: 
            null
          Arguments(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,17254,17650);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22054_17487_17634(f_22054_17487_17614(f_22054_17487_17579(ErrorCode.ERR_ImplicitlyTypedVariableAssignedBadValue, "x = /*<bind>*/() => F()"), "lambda expression"), 8, 13)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,17666,17796);

f_22054_17666_17795(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22054,16201,17807);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22054,16201,17807);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22054,16201,17807);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17598, "https://github.com/dotnet/roslyn/issues/17598")]
        public void InvalidFieldInitializer()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22054,17819,19694);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,18016,18201);

string 
source = @"
class Program
{
    int x /*<bind>*/= Program/*</bind>*/;
    static void Main(string[] args)
    {
        var x = new Program() { x = Program };
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,18215,18916);

string 
expectedOperationTree = @"
IFieldInitializerOperation (Field: System.Int32 Program.x) (OperationKind.FieldInitializer, Type: null, IsInvalid) (Syntax: '= Program')
  IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'Program')
    Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
    Operand: 
      IInvalidOperation (OperationKind.Invalid, Type: Program, IsInvalid, IsImplicit) (Syntax: 'Program')
        Children(1):
            IOperation:  (OperationKind.None, Type: null, IsInvalid) (Syntax: 'Program')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,18930,19549);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22054_19154_19256(f_22054_19154_19236(f_22054_19154_19203(ErrorCode.ERR_BadSKunknown, "Program"), "Program", "type"), 4, 23),
f_22054_19431_19533(f_22054_19431_19513(f_22054_19431_19480(ErrorCode.ERR_BadSKunknown, "Program"), "Program", "type"), 7, 37)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,19565,19683);

f_22054_19565_19682(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22054,17819,19694);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22054,17819,19694);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22054,17819,19694);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17598, "https://github.com/dotnet/roslyn/issues/17598")]
        public void InvalidArrayInitializer()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22054,19706,23347);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,19903,20077);

string 
source = @"
class Program
{
    static void Main(string[] args)
    {
        var x = new int[2, 2] /*<bind>*/{ { { 1, 1 } }, { 2, 2 } }/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,20091,22478);

string 
expectedOperationTree = @"
IArrayInitializerOperation (2 elements) (OperationKind.ArrayInitializer, Type: null, IsInvalid) (Syntax: '{ { { 1, 1  ...  { 2, 2 } }')
  Element Values(2):
      IArrayInitializerOperation (1 elements) (OperationKind.ArrayInitializer, Type: null, IsInvalid) (Syntax: '{ { 1, 1 } }')
        Element Values(1):
            IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: '{ 1, 1 }')
              Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
              Operand: 
                IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid, IsImplicit) (Syntax: '{ 1, 1 }')
                  Children(1):
                      IArrayInitializerOperation (2 elements) (OperationKind.ArrayInitializer, Type: null, IsInvalid) (Syntax: '{ 1, 1 }')
                        Element Values(2):
                            IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsInvalid, IsImplicit) (Syntax: '1')
                              Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                              Operand: 
                                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1, IsInvalid) (Syntax: '1')
                            IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsInvalid, IsImplicit) (Syntax: '1')
                              Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                              Operand: 
                                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1, IsInvalid) (Syntax: '1')
      IArrayInitializerOperation (2 elements) (OperationKind.ArrayInitializer, Type: null) (Syntax: '{ 2, 2 }')
        Element Values(2):
            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,22492,23198);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22054_22800_22877(f_22054_22800_22857(ErrorCode.ERR_ArrayInitInBadPlace, "{ 1, 1 }"), 6, 45),
f_22054_23070_23182(f_22054_23070_23162(f_22054_23070_23143(ErrorCode.ERR_ArrayInitializerIncorrectLength, "{ { 1, 1 } }"), "2"), 6, 43)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,23214,23336);

f_22054_23214_23335(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22054,19706,23347);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22054,19706,23347);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22054,19706,23347);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17598, "https://github.com/dotnet/roslyn/issues/17598")]
        public void InvalidArrayCreation()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22054,23359,26594);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,23553,23711);

string 
source = @"
class Program
{
    static void Main(string[] args)
    {
        var x = /*<bind>*/new X[Program] { { 1 } }/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,23725,25420);

string 
expectedOperationTree = @"
IArrayCreationOperation (OperationKind.ArrayCreation, Type: X[], IsInvalid) (Syntax: 'new X[Program] { { 1 } }')
  Dimension Sizes(1):
      IInvalidOperation (OperationKind.Invalid, Type: Program, IsInvalid, IsImplicit) (Syntax: 'Program')
        Children(1):
            IOperation:  (OperationKind.None, Type: null, IsInvalid) (Syntax: 'Program')
  Initializer: 
    IArrayInitializerOperation (1 elements) (OperationKind.ArrayInitializer, Type: null, IsInvalid) (Syntax: '{ { 1 } }')
      Element Values(1):
          IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: X, IsInvalid, IsImplicit) (Syntax: '{ 1 }')
            Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            Operand: 
              IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid, IsImplicit) (Syntax: '{ 1 }')
                Children(1):
                    IArrayInitializerOperation (1 elements) (OperationKind.ArrayInitializer, Type: null, IsInvalid) (Syntax: '{ 1 }')
                      Element Values(1):
                          IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsInvalid, IsImplicit) (Syntax: '1')
                            Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            Operand: 
                              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1, IsInvalid) (Syntax: '1')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,25434,26443);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22054_25730_25822(f_22054_25730_25802(f_22054_25730_25783(ErrorCode.ERR_SingleTypeNameNotFound, "X"), "X"), 6, 31),
f_22054_26013_26115(f_22054_26013_26095(f_22054_26013_26062(ErrorCode.ERR_BadSKunknown, "Program"), "Program", "type"), 6, 33),
f_22054_26353_26427(f_22054_26353_26407(ErrorCode.ERR_ArrayInitInBadPlace, "{ 1 }"), 6, 44)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,26459,26583);

f_22054_26459_26582(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22054,23359,26594);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22054,23359,26594);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22054,23359,26594);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17598, "https://github.com/dotnet/roslyn/issues/17598")]
        public void InvalidParameterDefaultValueInitializer()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22054,26606,27958);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,26819,27059);

string 
source = @"
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

class Program
{
    static int M() { return 0; }
    void F(int p /*<bind>*/= M()/*</bind>*/)
    {
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,27073,27454);

string 
expectedOperationTree = @"
IParameterInitializerOperation (Parameter: [System.Int32 p = default(System.Int32)]) (OperationKind.ParameterInitializer, Type: null, IsInvalid) (Syntax: '= M()')
  IInvocationOperation (System.Int32 Program.M()) (OperationKind.Invocation, Type: System.Int32, IsInvalid) (Syntax: 'M()')
    Instance Receiver: 
      null
    Arguments(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,27468,27813);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22054_27698_27797(f_22054_27698_27776(f_22054_27698_27757(ErrorCode.ERR_DefaultValueMustBeConstant, "M()"), "p"), 10, 30)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,27829,27947);

f_22054_27829_27946(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22054,26606,27958);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22054,26606,27958);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22054,26606,27958);
}
		}

[Fact]
        [CompilerTrait(CompilerFeature.IOperation)]
        [WorkItem(20050, "https://github.com/dotnet/roslyn/issues/20050")]
        public void BuildsArgumentsOperationsForDuplicateExplicitArguments_Repro()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22054,27970,29340);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,28214,28357);

string 
source = @"
public class C
{
    void M()
    {
        /*<bind>*/string.Format(format: """", format: """")/*</bind>*/;
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,28371,28819);

string 
expectedOperationTree = @"
IInvalidOperation (OperationKind.Invalid, Type: System.String, IsInvalid) (Syntax: 'string.Form ... format: """")')
  Children(3):
      IOperation:  (OperationKind.None, Type: null) (Syntax: 'string')
      ILiteralOperation (OperationKind.Literal, Type: System.String, Constant: """") (Syntax: '""""')
      ILiteralOperation (OperationKind.Literal, Type: System.String, Constant: """") (Syntax: '""""')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,28833,29329);

f_22054_28833_29328(source, expectedOperationTree, expectedDiagnostics: new DiagnosticDescription[]
            {
f_22054_29210_29312(f_22054_29210_29292(f_22054_29210_29268(ErrorCode.ERR_DuplicateNamedArgument, "format"), "format"), 6, 45)            });
DynAbs.Tracing.TraceSender.TraceExitMethod(22054,27970,29340);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22054,27970,29340);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22054,27970,29340);
}
		}

[Fact]
        [CompilerTrait(CompilerFeature.IOperation)]
        [WorkItem(20050, "https://github.com/dotnet/roslyn/issues/20050")]
        public void BuildsArgumentsOperationsForDuplicateExplicitArguments_CorrectArgumentsOrder_Methods()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22054,29352,30738);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,29620,29794);

string 
source = @"
public class C
{
    void N(int a, int b, int c = 4)
    {
    }

    void M()
    {
        /*<bind>*/N(a: 1, a: 2, b: 3)/*</bind>*/;
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,29808,30254);

string 
expectedOperationTree = @"
IInvalidOperation (OperationKind.Invalid, Type: System.Void, IsInvalid) (Syntax: 'N(a: 1, a: 2, b: 3)')
  Children(3):
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,30268,30727);

f_22054_30268_30726(source, expectedOperationTree, expectedDiagnostics: new DiagnosticDescription[]
            {
f_22054_30617_30710(f_22054_30617_30689(f_22054_30617_30670(ErrorCode.ERR_DuplicateNamedArgument, "a"), "a"), 10, 27)            });
DynAbs.Tracing.TraceSender.TraceExitMethod(22054,29352,30738);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22054,29352,30738);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22054,29352,30738);
}
		}

[Fact]
        [CompilerTrait(CompilerFeature.IOperation)]
        [WorkItem(20050, "https://github.com/dotnet/roslyn/issues/20050")]
        public void BuildsArgumentsOperationsForDuplicateExplicitArguments_CorrectArgumentsOrder_Delegates()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22054,30750,32269);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,31020,31204);

string 
source = @"
public delegate void D(int a, int b, int c = 4);
public class C
{
    void N(D lambda)
    {
        /*<bind>*/lambda(a: 1, a: 2, b: 3)/*</bind>*/;
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,31218,31776);

string 
expectedOperationTree = @"
IInvalidOperation (OperationKind.Invalid, Type: System.Void, IsInvalid) (Syntax: 'lambda(a: 1, a: 2, b: 3)')
  Children(4):
      IParameterReferenceOperation: lambda (OperationKind.ParameterReference, Type: D) (Syntax: 'lambda')
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,31790,32258);

f_22054_31790_32257(source, expectedOperationTree, expectedDiagnostics: new DiagnosticDescription[]
            {
f_22054_32149_32241(f_22054_32149_32221(f_22054_32149_32202(ErrorCode.ERR_DuplicateNamedArgument, "a"), "a"), 7, 32)            });
DynAbs.Tracing.TraceSender.TraceExitMethod(22054,30750,32269);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22054,30750,32269);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22054,30750,32269);
}
		}

[Fact]
        [CompilerTrait(CompilerFeature.IOperation)]
        [WorkItem(20050, "https://github.com/dotnet/roslyn/issues/20050")]
        public void BuildsArgumentsOperationsForDuplicateExplicitArguments_CorrectArgumentsOrder_Indexers_Getter()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22054,32281,33876);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,32557,32768);

string 
source = @"
public class C
{
    int this[int a, int b, int c = 4]
    {
        get => 0;
    }

    void M()
    {
        var result = /*<bind>*/this[a: 1, a: 2, b: 3]/*</bind>*/;
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,32782,33367);

string 
expectedOperationTree = @"
IInvalidOperation (OperationKind.Invalid, Type: System.Int32, IsInvalid) (Syntax: 'this[a: 1, a: 2, b: 3]')
  Children(4):
      IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C) (Syntax: 'this')
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,33381,33865);

f_22054_33381_33864(source, expectedOperationTree, expectedDiagnostics: new DiagnosticDescription[]
            {
f_22054_33755_33848(f_22054_33755_33827(f_22054_33755_33808(ErrorCode.ERR_DuplicateNamedArgument, "a"), "a"), 11, 43)            });
DynAbs.Tracing.TraceSender.TraceExitMethod(22054,32281,33876);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22054,32281,33876);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22054,32281,33876);
}
		}

[Fact]
        [CompilerTrait(CompilerFeature.IOperation)]
        [WorkItem(20050, "https://github.com/dotnet/roslyn/issues/20050")]
        public void BuildsArgumentsOperationsForDuplicateExplicitArguments_CorrectArgumentsOrder_Indexers_Setter()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22054,33888,35462);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,34164,34363);

string 
source = @"
public class C
{
    int this[int a, int b, int c = 4]
    {
        set {}
    }

    void M()
    {
        /*<bind>*/this[a: 1, a: 2, b: 3]/*</bind>*/ = 0;
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,34377,34962);

string 
expectedOperationTree = @"
IInvalidOperation (OperationKind.Invalid, Type: System.Int32, IsInvalid) (Syntax: 'this[a: 1, a: 2, b: 3]')
  Children(4):
      IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C) (Syntax: 'this')
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,34976,35451);

f_22054_34976_35450(source, expectedOperationTree, expectedDiagnostics: new DiagnosticDescription[]
            {
f_22054_35341_35434(f_22054_35341_35413(f_22054_35341_35394(ErrorCode.ERR_DuplicateNamedArgument, "a"), "a"), 11, 30)            });
DynAbs.Tracing.TraceSender.TraceExitMethod(22054,33888,35462);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22054,33888,35462);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22054,33888,35462);
}
		}

[Fact]
        [CompilerTrait(CompilerFeature.IOperation)]
        [WorkItem(20050, "https://github.com/dotnet/roslyn/issues/20050")]
        public void BuildsArgumentsOperationsForDuplicateExplicitArguments_IncorrectArgumentsOrder_Methods()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22054,35474,36868);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,35744,35918);

string 
source = @"
public class C
{
    void N(int a, int b, int c = 4)
    {
    }

    void M()
    {
        /*<bind>*/N(b: 1, a: 2, a: 3)/*</bind>*/;
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,35932,36378);

string 
expectedOperationTree = @"
IInvalidOperation (OperationKind.Invalid, Type: System.Void, IsInvalid) (Syntax: 'N(b: 1, a: 2, a: 3)')
  Children(3):
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,36392,36857);

f_22054_36392_36856(source, expectedOperationTree, expectedDiagnostics: new DiagnosticDescription[]
            {
f_22054_36747_36840(f_22054_36747_36819(f_22054_36747_36800(ErrorCode.ERR_DuplicateNamedArgument, "a"), "a"), 10, 33)            });
DynAbs.Tracing.TraceSender.TraceExitMethod(22054,35474,36868);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22054,35474,36868);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22054,35474,36868);
}
		}

[Fact]
        [CompilerTrait(CompilerFeature.IOperation)]
        [WorkItem(20050, "https://github.com/dotnet/roslyn/issues/20050")]
        public void BuildsArgumentsOperationsForDuplicateExplicitArguments_IncorrectArgumentsOrder_Delegates()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22054,36880,38401);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,37152,37336);

string 
source = @"
public delegate void D(int a, int b, int c = 4);
public class C
{
    void N(D lambda)
    {
        /*<bind>*/lambda(b: 1, a: 2, a: 3)/*</bind>*/;
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,37350,37908);

string 
expectedOperationTree = @"
IInvalidOperation (OperationKind.Invalid, Type: System.Void, IsInvalid) (Syntax: 'lambda(b: 1, a: 2, a: 3)')
  Children(4):
      IParameterReferenceOperation: lambda (OperationKind.ParameterReference, Type: D) (Syntax: 'lambda')
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,37922,38390);

f_22054_37922_38389(source, expectedOperationTree, expectedDiagnostics: new DiagnosticDescription[]
            {
f_22054_38281_38373(f_22054_38281_38353(f_22054_38281_38334(ErrorCode.ERR_DuplicateNamedArgument, "a"), "a"), 7, 38)            });
DynAbs.Tracing.TraceSender.TraceExitMethod(22054,36880,38401);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22054,36880,38401);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22054,36880,38401);
}
		}

[Fact]
        [CompilerTrait(CompilerFeature.IOperation)]
        [WorkItem(20050, "https://github.com/dotnet/roslyn/issues/20050")]
        public void BuildsArgumentsOperationsForDuplicateExplicitArguments_IncorrectArgumentsOrder_Indexers_Getter()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22054,38413,40010);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,38691,38902);

string 
source = @"
public class C
{
    int this[int a, int b, int c = 4]
    {
        get => 0;
    }

    void M()
    {
        var result = /*<bind>*/this[b: 1, a: 2, a: 3]/*</bind>*/;
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,38916,39501);

string 
expectedOperationTree = @"
IInvalidOperation (OperationKind.Invalid, Type: System.Int32, IsInvalid) (Syntax: 'this[b: 1, a: 2, a: 3]')
  Children(4):
      IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C) (Syntax: 'this')
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,39515,39999);

f_22054_39515_39998(source, expectedOperationTree, expectedDiagnostics: new DiagnosticDescription[]
            {
f_22054_39889_39982(f_22054_39889_39961(f_22054_39889_39942(ErrorCode.ERR_DuplicateNamedArgument, "a"), "a"), 11, 49)            });
DynAbs.Tracing.TraceSender.TraceExitMethod(22054,38413,40010);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22054,38413,40010);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22054,38413,40010);
}
		}

[Fact]
        [CompilerTrait(CompilerFeature.IOperation)]
        [WorkItem(20050, "https://github.com/dotnet/roslyn/issues/20050")]
        public void BuildsArgumentsOperationsForDuplicateExplicitArguments_IncorrectArgumentsOrder_Indexers_Setter()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22054,40022,41598);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,40300,40499);

string 
source = @"
public class C
{
    int this[int a, int b, int c = 4]
    {
        set {}
    }

    void M()
    {
        /*<bind>*/this[b: 1, a: 2, a: 3]/*</bind>*/ = 0;
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,40513,41098);

string 
expectedOperationTree = @"
IInvalidOperation (OperationKind.Invalid, Type: System.Int32, IsInvalid) (Syntax: 'this[b: 1, a: 2, a: 3]')
  Children(4):
      IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C) (Syntax: 'this')
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,41112,41587);

f_22054_41112_41586(source, expectedOperationTree, expectedDiagnostics: new DiagnosticDescription[]
            {
f_22054_41477_41570(f_22054_41477_41549(f_22054_41477_41530(ErrorCode.ERR_DuplicateNamedArgument, "a"), "a"), 11, 36)            });
DynAbs.Tracing.TraceSender.TraceExitMethod(22054,40022,41598);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22054,40022,41598);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22054,40022,41598);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void InvalidExpressionFlow_01()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22054,41610,44361);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,41768,41932);

string 
source = @"
using System;
class C
{
    static void M1(int i, int x, int y)
    /*<bind>*/{
        i = M(1, __arglist(x, y));
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,41946,42271);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22054_42169_42255(f_22054_42169_42235(f_22054_42169_42216(ErrorCode.ERR_NameNotInContext, "M"), "M"), 7, 13)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,42287,44238);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (1)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: 'i = M(1, __ ... ist(x, y));')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsInvalid) (Syntax: 'i = M(1, __ ... list(x, y))')
              Left: 
                IParameterReferenceOperation: i (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i')
              Right: 
                IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'M(1, __arglist(x, y))')
                  Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    (NoConversion)
                  Operand: 
                    IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid) (Syntax: 'M(1, __arglist(x, y))')
                      Children(3):
                          IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid) (Syntax: 'M')
                            Children(0)
                          ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
                          IOperation:  (OperationKind.None, Type: null) (Syntax: '__arglist(x, y)')
                            Children(2):
                                IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'x')
                                IParameterReferenceOperation: y (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'y')

    Next (Regular) Block[B2]
Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,44252,44350);

f_22054_44252_44349(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22054,41610,44361);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22054,41610,44361);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22054,41610,44361);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void InvalidExpressionFlow_02()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22054,44373,49438);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,44531,44717);

string 
source = @"
using System;
class C
{
    static void M1(int i, bool a,int x, int y, int z)
    /*<bind>*/{
        i = M(1, __arglist(x, a ? y : z));
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,44731,45048);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22054_44946_45032(f_22054_44946_45012(f_22054_44946_44993(ErrorCode.ERR_NameNotInContext, "M"), "M"), 7, 13)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,45064,49315);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [1] [2] [3] [4]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (4)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i')
              Value: 
                IParameterReferenceOperation: i (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'M')
              Value: 
                IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid) (Syntax: 'M')
                  Children(0)

            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '1')
              Value: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

            IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'x')
              Value: 
                IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'x')

        Jump if False (Regular) to Block[B3]
            IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'a')

        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'y')
              Value: 
                IParameterReferenceOperation: y (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'y')

        Next (Regular) Block[B4]
    Block[B3] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'z')
              Value: 
                IParameterReferenceOperation: z (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'z')

        Next (Regular) Block[B4]
    Block[B4] - Block
        Predecessors: [B2] [B3]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: 'i = M(1, __ ...  ? y : z));')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsInvalid) (Syntax: 'i = M(1, __ ... a ? y : z))')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'i')
                  Right: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'M(1, __argl ... a ? y : z))')
                      Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (NoConversion)
                      Operand: 
                        IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid) (Syntax: 'M(1, __argl ... a ? y : z))')
                          Children(3):
                              IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: ?, IsInvalid, IsImplicit) (Syntax: 'M')
                              IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, Constant: 1, IsImplicit) (Syntax: '1')
                              IOperation:  (OperationKind.None, Type: null) (Syntax: '__arglist(x, a ? y : z)')
                                Children(2):
                                    IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'x')
                                    IFlowCaptureReferenceOperation: 4 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'a ? y : z')

        Next (Regular) Block[B5]
            Leaving: {R1}
}

Block[B5] - Exit
    Predecessors: [B4]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,49329,49427);

f_22054_49329_49426(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22054,44373,49438);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22054,44373,49438);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22054,44373,49438);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void InvalidExpressionFlow_03()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22054,49450,54249);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,49608,49795);

string 
source = @"
using System;
class C
{
    static void M1(int i, bool a, int w, int x, int y)
    /*<bind>*/{
        i = M(1, __arglist(a ? w : x, y));
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,49809,50126);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22054_50024_50110(f_22054_50024_50090(f_22054_50024_50071(ErrorCode.ERR_NameNotInContext, "M"), "M"), 7, 13)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,50142,54126);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i')
              Value: 
                IParameterReferenceOperation: i (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'M')
              Value: 
                IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid) (Syntax: 'M')
                  Children(0)

            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '1')
              Value: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

        Jump if False (Regular) to Block[B3]
            IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'a')

        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'w')
              Value: 
                IParameterReferenceOperation: w (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'w')

        Next (Regular) Block[B4]
    Block[B3] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'x')
              Value: 
                IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'x')

        Next (Regular) Block[B4]
    Block[B4] - Block
        Predecessors: [B2] [B3]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: 'i = M(1, __ ... w : x, y));')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsInvalid) (Syntax: 'i = M(1, __ ...  w : x, y))')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'i')
                  Right: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'M(1, __argl ...  w : x, y))')
                      Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (NoConversion)
                      Operand: 
                        IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid) (Syntax: 'M(1, __argl ...  w : x, y))')
                          Children(3):
                              IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: ?, IsInvalid, IsImplicit) (Syntax: 'M')
                              IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, Constant: 1, IsImplicit) (Syntax: '1')
                              IOperation:  (OperationKind.None, Type: null) (Syntax: '__arglist(a ? w : x, y)')
                                Children(2):
                                    IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'a ? w : x')
                                    IParameterReferenceOperation: y (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'y')

        Next (Regular) Block[B5]
            Leaving: {R1}
}

Block[B5] - Exit
    Predecessors: [B4]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,54140,54238);

f_22054_54140_54237(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22054,49450,54249);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22054,49450,54249);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22054,49450,54249);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void InvalidExpressionFlow_04()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22054,54261,60113);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,54419,54629);

string 
source = @"
using System;
class C
{
    static void M1(int i, bool a, bool b, int w, int x, int y, int z)
    /*<bind>*/{
        i = M(1, __arglist(a ? w : x, b ? y : z));
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,54643,54968);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22054_54866_54952(f_22054_54866_54932(f_22054_54866_54913(ErrorCode.ERR_NameNotInContext, "M"), "M"), 7, 13)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,54984,59990);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [1] [2] [3] [4]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (3)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i')
              Value: 
                IParameterReferenceOperation: i (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'M')
              Value: 
                IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid) (Syntax: 'M')
                  Children(0)

            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '1')
              Value: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

        Jump if False (Regular) to Block[B3]
            IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'a')

        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'w')
              Value: 
                IParameterReferenceOperation: w (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'w')

        Next (Regular) Block[B4]
    Block[B3] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'x')
              Value: 
                IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'x')

        Next (Regular) Block[B4]
    Block[B4] - Block
        Predecessors: [B2] [B3]
        Statements (0)
        Jump if False (Regular) to Block[B6]
            IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

        Next (Regular) Block[B5]
    Block[B5] - Block
        Predecessors: [B4]
        Statements (1)
            IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'y')
              Value: 
                IParameterReferenceOperation: y (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'y')

        Next (Regular) Block[B7]
    Block[B6] - Block
        Predecessors: [B4]
        Statements (1)
            IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'z')
              Value: 
                IParameterReferenceOperation: z (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'z')

        Next (Regular) Block[B7]
    Block[B7] - Block
        Predecessors: [B5] [B6]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: 'i = M(1, __ ...  ? y : z));')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsInvalid) (Syntax: 'i = M(1, __ ... b ? y : z))')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'i')
                  Right: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'M(1, __argl ... b ? y : z))')
                      Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (NoConversion)
                      Operand: 
                        IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid) (Syntax: 'M(1, __argl ... b ? y : z))')
                          Children(3):
                              IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: ?, IsInvalid, IsImplicit) (Syntax: 'M')
                              IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, Constant: 1, IsImplicit) (Syntax: '1')
                              IOperation:  (OperationKind.None, Type: null) (Syntax: '__arglist(a ...  b ? y : z)')
                                Children(2):
                                    IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'a ? w : x')
                                    IFlowCaptureReferenceOperation: 4 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'b ? y : z')

        Next (Regular) Block[B8]
            Leaving: {R1}
}

Block[B8] - Exit
    Predecessors: [B7]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22054,60004,60102);

f_22054_60004_60101(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22054,54261,60113);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22054,54261,60113);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22054,54261,60113);
}
		}

Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_1557_1609(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 1557, 1609);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_1557_1655(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 1557, 1655);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_1557_1675(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 1557, 1675);
return return_v;
}


int
f_22054_1707_1827(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InvocationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 1707, 1827);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_2890_2942(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 2890, 2942);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_2890_2978(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 2890, 2978);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_2890_2998(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 2890, 2998);
return return_v;
}


int
f_22054_3030_3150(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InvocationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 3030, 3150);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_4194_4236(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 4194, 4236);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_4194_4260(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 4194, 4260);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_4194_4280(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 4194, 4280);
return return_v;
}


int
f_22054_4312_4432(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InvocationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 4312, 4432);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_5839_5904(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 5839, 5904);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_5839_5945(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 5839, 5945);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_5839_5965(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 5839, 5965);
return return_v;
}


int
f_22054_5997_6115(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 5997, 6115);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_8139_8187(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 8139, 8187);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_8139_8218(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 8139, 8218);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_8139_8239(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 8139, 8239);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_8400_8455(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 8400, 8455);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_8400_8488(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 8400, 8488);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_8400_8507(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 8400, 8507);
return return_v;
}


int
f_22054_8539_8664(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<LocalDeclarationStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 8539, 8664);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_10724_10781(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 10724, 10781);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_10724_10813(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 10724, 10813);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_10724_10834(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 10724, 10834);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_10995_11050(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 10995, 11050);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_10995_11083(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 10995, 11083);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_10995_11102(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 10995, 11102);
return return_v;
}


int
f_22054_11134_11259(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<LocalDeclarationStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 11134, 11259);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_12217_12260(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 12217, 12260);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_12217_12291(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 12217, 12291);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_12217_12311(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 12217, 12311);
return return_v;
}


int
f_22054_12343_12464(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 12343, 12464);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_14036_14083(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 14036, 14083);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_14036_14102(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 14036, 14102);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_14036_14122(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 14036, 14122);
return return_v;
}


int
f_22054_14154_14270(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<BinaryExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 14154, 14270);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_15890_15972(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 15890, 15972);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_15890_16007(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 15890, 16007);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_15890_16027(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 15890, 16027);
return return_v;
}


int
f_22054_16059_16177(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 16059, 16177);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_17487_17579(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 17487, 17579);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_17487_17614(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 17487, 17614);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_17487_17634(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 17487, 17634);
return return_v;
}


int
f_22054_17666_17795(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ParenthesizedLambdaExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 17666, 17795);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_19154_19203(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 19154, 19203);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_19154_19236(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 19154, 19236);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_19154_19256(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 19154, 19256);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_19431_19480(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 19431, 19480);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_19431_19513(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 19431, 19513);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_19431_19533(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 19431, 19533);
return return_v;
}


int
f_22054_19565_19682(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<EqualsValueClauseSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 19565, 19682);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_22800_22857(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 22800, 22857);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_22800_22877(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 22800, 22877);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_23070_23143(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 23070, 23143);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_23070_23162(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 23070, 23162);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_23070_23182(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 23070, 23182);
return return_v;
}


int
f_22054_23214_23335(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InitializerExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 23214, 23335);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_25730_25783(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 25730, 25783);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_25730_25802(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 25730, 25802);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_25730_25822(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 25730, 25822);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_26013_26062(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 26013, 26062);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_26013_26095(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 26013, 26095);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_26013_26115(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 26013, 26115);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_26353_26407(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 26353, 26407);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_26353_26427(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 26353, 26427);
return return_v;
}


int
f_22054_26459_26582(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ArrayCreationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 26459, 26582);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_27698_27757(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 27698, 27757);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_27698_27776(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 27698, 27776);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_27698_27797(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 27698, 27797);
return return_v;
}


int
f_22054_27829_27946(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<EqualsValueClauseSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 27829, 27946);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_29210_29268(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 29210, 29268);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_29210_29292(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 29210, 29292);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_29210_29312(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 29210, 29312);
return return_v;
}


int
f_22054_28833_29328(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InvocationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics:expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 28833, 29328);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_30617_30670(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 30617, 30670);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_30617_30689(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 30617, 30689);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_30617_30710(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 30617, 30710);
return return_v;
}


int
f_22054_30268_30726(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InvocationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics:expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 30268, 30726);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_32149_32202(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 32149, 32202);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_32149_32221(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 32149, 32221);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_32149_32241(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 32149, 32241);
return return_v;
}


int
f_22054_31790_32257(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InvocationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics:expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 31790, 32257);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_33755_33808(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 33755, 33808);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_33755_33827(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 33755, 33827);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_33755_33848(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 33755, 33848);
return return_v;
}


int
f_22054_33381_33864(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ElementAccessExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics:expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 33381, 33864);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_35341_35394(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 35341, 35394);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_35341_35413(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 35341, 35413);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_35341_35434(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 35341, 35434);
return return_v;
}


int
f_22054_34976_35450(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ElementAccessExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics:expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 34976, 35450);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_36747_36800(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 36747, 36800);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_36747_36819(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 36747, 36819);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_36747_36840(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 36747, 36840);
return return_v;
}


int
f_22054_36392_36856(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InvocationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics:expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 36392, 36856);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_38281_38334(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 38281, 38334);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_38281_38353(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 38281, 38353);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_38281_38373(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 38281, 38373);
return return_v;
}


int
f_22054_37922_38389(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InvocationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics:expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 37922, 38389);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_39889_39942(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 39889, 39942);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_39889_39961(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 39889, 39961);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_39889_39982(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 39889, 39982);
return return_v;
}


int
f_22054_39515_39998(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ElementAccessExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics:expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 39515, 39998);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_41477_41530(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 41477, 41530);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_41477_41549(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 41477, 41549);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_41477_41570(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 41477, 41570);
return return_v;
}


int
f_22054_41112_41586(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ElementAccessExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics:expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 41112, 41586);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_42169_42216(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 42169, 42216);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_42169_42235(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 42169, 42235);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_42169_42255(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 42169, 42255);
return return_v;
}


int
f_22054_44252_44349(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 44252, 44349);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_44946_44993(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 44946, 44993);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_44946_45012(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 44946, 45012);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_44946_45032(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 44946, 45032);
return return_v;
}


int
f_22054_49329_49426(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 49329, 49426);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_50024_50071(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 50024, 50071);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_50024_50090(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 50024, 50090);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_50024_50110(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 50024, 50110);
return return_v;
}


int
f_22054_54140_54237(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 54140, 54237);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_54866_54913(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 54866, 54913);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_54866_54932(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 54866, 54932);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22054_54866_54952(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 54866, 54952);
return return_v;
}


int
f_22054_60004_60101(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22054, 60004, 60101);
return 0;
}

}
}
