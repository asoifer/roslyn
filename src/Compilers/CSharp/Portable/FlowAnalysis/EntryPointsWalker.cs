// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal class EntryPointsWalker : AbstractRegionControlFlowPass
    {
        internal static IEnumerable<LabeledStatementSyntax> Analyze(CSharpCompilation compilation, Symbol member, BoundNode node, BoundNode firstInRegion, BoundNode lastInRegion, out bool? succeeded)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10894, 833, 1569);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10894, 1049, 1140);

                var
                walker = f_10894_1062_1139(compilation, member, node, firstInRegion, lastInRegion)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10894, 1154, 1177);

                bool
                badRegion = false
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10894, 1227, 1257);

                    f_10894_1227_1256(walker, ref badRegion);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10894, 1275, 1308);

                    var
                    result = walker._entryPoints
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10894, 1326, 1349);

                    succeeded = !badRegion;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10894, 1367, 1460);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10894, 1374, 1383) || ((badRegion && DynAbs.Tracing.TraceSender.Conditional_F2(10894, 1386, 1450)) || DynAbs.Tracing.TraceSender.Conditional_F3(10894, 1453, 1459))) ? f_10894_1386_1450() : result;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(10894, 1489, 1558);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10894, 1529, 1543);

                    f_10894_1529_1542(walker);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(10894, 1489, 1558);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10894, 833, 1569);

                Microsoft.CodeAnalysis.CSharp.EntryPointsWalker
                f_10894_1062_1139(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.Symbol
                member, Microsoft.CodeAnalysis.CSharp.BoundNode
                node, Microsoft.CodeAnalysis.CSharp.BoundNode
                firstInRegion, Microsoft.CodeAnalysis.CSharp.BoundNode
                lastInRegion)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.EntryPointsWalker(compilation, member, node, firstInRegion, lastInRegion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10894, 1062, 1139);
                    return return_v;
                }


                int
                f_10894_1227_1256(Microsoft.CodeAnalysis.CSharp.EntryPointsWalker
                this_param, ref bool
                badRegion)
                {
                    this_param.Analyze(ref badRegion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10894, 1227, 1256);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.LabeledStatementSyntax>
                f_10894_1386_1450()
                {
                    var return_v = SpecializedCollections.EmptyEnumerable<LabeledStatementSyntax>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10894, 1386, 1450);
                    return return_v;
                }


                int
                f_10894_1529_1542(Microsoft.CodeAnalysis.CSharp.EntryPointsWalker
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10894, 1529, 1542);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10894, 833, 1569);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10894, 833, 1569);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private readonly HashSet<LabeledStatementSyntax> _entryPoints;

        private void Analyze(ref bool badRegion)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10894, 1695, 1846);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10894, 1815, 1835);

                f_10894_1815_1834(this, ref badRegion);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10894, 1695, 1846);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<Microsoft.CodeAnalysis.CSharp.ControlFlowPass.LocalState, Microsoft.CodeAnalysis.CSharp.ControlFlowPass.LocalFunctionState>.PendingBranch>
                f_10894_1815_1834(Microsoft.CodeAnalysis.CSharp.EntryPointsWalker
                this_param, ref bool
                badRegion)
                {
                    var return_v = this_param.Scan(ref badRegion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10894, 1815, 1834);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10894, 1695, 1846);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10894, 1695, 1846);
            }
        }

        private EntryPointsWalker(CSharpCompilation compilation, Symbol member, BoundNode node, BoundNode firstInRegion, BoundNode lastInRegion)
        : base(f_10894_2015_2026_C(compilation), member, node, firstInRegion, lastInRegion)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10894, 1858, 2092);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10894, 1630, 1682);
                this._entryPoints = f_10894_1645_1682(); DynAbs.Tracing.TraceSender.TraceExitConstructor(10894, 1858, 2092);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10894, 1858, 2092);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10894, 1858, 2092);
            }
        }

        protected override void Free()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10894, 2104, 2182);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10894, 2159, 2171);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Free(), 10894, 2159, 2170);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10894, 2104, 2182);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10894, 2104, 2182);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10894, 2104, 2182);
            }
        }

        protected override void NoteBranch(PendingBranch pending, BoundNode gotoStmt, BoundStatement targetStmt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10894, 2194, 2618);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10894, 2323, 2361);

                f_10894_2323_2360(targetStmt);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10894, 2375, 2607) || true) && (f_10894_2379_2409_M(!gotoStmt.WasCompilerGenerated) && (DynAbs.Tracing.TraceSender.Expression_True(10894, 2379, 2445) && f_10894_2413_2445_M(!targetStmt.WasCompilerGenerated)) && (DynAbs.Tracing.TraceSender.Expression_True(10894, 2379, 2487) && f_10894_2449_2487(this, f_10894_2464_2486(targetStmt.Syntax))) && (DynAbs.Tracing.TraceSender.Expression_True(10894, 2379, 2528) && !f_10894_2492_2528(this, f_10894_2507_2527(gotoStmt.Syntax))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10894, 2375, 2607);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10894, 2547, 2607);

                    f_10894_2547_2606(_entryPoints, targetStmt.Syntax);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10894, 2375, 2607);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10894, 2194, 2618);

                int
                f_10894_2323_2360(Microsoft.CodeAnalysis.CSharp.BoundStatement
                node)
                {
                    node.AssertIsLabeledStatement();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10894, 2323, 2360);
                    return 0;
                }


                bool
                f_10894_2379_2409_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10894, 2379, 2409);
                    return return_v;
                }


                bool
                f_10894_2413_2445_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10894, 2413, 2445);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_10894_2464_2486(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Span;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10894, 2464, 2486);
                    return return_v;
                }


                bool
                f_10894_2449_2487(Microsoft.CodeAnalysis.CSharp.EntryPointsWalker
                this_param, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    var return_v = this_param.RegionContains(span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10894, 2449, 2487);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_10894_2507_2527(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Span;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10894, 2507, 2527);
                    return return_v;
                }


                bool
                f_10894_2492_2528(Microsoft.CodeAnalysis.CSharp.EntryPointsWalker
                this_param, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    var return_v = this_param.RegionContains(span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10894, 2492, 2528);
                    return return_v;
                }


                bool
                f_10894_2547_2606(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Syntax.LabeledStatementSyntax>
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                item)
                {
                    var return_v = this_param.Add((Microsoft.CodeAnalysis.CSharp.Syntax.LabeledStatementSyntax)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10894, 2547, 2606);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10894, 2194, 2618);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10894, 2194, 2618);
            }
        }

        static EntryPointsWalker()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10894, 752, 2625);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10894, 752, 2625);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10894, 752, 2625);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10894, 752, 2625);

        System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Syntax.LabeledStatementSyntax>
        f_10894_1645_1682()
        {
            var return_v = new System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Syntax.LabeledStatementSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10894, 1645, 1682);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_10894_2015_2026_C(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10894, 1858, 2092);
            return return_v;
        }

    }
}
