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
        [Fact, WorkItem(17596, "https://github.com/dotnet/roslyn/issues/17596")]
        public void SimpleArrayCreation_PrimitiveType()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22002, 501, 1299);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 655, 780);

                string
                source = @"
class C
{
    public void F()
    {
        var a = /*<bind>*/new string[1]/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 794, 1081);

                string
                expectedOperationTree = @"
IArrayCreationOperation (OperationKind.ArrayCreation, Type: System.String[]) (Syntax: 'new string[1]')
  Dimension Sizes(1):
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
  Initializer: 
    null
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 1095, 1148);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 1164, 1288);

                f_22002_1164_1287(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22002, 501, 1299);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22002, 501, 1299);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22002, 501, 1299);
            }
        }

        [Fact, WorkItem(17596, "https://github.com/dotnet/roslyn/issues/17596")]
        public void SimpleArrayCreation_UserDefinedType()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22002, 1311, 2104);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 1467, 1602);

                string
                source = @"
class M { }

class C
{
    public void F()
    {
        var a = /*<bind>*/new M[1]/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 1616, 1886);

                string
                expectedOperationTree = @"
IArrayCreationOperation (OperationKind.ArrayCreation, Type: M[]) (Syntax: 'new M[1]')
  Dimension Sizes(1):
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
  Initializer: 
    null
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 1900, 1953);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 1969, 2093);

                f_22002_1969_2092(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22002, 1311, 2104);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22002, 1311, 2104);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22002, 1311, 2104);
            }
        }

        [Fact, WorkItem(17596, "https://github.com/dotnet/roslyn/issues/17596")]
        public void SimpleArrayCreation_ConstantDimension()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22002, 2116, 2994);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 2274, 2451);

                string
                source = @"
class M { }

class C
{
    public void F()
    {
        const int dimension = 1;
        var a = /*<bind>*/new M[dimension]/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 2465, 2776);

                string
                expectedOperationTree = @"
IArrayCreationOperation (OperationKind.ArrayCreation, Type: M[]) (Syntax: 'new M[dimension]')
  Dimension Sizes(1):
      ILocalReferenceOperation: dimension (OperationKind.LocalReference, Type: System.Int32, Constant: 1) (Syntax: 'dimension')
  Initializer: 
    null
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 2790, 2843);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 2859, 2983);

                f_22002_2859_2982(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22002, 2116, 2994);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22002, 2116, 2994);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22002, 2116, 2994);
            }
        }

        [Fact, WorkItem(17596, "https://github.com/dotnet/roslyn/issues/17596")]
        public void SimpleArrayCreation_NonConstantDimension()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22002, 3006, 3861);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 3167, 3323);

                string
                source = @"
class M { }

class C
{
    public void F(int dimension)
    {
        var a = /*<bind>*/new M[dimension]/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 3337, 3643);

                string
                expectedOperationTree = @"
IArrayCreationOperation (OperationKind.ArrayCreation, Type: M[]) (Syntax: 'new M[dimension]')
  Dimension Sizes(1):
      IParameterReferenceOperation: dimension (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'dimension')
  Initializer: 
    null
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 3657, 3710);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 3726, 3850);

                f_22002_3726_3849(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22002, 3006, 3861);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22002, 3006, 3861);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22002, 3006, 3861);
            }
        }

        [Fact, WorkItem(17596, "https://github.com/dotnet/roslyn/issues/17596")]
        public void SimpleArrayCreation_DimensionWithImplicitConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22002, 3873, 5051);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 4045, 4202);

                string
                source = @"
class M { }

class C
{
    public void F(char dimension)
    {
        var a = /*<bind>*/new M[dimension]/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 4216, 4833);

                string
                expectedOperationTree = @"
IArrayCreationOperation (OperationKind.ArrayCreation, Type: M[]) (Syntax: 'new M[dimension]')
  Dimension Sizes(1):
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32, IsImplicit) (Syntax: 'dimension')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          IParameterReferenceOperation: dimension (OperationKind.ParameterReference, Type: System.Char) (Syntax: 'dimension')
  Initializer: 
    null
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 4847, 4900);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 4916, 5040);

                f_22002_4916_5039(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22002, 3873, 5051);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22002, 3873, 5051);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22002, 3873, 5051);
            }
        }

        [Fact, WorkItem(17596, "https://github.com/dotnet/roslyn/issues/17596")]
        public void SimpleArrayCreation_DimensionWithExplicitConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22002, 5063, 6249);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 5235, 5399);

                string
                source = @"
class M { }

class C
{
    public void F(object dimension)
    {
        var a = /*<bind>*/new M[(int)dimension]/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 5413, 6031);

                string
                expectedOperationTree = @"
IArrayCreationOperation (OperationKind.ArrayCreation, Type: M[]) (Syntax: 'new M[(int)dimension]')
  Dimension Sizes(1):
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32) (Syntax: '(int)dimension')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          IParameterReferenceOperation: dimension (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'dimension')
  Initializer: 
    null
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 6045, 6098);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 6114, 6238);

                f_22002_6114_6237(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22002, 5063, 6249);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22002, 5063, 6249);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22002, 5063, 6249);
            }
        }

        [Fact, WorkItem(17596, "https://github.com/dotnet/roslyn/issues/17596")]
        public void ArrayCreationWithInitializer_PrimitiveType()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22002, 6261, 7481);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 6424, 6565);

                string
                source = @"
class C
{
    public void F()
    {
        var a = /*<bind>*/new string[] { string.Empty }/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 6579, 7263);

                string
                expectedOperationTree = @"
IArrayCreationOperation (OperationKind.ArrayCreation, Type: System.String[]) (Syntax: 'new string[ ... ing.Empty }')
  Dimension Sizes(1):
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1, IsImplicit) (Syntax: 'new string[ ... ing.Empty }')
  Initializer: 
    IArrayInitializerOperation (1 elements) (OperationKind.ArrayInitializer, Type: null) (Syntax: '{ string.Empty }')
      Element Values(1):
          IFieldReferenceOperation: System.String System.String.Empty (Static) (OperationKind.FieldReference, Type: System.String) (Syntax: 'string.Empty')
            Instance Receiver: 
              null
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 7277, 7330);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 7346, 7470);

                f_22002_7346_7469(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22002, 6261, 7481);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22002, 6261, 7481);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22002, 6261, 7481);
            }
        }

        [Fact, WorkItem(17596, "https://github.com/dotnet/roslyn/issues/17596")]
        public void ArrayCreationWithInitializer_PrimitiveTypeWithExplicitDimension()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22002, 7493, 8697);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 7677, 7819);

                string
                source = @"
class C
{
    public void F()
    {
        var a = /*<bind>*/new string[1] { string.Empty }/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 7833, 8479);

                string
                expectedOperationTree = @"
IArrayCreationOperation (OperationKind.ArrayCreation, Type: System.String[]) (Syntax: 'new string[ ... ing.Empty }')
  Dimension Sizes(1):
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
  Initializer: 
    IArrayInitializerOperation (1 elements) (OperationKind.ArrayInitializer, Type: null) (Syntax: '{ string.Empty }')
      Element Values(1):
          IFieldReferenceOperation: System.String System.String.Empty (Static) (OperationKind.FieldReference, Type: System.String) (Syntax: 'string.Empty')
            Instance Receiver: 
              null
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 8493, 8546);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 8562, 8686);

                f_22002_8562_8685(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22002, 7493, 8697);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22002, 7493, 8697);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22002, 7493, 8697);
            }
        }

        [Fact, WorkItem(17596, "https://github.com/dotnet/roslyn/issues/17596")]
        public void ArrayCreationWithInitializerErrorCase_PrimitiveTypeWithIncorrectExplicitDimension()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22002, 8709, 10280);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 8911, 9053);

                string
                source = @"
class C
{
    public void F()
    {
        var a = /*<bind>*/new string[2] { string.Empty }/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 9067, 9746);

                string
                expectedOperationTree = @"
IArrayCreationOperation (OperationKind.ArrayCreation, Type: System.String[], IsInvalid) (Syntax: 'new string[ ... ing.Empty }')
  Dimension Sizes(1):
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
  Initializer: 
    IArrayInitializerOperation (1 elements) (OperationKind.ArrayInitializer, Type: null, IsInvalid) (Syntax: '{ string.Empty }')
      Element Values(1):
          IFieldReferenceOperation: System.String System.String.Empty (Static) (OperationKind.FieldReference, Type: System.String, IsInvalid) (Syntax: 'string.Empty')
            Instance Receiver: 
              null
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 9760, 10129);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22002_9997_10113(f_22002_9997_10093(f_22002_9997_10074(ErrorCode.ERR_ArrayInitializerIncorrectLength, "{ string.Empty }"), "2"), 6, 41)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 10145, 10269);

                f_22002_10145_10268(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22002, 8709, 10280);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22002, 8709, 10280);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22002, 8709, 10280);
            }
        }

        [Fact, WorkItem(17596, "https://github.com/dotnet/roslyn/issues/17596")]
        public void ArrayCreationWithInitializerErrorCase_PrimitiveTypeWithNonConstantExplicitDimension()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22002, 10292, 11852);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 10496, 10659);

                string
                source = @"
class C
{
    public void F(int dimension)
    {
        var a = /*<bind>*/new string[dimension] { string.Empty }/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 10673, 11369);

                string
                expectedOperationTree = @"
IArrayCreationOperation (OperationKind.ArrayCreation, Type: System.String[], IsInvalid) (Syntax: 'new string[ ... ing.Empty }')
  Dimension Sizes(1):
      IParameterReferenceOperation: dimension (OperationKind.ParameterReference, Type: System.Int32, IsInvalid) (Syntax: 'dimension')
  Initializer: 
    IArrayInitializerOperation (1 elements) (OperationKind.ArrayInitializer, Type: null) (Syntax: '{ string.Empty }')
      Element Values(1):
          IFieldReferenceOperation: System.String System.String.Empty (Static) (OperationKind.FieldReference, Type: System.String) (Syntax: 'string.Empty')
            Instance Receiver: 
              null
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 11383, 11701);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22002_11610_11685(f_22002_11610_11665(ErrorCode.ERR_ConstantExpected, "dimension"), 6, 38)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 11717, 11841);

                f_22002_11717_11840(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22002, 10292, 11852);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22002, 10292, 11852);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22002, 10292, 11852);
            }
        }

        [Fact, WorkItem(17596, "https://github.com/dotnet/roslyn/issues/17596")]
        public void ArrayCreationWithInitializer_NoExplicitArrayCreationExpression()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22002, 11864, 13758);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 12047, 12182);

                string
                source = @"
class C
{
    public void F(int dimension)
    {
        /*<bind>*/int[] x = { 1, 2 };/*</bind>*/
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 12196, 13538);

                string
                expectedOperationTree = @"
IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null) (Syntax: 'int[] x = { 1, 2 };')
  IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'int[] x = { 1, 2 }')
    Declarators:
        IVariableDeclaratorOperation (Symbol: System.Int32[] x) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'x = { 1, 2 }')
          Initializer: 
            IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= { 1, 2 }')
              IArrayCreationOperation (OperationKind.ArrayCreation, Type: System.Int32[], IsImplicit) (Syntax: '{ 1, 2 }')
                Dimension Sizes(1):
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2, IsImplicit) (Syntax: '{ 1, 2 }')
                Initializer: 
                  IArrayInitializerOperation (2 elements) (OperationKind.ArrayInitializer, Type: null) (Syntax: '{ 1, 2 }')
                    Element Values(2):
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
    Initializer: 
      null
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 13552, 13605);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 13621, 13747);

                f_22002_13621_13746(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22002, 11864, 13758);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22002, 11864, 13758);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22002, 11864, 13758);
            }
        }

        [Fact, WorkItem(17596, "https://github.com/dotnet/roslyn/issues/17596")]
        public void ArrayCreationWithInitializer_UserDefinedType()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22002, 13770, 14948);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 13935, 14081);

                string
                source = @"
class M { }

class C
{
    public void F()
    {
        var a = /*<bind>*/new M[] { new M() }/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 14095, 14730);

                string
                expectedOperationTree = @"
IArrayCreationOperation (OperationKind.ArrayCreation, Type: M[]) (Syntax: 'new M[] { new M() }')
  Dimension Sizes(1):
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1, IsImplicit) (Syntax: 'new M[] { new M() }')
  Initializer: 
    IArrayInitializerOperation (1 elements) (OperationKind.ArrayInitializer, Type: null) (Syntax: '{ new M() }')
      Element Values(1):
          IObjectCreationOperation (Constructor: M..ctor()) (OperationKind.ObjectCreation, Type: M) (Syntax: 'new M()')
            Arguments(0)
            Initializer: 
              null
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 14744, 14797);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 14813, 14937);

                f_22002_14813_14936(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22002, 13770, 14948);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22002, 13770, 14948);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22002, 13770, 14948);
            }
        }

        [Fact, WorkItem(17596, "https://github.com/dotnet/roslyn/issues/17596")]
        public void ArrayCreationWithInitializer_ImplicitlyTyped()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22002, 14960, 16140);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 15125, 15269);

                string
                source = @"
