// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;
using System.Diagnostics;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal class VariablesDeclaredWalker : AbstractRegionControlFlowPass
    {
        internal static IEnumerable<Symbol> Analyze(CSharpCompilation compilation, Symbol member, BoundNode node, BoundNode firstInRegion, BoundNode lastInRegion)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10910, 706, 1326);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10910, 885, 982);

                var
                walker = f_10910_898_981(compilation, member, node, firstInRegion, lastInRegion)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10910, 1032, 1055);

                    bool
                    badRegion = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10910, 1073, 1103);

                    f_10910_1073_1102(walker, ref badRegion);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10910, 1121, 1217);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10910, 1128, 1137) || ((badRegion && DynAbs.Tracing.TraceSender.Conditional_F2(10910, 1140, 1188)) || DynAbs.Tracing.TraceSender.Conditional_F3(10910, 1191, 1216))) ? f_10910_1140_1188() : walker._variablesDeclared;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(10910, 1246, 1315);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10910, 1286, 1300);

                    f_10910_1286_1299(walker);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(10910, 1246, 1315);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10910, 706, 1326);

                Microsoft.CodeAnalysis.CSharp.VariablesDeclaredWalker
                f_10910_898_981(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.Symbol
                member, Microsoft.CodeAnalysis.CSharp.BoundNode
                node, Microsoft.CodeAnalysis.CSharp.BoundNode
                firstInRegion, Microsoft.CodeAnalysis.CSharp.BoundNode
                lastInRegion)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.VariablesDeclaredWalker(compilation, member, node, firstInRegion, lastInRegion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10910, 898, 981);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<Microsoft.CodeAnalysis.CSharp.ControlFlowPass.LocalState, Microsoft.CodeAnalysis.CSharp.ControlFlowPass.LocalFunctionState>.PendingBranch>
                f_10910_1073_1102(Microsoft.CodeAnalysis.CSharp.VariablesDeclaredWalker
                this_param, ref bool
                badRegion)
                {
                    var return_v = this_param.Analyze(ref badRegion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10910, 1073, 1102);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10910_1140_1188()
                {
                    var return_v = SpecializedCollections.EmptyEnumerable<Symbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10910, 1140, 1188);
                    return return_v;
                }


                int
                f_10910_1286_1299(Microsoft.CodeAnalysis.CSharp.VariablesDeclaredWalker
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10910, 1286, 1299);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10910, 706, 1326);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10910, 706, 1326);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private HashSet<Symbol> _variablesDeclared;

        internal VariablesDeclaredWalker(CSharpCompilation compilation, Symbol member, BoundNode node, BoundNode firstInRegion, BoundNode lastInRegion)
        : base(f_10910_1581_1592_C(compilation), member, node, firstInRegion, lastInRegion)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10910, 1417, 1658);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10910, 1362, 1404);
                this._variablesDeclared = f_10910_1383_1404(); DynAbs.Tracing.TraceSender.TraceExitConstructor(10910, 1417, 1658);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10910, 1417, 1658);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10910, 1417, 1658);
            }
        }

        protected override void Free()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10910, 1670, 1788);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10910, 1725, 1737);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Free(), 10910, 1725, 1736);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10910, 1751, 1777);

                _variablesDeclared = null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10910, 1670, 1788);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10910, 1670, 1788);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10910, 1670, 1788);
            }
        }

        public override void VisitPattern(BoundPattern pattern)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10910, 1800, 1970);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10910, 1880, 1907);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitPattern(pattern), 10910, 1880, 1906);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10910, 1921, 1959);

                f_10910_1921_1958(this, pattern);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10910, 1800, 1970);

                int
                f_10910_1921_1958(Microsoft.CodeAnalysis.CSharp.VariablesDeclaredWalker
                this_param, Microsoft.CodeAnalysis.CSharp.BoundPattern
                pattern)
                {
                    this_param.NoteDeclaredPatternVariables(pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10910, 1921, 1958);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10910, 1800, 1970);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10910, 1800, 1970);
            }
        }

        protected override void VisitSwitchSection(BoundSwitchSection node, bool isLastSection)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10910, 1982, 2298);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10910, 2094, 2226);
                    foreach (var label in f_10910_2116_2133_I(f_10910_2116_2133(node)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10910, 2094, 2226);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10910, 2167, 2211);

                        f_10910_2167_2210(this, f_10910_2196_2209(label));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10910, 2094, 2226);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10910, 1, 133);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10910, 1, 133);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10910, 2242, 2287);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitSwitchSection(node, isLastSection), 10910, 2242, 2286);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10910, 1982, 2298);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel>
                f_10910_2116_2133(Microsoft.CodeAnalysis.CSharp.BoundSwitchSection
                this_param)
                {
                    var return_v = this_param.SwitchLabels;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10910, 2116, 2133);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundPattern
                f_10910_2196_2209(Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel
                this_param)
                {
                    var return_v = this_param.Pattern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10910, 2196, 2209);
                    return return_v;
                }


                int
                f_10910_2167_2210(Microsoft.CodeAnalysis.CSharp.VariablesDeclaredWalker
                this_param, Microsoft.CodeAnalysis.CSharp.BoundPattern
                pattern)
                {
                    this_param.NoteDeclaredPatternVariables(pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10910, 2167, 2210);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel>
                f_10910_2116_2133_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10910, 2116, 2133);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10910, 1982, 2298);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10910, 1982, 2298);
            }
        }

        private void NoteDeclaredPatternVariables(BoundPattern pattern)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10910, 2412, 3617);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10910, 2500, 3606) || true) && (f_10910_2504_2512())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10910, 2500, 3606);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10910, 2546, 3591);

                    switch (pattern)
                    {

                        case BoundDeclarationPattern decl:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10910, 2546, 3591);
                            {

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10910, 2787, 3162) || true) && (f_10910_2791_2810_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10910_2791_2804(decl), 10910, 2791, 2810)?.Kind) == SymbolKind.Local)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10910, 2787, 3162);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10910, 3093, 3131);

                                    f_10910_3093_3130(                                // Because this API only returns local symbols and parameters,
                                                                                      // we exclude pattern variables that have become fields in scripts.
                                                                    _variablesDeclared, f_10910_3116_3129(decl));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10910, 2787, 3162);
                                }
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(10910, 3215, 3221);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10910, 2546, 3591);

                        case BoundRecursivePattern recur:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10910, 2546, 3591);
                            {

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10910, 3333, 3513) || true) && (f_10910_3337_3357_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10910_3337_3351(recur), 10910, 3337, 3357)?.Kind) == SymbolKind.Local)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10910, 3333, 3513);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10910, 3443, 3482);

                                    f_10910_3443_3481(_variablesDeclared, f_10910_3466_3480(recur));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10910, 3333, 3513);
                                }
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(10910, 3566, 3572);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10910, 2546, 3591);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10910, 2500, 3606);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10910, 2412, 3617);

                bool
                f_10910_2504_2512()
                {
                    var return_v = IsInside;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10910, 2504, 2512);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10910_2791_2804(Microsoft.CodeAnalysis.CSharp.BoundDeclarationPattern
                this_param)
                {
                    var return_v = this_param.Variable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10910, 2791, 2804);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind?
                f_10910_2791_2810_M(Microsoft.CodeAnalysis.SymbolKind?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10910, 2791, 2810);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10910_3116_3129(Microsoft.CodeAnalysis.CSharp.BoundDeclarationPattern
                this_param)
                {
                    var return_v = this_param.Variable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10910, 3116, 3129);
                    return return_v;
                }


                bool
                f_10910_3093_3130(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10910, 3093, 3130);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10910_3337_3351(Microsoft.CodeAnalysis.CSharp.BoundRecursivePattern
                this_param)
                {
                    var return_v = this_param.Variable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10910, 3337, 3351);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind?
                f_10910_3337_3357_M(Microsoft.CodeAnalysis.SymbolKind?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10910, 3337, 3357);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10910_3466_3480(Microsoft.CodeAnalysis.CSharp.BoundRecursivePattern
                this_param)
                {
                    var return_v = this_param.Variable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10910, 3466, 3480);
                    return return_v;
                }


                bool
                f_10910_3443_3481(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10910, 3443, 3481);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10910, 2412, 3617);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10910, 2412, 3617);
            }
        }

        public override BoundNode VisitLocalDeclaration(BoundLocalDeclaration node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10910, 3629, 3898);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10910, 3729, 3831) || true) && (f_10910_3733_3741())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10910, 3729, 3831);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10910, 3775, 3816);

                    f_10910_3775_3815(_variablesDeclared, f_10910_3798_3814(node));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10910, 3729, 3831);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10910, 3847, 3887);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitLocalDeclaration(node), 10910, 3854, 3886);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10910, 3629, 3898);

                bool
                f_10910_3733_3741()
                {
                    var return_v = IsInside;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10910, 3733, 3741);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10910_3798_3814(Microsoft.CodeAnalysis.CSharp.BoundLocalDeclaration
                this_param)
                {
                    var return_v = this_param.LocalSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10910, 3798, 3814);
                    return return_v;
                }


                bool
                f_10910_3775_3815(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                item)
                {
                    var return_v = this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10910, 3775, 3815);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10910, 3629, 3898);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10910, 3629, 3898);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitLambda(BoundLambda node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10910, 3910, 4281);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10910, 3990, 4224) || true) && (f_10910_3994_4002() && (DynAbs.Tracing.TraceSender.Expression_True(10910, 3994, 4032) && f_10910_4006_4032_M(!node.WasCompilerGenerated)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10910, 3990, 4224);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10910, 4066, 4209);
                        foreach (var parameter in f_10910_4092_4114_I(f_10910_4092_4114(f_10910_4092_4103(node))))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10910, 4066, 4209);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10910, 4156, 4190);

                            f_10910_4156_4189(_variablesDeclared, parameter);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10910, 4066, 4209);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10910, 1, 144);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10910, 1, 144);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10910, 3990, 4224);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10910, 4240, 4270);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitLambda(node), 10910, 4247, 4269);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10910, 3910, 4281);

                bool
                f_10910_3994_4002()
                {
                    var return_v = IsInside;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10910, 3994, 4002);
                    return return_v;
                }


                bool
                f_10910_4006_4032_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10910, 4006, 4032);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                f_10910_4092_4103(Microsoft.CodeAnalysis.CSharp.BoundLambda
                this_param)
                {
                    var return_v = this_param.Symbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10910, 4092, 4103);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10910_4092_4114(Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10910, 4092, 4114);
                    return return_v;
                }


                bool
                f_10910_4156_4189(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                item)
                {
                    var return_v = this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10910, 4156, 4189);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10910_4092_4114_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10910, 4092, 4114);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10910, 3910, 4281);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10910, 3910, 4281);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitLocalFunctionStatement(BoundLocalFunctionStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10910, 4293, 4712);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10910, 4405, 4639) || true) && (f_10910_4409_4417() && (DynAbs.Tracing.TraceSender.Expression_True(10910, 4409, 4447) && f_10910_4421_4447_M(!node.WasCompilerGenerated)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10910, 4405, 4639);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10910, 4481, 4624);
                        foreach (var parameter in f_10910_4507_4529_I(f_10910_4507_4529(f_10910_4507_4518(node))))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10910, 4481, 4624);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10910, 4571, 4605);

                            f_10910_4571_4604(_variablesDeclared, parameter);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10910, 4481, 4624);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10910, 1, 144);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10910, 1, 144);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10910, 4405, 4639);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10910, 4655, 4701);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitLocalFunctionStatement(node), 10910, 4662, 4700);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10910, 4293, 4712);

                bool
                f_10910_4409_4417()
                {
                    var return_v = IsInside;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10910, 4409, 4417);
                    return return_v;
                }


                bool
                f_10910_4421_4447_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10910, 4421, 4447);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                f_10910_4507_4518(Microsoft.CodeAnalysis.CSharp.BoundLocalFunctionStatement
                this_param)
                {
                    var return_v = this_param.Symbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10910, 4507, 4518);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10910_4507_4529(Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10910, 4507, 4529);
                    return return_v;
                }


                bool
                f_10910_4571_4604(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                item)
                {
                    var return_v = this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10910, 4571, 4604);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10910_4507_4529_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10910, 4507, 4529);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10910, 4293, 4712);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10910, 4293, 4712);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override void VisitForEachIterationVariables(BoundForEachStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10910, 4724, 5411);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10910, 4828, 5400) || true) && (f_10910_4832_4840())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10910, 4828, 5400);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10910, 4874, 4954);

                    var
                    deconstructionAssignment = f_10910_4905_4953_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10910_4905_4927(node), 10910, 4905, 4953)?.DeconstructionAssignment)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10910, 4974, 5385) || true) && (deconstructionAssignment == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10910, 4974, 5385);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10910, 5052, 5103);

                        f_10910_5052_5102(_variablesDeclared, f_10910_5078_5101(node));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10910, 4974, 5385);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10910, 4974, 5385);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10910, 5261, 5366);

                        f_10910_5261_5365(                    // Deconstruction foreach declares multiple variables.
                                            ((BoundTupleExpression)f_10910_5284_5313(deconstructionAssignment)), (x, self) => self.Visit(x), this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10910, 4974, 5385);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10910, 4828, 5400);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10910, 4724, 5411);

                bool
                f_10910_4832_4840()
                {
                    var return_v = IsInside;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10910, 4832, 4840);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundForEachDeconstructStep?
                f_10910_4905_4927(Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
                this_param)
                {
                    var return_v = this_param.DeconstructionOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10910, 4905, 4927);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDeconstructionAssignmentOperator?
                f_10910_4905_4953_M(Microsoft.CodeAnalysis.CSharp.BoundDeconstructionAssignmentOperator?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10910, 4905, 4953);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10910_5078_5101(Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
                this_param)
                {
                    var return_v = this_param.IterationVariables;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10910, 5078, 5101);
                    return return_v;
                }


                bool
                f_10910_5052_5102(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                set, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                values)
                {
                    var return_v = set.AddAll<Microsoft.CodeAnalysis.CSharp.Symbol>((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbol>)values);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10910, 5052, 5102);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundTupleExpression
                f_10910_5284_5313(Microsoft.CodeAnalysis.CSharp.BoundDeconstructionAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10910, 5284, 5313);
                    return return_v;
                }


                int
                f_10910_5261_5365(Microsoft.CodeAnalysis.CSharp.BoundTupleExpression
                this_param, System.Action<Microsoft.CodeAnalysis.CSharp.BoundExpression, Microsoft.CodeAnalysis.CSharp.VariablesDeclaredWalker>
                action, Microsoft.CodeAnalysis.CSharp.VariablesDeclaredWalker
                args)
                {
                    this_param.VisitAllElements<Microsoft.CodeAnalysis.CSharp.VariablesDeclaredWalker>(action, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10910, 5261, 5365);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10910, 4724, 5411);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10910, 4724, 5411);
            }
        }

        protected override void VisitCatchBlock(BoundCatchBlock catchBlock, ref LocalState finallyState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10910, 5423, 5905);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10910, 5544, 5827) || true) && (f_10910_5548_5556())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10910, 5544, 5827);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10910, 5590, 5637);

                    var
                    local = catchBlock.Locals.FirstOrDefault()
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10910, 5657, 5812) || true) && (f_10910_5661_5683_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(local, 10910, 5661, 5683)?.DeclarationKind) == LocalDeclarationKind.CatchVariable)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10910, 5657, 5812);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10910, 5763, 5793);

                        f_10910_5763_5792(_variablesDeclared, local);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10910, 5657, 5812);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10910, 5544, 5827);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10910, 5843, 5894);

                //DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitCatchBlock(catchBlock, ref finallyState), 10910, 5843, 5893);
                base.VisitCatchBlock(catchBlock, ref finallyState);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10910, 5843, 5893);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10910, 5423, 5905);

                bool
                f_10910_5548_5556()
                {
                    var return_v = IsInside;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10910, 5548, 5556);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalDeclarationKind?
                f_10910_5661_5683_M(Microsoft.CodeAnalysis.CSharp.Symbols.LocalDeclarationKind?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10910, 5661, 5683);
                    return return_v;
                }


                bool
                f_10910_5763_5792(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                item)
                {
                    var return_v = this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10910, 5763, 5792);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10910, 5423, 5905);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10910, 5423, 5905);
            }
        }

        public override BoundNode VisitQueryClause(BoundQueryClause node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10910, 5917, 6272);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10910, 6007, 6210) || true) && (f_10910_6011_6019())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10910, 6007, 6210);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10910, 6053, 6195) || true) && ((object)f_10910_6065_6083(node) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10910, 6053, 6195);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10910, 6133, 6176);

                        f_10910_6133_6175(_variablesDeclared, f_10910_6156_6174(node));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10910, 6053, 6195);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10910, 6007, 6210);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10910, 6226, 6261);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitQueryClause(node), 10910, 6233, 6260);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10910, 5917, 6272);

                bool
                f_10910_6011_6019()
                {
                    var return_v = IsInside;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10910, 6011, 6019);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol?
                f_10910_6065_6083(Microsoft.CodeAnalysis.CSharp.BoundQueryClause
                this_param)
                {
                    var return_v = this_param.DefinedSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10910, 6065, 6083);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                f_10910_6156_6174(Microsoft.CodeAnalysis.CSharp.BoundQueryClause
                this_param)
                {
                    var return_v = this_param.DefinedSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10910, 6156, 6174);
                    return return_v;
                }


                bool
                f_10910_6133_6175(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                item)
                {
                    var return_v = this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10910, 6133, 6175);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10910, 5917, 6272);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10910, 5917, 6272);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override void VisitLvalue(BoundLocal node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10910, 6284, 6389);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10910, 6361, 6378);

                f_10910_6361_6377(this, node);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10910, 6284, 6389);

                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10910_6361_6377(Microsoft.CodeAnalysis.CSharp.VariablesDeclaredWalker
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                node)
                {
                    var return_v = this_param.VisitLocal(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10910, 6361, 6377);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10910, 6284, 6389);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10910, 6284, 6389);
            }
        }

        public override BoundNode VisitLocal(BoundLocal node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10910, 6401, 6678);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10910, 6479, 6639) || true) && (f_10910_6483_6491() && (DynAbs.Tracing.TraceSender.Expression_True(10910, 6483, 6549) && f_10910_6495_6515(node) != BoundLocalDeclarationKind.None))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10910, 6479, 6639);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10910, 6583, 6624);

                    f_10910_6583_6623(_variablesDeclared, f_10910_6606_6622(node));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10910, 6479, 6639);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10910, 6655, 6667);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10910, 6401, 6678);

                bool
                f_10910_6483_6491()
                {
                    var return_v = IsInside;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10910, 6483, 6491);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocalDeclarationKind
                f_10910_6495_6515(Microsoft.CodeAnalysis.CSharp.BoundLocal
                this_param)
                {
                    var return_v = this_param.DeclarationKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10910, 6495, 6515);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10910_6606_6622(Microsoft.CodeAnalysis.CSharp.BoundLocal
                this_param)
                {
                    var return_v = this_param.LocalSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10910, 6606, 6622);
                    return return_v;
                }


                bool
                f_10910_6583_6623(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                item)
                {
                    var return_v = this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10910, 6583, 6623);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10910, 6401, 6678);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10910, 6401, 6678);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static VariablesDeclaredWalker()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10910, 619, 6685);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10910, 619, 6685);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10910, 619, 6685);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10910, 619, 6685);

        System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
        f_10910_1383_1404()
        {
            var return_v = new System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10910, 1383, 1404);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_10910_1581_1592_C(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10910, 1417, 1658);
            return return_v;
        }

    }
}
