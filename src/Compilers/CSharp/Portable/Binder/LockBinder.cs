// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Diagnostics;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed class LockBinder : LockOrUsingBinder
    {
        private readonly LockStatementSyntax _syntax;

        public LockBinder(Binder enclosing, LockStatementSyntax syntax)
        : base(f_10351_684_693_C(enclosing))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10351, 600, 747);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10351, 580, 587);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10351, 719, 736);

                _syntax = syntax;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10351, 600, 747);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10351, 600, 747);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10351, 600, 747);
            }
        }

        protected override ExpressionSyntax TargetExpressionSyntax
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10351, 842, 919);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10351, 878, 904);

                    return f_10351_885_903(_syntax);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10351, 842, 919);

                    Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                    f_10351_885_903(Microsoft.CodeAnalysis.CSharp.Syntax.LockStatementSyntax
                    this_param)
                    {
                        var return_v = this_param.Expression;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10351, 885, 903);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10351, 759, 930);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10351, 759, 930);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override BoundStatement BindLockStatementParts(DiagnosticBag diagnostics, Binder originalBinder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10351, 942, 2357);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10351, 1218, 1271);

                ExpressionSyntax
                exprSyntax = f_10351_1248_1270()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10351, 1285, 1358);

                BoundExpression
                expr = f_10351_1308_1357(this, diagnostics, originalBinder)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10351, 1372, 1404);

                TypeSymbol
                exprType = f_10351_1394_1403(expr)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10351, 1420, 1443);

                bool
                hasErrors = false
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10351, 1459, 2098) || true) && ((object)exprType == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10351, 1459, 2098);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10351, 1521, 1814) || true) && (f_10351_1525_1543(expr) != f_10351_1547_1565() || (DynAbs.Tracing.TraceSender.Expression_False(10351, 1525, 1601) || f_10351_1569_1601(f_10351_1569_1580())))
                    ) // Dev10 allows the null literal.

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10351, 1521, 1814);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10351, 1677, 1756);

                        f_10351_1677_1755(diagnostics, ErrorCode.ERR_LockNeedsReference, exprSyntax, f_10351_1742_1754(expr));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10351, 1778, 1795);

                        hasErrors = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10351, 1521, 1814);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10351, 1459, 2098);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10351, 1459, 2098);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10351, 1848, 2098) || true) && (f_10351_1852_1877_M(!exprType.IsReferenceType) && (DynAbs.Tracing.TraceSender.Expression_True(10351, 1852, 1939) && (f_10351_1882_1902(exprType) || (DynAbs.Tracing.TraceSender.Expression_False(10351, 1882, 1938) || f_10351_1906_1938(f_10351_1906_1917())))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10351, 1848, 2098);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10351, 1973, 2048);

                        f_10351_1973_2047(diagnostics, ErrorCode.ERR_LockNeedsReference, exprSyntax, exprType);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10351, 2066, 2083);

                        hasErrors = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10351, 1848, 2098);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10351, 1459, 2098);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10351, 2114, 2213);

                BoundStatement
                stmt = f_10351_2136_2212(originalBinder, f_10351_2181_2198(_syntax), diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10351, 2227, 2270);

                f_10351_2227_2269(this.Locals.IsDefaultOrEmpty);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10351, 2284, 2346);

                return f_10351_2291_2345(_syntax, expr, stmt, hasErrors);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10351, 942, 2357);

                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10351_1248_1270()
                {
                    var return_v = TargetExpressionSyntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10351, 1248, 1270);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10351_1308_1357(Microsoft.CodeAnalysis.CSharp.LockBinder
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Binder
                originalBinder)
                {
                    var return_v = this_param.BindTargetExpression(diagnostics, originalBinder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10351, 1308, 1357);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10351_1394_1403(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10351, 1394, 1403);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10351_1525_1543(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10351, 1525, 1543);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10351_1547_1565()
                {
                    var return_v = ConstantValue.Null;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10351, 1547, 1565);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10351_1569_1580()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10351, 1569, 1580);
                    return return_v;
                }


                bool
                f_10351_1569_1601(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.FeatureStrictEnabled;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10351, 1569, 1601);
                    return return_v;
                }


                object
                f_10351_1742_1754(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Display;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10351, 1742, 1754);
                    return return_v;
                }


                int
                f_10351_1677_1755(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                syntax, params object[]
                args)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10351, 1677, 1755);
                    return 0;
                }


                bool
                f_10351_1852_1877_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10351, 1852, 1877);
                    return return_v;
                }


                bool
                f_10351_1882_1902(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsValueType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10351, 1882, 1902);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10351_1906_1917()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10351, 1906, 1917);
                    return return_v;
                }


                bool
                f_10351_1906_1938(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.FeatureStrictEnabled;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10351, 1906, 1938);
                    return return_v;
                }


                int
                f_10351_1973_2047(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                syntax, params object[]
                args)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10351, 1973, 2047);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                f_10351_2181_2198(Microsoft.CodeAnalysis.CSharp.Syntax.LockStatementSyntax
                this_param)
                {
                    var return_v = this_param.Statement;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10351, 2181, 2198);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10351_2136_2212(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindPossibleEmbeddedStatement(node, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10351, 2136, 2212);
                    return return_v;
                }


                int
                f_10351_2227_2269(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10351, 2227, 2269);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLockStatement
                f_10351_2291_2345(Microsoft.CodeAnalysis.CSharp.Syntax.LockStatementSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                argument, Microsoft.CodeAnalysis.CSharp.BoundStatement
                body, bool
                hasErrors)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundLockStatement((Microsoft.CodeAnalysis.SyntaxNode)syntax, argument, body, hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10351, 2291, 2345);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10351, 942, 2357);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10351, 942, 2357);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static LockBinder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10351, 474, 2364);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10351, 474, 2364);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10351, 474, 2364);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10351, 474, 2364);

        static Microsoft.CodeAnalysis.CSharp.Binder
        f_10351_684_693_C(Microsoft.CodeAnalysis.CSharp.Binder
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10351, 600, 747);
            return return_v;
        }

    }
}
