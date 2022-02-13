// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp.Test.Utilities;
using Microsoft.CodeAnalysis.Operations;
using Microsoft.CodeAnalysis.Test.Utilities;
using Xunit;

namespace Microsoft.CodeAnalysis.CSharp.UnitTests
{
    public partial class IOperationTests : SemanticModelTestBase
    {
        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Implicit_IdentityConversionDynamic()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 715, 2043);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 878, 1054);

                string
                source = @"
class Program
{
    static void Main(string[] args)
    {
        object o1 = new object();
        dynamic /*<bind>*/d1 = o1/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 1068, 1743);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: dynamic d1) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'd1 = o1')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= o1')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: dynamic, IsImplicit) (Syntax: 'o1')
        Conversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          ILocalReferenceOperation: o1 (OperationKind.LocalReference, Type: System.Object) (Syntax: 'o1')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 1757, 1810);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 1826, 2032);

                f_22020_1826_2031(source, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: f_22020_1995_2023().Verify);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 715, 2043);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 715, 2043);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 715, 2043);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Implicit_IdentityConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 2221, 3160);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 2377, 2552);

                string
                source = @"
class Program
{
    static void Main(string[] args)
    {
        object o1 = new object();
        object /*<bind>*/o2 = o1/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 2566, 2947);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: System.Object o2) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'o2 = o1')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= o1')
      ILocalReferenceOperation: o1 (OperationKind.LocalReference, Type: System.Object) (Syntax: 'o1')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 2961, 3014);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 3030, 3149);

                f_22020_3030_3148(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 2221, 3160);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 2221, 3160);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 2221, 3160);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Implicit_NumericConversion_Valid()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 3172, 4500);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 3333, 3499);

                string
                source = @"
class Program
{
    static void Main(string[] args)
    {
        float f1 = 1.0f;
        double /*<bind>*/d1 = f1/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 3513, 4200);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: System.Double d1) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'd1 = f1')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= f1')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Double, IsImplicit) (Syntax: 'f1')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          ILocalReferenceOperation: f1 (OperationKind.LocalReference, Type: System.Single) (Syntax: 'f1')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 4214, 4267);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 4283, 4489);

                f_22020_4283_4488(source, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: f_22020_4452_4480().Verify);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 3172, 4500);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 3172, 4500);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 3172, 4500);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Implicit_NumericConversion_InvalidIllegalTypes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 4512, 6224);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 4687, 4850);

                string
                source = @"
class Program
{
    static void Main(string[] args)
    {
        float f1 = 1.0f;
        int /*<bind>*/i1 = f1/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 4864, 5593);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: System.Int32 i1) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'i1 = f1')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '= f1')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'f1')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          ILocalReferenceOperation: f1 (OperationKind.LocalReference, Type: System.Single, IsInvalid) (Syntax: 'f1')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 5607, 5991);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22020_5875_5975(f_22020_5875_5955(f_22020_5875_5925(ErrorCode.ERR_NoImplicitConvCast, "f1"), "float", "int"), 7, 28)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 6007, 6213);

                f_22020_6007_6212(source, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: f_22020_6176_6204().Verify);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 4512, 6224);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 4512, 6224);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 4512, 6224);
            }
        }

        [Fact]
        public void ConversionExpression_Implicit_NumericConversion_InvalidNoInitializer()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 6236, 8540);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 6359, 6510);

                string
                source = @"
using System;

class Program
{
    static void Main(string[] args)
    {
        int /*<bind>*/i1 =/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 6524, 6945);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: System.Int32 i1) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'i1 =/*</bind>*/')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '=/*</bind>*/')
      IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid) (Syntax: '')
        Children(0)
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 6959, 7248);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22020_7147_7232(f_22020_7147_7212(f_22020_7147_7193(ErrorCode.ERR_InvalidExprTerm, ";"), ";"), 8, 38)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 7264, 8529);

                f_22020_7264_8528(source, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: (operation, compilation, syntax) =>
                                {
                    // This scenario, where the syntax has IsMissing set, is special cased. We remove the conversion, and leave
                    // just an IInvalidOperation with null type. First assert that our assumptions are true, then test the actual
                    // result
                    var initializerSyntax = ((VariableDeclaratorSyntax)syntax).Initializer.Value;
                                    var typeInfo = compilation.GetSemanticModel(syntax.SyntaxTree).GetTypeInfo(initializerSyntax);
                                    Assert.Equal(SyntaxKind.IdentifierName, initializerSyntax.Kind());
                                    Assert.True(initializerSyntax.IsMissing);
                                    Assert.Null(typeInfo.Type);
                                    Assert.Null(typeInfo.ConvertedType);

                                    var initializerOperation = ((IVariableDeclaratorOperation)operation).Initializer.Value;
                                    Assert.Null(initializerOperation.Type);
                                    Assert.Equal(OperationKind.Invalid, initializerOperation.Kind);
                                });
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 6236, 8540);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 6236, 8540);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 6236, 8540);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Implicit_EnumConversion_ZeroToEnum()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 8552, 10156);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 8715, 8891);

                string
                source = @"
class Program
{    static void Main(string[] args)
    {
        Enum1 /*<bind>*/e1 = 0/*</bind>*/;
    }
}
enum Enum1
{
    Option1, Option2
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 8905, 9580);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: Enum1 e1) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'e1 = 0')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= 0')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: Enum1, Constant: 0, IsImplicit) (Syntax: '0')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 9594, 9923);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22020_9816_9907(f_22020_9816_9887(f_22020_9816_9867(ErrorCode.WRN_UnreferencedVarAssg, "e1"), "e1"), 5, 25)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 9939, 10145);

                f_22020_9939_10144(source, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: f_22020_10108_10136().Verify);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 8552, 10156);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 8552, 10156);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 8552, 10156);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Implicit_EnumConversion_IntToEnum_Invalid()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 10168, 11908);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 10338, 10538);

                string
                source = @"
class Program
{
    static void Main(string[] args)
    {
        int i1 = 1;
        Enum1 /*<bind>*/e1 = i1/*</bind>*/;
    }
}
enum Enum1
{
    Option1, Option2
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 10552, 11267);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: Enum1 e1) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'e1 = i1')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '= i1')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: Enum1, IsInvalid, IsImplicit) (Syntax: 'i1')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          ILocalReferenceOperation: i1 (OperationKind.LocalReference, Type: System.Int32, IsInvalid) (Syntax: 'i1')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 11281, 11675);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22020_11559_11659(f_22020_11559_11639(f_22020_11559_11609(ErrorCode.ERR_NoImplicitConvCast, "i1"), "int", "Enum1"), 7, 30)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 11691, 11897);

                f_22020_11691_11896(source, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: f_22020_11860_11888().Verify);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 10168, 11908);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 10168, 11908);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 10168, 11908);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Implicit_EnumConversion_OneToEnum_Invalid()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 11920, 13919);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 12090, 12266);

                string
                source = @"
class Program
{    static void Main(string[] args)
    {
        Enum1 /*<bind>*/e1 = 1/*</bind>*/;
    }
}
enum Enum1
{
    Option1, Option2
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 12280, 12999);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: Enum1 e1) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'e1 = 1')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '= 1')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: Enum1, Constant: 1, IsInvalid, IsImplicit) (Syntax: '1')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1, IsInvalid) (Syntax: '1')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 13013, 13686);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22020_13296_13395(f_22020_13296_13375(f_22020_13296_13345(ErrorCode.ERR_NoImplicitConvCast, "1"), "int", "Enum1"), 5, 30),
f_22020_13579_13670(f_22020_13579_13650(f_22020_13579_13630(ErrorCode.WRN_UnreferencedVarAssg, "e1"), "e1"), 5, 25)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 13702, 13908);

                f_22020_13702_13907(source, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: f_22020_13871_13899().Verify);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 11920, 13919);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 11920, 13919);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 11920, 13919);
            }
        }

        [Fact(Skip = "https://github.com/dotnet/roslyn/issues/20175")]
        public void ConversionExpression_Implicit_EnumConversion_NoInitializer_Invalid()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 13931, 15419);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 14108, 14284);

                string
                source = @"
class Program
{
    static void Main(string[] args)
    {
        Enum1 /*<bind>*/e1 =/*</bind>*/;
    }
}
enum Enum1
{
    Option1, Option2
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 14298, 14881);

                string
                expectedOperationTree = @"
IVariableDeclarationStatement (1 declarators) (OperationKind.VariableDeclarationStatement, IsInvalid) (Syntax: 'Enum1 /*<bi ... *</bind>*/;')
  IVariableDeclaration (1 variables) (OperationKind.VariableDeclaration, IsInvalid) (Syntax: 'Enum1 /*<bi ... *</bind>*/;')
    Variables: Local_1: Enum1 e1
    Initializer: IConversionExpression (ConversionKind.Invalid, Implicit) (OperationKind.ConversionExpression, Type: Enum1, IsInvalid) (Syntax: '')
        IInvalidExpression (OperationKind.InvalidExpression, Type: ?, IsInvalid) (Syntax: '')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 14895, 15186);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22020_15085_15170(f_22020_15085_15150(f_22020_15085_15131(ErrorCode.ERR_InvalidExprTerm, ";"), ";"), 6, 40)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 15202, 15408);

                f_22020_15202_15407(source, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: f_22020_15371_15399().Verify);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 13931, 15419);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 13931, 15419);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 13931, 15419);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Implicit_ThrowExpressionConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 15431, 18275);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 15594, 15785);

                string
                source = @"
using System;

class Program
{
    static void Main(string[] args)
    {
        object /*<bind>*/o = new object() ?? throw new Exception()/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 15799, 17364);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: System.Object o) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'o = new obj ... Exception()')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= new objec ... Exception()')
      ICoalesceOperation (OperationKind.Coalesce, Type: System.Object) (Syntax: 'new object( ... Exception()')
        Expression: 
          IObjectCreationOperation (Constructor: System.Object..ctor()) (OperationKind.ObjectCreation, Type: System.Object) (Syntax: 'new object()')
            Arguments(0)
            Initializer: 
              null
        ValueConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
          (Identity)
        WhenNull: 
          IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsImplicit) (Syntax: 'throw new Exception()')
            Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            Operand: 
              IThrowOperation (OperationKind.Throw, Type: null) (Syntax: 'throw new Exception()')
                IObjectCreationOperation (Constructor: System.Exception..ctor()) (OperationKind.ObjectCreation, Type: System.Exception) (Syntax: 'new Exception()')
                  Arguments(0)
                  Initializer: 
                    null
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 17378, 17431);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 17447, 18264);

                // LAFHIS (DynAbs.Tracing.TraceSender.TraceInitializationWrapper)
                f_22020_17447_18263(source, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: new ExpectedSymbolVerifier()
                {
                    SyntaxSelector = (syntax) =>
                    {
                        var initializer = (BinaryExpressionSyntax)((VariableDeclaratorSyntax)syntax).Initializer.Value;
                        return initializer.Right;
                    },
                    OperationSelector = (operation) =>
{
var initializer = ((IVariableDeclaratorOperation)operation).Initializer.Value;
return (IConversionOperation)((ICoalesceOperation)initializer).WhenNull;
}
                }.Verify);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 15431, 18275);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 15431, 18275);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 15431, 18275);
            }
        }

        [Fact(Skip = "https://github.com/dotnet/roslyn/issues/20175")]
        public void ConversionExpression_Implicit_ThrowExpressionConversion_InvalidSyntax()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 18287, 20153);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 18467, 18642);

                string
                source = @"
using System;

class Program
{
    static void Main(string[] args)
    {
        object /*<bind>*/o = throw new Exception()/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 18656, 19586);

                string
                expectedOperationTree = @"
IVariableDeclarationStatement (1 declarators) (OperationKind.VariableDeclarationStatement, IsInvalid) (Syntax: 'object /*<b ... *</bind>*/;')
  IVariableDeclaration (1 variables) (OperationKind.VariableDeclaration, IsInvalid) (Syntax: 'object /*<b ... *</bind>*/;')
    Variables: Local_1: System.Object o
    Initializer: IConversionExpression (ConversionKind.Invalid, Implicit) (OperationKind.ConversionExpression, Type: System.Object, IsInvalid) (Syntax: 'throw new Exception()')
        IInvalidExpression (OperationKind.InvalidExpression, Type: ?, IsInvalid) (Syntax: 'throw new Exception()')
          Children(1): IOperation:  (OperationKind.None, IsInvalid) (Syntax: 'throw new Exception()')
              Children(1): IObjectCreationExpression (Constructor: System.Exception..ctor()) (OperationKind.ObjectCreationExpression, Type: System.Exception) (Syntax: 'new Exception()')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 19600, 19920);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22020_19835_19904(f_22020_19835_19884(ErrorCode.ERR_ThrowMisplaced, "throw"), 8, 30)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 19936, 20142);

                f_22020_19936_20141(source, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: f_22020_20105_20133().Verify);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 18287, 20153);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 18287, 20153);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 18287, 20153);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Implicit_NullToClassConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 20165, 21760);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 20324, 20466);

                string
                source = @"
class Program
{
    static void Main(string[] args)
    {
        string /*<bind>*/s1 = null/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 20480, 21180);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: System.String s1) (OperationKind.VariableDeclarator, Type: null) (Syntax: 's1 = null')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= null')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.String, Constant: null, IsImplicit) (Syntax: 'null')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 21194, 21527);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22020_21420_21511(f_22020_21420_21491(f_22020_21420_21471(ErrorCode.WRN_UnreferencedVarAssg, "s1"), "s1"), 6, 26)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 21543, 21749);

                f_22020_21543_21748(source, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: f_22020_21712_21740().Verify);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 20165, 21760);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 20165, 21760);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 20165, 21760);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Implicit_NullToNullableValueConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 21772, 23347);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 21939, 22074);

                string
                source = @"
interface I1
{
}

struct S1
{
    void M1()
    {
        S1? /*<bind>*/s1 = null/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 22088, 22769);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: S1? s1) (OperationKind.VariableDeclarator, Type: null) (Syntax: 's1 = null')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= null')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: S1?, Constant: null, IsImplicit) (Syntax: 'null')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 22783, 23114);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22020_23006_23098(f_22020_23006_23077(f_22020_23006_23057(ErrorCode.WRN_UnreferencedVarAssg, "s1"), "s1"), 10, 23)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 23130, 23336);

                f_22020_23130_23335(source, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: f_22020_23299_23327().Verify);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 21772, 23347);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 21772, 23347);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 21772, 23347);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Implicit_NullToNonNullableConversion_Invalid()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 23359, 25000);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 23532, 23671);

                string
                source = @"
class Program
{
    static void Main(string[] args)
    {
        int /*<bind>*/i1 = null/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 23685, 24413);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: System.Int32 i1) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'i1 = null')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '= null')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'null')
        Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          ILiteralOperation (OperationKind.Literal, Type: null, Constant: null, IsInvalid) (Syntax: 'null')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 24427, 24767);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22020_24661_24751(f_22020_24661_24731(f_22020_24661_24710(ErrorCode.ERR_ValueCantBeNull, "null"), "int"), 6, 28)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 24783, 24989);

                f_22020_24783_24988(source, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: f_22020_24952_24980().Verify);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 23359, 25000);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 23359, 25000);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 23359, 25000);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Implicit_DefaultToValueConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 25012, 26685);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 25174, 25307);

                string
                source = @"
using System;

class S1
{
    void M1()
    {
        long /*<bind>*/i1 = default/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 25321, 26044);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: System.Int64 i1) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'i1 = default')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= default')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int64, Constant: 0, IsImplicit) (Syntax: 'default')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          IDefaultValueOperation (OperationKind.DefaultValue, Type: System.Int64, Constant: 0) (Syntax: 'default')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 26058, 26397);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22020_26290_26381(f_22020_26290_26361(f_22020_26290_26341(ErrorCode.WRN_UnreferencedVarAssg, "i1"), "i1"), 8, 24)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 26413, 26674);

                f_22020_26413_26673(source, expectedOperationTree, expectedDiagnostics, parseOptions: TestOptions.Regular7_1, additionalOperationTreeVerifier: f_22020_26637_26665().Verify);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 25012, 26685);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 25012, 26685);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 25012, 26685);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Implicit_DefaultOfImplicitlyConvertableTypeToValueConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 26697, 28366);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 26886, 27024);

                string
                source = @"
using System;

class S1
{
    void M1()
    {
        long /*<bind>*/i1 = default(int)/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 27038, 27780);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: System.Int64 i1) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'i1 = default(int)')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= default(int)')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int64, Constant: 0, IsImplicit) (Syntax: 'default(int)')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          IDefaultValueOperation (OperationKind.DefaultValue, Type: System.Int32, Constant: 0) (Syntax: 'default(int)')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 27794, 28133);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22020_28026_28117(f_22020_28026_28097(f_22020_28026_28077(ErrorCode.WRN_UnreferencedVarAssg, "i1"), "i1"), 8, 24)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 28149, 28355);

                f_22020_28149_28354(source, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: f_22020_28318_28346().Verify);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 26697, 28366);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 26697, 28366);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 26697, 28366);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Implicit_DefaultToClassNoConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 28540, 29793);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 28704, 28847);

                string
                source = @"
using System;

class S1
{
    void M1()
    {
        string /*<bind>*/i1 = default(string)/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 28861, 29289);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: System.String i1) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'i1 = default(string)')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= default(string)')
      IDefaultValueOperation (OperationKind.DefaultValue, Type: System.String, Constant: null) (Syntax: 'default(string)')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 29303, 29647);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22020_29540_29631(f_22020_29540_29611(f_22020_29540_29591(ErrorCode.WRN_UnreferencedVarAssg, "i1"), "i1"), 8, 26)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 29663, 29782);

                f_22020_29663_29781(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 28540, 29793);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 28540, 29793);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 28540, 29793);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Implicit_NullableFromConstantConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 29805, 31377);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 29973, 30110);

                string
                source = @"
class Program
{
    static void Main(string[] args)
    {
        int? /*<bind>*/i1 = 1/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 30124, 30802);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: System.Int32? i1) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'i1 = 1')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= 1')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32?, IsImplicit) (Syntax: '1')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 30816, 31144);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22020_31037_31128(f_22020_31037_31108(f_22020_31037_31088(ErrorCode.WRN_UnreferencedVarAssg, "i1"), "i1"), 6, 24)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 31160, 31366);

                f_22020_31160_31365(source, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: f_22020_31329_31357().Verify);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 29805, 31377);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 29805, 31377);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 29805, 31377);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Implicit_NullableToNullableConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 31389, 32718);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 31555, 31716);

                string
                source = @"
class Program
{
    static void Main(string[] args)
    {
        int? i1 = 1;
        long? /*<bind>*/l1 = i1/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 31730, 32418);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: System.Int64? l1) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'l1 = i1')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= i1')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int64?, IsImplicit) (Syntax: 'i1')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          ILocalReferenceOperation: i1 (OperationKind.LocalReference, Type: System.Int32?) (Syntax: 'i1')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 32432, 32485);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 32501, 32707);

                f_22020_32501_32706(source, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: f_22020_32670_32698().Verify);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 31389, 32718);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 31389, 32718);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 31389, 32718);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Implicit_NullableFromNonNullableConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 32730, 34061);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 32901, 33060);

                string
                source = @"
class Program
{
    static void Main(string[] args)
    {
        int i1 = 1;
        int? /*<bind>*/i2 = i1/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 33074, 33761);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: System.Int32? i2) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'i2 = i1')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= i1')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32?, IsImplicit) (Syntax: 'i1')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          ILocalReferenceOperation: i1 (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i1')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 33775, 33828);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 33844, 34050);

                f_22020_33844_34049(source, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: f_22020_34013_34041().Verify);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 32730, 34061);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 32730, 34061);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 32730, 34061);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Implicit_NullableToNonNullableConversion_Invalid()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 34073, 35782);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 34250, 34409);

                string
                source = @"
class Program
{
    static void Main(string[] args)
    {
        int? i1 = 1;
        int /*<bind>*/i2 = i1/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 34423, 35153);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: System.Int32 i2) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'i2 = i1')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '= i1')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'i1')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          ILocalReferenceOperation: i1 (OperationKind.LocalReference, Type: System.Int32?, IsInvalid) (Syntax: 'i1')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 35167, 35549);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22020_35434_35533(f_22020_35434_35513(f_22020_35434_35484(ErrorCode.ERR_NoImplicitConvCast, "i1"), "int?", "int"), 7, 28)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 35565, 35771);

                f_22020_35565_35770(source, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: f_22020_35734_35762().Verify);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 34073, 35782);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 34073, 35782);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 34073, 35782);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Implicit_InterpolatedStringToIFormattableExpression()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 35794, 37672);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 36080, 36249);

                string
                source = @"
using System;

class Program
{
    static void Main(string[] args)
    {
        IFormattable /*<bind>*/f1 = $""{1}""/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 36263, 37372);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: System.IFormattable f1) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'f1 = $""{1}""')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= $""{1}""')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.IFormattable, IsImplicit) (Syntax: '$""{1}""')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
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
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 37386, 37439);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 37455, 37661);

                f_22020_37455_37660(source, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: f_22020_37624_37652().Verify);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 35794, 37672);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 35794, 37672);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 35794, 37672);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Implicit_ReferenceToObjectConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 37684, 39116);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 37849, 38007);

                string
                source = @"
using System;

class C1
{
    static void Main(string[] args)
    {
        object /*<bind>*/o1 = new C1()/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 38021, 38816);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: System.Object o1) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'o1 = new C1()')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= new C1()')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsImplicit) (Syntax: 'new C1()')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          IObjectCreationOperation (Constructor: C1..ctor()) (OperationKind.ObjectCreation, Type: C1) (Syntax: 'new C1()')
            Arguments(0)
            Initializer: 
              null
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 38830, 38883);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 38899, 39105);

                f_22020_38899_39104(source, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: f_22020_39068_39096().Verify);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 37684, 39116);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 37684, 39116);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 37684, 39116);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Implicit_ReferenceToDynamicConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 39128, 40550);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 39294, 39453);

                string
                source = @"
using System;

class C1
{
    static void Main(string[] args)
    {
        dynamic /*<bind>*/d1 = new C1()/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 39467, 40250);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: dynamic d1) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'd1 = new C1()')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= new C1()')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: dynamic, IsImplicit) (Syntax: 'new C1()')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          IObjectCreationOperation (Constructor: C1..ctor()) (OperationKind.ObjectCreation, Type: C1) (Syntax: 'new C1()')
            Arguments(0)
            Initializer: 
              null
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 40264, 40317);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 40333, 40539);

                f_22020_40333_40538(source, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: f_22020_40502_40530().Verify);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 39128, 40550);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 39128, 40550);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 39128, 40550);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Implicit_ReferenceClassToClassConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 40562, 41995);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 40731, 40908);

                string
                source = @"
using System;

class C1
{
    static void Main(string[] args)
    {
        C1 /*<bind>*/c1 = new C2()/*</bind>*/;
    }
}

class C2 : C1
{
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 40922, 41695);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: C1 c1) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'c1 = new C2()')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= new C2()')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: C1, IsImplicit) (Syntax: 'new C2()')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          IObjectCreationOperation (Constructor: C2..ctor()) (OperationKind.ObjectCreation, Type: C2) (Syntax: 'new C2()')
            Arguments(0)
            Initializer: 
              null
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 41709, 41762);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 41778, 41984);

                f_22020_41778_41983(source, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: f_22020_41947_41975().Verify);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 40562, 41995);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 40562, 41995);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 40562, 41995);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Implicit_ReferenceClassToClassConversion_Invalid()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 42007, 43762);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 42184, 42356);

                string
                source = @"
using System;

class C1
{
    static void Main(string[] args)
    {
        C1 /*<bind>*/c1 = new C2()/*</bind>*/;
    }
}

