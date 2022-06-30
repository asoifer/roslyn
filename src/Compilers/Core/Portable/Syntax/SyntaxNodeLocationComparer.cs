// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis
{
    internal class SyntaxNodeLocationComparer : IComparer<SyntaxNode>
    {
        private readonly Compilation _compilation;

        public SyntaxNodeLocationComparer(Compilation compilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(691, 485, 606);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(691, 460, 472);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(691, 568, 595);

                _compilation = compilation;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(691, 485, 606);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(691, 485, 606);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(691, 485, 606);
            }
        }

        public int Compare(SyntaxNode? x, SyntaxNode? y)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(691, 616, 1108);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(691, 689, 1097) || true) && (x is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(691, 689, 1097);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(691, 736, 819) || true) && (y is null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(691, 736, 819);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(691, 791, 800);

                        return 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(691, 736, 819);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(691, 839, 849);

                    return -1;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(691, 689, 1097);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(691, 689, 1097);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(691, 883, 1097) || true) && (y is null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(691, 883, 1097);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(691, 930, 939);

                        return 1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(691, 883, 1097);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(691, 883, 1097);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(691, 1005, 1082);

                        return f_691_1012_1081(_compilation, f_691_1048_1063(x), f_691_1065_1080(y));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(691, 883, 1097);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(691, 689, 1097);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(691, 616, 1108);

                Microsoft.CodeAnalysis.Location
                f_691_1048_1063(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.GetLocation();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(691, 1048, 1063);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_691_1065_1080(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.GetLocation();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(691, 1065, 1080);
                    return return_v;
                }


                int
                f_691_1012_1081(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.Location
                loc1, Microsoft.CodeAnalysis.Location
                loc2)
                {
                    var return_v = this_param.CompareSourceLocations(loc1, loc2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(691, 1012, 1081);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(691, 616, 1108);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(691, 616, 1108);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SyntaxNodeLocationComparer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(691, 349, 1115);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(691, 349, 1115);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(691, 349, 1115);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(691, 349, 1115);
    }
}
