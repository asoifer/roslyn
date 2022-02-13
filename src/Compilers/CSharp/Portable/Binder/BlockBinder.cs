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
    internal sealed class BlockBinder : LocalScopeBinder
    {
        private readonly BlockSyntax _block;

        public BlockBinder(Binder enclosing, BlockSyntax block)
        : this(f_10324_712_721_C(enclosing), block, enclosing.Flags)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10324, 636, 768);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10324, 636, 768);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10324, 636, 768);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10324, 636, 768);
            }
        }

        public BlockBinder(Binder enclosing, BlockSyntax block, BinderFlags additionalFlags)
        : base(f_10324_885_894_C(enclosing), enclosing.Flags | additionalFlags)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10324, 780, 1023);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10324, 617, 623);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10324, 955, 983);

                f_10324_955_982(block != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10324, 997, 1012);

                _block = block;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10324, 780, 1023);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10324, 780, 1023);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10324, 780, 1023);
            }
        }

        protected override ImmutableArray<LocalSymbol> BuildLocals()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10324, 1035, 1175);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10324, 1120, 1164);

                return f_10324_1127_1163(this, f_10324_1139_1156(_block), this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10324, 1035, 1175);

                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax>
                f_10324_1139_1156(Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
                this_param)
                {
                    var return_v = this_param.Statements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10324, 1139, 1156);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10324_1127_1163(Microsoft.CodeAnalysis.CSharp.BlockBinder
                this_param, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax>
                statements, Microsoft.CodeAnalysis.CSharp.BlockBinder
                enclosingBinder)
                {
                    var return_v = this_param.BuildLocals(statements, (Microsoft.CodeAnalysis.CSharp.Binder)enclosingBinder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10324, 1127, 1163);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10324, 1035, 1175);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10324, 1035, 1175);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override ImmutableArray<LocalFunctionSymbol> BuildLocalFunctions()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10324, 1187, 1345);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10324, 1288, 1334);

                return f_10324_1295_1333(this, f_10324_1315_1332(_block));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10324, 1187, 1345);

                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax>
                f_10324_1315_1332(Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
                this_param)
                {
                    var return_v = this_param.Statements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10324, 1315, 1332);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol>
                f_10324_1295_1333(Microsoft.CodeAnalysis.CSharp.BlockBinder
                this_param, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax>
                statements)
                {
                    var return_v = this_param.BuildLocalFunctions(statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10324, 1295, 1333);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10324, 1187, 1345);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10324, 1187, 1345);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool IsLocalFunctionsScopeBinder
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10324, 1432, 1495);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10324, 1468, 1480);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10324, 1432, 1495);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10324, 1357, 1506);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10324, 1357, 1506);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override ImmutableArray<LabelSymbol> BuildLabels()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10324, 1518, 1820);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10324, 1603, 1643);

                ArrayBuilder<LabelSymbol>
                labels = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10324, 1657, 1705);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.BuildLabels(f_10324_1674_1691(_block), ref labels), 10324, 1657, 1704);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10324, 1719, 1809);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10324, 1726, 1742) || (((labels != null) && DynAbs.Tracing.TraceSender.Conditional_F2(10324, 1745, 1772)) || DynAbs.Tracing.TraceSender.Conditional_F3(10324, 1775, 1808))) ? f_10324_1745_1772(labels) : ImmutableArray<LabelSymbol>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10324, 1518, 1820);

                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax>
                f_10324_1674_1691(Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
                this_param)
                {
                    var return_v = this_param.Statements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10324, 1674, 1691);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                f_10324_1745_1772(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10324, 1745, 1772);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10324, 1518, 1820);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10324, 1518, 1820);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool IsLabelsScopeBinder
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10324, 1899, 1962);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10324, 1935, 1947);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10324, 1899, 1962);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10324, 1832, 1973);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10324, 1832, 1973);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ImmutableArray<LocalSymbol> GetDeclaredLocalsForScope(SyntaxNode scopeDesignator)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10324, 1985, 2279);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10324, 2109, 2215) || true) && (f_10324_2113_2128() == scopeDesignator)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10324, 2109, 2215);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10324, 2181, 2200);

                    return f_10324_2188_2199(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10324, 2109, 2215);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10324, 2231, 2268);

                throw f_10324_2237_2267();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10324, 1985, 2279);

                Microsoft.CodeAnalysis.SyntaxNode
                f_10324_2113_2128()
                {
                    var return_v = ScopeDesignator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10324, 2113, 2128);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10324_2188_2199(Microsoft.CodeAnalysis.CSharp.BlockBinder
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10324, 2188, 2199);
                    return return_v;
                }


                System.Exception
                f_10324_2237_2267()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10324, 2237, 2267);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10324, 1985, 2279);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10324, 1985, 2279);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override SyntaxNode ScopeDesignator
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10324, 2360, 2425);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10324, 2396, 2410);

                    return _block;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10324, 2360, 2425);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10324, 2291, 2436);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10324, 2291, 2436);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ImmutableArray<LocalFunctionSymbol> GetDeclaredLocalFunctionsForScope(CSharpSyntaxNode scopeDesignator)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10324, 2448, 2772);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10324, 2594, 2708) || true) && (f_10324_2598_2613() == scopeDesignator)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10324, 2594, 2708);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10324, 2666, 2693);

                    return f_10324_2673_2692(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10324, 2594, 2708);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10324, 2724, 2761);

                throw f_10324_2730_2760();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10324, 2448, 2772);

                Microsoft.CodeAnalysis.SyntaxNode
                f_10324_2598_2613()
                {
                    var return_v = ScopeDesignator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10324, 2598, 2613);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol>
                f_10324_2673_2692(Microsoft.CodeAnalysis.CSharp.BlockBinder
                this_param)
                {
                    var return_v = this_param.LocalFunctions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10324, 2673, 2692);
                    return return_v;
                }


                System.Exception
                f_10324_2730_2760()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10324, 2730, 2760);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10324, 2448, 2772);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10324, 2448, 2772);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static BlockBinder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10324, 519, 2779);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10324, 519, 2779);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10324, 519, 2779);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10324, 519, 2779);

        static Microsoft.CodeAnalysis.CSharp.Binder
        f_10324_712_721_C(Microsoft.CodeAnalysis.CSharp.Binder
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10324, 636, 768);
            return return_v;
        }


        int
        f_10324_955_982(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10324, 955, 982);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Binder
        f_10324_885_894_C(Microsoft.CodeAnalysis.CSharp.Binder
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10324, 780, 1023);
            return return_v;
        }

    }
}