class C2
{
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 42370, 43189);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: C1 c1) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'c1 = new C2()')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '= new C2()')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: C1, IsInvalid, IsImplicit) (Syntax: 'new C2()')
        Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          IObjectCreationOperation (Constructor: C2..ctor()) (OperationKind.ObjectCreation, Type: C2, IsInvalid) (Syntax: 'new C2()')
            Arguments(0)
            Initializer: 
              null
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 43203, 43529);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22020_43415_43513(f_22020_43415_43493(f_22020_43415_43467(ErrorCode.ERR_NoImplicitConv, "new C2()"), "C2", "C1"), 8, 27)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 43545, 43751);

                f_22020_43545_43750(source, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: f_22020_43714_43742().Verify);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 42007, 43762);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 42007, 43762);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 42007, 43762);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Implicit_ReferenceConversion_InvalidSyntax()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 43774, 45441);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 43945, 44094);

                string
                source = @"
using System;

class C1
{
    static void Main(string[] args)
    {
        C1 /*<bind>*/c1 = new/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 44108, 44862);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: C1 c1) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'c1 = new/*</bind>*/')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '= new/*</bind>*/')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: C1, IsInvalid, IsImplicit) (Syntax: 'new/*</bind>*/')
        Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid) (Syntax: 'new/*</bind>*/')
            Children(0)
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 44876, 45208);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22020_45131_45192(f_22020_45131_45172(ErrorCode.ERR_BadNewExpr, ";"), 8, 41)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 45224, 45430);

                f_22020_45224_45429(source, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: f_22020_45393_45421().Verify);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 43774, 45441);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 43774, 45441);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 43774, 45441);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Implicit_ReferenceClassToInterfaceConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 45453, 46894);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 45626, 45807);

                string
                source = @"
using System;

interface I1
{
}

class C1 : I1
{
    static void Main(string[] args)
    {
        I1 /*<bind>*/i1 = new C1()/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 45821, 46594);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: I1 i1) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'i1 = new C1()')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= new C1()')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: I1, IsImplicit) (Syntax: 'new C1()')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          IObjectCreationOperation (Constructor: C1..ctor()) (OperationKind.ObjectCreation, Type: C1) (Syntax: 'new C1()')
            Arguments(0)
            Initializer: 
              null
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 46608, 46661);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 46677, 46883);

                f_22020_46677_46882(source, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: f_22020_46846_46874().Verify);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 45453, 46894);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 45453, 46894);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 45453, 46894);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Implicit_ReferenceClassToInterfaceConversion_Invalid()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 46906, 48729);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 47087, 47263);

                string
                source = @"
using System;

interface I1
{
}

class C1
{
    static void Main(string[] args)
    {
        I1 /*<bind>*/i1 = new C1()/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 47277, 48094);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: I1 i1) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'i1 = new C1()')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '= new C1()')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: I1, IsInvalid, IsImplicit) (Syntax: 'new C1()')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          IObjectCreationOperation (Constructor: C1..ctor()) (OperationKind.ObjectCreation, Type: C1, IsInvalid) (Syntax: 'new C1()')
            Arguments(0)
            Initializer: 
              null
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 48108, 48496);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22020_48377_48480(f_22020_48377_48459(f_22020_48377_48433(ErrorCode.ERR_NoImplicitConvCast, "new C1()"), "C1", "I1"), 12, 27)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 48512, 48718);

                f_22020_48512_48717(source, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: f_22020_48681_48709().Verify);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 46906, 48729);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 46906, 48729);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 46906, 48729);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Implicit_ReferenceInterfaceToClassConversion_Invalid()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 48741, 50429);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 48922, 49098);

                string
                source = @"
using System;

interface I1
{
}

class C1
{
    static void Main(string[] args)
    {
        C1 /*<bind>*/i1 = new I1()/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 49112, 49841);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: C1 i1) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'i1 = new I1()')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '= new I1()')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: C1, IsInvalid, IsImplicit) (Syntax: 'new I1()')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          IInvalidOperation (OperationKind.Invalid, Type: I1, IsInvalid) (Syntax: 'new I1()')
            Children(0)
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 49855, 50196);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22020_50088_50180(f_22020_50088_50159(f_22020_50088_50139(ErrorCode.ERR_NoNewAbstract, "new I1()"), "I1"), 12, 27)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 50212, 50418);

                f_22020_50212_50417(source, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: f_22020_50381_50409().Verify);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 48741, 50429);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 48741, 50429);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 48741, 50429);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Implicit_ReferenceInterfaceToInterfaceConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 50441, 51815);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 50618, 50847);

                string
                source = @"
using System;

interface I1
{
}

interface I2 : I1
{
}

class C1 : I2
{
    static void Main(string[] args)
    {
        I2 i2 = new C1();
        I1 /*<bind>*/i1 = i2/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 50861, 51515);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: I1 i1) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'i1 = i2')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= i2')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: I1, IsImplicit) (Syntax: 'i2')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          ILocalReferenceOperation: i2 (OperationKind.LocalReference, Type: I2) (Syntax: 'i2')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 51529, 51582);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 51598, 51804);

                f_22020_51598_51803(source, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: f_22020_51767_51795().Verify);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 50441, 51815);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 50441, 51815);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 50441, 51815);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Implicit_ReferenceInterfaceToInterfaceConversion_Invalid()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 51827, 53571);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 52012, 52236);

                string
                source = @"
using System;

interface I1
{
}

interface I2
{
}

class C1 : I2
{
    static void Main(string[] args)
    {
        I2 i2 = new C1();
        I1 /*<bind>*/i1 = i2/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 52250, 52948);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: I1 i1) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'i1 = i2')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '= i2')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: I1, IsInvalid, IsImplicit) (Syntax: 'i2')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          ILocalReferenceOperation: i2 (OperationKind.LocalReference, Type: I2, IsInvalid) (Syntax: 'i2')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 52962, 53338);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22020_53225_53322(f_22020_53225_53301(f_22020_53225_53275(ErrorCode.ERR_NoImplicitConvCast, "i2"), "I2", "I1"), 17, 27)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 53354, 53560);

                f_22020_53354_53559(source, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: f_22020_53523_53551().Verify);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 51827, 53571);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 51827, 53571);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 51827, 53571);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Implicit_ReferenceArrayToArrayConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 53583, 54960);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 53752, 53965);

                string
                source = @"
using System;

class C1
{
    static void Main(string[] args)
    {
        C2[] c2arr = new C2[10];
        C1[] /*<bind>*/c1arr = c2arr/*</bind>*/;
    }
}

class C2 : C1
{
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 53979, 54660);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: C1[] c1arr) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'c1arr = c2arr')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= c2arr')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: C1[], IsImplicit) (Syntax: 'c2arr')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          ILocalReferenceOperation: c2arr (OperationKind.LocalReference, Type: C2[]) (Syntax: 'c2arr')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 54674, 54727);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 54743, 54949);

                f_22020_54743_54948(source, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: f_22020_54912_54940().Verify);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 53583, 54960);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 53583, 54960);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 53583, 54960);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Implicit_ReferenceArrayToArrayConversion_InvalidDimensionMismatch()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 54972, 56712);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 55166, 55381);

                string
                source = @"
using System;

class C1
{
    static void Main(string[] args)
    {
        C2[] c2arr = new C2[10];
        C1[][] /*<bind>*/c1arr = c2arr/*</bind>*/;
    }
}

class C2 : C1
{
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 55395, 56126);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: C1[][] c1arr) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'c1arr = c2arr')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '= c2arr')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: C1[][], IsInvalid, IsImplicit) (Syntax: 'c2arr')
        Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          ILocalReferenceOperation: c2arr (OperationKind.LocalReference, Type: C2[], IsInvalid) (Syntax: 'c2arr')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 56140, 56479);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22020_56362_56463(f_22020_56362_56443(f_22020_56362_56411(ErrorCode.ERR_NoImplicitConv, "c2arr"), "C2[]", "C1[][]"), 9, 34)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 56495, 56701);

                f_22020_56495_56700(source, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: f_22020_56664_56692().Verify);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 54972, 56712);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 54972, 56712);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 54972, 56712);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Implicit_ReferenceArrayToArrayConversion_InvalidNoReferenceConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 56724, 58451);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 56922, 57130);

                string
                source = @"
using System;

class C1
{
    static void Main(string[] args)
    {
        C2[] c2arr = new C2[10];
        C1[] /*<bind>*/c1arr = c2arr/*</bind>*/;
    }
}

class C2
{
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 57144, 57871);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: C1[] c1arr) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'c1arr = c2arr')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '= c2arr')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: C1[], IsInvalid, IsImplicit) (Syntax: 'c2arr')
        Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          ILocalReferenceOperation: c2arr (OperationKind.LocalReference, Type: C2[], IsInvalid) (Syntax: 'c2arr')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 57885, 58218);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22020_58103_58202(f_22020_58103_58182(f_22020_58103_58152(ErrorCode.ERR_NoImplicitConv, "c2arr"), "C2[]", "C1[]"), 9, 32)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 58234, 58440);

                f_22020_58234_58439(source, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: f_22020_58403_58431().Verify);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 56724, 58451);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 56724, 58451);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 56724, 58451);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Implicit_ReferenceArrayToArrayConversion_InvalidValueTypeToReferenceType()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 58463, 60412);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 58664, 58871);

                string
                source = @"
using System;

class C1
{
    static void Main(string[] args)
    {
        I1[] /*<bind>*/i1arr = new S1[10]/*</bind>*/;
    }
}

interface I1
{
}

struct S1 : I1
{
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 58885, 59822);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: I1[] i1arr) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'i1arr = new S1[10]')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '= new S1[10]')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: I1[], IsInvalid, IsImplicit) (Syntax: 'new S1[10]')
        Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          IArrayCreationOperation (OperationKind.ArrayCreation, Type: S1[], IsInvalid) (Syntax: 'new S1[10]')
            Dimension Sizes(1):
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 10, IsInvalid) (Syntax: '10')
            Initializer: 
              null
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 59836, 60179);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22020_60059_60163(f_22020_60059_60143(f_22020_60059_60113(ErrorCode.ERR_NoImplicitConv, "new S1[10]"), "S1[]", "I1[]"), 8, 32)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 60195, 60401);

                f_22020_60195_60400(source, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: f_22020_60364_60392().Verify);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 58463, 60412);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 58463, 60412);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 58463, 60412);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Implicit_ReferenceArrayToSystemArrayConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 60424, 61993);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 60599, 60762);

                string
                source = @"
using System;

class C1
{
    static void Main(string[] args)
    {
        Array /*<bind>*/a1 = new object[10]/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 60776, 61693);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: System.Array a1) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'a1 = new object[10]')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= new object[10]')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Array, IsImplicit) (Syntax: 'new object[10]')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          IArrayCreationOperation (OperationKind.ArrayCreation, Type: System.Object[]) (Syntax: 'new object[10]')
            Dimension Sizes(1):
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 10) (Syntax: '10')
            Initializer: 
              null
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 61707, 61760);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 61776, 61982);

                f_22020_61776_61981(source, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: f_22020_61945_61973().Verify);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 60424, 61993);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 60424, 61993);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 60424, 61993);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Implicit_ReferenceArrayToSystemArrayConversion_MultiDimensionalArray()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 62005, 63592);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 62202, 62364);

                string
                source = @"
using System;

class C1
{
    static void Main(string[] args)
    {
        Array /*<bind>*/a1 = new int[10][]/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 62378, 63292);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: System.Array a1) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'a1 = new int[10][]')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= new int[10][]')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Array, IsImplicit) (Syntax: 'new int[10][]')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          IArrayCreationOperation (OperationKind.ArrayCreation, Type: System.Int32[][]) (Syntax: 'new int[10][]')
            Dimension Sizes(1):
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 10) (Syntax: '10')
            Initializer: 
              null
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 63306, 63359);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 63375, 63581);

                f_22020_63375_63580(source, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: f_22020_63544_63572().Verify);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 62005, 63592);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 62005, 63592);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 62005, 63592);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Implicit_ReferenceArrayToSystemArrayConversion_InvalidNotArrayType()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 63604, 65522);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 63799, 63960);

                string
                source = @"
using System;

class C1
{
    static void Main(string[] args)
    {
        Array /*<bind>*/a1 = new object()/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 63974, 64849);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: System.Array a1) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'a1 = new object()')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '= new object()')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Array, IsInvalid, IsImplicit) (Syntax: 'new object()')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          IObjectCreationOperation (Constructor: System.Object..ctor()) (OperationKind.ObjectCreation, Type: System.Object, IsInvalid) (Syntax: 'new object()')
            Arguments(0)
            Initializer: 
              null
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 64863, 65289);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22020_65153_65273(f_22020_65153_65253(f_22020_65153_65213(ErrorCode.ERR_NoImplicitConvCast, "new object()"), "object", "System.Array"), 8, 30)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 65305, 65511);

                f_22020_65305_65510(source, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: f_22020_65474_65502().Verify);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 63604, 65522);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 63604, 65522);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 63604, 65522);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Implicit_ReferenceArrayToIListTConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 65534, 67175);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 65704, 65889);

                string
                source = @"
using System.Collections.Generic;

class C1
{
    static void Main(string[] args)
    {
        IList<int> /*<bind>*/a1 = new int[10]/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 65903, 66875);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: System.Collections.Generic.IList<System.Int32> a1) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'a1 = new int[10]')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= new int[10]')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Collections.Generic.IList<System.Int32>, IsImplicit) (Syntax: 'new int[10]')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          IArrayCreationOperation (OperationKind.ArrayCreation, Type: System.Int32[]) (Syntax: 'new int[10]')
            Dimension Sizes(1):
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 10) (Syntax: '10')
            Initializer: 
              null
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 66889, 66942);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 66958, 67164);

                f_22020_66958_67163(source, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: f_22020_67127_67155().Verify);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 65534, 67175);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 65534, 67175);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 65534, 67175);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Implicit_ReferenceArrayToIListTConversion_InvalidNonArrayType()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 67187, 69248);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 67377, 67563);

                string
                source = @"
using System.Collections.Generic;

class C1
{
    static void Main(string[] args)
    {
        IList<int> /*<bind>*/a1 = new object()/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 67577, 68520);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: System.Collections.Generic.IList<System.Int32> a1) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'a1 = new object()')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '= new object()')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Collections.Generic.IList<System.Int32>, IsInvalid, IsImplicit) (Syntax: 'new object()')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          IObjectCreationOperation (Constructor: System.Object..ctor()) (OperationKind.ObjectCreation, Type: System.Object, IsInvalid) (Syntax: 'new object()')
            Arguments(0)
            Initializer: 
              null
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 68534, 69015);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22020_68854_68999(f_22020_68854_68979(f_22020_68854_68914(ErrorCode.ERR_NoImplicitConvCast, "new object()"), "object", "System.Collections.Generic.IList<int>"), 8, 35)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 69031, 69237);

                f_22020_69031_69236(source, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: f_22020_69200_69228().Verify);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 67187, 69248);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 67187, 69248);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 67187, 69248);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Implicit_ReferenceDelegateTypeToSystemDelegateConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 69260, 70660);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 69445, 69660);

                string
                source = @"
using System;

class C1
{
    delegate void DType();
    void M1()
    {
        DType d1 = M2;
        Delegate /*<bind>*/d2 = d1/*</bind>*/;
    }

    void M2()
    {
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 69674, 70360);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: System.Delegate d2) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'd2 = d1')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= d1')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Delegate, IsImplicit) (Syntax: 'd1')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          ILocalReferenceOperation: d1 (OperationKind.LocalReference, Type: C1.DType) (Syntax: 'd1')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 70374, 70427);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 70443, 70649);

                f_22020_70443_70648(source, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: f_22020_70612_70640().Verify);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 69260, 70660);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 69260, 70660);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 69260, 70660);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Implicit_ReferenceDelegateTypeToSystemDelegateConversion_InvalidNonDelegateType()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 70672, 72653);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 70880, 71097);

                string
                source = @"
using System;

class C1
{
    delegate void DType();
    void M1()
    {
        DType d1 = M2;
        Delegate /*<bind>*/d2 = d1()/*</bind>*/;
    }

    void M2()
    {
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 71111, 72051);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: System.Delegate d2) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'd2 = d1()')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '= d1()')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Delegate, IsInvalid, IsImplicit) (Syntax: 'd1()')
        Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          IInvocationOperation (virtual void C1.DType.Invoke()) (OperationKind.Invocation, Type: System.Void, IsInvalid) (Syntax: 'd1()')
            Instance Receiver: 
              ILocalReferenceOperation: d1 (OperationKind.LocalReference, Type: C1.DType, IsInvalid) (Syntax: 'd1')
            Arguments(0)
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 72065, 72420);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22020_72294_72404(f_22020_72294_72383(f_22020_72294_72342(ErrorCode.ERR_NoImplicitConv, "d1()"), "void", "System.Delegate"), 10, 33)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 72436, 72642);

                f_22020_72436_72641(source, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: f_22020_72605_72633().Verify);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 70672, 72653);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 70672, 72653);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 70672, 72653);
            }
        }

        [Fact(Skip = "https://github.com/dotnet/roslyn/issues/20175")]
        public void ConversionExpression_Implicit_ReferenceDelegateTypeToSystemDelegateConversion_InvalidSyntax()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 72665, 74213);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 72867, 73055);

                string
                source = @"
using System;

class C1
{
    delegate void DType();
    void M1()
    {
        Delegate /*<bind>*/d2 =/*</bind>*/;
    }

    void M2()
    {
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 73069, 73672);

                string
                expectedOperationTree = @"
IVariableDeclarationStatement (1 declarators) (OperationKind.VariableDeclarationStatement, IsInvalid) (Syntax: 'Delegate /* ... *</bind>*/;')
  IVariableDeclaration (1 variables) (OperationKind.VariableDeclaration, IsInvalid) (Syntax: 'Delegate /* ... *</bind>*/;')
    Variables: Local_1: System.Delegate d2
    Initializer: IConversionExpression (ConversionKind.Invalid, Implicit) (OperationKind.ConversionExpression, Type: System.Delegate, IsInvalid) (Syntax: '')
        IInvalidExpression (OperationKind.InvalidExpression, Type: ?, IsInvalid) (Syntax: '')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 73686, 73980);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22020_73879_73964(f_22020_73879_73944(f_22020_73879_73925(ErrorCode.ERR_InvalidExprTerm, ";"), ";"), 9, 43)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 73996, 74202);

                f_22020_73996_74201(source, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: f_22020_74165_74193().Verify);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 72665, 74213);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 72665, 74213);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 72665, 74213);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Implicit_ReferenceTransitiveConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 74225, 75640);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 74392, 74553);

                string
                source = @"
class C1
{
    void M1()
    {
        C1 /*<bind>*/c1 = new C3()/*</bind>*/;
    }
}

class C2 : C1
{
}

class C3 : C2
{
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 74567, 75340);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: C1 c1) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'c1 = new C3()')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= new C3()')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: C1, IsImplicit) (Syntax: 'new C3()')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          IObjectCreationOperation (Constructor: C3..ctor()) (OperationKind.ObjectCreation, Type: C3) (Syntax: 'new C3()')
            Arguments(0)
            Initializer: 
              null
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 75354, 75407);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 75423, 75629);

                f_22020_75423_75628(source, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: f_22020_75592_75620().Verify);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 74225, 75640);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 74225, 75640);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 74225, 75640);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Implicit_ReferenceCovarianceTransitiveConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 75652, 77066);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 75829, 76086);

                string
                source = @"
interface I1<in T>
{
}

class C1<T> : I1<T>
{
    void M1()
    {
        C2<C3> c2 = new C2<C3>();
        I1<C4> /*<bind>*/c1 = c2/*</bind>*/;
    }
}

class C2<T> : C1<T>
{
}

class C3
{
}

class C4 : C3
{
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 76100, 76766);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: I1<C4> c1) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'c1 = c2')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= c2')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: I1<C4>, IsImplicit) (Syntax: 'c2')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          ILocalReferenceOperation: c2 (OperationKind.LocalReference, Type: C2<C3>) (Syntax: 'c2')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 76780, 76833);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 76849, 77055);

                f_22020_76849_77054(source, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: f_22020_77018_77046().Verify);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 75652, 77066);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 75652, 77066);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 75652, 77066);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Implicit_ReferenceCovarianceTransitiveConversion_Invalid()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 77078, 78887);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 77263, 77520);

                string
                source = @"
interface I1<in T>
{
}

class C1<T> : I1<T>
{
    void M1()
    {
        C2<C4> c2 = new C2<C4>();
        I1<C3> /*<bind>*/c1 = c2/*</bind>*/;
    }
}

class C2<T> : C1<T>
{
}

class C3
{
}

class C4 : C3
{
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 77534, 78244);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: I1<C3> c1) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'c1 = c2')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '= c2')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: I1<C3>, IsInvalid, IsImplicit) (Syntax: 'c2')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          ILocalReferenceOperation: c2 (OperationKind.LocalReference, Type: C2<C4>, IsInvalid) (Syntax: 'c2')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 78258, 78654);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22020_78533_78638(f_22020_78533_78617(f_22020_78533_78583(ErrorCode.ERR_NoImplicitConvCast, "c2"), "C2<C4>", "I1<C3>"), 11, 31)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 78670, 78876);

                f_22020_78670_78875(source, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: f_22020_78839_78867().Verify);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 77078, 78887);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 77078, 78887);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 77078, 78887);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Implicit_ReferenceContravarianceTransitiveConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 78899, 80318);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 79080, 79338);

                string
                source = @"
interface I1<out T>
{
}

class C1<T> : I1<T>
{
    void M1()
    {
        C2<C4> c2 = new C2<C4>();
        I1<C3> /*<bind>*/c1 = c2/*</bind>*/;
    }
}

class C2<T> : C1<T>
{
}

class C3
{
}

class C4 : C3
{
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 79352, 80018);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: I1<C3> c1) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'c1 = c2')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= c2')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: I1<C3>, IsImplicit) (Syntax: 'c2')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          ILocalReferenceOperation: c2 (OperationKind.LocalReference, Type: C2<C4>) (Syntax: 'c2')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 80032, 80085);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 80101, 80307);

                f_22020_80101_80306(source, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: f_22020_80270_80298().Verify);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 78899, 80318);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 78899, 80318);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 78899, 80318);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Implicit_ReferenceContravarianceTransitiveConversion_Invalid()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 80330, 82144);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 80519, 80777);

                string
                source = @"
interface I1<out T>
{
}

class C1<T> : I1<T>
{
    void M1()
    {
        C2<C3> c2 = new C2<C3>();
        I1<C4> /*<bind>*/c1 = c2/*</bind>*/;
    }
}

class C2<T> : C1<T>
{
}

class C3
{
}

class C4 : C3
{
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 80791, 81501);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: I1<C4> c1) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'c1 = c2')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '= c2')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: I1<C4>, IsInvalid, IsImplicit) (Syntax: 'c2')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          ILocalReferenceOperation: c2 (OperationKind.LocalReference, Type: C2<C3>, IsInvalid) (Syntax: 'c2')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 81515, 81911);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22020_81790_81895(f_22020_81790_81874(f_22020_81790_81840(ErrorCode.ERR_NoImplicitConvCast, "c2"), "C2<C3>", "I1<C4>"), 11, 31)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 81927, 82133);

                f_22020_81927_82132(source, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: f_22020_82096_82124().Verify);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 80330, 82144);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 80330, 82144);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 80330, 82144);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Implicit_ReferenceInvariantTransitiveConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 82156, 83825);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 82332, 82514);

                string
                source = @"
using System.Collections.Generic;

