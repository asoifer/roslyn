// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed partial class OverloadResolution
    {
        private struct ParameterMap
        {

            private readonly int[] _parameters;

            private readonly int _length;

            public ParameterMap(int[] parameters, int length)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10876, 1318, 1557);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 1400, 1464);

                    f_10876_1400_1463(parameters == null || (DynAbs.Tracing.TraceSender.Expression_False(10876, 1413, 1462) || f_10876_1435_1452(parameters) == length));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 1482, 1507);

                    _parameters = parameters;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 1525, 1542);

                    _length = length;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10876, 1318, 1557);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10876, 1318, 1557);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10876, 1318, 1557);
                }
            }

            public bool IsTrivial
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10876, 1597, 1632);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 1603, 1630);

                        return _parameters == null;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10876, 1597, 1632);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10876, 1573, 1634);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10876, 1573, 1634);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public int Length
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10876, 1670, 1693);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 1676, 1691);

                        return _length;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10876, 1670, 1693);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10876, 1650, 1695);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10876, 1650, 1695);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public int this[int argument]
            {

                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10876, 1773, 1970);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 1817, 1867);

                        f_10876_1817_1866(0 <= argument && (DynAbs.Tracing.TraceSender.Expression_True(10876, 1830, 1865) && argument < _length));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 1889, 1951);

                        return (DynAbs.Tracing.TraceSender.Conditional_F1(10876, 1896, 1915) || ((_parameters == null && DynAbs.Tracing.TraceSender.Conditional_F2(10876, 1918, 1926)) || DynAbs.Tracing.TraceSender.Conditional_F3(10876, 1929, 1950))) ? argument : _parameters[argument];
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10876, 1773, 1970);

                        int
                        f_10876_1817_1866(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10876, 1817, 1866);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10876, 1773, 1970);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10876, 1773, 1970);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public ImmutableArray<int> ToImmutableArray()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10876, 2001, 2133);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 2079, 2118);

                    return f_10876_2086_2117(_parameters);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10876, 2001, 2133);

                    System.Collections.Immutable.ImmutableArray<int>
                    f_10876_2086_2117(int[]
                    items)
                    {
                        var return_v = items.AsImmutableOrNull<int>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10876, 2086, 2117);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10876, 2001, 2133);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10876, 2001, 2133);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            static ParameterMap()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10876, 1172, 2144);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10876, 1172, 2144);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10876, 1172, 2144);
            }

            static int
            f_10876_1435_1452(int[]
            this_param)
            {
                var return_v = this_param.Length;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10876, 1435, 1452);
                return return_v;
            }


            static int
            f_10876_1400_1463(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10876, 1400, 1463);
                return 0;
            }

        }

        private static ArgumentAnalysisResult AnalyzeArguments(
                    Symbol symbol,
                    AnalyzedArguments arguments,
                    bool isMethodGroupConversion,
                    bool expanded)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10876, 2156, 8741);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 2377, 2414);

                f_10876_2377_2413((object)symbol != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 2428, 2460);

                f_10876_2428_2459(arguments != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 2476, 2544);

                ImmutableArray<ParameterSymbol>
                parameters = f_10876_2521_2543(symbol)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 2558, 2595);

                bool
                isVararg = f_10876_2574_2594(symbol)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 2699, 2902) || true) && (!expanded && (DynAbs.Tracing.TraceSender.Expression_True(10876, 2703, 2742) && f_10876_2716_2737(arguments.Names) == 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10876, 2699, 2902);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 2776, 2887);

                    return f_10876_2783_2886(parameters, arguments, isMethodGroupConversion, isVararg);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10876, 2699, 2902);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 3006, 3052);

                int
                argumentCount = f_10876_3026_3051(arguments.Arguments)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 3068, 3101);

                int[]
                parametersPositions = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 3115, 3150);

                int?
                unmatchedArgumentIndex = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 3164, 3202);

                bool?
                unmatchedArgumentIsNamed = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 3303, 3332);

                bool
                seenNamedParams = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 3346, 3390);

                bool
                seenOutOfPositionNamedArgument = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 3404, 3447);

                bool
                isValidParams = f_10876_3425_3446(symbol)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 3470, 3490);
                    for (int
        argumentPosition = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 3461, 4759) || true) && (argumentPosition < argumentCount)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 3526, 3544)
        , ++argumentPosition, DynAbs.Tracing.TraceSender.TraceExitCondition(10876, 3461, 4759))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10876, 3461, 4759);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 3694, 3715);

                        bool
                        isNamedArgument
                        = default(bool);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 3733, 3964);

                        int
                        parameterPosition = f_10876_3757_3957(parameters, expanded, arguments, argumentPosition, isValidParams, isVararg, out isNamedArgument, ref seenNamedParams, ref seenOutOfPositionNamedArgument) ?? (DynAbs.Tracing.TraceSender.Expression_Null<int?>(10876, 3757, 3963) ?? -1)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 3984, 4213) || true) && (parameterPosition == -1 && (DynAbs.Tracing.TraceSender.Expression_True(10876, 3988, 4045) && unmatchedArgumentIndex == null))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10876, 3984, 4213);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 4087, 4129);

                            unmatchedArgumentIndex = argumentPosition;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 4151, 4194);

                            unmatchedArgumentIsNamed = isNamedArgument;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10876, 3984, 4213);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 4233, 4574) || true) && (parameterPosition != argumentPosition && (DynAbs.Tracing.TraceSender.Expression_True(10876, 4237, 4305) && parametersPositions == null))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10876, 4233, 4574);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 4347, 4392);

                            parametersPositions = new int[argumentCount];
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 4423, 4428);
                                for (int
            i = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 4414, 4555) || true) && (i < argumentPosition)
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 4452, 4455)
            , ++i, DynAbs.Tracing.TraceSender.TraceExitCondition(10876, 4414, 4555))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10876, 4414, 4555);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 4505, 4532);

                                    parametersPositions[i] = i;
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10876, 1, 142);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10876, 1, 142);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10876, 4233, 4574);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 4594, 4744) || true) && (parametersPositions != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10876, 4594, 4744);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 4667, 4725);

                            parametersPositions[argumentPosition] = parameterPosition;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10876, 4594, 4744);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10876, 1, 1299);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10876, 1, 1299);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 4775, 4860);

                ParameterMap
                argsToParameters = f_10876_4807_4859(parametersPositions, argumentCount)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 6106, 6218);

                int?
                badNonTrailingNamedArgument = f_10876_6141_6217(arguments, argsToParameters, parameters)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 6232, 6413) || true) && (badNonTrailingNamedArgument != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10876, 6232, 6413);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 6305, 6398);

                    return ArgumentAnalysisResult.BadNonTrailingNamedArgument(f_10876_6363_6396(badNonTrailingNamedArgument));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10876, 6232, 6413);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 6508, 6943) || true) && (unmatchedArgumentIndex != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10876, 6508, 6943);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 6576, 6928) || true) && (f_10876_6580_6610(unmatchedArgumentIsNamed))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10876, 6576, 6928);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 6652, 6742);

                        return ArgumentAnalysisResult.NoCorrespondingNamedParameter(f_10876_6712_6740(unmatchedArgumentIndex));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10876, 6576, 6928);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10876, 6576, 6928);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 6824, 6909);

                        return ArgumentAnalysisResult.NoCorrespondingParameter(f_10876_6879_6907(unmatchedArgumentIndex));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10876, 6576, 6928);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10876, 6508, 6943);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 7112, 7192);

                int?
                nameUsedForPositional = f_10876_7141_7191(arguments, argsToParameters)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 7206, 7369) || true) && (nameUsedForPositional != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10876, 7206, 7369);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 7273, 7354);

                    return ArgumentAnalysisResult.NameUsedForPositional(f_10876_7325_7352(nameUsedForPositional));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10876, 7206, 7369);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 7477, 7607);

                int?
                requiredParameterMissing = f_10876_7509_7606(argsToParameters, parameters, isMethodGroupConversion, expanded)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 7621, 7793) || true) && (requiredParameterMissing != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10876, 7621, 7793);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 7691, 7778);

                    return ArgumentAnalysisResult.RequiredParameterMissing(f_10876_7746_7776(requiredParameterMissing));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10876, 7621, 7793);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 7899, 8093) || true) && (f_10876_7903_7924(arguments.Names) && (DynAbs.Tracing.TraceSender.Expression_True(10876, 7903, 7958) && f_10876_7928_7950(arguments.Names) != null) && (DynAbs.Tracing.TraceSender.Expression_True(10876, 7903, 7970) && isVararg))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10876, 7899, 8093);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 8004, 8078);

                    return ArgumentAnalysisResult.RequiredParameterMissing(parameters.Length);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10876, 7899, 8093);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 8186, 8258);

                int?
                duplicateNamedArgument = f_10876_8216_8257(arguments)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 8272, 8438) || true) && (duplicateNamedArgument != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10876, 8272, 8438);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 8340, 8423);

                    return ArgumentAnalysisResult.DuplicateNamedArgument(f_10876_8393_8421(duplicateNamedArgument));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10876, 8272, 8438);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 8532, 8730);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10876, 8539, 8547) || ((expanded && DynAbs.Tracing.TraceSender.Conditional_F2(10876, 8567, 8639)) || DynAbs.Tracing.TraceSender.Conditional_F3(10876, 8659, 8729))) ? ArgumentAnalysisResult.ExpandedForm(argsToParameters.ToImmutableArray()) : ArgumentAnalysisResult.NormalForm(argsToParameters.ToImmutableArray());
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10876, 2156, 8741);

                int
                f_10876_2377_2413(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10876, 2377, 2413);
                    return 0;
                }


                int
                f_10876_2428_2459(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10876, 2428, 2459);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10876_2521_2543(Microsoft.CodeAnalysis.CSharp.Symbol
                member)
                {
                    var return_v = member.GetParameters();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10876, 2521, 2543);
                    return return_v;
                }


                bool
                f_10876_2574_2594(Microsoft.CodeAnalysis.CSharp.Symbol
                member)
                {
                    var return_v = member.GetIsVararg();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10876, 2574, 2594);
                    return return_v;
                }


                int
                f_10876_2716_2737(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10876, 2716, 2737);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ArgumentAnalysisResult
                f_10876_2783_2886(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                arguments, bool
                isMethodGroupConversion, bool
                isVararg)
                {
                    var return_v = AnalyzeArgumentsForNormalFormNoNamedArguments(parameters, arguments, isMethodGroupConversion, isVararg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10876, 2783, 2886);
                    return return_v;
                }


                int
                f_10876_3026_3051(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10876, 3026, 3051);
                    return return_v;
                }


                bool
                f_10876_3425_3446(Microsoft.CodeAnalysis.CSharp.Symbol
                member)
                {
                    var return_v = IsValidParams(member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10876, 3425, 3446);
                    return return_v;
                }


                int?
                f_10876_3757_3957(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                memberParameters, bool
                expanded, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                arguments, int
                argumentPosition, bool
                isValidParams, bool
                isVararg, out bool
                isNamedArgument, ref bool
                seenNamedParams, ref bool
                seenOutOfPositionNamedArgument)
                {
                    var return_v = CorrespondsToAnyParameter(memberParameters, expanded, arguments, argumentPosition, isValidParams, isVararg, out isNamedArgument, ref seenNamedParams, ref seenOutOfPositionNamedArgument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10876, 3757, 3957);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.OverloadResolution.ParameterMap
                f_10876_4807_4859(int[]?
                parameters, int
                length)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.OverloadResolution.ParameterMap(parameters, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10876, 4807, 4859);
                    return return_v;
                }


                int?
                f_10876_6141_6217(Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                arguments, Microsoft.CodeAnalysis.CSharp.OverloadResolution.ParameterMap
                argsToParameters, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters)
                {
                    var return_v = CheckForBadNonTrailingNamedArgument(arguments, argsToParameters, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10876, 6141, 6217);
                    return return_v;
                }


                int
                f_10876_6363_6396(int?
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10876, 6363, 6396);
                    return return_v;
                }


                bool
                f_10876_6580_6610(bool?
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10876, 6580, 6610);
                    return return_v;
                }


                int
                f_10876_6712_6740(int?
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10876, 6712, 6740);
                    return return_v;
                }


                int
                f_10876_6879_6907(int?
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10876, 6879, 6907);
                    return return_v;
                }


                int?
                f_10876_7141_7191(Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                arguments, Microsoft.CodeAnalysis.CSharp.OverloadResolution.ParameterMap
                argsToParameters)
                {
                    var return_v = NameUsedForPositional(arguments, argsToParameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10876, 7141, 7191);
                    return return_v;
                }


                int
                f_10876_7325_7352(int?
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10876, 7325, 7352);
                    return return_v;
                }


                int?
                f_10876_7509_7606(Microsoft.CodeAnalysis.CSharp.OverloadResolution.ParameterMap
                argsToParameters, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters, bool
                isMethodGroupConversion, bool
                expanded)
                {
                    var return_v = CheckForMissingRequiredParameter(argsToParameters, parameters, isMethodGroupConversion, expanded);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10876, 7509, 7606);
                    return return_v;
                }


                int
                f_10876_7746_7776(int?
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10876, 7746, 7776);
                    return return_v;
                }


                bool
                f_10876_7903_7924(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax>
                this_param)
                {
                    var return_v = this_param.Any();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10876, 7903, 7924);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                f_10876_7928_7950(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax>
                this_param)
                {
                    var return_v = this_param.Last();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10876, 7928, 7950);
                    return return_v;
                }


                int?
                f_10876_8216_8257(Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                arguments)
                {
                    var return_v = CheckForDuplicateNamedArgument(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10876, 8216, 8257);
                    return return_v;
                }


                int
                f_10876_8393_8421(int?
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10876, 8393, 8421);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10876, 2156, 8741);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10876, 2156, 8741);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static int? CheckForBadNonTrailingNamedArgument(AnalyzedArguments arguments, ParameterMap argsToParameters, ImmutableArray<ParameterSymbol> parameters)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10876, 8753, 10103);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 9095, 9186) || true) && (argsToParameters.IsTrivial)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10876, 9095, 9186);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 9159, 9171);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10876, 9095, 9186);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 9278, 9301);

                int
                foundPosition = -1
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 9315, 9354);

                int
                length = f_10876_9328_9353(arguments.Arguments)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 9377, 9382);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 9368, 9675) || true) && (i < length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 9396, 9399)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10876, 9368, 9675))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10876, 9368, 9675);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 9433, 9469);

                        int
                        parameter = argsToParameters[i]
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 9487, 9660) || true) && (parameter != -1 && (DynAbs.Tracing.TraceSender.Expression_True(10876, 9491, 9524) && parameter != i) && (DynAbs.Tracing.TraceSender.Expression_True(10876, 9491, 9553) && f_10876_9528_9545(arguments, i) != null))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10876, 9487, 9660);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 9595, 9613);

                            foundPosition = i;
                            DynAbs.Tracing.TraceSender.TraceBreak(10876, 9635, 9641);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10876, 9487, 9660);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10876, 1, 308);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10876, 1, 308);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 9691, 10064) || true) && (foundPosition != -1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10876, 9691, 10064);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 9827, 9848);
                        // Verify that all the following arguments are named
                        for (int
        i = foundPosition + 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 9818, 10049) || true) && (i < length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 9862, 9865)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10876, 9818, 10049))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10876, 9818, 10049);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 9907, 10030) || true) && (f_10876_9911_9928(arguments, i) == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10876, 9907, 10030);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 9986, 10007);

                                return foundPosition;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10876, 9907, 10030);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10876, 1, 232);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10876, 1, 232);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10876, 9691, 10064);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 10080, 10092);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10876, 8753, 10103);

                int
                f_10876_9328_9353(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10876, 9328, 9353);
                    return return_v;
                }


                string
                f_10876_9528_9545(Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                this_param, int
                i)
                {
                    var return_v = this_param.Name(i);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10876, 9528, 9545);
                    return return_v;
                }


                string
                f_10876_9911_9928(Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                this_param, int
                i)
                {
                    var return_v = this_param.Name(i);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10876, 9911, 9928);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10876, 8753, 10103);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10876, 8753, 10103);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static int? CorrespondsToAnyParameter(
                    ImmutableArray<ParameterSymbol> memberParameters,
                    bool expanded,
                    AnalyzedArguments arguments,
                    int argumentPosition,
                    bool isValidParams,
                    bool isVararg,
                    out bool isNamedArgument,
                    ref bool seenNamedParams,
                    ref bool seenOutOfPositionNamedArgument)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10876, 10115, 16216);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 12261, 12365);

                isNamedArgument = f_10876_12279_12300(arguments.Names) > argumentPosition && (DynAbs.Tracing.TraceSender.Expression_True(10876, 12279, 12364) && f_10876_12323_12356(arguments.Names, argumentPosition) != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 12381, 16177) || true) && (!isNamedArgument)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10876, 12381, 16177);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 13178, 13407) || true) && (seenNamedParams)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10876, 13178, 13407);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 13376, 13388);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10876, 13178, 13407);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 13427, 13652) || true) && (seenOutOfPositionNamedArgument)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10876, 13427, 13652);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 13621, 13633);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10876, 13427, 13652);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 13672, 13738);

                    int
                    parameterCount = memberParameters.Length + ((DynAbs.Tracing.TraceSender.Conditional_F1(10876, 13720, 13728) || ((isVararg && DynAbs.Tracing.TraceSender.Conditional_F2(10876, 13731, 13732)) || DynAbs.Tracing.TraceSender.Conditional_F3(10876, 13735, 13736))) ? 1 : 0)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 13756, 13905) || true) && (argumentPosition >= parameterCount)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10876, 13756, 13905);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 13836, 13886);

                        return (DynAbs.Tracing.TraceSender.Conditional_F1(10876, 13843, 13851) || ((expanded && DynAbs.Tracing.TraceSender.Conditional_F2(10876, 13854, 13872)) || DynAbs.Tracing.TraceSender.Conditional_F3(10876, 13875, 13885))) ? parameterCount - 1 : (int?)null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10876, 13756, 13905);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 13925, 13949);

                    return argumentPosition;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10876, 12381, 16177);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10876, 12381, 16177);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 15282, 15327);

                    var
                    name = f_10876_15293_15326(arguments.Names, argumentPosition)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 15354, 15359);
                        for (int
        p = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 15345, 16162) || true) && (p < memberParameters.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 15390, 15393)
        , ++p, DynAbs.Tracing.TraceSender.TraceExitCondition(10876, 15345, 16162))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10876, 15345, 16162);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 15639, 16143) || true) && (f_10876_15643_15667(memberParameters[p]) == name.Identifier.ValueText)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10876, 15639, 16143);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 15746, 15907) || true) && (isValidParams && (DynAbs.Tracing.TraceSender.Expression_True(10876, 15750, 15799) && p == memberParameters.Length - 1))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10876, 15746, 15907);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 15857, 15880);

                                    seenNamedParams = true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10876, 15746, 15907);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 15935, 16083) || true) && (p != argumentPosition)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10876, 15935, 16083);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 16018, 16056);

                                    seenOutOfPositionNamedArgument = true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10876, 15935, 16083);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 16111, 16120);

                                return p;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10876, 15639, 16143);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10876, 1, 818);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10876, 1, 818);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10876, 12381, 16177);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 16193, 16205);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10876, 10115, 16216);

                int
                f_10876_12279_12300(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10876, 12279, 12300);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                f_10876_12323_12356(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10876, 12323, 12356);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                f_10876_15293_15326(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10876, 15293, 15326);
                    return return_v;
                }


                string
                f_10876_15643_15667(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10876, 15643, 15667);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10876, 10115, 16216);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10876, 10115, 16216);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static ArgumentAnalysisResult AnalyzeArgumentsForNormalFormNoNamedArguments(
                    ImmutableArray<ParameterSymbol> parameters,
                    AnalyzedArguments arguments,
                    bool isMethodGroupConversion,
                    bool isVararg)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10876, 16228, 18308);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 16507, 16543);

                f_10876_16507_16542(f_10876_16520_16541_M(!parameters.IsDefault));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 16557, 16589);

                f_10876_16557_16588(arguments != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 16603, 16644);

                f_10876_16603_16643(f_10876_16616_16637(arguments.Names) == 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 16746, 16806);

                int
                parameterCount = parameters.Length + ((DynAbs.Tracing.TraceSender.Conditional_F1(10876, 16788, 16796) || ((isVararg && DynAbs.Tracing.TraceSender.Conditional_F2(10876, 16799, 16800)) || DynAbs.Tracing.TraceSender.Conditional_F3(10876, 16803, 16804))) ? 1 : 0)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 16820, 16866);

                int
                argumentCount = f_10876_16840_16865(arguments.Arguments)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 17370, 18049) || true) && (argumentCount < parameterCount)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10876, 17370, 18049);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 17447, 17480);
                        for (int
        parameterPosition = argumentCount
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 17438, 17861) || true) && (parameterPosition < parameterCount)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 17518, 17537)
        , ++parameterPosition, DynAbs.Tracing.TraceSender.TraceExitCondition(10876, 17438, 17861))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10876, 17438, 17861);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 17579, 17842) || true) && (parameters.Length == parameterPosition || (DynAbs.Tracing.TraceSender.Expression_False(10876, 17583, 17695) || !f_10876_17626_17695(parameters[parameterPosition], isMethodGroupConversion)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10876, 17579, 17842);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 17745, 17819);

                                return ArgumentAnalysisResult.RequiredParameterMissing(parameterPosition);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10876, 17579, 17842);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10876, 1, 424);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10876, 1, 424);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10876, 17370, 18049);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10876, 17370, 18049);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 17895, 18049) || true) && (parameterCount < argumentCount)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10876, 17895, 18049);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 17963, 18034);

                        return ArgumentAnalysisResult.NoCorrespondingParameter(parameterCount);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10876, 17895, 18049);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10876, 17370, 18049);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 18226, 18297);

                return ArgumentAnalysisResult.NormalForm(default(ImmutableArray<int>));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10876, 16228, 18308);

                bool
                f_10876_16520_16541_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10876, 16520, 16541);
                    return return_v;
                }


                int
                f_10876_16507_16542(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10876, 16507, 16542);
                    return 0;
                }


                int
                f_10876_16557_16588(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10876, 16557, 16588);
                    return 0;
                }


                int
                f_10876_16616_16637(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10876, 16616, 16637);
                    return return_v;
                }


                int
                f_10876_16603_16643(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10876, 16603, 16643);
                    return 0;
                }


                int
                f_10876_16840_16865(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10876, 16840, 16865);
                    return return_v;
                }


                bool
                f_10876_17626_17695(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                parameter, bool
                isMethodGroupConversion)
                {
                    var return_v = CanBeOptional(parameter, isMethodGroupConversion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10876, 17626, 17695);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10876, 16228, 18308);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10876, 16228, 18308);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool CanBeOptional(ParameterSymbol parameter, bool isMethodGroupConversion)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10876, 18320, 19326);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 19259, 19315);

                return !isMethodGroupConversion && (DynAbs.Tracing.TraceSender.Expression_True(10876, 19266, 19314) && f_10876_19294_19314(parameter));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10876, 18320, 19326);

                bool
                f_10876_19294_19314(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.IsOptional;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10876, 19294, 19314);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10876, 18320, 19326);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10876, 18320, 19326);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static int? NameUsedForPositional(AnalyzedArguments arguments, ParameterMap argsToParameters)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10876, 19338, 20797);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 19618, 19709) || true) && (argsToParameters.IsTrivial)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10876, 19618, 19709);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 19682, 19694);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10876, 19618, 19709);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 19943, 19963);

                    // PERFORMANCE: This is an O(n-squared) algorithm, but n will typically be small.  We could rewrite this
                    // PERFORMANCE: as a linear algorithm if we wanted to allocate more memory.

                    for (int
        argumentPosition = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 19934, 20758) || true) && (argumentPosition < argsToParameters.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 20009, 20027)
        , ++argumentPosition, DynAbs.Tracing.TraceSender.TraceExitCondition(10876, 19934, 20758))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10876, 19934, 20758);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 20061, 20743) || true) && (f_10876_20065_20097(arguments, argumentPosition) != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10876, 20061, 20743);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 20156, 20161);
                                for (int
            i = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 20147, 20724) || true) && (i < argumentPosition)
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 20185, 20188)
            , ++i, DynAbs.Tracing.TraceSender.TraceExitCondition(10876, 20147, 20724))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10876, 20147, 20724);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 20238, 20701) || true) && (f_10876_20242_20259(arguments, i) == null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10876, 20238, 20701);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 20325, 20674) || true) && (argsToParameters[argumentPosition] == argsToParameters[i])
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10876, 20325, 20674);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 20619, 20643);

                                            return argumentPosition;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10876, 20325, 20674);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10876, 20238, 20701);
                                    }
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10876, 1, 578);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10876, 1, 578);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10876, 20061, 20743);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10876, 1, 825);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10876, 1, 825);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 20774, 20786);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10876, 19338, 20797);

                string
                f_10876_20065_20097(Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                this_param, int
                i)
                {
                    var return_v = this_param.Name(i);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10876, 20065, 20097);
                    return return_v;
                }


                string
                f_10876_20242_20259(Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                this_param, int
                i)
                {
                    var return_v = this_param.Name(i);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10876, 20242, 20259);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10876, 19338, 20797);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10876, 19338, 20797);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static int? CheckForMissingRequiredParameter(
                    ParameterMap argsToParameters,
                    ImmutableArray<ParameterSymbol> parameters,
                    bool isMethodGroupConversion,
                    bool expanded)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10876, 20809, 22883);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 21059, 21112);

                f_10876_21059_21111(!(expanded && (DynAbs.Tracing.TraceSender.Expression_True(10876, 21074, 21109) && isMethodGroupConversion)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 21269, 21334);

                int
                count = (DynAbs.Tracing.TraceSender.Conditional_F1(10876, 21281, 21289) || ((expanded && DynAbs.Tracing.TraceSender.Conditional_F2(10876, 21292, 21313)) || DynAbs.Tracing.TraceSender.Conditional_F3(10876, 21316, 21333))) ? parameters.Length - 1 : parameters.Length
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 21588, 21715) || true) && (argsToParameters.IsTrivial && (DynAbs.Tracing.TraceSender.Expression_True(10876, 21592, 21654) && count <= argsToParameters.Length))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10876, 21588, 21715);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 21688, 21700);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10876, 21588, 21715);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 22230, 22235);

                    // This is an O(n squared) algorithm, but (1) we avoid allocating any more heap memory, and
                    // (2) n is likely to be small, both because the number of parameters in a method is typically
                    // small, and because methods with many parameters make most of them optional. We could make
                    // this linear easily enough if we needed to but we'd have to allocate more heap memory and
                    // we'd rather not pressure the garbage collector.

                    for (int
        p = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 22221, 22844) || true) && (p < count)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 22248, 22251)
        , ++p, DynAbs.Tracing.TraceSender.TraceExitCondition(10876, 22221, 22844))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10876, 22221, 22844);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 22285, 22412) || true) && (f_10876_22289_22342(parameters[p], isMethodGroupConversion))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10876, 22285, 22412);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 22384, 22393);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10876, 22285, 22412);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 22432, 22451);

                        bool
                        found = false
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 22478, 22485);
                            for (int
            arg = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 22469, 22731) || true) && (arg < argsToParameters.Length)
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 22518, 22523)
            , ++arg, DynAbs.Tracing.TraceSender.TraceExitCondition(10876, 22469, 22731))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10876, 22469, 22731);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 22565, 22602);

                                found = (argsToParameters[arg] == p);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 22624, 22712) || true) && (found)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10876, 22624, 22712);
                                    DynAbs.Tracing.TraceSender.TraceBreak(10876, 22683, 22689);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10876, 22624, 22712);
                                }
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10876, 1, 263);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10876, 1, 263);
                        }
                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 22749, 22829) || true) && (!found)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10876, 22749, 22829);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 22801, 22810);

                            return p;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10876, 22749, 22829);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10876, 1, 624);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10876, 1, 624);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 22860, 22872);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10876, 20809, 22883);

                int
                f_10876_21059_21111(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10876, 21059, 21111);
                    return 0;
                }


                bool
                f_10876_22289_22342(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                parameter, bool
                isMethodGroupConversion)
                {
                    var return_v = CanBeOptional(parameter, isMethodGroupConversion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10876, 22289, 22342);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10876, 20809, 22883);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10876, 20809, 22883);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static int? CheckForDuplicateNamedArgument(AnalyzedArguments arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10876, 22895, 23756);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 22999, 23151) || true) && (f_10876_23003_23028(arguments.Names))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10876, 22999, 23151);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 23124, 23136);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10876, 22999, 23151);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 23167, 23224);

                var
                alreadyDefined = f_10876_23188_23223()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 23247, 23252);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 23238, 23681) || true) && (i < f_10876_23258_23279(arguments.Names))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 23281, 23284)
        , ++i, DynAbs.Tracing.TraceSender.TraceExitCondition(10876, 23238, 23681))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10876, 23238, 23681);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 23318, 23350);

                        string
                        name = f_10876_23332_23349(arguments, i)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 23370, 23503) || true) && (name is null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10876, 23370, 23503);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 23475, 23484);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10876, 23370, 23503);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 23523, 23666) || true) && (!f_10876_23528_23552(alreadyDefined, name))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10876, 23523, 23666);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 23594, 23616);

                            f_10876_23594_23615(alreadyDefined);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 23638, 23647);

                            return i;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10876, 23523, 23666);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10876, 1, 444);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10876, 1, 444);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 23697, 23719);

                f_10876_23697_23718(
                            alreadyDefined);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10876, 23733, 23745);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10876, 22895, 23756);

                bool
                f_10876_23003_23028(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax>
                source)
                {
                    var return_v = source.IsEmpty<Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10876, 23003, 23028);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<string>
                f_10876_23188_23223()
                {
                    var return_v = PooledHashSet<string>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10876, 23188, 23223);
                    return return_v;
                }


                int
                f_10876_23258_23279(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10876, 23258, 23279);
                    return return_v;
                }


                string
                f_10876_23332_23349(Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                this_param, int
                i)
                {
                    var return_v = this_param.Name(i);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10876, 23332, 23349);
                    return return_v;
                }


                bool
                f_10876_23528_23552(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10876, 23528, 23552);
                    return return_v;
                }


                int
                f_10876_23594_23615(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<string>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10876, 23594, 23615);
                    return 0;
                }


                int
                f_10876_23697_23718(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<string>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10876, 23697, 23718);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10876, 22895, 23756);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10876, 22895, 23756);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
}
