// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.CodeAnalysis.Syntax.InternalSyntax
{
    internal static class GreenNodeExtensions
    {
        internal static SyntaxList<T> ToGreenList<T>(this SyntaxNode? node) where T : GreenNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(821, 329, 560);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(821, 441, 549);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(821, 448, 460) || ((node != null && DynAbs.Tracing.TraceSender.Conditional_F2(821, 480, 506)) || DynAbs.Tracing.TraceSender.Conditional_F3(821, 526, 548))) ? f_821_480_506(f_821_495_505(node)) : default(SyntaxList<T>);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(821, 329, 560);

                Microsoft.CodeAnalysis.GreenNode
                f_821_495_505(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Green;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(821, 495, 505);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<T>
                f_821_480_506(Microsoft.CodeAnalysis.GreenNode
                node)
                {
                    var return_v = node.ToGreenList<T>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(821, 480, 506);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(821, 329, 560);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(821, 329, 560);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static SeparatedSyntaxList<T> ToGreenSeparatedList<T>(this SyntaxNode? node) where T : GreenNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(821, 572, 858);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(821, 702, 847);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(821, 709, 721) || ((node != null && DynAbs.Tracing.TraceSender.Conditional_F2(821, 741, 795)) || DynAbs.Tracing.TraceSender.Conditional_F3(821, 815, 846))) ? f_821_741_795(f_821_768_794(f_821_783_793(node))) : default(SeparatedSyntaxList<T>);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(821, 572, 858);

                Microsoft.CodeAnalysis.GreenNode
                f_821_783_793(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Green;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(821, 783, 793);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<T>
                f_821_768_794(Microsoft.CodeAnalysis.GreenNode
                node)
                {
                    var return_v = node.ToGreenList<T>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(821, 768, 794);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<T>
                f_821_741_795(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<T>
                list)
                {
                    var return_v = new Microsoft.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<T>((Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.GreenNode>)list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(821, 741, 795);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(821, 572, 858);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(821, 572, 858);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static SyntaxList<T> ToGreenList<T>(this GreenNode? node) where T : GreenNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(821, 870, 1023);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(821, 981, 1012);

                return f_821_988_1011(node);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(821, 870, 1023);

                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<T>
                f_821_988_1011(Microsoft.CodeAnalysis.GreenNode?
                node)
                {
                    var return_v = new Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<T>(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(821, 988, 1011);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(821, 870, 1023);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(821, 870, 1023);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static GreenNodeExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(821, 271, 1030);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(821, 271, 1030);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(821, 271, 1030);
        }

    }
}