class C1
{
    static void M1()
    {
        IList<string> /*<bind>*/list = new List<string>()/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 82528, 83525);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: System.Collections.Generic.IList<System.String> list) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'list = new  ... t<string>()')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= new List<string>()')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Collections.Generic.IList<System.String>, IsImplicit) (Syntax: 'new List<string>()')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          IObjectCreationOperation (Constructor: System.Collections.Generic.List<System.String>..ctor()) (OperationKind.ObjectCreation, Type: System.Collections.Generic.List<System.String>) (Syntax: 'new List<string>()')
            Arguments(0)
            Initializer: 
              null
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 83539, 83592);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 83608, 83814);

                f_22020_83608_83813(source, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: f_22020_83777_83805().Verify);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 82156, 83825);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 82156, 83825);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 82156, 83825);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Implicit_ReferenceTypeParameterClassConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 83837, 85246);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 84012, 84190);

                string
                source = @"
class C1
{
    static void M1<T>()
        where T : C2, new()
    {
        C1 /*<bind>*/c1 = new T()/*</bind>*/;
    }
}

class C2 : C1
{

}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 84204, 84946);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: C1 c1) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'c1 = new T()')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= new T()')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: C1, IsImplicit) (Syntax: 'new T()')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          ITypeParameterObjectCreationOperation (OperationKind.TypeParameterObjectCreation, Type: T) (Syntax: 'new T()')
            Initializer: 
              null
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 84960, 85013);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 85029, 85235);

                f_22020_85029_85234(source, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: f_22020_85198_85226().Verify);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 83837, 85246);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 83837, 85246);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 83837, 85246);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Implicit_ReferenceTypeParameterClassConversion_InvalidConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 85258, 87003);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 85451, 85632);

                string
                source = @"
class C1
{
    static void M1<T>()
        where T : class, new()
    {
        C1 /*<bind>*/c1 = new T()/*</bind>*/;
    }
}

class C2 : C1
{

}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 85646, 86434);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: C1 c1) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'c1 = new T()')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '= new T()')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: C1, IsInvalid, IsImplicit) (Syntax: 'new T()')
        Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          ITypeParameterObjectCreationOperation (OperationKind.TypeParameterObjectCreation, Type: T, IsInvalid) (Syntax: 'new T()')
            Initializer: 
              null
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 86448, 86770);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22020_86658_86754(f_22020_86658_86734(f_22020_86658_86709(ErrorCode.ERR_NoImplicitConv, "new T()"), "T", "C1"), 7, 27)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 86786, 86992);

                f_22020_86786_86991(source, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: f_22020_86955_86983().Verify);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 85258, 87003);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 85258, 87003);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 85258, 87003);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Implicit_ReferenceTypeParameterInterfaceConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 87015, 88430);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 87194, 87374);

                string
                source = @"
interface I1
{
}

class C1 : I1
{
    static void M1<T>()
        where T : C1, new()
    {
        I1 /*<bind>*/i1 = new T()/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 87388, 88130);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: I1 i1) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'i1 = new T()')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= new T()')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: I1, IsImplicit) (Syntax: 'new T()')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          ITypeParameterObjectCreationOperation (OperationKind.TypeParameterObjectCreation, Type: T) (Syntax: 'new T()')
            Initializer: 
              null
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 88144, 88197);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 88213, 88419);

                f_22020_88213_88418(source, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: f_22020_88382_88410().Verify);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 87015, 88430);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 87015, 88430);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 87015, 88430);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Implicit_ReferenceTypeParameterToInterfaceConversion_InvalidConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 88442, 90247);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 88641, 88816);

                string
                source = @"
interface I1
{
}

class C1
{
    static void M1<T>()
        where T : C1, new()
    {
        I1 /*<bind>*/i1 = new T()/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 88830, 89616);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: I1 i1) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'i1 = new T()')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '= new T()')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: I1, IsInvalid, IsImplicit) (Syntax: 'new T()')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          ITypeParameterObjectCreationOperation (OperationKind.TypeParameterObjectCreation, Type: T, IsInvalid) (Syntax: 'new T()')
            Initializer: 
              null
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 89630, 90014);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22020_89897_89998(f_22020_89897_89977(f_22020_89897_89952(ErrorCode.ERR_NoImplicitConvCast, "new T()"), "T", "I1"), 11, 27)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 90030, 90236);

                f_22020_90030_90235(source, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: f_22020_90199_90227().Verify);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 88442, 90247);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 88442, 90247);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 88442, 90247);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Implicit_ReferenceTypeParameterToConstraintParameterConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 90259, 91703);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 90450, 90650);

                string
                source = @"
interface I1
{
}

class C1
{
    static void M1<T, U>()
        where T : U, new()
        where U : class
    {
        U /*<bind>*/u = new T()/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 90664, 91403);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: U u) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'u = new T()')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= new T()')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: U, IsImplicit) (Syntax: 'new T()')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          ITypeParameterObjectCreationOperation (OperationKind.TypeParameterObjectCreation, Type: T) (Syntax: 'new T()')
            Initializer: 
              null
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 91417, 91470);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 91486, 91692);

                f_22020_91486_91691(source, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: f_22020_91655_91683().Verify);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 90259, 91703);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 90259, 91703);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 90259, 91703);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Implicit_ReferenceTypeParameterToConstraintParameter_InvalidConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 91715, 93482);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 91914, 92118);

                string
                source = @"
interface I1
{
}

class C1
{
    static void M1<T, U>()
        where T : class, new()
        where U : class
    {
        U /*<bind>*/u = new T()/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 92132, 92916);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: U u) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'u = new T()')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '= new T()')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: U, IsInvalid, IsImplicit) (Syntax: 'new T()')
        Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          ITypeParameterObjectCreationOperation (OperationKind.TypeParameterObjectCreation, Type: T, IsInvalid) (Syntax: 'new T()')
            Initializer: 
              null
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 92930, 93249);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22020_93137_93233(f_22020_93137_93212(f_22020_93137_93188(ErrorCode.ERR_NoImplicitConv, "new T()"), "T", "U"), 12, 25)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 93265, 93471);

                f_22020_93265_93470(source, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: f_22020_93434_93462().Verify);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 91715, 93482);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 91715, 93482);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 91715, 93482);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Implicit_ReferenceTypeParameterFromNull()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 93494, 95098);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 93662, 93838);

                string
                source = @"
interface I1
{
}

class C1
{
    static void M1<T, U>()
        where T : class, new()
    {
        T /*<bind>*/t = null/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 93852, 94526);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: T t) (OperationKind.VariableDeclarator, Type: null) (Syntax: 't = null')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= null')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: T, Constant: null, IsImplicit) (Syntax: 'null')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 94540, 94865);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22020_94759_94849(f_22020_94759_94828(f_22020_94759_94809(ErrorCode.WRN_UnreferencedVarAssg, "t"), "t"), 11, 21)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 94881, 95087);

                f_22020_94881_95086(source, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: f_22020_95050_95078().Verify);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 93494, 95098);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 93494, 95098);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 93494, 95098);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Implicit_ReferenceTypeParameterFromNull_InvalidNoReferenceConstraint()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 95110, 96836);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 95307, 95476);

                string
                source = @"
interface I1
{
}

class C1
{
    static void M1<T, U>()
        where T : new()
    {
        T /*<bind>*/t = null/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 95490, 96194);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: T t) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 't = null')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '= null')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: T, IsInvalid, IsImplicit) (Syntax: 'null')
        Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          ILiteralOperation (OperationKind.Literal, Type: null, Constant: null, IsInvalid) (Syntax: 'null')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 96208, 96603);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22020_96496_96587(f_22020_96496_96566(f_22020_96496_96547(ErrorCode.ERR_TypeVarCantBeNull, "null"), "T"), 11, 25)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 96619, 96825);

                f_22020_96619_96824(source, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: f_22020_96788_96816().Verify);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 95110, 96836);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 95110, 96836);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 95110, 96836);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Implicit_BoxingNonNullableValueToObjectConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 96848, 98160);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 97026, 97166);

                string
                source = @"

class C1
{
    static void M1()
    {
        int i = 1;
        object /*<bind>*/o = i/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 97180, 97860);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: System.Object o) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'o = i')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= i')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsImplicit) (Syntax: 'i')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 97874, 97927);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 97943, 98149);

                f_22020_97943_98148(source, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: f_22020_98112_98140().Verify);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 96848, 98160);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 96848, 98160);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 96848, 98160);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Implicit_BoxingNonNullableValueToDynamicConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 98172, 99474);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 98351, 98492);

                string
                source = @"

class C1
{
    static void M1()
    {
        int i = 1;
        dynamic /*<bind>*/d = i/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 98506, 99174);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: dynamic d) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'd = i')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= i')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: dynamic, IsImplicit) (Syntax: 'i')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 99188, 99241);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 99257, 99463);

                f_22020_99257_99462(source, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: f_22020_99426_99454().Verify);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 98172, 99474);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 98172, 99474);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 98172, 99474);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Implicit_BoxingValueToSystemValueTypeConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 99486, 100920);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 99662, 99804);

                string
                source = @"
using System;

struct S1
{
    void M1()
    {
        ValueType /*<bind>*/v1 = new S1()/*</bind>*/;
    }
}

"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 99818, 100620);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: System.ValueType v1) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'v1 = new S1()')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= new S1()')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.ValueType, IsImplicit) (Syntax: 'new S1()')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          IObjectCreationOperation (Constructor: S1..ctor()) (OperationKind.ObjectCreation, Type: S1) (Syntax: 'new S1()')
            Arguments(0)
            Initializer: 
              null
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 100634, 100687);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 100703, 100909);

                f_22020_100703_100908(source, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: f_22020_100872_100900().Verify);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 99486, 100920);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 99486, 100920);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 99486, 100920);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Implicit_BoxingNonNullableValueToSystemValueTypeConversion_InvalidNonValueType()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 100932, 102749);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 101139, 101280);

                string
                source = @"
using System;

class C1
{
    void M1()
    {
        ValueType /*<bind>*/v1 = new C1()/*</bind>*/;
    }
}

"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 101294, 102141);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: System.ValueType v1) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'v1 = new C1()')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '= new C1()')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.ValueType, IsInvalid, IsImplicit) (Syntax: 'new C1()')
        Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          IObjectCreationOperation (Constructor: C1..ctor()) (OperationKind.ObjectCreation, Type: C1, IsInvalid) (Syntax: 'new C1()')
            Arguments(0)
            Initializer: 
              null
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 102155, 102516);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22020_102388_102500(f_22020_102388_102480(f_22020_102388_102440(ErrorCode.ERR_NoImplicitConv, "new C1()"), "C1", "System.ValueType"), 8, 34)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 102532, 102738);

                f_22020_102532_102737(source, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: f_22020_102701_102729().Verify);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 100932, 102749);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 100932, 102749);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 100932, 102749);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Implicit_BoxingNonNullableValueToImplementingInterfaceConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 102761, 104185);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 102954, 103097);

                string
                source = @"
interface I1
{
}

struct S1 : I1
{
    void M1()
    {
        I1 /*<bind>*/i1 = new S1()/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 103111, 103885);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: I1 i1) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'i1 = new S1()')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= new S1()')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: I1, IsImplicit) (Syntax: 'new S1()')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          IObjectCreationOperation (Constructor: S1..ctor()) (OperationKind.ObjectCreation, Type: S1) (Syntax: 'new S1()')
            Arguments(0)
            Initializer: 
              null
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 103899, 103952);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 103968, 104174);

                f_22020_103968_104173(source, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: f_22020_104137_104165().Verify);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 102761, 104185);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 102761, 104185);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 102761, 104185);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Implicit_BoxingNonNullableValueToImplementingInterfaceConversion_InvalidNotImplementing()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 104197, 105958);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 104413, 104551);

                string
                source = @"
interface I1
{
}

struct S1
{
    void M1()
    {
        I1 /*<bind>*/i1 = new S1()/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 104565, 105384);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: I1 i1) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'i1 = new S1()')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '= new S1()')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: I1, IsInvalid, IsImplicit) (Syntax: 'new S1()')
        Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          IObjectCreationOperation (Constructor: S1..ctor()) (OperationKind.ObjectCreation, Type: S1, IsInvalid) (Syntax: 'new S1()')
            Arguments(0)
            Initializer: 
              null
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 105398, 105725);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22020_105610_105709(f_22020_105610_105688(f_22020_105610_105662(ErrorCode.ERR_NoImplicitConv, "new S1()"), "S1", "I1"), 10, 27)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 105741, 105947);

                f_22020_105741_105946(source, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: f_22020_105910_105938().Verify);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 104197, 105958);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 104197, 105958);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 104197, 105958);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Implicit_BoxingNullableValueToImplementingInterfaceConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 105970, 107291);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 106160, 106321);

                string
                source = @"
interface I1
{
}

struct S1 : I1
{
    void M1()
    {
        S1? s1 = null;
        I1 /*<bind>*/i1 = s1/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 106335, 106991);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: I1 i1) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'i1 = s1')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= s1')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: I1, IsImplicit) (Syntax: 's1')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          ILocalReferenceOperation: s1 (OperationKind.LocalReference, Type: S1?) (Syntax: 's1')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 107005, 107058);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 107074, 107280);

                f_22020_107074_107279(source, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: f_22020_107243_107271().Verify);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 105970, 107291);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 105970, 107291);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 105970, 107291);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Implicit_BoxingNullableValueToImplementingInterfaceConversion_InvalidNotImplementing()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 107303, 108951);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 107516, 107672);

                string
                source = @"
interface I1
{
}

struct S1
{
    void M1()
    {
        S1? s1 = null;
        I1 /*<bind>*/i1 = s1/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 107686, 108387);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: I1 i1) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'i1 = s1')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '= s1')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: I1, IsInvalid, IsImplicit) (Syntax: 's1')
        Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          ILocalReferenceOperation: s1 (OperationKind.LocalReference, Type: S1?, IsInvalid) (Syntax: 's1')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 108401, 108718);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22020_108608_108702(f_22020_108608_108681(f_22020_108608_108654(ErrorCode.ERR_NoImplicitConv, "s1"), "S1?", "I1"), 11, 27)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 108734, 108940);

                f_22020_108734_108939(source, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: f_22020_108903_108931().Verify);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 107303, 108951);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 107303, 108951);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 107303, 108951);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Implicit_BoxingEnumToSystemEnumConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 108963, 110359);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 109133, 109289);

                string
                source = @"
using System;

enum E1
{
    E
}

struct S1
{
    void M1()
    {
        Enum /*<bind>*/e = E1.E/*</bind>*/;
    }
}

"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 109303, 110059);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: System.Enum e) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'e = E1.E')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= E1.E')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Enum, IsImplicit) (Syntax: 'E1.E')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          IFieldReferenceOperation: E1.E (Static) (OperationKind.FieldReference, Type: E1, Constant: 0) (Syntax: 'E1.E')
            Instance Receiver: 
              null
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 110073, 110126);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 110142, 110348);

                f_22020_110142_110347(source, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: f_22020_110311_110339().Verify);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 108963, 110359);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 108963, 110359);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 108963, 110359);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Implicit_BoxingEnumToSystemEnumConversion_InvalidNotEnum()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 110371, 112021);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 110556, 110709);

                string
                source = @"
using System;

enum E1
{
    E
}

struct S1
{
    void M1()
    {
        Enum /*<bind>*/e = 1/*</bind>*/;
    }
}

"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 110723, 111440);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: System.Enum e) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'e = 1')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '= 1')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Enum, IsInvalid, IsImplicit) (Syntax: '1')
        Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1, IsInvalid) (Syntax: '1')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 111454, 111788);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22020_111670_111772(f_22020_111670_111751(f_22020_111670_111715(ErrorCode.ERR_NoImplicitConv, "1"), "int", "System.Enum"), 13, 28)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 111804, 112010);

                f_22020_111804_112009(source, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: f_22020_111973_112001().Verify);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 110371, 112021);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 110371, 112021);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 110371, 112021);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Implicit_DynamicConversionToClass()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 112033, 113329);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 112195, 112333);

                string
                source = @"
class S1
{
    void M1()
    {
        dynamic d1 = 1;
        string /*<bind>*/s1 = d1/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 112347, 113029);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: System.String s1) (OperationKind.VariableDeclarator, Type: null) (Syntax: 's1 = d1')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= d1')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.String, IsImplicit) (Syntax: 'd1')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          ILocalReferenceOperation: d1 (OperationKind.LocalReference, Type: dynamic) (Syntax: 'd1')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 113043, 113096);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 113112, 113318);

                f_22020_113112_113317(source, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: f_22020_113281_113309().Verify);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 112033, 113329);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 112033, 113329);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 112033, 113329);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Implicit_DynamicConversionToValueType()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 113341, 114639);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 113507, 113645);

                string
                source = @"
class S1
{
    void M1()
    {
        dynamic d1 = null;
        int /*<bind>*/i1 = d1/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 113659, 114339);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: System.Int32 i1) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'i1 = d1')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= d1')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32, IsImplicit) (Syntax: 'd1')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          ILocalReferenceOperation: d1 (OperationKind.LocalReference, Type: dynamic) (Syntax: 'd1')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 114353, 114406);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 114422, 114628);

                f_22020_114422_114627(source, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: f_22020_114591_114619().Verify);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 113341, 114639);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 113341, 114639);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 113341, 114639);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Implicit_ConstantExpressionConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 114651, 116274);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 114817, 114962);

                string
                source = @"
class S1
{
    void M1()
    {
        const int i1 = 1;
        const sbyte /*<bind>*/s1 = i1/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 114976, 115687);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: System.SByte s1) (OperationKind.VariableDeclarator, Type: null) (Syntax: 's1 = i1')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= i1')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.SByte, Constant: 1, IsImplicit) (Syntax: 'i1')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          ILocalReferenceOperation: i1 (OperationKind.LocalReference, Type: System.Int32, Constant: 1) (Syntax: 'i1')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 115701, 116037);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22020_115930_116021(f_22020_115930_116001(f_22020_115930_115981(ErrorCode.WRN_UnreferencedVarAssg, "s1"), "s1"), 7, 31)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 116053, 116263);

                f_22020_116053_116262(source, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: f_22020_116226_116254().Verify);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 114651, 116274);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 114651, 116274);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 114651, 116274);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Implicit_ConstantExpressionConversion_InvalidValueTooLarge()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 116286, 118264);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 116473, 116623);

                string
                source = @"
class S1
{
    void M1()
    {
        const int i1 = 0x1000;
        const sbyte /*<bind>*/s1 = i1/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 116637, 117381);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: System.SByte s1) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 's1 = i1')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '= i1')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.SByte, IsInvalid, IsImplicit) (Syntax: 'i1')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          ILocalReferenceOperation: i1 (OperationKind.LocalReference, Type: System.Int32, Constant: 4096, IsInvalid) (Syntax: 'i1')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 117395, 118031);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22020_117635_117733(f_22020_117635_117713(f_22020_117635_117682(ErrorCode.ERR_ConstOutOfRange, "i1"), "4096", "sbyte"), 7, 36),
f_22020_117924_118015(f_22020_117924_117995(f_22020_117924_117975(ErrorCode.WRN_UnreferencedVarAssg, "s1"), "s1"), 7, 31)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 118047, 118253);

                f_22020_118047_118252(source, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: f_22020_118216_118244().Verify);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 116286, 118264);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 116286, 118264);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 116286, 118264);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Implicit_ConstantExpressionConversion_InvalidNonConstantExpression()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 118276, 119991);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 118471, 118610);

                string
                source = @"
class S1
{
    void M1()
    {
        int i1 = 0;
        const sbyte /*<bind>*/s1 = i1/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 118624, 119352);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: System.SByte s1) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 's1 = i1')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '= i1')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.SByte, IsInvalid, IsImplicit) (Syntax: 'i1')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          ILocalReferenceOperation: i1 (OperationKind.LocalReference, Type: System.Int32, IsInvalid) (Syntax: 'i1')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 119366, 119758);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22020_119642_119742(f_22020_119642_119722(f_22020_119642_119692(ErrorCode.ERR_NoImplicitConvCast, "i1"), "int", "sbyte"), 7, 36)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 119774, 119980);

                f_22020_119774_119979(source, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: f_22020_119943_119971().Verify);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 118276, 119991);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 118276, 119991);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 118276, 119991);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Implicit_UserDefinedConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 120003, 121455);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 120162, 120374);

                string
                source = @"
class C1
{
    void M1()
    {
        C2 /*<bind>*/c2 = this/*</bind>*/;
    }
}

class C2
{
    public static implicit operator C2(C1 c1)
    {
        return null;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 120388, 121155);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: C2 c2) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'c2 = this')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= this')
      IConversionOperation (TryCast: False, Unchecked) (OperatorMethod: C2 C2.op_Implicit(C1 c1)) (OperationKind.Conversion, Type: C2, IsImplicit) (Syntax: 'this')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: True) (MethodSymbol: C2 C2.op_Implicit(C1 c1))
        Operand: 
          IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C1) (Syntax: 'this')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 121169, 121222);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 121238, 121444);

                f_22020_121238_121443(source, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: f_22020_121407_121435().Verify);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 120003, 121455);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 120003, 121455);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 120003, 121455);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Implicit_UserDefinedMultiImplicitStepConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 121467, 123392);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 121643, 121876);

                string
                source = @"
class C1
{
    void M1()
    {
        int i1 = 1;
        C2 /*<bind>*/c2 = i1/*</bind>*/;
    }
}

class C2
{
    public static implicit operator C2(long c1)
    {
        return null;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 121890, 122954);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: C2 c2) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'c2 = i1')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= i1')
      IConversionOperation (TryCast: False, Unchecked) (OperatorMethod: C2 C2.op_Implicit(System.Int64 c1)) (OperationKind.Conversion, Type: C2, IsImplicit) (Syntax: 'i1')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: True) (MethodSymbol: C2 C2.op_Implicit(System.Int64 c1))
        Operand: 
          IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int64, IsImplicit) (Syntax: 'i1')
            Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            Operand: 
              ILocalReferenceOperation: i1 (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i1')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 122968, 123021);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 123037, 123381);

                // LAFHIS: TraceInitializationWrapper
                f_22020_123037_123380(source, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: new ExpectedSymbolVerifier()
                {
                    ConversionChildSelector =  ExpectedSymbolVerifier.NestedConversionChildSelector
                }.Verify);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 123206, 123372);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 121467, 123392);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 121467, 123392);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 121467, 123392);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Implicit_UserDefinedMultiImplicitAndExplicitStepConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 123404, 125927);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 123591, 123914);

                string
                source = @"
class C1
{
    void M1()
    {
        int i1 = 1;
        C2 /*<bind>*/c2 = (int)this/*</bind>*/;
    }

    public static implicit operator int(C1 c1)
    {
        return 1;
    }
}

class C2
{
    public static implicit operator C2(long c1)
    {
        return null;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 123928, 125461);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: C2 c2) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'c2 = (int)this')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= (int)this')
      IConversionOperation (TryCast: False, Unchecked) (OperatorMethod: C2 C2.op_Implicit(System.Int64 c1)) (OperationKind.Conversion, Type: C2, IsImplicit) (Syntax: '(int)this')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: True) (MethodSymbol: C2 C2.op_Implicit(System.Int64 c1))
        Operand: 
          IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int64, IsImplicit) (Syntax: '(int)this')
            Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            Operand: 
              IConversionOperation (TryCast: False, Unchecked) (OperatorMethod: System.Int32 C1.op_Implicit(C1 c1)) (OperationKind.Conversion, Type: System.Int32) (Syntax: '(int)this')
                Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: True) (MethodSymbol: System.Int32 C1.op_Implicit(C1 c1))
                Operand: 
                  IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C1) (Syntax: 'this')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 125475, 125781);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22020_125674_125765(f_22020_125674_125745(f_22020_125674_125725(ErrorCode.WRN_UnreferencedVarAssg, "i1"), "i1"), 6, 13)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 125797, 125916);

                f_22020_125797_125915(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 123404, 125927);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 123404, 125927);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 123404, 125927);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Implicit_UserDefinedMultiImplicitAndExplicitStepConversion_InvalidMissingExplicitConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 125939, 127955);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 126159, 126477);

                string
                source = @"
