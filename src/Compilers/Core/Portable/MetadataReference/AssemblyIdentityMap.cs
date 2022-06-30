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
            TValue value;
            return TryGetValue(identity, out value, allowHigherVersion);
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
            OneOrMany<KeyValuePair<AssemblyIdentity, TValue>> sameName;
            if (_map.TryGetValue(identity.Name, out sameName))
            {
                for (int i = 0; i < sameName.Count; i++)
                {
                    AssemblyIdentity currentIdentity = sameName[i].Key;

                    if (comparer(identity.Version, currentIdentity.Version, sameName[i].Value) &&
                        AssemblyIdentity.EqualIgnoringNameAndVersion(currentIdentity, identity))
                    {
                        value = sameName[i].Value;
                        return true;
                    }
                }
            }

            value = default(TValue);
            return false;
        }

        public void Add(AssemblyIdentity identity, TValue value)
        {
            var pair = KeyValuePairUtil.Create(identity, value);

            OneOrMany<KeyValuePair<AssemblyIdentity, TValue>> sameName;
            _map[identity.Name] = _map.TryGetValue(identity.Name, out sameName) ? sameName.Add(pair) : OneOrMany.Create(pair);
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
