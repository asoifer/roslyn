// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.CodeAnalysis.CodeGen;
using Microsoft.CodeAnalysis.CSharp.CodeGen;
using Microsoft.CodeAnalysis.CSharp.Emit;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed class SyntheticBoundNodeFactory
    {
        public class MissingPredefinedMember : Exception
        {
            public MissingPredefinedMember(Diagnostic error) : base(f_10440_1346_1362_C(f_10440_1346_1362(error)))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10440, 1290, 1435);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 1451, 1488);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 1396, 1420);

                    this.Diagnostic = error;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10440, 1290, 1435);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 1290, 1435);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 1290, 1435);
                }
            }

            public Diagnostic Diagnostic { get; }

            static MissingPredefinedMember()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10440, 1217, 1499);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10440, 1217, 1499);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 1217, 1499);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10440, 1217, 1499);

            static string
            f_10440_1346_1362(Microsoft.CodeAnalysis.Diagnostic
            this_param)
            {
                var return_v = this_param.ToString();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 1346, 1362);
                return return_v;
            }


            static string
            f_10440_1346_1362_C(string
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10440, 1290, 1435);
                return return_v;
            }

        }

        public CSharpCompilation Compilation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 1550, 1594);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 1556, 1592);

                    return f_10440_1563_1579().Compilation;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 1550, 1594);

                    Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                    f_10440_1563_1579()
                    {
                        var return_v = CompilationState;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 1563, 1579);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 1511, 1596);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 1511, 1596);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public SyntaxNode Syntax { get; set; }

        public PEModuleBuilder? ModuleBuilderOpt
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 1697, 1746);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 1703, 1744);

                    return f_10440_1710_1726().ModuleBuilderOpt;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 1697, 1746);

                    Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                    f_10440_1710_1726()
                    {
                        var return_v = CompilationState;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 1710, 1726);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 1654, 1748);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 1654, 1748);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public DiagnosticBag Diagnostics { get; }

        public TypeCompilationState CompilationState { get; }

        private NamedTypeSymbol? _currentType;

        public NamedTypeSymbol? CurrentType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 2044, 2072);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 2050, 2070);

                    return _currentType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 2044, 2072);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 1984, 2206);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 1984, 2206);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 2086, 2195);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 2122, 2143);

                    _currentType = value;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 2161, 2180);

                    f_10440_2161_2179(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 2086, 2195);

                    int
                    f_10440_2161_2179(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param)
                    {
                        this_param.CheckCurrentType();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 2161, 2179);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 1984, 2206);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 1984, 2206);
                }
            }
        }

        private MethodSymbol? _currentFunction;

        public MethodSymbol? CurrentFunction
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 2418, 2450);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 2424, 2448);

                    return _currentFunction;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 2418, 2450);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 2357, 2907);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 2357, 2907);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 2464, 2896);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 2500, 2525);

                    _currentFunction = value;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 2543, 2844) || true) && (value is { } && (DynAbs.Tracing.TraceSender.Expression_True(10440, 2547, 2632) && f_10440_2584_2600(value) != MethodKind.AnonymousFunction) && (DynAbs.Tracing.TraceSender.Expression_True(10440, 2547, 2701) && f_10440_2657_2673(value) != MethodKind.LocalFunction))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10440, 2543, 2844);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 2743, 2767);

                        _topLevelMethod = value;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 2789, 2825);

                        _currentType = f_10440_2804_2824(value);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10440, 2543, 2844);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 2862, 2881);

                    f_10440_2862_2880(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 2464, 2896);

                    Microsoft.CodeAnalysis.MethodKind
                    f_10440_2584_2600(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.MethodKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 2584, 2600);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.MethodKind
                    f_10440_2657_2673(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.MethodKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 2657, 2673);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10440_2804_2824(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 2804, 2824);
                        return return_v;
                    }


                    int
                    f_10440_2862_2880(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param)
                    {
                        this_param.CheckCurrentType();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 2862, 2880);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 2357, 2907);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 2357, 2907);
                }
            }
        }

        private MethodSymbol? _topLevelMethod;

        public MethodSymbol? TopLevelMethod
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 3105, 3136);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 3111, 3134);

                    return _topLevelMethod;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 3105, 3136);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 3045, 3281);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 3045, 3281);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            private set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 3150, 3270);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 3194, 3218);

                    _topLevelMethod = value;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 3236, 3255);

                    f_10440_3236_3254(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 3150, 3270);

                    int
                    f_10440_3236_3254(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param)
                    {
                        this_param.CheckCurrentType();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 3236, 3254);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 3045, 3281);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 3045, 3281);
                }
            }
        }

        private Binder? _binder;

        internal BoundExpression MakeInvocationExpression(
                    BinderFlags flags,
                    SyntaxNode node,
                    BoundExpression? receiver,
                    string methodName,
                    ImmutableArray<BoundExpression> args,
                    DiagnosticBag diagnostics,
                    ImmutableArray<TypeSymbol> typeArgs = default(ImmutableArray<TypeSymbol>),
                    bool allowUnexpandedForm = true)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 3483, 4532);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 3917, 4068) || true) && (_binder is null || (DynAbs.Tracing.TraceSender.Expression_False(10440, 3921, 3962) || _binder.Flags != flags))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10440, 3917, 4068);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 3996, 4053);

                    _binder = f_10440_4006_4052(f_10440_4006_4035(this), flags);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10440, 3917, 4068);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 4084, 4521);

                return f_10440_4091_4520(_binder, node, receiver, methodName, args, diagnostics, typeArgs: (DynAbs.Tracing.TraceSender.Conditional_F1(10440, 4284, 4302) || ((typeArgs.IsDefault && DynAbs.Tracing.TraceSender.Conditional_F2(10440, 4305, 4349)) || DynAbs.Tracing.TraceSender.Conditional_F3(10440, 4352, 4410))) ? default(ImmutableArray<TypeWithAnnotations>) : typeArgs.SelectAsArray(t => TypeWithAnnotations.Create(t)), allowFieldsAndProperties: false, allowUnexpandedForm: allowUnexpandedForm);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 3483, 4532);

                Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory.SyntheticBinderImpl
                f_10440_4006_4035(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                factory)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory.SyntheticBinderImpl(factory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 4006, 4035);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10440_4006_4052(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory.SyntheticBinderImpl
                this_param, Microsoft.CodeAnalysis.CSharp.BinderFlags
                flags)
                {
                    var return_v = this_param.WithFlags(flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 4006, 4052);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10440_4091_4520(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiver, string
                methodName, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                args, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                typeArgs, bool
                allowFieldsAndProperties, bool
                allowUnexpandedForm)
                {
                    var return_v = this_param.MakeInvocationExpression(node, receiver, methodName, args, diagnostics, typeArgs: typeArgs, allowFieldsAndProperties: allowFieldsAndProperties, allowUnexpandedForm: allowUnexpandedForm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 4091, 4520);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 3483, 4532);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 3483, 4532);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        private sealed class SyntheticBinderImpl : BuckStopsHereBinder
        {
            private readonly SyntheticBoundNodeFactory _factory;

            internal SyntheticBinderImpl(SyntheticBoundNodeFactory factory) : base(f_10440_4909_4928_C(f_10440_4909_4928(factory)))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10440, 4838, 4996);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 4815, 4823);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 4962, 4981);

                    _factory = factory;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10440, 4838, 4996);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 4838, 4996);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 4838, 4996);
                }
            }

            internal override Symbol? ContainingMemberOrLambda
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 5065, 5105);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 5071, 5103);

                        return f_10440_5078_5102(_factory);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 5065, 5105);

                        Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                        f_10440_5078_5102(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                        this_param)
                        {
                            var return_v = this_param.CurrentFunction;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 5078, 5102);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 5012, 5107);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 5012, 5107);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal override bool IsAccessibleHelper(Symbol symbol, TypeSymbol accessThroughType, out bool failedThroughTypeCheck, ref HashSet<DiagnosticInfo>? useSiteDiagnostics, ConsList<TypeSymbol> basesBeingResolved)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 5121, 5537);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 5363, 5522);

                    return f_10440_5370_5521(symbol, f_10440_5409_5429(_factory), accessThroughType, out failedThroughTypeCheck, ref useSiteDiagnostics, basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 5121, 5537);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                    f_10440_5409_5429(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param)
                    {
                        var return_v = this_param.CurrentType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 5409, 5429);
                        return return_v;
                    }


                    bool
                    f_10440_5370_5521(Microsoft.CodeAnalysis.CSharp.Symbol
                    symbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                    within, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    throughTypeOpt, out bool
                    failedThroughTypeCheck, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                    useSiteDiagnostics, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                    basesBeingResolved)
                    {
                        var return_v = AccessCheck.IsSymbolAccessible(symbol, within, throughTypeOpt, out failedThroughTypeCheck, ref useSiteDiagnostics, basesBeingResolved);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 5370, 5521);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 5121, 5537);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 5121, 5537);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static SyntheticBinderImpl()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10440, 4685, 5548);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10440, 4685, 5548);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 4685, 5548);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10440, 4685, 5548);

            static Microsoft.CodeAnalysis.CSharp.CSharpCompilation
            f_10440_4909_4928(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
            this_param)
            {
                var return_v = this_param.Compilation;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 4909, 4928);
                return return_v;
            }


            static Microsoft.CodeAnalysis.CSharp.CSharpCompilation
            f_10440_4909_4928_C(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10440, 4838, 4996);
                return return_v;
            }

        }

        public SyntheticBoundNodeFactory(MethodSymbol topLevelMethod, SyntaxNode node, TypeCompilationState compilationState, DiagnosticBag diagnostics)
        : this(f_10440_6393_6407_C(topLevelMethod), f_10440_6409_6438(topLevelMethod), node, compilationState, diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10440, 6228, 6498);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10440, 6228, 6498);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 6228, 6498);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 6228, 6498);
            }
        }

        public SyntheticBoundNodeFactory(MethodSymbol? topLevelMethodOpt, NamedTypeSymbol? currentClassOpt, SyntaxNode node, TypeCompilationState compilationState, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10440, 6974, 7613);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 1606, 1644);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 1758, 1799);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 1809, 1862);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 1961, 1973);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 2330, 2346);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 3019, 3034);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 3463, 3470);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 7181, 7208);

                f_10440_7181_7207(node != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 7222, 7261);

                f_10440_7222_7260(compilationState != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 7275, 7309);

                f_10440_7275_7308(diagnostics != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 7325, 7366);

                this.CompilationState = compilationState;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 7380, 7415);

                this.CurrentType = currentClassOpt;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 7429, 7469);

                this.TopLevelMethod = topLevelMethodOpt;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 7483, 7524);

                this.CurrentFunction = topLevelMethodOpt;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 7538, 7557);

                this.Syntax = node;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 7571, 7602);

                this.Diagnostics = diagnostics;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10440, 6974, 7613);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 6974, 7613);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 6974, 7613);
            }
        }

        [Conditional("DEBUG")]
        private void CheckCurrentType()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 7625, 8678);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 7713, 8667) || true) && (f_10440_7717_7728() is { })
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10440, 7713, 8667);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 7769, 7908);

                    f_10440_7769_7907(f_10440_7782_7796() is null || (DynAbs.Tracing.TraceSender.Expression_False(10440, 7782, 7906) || f_10440_7808_7906(f_10440_7826_7855(f_10440_7826_7840()), f_10440_7857_7868(), TypeCompareKind.ConsiderEverything2)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 8328, 8652);

                    f_10440_8328_8651(f_10440_8341_8356() is null || (DynAbs.Tracing.TraceSender.Expression_False(10440, 8341, 8447) || f_10440_8389_8415(f_10440_8389_8404()) == MethodKind.AnonymousFunction) || (DynAbs.Tracing.TraceSender.Expression_False(10440, 8341, 8526) || f_10440_8472_8498(f_10440_8472_8487()) == MethodKind.LocalFunction) || (DynAbs.Tracing.TraceSender.Expression_False(10440, 8341, 8650) || f_10440_8551_8650(f_10440_8569_8599(f_10440_8569_8584()), f_10440_8601_8612(), TypeCompareKind.ConsiderEverything2)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10440, 7713, 8667);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 7625, 8678);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10440_7717_7728()
                {
                    var return_v = CurrentType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 7717, 7728);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10440_7782_7796()
                {
                    var return_v = TopLevelMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 7782, 7796);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10440_7826_7840()
                {
                    var return_v = TopLevelMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 7826, 7840);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10440_7826_7855(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 7826, 7855);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10440_7857_7868()
                {
                    var return_v = CurrentType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 7857, 7868);
                    return return_v;
                }


                bool
                f_10440_7808_7906(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 7808, 7906);
                    return return_v;
                }


                int
                f_10440_7769_7907(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 7769, 7907);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10440_8341_8356()
                {
                    var return_v = CurrentFunction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 8341, 8356);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10440_8389_8404()
                {
                    var return_v = CurrentFunction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 8389, 8404);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10440_8389_8415(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 8389, 8415);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10440_8472_8487()
                {
                    var return_v = CurrentFunction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 8472, 8487);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10440_8472_8498(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 8472, 8498);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10440_8569_8584()
                {
                    var return_v = CurrentFunction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 8569, 8584);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10440_8569_8599(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 8569, 8599);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10440_8601_8612()
                {
                    var return_v = CurrentType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 8601, 8612);
                    return return_v;
                }


                bool
                f_10440_8551_8650(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 8551, 8650);
                    return return_v;
                }


                int
                f_10440_8328_8651(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 8328, 8651);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 7625, 8678);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 7625, 8678);
            }
        }

        public void AddNestedType(NamedTypeSymbol nestedType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 8690, 9007);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 8861, 8899);

                f_10440_8861_8898(f_10440_8874_8890() is { });
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 8913, 8996);

                f_10440_8913_8995(f_10440_8913_8929(), f_10440_8955_8966(), f_10440_8968_8994(nestedType));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 8690, 9007);

                Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder?
                f_10440_8874_8890()
                {
                    var return_v = ModuleBuilderOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 8874, 8890);
                    return return_v;
                }


                int
                f_10440_8861_8898(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 8861, 8898);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                f_10440_8913_8929()
                {
                    var return_v = ModuleBuilderOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 8913, 8929);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10440_8955_8966()
                {
                    var return_v = CurrentType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 8955, 8966);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                f_10440_8968_8994(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetCciAdapter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 8968, 8994);
                    return return_v;
                }


                int
                f_10440_8913_8995(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                container, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                nestedType)
                {
                    this_param.AddSynthesizedDefinition(container, (Microsoft.Cci.INestedTypeDefinition)nestedType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 8913, 8995);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 8690, 9007);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 8690, 9007);
            }
        }

        public void OpenNestedType(NamedTypeSymbol nestedType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 9019, 9462);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 9313, 9339);

                f_10440_9313_9338(this, nestedType);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 9353, 9376);

                CurrentFunction = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 9390, 9412);

                TopLevelMethod = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 9426, 9451);

                CurrentType = nestedType;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 9019, 9462);

                int
                f_10440_9313_9338(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                nestedType)
                {
                    this_param.AddNestedType(nestedType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 9313, 9338);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 9019, 9462);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 9019, 9462);
            }
        }

        public BoundHoistedFieldAccess HoistedField(FieldSymbol field)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 9474, 9634);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 9561, 9623);

                return f_10440_9568_9622(f_10440_9596_9602(), field, f_10440_9611_9621(field));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 9474, 9634);

                Microsoft.CodeAnalysis.SyntaxNode
                f_10440_9596_9602()
                {
                    var return_v = Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 9596, 9602);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10440_9611_9621(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 9611, 9621);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundHoistedFieldAccess
                f_10440_9568_9622(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                fieldSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundHoistedFieldAccess(syntax, fieldSymbol, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 9568, 9622);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 9474, 9634);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 9474, 9634);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public StateMachineFieldSymbol StateMachineField(TypeWithAnnotations type, string name, bool isPublic = false, bool isThis = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 9646, 10016);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 9802, 9835);

                f_10440_9802_9834(f_10440_9815_9826() is { });
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 9849, 9933);

                var
                result = f_10440_9862_9932(f_10440_9890_9901(), type, name, isPublic, isThis)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 9947, 9977);

                f_10440_9947_9976(this, f_10440_9956_9967(), result);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 9991, 10005);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 9646, 10016);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10440_9815_9826()
                {
                    var return_v = CurrentType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 9815, 9826);
                    return return_v;
                }


                int
                f_10440_9802_9834(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 9802, 9834);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10440_9890_9901()
                {
                    var return_v = CurrentType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 9890, 9901);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol
                f_10440_9862_9932(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                stateMachineType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                type, string
                name, bool
                isPublic, bool
                isThis)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol(stateMachineType, type, name, isPublic, isThis);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 9862, 9932);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10440_9956_9967()
                {
                    var return_v = CurrentType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 9956, 9967);
                    return return_v;
                }


                int
                f_10440_9947_9976(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                containingType, Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol
                field)
                {
                    this_param.AddField(containingType, (Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol)field);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 9947, 9976);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 9646, 10016);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 9646, 10016);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public StateMachineFieldSymbol StateMachineField(TypeSymbol type, string name, bool isPublic = false, bool isThis = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 10028, 10417);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 10175, 10208);

                f_10440_10175_10207(f_10440_10188_10199() is { });
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 10222, 10334);

                var
                result = f_10440_10235_10333(f_10440_10263_10274(), TypeWithAnnotations.Create(type), name, isPublic, isThis)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 10348, 10378);

                f_10440_10348_10377(this, f_10440_10357_10368(), result);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 10392, 10406);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 10028, 10417);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10440_10188_10199()
                {
                    var return_v = CurrentType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 10188, 10199);
                    return return_v;
                }


                int
                f_10440_10175_10207(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 10175, 10207);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10440_10263_10274()
                {
                    var return_v = CurrentType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 10263, 10274);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol
                f_10440_10235_10333(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                stateMachineType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                type, string
                name, bool
                isPublic, bool
                isThis)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol(stateMachineType, type, name, isPublic, isThis);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 10235, 10333);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10440_10357_10368()
                {
                    var return_v = CurrentType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 10357, 10368);
                    return return_v;
                }


                int
                f_10440_10348_10377(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                containingType, Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol
                field)
                {
                    this_param.AddField(containingType, (Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol)field);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 10348, 10377);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 10028, 10417);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 10028, 10417);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public StateMachineFieldSymbol StateMachineField(TypeSymbol type, string name, SynthesizedLocalKind synthesizedKind, int slotIndex)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 10429, 10826);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 10585, 10618);

                f_10440_10585_10617(f_10440_10598_10609() is { });
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 10632, 10743);

                var
                result = f_10440_10645_10742(f_10440_10673_10684(), type, name, synthesizedKind, slotIndex, isPublic: false)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 10757, 10787);

                f_10440_10757_10786(this, f_10440_10766_10777(), result);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 10801, 10815);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 10429, 10826);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10440_10598_10609()
                {
                    var return_v = CurrentType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 10598, 10609);
                    return return_v;
                }


                int
                f_10440_10585_10617(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 10585, 10617);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10440_10673_10684()
                {
                    var return_v = CurrentType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 10673, 10684);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol
                f_10440_10645_10742(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                stateMachineType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, string
                name, Microsoft.CodeAnalysis.SynthesizedLocalKind
                synthesizedKind, int
                slotIndex, bool
                isPublic)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol(stateMachineType, type, name, synthesizedKind, slotIndex, isPublic: isPublic);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 10645, 10742);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10440_10766_10777()
                {
                    var return_v = CurrentType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 10766, 10777);
                    return return_v;
                }


                int
                f_10440_10757_10786(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                containingType, Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol
                field)
                {
                    this_param.AddField(containingType, (Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol)field);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 10757, 10786);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 10429, 10826);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 10429, 10826);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public StateMachineFieldSymbol StateMachineField(TypeSymbol type, string name, LocalSlotDebugInfo slotDebugInfo, int slotIndex)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 10838, 11229);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 10990, 11023);

                f_10440_10990_11022(f_10440_11003_11014() is { });
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 11037, 11146);

                var
                result = f_10440_11050_11145(f_10440_11078_11089(), type, name, slotDebugInfo, slotIndex, isPublic: false)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 11160, 11190);

                f_10440_11160_11189(this, f_10440_11169_11180(), result);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 11204, 11218);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 10838, 11229);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10440_11003_11014()
                {
                    var return_v = CurrentType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 11003, 11014);
                    return return_v;
                }


                int
                f_10440_10990_11022(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 10990, 11022);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10440_11078_11089()
                {
                    var return_v = CurrentType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 11078, 11089);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol
                f_10440_11050_11145(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                stateMachineType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, string
                name, Microsoft.CodeAnalysis.CodeGen.LocalSlotDebugInfo
                slotDebugInfo, int
                slotIndex, bool
                isPublic)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol(stateMachineType, type, name, slotDebugInfo, slotIndex, isPublic: isPublic);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 11050, 11145);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10440_11169_11180()
                {
                    var return_v = CurrentType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 11169, 11180);
                    return return_v;
                }


                int
                f_10440_11160_11189(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                containingType, Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol
                field)
                {
                    this_param.AddField(containingType, (Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol)field);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 11160, 11189);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 10838, 11229);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 10838, 11229);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void AddField(NamedTypeSymbol containingType, FieldSymbol field)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 11241, 11574);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 11430, 11468);

                f_10440_11430_11467(f_10440_11443_11459() is { });
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 11482, 11563);

                f_10440_11482_11562(f_10440_11482_11498(), containingType, f_10440_11540_11561(field));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 11241, 11574);

                Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder?
                f_10440_11443_11459()
                {
                    var return_v = ModuleBuilderOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 11443, 11459);
                    return return_v;
                }


                int
                f_10440_11430_11467(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 11430, 11467);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                f_10440_11482_11498()
                {
                    var return_v = ModuleBuilderOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 11482, 11498);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolAdapter
                f_10440_11540_11561(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.GetCciAdapter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 11540, 11561);
                    return return_v;
                }


                int
                f_10440_11482_11562(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                container, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolAdapter
                field)
                {
                    this_param.AddSynthesizedDefinition(container, (Microsoft.Cci.IFieldDefinition)field);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 11482, 11562);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 11241, 11574);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 11241, 11574);
            }
        }

        public GeneratedLabelSymbol GenerateLabel(string prefix)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 11586, 11718);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 11667, 11707);

                return f_10440_11674_11706(prefix);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 11586, 11718);

                Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                f_10440_11674_11706(string
                name)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 11674, 11706);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 11586, 11718);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 11586, 11718);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundThisReference This()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 11730, 11971);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 11787, 11840);

                f_10440_11787_11839(f_10440_11800_11815() is { IsStatic: false });
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 11854, 11960);

                return new BoundThisReference(f_10440_11884_11890(), f_10440_11892_11926(f_10440_11892_11921(f_10440_11892_11907()))) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10440, 11861, 11959) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 11730, 11971);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10440_11800_11815()
                {
                    var return_v = CurrentFunction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 11800, 11815);
                    return return_v;
                }


                int
                f_10440_11787_11839(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 11787, 11839);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10440_11884_11890()
                {
                    var return_v = Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 11884, 11890);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10440_11892_11907()
                {
                    var return_v = CurrentFunction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 11892, 11907);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10440_11892_11921(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ThisParameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 11892, 11921);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10440_11892_11926(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 11892, 11926);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 11730, 11971);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 11730, 11971);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundExpression This(LocalSymbol thisTempOpt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 11983, 12147);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 12060, 12136);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10440, 12067, 12088) || (((thisTempOpt != null) && DynAbs.Tracing.TraceSender.Conditional_F2(10440, 12091, 12109)) || DynAbs.Tracing.TraceSender.Conditional_F3(10440, 12112, 12135))) ? f_10440_12091_12109(this, thisTempOpt) : (BoundExpression)f_10440_12129_12135(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 11983, 12147);

                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10440_12091_12109(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 12091, 12109);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundThisReference
                f_10440_12129_12135(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.This();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 12129, 12135);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 11983, 12147);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 11983, 12147);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundBaseReference Base(NamedTypeSymbol baseType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 12159, 12398);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 12240, 12293);

                f_10440_12240_12292(f_10440_12253_12268() is { IsStatic: false });
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 12307, 12387);

                return new BoundBaseReference(f_10440_12337_12343(), baseType) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10440, 12314, 12386) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 12159, 12398);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10440_12253_12268()
                {
                    var return_v = CurrentFunction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 12253, 12268);
                    return return_v;
                }


                int
                f_10440_12240_12292(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 12240, 12292);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10440_12337_12343()
                {
                    var return_v = Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 12337, 12343);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 12159, 12398);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 12159, 12398);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundBadExpression BadExpression(TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 12410, 12657);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 12491, 12646);

                return f_10440_12498_12645(f_10440_12521_12527(), LookupResultKind.Empty, ImmutableArray<Symbol?>.Empty, ImmutableArray<BoundExpression>.Empty, type, hasErrors: true);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 12410, 12657);

                Microsoft.CodeAnalysis.SyntaxNode
                f_10440_12521_12527()
                {
                    var return_v = Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 12521, 12527);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBadExpression
                f_10440_12498_12645(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.LookupResultKind
                resultKind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol?>
                symbols, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                childBoundNodes, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, bool
                hasErrors)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundBadExpression(syntax, resultKind, symbols, childBoundNodes, type, hasErrors: hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 12498, 12645);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 12410, 12657);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 12410, 12657);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundParameter Parameter(ParameterSymbol p)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 12669, 12832);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 12744, 12821);

                return new BoundParameter(f_10440_12770_12776(), p, f_10440_12781_12787(p)) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10440, 12751, 12820) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 12669, 12832);

                Microsoft.CodeAnalysis.SyntaxNode
                f_10440_12770_12776()
                {
                    var return_v = Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 12770, 12776);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10440_12781_12787(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 12781, 12787);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 12669, 12832);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 12669, 12832);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundFieldAccess Field(BoundExpression? receiver, FieldSymbol f)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 12844, 13093);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 12940, 13082);

                return new BoundFieldAccess(f_10440_12968_12974(), receiver, f, ConstantValue.NotAvailable, LookupResultKind.Viable, f_10440_13042_13048(f)) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10440, 12947, 13081) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 12844, 13093);

                Microsoft.CodeAnalysis.SyntaxNode
                f_10440_12968_12974()
                {
                    var return_v = Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 12968, 12974);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10440_13042_13048(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 13042, 13048);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 12844, 13093);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 12844, 13093);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundFieldAccess InstanceField(FieldSymbol f)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 13105, 13227);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 13182, 13216);

                return f_10440_13189_13215(this, f_10440_13200_13211(this), f);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 13105, 13227);

                Microsoft.CodeAnalysis.CSharp.BoundThisReference
                f_10440_13200_13211(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.This();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 13200, 13211);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                f_10440_13189_13215(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundThisReference
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f)
                {
                    var return_v = this_param.Field((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, f);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 13189, 13215);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 13105, 13227);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 13105, 13227);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundExpression Property(WellKnownMember member)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 13239, 13360);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 13319, 13349);

                return f_10440_13326_13348(this, null, member);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 13239, 13360);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10440_13326_13348(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiverOpt, Microsoft.CodeAnalysis.WellKnownMember
                member)
                {
                    var return_v = this_param.Property(receiverOpt, member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 13326, 13348);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 13239, 13360);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 13239, 13360);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundExpression Property(BoundExpression? receiverOpt, WellKnownMember member)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 13372, 13877);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 13482, 13540);

                var
                propertySym = (PropertySymbol)f_10440_13516_13539(this, member)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 13554, 13730);

                f_10440_13554_13729(receiverOpt is null || (DynAbs.Tracing.TraceSender.Expression_False(10440, 13567, 13728) || f_10440_13590_13606(receiverOpt) is { } && (DynAbs.Tracing.TraceSender.Expression_True(10440, 13590, 13728) && f_10440_13634_13713(f_10440_13634_13679(f_10440_13634_13650(receiverOpt), f_10440_13662_13678(propertySym)).OfType<PropertySymbol>()) == propertySym)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 13744, 13810);

                f_10440_13744_13809(propertySym, f_10440_13789_13800(), f_10440_13802_13808());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 13824, 13866);

                return f_10440_13831_13865(this, receiverOpt, propertySym);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 13372, 13877);

                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10440_13516_13539(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                wm)
                {
                    var return_v = this_param.WellKnownMember(wm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 13516, 13539);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10440_13590_13606(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 13590, 13606);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10440_13634_13650(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 13634, 13650);
                    return return_v;
                }


                string
                f_10440_13662_13678(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 13662, 13678);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10440_13634_13679(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 13634, 13679);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                f_10440_13634_13713(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol>
                source)
                {
                    var return_v = source.Single<Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 13634, 13713);
                    return return_v;
                }


                int
                f_10440_13554_13729(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 13554, 13729);
                    return 0;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10440_13789_13800()
                {
                    var return_v = Diagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 13789, 13800);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10440_13802_13808()
                {
                    var return_v = Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 13802, 13808);
                    return return_v;
                }


                bool
                f_10440_13744_13809(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                symbol, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = Binder.ReportUseSiteDiagnostics((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, diagnostics, node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 13744, 13809);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10440_13831_13865(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiverOpt, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                property)
                {
                    var return_v = this_param.Property(receiverOpt, property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 13831, 13865);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 13372, 13877);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 13372, 13877);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundExpression Property(BoundExpression? receiverOpt, PropertySymbol property)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 13889, 14242);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 14000, 14057);

                f_10440_14000_14056((receiverOpt is null) == f_10440_14038_14055(property));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 14071, 14116);

                return f_10440_14078_14115(this, receiverOpt, f_10440_14096_14114(property));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 13889, 14242);

                bool
                f_10440_14038_14055(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 14038, 14055);
                    return return_v;
                }


                int
                f_10440_14000_14056(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 14000, 14056);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10440_14096_14114(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.GetMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 14096, 14114);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10440_14078_14115(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = this_param.Call(receiver, method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 14078, 14115);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 13889, 14242);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 13889, 14242);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundExpression Indexer(BoundExpression? receiverOpt, PropertySymbol property, BoundExpression arg0)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 14254, 14634);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 14386, 14443);

                f_10440_14386_14442((receiverOpt is null) == f_10440_14424_14441(property));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 14457, 14508);

                return f_10440_14464_14507(this, receiverOpt, f_10440_14482_14500(property), arg0);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 14254, 14634);

                bool
                f_10440_14424_14441(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 14424, 14441);
                    return return_v;
                }


                int
                f_10440_14386_14442(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 14386, 14442);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10440_14482_14500(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.GetMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 14482, 14500);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10440_14464_14507(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.CSharp.BoundExpression
                arg0)
                {
                    var return_v = this_param.Call(receiver, method, arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 14464, 14507);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 14254, 14634);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 14254, 14634);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public NamedTypeSymbol SpecialType(SpecialType st)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 14646, 14906);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 14721, 14782);

                NamedTypeSymbol
                specialType = f_10440_14751_14781(f_10440_14751_14762(), st)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 14796, 14862);

                f_10440_14796_14861(specialType, f_10440_14841_14852(), f_10440_14854_14860());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 14876, 14895);

                return specialType;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 14646, 14906);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10440_14751_14762()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 14751, 14762);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10440_14751_14781(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 14751, 14781);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10440_14841_14852()
                {
                    var return_v = Diagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 14841, 14852);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10440_14854_14860()
                {
                    var return_v = Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 14854, 14860);
                    return return_v;
                }


                bool
                f_10440_14796_14861(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = Binder.ReportUseSiteDiagnostics((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, diagnostics, node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 14796, 14861);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 14646, 14906);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 14646, 14906);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public ArrayTypeSymbol WellKnownArrayType(WellKnownType elementType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 14918, 15091);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 15011, 15080);

                return f_10440_15018_15079(f_10440_15018_15029(), f_10440_15052_15078(this, elementType));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 14918, 15091);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10440_15018_15029()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 15018, 15029);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10440_15052_15078(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.WellKnownType
                wt)
                {
                    var return_v = this_param.WellKnownType(wt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 15052, 15078);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                f_10440_15018_15079(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                elementType)
                {
                    var return_v = this_param.CreateArrayTypeSymbol((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)elementType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 15018, 15079);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 14918, 15091);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 14918, 15091);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public NamedTypeSymbol WellKnownType(WellKnownType wt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 15103, 15375);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 15182, 15247);

                NamedTypeSymbol
                wellKnownType = f_10440_15214_15246(f_10440_15214_15225(), wt)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 15261, 15329);

                f_10440_15261_15328(wellKnownType, f_10440_15308_15319(), f_10440_15321_15327());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 15343, 15364);

                return wellKnownType;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 15103, 15375);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10440_15214_15225()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 15214, 15225);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10440_15214_15246(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownType
                type)
                {
                    var return_v = this_param.GetWellKnownType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 15214, 15246);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10440_15308_15319()
                {
                    var return_v = Diagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 15308, 15319);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10440_15321_15327()
                {
                    var return_v = Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 15321, 15327);
                    return return_v;
                }


                bool
                f_10440_15261_15328(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = Binder.ReportUseSiteDiagnostics((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, diagnostics, node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 15261, 15328);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 15103, 15375);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 15103, 15375);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Symbol? WellKnownMember(WellKnownMember wm, bool isOptional)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 16060, 16773);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 16152, 16271);

                Symbol
                wellKnownMember = f_10440_16177_16270(f_10440_16207_16218(), wm, f_10440_16224_16235(), syntax: f_10440_16245_16251(), isOptional: true)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 16285, 16723) || true) && (wellKnownMember is null && (DynAbs.Tracing.TraceSender.Expression_True(10440, 16289, 16327) && !isOptional))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10440, 16285, 16723);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 16361, 16447);

                    RuntimeMembers.MemberDescriptor
                    memberDescriptor = f_10440_16412_16446(wm)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 16465, 16644);

                    var
                    diagnostic = f_10440_16482_16643(f_10440_16499_16625(ErrorCode.ERR_MissingPredefinedMember, memberDescriptor.DeclaringTypeMetadataName, memberDescriptor.Name), f_10440_16627_16642(f_10440_16627_16633()))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 16662, 16708);

                    throw f_10440_16668_16707(diagnostic);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10440, 16285, 16723);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 16739, 16762);

                return wellKnownMember;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 16060, 16773);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10440_16207_16218()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 16207, 16218);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10440_16224_16235()
                {
                    var return_v = Diagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 16224, 16235);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10440_16245_16251()
                {
                    var return_v = Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 16245, 16251);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10440_16177_16270(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.WellKnownMember
                member, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.SyntaxNode
                syntax, bool
                isOptional)
                {
                    var return_v = Binder.GetWellKnownTypeMember(compilation, member, diagnostics, syntax: syntax, isOptional: isOptional);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 16177, 16270);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RuntimeMembers.MemberDescriptor
                f_10440_16412_16446(Microsoft.CodeAnalysis.WellKnownMember
                member)
                {
                    var return_v = WellKnownMembers.GetDescriptor(member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 16412, 16446);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10440_16499_16625(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 16499, 16625);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10440_16627_16633()
                {
                    var return_v = Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 16627, 16633);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10440_16627_16642(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 16627, 16642);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                f_10440_16482_16643(Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                info, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnostic((Microsoft.CodeAnalysis.DiagnosticInfo)info, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 16482, 16643);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory.MissingPredefinedMember
                f_10440_16668_16707(Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                error)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory.MissingPredefinedMember((Microsoft.CodeAnalysis.Diagnostic)error);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 16668, 16707);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 16060, 16773);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 16060, 16773);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Symbol WellKnownMember(WellKnownMember wm)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 16785, 16905);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 16859, 16894);

                return f_10440_16866_16892(this, wm, false)!;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 16785, 16905);

                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10440_16866_16892(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                wm, bool
                isOptional)
                {
                    var return_v = this_param.WellKnownMember(wm, isOptional);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 16866, 16892);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 16785, 16905);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 16785, 16905);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public MethodSymbol? WellKnownMethod(WellKnownMember wm, bool isOptional)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 16917, 17080);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 17015, 17069);

                return (MethodSymbol?)f_10440_17037_17068(this, wm, isOptional);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 16917, 17080);

                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10440_17037_17068(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                wm, bool
                isOptional)
                {
                    var return_v = this_param.WellKnownMember(wm, isOptional);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 17037, 17068);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 16917, 17080);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 16917, 17080);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public MethodSymbol WellKnownMethod(WellKnownMember wm)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 17092, 17244);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 17172, 17233);

                return (MethodSymbol)f_10440_17193_17231(this, wm, isOptional: false)!;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 17092, 17244);

                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10440_17193_17231(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                wm, bool
                isOptional)
                {
                    var return_v = this_param.WellKnownMember(wm, isOptional: isOptional);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 17193, 17231);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 17092, 17244);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 17092, 17244);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Symbol SpecialMember(SpecialMember sm)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 17712, 18405);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 17782, 17842);

                Symbol
                specialMember = f_10440_17805_17841(f_10440_17805_17816(), sm)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 17856, 18275) || true) && (specialMember is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10440, 17856, 18275);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 17915, 17999);

                    RuntimeMembers.MemberDescriptor
                    memberDescriptor = f_10440_17966_17998(sm)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 18017, 18196);

                    var
                    diagnostic = f_10440_18034_18195(f_10440_18051_18177(ErrorCode.ERR_MissingPredefinedMember, memberDescriptor.DeclaringTypeMetadataName, memberDescriptor.Name), f_10440_18179_18194(f_10440_18179_18185()))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 18214, 18260);

                    throw f_10440_18220_18259(diagnostic);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10440, 17856, 18275);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 18291, 18359);

                f_10440_18291_18358(specialMember, f_10440_18338_18349(), f_10440_18351_18357());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 18373, 18394);

                return specialMember;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 17712, 18405);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10440_17805_17816()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 17805, 17816);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10440_17805_17841(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialMember
                specialMember)
                {
                    var return_v = this_param.GetSpecialTypeMember(specialMember);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 17805, 17841);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RuntimeMembers.MemberDescriptor
                f_10440_17966_17998(Microsoft.CodeAnalysis.SpecialMember
                member)
                {
                    var return_v = SpecialMembers.GetDescriptor(member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 17966, 17998);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10440_18051_18177(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 18051, 18177);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10440_18179_18185()
                {
                    var return_v = Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 18179, 18185);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10440_18179_18194(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 18179, 18194);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                f_10440_18034_18195(Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                info, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnostic((Microsoft.CodeAnalysis.DiagnosticInfo)info, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 18034, 18195);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory.MissingPredefinedMember
                f_10440_18220_18259(Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                error)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory.MissingPredefinedMember((Microsoft.CodeAnalysis.Diagnostic)error);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 18220, 18259);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10440_18338_18349()
                {
                    var return_v = Diagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 18338, 18349);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10440_18351_18357()
                {
                    var return_v = Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 18351, 18357);
                    return return_v;
                }


                bool
                f_10440_18291_18358(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = Binder.ReportUseSiteDiagnostics(symbol, diagnostics, node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 18291, 18358);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 17712, 18405);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 17712, 18405);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public MethodSymbol SpecialMethod(SpecialMember sm)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 18417, 18543);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 18493, 18532);

                return (MethodSymbol)f_10440_18514_18531(this, sm);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 18417, 18543);

                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10440_18514_18531(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.SpecialMember
                sm)
                {
                    var return_v = this_param.SpecialMember(sm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 18514, 18531);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 18417, 18543);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 18417, 18543);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public PropertySymbol SpecialProperty(SpecialMember sm)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 18555, 18687);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 18635, 18676);

                return (PropertySymbol)f_10440_18658_18675(this, sm);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 18555, 18687);

                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10440_18658_18675(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.SpecialMember
                sm)
                {
                    var return_v = this_param.SpecialMember(sm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 18658, 18675);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 18555, 18687);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 18555, 18687);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundExpressionStatement Assignment(BoundExpression left, BoundExpression right, bool isRef = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 18699, 18911);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 18831, 18900);

                return f_10440_18838_18899(this, f_10440_18858_18898(this, left, right, isRef));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 18699, 18911);

                Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                f_10440_18858_18898(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right, bool
                isRef)
                {
                    var return_v = this_param.AssignmentExpression(left, right, isRef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 18858, 18898);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10440_18838_18899(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                expr)
                {
                    var return_v = this_param.ExpressionStatement((Microsoft.CodeAnalysis.CSharp.BoundExpression)expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 18838, 18899);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 18699, 18911);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 18699, 18911);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundExpressionStatement ExpressionStatement(BoundExpression expr)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 18923, 19114);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 19021, 19103);

                return new BoundExpressionStatement(f_10440_19057_19063(), expr) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10440, 19028, 19102) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 18923, 19114);

                Microsoft.CodeAnalysis.SyntaxNode
                f_10440_19057_19063()
                {
                    var return_v = Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 19057, 19063);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 18923, 19114);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 18923, 19114);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundAssignmentOperator AssignmentExpression(BoundExpression left, BoundExpression right, bool isRef = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 19126, 19712);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 19267, 19572);

                f_10440_19267_19571(f_10440_19280_19289(left) is { } && (DynAbs.Tracing.TraceSender.Expression_True(10440, 19280, 19317) && f_10440_19300_19310(right) is { }) && (DynAbs.Tracing.TraceSender.Expression_True(10440, 19280, 19570) && (f_10440_19339_19401(f_10440_19339_19348(left), f_10440_19356_19366(right), TypeCompareKind.AllIgnoreOptions) || (DynAbs.Tracing.TraceSender.Expression_False(10440, 19339, 19496) || f_10440_19423_19496(left, right, isRef)) || (DynAbs.Tracing.TraceSender.Expression_False(10440, 19339, 19542) || f_10440_19518_19542(f_10440_19518_19528(right))) || (DynAbs.Tracing.TraceSender.Expression_False(10440, 19339, 19569) || f_10440_19546_19569(f_10440_19546_19555(left))))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 19588, 19701);

                return new BoundAssignmentOperator(f_10440_19623_19629(), left, right, f_10440_19644_19653(left), isRef: isRef) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10440, 19595, 19700) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 19126, 19712);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10440_19280_19289(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 19280, 19289);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10440_19300_19310(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 19300, 19310);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10440_19339_19348(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 19339, 19348);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10440_19356_19366(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 19356, 19366);
                    return return_v;
                }


                bool
                f_10440_19339_19401(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals(t2, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 19339, 19401);
                    return return_v;
                }


                bool
                f_10440_19423_19496(Microsoft.CodeAnalysis.CSharp.BoundExpression
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right, bool
                isRef)
                {
                    var return_v = StackOptimizerPass1.IsFixedBufferAssignmentToRefLocal(left, right, isRef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 19423, 19496);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10440_19518_19528(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 19518, 19528);
                    return return_v;
                }


                bool
                f_10440_19518_19542(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 19518, 19542);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10440_19546_19555(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 19546, 19555);
                    return return_v;
                }


                bool
                f_10440_19546_19569(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 19546, 19569);
                    return return_v;
                }


                int
                f_10440_19267_19571(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 19267, 19571);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10440_19623_19629()
                {
                    var return_v = Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 19623, 19629);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10440_19644_19653(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 19644, 19653);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 19126, 19712);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 19126, 19712);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundBlock Block()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 19724, 19836);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 19774, 19825);

                return f_10440_19781_19824(this, ImmutableArray<BoundStatement>.Empty);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 19724, 19836);

                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10440_19781_19824(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                statements)
                {
                    var return_v = this_param.Block(statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 19781, 19824);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 19724, 19836);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 19724, 19836);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundBlock Block(ImmutableArray<BoundStatement> statements)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 19848, 20010);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 19939, 19999);

                return f_10440_19946_19998(this, ImmutableArray<LocalSymbol>.Empty, statements);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 19848, 20010);

                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10440_19946_19998(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                statements)
                {
                    var return_v = this_param.Block(locals, statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 19946, 19998);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 19848, 20010);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 19848, 20010);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundBlock Block(params BoundStatement[] statements)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 20022, 20165);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 20106, 20154);

                return f_10440_20113_20153(this, f_10440_20119_20152(statements));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 20022, 20165);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10440_20119_20152(params Microsoft.CodeAnalysis.CSharp.BoundStatement[]
                items)
                {
                    var return_v = ImmutableArray.Create(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 20119, 20152);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10440_20113_20153(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                statements)
                {
                    var return_v = this_param.Block(statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 20113, 20153);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 20022, 20165);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 20022, 20165);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundBlock Block(ImmutableArray<LocalSymbol> locals, params BoundStatement[] statements)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 20177, 20364);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 20297, 20353);

                return f_10440_20304_20352(this, locals, f_10440_20318_20351(statements));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 20177, 20364);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10440_20318_20351(params Microsoft.CodeAnalysis.CSharp.BoundStatement[]
                items)
                {
                    var return_v = ImmutableArray.Create(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 20318, 20351);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10440_20304_20352(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                statements)
                {
                    var return_v = this_param.Block(locals, statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 20304, 20352);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 20177, 20364);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 20177, 20364);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundBlock Block(ImmutableArray<LocalSymbol> locals, ImmutableArray<BoundStatement> statements)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 20376, 20596);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 20503, 20585);

                return new BoundBlock(f_10440_20525_20531(), locals, statements) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10440, 20510, 20584) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 20376, 20596);

                Microsoft.CodeAnalysis.SyntaxNode
                f_10440_20525_20531()
                {
                    var return_v = Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 20525, 20531);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 20376, 20596);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 20376, 20596);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundBlock Block(ImmutableArray<LocalSymbol> locals, ImmutableArray<LocalFunctionSymbol> localFunctions, params BoundStatement[] statements)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 20608, 20863);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 20780, 20852);

                return f_10440_20787_20851(this, locals, localFunctions, f_10440_20817_20850(statements));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 20608, 20863);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10440_20817_20850(params Microsoft.CodeAnalysis.CSharp.BoundStatement[]
                items)
                {
                    var return_v = ImmutableArray.Create(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 20817, 20850);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10440_20787_20851(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol>
                localFunctions, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                statements)
                {
                    var return_v = this_param.Block(locals, localFunctions, statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 20787, 20851);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 20608, 20863);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 20608, 20863);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundBlock Block(ImmutableArray<LocalSymbol> locals, ImmutableArray<LocalFunctionSymbol> localFunctions, ImmutableArray<BoundStatement> statements)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 20875, 21163);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 21054, 21152);

                return new BoundBlock(f_10440_21076_21082(), locals, localFunctions, statements) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10440, 21061, 21151) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 20875, 21163);

                Microsoft.CodeAnalysis.SyntaxNode
                f_10440_21076_21082()
                {
                    var return_v = Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 21076, 21082);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 20875, 21163);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 20875, 21163);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundExtractedFinallyBlock ExtractedFinallyBlock(BoundBlock finallyBlock)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 21175, 21383);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 21280, 21372);

                return new BoundExtractedFinallyBlock(f_10440_21318_21324(), finallyBlock) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10440, 21287, 21371) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 21175, 21383);

                Microsoft.CodeAnalysis.SyntaxNode
                f_10440_21318_21324()
                {
                    var return_v = Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 21318, 21324);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 21175, 21383);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 21175, 21383);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundStatementList StatementList()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 21395, 21531);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 21461, 21520);

                return f_10440_21468_21519(this, ImmutableArray<BoundStatement>.Empty);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 21395, 21531);

                Microsoft.CodeAnalysis.CSharp.BoundStatementList
                f_10440_21468_21519(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                statements)
                {
                    var return_v = this_param.StatementList(statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 21468, 21519);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 21395, 21531);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 21395, 21531);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundStatementList StatementList(ImmutableArray<BoundStatement> statements)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 21543, 21743);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 21650, 21732);

                return new BoundStatementList(f_10440_21680_21686(), statements) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10440, 21657, 21731) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 21543, 21743);

                Microsoft.CodeAnalysis.SyntaxNode
                f_10440_21680_21686()
                {
                    var return_v = Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 21680, 21686);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 21543, 21743);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 21543, 21743);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundStatementList StatementList(BoundStatement first, BoundStatement second)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 21755, 21983);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 21864, 21972);

                return new BoundStatementList(f_10440_21894_21900(), f_10440_21902_21938(first, second)) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10440, 21871, 21971) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 21755, 21983);

                Microsoft.CodeAnalysis.SyntaxNode
                f_10440_21894_21900()
                {
                    var return_v = Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 21894, 21900);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10440_21902_21938(Microsoft.CodeAnalysis.CSharp.BoundStatement
                item1, Microsoft.CodeAnalysis.CSharp.BoundStatement
                item2)
                {
                    var return_v = ImmutableArray.Create(item1, item2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 21902, 21938);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 21755, 21983);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 21755, 21983);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundReturnStatement Return(BoundExpression? expression = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 21995, 23169);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 22090, 22127);

                f_10440_22090_22126(f_10440_22103_22118() is { });

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 22143, 23033) || true) && (expression != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10440, 22143, 23033);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 22276, 22327);

                    HashSet<DiagnosticInfo>?
                    useSiteDiagnostics = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 22345, 22482);

                    var
                    conversion = f_10440_22362_22481(f_10440_22362_22385(f_10440_22362_22373()), f_10440_22413_22428(expression), f_10440_22430_22456(f_10440_22430_22445()), ref useSiteDiagnostics)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 22500, 22549);

                    f_10440_22500_22548(f_10440_22513_22547(useSiteDiagnostics));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 22567, 22628);

                    f_10440_22567_22627(conversion.Kind != ConversionKind.NoConversion);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 22646, 23018) || true) && (conversion.Kind != ConversionKind.Identity)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10440, 22646, 23018);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 22734, 22788);

                        f_10440_22734_22787(f_10440_22747_22770(f_10440_22747_22762()) == RefKind.None);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 22810, 22999);

                        expression = f_10440_22823_22998(f_10440_22851_22857(), expression, conversion, false, explicitCastInCode: false, conversionGroupOpt: null, ConstantValue.NotAvailable, f_10440_22971_22997(f_10440_22971_22986()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10440, 22646, 23018);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10440, 22143, 23033);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 23049, 23158);

                return new BoundReturnStatement(f_10440_23081_23087(), f_10440_23089_23112(f_10440_23089_23104()), expression) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10440, 23056, 23157) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 21995, 23169);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10440_22103_22118()
                {
                    var return_v = CurrentFunction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 22103, 22118);
                    return return_v;
                }


                int
                f_10440_22090_22126(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 22090, 22126);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10440_22362_22373()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 22362, 22373);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversions
                f_10440_22362_22385(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Conversions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 22362, 22385);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10440_22413_22428(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 22413, 22428);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10440_22430_22445()
                {
                    var return_v = CurrentFunction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 22430, 22445);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10440_22430_22456(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 22430, 22456);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10440_22362_22481(Microsoft.CodeAnalysis.CSharp.Conversions
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = this_param.ClassifyConversionFromType(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 22362, 22481);
                    return return_v;
                }


                bool
                f_10440_22513_22547(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                hashSet)
                {
                    var return_v = hashSet.IsNullOrEmpty<Microsoft.CodeAnalysis.DiagnosticInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 22513, 22547);
                    return return_v;
                }


                int
                f_10440_22500_22548(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 22500, 22548);
                    return 0;
                }


                int
                f_10440_22567_22627(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 22567, 22627);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10440_22747_22762()
                {
                    var return_v = CurrentFunction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 22747, 22762);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10440_22747_22770(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 22747, 22770);
                    return return_v;
                }


                int
                f_10440_22734_22787(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 22734, 22787);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10440_22851_22857()
                {
                    var return_v = Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 22851, 22857);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10440_22971_22986()
                {
                    var return_v = CurrentFunction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 22971, 22986);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10440_22971_22997(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 22971, 22997);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundConversion
                f_10440_22823_22998(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                operand, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, bool
                @checked, bool
                explicitCastInCode, Microsoft.CodeAnalysis.CSharp.ConversionGroup?
                conversionGroupOpt, Microsoft.CodeAnalysis.ConstantValue
                constantValueOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = BoundConversion.Synthesized(syntax, operand, conversion, @checked, explicitCastInCode: explicitCastInCode, conversionGroupOpt: conversionGroupOpt, constantValueOpt, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 22823, 22998);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10440_23081_23087()
                {
                    var return_v = Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 23081, 23087);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10440_23089_23104()
                {
                    var return_v = CurrentFunction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 23089, 23104);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10440_23089_23112(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 23089, 23112);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 21995, 23169);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 21995, 23169);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void CloseMethod(BoundStatement body)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 23181, 23526);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 23250, 23287);

                f_10440_23250_23286(f_10440_23263_23278() is { });

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 23301, 23401) || true) && (f_10440_23305_23314(body) != BoundKind.Block)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10440, 23301, 23401);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 23367, 23386);

                    body = f_10440_23374_23385(this, body);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10440, 23301, 23401);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 23417, 23478);

                f_10440_23417_23477(f_10440_23417_23433(), f_10440_23455_23470(), body);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 23492, 23515);

                CurrentFunction = null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 23181, 23526);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10440_23263_23278()
                {
                    var return_v = CurrentFunction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 23263, 23278);
                    return return_v;
                }


                int
                f_10440_23250_23286(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 23250, 23286);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10440_23305_23314(Microsoft.CodeAnalysis.CSharp.BoundStatement
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 23305, 23314);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10440_23374_23385(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, params Microsoft.CodeAnalysis.CSharp.BoundStatement[]
                statements)
                {
                    var return_v = this_param.Block(statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 23374, 23385);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                f_10440_23417_23433()
                {
                    var return_v = CompilationState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 23417, 23433);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10440_23455_23470()
                {
                    var return_v = CurrentFunction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 23455, 23470);
                    return return_v;
                }


                int
                f_10440_23417_23477(Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.CSharp.BoundStatement
                body)
                {
                    this_param.AddSynthesizedMethod(method, body);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 23417, 23477);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 23181, 23526);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 23181, 23526);
            }
        }

        public LocalSymbol SynthesizedLocal(
                    TypeSymbol type,
                    SyntaxNode? syntax = null,
                    bool isPinned = false,
                    RefKind refKind = RefKind.None,
                    SynthesizedLocalKind kind = SynthesizedLocalKind.LoweringTemp
                    ,
                    [CallerLineNumber] int createdAtLineNumber = 0,
                    [CallerFilePath] string? createdAtFilePath = null
                    )
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 23538, 24216);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 23998, 24205);

                return f_10440_24005_24204(f_10440_24026_24041(), TypeWithAnnotations.Create(type), kind, syntax, isPinned, refKind, createdAtLineNumber, createdAtFilePath);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 23538, 24216);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10440_24026_24041()
                {
                    var return_v = CurrentFunction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 24026, 24041);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedLocal
                f_10440_24005_24204(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                containingMethodOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                type, Microsoft.CodeAnalysis.SynthesizedLocalKind
                kind, Microsoft.CodeAnalysis.SyntaxNode?
                syntaxOpt, bool
                isPinned, Microsoft.CodeAnalysis.RefKind
                refKind, int
                createdAtLineNumber, string?
                createdAtFilePath)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedLocal(containingMethodOpt, type, kind, syntaxOpt, isPinned, refKind, createdAtLineNumber, createdAtFilePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 24005, 24204);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 23538, 24216);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 23538, 24216);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public ParameterSymbol SynthesizedParameter(TypeSymbol type, string name, MethodSymbol? container = null, int ordinal = 0)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 24228, 24501);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 24375, 24490);

                return f_10440_24382_24489(container, TypeWithAnnotations.Create(type), ordinal, RefKind.None, name);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 24228, 24501);

                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10440_24382_24489(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                container, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                type, int
                ordinal, Microsoft.CodeAnalysis.RefKind
                refKind, string
                name)
                {
                    var return_v = SynthesizedParameterSymbol.Create(container, type, ordinal, refKind, name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 24382, 24489);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 24228, 24501);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 24228, 24501);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundBinaryOperator Binary(BinaryOperatorKind kind, TypeSymbol type, BoundExpression left, BoundExpression right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 24513, 24829);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 24658, 24818);

                return new BoundBinaryOperator(f_10440_24689_24700(this), kind, ConstantValue.NotAvailable, null, LookupResultKind.Viable, left, right, type) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10440, 24665, 24817) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 24513, 24829);

                Microsoft.CodeAnalysis.SyntaxNode
                f_10440_24689_24700(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 24689, 24700);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 24513, 24829);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 24513, 24829);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundAsOperator As(BoundExpression operand, TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 24841, 25073);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 24933, 25062);

                return new BoundAsOperator(f_10440_24960_24971(this), operand, f_10440_24982_24992(this, type), Conversion.ExplicitReference, type) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10440, 24940, 25061) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 24841, 25073);

                Microsoft.CodeAnalysis.SyntaxNode
                f_10440_24960_24971(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 24960, 24971);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
                f_10440_24982_24992(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Type(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 24982, 24992);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 24841, 25073);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 24841, 25073);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundIsOperator Is(BoundExpression operand, TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 25085, 25741);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 25177, 25219);

                HashSet<DiagnosticInfo>?
                discarded = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 25456, 25556);

                Conversion
                c = f_10440_25471_25555(f_10440_25471_25494(f_10440_25471_25482()), f_10440_25521_25533(operand), type, ref discarded)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 25570, 25730);

                return new BoundIsOperator(f_10440_25597_25608(this), operand, f_10440_25619_25629(this, type), c, f_10440_25634_25696(this, Microsoft.CodeAnalysis.SpecialType.System_Boolean)) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10440, 25577, 25729) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 25085, 25741);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10440_25471_25482()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 25471, 25482);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversions
                f_10440_25471_25494(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Conversions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 25471, 25494);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10440_25521_25533(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 25521, 25533);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10440_25471_25555(Microsoft.CodeAnalysis.CSharp.Conversions
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = this_param.ClassifyBuiltInConversion(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 25471, 25555);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10440_25597_25608(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 25597, 25608);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
                f_10440_25619_25629(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Type(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 25619, 25629);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10440_25634_25696(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.SpecialType
                st)
                {
                    var return_v = this_param.SpecialType(st);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 25634, 25696);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 25085, 25741);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 25085, 25741);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundBinaryOperator LogicalAnd(BoundExpression left, BoundExpression right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 25753, 26186);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 25860, 25940);

                f_10440_25860_25939(f_10440_25873_25895_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10440_25873_25882(left), 10440, 25873, 25895)?.SpecialType) == CodeAnalysis.SpecialType.System_Boolean);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 25954, 26035);

                f_10440_25954_26034(f_10440_25967_25990_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10440_25967_25977(right), 10440, 25967, 25990)?.SpecialType) == CodeAnalysis.SpecialType.System_Boolean);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 26049, 26175);

                return f_10440_26056_26174(this, BinaryOperatorKind.LogicalBoolAnd, f_10440_26098_26160(this, Microsoft.CodeAnalysis.SpecialType.System_Boolean), left, right);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 25753, 26186);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10440_25873_25882(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 25873, 25882);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType?
                f_10440_25873_25895_M(Microsoft.CodeAnalysis.SpecialType?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 25873, 25895);
                    return return_v;
                }


                int
                f_10440_25860_25939(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 25860, 25939);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10440_25967_25977(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 25967, 25977);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType?
                f_10440_25967_25990_M(Microsoft.CodeAnalysis.SpecialType?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 25967, 25990);
                    return return_v;
                }


                int
                f_10440_25954_26034(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 25954, 26034);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10440_26098_26160(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.SpecialType
                st)
                {
                    var return_v = this_param.SpecialType(st);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 26098, 26160);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                f_10440_26056_26174(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.BoundExpression
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right)
                {
                    var return_v = this_param.Binary(kind, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 26056, 26174);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 25753, 26186);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 25753, 26186);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundBinaryOperator LogicalOr(BoundExpression left, BoundExpression right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 26198, 26629);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 26304, 26384);

                f_10440_26304_26383(f_10440_26317_26339_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10440_26317_26326(left), 10440, 26317, 26339)?.SpecialType) == CodeAnalysis.SpecialType.System_Boolean);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 26398, 26479);

                f_10440_26398_26478(f_10440_26411_26434_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10440_26411_26421(right), 10440, 26411, 26434)?.SpecialType) == CodeAnalysis.SpecialType.System_Boolean);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 26493, 26618);

                return f_10440_26500_26617(this, BinaryOperatorKind.LogicalBoolOr, f_10440_26541_26603(this, Microsoft.CodeAnalysis.SpecialType.System_Boolean), left, right);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 26198, 26629);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10440_26317_26326(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 26317, 26326);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType?
                f_10440_26317_26339_M(Microsoft.CodeAnalysis.SpecialType?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 26317, 26339);
                    return return_v;
                }


                int
                f_10440_26304_26383(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 26304, 26383);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10440_26411_26421(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 26411, 26421);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType?
                f_10440_26411_26434_M(Microsoft.CodeAnalysis.SpecialType?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 26411, 26434);
                    return return_v;
                }


                int
                f_10440_26398_26478(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 26398, 26478);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10440_26541_26603(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.SpecialType
                st)
                {
                    var return_v = this_param.SpecialType(st);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 26541, 26603);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                f_10440_26500_26617(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.BoundExpression
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right)
                {
                    var return_v = this_param.Binary(kind, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 26500, 26617);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 26198, 26629);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 26198, 26629);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundBinaryOperator IntEqual(BoundExpression left, BoundExpression right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 26641, 26877);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 26746, 26866);

                return f_10440_26753_26865(this, BinaryOperatorKind.IntEqual, f_10440_26789_26851(this, Microsoft.CodeAnalysis.SpecialType.System_Boolean), left, right);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 26641, 26877);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10440_26789_26851(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.SpecialType
                st)
                {
                    var return_v = this_param.SpecialType(st);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 26789, 26851);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                f_10440_26753_26865(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.BoundExpression
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right)
                {
                    var return_v = this_param.Binary(kind, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 26753, 26865);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 26641, 26877);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 26641, 26877);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundBinaryOperator ObjectEqual(BoundExpression left, BoundExpression right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 26889, 27131);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 26997, 27120);

                return f_10440_27004_27119(this, BinaryOperatorKind.ObjectEqual, f_10440_27043_27105(this, Microsoft.CodeAnalysis.SpecialType.System_Boolean), left, right);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 26889, 27131);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10440_27043_27105(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.SpecialType
                st)
                {
                    var return_v = this_param.SpecialType(st);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 27043, 27105);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                f_10440_27004_27119(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.BoundExpression
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right)
                {
                    var return_v = this_param.Binary(kind, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 27004, 27119);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 26889, 27131);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 26889, 27131);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundBinaryOperator ObjectNotEqual(BoundExpression left, BoundExpression right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 27143, 27391);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 27254, 27380);

                return f_10440_27261_27379(this, BinaryOperatorKind.ObjectNotEqual, f_10440_27303_27365(this, Microsoft.CodeAnalysis.SpecialType.System_Boolean), left, right);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 27143, 27391);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10440_27303_27365(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.SpecialType
                st)
                {
                    var return_v = this_param.SpecialType(st);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 27303, 27365);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                f_10440_27261_27379(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.BoundExpression
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right)
                {
                    var return_v = this_param.Binary(kind, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 27261, 27379);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 27143, 27391);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 27143, 27391);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundBinaryOperator IntNotEqual(BoundExpression left, BoundExpression right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 27403, 27645);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 27511, 27634);

                return f_10440_27518_27633(this, BinaryOperatorKind.IntNotEqual, f_10440_27557_27619(this, Microsoft.CodeAnalysis.SpecialType.System_Boolean), left, right);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 27403, 27645);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10440_27557_27619(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.SpecialType
                st)
                {
                    var return_v = this_param.SpecialType(st);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 27557, 27619);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                f_10440_27518_27633(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.BoundExpression
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right)
                {
                    var return_v = this_param.Binary(kind, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 27518, 27633);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 27403, 27645);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 27403, 27645);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundBinaryOperator IntLessThan(BoundExpression left, BoundExpression right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 27657, 27899);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 27765, 27888);

                return f_10440_27772_27887(this, BinaryOperatorKind.IntLessThan, f_10440_27811_27873(this, Microsoft.CodeAnalysis.SpecialType.System_Boolean), left, right);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 27657, 27899);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10440_27811_27873(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.SpecialType
                st)
                {
                    var return_v = this_param.SpecialType(st);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 27811, 27873);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                f_10440_27772_27887(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.BoundExpression
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right)
                {
                    var return_v = this_param.Binary(kind, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 27772, 27887);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 27657, 27899);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 27657, 27899);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundBinaryOperator IntGreaterThanOrEqual(BoundExpression left, BoundExpression right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 27911, 28163);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 28029, 28152);

                return f_10440_28036_28151(this, BinaryOperatorKind.IntGreaterThanOrEqual, f_10440_28085_28137(this, CodeAnalysis.SpecialType.System_Boolean), left, right);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 27911, 28163);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10440_28085_28137(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.SpecialType
                st)
                {
                    var return_v = this_param.SpecialType(st);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 28085, 28137);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                f_10440_28036_28151(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.BoundExpression
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right)
                {
                    var return_v = this_param.Binary(kind, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 28036, 28151);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 27911, 28163);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 27911, 28163);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundBinaryOperator IntSubtract(BoundExpression left, BoundExpression right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 28175, 28408);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 28283, 28397);

                return f_10440_28290_28396(this, BinaryOperatorKind.IntSubtraction, f_10440_28332_28382(this, CodeAnalysis.SpecialType.System_Int32), left, right);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 28175, 28408);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10440_28332_28382(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.SpecialType
                st)
                {
                    var return_v = this_param.SpecialType(st);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 28332, 28382);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                f_10440_28290_28396(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.BoundExpression
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right)
                {
                    var return_v = this_param.Binary(kind, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 28290, 28396);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 28175, 28408);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 28175, 28408);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundLiteral Literal(int value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 28420, 28649);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 28483, 28638);

                return new BoundLiteral(f_10440_28507_28513(), f_10440_28515_28542(value), f_10440_28544_28604(this, Microsoft.CodeAnalysis.SpecialType.System_Int32)) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10440, 28490, 28637) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 28420, 28649);

                Microsoft.CodeAnalysis.SyntaxNode
                f_10440_28507_28513()
                {
                    var return_v = Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 28507, 28513);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10440_28515_28542(int
                value)
                {
                    var return_v = ConstantValue.Create(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 28515, 28542);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10440_28544_28604(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.SpecialType
                st)
                {
                    var return_v = this_param.SpecialType(st);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 28544, 28604);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 28420, 28649);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 28420, 28649);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundLiteral Literal(uint value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 28661, 28892);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 28725, 28881);

                return new BoundLiteral(f_10440_28749_28755(), f_10440_28757_28784(value), f_10440_28786_28847(this, Microsoft.CodeAnalysis.SpecialType.System_UInt32)) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10440, 28732, 28880) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 28661, 28892);

                Microsoft.CodeAnalysis.SyntaxNode
                f_10440_28749_28755()
                {
                    var return_v = Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 28749, 28755);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10440_28757_28784(uint
                value)
                {
                    var return_v = ConstantValue.Create(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 28757, 28784);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10440_28786_28847(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.SpecialType
                st)
                {
                    var return_v = this_param.SpecialType(st);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 28786, 28847);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 28661, 28892);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 28661, 28892);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundLiteral Literal(ConstantValue value, TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 28904, 29082);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 28994, 29071);

                return new BoundLiteral(f_10440_29018_29024(), value, type) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10440, 29001, 29070) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 28904, 29082);

                Microsoft.CodeAnalysis.SyntaxNode
                f_10440_29018_29024()
                {
                    var return_v = Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 29018, 29024);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 28904, 29082);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 28904, 29082);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundObjectCreationExpression New(NamedTypeSymbol type, params BoundExpression[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 29094, 29342);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 29212, 29294);

                var
                ctor = type.InstanceConstructors.Single(c => c.ParameterCount == args.Length)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 29308, 29331);

                return f_10440_29315_29330(this, ctor, args);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 29094, 29342);

                Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                f_10440_29315_29330(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                ctor, params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                args)
                {
                    var return_v = this_param.New(ctor, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 29315, 29330);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 29094, 29342);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 29094, 29342);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundObjectCreationExpression New(MethodSymbol ctor, params BoundExpression[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 29458, 29495);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 29461, 29495);
                return f_10440_29461_29495(this, ctor, f_10440_29471_29494(args)); DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 29458, 29495);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 29458, 29495);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 29458, 29495);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
            f_10440_29471_29494(Microsoft.CodeAnalysis.CSharp.BoundExpression[]
            items)
            {
                var return_v = items.ToImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 29471, 29494);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
            f_10440_29461_29495(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
            this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
            ctor, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
            args)
            {
                var return_v = this_param.New(ctor, args);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 29461, 29495);
                return return_v;
            }

        }

        public BoundObjectCreationExpression New(MethodSymbol ctor, ImmutableArray<BoundExpression> args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 29619, 29707);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 29622, 29707);
                return new BoundObjectCreationExpression(f_10440_29656_29662(), ctor, args) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10440, 29622, 29707) }; DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 29619, 29707);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 29619, 29707);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 29619, 29707);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.SyntaxNode
            f_10440_29656_29662()
            {
                var return_v = Syntax;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 29656, 29662);
                return return_v;
            }

        }

        public BoundObjectCreationExpression New(WellKnownMember wm, ImmutableArray<BoundExpression> args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 29720, 29992);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 29843, 29874);

                var
                ctor = f_10440_29854_29873(this, wm)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 29888, 29981);

                return new BoundObjectCreationExpression(f_10440_29929_29935(), ctor, args) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10440, 29895, 29980) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 29720, 29992);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10440_29854_29873(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                wm)
                {
                    var return_v = this_param.WellKnownMethod(wm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 29854, 29873);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10440_29929_29935()
                {
                    var return_v = Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 29929, 29935);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 29720, 29992);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 29720, 29992);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundExpression MakeIsNotANumberTest(BoundExpression input)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 30004, 30709);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 30095, 30698);

                switch (f_10440_30103_30113(input))
                {

                    case { SpecialType: CodeAnalysis.SpecialType.System_Double }:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10440, 30095, 30698);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 30282, 30356);

                        return f_10440_30289_30355(this, CodeAnalysis.SpecialMember.System_Double__IsNaN, input);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10440, 30095, 30698);

                    case { SpecialType: CodeAnalysis.SpecialType.System_Single }:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10440, 30095, 30698);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 30508, 30582);

                        return f_10440_30515_30581(this, CodeAnalysis.SpecialMember.System_Single__IsNaN, input);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10440, 30095, 30698);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10440, 30095, 30698);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 30630, 30683);

                        throw f_10440_30636_30682(f_10440_30671_30681(input));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10440, 30095, 30698);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 30004, 30709);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10440_30103_30113(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 30103, 30113);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10440_30289_30355(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.SpecialMember
                method, params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                args)
                {
                    var return_v = this_param.StaticCall(method, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 30289, 30355);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10440_30515_30581(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.SpecialMember
                method, params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                args)
                {
                    var return_v = this_param.StaticCall(method, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 30515, 30581);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10440_30671_30681(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 30671, 30681);
                    return return_v;
                }


                System.Exception
                f_10440_30636_30682(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object?)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 30636, 30682);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 30004, 30709);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 30004, 30709);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundExpression InstanceCall(BoundExpression? receiver, string name, BoundExpression arg)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 30721, 30978);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 30842, 30967);

                return f_10440_30849_30966(this, BinderFlags.None, f_10440_30892_30903(this), receiver, name, f_10440_30921_30947(arg), f_10440_30949_30965(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 30721, 30978);

                Microsoft.CodeAnalysis.SyntaxNode
                f_10440_30892_30903(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 30892, 30903);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10440_30921_30947(Microsoft.CodeAnalysis.CSharp.BoundExpression
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 30921, 30947);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10440_30949_30965(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Diagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 30949, 30965);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10440_30849_30966(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BinderFlags
                flags, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiver, string
                methodName, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                args, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.MakeInvocationExpression(flags, node, receiver, methodName, args, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 30849, 30966);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 30721, 30978);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 30721, 30978);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundExpression InstanceCall(BoundExpression? receiver, string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 30990, 31237);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 31090, 31226);

                return f_10440_31097_31225(this, BinderFlags.None, f_10440_31140_31151(this), receiver, name, ImmutableArray<BoundExpression>.Empty, f_10440_31208_31224(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 30990, 31237);

                Microsoft.CodeAnalysis.SyntaxNode
                f_10440_31140_31151(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 31140, 31151);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10440_31208_31224(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Diagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 31208, 31224);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10440_31097_31225(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BinderFlags
                flags, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiver, string
                methodName, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                args, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.MakeInvocationExpression(flags, node, receiver, methodName, args, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 31097, 31225);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 30990, 31237);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 30990, 31237);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundExpression StaticCall(TypeSymbol receiver, string name, params BoundExpression[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 31249, 31516);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 31372, 31505);

                return f_10440_31379_31504(this, BinderFlags.None, f_10440_31422_31433(this), f_10440_31435_31454(this, receiver), name, f_10440_31462_31485(args), f_10440_31487_31503(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 31249, 31516);

                Microsoft.CodeAnalysis.SyntaxNode
                f_10440_31422_31433(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 31422, 31433);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
                f_10440_31435_31454(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Type(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 31435, 31454);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10440_31462_31485(Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                items)
                {
                    var return_v = items.ToImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 31462, 31485);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10440_31487_31503(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Diagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 31487, 31503);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10440_31379_31504(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BinderFlags
                flags, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
                receiver, string
                methodName, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                args, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.MakeInvocationExpression(flags, node, (Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, methodName, args, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 31379, 31504);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 31249, 31516);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 31249, 31516);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundExpression StaticCall(TypeSymbol receiver, string name, ImmutableArray<BoundExpression> args, bool allowUnexpandedForm)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 31528, 31851);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 31684, 31840);

                return f_10440_31691_31839(this, BinderFlags.None, f_10440_31734_31745(this), f_10440_31747_31766(this, receiver), name, args, f_10440_31780_31796(this), allowUnexpandedForm: allowUnexpandedForm);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 31528, 31851);

                Microsoft.CodeAnalysis.SyntaxNode
                f_10440_31734_31745(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 31734, 31745);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
                f_10440_31747_31766(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Type(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 31747, 31766);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10440_31780_31796(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Diagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 31780, 31796);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10440_31691_31839(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BinderFlags
                flags, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
                receiver, string
                methodName, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                args, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                allowUnexpandedForm)
                {
                    var return_v = this_param.MakeInvocationExpression(flags, node, (Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, methodName, args, diagnostics, allowUnexpandedForm: allowUnexpandedForm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 31691, 31839);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 31528, 31851);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 31528, 31851);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundExpression StaticCall(BinderFlags flags, TypeSymbol receiver, string name, ImmutableArray<TypeSymbol> typeArgs, params BoundExpression[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 31863, 32185);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 32042, 32174);

                return f_10440_32049_32173(this, flags, f_10440_32081_32092(this), f_10440_32094_32113(this, receiver), name, f_10440_32121_32144(args), f_10440_32146_32162(this), typeArgs);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 31863, 32185);

                Microsoft.CodeAnalysis.SyntaxNode
                f_10440_32081_32092(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 32081, 32092);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
                f_10440_32094_32113(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Type(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 32094, 32113);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10440_32121_32144(Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                items)
                {
                    var return_v = items.ToImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 32121, 32144);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10440_32146_32162(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Diagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 32146, 32162);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10440_32049_32173(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BinderFlags
                flags, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
                receiver, string
                methodName, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                args, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                typeArgs)
                {
                    var return_v = this_param.MakeInvocationExpression(flags, node, (Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, methodName, args, diagnostics, typeArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 32049, 32173);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 31863, 32185);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 31863, 32185);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundExpression StaticCall(TypeSymbol receiver, MethodSymbol method, params BoundExpression[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 32197, 32580);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 32328, 32521) || true) && (method is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10440, 32328, 32521);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 32380, 32506);

                    return f_10440_32387_32505(f_10440_32410_32416(), default(LookupResultKind), ImmutableArray<Symbol?>.Empty, f_10440_32476_32494(args), receiver);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10440, 32328, 32521);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 32537, 32569);

                return f_10440_32544_32568(this, null, method, args);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 32197, 32580);

                Microsoft.CodeAnalysis.SyntaxNode
                f_10440_32410_32416()
                {
                    var return_v = Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 32410, 32416);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10440_32476_32494(Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                items)
                {
                    var return_v = items.AsImmutable<Microsoft.CodeAnalysis.CSharp.BoundExpression>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 32476, 32494);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBadExpression
                f_10440_32387_32505(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.LookupResultKind
                resultKind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol?>
                symbols, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                childBoundNodes, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundBadExpression(syntax, resultKind, symbols, childBoundNodes, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 32387, 32505);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10440_32544_32568(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                args)
                {
                    var return_v = this_param.Call(receiver, method, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 32544, 32568);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 32197, 32580);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 32197, 32580);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundExpression StaticCall(MethodSymbol method, ImmutableArray<BoundExpression> args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 32698, 32725);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 32701, 32725);
                return f_10440_32701_32725(this, null, method, args); DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 32698, 32725);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 32698, 32725);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 32698, 32725);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.BoundCall
            f_10440_32701_32725(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
            this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
            receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
            method, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
            args)
            {
                var return_v = this_param.Call(receiver, method, args);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 32701, 32725);
                return return_v;
            }

        }

        public BoundExpression StaticCall(WellKnownMember method, params BoundExpression[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 32738, 33097);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 32851, 32903);

                MethodSymbol
                methodSymbol = f_10440_32879_32902(this, method)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 32917, 32984);

                f_10440_32917_32983(methodSymbol, f_10440_32963_32974(), f_10440_32976_32982());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 32998, 33034);

                f_10440_32998_33033(f_10440_33011_33032(methodSymbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 33048, 33086);

                return f_10440_33055_33085(this, null, methodSymbol, args);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 32738, 33097);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10440_32879_32902(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                wm)
                {
                    var return_v = this_param.WellKnownMethod(wm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 32879, 32902);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10440_32963_32974()
                {
                    var return_v = Diagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 32963, 32974);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10440_32976_32982()
                {
                    var return_v = Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 32976, 32982);
                    return return_v;
                }


                bool
                f_10440_32917_32983(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = Binder.ReportUseSiteDiagnostics((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, diagnostics, node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 32917, 32983);
                    return return_v;
                }


                bool
                f_10440_33011_33032(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 33011, 33032);
                    return return_v;
                }


                int
                f_10440_32998_33033(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 32998, 33033);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10440_33055_33085(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                args)
                {
                    var return_v = this_param.Call(receiver, method, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 33055, 33085);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 32738, 33097);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 32738, 33097);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundExpression StaticCall(SpecialMember method, params BoundExpression[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 33109, 33464);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 33220, 33270);

                MethodSymbol
                methodSymbol = f_10440_33248_33269(this, method)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 33284, 33351);

                f_10440_33284_33350(methodSymbol, f_10440_33330_33341(), f_10440_33343_33349());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 33365, 33401);

                f_10440_33365_33400(f_10440_33378_33399(methodSymbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 33415, 33453);

                return f_10440_33422_33452(this, null, methodSymbol, args);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 33109, 33464);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10440_33248_33269(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.SpecialMember
                sm)
                {
                    var return_v = this_param.SpecialMethod(sm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 33248, 33269);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10440_33330_33341()
                {
                    var return_v = Diagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 33330, 33341);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10440_33343_33349()
                {
                    var return_v = Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 33343, 33349);
                    return return_v;
                }


                bool
                f_10440_33284_33350(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = Binder.ReportUseSiteDiagnostics((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, diagnostics, node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 33284, 33350);
                    return return_v;
                }


                bool
                f_10440_33378_33399(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 33378, 33399);
                    return return_v;
                }


                int
                f_10440_33365_33400(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 33365, 33400);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10440_33422_33452(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                args)
                {
                    var return_v = this_param.Call(receiver, method, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 33422, 33452);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 33109, 33464);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 33109, 33464);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundCall Call(BoundExpression? receiver, MethodSymbol method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 33476, 33650);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 33570, 33639);

                return f_10440_33577_33638(this, receiver, method, ImmutableArray<BoundExpression>.Empty);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 33476, 33650);

                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10440_33577_33638(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                args)
                {
                    var return_v = this_param.Call(receiver, method, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 33577, 33638);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 33476, 33650);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 33476, 33650);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundCall Call(BoundExpression? receiver, MethodSymbol method, BoundExpression arg0)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 33662, 33848);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 33778, 33837);

                return f_10440_33785_33836(this, receiver, method, f_10440_33808_33835(arg0));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 33662, 33848);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10440_33808_33835(Microsoft.CodeAnalysis.CSharp.BoundExpression
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 33808, 33835);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10440_33785_33836(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                args)
                {
                    var return_v = this_param.Call(receiver, method, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 33785, 33836);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 33662, 33848);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 33662, 33848);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundCall Call(BoundExpression? receiver, MethodSymbol method, BoundExpression arg0, BoundExpression arg1)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 33860, 34074);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 33998, 34063);

                return f_10440_34005_34062(this, receiver, method, f_10440_34028_34061(arg0, arg1));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 33860, 34074);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10440_34028_34061(Microsoft.CodeAnalysis.CSharp.BoundExpression
                item1, Microsoft.CodeAnalysis.CSharp.BoundExpression
                item2)
                {
                    var return_v = ImmutableArray.Create(item1, item2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 34028, 34061);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10440_34005_34062(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                args)
                {
                    var return_v = this_param.Call(receiver, method, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 34005, 34062);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 33860, 34074);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 33860, 34074);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundCall Call(BoundExpression? receiver, MethodSymbol method, params BoundExpression[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 34086, 34298);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 34211, 34287);

                return f_10440_34218_34286(this, receiver, method, f_10440_34241_34285(args));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 34086, 34298);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10440_34241_34285(params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                items)
                {
                    var return_v = ImmutableArray.Create<BoundExpression>(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 34241, 34285);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10440_34218_34286(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                args)
                {
                    var return_v = this_param.Call(receiver, method, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 34218, 34286);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 34086, 34298);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 34086, 34298);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundCall Call(BoundExpression? receiver, WellKnownMember method, BoundExpression arg0)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 34418, 34489);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 34421, 34489);
                return f_10440_34421_34489(this, receiver, f_10440_34436_34459(this, method), f_10440_34461_34488(arg0)); DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 34418, 34489);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 34418, 34489);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 34418, 34489);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
            f_10440_34436_34459(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
            this_param, Microsoft.CodeAnalysis.WellKnownMember
            wm)
            {
                var return_v = this_param.WellKnownMethod(wm);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 34436, 34459);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
            f_10440_34461_34488(Microsoft.CodeAnalysis.CSharp.BoundExpression
            item)
            {
                var return_v = ImmutableArray.Create(item);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 34461, 34488);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.BoundCall
            f_10440_34421_34489(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
            this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
            receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
            method, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
            args)
            {
                var return_v = this_param.Call(receiver, method, args);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 34421, 34489);
                return return_v;
            }

        }

        public BoundCall Call(BoundExpression? receiver, MethodSymbol method, ImmutableArray<BoundExpression> args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 34502, 35256);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 34634, 34685);

                f_10440_34634_34684(f_10440_34647_34668(method) == args.Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 34701, 35245);

                return new BoundCall(
                f_10440_34740_34746(), receiver, method, args,
                                argumentNamesOpt: default(ImmutableArray<String>), argumentRefKindsOpt: f_10440_34861_34885(method), isDelegateCall: false, expanded: false,
                                invokedAsExtensionMethod: false, argsToParamsOpt: default(ImmutableArray<int>), defaultArguments: default(BitVector), resultKind: LookupResultKind.Viable,
                                type: f_10440_35122_35139(method), hasErrors: f_10440_35152_35177(method) is ErrorMethodSymbol)
                { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10440, 34708, 35244) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 34502, 35256);

                int
                f_10440_34647_34668(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 34647, 34668);
                    return return_v;
                }


                int
                f_10440_34634_34684(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 34634, 34684);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10440_34740_34746()
                {
                    var return_v = Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 34740, 34746);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                f_10440_34861_34885(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterRefKinds;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 34861, 34885);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10440_35122_35139(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 35122, 35139);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10440_35152_35177(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 35152, 35177);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 34502, 35256);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 34502, 35256);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundCall Call(BoundExpression? receiver, MethodSymbol method, ImmutableArray<RefKind> refKinds, ImmutableArray<BoundExpression> args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 35268, 35959);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 35434, 35485);

                f_10440_35434_35484(f_10440_35447_35468(method) == args.Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 35499, 35948);

                return new BoundCall(
                f_10440_35538_35544(), receiver, method, args,
                                argumentNamesOpt: default(ImmutableArray<String>), argumentRefKindsOpt: refKinds, isDelegateCall: false, expanded: false, invokedAsExtensionMethod: false,
                                argsToParamsOpt: ImmutableArray<int>.Empty, defaultArguments: default(BitVector), resultKind: LookupResultKind.Viable, type: f_10440_35884_35901(method))
                { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10440, 35506, 35947) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 35268, 35959);

                int
                f_10440_35447_35468(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 35447, 35468);
                    return return_v;
                }


                int
                f_10440_35434_35484(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 35434, 35484);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10440_35538_35544()
                {
                    var return_v = Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 35538, 35544);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10440_35884_35901(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 35884, 35901);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 35268, 35959);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 35268, 35959);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundExpression Conditional(BoundExpression condition, BoundExpression consequence, BoundExpression alternative, TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 35971, 36322);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 36132, 36311);

                return new BoundConditionalOperator(f_10440_36168_36174(), false, condition, consequence, alternative, constantValueOpt: null, type, wasTargetTyped: false, type) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10440, 36139, 36310) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 35971, 36322);

                Microsoft.CodeAnalysis.SyntaxNode
                f_10440_36168_36174()
                {
                    var return_v = Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 36168, 36174);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 35971, 36322);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 35971, 36322);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundExpression ComplexConditionalReceiver(BoundExpression valueTypeReceiver, BoundExpression referenceTypeReceiver)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 36334, 36835);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 36482, 36526);

                f_10440_36482_36525(f_10440_36495_36517(valueTypeReceiver) is { });
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 36540, 36661);

                f_10440_36540_36660(f_10440_36553_36659(f_10440_36571_36593(valueTypeReceiver), f_10440_36595_36621(referenceTypeReceiver), TypeCompareKind.ConsiderEverything2));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 36675, 36824);

                return new BoundComplexConditionalReceiver(f_10440_36718_36724(), valueTypeReceiver, referenceTypeReceiver, f_10440_36768_36790(valueTypeReceiver)) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10440, 36682, 36823) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 36334, 36835);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10440_36495_36517(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 36495, 36517);
                    return return_v;
                }


                int
                f_10440_36482_36525(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 36482, 36525);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10440_36571_36593(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 36571, 36593);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10440_36595_36621(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 36595, 36621);
                    return return_v;
                }


                bool
                f_10440_36553_36659(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 36553, 36659);
                    return return_v;
                }


                int
                f_10440_36540_36660(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 36540, 36660);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10440_36718_36724()
                {
                    var return_v = Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 36718, 36724);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10440_36768_36790(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 36768, 36790);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 36334, 36835);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 36334, 36835);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundExpression Coalesce(BoundExpression left, BoundExpression right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 36847, 37397);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 36948, 37144);

                f_10440_36948_37143(f_10440_36961_37115(left.Type!, f_10440_36979_36989(right), TypeCompareKind.IgnoreCustomModifiersAndArraySizesAndLowerBounds | TypeCompareKind.IgnoreNullableModifiersForReferenceTypes) || (DynAbs.Tracing.TraceSender.Expression_False(10440, 36961, 37142) || f_10440_37119_37142(f_10440_37119_37128(left))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 37158, 37198);

                f_10440_37158_37197(f_10440_37171_37196(f_10440_37171_37180(left)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 37214, 37386);

                return new BoundNullCoalescingOperator(f_10440_37253_37259(), left, right, Conversion.Identity, BoundNullCoalescingOperatorResultKind.LeftType, f_10440_37343_37352(left)) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10440, 37221, 37385) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 36847, 37397);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10440_36979_36989(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 36979, 36989);
                    return return_v;
                }


                bool
                f_10440_36961_37115(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals(t2, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 36961, 37115);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10440_37119_37128(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 37119, 37128);
                    return return_v;
                }


                bool
                f_10440_37119_37142(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 37119, 37142);
                    return return_v;
                }


                int
                f_10440_36948_37143(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 36948, 37143);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10440_37171_37180(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 37171, 37180);
                    return return_v;
                }


                bool
                f_10440_37171_37196(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsReferenceType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 37171, 37196);
                    return return_v;
                }


                int
                f_10440_37158_37197(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 37158, 37197);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10440_37253_37259()
                {
                    var return_v = Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 37253, 37259);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10440_37343_37352(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 37343, 37352);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 36847, 37397);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 36847, 37397);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundStatement If(BoundExpression condition, BoundStatement thenClause, BoundStatement? elseClauseOpt = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 37409, 37644);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 37550, 37633);

                return f_10440_37557_37632(this, condition, ImmutableArray<LocalSymbol>.Empty, thenClause, elseClauseOpt);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 37409, 37644);

                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10440_37557_37632(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                condition, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, Microsoft.CodeAnalysis.CSharp.BoundStatement
                thenClause, Microsoft.CodeAnalysis.CSharp.BoundStatement?
                elseClauseOpt)
                {
                    var return_v = this_param.If(condition, locals, thenClause, elseClauseOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 37557, 37632);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 37409, 37644);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 37409, 37644);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundStatement ConditionalGoto(BoundExpression condition, LabelSymbol label, bool jumpIfTrue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 37656, 37894);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 37781, 37883);

                return new BoundConditionalGoto(f_10440_37813_37819(), condition, jumpIfTrue, label) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10440, 37788, 37882) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 37656, 37894);

                Microsoft.CodeAnalysis.SyntaxNode
                f_10440_37813_37819()
                {
                    var return_v = Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 37813, 37819);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 37656, 37894);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 37656, 37894);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundStatement If(BoundExpression condition, ImmutableArray<LocalSymbol> locals, BoundStatement thenClause, BoundStatement? elseClauseOpt = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 37906, 39842);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 38464, 38497);

                f_10440_38464_38496(thenClause != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 38513, 38573);

                var
                statements = f_10440_38530_38572()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 38587, 38637);

                var
                afterif = f_10440_38601_38636("afterif")
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 38653, 39724) || true) && (elseClauseOpt != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10440, 38653, 39724);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 38712, 38762);

                    var
                    alt = f_10440_38722_38761("alternative")
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 38782, 38837);

                    f_10440_38782_38836(
                                    statements, f_10440_38797_38835(this, condition, alt, false));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 38855, 38882);

                    f_10440_38855_38881(statements, thenClause);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 38900, 38930);

                    f_10440_38900_38929(statements, f_10440_38915_38928(this, afterif));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 38948, 39187) || true) && (f_10440_38952_38976_M(!locals.IsDefaultOrEmpty))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10440, 38948, 39187);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 39018, 39079);

                        var
                        firstPart = f_10440_39034_39078(this, locals, f_10440_39053_39077(statements))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 39101, 39120);

                        f_10440_39101_39119(statements);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 39142, 39168);

                        f_10440_39142_39167(statements, firstPart);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10440, 38948, 39187);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 39207, 39234);

                    f_10440_39207_39233(
                                    statements, f_10440_39222_39232(this, alt));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 39252, 39282);

                    f_10440_39252_39281(statements, elseClauseOpt);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10440, 38653, 39724);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10440, 38653, 39724);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 39348, 39407);

                    f_10440_39348_39406(statements, f_10440_39363_39405(this, condition, afterif, false));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 39425, 39452);

                    f_10440_39425_39451(statements, thenClause);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 39470, 39709) || true) && (f_10440_39474_39498_M(!locals.IsDefaultOrEmpty))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10440, 39470, 39709);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 39540, 39601);

                        var
                        firstPart = f_10440_39556_39600(this, locals, f_10440_39575_39599(statements))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 39623, 39642);

                        f_10440_39623_39641(statements);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 39664, 39690);

                        f_10440_39664_39689(statements, firstPart);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10440, 39470, 39709);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10440, 38653, 39724);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 39740, 39771);

                f_10440_39740_39770(
                            statements, f_10440_39755_39769(this, afterif));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 39785, 39831);

                return f_10440_39792_39830(this, f_10440_39798_39829(statements));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 37906, 39842);

                int
                f_10440_38464_38496(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 38464, 38496);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10440_38530_38572()
                {
                    var return_v = ArrayBuilder<BoundStatement>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 38530, 38572);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                f_10440_38601_38636(string
                name)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 38601, 38636);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                f_10440_38722_38761(string
                name)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 38722, 38761);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10440_38797_38835(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                condition, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                label, bool
                jumpIfTrue)
                {
                    var return_v = this_param.ConditionalGoto(condition, (Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)label, jumpIfTrue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 38797, 38835);
                    return return_v;
                }


                int
                f_10440_38782_38836(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 38782, 38836);
                    return 0;
                }


                int
                f_10440_38855_38881(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 38855, 38881);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
                f_10440_38915_38928(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                label)
                {
                    var return_v = this_param.Goto((Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 38915, 38928);
                    return return_v;
                }


                int
                f_10440_38900_38929(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 38900, 38929);
                    return 0;
                }


                bool
                f_10440_38952_38976_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 38952, 38976);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10440_39053_39077(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 39053, 39077);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10440_39034_39078(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                statements)
                {
                    var return_v = this_param.Block(locals, statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 39034, 39078);
                    return return_v;
                }


                int
                f_10440_39101_39119(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 39101, 39119);
                    return 0;
                }


                int
                f_10440_39142_39167(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 39142, 39167);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
                f_10440_39222_39232(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                label)
                {
                    var return_v = this_param.Label((Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 39222, 39232);
                    return return_v;
                }


                int
                f_10440_39207_39233(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 39207, 39233);
                    return 0;
                }


                int
                f_10440_39252_39281(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 39252, 39281);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10440_39363_39405(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                condition, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                label, bool
                jumpIfTrue)
                {
                    var return_v = this_param.ConditionalGoto(condition, (Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)label, jumpIfTrue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 39363, 39405);
                    return return_v;
                }


                int
                f_10440_39348_39406(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 39348, 39406);
                    return 0;
                }


                int
                f_10440_39425_39451(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 39425, 39451);
                    return 0;
                }


                bool
                f_10440_39474_39498_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 39474, 39498);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10440_39575_39599(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 39575, 39599);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10440_39556_39600(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                statements)
                {
                    var return_v = this_param.Block(locals, statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 39556, 39600);
                    return return_v;
                }


                int
                f_10440_39623_39641(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 39623, 39641);
                    return 0;
                }


                int
                f_10440_39664_39689(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 39664, 39689);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
                f_10440_39755_39769(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                label)
                {
                    var return_v = this_param.Label((Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 39755, 39769);
                    return return_v;
                }


                int
                f_10440_39740_39770(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 39740, 39770);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10440_39798_39829(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 39798, 39829);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10440_39792_39830(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                statements)
                {
                    var return_v = this_param.Block(statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 39792, 39830);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 37906, 39842);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 37906, 39842);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundThrowStatement Throw(BoundExpression e)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 39854, 40015);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 39930, 40004);

                return new BoundThrowStatement(f_10440_39961_39967(), e) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10440, 39937, 40003) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 39854, 40015);

                Microsoft.CodeAnalysis.SyntaxNode
                f_10440_39961_39967()
                {
                    var return_v = Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 39961, 39967);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 39854, 40015);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 39854, 40015);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundLocal Local(LocalSymbol local)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 40027, 40192);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 40094, 40181);

                return new BoundLocal(f_10440_40116_40122(), local, null, f_10440_40137_40147(local)) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10440, 40101, 40180) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 40027, 40192);

                Microsoft.CodeAnalysis.SyntaxNode
                f_10440_40116_40122()
                {
                    var return_v = Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 40116, 40122);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10440_40137_40147(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 40137, 40147);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 40027, 40192);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 40027, 40192);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundExpression MakeSequence(LocalSymbol temp, params BoundExpression[] parts)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 40204, 40394);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 40314, 40383);

                return f_10440_40321_40382(this, f_10440_40334_40374(temp), parts);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 40204, 40394);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10440_40334_40374(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                item)
                {
                    var return_v = ImmutableArray.Create<LocalSymbol>(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 40334, 40374);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10440_40321_40382(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                parts)
                {
                    var return_v = this_param.MakeSequence(locals, parts);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 40321, 40382);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 40204, 40394);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 40204, 40394);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundExpression MakeSequence(params BoundExpression[] parts)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 40406, 40571);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 40498, 40560);

                return f_10440_40505_40559(this, ImmutableArray<LocalSymbol>.Empty, parts);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 40406, 40571);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10440_40505_40559(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                parts)
                {
                    var return_v = this_param.MakeSequence(locals, parts);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 40505, 40559);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 40406, 40571);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 40406, 40571);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundExpression MakeSequence(ImmutableArray<LocalSymbol> locals, params BoundExpression[] parts)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 40583, 41362);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 40711, 40769);

                var
                builder = f_10440_40725_40768()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 40792, 40797);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 40783, 41037) || true) && (i < f_10440_40803_40815(parts) - 1)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 40821, 40824)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10440, 40783, 41037))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10440, 40783, 41037);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 40858, 40878);

                        var
                        part = parts[i]
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 40896, 41022) || true) && (f_10440_40900_40939(part))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10440, 40896, 41022);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 40981, 41003);

                            f_10440_40981_41002(builder, parts[i]);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10440, 40896, 41022);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10440, 1, 255);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10440, 1, 255);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 41051, 41096);

                var
                lastExpression = parts[f_10440_41078_41090(parts) - 1]
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 41112, 41265) || true) && (locals.IsDefaultOrEmpty && (DynAbs.Tracing.TraceSender.Expression_True(10440, 41116, 41161) && f_10440_41143_41156(builder) == 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10440, 41112, 41265);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 41195, 41210);

                    f_10440_41195_41209(builder);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 41228, 41250);

                    return lastExpression;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10440, 41112, 41265);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 41281, 41351);

                return f_10440_41288_41350(this, locals, f_10440_41305_41333(builder), lastExpression);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 40583, 41362);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10440_40725_40768()
                {
                    var return_v = ArrayBuilder<BoundExpression>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 40725, 40768);
                    return return_v;
                }


                int
                f_10440_40803_40815(Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 40803, 40815);
                    return return_v;
                }


                bool
                f_10440_40900_40939(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression)
                {
                    var return_v = LocalRewriter.ReadIsSideeffecting(expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 40900, 40939);
                    return return_v;
                }


                int
                f_10440_40981_41002(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 40981, 41002);
                    return 0;
                }


                int
                f_10440_41078_41090(Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 41078, 41090);
                    return return_v;
                }


                int
                f_10440_41143_41156(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 41143, 41156);
                    return return_v;
                }


                int
                f_10440_41195_41209(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 41195, 41209);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10440_41305_41333(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 41305, 41333);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10440_41288_41350(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                sideEffects, Microsoft.CodeAnalysis.CSharp.BoundExpression
                result)
                {
                    var return_v = this_param.Sequence(locals, sideEffects, result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 41288, 41350);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 40583, 41362);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 40583, 41362);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundSequence Sequence(BoundExpression[] sideEffects, BoundExpression result, TypeSymbol? type = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 41374, 41770);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 41508, 41541);

                f_10440_41508_41540(f_10440_41521_41532(result) is { });
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 41555, 41592);

                var
                resultType = type ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?>(10440, 41572, 41591) ?? f_10440_41580_41591(result))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 41606, 41759);

                return new BoundSequence(f_10440_41631_41637(), ImmutableArray<LocalSymbol>.Empty, f_10440_41674_41705(sideEffects), result, resultType) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10440, 41613, 41758) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 41374, 41770);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10440_41521_41532(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 41521, 41532);
                    return return_v;
                }


                int
                f_10440_41508_41540(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 41508, 41540);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10440_41580_41591(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 41580, 41591);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10440_41631_41637()
                {
                    var return_v = Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 41631, 41637);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10440_41674_41705(Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                items)
                {
                    var return_v = items.AsImmutableOrNull<Microsoft.CodeAnalysis.CSharp.BoundExpression>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 41674, 41705);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 41374, 41770);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 41374, 41770);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundExpression Sequence(ImmutableArray<LocalSymbol> locals, ImmutableArray<BoundExpression> sideEffects, BoundExpression result)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 41782, 42226);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 41943, 41976);

                f_10440_41943_41975(f_10440_41956_41967(result) is { });
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 41990, 42215);

                return
                (DynAbs.Tracing.TraceSender.Conditional_F1(10440, 42014, 42069) || ((locals.IsDefaultOrEmpty && (DynAbs.Tracing.TraceSender.Expression_True(10440, 42014, 42069) && sideEffects.IsDefaultOrEmpty
                ) && DynAbs.Tracing.TraceSender.Conditional_F2(10440, 42089, 42095)) || DynAbs.Tracing.TraceSender.Conditional_F3(10440, 42115, 42214))) ? result
                : new BoundSequence(f_10440_42133_42139(), locals, sideEffects, result, f_10440_42170_42181(result)) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10440, 42115, 42214) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 41782, 42226);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10440_41956_41967(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 41956, 41967);
                    return return_v;
                }


                int
                f_10440_41943_41975(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 41943, 41975);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10440_42133_42139()
                {
                    var return_v = Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 42133, 42139);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10440_42170_42181(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 42170, 42181);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 41782, 42226);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 41782, 42226);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundSpillSequence SpillSequence(ImmutableArray<LocalSymbol> locals, ImmutableArray<BoundStatement> sideEffects, BoundExpression result)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 42238, 42576);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 42406, 42439);

                f_10440_42406_42438(f_10440_42419_42430(result) is { });
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 42453, 42565);

                return new BoundSpillSequence(f_10440_42483_42489(), locals, sideEffects, result, f_10440_42520_42531(result)) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10440, 42460, 42564) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 42238, 42576);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10440_42419_42430(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 42419, 42430);
                    return return_v;
                }


                int
                f_10440_42406_42438(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 42406, 42438);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10440_42483_42489()
                {
                    var return_v = Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 42483, 42489);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10440_42520_42531(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 42520, 42531);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 42238, 42576);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 42238, 42576);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        internal class SyntheticSwitchSection
        {
            public readonly ImmutableArray<int> Values;

            public readonly ImmutableArray<BoundStatement> Statements;

            public SyntheticSwitchSection(ImmutableArray<int> Values, ImmutableArray<BoundStatement> Statements)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10440, 42897, 43113);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 43030, 43051);

                    this.Values = Values;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 43069, 43098);

                    this.Statements = Statements;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10440, 42897, 43113);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 42897, 43113);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 42897, 43113);
                }
            }

            static SyntheticSwitchSection()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10440, 42706, 43124);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10440, 42706, 43124);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 42706, 43124);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10440, 42706, 43124);
        }

        public SyntheticSwitchSection SwitchSection(int value, params BoundStatement[] statements)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 43136, 43361);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 43251, 43350);

                return f_10440_43258_43349(f_10440_43285_43313(value), f_10440_43315_43348(statements));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 43136, 43361);

                System.Collections.Immutable.ImmutableArray<int>
                f_10440_43285_43313(int
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 43285, 43313);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10440_43315_43348(params Microsoft.CodeAnalysis.CSharp.BoundStatement[]
                items)
                {
                    var return_v = ImmutableArray.Create(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 43315, 43348);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory.SyntheticSwitchSection
                f_10440_43258_43349(System.Collections.Immutable.ImmutableArray<int>
                Values, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                Statements)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory.SyntheticSwitchSection(Values, Statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 43258, 43349);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 43136, 43361);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 43136, 43361);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SyntheticSwitchSection SwitchSection(List<int> values, params BoundStatement[] statements)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 43373, 43611);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 43495, 43600);

                return f_10440_43502_43599(f_10440_43529_43563(values), f_10440_43565_43598(statements));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 43373, 43611);

                System.Collections.Immutable.ImmutableArray<int>
                f_10440_43529_43563(System.Collections.Generic.List<int>
                items)
                {
                    var return_v = ImmutableArray.CreateRange((System.Collections.Generic.IEnumerable<int>)items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 43529, 43563);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10440_43565_43598(params Microsoft.CodeAnalysis.CSharp.BoundStatement[]
                items)
                {
                    var return_v = ImmutableArray.Create(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 43565, 43598);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory.SyntheticSwitchSection
                f_10440_43502_43599(System.Collections.Immutable.ImmutableArray<int>
                Values, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                Statements)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory.SyntheticSwitchSection(Values, Statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 43502, 43599);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 43373, 43611);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 43373, 43611);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundStatement Switch(BoundExpression ex, ImmutableArray<SyntheticSwitchSection> sections)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 43706, 45203);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 43828, 43908);

                f_10440_43828_43907(f_10440_43841_43848(ex) is { SpecialType: CodeAnalysis.SpecialType.System_Int32 });

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 43924, 44028) || true) && (sections.Length == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10440, 43924, 44028);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 43982, 44013);

                    return f_10440_43989_44012(this, ex);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10440, 43924, 44028);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 44044, 44074);

                f_10440_44044_44073(sections);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 44088, 44156);

                GeneratedLabelSymbol
                breakLabel = f_10440_44122_44155("break")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 44170, 44257);

                var
                caseBuilder = f_10440_44188_44256()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 44271, 44331);

                var
                statements = f_10440_44288_44330()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 44345, 44367);

                f_10440_44345_44366(statements, null!);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 44430, 44882);
                    foreach (var section in f_10440_44454_44462_I(sections))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10440, 44430, 44882);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 44496, 44577);

                        LabelSymbol
                        sectionLabel = f_10440_44523_44576("case " + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (section.Values[0]).ToString(), 10440, 44558, 44575))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 44595, 44631);

                        f_10440_44595_44630(statements, f_10440_44610_44629(this, sectionLabel));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 44649, 44689);

                        f_10440_44649_44688(statements, section.Statements);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 44709, 44867);
                            foreach (var value in f_10440_44731_44745_I(section.Values))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10440, 44709, 44867);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 44787, 44848);

                                f_10440_44787_44847(caseBuilder, (f_10440_44804_44831(value), sectionLabel));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10440, 44709, 44867);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10440, 1, 159);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10440, 1, 159);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10440, 44430, 44882);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10440, 1, 453);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10440, 1, 453);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 44898, 44932);

                f_10440_44898_44931(
                            statements, f_10440_44913_44930(this, breakLabel));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 44946, 44982);

                f_10440_44946_44981(f_10440_44959_44972(statements, 0) is null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 44996, 45132);

                statements[0] = new BoundSwitchDispatch(f_10440_45036_45042(), ex, f_10440_45048_45080(caseBuilder), breakLabel, null) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10440, 45012, 45131) };
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 45146, 45192);

                return f_10440_45153_45191(this, f_10440_45159_45190(statements));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 43706, 45203);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10440_43841_43848(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 43841, 43848);
                    return return_v;
                }


                int
                f_10440_43828_43907(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 43828, 43907);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10440_43989_44012(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr)
                {
                    var return_v = this_param.ExpressionStatement(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 43989, 44012);
                    return return_v;
                }


                int
                f_10440_44044_44073(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory.SyntheticSwitchSection>
                sections)
                {
                    CheckSwitchSections(sections);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 44044, 44073);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                f_10440_44122_44155(string
                name)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 44122, 44155);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.ConstantValue Value, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol label)>
                f_10440_44188_44256()
                {
                    var return_v = ArrayBuilder<(ConstantValue Value, LabelSymbol label)>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 44188, 44256);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10440_44288_44330()
                {
                    var return_v = ArrayBuilder<BoundStatement>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 44288, 44330);
                    return return_v;
                }


                int
                f_10440_44345_44366(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 44345, 44366);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                f_10440_44523_44576(string
                name)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 44523, 44576);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
                f_10440_44610_44629(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                label)
                {
                    var return_v = this_param.Label(label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 44610, 44629);
                    return return_v;
                }


                int
                f_10440_44595_44630(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 44595, 44630);
                    return 0;
                }


                int
                f_10440_44649_44688(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 44649, 44688);
                    return 0;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10440_44804_44831(int
                value)
                {
                    var return_v = ConstantValue.Create(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 44804, 44831);
                    return return_v;
                }


                int
                f_10440_44787_44847(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.ConstantValue Value, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol label)>
                this_param, (Microsoft.CodeAnalysis.ConstantValue, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol sectionLabel)
                item)
                {
                    this_param.Add(((Microsoft.CodeAnalysis.ConstantValue Value, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol label))item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 44787, 44847);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<int>
                f_10440_44731_44745_I(System.Collections.Immutable.ImmutableArray<int>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 44731, 44745);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory.SyntheticSwitchSection>
                f_10440_44454_44462_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory.SyntheticSwitchSection>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 44454, 44462);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
                f_10440_44913_44930(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                label)
                {
                    var return_v = this_param.Label((Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 44913, 44930);
                    return return_v;
                }


                int
                f_10440_44898_44931(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 44898, 44931);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10440_44959_44972(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 44959, 44972);
                    return return_v;
                }


                int
                f_10440_44946_44981(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 44946, 44981);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10440_45036_45042()
                {
                    var return_v = Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 45036, 45042);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<(Microsoft.CodeAnalysis.ConstantValue Value, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol label)>
                f_10440_45048_45080(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.ConstantValue Value, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol label)>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 45048, 45080);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10440_45159_45190(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 45159, 45190);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10440_45153_45191(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                statements)
                {
                    var return_v = this_param.Block(statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 45153, 45191);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 43706, 45203);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 43706, 45203);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [Conditional("DEBUG")]
        private static void CheckSwitchSections(ImmutableArray<SyntheticSwitchSection> sections)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10440, 45398, 45835);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 45543, 45575);

                var
                labels = f_10440_45556_45574()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 45589, 45824);
                    foreach (var s in f_10440_45607_45615_I(sections))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10440, 45589, 45824);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 45649, 45809);
                            foreach (var v2 in f_10440_45668_45676_I(s.Values))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10440, 45649, 45809);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 45718, 45753);

                                f_10440_45718_45752(!f_10440_45732_45751(labels, v2));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 45775, 45790);

                                f_10440_45775_45789(labels, v2);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10440, 45649, 45809);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10440, 1, 161);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10440, 1, 161);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10440, 45589, 45824);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10440, 1, 236);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10440, 1, 236);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10440, 45398, 45835);

                System.Collections.Generic.HashSet<int>
                f_10440_45556_45574()
                {
                    var return_v = new System.Collections.Generic.HashSet<int>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 45556, 45574);
                    return return_v;
                }


                bool
                f_10440_45732_45751(System.Collections.Generic.HashSet<int>
                this_param, int
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 45732, 45751);
                    return return_v;
                }


                int
                f_10440_45718_45752(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 45718, 45752);
                    return 0;
                }


                bool
                f_10440_45775_45789(System.Collections.Generic.HashSet<int>
                this_param, int
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 45775, 45789);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<int>
                f_10440_45668_45676_I(System.Collections.Immutable.ImmutableArray<int>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 45668, 45676);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory.SyntheticSwitchSection>
                f_10440_45607_45615_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory.SyntheticSwitchSection>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 45607, 45615);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 45398, 45835);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 45398, 45835);
            }
        }

        public BoundGotoStatement Goto(LabelSymbol label)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 45847, 46009);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 45921, 45998);

                return new BoundGotoStatement(f_10440_45951_45957(), label) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10440, 45928, 45997) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 45847, 46009);

                Microsoft.CodeAnalysis.SyntaxNode
                f_10440_45951_45957()
                {
                    var return_v = Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 45951, 45957);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 45847, 46009);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 45847, 46009);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundLabelStatement Label(LabelSymbol label)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 46021, 46186);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 46097, 46175);

                return new BoundLabelStatement(f_10440_46128_46134(), label) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10440, 46104, 46174) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 46021, 46186);

                Microsoft.CodeAnalysis.SyntaxNode
                f_10440_46128_46134()
                {
                    var return_v = Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 46128, 46134);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 46021, 46186);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 46021, 46186);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundLiteral Literal(Boolean value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 46198, 46433);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 46265, 46422);

                return new BoundLiteral(f_10440_46289_46295(), f_10440_46297_46324(value), f_10440_46326_46388(this, Microsoft.CodeAnalysis.SpecialType.System_Boolean)) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10440, 46272, 46421) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 46198, 46433);

                Microsoft.CodeAnalysis.SyntaxNode
                f_10440_46289_46295()
                {
                    var return_v = Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 46289, 46295);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10440_46297_46324(bool
                value)
                {
                    var return_v = ConstantValue.Create(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 46297, 46324);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10440_46326_46388(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.SpecialType
                st)
                {
                    var return_v = this_param.SpecialType(st);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 46326, 46388);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 46198, 46433);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 46198, 46433);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundLiteral Literal(string? value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 46445, 46617);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 46512, 46558);

                var
                stringConst = f_10440_46530_46557(value)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 46572, 46606);

                return f_10440_46579_46605(this, stringConst);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 46445, 46617);

                Microsoft.CodeAnalysis.ConstantValue
                f_10440_46530_46557(string?
                value)
                {
                    var return_v = ConstantValue.Create(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 46530, 46557);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLiteral
                f_10440_46579_46605(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.ConstantValue
                stringConst)
                {
                    var return_v = this_param.StringLiteral(stringConst);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 46579, 46605);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 46445, 46617);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 46445, 46617);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundLiteral StringLiteral(ConstantValue stringConst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 46629, 46936);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 46714, 46771);

                f_10440_46714_46770(f_10440_46727_46747(stringConst) || (DynAbs.Tracing.TraceSender.Expression_False(10440, 46727, 46769) || f_10440_46751_46769(stringConst)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 46785, 46925);

                return new BoundLiteral(f_10440_46809_46815(), stringConst, f_10440_46830_46891(this, Microsoft.CodeAnalysis.SpecialType.System_String)) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10440, 46792, 46924) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 46629, 46936);

                bool
                f_10440_46727_46747(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.IsString;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 46727, 46747);
                    return return_v;
                }


                bool
                f_10440_46751_46769(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.IsNull;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 46751, 46769);
                    return return_v;
                }


                int
                f_10440_46714_46770(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 46714, 46770);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10440_46809_46815()
                {
                    var return_v = Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 46809, 46815);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10440_46830_46891(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.SpecialType
                st)
                {
                    var return_v = this_param.SpecialType(st);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 46830, 46891);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 46629, 46936);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 46629, 46936);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundLiteral StringLiteral(String stringValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 46948, 47093);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 47026, 47082);

                return f_10440_47033_47081(this, f_10440_47047_47080(stringValue));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 46948, 47093);

                Microsoft.CodeAnalysis.ConstantValue
                f_10440_47047_47080(string
                value)
                {
                    var return_v = ConstantValue.Create(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 47047, 47080);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLiteral
                f_10440_47033_47081(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.ConstantValue
                stringConst)
                {
                    var return_v = this_param.StringLiteral(stringConst);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 47033, 47081);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 46948, 47093);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 46948, 47093);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundArrayLength ArrayLength(BoundExpression array)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 47105, 47375);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 47188, 47245);

                f_10440_47188_47244(f_10440_47201_47211(array) is { TypeKind: TypeKind.Array });
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 47259, 47364);

                return f_10440_47266_47363(f_10440_47287_47293(), array, f_10440_47302_47362(this, Microsoft.CodeAnalysis.SpecialType.System_Int32));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 47105, 47375);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10440_47201_47211(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 47201, 47211);
                    return return_v;
                }


                int
                f_10440_47188_47244(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 47188, 47244);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10440_47287_47293()
                {
                    var return_v = Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 47287, 47293);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10440_47302_47362(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.SpecialType
                st)
                {
                    var return_v = this_param.SpecialType(st);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 47302, 47362);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundArrayLength
                f_10440_47266_47363(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundArrayLength(syntax, expression, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 47266, 47363);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 47105, 47375);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 47105, 47375);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundArrayAccess ArrayAccessFirstElement(BoundExpression array)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 47387, 47820);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 47482, 47539);

                f_10440_47482_47538(f_10440_47495_47505(array) is { TypeKind: TypeKind.Array });
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 47553, 47599);

                int
                rank = f_10440_47564_47598(((ArrayTypeSymbol)f_10440_47582_47592(array)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 47613, 47748);

                ImmutableArray<BoundExpression>
                firstElementIndices = f_10440_47667_47747(f_10440_47667_47726(rank, f_10440_47715_47725(this, 0)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 47762, 47809);

                return f_10440_47769_47808(this, array, firstElementIndices);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 47387, 47820);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10440_47495_47505(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 47495, 47505);
                    return return_v;
                }


                int
                f_10440_47482_47538(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 47482, 47538);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10440_47582_47592(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 47582, 47592);
                    return return_v;
                }


                int
                f_10440_47564_47598(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param)
                {
                    var return_v = this_param.Rank;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 47564, 47598);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLiteral
                f_10440_47715_47725(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, int
                value)
                {
                    var return_v = this_param.Literal(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 47715, 47725);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10440_47667_47726(int
                capacity, Microsoft.CodeAnalysis.CSharp.BoundLiteral
                fillWithValue)
                {
                    var return_v = ArrayBuilder<BoundExpression>.GetInstance(capacity, (Microsoft.CodeAnalysis.CSharp.BoundExpression)fillWithValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 47667, 47726);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10440_47667_47747(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 47667, 47747);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundArrayAccess
                f_10440_47769_47808(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                array, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                indices)
                {
                    var return_v = this_param.ArrayAccess(array, indices);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 47769, 47808);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 47387, 47820);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 47387, 47820);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundArrayAccess ArrayAccess(BoundExpression array, params BoundExpression[] indices)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 47832, 48015);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 47949, 48004);

                return f_10440_47956_48003(this, array, f_10440_47975_48002(indices));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 47832, 48015);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10440_47975_48002(Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                items)
                {
                    var return_v = items.AsImmutableOrNull<Microsoft.CodeAnalysis.CSharp.BoundExpression>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 47975, 48002);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundArrayAccess
                f_10440_47956_48003(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                array, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                indices)
                {
                    var return_v = this_param.ArrayAccess(array, indices);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 47956, 48003);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 47832, 48015);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 47832, 48015);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundArrayAccess ArrayAccess(BoundExpression array, ImmutableArray<BoundExpression> indices)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 48027, 48328);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 48151, 48208);

                f_10440_48151_48207(f_10440_48164_48174(array) is { TypeKind: TypeKind.Array });
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 48222, 48317);

                return f_10440_48229_48316(f_10440_48250_48256(), array, indices, f_10440_48274_48315(((ArrayTypeSymbol)f_10440_48292_48302(array))));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 48027, 48328);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10440_48164_48174(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 48164, 48174);
                    return return_v;
                }


                int
                f_10440_48151_48207(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 48151, 48207);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10440_48250_48256()
                {
                    var return_v = Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 48250, 48256);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10440_48292_48302(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 48292, 48302);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10440_48274_48315(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param)
                {
                    var return_v = this_param.ElementType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 48274, 48315);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundArrayAccess
                f_10440_48229_48316(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                indices, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundArrayAccess(syntax, expression, indices, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 48229, 48316);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 48027, 48328);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 48027, 48328);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundStatement BaseInitialization()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 48340, 48833);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 48472, 48509);

                f_10440_48472_48508(f_10440_48485_48500() is { });
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 48523, 48614);

                NamedTypeSymbol
                baseType = f_10440_48550_48613(f_10440_48550_48584(f_10440_48550_48579(f_10440_48550_48565())))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 48628, 48704);

                var
                ctor = baseType.InstanceConstructors.Single(c => c.ParameterCount == 0)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 48718, 48822);

                return new BoundExpressionStatement(f_10440_48754_48760(), f_10440_48762_48788(this, f_10440_48767_48781(this, baseType), ctor)) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10440, 48725, 48821) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 48340, 48833);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10440_48485_48500()
                {
                    var return_v = CurrentFunction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 48485, 48500);
                    return return_v;
                }


                int
                f_10440_48472_48508(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 48472, 48508);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10440_48550_48565()
                {
                    var return_v = CurrentFunction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 48550, 48565);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10440_48550_48579(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ThisParameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 48550, 48579);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10440_48550_48584(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 48550, 48584);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10440_48550_48613(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.BaseTypeNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 48550, 48613);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10440_48754_48760()
                {
                    var return_v = Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 48754, 48760);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBaseReference
                f_10440_48767_48781(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                baseType)
                {
                    var return_v = this_param.Base(baseType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 48767, 48781);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10440_48762_48788(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBaseReference
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = this_param.Call((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 48762, 48788);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 48340, 48833);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 48340, 48833);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundStatement SequencePoint(SyntaxNode syntax, BoundStatement statement)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 48845, 49010);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 48950, 48999);

                return f_10440_48957_48998(syntax, statement);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 48845, 49010);

                Microsoft.CodeAnalysis.CSharp.BoundSequencePoint
                f_10440_48957_48998(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundStatement
                statementOpt)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundSequencePoint(syntax, statementOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 48957, 48998);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 48845, 49010);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 48845, 49010);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundStatement SequencePointWithSpan(CSharpSyntaxNode syntax, TextSpan span, BoundStatement statement)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 49022, 49230);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 49156, 49219);

                return f_10440_49163_49218(syntax, statement, span);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 49022, 49230);

                Microsoft.CodeAnalysis.CSharp.BoundSequencePointWithSpan
                f_10440_49163_49218(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundStatement
                statementOpt, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundSequencePointWithSpan((Microsoft.CodeAnalysis.SyntaxNode)syntax, statementOpt, span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 49163, 49218);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 49022, 49230);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 49022, 49230);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundStatement HiddenSequencePoint(BoundStatement? statementOpt = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 49242, 49409);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 49345, 49398);

                return f_10440_49352_49397(statementOpt);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 49242, 49409);

                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10440_49352_49397(Microsoft.CodeAnalysis.CSharp.BoundStatement?
                statementOpt)
                {
                    var return_v = BoundSequencePoint.CreateHidden(statementOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 49352, 49397);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 49242, 49409);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 49242, 49409);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundStatement ThrowNull()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 49421, 49594);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 49479, 49583);

                return f_10440_49486_49582(this, f_10440_49492_49581(this, f_10440_49497_49580(f_10440_49497_49508(), Microsoft.CodeAnalysis.WellKnownType.System_Exception)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 49421, 49594);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10440_49497_49508()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 49497, 49508);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10440_49497_49580(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownType
                type)
                {
                    var return_v = this_param.GetWellKnownType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 49497, 49580);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10440_49492_49581(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = this_param.Null((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 49492, 49581);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundThrowStatement
                f_10440_49486_49582(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                e)
                {
                    var return_v = this_param.Throw(e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 49486, 49582);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 49421, 49594);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 49421, 49594);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundExpression ThrowExpression(BoundExpression thrown, TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 49606, 49814);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 49710, 49803);

                return new BoundThrowExpression(thrown.Syntax, thrown, type) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10440, 49717, 49802) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 49606, 49814);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 49606, 49814);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 49606, 49814);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundExpression Null(TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 49826, 49932);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 49895, 49921);

                return f_10440_49902_49920(type, f_10440_49913_49919());
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 49826, 49932);

                Microsoft.CodeAnalysis.SyntaxNode
                f_10440_49913_49919()
                {
                    var return_v = Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 49913, 49919);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10440_49902_49920(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    var return_v = Null(type, syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 49902, 49920);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 49826, 49932);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 49826, 49932);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static BoundExpression Null(TypeSymbol type, SyntaxNode syntax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10440, 49944, 50416);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 50039, 50078);

                f_10440_50039_50077(f_10440_50052_50076(type));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 50092, 50205);

                BoundExpression
                nullLiteral = new BoundLiteral(syntax, f_10440_50147_50165(), type) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10440, 50122, 50204) }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 50219, 50405);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10440, 50226, 50259) || ((f_10440_50226_50259(type) && DynAbs.Tracing.TraceSender.Conditional_F2(10440, 50279, 50373)) || DynAbs.Tracing.TraceSender.Conditional_F3(10440, 50393, 50404))) ? f_10440_50279_50373(syntax, nullLiteral, Conversion.NullToPointer, type) : nullLiteral;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10440, 49944, 50416);

                bool
                f_10440_50052_50076(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.CanBeAssignedNull();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 50052, 50076);
                    return return_v;
                }


                int
                f_10440_50039_50077(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 50039, 50077);
                    return 0;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10440_50147_50165()
                {
                    var return_v = ConstantValue.Null;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 50147, 50165);
                    return return_v;
                }


                bool
                f_10440_50226_50259(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsPointerOrFunctionPointer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 50226, 50259);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundConversion
                f_10440_50279_50373(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                operand, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = BoundConversion.SynthesizedNonUserDefined(syntax, operand, conversion, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 50279, 50373);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 49944, 50416);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 49944, 50416);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundTypeExpression Type(TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 50428, 50595);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 50501, 50584);

                return new BoundTypeExpression(f_10440_50532_50538(), null, type) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10440, 50508, 50583) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 50428, 50595);

                Microsoft.CodeAnalysis.SyntaxNode
                f_10440_50532_50538()
                {
                    var return_v = Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 50532, 50538);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 50428, 50595);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 50428, 50595);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundExpression Typeof(WellKnownType type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 50607, 50727);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 50681, 50716);

                return f_10440_50688_50715(this, f_10440_50695_50714(this, type));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 50607, 50727);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10440_50695_50714(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.WellKnownType
                wt)
                {
                    var return_v = this_param.WellKnownType(wt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 50695, 50714);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10440_50688_50715(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = this_param.Typeof((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 50688, 50715);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 50607, 50727);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 50607, 50727);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundExpression Typeof(TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 50739, 51119);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 50810, 51108);

                return new BoundTypeOfOperator(
                f_10440_50859_50865(),
                f_10440_50884_50894(this, type),
                f_10440_50913_50989(this, CodeAnalysis.WellKnownMember.System_Type__GetTypeFromHandle),
                f_10440_51008_51061(this, CodeAnalysis.WellKnownType.System_Type))
                { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10440, 50817, 51107) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 50739, 51119);

                Microsoft.CodeAnalysis.SyntaxNode
                f_10440_50859_50865()
                {
                    var return_v = Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 50859, 50865);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
                f_10440_50884_50894(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Type(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 50884, 50894);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10440_50913_50989(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                wm)
                {
                    var return_v = this_param.WellKnownMethod(wm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 50913, 50989);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10440_51008_51061(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.WellKnownType
                wt)
                {
                    var return_v = this_param.WellKnownType(wt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 51008, 51061);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 50739, 51119);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 50739, 51119);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundExpression Typeof(TypeWithAnnotations type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 51131, 51247);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 51211, 51236);

                return f_10440_51218_51235(this, type.Type);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 51131, 51247);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10440_51218_51235(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Typeof(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 51218, 51235);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 51131, 51247);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 51131, 51247);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public ImmutableArray<BoundExpression> TypeOfs(ImmutableArray<TypeWithAnnotations> typeArguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 51259, 51435);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 51381, 51424);

                return typeArguments.SelectAsArray(Typeof);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 51259, 51435);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 51259, 51435);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 51259, 51435);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundExpression TypeofDynamicOperationContextType()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 51447, 51696);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 51530, 51606);

                f_10440_51530_51605(f_10440_51543_51564(this) is { DynamicOperationContextType: { } });
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 51620, 51685);

                return f_10440_51627_51684(this, f_10440_51634_51683(f_10440_51634_51655(this)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 51447, 51696);

                Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                f_10440_51543_51564(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.CompilationState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 51543, 51564);
                    return return_v;
                }


                int
                f_10440_51530_51605(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 51530, 51605);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                f_10440_51634_51655(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.CompilationState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 51634, 51655);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10440_51634_51683(Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                this_param)
                {
                    var return_v = this_param.DynamicOperationContextType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 51634, 51683);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10440_51627_51684(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = this_param.Typeof((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 51627, 51684);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 51447, 51696);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 51447, 51696);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundExpression Sizeof(TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 51708, 51967);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 51779, 51956);

                return new BoundSizeOfOperator(f_10440_51810_51816(), f_10440_51818_51828(this, type), f_10440_51830_51860(type), f_10440_51862_51922(this, Microsoft.CodeAnalysis.SpecialType.System_Int32)) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10440, 51786, 51955) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 51708, 51967);

                Microsoft.CodeAnalysis.SyntaxNode
                f_10440_51810_51816()
                {
                    var return_v = Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 51810, 51816);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
                f_10440_51818_51828(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Type(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 51818, 51828);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10440_51830_51860(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = Binder.GetConstantSizeOf(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 51830, 51860);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10440_51862_51922(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.SpecialType
                st)
                {
                    var return_v = this_param.SpecialType(st);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 51862, 51922);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 51708, 51967);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 51708, 51967);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal BoundExpression ConstructorInfo(MethodSymbol ctor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 51979, 52364);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 52063, 52353);

                return new BoundMethodInfo(
                f_10440_52108_52114(),
                                ctor,
                f_10440_52156_52202(this, f_10440_52182_52201(ctor)),
                f_10440_52221_52306(this, Microsoft.CodeAnalysis.WellKnownType.System_Reflection_ConstructorInfo))
                { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10440, 52070, 52352) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 51979, 52364);

                Microsoft.CodeAnalysis.SyntaxNode
                f_10440_52108_52114()
                {
                    var return_v = Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 52108, 52114);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10440_52182_52201(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 52182, 52201);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10440_52156_52202(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                methodContainer)
                {
                    var return_v = this_param.GetMethodFromHandleMethod(methodContainer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 52156, 52202);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10440_52221_52306(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.WellKnownType
                wt)
                {
                    var return_v = this_param.WellKnownType(wt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 52221, 52306);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 51979, 52364);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 51979, 52364);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundExpression MethodDefIndex(MethodSymbol method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 52376, 52676);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 52459, 52665);

                return new BoundMethodDefIndex(
                f_10440_52508_52514(),
                                method,
                f_10440_52558_52618(this, Microsoft.CodeAnalysis.SpecialType.System_Int32))
                { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10440, 52466, 52664) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 52376, 52676);

                Microsoft.CodeAnalysis.SyntaxNode
                f_10440_52508_52514()
                {
                    var return_v = Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 52508, 52514);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10440_52558_52618(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.SpecialType
                st)
                {
                    var return_v = this_param.SpecialType(st);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 52558, 52618);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 52376, 52676);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 52376, 52676);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundExpression ModuleVersionId()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 52852, 53065);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 52917, 53054);

                return new BoundModuleVersionId(f_10440_52949_52955(), f_10440_52957_53020(this, Microsoft.CodeAnalysis.WellKnownType.System_Guid)) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10440, 52924, 53053) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 52852, 53065);

                Microsoft.CodeAnalysis.SyntaxNode
                f_10440_52949_52955()
                {
                    var return_v = Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 52949, 52955);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10440_52957_53020(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.WellKnownType
                wt)
                {
                    var return_v = this_param.WellKnownType(wt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 52957, 53020);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 52852, 53065);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 52852, 53065);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundExpression ModuleVersionIdString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 53077, 53300);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 53148, 53289);

                return new BoundModuleVersionIdString(f_10440_53186_53192(), f_10440_53194_53255(this, Microsoft.CodeAnalysis.SpecialType.System_String)) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10440, 53155, 53288) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 53077, 53300);

                Microsoft.CodeAnalysis.SyntaxNode
                f_10440_53186_53192()
                {
                    var return_v = Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 53186, 53192);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10440_53194_53255(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.SpecialType
                st)
                {
                    var return_v = this_param.SpecialType(st);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 53194, 53255);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 53077, 53300);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 53077, 53300);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundExpression InstrumentationPayloadRoot(int analysisKind, TypeSymbol payloadType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 53312, 53549);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 53428, 53538);

                return new BoundInstrumentationPayloadRoot(f_10440_53471_53477(), analysisKind, payloadType) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10440, 53435, 53537) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 53312, 53549);

                Microsoft.CodeAnalysis.SyntaxNode
                f_10440_53471_53477()
                {
                    var return_v = Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 53471, 53477);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 53312, 53549);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 53312, 53549);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundExpression MaximumMethodDefIndex()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 53561, 53831);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 53632, 53820);

                return new BoundMaximumMethodDefIndex(
                f_10440_53688_53694(),
                f_10440_53713_53773(this, Microsoft.CodeAnalysis.SpecialType.System_Int32))
                { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10440, 53639, 53819) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 53561, 53831);

                Microsoft.CodeAnalysis.SyntaxNode
                f_10440_53688_53694()
                {
                    var return_v = Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 53688, 53694);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10440_53713_53773(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.SpecialType
                st)
                {
                    var return_v = this_param.SpecialType(st);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 53713, 53773);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 53561, 53831);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 53561, 53831);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundExpression SourceDocumentIndex(Cci.DebugSourceDocument document)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 54018, 54343);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 54119, 54332);

                return new BoundSourceDocumentIndex(
                f_10440_54173_54179(),
                                document,
                f_10440_54225_54285(this, Microsoft.CodeAnalysis.SpecialType.System_Int32))
                { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10440, 54126, 54331) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 54018, 54343);

                Microsoft.CodeAnalysis.SyntaxNode
                f_10440_54173_54179()
                {
                    var return_v = Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 54173, 54179);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10440_54225_54285(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.SpecialType
                st)
                {
                    var return_v = this_param.SpecialType(st);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 54225, 54285);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 54018, 54343);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 54018, 54343);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundExpression MethodInfo(MethodSymbol method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 54355, 55406);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 54804, 55090) || true) && (f_10440_54808_54842_M(!f_10440_54809_54830(method).IsValueType) || (DynAbs.Tracing.TraceSender.Expression_False(10440, 54808, 54932) || !f_10440_54847_54932(method)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10440, 54804, 55090);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 54966, 55075);

                    method = f_10440_54975_55074(method, f_10440_55018_55044(f_10440_55018_55039(this)), requireSameReturnType: true);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10440, 54804, 55090);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 55106, 55395);

                return new BoundMethodInfo(
                f_10440_55151_55157(),
                                method,
                f_10440_55201_55249(this, f_10440_55227_55248(method)),
                f_10440_55268_55348(this, Microsoft.CodeAnalysis.WellKnownType.System_Reflection_MethodInfo))
                { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10440, 55113, 55394) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 54355, 55406);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10440_54809_54830(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 54809, 54830);
                    return return_v;
                }


                bool
                f_10440_54808_54842_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 54808, 54842);
                    return return_v;
                }


                bool
                f_10440_54847_54932(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator.MayUseCallForStructMethod(method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 54847, 54932);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                f_10440_55018_55039(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.CompilationState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 55018, 55039);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10440_55018_55044(Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 55018, 55044);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10440_54975_55074(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                accessingTypeOpt, bool
                requireSameReturnType)
                {
                    var return_v = this_param.GetConstructedLeastOverriddenMethod(accessingTypeOpt, requireSameReturnType: requireSameReturnType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 54975, 55074);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10440_55151_55157()
                {
                    var return_v = Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 55151, 55157);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10440_55227_55248(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 55227, 55248);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10440_55201_55249(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                methodContainer)
                {
                    var return_v = this_param.GetMethodFromHandleMethod(methodContainer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 55201, 55249);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10440_55268_55348(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.WellKnownType
                wt)
                {
                    var return_v = this_param.WellKnownType(wt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 55268, 55348);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 54355, 55406);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 54355, 55406);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundExpression FieldInfo(FieldSymbol field)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 55418, 55789);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 55494, 55778);

                return new BoundFieldInfo(
                f_10440_55538_55544(),
                                field,
                f_10440_55587_55633(this, f_10440_55612_55632(field)),
                f_10440_55652_55731(this, Microsoft.CodeAnalysis.WellKnownType.System_Reflection_FieldInfo))
                { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10440, 55501, 55777) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 55418, 55789);

                Microsoft.CodeAnalysis.SyntaxNode
                f_10440_55538_55544()
                {
                    var return_v = Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 55538, 55544);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10440_55612_55632(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 55612, 55632);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10440_55587_55633(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                fieldContainer)
                {
                    var return_v = this_param.GetFieldFromHandleMethod(fieldContainer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 55587, 55633);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10440_55652_55731(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.WellKnownType
                wt)
                {
                    var return_v = this_param.WellKnownType(wt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 55652, 55731);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 55418, 55789);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 55418, 55789);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private MethodSymbol GetMethodFromHandleMethod(NamedTypeSymbol methodContainer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 55801, 56237);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 55905, 56226);

                return f_10440_55912_56225(this, (DynAbs.Tracing.TraceSender.Conditional_F1(10440, 55946, 56027) || (((f_10440_55947_55985(methodContainer) == 0 && (DynAbs.Tracing.TraceSender.Expression_True(10440, 55947, 56026) && f_10440_55994_56026_M(!methodContainer.IsAnonymousType))) && DynAbs.Tracing.TraceSender.Conditional_F2(10440, 56047, 56125)) || DynAbs.Tracing.TraceSender.Conditional_F3(10440, 56145, 56224))) ? CodeAnalysis.WellKnownMember.System_Reflection_MethodBase__GetMethodFromHandle : CodeAnalysis.WellKnownMember.System_Reflection_MethodBase__GetMethodFromHandle2);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 55801, 56237);

                int
                f_10440_55947_55985(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.AllTypeArgumentCount();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 55947, 55985);
                    return return_v;
                }


                bool
                f_10440_55994_56026_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 55994, 56026);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10440_55912_56225(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                wm)
                {
                    var return_v = this_param.WellKnownMethod(wm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 55912, 56225);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 55801, 56237);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 55801, 56237);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private MethodSymbol GetFieldFromHandleMethod(NamedTypeSymbol fieldContainer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 56249, 56642);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 56351, 56631);

                return f_10440_56358_56630(this, (DynAbs.Tracing.TraceSender.Conditional_F1(10440, 56392, 56436) || (((f_10440_56393_56430(fieldContainer) == 0) && DynAbs.Tracing.TraceSender.Conditional_F2(10440, 56456, 56532)) || DynAbs.Tracing.TraceSender.Conditional_F3(10440, 56552, 56629))) ? CodeAnalysis.WellKnownMember.System_Reflection_FieldInfo__GetFieldFromHandle : CodeAnalysis.WellKnownMember.System_Reflection_FieldInfo__GetFieldFromHandle2);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 56249, 56642);

                int
                f_10440_56393_56430(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.AllTypeArgumentCount();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 56393, 56430);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10440_56358_56630(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                wm)
                {
                    var return_v = this_param.WellKnownMethod(wm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 56358, 56630);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 56249, 56642);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 56249, 56642);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundExpression Convert(TypeSymbol type, BoundExpression arg)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 56654, 57443);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 56747, 56881) || true) && (f_10440_56751_56821(type, f_10440_56775_56783(arg), TypeCompareKind.ConsiderEverything2))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10440, 56747, 56881);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 56855, 56866);

                    return arg;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10440, 56747, 56881);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 56897, 56948);

                HashSet<DiagnosticInfo>?
                useSiteDiagnostics = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 56962, 57069);

                Conversion
                c = f_10440_56977_57068(f_10440_56977_57000(f_10440_56977_56988()), arg, type, ref useSiteDiagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 57083, 57106);

                f_10440_57083_57105(c.Exists);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 57120, 57169);

                f_10440_57120_57168(f_10440_57133_57167(useSiteDiagnostics));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 57280, 57387);

                f_10440_57280_57386(c.Method is null, "Why are we synthesizing a user-defined conversion after initial binding?");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 57403, 57432);

                return f_10440_57410_57431(this, type, arg, c);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 56654, 57443);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10440_56775_56783(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 56775, 56783);
                    return return_v;
                }


                bool
                f_10440_56751_56821(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 56751, 56821);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10440_56977_56988()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 56977, 56988);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversions
                f_10440_56977_57000(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Conversions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 56977, 57000);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10440_56977_57068(Microsoft.CodeAnalysis.CSharp.Conversions
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                sourceExpression, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = this_param.ClassifyConversionFromExpression(sourceExpression, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 56977, 57068);
                    return return_v;
                }


                int
                f_10440_57083_57105(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 57083, 57105);
                    return 0;
                }


                bool
                f_10440_57133_57167(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                hashSet)
                {
                    var return_v = hashSet.IsNullOrEmpty<Microsoft.CodeAnalysis.DiagnosticInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 57133, 57167);
                    return return_v;
                }


                int
                f_10440_57120_57168(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 57120, 57168);
                    return 0;
                }


                int
                f_10440_57280_57386(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 57280, 57386);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10440_57410_57431(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.BoundExpression
                arg, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion)
                {
                    var return_v = this_param.Convert(type, arg, conversion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 57410, 57431);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 56654, 57443);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 56654, 57443);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundExpression Convert(TypeSymbol type, BoundExpression arg, Conversion conversion, bool isChecked = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 57455, 59058);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 57829, 58070) || true) && (conversion.Method is { } && (DynAbs.Tracing.TraceSender.Expression_True(10440, 57833, 57964) && !f_10440_57862_57964(f_10440_57880_57916(f_10440_57880_57908(conversion.Method)[0]), f_10440_57918_57926(arg), TypeCompareKind.ConsiderEverything2)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10440, 57829, 58070);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 57998, 58055);

                    arg = f_10440_58004_58054(this, f_10440_58012_58048(f_10440_58012_58040(conversion.Method)[0]), arg);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10440, 57829, 58070);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 58086, 58231) || true) && (conversion.Kind == ConversionKind.ImplicitReference && (DynAbs.Tracing.TraceSender.Expression_True(10440, 58090, 58164) && f_10440_58145_58164(arg)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10440, 58086, 58231);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 58198, 58216);

                    return f_10440_58205_58215(this, type);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10440, 58086, 58231);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 58247, 58277);

                f_10440_58247_58276(f_10440_58260_58268(arg) is { });

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 58291, 58862) || true) && (conversion.Kind == ConversionKind.ExplicitNullable && (DynAbs.Tracing.TraceSender.Expression_True(10440, 58295, 58391) && f_10440_58366_58391(f_10440_58366_58374(arg))) && (DynAbs.Tracing.TraceSender.Expression_True(10440, 58295, 58495) && f_10440_58412_58495(f_10440_58412_58448(f_10440_58412_58420(arg)), type, TypeCompareKind.AllIgnoreOptions)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10440, 58291, 58862);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 58713, 58847);

                    return f_10440_58720_58846(this, arg, f_10440_58735_58845(f_10440_58735_58809(this, CodeAnalysis.SpecialMember.System_Nullable_T_get_Value), f_10440_58836_58844(arg)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10440, 58291, 58862);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 58878, 59047);

                return new BoundConversion(f_10440_58905_58911(), arg, conversion, @checked: isChecked, explicitCastInCode: true, conversionGroupOpt: null, null, type) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10440, 58885, 59046) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 57455, 59058);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10440_57880_57908(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 57880, 57908);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10440_57880_57916(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 57880, 57916);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10440_57918_57926(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 57918, 57926);
                    return return_v;
                }


                bool
                f_10440_57862_57964(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 57862, 57964);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10440_58012_58040(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 58012, 58040);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10440_58012_58048(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 58012, 58048);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10440_58004_58054(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.BoundExpression
                arg)
                {
                    var return_v = this_param.Convert(type, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 58004, 58054);
                    return return_v;
                }


                bool
                f_10440_58145_58164(Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = node.IsLiteralNull();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 58145, 58164);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10440_58205_58215(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Null(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 58205, 58215);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10440_58260_58268(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 58260, 58268);
                    return return_v;
                }


                int
                f_10440_58247_58276(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 58247, 58276);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10440_58366_58374(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 58366, 58374);
                    return return_v;
                }


                bool
                f_10440_58366_58391(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 58366, 58391);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10440_58412_58420(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 58412, 58420);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10440_58412_58448(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.GetNullableUnderlyingType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 58412, 58448);
                    return return_v;
                }


                bool
                f_10440_58412_58495(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals(t2, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 58412, 58495);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10440_58735_58809(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.SpecialMember
                sm)
                {
                    var return_v = this_param.SpecialMethod(sm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 58735, 58809);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10440_58836_58844(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 58836, 58844);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10440_58735_58845(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                newOwner)
                {
                    var return_v = this_param.AsMember((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)newOwner);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 58735, 58845);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10440_58720_58846(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = this_param.Call(receiver, method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 58720, 58846);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10440_58905_58911()
                {
                    var return_v = Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 58905, 58911);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 57455, 59058);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 57455, 59058);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundExpression ArrayOrEmpty(TypeSymbol elementType, BoundExpression[] elements)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 59070, 59250);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 59182, 59239);

                return f_10440_59189_59238(this, elementType, f_10440_59215_59237(elements));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 59070, 59250);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10440_59215_59237(Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                items)
                {
                    var return_v = items.AsImmutable<Microsoft.CodeAnalysis.CSharp.BoundExpression>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 59215, 59237);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10440_59189_59238(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                elementType, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                elements)
                {
                    var return_v = this_param.ArrayOrEmpty(elementType, elements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 59189, 59238);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 59070, 59250);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 59070, 59250);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundExpression ArrayOrEmpty(TypeSymbol elementType, ImmutableArray<BoundExpression> elements)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 59793, 60388);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 59919, 60325) || true) && (elements.Length == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10440, 59919, 60325);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 59977, 60088);

                    MethodSymbol?
                    arrayEmpty = f_10440_60004_60087(this, CodeAnalysis.WellKnownMember.System_Array__Empty, isOptional: true)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 60106, 60310) || true) && (arrayEmpty is { })
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10440, 60106, 60310);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 60169, 60239);

                        arrayEmpty = f_10440_60182_60238(arrayEmpty, f_10440_60203_60237(elementType));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 60261, 60291);

                        return f_10440_60268_60290(this, null, arrayEmpty);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10440, 60106, 60310);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10440, 59919, 60325);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 60341, 60377);

                return f_10440_60348_60376(this, elementType, elements);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 59793, 60388);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10440_60004_60087(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                wm, bool
                isOptional)
                {
                    var return_v = this_param.WellKnownMethod(wm, isOptional: isOptional);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 60004, 60087);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                f_10440_60203_60237(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 60203, 60237);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10440_60182_60238(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                typeArguments)
                {
                    var return_v = this_param.Construct(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 60182, 60238);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10440_60268_60290(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = this_param.Call(receiver, method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 60268, 60290);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10440_60348_60376(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                elementType, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                elements)
                {
                    var return_v = this_param.Array(elementType, elements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 60348, 60376);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 59793, 60388);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 59793, 60388);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundExpression Array(TypeSymbol elementType, ImmutableArray<BoundExpression> elements)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 60400, 60831);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 60519, 60820);

                return f_10440_60526_60819(f_10440_60567_60573(), f_10440_60592_60656(f_10440_60631_60655(this, elements.Length)), new BoundArrayInitialization(f_10440_60704_60710(), elements) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10440, 60675, 60753) }, f_10440_60772_60818(f_10440_60772_60783(), elementType));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 60400, 60831);

                Microsoft.CodeAnalysis.SyntaxNode
                f_10440_60567_60573()
                {
                    var return_v = Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 60567, 60573);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLiteral
                f_10440_60631_60655(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, int
                value)
                {
                    var return_v = this_param.Literal(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 60631, 60655);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10440_60592_60656(Microsoft.CodeAnalysis.CSharp.BoundLiteral
                item)
                {
                    var return_v = ImmutableArray.Create<BoundExpression>((Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 60592, 60656);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10440_60704_60710()
                {
                    var return_v = Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 60704, 60710);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10440_60772_60783()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 60772, 60783);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                f_10440_60772_60818(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                elementType)
                {
                    var return_v = this_param.CreateArrayTypeSymbol(elementType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 60772, 60818);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundArrayCreation
                f_10440_60526_60819(Microsoft.CodeAnalysis.SyntaxNode
                syntax, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                bounds, Microsoft.CodeAnalysis.CSharp.BoundArrayInitialization
                initializerOpt, Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundArrayCreation(syntax, bounds, initializerOpt, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 60526, 60819);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 60400, 60831);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 60400, 60831);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundExpression Array(TypeSymbol elementType, BoundExpression length)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 60843, 61205);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 60944, 61194);

                return new BoundArrayCreation(
                f_10440_60991_60997(),
                f_10440_61015_61061(length),
                               null,
                f_10440_61101_61147(f_10440_61101_61112(), elementType))
                { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10440, 60951, 61193) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 60843, 61205);

                Microsoft.CodeAnalysis.SyntaxNode
                f_10440_60991_60997()
                {
                    var return_v = Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 60991, 60997);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10440_61015_61061(Microsoft.CodeAnalysis.CSharp.BoundExpression
                item)
                {
                    var return_v = ImmutableArray.Create<BoundExpression>(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 61015, 61061);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10440_61101_61112()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 61101, 61112);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                f_10440_61101_61147(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                elementType)
                {
                    var return_v = this_param.CreateArrayTypeSymbol(elementType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 61101, 61147);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 60843, 61205);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 60843, 61205);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal BoundExpression Default(TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 61217, 61331);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 61291, 61320);

                return f_10440_61298_61319(type, f_10440_61312_61318());
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 61217, 61331);

                Microsoft.CodeAnalysis.SyntaxNode
                f_10440_61312_61318()
                {
                    var return_v = Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 61312, 61318);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10440_61298_61319(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    var return_v = Default(type, syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 61298, 61319);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 61217, 61331);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 61217, 61331);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static BoundExpression Default(TypeSymbol type, SyntaxNode syntax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10440, 61343, 61534);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 61443, 61523);

                return new BoundDefaultExpression(syntax, type) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10440, 61450, 61522) };
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10440, 61343, 61534);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 61343, 61534);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 61343, 61534);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal BoundStatement Try(
                    BoundBlock tryBlock,
                    ImmutableArray<BoundCatchBlock> catchBlocks,
                    BoundBlock? finallyBlock = null,
                    LabelSymbol? finallyLabel = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 61546, 61915);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 61784, 61904);

                return new BoundTryStatement(f_10440_61813_61819(), tryBlock, catchBlocks, finallyBlock, finallyLabel) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10440, 61791, 61903) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 61546, 61915);

                Microsoft.CodeAnalysis.SyntaxNode
                f_10440_61813_61819()
                {
                    var return_v = Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 61813, 61819);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 61546, 61915);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 61546, 61915);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal ImmutableArray<BoundCatchBlock> CatchBlocks(
                    params BoundCatchBlock[] catchBlocks)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 61927, 62106);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 62056, 62095);

                return f_10440_62063_62094(catchBlocks);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 61927, 62106);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundCatchBlock>
                f_10440_62063_62094(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock[]
                items)
                {
                    var return_v = items.AsImmutableOrNull<Microsoft.CodeAnalysis.CSharp.BoundCatchBlock>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 62063, 62094);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 61927, 62106);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 61927, 62106);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal BoundCatchBlock Catch(
                    LocalSymbol local,
                    BoundBlock block)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 62118, 62482);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 62237, 62263);

                var
                source = f_10440_62250_62262(this, local)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 62277, 62471);

                return f_10440_62284_62470(f_10440_62304_62310(), f_10440_62312_62340(local), source, f_10440_62350_62361(source), exceptionFilterPrologueOpt: null, exceptionFilterOpt: null, body: block, isSynthesizedAsyncCatchAll: false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 62118, 62482);

                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10440_62250_62262(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 62250, 62262);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10440_62304_62310()
                {
                    var return_v = Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 62304, 62310);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10440_62312_62340(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 62312, 62340);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10440_62350_62361(Microsoft.CodeAnalysis.CSharp.BoundLocal
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 62350, 62361);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                f_10440_62284_62470(Microsoft.CodeAnalysis.SyntaxNode
                syntax, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, Microsoft.CodeAnalysis.CSharp.BoundLocal
                exceptionSourceOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                exceptionTypeOpt, Microsoft.CodeAnalysis.CSharp.BoundStatementList?
                exceptionFilterPrologueOpt, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                exceptionFilterOpt, Microsoft.CodeAnalysis.CSharp.BoundBlock
                body, bool
                isSynthesizedAsyncCatchAll)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundCatchBlock(syntax, locals, (Microsoft.CodeAnalysis.CSharp.BoundExpression)exceptionSourceOpt, exceptionTypeOpt, exceptionFilterPrologueOpt: exceptionFilterPrologueOpt, exceptionFilterOpt: exceptionFilterOpt, body: body, isSynthesizedAsyncCatchAll: isSynthesizedAsyncCatchAll);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 62284, 62470);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 62118, 62482);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 62118, 62482);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal BoundCatchBlock Catch(
                    BoundExpression source,
                    BoundBlock block)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 62494, 62828);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 62618, 62817);

                return f_10440_62625_62816(f_10440_62645_62651(), ImmutableArray<LocalSymbol>.Empty, source, f_10440_62696_62707(source), exceptionFilterPrologueOpt: null, exceptionFilterOpt: null, body: block, isSynthesizedAsyncCatchAll: false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 62494, 62828);

                Microsoft.CodeAnalysis.SyntaxNode
                f_10440_62645_62651()
                {
                    var return_v = Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 62645, 62651);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10440_62696_62707(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 62696, 62707);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                f_10440_62625_62816(Microsoft.CodeAnalysis.SyntaxNode
                syntax, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, Microsoft.CodeAnalysis.CSharp.BoundExpression
                exceptionSourceOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                exceptionTypeOpt, Microsoft.CodeAnalysis.CSharp.BoundStatementList?
                exceptionFilterPrologueOpt, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                exceptionFilterOpt, Microsoft.CodeAnalysis.CSharp.BoundBlock
                body, bool
                isSynthesizedAsyncCatchAll)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundCatchBlock(syntax, locals, exceptionSourceOpt, exceptionTypeOpt, exceptionFilterPrologueOpt: exceptionFilterPrologueOpt, exceptionFilterOpt: exceptionFilterOpt, body: body, isSynthesizedAsyncCatchAll: isSynthesizedAsyncCatchAll);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 62625, 62816);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 62494, 62828);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 62494, 62828);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal BoundTryStatement Fault(BoundBlock tryBlock, BoundBlock faultBlock)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 62840, 63099);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 62941, 63088);

                return f_10440_62948_63087(f_10440_62970_62976(), tryBlock, ImmutableArray<BoundCatchBlock>.Empty, faultBlock, finallyLabelOpt: null, preferFaultHandler: true);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 62840, 63099);

                Microsoft.CodeAnalysis.SyntaxNode
                f_10440_62970_62976()
                {
                    var return_v = Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 62970, 62976);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundTryStatement
                f_10440_62948_63087(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundBlock
                tryBlock, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundCatchBlock>
                catchBlocks, Microsoft.CodeAnalysis.CSharp.BoundBlock
                finallyBlockOpt, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol?
                finallyLabelOpt, bool
                preferFaultHandler)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundTryStatement(syntax, tryBlock, catchBlocks, finallyBlockOpt, finallyLabelOpt: finallyLabelOpt, preferFaultHandler: preferFaultHandler);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 62948, 63087);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 62840, 63099);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 62840, 63099);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal BoundExpression NullOrDefault(TypeSymbol typeSymbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 63111, 63254);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 63197, 63243);

                return f_10440_63204_63242(typeSymbol, f_10440_63230_63241(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 63111, 63254);

                Microsoft.CodeAnalysis.SyntaxNode
                f_10440_63230_63241(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 63230, 63241);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10440_63204_63242(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                typeSymbol, Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    var return_v = NullOrDefault(typeSymbol, syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 63204, 63242);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 63111, 63254);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 63111, 63254);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static BoundExpression NullOrDefault(TypeSymbol typeSymbol, SyntaxNode syntax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10440, 63266, 63480);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 63378, 63469);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10440, 63385, 63411) || ((f_10440_63385_63411(typeSymbol) && DynAbs.Tracing.TraceSender.Conditional_F2(10440, 63414, 63438)) || DynAbs.Tracing.TraceSender.Conditional_F3(10440, 63441, 63468))) ? f_10440_63414_63438(typeSymbol, syntax) : f_10440_63441_63468(typeSymbol, syntax);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10440, 63266, 63480);

                bool
                f_10440_63385_63411(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsReferenceType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 63385, 63411);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10440_63414_63438(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    var return_v = Null(type, syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 63414, 63438);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10440_63441_63468(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    var return_v = Default(type, syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 63441, 63468);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 63266, 63480);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 63266, 63480);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal BoundExpression Not(BoundExpression expression)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 63492, 63847);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 63573, 63668);

                f_10440_63573_63667(expression is { Type: { SpecialType: CodeAnalysis.SpecialType.System_Boolean } });
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 63682, 63836);

                return f_10440_63689_63835(expression.Syntax, UnaryOperatorKind.BoolLogicalNegation, expression, null, null, LookupResultKind.Viable, f_10440_63819_63834(expression));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 63492, 63847);

                int
                f_10440_63573_63667(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 63573, 63667);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10440_63819_63834(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 63819, 63834);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundUnaryOperator
                f_10440_63689_63835(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
                operatorKind, Microsoft.CodeAnalysis.CSharp.BoundExpression
                operand, Microsoft.CodeAnalysis.ConstantValue?
                constantValueOpt, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                methodOpt, Microsoft.CodeAnalysis.CSharp.LookupResultKind
                resultKind, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundUnaryOperator(syntax, operatorKind, operand, constantValueOpt, methodOpt, resultKind, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 63689, 63835);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 63492, 63847);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 63492, 63847);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundLocal StoreToTemp(
                    BoundExpression argument,
                    out BoundAssignmentOperator store,
                    RefKind refKind = RefKind.None,
                    SynthesizedLocalKind kind = SynthesizedLocalKind.LoweringTemp,
                    SyntaxNode? syntaxOpt = null
                    , [CallerLineNumber] int callerLineNumber = 0
                    , [CallerFilePath] string? callerFilePath = null
                    )
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 64049, 66693);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 64509, 64544);

                f_10440_64509_64543(f_10440_64522_64535(argument) is { });
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 64558, 64612);

                MethodSymbol?
                containingMethod = f_10440_64591_64611(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 64626, 64664);

                f_10440_64626_64663(containingMethod is { });
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 64680, 65804);

                switch (refKind)
                {

                    case RefKind.Out:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10440, 64680, 65804);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 64768, 64790);

                        refKind = RefKind.Ref;
                        DynAbs.Tracing.TraceSender.TraceBreak(10440, 64812, 64818);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10440, 64680, 65804);

                    case RefKind.In:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10440, 64680, 65804);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 64876, 65514) || true) && (!f_10440_64881_65175(argument, Binder.AddressKind.ReadOnly, containingMethod, f_10440_65076_65111(f_10440_65076_65087()), stackLocalsOpt: null))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10440, 64876, 65514);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 65392, 65442);

                            f_10440_65392_65441(f_10440_65405_65426(argument) != RefKind.In);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 65468, 65491);

                            refKind = RefKind.None;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10440, 64876, 65514);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10440, 65536, 65542);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10440, 64680, 65804);

                    case RefKindExtensions.StrictIn:
                    case RefKind.None:
                    case RefKind.Ref:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10440, 64680, 65804);
                        DynAbs.Tracing.TraceSender.TraceBreak(10440, 65685, 65691);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10440, 64680, 65804);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10440, 64680, 65804);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 65739, 65789);

                        throw f_10440_65745_65788(refKind);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10440, 64680, 65804);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 65820, 65849);

                var
                syntax = argument.Syntax
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 65863, 65888);

                var
                type = f_10440_65874_65887(argument)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 65904, 66459);

                var
                local = f_10440_65916_66458(syntax, f_10440_65974_66411(containingMethod, TypeWithAnnotations.Create(type), kind, createdAtLineNumber: callerLineNumber, createdAtFilePath: callerFilePath, syntaxOpt: syntaxOpt ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.SyntaxNode?>(10440, 66284, 66333) ?? ((DynAbs.Tracing.TraceSender.Conditional_F1(10440, 66298, 66316) || ((f_10440_66298_66316(kind) && DynAbs.Tracing.TraceSender.Conditional_F2(10440, 66319, 66325)) || DynAbs.Tracing.TraceSender.Conditional_F3(10440, 66328, 66332))) ? syntax : null)), isPinned: false, refKind: refKind), null, type)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 66475, 66653);

                store = f_10440_66483_66652(syntax, local, argument, refKind != RefKind.None, type);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 66669, 66682);

                return local;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 64049, 66693);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10440_64522_64535(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 64522, 64535);
                    return return_v;
                }


                int
                f_10440_64509_64543(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 64509, 64543);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10440_64591_64611(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.CurrentFunction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 64591, 64611);
                    return return_v;
                }


                int
                f_10440_64626_64663(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 64626, 64663);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10440_65076_65087()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 65076, 65087);
                    return return_v;
                }


                bool
                f_10440_65076_65111(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.IsPeVerifyCompatEnabled;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 65076, 65111);
                    return return_v;
                }


                bool
                f_10440_64881_65175(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.CSharp.Binder.AddressKind
                addressKind, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, bool
                peVerifyCompatEnabled, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                stackLocalsOpt)
                {
                    var return_v = Binder.HasHome(expression, addressKind, method, peVerifyCompatEnabled, stackLocalsOpt: stackLocalsOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 64881, 65175);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10440_65405_65426(Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = node.GetRefKind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 65405, 65426);
                    return return_v;
                }


                int
                f_10440_65392_65441(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 65392, 65441);
                    return 0;
                }


                System.Exception
                f_10440_65745_65788(Microsoft.CodeAnalysis.RefKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 65745, 65788);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10440_65874_65887(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 65874, 65887);
                    return return_v;
                }


                bool
                f_10440_66298_66316(Microsoft.CodeAnalysis.SynthesizedLocalKind
                kind)
                {
                    var return_v = kind.IsLongLived();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 66298, 66316);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedLocal
                f_10440_65974_66411(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                containingMethodOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                type, Microsoft.CodeAnalysis.SynthesizedLocalKind
                kind, int
                createdAtLineNumber, string?
                createdAtFilePath, Microsoft.CodeAnalysis.SyntaxNode?
                syntaxOpt, bool
                isPinned, Microsoft.CodeAnalysis.RefKind
                refKind)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedLocal(containingMethodOpt, type, kind, createdAtLineNumber: createdAtLineNumber, createdAtFilePath: createdAtFilePath, syntaxOpt: syntaxOpt, isPinned: isPinned, refKind: refKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 65974, 66411);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10440_65916_66458(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedLocal
                localSymbol, Microsoft.CodeAnalysis.ConstantValue?
                constantValueOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundLocal(syntax, (Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol)localSymbol, constantValueOpt, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 65916, 66458);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                f_10440_66483_66652(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundLocal
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right, bool
                isRef, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator(syntax, (Microsoft.CodeAnalysis.CSharp.BoundExpression)left, right, isRef, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 66483, 66652);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 64049, 66693);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 64049, 66693);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal BoundStatement NoOp(NoOpStatementFlavor noOpStatementFlavor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 66705, 66869);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 66799, 66858);

                return f_10440_66806_66857(f_10440_66829_66835(), noOpStatementFlavor);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 66705, 66869);

                Microsoft.CodeAnalysis.SyntaxNode
                f_10440_66829_66835()
                {
                    var return_v = Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 66829, 66835);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNoOpStatement
                f_10440_66806_66857(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.NoOpStatementFlavor
                flavor)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundNoOpStatement(syntax, flavor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 66806, 66857);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 66705, 66869);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 66705, 66869);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal BoundLocal MakeTempForDiscard(BoundDiscardExpression node, ArrayBuilder<LocalSymbol> temps)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 66881, 67161);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 67006, 67023);

                LocalSymbol
                temp
                = default(LocalSymbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 67037, 67092);

                BoundLocal
                result = f_10440_67057_67091(this, node, out temp)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 67106, 67122);

                f_10440_67106_67121(temps, temp);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 67136, 67150);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 66881, 67161);

                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10440_67057_67091(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundDiscardExpression
                node, out Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                temp)
                {
                    var return_v = this_param.MakeTempForDiscard(node, out temp);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 67057, 67091);
                    return return_v;
                }


                int
                f_10440_67106_67121(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 67106, 67121);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 66881, 67161);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 66881, 67161);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal BoundLocal MakeTempForDiscard(BoundDiscardExpression node, out LocalSymbol temp)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 67173, 67597);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 67287, 67318);

                f_10440_67287_67317(f_10440_67300_67309(node) is { });
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 67332, 67456);

                temp = f_10440_67339_67455(f_10440_67360_67380(this), TypeWithAnnotations.Create(f_10440_67409_67418(node)), SynthesizedLocalKind.LoweringTemp);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 67472, 67586);

                return new BoundLocal(node.Syntax, temp, constantValueOpt: null, type: f_10440_67543_67552(node)) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10440, 67479, 67585) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 67173, 67597);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10440_67300_67309(Microsoft.CodeAnalysis.CSharp.BoundDiscardExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 67300, 67309);
                    return return_v;
                }


                int
                f_10440_67287_67317(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 67287, 67317);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10440_67360_67380(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.CurrentFunction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 67360, 67380);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10440_67409_67418(Microsoft.CodeAnalysis.CSharp.BoundDiscardExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 67409, 67418);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedLocal
                f_10440_67339_67455(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                containingMethodOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                type, Microsoft.CodeAnalysis.SynthesizedLocalKind
                kind)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedLocal(containingMethodOpt, type, kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 67339, 67455);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10440_67543_67552(Microsoft.CodeAnalysis.CSharp.BoundDiscardExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 67543, 67552);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 67173, 67597);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 67173, 67597);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal ImmutableArray<BoundExpression> MakeTempsForDiscardArguments(ImmutableArray<BoundExpression> arguments, ArrayBuilder<LocalSymbol> builder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10440, 67609, 68233);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 67781, 67861);

                var
                discardsPresent = arguments.Any(a => a.Kind == BoundKind.DiscardExpression)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 67877, 68189) || true) && (discardsPresent)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10440, 67877, 68189);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 67930, 68174);

                    arguments = arguments.SelectAsArray((arg, t) => arg.Kind == BoundKind.DiscardExpression ? t.factory.MakeTempForDiscard((BoundDiscardExpression)arg, t.builder) : arg, (factory: this, builder: builder));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10440, 67877, 68189);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10440, 68205, 68222);

                return arguments;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10440, 67609, 68233);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10440, 67609, 68233);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 67609, 68233);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SyntheticBoundNodeFactory()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10440, 812, 68240);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10440, 812, 68240);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10440, 812, 68240);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10440, 812, 68240);

        static Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10440_6409_6438(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.ContainingType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10440, 6409, 6438);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        f_10440_6393_6407_C(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10440, 6228, 6498);
            return return_v;
        }


        int
        f_10440_7181_7207(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 7181, 7207);
            return 0;
        }


        int
        f_10440_7222_7260(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 7222, 7260);
            return 0;
        }


        int
        f_10440_7275_7308(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10440, 7275, 7308);
            return 0;
        }

    }
}
