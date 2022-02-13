// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Operations;
using Microsoft.CodeAnalysis.Test.Utilities;
using Xunit;

namespace Microsoft.CodeAnalysis.CSharp.UnitTests
{
    public partial class IOperationTests : SemanticModelTestBase
    {
        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ICompoundAssignment_NullArgumentToGetConversionThrows()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22016, 594, 1044);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22016, 755, 806);

                ICompoundAssignmentOperation
                nullAssignment = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22016, 820, 919);

                f_22016_820_918("compoundAssignment", () => nullAssignment.GetInConversion());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22016, 933, 1033);

                f_22016_933_1032("compoundAssignment", () => nullAssignment.GetOutConversion());
                DynAbs.Tracing.TraceSender.TraceExitMethod(22016, 594, 1044);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22016, 594, 1044);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22016, 594, 1044);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ICompoundAssignment_GetConversionOnValidNode_IdentityConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22016, 1056, 1874);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22016, 1227, 1364);

                string
                source = @"
class C
{
    static void M()
    {
        int x = 1, y = 1;
        /*<bind>*/x += y/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22016, 1380, 1411);

                var
                syntaxTree = f_22016_1397_1410(source)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22016, 1425, 1497);

                var
                compilation = f_22016_1443_1496(new[] { syntaxTree })
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22016, 1511, 1609);

                (IOperation operation, _) = f_22016_1539_1608(compilation);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22016, 1623, 1688);

                var
                compoundAssignment = (ICompoundAssignmentOperation)operation
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22016, 1704, 1776);

                f_22016_1704_1775(Conversion.Identity, f_22016_1738_1774(compoundAssignment));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22016, 1790, 1863);

                f_22016_1790_1862(Conversion.Identity, f_22016_1824_1861(compoundAssignment));
                DynAbs.Tracing.TraceSender.TraceExitMethod(22016, 1056, 1874);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22016, 1056, 1874);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22016, 1056, 1874);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ICompoundAssignment_GetConversionOnValidNode_InOutConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22016, 1886, 3466);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22016, 2054, 2377);

                string
                source = @"
class C
{
    static void M()
    {
        var c = new C();
        var x = 1;
        /*<bind>*/c += x/*</bind>*/;
    }

    public static implicit operator C(int i)
    {
        return null;
    }

    public static implicit operator int(C c)
    {
        return 0;
    }
}

"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22016, 2393, 2424);

                var
                syntaxTree = f_22016_2410_2423(source)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22016, 2438, 2510);

                var
                compilation = f_22016_2456_2509(new[] { syntaxTree })
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22016, 2524, 2636);

                (IOperation operation, SyntaxNode node) = f_22016_2566_2635(compilation);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22016, 2650, 2715);

                var
                compoundAssignment = (ICompoundAssignmentOperation)operation
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22016, 2731, 2787);

                var
                typeSymbol = f_22016_2748_2786(compilation, "C")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22016, 2801, 2881);

                // LAFHIS
                var temp = f_22016_2823_2859(typeSymbol, "op_Implicit");
                var
                implicitSymbols = f_22016_2823_2880(ref temp)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22016, 2895, 3004);

                var
                inSymbol = f_22016_2910_3003(f_22016_2910_2994(implicitSymbols, sym => sym.ReturnType.SpecialType == SpecialType.System_Int32))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22016, 3018, 3089);

                var
                outSymbol = f_22016_3034_3088(f_22016_3034_3079(implicitSymbols, sym => sym != inSymbol))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22016, 3103, 3190);

                var
                inConversion = f_22016_3122_3189(ConversionKind.ImplicitUserDefined, inSymbol, false)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22016, 3204, 3293);

                var
                outConversion = f_22016_3224_3292(ConversionKind.ImplicitUserDefined, outSymbol, false)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22016, 3309, 3374);

                f_22016_3309_3373(inConversion, f_22016_3336_3372(compoundAssignment));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22016, 3388, 3455);

                f_22016_3388_3454(outConversion, f_22016_3416_3453(compoundAssignment));
                DynAbs.Tracing.TraceSender.TraceExitMethod(22016, 1886, 3466);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22016, 1886, 3466);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22016, 1886, 3466);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ICompoundAssignment_BinaryOperatorInOutConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22016, 3478, 4897);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22016, 3635, 3956);

                string
                source = @"
class C
{
    static void M()
    {
        var c = new C();
        var x = 1;
        /*<bind>*/c += x/*</bind>*/;
    }

