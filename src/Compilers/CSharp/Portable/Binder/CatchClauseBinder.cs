// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed class CatchClauseBinder : LocalScopeBinder
    {
        private readonly CatchClauseSyntax _syntax;

        public CatchClauseBinder(Binder enclosing, CatchClauseSyntax syntax)
        : base(f_10326_723_732_C(enclosing), (enclosing.Flags | BinderFlags.InCatchBlock) & ~BinderFlags.InNestedFinallyBlock)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10326, 634, 911);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10326, 614, 621);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10326, 840, 869);

                f_10326_840_868(syntax != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10326, 883, 900);

                _syntax = syntax;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10326, 634, 911);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10326, 634, 911);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10326, 634, 911);
            }
        }

        protected override ImmutableArray<LocalSymbol> BuildLocals()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10326, 923, 1683);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10326, 1008, 1061);

                var
                locals = f_10326_1021_1060()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10326, 1077, 1118);

                var
                declarationOpt = f_10326_1098_1117(_syntax)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10326, 1132, 1434) || true) && ((declarationOpt != null) && (DynAbs.Tracing.TraceSender.Expression_True(10326, 1136, 1217) && (declarationOpt.Identifier.Kind() != SyntaxKind.None)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10326, 1132, 1434);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10326, 1251, 1419);

                    f_10326_1251_1418(locals, f_10326_1262_1417(f_10326_1290_1319(this), this, false, f_10326_1334_1353(declarationOpt), f_10326_1355_1380(declarationOpt), LocalDeclarationKind.CatchVariable));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10326, 1132, 1434);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10326, 1450, 1621) || true) && (f_10326_1454_1468(_syntax) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10326, 1450, 1621);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10326, 1510, 1606);

                    f_10326_1510_1605(this, locals, f_10326_1573_1604(f_10326_1573_1587(_syntax)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10326, 1450, 1621);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10326, 1637, 1672);

                return f_10326_1644_1671(locals);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10326, 923, 1683);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10326_1021_1060()
                {
                    var return_v = ArrayBuilder<LocalSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10326, 1021, 1060);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.CatchDeclarationSyntax?
                f_10326_1098_1117(Microsoft.CodeAnalysis.CSharp.Syntax.CatchClauseSyntax
                this_param)
                {
                    var return_v = this_param.Declaration;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10326, 1098, 1117);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10326_1290_1319(Microsoft.CodeAnalysis.CSharp.CatchClauseBinder
                this_param)
                {
                    var return_v = this_param.ContainingMemberOrLambda;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10326, 1290, 1319);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10326_1334_1353(Microsoft.CodeAnalysis.CSharp.Syntax.CatchDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10326, 1334, 1353);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10326_1355_1380(Microsoft.CodeAnalysis.CSharp.Syntax.CatchDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Identifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10326, 1355, 1380);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol
                f_10326_1262_1417(Microsoft.CodeAnalysis.CSharp.Symbol?
                containingSymbol, Microsoft.CodeAnalysis.CSharp.CatchClauseBinder
                scopeBinder, bool
                allowRefKind, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                typeSyntax, Microsoft.CodeAnalysis.SyntaxToken
                identifierToken, Microsoft.CodeAnalysis.CSharp.Symbols.LocalDeclarationKind
                declarationKind)
                {
                    var return_v = SourceLocalSymbol.MakeLocal(containingSymbol, (Microsoft.CodeAnalysis.CSharp.Binder)scopeBinder, allowRefKind, typeSyntax, identifierToken, declarationKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10326, 1262, 1417);
                    return return_v;
                }


                int
                f_10326_1251_1418(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10326, 1251, 1418);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.CatchFilterClauseSyntax?
                f_10326_1454_1468(Microsoft.CodeAnalysis.CSharp.Syntax.CatchClauseSyntax
                this_param)
                {
                    var return_v = this_param.Filter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10326, 1454, 1468);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.CatchFilterClauseSyntax
                f_10326_1573_1587(Microsoft.CodeAnalysis.CSharp.Syntax.CatchClauseSyntax
                this_param)
                {
                    var return_v = this_param.Filter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10326, 1573, 1587);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10326_1573_1604(Microsoft.CodeAnalysis.CSharp.Syntax.CatchFilterClauseSyntax
                this_param)
                {
                    var return_v = this_param.FilterExpression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10326, 1573, 1604);
                    return return_v;
                }


                int
                f_10326_1510_1605(Microsoft.CodeAnalysis.CSharp.CatchClauseBinder
                scopeBinder, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                builder, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node)
                {
                    ExpressionVariableFinder.FindExpressionVariables((Microsoft.CodeAnalysis.CSharp.Binder)scopeBinder, builder, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10326, 1510, 1605);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10326_1644_1671(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10326, 1644, 1671);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10326, 923, 1683);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10326, 923, 1683);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ImmutableArray<LocalSymbol> GetDeclaredLocalsForScope(SyntaxNode scopeDesignator)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10326, 1695, 1981);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10326, 1819, 1917) || true) && (_syntax == scopeDesignator)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10326, 1819, 1917);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10326, 1883, 1902);

                    return f_10326_1890_1901(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10326, 1819, 1917);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10326, 1933, 1970);

                throw f_10326_1939_1969();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10326, 1695, 1981);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10326_1890_1901(Microsoft.CodeAnalysis.CSharp.CatchClauseBinder
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10326, 1890, 1901);
                    return return_v;
                }


                System.Exception
                f_10326_1939_1969()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10326, 1939, 1969);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10326, 1695, 1981);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10326, 1695, 1981);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ImmutableArray<LocalFunctionSymbol> GetDeclaredLocalFunctionsForScope(CSharpSyntaxNode scopeDesignator)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10326, 1993, 2187);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10326, 2139, 2176);

                throw f_10326_2145_2175();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10326, 1993, 2187);

                System.Exception
                f_10326_2145_2175()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10326, 2145, 2175);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10326, 1993, 2187);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10326, 1993, 2187);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override SyntaxNode ScopeDesignator
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10326, 2268, 2334);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10326, 2304, 2319);

                    return _syntax;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10326, 2268, 2334);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10326, 2199, 2345);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10326, 2199, 2345);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static CatchClauseBinder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10326, 504, 2352);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10326, 504, 2352);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10326, 504, 2352);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10326, 504, 2352);

        int
        f_10326_840_868(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10326, 840, 868);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Binder
        f_10326_723_732_C(Microsoft.CodeAnalysis.CSharp.Binder
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10326, 634, 911);
            return return_v;
        }

    }
}
