// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal partial class Binder
    {
        private class QueryTranslationState
        {
            public BoundExpression fromExpression;

            public RangeVariableSymbol rangeVariable;

            public readonly Stack<QueryClauseSyntax> clauses;

            public SelectOrGroupClauseSyntax selectOrGroup;

            public readonly Dictionary<RangeVariableSymbol, ArrayBuilder<string>> allRangeVariables;

            public static RangeVariableMap RangeVariableMap(params RangeVariableSymbol[] parameters)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10289, 2237, 2598);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10289, 2358, 2394);

                    var
                    result = f_10289_2371_2393()
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10289, 2412, 2551);
                        foreach (var vars in f_10289_2433_2443_I(parameters))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10289, 2412, 2551);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10289, 2485, 2532);

                            f_10289_2485_2531(result, vars, ImmutableArray<string>.Empty);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10289, 2412, 2551);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10289, 1, 140);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10289, 1, 140);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10289, 2569, 2583);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10289, 2237, 2598);

                    Microsoft.CodeAnalysis.CSharp.Binder.RangeVariableMap
                    f_10289_2371_2393()
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Binder.RangeVariableMap();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10289, 2371, 2393);
                        return return_v;
                    }


                    int
                    f_10289_2485_2531(Microsoft.CodeAnalysis.CSharp.Binder.RangeVariableMap
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                    key, System.Collections.Immutable.ImmutableArray<string>
                    value)
                    {
                        this_param.Add(key, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10289, 2485, 2531);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol[]
                    f_10289_2433_2443_I(Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol[]
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10289, 2433, 2443);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10289, 2237, 2598);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10289, 2237, 2598);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public RangeVariableMap RangeVariableMap()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10289, 2614, 2950);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10289, 2689, 2725);

                    var
                    result = f_10289_2702_2724()
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10289, 2743, 2903);
                        foreach (var vars in f_10289_2764_2786_I(f_10289_2764_2786(allRangeVariables)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10289, 2743, 2903);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10289, 2828, 2884);

                            f_10289_2828_2883(result, vars, f_10289_2845_2882(f_10289_2845_2868(allRangeVariables, vars)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10289, 2743, 2903);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10289, 1, 161);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10289, 1, 161);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10289, 2921, 2935);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10289, 2614, 2950);

                    Microsoft.CodeAnalysis.CSharp.Binder.RangeVariableMap
                    f_10289_2702_2724()
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Binder.RangeVariableMap();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10289, 2702, 2724);
                        return return_v;
                    }


                    System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>>.KeyCollection
                    f_10289_2764_2786(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>>
                    this_param)
                    {
                        var return_v = this_param.Keys;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10289, 2764, 2786);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                    f_10289_2845_2868(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>>
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10289, 2845, 2868);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<string>
                    f_10289_2845_2882(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                    this_param)
                    {
                        var return_v = this_param.ToImmutable();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10289, 2845, 2882);
                        return return_v;
                    }


                    int
                    f_10289_2828_2883(Microsoft.CodeAnalysis.CSharp.Binder.RangeVariableMap
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                    key, System.Collections.Immutable.ImmutableArray<string>
                    value)
                    {
                        this_param.Add(key, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10289, 2828, 2883);
                        return 0;
                    }


                    System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>>.KeyCollection
                    f_10289_2764_2786_I(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>>.KeyCollection
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10289, 2764, 2786);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10289, 2614, 2950);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10289, 2614, 2950);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal RangeVariableSymbol AddRangeVariable(Binder binder, SyntaxToken identifier, DiagnosticBag diagnostics)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10289, 2966, 4062);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10289, 3110, 3145);

                    string
                    name = identifier.ValueText
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10289, 3163, 3265);

                    var
                    result = f_10289_3176_3264(name, f_10289_3206_3237(binder), identifier.GetLocation())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10289, 3283, 3302);

                    bool
                    error = false
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10289, 3322, 3684);
                        foreach (var existingRangeVariable in f_10289_3360_3382_I(f_10289_3360_3382(allRangeVariables)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10289, 3322, 3684);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10289, 3424, 3665) || true) && (f_10289_3428_3454(existingRangeVariable) == name)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10289, 3424, 3665);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10289, 3512, 3603);

                                f_10289_3512_3602(diagnostics, ErrorCode.ERR_QueryDuplicateRangeVariable, identifier.GetLocation(), name);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10289, 3629, 3642);

                                error = true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10289, 3424, 3665);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10289, 3322, 3684);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10289, 1, 363);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10289, 1, 363);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10289, 3704, 3929) || true) && (!error)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10289, 3704, 3929);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10289, 3756, 3809);

                        var
                        collisionDetector = f_10289_3780_3808(binder)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10289, 3831, 3910);

                        f_10289_3831_3909(collisionDetector, result, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10289, 3704, 3929);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10289, 3949, 4015);

                    f_10289_3949_4014(
                                    allRangeVariables, result, f_10289_3979_4013());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10289, 4033, 4047);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10289, 2966, 4062);

                    Microsoft.CodeAnalysis.CSharp.Symbol?
                    f_10289_3206_3237(Microsoft.CodeAnalysis.CSharp.Binder
                    this_param)
                    {
                        var return_v = this_param.ContainingMemberOrLambda;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10289, 3206, 3237);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                    f_10289_3176_3264(string
                    Name, Microsoft.CodeAnalysis.CSharp.Symbol?
                    containingSymbol, Microsoft.CodeAnalysis.Location
                    location)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol(Name, containingSymbol, location);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10289, 3176, 3264);
                        return return_v;
                    }


                    System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>>.KeyCollection
                    f_10289_3360_3382(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>>
                    this_param)
                    {
                        var return_v = this_param.Keys;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10289, 3360, 3382);
                        return return_v;
                    }


                    string
                    f_10289_3428_3454(Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10289, 3428, 3454);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                    f_10289_3512_3602(Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                    code, Microsoft.CodeAnalysis.Location
                    location, params object[]
                    args)
                    {
                        var return_v = diagnostics.Add(code, location, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10289, 3512, 3602);
                        return return_v;
                    }


                    System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>>.KeyCollection
                    f_10289_3360_3382_I(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>>.KeyCollection
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10289, 3360, 3382);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.LocalScopeBinder
                    f_10289_3780_3808(Microsoft.CodeAnalysis.CSharp.Binder
                    next)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.LocalScopeBinder(next);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10289, 3780, 3808);
                        return return_v;
                    }


                    bool
                    f_10289_3831_3909(Microsoft.CodeAnalysis.CSharp.LocalScopeBinder
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                    symbol, Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics)
                    {
                        var return_v = this_param.ValidateDeclarationNameConflictsInScope((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10289, 3831, 3909);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                    f_10289_3979_4013()
                    {
                        var return_v = ArrayBuilder<string>.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10289, 3979, 4013);
                        return return_v;
                    }


                    int
                    f_10289_3949_4014(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>>
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                    key, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                    value)
                    {
                        this_param.Add(key, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10289, 3949, 4014);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10289, 2966, 4062);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10289, 2966, 4062);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal void AddTransparentIdentifier(string name)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10289, 4274, 4488);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10289, 4358, 4473);
                        foreach (var b in f_10289_4376_4400_I(f_10289_4376_4400(allRangeVariables)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10289, 4358, 4473);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10289, 4442, 4454);

                            f_10289_4442_4453(b, name);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10289, 4358, 4473);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10289, 1, 116);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10289, 1, 116);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10289, 4274, 4488);

                    System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>>.ValueCollection
                    f_10289_4376_4400(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>>
                    this_param)
                    {
                        var return_v = this_param.Values;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10289, 4376, 4400);
                        return return_v;
                    }


                    int
                    f_10289_4442_4453(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                    this_param, string
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10289, 4442, 4453);
                        return 0;
                    }


                    System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>>.ValueCollection
                    f_10289_4376_4400_I(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>>.ValueCollection
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10289, 4376, 4400);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10289, 4274, 4488);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10289, 4274, 4488);
                }
            }

            private int _nextTransparentIdentifierNumber;

            internal string TransparentRangeVariableName()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10289, 4565, 4731);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10289, 4644, 4716);

                    return transparentIdentifierPrefix + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (_nextTransparentIdentifierNumber++).ToString(), 10289, 4681, 4715);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10289, 4565, 4731);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10289, 4565, 4731);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10289, 4565, 4731);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal RangeVariableSymbol TransparentRangeVariable(Binder binder)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10289, 4747, 5039);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10289, 4848, 4907);

                    var
                    transparentIdentifier = f_10289_4876_4906(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10289, 4925, 5024);

                    return f_10289_4932_5023(transparentIdentifier, f_10289_4979_5010(binder), null, true);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10289, 4747, 5039);

                    string
                    f_10289_4876_4906(Microsoft.CodeAnalysis.CSharp.Binder.QueryTranslationState
                    this_param)
                    {
                        var return_v = this_param.TransparentRangeVariableName();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10289, 4876, 4906);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol?
                    f_10289_4979_5010(Microsoft.CodeAnalysis.CSharp.Binder
                    this_param)
                    {
                        var return_v = this_param.ContainingMemberOrLambda;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10289, 4979, 5010);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                    f_10289_4932_5023(string
                    Name, Microsoft.CodeAnalysis.CSharp.Symbol?
                    containingSymbol, Microsoft.CodeAnalysis.Location
                    location, bool
                    isTransparent)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol(Name, containingSymbol, location, isTransparent);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10289, 4932, 5023);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10289, 4747, 5039);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10289, 4747, 5039);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public void Clear()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10289, 5055, 5371);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10289, 5107, 5129);

                    fromExpression = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10289, 5147, 5168);

                    rangeVariable = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10289, 5186, 5207);

                    selectOrGroup = null;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10289, 5225, 5278);
                        foreach (var b in f_10289_5243_5267_I(f_10289_5243_5267(allRangeVariables)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10289, 5225, 5278);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10289, 5269, 5278);

                            f_10289_5269_5277(b);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10289, 5225, 5278);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10289, 1, 54);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10289, 1, 54);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10289, 5296, 5322);

                    f_10289_5296_5321(allRangeVariables);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10289, 5340, 5356);

                    f_10289_5340_5355(clauses);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10289, 5055, 5371);

                    System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>>.ValueCollection
                    f_10289_5243_5267(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>>
                    this_param)
                    {
                        var return_v = this_param.Values;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10289, 5243, 5267);
                        return return_v;
                    }


                    int
                    f_10289_5269_5277(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                    this_param)
                    {
                        this_param.Free();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10289, 5269, 5277);
                        return 0;
                    }


                    System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>>.ValueCollection
                    f_10289_5243_5267_I(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>>.ValueCollection
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10289, 5243, 5267);
                        return return_v;
                    }


                    int
                    f_10289_5296_5321(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>>
                    this_param)
                    {
                        this_param.Clear();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10289, 5296, 5321);
                        return 0;
                    }


                    int
                    f_10289_5340_5355(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.CSharp.Syntax.QueryClauseSyntax>
                    this_param)
                    {
                        this_param.Clear();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10289, 5340, 5355);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10289, 5055, 5371);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10289, 5055, 5371);
                }
            }

            public void Free()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10289, 5387, 5461);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10289, 5438, 5446);

                    f_10289_5438_5445(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10289, 5387, 5461);

                    int
                    f_10289_5438_5445(Microsoft.CodeAnalysis.CSharp.Binder.QueryTranslationState
                    this_param)
                    {
                        this_param.Clear();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10289, 5438, 5445);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10289, 5387, 5461);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10289, 5387, 5461);
                }
            }

            public QueryTranslationState()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10289, 533, 5472);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10289, 801, 815);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10289, 945, 958);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10289, 1097, 1137);
                this.clauses = f_10289_1107_1137(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10289, 1262, 1275);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10289, 2141, 2220);
                this.allRangeVariables = f_10289_2161_2220(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10289, 4516, 4548);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10289, 533, 5472);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10289, 533, 5472);
            }


            static QueryTranslationState()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10289, 533, 5472);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10289, 533, 5472);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10289, 533, 5472);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10289, 533, 5472);

            System.Collections.Generic.Stack<Microsoft.CodeAnalysis.CSharp.Syntax.QueryClauseSyntax>
            f_10289_1107_1137()
            {
                var return_v = new System.Collections.Generic.Stack<Microsoft.CodeAnalysis.CSharp.Syntax.QueryClauseSyntax>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10289, 1107, 1137);
                return return_v;
            }


            System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>>
            f_10289_2161_2220()
            {
                var return_v = new System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10289, 2161, 2220);
                return return_v;
            }

        }
    }
}
