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
            Debug.Assert(!Frozen);

            if (_lazyStateMachineTypes == null)
            {
                Interlocked.CompareExchange(ref _lazyStateMachineTypes, new Dictionary<TMethodSymbol, TNamedTypeSymbol>(), null);
            }

            lock (_lazyStateMachineTypes)
            {
                _lazyStateMachineTypes.Add(method, stateMachineClass);
            }
        }

        internal bool TryGetStateMachineType(TMethodSymbol method, [NotNullWhen(true)] out TNamedTypeSymbol? stateMachineType)
        {
            Debug.Assert(Frozen);

            stateMachineType = null;
            return _lazyStateMachineTypes != null && _lazyStateMachineTypes.TryGetValue(method, out stateMachineType);
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
