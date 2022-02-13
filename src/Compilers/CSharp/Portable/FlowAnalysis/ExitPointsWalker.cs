// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal class ExitPointsWalker : AbstractRegionControlFlowPass
    {
        private readonly ArrayBuilder<LabelSymbol> _labelsInside;

        private ArrayBuilder<StatementSyntax> _branchesOutOf;

        private ExitPointsWalker(CSharpCompilation compilation, Symbol member, BoundNode node, BoundNode firstInRegion, BoundNode lastInRegion)
        : base(f_10895_1037_1048_C(compilation), member, node, firstInRegion, lastInRegion)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10895, 881, 1251);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10895, 792, 805);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10895, 854, 868);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10895, 1117, 1165);

                _labelsInside = f_10895_1133_1164();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10895, 1179, 1240);

                _branchesOutOf = f_10895_1196_1239();
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10895, 881, 1251);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10895, 881, 1251);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10895, 881, 1251);
            }
        }

        protected override void Free()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10895, 1263, 1489);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10895, 1318, 1415) || true) && (_branchesOutOf != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10895, 1318, 1415);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10895, 1378, 1400);

                    f_10895_1378_1399(_branchesOutOf);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10895, 1318, 1415);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10895, 1431, 1452);

                f_10895_1431_1451(
                            _labelsInside);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10895, 1466, 1478);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Free(), 10895, 1466, 1477);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10895, 1263, 1489);

                int
                f_10895_1378_1399(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10895, 1378, 1399);
                    return 0;
                }


                int
                f_10895_1431_1451(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10895, 1431, 1451);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10895, 1263, 1489);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10895, 1263, 1489);
            }
        }

        internal static IEnumerable<StatementSyntax> Analyze(CSharpCompilation compilation, Symbol member, BoundNode node, BoundNode firstInRegion, BoundNode lastInRegion)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10895, 1501, 2234);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10895, 1689, 1779);

                var
                walker = f_10895_1702_1778(compilation, member, node, firstInRegion, lastInRegion)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10895, 1829, 1852);

                    bool
                    badRegion = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10895, 1870, 1900);

                    f_10895_1870_1899(walker, ref badRegion);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10895, 1918, 1974);

                    var
                    result = f_10895_1931_1973(walker._branchesOutOf)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10895, 1992, 2021);

                    walker._branchesOutOf = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10895, 2039, 2125);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10895, 2046, 2055) || ((badRegion && DynAbs.Tracing.TraceSender.Conditional_F2(10895, 2058, 2115)) || DynAbs.Tracing.TraceSender.Conditional_F3(10895, 2118, 2124))) ? f_10895_2058_2115() : result;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(10895, 2154, 2223);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10895, 2194, 2208);

                    f_10895_2194_2207(walker);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(10895, 2154, 2223);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10895, 1501, 2234);

                Microsoft.CodeAnalysis.CSharp.ExitPointsWalker
                f_10895_1702_1778(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.Symbol
                member, Microsoft.CodeAnalysis.CSharp.BoundNode
                node, Microsoft.CodeAnalysis.CSharp.BoundNode
                firstInRegion, Microsoft.CodeAnalysis.CSharp.BoundNode
                lastInRegion)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.ExitPointsWalker(compilation, member, node, firstInRegion, lastInRegion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10895, 1702, 1778);
                    return return_v;
                }


                int
                f_10895_1870_1899(Microsoft.CodeAnalysis.CSharp.ExitPointsWalker
                this_param, ref bool
                badRegion)
                {
                    this_param.Analyze(ref badRegion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10895, 1870, 1899);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax>
                f_10895_1931_1973(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10895, 1931, 1973);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax>
                f_10895_2058_2115()
                {
                    var return_v = SpecializedCollections.EmptyEnumerable<StatementSyntax>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10895, 2058, 2115);
                    return return_v;
                }


                int
                f_10895_2194_2207(Microsoft.CodeAnalysis.CSharp.ExitPointsWalker
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10895, 2194, 2207);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10895, 1501, 2234);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10895, 1501, 2234);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void Analyze(ref bool badRegion)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10895, 2246, 2383);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10895, 2352, 2372);

                f_10895_2352_2371(this, ref badRegion);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10895, 2246, 2383);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<Microsoft.CodeAnalysis.CSharp.ControlFlowPass.LocalState, Microsoft.CodeAnalysis.CSharp.ControlFlowPass.LocalFunctionState>.PendingBranch>
                f_10895_2352_2371(Microsoft.CodeAnalysis.CSharp.ExitPointsWalker
                this_param, ref bool
                badRegion)
                {
                    var return_v = this_param.Scan(ref badRegion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10895, 2352, 2371);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10895, 2246, 2383);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10895, 2246, 2383);
            }
        }

        public override BoundNode VisitLabelStatement(BoundLabelStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10895, 2395, 2598);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10895, 2491, 2535) || true) && (f_10895_2495_2503())
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10895, 2491, 2535);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10895, 2505, 2535);

                    f_10895_2505_2534(_labelsInside, f_10895_2523_2533(node));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10895, 2491, 2535);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10895, 2549, 2587);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitLabelStatement(node), 10895, 2556, 2586);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10895, 2395, 2598);

                bool
                f_10895_2495_2503()
                {
                    var return_v = IsInside;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10895, 2495, 2503);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                f_10895_2523_2533(Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
                this_param)
                {
                    var return_v = this_param.Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10895, 2523, 2533);
                    return return_v;
                }


                int
                f_10895_2505_2534(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10895, 2505, 2534);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10895, 2395, 2598);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10895, 2395, 2598);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitDoStatement(BoundDoStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10895, 2610, 2912);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10895, 2700, 2852) || true) && (f_10895_2704_2712())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10895, 2700, 2852);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10895, 2746, 2781);

                    f_10895_2746_2780(_labelsInside, f_10895_2764_2779(node));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10895, 2799, 2837);

                    f_10895_2799_2836(_labelsInside, f_10895_2817_2835(node));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10895, 2700, 2852);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10895, 2866, 2901);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitDoStatement(node), 10895, 2873, 2900);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10895, 2610, 2912);

                bool
                f_10895_2704_2712()
                {
                    var return_v = IsInside;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10895, 2704, 2712);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                f_10895_2764_2779(Microsoft.CodeAnalysis.CSharp.BoundDoStatement
                this_param)
                {
                    var return_v = this_param.BreakLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10895, 2764, 2779);
                    return return_v;
                }


                int
                f_10895_2746_2780(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10895, 2746, 2780);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                f_10895_2817_2835(Microsoft.CodeAnalysis.CSharp.BoundDoStatement
                this_param)
                {
                    var return_v = this_param.ContinueLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10895, 2817, 2835);
                    return return_v;
                }


                int
                f_10895_2799_2836(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10895, 2799, 2836);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10895, 2610, 2912);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10895, 2610, 2912);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitForEachStatement(BoundForEachStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10895, 2924, 3241);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10895, 3024, 3176) || true) && (f_10895_3028_3036())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10895, 3024, 3176);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10895, 3070, 3105);

                    f_10895_3070_3104(_labelsInside, f_10895_3088_3103(node));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10895, 3123, 3161);

                    f_10895_3123_3160(_labelsInside, f_10895_3141_3159(node));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10895, 3024, 3176);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10895, 3190, 3230);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitForEachStatement(node), 10895, 3197, 3229);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10895, 2924, 3241);

                bool
                f_10895_3028_3036()
                {
                    var return_v = IsInside;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10895, 3028, 3036);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                f_10895_3088_3103(Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
                this_param)
                {
                    var return_v = this_param.BreakLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10895, 3088, 3103);
                    return return_v;
                }


                int
                f_10895_3070_3104(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10895, 3070, 3104);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                f_10895_3141_3159(Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
                this_param)
                {
                    var return_v = this_param.ContinueLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10895, 3141, 3159);
                    return return_v;
                }


                int
                f_10895_3123_3160(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10895, 3123, 3160);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10895, 2924, 3241);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10895, 2924, 3241);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitForStatement(BoundForStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10895, 3253, 3558);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10895, 3345, 3497) || true) && (f_10895_3349_3357())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10895, 3345, 3497);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10895, 3391, 3426);

                    f_10895_3391_3425(_labelsInside, f_10895_3409_3424(node));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10895, 3444, 3482);

                    f_10895_3444_3481(_labelsInside, f_10895_3462_3480(node));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10895, 3345, 3497);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10895, 3511, 3547);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitForStatement(node), 10895, 3518, 3546);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10895, 3253, 3558);

                bool
                f_10895_3349_3357()
                {
                    var return_v = IsInside;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10895, 3349, 3357);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                f_10895_3409_3424(Microsoft.CodeAnalysis.CSharp.BoundForStatement
                this_param)
                {
                    var return_v = this_param.BreakLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10895, 3409, 3424);
                    return return_v;
                }


                int
                f_10895_3391_3425(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10895, 3391, 3425);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                f_10895_3462_3480(Microsoft.CodeAnalysis.CSharp.BoundForStatement
                this_param)
                {
                    var return_v = this_param.ContinueLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10895, 3462, 3480);
                    return return_v;
                }


                int
                f_10895_3444_3481(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10895, 3444, 3481);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10895, 3253, 3558);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10895, 3253, 3558);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitWhileStatement(BoundWhileStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10895, 3570, 3825);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10895, 3666, 3762) || true) && (f_10895_3670_3678())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10895, 3666, 3762);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10895, 3712, 3747);

                    f_10895_3712_3746(_labelsInside, f_10895_3730_3745(node));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10895, 3666, 3762);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10895, 3776, 3814);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitWhileStatement(node), 10895, 3783, 3813);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10895, 3570, 3825);

                bool
                f_10895_3670_3678()
                {
                    var return_v = IsInside;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10895, 3670, 3678);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                f_10895_3730_3745(Microsoft.CodeAnalysis.CSharp.BoundWhileStatement
                this_param)
                {
                    var return_v = this_param.BreakLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10895, 3730, 3745);
                    return return_v;
                }


                int
                f_10895_3712_3746(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10895, 3712, 3746);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10895, 3570, 3825);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10895, 3570, 3825);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override void EnterRegion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10895, 3837, 3929);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10895, 3899, 3918);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.EnterRegion(), 10895, 3899, 3917);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10895, 3837, 3929);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10895, 3837, 3929);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10895, 3837, 3929);
            }
        }

        protected override void LeaveRegion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10895, 3941, 5815);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10895, 4003, 5769);
                    foreach (var pending in f_10895_4027_4042_I(f_10895_4027_4042()))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10895, 4003, 5769);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10895, 4076, 4160) || true) && (pending.Branch == null || (DynAbs.Tracing.TraceSender.Expression_False(10895, 4080, 4149) || !f_10895_4107_4149(this, f_10895_4122_4148(pending.Branch.Syntax))))
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10895, 4076, 4160);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10895, 4151, 4160);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10895, 4076, 4160);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10895, 4178, 5677);

                        switch (f_10895_4186_4205(pending.Branch))
                        {

                            case BoundKind.GotoStatement:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10895, 4178, 5677);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10895, 4302, 4383) || true) && (f_10895_4306_4372(_labelsInside, f_10895_4329_4371(((BoundGotoStatement)pending.Branch))))
                                )
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10895, 4302, 4383);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10895, 4374, 4383);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10895, 4302, 4383);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(10895, 4409, 4415);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10895, 4178, 5677);

                            case BoundKind.BreakStatement:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10895, 4178, 5677);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10895, 4493, 4575) || true) && (f_10895_4497_4564(_labelsInside, f_10895_4520_4563(((BoundBreakStatement)pending.Branch))))
                                )
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10895, 4493, 4575);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10895, 4566, 4575);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10895, 4493, 4575);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(10895, 4601, 4607);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10895, 4178, 5677);

                            case BoundKind.ContinueStatement:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10895, 4178, 5677);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10895, 4688, 4773) || true) && (f_10895_4692_4762(_labelsInside, f_10895_4715_4761(((BoundContinueStatement)pending.Branch))))
                                )
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10895, 4688, 4773);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10895, 4764, 4773);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10895, 4688, 4773);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(10895, 4799, 4805);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10895, 4178, 5677);

                            case BoundKind.YieldBreakStatement:
                            case BoundKind.ReturnStatement:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10895, 4178, 5677);
                                DynAbs.Tracing.TraceSender.TraceBreak(10895, 5000, 5006);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10895, 4178, 5677);

                            case BoundKind.YieldReturnStatement:
                            case BoundKind.AwaitExpression:
                            case BoundKind.UsingStatement:
                            case BoundKind.ForEachStatement when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10895, 5223, 5284) || true) && (f_10895_5228_5276(((BoundForEachStatement)pending.Branch)) != null) && (DynAbs.Tracing.TraceSender.Expression_True(10895, 5223, 5284) || true)
                        :
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10895, 4178, 5677);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10895, 5531, 5540);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10895, 4178, 5677);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10895, 4178, 5677);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10895, 5596, 5658);

                                throw f_10895_5602_5657(f_10895_5637_5656(pending.Branch));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10895, 4178, 5677);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10895, 5695, 5754);

                        f_10895_5695_5753(_branchesOutOf, pending.Branch.Syntax);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10895, 4003, 5769);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10895, 1, 1767);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10895, 1, 1767);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10895, 5785, 5804);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.LeaveRegion(), 10895, 5785, 5803);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10895, 3941, 5815);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<Microsoft.CodeAnalysis.CSharp.ControlFlowPass.LocalState, Microsoft.CodeAnalysis.CSharp.ControlFlowPass.LocalFunctionState>.PendingBranch>
                f_10895_4027_4042()
                {
                    var return_v = PendingBranches;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10895, 4027, 4042);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_10895_4122_4148(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Span;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10895, 4122, 4148);
                    return return_v;
                }


                bool
                f_10895_4107_4149(Microsoft.CodeAnalysis.CSharp.ExitPointsWalker
                this_param, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    var return_v = this_param.RegionContains(span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10895, 4107, 4149);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10895_4186_4205(Microsoft.CodeAnalysis.CSharp.BoundNode
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10895, 4186, 4205);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                f_10895_4329_4371(Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
                this_param)
                {
                    var return_v = this_param.Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10895, 4329, 4371);
                    return return_v;
                }


                bool
                f_10895_4306_4372(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10895, 4306, 4372);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                f_10895_4520_4563(Microsoft.CodeAnalysis.CSharp.BoundBreakStatement
                this_param)
                {
                    var return_v = this_param.Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10895, 4520, 4563);
                    return return_v;
                }


                bool
                f_10895_4497_4564(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                item)
                {
                    var return_v = this_param.Contains((Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10895, 4497, 4564);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                f_10895_4715_4761(Microsoft.CodeAnalysis.CSharp.BoundContinueStatement
                this_param)
                {
                    var return_v = this_param.Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10895, 4715, 4761);
                    return return_v;
                }


                bool
                f_10895_4692_4762(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                item)
                {
                    var return_v = this_param.Contains((Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10895, 4692, 4762);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundAwaitableInfo?
                f_10895_5228_5276(Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
                this_param)
                {
                    var return_v = this_param.AwaitOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10895, 5228, 5276);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10895_5637_5656(Microsoft.CodeAnalysis.CSharp.BoundNode
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10895, 5637, 5656);
                    return return_v;
                }


                System.Exception
                f_10895_5602_5657(Microsoft.CodeAnalysis.CSharp.BoundKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10895, 5602, 5657);
                    return return_v;
                }


                int
                f_10895_5695_5753(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax>
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10895, 5695, 5753);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<Microsoft.CodeAnalysis.CSharp.ControlFlowPass.LocalState, Microsoft.CodeAnalysis.CSharp.ControlFlowPass.LocalFunctionState>.PendingBranch>
                f_10895_4027_4042_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<Microsoft.CodeAnalysis.CSharp.ControlFlowPass.LocalState, Microsoft.CodeAnalysis.CSharp.ControlFlowPass.LocalFunctionState>.PendingBranch>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10895, 4027, 4042);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10895, 3941, 5815);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10895, 3941, 5815);
            }
        }

        static ExitPointsWalker()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10895, 669, 5822);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10895, 669, 5822);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10895, 669, 5822);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10895, 669, 5822);

        Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
        f_10895_1133_1164()
        {
            var return_v = new Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10895, 1133, 1164);
            return return_v;
        }


        Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax>
        f_10895_1196_1239()
        {
            var return_v = ArrayBuilder<StatementSyntax>.GetInstance();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10895, 1196, 1239);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_10895_1037_1048_C(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10895, 881, 1251);
            return return_v;
        }

    }
}
