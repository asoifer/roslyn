// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Threading;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal class SimpleSyntaxReference : SyntaxReference
    {
        private readonly SyntaxNode _node;

        internal SimpleSyntaxReference(SyntaxNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10797, 548, 644);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10797, 530, 535);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10797, 620, 633);

                _node = node;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10797, 548, 644);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10797, 548, 644);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10797, 548, 644);
            }
        }

        public override SyntaxTree SyntaxTree
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10797, 718, 793);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10797, 754, 778);

                    return f_10797_761_777(_node);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10797, 718, 793);

                    Microsoft.CodeAnalysis.SyntaxTree
                    f_10797_761_777(Microsoft.CodeAnalysis.SyntaxNode
                    this_param)
                    {
                        var return_v = this_param.SyntaxTree;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10797, 761, 777);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10797, 656, 804);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10797, 656, 804);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override TextSpan Span
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10797, 870, 939);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10797, 906, 924);

                    return f_10797_913_923(_node);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10797, 870, 939);

                    Microsoft.CodeAnalysis.Text.TextSpan
                    f_10797_913_923(Microsoft.CodeAnalysis.SyntaxNode
                    this_param)
                    {
                        var return_v = this_param.Span;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10797, 913, 923);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10797, 816, 950);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10797, 816, 950);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override SyntaxNode GetSyntax(CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10797, 962, 1084);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10797, 1060, 1073);

                return _node;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10797, 962, 1084);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10797, 962, 1084);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10797, 962, 1084);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SimpleSyntaxReference()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10797, 431, 1091);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10797, 431, 1091);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10797, 431, 1091);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10797, 431, 1091);
    }
}
