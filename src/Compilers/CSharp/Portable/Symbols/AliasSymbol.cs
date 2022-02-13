// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed class AliasSymbol : Symbol
    {
        private readonly SyntaxToken _aliasName;

        private readonly Binder _binder;

        private SymbolCompletionState _state;

        private NamespaceOrTypeSymbol? _aliasTarget;

        private readonly ImmutableArray<Location> _locations;

        private readonly NameSyntax? _aliasTargetName;

        private readonly bool _isExtern;

        private DiagnosticBag? _aliasTargetDiagnostics;

        private AliasSymbol(Binder binder, NamespaceOrTypeSymbol target, SyntaxToken aliasName, ImmutableArray<Location> locations)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10088, 3230, 3582);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10088, 2815, 2822);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10088, 2913, 2925);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10088, 3102, 3118);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10088, 3151, 3160);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10088, 3194, 3217);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10088, 3378, 3401);

                _aliasName = aliasName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10088, 3415, 3438);

                _locations = locations;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10088, 3452, 3474);

                _aliasTarget = target;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10088, 3488, 3505);

                _binder = binder;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10088, 3519, 3571);

                _state.NotePartComplete(CompletionPart.AliasTarget);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10088, 3230, 3582);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10088, 3230, 3582);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10088, 3230, 3582);
            }
        }

        private AliasSymbol(Binder binder, SyntaxToken aliasName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10088, 3594, 3815);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10088, 2815, 2822);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10088, 2913, 2925);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10088, 3102, 3118);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10088, 3151, 3160);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10088, 3194, 3217);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10088, 3676, 3699);

                _aliasName = aliasName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10088, 3713, 3773);

                _locations = f_10088_3726_3772(aliasName.GetLocation());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10088, 3787, 3804);

                _binder = binder;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10088, 3594, 3815);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10088, 3594, 3815);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10088, 3594, 3815);
            }
        }

        internal AliasSymbol(Binder binder, NameSyntax name, NameEqualsSyntax alias)
        : this(f_10088_3924_3930_C(binder), f_10088_3932_3953(f_10088_3932_3942(alias)))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10088, 3827, 4146);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10088, 3979, 4039);

                f_10088_3979_4038(f_10088_3992_4037(f_10088_3992_4003(name), SyntaxKind.UsingDirective));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10088, 4053, 4095);

                f_10088_4053_4094(f_10088_4066_4077(name) == f_10088_4081_4093(alias));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10088, 4111, 4135);

                _aliasTargetName = name;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10088, 3827, 4146);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10088, 3827, 4146);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10088, 3827, 4146);
            }
        }

        internal AliasSymbol(Binder binder, ExternAliasDirectiveSyntax syntax)
        : this(f_10088_4249_4255_C(binder), f_10088_4257_4274(syntax))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10088, 4158, 4328);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10088, 4300, 4317);

                _isExtern = true;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10088, 4158, 4328);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10088, 4158, 4328);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10088, 4158, 4328);
            }
        }

        internal static AliasSymbol CreateGlobalNamespaceAlias(NamespaceSymbol globalNamespace, Binder globalNamespaceBinder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10088, 4572, 4996);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10088, 4714, 4865);

                SyntaxToken
                aliasName = f_10088_4738_4864(f_10088_4763_4789(), SyntaxKind.GlobalKeyword, "global", "global", f_10088_4837_4863())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10088, 4879, 4985);

                return f_10088_4886_4984(globalNamespaceBinder, globalNamespace, aliasName, ImmutableArray<Location>.Empty);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10088, 4572, 4996);

                Microsoft.CodeAnalysis.SyntaxTriviaList
                f_10088_4763_4789()
                {
                    var return_v = SyntaxFactory.TriviaList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10088, 4763, 4789);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTriviaList
                f_10088_4837_4863()
                {
                    var return_v = SyntaxFactory.TriviaList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10088, 4837, 4863);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10088_4738_4864(Microsoft.CodeAnalysis.SyntaxTriviaList
                leading, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                contextualKind, string
                text, string
                valueText, Microsoft.CodeAnalysis.SyntaxTriviaList
                trailing)
                {
                    var return_v = SyntaxFactory.Identifier(leading, contextualKind, text, valueText, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10088, 4738, 4864);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol
                f_10088_4886_4984(Microsoft.CodeAnalysis.CSharp.Binder
                binder, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                target, Microsoft.CodeAnalysis.SyntaxToken
                aliasName, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                locations)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol(binder, (Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol)target, aliasName, locations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10088, 4886, 4984);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10088, 4572, 4996);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10088, 4572, 4996);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static AliasSymbol CreateCustomDebugInfoAlias(NamespaceOrTypeSymbol targetSymbol, SyntaxToken aliasToken, Binder binder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10088, 5008, 5279);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10088, 5162, 5268);

                return f_10088_5169_5267(binder, targetSymbol, aliasToken, f_10088_5219_5266(aliasToken.GetLocation()));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10088, 5008, 5279);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10088_5219_5266(Microsoft.CodeAnalysis.Location
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10088, 5219, 5266);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol
                f_10088_5169_5267(Microsoft.CodeAnalysis.CSharp.Binder
                binder, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                target, Microsoft.CodeAnalysis.SyntaxToken
                aliasName, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                locations)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol(binder, target, aliasName, locations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10088, 5169, 5267);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10088, 5008, 5279);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10088, 5008, 5279);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal AliasSymbol ToNewSubmission(CSharpCompilation compilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10088, 5291, 6236);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10088, 5383, 5430);

                f_10088_5383_5429(f_10088_5396_5428(f_10088_5396_5415(_binder)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10088, 5629, 5691);

                var
                previousTarget = f_10088_5650_5690(this, basesBeingResolved: null)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10088, 5705, 5813) || true) && (f_10088_5709_5728(previousTarget) != SymbolKind.Namespace)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10088, 5705, 5813);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10088, 5786, 5798);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10088, 5705, 5813);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10088, 5829, 5887);

                var
                expandedGlobalNamespace = f_10088_5859_5886(compilation)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10088, 5901, 6025);

                var
                expandedNamespace = f_10088_5925_6024(previousTarget, expandedGlobalNamespace)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10088, 6039, 6137);

                var
                binder = f_10088_6052_6136(expandedGlobalNamespace, f_10088_6099_6135(compilation))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10088, 6151, 6225);

                return f_10088_6158_6224(binder, expandedNamespace, _aliasName, _locations);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10088, 5291, 6236);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10088_5396_5415(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10088, 5396, 5415);
                    return return_v;
                }


                bool
                f_10088_5396_5428(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.IsSubmission;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10088, 5396, 5428);
                    return return_v;
                }


                int
                f_10088_5383_5429(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10088, 5383, 5429);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                f_10088_5650_5690(Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol
                this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>?
                basesBeingResolved)
                {
                    var return_v = this_param.GetAliasTarget(basesBeingResolved: basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10088, 5650, 5690);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10088_5709_5728(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10088, 5709, 5728);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_10088_5859_5886(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.GlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10088, 5859, 5886);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_10088_5925_6024(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                originalNamespace, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                expandedGlobalNamespace)
                {
                    var return_v = Imports.ExpandPreviousSubmissionNamespace((Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol)originalNamespace, expandedGlobalNamespace);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10088, 5925, 6024);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BuckStopsHereBinder
                f_10088_6099_6135(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BuckStopsHereBinder(compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10088, 6099, 6135);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.InContainerBinder
                f_10088_6052_6136(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                container, Microsoft.CodeAnalysis.CSharp.BuckStopsHereBinder
                next)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.InContainerBinder((Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol)container, (Microsoft.CodeAnalysis.CSharp.Binder)next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10088, 6052, 6136);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol
                f_10088_6158_6224(Microsoft.CodeAnalysis.CSharp.InContainerBinder
                binder, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                target, Microsoft.CodeAnalysis.SyntaxToken
                aliasName, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                locations)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol((Microsoft.CodeAnalysis.CSharp.Binder)binder, (Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol)target, aliasName, locations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10088, 6158, 6224);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10088, 5291, 6236);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10088, 5291, 6236);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10088, 6300, 6379);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10088, 6336, 6364);

                    return _aliasName.ValueText;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10088, 6300, 6379);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10088, 6248, 6390);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10088, 6248, 6390);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override SymbolKind Kind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10088, 6458, 6533);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10088, 6494, 6518);

                    return SymbolKind.Alias;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10088, 6458, 6533);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10088, 6402, 6544);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10088, 6402, 6544);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public NamespaceOrTypeSymbol Target
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10088, 6785, 6884);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10088, 6821, 6869);

                    return f_10088_6828_6868(this, basesBeingResolved: null);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10088, 6785, 6884);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                    f_10088_6828_6868(Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol
                    this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>?
                    basesBeingResolved)
                    {
                        var return_v = this_param.GetAliasTarget(basesBeingResolved: basesBeingResolved);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10088, 6828, 6868);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10088, 6725, 6895);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10088, 6725, 6895);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<Location> Locations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10088, 6982, 7051);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10088, 7018, 7036);

                    return _locations;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10088, 6982, 7051);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10088, 6907, 7062);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10088, 6907, 7062);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<SyntaxReference> DeclaringSyntaxReferences
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10088, 7172, 7298);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10088, 7208, 7283);

                    return f_10088_7215_7282(_locations);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10088, 7172, 7298);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxReference>
                    f_10088_7215_7282(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                    locations)
                    {
                        var return_v = GetDeclaringSyntaxReferenceHelper<UsingDirectiveSyntax>(locations);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10088, 7215, 7282);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10088, 7074, 7309);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10088, 7074, 7309);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsExtern
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10088, 7375, 7443);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10088, 7411, 7428);

                    return _isExtern;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10088, 7375, 7443);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10088, 7321, 7454);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10088, 7321, 7454);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsSealed
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10088, 7520, 7584);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10088, 7556, 7569);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10088, 7520, 7584);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10088, 7466, 7595);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10088, 7466, 7595);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsAbstract
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10088, 7663, 7727);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10088, 7699, 7712);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10088, 7663, 7727);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10088, 7607, 7738);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10088, 7607, 7738);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsOverride
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10088, 7804, 7868);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10088, 7840, 7853);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10088, 7804, 7868);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10088, 7748, 7879);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10088, 7748, 7879);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsVirtual
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10088, 7946, 8010);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10088, 7982, 7995);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10088, 7946, 8010);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10088, 7891, 8021);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10088, 7891, 8021);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsStatic
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10088, 8087, 8151);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10088, 8123, 8136);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10088, 8087, 8151);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10088, 8033, 8162);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10088, 8033, 8162);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override ObsoleteAttributeData? ObsoleteAttributeData
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10088, 8536, 8556);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10088, 8542, 8554);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10088, 8536, 8556);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10088, 8442, 8567);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10088, 8442, 8567);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10088, 8655, 8741);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10088, 8691, 8726);

                    return Accessibility.NotApplicable;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10088, 8655, 8741);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10088, 8579, 8752);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10088, 8579, 8752);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override Symbol? ContainingSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10088, 9206, 9297);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10088, 9242, 9282);

                    return f_10088_9249_9281(_binder);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10088, 9206, 9297);

                    Microsoft.CodeAnalysis.CSharp.Symbol?
                    f_10088_9249_9281(Microsoft.CodeAnalysis.CSharp.Binder
                    this_param)
                    {
                        var return_v = this_param.ContainingMemberOrLambda;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10088, 9249, 9281);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10088, 9141, 9308);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10088, 9141, 9308);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override TResult Accept<TArg, TResult>(CSharpSymbolVisitor<TArg, TResult> visitor, TArg a)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10088, 9320, 9490);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10088, 9444, 9479);

                return f_10088_9451_9478<TResult, TArg>(visitor, this, a);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10088, 9320, 9490);

                TResult
                f_10088_9451_9478<TResult, TArg>(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor<TArg, TResult>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol
                symbol, TArg
                argument)
                {
                    var return_v = this_param.VisitAlias(symbol, argument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10088, 9451, 9478);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10088, 9320, 9490);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10088, 9320, 9490);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override void Accept(CSharpSymbolVisitor visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10088, 9502, 9619);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10088, 9583, 9608);

                f_10088_9583_9607(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10088, 9502, 9619);

                int
                f_10088_9583_9607(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol
                symbol)
                {
                    this_param.VisitAlias(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10088, 9583, 9607);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10088, 9502, 9619);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10088, 9502, 9619);
            }
        }

        public override TResult Accept<TResult>(CSharpSymbolVisitor<TResult> visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10088, 9631, 9776);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10088, 9733, 9765);

                return f_10088_9740_9764<TResult>(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10088, 9631, 9776);

                TResult
                f_10088_9740_9764<TResult>(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor<TResult>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol
                symbol)
                {
                    var return_v = this_param.VisitAlias(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10088, 9740, 9764);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10088, 9631, 9776);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10088, 9631, 9776);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal NamespaceOrTypeSymbol GetAliasTarget(ConsList<TypeSymbol>? basesBeingResolved)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10088, 9862, 11801);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10088, 9974, 11753) || true) && (!_state.HasComplete(CompletionPart.AliasTarget))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10088, 9974, 11753);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10088, 10262, 10311);

                    var
                    newDiagnostics = f_10088_10283_10310()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10088, 10331, 10545);

                    NamespaceOrTypeSymbol
                    symbol = (DynAbs.Tracing.TraceSender.Conditional_F1(10088, 10362, 10375) || ((f_10088_10362_10375(this) && DynAbs.Tracing.TraceSender.Conditional_F2(10088, 10399, 10439)) || DynAbs.Tracing.TraceSender.Conditional_F3(10088, 10463, 10544))) ? f_10088_10399_10439(this, newDiagnostics) : f_10088_10463_10544(_binder, _aliasTargetName, newDiagnostics, basesBeingResolved)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10088, 10565, 11738) || true) && ((object?)f_10088_10578_10637(ref _aliasTarget, symbol, null) == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10088, 10565, 11738);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10088, 11015, 11100);

                        bool
                        won = f_10088_11026_11091(ref _aliasTargetDiagnostics, newDiagnostics) == null
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10088, 11122, 11200);

                        f_10088_11122_11199(won, "Only one thread can win the alias target CompareExchange");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10088, 11224, 11276);

                        _state.NotePartComplete(CompletionPart.AliasTarget);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10088, 10565, 11738);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10088, 10565, 11738);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10088, 11491, 11513);

                        f_10088_11491_11512(newDiagnostics);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10088, 11639, 11719);

                        _state.SpinWaitComplete(CompletionPart.AliasTarget, default(CancellationToken));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10088, 10565, 11738);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10088, 9974, 11753);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10088, 11769, 11790);

                return _aliasTarget!;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10088, 9862, 11801);

                Microsoft.CodeAnalysis.DiagnosticBag
                f_10088_10283_10310()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10088, 10283, 10310);
                    return return_v;
                }


                bool
                f_10088_10362_10375(Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol
                this_param)
                {
                    var return_v = this_param.IsExtern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10088, 10362, 10375);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_10088_10399_10439(Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.ResolveExternAliasTarget(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10088, 10399, 10439);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                f_10088_10463_10544(Microsoft.CodeAnalysis.CSharp.Binder
                binder, Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax?
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>?
                basesBeingResolved)
                {
                    var return_v = ResolveAliasTarget(binder, syntax, diagnostics, basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10088, 10463, 10544);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol?
                f_10088_10578_10637(ref Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol?
                location1, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                value, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol?
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10088, 10578, 10637);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag?
                f_10088_11026_11091(ref Microsoft.CodeAnalysis.DiagnosticBag?
                location1, Microsoft.CodeAnalysis.DiagnosticBag
                value)
                {
                    var return_v = Interlocked.Exchange(ref location1, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10088, 11026, 11091);
                    return return_v;
                }


                int
                f_10088_11122_11199(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10088, 11122, 11199);
                    return 0;
                }


                int
                f_10088_11491_11512(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10088, 11491, 11512);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10088, 9862, 11801);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10088, 9862, 11801);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal DiagnosticBag AliasTargetDiagnostics
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10088, 11883, 12074);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10088, 11919, 11940);

                    f_10088_11919_11939(this, null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10088, 11958, 12010);

                    f_10088_11958_12009(_aliasTargetDiagnostics != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10088, 12028, 12059);

                    return _aliasTargetDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10088, 11883, 12074);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                    f_10088_11919_11939(Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol
                    this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>?
                    basesBeingResolved)
                    {
                        var return_v = this_param.GetAliasTarget(basesBeingResolved);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10088, 11919, 11939);
                        return return_v;
                    }


                    int
                    f_10088_11958_12009(bool
                    b)
                    {
                        RoslynDebug.Assert(b);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10088, 11958, 12009);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10088, 11813, 12085);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10088, 11813, 12085);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal void CheckConstraints(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10088, 12097, 12572);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10088, 12179, 12218);

                var
                target = f_10088_12192_12203(this) as TypeSymbol
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10088, 12232, 12561) || true) && ((object?)target != null && (DynAbs.Tracing.TraceSender.Expression_True(10088, 12236, 12284) && _locations.Length > 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10088, 12232, 12561);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10088, 12318, 12370);

                    var
                    corLibrary = f_10088_12335_12369(f_10088_12335_12358(this))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10088, 12388, 12438);

                    var
                    conversions = f_10088_12406_12437(corLibrary)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10088, 12456, 12546);

                    f_10088_12456_12545(target, f_10088_12483_12503(), conversions, _locations[0], diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10088, 12232, 12561);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10088, 12097, 12572);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                f_10088_12192_12203(Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol
                this_param)
                {
                    var return_v = this_param.Target;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10088, 12192, 12203);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10088_12335_12358(Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10088, 12335, 12358);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10088_12335_12369(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.CorLibrary;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10088, 12335, 12369);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.TypeConversions
                f_10088_12406_12437(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                corLibrary)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.TypeConversions(corLibrary);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10088, 12406, 12437);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10088_12483_12503()
                {
                    var return_v = DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10088, 12483, 12503);
                    return return_v;
                }


                int
                f_10088_12456_12545(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.TypeConversions
                conversions, Microsoft.CodeAnalysis.Location
                location, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    type.CheckAllConstraints(compilation, (Microsoft.CodeAnalysis.CSharp.ConversionsBase)conversions, location, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10088, 12456, 12545);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10088, 12097, 12572);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10088, 12097, 12572);
            }
        }

        private NamespaceSymbol ResolveExternAliasTarget(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10088, 12584, 13038);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10088, 12684, 12708);

                NamespaceSymbol?
                target
                = default(NamespaceSymbol?);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10088, 12722, 12944) || true) && (!f_10088_12727_12801(f_10088_12727_12746(_binder), _aliasName.ValueText, out target))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10088, 12722, 12944);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10088, 12835, 12929);

                    f_10088_12835_12928(diagnostics, ErrorCode.ERR_BadExternAlias, _aliasName.GetLocation(), _aliasName.ValueText);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10088, 12722, 12944);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10088, 12960, 12997);

                f_10088_12960_12996(target is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10088, 13013, 13027);

                return target;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10088, 12584, 13038);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10088_12727_12746(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10088, 12727, 12746);
                    return return_v;
                }


                bool
                f_10088_12727_12801(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, string
                aliasName, out Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol?
                @namespace)
                {
                    var return_v = this_param.GetExternAliasTarget(aliasName, out @namespace);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10088, 12727, 12801);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10088_12835_12928(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10088, 12835, 12928);
                    return return_v;
                }


                int
                f_10088_12960_12996(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10088, 12960, 12996);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10088, 12584, 13038);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10088, 12584, 13038);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static NamespaceOrTypeSymbol ResolveAliasTarget(Binder binder, NameSyntax? syntax, DiagnosticBag diagnostics, ConsList<TypeSymbol>? basesBeingResolved)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10088, 13050, 13499);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10088, 13234, 13360);

                var
                declarationBinder = f_10088_13258_13359(binder, BinderFlags.SuppressConstraintChecks | BinderFlags.SuppressObsoleteChecks)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10088, 13374, 13488);

                return f_10088_13381_13465(declarationBinder, syntax, diagnostics, basesBeingResolved).NamespaceOrTypeSymbol;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10088, 13050, 13499);

                Microsoft.CodeAnalysis.CSharp.Binder
                f_10088_13258_13359(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BinderFlags
                flags)
                {
                    var return_v = this_param.WithAdditionalFlags(flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10088, 13258, 13359);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder.NamespaceOrTypeOrAliasSymbolWithAnnotations
                f_10088_13381_13465(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax?
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>?
                basesBeingResolved)
                {
                    var return_v = this_param.BindNamespaceOrTypeSymbol((Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax?)syntax, diagnostics, basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10088, 13381, 13465);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10088, 13050, 13499);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10088, 13050, 13499);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool Equals(Symbol? obj, TypeCompareKind compareKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10088, 13511, 14101);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10088, 13605, 13696) || true) && (f_10088_13609_13635(this, obj))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10088, 13605, 13696);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10088, 13669, 13681);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10088, 13605, 13696);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10088, 13712, 13804) || true) && (f_10088_13716_13742(obj, null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10088, 13712, 13804);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10088, 13776, 13789);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10088, 13712, 13804);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10088, 13820, 13860);

                AliasSymbol?
                other = obj as AliasSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10088, 13876, 14090);

                return (object?)other != null && (DynAbs.Tracing.TraceSender.Expression_True(10088, 13883, 13999) && f_10088_13926_13999(this.Locations.FirstOrDefault(), other.Locations.FirstOrDefault())) && (DynAbs.Tracing.TraceSender.Expression_True(10088, 13883, 14089) && f_10088_14020_14089(f_10088_14020_14043(this), f_10088_14051_14075(other), compareKind));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10088, 13511, 14101);

                bool
                f_10088_13609_13635(Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbol?
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object?)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10088, 13609, 13635);
                    return return_v;
                }


                bool
                f_10088_13716_13742(Microsoft.CodeAnalysis.CSharp.Symbol?
                objA, object?
                objB)
                {
                    var return_v = ReferenceEquals((object?)objA, objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10088, 13716, 13742);
                    return return_v;
                }


                bool
                f_10088_13926_13999(Microsoft.CodeAnalysis.Location?
                objA, Microsoft.CodeAnalysis.Location?
                objB)
                {
                    var return_v = Equals((object?)objA, (object?)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10088, 13926, 13999);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10088_14020_14043(Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10088, 14020, 14043);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10088_14051_14075(Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10088, 14051, 14075);
                    return return_v;
                }


                bool
                f_10088_14020_14089(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                other, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals((Microsoft.CodeAnalysis.CSharp.Symbol)other, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10088, 14020, 14089);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10088, 13511, 14101);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10088, 13511, 14101);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10088, 14113, 14336);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10088, 14171, 14325) || true) && (this.Locations.Length > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10088, 14171, 14325);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10088, 14219, 14263);

                    return f_10088_14226_14262(this.Locations.First());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10088, 14171, 14325);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10088, 14171, 14325);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10088, 14299, 14325);

                    return f_10088_14306_14324(f_10088_14306_14310());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10088, 14171, 14325);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10088, 14113, 14336);

                int
                f_10088_14226_14262(Microsoft.CodeAnalysis.Location
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10088, 14226, 14262);
                    return return_v;
                }


                string
                f_10088_14306_14310()
                {
                    var return_v = Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10088, 14306, 14310);
                    return return_v;
                }


                int
                f_10088_14306_14324(string
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10088, 14306, 14324);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10088, 14113, 14336);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10088, 14113, 14336);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool RequiresCompletion
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10088, 14414, 14434);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10088, 14420, 14432);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10088, 14414, 14434);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10088, 14348, 14445);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10088, 14348, 14445);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override ISymbol CreateISymbol()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10088, 14457, 14576);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10088, 14524, 14565);

                return f_10088_14531_14564(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10088, 14457, 14576);

                Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.AliasSymbol
                f_10088_14531_14564(Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol
                underlying)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.AliasSymbol(underlying);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10088, 14531, 14564);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10088, 14457, 14576);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10088, 14457, 14576);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static AliasSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10088, 2682, 14583);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10088, 2682, 14583);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10088, 2682, 14583);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10088, 2682, 14583);

        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
        f_10088_3726_3772(Microsoft.CodeAnalysis.Location
        item)
        {
            var return_v = ImmutableArray.Create(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10088, 3726, 3772);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
        f_10088_3932_3942(Microsoft.CodeAnalysis.CSharp.Syntax.NameEqualsSyntax
        this_param)
        {
            var return_v = this_param.Name;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10088, 3932, 3942);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SyntaxToken
        f_10088_3932_3953(Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
        this_param)
        {
            var return_v = this_param.Identifier;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10088, 3932, 3953);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
        f_10088_3992_4003(Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
        this_param)
        {
            var return_v = this_param.Parent;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10088, 3992, 4003);
            return return_v;
        }


        bool
        f_10088_3992_4037(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
        node, Microsoft.CodeAnalysis.CSharp.SyntaxKind
        kind)
        {
            var return_v = node.IsKind(kind);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10088, 3992, 4037);
            return return_v;
        }


        int
        f_10088_3979_4038(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10088, 3979, 4038);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
        f_10088_4066_4077(Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
        this_param)
        {
            var return_v = this_param.Parent;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10088, 4066, 4077);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
        f_10088_4081_4093(Microsoft.CodeAnalysis.CSharp.Syntax.NameEqualsSyntax
        this_param)
        {
            var return_v = this_param.Parent;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10088, 4081, 4093);
            return return_v;
        }


        int
        f_10088_4053_4094(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10088, 4053, 4094);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Binder
        f_10088_3924_3930_C(Microsoft.CodeAnalysis.CSharp.Binder
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10088, 3827, 4146);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SyntaxToken
        f_10088_4257_4274(Microsoft.CodeAnalysis.CSharp.Syntax.ExternAliasDirectiveSyntax
        this_param)
        {
            var return_v = this_param.Identifier;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10088, 4257, 4274);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Binder
        f_10088_4249_4255_C(Microsoft.CodeAnalysis.CSharp.Binder
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10088, 4158, 4328);
            return return_v;
        }

    }
}
