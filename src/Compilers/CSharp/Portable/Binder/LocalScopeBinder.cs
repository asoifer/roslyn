// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal partial class LocalScopeBinder : Binder
    {
        private ImmutableArray<LocalSymbol> _locals;

        private ImmutableArray<LocalFunctionSymbol> _localFunctions;

        private ImmutableArray<LabelSymbol> _labels;

        private readonly uint _localScopeDepth;

        internal LocalScopeBinder(Binder next)
        : this(f_10350_907_911_C(next), next.Flags)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10350, 848, 946);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10350, 848, 946);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10350, 848, 946);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10350, 848, 946);
            }
        }

        internal LocalScopeBinder(Binder next, BinderFlags flags)
        : base(f_10350_1036_1040_C(next), flags)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10350, 958, 2130);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 819, 835);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 3878, 3892);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 4303, 4325);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 4784, 4798);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 1073, 1112);

                var
                parentDepth = f_10350_1091_1111(next)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 1128, 2119) || true) && (parentDepth != Binder.TopLevelScope)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10350, 1128, 2119);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 1201, 1236);

                    _localScopeDepth = parentDepth + 1;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10350, 1128, 2119);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10350, 1128, 2119);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 1434, 1457);

                    var
                    parentScope = next
                    ;
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 1475, 2104) || true) && (parentScope != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10350, 1475, 2104);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 1543, 1766) || true) && (parentScope is InMethodBinder || (DynAbs.Tracing.TraceSender.Expression_False(10350, 1547, 1621) || parentScope is WithLambdaParametersBinder))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10350, 1543, 1766);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 1671, 1711);

                                _localScopeDepth = Binder.TopLevelScope;
                                DynAbs.Tracing.TraceSender.TraceBreak(10350, 1737, 1743);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10350, 1543, 1766);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 1790, 1974) || true) && (parentScope is LocalScopeBinder)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10350, 1790, 1974);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 1875, 1919);

                                _localScopeDepth = Binder.TopLevelScope + 1;
                                DynAbs.Tracing.TraceSender.TraceBreak(10350, 1945, 1951);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10350, 1790, 1974);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 1998, 2029);

                            parentScope = f_10350_2012_2028(parentScope);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 2051, 2085);

                            f_10350_2051_2084(parentScope != null);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10350, 1475, 2104);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10350, 1475, 2104);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10350, 1475, 2104);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10350, 1128, 2119);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10350, 958, 2130);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10350, 958, 2130);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10350, 958, 2130);
            }
        }

        internal sealed override ImmutableArray<LocalSymbol> Locals
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10350, 2226, 2508);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 2262, 2458) || true) && (_locals.IsDefault)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10350, 2262, 2458);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 2325, 2439);

                        f_10350_2325_2438(ref _locals, f_10350_2386_2399(this), default(ImmutableArray<LocalSymbol>));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10350, 2262, 2458);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 2478, 2493);

                    return _locals;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10350, 2226, 2508);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    f_10350_2386_2399(Microsoft.CodeAnalysis.CSharp.LocalScopeBinder
                    this_param)
                    {
                        var return_v = this_param.BuildLocals();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10350, 2386, 2399);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    f_10350_2325_2438(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    value, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    comparand)
                    {
                        var return_v = ImmutableInterlocked.InterlockedCompareExchange(ref location, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10350, 2325, 2438);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10350, 2142, 2519);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10350, 2142, 2519);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected virtual ImmutableArray<LocalSymbol> BuildLocals()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10350, 2531, 2667);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 2615, 2656);

                return ImmutableArray<LocalSymbol>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10350, 2531, 2667);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10350, 2531, 2667);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10350, 2531, 2667);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal sealed override ImmutableArray<LocalFunctionSymbol> LocalFunctions
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10350, 2779, 3101);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 2815, 3043) || true) && (_localFunctions.IsDefault)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10350, 2815, 3043);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 2886, 3024);

                        f_10350_2886_3023(ref _localFunctions, f_10350_2955_2976(this), default(ImmutableArray<LocalFunctionSymbol>));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10350, 2815, 3043);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 3063, 3086);

                    return _localFunctions;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10350, 2779, 3101);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol>
                    f_10350_2955_2976(Microsoft.CodeAnalysis.CSharp.LocalScopeBinder
                    this_param)
                    {
                        var return_v = this_param.BuildLocalFunctions();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10350, 2955, 2976);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol>
                    f_10350_2886_3023(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol>
                    location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol>
                    value, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol>
                    comparand)
                    {
                        var return_v = ImmutableInterlocked.InterlockedCompareExchange(ref location, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10350, 2886, 3023);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10350, 2679, 3112);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10350, 2679, 3112);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected virtual ImmutableArray<LocalFunctionSymbol> BuildLocalFunctions()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10350, 3124, 3284);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 3224, 3273);

                return ImmutableArray<LocalFunctionSymbol>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10350, 3124, 3284);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10350, 3124, 3284);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10350, 3124, 3284);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal sealed override ImmutableArray<LabelSymbol> Labels
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10350, 3380, 3662);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 3416, 3612) || true) && (_labels.IsDefault)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10350, 3416, 3612);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 3479, 3593);

                        f_10350_3479_3592(ref _labels, f_10350_3540_3553(this), default(ImmutableArray<LabelSymbol>));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10350, 3416, 3612);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 3632, 3647);

                    return _labels;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10350, 3380, 3662);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                    f_10350_3540_3553(Microsoft.CodeAnalysis.CSharp.LocalScopeBinder
                    this_param)
                    {
                        var return_v = this_param.BuildLabels();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10350, 3540, 3553);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                    f_10350_3479_3592(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                    location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                    value, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                    comparand)
                    {
                        var return_v = ImmutableInterlocked.InterlockedCompareExchange(ref location, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10350, 3479, 3592);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10350, 3296, 3673);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10350, 3296, 3673);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected virtual ImmutableArray<LabelSymbol> BuildLabels()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10350, 3685, 3821);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 3769, 3810);

                return ImmutableArray<LabelSymbol>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10350, 3685, 3821);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10350, 3685, 3821);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10350, 3685, 3821);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private SmallDictionary<string, LocalSymbol> _lazyLocalsMap;

        private SmallDictionary<string, LocalSymbol> LocalsMap
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10350, 3982, 4227);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 4018, 4170) || true) && (_lazyLocalsMap == null && (DynAbs.Tracing.TraceSender.Expression_True(10350, 4022, 4070) && this.Locals.Length > 0))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10350, 4018, 4170);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 4112, 4151);

                        _lazyLocalsMap = f_10350_4129_4150(f_10350_4138_4149(this));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10350, 4018, 4170);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 4190, 4212);

                    return _lazyLocalsMap;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10350, 3982, 4227);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    f_10350_4138_4149(Microsoft.CodeAnalysis.CSharp.LocalScopeBinder
                    this_param)
                    {
                        var return_v = this_param.Locals;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10350, 4138, 4149);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SmallDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    f_10350_4129_4150(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    array)
                    {
                        var return_v = BuildMap(array);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10350, 4129, 4150);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10350, 3903, 4238);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10350, 3903, 4238);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private SmallDictionary<string, LocalFunctionSymbol> _lazyLocalFunctionsMap;

        private SmallDictionary<string, LocalFunctionSymbol> LocalFunctionsMap
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10350, 4431, 4716);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 4467, 4651) || true) && (_lazyLocalFunctionsMap == null && (DynAbs.Tracing.TraceSender.Expression_True(10350, 4471, 4535) && this.LocalFunctions.Length > 0))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10350, 4467, 4651);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 4577, 4632);

                        _lazyLocalFunctionsMap = f_10350_4602_4631(f_10350_4611_4630(this));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10350, 4467, 4651);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 4671, 4701);

                    return _lazyLocalFunctionsMap;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10350, 4431, 4716);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol>
                    f_10350_4611_4630(Microsoft.CodeAnalysis.CSharp.LocalScopeBinder
                    this_param)
                    {
                        var return_v = this_param.LocalFunctions;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10350, 4611, 4630);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SmallDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol>
                    f_10350_4602_4631(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol>
                    array)
                    {
                        var return_v = BuildMap(array);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10350, 4602, 4631);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10350, 4336, 4727);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10350, 4336, 4727);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private SmallDictionary<string, LabelSymbol> _lazyLabelsMap;

        private SmallDictionary<string, LabelSymbol> LabelsMap
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10350, 4888, 5133);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 4924, 5076) || true) && (_lazyLabelsMap == null && (DynAbs.Tracing.TraceSender.Expression_True(10350, 4928, 4976) && this.Labels.Length > 0))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10350, 4924, 5076);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 5018, 5057);

                        _lazyLabelsMap = f_10350_5035_5056(f_10350_5044_5055(this));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10350, 4924, 5076);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 5096, 5118);

                    return _lazyLabelsMap;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10350, 4888, 5133);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                    f_10350_5044_5055(Microsoft.CodeAnalysis.CSharp.LocalScopeBinder
                    this_param)
                    {
                        var return_v = this_param.Labels;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10350, 5044, 5055);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SmallDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                    f_10350_5035_5056(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                    array)
                    {
                        var return_v = BuildMap(array);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10350, 5035, 5056);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10350, 4809, 5144);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10350, 4809, 5144);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private static SmallDictionary<string, TSymbol> BuildMap<TSymbol>(ImmutableArray<TSymbol> array)
                    where TSymbol : Symbol
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10350, 5156, 5736);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 5313, 5344);

                f_10350_5313_5343<TSymbol>(array.Length > 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 5360, 5409);

                var
                map = f_10350_5370_5408<TSymbol>()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 5550, 5570);

                    // NOTE: in a rare case of having two symbols with same name the one closer to the array's start wins.
                    for (int
        i = array.Length - 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 5541, 5698) || true) && (i >= 0)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 5580, 5583)
        , i--, DynAbs.Tracing.TraceSender.TraceExitCondition(10350, 5541, 5698))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10350, 5541, 5698);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 5617, 5639);

                        var
                        symbol = array[i]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 5657, 5683);

                        map[f_10350_5661_5672<TSymbol>(symbol)] = symbol;
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10350, 1, 158);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10350, 1, 158);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 5714, 5725);

                return map;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10350, 5156, 5736);

                int
                f_10350_5313_5343<TSymbol>(bool
                condition) where TSymbol : Symbol

                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10350, 5313, 5343);
                    return 0;
                }


                Microsoft.CodeAnalysis.SmallDictionary<string, TSymbol>
                f_10350_5370_5408<TSymbol>() where TSymbol : Symbol

                {
                    var return_v = new Microsoft.CodeAnalysis.SmallDictionary<string, TSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10350, 5370, 5408);
                    return return_v;
                }


                string
                f_10350_5661_5672<TSymbol>(TSymbol
                this_param) where TSymbol : Symbol

                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10350, 5661, 5672);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10350, 5156, 5736);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10350, 5156, 5736);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected ImmutableArray<LocalSymbol> BuildLocals(SyntaxList<StatementSyntax> statements, Binder enclosingBinder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10350, 5748, 6467);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 5897, 5936);

                Binder
                currentBinder = enclosingBinder
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 5952, 6159) || true) && (true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10350, 5952, 6159);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 5997, 6089) || true) && (this == currentBinder)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10350, 5997, 6089);
                            DynAbs.Tracing.TraceSender.TraceBreak(10350, 6064, 6070);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10350, 5997, 6089);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 6109, 6144);

                        currentBinder = f_10350_6125_6143(currentBinder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10350, 5952, 6159);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10350, 5952, 6159);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10350, 5952, 6159);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 6183, 6258);

                ArrayBuilder<LocalSymbol>
                locals = f_10350_6218_6257()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 6272, 6405);
                    foreach (var statement in f_10350_6298_6308_I(statements))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10350, 6272, 6405);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 6342, 6390);

                        f_10350_6342_6389(this, enclosingBinder, statement, locals);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10350, 6272, 6405);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10350, 1, 134);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10350, 1, 134);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 6421, 6456);

                return f_10350_6428_6455(locals);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10350, 5748, 6467);

                Microsoft.CodeAnalysis.CSharp.Binder?
                f_10350_6125_6143(Microsoft.CodeAnalysis.CSharp.Binder?
                this_param)
                {
                    var return_v = this_param.Next;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10350, 6125, 6143);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10350_6218_6257()
                {
                    var return_v = ArrayBuilder<LocalSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10350, 6218, 6257);
                    return return_v;
                }


                int
                f_10350_6342_6389(Microsoft.CodeAnalysis.CSharp.LocalScopeBinder
                this_param, Microsoft.CodeAnalysis.CSharp.Binder
                enclosingBinder, Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                statement, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals)
                {
                    this_param.BuildLocals(enclosingBinder, statement, locals);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10350, 6342, 6389);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax>
                f_10350_6298_6308_I(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10350, 6298, 6308);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10350_6428_6455(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10350, 6428, 6455);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10350, 5748, 6467);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10350, 5748, 6467);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void BuildLocals(Binder enclosingBinder, StatementSyntax statement, ArrayBuilder<LocalSymbol> locals)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10350, 6479, 10615);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 6614, 6645);

                var
                innerStatement = statement
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 6813, 6989) || true) && (f_10350_6820_6841(innerStatement) == SyntaxKind.LabeledStatement)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10350, 6813, 6989);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 6906, 6974);

                        innerStatement = f_10350_6923_6973(((LabeledStatementSyntax)innerStatement));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10350, 6813, 6989);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10350, 6813, 6989);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10350, 6813, 6989);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 7005, 10604);

                switch (f_10350_7013_7034(innerStatement))
                {

                    case SyntaxKind.LocalDeclarationStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10350, 7005, 10604);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 7159, 7252);

                            Binder
                            localDeclarationBinder = f_10350_7191_7232(enclosingBinder, innerStatement) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Binder?>(10350, 7191, 7251) ?? enclosingBinder)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 7278, 7337);

                            var
                            decl = (LocalDeclarationStatementSyntax)innerStatement
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 7365, 8047);

                            f_10350_7365_8046(f_10350_7365_7386(f_10350_7365_7381(decl)), (rankSpecifier, args) =>
                                                    {
                                                        foreach (var expression in rankSpecifier.Sizes)
                                                        {
                                                            if (expression.Kind() != SyntaxKind.OmittedArraySizeExpression)
                                                            {
                                                                ExpressionVariableFinder.FindExpressionVariables(args.localScopeBinder, args.locals, expression, args.localDeclarationBinder);
                                                            }
                                                        }
                                                    }, (localScopeBinder: this, locals: locals, localDeclarationBinder: localDeclarationBinder));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 8075, 8101);

                            LocalDeclarationKind
                            kind
                            = default(LocalDeclarationKind);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 8127, 8626) || true) && (f_10350_8131_8143(decl))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10350, 8127, 8626);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 8201, 8238);

                                kind = LocalDeclarationKind.Constant;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10350, 8127, 8626);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10350, 8127, 8626);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 8296, 8626) || true) && (f_10350_8300_8317(decl) != default(SyntaxToken))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10350, 8296, 8626);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 8399, 8441);

                                    kind = LocalDeclarationKind.UsingVariable;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10350, 8296, 8626);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10350, 8296, 8626);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 8555, 8599);

                                    kind = LocalDeclarationKind.RegularVariable;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10350, 8296, 8626);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10350, 8127, 8626);
                            }
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 8652, 9177);
                                foreach (var vdecl in f_10350_8674_8700_I(f_10350_8674_8700(f_10350_8674_8690(decl))))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10350, 8652, 9177);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 8758, 8841);

                                    var
                                    localSymbol = f_10350_8776_8840(this, f_10350_8786_8802(decl), vdecl, kind, localDeclarationBinder)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 8871, 8895);

                                    f_10350_8871_8894(locals, localSymbol);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 9056, 9150);

                                    f_10350_9056_9149(this, locals, vdecl, localDeclarationBinder);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10350, 8652, 9177);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10350, 1, 526);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10350, 1, 526);
                            }
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10350, 9222, 9228);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10350, 7005, 10604);

                    case SyntaxKind.ExpressionStatement:
                    case SyntaxKind.IfStatement:
                    case SyntaxKind.YieldReturnStatement:
                    case SyntaxKind.ReturnStatement:
                    case SyntaxKind.ThrowStatement:
                    case SyntaxKind.GotoCaseStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10350, 7005, 10604);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 9558, 9699);

                        f_10350_9558_9698(this, locals, innerStatement, f_10350_9637_9678(enclosingBinder, innerStatement) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Binder?>(10350, 9637, 9697) ?? enclosingBinder));
                        DynAbs.Tracing.TraceSender.TraceBreak(10350, 9721, 9727);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10350, 7005, 10604);

                    case SyntaxKind.SwitchStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10350, 7005, 10604);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 9801, 9861);

                        var
                        switchStatement = (SwitchStatementSyntax)innerStatement
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 9883, 10036);

                        f_10350_9883_10035(this, locals, innerStatement, f_10350_9962_10015(enclosingBinder, f_10350_9988_10014(switchStatement)) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Binder?>(10350, 9962, 10034) ?? enclosingBinder));
                        DynAbs.Tracing.TraceSender.TraceBreak(10350, 10058, 10064);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10350, 7005, 10604);

                    case SyntaxKind.LockStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10350, 7005, 10604);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 10136, 10203);

                        Binder
                        statementBinder = f_10350_10161_10202(enclosingBinder, innerStatement)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 10225, 10263);

                        f_10350_10225_10262(statementBinder != null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 10314, 10410);

                        f_10350_10314_10409(this, locals, innerStatement, statementBinder);
                        DynAbs.Tracing.TraceSender.TraceBreak(10350, 10432, 10438);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10350, 7005, 10604);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10350, 7005, 10604);
                        DynAbs.Tracing.TraceSender.TraceBreak(10350, 10583, 10589);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10350, 7005, 10604);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10350, 6479, 10615);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10350_6820_6841(Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10350, 6820, 6841);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                f_10350_6923_6973(Microsoft.CodeAnalysis.CSharp.Syntax.LabeledStatementSyntax
                this_param)
                {
                    var return_v = this_param.Statement;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10350, 6923, 6973);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10350_7013_7034(Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10350, 7013, 7034);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder?
                f_10350_7191_7232(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                node)
                {
                    var return_v = this_param.GetBinder((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10350, 7191, 7232);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax
                f_10350_7365_7381(Microsoft.CodeAnalysis.CSharp.Syntax.LocalDeclarationStatementSyntax
                this_param)
                {
                    var return_v = this_param.Declaration;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10350, 7365, 7381);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10350_7365_7386(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10350, 7365, 7386);
                    return return_v;
                }


                int
                f_10350_7365_8046(Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                type, System.Action<Microsoft.CodeAnalysis.CSharp.Syntax.ArrayRankSpecifierSyntax, (Microsoft.CodeAnalysis.CSharp.LocalScopeBinder localScopeBinder, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol> locals, Microsoft.CodeAnalysis.CSharp.Binder localDeclarationBinder)>
                action, (Microsoft.CodeAnalysis.CSharp.LocalScopeBinder localScopeBinder, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol> locals, Microsoft.CodeAnalysis.CSharp.Binder localDeclarationBinder)
                argument)
                {
                    type.VisitRankSpecifiers<(Microsoft.CodeAnalysis.CSharp.LocalScopeBinder localScopeBinder, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol> locals, Microsoft.CodeAnalysis.CSharp.Binder localDeclarationBinder)>(action, argument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10350, 7365, 8046);
                    return 0;
                }


                bool
                f_10350_8131_8143(Microsoft.CodeAnalysis.CSharp.Syntax.LocalDeclarationStatementSyntax
                this_param)
                {
                    var return_v = this_param.IsConst;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10350, 8131, 8143);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10350_8300_8317(Microsoft.CodeAnalysis.CSharp.Syntax.LocalDeclarationStatementSyntax
                this_param)
                {
                    var return_v = this_param.UsingKeyword;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10350, 8300, 8317);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax
                f_10350_8674_8690(Microsoft.CodeAnalysis.CSharp.Syntax.LocalDeclarationStatementSyntax
                this_param)
                {
                    var return_v = this_param.Declaration;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10350, 8674, 8690);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax>
                f_10350_8674_8700(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Variables;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10350, 8674, 8700);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax
                f_10350_8786_8802(Microsoft.CodeAnalysis.CSharp.Syntax.LocalDeclarationStatementSyntax
                this_param)
                {
                    var return_v = this_param.Declaration;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10350, 8786, 8802);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol
                f_10350_8776_8840(Microsoft.CodeAnalysis.CSharp.LocalScopeBinder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax
                declaration, Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax
                declarator, Microsoft.CodeAnalysis.CSharp.Symbols.LocalDeclarationKind
                kind, Microsoft.CodeAnalysis.CSharp.Binder
                initializerBinderOpt)
                {
                    var return_v = this_param.MakeLocal(declaration, declarator, kind, initializerBinderOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10350, 8776, 8840);
                    return return_v;
                }


                int
                f_10350_8871_8894(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10350, 8871, 8894);
                    return 0;
                }


                int
                f_10350_9056_9149(Microsoft.CodeAnalysis.CSharp.LocalScopeBinder
                scopeBinder, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                builder, Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax
                node, Microsoft.CodeAnalysis.CSharp.Binder
                enclosingBinderOpt)
                {
                    ExpressionVariableFinder.FindExpressionVariables((Microsoft.CodeAnalysis.CSharp.Binder)scopeBinder, builder, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node, enclosingBinderOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10350, 9056, 9149);
                    return 0;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax>
                f_10350_8674_8700_I(Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10350, 8674, 8700);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder?
                f_10350_9637_9678(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                node)
                {
                    var return_v = this_param.GetBinder((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10350, 9637, 9678);
                    return return_v;
                }


                int
                f_10350_9558_9698(Microsoft.CodeAnalysis.CSharp.LocalScopeBinder
                scopeBinder, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                builder, Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                node, Microsoft.CodeAnalysis.CSharp.Binder
                enclosingBinderOpt)
                {
                    ExpressionVariableFinder.FindExpressionVariables((Microsoft.CodeAnalysis.CSharp.Binder)scopeBinder, builder, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node, enclosingBinderOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10350, 9558, 9698);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10350_9988_10014(Microsoft.CodeAnalysis.CSharp.Syntax.SwitchStatementSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10350, 9988, 10014);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder?
                f_10350_9962_10015(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node)
                {
                    var return_v = this_param.GetBinder((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10350, 9962, 10015);
                    return return_v;
                }


                int
                f_10350_9883_10035(Microsoft.CodeAnalysis.CSharp.LocalScopeBinder
                scopeBinder, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                builder, Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                node, Microsoft.CodeAnalysis.CSharp.Binder
                enclosingBinderOpt)
                {
                    ExpressionVariableFinder.FindExpressionVariables((Microsoft.CodeAnalysis.CSharp.Binder)scopeBinder, builder, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node, enclosingBinderOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10350, 9883, 10035);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Binder?
                f_10350_10161_10202(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                node)
                {
                    var return_v = this_param.GetBinder((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10350, 10161, 10202);
                    return return_v;
                }


                int
                f_10350_10225_10262(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10350, 10225, 10262);
                    return 0;
                }


                int
                f_10350_10314_10409(Microsoft.CodeAnalysis.CSharp.LocalScopeBinder
                scopeBinder, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                builder, Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                node, Microsoft.CodeAnalysis.CSharp.Binder
                enclosingBinderOpt)
                {
                    ExpressionVariableFinder.FindExpressionVariables((Microsoft.CodeAnalysis.CSharp.Binder)scopeBinder, builder, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node, enclosingBinderOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10350, 10314, 10409);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10350, 6479, 10615);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10350, 6479, 10615);
            }
        }

        protected ImmutableArray<LocalFunctionSymbol> BuildLocalFunctions(SyntaxList<StatementSyntax> statements)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10350, 10627, 11055);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 10757, 10805);

                ArrayBuilder<LocalFunctionSymbol>
                locals = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 10819, 10947);
                    foreach (var statement in f_10350_10845_10855_I(statements))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10350, 10819, 10947);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 10889, 10932);

                        f_10350_10889_10931(this, statement, ref locals);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10350, 10819, 10947);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10350, 1, 129);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10350, 1, 129);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 10963, 11044);

                return f_10350_10970_10998_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(locals, 10350, 10970, 10998)?.ToImmutableAndFree()) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol>?>(10350, 10970, 11043) ?? ImmutableArray<LocalFunctionSymbol>.Empty);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10350, 10627, 11055);

                int
                f_10350_10889_10931(Microsoft.CodeAnalysis.CSharp.LocalScopeBinder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                statement, ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol>?
                locals)
                {
                    this_param.BuildLocalFunctions(statement, ref locals);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10350, 10889, 10931);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax>
                f_10350_10845_10855_I(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10350, 10845, 10855);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol>?
                f_10350_10970_10998_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol>?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10350, 10970, 10998);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10350, 10627, 11055);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10350, 10627, 11055);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void BuildLocalFunctions(StatementSyntax statement, ref ArrayBuilder<LocalFunctionSymbol> locals)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10350, 11067, 12025);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 11198, 11229);

                var
                innerStatement = statement
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 11397, 11573) || true) && (f_10350_11404_11425(innerStatement) == SyntaxKind.LabeledStatement)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10350, 11397, 11573);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 11490, 11558);

                        innerStatement = f_10350_11507_11557(((LabeledStatementSyntax)innerStatement));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10350, 11397, 11573);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10350, 11397, 11573);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10350, 11397, 11573);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 11589, 12014) || true) && (f_10350_11593_11614(innerStatement) == SyntaxKind.LocalFunctionStatement)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10350, 11589, 12014);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 11685, 11741);

                    var
                    decl = (LocalFunctionStatementSyntax)innerStatement
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 11759, 11895) || true) && (locals == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10350, 11759, 11895);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 11819, 11876);

                        locals = f_10350_11828_11875();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10350, 11759, 11895);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 11915, 11957);

                    var
                    localSymbol = f_10350_11933_11956(this, decl)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 11975, 11999);

                    f_10350_11975_11998(locals, localSymbol);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10350, 11589, 12014);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10350, 11067, 12025);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10350_11404_11425(Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10350, 11404, 11425);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                f_10350_11507_11557(Microsoft.CodeAnalysis.CSharp.Syntax.LabeledStatementSyntax
                this_param)
                {
                    var return_v = this_param.Statement;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10350, 11507, 11557);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10350_11593_11614(Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10350, 11593, 11614);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol>
                f_10350_11828_11875()
                {
                    var return_v = ArrayBuilder<LocalFunctionSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10350, 11828, 11875);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                f_10350_11933_11956(Microsoft.CodeAnalysis.CSharp.LocalScopeBinder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.LocalFunctionStatementSyntax
                declaration)
                {
                    var return_v = this_param.MakeLocalFunction(declaration);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10350, 11933, 11956);
                    return return_v;
                }


                int
                f_10350_11975_11998(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10350, 11975, 11998);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10350, 11067, 12025);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10350, 11067, 12025);
            }
        }

        protected SourceLocalSymbol MakeLocal(VariableDeclarationSyntax declaration, VariableDeclaratorSyntax declarator, LocalDeclarationKind kind, Binder initializerBinderOpt = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10350, 12037, 12557);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 12238, 12546);

                return f_10350_12245_12545(f_10350_12291_12320(this), this, true, f_10350_12385_12401(declaration), f_10350_12420_12441(declarator), kind, f_10350_12483_12505(declarator), initializerBinderOpt);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10350, 12037, 12557);

                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10350_12291_12320(Microsoft.CodeAnalysis.CSharp.LocalScopeBinder
                this_param)
                {
                    var return_v = this_param.ContainingMemberOrLambda;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10350, 12291, 12320);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10350_12385_12401(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10350, 12385, 12401);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10350_12420_12441(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax
                this_param)
                {
                    var return_v = this_param.Identifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10350, 12420, 12441);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax?
                f_10350_12483_12505(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax
                this_param)
                {
                    var return_v = this_param.Initializer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10350, 12483, 12505);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol
                f_10350_12245_12545(Microsoft.CodeAnalysis.CSharp.Symbol?
                containingSymbol, Microsoft.CodeAnalysis.CSharp.LocalScopeBinder
                scopeBinder, bool
                allowRefKind, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                typeSyntax, Microsoft.CodeAnalysis.SyntaxToken
                identifierToken, Microsoft.CodeAnalysis.CSharp.Symbols.LocalDeclarationKind
                declarationKind, Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax?
                initializer, Microsoft.CodeAnalysis.CSharp.Binder?
                initializerBinderOpt)
                {
                    var return_v = SourceLocalSymbol.MakeLocal(containingSymbol, (Microsoft.CodeAnalysis.CSharp.Binder)scopeBinder, allowRefKind, typeSyntax, identifierToken, declarationKind, initializer, initializerBinderOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10350, 12245, 12545);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10350, 12037, 12557);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10350, 12037, 12557);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected LocalFunctionSymbol MakeLocalFunction(LocalFunctionStatementSyntax declaration)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10350, 12569, 12827);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 12683, 12816);

                return f_10350_12690_12815(this, f_10350_12755_12784(this), declaration);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10350, 12569, 12827);

                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10350_12755_12784(Microsoft.CodeAnalysis.CSharp.LocalScopeBinder
                this_param)
                {
                    var return_v = this_param.ContainingMemberOrLambda;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10350, 12755, 12784);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                f_10350_12690_12815(Microsoft.CodeAnalysis.CSharp.LocalScopeBinder
                binder, Microsoft.CodeAnalysis.CSharp.Symbol?
                containingSymbol, Microsoft.CodeAnalysis.CSharp.Syntax.LocalFunctionStatementSyntax
                syntax)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol((Microsoft.CodeAnalysis.CSharp.Binder)binder, containingSymbol, syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10350, 12690, 12815);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10350, 12569, 12827);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10350, 12569, 12827);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected void BuildLabels(SyntaxList<StatementSyntax> statements, ref ArrayBuilder<LabelSymbol> labels)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10350, 12839, 13198);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 12968, 13035);

                var
                containingMethod = (MethodSymbol)f_10350_13005_13034(this)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 13049, 13187);
                    foreach (var statement in f_10350_13075_13085_I(statements))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10350, 13049, 13187);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 13119, 13172);

                        f_10350_13119_13171(containingMethod, statement, ref labels);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10350, 13049, 13187);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10350, 1, 139);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10350, 1, 139);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10350, 12839, 13198);

                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10350_13005_13034(Microsoft.CodeAnalysis.CSharp.LocalScopeBinder
                this_param)
                {
                    var return_v = this_param.ContainingMemberOrLambda;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10350, 13005, 13034);
                    return return_v;
                }


                int
                f_10350_13119_13171(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                containingMethod, Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                statement, ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                labels)
                {
                    BuildLabels(containingMethod, statement, ref labels);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10350, 13119, 13171);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax>
                f_10350_13075_13085_I(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10350, 13075, 13085);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10350, 12839, 13198);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10350, 12839, 13198);
            }
        }

        internal static void BuildLabels(MethodSymbol containingMethod, StatementSyntax statement, ref ArrayBuilder<LabelSymbol> labels)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10350, 13210, 13886);
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 13363, 13875) || true) && (f_10350_13370_13386(statement) == SyntaxKind.LabeledStatement)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10350, 13363, 13875);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 13451, 13508);

                        var
                        labeledStatement = (LabeledStatementSyntax)statement
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 13526, 13654) || true) && (labels == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10350, 13526, 13654);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 13586, 13635);

                            labels = f_10350_13595_13634();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10350, 13526, 13654);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 13674, 13761);

                        var
                        labelSymbol = f_10350_13692_13760(containingMethod, f_10350_13732_13759(labeledStatement))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 13779, 13803);

                        f_10350_13779_13802(labels, labelSymbol);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 13821, 13860);

                        statement = f_10350_13833_13859(labeledStatement);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10350, 13363, 13875);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10350, 13363, 13875);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10350, 13363, 13875);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10350, 13210, 13886);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10350_13370_13386(Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10350, 13370, 13386);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                f_10350_13595_13634()
                {
                    var return_v = ArrayBuilder<LabelSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10350, 13595, 13634);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10350_13732_13759(Microsoft.CodeAnalysis.CSharp.Syntax.LabeledStatementSyntax
                this_param)
                {
                    var return_v = this_param.Identifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10350, 13732, 13759);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceLabelSymbol
                f_10350_13692_13760(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                containingMethod, Microsoft.CodeAnalysis.SyntaxToken
                identifierNodeOrToken)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SourceLabelSymbol(containingMethod, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)identifierNodeOrToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10350, 13692, 13760);
                    return return_v;
                }


                int
                f_10350_13779_13802(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceLabelSymbol
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10350, 13779, 13802);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                f_10350_13833_13859(Microsoft.CodeAnalysis.CSharp.Syntax.LabeledStatementSyntax
                this_param)
                {
                    var return_v = this_param.Statement;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10350, 13833, 13859);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10350, 13210, 13886);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10350, 13210, 13886);
            }
        }

        protected override SourceLocalSymbol LookupLocal(SyntaxToken nameToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10350, 14050, 14817);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 14146, 14172);

                LocalSymbol
                result = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 14186, 14755) || true) && (f_10350_14190_14199() != null && (DynAbs.Tracing.TraceSender.Expression_True(10350, 14190, 14265) && f_10350_14211_14265(f_10350_14211_14220(), nameToken.ValueText, out result)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10350, 14186, 14755);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 14299, 14373) || true) && (f_10350_14303_14325(result) == nameToken)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10350, 14299, 14373);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 14340, 14373);

                        return (SourceLocalSymbol)result;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10350, 14299, 14373);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 14503, 14740);
                        foreach (var local in f_10350_14525_14536_I(f_10350_14525_14536(this)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10350, 14503, 14740);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 14578, 14721) || true) && (f_10350_14582_14603(local) == nameToken)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10350, 14578, 14721);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 14666, 14698);

                                return (SourceLocalSymbol)local;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10350, 14578, 14721);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10350, 14503, 14740);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10350, 1, 238);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10350, 1, 238);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10350, 14186, 14755);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 14771, 14806);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.LookupLocal(nameToken), 10350, 14778, 14805);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10350, 14050, 14817);

                Microsoft.CodeAnalysis.SmallDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10350_14190_14199()
                {
                    var return_v = LocalsMap;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10350, 14190, 14199);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SmallDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10350_14211_14220()
                {
                    var return_v = LocalsMap;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10350, 14211, 14220);
                    return return_v;
                }


                bool
                f_10350_14211_14265(Microsoft.CodeAnalysis.SmallDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                this_param, string
                key, out Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10350, 14211, 14265);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10350_14303_14325(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.IdentifierToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10350, 14303, 14325);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10350_14525_14536(Microsoft.CodeAnalysis.CSharp.LocalScopeBinder
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10350, 14525, 14536);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10350_14582_14603(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.IdentifierToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10350, 14582, 14603);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10350_14525_14536_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10350, 14525, 14536);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10350, 14050, 14817);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10350, 14050, 14817);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override LocalFunctionSymbol LookupLocalFunction(SyntaxToken nameToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10350, 14829, 15596);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 14935, 14969);

                LocalFunctionSymbol
                result = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 14983, 15526) || true) && (f_10350_14987_15004() != null && (DynAbs.Tracing.TraceSender.Expression_True(10350, 14987, 15078) && f_10350_15016_15078(f_10350_15016_15033(), nameToken.ValueText, out result)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10350, 14983, 15526);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 15112, 15161) || true) && (f_10350_15116_15132(result) == nameToken)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10350, 15112, 15161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 15147, 15161);

                        return result;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10350, 15112, 15161);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 15291, 15511);
                        foreach (var local in f_10350_15313_15332_I(f_10350_15313_15332(this)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10350, 15291, 15511);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 15374, 15492) || true) && (f_10350_15378_15393(local) == nameToken)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10350, 15374, 15492);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 15456, 15469);

                                return local;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10350, 15374, 15492);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10350, 15291, 15511);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10350, 1, 221);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10350, 1, 221);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10350, 14983, 15526);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 15542, 15585);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.LookupLocalFunction(nameToken), 10350, 15549, 15584);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10350, 14829, 15596);

                Microsoft.CodeAnalysis.SmallDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol>
                f_10350_14987_15004()
                {
                    var return_v = LocalFunctionsMap;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10350, 14987, 15004);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SmallDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol>
                f_10350_15016_15033()
                {
                    var return_v = LocalFunctionsMap;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10350, 15016, 15033);
                    return return_v;
                }


                bool
                f_10350_15016_15078(Microsoft.CodeAnalysis.SmallDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol>
                this_param, string
                key, out Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10350, 15016, 15078);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10350_15116_15132(Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                this_param)
                {
                    var return_v = this_param.NameToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10350, 15116, 15132);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol>
                f_10350_15313_15332(Microsoft.CodeAnalysis.CSharp.LocalScopeBinder
                this_param)
                {
                    var return_v = this_param.LocalFunctions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10350, 15313, 15332);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10350_15378_15393(Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                this_param)
                {
                    var return_v = this_param.NameToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10350, 15378, 15393);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol>
                f_10350_15313_15332_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10350, 15313, 15332);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10350, 14829, 15596);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10350, 14829, 15596);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override uint LocalScopeDepth
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10350, 15647, 15666);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 15650, 15666);
                    return _localScopeDepth; DynAbs.Tracing.TraceSender.TraceExitMethod(10350, 15647, 15666);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10350, 15647, 15666);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10350, 15647, 15666);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override void LookupSymbolsInSingleBinder(
                    LookupResult result, string name, int arity, ConsList<TypeSymbol> basesBeingResolved, LookupOptions options, Binder originalBinder, bool diagnose, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10350, 15679, 17499);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 15963, 15996);

                f_10350_15963_15995(f_10350_15976_15994(options));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 16010, 16039);

                f_10350_16010_16038(f_10350_16023_16037(result));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 16055, 16522) || true) && ((options & LookupOptions.LabelsOnly) != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10350, 16055, 16522);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 16134, 16165);

                    var
                    labelsMap = f_10350_16150_16164(this)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 16183, 16482) || true) && (labelsMap != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10350, 16183, 16482);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 16246, 16270);

                        LabelSymbol
                        labelSymbol
                        = default(LabelSymbol);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 16292, 16463) || true) && (f_10350_16296_16340(labelsMap, name, out labelSymbol))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10350, 16292, 16463);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 16390, 16440);

                            f_10350_16390_16439(result, f_10350_16408_16438(labelSymbol));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10350, 16292, 16463);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10350, 16183, 16482);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 16500, 16507);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10350, 16055, 16522);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 16538, 16569);

                var
                localsMap = f_10350_16554_16568(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 16583, 16997) || true) && (localsMap != null && (DynAbs.Tracing.TraceSender.Expression_True(10350, 16587, 16659) && (options & LookupOptions.NamespaceAliasesOnly) == 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10350, 16583, 16997);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 16693, 16717);

                    LocalSymbol
                    localSymbol
                    = default(LocalSymbol);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 16735, 16982) || true) && (f_10350_16739_16783(localsMap, name, out localSymbol))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10350, 16735, 16982);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 16825, 16963);

                        f_10350_16825_16962(result, f_10350_16843_16961(originalBinder, localSymbol, arity, options, null, diagnose, ref useSiteDiagnostics, basesBeingResolved));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10350, 16735, 16982);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10350, 16583, 16997);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 17013, 17060);

                var
                localFunctionsMap = f_10350_17037_17059(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 17074, 17488) || true) && (localFunctionsMap != null && (DynAbs.Tracing.TraceSender.Expression_True(10350, 17078, 17134) && f_10350_17107_17134(options)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10350, 17074, 17488);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 17168, 17200);

                    LocalFunctionSymbol
                    localSymbol
                    = default(LocalFunctionSymbol);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 17218, 17473) || true) && (f_10350_17222_17274(localFunctionsMap, name, out localSymbol))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10350, 17218, 17473);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 17316, 17454);

                        f_10350_17316_17453(result, f_10350_17334_17452(originalBinder, localSymbol, arity, options, null, diagnose, ref useSiteDiagnostics, basesBeingResolved));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10350, 17218, 17473);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10350, 17074, 17488);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10350, 15679, 17499);

                bool
                f_10350_15976_15994(Microsoft.CodeAnalysis.CSharp.LookupOptions
                options)
                {
                    var return_v = options.AreValid();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10350, 15976, 15994);
                    return return_v;
                }


                int
                f_10350_15963_15995(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10350, 15963, 15995);
                    return 0;
                }


                bool
                f_10350_16023_16037(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param)
                {
                    var return_v = this_param.IsClear;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10350, 16023, 16037);
                    return return_v;
                }


                int
                f_10350_16010_16038(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10350, 16010, 16038);
                    return 0;
                }


                Microsoft.CodeAnalysis.SmallDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                f_10350_16150_16164(Microsoft.CodeAnalysis.CSharp.LocalScopeBinder
                this_param)
                {
                    var return_v = this_param.LabelsMap;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10350, 16150, 16164);
                    return return_v;
                }


                bool
                f_10350_16296_16340(Microsoft.CodeAnalysis.SmallDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                this_param, string
                key, out Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10350, 16296, 16340);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SingleLookupResult
                f_10350_16408_16438(Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                symbol)
                {
                    var return_v = LookupResult.Good((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10350, 16408, 16438);
                    return return_v;
                }


                int
                f_10350_16390_16439(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param, Microsoft.CodeAnalysis.CSharp.SingleLookupResult
                result)
                {
                    this_param.MergeEqual(result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10350, 16390, 16439);
                    return 0;
                }


                Microsoft.CodeAnalysis.SmallDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10350_16554_16568(Microsoft.CodeAnalysis.CSharp.LocalScopeBinder
                this_param)
                {
                    var return_v = this_param.LocalsMap;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10350, 16554, 16568);
                    return return_v;
                }


                bool
                f_10350_16739_16783(Microsoft.CodeAnalysis.SmallDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                this_param, string
                key, out Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10350, 16739, 16783);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SingleLookupResult
                f_10350_16843_16961(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                symbol, int
                arity, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                accessThroughType, bool
                diagnose, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved)
                {
                    var return_v = this_param.CheckViability((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, arity, options, accessThroughType, diagnose, ref useSiteDiagnostics, basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10350, 16843, 16961);
                    return return_v;
                }


                int
                f_10350_16825_16962(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param, Microsoft.CodeAnalysis.CSharp.SingleLookupResult
                result)
                {
                    this_param.MergeEqual(result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10350, 16825, 16962);
                    return 0;
                }


                Microsoft.CodeAnalysis.SmallDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol>
                f_10350_17037_17059(Microsoft.CodeAnalysis.CSharp.LocalScopeBinder
                this_param)
                {
                    var return_v = this_param.LocalFunctionsMap;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10350, 17037, 17059);
                    return return_v;
                }


                bool
                f_10350_17107_17134(Microsoft.CodeAnalysis.CSharp.LookupOptions
                options)
                {
                    var return_v = options.CanConsiderLocals();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10350, 17107, 17134);
                    return return_v;
                }


                bool
                f_10350_17222_17274(Microsoft.CodeAnalysis.SmallDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol>
                this_param, string
                key, out Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10350, 17222, 17274);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SingleLookupResult
                f_10350_17334_17452(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                symbol, int
                arity, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                accessThroughType, bool
                diagnose, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved)
                {
                    var return_v = this_param.CheckViability((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, arity, options, accessThroughType, diagnose, ref useSiteDiagnostics, basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10350, 17334, 17452);
                    return return_v;
                }


                int
                f_10350_17316_17453(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param, Microsoft.CodeAnalysis.CSharp.SingleLookupResult
                result)
                {
                    this_param.MergeEqual(result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10350, 17316, 17453);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10350, 15679, 17499);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10350, 15679, 17499);
            }
        }

        protected override void AddLookupSymbolsInfoInSingleBinder(LookupSymbolsInfo result, LookupOptions options, Binder originalBinder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10350, 17511, 18992);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 17666, 17699);

                f_10350_17666_17698(f_10350_17679_17697(options));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 17715, 18049) || true) && ((options & LookupOptions.LabelsOnly) != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10350, 17715, 18049);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 17794, 18034) || true) && (f_10350_17798_17812(this) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10350, 17794, 18034);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 17862, 18015);
                            foreach (var label in f_10350_17884_17898_I(f_10350_17884_17898(this)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10350, 17862, 18015);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 17948, 17992);

                                f_10350_17948_17991(result, label.Value, label.Key, 0);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10350, 17862, 18015);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10350, 1, 154);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10350, 1, 154);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10350, 17794, 18034);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10350, 17715, 18049);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 18063, 18981) || true) && (f_10350_18067_18094(options))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10350, 18063, 18981);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 18128, 18530) || true) && (f_10350_18132_18146(this) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10350, 18128, 18530);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 18196, 18511);
                            foreach (var local in f_10350_18218_18232_I(f_10350_18218_18232(this)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10350, 18196, 18511);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 18282, 18488) || true) && (f_10350_18286_18359(originalBinder, local.Value, options, result, null))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10350, 18282, 18488);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 18417, 18461);

                                    f_10350_18417_18460(result, local.Value, local.Key, 0);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10350, 18282, 18488);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10350, 18196, 18511);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10350, 1, 316);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10350, 1, 316);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10350, 18128, 18530);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 18548, 18966) || true) && (f_10350_18552_18574(this) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10350, 18548, 18966);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 18624, 18947);
                            foreach (var local in f_10350_18646_18668_I(f_10350_18646_18668(this)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10350, 18624, 18947);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 18718, 18924) || true) && (f_10350_18722_18795(originalBinder, local.Value, options, result, null))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10350, 18718, 18924);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 18853, 18897);

                                    f_10350_18853_18896(result, local.Value, local.Key, 0);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10350, 18718, 18924);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10350, 18624, 18947);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10350, 1, 324);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10350, 1, 324);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10350, 18548, 18966);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10350, 18063, 18981);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10350, 17511, 18992);

                bool
                f_10350_17679_17697(Microsoft.CodeAnalysis.CSharp.LookupOptions
                options)
                {
                    var return_v = options.AreValid();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10350, 17679, 17697);
                    return return_v;
                }


                int
                f_10350_17666_17698(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10350, 17666, 17698);
                    return 0;
                }


                Microsoft.CodeAnalysis.SmallDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                f_10350_17798_17812(Microsoft.CodeAnalysis.CSharp.LocalScopeBinder
                this_param)
                {
                    var return_v = this_param.LabelsMap;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10350, 17798, 17812);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SmallDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                f_10350_17884_17898(Microsoft.CodeAnalysis.CSharp.LocalScopeBinder
                this_param)
                {
                    var return_v = this_param.LabelsMap;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10350, 17884, 17898);
                    return return_v;
                }


                int
                f_10350_17948_17991(Microsoft.CodeAnalysis.CSharp.LookupSymbolsInfo
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                symbol, string
                name, int
                arity)
                {
                    this_param.AddSymbol((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, name, arity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10350, 17948, 17991);
                    return 0;
                }


                Microsoft.CodeAnalysis.SmallDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                f_10350_17884_17898_I(Microsoft.CodeAnalysis.SmallDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10350, 17884, 17898);
                    return return_v;
                }


                bool
                f_10350_18067_18094(Microsoft.CodeAnalysis.CSharp.LookupOptions
                options)
                {
                    var return_v = options.CanConsiderLocals();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10350, 18067, 18094);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SmallDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10350_18132_18146(Microsoft.CodeAnalysis.CSharp.LocalScopeBinder
                this_param)
                {
                    var return_v = this_param.LocalsMap;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10350, 18132, 18146);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SmallDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10350_18218_18232(Microsoft.CodeAnalysis.CSharp.LocalScopeBinder
                this_param)
                {
                    var return_v = this_param.LocalsMap;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10350, 18218, 18232);
                    return return_v;
                }


                bool
                f_10350_18286_18359(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                symbol, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, Microsoft.CodeAnalysis.CSharp.LookupSymbolsInfo
                info, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                accessThroughType)
                {
                    var return_v = this_param.CanAddLookupSymbolInfo((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, options, info, accessThroughType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10350, 18286, 18359);
                    return return_v;
                }


                int
                f_10350_18417_18460(Microsoft.CodeAnalysis.CSharp.LookupSymbolsInfo
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                symbol, string
                name, int
                arity)
                {
                    this_param.AddSymbol((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, name, arity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10350, 18417, 18460);
                    return 0;
                }


                Microsoft.CodeAnalysis.SmallDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10350_18218_18232_I(Microsoft.CodeAnalysis.SmallDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10350, 18218, 18232);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SmallDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol>
                f_10350_18552_18574(Microsoft.CodeAnalysis.CSharp.LocalScopeBinder
                this_param)
                {
                    var return_v = this_param.LocalFunctionsMap;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10350, 18552, 18574);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SmallDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol>
                f_10350_18646_18668(Microsoft.CodeAnalysis.CSharp.LocalScopeBinder
                this_param)
                {
                    var return_v = this_param.LocalFunctionsMap;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10350, 18646, 18668);
                    return return_v;
                }


                bool
                f_10350_18722_18795(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                symbol, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, Microsoft.CodeAnalysis.CSharp.LookupSymbolsInfo
                info, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                accessThroughType)
                {
                    var return_v = this_param.CanAddLookupSymbolInfo((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, options, info, accessThroughType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10350, 18722, 18795);
                    return return_v;
                }


                int
                f_10350_18853_18896(Microsoft.CodeAnalysis.CSharp.LookupSymbolsInfo
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                symbol, string
                name, int
                arity)
                {
                    this_param.AddSymbol((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, name, arity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10350, 18853, 18896);
                    return 0;
                }


                Microsoft.CodeAnalysis.SmallDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol>
                f_10350_18646_18668_I(Microsoft.CodeAnalysis.SmallDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10350, 18646, 18668);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10350, 17511, 18992);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10350, 17511, 18992);
            }
        }

        private bool ReportConflictWithLocal(Symbol local, Symbol newSymbol, string name, Location newLocation, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10350, 19004, 21064);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 19224, 19317);

                SymbolKind
                newSymbolKind = (DynAbs.Tracing.TraceSender.Conditional_F1(10350, 19251, 19276) || (((object)newSymbol == null && DynAbs.Tracing.TraceSender.Conditional_F2(10350, 19279, 19299)) || DynAbs.Tracing.TraceSender.Conditional_F3(10350, 19302, 19316))) ? SymbolKind.Parameter : f_10350_19302_19316(newSymbol)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 19333, 19388) || true) && (newSymbolKind == SymbolKind.ErrorType)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10350, 19333, 19388);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 19376, 19388);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10350, 19333, 19388);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 19404, 19436);

                var
                declaredInThisScope = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 19452, 19557);

                declaredInThisScope |= newSymbolKind == SymbolKind.Local && (DynAbs.Tracing.TraceSender.Expression_True(10350, 19475, 19556) && this.Locals.Contains(newSymbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 19571, 19693);

                declaredInThisScope |= newSymbolKind == SymbolKind.Method && (DynAbs.Tracing.TraceSender.Expression_True(10350, 19594, 19692) && this.LocalFunctions.Contains(newSymbol));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 19709, 20041) || true) && (declaredInThisScope && (DynAbs.Tracing.TraceSender.Expression_True(10350, 19713, 19803) && newLocation.SourceSpan.Start >= f_10350_19768_19783(local)[0].SourceSpan.Start))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10350, 19709, 20041);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 19931, 19996);

                    f_10350_19931_19995(                // A local variable or function named '{0}' is already defined in this scope
                                    diagnostics, ErrorCode.ERR_LocalDuplicate, newLocation, name);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 20014, 20026);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10350, 19709, 20041);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 20057, 20867);

                switch (newSymbolKind)
                {

                    case SymbolKind.Local:
                    case SymbolKind.Parameter:
                    case SymbolKind.Method:
                    case SymbolKind.TypeParameter:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10350, 20057, 20867);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 20464, 20538);

                        f_10350_20464_20537(                    // A local or parameter named '{0}' cannot be declared in this scope because that name is used in an enclosing local scope to define a local or parameter
                                            diagnostics, ErrorCode.ERR_LocalIllegallyOverrides, newLocation, name);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 20560, 20572);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10350, 20057, 20867);

                    case SymbolKind.RangeVariable:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10350, 20057, 20867);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 20740, 20818);

                        f_10350_20740_20817(                    // The range variable '{0}' conflicts with a previous declaration of '{0}'
                                            diagnostics, ErrorCode.ERR_QueryRangeVariableOverrides, newLocation, name);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 20840, 20852);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10350, 20057, 20867);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 20883, 20954);

                f_10350_20883_20953(false, "what else can be declared inside a local scope?");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 20968, 21026);

                f_10350_20968_21025(diagnostics, ErrorCode.ERR_InternalError, newLocation);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 21040, 21053);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10350, 19004, 21064);

                Microsoft.CodeAnalysis.SymbolKind
                f_10350_19302_19316(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10350, 19302, 19316);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10350_19768_19783(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10350, 19768, 19783);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10350_19931_19995(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10350, 19931, 19995);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10350_20464_20537(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10350, 20464, 20537);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10350_20740_20817(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10350, 20740, 20817);
                    return return_v;
                }


                int
                f_10350_20883_20953(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10350, 20883, 20953);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10350_20968_21025(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10350, 20968, 21025);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10350, 19004, 21064);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10350, 19004, 21064);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual bool EnsureSingleDefinition(Symbol symbol, string name, Location location, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10350, 21076, 22234);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 21219, 21252);

                LocalSymbol
                existingLocal = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 21266, 21315);

                LocalFunctionSymbol
                existingLocalFunction = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 21331, 21362);

                var
                localsMap = f_10350_21347_21361(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 21376, 21423);

                var
                localFunctionsMap = f_10350_21400_21422(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 21587, 22194) || true) && ((localsMap != null && (DynAbs.Tracing.TraceSender.Expression_True(10350, 21592, 21659) && f_10350_21613_21659(localsMap, name, out existingLocal))) || (DynAbs.Tracing.TraceSender.Expression_False(10350, 21591, 21774) || (localFunctionsMap != null && (DynAbs.Tracing.TraceSender.Expression_True(10350, 21682, 21773) && f_10350_21711_21773(localFunctionsMap, name, out existingLocalFunction)))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10350, 21587, 22194);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 21808, 21876);

                    var
                    existingSymbol = (Symbol)existingLocal ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbol?>(10350, 21829, 21875) ?? existingLocalFunction)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 21894, 22075) || true) && (symbol == existingSymbol)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10350, 21894, 22075);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 22043, 22056);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10350, 21894, 22075);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 22095, 22179);

                    return f_10350_22102_22178(this, existingSymbol, symbol, name, location, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10350, 21587, 22194);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10350, 22210, 22223);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10350, 21076, 22234);

                Microsoft.CodeAnalysis.SmallDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10350_21347_21361(Microsoft.CodeAnalysis.CSharp.LocalScopeBinder
                this_param)
                {
                    var return_v = this_param.LocalsMap;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10350, 21347, 21361);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SmallDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol>
                f_10350_21400_21422(Microsoft.CodeAnalysis.CSharp.LocalScopeBinder
                this_param)
                {
                    var return_v = this_param.LocalFunctionsMap;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10350, 21400, 21422);
                    return return_v;
                }


                bool
                f_10350_21613_21659(Microsoft.CodeAnalysis.SmallDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                this_param, string
                key, out Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10350, 21613, 21659);
                    return return_v;
                }


                bool
                f_10350_21711_21773(Microsoft.CodeAnalysis.SmallDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol>
                this_param, string
                key, out Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10350, 21711, 21773);
                    return return_v;
                }


                bool
                f_10350_22102_22178(Microsoft.CodeAnalysis.CSharp.LocalScopeBinder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol?
                local, Microsoft.CodeAnalysis.CSharp.Symbol
                newSymbol, string
                name, Microsoft.CodeAnalysis.Location
                newLocation, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.ReportConflictWithLocal(local, newSymbol, name, newLocation, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10350, 22102, 22178);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10350, 21076, 22234);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10350, 21076, 22234);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static LocalScopeBinder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10350, 554, 22241);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10350, 554, 22241);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10350, 554, 22241);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10350, 554, 22241);

        static Microsoft.CodeAnalysis.CSharp.Binder
        f_10350_907_911_C(Microsoft.CodeAnalysis.CSharp.Binder
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10350, 848, 946);
            return return_v;
        }


        uint
        f_10350_1091_1111(Microsoft.CodeAnalysis.CSharp.Binder
        this_param)
        {
            var return_v = this_param.LocalScopeDepth;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10350, 1091, 1111);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Binder?
        f_10350_2012_2028(Microsoft.CodeAnalysis.CSharp.Binder
        this_param)
        {
            var return_v = this_param.Next;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10350, 2012, 2028);
            return return_v;
        }


        int
        f_10350_2051_2084(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10350, 2051, 2084);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Binder
        f_10350_1036_1040_C(Microsoft.CodeAnalysis.CSharp.Binder
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10350, 958, 2130);
            return return_v;
        }

    }
}
