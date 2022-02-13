// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal class UnassignedAddressTakenVariablesWalker : DefiniteAssignmentPass
    {
        private UnassignedAddressTakenVariablesWalker(CSharpCompilation compilation, Symbol member, BoundNode node)
        : base(f_10908_764_775_C(compilation), member, node, strictAnalysis: true)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10908, 636, 834);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10908, 1459, 1511);
                this._result = f_10908_1469_1511(); DynAbs.Tracing.TraceSender.TraceExitConstructor(10908, 636, 834);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10908, 636, 834);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10908, 636, 834);
            }
        }

        internal static HashSet<PrefixUnaryExpressionSyntax> Analyze(CSharpCompilation compilation, Symbol member, BoundNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10908, 846, 1393);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10908, 993, 1075);

                var
                walker = f_10908_1006_1074(compilation, member, node)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10908, 1125, 1148);

                    bool
                    badRegion = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10908, 1166, 1209);

                    var
                    result = f_10908_1179_1208(walker, ref badRegion)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10908, 1227, 1252);

                    f_10908_1227_1251(!badRegion);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10908, 1270, 1284);

                    return result;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(10908, 1313, 1382);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10908, 1353, 1367);

                    f_10908_1353_1366(walker);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(10908, 1313, 1382);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10908, 846, 1393);

                Microsoft.CodeAnalysis.CSharp.UnassignedAddressTakenVariablesWalker
                f_10908_1006_1074(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.Symbol
                member, Microsoft.CodeAnalysis.CSharp.BoundNode
                node)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.UnassignedAddressTakenVariablesWalker(compilation, member, node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10908, 1006, 1074);
                    return return_v;
                }


                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Syntax.PrefixUnaryExpressionSyntax>
                f_10908_1179_1208(Microsoft.CodeAnalysis.CSharp.UnassignedAddressTakenVariablesWalker
                this_param, ref bool
                badRegion)
                {
                    var return_v = this_param.Analyze(ref badRegion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10908, 1179, 1208);
                    return return_v;
                }


                int
                f_10908_1227_1251(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10908, 1227, 1251);
                    return 0;
                }


                int
                f_10908_1353_1366(Microsoft.CodeAnalysis.CSharp.UnassignedAddressTakenVariablesWalker
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10908, 1353, 1366);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10908, 846, 1393);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10908, 846, 1393);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private readonly HashSet<PrefixUnaryExpressionSyntax> _result;

        private HashSet<PrefixUnaryExpressionSyntax> Analyze(ref bool badRegion)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10908, 1524, 2263);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10908, 2189, 2223);

                // LAFHIS
                //DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Analyze(ref badRegion, null), 10908, 2189, 2222);
                base.Analyze(ref badRegion, null);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10908, 2189, 2222);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10908, 2237, 2252);

                return _result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10908, 1524, 2263);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10908, 1524, 2263);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10908, 1524, 2263);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override void ReportUnassigned(Symbol symbol, SyntaxNode node, int slot, bool skipIfUseBeforeDeclaration)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10908, 2275, 2585);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10908, 2415, 2574) || true) && (f_10908_2419_2437(f_10908_2419_2430(node)) == SyntaxKind.AddressOfExpression)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10908, 2415, 2574);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10908, 2505, 2559);

                    f_10908_2505_2558(_result, f_10908_2546_2557(node));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10908, 2415, 2574);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10908, 2275, 2585);

                Microsoft.CodeAnalysis.SyntaxNode?
                f_10908_2419_2430(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10908, 2419, 2430);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10908_2419_2437(Microsoft.CodeAnalysis.SyntaxNode?
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10908, 2419, 2437);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10908_2546_2557(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10908, 2546, 2557);
                    return return_v;
                }


                bool
                f_10908_2505_2558(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Syntax.PrefixUnaryExpressionSyntax>
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                item)
                {
                    var return_v = this_param.Add((Microsoft.CodeAnalysis.CSharp.Syntax.PrefixUnaryExpressionSyntax)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10908, 2505, 2558);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10908, 2275, 2585);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10908, 2275, 2585);
            }
        }

        public override BoundNode VisitAddressOfOperator(BoundAddressOfOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10908, 2597, 2886);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10908, 2823, 2849);

                f_10908_2823_2848(this, f_10908_2835_2847(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10908, 2863, 2875);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10908, 2597, 2886);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10908_2835_2847(Microsoft.CodeAnalysis.CSharp.BoundAddressOfOperator
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10908, 2835, 2847);
                    return return_v;
                }


                int
                f_10908_2823_2848(Microsoft.CodeAnalysis.CSharp.UnassignedAddressTakenVariablesWalker
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitRvalue(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10908, 2823, 2848);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10908, 2597, 2886);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10908, 2597, 2886);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static UnassignedAddressTakenVariablesWalker()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10908, 542, 2893);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10908, 542, 2893);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10908, 542, 2893);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10908, 542, 2893);

        static Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_10908_764_775_C(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10908, 636, 834);
            return return_v;
        }


        System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Syntax.PrefixUnaryExpressionSyntax>
        f_10908_1469_1511()
        {
            var return_v = new System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Syntax.PrefixUnaryExpressionSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10908, 1469, 1511);
            return return_v;
        }

    }
}
