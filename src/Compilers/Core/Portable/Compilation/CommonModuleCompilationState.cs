// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Threading;
using Microsoft.CodeAnalysis.Symbols;

namespace Microsoft.CodeAnalysis
{
    internal class CommonModuleCompilationState
    {
        private bool _frozen;

        internal void Freeze()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(143, 510, 734);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(143, 557, 580);

                f_143_557_579(!_frozen);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(143, 664, 692);

                f_143_664_691();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(143, 708, 723);

                _frozen = true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(143, 510, 734);

                int
                f_143_557_579(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(143, 557, 579);
                    return 0;
                }


                int
                f_143_664_691()
                {
                    Interlocked.MemoryBarrier();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(143, 664, 691);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(143, 510, 734);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(143, 510, 734);
            }
        }

        internal bool Frozen
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(143, 791, 814);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(143, 797, 812);

                    return _frozen;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(143, 791, 814);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(143, 746, 825);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(143, 746, 825);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public CommonModuleCompilationState()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(143, 417, 832);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(143, 490, 497);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(143, 417, 832);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(143, 417, 832);
        }


        static CommonModuleCompilationState()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(143, 417, 832);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(143, 417, 832);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(143, 417, 832);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(143, 417, 832);
    }
    internal class ModuleCompilationState<TNamedTypeSymbol, TMethodSymbol> : CommonModuleCompilationState
            where TNamedTypeSymbol : class, INamedTypeSymbolInternal
            where TMethodSymbol : class, IMethodSymbolInternal
    {
        private Dictionary<TMethodSymbol, TNamedTypeSymbol>? _lazyStateMachineTypes;

        internal void SetStateMachineType(TMethodSymbol method, TNamedTypeSymbol stateMachineClass)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(143, 1329, 1837);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(143, 1445, 1467);

                f_143_1445_1466(f_143_1458_1465_M(!Frozen));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(143, 1483, 1679) || true) && (_lazyStateMachineTypes == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(143, 1483, 1679);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(143, 1551, 1664);

                    f_143_1551_1663(ref _lazyStateMachineTypes, f_143_1607_1656(), null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(143, 1483, 1679);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(143, 1701, 1723);

                lock (_lazyStateMachineTypes)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(143, 1757, 1811);

                    f_143_1757_1810(_lazyStateMachineTypes, method, stateMachineClass);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(143, 1329, 1837);

                bool
                f_143_1458_1465_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(143, 1458, 1465);
                    return return_v;
                }


                int
                f_143_1445_1466(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(143, 1445, 1466);
                    return 0;
                }


                System.Collections.Generic.Dictionary<TMethodSymbol, TNamedTypeSymbol>
                f_143_1607_1656()
                {
                    var return_v = new System.Collections.Generic.Dictionary<TMethodSymbol, TNamedTypeSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(143, 1607, 1656);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<TMethodSymbol, TNamedTypeSymbol>?
                f_143_1551_1663(ref System.Collections.Generic.Dictionary<TMethodSymbol, TNamedTypeSymbol>?
                location1, System.Collections.Generic.Dictionary<TMethodSymbol, TNamedTypeSymbol>
                value, System.Collections.Generic.Dictionary<TMethodSymbol, TNamedTypeSymbol>?
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(143, 1551, 1663);
                    return return_v;
                }


                int
                f_143_1757_1810(System.Collections.Generic.Dictionary<TMethodSymbol, TNamedTypeSymbol>
                this_param, TMethodSymbol
                key, TNamedTypeSymbol
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(143, 1757, 1810);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(143, 1329, 1837);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(143, 1329, 1837);
            }
        }


        internal bool TryGetStateMachineType(TMethodSymbol method, [NotNullWhen(true)] out TNamedTypeSymbol? stateMachineType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(143, 1849, 2184);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(143, 1992, 2013);

                f_143_1992_2012(f_143_2005_2011());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(143, 2029, 2053);

                stateMachineType = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(143, 2067, 2173);

                return _lazyStateMachineTypes != null && (DynAbs.Tracing.TraceSender.Expression_True(143, 2074, 2172) && f_143_2108_2172(_lazyStateMachineTypes, method, out stateMachineType));
                DynAbs.Tracing.TraceSender.TraceExitMethod(143, 1849, 2184);

                bool
                f_143_2005_2011()
                {
                    var return_v = Frozen;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(143, 2005, 2011);
                    return return_v;
                }


                int
                f_143_1992_2012(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(143, 1992, 2012);
                    return 0;
                }


                bool
                f_143_2108_2172(System.Collections.Generic.Dictionary<TMethodSymbol, TNamedTypeSymbol>
                this_param, TMethodSymbol
                key, out TNamedTypeSymbol?
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(143, 2108, 2172);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(143, 1849, 2184);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(143, 1849, 2184);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public ModuleCompilationState()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(143, 840, 2191);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(143, 1294, 1316);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(143, 840, 2191);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(143, 840, 2191);
        }


        static ModuleCompilationState()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(143, 840, 2191);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(143, 840, 2191);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(143, 840, 2191);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(143, 840, 2191);
    }
}
