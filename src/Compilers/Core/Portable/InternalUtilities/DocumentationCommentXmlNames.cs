// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;

namespace Roslyn.Utilities
{
    internal static class DocumentationCommentXmlNames
    {
        public const string
        CElementName = "c"
        ;

        public const string
        CodeElementName = "code"
        ;

        public const string
        CompletionListElementName = "completionlist"
        ;

        public const string
        DescriptionElementName = "description"
        ;

        public const string
        ExampleElementName = "example"
        ;

        public const string
        ExceptionElementName = "exception"
        ;

        public const string
        IncludeElementName = "include"
        ;

        public const string
        InheritdocElementName = "inheritdoc"
        ;

        public const string
        ItemElementName = "item"
        ;

        public const string
        ListElementName = "list"
        ;

        public const string
        ListHeaderElementName = "listheader"
        ;

        public const string
        ParaElementName = "para"
        ;

        public const string
        ParameterElementName = "param"
        ;

        public const string
        ParameterReferenceElementName = "paramref"
        ;

        public const string
        PermissionElementName = "permission"
        ;

        public const string
        PlaceholderElementName = "placeholder"
        ;

        public const string
        PreliminaryElementName = "preliminary"
        ;

        public const string
        RemarksElementName = "remarks"
        ;

        public const string
        ReturnsElementName = "returns"
        ;

        public const string
        SeeElementName = "see"
        ;

        public const string
        SeeAlsoElementName = "seealso"
        ;

        public const string
        SummaryElementName = "summary"
        ;

        public const string
        TermElementName = "term"
        ;

        public const string
        ThreadSafetyElementName = "threadsafety"
        ;

        public const string
        TypeParameterElementName = "typeparam"
        ;

        public const string
        TypeParameterReferenceElementName = "typeparamref"
        ;

        public const string
        ValueElementName = "value"
        ;

        public const string
        CrefAttributeName = "cref"
        ;

        public const string
        HrefAttributeName = "href"
        ;

        public const string
        FileAttributeName = "file"
        ;

        public const string
        InstanceAttributeName = "instance"
        ;

        public const string
        LangwordAttributeName = "langword"
        ;

        public const string
        NameAttributeName = "name"
        ;

        public const string
        PathAttributeName = "path"
        ;

        public const string
        StaticAttributeName = "static"
        ;

        public const string
        TypeAttributeName = "type"
        ;

        public static bool ElementEquals(string name1, string name2, bool fromVb = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(321, 2664, 2888);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(321, 2770, 2877);

                return f_321_2777_2876(name1, name2, (DynAbs.Tracing.TraceSender.Conditional_F1(321, 2805, 2811) || ((fromVb && DynAbs.Tracing.TraceSender.Conditional_F2(321, 2814, 2838)) || DynAbs.Tracing.TraceSender.Conditional_F3(321, 2841, 2875))) ? StringComparison.Ordinal : StringComparison.OrdinalIgnoreCase);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(321, 2664, 2888);

                bool
                f_321_2777_2876(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(321, 2777, 2876);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(321, 2664, 2888);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(321, 2664, 2888);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool AttributeEquals(string name1, string name2)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(321, 2900, 3059);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(321, 2987, 3048);

                return f_321_2994_3047(name1, name2, StringComparison.Ordinal);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(321, 2900, 3059);

                bool
                f_321_2994_3047(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(321, 2994, 3047);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(321, 2900, 3059);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(321, 2900, 3059);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static new bool Equals(object left, object right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(321, 3071, 3197);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(321, 3152, 3186);

                return f_321_3159_3185(left, right);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(321, 3071, 3197);

                bool
                f_321_3159_3185(object
                objA, object
                objB)
                {
                    var return_v = object.Equals(objA, objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(321, 3159, 3185);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(321, 3071, 3197);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(321, 3071, 3197);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static DocumentationCommentXmlNames()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(321, 357, 3204);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(321, 444, 462);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(321, 493, 517);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(321, 548, 592);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(321, 623, 661);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(321, 692, 722);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(321, 753, 787);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(321, 818, 848);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(321, 879, 915);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(321, 946, 970);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(321, 1001, 1025);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(321, 1056, 1092);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(321, 1123, 1147);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(321, 1178, 1208);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(321, 1239, 1281);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(321, 1312, 1348);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(321, 1379, 1417);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(321, 1448, 1486);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(321, 1517, 1547);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(321, 1578, 1608);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(321, 1639, 1661);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(321, 1692, 1722);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(321, 1753, 1783);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(321, 1814, 1838);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(321, 1869, 1909);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(321, 1940, 1978);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(321, 2009, 2059);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(321, 2090, 2116);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(321, 2149, 2175);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(321, 2206, 2232);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(321, 2263, 2289);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(321, 2320, 2354);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(321, 2385, 2419);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(321, 2450, 2476);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(321, 2507, 2533);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(321, 2564, 2594);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(321, 2625, 2651);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(321, 357, 3204);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(321, 357, 3204);
        }

    }
}
