// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;

namespace Roslyn.Utilities
{
    internal static class RoslynParallel
    {
        internal static readonly ParallelOptions DefaultParallelOptions;

        public static ParallelLoopResult For(int fromInclusive, int toExclusive, Action<int> body, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(362, 587, 1891);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(362, 739, 916);

                var
                parallelOptions = (DynAbs.Tracing.TraceSender.Conditional_F1(362, 761, 792) || ((cancellationToken.CanBeCanceled
                && DynAbs.Tracing.TraceSender.Conditional_F2(362, 812, 873)) || DynAbs.Tracing.TraceSender.Conditional_F3(362, 893, 915))) ? new ParallelOptions { CancellationToken = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => cancellationToken, 362, 812, 873) }
                : DefaultParallelOptions
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(362, 932, 1016);

                return f_362_939_1015(fromInclusive, toExclusive, parallelOptions, errorHandlingBody);

                void errorHandlingBody(int i)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(362, 1063, 1880);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(362, 1169, 1177);

                            f_362_1169_1176(body, i);
                        }
                        catch (Exception e) when (f_362_1240_1305(e, cancellationToken))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(362, 1214, 1403);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(362, 1347, 1384);

                            throw f_362_1353_1383();
                            DynAbs.Tracing.TraceSender.TraceExitCatch(362, 1214, 1403);
                        }
                        catch (OperationCanceledException e) when (cancellationToken.IsCancellationRequested && (DynAbs.Tracing.TraceSender.Expression_True(362, 1464, 1549) && f_362_1509_1528(e) != cancellationToken))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(362, 1421, 1865);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(362, 1738, 1787);

                            cancellationToken.ThrowIfCancellationRequested();
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(362, 1809, 1846);

                            throw f_362_1815_1845();
                            DynAbs.Tracing.TraceSender.TraceExitCatch(362, 1421, 1865);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitMethod(362, 1063, 1880);

                        int
                        f_362_1169_1176(System.Action<int>
                        this_param, int
                        obj)
                        {
                            this_param.Invoke(obj);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(362, 1169, 1176);
                            return 0;
                        }


                        bool
                        f_362_1240_1305(System.Exception
                        exception, System.Threading.CancellationToken
                        cancellationToken)
                        {
                            var return_v = FatalError.ReportAndPropagateUnlessCanceled(exception, cancellationToken);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(362, 1240, 1305);
                            return return_v;
                        }


                        System.Exception
                        f_362_1353_1383()
                        {
                            var return_v = ExceptionUtilities.Unreachable;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(362, 1353, 1383);
                            return return_v;
                        }


                        System.Threading.CancellationToken
                        f_362_1509_1528(System.OperationCanceledException
                        this_param)
                        {
                            var return_v = this_param.CancellationToken;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(362, 1509, 1528);
                            return return_v;
                        }


                        System.Exception
                        f_362_1815_1845()
                        {
                            var return_v = ExceptionUtilities.Unreachable;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(362, 1815, 1845);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(362, 1063, 1880);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(362, 1063, 1880);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(362, 587, 1891);

                System.Threading.Tasks.ParallelLoopResult
                f_362_939_1015(int
                fromInclusive, int
                toExclusive, System.Threading.Tasks.ParallelOptions
                parallelOptions, System.Action<int>
                body)
                {
                    var return_v = Parallel.For(fromInclusive, toExclusive, parallelOptions, body);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(362, 939, 1015);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(362, 587, 1891);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(362, 587, 1891);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static RoslynParallel()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(362, 347, 1898);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(362, 441, 487);
            DefaultParallelOptions = f_362_466_487(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(362, 347, 1898);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(362, 347, 1898);
        }


        static System.Threading.Tasks.ParallelOptions
        f_362_466_487()
        {
            var return_v = new System.Threading.Tasks.ParallelOptions();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(362, 466, 487);
            return return_v;
        }

    }
}
