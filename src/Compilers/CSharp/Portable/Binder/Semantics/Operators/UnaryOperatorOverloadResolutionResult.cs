// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Text;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed class UnaryOperatorOverloadResolutionResult
    {
        public readonly ArrayBuilder<UnaryOperatorAnalysisResult> Results;

        public UnaryOperatorOverloadResolutionResult()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10863, 523, 670);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10863, 503, 510);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10863, 594, 659);

                this.Results = f_10863_609_658(10);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10863, 523, 670);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10863, 523, 670);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10863, 523, 670);
            }
        }

        public bool AnyValid()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10863, 682, 939);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10863, 729, 899);
                    foreach (var result in f_10863_752_759_I(Results))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10863, 729, 899);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10863, 793, 884) || true) && (result.IsValid)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10863, 793, 884);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10863, 853, 865);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10863, 793, 884);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10863, 729, 899);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10863, 1, 171);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10863, 1, 171);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10863, 915, 928);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10863, 682, 939);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.UnaryOperatorAnalysisResult>
                f_10863_752_759_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.UnaryOperatorAnalysisResult>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10863, 752, 759);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10863, 682, 939);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10863, 682, 939);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool SingleValid()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10863, 951, 1376);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10863, 1001, 1023);

                bool
                oneValid = false
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10863, 1037, 1333);
                    foreach (var result in f_10863_1060_1067_I(Results))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10863, 1037, 1333);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10863, 1101, 1318) || true) && (result.IsValid)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10863, 1101, 1318);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10863, 1161, 1259) || true) && (oneValid)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10863, 1161, 1259);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10863, 1223, 1236);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10863, 1161, 1259);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10863, 1283, 1299);

                            oneValid = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10863, 1101, 1318);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10863, 1037, 1333);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10863, 1, 297);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10863, 1, 297);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10863, 1349, 1365);

                return oneValid;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10863, 951, 1376);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.UnaryOperatorAnalysisResult>
                f_10863_1060_1067_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.UnaryOperatorAnalysisResult>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10863, 1060, 1067);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10863, 951, 1376);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10863, 951, 1376);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public UnaryOperatorAnalysisResult Best
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10863, 1452, 2061);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10863, 1488, 1560);

                    UnaryOperatorAnalysisResult
                    best = default(UnaryOperatorAnalysisResult)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10863, 1578, 2014);
                        foreach (var result in f_10863_1601_1608_I(Results))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10863, 1578, 2014);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10863, 1650, 1995) || true) && (result.IsValid)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10863, 1650, 1995);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10863, 1718, 1932) || true) && (best.IsValid)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10863, 1718, 1932);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10863, 1861, 1905);

                                    return default(UnaryOperatorAnalysisResult);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10863, 1718, 1932);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10863, 1958, 1972);

                                best = result;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10863, 1650, 1995);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10863, 1578, 2014);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10863, 1, 437);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10863, 1, 437);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10863, 2034, 2046);

                    return best;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10863, 1452, 2061);

                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.UnaryOperatorAnalysisResult>
                    f_10863_1601_1608_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.UnaryOperatorAnalysisResult>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10863, 1601, 1608);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10863, 1388, 2072);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10863, 1388, 2072);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public string Dump()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10863, 2095, 3163);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10863, 2140, 2290) || true) && (f_10863_2144_2157(Results) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10863, 2140, 2290);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10863, 2196, 2275);

                    return "Overload resolution failed because there were no candidate operators.";
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10863, 2140, 2290);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10863, 2306, 2335);

                var
                sb = f_10863_2315_2334()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10863, 2349, 2871) || true) && (this.Best.HasValue)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10863, 2349, 2871);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10863, 2405, 2496);

                    f_10863_2405_2495(sb, "Overload resolution succeeded and chose " + this.Best.Signature.ToString());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10863, 2349, 2871);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10863, 2349, 2871);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10863, 2530, 2871) || true) && (f_10863_2534_2582(this, OperatorAnalysisResultKind.Applicable) > 1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10863, 2530, 2871);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10863, 2620, 2710);

                        f_10863_2620_2709(sb, "Overload resolution failed because of ambiguous possible best operators.");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10863, 2530, 2871);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10863, 2530, 2871);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10863, 2776, 2856);

                        f_10863_2776_2855(sb, "Overload resolution failed because no operator was applicable.");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10863, 2530, 2871);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10863, 2349, 2871);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10863, 2887, 2922);

                f_10863_2887_2921(
                            sb, "Detailed results:");
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10863, 2936, 3115);
                    foreach (var result in f_10863_2959_2966_I(Results))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10863, 2936, 3115);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10863, 3000, 3100);

                        f_10863_3000_3099(sb, "operator: {0} reason: {1}\n", result.Signature.ToString(), f_10863_3076_3098(result.Kind));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10863, 2936, 3115);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10863, 1, 180);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10863, 1, 180);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10863, 3131, 3152);

                return f_10863_3138_3151(sb);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10863, 2095, 3163);

                int
                f_10863_2144_2157(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.UnaryOperatorAnalysisResult>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10863, 2144, 2157);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10863_2315_2334()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10863, 2315, 2334);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10863_2405_2495(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10863, 2405, 2495);
                    return return_v;
                }


                int
                f_10863_2534_2582(Microsoft.CodeAnalysis.CSharp.UnaryOperatorOverloadResolutionResult
                this_param, Microsoft.CodeAnalysis.CSharp.OperatorAnalysisResultKind
                kind)
                {
                    var return_v = this_param.CountKind(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10863, 2534, 2582);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10863_2620_2709(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10863, 2620, 2709);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10863_2776_2855(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10863, 2776, 2855);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10863_2887_2921(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10863, 2887, 2921);
                    return return_v;
                }


                string
                f_10863_3076_3098(Microsoft.CodeAnalysis.CSharp.OperatorAnalysisResultKind
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10863, 3076, 3098);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10863_3000_3099(System.Text.StringBuilder
                this_param, string
                format, string
                arg0, string
                arg1)
                {
                    var return_v = this_param.AppendFormat(format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10863, 3000, 3099);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.UnaryOperatorAnalysisResult>
                f_10863_2959_2966_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.UnaryOperatorAnalysisResult>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10863, 2959, 2966);
                    return return_v;
                }


                string
                f_10863_3138_3151(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10863, 3138, 3151);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10863, 2095, 3163);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10863, 2095, 3163);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private int CountKind(OperatorAnalysisResultKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10863, 3175, 3522);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10863, 3254, 3268);

                int
                count = 0
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10863, 3291, 3296);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10863, 3298, 3320);
                    for (int
        i = 0
        ,
        n = f_10863_3302_3320(this.Results)
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10863, 3282, 3482) || true) && (i < n)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10863, 3329, 3332)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10863, 3282, 3482))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10863, 3282, 3482);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10863, 3366, 3467) || true) && (this.Results[i].Kind == kind)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10863, 3366, 3467);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10863, 3440, 3448);

                            count++;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10863, 3366, 3467);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10863, 1, 201);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10863, 1, 201);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10863, 3498, 3511);

                return count;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10863, 3175, 3522);

                int
                f_10863_3302_3320(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.UnaryOperatorAnalysisResult>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10863, 3302, 3320);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10863, 3175, 3522);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10863, 3175, 3522);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static UnaryOperatorOverloadResolutionResult GetInstance()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10863, 3572, 3696);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10863, 3662, 3685);

                return f_10863_3669_3684(Pool);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10863, 3572, 3696);

                Microsoft.CodeAnalysis.CSharp.UnaryOperatorOverloadResolutionResult
                f_10863_3669_3684(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.CSharp.UnaryOperatorOverloadResolutionResult>
                this_param)
                {
                    var return_v = this_param.Allocate();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10863, 3669, 3684);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10863, 3572, 3696);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10863, 3572, 3696);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void Free()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10863, 3708, 3813);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10863, 3751, 3772);

                f_10863_3751_3771(this.Results);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10863, 3786, 3802);

                f_10863_3786_3801(Pool, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10863, 3708, 3813);

                int
                f_10863_3751_3771(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.UnaryOperatorAnalysisResult>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10863, 3751, 3771);
                    return 0;
                }


                int
                f_10863_3786_3801(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.CSharp.UnaryOperatorOverloadResolutionResult>
                this_param, Microsoft.CodeAnalysis.CSharp.UnaryOperatorOverloadResolutionResult
                obj)
                {
                    this_param.Free(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10863, 3786, 3801);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10863, 3708, 3813);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10863, 3708, 3813);
            }
        }

        public static readonly ObjectPool<UnaryOperatorOverloadResolutionResult> Pool;

        private static ObjectPool<UnaryOperatorOverloadResolutionResult> CreatePool()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10863, 4099, 4430);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10863, 4201, 4263);

                ObjectPool<UnaryOperatorOverloadResolutionResult>
                pool = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10863, 4277, 4393);

                pool = f_10863_4284_4392(() => new UnaryOperatorOverloadResolutionResult(), 10);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10863, 4407, 4419);

                return pool;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10863, 4099, 4430);

                Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.CSharp.UnaryOperatorOverloadResolutionResult>
                f_10863_4284_4392(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.CSharp.UnaryOperatorOverloadResolutionResult>.Factory
                factory, int
                size)
                {
                    var return_v = new Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.CSharp.UnaryOperatorOverloadResolutionResult>(factory, size);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10863, 4284, 4392);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10863, 4099, 4430);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10863, 4099, 4430);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static UnaryOperatorOverloadResolutionResult()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10863, 369, 4459);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10863, 4067, 4086);
            Pool = f_10863_4074_4086(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10863, 369, 4459);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10863, 369, 4459);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10863, 369, 4459);

        Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.UnaryOperatorAnalysisResult>
        f_10863_609_658(int
        size)
        {
            var return_v = new Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.UnaryOperatorAnalysisResult>(size);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10863, 609, 658);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.CSharp.UnaryOperatorOverloadResolutionResult>
        f_10863_4074_4086()
        {
            var return_v = CreatePool();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10863, 4074, 4086);
            return return_v;
        }

    }
}
