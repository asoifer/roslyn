// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.CodeAnalysis
{
    internal static class CommonAttributeDataExtensions
    {
        public static bool TryGetGuidAttributeValue(this AttributeData attrData, out string? guidString)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(588, 317, 858);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(588, 438, 786) || true) && (attrData.CommonConstructorArguments.Length == 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(588, 438, 786);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(588, 523, 592);

                    object?
                    value = f_588_539_574(attrData)[0].ValueInternal
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(588, 612, 771) || true) && (value == null || (DynAbs.Tracing.TraceSender.Expression_False(588, 616, 648) || value is string))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(588, 612, 771);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(588, 690, 718);

                        guidString = (string?)value;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(588, 740, 752);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(588, 612, 771);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(588, 438, 786);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(588, 802, 820);

                guidString = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(588, 834, 847);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(588, 317, 858);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                f_588_539_574(Microsoft.CodeAnalysis.AttributeData
                this_param)
                {
                    var return_v = this_param.CommonConstructorArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(588, 539, 574);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(588, 317, 858);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(588, 317, 858);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static CommonAttributeDataExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(588, 249, 865);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(588, 249, 865);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(588, 249, 865);
        }

    }
}