    public static implicit operator C(int i)
    {
        return null;
    }

    public static implicit operator int(C c)
    {
        return 0;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22016, 3970, 4682);

                string
                expectedOperationTree = @"
ICompoundAssignmentOperation (BinaryOperatorKind.Add) (OperationKind.CompoundAssignment, Type: C) (Syntax: 'c += x')
  InConversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: True) (MethodSymbol: System.Int32 C.op_Implicit(C c))
  OutConversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: True) (MethodSymbol: C C.op_Implicit(System.Int32 i))
  Left: 
    ILocalReferenceOperation: c (OperationKind.LocalReference, Type: C) (Syntax: 'c')
  Right: 
    ILocalReferenceOperation: x (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'x')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22016, 4696, 4749);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22016, 4765, 4886);

                f_22016_4765_4885(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22016, 3478, 4897);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22016, 3478, 4897);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22016, 3478, 4897);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ICompoundAssignment_BinaryOperatorInConversion_InvalidMissingOutConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22016, 4909, 6538);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22016, 5091, 5328);

                string
                source = @"
class C
{
    static void M()
    {
        var c = new C();
        var x = 1;
        /*<bind>*/c += x/*</bind>*/;
    }

    public static implicit operator int(C c)
    {
        return 0;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22016, 5342, 6062);

                string
                expectedOperationTree = @"
ICompoundAssignmentOperation (BinaryOperatorKind.Add) (OperationKind.CompoundAssignment, Type: C, IsInvalid) (Syntax: 'c += x')
  InConversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: True) (MethodSymbol: System.Int32 C.op_Implicit(C c))
  OutConversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
  Left: 
    ILocalReferenceOperation: c (OperationKind.LocalReference, Type: C, IsInvalid) (Syntax: 'c')
  Right: 
    ILocalReferenceOperation: x (OperationKind.LocalReference, Type: System.Int32, IsInvalid) (Syntax: 'x')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22016, 6076, 6390);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22016_6278_6374(f_22016_6278_6354(f_22016_6278_6328(ErrorCode.ERR_NoImplicitConv, "c += x"), "int", "C"), 8, 19)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22016, 6406, 6527);

                f_22016_6406_6526(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22016, 4909, 6538);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22016, 4909, 6538);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22016, 4909, 6538);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ICompoundAssignment_BinaryOperatorOutConversion_InvalidMissingInConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22016, 6550, 8184);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22016, 6732, 6972);

                string
                source = @"
class C
{
    static void M()
    {
        var c = new C();
        var x = 1;
        /*<bind>*/c += x/*</bind>*/;
    }

    public static implicit operator C(int i)
    {
        return null;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22016, 6986, 7682);

                string
                expectedOperationTree = @"
ICompoundAssignmentOperation (BinaryOperatorKind.None) (OperationKind.CompoundAssignment, Type: ?, IsInvalid) (Syntax: 'c += x')
  InConversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
  OutConversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
  Left: 
    ILocalReferenceOperation: c (OperationKind.LocalReference, Type: C, IsInvalid) (Syntax: 'c')
  Right: 
    ILocalReferenceOperation: x (OperationKind.LocalReference, Type: System.Int32, IsInvalid) (Syntax: 'x')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22016, 7696, 8036);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22016_7920_8020(f_22016_7920_8000(f_22016_7920_7968(ErrorCode.ERR_BadBinaryOps, "c += x"), "+=", "C", "int"), 8, 19)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22016, 8052, 8173);

                f_22016_8052_8172(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22016, 6550, 8184);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22016, 6550, 8184);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22016, 6550, 8184);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ICompoundAssignment_UserDefinedBinaryOperator_InConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22016, 8196, 10102);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22016, 8362, 8767);

                string
                source = @"
class C
{
    static void M()
    {
        var c = new C();
        var x = 1;
        /*<bind>*/c += x/*</bind>*/;
    }

    public static implicit operator C(int i)
    {
        return null;
    }

    public static implicit operator int(C c)
    {
        return 0;
    }

    public static C operator +(int c1, C c2)
    {
        return null;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22016, 8781, 9887);

