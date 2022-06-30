// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using Roslyn.Utilities;
using System.Diagnostics;

namespace Microsoft.CodeAnalysis.Syntax.InternalSyntax
{
    internal partial class SyntaxList
    {
        internal sealed class WithLotsOfChildren : WithManyChildrenBase
        {
            static WithLotsOfChildren()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(826, 478, 645);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(826, 538, 630);

                    f_826_538_629(typeof(WithLotsOfChildren), r => new WithLotsOfChildren(r));
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(826, 478, 645);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(826, 478, 645);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(826, 478, 645);
                }
            }

            private readonly int[] _childOffsets;

            internal WithLotsOfChildren(ArrayElement<GreenNode>[] children)
            : base(f_826_802_810_C(children))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(826, 714, 902);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(826, 684, 697);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(826, 844, 887);

                    _childOffsets = f_826_860_886(children);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(826, 714, 902);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(826, 714, 902);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(826, 714, 902);
                }
            }

            internal WithLotsOfChildren(DiagnosticInfo[]? diagnostics, SyntaxAnnotation[]? annotations, ArrayElement<GreenNode>[] children, int[] childOffsets)
            : base(f_826_1090_1101_C(diagnostics), annotations, children)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(826, 918, 1202);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(826, 684, 697);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(826, 1158, 1187);

                    _childOffsets = childOffsets;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(826, 918, 1202);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(826, 918, 1202);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(826, 918, 1202);
                }
            }

            internal WithLotsOfChildren(ObjectReader reader)
            : base(f_826_1291_1297_C(reader))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(826, 1218, 1394);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(826, 684, 697);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(826, 1331, 1379);

                    _childOffsets = f_826_1347_1378(this.children);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(826, 1218, 1394);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(826, 1218, 1394);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(826, 1218, 1394);
                }
            }

            internal override void WriteTo(ObjectWriter writer)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(826, 1410, 1606);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(826, 1494, 1515);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.WriteTo(writer), 826, 1494, 1514);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(826, 1410, 1606);
                    // don't write offsets out, recompute them on construction
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(826, 1410, 1606);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(826, 1410, 1606);
                }
            }

            public override int GetSlotOffset(int index)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(826, 1622, 1742);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(826, 1699, 1727);

                    return _childOffsets[index];
                    DynAbs.Tracing.TraceSender.TraceExitMethod(826, 1622, 1742);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(826, 1622, 1742);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(826, 1622, 1742);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override int FindSlotIndexContainingOffset(int offset)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(826, 2275, 2506);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(826, 2369, 2417);

                    f_826_2369_2416(offset >= 0 && (DynAbs.Tracing.TraceSender.Expression_True(826, 2382, 2415) && offset < f_826_2406_2415()));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(826, 2435, 2491);

                    return f_826_2442_2486(_childOffsets, offset) - 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(826, 2275, 2506);

                    int
                    f_826_2406_2415()
                    {
                        var return_v = FullWidth;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(826, 2406, 2415);
                        return return_v;
                    }


                    int
                    f_826_2369_2416(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(826, 2369, 2416);
                        return 0;
                    }


                    int
                    f_826_2442_2486(int[]
                    array, int
                    value)
                    {
                        var return_v = array.BinarySearchUpperBound(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(826, 2442, 2486);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(826, 2275, 2506);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(826, 2275, 2506);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private static int[] CalculateOffsets(ArrayElement<GreenNode>[] children)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(826, 2522, 2976);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(826, 2628, 2652);

                    int
                    n = f_826_2636_2651(children)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(826, 2670, 2700);

                    var
                    childOffsets = new int[n]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(826, 2718, 2733);

                    int
                    offset = 0
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(826, 2760, 2765);
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(826, 2751, 2923) || true) && (i < n)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(826, 2774, 2777)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(826, 2751, 2923))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(826, 2751, 2923);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(826, 2819, 2844);

                            childOffsets[i] = offset;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(826, 2866, 2904);

                            offset += f_826_2876_2903(children[i].Value);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(826, 1, 173);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(826, 1, 173);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(826, 2941, 2961);

                    return childOffsets;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(826, 2522, 2976);

                    int
                    f_826_2636_2651(Microsoft.CodeAnalysis.ArrayElement<Microsoft.CodeAnalysis.GreenNode>[]
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(826, 2636, 2651);
                        return return_v;
                    }


                    int
                    f_826_2876_2903(Microsoft.CodeAnalysis.GreenNode
                    this_param)
                    {
                        var return_v = this_param.FullWidth;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(826, 2876, 2903);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(826, 2522, 2976);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(826, 2522, 2976);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override GreenNode SetDiagnostics(DiagnosticInfo[]? errors)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(826, 2992, 3194);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(826, 3093, 3179);

                    return f_826_3100_3178(errors, f_826_3131_3152(this), children, _childOffsets);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(826, 2992, 3194);

                    Microsoft.CodeAnalysis.SyntaxAnnotation[]
                    f_826_3131_3152(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList.WithLotsOfChildren
                    this_param)
                    {
                        var return_v = this_param.GetAnnotations();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(826, 3131, 3152);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList.WithLotsOfChildren
                    f_826_3100_3178(Microsoft.CodeAnalysis.DiagnosticInfo[]?
                    diagnostics, Microsoft.CodeAnalysis.SyntaxAnnotation[]
                    annotations, Microsoft.CodeAnalysis.ArrayElement<Microsoft.CodeAnalysis.GreenNode>[]
                    children, int[]
                    childOffsets)
                    {
                        var return_v = new Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList.WithLotsOfChildren(diagnostics, annotations, children, childOffsets);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(826, 3100, 3178);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(826, 2992, 3194);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(826, 2992, 3194);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override GreenNode SetAnnotations(SyntaxAnnotation[]? annotations)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(826, 3210, 3419);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(826, 3318, 3404);

                    return f_826_3325_3403(f_826_3348_3364(this), annotations, children, _childOffsets);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(826, 3210, 3419);

                    Microsoft.CodeAnalysis.DiagnosticInfo[]
                    f_826_3348_3364(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList.WithLotsOfChildren
                    this_param)
                    {
                        var return_v = this_param.GetDiagnostics();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(826, 3348, 3364);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList.WithLotsOfChildren
                    f_826_3325_3403(Microsoft.CodeAnalysis.DiagnosticInfo[]
                    diagnostics, Microsoft.CodeAnalysis.SyntaxAnnotation[]?
                    annotations, Microsoft.CodeAnalysis.ArrayElement<Microsoft.CodeAnalysis.GreenNode>[]
                    children, int[]
                    childOffsets)
                    {
                        var return_v = new Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList.WithLotsOfChildren(diagnostics, annotations, children, childOffsets);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(826, 3325, 3403);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(826, 3210, 3419);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(826, 3210, 3419);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(826, 390, 3430);

            static int
            f_826_538_629(System.Type
            type, System.Func<Roslyn.Utilities.ObjectReader, Roslyn.Utilities.IObjectWritable>
            typeReader)
            {
                ObjectBinder.RegisterTypeReader(type, typeReader);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(826, 538, 629);
                return 0;
            }


            static int[]
            f_826_860_886(Microsoft.CodeAnalysis.ArrayElement<Microsoft.CodeAnalysis.GreenNode>[]
            children)
            {
                var return_v = CalculateOffsets(children);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(826, 860, 886);
                return return_v;
            }


            static Microsoft.CodeAnalysis.ArrayElement<Microsoft.CodeAnalysis.GreenNode>[]
            f_826_802_810_C(Microsoft.CodeAnalysis.ArrayElement<Microsoft.CodeAnalysis.GreenNode>[]
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(826, 714, 902);
                return return_v;
            }


            static Microsoft.CodeAnalysis.DiagnosticInfo[]?
            f_826_1090_1101_C(Microsoft.CodeAnalysis.DiagnosticInfo[]?
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(826, 918, 1202);
                return return_v;
            }


            static int[]
            f_826_1347_1378(Microsoft.CodeAnalysis.ArrayElement<Microsoft.CodeAnalysis.GreenNode>[]
            children)
            {
                var return_v = CalculateOffsets(children);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(826, 1347, 1378);
                return return_v;
            }


            static Roslyn.Utilities.ObjectReader
            f_826_1291_1297_C(Roslyn.Utilities.ObjectReader
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(826, 1218, 1394);
                return return_v;
            }

        }
    }
}
