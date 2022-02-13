// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.CodeAnalysis.Syntax.InternalSyntax;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax
{
    [DebuggerDisplay("{GetDebuggerDisplay(), nq}")]
    internal abstract class CSharpSyntaxNode : GreenNode
    {
        internal CSharpSyntaxNode(SyntaxKind kind)
        : base(f_10010_686_698_C((ushort)kind))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10010, 623, 762);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10010, 724, 751);

                f_10010_724_750(this);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10010, 623, 762);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10010, 623, 762);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10010, 623, 762);
            }
        }

        internal CSharpSyntaxNode(SyntaxKind kind, int fullWidth)
        : base(f_10010_852_864_C((ushort)kind), fullWidth)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10010, 774, 939);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10010, 901, 928);

                f_10010_901_927(this);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10010, 774, 939);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10010, 774, 939);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10010, 774, 939);
            }
        }

        internal CSharpSyntaxNode(SyntaxKind kind, DiagnosticInfo[] diagnostics)
        : base(f_10010_1044_1056_C((ushort)kind), diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10010, 951, 1133);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10010, 1095, 1122);

                f_10010_1095_1121(this);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10010, 951, 1133);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10010, 951, 1133);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10010, 951, 1133);
            }
        }

        internal CSharpSyntaxNode(SyntaxKind kind, DiagnosticInfo[] diagnostics, int fullWidth)
        : base(f_10010_1253_1265_C((ushort)kind), diagnostics, fullWidth)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10010, 1145, 1353);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10010, 1315, 1342);

                f_10010_1315_1341(this);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10010, 1145, 1353);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10010, 1145, 1353);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10010, 1145, 1353);
            }
        }

        internal CSharpSyntaxNode(SyntaxKind kind, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
        : base(f_10010_1490_1502_C((ushort)kind), diagnostics, annotations)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10010, 1365, 1592);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10010, 1554, 1581);

                f_10010_1554_1580(this);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10010, 1365, 1592);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10010, 1365, 1592);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10010, 1365, 1592);
            }
        }

        internal CSharpSyntaxNode(SyntaxKind kind, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations, int fullWidth)
        : base(f_10010_1744_1756_C((ushort)kind), diagnostics, annotations, fullWidth)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10010, 1604, 1857);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10010, 1819, 1846);

                f_10010_1819_1845(this);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10010, 1604, 1857);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10010, 1604, 1857);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10010, 1604, 1857);
            }
        }

        internal CSharpSyntaxNode(ObjectReader reader)
        : base(f_10010_1936_1942_C(reader))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10010, 1869, 1965);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10010, 1869, 1965);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10010, 1869, 1965);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10010, 1869, 1965);
            }
        }

        public override string Language
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10010, 2033, 2069);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10010, 2039, 2067);

                    return LanguageNames.CSharp;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10010, 2033, 2069);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10010, 1977, 2080);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10010, 1977, 2080);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public SyntaxKind Kind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10010, 2139, 2179);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10010, 2145, 2177);

                    return (SyntaxKind)f_10010_2164_2176(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10010, 2139, 2179);

                    int
                    f_10010_2164_2176(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode
                    this_param)
                    {
                        var return_v = this_param.RawKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10010, 2164, 2176);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10010, 2092, 2190);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10010, 2092, 2190);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string KindText
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10010, 2234, 2257);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10010, 2237, 2257);
                    return f_10010_2237_2257(f_10010_2237_2246(this)); DynAbs.Tracing.TraceSender.TraceExitMethod(10010, 2234, 2257);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10010, 2234, 2257);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10010, 2234, 2257);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int RawContextualKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10010, 2332, 2403);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10010, 2368, 2388);

                    return f_10010_2375_2387(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10010, 2332, 2403);

                    int
                    f_10010_2375_2387(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode
                    this_param)
                    {
                        var return_v = this_param.RawKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10010, 2375, 2387);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10010, 2270, 2414);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10010, 2270, 2414);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsStructuredTrivia
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10010, 2490, 2579);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10010, 2526, 2564);

                    return this is StructuredTriviaSyntax;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10010, 2490, 2579);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10010, 2426, 2590);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10010, 2426, 2590);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsDirective
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10010, 2659, 2747);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10010, 2695, 2732);

                    return this is DirectiveTriviaSyntax;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10010, 2659, 2747);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10010, 2602, 2758);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10010, 2602, 2758);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsSkippedTokensTrivia
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10010, 2813, 2859);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10010, 2816, 2859);
                    return f_10010_2816_2825(this) == SyntaxKind.SkippedTokensTrivia; DynAbs.Tracing.TraceSender.TraceExitMethod(10010, 2813, 2859);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10010, 2813, 2859);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10010, 2813, 2859);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsDocumentationCommentTrivia
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10010, 2920, 2974);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10010, 2923, 2974);
                    return f_10010_2923_2974(f_10010_2964_2973(this)); DynAbs.Tracing.TraceSender.TraceExitMethod(10010, 2920, 2974);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10010, 2920, 2974);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10010, 2920, 2974);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int GetSlotOffset(int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10010, 2987, 3584);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10010, 3184, 3228);

                f_10010_3184_3227(index < 11);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10010, 3285, 3300);

                int
                offset = 0
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10010, 3323, 3328);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10010, 3314, 3543) || true) && (i < index)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10010, 3341, 3344)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10010, 3314, 3543))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10010, 3314, 3543);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10010, 3378, 3406);

                        var
                        child = f_10010_3390_3405(this, i)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10010, 3424, 3528) || true) && (child != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10010, 3424, 3528);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10010, 3483, 3509);

                            offset += f_10010_3493_3508(child);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10010, 3424, 3528);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10010, 1, 230);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10010, 1, 230);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10010, 3559, 3573);

                return offset;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10010, 2987, 3584);

                int
                f_10010_3184_3227(bool
                condition)
                {
                    System.Diagnostics.Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10010, 3184, 3227);
                    return 0;
                }


                Microsoft.CodeAnalysis.GreenNode?
                f_10010_3390_3405(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode
                this_param, int
                index)
                {
                    var return_v = this_param.GetSlot(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10010, 3390, 3405);
                    return return_v;
                }


                int
                f_10010_3493_3508(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.FullWidth;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10010, 3493, 3508);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10010, 2987, 3584);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10010, 2987, 3584);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SyntaxToken GetFirstToken()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10010, 3596, 3710);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10010, 3655, 3699);

                return (SyntaxToken)f_10010_3675_3698(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10010, 3596, 3710);

                Microsoft.CodeAnalysis.GreenNode?
                f_10010_3675_3698(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.GetFirstTerminal();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10010, 3675, 3698);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10010, 3596, 3710);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10010, 3596, 3710);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SyntaxToken GetLastToken()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10010, 3722, 3834);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10010, 3780, 3823);

                return (SyntaxToken)f_10010_3800_3822(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10010, 3722, 3834);

                Microsoft.CodeAnalysis.GreenNode?
                f_10010_3800_3822(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.GetLastTerminal();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10010, 3800, 3822);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10010, 3722, 3834);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10010, 3722, 3834);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SyntaxToken GetLastNonmissingToken()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10010, 3846, 3978);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10010, 3914, 3967);

                return (SyntaxToken)f_10010_3934_3966(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10010, 3846, 3978);

                Microsoft.CodeAnalysis.GreenNode?
                f_10010_3934_3966(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.GetLastNonmissingTerminal();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10010, 3934, 3966);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10010, 3846, 3978);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10010, 3846, 3978);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual GreenNode GetLeadingTrivia()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10010, 3990, 4081);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10010, 4058, 4070);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10010, 3990, 4081);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10010, 3990, 4081);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10010, 3990, 4081);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override GreenNode GetLeadingTriviaCore()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10010, 4093, 4208);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10010, 4166, 4197);

                return f_10010_4173_4196(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10010, 4093, 4208);

                Microsoft.CodeAnalysis.GreenNode
                f_10010_4173_4196(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.GetLeadingTrivia();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10010, 4173, 4196);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10010, 4093, 4208);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10010, 4093, 4208);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual GreenNode GetTrailingTrivia()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10010, 4220, 4312);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10010, 4289, 4301);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10010, 4220, 4312);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10010, 4220, 4312);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10010, 4220, 4312);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override GreenNode GetTrailingTriviaCore()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10010, 4324, 4441);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10010, 4398, 4430);

                return f_10010_4405_4429(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10010, 4324, 4441);

                Microsoft.CodeAnalysis.GreenNode
                f_10010_4405_4429(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.GetTrailingTrivia();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10010, 4405, 4429);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10010, 4324, 4441);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10010, 4324, 4441);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public abstract TResult Accept<TResult>(CSharpSyntaxVisitor<TResult> visitor);

        public abstract void Accept(CSharpSyntaxVisitor visitor);

        internal virtual DirectiveStack ApplyDirectives(DirectiveStack stack)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10010, 4612, 4753);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10010, 4706, 4742);

                return f_10010_4713_4741(this, stack);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10010, 4612, 4753);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveStack
                f_10010_4713_4741(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveStack
                stack)
                {
                    var return_v = ApplyDirectives((Microsoft.CodeAnalysis.GreenNode)node, stack);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10010, 4713, 4741);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10010, 4612, 4753);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10010, 4612, 4753);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static DirectiveStack ApplyDirectives(GreenNode node, DirectiveStack stack)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10010, 4765, 5287);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10010, 4874, 5247) || true) && (f_10010_4878_4901(node))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10010, 4874, 5247);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10010, 4944, 4949);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10010, 4951, 4969);
                        for (int
        i = 0
        ,
        n = f_10010_4955_4969(node)
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10010, 4935, 5232) || true) && (i < n)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10010, 4978, 4981)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10010, 4935, 5232))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10010, 4935, 5232);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10010, 5023, 5051);

                            var
                            child = f_10010_5035_5050(node, i)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10010, 5073, 5213) || true) && (child != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10010, 5073, 5213);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10010, 5140, 5190);

                                stack = f_10010_5148_5189(child, stack);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10010, 5073, 5213);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10010, 1, 298);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10010, 1, 298);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10010, 4874, 5247);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10010, 5263, 5276);

                return stack;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10010, 4765, 5287);

                bool
                f_10010_4878_4901(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.ContainsDirectives;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10010, 4878, 4901);
                    return return_v;
                }


                int
                f_10010_4955_4969(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.SlotCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10010, 4955, 4969);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode?
                f_10010_5035_5050(Microsoft.CodeAnalysis.GreenNode
                this_param, int
                index)
                {
                    var return_v = this_param.GetSlot(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10010, 5035, 5050);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveStack
                f_10010_5148_5189(Microsoft.CodeAnalysis.GreenNode
                listOrNode, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveStack
                stack)
                {
                    var return_v = ApplyDirectivesToListOrNode(listOrNode, stack);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10010, 5148, 5189);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10010, 4765, 5287);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10010, 4765, 5287);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static DirectiveStack ApplyDirectivesToListOrNode(GreenNode listOrNode, DirectiveStack stack)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10010, 5299, 6103);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10010, 5691, 6092) || true) && (f_10010_5695_5713(listOrNode) == GreenNode.ListKind)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10010, 5691, 6092);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10010, 5769, 5811);

                    return f_10010_5776_5810(listOrNode, stack);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10010, 5691, 6092);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10010, 5691, 6092);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10010, 6016, 6077);

                    return f_10010_6023_6076(((CSharpSyntaxNode)listOrNode), stack);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10010, 5691, 6092);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10010, 5299, 6103);

                int
                f_10010_5695_5713(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.RawKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10010, 5695, 5713);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveStack
                f_10010_5776_5810(Microsoft.CodeAnalysis.GreenNode
                node, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveStack
                stack)
                {
                    var return_v = ApplyDirectives(node, stack);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10010, 5776, 5810);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveStack
                f_10010_6023_6076(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveStack
                stack)
                {
                    var return_v = this_param.ApplyDirectives(stack);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10010, 6023, 6076);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10010, 5299, 6103);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10010, 5299, 6103);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual IList<DirectiveTriviaSyntax> GetDirectives()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10010, 6115, 6515);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10010, 6201, 6423) || true) && ((this.flags & NodeFlags.ContainsDirectives) != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10010, 6201, 6423);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10010, 6287, 6334);

                    var
                    list = f_10010_6298_6333(32)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10010, 6352, 6378);

                    f_10010_6352_6377(this, list);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10010, 6396, 6408);

                    return list;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10010, 6201, 6423);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10010, 6439, 6504);

                return f_10010_6446_6503();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10010, 6115, 6515);

                System.Collections.Generic.List<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveTriviaSyntax>
                f_10010_6298_6333(int
                capacity)
                {
                    var return_v = new System.Collections.Generic.List<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveTriviaSyntax>(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10010, 6298, 6333);
                    return return_v;
                }


                int
                f_10010_6352_6377(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode
                node, System.Collections.Generic.List<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveTriviaSyntax>
                directives)
                {
                    GetDirectives((Microsoft.CodeAnalysis.GreenNode)node, directives);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10010, 6352, 6377);
                    return 0;
                }


                System.Collections.Generic.IList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveTriviaSyntax>
                f_10010_6446_6503()
                {
                    var return_v = SpecializedCollections.EmptyList<DirectiveTriviaSyntax>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10010, 6446, 6503);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10010, 6115, 6515);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10010, 6115, 6515);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void GetDirectives(GreenNode node, List<DirectiveTriviaSyntax> directives)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10010, 6527, 7505);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10010, 6641, 7494) || true) && (node != null && (DynAbs.Tracing.TraceSender.Expression_True(10010, 6645, 6684) && f_10010_6661_6684(node)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10010, 6641, 7494);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10010, 6718, 6756);

                    var
                    d = node as DirectiveTriviaSyntax
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10010, 6774, 7479) || true) && (d != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10010, 6774, 7479);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10010, 6829, 6847);

                        f_10010_6829_6846(directives, d);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10010, 6774, 7479);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10010, 6774, 7479);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10010, 6929, 6957);

                        var
                        t = node as SyntaxToken
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10010, 6979, 7460) || true) && (t != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10010, 6979, 7460);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10010, 7042, 7090);

                            f_10010_7042_7089(f_10010_7056_7076(t), directives);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10010, 7116, 7165);

                            f_10010_7116_7164(f_10010_7130_7151(t), directives);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10010, 6979, 7460);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10010, 6979, 7460);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10010, 7272, 7277);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10010, 7279, 7297);
                                for (int
        i = 0
        ,
        n = f_10010_7283_7297(node)
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10010, 7263, 7437) || true) && (i < n)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10010, 7306, 7309)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10010, 7263, 7437))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10010, 7263, 7437);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10010, 7367, 7410);

                                    f_10010_7367_7409(f_10010_7381_7396(node, i), directives);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10010, 1, 175);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10010, 1, 175);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10010, 6979, 7460);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10010, 6774, 7479);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10010, 6641, 7494);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10010, 6527, 7505);

                bool
                f_10010_6661_6684(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.ContainsDirectives;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10010, 6661, 6684);
                    return return_v;
                }


                int
                f_10010_6829_6846(System.Collections.Generic.List<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveTriviaSyntax>
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveTriviaSyntax
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10010, 6829, 6846);
                    return 0;
                }


                Microsoft.CodeAnalysis.GreenNode
                f_10010_7056_7076(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.GetLeadingTrivia();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10010, 7056, 7076);
                    return return_v;
                }


                int
                f_10010_7042_7089(Microsoft.CodeAnalysis.GreenNode
                node, System.Collections.Generic.List<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveTriviaSyntax>
                directives)
                {
                    GetDirectives(node, directives);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10010, 7042, 7089);
                    return 0;
                }


                Microsoft.CodeAnalysis.GreenNode
                f_10010_7130_7151(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.GetTrailingTrivia();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10010, 7130, 7151);
                    return return_v;
                }


                int
                f_10010_7116_7164(Microsoft.CodeAnalysis.GreenNode
                node, System.Collections.Generic.List<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveTriviaSyntax>
                directives)
                {
                    GetDirectives(node, directives);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10010, 7116, 7164);
                    return 0;
                }


                int
                f_10010_7283_7297(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.SlotCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10010, 7283, 7297);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode?
                f_10010_7381_7396(Microsoft.CodeAnalysis.GreenNode
                this_param, int
                index)
                {
                    var return_v = this_param.GetSlot(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10010, 7381, 7396);
                    return return_v;
                }


                int
                f_10010_7367_7409(Microsoft.CodeAnalysis.GreenNode?
                node, System.Collections.Generic.List<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveTriviaSyntax>
                directives)
                {
                    GetDirectives(node, directives);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10010, 7367, 7409);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10010, 6527, 7505);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10010, 6527, 7505);
            }
        }

        protected void SetFactoryContext(SyntaxFactoryContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10010, 7782, 8132);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10010, 7869, 7987) || true) && (context.IsInAsync)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10010, 7869, 7987);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10010, 7924, 7972);

                    this.flags |= NodeFlags.FactoryContextIsInAsync;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10010, 7869, 7987);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10010, 8003, 8121) || true) && (f_10010_8007_8024(context))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10010, 8003, 8121);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10010, 8058, 8106);

                    this.flags |= NodeFlags.FactoryContextIsInQuery;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10010, 8003, 8121);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10010, 7782, 8132);

                bool
                f_10010_8007_8024(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxFactoryContext
                this_param)
                {
                    var return_v = this_param.IsInQuery;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10010, 8007, 8024);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10010, 7782, 8132);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10010, 7782, 8132);
            }
        }

        internal static NodeFlags SetFactoryContext(NodeFlags flags, SyntaxFactoryContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10010, 8144, 8541);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10010, 8259, 8372) || true) && (context.IsInAsync)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10010, 8259, 8372);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10010, 8314, 8357);

                    flags |= NodeFlags.FactoryContextIsInAsync;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10010, 8259, 8372);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10010, 8388, 8501) || true) && (f_10010_8392_8409(context))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10010, 8388, 8501);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10010, 8443, 8486);

                    flags |= NodeFlags.FactoryContextIsInQuery;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10010, 8388, 8501);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10010, 8517, 8530);

                return flags;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10010, 8144, 8541);

                bool
                f_10010_8392_8409(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxFactoryContext
                this_param)
                {
                    var return_v = this_param.IsInQuery;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10010, 8392, 8409);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10010, 8144, 8541);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10010, 8144, 8541);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override CodeAnalysis.SyntaxToken CreateSeparator<TNode>(SyntaxNode element)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10010, 8553, 8729);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10010, 8661, 8718);

                return f_10010_8668_8717<TNode>(SyntaxKind.CommaToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10010, 8553, 8729);

                Microsoft.CodeAnalysis.SyntaxToken
                f_10010_8668_8717<TNode>(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = CSharp.SyntaxFactory.Token(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10010, 8668, 8717);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10010, 8553, 8729);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10010, 8553, 8729);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool IsTriviaWithEndOfLine()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10010, 8741, 8936);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10010, 8810, 8925);

                return f_10010_8817_8826(this) == SyntaxKind.EndOfLineTrivia
                || (DynAbs.Tracing.TraceSender.Expression_False(10010, 8817, 8924) || f_10010_8877_8886(this) == SyntaxKind.SingleLineCommentTrivia);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10010, 8741, 8936);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10010_8817_8826(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10010, 8817, 8826);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10010_8877_8886(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10010, 8877, 8886);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10010, 8741, 8936);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10010, 8741, 8936);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static readonly ConditionalWeakTable<SyntaxNode, Dictionary<CodeAnalysis.SyntaxTrivia, SyntaxNode>> s_structuresTable
        ;

        public override SyntaxNode GetStructure(Microsoft.CodeAnalysis.SyntaxTrivia trivia)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10010, 10234, 11262);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10010, 10342, 11223) || true) && (trivia.HasStructure)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10010, 10342, 11223);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10010, 10399, 10432);

                    var
                    parent = trivia.Token.Parent
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10010, 10450, 11208) || true) && (parent != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10010, 10450, 11208);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10010, 10510, 10531);

                        SyntaxNode
                        structure
                        = default(SyntaxNode);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10010, 10553, 10618);

                        var
                        structsInParent = f_10010_10575_10617(s_structuresTable, parent)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10010, 10646, 10661);
                        lock (structsInParent)
                        {

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10010, 10711, 10984) || true) && (!f_10010_10716_10766(structsInParent, trivia, out structure))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10010, 10711, 10984);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10010, 10824, 10888);

                                structure = f_10010_10836_10887(trivia);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10010, 10918, 10957);

                                f_10010_10918_10956(structsInParent, trivia, structure);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10010, 10711, 10984);
                            }
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10010, 11031, 11048);

                        return structure;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10010, 10450, 11208);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10010, 10450, 11208);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10010, 11130, 11189);

                        return f_10010_11137_11188(trivia);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10010, 10450, 11208);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10010, 10342, 11223);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10010, 11239, 11251);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10010, 10234, 11262);

                System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxTrivia, Microsoft.CodeAnalysis.SyntaxNode>
                f_10010_10575_10617(System.Runtime.CompilerServices.ConditionalWeakTable<Microsoft.CodeAnalysis.SyntaxNode, System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxTrivia, Microsoft.CodeAnalysis.SyntaxNode>>
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                key)
                {
                    var return_v = this_param.GetOrCreateValue(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10010, 10575, 10617);
                    return return_v;
                }


                bool
                f_10010_10716_10766(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxTrivia, Microsoft.CodeAnalysis.SyntaxNode>
                this_param, Microsoft.CodeAnalysis.SyntaxTrivia
                key, out Microsoft.CodeAnalysis.SyntaxNode
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10010, 10716, 10766);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.StructuredTriviaSyntax
                f_10010_10836_10887(Microsoft.CodeAnalysis.SyntaxTrivia
                trivia)
                {
                    var return_v = CSharp.Syntax.StructuredTriviaSyntax.Create(trivia);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10010, 10836, 10887);
                    return return_v;
                }


                int
                f_10010_10918_10956(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxTrivia, Microsoft.CodeAnalysis.SyntaxNode>
                this_param, Microsoft.CodeAnalysis.SyntaxTrivia
                key, Microsoft.CodeAnalysis.SyntaxNode
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10010, 10918, 10956);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.StructuredTriviaSyntax
                f_10010_11137_11188(Microsoft.CodeAnalysis.SyntaxTrivia
                trivia)
                {
                    var return_v = CSharp.Syntax.StructuredTriviaSyntax.Create(trivia);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10010, 11137, 11188);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10010, 10234, 11262);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10010, 10234, 11262);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static CSharpSyntaxNode()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10010, 501, 11269);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10010, 9151, 9273);
            s_structuresTable = f_10010_9184_9273(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10010, 501, 11269);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10010, 501, 11269);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10010, 501, 11269);

        int
        f_10010_724_750(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode
        node)
        {
            GreenStats.NoteGreen((Microsoft.CodeAnalysis.GreenNode)node);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10010, 724, 750);
            return 0;
        }


        static ushort
        f_10010_686_698_C(ushort
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10010, 623, 762);
            return return_v;
        }


        int
        f_10010_901_927(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode
        node)
        {
            GreenStats.NoteGreen((Microsoft.CodeAnalysis.GreenNode)node);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10010, 901, 927);
            return 0;
        }


        static ushort
        f_10010_852_864_C(ushort
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10010, 774, 939);
            return return_v;
        }


        int
        f_10010_1095_1121(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode
        node)
        {
            GreenStats.NoteGreen((Microsoft.CodeAnalysis.GreenNode)node);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10010, 1095, 1121);
            return 0;
        }


        static ushort
        f_10010_1044_1056_C(ushort
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10010, 951, 1133);
            return return_v;
        }


        int
        f_10010_1315_1341(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode
        node)
        {
            GreenStats.NoteGreen((Microsoft.CodeAnalysis.GreenNode)node);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10010, 1315, 1341);
            return 0;
        }


        static ushort
        f_10010_1253_1265_C(ushort
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10010, 1145, 1353);
            return return_v;
        }


        int
        f_10010_1554_1580(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode
        node)
        {
            GreenStats.NoteGreen((Microsoft.CodeAnalysis.GreenNode)node);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10010, 1554, 1580);
            return 0;
        }


        static ushort
        f_10010_1490_1502_C(ushort
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10010, 1365, 1592);
            return return_v;
        }


        int
        f_10010_1819_1845(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode
        node)
        {
            GreenStats.NoteGreen((Microsoft.CodeAnalysis.GreenNode)node);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10010, 1819, 1845);
            return 0;
        }


        static ushort
        f_10010_1744_1756_C(ushort
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10010, 1604, 1857);
            return return_v;
        }


        static Roslyn.Utilities.ObjectReader
        f_10010_1936_1942_C(Roslyn.Utilities.ObjectReader
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10010, 1869, 1965);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.SyntaxKind
        f_10010_2237_2246(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode
        this_param)
        {
            var return_v = this_param.Kind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10010, 2237, 2246);
            return return_v;
        }


        string
        f_10010_2237_2257(Microsoft.CodeAnalysis.CSharp.SyntaxKind
        this_param)
        {
            var return_v = this_param.ToString();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10010, 2237, 2257);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.SyntaxKind
        f_10010_2816_2825(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode
        this_param)
        {
            var return_v = this_param.Kind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10010, 2816, 2825);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.SyntaxKind
        f_10010_2964_2973(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode
        this_param)
        {
            var return_v = this_param.Kind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10010, 2964, 2973);
            return return_v;
        }


        bool
        f_10010_2923_2974(Microsoft.CodeAnalysis.CSharp.SyntaxKind
        kind)
        {
            var return_v = SyntaxFacts.IsDocumentationCommentTrivia(kind);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10010, 2923, 2974);
            return return_v;
        }


        static System.Runtime.CompilerServices.ConditionalWeakTable<Microsoft.CodeAnalysis.SyntaxNode, System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxTrivia, Microsoft.CodeAnalysis.SyntaxNode>>
        f_10010_9184_9273()
        {
            var return_v = new System.Runtime.CompilerServices.ConditionalWeakTable<Microsoft.CodeAnalysis.SyntaxNode, System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxTrivia, Microsoft.CodeAnalysis.SyntaxNode>>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10010, 9184, 9273);
            return return_v;
        }

    }
}