                string
                expectedOperationTree = @"
ICompoundAssignmentOperation (BinaryOperatorKind.Add) (OperatorMethod: C C.op_Addition(System.Int32 c1, C c2)) (OperationKind.CompoundAssignment, Type: C) (Syntax: 'c += x')
  InConversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: True) (MethodSymbol: System.Int32 C.op_Implicit(C c))
  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
  Left: 
    ILocalReferenceOperation: c (OperationKind.LocalReference, Type: C) (Syntax: 'c')
  Right: 
    IConversionOperation (TryCast: False, Unchecked) (OperatorMethod: C C.op_Implicit(System.Int32 i)) (OperationKind.Conversion, Type: C, IsImplicit) (Syntax: 'x')
      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: True) (MethodSymbol: C C.op_Implicit(System.Int32 i))
      Operand: 
        ILocalReferenceOperation: x (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'x')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22016, 9901, 9954);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22016, 9970, 10091);

                f_22016_9970_10090(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22016, 8196, 10102);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22016, 8196, 10102);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22016, 8196, 10102);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ICompoundAssignment_UserDefinedBinaryOperator_OutConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22016, 10114, 12018);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22016, 10281, 10683);

                string
                source = @"
class C
{
    static void M()
    {
        var c = new C();
        var x = 1;
        /*<bind>*/c += x/*</bind>*/;
    }

    public static implicit operator C(int i)
    {
        return null;
    }

    public static implicit operator int(C c)
    {
        return 0;
    }

    public static int operator +(C c1, C c2)
    {
        return 0;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22016, 10697, 11803);

                string
                expectedOperationTree = @"
ICompoundAssignmentOperation (BinaryOperatorKind.Add) (OperatorMethod: System.Int32 C.op_Addition(C c1, C c2)) (OperationKind.CompoundAssignment, Type: C) (Syntax: 'c += x')
  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
  OutConversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: True) (MethodSymbol: C C.op_Implicit(System.Int32 i))
  Left: 
    ILocalReferenceOperation: c (OperationKind.LocalReference, Type: C) (Syntax: 'c')
  Right: 
    IConversionOperation (TryCast: False, Unchecked) (OperatorMethod: C C.op_Implicit(System.Int32 i)) (OperationKind.Conversion, Type: C, IsImplicit) (Syntax: 'x')
      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: True) (MethodSymbol: C C.op_Implicit(System.Int32 i))
      Operand: 
        ILocalReferenceOperation: x (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'x')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22016, 11817, 11870);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22016, 11886, 12007);

                f_22016_11886_12006(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22016, 10114, 12018);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22016, 10114, 12018);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22016, 10114, 12018);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ICompoundAssignment_UserDefinedBinaryOperator_InOutConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22016, 12030, 13976);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22016, 12199, 12603);

                string
                source = @"
class C
{
    static void M()
    {
        var c = new C();
        var x = 1;
        /*<bind>*/c += x/*</bind>*/;
    }

    public static implicit operator C(int i)
    {
        return null;
    }

    public static implicit operator int(C c)
    {
        return 0;
    }

    public static int operator +(int c1, C c2)
    {
        return 0;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22016, 12617, 13761);

                string
                expectedOperationTree = @"
ICompoundAssignmentOperation (BinaryOperatorKind.Add) (OperatorMethod: System.Int32 C.op_Addition(System.Int32 c1, C c2)) (OperationKind.CompoundAssignment, Type: C) (Syntax: 'c += x')
  InConversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: True) (MethodSymbol: System.Int32 C.op_Implicit(C c))
  OutConversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: True) (MethodSymbol: C C.op_Implicit(System.Int32 i))
  Left: 
    ILocalReferenceOperation: c (OperationKind.LocalReference, Type: C) (Syntax: 'c')
  Right: 
    IConversionOperation (TryCast: False, Unchecked) (OperatorMethod: C C.op_Implicit(System.Int32 i)) (OperationKind.Conversion, Type: C, IsImplicit) (Syntax: 'x')
      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: True) (MethodSymbol: C C.op_Implicit(System.Int32 i))
      Operand: 
        ILocalReferenceOperation: x (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'x')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22016, 13775, 13828);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22016, 13844, 13965);

                f_22016_13844_13964(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22016, 12030, 13976);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22016, 12030, 13976);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22016, 12030, 13976);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ICompoundAssignment_UserDefinedBinaryOperator_InvalidMissingInConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22016, 13988, 15703);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22016, 14168, 14491);

                string
                source = @"
class C
{
    static void M()
    {
        var c = new C();
        var x = 1;
        /*<bind>*/c += x/*</bind>*/;
    }

