// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Collections;
using Microsoft.CodeAnalysis.PooledObjects;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal partial class Binder
    {
        private UnboundLambda AnalyzeAnonymousFunction(
                    AnonymousFunctionExpressionSyntax syntax, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10311, 1693, 9229);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 1847, 1876);

                f_10311_1847_1875(syntax != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 1890, 1933);

                f_10311_1890_1932(f_10311_1903_1931(syntax));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 1949, 1993);

                var
                names = default(ImmutableArray<string>)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 2007, 2055);

                var
                refKinds = default(ImmutableArray<RefKind>)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 2069, 2126);

                var
                types = default(ImmutableArray<TypeWithAnnotations>)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 2142, 2196);

                var
                namesBuilder = f_10311_2161_2195()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 2210, 2253);

                ImmutableArray<bool>
                discardsOpt = default
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 2267, 2332);

                SeparatedSyntaxList<ParameterSyntax>?
                parameterSyntaxList = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 2346, 2364);

                bool
                hasSignature
                = default(bool);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 2380, 3703);

                switch (f_10311_2388_2401(syntax))
                {

                    default:
                    case SyntaxKind.SimpleLambdaExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10311, 2380, 3703);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 2555, 2575);

                        hasSignature = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 2597, 2647);

                        var
                        simple = (SimpleLambdaExpressionSyntax)syntax
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 2669, 2725);

                        f_10311_2669_2724(namesBuilder, f_10311_2686_2702(simple).Identifier.ValueText);
                        DynAbs.Tracing.TraceSender.TraceBreak(10311, 2747, 2753);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10311, 2380, 3703);

                    case SyntaxKind.ParenthesizedLambdaExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10311, 2380, 3703);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 2919, 2939);

                        hasSignature = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 2961, 3017);

                        var
                        paren = (ParenthesizedLambdaExpressionSyntax)syntax
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 3039, 3092);

                        parameterSyntaxList = f_10311_3061_3091(f_10311_3061_3080(paren));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 3114, 3189);

                        f_10311_3114_3188(this, parameterSyntaxList.Value, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceBreak(10311, 3211, 3217);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10311, 2380, 3703);

                    case SyntaxKind.AnonymousMethodExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10311, 2380, 3703);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 3381, 3432);

                        var
                        anon = (AnonymousMethodExpressionSyntax)syntax
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 3454, 3496);

                        hasSignature = f_10311_3469_3487(anon) != null;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 3518, 3660) || true) && (hasSignature)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10311, 3518, 3660);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 3584, 3637);

                            parameterSyntaxList = f_10311_3606_3636(anon.ParameterList!);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10311, 3518, 3660);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10311, 3682, 3688);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10311, 2380, 3703);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 3719, 3779);

                var
                isAsync = syntax.Modifiers.Any(SyntaxKind.AsyncKeyword)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 3793, 3855);

                var
                isStatic = syntax.Modifiers.Any(SyntaxKind.StaticKeyword)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 3871, 8282) || true) && (parameterSyntaxList != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10311, 3871, 8282);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 3936, 3979);

                    var
                    hasExplicitlyTypedParameterList = true
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 3997, 4017);

                    var
                    allValue = true
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 4037, 4104);

                    var
                    typesBuilder = f_10311_4056_4103()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 4122, 4180);

                    var
                    refKindsBuilder = f_10311_4144_4179()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 4751, 4776);

                    int
                    underscoresCount = 0
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 4794, 7805);
                        foreach (var p in f_10311_4812_4837_I(parameterSyntaxList.Value))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10311, 4794, 7805);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 4879, 5007) || true) && (p.Identifier.IsUnderscoreToken())
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10311, 4879, 5007);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 4965, 4984);

                                underscoresCount++;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10311, 4879, 5007);
                            }
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 5031, 5220);
                                foreach (var attributeList in f_10311_5061_5077_I(f_10311_5061_5077(p)))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10311, 5031, 5220);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 5127, 5197);

                                    f_10311_5127_5196(diagnostics, ErrorCode.ERR_AttributesNotAllowed, attributeList);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10311, 5031, 5220);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10311, 1, 190);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10311, 1, 190);
                            }
                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 5244, 5418) || true) && (f_10311_5248_5257(p) != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10311, 5244, 5418);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 5315, 5395);

                                f_10311_5315_5394(diagnostics, ErrorCode.ERR_DefaultValueNotAllowed, f_10311_5372_5393(f_10311_5372_5381(p)));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10311, 5244, 5418);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 5442, 5617) || true) && (f_10311_5446_5457(p))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10311, 5442, 5617);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 5507, 5559);

                                f_10311_5507_5558(diagnostics, ErrorCode.ERR_IllegalVarArgs, p);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 5585, 5594);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10311, 5442, 5617);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 5641, 5665);

                            var
                            typeSyntax = f_10311_5658_5664(p)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 5687, 5722);

                            TypeWithAnnotations
                            type = default
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 5744, 5771);

                            var
                            refKind = RefKind.None
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 5795, 7625) || true) && (typeSyntax == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10311, 5795, 7625);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 5867, 5907);

                                hasExplicitlyTypedParameterList = false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10311, 5795, 7625);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10311, 5795, 7625);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 6005, 6046);

                                type = f_10311_6012_6045(this, typeSyntax, diagnostics);
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 6072, 7602);
                                    foreach (var modifier in f_10311_6097_6108_I(f_10311_6097_6108(p)))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10311, 6072, 7602);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 6166, 7575);

                                        switch (modifier.Kind())
                                        {

                                            case SyntaxKind.RefKeyword:
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10311, 6166, 7575);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 6320, 6342);

                                                refKind = RefKind.Ref;
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 6380, 6397);

                                                allValue = false;
                                                DynAbs.Tracing.TraceSender.TraceBreak(10311, 6435, 6441);

                                                break;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10311, 6166, 7575);

                                            case SyntaxKind.OutKeyword:
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10311, 6166, 7575);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 6542, 6564);

                                                refKind = RefKind.Out;
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 6602, 6619);

                                                allValue = false;
                                                DynAbs.Tracing.TraceSender.TraceBreak(10311, 6657, 6663);

                                                break;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10311, 6166, 7575);

                                            case SyntaxKind.InKeyword:
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10311, 6166, 7575);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 6763, 6784);

                                                refKind = RefKind.In;
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 6822, 6839);

                                                allValue = false;
                                                DynAbs.Tracing.TraceSender.TraceBreak(10311, 6877, 6883);

                                                break;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10311, 6166, 7575);

                                            case SyntaxKind.ParamsKeyword:
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10311, 6166, 7575);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 7242, 7293);

                                                f_10311_7242_7292(diagnostics, ErrorCode.ERR_IllegalParams, p);
                                                DynAbs.Tracing.TraceSender.TraceBreak(10311, 7331, 7337);

                                                break;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10311, 6166, 7575);

                                            case SyntaxKind.ThisKeyword:
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10311, 6166, 7575);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 7439, 7500);

                                                f_10311_7439_7499(diagnostics, ErrorCode.ERR_ThisInBadContext, modifier);
                                                DynAbs.Tracing.TraceSender.TraceBreak(10311, 7538, 7544);

                                                break;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10311, 6166, 7575);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10311, 6072, 7602);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10311, 1, 1531);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(10311, 1, 1531);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10311, 5795, 7625);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 7649, 7690);

                            f_10311_7649_7689(
                                                namesBuilder, p.Identifier.ValueText);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 7712, 7735);

                            f_10311_7712_7734(typesBuilder, type);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 7757, 7786);

                            f_10311_7757_7785(refKindsBuilder, refKind);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10311, 4794, 7805);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10311, 1, 3012);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10311, 1, 3012);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 7825, 7900);

                    discardsOpt = f_10311_7839_7899(parameterSyntaxList.Value, underscoresCount);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 7920, 8051) || true) && (hasExplicitlyTypedParameterList)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10311, 7920, 8051);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 7997, 8032);

                        types = f_10311_8005_8031(typesBuilder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10311, 7920, 8051);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 8071, 8186) || true) && (!allValue)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10311, 8071, 8186);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 8126, 8167);

                        refKinds = f_10311_8137_8166(refKindsBuilder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10311, 8071, 8186);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 8206, 8226);

                    f_10311_8206_8225(
                                    typesBuilder);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 8244, 8267);

                    f_10311_8244_8266(refKindsBuilder);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10311, 3871, 8282);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 8298, 8398) || true) && (hasSignature)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10311, 8298, 8398);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 8348, 8383);

                    names = f_10311_8356_8382(namesBuilder);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10311, 8298, 8398);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 8414, 8434);

                f_10311_8414_8433(
                            namesBuilder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 8450, 8545);

                return f_10311_8457_8544(syntax, this, refKinds, types, names, discardsOpt, isAsync, isStatic);

                static ImmutableArray<bool> computeDiscards(SeparatedSyntaxList<ParameterSyntax> parameters, int underscoresCount)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10311, 8561, 9218);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 8708, 8809) || true) && (underscoresCount <= 1)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10311, 8708, 8809);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 8775, 8790);

                            return default;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10311, 8708, 8809);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 8907, 8978);

                        var
                        discardsBuilder = f_10311_8929_8977(parameters.Count)
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 8996, 9139);
                            foreach (var p in f_10311_9014_9024_I(parameters))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10311, 8996, 9139);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 9066, 9120);

                                f_10311_9066_9119(discardsBuilder, p.Identifier.IsUnderscoreToken());
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10311, 8996, 9139);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10311, 1, 144);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10311, 1, 144);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 9159, 9203);

                        return f_10311_9166_9202(discardsBuilder);
                        DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10311, 8561, 9218);

                        Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<bool>
                        f_10311_8929_8977(int
                        capacity)
                        {
                            var return_v = ArrayBuilder<bool>.GetInstance(capacity);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10311, 8929, 8977);
                            return return_v;
                        }


                        int
                        f_10311_9066_9119(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<bool>
                        this_param, bool
                        item)
                        {
                            this_param.Add(item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10311, 9066, 9119);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax>
                        f_10311_9014_9024_I(Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10311, 9014, 9024);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<bool>
                        f_10311_9166_9202(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<bool>
                        this_param)
                        {
                            var return_v = this_param.ToImmutableAndFree();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10311, 9166, 9202);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10311, 8561, 9218);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10311, 8561, 9218);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10311, 1693, 9229);

                int
                f_10311_1847_1875(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10311, 1847, 1875);
                    return 0;
                }


                bool
                f_10311_1903_1931(Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousFunctionExpressionSyntax
                syntax)
                {
                    var return_v = syntax.IsAnonymousFunction();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10311, 1903, 1931);
                    return return_v;
                }


                int
                f_10311_1890_1932(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10311, 1890, 1932);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                f_10311_2161_2195()
                {
                    var return_v = ArrayBuilder<string>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10311, 2161, 2195);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10311_2388_2401(Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousFunctionExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10311, 2388, 2401);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
                f_10311_2686_2702(Microsoft.CodeAnalysis.CSharp.Syntax.SimpleLambdaExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10311, 2686, 2702);
                    return return_v;
                }


                int
                f_10311_2669_2724(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10311, 2669, 2724);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
                f_10311_3061_3080(Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedLambdaExpressionSyntax
                this_param)
                {
                    var return_v = this_param.ParameterList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10311, 3061, 3080);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax>
                f_10311_3061_3091(Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10311, 3061, 3091);
                    return return_v;
                }


                int
                f_10311_3114_3188(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax>
                parameterSyntaxList, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.CheckParenthesizedLambdaParameters(parameterSyntaxList, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10311, 3114, 3188);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax?
                f_10311_3469_3487(Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousMethodExpressionSyntax
                this_param)
                {
                    var return_v = this_param.ParameterList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10311, 3469, 3487);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax>
                f_10311_3606_3636(Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10311, 3606, 3636);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10311_4056_4103()
                {
                    var return_v = ArrayBuilder<TypeWithAnnotations>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10311, 4056, 4103);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.RefKind>
                f_10311_4144_4179()
                {
                    var return_v = ArrayBuilder<RefKind>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10311, 4144, 4179);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                f_10311_5061_5077(Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
                this_param)
                {
                    var return_v = this_param.AttributeLists;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10311, 5061, 5077);
                    return return_v;
                }


                int
                f_10311_5127_5196(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax
                syntax)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10311, 5127, 5196);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                f_10311_5061_5077_I(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10311, 5061, 5077);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax?
                f_10311_5248_5257(Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
                this_param)
                {
                    var return_v = this_param.Default;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10311, 5248, 5257);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax
                f_10311_5372_5381(Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
                this_param)
                {
                    var return_v = this_param.Default;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10311, 5372, 5381);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10311_5372_5393(Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax
                this_param)
                {
                    var return_v = this_param.EqualsToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10311, 5372, 5393);
                    return return_v;
                }


                int
                f_10311_5315_5394(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxToken
                token)
                {
                    Error(diagnostics, code, token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10311, 5315, 5394);
                    return 0;
                }


                bool
                f_10311_5446_5457(Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
                this_param)
                {
                    var return_v = this_param.IsArgList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10311, 5446, 5457);
                    return return_v;
                }


                int
                f_10311_5507_5558(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
                syntax)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10311, 5507, 5558);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax?
                f_10311_5658_5664(Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10311, 5658, 5664);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10311_6012_6045(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindType((Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax)syntax, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10311, 6012, 6045);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTokenList
                f_10311_6097_6108(Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
                this_param)
                {
                    var return_v = this_param.Modifiers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10311, 6097, 6108);
                    return return_v;
                }


                int
                f_10311_7242_7292(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
                syntax)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10311, 7242, 7292);
                    return 0;
                }


                int
                f_10311_7439_7499(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxToken
                token)
                {
                    Error(diagnostics, code, token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10311, 7439, 7499);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxTokenList
                f_10311_6097_6108_I(Microsoft.CodeAnalysis.SyntaxTokenList
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10311, 6097, 6108);
                    return return_v;
                }


                int
                f_10311_7649_7689(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10311, 7649, 7689);
                    return 0;
                }


                int
                f_10311_7712_7734(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10311, 7712, 7734);
                    return 0;
                }


                int
                f_10311_7757_7785(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.RefKind>
                this_param, Microsoft.CodeAnalysis.RefKind
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10311, 7757, 7785);
                    return 0;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax>
                f_10311_4812_4837_I(Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10311, 4812, 4837);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<bool>
                f_10311_7839_7899(Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax>
                parameters, int
                underscoresCount)
                {
                    var return_v = computeDiscards(parameters, underscoresCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10311, 7839, 7899);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10311_8005_8031(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10311, 8005, 8031);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                f_10311_8137_8166(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.RefKind>
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10311, 8137, 8166);
                    return return_v;
                }


                int
                f_10311_8206_8225(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10311, 8206, 8225);
                    return 0;
                }


                int
                f_10311_8244_8266(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.RefKind>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10311, 8244, 8266);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_10311_8356_8382(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10311, 8356, 8382);
                    return return_v;
                }


                int
                f_10311_8414_8433(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10311, 8414, 8433);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.UnboundLambda
                f_10311_8457_8544(Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousFunctionExpressionSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.Binder
                binder, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                refKinds, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                types, System.Collections.Immutable.ImmutableArray<string>
                names, System.Collections.Immutable.ImmutableArray<bool>
                discardsOpt, bool
                isAsync, bool
                isStatic)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.UnboundLambda((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, binder, refKinds, types, names, discardsOpt, isAsync, isStatic);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10311, 8457, 8544);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10311, 1693, 9229);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10311, 1693, 9229);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void CheckParenthesizedLambdaParameters(
                    SeparatedSyntaxList<ParameterSyntax> parameterSyntaxList, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10311, 9241, 10378);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 9412, 10367) || true) && (parameterSyntaxList.Count > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10311, 9412, 10367);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 9479, 9530);

                    var
                    hasTypes = f_10311_9494_9521(parameterSyntaxList[0]) != null
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 9559, 9564);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 9566, 9595);

                        for (int
        i = 1
        ,
        n = parameterSyntaxList.Count
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 9550, 10352) || true) && (i < n)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 9604, 9607)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10311, 9550, 10352))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10311, 9550, 10352);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 9649, 9688);

                            var
                            parameter = parameterSyntaxList[i]
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 9862, 10333) || true) && (f_10311_9866_9897_M(!parameter.Identifier.IsMissing))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10311, 9862, 10333);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 9947, 9997);

                                var
                                thisParameterHasType = f_10311_9974_9988(parameter) != null
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 10023, 10310) || true) && (hasTypes != thisParameterHasType)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10311, 10023, 10310);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 10117, 10283);

                                    f_10311_10117_10282(diagnostics, ErrorCode.ERR_InconsistentLambdaParameterUsage, f_10311_10214_10243_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10311_10214_10228(parameter), 10311, 10214, 10243).GetLocation()) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.Location?>(10311, 10214, 10281) ?? parameter.Identifier.GetLocation()));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10311, 10023, 10310);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10311, 9862, 10333);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10311, 1, 803);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10311, 1, 803);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10311, 9412, 10367);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10311, 9241, 10378);

                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax?
                f_10311_9494_9521(Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10311, 9494, 9521);
                    return return_v;
                }


                bool
                f_10311_9866_9897_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10311, 9866, 9897);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax?
                f_10311_9974_9988(Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10311, 9974, 9988);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax?
                f_10311_10214_10228(Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10311, 10214, 10228);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location?
                f_10311_10214_10243_I(Microsoft.CodeAnalysis.Location?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10311, 10214, 10243);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10311_10117_10282(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10311, 10117, 10282);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10311, 9241, 10378);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10311, 9241, 10378);
            }
        }

        private UnboundLambda BindAnonymousFunction(AnonymousFunctionExpressionSyntax syntax, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10311, 10390, 13492);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 10527, 10556);

                f_10311_10527_10555(syntax != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 10570, 10613);

                f_10311_10570_10612(f_10311_10583_10611(syntax));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 10629, 10688);

                var
                lambda = f_10311_10642_10687(this, syntax, diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 10702, 10725);

                var
                data = f_10311_10713_10724(lambda)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 10739, 11297) || true) && (f_10311_10743_10779(data))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10311, 10739, 11297);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 10822, 10827);
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 10813, 11282) || true) && (i < f_10311_10833_10854(lambda))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 10856, 10859)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10311, 10813, 11282))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10311, 10813, 11282);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 10983, 11038);

                            var
                            type = f_10311_10994_11037(f_10311_10994_11005(lambda), i)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 11060, 11263) || true) && (type.HasType && (DynAbs.Tracing.TraceSender.Expression_True(10311, 11064, 11093) && type.IsStatic))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10311, 11060, 11263);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 11143, 11240);

                                f_10311_11143_11239(diagnostics, f_10311_11162_11219(useWarning: false), syntax, type.Type);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10311, 11060, 11263);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10311, 1, 470);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10311, 1, 470);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10311, 10739, 11297);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 11547, 11615);

                ModifierUtils.ToDeclarationModifiers(f_10311_11584_11600(syntax), diagnostics);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 11631, 13451) || true) && (f_10311_11635_11648(data))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10311, 11631, 13451);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 11682, 11722);

                    var
                    binder = f_10311_11695_11721(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 11740, 11856);

                    bool
                    allowShadowingNames = f_10311_11767_11855(f_10311_11767_11785(binder), MessageID.IDS_FeatureNameShadowingInNestedFunctions)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 11874, 11923);

                    var
                    pNames = f_10311_11887_11922()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 11941, 11966);

                    bool
                    seenDiscard = false
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 11995, 12000);

                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 11986, 13404) || true) && (i < f_10311_12006_12027(lambda))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 12029, 12032)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10311, 11986, 13404))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10311, 11986, 13404);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 12074, 12109);

                            var
                            name = f_10311_12085_12108(lambda, i)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 12133, 12245) || true) && (f_10311_12137_12163(name))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10311, 12133, 12245);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 12213, 12222);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10311, 12133, 12245);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 12269, 12891) || true) && (f_10311_12273_12301(lambda, i))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10311, 12269, 12891);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 12351, 12786) || true) && (seenDiscard)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10311, 12351, 12786);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 12527, 12759);

                                    f_10311_12527_12758(                            // We only report the diagnostic on the second and subsequent underscores
                                                                MessageID.IDS_FeatureLambdaDiscardParameters, diagnostics, f_10311_12677_12695(binder), f_10311_12730_12757(lambda, i));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10311, 12351, 12786);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 12814, 12833);

                                seenDiscard = true;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 12859, 12868);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10311, 12269, 12891);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 12915, 13385) || true) && (!f_10311_12920_12936(pNames, name))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10311, 12915, 13385);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 13054, 13139);

                                f_10311_13054_13138(                        // The parameter name '{0}' is a duplicate
                                                        diagnostics, ErrorCode.ERR_DuplicateParamName, f_10311_13104_13131(lambda, i), name);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10311, 12915, 13385);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10311, 12915, 13385);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 13189, 13385) || true) && (!allowShadowingNames)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10311, 13189, 13385);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 13263, 13362);

                                    f_10311_13263_13361(binder, f_10311_13314_13341(lambda, i), name, diagnostics);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10311, 13189, 13385);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10311, 12915, 13385);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10311, 1, 1419);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10311, 1, 1419);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 13422, 13436);

                    f_10311_13422_13435(pNames);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10311, 11631, 13451);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10311, 13467, 13481);

                return lambda;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10311, 10390, 13492);

                int
                f_10311_10527_10555(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10311, 10527, 10555);
                    return 0;
                }


                bool
                f_10311_10583_10611(Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousFunctionExpressionSyntax
                syntax)
                {
                    var return_v = syntax.IsAnonymousFunction();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10311, 10583, 10611);
                    return return_v;
                }


                int
                f_10311_10570_10612(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10311, 10570, 10612);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.UnboundLambda
                f_10311_10642_10687(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousFunctionExpressionSyntax
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.AnalyzeAnonymousFunction(syntax, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10311, 10642, 10687);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.UnboundLambdaState
                f_10311_10713_10724(Microsoft.CodeAnalysis.CSharp.UnboundLambda
                this_param)
                {
                    var return_v = this_param.Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10311, 10713, 10724);
                    return return_v;
                }


                bool
                f_10311_10743_10779(Microsoft.CodeAnalysis.CSharp.UnboundLambdaState
                this_param)
                {
                    var return_v = this_param.HasExplicitlyTypedParameterList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10311, 10743, 10779);
                    return return_v;
                }


                int
                f_10311_10833_10854(Microsoft.CodeAnalysis.CSharp.UnboundLambda
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10311, 10833, 10854);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.UnboundLambdaState
                f_10311_10994_11005(Microsoft.CodeAnalysis.CSharp.UnboundLambda
                this_param)
                {
                    var return_v = this_param.Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10311, 10994, 11005);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10311_10994_11037(Microsoft.CodeAnalysis.CSharp.UnboundLambdaState
                this_param, int
                index)
                {
                    var return_v = this_param.ParameterTypeWithAnnotations(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10311, 10994, 11037);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ErrorCode
                f_10311_11162_11219(bool
                useWarning)
                {
                    var return_v = ErrorFacts.GetStaticClassParameterCode(useWarning: useWarning);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10311, 11162, 11219);
                    return return_v;
                }


                int
                f_10311_11143_11239(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousFunctionExpressionSyntax
                syntax, params object[]
                args)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10311, 11143, 11239);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxTokenList
                f_10311_11584_11600(Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousFunctionExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Modifiers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10311, 11584, 11600);
                    return return_v;
                }


                bool
                f_10311_11635_11648(Microsoft.CodeAnalysis.CSharp.UnboundLambdaState
                this_param)
                {
                    var return_v = this_param.HasNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10311, 11635, 11648);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LocalScopeBinder
                f_10311_11695_11721(Microsoft.CodeAnalysis.CSharp.Binder
                next)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.LocalScopeBinder(next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10311, 11695, 11721);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10311_11767_11785(Microsoft.CodeAnalysis.CSharp.LocalScopeBinder
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10311, 11767, 11785);
                    return return_v;
                }


                bool
                f_10311_11767_11855(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.MessageID
                feature)
                {
                    var return_v = compilation.IsFeatureEnabled(feature);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10311, 11767, 11855);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<string>
                f_10311_11887_11922()
                {
                    var return_v = PooledHashSet<string>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10311, 11887, 11922);
                    return return_v;
                }


                int
                f_10311_12006_12027(Microsoft.CodeAnalysis.CSharp.UnboundLambda
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10311, 12006, 12027);
                    return return_v;
                }


                string
                f_10311_12085_12108(Microsoft.CodeAnalysis.CSharp.UnboundLambda
                this_param, int
                index)
                {
                    var return_v = this_param.ParameterName(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10311, 12085, 12108);
                    return return_v;
                }


                bool
                f_10311_12137_12163(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10311, 12137, 12163);
                    return return_v;
                }


                bool
                f_10311_12273_12301(Microsoft.CodeAnalysis.CSharp.UnboundLambda
                this_param, int
                index)
                {
                    var return_v = this_param.ParameterIsDiscard(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10311, 12273, 12301);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10311_12677_12695(Microsoft.CodeAnalysis.CSharp.LocalScopeBinder
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10311, 12677, 12695);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10311_12730_12757(Microsoft.CodeAnalysis.CSharp.UnboundLambda
                this_param, int
                index)
                {
                    var return_v = this_param.ParameterLocation(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10311, 12730, 12757);
                    return return_v;
                }


                bool
                f_10311_12527_12758(Microsoft.CodeAnalysis.CSharp.MessageID
                feature, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = feature.CheckFeatureAvailability(diagnostics, (Microsoft.CodeAnalysis.Compilation)compilation, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10311, 12527, 12758);
                    return return_v;
                }


                bool
                f_10311_12920_12936(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10311, 12920, 12936);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10311_13104_13131(Microsoft.CodeAnalysis.CSharp.UnboundLambda
                this_param, int
                index)
                {
                    var return_v = this_param.ParameterLocation(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10311, 13104, 13131);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10311_13054_13138(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10311, 13054, 13138);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10311_13314_13341(Microsoft.CodeAnalysis.CSharp.UnboundLambda
                this_param, int
                index)
                {
                    var return_v = this_param.ParameterLocation(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10311, 13314, 13341);
                    return return_v;
                }


                bool
                f_10311_13263_13361(Microsoft.CodeAnalysis.CSharp.LocalScopeBinder
                this_param, Microsoft.CodeAnalysis.Location
                location, string
                name, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.ValidateLambdaParameterNameConflictsInScope(location, name, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10311, 13263, 13361);
                    return return_v;
                }


                int
                f_10311_13422_13435(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<string>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10311, 13422, 13435);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10311, 10390, 13492);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10311, 10390, 13492);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
}
