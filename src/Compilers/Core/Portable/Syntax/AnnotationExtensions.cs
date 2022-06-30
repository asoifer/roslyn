// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Linq;

namespace Microsoft.CodeAnalysis
{
    public static class AnnotationExtensions
    {
        public static TNode WithAdditionalAnnotations<TNode>(this TNode node, params SyntaxAnnotation[] annotations)
                    where TNode : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(656, 649, 897);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(656, 820, 886);

                return (TNode)f_656_834_885(node, annotations);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(656, 649, 897);

                Microsoft.CodeAnalysis.SyntaxNode
                f_656_834_885(TNode
                this_param, Microsoft.CodeAnalysis.SyntaxAnnotation[]
                annotations)
                {
                    var return_v = this_param.WithAdditionalAnnotationsInternal((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxAnnotation>)annotations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(656, 834, 885);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(656, 649, 897);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(656, 649, 897);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static TNode WithAdditionalAnnotations<TNode>(this TNode node, IEnumerable<SyntaxAnnotation> annotations)
                    where TNode : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(656, 1195, 1447);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(656, 1370, 1436);

                return (TNode)f_656_1384_1435(node, annotations);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(656, 1195, 1447);

                Microsoft.CodeAnalysis.SyntaxNode
                f_656_1384_1435(TNode
                this_param, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxAnnotation>
                annotations)
                {
                    var return_v = this_param.WithAdditionalAnnotationsInternal(annotations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(656, 1384, 1435);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(656, 1195, 1447);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(656, 1195, 1447);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static TNode WithoutAnnotations<TNode>(this TNode node, params SyntaxAnnotation[] annotations)
                    where TNode : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(656, 1748, 1981);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(656, 1912, 1970);

                return (TNode)f_656_1926_1969(node, annotations);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(656, 1748, 1981);

                Microsoft.CodeAnalysis.SyntaxNode
                f_656_1926_1969(TNode
                this_param, Microsoft.CodeAnalysis.SyntaxAnnotation[]
                annotations)
                {
                    var return_v = this_param.GetNodeWithoutAnnotations((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxAnnotation>)annotations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(656, 1926, 1969);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(656, 1748, 1981);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(656, 1748, 1981);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static TNode WithoutAnnotations<TNode>(this TNode node, IEnumerable<SyntaxAnnotation> annotations)
                    where TNode : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(656, 2282, 2519);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(656, 2450, 2508);

                return (TNode)f_656_2464_2507(node, annotations);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(656, 2282, 2519);

                Microsoft.CodeAnalysis.SyntaxNode
                f_656_2464_2507(TNode
                this_param, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxAnnotation>
                annotations)
                {
                    var return_v = this_param.GetNodeWithoutAnnotations(annotations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(656, 2464, 2507);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(656, 2282, 2519);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(656, 2282, 2519);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static TNode WithoutAnnotations<TNode>(this TNode node, string annotationKind)
                    where TNode : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(656, 2824, 3234);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(656, 2972, 3223) || true) && (f_656_2976_3011(node, annotationKind))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(656, 2972, 3223);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(656, 3045, 3130);

                    return f_656_3052_3129(node, f_656_3083_3128(f_656_3083_3118(node, annotationKind)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(656, 2972, 3223);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(656, 2972, 3223);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(656, 3196, 3208);

                    return node;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(656, 2972, 3223);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(656, 2824, 3234);

                bool
                f_656_2976_3011(TNode
                this_param, string
                annotationKind)
                {
                    var return_v = this_param.HasAnnotations(annotationKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(656, 2976, 3011);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxAnnotation>
                f_656_3083_3118(TNode
                this_param, string
                annotationKind)
                {
                    var return_v = this_param.GetAnnotations(annotationKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(656, 3083, 3118);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxAnnotation[]
                f_656_3083_3128(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxAnnotation>
                source)
                {
                    var return_v = source.ToArray<Microsoft.CodeAnalysis.SyntaxAnnotation>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(656, 3083, 3128);
                    return return_v;
                }


                TNode
                f_656_3052_3129(TNode
                node, params Microsoft.CodeAnalysis.SyntaxAnnotation[]
                annotations)
                {
                    var return_v = node.WithoutAnnotations<TNode>(annotations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(656, 3052, 3129);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(656, 2824, 3234);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(656, 2824, 3234);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static AnnotationExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(656, 306, 3241);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(656, 306, 3241);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(656, 306, 3241);
        }

    }
}
