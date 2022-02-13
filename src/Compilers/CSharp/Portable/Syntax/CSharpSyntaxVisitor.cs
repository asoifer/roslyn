// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.CodeAnalysis.CSharp
{
    public abstract partial class CSharpSyntaxVisitor<TResult>
    {
        public virtual TResult? Visit(SyntaxNode? node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10046, 741, 1058);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10046, 813, 923) || true) && (node != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10046, 813, 923);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10046, 863, 908);

                    return f_10046_870_907(((CSharpSyntaxNode)node), this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10046, 813, 923);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10046, 1032, 1047);

                return default;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10046, 741, 1058);

                TResult?
                f_10046_870_907(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor<TResult>
                visitor)
                {
                    var return_v = this_param.Accept<TResult>(visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10046, 870, 907);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10046, 741, 1058);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10046, 741, 1058);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual TResult? DefaultVisit(SyntaxNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10046, 1070, 1174);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10046, 1148, 1163);

                return default;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10046, 1070, 1174);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10046, 1070, 1174);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10046, 1070, 1174);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public CSharpSyntaxVisitor()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(10046, 666, 1181);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(10046, 666, 1181);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10046, 666, 1181);
        }


        static CSharpSyntaxVisitor()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10046, 666, 1181);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10046, 666, 1181);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10046, 666, 1181);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10046, 666, 1181);
    }
    public abstract partial class CSharpSyntaxVisitor
    {
        public virtual void Visit(SyntaxNode? node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10046, 1439, 1621);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10046, 1507, 1610) || true) && (node != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10046, 1507, 1610);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10046, 1557, 1595);

                    f_10046_1557_1594(((CSharpSyntaxNode)node), this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10046, 1507, 1610);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10046, 1439, 1621);

                int
                f_10046_1557_1594(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor
                visitor)
                {
                    this_param.Accept(visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10046, 1557, 1594);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10046, 1439, 1621);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10046, 1439, 1621);
            }
        }

        public virtual void DefaultVisit(SyntaxNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10046, 1633, 1704);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10046, 1633, 1704);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10046, 1633, 1704);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10046, 1633, 1704);
            }
        }
    }
}
