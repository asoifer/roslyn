// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax
{
    internal abstract partial class CSharpSyntaxVisitor<TResult>
    {
        public virtual TResult Visit(CSharpSyntaxNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10012, 505, 722);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10012, 581, 670) || true) && (node == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10012, 581, 670);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10012, 631, 655);

                    return default(TResult);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10012, 581, 670);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10012, 686, 711);

                return f_10012_693_710(node, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10012, 505, 722);

                TResult
                f_10012_693_710(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxVisitor<TResult>
                visitor)
                {
                    var return_v = this_param.Accept<TResult>(visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10012, 693, 710);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10012, 505, 722);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10012, 505, 722);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual TResult VisitToken(SyntaxToken token)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10012, 734, 854);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10012, 811, 843);

                return f_10012_818_842(this, token);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10012, 734, 854);

                TResult
                f_10012_818_842(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxVisitor<TResult>
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                node)
                {
                    var return_v = this_param.DefaultVisit((Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10012, 818, 842);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10012, 734, 854);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10012, 734, 854);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual TResult VisitTrivia(SyntaxTrivia trivia)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10012, 866, 990);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10012, 946, 979);

                return f_10012_953_978(this, trivia);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10012, 866, 990);

                TResult
                f_10012_953_978(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxVisitor<TResult>
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxTrivia
                node)
                {
                    var return_v = this_param.DefaultVisit((Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10012, 953, 978);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10012, 866, 990);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10012, 866, 990);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected virtual TResult DefaultVisit(CSharpSyntaxNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10012, 1002, 1123);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10012, 1088, 1112);

                return default(TResult);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10012, 1002, 1123);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10012, 1002, 1123);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10012, 1002, 1123);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public CSharpSyntaxVisitor()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(10012, 428, 1130);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(10012, 428, 1130);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10012, 428, 1130);
        }


        static CSharpSyntaxVisitor()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10012, 428, 1130);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10012, 428, 1130);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10012, 428, 1130);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10012, 428, 1130);
    }
    internal abstract partial class CSharpSyntaxVisitor
    {
        public virtual void Visit(CSharpSyntaxNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10012, 1206, 1396);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10012, 1279, 1351) || true) && (node == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10012, 1279, 1351);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10012, 1329, 1336);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10012, 1279, 1351);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10012, 1367, 1385);

                f_10012_1367_1384(
                            node, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10012, 1206, 1396);

                int
                f_10012_1367_1384(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxVisitor
                visitor)
                {
                    this_param.Accept(visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10012, 1367, 1384);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10012, 1206, 1396);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10012, 1206, 1396);
            }
        }

        public virtual void VisitToken(SyntaxToken token)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10012, 1408, 1518);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10012, 1482, 1507);

                f_10012_1482_1506(this, token);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10012, 1408, 1518);

                int
                f_10012_1482_1506(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                node)
                {
                    this_param.DefaultVisit((Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10012, 1482, 1506);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10012, 1408, 1518);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10012, 1408, 1518);
            }
        }

        public virtual void VisitTrivia(SyntaxTrivia trivia)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10012, 1530, 1644);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10012, 1607, 1633);

                f_10012_1607_1632(this, trivia);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10012, 1530, 1644);

                int
                f_10012_1607_1632(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxTrivia
                node)
                {
                    this_param.DefaultVisit((Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10012, 1607, 1632);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10012, 1530, 1644);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10012, 1530, 1644);
            }
        }

        public virtual void DefaultVisit(CSharpSyntaxNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10012, 1656, 1733);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10012, 1656, 1733);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10012, 1656, 1733);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10012, 1656, 1733);
            }
        }
    }
}