class C1
{
    void M1()
    {
        int i1 = 1;
        C2 /*<bind>*/c2 = this/*</bind>*/;
    }

    public static implicit operator int(C1 c1)
    {
        return 1;
    }
}

class C2
{
    public static implicit operator C2(long c1)
    {
        return null;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 126491, 127241);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: C2 c2) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'c2 = this')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '= this')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: C2, IsInvalid, IsImplicit) (Syntax: 'this')
        Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C1, IsInvalid) (Syntax: 'this')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 127255, 127809);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22020_127463_127557(f_22020_127463_127537(f_22020_127463_127511(ErrorCode.ERR_NoImplicitConv, "this"), "C1", "C2"), 7, 27),
f_22020_127702_127793(f_22020_127702_127773(f_22020_127702_127753(ErrorCode.WRN_UnreferencedVarAssg, "i1"), "i1"), 6, 13)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 127825, 127944);

                f_22020_127825_127943(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 125939, 127955);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 125939, 127955);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 125939, 127955);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Implicit_UserDefinedMultipleCandidateConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 127967, 129544);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 128143, 128463);

                string
                source = @"
class C1
{
}

class C2 : C1
{
    void M1()
    {
        C3 /*<bind>*/c3 = this/*</bind>*/;
    }
}

class C3
{
    public static implicit operator C3(C1 c1)
    {
        return null;
    }

    public static implicit operator C3(C2 c2)
    {
        return null;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 128477, 129244);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: C3 c3) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'c3 = this')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= this')
      IConversionOperation (TryCast: False, Unchecked) (OperatorMethod: C3 C3.op_Implicit(C2 c2)) (OperationKind.Conversion, Type: C3, IsImplicit) (Syntax: 'this')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: True) (MethodSymbol: C3 C3.op_Implicit(C2 c2))
        Operand: 
          IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C2) (Syntax: 'this')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 129258, 129311);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 129327, 129533);

                f_22020_129327_129532(source, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: f_22020_129496_129524().Verify);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 127967, 129544);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 127967, 129544);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 127967, 129544);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Implicit_PointerFromNullConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 129556, 130919);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 129719, 129857);

                string
                source = @"
using System;

class S1
{
    unsafe void M1()
    {
        void* /*<bind>*/v1 = null/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 129871, 130554);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: System.Void* v1) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'v1 = null')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= null')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Void*, IsImplicit) (Syntax: 'null')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 130568, 130621);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 130635, 130908);

                f_22020_130635_130907(source, expectedOperationTree, expectedDiagnostics, compilationOptions: TestOptions.UnsafeReleaseDll, additionalOperationTreeVerifier: f_22020_130871_130899().Verify);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 129556, 130919);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 129556, 130919);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 129556, 130919);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Implicit_PointerToVoidConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 130931, 132320);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 131092, 131253);

                string
                source = @"
using System;

class S1
{
    unsafe void M1()
    {
        int* i1 = null;
        void* /*<bind>*/v1 = i1/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 131267, 131953);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: System.Void* v1) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'v1 = i1')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= i1')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Void*, IsImplicit) (Syntax: 'i1')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          ILocalReferenceOperation: i1 (OperationKind.LocalReference, Type: System.Int32*) (Syntax: 'i1')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 131967, 132020);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 132036, 132309);

                f_22020_132036_132308(source, expectedOperationTree, expectedDiagnostics, compilationOptions: TestOptions.UnsafeReleaseDll, additionalOperationTreeVerifier: f_22020_132272_132300().Verify);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 130931, 132320);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 130931, 132320);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 130931, 132320);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Implicit_PointerFromVoidConversion_Invalid()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 132332, 134110);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 132503, 132664);

                string
                source = @"
using System;

class S1
{
    unsafe void M1()
    {
        void* v1 = null;
        int* /*<bind>*/i1 = v1/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 132678, 133409);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: System.Int32* i1) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'i1 = v1')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '= v1')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32*, IsInvalid, IsImplicit) (Syntax: 'v1')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          ILocalReferenceOperation: v1 (OperationKind.LocalReference, Type: System.Void*, IsInvalid) (Syntax: 'v1')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 133423, 133810);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22020_133693_133794(f_22020_133693_133774(f_22020_133693_133743(ErrorCode.ERR_NoImplicitConvCast, "v1"), "void*", "int*"), 9, 29)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 133826, 134099);

                f_22020_133826_134098(source, expectedOperationTree, expectedDiagnostics, compilationOptions: TestOptions.UnsafeReleaseDll, additionalOperationTreeVerifier: f_22020_134062_134090().Verify);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 132332, 134110);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 132332, 134110);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 132332, 134110);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Implicit_PointerFromIntegerConversion_Invalid()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 134122, 135864);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 134296, 134431);

                string
                source = @"
using System;

class S1
{
    unsafe void M1()
    {
        void* /*<bind>*/v1 = 0/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 134445, 135165);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: System.Void* v1) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'v1 = 0')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '= 0')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Void*, IsInvalid, IsImplicit) (Syntax: '0')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0, IsInvalid) (Syntax: '0')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 135179, 135564);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22020_135448_135547(f_22020_135448_135527(f_22020_135448_135497(ErrorCode.ERR_NoImplicitConvCast, "0"), "int", "void*"), 8, 30),
                            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 135580, 135853);

                f_22020_135580_135852(source, expectedOperationTree, expectedDiagnostics, compilationOptions: TestOptions.UnsafeReleaseDll, additionalOperationTreeVerifier: f_22020_135816_135844().Verify);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 134122, 135864);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 134122, 135864);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 134122, 135864);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Implicit_ExpressionTreeConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 135876, 138132);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 136038, 136261);

                string
                source = @"
using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        Expression<Func<int, bool>> /*<bind>*/exp = num => num < 5/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 136275, 137832);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: System.Linq.Expressions.Expression<System.Func<System.Int32, System.Boolean>> exp) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'exp = num => num < 5')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= num => num < 5')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Linq.Expressions.Expression<System.Func<System.Int32, System.Boolean>>, IsImplicit) (Syntax: 'num => num < 5')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          IAnonymousFunctionOperation (Symbol: lambda expression) (OperationKind.AnonymousFunction, Type: null) (Syntax: 'num => num < 5')
            IBlockOperation (1 statements) (OperationKind.Block, Type: null, IsImplicit) (Syntax: 'num < 5')
              IReturnOperation (OperationKind.Return, Type: null, IsImplicit) (Syntax: 'num < 5')
                ReturnedValue: 
                  IBinaryOperation (BinaryOperatorKind.LessThan) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'num < 5')
                    Left: 
                      IParameterReferenceOperation: num (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'num')
                    Right: 
                      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 5) (Syntax: '5')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 137846, 137899);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 137915, 138121);

                f_22020_137915_138120(source, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: f_22020_138084_138112().Verify);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 135876, 138132);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 135876, 138132);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 135876, 138132);
            }
        }

        [Fact(Skip = "https://github.com/dotnet/roslyn/issues/20291")]
        public void ConversionExpression_Implicit_ExpressionTreeConversion_InvalidIncorrectLambdaType()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 138144, 141069);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 138336, 138555);

                string
                source = @"
using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        Expression<Func<int, bool>> /*<bind>*/exp = num => num/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 138569, 139848);

                string
                expectedOperationTree = @"
IVariableDeclarationStatement (1 declarators) (OperationKind.VariableDeclarationStatement, IsInvalid) (Syntax: 'Expression< ... *</bind>*/;')
  IVariableDeclaration (1 variables) (OperationKind.VariableDeclaration, IsInvalid) (Syntax: 'Expression< ... *</bind>*/;')
    Variables: Local_1: System.Linq.Expressions.Expression<System.Func<System.Int32, System.Boolean>> exp
    Initializer: IConversionExpression (ConversionKind.Invalid, Implicit) (OperationKind.ConversionExpression, Type: System.Linq.Expressions.Expression<System.Func<System.Int32, System.Boolean>>, IsInvalid) (Syntax: 'num => num')
        IAnonymousFunctionExpression (Symbol: lambda expression) (OperationKind.AnonymousFunctionExpression, Type: null, IsInvalid) (Syntax: 'num => num')
          IBlockStatement (1 statements) (OperationKind.BlockStatement, IsInvalid) (Syntax: 'num')
            IReturnStatement (OperationKind.ReturnStatement, IsInvalid) (Syntax: 'num')
              IConversionExpression (ConversionKind.Invalid, Implicit) (OperationKind.ConversionExpression, Type: System.Boolean, IsInvalid) (Syntax: 'num')
                IParameterReferenceExpression: num (OperationKind.ParameterReferenceExpression, Type: System.Int32) (Syntax: 'num')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 139862, 140634);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22020_140105_140201(f_22020_140105_140181(f_22020_140105_140152(ErrorCode.ERR_NoImplicitConv, "num"), "int", "bool"), 9, 60),
f_22020_140507_140618(f_22020_140507_140598(f_22020_140507_140563(ErrorCode.ERR_CantConvAnonMethReturns, "num"), "lambda expression"), 9, 60)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 140852, 141058);

                f_22020_140852_141057(source, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: f_22020_141021_141049().Verify);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 138144, 141069);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 138144, 141069);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 138144, 141069);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Implicit_ExpressionTreeConversion_InvalidSyntax()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 141081, 143377);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 141257, 141472);

                string
                source = @"
using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        Expression<Func<int, bool>> /*<bind>*/exp = num =>/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 141486, 142809);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: System.Linq.Expressions.Expression<System.Func<System.Int32, System.Boolean>> exp) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'exp = num =>/*</bind>*/')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '= num =>/*</bind>*/')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Linq.Expressions.Expression<System.Func<System.Int32, System.Boolean>>, IsInvalid, IsImplicit) (Syntax: 'num =>/*</bind>*/')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          IAnonymousFunctionOperation (Symbol: lambda expression) (OperationKind.AnonymousFunction, Type: null, IsInvalid) (Syntax: 'num =>/*</bind>*/')
            IBlockOperation (1 statements) (OperationKind.Block, Type: null, IsInvalid, IsImplicit) (Syntax: '')
              IReturnOperation (OperationKind.Return, Type: null, IsInvalid, IsImplicit) (Syntax: '')
                ReturnedValue: 
                  IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid) (Syntax: '')
                    Children(0)
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 142823, 143144);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22020_143043_143128(f_22020_143043_143108(f_22020_143043_143089(ErrorCode.ERR_InvalidExprTerm, ";"), ";"), 9, 70)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 143160, 143366);

                f_22020_143160_143365(source, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: f_22020_143329_143357().Verify);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 141081, 143377);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 141081, 143377);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 141081, 143377);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Implicit_ReturnStatementConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 143389, 144524);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 143552, 143686);

                string
                source = @"
class C1
{
    public long M1()
    {
        int i = 1;
        /*<bind>*/return i;/*</bind>*/
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 143700, 144227);

                string
                expectedOperationTree = @"
IReturnOperation (OperationKind.Return, Type: null) (Syntax: 'return i;')
  ReturnedValue: 
    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int64, IsImplicit) (Syntax: 'i')
      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      Operand: 
        ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 144241, 144294);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 144310, 144513);

                f_22020_144310_144512(source, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: f_22020_144476_144504().Verify);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 143389, 144524);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 143389, 144524);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 143389, 144524);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Implicit_ReturnStatementConversion_InvalidConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 144536, 146051);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 144717, 144852);

                string
                source = @"
class C1
{
    public int M1()
    {
        float f = 1;
        /*<bind>*/return f;/*</bind>*/
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 144866, 145427);

                string
                expectedOperationTree = @"
IReturnOperation (OperationKind.Return, Type: null, IsInvalid) (Syntax: 'return f;')
  ReturnedValue: 
    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'f')
      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      Operand: 
        ILocalReferenceOperation: f (OperationKind.LocalReference, Type: System.Single, IsInvalid) (Syntax: 'f')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 145441, 145821);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22020_145706_145805(f_22020_145706_145785(f_22020_145706_145755(ErrorCode.ERR_NoImplicitConvCast, "f"), "float", "int"), 7, 26)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 145837, 146040);

                f_22020_145837_146039(source, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: f_22020_146003_146031().Verify);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 144536, 146051);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 144536, 146051);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 144536, 146051);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Implicit_CheckedOnlyAppliesToNumeric()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 146063, 148043);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 146228, 146461);

                string
                source = @"
namespace ConsoleApp1
{
    class C1
    {
        static void M1()
        {
            checked
            {
                /*<bind>*/object o = null;/*</bind>*/
            }
        }
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 146475, 147538);

                string
                expectedOperationTree = @"
IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null) (Syntax: 'object o = null;')
  IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'object o = null')
    Declarators:
        IVariableDeclaratorOperation (Symbol: System.Object o) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'o = null')
          Initializer: 
            IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= null')
              IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, Constant: null, IsImplicit) (Syntax: 'null')
                Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                Operand: 
                  ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')
    Initializer: 
      null
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 147552, 147890);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22020_147784_147874(f_22020_147784_147853(f_22020_147784_147834(ErrorCode.WRN_UnreferencedVarAssg, "o"), "o"), 10, 34)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 147906, 148032);

                f_22020_147906_148031(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 146063, 148043);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 146063, 148043);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 146063, 148043);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Implicit_DelegateTypeConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 148055, 149853);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 148215, 148429);

                string
                source = @"
using System;
class Program
{
    void Main()
    {
        Action<object> objectAction = str => { };
        /*<bind>*/Action<string> stringAction = objectAction;/*</bind>*/
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 148443, 149633);

                string
                expectedOperationTree = @"
IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null) (Syntax: 'Action<stri ... jectAction;')
  IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'Action<stri ... bjectAction')
    Declarators:
        IVariableDeclaratorOperation (Symbol: System.Action<System.String> stringAction) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'stringActio ... bjectAction')
          Initializer: 
            IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= objectAction')
              IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Action<System.String>, IsImplicit) (Syntax: 'objectAction')
                Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                Operand: 
                  ILocalReferenceOperation: objectAction (OperationKind.LocalReference, Type: System.Action<System.Object>) (Syntax: 'objectAction')
    Initializer: 
      null
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 149647, 149700);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 149716, 149842);

                f_22020_149716_149841(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 148055, 149853);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 148055, 149853);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 148055, 149853);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Implicit_DelegateTypeConversion_InvalidConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 149865, 152102);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 150043, 150251);

                string
                source = @"
using System;
class Program
{
    void Main()
    {
        Action<object> objectAction = str => { };
        /*<bind>*/Action<int> intAction = objectAction;/*</bind>*/
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 150265, 151515);

                string
                expectedOperationTree = @"
IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsInvalid) (Syntax: 'Action<int> ... jectAction;')
  IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null, IsInvalid) (Syntax: 'Action<int> ... bjectAction')
    Declarators:
        IVariableDeclaratorOperation (Symbol: System.Action<System.Int32> intAction) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'intAction = objectAction')
          Initializer: 
            IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '= objectAction')
              IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Action<System.Int32>, IsInvalid, IsImplicit) (Syntax: 'objectAction')
                Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                Operand: 
                  ILocalReferenceOperation: objectAction (OperationKind.LocalReference, Type: System.Action<System.Object>, IsInvalid) (Syntax: 'objectAction')
    Initializer: 
      null
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 151529, 151949);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22020_151796_151933(f_22020_151796_151913(f_22020_151796_151852(ErrorCode.ERR_NoImplicitConv, "objectAction"), "System.Action<object>", "System.Action<int>"), 8, 43)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 151965, 152091);

                f_22020_151965_152090(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 149865, 152102);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 149865, 152102);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 149865, 152102);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ConversionFlow_01()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 152114, 153740);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 152265, 152380);

                string
                source = @"
class C
{
    void M(int i, long l)
    /*<bind>*/{
        l = i;
    }/*</bind>*/
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 152394, 152447);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 152463, 153617);

                string
                expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (1)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'l = i;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int64) (Syntax: 'l = i')
              Left: 
                IParameterReferenceOperation: l (OperationKind.ParameterReference, Type: System.Int64) (Syntax: 'l')
              Right: 
                IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int64, IsImplicit) (Syntax: 'i')
                  Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    (ImplicitNumeric)
                  Operand: 
                    IParameterReferenceOperation: i (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i')

    Next (Regular) Block[B2]
Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 153631, 153729);

                f_22020_153631_153728(source, expectedFlowGraph, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 152114, 153740);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 152114, 153740);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 152114, 153740);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Explicit_ExplicitIdentityConversionCreatesIConversionExpression()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 153813, 155403);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 154005, 154125);

                string
                source = @"
class C1
{
    public void M1()
    {
        int /*<bind>*/i = (int)1/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 154139, 154828);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: System.Int32 i) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'i = (int)1')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= (int)1')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32, Constant: 1) (Syntax: '(int)1')
        Conversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 154842, 155170);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22020_155065_155154(f_22020_155065_155134(f_22020_155065_155115(ErrorCode.WRN_UnreferencedVarAssg, "i"), "i"), 6, 23)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 155186, 155392);

                f_22020_155186_155391(source, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: f_22020_155355_155383().Verify);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 153813, 155403);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 153813, 155403);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 153813, 155403);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Explicit_ImplicitAndExplicitConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 155415, 157316);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 155582, 155703);

                string
                source = @"
class C1
{
    public void M1()
    {
        long /*<bind>*/i = (int)1/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 155717, 156740);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: System.Int64 i) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'i = (int)1')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= (int)1')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int64, Constant: 1, IsImplicit) (Syntax: '(int)1')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32, Constant: 1) (Syntax: '(int)1')
            Conversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            Operand: 
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 156754, 157083);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22020_156978_157067(f_22020_156978_157047(f_22020_156978_157028(ErrorCode.WRN_UnreferencedVarAssg, "i"), "i"), 6, 24)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 157099, 157305);

                f_22020_157099_157304(source, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: f_22020_157268_157296().Verify);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 155415, 157316);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 155415, 157316);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 155415, 157316);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Explicit_SimpleNumericCast()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 157328, 158529);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 157483, 157605);

                string
                source = @"
class C1
{
    public void M1()
    {
        int i = /*<bind>*/(int)1.0/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 157619, 158043);

                string
                expectedOperationTree = @"
IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32, Constant: 1) (Syntax: '(int)1.0')
  Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
  Operand: 
    ILiteralOperation (OperationKind.Literal, Type: System.Double, Constant: 1) (Syntax: '1.0')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 158057, 158387);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22020_158282_158371(f_22020_158282_158351(f_22020_158282_158332(ErrorCode.WRN_UnreferencedVarAssg, "i"), "i"), 6, 13)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 158403, 158518);

                f_22020_158403_158517(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 157328, 158529);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 157328, 158529);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 157328, 158529);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Explicit_SimpleNumericConversion_InvalidNoImplicitConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 158541, 160817);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 158730, 158854);

                string
                source = @"
class C1
{
    public void M1()
    {
        int /*<bind>*/i = (float)1.0/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 158868, 159966);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: System.Int32 i) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'i = (float)1.0')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '= (float)1.0')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32, Constant: 1, IsInvalid, IsImplicit) (Syntax: '(float)1.0')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Single, Constant: 1, IsInvalid) (Syntax: '(float)1.0')
            Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            Operand: 
              ILiteralOperation (OperationKind.Literal, Type: System.Double, Constant: 1, IsInvalid) (Syntax: '1.0')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 159980, 160671);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22020_160269_160377(f_22020_160269_160357(f_22020_160269_160327(ErrorCode.ERR_NoImplicitConvCast, "(float)1.0"), "float", "int"), 6, 27),
f_22020_160566_160655(f_22020_160566_160635(f_22020_160566_160616(ErrorCode.WRN_UnreferencedVarAssg, "i"), "i"), 6, 23)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 160687, 160806);

                f_22020_160687_160805(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 158541, 160817);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 158541, 160817);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 158541, 160817);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Explicit_SimpleNumericConversion_InvalidSyntax()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 160829, 162694);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 161004, 161124);

                string
                source = @"
class C1
{
    public void M1()
    {
        long /*<bind>*/i = (int)/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 161138, 162239);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: System.Int64 i) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'i = (int)/*</bind>*/')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '= (int)/*</bind>*/')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int64, IsInvalid, IsImplicit) (Syntax: '(int)/*</bind>*/')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32, IsInvalid) (Syntax: '(int)/*</bind>*/')
            Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            Operand: 
              IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid) (Syntax: '')
                Children(0)
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 162253, 162548);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22020_162447_162532(f_22020_162447_162512(f_22020_162447_162493(ErrorCode.ERR_InvalidExprTerm, ";"), ";"), 6, 44)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 162564, 162683);

                f_22020_162564_162682(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 160829, 162694);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 160829, 162694);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 160829, 162694);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Explicit_EnumFromNumericLiteralConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 162706, 164199);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 162876, 163026);

                string
                source = @"
class C1
{
    public void M1()
    {
        E1 /*<bind>*/e1 = (E1)1/*</bind>*/;
    }
}

enum E1
{
    One, Two
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 163040, 163709);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: E1 e1) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'e1 = (E1)1')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= (E1)1')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: E1, Constant: 1) (Syntax: '(E1)1')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 163723, 164053);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22020_163946_164037(f_22020_163946_164017(f_22020_163946_163997(ErrorCode.WRN_UnreferencedVarAssg, "e1"), "e1"), 6, 22)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 164069, 164188);

                f_22020_164069_164187(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 162706, 164199);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 162706, 164199);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 162706, 164199);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Explicit_EnumToNumericTypeConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 164211, 165823);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 164376, 164532);

                string
                source = @"
class C1
{
    public void M1()
    {
        int /*<bind>*/i = (int)E1.One/*</bind>*/;
    }
}

enum E1
{
    One, Two
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 164546, 165330);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: System.Int32 i) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'i = (int)E1.One')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= (int)E1.One')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32, Constant: 0) (Syntax: '(int)E1.One')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          IFieldReferenceOperation: E1.One (Static) (OperationKind.FieldReference, Type: E1, Constant: 0) (Syntax: 'E1.One')
            Instance Receiver: 
              null
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 165344, 165677);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22020_165572_165661(f_22020_165572_165641(f_22020_165572_165622(ErrorCode.WRN_UnreferencedVarAssg, "i"), "i"), 6, 23)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 165693, 165812);

                f_22020_165693_165811(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 164211, 165823);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 164211, 165823);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 164211, 165823);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Explicit_EnumToEnumConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 165835, 167454);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 165993, 166182);

                string
                source = @"
class C1
{
    public void M1()
    {
        E2 /*<bind>*/e2 = (E2)E1.One/*</bind>*/;
    }
}

enum E1
{
    One, Two
}

enum E2
{
    Three, Four
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 166196, 166959);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: E2 e2) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'e2 = (E2)E1.One')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= (E2)E1.One')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: E2, Constant: 0) (Syntax: '(E2)E1.One')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          IFieldReferenceOperation: E1.One (Static) (OperationKind.FieldReference, Type: E1, Constant: 0) (Syntax: 'E1.One')
            Instance Receiver: 
              null
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 166973, 167308);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22020_167201_167292(f_22020_167201_167272(f_22020_167201_167252(ErrorCode.WRN_UnreferencedVarAssg, "e2"), "e2"), 6, 22)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 167324, 167443);

                f_22020_167324_167442(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 165835, 167454);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 165835, 167454);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 165835, 167454);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Explicit_EnumToEnumConversion_InvalidOutOfRange()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 167466, 169672);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 167642, 167832);

                string
                source = @"
