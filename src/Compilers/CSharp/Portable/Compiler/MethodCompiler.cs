// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CodeGen;
using Microsoft.CodeAnalysis.CSharp.Emit;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Debugging;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.CodeAnalysis.Emit;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed class MethodCompiler : CSharpSymbolVisitor<TypeCompilationState, object>
    {
        private readonly CSharpCompilation _compilation;

        private readonly bool _emittingPdb;

        private readonly bool _emitTestCoverageData;

        private readonly CancellationToken _cancellationToken;

        private readonly DiagnosticBag _diagnostics;

        private readonly bool _hasDeclarationErrors;

        private readonly PEModuleBuilder _moduleBeingBuiltOpt;

        private readonly Predicate<Symbol> _filterOpt;

        private readonly DebugDocumentProvider _debugDocumentProvider;

        private readonly SynthesizedEntryPointSymbol.AsyncForwardEntryPoint _entryPointOpt;

        private ConcurrentStack<Task> _compilerTasks;

        private bool _globalHasErrors;

        private void SetGlobalErrorIfTrue(bool arg)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10626, 3594, 4464);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 4373, 4453) || true) && (arg)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 4373, 4453);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 4414, 4438);

                    _globalHasErrors = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 4373, 4453);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10626, 3594, 4464);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10626, 3594, 4464);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10626, 3594, 4464);
            }
        }

        internal MethodCompiler(CSharpCompilation compilation, PEModuleBuilder moduleBeingBuiltOpt, bool emittingPdb, bool emitTestCoverageData, bool hasDeclarationErrors,
                    DiagnosticBag diagnostics, Predicate<Symbol> filterOpt, SynthesizedEntryPointSymbol.AsyncForwardEntryPoint entryPointOpt, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10626, 4515, 5721);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 1010, 1022);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 1055, 1067);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 1100, 1121);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 1227, 1239);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 1272, 1293);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 1337, 1357);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 1440, 1450);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 1559, 1581);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 1660, 1674);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 2777, 2791);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 3565, 3581);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 4875, 4909);

                f_10626_4875_4908(compilation != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 4923, 4957);

                f_10626_4923_4956(diagnostics != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 4973, 5000);

                _compilation = compilation;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 5014, 5057);

                _moduleBeingBuiltOpt = moduleBeingBuiltOpt;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 5071, 5098);

                _emittingPdb = emittingPdb;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 5112, 5151);

                _cancellationToken = cancellationToken;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 5165, 5192);

                _diagnostics = diagnostics;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 5206, 5229);

                _filterOpt = filterOpt;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 5243, 5274);

                _entryPointOpt = entryPointOpt;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 5290, 5335);

                _hasDeclarationErrors = hasDeclarationErrors;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 5349, 5392);

                f_10626_5349_5391(this, hasDeclarationErrors);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 5408, 5649) || true) && (emittingPdb || (DynAbs.Tracing.TraceSender.Expression_False(10626, 5412, 5447) || emitTestCoverageData))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 5408, 5649);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 5481, 5634);

                    _debugDocumentProvider = (path, basePath) => moduleBeingBuiltOpt.DebugDocumentsBuilder.GetOrAddDebugDocument(path, basePath, CreateDebugDocumentForFile);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 5408, 5649);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 5665, 5710);

                _emitTestCoverageData = emitTestCoverageData;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10626, 4515, 5721);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10626, 4515, 5721);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10626, 4515, 5721);
            }
        }

        public static void CompileMethodBodies(
                    CSharpCompilation compilation,
                    PEModuleBuilder moduleBeingBuiltOpt,
                    bool emittingPdb,
                    bool emitTestCoverageData,
                    bool hasDeclarationErrors,
                    DiagnosticBag diagnostics,
                    Predicate<Symbol> filterOpt,
                    CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10626, 5733, 10620);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 6134, 6168);

                f_10626_6134_6167(compilation != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 6182, 6216);

                f_10626_6182_6215(diagnostics != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 6232, 6722) || true) && (f_10626_6236_6266(compilation) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 6232, 6722);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 6556, 6635);

                    f_10626_6556_6634(f_10626_6556_6586(compilation), cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 6232, 6722);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 6738, 6769);

                MethodSymbol
                entryPoint = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 6783, 6968) || true) && (filterOpt is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 6783, 6968);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 6838, 6953);

                    entryPoint = f_10626_6851_6952(compilation, moduleBeingBuiltOpt, hasDeclarationErrors, diagnostics, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 6783, 6968);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 6984, 7378);

                var
                methodCompiler = f_10626_7005_7377(compilation, moduleBeingBuiltOpt, emittingPdb, emitTestCoverageData, hasDeclarationErrors, diagnostics, filterOpt, entryPoint as SynthesizedEntryPointSymbol.AsyncForwardEntryPoint, cancellationToken)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 7394, 7542) || true) && (f_10626_7398_7433(f_10626_7398_7417(compilation)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 7394, 7542);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 7467, 7527);

                    methodCompiler._compilerTasks = f_10626_7499_7526();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 7394, 7542);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 7643, 7717);

                f_10626_7643_7716(
                            // directly traverse global namespace (no point to defer this to async)
                            methodCompiler, f_10626_7675_7715(f_10626_7675_7699(compilation)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 7731, 7763);

                f_10626_7731_7762(methodCompiler);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 7841, 8972) || true) && (moduleBeingBuiltOpt != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 7841, 8972);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 7906, 7988);

                    var
                    additionalTypes = f_10626_7928_7987(moduleBeingBuiltOpt, diagnostics)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 8006, 8077);

                    f_10626_8006_8076(methodCompiler, additionalTypes, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 8097, 8167);

                    var
                    embeddedTypes = f_10626_8117_8166(moduleBeingBuiltOpt, diagnostics)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 8185, 8254);

                    f_10626_8185_8253(methodCompiler, embeddedTypes, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 8376, 8490);

                    f_10626_8376_8489(f_10626_8376_8408(compilation), methodCompiler, moduleBeingBuiltOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 8508, 8540);

                    f_10626_8508_8539(methodCompiler);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 8560, 8620);

                    var
                    privateImplClass = f_10626_8583_8619(moduleBeingBuiltOpt)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 8638, 8957) || true) && (privateImplClass != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 8638, 8957);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 8816, 8842);

                        f_10626_8816_8841(                    // all threads that were adding methods must be finished now, we can freeze the class:
                                            privateImplClass);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 8866, 8938);

                        f_10626_8866_8937(
                                            methodCompiler, privateImplClass, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 8638, 8957);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 7841, 8972);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 9361, 10054) || true) && (moduleBeingBuiltOpt != null && (DynAbs.Tracing.TraceSender.Expression_True(10626, 9365, 9482) && (methodCompiler._globalHasErrors || (DynAbs.Tracing.TraceSender.Expression_False(10626, 9397, 9481) || f_10626_9432_9481(moduleBeingBuiltOpt.SourceModule)))) && (DynAbs.Tracing.TraceSender.Expression_True(10626, 9365, 9513) && !f_10626_9487_9513(diagnostics)) && (DynAbs.Tracing.TraceSender.Expression_True(10626, 9365, 9538) && !hasDeclarationErrors))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 9361, 10054);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 9572, 9761);

                    var
                    messageResourceName = (DynAbs.Tracing.TraceSender.Conditional_F1(10626, 9598, 9629) || ((methodCompiler._globalHasErrors && DynAbs.Tracing.TraceSender.Conditional_F2(10626, 9632, 9701)) || DynAbs.Tracing.TraceSender.Conditional_F3(10626, 9704, 9760))) ? nameof(CodeAnalysisResources.UnableToDetermineSpecificCauseOfFailure) : nameof(CodeAnalysisResources.ModuleHasInvalidAttributes)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 9779, 10039);

                    f_10626_9779_10038(diagnostics, ErrorCode.ERR_ModuleEmitFailure, NoLocation.Singleton, f_10626_9850_9894(((Cci.INamedEntity)moduleBeingBuiltOpt)), f_10626_9917_10037(messageResourceName, f_10626_9968_10005(), typeof(CodeAnalysisResources)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 9361, 10054);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 10070, 10130);

                f_10626_10070_10129(
                            diagnostics, f_10626_10091_10128(compilation));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 10232, 10609) || true) && (filterOpt == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 10232, 10609);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 10287, 10349);

                    f_10626_10287_10348(compilation, diagnostics, cancellationToken);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 10369, 10594) || true) && (moduleBeingBuiltOpt != null && (DynAbs.Tracing.TraceSender.Expression_True(10626, 10373, 10422) && entryPoint != null) && (DynAbs.Tracing.TraceSender.Expression_True(10626, 10373, 10472) && f_10626_10426_10472(f_10626_10426_10456(f_10626_10426_10445(compilation)))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 10369, 10594);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 10514, 10575);

                        f_10626_10514_10574(moduleBeingBuiltOpt, entryPoint, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 10369, 10594);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 10232, 10609);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10626, 5733, 10620);

                int
                f_10626_6134_6167(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 6134, 6167);
                    return 0;
                }


                int
                f_10626_6182_6215(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 6182, 6215);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation?
                f_10626_6236_6266(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.PreviousSubmission;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 6236, 6266);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10626_6556_6586(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.PreviousSubmission;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 6556, 6586);
                    return return_v;
                }


                int
                f_10626_6556_6634(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, System.Threading.CancellationToken
                cancellationToken)
                {
                    this_param.EnsureAnonymousTypeTemplates(cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 6556, 6634);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10626_6851_6952(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                moduleBeingBuilt, bool
                hasDeclarationErrors, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = GetEntryPoint(compilation, moduleBeingBuilt, hasDeclarationErrors, diagnostics, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 6851, 6952);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MethodCompiler
                f_10626_7005_7377(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                moduleBeingBuiltOpt, bool
                emittingPdb, bool
                emitTestCoverageData, bool
                hasDeclarationErrors, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, System.Predicate<Microsoft.CodeAnalysis.CSharp.Symbol>?
                filterOpt, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                entryPointOpt, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.MethodCompiler(compilation, moduleBeingBuiltOpt, emittingPdb, emitTestCoverageData, hasDeclarationErrors, diagnostics, filterOpt, (Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEntryPointSymbol.AsyncForwardEntryPoint?)entryPointOpt, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 7005, 7377);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_10626_7398_7417(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 7398, 7417);
                    return return_v;
                }


                bool
                f_10626_7398_7433(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.ConcurrentBuild;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 7398, 7433);
                    return return_v;
                }


                System.Collections.Concurrent.ConcurrentStack<System.Threading.Tasks.Task>
                f_10626_7499_7526()
                {
                    var return_v = new System.Collections.Concurrent.ConcurrentStack<System.Threading.Tasks.Task>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 7499, 7526);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                f_10626_7675_7699(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.SourceModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 7675, 7699);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_10626_7675_7715(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                this_param)
                {
                    var return_v = this_param.GlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 7675, 7715);
                    return return_v;
                }


                int
                f_10626_7643_7716(Microsoft.CodeAnalysis.CSharp.MethodCompiler
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                symbol)
                {
                    this_param.CompileNamespace(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 7643, 7716);
                    return 0;
                }


                int
                f_10626_7731_7762(Microsoft.CodeAnalysis.CSharp.MethodCompiler
                this_param)
                {
                    this_param.WaitForWorkers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 7731, 7762);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10626_7928_7987(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.GetAdditionalTopLevelTypes(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 7928, 7987);
                    return return_v;
                }


                int
                f_10626_8006_8076(Microsoft.CodeAnalysis.CSharp.MethodCompiler
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                additionalTypes, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.CompileSynthesizedMethods(additionalTypes, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 8006, 8076);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10626_8117_8166(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.GetEmbeddedTypes(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 8117, 8166);
                    return return_v;
                }


                int
                f_10626_8185_8253(Microsoft.CodeAnalysis.CSharp.MethodCompiler
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                additionalTypes, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.CompileSynthesizedMethods(additionalTypes, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 8185, 8253);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager
                f_10626_8376_8408(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.AnonymousTypeManager;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 8376, 8408);
                    return return_v;
                }


                int
                f_10626_8376_8489(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager
                this_param, Microsoft.CodeAnalysis.CSharp.MethodCompiler
                compiler, Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                moduleBeingBuilt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.AssignTemplatesNamesAndCompile(compiler, moduleBeingBuilt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 8376, 8489);
                    return 0;
                }


                int
                f_10626_8508_8539(Microsoft.CodeAnalysis.CSharp.MethodCompiler
                this_param)
                {
                    this_param.WaitForWorkers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 8508, 8539);
                    return 0;
                }


                Microsoft.CodeAnalysis.CodeGen.PrivateImplementationDetails
                f_10626_8583_8619(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param)
                {
                    var return_v = this_param.PrivateImplClass;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 8583, 8619);
                    return return_v;
                }


                int
                f_10626_8816_8841(Microsoft.CodeAnalysis.CodeGen.PrivateImplementationDetails
                this_param)
                {
                    this_param.Freeze();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 8816, 8841);
                    return 0;
                }


                int
                f_10626_8866_8937(Microsoft.CodeAnalysis.CSharp.MethodCompiler
                this_param, Microsoft.CodeAnalysis.CodeGen.PrivateImplementationDetails
                privateImplClass, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.CompileSynthesizedMethods(privateImplClass, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 8866, 8937);
                    return 0;
                }


                bool
                f_10626_9432_9481(Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                this_param)
                {
                    var return_v = this_param.HasBadAttributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 9432, 9481);
                    return return_v;
                }


                bool
                f_10626_9487_9513(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.HasAnyErrors();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 9487, 9513);
                    return return_v;
                }


                string?
                f_10626_9850_9894(Microsoft.Cci.INamedEntity
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 9850, 9894);
                    return return_v;
                }


                System.Resources.ResourceManager
                f_10626_9968_10005()
                {
                    var return_v = CodeAnalysisResources.ResourceManager;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 9968, 10005);
                    return return_v;
                }


                Microsoft.CodeAnalysis.LocalizableResourceString
                f_10626_9917_10037(string
                nameOfLocalizableResource, System.Resources.ResourceManager
                resourceManager, System.Type
                resourceSource)
                {
                    var return_v = new Microsoft.CodeAnalysis.LocalizableResourceString(nameOfLocalizableResource, resourceManager, resourceSource);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 9917, 10037);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10626_9779_10038(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 9779, 10038);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10626_10091_10128(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.AdditionalCodegenWarnings;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 10091, 10128);
                    return return_v;
                }


                int
                f_10626_10070_10129(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                bag)
                {
                    this_param.AddRange(bag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 10070, 10129);
                    return 0;
                }


                int
                f_10626_10287_10348(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, System.Threading.CancellationToken
                cancellationToken)
                {
                    WarnUnusedFields(compilation, diagnostics, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 10287, 10348);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_10626_10426_10445(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 10426, 10445);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OutputKind
                f_10626_10426_10456(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.OutputKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 10426, 10456);
                    return return_v;
                }


                bool
                f_10626_10426_10472(Microsoft.CodeAnalysis.OutputKind
                kind)
                {
                    var return_v = kind.IsApplication();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 10426, 10472);
                    return return_v;
                }


                int
                f_10626_10514_10574(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.SetPEEntryPoint((Microsoft.CodeAnalysis.Symbols.IMethodSymbolInternal)method, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 10514, 10574);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10626, 5733, 10620);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10626, 5733, 10620);
            }
        }

        private static MethodSymbol GetEntryPoint(CSharpCompilation compilation, PEModuleBuilder moduleBeingBuilt, bool hasDeclarationErrors, DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10626, 10807, 15288);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 11029, 11119);

                var
                entryPointAndDiagnostics = f_10626_11060_11118(compilation, cancellationToken)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 11135, 11197);

                f_10626_11135_11196(f_10626_11148_11195_M(!entryPointAndDiagnostics.Diagnostics.IsDefault));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 11211, 11270);

                f_10626_11211_11269(diagnostics, entryPointAndDiagnostics.Diagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 11284, 11339);

                var
                entryPoint = entryPointAndDiagnostics.MethodSymbol
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 11355, 11446) || true) && ((object)entryPoint == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 11355, 11446);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 11419, 11431);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 11355, 11446);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 11557, 11651);

                SynthesizedEntryPointSymbol
                synthesizedEntryPoint = entryPoint as SynthesizedEntryPointSymbol
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 11665, 12393) || true) && ((object)synthesizedEntryPoint == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 11665, 12393);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 11740, 11779);

                    var
                    returnType = f_10626_11757_11778(entryPoint)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 11797, 12378) || true) && (f_10626_11801_11842(returnType, compilation) || (DynAbs.Tracing.TraceSender.Expression_False(10626, 11801, 11890) || f_10626_11846_11890(returnType, compilation)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 11797, 12378);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 11932, 12063);

                        synthesizedEntryPoint = f_10626_11956_12062(compilation, f_10626_12024_12049(entryPoint), entryPoint);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 12085, 12120);

                        entryPoint = synthesizedEntryPoint;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 12142, 12359) || true) && ((object)moduleBeingBuilt != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 12142, 12359);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 12228, 12336);

                            f_10626_12228_12335(moduleBeingBuilt, f_10626_12270_12295(entryPoint), f_10626_12297_12334(synthesizedEntryPoint));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 12142, 12359);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 11797, 12378);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 11665, 12393);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 12409, 15243) || true) && (((object)synthesizedEntryPoint != null) && (DynAbs.Tracing.TraceSender.Expression_True(10626, 12413, 12499) && (moduleBeingBuilt != null)) && (DynAbs.Tracing.TraceSender.Expression_True(10626, 12413, 12541) && !hasDeclarationErrors) && (DynAbs.Tracing.TraceSender.Expression_True(10626, 12413, 12589) && !f_10626_12563_12589(diagnostics)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 12409, 15243);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 12623, 12691);

                    BoundStatement
                    body = f_10626_12645_12690(synthesizedEntryPoint, diagnostics)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 12709, 12836) || true) && (f_10626_12713_12727(body) || (DynAbs.Tracing.TraceSender.Expression_False(10626, 12713, 12757) || f_10626_12731_12757(diagnostics)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 12709, 12836);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 12799, 12817);

                        return entryPoint;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 12709, 12836);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 12856, 12916);

                    var
                    dynamicAnalysisSpans = ImmutableArray<SourceSpan>.Empty
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 12934, 12989);

                    VariableSlotAllocator
                    lazyVariableSlotAllocator = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 13007, 13080);

                    var
                    lambdaDebugInfoBuilder = f_10626_13036_13079()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 13098, 13173);

                    var
                    closureDebugInfoBuilder = f_10626_13128_13172()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 13191, 13241);

                    StateMachineTypeSymbol
                    stateMachineTypeOpt = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 13259, 13288);

                    const int
                    methodOrdinal = -1
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 13308, 13925);

                    var
                    loweredBody = f_10626_13326_13924(synthesizedEntryPoint, methodOrdinal, body, null, f_10626_13505_13598(f_10626_13530_13566(synthesizedEntryPoint), compilation, moduleBeingBuilt), false, null, ref dynamicAnalysisSpans, diagnostics, ref lazyVariableSlotAllocator, lambdaDebugInfoBuilder, closureDebugInfoBuilder, out stateMachineTypeOpt)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 13945, 14001);

                    f_10626_13945_14000((object)lazyVariableSlotAllocator == null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 14019, 14069);

                    f_10626_14019_14068((object)stateMachineTypeOpt == null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 14087, 14130);

                    f_10626_14087_14129(dynamicAnalysisSpans.IsEmpty);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 14148, 14195);

                    f_10626_14148_14194(f_10626_14161_14193(lambdaDebugInfoBuilder));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 14213, 14261);

                    f_10626_14213_14260(f_10626_14226_14259(closureDebugInfoBuilder));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 14281, 14311);

                    f_10626_14281_14310(
                                    lambdaDebugInfoBuilder);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 14329, 14360);

                    f_10626_14329_14359(closureDebugInfoBuilder);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 14380, 15143);

                    var
                    emittedBody = f_10626_14398_15142(moduleBeingBuilt, synthesizedEntryPoint, methodOrdinal, loweredBody, ImmutableArray<LambdaDebugInfo>.Empty, ImmutableArray<ClosureDebugInfo>.Empty, stateMachineTypeOpt: null, variableSlotAllocatorOpt: null, diagnostics: diagnostics, debugDocumentProvider: null, importChainOpt: null, emittingPdb: false, emitTestCoverageData: false, dynamicAnalysisSpans: ImmutableArray<SourceSpan>.Empty, entryPointOpt: null)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 15161, 15228);

                    f_10626_15161_15227(moduleBeingBuilt, synthesizedEntryPoint, emittedBody);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 12409, 15243);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 15259, 15277);

                return entryPoint;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10626, 10807, 15288);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation.EntryPoint
                f_10626_11060_11118(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetEntryPointAndDiagnostics(cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 11060, 11118);
                    return return_v;
                }


                bool
                f_10626_11148_11195_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 11148, 11195);
                    return return_v;
                }


                int
                f_10626_11135_11196(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 11135, 11196);
                    return 0;
                }


                int
                f_10626_11211_11269(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics)
                {
                    this_param.AddRange<Microsoft.CodeAnalysis.Diagnostic>(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 11211, 11269);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10626_11757_11778(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 11757, 11778);
                    return return_v;
                }


                bool
                f_10626_11801_11842(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = type.IsGenericTaskType(compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 11801, 11842);
                    return return_v;
                }


                bool
                f_10626_11846_11890(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = type.IsNonGenericTaskType(compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 11846, 11890);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10626_12024_12049(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 12024, 12049);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEntryPointSymbol.AsyncForwardEntryPoint
                f_10626_11956_12062(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                containingType, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                userMain)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEntryPointSymbol.AsyncForwardEntryPoint(compilation, containingType, userMain);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 11956, 12062);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10626_12270_12295(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 12270, 12295);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                f_10626_12297_12334(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEntryPointSymbol
                this_param)
                {
                    var return_v = this_param.GetCciAdapter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 12297, 12334);
                    return return_v;
                }


                int
                f_10626_12228_12335(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                container, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                method)
                {
                    this_param.AddSynthesizedDefinition(container, (Microsoft.Cci.IMethodDefinition)method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 12228, 12335);
                    return 0;
                }


                bool
                f_10626_12563_12589(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.HasAnyErrors();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 12563, 12589);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10626_12645_12690(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEntryPointSymbol
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.CreateBody(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 12645, 12690);
                    return return_v;
                }


                bool
                f_10626_12713_12727(Microsoft.CodeAnalysis.CSharp.BoundStatement
                this_param)
                {
                    var return_v = this_param.HasErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 12713, 12727);
                    return return_v;
                }


                bool
                f_10626_12731_12757(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.HasAnyErrors();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 12731, 12757);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.LambdaDebugInfo>
                f_10626_13036_13079()
                {
                    var return_v = ArrayBuilder<LambdaDebugInfo>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 13036, 13079);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.ClosureDebugInfo>
                f_10626_13128_13172()
                {
                    var return_v = ArrayBuilder<ClosureDebugInfo>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 13128, 13172);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10626_13530_13566(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEntryPointSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 13530, 13566);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                f_10626_13505_13598(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                typeOpt, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                moduleBuilderOpt)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.TypeCompilationState(typeOpt, compilation, moduleBuilderOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 13505, 13598);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10626_13326_13924(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEntryPointSymbol
                method, int
                methodOrdinal, Microsoft.CodeAnalysis.CSharp.BoundStatement
                body, Microsoft.CodeAnalysis.CSharp.SynthesizedSubmissionFields
                previousSubmissionFields, Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                compilationState, bool
                instrumentForDynamicAnalysis, Microsoft.CodeAnalysis.CodeGen.DebugDocumentProvider
                debugDocumentProvider, ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.SourceSpan>
                dynamicAnalysisSpans, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, ref Microsoft.CodeAnalysis.CodeGen.VariableSlotAllocator?
                lazyVariableSlotAllocator, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.LambdaDebugInfo>
                lambdaDebugInfoBuilder, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.ClosureDebugInfo>
                closureDebugInfoBuilder, out Microsoft.CodeAnalysis.CSharp.StateMachineTypeSymbol
                stateMachineTypeOpt)
                {
                    var return_v = LowerBodyOrInitializer((Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)method, methodOrdinal, body, previousSubmissionFields, compilationState, instrumentForDynamicAnalysis, debugDocumentProvider, ref dynamicAnalysisSpans, diagnostics, ref lazyVariableSlotAllocator, lambdaDebugInfoBuilder, closureDebugInfoBuilder, out stateMachineTypeOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 13326, 13924);
                    return return_v;
                }


                int
                f_10626_13945_14000(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 13945, 14000);
                    return 0;
                }


                int
                f_10626_14019_14068(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 14019, 14068);
                    return 0;
                }


                int
                f_10626_14087_14129(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 14087, 14129);
                    return 0;
                }


                bool
                f_10626_14161_14193(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.LambdaDebugInfo>
                source)
                {
                    var return_v = source.IsEmpty<Microsoft.CodeAnalysis.CodeGen.LambdaDebugInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 14161, 14193);
                    return return_v;
                }


                int
                f_10626_14148_14194(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 14148, 14194);
                    return 0;
                }


                bool
                f_10626_14226_14259(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.ClosureDebugInfo>
                source)
                {
                    var return_v = source.IsEmpty<Microsoft.CodeAnalysis.CodeGen.ClosureDebugInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 14226, 14259);
                    return return_v;
                }


                int
                f_10626_14213_14260(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 14213, 14260);
                    return 0;
                }


                int
                f_10626_14281_14310(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.LambdaDebugInfo>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 14281, 14310);
                    return 0;
                }


                int
                f_10626_14329_14359(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.ClosureDebugInfo>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 14329, 14359);
                    return 0;
                }


                Microsoft.CodeAnalysis.CodeGen.MethodBody
                f_10626_14398_15142(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                moduleBuilder, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEntryPointSymbol
                method, int
                methodOrdinal, Microsoft.CodeAnalysis.CSharp.BoundStatement
                block, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.LambdaDebugInfo>
                lambdaDebugInfo, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.ClosureDebugInfo>
                closureDebugInfo, Microsoft.CodeAnalysis.CSharp.StateMachineTypeSymbol
                stateMachineTypeOpt, Microsoft.CodeAnalysis.CodeGen.VariableSlotAllocator
                variableSlotAllocatorOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CodeGen.DebugDocumentProvider
                debugDocumentProvider, Microsoft.CodeAnalysis.CSharp.ImportChain
                importChainOpt, bool
                emittingPdb, bool
                emitTestCoverageData, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.SourceSpan>
                dynamicAnalysisSpans, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEntryPointSymbol.AsyncForwardEntryPoint
                entryPointOpt)
                {
                    var return_v = GenerateMethodBody(moduleBuilder, (Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)method, methodOrdinal, block, lambdaDebugInfo, closureDebugInfo, stateMachineTypeOpt: stateMachineTypeOpt, variableSlotAllocatorOpt: variableSlotAllocatorOpt, diagnostics: diagnostics, debugDocumentProvider: debugDocumentProvider, importChainOpt: importChainOpt, emittingPdb: emittingPdb, emitTestCoverageData: emitTestCoverageData, dynamicAnalysisSpans: dynamicAnalysisSpans, entryPointOpt: entryPointOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 14398, 15142);
                    return return_v;
                }


                int
                f_10626_15161_15227(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEntryPointSymbol
                methodSymbol, Microsoft.CodeAnalysis.CodeGen.MethodBody
                body)
                {
                    this_param.SetMethodBody((Microsoft.CodeAnalysis.Symbols.IMethodSymbolInternal)methodSymbol, (Microsoft.Cci.IMethodBody)body);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 15161, 15227);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10626, 10807, 15288);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10626, 10807, 15288);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void WaitForWorkers()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10626, 15300, 15636);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 15354, 15381);

                var
                tasks = _compilerTasks
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 15395, 15468) || true) && (tasks == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 15395, 15468);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 15446, 15453);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 15395, 15468);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 15484, 15497);

                Task
                curTask
                = default(Task);
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 15511, 15625) || true) && (f_10626_15518_15543(tasks, out curTask))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 15511, 15625);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 15577, 15610);

                        f_10626_15577_15597(curTask).GetResult();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 15511, 15625);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10626, 15511, 15625);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10626, 15511, 15625);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10626, 15300, 15636);

                bool
                f_10626_15518_15543(System.Collections.Concurrent.ConcurrentStack<System.Threading.Tasks.Task>
                this_param, out System.Threading.Tasks.Task
                result)
                {
                    var return_v = this_param.TryPop(out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 15518, 15543);
                    return return_v;
                }


                System.Runtime.CompilerServices.TaskAwaiter
                f_10626_15577_15597(System.Threading.Tasks.Task
                this_param)
                {
                    var return_v = this_param.GetAwaiter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 15577, 15597);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10626, 15300, 15636);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10626, 15300, 15636);
            }
        }

        private static void WarnUnusedFields(CSharpCompilation compilation, DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10626, 15648, 15977);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 15804, 15879);

                SourceAssemblySymbol
                assembly = (SourceAssemblySymbol)f_10626_15858_15878(compilation)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 15893, 15966);

                f_10626_15893_15965(diagnostics, f_10626_15914_15964(assembly, cancellationToken));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10626, 15648, 15977);

                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10626_15858_15878(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Assembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 15858, 15878);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_10626_15914_15964(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetUnusedFieldWarnings(cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 15914, 15964);
                    return return_v;
                }


                int
                f_10626_15893_15965(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics)
                {
                    this_param.AddRange<Microsoft.CodeAnalysis.Diagnostic>(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 15893, 15965);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10626, 15648, 15977);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10626, 15648, 15977);
            }
        }

        public override object VisitNamespace(NamespaceSymbol symbol, TypeCompilationState arg)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10626, 15989, 16664);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 16101, 16199) || true) && (!f_10626_16106_16138(_filterOpt, symbol))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 16101, 16199);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 16172, 16184);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 16101, 16199);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 16215, 16226);

                arg = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 16287, 16337);

                _cancellationToken.ThrowIfCancellationRequested();

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 16353, 16625) || true) && (f_10626_16357_16393(f_10626_16357_16377(_compilation)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 16353, 16625);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 16427, 16473);

                    Task
                    worker = f_10626_16441_16472(this, symbol)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 16491, 16519);

                    f_10626_16491_16518(_compilerTasks, worker);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 16353, 16625);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 16353, 16625);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 16585, 16610);

                    f_10626_16585_16609(this, symbol);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 16353, 16625);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 16641, 16653);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10626, 15989, 16664);

                bool
                f_10626_16106_16138(System.Predicate<Microsoft.CodeAnalysis.CSharp.Symbol>
                filterOpt, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                symbol)
                {
                    var return_v = PassesFilter(filterOpt, (Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 16106, 16138);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_10626_16357_16377(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 16357, 16377);
                    return return_v;
                }


                bool
                f_10626_16357_16393(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.ConcurrentBuild;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 16357, 16393);
                    return return_v;
                }


                System.Threading.Tasks.Task
                f_10626_16441_16472(Microsoft.CodeAnalysis.CSharp.MethodCompiler
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                symbol)
                {
                    var return_v = this_param.CompileNamespaceAsAsync(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 16441, 16472);
                    return return_v;
                }


                int
                f_10626_16491_16518(System.Collections.Concurrent.ConcurrentStack<System.Threading.Tasks.Task>
                this_param, System.Threading.Tasks.Task
                item)
                {
                    this_param.Push(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 16491, 16518);
                    return 0;
                }


                int
                f_10626_16585_16609(Microsoft.CodeAnalysis.CSharp.MethodCompiler
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                symbol)
                {
                    this_param.CompileNamespace(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 16585, 16609);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10626, 15989, 16664);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10626, 15989, 16664);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Task CompileNamespaceAsAsync(NamespaceSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10626, 16676, 17220);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 16761, 17209);

                return f_10626_16768_17208(f_10626_16777_17187(() =>
                                {
                                    try
                                    {
                                        CompileNamespace(symbol);
                                    }
                                    catch (Exception e) when (FatalError.ReportAndPropagateUnlessCanceled(e))
                                    {
                                        throw ExceptionUtilities.Unreachable;
                                    }
                                }), _cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10626, 16676, 17220);

                System.Action
                f_10626_16777_17187(System.Action
                action)
                {
                    var return_v = UICultureUtilities.WithCurrentUICulture(action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 16777, 17187);
                    return return_v;
                }


                System.Threading.Tasks.Task
                f_10626_16768_17208(System.Action
                action, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = Task.Run(action, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 16768, 17208);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10626, 16676, 17220);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10626, 16676, 17220);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void CompileNamespace(NamespaceSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10626, 17232, 17437);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 17310, 17426);
                    foreach (var s in f_10626_17328_17356_I(f_10626_17328_17356(symbol)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 17310, 17426);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 17390, 17411);

                        f_10626_17390_17410(s, this, null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 17310, 17426);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10626, 1, 117);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10626, 1, 117);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10626, 17232, 17437);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10626_17328_17356(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param)
                {
                    var return_v = this_param.GetMembersUnordered();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 17328, 17356);
                    return return_v;
                }


                object
                f_10626_17390_17410(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param, Microsoft.CodeAnalysis.CSharp.MethodCompiler
                visitor, Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                a)
                {
                    var return_v = this_param.Accept<Microsoft.CodeAnalysis.CSharp.TypeCompilationState, object>((Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor<Microsoft.CodeAnalysis.CSharp.TypeCompilationState, object>)visitor, a);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 17390, 17410);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10626_17328_17356_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 17328, 17356);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10626, 17232, 17437);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10626, 17232, 17437);
            }
        }

        public override object VisitNamedType(NamedTypeSymbol symbol, TypeCompilationState arg)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10626, 17449, 18122);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 17561, 17659) || true) && (!f_10626_17566_17598(_filterOpt, symbol))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 17561, 17659);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 17632, 17644);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 17561, 17659);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 17675, 17686);

                arg = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 17747, 17797);

                _cancellationToken.ThrowIfCancellationRequested();

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 17813, 18083) || true) && (f_10626_17817_17853(f_10626_17817_17837(_compilation)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 17813, 18083);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 17887, 17931);

                    Task
                    worker = f_10626_17901_17930(this, symbol)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 17949, 17977);

                    f_10626_17949_17976(_compilerTasks, worker);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 17813, 18083);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 17813, 18083);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 18043, 18068);

                    f_10626_18043_18067(this, symbol);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 17813, 18083);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 18099, 18111);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10626, 17449, 18122);

                bool
                f_10626_17566_17598(System.Predicate<Microsoft.CodeAnalysis.CSharp.Symbol>
                filterOpt, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = PassesFilter(filterOpt, (Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 17566, 17598);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_10626_17817_17837(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 17817, 17837);
                    return return_v;
                }


                bool
                f_10626_17817_17853(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.ConcurrentBuild;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 17817, 17853);
                    return return_v;
                }


                System.Threading.Tasks.Task
                f_10626_17901_17930(Microsoft.CodeAnalysis.CSharp.MethodCompiler
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = this_param.CompileNamedTypeAsync(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 17901, 17930);
                    return return_v;
                }


                int
                f_10626_17949_17976(System.Collections.Concurrent.ConcurrentStack<System.Threading.Tasks.Task>
                this_param, System.Threading.Tasks.Task
                item)
                {
                    this_param.Push(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 17949, 17976);
                    return 0;
                }


                int
                f_10626_18043_18067(Microsoft.CodeAnalysis.CSharp.MethodCompiler
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                containingType)
                {
                    this_param.CompileNamedType(containingType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 18043, 18067);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10626, 17449, 18122);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10626, 17449, 18122);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Task CompileNamedTypeAsync(NamedTypeSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10626, 18134, 18676);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 18217, 18665);

                return f_10626_18224_18664(f_10626_18233_18643(() =>
                                {
                                    try
                                    {
                                        CompileNamedType(symbol);
                                    }
                                    catch (Exception e) when (FatalError.ReportAndPropagateUnlessCanceled(e))
                                    {
                                        throw ExceptionUtilities.Unreachable;
                                    }
                                }), _cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10626, 18134, 18676);

                System.Action
                f_10626_18233_18643(System.Action
                action)
                {
                    var return_v = UICultureUtilities.WithCurrentUICulture(action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 18233, 18643);
                    return return_v;
                }


                System.Threading.Tasks.Task
                f_10626_18224_18664(System.Action
                action, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = Task.Run(action, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 18224, 18664);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10626, 18134, 18676);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10626, 18134, 18676);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void CompileNamedType(NamedTypeSymbol containingType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10626, 18688, 31200);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 18774, 18874);

                var
                compilationState = f_10626_18797_18873(containingType, _compilation, _moduleBeingBuiltOpt)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 18890, 18940);

                _cancellationToken.ThrowIfCancellationRequested();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 19012, 19061);

                SynthesizedInstanceConstructor
                scriptCtor = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 19075, 19140);

                SynthesizedInteractiveInitializerMethod
                scriptInitializer = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 19154, 19206);

                SynthesizedEntryPointSymbol
                scriptEntryPoint = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 19220, 19247);

                int
                scriptCtorOrdinal = -1
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 19261, 20120) || true) && (f_10626_19265_19293(containingType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 19261, 20120);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 19779, 19830);

                    scriptCtor = f_10626_19792_19829(containingType);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 19848, 19906);

                    scriptInitializer = f_10626_19868_19905(containingType);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 19924, 19980);

                    scriptEntryPoint = f_10626_19943_19979(containingType);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 19998, 20039);

                    f_10626_19998_20038((object)scriptCtor != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 20057, 20105);

                    f_10626_20057_20104((object)scriptInitializer != null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 19261, 20120);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 20136, 20274);

                var
                synthesizedSubmissionFields = (DynAbs.Tracing.TraceSender.Conditional_F1(10626, 20170, 20202) || ((f_10626_20170_20202(containingType) && DynAbs.Tracing.TraceSender.Conditional_F2(10626, 20205, 20266)) || DynAbs.Tracing.TraceSender.Conditional_F3(10626, 20269, 20273))) ? f_10626_20205_20266(_compilation, containingType) : null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 20288, 20362);

                var
                processedStaticInitializers = f_10626_20322_20361()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 20376, 20452);

                var
                processedInstanceInitializers = f_10626_20412_20451()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 20468, 20541);

                var
                sourceTypeSymbol = containingType as SourceMemberContainerTypeSymbol
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 20557, 21282) || true) && ((object)sourceTypeSymbol != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 20557, 21282);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 20627, 20677);

                    _cancellationToken.ThrowIfCancellationRequested();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 20695, 20841);

                    f_10626_20695_20840(_compilation, scriptInitializer, f_10626_20757_20792(sourceTypeSymbol), _diagnostics, ref processedStaticInitializers);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 20861, 20911);

                    _cancellationToken.ThrowIfCancellationRequested();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 20929, 21079);

                    f_10626_20929_21078(_compilation, scriptInitializer, f_10626_20991_21028(sourceTypeSymbol), _diagnostics, ref processedInstanceInitializers);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 21099, 21267) || true) && (f_10626_21103_21128(compilationState))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 21099, 21267);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 21170, 21248);

                        f_10626_21170_21247(this, sourceTypeSymbol, compilationState);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 21099, 21267);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 20557, 21282);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 21435, 21469);

                bool
                hasStaticConstructor = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 21485, 21527);

                var
                members = f_10626_21499_21526(containingType)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 21550, 21567);
                    for (int
        memberOrdinal = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 21541, 27052) || true) && (memberOrdinal < members.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 21601, 21616)
        , memberOrdinal++, DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 21541, 27052))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 21541, 27052);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 21650, 21686);

                        var
                        member = members[memberOrdinal]
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 21805, 21912) || true) && (!f_10626_21810_21842(_filterOpt, member))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 21805, 21912);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 21884, 21893);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 21805, 21912);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 21932, 27037);

                        switch (f_10626_21940_21951(member))
                        {

                            case SymbolKind.NamedType:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 21932, 27037);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 22045, 22083);

                                f_10626_22045_22082(member, this, compilationState);
                                DynAbs.Tracing.TraceSender.TraceBreak(10626, 22109, 22115);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 21932, 27037);

                            case SymbolKind.Method:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 21932, 27037);
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 22219, 22262);

                                    MethodSymbol
                                    method = (MethodSymbol)member
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 22292, 22645) || true) && (f_10626_22296_22322(method))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 22292, 22645);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 22388, 22426);

                                        f_10626_22388_22425(scriptCtorOrdinal == -1);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 22460, 22503);

                                        f_10626_22460_22502((object)scriptCtor == method);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 22537, 22571);

                                        scriptCtorOrdinal = memberOrdinal;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 22605, 22614);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 22292, 22645);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 22677, 22821) || true) && ((object)method == scriptEntryPoint)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 22677, 22821);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 22781, 22790);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 22677, 22821);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 22853, 22995) || true) && (f_10626_22857_22889(method))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 22853, 22995);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 22955, 22964);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 22853, 22995);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 23027, 23376) || true) && (f_10626_23031_23059(method))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 23027, 23376);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 23125, 23167);

                                        method = f_10626_23134_23166(method);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 23201, 23345) || true) && ((object)method == null)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 23201, 23345);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 23301, 23310);

                                            continue;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 23201, 23345);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 23027, 23376);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 23408, 23800);

                                    Binder.ProcessedFieldInitializers
                                    processedInitializers =
                                    (DynAbs.Tracing.TraceSender.Conditional_F1(10626, 23499, 23574) || (((f_10626_23500_23517(method) == MethodKind.Constructor || (DynAbs.Tracing.TraceSender.Expression_False(10626, 23500, 23573) || f_10626_23547_23573(method))) && DynAbs.Tracing.TraceSender.Conditional_F2(10626, 23577, 23606)) || DynAbs.Tracing.TraceSender.Conditional_F3(10626, 23642, 23799))) ? processedInstanceInitializers : (DynAbs.Tracing.TraceSender.Conditional_F1(10626, 23642, 23691) || ((f_10626_23642_23659(method) == MethodKind.StaticConstructor && DynAbs.Tracing.TraceSender.Conditional_F2(10626, 23694, 23721)) || DynAbs.Tracing.TraceSender.Conditional_F3(10626, 23757, 23799))) ? processedStaticInitializers : default(Binder.ProcessedFieldInitializers)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 23832, 23943);

                                    f_10626_23832_23942(this, method, memberOrdinal, ref processedInitializers, synthesizedSubmissionFields, compilationState);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 24068, 24246) || true) && (f_10626_24072_24089(method) == MethodKind.StaticConstructor)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 24068, 24246);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 24187, 24215);

                                        hasStaticConstructor = true;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 24068, 24246);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceBreak(10626, 24276, 24282);

                                    break;
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 21932, 27037);

                            case SymbolKind.Property:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 21932, 27037);
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 24415, 24471);

                                    var
                                    sourceProperty = member as SourcePropertySymbolBase
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 24501, 24756) || true) && ((object)sourceProperty != null && (DynAbs.Tracing.TraceSender.Expression_True(10626, 24505, 24562) && f_10626_24539_24562(sourceProperty)) && (DynAbs.Tracing.TraceSender.Expression_True(10626, 24505, 24591) && f_10626_24566_24591(compilationState)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 24501, 24756);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 24657, 24725);

                                        f_10626_24657_24724(this, sourceProperty, compilationState);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 24501, 24756);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceBreak(10626, 24786, 24792);

                                    break;
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 21932, 27037);

                            case SymbolKind.Event:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 21932, 27037);
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 24922, 24982);

                                    SourceEventSymbol
                                    eventSymbol = member as SourceEventSymbol
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 25012, 25389) || true) && ((object)eventSymbol != null && (DynAbs.Tracing.TraceSender.Expression_True(10626, 25016, 25077) && f_10626_25047_25077(eventSymbol)) && (DynAbs.Tracing.TraceSender.Expression_True(10626, 25016, 25104) && f_10626_25081_25104_M(!eventSymbol.IsAbstract)) && (DynAbs.Tracing.TraceSender.Expression_True(10626, 25016, 25133) && f_10626_25108_25133(compilationState)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 25012, 25389);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 25199, 25261);

                                        f_10626_25199_25260(this, eventSymbol, isAddMethod: true);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 25295, 25358);

                                        f_10626_25295_25357(this, eventSymbol, isAddMethod: false);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 25012, 25389);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceBreak(10626, 25419, 25425);

                                    break;
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 21932, 27037);

                            case SymbolKind.Field:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 21932, 27037);
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 25555, 25587);

                                    var
                                    field = (FieldSymbol)member
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 25617, 25700);

                                    var
                                    fieldSymbol = (f_10626_25636_25662(field) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>(10626, 25636, 25671) ?? field)) as SourceMemberFieldSymbol
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 25730, 26955) || true) && ((object)fieldSymbol != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 25730, 26955);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 25827, 26515) || true) && (f_10626_25831_25850(fieldSymbol))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 25827, 26515);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 26243, 26375);

                                            ConstantValue
                                            constantValue = f_10626_26273_26374(fieldSymbol, ConstantFieldsInProgress.Empty, earlyDecodingWellKnownAttributes: false)
                                            ;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 26413, 26480);

                                            f_10626_26413_26479(this, constantValue == null || (DynAbs.Tracing.TraceSender.Expression_False(10626, 26434, 26478) || f_10626_26459_26478(constantValue)));
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 25827, 26515);
                                        }

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 26551, 26924) || true) && (f_10626_26555_26584(fieldSymbol) && (DynAbs.Tracing.TraceSender.Expression_True(10626, 26555, 26613) && f_10626_26588_26613(compilationState)))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 26551, 26924);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 26795, 26889);

                                            TypeSymbol
                                            discarded = f_10626_26818_26888(fieldSymbol, compilationState.ModuleBuilderOpt)
                                            ;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 26551, 26924);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 25730, 26955);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceBreak(10626, 26985, 26991);

                                    break;
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 21932, 27037);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10626, 1, 5512);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10626, 1, 5512);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 27068, 27139);

                f_10626_27068_27138(f_10626_27081_27109(containingType) == (scriptCtorOrdinal >= 0));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 27213, 27665) || true) && (f_10626_27217_27277(containingType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 27213, 27665);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 27311, 27382);

                    var
                    processedInitializers = default(Binder.ProcessedFieldInitializers)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 27400, 27650);
                        foreach (var method in f_10626_27423_27489_I(f_10626_27423_27489(containingType)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 27400, 27650);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 27531, 27631);

                            f_10626_27531_27630(this, method, -1, ref processedInitializers, synthesizedSubmissionFields, compilationState);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 27400, 27650);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10626, 1, 251);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10626, 1, 251);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 27213, 27665);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 28018, 29021) || true) && (_moduleBeingBuiltOpt != null && (DynAbs.Tracing.TraceSender.Expression_True(10626, 28022, 28075) && !hasStaticConstructor) && (DynAbs.Tracing.TraceSender.Expression_True(10626, 28022, 28142) && f_10626_28079_28142_M(!processedStaticInitializers.BoundInitializers.IsDefaultOrEmpty)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 28018, 29021);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 28176, 28373);

                    f_10626_28176_28372(processedStaticInitializers.BoundInitializers.All((init) =>
                                        (init.Kind == BoundKind.FieldEqualsValue) && !((BoundFieldEqualsValue)init).Field.IsMetadataConstant));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 28393, 28466);

                    MethodSymbol
                    method = f_10626_28415_28465(sourceTypeSymbol)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 28484, 29006) || true) && (f_10626_28488_28520(_filterOpt, method))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 28484, 29006);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 28562, 28668);

                        f_10626_28562_28667(this, method, -1, ref processedStaticInitializers, synthesizedSubmissionFields, compilationState);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 28772, 28987) || true) && (f_10626_28776_28818(_moduleBeingBuiltOpt, method) != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 28772, 28987);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 28876, 28964);

                            f_10626_28876_28963(_moduleBeingBuiltOpt, sourceTypeSymbol, f_10626_28940_28962(method));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 28772, 28987);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 28484, 29006);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 28018, 29021);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 29309, 30160) || true) && (!hasStaticConstructor && (DynAbs.Tracing.TraceSender.Expression_True(10626, 29313, 29417) && processedStaticInitializers.BoundInitializers.IsDefaultOrEmpty) && (DynAbs.Tracing.TraceSender.Expression_True(10626, 29313, 29531) && f_10626_29438_29466(_compilation) >= f_10626_29470_29531(MessageID.IDS_FeatureNullableReferenceTypes)) && (DynAbs.Tracing.TraceSender.Expression_True(10626, 29313, 29668) && containingType is { IsImplicitlyDeclared: false, TypeKind: TypeKind.Class or TypeKind.Struct or TypeKind.Interface }))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 29309, 30160);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 29702, 30145);

                    f_10626_29702_30144(this._compilation, f_10626_29795_29843(containingType), f_10626_29866_29905(containingType), _diagnostics, useConstructorExitWarnings: true, initialNullableState: null, getFinalNullableState: false, finalNullableState: out _);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 29309, 30160);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 30305, 30935) || true) && (scriptCtor != null && (DynAbs.Tracing.TraceSender.Expression_True(10626, 30309, 30356) && f_10626_30331_30356(compilationState)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 30305, 30935);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 30390, 30427);

                    f_10626_30390_30426(scriptCtorOrdinal >= 0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 30445, 30576);

                    var
                    processedInitializers = new Binder.ProcessedFieldInitializers() { BoundInitializers = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => ImmutableArray<BoundInitializer>.Empty, 10626, 30473, 30575) }
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 30594, 30713);

                    f_10626_30594_30712(this, scriptCtor, scriptCtorOrdinal, ref processedInitializers, synthesizedSubmissionFields, compilationState);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 30731, 30920) || true) && (synthesizedSubmissionFields != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 30731, 30920);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 30812, 30901);

                        f_10626_30812_30900(synthesizedSubmissionFields, containingType, compilationState.ModuleBuilderOpt);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 30731, 30920);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 30305, 30935);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 31024, 31149) || true) && (_moduleBeingBuiltOpt != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 31024, 31149);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 31090, 31134);

                    f_10626_31090_31133(this, compilationState);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 31024, 31149);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 31165, 31189);

                f_10626_31165_31188(
                            compilationState);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10626, 18688, 31200);

                Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                f_10626_18797_18873(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                typeOpt, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                moduleBuilderOpt)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.TypeCompilationState(typeOpt, compilation, moduleBuilderOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 18797, 18873);
                    return return_v;
                }


                bool
                f_10626_19265_19293(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsScriptClass;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 19265, 19293);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedInstanceConstructor
                f_10626_19792_19829(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetScriptConstructor();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 19792, 19829);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedInteractiveInitializerMethod
                f_10626_19868_19905(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetScriptInitializer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 19868, 19905);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEntryPointSymbol
                f_10626_19943_19979(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetScriptEntryPoint();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 19943, 19979);
                    return return_v;
                }


                int
                f_10626_19998_20038(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 19998, 20038);
                    return 0;
                }


                int
                f_10626_20057_20104(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 20057, 20104);
                    return 0;
                }


                bool
                f_10626_20170_20202(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsSubmissionClass;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 20170, 20202);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SynthesizedSubmissionFields
                f_10626_20205_20266(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                submissionClass)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SynthesizedSubmissionFields(compilation, submissionClass);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 20205, 20266);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder.ProcessedFieldInitializers
                f_10626_20322_20361()
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Binder.ProcessedFieldInitializers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 20322, 20361);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder.ProcessedFieldInitializers
                f_10626_20412_20451()
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Binder.ProcessedFieldInitializers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 20412, 20451);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.FieldOrPropertyInitializer>>
                f_10626_20757_20792(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                this_param)
                {
                    var return_v = this_param.StaticInitializers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 20757, 20792);
                    return return_v;
                }


                int
                f_10626_20695_20840(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedInteractiveInitializerMethod?
                scriptInitializerOpt, System.Collections.Immutable.ImmutableArray<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.FieldOrPropertyInitializer>>
                fieldInitializers, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, ref Microsoft.CodeAnalysis.CSharp.Binder.ProcessedFieldInitializers
                processedInitializers)
                {
                    Binder.BindFieldInitializers(compilation, scriptInitializerOpt, fieldInitializers, diagnostics, ref processedInitializers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 20695, 20840);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.FieldOrPropertyInitializer>>
                f_10626_20991_21028(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                this_param)
                {
                    var return_v = this_param.InstanceInitializers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 20991, 21028);
                    return return_v;
                }


                int
                f_10626_20929_21078(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedInteractiveInitializerMethod?
                scriptInitializerOpt, System.Collections.Immutable.ImmutableArray<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.FieldOrPropertyInitializer>>
                fieldInitializers, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, ref Microsoft.CodeAnalysis.CSharp.Binder.ProcessedFieldInitializers
                processedInitializers)
                {
                    Binder.BindFieldInitializers(compilation, scriptInitializerOpt, fieldInitializers, diagnostics, ref processedInitializers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 20929, 21078);
                    return 0;
                }


                bool
                f_10626_21103_21128(Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                this_param)
                {
                    var return_v = this_param.Emitting;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 21103, 21128);
                    return return_v;
                }


                int
                f_10626_21170_21247(Microsoft.CodeAnalysis.CSharp.MethodCompiler
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                sourceTypeSymbol, Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                compilationState)
                {
                    this_param.CompileSynthesizedExplicitImplementations(sourceTypeSymbol, compilationState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 21170, 21247);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10626_21499_21526(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 21499, 21526);
                    return return_v;
                }


                bool
                f_10626_21810_21842(System.Predicate<Microsoft.CodeAnalysis.CSharp.Symbol>
                filterOpt, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = PassesFilter(filterOpt, symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 21810, 21842);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10626_21940_21951(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 21940, 21951);
                    return return_v;
                }


                object
                f_10626_22045_22082(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param, Microsoft.CodeAnalysis.CSharp.MethodCompiler
                visitor, Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                a)
                {
                    var return_v = this_param.Accept<Microsoft.CodeAnalysis.CSharp.TypeCompilationState, object>((Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor<Microsoft.CodeAnalysis.CSharp.TypeCompilationState, object>)visitor, a);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 22045, 22082);
                    return return_v;
                }


                bool
                f_10626_22296_22322(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsScriptConstructor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 22296, 22322);
                    return return_v;
                }


                int
                f_10626_22388_22425(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 22388, 22425);
                    return 0;
                }


                int
                f_10626_22460_22502(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 22460, 22502);
                    return 0;
                }


                bool
                f_10626_22857_22889(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = IsFieldLikeEventAccessor(method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 22857, 22889);
                    return return_v;
                }


                bool
                f_10626_23031_23059(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                member)
                {
                    var return_v = member.IsPartialDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 23031, 23059);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10626_23134_23166(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.PartialImplementationPart;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 23134, 23166);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10626_23500_23517(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 23500, 23517);
                    return return_v;
                }


                bool
                f_10626_23547_23573(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsScriptInitializer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 23547, 23573);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10626_23642_23659(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 23642, 23659);
                    return return_v;
                }


                int
                f_10626_23832_23942(Microsoft.CodeAnalysis.CSharp.MethodCompiler
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                methodSymbol, int
                methodOrdinal, ref Microsoft.CodeAnalysis.CSharp.Binder.ProcessedFieldInitializers
                processedInitializers, Microsoft.CodeAnalysis.CSharp.SynthesizedSubmissionFields?
                previousSubmissionFields, Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                compilationState)
                {
                    this_param.CompileMethod(methodSymbol, methodOrdinal, ref processedInitializers, previousSubmissionFields, compilationState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 23832, 23942);
                    return 0;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10626_24072_24089(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 24072, 24089);
                    return return_v;
                }


                bool
                f_10626_24539_24562(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                this_param)
                {
                    var return_v = this_param.IsSealed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 24539, 24562);
                    return return_v;
                }


                bool
                f_10626_24566_24591(Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                this_param)
                {
                    var return_v = this_param.Emitting;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 24566, 24591);
                    return return_v;
                }


                int
                f_10626_24657_24724(Microsoft.CodeAnalysis.CSharp.MethodCompiler
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                sourceProperty, Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                compilationState)
                {
                    this_param.CompileSynthesizedSealedAccessors(sourceProperty, compilationState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 24657, 24724);
                    return 0;
                }


                bool
                f_10626_25047_25077(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol
                this_param)
                {
                    var return_v = this_param.HasAssociatedField;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 25047, 25077);
                    return return_v;
                }


                bool
                f_10626_25081_25104_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 25081, 25104);
                    return return_v;
                }


                bool
                f_10626_25108_25133(Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                this_param)
                {
                    var return_v = this_param.Emitting;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 25108, 25133);
                    return return_v;
                }


                int
                f_10626_25199_25260(Microsoft.CodeAnalysis.CSharp.MethodCompiler
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol
                eventSymbol, bool
                isAddMethod)
                {
                    this_param.CompileFieldLikeEventAccessor(eventSymbol, isAddMethod: isAddMethod);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 25199, 25260);
                    return 0;
                }


                int
                f_10626_25295_25357(Microsoft.CodeAnalysis.CSharp.MethodCompiler
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol
                eventSymbol, bool
                isAddMethod)
                {
                    this_param.CompileFieldLikeEventAccessor(eventSymbol, isAddMethod: isAddMethod);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 25295, 25357);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10626_25636_25662(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.TupleUnderlyingField;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 25636, 25662);
                    return return_v;
                }


                bool
                f_10626_25831_25850(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberFieldSymbol
                this_param)
                {
                    var return_v = this_param.IsConst;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 25831, 25850);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10626_26273_26374(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberFieldSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.ConstantFieldsInProgress
                inProgress, bool
                earlyDecodingWellKnownAttributes)
                {
                    var return_v = this_param.GetConstantValue(inProgress, earlyDecodingWellKnownAttributes: earlyDecodingWellKnownAttributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 26273, 26374);
                    return return_v;
                }


                bool
                f_10626_26459_26478(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.IsBad;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 26459, 26478);
                    return return_v;
                }


                int
                f_10626_26413_26479(Microsoft.CodeAnalysis.CSharp.MethodCompiler
                this_param, bool
                arg)
                {
                    this_param.SetGlobalErrorIfTrue(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 26413, 26479);
                    return 0;
                }


                bool
                f_10626_26555_26584(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberFieldSymbol
                this_param)
                {
                    var return_v = this_param.IsFixedSizeBuffer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 26555, 26584);
                    return return_v;
                }


                bool
                f_10626_26588_26613(Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                this_param)
                {
                    var return_v = this_param.Emitting;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 26588, 26613);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10626_26818_26888(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberFieldSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                emitModule)
                {
                    var return_v = this_param.FixedImplementationType(emitModule);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 26818, 26888);
                    return return_v;
                }


                bool
                f_10626_27081_27109(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsScriptClass;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 27081, 27109);
                    return return_v;
                }


                int
                f_10626_27068_27138(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 27068, 27138);
                    return 0;
                }


                bool
                f_10626_27217_27277(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = AnonymousTypeManager.IsAnonymousTypeTemplate(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 27217, 27277);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10626_27423_27489(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = AnonymousTypeManager.GetAnonymousTypeHiddenMethods(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 27423, 27489);
                    return return_v;
                }


                int
                f_10626_27531_27630(Microsoft.CodeAnalysis.CSharp.MethodCompiler
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                methodSymbol, int
                methodOrdinal, ref Microsoft.CodeAnalysis.CSharp.Binder.ProcessedFieldInitializers
                processedInitializers, Microsoft.CodeAnalysis.CSharp.SynthesizedSubmissionFields?
                previousSubmissionFields, Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                compilationState)
                {
                    this_param.CompileMethod(methodSymbol, methodOrdinal, ref processedInitializers, previousSubmissionFields, compilationState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 27531, 27630);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10626_27423_27489_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 27423, 27489);
                    return return_v;
                }


                bool
                f_10626_28079_28142_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 28079, 28142);
                    return return_v;
                }


                int
                f_10626_28176_28372(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 28176, 28372);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedStaticConstructor
                f_10626_28415_28465(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol?
                containingType)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedStaticConstructor((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?)containingType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 28415, 28465);
                    return return_v;
                }


                bool
                f_10626_28488_28520(System.Predicate<Microsoft.CodeAnalysis.CSharp.Symbol>
                filterOpt, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol)
                {
                    var return_v = PassesFilter(filterOpt, (Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 28488, 28520);
                    return return_v;
                }


                int
                f_10626_28562_28667(Microsoft.CodeAnalysis.CSharp.MethodCompiler
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                methodSymbol, int
                methodOrdinal, ref Microsoft.CodeAnalysis.CSharp.Binder.ProcessedFieldInitializers
                processedInitializers, Microsoft.CodeAnalysis.CSharp.SynthesizedSubmissionFields?
                previousSubmissionFields, Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                compilationState)
                {
                    this_param.CompileMethod(methodSymbol, methodOrdinal, ref processedInitializers, previousSubmissionFields, compilationState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 28562, 28667);
                    return 0;
                }


                Microsoft.Cci.IMethodBody
                f_10626_28776_28818(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                methodSymbol)
                {
                    var return_v = this_param.GetMethodBody((Microsoft.CodeAnalysis.Symbols.IMethodSymbolInternal)methodSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 28776, 28818);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                f_10626_28940_28962(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.GetCciAdapter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 28940, 28962);
                    return return_v;
                }


                int
                f_10626_28876_28963(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                container, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                method)
                {
                    this_param.AddSynthesizedDefinition((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)container, (Microsoft.Cci.IMethodDefinition)method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 28876, 28963);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.LanguageVersion
                f_10626_29438_29466(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.LanguageVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 29438, 29466);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LanguageVersion
                f_10626_29470_29531(Microsoft.CodeAnalysis.CSharp.MessageID
                feature)
                {
                    var return_v = feature.RequiredVersion();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 29470, 29531);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedStaticConstructor
                f_10626_29795_29843(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                containingType)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedStaticConstructor(containingType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 29795, 29843);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10626_29866_29905(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = GetSynthesizedEmptyBody((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 29866, 29905);
                    return return_v;
                }


                int
                f_10626_29702_30144(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedStaticConstructor
                method, Microsoft.CodeAnalysis.CSharp.BoundBlock
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                useConstructorExitWarnings, Microsoft.CodeAnalysis.CSharp.NullableWalker.VariableState?
                initialNullableState, bool
                getFinalNullableState, out Microsoft.CodeAnalysis.CSharp.NullableWalker.VariableState?
                finalNullableState)
                {
                    NullableWalker.AnalyzeIfNeeded(compilation, (Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)method, (Microsoft.CodeAnalysis.CSharp.BoundNode)node, diagnostics, useConstructorExitWarnings: useConstructorExitWarnings, initialNullableState: initialNullableState, getFinalNullableState: getFinalNullableState, out finalNullableState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 29702, 30144);
                    return 0;
                }


                bool
                f_10626_30331_30356(Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                this_param)
                {
                    var return_v = this_param.Emitting;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 30331, 30356);
                    return return_v;
                }


                int
                f_10626_30390_30426(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 30390, 30426);
                    return 0;
                }


                int
                f_10626_30594_30712(Microsoft.CodeAnalysis.CSharp.MethodCompiler
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedInstanceConstructor
                methodSymbol, int
                methodOrdinal, ref Microsoft.CodeAnalysis.CSharp.Binder.ProcessedFieldInitializers
                processedInitializers, Microsoft.CodeAnalysis.CSharp.SynthesizedSubmissionFields?
                previousSubmissionFields, Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                compilationState)
                {
                    this_param.CompileMethod((Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)methodSymbol, methodOrdinal, ref processedInitializers, previousSubmissionFields, compilationState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 30594, 30712);
                    return 0;
                }


                int
                f_10626_30812_30900(Microsoft.CodeAnalysis.CSharp.SynthesizedSubmissionFields
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                containingType, Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                moduleBeingBuilt)
                {
                    this_param.AddToType(containingType, moduleBeingBuilt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 30812, 30900);
                    return 0;
                }


                int
                f_10626_31090_31133(Microsoft.CodeAnalysis.CSharp.MethodCompiler
                this_param, Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                compilationState)
                {
                    this_param.CompileSynthesizedMethods(compilationState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 31090, 31133);
                    return 0;
                }


                int
                f_10626_31165_31188(Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 31165, 31188);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10626, 18688, 31200);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10626, 18688, 31200);
            }
        }

        private void CompileSynthesizedMethods(PrivateImplementationDetails privateImplClass, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10626, 31212, 32050);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 31349, 31392);

                f_10626_31349_31391(_moduleBeingBuiltOpt != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 31408, 31498);

                var
                compilationState = f_10626_31431_31497(null, _compilation, _moduleBeingBuiltOpt)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 31512, 31941);
                    foreach (Cci.IMethodDefinition definition in f_10626_31557_31692_I(f_10626_31557_31692(privateImplClass, f_10626_31585_31691(_moduleBeingBuiltOpt, null, diagnostics, metadataOnly: false, includePrivateMembers: true))))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 31512, 31941);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 31726, 31784);

                        var
                        method = (MethodSymbol)f_10626_31753_31783(definition)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 31802, 31851);

                        f_10626_31802_31850(f_10626_31815_31849(method));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 31869, 31926);

                        f_10626_31869_31925(method, compilationState, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 31512, 31941);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10626, 1, 430);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10626, 1, 430);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 31957, 32001);

                f_10626_31957_32000(this, compilationState);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 32015, 32039);

                f_10626_32015_32038(compilationState);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10626, 31212, 32050);

                int
                f_10626_31349_31391(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 31349, 31391);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                f_10626_31431_31497(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                typeOpt, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                moduleBuilderOpt)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.TypeCompilationState(typeOpt, compilation, moduleBuilderOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 31431, 31497);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.EmitContext
                f_10626_31585_31691(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                module, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                metadataOnly, bool
                includePrivateMembers)
                {
                    var return_v = new Microsoft.CodeAnalysis.Emit.EmitContext((Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder)module, syntaxNodeOpt, diagnostics, metadataOnly: metadataOnly, includePrivateMembers: includePrivateMembers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 31585, 31691);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.IMethodDefinition>
                f_10626_31557_31692(Microsoft.CodeAnalysis.CodeGen.PrivateImplementationDetails
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetMethods(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 31557, 31692);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Symbols.ISymbolInternal?
                f_10626_31753_31783(Microsoft.Cci.IMethodDefinition
                this_param)
                {
                    var return_v = this_param.GetInternalSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 31753, 31783);
                    return return_v;
                }


                bool
                f_10626_31815_31849(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                this_param)
                {
                    var return_v = this_param.SynthesizesLoweredBoundBody;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 31815, 31849);
                    return return_v;
                }


                int
                f_10626_31802_31850(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 31802, 31850);
                    return 0;
                }


                int
                f_10626_31869_31925(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                compilationState, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.GenerateMethodBody(compilationState, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 31869, 31925);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.IMethodDefinition>
                f_10626_31557_31692_I(System.Collections.Generic.IEnumerable<Microsoft.Cci.IMethodDefinition>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 31557, 31692);
                    return return_v;
                }


                int
                f_10626_31957_32000(Microsoft.CodeAnalysis.CSharp.MethodCompiler
                this_param, Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                compilationState)
                {
                    this_param.CompileSynthesizedMethods(compilationState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 31957, 32000);
                    return 0;
                }


                int
                f_10626_32015_32038(Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 32015, 32038);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10626, 31212, 32050);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10626, 31212, 32050);
            }
        }

        private void CompileSynthesizedMethods(ImmutableArray<NamedTypeSymbol> additionalTypes, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10626, 32062, 32799);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 32201, 32788);
                    foreach (var additionalType in f_10626_32232_32247_I(additionalTypes))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 32201, 32788);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 32281, 32381);

                        var
                        compilationState = f_10626_32304_32380(additionalType, _compilation, _moduleBeingBuiltOpt)
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 32399, 32573);
                            foreach (var method in f_10626_32422_32455_I(f_10626_32422_32455(additionalType)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 32399, 32573);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 32497, 32554);

                                f_10626_32497_32553(method, compilationState, diagnostics);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 32399, 32573);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10626, 1, 175);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10626, 1, 175);
                        }
                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 32593, 32729) || true) && (!f_10626_32598_32624(diagnostics))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 32593, 32729);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 32666, 32710);

                            f_10626_32666_32709(this, compilationState);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 32593, 32729);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 32749, 32773);

                        f_10626_32749_32772(
                                        compilationState);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 32201, 32788);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10626, 1, 588);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10626, 1, 588);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10626, 32062, 32799);

                Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                f_10626_32304_32380(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                typeOpt, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                moduleBuilderOpt)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.TypeCompilationState(typeOpt, compilation, moduleBuilderOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 32304, 32380);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10626_32422_32455(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetMethodsToEmit();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 32422, 32455);
                    return return_v;
                }


                int
                f_10626_32497_32553(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                compilationState, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.GenerateMethodBody(compilationState, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 32497, 32553);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10626_32422_32455_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 32422, 32455);
                    return return_v;
                }


                bool
                f_10626_32598_32624(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.HasAnyErrors();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 32598, 32624);
                    return return_v;
                }


                int
                f_10626_32666_32709(Microsoft.CodeAnalysis.CSharp.MethodCompiler
                this_param, Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                compilationState)
                {
                    this_param.CompileSynthesizedMethods(compilationState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 32666, 32709);
                    return 0;
                }


                int
                f_10626_32749_32772(Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 32749, 32772);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10626_32232_32247_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 32232, 32247);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10626, 32062, 32799);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10626, 32062, 32799);
            }
        }

        private void CompileSynthesizedMethods(TypeCompilationState compilationState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10626, 32811, 37974);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 32913, 32956);

                f_10626_32913_32955(_moduleBeingBuiltOpt != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 32970, 33042);

                f_10626_32970_33041(compilationState.ModuleBuilderOpt == _moduleBeingBuiltOpt);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 33058, 33119);

                var
                synthesizedMethods = f_10626_33083_33118(compilationState)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 33133, 33219) || true) && (synthesizedMethods == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 33133, 33219);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 33197, 33204);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 33133, 33219);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 33235, 33292);

                var
                oldImportChain = compilationState.CurrentImportChain
                ;
                try
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 33342, 37826);
                        foreach (var methodWithBody in f_10626_33373_33391_I(synthesizedMethods))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 33342, 37826);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 33433, 33478);

                            var
                            importChain = methodWithBody.ImportChain
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 33500, 33550);

                            compilationState.CurrentImportChain = importChain;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 33860, 33916);

                            var
                            diagnosticsThisMethod = f_10626_33888_33915()
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 33940, 33975);

                            var
                            method = methodWithBody.Method
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 33997, 34045);

                            var
                            lambda = method as SynthesizedClosureMethod
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 34067, 34374);

                            var
                            variableSlotAllocatorOpt = (DynAbs.Tracing.TraceSender.Conditional_F1(10626, 34098, 34122) || ((((object)lambda != null) && DynAbs.Tracing.TraceSender.Conditional_F2(10626, 34150, 34255)) || DynAbs.Tracing.TraceSender.Conditional_F3(10626, 34283, 34373))) ? f_10626_34150_34255(_moduleBeingBuiltOpt, lambda, f_10626_34210_34231(lambda), diagnosticsThisMethod) : f_10626_34283_34373(_moduleBeingBuiltOpt, method, method, diagnosticsThisMethod)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 34887, 34916);

                            const int
                            methodOrdinal = -1
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 34938, 34968);

                            MethodBody
                            emittedBody = null
                            ;

                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 35199, 35241);

                                IteratorStateMachine
                                iteratorStateMachine
                                = default(IteratorStateMachine);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 35267, 35458);

                                BoundStatement
                                loweredBody = f_10626_35296_35457(methodWithBody.Body, method, methodOrdinal, variableSlotAllocatorOpt, compilationState, diagnosticsThisMethod, out iteratorStateMachine)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 35484, 35543);

                                StateMachineTypeSymbol
                                stateMachine = iteratorStateMachine
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 35571, 36109) || true) && (f_10626_35575_35597_M(!loweredBody.HasErrors))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 35571, 36109);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 35655, 35691);

                                    AsyncStateMachine
                                    asyncStateMachine
                                    = default(AsyncStateMachine);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 35721, 35883);

                                    loweredBody = f_10626_35735_35882(loweredBody, method, methodOrdinal, variableSlotAllocatorOpt, compilationState, diagnosticsThisMethod, out asyncStateMachine);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 35915, 36003);

                                    f_10626_35915_36002((object)iteratorStateMachine == null || (DynAbs.Tracing.TraceSender.Expression_False(10626, 35928, 36001) || (object)asyncStateMachine == null));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 36033, 36082);

                                    stateMachine = stateMachine ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.StateMachineTypeSymbol>(10626, 36048, 36081) ?? asyncStateMachine);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 35571, 36109);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 36137, 37228) || true) && (!f_10626_36142_36178(diagnosticsThisMethod) && (DynAbs.Tracing.TraceSender.Expression_True(10626, 36141, 36199) && !_globalHasErrors))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 36137, 37228);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 36257, 37201);

                                    emittedBody = f_10626_36271_37200(_moduleBeingBuiltOpt, method, methodOrdinal, loweredBody, ImmutableArray<LambdaDebugInfo>.Empty, ImmutableArray<ClosureDebugInfo>.Empty, stateMachine, variableSlotAllocatorOpt, diagnosticsThisMethod, _debugDocumentProvider, (DynAbs.Tracing.TraceSender.Conditional_F1(10626, 36878, 36902) || ((f_10626_36878_36902(method) && DynAbs.Tracing.TraceSender.Conditional_F2(10626, 36905, 36916)) || DynAbs.Tracing.TraceSender.Conditional_F3(10626, 36919, 36923))) ? importChain : null, emittingPdb: _emittingPdb, emitTestCoverageData: _emitTestCoverageData, dynamicAnalysisSpans: ImmutableArray<SourceSpan>.Empty, _entryPointOpt);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 36137, 37228);
                                }
                            }
                            catch (BoundTreeVisitor.CancelledByStackGuardException ex)
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCatch(10626, 37273, 37431);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 37380, 37408);

                                f_10626_37380_37407(ex, _diagnostics);
                                DynAbs.Tracing.TraceSender.TraceExitCatch(10626, 37273, 37431);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 37455, 37500);

                            f_10626_37455_37499(
                                                _diagnostics, diagnosticsThisMethod);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 37522, 37551);

                            f_10626_37522_37550(diagnosticsThisMethod);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 37625, 37727) || true) && (emittedBody == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 37625, 37727);
                                DynAbs.Tracing.TraceSender.TraceBreak(10626, 37698, 37704);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 37625, 37727);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 37751, 37807);

                            f_10626_37751_37806(
                                                _moduleBeingBuiltOpt, method, emittedBody);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 33342, 37826);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10626, 1, 4485);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10626, 1, 4485);
                    }
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(10626, 37855, 37963);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 37895, 37948);

                    compilationState.CurrentImportChain = oldImportChain;
                    DynAbs.Tracing.TraceSender.TraceExitFinally(10626, 37855, 37963);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10626, 32811, 37974);

                int
                f_10626_32913_32955(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 32913, 32955);
                    return 0;
                }


                int
                f_10626_32970_33041(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 32970, 33041);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.TypeCompilationState.MethodWithBody>?
                f_10626_33083_33118(Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                this_param)
                {
                    var return_v = this_param.SynthesizedMethods;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 33083, 33118);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10626_33888_33915()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 33888, 33915);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10626_34210_34231(Microsoft.CodeAnalysis.CSharp.SynthesizedClosureMethod
                this_param)
                {
                    var return_v = this_param.TopLevelMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 34210, 34231);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.VariableSlotAllocator
                f_10626_34150_34255(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.SynthesizedClosureMethod
                method, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                topLevelMethod, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.TryCreateVariableSlotAllocator((Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)method, topLevelMethod, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 34150, 34255);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.VariableSlotAllocator
                f_10626_34283_34373(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                topLevelMethod, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.TryCreateVariableSlotAllocator(method, topLevelMethod, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 34283, 34373);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10626_35296_35457(Microsoft.CodeAnalysis.CSharp.BoundStatement
                body, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, int
                methodOrdinal, Microsoft.CodeAnalysis.CodeGen.VariableSlotAllocator
                slotAllocatorOpt, Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                compilationState, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out Microsoft.CodeAnalysis.CSharp.IteratorStateMachine
                stateMachineType)
                {
                    var return_v = IteratorRewriter.Rewrite(body, method, methodOrdinal, slotAllocatorOpt, compilationState, diagnostics, out stateMachineType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 35296, 35457);
                    return return_v;
                }


                bool
                f_10626_35575_35597_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 35575, 35597);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10626_35735_35882(Microsoft.CodeAnalysis.CSharp.BoundStatement
                bodyWithAwaitLifted, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, int
                methodOrdinal, Microsoft.CodeAnalysis.CodeGen.VariableSlotAllocator
                slotAllocatorOpt, Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                compilationState, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out Microsoft.CodeAnalysis.CSharp.AsyncStateMachine
                stateMachineType)
                {
                    var return_v = AsyncRewriter.Rewrite(bodyWithAwaitLifted, method, methodOrdinal, slotAllocatorOpt, compilationState, diagnostics, out stateMachineType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 35735, 35882);
                    return return_v;
                }


                int
                f_10626_35915_36002(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 35915, 36002);
                    return 0;
                }


                bool
                f_10626_36142_36178(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.HasAnyErrors();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 36142, 36178);
                    return return_v;
                }


                bool
                f_10626_36878_36902(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.GenerateDebugInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 36878, 36902);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.MethodBody
                f_10626_36271_37200(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                moduleBuilder, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, int
                methodOrdinal, Microsoft.CodeAnalysis.CSharp.BoundStatement
                block, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.LambdaDebugInfo>
                lambdaDebugInfo, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.ClosureDebugInfo>
                closureDebugInfo, Microsoft.CodeAnalysis.CSharp.StateMachineTypeSymbol?
                stateMachineTypeOpt, Microsoft.CodeAnalysis.CodeGen.VariableSlotAllocator
                variableSlotAllocatorOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CodeGen.DebugDocumentProvider
                debugDocumentProvider, Microsoft.CodeAnalysis.CSharp.ImportChain?
                importChainOpt, bool
                emittingPdb, bool
                emitTestCoverageData, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.SourceSpan>
                dynamicAnalysisSpans, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEntryPointSymbol.AsyncForwardEntryPoint
                entryPointOpt)
                {
                    var return_v = GenerateMethodBody(moduleBuilder, method, methodOrdinal, block, lambdaDebugInfo, closureDebugInfo, stateMachineTypeOpt, variableSlotAllocatorOpt, diagnostics, debugDocumentProvider, importChainOpt, emittingPdb: emittingPdb, emitTestCoverageData: emitTestCoverageData, dynamicAnalysisSpans: dynamicAnalysisSpans, entryPointOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 36271, 37200);
                    return return_v;
                }


                int
                f_10626_37380_37407(Microsoft.CodeAnalysis.CSharp.BoundTreeVisitor.CancelledByStackGuardException
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.AddAnError(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 37380, 37407);
                    return 0;
                }


                int
                f_10626_37455_37499(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                bag)
                {
                    this_param.AddRange(bag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 37455, 37499);
                    return 0;
                }


                int
                f_10626_37522_37550(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 37522, 37550);
                    return 0;
                }


                int
                f_10626_37751_37806(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                methodSymbol, Microsoft.CodeAnalysis.CodeGen.MethodBody
                body)
                {
                    this_param.SetMethodBody((Microsoft.CodeAnalysis.Symbols.IMethodSymbolInternal)methodSymbol, (Microsoft.Cci.IMethodBody)body);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 37751, 37806);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.TypeCompilationState.MethodWithBody>
                f_10626_33373_33391_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.TypeCompilationState.MethodWithBody>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 33373, 33391);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10626, 32811, 37974);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10626, 32811, 37974);
            }
        }

        private static bool IsFieldLikeEventAccessor(MethodSymbol method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10626, 37986, 38360);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 38076, 38135);

                Symbol
                associatedPropertyOrEvent = f_10626_38111_38134(method)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 38149, 38349);

                return (object)associatedPropertyOrEvent != null && (DynAbs.Tracing.TraceSender.Expression_True(10626, 38156, 38268) && f_10626_38218_38248(associatedPropertyOrEvent) == SymbolKind.Event) && (DynAbs.Tracing.TraceSender.Expression_True(10626, 38156, 38348) && f_10626_38289_38348(((EventSymbol)associatedPropertyOrEvent)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10626, 37986, 38360);

                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10626_38111_38134(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.AssociatedSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 38111, 38134);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10626_38218_38248(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 38218, 38248);
                    return return_v;
                }


                bool
                f_10626_38289_38348(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.HasAssociatedField;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 38289, 38348);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10626, 37986, 38360);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10626, 37986, 38360);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void CompileSynthesizedExplicitImplementations(SourceMemberContainerTypeSymbol sourceTypeSymbol, TypeCompilationState compilationState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10626, 38805, 39844);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 39090, 39833) || true) && (!_globalHasErrors)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 39090, 39833);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 39145, 39818);
                        foreach (var synthesizedExplicitImpl in f_10626_39185_39259_I(f_10626_39185_39259(sourceTypeSymbol, _cancellationToken)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 39145, 39818);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 39301, 39367);

                            f_10626_39301_39366(f_10626_39314_39365(synthesizedExplicitImpl));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 39389, 39444);

                            var
                            discardedDiagnostics = f_10626_39416_39443()
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 39466, 39549);

                            f_10626_39466_39548(synthesizedExplicitImpl, compilationState, discardedDiagnostics);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 39571, 39622);

                            f_10626_39571_39621(!f_10626_39585_39620(discardedDiagnostics));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 39644, 39672);

                            f_10626_39644_39671(discardedDiagnostics);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 39694, 39799);

                            f_10626_39694_39798(_moduleBeingBuiltOpt, sourceTypeSymbol, f_10626_39758_39797(synthesizedExplicitImpl));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 39145, 39818);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10626, 1, 674);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10626, 1, 674);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 39090, 39833);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10626, 38805, 39844);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedExplicitImplementationForwardingMethod>
                f_10626_39185_39259(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                this_param, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetSynthesizedExplicitImplementations(cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 39185, 39259);
                    return return_v;
                }


                bool
                f_10626_39314_39365(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedExplicitImplementationForwardingMethod
                this_param)
                {
                    var return_v = this_param.SynthesizesLoweredBoundBody;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 39314, 39365);
                    return return_v;
                }


                int
                f_10626_39301_39366(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 39301, 39366);
                    return 0;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10626_39416_39443()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 39416, 39443);
                    return return_v;
                }


                int
                f_10626_39466_39548(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedExplicitImplementationForwardingMethod
                this_param, Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                compilationState, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.GenerateMethodBody(compilationState, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 39466, 39548);
                    return 0;
                }


                bool
                f_10626_39585_39620(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.HasAnyErrors();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 39585, 39620);
                    return return_v;
                }


                int
                f_10626_39571_39621(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 39571, 39621);
                    return 0;
                }


                int
                f_10626_39644_39671(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 39644, 39671);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                f_10626_39758_39797(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedExplicitImplementationForwardingMethod
                this_param)
                {
                    var return_v = this_param.GetCciAdapter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 39758, 39797);
                    return return_v;
                }


                int
                f_10626_39694_39798(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                container, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                method)
                {
                    this_param.AddSynthesizedDefinition((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)container, (Microsoft.Cci.IMethodDefinition)method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 39694, 39798);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedExplicitImplementationForwardingMethod>
                f_10626_39185_39259_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedExplicitImplementationForwardingMethod>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 39185, 39259);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10626, 38805, 39844);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10626, 38805, 39844);
            }
        }

        private void CompileSynthesizedSealedAccessors(SourcePropertySymbolBase sourceProperty, TypeCompilationState compilationState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10626, 39856, 40841);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 40007, 40107);

                SynthesizedSealedPropertyAccessor
                synthesizedAccessor = f_10626_40063_40106(sourceProperty)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 40240, 40830) || true) && ((object)synthesizedAccessor != null && (DynAbs.Tracing.TraceSender.Expression_True(10626, 40244, 40300) && !_globalHasErrors))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 40240, 40830);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 40334, 40396);

                    f_10626_40334_40395(f_10626_40347_40394(synthesizedAccessor));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 40414, 40469);

                    var
                    discardedDiagnostics = f_10626_40441_40468()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 40487, 40566);

                    f_10626_40487_40565(synthesizedAccessor, compilationState, discardedDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 40584, 40635);

                    f_10626_40584_40634(!f_10626_40598_40633(discardedDiagnostics));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 40653, 40681);

                    f_10626_40653_40680(discardedDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 40701, 40815);

                    f_10626_40701_40814(
                                    _moduleBeingBuiltOpt, f_10626_40747_40776(sourceProperty), f_10626_40778_40813(synthesizedAccessor));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 40240, 40830);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10626, 39856, 40841);

                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedSealedPropertyAccessor
                f_10626_40063_40106(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                this_param)
                {
                    var return_v = this_param.SynthesizedSealedAccessorOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 40063, 40106);
                    return return_v;
                }


                bool
                f_10626_40347_40394(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedSealedPropertyAccessor
                this_param)
                {
                    var return_v = this_param.SynthesizesLoweredBoundBody;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 40347, 40394);
                    return return_v;
                }


                int
                f_10626_40334_40395(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 40334, 40395);
                    return 0;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10626_40441_40468()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 40441, 40468);
                    return return_v;
                }


                int
                f_10626_40487_40565(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedSealedPropertyAccessor
                this_param, Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                compilationState, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.GenerateMethodBody(compilationState, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 40487, 40565);
                    return 0;
                }


                bool
                f_10626_40598_40633(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.HasAnyErrors();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 40598, 40633);
                    return return_v;
                }


                int
                f_10626_40584_40634(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 40584, 40634);
                    return 0;
                }


                int
                f_10626_40653_40680(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 40653, 40680);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10626_40747_40776(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 40747, 40776);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                f_10626_40778_40813(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedSealedPropertyAccessor
                this_param)
                {
                    var return_v = this_param.GetCciAdapter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 40778, 40813);
                    return return_v;
                }


                int
                f_10626_40701_40814(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                container, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                method)
                {
                    this_param.AddSynthesizedDefinition(container, (Microsoft.Cci.IMethodDefinition)method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 40701, 40814);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10626, 39856, 40841);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10626, 39856, 40841);
            }
        }

        private void CompileFieldLikeEventAccessor(SourceEventSymbol eventSymbol, bool isAddMethod)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10626, 40853, 43311);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 40969, 41056);

                MethodSymbol
                accessor = (DynAbs.Tracing.TraceSender.Conditional_F1(10626, 40993, 41004) || ((isAddMethod && DynAbs.Tracing.TraceSender.Conditional_F2(10626, 41007, 41028)) || DynAbs.Tracing.TraceSender.Conditional_F3(10626, 41031, 41055))) ? f_10626_41007_41028(eventSymbol) : f_10626_41031_41055(eventSymbol)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 41072, 41128);

                var
                diagnosticsThisMethod = f_10626_41100_41127()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 41178, 41322);

                    BoundBlock
                    boundBody = f_10626_41201_41321(eventSymbol, isAddMethod, _compilation, diagnosticsThisMethod)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 41340, 41393);

                    var
                    hasErrors = f_10626_41356_41392(diagnosticsThisMethod)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 41411, 41443);

                    f_10626_41411_41442(this, hasErrors);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 41892, 43124) || true) && (!hasErrors && (DynAbs.Tracing.TraceSender.Expression_True(10626, 41896, 41932) && !_hasDeclarationErrors))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 41892, 43124);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 41974, 42005);

                        const int
                        accessorOrdinal = -1
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 42029, 42894);

                        MethodBody
                        emittedBody = f_10626_42054_42893(_moduleBeingBuiltOpt, accessor, accessorOrdinal, boundBody, ImmutableArray<LambdaDebugInfo>.Empty, ImmutableArray<ClosureDebugInfo>.Empty, stateMachineTypeOpt: null, variableSlotAllocatorOpt: null, diagnostics: diagnosticsThisMethod, debugDocumentProvider: _debugDocumentProvider, importChainOpt: null, emittingPdb: false, emitTestCoverageData: _emitTestCoverageData, dynamicAnalysisSpans: ImmutableArray<SourceSpan>.Empty, entryPointOpt: null)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 42918, 42976);

                        f_10626_42918_42975(
                                            _moduleBeingBuiltOpt, accessor, emittedBody);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 41892, 43124);
                    }
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(10626, 43153, 43300);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 43193, 43238);

                    f_10626_43193_43237(_diagnostics, diagnosticsThisMethod);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 43256, 43285);

                    f_10626_43256_43284(diagnosticsThisMethod);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(10626, 43153, 43300);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10626, 40853, 43311);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10626_41007_41028(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol
                this_param)
                {
                    var return_v = this_param.AddMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 41007, 41028);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10626_41031_41055(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol
                this_param)
                {
                    var return_v = this_param.RemoveMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 41031, 41055);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10626_41100_41127()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 41100, 41127);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10626_41201_41321(Microsoft.CodeAnalysis.CSharp.Symbols.SourceEventSymbol
                eventSymbol, bool
                isAddMethod, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = MethodBodySynthesizer.ConstructFieldLikeEventAccessorBody(eventSymbol, isAddMethod, compilation, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 41201, 41321);
                    return return_v;
                }


                bool
                f_10626_41356_41392(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.HasAnyErrors();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 41356, 41392);
                    return return_v;
                }


                int
                f_10626_41411_41442(Microsoft.CodeAnalysis.CSharp.MethodCompiler
                this_param, bool
                arg)
                {
                    this_param.SetGlobalErrorIfTrue(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 41411, 41442);
                    return 0;
                }


                Microsoft.CodeAnalysis.CodeGen.MethodBody
                f_10626_42054_42893(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                moduleBuilder, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                method, int
                methodOrdinal, Microsoft.CodeAnalysis.CSharp.BoundBlock
                block, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.LambdaDebugInfo>
                lambdaDebugInfo, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.ClosureDebugInfo>
                closureDebugInfo, Microsoft.CodeAnalysis.CSharp.StateMachineTypeSymbol
                stateMachineTypeOpt, Microsoft.CodeAnalysis.CodeGen.VariableSlotAllocator
                variableSlotAllocatorOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CodeGen.DebugDocumentProvider
                debugDocumentProvider, Microsoft.CodeAnalysis.CSharp.ImportChain
                importChainOpt, bool
                emittingPdb, bool
                emitTestCoverageData, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.SourceSpan>
                dynamicAnalysisSpans, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEntryPointSymbol.AsyncForwardEntryPoint
                entryPointOpt)
                {
                    var return_v = GenerateMethodBody(moduleBuilder, method, methodOrdinal, (Microsoft.CodeAnalysis.CSharp.BoundStatement)block, lambdaDebugInfo, closureDebugInfo, stateMachineTypeOpt: stateMachineTypeOpt, variableSlotAllocatorOpt: variableSlotAllocatorOpt, diagnostics: diagnostics, debugDocumentProvider: debugDocumentProvider, importChainOpt: importChainOpt, emittingPdb: emittingPdb, emitTestCoverageData: emitTestCoverageData, dynamicAnalysisSpans: dynamicAnalysisSpans, entryPointOpt: entryPointOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 42054, 42893);
                    return return_v;
                }


                int
                f_10626_42918_42975(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                methodSymbol, Microsoft.CodeAnalysis.CodeGen.MethodBody
                body)
                {
                    this_param.SetMethodBody((Microsoft.CodeAnalysis.Symbols.IMethodSymbolInternal?)methodSymbol, (Microsoft.Cci.IMethodBody)body);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 42918, 42975);
                    return 0;
                }


                int
                f_10626_43193_43237(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                bag)
                {
                    this_param.AddRange(bag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 43193, 43237);
                    return 0;
                }


                int
                f_10626_43256_43284(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 43256, 43284);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10626, 40853, 43311);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10626, 40853, 43311);
            }
        }

        public override object VisitMethod(MethodSymbol symbol, TypeCompilationState arg)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10626, 43323, 43477);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 43429, 43466);

                throw f_10626_43435_43465();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10626, 43323, 43477);

                System.Exception
                f_10626_43435_43465()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 43435, 43465);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10626, 43323, 43477);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10626, 43323, 43477);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override object VisitProperty(PropertySymbol symbol, TypeCompilationState argument)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10626, 43489, 43652);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 43604, 43641);

                throw f_10626_43610_43640();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10626, 43489, 43652);

                System.Exception
                f_10626_43610_43640()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 43610, 43640);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10626, 43489, 43652);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10626, 43489, 43652);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override object VisitEvent(EventSymbol symbol, TypeCompilationState argument)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10626, 43664, 43821);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 43773, 43810);

                throw f_10626_43779_43809();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10626, 43664, 43821);

                System.Exception
                f_10626_43779_43809()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 43779, 43809);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10626, 43664, 43821);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10626, 43664, 43821);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override object VisitField(FieldSymbol symbol, TypeCompilationState argument)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10626, 43833, 43990);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 43942, 43979);

                throw f_10626_43948_43978();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10626, 43833, 43990);

                System.Exception
                f_10626_43948_43978()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 43948, 43978);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10626, 43833, 43990);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10626, 43833, 43990);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void CompileMethod(
                    MethodSymbol methodSymbol,
                    int methodOrdinal,
                    ref Binder.ProcessedFieldInitializers processedInitializers,
                    SynthesizedSubmissionFields previousSubmissionFields,
                    TypeCompilationState compilationState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10626, 44002, 66891);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 44319, 44369);

                _cancellationToken.ThrowIfCancellationRequested();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 44383, 44464);

                SourceMemberMethodSymbol
                sourceMethod = methodSymbol as SourceMemberMethodSymbol
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 44480, 45084) || true) && (f_10626_44484_44507(methodSymbol) || (DynAbs.Tracing.TraceSender.Expression_False(10626, 44484, 44564) || f_10626_44539_44556(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10626_44511_44538(methodSymbol), 10626, 44511, 44556)) == true))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 44480, 45084);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 44598, 45042) || true) && ((object)sourceMethod != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 44598, 45042);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 44672, 44690);

                        bool
                        diagsWritten
                        = default(bool);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 44712, 44792);

                        f_10626_44712_44791(sourceMethod, ImmutableArray<Diagnostic>.Empty, out diagsWritten);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 44814, 45023) || true) && (diagsWritten && (DynAbs.Tracing.TraceSender.Expression_True(10626, 44818, 44868) && f_10626_44834_44868_M(!methodSymbol.IsImplicitlyDeclared)) && (DynAbs.Tracing.TraceSender.Expression_True(10626, 44818, 44903) && f_10626_44872_44895(_compilation) != null))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 44814, 45023);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 44953, 45000);

                            f_10626_44953_44999(_compilation, methodSymbol);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 44814, 45023);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 44598, 45042);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 45062, 45069);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 44480, 45084);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 45171, 45516) || true) && (_moduleBeingBuiltOpt == null && (DynAbs.Tracing.TraceSender.Expression_True(10626, 45175, 45235) && (object)sourceMethod != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 45171, 45516);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 45269, 45318);

                    var
                    cachedDiagnostics = f_10626_45293_45317(sourceMethod)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 45338, 45501) || true) && (f_10626_45342_45370_M(!cachedDiagnostics.IsDefault))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 45338, 45501);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 45412, 45453);

                        f_10626_45412_45452(_diagnostics, cachedDiagnostics);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 45475, 45482);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 45338, 45501);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 45171, 45516);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 45532, 45597);

                ImportChain
                oldImportChain = compilationState.CurrentImportChain
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 45737, 45803);

                DiagnosticBag
                diagsForCurrentMethod = f_10626_45775_45802()
                ;

                try
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 45930, 46315) || true) && (f_10626_45934_45974(methodSymbol))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 45930, 46315);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 46016, 46265) || true) && (_moduleBeingBuiltOpt != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 46016, 46265);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 46098, 46171);

                            f_10626_46098_46170(methodSymbol, compilationState, diagsForCurrentMethod);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 46197, 46242);

                            f_10626_46197_46241(_diagnostics, diagsForCurrentMethod);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 46016, 46265);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 46289, 46296);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 45930, 46315);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 46415, 46531) || true) && (f_10626_46419_46463(methodSymbol))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 46415, 46531);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 46505, 46512);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 46415, 46531);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 46551, 46598);

                    bool
                    includeNonEmptyInitializersInBody = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 46616, 46632);

                    BoundBlock
                    body
                    = default(BoundBlock);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 46650, 46682);

                    bool
                    originalBodyNested = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 46780, 46827);

                    BoundStatementList
                    analyzedInitializers = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 46845, 46909);

                    MethodBodySemanticModel.InitialState
                    forSemanticModel = default
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 46927, 46958);

                    ImportChain
                    importChain = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 46976, 47010);

                    var
                    hasTrailingExpression = false
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 47030, 53639) || true) && (f_10626_47034_47066(methodSymbol))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 47030, 53639);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 47108, 47156);

                        f_10626_47108_47155(f_10626_47121_47154(methodSymbol));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 47178, 47342);

                        body = new BoundBlock(f_10626_47200_47235(methodSymbol), ImmutableArray<LocalSymbol>.Empty, ImmutableArray<BoundStatement>.Empty) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10626, 47185, 47341) };
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 47030, 53639);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 47030, 53639);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 47384, 53639) || true) && (f_10626_47388_47420(methodSymbol))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 47384, 53639);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 47462, 47510);

                            f_10626_47462_47509(f_10626_47475_47508(methodSymbol));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 47675, 47871);

                            var
                            initializerStatements = f_10626_47703_47870(processedInitializers.BoundInitializers, methodSymbol, out hasTrailingExpression)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 48019, 48121);

                            body = f_10626_48026_48120(initializerStatements.Syntax, f_10626_48087_48119(initializerStatements));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 48145, 48593);

                            f_10626_48145_48592(_compilation, methodSymbol, initializerStatements, diagsForCurrentMethod, useConstructorExitWarnings: false, initialNullableState: null, getFinalNullableState: true, out processedInitializers.AfterInitializersState);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 48617, 48669);

                            var
                            unusedDiagnostics = f_10626_48641_48668()
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 48691, 48825);

                            f_10626_48691_48824(_compilation, methodSymbol, initializerStatements, unusedDiagnostics, requireOutParamsAssigned: false);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 48847, 48950);

                            f_10626_48847_48949(_compilation, initializerStatements, unusedDiagnostics, methodSymbol);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 48972, 48997);

                            f_10626_48972_48996(unusedDiagnostics);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 47384, 53639);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 47384, 53639);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 49079, 49157);

                            var
                            includeInitializersInBody = f_10626_49111_49156(methodSymbol)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 49282, 49405);

                            includeNonEmptyInitializersInBody = includeInitializersInBody && (DynAbs.Tracing.TraceSender.Expression_True(10626, 49318, 49404) && f_10626_49347_49404_M(!processedInitializers.BoundInitializers.IsDefaultOrEmpty));

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 49429, 49838) || true) && (includeNonEmptyInitializersInBody && (DynAbs.Tracing.TraceSender.Expression_True(10626, 49433, 49519) && processedInitializers.LoweredInitializers == null))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 49429, 49838);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 49569, 49686);

                                analyzedInitializers = f_10626_49592_49685(processedInitializers.BoundInitializers, methodSymbol);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 49712, 49815);

                                processedInitializers.HasErrors = processedInitializers.HasErrors || (DynAbs.Tracing.TraceSender.Expression_False(10626, 49746, 49814) || f_10626_49781_49814(analyzedInitializers));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 49429, 49838);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 49862, 50779) || true) && (includeInitializersInBody && (DynAbs.Tracing.TraceSender.Expression_True(10626, 49866, 49947) && processedInitializers.AfterInitializersState is null))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 49862, 50779);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 49997, 50756);

                                f_10626_49997_50755(_compilation, methodSymbol, analyzedInitializers ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.BoundStatementList?>(10626, 50383, 50444) ?? f_10626_50407_50444(methodSymbol)), diagsForCurrentMethod, useConstructorExitWarnings: false, initialNullableState: null, getFinalNullableState: true, out processedInitializers.AfterInitializersState);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 49862, 50779);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 50801, 50987);

                            body = f_10626_50808_50986(methodSymbol, compilationState, diagsForCurrentMethod, processedInitializers.AfterInitializersState, out importChain, out originalBodyNested, out forSemanticModel);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 51009, 51178) || true) && (f_10626_51013_51049(diagsForCurrentMethod) && (DynAbs.Tracing.TraceSender.Expression_True(10626, 51013, 51065) && body != null))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 51009, 51178);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 51115, 51155);

                                body = (BoundBlock)f_10626_51134_51154(body);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 51009, 51178);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 51640, 53620) || true) && (includeNonEmptyInitializersInBody && (DynAbs.Tracing.TraceSender.Expression_True(10626, 51644, 51730) && processedInitializers.LoweredInitializers == null))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 51640, 53620);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 51780, 53597) || true) && (body != null && (DynAbs.Tracing.TraceSender.Expression_True(10626, 51784, 51958) && ((f_10626_51802_51844(f_10626_51802_51829(methodSymbol)) && (DynAbs.Tracing.TraceSender.Expression_True(10626, 51802, 51883) && f_10626_51848_51883_M(!methodSymbol.IsImplicitConstructor))) || (DynAbs.Tracing.TraceSender.Expression_False(10626, 51801, 51932) || methodSymbol is SynthesizedRecordConstructor) || (DynAbs.Tracing.TraceSender.Expression_False(10626, 51801, 51957) || _emitTestCoverageData))))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 51780, 53597);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 52016, 52613) || true) && (_emitTestCoverageData && (DynAbs.Tracing.TraceSender.Expression_True(10626, 52020, 52079) && f_10626_52045_52079(methodSymbol)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 52016, 52613);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 52445, 52582);

                                        f_10626_52445_52581(_compilation, methodSymbol, analyzedInitializers, diagsForCurrentMethod, requireOutParamsAssigned: false);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 52016, 52613);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 52769, 52871);

                                    body = f_10626_52776_52870(body, f_10626_52788_52799(body), f_10626_52801_52820(body), body.Statements.Insert(0, analyzedInitializers));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 52901, 52943);

                                    includeNonEmptyInitializersInBody = false;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 52973, 53001);

                                    analyzedInitializers = null;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 51780, 53597);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 51780, 53597);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 53297, 53434);

                                    f_10626_53297_53433(_compilation, methodSymbol, analyzedInitializers, diagsForCurrentMethod, requireOutParamsAssigned: false);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 53464, 53570);

                                    f_10626_53464_53569(_compilation, analyzedInitializers, diagsForCurrentMethod, methodSymbol);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 51780, 53597);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 51640, 53620);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 47384, 53639);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 47030, 53639);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 53864, 54245) || true) && ((f_10626_53869_53892(methodSymbol) == MethodKind.Constructor || (DynAbs.Tracing.TraceSender.Expression_False(10626, 53869, 53977) || f_10626_53922_53945(methodSymbol) == MethodKind.StaticConstructor)) && (DynAbs.Tracing.TraceSender.Expression_True(10626, 53868, 54036) && f_10626_54003_54036(methodSymbol)) && (DynAbs.Tracing.TraceSender.Expression_True(10626, 53868, 54052) && body == null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 53864, 54245);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 54192, 54226);

                        f_10626_54192_54225(importChain == null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 53864, 54245);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 54373, 54494);

                    f_10626_54373_54493(processedInitializers.BoundInitializers.IsDefaultOrEmpty || (DynAbs.Tracing.TraceSender.Expression_False(10626, 54386, 54492) || processedInitializers.FirstImportChain != null));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 54522, 54590);

                    importChain = importChain ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.ImportChain?>(10626, 54536, 54589) ?? processedInitializers.FirstImportChain);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 54702, 54752);

                    compilationState.CurrentImportChain = importChain;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 54772, 54939) || true) && (body != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 54772, 54939);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 54830, 54920);

                        f_10626_54830_54919(_compilation, body, diagsForCurrentMethod, methodSymbol);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 54772, 54939);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 54959, 54994);

                    BoundBlock
                    flowAnalyzedBody = null
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 55012, 55262) || true) && (body != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 55012, 55262);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 55070, 55243);

                        flowAnalyzedBody = f_10626_55089_55242(methodSymbol, body, diagsForCurrentMethod, hasTrailingExpression: hasTrailingExpression, originalBodyNested: originalBodyNested);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 55012, 55262);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 55282, 55396);

                    bool
                    hasErrors = _hasDeclarationErrors || (DynAbs.Tracing.TraceSender.Expression_False(10626, 55299, 55360) || f_10626_55324_55360(diagsForCurrentMethod)) || (DynAbs.Tracing.TraceSender.Expression_False(10626, 55299, 55395) || processedInitializers.HasErrors)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 55604, 55636);

                    f_10626_55604_55635(this, hasErrors);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 55656, 55682);

                    bool
                    diagsWritten = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 55700, 55759);

                    var
                    actualDiagnostics = f_10626_55724_55758(diagsForCurrentMethod)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 55777, 55947) || true) && (sourceMethod != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 55777, 55947);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 55843, 55928);

                        actualDiagnostics = f_10626_55863_55927(sourceMethod, actualDiagnostics, out diagsWritten);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 55777, 55947);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 55967, 57797) || true) && (diagsWritten && (DynAbs.Tracing.TraceSender.Expression_True(10626, 55971, 56021) && f_10626_55987_56021_M(!methodSymbol.IsImplicitlyDeclared)) && (DynAbs.Tracing.TraceSender.Expression_True(10626, 55971, 56056) && f_10626_56025_56048(_compilation) != null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 55967, 57797);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 56294, 56359);

                        SyntaxTreeSemanticModel
                        semanticModelWithCachedBoundNodes = null
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 56381, 57602) || true) && (body != null && (DynAbs.Tracing.TraceSender.Expression_True(10626, 56385, 56476) && forSemanticModel.Syntax is { } semanticModelSyntax) && (DynAbs.Tracing.TraceSender.Expression_True(10626, 56385, 56600) && f_10626_56505_56539(_compilation) is CachingSemanticModelProvider cachingSemanticModelProvider))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 56381, 57602);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 56650, 56675);

                            var
                            syntax = body.Syntax
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 56701, 56841);

                            semanticModelWithCachedBoundNodes = (SyntaxTreeSemanticModel)f_10626_56762_56840(cachingSemanticModelProvider, f_10626_56808_56825(syntax), _compilation);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 56867, 57579);

                            f_10626_56867_57578(semanticModelWithCachedBoundNodes, semanticModelSyntax, (rootSyntax) =>
                                                        {
                                                            Debug.Assert(rootSyntax == forSemanticModel.Syntax);
                                                            return MethodBodySemanticModel.Create(semanticModelWithCachedBoundNodes,
                                                                                                  methodSymbol,
                                                                                                  forSemanticModel);
                                                        });
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 56381, 57602);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 57626, 57778);

                        f_10626_57626_57777(f_10626_57626_57649(_compilation), f_10626_57661_57776(_compilation, f_10626_57710_57740(methodSymbol), semanticModelWithCachedBoundNodes));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 55967, 57797);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 57998, 58174) || true) && (_moduleBeingBuiltOpt == null || (DynAbs.Tracing.TraceSender.Expression_False(10626, 58002, 58043) || hasErrors))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 57998, 58174);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 58085, 58126);

                        f_10626_58085_58125(_diagnostics, actualDiagnostics);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 58148, 58155);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 57998, 58174);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 58452, 58535);

                    ImmutableArray<SourceSpan>
                    dynamicAnalysisSpans = ImmutableArray<SourceSpan>.Empty
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 58553, 58593);

                    bool
                    hasBody = flowAnalyzedBody != null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 58611, 58666);

                    VariableSlotAllocator
                    lazyVariableSlotAllocator = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 58684, 58734);

                    StateMachineTypeSymbol
                    stateMachineTypeOpt = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 58752, 58825);

                    var
                    lambdaDebugInfoBuilder = f_10626_58781_58824()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 58843, 58918);

                    var
                    closureDebugInfoBuilder = f_10626_58873_58917()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 58936, 58973);

                    BoundStatement
                    loweredBodyOpt = null
                    ;

                    try
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 59037, 60016) || true) && (hasBody)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 59037, 60016);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 59098, 59808);

                            loweredBodyOpt = f_10626_59115_59807(methodSymbol, methodOrdinal, flowAnalyzedBody, previousSubmissionFields, compilationState, _emitTestCoverageData, _debugDocumentProvider, ref dynamicAnalysisSpans, diagsForCurrentMethod, ref lazyVariableSlotAllocator, lambdaDebugInfoBuilder, closureDebugInfoBuilder, out stateMachineTypeOpt);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 59836, 59873);

                            f_10626_59836_59872(loweredBodyOpt != null);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 59037, 60016);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 59037, 60016);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 59971, 59993);

                            loweredBodyOpt = null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 59037, 60016);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 60040, 60143);

                        hasErrors = hasErrors || (DynAbs.Tracing.TraceSender.Expression_False(10626, 60052, 60102) || (hasBody && (DynAbs.Tracing.TraceSender.Expression_True(10626, 60066, 60101) && f_10626_60077_60101(loweredBodyOpt)))) || (DynAbs.Tracing.TraceSender.Expression_False(10626, 60052, 60142) || f_10626_60106_60142(diagsForCurrentMethod));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 60165, 60197);

                        f_10626_60165_60196(this, hasErrors);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 60319, 66440) || true) && (!hasErrors && (DynAbs.Tracing.TraceSender.Expression_True(10626, 60323, 60383) && (hasBody || (DynAbs.Tracing.TraceSender.Expression_False(10626, 60338, 60382) || includeNonEmptyInitializersInBody))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 60319, 66440);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 60433, 60614);

                            f_10626_60433_60613(!(f_10626_60448_60490(methodSymbol) && (DynAbs.Tracing.TraceSender.Expression_True(10626, 60448, 60526) && f_10626_60494_60521(methodSymbol) == 0)) || (DynAbs.Tracing.TraceSender.Expression_False(10626, 60446, 60612) || !f_10626_60570_60612(f_10626_60570_60597(methodSymbol))));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 61003, 61050);

                            ImmutableArray<BoundStatement>
                            boundStatements
                            = default(ImmutableArray<BoundStatement>);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 61078, 64996) || true) && (f_10626_61082_61114(methodSymbol))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 61078, 64996);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 61172, 61313);

                                boundStatements = f_10626_61190_61312(loweredBodyOpt, methodSymbol, previousSubmissionFields, _compilation);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 61078, 64996);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 61078, 64996);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 61427, 61482);

                                boundStatements = ImmutableArray<BoundStatement>.Empty;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 61514, 63880) || true) && (analyzedInitializers != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 61514, 63880);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 61803, 61840);

                                    f_10626_61803_61839(!_emitTestCoverageData);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 61874, 61928);

                                    StateMachineTypeSymbol
                                    initializerStateMachineTypeOpt
                                    = default(StateMachineTypeSymbol);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 61964, 62801);

                                    BoundStatement
                                    lowered = f_10626_61989_62800(methodSymbol, methodOrdinal, analyzedInitializers, previousSubmissionFields, compilationState, _emitTestCoverageData, _debugDocumentProvider, ref dynamicAnalysisSpans, diagsForCurrentMethod, ref lazyVariableSlotAllocator, lambdaDebugInfoBuilder, closureDebugInfoBuilder, out initializerStateMachineTypeOpt)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 62837, 62889);

                                    processedInitializers.LoweredInitializers = lowered;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 63003, 63064);

                                    f_10626_63003_63063((object)initializerStateMachineTypeOpt == null);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 63098, 63123);

                                    f_10626_63098_63122(!hasErrors);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 63157, 63230);

                                    hasErrors = f_10626_63169_63189(lowered) || (DynAbs.Tracing.TraceSender.Expression_False(10626, 63169, 63229) || f_10626_63193_63229(diagsForCurrentMethod));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 63264, 63296);

                                    f_10626_63264_63295(this, hasErrors);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 63330, 63542) || true) && (hasErrors)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 63330, 63542);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 63417, 63462);

                                        f_10626_63417_63461(_diagnostics, diagsForCurrentMethod);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 63500, 63507);

                                        return;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 63330, 63542);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 63777, 63849);

                                    processedInitializers.LoweredInitializers = (BoundStatementList)lowered;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 61514, 63880);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 64012, 64749) || true) && (includeNonEmptyInitializersInBody)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 64012, 64749);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 64115, 64718) || true) && (f_10626_64119_64165(processedInitializers.LoweredInitializers) == BoundKind.StatementList)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 64115, 64718);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 64266, 64357);

                                        BoundStatementList
                                        lowered = (BoundStatementList)processedInitializers.LoweredInitializers
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 64395, 64456);

                                        boundStatements = boundStatements.Concat(f_10626_64436_64454(lowered));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 64115, 64718);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 64115, 64718);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 64602, 64683);

                                        boundStatements = boundStatements.Add(processedInitializers.LoweredInitializers);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 64115, 64718);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 64012, 64749);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 64781, 64969) || true) && (hasBody)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 64781, 64969);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 64858, 64938);

                                    boundStatements = boundStatements.Concat(f_10626_64899_64936(loweredBodyOpt));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 64781, 64969);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 61078, 64996);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 65024, 66417) || true) && (!(methodSymbol is SynthesizedStaticConstructor cctor) || (DynAbs.Tracing.TraceSender.Expression_False(10626, 65028, 65142) || f_10626_65085_65142(cctor, processedInitializers.BoundInitializers)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 65024, 66417);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 65200, 65262);

                                CSharpSyntaxNode
                                syntax = f_10626_65226_65261(methodSymbol)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 65294, 65366);

                                var
                                boundBody = f_10626_65310_65365(syntax, boundStatements)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 65398, 66258);

                                var
                                emittedBody = f_10626_65416_66257(_moduleBeingBuiltOpt, methodSymbol, methodOrdinal, boundBody, f_10626_65663_65699(lambdaDebugInfoBuilder), f_10626_65734_65771(closureDebugInfoBuilder), stateMachineTypeOpt, lazyVariableSlotAllocator, diagsForCurrentMethod, _debugDocumentProvider, importChain, _emittingPdb, _emitTestCoverageData, dynamicAnalysisSpans, entryPointOpt: null)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 66290, 66390);

                                f_10626_66290_66389(
                                                            _moduleBeingBuiltOpt, f_10626_66325_66359(methodSymbol) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>(10626, 66325, 66375) ?? methodSymbol), emittedBody);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 65024, 66417);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 60319, 66440);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 66464, 66509);

                        f_10626_66464_66508(
                                            _diagnostics, diagsForCurrentMethod);
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinally(10626, 66546, 66696);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 66594, 66624);

                        f_10626_66594_66623(lambdaDebugInfoBuilder);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 66646, 66677);

                        f_10626_66646_66676(closureDebugInfoBuilder);
                        DynAbs.Tracing.TraceSender.TraceExitFinally(10626, 66546, 66696);
                    }
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(10626, 66725, 66880);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 66765, 66794);

                    f_10626_66765_66793(diagsForCurrentMethod);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 66812, 66865);

                    compilationState.CurrentImportChain = oldImportChain;
                    DynAbs.Tracing.TraceSender.TraceExitFinally(10626, 66725, 66880);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10626, 44002, 66891);

                bool
                f_10626_44484_44507(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsAbstract;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 44484, 44507);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10626_44511_44538(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 44511, 44538);
                    return return_v;
                }


                bool?
                f_10626_44539_44556(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type?.IsDelegateType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 44539, 44556);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_10626_44712_44791(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                newSet, out bool
                diagsWritten)
                {
                    var return_v = this_param.SetDiagnostics(newSet, out diagsWritten);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 44712, 44791);
                    return return_v;
                }


                bool
                f_10626_44834_44868_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 44834, 44868);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AsyncQueue<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>?
                f_10626_44872_44895(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.EventQueue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 44872, 44895);
                    return return_v;
                }


                int
                f_10626_44953_44999(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol)
                {
                    this_param.SymbolDeclaredEvent((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 44953, 44999);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_10626_45293_45317(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol
                this_param)
                {
                    var return_v = this_param.Diagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 45293, 45317);
                    return return_v;
                }


                bool
                f_10626_45342_45370_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 45342, 45370);
                    return return_v;
                }


                int
                f_10626_45412_45452(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics)
                {
                    this_param.AddRange<Microsoft.CodeAnalysis.Diagnostic>(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 45412, 45452);
                    return 0;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10626_45775_45802()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 45775, 45802);
                    return return_v;
                }


                bool
                f_10626_45934_45974(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.SynthesizesLoweredBoundBody;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 45934, 45974);
                    return return_v;
                }


                int
                f_10626_46098_46170(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                compilationState, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.GenerateMethodBody(compilationState, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 46098, 46170);
                    return 0;
                }


                int
                f_10626_46197_46241(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                bag)
                {
                    this_param.AddRange(bag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 46197, 46241);
                    return 0;
                }


                bool
                f_10626_46419_46463(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = method.IsDefaultValueTypeConstructor();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 46419, 46463);
                    return return_v;
                }


                bool
                f_10626_47034_47066(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsScriptConstructor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 47034, 47066);
                    return return_v;
                }


                bool
                f_10626_47121_47154(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsImplicitlyDeclared;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 47121, 47154);
                    return return_v;
                }


                int
                f_10626_47108_47155(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 47108, 47155);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10626_47200_47235(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol)
                {
                    var return_v = symbol.GetNonNullSyntaxNode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 47200, 47235);
                    return return_v;
                }


                bool
                f_10626_47388_47420(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsScriptInitializer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 47388, 47420);
                    return return_v;
                }


                bool
                f_10626_47475_47508(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsImplicitlyDeclared;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 47475, 47508);
                    return return_v;
                }


                int
                f_10626_47462_47509(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 47462, 47509);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundTypeOrInstanceInitializers
                f_10626_47703_47870(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundInitializer>
                boundInitializers, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, out bool
                hasTrailingExpression)
                {
                    var return_v = InitializerRewriter.RewriteScriptInitializer(boundInitializers, (Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedInteractiveInitializerMethod)method, out hasTrailingExpression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 47703, 47870);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10626_48087_48119(Microsoft.CodeAnalysis.CSharp.BoundTypeOrInstanceInitializers
                this_param)
                {
                    var return_v = this_param.Statements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 48087, 48119);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10626_48026_48120(Microsoft.CodeAnalysis.SyntaxNode
                syntax, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                statements)
                {
                    var return_v = BoundBlock.SynthesizedNoLocals(syntax, statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 48026, 48120);
                    return return_v;
                }


                int
                f_10626_48145_48592(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.CSharp.BoundTypeOrInstanceInitializers
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                useConstructorExitWarnings, Microsoft.CodeAnalysis.CSharp.NullableWalker.VariableState?
                initialNullableState, bool
                getFinalNullableState, out Microsoft.CodeAnalysis.CSharp.NullableWalker.VariableState
                finalNullableState)
                {
                    NullableWalker.AnalyzeIfNeeded(compilation, method, (Microsoft.CodeAnalysis.CSharp.BoundNode)node, diagnostics, useConstructorExitWarnings: useConstructorExitWarnings, initialNullableState: initialNullableState, getFinalNullableState: getFinalNullableState, out finalNullableState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 48145, 48592);
                    return 0;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10626_48641_48668()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 48641, 48668);
                    return return_v;
                }


                int
                f_10626_48691_48824(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                member, Microsoft.CodeAnalysis.CSharp.BoundTypeOrInstanceInitializers
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                requireOutParamsAssigned)
                {
                    DefiniteAssignmentPass.Analyze(compilation, member, (Microsoft.CodeAnalysis.CSharp.BoundNode)node, diagnostics, requireOutParamsAssigned: requireOutParamsAssigned);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 48691, 48824);
                    return 0;
                }


                int
                f_10626_48847_48949(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.BoundTypeOrInstanceInitializers
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                containingSymbol)
                {
                    DiagnosticsPass.IssueDiagnostics(compilation, (Microsoft.CodeAnalysis.CSharp.BoundNode)node, diagnostics, containingSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 48847, 48949);
                    return 0;
                }


                int
                f_10626_48972_48996(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 48972, 48996);
                    return 0;
                }


                bool
                f_10626_49111_49156(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                methodSymbol)
                {
                    var return_v = methodSymbol.IncludeFieldInitializersInBody();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 49111, 49156);
                    return return_v;
                }


                bool
                f_10626_49347_49404_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 49347, 49404);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundTypeOrInstanceInitializers
                f_10626_49592_49685(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundInitializer>
                boundInitializers, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = InitializerRewriter.RewriteConstructor(boundInitializers, method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 49592, 49685);
                    return return_v;
                }


                bool
                f_10626_49781_49814(Microsoft.CodeAnalysis.CSharp.BoundStatementList
                this_param)
                {
                    var return_v = this_param.HasAnyErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 49781, 49814);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10626_50407_50444(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol)
                {
                    var return_v = GetSynthesizedEmptyBody((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 50407, 50444);
                    return return_v;
                }


                int
                f_10626_49997_50755(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.CSharp.BoundStatementList
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                useConstructorExitWarnings, Microsoft.CodeAnalysis.CSharp.NullableWalker.VariableState?
                initialNullableState, bool
                getFinalNullableState, out Microsoft.CodeAnalysis.CSharp.NullableWalker.VariableState
                finalNullableState)
                {
                    NullableWalker.AnalyzeIfNeeded(compilation, method, (Microsoft.CodeAnalysis.CSharp.BoundNode)node, diagnostics, useConstructorExitWarnings: useConstructorExitWarnings, initialNullableState: initialNullableState, getFinalNullableState: getFinalNullableState, out finalNullableState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 49997, 50755);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10626_50808_50986(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                compilationState, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.NullableWalker.VariableState?
                nullableInitialState, out Microsoft.CodeAnalysis.CSharp.ImportChain
                importChain, out bool
                originalBodyNested, out Microsoft.CodeAnalysis.CSharp.MethodBodySemanticModel.InitialState
                forSemanticModel)
                {
                    var return_v = BindMethodBody(method, compilationState, diagnostics, nullableInitialState, out importChain, out originalBodyNested, out forSemanticModel);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 50808, 50986);
                    return return_v;
                }


                bool
                f_10626_51013_51049(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.HasAnyErrors();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 51013, 51049);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10626_51134_51154(Microsoft.CodeAnalysis.CSharp.BoundBlock
                this_param)
                {
                    var return_v = this_param.WithHasErrors();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 51134, 51154);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10626_51802_51829(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 51802, 51829);
                    return return_v;
                }


                bool
                f_10626_51802_51844(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                type)
                {
                    var return_v = type.IsStructType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 51802, 51844);
                    return return_v;
                }


                bool
                f_10626_51848_51883_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 51848, 51883);
                    return return_v;
                }


                bool
                f_10626_52045_52079(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsImplicitConstructor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 52045, 52079);
                    return return_v;
                }


                int
                f_10626_52445_52581(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                member, Microsoft.CodeAnalysis.CSharp.BoundStatementList?
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                requireOutParamsAssigned)
                {
                    DefiniteAssignmentPass.Analyze(compilation, member, (Microsoft.CodeAnalysis.CSharp.BoundNode?)node, diagnostics, requireOutParamsAssigned: requireOutParamsAssigned);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 52445, 52581);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10626_52788_52799(Microsoft.CodeAnalysis.CSharp.BoundBlock
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 52788, 52799);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol>
                f_10626_52801_52820(Microsoft.CodeAnalysis.CSharp.BoundBlock
                this_param)
                {
                    var return_v = this_param.LocalFunctions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 52801, 52820);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10626_52776_52870(Microsoft.CodeAnalysis.CSharp.BoundBlock
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol>
                localFunctions, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                statements)
                {
                    var return_v = this_param.Update(locals, localFunctions, statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 52776, 52870);
                    return return_v;
                }


                int
                f_10626_53297_53433(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                member, Microsoft.CodeAnalysis.CSharp.BoundStatementList?
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                requireOutParamsAssigned)
                {
                    DefiniteAssignmentPass.Analyze(compilation, member, (Microsoft.CodeAnalysis.CSharp.BoundNode?)node, diagnostics, requireOutParamsAssigned: requireOutParamsAssigned);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 53297, 53433);
                    return 0;
                }


                int
                f_10626_53464_53569(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.BoundStatementList?
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                containingSymbol)
                {
                    DiagnosticsPass.IssueDiagnostics(compilation, (Microsoft.CodeAnalysis.CSharp.BoundNode?)node, diagnostics, containingSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 53464, 53569);
                    return 0;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10626_53869_53892(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 53869, 53892);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10626_53922_53945(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 53922, 53945);
                    return return_v;
                }


                bool
                f_10626_54003_54036(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsImplicitlyDeclared;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 54003, 54036);
                    return return_v;
                }


                int
                f_10626_54192_54225(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 54192, 54225);
                    return 0;
                }


                int
                f_10626_54373_54493(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 54373, 54493);
                    return 0;
                }


                int
                f_10626_54830_54919(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.BoundBlock
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                containingSymbol)
                {
                    DiagnosticsPass.IssueDiagnostics(compilation, (Microsoft.CodeAnalysis.CSharp.BoundNode)node, diagnostics, containingSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 54830, 54919);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10626_55089_55242(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.CSharp.BoundBlock
                block, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                hasTrailingExpression, bool
                originalBodyNested)
                {
                    var return_v = FlowAnalysisPass.Rewrite(method, block, diagnostics, hasTrailingExpression: hasTrailingExpression, originalBodyNested: originalBodyNested);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 55089, 55242);
                    return return_v;
                }


                bool
                f_10626_55324_55360(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.HasAnyErrors();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 55324, 55360);
                    return return_v;
                }


                int
                f_10626_55604_55635(Microsoft.CodeAnalysis.CSharp.MethodCompiler
                this_param, bool
                arg)
                {
                    this_param.SetGlobalErrorIfTrue(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 55604, 55635);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_10626_55724_55758(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.ToReadOnly();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 55724, 55758);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_10626_55863_55927(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                newSet, out bool
                diagsWritten)
                {
                    var return_v = this_param.SetDiagnostics(newSet, out diagsWritten);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 55863, 55927);
                    return return_v;
                }


                bool
                f_10626_55987_56021_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 55987, 56021);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AsyncQueue<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>?
                f_10626_56025_56048(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.EventQueue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 56025, 56048);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SemanticModelProvider?
                f_10626_56505_56539(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.SemanticModelProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 56505, 56539);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10626_56808_56825(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 56808, 56825);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SemanticModel
                f_10626_56762_56840(Microsoft.CodeAnalysis.Diagnostics.CachingSemanticModelProvider
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                tree, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = this_param.GetSemanticModel(tree, (Microsoft.CodeAnalysis.Compilation)compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 56762, 56840);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                f_10626_56867_57578(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node, System.Func<Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode, Microsoft.CodeAnalysis.CSharp.MemberSemanticModel>
                createMemberModelFunction)
                {
                    var return_v = this_param.GetOrAddModel(node, createMemberModelFunction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 56867, 57578);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AsyncQueue<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                f_10626_57626_57649(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.EventQueue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 57626, 57649);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IMethodSymbol?
                f_10626_57710_57740(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 57710, 57740);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.SymbolDeclaredCompilationEvent
                f_10626_57661_57776(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.IMethodSymbol
                symbol, Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel?
                semanticModelWithCachedBoundNodes)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.SymbolDeclaredCompilationEvent((Microsoft.CodeAnalysis.Compilation)compilation, (Microsoft.CodeAnalysis.ISymbol)symbol, (Microsoft.CodeAnalysis.SemanticModel?)semanticModelWithCachedBoundNodes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 57661, 57776);
                    return return_v;
                }


                bool
                f_10626_57626_57777(Microsoft.CodeAnalysis.Diagnostics.AsyncQueue<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                this_param, Microsoft.CodeAnalysis.Diagnostics.SymbolDeclaredCompilationEvent
                value)
                {
                    var return_v = this_param.TryEnqueue((Microsoft.CodeAnalysis.Diagnostics.CompilationEvent)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 57626, 57777);
                    return return_v;
                }


                int
                f_10626_58085_58125(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics)
                {
                    this_param.AddRange<Microsoft.CodeAnalysis.Diagnostic>(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 58085, 58125);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.LambdaDebugInfo>
                f_10626_58781_58824()
                {
                    var return_v = ArrayBuilder<LambdaDebugInfo>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 58781, 58824);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.ClosureDebugInfo>
                f_10626_58873_58917()
                {
                    var return_v = ArrayBuilder<ClosureDebugInfo>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 58873, 58917);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10626_59115_59807(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, int
                methodOrdinal, Microsoft.CodeAnalysis.CSharp.BoundBlock?
                body, Microsoft.CodeAnalysis.CSharp.SynthesizedSubmissionFields
                previousSubmissionFields, Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                compilationState, bool
                instrumentForDynamicAnalysis, Microsoft.CodeAnalysis.CodeGen.DebugDocumentProvider
                debugDocumentProvider, ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.SourceSpan>
                dynamicAnalysisSpans, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, ref Microsoft.CodeAnalysis.CodeGen.VariableSlotAllocator?
                lazyVariableSlotAllocator, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.LambdaDebugInfo>
                lambdaDebugInfoBuilder, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.ClosureDebugInfo>
                closureDebugInfoBuilder, out Microsoft.CodeAnalysis.CSharp.StateMachineTypeSymbol
                stateMachineTypeOpt)
                {
                    var return_v = LowerBodyOrInitializer(method, methodOrdinal, (Microsoft.CodeAnalysis.CSharp.BoundStatement?)body, previousSubmissionFields, compilationState, instrumentForDynamicAnalysis, debugDocumentProvider, ref dynamicAnalysisSpans, diagnostics, ref lazyVariableSlotAllocator, lambdaDebugInfoBuilder, closureDebugInfoBuilder, out stateMachineTypeOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 59115, 59807);
                    return return_v;
                }


                int
                f_10626_59836_59872(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 59836, 59872);
                    return 0;
                }


                bool
                f_10626_60077_60101(Microsoft.CodeAnalysis.CSharp.BoundStatement?
                this_param)
                {
                    var return_v = this_param.HasErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 60077, 60101);
                    return return_v;
                }


                bool
                f_10626_60106_60142(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.HasAnyErrors();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 60106, 60142);
                    return return_v;
                }


                int
                f_10626_60165_60196(Microsoft.CodeAnalysis.CSharp.MethodCompiler
                this_param, bool
                arg)
                {
                    this_param.SetGlobalErrorIfTrue(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 60165, 60196);
                    return 0;
                }


                bool
                f_10626_60448_60490(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsImplicitInstanceConstructor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 60448, 60490);
                    return return_v;
                }


                int
                f_10626_60494_60521(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 60494, 60521);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10626_60570_60597(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 60570, 60597);
                    return return_v;
                }


                bool
                f_10626_60570_60612(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                type)
                {
                    var return_v = type.IsStructType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 60570, 60612);
                    return return_v;
                }


                int
                f_10626_60433_60613(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 60433, 60613);
                    return 0;
                }


                bool
                f_10626_61082_61114(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsScriptConstructor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 61082, 61114);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10626_61190_61312(Microsoft.CodeAnalysis.CSharp.BoundStatement?
                loweredBody, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                constructor, Microsoft.CodeAnalysis.CSharp.SynthesizedSubmissionFields
                previousSubmissionFields, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = MethodBodySynthesizer.ConstructScriptConstructorBody(loweredBody, constructor, previousSubmissionFields, compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 61190, 61312);
                    return return_v;
                }


                int
                f_10626_61803_61839(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 61803, 61839);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10626_61989_62800(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, int
                methodOrdinal, Microsoft.CodeAnalysis.CSharp.BoundStatementList
                body, Microsoft.CodeAnalysis.CSharp.SynthesizedSubmissionFields
                previousSubmissionFields, Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                compilationState, bool
                instrumentForDynamicAnalysis, Microsoft.CodeAnalysis.CodeGen.DebugDocumentProvider
                debugDocumentProvider, ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.SourceSpan>
                dynamicAnalysisSpans, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, ref Microsoft.CodeAnalysis.CodeGen.VariableSlotAllocator?
                lazyVariableSlotAllocator, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.LambdaDebugInfo>
                lambdaDebugInfoBuilder, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.ClosureDebugInfo>
                closureDebugInfoBuilder, out Microsoft.CodeAnalysis.CSharp.StateMachineTypeSymbol
                stateMachineTypeOpt)
                {
                    var return_v = LowerBodyOrInitializer(method, methodOrdinal, (Microsoft.CodeAnalysis.CSharp.BoundStatement)body, previousSubmissionFields, compilationState, instrumentForDynamicAnalysis, debugDocumentProvider, ref dynamicAnalysisSpans, diagnostics, ref lazyVariableSlotAllocator, lambdaDebugInfoBuilder, closureDebugInfoBuilder, out stateMachineTypeOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 61989, 62800);
                    return return_v;
                }


                int
                f_10626_63003_63063(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 63003, 63063);
                    return 0;
                }


                int
                f_10626_63098_63122(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 63098, 63122);
                    return 0;
                }


                bool
                f_10626_63169_63189(Microsoft.CodeAnalysis.CSharp.BoundStatement
                this_param)
                {
                    var return_v = this_param.HasAnyErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 63169, 63189);
                    return return_v;
                }


                bool
                f_10626_63193_63229(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.HasAnyErrors();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 63193, 63229);
                    return return_v;
                }


                int
                f_10626_63264_63295(Microsoft.CodeAnalysis.CSharp.MethodCompiler
                this_param, bool
                arg)
                {
                    this_param.SetGlobalErrorIfTrue(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 63264, 63295);
                    return 0;
                }


                int
                f_10626_63417_63461(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                bag)
                {
                    this_param.AddRange(bag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 63417, 63461);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10626_64119_64165(Microsoft.CodeAnalysis.CSharp.BoundStatement?
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 64119, 64165);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10626_64436_64454(Microsoft.CodeAnalysis.CSharp.BoundStatementList
                this_param)
                {
                    var return_v = this_param.Statements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 64436, 64454);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement?>
                f_10626_64899_64936(Microsoft.CodeAnalysis.CSharp.BoundStatement?
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 64899, 64936);
                    return return_v;
                }


                bool
                f_10626_65085_65142(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedStaticConstructor
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundInitializer>
                boundInitializersOpt)
                {
                    var return_v = this_param.ShouldEmit(boundInitializersOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 65085, 65142);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10626_65226_65261(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol)
                {
                    var return_v = symbol.GetNonNullSyntaxNode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 65226, 65261);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatementList
                f_10626_65310_65365(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                statements)
                {
                    var return_v = BoundStatementList.Synthesized((Microsoft.CodeAnalysis.SyntaxNode)syntax, statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 65310, 65365);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.LambdaDebugInfo>
                f_10626_65663_65699(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.LambdaDebugInfo>
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 65663, 65699);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.ClosureDebugInfo>
                f_10626_65734_65771(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.ClosureDebugInfo>
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 65734, 65771);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.MethodBody
                f_10626_65416_66257(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                moduleBuilder, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, int
                methodOrdinal, Microsoft.CodeAnalysis.CSharp.BoundStatementList
                block, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.LambdaDebugInfo>
                lambdaDebugInfo, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.ClosureDebugInfo>
                closureDebugInfo, Microsoft.CodeAnalysis.CSharp.StateMachineTypeSymbol?
                stateMachineTypeOpt, Microsoft.CodeAnalysis.CodeGen.VariableSlotAllocator?
                variableSlotAllocatorOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CodeGen.DebugDocumentProvider
                debugDocumentProvider, Microsoft.CodeAnalysis.CSharp.ImportChain?
                importChainOpt, bool
                emittingPdb, bool
                emitTestCoverageData, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.SourceSpan>
                dynamicAnalysisSpans, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEntryPointSymbol.AsyncForwardEntryPoint
                entryPointOpt)
                {
                    var return_v = GenerateMethodBody(moduleBuilder, method, methodOrdinal, (Microsoft.CodeAnalysis.CSharp.BoundStatement)block, lambdaDebugInfo, closureDebugInfo, stateMachineTypeOpt, variableSlotAllocatorOpt, diagnostics, debugDocumentProvider, importChainOpt, emittingPdb, emitTestCoverageData, dynamicAnalysisSpans, entryPointOpt: entryPointOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 65416, 66257);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10626_66325_66359(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.PartialDefinitionPart;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 66325, 66359);
                    return return_v;
                }


                int
                f_10626_66290_66389(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                methodSymbol, Microsoft.CodeAnalysis.CodeGen.MethodBody
                body)
                {
                    this_param.SetMethodBody((Microsoft.CodeAnalysis.Symbols.IMethodSymbolInternal)methodSymbol, (Microsoft.Cci.IMethodBody)body);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 66290, 66389);
                    return 0;
                }


                int
                f_10626_66464_66508(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                bag)
                {
                    this_param.AddRange(bag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 66464, 66508);
                    return 0;
                }


                int
                f_10626_66594_66623(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.LambdaDebugInfo>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 66594, 66623);
                    return 0;
                }


                int
                f_10626_66646_66676(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.ClosureDebugInfo>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 66646, 66676);
                    return 0;
                }


                int
                f_10626_66765_66793(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 66765, 66793);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10626, 44002, 66891);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10626, 44002, 66891);
            }
        }

        internal static BoundStatement LowerBodyOrInitializer(
                    MethodSymbol method,
                    int methodOrdinal,
                    BoundStatement body,
                    SynthesizedSubmissionFields previousSubmissionFields,
                    TypeCompilationState compilationState,
                    bool instrumentForDynamicAnalysis,
                    DebugDocumentProvider debugDocumentProvider,
                    ref ImmutableArray<SourceSpan> dynamicAnalysisSpans,
                    DiagnosticBag diagnostics,
                    ref VariableSlotAllocator lazyVariableSlotAllocator,
                    ArrayBuilder<LambdaDebugInfo> lambdaDebugInfoBuilder,
                    ArrayBuilder<ClosureDebugInfo> closureDebugInfoBuilder,
                    out StateMachineTypeSymbol stateMachineTypeOpt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10626, 66936, 72195);
                bool sawLambdas = default(bool);
                bool sawLocalFunctions = default(bool);
                bool sawAwaitInExceptionHandler = default(bool);
                Microsoft.CodeAnalysis.CSharp.IteratorStateMachine iteratorStateMachine = default(Microsoft.CodeAnalysis.CSharp.IteratorStateMachine);
                Microsoft.CodeAnalysis.CSharp.AsyncStateMachine asyncStateMachine = default(Microsoft.CodeAnalysis.CSharp.AsyncStateMachine);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 67709, 67765);

                f_10626_67709_67764(compilationState.ModuleBuilderOpt != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 67779, 67806);

                stateMachineTypeOpt = null;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 67822, 67901) || true) && (f_10626_67826_67840(body))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 67822, 67901);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 67874, 67886);

                    return body;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 67822, 67901);
                }

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 67953, 68824);

                    var
                    loweredBody = f_10626_67971_68823(f_10626_68015_68042(method), method, methodOrdinal, f_10626_68130_68151(method), body, compilationState, previousSubmissionFields: previousSubmissionFields, allowOmissionOfConditionalCalls: true, instrumentForDynamicAnalysis: instrumentForDynamicAnalysis, debugDocumentProvider: debugDocumentProvider, dynamicAnalysisSpans: ref dynamicAnalysisSpans, diagnostics: diagnostics, sawLambdas: out sawLambdas, sawLocalFunctions: out sawLocalFunctions, sawAwaitInExceptionHandler: out sawAwaitInExceptionHandler)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 68844, 68949) || true) && (f_10626_68848_68869(loweredBody))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 68844, 68949);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 68911, 68930);

                        return loweredBody;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 68844, 68949);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 68969, 69763) || true) && (sawAwaitInExceptionHandler)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 68969, 69763);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 69491, 69744);

                        loweredBody = f_10626_69505_69743(method, f_10626_69602_69623(method), loweredBody, compilationState, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 68969, 69763);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 69783, 69888) || true) && (f_10626_69787_69808(loweredBody))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 69783, 69888);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 69850, 69869);

                        return loweredBody;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 69783, 69888);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 69908, 70128) || true) && (lazyVariableSlotAllocator == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 69908, 70128);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 69987, 70109);

                        lazyVariableSlotAllocator = f_10626_70015_70108(compilationState.ModuleBuilderOpt, method, method, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 69908, 70128);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 70148, 70196);

                    BoundStatement
                    bodyWithoutLambdas = loweredBody
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 70214, 70872) || true) && (sawLambdas || (DynAbs.Tracing.TraceSender.Expression_False(10626, 70218, 70249) || sawLocalFunctions))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 70214, 70872);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 70291, 70853);

                        bodyWithoutLambdas = f_10626_70312_70852(loweredBody, f_10626_70402_70423(method), f_10626_70450_70470(method), method, methodOrdinal, null, lambdaDebugInfoBuilder, closureDebugInfoBuilder, lazyVariableSlotAllocator, compilationState, diagnostics, assignLocals: null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 70214, 70872);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 70892, 71011) || true) && (f_10626_70896_70924(bodyWithoutLambdas))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 70892, 71011);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 70966, 70992);

                        return bodyWithoutLambdas;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 70892, 71011);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 71031, 71263);

                    BoundStatement
                    bodyWithoutIterators = f_10626_71069_71262(bodyWithoutLambdas, method, methodOrdinal, lazyVariableSlotAllocator, compilationState, diagnostics, out iteratorStateMachine)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 71283, 71406) || true) && (f_10626_71287_71317(bodyWithoutIterators))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 71283, 71406);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 71359, 71387);

                        return bodyWithoutIterators;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 71283, 71406);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 71426, 71647);

                    BoundStatement
                    bodyWithoutAsync = f_10626_71460_71646(bodyWithoutIterators, method, methodOrdinal, lazyVariableSlotAllocator, compilationState, diagnostics, out asyncStateMachine)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 71667, 71755);

                    f_10626_71667_71754((object)iteratorStateMachine == null || (DynAbs.Tracing.TraceSender.Expression_False(10626, 71680, 71753) || (object)asyncStateMachine == null));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 71773, 71861);

                    stateMachineTypeOpt = (StateMachineTypeSymbol)iteratorStateMachine ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.StateMachineTypeSymbol?>(10626, 71795, 71860) ?? asyncStateMachine);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 71881, 71905);

                    return bodyWithoutAsync;
                }
                catch (BoundTreeVisitor.CancelledByStackGuardException ex)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(10626, 71934, 72184);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 72025, 72052);

                    f_10626_72025_72051(ex, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 72070, 72169);

                    return f_10626_72077_72168(body.Syntax, f_10626_72112_72150(body), hasErrors: true);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(10626, 71934, 72184);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10626, 66936, 72195);

                int
                f_10626_67709_67764(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 67709, 67764);
                    return 0;
                }


                bool
                f_10626_67826_67840(Microsoft.CodeAnalysis.CSharp.BoundStatement
                this_param)
                {
                    var return_v = this_param.HasErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 67826, 67840);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10626_68015_68042(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 68015, 68042);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10626_68130_68151(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 68130, 68151);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10626_67971_68823(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, int
                methodOrdinal, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                containingType, Microsoft.CodeAnalysis.CSharp.BoundStatement
                statement, Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                compilationState, Microsoft.CodeAnalysis.CSharp.SynthesizedSubmissionFields
                previousSubmissionFields, bool
                allowOmissionOfConditionalCalls, bool
                instrumentForDynamicAnalysis, Microsoft.CodeAnalysis.CodeGen.DebugDocumentProvider
                debugDocumentProvider, ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.SourceSpan>
                dynamicAnalysisSpans, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out bool
                sawLambdas, out bool
                sawLocalFunctions, out bool
                sawAwaitInExceptionHandler)
                {
                    var return_v = LocalRewriter.Rewrite(
                        compilation, 
                        method, 
                        methodOrdinal, 
                        containingType, 
                        statement, 
                        compilationState, 
                        previousSubmissionFields: previousSubmissionFields, 
                        allowOmissionOfConditionalCalls: allowOmissionOfConditionalCalls, 
                        instrumentForDynamicAnalysis: instrumentForDynamicAnalysis,
                        ref dynamicAnalysisSpans,
                        debugDocumentProvider, 
                        diagnostics: diagnostics, 
                        out sawLambdas, 
                        out sawLocalFunctions, 
                        out sawAwaitInExceptionHandler);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 67971, 68823);
                    return return_v;
                }


                bool
                f_10626_68848_68869(Microsoft.CodeAnalysis.CSharp.BoundStatement
                this_param)
                {
                    var return_v = this_param.HasErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 68848, 68869);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10626_69602_69623(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 69602, 69623);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10626_69505_69743(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                containingSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                containingType, Microsoft.CodeAnalysis.CSharp.BoundStatement
                statement, Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                compilationState, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = AsyncExceptionHandlerRewriter.Rewrite(containingSymbol, containingType, statement, compilationState, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 69505, 69743);
                    return return_v;
                }


                bool
                f_10626_69787_69808(Microsoft.CodeAnalysis.CSharp.BoundStatement
                this_param)
                {
                    var return_v = this_param.HasErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 69787, 69808);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.VariableSlotAllocator
                f_10626_70015_70108(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                topLevelMethod, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.TryCreateVariableSlotAllocator(method, topLevelMethod, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 70015, 70108);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10626_70402_70423(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 70402, 70423);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10626_70450_70470(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ThisParameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 70450, 70470);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10626_70312_70852(Microsoft.CodeAnalysis.CSharp.BoundStatement
                loweredBody, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                thisType, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                thisParameter, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, int
                methodOrdinal, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                substitutedSourceMethod, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.LambdaDebugInfo>
                lambdaDebugInfoBuilder, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.ClosureDebugInfo>
                closureDebugInfoBuilder, Microsoft.CodeAnalysis.CodeGen.VariableSlotAllocator
                slotAllocatorOpt, Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                compilationState, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                assignLocals)
                {
                    var return_v = ClosureConversion.Rewrite(loweredBody, thisType, thisParameter, method, methodOrdinal, substitutedSourceMethod, lambdaDebugInfoBuilder, closureDebugInfoBuilder, slotAllocatorOpt, compilationState, diagnostics, assignLocals: assignLocals);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 70312, 70852);
                    return return_v;
                }


                bool
                f_10626_70896_70924(Microsoft.CodeAnalysis.CSharp.BoundStatement
                this_param)
                {
                    var return_v = this_param.HasErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 70896, 70924);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10626_71069_71262(Microsoft.CodeAnalysis.CSharp.BoundStatement
                body, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, int
                methodOrdinal, Microsoft.CodeAnalysis.CodeGen.VariableSlotAllocator
                slotAllocatorOpt, Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                compilationState, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out Microsoft.CodeAnalysis.CSharp.IteratorStateMachine
                stateMachineType)
                {
                    var return_v = IteratorRewriter.Rewrite(body, method, methodOrdinal, slotAllocatorOpt, compilationState, diagnostics, out stateMachineType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 71069, 71262);
                    return return_v;
                }


                bool
                f_10626_71287_71317(Microsoft.CodeAnalysis.CSharp.BoundStatement
                this_param)
                {
                    var return_v = this_param.HasErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 71287, 71317);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10626_71460_71646(Microsoft.CodeAnalysis.CSharp.BoundStatement
                bodyWithAwaitLifted, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, int
                methodOrdinal, Microsoft.CodeAnalysis.CodeGen.VariableSlotAllocator
                slotAllocatorOpt, Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                compilationState, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out Microsoft.CodeAnalysis.CSharp.AsyncStateMachine
                stateMachineType)
                {
                    var return_v = AsyncRewriter.Rewrite(bodyWithAwaitLifted, method, methodOrdinal, slotAllocatorOpt, compilationState, diagnostics, out stateMachineType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 71460, 71646);
                    return return_v;
                }


                int
                f_10626_71667_71754(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 71667, 71754);
                    return 0;
                }


                int
                f_10626_72025_72051(Microsoft.CodeAnalysis.CSharp.BoundTreeVisitor.CancelledByStackGuardException
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.AddAnError(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 72025, 72051);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundNode>
                f_10626_72112_72150(Microsoft.CodeAnalysis.CSharp.BoundStatement
                item)
                {
                    var return_v = ImmutableArray.Create<BoundNode>((Microsoft.CodeAnalysis.CSharp.BoundNode)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 72112, 72150);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBadStatement
                f_10626_72077_72168(Microsoft.CodeAnalysis.SyntaxNode
                syntax, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundNode>
                childBoundNodes, bool
                hasErrors)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundBadStatement(syntax, childBoundNodes, hasErrors: hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 72077, 72168);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10626, 66936, 72195);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10626, 66936, 72195);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static MethodBody GenerateMethodBody(
                    PEModuleBuilder moduleBuilder,
                    MethodSymbol method,
                    int methodOrdinal,
                    BoundStatement block,
                    ImmutableArray<LambdaDebugInfo> lambdaDebugInfo,
                    ImmutableArray<ClosureDebugInfo> closureDebugInfo,
                    StateMachineTypeSymbol stateMachineTypeOpt,
                    VariableSlotAllocator variableSlotAllocatorOpt,
                    DiagnosticBag diagnostics,
                    DebugDocumentProvider debugDocumentProvider,
                    ImportChain importChainOpt,
                    bool emittingPdb,
                    bool emitTestCoverageData,
                    ImmutableArray<SourceSpan> dynamicAnalysisSpans,
                    SynthesizedEntryPointSymbol.AsyncForwardEntryPoint entryPointOpt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10626, 72386, 81540);
                int asyncCatchHandlerOffset = default(int);
                System.Collections.Immutable.ImmutableArray<int> asyncYieldPoints = default(System.Collections.Immutable.ImmutableArray<int>);
                System.Collections.Immutable.ImmutableArray<int> asyncResumePoints = default(System.Collections.Immutable.ImmutableArray<int>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 73321, 73463);

                f_10626_73321_73462(!f_10626_73335_73361(diagnostics), "Running code generator when errors exist might be dangerous; code generator not expecting errors");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 73479, 73523);

                var
                compilation = moduleBuilder.Compilation
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 73537, 73607);

                var
                localSlotManager = f_10626_73560_73606(variableSlotAllocatorOpt)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 73621, 73679);

                var
                optimizations = f_10626_73641_73678(f_10626_73641_73660(compilation))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 73695, 73801);

                ILBuilder
                builder = f_10626_73715_73800(moduleBuilder, localSlotManager, optimizations, f_10626_73777_73799(method))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 73815, 73834);

                bool
                hasStackalloc
                = default(bool);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 73848, 73917);

                DiagnosticBag
                diagnosticsForThisMethod = f_10626_73889_73916()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 73967, 74033);

                    StateMachineMoveNextBodyDebugInfo
                    moveNextBodyDebugInfoOpt = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 74053, 74186);

                    var
                    codeGen = f_10626_74067_74185(method, block, builder, moduleBuilder, diagnosticsForThisMethod, optimizations, emittingPdb)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 74206, 74417) || true) && (f_10626_74210_74249(diagnosticsForThisMethod))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 74206, 74417);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 74386, 74398);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 74206, 74417);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 74437, 74462);

                    bool
                    isAsyncStateMachine
                    = default(bool);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 74480, 74507);

                    MethodSymbol
                    kickoffMethod
                    = default(MethodSymbol);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 74527, 75386) || true) && (method is SynthesizedStateMachineMethod stateMachineMethod && (DynAbs.Tracing.TraceSender.Expression_True(10626, 74531, 74668) && f_10626_74614_74625(method) == WellKnownMemberNames.MoveNextMethodName))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 74527, 75386);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 74710, 74776);

                        kickoffMethod = f_10626_74726_74761(stateMachineMethod).KickoffMethod;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 74798, 74834);

                        f_10626_74798_74833(kickoffMethod != null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 74858, 74902);

                        isAsyncStateMachine = f_10626_74880_74901(kickoffMethod);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 75145, 75214);

                        kickoffMethod = f_10626_75161_75196(kickoffMethod) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>(10626, 75161, 75213) ?? kickoffMethod);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 74527, 75386);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 74527, 75386);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 75296, 75317);

                        kickoffMethod = null;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 75339, 75367);

                        isAsyncStateMachine = false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 74527, 75386);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 75406, 77385) || true) && (isAsyncStateMachine)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 75406, 77385);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 75471, 75593);

                        f_10626_75471_75592(codeGen, out asyncCatchHandlerOffset, out asyncYieldPoints, out asyncResumePoints, out hasStackalloc);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 76575, 76672);

                        bool
                        isAsyncMainMoveNext = entryPointOpt != null && (DynAbs.Tracing.TraceSender.Expression_True(10626, 76602, 76671) && f_10626_76627_76671(entryPointOpt.UserMain, kickoffMethod))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 76696, 77026);

                        moveNextBodyDebugInfoOpt = f_10626_76723_77025(f_10626_76780_76809(kickoffMethod), catchHandlerOffset: (DynAbs.Tracing.TraceSender.Conditional_F1(10626, 76856, 76906) || (((f_10626_76857_76882(kickoffMethod) || (DynAbs.Tracing.TraceSender.Expression_False(10626, 76857, 76905) || isAsyncMainMoveNext)) && DynAbs.Tracing.TraceSender.Conditional_F2(10626, 76909, 76932)) || DynAbs.Tracing.TraceSender.Conditional_F3(10626, 76935, 76937))) ? asyncCatchHandlerOffset : -1, asyncYieldPoints, asyncResumePoints);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 75406, 77385);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 75406, 77385);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 77108, 77144);

                        f_10626_77108_77143(codeGen, out hasStackalloc);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 77168, 77366) || true) && ((object)kickoffMethod != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 77168, 77366);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 77251, 77343);

                            moveNextBodyDebugInfoOpt = f_10626_77278_77342(f_10626_77312_77341(kickoffMethod));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 77168, 77366);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 75406, 77385);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 77553, 77734);

                    var
                    stateMachineHoistedLocalScopes = (DynAbs.Tracing.TraceSender.Conditional_F1(10626, 77590, 77621) || ((((object)kickoffMethod != null) && DynAbs.Tracing.TraceSender.Conditional_F2(10626, 77645, 77676)) || DynAbs.Tracing.TraceSender.Conditional_F3(10626, 77679, 77733))) ? f_10626_77645_77676(builder) : default(ImmutableArray<StateMachineHoistedLocalScope>)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 78135, 78223);

                    var
                    importScopeOpt = f_10626_78156_78222_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(importChainOpt, 10626, 78156, 78222)?.Translate(moduleBuilder, diagnosticsForThisMethod))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 78243, 78305);

                    var
                    localVariables = f_10626_78264_78304(builder.LocalSlotManager)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 78325, 78504) || true) && (localVariables.Length > 0xFFFE)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 78325, 78504);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 78401, 78485);

                        f_10626_78401_78484(diagnosticsForThisMethod, ErrorCode.ERR_TooManyLocals, method.Locations.First());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 78325, 78504);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 78524, 78735) || true) && (f_10626_78528_78567(diagnosticsForThisMethod))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 78524, 78735);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 78704, 78716);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 78524, 78735);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 78829, 78983) || true) && (f_10626_78833_78859(moduleBuilder))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 78829, 78983);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 78901, 78964);

                        f_10626_78901_78963(moduleBuilder, method, f_10626_78941_78962(builder));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 78829, 78983);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 79003, 79084);

                    var
                    stateMachineHoistedLocalSlots = default(ImmutableArray<EncHoistedLocalInfo>)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 79102, 79177);

                    var
                    stateMachineAwaiterSlots = default(ImmutableArray<Cci.ITypeReference>)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 79195, 79693) || true) && (optimizations == OptimizationLevel.Debug && (DynAbs.Tracing.TraceSender.Expression_True(10626, 79199, 79278) && (object)stateMachineTypeOpt != null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 79195, 79693);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 79320, 79370);

                        f_10626_79320_79369(f_10626_79333_79347(method) || (DynAbs.Tracing.TraceSender.Expression_False(10626, 79333, 79368) || f_10626_79351_79368(method)));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 79392, 79610);

                        f_10626_79392_79609(moduleBuilder, f_10626_79436_79491(moduleBuilder, stateMachineTypeOpt), variableSlotAllocatorOpt, diagnosticsForThisMethod, out stateMachineHoistedLocalSlots, out stateMachineAwaiterSlots);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 79632, 79674);

                        f_10626_79632_79673(!f_10626_79646_79672(diagnostics));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 79195, 79693);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 79713, 79773);

                    DynamicAnalysisMethodBodyData
                    dynamicAnalysisDataOpt = null
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 79791, 80023) || true) && (emitTestCoverageData)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 79791, 80023);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 79857, 79901);

                        f_10626_79857_79900(debugDocumentProvider != null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 79923, 80004);

                        dynamicAnalysisDataOpt = f_10626_79948_80003(dynamicAnalysisSpans);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 79791, 80023);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 80043, 81121);

                    return f_10626_80050_81120(builder.RealizedIL, f_10626_80128_80144(builder), f_10626_80167_80223((f_10626_80168_80196(method) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>(10626, 80168, 80206) ?? method))), f_10626_80246_80280_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(variableSlotAllocatorOpt, 10626, 80246, 80280)?.MethodId) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CodeGen.DebugId?>(10626, 80246, 80350) ?? f_10626_80284_80350(methodOrdinal, f_10626_80311_80349(moduleBuilder))), localVariables, builder.RealizedSequencePoints, debugDocumentProvider, builder.RealizedExceptionHandlers, f_10626_80563_80586(builder), hasStackalloc, f_10626_80645_80667(builder), f_10626_80690_80713(builder), importScopeOpt, lambdaDebugInfo, closureDebugInfo, f_10626_80850_80875_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(stateMachineTypeOpt, 10626, 80850, 80875)?.Name), stateMachineHoistedLocalScopes, stateMachineHoistedLocalSlots, stateMachineAwaiterSlots, moveNextBodyDebugInfoOpt, dynamicAnalysisDataOpt);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(10626, 81150, 81529);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 81329, 81355);

                    f_10626_81329_81354(                // Basic blocks contain poolable builders for IL and sequence points. Free those back
                                                        // to their pools.
                                    builder);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 81417, 81464);

                    f_10626_81417_81463(
                                    // Remember diagnostics.
                                    diagnostics, diagnosticsForThisMethod);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 81482, 81514);

                    f_10626_81482_81513(diagnosticsForThisMethod);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(10626, 81150, 81529);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10626, 72386, 81540);

                bool
                f_10626_73335_73361(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.HasAnyErrors();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 73335, 73361);
                    return return_v;
                }


                int
                f_10626_73321_73462(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 73321, 73462);
                    return 0;
                }


                Microsoft.CodeAnalysis.CodeGen.LocalSlotManager
                f_10626_73560_73606(Microsoft.CodeAnalysis.CodeGen.VariableSlotAllocator
                slotAllocator)
                {
                    var return_v = new Microsoft.CodeAnalysis.CodeGen.LocalSlotManager(slotAllocator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 73560, 73606);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_10626_73641_73660(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 73641, 73660);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OptimizationLevel
                f_10626_73641_73678(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.OptimizationLevel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 73641, 73678);
                    return return_v;
                }


                bool
                f_10626_73777_73799(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.AreLocalsZeroed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 73777, 73799);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.ILBuilder
                f_10626_73715_73800(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                module, Microsoft.CodeAnalysis.CodeGen.LocalSlotManager
                localSlotManager, Microsoft.CodeAnalysis.OptimizationLevel
                optimizations, bool
                areLocalsZeroed)
                {
                    var return_v = new Microsoft.CodeAnalysis.CodeGen.ILBuilder((Microsoft.CodeAnalysis.CodeGen.ITokenDeferral)module, localSlotManager, optimizations, areLocalsZeroed);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 73715, 73800);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10626_73889_73916()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 73889, 73916);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                f_10626_74067_74185(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.CSharp.BoundStatement
                boundBody, Microsoft.CodeAnalysis.CodeGen.ILBuilder
                builder, Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                moduleBuilder, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.OptimizationLevel
                optimizations, bool
                emittingPdb)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator(method, boundBody, builder, moduleBuilder, diagnostics, optimizations, emittingPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 74067, 74185);
                    return return_v;
                }


                bool
                f_10626_74210_74249(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.HasAnyErrors();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 74210, 74249);
                    return return_v;
                }


                string
                f_10626_74614_74625(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 74614, 74625);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.StateMachineTypeSymbol
                f_10626_74726_74761(Microsoft.CodeAnalysis.CSharp.SynthesizedStateMachineMethod
                this_param)
                {
                    var return_v = this_param.StateMachineType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 74726, 74761);
                    return return_v;
                }


                int
                f_10626_74798_74833(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 74798, 74833);
                    return 0;
                }


                bool
                f_10626_74880_74901(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsAsync;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 74880, 74901);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10626_75161_75196(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.PartialDefinitionPart;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 75161, 75196);
                    return return_v;
                }


                int
                f_10626_75471_75592(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, out int
                asyncCatchHandlerOffset, out System.Collections.Immutable.ImmutableArray<int>
                asyncYieldPoints, out System.Collections.Immutable.ImmutableArray<int>
                asyncResumePoints, out bool
                hasStackAlloc)
                {
                    this_param.Generate(out asyncCatchHandlerOffset, out asyncYieldPoints, out asyncResumePoints, out hasStackAlloc);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 75471, 75592);
                    return 0;
                }


                bool
                f_10626_76627_76671(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                obj)
                {
                    var return_v = this_param.Equals((object?)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 76627, 76671);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                f_10626_76780_76809(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                this_param)
                {
                    var return_v = this_param.GetCciAdapter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 76780, 76809);
                    return return_v;
                }


                bool
                f_10626_76857_76882(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnsVoid;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 76857, 76882);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.AsyncMoveNextBodyDebugInfo
                f_10626_76723_77025(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                kickoffMethod, int
                catchHandlerOffset, System.Collections.Immutable.ImmutableArray<int>
                yieldOffsets, System.Collections.Immutable.ImmutableArray<int>
                resumeOffsets)
                {
                    var return_v = new Microsoft.CodeAnalysis.Emit.AsyncMoveNextBodyDebugInfo((Microsoft.Cci.IMethodDefinition)kickoffMethod, catchHandlerOffset: catchHandlerOffset, yieldOffsets, resumeOffsets);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 76723, 77025);
                    return return_v;
                }


                int
                f_10626_77108_77143(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, out bool
                hasStackalloc)
                {
                    this_param.Generate(out hasStackalloc);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 77108, 77143);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                f_10626_77312_77341(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.GetCciAdapter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 77312, 77341);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.IteratorMoveNextBodyDebugInfo
                f_10626_77278_77342(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                kickoffMethod)
                {
                    var return_v = new Microsoft.CodeAnalysis.Emit.IteratorMoveNextBodyDebugInfo((Microsoft.Cci.IMethodDefinition)kickoffMethod);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 77278, 77342);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Debugging.StateMachineHoistedLocalScope>
                f_10626_77645_77676(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    var return_v = this_param.GetHoistedLocalScopes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 77645, 77676);
                    return return_v;
                }


                Microsoft.Cci.IImportScope?
                f_10626_78156_78222_I(Microsoft.Cci.IImportScope?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 78156, 78222);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ILocalDefinition>
                f_10626_78264_78304(Microsoft.CodeAnalysis.CodeGen.LocalSlotManager
                this_param)
                {
                    var return_v = this_param.LocalsInOrder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 78264, 78304);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10626_78401_78484(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 78401, 78484);
                    return return_v;
                }


                bool
                f_10626_78528_78567(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.HasAnyErrors();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 78528, 78567);
                    return return_v;
                }


                bool
                f_10626_78833_78859(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param)
                {
                    var return_v = this_param.SaveTestData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 78833, 78859);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.ILBuilder
                f_10626_78941_78962(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    var return_v = this_param.GetSnapshot();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 78941, 78962);
                    return return_v;
                }


                int
                f_10626_78901_78963(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.CodeGen.ILBuilder
                builder)
                {
                    this_param.SetMethodTestData((Microsoft.CodeAnalysis.Symbols.IMethodSymbolInternal)method, builder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 78901, 78963);
                    return 0;
                }


                bool
                f_10626_79333_79347(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsAsync;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 79333, 79347);
                    return return_v;
                }


                bool
                f_10626_79351_79368(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsIterator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 79351, 79368);
                    return return_v;
                }


                int
                f_10626_79320_79369(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 79320, 79369);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.IFieldDefinition>
                f_10626_79436_79491(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.StateMachineTypeSymbol
                container)
                {
                    var return_v = this_param.GetSynthesizedFields((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)container);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 79436, 79491);
                    return return_v;
                }


                int
                f_10626_79392_79609(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                moduleBuilder, System.Collections.Generic.IEnumerable<Microsoft.Cci.IFieldDefinition>
                fieldDefs, Microsoft.CodeAnalysis.CodeGen.VariableSlotAllocator
                variableSlotAllocatorOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.EncHoistedLocalInfo>
                hoistedVariableSlots, out System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ITypeReference>
                awaiterSlots)
                {
                    GetStateMachineSlotDebugInfo(moduleBuilder, fieldDefs, variableSlotAllocatorOpt, diagnostics, out hoistedVariableSlots, out awaiterSlots);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 79392, 79609);
                    return 0;
                }


                bool
                f_10626_79646_79672(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.HasAnyErrors();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 79646, 79672);
                    return return_v;
                }


                int
                f_10626_79632_79673(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 79632, 79673);
                    return 0;
                }


                int
                f_10626_79857_79900(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 79857, 79900);
                    return 0;
                }


                Microsoft.CodeAnalysis.CodeGen.DynamicAnalysisMethodBodyData
                f_10626_79948_80003(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.SourceSpan>
                spans)
                {
                    var return_v = new Microsoft.CodeAnalysis.CodeGen.DynamicAnalysisMethodBodyData(spans);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 79948, 80003);
                    return return_v;
                }


                ushort
                f_10626_80128_80144(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    var return_v = this_param.MaxStack;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 80128, 80144);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10626_80168_80196(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.PartialDefinitionPart;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 80168, 80196);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                f_10626_80167_80223(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.GetCciAdapter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 80167, 80223);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.DebugId?
                f_10626_80246_80280_M(Microsoft.CodeAnalysis.CodeGen.DebugId?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 80246, 80280);
                    return return_v;
                }


                int
                f_10626_80311_80349(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param)
                {
                    var return_v = this_param.CurrentGenerationOrdinal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 80311, 80349);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.DebugId
                f_10626_80284_80350(int
                ordinal, int
                generation)
                {
                    var return_v = new Microsoft.CodeAnalysis.CodeGen.DebugId(ordinal, generation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 80284, 80350);
                    return return_v;
                }


                bool
                f_10626_80563_80586(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    var return_v = this_param.AreLocalsZeroed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 80563, 80586);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.LocalScope>
                f_10626_80645_80667(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    var return_v = this_param.GetAllScopes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 80645, 80667);
                    return return_v;
                }


                bool
                f_10626_80690_80713(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    var return_v = this_param.HasDynamicLocal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 80690, 80713);
                    return return_v;
                }


                string?
                f_10626_80850_80875_M(string?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 80850, 80875);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.MethodBody
                f_10626_80050_81120(System.Collections.Immutable.ImmutableArray<byte>
                ilBits, ushort
                maxStack, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                parent, Microsoft.CodeAnalysis.CodeGen.DebugId
                methodId, System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ILocalDefinition>
                locals, Microsoft.CodeAnalysis.CodeGen.SequencePointList
                sequencePoints, Microsoft.CodeAnalysis.CodeGen.DebugDocumentProvider
                debugDocumentProvider, System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ExceptionHandlerRegion>
                exceptionHandlers, bool
                areLocalsZeroed, bool
                hasStackalloc, System.Collections.Immutable.ImmutableArray<Microsoft.Cci.LocalScope>
                localScopes, bool
                hasDynamicLocalVariables, Microsoft.Cci.IImportScope?
                importScopeOpt, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.LambdaDebugInfo>
                lambdaDebugInfo, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.ClosureDebugInfo>
                closureDebugInfo, string?
                stateMachineTypeNameOpt, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Debugging.StateMachineHoistedLocalScope>
                stateMachineHoistedLocalScopes, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.EncHoistedLocalInfo>
                stateMachineHoistedLocalSlots, System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ITypeReference>
                stateMachineAwaiterSlots, Microsoft.CodeAnalysis.Emit.StateMachineMoveNextBodyDebugInfo?
                stateMachineMoveNextDebugInfoOpt, Microsoft.CodeAnalysis.CodeGen.DynamicAnalysisMethodBodyData?
                dynamicAnalysisDataOpt)
                {
                    var return_v = new Microsoft.CodeAnalysis.CodeGen.MethodBody(ilBits, maxStack, (Microsoft.Cci.IMethodDefinition)parent, methodId, locals, sequencePoints, debugDocumentProvider, exceptionHandlers, areLocalsZeroed, hasStackalloc, localScopes, hasDynamicLocalVariables, importScopeOpt, lambdaDebugInfo, closureDebugInfo, stateMachineTypeNameOpt, stateMachineHoistedLocalScopes, stateMachineHoistedLocalSlots, stateMachineAwaiterSlots, stateMachineMoveNextDebugInfoOpt, dynamicAnalysisDataOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 80050, 81120);
                    return return_v;
                }


                int
                f_10626_81329_81354(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    this_param.FreeBasicBlocks();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 81329, 81354);
                    return 0;
                }


                int
                f_10626_81417_81463(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                bag)
                {
                    this_param.AddRange(bag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 81417, 81463);
                    return 0;
                }


                int
                f_10626_81482_81513(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 81482, 81513);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10626, 72386, 81540);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10626, 72386, 81540);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void GetStateMachineSlotDebugInfo(
                    PEModuleBuilder moduleBuilder,
                    IEnumerable<Cci.IFieldDefinition> fieldDefs,
                    VariableSlotAllocator variableSlotAllocatorOpt,
                    DiagnosticBag diagnostics,
                    out ImmutableArray<EncHoistedLocalInfo> hoistedVariableSlots,
                    out ImmutableArray<Cci.ITypeReference> awaiterSlots)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10626, 81552, 84360);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 81970, 82041);

                var
                hoistedVariables = f_10626_81993_82040()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 82055, 82117);

                var
                awaiters = f_10626_82070_82116()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 82133, 83484);
                    foreach (StateMachineFieldSymbol field in f_10626_82197_82296_I(f_10626_82197_82296(fieldDefs
                    , f => ((FieldSymbolAdapter)f).AdaptedFieldSymbol)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 82133, 83484);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 82361, 82389);

                        int
                        index = field.SlotIndex
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 82409, 83469) || true) && (field.SlotDebugInfo.SynthesizedKind == SynthesizedLocalKind.AwaiterField)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 82409, 83469);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 82527, 82552);

                            f_10626_82527_82551(index >= 0);
                            try
                            {
                                while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 82576, 82698) || true) && (index >= f_10626_82592_82606(awaiters))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 82576, 82698);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 82656, 82675);

                                    f_10626_82656_82674(awaiters, null);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 82576, 82698);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10626, 82576, 82698);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10626, 82576, 82698);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 82722, 82809);

                            awaiters[index] = f_10626_82740_82808(moduleBuilder, f_10626_82784_82794(field), diagnostics);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 82409, 83469);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 82409, 83469);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 82851, 83469) || true) && (f_10626_82855_82885_M(!field.SlotDebugInfo.Id.IsNone))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 82851, 83469);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 82927, 83005);

                                f_10626_82927_83004(index >= 0 && (DynAbs.Tracing.TraceSender.Expression_True(10626, 82940, 83003) && f_10626_82954_83003(field.SlotDebugInfo.SynthesizedKind)));
                                try
                                {
                                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 83029, 83285) || true) && (index >= f_10626_83045_83067(hoistedVariables))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 83029, 83285);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 83210, 83262);

                                        f_10626_83210_83261(                        // Empty slots may be present if variables were deleted during EnC.
                                                                hoistedVariables, f_10626_83231_83260(true));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 83029, 83285);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10626, 83029, 83285);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(10626, 83029, 83285);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 83309, 83450);

                                hoistedVariables[index] = f_10626_83335_83449(field.SlotDebugInfo, f_10626_83380_83448(moduleBuilder, f_10626_83424_83434(field), diagnostics));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 82851, 83469);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 82409, 83469);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 82133, 83484);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10626, 1, 1352);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10626, 1, 1352);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 83616, 84213) || true) && (variableSlotAllocatorOpt != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 83616, 84213);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 83686, 83763);

                    int
                    previousAwaiterCount = f_10626_83713_83762(variableSlotAllocatorOpt)
                    ;
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 83781, 83905) || true) && (f_10626_83788_83802(awaiters) < previousAwaiterCount)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 83781, 83905);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 83867, 83886);

                            f_10626_83867_83885(awaiters, null);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 83781, 83905);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10626, 83781, 83905);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10626, 83781, 83905);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 83925, 84011);

                    int
                    previousAwaiterSlotCount = f_10626_83956_84010(variableSlotAllocatorOpt)
                    ;
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 84029, 84198) || true) && (f_10626_84036_84058(hoistedVariables) < previousAwaiterSlotCount)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 84029, 84198);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 84127, 84179);

                            f_10626_84127_84178(hoistedVariables, f_10626_84148_84177(true));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 84029, 84198);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10626, 84029, 84198);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10626, 84029, 84198);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 83616, 84213);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 84229, 84290);

                hoistedVariableSlots = f_10626_84252_84289(hoistedVariables);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 84304, 84349);

                awaiterSlots = f_10626_84319_84348(awaiters);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10626, 81552, 84360);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Emit.EncHoistedLocalInfo>
                f_10626_81993_82040()
                {
                    var return_v = ArrayBuilder<EncHoistedLocalInfo>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 81993, 82040);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.ITypeReference>
                f_10626_82070_82116()
                {
                    var return_v = ArrayBuilder<Cci.ITypeReference>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 82070, 82116);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                f_10626_82197_82296(System.Collections.Generic.IEnumerable<Microsoft.Cci.IFieldDefinition>
                source, System.Func<Microsoft.Cci.IFieldDefinition, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                selector)
                {
                    var return_v = source.Select<Microsoft.Cci.IFieldDefinition, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 82197, 82296);
                    return return_v;
                }


                int
                f_10626_82527_82551(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 82527, 82551);
                    return 0;
                }


                int
                f_10626_82592_82606(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.ITypeReference>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 82592, 82606);
                    return return_v;
                }


                int
                f_10626_82656_82674(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.ITypeReference>
                this_param, Microsoft.Cci.ITypeReference
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 82656, 82674);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10626_82784_82794(Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 82784, 82794);
                    return return_v;
                }


                Microsoft.Cci.ITypeReference
                f_10626_82740_82808(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.EncTranslateLocalVariableType(type, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 82740, 82808);
                    return return_v;
                }


                bool
                f_10626_82855_82885_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 82855, 82885);
                    return return_v;
                }


                bool
                f_10626_82954_83003(Microsoft.CodeAnalysis.SynthesizedLocalKind
                kind)
                {
                    var return_v = kind.IsLongLived();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 82954, 83003);
                    return return_v;
                }


                int
                f_10626_82927_83004(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 82927, 83004);
                    return 0;
                }


                int
                f_10626_83045_83067(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Emit.EncHoistedLocalInfo>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 83045, 83067);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.EncHoistedLocalInfo
                f_10626_83231_83260(bool
                ignored)
                {
                    var return_v = new Microsoft.CodeAnalysis.Emit.EncHoistedLocalInfo(ignored);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 83231, 83260);
                    return return_v;
                }


                int
                f_10626_83210_83261(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Emit.EncHoistedLocalInfo>
                this_param, Microsoft.CodeAnalysis.Emit.EncHoistedLocalInfo
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 83210, 83261);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10626_83424_83434(Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 83424, 83434);
                    return return_v;
                }


                Microsoft.Cci.ITypeReference
                f_10626_83380_83448(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.EncTranslateLocalVariableType(type, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 83380, 83448);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.EncHoistedLocalInfo
                f_10626_83335_83449(Microsoft.CodeAnalysis.CodeGen.LocalSlotDebugInfo
                slotInfo, Microsoft.Cci.ITypeReference
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.Emit.EncHoistedLocalInfo(slotInfo, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 83335, 83449);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                f_10626_82197_82296_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 82197, 82296);
                    return return_v;
                }


                int
                f_10626_83713_83762(Microsoft.CodeAnalysis.CodeGen.VariableSlotAllocator
                this_param)
                {
                    var return_v = this_param.PreviousAwaiterSlotCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 83713, 83762);
                    return return_v;
                }


                int
                f_10626_83788_83802(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.ITypeReference>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 83788, 83802);
                    return return_v;
                }


                int
                f_10626_83867_83885(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.ITypeReference>
                this_param, Microsoft.Cci.ITypeReference
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 83867, 83885);
                    return 0;
                }


                int
                f_10626_83956_84010(Microsoft.CodeAnalysis.CodeGen.VariableSlotAllocator
                this_param)
                {
                    var return_v = this_param.PreviousHoistedLocalSlotCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 83956, 84010);
                    return return_v;
                }


                int
                f_10626_84036_84058(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Emit.EncHoistedLocalInfo>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 84036, 84058);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.EncHoistedLocalInfo
                f_10626_84148_84177(bool
                ignored)
                {
                    var return_v = new Microsoft.CodeAnalysis.Emit.EncHoistedLocalInfo(ignored);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 84148, 84177);
                    return return_v;
                }


                int
                f_10626_84127_84178(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Emit.EncHoistedLocalInfo>
                this_param, Microsoft.CodeAnalysis.Emit.EncHoistedLocalInfo
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 84127, 84178);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.EncHoistedLocalInfo>
                f_10626_84252_84289(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Emit.EncHoistedLocalInfo>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 84252, 84289);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ITypeReference>
                f_10626_84319_84348(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.ITypeReference>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 84319, 84348);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10626, 81552, 84360);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10626, 81552, 84360);
            }
        }

        internal static BoundBlock BindMethodBody(MethodSymbol method, TypeCompilationState compilationState, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10626, 84433, 84707);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 84586, 84696);

                return f_10626_84593_84695(method, compilationState, diagnostics, nullableInitialState: null, out _, out _, out _);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10626, 84433, 84707);

                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10626_84593_84695(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                compilationState, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.NullableWalker.VariableState
                nullableInitialState, out Microsoft.CodeAnalysis.CSharp.ImportChain
                importChain, out bool
                originalBodyNested, out Microsoft.CodeAnalysis.CSharp.MethodBodySemanticModel.InitialState
                forSemanticModel)
                {
                    var return_v = BindMethodBody(method, compilationState, diagnostics, nullableInitialState: nullableInitialState, out importChain, out originalBodyNested, out forSemanticModel);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 84593, 84695);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10626, 84433, 84707);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10626, 84433, 84707);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static BoundBlock BindMethodBody(MethodSymbol method, TypeCompilationState compilationState, DiagnosticBag diagnostics,
                                                         NullableWalker.VariableState nullableInitialState,
                                                         out ImportChain importChain, out bool originalBodyNested,
                                                         out MethodBodySemanticModel.InitialState forSemanticModel)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10626, 84780, 93532);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 85250, 85277);

                originalBodyNested = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 85291, 85310);

                importChain = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 85324, 85351);

                forSemanticModel = default;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 85367, 85383);

                BoundBlock
                body
                = default(BoundBlock);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 85399, 91913) || true) && (method is SourceMemberMethodSymbol sourceMethod)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 85399, 91913);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 85484, 85538);

                    CSharpSyntaxNode
                    syntaxNode = f_10626_85514_85537(sourceMethod)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 85627, 86143) || true) && (f_10626_85631_85648(method) == MethodKind.StaticConstructor && (DynAbs.Tracing.TraceSender.Expression_True(10626, 85631, 85765) && syntaxNode is ConstructorDeclarationSyntax constructorSyntax) && (DynAbs.Tracing.TraceSender.Expression_True(10626, 85631, 85827) && f_10626_85790_85819(constructorSyntax) != null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 85627, 86143);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 85869, 86124);

                        f_10626_85869_86123(diagnostics, ErrorCode.ERR_StaticConstructorWithExplicitConstructorCall, f_10626_85996_86025(constructorSyntax).ThisOrBaseKeyword.GetLocation(), constructorSyntax.Identifier.ValueText);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 85627, 86143);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 86163, 86229);

                    ExecutableCodeBinder
                    bodyBinder = f_10626_86197_86228(sourceMethod)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 86249, 86395) || true) && (f_10626_86253_86274(sourceMethod) || (DynAbs.Tracing.TraceSender.Expression_False(10626, 86253, 86322) || f_10626_86278_86322(sourceMethod)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 86249, 86395);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 86364, 86376);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 86249, 86395);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 86415, 91132) || true) && (bodyBinder != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 86415, 91132);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 86479, 86516);

                        importChain = f_10626_86493_86515(bodyBinder);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 86540, 86614);

                        BoundNode
                        methodBody = f_10626_86563_86613(bodyBinder, syntaxNode, diagnostics)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 86636, 86686);

                        BoundNode
                        methodBodyForSemanticModel = methodBody
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 86708, 86762);

                        NullableWalker.SnapshotManager
                        snapshotManager = null
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 86784, 86843);

                        ImmutableDictionary<Symbol, Symbol>
                        remappedSymbols = null
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 86865, 86906);

                        var
                        compilation = f_10626_86883_86905(bodyBinder)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 86928, 87051);

                        var
                        isSufficientLangVersion = f_10626_86958_86985(compilation) >= f_10626_86989_87050(MessageID.IDS_FeatureNullableReferenceTypes)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 87073, 88467) || true) && (f_10626_87077_87124(compilation, method))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 87073, 88467);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 87174, 87923);

                            methodBodyForSemanticModel = f_10626_87203_87922(compilation, method, methodBody, bodyBinder, nullableInitialState, (DynAbs.Tracing.TraceSender.Conditional_F1(10626, 87710, 87733) || ((                            // if language version is insufficient, we do not want to surface nullability diagnostics,
                                                                                                                                                                                                                                                 // but we should still provide nullability information through the semantic model.
                                                        isSufficientLangVersion && DynAbs.Tracing.TraceSender.Conditional_F2(10626, 87736, 87747)) || DynAbs.Tracing.TraceSender.Conditional_F3(10626, 87750, 87769))) ? diagnostics : f_10626_87750_87769(), createSnapshots: true, out snapshotManager, ref remappedSymbols);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 87073, 88467);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 87073, 88467);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 88021, 88444);

                            f_10626_88021_88443(compilation, method, methodBody, diagnostics, useConstructorExitWarnings: true, nullableInitialState, getFinalNullableState: false, finalNullableState: out _);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 87073, 88467);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 88491, 88637);

                        forSemanticModel = f_10626_88510_88636(syntaxNode, methodBodyForSemanticModel, bodyBinder, snapshotManager, remappedSymbols);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 88661, 90680);

                        switch (f_10626_88669_88684(methodBody))
                        {

                            case BoundKind.ConstructorMethodBody:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 88661, 90680);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 88801, 88858);

                                var
                                constructor = (BoundConstructorMethodBody)methodBody
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 88888, 88947);

                                body = f_10626_88895_88916(constructor) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.BoundBlock?>(10626, 88895, 88946) ?? f_10626_88920_88946(constructor));

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 88979, 90062) || true) && (f_10626_88983_89006(constructor) != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 88979, 90062);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 89080, 89183);

                                    f_10626_89080_89182(method, f_10626_89116_89150(f_10626_89116_89139(constructor)), compilationState, diagnostics);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 89219, 89812) || true) && (body == null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 89219, 89812);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 89309, 89435);

                                        body = f_10626_89316_89434(constructor.Syntax, f_10626_89351_89369(constructor), f_10626_89371_89433(f_10626_89409_89432(constructor)));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 89219, 89812);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 89219, 89812);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 89581, 89713);

                                        body = f_10626_89588_89712(constructor.Syntax, f_10626_89623_89641(constructor), f_10626_89643_89711(f_10626_89681_89704(constructor), body));
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 89751, 89777);

                                        originalBodyNested = true;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 89219, 89812);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 89848, 89860);

                                    return body;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 88979, 90062);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 88979, 90062);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 89990, 90031);

                                    f_10626_89990_90030(constructor.Locals.IsEmpty);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 88979, 90062);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(10626, 90092, 90098);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 88661, 90680);

                            case BoundKind.NonConstructorMethodBody:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 88661, 90680);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 90196, 90259);

                                var
                                nonConstructor = (BoundNonConstructorMethodBody)methodBody
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 90289, 90354);

                                body = f_10626_90296_90320(nonConstructor) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.BoundBlock?>(10626, 90296, 90353) ?? f_10626_90324_90353(nonConstructor));
                                DynAbs.Tracing.TraceSender.TraceBreak(10626, 90384, 90390);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 88661, 90680);

                            case BoundKind.Block:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 88661, 90680);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 90469, 90499);

                                body = (BoundBlock)methodBody;
                                DynAbs.Tracing.TraceSender.TraceBreak(10626, 90529, 90535);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 88661, 90680);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 88661, 90680);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 90599, 90657);

                                throw f_10626_90605_90656(f_10626_90640_90655(methodBody));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 88661, 90680);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 86415, 91132);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 86415, 91132);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 90762, 90835);

                        var
                        property = f_10626_90777_90806(sourceMethod) as SourcePropertySymbolBase
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 90857, 91077) || true) && ((object)property != null && (DynAbs.Tracing.TraceSender.Expression_True(10626, 90861, 90927) && f_10626_90889_90927(property)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 90857, 91077);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 90977, 91054);

                            return f_10626_90984_91053(sourceMethod);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 90857, 91077);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 91101, 91113);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 86415, 91132);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 85399, 91913);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 85399, 91913);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 91166, 91913) || true) && (method is SynthesizedInstanceConstructor ctor)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 91166, 91913);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 91359, 91398);

                        var
                        node = f_10626_91370_91397(ctor)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 91416, 91503);

                        var
                        factory = f_10626_91430_91502(ctor, node, compilationState, diagnostics)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 91521, 91576);

                        var
                        stmts = f_10626_91533_91575()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 91594, 91657);

                        f_10626_91594_91656(ctor, factory, stmts, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 91675, 91747);

                        body = f_10626_91682_91746(node, f_10626_91719_91745(stmts));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 91166, 91913);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 91166, 91913);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 91886, 91898);

                        body = null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 91166, 91913);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 85399, 91913);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 91929, 92474) || true) && (f_10626_91933_91955(method) && (DynAbs.Tracing.TraceSender.Expression_True(10626, 91933, 91986) && f_10626_91959_91986(method)) && (DynAbs.Tracing.TraceSender.Expression_True(10626, 91933, 92020) && nullableInitialState is object))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 91929, 92474);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 92054, 92459);

                    f_10626_92054_92458(compilationState.Compilation, method, body ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.BoundBlock?>(10626, 92187, 92226) ?? f_10626_92195_92226(method)), diagnostics, useConstructorExitWarnings: true, nullableInitialState, getFinalNullableState: false, finalNullableState: out _);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 91929, 92474);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 92490, 92668) || true) && (f_10626_92494_92511(method) == MethodKind.Destructor && (DynAbs.Tracing.TraceSender.Expression_True(10626, 92494, 92552) && body != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 92490, 92668);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 92586, 92653);

                    return f_10626_92593_92652(method, body);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 92490, 92668);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 92684, 92792);

                var
                constructorInitializer = f_10626_92713_92791(method, compilationState, diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 92806, 92848);

                ImmutableArray<BoundStatement>
                statements
                = default(ImmutableArray<BoundStatement>);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 92864, 93424) || true) && (constructorInitializer == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 92864, 93424);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 92932, 93021) || true) && (body != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 92932, 93021);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 92990, 93002);

                        return body;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 92932, 93021);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 93041, 93091);

                    statements = ImmutableArray<BoundStatement>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 92864, 93424);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 92864, 93424);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 93125, 93424) || true) && (body == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 93125, 93424);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 93175, 93234);

                        statements = f_10626_93188_93233(constructorInitializer);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 93125, 93424);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 93125, 93424);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 93300, 93365);

                        statements = f_10626_93313_93364(constructorInitializer, body);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 93383, 93409);

                        originalBodyNested = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 93125, 93424);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 92864, 93424);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 93440, 93521);

                return f_10626_93447_93520(f_10626_93478_93507(method), statements);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10626, 84780, 93532);

                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10626_85514_85537(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol
                this_param)
                {
                    var return_v = this_param.SyntaxNode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 85514, 85537);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10626_85631_85648(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 85631, 85648);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorInitializerSyntax?
                f_10626_85790_85819(Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Initializer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 85790, 85819);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorInitializerSyntax
                f_10626_85996_86025(Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Initializer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 85996, 86025);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10626_85869_86123(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 85869, 86123);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ExecutableCodeBinder
                f_10626_86197_86228(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol
                this_param)
                {
                    var return_v = this_param.TryGetBodyBinder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 86197, 86228);
                    return return_v;
                }


                bool
                f_10626_86253_86274(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol
                this_param)
                {
                    var return_v = this_param.IsExtern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 86253, 86274);
                    return return_v;
                }


                bool
                f_10626_86278_86322(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol
                method)
                {
                    var return_v = method.IsDefaultValueTypeConstructor();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 86278, 86322);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ImportChain?
                f_10626_86493_86515(Microsoft.CodeAnalysis.CSharp.ExecutableCodeBinder
                this_param)
                {
                    var return_v = this_param.ImportChain;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 86493, 86515);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10626_86563_86613(Microsoft.CodeAnalysis.CSharp.ExecutableCodeBinder
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindMethodBody(syntax, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 86563, 86613);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10626_86883_86905(Microsoft.CodeAnalysis.CSharp.ExecutableCodeBinder
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 86883, 86905);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LanguageVersion
                f_10626_86958_86985(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.LanguageVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 86958, 86985);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LanguageVersion
                f_10626_86989_87050(Microsoft.CodeAnalysis.CSharp.MessageID
                feature)
                {
                    var return_v = feature.RequiredVersion();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 86989, 87050);
                    return return_v;
                }


                bool
                f_10626_87077_87124(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = this_param.IsNullableAnalysisEnabledIn(method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 87077, 87124);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10626_87750_87769()
                {
                    var return_v = new Microsoft.CodeAnalysis.DiagnosticBag();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 87750, 87769);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10626_87203_87922(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol, Microsoft.CodeAnalysis.CSharp.BoundNode
                node, Microsoft.CodeAnalysis.CSharp.ExecutableCodeBinder
                binder, Microsoft.CodeAnalysis.CSharp.NullableWalker.VariableState
                initialState, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                createSnapshots, out Microsoft.CodeAnalysis.CSharp.NullableWalker.SnapshotManager
                snapshotManager, ref System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>?
                remappedSymbols)
                {
                    var return_v = NullableWalker.AnalyzeAndRewrite(compilation, (Microsoft.CodeAnalysis.CSharp.Symbol)symbol, node, (Microsoft.CodeAnalysis.CSharp.Binder)binder, initialState, diagnostics, createSnapshots: createSnapshots, out snapshotManager, ref remappedSymbols);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 87203, 87922);
                    return return_v;
                }


                int
                f_10626_88021_88443(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.CSharp.BoundNode
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                useConstructorExitWarnings, Microsoft.CodeAnalysis.CSharp.NullableWalker.VariableState
                initialNullableState, bool
                getFinalNullableState, out Microsoft.CodeAnalysis.CSharp.NullableWalker.VariableState?
                finalNullableState)
                {
                    NullableWalker.AnalyzeIfNeeded(compilation, method, node, diagnostics, useConstructorExitWarnings: useConstructorExitWarnings, initialNullableState, getFinalNullableState: getFinalNullableState, out finalNullableState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 88021, 88443);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.MethodBodySemanticModel.InitialState
                f_10626_88510_88636(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundNode
                bodyOpt, Microsoft.CodeAnalysis.CSharp.ExecutableCodeBinder
                binder, Microsoft.CodeAnalysis.CSharp.NullableWalker.SnapshotManager?
                snapshotManager, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>?
                remappedSymbols)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.MethodBodySemanticModel.InitialState(syntax, bodyOpt, binder, snapshotManager, remappedSymbols);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 88510, 88636);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10626_88669_88684(Microsoft.CodeAnalysis.CSharp.BoundNode
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 88669, 88684);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock?
                f_10626_88895_88916(Microsoft.CodeAnalysis.CSharp.BoundConstructorMethodBody
                this_param)
                {
                    var return_v = this_param.BlockBody;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 88895, 88916);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock?
                f_10626_88920_88946(Microsoft.CodeAnalysis.CSharp.BoundConstructorMethodBody
                this_param)
                {
                    var return_v = this_param.ExpressionBody;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 88920, 88946);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement?
                f_10626_88983_89006(Microsoft.CodeAnalysis.CSharp.BoundConstructorMethodBody
                this_param)
                {
                    var return_v = this_param.Initializer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 88983, 89006);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10626_89116_89139(Microsoft.CodeAnalysis.CSharp.BoundConstructorMethodBody
                this_param)
                {
                    var return_v = this_param.Initializer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 89116, 89139);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10626_89116_89150(Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 89116, 89150);
                    return return_v;
                }


                int
                f_10626_89080_89182(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.CSharp.BoundExpression
                initializerInvocation, Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                compilationState, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    ReportCtorInitializerCycles(method, initializerInvocation, compilationState, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 89080, 89182);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10626_89351_89369(Microsoft.CodeAnalysis.CSharp.BoundConstructorMethodBody
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 89351, 89369);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10626_89409_89432(Microsoft.CodeAnalysis.CSharp.BoundConstructorMethodBody
                this_param)
                {
                    var return_v = this_param.Initializer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 89409, 89432);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10626_89371_89433(Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                item)
                {
                    var return_v = ImmutableArray.Create<BoundStatement>((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 89371, 89433);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10626_89316_89434(Microsoft.CodeAnalysis.SyntaxNode
                syntax, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                statements)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundBlock(syntax, locals, statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 89316, 89434);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10626_89623_89641(Microsoft.CodeAnalysis.CSharp.BoundConstructorMethodBody
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 89623, 89641);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10626_89681_89704(Microsoft.CodeAnalysis.CSharp.BoundConstructorMethodBody
                this_param)
                {
                    var return_v = this_param.Initializer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 89681, 89704);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10626_89643_89711(Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                item1, Microsoft.CodeAnalysis.CSharp.BoundBlock
                item2)
                {
                    var return_v = ImmutableArray.Create<BoundStatement>((Microsoft.CodeAnalysis.CSharp.BoundStatement)item1, (Microsoft.CodeAnalysis.CSharp.BoundStatement)item2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 89643, 89711);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10626_89588_89712(Microsoft.CodeAnalysis.SyntaxNode
                syntax, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                statements)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundBlock(syntax, locals, statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 89588, 89712);
                    return return_v;
                }


                int
                f_10626_89990_90030(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 89990, 90030);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock?
                f_10626_90296_90320(Microsoft.CodeAnalysis.CSharp.BoundNonConstructorMethodBody
                this_param)
                {
                    var return_v = this_param.BlockBody;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 90296, 90320);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock?
                f_10626_90324_90353(Microsoft.CodeAnalysis.CSharp.BoundNonConstructorMethodBody
                this_param)
                {
                    var return_v = this_param.ExpressionBody;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 90324, 90353);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10626_90640_90655(Microsoft.CodeAnalysis.CSharp.BoundNode
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 90640, 90655);
                    return return_v;
                }


                System.Exception
                f_10626_90605_90656(Microsoft.CodeAnalysis.CSharp.BoundKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 90605, 90656);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10626_90777_90806(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol
                this_param)
                {
                    var return_v = this_param.AssociatedSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 90777, 90806);
                    return return_v;
                }


                bool
                f_10626_90889_90927(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                this_param)
                {
                    var return_v = this_param.IsAutoPropertyWithGetAccessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 90889, 90927);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10626_90984_91053(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol
                accessor)
                {
                    var return_v = MethodBodySynthesizer.ConstructAutoPropertyAccessorBody(accessor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 90984, 91053);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10626_91370_91397(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedInstanceConstructor
                symbol)
                {
                    var return_v = symbol.GetNonNullSyntaxNode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 91370, 91397);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                f_10626_91430_91502(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedInstanceConstructor
                topLevelMethod, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                compilationState, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory((Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)topLevelMethod, (Microsoft.CodeAnalysis.SyntaxNode)node, compilationState, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 91430, 91502);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10626_91533_91575()
                {
                    var return_v = ArrayBuilder<BoundStatement>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 91533, 91575);
                    return return_v;
                }


                int
                f_10626_91594_91656(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedInstanceConstructor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                factory, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                statements, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.GenerateMethodBodyStatements(factory, statements, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 91594, 91656);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10626_91719_91745(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 91719, 91745);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10626_91682_91746(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                statements)
                {
                    var return_v = BoundBlock.SynthesizedNoLocals((Microsoft.CodeAnalysis.SyntaxNode)syntax, statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 91682, 91746);
                    return return_v;
                }


                bool
                f_10626_91933_91955(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = method.IsConstructor();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 91933, 91955);
                    return return_v;
                }


                bool
                f_10626_91959_91986(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsImplicitlyDeclared;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 91959, 91986);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10626_92195_92226(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol)
                {
                    var return_v = GetSynthesizedEmptyBody((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 92195, 92226);
                    return return_v;
                }


                int
                f_10626_92054_92458(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.CSharp.BoundBlock
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                useConstructorExitWarnings, Microsoft.CodeAnalysis.CSharp.NullableWalker.VariableState
                initialNullableState, bool
                getFinalNullableState, out Microsoft.CodeAnalysis.CSharp.NullableWalker.VariableState?
                finalNullableState)
                {
                    NullableWalker.AnalyzeIfNeeded(compilation, method, (Microsoft.CodeAnalysis.CSharp.BoundNode)node, diagnostics, useConstructorExitWarnings: useConstructorExitWarnings, initialNullableState, getFinalNullableState: getFinalNullableState, out finalNullableState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 92054, 92458);
                    return 0;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10626_92494_92511(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 92494, 92511);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10626_92593_92652(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.CSharp.BoundBlock
                block)
                {
                    var return_v = MethodBodySynthesizer.ConstructDestructorBody(method, block);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 92593, 92652);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10626_92713_92791(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                compilationState, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = BindImplicitConstructorInitializerIfAny(method, compilationState, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 92713, 92791);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10626_93188_93233(Microsoft.CodeAnalysis.CSharp.BoundStatement
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 93188, 93233);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10626_93313_93364(Microsoft.CodeAnalysis.CSharp.BoundStatement
                item1, Microsoft.CodeAnalysis.CSharp.BoundBlock
                item2)
                {
                    var return_v = ImmutableArray.Create(item1, (Microsoft.CodeAnalysis.CSharp.BoundStatement)item2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 93313, 93364);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10626_93478_93507(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol)
                {
                    var return_v = symbol.GetNonNullSyntaxNode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 93478, 93507);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10626_93447_93520(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                statements)
                {
                    var return_v = BoundBlock.SynthesizedNoLocals((Microsoft.CodeAnalysis.SyntaxNode)syntax, statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 93447, 93520);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10626, 84780, 93532);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10626, 84780, 93532);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static BoundBlock GetSynthesizedEmptyBody(Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10626, 93544, 93713);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 93633, 93702);

                return f_10626_93640_93701(f_10626_93671_93700(symbol));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10626, 93544, 93713);

                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10626_93671_93700(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.GetNonNullSyntaxNode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 93671, 93700);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10626_93640_93701(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax, params Microsoft.CodeAnalysis.CSharp.BoundStatement[]
                statements)
                {
                    var return_v = BoundBlock.SynthesizedNoLocals((Microsoft.CodeAnalysis.SyntaxNode)syntax, statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 93640, 93701);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10626, 93544, 93713);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10626, 93544, 93713);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static BoundStatement BindImplicitConstructorInitializerIfAny(MethodSymbol method, TypeCompilationState compilationState, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10626, 93725, 95178);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 93906, 93960);

                f_10626_93906_93959(!f_10626_93920_93958(f_10626_93920_93941(method)));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 94053, 95139) || true) && (f_10626_94057_94074(method) == MethodKind.Constructor && (DynAbs.Tracing.TraceSender.Expression_True(10626, 94057, 94120) && f_10626_94104_94120_M(!method.IsExtern)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 94053, 95139);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 94154, 94200);

                    var
                    compilation = f_10626_94172_94199(method)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 94218, 94315);

                    var
                    initializerInvocation = f_10626_94246_94314(method, diagnostics, compilation)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 94335, 95124) || true) && (initializerInvocation != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 94335, 95124);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 94410, 94500);

                        f_10626_94410_94499(method, initializerInvocation, compilationState, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 94673, 94839);

                        var
                        constructorInitializer = new BoundExpressionStatement(initializerInvocation.Syntax, initializerInvocation) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => f_10626_94809_94836(method), 10626, 94702, 94838) }
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 94861, 95053);

                        f_10626_94861_95052(f_10626_94874_94908(initializerInvocation) || (DynAbs.Tracing.TraceSender.Expression_False(10626, 94874, 94961) || f_10626_94912_94961(constructorInitializer)), "Please keep this bound node in sync with BoundNodeExtensions.IsConstructorInitializer.");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 95075, 95105);

                        return constructorInitializer;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 94335, 95124);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 94053, 95139);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 95155, 95167);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10626, 93725, 95178);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10626_93920_93941(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 93920, 93941);
                    return return_v;
                }


                bool
                f_10626_93920_93958(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.IsDelegateType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 93920, 93958);
                    return return_v;
                }


                int
                f_10626_93906_93959(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 93906, 93959);
                    return 0;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10626_94057_94074(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 94057, 94074);
                    return return_v;
                }


                bool
                f_10626_94104_94120_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 94104, 94120);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10626_94172_94199(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 94172, 94199);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10626_94246_94314(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                constructor, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = BindImplicitConstructorInitializer(constructor, diagnostics, compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 94246, 94314);
                    return return_v;
                }


                int
                f_10626_94410_94499(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.CSharp.BoundExpression
                initializerInvocation, Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                compilationState, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    ReportCtorInitializerCycles(method, initializerInvocation, compilationState, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 94410, 94499);
                    return 0;
                }


                bool
                f_10626_94809_94836(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsImplicitlyDeclared;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 94809, 94836);
                    return return_v;
                }


                bool
                f_10626_94874_94908(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.HasAnyErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 94874, 94908);
                    return return_v;
                }


                bool
                f_10626_94912_94961(Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                statement)
                {
                    var return_v = statement.IsConstructorInitializer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 94912, 94961);
                    return return_v;
                }


                int
                f_10626_94861_95052(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 94861, 95052);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10626, 93725, 95178);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10626, 93725, 95178);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void ReportCtorInitializerCycles(MethodSymbol method, BoundExpression initializerInvocation, TypeCompilationState compilationState, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10626, 95190, 95890);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 95388, 95438);

                var
                ctorCall = initializerInvocation as BoundCall
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 95452, 95879) || true) && (ctorCall != null && (DynAbs.Tracing.TraceSender.Expression_True(10626, 95456, 95498) && f_10626_95476_95498_M(!ctorCall.HasAnyErrors)) && (DynAbs.Tracing.TraceSender.Expression_True(10626, 95456, 95527) && f_10626_95502_95517(ctorCall) != method) && (DynAbs.Tracing.TraceSender.Expression_True(10626, 95456, 95640) && f_10626_95531_95640(f_10626_95549_95579(f_10626_95549_95564(ctorCall)), f_10626_95581_95602(method), TypeCompareKind.ConsiderEverything2)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 95452, 95879);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 95764, 95864);

                    f_10626_95764_95863(                // Detect and report indirect cycles in the ctor-initializer call graph.
                                    compilationState, method, f_10626_95817_95832(ctorCall), ctorCall.Syntax, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 95452, 95879);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10626, 95190, 95890);

                bool
                f_10626_95476_95498_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 95476, 95498);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10626_95502_95517(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.Method;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 95502, 95517);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10626_95549_95564(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.Method;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 95549, 95564);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10626_95549_95579(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 95549, 95579);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10626_95581_95602(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 95581, 95602);
                    return return_v;
                }


                bool
                f_10626_95531_95640(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 95531, 95640);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10626_95817_95832(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.Method;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 95817, 95832);
                    return return_v;
                }


                int
                f_10626_95764_95863(Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method1, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method2, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.ReportCtorInitializerCycles(method1, method2, syntax, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 95764, 95863);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10626, 95190, 95890);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10626, 95190, 95890);
            }
        }

        internal static BoundExpression BindImplicitConstructorInitializer(
                    MethodSymbol constructor, DiagnosticBag diagnostics, CSharpCompilation compilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10626, 96372, 101624);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 96657, 96740);

                NamedTypeSymbol
                baseType = f_10626_96684_96739(f_10626_96684_96710(constructor))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 96756, 96841);

                SourceMemberMethodSymbol
                sourceConstructor = constructor as SourceMemberMethodSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 96855, 97012);

                f_10626_96855_97011(f_10626_96868_96897_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(sourceConstructor, 10626, 96868, 96897)?.SyntaxNode) is RecordDeclarationSyntax || (DynAbs.Tracing.TraceSender.Expression_False(10626, 96868, 97010) || f_10626_96928_97002_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(((ConstructorDeclarationSyntax)f_10626_96959_96988_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(sourceConstructor, 10626, 96959, 96988)?.SyntaxNode)), 10626, 96928, 97002)?.Initializer) == null));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 97605, 98206) || true) && ((object)baseType != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 97605, 98206);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 97667, 98191) || true) && (f_10626_97671_97691(baseType) == SpecialType.System_Object)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 97667, 98191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 97762, 97843);

                        return f_10626_97769_97842(constructor, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 97667, 98191);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 97667, 98191);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 97885, 98191) || true) && (f_10626_97889_97911(baseType) || (DynAbs.Tracing.TraceSender.Expression_False(10626, 97889, 97932) || f_10626_97915_97932(baseType)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 97885, 98191);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 98160, 98172);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 97885, 98191);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 97667, 98191);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 97605, 98206);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 98222, 98393) || true) && (constructor is SynthesizedRecordCopyCtor copyCtor)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 98222, 98393);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 98309, 98378);

                    return f_10626_98316_98377(copyCtor, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 98222, 98393);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 99222, 99241);

                Binder
                outerBinder
                = default(Binder);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 99257, 101196) || true) && ((object)sourceConstructor == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 99257, 101196);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 99460, 99528);

                    CSharpSyntaxNode
                    containerNode = f_10626_99493_99527(constructor)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 99546, 99631);

                    BinderFactory
                    binderFactory = f_10626_99576_99630(compilation, f_10626_99605_99629(containerNode))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 99651, 100077) || true) && (containerNode is RecordDeclarationSyntax recordDecl)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 99651, 100077);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 99748, 99810);

                        outerBinder = f_10626_99762_99809(binderFactory, recordDecl);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 99651, 100077);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 99651, 100077);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 99892, 99963);

                        SyntaxToken
                        bodyToken = f_10626_99916_99962(containerNode)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 99985, 100058);

                        outerBinder = f_10626_99999_100057(binderFactory, containerNode, bodyToken.Position);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 99651, 100077);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 99257, 101196);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 99257, 101196);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 100143, 100232);

                    BinderFactory
                    binderFactory = f_10626_100173_100231(compilation, f_10626_100202_100230(sourceConstructor))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 100252, 101181);

                    switch (f_10626_100260_100288(sourceConstructor))
                    {

                        case ConstructorDeclarationSyntax ctorDecl:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 100252, 101181);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 100789, 100851);

                            outerBinder = f_10626_100803_100850(binderFactory, f_10626_100827_100849(ctorDecl));
                            DynAbs.Tracing.TraceSender.TraceBreak(10626, 100877, 100883);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 100252, 101181);

                        case RecordDeclarationSyntax recordDecl:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 100252, 101181);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 100973, 101035);

                            outerBinder = f_10626_100987_101034(binderFactory, recordDecl);
                            DynAbs.Tracing.TraceSender.TraceBreak(10626, 101061, 101067);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 100252, 101181);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 100252, 101181);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 101125, 101162);

                            throw f_10626_101131_101161();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 100252, 101181);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 99257, 101196);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 101378, 101513);

                Binder
                initializerBinder = f_10626_101405_101512(outerBinder, BinderFlags.ConstructorInitializer, constructor)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 101529, 101613);

                return f_10626_101536_101612(initializerBinder, null, constructor, diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10626, 96372, 101624);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10626_96684_96710(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 96684, 96710);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10626_96684_96739(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.BaseTypeNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 96684, 96739);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10626_96868_96897_M(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 96868, 96897);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10626_96959_96988_M(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 96959, 96988);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorInitializerSyntax?
                f_10626_96928_97002_M(Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorInitializerSyntax?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 96928, 97002);
                    return return_v;
                }


                int
                f_10626_96855_97011(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 96855, 97011);
                    return 0;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10626_97671_97691(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 97671, 97691);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10626_97769_97842(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                constructor, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = GenerateBaseParameterlessConstructorInitializer(constructor, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 97769, 97842);
                    return return_v;
                }


                bool
                f_10626_97889_97911(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.IsErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 97889, 97911);
                    return return_v;
                }


                bool
                f_10626_97915_97932(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 97915, 97932);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10626_98316_98377(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedRecordCopyCtor
                constructor, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = GenerateBaseCopyConstructorInitializer(constructor, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 98316, 98377);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10626_99493_99527(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol)
                {
                    var return_v = symbol.GetNonNullSyntaxNode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 99493, 99527);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10626_99605_99629(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 99605, 99629);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinderFactory
                f_10626_99576_99630(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree)
                {
                    var return_v = this_param.GetBinderFactory(syntaxTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 99576, 99630);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10626_99762_99809(Microsoft.CodeAnalysis.CSharp.BinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.RecordDeclarationSyntax
                typeDecl)
                {
                    var return_v = this_param.GetInRecordBodyBinder(typeDecl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 99762, 99809);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10626_99916_99962(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                containerNode)
                {
                    var return_v = GetImplicitConstructorBodyToken(containerNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 99916, 99962);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10626_99999_100057(Microsoft.CodeAnalysis.CSharp.BinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node, int
                position)
                {
                    var return_v = this_param.GetBinder((Microsoft.CodeAnalysis.SyntaxNode)node, position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 99999, 100057);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10626_100202_100230(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 100202, 100230);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinderFactory
                f_10626_100173_100231(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree)
                {
                    var return_v = this_param.GetBinderFactory(syntaxTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 100173, 100231);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10626_100260_100288(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol
                this_param)
                {
                    var return_v = this_param.SyntaxNode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 100260, 100288);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
                f_10626_100827_100849(Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.ParameterList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 100827, 100849);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10626_100803_100850(Microsoft.CodeAnalysis.CSharp.BinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
                node)
                {
                    var return_v = this_param.GetBinder((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 100803, 100850);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10626_100987_101034(Microsoft.CodeAnalysis.CSharp.BinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.RecordDeclarationSyntax
                typeDecl)
                {
                    var return_v = this_param.GetInRecordBodyBinder(typeDecl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 100987, 101034);
                    return return_v;
                }


                System.Exception
                f_10626_101131_101161()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 101131, 101161);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10626_101405_101512(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BinderFlags
                flags, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                containing)
                {
                    var return_v = this_param.WithAdditionalFlagsAndContainingMemberOrLambda(flags, (Microsoft.CodeAnalysis.CSharp.Symbol)containing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 101405, 101512);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10626_101536_101612(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentListSyntax
                initializerArgumentListOpt, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                constructor, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindConstructorInitializer(initializerArgumentListOpt, constructor, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 101536, 101612);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10626, 96372, 101624);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10626, 96372, 101624);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static SyntaxToken GetImplicitConstructorBodyToken(CSharpSyntaxNode containerNode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10626, 101636, 101827);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 101751, 101816);

                return f_10626_101758_101815(((BaseTypeDeclarationSyntax)containerNode));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10626, 101636, 101827);

                Microsoft.CodeAnalysis.SyntaxToken
                f_10626_101758_101815(Microsoft.CodeAnalysis.CSharp.Syntax.BaseTypeDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.OpenBraceToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 101758, 101815);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10626, 101636, 101827);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10626, 101636, 101827);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static BoundCall GenerateBaseParameterlessConstructorInitializer(MethodSymbol constructor, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10626, 101839, 104777);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 101990, 102073);

                NamedTypeSymbol
                baseType = f_10626_102017_102072(f_10626_102017_102043(constructor))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 102087, 102123);

                MethodSymbol
                baseConstructor = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 102137, 102191);

                LookupResultKind
                resultKind = LookupResultKind.Viable
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 102205, 102316);

                Location
                diagnosticsLocation = (DynAbs.Tracing.TraceSender.Conditional_F1(10626, 102236, 102265) || ((constructor.Locations.IsEmpty && DynAbs.Tracing.TraceSender.Conditional_F2(10626, 102268, 102288)) || DynAbs.Tracing.TraceSender.Conditional_F3(10626, 102291, 102315))) ? NoLocation.Singleton : f_10626_102291_102312(constructor)[0]
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 102332, 102580);
                    foreach (MethodSymbol ctor in f_10626_102362_102391_I(f_10626_102362_102391(baseType)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 102332, 102580);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 102425, 102565) || true) && (f_10626_102429_102448(ctor) == 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 102425, 102565);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 102495, 102518);

                            baseConstructor = ctor;
                            DynAbs.Tracing.TraceSender.TraceBreak(10626, 102540, 102546);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 102425, 102565);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 102332, 102580);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10626, 1, 249);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10626, 1, 249);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 102699, 102918) || true) && ((object)baseConstructor == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 102699, 102918);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 102768, 102873);

                    f_10626_102768_102872(diagnostics, ErrorCode.ERR_BadCtorArgCount, diagnosticsLocation, baseType, 0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 102891, 102903);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 102699, 102918);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 102934, 103081) || true) && (f_10626_102938_103020(baseConstructor, diagnostics, diagnosticsLocation))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 102934, 103081);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 103054, 103066);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 102934, 103081);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 103200, 103223);

                bool
                hasErrors = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 103237, 103287);

                HashSet<DiagnosticInfo>
                useSiteDiagnostics = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 103301, 103629) || true) && (!f_10626_103306_103405(baseConstructor, f_10626_103354_103380(constructor), ref useSiteDiagnostics))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 103301, 103629);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 103439, 103518);

                    f_10626_103439_103517(diagnostics, ErrorCode.ERR_BadAccess, diagnosticsLocation, baseConstructor);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 103536, 103579);

                    resultKind = LookupResultKind.Inaccessible;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 103597, 103614);

                    hasErrors = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 103301, 103629);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 103645, 103790) || true) && (!f_10626_103650_103684(useSiteDiagnostics))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 103645, 103790);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 103718, 103775);

                    f_10626_103718_103774(diagnostics, diagnosticsLocation, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 103645, 103790);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 103806, 103867);

                CSharpSyntaxNode
                syntax = f_10626_103832_103866(constructor)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 103883, 104001);

                BoundExpression
                receiver = new BoundThisReference(syntax, f_10626_103941_103967(constructor)) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10626, 103910, 104000) }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 104015, 104766);

                return new BoundCall(
                                syntax: syntax,
                                receiverOpt: receiver,
                                method: baseConstructor,
                                arguments: ImmutableArray<BoundExpression>.Empty,
                                argumentNamesOpt: ImmutableArray<string>.Empty,
                                argumentRefKindsOpt: ImmutableArray<RefKind>.Empty,
                                isDelegateCall: false,
                                expanded: false,
                                invokedAsExtensionMethod: false,
                                argsToParamsOpt: ImmutableArray<int>.Empty,
                                defaultArguments: BitVector.Empty,
                                resultKind: resultKind,
                                type: f_10626_104654_104680(baseConstructor),
                                hasErrors: hasErrors)
                { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10626, 104022, 104765) };
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10626, 101839, 104777);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10626_102017_102043(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 102017, 102043);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10626_102017_102072(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.BaseTypeNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 102017, 102072);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10626_102291_102312(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 102291, 102312);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10626_102362_102391(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.InstanceConstructors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 102362, 102391);
                    return return_v;
                }


                int
                f_10626_102429_102448(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 102429, 102448);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10626_102362_102391_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 102362, 102391);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10626_102768_102872(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 102768, 102872);
                    return return_v;
                }


                bool
                f_10626_102938_103020(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = Binder.ReportUseSiteDiagnostics((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, diagnostics, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 102938, 103020);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10626_103354_103380(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 103354, 103380);
                    return return_v;
                }


                bool
                f_10626_103306_103405(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                within, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = AccessCheck.IsSymbolAccessible((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, within, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 103306, 103405);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10626_103439_103517(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 103439, 103517);
                    return return_v;
                }


                bool
                f_10626_103650_103684(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                hashSet)
                {
                    var return_v = hashSet.IsNullOrEmpty<Microsoft.CodeAnalysis.DiagnosticInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 103650, 103684);
                    return return_v;
                }


                bool
                f_10626_103718_103774(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = diagnostics.Add(location, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 103718, 103774);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10626_103832_103866(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol)
                {
                    var return_v = symbol.GetNonNullSyntaxNode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 103832, 103866);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10626_103941_103967(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 103941, 103967);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10626_104654_104680(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 104654, 104680);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10626, 101839, 104777);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10626, 101839, 104777);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static BoundCall GenerateBaseCopyConstructorInitializer(SynthesizedRecordCopyCtor constructor, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10626, 104789, 106928);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 104943, 105003);

                NamedTypeSymbol
                containingType = f_10626_104976_105002(constructor)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 105017, 105088);

                NamedTypeSymbol
                baseType = f_10626_105044_105087(containingType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 105102, 105169);

                Location
                diagnosticsLocation = constructor.Locations.FirstOrNone()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 105185, 105235);

                HashSet<DiagnosticInfo>
                useSiteDiagnostics = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 105249, 105376);

                MethodSymbol
                baseConstructor = f_10626_105280_105375(baseType, containingType, ref useSiteDiagnostics)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 105392, 105588) || true) && (baseConstructor is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 105392, 105588);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 105453, 105543);

                    f_10626_105453_105542(diagnostics, ErrorCode.ERR_NoCopyConstructorInBaseType, diagnosticsLocation, baseType);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 105561, 105573);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 105392, 105588);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 105604, 105751) || true) && (f_10626_105608_105690(baseConstructor, diagnostics, diagnosticsLocation))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 105604, 105751);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 105724, 105736);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 105604, 105751);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 105767, 105912) || true) && (!f_10626_105772_105806(useSiteDiagnostics))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10626, 105767, 105912);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 105840, 105897);

                    f_10626_105840_105896(diagnostics, diagnosticsLocation, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10626, 105767, 105912);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 105928, 105989);

                CSharpSyntaxNode
                syntax = f_10626_105954_105988(constructor)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 106003, 106121);

                BoundExpression
                receiver = new BoundThisReference(syntax, f_10626_106061_106087(constructor)) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10626, 106030, 106120) }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 106135, 106216);

                BoundExpression
                argument = f_10626_106162_106215(syntax, f_10626_106189_106211(constructor)[0])
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 106232, 106917);

                return new BoundCall(
                                syntax: syntax,
                                receiverOpt: receiver,
                                method: baseConstructor,
                                arguments: f_10626_106397_106428(argument),
                                argumentNamesOpt: default,
                                argumentRefKindsOpt: default,
                                isDelegateCall: false,
                                expanded: false,
                                invokedAsExtensionMethod: false,
                                argsToParamsOpt: default,
                                defaultArguments: default,
                                resultKind: LookupResultKind.Viable,
                                type: f_10626_106809_106835(baseConstructor),
                                hasErrors: false)
                { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10626, 106239, 106916) };
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10626, 104789, 106928);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10626_104976_105002(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedRecordCopyCtor
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 104976, 105002);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10626_105044_105087(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.BaseTypeNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 105044, 105087);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10626_105280_105375(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                containingType, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                within, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = SynthesizedRecordCopyCtor.FindCopyConstructor(containingType, within, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 105280, 105375);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10626_105453_105542(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 105453, 105542);
                    return return_v;
                }


                bool
                f_10626_105608_105690(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = Binder.ReportUseSiteDiagnostics((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, diagnostics, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 105608, 105690);
                    return return_v;
                }


                bool
                f_10626_105772_105806(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                hashSet)
                {
                    var return_v = hashSet.IsNullOrEmpty<Microsoft.CodeAnalysis.DiagnosticInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 105772, 105806);
                    return return_v;
                }


                bool
                f_10626_105840_105896(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = diagnostics.Add(location, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 105840, 105896);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10626_105954_105988(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedRecordCopyCtor
                symbol)
                {
                    var return_v = symbol.GetNonNullSyntaxNode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 105954, 105988);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10626_106061_106087(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedRecordCopyCtor
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 106061, 106087);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10626_106189_106211(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedRecordCopyCtor
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 106189, 106211);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundParameter
                f_10626_106162_106215(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                parameterSymbol)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundParameter((Microsoft.CodeAnalysis.SyntaxNode)syntax, parameterSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 106162, 106215);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10626_106397_106428(Microsoft.CodeAnalysis.CSharp.BoundExpression
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 106397, 106428);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10626_106809_106835(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10626, 106809, 106835);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10626, 104789, 106928);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10626, 104789, 106928);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Cci.DebugSourceDocument CreateDebugDocumentForFile(string normalizedPath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10626, 106940, 107165);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 107053, 107154);

                return f_10626_107060_107153(normalizedPath, Cci.DebugSourceDocument.CorSymLanguageTypeCSharp);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10626, 106940, 107165);

                Microsoft.Cci.DebugSourceDocument
                f_10626_107060_107153(string
                location, System.Guid
                language)
                {
                    var return_v = new Microsoft.Cci.DebugSourceDocument(location, language);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 107060, 107153);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10626, 106940, 107165);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10626, 106940, 107165);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool PassesFilter(Predicate<Symbol> filterOpt, Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10626, 107177, 107337);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10626, 107278, 107326);

                return (filterOpt == null) || (DynAbs.Tracing.TraceSender.Expression_False(10626, 107285, 107325) || f_10626_107308_107325(filterOpt, symbol));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10626, 107177, 107337);

                bool
                f_10626_107308_107325(System.Predicate<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                obj)
                {
                    var return_v = this_param.Invoke(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 107308, 107325);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10626, 107177, 107337);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10626, 107177, 107337);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static MethodCompiler()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10626, 870, 107344);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10626, 870, 107344);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10626, 870, 107344);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10626, 870, 107344);

        int
        f_10626_4875_4908(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 4875, 4908);
            return 0;
        }


        int
        f_10626_4923_4956(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 4923, 4956);
            return 0;
        }


        int
        f_10626_5349_5391(Microsoft.CodeAnalysis.CSharp.MethodCompiler
        this_param, bool
        arg)
        {
            this_param.SetGlobalErrorIfTrue(arg);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10626, 5349, 5391);
            return 0;
        }

    }
}
