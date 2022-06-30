// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Immutable;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.Text
{
    internal sealed class StringText : SourceText
    {
        private readonly string _source;

        private readonly Encoding? _encodingOpt;

        internal StringText(
                    string source,
                    Encoding? encodingOpt,
                    ImmutableArray<byte> checksum = default(ImmutableArray<byte>),
                    SourceHashAlgorithm checksumAlgorithm = SourceHashAlgorithm.Sha1,
                    ImmutableArray<byte> embeddedTextBlob = default(ImmutableArray<byte>))
        : base(f_726_1038_1046_C(checksum), checksumAlgorithm, embeddedTextBlob)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(726, 694, 1229);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(726, 624, 631);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(726, 669, 681);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(726, 1109, 1144);

                f_726_1109_1143(source != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(726, 1160, 1177);

                _source = source;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(726, 1191, 1218);

                _encodingOpt = encodingOpt;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(726, 694, 1229);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(726, 694, 1229);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(726, 694, 1229);
            }
        }

        public override Encoding? Encoding
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(726, 1276, 1291);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(726, 1279, 1291);
                    return _encodingOpt; DynAbs.Tracing.TraceSender.TraceExitMethod(726, 1276, 1291);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(726, 1276, 1291);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(726, 1276, 1291);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public string Source
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(726, 1464, 1474);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(726, 1467, 1474);
                    return _source; DynAbs.Tracing.TraceSender.TraceExitMethod(726, 1464, 1474);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(726, 1464, 1474);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(726, 1464, 1474);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(726, 1638, 1655);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(726, 1641, 1655);
                    return f_726_1641_1655(_source); DynAbs.Tracing.TraceSender.TraceExitMethod(726, 1638, 1655);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(726, 1638, 1655);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(726, 1638, 1655);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(726, 2111, 2368);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(726, 2328, 2353);

                    return f_726_2335_2352(_source, position);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(726, 2111, 2368);

                    char
                    f_726_2335_2352(string
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(726, 2335, 2352);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(726, 2111, 2368);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(726, 2111, 2368);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string ToString(TextSpan span)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(726, 2646, 3065);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(726, 2717, 2851) || true) && (span.End > f_726_2732_2750(f_726_2732_2743(this)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(726, 2717, 2851);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(726, 2784, 2836);

                    throw f_726_2790_2835(nameof(span));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(726, 2717, 2851);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(726, 2867, 2984) || true) && (span.Start == 0 && (DynAbs.Tracing.TraceSender.Expression_True(726, 2871, 2916) && span.Length == f_726_2905_2916(this)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(726, 2867, 2984);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(726, 2950, 2969);

                    return f_726_2957_2968(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(726, 2867, 2984);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(726, 3000, 3054);

                return f_726_3007_3053(f_726_3007_3018(this), span.Start, span.Length);
                DynAbs.Tracing.TraceSender.TraceExitMethod(726, 2646, 3065);

                string
                f_726_2732_2743(Microsoft.CodeAnalysis.Text.StringText
                this_param)
                {
                    var return_v = this_param.Source;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(726, 2732, 2743);
                    return return_v;
                }


                int
                f_726_2732_2750(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(726, 2732, 2750);
                    return return_v;
                }


                System.ArgumentOutOfRangeException
                f_726_2790_2835(string
                paramName)
                {
                    var return_v = new System.ArgumentOutOfRangeException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(726, 2790, 2835);
                    return return_v;
                }


                int
                f_726_2905_2916(Microsoft.CodeAnalysis.Text.StringText
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(726, 2905, 2916);
                    return return_v;
                }


                string
                f_726_2957_2968(Microsoft.CodeAnalysis.Text.StringText
                this_param)
                {
                    var return_v = this_param.Source;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(726, 2957, 2968);
                    return return_v;
                }


                string
                f_726_3007_3018(Microsoft.CodeAnalysis.Text.StringText
                this_param)
                {
                    var return_v = this_param.Source;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(726, 3007, 3018);
                    return return_v;
                }


                string
                f_726_3007_3053(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(726, 3007, 3053);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(726, 2646, 3065);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(726, 2646, 3065);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override void CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(726, 3077, 3280);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(726, 3199, 3269);

                f_726_3199_3268(f_726_3199_3210(this), sourceIndex, destination, destinationIndex, count);
                DynAbs.Tracing.TraceSender.TraceExitMethod(726, 3077, 3280);

                string
                f_726_3199_3210(Microsoft.CodeAnalysis.Text.StringText
                this_param)
                {
                    var return_v = this_param.Source;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(726, 3199, 3210);
                    return return_v;
                }


                int
                f_726_3199_3268(string
                this_param, int
                sourceIndex, char[]
                destination, int
                destinationIndex, int
                count)
                {
                    this_param.CopyTo(sourceIndex, destination, destinationIndex, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(726, 3199, 3268);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(726, 3077, 3280);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(726, 3077, 3280);
            }
        }

        public override void Write(TextWriter textWriter, TextSpan span, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(726, 3292, 3697);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(726, 3447, 3686) || true) && (span.Start == 0 && (DynAbs.Tracing.TraceSender.Expression_True(726, 3451, 3493) && span.End == f_726_3482_3493(this)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(726, 3447, 3686);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(726, 3527, 3557);

                    f_726_3527_3556(textWriter, f_726_3544_3555(this));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(726, 3447, 3686);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(726, 3447, 3686);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(726, 3623, 3671);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Write(textWriter, span, cancellationToken), 726, 3623, 3670);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(726, 3447, 3686);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(726, 3292, 3697);

                int
                f_726_3482_3493(Microsoft.CodeAnalysis.Text.StringText
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(726, 3482, 3493);
                    return return_v;
                }


                string
                f_726_3544_3555(Microsoft.CodeAnalysis.Text.StringText
                this_param)
                {
                    var return_v = this_param.Source;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(726, 3544, 3555);
                    return return_v;
                }


                int
                f_726_3527_3556(System.IO.TextWriter
                this_param, string
                value)
                {
                    this_param.Write(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(726, 3527, 3556);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(726, 3292, 3697);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(726, 3292, 3697);
            }
        }

        static StringText()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(726, 538, 3704);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(726, 538, 3704);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(726, 538, 3704);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(726, 538, 3704);

        static int
        f_726_1109_1143(bool
        b)
        {
            RoslynDebug.Assert(b);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(726, 1109, 1143);
            return 0;
        }


        static System.Collections.Immutable.ImmutableArray<byte>
        f_726_1038_1046_C(System.Collections.Immutable.ImmutableArray<byte>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(726, 694, 1229);
            return return_v;
        }


        int
        f_726_1641_1655(string
        this_param)
        {
            var return_v = this_param.Length;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(726, 1641, 1655);
            return return_v;
        }

    }
}
