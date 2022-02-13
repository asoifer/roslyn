// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

namespace Microsoft.CodeAnalysis.CSharp.Syntax
{
    public abstract partial class StructuredTriviaSyntax : CSharpSyntaxNode, IStructuredTriviaSyntax
    {
        private SyntaxTrivia _parent;

        internal StructuredTriviaSyntax(InternalSyntax.CSharpSyntaxNode green, SyntaxNode parent, int position)
        : base(f_10800_685_690_C(green), position, (DynAbs.Tracing.TraceSender.Conditional_F1(10800, 702, 716) || ((parent == null && DynAbs.Tracing.TraceSender.Conditional_F2(10800, 719, 723)) || DynAbs.Tracing.TraceSender.Conditional_F3(10800, 726, 743))) ? null : f_10800_726_743(parent))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10800, 561, 845);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10800, 769, 834);

                f_10800_769_833(parent == null || (DynAbs.Tracing.TraceSender.Expression_False(10800, 801, 832) || position >= 0));
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10800, 561, 845);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10800, 561, 845);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10800, 561, 845);
            }
        }

        internal static StructuredTriviaSyntax Create(SyntaxTrivia trivia)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10800, 857, 1225);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10800, 948, 981);

                var
                node = trivia.UnderlyingNode
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10800, 995, 1028);

                var
                parent = trivia.Token.Parent
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10800, 1042, 1073);

                var
                position = trivia.Position
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10800, 1087, 1154);

                var
                red = (StructuredTriviaSyntax)f_10800_1121_1153(node, parent, position)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10800, 1168, 1189);

                red._parent = trivia;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10800, 1203, 1214);

                return red;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10800, 857, 1225);

                Microsoft.CodeAnalysis.SyntaxNode
                f_10800_1121_1153(Microsoft.CodeAnalysis.GreenNode?
                this_param, Microsoft.CodeAnalysis.SyntaxNode?
                parent, int
                position)
                {
                    var return_v = this_param.CreateRed(parent, position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10800, 1121, 1153);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10800, 857, 1225);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10800, 857, 1225);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override SyntaxTrivia ParentTrivia
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10800, 1358, 1368);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10800, 1361, 1368);
                    return _parent; DynAbs.Tracing.TraceSender.TraceExitMethod(10800, 1358, 1368);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10800, 1358, 1368);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10800, 1358, 1368);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static StructuredTriviaSyntax()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10800, 407, 1376);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10800, 407, 1376);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10800, 407, 1376);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10800, 407, 1376);

        static Microsoft.CodeAnalysis.SyntaxTree
        f_10800_726_743(Microsoft.CodeAnalysis.SyntaxNode
        this_param)
        {
            var return_v = this_param.SyntaxTree;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10800, 726, 743);
            return return_v;
        }


        int
        f_10800_769_833(bool
        condition)
        {
            System.Diagnostics.Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10800, 769, 833);
            return 0;
        }


        static Microsoft.CodeAnalysis.GreenNode
        f_10800_685_690_C(Microsoft.CodeAnalysis.GreenNode
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10800, 561, 845);
            return return_v;
        }

    }
}
