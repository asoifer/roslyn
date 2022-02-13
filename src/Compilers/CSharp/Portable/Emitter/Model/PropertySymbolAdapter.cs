// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.Cci;
using Microsoft.CodeAnalysis.CodeGen;
using Microsoft.CodeAnalysis.CSharp.Emit;
using Microsoft.CodeAnalysis.Emit;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal partial class
            PropertySymbolAdapter : SymbolAdapter,
            IPropertyDefinition
    {
        IEnumerable<IMethodReference> IPropertyDefinition.GetAccessors(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10206, 767, 1843);

                var listYield = new List<IMethodReference>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10206, 875, 902);

                f_10206_875_901(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10206, 918, 983);

                var
                getMethod = f_10206_934_982_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10206_934_965(f_10206_934_955()), 10206, 934, 982)?.GetCciAdapter())
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10206, 997, 1126) || true) && (getMethod != null && (DynAbs.Tracing.TraceSender.Expression_True(10206, 1001, 1054) && getMethod.ShouldInclude(context)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10206, 997, 1126);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10206, 1088, 1111);

                    listYield.Add(getMethod);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10206, 997, 1126);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10206, 1142, 1207);

                var
                setMethod = f_10206_1158_1206_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10206_1158_1189(f_10206_1158_1179()), 10206, 1158, 1206)?.GetCciAdapter())
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10206, 1221, 1350) || true) && (setMethod != null && (DynAbs.Tracing.TraceSender.Expression_True(10206, 1225, 1278) && setMethod.ShouldInclude(context)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10206, 1221, 1350);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10206, 1312, 1335);

                    listYield.Add(setMethod);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10206, 1221, 1350);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10206, 1366, 1437);

                var
                sourceProperty = f_10206_1387_1408() as SourcePropertySymbolBase
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10206, 1451, 1832) || true) && ((object)sourceProperty != null && (DynAbs.Tracing.TraceSender.Expression_True(10206, 1455, 1516) && this.ShouldInclude(context)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10206, 1451, 1832);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10206, 1550, 1650);

                    SynthesizedSealedPropertyAccessor
                    synthesizedAccessor = f_10206_1606_1649(sourceProperty)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10206, 1668, 1817) || true) && ((object)synthesizedAccessor != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10206, 1668, 1817);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10206, 1749, 1798);

                        listYield.Add(f_10206_1762_1797(synthesizedAccessor));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10206, 1668, 1817);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10206, 1451, 1832);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10206, 767, 1843);

                return listYield;

                int
                f_10206_875_901(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbolAdapter
                this_param)
                {
                    this_param.CheckDefinitionInvariant();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10206, 875, 901);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                f_10206_934_955()
                {
                    var return_v = AdaptedPropertySymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10206, 934, 955);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10206_934_965(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.GetMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10206, 934, 965);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter?
                f_10206_934_982_I(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10206, 934, 982);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                f_10206_1158_1179()
                {
                    var return_v = AdaptedPropertySymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10206, 1158, 1179);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10206_1158_1189(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.SetMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10206, 1158, 1189);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter?
                f_10206_1158_1206_I(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10206, 1158, 1206);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                f_10206_1387_1408()
                {
                    var return_v = AdaptedPropertySymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10206, 1387, 1408);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedSealedPropertyAccessor
                f_10206_1606_1649(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                this_param)
                {
                    var return_v = this_param.SynthesizedSealedAccessorOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10206, 1606, 1649);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                f_10206_1762_1797(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedSealedPropertyAccessor
                this_param)
                {
                    var return_v = this_param.GetCciAdapter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10206, 1762, 1797);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10206, 767, 1843);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10206, 767, 1843);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        MetadataConstant IPropertyDefinition.DefaultValue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10206, 1929, 2037);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10206, 1965, 1992);

                    f_10206_1965_1991(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10206, 2010, 2022);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10206, 1929, 2037);

                    int
                    f_10206_1965_1991(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbolAdapter
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10206, 1965, 1991);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10206, 1855, 2048);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10206, 1855, 2048);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        IMethodReference IPropertyDefinition.Getter
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10206, 2128, 2538);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10206, 2164, 2191);

                    f_10206_2164_2190(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10206, 2209, 2266);

                    MethodSymbol
                    getMethod = f_10206_2234_2265(f_10206_2234_2255())
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10206, 2284, 2443) || true) && ((object)getMethod != null || (DynAbs.Tracing.TraceSender.Expression_False(10206, 2288, 2348) || f_10206_2317_2348_M(!f_10206_2318_2339().IsSealed)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10206, 2284, 2443);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10206, 2390, 2424);

                        return f_10206_2397_2423_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(getMethod, 10206, 2397, 2423)?.GetCciAdapter());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10206, 2284, 2443);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10206, 2463, 2523);

                    return f_10206_2470_2522(this, MethodKind.PropertyGet);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10206, 2128, 2538);

                    int
                    f_10206_2164_2190(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbolAdapter
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10206, 2164, 2190);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    f_10206_2234_2255()
                    {
                        var return_v = AdaptedPropertySymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10206, 2234, 2255);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10206_2234_2265(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.GetMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10206, 2234, 2265);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    f_10206_2318_2339()
                    {
                        var return_v = AdaptedPropertySymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10206, 2318, 2339);
                        return return_v;
                    }


                    bool
                    f_10206_2317_2348_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10206, 2317, 2348);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter?
                    f_10206_2397_2423_I(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter?
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10206, 2397, 2423);
                        return return_v;
                    }


                    Microsoft.Cci.IMethodReference
                    f_10206_2470_2522(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbolAdapter
                    this_param, Microsoft.CodeAnalysis.MethodKind
                    targetMethodKind)
                    {
                        var return_v = this_param.GetSynthesizedSealedAccessor(targetMethodKind);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10206, 2470, 2522);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10206, 2060, 2549);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10206, 2060, 2549);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool IPropertyDefinition.HasDefaultValue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10206, 2626, 2735);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10206, 2662, 2689);

                    f_10206_2662_2688(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10206, 2707, 2720);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10206, 2626, 2735);

                    int
                    f_10206_2662_2688(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbolAdapter
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10206, 2662, 2688);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10206, 2561, 2746);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10206, 2561, 2746);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool IPropertyDefinition.IsRuntimeSpecial
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10206, 2824, 2971);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10206, 2860, 2887);

                    f_10206_2860_2886(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10206, 2905, 2956);

                    return f_10206_2912_2955(f_10206_2912_2933());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10206, 2824, 2971);

                    int
                    f_10206_2860_2886(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbolAdapter
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10206, 2860, 2886);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    f_10206_2912_2933()
                    {
                        var return_v = AdaptedPropertySymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10206, 2912, 2933);
                        return return_v;
                    }


                    bool
                    f_10206_2912_2955(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.HasRuntimeSpecialName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10206, 2912, 2955);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10206, 2758, 2982);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10206, 2758, 2982);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool IPropertyDefinition.IsSpecialName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10206, 3057, 3197);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10206, 3093, 3120);

                    f_10206_3093_3119(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10206, 3138, 3182);

                    return f_10206_3145_3181(f_10206_3145_3166());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10206, 3057, 3197);

                    int
                    f_10206_3093_3119(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbolAdapter
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10206, 3093, 3119);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    f_10206_3145_3166()
                    {
                        var return_v = AdaptedPropertySymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10206, 3145, 3166);
                        return return_v;
                    }


                    bool
                    f_10206_3145_3181(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.HasSpecialName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10206, 3145, 3181);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10206, 2994, 3208);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10206, 2994, 3208);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ImmutableArray<IParameterDefinition> IPropertyDefinition.Parameters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10206, 3312, 3648);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10206, 3348, 3375);

                    f_10206_3348_3374(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10206, 3404, 3521);

                    return f_10206_3411_3432().Parameters.SelectAsArray<ParameterSymbol, IParameterDefinition>(p => p.GetCciAdapter());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10206, 3312, 3648);

                    int
                    f_10206_3348_3374(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbolAdapter
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10206, 3348, 3374);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    f_10206_3411_3432()
                    {
                        var return_v = AdaptedPropertySymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10206, 3411, 3432);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10206, 3220, 3659);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10206, 3220, 3659);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        IMethodReference IPropertyDefinition.Setter
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10206, 3739, 4149);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10206, 3775, 3802);

                    f_10206_3775_3801(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10206, 3820, 3877);

                    MethodSymbol
                    setMethod = f_10206_3845_3876(f_10206_3845_3866())
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10206, 3895, 4054) || true) && ((object)setMethod != null || (DynAbs.Tracing.TraceSender.Expression_False(10206, 3899, 3959) || f_10206_3928_3959_M(!f_10206_3929_3950().IsSealed)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10206, 3895, 4054);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10206, 4001, 4035);

                        return f_10206_4008_4034_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(setMethod, 10206, 4008, 4034)?.GetCciAdapter());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10206, 3895, 4054);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10206, 4074, 4134);

                    return f_10206_4081_4133(this, MethodKind.PropertySet);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10206, 3739, 4149);

                    int
                    f_10206_3775_3801(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbolAdapter
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10206, 3775, 3801);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    f_10206_3845_3866()
                    {
                        var return_v = AdaptedPropertySymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10206, 3845, 3866);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10206_3845_3876(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.SetMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10206, 3845, 3876);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    f_10206_3929_3950()
                    {
                        var return_v = AdaptedPropertySymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10206, 3929, 3950);
                        return return_v;
                    }


                    bool
                    f_10206_3928_3959_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10206, 3928, 3959);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter?
                    f_10206_4008_4034_I(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter?
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10206, 4008, 4034);
                        return return_v;
                    }


                    Microsoft.Cci.IMethodReference
                    f_10206_4081_4133(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbolAdapter
                    this_param, Microsoft.CodeAnalysis.MethodKind
                    targetMethodKind)
                    {
                        var return_v = this_param.GetSynthesizedSealedAccessor(targetMethodKind);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10206, 4081, 4133);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10206, 3671, 4160);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10206, 3671, 4160);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        [Conditional("DEBUG")]
        private void CheckDefinitionInvariantAllowEmbedded()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10206, 4232, 4655);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10206, 4388, 4437);

                f_10206_4388_4436(f_10206_4401_4435(f_10206_4401_4422()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10206, 4516, 4644);

                f_10206_4516_4643(f_10206_4529_4567(f_10206_4529_4550()) is SourceModuleSymbol || (DynAbs.Tracing.TraceSender.Expression_False(10206, 4529, 4642) || f_10206_4593_4642(f_10206_4593_4633(f_10206_4593_4614()))));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10206, 4232, 4655);

                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                f_10206_4401_4422()
                {
                    var return_v = AdaptedPropertySymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10206, 4401, 4422);
                    return return_v;
                }


                bool
                f_10206_4401_4435(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.IsDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10206, 4401, 4435);
                    return return_v;
                }


                int
                f_10206_4388_4436(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10206, 4388, 4436);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                f_10206_4529_4550()
                {
                    var return_v = AdaptedPropertySymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10206, 4529, 4550);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                f_10206_4529_4567(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.ContainingModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10206, 4529, 4567);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                f_10206_4593_4614()
                {
                    var return_v = AdaptedPropertySymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10206, 4593, 4614);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10206_4593_4633(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10206, 4593, 4633);
                    return return_v;
                }


                bool
                f_10206_4593_4642(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.IsLinked;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10206, 4593, 4642);
                    return return_v;
                }


                int
                f_10206_4516_4643(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10206, 4516, 4643);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10206, 4232, 4655);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10206, 4232, 4655);
            }
        }

        CallingConvention ISignature.CallingConvention
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10206, 4738, 4894);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10206, 4774, 4814);

                    f_10206_4774_4813(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10206, 4832, 4879);

                    return f_10206_4839_4878(f_10206_4839_4860());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10206, 4738, 4894);

                    int
                    f_10206_4774_4813(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbolAdapter
                    this_param)
                    {
                        this_param.CheckDefinitionInvariantAllowEmbedded();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10206, 4774, 4813);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    f_10206_4839_4860()
                    {
                        var return_v = AdaptedPropertySymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10206, 4839, 4860);
                        return return_v;
                    }


                    Microsoft.Cci.CallingConvention
                    f_10206_4839_4878(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.CallingConvention;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10206, 4839, 4878);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10206, 4667, 4905);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10206, 4667, 4905);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ushort ISignature.ParameterCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10206, 4974, 5122);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10206, 5010, 5037);

                    f_10206_5010_5036(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10206, 5055, 5107);

                    return (ushort)f_10206_5070_5106(f_10206_5070_5091());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10206, 4974, 5122);

                    int
                    f_10206_5010_5036(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbolAdapter
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10206, 5010, 5036);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    f_10206_5070_5091()
                    {
                        var return_v = AdaptedPropertySymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10206, 5070, 5091);
                        return return_v;
                    }


                    int
                    f_10206_5070_5106(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.ParameterCount;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10206, 5070, 5106);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10206, 4917, 5133);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10206, 4917, 5133);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ImmutableArray<IParameterTypeInformation> ISignature.GetParameters(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10206, 5145, 5555);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10206, 5257, 5284);

                f_10206_5257_5283(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10206, 5309, 5431);

                return f_10206_5316_5337().Parameters.SelectAsArray<ParameterSymbol, IParameterTypeInformation>(p => p.GetCciAdapter());
                DynAbs.Tracing.TraceSender.TraceExitMethod(10206, 5145, 5555);

                int
                f_10206_5257_5283(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbolAdapter
                this_param)
                {
                    this_param.CheckDefinitionInvariant();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10206, 5257, 5283);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                f_10206_5316_5337()
                {
                    var return_v = AdaptedPropertySymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10206, 5316, 5337);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10206, 5145, 5555);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10206, 5145, 5555);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        ImmutableArray<ICustomModifier> ISignature.ReturnValueCustomModifiers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10206, 5661, 5857);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10206, 5697, 5737);

                    f_10206_5697_5736(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10206, 5755, 5842);

                    return f_10206_5762_5783().TypeWithAnnotations.CustomModifiers.As<ICustomModifier>();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10206, 5661, 5857);

                    int
                    f_10206_5697_5736(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbolAdapter
                    this_param)
                    {
                        this_param.CheckDefinitionInvariantAllowEmbedded();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10206, 5697, 5736);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    f_10206_5762_5783()
                    {
                        var return_v = AdaptedPropertySymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10206, 5762, 5783);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10206, 5567, 5868);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10206, 5567, 5868);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ImmutableArray<ICustomModifier> ISignature.RefCustomModifiers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10206, 5966, 6145);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10206, 6002, 6042);

                    f_10206_6002_6041(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10206, 6060, 6130);

                    return f_10206_6067_6088().RefCustomModifiers.As<ICustomModifier>();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10206, 5966, 6145);

                    int
                    f_10206_6002_6041(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbolAdapter
                    this_param)
                    {
                        this_param.CheckDefinitionInvariantAllowEmbedded();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10206, 6002, 6041);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    f_10206_6067_6088()
                    {
                        var return_v = AdaptedPropertySymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10206, 6067, 6088);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10206, 5880, 6156);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10206, 5880, 6156);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool ISignature.ReturnValueIsByRef
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10206, 6227, 6394);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10206, 6263, 6303);

                    f_10206_6263_6302(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10206, 6321, 6379);

                    return f_10206_6328_6378(f_10206_6328_6357(f_10206_6328_6349()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10206, 6227, 6394);

                    int
                    f_10206_6263_6302(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbolAdapter
                    this_param)
                    {
                        this_param.CheckDefinitionInvariantAllowEmbedded();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10206, 6263, 6302);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    f_10206_6328_6349()
                    {
                        var return_v = AdaptedPropertySymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10206, 6328, 6349);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.RefKind
                    f_10206_6328_6357(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.RefKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10206, 6328, 6357);
                        return return_v;
                    }


                    bool
                    f_10206_6328_6378(Microsoft.CodeAnalysis.RefKind
                    refKind)
                    {
                        var return_v = refKind.IsManagedReference();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10206, 6328, 6378);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10206, 6168, 6405);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10206, 6168, 6405);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ITypeReference ISignature.GetType(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10206, 6417, 6840);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10206, 6496, 6536);

                f_10206_6496_6535(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10206, 6550, 6829);

                return f_10206_6557_6828(((PEModuleBuilder)context.Module), f_10206_6601_6627(f_10206_6601_6622()), (CSharpSyntaxNode)context.SyntaxNodeOpt, diagnostics: context.Diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10206, 6417, 6840);

                int
                f_10206_6496_6535(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbolAdapter
                this_param)
                {
                    this_param.CheckDefinitionInvariantAllowEmbedded();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10206, 6496, 6535);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                f_10206_6601_6622()
                {
                    var return_v = AdaptedPropertySymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10206, 6601, 6622);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10206_6601_6627(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10206, 6601, 6627);
                    return return_v;
                }


                Microsoft.Cci.ITypeReference
                f_10206_6557_6828(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                typeSymbol, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.Translate(typeSymbol, syntaxNodeOpt: (Microsoft.CodeAnalysis.SyntaxNode)syntaxNodeOpt, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10206, 6557, 6828);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10206, 6417, 6840);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10206, 6417, 6840);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        ITypeDefinition ITypeDefinitionMember.ContainingTypeDefinition
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10206, 7010, 7166);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10206, 7046, 7073);

                    f_10206_7046_7072(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10206, 7091, 7151);

                    return f_10206_7098_7150(f_10206_7098_7134(f_10206_7098_7119()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10206, 7010, 7166);

                    int
                    f_10206_7046_7072(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbolAdapter
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10206, 7046, 7072);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    f_10206_7098_7119()
                    {
                        var return_v = AdaptedPropertySymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10206, 7098, 7119);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10206_7098_7134(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10206, 7098, 7134);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                    f_10206_7098_7150(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.GetCciAdapter();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10206, 7098, 7150);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10206, 6923, 7177);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10206, 6923, 7177);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        TypeMemberVisibility ITypeDefinitionMember.Visibility
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10206, 7267, 7426);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10206, 7303, 7330);

                    f_10206_7303_7329(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10206, 7348, 7411);

                    return f_10206_7355_7410(f_10206_7388_7409());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10206, 7267, 7426);

                    int
                    f_10206_7303_7329(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbolAdapter
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10206, 7303, 7329);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    f_10206_7388_7409()
                    {
                        var return_v = AdaptedPropertySymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10206, 7388, 7409);
                        return return_v;
                    }


                    Microsoft.Cci.TypeMemberVisibility
                    f_10206_7355_7410(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    symbol)
                    {
                        var return_v = PEModuleBuilder.MemberVisibility((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10206, 7355, 7410);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10206, 7189, 7437);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10206, 7189, 7437);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ITypeReference ITypeMemberReference.GetContainingType(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10206, 7519, 7730);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10206, 7618, 7645);

                f_10206_7618_7644(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10206, 7659, 7719);

                return f_10206_7666_7718(f_10206_7666_7702(f_10206_7666_7687()));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10206, 7519, 7730);

                int
                f_10206_7618_7644(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbolAdapter
                this_param)
                {
                    this_param.CheckDefinitionInvariant();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10206, 7618, 7644);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                f_10206_7666_7687()
                {
                    var return_v = AdaptedPropertySymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10206, 7666, 7687);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10206_7666_7702(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10206, 7666, 7702);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                f_10206_7666_7718(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetCciAdapter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10206, 7666, 7718);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10206, 7519, 7730);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10206, 7519, 7730);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        void IReference.Dispatch(MetadataVisitor visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10206, 7802, 7969);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10206, 7876, 7903);

                f_10206_7876_7902(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10206, 7917, 7958);

                f_10206_7917_7957(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10206, 7802, 7969);

                int
                f_10206_7876_7902(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbolAdapter
                this_param)
                {
                    this_param.CheckDefinitionInvariant();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10206, 7876, 7902);
                    return 0;
                }


                int
                f_10206_7917_7957(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbolAdapter
                propertyDefinition)
                {
                    this_param.Visit((Microsoft.Cci.IPropertyDefinition)propertyDefinition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10206, 7917, 7957);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10206, 7802, 7969);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10206, 7802, 7969);
            }
        }

        IDefinition IReference.AsDefinition(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10206, 7981, 8126);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10206, 8062, 8089);

                f_10206_8062_8088(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10206, 8103, 8115);

                return this;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10206, 7981, 8126);

                int
                f_10206_8062_8088(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbolAdapter
                this_param)
                {
                    this_param.CheckDefinitionInvariant();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10206, 8062, 8088);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10206, 7981, 8126);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10206, 7981, 8126);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        string INamedEntity.Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10206, 8249, 8387);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10206, 8285, 8312);

                    f_10206_8285_8311(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10206, 8330, 8372);

                    return f_10206_8337_8371(f_10206_8337_8358());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10206, 8249, 8387);

                    int
                    f_10206_8285_8311(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbolAdapter
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10206, 8285, 8311);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    f_10206_8337_8358()
                    {
                        var return_v = AdaptedPropertySymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10206, 8337, 8358);
                        return return_v;
                    }


                    string
                    f_10206_8337_8371(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.MetadataName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10206, 8337, 8371);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10206, 8200, 8398);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10206, 8200, 8398);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private IMethodReference GetSynthesizedSealedAccessor(MethodKind targetMethodKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10206, 8432, 8974);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10206, 8539, 8610);

                var
                sourceProperty = f_10206_8560_8581() as SourcePropertySymbolBase
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10206, 8624, 8935) || true) && ((object)sourceProperty != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10206, 8624, 8935);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10206, 8692, 8784);

                    SynthesizedSealedPropertyAccessor
                    synthesized = f_10206_8740_8783(sourceProperty)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10206, 8802, 8920);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10206, 8809, 8882) || (((object)synthesized != null && (DynAbs.Tracing.TraceSender.Expression_True(10206, 8809, 8882) && f_10206_8840_8862(synthesized) == targetMethodKind) && DynAbs.Tracing.TraceSender.Conditional_F2(10206, 8885, 8912)) || DynAbs.Tracing.TraceSender.Conditional_F3(10206, 8915, 8919))) ? f_10206_8885_8912(synthesized) : null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10206, 8624, 8935);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10206, 8951, 8963);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10206, 8432, 8974);

                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                f_10206_8560_8581()
                {
                    var return_v = AdaptedPropertySymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10206, 8560, 8581);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedSealedPropertyAccessor
                f_10206_8740_8783(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                this_param)
                {
                    var return_v = this_param.SynthesizedSealedAccessorOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10206, 8740, 8783);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10206_8840_8862(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedSealedPropertyAccessor
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10206, 8840, 8862);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                f_10206_8885_8912(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedSealedPropertyAccessor
                this_param)
                {
                    var return_v = this_param.GetCciAdapter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10206, 8885, 8912);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10206, 8432, 8974);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10206, 8432, 8974);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static PropertySymbolAdapter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10206, 551, 8981);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10206, 551, 8981);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10206, 551, 8981);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10206, 551, 8981);
    }
    internal partial class PropertySymbol
    {
        private PropertySymbolAdapter _lazyAdapter;

        protected sealed override SymbolAdapter GetCciAdapterImpl()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10206, 9169, 9187);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10206, 9172, 9187);
                return f_10206_9172_9187(this); DynAbs.Tracing.TraceSender.TraceExitMethod(10206, 9169, 9187);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10206, 9169, 9187);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10206, 9169, 9187);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbolAdapter
            f_10206_9172_9187(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
            this_param)
            {
                var return_v = this_param.GetCciAdapter();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10206, 9172, 9187);
                return return_v;
            }

        }

        internal new PropertySymbolAdapter GetCciAdapter()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10206, 9200, 9486);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10206, 9275, 9439) || true) && (_lazyAdapter is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10206, 9275, 9439);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10206, 9333, 9424);

                    return f_10206_9340_9423(ref _lazyAdapter, f_10206_9391_9422(this));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10206, 9275, 9439);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10206, 9455, 9475);

                return _lazyAdapter;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10206, 9200, 9486);

                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbolAdapter
                f_10206_9391_9422(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                underlyingPropertySymbol)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbolAdapter(underlyingPropertySymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10206, 9391, 9422);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbolAdapter
                f_10206_9340_9423(ref Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbolAdapter?
                target, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbolAdapter
                value)
                {
                    var return_v = InterlockedOperations.Initialize(ref target, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10206, 9340, 9423);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10206, 9200, 9486);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10206, 9200, 9486);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual bool HasRuntimeSpecialName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10206, 9749, 9858);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10206, 9785, 9812);

                    f_10206_9785_9811(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10206, 9830, 9843);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10206, 9749, 9858);

                    int
                    f_10206_9785_9811(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10206, 9785, 9811);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10206, 9681, 9869);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10206, 9681, 9869);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static PropertySymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10206, 8989, 9876);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10206, 8989, 9876);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10206, 8989, 9876);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10206, 8989, 9876);
    }
    internal partial class PropertySymbolAdapter
    {
        internal PropertySymbolAdapter(PropertySymbol underlyingPropertySymbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10206, 9956, 10333);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10206, 10426, 10480);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10206, 10052, 10101);

                AdaptedPropertySymbol = underlyingPropertySymbol;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10206, 10117, 10322) || true) && (underlyingPropertySymbol is NativeIntegerPropertySymbol)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10206, 10117, 10322);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10206, 10270, 10307);

                    throw f_10206_10276_10306();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10206, 10117, 10322);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10206, 9956, 10333);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10206, 9956, 10333);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10206, 9956, 10333);
            }
        }

        internal sealed override Symbol AdaptedSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10206, 10391, 10415);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10206, 10394, 10415);
                    return f_10206_10394_10415(); DynAbs.Tracing.TraceSender.TraceExitMethod(10206, 10391, 10415);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10206, 10391, 10415);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10206, 10391, 10415);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal PropertySymbol AdaptedPropertySymbol { get; }

        System.Exception
        f_10206_10276_10306()
        {
            var return_v = ExceptionUtilities.Unreachable;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10206, 10276, 10306);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
        f_10206_10394_10415()
        {
            var return_v = AdaptedPropertySymbol;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10206, 10394, 10415);
            return return_v;
        }

    }
}
