// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Diagnostics;
using System.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.Text
{
    internal sealed partial class StringBuilderText : SourceText
    {
        private readonly StringBuilder _builder;

        private readonly Encoding? _encodingOpt;

        public StringBuilderText(StringBuilder builder, Encoding? encodingOpt, SourceHashAlgorithm checksumAlgorithm)
        : base(checksumAlgorithm: f_725_912_948_C(checksumAlgorithm))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(725, 781, 1097);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(725, 708, 716);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(725, 756, 768);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(725, 974, 1010);

                f_725_974_1009(builder != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(725, 1026, 1045);

                _builder = builder;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(725, 1059, 1086);

                _encodingOpt = encodingOpt;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(725, 781, 1097);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(725, 781, 1097);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(725, 781, 1097);
            }
        }

        public override Encoding? Encoding
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(725, 1168, 1196);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(725, 1174, 1194);

                    return _encodingOpt;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(725, 1168, 1196);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(725, 1109, 1207);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(725, 1109, 1207);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal StringBuilder Builder
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(725, 1400, 1424);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(725, 1406, 1422);

                    return _builder;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(725, 1400, 1424);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(725, 1345, 1435);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(725, 1345, 1435);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int Length
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(725, 1629, 1660);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(725, 1635, 1658);

                    return f_725_1642_1657(_builder);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(725, 1629, 1660);

                    int
                    f_725_1642_1657(System.Text.StringBuilder
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(725, 1642, 1657);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(725, 1578, 1671);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(725, 1578, 1671);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        /// <summary>
        /// Returns a character at given position.
        /// </summary>
        /// <param name="position">The position to get the character from.</param>
        /// <returns>The character.</returns>
        /// <exception cref="ArgumentOutOfRangeException">When position is negative or 
        /// greater than <see cref="Length"/>.</exception>
        public override char this[int position]
        {

            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(725, 2126, 2387);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(725, 2162, 2326) || true) && (position < 0 || (DynAbs.Tracing.TraceSender.Expression_False(725, 2166, 2209) || position >= f_725_2194_2209(_builder)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(725, 2162, 2326);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(725, 2251, 2307);

                        throw f_725_2257_2306(nameof(position));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(725, 2162, 2326);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(725, 2346, 2372);

                    return f_725_2353_2371(_builder, position);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(725, 2126, 2387);

                    int
                    f_725_2194_2209(System.Text.StringBuilder
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(725, 2194, 2209);
                        return return_v;
                    }


                    System.ArgumentOutOfRangeException
                    f_725_2257_2306(string
                    paramName)
                    {
                        var return_v = new System.ArgumentOutOfRangeException(paramName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(725, 2257, 2306);
                        return return_v;
                    }


                    char
                    f_725_2353_2371(System.Text.StringBuilder
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(725, 2353, 2371);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(725, 2126, 2387);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(725, 2126, 2387);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string ToString(TextSpan span)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(725, 2672, 2951);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(725, 2743, 2874) || true) && (span.End > f_725_2758_2773(_builder))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(725, 2743, 2874);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(725, 2807, 2859);

                    throw f_725_2813_2858(nameof(span));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(725, 2743, 2874);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(725, 2890, 2940);

                return f_725_2897_2939(_builder, span.Start, span.Length);
                DynAbs.Tracing.TraceSender.TraceExitMethod(725, 2672, 2951);

                int
                f_725_2758_2773(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(725, 2758, 2773);
                    return return_v;
                }


                System.ArgumentOutOfRangeException
                f_725_2813_2858(string
                paramName)
                {
                    var return_v = new System.ArgumentOutOfRangeException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(725, 2813, 2858);
                    return return_v;
                }


                string
                f_725_2897_2939(System.Text.StringBuilder
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.ToString(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(725, 2897, 2939);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(725, 2672, 2951);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(725, 2672, 2951);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override void CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(725, 2963, 3163);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(725, 3085, 3152);

                f_725_3085_3151(_builder, sourceIndex, destination, destinationIndex, count);
                DynAbs.Tracing.TraceSender.TraceExitMethod(725, 2963, 3163);

                int
                f_725_3085_3151(System.Text.StringBuilder
                this_param, int
                sourceIndex, char[]
                destination, int
                destinationIndex, int
                count)
                {
                    this_param.CopyTo(sourceIndex, destination, destinationIndex, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(725, 3085, 3151);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(725, 2963, 3163);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(725, 2963, 3163);
            }
        }

        static StringBuilderText()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(725, 479, 3170);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(725, 479, 3170);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(725, 479, 3170);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(725, 479, 3170);

        static int
        f_725_974_1009(bool
        b)
        {
            RoslynDebug.Assert(b);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(725, 974, 1009);
            return 0;
        }


        static Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
        f_725_912_948_C(Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(725, 781, 1097);
            return return_v;
        }

    }
}
