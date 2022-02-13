// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal partial class Binder
    {
        private BoundExpression BindAwait(AwaitExpressionSyntax node, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10301, 691, 966);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 804, 891);

                BoundExpression
                expression = f_10301_833_890(this, f_10301_861_876(node), diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 907, 955);

                return f_10301_914_954(this, expression, node, diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10301, 691, 966);

                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10301_861_876(Microsoft.CodeAnalysis.CSharp.Syntax.AwaitExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10301, 861, 876);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10301_833_890(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindRValueWithoutTargetType(node, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10301, 833, 890);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundAwaitExpression
                f_10301_914_954(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.CSharp.Syntax.AwaitExpressionSyntax
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindAwait(expression, (Microsoft.CodeAnalysis.SyntaxNode)node, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10301, 914, 954);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10301, 691, 966);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10301, 691, 966);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundAwaitExpression BindAwait(BoundExpression expression, SyntaxNode node, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10301, 978, 2101);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 1113, 1136);

                bool
                hasErrors = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 1150, 1282);

                var
                placeholder = f_10301_1168_1281(expression.Syntax, f_10301_1222_1263(expression, f_10301_1247_1262()), f_10301_1265_1280(expression))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 1298, 1373);

                f_10301_1298_1372(this, node, f_10301_1330_1343(node), diagnostics, ref hasErrors);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 1387, 1486);

                var
                info = f_10301_1398_1485(this, placeholder, node, diagnostics, ref hasErrors, expressionOpt: expression)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 1865, 1986);

                TypeSymbol
                awaitExpressionType = f_10301_1898_1924_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10301_1898_1912(info), 10301, 1898, 1924)?.ReturnType) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?>(10301, 1898, 1985) ?? ((DynAbs.Tracing.TraceSender.Conditional_F1(10301, 1929, 1938) || ((hasErrors && DynAbs.Tracing.TraceSender.Conditional_F2(10301, 1941, 1958)) || DynAbs.Tracing.TraceSender.Conditional_F3(10301, 1961, 1984))) ? f_10301_1941_1958(this) : f_10301_1961_1984(f_10301_1961_1972())))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 2002, 2090);

                return f_10301_2009_2089(node, expression, info, awaitExpressionType, hasErrors);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10301, 978, 2101);

                uint
                f_10301_1247_1262()
                {
                    var return_v = LocalScopeDepth;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10301, 1247, 1262);
                    return return_v;
                }


                uint
                f_10301_1222_1263(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, uint
                scopeOfTheContainingExpression)
                {
                    var return_v = GetValEscape(expr, scopeOfTheContainingExpression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10301, 1222, 1263);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10301_1265_1280(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10301, 1265, 1280);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundAwaitableValuePlaceholder
                f_10301_1168_1281(Microsoft.CodeAnalysis.SyntaxNode
                syntax, uint
                valEscape, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundAwaitableValuePlaceholder(syntax, valEscape, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10301, 1168, 1281);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10301_1330_1343(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10301, 1330, 1343);
                    return return_v;
                }


                int
                f_10301_1298_1372(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.Location
                location, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, ref bool
                hasErrors)
                {
                    this_param.ReportBadAwaitDiagnostics(node, location, diagnostics, ref hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10301, 1298, 1372);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundAwaitableInfo
                f_10301_1398_1485(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundAwaitableValuePlaceholder
                placeholder, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, ref bool
                hasErrors, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expressionOpt)
                {
                    var return_v = this_param.BindAwaitInfo(placeholder, node, diagnostics, ref hasErrors, expressionOpt: expressionOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10301, 1398, 1485);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10301_1898_1912(Microsoft.CodeAnalysis.CSharp.BoundAwaitableInfo
                this_param)
                {
                    var return_v = this_param.GetResult;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10301, 1898, 1912);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10301_1898_1924_M(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10301, 1898, 1924);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10301_1941_1958(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.CreateErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10301, 1941, 1958);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10301_1961_1972()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10301, 1961, 1972);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10301_1961_1984(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.DynamicType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10301, 1961, 1984);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundAwaitExpression
                f_10301_2009_2089(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.CSharp.BoundAwaitableInfo
                awaitableInfo, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, bool
                hasErrors)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundAwaitExpression(syntax, expression, awaitableInfo, type, hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10301, 2009, 2089);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10301, 978, 2101);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10301, 978, 2101);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void ReportBadAwaitDiagnostics(SyntaxNode node, Location location, DiagnosticBag diagnostics, ref bool hasErrors)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10301, 2113, 2412);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 2260, 2323);

                hasErrors |= f_10301_2273_2322(this, location, diagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 2337, 2401);

                hasErrors |= f_10301_2350_2400(this, node, location, diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10301, 2113, 2412);

                bool
                f_10301_2273_2322(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.Location
                location, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.ReportBadAwaitWithoutAsync(location, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10301, 2273, 2322);
                    return return_v;
                }


                bool
                f_10301_2350_2400(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.Location
                location, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.ReportBadAwaitContext(node, location, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10301, 2350, 2400);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10301, 2113, 2412);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10301, 2113, 2412);
            }
        }

        internal BoundAwaitableInfo BindAwaitInfo(BoundAwaitableValuePlaceholder placeholder, SyntaxNode node, DiagnosticBag diagnostics, ref bool hasErrors, BoundExpression? expressionOpt = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10301, 2424, 3306);
                bool isDynamic = default(bool);
                Microsoft.CodeAnalysis.CSharp.BoundExpression? getAwaiter = default(Microsoft.CodeAnalysis.CSharp.BoundExpression?);
                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol? isCompleted = default(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol?);
                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol? getResult = default(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 2637, 3057);

                bool
                hasGetAwaitableErrors = !f_10301_2667_3056(this, expressionOpt ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.BoundExpression?>(10301, 2712, 2740) ?? placeholder), placeholder, out isDynamic, out getAwaiter, out isCompleted, out getResult, getAwaiterGetResultCall: out _, node, diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 3071, 3106);

                hasErrors |= hasGetAwaitableErrors;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 3122, 3295);

                return new BoundAwaitableInfo(node, placeholder, isDynamic: isDynamic, getAwaiter, isCompleted, getResult, hasErrors: hasGetAwaitableErrors) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10301, 3129, 3294) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10301, 2424, 3306);

                bool
                f_10301_2667_3056(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.CSharp.BoundAwaitableValuePlaceholder
                getAwaiterArgument, out bool
                isDynamic, out Microsoft.CodeAnalysis.CSharp.BoundExpression?
                getAwaiter, out Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol?
                isCompleted, out Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                getResult, out Microsoft.CodeAnalysis.CSharp.BoundExpression?
                getAwaiterGetResultCall, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.GetAwaitableExpressionInfo(expression, (Microsoft.CodeAnalysis.CSharp.BoundExpression)getAwaiterArgument, out isDynamic, out getAwaiter, out isCompleted, out getResult, out getAwaiterGetResultCall, node, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10301, 2667, 3056);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10301, 2424, 3306);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10301, 2424, 3306);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool CouldBeAwaited(BoundExpression expression)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10301, 3472, 5314);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 3871, 3970) || true) && (f_10301_3875_3890(expression) != BoundKind.Call)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10301, 3871, 3970);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 3942, 3955);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10301, 3871, 3970);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 3986, 4013);

                var
                type = f_10301_3997_4012(expression)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 4027, 4184) || true) && ((type is null) || (DynAbs.Tracing.TraceSender.Expression_False(10301, 4031, 4082) || f_10301_4066_4082(type)) || (DynAbs.Tracing.TraceSender.Expression_False(10301, 4031, 4122) || (f_10301_4104_4121(type))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10301, 4027, 4184);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 4156, 4169);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10301, 4027, 4184);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 4200, 4233);

                var
                call = (BoundCall)expression
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 4308, 4423) || true) && ((object)f_10301_4320_4331(call) != null && (DynAbs.Tracing.TraceSender.Expression_True(10301, 4312, 4362) && f_10301_4343_4362(f_10301_4343_4354(call))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10301, 4308, 4423);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 4396, 4408);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10301, 4308, 4423);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 4513, 4618) || true) && (f_10301_4517_4557(this, f_10301_4547_4556(call)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10301, 4513, 4618);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 4591, 4603);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10301, 4513, 4618);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 4762, 4831);

                var
                containingMethod = f_10301_4785_4814(this) as MethodSymbol
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 4845, 4964) || true) && (containingMethod is null || (DynAbs.Tracing.TraceSender.Expression_False(10301, 4849, 4902) || f_10301_4877_4902_M(!containingMethod.IsAsync)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10301, 4845, 4964);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 4936, 4949);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10301, 4845, 4964);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 4980, 5065) || true) && (f_10301_4984_5003())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10301, 4980, 5065);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 5037, 5050);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10301, 4980, 5065);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 5081, 5131);

                var
                fakeDiagnostics = f_10301_5103_5130()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 5145, 5220);

                var
                boundAwait = f_10301_5162_5219(this, expression, expression.Syntax, fakeDiagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 5234, 5257);

                f_10301_5234_5256(fakeDiagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 5271, 5303);

                return f_10301_5278_5302_M(!boundAwait.HasAnyErrors);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10301, 3472, 5314);

                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10301_3875_3890(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10301, 3875, 3890);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10301_3997_4012(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10301, 3997, 4012);
                    return return_v;
                }


                bool
                f_10301_4066_4082(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsDynamic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10301, 4066, 4082);
                    return return_v;
                }


                bool
                f_10301_4104_4121(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsVoidType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10301, 4104, 4121);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10301_4320_4331(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.Method;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10301, 4320, 4331);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10301_4343_4354(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.Method;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10301, 4343, 4354);
                    return return_v;
                }


                bool
                f_10301_4343_4362(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsAsync;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10301, 4343, 4362);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10301_4547_4556(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10301, 4547, 4556);
                    return return_v;
                }


                bool
                f_10301_4517_4557(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.ImplementsWinRTAsyncInterface(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10301, 4517, 4557);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10301_4785_4814(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.ContainingMemberOrLambda;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10301, 4785, 4814);
                    return return_v;
                }


                bool
                f_10301_4877_4902_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10301, 4877, 4902);
                    return return_v;
                }


                bool
                f_10301_4984_5003()
                {
                    var return_v = ContextForbidsAwait;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10301, 4984, 5003);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10301_5103_5130()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10301, 5103, 5130);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundAwaitExpression
                f_10301_5162_5219(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindAwait(expression, node, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10301, 5162, 5219);
                    return return_v;
                }


                int
                f_10301_5234_5256(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10301, 5234, 5256);
                    return 0;
                }


                bool
                f_10301_5278_5302_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10301, 5278, 5302);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10301, 3472, 5314);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10301, 3472, 5314);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool ContextForbidsAwait
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10301, 5618, 5791);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 5654, 5776);

                    return f_10301_5661_5707(this.Flags, BinderFlags.InCatchFilter) || (DynAbs.Tracing.TraceSender.Expression_False(10301, 5661, 5775) || f_10301_5732_5775(this.Flags, BinderFlags.InLockBody));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10301, 5618, 5791);

                    bool
                    f_10301_5661_5707(Microsoft.CodeAnalysis.CSharp.BinderFlags
                    self, Microsoft.CodeAnalysis.CSharp.BinderFlags
                    other)
                    {
                        var return_v = self.Includes(other);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10301, 5661, 5707);
                        return return_v;
                    }


                    bool
                    f_10301_5732_5775(Microsoft.CodeAnalysis.CSharp.BinderFlags
                    self, Microsoft.CodeAnalysis.CSharp.BinderFlags
                    other)
                    {
                        var return_v = self.Includes(other);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10301, 5732, 5775);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10301, 5561, 5802);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10301, 5561, 5802);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        [SuppressMessage("Style", "VSTHRD200:Use \"Async\" suffix for async methods", Justification = "'await without async' refers to the error scenario.")]
        private bool ReportBadAwaitWithoutAsync(Location location, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10301, 6022, 8589);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 6291, 6319);

                DiagnosticInfo?
                info = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 6333, 6394);

                var
                containingMemberOrLambda = f_10301_6364_6393(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 6408, 8360) || true) && (containingMemberOrLambda is object)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10301, 6408, 8360);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 6480, 8345);

                    switch (f_10301_6488_6517(containingMemberOrLambda))
                    {

                        case SymbolKind.Field:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10301, 6480, 8345);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 6607, 7120) || true) && (f_10301_6611_6664(f_10301_6611_6650(containingMemberOrLambda)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10301, 6607, 7120);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 6722, 7093) || true) && (f_10301_6726_6774(((FieldSymbol)containingMemberOrLambda)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10301, 6722, 7093);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 6840, 6919);

                                    info = f_10301_6847_6918(ErrorCode.ERR_BadAwaitInStaticVariableInitializer);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10301, 6722, 7093);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10301, 6722, 7093);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 7049, 7062);

                                    return false;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10301, 6722, 7093);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10301, 6607, 7120);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(10301, 7146, 7152);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10301, 6480, 8345);

                        case SymbolKind.Method:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10301, 6480, 8345);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 7223, 7275);

                            var
                            method = (MethodSymbol)containingMemberOrLambda
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 7301, 7417) || true) && (f_10301_7305_7319(method))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10301, 7301, 7417);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 7377, 7390);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10301, 7301, 7417);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 7443, 8294) || true) && (f_10301_7447_7464(method) == MethodKind.AnonymousFunction)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10301, 7443, 8294);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 7554, 7908);

                                info = (DynAbs.Tracing.TraceSender.Conditional_F1(10301, 7561, 7588) || ((f_10301_7561_7588(method) && DynAbs.Tracing.TraceSender.Conditional_F2(10301, 7713, 7764)) || DynAbs.Tracing.TraceSender.Conditional_F3(10301, 7800, 7907))) ? f_10301_7713_7764(ErrorCode.ERR_BadAwaitInQuery) : f_10301_7800_7907(ErrorCode.ERR_BadAwaitWithoutAsyncLambda, f_10301_7863_7906(f_10301_7863_7895(((LambdaSymbol)method))));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10301, 7443, 8294);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10301, 7443, 8294);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 8022, 8267);

                                info = (DynAbs.Tracing.TraceSender.Conditional_F1(10301, 8029, 8047) || ((f_10301_8029_8047(method) && DynAbs.Tracing.TraceSender.Conditional_F2(10301, 8083, 8149)) || DynAbs.Tracing.TraceSender.Conditional_F3(10301, 8185, 8266))) ? f_10301_8083_8149(ErrorCode.ERR_BadAwaitWithoutVoidAsyncMethod) : f_10301_8185_8266(ErrorCode.ERR_BadAwaitWithoutAsyncMethod, f_10301_8248_8265(method));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10301, 7443, 8294);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(10301, 8320, 8326);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10301, 6480, 8345);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10301, 6408, 8360);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 8374, 8503) || true) && (info == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10301, 8374, 8503);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 8424, 8488);

                    info = f_10301_8431_8487(ErrorCode.ERR_BadAwaitWithoutAsync);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10301, 8374, 8503);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 8517, 8552);

                f_10301_8517_8551(diagnostics, info, location);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 8566, 8578);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10301, 6022, 8589);

                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10301_6364_6393(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.ContainingMemberOrLambda;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10301, 6364, 6393);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10301_6488_6517(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10301, 6488, 6517);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10301_6611_6650(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10301, 6611, 6650);
                    return return_v;
                }


                bool
                f_10301_6611_6664(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsScriptClass;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10301, 6611, 6664);
                    return return_v;
                }


                bool
                f_10301_6726_6774(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10301, 6726, 6774);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10301_6847_6918(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10301, 6847, 6918);
                    return return_v;
                }


                bool
                f_10301_7305_7319(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsAsync;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10301, 7305, 7319);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10301_7447_7464(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10301, 7447, 7464);
                    return return_v;
                }


                bool
                f_10301_7561_7588(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsImplicitlyDeclared;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10301, 7561, 7588);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10301_7713_7764(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10301, 7713, 7764);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MessageID
                f_10301_7863_7895(Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                this_param)
                {
                    var return_v = this_param.MessageID;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10301, 7863, 7895);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument
                f_10301_7863_7906(Microsoft.CodeAnalysis.CSharp.MessageID
                id)
                {
                    var return_v = id.Localize();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10301, 7863, 7906);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10301_7800_7907(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10301, 7800, 7907);
                    return return_v;
                }


                bool
                f_10301_8029_8047(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnsVoid;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10301, 8029, 8047);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10301_8083_8149(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10301, 8083, 8149);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10301_8248_8265(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10301, 8248, 8265);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10301_8185_8266(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10301, 8185, 8266);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10301_8431_8487(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10301, 8431, 8487);
                    return return_v;
                }


                int
                f_10301_8517_8551(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.DiagnosticInfo
                info, Microsoft.CodeAnalysis.Location
                location)
                {
                    Error(diagnostics, info, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10301, 8517, 8551);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10301, 6022, 8589);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10301, 6022, 8589);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool ReportBadAwaitContext(SyntaxNode node, Location location, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10301, 8808, 10892);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 8930, 10881) || true) && (f_10301_8934_8953(this) && (DynAbs.Tracing.TraceSender.Expression_True(10301, 8934, 9016) && !f_10301_8958_9016(this.Flags, BinderFlags.AllowAwaitInUnsafeContext)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10301, 8930, 10881);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 9050, 9115);

                    f_10301_9050_9114(diagnostics, ErrorCode.ERR_AwaitInUnsafeContext, location);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 9133, 9145);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10301, 8930, 10881);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10301, 8930, 10881);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 9179, 10881) || true) && (f_10301_9183_9226(this.Flags, BinderFlags.InLockBody))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10301, 9179, 10881);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 9260, 9319);

                        f_10301_9260_9318(diagnostics, ErrorCode.ERR_BadAwaitInLock, location);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 9337, 9349);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10301, 9179, 10881);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10301, 9179, 10881);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 9383, 10881) || true) && (f_10301_9387_9433(this.Flags, BinderFlags.InCatchFilter))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10301, 9383, 10881);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 9467, 9533);

                            f_10301_9467_9532(diagnostics, ErrorCode.ERR_BadAwaitInCatchFilter, location);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 9551, 9563);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10301, 9383, 10881);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10301, 9383, 10881);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 9597, 10881) || true) && (f_10301_9601_9648(this.Flags, BinderFlags.InFinallyBlock) && (DynAbs.Tracing.TraceSender.Expression_True(10301, 9601, 9864) &&                // LAFHIS
                                                                                                                                                                                                                                                                //(node.SyntaxTree as CSharpSyntaxTree)?.Options?.IsFeatureEnabled(MessageID.IDS_AwaitInCatchAndFinally) == false
                                            (f_10301_9828_9843(node) is CSharpSyntaxTree)) && (DynAbs.Tracing.TraceSender.Expression_True(10301, 9601, 9936) && f_10301_9885_9928(((CSharpSyntaxTree)f_10301_9904_9919(node))) != null) && (DynAbs.Tracing.TraceSender.Expression_True(10301, 9601, 10064) && f_10301_9957_10055(f_10301_9957_10000(((CSharpSyntaxTree)f_10301_9976_9991(node))), MessageID.IDS_AwaitInCatchAndFinally) == false))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10301, 9597, 10881);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 10098, 10160);

                                f_10301_10098_10159(diagnostics, ErrorCode.ERR_BadAwaitInFinally, location);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 10178, 10190);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10301, 9597, 10881);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10301, 9597, 10881);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 10224, 10881) || true) && (f_10301_10228_10273(this.Flags, BinderFlags.InCatchBlock) && (DynAbs.Tracing.TraceSender.Expression_True(10301, 10228, 10463) &&                //(node.SyntaxTree as CSharpSyntaxTree)?.Options?.IsFeatureEnabled(MessageID.IDS_AwaitInCatchAndFinally) == false)
                                                (f_10301_10427_10442(node) is CSharpSyntaxTree)) && (DynAbs.Tracing.TraceSender.Expression_True(10301, 10228, 10535) && f_10301_10484_10527(((CSharpSyntaxTree)f_10301_10503_10518(node))) != null) && (DynAbs.Tracing.TraceSender.Expression_True(10301, 10228, 10663) && f_10301_10556_10654(f_10301_10556_10599(((CSharpSyntaxTree)f_10301_10575_10590(node))), MessageID.IDS_AwaitInCatchAndFinally) == false))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10301, 10224, 10881);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 10697, 10757);

                                    f_10301_10697_10756(diagnostics, ErrorCode.ERR_BadAwaitInCatch, location);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 10775, 10787);

                                    return true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10301, 10224, 10881);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10301, 10224, 10881);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 10853, 10866);

                                    return false;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10301, 10224, 10881);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10301, 9597, 10881);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10301, 9383, 10881);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10301, 9179, 10881);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10301, 8930, 10881);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10301, 8808, 10892);

                bool
                f_10301_8934_8953(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.InUnsafeRegion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10301, 8934, 8953);
                    return return_v;
                }


                bool
                f_10301_8958_9016(Microsoft.CodeAnalysis.CSharp.BinderFlags
                self, Microsoft.CodeAnalysis.CSharp.BinderFlags
                other)
                {
                    var return_v = self.Includes(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10301, 8958, 9016);
                    return return_v;
                }


                int
                f_10301_9050_9114(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    Error(diagnostics, code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10301, 9050, 9114);
                    return 0;
                }


                bool
                f_10301_9183_9226(Microsoft.CodeAnalysis.CSharp.BinderFlags
                self, Microsoft.CodeAnalysis.CSharp.BinderFlags
                other)
                {
                    var return_v = self.Includes(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10301, 9183, 9226);
                    return return_v;
                }


                int
                f_10301_9260_9318(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    Error(diagnostics, code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10301, 9260, 9318);
                    return 0;
                }


                bool
                f_10301_9387_9433(Microsoft.CodeAnalysis.CSharp.BinderFlags
                self, Microsoft.CodeAnalysis.CSharp.BinderFlags
                other)
                {
                    var return_v = self.Includes(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10301, 9387, 9433);
                    return return_v;
                }


                int
                f_10301_9467_9532(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    Error(diagnostics, code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10301, 9467, 9532);
                    return 0;
                }


                bool
                f_10301_9601_9648(Microsoft.CodeAnalysis.CSharp.BinderFlags
                self, Microsoft.CodeAnalysis.CSharp.BinderFlags
                other)
                {
                    var return_v = self.Includes(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10301, 9601, 9648);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10301_9828_9843(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10301, 9828, 9843);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10301_9904_9919(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10301, 9904, 9919);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                f_10301_9885_9928(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10301, 9885, 9928);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10301_9976_9991(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10301, 9976, 9991);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                f_10301_9957_10000(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10301, 9957, 10000);
                    return return_v;
                }


                bool
                f_10301_9957_10055(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                this_param, Microsoft.CodeAnalysis.CSharp.MessageID
                feature)
                {
                    var return_v = this_param.IsFeatureEnabled(feature);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10301, 9957, 10055);
                    return return_v;
                }


                int
                f_10301_10098_10159(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    Error(diagnostics, code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10301, 10098, 10159);
                    return 0;
                }


                bool
                f_10301_10228_10273(Microsoft.CodeAnalysis.CSharp.BinderFlags
                self, Microsoft.CodeAnalysis.CSharp.BinderFlags
                other)
                {
                    var return_v = self.Includes(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10301, 10228, 10273);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10301_10427_10442(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10301, 10427, 10442);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10301_10503_10518(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10301, 10503, 10518);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                f_10301_10484_10527(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10301, 10484, 10527);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10301_10575_10590(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10301, 10575, 10590);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                f_10301_10556_10599(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10301, 10556, 10599);
                    return return_v;
                }


                bool
                f_10301_10556_10654(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                this_param, Microsoft.CodeAnalysis.CSharp.MessageID
                feature)
                {
                    var return_v = this_param.IsFeatureEnabled(feature);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10301, 10556, 10654);
                    return return_v;
                }


                int
                f_10301_10697_10756(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    Error(diagnostics, code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10301, 10697, 10756);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10301, 8808, 10892);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10301, 8808, 10892);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool GetAwaitableExpressionInfo(
                    BoundExpression expression,
                    out BoundExpression? getAwaiterGetResultCall,
                    SyntaxNode node,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10301, 11149, 11530);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 11385, 11519);

                return f_10301_11392_11518(this, expression, expression, out _, out _, out _, out _, out getAwaiterGetResultCall, node, diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10301, 11149, 11530);

                bool
                f_10301_11392_11518(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.CSharp.BoundExpression
                getAwaiterArgument, out bool
                isDynamic, out Microsoft.CodeAnalysis.CSharp.BoundExpression?
                getAwaiter, out Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol?
                isCompleted, out Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                getResult, out Microsoft.CodeAnalysis.CSharp.BoundExpression?
                getAwaiterGetResultCall, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.GetAwaitableExpressionInfo(expression, getAwaiterArgument, out isDynamic, out getAwaiter, out isCompleted, out getResult, out getAwaiterGetResultCall, node, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10301, 11392, 11518);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10301, 11149, 11530);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10301, 11149, 11530);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool GetAwaitableExpressionInfo(
                    BoundExpression expression,
                    BoundExpression getAwaiterArgument,
                    out bool isDynamic,
                    out BoundExpression? getAwaiter,
                    out PropertySymbol? isCompleted,
                    out MethodSymbol? getResult,
                    out BoundExpression? getAwaiterGetResultCall,
                    SyntaxNode node,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10301, 11542, 13116);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 11993, 12103);

                f_10301_11993_12102(f_10301_12006_12101(f_10301_12024_12039(expression), f_10301_12041_12064(getAwaiterArgument), TypeCompareKind.ConsiderEverything));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 12119, 12137);

                isDynamic = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 12151, 12169);

                getAwaiter = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 12183, 12202);

                isCompleted = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 12216, 12233);

                getResult = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 12247, 12278);

                getAwaiterGetResultCall = null;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 12294, 12417) || true) && (!f_10301_12299_12355(expression, node, diagnostics))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10301, 12294, 12417);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 12389, 12402);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10301, 12294, 12417);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 12433, 12560) || true) && (f_10301_12437_12464(expression))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10301, 12433, 12560);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 12498, 12515);

                    isDynamic = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 12533, 12545);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10301, 12433, 12560);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 12576, 12717) || true) && (!f_10301_12581_12655(this, getAwaiterArgument, node, diagnostics, out getAwaiter))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10301, 12576, 12717);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 12689, 12702);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10301, 12576, 12717);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 12733, 12775);

                TypeSymbol
                awaiterType = getAwaiter.Type!
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 12789, 13105);

                return f_10301_12796_12885(this, awaiterType, node, expression.Type!, diagnostics, out isCompleted) && (DynAbs.Tracing.TraceSender.Expression_True(10301, 12796, 12972) && f_10301_12906_12972(this, awaiterType, node, diagnostics)) && (DynAbs.Tracing.TraceSender.Expression_True(10301, 12796, 13104) && f_10301_12993_13104(this, getAwaiter, node, expression.Type!, diagnostics, out getResult, out getAwaiterGetResultCall));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10301, 11542, 13116);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10301_12024_12039(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10301, 12024, 12039);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10301_12041_12064(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10301, 12041, 12064);
                    return return_v;
                }


                bool
                f_10301_12006_12101(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                left, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10301, 12006, 12101);
                    return return_v;
                }


                int
                f_10301_11993_12102(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10301, 11993, 12102);
                    return 0;
                }


                bool
                f_10301_12299_12355(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = ValidateAwaitedExpression(expression, node, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10301, 12299, 12355);
                    return return_v;
                }


                bool
                f_10301_12437_12464(Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = node.HasDynamicType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10301, 12437, 12464);
                    return return_v;
                }


                bool
                f_10301_12581_12655(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out Microsoft.CodeAnalysis.CSharp.BoundExpression?
                getAwaiterCall)
                {
                    var return_v = this_param.GetGetAwaiterMethod(expression, node, diagnostics, out getAwaiterCall);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10301, 12581, 12655);
                    return return_v;
                }


                bool
                f_10301_12796_12885(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                awaiterType, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                awaitedExpressionType, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol?
                isCompletedProperty)
                {
                    var return_v = this_param.GetIsCompletedProperty(awaiterType, node, awaitedExpressionType, diagnostics, out isCompletedProperty);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10301, 12796, 12885);
                    return return_v;
                }


                bool
                f_10301_12906_12972(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                awaiterType, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.AwaiterImplementsINotifyCompletion(awaiterType, node, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10301, 12906, 12972);
                    return return_v;
                }


                bool
                f_10301_12993_13104(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                awaiterExpression, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                awaitedExpressionType, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                getResultMethod, out Microsoft.CodeAnalysis.CSharp.BoundExpression?
                getAwaiterGetResultCall)
                {
                    var return_v = this_param.GetGetResultMethod(awaiterExpression, node, awaitedExpressionType, diagnostics, out getResultMethod, out getAwaiterGetResultCall);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10301, 12993, 13104);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10301, 11542, 13116);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10301, 11542, 13116);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool ValidateAwaitedExpression(BoundExpression expression, SyntaxNode node, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10301, 13261, 13811);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 13403, 13568) || true) && (f_10301_13407_13430(expression))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10301, 13403, 13568);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 13540, 13553);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10301, 13403, 13568);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 13584, 13772) || true) && (f_10301_13588_13603(expression) is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10301, 13584, 13772);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 13645, 13726);

                    f_10301_13645_13725(diagnostics, ErrorCode.ERR_BadAwaitArgIntrinsic, node, f_10301_13706_13724(expression));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 13744, 13757);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10301, 13584, 13772);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 13788, 13800);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10301, 13261, 13811);

                bool
                f_10301_13407_13430(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.HasAnyErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10301, 13407, 13430);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10301_13588_13603(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10301, 13588, 13603);
                    return return_v;
                }


                object
                f_10301_13706_13724(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Display;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10301, 13706, 13724);
                    return return_v;
                }


                int
                f_10301_13645_13725(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax, params object[]
                args)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10301, 13645, 13725);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10301, 13261, 13811);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10301, 13261, 13811);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool GetGetAwaiterMethod(BoundExpression expression, SyntaxNode node, DiagnosticBag diagnostics, [NotNullWhen(true)] out BoundExpression? getAwaiterCall)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10301, 14426, 16136);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 14612, 14658);

                f_10301_14612_14657(f_10301_14631_14646(expression) is object);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 14672, 14884) || true) && (f_10301_14676_14704(f_10301_14676_14691(expression)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10301, 14672, 14884);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 14738, 14798);

                    f_10301_14738_14797(diagnostics, ErrorCode.ERR_BadAwaitArgVoidCall, node);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 14816, 14838);

                    getAwaiterCall = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 14856, 14869);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10301, 14672, 14884);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 14900, 15045);

                getAwaiterCall = f_10301_14917_15044(this, node, expression, WellKnownMemberNames.GetAwaiter, ImmutableArray<BoundExpression>.Empty, diagnostics);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 15059, 15224) || true) && (f_10301_15063_15090(getAwaiterCall))
                ) // && !expression.HasAnyErrors?

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10301, 15059, 15224);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 15156, 15178);

                    getAwaiterCall = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 15196, 15209);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10301, 15059, 15224);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 15240, 15470) || true) && (f_10301_15244_15263(getAwaiterCall) != BoundKind.Call)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10301, 15240, 15470);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 15315, 15384);

                    f_10301_15315_15383(diagnostics, ErrorCode.ERR_BadAwaitArg, node, f_10301_15367_15382(expression));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 15402, 15424);

                    getAwaiterCall = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 15442, 15455);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10301, 15240, 15470);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 15486, 15544);

                var
                getAwaiterMethod = f_10301_15509_15543(((BoundCall)getAwaiterCall))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 15558, 16097) || true) && (getAwaiterMethod is ErrorMethodSymbol || (DynAbs.Tracing.TraceSender.Expression_False(10301, 15562, 15669) || f_10301_15620_15669(getAwaiterMethod)) || (DynAbs.Tracing.TraceSender.Expression_False(10301, 15562, 15827) || f_10301_15799_15827(getAwaiterMethod)))
                ) // If GetAwaiter returns void, don't bother checking that it returns an Awaiter.

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10301, 15558, 16097);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 15942, 16011);

                    f_10301_15942_16010(diagnostics, ErrorCode.ERR_BadAwaitArg, node, f_10301_15994_16009(expression));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 16029, 16051);

                    getAwaiterCall = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 16069, 16082);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10301, 15558, 16097);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 16113, 16125);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10301, 14426, 16136);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10301_14631_14646(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10301, 14631, 14646);
                    return return_v;
                }


                int
                f_10301_14612_14657(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10301, 14612, 14657);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10301_14676_14691(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10301, 14676, 14691);
                    return return_v;
                }


                bool
                f_10301_14676_14704(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsVoidType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10301, 14676, 14704);
                    return return_v;
                }


                int
                f_10301_14738_14797(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10301, 14738, 14797);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10301_14917_15044(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver, string
                methodName, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                args, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.MakeInvocationExpression(node, receiver, methodName, args, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10301, 14917, 15044);
                    return return_v;
                }


                bool
                f_10301_15063_15090(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.HasAnyErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10301, 15063, 15090);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10301_15244_15263(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10301, 15244, 15263);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10301_15367_15382(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10301, 15367, 15382);
                    return return_v;
                }


                int
                f_10301_15315_15383(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax, params object[]
                args)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10301, 15315, 15383);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10301_15509_15543(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.Method;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10301, 15509, 15543);
                    return return_v;
                }


                bool
                f_10301_15620_15669(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = HasOptionalOrVariableParameters(method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10301, 15620, 15669);
                    return return_v;
                }


                bool
                f_10301_15799_15827(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnsVoid;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10301, 15799, 15827);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10301_15994_16009(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10301, 15994, 16009);
                    return return_v;
                }


                int
                f_10301_15942_16010(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax, params object[]
                args)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10301, 15942, 16010);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10301, 14426, 16136);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10301, 14426, 16136);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool GetIsCompletedProperty(TypeSymbol awaiterType, SyntaxNode node, TypeSymbol awaitedExpressionType, DiagnosticBag diagnostics, [NotNullWhen(true)] out PropertySymbol? isCompletedProperty)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10301, 16431, 18118);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 16654, 16725);

                var
                receiver = f_10301_16669_16724(node, f_10301_16692_16710(), awaiterType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 16739, 16783);

                var
                name = WellKnownMemberNames.IsCompleted
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 16797, 17002);

                var
                qualified = f_10301_16813_17001(this, node, node, receiver, name, 0, default(SeparatedSyntaxList<TypeSyntax>), default(ImmutableArray<TypeWithAnnotations>), invoked: false, indexed: false, diagnostics)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 17016, 17149) || true) && (f_10301_17020_17042(qualified))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10301, 17016, 17149);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 17076, 17103);

                    isCompletedProperty = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 17121, 17134);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10301, 17016, 17149);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 17165, 17436) || true) && (f_10301_17169_17183(qualified) != BoundKind.PropertyAccess)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10301, 17165, 17436);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 17245, 17345);

                    f_10301_17245_17344(diagnostics, ErrorCode.ERR_NoSuchMember, node, awaiterType, WellKnownMemberNames.IsCompleted);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 17363, 17390);

                    isCompletedProperty = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 17408, 17421);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10301, 17165, 17436);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 17452, 17522);

                isCompletedProperty = f_10301_17474_17521(((BoundPropertyAccess)qualified));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 17536, 17774) || true) && (f_10301_17540_17571(isCompletedProperty))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10301, 17536, 17774);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 17605, 17683);

                    f_10301_17605_17682(diagnostics, ErrorCode.ERR_PropertyLacksGet, node, isCompletedProperty);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 17701, 17728);

                    isCompletedProperty = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 17746, 17759);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10301, 17536, 17774);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 17790, 18079) || true) && (f_10301_17794_17830(f_10301_17794_17818(isCompletedProperty)) != SpecialType.System_Boolean)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10301, 17790, 18079);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 17894, 17988);

                    f_10301_17894_17987(diagnostics, ErrorCode.ERR_BadAwaiterPattern, node, awaiterType, awaitedExpressionType);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 18006, 18033);

                    isCompletedProperty = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 18051, 18064);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10301, 17790, 18079);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 18095, 18107);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10301, 16431, 18118);

                Microsoft.CodeAnalysis.ConstantValue
                f_10301_16692_16710()
                {
                    var return_v = ConstantValue.Null;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10301, 16692, 16710);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLiteral
                f_10301_16669_16724(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.ConstantValue
                constantValueOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundLiteral(syntax, constantValueOpt, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10301, 16669, 16724);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10301_16813_17001(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.SyntaxNode
                right, Microsoft.CodeAnalysis.CSharp.BoundLiteral
                boundLeft, string
                rightName, int
                rightArity, Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax>
                typeArgumentsSyntax, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                typeArgumentsWithAnnotations, bool
                invoked, bool
                indexed, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindInstanceMemberAccess(node, right, (Microsoft.CodeAnalysis.CSharp.BoundExpression)boundLeft, rightName, rightArity, typeArgumentsSyntax, typeArgumentsWithAnnotations, invoked: invoked, indexed: indexed, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10301, 16813, 17001);
                    return return_v;
                }


                bool
                f_10301_17020_17042(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.HasAnyErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10301, 17020, 17042);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10301_17169_17183(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10301, 17169, 17183);
                    return return_v;
                }


                int
                f_10301_17245_17344(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax, params object[]
                args)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10301, 17245, 17344);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                f_10301_17474_17521(Microsoft.CodeAnalysis.CSharp.BoundPropertyAccess
                this_param)
                {
                    var return_v = this_param.PropertySymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10301, 17474, 17521);
                    return return_v;
                }


                bool
                f_10301_17540_17571(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.IsWriteOnly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10301, 17540, 17571);
                    return return_v;
                }


                int
                f_10301_17605_17682(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax, params object[]
                args)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10301, 17605, 17682);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10301_17794_17818(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10301, 17794, 17818);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10301_17794_17830(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10301, 17794, 17830);
                    return return_v;
                }


                int
                f_10301_17894_17987(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax, params object[]
                args)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10301, 17894, 17987);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10301, 16431, 18118);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10301, 16431, 18118);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool AwaiterImplementsINotifyCompletion(TypeSymbol awaiterType, SyntaxNode node, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10301, 18452, 19291);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 18592, 18717);

                var
                INotifyCompletion = f_10301_18616_18716(this, WellKnownType.System_Runtime_CompilerServices_INotifyCompletion, diagnostics, node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 18731, 18782);

                HashSet<DiagnosticInfo>?
                useSiteDiagnostics = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 18798, 18923);

                var
                conversion = f_10301_18815_18922(f_10301_18815_18831(this), awaiterType, INotifyCompletion, ref useSiteDiagnostics)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 18937, 19205) || true) && (f_10301_18941_18963_M(!conversion.IsImplicit))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10301, 18937, 19205);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 18997, 19039);

                    f_10301_18997_19038(diagnostics, node, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 19057, 19159);

                    f_10301_19057_19158(diagnostics, ErrorCode.ERR_DoesntImplementAwaitInterface, node, awaiterType, INotifyCompletion);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 19177, 19190);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10301, 18937, 19205);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 19221, 19254);

                f_10301_19221_19253(conversion.IsValid);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 19268, 19280);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10301, 18452, 19291);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10301_18616_18716(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.WellKnownType
                type, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = this_param.GetWellKnownType(type, diagnostics, node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10301, 18616, 18716);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversions
                f_10301_18815_18831(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.Conversions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10301, 18815, 18831);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10301_18815_18922(Microsoft.CodeAnalysis.CSharp.Conversions
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = this_param.ClassifyImplicitConversionFromType(source, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10301, 18815, 18922);
                    return return_v;
                }


                bool
                f_10301_18941_18963_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10301, 18941, 18963);
                    return return_v;
                }


                bool
                f_10301_18997_19038(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.SyntaxNode
                node, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = diagnostics.Add(node, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10301, 18997, 19038);
                    return return_v;
                }


                int
                f_10301_19057_19158(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax, params object[]
                args)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10301, 19057, 19158);
                    return 0;
                }


                int
                f_10301_19221_19253(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10301, 19221, 19253);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10301, 18452, 19291);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10301, 18452, 19291);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool GetGetResultMethod(BoundExpression awaiterExpression, SyntaxNode node, TypeSymbol awaitedExpressionType, DiagnosticBag diagnostics, out MethodSymbol? getResultMethod, [NotNullWhen(true)] out BoundExpression? getAwaiterGetResultCall)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10301, 19597, 21567);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 19867, 19908);

                var
                awaiterType = f_10301_19885_19907(awaiterExpression)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 19922, 20082);

                getAwaiterGetResultCall = f_10301_19948_20081(this, node, awaiterExpression, WellKnownMemberNames.GetResult, ImmutableArray<BoundExpression>.Empty, diagnostics);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 20096, 20288) || true) && (f_10301_20100_20136(getAwaiterGetResultCall))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10301, 20096, 20288);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 20170, 20193);

                    getResultMethod = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 20211, 20242);

                    getAwaiterGetResultCall = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 20260, 20273);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10301, 20096, 20288);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 20304, 20346);

                f_10301_20304_20345(awaiterType is object);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 20360, 20678) || true) && (f_10301_20364_20392(getAwaiterGetResultCall) != BoundKind.Call)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10301, 20360, 20678);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 20444, 20542);

                    f_10301_20444_20541(diagnostics, ErrorCode.ERR_NoSuchMember, node, awaiterType, WellKnownMemberNames.GetResult);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 20560, 20583);

                    getResultMethod = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 20601, 20632);

                    getAwaiterGetResultCall = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 20650, 20663);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10301, 20360, 20678);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 20694, 20756);

                getResultMethod = f_10301_20712_20755(((BoundCall)getAwaiterGetResultCall));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 20770, 21075) || true) && (f_10301_20774_20807(getResultMethod))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10301, 20770, 21075);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 20841, 20939);

                    f_10301_20841_20938(diagnostics, ErrorCode.ERR_NoSuchMember, node, awaiterType, WellKnownMemberNames.GetResult);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 20957, 20980);

                    getResultMethod = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 20998, 21029);

                    getAwaiterGetResultCall = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 21047, 21060);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10301, 20770, 21075);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 21091, 21440) || true) && (f_10301_21095_21143(getResultMethod) || (DynAbs.Tracing.TraceSender.Expression_False(10301, 21095, 21176) || f_10301_21147_21176(getResultMethod)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10301, 21091, 21440);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 21210, 21304);

                    f_10301_21210_21303(diagnostics, ErrorCode.ERR_BadAwaiterPattern, node, awaiterType, awaitedExpressionType);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 21322, 21345);

                    getResultMethod = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 21363, 21394);

                    getAwaiterGetResultCall = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 21412, 21425);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10301, 21091, 21440);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 21544, 21556);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10301, 19597, 21567);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10301_19885_19907(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10301, 19885, 19907);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10301_19948_20081(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver, string
                methodName, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                args, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.MakeInvocationExpression(node, receiver, methodName, args, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10301, 19948, 20081);
                    return return_v;
                }


                bool
                f_10301_20100_20136(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.HasAnyErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10301, 20100, 20136);
                    return return_v;
                }


                int
                f_10301_20304_20345(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10301, 20304, 20345);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10301_20364_20392(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10301, 20364, 20392);
                    return return_v;
                }


                int
                f_10301_20444_20541(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax, params object[]
                args)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10301, 20444, 20541);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10301_20712_20755(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.Method;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10301, 20712, 20755);
                    return return_v;
                }


                bool
                f_10301_20774_20807(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsExtensionMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10301, 20774, 20807);
                    return return_v;
                }


                int
                f_10301_20841_20938(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax, params object[]
                args)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10301, 20841, 20938);
                    return 0;
                }


                bool
                f_10301_21095_21143(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = HasOptionalOrVariableParameters(method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10301, 21095, 21143);
                    return return_v;
                }


                bool
                f_10301_21147_21176(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsConditional;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10301, 21147, 21176);
                    return return_v;
                }


                int
                f_10301_21210_21303(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax, params object[]
                args)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10301, 21210, 21303);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10301, 19597, 21567);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10301, 19597, 21567);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool HasOptionalOrVariableParameters(MethodSymbol method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10301, 21579, 21975);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 21676, 21711);

                f_10301_21676_21710(method != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 21727, 21935) || true) && (f_10301_21731_21752(method) != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10301, 21727, 21935);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 21791, 21852);

                    var
                    parameter = f_10301_21807_21824(method)[f_10301_21825_21846(method) - 1]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 21870, 21920);

                    return f_10301_21877_21897(parameter) || (DynAbs.Tracing.TraceSender.Expression_False(10301, 21877, 21919) || f_10301_21901_21919(parameter));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10301, 21727, 21935);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10301, 21951, 21964);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10301, 21579, 21975);

                int
                f_10301_21676_21710(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10301, 21676, 21710);
                    return 0;
                }


                int
                f_10301_21731_21752(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10301, 21731, 21752);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10301_21807_21824(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10301, 21807, 21824);
                    return return_v;
                }


                int
                f_10301_21825_21846(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10301, 21825, 21846);
                    return return_v;
                }


                bool
                f_10301_21877_21897(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.IsOptional;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10301, 21877, 21897);
                    return return_v;
                }


                bool
                f_10301_21901_21919(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.IsParams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10301, 21901, 21919);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10301, 21579, 21975);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10301, 21579, 21975);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
}