    public static implicit operator C(int i)
    {
        return null;
    }

    public static int operator +(int c1, C c2)
    {
        return 0;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22016, 14505, 15201);

                string
                expectedOperationTree = @"
ICompoundAssignmentOperation (BinaryOperatorKind.None) (OperationKind.CompoundAssignment, Type: ?, IsInvalid) (Syntax: 'c += x')
  InConversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
  OutConversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
  Left: 
    ILocalReferenceOperation: c (OperationKind.LocalReference, Type: C, IsInvalid) (Syntax: 'c')
  Right: 
    ILocalReferenceOperation: x (OperationKind.LocalReference, Type: System.Int32, IsInvalid) (Syntax: 'x')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22016, 15215, 15555);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22016_15439_15539(f_22016_15439_15519(f_22016_15439_15487(ErrorCode.ERR_BadBinaryOps, "c += x"), "+=", "C", "int"), 8, 19)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22016, 15571, 15692);

                f_22016_15571_15691(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22016, 13988, 15703);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22016, 13988, 15703);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22016, 13988, 15703);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ICompoundAssignment_UserDefinedBinaryOperator_InvalidMissingOutConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22016, 15715, 17426);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22016, 15896, 16216);

                string
                source = @"
class C
{
    static void M()
    {
        var c = new C();
        var x = 1;
        /*<bind>*/c += x/*</bind>*/;
    }

    public static implicit operator int(C c)
    {
        return 0;
    }

    public static int operator +(int c1, C c2)
    {
        return 0;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22016, 16230, 16950);

                string
                expectedOperationTree = @"
ICompoundAssignmentOperation (BinaryOperatorKind.Add) (OperationKind.CompoundAssignment, Type: C, IsInvalid) (Syntax: 'c += x')
  InConversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: True) (MethodSymbol: System.Int32 C.op_Implicit(C c))
  OutConversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
  Left: 
    ILocalReferenceOperation: c (OperationKind.LocalReference, Type: C, IsInvalid) (Syntax: 'c')
  Right: 
    ILocalReferenceOperation: x (OperationKind.LocalReference, Type: System.Int32, IsInvalid) (Syntax: 'x')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22016, 16964, 17278);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22016_17166_17262(f_22016_17166_17242(f_22016_17166_17216(ErrorCode.ERR_NoImplicitConv, "c += x"), "int", "C"), 8, 19)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22016, 17294, 17415);

                f_22016_17294_17414(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22016, 15715, 17426);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22016, 15715, 17426);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22016, 15715, 17426);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void CompoundAssignment_01()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22016, 17438, 21827);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22016, 17593, 17741);

                string
                source = @"
using System;
class C
{
    void M(int[] a, int? b, int c)
    /*<bind>*/{
        a[0] += b ?? c;
    }/*</bind>*/
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22016, 17755, 17808);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22016, 17824, 21704);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a[0]')
              Value: 
                IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: System.Int32) (Syntax: 'a[0]')
                  Array reference: 
                    IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Int32[]) (Syntax: 'a')
                  Indices(1):
                      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')

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
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'a[0] += b ?? c;')
              Expression: 
                ICompoundAssignmentOperation (BinaryOperatorKind.Add) (OperationKind.CompoundAssignment, Type: System.Int32) (Syntax: 'a[0] += b ?? c')
                  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'a[0]')
                  Right: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'b ?? c')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22016, 21718, 21816);

                f_22016_21718_21815(source, expectedFlowGraph, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22016, 17438, 21827);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22016, 17438, 21827);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22016, 17438, 21827);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void CompoundAssignment_02()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22016, 21839, 26233);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22016, 21994, 22142);

                string
                source = @"
using System;
class C
{
    void M(int[] a, int? b, int c)
    /*<bind>*/{
        a[0] -= b ?? c;
    }/*</bind>*/
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22016, 22156, 22209);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22016, 22225, 26110);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a[0]')
              Value: 
                IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: System.Int32) (Syntax: 'a[0]')
                  Array reference: 
                    IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Int32[]) (Syntax: 'a')
                  Indices(1):
                      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')

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
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'a[0] -= b ?? c;')
              Expression: 
                ICompoundAssignmentOperation (BinaryOperatorKind.Subtract) (OperationKind.CompoundAssignment, Type: System.Int32) (Syntax: 'a[0] -= b ?? c')
                  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'a[0]')
                  Right: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'b ?? c')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22016, 26124, 26222);

                f_22016_26124_26221(source, expectedFlowGraph, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22016, 21839, 26233);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22016, 21839, 26233);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22016, 21839, 26233);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void CompoundAssignment_03()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22016, 26245, 30639);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22016, 26400, 26548);

                string
                source = @"
