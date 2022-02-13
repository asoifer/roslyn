// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using System.Collections.Immutable;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed class ScriptLocalScopeBinder : LocalScopeBinder
    {
        private readonly Labels _labels;

        internal ScriptLocalScopeBinder(Labels labels, Binder next) : base(f_10364_668_672_C(next))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10364, 601, 726);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10364, 581, 588);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10364, 698, 715);

                _labels = labels;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10364, 601, 726);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10364, 601, 726);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10364, 601, 726);
            }
        }

        internal override Symbol ContainingMemberOrLambda
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10364, 812, 853);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10364, 818, 851);

                    return f_10364_825_850(_labels);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10364, 812, 853);

                    Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedInteractiveInitializerMethod
                    f_10364_825_850(Microsoft.CodeAnalysis.CSharp.ScriptLocalScopeBinder.Labels
                    this_param)
                    {
                        var return_v = this_param.ScriptInitializer;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10364, 825, 850);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10364, 738, 864);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10364, 738, 864);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override ImmutableArray<LabelSymbol> BuildLabels()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10364, 876, 999);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10364, 961, 988);

                return f_10364_968_987(_labels);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10364, 876, 999);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                f_10364_968_987(Microsoft.CodeAnalysis.CSharp.ScriptLocalScopeBinder.Labels
                this_param)
                {
                    var return_v = this_param.GetLabels();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10364, 968, 987);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10364, 876, 999);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10364, 876, 999);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool IsLabelsScopeBinder
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10364, 1078, 1141);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10364, 1114, 1126);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10364, 1078, 1141);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10364, 1011, 1152);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10364, 1011, 1152);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ImmutableArray<LocalSymbol> GetDeclaredLocalsForScope(SyntaxNode scopeDesignator)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10364, 1164, 1336);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10364, 1288, 1325);

                throw f_10364_1294_1324();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10364, 1164, 1336);

                System.Exception
                f_10364_1294_1324()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10364, 1294, 1324);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10364, 1164, 1336);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10364, 1164, 1336);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ImmutableArray<LocalFunctionSymbol> GetDeclaredLocalFunctionsForScope(CSharpSyntaxNode scopeDesignator)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10364, 1348, 1542);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10364, 1494, 1531);

                throw f_10364_1500_1530();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10364, 1348, 1542);

                System.Exception
                f_10364_1500_1530()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10364, 1500, 1530);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10364, 1348, 1542);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10364, 1348, 1542);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        internal new sealed class Labels
        {
            private readonly SynthesizedInteractiveInitializerMethod _scriptInitializer;

            private readonly CompilationUnitSyntax _syntax;

            private ImmutableArray<LabelSymbol> _lazyLabels;

            internal Labels(SynthesizedInteractiveInitializerMethod scriptInitializer, CompilationUnitSyntax syntax)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10364, 1914, 2140);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10364, 1756, 1774);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10364, 1828, 1835);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10364, 2051, 2090);

                    _scriptInitializer = scriptInitializer;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10364, 2108, 2125);

                    _syntax = syntax;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10364, 1914, 2140);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10364, 1914, 2140);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10364, 1914, 2140);
                }
            }

            internal SynthesizedInteractiveInitializerMethod ScriptInitializer
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10364, 2255, 2289);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10364, 2261, 2287);

                        return _scriptInitializer;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10364, 2255, 2289);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10364, 2156, 2304);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10364, 2156, 2304);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal ImmutableArray<LabelSymbol> GetLabels()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10364, 2320, 2637);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10364, 2401, 2585) || true) && (_lazyLabels == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10364, 2401, 2585);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10364, 2466, 2566);

                        f_10364_2466_2565(ref _lazyLabels, f_10364_2526_2564(_scriptInitializer, _syntax));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10364, 2401, 2585);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10364, 2603, 2622);

                    return _lazyLabels;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10364, 2320, 2637);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                    f_10364_2526_2564(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedInteractiveInitializerMethod
                    scriptInitializer, Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax
                    syntax)
                    {
                        var return_v = GetLabels(scriptInitializer, syntax);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10364, 2526, 2564);
                        return return_v;
                    }


                    bool
                    f_10364_2466_2565(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                    location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                    value)
                    {
                        var return_v = ImmutableInterlocked.InterlockedInitialize(ref location, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10364, 2466, 2565);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10364, 2320, 2637);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10364, 2320, 2637);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private static ImmutableArray<LabelSymbol> GetLabels(SynthesizedInteractiveInitializerMethod scriptInitializer, CompilationUnitSyntax syntax)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10364, 2653, 3321);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10364, 2827, 2881);

                    var
                    builder = f_10364_2841_2880()
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10364, 2899, 3252);
                        foreach (var member in f_10364_2922_2936_I(f_10364_2922_2936(syntax)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10364, 2899, 3252);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10364, 2978, 3107) || true) && (f_10364_2982_2995(member) != SyntaxKind.GlobalStatement)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10364, 2978, 3107);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10364, 3075, 3084);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10364, 2978, 3107);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10364, 3129, 3233);

                            f_10364_3129_3232(scriptInitializer, f_10364_3177_3218(((GlobalStatementSyntax)member)), ref builder);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10364, 2899, 3252);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10364, 1, 354);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10364, 1, 354);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10364, 3270, 3306);

                    return f_10364_3277_3305(builder);
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10364, 2653, 3321);

                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                    f_10364_2841_2880()
                    {
                        var return_v = ArrayBuilder<LabelSymbol>.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10364, 2841, 2880);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax>
                    f_10364_2922_2936(Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax
                    this_param)
                    {
                        var return_v = this_param.Members;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10364, 2922, 2936);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    f_10364_2982_2995(Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.Kind();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10364, 2982, 2995);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                    f_10364_3177_3218(Microsoft.CodeAnalysis.CSharp.Syntax.GlobalStatementSyntax
                    this_param)
                    {
                        var return_v = this_param.Statement;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10364, 3177, 3218);
                        return return_v;
                    }


                    int
                    f_10364_3129_3232(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedInteractiveInitializerMethod
                    containingMethod, Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                    statement, ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                    labels)
                    {
                        LocalScopeBinder.BuildLabels((Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)containingMethod, statement, ref labels);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10364, 3129, 3232);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax>
                    f_10364_2922_2936_I(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10364, 2922, 2936);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                    f_10364_3277_3305(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                    this_param)
                    {
                        var return_v = this_param.ToImmutableAndFree();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10364, 3277, 3305);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10364, 2653, 3321);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10364, 2653, 3321);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static Labels()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10364, 1642, 3332);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10364, 1642, 3332);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10364, 1642, 3332);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10364, 1642, 3332);
        }

        static ScriptLocalScopeBinder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10364, 477, 3339);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10364, 477, 3339);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10364, 477, 3339);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10364, 477, 3339);

        static Microsoft.CodeAnalysis.CSharp.Binder
        f_10364_668_672_C(Microsoft.CodeAnalysis.CSharp.Binder
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10364, 601, 726);
            return return_v;
        }

    }
}
