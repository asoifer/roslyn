// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal class BuckStopsHereBinder : Binder
    {
        internal BuckStopsHereBinder(CSharpCompilation compilation)
        : base(f_10325_696_707_C(compilation))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10325, 616, 730);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10325, 616, 730);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10325, 616, 730);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10325, 616, 730);
            }
        }

        internal override ImportChain? ImportChain
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10325, 809, 872);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10325, 845, 857);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10325, 809, 872);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10325, 742, 883);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10325, 742, 883);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override QuickAttributeChecker QuickAttributeChecker
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10325, 1190, 1281);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10325, 1226, 1266);

                    return f_10325_1233_1265();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10325, 1190, 1281);

                    Microsoft.CodeAnalysis.CSharp.Symbols.QuickAttributeChecker
                    f_10325_1233_1265()
                    {
                        var return_v = QuickAttributeChecker.Predefined;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10325, 1233, 1265);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10325, 1104, 1292);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10325, 1104, 1292);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override Imports GetImports(ConsList<TypeSymbol>? basesBeingResolved)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10325, 1304, 1439);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10325, 1407, 1428);

                return Imports.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10325, 1304, 1439);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10325, 1304, 1439);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10325, 1304, 1439);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override SourceLocalSymbol? LookupLocal(SyntaxToken nameToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10325, 1451, 1571);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10325, 1548, 1560);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10325, 1451, 1571);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10325, 1451, 1571);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10325, 1451, 1571);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override LocalFunctionSymbol? LookupLocalFunction(SyntaxToken nameToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10325, 1583, 1713);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10325, 1690, 1702);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10325, 1583, 1713);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10325, 1583, 1713);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10325, 1583, 1713);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override uint LocalScopeDepth
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10325, 1764, 1787);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10325, 1767, 1787);
                    return Binder.ExternalScope; DynAbs.Tracing.TraceSender.TraceExitMethod(10325, 1764, 1787);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10325, 1764, 1787);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10325, 1764, 1787);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override bool InExecutableBinder
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10325, 1843, 1851);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10325, 1846, 1851);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10325, 1843, 1851);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10325, 1843, 1851);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10325, 1843, 1851);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsAccessibleHelper(Symbol symbol, TypeSymbol accessThroughType, out bool failedThroughTypeCheck, ref HashSet<DiagnosticInfo>? useSiteDiagnostics, ConsList<TypeSymbol> basesBeingResolved)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10325, 1864, 2245);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10325, 2098, 2129);

                failedThroughTypeCheck = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10325, 2143, 2234);

                return f_10325_2150_2233(symbol, f_10325_2188_2208(f_10325_2188_2199()), ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10325, 1864, 2245);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10325_2188_2199()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10325, 2188, 2199);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10325_2188_2208(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Assembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10325, 2188, 2208);
                    return return_v;
                }


                bool
                f_10325_2150_2233(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                within, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = IsSymbolAccessibleConditional(symbol, within, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10325, 2150, 2233);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10325, 1864, 2245);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10325, 1864, 2245);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ConstantFieldsInProgress ConstantFieldsInProgress
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10325, 2349, 2438);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10325, 2385, 2423);

                    return ConstantFieldsInProgress.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10325, 2349, 2438);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10325, 2257, 2449);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10325, 2257, 2449);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ConsList<FieldSymbol> FieldsBeingBound
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10325, 2542, 2628);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10325, 2578, 2613);

                    return ConsList<FieldSymbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10325, 2542, 2628);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10325, 2461, 2639);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10325, 2461, 2639);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override LocalSymbol? LocalInProgress
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10325, 2722, 2785);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10325, 2758, 2770);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10325, 2722, 2785);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10325, 2651, 2796);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10325, 2651, 2796);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override bool IsUnboundTypeAllowed(GenericNameSyntax syntax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10325, 2808, 2927);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10325, 2903, 2916);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10325, 2808, 2927);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10325, 2808, 2927);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10325, 2808, 2927);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool IsInMethodBody
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10325, 3001, 3065);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10325, 3037, 3050);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10325, 3001, 3065);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10325, 2939, 3076);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10325, 2939, 3076);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsDirectlyInIterator
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10325, 3156, 3220);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10325, 3192, 3205);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10325, 3156, 3220);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10325, 3088, 3231);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10325, 3088, 3231);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsIndirectlyInIterator
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10325, 3313, 3377);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10325, 3349, 3362);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10325, 3313, 3377);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10325, 3243, 3388);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10325, 3243, 3388);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override GeneratedLabelSymbol? BreakLabel
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10325, 3475, 3538);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10325, 3511, 3523);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10325, 3475, 3538);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10325, 3400, 3549);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10325, 3400, 3549);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override GeneratedLabelSymbol? ContinueLabel
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10325, 3639, 3702);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10325, 3675, 3687);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10325, 3639, 3702);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10325, 3561, 3713);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10325, 3561, 3713);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override BoundExpression? ConditionalReceiverExpression
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10325, 3814, 3877);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10325, 3850, 3862);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10325, 3814, 3877);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10325, 3725, 3888);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10325, 3725, 3888);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override TypeWithAnnotations GetIteratorElementType()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10325, 4084, 4289);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10325, 4241, 4278);

                throw f_10325_4247_4277();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10325, 4084, 4289);

                System.Exception
                f_10325_4247_4277()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10325, 4247, 4277);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10325, 4084, 4289);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10325, 4084, 4289);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override Symbol? ContainingMemberOrLambda
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10325, 4376, 4439);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10325, 4412, 4424);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10325, 4376, 4439);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10325, 4301, 4450);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10325, 4301, 4450);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool AreNullableAnnotationsGloballyEnabled()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10325, 4462, 4594);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10325, 4549, 4583);

                return f_10325_4556_4582(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10325, 4462, 4594);

                bool
                f_10325_4556_4582(Microsoft.CodeAnalysis.CSharp.BuckStopsHereBinder
                this_param)
                {
                    var return_v = this_param.GetGlobalAnnotationState();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10325, 4556, 4582);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10325, 4462, 4594);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10325, 4462, 4594);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override Binder? GetBinder(SyntaxNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10325, 4606, 4706);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10325, 4683, 4695);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10325, 4606, 4706);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10325, 4606, 4706);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10325, 4606, 4706);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ImmutableArray<LocalSymbol> GetDeclaredLocalsForScope(SyntaxNode scopeDesignator)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10325, 4718, 4890);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10325, 4842, 4879);

                throw f_10325_4848_4878();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10325, 4718, 4890);

                System.Exception
                f_10325_4848_4878()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10325, 4848, 4878);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10325, 4718, 4890);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10325, 4718, 4890);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ImmutableArray<LocalFunctionSymbol> GetDeclaredLocalFunctionsForScope(CSharpSyntaxNode scopeDesignator)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10325, 4902, 5096);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10325, 5048, 5085);

                throw f_10325_5054_5084();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10325, 4902, 5096);

                System.Exception
                f_10325_5054_5084()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10325, 5054, 5084);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10325, 4902, 5096);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10325, 4902, 5096);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override BoundStatement BindSwitchStatementCore(SwitchStatementSyntax node, Binder originalBinder, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10325, 5108, 5419);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10325, 5371, 5408);

                throw f_10325_5377_5407();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10325, 5108, 5419);

                System.Exception
                f_10325_5377_5407()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10325, 5377, 5407);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10325, 5108, 5419);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10325, 5108, 5419);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override BoundExpression BindSwitchExpressionCore(SwitchExpressionSyntax node, Binder originalBinder, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10325, 5431, 5755);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10325, 5707, 5744);

                throw f_10325_5713_5743();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10325, 5431, 5755);

                System.Exception
                f_10325_5713_5743()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10325, 5713, 5743);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10325, 5431, 5755);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10325, 5431, 5755);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override void BindPatternSwitchLabelForInference(CasePatternSwitchLabelSyntax node, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10325, 5767, 6063);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10325, 6015, 6052);

                throw f_10325_6021_6051();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10325, 5767, 6063);

                System.Exception
                f_10325_6021_6051()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10325, 6021, 6051);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10325, 5767, 6063);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10325, 5767, 6063);
            }
        }

        internal override BoundSwitchExpressionArm BindSwitchExpressionArm(SwitchExpressionArmSyntax node, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10325, 6075, 6399);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10325, 6351, 6388);

                throw f_10325_6357_6387();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10325, 6075, 6399);

                System.Exception
                f_10325_6357_6387()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10325, 6357, 6387);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10325, 6075, 6399);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10325, 6075, 6399);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override BoundForStatement BindForParts(DiagnosticBag diagnostics, Binder originalBinder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10325, 6411, 6687);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10325, 6639, 6676);

                throw f_10325_6645_6675();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10325, 6411, 6687);

                System.Exception
                f_10325_6645_6675()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10325, 6645, 6675);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10325, 6411, 6687);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10325, 6411, 6687);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override BoundStatement BindForEachParts(DiagnosticBag diagnostics, Binder originalBinder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10325, 6699, 6980);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10325, 6932, 6969);

                throw f_10325_6938_6968();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10325, 6699, 6980);

                System.Exception
                f_10325_6938_6968()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10325, 6938, 6968);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10325, 6699, 6980);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10325, 6699, 6980);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override BoundStatement BindForEachDeconstruction(DiagnosticBag diagnostics, Binder originalBinder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10325, 6992, 7282);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10325, 7234, 7271);

                throw f_10325_7240_7270();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10325, 6992, 7282);

                System.Exception
                f_10325_7240_7270()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10325, 7240, 7270);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10325, 6992, 7282);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10325, 6992, 7282);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override BoundWhileStatement BindWhileParts(DiagnosticBag diagnostics, Binder originalBinder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10325, 7294, 7572);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10325, 7524, 7561);

                throw f_10325_7530_7560();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10325, 7294, 7572);

                System.Exception
                f_10325_7530_7560()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10325, 7530, 7560);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10325, 7294, 7572);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10325, 7294, 7572);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override BoundDoStatement BindDoParts(DiagnosticBag diagnostics, Binder originalBinder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10325, 7584, 7856);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10325, 7808, 7845);

                throw f_10325_7814_7844();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10325, 7584, 7856);

                System.Exception
                f_10325_7814_7844()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10325, 7814, 7844);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10325, 7584, 7856);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10325, 7584, 7856);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override BoundStatement BindUsingStatementParts(DiagnosticBag diagnostics, Binder originalBinder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10325, 7868, 8159);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10325, 8111, 8148);

                throw f_10325_8117_8147();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10325, 7868, 8159);

                System.Exception
                f_10325_8117_8147()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10325, 8117, 8147);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10325, 7868, 8159);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10325, 7868, 8159);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override BoundStatement BindLockStatementParts(DiagnosticBag diagnostics, Binder originalBinder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10325, 8171, 8451);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10325, 8403, 8440);

                throw f_10325_8409_8439();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10325, 8171, 8451);

                System.Exception
                f_10325_8409_8439()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10325, 8409, 8439);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10325, 8171, 8451);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10325, 8171, 8451);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ImmutableHashSet<Symbol> LockedOrDisposedVariables
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10325, 8556, 8605);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10325, 8562, 8603);

                    return f_10325_8569_8602();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10325, 8556, 8605);

                    System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                    f_10325_8569_8602()
                    {
                        var return_v = ImmutableHashSet.Create<Symbol>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10325, 8569, 8602);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10325, 8463, 8616);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10325, 8463, 8616);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static BuckStopsHereBinder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10325, 556, 8623);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10325, 556, 8623);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10325, 556, 8623);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10325, 556, 8623);

        static Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_10325_696_707_C(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10325, 616, 730);
            return return_v;
        }

    }
}
