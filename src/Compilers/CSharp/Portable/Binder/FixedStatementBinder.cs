// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed class FixedStatementBinder : LocalScopeBinder
    {
        private readonly FixedStatementSyntax _syntax;

        public FixedStatementBinder(Binder enclosing, FixedStatementSyntax syntax)
        : base(f_10338_806_815_C(enclosing))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10338, 711, 912);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10338, 691, 698);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10338, 841, 870);

                f_10338_841_869(syntax != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10338, 884, 901);

                _syntax = syntax;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10338, 711, 912);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10338, 711, 912);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10338, 711, 912);
            }
        }

        protected override ImmutableArray<LocalSymbol> BuildLocals()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10338, 924, 2272);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10338, 1009, 2204) || true) && (f_10338_1013_1032(_syntax) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10338, 1009, 2204);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10338, 1074, 1154);

                    var
                    locals = f_10338_1087_1153(f_10338_1117_1136(_syntax).Variables.Count)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10338, 1174, 1672);

                    f_10338_1174_1671(f_10338_1174_1198(f_10338_1174_1193(_syntax)), (rankSpecifier, args) =>
                                    {
                                        foreach (var size in rankSpecifier.Sizes)
                                        {
                                            if (size.Kind() != SyntaxKind.OmittedArraySizeExpression)
                                            {
                                                ExpressionVariableFinder.FindExpressionVariables(args.binder, args.locals, size);
                                            }
                                        }
                                    }, (binder: this, locals: locals));
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10338, 1692, 2141);
                        foreach (VariableDeclaratorSyntax declarator in f_10338_1740_1769_I(f_10338_1740_1769(f_10338_1740_1759(_syntax))))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10338, 1692, 2141);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10338, 1811, 1902);

                            f_10338_1811_1901(locals, f_10338_1822_1900(this, f_10338_1832_1851(_syntax), declarator, LocalDeclarationKind.FixedVariable));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10338, 2047, 2122);

                            f_10338_2047_2121(this, locals, declarator);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10338, 1692, 2141);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10338, 1, 450);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10338, 1, 450);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10338, 2161, 2189);

                    return f_10338_2168_2188(locals);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10338, 1009, 2204);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10338, 2220, 2261);

                return ImmutableArray<LocalSymbol>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10338, 924, 2272);

                Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax
                f_10338_1013_1032(Microsoft.CodeAnalysis.CSharp.Syntax.FixedStatementSyntax
                this_param)
                {
                    var return_v = this_param.Declaration;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10338, 1013, 1032);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax
                f_10338_1117_1136(Microsoft.CodeAnalysis.CSharp.Syntax.FixedStatementSyntax
                this_param)
                {
                    var return_v = this_param.Declaration;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10338, 1117, 1136);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10338_1087_1153(int
                size)
                {
                    var return_v = new Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>(size);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10338, 1087, 1153);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax
                f_10338_1174_1193(Microsoft.CodeAnalysis.CSharp.Syntax.FixedStatementSyntax
                this_param)
                {
                    var return_v = this_param.Declaration;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10338, 1174, 1193);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10338_1174_1198(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10338, 1174, 1198);
                    return return_v;
                }


                int
                f_10338_1174_1671(Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                type, System.Action<Microsoft.CodeAnalysis.CSharp.Syntax.ArrayRankSpecifierSyntax, (Microsoft.CodeAnalysis.CSharp.FixedStatementBinder binder, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol> locals)>
                action, (Microsoft.CodeAnalysis.CSharp.FixedStatementBinder binder, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol> locals)
                argument)
                {
                    type.VisitRankSpecifiers<(Microsoft.CodeAnalysis.CSharp.FixedStatementBinder binder, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol> locals)>(action, argument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10338, 1174, 1671);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax
                f_10338_1740_1759(Microsoft.CodeAnalysis.CSharp.Syntax.FixedStatementSyntax
                this_param)
                {
                    var return_v = this_param.Declaration;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10338, 1740, 1759);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax>
                f_10338_1740_1769(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Variables;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10338, 1740, 1769);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax
                f_10338_1832_1851(Microsoft.CodeAnalysis.CSharp.Syntax.FixedStatementSyntax
                this_param)
                {
                    var return_v = this_param.Declaration;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10338, 1832, 1851);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol
                f_10338_1822_1900(Microsoft.CodeAnalysis.CSharp.FixedStatementBinder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax
                declaration, Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax
                declarator, Microsoft.CodeAnalysis.CSharp.Symbols.LocalDeclarationKind
                kind)
                {
                    var return_v = this_param.MakeLocal(declaration, declarator, kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10338, 1822, 1900);
                    return return_v;
                }


                int
                f_10338_1811_1901(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10338, 1811, 1901);
                    return 0;
                }


                int
                f_10338_2047_2121(Microsoft.CodeAnalysis.CSharp.FixedStatementBinder
                scopeBinder, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                builder, Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax
                node)
                {
                    ExpressionVariableFinder.FindExpressionVariables((Microsoft.CodeAnalysis.CSharp.Binder)scopeBinder, builder, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10338, 2047, 2121);
                    return 0;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax>
                f_10338_1740_1769_I(Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10338, 1740, 1769);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10338_2168_2188(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10338, 2168, 2188);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10338, 924, 2272);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10338, 924, 2272);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ImmutableArray<LocalSymbol> GetDeclaredLocalsForScope(SyntaxNode scopeDesignator)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10338, 2284, 2570);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10338, 2408, 2506) || true) && (_syntax == scopeDesignator)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10338, 2408, 2506);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10338, 2472, 2491);

                    return f_10338_2479_2490(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10338, 2408, 2506);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10338, 2522, 2559);

                throw f_10338_2528_2558();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10338, 2284, 2570);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10338_2479_2490(Microsoft.CodeAnalysis.CSharp.FixedStatementBinder
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10338, 2479, 2490);
                    return return_v;
                }


                System.Exception
                f_10338_2528_2558()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10338, 2528, 2558);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10338, 2284, 2570);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10338, 2284, 2570);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ImmutableArray<LocalFunctionSymbol> GetDeclaredLocalFunctionsForScope(CSharpSyntaxNode scopeDesignator)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10338, 2582, 2776);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10338, 2728, 2765);

                throw f_10338_2734_2764();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10338, 2582, 2776);

                System.Exception
                f_10338_2734_2764()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10338, 2734, 2764);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10338, 2582, 2776);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10338, 2582, 2776);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override SyntaxNode ScopeDesignator
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10338, 2857, 2923);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10338, 2893, 2908);

                    return _syntax;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10338, 2857, 2923);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10338, 2788, 2934);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10338, 2788, 2934);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static FixedStatementBinder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10338, 575, 2941);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10338, 575, 2941);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10338, 575, 2941);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10338, 575, 2941);

        int
        f_10338_841_869(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10338, 841, 869);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Binder
        f_10338_806_815_C(Microsoft.CodeAnalysis.CSharp.Binder
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10338, 711, 912);
            return return_v;
        }

    }
}