using System;
class C
{
    void M(int[] a, int? b, int c)
    /*<bind>*/{
        a[0] *= b ?? c;
    }/*</bind>*/
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22016, 26562, 26615);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22016, 26631, 30516);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a[0]')
              Value: 
                IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: System.Int32) (Syntax: 'a[0]')
                  Array reference: 
                    IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Int32[]) (Syntax: 'a')
                  Indices(1):
                      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')

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
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'a[0] *= b ?? c;')
              Expression: 
                ICompoundAssignmentOperation (BinaryOperatorKind.Multiply) (OperationKind.CompoundAssignment, Type: System.Int32) (Syntax: 'a[0] *= b ?? c')
                  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'a[0]')
                  Right: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'b ?? c')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22016, 30530, 30628);

                f_22016_30530_30627(source, expectedFlowGraph, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22016, 26245, 30639);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22016, 26245, 30639);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22016, 26245, 30639);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void CompoundAssignment_04()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22016, 30651, 35043);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22016, 30806, 30954);

                string
                source = @"
using System;
class C
{
    void M(int[] a, int? b, int c)
    /*<bind>*/{
        a[0] /= b ?? c;
    }/*</bind>*/
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22016, 30968, 31021);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22016, 31037, 34920);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a[0]')
              Value: 
                IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: System.Int32) (Syntax: 'a[0]')
                  Array reference: 
                    IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Int32[]) (Syntax: 'a')
                  Indices(1):
                      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')

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
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'a[0] /= b ?? c;')
              Expression: 
                ICompoundAssignmentOperation (BinaryOperatorKind.Divide) (OperationKind.CompoundAssignment, Type: System.Int32) (Syntax: 'a[0] /= b ?? c')
                  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'a[0]')
                  Right: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'b ?? c')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22016, 34934, 35032);

                f_22016_34934_35031(source, expectedFlowGraph, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22016, 30651, 35043);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22016, 30651, 35043);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22016, 30651, 35043);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void CompoundAssignment_05()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22016, 35055, 39450);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22016, 35210, 35358);

                string
                source = @"
using System;
class C
{
    void M(int[] a, int? b, int c)
    /*<bind>*/{
        a[0] %= b ?? c;
    }/*</bind>*/
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22016, 35372, 35425);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22016, 35441, 39327);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a[0]')
              Value: 
                IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: System.Int32) (Syntax: 'a[0]')
                  Array reference: 
                    IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Int32[]) (Syntax: 'a')
                  Indices(1):
                      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')

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
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'a[0] %= b ?? c;')
              Expression: 
                ICompoundAssignmentOperation (BinaryOperatorKind.Remainder) (OperationKind.CompoundAssignment, Type: System.Int32) (Syntax: 'a[0] %= b ?? c')
                  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'a[0]')
                  Right: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'b ?? c')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22016, 39341, 39439);

                f_22016_39341_39438(source, expectedFlowGraph, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22016, 35055, 39450);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22016, 35055, 39450);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22016, 35055, 39450);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void CompoundAssignment_06()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22016, 39462, 43851);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22016, 39617, 39765);

                string
                source = @"
using System;
class C
{
    void M(int[] a, int? b, int c)
    /*<bind>*/{
        a[0] &= b ?? c;
    }/*</bind>*/
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22016, 39779, 39832);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22016, 39848, 43728);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a[0]')
              Value: 
                IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: System.Int32) (Syntax: 'a[0]')
                  Array reference: 
                    IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Int32[]) (Syntax: 'a')
                  Indices(1):
                      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')

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
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'a[0] &= b ?? c;')
              Expression: 
                ICompoundAssignmentOperation (BinaryOperatorKind.And) (OperationKind.CompoundAssignment, Type: System.Int32) (Syntax: 'a[0] &= b ?? c')
                  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'a[0]')
                  Right: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'b ?? c')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22016, 43742, 43840);

                f_22016_43742_43839(source, expectedFlowGraph, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22016, 39462, 43851);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22016, 39462, 43851);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22016, 39462, 43851);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void CompoundAssignment_07()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22016, 43863, 48251);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22016, 44018, 44166);

                string
                source = @"
