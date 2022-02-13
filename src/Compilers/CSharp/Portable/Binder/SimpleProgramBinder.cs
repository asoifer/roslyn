// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed class SimpleProgramBinder : LocalScopeBinder
    {
        private readonly SynthesizedSimpleProgramEntryPointSymbol _entryPoint;

        public SimpleProgramBinder(Binder enclosing, SynthesizedSimpleProgramEntryPointSymbol entryPoint)
        : base(f_10366_849_858_C(enclosing), enclosing.Flags)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10366, 731, 937);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10366, 707, 718);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10366, 901, 926);

                _entryPoint = entryPoint;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10366, 731, 937);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10366, 731, 937);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10366, 731, 937);
            }
        }

        protected override ImmutableArray<LocalSymbol> BuildLocals()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10366, 949, 1474);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10366, 1034, 1109);

                ArrayBuilder<LocalSymbol>
                locals = f_10366_1069_1108()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10366, 1125, 1412);
                    foreach (var statement in f_10366_1151_1186_I(f_10366_1151_1186(f_10366_1151_1178(_entryPoint))))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10366, 1125, 1412);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10366, 1220, 1397) || true) && (statement is GlobalStatementSyntax topLevelStatement)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10366, 1220, 1397);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10366, 1318, 1378);

                            f_10366_1318_1377(this, this, f_10366_1341_1368(topLevelStatement), locals);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10366, 1220, 1397);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10366, 1125, 1412);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10366, 1, 288);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10366, 1, 288);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10366, 1428, 1463);

                return f_10366_1435_1462(locals);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10366, 949, 1474);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10366_1069_1108()
                {
                    var return_v = ArrayBuilder<LocalSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10366, 1069, 1108);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax
                f_10366_1151_1178(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedSimpleProgramEntryPointSymbol
                this_param)
                {
                    var return_v = this_param.CompilationUnit;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10366, 1151, 1178);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax>
                f_10366_1151_1186(Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax
                this_param)
                {
                    var return_v = this_param.Members;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10366, 1151, 1186);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                f_10366_1341_1368(Microsoft.CodeAnalysis.CSharp.Syntax.GlobalStatementSyntax
                this_param)
                {
                    var return_v = this_param.Statement;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10366, 1341, 1368);
                    return return_v;
                }


                int
                f_10366_1318_1377(Microsoft.CodeAnalysis.CSharp.SimpleProgramBinder
                this_param, Microsoft.CodeAnalysis.CSharp.SimpleProgramBinder
                enclosingBinder, Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                statement, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals)
                {
                    this_param.BuildLocals((Microsoft.CodeAnalysis.CSharp.Binder)enclosingBinder, statement, locals);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10366, 1318, 1377);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax>
                f_10366_1151_1186_I(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10366, 1151, 1186);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10366_1435_1462(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10366, 1435, 1462);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10366, 949, 1474);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10366, 949, 1474);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override ImmutableArray<LocalFunctionSymbol> BuildLocalFunctions()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10366, 1486, 2053);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10366, 1587, 1636);

                ArrayBuilder<LocalFunctionSymbol>?
                locals = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10366, 1652, 1945);
                    foreach (var statement in f_10366_1678_1713_I(f_10366_1678_1713(f_10366_1678_1705(_entryPoint))))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10366, 1652, 1945);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10366, 1747, 1930) || true) && (statement is GlobalStatementSyntax topLevelStatement)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10366, 1747, 1930);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10366, 1845, 1911);

                            f_10366_1845_1910(this, f_10366_1870_1897(topLevelStatement), ref locals);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10366, 1747, 1930);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10366, 1652, 1945);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10366, 1, 294);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10366, 1, 294);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10366, 1961, 2042);

                return f_10366_1968_1996_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(locals, 10366, 1968, 1996)?.ToImmutableAndFree()) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol>?>(10366, 1968, 2041) ?? ImmutableArray<LocalFunctionSymbol>.Empty);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10366, 1486, 2053);

                Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax
                f_10366_1678_1705(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedSimpleProgramEntryPointSymbol
                this_param)
                {
                    var return_v = this_param.CompilationUnit;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10366, 1678, 1705);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax>
                f_10366_1678_1713(Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax
                this_param)
                {
                    var return_v = this_param.Members;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10366, 1678, 1713);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                f_10366_1870_1897(Microsoft.CodeAnalysis.CSharp.Syntax.GlobalStatementSyntax
                this_param)
                {
                    var return_v = this_param.Statement;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10366, 1870, 1897);
                    return return_v;
                }


                int
                f_10366_1845_1910(Microsoft.CodeAnalysis.CSharp.SimpleProgramBinder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                statement, ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol>?
                locals)
                {
                    this_param.BuildLocalFunctions(statement, ref locals);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10366, 1845, 1910);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax>
                f_10366_1678_1713_I(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10366, 1678, 1713);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol>?
                f_10366_1968_1996_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol>?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10366, 1968, 1996);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10366, 1486, 2053);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10366, 1486, 2053);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool IsLocalFunctionsScopeBinder
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10366, 2140, 2203);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10366, 2176, 2188);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10366, 2140, 2203);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10366, 2065, 2214);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10366, 2065, 2214);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override ImmutableArray<LabelSymbol> BuildLabels()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10366, 2226, 2761);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10366, 2311, 2352);

                ArrayBuilder<LabelSymbol>?
                labels = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10366, 2368, 2661);
                    foreach (var statement in f_10366_2394_2429_I(f_10366_2394_2429(f_10366_2394_2421(_entryPoint))))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10366, 2368, 2661);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10366, 2463, 2646) || true) && (statement is GlobalStatementSyntax topLevelStatement)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10366, 2463, 2646);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10366, 2561, 2627);

                            f_10366_2561_2626(_entryPoint, f_10366_2586_2613(topLevelStatement), ref labels);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10366, 2463, 2646);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10366, 2368, 2661);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10366, 1, 294);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10366, 1, 294);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10366, 2677, 2750);

                return f_10366_2684_2712_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(labels, 10366, 2684, 2712)?.ToImmutableAndFree()) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>?>(10366, 2684, 2749) ?? ImmutableArray<LabelSymbol>.Empty);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10366, 2226, 2761);

                Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax
                f_10366_2394_2421(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedSimpleProgramEntryPointSymbol
                this_param)
                {
                    var return_v = this_param.CompilationUnit;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10366, 2394, 2421);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax>
                f_10366_2394_2429(Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax
                this_param)
                {
                    var return_v = this_param.Members;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10366, 2394, 2429);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                f_10366_2586_2613(Microsoft.CodeAnalysis.CSharp.Syntax.GlobalStatementSyntax
                this_param)
                {
                    var return_v = this_param.Statement;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10366, 2586, 2613);
                    return return_v;
                }


                int
                f_10366_2561_2626(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedSimpleProgramEntryPointSymbol
                containingMethod, Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                statement, ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>?
                labels)
                {
                    BuildLabels((Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)containingMethod, statement, ref labels);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10366, 2561, 2626);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax>
                f_10366_2394_2429_I(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10366, 2394, 2429);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>?
                f_10366_2684_2712_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10366, 2684, 2712);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10366, 2226, 2761);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10366, 2226, 2761);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool IsLabelsScopeBinder
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10366, 2840, 2903);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10366, 2876, 2888);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10366, 2840, 2903);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10366, 2773, 2914);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10366, 2773, 2914);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ImmutableArray<LocalSymbol> GetDeclaredLocalsForScope(SyntaxNode scopeDesignator)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10366, 2926, 3220);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10366, 3050, 3156) || true) && (f_10366_3054_3069() == scopeDesignator)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10366, 3050, 3156);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10366, 3122, 3141);

                    return f_10366_3129_3140(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10366, 3050, 3156);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10366, 3172, 3209);

                throw f_10366_3178_3208();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10366, 2926, 3220);

                Microsoft.CodeAnalysis.SyntaxNode
                f_10366_3054_3069()
                {
                    var return_v = ScopeDesignator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10366, 3054, 3069);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10366_3129_3140(Microsoft.CodeAnalysis.CSharp.SimpleProgramBinder
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10366, 3129, 3140);
                    return return_v;
                }


                System.Exception
                f_10366_3178_3208()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10366, 3178, 3208);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10366, 2926, 3220);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10366, 2926, 3220);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override SyntaxNode ScopeDesignator
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10366, 3301, 3382);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10366, 3337, 3367);

                    return f_10366_3344_3366(_entryPoint);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10366, 3301, 3382);

                    Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                    f_10366_3344_3366(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedSimpleProgramEntryPointSymbol
                    this_param)
                    {
                        var return_v = this_param.SyntaxNode;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10366, 3344, 3366);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10366, 3232, 3393);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10366, 3232, 3393);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ImmutableArray<LocalFunctionSymbol> GetDeclaredLocalFunctionsForScope(CSharpSyntaxNode scopeDesignator)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10366, 3405, 3729);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10366, 3551, 3665) || true) && (f_10366_3555_3570() == scopeDesignator)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10366, 3551, 3665);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10366, 3623, 3650);

                    return f_10366_3630_3649(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10366, 3551, 3665);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10366, 3681, 3718);

                throw f_10366_3687_3717();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10366, 3405, 3729);

                Microsoft.CodeAnalysis.SyntaxNode
                f_10366_3555_3570()
                {
                    var return_v = ScopeDesignator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10366, 3555, 3570);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol>
                f_10366_3630_3649(Microsoft.CodeAnalysis.CSharp.SimpleProgramBinder
                this_param)
                {
                    var return_v = this_param.LocalFunctions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10366, 3630, 3649);
                    return return_v;
                }


                System.Exception
                f_10366_3687_3717()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10366, 3687, 3717);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10366, 3405, 3729);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10366, 3405, 3729);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SimpleProgramBinder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10366, 572, 3736);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10366, 572, 3736);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10366, 572, 3736);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10366, 572, 3736);

        static Microsoft.CodeAnalysis.CSharp.Binder
        f_10366_849_858_C(Microsoft.CodeAnalysis.CSharp.Binder
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10366, 731, 937);
            return return_v;
        }

    }
}
