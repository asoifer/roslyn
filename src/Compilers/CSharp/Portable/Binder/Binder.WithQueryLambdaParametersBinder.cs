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
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal partial class Binder
    {
        private sealed class WithQueryLambdaParametersBinder : WithLambdaParametersBinder
        {
            private readonly RangeVariableMap _rangeVariableMap;

            private readonly MultiDictionary<string, RangeVariableSymbol> _parameterMap;

            public WithQueryLambdaParametersBinder(LambdaSymbol lambdaSymbol, RangeVariableMap rangeVariableMap, Binder next)
            : base(f_10293_1162_1174_C(lambdaSymbol), next)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10293, 1024, 1501);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10293, 900, 917);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10293, 994, 1007);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10293, 1214, 1251);

                    _rangeVariableMap = rangeVariableMap;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10293, 1269, 1336);

                    _parameterMap = f_10293_1285_1335();
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10293, 1354, 1486);
                        foreach (var qv in f_10293_1373_1394_I(f_10293_1373_1394(rangeVariableMap)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10293, 1354, 1486);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10293, 1436, 1467);

                            f_10293_1436_1466(_parameterMap, f_10293_1454_1461(qv), qv);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10293, 1354, 1486);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10293, 1, 133);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10293, 1, 133);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10293, 1024, 1501);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10293, 1024, 1501);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10293, 1024, 1501);
                }
            }

            protected override BoundExpression BindRangeVariable(SimpleNameSyntax node, RangeVariableSymbol qv, DiagnosticBag diagnostics)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10293, 1517, 3343);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10293, 1676, 1708);

                    f_10293_1676_1707(f_10293_1689_1706_M(!qv.IsTransparent));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10293, 1728, 1756);

                    BoundExpression
                    translation
                    = default(BoundExpression);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10293, 1774, 1802);

                    ImmutableArray<string>
                    path
                    = default(ImmutableArray<string>);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10293, 1820, 3255) || true) && (f_10293_1824_1867(_rangeVariableMap, qv, out path))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10293, 1820, 3255);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10293, 1909, 3141) || true) && (path.IsEmpty)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10293, 1909, 3141);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10293, 2075, 2114);

                            var
                            value = f_10293_2087_2113(DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.parameterMap, 10293, 2087, 2104), f_10293_2105_2112(qv))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10293, 2140, 2171);

                            f_10293_2140_2170(value.Count == 1);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10293, 2197, 2252);

                            translation = f_10293_2211_2251(node, value.Single());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10293, 1909, 3141);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10293, 1909, 3141);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10293, 2558, 2675);

                            f_10293_2558_2674(f_10293_2571_2673(f_10293_2571_2607(f_10293_2571_2599(DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.lambdaSymbol, 10293, 2571, 2588))[0]), transparentIdentifierPrefix, StringComparison.Ordinal));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10293, 2701, 2773);

                            translation = f_10293_2715_2772(node, f_10293_2740_2768(DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.lambdaSymbol, 10293, 2740, 2757))[0]);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10293, 2808, 2827);
                                for (int
        i = path.Length - 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10293, 2799, 3118) || true) && (i >= 0)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10293, 2837, 2840)
        , i--, DynAbs.Tracing.TraceSender.TraceExitCondition(10293, 2799, 3118))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10293, 2799, 3118);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10293, 2898, 2938);

                                    translation.WasCompilerGenerated = true;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10293, 2968, 2992);

                                    var
                                    nextField = path[i]
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10293, 3022, 3091);

                                    translation = f_10293_3036_3090(this, node, translation, nextField, diagnostics);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10293, 1, 320);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10293, 1, 320);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10293, 1909, 3141);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10293, 3165, 3236);

                        return f_10293_3172_3235(node, qv, translation, f_10293_3218_3234(translation));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10293, 1820, 3255);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10293, 3275, 3328);

                    return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.BindRangeVariable(node, qv, diagnostics), 10293, 3282, 3327);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10293, 1517, 3343);

                    bool
                    f_10293_1689_1706_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10293, 1689, 1706);
                        return return_v;
                    }


                    int
                    f_10293_1676_1707(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10293, 1676, 1707);
                        return 0;
                    }


                    bool
                    f_10293_1824_1867(Microsoft.CodeAnalysis.CSharp.Binder.RangeVariableMap
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                    key, out System.Collections.Immutable.ImmutableArray<string>
                    value)
                    {
                        var return_v = this_param.TryGetValue(key, out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10293, 1824, 1867);
                        return return_v;
                    }


                    string
                    f_10293_2105_2112(Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10293, 2105, 2112);
                        return return_v;
                    }


                    Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>.ValueSet
                    f_10293_2087_2113(Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    this_param, string
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10293, 2087, 2113);
                        return return_v;
                    }


                    int
                    f_10293_2140_2170(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10293, 2140, 2170);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundParameter
                    f_10293_2211_2251(Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax
                    syntax, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    parameterSymbol)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.BoundParameter((Microsoft.CodeAnalysis.SyntaxNode)syntax, parameterSymbol);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10293, 2211, 2251);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    f_10293_2571_2599(Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                    this_param)
                    {
                        var return_v = this_param.Parameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10293, 2571, 2599);
                        return return_v;
                    }


                    string
                    f_10293_2571_2607(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10293, 2571, 2607);
                        return return_v;
                    }


                    bool
                    f_10293_2571_2673(string
                    this_param, string
                    value, System.StringComparison
                    comparisonType)
                    {
                        var return_v = this_param.StartsWith(value, comparisonType);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10293, 2571, 2673);
                        return return_v;
                    }


                    int
                    f_10293_2558_2674(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10293, 2558, 2674);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    f_10293_2740_2768(Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                    this_param)
                    {
                        var return_v = this_param.Parameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10293, 2740, 2768);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundParameter
                    f_10293_2715_2772(Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax
                    syntax, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    parameterSymbol)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.BoundParameter((Microsoft.CodeAnalysis.SyntaxNode)syntax, parameterSymbol);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10293, 2715, 2772);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10293_3036_3090(Microsoft.CodeAnalysis.CSharp.Binder.WithQueryLambdaParametersBinder
                    this_param, Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax
                    node, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    receiver, string
                    name, Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics)
                    {
                        var return_v = this_param.SelectField(node, receiver, name, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10293, 3036, 3090);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                    f_10293_3218_3234(Microsoft.CodeAnalysis.CSharp.BoundExpression
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10293, 3218, 3234);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundRangeVariable
                    f_10293_3172_3235(Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax
                    syntax, Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                    rangeVariableSymbol, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    value, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                    type)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.BoundRangeVariable((Microsoft.CodeAnalysis.SyntaxNode)syntax, rangeVariableSymbol, value, type);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10293, 3172, 3235);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10293, 1517, 3343);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10293, 1517, 3343);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private BoundExpression SelectField(SimpleNameSyntax node, BoundExpression receiver, string name, DiagnosticBag diagnostics)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10293, 3359, 5396);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10293, 3516, 3568);

                    var
                    receiverType = f_10293_3535_3548(receiver) as NamedTypeSymbol
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10293, 3586, 4647) || true) && ((object)receiverType == null || (DynAbs.Tracing.TraceSender.Expression_False(10293, 3590, 3651) || f_10293_3622_3651_M(!receiverType.IsAnonymousType)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10293, 3586, 4647);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10293, 3938, 4073);

                        var
                        info = f_10293_3949_4072(ErrorCode.ERR_UnsupportedTransparentIdentifierAccess, name, f_10293_4030_4055(receiver) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbol?>(10293, 4030, 4071) ?? receiverType))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10293, 4095, 4239) || true) && (f_10293_4113_4127(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10293_4099_4112(receiver), 10293, 4099, 4127)) != true)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10293, 4095, 4239);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10293, 4185, 4216);

                            f_10293_4185_4215(diagnostics, info, node);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10293, 4095, 4239);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10293, 4263, 4628);

                        return f_10293_4270_4627(node, LookupResultKind.Empty, f_10293_4399_4455(f_10293_4429_4454(receiver)), f_10293_4482_4541(f_10293_4504_4540(this, receiver)), f_10293_4568_4626(f_10293_4596_4612(this), "", 0, info));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10293, 3586, 4647);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10293, 4667, 4722);

                    LookupResult
                    lookupResult = f_10293_4695_4721()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10293, 4740, 4793);

                    LookupOptions
                    options = LookupOptions.MustBeInstance
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10293, 4811, 4861);

                    HashSet<DiagnosticInfo>
                    useSiteDiagnostics = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10293, 4879, 5011);

                    f_10293_4879_5010(this, lookupResult, f_10293_4919_4932(receiver), name, 0, ref useSiteDiagnostics, basesBeingResolved: null, options: options);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10293, 5029, 5071);

                    f_10293_5029_5070(diagnostics, node, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10293, 5091, 5311);

                    var
                    result = f_10293_5104_5310(this, node, node, name, 0, indexed: false, receiver, default(SeparatedSyntaxList<TypeSyntax>), default(ImmutableArray<TypeWithAnnotations>), lookupResult, BoundMethodGroupFlags.None, diagnostics)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10293, 5329, 5349);

                    f_10293_5329_5348(lookupResult);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10293, 5367, 5381);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10293, 3359, 5396);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                    f_10293_3535_3548(Microsoft.CodeAnalysis.CSharp.BoundExpression
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10293, 3535, 3548);
                        return return_v;
                    }


                    bool
                    f_10293_3622_3651_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10293, 3622, 3651);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol?
                    f_10293_4030_4055(Microsoft.CodeAnalysis.CSharp.BoundExpression
                    this_param)
                    {
                        var return_v = this_param.ExpressionSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10293, 4030, 4055);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                    f_10293_3949_4072(Microsoft.CodeAnalysis.CSharp.ErrorCode
                    code, params object[]
                    args)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10293, 3949, 4072);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                    f_10293_4099_4112(Microsoft.CodeAnalysis.CSharp.BoundExpression
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10293, 4099, 4112);
                        return return_v;
                    }


                    bool?
                    f_10293_4113_4127(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type)
                    {
                        var return_v = type?.IsErrorType();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10293, 4113, 4127);
                        return return_v;
                    }


                    int
                    f_10293_4185_4215(Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics, Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                    info, Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax
                    syntax)
                    {
                        Error(diagnostics, (Microsoft.CodeAnalysis.DiagnosticInfo)info, (Microsoft.CodeAnalysis.SyntaxNode)syntax);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10293, 4185, 4215);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol?
                    f_10293_4429_4454(Microsoft.CodeAnalysis.CSharp.BoundExpression
                    this_param)
                    {
                        var return_v = this_param.ExpressionSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10293, 4429, 4454);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                    f_10293_4399_4455(Microsoft.CodeAnalysis.CSharp.Symbol?
                    item)
                    {
                        var return_v = ImmutableArray.Create<Symbol>(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10293, 4399, 4455);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10293_4504_4540(Microsoft.CodeAnalysis.CSharp.Binder.WithQueryLambdaParametersBinder
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    expression)
                    {
                        var return_v = this_param.BindToTypeForErrorRecovery(expression);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10293, 4504, 4540);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                    f_10293_4482_4541(Microsoft.CodeAnalysis.CSharp.BoundExpression
                    item)
                    {
                        var return_v = ImmutableArray.Create(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10293, 4482, 4541);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    f_10293_4596_4612(Microsoft.CodeAnalysis.CSharp.Binder.WithQueryLambdaParametersBinder
                    this_param)
                    {
                        var return_v = this_param.Compilation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10293, 4596, 4612);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol
                    f_10293_4568_4626(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    compilation, string
                    name, int
                    arity, Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                    errorInfo)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol(compilation, name, arity, (Microsoft.CodeAnalysis.DiagnosticInfo)errorInfo);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10293, 4568, 4626);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundBadExpression
                    f_10293_4270_4627(Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax
                    syntax, Microsoft.CodeAnalysis.CSharp.LookupResultKind
                    resultKind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                    symbols, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                    childBoundNodes, Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol
                    type)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.BoundBadExpression((Microsoft.CodeAnalysis.SyntaxNode)syntax, resultKind, symbols, childBoundNodes, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10293, 4270, 4627);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.LookupResult
                    f_10293_4695_4721()
                    {
                        var return_v = LookupResult.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10293, 4695, 4721);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                    f_10293_4919_4932(Microsoft.CodeAnalysis.CSharp.BoundExpression
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10293, 4919, 4932);
                        return return_v;
                    }


                    int
                    f_10293_4879_5010(Microsoft.CodeAnalysis.CSharp.Binder.WithQueryLambdaParametersBinder
                    this_param, Microsoft.CodeAnalysis.CSharp.LookupResult
                    result, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                    nsOrType, string
                    name, int
                    arity, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                    useSiteDiagnostics, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                    basesBeingResolved, Microsoft.CodeAnalysis.CSharp.LookupOptions
                    options)
                    {
                        this_param.LookupMembersWithFallback(result, (Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol?)nsOrType, name, arity, ref useSiteDiagnostics, basesBeingResolved: basesBeingResolved, options: options);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10293, 4879, 5010);
                        return 0;
                    }


                    bool
                    f_10293_5029_5070(Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics, Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax
                    node, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                    useSiteDiagnostics)
                    {
                        var return_v = diagnostics.Add((Microsoft.CodeAnalysis.SyntaxNode)node, useSiteDiagnostics);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10293, 5029, 5070);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10293_5104_5310(Microsoft.CodeAnalysis.CSharp.Binder.WithQueryLambdaParametersBinder
                    this_param, Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax
                    node, Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax
                    right, string
                    plainName, int
                    arity, bool
                    indexed, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    left, Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax>
                    typeArgumentsSyntax, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    typeArgumentsWithAnnotations, Microsoft.CodeAnalysis.CSharp.LookupResult
                    lookupResult, Microsoft.CodeAnalysis.CSharp.BoundMethodGroupFlags
                    methodGroupFlags, Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics)
                    {
                        var return_v = this_param.BindMemberOfType((Microsoft.CodeAnalysis.SyntaxNode)node, (Microsoft.CodeAnalysis.SyntaxNode)right, plainName, arity, indexed: indexed, left, typeArgumentsSyntax, typeArgumentsWithAnnotations, lookupResult, methodGroupFlags, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10293, 5104, 5310);
                        return return_v;
                    }


                    int
                    f_10293_5329_5348(Microsoft.CodeAnalysis.CSharp.LookupResult
                    this_param)
                    {
                        this_param.Free();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10293, 5329, 5348);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10293, 3359, 5396);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10293, 3359, 5396);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override void LookupSymbolsInSingleBinder(
                            LookupResult result, string name, int arity, ConsList<TypeSymbol> basesBeingResolved, LookupOptions options, Binder originalBinder, bool diagnose, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10293, 5412, 6145);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10293, 5708, 5737);

                    f_10293_5708_5736(f_10293_5721_5735(result));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10293, 5757, 5880) || true) && ((options & LookupOptions.NamespaceAliasesOnly) != 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10293, 5757, 5880);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10293, 5854, 5861);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10293, 5757, 5880);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10293, 5900, 6130);
                        foreach (var rangeVariable in f_10293_5930_5949_I(f_10293_5930_5949(_parameterMap, name)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10293, 5900, 6130);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10293, 5991, 6111);

                            f_10293_5991_6110(result, f_10293_6009_6109(originalBinder, rangeVariable, arity, options, null, diagnose, ref useSiteDiagnostics));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10293, 5900, 6130);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10293, 1, 231);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10293, 1, 231);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10293, 5412, 6145);

                    bool
                    f_10293_5721_5735(Microsoft.CodeAnalysis.CSharp.LookupResult
                    this_param)
                    {
                        var return_v = this_param.IsClear;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10293, 5721, 5735);
                        return return_v;
                    }


                    int
                    f_10293_5708_5736(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10293, 5708, 5736);
                        return 0;
                    }


                    Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol>.ValueSet
                    f_10293_5930_5949(Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol>
                    this_param, string
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10293, 5930, 5949);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.SingleLookupResult
                    f_10293_6009_6109(Microsoft.CodeAnalysis.CSharp.Binder
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                    symbol, int
                    arity, Microsoft.CodeAnalysis.CSharp.LookupOptions
                    options, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    accessThroughType, bool
                    diagnose, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                    useSiteDiagnostics)
                    {
                        var return_v = this_param.CheckViability((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, arity, options, accessThroughType, diagnose, ref useSiteDiagnostics);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10293, 6009, 6109);
                        return return_v;
                    }


                    int
                    f_10293_5991_6110(Microsoft.CodeAnalysis.CSharp.LookupResult
                    this_param, Microsoft.CodeAnalysis.CSharp.SingleLookupResult
                    result)
                    {
                        this_param.MergeEqual(result);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10293, 5991, 6110);
                        return 0;
                    }


                    Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol>.ValueSet
                    f_10293_5930_5949_I(Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol>.ValueSet
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10293, 5930, 5949);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10293, 5412, 6145);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10293, 5412, 6145);
                }
            }

            protected override void AddLookupSymbolsInfoInSingleBinder(LookupSymbolsInfo result, LookupOptions options, Binder originalBinder)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10293, 6161, 6573);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10293, 6324, 6558) || true) && (f_10293_6328_6356(options))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10293, 6324, 6558);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10293, 6398, 6539);
                            foreach (var kvp in f_10293_6418_6431_I(_parameterMap))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10293, 6398, 6539);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10293, 6481, 6516);

                                f_10293_6481_6515(result, null, kvp.Key, 0);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10293, 6398, 6539);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10293, 1, 142);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10293, 1, 142);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10293, 6324, 6558);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10293, 6161, 6573);

                    bool
                    f_10293_6328_6356(Microsoft.CodeAnalysis.CSharp.LookupOptions
                    options)
                    {
                        var return_v = options.CanConsiderMembers();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10293, 6328, 6356);
                        return return_v;
                    }


                    int
                    f_10293_6481_6515(Microsoft.CodeAnalysis.CSharp.LookupSymbolsInfo
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                    symbol, string
                    name, int
                    arity)
                    {
                        this_param.AddSymbol(symbol, name, arity);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10293, 6481, 6515);
                        return 0;
                    }


                    Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol>
                    f_10293_6418_6431_I(Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10293, 6418, 6431);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10293, 6161, 6573);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10293, 6161, 6573);
                }
            }

            static WithQueryLambdaParametersBinder()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10293, 760, 6584);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10293, 760, 6584);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10293, 760, 6584);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10293, 760, 6584);

            Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol>
            f_10293_1285_1335()
            {
                var return_v = new Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10293, 1285, 1335);
                return return_v;
            }


            System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol, System.Collections.Immutable.ImmutableArray<string>>.KeyCollection
            f_10293_1373_1394(Microsoft.CodeAnalysis.CSharp.Binder.RangeVariableMap
            this_param)
            {
                var return_v = this_param.Keys;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10293, 1373, 1394);
                return return_v;
            }


            string
            f_10293_1454_1461(Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
            this_param)
            {
                var return_v = this_param.Name;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10293, 1454, 1461);
                return return_v;
            }


            bool
            f_10293_1436_1466(Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol>
            this_param, string
            k, Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
            v)
            {
                var return_v = this_param.Add(k, v);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10293, 1436, 1466);
                return return_v;
            }


            System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol, System.Collections.Immutable.ImmutableArray<string>>.KeyCollection
            f_10293_1373_1394_I(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol, System.Collections.Immutable.ImmutableArray<string>>.KeyCollection
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10293, 1373, 1394);
                return return_v;
            }


            static Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
            f_10293_1162_1174_C(Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10293, 1024, 1501);
                return return_v;
            }

        }
    }
}
