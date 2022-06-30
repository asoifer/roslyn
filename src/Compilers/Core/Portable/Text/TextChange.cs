// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.Text
{

    [DataContract]
    [DebuggerDisplay("{GetDebuggerDisplay(),nq}")]
    public readonly struct TextChange : IEquatable<TextChange>
    {

        [DataMember(Order = 0)]
        public TextSpan Span { get; }

        [DataMember(Order = 1)]
        public string? NewText { get; }

        public TextChange(TextSpan span, string newText)
                    : this()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(729, 1243, 1536);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(729, 1338, 1455) || true) && (newText == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(729, 1338, 1455);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(729, 1391, 1440);

                    throw f_729_1397_1439(nameof(newText));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(729, 1338, 1455);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(729, 1471, 1488);

                this.Span = span;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(729, 1502, 1525);

                this.NewText = newText;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(729, 1243, 1536);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(729, 1243, 1536);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(729, 1243, 1536);
            }
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(729, 1671, 1824);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(729, 1729, 1813);

                // LAFHIS
                var temp = this.GetType();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(729, 1777, 1791);

                return f_729_1736_1812("{0}: {{ {1}, \"{2}\" }}", f_729_1777_1796(temp), Span, NewText);
                DynAbs.Tracing.TraceSender.TraceExitMethod(729, 1671, 1824);

                System.Type
                f_729_1777_1791(ref Microsoft.CodeAnalysis.Text.TextChange
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(729, 1777, 1791);
                    return return_v;
                }


                string
                f_729_1777_1796(System.Type
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(729, 1777, 1796);
                    return return_v;
                }


                string
                f_729_1736_1812(string
                format, string
                arg0, Microsoft.CodeAnalysis.Text.TextSpan
                arg1, string?
                arg2)
                {
                    var return_v = string.Format(format, (object)arg0, (object)arg1, (object?)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(729, 1736, 1812);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(729, 1671, 1824);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(729, 1671, 1824);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool Equals(object? obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(729, 1836, 1969);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(729, 1901, 1958);

                return obj is TextChange && (DynAbs.Tracing.TraceSender.Expression_True(729, 1908, 1957) && this.Equals(obj));
                DynAbs.Tracing.TraceSender.TraceExitMethod(729, 1836, 1969);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(729, 1836, 1969);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(729, 1836, 1969);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool Equals(TextChange other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(729, 1981, 2231);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(729, 2042, 2220);

                return
                f_729_2066_2130(f_729_2066_2100(), this.Span, other.Span) && (DynAbs.Tracing.TraceSender.Expression_True(729, 2066, 2219) && f_729_2151_2219(f_729_2151_2183(), this.NewText, other.NewText));
                DynAbs.Tracing.TraceSender.TraceExitMethod(729, 1981, 2231);

                System.Collections.Generic.EqualityComparer<Microsoft.CodeAnalysis.Text.TextSpan>
                f_729_2066_2100()
                {
                    var return_v = EqualityComparer<TextSpan>.Default;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(729, 2066, 2100);
                    return return_v;
                }


                bool
                f_729_2066_2130(System.Collections.Generic.EqualityComparer<Microsoft.CodeAnalysis.Text.TextSpan>
                this_param, Microsoft.CodeAnalysis.Text.TextSpan
                x, Microsoft.CodeAnalysis.Text.TextSpan
                y)
                {
                    var return_v = this_param.Equals(x, y);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(729, 2066, 2130);
                    return return_v;
                }


                System.Collections.Generic.EqualityComparer<string>
                f_729_2151_2183()
                {
                    var return_v = EqualityComparer<string>.Default;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(729, 2151, 2183);
                    return return_v;
                }


                bool
                f_729_2151_2219(System.Collections.Generic.EqualityComparer<string>
                this_param, string?
                x, string?
                y)
                {
                    var return_v = this_param.Equals(x, y);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(729, 2151, 2219);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(729, 1981, 2231);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(729, 1981, 2231);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(729, 2243, 2391);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(729, 2301, 2380);

                return f_729_2308_2379(this.Span.GetHashCode(), f_729_2346_2373_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(this.NewText, 729, 2346, 2373).GetHashCode()) ?? (DynAbs.Tracing.TraceSender.Expression_Null<int?>(729, 2346, 2378) ?? 0));
                DynAbs.Tracing.TraceSender.TraceExitMethod(729, 2243, 2391);

                int?
                f_729_2346_2373_I(int?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(729, 2346, 2373);
                    return return_v;
                }


                int
                f_729_2308_2379(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(729, 2308, 2379);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(729, 2243, 2391);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(729, 2243, 2391);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool operator ==(TextChange left, TextChange right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(729, 2403, 2530);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(729, 2493, 2519);

                return left.Equals(right);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(729, 2403, 2530);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(729, 2403, 2530);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(729, 2403, 2530);
            }
        }

        public static bool operator !=(TextChange left, TextChange right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(729, 2542, 2667);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(729, 2632, 2656);

                return !(left == right);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(729, 2542, 2667);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(729, 2542, 2667);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(729, 2542, 2667);
            }
        }

        /// <summary>
        /// Converts a <see cref="TextChange"/> to a <see cref="TextChangeRange"/>.
        /// </summary>
        /// <param name="change"></param>
        public static implicit operator TextChangeRange(TextChange change)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(729, 2854, 3072);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(729, 2945, 2984);

                f_729_2945_2983(change.NewText is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(729, 2998, 3061);

                return f_729_3005_3060(change.Span, f_729_3038_3059(change.NewText));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(729, 2854, 3072);

                int
                f_729_2945_2983(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(729, 2945, 2983);
                    return 0;
                }


                int
                f_729_3038_3059(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(729, 3038, 3059);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextChangeRange
                f_729_3005_3060(Microsoft.CodeAnalysis.Text.TextSpan
                span, int
                newLength)
                {
                    var return_v = new Microsoft.CodeAnalysis.Text.TextChangeRange(span, newLength);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(729, 3005, 3060);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(729, 2854, 3072);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(729, 2854, 3072);
            }
        }
        public static IReadOnlyList<TextChange> NoChanges
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(729, 3219, 3276);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(729, 3222, 3276);
                    return f_729_3222_3276(); 
                    DynAbs.Tracing.TraceSender.TraceExitMethod(729, 3219, 3276);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(729, 3219, 3276);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(729, 3219, 3276);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal string GetDebuggerDisplay()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(729, 3289, 3684);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(729, 3350, 3573);

                var
                newTextDisplay = NewText switch
                {
                    null when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(729, 3418, 3432) && DynAbs.Tracing.TraceSender.Expression_True(729, 3418, 3432))
=> "null",
                    { Length: < 10 } when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(729, 3451, 3487) && DynAbs.Tracing.TraceSender.Expression_True(729, 3451, 3487))
=> $"\"{NewText}\"",
                    { Length: var length } when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(729, 3506, 3557) && DynAbs.Tracing.TraceSender.Expression_True(729, 3506, 3557))
=> $"(NewLength = {length})"
                }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(729, 3587, 3673);

                return $"new TextChange(new TextSpan({Span.Start}, {Span.Length}), {newTextDisplay})";
                DynAbs.Tracing.TraceSender.TraceExitMethod(729, 3289, 3684);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(729, 3289, 3684);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(729, 3289, 3684);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        static TextChange()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(729, 521, 3691);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(729, 521, 3691);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(729, 521, 3691);
        }

        static System.ArgumentNullException
        f_729_1397_1439(string
        paramName)
        {
            var return_v = new System.ArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(729, 1397, 1439);
            return return_v;
        }


        static System.Collections.Generic.IReadOnlyList<Microsoft.CodeAnalysis.Text.TextChange>
        f_729_3222_3276()
        {
            var return_v = SpecializedCollections.EmptyReadOnlyList<TextChange>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(729, 3222, 3276);
            return return_v;
        }

    }
}
