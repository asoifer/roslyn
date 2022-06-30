// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.Syntax.InternalSyntax
{
    internal partial class SyntaxList
    {
        internal class WithTwoChildren : SyntaxList
        {
            static WithTwoChildren()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(829, 466, 624);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(829, 523, 609);

                    f_829_523_608(typeof(WithTwoChildren), r => new WithTwoChildren(r));
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(829, 466, 624);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(829, 466, 624);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(829, 466, 624);
                }
            }

            private readonly GreenNode _child0;

            private readonly GreenNode _child1;

            internal WithTwoChildren(GreenNode child0, GreenNode child1)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(829, 740, 1039);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(829, 667, 674);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(829, 716, 723);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(829, 833, 852);

                    this.SlotCount = 2;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(829, 870, 903);

                    f_829_870_902(this, child0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(829, 921, 938);

                    _child0 = child0;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(829, 956, 989);

                    f_829_956_988(this, child1);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(829, 1007, 1024);

                    _child1 = child1;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(829, 740, 1039);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(829, 740, 1039);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(829, 740, 1039);
                }
            }

            internal WithTwoChildren(DiagnosticInfo[]? diagnostics, SyntaxAnnotation[]? annotations, GreenNode child0, GreenNode child1)
            : base(f_829_1204_1215_C(diagnostics), annotations)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(829, 1055, 1468);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(829, 667, 674);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(829, 716, 723);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(829, 1262, 1281);

                    this.SlotCount = 2;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(829, 1299, 1332);

                    f_829_1299_1331(this, child0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(829, 1350, 1367);

                    _child0 = child0;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(829, 1385, 1418);

                    f_829_1385_1417(this, child1);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(829, 1436, 1453);

                    _child1 = child1;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(829, 1055, 1468);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(829, 1055, 1468);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(829, 1055, 1468);
                }
            }

            internal WithTwoChildren(ObjectReader reader)
            : base(f_829_1554_1560_C(reader))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(829, 1484, 1848);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(829, 667, 674);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(829, 716, 723);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(829, 1594, 1613);

                    this.SlotCount = 2;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(829, 1631, 1671);

                    _child0 = (GreenNode)f_829_1652_1670(reader);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(829, 1689, 1723);

                    f_829_1689_1722(this, _child0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(829, 1741, 1781);

                    _child1 = (GreenNode)f_829_1762_1780(reader);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(829, 1799, 1833);

                    f_829_1799_1832(this, _child1);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(829, 1484, 1848);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(829, 1484, 1848);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(829, 1484, 1848);
                }
            }

            internal override void WriteTo(ObjectWriter writer)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(829, 1864, 2074);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(829, 1948, 1969);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.WriteTo(writer), 829, 1948, 1968);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(829, 1987, 2014);

                    f_829_1987_2013(writer, _child0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(829, 2032, 2059);

                    f_829_2032_2058(writer, _child1);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(829, 1864, 2074);

                    int
                    f_829_1987_2013(Roslyn.Utilities.ObjectWriter
                    this_param, Microsoft.CodeAnalysis.GreenNode
                    value)
                    {
                        this_param.WriteValue((Roslyn.Utilities.IObjectWritable)value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(829, 1987, 2013);
                        return 0;
                    }


                    int
                    f_829_2032_2058(Roslyn.Utilities.ObjectWriter
                    this_param, Microsoft.CodeAnalysis.GreenNode
                    value)
                    {
                        this_param.WriteValue((Roslyn.Utilities.IObjectWritable)value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(829, 2032, 2058);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(829, 1864, 2074);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(829, 1864, 2074);
                }
            }

            internal override GreenNode? GetSlot(int index)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(829, 2090, 2445);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(829, 2170, 2430);

                    switch (index)
                    {

                        case 0:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(829, 2170, 2430);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(829, 2258, 2273);

                            return _child0;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(829, 2170, 2430);

                        case 1:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(829, 2170, 2430);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(829, 2328, 2343);

                            return _child1;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(829, 2170, 2430);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(829, 2170, 2430);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(829, 2399, 2411);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(829, 2170, 2430);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(829, 2090, 2445);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(829, 2090, 2445);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(829, 2090, 2445);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override void CopyTo(ArrayElement<GreenNode>[] array, int offset)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(829, 2461, 2665);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(829, 2568, 2598);

                    array[offset].Value = _child0;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(829, 2616, 2650);

                    array[offset + 1].Value = _child1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(829, 2461, 2665);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(829, 2461, 2665);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(829, 2461, 2665);
                }
            }

            internal override SyntaxNode CreateRed(SyntaxNode? parent, int position)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(829, 2681, 2870);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(829, 2786, 2855);

                    return f_829_2793_2854(this, parent, position);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(829, 2681, 2870);

                    Microsoft.CodeAnalysis.Syntax.SyntaxList.WithTwoChildren
                    f_829_2793_2854(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList.WithTwoChildren
                    green, Microsoft.CodeAnalysis.SyntaxNode?
                    parent, int
                    position)
                    {
                        var return_v = new Microsoft.CodeAnalysis.Syntax.SyntaxList.WithTwoChildren((Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList)green, parent, position);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(829, 2793, 2854);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(829, 2681, 2870);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(829, 2681, 2870);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override GreenNode SetDiagnostics(DiagnosticInfo[]? errors)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(829, 2886, 3078);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(829, 2987, 3063);

                    return f_829_2994_3062(errors, f_829_3022_3043(this), _child0, _child1);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(829, 2886, 3078);

                    Microsoft.CodeAnalysis.SyntaxAnnotation[]
                    f_829_3022_3043(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList.WithTwoChildren
                    this_param)
                    {
                        var return_v = this_param.GetAnnotations();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(829, 3022, 3043);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList.WithTwoChildren
                    f_829_2994_3062(Microsoft.CodeAnalysis.DiagnosticInfo[]?
                    diagnostics, Microsoft.CodeAnalysis.SyntaxAnnotation[]
                    annotations, Microsoft.CodeAnalysis.GreenNode
                    child0, Microsoft.CodeAnalysis.GreenNode
                    child1)
                    {
                        var return_v = new Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList.WithTwoChildren(diagnostics, annotations, child0, child1);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(829, 2994, 3062);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(829, 2886, 3078);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(829, 2886, 3078);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override GreenNode SetAnnotations(SyntaxAnnotation[]? annotations)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(829, 3094, 3293);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(829, 3202, 3278);

                    return f_829_3209_3277(f_829_3229_3245(this), annotations, _child0, _child1);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(829, 3094, 3293);

                    Microsoft.CodeAnalysis.DiagnosticInfo[]
                    f_829_3229_3245(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList.WithTwoChildren
                    this_param)
                    {
                        var return_v = this_param.GetDiagnostics();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(829, 3229, 3245);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList.WithTwoChildren
                    f_829_3209_3277(Microsoft.CodeAnalysis.DiagnosticInfo[]
                    diagnostics, Microsoft.CodeAnalysis.SyntaxAnnotation[]?
                    annotations, Microsoft.CodeAnalysis.GreenNode
                    child0, Microsoft.CodeAnalysis.GreenNode
                    child1)
                    {
                        var return_v = new Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList.WithTwoChildren(diagnostics, annotations, child0, child1);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(829, 3209, 3277);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(829, 3094, 3293);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(829, 3094, 3293);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(829, 398, 3304);

            static int
            f_829_523_608(System.Type
            type, System.Func<Roslyn.Utilities.ObjectReader, Roslyn.Utilities.IObjectWritable>
            typeReader)
            {
                ObjectBinder.RegisterTypeReader(type, typeReader);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(829, 523, 608);
                return 0;
            }


            static int
            f_829_870_902(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList.WithTwoChildren
            this_param, Microsoft.CodeAnalysis.GreenNode
            node)
            {
                this_param.AdjustFlagsAndWidth(node);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(829, 870, 902);
                return 0;
            }


            static int
            f_829_956_988(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList.WithTwoChildren
            this_param, Microsoft.CodeAnalysis.GreenNode
            node)
            {
                this_param.AdjustFlagsAndWidth(node);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(829, 956, 988);
                return 0;
            }


            static int
            f_829_1299_1331(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList.WithTwoChildren
            this_param, Microsoft.CodeAnalysis.GreenNode
            node)
            {
                this_param.AdjustFlagsAndWidth(node);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(829, 1299, 1331);
                return 0;
            }


            static int
            f_829_1385_1417(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList.WithTwoChildren
            this_param, Microsoft.CodeAnalysis.GreenNode
            node)
            {
                this_param.AdjustFlagsAndWidth(node);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(829, 1385, 1417);
                return 0;
            }


            static Microsoft.CodeAnalysis.DiagnosticInfo[]?
            f_829_1204_1215_C(Microsoft.CodeAnalysis.DiagnosticInfo[]?
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(829, 1055, 1468);
                return return_v;
            }


            static object
            f_829_1652_1670(Roslyn.Utilities.ObjectReader
            this_param)
            {
                var return_v = this_param.ReadValue();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(829, 1652, 1670);
                return return_v;
            }


            static int
            f_829_1689_1722(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList.WithTwoChildren
            this_param, Microsoft.CodeAnalysis.GreenNode
            node)
            {
                this_param.AdjustFlagsAndWidth(node);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(829, 1689, 1722);
                return 0;
            }


            static object
            f_829_1762_1780(Roslyn.Utilities.ObjectReader
            this_param)
            {
                var return_v = this_param.ReadValue();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(829, 1762, 1780);
                return return_v;
            }


            static int
            f_829_1799_1832(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList.WithTwoChildren
            this_param, Microsoft.CodeAnalysis.GreenNode
            node)
            {
                this_param.AdjustFlagsAndWidth(node);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(829, 1799, 1832);
                return 0;
            }


            static Roslyn.Utilities.ObjectReader
            f_829_1554_1560_C(Roslyn.Utilities.ObjectReader
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(829, 1484, 1848);
                return return_v;
            }

        }
    }
}
