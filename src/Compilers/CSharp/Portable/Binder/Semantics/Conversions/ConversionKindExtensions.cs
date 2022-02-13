// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;
using static Microsoft.CodeAnalysis.CSharp.ConversionKind;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal static class ConversionKindExtensions
    {
        public static bool IsDynamic(this ConversionKind conversionKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10841, 581, 759);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10841, 670, 748);

                return conversionKind == ImplicitDynamic || (DynAbs.Tracing.TraceSender.Expression_False(10841, 677, 747) || conversionKind == ExplicitDynamic);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10841, 581, 759);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10841, 581, 759);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10841, 581, 759);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsImplicitConversion(this ConversionKind conversionKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10841, 836, 2878);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10841, 936, 2867);

                switch (conversionKind)
                {

                    case NoConversion:
                    case UnsetConversionKind:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10841, 936, 2867);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10841, 1075, 1088);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10841, 936, 2867);

                    case Identity:
                    case ImplicitNumeric:
                    case ImplicitTupleLiteral:
                    case ImplicitTuple:
                    case ImplicitEnumeration:
                    case ImplicitThrow:
                    case ImplicitNullable:
                    case NullLiteral:
                    case DefaultLiteral:
                    case ImplicitReference:
                    case Boxing:
                    case ImplicitDynamic:
                    case ImplicitConstant:
                    case ImplicitUserDefined:
                    case AnonymousFunction:
                    case ConversionKind.MethodGroup:
                    case ImplicitPointerToVoid:
                    case ImplicitNullToPointer:
                    case InterpolatedString:
                    case SwitchExpression:
                    case ConditionalExpression:
                    case Deconstruction:
                    case StackAllocToPointerType:
                    case StackAllocToSpanType:
                    case ImplicitPointer:
                    case ObjectCreation:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10841, 936, 2867);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10841, 2164, 2176);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10841, 936, 2867);

                    case ExplicitNumeric:
                    case ExplicitTuple:
                    case ExplicitTupleLiteral:
                    case ExplicitEnumeration:
                    case ExplicitNullable:
                    case ExplicitReference:
                    case Unboxing:
                    case ExplicitDynamic:
                    case ExplicitUserDefined:
                    case ExplicitPointerToPointer:
                    case ExplicitPointerToInteger:
                    case ExplicitIntegerToPointer:
                    case IntPtr:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10841, 936, 2867);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10841, 2732, 2745);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10841, 936, 2867);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10841, 936, 2867);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10841, 2795, 2852);

                        throw f_10841_2801_2851(conversionKind);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10841, 936, 2867);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10841, 836, 2878);

                System.Exception
                f_10841_2801_2851(Microsoft.CodeAnalysis.CSharp.ConversionKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10841, 2801, 2851);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10841, 836, 2878);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10841, 836, 2878);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsUserDefinedConversion(this ConversionKind conversionKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10841, 2958, 3308);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10841, 3061, 3297);

                switch (conversionKind)
                {

                    case ImplicitUserDefined:
                    case ExplicitUserDefined:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10841, 3061, 3297);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10841, 3207, 3219);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10841, 3061, 3297);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10841, 3061, 3297);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10841, 3269, 3282);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10841, 3061, 3297);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10841, 2958, 3308);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10841, 2958, 3308);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10841, 2958, 3308);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsPointerConversion(this ConversionKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10841, 3320, 3831);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10841, 3409, 3820);

                switch (kind)
                {

                    case ImplicitPointerToVoid:
                    case ExplicitPointerToPointer:
                    case ExplicitPointerToInteger:
                    case ExplicitIntegerToPointer:
                    case ImplicitNullToPointer:
                    case ImplicitPointer:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10841, 3409, 3820);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10841, 3732, 3744);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10841, 3409, 3820);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10841, 3409, 3820);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10841, 3792, 3805);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10841, 3409, 3820);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10841, 3320, 3831);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10841, 3320, 3831);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10841, 3320, 3831);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ConversionKindExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10841, 518, 3838);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10841, 518, 3838);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10841, 518, 3838);
        }

    }
}
