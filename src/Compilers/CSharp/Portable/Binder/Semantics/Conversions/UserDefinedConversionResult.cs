// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal enum UserDefinedConversionResultKind : byte
    {
        NoApplicableOperators,
        NoBestSourceType,
        NoBestTargetType,
        Ambiguous,
        Valid
    }

    internal struct UserDefinedConversionResult
    {

        public readonly ImmutableArray<UserDefinedConversionAnalysis> Results;

        public readonly int Best;

        public readonly UserDefinedConversionResultKind Kind;

        public static UserDefinedConversionResult NoApplicableOperators(ImmutableArray<UserDefinedConversionAnalysis> results)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10847, 878, 1191);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10847, 1021, 1180);

                return f_10847_1028_1179(UserDefinedConversionResultKind.NoApplicableOperators, results, -1);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10847, 878, 1191);

                Microsoft.CodeAnalysis.CSharp.UserDefinedConversionResult
                f_10847_1028_1179(Microsoft.CodeAnalysis.CSharp.UserDefinedConversionResultKind
                kind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.UserDefinedConversionAnalysis>
                results, int
                best)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.UserDefinedConversionResult(kind, results, best);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10847, 1028, 1179);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10847, 878, 1191);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10847, 878, 1191);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static UserDefinedConversionResult NoBestSourceType(ImmutableArray<UserDefinedConversionAnalysis> results)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10847, 1203, 1506);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10847, 1341, 1495);

                return f_10847_1348_1494(UserDefinedConversionResultKind.NoBestSourceType, results, -1);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10847, 1203, 1506);

                Microsoft.CodeAnalysis.CSharp.UserDefinedConversionResult
                f_10847_1348_1494(Microsoft.CodeAnalysis.CSharp.UserDefinedConversionResultKind
                kind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.UserDefinedConversionAnalysis>
                results, int
                best)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.UserDefinedConversionResult(kind, results, best);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10847, 1348, 1494);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10847, 1203, 1506);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10847, 1203, 1506);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static UserDefinedConversionResult NoBestTargetType(ImmutableArray<UserDefinedConversionAnalysis> results)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10847, 1518, 1821);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10847, 1656, 1810);

                return f_10847_1663_1809(UserDefinedConversionResultKind.NoBestTargetType, results, -1);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10847, 1518, 1821);

                Microsoft.CodeAnalysis.CSharp.UserDefinedConversionResult
                f_10847_1663_1809(Microsoft.CodeAnalysis.CSharp.UserDefinedConversionResultKind
                kind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.UserDefinedConversionAnalysis>
                results, int
                best)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.UserDefinedConversionResult(kind, results, best);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10847, 1663, 1809);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10847, 1518, 1821);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10847, 1518, 1821);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static UserDefinedConversionResult Ambiguous(ImmutableArray<UserDefinedConversionAnalysis> results)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10847, 1833, 2122);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10847, 1964, 2111);

                return f_10847_1971_2110(UserDefinedConversionResultKind.Ambiguous, results, -1);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10847, 1833, 2122);

                Microsoft.CodeAnalysis.CSharp.UserDefinedConversionResult
                f_10847_1971_2110(Microsoft.CodeAnalysis.CSharp.UserDefinedConversionResultKind
                kind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.UserDefinedConversionAnalysis>
                results, int
                best)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.UserDefinedConversionResult(kind, results, best);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10847, 1971, 2110);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10847, 1833, 2122);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10847, 1833, 2122);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static UserDefinedConversionResult Valid(ImmutableArray<UserDefinedConversionAnalysis> results, int best)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10847, 2134, 2427);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10847, 2271, 2416);

                return f_10847_2278_2415(UserDefinedConversionResultKind.Valid, results, best);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10847, 2134, 2427);

                Microsoft.CodeAnalysis.CSharp.UserDefinedConversionResult
                f_10847_2278_2415(Microsoft.CodeAnalysis.CSharp.UserDefinedConversionResultKind
                kind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.UserDefinedConversionAnalysis>
                results, int
                best)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.UserDefinedConversionResult(kind, results, best);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10847, 2278, 2415);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10847, 2134, 2427);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10847, 2134, 2427);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private UserDefinedConversionResult(
                    UserDefinedConversionResultKind kind,
                    ImmutableArray<UserDefinedConversionAnalysis> results,
                    int best)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10847, 2439, 2738);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10847, 2642, 2659);

                this.Kind = kind;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10847, 2673, 2696);

                this.Results = results;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10847, 2710, 2727);

                this.Best = best;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10847, 2439, 2738);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10847, 2439, 2738);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10847, 2439, 2738);
            }
        }

        public string Dump()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10847, 2761, 3301);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10847, 2806, 2847);

                var
                sb = f_10847_2815_2846()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10847, 2861, 2920);

                f_10847_2861_2919(sb, "User defined conversion analysis results:");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10847, 2934, 2974);

                f_10847_2934_2973(sb, "Summary: {0}\n", Kind);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10847, 2997, 3002);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10847, 2988, 3253) || true) && (i < Results.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10847, 3024, 3027)
        , ++i, DynAbs.Tracing.TraceSender.TraceExitCondition(10847, 2988, 3253))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10847, 2988, 3253);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10847, 3061, 3238);

                        f_10847_3061_3237(sb, "{0} Conversion: {1} Result: {2}\n", (DynAbs.Tracing.TraceSender.Conditional_F1(10847, 3135, 3144) || ((i == Best && DynAbs.Tracing.TraceSender.Conditional_F2(10847, 3147, 3150)) || DynAbs.Tracing.TraceSender.Conditional_F3(10847, 3153, 3156))) ? "*" : " ", Results[i].Operator, Results[i].Kind);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10847, 1, 266);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10847, 1, 266);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10847, 3269, 3290);

                return f_10847_3276_3289(sb);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10847, 2761, 3301);

                System.Text.StringBuilder
                f_10847_2815_2846()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10847, 2815, 2846);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10847_2861_2919(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10847, 2861, 2919);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10847_2934_2973(System.Text.StringBuilder
                this_param, string
                format, Microsoft.CodeAnalysis.CSharp.UserDefinedConversionResultKind
                arg0)
                {
                    var return_v = this_param.AppendFormat(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10847, 2934, 2973);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10847_3061_3237(System.Text.StringBuilder
                this_param, string
                format, string
                arg0, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                arg1, Microsoft.CodeAnalysis.CSharp.UserDefinedConversionAnalysisKind
                arg2)
                {
                    var return_v = this_param.AppendFormat(format, (object)arg0, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10847, 3061, 3237);
                    return return_v;
                }


                string
                f_10847_3276_3289(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10847, 3276, 3289);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10847, 2761, 3301);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10847, 2761, 3301);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        static UserDefinedConversionResult()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10847, 638, 3318);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10847, 638, 3318);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10847, 638, 3318);
        }

    }
}