using System;
class C
{
    void M(int[] a, int? b, int c)
    /*<bind>*/{
        a[0] |= b ?? c;
    }/*</bind>*/
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22016, 44180, 44233);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22016, 44249, 48128);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a[0]')
              Value: 
                IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: System.Int32) (Syntax: 'a[0]')
                  Array reference: 
                    IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Int32[]) (Syntax: 'a')
                  Indices(1):
                      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')

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
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'a[0] |= b ?? c;')
              Expression: 
                ICompoundAssignmentOperation (BinaryOperatorKind.Or) (OperationKind.CompoundAssignment, Type: System.Int32) (Syntax: 'a[0] |= b ?? c')
                  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'a[0]')
                  Right: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'b ?? c')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22016, 48142, 48240);

                f_22016_48142_48239(source, expectedFlowGraph, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22016, 43863, 48251);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22016, 43863, 48251);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22016, 43863, 48251);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void CompoundAssignment_08()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22016, 48263, 52660);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22016, 48418, 48566);

                string
                source = @"
using System;
class C
{
    void M(int[] a, int? b, int c)
    /*<bind>*/{
        a[0] ^= b ?? c;
    }/*</bind>*/
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22016, 48580, 48633);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22016, 48649, 52537);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a[0]')
              Value: 
                IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: System.Int32) (Syntax: 'a[0]')
                  Array reference: 
                    IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Int32[]) (Syntax: 'a')
                  Indices(1):
                      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')

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
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'a[0] ^= b ?? c;')
              Expression: 
                ICompoundAssignmentOperation (BinaryOperatorKind.ExclusiveOr) (OperationKind.CompoundAssignment, Type: System.Int32) (Syntax: 'a[0] ^= b ?? c')
                  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'a[0]')
                  Right: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'b ?? c')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22016, 52551, 52649);

                f_22016_52551_52648(source, expectedFlowGraph, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22016, 48263, 52660);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22016, 48263, 52660);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22016, 48263, 52660);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void CompoundAssignment_09()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22016, 52672, 57070);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22016, 52827, 52976);

                string
                source = @"
using System;
class C
{
    void M(int[] a, int? b, int c)
    /*<bind>*/{
        a[0] <<= b ?? c;
    }/*</bind>*/
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22016, 52990, 53043);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22016, 53059, 56947);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a[0]')
              Value: 
                IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: System.Int32) (Syntax: 'a[0]')
                  Array reference: 
                    IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Int32[]) (Syntax: 'a')
                  Indices(1):
                      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')

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
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'a[0] <<= b ?? c;')
              Expression: 
                ICompoundAssignmentOperation (BinaryOperatorKind.LeftShift) (OperationKind.CompoundAssignment, Type: System.Int32) (Syntax: 'a[0] <<= b ?? c')
                  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'a[0]')
                  Right: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'b ?? c')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22016, 56961, 57059);

                f_22016_56961_57058(source, expectedFlowGraph, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22016, 52672, 57070);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22016, 52672, 57070);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22016, 52672, 57070);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void CompoundAssignment_10()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22016, 57082, 61481);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22016, 57237, 57386);

                string
                source = @"
