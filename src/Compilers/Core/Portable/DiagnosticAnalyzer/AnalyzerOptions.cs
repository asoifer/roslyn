// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Immutable;
using System.Linq;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.Diagnostics
{
    public class AnalyzerOptions
    {
        internal static readonly AnalyzerOptions Empty;

        public ImmutableArray<AdditionalText> AdditionalFiles { get; }

        public AnalyzerConfigOptionsProvider AnalyzerConfigOptionsProvider { get; }

        public AnalyzerOptions(ImmutableArray<AdditionalText> additionalFiles, AnalyzerConfigOptionsProvider optionsProvider)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(237, 1425, 1837);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(237, 973, 1048);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(237, 1567, 1700) || true) && (optionsProvider is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(237, 1567, 1700);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(237, 1628, 1685);

                    throw f_237_1634_1684(nameof(optionsProvider));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(237, 1567, 1700);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(237, 1716, 1764);

                AdditionalFiles = additionalFiles.NullToEmpty();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(237, 1778, 1826);

                AnalyzerConfigOptionsProvider = optionsProvider;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(237, 1425, 1837);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(237, 1425, 1837);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(237, 1425, 1837);
            }
        }

        public AnalyzerOptions(ImmutableArray<AdditionalText> additionalFiles)
        : this(f_237_2197_2212_C(additionalFiles), f_237_2214_2257())
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(237, 2106, 2271);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(237, 2106, 2271);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(237, 2106, 2271);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(237, 2106, 2271);
            }
        }

        public AnalyzerOptions WithAdditionalFiles(ImmutableArray<AdditionalText> additionalFiles)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(237, 2419, 2709);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(237, 2534, 2638) || true) && (f_237_2538_2558(this) == additionalFiles)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(237, 2534, 2638);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(237, 2611, 2623);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(237, 2534, 2638);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(237, 2654, 2698);

                return f_237_2661_2697(additionalFiles);
                DynAbs.Tracing.TraceSender.TraceExitMethod(237, 2419, 2709);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AdditionalText>
                f_237_2538_2558(Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions
                this_param)
                {
                    var return_v = this_param.AdditionalFiles;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(237, 2538, 2558);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions
                f_237_2661_2697(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AdditionalText>
                additionalFiles)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions(additionalFiles);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(237, 2661, 2697);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(237, 2419, 2709);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(237, 2419, 2709);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool Equals(object? obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(237, 2721, 3137);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(237, 2786, 2877) || true) && (f_237_2790_2816(this, obj))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(237, 2786, 2877);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(237, 2850, 2862);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(237, 2786, 2877);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(237, 2893, 2928);

                var
                other = obj as AnalyzerOptions
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(237, 2942, 3126);

                return other != null && (DynAbs.Tracing.TraceSender.Expression_True(237, 2949, 3125) && (f_237_2984_3004(this) == f_237_3008_3029(other) || (DynAbs.Tracing.TraceSender.Expression_False(237, 2984, 3124) || this.AdditionalFiles.SequenceEqual(f_237_3085_3106(other), ReferenceEquals))));
                DynAbs.Tracing.TraceSender.TraceExitMethod(237, 2721, 3137);

                bool
                f_237_2790_2816(Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions
                objA, object?
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(237, 2790, 2816);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AdditionalText>
                f_237_2984_3004(Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions
                this_param)
                {
                    var return_v = this_param.AdditionalFiles;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(237, 2984, 3004);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AdditionalText>
                f_237_3008_3029(Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions
                this_param)
                {
                    var return_v = this_param.AdditionalFiles;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(237, 3008, 3029);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AdditionalText>
                f_237_3085_3106(Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions
                this_param)
                {
                    var return_v = this_param.AdditionalFiles;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(237, 3085, 3106);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(237, 2721, 3137);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(237, 2721, 3137);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(237, 3149, 3266);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(237, 3207, 3255);

                return f_237_3214_3254(f_237_3233_3253(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(237, 3149, 3266);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AdditionalText>
                f_237_3233_3253(Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions
                this_param)
                {
                    var return_v = this_param.AdditionalFiles;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(237, 3233, 3253);
                    return return_v;
                }


                int
                f_237_3214_3254(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AdditionalText>
                values)
                {
                    var return_v = Hash.CombineValues(values);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(237, 3214, 3254);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(237, 3149, 3266);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(237, 3149, 3266);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static AnalyzerOptions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(237, 460, 3273);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(237, 546, 611);
            Empty = f_237_554_611(ImmutableArray<AdditionalText>.Empty); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(237, 460, 3273);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(237, 460, 3273);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(237, 460, 3273);

        static Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions
        f_237_554_611(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AdditionalText>
        additionalFiles)
        {
            var return_v = new Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions(additionalFiles);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(237, 554, 611);
            return return_v;
        }


        static System.ArgumentNullException
        f_237_1634_1684(string
        paramName)
        {
            var return_v = new System.ArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(237, 1634, 1684);
            return return_v;
        }


        static Microsoft.CodeAnalysis.Diagnostics.CompilerAnalyzerConfigOptionsProvider
        f_237_2214_2257()
        {
            var return_v = CompilerAnalyzerConfigOptionsProvider.Empty;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(237, 2214, 2257);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AdditionalText>
        f_237_2197_2212_C(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AdditionalText>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(237, 2106, 2271);
            return return_v;
        }

    }
}
