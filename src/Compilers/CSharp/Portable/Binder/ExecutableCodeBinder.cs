// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;
using System;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Threading;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed class ExecutableCodeBinder : Binder
    {
        private readonly Symbol _memberSymbol;

        private readonly SyntaxNode _root;

        private readonly Action<Binder, SyntaxNode> _binderUpdatedHandler;

        private SmallDictionary<SyntaxNode, Binder> _lazyBinderMap;

        internal ExecutableCodeBinder(SyntaxNode root, Symbol memberSymbol, Binder next, Action<Binder, SyntaxNode> binderUpdatedHandler = null)
        : this(f_10333_1431_1435_C(root), memberSymbol, next, next.Flags)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10333, 1274, 1549);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10333, 1493, 1538);

                _binderUpdatedHandler = binderUpdatedHandler;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10333, 1274, 1549);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10333, 1274, 1549);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10333, 1274, 1549);
            }
        }

        internal ExecutableCodeBinder(SyntaxNode root, Symbol memberSymbol, Binder next, BinderFlags additionalFlags)
        : base(f_10333_1691_1695_C(next), (next.Flags | additionalFlags) & ~BinderFlags.AllClearedAtExecutableCodeBoundary)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10333, 1561, 2092);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10333, 1059, 1072);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10333, 1111, 1116);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10333, 1171, 1192);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10333, 1247, 1261);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10333, 1803, 2009);

                f_10333_1803_2008((object)memberSymbol == null || (DynAbs.Tracing.TraceSender.Expression_False(10333, 1816, 2007) || (f_10333_1875_1892(memberSymbol) != SymbolKind.Local && (DynAbs.Tracing.TraceSender.Expression_True(10333, 1875, 1961) && f_10333_1916_1933(memberSymbol) != SymbolKind.RangeVariable) && (DynAbs.Tracing.TraceSender.Expression_True(10333, 1875, 2006) && f_10333_1965_1982(memberSymbol) != SymbolKind.Parameter))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10333, 2025, 2054);

                _memberSymbol = memberSymbol;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10333, 2068, 2081);

                _root = root;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10333, 1561, 2092);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10333, 1561, 2092);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10333, 1561, 2092);
            }
        }

        internal override Symbol ContainingMemberOrLambda
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10333, 2178, 2240);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10333, 2184, 2238);

                    return _memberSymbol ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbol>(10333, 2191, 2237) ?? f_10333_2208_2237(f_10333_2208_2212()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10333, 2178, 2240);

                    Microsoft.CodeAnalysis.CSharp.Binder?
                    f_10333_2208_2212()
                    {
                        var return_v = Next;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10333, 2208, 2212);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol?
                    f_10333_2208_2237(Microsoft.CodeAnalysis.CSharp.Binder?
                    this_param)
                    {
                        var return_v = this_param.ContainingMemberOrLambda;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10333, 2208, 2237);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10333, 2104, 2251);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10333, 2104, 2251);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override bool InExecutableBinder
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10333, 2319, 2326);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10333, 2322, 2326);
                    return true; DynAbs.Tracing.TraceSender.TraceExitMethod(10333, 2319, 2326);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10333, 2319, 2326);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10333, 2319, 2326);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal Symbol MemberSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10333, 2370, 2399);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10333, 2376, 2397);

                    return _memberSymbol;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10333, 2370, 2399);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10333, 2339, 2401);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10333, 2339, 2401);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override Binder GetBinder(SyntaxNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10333, 2413, 2612);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10333, 2489, 2503);

                Binder
                binder
                = default(Binder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10333, 2517, 2601);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10333, 2524, 2568) || ((f_10333_2524_2568(f_10333_2524_2538(this), node, out binder) && DynAbs.Tracing.TraceSender.Conditional_F2(10333, 2571, 2577)) || DynAbs.Tracing.TraceSender.Conditional_F3(10333, 2580, 2600))) ? binder : f_10333_2580_2600(f_10333_2580_2584(), node);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10333, 2413, 2612);

                Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.CSharp.Binder>
                f_10333_2524_2538(Microsoft.CodeAnalysis.CSharp.ExecutableCodeBinder
                this_param)
                {
                    var return_v = this_param.BinderMap;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10333, 2524, 2538);
                    return return_v;
                }


                bool
                f_10333_2524_2568(Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.CSharp.Binder>
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                key, out Microsoft.CodeAnalysis.CSharp.Binder
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10333, 2524, 2568);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder?
                f_10333_2580_2584()
                {
                    var return_v = Next;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10333, 2580, 2584);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder?
                f_10333_2580_2600(Microsoft.CodeAnalysis.CSharp.Binder?
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = this_param.GetBinder(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10333, 2580, 2600);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10333, 2413, 2612);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10333, 2413, 2612);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void ComputeBinderMap()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10333, 2624, 3652);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10333, 2680, 2720);

                SmallDictionary<SyntaxNode, Binder>
                map
                = default(SmallDictionary<SyntaxNode, Binder>);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10333, 2736, 3566) || true) && (_memberSymbol is SynthesizedSimpleProgramEntryPointSymbol entryPoint && (DynAbs.Tracing.TraceSender.Expression_True(10333, 2740, 2842) && _root == f_10333_2821_2842(entryPoint)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10333, 2736, 3566);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10333, 2876, 2935);

                    var
                    scopeOwner = f_10333_2893_2934(this, entryPoint)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10333, 2953, 3044);

                    map = f_10333_2959_3043(_memberSymbol, _root, scopeOwner, _binderUpdatedHandler);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10333, 3062, 3089);

                    f_10333_3062_3088(map, _root, scopeOwner);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10333, 2736, 3566);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10333, 2736, 3566);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10333, 3225, 3551) || true) && ((object)_memberSymbol != null && (DynAbs.Tracing.TraceSender.Expression_True(10333, 3229, 3275) && _root != null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10333, 3225, 3551);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10333, 3317, 3402);

                        map = f_10333_3323_3401(_memberSymbol, _root, this, _binderUpdatedHandler);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10333, 3225, 3551);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10333, 3225, 3551);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10333, 3484, 3532);

                        map = SmallDictionary<SyntaxNode, Binder>.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10333, 3225, 3551);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10333, 2736, 3566);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10333, 3582, 3641);

                f_10333_3582_3640(ref _lazyBinderMap, map, null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10333, 2624, 3652);

                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10333_2821_2842(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedSimpleProgramEntryPointSymbol
                this_param)
                {
                    var return_v = this_param.SyntaxNode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10333, 2821, 2842);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SimpleProgramBinder
                f_10333_2893_2934(Microsoft.CodeAnalysis.CSharp.ExecutableCodeBinder
                enclosing, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedSimpleProgramEntryPointSymbol
                entryPoint)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SimpleProgramBinder((Microsoft.CodeAnalysis.CSharp.Binder)enclosing, entryPoint);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10333, 2893, 2934);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.CSharp.Binder>
                f_10333_2959_3043(Microsoft.CodeAnalysis.CSharp.Symbol
                containingMemberOrLambda, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.SimpleProgramBinder
                enclosing, System.Action<Microsoft.CodeAnalysis.CSharp.Binder, Microsoft.CodeAnalysis.SyntaxNode>
                binderUpdatedHandler)
                {
                    var return_v = LocalBinderFactory.BuildMap(containingMemberOrLambda, syntax, (Microsoft.CodeAnalysis.CSharp.Binder)enclosing, binderUpdatedHandler);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10333, 2959, 3043);
                    return return_v;
                }


                int
                f_10333_3062_3088(Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.CSharp.Binder>
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                key, Microsoft.CodeAnalysis.CSharp.SimpleProgramBinder
                value)
                {
                    this_param.Add(key, (Microsoft.CodeAnalysis.CSharp.Binder)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10333, 3062, 3088);
                    return 0;
                }


                Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.CSharp.Binder>
                f_10333_3323_3401(Microsoft.CodeAnalysis.CSharp.Symbol
                containingMemberOrLambda, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.ExecutableCodeBinder
                enclosing, System.Action<Microsoft.CodeAnalysis.CSharp.Binder, Microsoft.CodeAnalysis.SyntaxNode>
                binderUpdatedHandler)
                {
                    var return_v = LocalBinderFactory.BuildMap(containingMemberOrLambda, syntax, (Microsoft.CodeAnalysis.CSharp.Binder)enclosing, binderUpdatedHandler);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10333, 3323, 3401);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.CSharp.Binder>
                f_10333_3582_3640(ref Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.CSharp.Binder>
                location1, Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.CSharp.Binder>
                value, Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.CSharp.Binder>
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10333, 3582, 3640);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10333, 2624, 3652);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10333, 2624, 3652);
            }
        }

        private SmallDictionary<SyntaxNode, Binder> BinderMap
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10333, 3742, 3941);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10333, 3778, 3884) || true) && (_lazyBinderMap == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10333, 3778, 3884);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10333, 3846, 3865);

                        f_10333_3846_3864(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10333, 3778, 3884);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10333, 3904, 3926);

                    return _lazyBinderMap;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10333, 3742, 3941);

                    int
                    f_10333_3846_3864(Microsoft.CodeAnalysis.CSharp.ExecutableCodeBinder
                    this_param)
                    {
                        this_param.ComputeBinderMap();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10333, 3846, 3864);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10333, 3664, 3952);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10333, 3664, 3952);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static void ValidateIteratorMethod(CSharpCompilation compilation, MethodSymbol iterator, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10333, 3964, 6596);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10333, 4111, 4191) || true) && (f_10333_4115_4135_M(!iterator.IsIterator))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10333, 4111, 4191);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10333, 4169, 4176);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10333, 4111, 4191);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10333, 4207, 4663);
                    foreach (var parameter in f_10333_4233_4252_I(f_10333_4233_4252(iterator)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10333, 4207, 4663);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10333, 4286, 4648) || true) && (f_10333_4290_4307(parameter) != RefKind.None)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10333, 4286, 4648);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10333, 4365, 4439);

                            f_10333_4365_4438(diagnostics, ErrorCode.ERR_BadIteratorArgType, f_10333_4415_4434(parameter)[0]);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10333, 4286, 4648);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10333, 4286, 4648);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10333, 4481, 4648) || true) && (f_10333_4485_4510(f_10333_4485_4499(parameter)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10333, 4481, 4648);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10333, 4552, 4629);

                                f_10333_4552_4628(diagnostics, ErrorCode.ERR_UnsafeIteratorArgType, f_10333_4605_4624(parameter)[0]);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10333, 4481, 4648);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10333, 4286, 4648);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10333, 4207, 4663);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10333, 1, 457);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10333, 1, 457);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10333, 4702, 4902);

                Location
                errorLocation = ((DynAbs.Tracing.TraceSender.Conditional_F1(10333, 4728, 4782) || (((iterator is SynthesizedSimpleProgramEntryPointSymbol) && DynAbs.Tracing.TraceSender.Conditional_F2(10333, 4785, 4868)) || DynAbs.Tracing.TraceSender.Conditional_F3(10333, 4871, 4875))) ? f_10333_4785_4868(f_10333_4785_4854(((SynthesizedSimpleProgramEntryPointSymbol)iterator))) : null) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.Location?>(10333, 4727, 4901) ?? f_10333_4880_4898(iterator)[0])
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10333, 4918, 5144) || true) && (f_10333_4922_4939(iterator))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10333, 4918, 5144);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10333, 5067, 5129);

                    f_10333_5067_5128(                // error CS1636: __arglist is not allowed in the parameter list of iterators
                                    diagnostics, ErrorCode.ERR_VarargsIterator, errorLocation);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10333, 4918, 5144);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10333, 5183, 5561) || true) && ((((iterator is SourceMemberMethodSymbol) && (DynAbs.Tracing.TraceSender.Expression_True(10333, 5189, 5276) && f_10333_5231_5276(((SourceMemberMethodSymbol)iterator))))
                || (DynAbs.Tracing.TraceSender.Expression_False(10333, 5188, 5377) || ((iterator is LocalFunctionSymbol) && (DynAbs.Tracing.TraceSender.Expression_True(10333, 5299, 5376) && f_10333_5336_5376(((LocalFunctionSymbol)iterator))))))
                && (DynAbs.Tracing.TraceSender.Expression_True(10333, 5187, 5430) && f_10333_5399_5430(f_10333_5399_5418(compilation))))
                ) // Don't cascade

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10333, 5183, 5561);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10333, 5481, 5546);

                    f_10333_5481_5545(diagnostics, ErrorCode.ERR_IllegalInnerUnsafe, errorLocation);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10333, 5183, 5561);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10333, 5577, 5614);

                var
                returnType = f_10333_5594_5613(iterator)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10333, 5628, 5663);

                RefKind
                refKind = f_10333_5646_5662(iterator)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10333, 5677, 5825);

                TypeWithAnnotations
                elementType = f_10333_5711_5824(compilation, refKind, returnType, errorLocation, diagnostics)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10333, 5841, 6285) || true) && (elementType.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10333, 5841, 6285);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10333, 5900, 6270) || true) && (refKind != RefKind.None)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10333, 5900, 6270);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10333, 5969, 6049);

                        f_10333_5969_6048(diagnostics, ErrorCode.ERR_BadIteratorReturnRef, errorLocation, iterator);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10333, 5900, 6270);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10333, 5900, 6270);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10333, 6091, 6270) || true) && (!f_10333_6096_6120(returnType))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10333, 6091, 6270);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10333, 6162, 6251);

                            f_10333_6162_6250(diagnostics, ErrorCode.ERR_BadIteratorReturn, errorLocation, iterator, returnType);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10333, 6091, 6270);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10333, 5900, 6270);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10333, 5841, 6285);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10333, 6301, 6395);

                bool
                asyncInterface = f_10333_6323_6394(compilation, refKind, returnType)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10333, 6409, 6585) || true) && (asyncInterface && (DynAbs.Tracing.TraceSender.Expression_True(10333, 6413, 6448) && f_10333_6431_6448_M(!iterator.IsAsync)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10333, 6409, 6585);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10333, 6482, 6570);

                    f_10333_6482_6569(diagnostics, ErrorCode.ERR_IteratorMustBeAsync, errorLocation, iterator, returnType);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10333, 6409, 6585);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10333, 3964, 6596);

                bool
                f_10333_4115_4135_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10333, 4115, 4135);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10333_4233_4252(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10333, 4233, 4252);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10333_4290_4307(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10333, 4290, 4307);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10333_4415_4434(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10333, 4415, 4434);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10333_4365_4438(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10333, 4365, 4438);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10333_4485_4499(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10333, 4485, 4499);
                    return return_v;
                }


                bool
                f_10333_4485_4510(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsUnsafe();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10333, 4485, 4510);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10333_4605_4624(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10333, 4605, 4624);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10333_4552_4628(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10333, 4552, 4628);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10333_4233_4252_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10333, 4233, 4252);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10333_4785_4854(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedSimpleProgramEntryPointSymbol
                this_param)
                {
                    var return_v = this_param.ReturnTypeSyntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10333, 4785, 4854);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10333_4785_4868(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.GetLocation();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10333, 4785, 4868);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10333_4880_4898(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10333, 4880, 4898);
                    return return_v;
                }


                bool
                f_10333_4922_4939(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsVararg;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10333, 4922, 4939);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10333_5067_5128(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10333, 5067, 5128);
                    return return_v;
                }


                bool
                f_10333_5231_5276(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol
                this_param)
                {
                    var return_v = this_param.IsUnsafe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10333, 5231, 5276);
                    return return_v;
                }


                bool
                f_10333_5336_5376(Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                this_param)
                {
                    var return_v = this_param.IsUnsafe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10333, 5336, 5376);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_10333_5399_5418(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10333, 5399, 5418);
                    return return_v;
                }


                bool
                f_10333_5399_5430(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.AllowUnsafe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10333, 5399, 5430);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10333_5481_5545(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10333, 5481, 5545);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10333_5594_5613(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10333, 5594, 5613);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10333_5646_5662(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10333, 5646, 5662);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10333_5711_5824(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.RefKind
                refKind, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                returnType, Microsoft.CodeAnalysis.Location
                errorLocation, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = InMethodBinder.GetIteratorElementTypeFromReturnType(compilation, refKind, returnType, errorLocation, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10333, 5711, 5824);
                    return return_v;
                }


                int
                f_10333_5969_6048(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    Error(diagnostics, code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10333, 5969, 6048);
                    return 0;
                }


                bool
                f_10333_6096_6120(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10333, 6096, 6120);
                    return return_v;
                }


                int
                f_10333_6162_6250(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    Error(diagnostics, code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10333, 6162, 6250);
                    return 0;
                }


                bool
                f_10333_6323_6394(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.RefKind
                refKind, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                returnType)
                {
                    var return_v = InMethodBinder.IsAsyncStreamInterface(compilation, refKind, returnType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10333, 6323, 6394);
                    return return_v;
                }


                bool
                f_10333_6431_6448_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10333, 6431, 6448);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10333_6482_6569(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10333, 6482, 6569);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10333, 3964, 6596);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10333, 3964, 6596);
            }
        }

        static ExecutableCodeBinder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10333, 967, 6603);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10333, 967, 6603);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10333, 967, 6603);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10333, 967, 6603);

        static Microsoft.CodeAnalysis.SyntaxNode
        f_10333_1431_1435_C(Microsoft.CodeAnalysis.SyntaxNode
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10333, 1274, 1549);
            return return_v;
        }


        Microsoft.CodeAnalysis.SymbolKind
        f_10333_1875_1892(Microsoft.CodeAnalysis.CSharp.Symbol
        this_param)
        {
            var return_v = this_param.Kind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10333, 1875, 1892);
            return return_v;
        }


        Microsoft.CodeAnalysis.SymbolKind
        f_10333_1916_1933(Microsoft.CodeAnalysis.CSharp.Symbol
        this_param)
        {
            var return_v = this_param.Kind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10333, 1916, 1933);
            return return_v;
        }


        Microsoft.CodeAnalysis.SymbolKind
        f_10333_1965_1982(Microsoft.CodeAnalysis.CSharp.Symbol
        this_param)
        {
            var return_v = this_param.Kind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10333, 1965, 1982);
            return return_v;
        }


        int
        f_10333_1803_2008(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10333, 1803, 2008);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Binder
        f_10333_1691_1695_C(Microsoft.CodeAnalysis.CSharp.Binder
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10333, 1561, 2092);
            return return_v;
        }

    }
}
