// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.CSharp
{

    internal struct LoweredDynamicOperation
    {

        private readonly SyntheticBoundNodeFactory? _factory;

        private readonly TypeSymbol _resultType;

        private readonly ImmutableArray<LocalSymbol> _temps;

        public readonly BoundExpression? SiteInitialization;

        public readonly BoundExpression SiteInvocation;

        public LoweredDynamicOperation(SyntheticBoundNodeFactory? factory, BoundExpression? siteInitialization, BoundExpression siteInvocation, TypeSymbol resultType, ImmutableArray<LocalSymbol> temps)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10536, 1284, 1710);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10536, 1502, 1521);

                _factory = factory;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10536, 1535, 1560);

                _resultType = resultType;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10536, 1574, 1589);

                _temps = temps;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10536, 1603, 1648);

                this.SiteInitialization = siteInitialization;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10536, 1662, 1699);

                this.SiteInvocation = siteInvocation;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10536, 1284, 1710);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10536, 1284, 1710);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10536, 1284, 1710);
            }
        }

        public static LoweredDynamicOperation Bad(
                    BoundExpression? loweredReceiver,
                    ImmutableArray<BoundExpression> loweredArguments,
                    BoundExpression? loweredRight,
                    TypeSymbol resultType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10536, 1722, 2294);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10536, 1979, 2038);

                var
                children = f_10536_1994_2037()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10536, 2052, 2090);

                f_10536_2052_2089(children, loweredReceiver);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10536, 2104, 2140);

                f_10536_2104_2139(children, loweredArguments);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10536, 2154, 2189);

                f_10536_2154_2188(children, loweredRight);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10536, 2205, 2283);

                return LoweredDynamicOperation.Bad(resultType, f_10536_2252_2281(children));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10536, 1722, 2294);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10536_1994_2037()
                {
                    var return_v = ArrayBuilder<BoundExpression>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10536, 1994, 2037);
                    return return_v;
                }


                int
                f_10536_2052_2089(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                builder, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                item)
                {
                    builder.AddOptional<Microsoft.CodeAnalysis.CSharp.BoundExpression>(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10536, 2052, 2089);
                    return 0;
                }


                int
                f_10536_2104_2139(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10536, 2104, 2139);
                    return 0;
                }


                int
                f_10536_2154_2188(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                builder, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                item)
                {
                    builder.AddOptional<Microsoft.CodeAnalysis.CSharp.BoundExpression>(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10536, 2154, 2188);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10536_2252_2281(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10536, 2252, 2281);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10536, 1722, 2294);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10536, 1722, 2294);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static LoweredDynamicOperation Bad(TypeSymbol resultType, ImmutableArray<BoundExpression> children)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10536, 2306, 2742);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10536, 2437, 2471);

                f_10536_2437_2470(children.Length > 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10536, 2485, 2615);

                var
                bad = f_10536_2495_2614(children[0].Syntax, LookupResultKind.Empty, ImmutableArray<Symbol?>.Empty, children, resultType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10536, 2629, 2731);

                return f_10536_2636_2730(null, null, bad, resultType, default(ImmutableArray<LocalSymbol>));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10536, 2306, 2742);

                int
                f_10536_2437_2470(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10536, 2437, 2470);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBadExpression
                f_10536_2495_2614(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.LookupResultKind
                resultKind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol?>
                symbols, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                childBoundNodes, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundBadExpression(syntax, resultKind, symbols, childBoundNodes, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10536, 2495, 2614);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperation
                f_10536_2636_2730(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory?
                factory, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                siteInitialization, Microsoft.CodeAnalysis.CSharp.BoundBadExpression
                siteInvocation, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                resultType, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                temps)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperation(factory, siteInitialization, (Microsoft.CodeAnalysis.CSharp.BoundExpression)siteInvocation, resultType, temps);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10536, 2636, 2730);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10536, 2306, 2742);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10536, 2306, 2742);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundExpression ToExpression()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10536, 2754, 3624);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10536, 2816, 3033) || true) && (_factory == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10536, 2816, 3033);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10536, 2870, 2978);

                    f_10536_2870_2977(SiteInitialization == null && (DynAbs.Tracing.TraceSender.Expression_True(10536, 2883, 2949) && SiteInvocation is BoundBadExpression) && (DynAbs.Tracing.TraceSender.Expression_True(10536, 2883, 2976) && _temps.IsDefaultOrEmpty));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10536, 2996, 3018);

                    return SiteInvocation;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10536, 2816, 3033);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10536, 3179, 3219);

                f_10536_3179_3218(SiteInitialization is { });

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10536, 3233, 3613) || true) && (_temps.IsDefaultOrEmpty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10536, 3233, 3613);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10536, 3294, 3378);

                    return f_10536_3301_3377(_factory, new[] { SiteInitialization }, SiteInvocation, _resultType);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10536, 3233, 3613);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10536, 3233, 3613);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10536, 3444, 3598);

                    return new BoundSequence(f_10536_3469_3484(_factory), _temps, f_10536_3494_3535(SiteInitialization), SiteInvocation, _resultType) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10536, 3451, 3597) };
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10536, 3233, 3613);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10536, 2754, 3624);

                int
                f_10536_2870_2977(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10536, 2870, 2977);
                    return 0;
                }


                int
                f_10536_3179_3218(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10536, 3179, 3218);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundSequence
                f_10536_3301_3377(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                sideEffects, Microsoft.CodeAnalysis.CSharp.BoundExpression
                result, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Sequence(sideEffects, result, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10536, 3301, 3377);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10536_3469_3484(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10536, 3469, 3484);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10536_3494_3535(Microsoft.CodeAnalysis.CSharp.BoundExpression
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10536, 3494, 3535);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10536, 2754, 3624);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10536, 2754, 3624);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        static LoweredDynamicOperation()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10536, 932, 3631);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10536, 932, 3631);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10536, 932, 3631);
        }
    }
}
