// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal partial class DebugInfoInjector : CompoundInstrumenter
    {
        public static readonly DebugInfoInjector Singleton;

        public DebugInfoInjector(Instrumenter previous)
        : base(f_10461_1296_1304_C(previous))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10461, 1228, 1327);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10461, 1228, 1327);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10461, 1228, 1327);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10461, 1228, 1327);
            }
        }

        public override BoundStatement InstrumentNoOpStatement(BoundNoOpStatement original, BoundStatement rewritten)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10461, 1339, 1559);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 1473, 1548);

                return f_10461_1480_1547(DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.InstrumentNoOpStatement(original, rewritten), 10461, 1497, 1546));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10461, 1339, 1559);

                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10461_1480_1547(Microsoft.CodeAnalysis.CSharp.BoundStatement
                node)
                {
                    var return_v = AddSequencePoint(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10461, 1480, 1547);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10461, 1339, 1559);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10461, 1339, 1559);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundStatement InstrumentBreakStatement(BoundBreakStatement original, BoundStatement rewritten)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10461, 1571, 1794);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 1707, 1783);

                return f_10461_1714_1782(DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.InstrumentBreakStatement(original, rewritten), 10461, 1731, 1781));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10461, 1571, 1794);

                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10461_1714_1782(Microsoft.CodeAnalysis.CSharp.BoundStatement
                node)
                {
                    var return_v = AddSequencePoint(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10461, 1714, 1782);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10461, 1571, 1794);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10461, 1571, 1794);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundStatement InstrumentContinueStatement(BoundContinueStatement original, BoundStatement rewritten)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10461, 1806, 2038);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 1948, 2027);

                return f_10461_1955_2026(DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.InstrumentContinueStatement(original, rewritten), 10461, 1972, 2025));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10461, 1806, 2038);

                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10461_1955_2026(Microsoft.CodeAnalysis.CSharp.BoundStatement
                node)
                {
                    var return_v = AddSequencePoint(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10461, 1955, 2026);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10461, 1806, 2038);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10461, 1806, 2038);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundStatement InstrumentExpressionStatement(BoundExpressionStatement original, BoundStatement rewritten)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10461, 2050, 3276);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 2196, 2264);

                rewritten = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.InstrumentExpressionStatement(original, rewritten), 10461, 2208, 2263);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 2280, 3214) || true) && (f_10461_2284_2319(original))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10461, 2280, 3214);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 2353, 3199);

                    switch (f_10461_2361_2383(original.Syntax))
                    {

                        case SyntaxKind.ConstructorDeclaration:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10461, 2353, 3199);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 2563, 2620);

                            var
                            decl = (ConstructorDeclarationSyntax)original.Syntax
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 2646, 2744);

                            return f_10461_2653_2743(decl, rewritten, f_10461_2701_2742(decl));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10461, 2353, 3199);

                        case SyntaxKind.BaseConstructorInitializer:
                        case SyntaxKind.ThisConstructorInitializer:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10461, 2353, 3199);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 2900, 2957);

                            var
                            init = (ConstructorInitializerSyntax)original.Syntax
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 2983, 3019);

                            f_10461_2983_3018(f_10461_2996_3007(init) is object);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 3045, 3180);

                            return f_10461_3052_3179(init, rewritten, f_10461_3100_3178(f_10461_3166_3177(init)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10461, 2353, 3199);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10461, 2280, 3214);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 3230, 3265);

                return f_10461_3237_3264(rewritten);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10461, 2050, 3276);

                bool
                f_10461_2284_2319(Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                statement)
                {
                    var return_v = statement.IsConstructorInitializer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10461, 2284, 2319);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10461_2361_2383(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10461, 2361, 2383);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_10461_2701_2742(Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
                constructorSyntax)
                {
                    var return_v = CreateSpanForConstructorInitializer(constructorSyntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10461, 2701, 2742);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundSequencePointWithSpan
                f_10461_2653_2743(Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.BoundStatement
                statementOpt, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundSequencePointWithSpan((Microsoft.CodeAnalysis.SyntaxNode)syntax, statementOpt, span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10461, 2653, 2743);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10461_2996_3007(Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorInitializerSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10461, 2996, 3007);
                    return return_v;
                }


                int
                f_10461_2983_3018(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10461, 2983, 3018);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10461_3166_3177(Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorInitializerSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10461, 3166, 3177);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_10461_3100_3178(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                constructorSyntax)
                {
                    var return_v = CreateSpanForConstructorInitializer((Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax)constructorSyntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10461, 3100, 3178);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundSequencePointWithSpan
                f_10461_3052_3179(Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorInitializerSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.BoundStatement
                statementOpt, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundSequencePointWithSpan((Microsoft.CodeAnalysis.SyntaxNode)syntax, statementOpt, span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10461, 3052, 3179);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10461_3237_3264(Microsoft.CodeAnalysis.CSharp.BoundStatement
                node)
                {
                    var return_v = AddSequencePoint(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10461, 3237, 3264);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10461, 2050, 3276);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10461, 2050, 3276);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundStatement InstrumentFieldOrPropertyInitializer(BoundStatement original, BoundStatement rewritten)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10461, 3288, 3952);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 3431, 3506);

                rewritten = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.InstrumentFieldOrPropertyInitializer(original, rewritten), 10461, 3443, 3505);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 3520, 3556);

                SyntaxNode
                syntax = original.Syntax
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 3572, 3862) || true) && (f_10461_3576_3590(rewritten) == BoundKind.Block)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10461, 3572, 3862);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 3643, 3677);

                    var
                    block = (BoundBlock)rewritten
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 3695, 3847);

                    return f_10461_3702_3846(block, f_10461_3715_3727(block), f_10461_3729_3749(block), f_10461_3751_3845(f_10461_3773_3844(block.Statements.Single(), syntax)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10461, 3572, 3862);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 3878, 3941);

                return f_10461_3885_3940(rewritten, syntax);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10461, 3288, 3952);

                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10461_3576_3590(Microsoft.CodeAnalysis.CSharp.BoundStatement
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10461, 3576, 3590);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10461_3715_3727(Microsoft.CodeAnalysis.CSharp.BoundBlock
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10461, 3715, 3727);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol>
                f_10461_3729_3749(Microsoft.CodeAnalysis.CSharp.BoundBlock
                this_param)
                {
                    var return_v = this_param.LocalFunctions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10461, 3729, 3749);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10461_3773_3844(Microsoft.CodeAnalysis.CSharp.BoundStatement
                rewritten, Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    var return_v = InstrumentFieldOrPropertyInitializer(rewritten, syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10461, 3773, 3844);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10461_3751_3845(Microsoft.CodeAnalysis.CSharp.BoundStatement
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10461, 3751, 3845);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10461_3702_3846(Microsoft.CodeAnalysis.CSharp.BoundBlock
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol>
                localFunctions, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                statements)
                {
                    var return_v = this_param.Update(locals, localFunctions, statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10461, 3702, 3846);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10461_3885_3940(Microsoft.CodeAnalysis.CSharp.BoundStatement
                rewritten, Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    var return_v = InstrumentFieldOrPropertyInitializer(rewritten, syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10461, 3885, 3940);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10461, 3288, 3952);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10461, 3288, 3952);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static BoundStatement InstrumentFieldOrPropertyInitializer(BoundStatement rewritten, SyntaxNode syntax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10461, 3964, 5050);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 4100, 4320) || true) && (f_10461_4104_4139(syntax, SyntaxKind.Parameter))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10461, 4100, 4320);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 4270, 4305);

                    return f_10461_4277_4304(rewritten);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10461, 4100, 4320);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 4336, 4388);

                f_10461_4336_4387(syntax is { Parent: { Parent: { } } });
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 4402, 4441);

                var
                grandparent = f_10461_4420_4440(f_10461_4420_4433(syntax))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 4455, 5039);

                switch (f_10461_4463_4481(grandparent))
                {

                    case SyntaxKind.VariableDeclarator:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10461, 4455, 5039);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 4572, 4633);

                        var
                        declaratorSyntax = (VariableDeclaratorSyntax)grandparent
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 4655, 4708);

                        return f_10461_4662_4707(declaratorSyntax, rewritten);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10461, 4455, 5039);

                    case SyntaxKind.PropertyDeclaration:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10461, 4455, 5039);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 4786, 4843);

                        var
                        declaration = (PropertyDeclarationSyntax)grandparent
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 4865, 4913);

                        return f_10461_4872_4912(declaration, rewritten);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10461, 4455, 5039);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10461, 4455, 5039);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 4963, 5024);

                        throw f_10461_4969_5023(f_10461_5004_5022(grandparent));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10461, 4455, 5039);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10461, 3964, 5050);

                bool
                f_10461_4104_4139(Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = node.IsKind(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10461, 4104, 4139);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10461_4277_4304(Microsoft.CodeAnalysis.CSharp.BoundStatement
                node)
                {
                    var return_v = AddSequencePoint(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10461, 4277, 4304);
                    return return_v;
                }


                int
                f_10461_4336_4387(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10461, 4336, 4387);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10461_4420_4433(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10461, 4420, 4433);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10461_4420_4440(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10461, 4420, 4440);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10461_4463_4481(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10461, 4463, 4481);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10461_4662_4707(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax
                declaratorSyntax, Microsoft.CodeAnalysis.CSharp.BoundStatement
                rewrittenStatement)
                {
                    var return_v = AddSequencePoint(declaratorSyntax, rewrittenStatement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10461, 4662, 4707);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10461_4872_4912(Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax
                declarationSyntax, Microsoft.CodeAnalysis.CSharp.BoundStatement
                rewrittenStatement)
                {
                    var return_v = AddSequencePoint(declarationSyntax, rewrittenStatement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10461, 4872, 4912);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10461_5004_5022(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10461, 5004, 5022);
                    return return_v;
                }


                System.Exception
                f_10461_4969_5023(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10461, 4969, 5023);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10461, 3964, 5050);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10461, 3964, 5050);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundStatement InstrumentGotoStatement(BoundGotoStatement original, BoundStatement rewritten)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10461, 5062, 5282);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 5196, 5271);

                return f_10461_5203_5270(DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.InstrumentGotoStatement(original, rewritten), 10461, 5220, 5269));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10461, 5062, 5282);

                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10461_5203_5270(Microsoft.CodeAnalysis.CSharp.BoundStatement
                node)
                {
                    var return_v = AddSequencePoint(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10461, 5203, 5270);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10461, 5062, 5282);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10461, 5062, 5282);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundStatement InstrumentThrowStatement(BoundThrowStatement original, BoundStatement rewritten)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10461, 5294, 5517);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 5430, 5506);

                return f_10461_5437_5505(DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.InstrumentThrowStatement(original, rewritten), 10461, 5454, 5504));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10461, 5294, 5517);

                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10461_5437_5505(Microsoft.CodeAnalysis.CSharp.BoundStatement
                node)
                {
                    var return_v = AddSequencePoint(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10461, 5437, 5505);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10461, 5294, 5517);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10461, 5294, 5517);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundStatement InstrumentYieldBreakStatement(BoundYieldBreakStatement original, BoundStatement rewritten)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10461, 5529, 6131);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 5675, 5743);

                rewritten = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.InstrumentYieldBreakStatement(original, rewritten), 10461, 5687, 5742);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 5759, 6069) || true) && (f_10461_5763_5792(original) && (DynAbs.Tracing.TraceSender.Expression_True(10461, 5763, 5838) && f_10461_5796_5818(original.Syntax) == SyntaxKind.Block))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10461, 5759, 6069);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 5935, 6054);

                    return f_10461_5942_6053(original.Syntax, rewritten, ((BlockSyntax)original.Syntax).CloseBraceToken.Span);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10461, 5759, 6069);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 6085, 6120);

                return f_10461_6092_6119(rewritten);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10461, 5529, 6131);

                bool
                f_10461_5763_5792(Microsoft.CodeAnalysis.CSharp.BoundYieldBreakStatement
                this_param)
                {
                    var return_v = this_param.WasCompilerGenerated;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10461, 5763, 5792);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10461_5796_5818(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10461, 5796, 5818);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundSequencePointWithSpan
                f_10461_5942_6053(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundStatement
                statementOpt, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundSequencePointWithSpan(syntax, statementOpt, span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10461, 5942, 6053);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10461_6092_6119(Microsoft.CodeAnalysis.CSharp.BoundStatement
                node)
                {
                    var return_v = AddSequencePoint(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10461, 6092, 6119);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10461, 5529, 6131);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10461, 5529, 6131);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundStatement InstrumentYieldReturnStatement(BoundYieldReturnStatement original, BoundStatement rewritten)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10461, 6143, 6384);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 6291, 6373);

                return f_10461_6298_6372(DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.InstrumentYieldReturnStatement(original, rewritten), 10461, 6315, 6371));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10461, 6143, 6384);

                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10461_6298_6372(Microsoft.CodeAnalysis.CSharp.BoundStatement
                node)
                {
                    var return_v = AddSequencePoint(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10461, 6298, 6372);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10461, 6143, 6384);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10461, 6143, 6384);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundStatement? CreateBlockPrologue(BoundBlock original, out Symbols.LocalSymbol? synthesizedLocal)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10461, 6396, 7090);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 6536, 6608);

                // LAFHIS
                //var previous = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.CreateBlockPrologue(original, out synthesizedLocal), 10461, 6551, 6607);
                var previous = base.CreateBlockPrologue(original, out synthesizedLocal);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10461, 6551, 6607);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 6622, 7051) || true) && (f_10461_6626_6648(original.Syntax) == SyntaxKind.Block && (DynAbs.Tracing.TraceSender.Expression_True(10461, 6626, 6702) && f_10461_6672_6702_M(!original.WasCompilerGenerated)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10461, 6622, 7051);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 6736, 6800);

                    var
                    oBspan = ((BlockSyntax)original.Syntax).OpenBraceToken.Span
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 6818, 6891);

                    return f_10461_6825_6890(original.Syntax, previous, oBspan);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10461, 6622, 7051);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10461, 6622, 7051);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 6925, 7051) || true) && (previous != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10461, 6925, 7051);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 6979, 7036);

                        return f_10461_6986_7035(original.Syntax, previous);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10461, 6925, 7051);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10461, 6622, 7051);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 7067, 7079);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10461, 6396, 7090);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10461_6626_6648(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10461, 6626, 6648);
                    return return_v;
                }


                bool
                f_10461_6672_6702_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10461, 6672, 6702);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundSequencePointWithSpan
                f_10461_6825_6890(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundStatement?
                statementOpt, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundSequencePointWithSpan(syntax, statementOpt, span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10461, 6825, 6890);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundSequencePoint
                f_10461_6986_7035(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundStatement
                statementOpt)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundSequencePoint(syntax, statementOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10461, 6986, 7035);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10461, 6396, 7090);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10461, 6396, 7090);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundStatement? CreateBlockEpilogue(BoundBlock original)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10461, 7102, 7970);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 7199, 7249);

                var
                previous = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.CreateBlockEpilogue(original), 10461, 7214, 7248)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 7265, 7927) || true) && (f_10461_7269_7291(original.Syntax) == SyntaxKind.Block && (DynAbs.Tracing.TraceSender.Expression_True(10461, 7269, 7345) && f_10461_7315_7345_M(!original.WasCompilerGenerated)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10461, 7265, 7927);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 7535, 7579);

                    SyntaxNode?
                    parent = f_10461_7556_7578(original.Syntax)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 7597, 7912) || true) && (parent == null || (DynAbs.Tracing.TraceSender.Expression_False(10461, 7601, 7691) || !(f_10461_7621_7649(parent) || (DynAbs.Tracing.TraceSender.Expression_False(10461, 7621, 7690) || parent is BaseMethodDeclarationSyntax))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10461, 7597, 7912);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 7733, 7798);

                        var
                        cBspan = ((BlockSyntax)original.Syntax).CloseBraceToken.Span
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 7820, 7893);

                        return f_10461_7827_7892(original.Syntax, previous, cBspan);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10461, 7597, 7912);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10461, 7265, 7927);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 7943, 7959);

                return previous;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10461, 7102, 7970);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10461_7269_7291(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10461, 7269, 7291);
                    return return_v;
                }


                bool
                f_10461_7315_7345_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10461, 7315, 7345);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode?
                f_10461_7556_7578(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10461, 7556, 7578);
                    return return_v;
                }


                bool
                f_10461_7621_7649(Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    var return_v = syntax.IsAnonymousFunction();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10461, 7621, 7649);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundSequencePointWithSpan
                f_10461_7827_7892(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundStatement?
                statementOpt, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundSequencePointWithSpan(syntax, statementOpt, span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10461, 7827, 7892);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10461, 7102, 7970);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10461, 7102, 7970);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundExpression InstrumentDoStatementCondition(BoundDoStatement original, BoundExpression rewrittenCondition, SyntheticBoundNodeFactory factory)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10461, 7982, 8521);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 8375, 8510);

                return f_10461_8382_8509(DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.InstrumentDoStatementCondition(original, rewrittenCondition, factory), 10461, 8408, 8482), original.Syntax, factory);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10461, 7982, 8521);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10461_8382_8509(Microsoft.CodeAnalysis.CSharp.BoundExpression
                condition, Microsoft.CodeAnalysis.SyntaxNode
                synthesizedVariableSyntax, Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                factory)
                {
                    var return_v = AddConditionSequencePoint(condition, synthesizedVariableSyntax, factory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10461, 8382, 8509);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10461, 7982, 8521);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10461, 7982, 8521);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundExpression InstrumentWhileStatementCondition(BoundWhileStatement original, BoundExpression rewrittenCondition, SyntheticBoundNodeFactory factory)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10461, 8533, 9081);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 8932, 9070);

                return f_10461_8939_9069(DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.InstrumentWhileStatementCondition(original, rewrittenCondition, factory), 10461, 8965, 9042), original.Syntax, factory);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10461, 8533, 9081);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10461_8939_9069(Microsoft.CodeAnalysis.CSharp.BoundExpression
                condition, Microsoft.CodeAnalysis.SyntaxNode
                synthesizedVariableSyntax, Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                factory)
                {
                    var return_v = AddConditionSequencePoint(condition, synthesizedVariableSyntax, factory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10461, 8939, 9069);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10461, 8533, 9081);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10461, 8533, 9081);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundStatement InstrumentDoStatementConditionalGotoStart(BoundDoStatement original, BoundStatement ifConditionGotoStart)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10461, 9093, 9612);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 9254, 9304);

                var
                doSyntax = (DoStatementSyntax)original.Syntax
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 9318, 9451);

                var
                span = TextSpan.FromBounds(doSyntax.WhileKeyword.SpanStart, doSyntax.SemicolonToken.Span.End)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 9467, 9601);

                return f_10461_9474_9600(doSyntax, DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.InstrumentDoStatementConditionalGotoStart(original, ifConditionGotoStart), 10461, 9515, 9593), span);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10461, 9093, 9612);

                Microsoft.CodeAnalysis.CSharp.BoundSequencePointWithSpan
                f_10461_9474_9600(Microsoft.CodeAnalysis.CSharp.Syntax.DoStatementSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.BoundStatement
                statementOpt, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundSequencePointWithSpan((Microsoft.CodeAnalysis.SyntaxNode)syntax, statementOpt, span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10461, 9474, 9600);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10461, 9093, 9612);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10461, 9093, 9612);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundStatement InstrumentWhileStatementConditionalGotoStartOrBreak(BoundWhileStatement original, BoundStatement ifConditionGotoStart)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10461, 9624, 10248);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 9798, 9871);

                WhileStatementSyntax
                whileSyntax = (WhileStatementSyntax)original.Syntax
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 9885, 10052);

                TextSpan
                conditionSequencePointSpan = TextSpan.FromBounds(whileSyntax.WhileKeyword.SpanStart, whileSyntax.CloseParenToken.Span.End)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 10068, 10237);

                return f_10461_10075_10236(whileSyntax, DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.InstrumentWhileStatementConditionalGotoStartOrBreak(original, ifConditionGotoStart), 10461, 10119, 10207), conditionSequencePointSpan);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10461, 9624, 10248);

                Microsoft.CodeAnalysis.CSharp.BoundSequencePointWithSpan
                f_10461_10075_10236(Microsoft.CodeAnalysis.CSharp.Syntax.WhileStatementSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.BoundStatement
                statementOpt, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundSequencePointWithSpan((Microsoft.CodeAnalysis.SyntaxNode)syntax, statementOpt, span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10461, 10075, 10236);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10461, 9624, 10248);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10461, 9624, 10248);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static BoundExpression AddConditionSequencePoint(BoundExpression condition, BoundStatement containingStatement, SyntheticBoundNodeFactory factory)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10461, 10260, 10531);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 10439, 10520);

                return f_10461_10446_10519(condition, containingStatement.Syntax, factory);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10461, 10260, 10531);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10461_10446_10519(Microsoft.CodeAnalysis.CSharp.BoundExpression
                condition, Microsoft.CodeAnalysis.SyntaxNode
                synthesizedVariableSyntax, Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                factory)
                {
                    var return_v = AddConditionSequencePoint(condition, synthesizedVariableSyntax, factory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10461, 10446, 10519);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10461, 10260, 10531);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10461, 10260, 10531);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundStatement InstrumentForEachStatementCollectionVarDeclaration(BoundForEachStatement original, BoundStatement? collectionVarDecl)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10461, 10783, 11232);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 10956, 11022);

                var
                forEachSyntax = (CommonForEachStatementSyntax)original.Syntax
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 11036, 11221);

                return f_10461_11043_11220(f_10461_11066_11090(forEachSyntax), DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.InstrumentForEachStatementCollectionVarDeclaration(original, collectionVarDecl), 10461, 11135, 11219));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10461, 10783, 11232);

                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10461_11066_11090(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10461, 11066, 11090);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundSequencePoint
                f_10461_11043_11220(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.BoundStatement?
                statementOpt)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundSequencePoint((Microsoft.CodeAnalysis.SyntaxNode)syntax, statementOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10461, 11043, 11220);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10461, 10783, 11232);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10461, 10783, 11232);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundStatement InstrumentForEachStatementDeconstructionVariablesDeclaration(BoundForEachStatement original, BoundStatement iterationVarDecl)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10461, 11244, 11695);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 11425, 11493);

                var
                forEachSyntax = (ForEachVariableStatementSyntax)original.Syntax
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 11507, 11684);

                return f_10461_11514_11683(forEachSyntax, DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.InstrumentForEachStatementDeconstructionVariablesDeclaration(original, iterationVarDecl), 10461, 11560, 11653), f_10461_11655_11682(f_10461_11655_11677(forEachSyntax)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10461, 11244, 11695);

                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10461_11655_11677(Microsoft.CodeAnalysis.CSharp.Syntax.ForEachVariableStatementSyntax
                this_param)
                {
                    var return_v = this_param.Variable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10461, 11655, 11677);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_10461_11655_11682(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Span;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10461, 11655, 11682);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundSequencePointWithSpan
                f_10461_11514_11683(Microsoft.CodeAnalysis.CSharp.Syntax.ForEachVariableStatementSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.BoundStatement
                statementOpt, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundSequencePointWithSpan((Microsoft.CodeAnalysis.SyntaxNode)syntax, statementOpt, span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10461, 11514, 11683);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10461, 11244, 11695);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10461, 11244, 11695);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundStatement InstrumentForEachStatement(BoundForEachStatement original, BoundStatement rewritten)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10461, 11947, 12812);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 12087, 12153);

                var
                forEachSyntax = (CommonForEachStatementSyntax)original.Syntax
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 12167, 12386);

                var
                span = (DynAbs.Tracing.TraceSender.Conditional_F1(10461, 12178, 12215) || ((f_10461_12178_12204(forEachSyntax) != default
                && DynAbs.Tracing.TraceSender.Conditional_F2(10461, 12235, 12332)) || DynAbs.Tracing.TraceSender.Conditional_F3(10461, 12352, 12385))) ? TextSpan.FromBounds(forEachSyntax.AwaitKeyword.Span.Start, forEachSyntax.ForEachKeyword.Span.End) : forEachSyntax.ForEachKeyword.Span
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 12402, 12494);

                var
                foreachKeywordSequencePoint = f_10461_12436_12493(forEachSyntax, null, span)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 12508, 12801);

                return f_10461_12515_12800(forEachSyntax, f_10461_12598_12799(foreachKeywordSequencePoint, DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.InstrumentForEachStatement(original, rewritten), 10461, 12746, 12798)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10461, 11947, 12812);

                Microsoft.CodeAnalysis.SyntaxToken
                f_10461_12178_12204(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
                this_param)
                {
                    var return_v = this_param.AwaitKeyword;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10461, 12178, 12204);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundSequencePointWithSpan
                f_10461_12436_12493(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.BoundStatement?
                statementOpt, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundSequencePointWithSpan((Microsoft.CodeAnalysis.SyntaxNode)syntax, statementOpt, span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10461, 12436, 12493);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10461_12598_12799(Microsoft.CodeAnalysis.CSharp.BoundSequencePointWithSpan
                item1, Microsoft.CodeAnalysis.CSharp.BoundStatement
                item2)
                {
                    var return_v = ImmutableArray.Create<BoundStatement>((Microsoft.CodeAnalysis.CSharp.BoundStatement)item1, item2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10461, 12598, 12799);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatementList
                f_10461_12515_12800(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
                syntax, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                statements)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundStatementList((Microsoft.CodeAnalysis.SyntaxNode)syntax, statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10461, 12515, 12800);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10461, 11947, 12812);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10461, 11947, 12812);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundStatement InstrumentForEachStatementIterationVarDeclaration(BoundForEachStatement original, BoundStatement iterationVarDecl)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10461, 13052, 14385);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 13222, 13252);

                TextSpan
                iterationVarDeclSpan
                = default(TextSpan);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 13266, 14097);

                switch (f_10461_13274_13296(original.Syntax))
                {

                    case SyntaxKind.ForEachStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10461, 13266, 14097);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 13412, 13472);

                            var
                            forEachSyntax = (ForEachStatementSyntax)original.Syntax
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 13498, 13606);

                            iterationVarDeclSpan = TextSpan.FromBounds(f_10461_13541_13569(f_10461_13541_13559(forEachSyntax)), forEachSyntax.Identifier.Span.End);
                            DynAbs.Tracing.TraceSender.TraceBreak(10461, 13632, 13638);

                            break;
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10461, 13266, 14097);

                    case SyntaxKind.ForEachVariableStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10461, 13266, 14097);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 13769, 13837);

                            var
                            forEachSyntax = (ForEachVariableStatementSyntax)original.Syntax
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 13863, 13914);

                            iterationVarDeclSpan = f_10461_13886_13913(f_10461_13886_13908(forEachSyntax));
                            DynAbs.Tracing.TraceSender.TraceBreak(10461, 13940, 13946);

                            break;
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10461, 13266, 14097);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10461, 13266, 14097);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 14017, 14082);

                        throw f_10461_14023_14081(f_10461_14058_14080(original.Syntax));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10461, 13266, 14097);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 14111, 14374);

                return f_10461_14118_14373(original.Syntax, DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.InstrumentForEachStatementIterationVarDeclaration(original, iterationVarDecl), 10461, 14217, 14299), iterationVarDeclSpan);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10461, 13052, 14385);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10461_13274_13296(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10461, 13274, 13296);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10461_13541_13559(Microsoft.CodeAnalysis.CSharp.Syntax.ForEachStatementSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10461, 13541, 13559);
                    return return_v;
                }


                int
                f_10461_13541_13569(Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                this_param)
                {
                    var return_v = this_param.SpanStart;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10461, 13541, 13569);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10461_13886_13908(Microsoft.CodeAnalysis.CSharp.Syntax.ForEachVariableStatementSyntax
                this_param)
                {
                    var return_v = this_param.Variable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10461, 13886, 13908);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_10461_13886_13913(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Span;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10461, 13886, 13913);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10461_14058_14080(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10461, 14058, 14080);
                    return return_v;
                }


                System.Exception
                f_10461_14023_14081(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10461, 14023, 14081);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundSequencePointWithSpan
                f_10461_14118_14373(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundStatement
                statementOpt, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundSequencePointWithSpan(syntax, statementOpt, span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10461, 14118, 14373);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10461, 13052, 14385);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10461, 13052, 14385);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundStatement InstrumentForStatementConditionalGotoStartOrBreak(BoundForStatement original, BoundStatement branchBack)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10461, 14397, 14815);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 14620, 14804);

                return f_10461_14627_14803(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10461_14653_14671(original), 10461, 14653, 14679)?.Syntax, DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.InstrumentForStatementConditionalGotoStartOrBreak(original, branchBack), 10461, 14726, 14802));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10461, 14397, 14815);

                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10461_14653_14671(Microsoft.CodeAnalysis.CSharp.BoundForStatement
                this_param)
                {
                    var return_v = this_param.Condition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10461, 14653, 14671);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10461_14627_14803(Microsoft.CodeAnalysis.SyntaxNode?
                syntax, Microsoft.CodeAnalysis.CSharp.BoundStatement
                statementOpt)
                {
                    var return_v = BoundSequencePoint.Create(syntax, statementOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10461, 14627, 14803);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10461, 14397, 14815);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10461, 14397, 14815);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundStatement InstrumentForEachStatementConditionalGotoStart(BoundForEachStatement original, BoundStatement branchBack)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10461, 14827, 15318);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 14988, 15047);

                var
                syntax = (CommonForEachStatementSyntax)original.Syntax
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 15061, 15307);

                return f_10461_15068_15306(syntax, DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.InstrumentForEachStatementConditionalGotoStart(original, branchBack), 10461, 15158, 15231), syntax.InKeyword.Span);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10461, 14827, 15318);

                Microsoft.CodeAnalysis.CSharp.BoundSequencePointWithSpan
                f_10461_15068_15306(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.BoundStatement
                statementOpt, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundSequencePointWithSpan((Microsoft.CodeAnalysis.SyntaxNode)syntax, statementOpt, span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10461, 15068, 15306);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10461, 14827, 15318);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10461, 14827, 15318);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundExpression InstrumentForStatementCondition(BoundForStatement original, BoundExpression rewrittenCondition, SyntheticBoundNodeFactory factory)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10461, 15330, 15872);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 15725, 15861);

                return f_10461_15732_15860(DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.InstrumentForStatementCondition(original, rewrittenCondition, factory), 10461, 15758, 15833), original.Syntax, factory);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10461, 15330, 15872);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10461_15732_15860(Microsoft.CodeAnalysis.CSharp.BoundExpression
                condition, Microsoft.CodeAnalysis.SyntaxNode
                synthesizedVariableSyntax, Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                factory)
                {
                    var return_v = AddConditionSequencePoint(condition, synthesizedVariableSyntax, factory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10461, 15732, 15860);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10461, 15330, 15872);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10461, 15330, 15872);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundStatement InstrumentIfStatement(BoundIfStatement original, BoundStatement rewritten)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10461, 15884, 16396);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 16014, 16062);

                var
                syntax = (IfStatementSyntax)original.Syntax
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 16076, 16385);

                return f_10461_16083_16384(syntax, DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.InstrumentIfStatement(original, rewritten), 10461, 16157, 16204), TextSpan.FromBounds(syntax.IfKeyword.SpanStart, syntax.CloseParenToken.Span.End), f_10461_16365_16383(original));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10461, 15884, 16396);

                bool
                f_10461_16365_16383(Microsoft.CodeAnalysis.CSharp.BoundIfStatement
                this_param)
                {
                    var return_v = this_param.HasErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10461, 16365, 16383);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundSequencePointWithSpan
                f_10461_16083_16384(Microsoft.CodeAnalysis.CSharp.Syntax.IfStatementSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.BoundStatement
                statementOpt, Microsoft.CodeAnalysis.Text.TextSpan
                span, bool
                hasErrors)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundSequencePointWithSpan((Microsoft.CodeAnalysis.SyntaxNode)syntax, statementOpt, span, hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10461, 16083, 16384);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10461, 15884, 16396);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10461, 15884, 16396);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundExpression InstrumentIfStatementCondition(BoundIfStatement original, BoundExpression rewrittenCondition, SyntheticBoundNodeFactory factory)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10461, 16408, 16947);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 16801, 16936);

                return f_10461_16808_16935(DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.InstrumentIfStatementCondition(original, rewrittenCondition, factory), 10461, 16834, 16908), original.Syntax, factory);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10461, 16408, 16947);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10461_16808_16935(Microsoft.CodeAnalysis.CSharp.BoundExpression
                condition, Microsoft.CodeAnalysis.SyntaxNode
                synthesizedVariableSyntax, Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                factory)
                {
                    var return_v = AddConditionSequencePoint(condition, synthesizedVariableSyntax, factory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10461, 16808, 16935);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10461, 16408, 16947);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10461, 16408, 16947);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundStatement InstrumentLabelStatement(BoundLabeledStatement original, BoundStatement rewritten)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10461, 16959, 17511);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 17097, 17157);

                var
                labeledSyntax = (LabeledStatementSyntax)original.Syntax
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 17171, 17273);

                var
                span = TextSpan.FromBounds(labeledSyntax.Identifier.SpanStart, labeledSyntax.ColonToken.Span.End)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 17287, 17500);

                return f_10461_17294_17499(labeledSyntax, DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.InstrumentLabelStatement(original, rewritten), 10461, 17391, 17441), span);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10461, 16959, 17511);

                Microsoft.CodeAnalysis.CSharp.BoundSequencePointWithSpan
                f_10461_17294_17499(Microsoft.CodeAnalysis.CSharp.Syntax.LabeledStatementSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.BoundStatement
                statementOpt, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundSequencePointWithSpan((Microsoft.CodeAnalysis.SyntaxNode)syntax, statementOpt, span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10461, 17294, 17499);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10461, 16959, 17511);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10461, 16959, 17511);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundStatement InstrumentLocalInitialization(BoundLocalDeclaration original, BoundStatement rewritten)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10461, 17523, 18061);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 17666, 18050);

                return f_10461_17673_18049((DynAbs.Tracing.TraceSender.Conditional_F1(10461, 17690, 17745) || ((f_10461_17690_17712(original.Syntax) == SyntaxKind.VariableDeclarator && DynAbs.Tracing.TraceSender.Conditional_F2(10461, 17789, 17830)) || DynAbs.Tracing.TraceSender.Conditional_F3(10461, 17874, 17954))) ? (VariableDeclaratorSyntax)original.Syntax : f_10461_17874_17936(((LocalDeclarationStatementSyntax)original.Syntax)).Variables.First(), DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.InstrumentLocalInitialization(original, rewritten), 10461, 17993, 18048));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10461, 17523, 18061);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10461_17690_17712(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10461, 17690, 17712);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax
                f_10461_17874_17936(Microsoft.CodeAnalysis.CSharp.Syntax.LocalDeclarationStatementSyntax
                this_param)
                {
                    var return_v = this_param.Declaration;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10461, 17874, 17936);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10461_17673_18049(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax
                declaratorSyntax, Microsoft.CodeAnalysis.CSharp.BoundStatement
                rewrittenStatement)
                {
                    var return_v = AddSequencePoint(declaratorSyntax, rewrittenStatement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10461, 17673, 18049);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10461, 17523, 18061);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10461, 17523, 18061);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundStatement InstrumentLockTargetCapture(BoundLockStatement original, BoundStatement lockTargetCapture)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10461, 18073, 18621);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 18219, 18289);

                LockStatementSyntax
                lockSyntax = (LockStatementSyntax)original.Syntax
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 18303, 18610);

                return f_10461_18310_18609(lockSyntax, DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.InstrumentLockTargetCapture(original, lockTargetCapture), 10461, 18404, 18465), TextSpan.FromBounds(lockSyntax.LockKeyword.SpanStart, lockSyntax.CloseParenToken.Span.End));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10461, 18073, 18621);

                Microsoft.CodeAnalysis.CSharp.BoundSequencePointWithSpan
                f_10461_18310_18609(Microsoft.CodeAnalysis.CSharp.Syntax.LockStatementSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.BoundStatement
                statementOpt, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundSequencePointWithSpan((Microsoft.CodeAnalysis.SyntaxNode)syntax, statementOpt, span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10461, 18310, 18609);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10461, 18073, 18621);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10461, 18073, 18621);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundStatement InstrumentReturnStatement(BoundReturnStatement original, BoundStatement rewritten)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10461, 18633, 19275);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 18771, 18835);

                rewritten = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.InstrumentReturnStatement(original, rewritten), 10461, 18783, 18834);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 18851, 19190) || true) && (f_10461_18855_18884(original) && (DynAbs.Tracing.TraceSender.Expression_True(10461, 18855, 18918) && f_10461_18888_18910(original) == null) && (DynAbs.Tracing.TraceSender.Expression_True(10461, 18855, 18964) && f_10461_18922_18944(original.Syntax) == SyntaxKind.Block))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10461, 18851, 19190);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 19056, 19175);

                    return f_10461_19063_19174(original.Syntax, rewritten, ((BlockSyntax)original.Syntax).CloseBraceToken.Span);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10461, 18851, 19190);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 19206, 19264);

                return f_10461_19213_19263(original.Syntax, rewritten);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10461, 18633, 19275);

                bool
                f_10461_18855_18884(Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                this_param)
                {
                    var return_v = this_param.WasCompilerGenerated;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10461, 18855, 18884);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10461_18888_18910(Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                this_param)
                {
                    var return_v = this_param.ExpressionOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10461, 18888, 18910);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10461_18922_18944(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10461, 18922, 18944);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundSequencePointWithSpan
                f_10461_19063_19174(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundStatement
                statementOpt, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundSequencePointWithSpan(syntax, statementOpt, span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10461, 19063, 19174);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundSequencePoint
                f_10461_19213_19263(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundStatement
                statementOpt)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundSequencePoint(syntax, statementOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10461, 19213, 19263);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10461, 18633, 19275);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10461, 18633, 19275);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundStatement InstrumentSwitchStatement(BoundSwitchStatement original, BoundStatement rewritten)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10461, 19287, 20033);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 19425, 19501);

                SwitchStatementSyntax
                switchSyntax = (SwitchStatementSyntax)original.Syntax
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 19515, 19761);

                TextSpan
                switchSequencePointSpan = TextSpan.FromBounds(switchSyntax.SwitchKeyword.SpanStart, (DynAbs.Tracing.TraceSender.Conditional_F1(10461, 19643, 19684) || (((f_10461_19644_19672(switchSyntax) != default) && DynAbs.Tracing.TraceSender.Conditional_F2(10461, 19687, 19724)) || DynAbs.Tracing.TraceSender.Conditional_F3(10461, 19727, 19759))) ? switchSyntax.CloseParenToken.Span.End : f_10461_19727_19750(switchSyntax).Span.End)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 19777, 20022);

                return f_10461_19784_20021(syntax: switchSyntax, statementOpt: DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.InstrumentSwitchStatement(original, rewritten), 10461, 19886, 19937), span: switchSequencePointSpan, hasErrors: false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10461, 19287, 20033);

                Microsoft.CodeAnalysis.SyntaxToken
                f_10461_19644_19672(Microsoft.CodeAnalysis.CSharp.Syntax.SwitchStatementSyntax
                this_param)
                {
                    var return_v = this_param.CloseParenToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10461, 19644, 19672);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10461_19727_19750(Microsoft.CodeAnalysis.CSharp.Syntax.SwitchStatementSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10461, 19727, 19750);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundSequencePointWithSpan
                f_10461_19784_20021(Microsoft.CodeAnalysis.CSharp.Syntax.SwitchStatementSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.BoundStatement
                statementOpt, Microsoft.CodeAnalysis.Text.TextSpan
                span, bool
                hasErrors)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundSequencePointWithSpan(syntax: (Microsoft.CodeAnalysis.SyntaxNode)syntax, statementOpt: statementOpt, span: span, hasErrors: hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10461, 19784, 20021);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10461, 19287, 20033);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10461, 19287, 20033);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundStatement InstrumentSwitchWhenClauseConditionalGotoBody(BoundExpression original, BoundStatement ifConditionGotoBody)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10461, 20045, 20599);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 20208, 20295);

                WhenClauseSyntax?
                whenClause = f_10461_20239_20294(original.Syntax)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 20309, 20342);

                f_10461_20309_20341(whenClause != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 20358, 20588);

                return f_10461_20365_20587(syntax: whenClause, statementOpt: DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.InstrumentSwitchWhenClauseConditionalGotoBody(original, ifConditionGotoBody), 10461, 20465, 20546), span: f_10461_20571_20586(whenClause));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10461, 20045, 20599);

                Microsoft.CodeAnalysis.CSharp.Syntax.WhenClauseSyntax?
                f_10461_20239_20294(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.FirstAncestorOrSelf<Microsoft.CodeAnalysis.CSharp.Syntax.WhenClauseSyntax>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10461, 20239, 20294);
                    return return_v;
                }


                int
                f_10461_20309_20341(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10461, 20309, 20341);
                    return 0;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_10461_20571_20586(Microsoft.CodeAnalysis.CSharp.Syntax.WhenClauseSyntax
                this_param)
                {
                    var return_v = this_param.Span;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10461, 20571, 20586);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundSequencePointWithSpan
                f_10461_20365_20587(Microsoft.CodeAnalysis.CSharp.Syntax.WhenClauseSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.BoundStatement
                statementOpt, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundSequencePointWithSpan(syntax: (Microsoft.CodeAnalysis.SyntaxNode)syntax, statementOpt: statementOpt, span: span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10461, 20365, 20587);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10461, 20045, 20599);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10461, 20045, 20599);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundStatement InstrumentUsingTargetCapture(BoundUsingStatement original, BoundStatement usingTargetCapture)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10461, 20611, 20936);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 20760, 20925);

                return f_10461_20767_20924(original.Syntax, DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.InstrumentUsingTargetCapture(original, usingTargetCapture), 10461, 20860, 20923));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10461, 20611, 20936);

                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10461_20767_20924(Microsoft.CodeAnalysis.SyntaxNode
                usingSyntax, Microsoft.CodeAnalysis.CSharp.BoundStatement
                rewrittenStatement)
                {
                    var return_v = AddSequencePoint((Microsoft.CodeAnalysis.CSharp.Syntax.UsingStatementSyntax)usingSyntax, rewrittenStatement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10461, 20767, 20924);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10461, 20611, 20936);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10461, 20611, 20936);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundExpression InstrumentCatchClauseFilter(BoundCatchBlock original, BoundExpression rewrittenFilter, SyntheticBoundNodeFactory factory)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10461, 20948, 21737);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 21126, 21213);

                rewrittenFilter = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.InstrumentCatchClauseFilter(original, rewrittenFilter, factory), 10461, 21144, 21212);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 21437, 21521);

                CatchFilterClauseSyntax?
                filterClause = f_10461_21477_21520(((CatchClauseSyntax)original.Syntax))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 21535, 21569);

                f_10461_21535_21568(filterClause is { });
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 21583, 21726);

                return f_10461_21590_21725(f_10461_21616_21701(filterClause, rewrittenFilter, f_10461_21680_21700(rewrittenFilter)), filterClause, factory);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10461, 20948, 21737);

                Microsoft.CodeAnalysis.CSharp.Syntax.CatchFilterClauseSyntax?
                f_10461_21477_21520(Microsoft.CodeAnalysis.CSharp.Syntax.CatchClauseSyntax
                this_param)
                {
                    var return_v = this_param.Filter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10461, 21477, 21520);
                    return return_v;
                }


                int
                f_10461_21535_21568(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10461, 21535, 21568);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10461_21680_21700(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10461, 21680, 21700);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundSequencePointExpression
                f_10461_21616_21701(Microsoft.CodeAnalysis.CSharp.Syntax.CatchFilterClauseSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundSequencePointExpression((Microsoft.CodeAnalysis.SyntaxNode)syntax, expression, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10461, 21616, 21701);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10461_21590_21725(Microsoft.CodeAnalysis.CSharp.BoundSequencePointExpression
                condition, Microsoft.CodeAnalysis.CSharp.Syntax.CatchFilterClauseSyntax
                synthesizedVariableSyntax, Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                factory)
                {
                    var return_v = AddConditionSequencePoint((Microsoft.CodeAnalysis.CSharp.BoundExpression)condition, (Microsoft.CodeAnalysis.SyntaxNode)synthesizedVariableSyntax, factory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10461, 21590, 21725);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10461, 20948, 21737);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10461, 20948, 21737);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundExpression InstrumentSwitchStatementExpression(BoundStatement original, BoundExpression rewrittenExpression, SyntheticBoundNodeFactory factory)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10461, 21749, 22299);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 22147, 22288);

                return f_10461_22154_22287(DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.InstrumentSwitchStatementExpression(original, rewrittenExpression, factory), 10461, 22180, 22260), original.Syntax, factory);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10461, 21749, 22299);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10461_22154_22287(Microsoft.CodeAnalysis.CSharp.BoundExpression
                condition, Microsoft.CodeAnalysis.SyntaxNode
                synthesizedVariableSyntax, Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                factory)
                {
                    var return_v = AddConditionSequencePoint(condition, synthesizedVariableSyntax, factory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10461, 22154, 22287);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10461, 21749, 22299);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10461, 21749, 22299);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundExpression InstrumentSwitchExpressionArmExpression(BoundExpression original, BoundExpression rewrittenExpression, SyntheticBoundNodeFactory factory)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10461, 22311, 22685);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 22505, 22674);

                return f_10461_22512_22673(original.Syntax, DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.InstrumentSwitchExpressionArmExpression(original, rewrittenExpression, factory), 10461, 22562, 22646), f_10461_22648_22672(rewrittenExpression));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10461, 22311, 22685);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10461_22648_22672(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10461, 22648, 22672);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundSequencePointExpression
                f_10461_22512_22673(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundSequencePointExpression(syntax, expression, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10461, 22512, 22673);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10461, 22311, 22685);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10461, 22311, 22685);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundStatement InstrumentSwitchBindCasePatternVariables(BoundStatement bindings)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10461, 22697, 23091);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 22984, 23080);

                return f_10461_22991_23079(DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.InstrumentSwitchBindCasePatternVariables(bindings), 10461, 23023, 23078));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10461, 22697, 23091);

                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10461_22991_23079(Microsoft.CodeAnalysis.CSharp.BoundStatement
                statementOpt)
                {
                    var return_v = BoundSequencePoint.CreateHidden(statementOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10461, 22991, 23079);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10461, 22697, 23091);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10461, 22697, 23091);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static DebugInfoInjector()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10461, 874, 23098);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10461, 1163, 1215);
            Singleton = f_10461_1175_1215(Instrumenter.NoOp); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10461, 874, 23098);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10461, 874, 23098);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10461, 874, 23098);

        static Microsoft.CodeAnalysis.CSharp.DebugInfoInjector
        f_10461_1175_1215(Microsoft.CodeAnalysis.CSharp.Instrumenter
        previous)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.DebugInfoInjector(previous);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10461, 1175, 1215);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Instrumenter
        f_10461_1296_1304_C(Microsoft.CodeAnalysis.CSharp.Instrumenter
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10461, 1228, 1327);
            return return_v;
        }

    }
}