class C1
{
    public void M1()
    {
        E2 /*<bind>*/e2 = (E2)E1.One/*</bind>*/;
    }
}

enum E1
{
    One = 1000
}

enum E2 : byte
{
    Two
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 168065, 168862);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: E2 e2) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'e2 = (E2)E1.One')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '= (E2)E1.One')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: E2, IsInvalid) (Syntax: '(E2)E1.One')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          IFieldReferenceOperation: E1.One (Static) (OperationKind.FieldReference, Type: E1, Constant: 1000, IsInvalid) (Syntax: 'E1.One')
            Instance Receiver: 
              null
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 168876, 169526);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22020_169135_169245(f_22020_169135_169225(f_22020_169135_169197(ErrorCode.ERR_ConstOutOfRangeChecked, "(E2)E1.One"), "1000", "E2"), 6, 27),
f_22020_169419_169510(f_22020_169419_169490(f_22020_169419_169470(ErrorCode.WRN_UnreferencedVarAssg, "e2"), "e2"), 6, 22)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 169542, 169661);

                f_22020_169542_169660(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 167466, 169672);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 167466, 169672);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 167466, 169672);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Explicit_NullableToNullableConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 169684, 170931);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 169850, 170017);

                string
                source = @"
class Program
{
    static void Main(string[] args)
    {
        long? l = null;
        int? /*<bind>*/i = (int?)l/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 170031, 170718);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: System.Int32? i) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'i = (int?)l')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= (int?)l')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32?) (Syntax: '(int?)l')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          ILocalReferenceOperation: l (OperationKind.LocalReference, Type: System.Int64?) (Syntax: 'l')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 170732, 170785);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 170801, 170920);

                f_22020_170801_170919(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 169684, 170931);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 169684, 170931);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 169684, 170931);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Explicit_NullableToNonNullableConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 170943, 172186);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 171112, 171277);

                string
                source = @"
class Program
{
    static void Main(string[] args)
    {
        long? l = null;
        int /*<bind>*/i = (int)l/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 171291, 171973);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: System.Int32 i) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'i = (int)l')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= (int)l')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32) (Syntax: '(int)l')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          ILocalReferenceOperation: l (OperationKind.LocalReference, Type: System.Int64?) (Syntax: 'l')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 171987, 172040);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 172056, 172175);

                f_22020_172056_172174(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 170943, 172186);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 170943, 172186);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 170943, 172186);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Explicit_ReferenceFromObjectConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 172198, 173444);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 172365, 172525);

                string
                source = @"
class C1
{
    static void M1()
    {
        object o = string.Empty;
        string /*<bind>*/s = (string)o/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 172539, 173231);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: System.String s) (OperationKind.VariableDeclarator, Type: null) (Syntax: 's = (string)o')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= (string)o')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.String) (Syntax: '(string)o')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          ILocalReferenceOperation: o (OperationKind.LocalReference, Type: System.Object) (Syntax: 'o')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 173245, 173298);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 173314, 173433);

                f_22020_173314_173432(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 172198, 173444);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 172198, 173444);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 172198, 173444);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Explicit_ReferenceFromDynamicConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 173456, 174699);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 173624, 173785);

                string
                source = @"
class C1
{
    static void M1()
    {
        dynamic d = string.Empty;
        string /*<bind>*/s = (string)d/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 173799, 174486);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: System.String s) (OperationKind.VariableDeclarator, Type: null) (Syntax: 's = (string)d')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= (string)d')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.String) (Syntax: '(string)d')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          ILocalReferenceOperation: d (OperationKind.LocalReference, Type: dynamic) (Syntax: 'd')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 174500, 174553);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 174569, 174688);

                f_22020_174569_174687(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 173456, 174699);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 173456, 174699);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 173456, 174699);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Explicit_ReferenceFromSuperclassConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 174711, 175933);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 174882, 175052);

                string
                source = @"
class C1
{
    static void M1()
    {
        C1 c1 = new C2();
        C2 /*<bind>*/c2 = (C2)c1/*</bind>*/;
    }
}

class C2 : C1
{
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 175066, 175720);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: C2 c2) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'c2 = (C2)c1')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= (C2)c1')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: C2) (Syntax: '(C2)c1')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          ILocalReferenceOperation: c1 (OperationKind.LocalReference, Type: C1) (Syntax: 'c1')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 175734, 175787);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 175803, 175922);

                f_22020_175803_175921(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 174711, 175933);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 174711, 175933);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 174711, 175933);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Explicit_ReferenceFromSuperclassConversion_InvalidNoConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 175945, 177486);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 176136, 176301);

                string
                source = @"
class C1
{
    static void M1()
    {
        C1 c1 = new C1();
        C2 /*<bind>*/c2 = (C2)c1/*</bind>*/;
    }
}

class C2
{
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 176315, 177015);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: C2 c2) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'c2 = (C2)c1')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '= (C2)c1')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: C2, IsInvalid) (Syntax: '(C2)c1')
        Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          ILocalReferenceOperation: c1 (OperationKind.LocalReference, Type: C1, IsInvalid) (Syntax: 'c1')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 177029, 177340);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22020_177228_177324(f_22020_177228_177304(f_22020_177228_177278(ErrorCode.ERR_NoExplicitConv, "(C2)c1"), "C1", "C2"), 7, 27)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 177356, 177475);

                f_22020_177356_177474(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 175945, 177486);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 175945, 177486);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 175945, 177486);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Explicit_ReferenceFromImplementedInterfaceConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 177498, 178732);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 177679, 177851);

                string
                source = @"
interface I1 { }

class C1 : I1
{
    static void M1()
    {
        I1 i1 = new C1();
        C1 /*<bind>*/c1 = (C1)i1/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 177865, 178519);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: C1 c1) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'c1 = (C1)i1')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= (C1)i1')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: C1) (Syntax: '(C1)i1')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          ILocalReferenceOperation: i1 (OperationKind.LocalReference, Type: I1) (Syntax: 'i1')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 178533, 178586);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 178602, 178721);

                f_22020_178602_178720(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 177498, 178732);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 177498, 178732);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 177498, 178732);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Explicit_ReferenceFromUnimplementedInterfaceConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 178744, 179971);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 178927, 179090);

                string
                source = @"
interface I1 { }

class C1
{
    static void M1()
    {
        I1 i1 = null;
        C1 /*<bind>*/c1 = (C1)i1/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 179104, 179758);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: C1 c1) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'c1 = (C1)i1')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= (C1)i1')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: C1) (Syntax: '(C1)i1')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          ILocalReferenceOperation: i1 (OperationKind.LocalReference, Type: I1) (Syntax: 'i1')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 179772, 179825);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 179841, 179960);

                f_22020_179841_179959(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 178744, 179971);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 178744, 179971);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 178744, 179971);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Explicit_ReferenceFromUnimplementedInterfaceConversion_InvalidSealedClass()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 179983, 181540);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 180185, 180355);

                string
                source = @"
interface I1 { }

sealed class C1
{
    static void M1()
    {
        I1 i1 = null;
        C1 /*<bind>*/c1 = (C1)i1/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 180369, 181069);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: C1 c1) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'c1 = (C1)i1')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '= (C1)i1')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: C1, IsInvalid) (Syntax: '(C1)i1')
        Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          ILocalReferenceOperation: i1 (OperationKind.LocalReference, Type: I1, IsInvalid) (Syntax: 'i1')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 181083, 181394);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22020_181282_181378(f_22020_181282_181358(f_22020_181282_181332(ErrorCode.ERR_NoExplicitConv, "(C1)i1"), "I1", "C1"), 9, 27)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 181410, 181529);

                f_22020_181410_181528(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 179983, 181540);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 179983, 181540);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 179983, 181540);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Explicit_ReferenceFromInterfaceToInterfaceConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 181552, 182804);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 181733, 181923);

                string
                source = @"
interface I1 { }

interface I2 { }

sealed class C1
{
    static void M1()
    {
        I1 i1 = null;
        I2 /*<bind>*/i2 = (I2)i1/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 181937, 182591);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: I2 i2) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'i2 = (I2)i1')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= (I2)i1')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: I2) (Syntax: '(I2)i1')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          ILocalReferenceOperation: i1 (OperationKind.LocalReference, Type: I1) (Syntax: 'i1')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 182605, 182658);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 182674, 182793);

                f_22020_182674_182792(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 181552, 182804);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 181552, 182804);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 181552, 182804);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Explicit_ReferenceConversion_InvalidSyntax()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 182816, 184310);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 182987, 183134);

                string
                source = @"
interface I2 { }

sealed class C1
{
    static void M1()
    {
        I2 /*<bind>*/i2 = (I2)()/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 183148, 183855);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: I2 i2) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'i2 = (I2)()')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '= (I2)()')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: I2, IsInvalid) (Syntax: '(I2)()')
        Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid) (Syntax: '')
            Children(0)
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 183869, 184164);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22020_184063_184148(f_22020_184063_184128(f_22020_184063_184109(ErrorCode.ERR_InvalidExprTerm, ")"), ")"), 8, 32)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 184180, 184299);

                f_22020_184180_184298(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 182816, 184310);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 182816, 184310);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 182816, 184310);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Explicit_ReferenceArrayTypeToArrayTypeConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 184322, 185597);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 184499, 184683);

                string
                source = @"
class C1
{
    static void M1()
    {
        C1[] c1arr = new C2[1];
        C2[] /*<bind>*/c2arr = (C2[])c1arr/*</bind>*/;
    }
}

class C2 : C1 { }
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 184697, 185384);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: C2[] c2arr) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'c2arr = (C2[])c1arr')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= (C2[])c1arr')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: C2[]) (Syntax: '(C2[])c1arr')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          ILocalReferenceOperation: c1arr (OperationKind.LocalReference, Type: C1[]) (Syntax: 'c1arr')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 185398, 185451);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 185467, 185586);

                f_22020_185467_185585(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 184322, 185597);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 184322, 185597);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 184322, 185597);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Explicit_ReferenceArrayTypeToArrayTypeConversion_InvalidNoElementTypeConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 185609, 187237);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 185817, 185996);

                string
                source = @"
class C1
{
    static void M1()
    {
        C1[] c1arr = new C1[1];
        C2[] /*<bind>*/c2arr = (C2[])c1arr/*</bind>*/;
    }
}

class C2 { }
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 186010, 186743);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: C2[] c2arr) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'c2arr = (C2[])c1arr')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '= (C2[])c1arr')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: C2[], IsInvalid) (Syntax: '(C2[])c1arr')
        Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          ILocalReferenceOperation: c1arr (OperationKind.LocalReference, Type: C1[], IsInvalid) (Syntax: 'c1arr')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 186757, 187091);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22020_186970_187075(f_22020_186970_187055(f_22020_186970_187025(ErrorCode.ERR_NoExplicitConv, "(C2[])c1arr"), "C1[]", "C2[]"), 7, 32)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 187107, 187226);

                f_22020_187107_187225(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 185609, 187237);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 185609, 187237);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 185609, 187237);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Explicit_ReferenceArrayTypeToArrayTypeConversion_InvalidMismatchedSized()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 187249, 188877);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 187449, 187616);

                string
                source = @"
class C1
{
    static void M1()
    {
        C1[] c1arr = new C1[1];
        C1[][] /*<bind>*/c2arr = (C1[][])c1arr/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 187630, 188373);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: C1[][] c2arr) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'c2arr = (C1[][])c1arr')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '= (C1[][])c1arr')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: C1[][], IsInvalid) (Syntax: '(C1[][])c1arr')
        Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          ILocalReferenceOperation: c1arr (OperationKind.LocalReference, Type: C1[], IsInvalid) (Syntax: 'c1arr')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 188387, 188731);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22020_188606_188715(f_22020_188606_188695(f_22020_188606_188663(ErrorCode.ERR_NoExplicitConv, "(C1[][])c1arr"), "C1[]", "C1[][]"), 7, 34)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 188747, 188866);

                f_22020_188747_188865(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 187249, 188877);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 187249, 188877);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 187249, 188877);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Explicit_ReferenceSystemArrayToArrayTypeConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 188889, 190171);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 189068, 189249);

                string
                source = @"
using System;

class C1
{
    static void M1()
    {
        Array c1arr = new C1[1];
        C1[] /*<bind>*/c2arr = (C1[])c1arr/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 189263, 189958);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: C1[] c2arr) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'c2arr = (C1[])c1arr')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= (C1[])c1arr')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: C1[]) (Syntax: '(C1[])c1arr')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          ILocalReferenceOperation: c1arr (OperationKind.LocalReference, Type: System.Array) (Syntax: 'c1arr')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 189972, 190025);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 190041, 190160);

                f_22020_190041_190159(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 188889, 190171);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 188889, 190171);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 188889, 190171);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Explicit_ReferenceArrayToIListConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 190183, 191575);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 190352, 190578);

                string
                source = @"
using System;
using System.Collections.Generic;

class C1
{
    static void M1()
    {
        C1[] c1arr = new C1[1];
        IList<C1> /*<bind>*/c1list = (IList<C1>)c1arr/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 190592, 191362);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: System.Collections.Generic.IList<C1> c1list) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'c1list = (I ... t<C1>)c1arr')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= (IList<C1>)c1arr')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Collections.Generic.IList<C1>) (Syntax: '(IList<C1>)c1arr')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          ILocalReferenceOperation: c1arr (OperationKind.LocalReference, Type: C1[]) (Syntax: 'c1arr')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 191376, 191429);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 191445, 191564);

                f_22020_191445_191563(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 190183, 191575);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 190183, 191575);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 190183, 191575);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Explicit_ReferenceArrayToIListConversion_InvalidMismatchedDimensions()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 191587, 193425);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 191784, 192014);

                string
                source = @"
using System;
using System.Collections.Generic;

class C1
{
    static void M1()
    {
        C1[][] c1arr = new C1[1][];
        IList<C1> /*<bind>*/c1list = (IList<C1>)c1arr/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 192028, 192846);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: System.Collections.Generic.IList<C1> c1list) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'c1list = (I ... t<C1>)c1arr')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '= (IList<C1>)c1arr')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Collections.Generic.IList<C1>, IsInvalid) (Syntax: '(IList<C1>)c1arr')
        Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          ILocalReferenceOperation: c1arr (OperationKind.LocalReference, Type: C1[][], IsInvalid) (Syntax: 'c1arr')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 192860, 193279);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22020_193118_193263(f_22020_193118_193242(f_22020_193118_193178(ErrorCode.ERR_NoExplicitConv, "(IList<C1>)c1arr"), "C1[][]", "System.Collections.Generic.IList<C1>"), 10, 38)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 193295, 193414);

                f_22020_193295_193413(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 191587, 193425);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 191587, 193425);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 191587, 193425);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Explicit_ReferenceIListToArrayTypeConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 193437, 194788);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 193610, 193837);

                string
                source = @"
using System;
using System.Collections.Generic;

class C1
{
    static void M1()
    {
        IList<C1> c1List = new List<C1>();
        C1[] /*<bind>*/c1arr = (C1[])c1List/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 193851, 194575);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: C1[] c1arr) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'c1arr = (C1[])c1List')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= (C1[])c1List')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: C1[]) (Syntax: '(C1[])c1List')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          ILocalReferenceOperation: c1List (OperationKind.LocalReference, Type: System.Collections.Generic.IList<C1>) (Syntax: 'c1List')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 194589, 194642);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 194658, 194777);

                f_22020_194658_194776(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 193437, 194788);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 193437, 194788);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 193437, 194788);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Explicit_ReferenceIListToArrayTypeConversion_InvalidMismatchedDimensions()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 194800, 196597);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 195001, 195232);

                string
                source = @"
using System;
using System.Collections.Generic;

class C1
{
    static void M1()
    {
        IList<C1> c1List = new List<C1>();
        C1[][] /*<bind>*/c1arr = (C1[][])c1List/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 195246, 196026);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: C1[][] c1arr) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'c1arr = (C1[][])c1List')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '= (C1[][])c1List')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: C1[][], IsInvalid) (Syntax: '(C1[][])c1List')
        Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          ILocalReferenceOperation: c1List (OperationKind.LocalReference, Type: System.Collections.Generic.IList<C1>, IsInvalid) (Syntax: 'c1List')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 196040, 196451);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22020_196292_196435(f_22020_196292_196414(f_22020_196292_196350(ErrorCode.ERR_NoExplicitConv, "(C1[][])c1List"), "System.Collections.Generic.IList<C1>", "C1[][]"), 10, 34)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 196467, 196586);

                f_22020_196467_196585(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 194800, 196597);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 194800, 196597);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 194800, 196597);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Explicit_ReferenceDelegateToDelegateTypeConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 196609, 197895);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 196788, 196974);

                string
                source = @"
using System;

class C1
{
    static void M1()
    {
        Delegate d = (Action)(() => { });
        Action /*<bind>*/a = (Action)d/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 196988, 197682);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: System.Action a) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'a = (Action)d')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= (Action)d')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Action) (Syntax: '(Action)d')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          ILocalReferenceOperation: d (OperationKind.LocalReference, Type: System.Delegate) (Syntax: 'd')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 197696, 197749);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 197765, 197884);

                f_22020_197765_197883(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 196609, 197895);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 196609, 197895);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 196609, 197895);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Explicit_ReferenceContravarianceConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 197907, 199249);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 198078, 198344);

                string
                source = @"
interface I1<out T>
{
}

class C1<T> : I1<T>
{
    void M1()
    {
        C2<C3> c2 = new C2<C3>();
        I1<C4> /*<bind>*/c1 = (I1<C4>)c2/*</bind>*/;
    }
}

class C2<T> : C1<T>
{
}

class C3
{
}

class C4 : C3
{
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 198358, 199036);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: I1<C4> c1) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'c1 = (I1<C4>)c2')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= (I1<C4>)c2')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: I1<C4>) (Syntax: '(I1<C4>)c2')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          ILocalReferenceOperation: c2 (OperationKind.LocalReference, Type: C2<C3>) (Syntax: 'c2')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 199050, 199103);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 199119, 199238);

                f_22020_199119_199237(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 197907, 199249);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 197907, 199249);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 197907, 199249);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Explicit_UnboxingObjectToValueTypeConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 199261, 200479);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 199434, 199570);

                string
                source = @"
class C1
{
    void M1()
    {
        object o = 1;
        int /*<bind>*/i = (int)o/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 199584, 200266);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: System.Int32 i) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'i = (int)o')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= (int)o')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32) (Syntax: '(int)o')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          ILocalReferenceOperation: o (OperationKind.LocalReference, Type: System.Object) (Syntax: 'o')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 200280, 200333);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 200349, 200468);

                f_22020_200349_200467(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 199261, 200479);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 199261, 200479);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 199261, 200479);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Explicit_UnboxingDynamicToValueTypeConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 200491, 201705);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 200665, 200802);

                string
                source = @"
class C1
{
    void M1()
    {
        dynamic d = 1;
        int /*<bind>*/i = (int)d/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 200816, 201492);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: System.Int32 i) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'i = (int)d')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= (int)d')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32) (Syntax: '(int)d')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          ILocalReferenceOperation: d (OperationKind.LocalReference, Type: dynamic) (Syntax: 'd')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 201506, 201559);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 201575, 201694);

                f_22020_201575_201693(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 200491, 201705);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 200491, 201705);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 200491, 201705);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Explicit_UnboxingSystemValueTypeToValueTypeConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 201717, 202967);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 201899, 202055);

                string
                source = @"
using System;

class C1
{
    void M1()
    {
        ValueType v = 1;
        int /*<bind>*/i = (int)v/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 202069, 202754);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: System.Int32 i) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'i = (int)v')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= (int)v')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32) (Syntax: '(int)v')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          ILocalReferenceOperation: v (OperationKind.LocalReference, Type: System.ValueType) (Syntax: 'v')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 202768, 202821);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 202837, 202956);

                f_22020_202837_202955(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 201717, 202967);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 201717, 202967);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 201717, 202967);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Explicit_UnboxingSystemEnumToEnumConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 202979, 204222);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 203151, 203336);

                string
                source = @"
using System;

class C1
{
    void M1()
    {
        Enum e = E1.One;
        E1 /*<bind>*/e1 = (E1)e/*</bind>*/;
    }
}

enum E1
{
    One = 1
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 203350, 204009);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: E1 e1) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'e1 = (E1)e')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= (E1)e')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: E1) (Syntax: '(E1)e')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          ILocalReferenceOperation: e (OperationKind.LocalReference, Type: System.Enum) (Syntax: 'e')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 204023, 204076);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 204092, 204211);

                f_22020_204092_204210(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 202979, 204222);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 202979, 204222);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 202979, 204222);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Explicit_UnboxingReferenceToNullableTypeConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 204234, 205489);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 204413, 204598);

                string
                source = @"
using System;

class C1
{
    void M1()
    {
        Enum e = null;
        E1? /*<bind>*/e1 = (E1?)e/*</bind>*/;
    }
}

enum E1
{
    One = 1
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 204612, 205276);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: E1? e1) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'e1 = (E1?)e')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= (E1?)e')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: E1?) (Syntax: '(E1?)e')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          ILocalReferenceOperation: e (OperationKind.LocalReference, Type: System.Enum) (Syntax: 'e')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 205290, 205343);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 205359, 205478);

                f_22020_205359_205477(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 204234, 205489);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 204234, 205489);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 204234, 205489);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Explicit_UnboxingReferenceToNullableTypeConversion_InvalidNoConversionToNonNullableType()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 205501, 207520);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 205717, 205903);

                string
                source = @"
using System;

class C1
{
    void M1()
    {
        Enum e = null;
        int? /*<bind>*/e1 = (E1?)e/*</bind>*/;
    }
}

enum E1
{
    One = 1
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 205917, 206969);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: System.Int32? e1) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'e1 = (E1?)e')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '= (E1?)e')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32?, IsInvalid, IsImplicit) (Syntax: '(E1?)e')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: E1?, IsInvalid) (Syntax: '(E1?)e')
            Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            Operand: 
              ILocalReferenceOperation: e (OperationKind.LocalReference, Type: System.Enum, IsInvalid) (Syntax: 'e')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 206983, 207374);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22020_207255_207358(f_22020_207255_207338(f_22020_207255_207309(ErrorCode.ERR_NoImplicitConvCast, "(E1?)e"), "E1?", "int?"), 9, 29)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 207390, 207509);

                f_22020_207390_207508(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 205501, 207520);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 205501, 207520);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 205501, 207520);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Explicit_UnboxingValueTypeFromInterfaceConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 207532, 208780);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 207710, 207903);

                string
                source = @"
using System;

class C1
{
    void M1()
    {
        I1 i = null;
        S1 /*<bind>*/s1 = (S1)i/*</bind>*/;
    }
}

interface I1 { }

struct S1 : I1 { }
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 207917, 208567);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: S1 s1) (OperationKind.VariableDeclarator, Type: null) (Syntax: 's1 = (S1)i')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= (S1)i')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: S1) (Syntax: '(S1)i')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          ILocalReferenceOperation: i (OperationKind.LocalReference, Type: I1) (Syntax: 'i')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 208581, 208634);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 208650, 208769);

                f_22020_208650_208768(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 207532, 208780);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 207532, 208780);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 207532, 208780);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Explicit_UnboxingValueTypeFromInterfaceConversion_InvalidNoConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 208792, 210356);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 208990, 209178);

                string
                source = @"
using System;

class C1
{
    void M1()
    {
        I1 i = null;
        S1 /*<bind>*/s1 = (S1)i/*</bind>*/;
    }
}

interface I1 { }

