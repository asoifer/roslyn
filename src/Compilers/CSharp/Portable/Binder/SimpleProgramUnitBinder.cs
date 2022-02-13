// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using Microsoft.CodeAnalysis.CSharp.Symbols;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed class SimpleProgramUnitBinder : LocalScopeBinder
    {
        private readonly SimpleProgramBinder _scope;

        public SimpleProgramUnitBinder(Binder enclosing, SimpleProgramBinder scope)
        : base(f_10367_1070_1079_C(enclosing), enclosing.Flags)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10367, 974, 1148);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10367, 957, 963);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10367, 1122, 1137);

                _scope = scope;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10367, 974, 1148);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10367, 974, 1148);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10367, 974, 1148);
            }
        }

        protected override ImmutableArray<LocalSymbol> BuildLocals()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10367, 1160, 1277);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10367, 1245, 1266);

                return f_10367_1252_1265(_scope);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10367, 1160, 1277);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10367_1252_1265(Microsoft.CodeAnalysis.CSharp.SimpleProgramBinder
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10367, 1252, 1265);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10367, 1160, 1277);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10367, 1160, 1277);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override ImmutableArray<LocalFunctionSymbol> BuildLocalFunctions()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10367, 1289, 1430);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10367, 1390, 1419);

                return f_10367_1397_1418(_scope);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10367, 1289, 1430);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol>
                f_10367_1397_1418(Microsoft.CodeAnalysis.CSharp.SimpleProgramBinder
                this_param)
                {
                    var return_v = this_param.LocalFunctions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10367, 1397, 1418);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10367, 1289, 1430);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10367, 1289, 1430);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool IsLocalFunctionsScopeBinder
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10367, 1517, 1610);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10367, 1553, 1595);

                    return f_10367_1560_1594(_scope);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10367, 1517, 1610);

                    bool
                    f_10367_1560_1594(Microsoft.CodeAnalysis.CSharp.SimpleProgramBinder
                    this_param)
                    {
                        var return_v = this_param.IsLocalFunctionsScopeBinder;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10367, 1560, 1594);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10367, 1442, 1621);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10367, 1442, 1621);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override ImmutableArray<LabelSymbol> BuildLabels()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10367, 1633, 1770);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10367, 1718, 1759);

                return ImmutableArray<LabelSymbol>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10367, 1633, 1770);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10367, 1633, 1770);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10367, 1633, 1770);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool IsLabelsScopeBinder
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10367, 1849, 1913);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10367, 1885, 1898);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10367, 1849, 1913);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10367, 1782, 1924);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10367, 1782, 1924);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ImmutableArray<LocalSymbol> GetDeclaredLocalsForScope(SyntaxNode scopeDesignator)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10367, 1936, 2128);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10367, 2060, 2117);

                return f_10367_2067_2116(_scope, scopeDesignator);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10367, 1936, 2128);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10367_2067_2116(Microsoft.CodeAnalysis.CSharp.SimpleProgramBinder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                scopeDesignator)
                {
                    var return_v = this_param.GetDeclaredLocalsForScope(scopeDesignator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10367, 2067, 2116);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10367, 1936, 2128);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10367, 1936, 2128);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override SyntaxNode? ScopeDesignator
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10367, 2210, 2291);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10367, 2246, 2276);

                    return f_10367_2253_2275(_scope);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10367, 2210, 2291);

                    Microsoft.CodeAnalysis.SyntaxNode
                    f_10367_2253_2275(Microsoft.CodeAnalysis.CSharp.SimpleProgramBinder
                    this_param)
                    {
                        var return_v = this_param.ScopeDesignator;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10367, 2253, 2275);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10367, 2140, 2302);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10367, 2140, 2302);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ImmutableArray<LocalFunctionSymbol> GetDeclaredLocalFunctionsForScope(CSharpSyntaxNode scopeDesignator)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10367, 2314, 2536);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10367, 2460, 2525);

                return f_10367_2467_2524(_scope, scopeDesignator);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10367, 2314, 2536);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol>
                f_10367_2467_2524(Microsoft.CodeAnalysis.CSharp.SimpleProgramBinder
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                scopeDesignator)
                {
                    var return_v = this_param.GetDeclaredLocalFunctionsForScope(scopeDesignator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10367, 2467, 2524);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10367, 2314, 2536);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10367, 2314, 2536);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SimpleProgramUnitBinder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10367, 839, 2543);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10367, 839, 2543);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10367, 839, 2543);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10367, 839, 2543);

        static Microsoft.CodeAnalysis.CSharp.Binder
        f_10367_1070_1079_C(Microsoft.CodeAnalysis.CSharp.Binder
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10367, 974, 1148);
            return return_v;
        }

    }
}
