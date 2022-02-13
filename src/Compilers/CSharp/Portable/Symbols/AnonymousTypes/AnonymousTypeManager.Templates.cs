// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Threading;
using Microsoft.CodeAnalysis.CSharp.Emit;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Symbols;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed partial class AnonymousTypeManager
    {
        private ConcurrentDictionary<string, AnonymousTypeTemplateSymbol> _lazyAnonymousTypeTemplates;

        private ConcurrentDictionary<SynthesizedDelegateKey, SynthesizedDelegateValue> _lazySynthesizedDelegates;

        private struct SynthesizedDelegateKey : IEquatable<SynthesizedDelegateKey>
        {

            private readonly BitVector _byRefs;

            private readonly ushort _parameterCount;

            private readonly bool _returnsVoid;

            private readonly int _generation;

            public SynthesizedDelegateKey(int parameterCount, BitVector byRefs, bool returnsVoid, int generation)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10420, 2066, 2379);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 2200, 2241);

                    _parameterCount = (ushort)parameterCount;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 2259, 2286);

                    _returnsVoid = returnsVoid;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 2304, 2329);

                    _generation = generation;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 2347, 2364);

                    _byRefs = byRefs;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10420, 2066, 2379);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10420, 2066, 2379);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10420, 2066, 2379);
                }
            }

            public string MakeTypeName()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10420, 2395, 2561);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 2456, 2546);

                    return f_10420_2463_2545(_byRefs, _returnsVoid, _generation);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10420, 2395, 2561);

                    string
                    f_10420_2463_2545(Microsoft.CodeAnalysis.BitVector
                    byRefs, bool
                    returnsVoid, int
                    generation)
                    {
                        var return_v = GeneratedNames.MakeDynamicCallSiteDelegateName(byRefs, returnsVoid, generation);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 2463, 2545);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10420, 2395, 2561);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10420, 2395, 2561);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override bool Equals(object obj)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10420, 2577, 2740);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 2649, 2725);

                    return obj is SynthesizedDelegateKey && (DynAbs.Tracing.TraceSender.Expression_True(10420, 2656, 2724) && Equals(obj));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10420, 2577, 2740);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10420, 2577, 2740);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10420, 2577, 2740);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public bool Equals(SynthesizedDelegateKey other)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10420, 2756, 3070);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 2837, 3055);

                    return _parameterCount == other._parameterCount
                    && (DynAbs.Tracing.TraceSender.Expression_True(10420, 2844, 2943) && _returnsVoid == other._returnsVoid
                    ) && (DynAbs.Tracing.TraceSender.Expression_True(10420, 2844, 3000) && _generation == other._generation
                    ) && (DynAbs.Tracing.TraceSender.Expression_True(10420, 2844, 3054) && _byRefs.Equals(other._byRefs));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10420, 2756, 3070);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10420, 2756, 3070);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10420, 2756, 3070);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override int GetHashCode()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10420, 3086, 3344);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 3152, 3329);

                    return f_10420_3159_3328(f_10420_3194_3241(_parameterCount, _generation), f_10420_3264_3327(f_10420_3277_3303(_returnsVoid), _byRefs.GetHashCode()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10420, 3086, 3344);

                    int
                    f_10420_3194_3241(ushort
                    newKey, int
                    currentKey)
                    {
                        var return_v = Hash.Combine((int)newKey, currentKey);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 3194, 3241);
                        return return_v;
                    }


                    int
                    f_10420_3277_3303(bool
                    this_param)
                    {
                        var return_v = this_param.GetHashCode();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 3277, 3303);
                        return return_v;
                    }


                    int
                    f_10420_3264_3327(int
                    newKey, int
                    currentKey)
                    {
                        var return_v = Hash.Combine(newKey, currentKey);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 3264, 3327);
                        return return_v;
                    }


                    int
                    f_10420_3159_3328(int
                    newKey, int
                    currentKey)
                    {
                        var return_v = Hash.Combine(newKey, currentKey);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 3159, 3328);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10420, 3086, 3344);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10420, 3086, 3344);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            static SynthesizedDelegateKey()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10420, 1766, 3355);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10420, 1766, 3355);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10420, 1766, 3355);
            }
        }

        private struct SynthesizedDelegateValue
        {

            public readonly SynthesizedDelegateSymbol Delegate;

            public readonly AnonymousTypeManager Manager;

            public SynthesizedDelegateValue(AnonymousTypeManager manager, SynthesizedDelegateSymbol @delegate)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10420, 3615, 3905);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 3746, 3805);

                    f_10420_3746_3804(manager != null && (DynAbs.Tracing.TraceSender.Expression_True(10420, 3759, 3803) && (object)@delegate != null));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 3823, 3846);

                    this.Manager = manager;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 3864, 3890);

                    this.Delegate = @delegate;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10420, 3615, 3905);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10420, 3615, 3905);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10420, 3615, 3905);
                }
            }
            static SynthesizedDelegateValue()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10420, 3367, 3916);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10420, 3367, 3916);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10420, 3367, 3916);
            }

            static int
            f_10420_3746_3804(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 3746, 3804);
                return 0;
            }

        }

        private readonly ConcurrentDictionary<Location, bool> _sourceLocationsSeen;

        [Conditional("DEBUG")]
        private void CheckSourceLocationSeen(AnonymousTypePublicSymbol anonymous)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10420, 4224, 4784);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 4365, 4408);

                Location
                location = f_10420_4385_4404(anonymous)[0]
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 4422, 4765) || true) && (f_10420_4426_4445(location))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10420, 4422, 4765);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 4479, 4750) || true) && (f_10420_4483_4506(this))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10420, 4479, 4750);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 4548, 4605);

                        f_10420_4548_4604(f_10420_4561_4603(_sourceLocationsSeen, location));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10420, 4479, 4750);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10420, 4479, 4750);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 4687, 4731);

                        f_10420_4687_4730(_sourceLocationsSeen, location, true);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10420, 4479, 4750);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10420, 4422, 4765);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10420, 4224, 4784);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10420_4385_4404(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypePublicSymbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10420, 4385, 4404);
                    return return_v;
                }


                bool
                f_10420_4426_4445(Microsoft.CodeAnalysis.Location
                this_param)
                {
                    var return_v = this_param.IsInSource;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10420, 4426, 4445);
                    return return_v;
                }


                bool
                f_10420_4483_4506(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager
                this_param)
                {
                    var return_v = this_param.AreTemplatesSealed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10420, 4483, 4506);
                    return return_v;
                }


                bool
                f_10420_4561_4603(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.Location, bool>
                this_param, Microsoft.CodeAnalysis.Location
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 4561, 4603);
                    return return_v;
                }


                int
                f_10420_4548_4604(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 4548, 4604);
                    return 0;
                }


                bool
                f_10420_4687_4730(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.Location, bool>
                this_param, Microsoft.CodeAnalysis.Location
                key, bool
                value)
                {
                    var return_v = this_param.TryAdd(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 4687, 4730);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10420, 4224, 4784);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10420, 4224, 4784);
            }
        }

        private ConcurrentDictionary<string, AnonymousTypeTemplateSymbol> AnonymousTypeTemplates
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10420, 4909, 5909);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 5002, 5839) || true) && (_lazyAnonymousTypeTemplates == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10420, 5002, 5839);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 5083, 5158);

                        CSharpCompilation
                        previousSubmission = f_10420_5122_5157(f_10420_5122_5138(this))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 5236, 5357);

                        var
                        previousCache = (DynAbs.Tracing.TraceSender.Conditional_F1(10420, 5256, 5284) || (((previousSubmission == null) && DynAbs.Tracing.TraceSender.Conditional_F2(10420, 5287, 5291)) || DynAbs.Tracing.TraceSender.Conditional_F3(10420, 5294, 5356))) ? null : f_10420_5294_5356(f_10420_5294_5333(previousSubmission))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 5381, 5820);

                        f_10420_5381_5819(ref _lazyAnonymousTypeTemplates, (DynAbs.Tracing.TraceSender.Conditional_F1(10420, 5491, 5512) || ((previousCache == null
                        && DynAbs.Tracing.TraceSender.Conditional_F2(10420, 5568, 5631)) || DynAbs.Tracing.TraceSender.Conditional_F3(10420, 5687, 5763))) ? f_10420_5568_5631() : f_10420_5687_5763(previousCache), null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10420, 5002, 5839);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 5859, 5894);

                    return _lazyAnonymousTypeTemplates;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10420, 4909, 5909);

                    Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    f_10420_5122_5138(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager
                    this_param)
                    {
                        var return_v = this_param.Compilation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10420, 5122, 5138);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpCompilation?
                    f_10420_5122_5157(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    this_param)
                    {
                        var return_v = this_param.PreviousSubmission;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10420, 5122, 5157);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager
                    f_10420_5294_5333(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    this_param)
                    {
                        var return_v = this_param.AnonymousTypeManager;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10420, 5294, 5333);
                        return return_v;
                    }


                    System.Collections.Concurrent.ConcurrentDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeTemplateSymbol>
                    f_10420_5294_5356(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager
                    this_param)
                    {
                        var return_v = this_param.AnonymousTypeTemplates;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10420, 5294, 5356);
                        return return_v;
                    }


                    System.Collections.Concurrent.ConcurrentDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeTemplateSymbol>
                    f_10420_5568_5631()
                    {
                        var return_v = new System.Collections.Concurrent.ConcurrentDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeTemplateSymbol>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 5568, 5631);
                        return return_v;
                    }


                    System.Collections.Concurrent.ConcurrentDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeTemplateSymbol>
                    f_10420_5687_5763(System.Collections.Concurrent.ConcurrentDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeTemplateSymbol>
                    collection)
                    {
                        var return_v = new System.Collections.Concurrent.ConcurrentDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeTemplateSymbol>((System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeTemplateSymbol>>)collection);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 5687, 5763);
                        return return_v;
                    }


                    System.Collections.Concurrent.ConcurrentDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeTemplateSymbol>?
                    f_10420_5381_5819(ref System.Collections.Concurrent.ConcurrentDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeTemplateSymbol>?
                    location1, System.Collections.Concurrent.ConcurrentDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeTemplateSymbol>
                    value, System.Collections.Concurrent.ConcurrentDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeTemplateSymbol>?
                    comparand)
                    {
                        var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 5381, 5819);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10420, 4796, 5920);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10420, 4796, 5920);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private ConcurrentDictionary<SynthesizedDelegateKey, SynthesizedDelegateValue> SynthesizedDelegates
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10420, 6056, 7022);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 6092, 6954) || true) && (_lazySynthesizedDelegates == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10420, 6092, 6954);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 6171, 6246);

                        CSharpCompilation
                        previousSubmission = f_10420_6210_6245(f_10420_6210_6226(this))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 6324, 6448);

                        var
                        previousCache = (DynAbs.Tracing.TraceSender.Conditional_F1(10420, 6344, 6372) || (((previousSubmission == null) && DynAbs.Tracing.TraceSender.Conditional_F2(10420, 6375, 6379)) || DynAbs.Tracing.TraceSender.Conditional_F3(10420, 6382, 6447))) ? null : f_10420_6382_6421(previousSubmission)._lazySynthesizedDelegates
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 6472, 6935);

                        f_10420_6472_6934(ref _lazySynthesizedDelegates, (DynAbs.Tracing.TraceSender.Conditional_F1(10420, 6580, 6601) || ((previousCache == null
                        && DynAbs.Tracing.TraceSender.Conditional_F2(10420, 6657, 6733)) || DynAbs.Tracing.TraceSender.Conditional_F3(10420, 6789, 6878))) ? f_10420_6657_6733() : f_10420_6789_6878(previousCache), null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10420, 6092, 6954);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 6974, 7007);

                    return _lazySynthesizedDelegates;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10420, 6056, 7022);

                    Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    f_10420_6210_6226(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager
                    this_param)
                    {
                        var return_v = this_param.Compilation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10420, 6210, 6226);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpCompilation?
                    f_10420_6210_6245(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    this_param)
                    {
                        var return_v = this_param.PreviousSubmission;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10420, 6210, 6245);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager
                    f_10420_6382_6421(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    this_param)
                    {
                        var return_v = this_param.AnonymousTypeManager;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10420, 6382, 6421);
                        return return_v;
                    }


                    System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.SynthesizedDelegateKey, Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.SynthesizedDelegateValue>
                    f_10420_6657_6733()
                    {
                        var return_v = new System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.SynthesizedDelegateKey, Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.SynthesizedDelegateValue>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 6657, 6733);
                        return return_v;
                    }


                    System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.SynthesizedDelegateKey, Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.SynthesizedDelegateValue>
                    f_10420_6789_6878(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.SynthesizedDelegateKey, Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.SynthesizedDelegateValue>
                    collection)
                    {
                        var return_v = new System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.SynthesizedDelegateKey, Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.SynthesizedDelegateValue>((System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.SynthesizedDelegateKey, Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.SynthesizedDelegateValue>>)collection);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 6789, 6878);
                        return return_v;
                    }


                    System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.SynthesizedDelegateKey, Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.SynthesizedDelegateValue>?
                    f_10420_6472_6934(ref System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.SynthesizedDelegateKey, Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.SynthesizedDelegateValue>?
                    location1, System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.SynthesizedDelegateKey, Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.SynthesizedDelegateValue>
                    value, System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.SynthesizedDelegateKey, Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.SynthesizedDelegateValue>?
                    comparand)
                    {
                        var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 6472, 6934);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10420, 5932, 7033);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10420, 5932, 7033);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal SynthesizedDelegateSymbol SynthesizeDelegate(int parameterCount, BitVector byRefParameters, bool returnsVoid, int generation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10420, 7045, 8371);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 7263, 7346);

                f_10420_7263_7345(byRefParameters.IsNull || (DynAbs.Tracing.TraceSender.Expression_False(10420, 7276, 7344) || parameterCount == byRefParameters.Capacity));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 7362, 7457);

                var
                key = f_10420_7372_7456(parameterCount, byRefParameters, returnsVoid, generation)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 7473, 7505);

                SynthesizedDelegateValue
                result
                = default(SynthesizedDelegateValue);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 7519, 7649) || true) && (f_10420_7523_7577(f_10420_7523_7548(this), key, out result))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10420, 7519, 7649);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 7611, 7634);

                    return result.Delegate;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10420, 7519, 7649);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 7756, 8360);

                return f_10420_7763_8350(f_10420_7763_7788(this), key, f_10420_7820_8349(this, f_10420_7898_8348(f_10420_7954_7995(f_10420_7954_7979(f_10420_7954_7970(this))), key.MakeTypeName(), f_10420_8067_8085(this), f_10420_8112_8165(f_10420_8112_8123(), SpecialType.System_IntPtr), (DynAbs.Tracing.TraceSender.Conditional_F1(10420, 8192, 8203) || ((returnsVoid && DynAbs.Tracing.TraceSender.Conditional_F2(10420, 8206, 8257)) || DynAbs.Tracing.TraceSender.Conditional_F3(10420, 8260, 8264))) ? f_10420_8206_8257(f_10420_8206_8217(), SpecialType.System_Void) : null, parameterCount, byRefParameters))).Delegate;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10420, 7045, 8371);

                int
                f_10420_7263_7345(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 7263, 7345);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.SynthesizedDelegateKey
                f_10420_7372_7456(int
                parameterCount, Microsoft.CodeAnalysis.BitVector
                byRefs, bool
                returnsVoid, int
                generation)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.SynthesizedDelegateKey(parameterCount, byRefs, returnsVoid, generation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 7372, 7456);
                    return return_v;
                }


                System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.SynthesizedDelegateKey, Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.SynthesizedDelegateValue>
                f_10420_7523_7548(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager
                this_param)
                {
                    var return_v = this_param.SynthesizedDelegates;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10420, 7523, 7548);
                    return return_v;
                }


                bool
                f_10420_7523_7577(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.SynthesizedDelegateKey, Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.SynthesizedDelegateValue>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.SynthesizedDelegateKey
                key, out Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.SynthesizedDelegateValue
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 7523, 7577);
                    return return_v;
                }


                System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.SynthesizedDelegateKey, Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.SynthesizedDelegateValue>
                f_10420_7763_7788(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager
                this_param)
                {
                    var return_v = this_param.SynthesizedDelegates;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10420, 7763, 7788);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10420_7954_7970(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10420, 7954, 7970);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10420_7954_7979(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Assembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10420, 7954, 7979);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_10420_7954_7995(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.GlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10420, 7954, 7995);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10420_8067_8085(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager
                this_param)
                {
                    var return_v = this_param.System_Object;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10420, 8067, 8085);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10420_8112_8123()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10420, 8112, 8123);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10420_8112_8165(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 8112, 8165);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10420_8206_8217()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10420, 8206, 8217);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10420_8206_8257(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 8206, 8257);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedDelegateSymbol
                f_10420_7898_8348(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                containingSymbol, string
                name, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                objectType, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                intPtrType, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                voidReturnTypeOpt, int
                parameterCount, Microsoft.CodeAnalysis.BitVector
                byRefParameters)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedDelegateSymbol((Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol)containingSymbol, name, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)objectType, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)intPtrType, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?)voidReturnTypeOpt, parameterCount, byRefParameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 7898, 8348);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.SynthesizedDelegateValue
                f_10420_7820_8349(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager
                manager, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedDelegateSymbol
                @delegate)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.SynthesizedDelegateValue(manager, @delegate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 7820, 8349);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.SynthesizedDelegateValue
                f_10420_7763_8350(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.SynthesizedDelegateKey, Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.SynthesizedDelegateValue>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.SynthesizedDelegateKey
                key, Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.SynthesizedDelegateValue
                value)
                {
                    var return_v = this_param.GetOrAdd(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 7763, 8350);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10420, 7045, 8371);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10420, 7045, 8371);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private NamedTypeSymbol ConstructAnonymousTypeImplementationSymbol(AnonymousTypePublicSymbol anonymous)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10420, 8809, 10211);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 8937, 8992);

                f_10420_8937_8991(f_10420_8950_8990(this, anonymous.Manager));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 9008, 9043);

                f_10420_9008_9042(this, anonymous);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 9059, 9120);

                AnonymousTypeDescriptor
                typeDescr = anonymous.TypeDescriptor
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 9134, 9159);

                typeDescr.AssertIsGood();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 9219, 9256);

                AnonymousTypeTemplateSymbol
                template
                = default(AnonymousTypeTemplateSymbol);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 9270, 9600) || true) && (!f_10420_9275_9343(f_10420_9275_9302(this), typeDescr.Key, out template))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10420, 9270, 9600);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 9472, 9585);

                    template = f_10420_9483_9584(f_10420_9483_9510(this), typeDescr.Key, f_10420_9535_9583(this, typeDescr));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10420, 9270, 9600);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 9698, 9834) || true) && (f_10420_9702_9741(template.Manager, this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10420, 9698, 9834);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 9775, 9819);

                    f_10420_9775_9818(template, typeDescr.Location);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10420, 9698, 9834);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 9914, 10002) || true) && (f_10420_9918_9932(template) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10420, 9914, 10002);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 9971, 9987);

                    return template;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10420, 9914, 10002);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 10081, 10145);

                var
                typeArguments = typeDescr.Fields.SelectAsArray(f => f.Type)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 10159, 10200);

                return f_10420_10166_10199(template, typeArguments);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10420, 8809, 10211);

                bool
                f_10420_8950_8990(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager
                objA, Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 8950, 8990);
                    return return_v;
                }


                int
                f_10420_8937_8991(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 8937, 8991);
                    return 0;
                }


                int
                f_10420_9008_9042(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypePublicSymbol
                anonymous)
                {
                    this_param.CheckSourceLocationSeen(anonymous);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 9008, 9042);
                    return 0;
                }


                System.Collections.Concurrent.ConcurrentDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeTemplateSymbol>
                f_10420_9275_9302(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager
                this_param)
                {
                    var return_v = this_param.AnonymousTypeTemplates;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10420, 9275, 9302);
                    return return_v;
                }


                bool
                f_10420_9275_9343(System.Collections.Concurrent.ConcurrentDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeTemplateSymbol>
                this_param, string
                key, out Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeTemplateSymbol
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 9275, 9343);
                    return return_v;
                }


                System.Collections.Concurrent.ConcurrentDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeTemplateSymbol>
                f_10420_9483_9510(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager
                this_param)
                {
                    var return_v = this_param.AnonymousTypeTemplates;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10420, 9483, 9510);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeTemplateSymbol
                f_10420_9535_9583(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager
                manager, Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeDescriptor
                typeDescr)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeTemplateSymbol(manager, typeDescr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 9535, 9583);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeTemplateSymbol
                f_10420_9483_9584(System.Collections.Concurrent.ConcurrentDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeTemplateSymbol>
                this_param, string
                key, Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeTemplateSymbol
                value)
                {
                    var return_v = this_param.GetOrAdd(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 9483, 9584);
                    return return_v;
                }


                bool
                f_10420_9702_9741(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager
                objA, Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 9702, 9741);
                    return return_v;
                }


                int
                f_10420_9775_9818(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeTemplateSymbol
                this_param, Microsoft.CodeAnalysis.Location
                location)
                {
                    this_param.AdjustLocation(location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 9775, 9818);
                    return 0;
                }


                int
                f_10420_9918_9932(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeTemplateSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10420, 9918, 9932);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10420_10166_10199(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeTemplateSymbol
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                typeArguments)
                {
                    var return_v = this_param.Construct(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 10166, 10199);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10420, 8809, 10211);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10420, 8809, 10211);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private AnonymousTypeTemplateSymbol CreatePlaceholderTemplate(Microsoft.CodeAnalysis.Emit.AnonymousTypeKey key)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10420, 10223, 10620);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 10359, 10458);

                var
                fields = key.Fields.SelectAsArray(f => new AnonymousTypeField(f.Name, Location.None, default))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 10472, 10539);

                var
                typeDescr = f_10420_10488_10538(fields, f_10420_10524_10537())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 10553, 10609);

                return f_10420_10560_10608(this, typeDescr);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10420, 10223, 10620);

                Microsoft.CodeAnalysis.Location
                f_10420_10524_10537()
                {
                    var return_v = Location.None;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10420, 10524, 10537);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeDescriptor
                f_10420_10488_10538(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeField>
                fields, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeDescriptor(fields, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 10488, 10538);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeTemplateSymbol
                f_10420_10560_10608(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager
                manager, Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeDescriptor
                typeDescr)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeTemplateSymbol(manager, typeDescr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 10560, 10608);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10420, 10223, 10620);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10420, 10223, 10620);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void AssignTemplatesNamesAndCompile(MethodCompiler compiler, PEModuleBuilder moduleBeingBuilt, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10420, 10827, 14603);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 11143, 11444);
                    foreach (var key in f_10420_11163_11207_I(f_10420_11163_11207(moduleBeingBuilt)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10420, 11143, 11444);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 11241, 11319);

                        var
                        templateKey = AnonymousTypeDescriptor.ComputeKey(key.Fields, f => f.Name)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 11337, 11429);

                        f_10420_11337_11428(f_10420_11337_11364(this), templateKey, k => this.CreatePlaceholderTemplate(key));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10420, 11143, 11444);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10420, 1, 302);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10420, 1, 302);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 11522, 11592);

                var
                builder = f_10420_11536_11591()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 11606, 11648);

                f_10420_11606_11647(this, builder);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 11802, 13670) || true) && (f_10420_11806_11830_M(!this.AreTemplatesSealed))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10420, 11802, 13670);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 12018, 12034);

                    string
                    moduleId
                    = default(string);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 12054, 12716) || true) && (moduleBeingBuilt.OutputKind == OutputKind.NetModule)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10420, 12054, 12716);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 12151, 12184);

                        moduleId = f_10420_12162_12183(moduleBeingBuilt);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 12208, 12270);

                        string
                        extension = f_10420_12227_12269(OutputKind.NetModule)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 12294, 12504) || true) && (f_10420_12298_12362(moduleId, extension, StringComparison.OrdinalIgnoreCase))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10420, 12294, 12504);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 12412, 12481);

                            moduleId = f_10420_12423_12480(moduleId, 0, f_10420_12445_12460(moduleId) - f_10420_12463_12479(extension));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10420, 12294, 12504);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 12528, 12591);

                        moduleId = f_10420_12539_12590(moduleId);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10420, 12054, 12716);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10420, 12054, 12716);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 12673, 12697);

                        moduleId = string.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10420, 12054, 12716);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 12736, 12797);

                    int
                    nextIndex = f_10420_12752_12796(moduleBeingBuilt)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 12815, 13614);
                        foreach (var template in f_10420_12840_12847_I(builder))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10420, 12815, 13614);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 12889, 12901);

                            string
                            name
                            = default(string);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 12923, 12933);

                            int
                            index
                            = default(int);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 12955, 13262) || true) && (!f_10420_12960_13031(moduleBeingBuilt, template, out name, out index))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10420, 12955, 13262);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 13081, 13101);

                                index = nextIndex++;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 13127, 13239);

                                name = f_10420_13134_13238(index, f_10420_13186_13227(f_10420_13186_13202(this)), moduleId);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10420, 12955, 13262);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 13541, 13595);

                            template.NameAndIndex = f_10420_13565_13594(name, index);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10420, 12815, 13614);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10420, 1, 800);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10420, 1, 800);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 13634, 13655);

                    f_10420_13634_13654(
                                    this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10420, 11802, 13670);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 13686, 14194) || true) && (f_10420_13690_13703(builder) > 0 && (DynAbs.Tracing.TraceSender.Expression_True(10420, 13690, 13756) && !f_10420_13712_13756(this, diagnostics)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10420, 13686, 14194);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 13836, 14179);
                        foreach (var template in f_10420_13861_13868_I(builder))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10420, 13836, 14179);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 13910, 14105);
                                foreach (var method in f_10420_13933_13956_I(template.SpecialMembers))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10420, 13910, 14105);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 14006, 14082);

                                    f_10420_14006_14081(moduleBeingBuilt, template, f_10420_14058_14080(method));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10420, 13910, 14105);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10420, 1, 196);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10420, 1, 196);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 14129, 14160);

                            f_10420_14129_14159(
                                                compiler, template, null);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10420, 13836, 14179);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10420, 1, 344);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10420, 1, 344);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10420, 13686, 14194);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 14210, 14225);

                f_10420_14210_14224(
                            builder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 14241, 14322);

                var
                synthesizedDelegates = f_10420_14268_14321()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 14336, 14389);

                f_10420_14336_14388(this, synthesizedDelegates);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 14403, 14550);
                    foreach (var synthesizedDelegate in f_10420_14439_14459_I(synthesizedDelegates))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10420, 14403, 14550);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 14493, 14535);

                        f_10420_14493_14534(compiler, synthesizedDelegate, null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10420, 14403, 14550);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10420, 1, 148);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10420, 1, 148);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 14564, 14592);

                f_10420_14564_14591(synthesizedDelegates);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10420, 10827, 14603);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.AnonymousTypeKey>
                f_10420_11163_11207(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param)
                {
                    var return_v = this_param.GetPreviousAnonymousTypes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 11163, 11207);
                    return return_v;
                }


                System.Collections.Concurrent.ConcurrentDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeTemplateSymbol>
                f_10420_11337_11364(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager
                this_param)
                {
                    var return_v = this_param.AnonymousTypeTemplates;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10420, 11337, 11364);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeTemplateSymbol
                f_10420_11337_11428(System.Collections.Concurrent.ConcurrentDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeTemplateSymbol>
                this_param, string
                key, System.Func<string, Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeTemplateSymbol>
                valueFactory)
                {
                    var return_v = this_param.GetOrAdd(key, valueFactory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 11337, 11428);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.AnonymousTypeKey>
                f_10420_11163_11207_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.AnonymousTypeKey>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 11163, 11207);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeTemplateSymbol>
                f_10420_11536_11591()
                {
                    var return_v = ArrayBuilder<AnonymousTypeTemplateSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 11536, 11591);
                    return return_v;
                }


                int
                f_10420_11606_11647(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeTemplateSymbol>
                builder)
                {
                    this_param.GetCreatedAnonymousTypeTemplates(builder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 11606, 11647);
                    return 0;
                }


                bool
                f_10420_11806_11830_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10420, 11806, 11830);
                    return return_v;
                }


                string
                f_10420_12162_12183(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10420, 12162, 12183);
                    return return_v;
                }


                string
                f_10420_12227_12269(Microsoft.CodeAnalysis.OutputKind
                kind)
                {
                    var return_v = kind.GetDefaultExtension();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 12227, 12269);
                    return return_v;
                }


                bool
                f_10420_12298_12362(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.EndsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 12298, 12362);
                    return return_v;
                }


                int
                f_10420_12445_12460(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10420, 12445, 12460);
                    return return_v;
                }


                int
                f_10420_12463_12479(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10420, 12463, 12479);
                    return return_v;
                }


                string
                f_10420_12423_12480(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 12423, 12480);
                    return return_v;
                }


                string
                f_10420_12539_12590(string
                moduleName)
                {
                    var return_v = MetadataHelpers.MangleForTypeNameIfNeeded(moduleName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 12539, 12590);
                    return return_v;
                }


                int
                f_10420_12752_12796(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param)
                {
                    var return_v = this_param.GetNextAnonymousTypeIndex();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 12752, 12796);
                    return return_v;
                }


                bool
                f_10420_12960_13031(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeTemplateSymbol
                template, out string
                name, out int
                index)
                {
                    var return_v = this_param.TryGetAnonymousTypeName(template, out name, out index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 12960, 13031);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10420_13186_13202(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10420, 13186, 13202);
                    return return_v;
                }


                int
                f_10420_13186_13227(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.GetSubmissionSlotIndex();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 13186, 13227);
                    return return_v;
                }


                string
                f_10420_13134_13238(int
                index, int
                submissionSlotIndex, string
                moduleId)
                {
                    var return_v = GeneratedNames.MakeAnonymousTypeTemplateName(index, submissionSlotIndex, moduleId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 13134, 13238);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.NameAndIndex
                f_10420_13565_13594(string
                name, int
                index)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.NameAndIndex(name, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 13565, 13594);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeTemplateSymbol>
                f_10420_12840_12847_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeTemplateSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 12840, 12847);
                    return return_v;
                }


                int
                f_10420_13634_13654(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager
                this_param)
                {
                    this_param.SealTemplates();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 13634, 13654);
                    return 0;
                }


                int
                f_10420_13690_13703(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeTemplateSymbol>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10420, 13690, 13703);
                    return return_v;
                }


                bool
                f_10420_13712_13756(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.ReportMissingOrErroneousSymbols(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 13712, 13756);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                f_10420_14058_14080(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.GetCciAdapter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 14058, 14080);
                    return return_v;
                }


                int
                f_10420_14006_14081(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeTemplateSymbol
                container, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                method)
                {
                    this_param.AddSynthesizedDefinition((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)container, (Microsoft.Cci.IMethodDefinition)method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 14006, 14081);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10420_13933_13956_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 13933, 13956);
                    return return_v;
                }


                object
                f_10420_14129_14159(Microsoft.CodeAnalysis.CSharp.MethodCompiler
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeTemplateSymbol
                symbol, Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                argument)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, argument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 14129, 14159);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeTemplateSymbol>
                f_10420_13861_13868_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeTemplateSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 13861, 13868);
                    return return_v;
                }


                int
                f_10420_14210_14224(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeTemplateSymbol>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 14210, 14224);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedDelegateSymbol>
                f_10420_14268_14321()
                {
                    var return_v = ArrayBuilder<SynthesizedDelegateSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 14268, 14321);
                    return return_v;
                }


                int
                f_10420_14336_14388(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedDelegateSymbol>
                builder)
                {
                    this_param.GetCreatedSynthesizedDelegates(builder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 14336, 14388);
                    return 0;
                }


                object
                f_10420_14493_14534(Microsoft.CodeAnalysis.CSharp.MethodCompiler
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedDelegateSymbol
                symbol, Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                argument)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, argument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 14493, 14534);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedDelegateSymbol>
                f_10420_14439_14459_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedDelegateSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 14439, 14459);
                    return return_v;
                }


                int
                f_10420_14564_14591(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedDelegateSymbol>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 14564, 14591);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10420, 10827, 14603);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10420, 10827, 14603);
            }
        }

        private void GetCreatedAnonymousTypeTemplates(ArrayBuilder<AnonymousTypeTemplateSymbol> builder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10420, 14778, 15476);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 14899, 14928);

                f_10420_14899_14927(!f_10420_14913_14926(builder));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 14942, 14991);

                var
                anonymousTypes = _lazyAnonymousTypeTemplates
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 15005, 15465) || true) && (anonymousTypes != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10420, 15005, 15465);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 15065, 15310);
                        foreach (var template in f_10420_15090_15111_I(f_10420_15090_15111(anonymousTypes)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10420, 15065, 15310);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 15153, 15291) || true) && (f_10420_15157_15196(template.Manager, this))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10420, 15153, 15291);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 15246, 15268);

                                f_10420_15246_15267(builder, template);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10420, 15153, 15291);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10420, 15065, 15310);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10420, 1, 246);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10420, 1, 246);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 15392, 15450);

                    f_10420_15392_15449(                // Sort type templates using smallest location
                                    builder, f_10420_15405_15448(f_10420_15431_15447(this)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10420, 15005, 15465);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10420, 14778, 15476);

                bool
                f_10420_14913_14926(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeTemplateSymbol>
                this_param)
                {
                    var return_v = this_param.Any();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 14913, 14926);
                    return return_v;
                }


                int
                f_10420_14899_14927(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 14899, 14927);
                    return 0;
                }


                System.Collections.Generic.ICollection<Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeTemplateSymbol>
                f_10420_15090_15111(System.Collections.Concurrent.ConcurrentDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeTemplateSymbol>
                this_param)
                {
                    var return_v = this_param.Values;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10420, 15090, 15111);
                    return return_v;
                }


                bool
                f_10420_15157_15196(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager
                objA, Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 15157, 15196);
                    return return_v;
                }


                int
                f_10420_15246_15267(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeTemplateSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeTemplateSymbol
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 15246, 15267);
                    return 0;
                }


                System.Collections.Generic.ICollection<Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeTemplateSymbol>
                f_10420_15090_15111_I(System.Collections.Generic.ICollection<Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeTemplateSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 15090, 15111);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10420_15431_15447(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10420, 15431, 15447);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeComparer
                f_10420_15405_15448(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeComparer(compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 15405, 15448);
                    return return_v;
                }


                int
                f_10420_15392_15449(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeTemplateSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeComparer
                comparer)
                {
                    this_param.Sort((System.Collections.Generic.IComparer<Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeTemplateSymbol>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 15392, 15449);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10420, 14778, 15476);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10420, 14778, 15476);
            }
        }

        private void GetCreatedSynthesizedDelegates(ArrayBuilder<SynthesizedDelegateSymbol> builder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10420, 15632, 16253);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 15749, 15778);

                f_10420_15749_15777(!f_10420_15763_15776(builder));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 15792, 15834);

                var
                delegates = _lazySynthesizedDelegates
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 15848, 16242) || true) && (delegates != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10420, 15848, 16242);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 15903, 16152);
                        foreach (var template in f_10420_15928_15944_I(f_10420_15928_15944(delegates)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10420, 15903, 16152);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 15986, 16133) || true) && (f_10420_15990_16029(template.Manager, this))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10420, 15986, 16133);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 16079, 16110);

                                f_10420_16079_16109(builder, template.Delegate);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10420, 15986, 16133);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10420, 15903, 16152);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10420, 1, 250);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10420, 1, 250);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 16170, 16227);

                    f_10420_16170_16226(builder, SynthesizedDelegateSymbolComparer.Instance);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10420, 15848, 16242);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10420, 15632, 16253);

                bool
                f_10420_15763_15776(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedDelegateSymbol>
                this_param)
                {
                    var return_v = this_param.Any();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 15763, 15776);
                    return return_v;
                }


                int
                f_10420_15749_15777(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 15749, 15777);
                    return 0;
                }


                System.Collections.Generic.ICollection<Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.SynthesizedDelegateValue>
                f_10420_15928_15944(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.SynthesizedDelegateKey, Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.SynthesizedDelegateValue>
                this_param)
                {
                    var return_v = this_param.Values;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10420, 15928, 15944);
                    return return_v;
                }


                bool
                f_10420_15990_16029(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager
                objA, Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 15990, 16029);
                    return return_v;
                }


                int
                f_10420_16079_16109(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedDelegateSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedDelegateSymbol
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 16079, 16109);
                    return 0;
                }


                System.Collections.Generic.ICollection<Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.SynthesizedDelegateValue>
                f_10420_15928_15944_I(System.Collections.Generic.ICollection<Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.SynthesizedDelegateValue>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 15928, 15944);
                    return return_v;
                }


                int
                f_10420_16170_16226(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedDelegateSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.SynthesizedDelegateSymbolComparer
                comparer)
                {
                    this_param.Sort((System.Collections.Generic.IComparer<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedDelegateSymbol>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 16170, 16226);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10420, 15632, 16253);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10420, 15632, 16253);
            }
        }
        private class SynthesizedDelegateSymbolComparer : IComparer<SynthesizedDelegateSymbol>
        {
            public static readonly SynthesizedDelegateSymbolComparer Instance;

            public int Compare(SynthesizedDelegateSymbol x, SynthesizedDelegateSymbol y)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10420, 16500, 16672);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 16609, 16657);

                    return f_10420_16616_16656(f_10420_16616_16630(x), f_10420_16641_16655(y));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10420, 16500, 16672);

                    string
                    f_10420_16616_16630(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedDelegateSymbol
                    this_param)
                    {
                        var return_v = this_param.MetadataName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10420, 16616, 16630);
                        return return_v;
                    }


                    string
                    f_10420_16641_16655(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedDelegateSymbol
                    this_param)
                    {
                        var return_v = this_param.MetadataName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10420, 16641, 16655);
                        return return_v;
                    }


                    int
                    f_10420_16616_16656(string
                    this_param, string
                    strB)
                    {
                        var return_v = this_param.CompareTo(strB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 16616, 16656);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10420, 16500, 16672);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10420, 16500, 16672);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public SynthesizedDelegateSymbolComparer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10420, 16265, 16683);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10420, 16265, 16683);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10420, 16265, 16683);
            }


            static SynthesizedDelegateSymbolComparer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10420, 16265, 16683);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 16433, 16483);
                Instance = f_10420_16444_16483(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10420, 16265, 16683);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10420, 16265, 16683);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10420, 16265, 16683);

            static Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.SynthesizedDelegateSymbolComparer
            f_10420_16444_16483()
            {
                var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.SynthesizedDelegateSymbolComparer();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 16444, 16483);
                return return_v;
            }

        }

        internal IReadOnlyDictionary<Microsoft.CodeAnalysis.Emit.AnonymousTypeKey, Microsoft.CodeAnalysis.Emit.AnonymousTypeValue> GetAnonymousTypeMap()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10420, 16695, 17846);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 16864, 16988);

                var
                result = f_10420_16877_16987()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 17002, 17074);

                var
                templates = f_10420_17018_17073()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 17348, 17392);

                f_10420_17348_17391(this, templates);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 17406, 17776);
                    foreach (var template in f_10420_17431_17440_I(templates))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10420, 17406, 17776);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 17474, 17515);

                        var
                        nameAndIndex = f_10420_17493_17514(template)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 17533, 17574);

                        var
                        key = f_10420_17543_17573(template)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 17592, 17720);

                        var
                        value = f_10420_17604_17719(nameAndIndex.Name, nameAndIndex.Index, f_10420_17694_17718(template))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 17738, 17761);

                        f_10420_17738_17760(result, key, value);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10420, 17406, 17776);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10420, 1, 371);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10420, 1, 371);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 17790, 17807);

                f_10420_17790_17806(templates);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 17821, 17835);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10420, 16695, 17846);

                System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Emit.AnonymousTypeKey, Microsoft.CodeAnalysis.Emit.AnonymousTypeValue>
                f_10420_16877_16987()
                {
                    var return_v = new System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Emit.AnonymousTypeKey, Microsoft.CodeAnalysis.Emit.AnonymousTypeValue>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 16877, 16987);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeTemplateSymbol>
                f_10420_17018_17073()
                {
                    var return_v = ArrayBuilder<AnonymousTypeTemplateSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 17018, 17073);
                    return return_v;
                }


                int
                f_10420_17348_17391(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeTemplateSymbol>
                builder)
                {
                    this_param.GetCreatedAnonymousTypeTemplates(builder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 17348, 17391);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.NameAndIndex
                f_10420_17493_17514(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeTemplateSymbol
                this_param)
                {
                    var return_v = this_param.NameAndIndex;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10420, 17493, 17514);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.AnonymousTypeKey
                f_10420_17543_17573(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeTemplateSymbol
                this_param)
                {
                    var return_v = this_param.GetAnonymousTypeKey();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 17543, 17573);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                f_10420_17694_17718(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeTemplateSymbol
                this_param)
                {
                    var return_v = this_param.GetCciAdapter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 17694, 17718);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.AnonymousTypeValue
                f_10420_17604_17719(string
                name, int
                uniqueIndex, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.Emit.AnonymousTypeValue(name, uniqueIndex, (Microsoft.Cci.ITypeDefinition)type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 17604, 17719);
                    return return_v;
                }


                int
                f_10420_17738_17760(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Emit.AnonymousTypeKey, Microsoft.CodeAnalysis.Emit.AnonymousTypeValue>
                this_param, Microsoft.CodeAnalysis.Emit.AnonymousTypeKey
                key, Microsoft.CodeAnalysis.Emit.AnonymousTypeValue
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 17738, 17760);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeTemplateSymbol>
                f_10420_17431_17440_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeTemplateSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 17431, 17440);
                    return return_v;
                }


                int
                f_10420_17790_17806(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeTemplateSymbol>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 17790, 17806);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10420, 16695, 17846);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10420, 16695, 17846);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal ImmutableArray<NamedTypeSymbol> GetAllCreatedTemplates()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10420, 17967, 18773);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 18154, 18212);

                var
                builder = f_10420_18168_18211()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 18228, 18305);

                var
                anonymousTypes = f_10420_18249_18304()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 18319, 18368);

                f_10420_18319_18367(this, anonymousTypes);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 18382, 18415);

                f_10420_18382_18414(builder, anonymousTypes);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 18429, 18451);

                f_10420_18429_18450(anonymousTypes);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 18467, 18548);

                var
                synthesizedDelegates = f_10420_18494_18547()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 18562, 18615);

                f_10420_18562_18614(this, synthesizedDelegates);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 18629, 18668);

                f_10420_18629_18667(builder, synthesizedDelegates);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 18682, 18710);

                f_10420_18682_18709(synthesizedDelegates);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 18726, 18762);

                return f_10420_18733_18761(builder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10420, 17967, 18773);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10420_18168_18211()
                {
                    var return_v = ArrayBuilder<NamedTypeSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 18168, 18211);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeTemplateSymbol>
                f_10420_18249_18304()
                {
                    var return_v = ArrayBuilder<AnonymousTypeTemplateSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 18249, 18304);
                    return return_v;
                }


                int
                f_10420_18319_18367(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeTemplateSymbol>
                builder)
                {
                    this_param.GetCreatedAnonymousTypeTemplates(builder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 18319, 18367);
                    return 0;
                }


                int
                f_10420_18382_18414(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeTemplateSymbol>
                items)
                {
                    this_param.AddRange<Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeTemplateSymbol>(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 18382, 18414);
                    return 0;
                }


                int
                f_10420_18429_18450(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeTemplateSymbol>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 18429, 18450);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedDelegateSymbol>
                f_10420_18494_18547()
                {
                    var return_v = ArrayBuilder<SynthesizedDelegateSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 18494, 18547);
                    return return_v;
                }


                int
                f_10420_18562_18614(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedDelegateSymbol>
                builder)
                {
                    this_param.GetCreatedSynthesizedDelegates(builder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 18562, 18614);
                    return 0;
                }


                int
                f_10420_18629_18667(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedDelegateSymbol>
                items)
                {
                    this_param.AddRange<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedDelegateSymbol>(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 18629, 18667);
                    return 0;
                }


                int
                f_10420_18682_18709(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedDelegateSymbol>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 18682, 18709);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10420_18733_18761(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 18733, 18761);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10420, 17967, 18773);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10420, 17967, 18773);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsAnonymousTypeTemplate(NamedTypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10420, 18928, 19073);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 19019, 19062);

                return type is AnonymousTypeTemplateSymbol;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10420, 18928, 19073);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10420, 18928, 19073);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10420, 18928, 19073);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ImmutableArray<MethodSymbol> GetAnonymousTypeHiddenMethods(NamedTypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10420, 19327, 19566);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 19448, 19483);

                f_10420_19448_19482((object)type != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 19497, 19555);

                return ((AnonymousTypeTemplateSymbol)type).SpecialMembers;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10420, 19327, 19566);

                int
                f_10420_19448_19482(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 19448, 19482);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10420, 19327, 19566);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10420, 19327, 19566);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static NamedTypeSymbol TranslateAnonymousTypeSymbol(NamedTypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10420, 19733, 20092);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 19840, 19875);

                f_10420_19840_19874((object)type != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 19889, 19924);

                f_10420_19889_19923(f_10420_19902_19922(type));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 19940, 19988);

                var
                anonymous = (AnonymousTypePublicSymbol)type
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 20002, 20081);

                return f_10420_20009_20080(anonymous.Manager, anonymous);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10420, 19733, 20092);

                int
                f_10420_19840_19874(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 19840, 19874);
                    return 0;
                }


                bool
                f_10420_19902_19922(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsAnonymousType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10420, 19902, 19922);
                    return return_v;
                }


                int
                f_10420_19889_19923(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 19889, 19923);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10420_20009_20080(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypePublicSymbol
                anonymous)
                {
                    var return_v = this_param.ConstructAnonymousTypeImplementationSymbol(anonymous);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 20009, 20080);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10420, 19733, 20092);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10420, 19733, 20092);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static MethodSymbol TranslateAnonymousTypeMethodSymbol(MethodSymbol method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10420, 20261, 21023);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 20370, 20407);

                f_10420_20370_20406((object)method != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 20421, 20506);

                NamedTypeSymbol
                translatedType = f_10420_20454_20505(f_10420_20483_20504(method))
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 20585, 20961);
                    foreach (var member in f_10420_20608_20684_I(f_10420_20608_20684(((NamedTypeSymbol)f_10420_20626_20659(translatedType)), f_10420_20672_20683(method))))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10420, 20585, 20961);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 20718, 20946) || true) && (f_10420_20722_20733(member) == SymbolKind.Method)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10420, 20718, 20946);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 20872, 20927);

                            return f_10420_20879_20926(((MethodSymbol)member), translatedType);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10420, 20718, 20946);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10420, 20585, 20961);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10420, 1, 377);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10420, 1, 377);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 20975, 21012);

                throw f_10420_20981_21011();
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10420, 20261, 21023);

                int
                f_10420_20370_20406(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 20370, 20406);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10420_20483_20504(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10420, 20483, 20504);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10420_20454_20505(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = TranslateAnonymousTypeSymbol(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 20454, 20505);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10420_20626_20659(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10420, 20626, 20659);
                    return return_v;
                }


                string
                f_10420_20672_20683(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10420, 20672, 20683);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10420_20608_20684(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 20608, 20684);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10420_20722_20733(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10420, 20722, 20733);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10420_20879_20926(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                newOwner)
                {
                    var return_v = this_param.AsMember(newOwner);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 20879, 20926);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10420_20608_20684_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 20608, 20684);
                    return return_v;
                }


                System.Exception
                f_10420_20981_21011()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10420, 20981, 21011);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10420, 20261, 21023);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10420, 20261, 21023);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        private sealed class AnonymousTypeComparer : IComparer<AnonymousTypeTemplateSymbol>
        {
            private readonly CSharpCompilation _compilation;

            public AnonymousTypeComparer(CSharpCompilation compilation)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10420, 21337, 21471);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 21308, 21320);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 21429, 21456);

                    _compilation = compilation;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10420, 21337, 21471);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10420, 21337, 21471);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10420, 21337, 21471);
                }
            }

            public int Compare(AnonymousTypeTemplateSymbol x, AnonymousTypeTemplateSymbol y)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10420, 21487, 22408);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 21600, 21696) || true) && ((object)x == (object)y)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10420, 21600, 21696);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 21668, 21677);

                        return 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10420, 21600, 21696);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 21919, 21994);

                    int
                    result = f_10420_21932_21993(this, f_10420_21954_21972(x), f_10420_21974_21992(y))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 22014, 22359) || true) && (result == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10420, 22014, 22359);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 22267, 22340);

                        result = f_10420_22276_22339(x.TypeDescriptorKey, y.TypeDescriptorKey);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10420, 22014, 22359);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 22379, 22393);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10420, 21487, 22408);

                    Microsoft.CodeAnalysis.Location
                    f_10420_21954_21972(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeTemplateSymbol
                    this_param)
                    {
                        var return_v = this_param.SmallestLocation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10420, 21954, 21972);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Location
                    f_10420_21974_21992(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeTemplateSymbol
                    this_param)
                    {
                        var return_v = this_param.SmallestLocation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10420, 21974, 21992);
                        return return_v;
                    }


                    int
                    f_10420_21932_21993(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeComparer
                    this_param, Microsoft.CodeAnalysis.Location
                    x, Microsoft.CodeAnalysis.Location
                    y)
                    {
                        var return_v = this_param.CompareLocations(x, y);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 21932, 21993);
                        return return_v;
                    }


                    int
                    f_10420_22276_22339(string
                    strA, string
                    strB)
                    {
                        var return_v = string.CompareOrdinal(strA, strB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 22276, 22339);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10420, 21487, 22408);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10420, 21487, 22408);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private int CompareLocations(Location x, Location y)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10420, 22424, 22966);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 22509, 22951) || true) && (x == y)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10420, 22509, 22951);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 22561, 22570);

                        return 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10420, 22509, 22951);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10420, 22509, 22951);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 22612, 22951) || true) && (x == f_10420_22621_22634())
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10420, 22612, 22951);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 22676, 22686);

                            return -1;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10420, 22612, 22951);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10420, 22612, 22951);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 22728, 22951) || true) && (y == f_10420_22737_22750())
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10420, 22728, 22951);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 22792, 22801);

                                return 1;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10420, 22728, 22951);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10420, 22728, 22951);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 22883, 22932);

                                return f_10420_22890_22931(_compilation, x, y);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10420, 22728, 22951);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10420, 22612, 22951);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10420, 22509, 22951);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10420, 22424, 22966);

                    Microsoft.CodeAnalysis.Location
                    f_10420_22621_22634()
                    {
                        var return_v = Location.None;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10420, 22621, 22634);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Location
                    f_10420_22737_22750()
                    {
                        var return_v = Location.None;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10420, 22737, 22750);
                        return return_v;
                    }


                    int
                    f_10420_22890_22931(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    this_param, Microsoft.CodeAnalysis.Location
                    loc1, Microsoft.CodeAnalysis.Location
                    loc2)
                    {
                        var return_v = this_param.CompareSourceLocations(loc1, loc2);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 22890, 22931);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10420, 22424, 22966);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10420, 22424, 22966);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static AnonymousTypeComparer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10420, 21165, 22977);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10420, 21165, 22977);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10420, 21165, 22977);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10420, 21165, 22977);
        }
    }
}