struct S1 { }
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 209192, 209887);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: S1 s1) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 's1 = (S1)i')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '= (S1)i')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: S1, IsInvalid) (Syntax: '(S1)i')
        Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          ILocalReferenceOperation: i (OperationKind.LocalReference, Type: I1, IsInvalid) (Syntax: 'i')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 209901, 210210);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22020_210099_210194(f_22020_210099_210174(f_22020_210099_210148(ErrorCode.ERR_NoExplicitConv, "(S1)i"), "I1", "S1"), 9, 27)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 210226, 210345);

                f_22020_210226_210344(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 208792, 210356);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 208792, 210356);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 208792, 210356);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Explicit_UnboxingVarianceConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 210368, 211838);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 210532, 210805);

                string
                source = @"
using System;
using System.Collections.Generic;

class C1
{
    void M1()
    {
        IList<I1> i1List = new List<I1>();
        IList<S1> /*<bind>*/s1List = (IList<S1>)i1List/*</bind>*/;
    }
}

interface I1 { }

struct S1 : I1 { }
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 210819, 211625);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: System.Collections.Generic.IList<S1> s1List) (OperationKind.VariableDeclarator, Type: null) (Syntax: 's1List = (I ... <S1>)i1List')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= (IList<S1>)i1List')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Collections.Generic.IList<S1>) (Syntax: '(IList<S1>)i1List')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          ILocalReferenceOperation: i1List (OperationKind.LocalReference, Type: System.Collections.Generic.IList<I1>) (Syntax: 'i1List')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 211639, 211692);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 211708, 211827);

                f_22020_211708_211826(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 210368, 211838);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 210368, 211838);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 210368, 211838);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Explicit_TypeParameterConstraintConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 211850, 213045);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 212021, 212168);

                string
                source = @"
using System;

class C1
{
    void M1<T, U>(U u) where T : U
    {
        T /*<bind>*/t = (T)u/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 212182, 212832);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: T t) (OperationKind.VariableDeclarator, Type: null) (Syntax: 't = (T)u')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= (T)u')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: T) (Syntax: '(T)u')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          IParameterReferenceOperation: u (OperationKind.ParameterReference, Type: U) (Syntax: 'u')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 212846, 212899);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 212915, 213034);

                f_22020_212915_213033(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 211850, 213045);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 211850, 213045);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 211850, 213045);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Explicit_TypeParameterConversion_InvalidNoConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 213057, 214543);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 213238, 213373);

                string
                source = @"
using System;

class C1
{
    void M1<T, U>(U u)
    {
        T /*<bind>*/t = (T)u/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 213387, 214082);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: T t) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 't = (T)u')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '= (T)u')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: T, IsInvalid) (Syntax: '(T)u')
        Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          IParameterReferenceOperation: u (OperationKind.ParameterReference, Type: U, IsInvalid) (Syntax: 'u')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 214096, 214397);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22020_214289_214381(f_22020_214289_214361(f_22020_214289_214337(ErrorCode.ERR_NoExplicitConv, "(T)u"), "U", "T"), 8, 25)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 214413, 214532);

                f_22020_214413_214531(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 213057, 214543);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 213057, 214543);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 213057, 214543);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Explicit_TypeParameterToInterfaceConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 214555, 215741);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 214727, 214863);

                string
                source = @"
interface I1 { }

class C1
{
    void M1<T>(I1 i)
    {
        T /*<bind>*/t = (T)i/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 214877, 215528);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: T t) (OperationKind.VariableDeclarator, Type: null) (Syntax: 't = (T)i')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= (T)i')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: T) (Syntax: '(T)i')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          IParameterReferenceOperation: i (OperationKind.ParameterReference, Type: I1) (Syntax: 'i')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 215542, 215595);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 215611, 215730);

                f_22020_215611_215729(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 214555, 215741);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 214555, 215741);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 214555, 215741);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Explicit_TypeParameterFromInterfaceConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 215753, 216946);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 215927, 216064);

                string
                source = @"
interface I1 { }

class C1
{
    void M1<T>(T t)
    {
        I1 /*<bind>*/i = (I1)t/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 216078, 216733);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: I1 i) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'i = (I1)t')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= (I1)t')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: I1) (Syntax: '(I1)t')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          IParameterReferenceOperation: t (OperationKind.ParameterReference, Type: T) (Syntax: 't')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 216747, 216800);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 216816, 216935);

                f_22020_216816_216934(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 215753, 216946);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 215753, 216946);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 215753, 216946);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Explicit_ImplicitUserDefinedConversionAsExplicitConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 216958, 218307);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 217145, 217363);

                string
                source = @"
class C1
{
    void M1()
    {
        C1 c1 = new C1();
        C2 /*<bind>*/c2 = (C2)c1/*</bind>*/;
    }

    public static implicit operator C2(C1 c1) => new C2();
}

class C2 { }
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 217377, 218094);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: C2 c2) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'c2 = (C2)c1')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= (C2)c1')
      IConversionOperation (TryCast: False, Unchecked) (OperatorMethod: C2 C1.op_Implicit(C1 c1)) (OperationKind.Conversion, Type: C2) (Syntax: '(C2)c1')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: True) (MethodSymbol: C2 C1.op_Implicit(C1 c1))
        Operand: 
          ILocalReferenceOperation: c1 (OperationKind.LocalReference, Type: C1) (Syntax: 'c1')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 218108, 218161);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 218177, 218296);

                f_22020_218177_218295(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 216958, 218307);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 216958, 218307);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 216958, 218307);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Explicit_ExplicitUserDefinedConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 218319, 219648);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 218486, 218704);

                string
                source = @"
class C1
{
    void M1()
    {
        C1 c1 = new C1();
        C2 /*<bind>*/c2 = (C2)c1/*</bind>*/;
    }

    public static explicit operator C2(C1 c1) => new C2();
}

class C2 { }
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 218718, 219435);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: C2 c2) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'c2 = (C2)c1')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= (C2)c1')
      IConversionOperation (TryCast: False, Unchecked) (OperatorMethod: C2 C1.op_Explicit(C1 c1)) (OperationKind.Conversion, Type: C2) (Syntax: '(C2)c1')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: True) (MethodSymbol: C2 C1.op_Explicit(C1 c1))
        Operand: 
          ILocalReferenceOperation: c1 (OperationKind.LocalReference, Type: C1) (Syntax: 'c1')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 219449, 219502);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 219518, 219637);

                f_22020_219518_219636(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 218319, 219648);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 218319, 219648);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 218319, 219648);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Explicit_ExplicitUserDefinedConversion_WithImplicitConversionAfter()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 219660, 221353);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 219855, 220098);

                string
                source = @"
interface I1 { }

class C1
{
    void M1()
    {
        C1 c1 = new C1();
        I1 /*<bind>*/i1 = (C2)c1/*</bind>*/;
    }

    public static explicit operator C2(C1 c1) => new C2();
}

class C2 : I1 { }
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 220112, 221140);

                string
                expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: I1 i1) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'i1 = (C2)c1')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= (C2)c1')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: I1, IsImplicit) (Syntax: '(C2)c1')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          IConversionOperation (TryCast: False, Unchecked) (OperatorMethod: C2 C1.op_Explicit(C1 c1)) (OperationKind.Conversion, Type: C2) (Syntax: '(C2)c1')
            Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: True) (MethodSymbol: C2 C1.op_Explicit(C1 c1))
            Operand: 
              ILocalReferenceOperation: c1 (OperationKind.LocalReference, Type: C1) (Syntax: 'c1')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 221154, 221207);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 221223, 221342);

                f_22020_221223_221341(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 219660, 221353);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 219660, 221353);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 219660, 221353);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Explicit_ReturnConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 221365, 222414);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 221519, 221649);

                string
                source = @"
using System;

class C1
{
    int M1()
    {
        /*<bind>*/return (int)1.0;/*</bind>*/
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 221663, 222204);

                string
                expectedOperationTree = @"
IReturnOperation (OperationKind.Return, Type: null) (Syntax: 'return (int)1.0;')
  ReturnedValue: 
    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32, Constant: 1) (Syntax: '(int)1.0')
      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      Operand: 
        ILiteralOperation (OperationKind.Literal, Type: System.Double, Constant: 1) (Syntax: '1.0')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 222218, 222271);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 222287, 222403);

                f_22020_222287_222402(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 221365, 222414);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 221365, 222414);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 221365, 222414);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Explicit_ReturnConversion_InvalidConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 222426, 223794);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 222598, 222729);

                string
                source = @"
using System;

