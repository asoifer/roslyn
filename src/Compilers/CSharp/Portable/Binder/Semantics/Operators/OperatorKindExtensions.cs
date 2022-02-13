// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Diagnostics;
using System.Linq.Expressions;
using System.Text;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal static partial class OperatorKindExtensions
    {
        public static int OperatorIndex(this UnaryOperatorKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10859, 579, 715);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 664, 704);

                return ((int)f_10859_677_692(kind) >> 8) - 16;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10859, 579, 715);

                Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
                f_10859_677_692(Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
                kind)
                {
                    var return_v = kind.Operator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10859, 677, 692);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10859, 579, 715);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10859, 579, 715);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static UnaryOperatorKind Operator(this UnaryOperatorKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10859, 727, 871);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 821, 860);

                return kind & UnaryOperatorKind.OpMask;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10859, 727, 871);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10859, 727, 871);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10859, 727, 871);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static UnaryOperatorKind Unlifted(this UnaryOperatorKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10859, 883, 1028);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 977, 1017);

                return kind & ~UnaryOperatorKind.Lifted;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10859, 883, 1028);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10859, 883, 1028);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10859, 883, 1028);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsLifted(this UnaryOperatorKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10859, 1040, 1178);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 1121, 1167);

                return 0 != (kind & UnaryOperatorKind.Lifted);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10859, 1040, 1178);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10859, 1040, 1178);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10859, 1040, 1178);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsChecked(this UnaryOperatorKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10859, 1190, 1330);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 1272, 1319);

                return 0 != (kind & UnaryOperatorKind.Checked);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10859, 1190, 1330);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10859, 1190, 1330);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10859, 1190, 1330);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsUserDefined(this UnaryOperatorKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10859, 1342, 1515);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 1428, 1504);

                return (kind & UnaryOperatorKind.TypeMask) == UnaryOperatorKind.UserDefined;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10859, 1342, 1515);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10859, 1342, 1515);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10859, 1342, 1515);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static UnaryOperatorKind OverflowChecks(this UnaryOperatorKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10859, 1527, 1678);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 1627, 1667);

                return kind & UnaryOperatorKind.Checked;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10859, 1527, 1678);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10859, 1527, 1678);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10859, 1527, 1678);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static UnaryOperatorKind WithOverflowChecksIfApplicable(this UnaryOperatorKind kind, bool enabled)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10859, 1690, 2964);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 1820, 2953) || true) && (enabled)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10859, 1820, 2953);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 2116, 2237) || true) && (f_10859_2120_2136(kind))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10859, 2116, 2237);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 2178, 2218);

                        return kind | UnaryOperatorKind.Checked;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10859, 2116, 2237);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 2257, 2801) || true) && (f_10859_2261_2278(kind))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10859, 2257, 2801);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 2320, 2782);

                        switch (f_10859_2328_2343(kind))
                        {

                            case UnaryOperatorKind.PrefixIncrement:
                            case UnaryOperatorKind.PostfixIncrement:
                            case UnaryOperatorKind.PrefixDecrement:
                            case UnaryOperatorKind.PostfixDecrement:
                            case UnaryOperatorKind.UnaryMinus:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10859, 2320, 2782);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 2719, 2759);

                                return kind | UnaryOperatorKind.Checked;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10859, 2320, 2782);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10859, 2257, 2801);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 2819, 2831);

                    return kind;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10859, 1820, 2953);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10859, 1820, 2953);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 2897, 2938);

                    return kind & ~UnaryOperatorKind.Checked;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10859, 1820, 2953);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10859, 1690, 2964);

                bool
                f_10859_2120_2136(Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
                kind)
                {
                    var return_v = kind.IsDynamic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10859, 2120, 2136);
                    return return_v;
                }


                bool
                f_10859_2261_2278(Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
                kind)
                {
                    var return_v = kind.IsIntegral();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10859, 2261, 2278);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
                f_10859_2328_2343(Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
                kind)
                {
                    var return_v = kind.Operator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10859, 2328, 2343);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10859, 1690, 2964);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10859, 1690, 2964);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static UnaryOperatorKind OperandTypes(this UnaryOperatorKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10859, 2976, 3126);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 3074, 3115);

                return kind & UnaryOperatorKind.TypeMask;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10859, 2976, 3126);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10859, 2976, 3126);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10859, 2976, 3126);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsDynamic(this UnaryOperatorKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10859, 3138, 3287);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 3220, 3276);

                return f_10859_3227_3246(kind) == UnaryOperatorKind.Dynamic;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10859, 3138, 3287);

                Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
                f_10859_3227_3246(Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
                kind)
                {
                    var return_v = kind.OperandTypes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10859, 3227, 3246);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10859, 3138, 3287);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10859, 3138, 3287);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsIntegral(this UnaryOperatorKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10859, 3299, 4120);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 3382, 4080);

                switch (f_10859_3390_3409(kind))
                {

                    case UnaryOperatorKind.SByte:
                    case UnaryOperatorKind.Byte:
                    case UnaryOperatorKind.Short:
                    case UnaryOperatorKind.UShort:
                    case UnaryOperatorKind.Int:
                    case UnaryOperatorKind.UInt:
                    case UnaryOperatorKind.Long:
                    case UnaryOperatorKind.ULong:
                    case UnaryOperatorKind.NInt:
                    case UnaryOperatorKind.NUInt:
                    case UnaryOperatorKind.Char:
                    case UnaryOperatorKind.Enum:
                    case UnaryOperatorKind.Pointer:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10859, 3382, 4080);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 4053, 4065);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10859, 3382, 4080);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 4096, 4109);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10859, 3299, 4120);

                Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
                f_10859_3390_3409(Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
                kind)
                {
                    var return_v = kind.OperandTypes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10859, 3390, 3409);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10859, 3299, 4120);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10859, 3299, 4120);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static UnaryOperatorKind WithType(this UnaryOperatorKind kind, UnaryOperatorKind type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10859, 4132, 4425);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 4250, 4309);

                f_10859_4250_4308(kind == (kind & ~UnaryOperatorKind.TypeMask));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 4323, 4381);

                f_10859_4323_4380(type == (type & UnaryOperatorKind.TypeMask));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 4395, 4414);

                return kind | type;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10859, 4132, 4425);

                int
                f_10859_4250_4308(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10859, 4250, 4308);
                    return 0;
                }


                int
                f_10859_4323_4380(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10859, 4323, 4380);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10859, 4132, 4425);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10859, 4132, 4425);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static int OperatorIndex(this BinaryOperatorKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10859, 4437, 4574);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 4523, 4563);

                return ((int)f_10859_4536_4551(kind) >> 8) - 16;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10859, 4437, 4574);

                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10859_4536_4551(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind)
                {
                    var return_v = kind.Operator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10859, 4536, 4551);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10859, 4437, 4574);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10859, 4437, 4574);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static BinaryOperatorKind Operator(this BinaryOperatorKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10859, 4586, 4733);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 4682, 4722);

                return kind & BinaryOperatorKind.OpMask;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10859, 4586, 4733);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10859, 4586, 4733);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10859, 4586, 4733);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static BinaryOperatorKind Unlifted(this BinaryOperatorKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10859, 4745, 4893);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 4841, 4882);

                return kind & ~BinaryOperatorKind.Lifted;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10859, 4745, 4893);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10859, 4745, 4893);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10859, 4745, 4893);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static BinaryOperatorKind OperatorWithLogical(this BinaryOperatorKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10859, 4905, 5094);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 5012, 5083);

                return kind & (BinaryOperatorKind.OpMask | BinaryOperatorKind.Logical);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10859, 4905, 5094);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10859, 4905, 5094);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10859, 4905, 5094);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static BinaryOperatorKind WithType(this BinaryOperatorKind kind, SpecialType type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10859, 5106, 5877);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 5220, 5280);

                f_10859_5220_5279(kind == (kind & ~BinaryOperatorKind.TypeMask));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 5294, 5866);

                switch (type)
                {

                    case SpecialType.System_Int32:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10859, 5294, 5866);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 5392, 5429);

                        return kind | BinaryOperatorKind.Int;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10859, 5294, 5866);

                    case SpecialType.System_UInt32:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10859, 5294, 5866);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 5500, 5538);

                        return kind | BinaryOperatorKind.UInt;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10859, 5294, 5866);

                    case SpecialType.System_Int64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10859, 5294, 5866);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 5608, 5646);

                        return kind | BinaryOperatorKind.Long;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10859, 5294, 5866);

                    case SpecialType.System_UInt64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10859, 5294, 5866);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 5717, 5756);

                        return kind | BinaryOperatorKind.ULong;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10859, 5294, 5866);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10859, 5294, 5866);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 5804, 5851);

                        throw f_10859_5810_5850(type);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10859, 5294, 5866);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10859, 5106, 5877);

                int
                f_10859_5220_5279(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10859, 5220, 5279);
                    return 0;
                }


                System.Exception
                f_10859_5810_5850(Microsoft.CodeAnalysis.SpecialType
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10859, 5810, 5850);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10859, 5106, 5877);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10859, 5106, 5877);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static UnaryOperatorKind WithType(this UnaryOperatorKind kind, SpecialType type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10859, 5889, 6653);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 6001, 6060);

                f_10859_6001_6059(kind == (kind & ~UnaryOperatorKind.TypeMask));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 6074, 6642);

                switch (type)
                {

                    case SpecialType.System_Int32:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10859, 6074, 6642);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 6172, 6208);

                        return kind | UnaryOperatorKind.Int;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10859, 6074, 6642);

                    case SpecialType.System_UInt32:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10859, 6074, 6642);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 6279, 6316);

                        return kind | UnaryOperatorKind.UInt;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10859, 6074, 6642);

                    case SpecialType.System_Int64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10859, 6074, 6642);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 6386, 6423);

                        return kind | UnaryOperatorKind.Long;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10859, 6074, 6642);

                    case SpecialType.System_UInt64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10859, 6074, 6642);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 6494, 6532);

                        return kind | UnaryOperatorKind.ULong;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10859, 6074, 6642);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10859, 6074, 6642);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 6580, 6627);

                        throw f_10859_6586_6626(type);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10859, 6074, 6642);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10859, 5889, 6653);

                int
                f_10859_6001_6059(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10859, 6001, 6059);
                    return 0;
                }


                System.Exception
                f_10859_6586_6626(Microsoft.CodeAnalysis.SpecialType
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10859, 6586, 6626);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10859, 5889, 6653);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10859, 5889, 6653);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static BinaryOperatorKind WithType(this BinaryOperatorKind kind, BinaryOperatorKind type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10859, 6665, 6963);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 6786, 6846);

                f_10859_6786_6845(kind == (kind & ~BinaryOperatorKind.TypeMask));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 6860, 6919);

                f_10859_6860_6918(type == (type & BinaryOperatorKind.TypeMask));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 6933, 6952);

                return kind | type;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10859, 6665, 6963);

                int
                f_10859_6786_6845(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10859, 6786, 6845);
                    return 0;
                }


                int
                f_10859_6860_6918(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10859, 6860, 6918);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10859, 6665, 6963);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10859, 6665, 6963);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsLifted(this BinaryOperatorKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10859, 6975, 7115);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 7057, 7104);

                return 0 != (kind & BinaryOperatorKind.Lifted);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10859, 6975, 7115);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10859, 6975, 7115);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10859, 6975, 7115);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsDynamic(this BinaryOperatorKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10859, 7127, 7278);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 7210, 7267);

                return f_10859_7217_7236(kind) == BinaryOperatorKind.Dynamic;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10859, 7127, 7278);

                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10859_7217_7236(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind)
                {
                    var return_v = kind.OperandTypes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10859, 7217, 7236);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10859, 7127, 7278);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10859, 7127, 7278);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsComparison(this BinaryOperatorKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10859, 7290, 7825);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 7376, 7787);

                switch (f_10859_7384_7399(kind))
                {

                    case BinaryOperatorKind.Equal:
                    case BinaryOperatorKind.NotEqual:
                    case BinaryOperatorKind.GreaterThan:
                    case BinaryOperatorKind.GreaterThanOrEqual:
                    case BinaryOperatorKind.LessThan:
                    case BinaryOperatorKind.LessThanOrEqual:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10859, 7376, 7787);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 7760, 7772);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10859, 7376, 7787);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 7801, 7814);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10859, 7290, 7825);

                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10859_7384_7399(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind)
                {
                    var return_v = kind.Operator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10859, 7384, 7399);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10859, 7290, 7825);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10859, 7290, 7825);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsChecked(this BinaryOperatorKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10859, 7837, 7979);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 7920, 7968);

                return 0 != (kind & BinaryOperatorKind.Checked);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10859, 7837, 7979);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10859, 7837, 7979);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10859, 7837, 7979);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool EmitsAsCheckedInstruction(this BinaryOperatorKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10859, 7991, 8479);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 8090, 8173) || true) && (!f_10859_8095_8111(kind))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10859, 8090, 8173);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 8145, 8158);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10859, 8090, 8173);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 8189, 8439);

                switch (f_10859_8197_8212(kind))
                {

                    case BinaryOperatorKind.Addition:
                    case BinaryOperatorKind.Subtraction:
                    case BinaryOperatorKind.Multiplication:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10859, 8189, 8439);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 8412, 8424);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10859, 8189, 8439);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 8455, 8468);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10859, 7991, 8479);

                bool
                f_10859_8095_8111(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind)
                {
                    var return_v = kind.IsChecked();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10859, 8095, 8111);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10859_8197_8212(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind)
                {
                    var return_v = kind.Operator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10859, 8197, 8212);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10859, 7991, 8479);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10859, 7991, 8479);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static BinaryOperatorKind WithOverflowChecksIfApplicable(this BinaryOperatorKind kind, bool enabled)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10859, 8491, 9579);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 8623, 9568) || true) && (enabled)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10859, 8623, 9568);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 8805, 8927) || true) && (f_10859_8809_8825(kind))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10859, 8805, 8927);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 8867, 8908);

                        return kind | BinaryOperatorKind.Checked;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10859, 8805, 8927);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 8947, 9415) || true) && (f_10859_8951_8968(kind))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10859, 8947, 9415);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 9010, 9396);

                        switch (f_10859_9018_9033(kind))
                        {

                            case BinaryOperatorKind.Addition:
                            case BinaryOperatorKind.Subtraction:
                            case BinaryOperatorKind.Multiplication:
                            case BinaryOperatorKind.Division:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10859, 9010, 9396);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 9332, 9373);

                                return kind | BinaryOperatorKind.Checked;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10859, 9010, 9396);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10859, 8947, 9415);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 9433, 9445);

                    return kind;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10859, 8623, 9568);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10859, 8623, 9568);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 9511, 9553);

                    return kind & ~BinaryOperatorKind.Checked;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10859, 8623, 9568);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10859, 8491, 9579);

                bool
                f_10859_8809_8825(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind)
                {
                    var return_v = kind.IsDynamic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10859, 8809, 8825);
                    return return_v;
                }


                bool
                f_10859_8951_8968(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind)
                {
                    var return_v = kind.IsIntegral();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10859, 8951, 8968);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10859_9018_9033(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind)
                {
                    var return_v = kind.Operator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10859, 9018, 9033);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10859, 8491, 9579);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10859, 8491, 9579);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsEnum(this BinaryOperatorKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10859, 9591, 9970);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 9671, 9930);

                switch (f_10859_9679_9698(kind))
                {

                    case BinaryOperatorKind.Enum:
                    case BinaryOperatorKind.EnumAndUnderlying:
                    case BinaryOperatorKind.UnderlyingAndEnum:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10859, 9671, 9930);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 9903, 9915);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10859, 9671, 9930);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 9946, 9959);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10859, 9591, 9970);

                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10859_9679_9698(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind)
                {
                    var return_v = kind.OperandTypes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10859, 9679, 9698);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10859, 9591, 9970);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10859, 9591, 9970);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsEnum(this UnaryOperatorKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10859, 9982, 10125);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 10061, 10114);

                return f_10859_10068_10087(kind) == UnaryOperatorKind.Enum;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10859, 9982, 10125);

                Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
                f_10859_10068_10087(Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
                kind)
                {
                    var return_v = kind.OperandTypes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10859, 10068, 10087);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10859, 9982, 10125);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10859, 9982, 10125);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsIntegral(this BinaryOperatorKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10859, 10137, 11356);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 10221, 11316);

                switch (f_10859_10229_10248(kind))
                {

                    case BinaryOperatorKind.Int:
                    case BinaryOperatorKind.UInt:
                    case BinaryOperatorKind.Long:
                    case BinaryOperatorKind.ULong:
                    case BinaryOperatorKind.NInt:
                    case BinaryOperatorKind.NUInt:
                    case BinaryOperatorKind.Char:
                    case BinaryOperatorKind.Enum:
                    case BinaryOperatorKind.EnumAndUnderlying:
                    case BinaryOperatorKind.UnderlyingAndEnum:
                    case BinaryOperatorKind.Pointer:
                    case BinaryOperatorKind.PointerAndInt:
                    case BinaryOperatorKind.PointerAndUInt:
                    case BinaryOperatorKind.PointerAndLong:
                    case BinaryOperatorKind.PointerAndULong:
                    case BinaryOperatorKind.IntAndPointer:
                    case BinaryOperatorKind.UIntAndPointer:
                    case BinaryOperatorKind.LongAndPointer:
                    case BinaryOperatorKind.ULongAndPointer:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10859, 10221, 11316);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 11289, 11301);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10859, 10221, 11316);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 11332, 11345);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10859, 10137, 11356);

                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10859_10229_10248(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind)
                {
                    var return_v = kind.OperandTypes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10859, 10229, 10248);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10859, 10137, 11356);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10859, 10137, 11356);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsLogical(this BinaryOperatorKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10859, 11368, 11510);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 11451, 11499);

                return 0 != (kind & BinaryOperatorKind.Logical);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10859, 11368, 11510);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10859, 11368, 11510);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10859, 11368, 11510);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static BinaryOperatorKind OperandTypes(this BinaryOperatorKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10859, 11522, 11675);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 11622, 11664);

                return kind & BinaryOperatorKind.TypeMask;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10859, 11522, 11675);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10859, 11522, 11675);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10859, 11522, 11675);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsUserDefined(this BinaryOperatorKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10859, 11687, 11863);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 11774, 11852);

                return (kind & BinaryOperatorKind.TypeMask) == BinaryOperatorKind.UserDefined;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10859, 11687, 11863);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10859, 11687, 11863);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10859, 11687, 11863);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsShift(this BinaryOperatorKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10859, 11875, 12108);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 11956, 11998);

                BinaryOperatorKind
                type = f_10859_11982_11997(kind)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 12012, 12097);

                return type == BinaryOperatorKind.LeftShift || (DynAbs.Tracing.TraceSender.Expression_False(10859, 12019, 12096) || type == BinaryOperatorKind.RightShift);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10859, 11875, 12108);

                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10859_11982_11997(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind)
                {
                    var return_v = kind.Operator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10859, 11982, 11997);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10859, 11875, 12108);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10859, 11875, 12108);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ExpressionType ToExpressionType(this BinaryOperatorKind kind, bool isCompoundAssignment)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10859, 12120, 14917);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 12247, 14832) || true) && (isCompoundAssignment)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10859, 12247, 14832);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 12305, 13280);

                    switch (f_10859_12313_12328(kind))
                    {

                        case BinaryOperatorKind.Multiplication:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10859, 12305, 13280);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 12410, 12447);

                            return ExpressionType.MultiplyAssign;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10859, 12305, 13280);

                        case BinaryOperatorKind.Addition:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10859, 12305, 13280);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 12503, 12535);

                            return ExpressionType.AddAssign;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10859, 12305, 13280);

                        case BinaryOperatorKind.Subtraction:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10859, 12305, 13280);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 12594, 12631);

                            return ExpressionType.SubtractAssign;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10859, 12305, 13280);

                        case BinaryOperatorKind.Division:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10859, 12305, 13280);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 12687, 12722);

                            return ExpressionType.DivideAssign;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10859, 12305, 13280);

                        case BinaryOperatorKind.Remainder:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10859, 12305, 13280);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 12779, 12814);

                            return ExpressionType.ModuloAssign;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10859, 12305, 13280);

                        case BinaryOperatorKind.LeftShift:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10859, 12305, 13280);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 12871, 12909);

                            return ExpressionType.LeftShiftAssign;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10859, 12305, 13280);

                        case BinaryOperatorKind.RightShift:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10859, 12305, 13280);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 12967, 13006);

                            return ExpressionType.RightShiftAssign;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10859, 12305, 13280);

                        case BinaryOperatorKind.And:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10859, 12305, 13280);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 13057, 13089);

                            return ExpressionType.AndAssign;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10859, 12305, 13280);

                        case BinaryOperatorKind.Xor:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10859, 12305, 13280);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 13140, 13180);

                            return ExpressionType.ExclusiveOrAssign;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10859, 12305, 13280);

                        case BinaryOperatorKind.Or:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10859, 12305, 13280);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 13230, 13261);

                            return ExpressionType.OrAssign;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10859, 12305, 13280);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10859, 12247, 14832);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10859, 12247, 14832);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 13346, 14817);

                    switch (f_10859_13354_13369(kind))
                    {

                        case BinaryOperatorKind.Multiplication:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10859, 13346, 14817);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 13451, 13482);

                            return ExpressionType.Multiply;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10859, 13346, 14817);

                        case BinaryOperatorKind.Addition:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10859, 13346, 14817);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 13538, 13564);

                            return ExpressionType.Add;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10859, 13346, 14817);

                        case BinaryOperatorKind.Subtraction:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10859, 13346, 14817);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 13623, 13654);

                            return ExpressionType.Subtract;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10859, 13346, 14817);

                        case BinaryOperatorKind.Division:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10859, 13346, 14817);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 13710, 13739);

                            return ExpressionType.Divide;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10859, 13346, 14817);

                        case BinaryOperatorKind.Remainder:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10859, 13346, 14817);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 13796, 13825);

                            return ExpressionType.Modulo;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10859, 13346, 14817);

                        case BinaryOperatorKind.LeftShift:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10859, 13346, 14817);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 13882, 13914);

                            return ExpressionType.LeftShift;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10859, 13346, 14817);

                        case BinaryOperatorKind.RightShift:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10859, 13346, 14817);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 13972, 14005);

                            return ExpressionType.RightShift;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10859, 13346, 14817);

                        case BinaryOperatorKind.Equal:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10859, 13346, 14817);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 14058, 14086);

                            return ExpressionType.Equal;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10859, 13346, 14817);

                        case BinaryOperatorKind.NotEqual:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10859, 13346, 14817);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 14142, 14173);

                            return ExpressionType.NotEqual;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10859, 13346, 14817);

                        case BinaryOperatorKind.GreaterThan:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10859, 13346, 14817);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 14232, 14266);

                            return ExpressionType.GreaterThan;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10859, 13346, 14817);

                        case BinaryOperatorKind.LessThan:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10859, 13346, 14817);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 14322, 14353);

                            return ExpressionType.LessThan;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10859, 13346, 14817);

                        case BinaryOperatorKind.GreaterThanOrEqual:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10859, 13346, 14817);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 14419, 14460);

                            return ExpressionType.GreaterThanOrEqual;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10859, 13346, 14817);

                        case BinaryOperatorKind.LessThanOrEqual:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10859, 13346, 14817);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 14523, 14561);

                            return ExpressionType.LessThanOrEqual;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10859, 13346, 14817);

                        case BinaryOperatorKind.And:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10859, 13346, 14817);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 14612, 14638);

                            return ExpressionType.And;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10859, 13346, 14817);

                        case BinaryOperatorKind.Xor:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10859, 13346, 14817);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 14689, 14723);

                            return ExpressionType.ExclusiveOr;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10859, 13346, 14817);

                        case BinaryOperatorKind.Or:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10859, 13346, 14817);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 14773, 14798);

                            return ExpressionType.Or;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10859, 13346, 14817);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10859, 12247, 14832);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 14848, 14906);

                throw f_10859_14854_14905(f_10859_14889_14904(kind));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10859, 12120, 14917);

                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10859_12313_12328(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind)
                {
                    var return_v = kind.Operator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10859, 12313, 12328);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10859_13354_13369(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind)
                {
                    var return_v = kind.Operator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10859, 13354, 13369);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10859_14889_14904(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind)
                {
                    var return_v = kind.Operator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10859, 14889, 14904);
                    return return_v;
                }


                System.Exception
                f_10859_14854_14905(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10859, 14854, 14905);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10859, 12120, 14917);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10859, 12120, 14917);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ExpressionType ToExpressionType(this UnaryOperatorKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10859, 14929, 16042);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 15028, 16031);

                switch (f_10859_15036_15051(kind))
                {

                    case UnaryOperatorKind.PrefixIncrement:
                    case UnaryOperatorKind.PostfixIncrement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10859, 15028, 16031);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 15204, 15236);

                        return ExpressionType.Increment;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10859, 15028, 16031);

                    case UnaryOperatorKind.PostfixDecrement:
                    case UnaryOperatorKind.PrefixDecrement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10859, 15028, 16031);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 15375, 15407);

                        return ExpressionType.Decrement;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10859, 15028, 16031);

                    case UnaryOperatorKind.UnaryPlus:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10859, 15028, 16031);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 15461, 15493);

                        return ExpressionType.UnaryPlus;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10859, 15028, 16031);

                    case UnaryOperatorKind.UnaryMinus:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10859, 15028, 16031);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 15546, 15575);

                        return ExpressionType.Negate;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10859, 15028, 16031);

                    case UnaryOperatorKind.LogicalNegation:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10859, 15028, 16031);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 15633, 15659);

                        return ExpressionType.Not;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10859, 15028, 16031);

                    case UnaryOperatorKind.BitwiseComplement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10859, 15028, 16031);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 15719, 15756);

                        return ExpressionType.OnesComplement;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10859, 15028, 16031);

                    case UnaryOperatorKind.True:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10859, 15028, 16031);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 15803, 15832);

                        return ExpressionType.IsTrue;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10859, 15028, 16031);

                    case UnaryOperatorKind.False:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10859, 15028, 16031);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 15880, 15910);

                        return ExpressionType.IsFalse;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10859, 15028, 16031);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10859, 15028, 16031);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 15958, 16016);

                        throw f_10859_15964_16015(f_10859_15999_16014(kind));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10859, 15028, 16031);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10859, 14929, 16042);

                Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
                f_10859_15036_15051(Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
                kind)
                {
                    var return_v = kind.Operator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10859, 15036, 15051);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
                f_10859_15999_16014(Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
                kind)
                {
                    var return_v = kind.Operator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10859, 15999, 16014);
                    return return_v;
                }


                System.Exception
                f_10859_15964_16015(Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10859, 15964, 16015);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10859, 14929, 16042);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10859, 14929, 16042);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static string Dump(this BinaryOperatorKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10859, 16065, 16678);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 16145, 16173);

                var
                b = f_10859_16153_16172()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 16187, 16251) || true) && ((kind & BinaryOperatorKind.Lifted) != 0)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10859, 16187, 16251);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 16232, 16251);

                    f_10859_16232_16250(b, "Lifted");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10859, 16187, 16251);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 16265, 16331) || true) && ((kind & BinaryOperatorKind.Logical) != 0)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10859, 16265, 16331);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 16311, 16331);

                    f_10859_16311_16330(b, "Logical");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10859, 16265, 16331);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 16345, 16411) || true) && ((kind & BinaryOperatorKind.Checked) != 0)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10859, 16345, 16411);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 16391, 16411);

                    f_10859_16391_16410(b, "Checked");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10859, 16345, 16411);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 16425, 16471);

                var
                type = kind & BinaryOperatorKind.TypeMask
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 16485, 16526) || true) && (type != 0)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10859, 16485, 16526);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 16500, 16526);

                    f_10859_16500_16525(b, f_10859_16509_16524(type));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10859, 16485, 16526);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 16540, 16582);

                var
                op = kind & BinaryOperatorKind.OpMask
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 16596, 16633) || true) && (op != 0)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10859, 16596, 16633);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 16609, 16633);

                    f_10859_16609_16632(b, f_10859_16618_16631(op));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10859, 16596, 16633);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 16647, 16667);

                return f_10859_16654_16666(b);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10859, 16065, 16678);

                System.Text.StringBuilder
                f_10859_16153_16172()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10859, 16153, 16172);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10859_16232_16250(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10859, 16232, 16250);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10859_16311_16330(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10859, 16311, 16330);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10859_16391_16410(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10859, 16391, 16410);
                    return return_v;
                }


                string
                f_10859_16509_16524(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10859, 16509, 16524);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10859_16500_16525(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10859, 16500, 16525);
                    return return_v;
                }


                string
                f_10859_16618_16631(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10859, 16618, 16631);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10859_16609_16632(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10859, 16609, 16632);
                    return return_v;
                }


                string
                f_10859_16654_16666(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10859, 16654, 16666);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10859, 16065, 16678);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10859, 16065, 16678);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static string Dump(this UnaryOperatorKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10859, 16690, 17218);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 16769, 16797);

                var
                b = f_10859_16777_16796()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 16811, 16874) || true) && ((kind & UnaryOperatorKind.Lifted) != 0)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10859, 16811, 16874);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 16855, 16874);

                    f_10859_16855_16873(b, "Lifted");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10859, 16811, 16874);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 16888, 16953) || true) && ((kind & UnaryOperatorKind.Checked) != 0)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10859, 16888, 16953);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 16933, 16953);

                    f_10859_16933_16952(b, "Checked");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10859, 16888, 16953);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 16967, 17012);

                var
                type = kind & UnaryOperatorKind.TypeMask
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 17026, 17067) || true) && (type != 0)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10859, 17026, 17067);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 17041, 17067);

                    f_10859_17041_17066(b, f_10859_17050_17065(type));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10859, 17026, 17067);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 17081, 17122);

                var
                op = kind & UnaryOperatorKind.OpMask
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 17136, 17173) || true) && (op != 0)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10859, 17136, 17173);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 17149, 17173);

                    f_10859_17149_17172(b, f_10859_17158_17171(op));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10859, 17136, 17173);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10859, 17187, 17207);

                return f_10859_17194_17206(b);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10859, 16690, 17218);

                System.Text.StringBuilder
                f_10859_16777_16796()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10859, 16777, 16796);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10859_16855_16873(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10859, 16855, 16873);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10859_16933_16952(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10859, 16933, 16952);
                    return return_v;
                }


                string
                f_10859_17050_17065(Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10859, 17050, 17065);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10859_17041_17066(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10859, 17041, 17066);
                    return return_v;
                }


                string
                f_10859_17158_17171(Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10859, 17158, 17171);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10859_17149_17172(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10859, 17149, 17172);
                    return return_v;
                }


                string
                f_10859_17194_17206(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10859, 17194, 17206);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10859, 16690, 17218);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10859, 16690, 17218);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        //static OperatorKindExtensions()
        //{
        //    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10859, 510, 17233);
        //    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10859, 510, 17233);

        //    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10859, 510, 17233);
        //}

    }
}
