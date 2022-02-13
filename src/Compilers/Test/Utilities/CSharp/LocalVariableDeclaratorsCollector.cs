// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;

namespace Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests
{
    internal sealed class LocalVariableDeclaratorsCollector : CSharpSyntaxWalker
    {
        private readonly ArrayBuilder<SyntaxNode> _builder;

        private LocalVariableDeclaratorsCollector(ArrayBuilder<SyntaxNode> builder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(21011, 634, 764);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21011, 613, 621);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21011, 734, 753);

                _builder = builder;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(21011, 634, 764);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21011, 634, 764);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21011, 634, 764);
            }
        }

        internal static ImmutableArray<SyntaxNode> GetDeclarators(SourceMemberMethodSymbol method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21011, 776, 1191);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21011, 891, 944);

                var
                builder = f_21011_905_943()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21011, 958, 1019);

                var
                visitor = f_21011_972_1018(builder)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21011, 1033, 1060);

                var
                bodies = f_21011_1046_1059(method)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21011, 1074, 1130);

                f_21011_1074_1129(visitor, bodies.Item1 ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax>(21011, 1088, 1128) ?? (SyntaxNode)bodies.Item2));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21011, 1144, 1180);

                return f_21011_1151_1179(builder);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21011, 776, 1191);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21011, 776, 1191);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21011, 776, 1191);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override void VisitForEachStatement(ForEachStatementSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21011, 1203, 1383);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21011, 1306, 1325);

                f_21011_1306_1324(_builder, node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21011, 1339, 1372);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitForEachStatement(node), 21011, 1339, 1371);
                DynAbs.Tracing.TraceSender.TraceExitMethod(21011, 1203, 1383);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21011, 1203, 1383);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21011, 1203, 1383);
            }
        }

        public sealed override void VisitLockStatement(LockStatementSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21011, 1395, 1566);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21011, 1492, 1511);

                f_21011_1492_1510(_builder, node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21011, 1525, 1555);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitLockStatement(node), 21011, 1525, 1554);
                DynAbs.Tracing.TraceSender.TraceExitMethod(21011, 1395, 1566);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21011, 1395, 1566);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21011, 1395, 1566);
            }
        }

        public sealed override void VisitUsingStatement(UsingStatementSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21011, 1578, 1830);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21011, 1677, 1772) || true) && (f_21011_1681_1696(node) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21011, 1677, 1772);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21011, 1738, 1757);

                    f_21011_1738_1756(_builder, node);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21011, 1677, 1772);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21011, 1788, 1819);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitUsingStatement(node), 21011, 1788, 1818);
                DynAbs.Tracing.TraceSender.TraceExitMethod(21011, 1578, 1830);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21011, 1578, 1830);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21011, 1578, 1830);
            }
        }

        public override void VisitSwitchStatement(SwitchStatementSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21011, 1842, 2012);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21011, 1936, 1955);

                f_21011_1936_1954(_builder, node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21011, 1969, 2001);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitSwitchStatement(node), 21011, 1969, 2000);
                DynAbs.Tracing.TraceSender.TraceExitMethod(21011, 1842, 2012);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21011, 1842, 2012);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21011, 1842, 2012);
            }
        }

        public override void VisitIfStatement(IfStatementSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21011, 2024, 2182);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21011, 2110, 2129);

                f_21011_2110_2128(_builder, node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21011, 2143, 2171);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitIfStatement(node), 21011, 2143, 2170);
                DynAbs.Tracing.TraceSender.TraceExitMethod(21011, 2024, 2182);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21011, 2024, 2182);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21011, 2024, 2182);
            }
        }

        public override void VisitWhileStatement(WhileStatementSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21011, 2194, 2361);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21011, 2286, 2305);

                f_21011_2286_2304(_builder, node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21011, 2319, 2350);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitWhileStatement(node), 21011, 2319, 2349);
                DynAbs.Tracing.TraceSender.TraceExitMethod(21011, 2194, 2361);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21011, 2194, 2361);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21011, 2194, 2361);
            }
        }

        public override void VisitDoStatement(DoStatementSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21011, 2373, 2531);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21011, 2459, 2478);

                f_21011_2459_2477(_builder, node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21011, 2492, 2520);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitDoStatement(node), 21011, 2492, 2519);
                DynAbs.Tracing.TraceSender.TraceExitMethod(21011, 2373, 2531);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21011, 2373, 2531);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21011, 2373, 2531);
            }
        }

        public override void VisitForStatement(ForStatementSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21011, 2543, 2781);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21011, 2631, 2725) || true) && (f_21011_2635_2649(node) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21011, 2631, 2725);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21011, 2691, 2710);

                    f_21011_2691_2709(_builder, node);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21011, 2631, 2725);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21011, 2741, 2770);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitForStatement(node), 21011, 2741, 2769);
                DynAbs.Tracing.TraceSender.TraceExitMethod(21011, 2543, 2781);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21011, 2543, 2781);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21011, 2543, 2781);
            }
        }

        public override void VisitVariableDeclarator(VariableDeclaratorSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21011, 2793, 2972);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21011, 2893, 2912);

                f_21011_2893_2911(_builder, node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21011, 2926, 2961);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitVariableDeclarator(node), 21011, 2926, 2960);
                DynAbs.Tracing.TraceSender.TraceExitMethod(21011, 2793, 2972);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21011, 2793, 2972);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21011, 2793, 2972);
            }
        }

        public override void VisitSingleVariableDesignation(SingleVariableDesignationSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21011, 2984, 3184);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21011, 3098, 3117);

                f_21011_3098_3116(_builder, node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21011, 3131, 3173);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitSingleVariableDesignation(node), 21011, 3131, 3172);
                DynAbs.Tracing.TraceSender.TraceExitMethod(21011, 2984, 3184);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21011, 2984, 3184);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21011, 2984, 3184);
            }
        }

        public override void VisitCatchDeclaration(CatchDeclarationSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21011, 3196, 3369);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21011, 3292, 3311);

                f_21011_3292_3310(_builder, node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21011, 3325, 3358);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitCatchDeclaration(node), 21011, 3325, 3357);
                DynAbs.Tracing.TraceSender.TraceExitMethod(21011, 3196, 3369);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21011, 3196, 3369);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21011, 3196, 3369);
            }
        }

        static LocalVariableDeclaratorsCollector()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(21011, 478, 3376);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(21011, 478, 3376);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21011, 478, 3376);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(21011, 478, 3376);

        static Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxNode>
        f_21011_905_943()
        {
            var return_v = ArrayBuilder<SyntaxNode>.GetInstance();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21011, 905, 943);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.LocalVariableDeclaratorsCollector
        f_21011_972_1018(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxNode>
        builder)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.LocalVariableDeclaratorsCollector(builder);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21011, 972, 1018);
            return return_v;
        }


        static (Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax blockBody, Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax arrowBody)
        f_21011_1046_1059(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol
        this_param)
        {
            var return_v = this_param.Bodies;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21011, 1046, 1059);
            return return_v;
        }


        static int
        f_21011_1074_1129(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.LocalVariableDeclaratorsCollector
        this_param, Microsoft.CodeAnalysis.SyntaxNode
        node)
        {
            this_param.Visit(node);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21011, 1074, 1129);
            return 0;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxNode>
        f_21011_1151_1179(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxNode>
        this_param)
        {
            var return_v = this_param.ToImmutableAndFree();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21011, 1151, 1179);
            return return_v;
        }


        int
        f_21011_1306_1324(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxNode>
        this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ForEachStatementSyntax
        item)
        {
            this_param.Add((Microsoft.CodeAnalysis.SyntaxNode)item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21011, 1306, 1324);
            return 0;
        }


        int
        f_21011_1492_1510(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxNode>
        this_param, Microsoft.CodeAnalysis.CSharp.Syntax.LockStatementSyntax
        item)
        {
            this_param.Add((Microsoft.CodeAnalysis.SyntaxNode)item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21011, 1492, 1510);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax?
        f_21011_1681_1696(Microsoft.CodeAnalysis.CSharp.Syntax.UsingStatementSyntax
        this_param)
        {
            var return_v = this_param.Expression;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21011, 1681, 1696);
            return return_v;
        }


        int
        f_21011_1738_1756(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxNode>
        this_param, Microsoft.CodeAnalysis.CSharp.Syntax.UsingStatementSyntax
        item)
        {
            this_param.Add((Microsoft.CodeAnalysis.SyntaxNode)item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21011, 1738, 1756);
            return 0;
        }


        int
        f_21011_1936_1954(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxNode>
        this_param, Microsoft.CodeAnalysis.CSharp.Syntax.SwitchStatementSyntax
        item)
        {
            this_param.Add((Microsoft.CodeAnalysis.SyntaxNode)item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21011, 1936, 1954);
            return 0;
        }


        int
        f_21011_2110_2128(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxNode>
        this_param, Microsoft.CodeAnalysis.CSharp.Syntax.IfStatementSyntax
        item)
        {
            this_param.Add((Microsoft.CodeAnalysis.SyntaxNode)item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21011, 2110, 2128);
            return 0;
        }


        int
        f_21011_2286_2304(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxNode>
        this_param, Microsoft.CodeAnalysis.CSharp.Syntax.WhileStatementSyntax
        item)
        {
            this_param.Add((Microsoft.CodeAnalysis.SyntaxNode)item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21011, 2286, 2304);
            return 0;
        }


        int
        f_21011_2459_2477(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxNode>
        this_param, Microsoft.CodeAnalysis.CSharp.Syntax.DoStatementSyntax
        item)
        {
            this_param.Add((Microsoft.CodeAnalysis.SyntaxNode)item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21011, 2459, 2477);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax?
        f_21011_2635_2649(Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax
        this_param)
        {
            var return_v = this_param.Condition;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21011, 2635, 2649);
            return return_v;
        }


        int
        f_21011_2691_2709(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxNode>
        this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax
        item)
        {
            this_param.Add((Microsoft.CodeAnalysis.SyntaxNode)item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21011, 2691, 2709);
            return 0;
        }


        int
        f_21011_2893_2911(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxNode>
        this_param, Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax
        item)
        {
            this_param.Add((Microsoft.CodeAnalysis.SyntaxNode)item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21011, 2893, 2911);
            return 0;
        }


        int
        f_21011_3098_3116(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxNode>
        this_param, Microsoft.CodeAnalysis.CSharp.Syntax.SingleVariableDesignationSyntax
        item)
        {
            this_param.Add((Microsoft.CodeAnalysis.SyntaxNode)item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21011, 3098, 3116);
            return 0;
        }


        int
        f_21011_3292_3310(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxNode>
        this_param, Microsoft.CodeAnalysis.CSharp.Syntax.CatchDeclarationSyntax
        item)
        {
            this_param.Add((Microsoft.CodeAnalysis.SyntaxNode)item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21011, 3292, 3310);
            return 0;
        }

    }
}
