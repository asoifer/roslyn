// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Threading;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis
{
    public abstract class SyntaxReference
    {
        public abstract SyntaxTree SyntaxTree { get; }

        public abstract TextSpan Span { get; }

        public abstract SyntaxNode GetSyntax(CancellationToken cancellationToken = default);

        public virtual Task<SyntaxNode> GetSyntaxAsync(CancellationToken cancellationToken = default)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(695, 1402, 1589);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(695, 1520, 1578);

                return f_695_1527_1577(f_695_1543_1576(this, cancellationToken));
                DynAbs.Tracing.TraceSender.TraceExitMethod(695, 1402, 1589);

                Microsoft.CodeAnalysis.SyntaxNode
                f_695_1543_1576(Microsoft.CodeAnalysis.SyntaxReference
                this_param, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetSyntax(cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(695, 1543, 1576);
                    return return_v;
                }


                System.Threading.Tasks.Task<Microsoft.CodeAnalysis.SyntaxNode>
                f_695_1527_1577(Microsoft.CodeAnalysis.SyntaxNode
                result)
                {
                    var return_v = Task.FromResult(result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(695, 1527, 1577);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(695, 1402, 1589);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(695, 1402, 1589);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Location GetLocation()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(695, 1879, 1992);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(695, 1935, 1981);

                return f_695_1942_1980(f_695_1942_1957(this), f_695_1970_1979(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(695, 1879, 1992);

                Microsoft.CodeAnalysis.SyntaxTree
                f_695_1942_1957(Microsoft.CodeAnalysis.SyntaxReference
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(695, 1942, 1957);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_695_1970_1979(Microsoft.CodeAnalysis.SyntaxReference
                this_param)
                {
                    var return_v = this_param.Span;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(695, 1970, 1979);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_695_1942_1980(Microsoft.CodeAnalysis.SyntaxTree
                this_param, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    var return_v = this_param.GetLocation(span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(695, 1942, 1980);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(695, 1879, 1992);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(695, 1879, 1992);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SyntaxReference()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(695, 421, 1999);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(695, 421, 1999);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(695, 421, 1999);
        }


        static SyntaxReference()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(695, 421, 1999);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(695, 421, 1999);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(695, 421, 1999);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(695, 421, 1999);
    }
}
