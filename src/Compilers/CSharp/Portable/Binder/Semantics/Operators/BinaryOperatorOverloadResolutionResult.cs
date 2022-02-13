// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Text;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed class BinaryOperatorOverloadResolutionResult
    {
        public readonly ArrayBuilder<BinaryOperatorAnalysisResult> Results;

        private BinaryOperatorOverloadResolutionResult()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10854, 525, 675);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10854, 505, 512);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10854, 598, 664);

                this.Results = f_10854_613_663(10);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10854, 525, 675);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10854, 525, 675);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10854, 525, 675);
            }
        }

        public bool AnyValid()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10854, 687, 944);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10854, 734, 904);
                    foreach (var result in f_10854_757_764_I(Results))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10854, 734, 904);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10854, 798, 889) || true) && (result.IsValid)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10854, 798, 889);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10854, 858, 870);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10854, 798, 889);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10854, 734, 904);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10854, 1, 171);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10854, 1, 171);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10854, 920, 933);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10854, 687, 944);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorAnalysisResult>
                f_10854_757_764_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorAnalysisResult>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10854, 757, 764);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10854, 687, 944);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10854, 687, 944);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool SingleValid()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10854, 956, 1381);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10854, 1006, 1028);

                bool
                oneValid = false
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10854, 1042, 1338);
                    foreach (var result in f_10854_1065_1072_I(Results))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10854, 1042, 1338);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10854, 1106, 1323) || true) && (result.IsValid)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10854, 1106, 1323);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10854, 1166, 1264) || true) && (oneValid)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10854, 1166, 1264);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10854, 1228, 1241);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10854, 1166, 1264);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10854, 1288, 1304);

                            oneValid = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10854, 1106, 1323);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10854, 1042, 1338);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10854, 1, 297);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10854, 1, 297);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10854, 1354, 1370);

                return oneValid;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10854, 956, 1381);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorAnalysisResult>
                f_10854_1065_1072_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorAnalysisResult>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10854, 1065, 1072);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10854, 956, 1381);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10854, 956, 1381);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BinaryOperatorAnalysisResult Best
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10854, 1458, 2070);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10854, 1494, 1568);

                    BinaryOperatorAnalysisResult
                    best = default(BinaryOperatorAnalysisResult)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10854, 1586, 2023);
                        foreach (var result in f_10854_1609_1616_I(Results))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10854, 1586, 2023);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10854, 1658, 2004) || true) && (result.IsValid)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10854, 1658, 2004);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10854, 1726, 1941) || true) && (best.IsValid)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10854, 1726, 1941);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10854, 1869, 1914);

                                    return default(BinaryOperatorAnalysisResult);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10854, 1726, 1941);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10854, 1967, 1981);

                                best = result;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10854, 1658, 2004);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10854, 1586, 2023);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10854, 1, 438);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10854, 1, 438);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10854, 2043, 2055);

                    return best;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10854, 1458, 2070);

                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorAnalysisResult>
                    f_10854_1609_1616_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorAnalysisResult>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10854, 1609, 1616);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10854, 1393, 2081);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10854, 1393, 2081);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public string Dump()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10854, 2104, 3172);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10854, 2149, 2299) || true) && (f_10854_2153_2166(Results) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10854, 2149, 2299);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10854, 2205, 2284);

                    return "Overload resolution failed because there were no candidate operators.";
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10854, 2149, 2299);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10854, 2315, 2344);

                var
                sb = f_10854_2324_2343()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10854, 2358, 2880) || true) && (this.Best.HasValue)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10854, 2358, 2880);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10854, 2414, 2505);

                    f_10854_2414_2504(sb, "Overload resolution succeeded and chose " + this.Best.Signature.ToString());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10854, 2358, 2880);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10854, 2358, 2880);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10854, 2539, 2880) || true) && (f_10854_2543_2591(this, OperatorAnalysisResultKind.Applicable) > 1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10854, 2539, 2880);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10854, 2629, 2719);

                        f_10854_2629_2718(sb, "Overload resolution failed because of ambiguous possible best operators.");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10854, 2539, 2880);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10854, 2539, 2880);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10854, 2785, 2865);

                        f_10854_2785_2864(sb, "Overload resolution failed because no operator was applicable.");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10854, 2539, 2880);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10854, 2358, 2880);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10854, 2896, 2931);

                f_10854_2896_2930(
                            sb, "Detailed results:");
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10854, 2945, 3124);
                    foreach (var result in f_10854_2968_2975_I(Results))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10854, 2945, 3124);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10854, 3009, 3109);

                        f_10854_3009_3108(sb, "operator: {0} reason: {1}\n", result.Signature.ToString(), f_10854_3085_3107(result.Kind));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10854, 2945, 3124);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10854, 1, 180);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10854, 1, 180);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10854, 3140, 3161);

                return f_10854_3147_3160(sb);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10854, 2104, 3172);

                int
                f_10854_2153_2166(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorAnalysisResult>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10854, 2153, 2166);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10854_2324_2343()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10854, 2324, 2343);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10854_2414_2504(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10854, 2414, 2504);
                    return return_v;
                }


                int
                f_10854_2543_2591(Microsoft.CodeAnalysis.CSharp.BinaryOperatorOverloadResolutionResult
                this_param, Microsoft.CodeAnalysis.CSharp.OperatorAnalysisResultKind
                kind)
                {
                    var return_v = this_param.CountKind(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10854, 2543, 2591);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10854_2629_2718(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10854, 2629, 2718);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10854_2785_2864(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10854, 2785, 2864);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10854_2896_2930(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10854, 2896, 2930);
                    return return_v;
                }


                string
                f_10854_3085_3107(Microsoft.CodeAnalysis.CSharp.OperatorAnalysisResultKind
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10854, 3085, 3107);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10854_3009_3108(System.Text.StringBuilder
                this_param, string
                format, string
                arg0, string
                arg1)
                {
                    var return_v = this_param.AppendFormat(format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10854, 3009, 3108);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorAnalysisResult>
                f_10854_2968_2975_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorAnalysisResult>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10854, 2968, 2975);
                    return return_v;
                }


                string
                f_10854_3147_3160(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10854, 3147, 3160);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10854, 2104, 3172);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10854, 2104, 3172);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private int CountKind(OperatorAnalysisResultKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10854, 3184, 3531);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10854, 3263, 3277);

                int
                count = 0
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10854, 3300, 3305);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10854, 3307, 3329);
                    for (int
        i = 0
        ,
        n = f_10854_3311_3329(this.Results)
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10854, 3291, 3491) || true) && (i < n)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10854, 3338, 3341)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10854, 3291, 3491))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10854, 3291, 3491);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10854, 3375, 3476) || true) && (this.Results[i].Kind == kind)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10854, 3375, 3476);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10854, 3449, 3457);

                            count++;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10854, 3375, 3476);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10854, 1, 201);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10854, 1, 201);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10854, 3507, 3520);

                return count;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10854, 3184, 3531);

                int
                f_10854_3311_3329(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorAnalysisResult>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10854, 3311, 3329);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10854, 3184, 3531);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10854, 3184, 3531);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static BinaryOperatorOverloadResolutionResult GetInstance()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10854, 3581, 3706);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10854, 3672, 3695);

                return f_10854_3679_3694(Pool);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10854, 3581, 3706);

                Microsoft.CodeAnalysis.CSharp.BinaryOperatorOverloadResolutionResult
                f_10854_3679_3694(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.CSharp.BinaryOperatorOverloadResolutionResult>
                this_param)
                {
                    var return_v = this_param.Allocate();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10854, 3679, 3694);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10854, 3581, 3706);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10854, 3581, 3706);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void Free()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10854, 3718, 3810);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10854, 3761, 3769);

                f_10854_3761_3768(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10854, 3783, 3799);

                f_10854_3783_3798(Pool, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10854, 3718, 3810);

                int
                f_10854_3761_3768(Microsoft.CodeAnalysis.CSharp.BinaryOperatorOverloadResolutionResult
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10854, 3761, 3768);
                    return 0;
                }


                int
                f_10854_3783_3798(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.CSharp.BinaryOperatorOverloadResolutionResult>
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorOverloadResolutionResult
                obj)
                {
                    this_param.Free(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10854, 3783, 3798);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10854, 3718, 3810);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10854, 3718, 3810);
            }
        }

        public void Clear()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10854, 3822, 3898);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10854, 3866, 3887);

                f_10854_3866_3886(this.Results);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10854, 3822, 3898);

                int
                f_10854_3866_3886(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorAnalysisResult>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10854, 3866, 3886);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10854, 3822, 3898);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10854, 3822, 3898);
            }
        }

        public static readonly ObjectPool<BinaryOperatorOverloadResolutionResult> Pool;

        private static ObjectPool<BinaryOperatorOverloadResolutionResult> CreatePool()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10854, 4016, 4351);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10854, 4119, 4182);

                ObjectPool<BinaryOperatorOverloadResolutionResult>
                pool = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10854, 4196, 4314);

                pool = f_10854_4203_4313(() => new BinaryOperatorOverloadResolutionResult(), 10);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10854, 4328, 4340);

                return pool;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10854, 4016, 4351);

                Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.CSharp.BinaryOperatorOverloadResolutionResult>
                f_10854_4203_4313(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.CSharp.BinaryOperatorOverloadResolutionResult>.Factory
                factory, int
                size)
                {
                    var return_v = new Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.CSharp.BinaryOperatorOverloadResolutionResult>(factory, size);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10854, 4203, 4313);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10854, 4016, 4351);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10854, 4016, 4351);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static BinaryOperatorOverloadResolutionResult()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10854, 369, 4380);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10854, 3984, 4003);
            Pool = f_10854_3991_4003(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10854, 369, 4380);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10854, 369, 4380);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10854, 369, 4380);

        Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorAnalysisResult>
        f_10854_613_663(int
        size)
        {
            var return_v = new Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorAnalysisResult>(size);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10854, 613, 663);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.CSharp.BinaryOperatorOverloadResolutionResult>
        f_10854_3991_4003()
        {
            var return_v = CreatePool();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10854, 3991, 4003);
            return return_v;
        }

    }
}
