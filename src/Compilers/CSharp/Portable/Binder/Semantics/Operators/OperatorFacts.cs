// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal static class OperatorFacts
    {
        public static bool DefinitelyHasNoUserDefinedOperators(TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10857, 447, 2404);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10857, 627, 932);

                switch (f_10857_635_648(type))
                {

                    case TypeKind.Struct:
                    case TypeKind.Class:
                    case TypeKind.TypeParameter:
                    case TypeKind.Interface:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10857, 627, 932);
                        DynAbs.Tracing.TraceSender.TraceBreak(10857, 851, 857);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10857, 627, 932);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10857, 627, 932);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10857, 905, 917);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10857, 627, 932);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10857, 1082, 2364);

                switch (f_10857_1090_1106(type))
                {

                    case SpecialType.System_Array:
                    case SpecialType.System_Boolean:
                    case SpecialType.System_Byte:
                    case SpecialType.System_Char:
                    case SpecialType.System_Decimal:
                    case SpecialType.System_Delegate:
                    case SpecialType.System_Double:
                    case SpecialType.System_Enum:
                    case SpecialType.System_Int16:
                    case SpecialType.System_Int32:
                    case SpecialType.System_Int64:
                    case SpecialType.System_IntPtr when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10857, 1704, 1733) || true) && (f_10857_1709_1733(type)) && (DynAbs.Tracing.TraceSender.Expression_True(10857, 1704, 1733) || true)
                :
                    case SpecialType.System_UIntPtr when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10857, 1784, 1813) || true) && (f_10857_1789_1813(type)) && (DynAbs.Tracing.TraceSender.Expression_True(10857, 1784, 1813) || true)
                :
                    case SpecialType.System_MulticastDelegate:
                    case SpecialType.System_Object:
                    case SpecialType.System_SByte:
                    case SpecialType.System_Single:
                    case SpecialType.System_String:
                    case SpecialType.System_UInt16:
                    case SpecialType.System_UInt32:
                    case SpecialType.System_UInt64:
                    case SpecialType.System_ValueType:
                    case SpecialType.System_Void:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10857, 1082, 2364);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10857, 2337, 2349);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10857, 1082, 2364);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10857, 2380, 2393);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10857, 447, 2404);

                Microsoft.CodeAnalysis.TypeKind
                f_10857_635_648(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10857, 635, 648);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10857_1090_1106(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10857, 1090, 1106);
                    return return_v;
                }


                bool
                f_10857_1709_1733(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsNativeIntegerType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10857, 1709, 1733);
                    return return_v;
                }


                bool
                f_10857_1789_1813(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsNativeIntegerType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10857, 1789, 1813);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10857, 447, 2404);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10857, 447, 2404);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static string BinaryOperatorNameFromSyntaxKind(SyntaxKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10857, 2416, 2687);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10857, 2511, 2624);

                return f_10857_2518_2561(kind) ?? (DynAbs.Tracing.TraceSender.Expression_Null<string>(10857, 2518, 2623) ?? WellKnownMemberNames.AdditionOperatorName);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10857, 2416, 2687);

                string
                f_10857_2518_2561(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = BinaryOperatorNameFromSyntaxKindIfAny(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10857, 2518, 2561);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10857, 2416, 2687);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10857, 2416, 2687);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string BinaryOperatorNameFromSyntaxKindIfAny(SyntaxKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10857, 2699, 4551);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10857, 2801, 4540);

                switch (kind)
                {

                    case SyntaxKind.PlusToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10857, 2801, 4540);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10857, 2874, 2923);

                        return WellKnownMemberNames.AdditionOperatorName;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10857, 2801, 4540);

                    case SyntaxKind.MinusToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10857, 2801, 4540);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10857, 2969, 3021);

                        return WellKnownMemberNames.SubtractionOperatorName;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10857, 2801, 4540);

                    case SyntaxKind.AsteriskToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10857, 2801, 4540);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10857, 3070, 3119);

                        return WellKnownMemberNames.MultiplyOperatorName;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10857, 2801, 4540);

                    case SyntaxKind.SlashToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10857, 2801, 4540);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10857, 3165, 3214);

                        return WellKnownMemberNames.DivisionOperatorName;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10857, 2801, 4540);

                    case SyntaxKind.PercentToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10857, 2801, 4540);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10857, 3262, 3310);

                        return WellKnownMemberNames.ModulusOperatorName;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10857, 2801, 4540);

                    case SyntaxKind.CaretToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10857, 2801, 4540);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10857, 3356, 3408);

                        return WellKnownMemberNames.ExclusiveOrOperatorName;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10857, 2801, 4540);

                    case SyntaxKind.AmpersandToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10857, 2801, 4540);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10857, 3458, 3509);

                        return WellKnownMemberNames.BitwiseAndOperatorName;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10857, 2801, 4540);

                    case SyntaxKind.BarToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10857, 2801, 4540);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10857, 3553, 3603);

                        return WellKnownMemberNames.BitwiseOrOperatorName;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10857, 2801, 4540);

                    case SyntaxKind.EqualsEqualsToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10857, 2801, 4540);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10857, 3656, 3705);

                        return WellKnownMemberNames.EqualityOperatorName;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10857, 2801, 4540);

                    case SyntaxKind.LessThanToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10857, 2801, 4540);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10857, 3754, 3803);

                        return WellKnownMemberNames.LessThanOperatorName;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10857, 2801, 4540);

                    case SyntaxKind.LessThanEqualsToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10857, 2801, 4540);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10857, 3858, 3914);

                        return WellKnownMemberNames.LessThanOrEqualOperatorName;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10857, 2801, 4540);

                    case SyntaxKind.LessThanLessThanToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10857, 2801, 4540);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10857, 3971, 4021);

                        return WellKnownMemberNames.LeftShiftOperatorName;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10857, 2801, 4540);

                    case SyntaxKind.GreaterThanToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10857, 2801, 4540);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10857, 4073, 4125);

                        return WellKnownMemberNames.GreaterThanOperatorName;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10857, 2801, 4540);

                    case SyntaxKind.GreaterThanEqualsToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10857, 2801, 4540);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10857, 4183, 4242);

                        return WellKnownMemberNames.GreaterThanOrEqualOperatorName;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10857, 2801, 4540);

                    case SyntaxKind.GreaterThanGreaterThanToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10857, 2801, 4540);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10857, 4305, 4356);

                        return WellKnownMemberNames.RightShiftOperatorName;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10857, 2801, 4540);

                    case SyntaxKind.ExclamationEqualsToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10857, 2801, 4540);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10857, 4414, 4465);

                        return WellKnownMemberNames.InequalityOperatorName;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10857, 2801, 4540);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10857, 2801, 4540);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10857, 4513, 4525);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10857, 2801, 4540);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10857, 2699, 4551);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10857, 2699, 4551);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10857, 2699, 4551);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static string UnaryOperatorNameFromSyntaxKind(SyntaxKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10857, 4563, 4833);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10857, 4657, 4770);

                return f_10857_4664_4706(kind) ?? (DynAbs.Tracing.TraceSender.Expression_Null<string>(10857, 4664, 4769) ?? WellKnownMemberNames.UnaryPlusOperatorName);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10857, 4563, 4833);

                string
                f_10857_4664_4706(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = UnaryOperatorNameFromSyntaxKindIfAny(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10857, 4664, 4706);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10857, 4563, 4833);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10857, 4563, 4833);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string UnaryOperatorNameFromSyntaxKindIfAny(SyntaxKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10857, 4845, 5845);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10857, 4946, 5834);

                switch (kind)
                {

                    case SyntaxKind.PlusToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10857, 4946, 5834);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10857, 5019, 5069);

                        return WellKnownMemberNames.UnaryPlusOperatorName;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10857, 4946, 5834);

                    case SyntaxKind.MinusToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10857, 4946, 5834);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10857, 5115, 5169);

                        return WellKnownMemberNames.UnaryNegationOperatorName;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10857, 4946, 5834);

                    case SyntaxKind.TildeToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10857, 4946, 5834);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10857, 5215, 5270);

                        return WellKnownMemberNames.OnesComplementOperatorName;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10857, 4946, 5834);

                    case SyntaxKind.ExclamationToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10857, 4946, 5834);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10857, 5322, 5373);

                        return WellKnownMemberNames.LogicalNotOperatorName;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10857, 4946, 5834);

                    case SyntaxKind.PlusPlusToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10857, 4946, 5834);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10857, 5422, 5472);

                        return WellKnownMemberNames.IncrementOperatorName;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10857, 4946, 5834);

                    case SyntaxKind.MinusMinusToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10857, 4946, 5834);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10857, 5523, 5573);

                        return WellKnownMemberNames.DecrementOperatorName;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10857, 4946, 5834);

                    case SyntaxKind.TrueKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10857, 4946, 5834);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10857, 5620, 5665);

                        return WellKnownMemberNames.TrueOperatorName;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10857, 4946, 5834);

                    case SyntaxKind.FalseKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10857, 4946, 5834);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10857, 5713, 5759);

                        return WellKnownMemberNames.FalseOperatorName;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10857, 4946, 5834);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10857, 4946, 5834);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10857, 5807, 5819);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10857, 4946, 5834);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10857, 4845, 5845);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10857, 4845, 5845);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10857, 4845, 5845);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static string OperatorNameFromDeclaration(OperatorDeclarationSyntax declaration)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10857, 5857, 6085);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10857, 5969, 6074);

                return f_10857_5976_6073((f_10857_6054_6071(declaration)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10857, 5857, 6085);

                Microsoft.CodeAnalysis.GreenNode
                f_10857_6054_6071(Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Green;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10857, 6054, 6071);
                    return return_v;
                }


                string
                f_10857_5976_6073(Microsoft.CodeAnalysis.GreenNode
                declaration)
                {
                    var return_v = OperatorNameFromDeclaration((Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.OperatorDeclarationSyntax)declaration);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10857, 5976, 6073);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10857, 5857, 6085);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10857, 5857, 6085);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static string OperatorNameFromDeclaration(Syntax.InternalSyntax.OperatorDeclarationSyntax declaration)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10857, 6097, 7210);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10857, 6231, 6280);

                var
                opTokenKind = f_10857_6249_6279(f_10857_6249_6274(declaration))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10857, 6296, 7199) || true) && (f_10857_6300_6356(opTokenKind))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10857, 6296, 7199);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10857, 6475, 6739) || true) && (f_10857_6479_6540(opTokenKind) && (DynAbs.Tracing.TraceSender.Expression_True(10857, 6479, 6612) && f_10857_6565_6590(declaration).Parameters.Count == 1))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10857, 6475, 6739);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10857, 6654, 6720);

                        return f_10857_6661_6719(opTokenKind);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10857, 6475, 6739);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10857, 6759, 6826);

                    return f_10857_6766_6825(opTokenKind);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10857, 6296, 7199);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10857, 6296, 7199);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10857, 6860, 7199) || true) && (f_10857_6864_6920(opTokenKind))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10857, 6860, 7199);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10857, 6954, 7020);

                        return f_10857_6961_7019(opTokenKind);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10857, 6860, 7199);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10857, 6860, 7199);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10857, 7134, 7184);

                        return WellKnownMemberNames.UnaryPlusOperatorName;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10857, 6860, 7199);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10857, 6296, 7199);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10857, 6097, 7210);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10857_6249_6274(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.OperatorDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.OperatorToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10857, 6249, 6274);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10857_6249_6279(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10857, 6249, 6279);
                    return return_v;
                }


                bool
                f_10857_6300_6356(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                token)
                {
                    var return_v = SyntaxFacts.IsBinaryExpressionOperatorToken(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10857, 6300, 6356);
                    return return_v;
                }


                bool
                f_10857_6479_6540(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                token)
                {
                    var return_v = SyntaxFacts.IsPrefixUnaryExpressionOperatorToken(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10857, 6479, 6540);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ParameterListSyntax
                f_10857_6565_6590(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.OperatorDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.ParameterList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10857, 6565, 6590);
                    return return_v;
                }


                string
                f_10857_6661_6719(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = OperatorFacts.UnaryOperatorNameFromSyntaxKind(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10857, 6661, 6719);
                    return return_v;
                }


                string
                f_10857_6766_6825(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = OperatorFacts.BinaryOperatorNameFromSyntaxKind(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10857, 6766, 6825);
                    return return_v;
                }


                bool
                f_10857_6864_6920(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                token)
                {
                    var return_v = SyntaxFacts.IsUnaryOperatorDeclarationToken(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10857, 6864, 6920);
                    return return_v;
                }


                string
                f_10857_6961_7019(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = OperatorFacts.UnaryOperatorNameFromSyntaxKind(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10857, 6961, 7019);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10857, 6097, 7210);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10857, 6097, 7210);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static string UnaryOperatorNameFromOperatorKind(UnaryOperatorKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10857, 7222, 8479);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10857, 7325, 8468);

                switch (kind & UnaryOperatorKind.OpMask)
                {

                    case UnaryOperatorKind.UnaryPlus:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10857, 7325, 8468);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10857, 7432, 7482);

                        return WellKnownMemberNames.UnaryPlusOperatorName;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10857, 7325, 8468);

                    case UnaryOperatorKind.UnaryMinus:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10857, 7325, 8468);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10857, 7535, 7589);

                        return WellKnownMemberNames.UnaryNegationOperatorName;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10857, 7325, 8468);

                    case UnaryOperatorKind.BitwiseComplement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10857, 7325, 8468);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10857, 7649, 7704);

                        return WellKnownMemberNames.OnesComplementOperatorName;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10857, 7325, 8468);

                    case UnaryOperatorKind.LogicalNegation:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10857, 7325, 8468);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10857, 7762, 7813);

                        return WellKnownMemberNames.LogicalNotOperatorName;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10857, 7325, 8468);

                    case UnaryOperatorKind.PostfixIncrement:
                    case UnaryOperatorKind.PrefixIncrement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10857, 7325, 8468);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10857, 7929, 7979);

                        return WellKnownMemberNames.IncrementOperatorName;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10857, 7325, 8468);

                    case UnaryOperatorKind.PostfixDecrement:
                    case UnaryOperatorKind.PrefixDecrement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10857, 7325, 8468);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10857, 8095, 8145);

                        return WellKnownMemberNames.DecrementOperatorName;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10857, 7325, 8468);

                    case UnaryOperatorKind.True:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10857, 7325, 8468);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10857, 8192, 8237);

                        return WellKnownMemberNames.TrueOperatorName;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10857, 7325, 8468);

                    case UnaryOperatorKind.False:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10857, 7325, 8468);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10857, 8285, 8331);

                        return WellKnownMemberNames.FalseOperatorName;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10857, 7325, 8468);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10857, 7325, 8468);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10857, 8379, 8453);

                        throw f_10857_8385_8452(kind & UnaryOperatorKind.OpMask);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10857, 7325, 8468);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10857, 7222, 8479);

                System.Exception
                f_10857_8385_8452(Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10857, 8385, 8452);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10857, 7222, 8479);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10857, 7222, 8479);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static string BinaryOperatorNameFromOperatorKind(BinaryOperatorKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10857, 8491, 10464);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10857, 8596, 10453);

                switch (kind & BinaryOperatorKind.OpMask)
                {

                    case BinaryOperatorKind.Addition:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10857, 8596, 10453);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10857, 8704, 8753);

                        return WellKnownMemberNames.AdditionOperatorName;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10857, 8596, 10453);

                    case BinaryOperatorKind.And:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10857, 8596, 10453);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10857, 8800, 8851);

                        return WellKnownMemberNames.BitwiseAndOperatorName;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10857, 8596, 10453);

                    case BinaryOperatorKind.Division:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10857, 8596, 10453);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10857, 8903, 8952);

                        return WellKnownMemberNames.DivisionOperatorName;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10857, 8596, 10453);

                    case BinaryOperatorKind.Equal:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10857, 8596, 10453);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10857, 9001, 9050);

                        return WellKnownMemberNames.EqualityOperatorName;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10857, 8596, 10453);

                    case BinaryOperatorKind.GreaterThan:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10857, 8596, 10453);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10857, 9105, 9157);

                        return WellKnownMemberNames.GreaterThanOperatorName;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10857, 8596, 10453);

                    case BinaryOperatorKind.GreaterThanOrEqual:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10857, 8596, 10453);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10857, 9219, 9278);

                        return WellKnownMemberNames.GreaterThanOrEqualOperatorName;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10857, 8596, 10453);

                    case BinaryOperatorKind.LeftShift:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10857, 8596, 10453);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10857, 9331, 9381);

                        return WellKnownMemberNames.LeftShiftOperatorName;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10857, 8596, 10453);

                    case BinaryOperatorKind.LessThan:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10857, 8596, 10453);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10857, 9433, 9482);

                        return WellKnownMemberNames.LessThanOperatorName;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10857, 8596, 10453);

                    case BinaryOperatorKind.LessThanOrEqual:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10857, 8596, 10453);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10857, 9541, 9597);

                        return WellKnownMemberNames.LessThanOrEqualOperatorName;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10857, 8596, 10453);

                    case BinaryOperatorKind.Multiplication:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10857, 8596, 10453);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10857, 9655, 9704);

                        return WellKnownMemberNames.MultiplyOperatorName;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10857, 8596, 10453);

                    case BinaryOperatorKind.Or:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10857, 8596, 10453);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10857, 9750, 9800);

                        return WellKnownMemberNames.BitwiseOrOperatorName;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10857, 8596, 10453);

                    case BinaryOperatorKind.NotEqual:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10857, 8596, 10453);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10857, 9852, 9903);

                        return WellKnownMemberNames.InequalityOperatorName;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10857, 8596, 10453);

                    case BinaryOperatorKind.Remainder:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10857, 8596, 10453);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10857, 9956, 10004);

                        return WellKnownMemberNames.ModulusOperatorName;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10857, 8596, 10453);

                    case BinaryOperatorKind.RightShift:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10857, 8596, 10453);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10857, 10058, 10109);

                        return WellKnownMemberNames.RightShiftOperatorName;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10857, 8596, 10453);

                    case BinaryOperatorKind.Subtraction:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10857, 8596, 10453);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10857, 10164, 10216);

                        return WellKnownMemberNames.SubtractionOperatorName;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10857, 8596, 10453);

                    case BinaryOperatorKind.Xor:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10857, 8596, 10453);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10857, 10263, 10315);

                        return WellKnownMemberNames.ExclusiveOrOperatorName;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10857, 8596, 10453);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10857, 8596, 10453);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10857, 10363, 10438);

                        throw f_10857_10369_10437(kind & BinaryOperatorKind.OpMask);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10857, 8596, 10453);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10857, 8491, 10464);

                System.Exception
                f_10857_10369_10437(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10857, 10369, 10437);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10857, 8491, 10464);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10857, 8491, 10464);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static OperatorFacts()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10857, 395, 10471);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10857, 395, 10471);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10857, 395, 10471);
        }

    }
}
