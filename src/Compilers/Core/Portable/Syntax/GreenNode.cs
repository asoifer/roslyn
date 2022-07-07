// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.CodeAnalysis.Collections;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Syntax.InternalSyntax;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
    [DebuggerDisplay("{GetDebuggerDisplay(), nq}")]
    internal abstract class GreenNode : IObjectWritable
    {
        private string GetDebuggerDisplay()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(661, 733, 877);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 793, 866);

                return f_661_800_819(f_661_800_814(this)) + " " + f_661_828_841(this) + " " + f_661_850_865(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(661, 733, 877);

                System.Type
                f_661_800_814(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 800, 814);
                    return return_v;
                }


                string
                f_661_800_819(System.Type
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(661, 800, 819);
                    return return_v;
                }


                string
                f_661_828_841(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.KindText;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(661, 828, 841);
                    return return_v;
                }


                string
                f_661_850_865(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 850, 865);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(661, 733, 877);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(661, 733, 877);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal const int
        ListKind = 1
        ;

        private readonly ushort _kind;

        protected NodeFlags flags;

        private byte _slotCount;

        private int _fullWidth;

        private static readonly ConditionalWeakTable<GreenNode, DiagnosticInfo[]> s_diagnosticsTable;

        private static readonly ConditionalWeakTable<GreenNode, SyntaxAnnotation[]> s_annotationsTable;

        private static readonly DiagnosticInfo[] s_noDiagnostics;

        private static readonly SyntaxAnnotation[] s_noAnnotations;

        private static readonly IEnumerable<SyntaxAnnotation> s_noAnnotationsEnumerable;

        protected GreenNode(ushort kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(661, 1789, 1870);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 957, 962);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 993, 998);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 1022, 1032);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 1055, 1065);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 1846, 1859);

                _kind = kind;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(661, 1789, 1870);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(661, 1789, 1870);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(661, 1789, 1870);
            }
        }

        protected GreenNode(ushort kind, int fullWidth)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(661, 1882, 2015);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 957, 962);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 993, 998);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 1022, 1032);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 1055, 1065);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 1954, 1967);

                _kind = kind;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 1981, 2004);

                _fullWidth = fullWidth;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(661, 1882, 2015);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(661, 1882, 2015);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(661, 1882, 2015);
            }
        }

        protected GreenNode(ushort kind, DiagnosticInfo[]? diagnostics, int fullWidth)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(661, 2027, 2385);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 957, 962);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 993, 998);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 1022, 1032);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 1055, 1065);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 2130, 2143);

                _kind = kind;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 2157, 2180);

                _fullWidth = fullWidth;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 2194, 2374) || true) && (f_661_2198_2217_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(diagnostics, 661, 2198, 2217)?.Length) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(661, 2194, 2374);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 2255, 2299);

                    this.flags |= NodeFlags.ContainsDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 2317, 2359);

                    f_661_2317_2358(s_diagnosticsTable, this, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(661, 2194, 2374);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(661, 2027, 2385);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(661, 2027, 2385);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(661, 2027, 2385);
            }
        }

        protected GreenNode(ushort kind, DiagnosticInfo[]? diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(661, 2397, 2703);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 957, 962);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 993, 998);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 1022, 1032);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 1055, 1065);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 2485, 2498);

                _kind = kind;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 2512, 2692) || true) && (f_661_2516_2535_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(diagnostics, 661, 2516, 2535)?.Length) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(661, 2512, 2692);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 2573, 2617);

                    this.flags |= NodeFlags.ContainsDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 2635, 2677);

                    f_661_2635_2676(s_diagnosticsTable, this, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(661, 2512, 2692);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(661, 2397, 2703);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(661, 2397, 2703);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(661, 2397, 2703);
            }
        }

        protected GreenNode(ushort kind, DiagnosticInfo[]? diagnostics, SyntaxAnnotation[]? annotations) : this(f_661_2832_2836_C(kind), diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(661, 2715, 3323);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 2875, 3312) || true) && (f_661_2879_2898_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(annotations, 661, 2879, 2898)?.Length) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(661, 2875, 3312);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 2936, 3173);
                        foreach (var annotation in f_661_2963_2974_I(annotations))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(661, 2936, 3173);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 3016, 3154) || true) && (annotation == null)
                            )
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(661, 3016, 3154);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 3040, 3154);

                                throw f_661_3046_3153(paramName: nameof(annotations), message: "");
                                DynAbs.Tracing.TraceSender.TraceExitCondition(661, 3016, 3154);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(661, 2936, 3173);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(661, 1, 238);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(661, 1, 238);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 3193, 3237);

                    this.flags |= NodeFlags.ContainsAnnotations;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 3255, 3297);

                    f_661_3255_3296(s_annotationsTable, this, annotations);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(661, 2875, 3312);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(661, 2715, 3323);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(661, 2715, 3323);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(661, 2715, 3323);
            }
        }

        protected GreenNode(ushort kind, DiagnosticInfo[]? diagnostics, SyntaxAnnotation[]? annotations, int fullWidth) : this(f_661_3467_3471_C(kind), diagnostics, fullWidth)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(661, 3335, 3969);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 3521, 3958) || true) && (f_661_3525_3544_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(annotations, 661, 3525, 3544)?.Length) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(661, 3521, 3958);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 3582, 3819);
                        foreach (var annotation in f_661_3609_3620_I(annotations))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(661, 3582, 3819);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 3662, 3800) || true) && (annotation == null)
                            )
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(661, 3662, 3800);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 3686, 3800);

                                throw f_661_3692_3799(paramName: nameof(annotations), message: "");
                                DynAbs.Tracing.TraceSender.TraceExitCondition(661, 3662, 3800);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(661, 3582, 3819);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(661, 1, 238);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(661, 1, 238);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 3839, 3883);

                    this.flags |= NodeFlags.ContainsAnnotations;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 3901, 3943);

                    f_661_3901_3942(s_annotationsTable, this, annotations);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(661, 3521, 3958);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(661, 3335, 3969);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(661, 3335, 3969);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(661, 3335, 3969);
            }
        }

        protected void AdjustFlagsAndWidth(GreenNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(661, 3981, 4292);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 4056, 4172);

                f_661_4056_4171(node != null, "PERF: caller must ensure that node!=null, we do not want to re-check that here.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 4186, 4237);

                this.flags |= (node.flags & NodeFlags.InheritMask);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 4251, 4281);

                _fullWidth += node._fullWidth;
                DynAbs.Tracing.TraceSender.TraceExitMethod(661, 3981, 4292);

                int
                f_661_4056_4171(bool
                b, string
                message)
                {
                    RoslynDebug.Assert(b, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 4056, 4171);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(661, 3981, 4292);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(661, 3981, 4292);
            }
        }

        public abstract string Language { get; }

        public int RawKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(661, 4422, 4443);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 4428, 4441);

                    return _kind;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(661, 4422, 4443);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(661, 4379, 4454);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(661, 4379, 4454);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsList
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(661, 4509, 4587);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 4545, 4572);

                    return f_661_4552_4559() == ListKind;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(661, 4509, 4587);

                    int
                    f_661_4552_4559()
                    {
                        var return_v = RawKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(661, 4552, 4559);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(661, 4466, 4598);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(661, 4466, 4598);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public abstract string KindText { get; }

        public virtual bool IsStructuredTrivia
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(661, 4701, 4709);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 4704, 4709);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(661, 4701, 4709);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(661, 4701, 4709);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(661, 4701, 4709);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public virtual bool IsDirective
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(661, 4752, 4760);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 4755, 4760);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(661, 4752, 4760);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(661, 4752, 4760);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(661, 4752, 4760);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public virtual bool IsToken
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(661, 4799, 4807);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 4802, 4807);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(661, 4799, 4807);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(661, 4799, 4807);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(661, 4799, 4807);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public virtual bool IsTrivia
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(661, 4847, 4855);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 4850, 4855);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(661, 4847, 4855);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(661, 4847, 4855);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(661, 4847, 4855);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public virtual bool IsSkippedTokensTrivia
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(661, 4908, 4916);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 4911, 4916);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(661, 4908, 4916);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(661, 4908, 4916);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(661, 4908, 4916);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public virtual bool IsDocumentationCommentTrivia
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(661, 4976, 4984);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 4979, 4984);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(661, 4976, 4984);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(661, 4976, 4984);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(661, 4976, 4984);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public int SlotCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(661, 5088, 5323);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 5124, 5147);

                    int
                    count = _slotCount
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 5165, 5275) || true) && (count == byte.MaxValue)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(661, 5165, 5275);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 5233, 5256);

                        count = f_661_5241_5255(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(661, 5165, 5275);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 5295, 5308);

                    return count;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(661, 5088, 5323);

                    int
                    f_661_5241_5255(Microsoft.CodeAnalysis.GreenNode
                    this_param)
                    {
                        var return_v = this_param.GetSlotCount();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 5241, 5255);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(661, 5043, 5436);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(661, 5043, 5436);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            protected set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(661, 5339, 5425);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 5385, 5410);

                    _slotCount = (byte)value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(661, 5339, 5425);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(661, 5043, 5436);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(661, 5043, 5436);
                }
            }
        }

        internal abstract GreenNode? GetSlot(int index);

        internal GreenNode GetRequiredSlot(int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(661, 5508, 5690);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 5578, 5604);

                var
                node = f_661_5589_5603(this, index)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 5618, 5653);

                f_661_5618_5652(node is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 5667, 5679);

                return node;
                DynAbs.Tracing.TraceSender.TraceExitMethod(661, 5508, 5690);

                Microsoft.CodeAnalysis.GreenNode?
                f_661_5589_5603(Microsoft.CodeAnalysis.GreenNode
                this_param, int
                index)
                {
                    var return_v = this_param.GetSlot(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 5589, 5603);
                    return return_v;
                }


                int
                f_661_5618_5652(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 5618, 5652);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(661, 5508, 5690);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(661, 5508, 5690);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected virtual int GetSlotCount()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(661, 5747, 5837);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 5808, 5826);

                return _slotCount;
                DynAbs.Tracing.TraceSender.TraceExitMethod(661, 5747, 5837);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(661, 5747, 5837);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(661, 5747, 5837);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual int GetSlotOffset(int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(661, 5849, 6216);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 5917, 5932);

                int
                offset = 0
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 5955, 5960);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 5946, 6175) || true) && (i < index)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 5973, 5976)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(661, 5946, 6175))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(661, 5946, 6175);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 6010, 6038);

                        var
                        child = f_661_6022_6037(this, i)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 6056, 6160) || true) && (child != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(661, 6056, 6160);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 6115, 6141);

                            offset += f_661_6125_6140(child);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(661, 6056, 6160);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(661, 1, 230);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(661, 1, 230);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 6191, 6205);

                return offset;
                DynAbs.Tracing.TraceSender.TraceExitMethod(661, 5849, 6216);

                Microsoft.CodeAnalysis.GreenNode?
                f_661_6022_6037(Microsoft.CodeAnalysis.GreenNode
                this_param, int
                index)
                {
                    var return_v = this_param.GetSlot(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 6022, 6037);
                    return return_v;
                }


                int
                f_661_6125_6140(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.FullWidth;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(661, 6125, 6140);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(661, 5849, 6216);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(661, 5849, 6216);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Syntax.InternalSyntax.ChildSyntaxList ChildNodesAndTokens()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(661, 6228, 6387);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 6321, 6376);

                return f_661_6328_6375(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(661, 6228, 6387);

                Microsoft.CodeAnalysis.Syntax.InternalSyntax.ChildSyntaxList
                f_661_6328_6375(Microsoft.CodeAnalysis.GreenNode
                node)
                {
                    var return_v = new Microsoft.CodeAnalysis.Syntax.InternalSyntax.ChildSyntaxList(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 6328, 6375);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(661, 6228, 6387);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(661, 6228, 6387);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal IEnumerable<GreenNode> EnumerateNodes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(661, 6535, 7470);

                var listYield = new List<GreenNode>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 6608, 6626);

                listYield.Add(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 6642, 6718);

                var
                stack = f_661_6654_6717(24)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 6732, 6787);

                f_661_6732_6786(stack, f_661_6743_6769(this).GetEnumerator());
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 6803, 7459) || true) && (f_661_6810_6821(stack) > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(661, 6803, 7459);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 6859, 6880);

                        var
                        en = f_661_6868_6879(stack)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 6898, 7035) || true) && (!en.MoveNext())
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(661, 6898, 7035);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 7007, 7016);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(661, 6898, 7035);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 7055, 7080);

                        var
                        current = en.Current
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 7098, 7113);

                        f_661_7098_7112(stack, en);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 7177, 7198);

                        listYield.Add(current);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 7218, 7444) || true) && (f_661_7222_7238_M(!current.IsToken))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(661, 7218, 7444);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 7336, 7394);

                            f_661_7336_7393(                    // not token, so consider children
                                                stack, f_661_7347_7376(current).GetEnumerator());
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 7416, 7425);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(661, 7218, 7444);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(661, 6803, 7459);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(661, 6803, 7459);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(661, 6803, 7459);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(661, 6535, 7470);

                return listYield;

                System.Collections.Generic.Stack<Microsoft.CodeAnalysis.Syntax.InternalSyntax.ChildSyntaxList.Enumerator>
                f_661_6654_6717(int
                capacity)
                {
                    var return_v = new System.Collections.Generic.Stack<Microsoft.CodeAnalysis.Syntax.InternalSyntax.ChildSyntaxList.Enumerator>(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 6654, 6717);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.ChildSyntaxList
                f_661_6743_6769(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.ChildNodesAndTokens();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 6743, 6769);
                    return return_v;
                }


                int
                f_661_6732_6786(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.Syntax.InternalSyntax.ChildSyntaxList.Enumerator>
                this_param, Microsoft.CodeAnalysis.Syntax.InternalSyntax.ChildSyntaxList.Enumerator
                item)
                {
                    this_param.Push(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 6732, 6786);
                    return 0;
                }


                int
                f_661_6810_6821(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.Syntax.InternalSyntax.ChildSyntaxList.Enumerator>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(661, 6810, 6821);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.ChildSyntaxList.Enumerator
                f_661_6868_6879(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.Syntax.InternalSyntax.ChildSyntaxList.Enumerator>
                this_param)
                {
                    var return_v = this_param.Pop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 6868, 6879);
                    return return_v;
                }


                int
                f_661_7098_7112(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.Syntax.InternalSyntax.ChildSyntaxList.Enumerator>
                this_param, Microsoft.CodeAnalysis.Syntax.InternalSyntax.ChildSyntaxList.Enumerator
                item)
                {
                    this_param.Push(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 7098, 7112);
                    return 0;
                }


                bool
                f_661_7222_7238_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(661, 7222, 7238);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.ChildSyntaxList
                f_661_7347_7376(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.ChildNodesAndTokens();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 7347, 7376);
                    return return_v;
                }


                int
                f_661_7336_7393(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.Syntax.InternalSyntax.ChildSyntaxList.Enumerator>
                this_param, Microsoft.CodeAnalysis.Syntax.InternalSyntax.ChildSyntaxList.Enumerator
                item)
                {
                    this_param.Push(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 7336, 7393);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(661, 6535, 7470);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(661, 6535, 7470);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual int FindSlotIndexContainingOffset(int offset)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(661, 7981, 8622);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 8066, 8114);

                f_661_8066_8113(0 <= offset && (DynAbs.Tracing.TraceSender.Expression_True(661, 8079, 8112) && offset < f_661_8103_8112()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 8130, 8136);

                int
                i
                = default(int);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 8150, 8175);

                int
                accumulatedWidth = 0
                ;
                try
                {
                    for (DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 8194, 8199)
   , i = 0; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 8189, 8586) || true) && (true)
   ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 8203, 8206)
   , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(661, 8189, 8586))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(661, 8189, 8586);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 8240, 8268);

                        f_661_8240_8267(i < f_661_8257_8266());
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 8286, 8309);

                        var
                        child = f_661_8298_8308(this, i)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 8327, 8571) || true) && (child != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(661, 8327, 8571);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 8386, 8422);

                            accumulatedWidth += f_661_8406_8421(child);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 8444, 8552) || true) && (offset < accumulatedWidth)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(661, 8444, 8552);
                                DynAbs.Tracing.TraceSender.TraceBreak(661, 8523, 8529);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(661, 8444, 8552);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(661, 8327, 8571);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(661, 1, 398);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(661, 1, 398);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 8602, 8611);

                return i;
                DynAbs.Tracing.TraceSender.TraceExitMethod(661, 7981, 8622);

                int
                f_661_8103_8112()
                {
                    var return_v = FullWidth;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(661, 8103, 8112);
                    return return_v;
                }


                int
                f_661_8066_8113(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 8066, 8113);
                    return 0;
                }


                int
                f_661_8257_8266()
                {
                    var return_v = SlotCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(661, 8257, 8266);
                    return return_v;
                }


                int
                f_661_8240_8267(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 8240, 8267);
                    return 0;
                }


                Microsoft.CodeAnalysis.GreenNode?
                f_661_8298_8308(Microsoft.CodeAnalysis.GreenNode
                this_param, int
                index)
                {
                    var return_v = this_param.GetSlot(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 8298, 8308);
                    return return_v;
                }


                int
                f_661_8406_8421(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.FullWidth;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(661, 8406, 8421);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(661, 7981, 8622);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(661, 7981, 8622);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }


        [Flags]
        internal enum NodeFlags : byte
        {
            None = 0,
            ContainsDiagnostics = 1 << 0,
            ContainsStructuredTrivia = 1 << 1,
            ContainsDirectives = 1 << 2,
            ContainsSkippedText = 1 << 3,
            ContainsAnnotations = 1 << 4,
            IsNotMissing = 1 << 5,

            FactoryContextIsInAsync = 1 << 6,
            FactoryContextIsInQuery = 1 << 7,
            FactoryContextIsInIterator = FactoryContextIsInQuery,  // VB does not use "InQuery", but uses "InIterator" instead

            InheritMask = ContainsDiagnostics | ContainsStructuredTrivia | ContainsDirectives | ContainsSkippedText | ContainsAnnotations | IsNotMissing,
        }

        internal NodeFlags Flags
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(661, 9469, 9495);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 9475, 9493);

                    return this.flags;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(661, 9469, 9495);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(661, 9420, 9506);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(661, 9420, 9506);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal void SetFlags(NodeFlags flags)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(661, 9518, 9613);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 9582, 9602);

                this.flags |= flags;
                DynAbs.Tracing.TraceSender.TraceExitMethod(661, 9518, 9613);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(661, 9518, 9613);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(661, 9518, 9613);
            }
        }

        internal void ClearFlags(NodeFlags flags)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(661, 9625, 9723);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 9691, 9712);

                this.flags &= ~flags;
                DynAbs.Tracing.TraceSender.TraceExitMethod(661, 9625, 9723);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(661, 9625, 9723);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(661, 9625, 9723);
            }
        }

        internal bool IsMissing
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(661, 9783, 9941);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 9876, 9926);

                    return (this.flags & NodeFlags.IsNotMissing) == 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(661, 9783, 9941);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(661, 9735, 9952);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(661, 9735, 9952);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool ParsedInAsync
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(661, 10016, 10128);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 10052, 10113);

                    return (this.flags & NodeFlags.FactoryContextIsInAsync) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(661, 10016, 10128);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(661, 9964, 10139);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(661, 9964, 10139);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool ParsedInQuery
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(661, 10203, 10315);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 10239, 10300);

                    return (this.flags & NodeFlags.FactoryContextIsInQuery) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(661, 10203, 10315);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(661, 10151, 10326);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(661, 10151, 10326);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool ParsedInIterator
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(661, 10393, 10508);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 10429, 10493);

                    return (this.flags & NodeFlags.FactoryContextIsInIterator) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(661, 10393, 10508);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(661, 10338, 10519);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(661, 10338, 10519);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool ContainsSkippedText
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(661, 10587, 10695);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 10623, 10680);

                    return (this.flags & NodeFlags.ContainsSkippedText) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(661, 10587, 10695);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(661, 10531, 10706);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(661, 10531, 10706);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool ContainsStructuredTrivia
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(661, 10779, 10892);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 10815, 10877);

                    return (this.flags & NodeFlags.ContainsStructuredTrivia) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(661, 10779, 10892);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(661, 10718, 10903);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(661, 10718, 10903);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool ContainsDirectives
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(661, 10970, 11077);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 11006, 11062);

                    return (this.flags & NodeFlags.ContainsDirectives) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(661, 10970, 11077);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(661, 10915, 11088);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(661, 10915, 11088);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool ContainsDiagnostics
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(661, 11156, 11264);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 11192, 11249);

                    return (this.flags & NodeFlags.ContainsDiagnostics) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(661, 11156, 11264);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(661, 11100, 11275);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(661, 11100, 11275);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool ContainsAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(661, 11343, 11451);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 11379, 11436);

                    return (this.flags & NodeFlags.ContainsAnnotations) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(661, 11343, 11451);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(661, 11287, 11462);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(661, 11287, 11462);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public int FullWidth
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(661, 11562, 11631);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 11598, 11616);

                    return _fullWidth;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(661, 11562, 11631);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(661, 11517, 11738);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(661, 11517, 11738);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            protected set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(661, 11647, 11727);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 11693, 11712);

                    _fullWidth = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(661, 11647, 11727);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(661, 11517, 11738);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(661, 11517, 11738);
                }
            }
        }

        public virtual int Width
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(661, 11799, 11931);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 11835, 11916);

                    return _fullWidth - f_661_11855_11883(this) - f_661_11886_11915(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(661, 11799, 11931);

                    int
                    f_661_11855_11883(Microsoft.CodeAnalysis.GreenNode
                    this_param)
                    {
                        var return_v = this_param.GetLeadingTriviaWidth();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 11855, 11883);
                        return return_v;
                    }


                    int
                    f_661_11886_11915(Microsoft.CodeAnalysis.GreenNode
                    this_param)
                    {
                        var return_v = this_param.GetTrailingTriviaWidth();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 11886, 11915);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(661, 11750, 11942);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(661, 11750, 11942);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public virtual int GetLeadingTriviaWidth()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(661, 11954, 12148);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 12021, 12137);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(661, 12028, 12047) || ((f_661_12028_12042(this) != 0 && DynAbs.Tracing.TraceSender.Conditional_F2(661, 12067, 12115)) || DynAbs.Tracing.TraceSender.Conditional_F3(661, 12135, 12136))) ? f_661_12067_12115(f_661_12067_12090(this)!) : 0;
                DynAbs.Tracing.TraceSender.TraceExitMethod(661, 11954, 12148);

                int
                f_661_12028_12042(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.FullWidth;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(661, 12028, 12042);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode?
                f_661_12067_12090(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.GetFirstTerminal();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 12067, 12090);
                    return return_v;
                }


                int
                f_661_12067_12115(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.GetLeadingTriviaWidth();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 12067, 12115);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(661, 11954, 12148);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(661, 11954, 12148);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual int GetTrailingTriviaWidth()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(661, 12160, 12355);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 12228, 12344);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(661, 12235, 12254) || ((f_661_12235_12249(this) != 0 && DynAbs.Tracing.TraceSender.Conditional_F2(661, 12274, 12322)) || DynAbs.Tracing.TraceSender.Conditional_F3(661, 12342, 12343))) ? f_661_12274_12322(f_661_12274_12296(this)!) : 0;
                DynAbs.Tracing.TraceSender.TraceExitMethod(661, 12160, 12355);

                int
                f_661_12235_12249(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.FullWidth;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(661, 12235, 12249);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode?
                f_661_12274_12296(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.GetLastTerminal();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 12274, 12296);
                    return return_v;
                }


                int
                f_661_12274_12322(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.GetTrailingTriviaWidth();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 12274, 12322);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(661, 12160, 12355);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(661, 12160, 12355);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool HasLeadingTrivia
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(661, 12420, 12512);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 12456, 12497);

                    return f_661_12463_12491(this) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(661, 12420, 12512);

                    int
                    f_661_12463_12491(Microsoft.CodeAnalysis.GreenNode
                    this_param)
                    {
                        var return_v = this_param.GetLeadingTriviaWidth();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 12463, 12491);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(661, 12367, 12523);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(661, 12367, 12523);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool HasTrailingTrivia
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(661, 12589, 12682);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 12625, 12667);

                    return f_661_12632_12661(this) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(661, 12589, 12682);

                    int
                    f_661_12632_12661(Microsoft.CodeAnalysis.GreenNode
                    this_param)
                    {
                        var return_v = this_param.GetTrailingTriviaWidth();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 12632, 12661);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(661, 12535, 12693);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(661, 12535, 12693);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private const UInt16
        ExtendedSerializationInfoMask = unchecked((UInt16)(1u << 15))
        ;

        internal GreenNode(ObjectReader reader)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(661, 12925, 13829);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 957, 962);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 993, 998);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 1022, 1032);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 1055, 1065);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 12989, 13024);

                var
                kindBits = f_661_13004_13023(reader)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 13038, 13098);

                _kind = (ushort)(kindBits & ~ExtendedSerializationInfoMask);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 13114, 13818) || true) && ((kindBits & ExtendedSerializationInfoMask) != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(661, 13114, 13818);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 13199, 13254);

                    var
                    diagnostics = (DiagnosticInfo[])f_661_13235_13253(reader)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 13272, 13490) || true) && (diagnostics != null && (DynAbs.Tracing.TraceSender.Expression_True(661, 13276, 13321) && f_661_13299_13317(diagnostics) > 0))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(661, 13272, 13490);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 13363, 13407);

                        this.flags |= NodeFlags.ContainsDiagnostics;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 13429, 13471);

                        f_661_13429_13470(s_diagnosticsTable, this, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(661, 13272, 13490);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 13510, 13567);

                    var
                    annotations = (SyntaxAnnotation[])f_661_13548_13566(reader)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 13585, 13803) || true) && (annotations != null && (DynAbs.Tracing.TraceSender.Expression_True(661, 13589, 13634) && f_661_13612_13630(annotations) > 0))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(661, 13585, 13803);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 13676, 13720);

                        this.flags |= NodeFlags.ContainsAnnotations;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 13742, 13784);

                        f_661_13742_13783(s_annotationsTable, this, annotations);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(661, 13585, 13803);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(661, 13114, 13818);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(661, 12925, 13829);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(661, 12925, 13829);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(661, 12925, 13829);
            }
        }

        bool IObjectWritable.ShouldReuseInSerialization
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(661, 13889, 13918);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 13892, 13918);
                    return f_661_13892_13918(); DynAbs.Tracing.TraceSender.TraceExitMethod(661, 13889, 13918);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(661, 13889, 13918);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(661, 13889, 13918);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal virtual bool ShouldReuseInSerialization
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(661, 13980, 13999);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 13983, 13999);
                    return f_661_13983_13999(this); DynAbs.Tracing.TraceSender.TraceExitMethod(661, 13980, 13999);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(661, 13980, 13999);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(661, 13980, 13999);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        void IObjectWritable.WriteTo(ObjectWriter writer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(661, 14012, 14118);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 14086, 14107);

                f_661_14086_14106(this, writer);
                DynAbs.Tracing.TraceSender.TraceExitMethod(661, 14012, 14118);

                int
                f_661_14086_14106(Microsoft.CodeAnalysis.GreenNode
                this_param, Roslyn.Utilities.ObjectWriter
                writer)
                {
                    this_param.WriteTo(writer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 14086, 14106);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(661, 14012, 14118);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(661, 14012, 14118);
            }
        }

        internal virtual void WriteTo(ObjectWriter writer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(661, 14130, 14832);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 14205, 14234);

                var
                kindBits = (UInt16)_kind
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 14248, 14302);

                var
                hasDiagnostics = f_661_14269_14297(f_661_14269_14290(this)) > 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 14316, 14370);

                var
                hasAnnotations = f_661_14337_14365(f_661_14337_14358(this)) > 0
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 14386, 14821) || true) && (hasDiagnostics || (DynAbs.Tracing.TraceSender.Expression_False(661, 14390, 14422) || hasAnnotations))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(661, 14386, 14821);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 14456, 14498);

                    kindBits |= ExtendedSerializationInfoMask;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 14516, 14545);

                    f_661_14516_14544(writer, kindBits);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 14563, 14628);

                    f_661_14563_14627(writer, (DynAbs.Tracing.TraceSender.Conditional_F1(661, 14581, 14595) || ((hasDiagnostics && DynAbs.Tracing.TraceSender.Conditional_F2(661, 14598, 14619)) || DynAbs.Tracing.TraceSender.Conditional_F3(661, 14622, 14626))) ? f_661_14598_14619(this) : null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 14646, 14711);

                    f_661_14646_14710(writer, (DynAbs.Tracing.TraceSender.Conditional_F1(661, 14664, 14678) || ((hasAnnotations && DynAbs.Tracing.TraceSender.Conditional_F2(661, 14681, 14702)) || DynAbs.Tracing.TraceSender.Conditional_F3(661, 14705, 14709))) ? f_661_14681_14702(this) : null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(661, 14386, 14821);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(661, 14386, 14821);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 14777, 14806);

                    f_661_14777_14805(writer, kindBits);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(661, 14386, 14821);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(661, 14130, 14832);

                Microsoft.CodeAnalysis.DiagnosticInfo[]
                f_661_14269_14290(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.GetDiagnostics();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 14269, 14290);
                    return return_v;
                }


                int
                f_661_14269_14297(Microsoft.CodeAnalysis.DiagnosticInfo[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(661, 14269, 14297);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxAnnotation[]
                f_661_14337_14358(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.GetAnnotations();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 14337, 14358);
                    return return_v;
                }


                int
                f_661_14337_14365(Microsoft.CodeAnalysis.SyntaxAnnotation[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(661, 14337, 14365);
                    return return_v;
                }


                int
                f_661_14516_14544(Roslyn.Utilities.ObjectWriter
                this_param, ushort
                value)
                {
                    this_param.WriteUInt16(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 14516, 14544);
                    return 0;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo[]
                f_661_14598_14619(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.GetDiagnostics();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 14598, 14619);
                    return return_v;
                }


                int
                f_661_14563_14627(Roslyn.Utilities.ObjectWriter
                this_param, Microsoft.CodeAnalysis.DiagnosticInfo[]?
                value)
                {
                    this_param.WriteValue((object?)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 14563, 14627);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxAnnotation[]
                f_661_14681_14702(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.GetAnnotations();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 14681, 14702);
                    return return_v;
                }


                int
                f_661_14646_14710(Roslyn.Utilities.ObjectWriter
                this_param, Microsoft.CodeAnalysis.SyntaxAnnotation[]?
                value)
                {
                    this_param.WriteValue((object?)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 14646, 14710);
                    return 0;
                }


                int
                f_661_14777_14805(Roslyn.Utilities.ObjectWriter
                this_param, ushort
                value)
                {
                    this_param.WriteUInt16(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 14777, 14805);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(661, 14130, 14832);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(661, 14130, 14832);
            }
        }

        public bool HasAnnotations(string annotationKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(661, 14896, 15355);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 14970, 15010);

                var
                annotations = f_661_14988_15009(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 15024, 15120) || true) && (annotations == s_noAnnotations)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(661, 15024, 15120);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 15092, 15105);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(661, 15024, 15120);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 15136, 15315);
                    foreach (var a in f_661_15154_15165_I(annotations))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(661, 15136, 15315);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 15199, 15300) || true) && (f_661_15203_15209(a) == annotationKind)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(661, 15199, 15300);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 15269, 15281);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(661, 15199, 15300);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(661, 15136, 15315);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(661, 1, 180);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(661, 1, 180);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 15331, 15344);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(661, 14896, 15355);

                Microsoft.CodeAnalysis.SyntaxAnnotation[]
                f_661_14988_15009(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.GetAnnotations();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 14988, 15009);
                    return return_v;
                }


                string?
                f_661_15203_15209(Microsoft.CodeAnalysis.SyntaxAnnotation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(661, 15203, 15209);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxAnnotation[]
                f_661_15154_15165_I(Microsoft.CodeAnalysis.SyntaxAnnotation[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 15154, 15165);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(661, 14896, 15355);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(661, 14896, 15355);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool HasAnnotations(IEnumerable<string> annotationKinds)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(661, 15367, 15848);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 15455, 15495);

                var
                annotations = f_661_15473_15494(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 15509, 15605) || true) && (annotations == s_noAnnotations)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(661, 15509, 15605);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 15577, 15590);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(661, 15509, 15605);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 15621, 15808);
                    foreach (var a in f_661_15639_15650_I(annotations))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(661, 15621, 15808);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 15684, 15793) || true) && (f_661_15688_15720(annotationKinds, f_661_15713_15719(a)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(661, 15684, 15793);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 15762, 15774);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(661, 15684, 15793);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(661, 15621, 15808);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(661, 1, 188);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(661, 1, 188);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 15824, 15837);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(661, 15367, 15848);

                Microsoft.CodeAnalysis.SyntaxAnnotation[]
                f_661_15473_15494(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.GetAnnotations();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 15473, 15494);
                    return return_v;
                }


                string?
                f_661_15713_15719(Microsoft.CodeAnalysis.SyntaxAnnotation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(661, 15713, 15719);
                    return return_v;
                }


                bool
                f_661_15688_15720(System.Collections.Generic.IEnumerable<string>
                sequence, string?
                s)
                {
                    var return_v = sequence.Contains(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 15688, 15720);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxAnnotation[]
                f_661_15639_15650_I(Microsoft.CodeAnalysis.SyntaxAnnotation[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 15639, 15650);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(661, 15367, 15848);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(661, 15367, 15848);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool HasAnnotation([NotNullWhen(true)] SyntaxAnnotation? annotation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(661, 15860, 16336);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 15960, 16000);

                var
                annotations = f_661_15978_15999(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 16014, 16110) || true) && (annotations == s_noAnnotations)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(661, 16014, 16110);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 16082, 16095);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(661, 16014, 16110);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 16126, 16296);
                    foreach (var a in f_661_16144_16155_I(annotations))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(661, 16126, 16296);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 16189, 16281) || true) && (a == annotation)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(661, 16189, 16281);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 16250, 16262);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(661, 16189, 16281);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(661, 16126, 16296);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(661, 1, 171);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(661, 1, 171);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 16312, 16325);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(661, 15860, 16336);

                Microsoft.CodeAnalysis.SyntaxAnnotation[]
                f_661_15978_15999(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.GetAnnotations();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 15978, 15999);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxAnnotation[]
                f_661_16144_16155_I(Microsoft.CodeAnalysis.SyntaxAnnotation[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 16144, 16155);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(661, 15860, 16336);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(661, 15860, 16336);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public IEnumerable<SyntaxAnnotation> GetAnnotations(string annotationKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(661, 16348, 16867);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 16447, 16597) || true) && (f_661_16451_16492(annotationKind))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(661, 16447, 16597);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 16526, 16582);

                    throw f_661_16532_16581(nameof(annotationKind));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(661, 16447, 16597);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 16613, 16653);

                var
                annotations = f_661_16631_16652(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 16669, 16785) || true) && (annotations == s_noAnnotations)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(661, 16669, 16785);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 16737, 16770);

                    return s_noAnnotationsEnumerable;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(661, 16669, 16785);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 16801, 16856);

                return f_661_16808_16855(annotations, annotationKind);
                DynAbs.Tracing.TraceSender.TraceExitMethod(661, 16348, 16867);

                bool
                f_661_16451_16492(string
                value)
                {
                    var return_v = string.IsNullOrWhiteSpace(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 16451, 16492);
                    return return_v;
                }


                System.ArgumentNullException
                f_661_16532_16581(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 16532, 16581);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxAnnotation[]
                f_661_16631_16652(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.GetAnnotations();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 16631, 16652);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxAnnotation>
                f_661_16808_16855(Microsoft.CodeAnalysis.SyntaxAnnotation[]
                annotations, string
                annotationKind)
                {
                    var return_v = GetAnnotationsSlow(annotations, annotationKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 16808, 16855);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(661, 16348, 16867);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(661, 16348, 16867);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<SyntaxAnnotation> GetAnnotationsSlow(SyntaxAnnotation[] annotations, string annotationKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(661, 16879, 17242);

                var listYield = new List<SyntaxAnnotation>();
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 17022, 17231);
                    foreach (var annotation in f_661_17049_17060_I(annotations))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(661, 17022, 17231);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 17094, 17216) || true) && (f_661_17098_17113(annotation) == annotationKind)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(661, 17094, 17216);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 17173, 17197);

                            listYield.Add(annotation);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(661, 17094, 17216);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(661, 17022, 17231);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(661, 1, 210);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(661, 1, 210);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(661, 16879, 17242);

                return listYield;

                string?
                f_661_17098_17113(Microsoft.CodeAnalysis.SyntaxAnnotation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(661, 17098, 17113);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxAnnotation[]
                f_661_17049_17060_I(Microsoft.CodeAnalysis.SyntaxAnnotation[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 17049, 17060);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(661, 16879, 17242);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(661, 16879, 17242);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public IEnumerable<SyntaxAnnotation> GetAnnotations(IEnumerable<string> annotationKinds)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(661, 17254, 17771);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 17367, 17500) || true) && (annotationKinds == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(661, 17367, 17500);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 17428, 17485);

                    throw f_661_17434_17484(nameof(annotationKinds));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(661, 17367, 17500);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 17516, 17556);

                var
                annotations = f_661_17534_17555(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 17572, 17688) || true) && (annotations == s_noAnnotations)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(661, 17572, 17688);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 17640, 17673);

                    return s_noAnnotationsEnumerable;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(661, 17572, 17688);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 17704, 17760);

                return f_661_17711_17759(annotations, annotationKinds);
                DynAbs.Tracing.TraceSender.TraceExitMethod(661, 17254, 17771);

                System.ArgumentNullException
                f_661_17434_17484(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 17434, 17484);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxAnnotation[]
                f_661_17534_17555(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.GetAnnotations();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 17534, 17555);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxAnnotation>
                f_661_17711_17759(Microsoft.CodeAnalysis.SyntaxAnnotation[]
                annotations, System.Collections.Generic.IEnumerable<string>
                annotationKinds)
                {
                    var return_v = GetAnnotationsSlow(annotations, annotationKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 17711, 17759);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(661, 17254, 17771);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(661, 17254, 17771);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<SyntaxAnnotation> GetAnnotationsSlow(SyntaxAnnotation[] annotations, IEnumerable<string> annotationKinds)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(661, 17783, 18168);

                var listYield = new List<SyntaxAnnotation>();
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 17940, 18157);
                    foreach (var annotation in f_661_17967_17978_I(annotations))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(661, 17940, 18157);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 18012, 18142) || true) && (f_661_18016_18057(annotationKinds, f_661_18041_18056(annotation)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(661, 18012, 18142);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 18099, 18123);

                            listYield.Add(annotation);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(661, 18012, 18142);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(661, 17940, 18157);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(661, 1, 218);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(661, 1, 218);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(661, 17783, 18168);

                return listYield;

                string?
                f_661_18041_18056(Microsoft.CodeAnalysis.SyntaxAnnotation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(661, 18041, 18056);
                    return return_v;
                }


                bool
                f_661_18016_18057(System.Collections.Generic.IEnumerable<string>
                sequence, string?
                s)
                {
                    var return_v = sequence.Contains(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 18016, 18057);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxAnnotation[]
                f_661_17967_17978_I(Microsoft.CodeAnalysis.SyntaxAnnotation[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 17967, 17978);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(661, 17783, 18168);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(661, 17783, 18168);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SyntaxAnnotation[] GetAnnotations()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(661, 18180, 18698);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 18247, 18648) || true) && (f_661_18251_18275(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(661, 18247, 18648);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 18309, 18341);

                    SyntaxAnnotation[]?
                    annotations
                    = default(SyntaxAnnotation[]?);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 18359, 18633) || true) && (f_661_18363_18416(s_annotationsTable, this, out annotations))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(661, 18359, 18633);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 18458, 18573);

                        f_661_18458_18572(f_661_18490_18508(annotations) != 0, "we should return nonempty annotations or NoAnnotations");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 18595, 18614);

                        return annotations;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(661, 18359, 18633);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(661, 18247, 18648);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 18664, 18687);

                return s_noAnnotations;
                DynAbs.Tracing.TraceSender.TraceExitMethod(661, 18180, 18698);

                bool
                f_661_18251_18275(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.ContainsAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(661, 18251, 18275);
                    return return_v;
                }


                bool
                f_661_18363_18416(System.Runtime.CompilerServices.ConditionalWeakTable<Microsoft.CodeAnalysis.GreenNode, Microsoft.CodeAnalysis.SyntaxAnnotation[]>
                this_param, Microsoft.CodeAnalysis.GreenNode
                key, out Microsoft.CodeAnalysis.SyntaxAnnotation[]?
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 18363, 18416);
                    return return_v;
                }


                int
                f_661_18490_18508(Microsoft.CodeAnalysis.SyntaxAnnotation[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(661, 18490, 18508);
                    return return_v;
                }


                int
                f_661_18458_18572(bool
                condition, string
                message)
                {
                    System.Diagnostics.Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 18458, 18572);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(661, 18180, 18698);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(661, 18180, 18698);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal abstract GreenNode SetAnnotations(SyntaxAnnotation[]? annotations);

        internal DiagnosticInfo[] GetDiagnostics()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(661, 18849, 19210);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 18916, 19160) || true) && (f_661_18920_18944(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(661, 18916, 19160);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 18978, 19002);

                    DiagnosticInfo[]?
                    diags
                    = default(DiagnosticInfo[]?);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 19020, 19145) || true) && (f_661_19024_19071(s_diagnosticsTable, this, out diags))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(661, 19020, 19145);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 19113, 19126);

                        return diags;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(661, 19020, 19145);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(661, 18916, 19160);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 19176, 19199);

                return s_noDiagnostics;
                DynAbs.Tracing.TraceSender.TraceExitMethod(661, 18849, 19210);

                bool
                f_661_18920_18944(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.ContainsDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(661, 18920, 18944);
                    return return_v;
                }


                bool
                f_661_19024_19071(System.Runtime.CompilerServices.ConditionalWeakTable<Microsoft.CodeAnalysis.GreenNode, Microsoft.CodeAnalysis.DiagnosticInfo[]>
                this_param, Microsoft.CodeAnalysis.GreenNode
                key, out Microsoft.CodeAnalysis.DiagnosticInfo[]?
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 19024, 19071);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(661, 18849, 19210);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(661, 18849, 19210);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal abstract GreenNode SetDiagnostics(DiagnosticInfo[]? diagnostics);

        public virtual string ToFullString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(661, 19352, 19692);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 19413, 19456);

                var
                sb = f_661_19422_19455()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 19470, 19573);

                var
                writer = f_661_19483_19572(sb.Builder, f_661_19522_19571())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 19587, 19639);

                f_661_19587_19638(this, writer, leading: true, trailing: true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 19653, 19681);

                return f_661_19660_19680(sb);
                DynAbs.Tracing.TraceSender.TraceExitMethod(661, 19352, 19692);

                Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                f_661_19422_19455()
                {
                    var return_v = PooledStringBuilder.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 19422, 19455);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_661_19522_19571()
                {
                    var return_v = System.Globalization.CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(661, 19522, 19571);
                    return return_v;
                }


                System.IO.StringWriter
                f_661_19483_19572(System.Text.StringBuilder
                sb, System.Globalization.CultureInfo
                formatProvider)
                {
                    var return_v = new System.IO.StringWriter(sb, (System.IFormatProvider)formatProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 19483, 19572);
                    return return_v;
                }


                int
                f_661_19587_19638(Microsoft.CodeAnalysis.GreenNode
                this_param, System.IO.StringWriter
                writer, bool
                leading, bool
                trailing)
                {
                    this_param.WriteTo((System.IO.TextWriter)writer, leading: leading, trailing: trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 19587, 19638);
                    return 0;
                }


                string
                f_661_19660_19680(Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                this_param)
                {
                    var return_v = this_param.ToStringAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 19660, 19680);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(661, 19352, 19692);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(661, 19352, 19692);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(661, 19704, 20043);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 19762, 19805);

                var
                sb = f_661_19771_19804()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 19819, 19922);

                var
                writer = f_661_19832_19921(sb.Builder, f_661_19871_19920())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 19936, 19990);

                f_661_19936_19989(this, writer, leading: false, trailing: false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 20004, 20032);

                return f_661_20011_20031(sb);
                DynAbs.Tracing.TraceSender.TraceExitMethod(661, 19704, 20043);

                Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                f_661_19771_19804()
                {
                    var return_v = PooledStringBuilder.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 19771, 19804);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_661_19871_19920()
                {
                    var return_v = System.Globalization.CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(661, 19871, 19920);
                    return return_v;
                }


                System.IO.StringWriter
                f_661_19832_19921(System.Text.StringBuilder
                sb, System.Globalization.CultureInfo
                formatProvider)
                {
                    var return_v = new System.IO.StringWriter(sb, (System.IFormatProvider)formatProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 19832, 19921);
                    return return_v;
                }


                int
                f_661_19936_19989(Microsoft.CodeAnalysis.GreenNode
                this_param, System.IO.StringWriter
                writer, bool
                leading, bool
                trailing)
                {
                    this_param.WriteTo((System.IO.TextWriter)writer, leading: leading, trailing: trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 19936, 19989);
                    return 0;
                }


                string
                f_661_20011_20031(Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                this_param)
                {
                    var return_v = this_param.ToStringAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 20011, 20031);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(661, 19704, 20043);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(661, 19704, 20043);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void WriteTo(System.IO.TextWriter writer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(661, 20055, 20191);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 20128, 20180);

                f_661_20128_20179(this, writer, leading: true, trailing: true);
                DynAbs.Tracing.TraceSender.TraceExitMethod(661, 20055, 20191);

                int
                f_661_20128_20179(Microsoft.CodeAnalysis.GreenNode
                this_param, System.IO.TextWriter
                writer, bool
                leading, bool
                trailing)
                {
                    this_param.WriteTo(writer, leading: leading, trailing: trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 20128, 20179);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(661, 20055, 20191);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(661, 20055, 20191);
            }
        }

        protected internal void WriteTo(TextWriter writer, bool leading, bool trailing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(661, 20203, 22347);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 20412, 20498);

                var
                stack = f_661_20424_20497()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 20512, 20550);

                // LAFHIS
                stack.Push((this, leading, trailing));
                DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 20512, 20549);

                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 20714, 20742);

                f_661_20714_20741(writer, stack);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 20756, 20769);

                f_661_20756_20768(stack);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 20783, 20790);

                return;

                static void processStack(
                                TextWriter writer,
                                ArrayBuilder<(GreenNode node, bool leading, bool trailing)> stack)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(661, 20806, 22336);
                        try
                        {
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 20984, 22321) || true) && (f_661_20991_21002(stack) > 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(661, 20984, 22321);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 21048, 21074);

                                var
                                current = f_661_21062_21073(stack)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 21096, 21127);

                                var
                                currentNode = current.node
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 21149, 21186);

                                var
                                currentLeading = current.leading
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 21208, 21247);

                                var
                                currentTrailing = current.trailing
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 21271, 21468) || true) && (f_661_21275_21294(currentNode))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(661, 21271, 21468);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 21344, 21410);

                                    f_661_21344_21409(currentNode, writer, currentLeading, currentTrailing);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 21436, 21445);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(661, 21271, 21468);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 21492, 21658) || true) && (f_661_21496_21516(currentNode))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(661, 21492, 21658);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 21566, 21600);

                                    f_661_21566_21599(currentNode, writer);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 21626, 21635);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(661, 21492, 21658);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 21682, 21738);

                                var
                                firstIndex = f_661_21699_21737(currentNode)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 21760, 21814);

                                var
                                lastIndex = f_661_21776_21813(currentNode)
                                ;
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 21847, 21860);

                                    for (var
                i = lastIndex
                ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 21838, 22302) || true) && (i >= firstIndex)
                ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 21879, 21882)
                , i--, DynAbs.Tracing.TraceSender.TraceExitCondition(661, 21838, 22302))

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(661, 21838, 22302);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 21932, 21967);

                                        var
                                        child = f_661_21944_21966(currentNode, i)
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 21993, 22279) || true) && (child != null)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(661, 21993, 22279);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 22068, 22096);

                                            var
                                            first = i == firstIndex
                                            ;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 22126, 22152);

                                            var
                                            last = i == lastIndex
                                            ;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 22182, 22252);

                                            // LAFHIS
                                            stack.Push((child, currentLeading | !first, currentTrailing | !last));
                                            DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 22182, 22251);

                                            DynAbs.Tracing.TraceSender.TraceExitCondition(661, 21993, 22279);
                                        }
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(661, 1, 465);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(661, 1, 465);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(661, 20984, 22321);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(661, 20984, 22321);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(661, 20984, 22321);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitStaticMethod(661, 20806, 22336);

                        int
                        f_661_20991_21002(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.GreenNode node, bool leading, bool trailing)>
                        this_param)
                        {
                            var return_v = this_param.Count;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(661, 20991, 21002);
                            return return_v;
                        }


                        (Microsoft.CodeAnalysis.GreenNode node, bool leading, bool trailing)
                        f_661_21062_21073(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.GreenNode node, bool leading, bool trailing)>
                        builder)
                        {
                            var return_v = builder.Pop<(Microsoft.CodeAnalysis.GreenNode node, bool leading, bool trailing)>();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 21062, 21073);
                            return return_v;
                        }


                        bool
                        f_661_21275_21294(Microsoft.CodeAnalysis.GreenNode
                        this_param)
                        {
                            var return_v = this_param.IsToken;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(661, 21275, 21294);
                            return return_v;
                        }


                        int
                        f_661_21344_21409(Microsoft.CodeAnalysis.GreenNode
                        this_param, System.IO.TextWriter
                        writer, bool
                        leading, bool
                        trailing)
                        {
                            this_param.WriteTokenTo(writer, leading, trailing);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 21344, 21409);
                            return 0;
                        }


                        bool
                        f_661_21496_21516(Microsoft.CodeAnalysis.GreenNode
                        this_param)
                        {
                            var return_v = this_param.IsTrivia;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(661, 21496, 21516);
                            return return_v;
                        }


                        int
                        f_661_21566_21599(Microsoft.CodeAnalysis.GreenNode
                        this_param, System.IO.TextWriter
                        writer)
                        {
                            this_param.WriteTriviaTo(writer);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 21566, 21599);
                            return 0;
                        }


                        int
                        f_661_21699_21737(Microsoft.CodeAnalysis.GreenNode
                        node)
                        {
                            var return_v = GetFirstNonNullChildIndex(node);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 21699, 21737);
                            return return_v;
                        }


                        int
                        f_661_21776_21813(Microsoft.CodeAnalysis.GreenNode
                        node)
                        {
                            var return_v = GetLastNonNullChildIndex(node);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 21776, 21813);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.GreenNode?
                        f_661_21944_21966(Microsoft.CodeAnalysis.GreenNode
                        this_param, int
                        index)
                        {
                            var return_v = this_param.GetSlot(index);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 21944, 21966);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(661, 20806, 22336);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(661, 20806, 22336);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(661, 20203, 22347);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.GreenNode node, bool leading, bool trailing)>
                f_661_20424_20497()
                {
                    var return_v = ArrayBuilder<(GreenNode node, bool leading, bool trailing)>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 20424, 20497);
                    return return_v;
                }


                int
                f_661_20714_20741(System.IO.TextWriter
                writer, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.GreenNode node, bool leading, bool trailing)>
                stack)
                {
                    processStack(writer, stack);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 20714, 20741);
                    return 0;
                }


                int
                f_661_20756_20768(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.GreenNode node, bool leading, bool trailing)>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 20756, 20768);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(661, 20203, 22347);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(661, 20203, 22347);
            }
        }

        private static int GetFirstNonNullChildIndex(GreenNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(661, 22359, 22782);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 22444, 22467);

                int
                n = f_661_22452_22466(node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 22481, 22500);

                int
                firstIndex = 0
                ;
                try
                {
                    for (; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 22514, 22737) || true) && (firstIndex < n)
   ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 22537, 22549)
   , firstIndex++, DynAbs.Tracing.TraceSender.TraceExitCondition(661, 22514, 22737))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(661, 22514, 22737);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 22583, 22620);

                        var
                        child = f_661_22595_22619(node, firstIndex)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 22638, 22722) || true) && (child != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(661, 22638, 22722);
                            DynAbs.Tracing.TraceSender.TraceBreak(661, 22697, 22703);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(661, 22638, 22722);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(661, 1, 224);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(661, 1, 224);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 22753, 22771);

                return firstIndex;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(661, 22359, 22782);

                int
                f_661_22452_22466(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.SlotCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(661, 22452, 22466);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode?
                f_661_22595_22619(Microsoft.CodeAnalysis.GreenNode
                this_param, int
                index)
                {
                    var return_v = this_param.GetSlot(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 22595, 22619);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(661, 22359, 22782);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(661, 22359, 22782);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static int GetLastNonNullChildIndex(GreenNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(661, 22794, 23216);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 22878, 22901);

                int
                n = f_661_22886_22900(node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 22915, 22937);

                int
                lastIndex = n - 1
                ;
                try
                {
                    for (; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 22951, 23172) || true) && (lastIndex >= 0)
   ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 22974, 22985)
   , lastIndex--, DynAbs.Tracing.TraceSender.TraceExitCondition(661, 22951, 23172))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(661, 22951, 23172);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 23019, 23055);

                        var
                        child = f_661_23031_23054(node, lastIndex)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 23073, 23157) || true) && (child != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(661, 23073, 23157);
                            DynAbs.Tracing.TraceSender.TraceBreak(661, 23132, 23138);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(661, 23073, 23157);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(661, 1, 222);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(661, 1, 222);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 23188, 23205);

                return lastIndex;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(661, 22794, 23216);

                int
                f_661_22886_22900(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.SlotCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(661, 22886, 22900);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode?
                f_661_23031_23054(Microsoft.CodeAnalysis.GreenNode
                this_param, int
                index)
                {
                    var return_v = this_param.GetSlot(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 23031, 23054);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(661, 22794, 23216);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(661, 22794, 23216);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected virtual void WriteTriviaTo(TextWriter writer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(661, 23228, 23355);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 23308, 23344);

                throw f_661_23314_23343();
                DynAbs.Tracing.TraceSender.TraceExitMethod(661, 23228, 23355);

                System.NotImplementedException
                f_661_23314_23343()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 23314, 23343);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(661, 23228, 23355);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(661, 23228, 23355);
            }
        }

        protected virtual void WriteTokenTo(TextWriter writer, bool leading, bool trailing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(661, 23367, 23522);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 23475, 23511);

                throw f_661_23481_23510();
                DynAbs.Tracing.TraceSender.TraceExitMethod(661, 23367, 23522);

                System.NotImplementedException
                f_661_23481_23510()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 23481, 23510);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(661, 23367, 23522);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(661, 23367, 23522);
            }
        }

        public virtual int RawContextualKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(661, 23622, 23650);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 23628, 23648);

                    return f_661_23635_23647(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(661, 23622, 23650);

                    int
                    f_661_23635_23647(Microsoft.CodeAnalysis.GreenNode
                    this_param)
                    {
                        var return_v = this_param.RawKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(661, 23635, 23647);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(661, 23583, 23652);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(661, 23583, 23652);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public virtual object? GetValue()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(661, 23662, 23712);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 23698, 23710);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(661, 23662, 23712);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(661, 23662, 23712);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(661, 23662, 23712);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual string GetValueText()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(661, 23722, 23783);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 23761, 23781);

                return string.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(661, 23722, 23783);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(661, 23722, 23783);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(661, 23722, 23783);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual GreenNode? GetLeadingTriviaCore()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(661, 23793, 23858);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 23844, 23856);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(661, 23793, 23858);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(661, 23793, 23858);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(661, 23793, 23858);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual GreenNode? GetTrailingTriviaCore()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(661, 23868, 23934);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 23920, 23932);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(661, 23868, 23934);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(661, 23868, 23934);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(661, 23868, 23934);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual GreenNode WithLeadingTrivia(GreenNode? trivia)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(661, 23946, 24055);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 24032, 24044);

                return this;
                DynAbs.Tracing.TraceSender.TraceExitMethod(661, 23946, 24055);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(661, 23946, 24055);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(661, 23946, 24055);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual GreenNode WithTrailingTrivia(GreenNode? trivia)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(661, 24067, 24177);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 24154, 24166);

                return this;
                DynAbs.Tracing.TraceSender.TraceExitMethod(661, 24067, 24177);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(661, 24067, 24177);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(661, 24067, 24177);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal GreenNode? GetFirstTerminal()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(661, 24189, 24791);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 24252, 24275);

                GreenNode?
                node = this
                ;
                {
                    try
                    {
                        do

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(661, 24291, 24752);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 24326, 24355);

                            GreenNode?
                            firstChild = null
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 24382, 24387);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 24389, 24407);
                                for (int
                i = 0
                ,
                n = f_661_24393_24407(node)
                ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 24373, 24671) || true) && (i < n)
                ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 24416, 24419)
                , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(661, 24373, 24671))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(661, 24373, 24671);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 24461, 24489);

                                    var
                                    child = f_661_24473_24488(node, i)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 24511, 24652) || true) && (child != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(661, 24511, 24652);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 24578, 24597);

                                        firstChild = child;
                                        DynAbs.Tracing.TraceSender.TraceBreak(661, 24623, 24629);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(661, 24511, 24652);
                                    }
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(661, 1, 299);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(661, 1, 299);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 24689, 24707);

                            node = firstChild;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(661, 24291, 24752);
                        }
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 24291, 24752) || true) && (DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(node, 661, 24730, 24746)?._slotCount > 0)
                        );
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(661, 24291, 24752);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(661, 24291, 24752);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 24768, 24780);

                return node;
                DynAbs.Tracing.TraceSender.TraceExitMethod(661, 24189, 24791);

                int
                f_661_24393_24407(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.SlotCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(661, 24393, 24407);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode?
                f_661_24473_24488(Microsoft.CodeAnalysis.GreenNode
                this_param, int
                index)
                {
                    var return_v = this_param.GetSlot(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 24473, 24488);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(661, 24189, 24791);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(661, 24189, 24791);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal GreenNode? GetLastTerminal()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(661, 24803, 25399);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 24865, 24888);

                GreenNode?
                node = this
                ;
                {
                    try
                    {
                        do

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(661, 24904, 25360);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 24939, 24967);

                            GreenNode?
                            lastChild = null
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 24994, 25016);
                                for (int
                i = f_661_24998_25012(node) - 1
                ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 24985, 25280) || true) && (i >= 0)
                ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 25026, 25029)
                , i--, DynAbs.Tracing.TraceSender.TraceExitCondition(661, 24985, 25280))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(661, 24985, 25280);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 25071, 25099);

                                    var
                                    child = f_661_25083_25098(node, i)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 25121, 25261) || true) && (child != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(661, 25121, 25261);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 25188, 25206);

                                        lastChild = child;
                                        DynAbs.Tracing.TraceSender.TraceBreak(661, 25232, 25238);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(661, 25121, 25261);
                                    }
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(661, 1, 296);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(661, 1, 296);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 25298, 25315);

                            node = lastChild;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(661, 24904, 25360);
                        }
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 24904, 25360) || true) && (DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(node, 661, 25338, 25354)?._slotCount > 0)
                        );
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(661, 24904, 25360);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(661, 24904, 25360);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 25376, 25388);

                return node;
                DynAbs.Tracing.TraceSender.TraceExitMethod(661, 24803, 25399);

                int
                f_661_24998_25012(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.SlotCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(661, 24998, 25012);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode?
                f_661_25083_25098(Microsoft.CodeAnalysis.GreenNode
                this_param, int
                index)
                {
                    var return_v = this_param.GetSlot(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 25083, 25098);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(661, 24803, 25399);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(661, 24803, 25399);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal GreenNode? GetLastNonmissingTerminal()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(661, 25411, 26068);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 25483, 25506);

                GreenNode?
                node = this
                ;
                {
                    try
                    {
                        do

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(661, 25522, 26029);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 25557, 25591);

                            GreenNode?
                            nonmissingChild = null
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 25618, 25640);
                                for (int
                i = f_661_25622_25636(node) - 1
                ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 25609, 25930) || true) && (i >= 0)
                ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 25650, 25653)
                , i--, DynAbs.Tracing.TraceSender.TraceExitCondition(661, 25609, 25930))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(661, 25609, 25930);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 25695, 25723);

                                    var
                                    child = f_661_25707_25722(node, i)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 25745, 25911) || true) && (child != null && (DynAbs.Tracing.TraceSender.Expression_True(661, 25749, 25782) && f_661_25766_25782_M(!child.IsMissing)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(661, 25745, 25911);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 25832, 25856);

                                        nonmissingChild = child;
                                        DynAbs.Tracing.TraceSender.TraceBreak(661, 25882, 25888);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(661, 25745, 25911);
                                    }
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(661, 1, 322);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(661, 1, 322);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 25948, 25971);

                            node = nonmissingChild;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(661, 25522, 26029);
                        }
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 25522, 26029) || true) && (DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(node, 661, 26007, 26023)?._slotCount > 0)
                        );
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(661, 25522, 26029);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(661, 25522, 26029);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 26045, 26057);

                return node;
                DynAbs.Tracing.TraceSender.TraceExitMethod(661, 25411, 26068);

                int
                f_661_25622_25636(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.SlotCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(661, 25622, 25636);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode?
                f_661_25707_25722(Microsoft.CodeAnalysis.GreenNode
                this_param, int
                index)
                {
                    var return_v = this_param.GetSlot(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 25707, 25722);
                    return return_v;
                }


                bool
                f_661_25766_25782_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(661, 25766, 25782);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(661, 25411, 26068);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(661, 25411, 26068);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual bool IsEquivalentTo([NotNullWhen(true)] GreenNode? other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(661, 26130, 26468);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 26227, 26305) || true) && (this == other)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(661, 26227, 26305);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 26278, 26290);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(661, 26227, 26305);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 26321, 26400) || true) && (other == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(661, 26321, 26400);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 26372, 26385);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(661, 26321, 26400);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 26416, 26457);

                return f_661_26423_26456(this, other);
                DynAbs.Tracing.TraceSender.TraceExitMethod(661, 26130, 26468);

                bool
                f_661_26423_26456(Microsoft.CodeAnalysis.GreenNode
                node1, Microsoft.CodeAnalysis.GreenNode
                node2)
                {
                    var return_v = EquivalentToInternal(node1, node2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 26423, 26456);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(661, 26130, 26468);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(661, 26130, 26468);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool EquivalentToInternal(GreenNode node1, GreenNode node2)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(661, 26480, 27945);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 26579, 27293) || true) && (f_661_26583_26596(node1) != f_661_26600_26613(node2))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(661, 26579, 27293);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 26862, 26996) || true) && (f_661_26866_26878(node1) && (DynAbs.Tracing.TraceSender.Expression_True(661, 26866, 26902) && f_661_26882_26897(node1) == 1))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(661, 26862, 26996);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 26944, 26977);

                        node1 = f_661_26952_26976(node1, 0);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(661, 26862, 26996);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 27016, 27150) || true) && (f_661_27020_27032(node2) && (DynAbs.Tracing.TraceSender.Expression_True(661, 27020, 27056) && f_661_27036_27051(node2) == 1))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(661, 27016, 27150);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 27098, 27131);

                        node2 = f_661_27106_27130(node2, 0);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(661, 27016, 27150);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 27170, 27278) || true) && (f_661_27174_27187(node1) != f_661_27191_27204(node2))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(661, 27170, 27278);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 27246, 27259);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(661, 27170, 27278);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(661, 26579, 27293);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 27309, 27411) || true) && (node1._fullWidth != node2._fullWidth)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(661, 27309, 27411);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 27383, 27396);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(661, 27309, 27411);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 27427, 27451);

                var
                n = f_661_27435_27450(node1)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 27465, 27551) || true) && (n != f_661_27474_27489(node2))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(661, 27465, 27551);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 27523, 27536);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(661, 27465, 27551);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 27576, 27581);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 27567, 27906) || true) && (i < n)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 27590, 27593)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(661, 27567, 27906))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(661, 27567, 27906);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 27627, 27661);

                        var
                        node1Child = f_661_27644_27660(node1, i)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 27679, 27713);

                        var
                        node2Child = f_661_27696_27712(node2, i)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 27731, 27891) || true) && (node1Child != null && (DynAbs.Tracing.TraceSender.Expression_True(661, 27735, 27775) && node2Child != null) && (DynAbs.Tracing.TraceSender.Expression_True(661, 27735, 27817) && !f_661_27780_27817(node1Child, node2Child)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(661, 27731, 27891);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 27859, 27872);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(661, 27731, 27891);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(661, 1, 340);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(661, 1, 340);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 27922, 27934);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(661, 26480, 27945);

                int
                f_661_26583_26596(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.RawKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(661, 26583, 26596);
                    return return_v;
                }


                int
                f_661_26600_26613(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.RawKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(661, 26600, 26613);
                    return return_v;
                }


                bool
                f_661_26866_26878(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.IsList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(661, 26866, 26878);
                    return return_v;
                }


                int
                f_661_26882_26897(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.SlotCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(661, 26882, 26897);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode
                f_661_26952_26976(Microsoft.CodeAnalysis.GreenNode
                this_param, int
                index)
                {
                    var return_v = this_param.GetRequiredSlot(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 26952, 26976);
                    return return_v;
                }


                bool
                f_661_27020_27032(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.IsList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(661, 27020, 27032);
                    return return_v;
                }


                int
                f_661_27036_27051(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.SlotCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(661, 27036, 27051);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode
                f_661_27106_27130(Microsoft.CodeAnalysis.GreenNode
                this_param, int
                index)
                {
                    var return_v = this_param.GetRequiredSlot(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 27106, 27130);
                    return return_v;
                }


                int
                f_661_27174_27187(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.RawKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(661, 27174, 27187);
                    return return_v;
                }


                int
                f_661_27191_27204(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.RawKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(661, 27191, 27204);
                    return return_v;
                }


                int
                f_661_27435_27450(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.SlotCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(661, 27435, 27450);
                    return return_v;
                }


                int
                f_661_27474_27489(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.SlotCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(661, 27474, 27489);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode?
                f_661_27644_27660(Microsoft.CodeAnalysis.GreenNode
                this_param, int
                index)
                {
                    var return_v = this_param.GetSlot(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 27644, 27660);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode?
                f_661_27696_27712(Microsoft.CodeAnalysis.GreenNode
                this_param, int
                index)
                {
                    var return_v = this_param.GetSlot(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 27696, 27712);
                    return return_v;
                }


                bool
                f_661_27780_27817(Microsoft.CodeAnalysis.GreenNode
                this_param, Microsoft.CodeAnalysis.GreenNode
                other)
                {
                    var return_v = this_param.IsEquivalentTo(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 27780, 27817);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(661, 26480, 27945);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(661, 26480, 27945);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public abstract SyntaxNode GetStructure(SyntaxTrivia parentTrivia);

        public abstract SyntaxToken CreateSeparator<TNode>(SyntaxNode element) where TNode : SyntaxNode;

        public abstract bool IsTriviaWithEndOfLine();

        public static GreenNode? CreateList<TFrom>(IEnumerable<TFrom>? enumerable, Func<TFrom, GreenNode> select)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(661, 28941, 29207);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 28944, 29207);
                return enumerable switch
                {
                    null when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 28994, 29006) && DynAbs.Tracing.TraceSender.Expression_True(661, 28994, 29006))
    => null,
                    List<TFrom> l when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 29025, 29063) && DynAbs.Tracing.TraceSender.Expression_True(661, 29025, 29063))
    => f_661_29042_29063(l, select),
                    IReadOnlyList<TFrom> l when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 29082, 29129) && DynAbs.Tracing.TraceSender.Expression_True(661, 29082, 29129))
    => f_661_29108_29129(l, select),
                    _ when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 29148, 29192) && DynAbs.Tracing.TraceSender.Expression_True(661, 29148, 29192))
    => f_661_29153_29192(f_661_29164_29183(enumerable), select)
                }; DynAbs.Tracing.TraceSender.TraceExitMethod(661, 28941, 29207);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(661, 28941, 29207);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(661, 28941, 29207);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.GreenNode?
            f_661_29042_29063(System.Collections.Generic.List<TFrom>
            list, System.Func<TFrom, Microsoft.CodeAnalysis.GreenNode>
            select)
            {
                var return_v = CreateList(list, select);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 29042, 29063);
                return return_v;
            }


            Microsoft.CodeAnalysis.GreenNode?
            f_661_29108_29129(System.Collections.Generic.IReadOnlyList<TFrom>
            list, System.Func<TFrom, Microsoft.CodeAnalysis.GreenNode>
            select)
            {
                var return_v = CreateList(list, select);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 29108, 29129);
                return return_v;
            }


            System.Collections.Generic.List<TFrom>
            f_661_29164_29183(System.Collections.Generic.IEnumerable<TFrom>
            source)
            {
                var return_v = source.ToList<TFrom>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 29164, 29183);
                return return_v;
            }


            Microsoft.CodeAnalysis.GreenNode?
            f_661_29153_29192(System.Collections.Generic.List<TFrom>
            list, System.Func<TFrom, Microsoft.CodeAnalysis.GreenNode>
            select)
            {
                var return_v = CreateList(list, select);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 29153, 29192);
                return return_v;
            }

        }

        public static GreenNode? CreateList<TFrom>(List<TFrom> list, Func<TFrom, GreenNode> select)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(661, 29220, 30083);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 29336, 30072);

                switch (f_661_29344_29354(list))
                {

                    case 0:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(661, 29336, 30072);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 29417, 29429);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(661, 29336, 30072);

                    case 1:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(661, 29336, 30072);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 29476, 29499);

                        return f_661_29483_29498(select, f_661_29490_29497(list, 0));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(661, 29336, 30072);

                    case 2:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(661, 29336, 30072);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 29546, 29603);

                        return f_661_29553_29602(f_661_29569_29584(select, f_661_29576_29583(list, 0)), f_661_29586_29601(select, f_661_29593_29600(list, 1)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(661, 29336, 30072);

                    case 3:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(661, 29336, 30072);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 29650, 29724);

                        return f_661_29657_29723(f_661_29673_29688(select, f_661_29680_29687(list, 0)), f_661_29690_29705(select, f_661_29697_29704(list, 1)), f_661_29707_29722(select, f_661_29714_29721(list, 2)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(661, 29336, 30072);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(661, 29336, 30072);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 29799, 29851);

                            var
                            array = new ArrayElement<GreenNode>[f_661_29839_29849(list)]
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 29886, 29891);
                                for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 29877, 29978) || true) && (i < f_661_29897_29909(array))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 29911, 29914)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(661, 29877, 29978))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(661, 29877, 29978);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 29945, 29978);

                                    array[i].Value = f_661_29962_29977(select, f_661_29969_29976(list, i));
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(661, 1, 102);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(661, 1, 102);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 30004, 30034);

                            return f_661_30011_30033(array);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(661, 29336, 30072);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(661, 29220, 30083);

                int
                f_661_29344_29354(System.Collections.Generic.List<TFrom>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(661, 29344, 29354);
                    return return_v;
                }


                TFrom?
                f_661_29490_29497(System.Collections.Generic.List<TFrom>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(661, 29490, 29497);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode
                f_661_29483_29498(System.Func<TFrom, Microsoft.CodeAnalysis.GreenNode>
                this_param, TFrom?
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 29483, 29498);
                    return return_v;
                }


                TFrom?
                f_661_29576_29583(System.Collections.Generic.List<TFrom>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(661, 29576, 29583);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode
                f_661_29569_29584(System.Func<TFrom, Microsoft.CodeAnalysis.GreenNode>
                this_param, TFrom?
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 29569, 29584);
                    return return_v;
                }


                TFrom?
                f_661_29593_29600(System.Collections.Generic.List<TFrom>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(661, 29593, 29600);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode
                f_661_29586_29601(System.Func<TFrom, Microsoft.CodeAnalysis.GreenNode>
                this_param, TFrom?
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 29586, 29601);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList.WithTwoChildren
                f_661_29553_29602(Microsoft.CodeAnalysis.GreenNode
                child0, Microsoft.CodeAnalysis.GreenNode
                child1)
                {
                    var return_v = SyntaxList.List(child0, child1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 29553, 29602);
                    return return_v;
                }


                TFrom?
                f_661_29680_29687(System.Collections.Generic.List<TFrom>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(661, 29680, 29687);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode
                f_661_29673_29688(System.Func<TFrom, Microsoft.CodeAnalysis.GreenNode>
                this_param, TFrom?
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 29673, 29688);
                    return return_v;
                }


                TFrom?
                f_661_29697_29704(System.Collections.Generic.List<TFrom>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(661, 29697, 29704);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode
                f_661_29690_29705(System.Func<TFrom, Microsoft.CodeAnalysis.GreenNode>
                this_param, TFrom?
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 29690, 29705);
                    return return_v;
                }


                TFrom?
                f_661_29714_29721(System.Collections.Generic.List<TFrom>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(661, 29714, 29721);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode
                f_661_29707_29722(System.Func<TFrom, Microsoft.CodeAnalysis.GreenNode>
                this_param, TFrom?
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 29707, 29722);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList.WithThreeChildren
                f_661_29657_29723(Microsoft.CodeAnalysis.GreenNode
                child0, Microsoft.CodeAnalysis.GreenNode
                child1, Microsoft.CodeAnalysis.GreenNode
                child2)
                {
                    var return_v = SyntaxList.List(child0, child1, child2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 29657, 29723);
                    return return_v;
                }


                int
                f_661_29839_29849(System.Collections.Generic.List<TFrom>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(661, 29839, 29849);
                    return return_v;
                }


                int
                f_661_29897_29909(Microsoft.CodeAnalysis.ArrayElement<Microsoft.CodeAnalysis.GreenNode>[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(661, 29897, 29909);
                    return return_v;
                }


                TFrom?
                f_661_29969_29976(System.Collections.Generic.List<TFrom>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(661, 29969, 29976);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode
                f_661_29962_29977(System.Func<TFrom, Microsoft.CodeAnalysis.GreenNode>
                this_param, TFrom?
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 29962, 29977);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList
                f_661_30011_30033(Microsoft.CodeAnalysis.ArrayElement<Microsoft.CodeAnalysis.GreenNode>[]
                children)
                {
                    var return_v = SyntaxList.List(children);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 30011, 30033);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(661, 29220, 30083);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(661, 29220, 30083);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static GreenNode? CreateList<TFrom>(IReadOnlyList<TFrom> list, Func<TFrom, GreenNode> select)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(661, 30095, 30967);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 30220, 30956);

                switch (f_661_30228_30238(list))
                {

                    case 0:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(661, 30220, 30956);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 30301, 30313);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(661, 30220, 30956);

                    case 1:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(661, 30220, 30956);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 30360, 30383);

                        return f_661_30367_30382(select, f_661_30374_30381(list, 0));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(661, 30220, 30956);

                    case 2:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(661, 30220, 30956);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 30430, 30487);

                        return f_661_30437_30486(f_661_30453_30468(select, f_661_30460_30467(list, 0)), f_661_30470_30485(select, f_661_30477_30484(list, 1)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(661, 30220, 30956);

                    case 3:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(661, 30220, 30956);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 30534, 30608);

                        return f_661_30541_30607(f_661_30557_30572(select, f_661_30564_30571(list, 0)), f_661_30574_30589(select, f_661_30581_30588(list, 1)), f_661_30591_30606(select, f_661_30598_30605(list, 2)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(661, 30220, 30956);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(661, 30220, 30956);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 30683, 30735);

                            var
                            array = new ArrayElement<GreenNode>[f_661_30723_30733(list)]
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 30770, 30775);
                                for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 30761, 30862) || true) && (i < f_661_30781_30793(array))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 30795, 30798)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(661, 30761, 30862))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(661, 30761, 30862);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 30829, 30862);

                                    array[i].Value = f_661_30846_30861(select, f_661_30853_30860(list, i));
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(661, 1, 102);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(661, 1, 102);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 30888, 30918);

                            return f_661_30895_30917(array);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(661, 30220, 30956);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(661, 30095, 30967);

                int
                f_661_30228_30238(System.Collections.Generic.IReadOnlyList<TFrom>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(661, 30228, 30238);
                    return return_v;
                }


                TFrom?
                f_661_30374_30381(System.Collections.Generic.IReadOnlyList<TFrom>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(661, 30374, 30381);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode
                f_661_30367_30382(System.Func<TFrom, Microsoft.CodeAnalysis.GreenNode>
                this_param, TFrom?
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 30367, 30382);
                    return return_v;
                }


                TFrom?
                f_661_30460_30467(System.Collections.Generic.IReadOnlyList<TFrom>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(661, 30460, 30467);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode
                f_661_30453_30468(System.Func<TFrom, Microsoft.CodeAnalysis.GreenNode>
                this_param, TFrom?
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 30453, 30468);
                    return return_v;
                }


                TFrom?
                f_661_30477_30484(System.Collections.Generic.IReadOnlyList<TFrom>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(661, 30477, 30484);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode
                f_661_30470_30485(System.Func<TFrom, Microsoft.CodeAnalysis.GreenNode>
                this_param, TFrom?
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 30470, 30485);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList.WithTwoChildren
                f_661_30437_30486(Microsoft.CodeAnalysis.GreenNode
                child0, Microsoft.CodeAnalysis.GreenNode
                child1)
                {
                    var return_v = SyntaxList.List(child0, child1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 30437, 30486);
                    return return_v;
                }


                TFrom?
                f_661_30564_30571(System.Collections.Generic.IReadOnlyList<TFrom>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(661, 30564, 30571);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode
                f_661_30557_30572(System.Func<TFrom, Microsoft.CodeAnalysis.GreenNode>
                this_param, TFrom?
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 30557, 30572);
                    return return_v;
                }


                TFrom?
                f_661_30581_30588(System.Collections.Generic.IReadOnlyList<TFrom>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(661, 30581, 30588);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode
                f_661_30574_30589(System.Func<TFrom, Microsoft.CodeAnalysis.GreenNode>
                this_param, TFrom?
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 30574, 30589);
                    return return_v;
                }


                TFrom?
                f_661_30598_30605(System.Collections.Generic.IReadOnlyList<TFrom>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(661, 30598, 30605);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode
                f_661_30591_30606(System.Func<TFrom, Microsoft.CodeAnalysis.GreenNode>
                this_param, TFrom?
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 30591, 30606);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList.WithThreeChildren
                f_661_30541_30607(Microsoft.CodeAnalysis.GreenNode
                child0, Microsoft.CodeAnalysis.GreenNode
                child1, Microsoft.CodeAnalysis.GreenNode
                child2)
                {
                    var return_v = SyntaxList.List(child0, child1, child2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 30541, 30607);
                    return return_v;
                }


                int
                f_661_30723_30733(System.Collections.Generic.IReadOnlyList<TFrom>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(661, 30723, 30733);
                    return return_v;
                }


                int
                f_661_30781_30793(Microsoft.CodeAnalysis.ArrayElement<Microsoft.CodeAnalysis.GreenNode>[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(661, 30781, 30793);
                    return return_v;
                }


                TFrom?
                f_661_30853_30860(System.Collections.Generic.IReadOnlyList<TFrom>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(661, 30853, 30860);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode
                f_661_30846_30861(System.Func<TFrom, Microsoft.CodeAnalysis.GreenNode>
                this_param, TFrom?
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 30846, 30861);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList
                f_661_30895_30917(Microsoft.CodeAnalysis.ArrayElement<Microsoft.CodeAnalysis.GreenNode>[]
                children)
                {
                    var return_v = SyntaxList.List(children);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 30895, 30917);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(661, 30095, 30967);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(661, 30095, 30967);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SyntaxNode CreateRed()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(661, 30979, 31070);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 31033, 31059);

                return f_661_31040_31058(this, null, 0);
                DynAbs.Tracing.TraceSender.TraceExitMethod(661, 30979, 31070);

                Microsoft.CodeAnalysis.SyntaxNode
                f_661_31040_31058(Microsoft.CodeAnalysis.GreenNode
                this_param, Microsoft.CodeAnalysis.SyntaxNode?
                parent, int
                position)
                {
                    var return_v = this_param.CreateRed(parent, position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 31040, 31058);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(661, 30979, 31070);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(661, 30979, 31070);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal abstract SyntaxNode CreateRed(SyntaxNode? parent, int position);

        internal const int
        MaxCachedChildNum = 3
        ;

        internal bool IsCacheable
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(661, 31319, 31512);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 31355, 31497);

                    return ((this.flags & NodeFlags.InheritMask) == NodeFlags.IsNotMissing) && (DynAbs.Tracing.TraceSender.Expression_True(661, 31362, 31496) && f_661_31451_31465(this) <= GreenNode.MaxCachedChildNum);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(661, 31319, 31512);

                    int
                    f_661_31451_31465(Microsoft.CodeAnalysis.GreenNode
                    this_param)
                    {
                        var return_v = this_param.SlotCount;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(661, 31451, 31465);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(661, 31269, 31523);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(661, 31269, 31523);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal int GetCacheHash()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(661, 31535, 32044);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 31587, 31618);

                f_661_31587_31617(f_661_31600_31616(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 31634, 31678);

                int
                code = (int)(this.flags) ^ f_661_31665_31677(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 31692, 31717);

                int
                cnt = f_661_31702_31716(this)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 31740, 31745);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 31731, 31988) || true) && (i < cnt)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 31756, 31759)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(661, 31731, 31988))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(661, 31731, 31988);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 31793, 31816);

                        var
                        child = f_661_31805_31815(this, i)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 31834, 31973) || true) && (child != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(661, 31834, 31973);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 31893, 31954);

                            code = f_661_31900_31953(f_661_31913_31946(child), code);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(661, 31834, 31973);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(661, 1, 258);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(661, 1, 258);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 32004, 32033);

                return code & Int32.MaxValue;
                DynAbs.Tracing.TraceSender.TraceExitMethod(661, 31535, 32044);

                bool
                f_661_31600_31616(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.IsCacheable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(661, 31600, 31616);
                    return return_v;
                }


                int
                f_661_31587_31617(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 31587, 31617);
                    return 0;
                }


                int
                f_661_31665_31677(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.RawKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(661, 31665, 31677);
                    return return_v;
                }


                int
                f_661_31702_31716(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.SlotCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(661, 31702, 31716);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode?
                f_661_31805_31815(Microsoft.CodeAnalysis.GreenNode
                this_param, int
                index)
                {
                    var return_v = this_param.GetSlot(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 31805, 31815);
                    return return_v;
                }


                int
                f_661_31913_31946(Microsoft.CodeAnalysis.GreenNode
                o)
                {
                    var return_v = RuntimeHelpers.GetHashCode((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 31913, 31946);
                    return return_v;
                }


                int
                f_661_31900_31953(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 31900, 31953);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(661, 31535, 32044);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(661, 31535, 32044);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool IsCacheEquivalent(int kind, NodeFlags flags, GreenNode? child1)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(661, 32056, 32330);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 32158, 32189);

                f_661_32158_32188(f_661_32171_32187(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 32205, 32319);

                return f_661_32212_32224(this) == kind && (DynAbs.Tracing.TraceSender.Expression_True(661, 32212, 32272) && this.flags == flags) && (DynAbs.Tracing.TraceSender.Expression_True(661, 32212, 32318) && f_661_32293_32308(this, 0) == child1);
                DynAbs.Tracing.TraceSender.TraceExitMethod(661, 32056, 32330);

                bool
                f_661_32171_32187(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.IsCacheable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(661, 32171, 32187);
                    return return_v;
                }


                int
                f_661_32158_32188(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 32158, 32188);
                    return 0;
                }


                int
                f_661_32212_32224(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.RawKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(661, 32212, 32224);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode?
                f_661_32293_32308(Microsoft.CodeAnalysis.GreenNode
                this_param, int
                index)
                {
                    var return_v = this_param.GetSlot(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 32293, 32308);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(661, 32056, 32330);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(661, 32056, 32330);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool IsCacheEquivalent(int kind, NodeFlags flags, GreenNode? child1, GreenNode? child2)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(661, 32342, 32681);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 32463, 32494);

                f_661_32463_32493(f_661_32476_32492(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 32510, 32670);

                return f_661_32517_32529(this) == kind && (DynAbs.Tracing.TraceSender.Expression_True(661, 32517, 32577) && this.flags == flags) && (DynAbs.Tracing.TraceSender.Expression_True(661, 32517, 32623) && f_661_32598_32613(this, 0) == child1) && (DynAbs.Tracing.TraceSender.Expression_True(661, 32517, 32669) && f_661_32644_32659(this, 1) == child2);
                DynAbs.Tracing.TraceSender.TraceExitMethod(661, 32342, 32681);

                bool
                f_661_32476_32492(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.IsCacheable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(661, 32476, 32492);
                    return return_v;
                }


                int
                f_661_32463_32493(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 32463, 32493);
                    return 0;
                }


                int
                f_661_32517_32529(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.RawKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(661, 32517, 32529);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode?
                f_661_32598_32613(Microsoft.CodeAnalysis.GreenNode
                this_param, int
                index)
                {
                    var return_v = this_param.GetSlot(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 32598, 32613);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode?
                f_661_32644_32659(Microsoft.CodeAnalysis.GreenNode
                this_param, int
                index)
                {
                    var return_v = this_param.GetSlot(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 32644, 32659);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(661, 32342, 32681);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(661, 32342, 32681);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool IsCacheEquivalent(int kind, NodeFlags flags, GreenNode? child1, GreenNode? child2, GreenNode? child3)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(661, 32693, 33097);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 32833, 32864);

                f_661_32833_32863(f_661_32846_32862(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 32880, 33086);

                return f_661_32887_32899(this) == kind && (DynAbs.Tracing.TraceSender.Expression_True(661, 32887, 32947) && this.flags == flags) && (DynAbs.Tracing.TraceSender.Expression_True(661, 32887, 32993) && f_661_32968_32983(this, 0) == child1) && (DynAbs.Tracing.TraceSender.Expression_True(661, 32887, 33039) && f_661_33014_33029(this, 1) == child2) && (DynAbs.Tracing.TraceSender.Expression_True(661, 32887, 33085) && f_661_33060_33075(this, 2) == child3);
                DynAbs.Tracing.TraceSender.TraceExitMethod(661, 32693, 33097);

                bool
                f_661_32846_32862(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.IsCacheable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(661, 32846, 32862);
                    return return_v;
                }


                int
                f_661_32833_32863(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 32833, 32863);
                    return 0;
                }


                int
                f_661_32887_32899(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.RawKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(661, 32887, 32899);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode?
                f_661_32968_32983(Microsoft.CodeAnalysis.GreenNode
                this_param, int
                index)
                {
                    var return_v = this_param.GetSlot(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 32968, 32983);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode?
                f_661_33014_33029(Microsoft.CodeAnalysis.GreenNode
                this_param, int
                index)
                {
                    var return_v = this_param.GetSlot(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 33014, 33029);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode?
                f_661_33060_33075(Microsoft.CodeAnalysis.GreenNode
                this_param, int
                index)
                {
                    var return_v = this_param.GetSlot(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 33060, 33075);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(661, 32693, 33097);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(661, 32693, 33097);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal GreenNode AddError(DiagnosticInfo err)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(661, 33778, 34490);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 33850, 33878);

                DiagnosticInfo[]
                errorInfos
                = default(DiagnosticInfo[]);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 33962, 34366) || true) && (f_661_33966_33982(this) == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(661, 33962, 34366);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 34024, 34051);

                    errorInfos = new[] { err };
                    DynAbs.Tracing.TraceSender.TraceExitCondition(661, 33962, 34366);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(661, 33962, 34366);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 34170, 34200);

                    errorInfos = f_661_34183_34199(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 34218, 34249);

                    var
                    length = f_661_34231_34248(errorInfos)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 34267, 34308);

                    f_661_34267_34307(ref errorInfos, length + 1);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 34326, 34351);

                    errorInfos[length] = err;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(661, 33962, 34366);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 34445, 34479);

                return f_661_34452_34478(this, errorInfos);
                DynAbs.Tracing.TraceSender.TraceExitMethod(661, 33778, 34490);

                Microsoft.CodeAnalysis.DiagnosticInfo[]
                f_661_33966_33982(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.GetDiagnostics();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 33966, 33982);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo[]
                f_661_34183_34199(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.GetDiagnostics();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 34183, 34199);
                    return return_v;
                }


                int
                f_661_34231_34248(Microsoft.CodeAnalysis.DiagnosticInfo[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(661, 34231, 34248);
                    return return_v;
                }


                int
                f_661_34267_34307(ref Microsoft.CodeAnalysis.DiagnosticInfo[]
                array, int
                newSize)
                {
                    Array.Resize(ref array, newSize);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 34267, 34307);
                    return 0;
                }


                Microsoft.CodeAnalysis.GreenNode
                f_661_34452_34478(Microsoft.CodeAnalysis.GreenNode
                this_param, Microsoft.CodeAnalysis.DiagnosticInfo[]
                diagnostics)
                {
                    var return_v = this_param.SetDiagnostics(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 34452, 34478);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(661, 33778, 34490);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(661, 33778, 34490);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static GreenNode()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(661, 612, 34497);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 908, 920);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 1152, 1241);
            s_diagnosticsTable = f_661_1186_1241(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 1330, 1421);
            s_annotationsTable = f_661_1364_1421(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 1475, 1522);
            s_noDiagnostics = f_661_1493_1522(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 1576, 1625);
            s_noAnnotations = f_661_1594_1625(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 1690, 1776);
            s_noAnnotationsEnumerable = f_661_1718_1776(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 12851, 12912);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(661, 31235, 31256);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(661, 612, 34497);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(661, 612, 34497);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(661, 612, 34497);

        static System.Runtime.CompilerServices.ConditionalWeakTable<Microsoft.CodeAnalysis.GreenNode, Microsoft.CodeAnalysis.DiagnosticInfo[]>
        f_661_1186_1241()
        {
            var return_v = new System.Runtime.CompilerServices.ConditionalWeakTable<Microsoft.CodeAnalysis.GreenNode, Microsoft.CodeAnalysis.DiagnosticInfo[]>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 1186, 1241);
            return return_v;
        }


        static System.Runtime.CompilerServices.ConditionalWeakTable<Microsoft.CodeAnalysis.GreenNode, Microsoft.CodeAnalysis.SyntaxAnnotation[]>
        f_661_1364_1421()
        {
            var return_v = new System.Runtime.CompilerServices.ConditionalWeakTable<Microsoft.CodeAnalysis.GreenNode, Microsoft.CodeAnalysis.SyntaxAnnotation[]>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 1364, 1421);
            return return_v;
        }


        static Microsoft.CodeAnalysis.DiagnosticInfo[]
        f_661_1493_1522()
        {
            var return_v = Array.Empty<DiagnosticInfo>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 1493, 1522);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SyntaxAnnotation[]
        f_661_1594_1625()
        {
            var return_v = Array.Empty<SyntaxAnnotation>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 1594, 1625);
            return return_v;
        }


        static System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxAnnotation>
        f_661_1718_1776()
        {
            var return_v = SpecializedCollections.EmptyEnumerable<SyntaxAnnotation>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 1718, 1776);
            return return_v;
        }


        int?
        f_661_2198_2217_M(int?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(661, 2198, 2217);
            return return_v;
        }


        static int
        f_661_2317_2358(System.Runtime.CompilerServices.ConditionalWeakTable<Microsoft.CodeAnalysis.GreenNode, Microsoft.CodeAnalysis.DiagnosticInfo[]>
        this_param, Microsoft.CodeAnalysis.GreenNode
        key, Microsoft.CodeAnalysis.DiagnosticInfo[]
        value)
        {
            this_param.Add(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 2317, 2358);
            return 0;
        }


        int?
        f_661_2516_2535_M(int?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(661, 2516, 2535);
            return return_v;
        }


        static int
        f_661_2635_2676(System.Runtime.CompilerServices.ConditionalWeakTable<Microsoft.CodeAnalysis.GreenNode, Microsoft.CodeAnalysis.DiagnosticInfo[]>
        this_param, Microsoft.CodeAnalysis.GreenNode
        key, Microsoft.CodeAnalysis.DiagnosticInfo[]
        value)
        {
            this_param.Add(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 2635, 2676);
            return 0;
        }


        int?
        f_661_2879_2898_M(int?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(661, 2879, 2898);
            return return_v;
        }


        static System.ArgumentException
        f_661_3046_3153(string
        paramName, string
        message)
        {
            var return_v = new System.ArgumentException(paramName: paramName, message: message);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 3046, 3153);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxAnnotation[]
        f_661_2963_2974_I(Microsoft.CodeAnalysis.SyntaxAnnotation[]
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 2963, 2974);
            return return_v;
        }


        static int
        f_661_3255_3296(System.Runtime.CompilerServices.ConditionalWeakTable<Microsoft.CodeAnalysis.GreenNode, Microsoft.CodeAnalysis.SyntaxAnnotation[]>
        this_param, Microsoft.CodeAnalysis.GreenNode
        key, Microsoft.CodeAnalysis.SyntaxAnnotation[]
        value)
        {
            this_param.Add(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 3255, 3296);
            return 0;
        }


        static ushort
        f_661_2832_2836_C(ushort
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(661, 2715, 3323);
            return return_v;
        }


        int?
        f_661_3525_3544_M(int?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(661, 3525, 3544);
            return return_v;
        }


        static System.ArgumentException
        f_661_3692_3799(string
        paramName, string
        message)
        {
            var return_v = new System.ArgumentException(paramName: paramName, message: message);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 3692, 3799);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxAnnotation[]
        f_661_3609_3620_I(Microsoft.CodeAnalysis.SyntaxAnnotation[]
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 3609, 3620);
            return return_v;
        }


        static int
        f_661_3901_3942(System.Runtime.CompilerServices.ConditionalWeakTable<Microsoft.CodeAnalysis.GreenNode, Microsoft.CodeAnalysis.SyntaxAnnotation[]>
        this_param, Microsoft.CodeAnalysis.GreenNode
        key, Microsoft.CodeAnalysis.SyntaxAnnotation[]
        value)
        {
            this_param.Add(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 3901, 3942);
            return 0;
        }


        static ushort
        f_661_3467_3471_C(ushort
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(661, 3335, 3969);
            return return_v;
        }


        static ushort
        f_661_13004_13023(Roslyn.Utilities.ObjectReader
        this_param)
        {
            var return_v = this_param.ReadUInt16();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 13004, 13023);
            return return_v;
        }


        static object
        f_661_13235_13253(Roslyn.Utilities.ObjectReader
        this_param)
        {
            var return_v = this_param.ReadValue();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 13235, 13253);
            return return_v;
        }


        static int
        f_661_13299_13317(Microsoft.CodeAnalysis.DiagnosticInfo[]
        this_param)
        {
            var return_v = this_param.Length;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(661, 13299, 13317);
            return return_v;
        }


        static int
        f_661_13429_13470(System.Runtime.CompilerServices.ConditionalWeakTable<Microsoft.CodeAnalysis.GreenNode, Microsoft.CodeAnalysis.DiagnosticInfo[]>
        this_param, Microsoft.CodeAnalysis.GreenNode
        key, Microsoft.CodeAnalysis.DiagnosticInfo[]
        value)
        {
            this_param.Add(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 13429, 13470);
            return 0;
        }


        static object
        f_661_13548_13566(Roslyn.Utilities.ObjectReader
        this_param)
        {
            var return_v = this_param.ReadValue();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 13548, 13566);
            return return_v;
        }


        static int
        f_661_13612_13630(Microsoft.CodeAnalysis.SyntaxAnnotation[]
        this_param)
        {
            var return_v = this_param.Length;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(661, 13612, 13630);
            return return_v;
        }


        static int
        f_661_13742_13783(System.Runtime.CompilerServices.ConditionalWeakTable<Microsoft.CodeAnalysis.GreenNode, Microsoft.CodeAnalysis.SyntaxAnnotation[]>
        this_param, Microsoft.CodeAnalysis.GreenNode
        key, Microsoft.CodeAnalysis.SyntaxAnnotation[]
        value)
        {
            this_param.Add(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(661, 13742, 13783);
            return 0;
        }


        bool
        f_661_13892_13918()
        {
            var return_v = ShouldReuseInSerialization;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(661, 13892, 13918);
            return return_v;
        }


        bool
        f_661_13983_13999(Microsoft.CodeAnalysis.GreenNode
        this_param)
        {
            var return_v = this_param.IsCacheable;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(661, 13983, 13999);
            return return_v;
        }

    }
}
