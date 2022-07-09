// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
    internal sealed class AssemblyIdentityMap<TValue>
    {
        private readonly Dictionary<string, OneOrMany<KeyValuePair<AssemblyIdentity, TValue>>> _map;

        public AssemblyIdentityMap()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(424, 862, 1052);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(424, 845, 849);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(424, 915, 1041);

                _map = f_424_922_1040(f_424_996_1039());
                DynAbs.Tracing.TraceSender.TraceExitConstructor(424, 862, 1052);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(424, 862, 1052);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(424, 862, 1052);
            }
        }

        public bool Contains(AssemblyIdentity identity, bool allowHigherVersion = true)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(424, 1064, 1266);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(424, 1168, 1181);

                TValue
                value
                = default(TValue);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(424, 1195, 1255);

                return f_424_1202_1254(this, identity, out value, allowHigherVersion);
                DynAbs.Tracing.TraceSender.TraceExitMethod(424, 1064, 1266);

                bool
                f_424_1202_1254(Microsoft.CodeAnalysis.AssemblyIdentityMap<TValue>
                this_param, Microsoft.CodeAnalysis.AssemblyIdentity
                identity, out TValue
                value, bool
                allowHigherVersion)
                {
                    var return_v = this_param.TryGetValue(identity, out value, allowHigherVersion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(424, 1202, 1254);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(424, 1064, 1266);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(424, 1064, 1266);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool TryGetValue(AssemblyIdentity identity, out TValue value, bool allowHigherVersion = true)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(424, 1278, 2960);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(424, 1403, 1462);

                OneOrMany<KeyValuePair<AssemblyIdentity, TValue>>
                sameName
                = default(OneOrMany<KeyValuePair<AssemblyIdentity, TValue>>);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(424, 1476, 2882) || true) && (f_424_1480_1525(_map, f_424_1497_1510(identity), out sameName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(424, 1476, 2882);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(424, 1559, 1594);

                    int
                    minHigherVersionCandidate = -1
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(424, 1623, 1628);

                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(424, 1614, 2668) || true) && (i < sameName.Count)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(424, 1650, 1653)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(424, 1614, 2668))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(424, 1614, 2668);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(424, 1695, 1746);

                            AssemblyIdentity
                            currentIdentity = sameName[i].Key
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(424, 1770, 2649) || true) && (f_424_1774_1845(currentIdentity, identity))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(424, 1770, 2649);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(424, 1895, 2095) || true) && (f_424_1899_1922(currentIdentity) == f_424_1926_1942(identity))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(424, 1895, 2095);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(424, 2000, 2026);

                                    value = sameName[i].Value;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(424, 2056, 2068);

                                    return true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(424, 1895, 2095);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(424, 2208, 2371) || true) && (!allowHigherVersion || (DynAbs.Tracing.TraceSender.Expression_False(424, 2212, 2277) || f_424_2235_2258(currentIdentity) < f_424_2261_2277(identity)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(424, 2208, 2371);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(424, 2335, 2344);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(424, 2208, 2371);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(424, 2399, 2626) || true) && (minHigherVersionCandidate == -1 || (DynAbs.Tracing.TraceSender.Expression_False(424, 2403, 2511) || f_424_2438_2461(currentIdentity) < f_424_2464_2511(sameName[minHigherVersionCandidate].Key)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(424, 2399, 2626);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(424, 2569, 2599);

                                    minHigherVersionCandidate = i;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(424, 2399, 2626);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(424, 1770, 2649);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(424, 1, 1055);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(424, 1, 1055);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(424, 2688, 2867) || true) && (minHigherVersionCandidate >= 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(424, 2688, 2867);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(424, 2764, 2814);

                        value = sameName[minHigherVersionCandidate].Value;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(424, 2836, 2848);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(424, 2688, 2867);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(424, 1476, 2882);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(424, 2898, 2922);

                value = default(TValue);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(424, 2936, 2949);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(424, 1278, 2960);

                string
                f_424_1497_1510(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(424, 1497, 1510);
                    return return_v;
                }


                bool
                f_424_1480_1525(System.Collections.Generic.Dictionary<string, Roslyn.Utilities.OneOrMany<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.AssemblyIdentity, TValue>>>
                this_param, string
                key, out Roslyn.Utilities.OneOrMany<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.AssemblyIdentity, TValue>>
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(424, 1480, 1525);
                    return return_v;
                }


                bool
                f_424_1774_1845(Microsoft.CodeAnalysis.AssemblyIdentity
                x, Microsoft.CodeAnalysis.AssemblyIdentity
                y)
                {
                    var return_v = AssemblyIdentity.EqualIgnoringNameAndVersion(x, y);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(424, 1774, 1845);
                    return return_v;
                }


                System.Version
                f_424_1899_1922(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.Version;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(424, 1899, 1922);
                    return return_v;
                }


                System.Version
                f_424_1926_1942(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.Version;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(424, 1926, 1942);
                    return return_v;
                }


                System.Version
                f_424_2235_2258(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.Version;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(424, 2235, 2258);
                    return return_v;
                }


                System.Version
                f_424_2261_2277(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.Version;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(424, 2261, 2277);
                    return return_v;
                }


                System.Version
                f_424_2438_2461(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.Version;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(424, 2438, 2461);
                    return return_v;
                }


                System.Version
                f_424_2464_2511(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.Version;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(424, 2464, 2511);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(424, 1278, 2960);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(424, 1278, 2960);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool TryGetValue(AssemblyIdentity identity, out TValue value, Func<Version, Version, TValue, bool> comparer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(424, 2972, 3847);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(424, 3112, 3171);

                OneOrMany<KeyValuePair<AssemblyIdentity, TValue>>
                sameName
                = default(OneOrMany<KeyValuePair<AssemblyIdentity, TValue>>);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(424, 3185, 3769) || true) && (f_424_3189_3234(_map, f_424_3206_3219(identity), out sameName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(424, 3185, 3769);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(424, 3277, 3282);
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(424, 3268, 3754) || true) && (i < sameName.Count)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(424, 3304, 3307)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(424, 3268, 3754))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(424, 3268, 3754);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(424, 3349, 3400);

                            AssemblyIdentity
                            currentIdentity = sameName[i].Key
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(424, 3424, 3735) || true) && (f_424_3428_3498(comparer, f_424_3437_3453(identity), f_424_3455_3478(currentIdentity), sameName[i].Value) && (DynAbs.Tracing.TraceSender.Expression_True(424, 3428, 3598) && f_424_3527_3598(currentIdentity, identity)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(424, 3424, 3735);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(424, 3648, 3674);

                                value = sameName[i].Value;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(424, 3700, 3712);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(424, 3424, 3735);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(424, 1, 487);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(424, 1, 487);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(424, 3185, 3769);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(424, 3785, 3809);

                value = default(TValue);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(424, 3823, 3836);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(424, 2972, 3847);

                string
                f_424_3206_3219(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(424, 3206, 3219);
                    return return_v;
                }


                bool
                f_424_3189_3234(System.Collections.Generic.Dictionary<string, Roslyn.Utilities.OneOrMany<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.AssemblyIdentity, TValue>>>
                this_param, string
                key, out Roslyn.Utilities.OneOrMany<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.AssemblyIdentity, TValue>>
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(424, 3189, 3234);
                    return return_v;
                }


                System.Version
                f_424_3437_3453(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.Version;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(424, 3437, 3453);
                    return return_v;
                }


                System.Version
                f_424_3455_3478(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.Version;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(424, 3455, 3478);
                    return return_v;
                }


                bool
                f_424_3428_3498(System.Func<System.Version, System.Version, TValue, bool>
                this_param, System.Version
                arg1, System.Version
                arg2, TValue
                arg3)
                {
                    var return_v = this_param.Invoke(arg1, arg2, arg3);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(424, 3428, 3498);
                    return return_v;
                }


                bool
                f_424_3527_3598(Microsoft.CodeAnalysis.AssemblyIdentity
                x, Microsoft.CodeAnalysis.AssemblyIdentity
                y)
                {
                    var return_v = AssemblyIdentity.EqualIgnoringNameAndVersion(x, y);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(424, 3527, 3598);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(424, 2972, 3847);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(424, 2972, 3847);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void Add(AssemblyIdentity identity, TValue value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(424, 3859, 4206);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(424, 3940, 3992);

                var
                pair = f_424_3951_3991(identity, value)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(424, 4008, 4067);

                OneOrMany<KeyValuePair<AssemblyIdentity, TValue>>
                sameName
                = default(OneOrMany<KeyValuePair<AssemblyIdentity, TValue>>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(424, 4081, 4195);

                _map[f_424_4086_4099(identity)] = (DynAbs.Tracing.TraceSender.Conditional_F1(424, 4103, 4148) || ((f_424_4103_4148(_map, f_424_4120_4133(identity), out sameName) && DynAbs.Tracing.TraceSender.Conditional_F2(424, 4151, 4169)) || DynAbs.Tracing.TraceSender.Conditional_F3(424, 4172, 4194))) ? sameName.Add(pair) : f_424_4172_4194(pair);
                DynAbs.Tracing.TraceSender.TraceExitMethod(424, 3859, 4206);

                System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.AssemblyIdentity, TValue>
                f_424_3951_3991(Microsoft.CodeAnalysis.AssemblyIdentity
                key, TValue
                value)
                {
                    var return_v = KeyValuePairUtil.Create(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(424, 3951, 3991);
                    return return_v;
                }


                string
                f_424_4086_4099(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(424, 4086, 4099);
                    return return_v;
                }


                string
                f_424_4120_4133(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(424, 4120, 4133);
                    return return_v;
                }


                bool
                f_424_4103_4148(System.Collections.Generic.Dictionary<string, Roslyn.Utilities.OneOrMany<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.AssemblyIdentity, TValue>>>
                this_param, string
                key, out Roslyn.Utilities.OneOrMany<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.AssemblyIdentity, TValue>>
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(424, 4103, 4148);
                    return return_v;
                }


                Roslyn.Utilities.OneOrMany<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.AssemblyIdentity, TValue>>
                f_424_4172_4194(System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.AssemblyIdentity, TValue>
                one)
                {
                    var return_v = OneOrMany.Create(one);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(424, 4172, 4194);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(424, 3859, 4206);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(424, 3859, 4206);
            }
        }

        static AssemblyIdentityMap()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(424, 692, 4213);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(424, 692, 4213);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(424, 692, 4213);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(424, 692, 4213);

        static System.StringComparer
        f_424_996_1039()
        {
            var return_v = AssemblyIdentityComparer.SimpleNameComparer;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(424, 996, 1039);
            return return_v;
        }


        static System.Collections.Generic.Dictionary<string, Roslyn.Utilities.OneOrMany<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.AssemblyIdentity, TValue>>>
        f_424_922_1040(System.StringComparer
        comparer)
        {
            var return_v = new System.Collections.Generic.Dictionary<string, Roslyn.Utilities.OneOrMany<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.AssemblyIdentity, TValue>>>((System.Collections.Generic.IEqualityComparer<string>)comparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(424, 922, 1040);
            return return_v;
        }

    }
}
