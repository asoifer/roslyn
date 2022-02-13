// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    /// <summary>
    /// Used by symbol implementations (source and metadata) to represent the value
    /// that was mapped from, or will be mapped to a [NullableContext] attribute.
    /// </summary>
    internal enum NullableContextKind : byte
    {
        /// <summary>
        /// Uninitialized state
        /// </summary>
        Unknown = 0,

        /// <summary>
        /// No [NullableContext] attribute
        /// </summary>
        None,

        /// <summary>
        /// [NullableContext(0)]
        /// </summary>
        Oblivious,

        /// <summary>
        /// [NullableContext(1)]
        /// </summary>
        NotAnnotated,

        /// <summary>
        /// [NullableContext(2)]
        /// </summary>
        Annotated,
    }
    internal static class NullableContextExtensions
    {
        internal static bool TryGetByte(this NullableContextKind kind, out byte? value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10136, 1167, 2174);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10136, 1271, 2163);

                switch (kind)
                {

                    case NullableContextKind.Unknown:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10136, 1271, 2163);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10136, 1372, 1385);

                        value = null;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10136, 1407, 1420);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10136, 1271, 2163);

                    case NullableContextKind.None:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10136, 1271, 2163);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10136, 1490, 1503);

                        value = null;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10136, 1525, 1537);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10136, 1271, 2163);

                    case NullableContextKind.Oblivious:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10136, 1271, 2163);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10136, 1612, 1673);

                        value = NullableAnnotationExtensions.ObliviousAttributeValue;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10136, 1695, 1707);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10136, 1271, 2163);

                    case NullableContextKind.NotAnnotated:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10136, 1271, 2163);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10136, 1785, 1849);

                        value = NullableAnnotationExtensions.NotAnnotatedAttributeValue;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10136, 1871, 1883);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10136, 1271, 2163);

                    case NullableContextKind.Annotated:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10136, 1271, 2163);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10136, 1958, 2019);

                        value = NullableAnnotationExtensions.AnnotatedAttributeValue;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10136, 2041, 2053);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10136, 1271, 2163);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10136, 1271, 2163);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10136, 2101, 2148);

                        throw f_10136_2107_2147(kind);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10136, 1271, 2163);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10136, 1167, 2174);

                System.Exception
                f_10136_2107_2147(Microsoft.CodeAnalysis.CSharp.Symbols.NullableContextKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10136, 2107, 2147);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10136, 1167, 2174);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10136, 1167, 2174);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static NullableContextKind ToNullableContextFlags(this byte? value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10136, 2186, 2931);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10136, 2287, 2920);

                switch (value)
                {

                    case null:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10136, 2287, 2920);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10136, 2366, 2398);

                        return NullableContextKind.None;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10136, 2287, 2920);

                    case NullableAnnotationExtensions.ObliviousAttributeValue:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10136, 2287, 2920);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10136, 2496, 2533);

                        return NullableContextKind.Oblivious;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10136, 2287, 2920);

                    case NullableAnnotationExtensions.NotAnnotatedAttributeValue:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10136, 2287, 2920);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10136, 2634, 2674);

                        return NullableContextKind.NotAnnotated;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10136, 2287, 2920);

                    case NullableAnnotationExtensions.AnnotatedAttributeValue:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10136, 2287, 2920);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10136, 2772, 2809);

                        return NullableContextKind.Annotated;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10136, 2287, 2920);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10136, 2287, 2920);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10136, 2857, 2905);

                        throw f_10136_2863_2904(value);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10136, 2287, 2920);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10136, 2186, 2931);

                System.Exception
                f_10136_2863_2904(byte?
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10136, 2863, 2904);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10136, 2186, 2931);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10136, 2186, 2931);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static NullableContextExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10136, 1103, 2938);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10136, 1103, 2938);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10136, 1103, 2938);
        }

    }
}
