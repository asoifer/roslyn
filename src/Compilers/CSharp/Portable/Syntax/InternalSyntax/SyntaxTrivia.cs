// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Diagnostics;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax
{
    internal class SyntaxTrivia : CSharpSyntaxNode
    {
        public readonly string Text;

        internal SyntaxTrivia(SyntaxKind kind, string text, DiagnosticInfo[]? diagnostics = null, SyntaxAnnotation[]? annotations = null)
        : base(f_10020_585_589_C(kind), diagnostics, annotations, f_10020_617_628(text))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10020, 435, 838);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10020, 418, 422);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10020, 654, 671);

                this.Text = text;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10020, 685, 827) || true) && (kind == SyntaxKind.PreprocessingMessageTrivia)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10020, 685, 827);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10020, 768, 812);

                    this.flags |= NodeFlags.ContainsSkippedText;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10020, 685, 827);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10020, 435, 838);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10020, 435, 838);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10020, 435, 838);
            }
        }

        internal SyntaxTrivia(ObjectReader reader)
        : base(f_10020_913_919_C(reader))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10020, 850, 1036);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10020, 418, 422);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10020, 945, 977);

                this.Text = f_10020_957_976(reader);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10020, 991, 1025);

                this.FullWidth = f_10020_1008_1024(this.Text);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10020, 850, 1036);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10020, 850, 1036);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10020, 850, 1036);
            }
        }

        static SyntaxTrivia()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10020, 1048, 1185);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10020, 1094, 1174);

                f_10020_1094_1173(typeof(SyntaxTrivia), r => new SyntaxTrivia(r));
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10020, 1048, 1185);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10020, 1048, 1185);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10020, 1048, 1185);
            }
        }

        public override bool IsTrivia
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10020, 1227, 1234);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10020, 1230, 1234);
                    return true; DynAbs.Tracing.TraceSender.TraceExitMethod(10020, 1227, 1234);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10020, 1227, 1234);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10020, 1227, 1234);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool ShouldReuseInSerialization
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10020, 1297, 1442);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10020, 1300, 1442);
                    return f_10020_1300_1309(this) == SyntaxKind.WhitespaceTrivia && (DynAbs.Tracing.TraceSender.Expression_True(10020, 1300, 1442) && f_10020_1406_1415() < Lexer.MaxCachedTokenSize); DynAbs.Tracing.TraceSender.TraceExitMethod(10020, 1297, 1442);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10020, 1297, 1442);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10020, 1297, 1442);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override void WriteTo(ObjectWriter writer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10020, 1455, 1607);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10020, 1531, 1552);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.WriteTo(writer), 10020, 1531, 1551);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10020, 1566, 1596);

                f_10020_1566_1595(writer, this.Text);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10020, 1455, 1607);

                int
                f_10020_1566_1595(Roslyn.Utilities.ObjectWriter
                this_param, string
                value)
                {
                    this_param.WriteString(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10020, 1566, 1595);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10020, 1455, 1607);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10020, 1455, 1607);
            }
        }

        internal static SyntaxTrivia Create(SyntaxKind kind, string text)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10020, 1619, 1756);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10020, 1709, 1745);

                return f_10020_1716_1744(kind, text);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10020, 1619, 1756);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxTrivia
                f_10020_1716_1744(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, string
                text)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxTrivia(kind, text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10020, 1716, 1744);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10020, 1619, 1756);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10020, 1619, 1756);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string ToFullString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10020, 1768, 1858);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10020, 1830, 1847);

                return this.Text;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10020, 1768, 1858);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10020, 1768, 1858);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10020, 1768, 1858);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10020, 1870, 1956);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10020, 1928, 1945);

                return this.Text;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10020, 1870, 1956);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10020, 1870, 1956);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10020, 1870, 1956);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override GreenNode GetSlot(int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10020, 1968, 2087);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10020, 2039, 2076);

                throw f_10020_2045_2075();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10020, 1968, 2087);

                System.Exception
                f_10020_2045_2075()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10020, 2045, 2075);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10020, 1968, 2087);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10020, 1968, 2087);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int Width
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10020, 2149, 2289);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10020, 2185, 2234);

                    f_10020_2185_2233(f_10020_2198_2212(this) == f_10020_2216_2232(this.Text));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10020, 2252, 2274);

                    return f_10020_2259_2273(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10020, 2149, 2289);

                    int
                    f_10020_2198_2212(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxTrivia
                    this_param)
                    {
                        var return_v = this_param.FullWidth;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10020, 2198, 2212);
                        return return_v;
                    }


                    int
                    f_10020_2216_2232(string
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10020, 2216, 2232);
                        return return_v;
                    }


                    int
                    f_10020_2185_2233(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10020, 2185, 2233);
                        return 0;
                    }


                    int
                    f_10020_2259_2273(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxTrivia
                    this_param)
                    {
                        var return_v = this_param.FullWidth;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10020, 2259, 2273);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10020, 2099, 2300);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10020, 2099, 2300);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int GetLeadingTriviaWidth()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10020, 2312, 2400);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10020, 2380, 2389);

                return 0;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10020, 2312, 2400);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10020, 2312, 2400);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10020, 2312, 2400);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetTrailingTriviaWidth()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10020, 2412, 2501);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10020, 2481, 2490);

                return 0;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10020, 2412, 2501);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10020, 2412, 2501);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10020, 2412, 2501);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override GreenNode SetDiagnostics(DiagnosticInfo[]? diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10020, 2513, 2699);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10020, 2611, 2688);

                return f_10020_2618_2687(f_10020_2635_2644(this), this.Text, diagnostics, f_10020_2670_2686(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10020, 2513, 2699);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10020_2635_2644(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxTrivia
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10020, 2635, 2644);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxAnnotation[]
                f_10020_2670_2686(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxTrivia
                this_param)
                {
                    var return_v = this_param.GetAnnotations();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10020, 2670, 2686);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxTrivia
                f_10020_2618_2687(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, string
                text, Microsoft.CodeAnalysis.DiagnosticInfo[]?
                diagnostics, Microsoft.CodeAnalysis.SyntaxAnnotation[]
                annotations)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxTrivia(kind, text, diagnostics, annotations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10020, 2618, 2687);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10020, 2513, 2699);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10020, 2513, 2699);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override GreenNode SetAnnotations(SyntaxAnnotation[]? annotations)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10020, 2711, 2899);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10020, 2811, 2888);

                return f_10020_2818_2887(f_10020_2835_2844(this), this.Text, f_10020_2857_2873(this), annotations);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10020, 2711, 2899);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10020_2835_2844(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxTrivia
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10020, 2835, 2844);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo[]
                f_10020_2857_2873(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxTrivia
                this_param)
                {
                    var return_v = this_param.GetDiagnostics();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10020, 2857, 2873);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxTrivia
                f_10020_2818_2887(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, string
                text, Microsoft.CodeAnalysis.DiagnosticInfo[]
                diagnostics, Microsoft.CodeAnalysis.SyntaxAnnotation[]?
                annotations)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxTrivia(kind, text, diagnostics, annotations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10020, 2818, 2887);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10020, 2711, 2899);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10020, 2711, 2899);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override TResult Accept<TResult>(CSharpSyntaxVisitor<TResult> visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10020, 2911, 3057);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10020, 3013, 3046);

                return f_10020_3020_3045<TResult>(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10020, 2911, 3057);

                TResult
                f_10020_3020_3045<TResult>(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxVisitor<TResult>
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxTrivia
                trivia)
                {
                    var return_v = this_param.VisitTrivia(trivia);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10020, 3020, 3045);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10020, 2911, 3057);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10020, 2911, 3057);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override void Accept(CSharpSyntaxVisitor visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10020, 3069, 3187);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10020, 3150, 3176);

                f_10020_3150_3175(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10020, 3069, 3187);

                int
                f_10020_3150_3175(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxTrivia
                trivia)
                {
                    this_param.VisitTrivia(trivia);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10020, 3150, 3175);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10020, 3069, 3187);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10020, 3069, 3187);
            }
        }

        protected override void WriteTriviaTo(System.IO.TextWriter writer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10020, 3199, 3320);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10020, 3290, 3309);

                f_10020_3290_3308(writer, Text);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10020, 3199, 3320);

                int
                f_10020_3290_3308(System.IO.TextWriter
                this_param, string
                value)
                {
                    this_param.Write(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10020, 3290, 3308);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10020, 3199, 3320);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10020, 3199, 3320);
            }
        }

        public static implicit operator CodeAnalysis.SyntaxTrivia(SyntaxTrivia trivia)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10020, 3332, 3530);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10020, 3435, 3519);

                return f_10020_3442_3518(token: default, trivia, position: 0, index: 0);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10020, 3332, 3530);

                Microsoft.CodeAnalysis.SyntaxTrivia
                f_10020_3442_3518(Microsoft.CodeAnalysis.SyntaxToken
                token, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxTrivia
                triviaNode, int
                position, int
                index)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxTrivia(token: token, (Microsoft.CodeAnalysis.GreenNode)triviaNode, position: position, index: index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10020, 3442, 3518);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10020, 3332, 3530);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10020, 3332, 3530);
            }
        }
        public override bool IsEquivalentTo(GreenNode? other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10020, 3542, 3873);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10020, 3620, 3713) || true) && (!DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.IsEquivalentTo(other), 10020, 3625, 3651))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10020, 3620, 3713);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10020, 3685, 3698);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10020, 3620, 3713);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10020, 3729, 3834) || true) && (this.Text != ((SyntaxTrivia)other).Text)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10020, 3729, 3834);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10020, 3806, 3819);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10020, 3729, 3834);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10020, 3850, 3862);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10020, 3542, 3873);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10020, 3542, 3873);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10020, 3542, 3873);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override SyntaxNode CreateRed(SyntaxNode? parent, int position)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10020, 3885, 4030);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10020, 3982, 4019);

                throw f_10020_3988_4018();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10020, 3885, 4030);

                System.Exception
                f_10020_3988_4018()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10020, 3988, 4018);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10020, 3885, 4030);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10020, 3885, 4030);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10020, 332, 4037);

        static int
        f_10020_617_628(string
        this_param)
        {
            var return_v = this_param.Length;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10020, 617, 628);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.SyntaxKind
        f_10020_585_589_C(Microsoft.CodeAnalysis.CSharp.SyntaxKind
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10020, 435, 838);
            return return_v;
        }


        string
        f_10020_957_976(Roslyn.Utilities.ObjectReader
        this_param)
        {
            var return_v = this_param.ReadString();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10020, 957, 976);
            return return_v;
        }


        int
        f_10020_1008_1024(string
        this_param)
        {
            var return_v = this_param.Length;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10020, 1008, 1024);
            return return_v;
        }


        static Roslyn.Utilities.ObjectReader
        f_10020_913_919_C(Roslyn.Utilities.ObjectReader
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10020, 850, 1036);
            return return_v;
        }


        static int
        f_10020_1094_1173(System.Type
        type, System.Func<Roslyn.Utilities.ObjectReader, Roslyn.Utilities.IObjectWritable>
        typeReader)
        {
            ObjectBinder.RegisterTypeReader(type, typeReader);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10020, 1094, 1173);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.SyntaxKind
        f_10020_1300_1309(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxTrivia
        this_param)
        {
            var return_v = this_param.Kind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10020, 1300, 1309);
            return return_v;
        }


        int
        f_10020_1406_1415()
        {
            var return_v = FullWidth;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10020, 1406, 1415);
            return return_v;
        }

    }
}
