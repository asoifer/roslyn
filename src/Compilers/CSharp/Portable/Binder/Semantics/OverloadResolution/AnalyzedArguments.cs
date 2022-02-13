// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed class AnalyzedArguments
    {
        public readonly ArrayBuilder<BoundExpression> Arguments;

        public readonly ArrayBuilder<IdentifierNameSyntax> Names;

        public readonly ArrayBuilder<RefKind> RefKinds;

        public bool IsExtensionMethodInvocation;

        private ThreeState _lazyHasDynamicArgument;

        internal AnalyzedArguments()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10865, 878, 1127);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10865, 629, 638);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10865, 700, 705);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10865, 754, 762);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10865, 785, 812);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10865, 842, 865);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10865, 931, 986);

                this.Arguments = f_10865_948_985(32);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10865, 1000, 1056);

                this.Names = f_10865_1013_1055(32);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10865, 1070, 1116);

                this.RefKinds = f_10865_1086_1115(32);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10865, 878, 1127);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10865, 878, 1127);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10865, 878, 1127);
            }
        }

        public void Clear()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10865, 1139, 1400);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10865, 1183, 1206);

                f_10865_1183_1205(this.Arguments);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10865, 1220, 1239);

                f_10865_1220_1238(this.Names);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10865, 1253, 1275);

                f_10865_1253_1274(this.RefKinds);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10865, 1289, 1330);

                this.IsExtensionMethodInvocation = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10865, 1344, 1389);

                _lazyHasDynamicArgument = ThreeState.Unknown;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10865, 1139, 1400);

                int
                f_10865_1183_1205(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10865, 1183, 1205);
                    return 0;
                }


                int
                f_10865_1220_1238(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10865, 1220, 1238);
                    return 0;
                }


                int
                f_10865_1253_1274(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.RefKind>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10865, 1253, 1274);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10865, 1139, 1400);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10865, 1139, 1400);
            }
        }

        public BoundExpression Argument(int i)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10865, 1412, 1506);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10865, 1475, 1495);

                return f_10865_1482_1494(Arguments, i);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10865, 1412, 1506);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10865_1482_1494(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10865, 1482, 1494);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10865, 1412, 1506);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10865, 1412, 1506);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public string Name(int i)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10865, 1518, 1788);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10865, 1568, 1649) || true) && (f_10865_1572_1583(Names) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10865, 1568, 1649);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10865, 1622, 1634);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10865, 1568, 1649);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10865, 1665, 1704);

                IdentifierNameSyntax
                syntax = f_10865_1695_1703(Names, i)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10865, 1718, 1777);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10865, 1725, 1739) || ((syntax == null && DynAbs.Tracing.TraceSender.Conditional_F2(10865, 1742, 1746)) || DynAbs.Tracing.TraceSender.Conditional_F3(10865, 1749, 1776))) ? null : syntax.Identifier.ValueText;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10865, 1518, 1788);

                int
                f_10865_1572_1583(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10865, 1572, 1583);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                f_10865_1695_1703(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10865, 1695, 1703);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10865, 1518, 1788);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10865, 1518, 1788);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public ImmutableArray<string> GetNames()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10865, 1800, 2257);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10865, 1865, 1894);

                int
                count = f_10865_1877_1893(this.Names)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10865, 1910, 1988) || true) && (count == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10865, 1910, 1988);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10865, 1958, 1973);

                    return default;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10865, 1910, 1988);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10865, 2004, 2069);

                var
                builder = f_10865_2018_2068(f_10865_2051_2067(this.Names))
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10865, 2092, 2097);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10865, 2083, 2194) || true) && (i < f_10865_2103_2119(this.Names))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10865, 2121, 2124)
        , ++i, DynAbs.Tracing.TraceSender.TraceExitCondition(10865, 2083, 2194))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10865, 2083, 2194);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10865, 2158, 2179);

                        f_10865_2158_2178(builder, f_10865_2170_2177(this, i));
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10865, 1, 112);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10865, 1, 112);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10865, 2210, 2246);

                return f_10865_2217_2245(builder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10865, 1800, 2257);

                int
                f_10865_1877_1893(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10865, 1877, 1893);
                    return return_v;
                }


                int
                f_10865_2051_2067(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10865, 2051, 2067);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                f_10865_2018_2068(int
                capacity)
                {
                    var return_v = ArrayBuilder<string>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10865, 2018, 2068);
                    return return_v;
                }


                int
                f_10865_2103_2119(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10865, 2103, 2119);
                    return return_v;
                }


                string
                f_10865_2170_2177(Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                this_param, int
                i)
                {
                    var return_v = this_param.Name(i);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10865, 2170, 2177);
                    return return_v;
                }


                int
                f_10865_2158_2178(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10865, 2158, 2178);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_10865_2217_2245(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10865, 2217, 2245);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10865, 1800, 2257);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10865, 1800, 2257);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public RefKind RefKind(int i)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10865, 2269, 2412);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10865, 2323, 2401);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10865, 2330, 2348) || ((f_10865_2330_2344(RefKinds) > 0 && DynAbs.Tracing.TraceSender.Conditional_F2(10865, 2351, 2362)) || DynAbs.Tracing.TraceSender.Conditional_F3(10865, 2365, 2400))) ? f_10865_2351_2362(RefKinds, i) : Microsoft.CodeAnalysis.RefKind.None;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10865, 2269, 2412);

                int
                f_10865_2330_2344(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.RefKind>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10865, 2330, 2344);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10865_2351_2362(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.RefKind>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10865, 2351, 2362);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10865, 2269, 2412);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10865, 2269, 2412);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool IsExtensionMethodThisArgument(int i)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10865, 2424, 2560);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10865, 2497, 2549);

                return (i == 0) && (DynAbs.Tracing.TraceSender.Expression_True(10865, 2504, 2548) && this.IsExtensionMethodInvocation);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10865, 2424, 2560);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10865, 2424, 2560);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10865, 2424, 2560);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool HasDynamicArgument
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10865, 2627, 3510);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10865, 2663, 2801) || true) && (f_10865_2667_2701(_lazyHasDynamicArgument))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10865, 2663, 2801);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10865, 2743, 2782);

                        return f_10865_2750_2781(_lazyHasDynamicArgument);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10865, 2663, 2801);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10865, 2821, 2859);

                    bool
                    hasRefKinds = f_10865_2840_2854(RefKinds) > 0
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10865, 2886, 2891);
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10865, 2877, 3401) || true) && (i < f_10865_2897_2912(Arguments))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10865, 2914, 2917)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10865, 2877, 3401))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10865, 2877, 3401);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10865, 2959, 2987);

                            var
                            argument = f_10865_2974_2986(Arguments, i)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10865, 3095, 3382) || true) && ((object)f_10865_3107_3120(argument) != null && (DynAbs.Tracing.TraceSender.Expression_True(10865, 3099, 3157) && f_10865_3132_3157(f_10865_3132_3145(argument))) && (DynAbs.Tracing.TraceSender.Expression_True(10865, 3099, 3229) && (!hasRefKinds || (DynAbs.Tracing.TraceSender.Expression_False(10865, 3162, 3228) || f_10865_3178_3189(RefKinds, i) == Microsoft.CodeAnalysis.RefKind.None))))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10865, 3095, 3382);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10865, 3279, 3321);

                                _lazyHasDynamicArgument = ThreeState.True;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10865, 3347, 3359);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10865, 3095, 3382);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10865, 1, 525);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10865, 1, 525);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10865, 3421, 3464);

                    _lazyHasDynamicArgument = ThreeState.False;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10865, 3482, 3495);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10865, 2627, 3510);

                    bool
                    f_10865_2667_2701(Microsoft.CodeAnalysis.ThreeState
                    value)
                    {
                        var return_v = value.HasValue();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10865, 2667, 2701);
                        return return_v;
                    }


                    bool
                    f_10865_2750_2781(Microsoft.CodeAnalysis.ThreeState
                    value)
                    {
                        var return_v = value.Value();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10865, 2750, 2781);
                        return return_v;
                    }


                    int
                    f_10865_2840_2854(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.RefKind>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10865, 2840, 2854);
                        return return_v;
                    }


                    int
                    f_10865_2897_2912(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10865, 2897, 2912);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10865_2974_2986(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10865, 2974, 2986);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                    f_10865_3107_3120(Microsoft.CodeAnalysis.CSharp.BoundExpression
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10865, 3107, 3120);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10865_3132_3145(Microsoft.CodeAnalysis.CSharp.BoundExpression
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10865, 3132, 3145);
                        return return_v;
                    }


                    bool
                    f_10865_3132_3157(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type)
                    {
                        var return_v = type.IsDynamic();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10865, 3132, 3157);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.RefKind
                    f_10865_3178_3189(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.RefKind>
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10865, 3178, 3189);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10865, 2572, 3521);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10865, 2572, 3521);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool HasErrors
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10865, 3579, 3873);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10865, 3615, 3825);
                        foreach (var argument in f_10865_3640_3654_I(this.Arguments))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10865, 3615, 3825);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10865, 3696, 3806) || true) && (f_10865_3700_3721(argument))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10865, 3696, 3806);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10865, 3771, 3783);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10865, 3696, 3806);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10865, 3615, 3825);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10865, 1, 211);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10865, 1, 211);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10865, 3845, 3858);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10865, 3579, 3873);

                    bool
                    f_10865_3700_3721(Microsoft.CodeAnalysis.CSharp.BoundExpression
                    this_param)
                    {
                        var return_v = this_param.HasAnyErrors;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10865, 3700, 3721);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                    f_10865_3640_3654_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10865, 3640, 3654);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10865, 3533, 3884);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10865, 3533, 3884);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static AnalyzedArguments GetInstance()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10865, 3926, 4030);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10865, 3996, 4019);

                return f_10865_4003_4018(Pool);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10865, 3926, 4030);

                Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                f_10865_4003_4018(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.CSharp.AnalyzedArguments>
                this_param)
                {
                    var return_v = this_param.Allocate();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10865, 4003, 4018);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10865, 3926, 4030);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10865, 3926, 4030);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static AnalyzedArguments GetInstance(AnalyzedArguments original)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10865, 4042, 4556);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10865, 4138, 4167);

                var
                instance = f_10865_4153_4166()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10865, 4181, 4229);

                f_10865_4181_4228(instance.Arguments, original.Arguments);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10865, 4243, 4283);

                f_10865_4243_4282(instance.Names, original.Names);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10865, 4297, 4343);

                f_10865_4297_4342(instance.RefKinds, original.RefKinds);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10865, 4357, 4433);

                instance.IsExtensionMethodInvocation = original.IsExtensionMethodInvocation;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10865, 4447, 4515);

                instance._lazyHasDynamicArgument = original._lazyHasDynamicArgument;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10865, 4529, 4545);

                return instance;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10865, 4042, 4556);

                Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                f_10865_4153_4166()
                {
                    var return_v = GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10865, 4153, 4166);
                    return return_v;
                }


                int
                f_10865_4181_4228(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10865, 4181, 4228);
                    return 0;
                }


                int
                f_10865_4243_4282(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax>
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax>
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10865, 4243, 4282);
                    return 0;
                }


                int
                f_10865_4297_4342(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.RefKind>
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.RefKind>
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10865, 4297, 4342);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10865, 4042, 4556);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10865, 4042, 4556);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static AnalyzedArguments GetInstance(
                    ImmutableArray<BoundExpression> arguments,
                    ImmutableArray<RefKind> argumentRefKindsOpt,
                    ImmutableArray<IdentifierNameSyntax> argumentNamesOpt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10865, 4568, 5227);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10865, 4819, 4848);

                var
                instance = f_10865_4834_4847()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10865, 4862, 4901);

                f_10865_4862_4900(instance.Arguments, arguments);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10865, 4915, 5046) || true) && (f_10865_4919_4949_M(!argumentRefKindsOpt.IsDefault))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10865, 4915, 5046);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10865, 4983, 5031);

                    f_10865_4983_5030(instance.RefKinds, argumentRefKindsOpt);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10865, 4915, 5046);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10865, 5062, 5184) || true) && (f_10865_5066_5093_M(!argumentNamesOpt.IsDefault))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10865, 5062, 5184);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10865, 5127, 5169);

                    f_10865_5127_5168(instance.Names, argumentNamesOpt);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10865, 5062, 5184);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10865, 5200, 5216);

                return instance;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10865, 4568, 5227);

                Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                f_10865_4834_4847()
                {
                    var return_v = GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10865, 4834, 4847);
                    return return_v;
                }


                int
                f_10865_4862_4900(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10865, 4862, 4900);
                    return 0;
                }


                bool
                f_10865_4919_4949_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10865, 4919, 4949);
                    return return_v;
                }


                int
                f_10865_4983_5030(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.RefKind>
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10865, 4983, 5030);
                    return 0;
                }


                bool
                f_10865_5066_5093_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10865, 5066, 5093);
                    return return_v;
                }


                int
                f_10865_5127_5168(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax>
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax>
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10865, 5127, 5168);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10865, 4568, 5227);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10865, 4568, 5227);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void Free()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10865, 5239, 5336);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10865, 5282, 5295);

                f_10865_5282_5294(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10865, 5309, 5325);

                f_10865_5309_5324(Pool, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10865, 5239, 5336);

                int
                f_10865_5282_5294(Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10865, 5282, 5294);
                    return 0;
                }


                int
                f_10865_5309_5324(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.CSharp.AnalyzedArguments>
                this_param, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                obj)
                {
                    this_param.Free(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10865, 5309, 5324);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10865, 5239, 5336);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10865, 5239, 5336);
            }
        }

        public static readonly ObjectPool<AnalyzedArguments> Pool;

        private static ObjectPool<AnalyzedArguments> CreatePool()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10865, 5602, 5853);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10865, 5684, 5726);

                ObjectPool<AnalyzedArguments>
                pool = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10865, 5740, 5816);

                pool = f_10865_5747_5815(() => new AnalyzedArguments(), 10);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10865, 5830, 5842);

                return pool;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10865, 5602, 5853);

                Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.CSharp.AnalyzedArguments>
                f_10865_5747_5815(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.CSharp.AnalyzedArguments>.Factory
                factory, int
                size)
                {
                    var return_v = new Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.CSharp.AnalyzedArguments>(factory, size);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10865, 5747, 5815);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10865, 5602, 5853);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10865, 5602, 5853);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static AnalyzedArguments()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10865, 527, 5882);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10865, 5570, 5589);
            Pool = f_10865_5577_5589(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10865, 527, 5882);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10865, 527, 5882);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10865, 527, 5882);

        Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
        f_10865_948_985(int
        size)
        {
            var return_v = new Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>(size);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10865, 948, 985);
            return return_v;
        }


        Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax>
        f_10865_1013_1055(int
        size)
        {
            var return_v = new Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax>(size);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10865, 1013, 1055);
            return return_v;
        }


        Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.RefKind>
        f_10865_1086_1115(int
        size)
        {
            var return_v = new Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.RefKind>(size);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10865, 1086, 1115);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.CSharp.AnalyzedArguments>
        f_10865_5577_5589()
        {
            var return_v = CreatePool();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10865, 5577, 5589);
            return return_v;
        }

    }
}
