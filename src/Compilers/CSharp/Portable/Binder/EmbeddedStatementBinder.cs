// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed class EmbeddedStatementBinder : LocalScopeBinder
    {
        private readonly StatementSyntax _statement;

        public EmbeddedStatementBinder(Binder enclosing, StatementSyntax statement)
        : base(f_10332_854_863_C(enclosing), enclosing.Flags)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10332, 758, 986);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10332, 735, 745);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10332, 906, 938);

                f_10332_906_937(statement != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10332, 952, 975);

                _statement = statement;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10332, 758, 986);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10332, 758, 986);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10332, 758, 986);
            }
        }

        protected override ImmutableArray<LocalSymbol> BuildLocals()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10332, 998, 1270);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10332, 1083, 1158);

                ArrayBuilder<LocalSymbol>
                locals = f_10332_1118_1157()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10332, 1172, 1210);

                f_10332_1172_1209(this, this, _statement, locals);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10332, 1224, 1259);

                return f_10332_1231_1258(locals);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10332, 998, 1270);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10332_1118_1157()
                {
                    var return_v = ArrayBuilder<LocalSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10332, 1118, 1157);
                    return return_v;
                }


                int
                f_10332_1172_1209(Microsoft.CodeAnalysis.CSharp.EmbeddedStatementBinder
                this_param, Microsoft.CodeAnalysis.CSharp.EmbeddedStatementBinder
                enclosingBinder, Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                statement, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals)
                {
                    this_param.BuildLocals((Microsoft.CodeAnalysis.CSharp.Binder)enclosingBinder, statement, locals);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10332, 1172, 1209);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10332_1231_1258(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10332, 1231, 1258);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10332, 998, 1270);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10332, 998, 1270);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override ImmutableArray<LocalFunctionSymbol> BuildLocalFunctions()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10332, 1282, 1595);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10332, 1383, 1431);

                ArrayBuilder<LocalFunctionSymbol>
                locals = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10332, 1445, 1489);

                f_10332_1445_1488(this, _statement, ref locals);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10332, 1503, 1584);

                return f_10332_1510_1538_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(locals, 10332, 1510, 1538)?.ToImmutableAndFree()) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol>?>(10332, 1510, 1583) ?? ImmutableArray<LocalFunctionSymbol>.Empty);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10332, 1282, 1595);

                int
                f_10332_1445_1488(Microsoft.CodeAnalysis.CSharp.EmbeddedStatementBinder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                statement, ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol>?
                locals)
                {
                    this_param.BuildLocalFunctions(statement, ref locals);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10332, 1445, 1488);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol>?
                f_10332_1510_1538_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol>?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10332, 1510, 1538);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10332, 1282, 1595);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10332, 1282, 1595);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool IsLocalFunctionsScopeBinder
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10332, 1682, 1745);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10332, 1718, 1730);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10332, 1682, 1745);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10332, 1607, 1756);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10332, 1607, 1756);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override ImmutableArray<LabelSymbol> BuildLabels()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10332, 1768, 2140);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10332, 1853, 1893);

                ArrayBuilder<LabelSymbol>
                labels = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10332, 1907, 1974);

                var
                containingMethod = (MethodSymbol)f_10332_1944_1973(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10332, 1988, 2042);

                f_10332_1988_2041(containingMethod, _statement, ref labels);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10332, 2056, 2129);

                return f_10332_2063_2091_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(labels, 10332, 2063, 2091)?.ToImmutableAndFree()) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>?>(10332, 2063, 2128) ?? ImmutableArray<LabelSymbol>.Empty);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10332, 1768, 2140);

                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10332_1944_1973(Microsoft.CodeAnalysis.CSharp.EmbeddedStatementBinder
                this_param)
                {
                    var return_v = this_param.ContainingMemberOrLambda;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10332, 1944, 1973);
                    return return_v;
                }


                int
                f_10332_1988_2041(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                containingMethod, Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                statement, ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>?
                labels)
                {
                    BuildLabels(containingMethod, statement, ref labels);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10332, 1988, 2041);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>?
                f_10332_2063_2091_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10332, 2063, 2091);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10332, 1768, 2140);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10332, 1768, 2140);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool IsLabelsScopeBinder
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10332, 2219, 2282);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10332, 2255, 2267);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10332, 2219, 2282);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10332, 2152, 2293);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10332, 2152, 2293);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ImmutableArray<LocalSymbol> GetDeclaredLocalsForScope(SyntaxNode scopeDesignator)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10332, 2305, 2599);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10332, 2429, 2535) || true) && (f_10332_2433_2448() == scopeDesignator)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10332, 2429, 2535);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10332, 2501, 2520);

                    return f_10332_2508_2519(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10332, 2429, 2535);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10332, 2551, 2588);

                throw f_10332_2557_2587();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10332, 2305, 2599);

                Microsoft.CodeAnalysis.SyntaxNode
                f_10332_2433_2448()
                {
                    var return_v = ScopeDesignator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10332, 2433, 2448);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10332_2508_2519(Microsoft.CodeAnalysis.CSharp.EmbeddedStatementBinder
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10332, 2508, 2519);
                    return return_v;
                }


                System.Exception
                f_10332_2557_2587()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10332, 2557, 2587);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10332, 2305, 2599);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10332, 2305, 2599);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override SyntaxNode ScopeDesignator
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10332, 2680, 2749);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10332, 2716, 2734);

                    return _statement;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10332, 2680, 2749);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10332, 2611, 2760);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10332, 2611, 2760);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ImmutableArray<LocalFunctionSymbol> GetDeclaredLocalFunctionsForScope(CSharpSyntaxNode scopeDesignator)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10332, 2772, 3096);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10332, 2918, 3032) || true) && (f_10332_2922_2937() == scopeDesignator)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10332, 2918, 3032);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10332, 2990, 3017);

                    return f_10332_2997_3016(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10332, 2918, 3032);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10332, 3048, 3085);

                throw f_10332_3054_3084();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10332, 2772, 3096);

                Microsoft.CodeAnalysis.SyntaxNode
                f_10332_2922_2937()
                {
                    var return_v = ScopeDesignator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10332, 2922, 2937);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol>
                f_10332_2997_3016(Microsoft.CodeAnalysis.CSharp.EmbeddedStatementBinder
                this_param)
                {
                    var return_v = this_param.LocalFunctions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10332, 2997, 3016);
                    return return_v;
                }


                System.Exception
                f_10332_3054_3084()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10332, 3054, 3084);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10332, 2772, 3096);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10332, 2772, 3096);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static EmbeddedStatementBinder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10332, 621, 3103);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10332, 621, 3103);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10332, 621, 3103);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10332, 621, 3103);

        int
        f_10332_906_937(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10332, 906, 937);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Binder
        f_10332_854_863_C(Microsoft.CodeAnalysis.CSharp.Binder
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10332, 758, 986);
            return return_v;
        }

    }
}
