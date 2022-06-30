// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.CodeAnalysis.Syntax.InternalSyntax
{
    internal static class SyntaxListBuilderExtensions
    {
        public static SyntaxList<GreenNode> ToList(this SyntaxListBuilder? builder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(831, 337, 482);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(831, 437, 471);

                return f_831_444_470(builder);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(831, 337, 482);

                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.GreenNode>
                f_831_444_470(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder?
                builder)
                {
                    var return_v = builder.ToList<Microsoft.CodeAnalysis.GreenNode>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(831, 444, 470);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(831, 337, 482);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(831, 337, 482);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxList<TNode> ToList<TNode>(this SyntaxListBuilder? builder) where TNode : GreenNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(831, 494, 805);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(831, 621, 727) || true) && (builder == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(831, 621, 727);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(831, 674, 712);

                    return default(SyntaxList<GreenNode>);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(831, 621, 727);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(831, 743, 794);

                return f_831_750_793(f_831_772_792(builder));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(831, 494, 805);

                Microsoft.CodeAnalysis.GreenNode?
                f_831_772_792(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                this_param)
                {
                    var return_v = this_param.ToListNode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(831, 772, 792);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<TNode>
                f_831_750_793(Microsoft.CodeAnalysis.GreenNode?
                node)
                {
                    var return_v = new Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<TNode>(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(831, 750, 793);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(831, 494, 805);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(831, 494, 805);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SyntaxListBuilderExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(831, 271, 812);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(831, 271, 812);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(831, 271, 812);
        }

    }
}
