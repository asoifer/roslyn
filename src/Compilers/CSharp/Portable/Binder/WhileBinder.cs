// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;
using System.Diagnostics;
using System.Collections.Immutable;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed class WhileBinder : LoopBinder
    {
        private readonly StatementSyntax _syntax;

        public WhileBinder(Binder enclosing, StatementSyntax syntax)
        : base(f_10375_737_746_C(enclosing))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10375, 656, 930);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10375, 636, 643);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10375, 772, 888);

                f_10375_772_887(syntax != null && (DynAbs.Tracing.TraceSender.Expression_True(10375, 785, 886) && (f_10375_804_844(syntax, SyntaxKind.WhileStatement) || (DynAbs.Tracing.TraceSender.Expression_False(10375, 804, 885) || f_10375_848_885(syntax, SyntaxKind.DoStatement)))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10375, 902, 919);

                _syntax = syntax;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10375, 656, 930);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10375, 656, 930);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10375, 656, 930);
            }
        }

        internal override BoundWhileStatement BindWhileParts(DiagnosticBag diagnostics, Binder originalBinder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10375, 942, 1516);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10375, 1069, 1110);

                var
                node = (WhileStatementSyntax)_syntax
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10375, 1126, 1208);

                var
                condition = f_10375_1142_1207(originalBinder, f_10375_1179_1193(node), diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10375, 1222, 1307);

                var
                body = f_10375_1233_1306(originalBinder, f_10375_1278_1292(node), diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10375, 1321, 1387);

                f_10375_1321_1386(f_10375_1334_1345(this) == f_10375_1349_1385(this, node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10375, 1401, 1505);

                return f_10375_1408_1504(node, f_10375_1438_1449(this), condition, body, f_10375_1468_1483(this), f_10375_1485_1503(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10375, 942, 1516);

                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10375_1179_1193(Microsoft.CodeAnalysis.CSharp.Syntax.WhileStatementSyntax
                this_param)
                {
                    var return_v = this_param.Condition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10375, 1179, 1193);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10375_1142_1207(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindBooleanExpression(node, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10375, 1142, 1207);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                f_10375_1278_1292(Microsoft.CodeAnalysis.CSharp.Syntax.WhileStatementSyntax
                this_param)
                {
                    var return_v = this_param.Statement;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10375, 1278, 1292);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10375_1233_1306(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindPossibleEmbeddedStatement(node, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10375, 1233, 1306);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10375_1334_1345(Microsoft.CodeAnalysis.CSharp.WhileBinder
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10375, 1334, 1345);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10375_1349_1385(Microsoft.CodeAnalysis.CSharp.WhileBinder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.WhileStatementSyntax
                scopeDesignator)
                {
                    var return_v = this_param.GetDeclaredLocalsForScope((Microsoft.CodeAnalysis.SyntaxNode)scopeDesignator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10375, 1349, 1385);
                    return return_v;
                }


                int
                f_10375_1321_1386(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10375, 1321, 1386);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10375_1438_1449(Microsoft.CodeAnalysis.CSharp.WhileBinder
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10375, 1438, 1449);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                f_10375_1468_1483(Microsoft.CodeAnalysis.CSharp.WhileBinder
                this_param)
                {
                    var return_v = this_param.BreakLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10375, 1468, 1483);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                f_10375_1485_1503(Microsoft.CodeAnalysis.CSharp.WhileBinder
                this_param)
                {
                    var return_v = this_param.ContinueLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10375, 1485, 1503);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundWhileStatement
                f_10375_1408_1504(Microsoft.CodeAnalysis.CSharp.Syntax.WhileStatementSyntax
                syntax, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, Microsoft.CodeAnalysis.CSharp.BoundExpression
                condition, Microsoft.CodeAnalysis.CSharp.BoundStatement
                body, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                breakLabel, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                continueLabel)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundWhileStatement((Microsoft.CodeAnalysis.SyntaxNode)syntax, locals, condition, body, breakLabel, continueLabel);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10375, 1408, 1504);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10375, 942, 1516);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10375, 942, 1516);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override BoundDoStatement BindDoParts(DiagnosticBag diagnostics, Binder originalBinder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10375, 1528, 2090);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10375, 1649, 1687);

                var
                node = (DoStatementSyntax)_syntax
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10375, 1703, 1785);

                var
                condition = f_10375_1719_1784(originalBinder, f_10375_1756_1770(node), diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10375, 1799, 1884);

                var
                body = f_10375_1810_1883(originalBinder, f_10375_1855_1869(node), diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10375, 1898, 1964);

                f_10375_1898_1963(f_10375_1911_1922(this) == f_10375_1926_1962(this, node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10375, 1978, 2079);

                return f_10375_1985_2078(node, f_10375_2012_2023(this), condition, body, f_10375_2042_2057(this), f_10375_2059_2077(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10375, 1528, 2090);

                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10375_1756_1770(Microsoft.CodeAnalysis.CSharp.Syntax.DoStatementSyntax
                this_param)
                {
                    var return_v = this_param.Condition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10375, 1756, 1770);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10375_1719_1784(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindBooleanExpression(node, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10375, 1719, 1784);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                f_10375_1855_1869(Microsoft.CodeAnalysis.CSharp.Syntax.DoStatementSyntax
                this_param)
                {
                    var return_v = this_param.Statement;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10375, 1855, 1869);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10375_1810_1883(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindPossibleEmbeddedStatement(node, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10375, 1810, 1883);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10375_1911_1922(Microsoft.CodeAnalysis.CSharp.WhileBinder
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10375, 1911, 1922);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10375_1926_1962(Microsoft.CodeAnalysis.CSharp.WhileBinder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.DoStatementSyntax
                scopeDesignator)
                {
                    var return_v = this_param.GetDeclaredLocalsForScope((Microsoft.CodeAnalysis.SyntaxNode)scopeDesignator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10375, 1926, 1962);
                    return return_v;
                }


                int
                f_10375_1898_1963(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10375, 1898, 1963);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10375_2012_2023(Microsoft.CodeAnalysis.CSharp.WhileBinder
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10375, 2012, 2023);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                f_10375_2042_2057(Microsoft.CodeAnalysis.CSharp.WhileBinder
                this_param)
                {
                    var return_v = this_param.BreakLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10375, 2042, 2057);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                f_10375_2059_2077(Microsoft.CodeAnalysis.CSharp.WhileBinder
                this_param)
                {
                    var return_v = this_param.ContinueLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10375, 2059, 2077);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDoStatement
                f_10375_1985_2078(Microsoft.CodeAnalysis.CSharp.Syntax.DoStatementSyntax
                syntax, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, Microsoft.CodeAnalysis.CSharp.BoundExpression
                condition, Microsoft.CodeAnalysis.CSharp.BoundStatement
                body, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                breakLabel, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                continueLabel)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundDoStatement((Microsoft.CodeAnalysis.SyntaxNode)syntax, locals, condition, body, breakLabel, continueLabel);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10375, 1985, 2078);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10375, 1528, 2090);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10375, 1528, 2090);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override ImmutableArray<LocalSymbol> BuildLocals()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10375, 2102, 2911);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10375, 2187, 2240);

                var
                locals = f_10375_2200_2239()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10375, 2254, 2281);

                ExpressionSyntax
                condition
                = default(ExpressionSyntax);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10375, 2297, 2755);

                switch (f_10375_2305_2319(_syntax))
                {

                    case SyntaxKind.WhileStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10375, 2297, 2755);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10375, 2406, 2460);

                        condition = f_10375_2418_2459(((WhileStatementSyntax)_syntax));
                        DynAbs.Tracing.TraceSender.TraceBreak(10375, 2482, 2488);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10375, 2297, 2755);

                    case SyntaxKind.DoStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10375, 2297, 2755);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10375, 2556, 2607);

                        condition = f_10375_2568_2606(((DoStatementSyntax)_syntax));
                        DynAbs.Tracing.TraceSender.TraceBreak(10375, 2629, 2635);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10375, 2297, 2755);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10375, 2297, 2755);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10375, 2683, 2740);

                        throw f_10375_2689_2739(f_10375_2724_2738(_syntax));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10375, 2297, 2755);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10375, 2771, 2851);

                f_10375_2771_2850(this, locals, node: condition);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10375, 2865, 2900);

                return f_10375_2872_2899(locals);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10375, 2102, 2911);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10375_2200_2239()
                {
                    var return_v = ArrayBuilder<LocalSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10375, 2200, 2239);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10375_2305_2319(Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10375, 2305, 2319);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10375_2418_2459(Microsoft.CodeAnalysis.CSharp.Syntax.WhileStatementSyntax
                this_param)
                {
                    var return_v = this_param.Condition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10375, 2418, 2459);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10375_2568_2606(Microsoft.CodeAnalysis.CSharp.Syntax.DoStatementSyntax
                this_param)
                {
                    var return_v = this_param.Condition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10375, 2568, 2606);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10375_2724_2738(Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10375, 2724, 2738);
                    return return_v;
                }


                System.Exception
                f_10375_2689_2739(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10375, 2689, 2739);
                    return return_v;
                }


                int
                f_10375_2771_2850(Microsoft.CodeAnalysis.CSharp.WhileBinder
                scopeBinder, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                builder, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node)
                {
                    ExpressionVariableFinder.FindExpressionVariables((Microsoft.CodeAnalysis.CSharp.Binder)scopeBinder, builder, node: (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10375, 2771, 2850);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10375_2872_2899(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10375, 2872, 2899);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10375, 2102, 2911);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10375, 2102, 2911);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ImmutableArray<LocalSymbol> GetDeclaredLocalsForScope(SyntaxNode scopeDesignator)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10375, 2923, 3209);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10375, 3047, 3145) || true) && (_syntax == scopeDesignator)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10375, 3047, 3145);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10375, 3111, 3130);

                    return f_10375_3118_3129(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10375, 3047, 3145);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10375, 3161, 3198);

                throw f_10375_3167_3197();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10375, 2923, 3209);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10375_3118_3129(Microsoft.CodeAnalysis.CSharp.WhileBinder
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10375, 3118, 3129);
                    return return_v;
                }


                System.Exception
                f_10375_3167_3197()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10375, 3167, 3197);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10375, 2923, 3209);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10375, 2923, 3209);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ImmutableArray<LocalFunctionSymbol> GetDeclaredLocalFunctionsForScope(CSharpSyntaxNode scopeDesignator)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10375, 3221, 3415);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10375, 3367, 3404);

                throw f_10375_3373_3403();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10375, 3221, 3415);

                System.Exception
                f_10375_3373_3403()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10375, 3373, 3403);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10375, 3221, 3415);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10375, 3221, 3415);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override SyntaxNode ScopeDesignator
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10375, 3496, 3562);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10375, 3532, 3547);

                    return _syntax;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10375, 3496, 3562);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10375, 3427, 3573);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10375, 3427, 3573);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static WhileBinder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10375, 540, 3580);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10375, 540, 3580);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10375, 540, 3580);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10375, 540, 3580);

        bool
        f_10375_804_844(Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
        node, Microsoft.CodeAnalysis.CSharp.SyntaxKind
        kind)
        {
            var return_v = node.IsKind(kind);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10375, 804, 844);
            return return_v;
        }


        bool
        f_10375_848_885(Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
        node, Microsoft.CodeAnalysis.CSharp.SyntaxKind
        kind)
        {
            var return_v = node.IsKind(kind);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10375, 848, 885);
            return return_v;
        }


        int
        f_10375_772_887(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10375, 772, 887);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Binder
        f_10375_737_746_C(Microsoft.CodeAnalysis.CSharp.Binder
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10375, 656, 930);
            return return_v;
        }

    }
}
