// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;
using System.Diagnostics;

namespace Microsoft.CodeAnalysis
{
    internal sealed class PEAssembly
    {
        internal readonly ImmutableArray<AssemblyIdentity> AssemblyReferences;

        internal readonly ImmutableArray<int> ModuleReferenceCounts;

        private readonly ImmutableArray<PEModule> _modules;

        private readonly AssemblyIdentity _identity;

        private ThreeState _lazyContainsNoPiaLocalTypes;

        private ThreeState _lazyDeclaresTheObjectClass;

        private readonly AssemblyMetadata _owner;

        private Dictionary<string, List<ImmutableArray<byte>>> _lazyInternalsVisibleToMap;

        internal PEAssembly(AssemblyMetadata owner, ImmutableArray<PEModule> modules)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(414, 2193, 3072);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(414, 1382, 1391);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(414, 1529, 1557);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(414, 1589, 1616);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(414, 1860, 1866);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(414, 2097, 2123);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(414, 2295, 2328);

                f_414_2295_2327(f_414_2308_2326_M(!modules.IsDefault));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(414, 2342, 2375);

                f_414_2342_2374(modules.Length > 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(414, 2391, 2444);

                _identity = f_414_2403_2443(modules[0]);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(414, 2460, 2516);

                var
                refs = f_414_2471_2515()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(414, 2530, 2572);

                int[]
                refCounts = new int[modules.Length]
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(414, 2597, 2602);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(414, 2588, 2858) || true) && (i < modules.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(414, 2624, 2627)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(414, 2588, 2858))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(414, 2588, 2858);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(414, 2661, 2742);

                        ImmutableArray<AssemblyIdentity>
                        refsForModule = f_414_2710_2741(modules[i])
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(414, 2760, 2796);

                        refCounts[i] = refsForModule.Length;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(414, 2814, 2843);

                        f_414_2814_2842(refs, refsForModule);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(414, 1, 271);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(414, 1, 271);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(414, 2874, 2893);

                _modules = modules;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(414, 2907, 2959);

                this.AssemblyReferences = f_414_2933_2958(refs);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(414, 2973, 3032);

                this.ModuleReferenceCounts = f_414_3002_3031(refCounts);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(414, 3046, 3061);

