// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Immutable;
using System.Linq;
using System.Threading;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed class SynthesizedSimpleProgramEntryPointSymbol : SourceMemberMethodSymbol
    {
        private readonly SingleTypeDeclaration _declaration;

        private readonly TypeSymbol _returnType;

        private readonly ImmutableArray<ParameterSymbol> _parameters;

        private WeakReference<ExecutableCodeBinder>? _weakBodyBinder;

        private WeakReference<ExecutableCodeBinder>? _weakIgnoreAccessibilityBodyBinder;

        internal SynthesizedSimpleProgramEntryPointSymbol(SimpleProgramNamedTypeSymbol containingType, SingleTypeDeclaration declaration, DiagnosticBag diagnostics)
        : base(f_10689_1216_1230_C(containingType), syntaxReferenceOpt: f_10689_1252_1279(declaration), f_10689_1281_1345(f_10689_1303_1344(f_10689_1303_1330(declaration))), isIterator: f_10689_1359_1381(declaration))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10689, 1039, 3732);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10689, 730, 742);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10689, 783, 794);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10689, 921, 936);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10689, 992, 1026);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10689, 1407, 1434);

                _declaration = declaration;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10689, 1450, 1498);

                bool
                hasAwait = f_10689_1466_1497(declaration)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10689, 1512, 1579);

                bool
                hasReturnWithExpression = f_10689_1543_1578(declaration)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10689, 1595, 1663);

                CSharpCompilation
                compilation = f_10689_1627_1662(containingType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10689, 1677, 2723);

                switch (hasAwait, hasReturnWithExpression)
                {

                    case (true, false):
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10689, 1677, 2723);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10689, 1793, 1922);

                        _returnType = f_10689_1807_1921(compilation, WellKnownType.System_Threading_Tasks_Task, diagnostics, NoLocation.Singleton);
                        DynAbs.Tracing.TraceSender.TraceBreak(10689, 1944, 1950);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10689, 1677, 2723);

                    case (false, false):
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10689, 1677, 2723);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10689, 2010, 2119);

                        _returnType = f_10689_2024_2118(compilation, SpecialType.System_Void, NoLocation.Singleton, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceBreak(10689, 2141, 2147);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10689, 1677, 2723);

                    case (true, true):
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10689, 1677, 2723);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10689, 2205, 2483);

                        _returnType = f_10689_2219_2482(f_10689_2219_2335(compilation, WellKnownType.System_Threading_Tasks_Task_T, diagnostics, NoLocation.Singleton), f_10689_2386_2481(compilation, SpecialType.System_Int32, NoLocation.Singleton, diagnostics));
                        DynAbs.Tracing.TraceSender.TraceBreak(10689, 2505, 2511);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10689, 1677, 2723);

                    case (false, true):
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10689, 1677, 2723);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10689, 2570, 2680);

                        _returnType = f_10689_2584_2679(compilation, SpecialType.System_Int32, NoLocation.Singleton, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceBreak(10689, 2702, 2708);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10689, 1677, 2723);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10689, 2739, 2828);

                bool
                isNullableAnalysisEnabled = f_10689_2772_2827(compilation, f_10689_2811_2826())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10689, 2842, 3286);

                f_10689_2842_3285(this, MethodKind.Ordinary, DeclarationModifiers.Static | DeclarationModifiers.Private | ((DynAbs.Tracing.TraceSender.Conditional_F1(10689, 2975, 2983) || ((hasAwait && DynAbs.Tracing.TraceSender.Conditional_F2(10689, 2986, 3012)) || DynAbs.Tracing.TraceSender.Conditional_F3(10689, 3015, 3040))) ? DeclarationModifiers.Async : DeclarationModifiers.None), returnsVoid: !hasAwait && (DynAbs.Tracing.TraceSender.Expression_True(10689, 3073, 3110) && !hasReturnWithExpression), isExtensionMethod: false, isNullableAnalysisEnabled: isNullableAnalysisEnabled, isMetadataVirtualIgnoringModifiers: false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10689, 3302, 3721);

                _parameters = f_10689_3316_3720(f_10689_3338_3719(this, TypeWithAnnotations.Create(f_10689_3472_3692(f_10689_3506_3526(compilation), TypeWithAnnotations.Create(f_10689_3594_3690(compilation, SpecialType.System_String, NoLocation.Singleton, diagnostics)))), 0, RefKind.None, "args"));
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10689, 1039, 3732);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10689, 1039, 3732);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10689, 1039, 3732);
            }
        }

        public override string Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10689, 3796, 3914);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10689, 3832, 3899);

                    return WellKnownMemberNames.TopLevelStatementsEntryPointMethodName;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10689, 3796, 3914);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10689, 3744, 3925);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10689, 3744, 3925);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override System.Reflection.MethodImplAttributes ImplementationAttributes
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10689, 4043, 4106);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10689, 4049, 4104);

                    return default(System.Reflection.MethodImplAttributes);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10689, 4043, 4106);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10689, 3937, 4117);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10689, 3937, 4117);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsVararg
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10689, 4183, 4247);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10689, 4219, 4232);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10689, 4183, 4247);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10689, 4129, 4258);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10689, 4129, 4258);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<TypeParameterSymbol> TypeParameters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10689, 4361, 4461);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10689, 4397, 4446);

                    return ImmutableArray<TypeParameterSymbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10689, 4361, 4461);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10689, 4270, 4472);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10689, 4270, 4472);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override int ParameterCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10689, 4545, 4605);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10689, 4581, 4590);

                    return 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10689, 4545, 4605);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10689, 4484, 4616);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10689, 4484, 4616);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<ParameterSymbol> Parameters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10689, 4711, 4781);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10689, 4747, 4766);

                    return _parameters;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10689, 4711, 4781);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10689, 4628, 4792);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10689, 4628, 4792);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override Accessibility DeclaredAccessibility
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10689, 4880, 4960);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10689, 4916, 4945);

                    return Accessibility.Private;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10689, 4880, 4960);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10689, 4804, 4971);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10689, 4804, 4971);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override RefKind RefKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10689, 5039, 5110);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10689, 5075, 5095);

                    return RefKind.None;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10689, 5039, 5110);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10689, 4983, 5121);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10689, 4983, 5121);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override TypeWithAnnotations ReturnTypeWithAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10689, 5219, 5317);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10689, 5255, 5302);

                    return TypeWithAnnotations.Create(_returnType);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10689, 5219, 5317);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10689, 5133, 5328);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10689, 5133, 5328);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override FlowAnalysisAnnotations ReturnTypeFlowAnalysisAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10689, 5414, 5445);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10689, 5417, 5445);
                    return FlowAnalysisAnnotations.None; DynAbs.Tracing.TraceSender.TraceExitMethod(10689, 5414, 5445);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10689, 5414, 5445);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10689, 5414, 5445);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableHashSet<string> ReturnNotNullIfParameterNotNull
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10689, 5531, 5564);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10689, 5534, 5564);
                    return ImmutableHashSet<string>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10689, 5531, 5564);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10689, 5531, 5564);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10689, 5531, 5564);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override FlowAnalysisAnnotations FlowAnalysisAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10689, 5641, 5672);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10689, 5644, 5672);
                    return FlowAnalysisAnnotations.None; DynAbs.Tracing.TraceSender.TraceExitMethod(10689, 5641, 5672);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10689, 5641, 5672);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10689, 5641, 5672);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<CustomModifier> RefCustomModifiers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10689, 5775, 5870);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10689, 5811, 5855);

                    return ImmutableArray<CustomModifier>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10689, 5775, 5870);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10689, 5685, 5881);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10689, 5685, 5881);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool IsImplicitlyDeclared
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10689, 5966, 6030);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10689, 6002, 6015);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10689, 5966, 6030);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10689, 5893, 6041);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10689, 5893, 6041);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override bool GenerateDebugInfo
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10689, 6125, 6188);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10689, 6161, 6173);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10689, 6125, 6188);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10689, 6053, 6199);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10689, 6053, 6199);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override int CalculateLocalSyntaxOffset(int localPosition, SyntaxTree localTree)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10689, 6211, 6357);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10689, 6325, 6346);

                return localPosition;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10689, 6211, 6357);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10689, 6211, 6357);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10689, 6211, 6357);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override void MethodChecks(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10689, 6369, 6454);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10689, 6369, 6454);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10689, 6369, 6454);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10689, 6369, 6454);
            }
        }

        internal override bool IsExpressionBodied
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10689, 6508, 6516);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10689, 6511, 6516);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10689, 6508, 6516);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10689, 6508, 6516);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10689, 6508, 6516);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<ImmutableArray<TypeWithAnnotations>> GetTypeParameterConstraintTypes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10689, 6644, 6704);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10689, 6647, 6704);
                return ImmutableArray<ImmutableArray<TypeWithAnnotations>>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10689, 6644, 6704);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10689, 6644, 6704);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10689, 6644, 6704);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<TypeParameterConstraintKind> GetTypeParameterConstraintKinds()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10689, 6824, 6876);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10689, 6827, 6876);
                return ImmutableArray<TypeParameterConstraintKind>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10689, 6824, 6876);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10689, 6824, 6876);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10689, 6824, 6876);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override object MethodChecksLockObject
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10689, 6938, 6953);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10689, 6941, 6953);
                    return _declaration; DynAbs.Tracing.TraceSender.TraceExitMethod(10689, 6938, 6953);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10689, 6938, 6953);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10689, 6938, 6953);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal CompilationUnitSyntax CompilationUnit
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10689, 7013, 7049);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10689, 7016, 7049);
                    return (CompilationUnitSyntax)f_10689_7039_7049(); DynAbs.Tracing.TraceSender.TraceExitMethod(10689, 7013, 7049);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10689, 7013, 7049);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10689, 7013, 7049);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ExecutableCodeBinder TryGetBodyBinder(BinderFactory? binderFactoryOpt = null, bool ignoreAccessibility = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10689, 7062, 7269);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10689, 7216, 7258);

                return f_10689_7223_7257(this, ignoreAccessibility);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10689, 7062, 7269);

                Microsoft.CodeAnalysis.CSharp.ExecutableCodeBinder
                f_10689_7223_7257(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedSimpleProgramEntryPointSymbol
                this_param, bool
                ignoreAccessibility)
                {
                    var return_v = this_param.GetBodyBinder(ignoreAccessibility);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10689, 7223, 7257);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10689, 7062, 7269);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10689, 7062, 7269);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ExecutableCodeBinder CreateBodyBinder(bool ignoreAccessibility)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10689, 7281, 7943);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10689, 7377, 7430);

                CSharpCompilation
                compilation = f_10689_7409_7429()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10689, 7446, 7499);

                Binder
                result = f_10689_7462_7498(compilation)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10689, 7513, 7609);

                result = f_10689_7522_7608(f_10689_7544_7571(compilation), result, f_10689_7581_7591(), inUsing: false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10689, 7623, 7678);

                result = f_10689_7632_7677(f_10689_7654_7668(), result);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10689, 7692, 7734);

                result = f_10689_7701_7733(this, result);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10689, 7748, 7858);

                result = f_10689_7757_7857(result, (DynAbs.Tracing.TraceSender.Conditional_F1(10689, 7784, 7803) || ((ignoreAccessibility && DynAbs.Tracing.TraceSender.Conditional_F2(10689, 7806, 7837)) || DynAbs.Tracing.TraceSender.Conditional_F3(10689, 7840, 7856))) ? BinderFlags.IgnoreAccessibility : BinderFlags.None);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10689, 7874, 7932);

                return f_10689_7881_7931(f_10689_7906_7916(), this, result);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10689, 7281, 7943);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10689_7409_7429()
                {
                    var return_v = DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10689, 7409, 7429);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BuckStopsHereBinder
                f_10689_7462_7498(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BuckStopsHereBinder(compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10689, 7462, 7498);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_10689_7544_7571(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.GlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10689, 7544, 7571);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10689_7581_7591()
                {
                    var return_v = SyntaxNode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10689, 7581, 7591);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.InContainerBinder
                f_10689_7522_7608(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                container, Microsoft.CodeAnalysis.CSharp.Binder
                next, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                declarationSyntax, bool
                inUsing)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.InContainerBinder((Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol)container, next, declarationSyntax, inUsing: inUsing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10689, 7522, 7608);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10689_7654_7668()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10689, 7654, 7668);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.InContainerBinder
                f_10689_7632_7677(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                container, Microsoft.CodeAnalysis.CSharp.Binder
                next)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.InContainerBinder((Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol)container, next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10689, 7632, 7677);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.InMethodBinder
                f_10689_7701_7733(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedSimpleProgramEntryPointSymbol
                owner, Microsoft.CodeAnalysis.CSharp.Binder
                enclosing)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.InMethodBinder((Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)owner, enclosing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10689, 7701, 7733);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10689_7757_7857(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BinderFlags
                flags)
                {
                    var return_v = this_param.WithAdditionalFlags(flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10689, 7757, 7857);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10689_7906_7916()
                {
                    var return_v = SyntaxNode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10689, 7906, 7916);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ExecutableCodeBinder
                f_10689_7881_7931(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                root, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedSimpleProgramEntryPointSymbol
                memberSymbol, Microsoft.CodeAnalysis.CSharp.Binder
                next)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.ExecutableCodeBinder((Microsoft.CodeAnalysis.SyntaxNode)root, (Microsoft.CodeAnalysis.CSharp.Symbol)memberSymbol, next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10689, 7881, 7931);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10689, 7281, 7943);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10689, 7281, 7943);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal ExecutableCodeBinder GetBodyBinder(bool ignoreAccessibility)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10689, 7955, 8864);
                Microsoft.CodeAnalysis.CSharp.ExecutableCodeBinder previousBinder = default(Microsoft.CodeAnalysis.CSharp.ExecutableCodeBinder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10689, 8049, 8190);

                ref WeakReference<ExecutableCodeBinder>?
                weakBinder = ref (DynAbs.Tracing.TraceSender.Conditional_F1(10689, 8107, 8126) || ((ignoreAccessibility && DynAbs.Tracing.TraceSender.Conditional_F2(10689, 8129, 8167)) || DynAbs.Tracing.TraceSender.Conditional_F3(10689, 8170, 8189))) ? ref _weakIgnoreAccessibilityBodyBinder : ref _weakBodyBinder
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10689, 8206, 8853) || true) && (true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10689, 8206, 8853);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10689, 8251, 8290);

                        var
                        previousWeakReference = weakBinder
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10689, 8308, 8504) || true) && (previousWeakReference != null && (DynAbs.Tracing.TraceSender.Expression_True(10689, 8312, 8421) && f_10689_8345_8421(previousWeakReference, out previousBinder)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10689, 8308, 8504);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10689, 8463, 8485);

                            return previousBinder;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10689, 8308, 8504);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10689, 8524, 8595);

                        ExecutableCodeBinder
                        newBinder = f_10689_8557_8594(this, ignoreAccessibility)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10689, 8613, 8838) || true) && (f_10689_8617_8735(ref weakBinder, f_10689_8661_8711(newBinder), previousWeakReference) == previousWeakReference)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10689, 8613, 8838);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10689, 8802, 8819);

                            return newBinder;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10689, 8613, 8838);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10689, 8206, 8853);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10689, 8206, 8853);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10689, 8206, 8853);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10689, 7955, 8864);

                bool
                f_10689_8345_8421(System.WeakReference<Microsoft.CodeAnalysis.CSharp.ExecutableCodeBinder>
                this_param, out Microsoft.CodeAnalysis.CSharp.ExecutableCodeBinder?
                target)
                {
                    var return_v = this_param.TryGetTarget(out target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10689, 8345, 8421);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ExecutableCodeBinder
                f_10689_8557_8594(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedSimpleProgramEntryPointSymbol
                this_param, bool
                ignoreAccessibility)
                {
                    var return_v = this_param.CreateBodyBinder(ignoreAccessibility);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10689, 8557, 8594);
                    return return_v;
                }


                System.WeakReference<Microsoft.CodeAnalysis.CSharp.ExecutableCodeBinder>
                f_10689_8661_8711(Microsoft.CodeAnalysis.CSharp.ExecutableCodeBinder
                target)
                {
                    var return_v = new System.WeakReference<Microsoft.CodeAnalysis.CSharp.ExecutableCodeBinder>(target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10689, 8661, 8711);
                    return return_v;
                }


                System.WeakReference<Microsoft.CodeAnalysis.CSharp.ExecutableCodeBinder>?
                f_10689_8617_8735(ref System.WeakReference<Microsoft.CodeAnalysis.CSharp.ExecutableCodeBinder>?
                location1, System.WeakReference<Microsoft.CodeAnalysis.CSharp.ExecutableCodeBinder>
                value, System.WeakReference<Microsoft.CodeAnalysis.CSharp.ExecutableCodeBinder>?
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10689, 8617, 8735);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10689, 7955, 8864);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10689, 7955, 8864);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool IsDefinedInSourceTree(SyntaxTree tree, TextSpan? definedWithinSpan, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10689, 8876, 9829);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10689, 9028, 9789) || true) && (f_10689_9032_9071(f_10689_9032_9060(_declaration)) == tree)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10689, 9028, 9789);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10689, 9113, 9774) || true) && (f_10689_9117_9144_M(!definedWithinSpan.HasValue))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10689, 9113, 9774);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10689, 9186, 9198);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10689, 9113, 9774);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10689, 9113, 9774);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10689, 9280, 9329);

                        var
                        span = definedWithinSpan.GetValueOrDefault()
                        ;
                        try
                        {
                            // LAFHIS
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10689, 9353, 9755);
                            var temp = f_10689_9376_9472(((CompilationUnitSyntax)f_10689_9400_9431(tree, cancellationToken)).Members);
                            foreach (var global in f_10689_9376_9472_I(temp))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10689, 9353, 9755);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10689, 9522, 9571);

                                cancellationToken.ThrowIfCancellationRequested();

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10689, 9599, 9732) || true) && (global.Span.IntersectsWith(span))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10689, 9599, 9732);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10689, 9693, 9705);

                                    return true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10689, 9599, 9732);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10689, 9353, 9755);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10689, 1, 403);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10689, 1, 403);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10689, 9113, 9774);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10689, 9028, 9789);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10689, 9805, 9818);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10689, 8876, 9829);

                Microsoft.CodeAnalysis.SyntaxReference
                f_10689_9032_9060(Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration
                this_param)
                {
                    var return_v = this_param.SyntaxReference;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10689, 9032, 9060);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10689_9032_9071(Microsoft.CodeAnalysis.SyntaxReference
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10689, 9032, 9071);
                    return return_v;
                }


                bool
                f_10689_9117_9144_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10689, 9117, 9144);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10689_9400_9431(Microsoft.CodeAnalysis.SyntaxTree
                this_param, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetRoot(cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10689, 9400, 9431);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.GlobalStatementSyntax>
                f_10689_9376_9472(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax>
                source)
                {
                    var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.GlobalStatementSyntax>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10689, 9376, 9472);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.GlobalStatementSyntax>
                f_10689_9376_9472_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.GlobalStatementSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10689, 9376, 9472);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10689, 8876, 9829);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10689, 8876, 9829);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SyntaxNode ReturnTypeSyntax
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10689, 9876, 9953);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10689, 9879, 9953);
                    return f_10689_9879_9953(f_10689_9879_9894().Members, m => m.Kind() == SyntaxKind.GlobalStatement); DynAbs.Tracing.TraceSender.TraceExitMethod(10689, 9876, 9953);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10689, 9876, 9953);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10689, 9876, 9953);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private static bool IsNullableAnalysisEnabled(CSharpCompilation compilation, CompilationUnitSyntax syntax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10689, 9966, 10392);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10689, 10097, 10354);
                    foreach (var member in f_10689_10120_10134_I(f_10689_10120_10134(syntax)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10689, 10097, 10354);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10689, 10168, 10339) || true) && (f_10689_10172_10185(member) == SyntaxKind.GlobalStatement && (DynAbs.Tracing.TraceSender.Expression_True(10689, 10172, 10266) && f_10689_10219_10266(compilation, member)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10689, 10168, 10339);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10689, 10308, 10320);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10689, 10168, 10339);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10689, 10097, 10354);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10689, 1, 258);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10689, 1, 258);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10689, 10368, 10381);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10689, 9966, 10392);

                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax>
                f_10689_10120_10134(Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax
                this_param)
                {
                    var return_v = this_param.Members;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10689, 10120, 10134);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10689_10172_10185(Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10689, 10172, 10185);
                    return return_v;
                }


                bool
                f_10689_10219_10266(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax
                syntax)
                {
                    var return_v = this_param.IsNullableAnalysisEnabledIn((Microsoft.CodeAnalysis.SyntaxNode)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10689, 10219, 10266);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax>
                f_10689_10120_10134_I(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10689, 10120, 10134);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10689, 9966, 10392);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10689, 9966, 10392);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SynthesizedSimpleProgramEntryPointSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10689, 469, 10399);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10689, 469, 10399);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10689, 469, 10399);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10689, 469, 10399);

        static Microsoft.CodeAnalysis.SyntaxReference
        f_10689_1252_1279(Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration
        this_param)
        {
            var return_v = this_param.SyntaxReference;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10689, 1252, 1279);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SyntaxReference
        f_10689_1303_1330(Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration
        this_param)
        {
            var return_v = this_param.SyntaxReference;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10689, 1303, 1330);
            return return_v;
        }


        static Microsoft.CodeAnalysis.Location
        f_10689_1303_1344(Microsoft.CodeAnalysis.SyntaxReference
        this_param)
        {
            var return_v = this_param.GetLocation();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10689, 1303, 1344);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
        f_10689_1281_1345(Microsoft.CodeAnalysis.Location
        item)
        {
            var return_v = ImmutableArray.Create(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10689, 1281, 1345);
            return return_v;
        }


        static bool
        f_10689_1359_1381(Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration
        this_param)
        {
            var return_v = this_param.IsIterator;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10689, 1359, 1381);
            return return_v;
        }


        bool
        f_10689_1466_1497(Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration
        this_param)
        {
            var return_v = this_param.HasAwaitExpressions;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10689, 1466, 1497);
            return return_v;
        }


        bool
        f_10689_1543_1578(Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration
        this_param)
        {
            var return_v = this_param.HasReturnWithExpression;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10689, 1543, 1578);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_10689_1627_1662(Microsoft.CodeAnalysis.CSharp.Symbols.SimpleProgramNamedTypeSymbol
        this_param)
        {
            var return_v = this_param.DeclaringCompilation;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10689, 1627, 1662);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10689_1807_1921(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation, Microsoft.CodeAnalysis.WellKnownType
        type, Microsoft.CodeAnalysis.DiagnosticBag
        diagnostics, Microsoft.CodeAnalysis.Location
        location)
        {
            var return_v = Binder.GetWellKnownType(compilation, type, diagnostics, location);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10689, 1807, 1921);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10689_2024_2118(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation, Microsoft.CodeAnalysis.SpecialType
        typeId, Microsoft.CodeAnalysis.Location
        location, Microsoft.CodeAnalysis.DiagnosticBag
        diagnostics)
        {
            var return_v = Binder.GetSpecialType(compilation, typeId, location, diagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10689, 2024, 2118);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10689_2219_2335(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation, Microsoft.CodeAnalysis.WellKnownType
        type, Microsoft.CodeAnalysis.DiagnosticBag
        diagnostics, Microsoft.CodeAnalysis.Location
        location)
        {
            var return_v = Binder.GetWellKnownType(compilation, type, diagnostics, location);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10689, 2219, 2335);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10689_2386_2481(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation, Microsoft.CodeAnalysis.SpecialType
        typeId, Microsoft.CodeAnalysis.Location
        location, Microsoft.CodeAnalysis.DiagnosticBag
        diagnostics)
        {
            var return_v = Binder.GetSpecialType(compilation, typeId, location, diagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10689, 2386, 2481);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10689_2219_2482(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        this_param, params Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol[]
        typeArguments)
        {
            var return_v = this_param.Construct(typeArguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10689, 2219, 2482);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10689_2584_2679(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation, Microsoft.CodeAnalysis.SpecialType
        typeId, Microsoft.CodeAnalysis.Location
        location, Microsoft.CodeAnalysis.DiagnosticBag
        diagnostics)
        {
            var return_v = Binder.GetSpecialType(compilation, typeId, location, diagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10689, 2584, 2679);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax
        f_10689_2811_2826()
        {
            var return_v = CompilationUnit;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10689, 2811, 2826);
            return return_v;
        }


        bool
        f_10689_2772_2827(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation, Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax
        syntax)
        {
            var return_v = IsNullableAnalysisEnabled(compilation, syntax);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10689, 2772, 2827);
            return return_v;
        }


        int
        f_10689_2842_3285(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedSimpleProgramEntryPointSymbol
        this_param, Microsoft.CodeAnalysis.MethodKind
        methodKind, Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
        declarationModifiers, bool
        returnsVoid, bool
        isExtensionMethod, bool
        isNullableAnalysisEnabled, bool
        isMetadataVirtualIgnoringModifiers)
        {
            this_param.MakeFlags(methodKind, declarationModifiers, returnsVoid: returnsVoid, isExtensionMethod: isExtensionMethod, isNullableAnalysisEnabled: isNullableAnalysisEnabled, isMetadataVirtualIgnoringModifiers: isMetadataVirtualIgnoringModifiers);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10689, 2842, 3285);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
        f_10689_3506_3526(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        this_param)
        {
            var return_v = this_param.Assembly;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10689, 3506, 3526);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10689_3594_3690(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation, Microsoft.CodeAnalysis.SpecialType
        typeId, Microsoft.CodeAnalysis.Location
        location, Microsoft.CodeAnalysis.DiagnosticBag
        diagnostics)
        {
            var return_v = Binder.GetSpecialType(compilation, typeId, location, diagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10689, 3594, 3690);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
        f_10689_3472_3692(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
        declaringAssembly, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
        elementTypeWithAnnotations)
        {
            var return_v = ArrayTypeSymbol.CreateCSharpArray(declaringAssembly, elementTypeWithAnnotations);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10689, 3472, 3692);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
        f_10689_3338_3719(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedSimpleProgramEntryPointSymbol
        container, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
        type, int
        ordinal, Microsoft.CodeAnalysis.RefKind
        refKind, string
        name)
        {
            var return_v = SynthesizedParameterSymbol.Create((Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)container, type, ordinal, refKind, name);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10689, 3338, 3719);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
        f_10689_3316_3720(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
        item)
        {
            var return_v = ImmutableArray.Create(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10689, 3316, 3720);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10689_1216_1230_C(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10689, 1039, 3732);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
        f_10689_7039_7049()
        {
            var return_v = SyntaxNode;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10689, 7039, 7049);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax
        f_10689_9879_9894()
        {
            var return_v = CompilationUnit;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10689, 9879, 9894);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax
        f_10689_9879_9953(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax>
        source, System.Func<Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax, bool>
        predicate)
        {
            var return_v = source.First<Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax>(predicate);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10689, 9879, 9953);
            return return_v;
        }

    }
}
