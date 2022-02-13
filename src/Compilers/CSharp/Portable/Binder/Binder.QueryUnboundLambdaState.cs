// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal partial class Binder
    {
        private delegate BoundBlock LambdaBodyFactory(LambdaSymbol lambdaSymbol, Binder lambdaBodyBinder, DiagnosticBag diagnostics);
        private sealed class QueryUnboundLambdaState : UnboundLambdaState
        {
            private readonly ImmutableArray<RangeVariableSymbol> _parameters;

            private readonly LambdaBodyFactory _bodyFactory;

            private readonly RangeVariableMap _rangeVariableMap;

            public QueryUnboundLambdaState(Binder binder, RangeVariableMap rangeVariableMap, ImmutableArray<RangeVariableSymbol> parameters, LambdaBodyFactory bodyFactory, bool includeCache = true)
            : base(f_10290_1094_1100_C(binder), unboundLambdaOpt: null, includeCache)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10290, 884, 1312);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10290, 789, 801);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10290, 850, 867);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10290, 1172, 1197);

                    _parameters = parameters;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10290, 1215, 1252);

                    _rangeVariableMap = rangeVariableMap;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10290, 1270, 1297);

                    _bodyFactory = bodyFactory;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10290, 884, 1312);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10290, 884, 1312);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10290, 884, 1312);
                }
            }

            public override string ParameterName(int index)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10290, 1328, 1411);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10290, 1378, 1409);

                    return f_10290_1385_1408(_parameters[index]);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10290, 1328, 1411);

                    string
                    f_10290_1385_1408(Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10290, 1385, 1408);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10290, 1328, 1411);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10290, 1328, 1411);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override bool ParameterIsDiscard(int index)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10290, 1425, 1493);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10290, 1478, 1491);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10290, 1425, 1493);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10290, 1425, 1493);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10290, 1425, 1493);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override bool HasNames
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10290, 1539, 1559);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10290, 1545, 1557);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10290, 1539, 1559);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10290, 1507, 1561);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10290, 1507, 1561);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override bool HasSignature
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10290, 1611, 1631);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10290, 1617, 1629);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10290, 1611, 1631);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10290, 1575, 1633);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10290, 1575, 1633);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override bool HasExplicitlyTypedParameterList
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10290, 1702, 1723);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10290, 1708, 1721);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10290, 1702, 1723);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10290, 1647, 1725);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10290, 1647, 1725);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override int ParameterCount
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10290, 1776, 1810);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10290, 1782, 1808);

                        return _parameters.Length;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10290, 1776, 1810);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10290, 1739, 1812);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10290, 1739, 1812);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override bool IsAsync
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10290, 1857, 1878);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10290, 1863, 1876);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10290, 1857, 1878);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10290, 1826, 1880);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10290, 1826, 1880);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override bool IsStatic
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10290, 1924, 1932);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10290, 1927, 1932);
                        return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10290, 1924, 1932);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10290, 1924, 1932);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10290, 1924, 1932);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override RefKind RefKind(int index)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10290, 1947, 2037);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10290, 1992, 2035);

                    return Microsoft.CodeAnalysis.RefKind.None;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10290, 1947, 2037);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10290, 1947, 2037);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10290, 1947, 2037);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override MessageID MessageID
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10290, 2089, 2141);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10290, 2095, 2139);

                        return MessageID.IDS_FeatureQueryExpression;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10290, 2089, 2141);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10290, 2051, 2143);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10290, 2051, 2143);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override Location ParameterLocation(int index)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10290, 2195, 2292);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10290, 2251, 2290);

                    return f_10290_2258_2286(_parameters[index])[0];
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10290, 2195, 2292);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                    f_10290_2258_2286(Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                    this_param)
                    {
                        var return_v = this_param.Locations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10290, 2258, 2286);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10290, 2195, 2292);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10290, 2195, 2292);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override TypeWithAnnotations ParameterTypeWithAnnotations(int index)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10290, 2306, 2416);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10290, 2384, 2414);

                    throw f_10290_2390_2413();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10290, 2306, 2416);

                    System.ArgumentException
                    f_10290_2390_2413()
                    {
                        var return_v = new System.ArgumentException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10290, 2390, 2413);
                        return return_v;
                    }

                } // implicitly typed
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10290, 2306, 2416);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10290, 2306, 2416);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override void GenerateAnonymousFunctionConversionError(DiagnosticBag diagnostics, TypeSymbol targetType)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10290, 2452, 2751);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10290, 2665, 2736);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.GenerateAnonymousFunctionConversionError(diagnostics, targetType), 10290, 2665, 2735);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10290, 2452, 2751);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10290, 2452, 2751);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10290, 2452, 2751);
                }
            }

            public override Binder ParameterBinder(LambdaSymbol lambdaSymbol, Binder binder)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10290, 2767, 2979);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10290, 2880, 2964);

                    return f_10290_2887_2963(lambdaSymbol, _rangeVariableMap, binder);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10290, 2767, 2979);

                    Microsoft.CodeAnalysis.CSharp.Binder.WithQueryLambdaParametersBinder
                    f_10290_2887_2963(Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                    lambdaSymbol, Microsoft.CodeAnalysis.CSharp.Binder.RangeVariableMap
                    rangeVariableMap, Microsoft.CodeAnalysis.CSharp.Binder
                    next)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Binder.WithQueryLambdaParametersBinder(lambdaSymbol, rangeVariableMap, next);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10290, 2887, 2963);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10290, 2767, 2979);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10290, 2767, 2979);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            protected override UnboundLambdaState WithCachingCore(bool includeCache)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10290, 2995, 3218);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10290, 3100, 3203);

                    return f_10290_3107_3202(Binder, _rangeVariableMap, _parameters, _bodyFactory, includeCache);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10290, 2995, 3218);

                    Microsoft.CodeAnalysis.CSharp.Binder.QueryUnboundLambdaState
                    f_10290_3107_3202(Microsoft.CodeAnalysis.CSharp.Binder
                    binder, Microsoft.CodeAnalysis.CSharp.Binder.RangeVariableMap
                    rangeVariableMap, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol>
                    parameters, Microsoft.CodeAnalysis.CSharp.Binder.LambdaBodyFactory
                    bodyFactory, bool
                    includeCache)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Binder.QueryUnboundLambdaState(binder, rangeVariableMap, parameters, bodyFactory, includeCache);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10290, 3107, 3202);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10290, 2995, 3218);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10290, 2995, 3218);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            protected override BoundExpression GetLambdaExpressionBody(BoundBlock body)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10290, 3234, 3369);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10290, 3342, 3354);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10290, 3234, 3369);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10290, 3234, 3369);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10290, 3234, 3369);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            protected override BoundBlock CreateBlockFromLambdaExpressionBody(Binder lambdaBodyBinder, BoundExpression expression, DiagnosticBag diagnostics)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10290, 3385, 3615);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10290, 3563, 3600);

                    throw f_10290_3569_3599();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10290, 3385, 3615);

                    System.Exception
                    f_10290_3569_3599()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10290, 3569, 3599);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10290, 3385, 3615);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10290, 3385, 3615);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            protected override BoundBlock BindLambdaBody(LambdaSymbol lambdaSymbol, Binder lambdaBodyBinder, DiagnosticBag diagnostics)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10290, 3631, 3867);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10290, 3787, 3852);

                    return f_10290_3794_3851(this, lambdaSymbol, lambdaBodyBinder, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10290, 3631, 3867);

                    Microsoft.CodeAnalysis.CSharp.BoundBlock
                    f_10290_3794_3851(Microsoft.CodeAnalysis.CSharp.Binder.QueryUnboundLambdaState
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                    lambdaSymbol, Microsoft.CodeAnalysis.CSharp.Binder
                    lambdaBodyBinder, Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics)
                    {
                        var return_v = this_param._bodyFactory(lambdaSymbol, lambdaBodyBinder, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10290, 3794, 3851);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10290, 3631, 3867);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10290, 3631, 3867);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static QueryUnboundLambdaState()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10290, 585, 3878);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10290, 585, 3878);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10290, 585, 3878);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10290, 585, 3878);

            static Microsoft.CodeAnalysis.CSharp.Binder
            f_10290_1094_1100_C(Microsoft.CodeAnalysis.CSharp.Binder
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10290, 884, 1312);
                return return_v;
            }

        }
    }
}