class M { }

class C
{
    public void F()
    {
        var a = /*<bind>*/new[] { new M() }/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 15283, 15914);

                string
                expectedOperationTree = @"
IArrayCreationOperation (OperationKind.ArrayCreation, Type: M[]) (Syntax: 'new[] { new M() }')
  Dimension Sizes(1):
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1, IsImplicit) (Syntax: 'new[] { new M() }')
  Initializer: 
    IArrayInitializerOperation (1 elements) (OperationKind.ArrayInitializer, Type: null) (Syntax: '{ new M() }')
      Element Values(1):
          IObjectCreationOperation (Constructor: M..ctor()) (OperationKind.ObjectCreation, Type: M) (Syntax: 'new M()')
            Arguments(0)
            Initializer: 
              null
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 15928, 15981);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 15997, 16129);

                f_22002_15997_16128(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22002, 14960, 16140);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22002, 14960, 16140);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22002, 14960, 16140);
            }
        }

        [Fact, WorkItem(17596, "https://github.com/dotnet/roslyn/issues/17596")]
        public void ArrayCreationWithInitializerErrorCase_ImplicitlyTypedWithoutInitializerAndDimension()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22002, 16152, 17826);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 16356, 16486);

                string
                source = @"
class C
{
    public void F(int dimension)
    {
        var x = /*<bind>*/new[]/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 16500, 16956);

                string
                expectedOperationTree = @"
IArrayCreationOperation (OperationKind.ArrayCreation, Type: ?[], IsInvalid) (Syntax: 'new[]/*</bind>*/')
  Dimension Sizes(1):
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0, IsInvalid, IsImplicit) (Syntax: 'new[]/*</bind>*/')
  Initializer: 
    IArrayInitializerOperation (0 elements) (OperationKind.ArrayInitializer, Type: null, IsInvalid) (Syntax: '')
      Element Values(0)
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 16970, 17667);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22002_17146_17211(f_22002_17146_17191(ErrorCode.ERR_LbraceExpected, ";"), 6, 43),
f_22002_17333_17398(f_22002_17333_17378(ErrorCode.ERR_RbraceExpected, ";"), 6, 43),
f_22002_17555_17651(f_22002_17555_17631(ErrorCode.ERR_ImplicitlyTypedArrayNoBestType, "new[]/*</bind>*/"), 6, 27)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 17683, 17815);

                f_22002_17683_17814(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22002, 16152, 17826);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22002, 16152, 17826);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22002, 16152, 17826);
            }
        }

        [Fact, WorkItem(17596, "https://github.com/dotnet/roslyn/issues/17596")]
        public void ArrayCreationWithInitializerErrorCase_ImplicitlyTypedWithoutInitializer()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22002, 17838, 19810);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 18030, 18161);

                string
                source = @"
class C
{
    public void F(int dimension)
    {
        var x = /*<bind>*/new[2]/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 18175, 18633);

                string
                expectedOperationTree = @"
IArrayCreationOperation (OperationKind.ArrayCreation, Type: ?[], IsInvalid) (Syntax: 'new[2]/*</bind>*/')
  Dimension Sizes(1):
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0, IsInvalid, IsImplicit) (Syntax: 'new[2]/*</bind>*/')
  Initializer: 
    IArrayInitializerOperation (0 elements) (OperationKind.ArrayInitializer, Type: null, IsInvalid) (Syntax: '')
      Element Values(0)
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 18647, 19651);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22002_18878_18941(f_22002_18878_18921(ErrorCode.ERR_InvalidArray, "2"), 6, 31),
f_22002_19085_19150(f_22002_19085_19130(ErrorCode.ERR_LbraceExpected, ";"), 6, 44),
f_22002_19294_19359(f_22002_19294_19339(ErrorCode.ERR_RbraceExpected, ";"), 6, 44),
f_22002_19538_19635(f_22002_19538_19615(ErrorCode.ERR_ImplicitlyTypedArrayNoBestType, "new[2]/*</bind>*/"), 6, 27)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 19667, 19799);

                f_22002_19667_19798(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22002, 17838, 19810);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22002, 17838, 19810);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22002, 17838, 19810);
            }
        }

        [Fact, WorkItem(17596, "https://github.com/dotnet/roslyn/issues/17596")]
        public void ArrayCreationWithInitializer_MultipleInitializersWithConversions()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22002, 19822, 21548);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 20007, 20170);

                string
                source = @"
