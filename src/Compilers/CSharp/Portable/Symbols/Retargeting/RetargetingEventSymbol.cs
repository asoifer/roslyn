// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;
using System.Diagnostics;
using System.Globalization;
using System.Threading;
using Microsoft.CodeAnalysis.CSharp.Emit;

namespace Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting
{
    internal sealed class RetargetingEventSymbol : WrappedEventSymbol
    {
        private readonly RetargetingModuleSymbol _retargetingModule;

        private ImmutableArray<EventSymbol> _lazyExplicitInterfaceImplementations;

        private DiagnosticInfo? _lazyUseSiteDiagnostic;

        public RetargetingEventSymbol(RetargetingModuleSymbol retargetingModule, EventSymbol underlyingEvent)
        : base(f_10595_1356_1371_C(underlyingEvent))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10595, 1234, 1590);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10595, 901, 919);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10595, 1136, 1192);
                this._lazyUseSiteDiagnostic = CSDiagnosticInfo.EmptyErrorInfo; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10595, 1397, 1451);

                f_10595_1397_1450((object)retargetingModule != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10595, 1465, 1524);

                f_10595_1465_1523(!(underlyingEvent is RetargetingEventSymbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10595, 1540, 1579);

                _retargetingModule = retargetingModule;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10595, 1234, 1590);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10595, 1234, 1590);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10595, 1234, 1590);
            }
        }

        private RetargetingModuleSymbol.RetargetingSymbolTranslator RetargetingTranslator
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10595, 1708, 1807);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10595, 1744, 1792);

                    return _retargetingModule.RetargetingTranslator;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10595, 1708, 1807);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10595, 1602, 1818);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10595, 1602, 1818);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override TypeWithAnnotations TypeWithAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10595, 1910, 2092);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10595, 1946, 2077);

                    return f_10595_1953_2076(f_10595_1953_1979(this), f_10595_1989_2025(_underlyingEvent), RetargetOptions.RetargetPrimitiveTypesByTypeCode);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10595, 1910, 2092);

                    Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    f_10595_1953_1979(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingEventSymbol
                    this_param)
                    {
                        var return_v = this_param.RetargetingTranslator;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10595, 1953, 1979);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    f_10595_1989_2025(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    this_param)
                    {
                        var return_v = this_param.TypeWithAnnotations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10595, 1989, 2025);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    f_10595_1953_2076(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    underlyingType, Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetOptions
                    options)
                    {
                        var return_v = this_param.Retarget(underlyingType, options);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10595, 1953, 2076);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10595, 1830, 2103);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10595, 1830, 2103);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override MethodSymbol? AddMethod
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10595, 2179, 2396);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10595, 2215, 2381);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10595, 2222, 2265) || (((object?)f_10595_2231_2257(_underlyingEvent) == null
                    && DynAbs.Tracing.TraceSender.Conditional_F2(10595, 2289, 2293)) || DynAbs.Tracing.TraceSender.Conditional_F3(10595, 2317, 2380))) ? null
                    : f_10595_2317_2380(f_10595_2317_2343(this), f_10595_2353_2379(_underlyingEvent));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10595, 2179, 2396);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                    f_10595_2231_2257(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    this_param)
                    {
                        var return_v = this_param.AddMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10595, 2231, 2257);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    f_10595_2317_2343(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingEventSymbol
                    this_param)
                    {
                        var return_v = this_param.RetargetingTranslator;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10595, 2317, 2343);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10595_2353_2379(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    this_param)
                    {
                        var return_v = this_param.AddMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10595, 2353, 2379);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10595_2317_2380(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    method)
                    {
                        var return_v = this_param.Retarget(method);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10595, 2317, 2380);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10595, 2115, 2407);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10595, 2115, 2407);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override MethodSymbol? RemoveMethod
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10595, 2486, 2709);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10595, 2522, 2694);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10595, 2529, 2575) || (((object?)f_10595_2538_2567(_underlyingEvent) == null
                    && DynAbs.Tracing.TraceSender.Conditional_F2(10595, 2599, 2603)) || DynAbs.Tracing.TraceSender.Conditional_F3(10595, 2627, 2693))) ? null
                    : f_10595_2627_2693(f_10595_2627_2653(this), f_10595_2663_2692(_underlyingEvent));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10595, 2486, 2709);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                    f_10595_2538_2567(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    this_param)
                    {
                        var return_v = this_param.RemoveMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10595, 2538, 2567);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    f_10595_2627_2653(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingEventSymbol
                    this_param)
                    {
                        var return_v = this_param.RetargetingTranslator;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10595, 2627, 2653);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10595_2663_2692(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    this_param)
                    {
                        var return_v = this_param.RemoveMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10595, 2663, 2692);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10595_2627_2693(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    method)
                    {
                        var return_v = this_param.Retarget(method);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10595, 2627, 2693);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10595, 2419, 2720);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10595, 2419, 2720);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override FieldSymbol? AssociatedField
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10595, 2803, 3032);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10595, 2839, 3017);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10595, 2846, 2895) || (((object?)f_10595_2855_2887(_underlyingEvent) == null
                    && DynAbs.Tracing.TraceSender.Conditional_F2(10595, 2919, 2923)) || DynAbs.Tracing.TraceSender.Conditional_F3(10595, 2947, 3016))) ? null
                    : f_10595_2947_3016(f_10595_2947_2973(this), f_10595_2983_3015(_underlyingEvent));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10595, 2803, 3032);

                    Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol?
                    f_10595_2855_2887(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    this_param)
                    {
                        var return_v = this_param.AssociatedField;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10595, 2855, 2887);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    f_10595_2947_2973(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingEventSymbol
                    this_param)
                    {
                        var return_v = this_param.RetargetingTranslator;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10595, 2947, 2973);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    f_10595_2983_3015(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    this_param)
                    {
                        var return_v = this_param.AssociatedField;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10595, 2983, 3015);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    f_10595_2947_3016(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    field)
                    {
                        var return_v = this_param.Retarget(field);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10595, 2947, 3016);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10595, 2732, 3043);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10595, 2732, 3043);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsExplicitInterfaceImplementation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10595, 3136, 3202);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10595, 3142, 3200);

                    return f_10595_3149_3199(_underlyingEvent);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10595, 3136, 3202);

                    bool
                    f_10595_3149_3199(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    this_param)
                    {
                        var return_v = this_param.IsExplicitInterfaceImplementation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10595, 3149, 3199);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10595, 3055, 3213);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10595, 3055, 3213);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<EventSymbol> ExplicitInterfaceImplementations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10595, 3326, 3806);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10595, 3362, 3728) || true) && (_lazyExplicitInterfaceImplementations.IsDefault)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10595, 3362, 3728);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10595, 3455, 3709);

                        f_10595_3455_3708(ref _lazyExplicitInterfaceImplementations, f_10595_3597_3644(this), default(ImmutableArray<EventSymbol>));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10595, 3362, 3728);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10595, 3746, 3791);

                    return _lazyExplicitInterfaceImplementations;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10595, 3326, 3806);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol>
                    f_10595_3597_3644(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingEventSymbol
                    this_param)
                    {
                        var return_v = this_param.RetargetExplicitInterfaceImplementations();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10595, 3597, 3644);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol>
                    f_10595_3455_3708(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol>
                    location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol>
                    value, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol>
                    comparand)
                    {
                        var return_v = ImmutableInterlocked.InterlockedCompareExchange(ref location, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10595, 3455, 3708);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10595, 3225, 3817);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10595, 3225, 3817);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private ImmutableArray<EventSymbol> RetargetExplicitInterfaceImplementations()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10595, 3829, 4640);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10595, 3932, 3994);

                var
                impls = f_10595_3944_3993(_underlyingEvent)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10595, 4010, 4089) || true) && (impls.IsEmpty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10595, 4010, 4089);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10595, 4061, 4074);

                    return impls;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10595, 4010, 4089);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10595, 4224, 4278);

                var
                builder = f_10595_4238_4277()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10595, 4303, 4308);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10595, 4294, 4577) || true) && (i < impls.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10595, 4328, 4331)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10595, 4294, 4577))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10595, 4294, 4577);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10595, 4365, 4428);

                        var
                        retargeted = f_10595_4382_4427(f_10595_4382_4408(this), impls[i])
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10595, 4446, 4562) || true) && ((object?)retargeted != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10595, 4446, 4562);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10595, 4519, 4543);

                            f_10595_4519_4542(builder, retargeted);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10595, 4446, 4562);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10595, 1, 284);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10595, 1, 284);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10595, 4593, 4629);

                return f_10595_4600_4628(builder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10595, 3829, 4640);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol>
                f_10595_3944_3993(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.ExplicitInterfaceImplementations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10595, 3944, 3993);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol>
                f_10595_4238_4277()
                {
                    var return_v = ArrayBuilder<EventSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10595, 4238, 4277);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                f_10595_4382_4408(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingEventSymbol
                this_param)
                {
                    var return_v = this_param.RetargetingTranslator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10595, 4382, 4408);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                f_10595_4382_4427(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                @event)
                {
                    var return_v = this_param.Retarget(@event);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10595, 4382, 4427);
                    return return_v;
                }


                int
                f_10595_4519_4542(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10595, 4519, 4542);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol>
                f_10595_4600_4628(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10595, 4600, 4628);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10595, 3829, 4640);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10595, 3829, 4640);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override Symbol? ContainingSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10595, 4717, 4846);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10595, 4753, 4831);

                    return f_10595_4760_4830(f_10595_4760_4786(this), f_10595_4796_4829(_underlyingEvent));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10595, 4717, 4846);

                    Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    f_10595_4760_4786(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingEventSymbol
                    this_param)
                    {
                        var return_v = this_param.RetargetingTranslator;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10595, 4760, 4786);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10595_4796_4829(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10595, 4796, 4829);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10595_4760_4830(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                    symbol)
                    {
                        var return_v = this_param.Retarget(symbol);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10595, 4760, 4830);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10595, 4652, 4857);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10595, 4652, 4857);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override AssemblySymbol ContainingAssembly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10595, 4943, 5039);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10595, 4979, 5024);

                    return f_10595_4986_5023(_retargetingModule);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10595, 4943, 5039);

                    Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    f_10595_4986_5023(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingAssembly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10595, 4986, 5023);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10595, 4869, 5050);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10595, 4869, 5050);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ModuleSymbol ContainingModule
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10595, 5134, 5211);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10595, 5170, 5196);

                    return _retargetingModule;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10595, 5134, 5211);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10595, 5062, 5222);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10595, 5062, 5222);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<CSharpAttributeData> GetAttributes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10595, 5234, 5377);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10595, 5326, 5366);

                return f_10595_5333_5365(_underlyingEvent);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10595, 5234, 5377);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10595_5333_5365(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.GetAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10595, 5333, 5365);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10595, 5234, 5377);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10595, 5234, 5377);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override IEnumerable<CSharpAttributeData> GetCustomAttributesToEmit(PEModuleBuilder moduleBuilder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10595, 5389, 5644);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10595, 5521, 5633);

                return f_10595_5528_5632(f_10595_5528_5554(this), f_10595_5574_5631(_underlyingEvent, moduleBuilder));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10595, 5389, 5644);

                Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                f_10595_5528_5554(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingEventSymbol
                this_param)
                {
                    var return_v = this_param.RetargetingTranslator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10595, 5528, 5554);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10595_5574_5631(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                moduleBuilder)
                {
                    var return_v = this_param.GetCustomAttributesToEmit(moduleBuilder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10595, 5574, 5631);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10595_5528_5632(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                this_param, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                attributes)
                {
                    var return_v = this_param.RetargetAttributes(attributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10595, 5528, 5632);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10595, 5389, 5644);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10595, 5389, 5644);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool MustCallMethodsDirectly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10595, 5727, 5826);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10595, 5763, 5811);

                    return f_10595_5770_5810(_underlyingEvent);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10595, 5727, 5826);

                    bool
                    f_10595_5770_5810(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    this_param)
                    {
                        var return_v = this_param.MustCallMethodsDirectly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10595, 5770, 5810);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10595, 5656, 5837);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10595, 5656, 5837);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override DiagnosticInfo? GetUseSiteDiagnostic()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10595, 5849, 6249);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10595, 5930, 6192) || true) && (f_10595_5934_6006(_lazyUseSiteDiagnostic, CSDiagnosticInfo.EmptyErrorInfo))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10595, 5930, 6192);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10595, 6040, 6070);

                    DiagnosticInfo?
                    result = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10595, 6088, 6127);

                    f_10595_6088_6126(this, ref result);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10595, 6145, 6177);

                    _lazyUseSiteDiagnostic = result;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10595, 5930, 6192);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10595, 6208, 6238);

                return _lazyUseSiteDiagnostic;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10595, 5849, 6249);

                bool
                f_10595_5934_6006(Microsoft.CodeAnalysis.DiagnosticInfo?
                objA, Microsoft.CodeAnalysis.DiagnosticInfo
                objB)
                {
                    var return_v = ReferenceEquals((object?)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10595, 5934, 6006);
                    return return_v;
                }


                bool
                f_10595_6088_6126(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingEventSymbol
                this_param, ref Microsoft.CodeAnalysis.DiagnosticInfo?
                result)
                {
                    var return_v = this_param.CalculateUseSiteDiagnostic(ref result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10595, 6088, 6126);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10595, 5849, 6249);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10595, 5849, 6249);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal sealed override CSharpCompilation? DeclaringCompilation // perf, not correctness
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10595, 6375, 6395);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10595, 6381, 6393);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10595, 6375, 6395);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10595, 6261, 6406);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10595, 6261, 6406);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static RetargetingEventSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10595, 686, 6413);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10595, 686, 6413);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10595, 686, 6413);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10595, 686, 6413);

        int
        f_10595_1397_1450(bool
        b)
        {
            RoslynDebug.Assert(b);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10595, 1397, 1450);
            return 0;
        }


        int
        f_10595_1465_1523(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10595, 1465, 1523);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
        f_10595_1356_1371_C(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10595, 1234, 1590);
            return return_v;
        }

    }
}