class C1
{
    int M1()
    {
        /*<bind>*/return (int)"""";/*</bind>*/
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 222743, 223312);

                string
                expectedOperationTree = @"
IReturnOperation (OperationKind.Return, Type: null, IsInvalid) (Syntax: 'return (int)"""";')
  ReturnedValue: 
    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32, IsInvalid) (Syntax: '(int)""""')
      Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      Operand: 
        ILiteralOperation (OperationKind.Literal, Type: System.String, Constant: """", IsInvalid) (Syntax: '""""')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 223326, 223651);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22020_223530_223635(f_22020_223530_223615(f_22020_223530_223584(ErrorCode.ERR_NoExplicitConv, @"(int)"""""), "string", "int"), 8, 26)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 223667, 223783);

                f_22020_223667_223782(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 222426, 223794);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 222426, 223794);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 222426, 223794);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Explicit_ReturnConversion_InvalidSyntax()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 223806, 225120);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 223974, 224101);

                string
                source = @"
using System;

class C1
{
    int M1()
    {
        /*<bind>*/return (int);/*</bind>*/
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 224115, 224670);

                string
                expectedOperationTree = @"
IReturnOperation (OperationKind.Return, Type: null, IsInvalid) (Syntax: 'return (int);')
  ReturnedValue: 
    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32, IsInvalid) (Syntax: '(int)')
      Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      Operand: 
        IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid) (Syntax: '')
          Children(0)
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 224684, 224977);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22020_224876_224961(f_22020_224876_224941(f_22020_224876_224922(ErrorCode.ERR_InvalidExprTerm, ";"), ";"), 8, 31)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 224993, 225109);

                f_22020_224993_225108(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 223806, 225120);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 223806, 225120);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 223806, 225120);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Explicit_CheckedOnlyAppliesToNumeric()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 225132, 227156);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 225297, 225538);

                string
                source = @"
namespace ConsoleApp1
{
    class C1
    {
        static void M1()
        {
            checked
            {
                /*<bind>*/object o = (object)null;/*</bind>*/
            }
        }
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 225552, 226643);

                string
                expectedOperationTree = @"
IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null) (Syntax: 'object o = (object)null;')
  IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'object o = (object)null')
    Declarators:
        IVariableDeclaratorOperation (Symbol: System.Object o) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'o = (object)null')
          Initializer: 
            IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= (object)null')
              IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, Constant: null) (Syntax: '(object)null')
                Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                Operand: 
                  ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')
    Initializer: 
      null
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 226657, 227003);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22020_226897_226987(f_22020_226897_226966(f_22020_226897_226947(ErrorCode.WRN_UnreferencedVarAssg, "o"), "o"), 10, 34)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 227019, 227145);

                f_22020_227019_227144(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 225132, 227156);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 225132, 227156);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 225132, 227156);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Explicit_DelegateTypeConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 227168, 228266);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 227328, 227558);

                string
                source = @"
using System;
class Program
{
    void Main()
    {
        Action<object> objectAction = str => { };
        Action<string> stringAction = /*<bind>*/(Action<string>)objectAction/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 227572, 228057);

                string
                expectedOperationTree = @"
IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Action<System.String>) (Syntax: '(Action<str ... bjectAction')
  Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
  Operand: 
    ILocalReferenceOperation: objectAction (OperationKind.LocalReference, Type: System.Action<System.Object>) (Syntax: 'objectAction')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 228071, 228124);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 228140, 228255);

                f_22020_228140_228254(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 227168, 228266);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 227168, 228266);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 227168, 228266);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Explicit_DelegateTypeConversion_InvalidConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 228278, 229790);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 228456, 228677);

                string
                source = @"
using System;
class Program
{
    void Main()
    {
        Action<object> objectAction = str => { };
        Action<int> intAction = /*<bind>*/(Action<int>)objectAction/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 228691, 229199);

                string
                expectedOperationTree = @"
IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Action<System.Int32>, IsInvalid) (Syntax: '(Action<int ... bjectAction')
  Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
  Operand: 
    ILocalReferenceOperation: objectAction (OperationKind.LocalReference, Type: System.Action<System.Object>, IsInvalid) (Syntax: 'objectAction')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 229213, 229648);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22020_229482_229632(f_22020_229482_229612(f_22020_229482_229551(ErrorCode.ERR_NoExplicitConv, "(Action<int>)objectAction"), "System.Action<object>", "System.Action<int>"), 8, 43)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 229664, 229779);

                f_22020_229664_229778(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 228278, 229790);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 228278, 229790);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 228278, 229790);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ConversionFlow_02()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 229802, 232933);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 229953, 230100);

                string
                source = @"
class C
{
    void M(int i, bool b, long l, long m)
    /*<bind>*/{
        i = (int) (b ? l : m);
    }/*</bind>*/
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 230114, 230167);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 230183, 232810);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i')
              Value: 
                IParameterReferenceOperation: i (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i')

        Jump if False (Regular) to Block[B3]
            IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'l')
              Value: 
                IParameterReferenceOperation: l (OperationKind.ParameterReference, Type: System.Int64) (Syntax: 'l')

        Next (Regular) Block[B4]
    Block[B3] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'm')
              Value: 
                IParameterReferenceOperation: m (OperationKind.ParameterReference, Type: System.Int64) (Syntax: 'm')

        Next (Regular) Block[B4]
    Block[B4] - Block
        Predecessors: [B2] [B3]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'i = (int) (b ? l : m);')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'i = (int) (b ? l : m)')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'i')
                  Right: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32) (Syntax: '(int) (b ? l : m)')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (ExplicitNumeric)
                      Operand: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int64, IsImplicit) (Syntax: 'b ? l : m')

        Next (Regular) Block[B5]
            Leaving: {R1}
}

Block[B5] - Exit
    Predecessors: [B4]
    Statements (0)
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 232824, 232922);

                f_22020_232824_232921(source, expectedFlowGraph, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 229802, 232933);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 229802, 232933);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 229802, 232933);
            }
        }

        [Fact]
        public void TestNullableConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 232945, 233993);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 233022, 233508);

                var
                source = @"
#nullable enable

using System;

class Class
{
    private static T? GetValueOrDefault<T>() where T : unmanaged
    {
        return null;
    }

    public static void Method()
    {
        IConvertible? nullableInterface;

        if (Environment.Is64BitProcess)
        {
            nullableInterface = GetValueOrDefault<long>();
        }
        else
        {
            nullableInterface = GetValueOrDefault<int>();
        }
    }
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 233524, 233568);

                var
                compilation = f_22020_233542_233567(source)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 233582, 233620);

                var
                tree = f_22020_233593_233616(compilation)[0]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 233634, 233681);

                var
                model = f_22020_233646_233680(compilation, tree)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 233697, 233792);

                var
                assignment = f_22020_233714_233791(f_22020_233714_233783(f_22020_233714_233746(f_22020_233714_233728(tree))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 233806, 233873);

                var
                iopTree = (IAssignmentOperation)f_22020_233842_233872(model, assignment)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 233887, 233982);

                f_22020_233887_233981(CodeAnalysis.NullableAnnotation.Annotated, f_22020_233943_233980(f_22020_233943_233961(f_22020_233943_233956(iopTree))));
                DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 232945, 233993);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 232945, 233993);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 232945, 233993);
            }
        }
        private class ExpectedSymbolVerifier
        {
            public static SyntaxNode VariableDeclaratorSelector(SyntaxNode syntaxNode)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 234161, 234237);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 234181, 234237);
                    return f_22020_234181_234237(f_22020_234181_234231(((VariableDeclaratorSyntax)syntaxNode))); DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 234161, 234237);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 234161, 234237);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 234161, 234237);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public static SyntaxNode IdentitySelector(SyntaxNode syntaxNode)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 234319, 234332);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 234322, 234332);
                    return syntaxNode; DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 234319, 234332);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 234319, 234332);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 234319, 234332);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public static SyntaxNode ReturnStatementSelector(SyntaxNode syntaxNode)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 234421, 234470);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 234424, 234470);
                    return f_22020_234424_234470(((ReturnStatementSyntax)syntaxNode)); DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 234421, 234470);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 234421, 234470);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 234421, 234470);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public static IOperation IVariableDeclarationStatementSelector(IOperation operation)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 234572, 234673);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 234592, 234673);
                    return f_22020_234592_234673(((IVariableDeclarationGroupOperation)operation).Declarations.Single()); DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 234572, 234673);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 234572, 234673);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 234572, 234673);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public static IOperation IVariableDeclarationSelector(IOperation operation)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 234766, 234846);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 234786, 234846);
                    return f_22020_234786_234846(f_22020_234786_234840(((IVariableDeclarationOperation)operation))); DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 234766, 234846);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 234766, 234846);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 234766, 234846);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public static IOperation IVariableDeclaratorSelector(IOperation operation)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 234938, 235017);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 234958, 235017);
                    return f_22020_234958_235017(f_22020_234958_235011(((IVariableDeclaratorOperation)operation))); DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 234938, 235017);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 234938, 235017);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 234938, 235017);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public static IOperation IReturnDeclarationStatementSelector(IOperation operation)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 235117, 235180);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 235137, 235180);
                    return f_22020_235137_235180(((IReturnOperation)operation)); DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 235117, 235180);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 235117, 235180);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 235117, 235180);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public static IOperation NestedConversionChildSelector(IOperation operation)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 235274, 235373);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 235294, 235373);
                    return f_22020_235294_235373(f_22020_235328_235372(operation)); DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 235274, 235373);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 235274, 235373);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 235274, 235373);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private static IOperation ConversionOrDelegateChildSelector(IOperation operation)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(22020, 235390, 235811);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 235504, 235796) || true) && (f_22020_235508_235522(operation) == OperationKind.Conversion)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(22020, 235504, 235796);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 235592, 235641);

                        return f_22020_235599_235640(((IConversionOperation)operation));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(22020, 235504, 235796);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(22020, 235504, 235796);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 235723, 235777);

                        return f_22020_235730_235776(((IDelegateCreationOperation)operation));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(22020, 235504, 235796);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(22020, 235390, 235811);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 235390, 235811);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 235390, 235811);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public Func<IOperation, IConversionOperation> OperationSelector { get; set; }

            public Func<IOperation, IOperation> ConversionChildSelector { get; set; }

            public Func<SyntaxNode, SyntaxNode> SyntaxSelector { get; set; }

            public void Verify(IOperation variableDeclaration, Compilation compilation, SyntaxNode syntaxNode)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 236922, 237586);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 237053, 237110);

                    var
                    finalSyntax = f_22020_237071_237109(this, syntaxNode)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 237128, 237201);

                    var
                    semanticModel = f_22020_237148_237200(compilation, f_22020_237177_237199(finalSyntax))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 237219, 237273);

                    var
                    typeInfo = f_22020_237234_237272(semanticModel, finalSyntax)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 237293, 237362);

                    var
                    initializer = f_22020_237311_237361(this, variableDeclaration)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 237382, 237411);

                    var
                    conversion = initializer
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 237429, 237483);

                    f_22020_237429_237482(f_22020_237442_237457(conversion), typeInfo.ConvertedType);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 237501, 237571);

                    // LAFHIS
                    f_22020_237501_237570(f_22020_237514_237554(f_22020_237514_237549(this, conversion)), typeInfo.Type);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 236922, 237586);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 236922, 237586);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 236922, 237586);
                }
            }

            private SyntaxNode GetAndInvokeSyntaxSelector(SyntaxNode syntax)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 237602, 238482);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 237699, 238467) || true) && (f_22020_237703_237717() != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(22020, 237699, 238467);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 237767, 237797);

                        // LAFHIS
                        return f_22020_237774_237796(this, syntax);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(22020, 237699, 238467);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(22020, 237699, 238467);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 237879, 238448);

                        switch (syntax)
                        {

                            case VariableDeclaratorSyntax _:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(22020, 237879, 238448);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 238005, 238047);

                                return f_22020_238012_238046(syntax);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(22020, 237879, 238448);

                            case ReturnStatementSyntax _:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(22020, 237879, 238448);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 238132, 238171);

                                return f_22020_238139_238170(syntax);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(22020, 237879, 238448);

                            case CastExpressionSyntax cast:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(22020, 237879, 238448);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 238258, 238281);

                                return f_22020_238265_238280(cast);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(22020, 237879, 238448);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(22020, 237879, 238448);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 238345, 238425);

                                throw f_22020_238351_238424($"Cannot handle syntax of type {f_22020_238405_238421(syntax)}");
                                DynAbs.Tracing.TraceSender.TraceExitCondition(22020, 237879, 238448);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(22020, 237699, 238467);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 237602, 238482);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 237602, 238482);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 237602, 238482);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private IOperation GetAndInvokeOperationSelector(IOperation operation)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(22020, 238498, 239585);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 238601, 238727) || true) && (f_22020_238605_238622() != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(22020, 238601, 238727);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 238672, 238708);

                        // LAFHIS
                        return f_22020_238679_238707(this, operation);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(22020, 238601, 238727);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 238747, 239570);

                    switch (operation)
                    {

                        case IVariableDeclarationGroupOperation _:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(22020, 238747, 239570);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 238874, 238930);

                            return f_22020_238881_238929(operation);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(22020, 238747, 239570);

                        case IVariableDeclarationOperation _:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(22020, 238747, 239570);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 239015, 239062);

                            return f_22020_239022_239061(operation);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(22020, 238747, 239570);

                        case IVariableDeclaratorOperation _:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(22020, 238747, 239570);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 239146, 239192);

                            return f_22020_239153_239191(operation);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(22020, 238747, 239570);

                        case IReturnOperation _:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(22020, 238747, 239570);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 239264, 239318);

                            return f_22020_239271_239317(operation);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(22020, 238747, 239570);

                        case IConversionOperation conv:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(22020, 238747, 239570);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 239397, 239409);

                            return conv;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(22020, 238747, 239570);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(22020, 238747, 239570);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 239465, 239551);

                            throw f_22020_239471_239550($"Cannot handle arguments of type {f_22020_239528_239547(operation)}");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(22020, 238747, 239570);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(22020, 238498, 239585);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22020, 238498, 239585);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 238498, 239585);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public ExpectedSymbolVerifier()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(22020, 234025, 239596);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 235827, 235904);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 235920, 236030);
                this.ConversionChildSelector = ConversionOrDelegateChildSelector; DynAbs.Tracing.TraceSender.TraceSimpleStatement(22020, 236046, 236110);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(22020, 234025, 239596);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 234025, 239596);
            }


            static ExpectedSymbolVerifier()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(22020, 234025, 239596);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(22020, 234025, 239596);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22020, 234025, 239596);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(22020, 234025, 239596);

            static Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax?
            f_22020_234181_234231(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax
            this_param)
            {
                var return_v = this_param.Initializer;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22020, 234181, 234231);
                return return_v;
            }


            static Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
            f_22020_234181_234237(Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax?
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22020, 234181, 234237);
                return return_v;
            }


            static Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax?
            f_22020_234424_234470(Microsoft.CodeAnalysis.CSharp.Syntax.ReturnStatementSyntax
            this_param)
            {
                var return_v = this_param.Expression;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22020, 234424, 234470);
                return return_v;
            }


            static Microsoft.CodeAnalysis.Operations.IVariableInitializerOperation?
            f_22020_234592_234673(Microsoft.CodeAnalysis.Operations.IVariableDeclarationOperation
            this_param)
            {
                var return_v = this_param.Initializer;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22020, 234592, 234673);
                return return_v;
            }


            static Microsoft.CodeAnalysis.Operations.IVariableInitializerOperation?
            f_22020_234786_234840(Microsoft.CodeAnalysis.Operations.IVariableDeclarationOperation
            this_param)
            {
                var return_v = this_param.Initializer;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22020, 234786, 234840);
                return return_v;
            }


            static Microsoft.CodeAnalysis.IOperation
            f_22020_234786_234846(Microsoft.CodeAnalysis.Operations.IVariableInitializerOperation?
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22020, 234786, 234846);
                return return_v;
            }


            static Microsoft.CodeAnalysis.Operations.IVariableInitializerOperation?
            f_22020_234958_235011(Microsoft.CodeAnalysis.Operations.IVariableDeclaratorOperation
            this_param)
            {
                var return_v = this_param.Initializer;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22020, 234958, 235011);
                return return_v;
            }


            static Microsoft.CodeAnalysis.IOperation
            f_22020_234958_235017(Microsoft.CodeAnalysis.Operations.IVariableInitializerOperation?
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22020, 234958, 235017);
                return return_v;
            }


            static Microsoft.CodeAnalysis.IOperation?
            f_22020_235137_235180(Microsoft.CodeAnalysis.Operations.IReturnOperation
            this_param)
            {
                var return_v = this_param.ReturnedValue;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22020, 235137, 235180);
                return return_v;
            }


            static Microsoft.CodeAnalysis.IOperation
            f_22020_235328_235372(Microsoft.CodeAnalysis.IOperation
            operation)
            {
                var return_v = ConversionOrDelegateChildSelector(operation);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 235328, 235372);
                return return_v;
            }


            static Microsoft.CodeAnalysis.IOperation
            f_22020_235294_235373(Microsoft.CodeAnalysis.IOperation
            operation)
            {
                var return_v = ConversionOrDelegateChildSelector(operation);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 235294, 235373);
                return return_v;
            }


            static Microsoft.CodeAnalysis.OperationKind
            f_22020_235508_235522(Microsoft.CodeAnalysis.IOperation
            this_param)
            {
                var return_v = this_param.Kind;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22020, 235508, 235522);
                return return_v;
            }


            static Microsoft.CodeAnalysis.IOperation
            f_22020_235599_235640(Microsoft.CodeAnalysis.Operations.IConversionOperation
            this_param)
            {
                var return_v = this_param.Operand;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22020, 235599, 235640);
                return return_v;
            }


            static Microsoft.CodeAnalysis.IOperation
            f_22020_235730_235776(Microsoft.CodeAnalysis.Operations.IDelegateCreationOperation
            this_param)
            {
                var return_v = this_param.Target;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22020, 235730, 235776);
                return return_v;
            }


            Microsoft.CodeAnalysis.SyntaxNode
            f_22020_237071_237109(Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier
            this_param, Microsoft.CodeAnalysis.SyntaxNode
            syntax)
            {
                var return_v = this_param.GetAndInvokeSyntaxSelector(syntax);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 237071, 237109);
                return return_v;
            }


            Microsoft.CodeAnalysis.SyntaxTree
            f_22020_237177_237199(Microsoft.CodeAnalysis.SyntaxNode
            this_param)
            {
                var return_v = this_param.SyntaxTree;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22020, 237177, 237199);
                return return_v;
            }


            Microsoft.CodeAnalysis.SemanticModel
            f_22020_237148_237200(Microsoft.CodeAnalysis.Compilation
            this_param, Microsoft.CodeAnalysis.SyntaxTree
            syntaxTree)
            {
                var return_v = this_param.GetSemanticModel(syntaxTree);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 237148, 237200);
                return return_v;
            }


            Microsoft.CodeAnalysis.TypeInfo
            f_22020_237234_237272(Microsoft.CodeAnalysis.SemanticModel
            this_param, Microsoft.CodeAnalysis.SyntaxNode
            node)
            {
                var return_v = this_param.GetTypeInfo(node);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 237234, 237272);
                return return_v;
            }


            Microsoft.CodeAnalysis.IOperation
            f_22020_237311_237361(Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier
            this_param, Microsoft.CodeAnalysis.IOperation
            operation)
            {
                var return_v = this_param.GetAndInvokeOperationSelector(operation);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 237311, 237361);
                return return_v;
            }


            Microsoft.CodeAnalysis.ITypeSymbol?
            f_22020_237442_237457(Microsoft.CodeAnalysis.IOperation
            this_param)
            {
                var return_v = this_param.Type;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22020, 237442, 237457);
                return return_v;
            }


            int
            f_22020_237429_237482(Microsoft.CodeAnalysis.ITypeSymbol?
            expected, Microsoft.CodeAnalysis.ITypeSymbol?
            actual)
            {
                Assert.Equal(expected, actual);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 237429, 237482);
                return 0;
            }


            Microsoft.CodeAnalysis.IOperation
            f_22020_237514_237549(Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier
            this_param, Microsoft.CodeAnalysis.IOperation
            arg)
            {
                var return_v = this_param.ConversionChildSelector(arg);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 237514, 237549);
                return return_v;
            }


            Microsoft.CodeAnalysis.ITypeSymbol?
            f_22020_237514_237554(Microsoft.CodeAnalysis.IOperation
            this_param)
            {
                var return_v = this_param.Type;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22020, 237514, 237554);
                return return_v;
            }


            int
            f_22020_237501_237570(Microsoft.CodeAnalysis.ITypeSymbol?
            expected, Microsoft.CodeAnalysis.ITypeSymbol?
            actual)
            {
                Assert.Equal(expected, actual);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 237501, 237570);
                return 0;
            }


            System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
            f_22020_237703_237717()
            {
                var return_v = SyntaxSelector;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22020, 237703, 237717);
                return return_v;
            }


            Microsoft.CodeAnalysis.SyntaxNode
            f_22020_237774_237796(Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier
            this_param, Microsoft.CodeAnalysis.SyntaxNode
            arg)
            {
                var return_v = this_param.SyntaxSelector(arg);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 237774, 237796);
                return return_v;
            }


            Microsoft.CodeAnalysis.SyntaxNode
            f_22020_238012_238046(Microsoft.CodeAnalysis.SyntaxNode
            syntaxNode)
            {
                var return_v = VariableDeclaratorSelector(syntaxNode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 238012, 238046);
                return return_v;
            }


            Microsoft.CodeAnalysis.SyntaxNode
            f_22020_238139_238170(Microsoft.CodeAnalysis.SyntaxNode
            syntaxNode)
            {
                var return_v = ReturnStatementSelector(syntaxNode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 238139, 238170);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
            f_22020_238265_238280(Microsoft.CodeAnalysis.CSharp.Syntax.CastExpressionSyntax
            this_param)
            {
                var return_v = this_param.Expression;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22020, 238265, 238280);
                return return_v;
            }


            System.Type
            f_22020_238405_238421(Microsoft.CodeAnalysis.SyntaxNode
            this_param)
            {
                var return_v = this_param.GetType();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 238405, 238421);
                return return_v;
            }


            System.ArgumentException
            f_22020_238351_238424(string
            message)
            {
                var return_v = new System.ArgumentException(message);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 238351, 238424);
                return return_v;
            }


            System.Func<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Operations.IConversionOperation>
            f_22020_238605_238622()
            {
                var return_v = OperationSelector;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22020, 238605, 238622);
                return return_v;
            }


            Microsoft.CodeAnalysis.Operations.IConversionOperation
            f_22020_238679_238707(Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier
            this_param, Microsoft.CodeAnalysis.IOperation
            arg)
            {
                var return_v = this_param.OperationSelector(arg);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 238679, 238707);
                return return_v;
            }


            Microsoft.CodeAnalysis.IOperation
            f_22020_238881_238929(Microsoft.CodeAnalysis.IOperation
            operation)
            {
                var return_v = IVariableDeclarationStatementSelector(operation);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 238881, 238929);
                return return_v;
            }


            Microsoft.CodeAnalysis.IOperation
            f_22020_239022_239061(Microsoft.CodeAnalysis.IOperation
            operation)
            {
                var return_v = IVariableDeclarationSelector(operation);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 239022, 239061);
                return return_v;
            }


            Microsoft.CodeAnalysis.IOperation
            f_22020_239153_239191(Microsoft.CodeAnalysis.IOperation
            operation)
            {
                var return_v = IVariableDeclaratorSelector(operation);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 239153, 239191);
                return return_v;
            }


            Microsoft.CodeAnalysis.IOperation
            f_22020_239271_239317(Microsoft.CodeAnalysis.IOperation
            operation)
            {
                var return_v = IReturnDeclarationStatementSelector(operation);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 239271, 239317);
                return return_v;
            }


            System.Type
            f_22020_239528_239547(Microsoft.CodeAnalysis.IOperation
            this_param)
            {
                var return_v = this_param.GetType();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 239528, 239547);
                return return_v;
            }


            System.ArgumentException
            f_22020_239471_239550(string
            message)
            {
                var return_v = new System.ArgumentException(message);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 239471, 239550);
                return return_v;
            }

        }

        Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier
        f_22020_1995_2023()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 1995, 2023);
            return return_v;
        }


        int
        f_22020_1826_2031(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics, System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
        additionalOperationTreeVerifier)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: additionalOperationTreeVerifier);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 1826, 2031);
            return 0;
        }


        int
        f_22020_3030_3148(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 3030, 3148);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier
        f_22020_4452_4480()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 4452, 4480);
            return return_v;
        }


        int
        f_22020_4283_4488(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics, System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
        additionalOperationTreeVerifier)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: additionalOperationTreeVerifier);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 4283, 4488);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_5875_5925(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 5875, 5925);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_5875_5955(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 5875, 5955);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_5875_5975(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 5875, 5975);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier
        f_22020_6176_6204()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 6176, 6204);
            return return_v;
        }


        int
        f_22020_6007_6212(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics, System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
        additionalOperationTreeVerifier)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: additionalOperationTreeVerifier);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 6007, 6212);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_7147_7193(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 7147, 7193);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_7147_7212(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 7147, 7212);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_7147_7232(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 7147, 7232);
            return return_v;
        }


        int
        f_22020_7264_8528(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics, System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
        additionalOperationTreeVerifier)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: additionalOperationTreeVerifier);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 7264, 8528);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_9816_9867(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 9816, 9867);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_9816_9887(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 9816, 9887);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_9816_9907(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 9816, 9907);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier
        f_22020_10108_10136()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 10108, 10136);
            return return_v;
        }


        int
        f_22020_9939_10144(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics, System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
        additionalOperationTreeVerifier)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: additionalOperationTreeVerifier);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 9939, 10144);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_11559_11609(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 11559, 11609);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_11559_11639(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 11559, 11639);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_11559_11659(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 11559, 11659);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier
        f_22020_11860_11888()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 11860, 11888);
            return return_v;
        }


        int
        f_22020_11691_11896(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics, System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
        additionalOperationTreeVerifier)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: additionalOperationTreeVerifier);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 11691, 11896);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_13296_13345(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 13296, 13345);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_13296_13375(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 13296, 13375);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_13296_13395(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 13296, 13395);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_13579_13630(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 13579, 13630);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_13579_13650(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 13579, 13650);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_13579_13670(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 13579, 13670);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier
        f_22020_13871_13899()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 13871, 13899);
            return return_v;
        }


        int
        f_22020_13702_13907(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics, System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
        additionalOperationTreeVerifier)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: additionalOperationTreeVerifier);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 13702, 13907);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_15085_15131(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 15085, 15131);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_15085_15150(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 15085, 15150);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_15085_15170(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 15085, 15170);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier
        f_22020_15371_15399()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 15371, 15399);
            return return_v;
        }


        int
        f_22020_15202_15407(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics, System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
        additionalOperationTreeVerifier)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: additionalOperationTreeVerifier);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 15202, 15407);
            return 0;
        }


        int
        f_22020_17447_18263(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics, System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
        additionalOperationTreeVerifier)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: additionalOperationTreeVerifier);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 17447, 18263);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_19835_19884(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 19835, 19884);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_19835_19904(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 19835, 19904);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier
        f_22020_20105_20133()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 20105, 20133);
            return return_v;
        }


        int
        f_22020_19936_20141(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics, System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
        additionalOperationTreeVerifier)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: additionalOperationTreeVerifier);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 19936, 20141);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_21420_21471(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 21420, 21471);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_21420_21491(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 21420, 21491);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_21420_21511(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 21420, 21511);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier
        f_22020_21712_21740()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 21712, 21740);
            return return_v;
        }


        int
        f_22020_21543_21748(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics, System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
        additionalOperationTreeVerifier)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: additionalOperationTreeVerifier);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 21543, 21748);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_23006_23057(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 23006, 23057);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_23006_23077(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 23006, 23077);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_23006_23098(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 23006, 23098);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier
        f_22020_23299_23327()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 23299, 23327);
            return return_v;
        }


        int
        f_22020_23130_23335(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics, System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
        additionalOperationTreeVerifier)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: additionalOperationTreeVerifier);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 23130, 23335);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_24661_24710(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 24661, 24710);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_24661_24731(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 24661, 24731);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_24661_24751(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 24661, 24751);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier
        f_22020_24952_24980()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 24952, 24980);
            return return_v;
        }


        int
        f_22020_24783_24988(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics, System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
        additionalOperationTreeVerifier)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: additionalOperationTreeVerifier);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 24783, 24988);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_26290_26341(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 26290, 26341);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_26290_26361(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 26290, 26361);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_26290_26381(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 26290, 26381);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier
        f_22020_26637_26665()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 26637, 26665);
            return return_v;
        }


        int
        f_22020_26413_26673(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
        parseOptions, System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
        additionalOperationTreeVerifier)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics, parseOptions: parseOptions, additionalOperationTreeVerifier: additionalOperationTreeVerifier);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 26413, 26673);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_28026_28077(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 28026, 28077);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_28026_28097(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 28026, 28097);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_28026_28117(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 28026, 28117);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier
        f_22020_28318_28346()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 28318, 28346);
            return return_v;
        }


        int
        f_22020_28149_28354(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics, System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
        additionalOperationTreeVerifier)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: additionalOperationTreeVerifier);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 28149, 28354);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_29540_29591(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 29540, 29591);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_29540_29611(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 29540, 29611);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_29540_29631(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 29540, 29631);
            return return_v;
        }


        int
        f_22020_29663_29781(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 29663, 29781);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_31037_31088(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 31037, 31088);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_31037_31108(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 31037, 31108);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_31037_31128(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 31037, 31128);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier
        f_22020_31329_31357()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 31329, 31357);
            return return_v;
        }


        int
        f_22020_31160_31365(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics, System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
        additionalOperationTreeVerifier)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: additionalOperationTreeVerifier);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 31160, 31365);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier
        f_22020_32670_32698()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 32670, 32698);
            return return_v;
        }


        int
        f_22020_32501_32706(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics, System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
        additionalOperationTreeVerifier)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: additionalOperationTreeVerifier);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 32501, 32706);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier
        f_22020_34013_34041()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 34013, 34041);
            return return_v;
        }


        int
        f_22020_33844_34049(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics, System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
        additionalOperationTreeVerifier)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: additionalOperationTreeVerifier);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 33844, 34049);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_35434_35484(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 35434, 35484);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_35434_35513(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 35434, 35513);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_35434_35533(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 35434, 35533);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier
        f_22020_35734_35762()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 35734, 35762);
            return return_v;
        }


        int
        f_22020_35565_35770(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics, System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
        additionalOperationTreeVerifier)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: additionalOperationTreeVerifier);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 35565, 35770);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier
        f_22020_37624_37652()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 37624, 37652);
            return return_v;
        }


        int
        f_22020_37455_37660(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics, System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
        additionalOperationTreeVerifier)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: additionalOperationTreeVerifier);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 37455, 37660);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier
        f_22020_39068_39096()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 39068, 39096);
            return return_v;
        }


        int
        f_22020_38899_39104(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics, System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
        additionalOperationTreeVerifier)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: additionalOperationTreeVerifier);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 38899, 39104);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier
        f_22020_40502_40530()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 40502, 40530);
            return return_v;
        }


        int
        f_22020_40333_40538(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics, System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
        additionalOperationTreeVerifier)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: additionalOperationTreeVerifier);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 40333, 40538);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier
        f_22020_41947_41975()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 41947, 41975);
            return return_v;
        }


        int
        f_22020_41778_41983(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics, System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
        additionalOperationTreeVerifier)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: additionalOperationTreeVerifier);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 41778, 41983);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_43415_43467(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 43415, 43467);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_43415_43493(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 43415, 43493);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_43415_43513(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 43415, 43513);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier
        f_22020_43714_43742()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 43714, 43742);
            return return_v;
        }


        int
        f_22020_43545_43750(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics, System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
        additionalOperationTreeVerifier)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: additionalOperationTreeVerifier);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 43545, 43750);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_45131_45172(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 45131, 45172);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_45131_45192(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 45131, 45192);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier
        f_22020_45393_45421()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 45393, 45421);
            return return_v;
        }


        int
        f_22020_45224_45429(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics, System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
        additionalOperationTreeVerifier)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: additionalOperationTreeVerifier);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 45224, 45429);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier
        f_22020_46846_46874()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 46846, 46874);
            return return_v;
        }


        int
        f_22020_46677_46882(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics, System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
        additionalOperationTreeVerifier)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: additionalOperationTreeVerifier);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 46677, 46882);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_48377_48433(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 48377, 48433);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_48377_48459(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 48377, 48459);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_48377_48480(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 48377, 48480);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier
        f_22020_48681_48709()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 48681, 48709);
            return return_v;
        }


        int
        f_22020_48512_48717(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics, System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
        additionalOperationTreeVerifier)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: additionalOperationTreeVerifier);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 48512, 48717);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_50088_50139(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 50088, 50139);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_50088_50159(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 50088, 50159);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_50088_50180(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 50088, 50180);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier
        f_22020_50381_50409()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 50381, 50409);
            return return_v;
        }


        int
        f_22020_50212_50417(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics, System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
        additionalOperationTreeVerifier)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: additionalOperationTreeVerifier);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 50212, 50417);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier
        f_22020_51767_51795()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 51767, 51795);
            return return_v;
        }


        int
        f_22020_51598_51803(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics, System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
        additionalOperationTreeVerifier)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: additionalOperationTreeVerifier);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 51598, 51803);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_53225_53275(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 53225, 53275);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_53225_53301(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 53225, 53301);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_53225_53322(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 53225, 53322);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier
        f_22020_53523_53551()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 53523, 53551);
            return return_v;
        }


        int
        f_22020_53354_53559(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics, System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
        additionalOperationTreeVerifier)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: additionalOperationTreeVerifier);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 53354, 53559);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier
        f_22020_54912_54940()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 54912, 54940);
            return return_v;
        }


        int
        f_22020_54743_54948(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics, System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
        additionalOperationTreeVerifier)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: additionalOperationTreeVerifier);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 54743, 54948);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_56362_56411(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 56362, 56411);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_56362_56443(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 56362, 56443);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_56362_56463(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 56362, 56463);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier
        f_22020_56664_56692()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 56664, 56692);
            return return_v;
        }


        int
        f_22020_56495_56700(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics, System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
        additionalOperationTreeVerifier)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: additionalOperationTreeVerifier);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 56495, 56700);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_58103_58152(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 58103, 58152);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_58103_58182(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 58103, 58182);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_58103_58202(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 58103, 58202);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier
        f_22020_58403_58431()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 58403, 58431);
            return return_v;
        }


        int
        f_22020_58234_58439(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics, System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
        additionalOperationTreeVerifier)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: additionalOperationTreeVerifier);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 58234, 58439);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_60059_60113(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 60059, 60113);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_60059_60143(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 60059, 60143);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_60059_60163(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 60059, 60163);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier
        f_22020_60364_60392()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 60364, 60392);
            return return_v;
        }


        int
        f_22020_60195_60400(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics, System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
        additionalOperationTreeVerifier)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: additionalOperationTreeVerifier);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 60195, 60400);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier
        f_22020_61945_61973()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 61945, 61973);
            return return_v;
        }


        int
        f_22020_61776_61981(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics, System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
        additionalOperationTreeVerifier)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: additionalOperationTreeVerifier);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 61776, 61981);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier
        f_22020_63544_63572()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 63544, 63572);
            return return_v;
        }


        int
        f_22020_63375_63580(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics, System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
        additionalOperationTreeVerifier)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: additionalOperationTreeVerifier);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 63375, 63580);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_65153_65213(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 65153, 65213);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_65153_65253(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 65153, 65253);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_65153_65273(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 65153, 65273);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier
        f_22020_65474_65502()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 65474, 65502);
            return return_v;
        }


        int
        f_22020_65305_65510(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics, System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
        additionalOperationTreeVerifier)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: additionalOperationTreeVerifier);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 65305, 65510);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier
        f_22020_67127_67155()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 67127, 67155);
            return return_v;
        }


        int
        f_22020_66958_67163(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics, System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
        additionalOperationTreeVerifier)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: additionalOperationTreeVerifier);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 66958, 67163);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_68854_68914(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 68854, 68914);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_68854_68979(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 68854, 68979);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_68854_68999(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 68854, 68999);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier
        f_22020_69200_69228()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 69200, 69228);
            return return_v;
        }


        int
        f_22020_69031_69236(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics, System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
        additionalOperationTreeVerifier)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: additionalOperationTreeVerifier);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 69031, 69236);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier
        f_22020_70612_70640()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 70612, 70640);
            return return_v;
        }


        int
        f_22020_70443_70648(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics, System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
        additionalOperationTreeVerifier)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: additionalOperationTreeVerifier);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 70443, 70648);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_72294_72342(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 72294, 72342);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_72294_72383(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 72294, 72383);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_72294_72404(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 72294, 72404);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier
        f_22020_72605_72633()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 72605, 72633);
            return return_v;
        }


        int
        f_22020_72436_72641(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics, System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
        additionalOperationTreeVerifier)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: additionalOperationTreeVerifier);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 72436, 72641);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_73879_73925(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 73879, 73925);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_73879_73944(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 73879, 73944);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_73879_73964(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 73879, 73964);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier
        f_22020_74165_74193()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 74165, 74193);
            return return_v;
        }


        int
        f_22020_73996_74201(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics, System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
        additionalOperationTreeVerifier)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: additionalOperationTreeVerifier);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 73996, 74201);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier
        f_22020_75592_75620()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 75592, 75620);
            return return_v;
        }


        int
        f_22020_75423_75628(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics, System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
        additionalOperationTreeVerifier)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: additionalOperationTreeVerifier);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 75423, 75628);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier
        f_22020_77018_77046()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 77018, 77046);
            return return_v;
        }


        int
        f_22020_76849_77054(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics, System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
        additionalOperationTreeVerifier)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: additionalOperationTreeVerifier);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 76849, 77054);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_78533_78583(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 78533, 78583);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_78533_78617(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 78533, 78617);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_78533_78638(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 78533, 78638);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier
        f_22020_78839_78867()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 78839, 78867);
            return return_v;
        }


        int
        f_22020_78670_78875(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics, System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
        additionalOperationTreeVerifier)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: additionalOperationTreeVerifier);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 78670, 78875);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier
        f_22020_80270_80298()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 80270, 80298);
            return return_v;
        }


        int
        f_22020_80101_80306(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics, System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
        additionalOperationTreeVerifier)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: additionalOperationTreeVerifier);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 80101, 80306);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_81790_81840(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 81790, 81840);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_81790_81874(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 81790, 81874);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_81790_81895(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 81790, 81895);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier
        f_22020_82096_82124()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 82096, 82124);
            return return_v;
        }


        int
        f_22020_81927_82132(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics, System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
        additionalOperationTreeVerifier)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: additionalOperationTreeVerifier);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 81927, 82132);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier
        f_22020_83777_83805()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 83777, 83805);
            return return_v;
        }


        int
        f_22020_83608_83813(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics, System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
        additionalOperationTreeVerifier)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: additionalOperationTreeVerifier);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 83608, 83813);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier
        f_22020_85198_85226()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 85198, 85226);
            return return_v;
        }


        int
        f_22020_85029_85234(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics, System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
        additionalOperationTreeVerifier)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: additionalOperationTreeVerifier);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 85029, 85234);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_86658_86709(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 86658, 86709);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_86658_86734(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 86658, 86734);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_86658_86754(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 86658, 86754);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier
        f_22020_86955_86983()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 86955, 86983);
            return return_v;
        }


        int
        f_22020_86786_86991(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics, System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
        additionalOperationTreeVerifier)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: additionalOperationTreeVerifier);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 86786, 86991);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier
        f_22020_88382_88410()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 88382, 88410);
            return return_v;
        }


        int
        f_22020_88213_88418(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics, System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
        additionalOperationTreeVerifier)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: additionalOperationTreeVerifier);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 88213, 88418);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_89897_89952(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 89897, 89952);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_89897_89977(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 89897, 89977);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_89897_89998(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 89897, 89998);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier
        f_22020_90199_90227()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 90199, 90227);
            return return_v;
        }


        int
        f_22020_90030_90235(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics, System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
        additionalOperationTreeVerifier)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: additionalOperationTreeVerifier);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 90030, 90235);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier
        f_22020_91655_91683()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 91655, 91683);
            return return_v;
        }


        int
        f_22020_91486_91691(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics, System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
        additionalOperationTreeVerifier)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: additionalOperationTreeVerifier);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 91486, 91691);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_93137_93188(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 93137, 93188);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_93137_93212(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 93137, 93212);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_93137_93233(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 93137, 93233);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier
        f_22020_93434_93462()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 93434, 93462);
            return return_v;
        }


        int
        f_22020_93265_93470(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics, System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
        additionalOperationTreeVerifier)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: additionalOperationTreeVerifier);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 93265, 93470);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_94759_94809(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 94759, 94809);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_94759_94828(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 94759, 94828);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_94759_94849(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 94759, 94849);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier
        f_22020_95050_95078()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 95050, 95078);
            return return_v;
        }


        int
        f_22020_94881_95086(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics, System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
        additionalOperationTreeVerifier)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: additionalOperationTreeVerifier);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 94881, 95086);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_96496_96547(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 96496, 96547);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_96496_96566(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 96496, 96566);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_96496_96587(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 96496, 96587);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier
        f_22020_96788_96816()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 96788, 96816);
            return return_v;
        }


        int
        f_22020_96619_96824(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics, System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
        additionalOperationTreeVerifier)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: additionalOperationTreeVerifier);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 96619, 96824);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier
        f_22020_98112_98140()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 98112, 98140);
            return return_v;
        }


        int
        f_22020_97943_98148(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics, System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
        additionalOperationTreeVerifier)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: additionalOperationTreeVerifier);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 97943, 98148);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier
        f_22020_99426_99454()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 99426, 99454);
            return return_v;
        }


        int
        f_22020_99257_99462(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics, System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
        additionalOperationTreeVerifier)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: additionalOperationTreeVerifier);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 99257, 99462);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier
        f_22020_100872_100900()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 100872, 100900);
            return return_v;
        }


        int
        f_22020_100703_100908(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics, System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
        additionalOperationTreeVerifier)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: additionalOperationTreeVerifier);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 100703, 100908);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_102388_102440(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 102388, 102440);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_102388_102480(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 102388, 102480);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_102388_102500(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 102388, 102500);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier
        f_22020_102701_102729()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 102701, 102729);
            return return_v;
        }


        int
        f_22020_102532_102737(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics, System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
        additionalOperationTreeVerifier)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: additionalOperationTreeVerifier);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 102532, 102737);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier
        f_22020_104137_104165()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 104137, 104165);
            return return_v;
        }


        int
        f_22020_103968_104173(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics, System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
        additionalOperationTreeVerifier)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: additionalOperationTreeVerifier);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 103968, 104173);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_105610_105662(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 105610, 105662);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_105610_105688(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 105610, 105688);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_105610_105709(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 105610, 105709);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier
        f_22020_105910_105938()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 105910, 105938);
            return return_v;
        }


        int
        f_22020_105741_105946(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics, System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
        additionalOperationTreeVerifier)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: additionalOperationTreeVerifier);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 105741, 105946);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier
        f_22020_107243_107271()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 107243, 107271);
            return return_v;
        }


        int
        f_22020_107074_107279(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics, System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
        additionalOperationTreeVerifier)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: additionalOperationTreeVerifier);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 107074, 107279);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_108608_108654(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 108608, 108654);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_108608_108681(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 108608, 108681);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_108608_108702(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 108608, 108702);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier
        f_22020_108903_108931()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 108903, 108931);
            return return_v;
        }


        int
        f_22020_108734_108939(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics, System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
        additionalOperationTreeVerifier)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: additionalOperationTreeVerifier);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 108734, 108939);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier
        f_22020_110311_110339()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 110311, 110339);
            return return_v;
        }


        int
        f_22020_110142_110347(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics, System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
        additionalOperationTreeVerifier)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: additionalOperationTreeVerifier);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 110142, 110347);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_111670_111715(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 111670, 111715);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_111670_111751(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 111670, 111751);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_111670_111772(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 111670, 111772);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier
        f_22020_111973_112001()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 111973, 112001);
            return return_v;
        }


        int
        f_22020_111804_112009(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics, System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
        additionalOperationTreeVerifier)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: additionalOperationTreeVerifier);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 111804, 112009);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier
        f_22020_113281_113309()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 113281, 113309);
            return return_v;
        }


        int
        f_22020_113112_113317(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics, System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
        additionalOperationTreeVerifier)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: additionalOperationTreeVerifier);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 113112, 113317);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier
        f_22020_114591_114619()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 114591, 114619);
            return return_v;
        }


        int
        f_22020_114422_114627(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics, System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
        additionalOperationTreeVerifier)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: additionalOperationTreeVerifier);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 114422, 114627);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_115930_115981(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 115930, 115981);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_115930_116001(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 115930, 116001);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_115930_116021(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 115930, 116021);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier
        f_22020_116226_116254()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 116226, 116254);
            return return_v;
        }


        int
        f_22020_116053_116262(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics, System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
        additionalOperationTreeVerifier)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: additionalOperationTreeVerifier);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 116053, 116262);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_117635_117682(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 117635, 117682);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_117635_117713(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 117635, 117713);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_117635_117733(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 117635, 117733);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_117924_117975(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 117924, 117975);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_117924_117995(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 117924, 117995);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_117924_118015(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 117924, 118015);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier
        f_22020_118216_118244()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 118216, 118244);
            return return_v;
        }


        int
        f_22020_118047_118252(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics, System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
        additionalOperationTreeVerifier)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: additionalOperationTreeVerifier);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 118047, 118252);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_119642_119692(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 119642, 119692);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_119642_119722(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 119642, 119722);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_119642_119742(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 119642, 119742);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier
        f_22020_119943_119971()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 119943, 119971);
            return return_v;
        }


        int
        f_22020_119774_119979(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics, System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
        additionalOperationTreeVerifier)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: additionalOperationTreeVerifier);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 119774, 119979);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier
        f_22020_121407_121435()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 121407, 121435);
            return return_v;
        }


        int
        f_22020_121238_121443(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics, System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
        additionalOperationTreeVerifier)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: additionalOperationTreeVerifier);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 121238, 121443);
            return 0;
        }


        int
        f_22020_123037_123380(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics, System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
        additionalOperationTreeVerifier)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: additionalOperationTreeVerifier);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 123037, 123380);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_125674_125725(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 125674, 125725);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_125674_125745(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 125674, 125745);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_125674_125765(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 125674, 125765);
            return return_v;
        }


        int
        f_22020_125797_125915(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 125797, 125915);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_127463_127511(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 127463, 127511);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_127463_127537(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 127463, 127537);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_127463_127557(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 127463, 127557);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_127702_127753(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 127702, 127753);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_127702_127773(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 127702, 127773);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_127702_127793(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 127702, 127793);
            return return_v;
        }


        int
        f_22020_127825_127943(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 127825, 127943);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier
        f_22020_129496_129524()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 129496, 129524);
            return return_v;
        }


        int
        f_22020_129327_129532(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics, System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
        additionalOperationTreeVerifier)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: additionalOperationTreeVerifier);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 129327, 129532);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier
        f_22020_130871_130899()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 130871, 130899);
            return return_v;
        }


        int
        f_22020_130635_130907(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        compilationOptions, System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
        additionalOperationTreeVerifier)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics, compilationOptions: compilationOptions, additionalOperationTreeVerifier: additionalOperationTreeVerifier);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 130635, 130907);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier
        f_22020_132272_132300()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 132272, 132300);
            return return_v;
        }


        int
        f_22020_132036_132308(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        compilationOptions, System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
        additionalOperationTreeVerifier)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics, compilationOptions: compilationOptions, additionalOperationTreeVerifier: additionalOperationTreeVerifier);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 132036, 132308);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_133693_133743(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 133693, 133743);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_133693_133774(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 133693, 133774);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_133693_133794(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 133693, 133794);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier
        f_22020_134062_134090()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 134062, 134090);
            return return_v;
        }


        int
        f_22020_133826_134098(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        compilationOptions, System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
        additionalOperationTreeVerifier)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics, compilationOptions: compilationOptions, additionalOperationTreeVerifier: additionalOperationTreeVerifier);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 133826, 134098);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_135448_135497(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 135448, 135497);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_135448_135527(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 135448, 135527);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_135448_135547(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 135448, 135547);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier
        f_22020_135816_135844()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 135816, 135844);
            return return_v;
        }


        int
        f_22020_135580_135852(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        compilationOptions, System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
        additionalOperationTreeVerifier)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics, compilationOptions: compilationOptions, additionalOperationTreeVerifier: additionalOperationTreeVerifier);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 135580, 135852);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier
        f_22020_138084_138112()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 138084, 138112);
            return return_v;
        }


        int
        f_22020_137915_138120(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics, System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
        additionalOperationTreeVerifier)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: additionalOperationTreeVerifier);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 137915, 138120);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_140105_140152(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 140105, 140152);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_140105_140181(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 140105, 140181);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_140105_140201(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 140105, 140201);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_140507_140563(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 140507, 140563);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_140507_140598(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 140507, 140598);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_140507_140618(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 140507, 140618);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier
        f_22020_141021_141049()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 141021, 141049);
            return return_v;
        }


        int
        f_22020_140852_141057(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics, System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
        additionalOperationTreeVerifier)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: additionalOperationTreeVerifier);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 140852, 141057);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_143043_143089(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 143043, 143089);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_143043_143108(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 143043, 143108);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_143043_143128(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 143043, 143128);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier
        f_22020_143329_143357()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 143329, 143357);
            return return_v;
        }


        int
        f_22020_143160_143365(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics, System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
        additionalOperationTreeVerifier)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: additionalOperationTreeVerifier);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 143160, 143365);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier
        f_22020_144476_144504()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 144476, 144504);
            return return_v;
        }


        int
        f_22020_144310_144512(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics, System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
        additionalOperationTreeVerifier)
        {
            VerifyOperationTreeAndDiagnosticsForTest<ReturnStatementSyntax>(testSrc, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: additionalOperationTreeVerifier);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 144310, 144512);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_145706_145755(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 145706, 145755);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_145706_145785(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 145706, 145785);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_145706_145805(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 145706, 145805);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier
        f_22020_146003_146031()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 146003, 146031);
            return return_v;
        }


        int
        f_22020_145837_146039(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics, System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
        additionalOperationTreeVerifier)
        {
            VerifyOperationTreeAndDiagnosticsForTest<ReturnStatementSyntax>(testSrc, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: additionalOperationTreeVerifier);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 145837, 146039);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_147784_147834(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 147784, 147834);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_147784_147853(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 147784, 147853);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_147784_147874(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 147784, 147874);
            return return_v;
        }


        int
        f_22020_147906_148031(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<LocalDeclarationStatementSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 147906, 148031);
            return 0;
        }


        int
        f_22020_149716_149841(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<LocalDeclarationStatementSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 149716, 149841);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_151796_151852(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 151796, 151852);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_151796_151913(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 151796, 151913);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_151796_151933(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 151796, 151933);
            return return_v;
        }


        int
        f_22020_151965_152090(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<LocalDeclarationStatementSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 151965, 152090);
            return 0;
        }


        int
        f_22020_153631_153728(string
        testSrc, string
        expectedFlowGraph, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>(testSrc, expectedFlowGraph, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 153631, 153728);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_155065_155115(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 155065, 155115);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_155065_155134(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 155065, 155134);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_155065_155154(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 155065, 155154);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier
        f_22020_155355_155383()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 155355, 155383);
            return return_v;
        }


        int
        f_22020_155186_155391(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics, System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
        additionalOperationTreeVerifier)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: additionalOperationTreeVerifier);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 155186, 155391);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_156978_157028(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 156978, 157028);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_156978_157047(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 156978, 157047);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_156978_157067(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 156978, 157067);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier
        f_22020_157268_157296()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 157268, 157296);
            return return_v;
        }


        int
        f_22020_157099_157304(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics, System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
        additionalOperationTreeVerifier)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: additionalOperationTreeVerifier);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 157099, 157304);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_158282_158332(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 158282, 158332);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_158282_158351(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 158282, 158351);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_158282_158371(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 158282, 158371);
            return return_v;
        }


        int
        f_22020_158403_158517(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<CastExpressionSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 158403, 158517);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_160269_160327(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 160269, 160327);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_160269_160357(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 160269, 160357);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_160269_160377(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 160269, 160377);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_160566_160616(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 160566, 160616);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_160566_160635(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 160566, 160635);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_160566_160655(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 160566, 160655);
            return return_v;
        }


        int
        f_22020_160687_160805(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 160687, 160805);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_162447_162493(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 162447, 162493);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_162447_162512(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 162447, 162512);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_162447_162532(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 162447, 162532);
            return return_v;
        }


        int
        f_22020_162564_162682(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 162564, 162682);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_163946_163997(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 163946, 163997);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_163946_164017(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 163946, 164017);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_163946_164037(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 163946, 164037);
            return return_v;
        }


        int
        f_22020_164069_164187(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 164069, 164187);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_165572_165622(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 165572, 165622);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_165572_165641(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 165572, 165641);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_165572_165661(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 165572, 165661);
            return return_v;
        }


        int
        f_22020_165693_165811(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 165693, 165811);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_167201_167252(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 167201, 167252);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_167201_167272(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 167201, 167272);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_167201_167292(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 167201, 167292);
            return return_v;
        }


        int
        f_22020_167324_167442(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 167324, 167442);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_169135_169197(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 169135, 169197);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_169135_169225(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 169135, 169225);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_169135_169245(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 169135, 169245);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_169419_169470(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 169419, 169470);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_169419_169490(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 169419, 169490);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_169419_169510(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 169419, 169510);
            return return_v;
        }


        int
        f_22020_169542_169660(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 169542, 169660);
            return 0;
        }


        int
        f_22020_170801_170919(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 170801, 170919);
            return 0;
        }


        int
        f_22020_172056_172174(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 172056, 172174);
            return 0;
        }


        int
        f_22020_173314_173432(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 173314, 173432);
            return 0;
        }


        int
        f_22020_174569_174687(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 174569, 174687);
            return 0;
        }


        int
        f_22020_175803_175921(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 175803, 175921);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_177228_177278(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 177228, 177278);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_177228_177304(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 177228, 177304);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_177228_177324(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 177228, 177324);
            return return_v;
        }


        int
        f_22020_177356_177474(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 177356, 177474);
            return 0;
        }


        int
        f_22020_178602_178720(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 178602, 178720);
            return 0;
        }


        int
        f_22020_179841_179959(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 179841, 179959);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_181282_181332(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 181282, 181332);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_181282_181358(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 181282, 181358);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_181282_181378(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 181282, 181378);
            return return_v;
        }


        int
        f_22020_181410_181528(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 181410, 181528);
            return 0;
        }


        int
        f_22020_182674_182792(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 182674, 182792);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_184063_184109(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 184063, 184109);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_184063_184128(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 184063, 184128);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_184063_184148(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 184063, 184148);
            return return_v;
        }


        int
        f_22020_184180_184298(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 184180, 184298);
            return 0;
        }


        int
        f_22020_185467_185585(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 185467, 185585);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_186970_187025(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 186970, 187025);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_186970_187055(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 186970, 187055);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_186970_187075(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 186970, 187075);
            return return_v;
        }


        int
        f_22020_187107_187225(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 187107, 187225);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_188606_188663(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 188606, 188663);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_188606_188695(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 188606, 188695);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_188606_188715(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 188606, 188715);
            return return_v;
        }


        int
        f_22020_188747_188865(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 188747, 188865);
            return 0;
        }


        int
        f_22020_190041_190159(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 190041, 190159);
            return 0;
        }


        int
        f_22020_191445_191563(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 191445, 191563);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_193118_193178(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 193118, 193178);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_193118_193242(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 193118, 193242);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_193118_193263(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 193118, 193263);
            return return_v;
        }


        int
        f_22020_193295_193413(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 193295, 193413);
            return 0;
        }


        int
        f_22020_194658_194776(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 194658, 194776);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_196292_196350(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 196292, 196350);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_196292_196414(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 196292, 196414);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_196292_196435(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 196292, 196435);
            return return_v;
        }


        int
        f_22020_196467_196585(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 196467, 196585);
            return 0;
        }


        int
        f_22020_197765_197883(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 197765, 197883);
            return 0;
        }


        int
        f_22020_199119_199237(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 199119, 199237);
            return 0;
        }


        int
        f_22020_200349_200467(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 200349, 200467);
            return 0;
        }


        int
        f_22020_201575_201693(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 201575, 201693);
            return 0;
        }


        int
        f_22020_202837_202955(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 202837, 202955);
            return 0;
        }


        int
        f_22020_204092_204210(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 204092, 204210);
            return 0;
        }


        int
        f_22020_205359_205477(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 205359, 205477);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_207255_207309(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 207255, 207309);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_207255_207338(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 207255, 207338);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_207255_207358(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 207255, 207358);
            return return_v;
        }


        int
        f_22020_207390_207508(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 207390, 207508);
            return 0;
        }


        int
        f_22020_208650_208768(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 208650, 208768);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_210099_210148(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 210099, 210148);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_210099_210174(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 210099, 210174);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_210099_210194(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 210099, 210194);
            return return_v;
        }


        int
        f_22020_210226_210344(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 210226, 210344);
            return 0;
        }


        int
        f_22020_211708_211826(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 211708, 211826);
            return 0;
        }


        int
        f_22020_212915_213033(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 212915, 213033);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_214289_214337(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 214289, 214337);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_214289_214361(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 214289, 214361);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_214289_214381(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 214289, 214381);
            return return_v;
        }


        int
        f_22020_214413_214531(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 214413, 214531);
            return 0;
        }


        int
        f_22020_215611_215729(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 215611, 215729);
            return 0;
        }


        int
        f_22020_216816_216934(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 216816, 216934);
            return 0;
        }


        int
        f_22020_218177_218295(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 218177, 218295);
            return 0;
        }


        int
        f_22020_219518_219636(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 219518, 219636);
            return 0;
        }


        int
        f_22020_221223_221341(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 221223, 221341);
            return 0;
        }


        int
        f_22020_222287_222402(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<ReturnStatementSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 222287, 222402);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_223530_223584(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 223530, 223584);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_223530_223615(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 223530, 223615);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_223530_223635(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 223530, 223635);
            return return_v;
        }


        int
        f_22020_223667_223782(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<ReturnStatementSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 223667, 223782);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_224876_224922(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 224876, 224922);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_224876_224941(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 224876, 224941);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_224876_224961(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 224876, 224961);
            return return_v;
        }


        int
        f_22020_224993_225108(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<ReturnStatementSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 224993, 225108);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_226897_226947(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 226897, 226947);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_226897_226966(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 226897, 226966);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_226897_226987(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 226897, 226987);
            return return_v;
        }


        int
        f_22020_227019_227144(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<LocalDeclarationStatementSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 227019, 227144);
            return 0;
        }


        int
        f_22020_228140_228254(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<CastExpressionSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 228140, 228254);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_229482_229551(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 229482, 229551);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_229482_229612(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 229482, 229612);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22020_229482_229632(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 229482, 229632);
            return return_v;
        }


        int
        f_22020_229664_229778(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<CastExpressionSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 229664, 229778);
            return 0;
        }


        int
        f_22020_232824_232921(string
        testSrc, string
        expectedFlowGraph, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>(testSrc, expectedFlowGraph, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 232824, 232921);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22020_233542_233567(string
        source)
        {
            var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 233542, 233567);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxTree>
        f_22020_233593_233616(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        this_param)
        {
            var return_v = this_param.SyntaxTrees;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22020, 233593, 233616);
            return return_v;
        }


        Microsoft.CodeAnalysis.SemanticModel
        f_22020_233646_233680(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        this_param, Microsoft.CodeAnalysis.SyntaxTree
        syntaxTree)
        {
            var return_v = this_param.GetSemanticModel(syntaxTree);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 233646, 233680);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxNode
        f_22020_233714_233728(Microsoft.CodeAnalysis.SyntaxTree
        this_param)
        {
            var return_v = this_param.GetRoot();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 233714, 233728);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        f_22020_233714_233746(Microsoft.CodeAnalysis.SyntaxNode
        this_param)
        {
            var return_v = this_param.DescendantNodes();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 233714, 233746);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.AssignmentExpressionSyntax>
        f_22020_233714_233783(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        source)
        {
            var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.AssignmentExpressionSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 233714, 233783);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.AssignmentExpressionSyntax
        f_22020_233714_233791(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.AssignmentExpressionSyntax>
        source)
        {
            var return_v = source.First<Microsoft.CodeAnalysis.CSharp.Syntax.AssignmentExpressionSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 233714, 233791);
            return return_v;
        }


        Microsoft.CodeAnalysis.IOperation?
        f_22020_233842_233872(Microsoft.CodeAnalysis.SemanticModel
        this_param, Microsoft.CodeAnalysis.CSharp.Syntax.AssignmentExpressionSyntax
        node)
        {
            var return_v = this_param.GetOperation((Microsoft.CodeAnalysis.SyntaxNode)node);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 233842, 233872);
            return return_v;
        }


        Microsoft.CodeAnalysis.IOperation
        f_22020_233943_233956(Microsoft.CodeAnalysis.Operations.IAssignmentOperation?
        this_param)
        {
            var return_v = this_param.Value;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22020, 233943, 233956);
            return return_v;
        }


        Microsoft.CodeAnalysis.ITypeSymbol?
        f_22020_233943_233961(Microsoft.CodeAnalysis.IOperation
        this_param)
        {
            var return_v = this_param.Type;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22020, 233943, 233961);
            return return_v;
        }


        Microsoft.CodeAnalysis.NullableAnnotation
        f_22020_233943_233980(Microsoft.CodeAnalysis.ITypeSymbol?
        this_param)
        {
            var return_v = this_param.NullableAnnotation;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22020, 233943, 233980);
            return return_v;
        }


        int
        f_22020_233887_233981(Microsoft.CodeAnalysis.NullableAnnotation
        expected, Microsoft.CodeAnalysis.NullableAnnotation
        actual)
        {
            Assert.Equal(expected, actual);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22020, 233887, 233981);
            return 0;
        }

    }
}
