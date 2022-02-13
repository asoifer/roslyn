// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using System.Diagnostics;

namespace Microsoft.CodeAnalysis.CSharp
{

    internal struct ArgumentAnalysisResult
    {

        public readonly ImmutableArray<int> ArgsToParamsOpt;

        public readonly int ArgumentPosition;

        public readonly int ParameterPosition;

        public readonly ArgumentAnalysisResultKind Kind;

        public int ParameterFromArgument(int arg)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10866, 615, 917);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10866, 681, 704);

                f_10866_681_703(arg >= 0);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10866, 718, 807) || true) && (ArgsToParamsOpt.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10866, 718, 807);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10866, 781, 792);

                    return arg;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10866, 718, 807);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10866, 821, 864);

                f_10866_821_863(arg < ArgsToParamsOpt.Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10866, 878, 906);

                return ArgsToParamsOpt[arg];
                DynAbs.Tracing.TraceSender.TraceExitMethod(10866, 615, 917);

                int
                f_10866_681_703(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10866, 681, 703);
                    return 0;
                }


                int
                f_10866_821_863(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10866, 821, 863);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10866, 615, 917);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10866, 615, 917);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ArgumentAnalysisResult(ArgumentAnalysisResultKind kind,
                                            int argumentPosition,
                                            int parameterPosition,
                                            ImmutableArray<int> argsToParamsOpt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10866, 929, 1403);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10866, 1210, 1227);

                this.Kind = kind;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10866, 1241, 1282);

                this.ArgumentPosition = argumentPosition;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10866, 1296, 1339);

                this.ParameterPosition = parameterPosition;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10866, 1353, 1392);

                this.ArgsToParamsOpt = argsToParamsOpt;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10866, 929, 1403);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10866, 929, 1403);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10866, 929, 1403);
            }
        }

        public bool IsValid
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10866, 1459, 1569);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10866, 1495, 1554);

                    return this.Kind < ArgumentAnalysisResultKind.FirstInvalid;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10866, 1459, 1569);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10866, 1415, 1580);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10866, 1415, 1580);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static ArgumentAnalysisResult NameUsedForPositional(int argumentPosition)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10866, 1592, 1843);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10866, 1697, 1832);

                return f_10866_1704_1831(ArgumentAnalysisResultKind.NameUsedForPositional, argumentPosition, 0, default(ImmutableArray<int>));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10866, 1592, 1843);

                Microsoft.CodeAnalysis.CSharp.ArgumentAnalysisResult
                f_10866_1704_1831(Microsoft.CodeAnalysis.CSharp.ArgumentAnalysisResultKind
                kind, int
                argumentPosition, int
                parameterPosition, System.Collections.Immutable.ImmutableArray<int>
                argsToParamsOpt)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.ArgumentAnalysisResult(kind, argumentPosition, parameterPosition, argsToParamsOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10866, 1704, 1831);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10866, 1592, 1843);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10866, 1592, 1843);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ArgumentAnalysisResult NoCorrespondingParameter(int argumentPosition)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10866, 1855, 2112);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10866, 1963, 2101);

                return f_10866_1970_2100(ArgumentAnalysisResultKind.NoCorrespondingParameter, argumentPosition, 0, default(ImmutableArray<int>));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10866, 1855, 2112);

                Microsoft.CodeAnalysis.CSharp.ArgumentAnalysisResult
                f_10866_1970_2100(Microsoft.CodeAnalysis.CSharp.ArgumentAnalysisResultKind
                kind, int
                argumentPosition, int
                parameterPosition, System.Collections.Immutable.ImmutableArray<int>
                argsToParamsOpt)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.ArgumentAnalysisResult(kind, argumentPosition, parameterPosition, argsToParamsOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10866, 1970, 2100);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10866, 1855, 2112);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10866, 1855, 2112);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ArgumentAnalysisResult NoCorrespondingNamedParameter(int argumentPosition)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10866, 2124, 2391);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10866, 2237, 2380);

                return f_10866_2244_2379(ArgumentAnalysisResultKind.NoCorrespondingNamedParameter, argumentPosition, 0, default(ImmutableArray<int>));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10866, 2124, 2391);

                Microsoft.CodeAnalysis.CSharp.ArgumentAnalysisResult
                f_10866_2244_2379(Microsoft.CodeAnalysis.CSharp.ArgumentAnalysisResultKind
                kind, int
                argumentPosition, int
                parameterPosition, System.Collections.Immutable.ImmutableArray<int>
                argsToParamsOpt)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.ArgumentAnalysisResult(kind, argumentPosition, parameterPosition, argsToParamsOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10866, 2244, 2379);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10866, 2124, 2391);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10866, 2124, 2391);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ArgumentAnalysisResult DuplicateNamedArgument(int argumentPosition)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10866, 2403, 2656);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10866, 2509, 2645);

                return f_10866_2516_2644(ArgumentAnalysisResultKind.DuplicateNamedArgument, argumentPosition, 0, default(ImmutableArray<int>));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10866, 2403, 2656);

                Microsoft.CodeAnalysis.CSharp.ArgumentAnalysisResult
                f_10866_2516_2644(Microsoft.CodeAnalysis.CSharp.ArgumentAnalysisResultKind
                kind, int
                argumentPosition, int
                parameterPosition, System.Collections.Immutable.ImmutableArray<int>
                argsToParamsOpt)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.ArgumentAnalysisResult(kind, argumentPosition, parameterPosition, argsToParamsOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10866, 2516, 2644);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10866, 2403, 2656);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10866, 2403, 2656);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ArgumentAnalysisResult RequiredParameterMissing(int parameterPosition)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10866, 2668, 2927);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10866, 2777, 2916);

                return f_10866_2784_2915(ArgumentAnalysisResultKind.RequiredParameterMissing, 0, parameterPosition, default(ImmutableArray<int>));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10866, 2668, 2927);

                Microsoft.CodeAnalysis.CSharp.ArgumentAnalysisResult
                f_10866_2784_2915(Microsoft.CodeAnalysis.CSharp.ArgumentAnalysisResultKind
                kind, int
                argumentPosition, int
                parameterPosition, System.Collections.Immutable.ImmutableArray<int>
                argsToParamsOpt)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.ArgumentAnalysisResult(kind, argumentPosition, parameterPosition, argsToParamsOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10866, 2784, 2915);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10866, 2668, 2927);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10866, 2668, 2927);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ArgumentAnalysisResult BadNonTrailingNamedArgument(int argumentPosition)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10866, 2939, 3202);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10866, 3050, 3191);

                return f_10866_3057_3190(ArgumentAnalysisResultKind.BadNonTrailingNamedArgument, argumentPosition, 0, default(ImmutableArray<int>));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10866, 2939, 3202);

                Microsoft.CodeAnalysis.CSharp.ArgumentAnalysisResult
                f_10866_3057_3190(Microsoft.CodeAnalysis.CSharp.ArgumentAnalysisResultKind
                kind, int
                argumentPosition, int
                parameterPosition, System.Collections.Immutable.ImmutableArray<int>
                argsToParamsOpt)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.ArgumentAnalysisResult(kind, argumentPosition, parameterPosition, argsToParamsOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10866, 3057, 3190);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10866, 2939, 3202);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10866, 2939, 3202);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ArgumentAnalysisResult NormalForm(ImmutableArray<int> argsToParamsOpt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10866, 3214, 3426);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10866, 3323, 3415);

                return f_10866_3330_3414(ArgumentAnalysisResultKind.Normal, 0, 0, argsToParamsOpt);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10866, 3214, 3426);

                Microsoft.CodeAnalysis.CSharp.ArgumentAnalysisResult
                f_10866_3330_3414(Microsoft.CodeAnalysis.CSharp.ArgumentAnalysisResultKind
                kind, int
                argumentPosition, int
                parameterPosition, System.Collections.Immutable.ImmutableArray<int>
                argsToParamsOpt)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.ArgumentAnalysisResult(kind, argumentPosition, parameterPosition, argsToParamsOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10866, 3330, 3414);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10866, 3214, 3426);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10866, 3214, 3426);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ArgumentAnalysisResult ExpandedForm(ImmutableArray<int> argsToParamsOpt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10866, 3438, 3654);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10866, 3549, 3643);

                return f_10866_3556_3642(ArgumentAnalysisResultKind.Expanded, 0, 0, argsToParamsOpt);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10866, 3438, 3654);

                Microsoft.CodeAnalysis.CSharp.ArgumentAnalysisResult
                f_10866_3556_3642(Microsoft.CodeAnalysis.CSharp.ArgumentAnalysisResultKind
                kind, int
                argumentPosition, int
                parameterPosition, System.Collections.Immutable.ImmutableArray<int>
                argsToParamsOpt)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.ArgumentAnalysisResult(kind, argumentPosition, parameterPosition, argsToParamsOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10866, 3556, 3642);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10866, 3438, 3654);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10866, 3438, 3654);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private string Dump()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10866, 3685, 5706);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10866, 3731, 3745);

                string
                s = ""
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10866, 3759, 5392);

                switch (Kind)
                {

                    case ArgumentAnalysisResultKind.Normal:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10866, 3759, 5392);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10866, 3866, 3895);

                        s += "Valid in normal form.";
                        DynAbs.Tracing.TraceSender.TraceBreak(10866, 3917, 3923);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10866, 3759, 5392);

                    case ArgumentAnalysisResultKind.Expanded:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10866, 3759, 5392);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10866, 4004, 4035);

                        s += "Valid in expanded form.";
                        DynAbs.Tracing.TraceSender.TraceBreak(10866, 4057, 4063);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10866, 3759, 5392);

                    case ArgumentAnalysisResultKind.NameUsedForPositional:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10866, 3759, 5392);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10866, 4157, 4226);

                        // LAFHIS
                        s += "Invalid because argument " + ArgumentPosition.ToString() + " had a name.";
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10866, 4192, 4208);

                        DynAbs.Tracing.TraceSender.TraceBreak(10866, 4248, 4254);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10866, 3759, 5392);

                    case ArgumentAnalysisResultKind.DuplicateNamedArgument:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10866, 3759, 5392);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10866, 4349, 4433);

                        // LAFHIS
                        s += "Invalid because named argument " + ArgumentPosition.ToString() + " was specified twice.";
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10866, 4390, 4406);

                        DynAbs.Tracing.TraceSender.TraceBreak(10866, 4455, 4461);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10866, 3759, 5392);

                    case ArgumentAnalysisResultKind.NoCorrespondingParameter:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10866, 3759, 5392);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10866, 4558, 4647);

                        // LAFHIS
                        s += "Invalid because argument " + ArgumentPosition.ToString() + " has no corresponding parameter.";
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10866, 4593, 4609);
                        DynAbs.Tracing.TraceSender.TraceBreak(10866, 4669, 4675);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10866, 3759, 5392);

                    case ArgumentAnalysisResultKind.NoCorrespondingNamedParameter:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10866, 3759, 5392);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10866, 4777, 4872);

                        // LAFHIS
                        s += "Invalid because named argument " + ArgumentPosition.ToString() + " has no corresponding parameter.";
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10866, 4818, 4834);

                        DynAbs.Tracing.TraceSender.TraceBreak(10866, 4894, 4900);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10866, 3759, 5392);

                    case ArgumentAnalysisResultKind.RequiredParameterMissing:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10866, 3759, 5392);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10866, 4997, 5087);

                        // LAFHIS
                        s += "Invalid because parameter " + ParameterPosition.ToString() + " has no corresponding argument.";
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10866, 5033, 5050);

                        DynAbs.Tracing.TraceSender.TraceBreak(10866, 5109, 5115);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10866, 3759, 5392);

                    case ArgumentAnalysisResultKind.BadNonTrailingNamedArgument:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10866, 3759, 5392);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10866, 5215, 5349);

                        // LAFHIS
                        s += "Invalid because named argument " + ParameterPosition.ToString() + " is used out of position but some following argument(s) are not named.";
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10866, 5256, 5273);

                        DynAbs.Tracing.TraceSender.TraceBreak(10866, 5371, 5377);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10866, 3759, 5392);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10866, 5408, 5670) || true) && (f_10866_5412_5438_M(!ArgsToParamsOpt.IsDefault))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10866, 5408, 5670);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10866, 5481, 5486);
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10866, 5472, 5655) || true) && (i < ArgsToParamsOpt.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10866, 5516, 5519)
        , ++i, DynAbs.Tracing.TraceSender.TraceExitCondition(10866, 5472, 5655))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10866, 5472, 5655);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10866, 5561, 5636);

                            // LAFHIS
                            var temp = ArgsToParamsOpt[i];

                            s += "\nArgument " + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (i).ToString(), 10866, 5582, 5583) + " corresponds to parameter " + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => temp.ToString(), 10866, 5617, 5635);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10866, 1, 184);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10866, 1, 184);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10866, 5408, 5670);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10866, 5686, 5695);

                return s;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10866, 3685, 5706);

                bool
                f_10866_5412_5438_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10866, 5412, 5438);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10866, 3685, 5706);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10866, 3685, 5706);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        static ArgumentAnalysisResult()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10866, 343, 5723);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10866, 343, 5723);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10866, 343, 5723);
        }

    }
}