class C
{
    public void F()
    {
        var a = """";
        var b = /*<bind>*/new[] { ""hello"", a, null }/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 20184, 21322);

                string
                expectedOperationTree = @"
IArrayCreationOperation (OperationKind.ArrayCreation, Type: System.String[]) (Syntax: 'new[] { ""he ... , a, null }')
  Dimension Sizes(1):
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3, IsImplicit) (Syntax: 'new[] { ""he ... , a, null }')
  Initializer: 
    IArrayInitializerOperation (3 elements) (OperationKind.ArrayInitializer, Type: null) (Syntax: '{ ""hello"", a, null }')
      Element Values(3):
          ILiteralOperation (OperationKind.Literal, Type: System.String, Constant: ""hello"") (Syntax: '""hello""')
          ILocalReferenceOperation: a (OperationKind.LocalReference, Type: System.String) (Syntax: 'a')
          IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.String, Constant: null, IsImplicit) (Syntax: 'null')
            Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
            Operand: 
              ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 21336, 21389);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 21405, 21537);

                f_22002_21405_21536(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22002, 19822, 21548);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22002, 19822, 21548);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22002, 19822, 21548);
            }
        }

        [Fact, WorkItem(17596, "https://github.com/dotnet/roslyn/issues/17596")]
        public void MultiDimensionalArrayCreation()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22002, 21560, 22557);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 21710, 21844);

                string
                source = @"
class C
{
    public void F()
    {
        byte[,,] b = /*<bind>*/new byte[1,2,3]/*</bind>*/;

    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 21858, 22339);

                string
                expectedOperationTree = @"
IArrayCreationOperation (OperationKind.ArrayCreation, Type: System.Byte[,,]) (Syntax: 'new byte[1,2,3]')
  Dimension Sizes(3):
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')
  Initializer: 
    null
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 22353, 22406);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 22422, 22546);

                f_22002_22422_22545(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22002, 21560, 22557);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22002, 21560, 22557);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22002, 21560, 22557);
            }
        }

        [Fact, WorkItem(17596, "https://github.com/dotnet/roslyn/issues/17596")]
        public void MultiDimensionalArrayCreation_WithInitializer()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22002, 22569, 27388);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 22735, 22901);

                string
                source = @"
class C
{
    public void F()
    {
        byte[,,] b = /*<bind>*/new byte[,,] { { { 1, 2, 3 } }, { { 4, 5, 6 } } }/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 22915, 27170);

                string
                expectedOperationTree = @"
IArrayCreationOperation (OperationKind.ArrayCreation, Type: System.Byte[,,]) (Syntax: 'new byte[,, ...  5, 6 } } }')
  Dimension Sizes(3):
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2, IsImplicit) (Syntax: 'new byte[,, ...  5, 6 } } }')
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1, IsImplicit) (Syntax: 'new byte[,, ...  5, 6 } } }')
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3, IsImplicit) (Syntax: 'new byte[,, ...  5, 6 } } }')
  Initializer: 
    IArrayInitializerOperation (2 elements) (OperationKind.ArrayInitializer, Type: null) (Syntax: '{ { { 1, 2, ...  5, 6 } } }')
      Element Values(2):
          IArrayInitializerOperation (1 elements) (OperationKind.ArrayInitializer, Type: null) (Syntax: '{ { 1, 2, 3 } }')
            Element Values(1):
                IArrayInitializerOperation (3 elements) (OperationKind.ArrayInitializer, Type: null) (Syntax: '{ 1, 2, 3 }')
                  Element Values(3):
                      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Byte, Constant: 1, IsImplicit) (Syntax: '1')
                        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        Operand: 
                          ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
                      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Byte, Constant: 2, IsImplicit) (Syntax: '2')
                        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        Operand: 
                          ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
                      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Byte, Constant: 3, IsImplicit) (Syntax: '3')
                        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        Operand: 
                          ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')
          IArrayInitializerOperation (1 elements) (OperationKind.ArrayInitializer, Type: null) (Syntax: '{ { 4, 5, 6 } }')
            Element Values(1):
                IArrayInitializerOperation (3 elements) (OperationKind.ArrayInitializer, Type: null) (Syntax: '{ 4, 5, 6 }')
                  Element Values(3):
                      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Byte, Constant: 4, IsImplicit) (Syntax: '4')
                        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        Operand: 
                          ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 4) (Syntax: '4')
                      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Byte, Constant: 5, IsImplicit) (Syntax: '5')
                        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        Operand: 
                          ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 5) (Syntax: '5')
                      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Byte, Constant: 6, IsImplicit) (Syntax: '6')
                        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        Operand: 
                          ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 6) (Syntax: '6')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 27184, 27237);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 27253, 27377);

                f_22002_27253_27376(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22002, 22569, 27388);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22002, 22569, 27388);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22002, 22569, 27388);
            }
        }

        [Fact, WorkItem(17596, "https://github.com/dotnet/roslyn/issues/17596")]
        public void ArrayCreationOfSingleDimensionalArrays()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22002, 27400, 29535);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 27559, 27720);

                string
                source = @"
class C
{
    public void F()
    {
        int[][] a = /*<bind>*/new int[][] { new[] { 1, 2, 3 }, new int[5] }/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 27734, 29317);

                string
                expectedOperationTree = @"
IArrayCreationOperation (OperationKind.ArrayCreation, Type: System.Int32[][]) (Syntax: 'new int[][] ... ew int[5] }')
  Dimension Sizes(1):
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2, IsImplicit) (Syntax: 'new int[][] ... ew int[5] }')
  Initializer: 
    IArrayInitializerOperation (2 elements) (OperationKind.ArrayInitializer, Type: null) (Syntax: '{ new[] { 1 ... ew int[5] }')
      Element Values(2):
          IArrayCreationOperation (OperationKind.ArrayCreation, Type: System.Int32[]) (Syntax: 'new[] { 1, 2, 3 }')
            Dimension Sizes(1):
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3, IsImplicit) (Syntax: 'new[] { 1, 2, 3 }')
            Initializer: 
              IArrayInitializerOperation (3 elements) (OperationKind.ArrayInitializer, Type: null) (Syntax: '{ 1, 2, 3 }')
                Element Values(3):
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')
          IArrayCreationOperation (OperationKind.ArrayCreation, Type: System.Int32[]) (Syntax: 'new int[5]')
            Dimension Sizes(1):
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 5) (Syntax: '5')
            Initializer: 
              null
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 29331, 29384);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 29400, 29524);

                f_22002_29400_29523(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22002, 27400, 29535);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22002, 27400, 29535);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22002, 27400, 29535);
            }
        }

        [Fact, WorkItem(17596, "https://github.com/dotnet/roslyn/issues/17596")]
        public void ArrayCreationOfMultiDimensionalArrays()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22002, 29547, 30356);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 29705, 29835);

                string
                source = @"
class C
{
    public void F()
    {
        int[][,] a = /*<bind>*/new int[1][,]/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 29849, 30138);

                string
                expectedOperationTree = @"
IArrayCreationOperation (OperationKind.ArrayCreation, Type: System.Int32[][,]) (Syntax: 'new int[1][,]')
  Dimension Sizes(1):
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
  Initializer: 
    null
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 30152, 30205);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 30221, 30345);

                f_22002_30221_30344(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22002, 29547, 30356);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22002, 29547, 30356);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22002, 29547, 30356);
            }
        }

        [Fact, WorkItem(17596, "https://github.com/dotnet/roslyn/issues/17596")]
        public void ArrayCreationOfImplicitlyTypedMultiDimensionalArrays_WithInitializer()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22002, 30368, 34227);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 30557, 30731);

                string
                source = @"
class C
{
    public void F()
    {
        var a = /*<bind>*/new[] { new[, ,] { { { 1, 2 } } }, new[, ,] { { { 3, 4 } } } }/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 30745, 34001);

                string
                expectedOperationTree = @"
IArrayCreationOperation (OperationKind.ArrayCreation, Type: System.Int32[][,,]) (Syntax: 'new[] { new ... , 4 } } } }')
  Dimension Sizes(1):
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2, IsImplicit) (Syntax: 'new[] { new ... , 4 } } } }')
  Initializer: 
    IArrayInitializerOperation (2 elements) (OperationKind.ArrayInitializer, Type: null) (Syntax: '{ new[, ,]  ... , 4 } } } }')
      Element Values(2):
          IArrayCreationOperation (OperationKind.ArrayCreation, Type: System.Int32[,,]) (Syntax: 'new[, ,] {  ...  1, 2 } } }')
            Dimension Sizes(3):
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1, IsImplicit) (Syntax: 'new[, ,] {  ...  1, 2 } } }')
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1, IsImplicit) (Syntax: 'new[, ,] {  ...  1, 2 } } }')
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2, IsImplicit) (Syntax: 'new[, ,] {  ...  1, 2 } } }')
            Initializer: 
              IArrayInitializerOperation (1 elements) (OperationKind.ArrayInitializer, Type: null) (Syntax: '{ { { 1, 2 } } }')
                Element Values(1):
                    IArrayInitializerOperation (1 elements) (OperationKind.ArrayInitializer, Type: null) (Syntax: '{ { 1, 2 } }')
                      Element Values(1):
                          IArrayInitializerOperation (2 elements) (OperationKind.ArrayInitializer, Type: null) (Syntax: '{ 1, 2 }')
                            Element Values(2):
                                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
                                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
          IArrayCreationOperation (OperationKind.ArrayCreation, Type: System.Int32[,,]) (Syntax: 'new[, ,] {  ...  3, 4 } } }')
            Dimension Sizes(3):
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1, IsImplicit) (Syntax: 'new[, ,] {  ...  3, 4 } } }')
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1, IsImplicit) (Syntax: 'new[, ,] {  ...  3, 4 } } }')
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2, IsImplicit) (Syntax: 'new[, ,] {  ...  3, 4 } } }')
            Initializer: 
              IArrayInitializerOperation (1 elements) (OperationKind.ArrayInitializer, Type: null) (Syntax: '{ { { 3, 4 } } }')
                Element Values(1):
                    IArrayInitializerOperation (1 elements) (OperationKind.ArrayInitializer, Type: null) (Syntax: '{ { 3, 4 } }')
                      Element Values(1):
                          IArrayInitializerOperation (2 elements) (OperationKind.ArrayInitializer, Type: null) (Syntax: '{ 3, 4 }')
                            Element Values(2):
                                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')
                                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 4) (Syntax: '4')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 34015, 34068);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 34084, 34216);

                f_22002_34084_34215(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22002, 30368, 34227);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22002, 30368, 34227);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22002, 30368, 34227);
            }
        }

        [Fact, WorkItem(17596, "https://github.com/dotnet/roslyn/issues/17596")]
        public void ArrayCreationErrorCase_MissingDimension()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22002, 34239, 35215);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 34399, 34523);

                string
                source = @"
class C
{
    public void F()
    {
        var a = /*<bind>*/new string[]/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 34537, 34737);

                string
                expectedOperationTree = @"
IArrayCreationOperation (OperationKind.ArrayCreation, Type: System.String[], IsInvalid) (Syntax: 'new string[]')
  Dimension Sizes(0)
  Initializer: 
    null
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 34751, 35064);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22002_34980_35048(f_22002_34980_35028(ErrorCode.ERR_MissingArraySize, "[]"), 6, 37)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 35080, 35204);

                f_22002_35080_35203(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22002, 34239, 35215);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22002, 34239, 35215);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22002, 34239, 35215);
            }
        }

        [Fact, WorkItem(17596, "https://github.com/dotnet/roslyn/issues/17596")]
        public void ArrayCreationErrorCase_InvalidInitializer()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22002, 35227, 36956);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 35389, 35519);

                string
                source = @"
class C
{
    public void F()
    {
        var a = /*<bind>*/new string[] { 1 }/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 35533, 36452);

                string
                expectedOperationTree = @"
IArrayCreationOperation (OperationKind.ArrayCreation, Type: System.String[], IsInvalid) (Syntax: 'new string[] { 1 }')
  Dimension Sizes(1):
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1, IsInvalid, IsImplicit) (Syntax: 'new string[] { 1 }')
  Initializer: 
    IArrayInitializerOperation (1 elements) (OperationKind.ArrayInitializer, Type: null, IsInvalid) (Syntax: '{ 1 }')
      Element Values(1):
          IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.String, IsInvalid, IsImplicit) (Syntax: '1')
            Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            Operand: 
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1, IsInvalid) (Syntax: '1')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 36466, 36805);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22002_36693_36789(f_22002_36693_36769(f_22002_36693_36738(ErrorCode.ERR_NoImplicitConv, "1"), "int", "string"), 6, 42)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 36821, 36945);

                f_22002_36821_36944(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22002, 35227, 36956);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22002, 35227, 36956);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22002, 35227, 36956);
            }
        }

        [Fact, WorkItem(17596, "https://github.com/dotnet/roslyn/issues/17596")]
        public void ArrayCreationErrorCase_MissingExplicitCast()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22002, 36968, 38497);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 37131, 37264);

                string
                source = @"
class C
{
    public void F(object b)
    {
        var a = /*<bind>*/new string[b]/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 37278, 37916);

                string
                expectedOperationTree = @"
IArrayCreationOperation (OperationKind.ArrayCreation, Type: System.String[], IsInvalid) (Syntax: 'new string[b]')
  Dimension Sizes(1):
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'b')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Object, IsInvalid) (Syntax: 'b')
  Initializer: 
    null
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 37930, 38346);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22002_38230_38330(f_22002_38230_38310(f_22002_38230_38279(ErrorCode.ERR_NoImplicitConvCast, "b"), "object", "int"), 6, 38)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 38362, 38486);

                f_22002_38362_38485(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22002, 36968, 38497);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22002, 36968, 38497);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22002, 36968, 38497);
            }
        }

        [Fact, WorkItem(17596, "https://github.com/dotnet/roslyn/issues/17596")]
        public void ArrayCreation_InvocationExpressionAsDimension()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22002, 38509, 39567);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 38675, 38830);

                string
                source = @"
class C
{
    public void F()
    {
        var a = /*<bind>*/new string[M()]/*</bind>*/;
    }

    public int M() => 1;
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 38844, 39349);

                string
                expectedOperationTree = @"
IArrayCreationOperation (OperationKind.ArrayCreation, Type: System.String[]) (Syntax: 'new string[M()]')
  Dimension Sizes(1):
      IInvocationOperation ( System.Int32 C.M()) (OperationKind.Invocation, Type: System.Int32) (Syntax: 'M()')
        Instance Receiver: 
          IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C, IsImplicit) (Syntax: 'M')
        Arguments(0)
  Initializer: 
    null
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 39363, 39416);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 39432, 39556);

                f_22002_39432_39555(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22002, 38509, 39567);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22002, 38509, 39567);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22002, 38509, 39567);
            }
        }

        [Fact, WorkItem(17596, "https://github.com/dotnet/roslyn/issues/17596")]
        public void ArrayCreation_InvocationExpressionWithConversionAsDimension()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22002, 39579, 40981);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 39759, 39925);

                string
                source = @"
class C
{
    public void F()
    {
        var a = /*<bind>*/new string[(int)M()]/*</bind>*/;
    }

    public object M() => null;
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 39939, 40763);

                string
                expectedOperationTree = @"
IArrayCreationOperation (OperationKind.ArrayCreation, Type: System.String[]) (Syntax: 'new string[(int)M()]')
  Dimension Sizes(1):
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32) (Syntax: '(int)M()')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          IInvocationOperation ( System.Object C.M()) (OperationKind.Invocation, Type: System.Object) (Syntax: 'M()')
            Instance Receiver: 
              IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C, IsImplicit) (Syntax: 'M')
            Arguments(0)
  Initializer: 
    null
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 40777, 40830);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 40846, 40970);

                f_22002_40846_40969(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22002, 39579, 40981);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22002, 39579, 40981);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22002, 39579, 40981);
            }
        }

        [Fact, WorkItem(17596, "https://github.com/dotnet/roslyn/issues/17596")]
        public void ArrayCreationErrorCase_InvocationExpressionAsDimension()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22002, 40993, 42668);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 41168, 41343);

                string
                source = @"
class C
{
    public static void F()
    {
        var a = /*<bind>*/new string[M()]/*</bind>*/;
    }

    public static object M() => null;
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 41357, 42083);

                string
                expectedOperationTree = @"
IArrayCreationOperation (OperationKind.ArrayCreation, Type: System.String[], IsInvalid) (Syntax: 'new string[M()]')
  Dimension Sizes(1):
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'M()')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          IInvocationOperation (System.Object C.M()) (OperationKind.Invocation, Type: System.Object, IsInvalid) (Syntax: 'M()')
            Instance Receiver: 
              null
            Arguments(0)
  Initializer: 
    null
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 42097, 42517);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22002_42399_42501(f_22002_42399_42481(f_22002_42399_42450(ErrorCode.ERR_NoImplicitConvCast, "M()"), "object", "int"), 6, 38)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 42533, 42657);

                f_22002_42533_42656(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22002, 40993, 42668);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22002, 40993, 42668);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22002, 40993, 42668);
            }
        }

        [Fact, WorkItem(17596, "https://github.com/dotnet/roslyn/issues/17596")]
        public void ArrayCreationErrorCase_InvocationExpressionWithConversionAsDimension()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22002, 42680, 44384);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 42869, 43033);

                string
                source = @"
class C
{
    public void F()
    {
        var a = /*<bind>*/new string[(int)M()]/*</bind>*/;
    }

    public C M() => new C();
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 43047, 43892);

                string
                expectedOperationTree = @"
IArrayCreationOperation (OperationKind.ArrayCreation, Type: System.String[], IsInvalid) (Syntax: 'new string[(int)M()]')
  Dimension Sizes(1):
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32, IsInvalid) (Syntax: '(int)M()')
        Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          IInvocationOperation ( C C.M()) (OperationKind.Invocation, Type: C, IsInvalid) (Syntax: 'M()')
            Instance Receiver: 
              IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C, IsInvalid, IsImplicit) (Syntax: 'M')
            Arguments(0)
  Initializer: 
    null
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 43906, 44233);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22002_44119_44217(f_22002_44119_44197(f_22002_44119_44171(ErrorCode.ERR_NoExplicitConv, "(int)M()"), "C", "int"), 6, 38)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 44249, 44373);

                f_22002_44249_44372(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22002, 42680, 44384);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22002, 42680, 44384);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22002, 42680, 44384);
            }
        }

        [Fact, WorkItem(7299, "https://github.com/dotnet/roslyn/issues/7299")]
        public void SimpleArrayCreation_ConstantConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22002, 44396, 45923);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 44553, 44680);

                string
                source = @"
class C
{
    public void F()
    {
        var a = /*<bind>*/new string[0.0]/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 44694, 45338);

                string
                expectedOperationTree = @"
IArrayCreationOperation (OperationKind.ArrayCreation, Type: System.String[], IsInvalid) (Syntax: 'new string[0.0]')
  Dimension Sizes(1):
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32, Constant: 0, IsInvalid, IsImplicit) (Syntax: '0.0')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          ILiteralOperation (OperationKind.Literal, Type: System.Double, Constant: 0, IsInvalid) (Syntax: '0.0')
  Initializer: 
    null
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 45352, 45772);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22002_45654_45756(f_22002_45654_45736(f_22002_45654_45705(ErrorCode.ERR_NoImplicitConvCast, "0.0"), "double", "int"), 6, 38)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 45788, 45912);

                f_22002_45788_45911(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22002, 44396, 45923);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22002, 44396, 45923);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22002, 44396, 45923);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ArrayCreationAndInitializer_NoControlFlow()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22002, 45935, 56408);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 46110, 47006);

                string
                source = @"
class C
{
    const int c1 = 2, c2 = 1, c3 = 1;
    void M(int[] a1, int[] a2, int[,] a3, int[,] a4, int[][] a5, int[][] a6,
           int d1, int d2, int d3, int d4, int v1, int v2, int v3, int v4)
    /*<bind>*/
    {
        a1 = new int[d1];                               // Single dimension, no initializer
        a2 = new int[] { v1 };                          // Single dimension, initializer
        a3 = new int[d2, d3];                           // Multi-dimension, no initializer
        a4 = new int[c1, c2] { { v2 }, { v3 } };        // Multi-dimension, initializer
        a5 = new int[d4][];                             // Jagged, no initializer
        a6 = new int[c3][] { new[] { v4 } };            // Jagged, initializer
        int[] f = { 1, 3, 4 };                          // Array creation with only initializer.
    }/*</bind>*/
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 47020, 56216);

                string
                expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [System.Int32[] f]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (7)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'a1 = new int[d1];')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32[]) (Syntax: 'a1 = new int[d1]')
                  Left: 
                    IParameterReferenceOperation: a1 (OperationKind.ParameterReference, Type: System.Int32[]) (Syntax: 'a1')
                  Right: 
                    IArrayCreationOperation (OperationKind.ArrayCreation, Type: System.Int32[]) (Syntax: 'new int[d1]')
                      Dimension Sizes(1):
                          IParameterReferenceOperation: d1 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'd1')
                      Initializer: 
                        null

            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'a2 = new int[] { v1 };')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32[]) (Syntax: 'a2 = new int[] { v1 }')
                  Left: 
                    IParameterReferenceOperation: a2 (OperationKind.ParameterReference, Type: System.Int32[]) (Syntax: 'a2')
                  Right: 
                    IArrayCreationOperation (OperationKind.ArrayCreation, Type: System.Int32[]) (Syntax: 'new int[] { v1 }')
                      Dimension Sizes(1):
                          ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1, IsImplicit) (Syntax: 'new int[] { v1 }')
                      Initializer: 
                        IArrayInitializerOperation (1 elements) (OperationKind.ArrayInitializer, Type: null) (Syntax: '{ v1 }')
                          Element Values(1):
                              IParameterReferenceOperation: v1 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'v1')

            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'a3 = new int[d2, d3];')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32[,]) (Syntax: 'a3 = new int[d2, d3]')
                  Left: 
                    IParameterReferenceOperation: a3 (OperationKind.ParameterReference, Type: System.Int32[,]) (Syntax: 'a3')
                  Right: 
                    IArrayCreationOperation (OperationKind.ArrayCreation, Type: System.Int32[,]) (Syntax: 'new int[d2, d3]')
                      Dimension Sizes(2):
                          IParameterReferenceOperation: d2 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'd2')
                          IParameterReferenceOperation: d3 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'd3')
                      Initializer: 
                        null

            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'a4 = new in ... , { v3 } };')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32[,]) (Syntax: 'a4 = new in ... }, { v3 } }')
                  Left: 
                    IParameterReferenceOperation: a4 (OperationKind.ParameterReference, Type: System.Int32[,]) (Syntax: 'a4')
                  Right: 
                    IArrayCreationOperation (OperationKind.ArrayCreation, Type: System.Int32[,]) (Syntax: 'new int[c1, ... }, { v3 } }')
                      Dimension Sizes(2):
                          IFieldReferenceOperation: System.Int32 C.c1 (Static) (OperationKind.FieldReference, Type: System.Int32, Constant: 2) (Syntax: 'c1')
                            Instance Receiver: 
                              null
                          IFieldReferenceOperation: System.Int32 C.c2 (Static) (OperationKind.FieldReference, Type: System.Int32, Constant: 1) (Syntax: 'c2')
                            Instance Receiver: 
                              null
                      Initializer: 
                        IArrayInitializerOperation (2 elements) (OperationKind.ArrayInitializer, Type: null) (Syntax: '{ { v2 }, { v3 } }')
                          Element Values(2):
                              IArrayInitializerOperation (1 elements) (OperationKind.ArrayInitializer, Type: null) (Syntax: '{ v2 }')
                                Element Values(1):
                                    IParameterReferenceOperation: v2 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'v2')
                              IArrayInitializerOperation (1 elements) (OperationKind.ArrayInitializer, Type: null) (Syntax: '{ v3 }')
                                Element Values(1):
                                    IParameterReferenceOperation: v3 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'v3')

            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'a5 = new int[d4][];')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32[][]) (Syntax: 'a5 = new int[d4][]')
                  Left: 
                    IParameterReferenceOperation: a5 (OperationKind.ParameterReference, Type: System.Int32[][]) (Syntax: 'a5')
                  Right: 
                    IArrayCreationOperation (OperationKind.ArrayCreation, Type: System.Int32[][]) (Syntax: 'new int[d4][]')
                      Dimension Sizes(1):
                          IParameterReferenceOperation: d4 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'd4')
                      Initializer: 
                        null

            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'a6 = new in ... ] { v4 } };')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32[][]) (Syntax: 'a6 = new in ... [] { v4 } }')
                  Left: 
                    IParameterReferenceOperation: a6 (OperationKind.ParameterReference, Type: System.Int32[][]) (Syntax: 'a6')
                  Right: 
                    IArrayCreationOperation (OperationKind.ArrayCreation, Type: System.Int32[][]) (Syntax: 'new int[c3] ... [] { v4 } }')
                      Dimension Sizes(1):
                          IFieldReferenceOperation: System.Int32 C.c3 (Static) (OperationKind.FieldReference, Type: System.Int32, Constant: 1) (Syntax: 'c3')
                            Instance Receiver: 
                              null
                      Initializer: 
                        IArrayInitializerOperation (1 elements) (OperationKind.ArrayInitializer, Type: null) (Syntax: '{ new[] { v4 } }')
                          Element Values(1):
                              IArrayCreationOperation (OperationKind.ArrayCreation, Type: System.Int32[]) (Syntax: 'new[] { v4 }')
                                Dimension Sizes(1):
                                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1, IsImplicit) (Syntax: 'new[] { v4 }')
                                Initializer: 
                                  IArrayInitializerOperation (1 elements) (OperationKind.ArrayInitializer, Type: null) (Syntax: '{ v4 }')
                                    Element Values(1):
                                        IParameterReferenceOperation: v4 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'v4')

            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32[], IsImplicit) (Syntax: 'f = { 1, 3, 4 }')
              Left: 
                ILocalReferenceOperation: f (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32[], IsImplicit) (Syntax: 'f = { 1, 3, 4 }')
              Right: 
                IArrayCreationOperation (OperationKind.ArrayCreation, Type: System.Int32[], IsImplicit) (Syntax: '{ 1, 3, 4 }')
                  Dimension Sizes(1):
                      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3, IsImplicit) (Syntax: '{ 1, 3, 4 }')
                  Initializer: 
                    IArrayInitializerOperation (3 elements) (OperationKind.ArrayInitializer, Type: null) (Syntax: '{ 1, 3, 4 }')
                      Element Values(3):
                          ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
                          ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')
                          ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 4) (Syntax: '4')

        Next (Regular) Block[B2]
            Leaving: {R1}
}

Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 56230, 56283);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 56299, 56397);

                f_22002_56299_56396(source, expectedFlowGraph, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22002, 45935, 56408);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22002, 45935, 56408);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22002, 45935, 56408);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ArrayCreationAndInitializer_ControlFlowInFirstDimension_NoInitializer()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22002, 56420, 60622);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 56623, 56784);

                string
                source = @"
class C
{
    void M(int[,] a1, int? d1, int d2, int c)
    /*<bind>*/
    {
        a1 = new int[d1 ?? d2, c];
    }/*</bind>*/
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 56798, 60430);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a1')
              Value: 
                IParameterReferenceOperation: a1 (OperationKind.ParameterReference, Type: System.Int32[,]) (Syntax: 'a1')

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
                    IParameterReferenceOperation: d1 (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'd1')

            Jump if True (Regular) to Block[B4]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'd1')
                  Operand: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'd1')
                Leaving: {R2}

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'd1')
                  Value: 
                    IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsImplicit) (Syntax: 'd1')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'd1')
                      Arguments(0)

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B4] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'd2')
              Value: 
                IParameterReferenceOperation: d2 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'd2')

        Next (Regular) Block[B5]
    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'a1 = new in ...  ?? d2, c];')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32[,]) (Syntax: 'a1 = new in ... 1 ?? d2, c]')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32[,], IsImplicit) (Syntax: 'a1')
                  Right: 
                    IArrayCreationOperation (OperationKind.ArrayCreation, Type: System.Int32[,]) (Syntax: 'new int[d1 ?? d2, c]')
                      Dimension Sizes(2):
                          IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'd1 ?? d2')
                          IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'c')
                      Initializer: 
                        null

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 60444, 60497);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 60513, 60611);

                f_22002_60513_60610(source, expectedFlowGraph, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22002, 56420, 60622);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22002, 56420, 60622);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22002, 56420, 60622);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ArrayCreationAndInitializer_ControlFlowInFirstDimension_WithInitializer()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22002, 60634, 65866);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 60839, 61034);

                string
                source = @"
class C
{
    const int c = 1;
    void M(int[,] a1, int? d1, int d2, int v1)
    /*<bind>*/
    {
        a1 = new int[d1 ?? d2, c] { { v1 } };
    }/*</bind>*/
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 61048, 65420);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a1')
              Value: 
                IParameterReferenceOperation: a1 (OperationKind.ParameterReference, Type: System.Int32[,]) (Syntax: 'a1')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'd1')
                  Value: 
                    IParameterReferenceOperation: d1 (OperationKind.ParameterReference, Type: System.Int32?, IsInvalid) (Syntax: 'd1')

            Jump if True (Regular) to Block[B4]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsInvalid, IsImplicit) (Syntax: 'd1')
                  Operand: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsInvalid, IsImplicit) (Syntax: 'd1')
                Leaving: {R2}

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'd1')
                  Value: 
                    IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'd1')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsInvalid, IsImplicit) (Syntax: 'd1')
                      Arguments(0)

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B4] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'd2')
              Value: 
                IParameterReferenceOperation: d2 (OperationKind.ParameterReference, Type: System.Int32, IsInvalid) (Syntax: 'd2')

        Next (Regular) Block[B5]
    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: 'a1 = new in ... { { v1 } };')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32[,], IsInvalid) (Syntax: 'a1 = new in ...  { { v1 } }')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32[,], IsImplicit) (Syntax: 'a1')
                  Right: 
                    IArrayCreationOperation (OperationKind.ArrayCreation, Type: System.Int32[,], IsInvalid) (Syntax: 'new int[d1  ...  { { v1 } }')
                      Dimension Sizes(2):
                          IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'd1 ?? d2')
                          IFieldReferenceOperation: System.Int32 C.c (Static) (OperationKind.FieldReference, Type: System.Int32, Constant: 1) (Syntax: 'c')
                            Instance Receiver: 
                              null
                      Initializer: 
                        IArrayInitializerOperation (1 elements) (OperationKind.ArrayInitializer, Type: null) (Syntax: '{ { v1 } }')
                          Element Values(1):
                              IArrayInitializerOperation (1 elements) (OperationKind.ArrayInitializer, Type: null) (Syntax: '{ v1 }')
                                Element Values(1):
                                    IParameterReferenceOperation: v1 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'v1')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 65434, 65741);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22002_65651_65725(f_22002_65651_65705(ErrorCode.ERR_ConstantExpected, "d1 ?? d2"), 8, 22)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 65757, 65855);

                f_22002_65757_65854(source, expectedFlowGraph, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22002, 60634, 65866);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22002, 60634, 65866);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22002, 60634, 65866);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ArrayCreationAndInitializer_ControlFlowInSecondDimension_NoInitializer()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22002, 65878, 70348);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 66082, 66243);

                string
                source = @"
class C
{
    void M(int[,] a1, int? d1, int d2, int c)
    /*<bind>*/
    {
        a1 = new int[c, d1 ?? d2];
    }/*</bind>*/
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 66257, 70156);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a1')
              Value: 
                IParameterReferenceOperation: a1 (OperationKind.ParameterReference, Type: System.Int32[,]) (Syntax: 'a1')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c')
              Value: 
                IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'c')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'd1')
                  Value: 
                    IParameterReferenceOperation: d1 (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'd1')

            Jump if True (Regular) to Block[B4]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'd1')
                  Operand: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'd1')
                Leaving: {R2}

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'd1')
                  Value: 
                    IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsImplicit) (Syntax: 'd1')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'd1')
                      Arguments(0)

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B4] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'd2')
              Value: 
                IParameterReferenceOperation: d2 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'd2')

        Next (Regular) Block[B5]
    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'a1 = new in ...  d1 ?? d2];')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32[,]) (Syntax: 'a1 = new in ... , d1 ?? d2]')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32[,], IsImplicit) (Syntax: 'a1')
                  Right: 
                    IArrayCreationOperation (OperationKind.ArrayCreation, Type: System.Int32[,]) (Syntax: 'new int[c, d1 ?? d2]')
                      Dimension Sizes(2):
                          IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'c')
                          IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'd1 ?? d2')
                      Initializer: 
                        null

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 70170, 70223);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 70239, 70337);

                f_22002_70239_70336(source, expectedFlowGraph, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22002, 65878, 70348);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22002, 65878, 70348);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22002, 65878, 70348);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ArrayCreationAndInitializer_ControlFlowInSecondDimension_WithInitializer()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22002, 70360, 75853);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 70566, 70761);

                string
                source = @"
class C
{
    const int c = 1;
    void M(int[,] a1, int? d1, int d2, int v1)
    /*<bind>*/
    {
        a1 = new int[c, d1 ?? d2] { { v1 } };
    }/*</bind>*/
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 70775, 75407);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a1')
              Value: 
                IParameterReferenceOperation: a1 (OperationKind.ParameterReference, Type: System.Int32[,]) (Syntax: 'a1')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c')
              Value: 
                IFieldReferenceOperation: System.Int32 C.c (Static) (OperationKind.FieldReference, Type: System.Int32, Constant: 1) (Syntax: 'c')
                  Instance Receiver: 
                    null

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'd1')
                  Value: 
                    IParameterReferenceOperation: d1 (OperationKind.ParameterReference, Type: System.Int32?, IsInvalid) (Syntax: 'd1')

            Jump if True (Regular) to Block[B4]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsInvalid, IsImplicit) (Syntax: 'd1')
                  Operand: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsInvalid, IsImplicit) (Syntax: 'd1')
                Leaving: {R2}

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'd1')
                  Value: 
                    IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'd1')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsInvalid, IsImplicit) (Syntax: 'd1')
                      Arguments(0)

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B4] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'd2')
              Value: 
                IParameterReferenceOperation: d2 (OperationKind.ParameterReference, Type: System.Int32, IsInvalid) (Syntax: 'd2')

        Next (Regular) Block[B5]
    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: 'a1 = new in ... { { v1 } };')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32[,], IsInvalid) (Syntax: 'a1 = new in ...  { { v1 } }')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32[,], IsImplicit) (Syntax: 'a1')
                  Right: 
                    IArrayCreationOperation (OperationKind.ArrayCreation, Type: System.Int32[,], IsInvalid) (Syntax: 'new int[c,  ...  { { v1 } }')
                      Dimension Sizes(2):
                          IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32, Constant: 1, IsImplicit) (Syntax: 'c')
                          IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'd1 ?? d2')
                      Initializer: 
                        IArrayInitializerOperation (1 elements) (OperationKind.ArrayInitializer, Type: null) (Syntax: '{ { v1 } }')
                          Element Values(1):
                              IArrayInitializerOperation (1 elements) (OperationKind.ArrayInitializer, Type: null) (Syntax: '{ v1 }')
                                Element Values(1):
                                    IParameterReferenceOperation: v1 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'v1')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 75421, 75728);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22002_75638_75712(f_22002_75638_75692(ErrorCode.ERR_ConstantExpected, "d1 ?? d2"), 8, 25)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 75744, 75842);

                f_22002_75744_75841(source, expectedFlowGraph, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22002, 70360, 75853);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22002, 70360, 75853);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22002, 70360, 75853);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ArrayCreationAndInitializer_ControlFlowInMultipleDimensions()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22002, 75865, 83290);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 76058, 76255);

                string
                source = @"
class C
{
    void M(int[,] a1, int? d1, int d2, int? d3, int d4, int v1)
    /*<bind>*/
    {
        a1 = new int[d1 ?? d2, d3 ?? d4] { { v1 } };
    }/*</bind>*/
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 76269, 82577);

                string
                expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [2] [4]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a1')
              Value: 
                IParameterReferenceOperation: a1 (OperationKind.ParameterReference, Type: System.Int32[,]) (Syntax: 'a1')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'd1')
                  Value: 
                    IParameterReferenceOperation: d1 (OperationKind.ParameterReference, Type: System.Int32?, IsInvalid) (Syntax: 'd1')

            Jump if True (Regular) to Block[B4]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsInvalid, IsImplicit) (Syntax: 'd1')
                  Operand: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsInvalid, IsImplicit) (Syntax: 'd1')
                Leaving: {R2}

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'd1')
                  Value: 
                    IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'd1')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsInvalid, IsImplicit) (Syntax: 'd1')
                      Arguments(0)

            Next (Regular) Block[B5]
                Leaving: {R2}
                Entering: {R3}
    }

    Block[B4] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'd2')
              Value: 
                IParameterReferenceOperation: d2 (OperationKind.ParameterReference, Type: System.Int32, IsInvalid) (Syntax: 'd2')

        Next (Regular) Block[B5]
            Entering: {R3}

    .locals {R3}
    {
        CaptureIds: [3]
        Block[B5] - Block
            Predecessors: [B3] [B4]
            Statements (1)
                IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'd3')
                  Value: 
                    IParameterReferenceOperation: d3 (OperationKind.ParameterReference, Type: System.Int32?, IsInvalid) (Syntax: 'd3')

            Jump if True (Regular) to Block[B7]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsInvalid, IsImplicit) (Syntax: 'd3')
                  Operand: 
                    IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsInvalid, IsImplicit) (Syntax: 'd3')
                Leaving: {R3}

            Next (Regular) Block[B6]
        Block[B6] - Block
            Predecessors: [B5]
            Statements (1)
                IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'd3')
                  Value: 
                    IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'd3')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsInvalid, IsImplicit) (Syntax: 'd3')
                      Arguments(0)

            Next (Regular) Block[B8]
                Leaving: {R3}
    }

    Block[B7] - Block
        Predecessors: [B5]
        Statements (1)
            IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'd4')
              Value: 
                IParameterReferenceOperation: d4 (OperationKind.ParameterReference, Type: System.Int32, IsInvalid) (Syntax: 'd4')

        Next (Regular) Block[B8]
    Block[B8] - Block
        Predecessors: [B6] [B7]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: 'a1 = new in ... { { v1 } };')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32[,], IsInvalid) (Syntax: 'a1 = new in ...  { { v1 } }')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32[,], IsImplicit) (Syntax: 'a1')
                  Right: 
                    IArrayCreationOperation (OperationKind.ArrayCreation, Type: System.Int32[,], IsInvalid) (Syntax: 'new int[d1  ...  { { v1 } }')
                      Dimension Sizes(2):
                          IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'd1 ?? d2')
                          IFlowCaptureReferenceOperation: 4 (OperationKind.FlowCaptureReference, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'd3 ?? d4')
                      Initializer: 
                        IArrayInitializerOperation (1 elements) (OperationKind.ArrayInitializer, Type: null) (Syntax: '{ { v1 } }')
                          Element Values(1):
                              IArrayInitializerOperation (1 elements) (OperationKind.ArrayInitializer, Type: null) (Syntax: '{ v1 }')
                                Element Values(1):
                                    IParameterReferenceOperation: v1 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'v1')

        Next (Regular) Block[B9]
            Leaving: {R1}
}

Block[B9] - Exit
    Predecessors: [B8]
    Statements (0)
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 82591, 83165);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22002_82831_82905(f_22002_82831_82885(ErrorCode.ERR_ConstantExpected, "d1 ?? d2"), 7, 22),
f_22002_83075_83149(f_22002_83075_83129(ErrorCode.ERR_ConstantExpected, "d3 ?? d4"), 7, 32)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 83181, 83279);

                f_22002_83181_83278(source, expectedFlowGraph, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22002, 75865, 83290);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22002, 75865, 83290);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22002, 75865, 83290);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ArrayCreationAndInitializer_ControlFlowInFirstInitializerValue_SingleDimArray()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22002, 83302, 88217);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 83513, 83705);

                string
                source = @"
class C
{
    const int c1 = 2;
    void M(int[] a1, int? v1, int v2, int v3)
    /*<bind>*/
    {
        a1 = new int[c1] { v1 ?? v2, v3 };
    }/*</bind>*/
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 83719, 88025);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a1')
              Value: 
                IParameterReferenceOperation: a1 (OperationKind.ParameterReference, Type: System.Int32[]) (Syntax: 'a1')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c1')
              Value: 
                IFieldReferenceOperation: System.Int32 C.c1 (Static) (OperationKind.FieldReference, Type: System.Int32, Constant: 2) (Syntax: 'c1')
                  Instance Receiver: 
                    null

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'v1')
                  Value: 
                    IParameterReferenceOperation: v1 (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'v1')

            Jump if True (Regular) to Block[B4]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'v1')
                  Operand: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'v1')
                Leaving: {R2}

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'v1')
                  Value: 
                    IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsImplicit) (Syntax: 'v1')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'v1')
                      Arguments(0)

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B4] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'v2')
              Value: 
                IParameterReferenceOperation: v2 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'v2')

        Next (Regular) Block[B5]
    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'a1 = new in ... ? v2, v3 };')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32[]) (Syntax: 'a1 = new in ... ?? v2, v3 }')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32[], IsImplicit) (Syntax: 'a1')
                  Right: 
                    IArrayCreationOperation (OperationKind.ArrayCreation, Type: System.Int32[]) (Syntax: 'new int[c1] ... ?? v2, v3 }')
                      Dimension Sizes(1):
                          IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32, Constant: 2, IsImplicit) (Syntax: 'c1')
                      Initializer: 
                        IArrayInitializerOperation (2 elements) (OperationKind.ArrayInitializer, Type: null) (Syntax: '{ v1 ?? v2, v3 }')
                          Element Values(2):
                              IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'v1 ?? v2')
                              IParameterReferenceOperation: v3 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'v3')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 88039, 88092);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 88108, 88206);

                f_22002_88108_88205(source, expectedFlowGraph, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22002, 83302, 88217);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22002, 83302, 88217);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22002, 83302, 88217);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ArrayCreationAndInitializer_ControlFlowInFirstInitializerValue_MultiDimArray()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22002, 88229, 94074);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 88439, 88652);

                string
                source = @"
class C
{
    const int c1 = 2, c2 = 1;
    void M(int[,] a1, int? v1, int v2, int v3)
    /*<bind>*/
    {
        a1 = new int[c1, c2] { { v1 ?? v2 }, { v3 } };
    }/*</bind>*/
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 88666, 93882);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a1')
              Value: 
                IParameterReferenceOperation: a1 (OperationKind.ParameterReference, Type: System.Int32[,]) (Syntax: 'a1')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c1')
              Value: 
                IFieldReferenceOperation: System.Int32 C.c1 (Static) (OperationKind.FieldReference, Type: System.Int32, Constant: 2) (Syntax: 'c1')
                  Instance Receiver: 
                    null

            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c2')
              Value: 
                IFieldReferenceOperation: System.Int32 C.c2 (Static) (OperationKind.FieldReference, Type: System.Int32, Constant: 1) (Syntax: 'c2')
                  Instance Receiver: 
                    null

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [3]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'v1')
                  Value: 
                    IParameterReferenceOperation: v1 (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'v1')

            Jump if True (Regular) to Block[B4]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'v1')
                  Operand: 
                    IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'v1')
                Leaving: {R2}

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'v1')
                  Value: 
                    IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsImplicit) (Syntax: 'v1')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'v1')
                      Arguments(0)

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B4] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'v2')
              Value: 
                IParameterReferenceOperation: v2 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'v2')

        Next (Regular) Block[B5]
    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'a1 = new in ... , { v3 } };')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32[,]) (Syntax: 'a1 = new in ... }, { v3 } }')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32[,], IsImplicit) (Syntax: 'a1')
                  Right: 
                    IArrayCreationOperation (OperationKind.ArrayCreation, Type: System.Int32[,]) (Syntax: 'new int[c1, ... }, { v3 } }')
                      Dimension Sizes(2):
                          IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32, Constant: 2, IsImplicit) (Syntax: 'c1')
                          IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, Constant: 1, IsImplicit) (Syntax: 'c2')
                      Initializer: 
                        IArrayInitializerOperation (2 elements) (OperationKind.ArrayInitializer, Type: null) (Syntax: '{ { v1 ?? v2 }, { v3 } }')
                          Element Values(2):
                              IArrayInitializerOperation (1 elements) (OperationKind.ArrayInitializer, Type: null) (Syntax: '{ v1 ?? v2 }')
                                Element Values(1):
                                    IFlowCaptureReferenceOperation: 4 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'v1 ?? v2')
                              IArrayInitializerOperation (1 elements) (OperationKind.ArrayInitializer, Type: null) (Syntax: '{ v3 }')
                                Element Values(1):
                                    IParameterReferenceOperation: v3 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'v3')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 93896, 93949);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 93965, 94063);

                f_22002_93965_94062(source, expectedFlowGraph, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22002, 88229, 94074);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22002, 88229, 94074);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22002, 88229, 94074);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ArrayCreationAndInitializer_ControlFlowInSecondInitializerValue_SingleDimArray()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22002, 94086, 99271);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 94298, 94490);

                string
                source = @"
class C
{
    const int c1 = 2;
    void M(int[] a1, int? v1, int v2, int v3)
    /*<bind>*/
    {
        a1 = new int[c1] { v3, v1 ?? v2 };
    }/*</bind>*/
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 94504, 99079);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a1')
              Value: 
                IParameterReferenceOperation: a1 (OperationKind.ParameterReference, Type: System.Int32[]) (Syntax: 'a1')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c1')
              Value: 
                IFieldReferenceOperation: System.Int32 C.c1 (Static) (OperationKind.FieldReference, Type: System.Int32, Constant: 2) (Syntax: 'c1')
                  Instance Receiver: 
                    null

            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'v3')
              Value: 
                IParameterReferenceOperation: v3 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'v3')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [3]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'v1')
                  Value: 
                    IParameterReferenceOperation: v1 (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'v1')

            Jump if True (Regular) to Block[B4]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'v1')
                  Operand: 
                    IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'v1')
                Leaving: {R2}

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'v1')
                  Value: 
                    IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsImplicit) (Syntax: 'v1')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'v1')
                      Arguments(0)

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B4] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'v2')
              Value: 
                IParameterReferenceOperation: v2 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'v2')

        Next (Regular) Block[B5]
    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'a1 = new in ... v1 ?? v2 };')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32[]) (Syntax: 'a1 = new in ...  v1 ?? v2 }')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32[], IsImplicit) (Syntax: 'a1')
                  Right: 
                    IArrayCreationOperation (OperationKind.ArrayCreation, Type: System.Int32[]) (Syntax: 'new int[c1] ...  v1 ?? v2 }')
                      Dimension Sizes(1):
                          IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32, Constant: 2, IsImplicit) (Syntax: 'c1')
                      Initializer: 
                        IArrayInitializerOperation (2 elements) (OperationKind.ArrayInitializer, Type: null) (Syntax: '{ v3, v1 ?? v2 }')
                          Element Values(2):
                              IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'v3')
                              IFlowCaptureReferenceOperation: 4 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'v1 ?? v2')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 99093, 99146);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 99162, 99260);

                f_22002_99162_99259(source, expectedFlowGraph, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22002, 94086, 99271);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22002, 94086, 99271);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22002, 94086, 99271);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ArrayCreationAndInitializer_ControlFlowInSecondInitializerValue_MultiDimArray()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22002, 99283, 105398);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 99494, 99707);

                string
                source = @"
class C
{
    const int c1 = 2, c2 = 1;
    void M(int[,] a1, int? v1, int v2, int v3)
    /*<bind>*/
    {
        a1 = new int[c1, c2] { { v3 }, { v1 ?? v2 } };
    }/*</bind>*/
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 99721, 105206);

                string
                expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [1] [2] [3] [5]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (4)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a1')
              Value: 
                IParameterReferenceOperation: a1 (OperationKind.ParameterReference, Type: System.Int32[,]) (Syntax: 'a1')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c1')
              Value: 
                IFieldReferenceOperation: System.Int32 C.c1 (Static) (OperationKind.FieldReference, Type: System.Int32, Constant: 2) (Syntax: 'c1')
                  Instance Receiver: 
                    null

            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c2')
              Value: 
                IFieldReferenceOperation: System.Int32 C.c2 (Static) (OperationKind.FieldReference, Type: System.Int32, Constant: 1) (Syntax: 'c2')
                  Instance Receiver: 
                    null

            IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'v3')
              Value: 
                IParameterReferenceOperation: v3 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'v3')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [4]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'v1')
                  Value: 
                    IParameterReferenceOperation: v1 (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'v1')

            Jump if True (Regular) to Block[B4]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'v1')
                  Operand: 
                    IFlowCaptureReferenceOperation: 4 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'v1')
                Leaving: {R2}

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 5 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'v1')
                  Value: 
                    IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsImplicit) (Syntax: 'v1')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 4 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'v1')
                      Arguments(0)

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B4] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 5 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'v2')
              Value: 
                IParameterReferenceOperation: v2 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'v2')

        Next (Regular) Block[B5]
    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'a1 = new in ...  ?? v2 } };')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32[,]) (Syntax: 'a1 = new in ... 1 ?? v2 } }')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32[,], IsImplicit) (Syntax: 'a1')
                  Right: 
                    IArrayCreationOperation (OperationKind.ArrayCreation, Type: System.Int32[,]) (Syntax: 'new int[c1, ... 1 ?? v2 } }')
                      Dimension Sizes(2):
                          IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32, Constant: 2, IsImplicit) (Syntax: 'c1')
                          IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, Constant: 1, IsImplicit) (Syntax: 'c2')
                      Initializer: 
                        IArrayInitializerOperation (2 elements) (OperationKind.ArrayInitializer, Type: null) (Syntax: '{ { v3 }, { v1 ?? v2 } }')
                          Element Values(2):
                              IArrayInitializerOperation (1 elements) (OperationKind.ArrayInitializer, Type: null) (Syntax: '{ v3 }')
                                Element Values(1):
                                    IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'v3')
                              IArrayInitializerOperation (1 elements) (OperationKind.ArrayInitializer, Type: null) (Syntax: '{ v1 ?? v2 }')
                                Element Values(1):
                                    IFlowCaptureReferenceOperation: 5 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'v1 ?? v2')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 105220, 105273);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 105289, 105387);

                f_22002_105289_105386(source, expectedFlowGraph, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22002, 99283, 105398);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22002, 99283, 105398);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22002, 99283, 105398);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ArrayCreationAndInitializer_ControlFlowInSecondInitializerValue_MultiDimArray_02()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22002, 105410, 112012);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 105828, 106037);

                string
                source = @"
class C
{
    const int c1 = 2, c2 = 1;
    void M(int[,] a1, int? v1, int v2, int v3)
    /*<bind>*/
    {
        a1 = new int[c1, c2] { v3, { v1 ?? v2 } };
    }/*</bind>*/
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 106051, 111549);

                string
                expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [1] [2] [3] [5]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (4)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a1')
              Value: 
                IParameterReferenceOperation: a1 (OperationKind.ParameterReference, Type: System.Int32[,]) (Syntax: 'a1')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c1')
              Value: 
                IFieldReferenceOperation: System.Int32 C.c1 (Static) (OperationKind.FieldReference, Type: System.Int32, Constant: 2) (Syntax: 'c1')
                  Instance Receiver: 
                    null

            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c2')
              Value: 
                IFieldReferenceOperation: System.Int32 C.c2 (Static) (OperationKind.FieldReference, Type: System.Int32, Constant: 1) (Syntax: 'c2')
                  Instance Receiver: 
                    null

            IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'v3')
              Value: 
                IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid, IsImplicit) (Syntax: 'v3')
                  Children(1):
                      IParameterReferenceOperation: v3 (OperationKind.ParameterReference, Type: System.Int32, IsInvalid) (Syntax: 'v3')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [4]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'v1')
                  Value: 
                    IParameterReferenceOperation: v1 (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'v1')

            Jump if True (Regular) to Block[B4]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'v1')
                  Operand: 
                    IFlowCaptureReferenceOperation: 4 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'v1')
                Leaving: {R2}

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 5 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'v1')
                  Value: 
                    IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsImplicit) (Syntax: 'v1')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 4 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'v1')
                      Arguments(0)

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B4] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 5 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'v2')
              Value: 
                IParameterReferenceOperation: v2 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'v2')

        Next (Regular) Block[B5]
    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: 'a1 = new in ...  ?? v2 } };')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32[,], IsInvalid) (Syntax: 'a1 = new in ... 1 ?? v2 } }')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32[,], IsImplicit) (Syntax: 'a1')
                  Right: 
                    IArrayCreationOperation (OperationKind.ArrayCreation, Type: System.Int32[,], IsInvalid) (Syntax: 'new int[c1, ... 1 ?? v2 } }')
                      Dimension Sizes(2):
                          IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32, Constant: 2, IsImplicit) (Syntax: 'c1')
                          IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, Constant: 1, IsImplicit) (Syntax: 'c2')
                      Initializer: 
                        IArrayInitializerOperation (2 elements) (OperationKind.ArrayInitializer, Type: null, IsInvalid) (Syntax: '{ v3, { v1 ?? v2 } }')
                          Element Values(2):
                              IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: ?, IsInvalid, IsImplicit) (Syntax: 'v3')
                              IArrayInitializerOperation (1 elements) (OperationKind.ArrayInitializer, Type: null) (Syntax: '{ v1 ?? v2 }')
                                Element Values(1):
                                    IFlowCaptureReferenceOperation: 5 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'v1 ?? v2')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 111563, 111887);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22002_111795_111871(f_22002_111795_111851(ErrorCode.ERR_ArrayInitializerExpected, "v3"), 8, 32)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 111903, 112001);

                f_22002_111903_112000(source, expectedFlowGraph, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22002, 105410, 112012);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22002, 105410, 112012);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22002, 105410, 112012);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ArrayCreationAndInitializer_ControlFlowInMultipleInitializerValues_SingleDimArray()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22002, 112024, 118902);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 112239, 112446);

                string
                source = @"
class C
{
    const int c1 = 2;
    void M(int[] a1, int? v1, int v2, int? v3, int v4)
    /*<bind>*/
    {
        a1 = new int[c1] { v1 ?? v2, v3 ?? v4 };
    }/*</bind>*/
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 112460, 118710);

                string
                expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [1] [3] [5]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (2)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a1')
              Value: 
                IParameterReferenceOperation: a1 (OperationKind.ParameterReference, Type: System.Int32[]) (Syntax: 'a1')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c1')
              Value: 
                IFieldReferenceOperation: System.Int32 C.c1 (Static) (OperationKind.FieldReference, Type: System.Int32, Constant: 2) (Syntax: 'c1')
                  Instance Receiver: 
                    null

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'v1')
                  Value: 
                    IParameterReferenceOperation: v1 (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'v1')

            Jump if True (Regular) to Block[B4]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'v1')
                  Operand: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'v1')
                Leaving: {R2}

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'v1')
                  Value: 
                    IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsImplicit) (Syntax: 'v1')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'v1')
                      Arguments(0)

            Next (Regular) Block[B5]
                Leaving: {R2}
                Entering: {R3}
    }

    Block[B4] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'v2')
              Value: 
                IParameterReferenceOperation: v2 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'v2')

        Next (Regular) Block[B5]
            Entering: {R3}

    .locals {R3}
    {
        CaptureIds: [4]
        Block[B5] - Block
            Predecessors: [B3] [B4]
            Statements (1)
                IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'v3')
                  Value: 
                    IParameterReferenceOperation: v3 (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'v3')

            Jump if True (Regular) to Block[B7]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'v3')
                  Operand: 
                    IFlowCaptureReferenceOperation: 4 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'v3')
                Leaving: {R3}

            Next (Regular) Block[B6]
        Block[B6] - Block
            Predecessors: [B5]
            Statements (1)
                IFlowCaptureOperation: 5 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'v3')
                  Value: 
                    IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsImplicit) (Syntax: 'v3')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 4 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'v3')
                      Arguments(0)

            Next (Regular) Block[B8]
                Leaving: {R3}
    }

    Block[B7] - Block
        Predecessors: [B5]
        Statements (1)
            IFlowCaptureOperation: 5 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'v4')
              Value: 
                IParameterReferenceOperation: v4 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'v4')

        Next (Regular) Block[B8]
    Block[B8] - Block
        Predecessors: [B6] [B7]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'a1 = new in ... v3 ?? v4 };')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32[]) (Syntax: 'a1 = new in ...  v3 ?? v4 }')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32[], IsImplicit) (Syntax: 'a1')
                  Right: 
                    IArrayCreationOperation (OperationKind.ArrayCreation, Type: System.Int32[]) (Syntax: 'new int[c1] ...  v3 ?? v4 }')
                      Dimension Sizes(1):
                          IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32, Constant: 2, IsImplicit) (Syntax: 'c1')
                      Initializer: 
                        IArrayInitializerOperation (2 elements) (OperationKind.ArrayInitializer, Type: null) (Syntax: '{ v1 ?? v2, v3 ?? v4 }')
                          Element Values(2):
                              IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'v1 ?? v2')
                              IFlowCaptureReferenceOperation: 5 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'v3 ?? v4')

        Next (Regular) Block[B9]
            Leaving: {R1}
}

Block[B9] - Exit
    Predecessors: [B8]
    Statements (0)
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 118724, 118777);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 118793, 118891);

                f_22002_118793_118890(source, expectedFlowGraph, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22002, 112024, 118902);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22002, 112024, 118902);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22002, 112024, 118902);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ArrayCreationAndInitializer_ControlFlowInMultipleInitializerValues_MultiDimArray()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22002, 118914, 126725);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 119128, 119356);

                string
                source = @"
class C
{
    const int c1 = 2, c2 = 1;
    void M(int[,] a1, int? v1, int v2, int? v3, int v4)
    /*<bind>*/
    {
        a1 = new int[c1, c2] { { v1 ?? v2 }, { v3 ?? v4 } };
    }/*</bind>*/
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 119370, 126533);

                string
                expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [1] [2] [4] [6]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (3)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a1')
              Value: 
                IParameterReferenceOperation: a1 (OperationKind.ParameterReference, Type: System.Int32[,]) (Syntax: 'a1')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c1')
              Value: 
                IFieldReferenceOperation: System.Int32 C.c1 (Static) (OperationKind.FieldReference, Type: System.Int32, Constant: 2) (Syntax: 'c1')
                  Instance Receiver: 
                    null

            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c2')
              Value: 
                IFieldReferenceOperation: System.Int32 C.c2 (Static) (OperationKind.FieldReference, Type: System.Int32, Constant: 1) (Syntax: 'c2')
                  Instance Receiver: 
                    null

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [3]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'v1')
                  Value: 
                    IParameterReferenceOperation: v1 (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'v1')

            Jump if True (Regular) to Block[B4]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'v1')
                  Operand: 
                    IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'v1')
                Leaving: {R2}

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'v1')
                  Value: 
                    IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsImplicit) (Syntax: 'v1')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'v1')
                      Arguments(0)

            Next (Regular) Block[B5]
                Leaving: {R2}
                Entering: {R3}
    }

    Block[B4] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'v2')
              Value: 
                IParameterReferenceOperation: v2 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'v2')

        Next (Regular) Block[B5]
            Entering: {R3}

    .locals {R3}
    {
        CaptureIds: [5]
        Block[B5] - Block
            Predecessors: [B3] [B4]
            Statements (1)
                IFlowCaptureOperation: 5 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'v3')
                  Value: 
                    IParameterReferenceOperation: v3 (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'v3')

            Jump if True (Regular) to Block[B7]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'v3')
                  Operand: 
                    IFlowCaptureReferenceOperation: 5 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'v3')
                Leaving: {R3}

            Next (Regular) Block[B6]
        Block[B6] - Block
            Predecessors: [B5]
            Statements (1)
                IFlowCaptureOperation: 6 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'v3')
                  Value: 
                    IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsImplicit) (Syntax: 'v3')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 5 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'v3')
                      Arguments(0)

            Next (Regular) Block[B8]
                Leaving: {R3}
    }

    Block[B7] - Block
        Predecessors: [B5]
        Statements (1)
            IFlowCaptureOperation: 6 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'v4')
              Value: 
                IParameterReferenceOperation: v4 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'v4')

        Next (Regular) Block[B8]
    Block[B8] - Block
        Predecessors: [B6] [B7]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'a1 = new in ...  ?? v4 } };')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32[,]) (Syntax: 'a1 = new in ... 3 ?? v4 } }')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32[,], IsImplicit) (Syntax: 'a1')
                  Right: 
                    IArrayCreationOperation (OperationKind.ArrayCreation, Type: System.Int32[,]) (Syntax: 'new int[c1, ... 3 ?? v4 } }')
                      Dimension Sizes(2):
                          IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32, Constant: 2, IsImplicit) (Syntax: 'c1')
                          IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, Constant: 1, IsImplicit) (Syntax: 'c2')
                      Initializer: 
                        IArrayInitializerOperation (2 elements) (OperationKind.ArrayInitializer, Type: null) (Syntax: '{ { v1 ?? v ... 3 ?? v4 } }')
                          Element Values(2):
                              IArrayInitializerOperation (1 elements) (OperationKind.ArrayInitializer, Type: null) (Syntax: '{ v1 ?? v2 }')
                                Element Values(1):
                                    IFlowCaptureReferenceOperation: 4 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'v1 ?? v2')
                              IArrayInitializerOperation (1 elements) (OperationKind.ArrayInitializer, Type: null) (Syntax: '{ v3 ?? v4 }')
                                Element Values(1):
                                    IFlowCaptureReferenceOperation: 6 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'v3 ?? v4')

        Next (Regular) Block[B9]
            Leaving: {R1}
}

Block[B9] - Exit
    Predecessors: [B8]
    Statements (0)
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 126547, 126600);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 126616, 126714);

                f_22002_126616_126713(source, expectedFlowGraph, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22002, 118914, 126725);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22002, 118914, 126725);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22002, 118914, 126725);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ArrayCreationAndInitializer_ControlFlowInDimensionAndMultipleInitializerValues_SingleDimArray()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22002, 126737, 135604);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 126964, 127171);

                string
                source = @"
class C
{
    void M(int[] a1, int? v1, int v2, int? v3, int v4, int? d1, int d2)
    /*<bind>*/
    {
        a1 = new int[d1 ?? d2] { v1 ?? v2, v3 ?? v4 };
    }/*</bind>*/
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 127185, 135149);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a1')
              Value: 
                IParameterReferenceOperation: a1 (OperationKind.ParameterReference, Type: System.Int32[]) (Syntax: 'a1')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'd1')
                  Value: 
                    IParameterReferenceOperation: d1 (OperationKind.ParameterReference, Type: System.Int32?, IsInvalid) (Syntax: 'd1')

            Jump if True (Regular) to Block[B4]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsInvalid, IsImplicit) (Syntax: 'd1')
                  Operand: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsInvalid, IsImplicit) (Syntax: 'd1')
                Leaving: {R2}

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'd1')
                  Value: 
                    IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'd1')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsInvalid, IsImplicit) (Syntax: 'd1')
                      Arguments(0)

            Next (Regular) Block[B5]
                Leaving: {R2}
                Entering: {R3}
    }

    Block[B4] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'd2')
              Value: 
                IParameterReferenceOperation: d2 (OperationKind.ParameterReference, Type: System.Int32, IsInvalid) (Syntax: 'd2')

        Next (Regular) Block[B5]
            Entering: {R3}

    .locals {R3}
    {
        CaptureIds: [3]
        Block[B5] - Block
            Predecessors: [B3] [B4]
            Statements (1)
                IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'v1')
                  Value: 
                    IParameterReferenceOperation: v1 (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'v1')

            Jump if True (Regular) to Block[B7]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'v1')
                  Operand: 
                    IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'v1')
                Leaving: {R3}

            Next (Regular) Block[B6]
        Block[B6] - Block
            Predecessors: [B5]
            Statements (1)
                IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'v1')
                  Value: 
                    IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsImplicit) (Syntax: 'v1')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'v1')
                      Arguments(0)

            Next (Regular) Block[B8]
                Leaving: {R3}
                Entering: {R4}
    }

    Block[B7] - Block
        Predecessors: [B5]
        Statements (1)
            IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'v2')
              Value: 
                IParameterReferenceOperation: v2 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'v2')

        Next (Regular) Block[B8]
            Entering: {R4}

    .locals {R4}
    {
        CaptureIds: [5]
        Block[B8] - Block
            Predecessors: [B6] [B7]
            Statements (1)
                IFlowCaptureOperation: 5 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'v3')
                  Value: 
                    IParameterReferenceOperation: v3 (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'v3')

            Jump if True (Regular) to Block[B10]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'v3')
                  Operand: 
                    IFlowCaptureReferenceOperation: 5 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'v3')
                Leaving: {R4}

            Next (Regular) Block[B9]
        Block[B9] - Block
            Predecessors: [B8]
            Statements (1)
                IFlowCaptureOperation: 6 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'v3')
                  Value: 
                    IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsImplicit) (Syntax: 'v3')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 5 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'v3')
                      Arguments(0)

            Next (Regular) Block[B11]
                Leaving: {R4}
    }

    Block[B10] - Block
        Predecessors: [B8]
        Statements (1)
            IFlowCaptureOperation: 6 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'v4')
              Value: 
                IParameterReferenceOperation: v4 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'v4')

        Next (Regular) Block[B11]
    Block[B11] - Block
        Predecessors: [B9] [B10]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: 'a1 = new in ... v3 ?? v4 };')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32[], IsInvalid) (Syntax: 'a1 = new in ...  v3 ?? v4 }')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32[], IsImplicit) (Syntax: 'a1')
                  Right: 
                    IArrayCreationOperation (OperationKind.ArrayCreation, Type: System.Int32[], IsInvalid) (Syntax: 'new int[d1  ...  v3 ?? v4 }')
                      Dimension Sizes(1):
                          IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'd1 ?? d2')
                      Initializer: 
                        IArrayInitializerOperation (2 elements) (OperationKind.ArrayInitializer, Type: null) (Syntax: '{ v1 ?? v2, v3 ?? v4 }')
                          Element Values(2):
                              IFlowCaptureReferenceOperation: 4 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'v1 ?? v2')
                              IFlowCaptureReferenceOperation: 6 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'v3 ?? v4')

        Next (Regular) Block[B12]
            Leaving: {R1}
}

Block[B12] - Exit
    Predecessors: [B11]
    Statements (0)
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 135163, 135479);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22002_135389_135463(f_22002_135389_135443(ErrorCode.ERR_ConstantExpected, "d1 ?? d2"), 7, 22)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 135495, 135593);

                f_22002_135495_135592(source, expectedFlowGraph, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22002, 126737, 135604);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22002, 126737, 135604);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22002, 126737, 135604);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ArrayCreationAndInitializer_ControlFlowInMultipleDimensionsAndInitializerValues_MultiDimArray()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22002, 135616, 147413);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 135843, 136086);

                string
                source = @"
class C
{
    void M(int[,] a1, int? v1, int v2, int? v3, int v4, int? d1, int d2, int? d3, int d4)
    /*<bind>*/
    {
        a1 = new int[d1 ?? d2, d3 ?? d4] { { v1 ?? v2 }, { v3 ?? v4 } };
    }/*</bind>*/
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 136100, 146660);

                string
                expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [2] [4] [6] [8]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a1')
              Value: 
                IParameterReferenceOperation: a1 (OperationKind.ParameterReference, Type: System.Int32[,]) (Syntax: 'a1')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'd1')
                  Value: 
                    IParameterReferenceOperation: d1 (OperationKind.ParameterReference, Type: System.Int32?, IsInvalid) (Syntax: 'd1')

            Jump if True (Regular) to Block[B4]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsInvalid, IsImplicit) (Syntax: 'd1')
                  Operand: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsInvalid, IsImplicit) (Syntax: 'd1')
                Leaving: {R2}

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'd1')
                  Value: 
                    IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'd1')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsInvalid, IsImplicit) (Syntax: 'd1')
                      Arguments(0)

            Next (Regular) Block[B5]
                Leaving: {R2}
                Entering: {R3}
    }

    Block[B4] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'd2')
              Value: 
                IParameterReferenceOperation: d2 (OperationKind.ParameterReference, Type: System.Int32, IsInvalid) (Syntax: 'd2')

        Next (Regular) Block[B5]
            Entering: {R3}

    .locals {R3}
    {
        CaptureIds: [3]
        Block[B5] - Block
            Predecessors: [B3] [B4]
            Statements (1)
                IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'd3')
                  Value: 
                    IParameterReferenceOperation: d3 (OperationKind.ParameterReference, Type: System.Int32?, IsInvalid) (Syntax: 'd3')

            Jump if True (Regular) to Block[B7]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsInvalid, IsImplicit) (Syntax: 'd3')
                  Operand: 
                    IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsInvalid, IsImplicit) (Syntax: 'd3')
                Leaving: {R3}

            Next (Regular) Block[B6]
        Block[B6] - Block
            Predecessors: [B5]
            Statements (1)
                IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'd3')
                  Value: 
                    IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'd3')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsInvalid, IsImplicit) (Syntax: 'd3')
                      Arguments(0)

            Next (Regular) Block[B8]
                Leaving: {R3}
                Entering: {R4}
    }

    Block[B7] - Block
        Predecessors: [B5]
        Statements (1)
            IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'd4')
              Value: 
                IParameterReferenceOperation: d4 (OperationKind.ParameterReference, Type: System.Int32, IsInvalid) (Syntax: 'd4')

        Next (Regular) Block[B8]
            Entering: {R4}

    .locals {R4}
    {
        CaptureIds: [5]
        Block[B8] - Block
            Predecessors: [B6] [B7]
            Statements (1)
                IFlowCaptureOperation: 5 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'v1')
                  Value: 
                    IParameterReferenceOperation: v1 (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'v1')

            Jump if True (Regular) to Block[B10]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'v1')
                  Operand: 
                    IFlowCaptureReferenceOperation: 5 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'v1')
                Leaving: {R4}

            Next (Regular) Block[B9]
        Block[B9] - Block
            Predecessors: [B8]
            Statements (1)
                IFlowCaptureOperation: 6 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'v1')
                  Value: 
                    IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsImplicit) (Syntax: 'v1')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 5 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'v1')
                      Arguments(0)

            Next (Regular) Block[B11]
                Leaving: {R4}
                Entering: {R5}
    }

    Block[B10] - Block
        Predecessors: [B8]
        Statements (1)
            IFlowCaptureOperation: 6 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'v2')
              Value: 
                IParameterReferenceOperation: v2 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'v2')

        Next (Regular) Block[B11]
            Entering: {R5}

    .locals {R5}
    {
        CaptureIds: [7]
        Block[B11] - Block
            Predecessors: [B9] [B10]
            Statements (1)
                IFlowCaptureOperation: 7 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'v3')
                  Value: 
                    IParameterReferenceOperation: v3 (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'v3')

            Jump if True (Regular) to Block[B13]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'v3')
                  Operand: 
                    IFlowCaptureReferenceOperation: 7 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'v3')
                Leaving: {R5}

            Next (Regular) Block[B12]
        Block[B12] - Block
            Predecessors: [B11]
            Statements (1)
                IFlowCaptureOperation: 8 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'v3')
                  Value: 
                    IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsImplicit) (Syntax: 'v3')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 7 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'v3')
                      Arguments(0)

            Next (Regular) Block[B14]
                Leaving: {R5}
    }

    Block[B13] - Block
        Predecessors: [B11]
        Statements (1)
            IFlowCaptureOperation: 8 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'v4')
              Value: 
                IParameterReferenceOperation: v4 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'v4')

        Next (Regular) Block[B14]
    Block[B14] - Block
        Predecessors: [B12] [B13]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: 'a1 = new in ...  ?? v4 } };')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32[,], IsInvalid) (Syntax: 'a1 = new in ... 3 ?? v4 } }')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32[,], IsImplicit) (Syntax: 'a1')
                  Right: 
                    IArrayCreationOperation (OperationKind.ArrayCreation, Type: System.Int32[,], IsInvalid) (Syntax: 'new int[d1  ... 3 ?? v4 } }')
                      Dimension Sizes(2):
                          IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'd1 ?? d2')
                          IFlowCaptureReferenceOperation: 4 (OperationKind.FlowCaptureReference, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'd3 ?? d4')
                      Initializer: 
                        IArrayInitializerOperation (2 elements) (OperationKind.ArrayInitializer, Type: null) (Syntax: '{ { v1 ?? v ... 3 ?? v4 } }')
                          Element Values(2):
                              IArrayInitializerOperation (1 elements) (OperationKind.ArrayInitializer, Type: null) (Syntax: '{ v1 ?? v2 }')
                                Element Values(1):
                                    IFlowCaptureReferenceOperation: 6 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'v1 ?? v2')
                              IArrayInitializerOperation (1 elements) (OperationKind.ArrayInitializer, Type: null) (Syntax: '{ v3 ?? v4 }')
                                Element Values(1):
                                    IFlowCaptureReferenceOperation: 8 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'v3 ?? v4')

        Next (Regular) Block[B15]
            Leaving: {R1}
}

Block[B15] - Exit
    Predecessors: [B14]
    Statements (0)
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 146674, 147288);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22002_146934_147008(f_22002_146934_146988(ErrorCode.ERR_ConstantExpected, "d1 ?? d2"), 7, 22),
f_22002_147198_147272(f_22002_147198_147252(ErrorCode.ERR_ConstantExpected, "d3 ?? d4"), 7, 32)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22002, 147304, 147402);

                f_22002_147304_147401(source, expectedFlowGraph, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22002, 135616, 147413);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22002, 135616, 147413);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22002, 135616, 147413);
            }
        }

        int
        f_22002_1164_1287(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<ArrayCreationExpressionSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22002, 1164, 1287);
            return 0;
        }


        int
        f_22002_1969_2092(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<ArrayCreationExpressionSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22002, 1969, 2092);
            return 0;
        }


        int
        f_22002_2859_2982(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<ArrayCreationExpressionSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22002, 2859, 2982);
            return 0;
        }


        int
        f_22002_3726_3849(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<ArrayCreationExpressionSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22002, 3726, 3849);
            return 0;
        }


        int
        f_22002_4916_5039(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<ArrayCreationExpressionSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22002, 4916, 5039);
            return 0;
        }


        int
        f_22002_6114_6237(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<ArrayCreationExpressionSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22002, 6114, 6237);
            return 0;
        }


        int
        f_22002_7346_7469(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<ArrayCreationExpressionSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22002, 7346, 7469);
            return 0;
        }


        int
        f_22002_8562_8685(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<ArrayCreationExpressionSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22002, 8562, 8685);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22002_9997_10074(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22002, 9997, 10074);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22002_9997_10093(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22002, 9997, 10093);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22002_9997_10113(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22002, 9997, 10113);
            return return_v;
        }


        int
        f_22002_10145_10268(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<ArrayCreationExpressionSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22002, 10145, 10268);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22002_11610_11665(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22002, 11610, 11665);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22002_11610_11685(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22002, 11610, 11685);
            return return_v;
        }


        int
        f_22002_11717_11840(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<ArrayCreationExpressionSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22002, 11717, 11840);
            return 0;
        }


        int
        f_22002_13621_13746(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<LocalDeclarationStatementSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22002, 13621, 13746);
            return 0;
        }


        int
        f_22002_14813_14936(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<ArrayCreationExpressionSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22002, 14813, 14936);
            return 0;
        }


        int
        f_22002_15997_16128(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<ImplicitArrayCreationExpressionSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22002, 15997, 16128);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22002_17146_17191(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22002, 17146, 17191);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22002_17146_17211(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22002, 17146, 17211);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22002_17333_17378(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22002, 17333, 17378);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22002_17333_17398(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22002, 17333, 17398);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22002_17555_17631(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22002, 17555, 17631);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22002_17555_17651(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22002, 17555, 17651);
            return return_v;
        }


        int
        f_22002_17683_17814(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<ImplicitArrayCreationExpressionSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22002, 17683, 17814);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22002_18878_18921(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22002, 18878, 18921);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22002_18878_18941(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22002, 18878, 18941);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22002_19085_19130(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22002, 19085, 19130);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22002_19085_19150(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22002, 19085, 19150);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22002_19294_19339(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22002, 19294, 19339);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22002_19294_19359(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22002, 19294, 19359);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22002_19538_19615(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22002, 19538, 19615);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22002_19538_19635(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22002, 19538, 19635);
            return return_v;
        }


        int
        f_22002_19667_19798(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<ImplicitArrayCreationExpressionSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22002, 19667, 19798);
            return 0;
        }


        int
        f_22002_21405_21536(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<ImplicitArrayCreationExpressionSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22002, 21405, 21536);
            return 0;
        }


        int
        f_22002_22422_22545(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<ArrayCreationExpressionSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22002, 22422, 22545);
            return 0;
        }


        int
        f_22002_27253_27376(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<ArrayCreationExpressionSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22002, 27253, 27376);
            return 0;
        }


        int
        f_22002_29400_29523(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<ArrayCreationExpressionSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22002, 29400, 29523);
            return 0;
        }


        int
        f_22002_30221_30344(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<ArrayCreationExpressionSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22002, 30221, 30344);
            return 0;
        }


        int
        f_22002_34084_34215(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<ImplicitArrayCreationExpressionSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22002, 34084, 34215);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22002_34980_35028(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22002, 34980, 35028);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22002_34980_35048(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22002, 34980, 35048);
            return return_v;
        }


        int
        f_22002_35080_35203(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<ArrayCreationExpressionSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22002, 35080, 35203);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22002_36693_36738(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22002, 36693, 36738);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22002_36693_36769(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22002, 36693, 36769);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22002_36693_36789(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22002, 36693, 36789);
            return return_v;
        }


        int
        f_22002_36821_36944(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<ArrayCreationExpressionSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22002, 36821, 36944);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22002_38230_38279(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22002, 38230, 38279);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22002_38230_38310(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22002, 38230, 38310);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22002_38230_38330(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22002, 38230, 38330);
            return return_v;
        }


        int
        f_22002_38362_38485(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<ArrayCreationExpressionSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22002, 38362, 38485);
            return 0;
        }


        int
        f_22002_39432_39555(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<ArrayCreationExpressionSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22002, 39432, 39555);
            return 0;
        }


        int
        f_22002_40846_40969(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<ArrayCreationExpressionSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22002, 40846, 40969);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22002_42399_42450(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22002, 42399, 42450);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22002_42399_42481(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22002, 42399, 42481);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22002_42399_42501(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22002, 42399, 42501);
            return return_v;
        }


        int
        f_22002_42533_42656(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<ArrayCreationExpressionSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22002, 42533, 42656);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22002_44119_44171(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22002, 44119, 44171);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22002_44119_44197(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22002, 44119, 44197);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22002_44119_44217(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22002, 44119, 44217);
            return return_v;
        }


        int
        f_22002_44249_44372(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<ArrayCreationExpressionSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22002, 44249, 44372);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22002_45654_45705(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22002, 45654, 45705);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22002_45654_45736(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22002, 45654, 45736);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22002_45654_45756(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22002, 45654, 45756);
            return return_v;
        }


        int
        f_22002_45788_45911(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<ArrayCreationExpressionSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22002, 45788, 45911);
            return 0;
        }


        int
        f_22002_56299_56396(string
        testSrc, string
        expectedFlowGraph, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>(testSrc, expectedFlowGraph, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22002, 56299, 56396);
            return 0;
        }


        int
        f_22002_60513_60610(string
        testSrc, string
        expectedFlowGraph, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>(testSrc, expectedFlowGraph, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22002, 60513, 60610);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22002_65651_65705(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22002, 65651, 65705);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22002_65651_65725(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22002, 65651, 65725);
            return return_v;
        }


        int
        f_22002_65757_65854(string
        testSrc, string
        expectedFlowGraph, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>(testSrc, expectedFlowGraph, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22002, 65757, 65854);
            return 0;
        }


        int
        f_22002_70239_70336(string
        testSrc, string
        expectedFlowGraph, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>(testSrc, expectedFlowGraph, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22002, 70239, 70336);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22002_75638_75692(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22002, 75638, 75692);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22002_75638_75712(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22002, 75638, 75712);
            return return_v;
        }


        int
        f_22002_75744_75841(string
        testSrc, string
        expectedFlowGraph, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>(testSrc, expectedFlowGraph, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22002, 75744, 75841);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22002_82831_82885(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22002, 82831, 82885);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22002_82831_82905(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22002, 82831, 82905);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22002_83075_83129(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22002, 83075, 83129);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22002_83075_83149(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22002, 83075, 83149);
            return return_v;
        }


        int
        f_22002_83181_83278(string
        testSrc, string
        expectedFlowGraph, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>(testSrc, expectedFlowGraph, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22002, 83181, 83278);
            return 0;
        }


        int
        f_22002_88108_88205(string
        testSrc, string
        expectedFlowGraph, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>(testSrc, expectedFlowGraph, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22002, 88108, 88205);
            return 0;
        }


        int
        f_22002_93965_94062(string
        testSrc, string
        expectedFlowGraph, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>(testSrc, expectedFlowGraph, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22002, 93965, 94062);
            return 0;
        }


        int
        f_22002_99162_99259(string
        testSrc, string
        expectedFlowGraph, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>(testSrc, expectedFlowGraph, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22002, 99162, 99259);
            return 0;
        }


        int
        f_22002_105289_105386(string
        testSrc, string
        expectedFlowGraph, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>(testSrc, expectedFlowGraph, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22002, 105289, 105386);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22002_111795_111851(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22002, 111795, 111851);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22002_111795_111871(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22002, 111795, 111871);
            return return_v;
        }


        int
        f_22002_111903_112000(string
        testSrc, string
        expectedFlowGraph, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>(testSrc, expectedFlowGraph, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22002, 111903, 112000);
            return 0;
        }


        int
        f_22002_118793_118890(string
        testSrc, string
        expectedFlowGraph, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>(testSrc, expectedFlowGraph, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22002, 118793, 118890);
            return 0;
        }


        int
        f_22002_126616_126713(string
        testSrc, string
        expectedFlowGraph, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>(testSrc, expectedFlowGraph, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22002, 126616, 126713);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22002_135389_135443(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22002, 135389, 135443);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22002_135389_135463(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22002, 135389, 135463);
            return return_v;
        }


        int
        f_22002_135495_135592(string
        testSrc, string
        expectedFlowGraph, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>(testSrc, expectedFlowGraph, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22002, 135495, 135592);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22002_146934_146988(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22002, 146934, 146988);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22002_146934_147008(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22002, 146934, 147008);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22002_147198_147252(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22002, 147198, 147252);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22002_147198_147272(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22002, 147198, 147272);
            return return_v;
        }


        int
        f_22002_147304_147401(string
        testSrc, string
        expectedFlowGraph, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>(testSrc, expectedFlowGraph, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22002, 147304, 147401);
            return 0;
        }

    }
}
