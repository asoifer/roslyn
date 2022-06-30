// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.Syntax.InternalSyntax
{
    internal partial class SyntaxList
    {
        internal class WithThreeChildren : SyntaxList
        {
            static WithThreeChildren()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(828, 433, 597);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(828, 492, 582);

                    f_828_492_581(typeof(WithThreeChildren), r => new WithThreeChildren(r));
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(828, 433, 597);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(828, 433, 597);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(828, 433, 597);
                }
            }

            private readonly GreenNode _child0;

            private readonly GreenNode _child1;

            private readonly GreenNode _child2;

            internal WithThreeChildren(GreenNode child0, GreenNode child1, GreenNode child2)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(828, 762, 1167);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(828, 640, 647);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(828, 689, 696);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(828, 738, 745);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(828, 875, 894);

                    this.SlotCount = 3;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(828, 912, 945);

                    f_828_912_944(this, child0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(828, 963, 980);

                    _child0 = child0;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(828, 998, 1031);

                    f_828_998_1030(this, child1);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(828, 1049, 1066);

                    _child1 = child1;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(828, 1084, 1117);

                    f_828_1084_1116(this, child2);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(828, 1135, 1152);

                    _child2 = child2;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(828, 762, 1167);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(828, 762, 1167);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(828, 762, 1167);
                }
            }

            internal WithThreeChildren(DiagnosticInfo[]? diagnostics, SyntaxAnnotation[]? annotations, GreenNode child0, GreenNode child1, GreenNode child2)
            : base(f_828_1352_1363_C(diagnostics), annotations)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(828, 1183, 1702);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(828, 640, 647);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(828, 689, 696);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(828, 738, 745);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(828, 1410, 1429);

                    this.SlotCount = 3;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(828, 1447, 1480);

                    f_828_1447_1479(this, child0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(828, 1498, 1515);

                    _child0 = child0;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(828, 1533, 1566);

                    f_828_1533_1565(this, child1);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(828, 1584, 1601);

                    _child1 = child1;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(828, 1619, 1652);

                    f_828_1619_1651(this, child2);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(828, 1670, 1687);

                    _child2 = child2;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(828, 1183, 1702);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(828, 1183, 1702);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(828, 1183, 1702);
                }
            }

            internal WithThreeChildren(ObjectReader reader)
            : base(f_828_1790_1796_C(reader))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(828, 1718, 2194);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(828, 640, 647);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(828, 689, 696);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(828, 738, 745);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(828, 1830, 1849);

                    this.SlotCount = 3;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(828, 1867, 1907);

                    _child0 = (GreenNode)f_828_1888_1906(reader);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(828, 1925, 1959);

                    f_828_1925_1958(this, _child0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(828, 1977, 2017);

                    _child1 = (GreenNode)f_828_1998_2016(reader);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(828, 2035, 2069);

                    f_828_2035_2068(this, _child1);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(828, 2087, 2127);

                    _child2 = (GreenNode)f_828_2108_2126(reader);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(828, 2145, 2179);

                    f_828_2145_2178(this, _child2);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(828, 1718, 2194);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(828, 1718, 2194);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(828, 1718, 2194);
                }
            }

            internal override void WriteTo(ObjectWriter writer)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(828, 2210, 2465);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(828, 2294, 2315);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.WriteTo(writer), 828, 2294, 2314);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(828, 2333, 2360);

                    f_828_2333_2359(writer, _child0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(828, 2378, 2405);

                    f_828_2378_2404(writer, _child1);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(828, 2423, 2450);

                    f_828_2423_2449(writer, _child2);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(828, 2210, 2465);

                    int
                    f_828_2333_2359(Roslyn.Utilities.ObjectWriter
                    this_param, Microsoft.CodeAnalysis.GreenNode
                    value)
                    {
                        this_param.WriteValue((Roslyn.Utilities.IObjectWritable)value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(828, 2333, 2359);
                        return 0;
                    }


                    int
                    f_828_2378_2404(Roslyn.Utilities.ObjectWriter
                    this_param, Microsoft.CodeAnalysis.GreenNode
                    value)
                    {
                        this_param.WriteValue((Roslyn.Utilities.IObjectWritable)value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(828, 2378, 2404);
                        return 0;
                    }


                    int
                    f_828_2423_2449(Roslyn.Utilities.ObjectWriter
                    this_param, Microsoft.CodeAnalysis.GreenNode
                    value)
                    {
                        this_param.WriteValue((Roslyn.Utilities.IObjectWritable)value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(828, 2423, 2449);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(828, 2210, 2465);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(828, 2210, 2465);
                }
            }

            internal override GreenNode? GetSlot(int index)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(828, 2481, 2906);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(828, 2561, 2891);

                    switch (index)
                    {

                        case 0:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(828, 2561, 2891);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(828, 2649, 2664);

                            return _child0;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(828, 2561, 2891);

                        case 1:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(828, 2561, 2891);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(828, 2719, 2734);

                            return _child1;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(828, 2561, 2891);

                        case 2:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(828, 2561, 2891);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(828, 2789, 2804);

                            return _child2;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(828, 2561, 2891);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(828, 2561, 2891);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(828, 2860, 2872);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(828, 2561, 2891);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(828, 2481, 2906);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(828, 2481, 2906);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(828, 2481, 2906);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override void CopyTo(ArrayElement<GreenNode>[] array, int offset)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(828, 2922, 3178);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(828, 3029, 3059);

                    array[offset].Value = _child0;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(828, 3077, 3111);

                    array[offset + 1].Value = _child1;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(828, 3129, 3163);

                    array[offset + 2].Value = _child2;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(828, 2922, 3178);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(828, 2922, 3178);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(828, 2922, 3178);
                }
            }

            internal override SyntaxNode CreateRed(SyntaxNode? parent, int position)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(828, 3194, 3385);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(828, 3299, 3370);

                    return f_828_3306_3369(this, parent, position);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(828, 3194, 3385);

                    Microsoft.CodeAnalysis.Syntax.SyntaxList.WithThreeChildren
                    f_828_3306_3369(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList.WithThreeChildren
                    green, Microsoft.CodeAnalysis.SyntaxNode?
                    parent, int
                    position)
                    {
                        var return_v = new Microsoft.CodeAnalysis.Syntax.SyntaxList.WithThreeChildren((Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList)green, parent, position);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(828, 3306, 3369);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(828, 3194, 3385);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(828, 3194, 3385);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override GreenNode SetDiagnostics(DiagnosticInfo[]? errors)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(828, 3401, 3604);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(828, 3502, 3589);

                    return f_828_3509_3588(errors, f_828_3539_3560(this), _child0, _child1, _child2);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(828, 3401, 3604);

                    Microsoft.CodeAnalysis.SyntaxAnnotation[]
                    f_828_3539_3560(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList.WithThreeChildren
                    this_param)
                    {
                        var return_v = this_param.GetAnnotations();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(828, 3539, 3560);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList.WithThreeChildren
                    f_828_3509_3588(Microsoft.CodeAnalysis.DiagnosticInfo[]?
                    diagnostics, Microsoft.CodeAnalysis.SyntaxAnnotation[]
                    annotations, Microsoft.CodeAnalysis.GreenNode
                    child0, Microsoft.CodeAnalysis.GreenNode
                    child1, Microsoft.CodeAnalysis.GreenNode
                    child2)
                    {
                        var return_v = new Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList.WithThreeChildren(diagnostics, annotations, child0, child1, child2);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(828, 3509, 3588);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(828, 3401, 3604);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(828, 3401, 3604);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override GreenNode SetAnnotations(SyntaxAnnotation[]? annotations)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(828, 3620, 3830);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(828, 3728, 3815);

                    return f_828_3735_3814(f_828_3757_3773(this), annotations, _child0, _child1, _child2);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(828, 3620, 3830);

                    Microsoft.CodeAnalysis.DiagnosticInfo[]
                    f_828_3757_3773(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList.WithThreeChildren
                    this_param)
                    {
                        var return_v = this_param.GetDiagnostics();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(828, 3757, 3773);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList.WithThreeChildren
                    f_828_3735_3814(Microsoft.CodeAnalysis.DiagnosticInfo[]
                    diagnostics, Microsoft.CodeAnalysis.SyntaxAnnotation[]?
                    annotations, Microsoft.CodeAnalysis.GreenNode
                    child0, Microsoft.CodeAnalysis.GreenNode
                    child1, Microsoft.CodeAnalysis.GreenNode
                    child2)
                    {
                        var return_v = new Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList.WithThreeChildren(diagnostics, annotations, child0, child1, child2);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(828, 3735, 3814);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(828, 3620, 3830);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(828, 3620, 3830);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(828, 363, 3841);

            static int
            f_828_492_581(System.Type
            type, System.Func<Roslyn.Utilities.ObjectReader, Roslyn.Utilities.IObjectWritable>
            typeReader)
            {
                ObjectBinder.RegisterTypeReader(type, typeReader);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(828, 492, 581);
                return 0;
            }


            static int
            f_828_912_944(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList.WithThreeChildren
            this_param, Microsoft.CodeAnalysis.GreenNode
            node)
            {
                this_param.AdjustFlagsAndWidth(node);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(828, 912, 944);
                return 0;
            }


            static int
            f_828_998_1030(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList.WithThreeChildren
            this_param, Microsoft.CodeAnalysis.GreenNode
            node)
            {
                this_param.AdjustFlagsAndWidth(node);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(828, 998, 1030);
                return 0;
            }


            static int
            f_828_1084_1116(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList.WithThreeChildren
            this_param, Microsoft.CodeAnalysis.GreenNode
            node)
            {
                this_param.AdjustFlagsAndWidth(node);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(828, 1084, 1116);
                return 0;
            }


            static int
            f_828_1447_1479(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList.WithThreeChildren
            this_param, Microsoft.CodeAnalysis.GreenNode
            node)
            {
                this_param.AdjustFlagsAndWidth(node);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(828, 1447, 1479);
                return 0;
            }


            static int
            f_828_1533_1565(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList.WithThreeChildren
            this_param, Microsoft.CodeAnalysis.GreenNode
            node)
            {
                this_param.AdjustFlagsAndWidth(node);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(828, 1533, 1565);
                return 0;
            }


            static int
            f_828_1619_1651(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList.WithThreeChildren
            this_param, Microsoft.CodeAnalysis.GreenNode
            node)
            {
                this_param.AdjustFlagsAndWidth(node);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(828, 1619, 1651);
                return 0;
            }


            static Microsoft.CodeAnalysis.DiagnosticInfo[]?
            f_828_1352_1363_C(Microsoft.CodeAnalysis.DiagnosticInfo[]?
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(828, 1183, 1702);
                return return_v;
            }


            static object
            f_828_1888_1906(Roslyn.Utilities.ObjectReader
            this_param)
            {
                var return_v = this_param.ReadValue();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(828, 1888, 1906);
                return return_v;
            }


            static int
            f_828_1925_1958(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList.WithThreeChildren
            this_param, Microsoft.CodeAnalysis.GreenNode
            node)
            {
                this_param.AdjustFlagsAndWidth(node);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(828, 1925, 1958);
                return 0;
            }


            static object
            f_828_1998_2016(Roslyn.Utilities.ObjectReader
            this_param)
            {
                var return_v = this_param.ReadValue();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(828, 1998, 2016);
                return return_v;
            }


            static int
            f_828_2035_2068(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList.WithThreeChildren
            this_param, Microsoft.CodeAnalysis.GreenNode
            node)
            {
                this_param.AdjustFlagsAndWidth(node);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(828, 2035, 2068);
                return 0;
            }


            static object
            f_828_2108_2126(Roslyn.Utilities.ObjectReader
            this_param)
            {
                var return_v = this_param.ReadValue();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(828, 2108, 2126);
                return return_v;
            }


            static int
            f_828_2145_2178(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList.WithThreeChildren
            this_param, Microsoft.CodeAnalysis.GreenNode
            node)
            {
                this_param.AdjustFlagsAndWidth(node);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(828, 2145, 2178);
                return 0;
            }


            static Roslyn.Utilities.ObjectReader
            f_828_1790_1796_C(Roslyn.Utilities.ObjectReader
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(828, 1718, 2194);
                return return_v;
            }

        }
    }
}