using System;
class C
{
    void M(int[] a, int? b, int c)
    /*<bind>*/{
        a[0] >>= b ?? c;
    }/*</bind>*/
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22016, 57400, 57453);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22016, 57469, 61358);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a[0]')
              Value: 
                IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: System.Int32) (Syntax: 'a[0]')
                  Array reference: 
                    IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Int32[]) (Syntax: 'a')
                  Indices(1):
                      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')

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
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'a[0] >>= b ?? c;')
              Expression: 
                ICompoundAssignmentOperation (BinaryOperatorKind.RightShift) (OperationKind.CompoundAssignment, Type: System.Int32) (Syntax: 'a[0] >>= b ?? c')
                  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'a[0]')
                  Right: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'b ?? c')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22016, 61372, 61470);

                f_22016_61372_61469(source, expectedFlowGraph, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22016, 57082, 61481);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22016, 57082, 61481);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22016, 57082, 61481);
            }
        }

        System.ArgumentNullException
        f_22016_820_918(string
        paramName, System.Func<object>
        testCode)
        {
            var return_v = Assert.Throws<ArgumentNullException>(paramName, testCode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22016, 820, 918);
            return return_v;
        }


        System.ArgumentNullException
        f_22016_933_1032(string
        paramName, System.Func<object>
        testCode)
        {
            var return_v = Assert.Throws<ArgumentNullException>(paramName, testCode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22016, 933, 1032);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxTree
        f_22016_1397_1410(string
        text)
        {
            var return_v = Parse(text);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22016, 1397, 1410);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22016_1443_1496(Microsoft.CodeAnalysis.SyntaxTree[]
        source)
        {
            var return_v = CreateCompilationWithMscorlib45((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22016, 1443, 1496);
            return return_v;
        }


        (Microsoft.CodeAnalysis.IOperation operation, Microsoft.CodeAnalysis.SyntaxNode node)
        f_22016_1539_1608(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation)
        {
            var return_v = GetOperationAndSyntaxForTest<AssignmentExpressionSyntax>(compilation);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22016, 1539, 1608);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Conversion
        f_22016_1738_1774(Microsoft.CodeAnalysis.Operations.ICompoundAssignmentOperation
        compoundAssignment)
        {
            var return_v = compoundAssignment.GetInConversion();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22016, 1738, 1774);
            return return_v;
        }


        int
        f_22016_1704_1775(Microsoft.CodeAnalysis.CSharp.Conversion
        expected, Microsoft.CodeAnalysis.CSharp.Conversion
        actual)
        {
            Assert.Equal(expected, actual);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22016, 1704, 1775);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.Conversion
        f_22016_1824_1861(Microsoft.CodeAnalysis.Operations.ICompoundAssignmentOperation
        compoundAssignment)
        {
            var return_v = compoundAssignment.GetOutConversion();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22016, 1824, 1861);
            return return_v;
        }


        int
        f_22016_1790_1862(Microsoft.CodeAnalysis.CSharp.Conversion
        expected, Microsoft.CodeAnalysis.CSharp.Conversion
        actual)
        {
            Assert.Equal(expected, actual);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22016, 1790, 1862);
            return 0;
        }


        Microsoft.CodeAnalysis.SyntaxTree
        f_22016_2410_2423(string
        text)
        {
            var return_v = Parse(text);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22016, 2410, 2423);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22016_2456_2509(Microsoft.CodeAnalysis.SyntaxTree[]
        source)
        {
            var return_v = CreateCompilationWithMscorlib45((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22016, 2456, 2509);
            return return_v;
        }


        (Microsoft.CodeAnalysis.IOperation operation, Microsoft.CodeAnalysis.SyntaxNode node)
        f_22016_2566_2635(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation)
        {
            var return_v = GetOperationAndSyntaxForTest<AssignmentExpressionSyntax>(compilation);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22016, 2566, 2635);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
        f_22016_2748_2786(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        this_param, string
        fullyQualifiedMetadataName)
        {
            var return_v = this_param.GetTypeByMetadataName(fullyQualifiedMetadataName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22016, 2748, 2786);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
        f_22016_2823_2859(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
        this_param, string
        name)
        {
            var return_v = this_param.GetMembers(name);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22016, 2823, 2859);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
        f_22016_2823_2880(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
        source)
        {
            var return_v = source.Cast<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22016, 2823, 2880);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
        f_22016_2910_2994(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
        source, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol, bool>
        predicate)
        {
            var return_v = source.Where<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>(predicate);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22016, 2910, 2994);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        f_22016_2910_3003(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
        source)
        {
            var return_v = source.Single<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22016, 2910, 3003);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
        f_22016_3034_3079(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
        source, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol, bool>
        predicate)
        {
            var return_v = source.Where<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>(predicate);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22016, 3034, 3079);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        f_22016_3034_3088(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
        source)
        {
            var return_v = source.Single<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22016, 3034, 3088);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Conversion
        f_22016_3122_3189(Microsoft.CodeAnalysis.CSharp.ConversionKind
        kind, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        conversionMethod, bool
        isExtensionMethod)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Conversion(kind, conversionMethod, isExtensionMethod);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22016, 3122, 3189);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Conversion
        f_22016_3224_3292(Microsoft.CodeAnalysis.CSharp.ConversionKind
        kind, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        conversionMethod, bool
        isExtensionMethod)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Conversion(kind, conversionMethod, isExtensionMethod);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22016, 3224, 3292);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Conversion
        f_22016_3336_3372(Microsoft.CodeAnalysis.Operations.ICompoundAssignmentOperation
        compoundAssignment)
        {
            var return_v = compoundAssignment.GetInConversion();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22016, 3336, 3372);
            return return_v;
        }


        int
        f_22016_3309_3373(Microsoft.CodeAnalysis.CSharp.Conversion
        expected, Microsoft.CodeAnalysis.CSharp.Conversion
        actual)
        {
            Assert.Equal(expected, actual);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22016, 3309, 3373);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.Conversion
        f_22016_3416_3453(Microsoft.CodeAnalysis.Operations.ICompoundAssignmentOperation
        compoundAssignment)
        {
            var return_v = compoundAssignment.GetOutConversion();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22016, 3416, 3453);
            return return_v;
        }


        int
        f_22016_3388_3454(Microsoft.CodeAnalysis.CSharp.Conversion
        expected, Microsoft.CodeAnalysis.CSharp.Conversion
        actual)
        {
            Assert.Equal(expected, actual);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22016, 3388, 3454);
            return 0;
        }


        int
        f_22016_4765_4885(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<AssignmentExpressionSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22016, 4765, 4885);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22016_6278_6328(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22016, 6278, 6328);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22016_6278_6354(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22016, 6278, 6354);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22016_6278_6374(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22016, 6278, 6374);
            return return_v;
        }


        int
        f_22016_6406_6526(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<AssignmentExpressionSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22016, 6406, 6526);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22016_7920_7968(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22016, 7920, 7968);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22016_7920_8000(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22016, 7920, 8000);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22016_7920_8020(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22016, 7920, 8020);
            return return_v;
        }


        int
        f_22016_8052_8172(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<AssignmentExpressionSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22016, 8052, 8172);
            return 0;
        }


        int
        f_22016_9970_10090(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<AssignmentExpressionSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22016, 9970, 10090);
            return 0;
        }


        int
        f_22016_11886_12006(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<AssignmentExpressionSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22016, 11886, 12006);
            return 0;
        }


        int
        f_22016_13844_13964(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<AssignmentExpressionSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22016, 13844, 13964);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22016_15439_15487(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22016, 15439, 15487);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22016_15439_15519(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22016, 15439, 15519);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22016_15439_15539(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22016, 15439, 15539);
            return return_v;
        }


        int
        f_22016_15571_15691(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<AssignmentExpressionSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22016, 15571, 15691);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22016_17166_17216(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22016, 17166, 17216);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22016_17166_17242(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22016, 17166, 17242);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22016_17166_17262(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22016, 17166, 17262);
            return return_v;
        }


        int
        f_22016_17294_17414(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<AssignmentExpressionSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22016, 17294, 17414);
            return 0;
        }


        int
        f_22016_21718_21815(string
        testSrc, string
        expectedFlowGraph, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>(testSrc, expectedFlowGraph, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22016, 21718, 21815);
            return 0;
        }


        int
        f_22016_26124_26221(string
        testSrc, string
        expectedFlowGraph, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>(testSrc, expectedFlowGraph, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22016, 26124, 26221);
            return 0;
        }


        int
        f_22016_30530_30627(string
        testSrc, string
        expectedFlowGraph, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>(testSrc, expectedFlowGraph, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22016, 30530, 30627);
            return 0;
        }


        int
        f_22016_34934_35031(string
        testSrc, string
        expectedFlowGraph, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>(testSrc, expectedFlowGraph, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22016, 34934, 35031);
            return 0;
        }


        int
        f_22016_39341_39438(string
        testSrc, string
        expectedFlowGraph, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>(testSrc, expectedFlowGraph, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22016, 39341, 39438);
            return 0;
        }


        int
        f_22016_43742_43839(string
        testSrc, string
        expectedFlowGraph, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>(testSrc, expectedFlowGraph, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22016, 43742, 43839);
            return 0;
        }


        int
        f_22016_48142_48239(string
        testSrc, string
        expectedFlowGraph, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>(testSrc, expectedFlowGraph, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22016, 48142, 48239);
            return 0;
        }


        int
        f_22016_52551_52648(string
        testSrc, string
        expectedFlowGraph, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>(testSrc, expectedFlowGraph, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22016, 52551, 52648);
            return 0;
        }


        int
        f_22016_56961_57058(string
        testSrc, string
        expectedFlowGraph, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>(testSrc, expectedFlowGraph, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22016, 56961, 57058);
            return 0;
        }


        int
        f_22016_61372_61469(string
        testSrc, string
        expectedFlowGraph, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>(testSrc, expectedFlowGraph, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22016, 61372, 61469);
            return 0;
        }

    }
}