                _owner = owner;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(414, 2193, 3072);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(414, 2193, 3072);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(414, 2193, 3072);
            }
        }

        internal EntityHandle Handle
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(414, 3137, 3227);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(414, 3173, 3212);

                    return EntityHandle.AssemblyDefinition;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(414, 3137, 3227);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(414, 3084, 3238);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(414, 3084, 3238);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal PEModule ManifestModule
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(414, 3307, 3333);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(414, 3313, 3331);

                    return f_414_3320_3327()[0];
                    DynAbs.Tracing.TraceSender.TraceExitMethod(414, 3307, 3333);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.PEModule>
                    f_414_3320_3327()
                    {
                        var return_v = Modules;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(414, 3320, 3327);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(414, 3250, 3344);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(414, 3250, 3344);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal ImmutableArray<PEModule> Modules
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(414, 3422, 3489);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(414, 3458, 3474);

                    return _modules;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(414, 3422, 3489);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(414, 3356, 3500);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(414, 3356, 3500);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal AssemblyIdentity Identity
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(414, 3571, 3639);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(414, 3607, 3624);

                    return _identity;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(414, 3571, 3639);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(414, 3512, 3650);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(414, 3512, 3650);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool ContainsNoPiaLocalTypes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(414, 3662, 4269);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(414, 3726, 4187) || true) && (_lazyContainsNoPiaLocalTypes == ThreeState.Unknown)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(414, 3726, 4187);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(414, 3814, 4104);
                        foreach (PEModule module in f_414_3842_3849_I(f_414_3842_3849()))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(414, 3814, 4104);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(414, 3891, 4085) || true) && (f_414_3895_3927(module))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(414, 3891, 4085);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(414, 3977, 4024);

                                _lazyContainsNoPiaLocalTypes = ThreeState.True;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(414, 4050, 4062);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(414, 3891, 4085);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(414, 3814, 4104);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(414, 1, 291);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(414, 1, 291);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(414, 4124, 4172);

                    _lazyContainsNoPiaLocalTypes = ThreeState.False;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(414, 3726, 4187);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(414, 4203, 4258);

                return _lazyContainsNoPiaLocalTypes == ThreeState.True;
                DynAbs.Tracing.TraceSender.TraceExitMethod(414, 3662, 4269);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.PEModule>
                f_414_3842_3849()
                {
                    var return_v = Modules;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(414, 3842, 3849);
                    return return_v;
                }


                bool
                f_414_3895_3927(Microsoft.CodeAnalysis.PEModule
                this_param)
                {
                    var return_v = this_param.ContainsNoPiaLocalTypes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(414, 3895, 3927);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.PEModule>
                f_414_3842_3849_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.PEModule>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(414, 3842, 3849);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(414, 3662, 4269);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(414, 3662, 4269);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Dictionary<string, List<ImmutableArray<byte>>> BuildInternalsVisibleToMap()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(414, 4281, 5714);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(414, 4389, 4487);

                var
                ivtMap = f_414_4402_4486(f_414_4453_4485())
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(414, 4501, 5673);
                    foreach (string attrVal in f_414_4528_4583_I(f_414_4528_4583(f_414_4528_4535()[0], f_414_4576_4582())))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(414, 4501, 5673);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(414, 4617, 4643);

                        AssemblyIdentity
                        identity
                        = default(AssemblyIdentity);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(414, 4661, 5658) || true) && (f_414_4665_4724(attrVal, out identity))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(414, 4661, 5658);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(414, 4766, 4798);

                            List<ImmutableArray<byte>>
                            keys
                            = default(List<ImmutableArray<byte>>);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(414, 4820, 5171) || true) && (f_414_4824_4867(ivtMap, f_414_4843_4856(identity), out keys))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(414, 4820, 5171);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(414, 4894, 4923);

                                f_414_4894_4922(keys, f_414_4903_4921(identity));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(414, 4820, 5171);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(414, 4820, 5171);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(414, 4998, 5038);

                                keys = f_414_5005_5037();
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(414, 5064, 5093);

                                f_414_5064_5092(keys, f_414_5073_5091(identity));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(414, 5119, 5148);

                                ivtMap[f_414_5126_5139(identity)] = keys;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(414, 4820, 5171);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(414, 4661, 5658);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(414, 4661, 5658);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(414, 4661, 5658);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(414, 4501, 5673);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(414, 1, 1173);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(414, 1, 1173);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(414, 5689, 5703);

                return ivtMap;
                DynAbs.Tracing.TraceSender.TraceExitMethod(414, 4281, 5714);

                System.StringComparer
                f_414_4453_4485()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(414, 4453, 4485);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Collections.Immutable.ImmutableArray<byte>>>
                f_414_4402_4486(System.StringComparer
                comparer)
                {
                    var return_v = new System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Collections.Immutable.ImmutableArray<byte>>>((System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(414, 4402, 4486);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.PEModule>
                f_414_4528_4535()
                {
                    var return_v = Modules;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(414, 4528, 4535);
                    return return_v;
                }


                System.Reflection.Metadata.EntityHandle
                f_414_4576_4582()
                {
                    var return_v = Handle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(414, 4576, 4582);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_414_4528_4583(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.EntityHandle
                token)
                {
                    var return_v = this_param.GetInternalsVisibleToAttributeValues(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(414, 4528, 4583);
                    return return_v;
                }


                bool
                f_414_4665_4724(string
                displayName, out Microsoft.CodeAnalysis.AssemblyIdentity
                identity)
                {
                    var return_v = AssemblyIdentity.TryParseDisplayName(displayName, out identity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(414, 4665, 4724);
                    return return_v;
                }


                string
                f_414_4843_4856(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(414, 4843, 4856);
                    return return_v;
                }


                bool
                f_414_4824_4867(System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Collections.Immutable.ImmutableArray<byte>>>
                this_param, string
                key, out System.Collections.Generic.List<System.Collections.Immutable.ImmutableArray<byte>>
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(414, 4824, 4867);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_414_4903_4921(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.PublicKey;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(414, 4903, 4921);
                    return return_v;
                }


                int
                f_414_4894_4922(System.Collections.Generic.List<System.Collections.Immutable.ImmutableArray<byte>>
                this_param, System.Collections.Immutable.ImmutableArray<byte>
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(414, 4894, 4922);
                    return 0;
                }


                System.Collections.Generic.List<System.Collections.Immutable.ImmutableArray<byte>>
                f_414_5005_5037()
                {
                    var return_v = new System.Collections.Generic.List<System.Collections.Immutable.ImmutableArray<byte>>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(414, 5005, 5037);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_414_5073_5091(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.PublicKey;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(414, 5073, 5091);
                    return return_v;
                }


                int
                f_414_5064_5092(System.Collections.Generic.List<System.Collections.Immutable.ImmutableArray<byte>>
                this_param, System.Collections.Immutable.ImmutableArray<byte>
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(414, 5064, 5092);
                    return 0;
                }


                string
                f_414_5126_5139(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(414, 5126, 5139);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_414_4528_4583_I(System.Collections.Immutable.ImmutableArray<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(414, 4528, 4583);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(414, 4281, 5714);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(414, 4281, 5714);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal IEnumerable<ImmutableArray<byte>> GetInternalsVisibleToPublicKeys(string simpleName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(414, 5726, 6233);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(414, 5844, 5997) || true) && (_lazyInternalsVisibleToMap == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(414, 5844, 5997);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(414, 5901, 5997);

                    f_414_5901_5996(ref _lazyInternalsVisibleToMap, f_414_5961_5989(this), null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(414, 5844, 5997);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(414, 6013, 6047);

                List<ImmutableArray<byte>>
                result
                = default(List<ImmutableArray<byte>>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(414, 6063, 6126);

                f_414_6063_6125(
                            _lazyInternalsVisibleToMap, simpleName, out result);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(414, 6142, 6222);

                return result ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Generic.List<System.Collections.Immutable.ImmutableArray<byte>>?>(414, 6149, 6221) ?? f_414_6159_6221());
                DynAbs.Tracing.TraceSender.TraceExitMethod(414, 5726, 6233);

                System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Collections.Immutable.ImmutableArray<byte>>>
                f_414_5961_5989(Microsoft.CodeAnalysis.PEAssembly
                this_param)
                {
                    var return_v = this_param.BuildInternalsVisibleToMap();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(414, 5961, 5989);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Collections.Immutable.ImmutableArray<byte>>>?
                f_414_5901_5996(ref System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Collections.Immutable.ImmutableArray<byte>>>?
                location1, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Collections.Immutable.ImmutableArray<byte>>>
                value, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Collections.Immutable.ImmutableArray<byte>>>?
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(414, 5901, 5996);
                    return return_v;
                }


                bool
                f_414_6063_6125(System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Collections.Immutable.ImmutableArray<byte>>>
                this_param, string
                key, out System.Collections.Generic.List<System.Collections.Immutable.ImmutableArray<byte>>
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(414, 6063, 6125);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Collections.Immutable.ImmutableArray<byte>>
                f_414_6159_6221()
                {
                    var return_v = SpecializedCollections.EmptyEnumerable<ImmutableArray<byte>>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(414, 6159, 6221);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(414, 5726, 6233);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(414, 5726, 6233);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool DeclaresTheObjectClass
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(414, 6306, 6682);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(414, 6342, 6593) || true) && (_lazyDeclaresTheObjectClass == ThreeState.Unknown)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(414, 6342, 6593);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(414, 6437, 6501);

                        var
                        value = f_414_6449_6500(f_414_6449_6475(_modules[0]))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(414, 6523, 6574);

                        _lazyDeclaresTheObjectClass = f_414_6553_6573(value);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(414, 6342, 6593);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(414, 6613, 6667);

                    return _lazyDeclaresTheObjectClass == ThreeState.True;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(414, 6306, 6682);

                    System.Reflection.Metadata.MetadataReader
                    f_414_6449_6475(Microsoft.CodeAnalysis.PEModule
                    this_param)
                    {
                        var return_v = this_param.MetadataReader;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(414, 6449, 6475);
                        return return_v;
                    }


                    bool
                    f_414_6449_6500(System.Reflection.Metadata.MetadataReader
                    reader)
                    {
                        var return_v = reader.DeclaresTheObjectClass();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(414, 6449, 6500);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ThreeState
                    f_414_6553_6573(bool
                    value)
                    {
                        var return_v = value.ToThreeState();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(414, 6553, 6573);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(414, 6245, 6693);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(414, 6245, 6693);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public AssemblyMetadata GetNonDisposableMetadata()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(414, 6756, 6772);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(414, 6759, 6772);
                return f_414_6759_6772(_owner); DynAbs.Tracing.TraceSender.TraceExitMethod(414, 6756, 6772);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(414, 6756, 6772);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(414, 6756, 6772);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.AssemblyMetadata
            f_414_6759_6772(Microsoft.CodeAnalysis.AssemblyMetadata
            this_param)
            {
                var return_v = this_param.Copy();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(414, 6759, 6772);
                return return_v;
            }

        }

        static PEAssembly()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(414, 536, 6780);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(414, 536, 6780);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(414, 536, 6780);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(414, 536, 6780);

        bool
        f_414_2308_2326_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(414, 2308, 2326);
            return return_v;
        }


        static int
        f_414_2295_2327(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(414, 2295, 2327);
            return 0;
        }


        static int
        f_414_2342_2374(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(414, 2342, 2374);
            return 0;
        }


        static Microsoft.CodeAnalysis.AssemblyIdentity
        f_414_2403_2443(Microsoft.CodeAnalysis.PEModule
        this_param)
        {
            var return_v = this_param.ReadAssemblyIdentityOrThrow();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(414, 2403, 2443);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.AssemblyIdentity>
        f_414_2471_2515()
        {
            var return_v = ArrayBuilder<AssemblyIdentity>.GetInstance();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(414, 2471, 2515);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AssemblyIdentity>
        f_414_2710_2741(Microsoft.CodeAnalysis.PEModule
        this_param)
        {
            var return_v = this_param.ReferencedAssemblies;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(414, 2710, 2741);
            return return_v;
        }


        static int
        f_414_2814_2842(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.AssemblyIdentity>
        this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AssemblyIdentity>
        items)
        {
            this_param.AddRange(items);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(414, 2814, 2842);
            return 0;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AssemblyIdentity>
        f_414_2933_2958(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.AssemblyIdentity>
        this_param)
        {
            var return_v = this_param.ToImmutableAndFree();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(414, 2933, 2958);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<int>
        f_414_3002_3031(int[]
        items)
        {
            var return_v = items.AsImmutableOrNull<int>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(414, 3002, 3031);
            return return_v;
        }

    }
}
